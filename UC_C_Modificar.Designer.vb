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
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(116, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 41)
        Label1.TabIndex = 52
        Label1.Text = "Modificar Cliente"
        ' 
        ' RFC
        ' 
        RFC.Location = New Point(321, 474)
        RFC.Margin = New Padding(3, 4, 3, 4)
        RFC.Name = "RFC"
        RFC.Size = New Size(229, 27)
        RFC.TabIndex = 139
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(181, 484)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 20)
        Label8.TabIndex = 138
        Label8.Text = "RFC"
        ' 
        ' Correo
        ' 
        Correo.Location = New Point(321, 414)
        Correo.Margin = New Padding(3, 4, 3, 4)
        Correo.Name = "Correo"
        Correo.Size = New Size(229, 27)
        Correo.TabIndex = 137
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(181, 164)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 20)
        Label9.TabIndex = 128
        Label9.Text = "Código"
        ' 
        ' Dire
        ' 
        Dire.Location = New Point(321, 354)
        Dire.Margin = New Padding(3, 4, 3, 4)
        Dire.Name = "Dire"
        Dire.Size = New Size(229, 27)
        Dire.TabIndex = 136
        ' 
        ' ID
        ' 
        ID.Location = New Point(321, 160)
        ID.Margin = New Padding(3, 4, 3, 4)
        ID.Name = "ID"
        ID.Size = New Size(229, 27)
        ID.TabIndex = 129
        ' 
        ' Telf
        ' 
        Telf.Location = New Point(321, 286)
        Telf.Margin = New Padding(3, 4, 3, 4)
        Telf.Name = "Telf"
        Telf.Size = New Size(229, 27)
        Telf.TabIndex = 135
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(181, 296)
        Label10.Name = "Label10"
        Label10.Size = New Size(67, 20)
        Label10.TabIndex = 130
        Label10.Text = "Telefono"
        ' 
        ' Nom
        ' 
        Nom.Location = New Point(321, 230)
        Nom.Margin = New Padding(3, 4, 3, 4)
        Nom.Name = "Nom"
        Nom.Size = New Size(229, 27)
        Nom.TabIndex = 134
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(181, 230)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 20)
        Label11.TabIndex = 131
        Label11.Text = "Nombre"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(181, 424)
        Label12.Name = "Label12"
        Label12.Size = New Size(54, 20)
        Label12.TabIndex = 133
        Label12.Text = "Correo"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(181, 358)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 20)
        Label13.TabIndex = 132
        Label13.Text = "Dirección"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(588, 479)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 127
        Button1.Text = "Modificar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(181, 96)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(370, 31)
        Button2.TabIndex = 126
        Button2.Text = "Buscar Material"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(RFC)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Correo)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Dire)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(ID)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(Telf)
        Panel1.Controls.Add(Nom)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(0, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(857, 584)
        Panel1.TabIndex = 140
        ' 
        ' UC_C_Modificar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_C_Modificar"
        Size = New Size(857, 587)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label1 As Label
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

End Class
