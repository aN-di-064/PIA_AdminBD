<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Materiales
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        txtBuscar = New TextBox()
        dgvMateriales = New DataGridView()
        Panel1 = New Panel()
        TableLayoutPanel1 = New TableLayoutPanel()
        CType(dgvMateriales, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(33, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 28)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del Material:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("Segoe UI", 12F)
        txtBuscar.Location = New Point(233, 45)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(327, 34)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvMateriales
        ' 
        dgvMateriales.AllowUserToAddRows = False
        dgvMateriales.AllowUserToDeleteRows = False
        dgvMateriales.AllowUserToResizeColumns = False
        dgvMateriales.AllowUserToResizeRows = False
        dgvMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMateriales.BackgroundColor = Color.White
        dgvMateriales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.White
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.LightCyan
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvMateriales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = Color.DimGray
        DataGridViewCellStyle2.Padding = New Padding(8, 8, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvMateriales.DefaultCellStyle = DataGridViewCellStyle2
        dgvMateriales.EnableHeadersVisualStyles = False
        dgvMateriales.GridColor = Color.WhiteSmoke
        dgvMateriales.Location = New Point(33, 95)
        dgvMateriales.Margin = New Padding(3, 4, 3, 4)
        dgvMateriales.MultiSelect = False
        dgvMateriales.Name = "dgvMateriales"
        dgvMateriales.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(50), CByte(50), CByte(50))
        DataGridViewCellStyle3.Padding = New Padding(8, 8, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(232), CByte(240), CByte(254))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvMateriales.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvMateriales.RowHeadersVisible = False
        dgvMateriales.RowHeadersWidth = 50
        dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMateriales.Size = New Size(700, 400)
        dgvMateriales.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtBuscar)
        Panel1.Controls.Add(dgvMateriales)
        Panel1.Location = New Point(12, 13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(758, 527)
        Panel1.TabIndex = 7
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackColor = Color.WhiteSmoke
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
        TableLayoutPanel1.TabIndex = 8
        ' 
        ' Busqueda_Materiales
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 553)
        Controls.Add(TableLayoutPanel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Busqueda_Materiales"
        Text = "Busqueda_Materiales"
        CType(dgvMateriales, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvMateriales As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
