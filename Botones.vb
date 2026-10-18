Imports System.Drawing.Drawing2D

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

End Class