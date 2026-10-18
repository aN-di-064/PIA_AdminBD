<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_M_Eliminar
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
        Label5 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        MTB_Nombre = New MaskedTextBox()
        Label3 = New Label()
        MTB_Tipo = New MaskedTextBox()
        MTB_Codigo = New MaskedTextBox()
        MTB_Unidad = New MaskedTextBox()
        Label2 = New Label()
        MTB_Pcompra = New MaskedTextBox()
        Button1 = New Button()
        Label7 = New Label()
        MTB_Pventa = New MaskedTextBox()
        Button2 = New Button()
        Panel_Form = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel_Form.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(100, 260)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 28)
        Label5.TabIndex = 59
        Label5.Text = "Unidad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(100, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(165, 28)
        Label6.TabIndex = 60
        Label6.Text = "Precio de compra"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(100, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 28)
        Label4.TabIndex = 58
        Label4.Text = "Nombre"
        ' 
        ' MTB_Nombre
        ' 
        MTB_Nombre.Font = New Font("Segoe UI", 12F)
        MTB_Nombre.Location = New Point(300, 120)
        MTB_Nombre.Margin = New Padding(3, 4, 3, 4)
        MTB_Nombre.Name = "MTB_Nombre"
        MTB_Nombre.Size = New Size(230, 34)
        MTB_Nombre.TabIndex = 61
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(100, 190)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 28)
        Label3.TabIndex = 57
        Label3.Text = "Tipo"
        ' 
        ' MTB_Tipo
        ' 
        MTB_Tipo.Font = New Font("Segoe UI", 12F)
        MTB_Tipo.Location = New Point(300, 190)
        MTB_Tipo.Margin = New Padding(3, 4, 3, 4)
        MTB_Tipo.Name = "MTB_Tipo"
        MTB_Tipo.Size = New Size(230, 34)
        MTB_Tipo.TabIndex = 62
        ' 
        ' MTB_Codigo
        ' 
        MTB_Codigo.Font = New Font("Segoe UI", 12F)
        MTB_Codigo.Location = New Point(300, 50)
        MTB_Codigo.Margin = New Padding(3, 4, 3, 4)
        MTB_Codigo.Name = "MTB_Codigo"
        MTB_Codigo.Size = New Size(230, 34)
        MTB_Codigo.TabIndex = 55
        ' 
        ' MTB_Unidad
        ' 
        MTB_Unidad.Font = New Font("Segoe UI", 12F)
        MTB_Unidad.Location = New Point(300, 260)
        MTB_Unidad.Margin = New Padding(3, 4, 3, 4)
        MTB_Unidad.Name = "MTB_Unidad"
        MTB_Unidad.Size = New Size(230, 34)
        MTB_Unidad.TabIndex = 63
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(100, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 28)
        Label2.TabIndex = 54
        Label2.Text = "Código"
        ' 
        ' MTB_Pcompra
        ' 
        MTB_Pcompra.Font = New Font("Segoe UI", 12F)
        MTB_Pcompra.Location = New Point(300, 330)
        MTB_Pcompra.Margin = New Padding(3, 4, 3, 4)
        MTB_Pcompra.Name = "MTB_Pcompra"
        MTB_Pcompra.Size = New Size(230, 34)
        MTB_Pcompra.TabIndex = 64
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(350, 470)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 40)
        Button1.TabIndex = 56
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(100, 400)
        Label7.Name = "Label7"
        Label7.Size = New Size(146, 28)
        Label7.TabIndex = 65
        Label7.Text = "Precio de venta"
        ' 
        ' MTB_Pventa
        ' 
        MTB_Pventa.Font = New Font("Segoe UI", 12F)
        MTB_Pventa.Location = New Point(300, 400)
        MTB_Pventa.Margin = New Padding(3, 4, 3, 4)
        MTB_Pventa.Name = "MTB_Pventa"
        MTB_Pventa.Size = New Size(229, 34)
        MTB_Pventa.TabIndex = 66
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(550, 50)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 34)
        Button2.TabIndex = 67
        Button2.Text = "Buscar Material"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel_Form
        ' 
        Panel_Form.Anchor = AnchorStyles.None
        Panel_Form.Controls.Add(Button2)
        Panel_Form.Controls.Add(MTB_Pventa)
        Panel_Form.Controls.Add(Label7)
        Panel_Form.Controls.Add(Button1)
        Panel_Form.Controls.Add(MTB_Pcompra)
        Panel_Form.Controls.Add(Label2)
        Panel_Form.Controls.Add(MTB_Unidad)
        Panel_Form.Controls.Add(MTB_Codigo)
        Panel_Form.Controls.Add(MTB_Tipo)
        Panel_Form.Controls.Add(Label3)
        Panel_Form.Controls.Add(MTB_Nombre)
        Panel_Form.Controls.Add(Label4)
        Panel_Form.Controls.Add(Label6)
        Panel_Form.Controls.Add(Label5)
        Panel_Form.Location = New Point(3, 4)
        Panel_Form.Margin = New Padding(3, 4, 3, 4)
        Panel_Form.Name = "Panel_Form"
        Panel_Form.Size = New Size(794, 592)
        Panel_Form.TabIndex = 1
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(Panel_Form, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 600)
        TableLayoutPanel1.TabIndex = 2
        ' 
        ' UC_M_Eliminar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_M_Eliminar"
        Size = New Size(800, 600)
        Panel_Form.ResumeLayout(False)
        Panel_Form.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MTB_Nombre As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MTB_Tipo As MaskedTextBox
    Friend WithEvents MTB_Codigo As MaskedTextBox
    Friend WithEvents MTB_Unidad As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MTB_Pcompra As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents MTB_Pventa As MaskedTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel_Form As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel

End Class
