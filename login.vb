Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.Sqlite

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuarioText As String = TextBox1.Text.Trim()
        Dim contrasenaText As String = TextBox2.Text.Trim()

        ' Validar que los campos no estén vacíos
        If String.IsNullOrEmpty(usuarioText) OrElse String.IsNullOrEmpty(contrasenaText) Then
            MessageBox.Show("Por favor, ingresa el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar credenciales en la base de datos
        If ValidarUsuario(usuarioText, contrasenaText) Then
            ' Si los datos son correctos, abre la interfaz principal
            Interfaz_Principal.Show()
            Me.Hide()

            ' Limpiar los campos
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            ' Si fallan, muestra el mensaje de error
            MessageBox.Show("Los datos de inicio de sesión son incorrectos", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Clear()
            TextBox2.Focus()
        End If
    End Sub

    ' Función para consultar la base de datos SQLit
    Private Function ValidarUsuario(user As String, pass As String) As Boolean
        Dim accesoValido As Boolean = False
        Dim db As New ConexionDB()

        Using conexion As SqliteConnection = db.ObtenerConexion()
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then

                ' Actualizado con los nombres reales de las columnas de tu tabla Usuario
                Dim query As String = "SELECT COUNT(1) FROM Usuario WHERE usuario_us = @user AND contraseña_us = @pass"

                Using comando As New SqliteCommand(query, conexion)
                    comando.Parameters.AddWithValue("@user", user)
                    comando.Parameters.AddWithValue("@pass", pass)

                    Dim resultado As Integer = Convert.ToInt32(comando.ExecuteScalar())
                    If resultado > 0 Then
                        accesoValido = True
                    End If
                End Using
            End If
        End Using

        Return accesoValido
    End Function

End Class
