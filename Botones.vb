Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class Botones

    ' Método compartido para aplicar bordes redondeados a cualquier botón o panel
    Public Shared Sub Redondear(control As Control, radio As Integer)
        Dim path As New GraphicsPath()
        Dim rect As New Rectangle(0, 0, control.Width, control.Height)

        ' Creamos un rectángulo con esquinas redondeadas
        path.AddArc(rect.X, rect.Y, radio, radio, 180, 90)
        path.AddArc(rect.X + rect.Width - radio, rect.Y, radio, radio, 270, 90)
        path.AddArc(rect.X + rect.Width - radio, rect.Y + rect.Height - radio, radio, radio, 0, 90)
        path.AddArc(rect.X, rect.Y + rect.Height - radio, radio, radio, 90, 90)
        path.CloseFigure()

        ' Asignamos la región redondeada al control
        control.Region = New Region(path)
    End Sub

    ' Centrar un boton Horizontalmente unicamente
    Public Shared Sub CentrarHorizontal(control As Control)
        If control.Parent IsNot Nothing Then
            control.Left = (control.Parent.ClientSize.Width - control.Width) \ 2
        End If
    End Sub

    ' Centrar un Panel o control vertical y horizontalmente
    Public Shared Sub CentrarTotal(control As Control)
        If control.Parent IsNot Nothing Then
            control.Location = New Point(
                (control.Parent.ClientSize.Width - control.Width) \ 2,
                (control.Parent.ClientSize.Height - control.Height) \ 2
            )
        End If
    End Sub

    ' Configuracion del comportamiento de Placeholder en las cajas de texto
    Public Shared Sub ConfigurarPlaceholder(txt As TextBoxBase, placeholderText As String, esPassword As Boolean)
        ' Configuración inicial
        If String.IsNullOrWhiteSpace(txt.Text) OrElse txt.Text = placeholderText Then
            txt.Text = placeholderText
            txt.ForeColor = Color.DarkGray
            If TypeOf txt Is TextBox AndAlso esPassword Then
                DirectCast(txt, TextBox).UseSystemPasswordChar = False
            End If
        End If

        ' Para cuando el control se le da click,se borra el placeholder y se cambia el color de la letra a negro
        AddHandler txt.Enter, Sub(sender As Object, e As EventArgs)
                                  If txt.Text = placeholderText Then
                                      txt.Text = ""
                                      txt.ForeColor = Color.Black
                                      If TypeOf txt Is TextBox AndAlso esPassword Then
                                          DirectCast(txt, TextBox).UseSystemPasswordChar = True
                                      End If
                                  End If
                              End Sub

        ' Para cuando el control deja de estar seleccionado, vuelve a poner el placeholder
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

    ' Funcion para asignar texto a un TextBoxBase y asegurarse de que no sea nulo, además de establecer el color de fuente a negro
    Public Shared Sub AsignarTexto(txt As TextBoxBase, valor As String)
        txt.Text = If(valor IsNot Nothing, valor, "")
        txt.ForeColor = Color.Black
    End Sub

    ' Funcion para aplicar estilo al toolstrip
    Public Shared Sub AplicarEstiloToolStrip(ts As ToolStrip)
        ts.Renderer = New CustomToolStripRenderer()
        ts.BackColor = Color.White
        ts.GripStyle = ToolStripGripStyle.Hidden
        ts.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular)
    End Sub

    ' clase anidada para renderizar los elementos del toolstrip
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

            ' Dibujo de esquinas redondeadas según el estado del botón
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

        Protected Overrides Sub OnRenderToolStripBorder(e As ToolStripRenderEventArgs)
            ' Oculta la línea gris por defecto
        End Sub
        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            ' No dibujar líneas separadoras
        End Sub

    End Class
End Class