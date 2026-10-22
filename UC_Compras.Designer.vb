<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Compras
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
        LBL_TOTAL = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LBL_IDCOMPRA = New Label()
        BTN_BORRAR = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Col_Cantidad = New DataGridViewTextBoxColumn()
        Col_Código = New DataGridViewTextBoxColumn()
        Col_Descripcion = New DataGridViewTextBoxColumn()
        Col_Precio = New DataGridViewTextBoxColumn()
        Col_Importe = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        CB_Vendedor = New ComboBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LBL_TOTAL
        ' 
        LBL_TOTAL.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        LBL_TOTAL.AutoSize = True
        LBL_TOTAL.Font = New Font("Segoe UI", 12F)
        LBL_TOTAL.Location = New Point(830, 570)
        LBL_TOTAL.Name = "LBL_TOTAL"
        LBL_TOTAL.Size = New Size(54, 28)
        LBL_TOTAL.TabIndex = 23
        LBL_TOTAL.Text = "label"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(770, 570)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 28)
        Label2.TabIndex = 22
        Label2.Text = "Total:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(30, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 28)
        Label3.TabIndex = 21
        Label3.Text = "Venta no."
        ' 
        ' LBL_IDCOMPRA
        ' 
        LBL_IDCOMPRA.AutoSize = True
        LBL_IDCOMPRA.Font = New Font("Segoe UI", 12F)
        LBL_IDCOMPRA.Location = New Point(130, 70)
        LBL_IDCOMPRA.Name = "LBL_IDCOMPRA"
        LBL_IDCOMPRA.Size = New Size(54, 28)
        LBL_IDCOMPRA.TabIndex = 20
        LBL_IDCOMPRA.Text = "label"
        ' 
        ' BTN_BORRAR
        ' 
        BTN_BORRAR.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        BTN_BORRAR.Font = New Font("Segoe UI", 12F)
        BTN_BORRAR.Location = New Point(30, 570)
        BTN_BORRAR.Margin = New Padding(3, 4, 3, 4)
        BTN_BORRAR.Name = "BTN_BORRAR"
        BTN_BORRAR.Size = New Size(175, 75)
        BTN_BORRAR.TabIndex = 19
        BTN_BORRAR.Text = "Borrar producto seleccionado"
        BTN_BORRAR.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(10, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 41)
        Label1.TabIndex = 18
        Label1.Text = "Compra de material"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Col_Cantidad, Col_Código, Col_Descripcion, Col_Precio, Col_Importe})
        DataGridView1.Location = New Point(30, 160)
        DataGridView1.Margin = New Padding(3, 4, 3, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(980, 400)
        DataGridView1.TabIndex = 17
        ' 
        ' Col_Cantidad
        ' 
        Col_Cantidad.HeaderText = "Cantidad (kg)"
        Col_Cantidad.MinimumWidth = 6
        Col_Cantidad.Name = "Col_Cantidad"
        ' 
        ' Col_Código
        ' 
        Col_Código.HeaderText = "Código"
        Col_Código.MinimumWidth = 6
        Col_Código.Name = "Col_Código"
        Col_Código.ReadOnly = True
        ' 
        ' Col_Descripcion
        ' 
        Col_Descripcion.FillWeight = 200F
        Col_Descripcion.HeaderText = "Descripción"
        Col_Descripcion.MinimumWidth = 6
        Col_Descripcion.Name = "Col_Descripcion"
        Col_Descripcion.ReadOnly = True
        ' 
        ' Col_Precio
        ' 
        Col_Precio.HeaderText = "Precio por kilo"
        Col_Precio.MinimumWidth = 6
        Col_Precio.Name = "Col_Precio"
        Col_Precio.ReadOnly = True
        ' 
        ' Col_Importe
        ' 
        Col_Importe.HeaderText = "Subtotal"
        Col_Importe.MinimumWidth = 6
        Col_Importe.Name = "Col_Importe"
        Col_Importe.ReadOnly = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(750, 110)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 39)
        Button2.TabIndex = 16
        Button2.Text = "Buscar producto"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(800, 610)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 39)
        Button1.TabIndex = 15
        Button1.Text = "Cobrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(30, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(210, 28)
        Label4.TabIndex = 24
        Label4.Text = "Nombre del vendedor:"
        ' 
        ' CB_Vendedor
        ' 
        CB_Vendedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        CB_Vendedor.AutoCompleteSource = AutoCompleteSource.ListItems
        CB_Vendedor.Font = New Font("Segoe UI", 12F)
        CB_Vendedor.FormattingEnabled = True
        CB_Vendedor.Location = New Point(250, 110)
        CB_Vendedor.Margin = New Padding(3, 4, 3, 4)
        CB_Vendedor.Name = "CB_Vendedor"
        CB_Vendedor.Size = New Size(138, 36)
        CB_Vendedor.TabIndex = 25
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
        TableLayoutPanel1.TabIndex = 26
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(LBL_TOTAL)
        Panel1.Controls.Add(CB_Vendedor)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(BTN_BORRAR)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(LBL_IDCOMPRA)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(120, 10)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1040, 700)
        Panel1.TabIndex = 0
        ' 
        ' UC_Compras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "UC_Compras"
        Size = New Size(1280, 720)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LBL_TOTAL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_IDCOMPRA As Label
    Friend WithEvents BTN_BORRAR As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Col_Código As DataGridViewTextBoxColumn
    Friend WithEvents Col_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Col_Precio As DataGridViewTextBoxColumn
    Friend WithEvents Col_Importe As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Vendedor As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel

End Class
