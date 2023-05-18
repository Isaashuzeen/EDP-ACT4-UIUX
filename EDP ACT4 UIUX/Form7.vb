Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        ' Create MySqlCommand and MySqlDataReader objects
        Dim mycmd As New MySqlCommand
        Dim myreader As MySqlDataReader

        ' Query to fetch data from check_up table
        Dim strSQL As String = "SELECT * FROM medicines;"
        mycmd.CommandText = strSQL
        mycmd.Connection = myconn

        ' Close the database connection if it is open
        If myconn.State = ConnectionState.Open Then
            myconn.Close()
        End If

        ' Open the database connection
        myconn.Open()

        ' Execute the query and fetch the data
        myreader = mycmd.ExecuteReader()

        ' Load data into a DataTable
        Dim dt As New DataTable
        dt.Load(myreader)

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt

        ' Close the database connection and reader
        myreader.Close()
        Call Disconnect_to_DB()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim da As New MySqlDataAdapter("SELECT * FROM medicines", myconn)
        Dim dt As New DataTable
        da.Fill(dt)

        ' Bind the DataTable to the DataGridView
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo)
        ' If the user clicks "Yes", close the current form
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            ' Prompt the user for the checkup ID to delete
            Dim medicines As String = ""
            Do While String.IsNullOrEmpty(medicines)
                medicines = InputBox("Enter the ID no. of the Record you want to delete:")
                If medicines = "" Then
                    Exit Do ' Exit the loop if the user clicks the Cancel button
                End If
            Loop

            ' Check if the checkup ID exists in the table
            If Not String.IsNullOrEmpty(medicines) Then
                strSQL = "SELECT COUNT(*) FROM medicines WHERE id_med = '" & medicines & "';"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                Dim count As Integer = Convert.ToInt32(mycmd.ExecuteScalar())

                ' Delete the record with the specified checkup ID if it exists
                If count > 0 Then
                    strSQL = "DELETE FROM medicines WHERE id_med = '" & medicines & "';"
                    mycmd.CommandText = strSQL
                    mycmd.Connection = myconn
                    If mycmd.ExecuteNonQuery() > 0 Then
                        MessageBox.Show("Record Deleted")
                    Else
                        MessageBox.Show("Error deleting record")
                    End If
                Else
                    MessageBox.Show("Record does not exist")
                End If
            End If

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Addmed.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Create a new Excel application
        Dim excelApp As New Excel.Application()
        excelApp.Visible = True

        ' Create a new workbook
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Add()
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Worksheets(1), Excel.Worksheet)

        ' Write the column headers to the worksheet
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            excelWorksheet.Cells(1, i + 1) = DataGridView1.Columns(i).HeaderText
        Next

        ' Write the data rows to the worksheet
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim cellValue As Object = DataGridView1.Rows(i).Cells(j).Value
                If cellValue IsNot Nothing AndAlso cellValue IsNot DBNull.Value Then
                    excelWorksheet.Cells(i + 2, j + 1) = cellValue.ToString()
                Else
                    excelWorksheet.Cells(i + 2, j + 1) = ""
                End If
            Next
        Next

        ' Autofit the columns
        excelWorksheet.Columns.AutoFit()

        ' Release Excel objects from memory
        ReleaseObject(excelWorksheet)
        ReleaseObject(excelWorkbook)
        ReleaseObject(excelApp)

        ' Display success message
        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditMed.Show()
    End Sub
End Class