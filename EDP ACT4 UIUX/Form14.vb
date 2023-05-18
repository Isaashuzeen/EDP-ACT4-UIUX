Imports MySql.Data.MySqlClient
Public Class AddPatient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim patientID As String = .id_patient.Text
            Dim firstName As String = .fname.Text
            Dim lastName As String = .lname.Text
            Dim patientType As String = .patient_type.Text
            Dim age As Integer = 0
            Integer.TryParse(.age.Text, age)
            Dim address As String = .address.Text

            Try
                ' Check if any required fields are empty
                If String.IsNullOrEmpty(patientID) OrElse String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(patientType) OrElse age = 0 OrElse String.IsNullOrEmpty(address) Then
                    MessageBox.Show("Please enter values for all the required fields.")
                    Exit Sub
                End If

                strSQL = "INSERT INTO patients (id_patient, fname, lname, patient_type, age, address) VALUES ('" _
                         & patientID & "','" _
                         & firstName & "','" _
                         & lastName & "','" _
                         & patientType & "','" _
                         & age & "','" _
                         & address & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Me.Hide()
                    MessageBox.Show("Record Added")

                    .id_patient.Text = ""
                    .fname.Text = ""
                    .lname.Text = ""
                    .patient_type.Text = ""
                    .address.Text = ""
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