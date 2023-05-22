Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        ' Create MySqlCommand and MySqlDataReader objects
        Dim mycmd As New MySqlCommand
        Dim myreader As MySqlDataReader

        ' Query to fetch data from check_up table
        Dim strSQL As String = "SELECT * FROM patients;"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim da As New MySqlDataAdapter("SELECT * FROM patients", myconn)
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Load the template file
        Dim templatePath As String = "C:\Users\USER\source\repos\EDP ACT4 UIUX\EDP ACT4 UIUX\dataXls\Template\template.xlsx"
        Dim excelApp As New Excel.Application()
        excelApp.Visible = True
        Dim excelWorkbook As Excel.Workbook = excelApp.Workbooks.Open(templatePath)
        Dim excelWorksheet As Excel.Worksheet = CType(excelWorkbook.Worksheets(1), Excel.Worksheet)

        ' Write the table name in the worksheet
        excelWorksheet.Cells(1, 1) = "Table Name: YourTableName"

        ' Write the column headers to the worksheet starting from row 7
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            excelWorksheet.Cells(7, i + 1) = DataGridView1.Columns(i).HeaderText
        Next

        ' Write the data rows to the worksheet starting from row 8
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                Dim cellValue As Object = DataGridView1.Rows(i).Cells(j).Value
                If cellValue IsNot Nothing AndAlso cellValue IsNot DBNull.Value Then
                    excelWorksheet.Cells(i + 8, j + 1) = cellValue.ToString()
                Else
                    excelWorksheet.Cells(i + 8, j + 1) = ""
                End If
            Next
        Next

        ' Format the data range with borders
        Dim lastRow As Integer = DataGridView1.Rows.Count + 7
        Dim lastColumn As Integer = DataGridView1.Columns.Count
        Dim dataRange As Excel.Range = excelWorksheet.Range("A7", ConvertToLetters(lastColumn) & lastRow)
        dataRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous

        ' Autofit the columns
        Dim columnsRange As Excel.Range = excelWorksheet.Range("A1", ConvertToLetters(lastColumn) & lastRow)
        columnsRange.Columns.AutoFit()

        ' Save the modified workbook
        Dim savePath As String = "C:\Users\USER\source\repos\EDP ACT4 UIUX\EDP ACT4 UIUX\dataXls\"
        Dim currentDate As DateTime = DateTime.Now
        Dim filename As String = "Patient_Data_" & currentDate.ToString("MM-dd-yy_HH-mm-ss") & ".xlsx"
        excelWorkbook.SaveAs(savePath & filename, Excel.XlFileFormat.xlOpenXMLWorkbook)
        MessageBox.Show("Export Successful")
        ' Release Excel objects from memory

        ReleaseObject(excelWorksheet)
        ReleaseObject(excelWorkbook)
        ReleaseObject(excelApp)

    End Sub

    Private Function ConvertToLetters(ByVal number As Integer) As String
        number -= 1
        Dim result As String = String.Empty

        If 26 > number Then
            result = Chr(number + 65)
        Else
            Dim column As Integer

            Do
                column = number Mod 26
                number = (number \ 26) - 1
                result = Chr(column + 65) + result
            Loop Until number < 0
        End If

        Return result
    End Function

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddPatient.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EditPatient.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            ' Prompt the user for the patient ID to delete
            Dim patientID As String = ""
            Do While String.IsNullOrEmpty(patientID)
                patientID = InputBox("Enter the ID of the patient record you want to delete:")
                If patientID = "" Then
                    Exit Do ' Exit the loop if the user clicks the Cancel button
                End If
            Loop

            ' Check if the patient ID exists in the table
            If Not String.IsNullOrEmpty(patientID) Then
                strSQL = "SELECT COUNT(*) FROM patients WHERE id_patient = '" & patientID & "';"
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                Dim count As Integer = Convert.ToInt32(mycmd.ExecuteScalar())

                ' Delete the record with the specified patient ID if it exists
                If count > 0 Then
                    strSQL = "DELETE FROM patients WHERE id_patient = '" & patientID & "';"
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
End Class