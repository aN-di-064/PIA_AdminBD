Imports Microsoft.Data.Sqlite
Imports System.Data

Public Class Busqueda_Vendedores
    ' Propiedades públicas para almacenar los datos del vendedor seleccionado momentáneamente
    Public Shared Property IdSeleccionado As String = ""
    Public Shared Property NombreSeleccionado As String = ""
    Public Shared Property TelefonoSeleccionado As String = ""
    Public Shared Property DireccionSeleccionada As String = ""
    Public Shared Property CorreoSeleccionado As String = ""
    Public Shared Property RFCSeleccionado As String = ""
    Public Shared Property VendedorSeleccionado As Boolean = False
    Private Sub Busqueda_Vendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VendedorSeleccionado = False
        Botones.Redondear(Panel1, 20)
        Botones.EstiloDataGrid(dgvVendedores)
        Botones.ConfigurarPlaceholder(txtBuscar, "Buscar Vendedor...", False)
        CargarVendedores()
        dgvVendedores.AllowUserToAddRows = False
    End Sub
    Private Sub CargarVendedores(Optional filtro As String = "")
        Try
            Dim query As String = "SELECT id_v AS 'ID', nom_v AS 'Nombre', telefono_v AS 'Teléfono', dirección_v AS 'Dirección', correo_v AS 'Correo', RFC_v AS 'RFC' FROM Vendedores"
            Dim parametros As New List(Of SqliteParameter) From {}
            If Not String.IsNullOrEmpty(filtro) Then
                query &= " WHERE nom_v LIKE @filtro"
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
            dgvVendedores.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar los vendedores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarVendedores(txtBuscar.Text.Trim())
    End Sub
    ' Evento de doble clic para capturar la fila seleccionada
    Private Sub dgvVendedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVendedores.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvVendedores.Rows(e.RowIndex)
            IdSeleccionado = fila.Cells("ID").Value.ToString()
            NombreSeleccionado = fila.Cells("Nombre").Value.ToString()
            TelefonoSeleccionado = fila.Cells("Teléfono").Value.ToString()
            DireccionSeleccionada = fila.Cells("Dirección").Value.ToString()
            CorreoSeleccionado = fila.Cells("Correo").Value.ToString()
            RFCSeleccionado = fila.Cells("RFC").Value.ToString()
            VendedorSeleccionado = True
            Me.Close()
        End If
    End Sub
End Class