Imports System.Data.SQLite

Public Class UpdateForm
    Private taskId As Integer

    ' Constructor to accept Task ID and load data
    Public Sub New(taskId As Integer)
        InitializeComponent()
        Me.taskId = taskId
    End Sub

    ' Load the task details into the controls when the form loads
    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load task details based on the passed task ID
        LoadTaskDetails()
    End Sub

    Private Sub LoadTaskDetails()
        ' Open the database connection
        Using connection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\TaskManagement.db;Version=3")
            connection.Open()

            ' Query to get task details
            Dim command As New SQLiteCommand("SELECT Task_I_D, Client_Name, DateAndTime,Time_Updated ,Status FROM TaskTable WHERE Task_I_D = @TaskID", connection)
            command.Parameters.AddWithValue("@TaskID", taskId)

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Populate the controls with task data
                txtTaskID.Text = reader("Task_I_D").ToString()
                txtClientName.Text = reader("Client_Name").ToString()
                dtpDateAndTime.Value = Convert.ToDateTime(reader("DateAndTime"))
                cmbStatus.SelectedItem = reader("Status").ToString()
            End If

            connection.Close()
        End Using
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Ask the user if they want to update the task
        Dim result As DialogResult = MessageBox.Show("Do you want to update this task?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", proceed with the update
        If result = DialogResult.Yes Then
            Try
                ' Open connection within a Using block to ensure it's properly closed
                Using connection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\TaskManagement.db;Version=3;Timeout=3000")
                    connection.Open()

                    ' Change journal mode to WAL for better concurrency (do this once)
                    Dim pragmaCommand As New SQLiteCommand("PRAGMA journal_mode=WAL;", connection)
                    pragmaCommand.ExecuteNonQuery()

                    ' Get the current time to update the DateAndTime field with the time of update
                    Dim currentDateAndTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

                    ' Save updated task details
                    Dim updateCommand As New SQLiteCommand("UPDATE TaskTable SET Client_Name = @ClientName, Time_Updated = @DateAndTime, Status = @Status WHERE Task_I_D = @TaskID", connection)
                    updateCommand.Parameters.AddWithValue("@ClientName", txtClientName.Text)
                    updateCommand.Parameters.AddWithValue("@DateAndTime", currentDateAndTime) ' Set the current date and time
                    updateCommand.Parameters.AddWithValue("@Status", cmbStatus.Text)
                    updateCommand.Parameters.AddWithValue("@TaskID", taskId)

                    ' Execute the update
                    updateCommand.ExecuteNonQuery()

                    MessageBox.Show("Task updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Optionally, refresh data in Form1
                    Dim form1 As Form1 = CType(Application.OpenForms("Form1"), Form1)
                    If form1 IsNot Nothing Then
                        form1.RefreshData()
                    End If

                    Me.Close()
                End Using
            Catch ex As SQLiteException
                ' Handle SQLite exception, including "database is locked"
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Dim form1 As Form1 = CType(Application.OpenForms("Form1"), Form1)
                Me.Close()
            End Try
        Else
            ' If the user clicks "No", cancel the update
            MessageBox.Show("Update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub





End Class

