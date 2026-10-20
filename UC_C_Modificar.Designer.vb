<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_C_Modificar
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        RFC = New MaskedTextBox()
        Label8 = New Label()
        Correo = New MaskedTextBox()
        Label9 = New Label()
        Dire = New MaskedTextBox()
        ID = New MaskedTextBox()
        Telf = New MaskedTextBox()
        Label10 = New Label()
        Nom = New MaskedTextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' RFC
        ' 
        RFC.Font = New Font("Segoe UI", 12F)
        RFC.Location = New Point(300, 400)
        RFC.Margin = New Padding(3, 4, 3, 4)
        RFC.Name = "RFC"
        RFC.Size = New Size(230, 34)
        RFC.TabIndex = 139
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(100, 400)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 28)
        Label8.TabIndex = 138
        Label8.Text = "RFC"
        ' 
        ' Correo
        ' 
        Correo.Font = New Font("Segoe UI", 12F)
        Correo.Location = New Point(300, 330)
        Correo.Margin = New Padding(3, 4, 3, 4)
        Correo.Name = "Correo"
        Correo.Size = New Size(230, 34)
        Correo.TabIndex = 137
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F)
        Label9.Location = New Point(100, 50)
        Label9.Name = "Label9"
        Label9.Size = New Size(77, 28)
        Label9.TabIndex = 128
        Label9.Text = "Código"
        ' 
        ' Dire
        ' 
        Dire.Font = New Font("Segoe UI", 12F)
        Dire.Location = New Point(300, 260)
        Dire.Margin = New Padding(3, 4, 3, 4)
        Dire.Name = "Dire"
        Dire.Size = New Size(230, 34)
        Dire.TabIndex = 136
        ' 
        ' ID
        ' 
        ID.Font = New Font("Segoe UI", 12F)
        ID.Location = New Point(300, 50)
        ID.Margin = New Padding(3, 4, 3, 4)
        ID.Name = "ID"
        ID.Size = New Size(230, 34)
        ID.TabIndex = 129
        ' 
        ' Telf
        ' 
        Telf.Font = New Font("Segoe UI", 12F)
        Telf.Location = New Point(300, 190)
        Telf.Margin = New Padding(3, 4, 3, 4)
        Telf.Name = "Telf"
        Telf.Size = New Size(230, 34)
        Telf.TabIndex = 135
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(100, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 28)
        Label10.TabIndex = 130
        Label10.Text = "Telefono"
        ' 
        ' Nom
        ' 
        Nom.Font = New Font("Segoe UI", 12F)
        Nom.Location = New Point(300, 120)
        Nom.Margin = New Padding(3, 4, 3, 4)
        Nom.Name = "Nom"
        Nom.Size = New Size(230, 34)
        Nom.TabIndex = 134
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(100, 120)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 28)
        Label11.TabIndex = 131
        Label11.Text = "Nombre"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(100, 330)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 28)
        Label12.TabIndex = 133
        Label12.Text = "Correo"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(100, 260)
        Label13.Name = "Label13"
        Label13.Size = New Size(94, 28)
        Label13.TabIndex = 132
        Label13.Text = "Dirección"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(350, 470)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 127
        Button1.Text = "Modificar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(550, 50)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 34)
        Button2.TabIndex = 126
        Button2.Text = "Buscar Clientes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TableLayoutPanel1)
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(857, 584)
        Panel1.TabIndex = 140
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(857, 584)
        TableLayoutPanel1.TabIndex = 141
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(RFC)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(ID)
        Panel2.Controls.Add(Correo)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(Nom)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(Dire)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Telf)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(851, 578)
        Panel2.TabIndex = 140
        ' 
        ' UC_C_Modificar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_C_Modificar"
        Size = New Size(800, 600)
        Panel1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents RFC As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Correo As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Dire As MaskedTextBox
    Friend WithEvents ID As MaskedTextBox
    Friend WithEvents Telf As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Nom As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel

End Class
