Imports Microsoft.Data.Sqlite

Public Class UC_I_Eliminar

    Private Sub UC_I_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()
    End Sub

    Private Sub UC_I_Eliminar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    ' Evento del botón superior "Buscar Producto" 
    ' (Si tu botón superior tiene otro nombre en las Propiedades, asegúrate de cambiar "Button2" por el nombre correcto)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Inventario()
        ventanaBusqueda.ShowDialog() ' Abre la ventana en modo modal

        ' Al cerrarse, recuperamos los datos del producto seleccionado mediante doble clic
        If Busqueda_Inventario.ProductoSeleccionado Then
            MTB_Codigo.Text = Busqueda_Inventario.IdSeleccionado
            MTB_Nombre.Text = Busqueda_Inventario.NombreSeleccionado
            MTB_Tipo.Text = Busqueda_Inventario.TipoSeleccionado
            MTB_Unidad.Text = Busqueda_Inventario.UnidadSeleccionada
            MTB_Pcompra.Text = Busqueda_Inventario.PCompraSeleccionado
            MTB_Pventa.Text = Busqueda_Inventario.PVentaSeleccionado
        End If
    End Sub

    ' Evento del botón "Eliminar" (Button1)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Validar que se haya seleccionado un producto previamente
        If String.IsNullOrEmpty(MTB_Codigo.Text) Then
            MessageBox.Show("Por favor, seleccione un producto primero utilizando el botón de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Preguntar al usuario si realmente desea eliminar el registro
        If MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                ' 3. Sentencia DELETE para la base de datos
                Dim query As String = "DELETE FROM Materiales WHERE Id_mat = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim()))
                }

                ' 4. Ejecutar el comando mediante la clase helper
                Dim filas As Integer = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Material eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Limpiar los campos después de la eliminación
                    MTB_Codigo.Clear()
                    MTB_Nombre.Clear()
                    MTB_Tipo.Clear()
                    MTB_Unidad.Clear()
                    MTB_Pcompra.Clear()
                    MTB_Pventa.Clear()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class