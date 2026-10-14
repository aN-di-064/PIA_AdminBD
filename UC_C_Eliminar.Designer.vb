<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_C_Eliminar
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
        Label1 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        MTB_RFC = New MaskedTextBox()
        Label7 = New Label()
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
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(107, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 32)
        Label1.TabIndex = 68
        Label1.Text = "Eliminar Material"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(186, 92)
        Button2.Name = "Button2"
        Button2.Size = New Size(324, 23)
        Button2.TabIndex = 82
        Button2.Text = "Buscar Material"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(542, 379)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 85
        Button1.Text = "Eliminar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MTB_RFC
        ' 
        MTB_RFC.Location = New Point(309, 375)
        MTB_RFC.Name = "MTB_RFC"
        MTB_RFC.Size = New Size(201, 23)
        MTB_RFC.TabIndex = 97
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(186, 383)
        Label7.Name = "Label7"
        Label7.Size = New Size(28, 15)
        Label7.TabIndex = 96
        Label7.Text = "RFC"
        ' 
        ' MTB_Correo
        ' 
        MTB_Correo.Location = New Point(309, 330)
        MTB_Correo.Name = "MTB_Correo"
        MTB_Correo.Size = New Size(201, 23)
        MTB_Correo.TabIndex = 95
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(186, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 86
        Label2.Text = "Código"
        ' 
        ' MTB_Dirección
        ' 
        MTB_Dirección.Location = New Point(309, 285)
        MTB_Dirección.Name = "MTB_Dirección"
        MTB_Dirección.Size = New Size(201, 23)
        MTB_Dirección.TabIndex = 94
        ' 
        ' MTB_Codigo
        ' 
        MTB_Codigo.Location = New Point(309, 140)
        MTB_Codigo.Name = "MTB_Codigo"
        MTB_Codigo.Size = New Size(201, 23)
        MTB_Codigo.TabIndex = 87
        ' 
        ' MTB_Telefono
        ' 
        MTB_Telefono.Location = New Point(309, 234)
        MTB_Telefono.Name = "MTB_Telefono"
        MTB_Telefono.Size = New Size(201, 23)
        MTB_Telefono.TabIndex = 93
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(186, 242)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 88
        Label3.Text = "Telefono"
        ' 
        ' MTB_Nombre
        ' 
        MTB_Nombre.Location = New Point(309, 192)
        MTB_Nombre.Name = "MTB_Nombre"
        MTB_Nombre.Size = New Size(201, 23)
        MTB_Nombre.TabIndex = 92
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(186, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 89
        Label4.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(186, 338)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 91
        Label6.Text = "Correo"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(186, 288)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 90
        Label5.Text = "Dirección"
        ' 
        ' UC_C_Eliminar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MTB_RFC)
        Controls.Add(Label7)
        Controls.Add(MTB_Correo)
        Controls.Add(Label2)
        Controls.Add(MTB_Dirección)
        Controls.Add(MTB_Codigo)
        Controls.Add(MTB_Telefono)
        Controls.Add(Label3)
        Controls.Add(MTB_Nombre)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Name = "UC_C_Eliminar"
        Size = New Size(750, 440)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MTB_RFC As MaskedTextBox
    Friend WithEvents Label7 As Label
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

End Class
