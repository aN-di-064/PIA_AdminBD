Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class UC_Materiales
    Public Sub CentrarFormulario()
        If Panel_principal IsNot Nothing Then
            Botones.CentrarTotal(Panel_principal)
        End If
    End Sub
    Private Sub UC_Materiales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()

        Botones.Redondear(Panel_principal, 16)
        Botones.Redondear(Panel_de_botones, 8)
        Botones.Redondear(BTN_NEW, 10)
        Botones.Redondear(BTN_MOD, 10)
        Botones.Redondear(BTN_DEL, 10)

        ' Simula un clic en el botón Nuevo al abrir la vista por primera vez
        BTN_NEW.PerformClick()
    End Sub
    ' Mantiene centrada la tarjeta si se cambia el tamaño de la ventana
    Private Sub UC_Materiales_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentrarFormulario()
    End Sub
    ' Funcion de mostrar el panel de contenido y cambiar el color del boton activo
    Private Sub MostrarSubVista(uc As UserControl, botonActivo As System.Windows.Forms.Button)
        Panel_de_contenido.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel_de_contenido.Controls.Add(uc)
        uc.BringToFront()
    End Sub
    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click, Button2.Click
        MostrarSubVista(New UC_M_Nuevo, BTN_NEW)
    End Sub
    Private Sub BTN_MOD_Click(sender As Object, e As EventArgs) Handles BTN_MOD.Click, Button1.Click
        MostrarSubVista(New UC_M_Modificar, BTN_MOD)
    End Sub
    Private Sub BTN_DEL_Click(sender As Object, e As EventArgs) Handles BTN_DEL.Click, Button3.Click
        MostrarSubVista(New UC_M_Eliminar, BTN_DEL)
    End Sub
End Class