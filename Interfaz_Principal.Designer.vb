<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Interfaz_Principal))
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton5 = New ToolStripButton()
        ToolStripButton4 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton6 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        panelContenido = New Panel()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.AutoSize = False
        ToolStrip1.Font = New Font("Segoe UI", 12F)
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.ImageScalingSize = New Size(32, 32)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, ToolStripButton1, ToolStripButton5, ToolStripButton4, ToolStripButton2, ToolStripButton6, ToolStripButton3, ToolStripButton7, ToolStripSeparator3})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1208, 87)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Image = My.Resources.Resources.Camion
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(198, 84)
        ToolStripLabel1.Text = "Centro de Acopio"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 87)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Padding = New Padding(4)
        ToolStripButton1.Size = New Size(81, 83)
        ToolStripButton1.Text = "Ventas"
        ToolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), Image)
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Padding = New Padding(4)
        ToolStripButton5.Size = New Size(94, 83)
        ToolStripButton5.Text = "Compra"
        ToolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Padding = New Padding(4)
        ToolStripButton4.Size = New Size(101, 83)
        ToolStripButton4.Text = "Reportes"
        ToolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), Image)
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Padding = New Padding(4)
        ToolStripButton2.Size = New Size(114, 83)
        ToolStripButton2.Text = "Materiales"
        ToolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton6
        ' 
        ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), Image)
        ToolStripButton6.ImageTransparentColor = Color.Magenta
        ToolStripButton6.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton6.Name = "ToolStripButton6"
        ToolStripButton6.Padding = New Padding(4)
        ToolStripButton6.Size = New Size(108, 83)
        ToolStripButton6.Text = "Consultas"
        ToolStripButton6.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), Image)
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Padding = New Padding(4)
        ToolStripButton3.Size = New Size(92, 83)
        ToolStripButton3.Text = "Clientes"
        ToolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripButton7
        ' 
        ToolStripButton7.Alignment = ToolStripItemAlignment.Right
        ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), Image)
        ToolStripButton7.ImageTransparentColor = Color.Magenta
        ToolStripButton7.Margin = New Padding(6, 2, 6, 2)
        ToolStripButton7.Name = "ToolStripButton7"
        ToolStripButton7.Padding = New Padding(4)
        ToolStripButton7.Size = New Size(94, 83)
        ToolStripButton7.Text = "Salir"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Alignment = ToolStripItemAlignment.Right
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 87)
        ' 
        ' panelContenido
        ' 
        panelContenido.Dock = DockStyle.Fill
        panelContenido.Location = New Point(0, 87)
        panelContenido.Margin = New Padding(3, 4, 3, 4)
        panelContenido.Name = "panelContenido"
        panelContenido.Size = New Size(1208, 524)
        panelContenido.TabIndex = 1
        ' 
        ' Interfaz_Principal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1208, 611)
        Controls.Add(panelContenido)
        Controls.Add(ToolStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(930, 634)
        Name = "Interfaz_Principal"
        Text = "Centro de Acopio"
        WindowState = FormWindowState.Maximized
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents panelContenido As Panel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
