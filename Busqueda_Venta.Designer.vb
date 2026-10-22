<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Venta
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda_Venta))
        dgvProductos = New DataGridView()
        txtBuscar = New TextBox()
        Label1 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        dgvProductos.Location = New Point(30, 90)
        dgvProductos.Margin = New Padding(3, 4, 3, 4)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New Size(700, 400)
        dgvProductos.TabIndex = 1
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("Segoe UI", 12F)
        txtBuscar.Location = New Point(255, 45)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(327, 34)
        txtBuscar.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(30, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 28)
        Label1.TabIndex = 3
        Label1.Text = "Nombre del material:"
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
        TableLayoutPanel1.Size = New Size(782, 553)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(dgvProductos)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(11, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(760, 530)
        Panel1.TabIndex = 0
        ' 
        ' Busqueda_Venta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(TableLayoutPanel1)
        Font = New Font("Segoe UI", 9F)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Busqueda_Venta"
        Text = "Busqueda de Venta y Compra"
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
