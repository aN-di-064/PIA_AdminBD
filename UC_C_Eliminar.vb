Imports Microsoft.Data.Sqlite

Public Class UC_C_Eliminar

    Private Sub UC_C_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.CentrarTotal(Panel1)

        Botones.Redondear(MTB_Codigo, 10)
        Botones.Redondear(MTB_Nombre, 10)
        Botones.Redondear(MTB_Telefono, 10)
        Botones.Redondear(MTB_Dirección, 10)
        Botones.Redondear(MTB_Correo, 10)
        Botones.Redondear(MTB_RFC, 10)
        Botones.Redondear(Button1, 10)
        Botones.Redondear(Button2, 10)

        Botones.ConfigurarPlaceholder(MTB_Codigo, "Código del Cliente", False)
        Botones.ConfigurarPlaceholder(MTB_Nombre, "Nombre del Cliente", False)
        Botones.ConfigurarPlaceholder(MTB_Telefono, "Teléfono ", False)
        Botones.ConfigurarPlaceholder(MTB_Dirección, "Dirección (Opcional)", False)
        Botones.ConfigurarPlaceholder(MTB_Correo, "Correo (Opcional)", False)
        Botones.ConfigurarPlaceholder(MTB_RFC, "RFC (Opcional)", False)
    End Sub

    Private Sub UC_C_Eliminar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Vendedores()
        ventanaBusqueda.ShowDialog()

        If Busqueda_Vendedores.VendedorSeleccionado Then
            Botones.AsignarTexto(MTB_Codigo, Busqueda_Vendedores.IdSeleccionado)
            Botones.AsignarTexto(MTB_Nombre, Busqueda_Vendedores.NombreSeleccionado)
            Botones.AsignarTexto(MTB_Telefono, Busqueda_Vendedores.TelefonoSeleccionado)
            Botones.AsignarTexto(MTB_Dirección, Busqueda_Vendedores.DireccionSeleccionada)
            Botones.AsignarTexto(MTB_Correo, Busqueda_Vendedores.CorreoSeleccionado)
            Botones.AsignarTexto(MTB_RFC, Busqueda_Vendedores.RFCSeleccionado)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(MTB_Codigo.Text) Then
            MessageBox.Show("Por favor, seleccione un producto primero utilizando el botón de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim query As String = "DELETE FROM Materiales WHERE Id_mat = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim()))
                }
                Dim filas As Integer = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Material eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Botones.LimpiarConPlaceholder(MTB_Codigo)
                    Botones.LimpiarConPlaceholder(MTB_Nombre)
                    Botones.LimpiarConPlaceholder(MTB_Telefono)
                    Botones.LimpiarConPlaceholder(MTB_Dirección)
                    Botones.LimpiarConPlaceholder(MTB_Correo)
                    Botones.LimpiarConPlaceholder(MTB_RFC)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al eliminar el material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class