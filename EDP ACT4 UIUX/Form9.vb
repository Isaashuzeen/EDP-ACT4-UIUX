Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form9
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Create an instance of OpenFileDialog
            Dim openFileDialog As New OpenFileDialog()

            ' Set the properties of the OpenFileDialog
            openFileDialog.Title = "Upload CSV File"
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv"
            openFileDialog.Multiselect = False

            ' Show the OpenFileDialog and get the result
            Dim dialogResult As DialogResult = openFileDialog.ShowDialog()

            ' If the result is OK, continue processing
            If dialogResult = DialogResult.OK Then
                ' Get the selected file name
                Dim fileName As String = openFileDialog.FileName

                ' Read the contents of the CSV file using File.ReadAllLines
                Dim lines As String() = File.ReadAllLines(fileName)

                ' Split the first line to get the column headers
                Dim columns As String() = lines(0).Split(","c)

                ' Add the column headers to the DataGridView
                DataGridView1.Columns.Clear() ' Clear existing columns
                For Each column As String In columns
                    DataGridView1.Columns.Add(column, column)
                Next

                ' Read the remaining lines and add them as rows to the DataGridView
                DataGridView1.Rows.Clear() ' Clear existing rows
                For i As Integer = 1 To lines.Length - 1
                    Dim values As String() = lines(i).Split(","c)
                    DataGridView1.Rows.Add(values)
                Next

                ' Display success message
                MessageBox.Show("CSV file uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error uploading CSV file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Db Back up File"
        backup.DefaultExt = "sql"
        backup.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        ' Set default file name with timestamp
        Dim timeStamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        backup.FileName = $"database_backup_{timeStamp}.sql"

        If backup.ShowDialog() = DialogResult.OK Then
            Dim backupFilePath As String = backup.FileName

            Call Connect_to_DB()

            Dim mycmd As MySqlCommand = New MySqlCommand
            mycmd.Connection = myconn

            Dim mybu As MySqlBackup = New MySqlBackup(mycmd)
            mybu.ExportToFile(backupFilePath)

            myconn.Close()

            MessageBox.Show($"Database backup created successfully.{vbCrLf}Backup file saved at:{vbCrLf}{backupFilePath}",
                    "Backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo)
        ' If the user clicks "Yes", close the current form
        If result = DialogResult.Yes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub

End Class
