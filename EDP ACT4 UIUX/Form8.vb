﻿Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_to_DB()

        ' Create MySqlCommand and MySqlDataReader objects
        Dim mycmd As New MySqlCommand
        Dim myreader As MySqlDataReader

        ' Query to fetch data from check_up table
        Dim strSQL As String = "SELECT * FROM treatments;"
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
        Dim da As New MySqlDataAdapter("SELECT * FROM treatments", myconn)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditTreatment.Show()
    End Sub

End Class