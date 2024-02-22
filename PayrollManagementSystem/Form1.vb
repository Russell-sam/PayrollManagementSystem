Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "abcd" And TextBox2.Text = "123" Then
            MsgBox("You login successfully")
            Form2.Show()

        Else
            MsgBox("Wrong email or password")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
