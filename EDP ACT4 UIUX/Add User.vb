Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim username As String = .Username.Text
            Dim password As String = .Password.Text
            Dim confirmPassword As String = .ConfirmPassword.Text

            If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(confirmPassword) Then
                MessageBox.Show("Please Enter your Username and Password")
                .Show()

                Exit Sub
            End If

            If password = confirmPassword Then

                strSQL = "INSERT INTO users (username, password) VALUES ('" _
                 & username & "','" _
                 & password & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Form1.Show()
                    MessageBox.Show("New user added")

                Else
                    MessageBox.Show("Failed to add new user")
                End If

            Else
                MessageBox.Show("Passwords do not match")
                .Show()

            End If

            Call Disconnect_to_DB()
        End With

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles ConfirmPassword.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

End Class