Imports System.Data.SqlClient
Public Class FrmLogin
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        conexion = New SqlConnection("server=LENOVODIEGO\SQLEXPRESS;database=Restaurante; integrated security=true")
        conexion.Open()

        Dim consulta As String = "select * from Usuarios where Usuario= '" & txtUsuario.Text & "' and Contraseña= '" & txtPass.Text & "'"

        comando = New SqlCommand(consulta, conexion)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        If lector.HasRows Then
            Dim FrmMenu As New FrmMesas
            FrmMenu.MdiParent = Me
            FrmMenu.Show()
        Else
            MessageBox.Show("No existe el usuario!!")
        End If


        If (txtUsuario.Text = "Arath") And (txtPass.Text = "123") Then
            FrmMesas.Show()
        Else
            MsgBox("Usuario o Contraseña incorrecta, porfavor verifique")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
