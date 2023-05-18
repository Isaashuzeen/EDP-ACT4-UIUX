Imports MySql.Data.MySqlClient
Public Class EditTreatment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim idbox As String = .idbox.Text
            Dim treatbox As String = .treatbox.Text

            Try
                ' Check if any required fields are empty
                If String.IsNullOrEmpty(idbox) OrElse String.IsNullOrEmpty(treatbox) Then
                    MessageBox.Show("Please enter values for all the required fields.")
                    Exit Sub
                End If

                strSQL = "INSERT INTO treatments (treatment_id, treatment_type) VALUES ('" _
                         & idbox & "','" _
                         & treatbox & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Me.Hide()
                    MessageBox.Show("Record Added")

                    .idbox.Text = ""
                    .treatbox.Text = ""
                Else
                    MessageBox.Show("Failed to add record")
                End If

                Call Disconnect_to_DB()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End With

    End Sub
End Class