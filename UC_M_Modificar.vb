Imports Microsoft.Data.Sqlite

Public Class UC_M_Modificar

    Public IdVendedorAEditar As Integer = 0

    Private Sub UC_M_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IdVendedorAEditar > 0 Then
            CargarDatosVendedor()
        End If
    End Sub

    Private Sub CargarDatosVendedor()
        Try
            Dim query As String = "SELECT id_v, nom_v, telefono_v, dirección_v, correo_v FROM Vendedores WHERE id_v = @id"
            Dim db As New ConexionBD()

            Using conexion As SqliteConnection = db.ObtenerConexion()
                If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                    Using comando As New SqliteCommand(query, conexion)
                        comando.Parameters.Add(New SqliteParameter("@id", IdVendedorAEditar))
                        Using lector As SqliteDataReader = comando.ExecuteReader()
                            If lector.Read() Then
                                MTB_Codigo.Text = lector("id_v").ToString()
                                MTB_Nombre.Text = lector("nom_v").ToString()
                                MTB_Tipo.Text = lector("telefono_v").ToString()
                                MTB_Unidad.Text = lector("dirección_v").ToString()
                                MTB_Pcompra.Text = lector("correo_v").ToString()
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos del vendedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(MTB_Codigo.Text) Then
            MessageBox.Show("Por favor, seleccione un vendedor primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Está seguro de realizar los cambios?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "UPDATE Vendedores SET nom_v = @nombre, telefono_v = @telefono, dirección_v = @direccion, correo_v = @correo WHERE id_v = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim())),
                    New SqliteParameter("@nombre", MTB_Nombre.Text.Trim()),
                    New SqliteParameter("@telefono", MTB_Tipo.Text.Trim()),
                    New SqliteParameter("@direccion", MTB_Unidad.Text.Trim()),
                    New SqliteParameter("@correo", MTB_Pcompra.Text.Trim())
                }

                Dim filas As Integer = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Vendedor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el vendedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class