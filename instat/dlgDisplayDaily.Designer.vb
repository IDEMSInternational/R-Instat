<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDisplayDaily
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
        Me.chkSummary = New System.Windows.Forms.CheckBox()
        Me.grpsummary = New System.Windows.Forms.GroupBox()
        Me.chkTotals = New System.Windows.Forms.CheckBox()
        Me.chkCount = New System.Windows.Forms.CheckBox()
        Me.chkMaximum = New System.Windows.Forms.CheckBox()
        Me.chkPlotMean = New System.Windows.Forms.CheckBox()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.UcrSelector1 = New instat.ucrSelector()
        Me.UcrBase = New instat.ucrButtons()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.grpsummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkSummary
        '
        Me.chkSummary.AutoSize = True
        Me.chkSummary.Location = New System.Drawing.Point(25, 167)
        Me.chkSummary.Name = "chkSummary"
        Me.chkSummary.Size = New System.Drawing.Size(69, 17)
        Me.chkSummary.TabIndex = 4
        Me.chkSummary.Tag = "Summary"
        Me.chkSummary.Text = "Summary"
        Me.chkSummary.UseVisualStyleBackColor = True
        '
        'grpsummary
        '
        Me.grpsummary.Controls.Add(Me.txtValue)
        Me.grpsummary.Controls.Add(Me.chkTotals)
        Me.grpsummary.Controls.Add(Me.chkCount)
        Me.grpsummary.Controls.Add(Me.chkMaximum)
        Me.grpsummary.Location = New System.Drawing.Point(100, 141)
        Me.grpsummary.Name = "grpsummary"
        Me.grpsummary.Size = New System.Drawing.Size(242, 80)
        Me.grpsummary.TabIndex = 5
        Me.grpsummary.TabStop = False
        Me.grpsummary.Tag = "Monthly Summaries"
        Me.grpsummary.Text = "Monthly Summaries"
        '
        'chkTotals
        '
        Me.chkTotals.AutoSize = True
        Me.chkTotals.Location = New System.Drawing.Point(6, 29)
        Me.chkTotals.Name = "chkTotals"
        Me.chkTotals.Size = New System.Drawing.Size(55, 17)
        Me.chkTotals.TabIndex = 3
        Me.chkTotals.Tag = "Totals"
        Me.chkTotals.Text = "Totals"
        Me.chkTotals.UseVisualStyleBackColor = True
        '
        'chkCount
        '
        Me.chkCount.AutoSize = True
        Me.chkCount.Location = New System.Drawing.Point(106, 29)
        Me.chkCount.Name = "chkCount"
        Me.chkCount.Size = New System.Drawing.Size(63, 17)
        Me.chkCount.TabIndex = 2
        Me.chkCount.Tag = "Count"
        Me.chkCount.Text = "Count >"
        Me.chkCount.UseVisualStyleBackColor = True
        '
        'chkMaximum
        '
        Me.chkMaximum.AutoSize = True
        Me.chkMaximum.Location = New System.Drawing.Point(6, 57)
        Me.chkMaximum.Name = "chkMaximum"
        Me.chkMaximum.Size = New System.Drawing.Size(70, 17)
        Me.chkMaximum.TabIndex = 1
        Me.chkMaximum.Tag = "Maximum"
        Me.chkMaximum.Text = "Maximum"
        Me.chkMaximum.UseVisualStyleBackColor = True
        '
        'chkPlotMean
        '
        Me.chkPlotMean.AutoSize = True
        Me.chkPlotMean.Location = New System.Drawing.Point(20, 228)
        Me.chkPlotMean.Name = "chkPlotMean"
        Me.chkPlotMean.Size = New System.Drawing.Size(74, 17)
        Me.chkPlotMean.TabIndex = 6
        Me.chkPlotMean.Tag = "Plot Mean"
        Me.chkPlotMean.Text = "Plot Mean"
        Me.chkPlotMean.UseVisualStyleBackColor = True
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(195, 17)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(98, 118)
        Me.UcrReceiverMultiple1.TabIndex = 3
        '
        'UcrSelector1
        '
        Me.UcrSelector1.Location = New System.Drawing.Point(8, 12)
        Me.UcrSelector1.Name = "UcrSelector1"
        Me.UcrSelector1.Size = New System.Drawing.Size(181, 123)
        Me.UcrSelector1.TabIndex = 2
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(12, 266)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 32)
        Me.UcrBase.TabIndex = 1
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(175, 26)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(50, 20)
        Me.txtValue.TabIndex = 4
        '
        'dlgDisplayDaily
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 310)
        Me.Controls.Add(Me.chkPlotMean)
        Me.Controls.Add(Me.grpsummary)
        Me.Controls.Add(Me.chkSummary)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Controls.Add(Me.UcrSelector1)
        Me.Controls.Add(Me.UcrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDisplayDaily"
        Me.Text = "dlgDisplayDaily"
        Me.grpsummary.ResumeLayout(False)
        Me.grpsummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents UcrSelector1 As ucrSelector
    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents chkSummary As CheckBox
    Friend WithEvents grpsummary As GroupBox
    Friend WithEvents chkTotals As CheckBox
    Friend WithEvents chkCount As CheckBox
    Friend WithEvents chkMaximum As CheckBox
    Friend WithEvents chkPlotMean As CheckBox
    Friend WithEvents txtValue As TextBox
End Class
