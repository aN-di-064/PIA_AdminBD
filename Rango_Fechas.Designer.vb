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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rango_Fechas))
        Button1 = New Button()
        Label2 = New Label()
        Label1 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        CB_TIPOCONSULTA = New ComboBox()
        Label3 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(175, 358)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 9
        Button1.Text = "Aceptar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(20, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(180, 56)
        Label2.TabIndex = 8
        Label2.Text = "Seleccione la fecha " & vbCrLf & "del fin del reporte"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(20, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 56)
        Label1.TabIndex = 7
        Label1.Text = "Seleccione la fecha " & vbCrLf & "de Inicio de reporte"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI", 12F)
        DateTimePicker2.Font = New Font("Segoe UI", 12F)
        DateTimePicker2.Location = New Point(220, 160)
        DateTimePicker2.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(260, 34)
        DateTimePicker2.TabIndex = 6
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 12F)
        DateTimePicker1.Font = New Font("Segoe UI", 12F)
        DateTimePicker1.Location = New Point(220, 60)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(260, 34)
        DateTimePicker1.TabIndex = 5
        ' 
        ' CB_TIPOCONSULTA
        ' 
        CB_TIPOCONSULTA.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CB_TIPOCONSULTA.AutoCompleteSource = AutoCompleteSource.ListItems
        CB_TIPOCONSULTA.Font = New Font("Segoe UI", 12F)
        CB_TIPOCONSULTA.FormattingEnabled = True
        CB_TIPOCONSULTA.Items.AddRange(New Object() {"Compras", "Ventas"})
        CB_TIPOCONSULTA.Location = New Point(220, 260)
        CB_TIPOCONSULTA.Margin = New Padding(3, 4, 3, 4)
        CB_TIPOCONSULTA.Name = "CB_TIPOCONSULTA"
        CB_TIPOCONSULTA.Size = New Size(260, 36)
        CB_TIPOCONSULTA.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(20, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 56)
        Label3.TabIndex = 27
        Label3.Text = "Seleccione la opción " & vbCrLf & "que desea consultar:"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel1, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(582, 553)
        TableLayoutPanel1.TabIndex = 28
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(CB_TIPOCONSULTA)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(41, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(500, 500)
        Panel1.TabIndex = 0
        ' 
        ' Rango_Fechas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 553)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Rango_Fechas"
        Text = "Rango Fechas"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CB_TIPOCONSULTA As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
