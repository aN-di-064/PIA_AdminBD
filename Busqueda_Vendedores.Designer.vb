<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Busqueda_Vendedores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda_Vendedores))
        Label1 = New Label()
        txtBuscar = New TextBox()
        dgvVendedores = New DataGridView()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel1 = New Panel()
        CType(dgvVendedores, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(30, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 28)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del Vendedor:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("Segoe UI", 12F)
        txtBuscar.Location = New Point(255, 45)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(327, 34)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvVendedores
        ' 
        dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVendedores.BackgroundColor = Color.White
        dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVendedores.Location = New Point(30, 90)
        dgvVendedores.Margin = New Padding(3, 4, 3, 4)
        dgvVendedores.MultiSelect = False
        dgvVendedores.Name = "dgvVendedores"
        dgvVendedores.RowHeadersWidth = 51
        dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVendedores.Size = New Size(700, 400)
        dgvVendedores.TabIndex = 4
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
        TableLayoutPanel1.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Location = New Point(11, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(760, 530)
        Panel1.TabIndex = 0
        ' 
        ' Busqueda_Vendedores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(Label1)
        Controls.Add(txtBuscar)
        Controls.Add(dgvVendedores)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Busqueda_Vendedores"
        Text = "Busqueda Vendedores"
        CType(dgvVendedores, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvVendedores As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
End Class
