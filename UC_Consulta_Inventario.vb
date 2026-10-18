Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class UC_Consulta_Inventario

    Private idSeleccionado As Integer = 0

    Private Sub UC_Consulta_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBox1.Items.Count = 0 Then
            ComboBox1.Items.Add("Inventario (Materiales)")
            ComboBox1.Items.Add("Vendedores")
            ComboBox1.SelectedIndex = 0
        End If

        CargarDatosTabla(txtBuscar.Text.Trim())
    End Sub

    Private Sub CargarDatosTabla(Optional filtro As String = "")
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
                query = "SELECT id_v AS 'ID', nom_v AS 'Nombre', telefono_v AS 'Teléfono', dirección_v AS 'Dirección', correo_v AS 'Correo' FROM Vendedores"
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

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If idSeleccionado = 0 Then
            MessageBox.Show("Por favor selecciona un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBox1.SelectedIndex = 0 Then
            ' --- OPCIÓN 0: MATERIALES ---
            Dim ucModifMaterial As New UC_M_Modificar()
            ucModifMaterial.IdMaterialAEditar = idSeleccionado
            ucModifMaterial.Dock = DockStyle.Fill
            Me.Controls.Add(ucModifMaterial)
            ucModifMaterial.BringToFront()

        ElseIf ComboBox1.SelectedIndex = 1 Then
            ' --- OPCIÓN 1: VENDEDORES / CLIENTES ---
            Dim ucModifCliente As New UC_C_Modificar()
            ucModifCliente.IdVendedorAEditar = idSeleccionado
            ucModifCliente.Dock = DockStyle.Fill
            Me.Controls.Add(ucModifCliente)
            ucModifCliente.BringToFront()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idSeleccionado = 0 Then
            MessageBox.Show("Por favor selecciona un registro de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirmacion As DialogResult = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirmacion = DialogResult.Yes Then
            Dim query As String = ""
            If ComboBox1.SelectedIndex = 0 Then
                query = "DELETE FROM Materiales WHERE Id_mat = @id"
            Else
                query = "DELETE FROM Vendedores WHERE id_v = @id"
            End If

            Dim parametros As New List(Of SqliteParameter) From {
                New SqliteParameter("@id", idSeleccionado)
            }

            Dim filasAfectadas As Integer = ConexionBD.EjecutarComando(query, parametros)

            If filasAfectadas > 0 Then
                MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarDatosTabla(txtBuscar.Text.Trim())
            End If
        End If
    End Sub

End Class