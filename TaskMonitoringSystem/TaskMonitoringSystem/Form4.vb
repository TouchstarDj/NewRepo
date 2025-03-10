Imports System.Data.SQLite

Public Class Form4
    Private taskId As Integer

    ' Constructor to accept Task ID and load data
    Public Sub New(taskId As Integer)
        InitializeComponent()
        Me.taskId = taskId
    End Sub

    ' Load the task details into the controls when the form loads
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load task details based on the passed task ID
        LoadTaskDetails()
    End Sub

    Private Sub LoadTaskDetails()
        ' Open the database connection
        Using connection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\TaskManagement.db;Version=3")
            connection.Open()

            ' Query to get task details
            Dim command As New SQLiteCommand("SELECT Task_I_D, Client_Name, DateAndTime,Time_Updated ,Status,Problem FROM TaskTable WHERE Task_I_D = @TaskID", connection)
            command.Parameters.AddWithValue("@TaskID", taskId)

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Populate the controls with task data
                txtTaskID.Text = reader("Task_I_D").ToString()
                txtClientName.Text = reader("Client_Name").ToString()
                dtpDateAndTime.Text = Convert.ToDateTime(reader("DateAndTime"))
                cmbStatus.Text = reader("Status").ToString()
                txtProblem.Text = reader("Problem").ToString()
            End If

            connection.Close()
        End Using
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        ' Ask the user if they want to update the task
        Dim result As DialogResult = MessageBox.Show("Do you want to update this task?", "Confirm Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                ' Open connection using a Using block for proper disposal
                Using connection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\TaskManagement.db;Version=3;Timeout=3000")
                    connection.Open()

                    ' Update only the Problem column for the correct Task_I_D
                    Dim updateCommand As New SQLiteCommand("UPDATE TaskTable SET Problem = @Problem, Client_Name = @Client_Name WHERE Task_I_D = @TaskID", connection)
                    updateCommand.Parameters.AddWithValue("@Problem", txtProblem.Text)
                    updateCommand.Parameters.AddWithValue("@Client_Name", txtClientName.Text)
                    updateCommand.Parameters.AddWithValue("@TaskID", taskId)

                    ' Execute the update
                    Dim rowsAffected As Integer = updateCommand.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Problem updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh Form1 data if it's open
                        Dim form1 As Form1 = TryCast(Application.OpenForms("Form1"), Form1)
                        If form1 IsNot Nothing Then
                            form1.RefreshData()
                        End If
                    Else
                        MessageBox.Show("No task was updated. Please check the Task ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                    Me.Close() ' Close Form4
                End Using
            Catch ex As SQLiteException
                ' Handle SQLite exceptions (including "database is locked")
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class