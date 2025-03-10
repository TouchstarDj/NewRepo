Imports System.Data.SQLite

Public Class Form2

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        ' Get values from controls
        Dim Client_Name As String = ClientName.Text.Trim()
        Dim Date_and_Time As String = DateAndTime.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim Problem As String = ProblemBox.Text.Trim()
        Dim Status As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), String.Empty)

        ' Validation: Check if required fields are empty
        If String.IsNullOrWhiteSpace(Client_Name) Then
            MsgBox("Please enter the client name.", MsgBoxStyle.Exclamation, "Validation Error")
            ClientName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(Problem) Then
            MsgBox("Please describe the problem.", MsgBoxStyle.Exclamation, "Validation Error")
            ProblemBox.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(Status) Then
            MsgBox("Please select a status.", MsgBoxStyle.Exclamation, "Validation Error")
            cmbStatus.Focus()
            Return
        End If

        ' Insert data into SQLite database
        Using conn As New SQLiteConnection("Data Source=TaskManagement.db;Version=3;Timeout=30")
            conn.Open()

            Dim query As String = "INSERT INTO TaskTable (Client_Name, DateAndTime, Problem, Status) VALUES (@Client_Name, @DateAndTime, @Problem, @Status)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Client_Name", Client_Name)
                cmd.Parameters.AddWithValue("@DateAndTime", Date_and_Time)
                cmd.Parameters.AddWithValue("@Problem", Problem)
                cmd.Parameters.AddWithValue("@Status", Status)
                cmd.ExecuteNonQuery()
            End Using

            conn.Close()
        End Using

        ' Show confirmation
        MsgBox("Task successfully created!" & vbCrLf &
           "Client Name: " & Client_Name & vbCrLf &
           "Date and Time: " & Date_and_Time & vbCrLf &
           "Problem: " & Problem & vbCrLf &
           "Status: " & Status, MsgBoxStyle.Information, "Success")

        ' Refresh DataGridView in Form1
        Dim form1 As Form1 = CType(Application.OpenForms("Form1"), Form1)
        If form1 IsNot Nothing Then
            form1.RefreshData()
        End If

        ' Optional: Close Form2 after inserting data
        Me.Close()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set the DateTimePicker format and minimum date
        DateAndTime.Format = DateTimePickerFormat.Custom
        DateAndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        DateAndTime.MinDate = DateTime.Now ' Prevent selection of past dates

    End Sub
End Class
