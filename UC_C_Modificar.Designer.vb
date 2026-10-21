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
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        MTB_RFC = New MaskedTextBox()
        Label8 = New Label()
        MTB_Codigo = New MaskedTextBox()
        MTB_Correo = New MaskedTextBox()
        Label11 = New Label()
        MTB_Nombre = New MaskedTextBox()
        Label12 = New Label()
        MTB_Direccion = New MaskedTextBox()
        Label13 = New Label()
        Label10 = New Label()
        MTB_Telefono = New MaskedTextBox()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        TableLayoutPanel1.Size = New Size(800, 600)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(MTB_RFC)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(MTB_Codigo)
        Panel1.Controls.Add(MTB_Correo)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(MTB_Nombre)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(MTB_Direccion)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(MTB_Telefono)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 594)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(100, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 28)
        Label1.TabIndex = 154
        Label1.Text = "Código"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(550, 50)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 34)
        Button2.TabIndex = 140
        Button2.Text = "Buscar Clientes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(356, 487)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 141
        Button1.Text = "Modificar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MTB_RFC
        ' 
        MTB_RFC.Font = New Font("Segoe UI", 12F)
        MTB_RFC.Location = New Point(300, 400)
        MTB_RFC.Margin = New Padding(3, 4, 3, 4)
        MTB_RFC.Name = "MTB_RFC"
        MTB_RFC.Size = New Size(230, 34)
        MTB_RFC.TabIndex = 153
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(100, 400)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 28)
        Label8.TabIndex = 152
        Label8.Text = "RFC"
        ' 
        ' MTB_Codigo
        ' 
        MTB_Codigo.Font = New Font("Segoe UI", 12F)
        MTB_Codigo.Location = New Point(300, 50)
        MTB_Codigo.Margin = New Padding(3, 4, 3, 4)
        MTB_Codigo.Name = "MTB_Codigo"
        MTB_Codigo.Size = New Size(230, 34)
        MTB_Codigo.TabIndex = 143
        ' 
        ' MTB_Correo
        ' 
        MTB_Correo.Font = New Font("Segoe UI", 12F)
        MTB_Correo.Location = New Point(300, 330)
        MTB_Correo.Margin = New Padding(3, 4, 3, 4)
        MTB_Correo.Name = "MTB_Correo"
        MTB_Correo.Size = New Size(230, 34)
        MTB_Correo.TabIndex = 151
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F)
        Label11.Location = New Point(100, 120)
        Label11.Name = "Label11"
        Label11.Size = New Size(85, 28)
        Label11.TabIndex = 145
        Label11.Text = "Nombre"
        ' 
        ' MTB_Nombre
        ' 
        MTB_Nombre.Font = New Font("Segoe UI", 12F)
        MTB_Nombre.Location = New Point(300, 120)
        MTB_Nombre.Margin = New Padding(3, 4, 3, 4)
        MTB_Nombre.Name = "MTB_Nombre"
        MTB_Nombre.Size = New Size(230, 34)
        MTB_Nombre.TabIndex = 148
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F)
        Label12.Location = New Point(100, 330)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 28)
        Label12.TabIndex = 147
        Label12.Text = "Correo"
        ' 
        ' MTB_Direccion
        ' 
        MTB_Direccion.Font = New Font("Segoe UI", 12F)
        MTB_Direccion.Location = New Point(300, 260)
        MTB_Direccion.Margin = New Padding(3, 4, 3, 4)
        MTB_Direccion.Name = "MTB_Direccion"
        MTB_Direccion.Size = New Size(230, 34)
        MTB_Direccion.TabIndex = 150
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 12F)
        Label13.Location = New Point(100, 260)
        Label13.Name = "Label13"
        Label13.Size = New Size(94, 28)
        Label13.TabIndex = 146
        Label13.Text = "Dirección"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(100, 190)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 28)
        Label10.TabIndex = 144
        Label10.Text = "Telefono"
        ' 
        ' MTB_Telefono
        ' 
        MTB_Telefono.Font = New Font("Segoe UI", 12F)
        MTB_Telefono.Location = New Point(300, 190)
        MTB_Telefono.Margin = New Padding(3, 4, 3, 4)
        MTB_Telefono.Name = "MTB_Telefono"
        MTB_Telefono.Size = New Size(230, 34)
        MTB_Telefono.TabIndex = 149
        ' 
        ' UC_C_Modificar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_C_Modificar"
        Size = New Size(800, 600)
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MTB_RFC As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MTB_Codigo As MaskedTextBox
    Friend WithEvents MTB_Correo As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MTB_Nombre As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents MTB_Direccion As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MTB_Telefono As MaskedTextBox

End Class
