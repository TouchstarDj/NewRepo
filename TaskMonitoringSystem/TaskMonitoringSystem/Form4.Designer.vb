<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.txtTaskID = New System.Windows.Forms.TextBox()
        Me.cmbStatus = New System.Windows.Forms.TextBox()
        Me.dtpDateAndTime = New System.Windows.Forms.TextBox()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtProblem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Task ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(32, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date And Time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Client Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(32, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Problem/Issue:"
        '
        'EditBtn
        '
        Me.EditBtn.Font = New System.Drawing.Font("Nirmala Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Location = New System.Drawing.Point(162, 344)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(125, 50)
        Me.EditBtn.TabIndex = 5
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'txtTaskID
        '
        Me.txtTaskID.Location = New System.Drawing.Point(230, 104)
        Me.txtTaskID.Name = "txtTaskID"
        Me.txtTaskID.ReadOnly = True
        Me.txtTaskID.Size = New System.Drawing.Size(207, 22)
        Me.txtTaskID.TabIndex = 6
        '
        'cmbStatus
        '
        Me.cmbStatus.Location = New System.Drawing.Point(230, 237)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.ReadOnly = True
        Me.cmbStatus.Size = New System.Drawing.Size(207, 22)
        Me.cmbStatus.TabIndex = 7
        '
        'dtpDateAndTime
        '
        Me.dtpDateAndTime.Location = New System.Drawing.Point(230, 191)
        Me.dtpDateAndTime.Name = "dtpDateAndTime"
        Me.dtpDateAndTime.ReadOnly = True
        Me.dtpDateAndTime.Size = New System.Drawing.Size(207, 22)
        Me.dtpDateAndTime.TabIndex = 8
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(230, 144)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(207, 22)
        Me.txtClientName.TabIndex = 9
        '
        'txtProblem
        '
        Me.txtProblem.Location = New System.Drawing.Point(230, 282)
        Me.txtProblem.Name = "txtProblem"
        Me.txtProblem.Size = New System.Drawing.Size(207, 22)
        Me.txtProblem.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(119, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(252, 41)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Edit Information"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 426)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProblem)
        Me.Controls.Add(Me.txtClientName)
        Me.Controls.Add(Me.dtpDateAndTime)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.txtTaskID)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EditBtn As Button
    Friend WithEvents txtTaskID As TextBox
    Friend WithEvents cmbStatus As TextBox
    Friend WithEvents dtpDateAndTime As TextBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents txtProblem As TextBox
    Friend WithEvents Label6 As Label
End Class
