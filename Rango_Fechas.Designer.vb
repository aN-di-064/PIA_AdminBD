<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rango_Fechas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        CB_TIPOCONSULTA = New ComboBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Location = New Point(197, 289)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 9
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 15)
        Label2.TabIndex = 8
        Label2.Text = "Seleccione la fecha del fin del reporte"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 15)
        Label1.TabIndex = 7
        Label1.Text = "Seleccione la fecha de Inicio de reporte"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(255, 143)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(255, 68)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 5
        ' 
        ' CB_TIPOCONSULTA
        ' 
        CB_TIPOCONSULTA.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CB_TIPOCONSULTA.AutoCompleteSource = AutoCompleteSource.ListItems
        CB_TIPOCONSULTA.FormattingEnabled = True
        CB_TIPOCONSULTA.Items.AddRange(New Object() {"Compras", "Ventas"})
        CB_TIPOCONSULTA.Location = New Point(255, 209)
        CB_TIPOCONSULTA.Name = "CB_TIPOCONSULTA"
        CB_TIPOCONSULTA.Size = New Size(121, 23)
        CB_TIPOCONSULTA.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 15)
        Label3.TabIndex = 27
        Label3.Text = "Seleccione la opción que desea consultar:"
        ' 
        ' Rango_Fechas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 346)
        Controls.Add(Label3)
        Controls.Add(CB_TIPOCONSULTA)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Rango_Fechas"
        Text = "Rango_Fechas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CB_TIPOCONSULTA As ComboBox
    Friend WithEvents Label3 As Label
End Class
