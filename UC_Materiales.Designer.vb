<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Materiales
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
        BTN_DEL = New Button()
        BTN_MOD = New Button()
        BTN_NEW = New Button()
        Panel_principal = New Panel()
        Panel_de_contenido = New Panel()
        Panel_de_botones = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel_principal.SuspendLayout()
        Panel_de_botones.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BTN_DEL
        ' 
        BTN_DEL.Font = New Font("Segoe UI", 12F)
        BTN_DEL.Location = New Point(700, 10)
        BTN_DEL.Margin = New Padding(3, 4, 3, 4)
        BTN_DEL.Name = "BTN_DEL"
        BTN_DEL.Size = New Size(140, 40)
        BTN_DEL.TabIndex = 2
        BTN_DEL.Text = "➖Eliminar"
        BTN_DEL.UseVisualStyleBackColor = True
        ' 
        ' BTN_MOD
        ' 
        BTN_MOD.Font = New Font("Segoe UI", 12F)
        BTN_MOD.Location = New Point(420, 10)
        BTN_MOD.Margin = New Padding(3, 4, 3, 4)
        BTN_MOD.Name = "BTN_MOD"
        BTN_MOD.Size = New Size(140, 40)
        BTN_MOD.TabIndex = 1
        BTN_MOD.Text = "✏Modificar"
        BTN_MOD.UseVisualStyleBackColor = True
        ' 
        ' BTN_NEW
        ' 
        BTN_NEW.Font = New Font("Segoe UI", 12F)
        BTN_NEW.Location = New Point(140, 10)
        BTN_NEW.Margin = New Padding(3, 4, 3, 4)
        BTN_NEW.Name = "BTN_NEW"
        BTN_NEW.Size = New Size(140, 40)
        BTN_NEW.TabIndex = 0
        BTN_NEW.Text = "➕Nuevo"
        BTN_NEW.UseVisualStyleBackColor = True
        ' 
        ' Panel_principal
        ' 
        Panel_principal.Anchor = AnchorStyles.None
        Panel_principal.BackColor = Color.White
        Panel_principal.Controls.Add(Panel_de_contenido)
        Panel_principal.Controls.Add(Panel_de_botones)
        Panel_principal.Controls.Add(Label1)
        Panel_principal.Location = New Point(120, 10)
        Panel_principal.Name = "Panel_principal"
        Panel_principal.Size = New Size(1040, 700)
        Panel_principal.TabIndex = 3
        ' 
        ' Panel_de_contenido
        ' 
        Panel_de_contenido.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel_de_contenido.AutoScroll = True
        Panel_de_contenido.BackColor = Color.Transparent
        Panel_de_contenido.Location = New Point(30, 120)
        Panel_de_contenido.Name = "Panel_de_contenido"
        Panel_de_contenido.Size = New Size(980, 540)
        Panel_de_contenido.TabIndex = 5
        ' 
        ' Panel_de_botones
        ' 
        Panel_de_botones.BackColor = Color.WhiteSmoke
        Panel_de_botones.Controls.Add(Button3)
        Panel_de_botones.Controls.Add(BTN_DEL)
        Panel_de_botones.Controls.Add(Button2)
        Panel_de_botones.Controls.Add(Button1)
        Panel_de_botones.Controls.Add(BTN_NEW)
        Panel_de_botones.Controls.Add(BTN_MOD)
        Panel_de_botones.Location = New Point(30, 60)
        Panel_de_botones.Name = "Panel_de_botones"
        Panel_de_botones.Size = New Size(980, 60)
        Panel_de_botones.TabIndex = 4
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F)
        Button3.Location = New Point(700, 10)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 40)
        Button3.TabIndex = 2
        Button3.Text = "➖Eliminar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(140, 10)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 40)
        Button2.TabIndex = 0
        Button2.Text = "➕Nuevo"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(420, 10)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 1
        Button1.Text = "✏Modificar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label1.Location = New Point(30, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 31)
        Label1.TabIndex = 3
        Label1.Text = "Materiales"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel_principal, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1280, 720)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' UC_Materiales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_Materiales"
        Size = New Size(1280, 720)
        Panel_principal.ResumeLayout(False)
        Panel_de_botones.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents BTN_DEL As Button
    Friend WithEvents BTN_MOD As Button
    Friend WithEvents BTN_NEW As Button
    Friend WithEvents Panel_principal As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_de_contenido As Panel
    Friend WithEvents Panel_de_botones As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
