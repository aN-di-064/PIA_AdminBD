Imports Microsoft.Data.Sqlite

Public Class UC_M_Modificar

    Private Sub UC_M_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()
    End Sub

    Private Sub UC_M_Modificar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    ' Evento del botón superior "Buscar Producto" (Button2)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Materiales()
        ventanaBusqueda.ShowDialog() ' Abre la ventana en modo modal

        ' Al cerrarse, verificamos si el usuario seleccionó un producto con doble clic
        If Busqueda_Materiales.ProductoSeleccionado Then
            MTB_Codigo.Text = Busqueda_Materiales.IdSeleccionado
            MTB_Nombre.Text = Busqueda_Materiales.NombreSeleccionado
            MTB_Tipo.Text = Busqueda_Materiales.TipoSeleccionado
            MTB_Unidad.Text = Busqueda_Materiales.UnidadSeleccionada
            MTB_Pcompra.Text = Busqueda_Materiales.PCompraSeleccionado
            MTB_Pventa.Text = Busqueda_Materiales.PVentaSeleccionado
        End If
    End Sub

    ' Evento del botón inferior para guardar los cambios de la modificación
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(MTB_Codigo.Text) Then
            MessageBox.Show("Por favor, seleccione un producto primero utilizando el botón de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("¿Está seguro de realizar los cambios?", "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim query As String = "UPDATE Materiales SET nom_mat = @nombre, tipo = @tipo, unidad_medida = @unidad, Precio_compra = @pcompra, Precio_Venta = @pventa WHERE Id_mat = @id"

                Dim parametros As New List(Of SqliteParameter) From {
                    New SqliteParameter("@id", Convert.ToInt32(MTB_Codigo.Text.Trim())),
                    New SqliteParameter("@nombre", MTB_Nombre.Text.Trim()),
                    New SqliteParameter("@tipo", MTB_Tipo.Text.Trim()),
                    New SqliteParameter("@unidad", MTB_Unidad.Text.Trim()),
                    New SqliteParameter("@pcompra", Convert.ToDecimal(MTB_Pcompra.Text.Trim())),
                    New SqliteParameter("@pventa", Convert.ToDecimal(MTB_Pventa.Text.Trim()))
                }

                Dim filas As Integer = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Material modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Panel_Form_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Form.Paint
    End Sub

    Private Sub MTB_Codigo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MTB_Codigo.MaskInputRejected
    End Sub

End Class