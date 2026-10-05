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
        DataGridView1 = New DataGridView()
        Col_Código = New DataGridViewTextBoxColumn()
        Col_Descripcion = New DataGridViewTextBoxColumn()
        Col_Cantidad = New DataGridViewTextBoxColumn()
        Col_Precio = New DataGridViewTextBoxColumn()
        Col_Importe = New DataGridViewTextBoxColumn()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Col_Código, Col_Descripcion, Col_Cantidad, Col_Precio, Col_Importe})
        DataGridView1.Location = New Point(47, 94)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(692, 198)
        DataGridView1.TabIndex = 7
        ' 
        ' Col_Código
        ' 
        Col_Código.HeaderText = "Código"
        Col_Código.Name = "Col_Código"
        ' 
        ' Col_Descripcion
        ' 
        Col_Descripcion.FillWeight = 200F
        Col_Descripcion.HeaderText = "Descripción"
        Col_Descripcion.Name = "Col_Descripcion"
        ' 
        ' Col_Cantidad
        ' 
        Col_Cantidad.HeaderText = "Cantidad (kg)"
        Col_Cantidad.Name = "Col_Cantidad"
        ' 
        ' Col_Precio
        ' 
        Col_Precio.HeaderText = "Precio por kilo"
        Col_Precio.Name = "Col_Precio"
        ' 
        ' Col_Importe
        ' 
        Col_Importe.HeaderText = "Subtotal"
        Col_Importe.Name = "Col_Importe"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(47, 42)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 27)
        Button2.TabIndex = 6
        Button2.Text = "Buscar producto"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.Location = New Point(572, 352)
        Button1.Name = "Button1"
        Button1.Size = New Size(167, 36)
        Button1.TabIndex = 5
        Button1.Text = "Cobrar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(330, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 15)
        Label1.TabIndex = 8
        Label1.Text = "Compra de material"
        ' 
        ' UC_Compras
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "UC_Compras"
        Size = New Size(787, 431)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Col_Código As DataGridViewTextBoxColumn
    Friend WithEvents Col_Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Col_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Col_Precio As DataGridViewTextBoxColumn
    Friend WithEvents Col_Importe As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label

End Class
