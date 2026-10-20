Public Class UC_Clientes
    Public Sub CentrarFormulario()
        If Panel_principal IsNot Nothing Then
            Botones.CentrarTotal(Panel_principal)
        End If
    End Sub
    Private Sub UC_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarFormulario()

        Botones.Redondear(Panel_principal, 16)
        Botones.Redondear(Panel_de_botones, 8)
        Botones.Redondear(BTN_NEW, 10)
        Botones.Redondear(BTN_MOD, 10)
        Botones.Redondear(BTN_DEL, 10)

        BTN_NEW.PerformClick()
    End Sub
    Private Sub UC_Clientes_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CentrarFormulario()
    End Sub
    Private Sub MostrarSubVista(uc As UserControl, botonActivo As System.Windows.Forms.Button)
        Panel_de_contenido.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel_de_contenido.Controls.Add(uc)
        uc.BringToFront()
    End Sub
    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        MostrarSubVista(New UC_C_Nuevo(), BTN_NEW)
    End Sub
    Private Sub BTN_MOD_Click(sender As Object, e As EventArgs) Handles BTN_MOD.Click
        MostrarSubVista(New UC_C_Modificar(), BTN_MOD)
    End Sub
    Private Sub BTN_DEL_Click(sender As Object, e As EventArgs) Handles BTN_DEL.Click
        MostrarSubVista(New UC_C_Eliminar(), BTN_DEL)
    End Sub
End Class