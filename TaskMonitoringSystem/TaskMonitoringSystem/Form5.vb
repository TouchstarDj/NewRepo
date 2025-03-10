Imports System.Data.SQLite
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports System.IO



Public Class Reports

    Private connString As String = "Data Source=TaskManagement.db;Version=3;"

    Private Sub LoadReport(reportType As String)
        Dim query As String = ""

        ' Define SQL query based on selected report
        Select Case reportType
            Case "Task Summary"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Status, Problem FROM TaskTable"
            Case "Daily Report"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Status, Problem FROM TaskTable WHERE Date(DateAndTime) = Date('now')"
            Case "Weekly Report"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Status, Problem FROM TaskTable WHERE DateAndTime >= Date('now', '-7 days')"
            Case "Monthly Report"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Status, Problem FROM TaskTable WHERE strftime('%Y-%m', DateAndTime) = strftime('%Y-%m', 'now')"
            Case "Yearly Report"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Status, Problem FROM TaskTable WHERE strftime('%Y', DateAndTime) = strftime('%Y', 'now')"
            Case "Pending Task "
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Problem FROM TaskTable WHERE Status = 'Pending'"
            Case "Resolved Task"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Time_Updated FROM TaskTable WHERE Status = 'Done'"
            Case "Urgent Tasks"
                query = "SELECT Task_I_D, Client_Name, DateAndTime, Problem FROM TaskTable WHERE Status = 'Urgent'"

        End Select


        'MessageBox.Show("Executing Query: " & query, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Report Created! Selected report: " & reportType)



        ' Load data into DataGridView
        Try
            Using conn As New SQLiteConnection(connString)
                conn.Open() ' Ensure connection is open


                Using cmd As New SQLiteCommand(query, conn)
                    Dim adapter As New SQLiteDataAdapter(cmd)
                    Dim TaskTable As New DataTable()
                    adapter.Fill(TaskTable)


                    DataGridView1.DataSource = TaskTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        ' Ensure that a report type is selected
        If cmbReportType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a report type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Get the selected report type
        Dim reportType As String = cmbReportType.SelectedItem.ToString()

        ' Ask for user confirmation
        Dim confirmResult As DialogResult = MessageBox.Show("Do you want to generate the " & reportType & "?", "Confirm Report Generation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If user selects No, exit the function
        If confirmResult = DialogResult.No Then
            Exit Sub
        End If

        ' Call function to load report
        LoadReport(reportType)
    End Sub


    Private Sub PrintBTN_Click(sender As Object, e As EventArgs) Handles PrintBTN.Click
        ' Check if a report type is selected
        If cmbReportType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a report type before printing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check if DataGridView has data
        If DataGridView1 Is Nothing OrElse DataGridView1.Rows.Count = 0 Then
            MessageBox.Show("No data available to print.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Generate PDF
        Dim pdfGen As New PDFGenerator()
        pdfGen.GeneratePDF(cmbReportType.SelectedItem.ToString(), DataGridView1)
    End Sub


End Class

