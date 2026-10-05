Public Class Interfaz_Principal
    'Cambiar la ventana
    Private Sub MostrarVista(ByVal vista As UserControl)
        panelContenido.Controls.Clear()

        vista.Dock = DockStyle.Fill

        panelContenido.Controls.Add(vista)
        vista.BringToFront()
    End Sub
    Private Sub Interfaz_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        MostrarVista(New UC_Ventas())
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        MostrarVista(New UC_Inventario())
    End Sub

    Private Sub panelContenido_Paint(sender As Object, e As PaintEventArgs) Handles panelContenido.Paint

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        MostrarVista(New UC_ReporteDia())
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        MostrarVista(New UC_Compras())
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        MostrarVista(New UC_Consulta_Inventario())
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

    End Sub
End Class