Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.Sqlite

Public Class Busqueda_Venta

    ' Propiedad opcional para indicar si el buscador se abrió desde Compras (True) o Ventas (False)
    Public EsParaCompra As Boolean = False

    ' Atributos para ignorar la serialización en el diseñador de Windows Forms
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property CodigoSeleccionado As String

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property DescripcionSeleccionada As String

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property PrecioSeleccionado As Decimal

    Private Sub Busqueda_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar todos los materiales registrados al abrir el formulario
        CargarProductos("")

        ' Hacer que todo el DataGridView sea de solo lectura
        dgvProductos.ReadOnly = True

        ' Evitar que el usuario pueda agregar nuevas filas vacías al final de la tabla
        dgvProductos.AllowUserToAddRows = False

        ' Evitar que el usuario pueda eliminar filas presionando la tecla Supr/Delete
        dgvProductos.AllowUserToDeleteRows = False

        ' Opcional: Hacer que se seleccione la fila completa al hacer clic
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.MultiSelect = False
    End Sub

    ' Método para consultar la base de datos y llenar el DataGridView
    Private Sub CargarProductos(filtro As String)
        Try
            ' Seleccionar dinámicamente Precio_compra o Precio_venta según el origen
            Dim columnaPrecio As String = If(EsParaCompra, "Precio_compra AS Precio", "Precio_venta AS Precio")

            ' Permitir buscar tanto por Nombre (nom_mat) como por Código (Id_mat)
            Dim query As String = "SELECT Id_mat AS Código, nom_mat AS Descripción, unidad_medida AS Unidad, " & columnaPrecio & " " &
                                  "FROM Materiales WHERE nom_mat LIKE @filtro OR Id_mat LIKE @filtro"

            Dim parametros As New List(Of SqliteParameter) From {
                New SqliteParameter("@filtro", "%" & filtro & "%")
            }

            Dim dt As DataTable = ConexionBD.ObtenerDatos(query, parametros)
            dgvProductos.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' EVENTO ACTIVADO: Filtra en tiempo real cada vez que escribes en el TextBox
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        CargarProductos(txtBuscar.Text.Trim())
    End Sub

    Private Sub DgvProductos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvProductos.Rows(e.RowIndex)

            CodigoSeleccionado = fila.Cells("Código").Value.ToString()
            DescripcionSeleccionada = fila.Cells("Descripción").Value.ToString()
            PrecioSeleccionado = Convert.ToDecimal(fila.Cells("Precio").Value)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub dgvProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick
    End Sub

End Class