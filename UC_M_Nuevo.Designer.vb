<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_M_Nuevo
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
        Panel_Form = New Panel()
        MTB_Pventa = New MaskedTextBox()
        Label7 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        MTB_Pcompra = New MaskedTextBox()
        Label2 = New Label()
        MTB_Unidad = New MaskedTextBox()
        MTB_Codigo = New MaskedTextBox()
        MTB_Tipo = New MaskedTextBox()
        Label3 = New Label()
        MTB_Nombre = New MaskedTextBox()
        Label4 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Panel_Form.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel_Form
        ' 
        Panel_Form.Controls.Add(MTB_Pventa)
        Panel_Form.Controls.Add(Label7)
        Panel_Form.Controls.Add(Label1)
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
        Panel_Form.Dock = DockStyle.Fill
        Panel_Form.Location = New Point(0, 0)
        Panel_Form.Margin = New Padding(3, 4, 3, 4)
        Panel_Form.Name = "Panel_Form"
        Panel_Form.Size = New Size(775, 537)
        Panel_Form.TabIndex = 0
        ' 
        ' MTB_Pventa
        ' 
        MTB_Pventa.Location = New Point(288, 452)
        MTB_Pventa.Margin = New Padding(3, 4, 3, 4)
        MTB_Pventa.Name = "MTB_Pventa"
        MTB_Pventa.Size = New Size(229, 27)
        MTB_Pventa.TabIndex = 37
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(147, 463)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 20)
        Label7.TabIndex = 36
        Label7.Text = "Precio de venta"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 41)
        Label1.TabIndex = 24
        Label1.Text = "Agregar Nuevo Material"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(583, 452)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 27
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MTB_Pcompra
        ' 
        MTB_Pcompra.Location = New Point(288, 392)
        MTB_Pcompra.Margin = New Padding(3, 4, 3, 4)
        MTB_Pcompra.Name = "MTB_Pcompra"
        MTB_Pcompra.Size = New Size(229, 27)
        MTB_Pcompra.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 25
        Label2.Text = "Código"
        ' 
        ' MTB_Unidad
        ' 
        MTB_Unidad.Location = New Point(288, 332)
        MTB_Unidad.Margin = New Padding(3, 4, 3, 4)
        MTB_Unidad.Name = "MTB_Unidad"
        MTB_Unidad.Size = New Size(229, 27)
        MTB_Unidad.TabIndex = 34
        ' 
        ' MTB_Codigo
        ' 
        MTB_Codigo.Location = New Point(288, 139)
        MTB_Codigo.Margin = New Padding(3, 4, 3, 4)
        MTB_Codigo.Name = "MTB_Codigo"
        MTB_Codigo.Size = New Size(229, 27)
        MTB_Codigo.TabIndex = 26
        ' 
        ' MTB_Tipo
        ' 
        MTB_Tipo.Location = New Point(288, 264)
        MTB_Tipo.Margin = New Padding(3, 4, 3, 4)
        MTB_Tipo.Name = "MTB_Tipo"
        MTB_Tipo.Size = New Size(229, 27)
        MTB_Tipo.TabIndex = 33
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(147, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 28
        Label3.Text = "Tipo"
        ' 
        ' MTB_Nombre
        ' 
        MTB_Nombre.Location = New Point(288, 208)
        MTB_Nombre.Margin = New Padding(3, 4, 3, 4)
        MTB_Nombre.Name = "MTB_Nombre"
        MTB_Nombre.Size = New Size(229, 27)
        MTB_Nombre.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(147, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 29
        Label4.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(147, 403)
        Label6.Name = "Label6"
        Label6.Size = New Size(126, 20)
        Label6.TabIndex = 31
        Label6.Text = "Precio de compra"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(147, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 20)
        Label5.TabIndex = 30
        Label5.Text = "Unidad"
        ' 
        ' UC_M_Nuevo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_Form)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_M_Nuevo"
        Size = New Size(775, 537)
        Panel_Form.ResumeLayout(False)
        Panel_Form.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel_Form As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MTB_Pcompra As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MTB_Unidad As MaskedTextBox
    Friend WithEvents MTB_Codigo As MaskedTextBox
    Friend WithEvents MTB_Tipo As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MTB_Nombre As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MTB_Pventa As MaskedTextBox
    Friend WithEvents Label7 As Label

End Class
