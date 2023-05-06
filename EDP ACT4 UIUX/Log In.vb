Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
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

                    ' Clear the username and password textboxes
                    .Username.Text = ""
                    .Password.Text = ""
                Else
                    MessageBox.Show("Invalid username or password")
                End If
            End If
            Call Disconnect_to_DB()

        End With
    End Sub

    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles AddUser.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Hpas_Click(sender As Object, e As EventArgs) Handles Hpas.Click
        With Me
            If .Password.UseSystemPasswordChar = False Then
                Spas.BringToFront()
                .Password.UseSystemPasswordChar = True
            End If
        End With
    End Sub

    Private Sub Spas_Click(sender As Object, e As EventArgs) Handles Spas.Click
        With Me
            If .Password.UseSystemPasswordChar = True Then
                Hpas.BringToFront()
                .Password.UseSystemPasswordChar = False
            End If
        End With
    End Sub


    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Label5.Show()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Label5.Hide()
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Label6.Show()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Label6.Hide()
    End Sub

End Class