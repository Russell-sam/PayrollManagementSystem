Public Class Form1
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text = "admin" And txt_password.Text = "admin" Then
            MsgBox("you login successfully")
            txt_username.Text = ""
            txt_password.Text = ""
            Mainform.Show()
            Me.Hide()
        Else
            MsgBox("Wrong username or password")
            txt_username.Text = ""
            txt_password.Text = ""
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class