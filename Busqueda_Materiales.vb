Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class Busqueda_Materiales

    ' Propiedades públicas para almacenar los datos del material seleccionado momentáneamente
    Public Shared Property IdSeleccionado As String = ""
    Public Shared Property NombreSeleccionado As String = ""
    Public Shared Property TipoSeleccionado As String = ""
    Public Shared Property UnidadSeleccionada As String = ""
    Public Shared Property PCompraSeleccionado As String = ""
    Public Shared Property PVentaSeleccionado As String = ""
    Public Shared Property ProductoSeleccionado As Boolean = False

    Private Sub Busqueda_Materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductoSeleccionado = False
        CargarMateriales()
    End Sub

    Private Sub CargarMateriales(Optional filtro As String = "")
        Try
            Dim query As String = "SELECT Id_mat AS 'Código', nom_mat AS 'Nombre', tipo AS 'Tipo', unidad_medida AS 'Unidad', Precio_compra AS 'Precio Compra', Precio_Venta AS 'Precio Venta' FROM Materiales"

            Dim parametros As New List(Of SqliteParameter) From {}
            If Not String.IsNullOrEmpty(filtro) Then
                query &= " WHERE nom_mat LIKE @filtro"
                parametros.Add(New SqliteParameter("@filtro", "%" & filtro & "%"))
            End If

            Dim dt As New DataTable()
            Dim db As New ConexionBD()

            Using conexion As SqliteConnection = db.ObtenerConexion()
                If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                    Using comando As New SqliteCommand(query, conexion)
                        If parametros.Count > 0 Then
                            comando.Parameters.AddRange(parametros)
                        End If
                        Using lector As SqliteDataReader = comando.ExecuteReader()
                            dt.Load(lector)
                        End Using
                    End Using
                End If
            End Using

            dgvMateriales.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar el inventario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarMateriales(txtBuscar.Text.Trim())
    End Sub

    ' Evento de doble clic para capturar la fila seleccionada
    Private Sub dgvMateriales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateriales.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvMateriales.Rows(e.RowIndex)

            IdSeleccionado = fila.Cells("Código").Value.ToString()
            NombreSeleccionado = fila.Cells("Nombre").Value.ToString()
            TipoSeleccionado = fila.Cells("Tipo").Value.ToString()
            UnidadSeleccionada = fila.Cells("Unidad").Value.ToString()
            PCompraSeleccionado = fila.Cells("Precio Compra").Value.ToString()
            PVentaSeleccionado = fila.Cells("Precio Venta").Value.ToString()

            ProductoSeleccionado = True
            Me.Close()
        End If
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMateriales.CellContentClick
    End Sub

End Class