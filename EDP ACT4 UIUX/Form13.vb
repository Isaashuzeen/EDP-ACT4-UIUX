Imports MySql.Data.MySqlClient
Public Class EditEquipment
    Dim selectedEquipID As String = InputBox("Enter Equipment ID")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim equipname As String = .equipname.Text
            Dim reqdate As Date = Me.reqdate.Value.Date ' Set time part to midnight
            Dim defectdate As Date = Me.defectdate.Value.Date ' Set time part to midnight

            ' Check if any required fields are empty
            If String.IsNullOrEmpty(equipname) Then
                MessageBox.Show("Please enter a value for the equipment name.")
                Exit Sub
            End If

            ' Retrieve the record from the database
            strSQL = "SELECT * FROM equipments WHERE equipment_id = '" & selectedEquipID & "'"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim reader As MySqlDataReader = mycmd.ExecuteReader()

            ' Check if a record is found
            If reader.Read() Then
                ' Update the record with the new values
                reader.Close() ' Close the reader before executing the update statement

                ' Update the record in the database
                strSQL = "UPDATE equipments SET equipment_name = @EquipName, requested_date = @ReqDate, date_defected = @DefectDate WHERE equipment_id = @SelectedEquipID"
                mycmd.CommandText = strSQL
                mycmd.Parameters.AddWithValue("@EquipName", equipname)
                mycmd.Parameters.AddWithValue("@ReqDate", reqdate)
                mycmd.Parameters.AddWithValue("@DefectDate", defectdate)
                mycmd.Parameters.AddWithValue("@SelectedEquipID", selectedEquipID)

                ' Execute the update statement
                mycmd.ExecuteNonQuery()

                ' Display a message indicating the record has been updated
                MessageBox.Show("Record with ID " & selectedEquipID & " has been updated.")

            Else
                ' No record found with the specified ID
                reader.Close()
                MessageBox.Show("Equipment ID not found")
                ' Handle the error condition as needed
            End If

            Call Disconnect_to_DB()
            Me.Close()
        End With


    End Sub

    Private Sub EditEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If String.IsNullOrEmpty(selectedEquipID) Then
                Me.Close()
                MessageBox.Show("No input provided.")
            Else
                ' Check if the input is a valid number
                Dim inputNumber As Integer
                If Integer.TryParse(selectedEquipID, inputNumber) Then
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