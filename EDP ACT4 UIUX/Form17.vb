Imports MySql.Data.MySqlClient
Public Class EditMed
    Dim selectedmedID As String = InputBox("Enter Med_ID")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim medName As String = .medname.Text
            Dim quantity As Integer
            Dim availQuantity As Integer
            Dim description As String = .description.Text
            Dim expDate As Date = Me.expdate.Value.Date ' Set time part to midnight
            Dim reqDate As Date = Me.reqdate.Value.Date ' Set time part to midnight

            ' Check if any required fields are empty
            If String.IsNullOrEmpty(.quantity.Text) OrElse String.IsNullOrEmpty(.availquantity.Text) Then
                MessageBox.Show("Please enter values for all the required fields.")
                Exit Sub
            End If

            ' Parse quantity and availQuantity values
            If Not Integer.TryParse(.quantity.Text, quantity) OrElse Not Integer.TryParse(.availquantity.Text, availQuantity) Then
                MessageBox.Show("Invalid quantity value. Please enter a valid integer value.")
                Exit Sub
            End If

            ' Retrieve the record from the database
            strSQL = "SELECT * FROM medicines WHERE id_med = '" & selectedmedID & "'"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim reader As MySqlDataReader = mycmd.ExecuteReader()

            ' Check if a record is found
            If reader.Read() Then
                ' Update the record with the new values
                reader.Close() ' Close the reader before executing the update statement

                ' Update the record in the database
                strSQL = "UPDATE medicines SET med_name = @MedName, quantity = @Quantity, available_quantity = @AvailableQuantity, descrption = @Description, expiry_date = @ExpiryDate, requested_date = @RequestedDate WHERE id_med = @SelectedMedID"
                mycmd.CommandText = strSQL
                mycmd.Parameters.AddWithValue("@MedName", medName)
                mycmd.Parameters.AddWithValue("@Quantity", quantity)
                mycmd.Parameters.AddWithValue("@AvailableQuantity", availQuantity)
                mycmd.Parameters.AddWithValue("@Description", description)
                mycmd.Parameters.AddWithValue("@ExpiryDate", expDate)
                mycmd.Parameters.AddWithValue("@RequestedDate", reqDate)
                mycmd.Parameters.AddWithValue("@SelectedMedID", selectedmedID)

                ' Execute the update statement
                mycmd.ExecuteNonQuery()

                ' Display a message indicating the record has been updated
                MessageBox.Show("Record with ID " & selectedmedID & " has been updated.")

            Else
                ' No record found with the specified ID
                reader.Close()
                MessageBox.Show("Medicine ID not found")
                ' Handle the error condition as needed
            End If

            Call Disconnect_to_DB()
            Me.Close()
        End With

    End Sub

    Private Sub EditMed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If String.IsNullOrEmpty(selectedmedID) Then
                Me.Close()
                MessageBox.Show("No input provided.")
            Else
                ' Check if the input is a valid number
                Dim inputNumber As Integer
                If Integer.TryParse(selectedmedID, inputNumber) Then
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