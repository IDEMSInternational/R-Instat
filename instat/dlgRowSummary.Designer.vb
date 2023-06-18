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
Partial Class dlgRowSummary
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
        Me.lblSelectedVariables = New System.Windows.Forms.Label()
        Me.grpStatistic = New System.Windows.Forms.GroupBox()
        Me.lblTrim = New System.Windows.Forms.Label()
        Me.rdoMore = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoNumberMissing = New System.Windows.Forms.RadioButton()
        Me.rdoMedian = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.lblProp = New System.Windows.Forms.Label()
        Me.ucrInputUserDefined = New instat.ucrInputComboBox()
        Me.ucrNudProp = New instat.ucrNud()
        Me.ucrNudTrim = New instat.ucrNud()
        Me.ucrPnlStatistics = New instat.UcrPanel()
        Me.grpMultipleRowSummary = New System.Windows.Forms.GroupBox()
        Me.ucrInputTiesMethod = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrChkType = New instat.ucrCheck()
        Me.ucrChkTiesMethod = New instat.ucrCheck()
        Me.ucrInputProbability = New instat.ucrInputComboBox()
        Me.rdoRowRanks = New System.Windows.Forms.RadioButton()
        Me.rdoRowQuantile = New System.Windows.Forms.RadioButton()
        Me.rdoRowRange = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMultipleRowSummary = New instat.UcrPanel()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.ucrChkIgnoreMissingValues = New instat.ucrCheck()
        Me.ucrSelectorForRowSummaries = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForRowSummaries = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlRowSummaries = New instat.UcrPanel()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.grpStatistic.SuspendLayout()
        Me.grpMultipleRowSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariables.Location = New System.Drawing.Point(276, 73)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 5
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'grpStatistic
        '
        Me.grpStatistic.Controls.Add(Me.lblTrim)
        Me.grpStatistic.Controls.Add(Me.rdoMore)
        Me.grpStatistic.Controls.Add(Me.rdoMinimum)
        Me.grpStatistic.Controls.Add(Me.rdoMaximum)
        Me.grpStatistic.Controls.Add(Me.rdoCount)
        Me.grpStatistic.Controls.Add(Me.rdoMean)
        Me.grpStatistic.Controls.Add(Me.rdoStandardDeviation)
        Me.grpStatistic.Controls.Add(Me.rdoNumberMissing)
        Me.grpStatistic.Controls.Add(Me.rdoMedian)
        Me.grpStatistic.Controls.Add(Me.rdoSum)
        Me.grpStatistic.Controls.Add(Me.lblProp)
        Me.grpStatistic.Controls.Add(Me.ucrInputUserDefined)
        Me.grpStatistic.Controls.Add(Me.ucrNudProp)
        Me.grpStatistic.Controls.Add(Me.ucrNudTrim)
        Me.grpStatistic.Controls.Add(Me.ucrPnlStatistics)
        Me.grpStatistic.Location = New System.Drawing.Point(10, 238)
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.Size = New System.Drawing.Size(435, 88)
        Me.grpStatistic.TabIndex = 8
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        Me.grpStatistic.Text = "Row Statistic"
        '
        'lblTrim
        '
        Me.lblTrim.AutoSize = True
        Me.lblTrim.Location = New System.Drawing.Point(353, 66)
        Me.lblTrim.Name = "lblTrim"
        Me.lblTrim.Size = New System.Drawing.Size(30, 13)
        Me.lblTrim.TabIndex = 15
        Me.lblTrim.Text = "Trim:"
        '
        'rdoMore
        '
        Me.rdoMore.AutoSize = True
        Me.rdoMore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMore.Location = New System.Drawing.Point(198, 63)
        Me.rdoMore.Name = "rdoMore"
        Me.rdoMore.Size = New System.Drawing.Size(49, 17)
        Me.rdoMore.TabIndex = 9
        Me.rdoMore.TabStop = True
        Me.rdoMore.Tag = "More"
        Me.rdoMore.Text = "More"
        Me.rdoMore.UseVisualStyleBackColor = True
        '
        'rdoMinimum
        '
        Me.rdoMinimum.AutoSize = True
        Me.rdoMinimum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMinimum.Location = New System.Drawing.Point(6, 42)
        Me.rdoMinimum.Name = "rdoMinimum"
        Me.rdoMinimum.Size = New System.Drawing.Size(66, 17)
        Me.rdoMinimum.TabIndex = 7
        Me.rdoMinimum.TabStop = True
        Me.rdoMinimum.Tag = "Minimum"
        Me.rdoMinimum.Text = "Minimum"
        Me.rdoMinimum.UseVisualStyleBackColor = True
        '
        'rdoMaximum
        '
        Me.rdoMaximum.AutoSize = True
        Me.rdoMaximum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMaximum.Location = New System.Drawing.Point(91, 42)
        Me.rdoMaximum.Name = "rdoMaximum"
        Me.rdoMaximum.Size = New System.Drawing.Size(69, 17)
        Me.rdoMaximum.TabIndex = 8
        Me.rdoMaximum.TabStop = True
        Me.rdoMaximum.Tag = "Maximum"
        Me.rdoMaximum.Text = "Maximum"
        Me.rdoMaximum.UseVisualStyleBackColor = True
        '
        'rdoCount
        '
        Me.rdoCount.AutoSize = True
        Me.rdoCount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCount.Location = New System.Drawing.Point(6, 63)
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.Size = New System.Drawing.Size(53, 17)
        Me.rdoCount.TabIndex = 4
        Me.rdoCount.TabStop = True
        Me.rdoCount.Tag = "Count"
        Me.rdoCount.Text = "Count"
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoMean
        '
        Me.rdoMean.AutoSize = True
        Me.rdoMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMean.Location = New System.Drawing.Point(6, 21)
        Me.rdoMean.Name = "rdoMean"
        Me.rdoMean.Size = New System.Drawing.Size(52, 17)
        Me.rdoMean.TabIndex = 1
        Me.rdoMean.TabStop = True
        Me.rdoMean.Tag = "Mean"
        Me.rdoMean.Text = "Mean"
        Me.rdoMean.UseVisualStyleBackColor = True
        '
        'rdoStandardDeviation
        '
        Me.rdoStandardDeviation.AutoSize = True
        Me.rdoStandardDeviation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStandardDeviation.Location = New System.Drawing.Point(198, 19)
        Me.rdoStandardDeviation.Name = "rdoStandardDeviation"
        Me.rdoStandardDeviation.Size = New System.Drawing.Size(116, 17)
        Me.rdoStandardDeviation.TabIndex = 5
        Me.rdoStandardDeviation.TabStop = True
        Me.rdoStandardDeviation.Tag = "Standard_Deviation"
        Me.rdoStandardDeviation.Text = "Standard Deviation"
        Me.rdoStandardDeviation.UseVisualStyleBackColor = True
        '
        'rdoNumberMissing
        '
        Me.rdoNumberMissing.AutoSize = True
        Me.rdoNumberMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumberMissing.Location = New System.Drawing.Point(91, 63)
        Me.rdoNumberMissing.Name = "rdoNumberMissing"
        Me.rdoNumberMissing.Size = New System.Drawing.Size(100, 17)
        Me.rdoNumberMissing.TabIndex = 6
        Me.rdoNumberMissing.TabStop = True
        Me.rdoNumberMissing.Tag = "Number_Missing"
        Me.rdoNumberMissing.Text = "Number Missing"
        Me.rdoNumberMissing.UseVisualStyleBackColor = True
        '
        'rdoMedian
        '
        Me.rdoMedian.AutoSize = True
        Me.rdoMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMedian.Location = New System.Drawing.Point(198, 42)
        Me.rdoMedian.Name = "rdoMedian"
        Me.rdoMedian.Size = New System.Drawing.Size(60, 17)
        Me.rdoMedian.TabIndex = 2
        Me.rdoMedian.TabStop = True
        Me.rdoMedian.Tag = "Median"
        Me.rdoMedian.Text = "Median"
        Me.rdoMedian.UseVisualStyleBackColor = True
        '
        'rdoSum
        '
        Me.rdoSum.AutoSize = True
        Me.rdoSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSum.Location = New System.Drawing.Point(91, 21)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(46, 17)
        Me.rdoSum.TabIndex = 3
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'lblProp
        '
        Me.lblProp.AutoSize = True
        Me.lblProp.Location = New System.Drawing.Point(353, 66)
        Me.lblProp.Name = "lblProp"
        Me.lblProp.Size = New System.Drawing.Size(32, 13)
        Me.lblProp.TabIndex = 13
        Me.lblProp.Text = "Prop:"
        '
        'ucrInputUserDefined
        '
        Me.ucrInputUserDefined.AddQuotesIfUnrecognised = True
        Me.ucrInputUserDefined.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUserDefined.GetSetSelectedIndex = -1
        Me.ucrInputUserDefined.IsReadOnly = False
        Me.ucrInputUserDefined.Location = New System.Drawing.Point(247, 61)
        Me.ucrInputUserDefined.Name = "ucrInputUserDefined"
        Me.ucrInputUserDefined.Size = New System.Drawing.Size(104, 25)
        Me.ucrInputUserDefined.TabIndex = 10
        '
        'ucrNudProp
        '
        Me.ucrNudProp.AutoSize = True
        Me.ucrNudProp.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudProp.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudProp.Location = New System.Drawing.Point(385, 62)
        Me.ucrNudProp.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudProp.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudProp.Name = "ucrNudProp"
        Me.ucrNudProp.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudProp.TabIndex = 14
        Me.ucrNudProp.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTrim
        '
        Me.ucrNudTrim.AutoSize = True
        Me.ucrNudTrim.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrim.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTrim.Location = New System.Drawing.Point(387, 62)
        Me.ucrNudTrim.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTrim.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTrim.Name = "ucrNudTrim"
        Me.ucrNudTrim.Size = New System.Drawing.Size(42, 20)
        Me.ucrNudTrim.TabIndex = 13
        Me.ucrNudTrim.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlStatistics
        '
        Me.ucrPnlStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStatistics.Location = New System.Drawing.Point(4, 14)
        Me.ucrPnlStatistics.Name = "ucrPnlStatistics"
        Me.ucrPnlStatistics.Size = New System.Drawing.Size(425, 68)
        Me.ucrPnlStatistics.TabIndex = 0
        '
        'grpMultipleRowSummary
        '
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputTiesMethod)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputType)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrChkType)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrChkTiesMethod)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputProbability)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowRanks)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowQuantile)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowRange)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrPnlMultipleRowSummary)
        Me.grpMultipleRowSummary.Location = New System.Drawing.Point(10, 238)
        Me.grpMultipleRowSummary.Name = "grpMultipleRowSummary"
        Me.grpMultipleRowSummary.Size = New System.Drawing.Size(385, 84)
        Me.grpMultipleRowSummary.TabIndex = 11
        Me.grpMultipleRowSummary.TabStop = False
        Me.grpMultipleRowSummary.Tag = "Statistic"
        Me.grpMultipleRowSummary.Text = "Row Statistic"
        '
        'ucrInputTiesMethod
        '
        Me.ucrInputTiesMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputTiesMethod.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTiesMethod.GetSetSelectedIndex = -1
        Me.ucrInputTiesMethod.IsReadOnly = False
        Me.ucrInputTiesMethod.Location = New System.Drawing.Point(163, 21)
        Me.ucrInputTiesMethod.Name = "ucrInputTiesMethod"
        Me.ucrInputTiesMethod.Size = New System.Drawing.Size(98, 21)
        Me.ucrInputTiesMethod.TabIndex = 15
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(277, 48)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(35, 24)
        Me.ucrInputType.TabIndex = 14
        '
        'ucrChkType
        '
        Me.ucrChkType.AutoSize = True
        Me.ucrChkType.Checked = False
        Me.ucrChkType.Location = New System.Drawing.Point(222, 49)
        Me.ucrChkType.Name = "ucrChkType"
        Me.ucrChkType.Size = New System.Drawing.Size(53, 23)
        Me.ucrChkType.TabIndex = 13
        '
        'ucrChkTiesMethod
        '
        Me.ucrChkTiesMethod.AutoSize = True
        Me.ucrChkTiesMethod.Checked = False
        Me.ucrChkTiesMethod.Location = New System.Drawing.Point(73, 22)
        Me.ucrChkTiesMethod.Name = "ucrChkTiesMethod"
        Me.ucrChkTiesMethod.Size = New System.Drawing.Size(86, 23)
        Me.ucrChkTiesMethod.TabIndex = 12
        '
        'ucrInputProbability
        '
        Me.ucrInputProbability.AddQuotesIfUnrecognised = True
        Me.ucrInputProbability.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputProbability.GetSetSelectedIndex = -1
        Me.ucrInputProbability.IsReadOnly = False
        Me.ucrInputProbability.Location = New System.Drawing.Point(73, 47)
        Me.ucrInputProbability.Name = "ucrInputProbability"
        Me.ucrInputProbability.Size = New System.Drawing.Size(140, 21)
        Me.ucrInputProbability.TabIndex = 10
        '
        'rdoRowRanks
        '
        Me.rdoRowRanks.AutoSize = True
        Me.rdoRowRanks.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowRanks.Location = New System.Drawing.Point(6, 21)
        Me.rdoRowRanks.Name = "rdoRowRanks"
        Me.rdoRowRanks.Size = New System.Drawing.Size(56, 17)
        Me.rdoRowRanks.TabIndex = 1
        Me.rdoRowRanks.TabStop = True
        Me.rdoRowRanks.Tag = "Ranks"
        Me.rdoRowRanks.Text = "Ranks"
        Me.rdoRowRanks.UseVisualStyleBackColor = True
        '
        'rdoRowQuantile
        '
        Me.rdoRowQuantile.AutoSize = True
        Me.rdoRowQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowQuantile.Location = New System.Drawing.Point(6, 49)
        Me.rdoRowQuantile.Name = "rdoRowQuantile"
        Me.rdoRowQuantile.Size = New System.Drawing.Size(69, 17)
        Me.rdoRowQuantile.TabIndex = 5
        Me.rdoRowQuantile.TabStop = True
        Me.rdoRowQuantile.Tag = "Quantile"
        Me.rdoRowQuantile.Text = "Quantiles"
        Me.rdoRowQuantile.UseVisualStyleBackColor = True
        '
        'rdoRowRange
        '
        Me.rdoRowRange.AutoSize = True
        Me.rdoRowRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowRange.Location = New System.Drawing.Point(280, 21)
        Me.rdoRowRange.Name = "rdoRowRange"
        Me.rdoRowRange.Size = New System.Drawing.Size(57, 17)
        Me.rdoRowRange.TabIndex = 3
        Me.rdoRowRange.TabStop = True
        Me.rdoRowRange.Tag = "Range"
        Me.rdoRowRange.Text = "Range"
        Me.rdoRowRange.UseVisualStyleBackColor = True
        '
        'ucrPnlMultipleRowSummary
        '
        Me.ucrPnlMultipleRowSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMultipleRowSummary.Location = New System.Drawing.Point(4, 14)
        Me.ucrPnlMultipleRowSummary.Name = "ucrPnlMultipleRowSummary"
        Me.ucrPnlMultipleRowSummary.Size = New System.Drawing.Size(365, 64)
        Me.ucrPnlMultipleRowSummary.TabIndex = 0
        '
        'rdoSingle
        '
        Me.rdoSingle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSingle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatAppearance.BorderSize = 2
        Me.rdoSingle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(101, 8)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(117, 28)
        Me.rdoSingle.TabIndex = 2
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Tag = ""
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingle.UseVisualStyleBackColor = False
        '
        'rdoMultiple
        '
        Me.rdoMultiple.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultiple.BackColor = System.Drawing.SystemColors.Control
        Me.rdoMultiple.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatAppearance.BorderSize = 2
        Me.rdoMultiple.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(216, 8)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(117, 28)
        Me.rdoMultiple.TabIndex = 3
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'ucrChkIgnoreMissingValues
        '
        Me.ucrChkIgnoreMissingValues.AutoSize = True
        Me.ucrChkIgnoreMissingValues.Checked = False
        Me.ucrChkIgnoreMissingValues.Location = New System.Drawing.Point(276, 199)
        Me.ucrChkIgnoreMissingValues.Name = "ucrChkIgnoreMissingValues"
        Me.ucrChkIgnoreMissingValues.Size = New System.Drawing.Size(140, 23)
        Me.ucrChkIgnoreMissingValues.TabIndex = 7
        '
        'ucrSelectorForRowSummaries
        '
        Me.ucrSelectorForRowSummaries.AutoSize = True
        Me.ucrSelectorForRowSummaries.bDropUnusedFilterLevels = False
        Me.ucrSelectorForRowSummaries.bShowHiddenColumns = False
        Me.ucrSelectorForRowSummaries.bUseCurrentFilter = True
        Me.ucrSelectorForRowSummaries.Location = New System.Drawing.Point(12, 45)
        Me.ucrSelectorForRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRowSummaries.Name = "ucrSelectorForRowSummaries"
        Me.ucrSelectorForRowSummaries.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRowSummaries.TabIndex = 4
        '
        'ucrReceiverForRowSummaries
        '
        Me.ucrReceiverForRowSummaries.AutoSize = True
        Me.ucrReceiverForRowSummaries.frmParent = Me
        Me.ucrReceiverForRowSummaries.Location = New System.Drawing.Point(276, 89)
        Me.ucrReceiverForRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForRowSummaries.Name = "ucrReceiverForRowSummaries"
        Me.ucrReceiverForRowSummaries.Selector = Nothing
        Me.ucrReceiverForRowSummaries.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForRowSummaries.strNcFilePath = ""
        Me.ucrReceiverForRowSummaries.TabIndex = 6
        Me.ucrReceiverForRowSummaries.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(12, 361)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrPnlRowSummaries
        '
        Me.ucrPnlRowSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRowSummaries.Location = New System.Drawing.Point(93, 3)
        Me.ucrPnlRowSummaries.Name = "ucrPnlRowSummaries"
        Me.ucrPnlRowSummaries.Size = New System.Drawing.Size(254, 39)
        Me.ucrPnlRowSummaries.TabIndex = 1
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(13, 334)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(391, 22)
        Me.ucrSaveNewDataFrame.TabIndex = 12
        '
        'dlgRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(453, 426)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.ucrChkIgnoreMissingValues)
        Me.Controls.Add(Me.ucrSelectorForRowSummaries)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverForRowSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlRowSummaries)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.grpMultipleRowSummary)
        Me.Controls.Add(Me.grpStatistic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRowSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Row_Summaries"
        Me.Text = "Row Summaries"
        Me.grpStatistic.ResumeLayout(False)
        Me.grpStatistic.PerformLayout()
        Me.grpMultipleRowSummary.ResumeLayout(False)
        Me.grpMultipleRowSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverForRowSummaries As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariables As Label
    Friend WithEvents ucrSelectorForRowSummaries As ucrSelectorByDataFrameAddRemove
    Friend WithEvents grpStatistic As GroupBox
    Friend WithEvents rdoMinimum As RadioButton
    Friend WithEvents rdoMaximum As RadioButton
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoMean As RadioButton
    Friend WithEvents rdoStandardDeviation As RadioButton
    Friend WithEvents rdoNumberMissing As RadioButton
    Friend WithEvents rdoMedian As RadioButton
    Friend WithEvents rdoSum As RadioButton
    Friend WithEvents ucrPnlStatistics As UcrPanel
    Friend WithEvents ucrChkIgnoreMissingValues As ucrCheck
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlRowSummaries As UcrPanel
    Friend WithEvents rdoMore As RadioButton
    Friend WithEvents ucrInputUserDefined As ucrInputComboBox
    Friend WithEvents grpMultipleRowSummary As GroupBox
    Friend WithEvents ucrInputProbability As ucrInputComboBox
    Friend WithEvents rdoRowRanks As RadioButton
    Friend WithEvents rdoRowQuantile As RadioButton
    Friend WithEvents rdoRowRange As RadioButton
    Friend WithEvents ucrPnlMultipleRowSummary As UcrPanel
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents ucrInputTiesMethod As ucrInputComboBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrChkType As ucrCheck
    Friend WithEvents ucrChkTiesMethod As ucrCheck
    Friend WithEvents lblProp As Label
    Friend WithEvents ucrNudTrim As ucrNud
    Friend WithEvents lblTrim As Label
    Friend WithEvents ucrNudProp As ucrNud
End Class
