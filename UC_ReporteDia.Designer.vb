<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ReporteDia
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
        DataGridView1 = New DataGridView()
        Col_Código = New DataGridViewTextBoxColumn()
        Col_Descripcion = New DataGridViewTextBoxColumn()
        Col_Cantidad = New DataGridViewTextBoxColumn()
        Col_Precio = New DataGridViewTextBoxColumn()
        Col_Importe = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LBL_ETIQUETA_TOTAL = New Label()
        LBL_TOTAL = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Col_Código, Col_Descripcion, Col_Cantidad, Col_Precio, Col_Importe})
        DataGridView1.Location = New Point(30, 120)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(980, 480)
        DataGridView1.TabIndex = 5
        ' 
        ' Col_Código
        ' 
        Col_Código.HeaderText = "Código"
        Col_Código.MinimumWidth = 6
        Col_Código.Name = "Col_Código"
        ' 
        ' Col_Descripcion
        ' 
        Col_Descripcion.FillWeight = 200F
        Col_Descripcion.HeaderText = "Descripción"
        Col_Descripcion.MinimumWidth = 6
        Col_Descripcion.Name = "Col_Descripcion"
        ' 
        ' Col_Cantidad
        ' 
        Col_Cantidad.HeaderText = "Cantidad"
        Col_Cantidad.MinimumWidth = 6
        Col_Cantidad.Name = "Col_Cantidad"
        ' 
        ' Col_Precio
        ' 
        Col_Precio.HeaderText = "Precio"
        Col_Precio.MinimumWidth = 6
        Col_Precio.Name = "Col_Precio"
        ' 
        ' Col_Importe
        ' 
        Col_Importe.HeaderText = "Importe"
        Col_Importe.MinimumWidth = 6
        Col_Importe.Name = "Col_Importe"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(30, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 28)
        Label1.TabIndex = 6
        Label1.Text = "Ventas del dia:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(180, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 28)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(30, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 28)
        Label3.TabIndex = 8
        Label3.Text = "Resumen:"
        ' 
        ' LBL_ETIQUETA_TOTAL
        ' 
        LBL_ETIQUETA_TOTAL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LBL_ETIQUETA_TOTAL.AutoSize = True
        LBL_ETIQUETA_TOTAL.Font = New Font("Segoe UI", 12F)
        LBL_ETIQUETA_TOTAL.Location = New Point(30, 630)
        LBL_ETIQUETA_TOTAL.Name = "LBL_ETIQUETA_TOTAL"
        LBL_ETIQUETA_TOTAL.Size = New Size(146, 28)
        LBL_ETIQUETA_TOTAL.TabIndex = 9
        LBL_ETIQUETA_TOTAL.Text = "Total de ventas:"
        ' 
        ' LBL_TOTAL
        ' 
        LBL_TOTAL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LBL_TOTAL.AutoSize = True
        LBL_TOTAL.Font = New Font("Segoe UI", 12F)
        LBL_TOTAL.Location = New Point(180, 630)
        LBL_TOTAL.Name = "LBL_TOTAL"
        LBL_TOTAL.Size = New Size(146, 28)
        LBL_TOTAL.TabIndex = 10
        LBL_TOTAL.Text = "Total de ventas:"
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
        TableLayoutPanel1.Size = New Size(1280, 720)
        TableLayoutPanel1.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(LBL_TOTAL)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LBL_ETIQUETA_TOTAL)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(120, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1040, 700)
        Panel1.TabIndex = 0
        ' 
        ' UC_ReporteDia
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_ReporteDia"
        Size = New Size(1280, 720)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col_Código As DataGridViewTextBoxColumn
    Friend WithEvents Col_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Col_Precio As DataGridViewTextBoxColumn
    Friend WithEvents Col_Importe As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_ETIQUETA_TOTAL As Label
    Friend WithEvents LBL_TOTAL As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel

End Class
