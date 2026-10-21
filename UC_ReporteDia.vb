Imports Microsoft.Data.Sqlite
Imports System.Globalization

Public Class UC_ReporteDia

    Public FechaInicio As DateTime
    Public FechaFin As DateTime
    Public TipoConsulta As String = "Ventas"

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(fInicio As DateTime, fFin As DateTime)
        InitializeComponent()
        FechaInicio = fInicio
        FechaFin = fFin
        TipoConsulta = "Ventas"
    End Sub

    Public Sub New(fInicio As DateTime, fFin As DateTime, tipo As String)
        InitializeComponent()
        FechaInicio = fInicio
        FechaFin = fFin
        TipoConsulta = tipo
    End Sub

    Private Sub UC_ReporteDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FechaInicio = Nothing Then FechaInicio = DateTime.Today
        If FechaFin = Nothing Then FechaFin = DateTime.Today

        Label2.Text = $"{FechaInicio.ToString("dd/MM/yyyy")} al {FechaFin.ToString("dd/MM/yyyy")}"

        ' Configurar el DataGridView para solo lectura en el reporte general
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.MultiSelect = False

        CargarReporte(FechaInicio, FechaFin, TipoConsulta)
    End Sub

    Public Sub CargarReporte(fInicio As DateTime, fFin As DateTime, tipo As String)
        Dim strInicio As String = fInicio.ToString("yyyy-MM-dd") & " 00:00:00"
        Dim strFin As String = fFin.ToString("yyyy-MM-dd") & " 23:59:59"

        Dim tipoConsultaLimpio As String = If(tipo IsNot Nothing, tipo.Trim(), "Ventas")

        ' Actualizar títulos de interfaz
        If tipoConsultaLimpio.Equals("Compras", StringComparison.OrdinalIgnoreCase) Then
            Label1.Text = "Compras del periodo:"
            If LBL_ETIQUETA_TOTAL IsNot Nothing Then LBL_ETIQUETA_TOTAL.Text = "Total de compras:"
        Else
            Label1.Text = "Ventas del periodo:"
            If LBL_ETIQUETA_TOTAL IsNot Nothing Then LBL_ETIQUETA_TOTAL.Text = "Total de ventas:"
        End If

        Dim querySQL As String = ""

        ' Consulta a nivel de Cabecera (Maestro) para mostrar solo los datos generales del ticket
        If tipoConsultaLimpio.Equals("Compras", StringComparison.OrdinalIgnoreCase) Then
            querySQL = "SELECT " &
                       "  c.Id_com AS [ID Compra], " &
                       "  c.fecha_com AS [Fecha], " &
                       "  v.nom_v AS [Vendedor], " &
                       "  c.total_peso_com AS [Peso Total (kg)], " &
                       "  c.total_precio AS [Total], " &
                       "  c.Metodo_pago_com AS [Método Pago] " &
                       "FROM Compra c " &
                       "LEFT JOIN Vendedores v ON c.Id_v = v.Id_v " &
                       "WHERE c.fecha_com BETWEEN @fInicio AND @fFin " &
                       "ORDER BY c.Id_com DESC"
        Else
            querySQL = "SELECT " &
                       "  s.Id_s AS [ID Venta], " &
                       "  s.fecha_s AS [Fecha], " &
                       "  s.total_Kg_s AS [Peso Total (kg)], " &
                       "  s.total_monto AS [Total] " &
                       "FROM Salida s " &
                       "WHERE s.fecha_s BETWEEN @fInicio AND @fFin " &
                       "ORDER BY s.Id_s DESC"
        End If

        Try
            Dim parametros As New List(Of SqliteParameter) From {
                New SqliteParameter("@fInicio", strInicio),
                New SqliteParameter("@fFin", strFin)
            }

            Dim dt As DataTable = ConexionBD.ObtenerDatos(querySQL, parametros)

            ' Limpiar DataGridView y evitar columnas duplicadas
            DataGridView1.DataSource = Nothing
            DataGridView1.Columns.Clear()
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = dt

            ' Calcular el total general sumando la columna de Total de todos los tickets listados
            Dim totalGeneral As Decimal = 0
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("Total")) Then
                        totalGeneral += Convert.ToDecimal(row("Total"))
                    End If
                Next
            End If

            LBL_TOTAL.Text = "$ " & totalGeneral.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error al consultar el reporte de " & tipoConsultaLimpio & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Evento de Doble Clic para mostrar el detalle de los materiales del ticket seleccionado
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim filaSeleccionada As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim idTransaccion As Integer = Convert.ToInt32(filaSeleccionada.Cells(0).Value)
            Dim tipoActual As String = If(TipoConsulta IsNot Nothing, TipoConsulta.Trim(), "Ventas")

            ' Crear una ventana emergente limpia para mostrar el detalle
            Dim formDetalle As New Form()
            formDetalle.Text = If(tipoActual.Equals("Compras", StringComparison.OrdinalIgnoreCase), "Detalle de Compra #" & idTransaccion, "Detalle de Venta #" & idTransaccion)
            formDetalle.Size = New Size(600, 350)
            formDetalle.StartPosition = FormStartPosition.CenterParent
            formDetalle.FormBorderStyle = FormBorderStyle.FixedDialog
            formDetalle.MaximizeBox = False
            formDetalle.MinimizeBox = False

            Dim dgvDetalle As New DataGridView()
            dgvDetalle.Dock = DockStyle.Fill
            dgvDetalle.ReadOnly = True
            dgvDetalle.AllowUserToAddRows = False
            dgvDetalle.AllowUserToDeleteRows = False
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            formDetalle.Controls.Add(dgvDetalle)

            Dim queryDetalle As String = ""
            If tipoActual.Equals("Compras", StringComparison.OrdinalIgnoreCase) Then
                queryDetalle = "SELECT " &
                               "  m.Id_mat AS [Código], " &
                               "  m.nom_mat AS [Material], " &
                               "  dc.Cantidad_kg_DC AS [Cantidad (kg)], " &
                               "  dc.Precio_kg_DC AS [Precio Unitario], " &
                               "  dc.Subtotal_DC AS [Subtotal] " &
                               "FROM Detalle_compra dc " &
                               "INNER JOIN Materiales m ON dc.Id_mat = m.Id_mat " &
                               "WHERE dc.Id_com = @id"
            Else
                queryDetalle = "SELECT " &
                               "  m.Id_mat AS [Código], " &
                               "  m.nom_mat AS [Material], " &
                               "  ds.cantidad_kg_DS AS [Cantidad (kg)], " &
                               "  ds.precio_Kg_DS AS [Precio Unitario], " &
                               "  ds.subtotal_DS AS [Subtotal] " &
                               "FROM Detalle_salida ds " &
                               "INNER JOIN Materiales m ON ds.Id_mat = m.Id_mat " &
                               "WHERE ds.Id_s = @id"
            End If

            Dim parametrosDetalle As New List(Of SqliteParameter) From {
                New SqliteParameter("@id", idTransaccion)
            }

            Dim dtDetalle As DataTable = ConexionBD.ObtenerDatos(queryDetalle, parametrosDetalle)
            dgvDetalle.DataSource = dtDetalle

            formDetalle.ShowDialog()
        End If
    End Sub

End Class