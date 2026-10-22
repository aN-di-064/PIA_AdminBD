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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cobro_Compra))
        Label4 = New Label()
        TXT_CAMBIO = New TextBox()
        Label3 = New Label()
        TXT_DR = New TextBox()
        BTN_CONFIRMAR = New Button()
        Label2 = New Label()
        TXT_TOTAL = New TextBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(34, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 28)
        Label4.TabIndex = 14
        Label4.Text = "Cambio"
        ' 
        ' TXT_CAMBIO
        ' 
        TXT_CAMBIO.BackColor = Color.White
        TXT_CAMBIO.Font = New Font("Segoe UI", 12F)
        TXT_CAMBIO.Location = New Point(204, 200)
        TXT_CAMBIO.Margin = New Padding(3, 4, 3, 4)
        TXT_CAMBIO.Name = "TXT_CAMBIO"
        TXT_CAMBIO.ReadOnly = True
        TXT_CAMBIO.Size = New Size(171, 34)
        TXT_CAMBIO.TabIndex = 13
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(34, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 28)
        Label3.TabIndex = 12
        Label3.Text = "Dinero recibido:"
        ' 
        ' TXT_DR
        ' 
        TXT_DR.BackColor = Color.White
        TXT_DR.Font = New Font("Segoe UI", 12F)
        TXT_DR.Location = New Point(204, 140)
        TXT_DR.Margin = New Padding(3, 4, 3, 4)
        TXT_DR.Name = "TXT_DR"
        TXT_DR.Size = New Size(171, 34)
        TXT_DR.TabIndex = 11
        ' 
        ' BTN_CONFIRMAR
        ' 
        BTN_CONFIRMAR.Font = New Font("Segoe UI", 12F)
        BTN_CONFIRMAR.Location = New Point(134, 260)
        BTN_CONFIRMAR.Margin = New Padding(3, 4, 3, 4)
        BTN_CONFIRMAR.Name = "BTN_CONFIRMAR"
        BTN_CONFIRMAR.Size = New Size(140, 40)
        BTN_CONFIRMAR.TabIndex = 10
        BTN_CONFIRMAR.Text = "Confirmar compra"
        BTN_CONFIRMAR.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(34, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 28)
        Label2.TabIndex = 9
        Label2.Text = "Total:"
        ' 
        ' TXT_TOTAL
        ' 
        TXT_TOTAL.BackColor = Color.White
        TXT_TOTAL.Font = New Font("Segoe UI", 12F)
        TXT_TOTAL.Location = New Point(204, 80)
        TXT_TOTAL.Margin = New Padding(3, 4, 3, 4)
        TXT_TOTAL.Name = "TXT_TOTAL"
        TXT_TOTAL.ReadOnly = True
        TXT_TOTAL.Size = New Size(171, 34)
        TXT_TOTAL.TabIndex = 8
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
        TableLayoutPanel1.Size = New Size(482, 453)
        TableLayoutPanel1.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(BTN_CONFIRMAR)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TXT_CAMBIO)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TXT_DR)
        Panel1.Controls.Add(TXT_TOTAL)
        Panel1.Location = New Point(41, 26)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 400)
        Panel1.TabIndex = 0
        ' 
        ' Cobro_Compra
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 453)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MaximumSize = New Size(500, 500)
        MinimizeBox = False
        MinimumSize = New Size(500, 500)
        Name = "Cobro_Compra"
        Text = "Cobro Compra"
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CAMBIO As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_DR As TextBox
    Friend WithEvents BTN_CONFIRMAR As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
