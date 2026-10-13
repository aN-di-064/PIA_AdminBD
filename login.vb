Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Drawing.Drawing2D
Imports Microsoft.Data.Sqlite

Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Esto es para centrar todo el panel y los controles dentro del ventana, independientemente del tamaño de la ventana
        Panel1.Location = New Point((Me.ClientSize.Width - Panel1.Width) / 2, (Me.ClientSize.Height - Panel1.Height) / 2)
        TextBox1.Location = New Point((Panel1.Width - TextBox1.Width) / 2, TextBox1.Location.Y)
        TextBox2.Location = New Point((Panel1.Width - TextBox2.Width) / 2, TextBox2.Location.Y)
        Button1.Location = New Point((Panel1.Width - Button1.Width) / 2, Button1.Location.Y)
        ' Configuración inicial de los placeholders
        TextBox1.Text = "Usuario"
        TextBox1.ForeColor = Color.DarkGray

        TextBox2.Text = "Contraseña"
        TextBox2.ForeColor = Color.DarkGray
        TextBox2.UseSystemPasswordChar = False ' Para que se lea la palabra "Contraseña" al inicio

        ' Esto es para aplicar bordes redondeados a los controles, entre mas grande el numero mas redondeado
        AplicarBordesRedondeados(Panel1, 20)
        AplicarBordesRedondeados(TextBox1, 10)
        AplicarBordesRedondeados(TextBox2, 10)
        AplicarBordesRedondeados(Button1, 10)
    End Sub

    ' Función para rendondear los bordes del control usa la libreria System.Drawing.Drawing2D
    Private Sub AplicarBordesRedondeados(control As Control, radio As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        ' Esquina superior izquierda
        path.AddArc(New Rectangle(0, 0, radio, radio), 180, 90)
        ' Esquina superior derecha
        path.AddArc(New Rectangle(control.Width - radio, 0, radio, radio), 270, 90)
        ' Esquina inferior derecha
        path.AddArc(New Rectangle(control.Width - radio, control.Height - radio, radio, radio), 0, 90)
        ' Esquina inferior izquierda
        path.AddArc(New Rectangle(0, control.Height - radio, radio, radio), 90, 90)
        path.CloseFigure()

        control.Region = New Region(path)
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
            TextBox2.Text = "Contraseña"
            TextBox2.ForeColor = Color.DarkGray
            Button1.Focus()
        End If
    End Sub

    ' Aquí se implementa el comportamiento de los placeholders (Es decir las letras de Fondo) para los TextBox de usuario y contraseña
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Usuario" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black ' Aqui se cambia el color de la letra a nergro cuando se escribe
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Text = "Usuario"
            TextBox1.ForeColor = Color.DarkGray ' Aqui el color de la letra gris cuando no se escribe nada
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Contraseña" Then
            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black
            TextBox2.UseSystemPasswordChar = True ' Activa los puntos de contraseña para que no se pueda ver para mayor privacidad
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            TextBox2.UseSystemPasswordChar = False ' Esto desactiva los puntos para ver la palabra contraseña
            TextBox2.Text = "Contraseña"
            TextBox2.ForeColor = Color.DarkGray
        End If
    End Sub

    ' Función para consultar la base de datos SQLite 
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
