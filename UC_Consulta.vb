Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class UC_Consulta

    Private idSeleccionado As Integer = 0

    Private Sub UC_Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count = 0 Then
            ComboBox1.Items.Add("Materiales")
            ComboBox1.Items.Add("Vendedores")
            ComboBox1.SelectedIndex = 0
        End If
        Botones.CentrarTotal(Panel1)
        Botones.Redondear(Panel1, 20)
        Botones.Redondear(txtBuscar, 10)

        Botones.ConfigurarPlaceholder(txtBuscar, "Buscar...", False)
        Botones.EstiloDataGrid(dgvProductos)
        CargarDatosTabla(txtBuscar.Text.Trim())
    End Sub
    Private Sub UC_Consulta_Resized(sender As Object, e As EventArgs) Handles MyBase.Resize
        Botones.CentrarTotal(Panel1)
    End Sub
    Private Sub CargarDatosTabla(Optional filtro As String = "")
        If filtro = "Buscar..." Then
            filtro = ""
        End If
        Try
            Dim query As String = ""
            Dim parametros As New List(Of SqliteParameter) From {}
            If ComboBox1.SelectedIndex = 0 Then
                query = "SELECT Id_mat AS 'Código', nom_mat AS 'Nombre', tipo AS 'Tipo', unidad_medida AS 'Unidad', Precio_compra AS 'Precio Compra', Precio_Venta AS 'Precio Venta' FROM Materiales"
                If Not String.IsNullOrEmpty(filtro) Then
                    query &= " WHERE nom_mat LIKE @filtro"
                    parametros.Add(New SqliteParameter("@filtro", "%" & filtro & "%"))
                End If
            ElseIf ComboBox1.SelectedIndex = 1 Then
                query = "SELECT id_v AS 'ID', nom_v AS 'Nombre', telefono_v AS 'Teléfono', dirección_v AS 'Dirección', correo_v AS 'Correo', rfc_v AS 'RFC' FROM Vendedores"
                If Not String.IsNullOrEmpty(filtro) Then
                    query &= " WHERE nom_v LIKE @filtro"
                    parametros.Add(New SqliteParameter("@filtro", "%" & filtro & "%"))
                End If
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
            dgvProductos.DataSource = dt
            idSeleccionado = 0
        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        CargarDatosTabla(txtBuscar.Text.Trim())
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarDatosTabla(txtBuscar.Text.Trim())
    End Sub
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)
            If fila.Cells(0).Value IsNot Nothing Then
                Integer.TryParse(fila.Cells(0).Value.ToString(), idSeleccionado)
            End If
        End If
    End Sub
End Class