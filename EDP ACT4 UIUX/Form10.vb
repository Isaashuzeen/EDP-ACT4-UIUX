Imports MySql.Data.MySqlClient
Public Class AddFormCheckUp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim checkupID As String = .checkupID.Text
            Dim patientID As String = .patientID.Text
            Dim findings As String = .findings.Text
            Dim treatmentID As String = .treatmentID.Text
            Dim medID As String = .medID.Text
            Dim quantity As String = .quantity.Text
            Dim checkupDate As Date = Me.checkupDate.Value
            Dim equipmentID As String = .equipmentID.Text

            Try
                ' Check if any required fields are empty
                If String.IsNullOrEmpty(checkupID) OrElse String.IsNullOrEmpty(patientID) OrElse String.IsNullOrEmpty(findings) _
           OrElse String.IsNullOrEmpty(treatmentID) OrElse String.IsNullOrEmpty(medID) OrElse String.IsNullOrEmpty(quantity) _
           OrElse String.IsNullOrEmpty(equipmentID) Then
                    MessageBox.Show("Please enter values for all the required fields.")
                    Exit Sub
                End If

                strSQL = "INSERT INTO check_up (checkup_id, id_patients, findings, treatment_id, id_med, quantity, date, equipment_id) VALUES ('" _
                 & checkupID & "','" _
                & patientID & "','" _
                & findings & "','" _
                & treatmentID & "','" _
                & medID & "','" _
                & quantity & "','" _
                & Me.checkupDate.Value.ToString("yyyy-MM-dd") & "','" _
                & equipmentID & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Me.Hide()
                    MessageBox.Show("Record Added")

                    .checkupID.Text = ""
                    .patientID.Text = ""
                    .findings.Text = ""
                    .treatmentID.Text = ""
                    .medID.Text = ""
                    .quantity.Text = ""
                    .equipmentID.Text = ""
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