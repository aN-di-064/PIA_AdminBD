Public Class Interfaz_Principal
    ' Importamos la función SendMessage de user32.dll para controlar el redibujado de la ventana
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function
    Private Const WM_SETREDRAW As Integer = &HB

    ' Cambiar la ventana
    Private Sub MostrarVista(ByVal vista As UserControl)
        ' Congelamos el redibujado gráfico del panel a nivel de Windows
        SendMessage(panelContenido.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero)
        panelContenido.SuspendLayout()

        panelContenido.Controls.Clear()

        vista.Dock = DockStyle.Fill
        panelContenido.Controls.Add(vista)
        vista.BringToFront()

        If TypeOf vista Is UC_Materiales Then
            DirectCast(vista, UC_Materiales).CentrarFormulario()
        End If
        If TypeOf vista Is UC_Clientes Then
            DirectCast(vista, UC_Clientes).CentrarFormulario()
        End If

        ' Reactivamos el redibujado y forzamos a que pinte ya centrado
        SendMessage(panelContenido.Handle, WM_SETREDRAW, New IntPtr(1), IntPtr.Zero)
        panelContenido.ResumeLayout(True)
        panelContenido.Refresh()
    End Sub
    Public Sub New()
        InitializeComponent()

        ' Activar doble búfer para evitar el parpadeo al cambiar de pantallas
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
        Me.UpdateStyles()
    End Sub

    Private Sub Interfaz_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.AplicarEstiloToolStrip(ToolStrip1)
        CentrarMenuToolStrip()
    End Sub
    Private Sub CentrarMenuToolStrip()
        If ToolStrip1 Is Nothing OrElse ToolStripButton1 Is Nothing Then Return

        ' 1. Calcular el ancho total que suman los 6 botones centrales (del 1 al 6)
        Dim anchoMenuCentral As Integer = ToolStripButton1.Width + ToolStripButton5.Width +
                                      ToolStripButton4.Width + ToolStripButton2.Width +
                                      ToolStripButton6.Width + ToolStripButton3.Width

        ' 2. Obtener el ancho real del logo/título que está a la izquierda
        Dim anchoIzquierda As Integer = 0
        If ToolStripLabel1 IsNot Nothing AndAlso ToolStripLabel1.Visible Then
            anchoIzquierda = ToolStripLabel1.Width + ToolStripLabel1.Margin.Horizontal
        End If

        ' 3. Calcular el centro exacto de todo el ToolStrip y restarle la mitad del menú y el espacio del logo, ademas de un ajuste
        ' de 30 pixeles para que no quede pegado al logo
        Dim centroBarra As Integer = ToolStrip1.ClientSize.Width \ 2
        Dim margenIzquierdo As Integer = centroBarra - (anchoMenuCentral \ 2) - anchoIzquierda - 30

        ' Seguridad para evitar valores negativos
        If margenIzquierdo < 10 Then margenIzquierdo = 10

        ' 4. Aplicar el margen calculado al primer botón central (Ventas)
        ToolStripButton1.Margin = New Padding(margenIzquierdo, ToolStripButton1.Margin.Top, ToolStripButton1.Margin.Right, ToolStripButton1.Margin.Bottom)
    End Sub

    Private Sub Interfaz_Principal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CentrarMenuToolStrip()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MostrarVista(New UC_Ventas)
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        ' 1. Obtener el botón exacto que fue presionado usando e.ClickedItem
        Dim botonActual As ToolStripButton = TryCast(e.ClickedItem, ToolStripButton)

        If botonActual IsNot Nothing Then
            ' 2. Recorrer todos los elementos de la barra (ToolStrip)
            For Each item As ToolStripItem In ToolStrip1.Items
                Dim btn As ToolStripButton = TryCast(item, ToolStripButton)

                If btn IsNot Nothing Then
                    If btn Is botonActual Then
                        ' Si es el botón al que se le dio clic, se queda marcado
                        btn.Checked = True
                    Else
                        ' A todos los demás se les quita la marca
                        btn.Checked = False
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        MostrarVista(New UC_Materiales)
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        MostrarVista(New UC_Clientes)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ' Se permite el acceso a todos los usuarios sin validar el rol

        ' Instanciar el formulario RangoFechas
        Using frmRango As New Rango_Fechas
            ' Abrir la ventana de manera modal
            If frmRango.ShowDialog = DialogResult.OK Then
                ' Capturar las fechas definidas en la ventana modal
                Dim fInicio = frmRango.FechaInicio
                Dim fFin = frmRango.FechaFin

                ' Cargar la vista pasándole el rango de fechas
                MostrarVista(New UC_ReporteDia(fInicio, fFin))
            End If
        End Using
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        MostrarVista(New UC_Consulta_Inventario)
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        login.Show()
        Hide()
    End Sub

End Class