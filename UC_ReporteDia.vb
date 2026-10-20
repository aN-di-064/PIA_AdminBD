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

        ' Consultas individuales (sin GROUP BY para que cada ticket y registro aparezca por separado)
        If tipoConsultaLimpio.Equals("Compras", StringComparison.OrdinalIgnoreCase) Then
            querySQL = "SELECT " &
                       "  c.Id_com AS [ID Compra], " &
                       "  c.fecha_com AS [Fecha], " &
                       "  m.Id_mat AS [Código], " &
                       "  m.nom_mat AS [Descripción], " &
                       "  dc.Cantidad_kg_DC AS [Cantidad], " &
                       "  dc.Precio_kg_DC AS [Precio], " &
                       "  dc.Subtotal_DC AS [Importe] " &
                       "FROM Compra c " &
                       "INNER JOIN Detalle_compra dc ON c.Id_com = dc.Id_com " &
                       "INNER JOIN Materiales m ON dc.Id_mat = m.Id_mat " &
                       "WHERE c.fecha_com BETWEEN @fInicio AND @fFin " &
                       "ORDER BY c.Id_com DESC"
        Else
            querySQL = "SELECT " &
                       "  s.Id_s AS [ID Venta], " &
                       "  s.fecha_s AS [Fecha], " &
                       "  m.Id_mat AS [Código], " &
                       "  m.nom_mat AS [Descripción], " &
                       "  ds.cantidad_kg_DS AS [Cantidad], " &
                       "  ds.precio_Kg_DS AS [Precio], " &
                       "  ds.subtotal_DS AS [Importe] " &
                       "FROM Salida s " &
                       "INNER JOIN Detalle_salida ds ON s.Id_s = ds.Id_s " &
                       "INNER JOIN Materiales m ON ds.Id_mat = m.Id_mat " &
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

            ' Calcular el total general sumando la columna de Importe de todos los registros listados
            Dim totalGeneral As Decimal = 0
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    If Not IsDBNull(row("Importe")) Then
                        totalGeneral += Convert.ToDecimal(row("Importe"))
                    End If
                Next
            End If

            LBL_TOTAL.Text = "$ " & totalGeneral.ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error al consultar el reporte de " & tipoConsultaLimpio & ": " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class