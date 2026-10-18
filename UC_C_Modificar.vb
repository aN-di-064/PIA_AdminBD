Imports Microsoft.Data.Sqlite

Public Class UC_C_Modificar

    Public IdVendedorAEditar As Integer = 0

    Private Sub UC_C_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()
        ' Si nos pasan un ID desde la tabla de consultas, cargamos sus datos automáticamente
        If IdVendedorAEditar > 0 Then
            ID.Text = IdVendedorAEditar.ToString()
            CargarDatosVendedor(IdVendedorAEditar)
        End If

    End Sub

    Private Sub UC_C_Modificar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentrarFormulario()
    End Sub

    Private Sub CentrarFormulario()
        If Panel1 IsNot Nothing Then
            Dim x As Integer = (Me.ClientSize.Width - Panel1.Width) \ 2
            Dim y As Integer = (Me.ClientSize.Height - Panel1.Height) \ 2

            If x < 0 Then x = 0
            If y < 0 Then y = 0

            Panel1.Location = New Point(x, y)
        End If
    End Sub

    ' Método auxiliar para consultar y rellenar las cajas de texto según el ID del vendedor/cliente
    Private Sub CargarDatosVendedor(idBuscado As Integer)
        Try
            Dim query As String = "SELECT id_v, nom_v, telefono_v, dirección_v, correo_v, rfc_v FROM Vendedores WHERE id_v = @id"
            Dim db As New ConexionBD()

            Using conexion As SqliteConnection = db.ObtenerConexion()
                If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                    Using comando As New SqliteCommand(query, conexion)
                        comando.Parameters.Add(New SqliteParameter("@id", idBuscado))
                        Using lector As SqliteDataReader = comando.ExecuteReader()
                            If lector.Read() Then
                                ID.Text = lector("id_v").ToString()
                                Nom.Text = lector("nom_v").ToString()
                                Telf.Text = lector("telefono_v").ToString()
                                Dire.Text = lector("dirección_v").ToString()
                                Correo.Text = lector("correo_v").ToString()
                                ' Si tienes el campo RFC en tu base de datos, descomenta la siguiente línea:
                                ' RFC.Text = lector("rfc_v").ToString()
                            Else
                                MessageBox.Show("No se encontró ningún registro con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos del vendedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento del Botón 2: Botón de Búsqueda (permite buscar manualmente si entraron directo a la vista)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Aquí puedes abrir una ventana de búsqueda de vendedores/clientes si ya la tienes creada,
        ' o bien permitir buscar introduciendo un ID directamente en la caja de texto ID:
        Dim idIngresado As Integer = 0
        If Integer.TryParse(ID.Text.Trim(), idIngresado) Then
            CargarDatosVendedor(idIngresado)
        Else
            MessageBox.Show("Por favor, ingresa un ID válido para buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Evento del Botón 1: Botón para Modificar / Actualizar los cambios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(ID.Text) Then
            MessageBox.Show("Por favor, seleccione o busque un vendedor primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Está seguro de realizar los cambios?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Asegúrate de que los nombres de las columnas en tu tabla Vendedores coincidan con estos (ej. rfc_v)
                Dim query As String = "UPDATE Vendedores SET nom_v = @nombre, telefono_v = @telefono, dirección_v = @direccion, correo_v = @correo WHERE id_v = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(ID.Text.Trim())),
                    New SqliteParameter("@nombre", Nom.Text.Trim()),
                    New SqliteParameter("@telefono", Telf.Text.Trim()),
                    New SqliteParameter("@direccion", Dire.Text.Trim()),
                    New SqliteParameter("@correo", Correo.Text.Trim())
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