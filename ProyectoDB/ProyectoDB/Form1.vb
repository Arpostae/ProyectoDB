Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If (txtUsuario.Text = "Arath") And (txtContrasenia.Text = "123") Then
            Form2.Show()
        Else
            MsgBox("Usuario o Contraseña incorrecta, porfavor verifique")
        End If
    End Sub
End Class
