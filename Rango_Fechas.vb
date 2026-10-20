Public Class Rango_Fechas

    ' Propiedades públicas para compartir la selección con UC_ReporteDia
    Public FechaInicio As DateTime
    Public FechaFin As DateTime
    Public TipoConsulta As String = "Ventas"

    Private Sub Rango_Fechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con las dos opciones disponibles
        CB_TIPOCONSULTA.Items.Clear()
        CB_TIPOCONSULTA.Items.Add("Ventas")
        CB_TIPOCONSULTA.Items.Add("Compras")

        ' Seleccionar "Ventas" por defecto
        CB_TIPOCONSULTA.SelectedIndex = 0

        ' Configurar las fechas actuales por defecto
        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DateTimePicker1.Value.Date > DateTimePicker2.Value.Date Then
            MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha de fin.", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        FechaInicio = DateTimePicker1.Value.Date
        FechaFin = DateTimePicker2.Value.Date

        ' Capturar directamente el texto seleccionado en el ComboBox
        If CB_TIPOCONSULTA.Text <> "" Then
            TipoConsulta = CB_TIPOCONSULTA.Text.Trim()
        Else
            TipoConsulta = "Ventas"
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class