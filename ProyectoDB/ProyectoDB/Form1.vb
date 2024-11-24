'Imports System.Data.SqlClient
Public Class Form1

    'Dim conexion As New SqlConnection
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If (txtUsuario.Text = "Arath") And (txtContrasenia.Text = "123") Then
            Form2.Show()
        Else
            MsgBox("Usuario o Contraseña incorrecta, porfavor verifique")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection("server=ARATH; database=Restaurante; integrated security=true")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtUsuario_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If (txtUsuario.Text = "Usuario") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.BlueViolet
        End If

    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged
        If (txtUsuario.Text = "Password") Then
            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.BlueViolet
        End If
    End Sub
End Class
