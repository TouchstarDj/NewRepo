<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnGenerateReport = New System.Windows.Forms.Button()
        Me.cmbReportType = New System.Windows.Forms.ComboBox()
        Me.PrintBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(376, 409)
        Me.DataGridView1.TabIndex = 0
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.Font = New System.Drawing.Font("Nirmala Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.Location = New System.Drawing.Point(38, 90)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.Size = New System.Drawing.Size(196, 32)
        Me.btnGenerateReport.TabIndex = 1
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.UseVisualStyleBackColor = True
        '
        'cmbReportType
        '
        Me.cmbReportType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Items.AddRange(New Object() {"Task Summary", "Daily Report", "Weekly Report", "Monthly Report", "Yearly Report", "Pending Task ", "Resolved Task", "Urgent Tasks"})
        Me.cmbReportType.Location = New System.Drawing.Point(240, 92)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(174, 28)
        Me.cmbReportType.TabIndex = 2
        '
        'PrintBTN
        '
        Me.PrintBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBTN.Location = New System.Drawing.Point(122, 554)
        Me.PrintBTN.Name = "PrintBTN"
        Me.PrintBTN.Size = New System.Drawing.Size(208, 41)
        Me.PrintBTN.TabIndex = 3
        Me.PrintBTN.Text = "Print Report"
        Me.PrintBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(90, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 41)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Generate Report"
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 637)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PrintBTN)
        Me.Controls.Add(Me.cmbReportType)
        Me.Controls.Add(Me.btnGenerateReport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents cmbReportType As ComboBox
    Friend WithEvents PrintBTN As Button
    Friend WithEvents Label1 As Label
End Class
