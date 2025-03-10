Imports System.Data.SQLite
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class Form1

    Private dbCommand As String = ""
    Private bindingSrc As BindingSource
    Private dbName As String = "TaskManagement.db"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3;Timeout=30"
    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)

    ' Add these declarations for blinking functionality
    Private WithEvents BlinkTimer As New Timer()
    Private BlinkState As Boolean = True
    Private UrgentRowIndices As New List(Of Integer)()



    'Form Loader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the blinking timer
        BlinkTimer.Interval = 500  ' Blink every half second (500ms)
        BlinkTimer.Enabled = True

        Me.Controls.Add(SearchBox)
        Me.Controls.Add(SearchBox)

        RefreshData()
    End Sub

    'Logic for Data Grid View and Database
    ' Method to refresh and load data into the DataGridView
    ' Method to refresh and load data into the DataGridView with search functionality
    ' Refresh data method with optional search term

    ' Event when data binding is complete
    Private Sub DataGridView1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView1.DataBindingComplete
        UpdateUrgentRowIndices()
    End Sub

    Public Sub RefreshData(Optional searchTerm As String = "")
        Try
            Using connection As New SQLiteConnection("Data Source=TaskManagement.db;Version=3;Timeout=30")
                connection.Open()

                Dim query As String = "SELECT Task_I_D, Client_Name, DateAndTime, Time_Updated, Status, Problem FROM TaskTable "

                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= "WHERE Client_Name LIKE @SearchTerm OR Task_I_D LIKE @SearchTerm OR Status LIKE @SearchTerm "
                End If

                query &= "ORDER BY CASE " &
                     "WHEN Status = 'Urgent' THEN 1 " &
                     "WHEN Status = 'Pending' THEN 2 " &
                     "WHEN Status = 'Done' THEN 4 " &
                     "ELSE 5 END, " &
                     "CASE WHEN Status = 'Pending' THEN Date(DateAndTime) ELSE NULL END DESC"

                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.Clear()

                    If Not String.IsNullOrEmpty(searchTerm) Then
                        command.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")
                    End If

                    Using rdr As SQLiteDataReader = command.ExecuteReader()
                        Dim table As New DataTable
                        table.Load(rdr)
                        DataGridView1.DataSource = table
                    End Using
                End Using
            End Using

            ' Ensure buttons are always present
            AddButtonColumns()

            ' Disable Update button for "Done" tasks
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("Status").Value IsNot Nothing AndAlso row.Cells("Status").Value.ToString().Trim().ToLower() = "done" Then
                    row.Cells("UpdateButton").ReadOnly = True
                    row.Cells("UpdateButton").Style.ForeColor = Color.Gray
                    row.Cells("UpdateButton").Value = "Locked"
                End If
            Next

            ' Update urgent row indices
            UpdateUrgentRowIndices()

        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub AddButtonColumns()
        ' Check and add "Update" button if not already present
        If DataGridView1.Columns("UpdateButton") Is Nothing Then
            Dim updateButton As New DataGridViewButtonColumn()
            updateButton.Name = "UpdateButton"
            updateButton.HeaderText = "Update"
            updateButton.Text = "Update"
            updateButton.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(updateButton)
        End If

        ' Check and add "Delete" button if not already present
        If DataGridView1.Columns("DeleteButton") Is Nothing Then
            Dim deleteButton As New DataGridViewButtonColumn()
            deleteButton.Name = "DeleteButton"
            deleteButton.HeaderText = "Delete"
            deleteButton.Text = "Delete"
            deleteButton.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(deleteButton)
        End If
    End Sub



    ' Method to update urgent row indices
    Private Sub UpdateUrgentRowIndices()
        UrgentRowIndices.Clear()
        Dim statusColIndex As Integer = DataGridView1.Columns("Status").Index

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells(statusColIndex).Value IsNot Nothing Then
                Dim status As String = DataGridView1.Rows(i).Cells(statusColIndex).Value.ToString().Trim().ToLower()
                If status = "urgent" Then
                    UrgentRowIndices.Add(i)
                End If
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Check if the Update button was clicked
        If e.ColumnIndex = DataGridView1.Columns("UpdateButton").Index AndAlso e.RowIndex >= 0 Then
            Dim taskId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("Task_I_D").Value)
            Dim taskStatus As String = DataGridView1.Rows(e.RowIndex).Cells("Status").Value.ToString()

            ' Prevent update if status is "Done"
            If taskStatus = "Done" Then
                MessageBox.Show("This task is already marked as 'Done' and cannot be updated.", "Update Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' Open UpdateForm and pass the Task ID to it
            Dim updateForm As New UpdateForm(taskId)
            updateForm.ShowDialog()

            ' Refresh the data after update
            RefreshData()
        End If

        ' Check if the Delete button was clicked
        If e.ColumnIndex = DataGridView1.Columns("DeleteButton").Index AndAlso e.RowIndex >= 0 Then
            Dim taskId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("Task_I_D").Value)

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                DeleteTask(taskId)
                RefreshData()
            End If
        End If
    End Sub

    ' Method to delete a task from the database
    Private Sub DeleteTask(taskId As Integer)
        Using connection As New SQLiteConnection("Data Source=" & Application.StartupPath & "\TaskManagement.db;Version=3;Timeout=30")
            connection.Open()

            ' Query to delete the task based on TaskID
            Dim deleteCommand As New SQLiteCommand("DELETE FROM TaskTable WHERE Task_I_D = @TaskID", connection)
            deleteCommand.Parameters.AddWithValue("@TaskID", taskId)

            ' Execute the delete command
            deleteCommand.ExecuteNonQuery()

            connection.Close()

            ' Notify the user of the successful deletion
            MessageBox.Show("Task deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    ' Links to different Forms
    ' Create Button Click event to open Form2 for adding a new task
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim addPanel As New Form2()
        addPanel.Show()  ' Open Form2 (the add task form)
    End Sub

    Private Sub Report_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addPanel As New Reports()
        addPanel.Show()
    End Sub


    'Timer and Blinker

    ' Timer tick event to toggle the blink state
    Private Sub BlinkTimer_Tick(sender As Object, e As EventArgs) Handles BlinkTimer.Tick
        BlinkState = Not BlinkState  ' Toggle between True and False

        ' Only invalidate cells that need to blink
        For Each rowIndex As Integer In UrgentRowIndices
            If rowIndex < DataGridView1.Rows.Count Then
                Dim statusCellIndex As Integer = DataGridView1.Columns("Status").Index
                DataGridView1.InvalidateCell(statusCellIndex, rowIndex)
            End If
        Next
    End Sub

    ' Add cleanup for the timer when form is closed
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        BlinkTimer.Enabled = False
        BlinkTimer.Dispose()
    End Sub






    'Key Bindings 

    ' Search button click event
    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ' Get the search term entered by the user
        Dim searchTerm As String = SearchBox.Text.Trim()

        ' Call RefreshData method with the search term
        RefreshData(searchTerm)
    End Sub

    ' Event handler for KeyDown event on the search TextBox
    Private Sub SearchBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBox.KeyDown
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            ' Call the RefreshData method with the search term entered in the SearchBox
            Dim searchTerm As String = SearchBox.Text.Trim()
            RefreshData(searchTerm)
        End If
    End Sub

    ' Handle double-click event on DataGridView rows
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ' Ensure the double-click is on a valid row (not the header row)
        If e.RowIndex >= 0 Then
            ' Get the Task ID from the selected row
            Dim taskId As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells("Task_I_D").Value)

            ' Open Form4 and pass the Task ID
            Dim form4 As New Form4(taskId)
            form4.ShowDialog() ' Show Form4 as a modal dialog

            ' Refresh Form1's DataGridView after editing
            RefreshData()
        End If
    End Sub




    ' Cell Painting ( Logic for Circle in the cell)

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        ' Check if this is the Status column
        If e.ColumnIndex = DataGridView1.Columns("Status").Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)

            ' Get the status value (but don't display it)
            Dim status As String = If(DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value?.ToString().Trim().ToLower(), "")

            ' Determine circle color based on status
            Dim circleColor As Color
            Select Case status
                Case "pending", "Pending"
                    circleColor = Color.Gray
                Case "done", "Done"
                    circleColor = Color.Green
                Case "urgent", "Urgent"
                    ' For urgent status, check the blink state
                    If BlinkState Then
                        circleColor = Color.Red
                    Else
                        circleColor = Color.Transparent  ' Make it invisible during "off" state
                    End If
                Case Else
                    circleColor = Color.Transparent
            End Select

            ' Calculate circle position (center of cell)
            Dim circleSize As Integer = 20
            Dim circleRect As New Rectangle(
                e.CellBounds.Left + (e.CellBounds.Width - circleSize) \ 2,
                e.CellBounds.Top + (e.CellBounds.Height - circleSize) \ 2,
                circleSize,
                circleSize)

            ' Draw the circle
            Using brush As New SolidBrush(circleColor)
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                e.Graphics.FillEllipse(brush, circleRect)
            End Using

            e.Handled = True
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub


End Class
