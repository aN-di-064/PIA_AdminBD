Imports Microsoft.Data.Sqlite
Public Class UC_C_Modificar

    Public IdVendedorAEditar As Integer = 0

    Private Sub UC_C_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.CentrarTotal(Panel1)

        Botones.Redondear(MTB_Codigo, 10)
        Botones.Redondear(MTB_Nombre, 10)
        Botones.Redondear(MTB_Telefono, 10)
        Botones.Redondear(MTB_Direccion, 10)
        Botones.Redondear(MTB_Correo, 10)
        Botones.Redondear(MTB_RFC, 10)
        Botones.Redondear(Button1, 10)
        Botones.Redondear(Button2, 10)

        Botones.ConfigurarPlaceholder(MTB_Codigo, "Código del Cliente", False)
        Botones.ConfigurarPlaceholder(MTB_Nombre, "Nombre del Cliente", False)
        Botones.ConfigurarPlaceholder(MTB_Telefono, "Teléfono", False)
        Botones.ConfigurarPlaceholder(MTB_Direccion, "Dirección (Opcional)", False)
        Botones.ConfigurarPlaceholder(MTB_Correo, "Correo electrónico (Opcional)", False)
        Botones.ConfigurarPlaceholder(MTB_RFC, "RFC (Opcional)", False)

        If IdVendedorAEditar > 0 Then
            CargarDatosVendedor(IdVendedorAEditar)
        End If
    End Sub

    Private Sub UC_C_Modificar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub

    ' Método auxiliar para consultar y rellenar las cajas de texto según el ID del vendedor/cliente
    Private Sub CargarDatosVendedor(idBuscado As Integer)
        Try
            Dim query As String = "SELECT id_v, nom_v, telefono_v, dirección_v, correo_v, RFC_v FROM Vendedores WHERE id_v = @id"
            Dim db As New ConexionBD()

            Using conexion As SqliteConnection = db.ObtenerConexion()
                If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                    Using comando As New SqliteCommand(query, conexion)
                        comando.Parameters.Add(New SqliteParameter("@id", idBuscado))
                        Using lector As SqliteDataReader = comando.ExecuteReader()
                            If lector.Read() Then
                                MTB_Codigo.Text = lector("id_v").ToString()
                                MTB_Nombre.Text = lector("nom_v").ToString()
                                MTB_Telefono.Text = lector("telefono_v").ToString()
                                MTB_Direccion.Text = lector("dirección_v").ToString()
                                MTB_Correo.Text = lector("correo_v").ToString()
                                MTB_RFC.Text = lector("RFC_v").ToString()
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

    ' Botón 2 Botón de Búsqueda de Cliente/Vendedor por ID
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Vendedores()
        ventanaBusqueda.ShowDialog()

        If Busqueda_Vendedores.VendedorSeleccionado Then
            Botones.AsignarTexto(MTB_Codigo, Busqueda_Vendedores.IdSeleccionado)
            Botones.AsignarTexto(MTB_Nombre, Busqueda_Vendedores.NombreSeleccionado)
            Botones.AsignarTexto(MTB_Telefono, Busqueda_Vendedores.TelefonoSeleccionado)
            Botones.AsignarOpcionPlaceholder(MTB_Direccion, Busqueda_Vendedores.DireccionSeleccionada)
            Botones.AsignarOpcionPlaceholder(MTB_Correo, Busqueda_Vendedores.CorreoSeleccionado)
            Botones.AsignarOpcionPlaceholder(MTB_RFC, Busqueda_Vendedores.RFCSeleccionado)
        End If
    End Sub

    ' Evento del Botón 1: Botón para Modificar / Actualizar los cambios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(MTB_Codigo.Text) Then
            MessageBox.Show("Por favor, seleccione o busque un vendedor primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Está seguro de realizar los cambios?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Asegúrate de que los nombres de las columnas en tu tabla Vendedores coincidan con estos (ej. rfc_v)
                Dim query = "UPDATE Vendedores SET nom_v = @nombre, telefono_v = @telefono, dirección_v = @direccion, correo_v = @correo WHERE id_v = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim)),
                    New SqliteParameter("@nombre", MTB_Nombre.Text.Trim),
                    New SqliteParameter("@telefono", MTB_Telefono.Text.Trim),
                    New SqliteParameter("@direccion", Botones.ObtenerValorLimpio(MTB_Direccion)),
                    New SqliteParameter("@correo", Botones.ObtenerValorLimpio(MTB_Correo)),
                    New SqliteParameter("@rfc", Botones.ObtenerValorLimpio(MTB_RFC))
                }

                Dim filas = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Vendedor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Botones.LimpiarConPlaceholder(MTB_Codigo)
                    Botones.LimpiarConPlaceholder(MTB_Nombre)
                    Botones.LimpiarConPlaceholder(MTB_Telefono)
                    Botones.LimpiarConPlaceholder(MTB_Direccion)
                    Botones.LimpiarConPlaceholder(MTB_Correo)
                    Botones.LimpiarConPlaceholder(MTB_RFC)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el vendedor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class