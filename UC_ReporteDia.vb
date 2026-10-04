Public Class UC_ReporteDia
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub UC_ReporteDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Asigna la fecha del día actual en formato DD/MM/YYYY (ej. 15/09/2026)
        Label2.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
