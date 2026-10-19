Imports System.Data
Imports System.IO
Imports Microsoft.Data.Sqlite

Public Class ConexionBD

    Private Shared ReadOnly rutaArchivoDb As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Centro de reciclaje", "Centro de reciclaje.db")
    Private ReadOnly cadenaConexion As String = "Data Source=" & rutaArchivoDb & ";"

    Public Function ObtenerConexion() As SqliteConnection
        Dim conexion As New SqliteConnection(cadenaConexion)
        Try
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conexion
    End Function

    ' Método para consultas SELECT con parámetros usando SqliteDataReader
    Public Shared Function ObtenerDatos(query As String, Optional parametros As List(Of SqliteParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Dim db As New ConexionBD()

        Using conexion As SqliteConnection = db.ObtenerConexion()
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                Using comando As New SqliteCommand(query, conexion)

                    ' Agregar parámetros uno por uno si existen
                    If parametros IsNot Nothing Then
                        For Each p As SqliteParameter In parametros
                            comando.Parameters.Add(p)
                        Next
                    End If

                    Using lector As SqliteDataReader = comando.ExecuteReader()
                        dt.Load(lector)
                    End Using
                End Using
            End If
        End Using

        Return dt
    End Function

    Public Shared Function EjecutarComando(query As String, Optional parametros As List(Of SqliteParameter) = Nothing) As Integer
        Dim filasAfectadas As Integer = 0
        Dim db As New ConexionBD()

        Using conexion As SqliteConnection = db.ObtenerConexion()
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                ' Abrimos una transacción explícita para asegurar que los datos se escriban en el disco duro
                Using transaccion As SqliteTransaction = conexion.BeginTransaction()
                    Using comando As New SqliteCommand(query, conexion, transaccion)
                        Try
                            If parametros IsNot Nothing Then
                                For Each p As SqliteParameter In parametros
                                    comando.Parameters.Add(p)
                                Next
                            End If

                            ' Ejecutar el comando una sola vez de forma correcta
                            filasAfectadas = comando.ExecuteNonQuery()

                            ' Confirmar los cambios permanentemente en la base de datos
                            transaccion.Commit()

                        Catch ex As Exception
                            ' Si algo falla, revertir cualquier cambio temporal
                            transaccion.Rollback()
                            MessageBox.Show("Error en EjecutarComando: " & ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            filasAfectadas = 0
                        End Try
                    End Using
                End Using
            End If
        End Using

        Return filasAfectadas
    End Function

End Class