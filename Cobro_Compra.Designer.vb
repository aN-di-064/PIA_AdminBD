<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobro_Compra
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
        Label4 = New Label()
        TXT_CAMBIO = New TextBox()
        Label3 = New Label()
        TXT_DR = New TextBox()
        BTN_CONFIRMAR = New Button()
        Label2 = New Label()
        TXT_TOTAL = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(92, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 15)
        Label4.TabIndex = 14
        Label4.Text = "Cambio"
        ' 
        ' TXT_CAMBIO
        ' 
        TXT_CAMBIO.Location = New Point(227, 169)
        TXT_CAMBIO.Name = "TXT_CAMBIO"
        TXT_CAMBIO.ReadOnly = True
        TXT_CAMBIO.Size = New Size(150, 23)
        TXT_CAMBIO.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 15)
        Label3.TabIndex = 12
        Label3.Text = "Dinero recibido:"
        ' 
        ' TXT_DR
        ' 
        TXT_DR.Location = New Point(227, 134)
        TXT_DR.Name = "TXT_DR"
        TXT_DR.Size = New Size(150, 23)
        TXT_DR.TabIndex = 11
        ' 
        ' BTN_CONFIRMAR
        ' 
        BTN_CONFIRMAR.Location = New Point(320, 321)
        BTN_CONFIRMAR.Name = "BTN_CONFIRMAR"
        BTN_CONFIRMAR.Size = New Size(135, 23)
        BTN_CONFIRMAR.TabIndex = 10
        BTN_CONFIRMAR.Text = "Confirmar compra"
        BTN_CONFIRMAR.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 15)
        Label2.TabIndex = 9
        Label2.Text = "Total:"
        ' 
        ' TXT_TOTAL
        ' 
        TXT_TOTAL.Location = New Point(227, 102)
        TXT_TOTAL.Name = "TXT_TOTAL"
        TXT_TOTAL.ReadOnly = True
        TXT_TOTAL.Size = New Size(150, 23)
        TXT_TOTAL.TabIndex = 8
        ' 
        ' Cobro_Compra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(467, 356)
        Controls.Add(Label4)
        Controls.Add(TXT_CAMBIO)
        Controls.Add(Label3)
        Controls.Add(TXT_DR)
        Controls.Add(BTN_CONFIRMAR)
        Controls.Add(Label2)
        Controls.Add(TXT_TOTAL)
        MaximizeBox = False
        MaximumSize = New Size(483, 395)
        MinimizeBox = False
        MinimumSize = New Size(483, 395)
        Name = "Cobro_Compra"
        Text = "Cobro_Compra"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CAMBIO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_DR As TextBox
    Friend WithEvents BTN_CONFIRMAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TOTAL As TextBox
End Class
