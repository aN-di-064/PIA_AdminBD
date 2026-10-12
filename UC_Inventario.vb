Public Class UC_Inventario

    Private Sub UC_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Simula un clic en el botón Nuevo al abrir la vista por primera vez
        BTN_NEW.PerformClick()
    End Sub

    Private Sub MostrarSubVista(uc As UserControl, botonActivo As Button)
        PANEL_DERECHO.Controls.Clear()
        uc.Dock = DockStyle.Fill
        PANEL_DERECHO.Controls.Add(uc)
        uc.BringToFront()

        ' 1. Restablecer el color de todos los botones a su estado normal (Gris por defecto)
        BTN_NEW.BackColor = SystemColors.Control
        BTN_MOD.BackColor = SystemColors.Control
        BTN_DEL.BackColor = SystemColors.Control
        BTN_CAT.BackColor = SystemColors.Control

        ' 2. Cambiar el color únicamente al botón que fue presionado (ej. un tono celeste o azul claro)
        botonActivo.BackColor = Color.LightSkyBlue
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        MostrarSubVista(New UC_I_Nuevo(), BTN_NEW)
    End Sub

    Private Sub BTN_MOD_Click(sender As Object, e As EventArgs) Handles BTN_MOD.Click
        MostrarSubVista(New UC_I_Modificar(), BTN_MOD)
    End Sub

    Private Sub BTN_DEL_Click(sender As Object, e As EventArgs) Handles BTN_DEL.Click
        MostrarSubVista(New UC_I_Eliminar(), BTN_DEL)
    End Sub

    Private Sub BTN_CAT_Click(sender As Object, e As EventArgs) Handles BTN_CAT.Click
        ' Recuerda cambiar UC_I_Nuevo por UC_I_Categoria cuando crees esa vista
        MostrarSubVista(New UC_I_Nuevo(), BTN_CAT)
    End Sub

    Private Sub PANEL_IZQUIERDO_Paint(sender As Object, e As PaintEventArgs) Handles PANEL_IZQUIERDO.Paint

    End Sub
End Class
