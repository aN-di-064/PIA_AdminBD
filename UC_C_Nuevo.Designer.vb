<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_C_Nuevo
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
        MTB_RFC = New MaskedTextBox()
        Label7 = New Label()
        Button1 = New Button()
        MTB_Correo = New MaskedTextBox()
        Label2 = New Label()
        MTB_Dirección = New MaskedTextBox()
        MTB_Codigo = New MaskedTextBox()
        MTB_Telefono = New MaskedTextBox()
        Label3 = New Label()
        MTB_Nombre = New MaskedTextBox()
        Label4 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MTB_RFC
        ' 
        MTB_RFC.Font = New Font("Segoe UI", 12F)
        MTB_RFC.Location = New Point(300, 400)
        MTB_RFC.Margin = New Padding(3, 4, 3, 4)
        MTB_RFC.Name = "MTB_RFC"
        MTB_RFC.Size = New Size(230, 34)
        MTB_RFC.TabIndex = 51
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(100, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(46, 28)
        Label7.TabIndex = 50
        Label7.Text = "RFC"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(350, 470)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 41
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MTB_Correo
        ' 
        MTB_Correo.Font = New Font("Segoe UI", 12F)
        MTB_Correo.Location = New Point(300, 330)
        MTB_Correo.Margin = New Padding(3, 4, 3, 4)
        MTB_Correo.Name = "MTB_Correo"
        MTB_Correo.Size = New Size(230, 34)
        MTB_Correo.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(100, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 28)
        Label2.TabIndex = 39
        Label2.Text = "Código"
        ' 
        ' MTB_Dirección
        ' 
        MTB_Dirección.Font = New Font("Segoe UI", 12F)
        MTB_Dirección.Location = New Point(300, 260)
        MTB_Dirección.Margin = New Padding(3, 4, 3, 4)
        MTB_Dirección.Name = "MTB_Dirección"
        MTB_Dirección.Size = New Size(230, 34)
        MTB_Dirección.TabIndex = 48
        ' 
        ' MTB_Codigo
        ' 
        MTB_Codigo.Font = New Font("Segoe UI", 12F)
        MTB_Codigo.Location = New Point(300, 50)
        MTB_Codigo.Margin = New Padding(3, 4, 3, 4)
        MTB_Codigo.Name = "MTB_Codigo"
        MTB_Codigo.Size = New Size(230, 34)
        MTB_Codigo.TabIndex = 40
        ' 
        ' MTB_Telefono
        ' 
        MTB_Telefono.Font = New Font("Segoe UI", 12F)
        MTB_Telefono.Location = New Point(300, 190)
        MTB_Telefono.Margin = New Padding(3, 4, 3, 4)
        MTB_Telefono.Name = "MTB_Telefono"
        MTB_Telefono.Size = New Size(230, 34)
        MTB_Telefono.TabIndex = 47
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(100, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 28)
        Label3.TabIndex = 42
        Label3.Text = "Telefono"
        ' 
        ' MTB_Nombre
        ' 
        MTB_Nombre.Font = New Font("Segoe UI", 12F)
        MTB_Nombre.Location = New Point(300, 120)
        MTB_Nombre.Margin = New Padding(3, 4, 3, 4)
        MTB_Nombre.Name = "MTB_Nombre"
        MTB_Nombre.Size = New Size(230, 34)
        MTB_Nombre.TabIndex = 46
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(100, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 28)
        Label4.TabIndex = 43
        Label4.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(100, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 28)
        Label6.TabIndex = 45
        Label6.Text = "Correo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(100, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 28)
        Label5.TabIndex = 44
        Label5.Text = "Dirección"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.AutoScroll = True
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(MTB_RFC)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(MTB_Correo)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(MTB_Dirección)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(MTB_Telefono)
        Panel1.Controls.Add(MTB_Codigo)
        Panel1.Controls.Add(MTB_Nombre)
        Panel1.Controls.Add(Label6)
        Panel1.Font = New Font("Segoe UI", 12F)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 594)
        Panel1.TabIndex = 52
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
        TableLayoutPanel1.TabIndex = 53
        ' 
        ' UC_C_Nuevo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_C_Nuevo"
        Size = New Size(800, 600)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MTB_RFC As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MTB_Correo As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MTB_Dirección As MaskedTextBox
    Friend WithEvents MTB_Codigo As MaskedTextBox
    Friend WithEvents MTB_Telefono As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MTB_Nombre As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
