Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Drawing2D
Imports Microsoft.Data.Sqlite

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Botones.CentrarTotal(Panel1)
        Botones.CentrarHorizontal(TextBox1)
        Botones.CentrarHorizontal(TextBox2)
        Botones.CentrarHorizontal(Button1)

        Botones.ConfigurarPlaceholder(TextBox1, "Usuario", False)
        Botones.ConfigurarPlaceholder(TextBox2, "Contraseña", True)

        Botones.Redondear(Panel1, 20)
        Botones.Redondear(TextBox1, 10)
        Botones.Redondear(TextBox2, 10)
        Botones.Redondear(Button1, 10)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuarioText As String = TextBox1.Text.Trim()
        Dim contrasenaText As String = TextBox2.Text.Trim()

        If String.IsNullOrEmpty(usuarioText) OrElse String.IsNullOrEmpty(contrasenaText) Then
            MessageBox.Show("Por favor, ingresa el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidarUsuario(usuarioText, contrasenaText) Then
            Interfaz_Principal.Show()
            Me.Hide()

            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MessageBox.Show("Los datos de inicio de sesión son incorrectos", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            Botones.LimpiarConPlaceholder(TextBox1)
            Botones.LimpiarConPlaceholder(TextBox2)

            Button1.Focus()
        End If
    End Sub

    Private Function ValidarUsuario(user As String, pass As String) As Boolean
        Dim accesoValido As Boolean = False
        Dim db As New ConexionBD()
        Using conexion As SqliteConnection = db.ObtenerConexion()
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then

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
