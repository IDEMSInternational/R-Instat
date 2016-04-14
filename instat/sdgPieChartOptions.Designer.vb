<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPieChartOptions
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
        Me.ucrBaseSdgPieChart = New instat.ucrButtonsSubdialogue()
        Me.chkClockwise = New System.Windows.Forms.CheckBox()
        Me.lblStartPoint = New System.Windows.Forms.Label()
        Me.nudStartPoint = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudStartPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucrBaseSdgPieChart
        '
        Me.ucrBaseSdgPieChart.Location = New System.Drawing.Point(49, 219)
        Me.ucrBaseSdgPieChart.Name = "ucrBaseSdgPieChart"
        Me.ucrBaseSdgPieChart.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSdgPieChart.TabIndex = 0
        '
        'chkClockwise
        '
        Me.chkClockwise.AutoSize = True
        Me.chkClockwise.Location = New System.Drawing.Point(12, 24)
        Me.chkClockwise.Name = "chkClockwise"
        Me.chkClockwise.Size = New System.Drawing.Size(74, 17)
        Me.chkClockwise.TabIndex = 11
        Me.chkClockwise.Text = "Clockwise"
        Me.chkClockwise.UseVisualStyleBackColor = True
        '
        'lblStartPoint
        '
        Me.lblStartPoint.AutoSize = True
        Me.lblStartPoint.Location = New System.Drawing.Point(108, 24)
        Me.lblStartPoint.Name = "lblStartPoint"
        Me.lblStartPoint.Size = New System.Drawing.Size(56, 13)
        Me.lblStartPoint.TabIndex = 12
        Me.lblStartPoint.Text = "Start Point"
        '
        'nudStartPoint
        '
        Me.nudStartPoint.Location = New System.Drawing.Point(170, 24)
        Me.nudStartPoint.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.nudStartPoint.Name = "nudStartPoint"
        Me.nudStartPoint.Size = New System.Drawing.Size(43, 20)
        Me.nudStartPoint.TabIndex = 13
        '
        'sdgPieChartOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.nudStartPoint)
        Me.Controls.Add(Me.lblStartPoint)
        Me.Controls.Add(Me.chkClockwise)
        Me.Controls.Add(Me.ucrBaseSdgPieChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPieChartOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Pie_Chart_Options"
        Me.Text = "Pie Chart Options"
        CType(Me.nudStartPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgPieChart As ucrButtonsSubdialogue
    Friend WithEvents chkClockwise As CheckBox
    Friend WithEvents lblStartPoint As Label
    Friend WithEvents nudStartPoint As NumericUpDown
End Class
