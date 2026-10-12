Imports Microsoft.Data.Sqlite

Public Class UC_I_Nuevo

    Private Sub UC_I_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()
        CargarSiguienteId()
    End Sub

    Private Sub UC_I_Nuevo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentrarFormulario()
    End Sub

    Private Sub CentrarFormulario()
        If Panel_Form IsNot Nothing Then
            Dim x As Integer = (Me.ClientSize.Width - Panel_Form.Width) \ 2
            Dim y As Integer = (Me.ClientSize.Height - Panel_Form.Height) \ 2

            If x < 0 Then x = 0
            If y < 0 Then y = 0

            Panel_Form.Location = New Point(x, y)
        End If
    End Sub

    Private Sub CargarSiguienteId()
        Try
            Dim query As String = "SELECT MIN(t1.Id_mat + 1) " &
                                  "FROM Materiales t1 " &
                                  "WHERE NOT EXISTS (" &
                                  "    SELECT 1 FROM Materiales t2 WHERE t2.Id_mat = t1.Id_mat + 1" &
                                  ")"

            Dim dt As DataTable = ConexionBD.ObtenerDatos(query)

            Dim siguienteId As Integer = 1
            If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)(0)) Then
                siguienteId = Convert.ToInt32(dt.Rows(0)(0))
            End If

            Dim queryVerificar1 As String = "SELECT COUNT(1) FROM Materiales WHERE Id_mat = 1"
            Dim dt1 As DataTable = ConexionBD.ObtenerDatos(queryVerificar1)
            If Convert.ToInt32(dt1.Rows(0)(0)) = 0 Then
                siguienteId = 1
            End If

            MTB_Codigo.Text = siguienteId.ToString()

        Catch ex As Exception
            MessageBox.Show("Error al calcular el código: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Validar que los campos obligatorios no estén vacíos (incluyendo compra y venta)
        If String.IsNullOrEmpty(MTB_Nombre.Text) OrElse
           String.IsNullOrEmpty(MTB_Pcompra.Text) OrElse
           String.IsNullOrEmpty(MTB_Pventa.Text) Then
            MessageBox.Show("Por favor, completa los campos obligatorios (Nombre, Precio de compra y Precio de venta).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Definir la instrucción INSERT con los dos precios actualizados
            Dim query As String = "INSERT INTO Materiales (Id_mat, nom_mat, tipo, unidad_medida, Precio_compra, Precio_Venta) " &
                                  "VALUES (@id, @nombre, @tipo, @unidad, @pcompra, @pventa);"

            ' 3. Preparar los parámetros enlazados a los controles correspondientes
            Dim parametros As New List(Of SqliteParameter) From {
                New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim())),
                New SqliteParameter("@nombre", MTB_Nombre.Text.Trim()),
                New SqliteParameter("@tipo", MTB_Tipo.Text.Trim()),
                New SqliteParameter("@unidad", MTB_Unidad.Text.Trim()),
                New SqliteParameter("@pcompra", Convert.ToDecimal(MTB_Pcompra.Text.Trim())),
                New SqliteParameter("@pventa", Convert.ToDecimal(MTB_Pventa.Text.Trim()))
            }

            ' 4. Ejecutar el comando utilizando tu clase helper con control transaccional
            Dim filasAfectadas As Integer = ConexionBD.EjecutarComando(query, parametros)

            If filasAfectadas > 0 Then
                MessageBox.Show("Material registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los campos para un nuevo registro y actualizar el siguiente ID disponible
                MTB_Nombre.Clear()
                MTB_Tipo.Clear()
                MTB_Unidad.Clear()
                MTB_Pcompra.Clear()
                MTB_Pventa.Clear()
                CargarSiguienteId()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el material: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class