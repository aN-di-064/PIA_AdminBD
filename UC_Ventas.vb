Public Class UC_Ventas

    ' Método para calcular y mostrar el siguiente ID consecutivo de venta
    Public Sub ObtenerSiguienteIdVenta()
        Try
            Dim dt As DataTable = ConexionBD.ObtenerDatos("SELECT IFNULL(MAX(id_s), 0) + 1 FROM Salida")
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                LBL_IDVENTA.Text = dt.Rows(0)(0).ToString()
            Else
                LBL_IDVENTA.Text = "1"
            End If
        Catch ex As Exception
            LBL_IDVENTA.Text = "1"
        End Try
    End Sub

    Private Sub UC_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Permitir edición en el DataGridView
        DataGridView1.ReadOnly = False

        ' Proteger todas las columnas excepto la que tenga "Cantidad" en su encabezado
        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.HeaderText.Contains("Cantidad") Then
                col.ReadOnly = False
            Else
                col.ReadOnly = True
            End If
        Next

        ' Cargar folio de salida y calcular total inicial
        ObtenerSiguienteIdVenta()
        CalcularTotalVenta()
    End Sub

    ' Función auxiliar para obtener el valor de una celda buscando por el HeaderText de la columna
    Private Function ObtenerValorCelda(fila As DataGridViewRow, textoEncabezado As String) As Object
        For Each cell As DataGridViewCell In fila.Cells
            If DataGridView1.Columns(cell.ColumnIndex).HeaderText.Equals(textoEncabezado, StringComparison.OrdinalIgnoreCase) Then
                Return cell.Value
            End If
        Next
        Return Nothing
    End Function

    ' Función auxiliar para asignar el valor a una celda buscando por el HeaderText de la columna
    Private Sub AsignarValorCelda(fila As DataGridViewRow, textoEncabezado As String, valor As Object)
        For Each cell As DataGridViewCell In fila.Cells
            If DataGridView1.Columns(cell.ColumnIndex).HeaderText.Equals(textoEncabezado, StringComparison.OrdinalIgnoreCase) Then
                cell.Value = valor
                Exit Sub
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validar que la tabla tenga productos antes de cobrar
        Dim tieneProductos As Boolean = False
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                tieneProductos = True
                Exit For
            End If
        Next

        If Not tieneProductos Then
            MessageBox.Show("No hay productos agregados en la venta actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el total actual de la etiqueta LBL_TOTAL
        Dim totalVenta As Decimal = 0
        Dim textoTotal = LBL_TOTAL.Text.Replace("$", "").Trim()
        Decimal.TryParse(textoTotal, totalVenta)

        Dim idVentaActual As Integer = 1
        Integer.TryParse(LBL_IDVENTA.Text, idVentaActual)

        ' Recolectar los elementos del DataGridView para pasarlos al formulario de cobro
        Dim listaDetalle As New List(Of Dictionary(Of String, Object))()
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim item As New Dictionary(Of String, Object)
                item("Codigo") = ObtenerValorCelda(row, "Código")
                item("Cantidad") = Convert.ToDecimal(ObtenerValorCelda(row, "Cantidad (kg)"))
                item("Precio") = Convert.ToDecimal(ObtenerValorCelda(row, "Precio por kilo"))
                item("Subtotal") = Convert.ToDecimal(ObtenerValorCelda(row, "Subtotal"))
                listaDetalle.Add(item)
            End If
        Next

        ' Instanciar y mostrar el formulario de Cobro por encima del sistema (.ShowDialog)
        Dim formCobro As New Cobro_Venta()
        formCobro.TotalVenta = totalVenta
        formCobro.IdVenta = idVentaActual
        formCobro.DetalleVentaRows = listaDetalle

        If formCobro.ShowDialog() = DialogResult.OK AndAlso formCobro.CompraExitosas Then
            ' Limpiar la interfaz de ventas tras un cobro exitoso para iniciar la siguiente venta
            DataGridView1.Rows.Clear()
            ObtenerSiguienteIdVenta()
            CalcularTotalVenta()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        ' Si el usuario presiona la tecla Delete (Supr)
        If e.KeyCode = Keys.Delete Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)

                If Not filaSeleccionada.IsNewRow Then
                    Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de eliminar este producto de la venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If respuesta = DialogResult.Yes Then
                        DataGridView1.Rows.Remove(filaSeleccionada)
                        CalcularTotalVenta()
                    End If
                End If
            Else
                MessageBox.Show("Por favor, selecciona la fila completa del producto que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim columnaEditadaHeader As String = DataGridView1.Columns(e.ColumnIndex).HeaderText

            ' Recalcular únicamente si la columna editada es la de Cantidad
            If columnaEditadaHeader.Contains("Cantidad") Then
                Dim cantidad As Decimal = 0
                Dim precio As Decimal = 0

                ' Leer valores buscando por HeaderText
                Dim valCantidad = ObtenerValorCelda(fila, columnaEditadaHeader)
                Dim valPrecio = ObtenerValorCelda(fila, "Precio por kilo")

                If valCantidad IsNot Nothing AndAlso Decimal.TryParse(valCantidad.ToString(), cantidad) AndAlso
                   valPrecio IsNot Nothing AndAlso Decimal.TryParse(valPrecio.ToString(), precio) Then

                    ' Recalcular el subtotal
                    Dim subtotal As Decimal = cantidad * precio
                    AsignarValorCelda(fila, "Subtotal", subtotal)
                Else
                    MessageBox.Show("Por favor, ingresa una cantidad numérica válida.", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    ' Restaurar a 1.0 por defecto
                    AsignarValorCelda(fila, columnaEditadaHeader, 1.0)
                    Dim valPrecioActual = ObtenerValorCelda(fila, "Precio por kilo")
                    If valPrecioActual IsNot Nothing AndAlso Decimal.TryParse(valPrecioActual.ToString(), precio) Then
                        AsignarValorCelda(fila, "Subtotal", 1.0 * precio)
                    End If
                End If

                ' Recalcular la suma general de la venta
                CalcularTotalVenta()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim buscador As New Busqueda_Venta()

        If buscador.ShowDialog() = DialogResult.OK Then
            Dim codigo As String = buscador.CodigoSeleccionado
            Dim descripcion As String = buscador.DescripcionSeleccionada
            Dim precio As Decimal = buscador.PrecioSeleccionado
            Dim cantidadAgregada As Decimal = 1.0
            Dim existe As Boolean = False

            ' Buscar si el producto ya está en el DataGridView
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim valCodigo = ObtenerValorCelda(row, "Código")
                    If valCodigo IsNot Nothing AndAlso valCodigo.ToString() = codigo Then
                        ' Obtener cantidad actual y sumar
                        Dim valCantidad = ObtenerValorCelda(row, "Cantidad (kg)")
                        Dim cantidadActual As Decimal = 0
                        If valCantidad IsNot Nothing Then Decimal.TryParse(valCantidad.ToString(), cantidadActual)

                        Dim nuevaCantidad As Decimal = cantidadActual + cantidadAgregada
                        AsignarValorCelda(row, "Cantidad (kg)", nuevaCantidad)
                        AsignarValorCelda(row, "Subtotal", nuevaCantidad * precio)

                        existe = True
                        Exit For
                    End If
                End If
            Next

            ' Si no existe, agregamos respetando el orden de las columnas de tu DataGridView
            If Not existe Then
                Dim subtotal As Decimal = cantidadAgregada * precio
                Dim nuevaFilaIdx As Integer = DataGridView1.Rows.Add()
                Dim nuevaFila As DataGridViewRow = DataGridView1.Rows(nuevaFilaIdx)

                AsignarValorCelda(nuevaFila, "Cantidad (kg)", cantidadAgregada)
                AsignarValorCelda(nuevaFila, "Código", codigo)
                AsignarValorCelda(nuevaFila, "Descripción", descripcion)
                AsignarValorCelda(nuevaFila, "Precio por kilo", precio)
                AsignarValorCelda(nuevaFila, "Subtotal", subtotal)
            End If

            ' Recalcular la suma general de la venta
            CalcularTotalVenta()
        End If
    End Sub

    Private Sub BTN_BORRAR_Click(sender As Object, e As EventArgs) Handles BTN_BORRAR.Click
        ' Verificar que haya una fila seleccionada y que no sea la fila nueva (vacía)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.SelectedRows(0)

            If Not filaSeleccionada.IsNewRow Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de eliminar este producto de la venta?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If respuesta = DialogResult.Yes Then
                    DataGridView1.Rows.Remove(filaSeleccionada)
                    CalcularTotalVenta()
                End If
            End If
        Else
            MessageBox.Show("Por favor, selecciona la fila completa del producto que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Método para calcular la sumatoria de los subtotales y mostrarla en LBL_TOTAL
    Private Sub CalcularTotalVenta()
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

        ' Muestra el total en la etiqueta con formato de dos decimales
        LBL_TOTAL.Text = "$ " & total.ToString("N2")
    End Sub

    Private Sub LBL_IDVENTA_Click(sender As Object, e As EventArgs) Handles LBL_IDVENTA.Click

    End Sub
End Class