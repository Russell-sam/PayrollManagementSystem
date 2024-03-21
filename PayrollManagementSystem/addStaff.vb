Imports MySql.Data.MySqlClient
Public Class addStaff
    Dim MySqlConnection As New MySqlConnection("host=127.001;user=root;database=payroll_database;")
    Dim cm As MySqlCommand
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub addStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MySqlConnection.Open()
            MessageBox.Show("successful connected")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cm = New MySqlCommand("insert into staff values('" & TextBox9.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox8.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox12.Text & "')", MySqlConnection)
        cm.ExecuteNonQuery()
        MsgBox("Data sent successfully")
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Loop through all controls on the form
        For Each control As Control In Me.Controls
            ' Check if the control is a textbox
            If TypeOf control Is TextBox Then
                ' Cast the control to a textbox and clear its text
                CType(control, TextBox).Text = String.Empty
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class