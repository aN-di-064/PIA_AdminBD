Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class UC_Consulta_Inventario

    Private Sub UC_Consulta_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar todos los productos al abrir la vista por primera vez
        CargarInventario()
    End Sub

    ' Método para consultar la base de datos y llenar el DataGridView con los precios de compra y venta
    Private Sub CargarInventario(Optional filtro As String = "")
        Try
            Dim query As String = "SELECT Id_mat AS 'Código', nom_mat AS 'Nombre', tipo AS 'Tipo', unidad_medida AS 'Unidad', Precio_compra AS 'Precio Compra', Precio_Venta AS 'Precio Venta' FROM Materiales"

            ' Si hay texto en el buscador, filtramos por nombre usando LIKE de forma segura
            Dim parametros As New List(Of SqliteParameter) From {}

            If Not String.IsNullOrEmpty(filtro) Then
                query &= " WHERE nom_mat LIKE @filtro"
                parametros.Add(New SqliteParameter("@filtro", "%" & filtro & "%"))
            End If

            ' Consulta directa mediante la conexión absoluta para mostrar los datos en el DataGridView
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

            ' Asignar los datos al DataGridView
            dgvProductos.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar el inventario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento para buscar automáticamente conforme escriben en la caja de texto del nombre
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarInventario(txtBuscar.Text.Trim())
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
        ' Evento por defecto
    End Sub

End Class