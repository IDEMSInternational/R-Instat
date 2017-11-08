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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgSummaries))
        Me.ucrButtonsSummaries = New instat.ucrButtonsSubdialogue()
        Me.tbMissingOptions = New System.Windows.Forms.TabPage()
        Me.rdoPercentage = New System.Windows.Forms.RadioButton()
        Me.rdoNumber = New System.Windows.Forms.RadioButton()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.ucrNudPercentage = New instat.ucrNud()
        Me.ucrNudNumber = New instat.ucrNud()
        Me.tbMore = New System.Windows.Forms.TabPage()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblFractionTrimmed = New System.Windows.Forms.Label()
        Me.ucrNudFraction = New instat.ucrNud()
        Me.ucrChkTrimmedMean = New instat.ucrCheck()
        Me.ucrChkKurtosis = New instat.ucrCheck()
        Me.ucrChkSkewness = New instat.ucrCheck()
        Me.ucrChkSn = New instat.ucrCheck()
        Me.ucrChkQn = New instat.ucrCheck()
        Me.ucrChkMedianAbsoluteDeviation = New instat.ucrCheck()
        Me.ucrChkCoefficientOfVariation = New instat.ucrCheck()
        Me.grpScale = New System.Windows.Forms.GroupBox()
        Me.grpSkewness = New System.Windows.Forms.GroupBox()
        Me.ucrChkMc = New instat.ucrCheck()
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
        Me.grpLocation.SuspendLayout()
        Me.grpSkewness.SuspendLayout()
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
        resources.ApplyResources(Me.ucrButtonsSummaries, "ucrButtonsSummaries")
        Me.ucrButtonsSummaries.Name = "ucrButtonsSummaries"
        '
        'tbMissingOptions
        '
        Me.tbMissingOptions.Controls.Add(Me.rdoPercentage)
        Me.tbMissingOptions.Controls.Add(Me.rdoNumber)
        Me.tbMissingOptions.Controls.Add(Me.lblPercentage)
        Me.tbMissingOptions.Controls.Add(Me.lblNumber)
        Me.tbMissingOptions.Controls.Add(Me.ucrNudPercentage)
        Me.tbMissingOptions.Controls.Add(Me.ucrNudNumber)
        resources.ApplyResources(Me.tbMissingOptions, "tbMissingOptions")
        Me.tbMissingOptions.Name = "tbMissingOptions"
        Me.tbMissingOptions.UseVisualStyleBackColor = True
        '
        'rdoPercentage
        '
        resources.ApplyResources(Me.rdoPercentage, "rdoPercentage")
        Me.rdoPercentage.Name = "rdoPercentage"
        Me.rdoPercentage.TabStop = True
        Me.rdoPercentage.UseVisualStyleBackColor = True
        '
        'rdoNumber
        '
        resources.ApplyResources(Me.rdoNumber, "rdoNumber")
        Me.rdoNumber.Name = "rdoNumber"
        Me.rdoNumber.TabStop = True
        Me.rdoNumber.UseVisualStyleBackColor = True
        '
        'lblPercentage
        '
        resources.ApplyResources(Me.lblPercentage, "lblPercentage")
        Me.lblPercentage.Name = "lblPercentage"
        '
        'lblNumber
        '
        resources.ApplyResources(Me.lblNumber, "lblNumber")
        Me.lblNumber.Name = "lblNumber"
        '
        'ucrNudPercentage
        '
        Me.ucrNudPercentage.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentage.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPercentage, "ucrNudPercentage")
        Me.ucrNudPercentage.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentage.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentage.Name = "ucrNudPercentage"
        Me.ucrNudPercentage.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumber
        '
        Me.ucrNudNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumber, "ucrNudNumber")
        Me.ucrNudNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumber.Name = "ucrNudNumber"
        Me.ucrNudNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'tbMore
        '
        Me.tbMore.Controls.Add(Me.grpLocation)
        Me.tbMore.Controls.Add(Me.ucrChkKurtosis)
        Me.tbMore.Controls.Add(Me.ucrChkSkewness)
        Me.tbMore.Controls.Add(Me.ucrChkSn)
        Me.tbMore.Controls.Add(Me.ucrChkQn)
        Me.tbMore.Controls.Add(Me.ucrChkMedianAbsoluteDeviation)
        Me.tbMore.Controls.Add(Me.ucrChkCoefficientOfVariation)
        Me.tbMore.Controls.Add(Me.grpScale)
        Me.tbMore.Controls.Add(Me.grpSkewness)
        resources.ApplyResources(Me.tbMore, "tbMore")
        Me.tbMore.Name = "tbMore"
        Me.tbMore.UseVisualStyleBackColor = True
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.lblFractionTrimmed)
        Me.grpLocation.Controls.Add(Me.ucrNudFraction)
        Me.grpLocation.Controls.Add(Me.ucrChkTrimmedMean)
        resources.ApplyResources(Me.grpLocation, "grpLocation")
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.TabStop = False
        '
        'lblFractionTrimmed
        '
        resources.ApplyResources(Me.lblFractionTrimmed, "lblFractionTrimmed")
        Me.lblFractionTrimmed.Name = "lblFractionTrimmed"
        '
        'ucrNudFraction
        '
        Me.ucrNudFraction.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFraction, "ucrNudFraction")
        Me.ucrNudFraction.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFraction.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFraction.Name = "ucrNudFraction"
        Me.ucrNudFraction.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkTrimmedMean
        '
        Me.ucrChkTrimmedMean.Checked = False
        resources.ApplyResources(Me.ucrChkTrimmedMean, "ucrChkTrimmedMean")
        Me.ucrChkTrimmedMean.Name = "ucrChkTrimmedMean"
        '
        'ucrChkKurtosis
        '
        Me.ucrChkKurtosis.Checked = False
        resources.ApplyResources(Me.ucrChkKurtosis, "ucrChkKurtosis")
        Me.ucrChkKurtosis.Name = "ucrChkKurtosis"
        '
        'ucrChkSkewness
        '
        Me.ucrChkSkewness.Checked = False
        resources.ApplyResources(Me.ucrChkSkewness, "ucrChkSkewness")
        Me.ucrChkSkewness.Name = "ucrChkSkewness"
        '
        'ucrChkSn
        '
        Me.ucrChkSn.Checked = False
        resources.ApplyResources(Me.ucrChkSn, "ucrChkSn")
        Me.ucrChkSn.Name = "ucrChkSn"
        '
        'ucrChkQn
        '
        Me.ucrChkQn.Checked = False
        resources.ApplyResources(Me.ucrChkQn, "ucrChkQn")
        Me.ucrChkQn.Name = "ucrChkQn"
        '
        'ucrChkMedianAbsoluteDeviation
        '
        Me.ucrChkMedianAbsoluteDeviation.Checked = False
        resources.ApplyResources(Me.ucrChkMedianAbsoluteDeviation, "ucrChkMedianAbsoluteDeviation")
        Me.ucrChkMedianAbsoluteDeviation.Name = "ucrChkMedianAbsoluteDeviation"
        '
        'ucrChkCoefficientOfVariation
        '
        Me.ucrChkCoefficientOfVariation.Checked = False
        resources.ApplyResources(Me.ucrChkCoefficientOfVariation, "ucrChkCoefficientOfVariation")
        Me.ucrChkCoefficientOfVariation.Name = "ucrChkCoefficientOfVariation"
        '
        'grpScale
        '
        resources.ApplyResources(Me.grpScale, "grpScale")
        Me.grpScale.Name = "grpScale"
        Me.grpScale.TabStop = False
        '
        'grpSkewness
        '
        Me.grpSkewness.Controls.Add(Me.ucrChkMc)
        resources.ApplyResources(Me.grpSkewness, "grpSkewness")
        Me.grpSkewness.Name = "grpSkewness"
        Me.grpSkewness.TabStop = False
        '
        'ucrChkMc
        '
        Me.ucrChkMc.Checked = False
        resources.ApplyResources(Me.ucrChkMc, "ucrChkMc")
        Me.ucrChkMc.Name = "ucrChkMc"
        '
        'tbsum
        '
        Me.tbsum.Controls.Add(Me.grpCommon)
        Me.tbsum.Controls.Add(Me.grpQuartiles)
        Me.tbsum.Controls.Add(Me.grpNotOrderedFactor)
        Me.tbsum.Controls.Add(Me.grpNumeric)
        resources.ApplyResources(Me.tbsum, "tbsum")
        Me.tbsum.Name = "tbsum"
        Me.tbsum.UseVisualStyleBackColor = True
        '
        'grpCommon
        '
        Me.grpCommon.Controls.Add(Me.ucrChkNTotal)
        Me.grpCommon.Controls.Add(Me.ucrChkMode)
        Me.grpCommon.Controls.Add(Me.ucrChkNMissing)
        Me.grpCommon.Controls.Add(Me.ucrChkNonMissing)
        resources.ApplyResources(Me.grpCommon, "grpCommon")
        Me.grpCommon.Name = "grpCommon"
        Me.grpCommon.TabStop = False
        Me.grpCommon.Tag = "Common"
        '
        'ucrChkNTotal
        '
        Me.ucrChkNTotal.Checked = False
        resources.ApplyResources(Me.ucrChkNTotal, "ucrChkNTotal")
        Me.ucrChkNTotal.Name = "ucrChkNTotal"
        '
        'ucrChkMode
        '
        Me.ucrChkMode.Checked = False
        resources.ApplyResources(Me.ucrChkMode, "ucrChkMode")
        Me.ucrChkMode.Name = "ucrChkMode"
        '
        'ucrChkNMissing
        '
        Me.ucrChkNMissing.Checked = False
        resources.ApplyResources(Me.ucrChkNMissing, "ucrChkNMissing")
        Me.ucrChkNMissing.Name = "ucrChkNMissing"
        '
        'ucrChkNonMissing
        '
        Me.ucrChkNonMissing.Checked = False
        resources.ApplyResources(Me.ucrChkNonMissing, "ucrChkNonMissing")
        Me.ucrChkNonMissing.Name = "ucrChkNonMissing"
        '
        'grpQuartiles
        '
        Me.grpQuartiles.Controls.Add(Me.ucrChkLowerQuartile)
        Me.grpQuartiles.Controls.Add(Me.ucrChkUpperQuartile)
        resources.ApplyResources(Me.grpQuartiles, "grpQuartiles")
        Me.grpQuartiles.Name = "grpQuartiles"
        Me.grpQuartiles.TabStop = False
        Me.grpQuartiles.Tag = "Quartiles"
        '
        'ucrChkLowerQuartile
        '
        Me.ucrChkLowerQuartile.Checked = False
        resources.ApplyResources(Me.ucrChkLowerQuartile, "ucrChkLowerQuartile")
        Me.ucrChkLowerQuartile.Name = "ucrChkLowerQuartile"
        '
        'ucrChkUpperQuartile
        '
        Me.ucrChkUpperQuartile.Checked = False
        resources.ApplyResources(Me.ucrChkUpperQuartile, "ucrChkUpperQuartile")
        Me.ucrChkUpperQuartile.Name = "ucrChkUpperQuartile"
        '
        'grpNotOrderedFactor
        '
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkRange)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMaximum)
        Me.grpNotOrderedFactor.Controls.Add(Me.ucrChkMinimum)
        resources.ApplyResources(Me.grpNotOrderedFactor, "grpNotOrderedFactor")
        Me.grpNotOrderedFactor.Name = "grpNotOrderedFactor"
        Me.grpNotOrderedFactor.TabStop = False
        Me.grpNotOrderedFactor.Tag = "All_but_unordered_Factor"
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        resources.ApplyResources(Me.ucrChkRange, "ucrChkRange")
        Me.ucrChkRange.Name = "ucrChkRange"
        '
        'ucrChkMaximum
        '
        Me.ucrChkMaximum.Checked = False
        resources.ApplyResources(Me.ucrChkMaximum, "ucrChkMaximum")
        Me.ucrChkMaximum.Name = "ucrChkMaximum"
        '
        'ucrChkMinimum
        '
        Me.ucrChkMinimum.Checked = False
        resources.ApplyResources(Me.ucrChkMinimum, "ucrChkMinimum")
        Me.ucrChkMinimum.Name = "ucrChkMinimum"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.ucrChkVariance)
        Me.grpNumeric.Controls.Add(Me.ucrChkMedian)
        Me.grpNumeric.Controls.Add(Me.ucrChkStdDev)
        Me.grpNumeric.Controls.Add(Me.ucrChkSum)
        Me.grpNumeric.Controls.Add(Me.ucrChkMean)
        resources.ApplyResources(Me.grpNumeric, "grpNumeric")
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Tag = "Numeric"
        '
        'ucrChkVariance
        '
        Me.ucrChkVariance.Checked = False
        resources.ApplyResources(Me.ucrChkVariance, "ucrChkVariance")
        Me.ucrChkVariance.Name = "ucrChkVariance"
        '
        'ucrChkMedian
        '
        Me.ucrChkMedian.Checked = False
        resources.ApplyResources(Me.ucrChkMedian, "ucrChkMedian")
        Me.ucrChkMedian.Name = "ucrChkMedian"
        '
        'ucrChkStdDev
        '
        Me.ucrChkStdDev.Checked = False
        resources.ApplyResources(Me.ucrChkStdDev, "ucrChkStdDev")
        Me.ucrChkStdDev.Name = "ucrChkStdDev"
        '
        'ucrChkSum
        '
        Me.ucrChkSum.Checked = False
        resources.ApplyResources(Me.ucrChkSum, "ucrChkSum")
        Me.ucrChkSum.Name = "ucrChkSum"
        '
        'ucrChkMean
        '
        Me.ucrChkMean.Checked = False
        resources.ApplyResources(Me.ucrChkMean, "ucrChkMean")
        Me.ucrChkMean.Name = "ucrChkMean"
        '
        'tbSummaries
        '
        Me.tbSummaries.Controls.Add(Me.tbsum)
        Me.tbSummaries.Controls.Add(Me.tbMore)
        Me.tbSummaries.Controls.Add(Me.tbMissingOptions)
        resources.ApplyResources(Me.tbSummaries, "tbSummaries")
        Me.tbSummaries.Name = "tbSummaries"
        Me.tbSummaries.SelectedIndex = 0
        '
        'sdgSummaries
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbSummaries)
        Me.Controls.Add(Me.ucrButtonsSummaries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgSummaries"
        Me.Tag = "Summaries"
        Me.tbMissingOptions.ResumeLayout(False)
        Me.tbMissingOptions.PerformLayout()
        Me.tbMore.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpSkewness.ResumeLayout(False)
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
    Friend WithEvents grpScale As GroupBox
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents grpSkewness As GroupBox
    Friend WithEvents ucrChkTrimmedMean As ucrCheck
    Friend WithEvents ucrChkMc As ucrCheck
    Friend WithEvents lblFractionTrimmed As Label
    Friend WithEvents ucrNudFraction As ucrNud
End Class