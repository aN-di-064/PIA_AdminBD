Imports Microsoft.Data.Sqlite

Public Class UC_M_Eliminar

    Private Sub UC_M_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.CentrarTotal(Panel_Form)

        Botones.Redondear(MTB_Codigo, 10)
        Botones.Redondear(MTB_Nombre, 10)
        Botones.Redondear(MTB_Tipo, 10)
        Botones.Redondear(MTB_Unidad, 10)
        Botones.Redondear(MTB_Pcompra, 10)
        Botones.Redondear(MTB_Pventa, 10)
        Botones.Redondear(Button1, 10)
        Botones.Redondear(Button2, 10)

        Botones.ConfigurarPlaceholder(MTB_Codigo, "Código del material", False)
        Botones.ConfigurarPlaceholder(MTB_Nombre, "Nombre del material", False)
        Botones.ConfigurarPlaceholder(MTB_Tipo, "Tipo de material", False)
        Botones.ConfigurarPlaceholder(MTB_Unidad, "Unidad de medida", False)
        Botones.ConfigurarPlaceholder(MTB_Pcompra, "Precio de compra", False)
        Botones.ConfigurarPlaceholder(MTB_Pventa, "Precio de venta", False)
    End Sub

    Private Sub UC_M_Eliminar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel_Form)
    End Sub

    ' Evento del botón superior "Buscar Producto" 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Materiales()
        ventanaBusqueda.ShowDialog() ' Abre la ventana en modo modal

        ' Al cerrarse, recuperamos los datos del producto seleccionado mediante doble clic
        If Busqueda_Materiales.ProductoSeleccionado Then
            Botones.AsignarTexto(MTB_Codigo, Busqueda_Materiales.IdSeleccionado)
            Botones.AsignarTexto(MTB_Nombre, Busqueda_Materiales.NombreSeleccionado)
            Botones.AsignarTexto(MTB_Tipo, Busqueda_Materiales.TipoSeleccionado)
            Botones.AsignarTexto(MTB_Unidad, Busqueda_Materiales.UnidadSeleccionada)
            Botones.AsignarTexto(MTB_Pcompra, Busqueda_Materiales.PCompraSeleccionado)
            Botones.AsignarTexto(MTB_Pventa, Busqueda_Materiales.PVentaSeleccionado)
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
                    Botones.LimpiarConPlaceholder(MTB_Codigo)
                    Botones.LimpiarConPlaceholder(MTB_Nombre)
                    Botones.LimpiarConPlaceholder(MTB_Tipo)
                    Botones.LimpiarConPlaceholder(MTB_Unidad)
                    Botones.LimpiarConPlaceholder(MTB_Pcompra)
                    Botones.LimpiarConPlaceholder(MTB_Pventa)
                End If

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class