Imports System.Data.SqlClient
Public Class FrmLogin

    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexion = New SqlConnection("server=LENOVODIEGO\SQLEXPRESS; database=practica;  integrated security=true")

        conexion.Open()
        Dim consulta As String = "Select * from Usuarios where usuario='" & txtUsuario.Text & "' and Contraseña = '" & txtContrasenia.Text & "'"
        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        'lector = 


        If (txtUsuario.Text = "Arath") And (txtContrasenia.Text = "123") Then
            Form2.Show()
        Else
            MsgBox("Usuario o Contraseña incorrecta, porfavor verifique")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = New SqlConnection("server=ARATH; database=Restaurante; integrated security=true")
    End Sub
End Class
