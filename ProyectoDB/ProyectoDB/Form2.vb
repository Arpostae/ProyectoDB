Public Class Form2
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub btnMesa6_Click(sender As Object, e As EventArgs) Handles btnMesa6.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMesa1_Click(sender As Object, e As EventArgs) Handles btnMesa1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If (BackColor == Color.Lime) Then
                {
        FormBorderStyle = FormBorderStyle.Sizable;
        BackColor = Color.Black;
        Location = New Point(Left - 8, Top - 30);
    }
    Else
    {
        FormBorderStyle = FormBorderStyle.None;
        BackColor = Color.Lime;
        Location = New Point(Left + 8, Top + 30);
    }
    End Sub
End Class