<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Create = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProblemBox = New System.Windows.Forms.RichTextBox()
        Me.DateAndTime = New System.Windows.Forms.DateTimePicker()
        Me.ClientName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Create
        '
        Me.Create.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.Location = New System.Drawing.Point(139, 379)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(123, 47)
        Me.Create.TabIndex = 0
        Me.Create.Text = "Create"
        Me.Create.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Client Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(40, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date And Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(40, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Problem/Issue:"
        '
        'ProblemBox
        '
        Me.ProblemBox.Location = New System.Drawing.Point(71, 235)
        Me.ProblemBox.Name = "ProblemBox"
        Me.ProblemBox.Size = New System.Drawing.Size(298, 114)
        Me.ProblemBox.TabIndex = 4
        Me.ProblemBox.Text = ""
        '
        'DateAndTime
        '
        Me.DateAndTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateAndTime.Location = New System.Drawing.Point(224, 160)
        Me.DateAndTime.MinDate = New Date(2025, 3, 5, 0, 0, 0, 0)
        Me.DateAndTime.Name = "DateAndTime"
        Me.DateAndTime.Size = New System.Drawing.Size(145, 22)
        Me.DateAndTime.TabIndex = 5
        '
        'ClientName
        '
        Me.ClientName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClientName.Location = New System.Drawing.Point(202, 74)
        Me.ClientName.Name = "ClientName"
        Me.ClientName.Size = New System.Drawing.Size(167, 22)
        Me.ClientName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(40, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Urgent", "Pending", "Done"})
        Me.cmbStatus.Location = New System.Drawing.Point(202, 116)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(167, 24)
        Me.cmbStatus.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(99, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 41)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Request Task"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 479)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ClientName)
        Me.Controls.Add(Me.DateAndTime)
        Me.Controls.Add(Me.ProblemBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Create)
        Me.Name = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Create As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProblemBox As RichTextBox
    Friend WithEvents DateAndTime As DateTimePicker
    Friend WithEvents ClientName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label5 As Label
End Class
