Imports Microsoft.Data.Sqlite

Public Class UC_Compras

    Private Sub UC_Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar las columnas de la tabla (DataGridView) si está vacía
        ConfigurarTablaDetalle()
    End Sub

    Private Sub ConfigurarTablaDetalle()
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("id_mat", "ID Material")
            DataGridView1.Columns.Add("nom_mat", "Descripción")
            DataGridView1.Columns.Add("cantidad", "Cantidad (kg)")
            DataGridView1.Columns.Add("precio", "Precio por kilo")
            DataGridView1.Columns.Add("subtotal", "Subtotal")
        End If
    End Sub

    ' Botón Buscar producto (agrega fila de prueba)
    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim idMat As String = "1"
            Dim descripcion As String = "Material Reciclaje"
            Dim cantidad As Decimal = 10D
            Dim precio As Decimal = 15.5D
            Dim subtotal As Decimal = cantidad * precio

            DataGridView1.Rows.Add(idMat, descripcion, cantidad, precio, subtotal.ToString("N2"))
        Catch ex As Exception
            MessageBox.Show("Error al agregar producto: " & ex.Message)
        End Try
    End Sub

    ' Botón Cobrar (Guarda en la base de datos SQLite)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No hay productos en la lista para cobrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' 1. Calcular el peso total y el precio total sumando los renglones de la tabla
            Dim pesoTotal As Decimal = 0
            Dim precioTotal As Decimal = 0

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(2).Value IsNot Nothing AndAlso row.Cells(4).Value IsNot Nothing Then
                    pesoTotal += Convert.ToDecimal(row.Cells(2).Value)
                    precioTotal += Convert.ToDecimal(row.Cells(4).Value)
                End If
            Next

            ' 2. Insertar la cabecera en la tabla Compra
            Dim queryCompra As String = "INSERT INTO Compra (fecha_com, id_u, id_v, total_peso_com, total_precio, Metodo_pago_com) VALUES (@fecha, @id_u, @id_v, @peso, @total, @metodo);"

            Dim parametrosCompra As New List(Of Microsoft.Data.Sqlite.SqliteParameter) From {
                New Microsoft.Data.Sqlite.SqliteParameter("@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                New Microsoft.Data.Sqlite.SqliteParameter("@id_u", 1),
                New Microsoft.Data.Sqlite.SqliteParameter("@id_v", 1),
                New Microsoft.Data.Sqlite.SqliteParameter("@peso", pesoTotal),
                New Microsoft.Data.Sqlite.SqliteParameter("@total", precioTotal),
                New Microsoft.Data.Sqlite.SqliteParameter("@metodo", "Efectivo")
            }

            Dim resultado As Integer = ConexionBD.EjecutarComando(queryCompra, parametrosCompra)

            If resultado > 0 Then
                MessageBox.Show("¡Cobro registrado y guardado en la Base de Datos con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.Rows.Clear()
            Else
                MessageBox.Show("No se pudo completar el registro de la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al procesar el cobro: " & ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class