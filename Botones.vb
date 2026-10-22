Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Botones
    Public Shared Sub Redondear(control As Control, radio As Integer)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, control.Width, control.Height)

        path.AddArc(rect.X, rect.Y, radio, radio, 180, 90)
        path.AddArc(rect.X + rect.Width - radio, rect.Y, radio, radio, 270, 90)
        path.AddArc(rect.X + rect.Width - radio, rect.Y + rect.Height - radio, radio, radio, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radio, radio, radio, 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
    End Sub
    Public Shared Sub CentrarHorizontal(control As Control)
        If control.Parent IsNot Nothing Then
            control.Left = (control.Parent.ClientSize.Width - control.Width) \ 2
        End If
    End Sub
    Public Shared Sub CentrarTotal(control As Control)
        If control.Parent IsNot Nothing Then
            control.Location = New Point(
                (control.Parent.ClientSize.Width - control.Width) \ 2,
                (control.Parent.ClientSize.Height - control.Height) \ 2
            )
        End If
    End Sub
    Public Shared Sub EstiloDataGrid(dgv As DataGridView)
        With dgv
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.FixedSingle
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.FromArgb(230, 230, 230)
            .RowTemplate.Height = 35
            .AllowUserToAddRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(40, 40, 40)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)

            .ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(245, 247, 250)
            .ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(40, 40, 40)

            .ColumnHeadersHeight = 40

            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
            .DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50)
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30)
            .DefaultCellStyle.Padding = New Padding(8, 0, 8, 0)

            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250)
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 240, 254)
        End With
    End Sub
    Public Shared Sub ConfigurarPlaceholder(txt As TextBoxBase, placeholderText As String, esPassword As Boolean)
        txt.Tag = placeholderText
        If String.IsNullOrWhiteSpace(txt.Text) OrElse txt.Text = placeholderText Then
            txt.Text = placeholderText
            txt.ForeColor = Color.DarkGray
            If TypeOf txt Is TextBox AndAlso esPassword Then
                DirectCast(txt, TextBox).UseSystemPasswordChar = False
            End If
        End If
        AddHandler txt.Enter, Sub(sender As Object, e As EventArgs)
                                  If txt.Text = placeholderText Then
                                      txt.Text = ""
                                      txt.ForeColor = Color.Black
                                      If TypeOf txt Is TextBox AndAlso esPassword Then
                                          DirectCast(txt, TextBox).UseSystemPasswordChar = True
                                      End If
                                  End If
                              End Sub
        AddHandler txt.Leave, Sub(sender As Object, e As EventArgs)
                                  If String.IsNullOrWhiteSpace(txt.Text) Then
                                      If TypeOf txt Is TextBox AndAlso esPassword Then
                                          DirectCast(txt, TextBox).UseSystemPasswordChar = False
                                      End If
                                      txt.Text = placeholderText
                                      txt.ForeColor = Color.DarkGray
                                  End If
                              End Sub
    End Sub

    Public Shared Sub LimpiarConPlaceholder(txt As TextBoxBase)
        Dim phText As String = If(txt.Tag IsNot Nothing, txt.Tag.ToString(), "")
        txt.Text = phText
        txt.ForeColor = Color.DarkGray
        If TypeOf txt Is TextBox Then
            DirectCast(txt, TextBox).UseSystemPasswordChar = False
        End If
    End Sub
    Public Shared Sub AsignarOpcionPlaceholder(txt As TextBoxBase, valor As String)
        If String.IsNullOrEmpty(valor) Then
            LimpiarConPlaceholder(txt)
        Else
            AsignarTexto(txt, valor)
        End If
    End Sub
    Public Shared Function ObtenerValorLimpio(txt As TextBoxBase) As Object
        Dim phText As String = If(txt.Tag IsNot Nothing, txt.Tag.ToString(), "")

        If String.IsNullOrWhiteSpace(txt.Text) OrElse txt.Text = phText Then
            Return DBNull.Value
        Else
            Return txt.Text.Trim()
        End If
    End Function
    Public Shared Sub AsignarTexto(txt As TextBoxBase, valor As String)
        txt.Text = If(valor IsNot Nothing, valor, "")
        txt.ForeColor = Color.Black
    End Sub
    Public Shared Sub AplicarEstiloToolStrip(ts As ToolStrip)
        ts.Renderer = New CustomToolStripRenderer()
        ts.BackColor = Color.White
        ts.GripStyle = ToolStripGripStyle.Hidden
        ts.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular)
    End Sub
    Private Class CustomToolStripRenderer
        Inherits ToolStripProfessionalRenderer
        Public Sub New()
            MyBase.New(New ProfessionalColorTable() With {.UseSystemColors = False})
        End Sub
        Protected Overrides Sub OnRenderButtonBackground(e As ToolStripItemRenderEventArgs)
            Dim btn = TryCast(e.Item, ToolStripButton)
            If btn Is Nothing Then
                MyBase.OnRenderButtonBackground(e)
                Return
            End If
            Dim g = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim rect As New Rectangle(2, 2, btn.Width - 4, btn.Height - 4)

            Dim path As New GraphicsPath()
            Dim r As Integer = 6
            path.AddArc(rect.X, rect.Y, r, r, 180, 90)
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90)
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90)
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90)
            path.CloseFigure()

            If btn.Checked OrElse btn.Pressed Then
                g.FillPath(New SolidBrush(Color.FromArgb(232, 240, 254)), path)
                g.DrawPath(New Pen(Color.FromArgb(180, 205, 240)), path)
            ElseIf btn.Selected Then
                g.FillPath(New SolidBrush(Color.FromArgb(245, 247, 250)), path)
                g.DrawPath(New Pen(Color.FromArgb(220, 225, 230)), path)
            End If
        End Sub
    End Class
End Class