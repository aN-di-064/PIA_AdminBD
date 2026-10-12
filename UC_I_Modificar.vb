Public Class UC_I_Modificar
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("¿Está seguro de realizar los cambios?", "Confirmar cambios",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Sub

    Private Sub Panel_Form_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Form.Paint

    End Sub

    Private Sub MTB_Codigo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MTB_Codigo.MaskInputRejected

    End Sub
End Class
