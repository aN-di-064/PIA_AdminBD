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
        Label1 = New Label()
        txtBuscar = New TextBox()
        dgvVendedores = New DataGridView()
        CType(dgvVendedores, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 15)
        Label1.TabIndex = 6
        Label1.Text = "Nombre del Vendedor:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(188, 128)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(287, 23)
        txtBuscar.TabIndex = 5
        ' 
        ' dgvVendedores
        ' 
        dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVendedores.Location = New Point(37, 173)
        dgvVendedores.MultiSelect = False
        dgvVendedores.Name = "dgvVendedores"
        dgvVendedores.RowHeadersWidth = 51
        dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVendedores.Size = New Size(726, 150)
        dgvVendedores.TabIndex = 4
        ' 
        ' Busqueda_Vendedores
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtBuscar)
        Controls.Add(dgvVendedores)
        Name = "Busqueda_Vendedores"
        Text = "Busqueda_Vendedores"
        CType(dgvVendedores, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvVendedores As DataGridView
End Class
