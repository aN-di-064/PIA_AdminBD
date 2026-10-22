Imports System.Globalization

Public Class Cobro_Compra

    ' Propiedades públicas para compartir información con UC_Compras
    Public TotalPagar As Decimal = 0
    Public DineroRecibido As Decimal = 0
    Public Cambio As Decimal = 0
    Public MetodoPago As String = "Efectivo"

    Private Sub Cobro_Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Proteger los campos de total y cambio para que sean solo de lectura
        TXT_TOTAL.ReadOnly = True
        TXT_CAMBIO.ReadOnly = True

        ' Mostrar el total a pagar recibido desde UC_Compras
        TXT_TOTAL.Text = "$ " & TotalPagar.ToString("N2")
        TXT_DR.Text = ""
        TXT_CAMBIO.Text = "$ 0.00"

        Botones.CentrarTotal(Panel1)
        Botones.Redondear(TXT_CAMBIO, 10)
        Botones.Redondear(TXT_DR, 10)
        Botones.Redondear(TXT_TOTAL, 10)
        Botones.Redondear(BTN_CONFIRMAR, 10)

        Botones.ConfigurarPlaceholder(TXT_DR, "Dinero recibido", False)

        TXT_DR.Focus()
    End Sub

    ' Calcular el cambio dinámicamente conforme el usuario escribe en TXT_DR
    Private Sub TXT_DR_TextChanged(sender As Object, e As EventArgs) Handles TXT_DR.TextChanged
        Dim recibido As Decimal = 0
        Dim textoIngresado As String = TXT_DR.Text.Replace("$", "").Trim()

        If Decimal.TryParse(textoIngresado, NumberStyles.Any, CultureInfo.CurrentCulture, recibido) OrElse
           Decimal.TryParse(textoIngresado, NumberStyles.Any, CultureInfo.InvariantCulture, recibido) Then

            DineroRecibido = recibido
            If recibido >= TotalPagar Then
                Cambio = recibido - TotalPagar
                TXT_CAMBIO.Text = "$ " & Cambio.ToString("N2")
            Else
                Cambio = 0
                TXT_CAMBIO.Text = "$ 0.00"
            End If
        Else
            DineroRecibido = 0
            Cambio = 0
            TXT_CAMBIO.Text = "$ 0.00"
        End If
    End Sub

    ' Confirmar la compra al hacer clic en el botón
    Private Sub BTN_CONFIRMAR_Click(sender As Object, e As EventArgs) Handles BTN_CONFIRMAR.Click
        If DineroRecibido < TotalPagar Then
            MessageBox.Show("El dinero recibido no cubre el total de la compra.", "Monto insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXT_DR.Focus()
            Return
        End If

        ' Indicar que todo salió bien y cerrar la ventana para proceder con el guardado en la base de datos
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Permitir confirmar presionando la tecla Enter en TXT_DR
    Private Sub TXT_DR_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_DR.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTN_CONFIRMAR.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class