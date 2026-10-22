Imports Microsoft.Data.Sqlite
Imports System.Globalization

Public Class UC_Compras

    ' Método para poblar el ComboBox de Vendedores / Proveedores, activar sugerencias al escribir y seleccionar "General" (Id_v = 1)
    Private Sub CargarVendedores()
        Try
            Dim dt As DataTable = ConexionBD.ObtenerDatos("SELECT Id_v, nom_v FROM Vendedores")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                CB_Vendedor.DataSource = dt
                CB_Vendedor.DisplayMember = "nom_v"
                CB_Vendedor.ValueMember = "Id_v"

                ' Habilitar sugerencias dinámicas e inicio/coincidencia al escribir
                CB_Vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                CB_Vendedor.AutoCompleteSource = AutoCompleteSource.ListItems

                ' Seleccionar por defecto el ID 1 ("General") si existe en la lista
                CB_Vendedor.SelectedValue = 1
                If CB_Vendedor.SelectedIndex = -1 AndAlso CB_Vendedor.Items.Count > 0 Then
                    CB_Vendedor.SelectedIndex = 0
                End If
            End If
        Catch ex As Exception
            ' Manejo silencioso o registro de excepción si la tabla está vacía
        End Try
    End Sub

    ' Método para obtener y mostrar el siguiente ID consecutivo de la tabla Compra
    Public Sub ObtenerSiguienteIdCompra()
        Try
            Dim dt As DataTable = ConexionBD.ObtenerDatos("SELECT IFNULL(MAX(Id_com), 0) + 1 FROM Compra")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                LBL_IDCOMPRA.Text = dt.Rows(0)(0).ToString()
            Else
                LBL_IDCOMPRA.Text = "1"
            End If
        Catch ex As Exception
            LBL_IDCOMPRA.Text = "1"
        End Try
    End Sub

    Private Sub UC_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.EstiloDataGrid(DataGridView1)
        DataGridView1.ReadOnly = False

        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.HeaderText.IndexOf("Cantidad", StringComparison.OrdinalIgnoreCase) >= 0 Then
                col.ReadOnly = False
            Else
                col.ReadOnly = True
            End If
        Next
        Botones.CentrarTotal(Panel1)
        Botones.Redondear(Panel1, 20)

        CargarVendedores()
        ObtenerSiguienteIdCompra()
        CalcularTotalCompra()
    End Sub
    Private Sub UC_Compras_Resized(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub

    ' Función auxiliar flexible para obtener el valor de una celda buscando por coincidencia parcial de encabezado
    Private Function ObtenerValorCelda(fila As DataGridViewRow, textoEncabezado As String) As Object
        For Each cell As DataGridViewCell In fila.Cells
            Dim header As String = DataGridView1.Columns(cell.ColumnIndex).HeaderText.Trim()
            If header.IndexOf(textoEncabezado, StringComparison.OrdinalIgnoreCase) >= 0 Then
                Return cell.Value
            End If
        Next
        Return Nothing
    End Function

    ' Función auxiliar flexible para asignar valor a una celda buscando por coincidencia parcial de encabezado
    Private Sub AsignarValorCelda(fila As DataGridViewRow, textoEncabezado As String, valor As Object)
        For Each cell As DataGridViewCell In fila.Cells
            Dim header As String = DataGridView1.Columns(cell.ColumnIndex).HeaderText.Trim()
            If header.IndexOf(textoEncabezado, StringComparison.OrdinalIgnoreCase) >= 0 Then
                cell.Value = valor
                Exit Sub
            End If
        Next
    End Sub

    ' Botón Cobrar (Abre la ventana secundaria Cobro_Compra e inserta la compra al confirmar)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. VALIDAR QUE HAYA UN CLIENTE / VENDEDOR SELECCIONADO
        If CB_Vendedor.SelectedIndex = -1 OrElse CB_Vendedor.SelectedValue Is Nothing OrElse String.IsNullOrWhiteSpace(CB_Vendedor.Text) Then
            MessageBox.Show("Por favor, seleccione un vendedor o cliente válido antes de continuar con la compra.", "Cliente requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CB_Vendedor.Focus()
            Return
        End If

        ' 2. Validar que la tabla tenga productos agregados antes de proceder
        Dim tieneProductos As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                tieneProductos = True
                Exit For
            End If
        Next

        If Not tieneProductos Then
            MessageBox.Show("No hay productos agregados en la lista de compra actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el total actual formateado desde la etiqueta LBL_TOTAL
        Dim totalCompra As Decimal = 0
        Dim textoTotal = LBL_TOTAL.Text.Replace("$", "").Trim()
        Decimal.TryParse(textoTotal, NumberStyles.Any, CultureInfo.InvariantCulture, totalCompra)
        If totalCompra = 0 Then
            Decimal.TryParse(textoTotal, totalCompra) ' Respaldo con formato regional
        End If

        ' Instanciar y abrir la ventana de pago correcta: Cobro_Compra
        Dim formPago As New Cobro_Compra()
        formPago.TotalPagar = totalCompra

        If formPago.ShowDialog() = DialogResult.OK Then
            Dim dineroRecibido As Decimal = formPago.DineroRecibido
            Dim cambio As Decimal = formPago.Cambio
            Dim metodoPago As String = formPago.MetodoPago

            ' Recolectar los elementos del DataGridView para guardar
            Dim listaDetalle As New List(Of Dictionary(Of String, Object))()
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim item As New Dictionary(Of String, Object)
                    item("Codigo") = ObtenerValorCelda(row, "Código")
                    item("Cantidad") = Convert.ToDecimal(ObtenerValorCelda(row, "Cantidad"))
                    item("Precio") = Convert.ToDecimal(ObtenerValorCelda(row, "Precio"))
                    item("Subtotal") = Convert.ToDecimal(ObtenerValorCelda(row, "Subtotal"))
                    listaDetalle.Add(item)
                End If
            Next

            Try
                Dim pesoTotal As Decimal = 0
                Dim precioTotal As Decimal = totalCompra

                For Each item In listaDetalle
                    pesoTotal += Convert.ToDecimal(item("Cantidad"))
                Next

                ' Obtener ID de usuario válido desde la tabla Usuario
                Dim dtUsuario As DataTable = ConexionBD.ObtenerDatos("SELECT MIN(Id_us) FROM Usuario")
                Dim idUsuarioValido As Integer = 1
                If dtUsuario IsNot Nothing AndAlso dtUsuario.Rows.Count > 0 AndAlso Not IsDBNull(dtUsuario.Rows(0)(0)) Then
                    idUsuarioValido = Convert.ToInt32(dtUsuario.Rows(0)(0))
                End If

                ' Obtener el ID del vendedor seleccionado en el ComboBox de forma segura
                Dim idVendedorValido As Integer = 1
                Integer.TryParse(CB_Vendedor.SelectedValue.ToString(), idVendedorValido)

                ' Insertar la cabecera de la tabla Compra
                Dim fechaActual As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim queryCompra As String = "INSERT INTO Compra (fecha_com, id_us, Id_v, total_peso_com, total_precio, Metodo_pago_com) " &
                                            "VALUES (@fecha, @id_us, @id_v, @peso, @total, @metodo);"

                Dim parametrosCompra As New List(Of SqliteParameter) From {
                    New SqliteParameter("@fecha", fechaActual),
                    New SqliteParameter("@id_us", idUsuarioValido),
                    New SqliteParameter("@id_v", idVendedorValido),
                    New SqliteParameter("@peso", pesoTotal),
                    New SqliteParameter("@total", precioTotal),
                    New SqliteParameter("@metodo", If(String.IsNullOrEmpty(metodoPago), "Efectivo", metodoPago))
                }

                Dim resultado As Integer = ConexionBD.EjecutarComando(queryCompra, parametrosCompra)

                If resultado > 0 Then
                    ' Recuperar el ID de compra recién generado
                    Dim dtIdReciente As DataTable = ConexionBD.ObtenerDatos("SELECT MAX(Id_com) FROM Compra")
                    Dim nuevoIdCom As Integer = Convert.ToInt32(dtIdReciente.Rows(0)(0))

                    ' Guardar cada detalle en la tabla Detalle_compra
                    For Each item In listaDetalle
                        Dim codigoMat As String = item("Codigo").ToString().Trim()
                        Dim cantidad As Decimal = Convert.ToDecimal(item("Cantidad"))
                        Dim precioKg As Decimal = Convert.ToDecimal(item("Precio"))
                        Dim subtotal As Decimal = Convert.ToDecimal(item("Subtotal"))

                        Dim queryMat As String = "SELECT Id_mat FROM Materiales WHERE Id_mat = @cod OR nom_mat = @cod LIMIT 1"
                        Dim paramMat As New List(Of SqliteParameter) From {
                            New SqliteParameter("@cod", codigoMat)
                        }
                        Dim dtMat As DataTable = ConexionBD.ObtenerDatos(queryMat, paramMat)

                        If dtMat IsNot Nothing AndAlso dtMat.Rows.Count > 0 Then
                            Dim idMatReal As Integer = Convert.ToInt32(dtMat.Rows(0)("Id_mat"))

                            Dim queryDetalle As String = "INSERT INTO Detalle_compra (Id_com, Id_mat, Cantidad_kg_DC, Precio_kg_DC, Subtotal_DC) " &
                                                         "VALUES (@idCom, @idMat, @cant, @precio, @sub);"

                            Dim parametrosDetalle As New List(Of SqliteParameter) From {
                                New SqliteParameter("@idCom", nuevoIdCom),
                                New SqliteParameter("@idMat", idMatReal),
                                New SqliteParameter("@cant", cantidad),
                                New SqliteParameter("@precio", precioKg),
                                New SqliteParameter("@sub", subtotal)
                            }

                            ConexionBD.EjecutarComando(queryDetalle, parametrosDetalle)
                        End If
                    Next

                    MessageBox.Show("¡Compra de material registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar la tabla, restablecer vendedor y actualizar ID consecutivo
                    DataGridView1.Rows.Clear()
                    CargarVendedores()
                    ObtenerSiguienteIdCompra()
                    CalcularTotalCompra()
                Else
                    MessageBox.Show("No se pudo completar el registro de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al procesar la compra: " & ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Botón Buscar producto (Abre modal de búsqueda de material)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim buscador As New Busqueda_Venta()
        buscador.EsParaCompra = True

        If buscador.ShowDialog() = DialogResult.OK Then
            Dim codigo As String = buscador.CodigoSeleccionado
            Dim descripcion As String = buscador.DescripcionSeleccionada
            Dim precio As Decimal = buscador.PrecioSeleccionado
            Dim cantidadAgregada As Decimal = 1.0
            Dim existe As Boolean = False

            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim valCodigo = ObtenerValorCelda(row, "Código")
                    If valCodigo IsNot Nothing AndAlso valCodigo.ToString().Trim() = codigo.Trim() Then
                        Dim valCantidad = ObtenerValorCelda(row, "Cantidad")
                        Dim cantidadActual As Decimal = 0
                        If valCantidad IsNot Nothing Then Decimal.TryParse(valCantidad.ToString(), cantidadActual)

                        Dim nuevaCantidad As Decimal = cantidadActual + cantidadAgregada
                        AsignarValorCelda(row, "Cantidad", nuevaCantidad)
                        AsignarValorCelda(row, "Subtotal", nuevaCantidad * precio)

                        existe = True
                        Exit For
                    End If
                End If
            Next

            If Not existe Then
                Dim subtotal As Decimal = cantidadAgregada * precio
                Dim idx As Integer = DataGridView1.Rows.Add()
                Dim fila As DataGridViewRow = DataGridView1.Rows(idx)

                If DataGridView1.Columns.Count >= 5 Then
                    fila.Cells(0).Value = cantidadAgregada
                    fila.Cells(1).Value = codigo
                    fila.Cells(2).Value = descripcion
                    fila.Cells(3).Value = precio
                    fila.Cells(4).Value = subtotal
                Else
                    AsignarValorCelda(fila, "Cantidad", cantidadAgregada)
                    AsignarValorCelda(fila, "Código", codigo)
                    AsignarValorCelda(fila, "Descripción", descripcion)
                    AsignarValorCelda(fila, "Precio", precio)
                    AsignarValorCelda(fila, "Subtotal", subtotal)
                End If
            End If

            CalcularTotalCompra()
        End If
    End Sub

    ' Edición de la celda de Cantidad en el DataGridView
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim columnaEditadaHeader As String = DataGridView1.Columns(e.ColumnIndex).HeaderText

            If columnaEditadaHeader.IndexOf("Cantidad", StringComparison.OrdinalIgnoreCase) >= 0 Then
                Dim cantidad As Decimal = 0
                Dim precio As Decimal = 0

                Dim valCantidad = ObtenerValorCelda(fila, "Cantidad")
                Dim valPrecio = ObtenerValorCelda(fila, "Precio")

                If valCantidad IsNot Nothing AndAlso Decimal.TryParse(valCantidad.ToString(), cantidad) AndAlso
                   valPrecio IsNot Nothing AndAlso Decimal.TryParse(valPrecio.ToString(), precio) Then

                    Dim subtotal As Decimal = cantidad * precio
                    AsignarValorCelda(fila, "Subtotal", subtotal)
                Else
                    MessageBox.Show("Por favor, ingresa una cantidad numérica válida.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    AsignarValorCelda(fila, "Cantidad", 1.0)
                    Dim valPrecioActual = ObtenerValorCelda(fila, "Precio")
                    If valPrecioActual IsNot Nothing AndAlso Decimal.TryParse(valPrecioActual.ToString(), precio) Then
                        AsignarValorCelda(fila, "Subtotal", 1.0 * precio)
                    End If
                End If

                CalcularTotalCompra()
            End If
        End If
    End Sub

    ' Botón Borrar producto seleccionado
    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim filaSeleccionada = DataGridView1.SelectedRows(0)

            If Not filaSeleccionada.IsNewRow Then
                Dim respuesta = MessageBox.Show("¿Estás seguro de eliminar este producto de la lista de compra?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(filaSeleccionada)
                    CalcularTotalCompra()
                End If
            End If
        Else
            MessageBox.Show("Por favor, selecciona la fila completa del producto que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            ' Cancelar el comportamiento predeterminado del DataGridView para evitar que borre la fila automáticamente
            e.Handled = True
            e.SuppressKeyPress = True

            ' Ejecutar únicamente la lógica controlada de tu botón de borrar con confirmación
            BTN_BORRAR.PerformClick()
        End If
    End Sub

    ' Calcular sumatoria de subtotales
    Private Sub CalcularTotalCompra()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim valSubtotal = ObtenerValorCelda(row, "Subtotal")
                If valSubtotal IsNot Nothing Then
                    Dim subtotalFila As Decimal = 0
                    If Decimal.TryParse(valSubtotal.ToString(), subtotalFila) Then
                        total += subtotalFila
                    End If
                End If
            End If
        Next

        LBL_TOTAL.Text = "$ " & total.ToString("N2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
End Class