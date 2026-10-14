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
        Label1 = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        Label8 = New Label()
        MaskedTextBox2 = New MaskedTextBox()
        Label9 = New Label()
        MaskedTextBox3 = New MaskedTextBox()
        MaskedTextBox4 = New MaskedTextBox()
        MaskedTextBox5 = New MaskedTextBox()
        Label10 = New Label()
        MaskedTextBox6 = New MaskedTextBox()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(96, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 32)
        Label1.TabIndex = 52
        Label1.Text = "Modificar Cliente"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(276, 389)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(201, 23)
        MaskedTextBox1.TabIndex = 139
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(153, 397)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 15)
        Label8.TabIndex = 138
        Label8.Text = "RFC"
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Location = New Point(276, 344)
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(201, 23)
        MaskedTextBox2.TabIndex = 137
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(153, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 15)
        Label9.TabIndex = 128
        Label9.Text = "Código"
        ' 
        ' MaskedTextBox3
        ' 
        MaskedTextBox3.Location = New Point(276, 299)
        MaskedTextBox3.Name = "MaskedTextBox3"
        MaskedTextBox3.Size = New Size(201, 23)
        MaskedTextBox3.TabIndex = 136
        ' 
        ' MaskedTextBox4
        ' 
        MaskedTextBox4.Location = New Point(276, 154)
        MaskedTextBox4.Name = "MaskedTextBox4"
        MaskedTextBox4.Size = New Size(201, 23)
        MaskedTextBox4.TabIndex = 129
        ' 
        ' MaskedTextBox5
        ' 
        MaskedTextBox5.Location = New Point(276, 248)
        MaskedTextBox5.Name = "MaskedTextBox5"
        MaskedTextBox5.Size = New Size(201, 23)
        MaskedTextBox5.TabIndex = 135
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(153, 256)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 15)
        Label10.TabIndex = 130
        Label10.Text = "Telefono"
        ' 
        ' MaskedTextBox6
        ' 
        MaskedTextBox6.Location = New Point(276, 206)
        MaskedTextBox6.Name = "MaskedTextBox6"
        MaskedTextBox6.Size = New Size(201, 23)
        MaskedTextBox6.TabIndex = 134
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(153, 206)
        Label11.Name = "Label11"
        Label11.Size = New Size(51, 15)
        Label11.TabIndex = 131
        Label11.Text = "Nombre"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(153, 352)
        Label12.Name = "Label12"
        Label12.Size = New Size(43, 15)
        Label12.TabIndex = 133
        Label12.Text = "Correo"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(153, 302)
        Label13.Name = "Label13"
        Label13.Size = New Size(57, 15)
        Label13.TabIndex = 132
        Label13.Text = "Dirección"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(509, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 127
        Button2.Text = "Eliminar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(153, 106)
        Button3.Name = "Button3"
        Button3.Size = New Size(324, 23)
        Button3.TabIndex = 126
        Button3.Text = "Buscar Material"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' UC_C_Modificar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(MaskedTextBox1)
        Controls.Add(Label8)
        Controls.Add(MaskedTextBox2)
        Controls.Add(Label9)
        Controls.Add(MaskedTextBox3)
        Controls.Add(MaskedTextBox4)
        Controls.Add(MaskedTextBox5)
        Controls.Add(Label10)
        Controls.Add(MaskedTextBox6)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(Label13)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Name = "UC_C_Modificar"
        Size = New Size(750, 440)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MaskedTextBox6 As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
