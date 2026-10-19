<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobro_Venta
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
        Label1 = New Label()
        TXT_TOTAL = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        TXT_DR = New TextBox()
        Label4 = New Label()
        TXT_CAMBIO = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' TXT_TOTAL
        ' 
        TXT_TOTAL.Location = New Point(224, 99)
        TXT_TOTAL.Name = "TXT_TOTAL"
        TXT_TOTAL.ReadOnly = True
        TXT_TOTAL.Size = New Size(150, 23)
        TXT_TOTAL.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(89, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 2
        Label2.Text = "Total:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(320, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 23)
        Button1.TabIndex = 3
        Button1.Text = "Confirmar venta"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(89, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 5
        Label3.Text = "Dinero recibido:"
        ' 
        ' TXT_DR
        ' 
        TXT_DR.Location = New Point(224, 131)
        TXT_DR.Name = "TXT_DR"
        TXT_DR.Size = New Size(150, 23)
        TXT_DR.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(89, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 7
        Label4.Text = "Cambio"
        ' 
        ' TXT_CAMBIO
        ' 
        TXT_CAMBIO.Location = New Point(224, 166)
        TXT_CAMBIO.Name = "TXT_CAMBIO"
        TXT_CAMBIO.ReadOnly = True
        TXT_CAMBIO.Size = New Size(150, 23)
        TXT_CAMBIO.TabIndex = 6
        ' 
        ' Cobro_Venta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(467, 356)
        Controls.Add(Label4)
        Controls.Add(TXT_CAMBIO)
        Controls.Add(Label3)
        Controls.Add(TXT_DR)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(TXT_TOTAL)
        Controls.Add(Label1)
        MaximizeBox = False
        MaximumSize = New Size(483, 395)
        MinimizeBox = False
        MinimumSize = New Size(483, 395)
        Name = "Cobro_Venta"
        Text = "Cobro_Venta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_DR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CAMBIO As TextBox
End Class
