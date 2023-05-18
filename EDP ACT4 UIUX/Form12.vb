Imports MySql.Data.MySqlClient
Public Class AddEquipment

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim equipid As String = .equipid.Text
            Dim equipname As String = .equipname.Text
            Dim reqdate As Date = Me.reqdate.Value
            Dim datedefect As Date = Me.datedefect.Value

            Try
                ' Check if any required fields are empty
                If String.IsNullOrEmpty(equipid) OrElse String.IsNullOrEmpty(equipname) Then
                    MessageBox.Show("Please enter values for all the required fields.")
                    Exit Sub
                End If

                strSQL = "INSERT INTO equipments (equipment_id, equipment_name, requested_date, date_defected) VALUES ('" _
                 & equipid & "','" _
                 & equipname & "','" _
                 & Me.reqdate.Value.ToString("yyyy-MM-dd") & "','" _
                 & Me.datedefect.Value.ToString("yyyy-MM-dd") & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Me.Hide()
                    MessageBox.Show("Record Added")

                    .equipid.Text = ""
                    .equipname.Text = ""

                Else
                    MessageBox.Show("Failed to add record")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
End Class