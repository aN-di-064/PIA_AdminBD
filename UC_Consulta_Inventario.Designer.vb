<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Consulta_Inventario
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
        txtBuscar = New TextBox()
        dgvProductos = New DataGridView()
        ComboBox1 = New ComboBox()
        btnModificar = New Button()
        btnEliminar = New Button()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 142)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(190, 25)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del producto:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(266, 136)
        txtBuscar.Margin = New Padding(4, 5, 4, 5)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(408, 31)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(43, 272)
        dgvProductos.Margin = New Padding(4, 5, 4, 5)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 62
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New Size(1037, 250)
        dgvProductos.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(782, 134)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 7
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(661, 225)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(112, 34)
        btnModificar.TabIndex = 8
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(815, 225)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 34)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' UC_Consulta_Inventario
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(txtBuscar)
        Controls.Add(dgvProductos)
        Margin = New Padding(4, 5, 4, 5)
        Name = "UC_Consulta_Inventario"
        Size = New Size(1124, 718)
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button

End Class
