Imports Microsoft.Data.Sqlite

Public Class UC_M_Modificar

    Public IdMaterialAEditar As Integer = 0

    Private Sub UC_M_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.CentrarTotal(Panel1)

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

        If IdMaterialAEditar > 0 Then
            CargarDatosMaterialPorId(IdMaterialAEditar)
        End If
    End Sub

    Private Sub UC_M_Modificar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub

    ' Método auxiliar para consultar y rellenar los datos cuando se pasa el ID directamente
    Private Sub CargarDatosMaterialPorId(id As Integer)
        Try
            Dim query As String = "SELECT Id_mat, nom_mat, tipo, unidad_medida, Precio_compra, Precio_Venta FROM Materiales WHERE Id_mat = @id"
            Dim db As New ConexionBD()

            Using conexion As SqliteConnection = db.ObtenerConexion()
                If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                    Using comando As New SqliteCommand(query, conexion)
                        comando.Parameters.Add(New SqliteParameter("@id", id))
                        Using lector As SqliteDataReader = comando.ExecuteReader()
                            If lector.Read() Then
                                MTB_Codigo.Text = lector("Id_mat").ToString()
                                MTB_Nombre.Text = lector("nom_mat").ToString()
                                MTB_Tipo.Text = lector("tipo").ToString()
                                MTB_Unidad.Text = lector("unidad_medida").ToString()
                                MTB_Pcompra.Text = lector("Precio_compra").ToString()
                                MTB_Pventa.Text = lector("Precio_Venta").ToString()
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos del material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento del botón superior "Buscar Producto" (Button2) - Por si entran directo a la pantalla
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ventanaBusqueda As New Busqueda_Materiales()
        ventanaBusqueda.ShowDialog() ' Abre la ventana en modo modal

        ' Al cerrarse, verificamos si el usuario seleccionó un producto con doble clic
        If Busqueda_Materiales.ProductoSeleccionado Then
            Botones.AsignarTexto(MTB_Codigo, Busqueda_Materiales.IdSeleccionado)
            Botones.AsignarTexto(MTB_Nombre, Busqueda_Materiales.NombreSeleccionado)
            Botones.AsignarTexto(MTB_Tipo, Busqueda_Materiales.TipoSeleccionado)
            Botones.AsignarTexto(MTB_Unidad, Busqueda_Materiales.UnidadSeleccionada)
            Botones.AsignarTexto(MTB_Pcompra, Busqueda_Materiales.PCompraSeleccionado)
            Botones.AsignarTexto(MTB_Pventa, Busqueda_Materiales.PVentaSeleccionado)
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

Namespaces:
                Dim filas As Integer = ConexionBD.EjecutarComando(query, parametros)

                If filas > 0 Then
                    MessageBox.Show("Material modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose() ' Cierra la vista al terminar de modificar con éxito
                End If

            Catch ex As Exception
                MessageBox.Show("Error al actualizar el material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class