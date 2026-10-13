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
        Label1 = New Label()
        txtBuscar = New TextBox()
        dgvMateriales = New DataGridView()
        CType(dgvMateriales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 20)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del Material:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(215, 171)
        txtBuscar.Margin = New Padding(3, 4, 3, 4)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(327, 27)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvMateriales
        ' 
        dgvMateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMateriales.Location = New Point(42, 231)
        dgvMateriales.Margin = New Padding(3, 4, 3, 4)
        dgvMateriales.MultiSelect = False
        dgvMateriales.Name = "dgvMateriales"
        dgvMateriales.RowHeadersWidth = 51
        dgvMateriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMateriales.Size = New Size(830, 200)
        dgvMateriales.TabIndex = 4
        ' 
        ' Busqueda_Inventario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Label1)
        Controls.Add(txtBuscar)
        Controls.Add(dgvMateriales)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Busqueda_Inventario"
        Text = "Busqueda_Materiales"
        CType(dgvMateriales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvMateriales As DataGridView
End Class
