Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            If String.IsNullOrEmpty(Username.Text) OrElse String.IsNullOrEmpty(Password.Text) Then
                MessageBox.Show("Please enter your Username/Password")

            Else
                strSQL = "Select * from users where username = '" _
                & .Username.Text & "' and password = md5('" _
                & .Password.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
                If myreader.HasRows Then
                    .Hide()
                    Form3.Show()
                Else
                    MessageBox.Show("Invalid username or password")
                End If
            End If
            Call Disconnect_to_DB()

        End With
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class
