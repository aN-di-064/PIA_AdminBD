Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class UC_C_Nuevo

    Private Sub UC_C_Nuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSiguienteId()
    End Sub

    ' Método para calcular automáticamente el código mínimo disponible en la tabla Vendedores
    Private Sub CargarSiguienteId()
        Try
            Dim query As String = "SELECT MIN(t1.Id_v + 1) " &
                                  "FROM Vendedores t1 " &
                                  "WHERE NOT EXISTS (" &
                                  "    SELECT 1 FROM Vendedores t2 WHERE t2.Id_v = t1.Id_v + 1" &
                                  ")"

            Dim dt As DataTable = ConexionBD.ObtenerDatos(query)

            Dim siguienteId As Integer = 1
            If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)(0)) Then
                siguienteId = Convert.ToInt32(dt.Rows(0)(0))
            End If

            ' Verificar si la tabla está completamente vacía o no existe el Id 1
            Dim queryVerificar1 As String = "SELECT COUNT(1) FROM Vendedores WHERE Id_v = 1"
            Dim dt1 As DataTable = ConexionBD.ObtenerDatos(queryVerificar1)
            If Convert.ToInt32(dt1.Rows(0)(0)) = 0 Then
                Dim queryMin As String = "SELECT MIN(Id_v) FROM Vendedores"
                Dim dtMin As DataTable = ConexionBD.ObtenerDatos(queryMin)
                If dtMin.Rows.Count > 0 AndAlso Not IsDBNull(dtMin.Rows(0)(0)) Then
                    Dim minActual As Integer = Convert.ToInt32(dtMin.Rows(0)(0))
                    If minActual > 1 Then
                        siguienteId = 1
                    End If
                End If
            End If

            MTB_Codigo.Text = siguienteId.ToString()

        Catch ex As Exception
            MessageBox.Show("Error al calcular el código del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento del botón "Agregar" (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Validar campos obligatorios principales (Nombre y Teléfono)
        If String.IsNullOrEmpty(MTB_Nombre.Text) OrElse String.IsNullOrEmpty(MTB_Telefono.Text) Then
            MessageBox.Show("Por favor, completa al menos el Nombre y el Teléfono del cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 2. Instrucción SQL INSERT con la columna correcta 'RFC_v'
            Dim query As String = "INSERT INTO Vendedores (Id_v, nom_v, telefono_v, dirección_v, correo_v, RFC_v) " &
                              "VALUES (@id, @nom, @tel, @dir, @correo, @rfc);"

            ' 3. Mapear parámetros asegurando que coincidan
            Dim parametros As New List(Of SqliteParameter) From {
            New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim())),
            New SqliteParameter("@nom", MTB_Nombre.Text.Trim()),
            New SqliteParameter("@tel", MTB_Telefono.Text.Trim()),
            New SqliteParameter("@dir", MTB_Dirección.Text.Trim()),
            New SqliteParameter("@correo", MTB_Correo.Text.Trim()),
            New SqliteParameter("@rfc", MTB_RFC.Text.Trim())
        }

            ' 4. Ejecutar el comando utilizando tu clase helper centralizada
            Dim filasAfectadas As Integer = ConexionBD.EjecutarComando(query, parametros)

            If filasAfectadas > 0 Then
                MessageBox.Show("Cliente registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar controles de texto y refrescar el siguiente ID disponible
                MTB_Nombre.Clear()
                MTB_Telefono.Clear()
                MTB_Dirección.Clear()
                MTB_Correo.Clear()
                MTB_RFC.Clear()
                CargarSiguienteId()
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el cliente: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class