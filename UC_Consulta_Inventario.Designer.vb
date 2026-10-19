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
        Label1.Location = New Point(30, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del producto:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(186, 82)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(287, 23)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(30, 163)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 62
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New Size(726, 150)
        dgvProductos.TabIndex = 4
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(547, 80)
        ComboBox1.Margin = New Padding(2, 2, 2, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(129, 23)
        ComboBox1.TabIndex = 7
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(463, 135)
        btnModificar.Margin = New Padding(2, 2, 2, 2)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(78, 20)
        btnModificar.TabIndex = 8
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(570, 135)
        btnEliminar.Margin = New Padding(2, 2, 2, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(78, 20)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' UC_Consulta_Inventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(txtBuscar)
        Controls.Add(dgvProductos)
        Name = "UC_Consulta_Inventario"
        Size = New Size(787, 431)
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
