<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTaskID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Date_And_Time = New System.Windows.Forms.Label()
        Me.dtpDateAndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTaskID
        '
        Me.txtTaskID.Location = New System.Drawing.Point(220, 82)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.ReadOnly = True
        Me.txtTaskID.Size = New System.Drawing.Size(209, 22)
        Me.txtTaskID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Task ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Client Name:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(220, 131)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.ReadOnly = True
        Me.txtClientName.Size = New System.Drawing.Size(209, 22)
        Me.txtClientName.TabIndex = 2
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Urgent", "Pending", "Done"})
        Me.cmbStatus.Location = New System.Drawing.Point(220, 219)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(209, 24)
        Me.cmbStatus.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(35, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Status:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(133, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(187, 41)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Update"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Date_And_Time
        '
        Me.Date_And_Time.AutoSize = True
        Me.Date_And_Time.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_And_Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Date_And_Time.Location = New System.Drawing.Point(35, 171)
        Me.Date_And_Time.Name = "Date_And_Time"
        Me.Date_And_Time.Size = New System.Drawing.Size(159, 28)
        Me.Date_And_Time.TabIndex = 8
        Me.Date_And_Time.Text = "Date And Time:"
        '
        'dtpDateAndTime
        '
        Me.dtpDateAndTime.AllowDrop = True
        Me.dtpDateAndTime.Enabled = False
        Me.dtpDateAndTime.Location = New System.Drawing.Point(220, 176)
        Me.dtpDateAndTime.Name = "dtpDateAndTime"
        Me.dtpDateAndTime.Size = New System.Drawing.Size(209, 22)
        Me.dtpDateAndTime.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(103, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 41)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Update Request"
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 403)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpDateAndTime)
        Me.Controls.Add(Me.Date_And_Time)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTaskID)
        Me.Name = "UpdateForm"
        Me.Text = "Update Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTaskID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Date_And_Time As Label
    Friend WithEvents dtpDateAndTime As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
