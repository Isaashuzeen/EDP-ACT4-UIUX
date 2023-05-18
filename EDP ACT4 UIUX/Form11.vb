Imports MySql.Data.MySqlClient
Public Class EditFormCheckUp
    Dim selectedCheckupID As String = InputBox("Enter CheckUp_ID")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim findings As String = .findings.Text
            Dim treatmentID As Integer
            Dim medID As Integer
            Dim quantity As Integer
            Dim checkupDate As Date = Me.checkupDate.Value.Date ' Set time part to midnight
            Dim equipmentID As Integer

            ' Check if any required fields are empty
            If String.IsNullOrEmpty(findings) OrElse
                Not Integer.TryParse(.treatmentid.Text, treatmentID) OrElse
                Not Integer.TryParse(.medID.Text, medID) OrElse
                Not Integer.TryParse(.quantity.Text, quantity) OrElse
                Not Integer.TryParse(.equipmentID.Text, equipmentID) Then
                MessageBox.Show("Please enter valid values for all the required fields.")
                Exit Sub
            End If

            ' Retrieve the record from the database
            strSQL = "SELECT * FROM check_up WHERE checkup_id = '" & selectedCheckupID & "'"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim reader As MySqlDataReader = mycmd.ExecuteReader()

            ' Check if a record is found
            If reader.Read() Then
                ' Update the record with the new values
                reader.Close() ' Close the reader before executing the update statement

                ' Update the record in the database
                strSQL = "UPDATE check_up SET findings = @Findings, treatment_id = @TreatmentID, id_med = @MedID, quantity = @Quantity, date = @CheckupDate, equipment_id = @EquipmentID WHERE checkup_id = @SelectedCheckupID"
                mycmd.CommandText = strSQL
                mycmd.Parameters.AddWithValue("@Findings", findings)
                mycmd.Parameters.AddWithValue("@TreatmentID", treatmentID)
                mycmd.Parameters.AddWithValue("@MedID", medID)
                mycmd.Parameters.AddWithValue("@Quantity", quantity)
                mycmd.Parameters.AddWithValue("@CheckupDate", checkupDate)
                mycmd.Parameters.AddWithValue("@EquipmentID", equipmentID)
                mycmd.Parameters.AddWithValue("@SelectedCheckupID", selectedCheckupID)

                ' Execute the update statement
                mycmd.ExecuteNonQuery()

                ' Display a message indicating the record has been updated
                MessageBox.Show("Record with ID " & selectedCheckupID & " has been updated.")

            Else
                ' No record found with the specified ID
                reader.Close()
                MessageBox.Show("Checkup ID not found")
                ' Handle the error condition as needed
            End If

            Call Disconnect_to_DB()
            Me.Close()
        End With


    End Sub

    Private Sub EditFormCheckUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If String.IsNullOrEmpty(selectedCheckupID) Then
                Me.Close()
                MessageBox.Show("No input provided.")
            Else
                ' Check if the input is a valid number
                Dim inputNumber As Integer
                If Integer.TryParse(selectedCheckupID, inputNumber) Then
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