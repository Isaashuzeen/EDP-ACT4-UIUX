Imports MySql.Data.MySqlClient
Public Class EditPatient
    Dim selectedPatientID As String = InputBox("Enter Med_ID")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim firstName As String = .fname.Text
            Dim lastName As String = .lname.Text
            Dim patientType As String = .patientType.Text
            Dim age As Integer
            Dim address As String = .address.Text

            ' Check if any required fields are empty
            If String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(patientType) OrElse String.IsNullOrEmpty(.age.Text) OrElse String.IsNullOrEmpty(address) Then
                MessageBox.Show("Please enter values for all the required fields.")
                Exit Sub
            End If

            ' Parse age value
            If Not Integer.TryParse(.age.Text, age) Then
                MessageBox.Show("Invalid age value. Please enter a valid integer value.")
                Exit Sub
            End If

            ' Retrieve the record from the database
            strSQL = "SELECT * FROM patients WHERE id_patient = '" & selectedPatientID & "'"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim reader As MySqlDataReader = mycmd.ExecuteReader()

            ' Check if a record is found
            If reader.Read() Then
                ' Update the record with the new values
                reader.Close() ' Close the reader before executing the update statement

                ' Update the record in the database
                strSQL = "UPDATE patients SET fname = @FirstName, lname = @LastName, patient_type = @PatientType, age = @Age, address = @Address WHERE id_patient = @SelectedPatientID"
                mycmd.CommandText = strSQL
                mycmd.Parameters.AddWithValue("@FirstName", firstName)
                mycmd.Parameters.AddWithValue("@LastName", lastName)
                mycmd.Parameters.AddWithValue("@PatientType", patientType)
                mycmd.Parameters.AddWithValue("@Age", age)
                mycmd.Parameters.AddWithValue("@Address", address)
                mycmd.Parameters.AddWithValue("@SelectedPatientID", selectedPatientID)

                ' Execute the update statement
                mycmd.ExecuteNonQuery()

                ' Display a message indicating the record has been updated
                MessageBox.Show("Record with ID " & selectedPatientID & " has been updated.")

            Else
                ' No record found with the specified ID
                reader.Close()
                MessageBox.Show("Patient ID not found")
                ' Handle the error condition as needed
            End If

            Call Disconnect_to_DB()
            Me.Close()
        End With

    End Sub

    Private Sub EditPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If String.IsNullOrEmpty(selectedPatientID) Then
                Me.Close()
                MessageBox.Show("No input provided.")
            Else
                ' Check if the input is a valid number
                Dim inputNumber As Integer
                If Integer.TryParse(selectedPatientID, inputNumber) Then
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid input. Please enter a number.")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            ' Handle any other errors that may occur
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class