﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgSummaries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpCommon = New System.Windows.Forms.GroupBox()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.ucrChkNonMissing = New instat.ucrCheck()
        Me.ucrChkNMissing = New instat.ucrCheck()
        Me.ucrChkMode = New instat.ucrCheck()
        Me.ucrChkNTotal = New instat.ucrCheck()
        Me.ucrChkMinimum = New instat.ucrCheck()
        Me.ucrChkMaximum = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
        Me.ucrChkStdDev = New instat.ucrCheck()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkVariance = New instat.ucrCheck()
        Me.ucrChkQuartiles = New instat.ucrCheck()
        Me.grpCommon.SuspendLayout()
        Me.grpNotOrderedFactor.SuspendLayout()
        Me.grpNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.ucrChkNTotal)
        Me.grpCommon.Controls.Add(Me.ucrChkMode)
        Me.grpCommon.Controls.Add(Me.ucrChkNMissing)
        Me.grpCommon.Controls.Add(Me.ucrChkNonMissing)
        Me.grpCommon.Location = New System.Drawing.Point(12, 8)
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.Size = New System.Drawing.Size(244, 57)
        Me.grpCommon.TabIndex = 0
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        Me.grpCommon.Text = "Common"
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMaximum)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMinimum)
        Me.grpNotOrderedFactor.Location = New System.Drawing.Point(13, 72)
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.Size = New System.Drawing.Size(243, 46)
        Me.grpNotOrderedFactor.TabIndex = 1
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unrdered_factor"
        Me.grpNotOrderedFactor.Text = "All but (Unordered) factor"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.ucrChkQuartiles)
        Me.grpNumeric.Controls.Add(Me.ucrChkVariance)
        Me.grpNumeric.Controls.Add(Me.ucrChkMedian)
        Me.grpNumeric.Controls.Add(Me.ucrChkStdDev)
        Me.grpNumeric.Controls.Add(Me.ucrChkRange)
        Me.grpNumeric.Controls.Add(Me.ucrChkSum)
        Me.grpNumeric.Controls.Add(Me.ucrChkMean)
        Me.grpNumeric.Location = New System.Drawing.Point(13, 123)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Size = New System.Drawing.Size(243, 108)
        Me.grpNumeric.TabIndex = 2
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        Me.grpNumeric.Text = "Numeric"
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(62, 236)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSummaries.TabIndex = 3
        '
        'ucrChkNonMissing
        '
        Me.ucrChkNonMissing.Checked = False
        Me.ucrChkNonMissing.Location = New System.Drawing.Point(13, 17)
        Me.ucrChkNonMissing.Name = "ucrChkNonMissing"
        Me.ucrChkNonMissing.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNonMissing.TabIndex = 4
        '
        'ucrChkNMissing
        '
        Me.ucrChkNMissing.Checked = False
        Me.ucrChkNMissing.Location = New System.Drawing.Point(13, 38)
        Me.ucrChkNMissing.Name = "ucrChkNMissing"
        Me.ucrChkNMissing.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNMissing.TabIndex = 5
        '
        'ucrChkMode
        '
        Me.ucrChkMode.Checked = False
        Me.ucrChkMode.Location = New System.Drawing.Point(151, 38)
        Me.ucrChkMode.Name = "ucrChkMode"
        Me.ucrChkMode.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMode.TabIndex = 6
        '
        'ucrChkNTotal
        '
        Me.ucrChkNTotal.Checked = False
        Me.ucrChkNTotal.Location = New System.Drawing.Point(151, 17)
        Me.ucrChkNTotal.Name = "ucrChkNTotal"
        Me.ucrChkNTotal.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNTotal.TabIndex = 7
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.Checked = False
        Me.ucrChkMinimum.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        Me.ucrChkMinimum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMinimum.TabIndex = 8
        '
        'ucrChkMaximum
        '
        Me.ucrChkMaximum.Checked = False
        Me.ucrChkMaximum.Location = New System.Drawing.Point(137, 20)
        Me.ucrChkMaximum.Name = "ucrChkMaximum"
        Me.ucrChkMaximum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMaximum.TabIndex = 9
        '
        'ucrChkMean
        '
        Me.ucrChkMean.Checked = False
        Me.ucrChkMean.Location = New System.Drawing.Point(12, 40)
        Me.ucrChkMean.Name = "ucrChkMean"
        Me.ucrChkMean.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMean.TabIndex = 10
        '
        'ucrChkStdDev
        '
        Me.ucrChkStdDev.Checked = False
        Me.ucrChkStdDev.Location = New System.Drawing.Point(12, 84)
        Me.ucrChkStdDev.Name = "ucrChkStdDev"
        Me.ucrChkStdDev.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkStdDev.TabIndex = 11
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        Me.ucrChkRange.Location = New System.Drawing.Point(12, 58)
        Me.ucrChkRange.Name = "ucrChkRange"
        Me.ucrChkRange.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRange.TabIndex = 12
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        Me.ucrChkSum.Location = New System.Drawing.Point(12, 19)
        Me.ucrChkSum.Name = "ucrChkSum"
        Me.ucrChkSum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSum.TabIndex = 13
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(150, 14)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMedian.TabIndex = 14
        '
        'ucrChkVariance
        '
        Me.ucrChkVariance.Checked = False
        Me.ucrChkVariance.Location = New System.Drawing.Point(150, 61)
        Me.ucrChkVariance.Name = "ucrChkVariance"
        Me.ucrChkVariance.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkVariance.TabIndex = 15
        '
        'ucrChkQuartiles
        '
        Me.ucrChkQuartiles.Checked = False
        Me.ucrChkQuartiles.Location = New System.Drawing.Point(150, 35)
        Me.ucrChkQuartiles.Name = "ucrChkQuartiles"
        Me.ucrChkQuartiles.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkQuartiles.TabIndex = 16
        '
        'sdgSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 266)
        Me.Controls.Add(Me.grpNumeric)
        Me.Controls.Add(Me.grpCommon)
        Me.Controls.Add(Me.grpNotOrderedFactor)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Summaries"
        Me.Text = "Summaries"
        Me.grpCommon.ResumeLayout(False)
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNumeric.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents grpCommon As GroupBox
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents grpNotOrderedFactor As GroupBox
    Friend WithEvents ucrChkNonMissing As ucrCheck
    Friend WithEvents ucrChkNTotal As ucrCheck
    Friend WithEvents ucrChkMode As ucrCheck
    Friend WithEvents ucrChkNMissing As ucrCheck
    Friend WithEvents ucrChkMinimum As ucrCheck
    Friend WithEvents ucrChkMaximum As ucrCheck
    Friend WithEvents ucrChkSum As ucrCheck
    Friend WithEvents ucrChkMean As ucrCheck
    Friend WithEvents ucrChkStdDev As ucrCheck
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents ucrChkVariance As ucrCheck
    Friend WithEvents ucrChkMedian As ucrCheck
    Friend WithEvents ucrChkQuartiles As ucrCheck
End Class