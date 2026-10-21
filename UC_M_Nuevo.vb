Imports Microsoft.Data.Sqlite

Public Class UC_M_Nuevo

    Private Sub UC_M_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSiguienteId()
        Botones.CentrarTotal(Panel1)

        Botones.Redondear(MTB_Codigo, 10)
        Botones.Redondear(MTB_Nombre, 10)
        Botones.Redondear(MTB_Tipo, 10)
        Botones.Redondear(MTB_Unidad, 10)
        Botones.Redondear(MTB_Pcompra, 10)
        Botones.Redondear(MTB_Pventa, 10)
        Botones.Redondear(Button1, 10)

        Botones.ConfigurarPlaceholder(MTB_Nombre, "Nombre del material", False)
        Botones.ConfigurarPlaceholder(MTB_Tipo, "Tipo de material", False)
        Botones.ConfigurarPlaceholder(MTB_Unidad, "Unidad de medida", False)
        Botones.ConfigurarPlaceholder(MTB_Pcompra, "Precio de compra", False)
        Botones.ConfigurarPlaceholder(MTB_Pventa, "Precio de venta", False)
    End Sub
    Private Sub UC_M_Nuevo_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
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
            Dim query = "INSERT INTO Materiales (Id_mat, nom_mat, tipo, unidad_medida, Precio_compra, Precio_Venta) " &
                                  "VALUES (@id, @nombre, @tipo, @unidad, @pcompra, @pventa);"

            ' 3. Preparar los parámetros enlazados a los controles correspondientes
            Dim parametros As New List(Of SqliteParameter) From {
                New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim)),
                New SqliteParameter("@nombre", MTB_Nombre.Text.Trim),
                New SqliteParameter("@tipo", MTB_Tipo.Text.Trim),
                New SqliteParameter("@unidad", MTB_Unidad.Text.Trim),
                New SqliteParameter("@pcompra", Convert.ToDecimal(MTB_Pcompra.Text.Trim)),
                New SqliteParameter("@pventa", Convert.ToDecimal(MTB_Pventa.Text.Trim))
            }

            ' 4. Ejecutar el comando utilizando tu clase helper con control transaccional
            Dim filasAfectadas = ConexionBD.EjecutarComando(query, parametros)

            If filasAfectadas > 0 Then
                MessageBox.Show("Material registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Botones.LimpiarConPlaceholder(MTB_Codigo)
                Botones.LimpiarConPlaceholder(MTB_Nombre)
                Botones.LimpiarConPlaceholder(MTB_Tipo)
                Botones.LimpiarConPlaceholder(MTB_Unidad)
                Botones.LimpiarConPlaceholder(MTB_Pcompra)
                Botones.LimpiarConPlaceholder(MTB_Pventa)
                CargarSiguienteId()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el material: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class