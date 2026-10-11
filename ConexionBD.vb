Imports Microsoft.Data.Sqlite

Public Class ConexionDB
    Private ReadOnly cadenaConexion As String = "Data Source=Centro de reciclaje\Centro de reciclaje.db;"

    Public Function ObtenerConexion() As SqliteConnection
        Dim conexion As New SqliteConnection(cadenaConexion)
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conexion
    End Function
End Class