Imports MySql.Data.MySqlClient
Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call Connect_to_DB()
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            ' Query to fetch data from check_up table
            strSQL = "SELECT * FROM check_up;"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            ' Open the database connection
            myconn.Open()

            ' Execute the query and fetch the data
            myreader = mycmd.ExecuteReader()

            ' Clear existing data in DataGridView
            DataGridView1.Rows.Clear()

            ' Loop through each row in the query result
            While myreader.Read()
                Dim row As String() = {myreader("checkup_id").ToString(), myreader("id_patients").ToString(), myreader("findings").ToString(), myreader("treatment_id").ToString(), myreader("id_med").ToString(), myreader("quantity").ToString(),
                                       DateTime.Parse(myreader("date").ToString()).ToString("yyyy-MM-dd HH:mm:ss"), myreader("equipment_id").ToString()}
                DataGridView1.Rows.Add(row)
            End While

            ' Close the database connection and reader
            myreader.Close()
            Call Disconnect_to_DB()

            ' Refresh the DataGridView to display the added data
            DataGridView1.Refresh()
        End With

    End Sub

End Class