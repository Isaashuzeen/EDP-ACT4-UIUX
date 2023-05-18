Imports MySql.Data.MySqlClient
Public Class Addmed
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Dim idmed As String = .idmed.Text
            Dim medname As String = .medname.Text
            Dim quantity As String = .quantity.Text
            Dim availquantity As String = .availquantity.Text
            Dim description As String = .description.Text
            Dim expiryDate As Date = Me.expiryDate.Value
            Dim requestedDate As Date = Me.requestedDate.Value

            Try
                ' Check if any required fields are empty
                If String.IsNullOrEmpty(idmed) OrElse String.IsNullOrEmpty(medname) OrElse String.IsNullOrEmpty(quantity) OrElse String.IsNullOrEmpty(availquantity) OrElse String.IsNullOrEmpty(description) Then
                    MessageBox.Show("Please enter values for all the required fields.")
                    Exit Sub
                End If

                strSQL = "INSERT INTO medicines (id_med, med_name, quantity, available_quantity, descrption, expiry_date, requested_date) VALUES ('" _
                         & idmed & "','" _
                         & medname & "','" _
                         & quantity & "','" _
                         & availquantity & "','" _
                         & description & "','" _
                         & Me.expiryDate.Value.ToString("yyyy-MM-dd") & "','" _
                         & Me.requestedDate.Value.ToString("yyyy-MM-dd") & "')"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                If mycmd.ExecuteNonQuery() > 0 Then
                    Me.Hide()
                    MessageBox.Show("Record Added")

                    .idmed.Text = ""
                    .medname.Text = ""
                    .quantity.Text = ""
                    .availquantity.Text = ""
                    .description.Text = ""
                Else
                    MessageBox.Show("Failed to add record")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class