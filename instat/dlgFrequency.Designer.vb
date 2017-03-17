<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFrequency
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrFactorsSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrchkCounts = New instat.ucrCheck()
        Me.ucrchkOverallPercentages = New instat.ucrCheck()
        Me.ucrchkPercentagesOf = New instat.ucrCheck()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(18, 325)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 55)
        Me.ucrBase.TabIndex = 1
        '
        'ucrFactorsSelector
        '
        Me.ucrFactorsSelector.bShowHiddenColumns = False
        Me.ucrFactorsSelector.bUseCurrentFilter = True
        Me.ucrFactorsSelector.Location = New System.Drawing.Point(10, 10)
        Me.ucrFactorsSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorsSelector.Name = "ucrFactorsSelector"
        Me.ucrFactorsSelector.Size = New System.Drawing.Size(210, 182)
        Me.ucrFactorsSelector.TabIndex = 2
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.frmParent = Me
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(220, 60)
        Me.UcrReceiverMultiple1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Selector = Nothing
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(120, 100)
        Me.UcrReceiverMultiple1.TabIndex = 3
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(217, 45)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 4
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrchkPercentagesOf)
        Me.GroupBox1.Controls.Add(Me.ucrchkOverallPercentages)
        Me.GroupBox1.Controls.Add(Me.ucrchkCounts)
        Me.GroupBox1.Location = New System.Drawing.Point(220, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 101)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display:"
        '
        'ucrchkCounts
        '
        Me.ucrchkCounts.Checked = False
        Me.ucrchkCounts.Location = New System.Drawing.Point(5, 19)
        Me.ucrchkCounts.Name = "ucrchkCounts"
        Me.ucrchkCounts.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkCounts.TabIndex = 0
        '
        'ucrchkOverallPercentages
        '
        Me.ucrchkOverallPercentages.Checked = False
        Me.ucrchkOverallPercentages.Location = New System.Drawing.Point(6, 45)
        Me.ucrchkOverallPercentages.Name = "ucrchkOverallPercentages"
        Me.ucrchkOverallPercentages.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkOverallPercentages.TabIndex = 1
        '
        'ucrchkPercentagesOf
        '
        Me.ucrchkPercentagesOf.Checked = False
        Me.ucrchkPercentagesOf.Location = New System.Drawing.Point(5, 71)
        Me.ucrchkPercentagesOf.Name = "ucrchkPercentagesOf"
        Me.ucrchkPercentagesOf.Size = New System.Drawing.Size(104, 20)
        Me.ucrchkPercentagesOf.TabIndex = 2
        '
        'dlgFrequency
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Controls.Add(Me.ucrFactorsSelector)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFrequency"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frequency"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrFactorsSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrchkPercentagesOf As ucrCheck
    Friend WithEvents ucrchkOverallPercentages As ucrCheck
    Friend WithEvents ucrchkCounts As ucrCheck
End Class
