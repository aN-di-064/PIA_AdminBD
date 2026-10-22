Public Class Cobro_Venta

    ' Variables públicas para recibir información desde UC_Ventas
    Public TotalVenta As Decimal
    Public IdVenta As Integer
    Public DetalleVentaRows As List(Of Dictionary(Of String, Object))
    Public CompraExitosas As Boolean = False

    Private Sub Cobro_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_TOTAL.Text = TotalVenta.ToString("N2")
        TXT_TOTAL.ReadOnly = True

        TXT_CAMBIO.ReadOnly = True
        TXT_CAMBIO.Text = "0.00"

        Botones.CentrarTotal(Panel1)
        Botones.Redondear(TXT_CAMBIO, 10)
        Botones.Redondear(TXT_DR, 10)
        Botones.Redondear(TXT_TOTAL, 10)
        Botones.Redondear(Button1, 10)

        Botones.ConfigurarPlaceholder(TXT_DR, "Dinero recibido", False)
        TXT_DR.Focus()
    End Sub
    Private Sub Cobro_Venta_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub
    Private Sub TXT_DR_TextChanged(sender As Object, e As EventArgs) Handles TXT_DR.TextChanged
        Dim dineroRecibido As Decimal = 0
        If Decimal.TryParse(TXT_DR.Text, dineroRecibido) Then
            Dim cambio As Decimal = dineroRecibido - TotalVenta
            If cambio >= 0 Then
                TXT_CAMBIO.Text = cambio.ToString("N2")
            Else
                TXT_CAMBIO.Text = "Falta dinero"
            End If
        Else
            TXT_CAMBIO.Text = "0.00"
        End If
    End Sub

    Private Sub TXT_DR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_DR.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If
        If (e.KeyChar = "."c) AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dineroRecibido As Decimal = 0

        If Not Decimal.TryParse(TXT_DR.Text, dineroRecibido) Then
            MessageBox.Show("Por favor, ingresa una cantidad de dinero válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXT_DR.Focus()
            Return
        End If

        If dineroRecibido < TotalVenta Then
            MessageBox.Show("El dinero recibido es menor al total de la venta.", "Fondos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXT_DR.Focus()
            Return
        End If

        Try
            ' 1. Obtener un Id_us válido de la tabla Usuario
            Dim dtUsuario As DataTable = ConexionBD.ObtenerDatos("SELECT MIN(Id_us) FROM Usuario")
            Dim idUsuarioValido As Integer = 1
            If dtUsuario IsNot Nothing AndAlso dtUsuario.Rows.Count > 0 AndAlso Not IsDBNull(dtUsuario.Rows(0)(0)) Then
                idUsuarioValido = Convert.ToInt32(dtUsuario.Rows(0)(0))
            End If

            ' 2. Insertar cabecera SIN Id_s (SQLite asigna el autoincremental de forma nativa)
            Dim fechaActual As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            Dim querySalida As String = "INSERT INTO Salida (fecha_s, Id_us, total_Kg_s, total_monto) VALUES ('" &
                                        fechaActual & "', " & idUsuarioValido & ", 0, " & TotalVenta & ")"

            Dim filasSalida As Integer = ConexionBD.EjecutarComando(querySalida)
            If filasSalida = 0 Then
                Throw New Exception("No se pudo registrar la cabecera de la salida.")
            End If

            ' 3. Recuperar el Id_s recién asignado por SQLite
            Dim dtIdReciente As DataTable = ConexionBD.ObtenerDatos("SELECT MAX(Id_s) FROM Salida")
            Dim nuevoIdS As Integer = Convert.ToInt32(dtIdReciente.Rows(0)(0))

            ' 4. Insertar los renglones del detalle usando el ID de la salida recien obtenida
            Dim pesoTotalKg As Decimal = 0
            For Each item As Dictionary(Of String, Object) In DetalleVentaRows
                Dim codigoMat As String = item("Codigo").ToString().Trim()
                Dim cantidad As Decimal = Convert.ToDecimal(item("Cantidad"))
                Dim precioKg As Decimal = Convert.ToDecimal(item("Precio"))
                Dim subtotal As Decimal = Convert.ToDecimal(item("Subtotal"))

                pesoTotalKg += cantidad

                Dim dtMat As DataTable = ConexionBD.ObtenerDatos("SELECT Id_mat FROM Materiales WHERE Id_mat = '" & codigoMat & "' OR nom_mat = '" & codigoMat & "' LIMIT 1")

                If dtMat Is Nothing OrElse dtMat.Rows.Count = 0 Then
                    Throw New Exception("El material '" & codigoMat & "' no existe en la base de datos.")
                End If

                Dim idMatReal As Integer = Convert.ToInt32(dtMat.Rows(0)("Id_mat"))

                Dim queryDetalle As String = "INSERT INTO Detalle_salida (Id_s, Id_mat, cantidad_kg_DS, precio_Kg_DS, subtotal_DS) " &
                                             "VALUES (" & nuevoIdS & ", " & idMatReal & ", " & cantidad & ", " & precioKg & ", " & subtotal & ")"

                ConexionBD.EjecutarComando(queryDetalle)
            Next

            ' 5. Actualizar el peso total real en la salida
            Dim queryUpdatePeso As String = "UPDATE Salida SET total_Kg_s = " & pesoTotalKg & " WHERE Id_s = " & nuevoIdS
            ConexionBD.EjecutarComando(queryUpdatePeso)

            MessageBox.Show("¡Venta registrada con éxito!", "Cobro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            CompraExitosas = True
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("No se pudo completar la venta: " & ex.Message, "Error en transacción", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CompraExitosas = False
        End Try
    End Sub

End Class