' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.tbMissingOptions = New System.Windows.Forms.TabPage()
        Me.rdoPercentage = New System.Windows.Forms.RadioButton()
        Me.rdoNumber = New System.Windows.Forms.RadioButton()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.ucrNudPercentage = New instat.ucrNud()
        Me.ucrNudNumber = New instat.ucrNud()
        Me.tbMore = New System.Windows.Forms.TabPage()
        Me.ucrChkKurtosis = New instat.ucrCheck()
        Me.ucrChkSkewness = New instat.ucrCheck()
        Me.ucrChkSn = New instat.ucrCheck()
        Me.ucrChkQn = New instat.ucrCheck()
        Me.ucrChkMedianAbsoluteDeviation = New instat.ucrCheck()
        Me.ucrChkCoefficientOfVariation = New instat.ucrCheck()
        Me.tbsum = New System.Windows.Forms.TabPage()
        Me.grpCommon = New System.Windows.Forms.GroupBox()
        Me.ucrChkNTotal = New instat.ucrCheck()
        Me.ucrChkMode = New instat.ucrCheck()
        Me.ucrChkNMissing = New instat.ucrCheck()
        Me.ucrChkNonMissing = New instat.ucrCheck()
        Me.grpQuartiles = New System.Windows.Forms.GroupBox()
        Me.ucrChkLowerQuartile = New instat.ucrCheck()
        Me.ucrChkUpperQuartile = New instat.ucrCheck()
        Me.grpNotOrderedFactor = New System.Windows.Forms.GroupBox()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.ucrChkMaximum = New instat.ucrCheck()
        Me.ucrChkMinimum = New instat.ucrCheck()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.ucrChkVariance = New instat.ucrCheck()
        Me.ucrChkMedian = New instat.ucrCheck()
        Me.ucrChkStdDev = New instat.ucrCheck()
        Me.ucrChkSum = New instat.ucrCheck()
        Me.ucrChkMean = New instat.ucrCheck()
        Me.tbSummaries = New System.Windows.Forms.TabControl()
        Me.tbMissingOptions.SuspendLayout()
        Me.tbMore.SuspendLayout()
        Me.tbsum.SuspendLayout()
        Me.grpCommon.SuspendLayout()
        Me.grpQuartiles.SuspendLayout()
        Me.grpNotOrderedFactor.SuspendLayout()
        Me.grpNumeric.SuspendLayout()
        Me.tbSummaries.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsSummaries
        '
        Me.ucrButtonsSummaries.Location = New System.Drawing.Point(97, 363)
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        Me.ucrButtonsSummaries.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSummaries.TabIndex = 4
        '
        'tbMissingOptions
        '
        Me.tbMissingOptions.Controls.Add(Me.rdoPercentage)
        Me.tbMissingOptions.Controls.Add(Me.rdoNumber)
        Me.tbMissingOptions.Controls.Add(Me.lblPercentage)
        Me.tbMissingOptions.Controls.Add(Me.lblNumber)
        Me.tbMissingOptions.Controls.Add(Me.ucrNudPercentage)
        Me.tbMissingOptions.Controls.Add(Me.ucrNudNumber)
        Me.tbMissingOptions.Location = New System.Drawing.Point(4, 22)
        Me.tbMissingOptions.Name = "tbMissingOptions"
        Me.tbMissingOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMissingOptions.Size = New System.Drawing.Size(317, 327)
        Me.tbMissingOptions.TabIndex = 4
        Me.tbMissingOptions.Text = "Missing Options"
        Me.tbMissingOptions.UseVisualStyleBackColor = True
        '
        'rdoPercentage
        '
        Me.rdoPercentage.AutoSize = True
        Me.rdoPercentage.Location = New System.Drawing.Point(9, 46)
        Me.rdoPercentage.Name = "rdoPercentage"
        Me.rdoPercentage.Size = New System.Drawing.Size(80, 17)
        Me.rdoPercentage.TabIndex = 8
        Me.rdoPercentage.TabStop = True
        Me.rdoPercentage.Text = "Percentage"
        Me.rdoPercentage.UseVisualStyleBackColor = True
        '
        'rdoNumber
        '
        Me.rdoNumber.AutoSize = True
        Me.rdoNumber.Location = New System.Drawing.Point(9, 23)
        Me.rdoNumber.Name = "rdoNumber"
        Me.rdoNumber.Size = New System.Drawing.Size(62, 17)
        Me.rdoNumber.TabIndex = 7
        Me.rdoNumber.TabStop = True
        Me.rdoNumber.Text = "Number"
        Me.rdoNumber.UseVisualStyleBackColor = True
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(4, 70)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(308, 13)
        Me.lblPercentage.TabIndex = 6
        Me.lblPercentage.Text = "Summary set to missing if more than this percentage are missing:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(6, 70)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(280, 13)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Summary set to missing if more than this value are missing:"
        '
        'ucrNudPercentage
        '
        Me.ucrNudPercentage.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentage.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPercentage.Location = New System.Drawing.Point(319, 66)
        Me.ucrNudPercentage.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentage.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentage.Name = "ucrNudPercentage"
        Me.ucrNudPercentage.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPercentage.TabIndex = 4
        Me.ucrNudPercentage.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumber
        '
        Me.ucrNudNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumber.Location = New System.Drawing.Point(318, 66)
        Me.ucrNudNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Name = "ucrNudNumber"
        Me.ucrNudNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumber.TabIndex = 3
        Me.ucrNudNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'tbMore
        '
        Me.tbMore.Controls.Add(Me.ucrChkKurtosis)
        Me.tbMore.Controls.Add(Me.ucrChkSkewness)
        Me.tbMore.Controls.Add(Me.ucrChkSn)
        Me.tbMore.Controls.Add(Me.ucrChkQn)
        Me.tbMore.Controls.Add(Me.ucrChkMedianAbsoluteDeviation)
        Me.tbMore.Controls.Add(Me.ucrChkCoefficientOfVariation)
        Me.tbMore.Location = New System.Drawing.Point(4, 22)
        Me.tbMore.Name = "tbMore"
        Me.tbMore.Padding = New System.Windows.Forms.Padding(3)
        Me.tbMore.Size = New System.Drawing.Size(317, 327)
        Me.tbMore.TabIndex = 1
        Me.tbMore.Text = "More"
        Me.tbMore.UseVisualStyleBackColor = True
        '
        'ucrChkKurtosis
        '
        Me.ucrChkKurtosis.Checked = False
        Me.ucrChkKurtosis.Location = New System.Drawing.Point(222, 78)
        Me.ucrChkKurtosis.Name = "ucrChkKurtosis"
        Me.ucrChkKurtosis.Size = New System.Drawing.Size(91, 20)
        Me.ucrChkKurtosis.TabIndex = 6
        '
        'ucrChkSkewness
        '
        Me.ucrChkSkewness.Checked = False
        Me.ucrChkSkewness.Location = New System.Drawing.Point(14, 78)
        Me.ucrChkSkewness.Name = "ucrChkSkewness"
        Me.ucrChkSkewness.Size = New System.Drawing.Size(152, 20)
        Me.ucrChkSkewness.TabIndex = 5
        '
        'ucrChkSn
        '
        Me.ucrChkSn.Checked = False
        Me.ucrChkSn.Location = New System.Drawing.Point(222, 51)
        Me.ucrChkSn.Name = "ucrChkSn"
        Me.ucrChkSn.Size = New System.Drawing.Size(82, 20)
        Me.ucrChkSn.TabIndex = 4
        '
        'ucrChkQn
        '
        Me.ucrChkQn.Checked = False
        Me.ucrChkQn.Location = New System.Drawing.Point(222, 25)
        Me.ucrChkQn.Name = "ucrChkQn"
        Me.ucrChkQn.Size = New System.Drawing.Size(85, 20)
        Me.ucrChkQn.TabIndex = 3
        '
        'ucrChkMedianAbsoluteDeviation
        '
        Me.ucrChkMedianAbsoluteDeviation.Checked = False
        Me.ucrChkMedianAbsoluteDeviation.Location = New System.Drawing.Point(14, 51)
        Me.ucrChkMedianAbsoluteDeviation.Name = "ucrChkMedianAbsoluteDeviation"
        Me.ucrChkMedianAbsoluteDeviation.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkMedianAbsoluteDeviation.TabIndex = 2
        '
        'ucrChkCoefficientOfVariation
        '
        Me.ucrChkCoefficientOfVariation.Checked = False
        Me.ucrChkCoefficientOfVariation.Location = New System.Drawing.Point(14, 25)
        Me.ucrChkCoefficientOfVariation.Name = "ucrChkCoefficientOfVariation"
        Me.ucrChkCoefficientOfVariation.Size = New System.Drawing.Size(171, 20)
        Me.ucrChkCoefficientOfVariation.TabIndex = 1
        '
        'tbsum
        '
        Me.tbsum.Controls.Add(Me.grpCommon)
        Me.tbsum.Controls.Add(Me.grpQuartiles)
        Me.tbsum.Controls.Add(Me.grpNotOrderedFactor)
        Me.tbsum.Controls.Add(Me.grpNumeric)
        Me.tbsum.Location = New System.Drawing.Point(4, 22)
        Me.tbsum.Name = "tbsum"
        Me.tbsum.Padding = New System.Windows.Forms.Padding(3)
        Me.tbsum.Size = New System.Drawing.Size(317, 327)
        Me.tbsum.TabIndex = 0
        Me.tbsum.Text = "Summaries"
        Me.tbsum.UseVisualStyleBackColor = True
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.ucrChkNTotal)
        Me.grpCommon.Controls.Add(Me.ucrChkMode)
        Me.grpCommon.Controls.Add(Me.ucrChkNMissing)
        Me.grpCommon.Controls.Add(Me.ucrChkNonMissing)
        Me.grpCommon.Location = New System.Drawing.Point(6, 6)
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.Size = New System.Drawing.Size(303, 72)
        Me.grpCommon.TabIndex = 0
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        Me.grpCommon.Text = "Common"
        '
        'ucrChkNTotal
        '
        Me.ucrChkNTotal.Checked = False
        Me.ucrChkNTotal.Location = New System.Drawing.Point(174, 19)
        Me.ucrChkNTotal.Name = "ucrChkNTotal"
        Me.ucrChkNTotal.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNTotal.TabIndex = 2
        '
        'ucrChkMode
        '
        Me.ucrChkMode.Checked = False
        Me.ucrChkMode.Location = New System.Drawing.Point(174, 45)
        Me.ucrChkMode.Name = "ucrChkMode"
        Me.ucrChkMode.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMode.TabIndex = 3
        '
        'ucrChkNMissing
        '
        Me.ucrChkNMissing.Checked = False
        Me.ucrChkNMissing.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkNMissing.Name = "ucrChkNMissing"
        Me.ucrChkNMissing.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNMissing.TabIndex = 1
        '
        'ucrChkNonMissing
        '
        Me.ucrChkNonMissing.Checked = False
        Me.ucrChkNonMissing.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkNonMissing.Name = "ucrChkNonMissing"
        Me.ucrChkNonMissing.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNonMissing.TabIndex = 0
        '
        'grpQuartiles
        '
        Me.grpQuartiles.Controls.Add(Me.ucrChkLowerQuartile)
        Me.grpQuartiles.Controls.Add(Me.ucrChkUpperQuartile)
        Me.grpQuartiles.Location = New System.Drawing.Point(6, 265)
        Me.grpQuartiles.Name = "grpQuartiles"
        Me.grpQuartiles.Size = New System.Drawing.Size(303, 56)
        Me.grpQuartiles.TabIndex = 3
        Me.grpQuartiles.TabStop = False
        Me.grpQuartiles.Tag = "Quartiles"
        Me.grpQuartiles.Text = "Quartiles"
        '
        'ucrChkLowerQuartile
        '
        Me.ucrChkLowerQuartile.Checked = False
        Me.ucrChkLowerQuartile.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkLowerQuartile.Name = "ucrChkLowerQuartile"
        Me.ucrChkLowerQuartile.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLowerQuartile.TabIndex = 1
        '
        'ucrChkUpperQuartile
        '
        Me.ucrChkUpperQuartile.Checked = False
        Me.ucrChkUpperQuartile.Location = New System.Drawing.Point(174, 19)
        Me.ucrChkUpperQuartile.Name = "ucrChkUpperQuartile"
        Me.ucrChkUpperQuartile.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkUpperQuartile.TabIndex = 0
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkRange)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMaximum)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMinimum)
        Me.grpNotOrderedFactor.Location = New System.Drawing.Point(6, 80)
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.Size = New System.Drawing.Size(303, 71)
        Me.grpNotOrderedFactor.TabIndex = 1
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unordered_Factor"
        Me.grpNotOrderedFactor.Text = "All but (unordered) Factor"
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        Me.ucrChkRange.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkRange.Name = "ucrChkRange"
        Me.ucrChkRange.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkRange.TabIndex = 1
        '
        'ucrChkMaximum
        '
        Me.ucrChkMaximum.Checked = False
        Me.ucrChkMaximum.Location = New System.Drawing.Point(174, 19)
        Me.ucrChkMaximum.Name = "ucrChkMaximum"
        Me.ucrChkMaximum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMaximum.TabIndex = 2
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.Checked = False
        Me.ucrChkMinimum.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        Me.ucrChkMinimum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMinimum.TabIndex = 0
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.ucrChkVariance)
        Me.grpNumeric.Controls.Add(Me.ucrChkMedian)
        Me.grpNumeric.Controls.Add(Me.ucrChkStdDev)
        Me.grpNumeric.Controls.Add(Me.ucrChkSum)
        Me.grpNumeric.Controls.Add(Me.ucrChkMean)
        Me.grpNumeric.Location = New System.Drawing.Point(5, 153)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Size = New System.Drawing.Size(303, 110)
        Me.grpNumeric.TabIndex = 2
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        Me.grpNumeric.Text = "Numeric"
        '
        'ucrChkVariance
        '
        Me.ucrChkVariance.Checked = False
        Me.ucrChkVariance.Location = New System.Drawing.Point(8, 71)
        Me.ucrChkVariance.Name = "ucrChkVariance"
        Me.ucrChkVariance.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkVariance.TabIndex = 2
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        Me.ucrChkMedian.Location = New System.Drawing.Point(175, 19)
        Me.ucrChkMedian.Name = "ucrChkMedian"
        Me.ucrChkMedian.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMedian.TabIndex = 3
        '
        'ucrChkStdDev
        '
        Me.ucrChkStdDev.Checked = False
        Me.ucrChkStdDev.Location = New System.Drawing.Point(175, 45)
        Me.ucrChkStdDev.Name = "ucrChkStdDev"
        Me.ucrChkStdDev.Size = New System.Drawing.Size(122, 20)
        Me.ucrChkStdDev.TabIndex = 4
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        Me.ucrChkSum.Location = New System.Drawing.Point(8, 19)
        Me.ucrChkSum.Name = "ucrChkSum"
        Me.ucrChkSum.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkSum.TabIndex = 0
        '
        'ucrChkMean
        '
        Me.ucrChkMean.Checked = False
        Me.ucrChkMean.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkMean.Name = "ucrChkMean"
        Me.ucrChkMean.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMean.TabIndex = 1
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbsum)
        Me.tbSummaries.Controls.Add(Me.tbMore)
        Me.tbSummaries.Controls.Add(Me.tbMissingOptions)
        Me.tbSummaries.Location = New System.Drawing.Point(7, 7)
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        Me.tbSummaries.Size = New System.Drawing.Size(325, 353)
        Me.tbSummaries.TabIndex = 0
        '
        'sdgSummaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 397)
        Me.Controls.Add(Me.tbSummaries)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Summaries"
        Me.Text = "Summaries"
        Me.tbMissingOptions.ResumeLayout(False)
        Me.tbMissingOptions.PerformLayout()
        Me.tbMore.ResumeLayout(False)
        Me.tbsum.ResumeLayout(False)
        Me.grpCommon.ResumeLayout(False)
        Me.grpQuartiles.ResumeLayout(False)
        Me.grpNotOrderedFactor.ResumeLayout(False)
        Me.grpNumeric.ResumeLayout(False)
        Me.tbSummaries.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSummaries As ucrButtonsSubdialogue
    Friend WithEvents tbMissingOptions As TabPage
    Friend WithEvents rdoPercentage As RadioButton
    Friend WithEvents rdoNumber As RadioButton
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents ucrNudPercentage As ucrNud
    Friend WithEvents ucrNudNumber As ucrNud
    Friend WithEvents tbMore As TabPage
    Friend WithEvents ucrChkKurtosis As ucrCheck
    Friend WithEvents ucrChkSkewness As ucrCheck
    Friend WithEvents ucrChkSn As ucrCheck
    Friend WithEvents ucrChkQn As ucrCheck
    Friend WithEvents ucrChkMedianAbsoluteDeviation As ucrCheck
    Friend WithEvents ucrChkCoefficientOfVariation As ucrCheck
    Friend WithEvents tbsum As TabPage
    Friend WithEvents grpCommon As GroupBox
    Friend WithEvents ucrChkNTotal As ucrCheck
    Friend WithEvents ucrChkMode As ucrCheck
    Friend WithEvents ucrChkNMissing As ucrCheck
    Friend WithEvents ucrChkNonMissing As ucrCheck
    Friend WithEvents grpQuartiles As GroupBox
    Friend WithEvents ucrChkLowerQuartile As ucrCheck
    Friend WithEvents ucrChkUpperQuartile As ucrCheck
    Friend WithEvents grpNotOrderedFactor As GroupBox
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents ucrChkMaximum As ucrCheck
    Friend WithEvents ucrChkMinimum As ucrCheck
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents ucrChkVariance As ucrCheck
    Friend WithEvents ucrChkMedian As ucrCheck
    Friend WithEvents ucrChkStdDev As ucrCheck
    Friend WithEvents ucrChkSum As ucrCheck
    Friend WithEvents ucrChkMean As ucrCheck
    Friend WithEvents tbSummaries As TabControl
End Class