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
        Me.rdoMore = New System.Windows.Forms.RadioButton()
        Me.rdoMinimum = New System.Windows.Forms.RadioButton()
        Me.rdoMaximum = New System.Windows.Forms.RadioButton()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoMean = New System.Windows.Forms.RadioButton()
        Me.rdoStandardDeviation = New System.Windows.Forms.RadioButton()
        Me.rdoNumberMissing = New System.Windows.Forms.RadioButton()
        Me.rdoMedian = New System.Windows.Forms.RadioButton()
        Me.rdoSum = New System.Windows.Forms.RadioButton()
        Me.grpMultipleRowSummary = New System.Windows.Forms.GroupBox()
        Me.rdoRowRanks = New System.Windows.Forms.RadioButton()
        Me.rdoRowQuantile = New System.Windows.Forms.RadioButton()
        Me.rdoRowRange = New System.Windows.Forms.RadioButton()
        Me.lblSummaries = New System.Windows.Forms.Label()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.lblSelectedVariablesMultiple = New System.Windows.Forms.Label()
        Me.ucrReceiverForMultipleRowSummaries = New instat.ucrReceiverMultiple()
        Me.ucrSaveNewDataFrame = New instat.ucrSave()
        Me.ucrNewDataFrameName = New instat.ucrSave()
        Me.ucrChkIgnoreMissingValues = New instat.ucrCheck()
        Me.ucrSelectorForRowSummaries = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForRowSummaries = New instat.ucrReceiverMultiple()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlRowSummaries = New instat.UcrPanel()
        Me.ucrInputRowRanks = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.ucrChkType = New instat.ucrCheck()
        Me.ucrChkRowRanks = New instat.ucrCheck()
        Me.ucrInputProbability = New instat.ucrInputComboBox()
        Me.ucrPnlMultipleRowSummary = New instat.UcrPanel()
        Me.ucrInputUserDefined = New instat.ucrInputComboBox()
        Me.ucrPnlStatistics = New instat.UcrPanel()
        Me.grpStatistic.SuspendLayout()
        Me.grpMultipleRowSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectedVariables
        '
        Me.lblSelectedVariables.AutoSize = True
        Me.lblSelectedVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariables.Location = New System.Drawing.Point(250, 79)
        Me.lblSelectedVariables.Name = "lblSelectedVariables"
        Me.lblSelectedVariables.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariables.TabIndex = 5
        Me.lblSelectedVariables.Tag = "Selected_Variables"
        Me.lblSelectedVariables.Text = "Selected Variables:"
        '
        'grpStatistic
        '
        Me.grpStatistic.Controls.Add(Me.ucrInputUserDefined)
        Me.grpStatistic.Controls.Add(Me.rdoMore)
        Me.grpStatistic.Controls.Add(Me.rdoMinimum)
        Me.grpStatistic.Controls.Add(Me.rdoMaximum)
        Me.grpStatistic.Controls.Add(Me.rdoCount)
        Me.grpStatistic.Controls.Add(Me.rdoMean)
        Me.grpStatistic.Controls.Add(Me.rdoStandardDeviation)
        Me.grpStatistic.Controls.Add(Me.rdoNumberMissing)
        Me.grpStatistic.Controls.Add(Me.rdoMedian)
        Me.grpStatistic.Controls.Add(Me.rdoSum)
        Me.grpStatistic.Controls.Add(Me.ucrPnlStatistics)
        Me.grpStatistic.Location = New System.Drawing.Point(10, 238)
        Me.grpStatistic.Name = "grpStatistic"
        Me.grpStatistic.Size = New System.Drawing.Size(454, 71)
        Me.grpStatistic.TabIndex = 8
        Me.grpStatistic.TabStop = False
        Me.grpStatistic.Tag = "Statistic"
        Me.grpStatistic.Text = "Row Statistic"
        '
        'rdoMore
        '
        Me.rdoMore.AutoSize = True
        Me.rdoMore.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMore.Location = New System.Drawing.Point(262, 45)
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
        Me.rdoMinimum.Location = New System.Drawing.Point(262, 21)
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
        Me.rdoMaximum.Location = New System.Drawing.Point(351, 22)
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
        Me.rdoCount.Location = New System.Drawing.Point(73, 44)
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
        Me.rdoStandardDeviation.Location = New System.Drawing.Point(138, 22)
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
        Me.rdoNumberMissing.Location = New System.Drawing.Point(139, 43)
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
        Me.rdoMedian.Location = New System.Drawing.Point(6, 43)
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
        Me.rdoSum.Location = New System.Drawing.Point(72, 21)
        Me.rdoSum.Name = "rdoSum"
        Me.rdoSum.Size = New System.Drawing.Size(46, 17)
        Me.rdoSum.TabIndex = 3
        Me.rdoSum.TabStop = True
        Me.rdoSum.Tag = "Sum"
        Me.rdoSum.Text = "Sum"
        Me.rdoSum.UseVisualStyleBackColor = True
        '
        'grpMultipleRowSummary
        '
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputRowRanks)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputType)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrChkType)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrChkRowRanks)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrInputProbability)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowRanks)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowQuantile)
        Me.grpMultipleRowSummary.Controls.Add(Me.rdoRowRange)
        Me.grpMultipleRowSummary.Controls.Add(Me.ucrPnlMultipleRowSummary)
        Me.grpMultipleRowSummary.Location = New System.Drawing.Point(10, 236)
        Me.grpMultipleRowSummary.Name = "grpMultipleRowSummary"
        Me.grpMultipleRowSummary.Size = New System.Drawing.Size(328, 84)
        Me.grpMultipleRowSummary.TabIndex = 11
        Me.grpMultipleRowSummary.TabStop = False
        Me.grpMultipleRowSummary.Tag = "Statistic"
        Me.grpMultipleRowSummary.Text = "Row Statistic"
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
        Me.rdoRowQuantile.Location = New System.Drawing.Point(6, 48)
        Me.rdoRowQuantile.Name = "rdoRowQuantile"
        Me.rdoRowQuantile.Size = New System.Drawing.Size(64, 17)
        Me.rdoRowQuantile.TabIndex = 5
        Me.rdoRowQuantile.TabStop = True
        Me.rdoRowQuantile.Tag = "Quantile"
        Me.rdoRowQuantile.Text = "Quantile"
        Me.rdoRowQuantile.UseVisualStyleBackColor = True
        '
        'rdoRowRange
        '
        Me.rdoRowRange.AutoSize = True
        Me.rdoRowRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowRange.Location = New System.Drawing.Point(199, 21)
        Me.rdoRowRange.Name = "rdoRowRange"
        Me.rdoRowRange.Size = New System.Drawing.Size(57, 17)
        Me.rdoRowRange.TabIndex = 3
        Me.rdoRowRange.TabStop = True
        Me.rdoRowRange.Tag = "Range"
        Me.rdoRowRange.Text = "Range"
        Me.rdoRowRange.UseVisualStyleBackColor = True
        '
        'lblSummaries
        '
        Me.lblSummaries.AutoSize = True
        Me.lblSummaries.Location = New System.Drawing.Point(57, 16)
        Me.lblSummaries.Name = "lblSummaries"
        Me.lblSummaries.Size = New System.Drawing.Size(61, 13)
        Me.lblSummaries.TabIndex = 0
        Me.lblSummaries.Text = "Summaries:"
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
        Me.rdoSingle.Location = New System.Drawing.Point(119, 8)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(131, 28)
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
        Me.rdoMultiple.Location = New System.Drawing.Point(248, 8)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(131, 28)
        Me.rdoMultiple.TabIndex = 3
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Tag = ""
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMultiple.UseVisualStyleBackColor = False
        '
        'lblSelectedVariablesMultiple
        '
        Me.lblSelectedVariablesMultiple.AutoSize = True
        Me.lblSelectedVariablesMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectedVariablesMultiple.Location = New System.Drawing.Point(250, 79)
        Me.lblSelectedVariablesMultiple.Name = "lblSelectedVariablesMultiple"
        Me.lblSelectedVariablesMultiple.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedVariablesMultiple.TabIndex = 14
        Me.lblSelectedVariablesMultiple.Tag = "Selected_Variables"
        Me.lblSelectedVariablesMultiple.Text = "Selected Variables:"
        '
        'ucrReceiverForMultipleRowSummaries
        '
        Me.ucrReceiverForMultipleRowSummaries.AutoSize = True
        Me.ucrReceiverForMultipleRowSummaries.frmParent = Me
        Me.ucrReceiverForMultipleRowSummaries.Location = New System.Drawing.Point(250, 95)
        Me.ucrReceiverForMultipleRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForMultipleRowSummaries.Name = "ucrReceiverForMultipleRowSummaries"
        Me.ucrReceiverForMultipleRowSummaries.Selector = Nothing
        Me.ucrReceiverForMultipleRowSummaries.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverForMultipleRowSummaries.strNcFilePath = ""
        Me.ucrReceiverForMultipleRowSummaries.TabIndex = 13
        Me.ucrReceiverForMultipleRowSummaries.ucrSelector = Nothing
        '
        'ucrSaveNewDataFrame
        '
        Me.ucrSaveNewDataFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataFrame.Location = New System.Drawing.Point(10, 331)
        Me.ucrSaveNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataFrame.Name = "ucrSaveNewDataFrame"
        Me.ucrSaveNewDataFrame.Size = New System.Drawing.Size(391, 22)
        Me.ucrSaveNewDataFrame.TabIndex = 12
        '
        'ucrNewDataFrameName
        '
        Me.ucrNewDataFrameName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewDataFrameName.Location = New System.Drawing.Point(10, 331)
        Me.ucrNewDataFrameName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewDataFrameName.Name = "ucrNewDataFrameName"
        Me.ucrNewDataFrameName.Size = New System.Drawing.Size(391, 22)
        Me.ucrNewDataFrameName.TabIndex = 11
        '
        'ucrChkIgnoreMissingValues
        '
        Me.ucrChkIgnoreMissingValues.AutoSize = True
        Me.ucrChkIgnoreMissingValues.Checked = False
        Me.ucrChkIgnoreMissingValues.Location = New System.Drawing.Point(250, 205)
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
        Me.ucrSelectorForRowSummaries.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorForRowSummaries.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForRowSummaries.Name = "ucrSelectorForRowSummaries"
        Me.ucrSelectorForRowSummaries.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForRowSummaries.TabIndex = 4
        '
        'ucrReceiverForRowSummaries
        '
        Me.ucrReceiverForRowSummaries.AutoSize = True
        Me.ucrReceiverForRowSummaries.frmParent = Me
        Me.ucrReceiverForRowSummaries.Location = New System.Drawing.Point(250, 95)
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
        Me.ucrBase.Location = New System.Drawing.Point(10, 359)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 10
        '
        'ucrPnlRowSummaries
        '
        Me.ucrPnlRowSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRowSummaries.Location = New System.Drawing.Point(119, 3)
        Me.ucrPnlRowSummaries.Name = "ucrPnlRowSummaries"
        Me.ucrPnlRowSummaries.Size = New System.Drawing.Size(265, 39)
        Me.ucrPnlRowSummaries.TabIndex = 1
        '
        'ucrInputRowRanks
        '
        Me.ucrInputRowRanks.AddQuotesIfUnrecognised = True
        Me.ucrInputRowRanks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputRowRanks.GetSetSelectedIndex = -1
        Me.ucrInputRowRanks.IsReadOnly = False
        Me.ucrInputRowRanks.Location = New System.Drawing.Point(109, 19)
        Me.ucrInputRowRanks.Name = "ucrInputRowRanks"
        Me.ucrInputRowRanks.Size = New System.Drawing.Size(66, 21)
        Me.ucrInputRowRanks.TabIndex = 15
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(212, 47)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputType.TabIndex = 14
        '
        'ucrChkType
        '
        Me.ucrChkType.AutoSize = True
        Me.ucrChkType.Checked = False
        Me.ucrChkType.Location = New System.Drawing.Point(157, 48)
        Me.ucrChkType.Name = "ucrChkType"
        Me.ucrChkType.Size = New System.Drawing.Size(82, 23)
        Me.ucrChkType.TabIndex = 13
        '
        'ucrChkRowRanks
        '
        Me.ucrChkRowRanks.AutoSize = True
        Me.ucrChkRowRanks.Checked = False
        Me.ucrChkRowRanks.Location = New System.Drawing.Point(66, 21)
        Me.ucrChkRowRanks.Name = "ucrChkRowRanks"
        Me.ucrChkRowRanks.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkRowRanks.TabIndex = 12
        '
        'ucrInputProbability
        '
        Me.ucrInputProbability.AddQuotesIfUnrecognised = True
        Me.ucrInputProbability.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputProbability.GetSetSelectedIndex = -1
        Me.ucrInputProbability.IsReadOnly = False
        Me.ucrInputProbability.Location = New System.Drawing.Point(73, 47)
        Me.ucrInputProbability.Name = "ucrInputProbability"
        Me.ucrInputProbability.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputProbability.TabIndex = 10
        '
        'ucrPnlMultipleRowSummary
        '
        Me.ucrPnlMultipleRowSummary.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMultipleRowSummary.Location = New System.Drawing.Point(4, 14)
        Me.ucrPnlMultipleRowSummary.Name = "ucrPnlMultipleRowSummary"
        Me.ucrPnlMultipleRowSummary.Size = New System.Drawing.Size(307, 57)
        Me.ucrPnlMultipleRowSummary.TabIndex = 0
        '
        'ucrInputUserDefined
        '
        Me.ucrInputUserDefined.AddQuotesIfUnrecognised = True
        Me.ucrInputUserDefined.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUserDefined.GetSetSelectedIndex = -1
        Me.ucrInputUserDefined.IsReadOnly = False
        Me.ucrInputUserDefined.Location = New System.Drawing.Point(317, 41)
        Me.ucrInputUserDefined.Name = "ucrInputUserDefined"
        Me.ucrInputUserDefined.Size = New System.Drawing.Size(125, 25)
        Me.ucrInputUserDefined.TabIndex = 10
        '
        'ucrPnlStatistics
        '
        Me.ucrPnlStatistics.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStatistics.Location = New System.Drawing.Point(4, 14)
        Me.ucrPnlStatistics.Name = "ucrPnlStatistics"
        Me.ucrPnlStatistics.Size = New System.Drawing.Size(444, 52)
        Me.ucrPnlStatistics.TabIndex = 0
        '
        'dlgRowSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(470, 433)
        Me.Controls.Add(Me.lblSelectedVariablesMultiple)
        Me.Controls.Add(Me.ucrReceiverForMultipleRowSummaries)
        Me.Controls.Add(Me.ucrSaveNewDataFrame)
        Me.Controls.Add(Me.ucrNewDataFrameName)
        Me.Controls.Add(Me.rdoMultiple)
        Me.Controls.Add(Me.rdoSingle)
        Me.Controls.Add(Me.lblSummaries)
        Me.Controls.Add(Me.ucrChkIgnoreMissingValues)
        Me.Controls.Add(Me.ucrSelectorForRowSummaries)
        Me.Controls.Add(Me.lblSelectedVariables)
        Me.Controls.Add(Me.ucrReceiverForRowSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlRowSummaries)
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
    Friend WithEvents lblSummaries As Label
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlRowSummaries As UcrPanel
    Friend WithEvents rdoMore As RadioButton
    Friend WithEvents ucrInputUserDefined As ucrInputComboBox
    Friend WithEvents ucrNewDataFrameName As ucrSave
    Friend WithEvents grpMultipleRowSummary As GroupBox
    Friend WithEvents ucrInputProbability As ucrInputComboBox
    Friend WithEvents rdoRowRanks As RadioButton
    Friend WithEvents rdoRowQuantile As RadioButton
    Friend WithEvents rdoRowRange As RadioButton
    Friend WithEvents ucrPnlMultipleRowSummary As UcrPanel
    Friend WithEvents ucrSaveNewDataFrame As ucrSave
    Friend WithEvents ucrReceiverForMultipleRowSummaries As ucrReceiverMultiple
    Friend WithEvents lblSelectedVariablesMultiple As Label
    Friend WithEvents ucrInputRowRanks As ucrInputComboBox
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrChkType As ucrCheck
    Friend WithEvents ucrChkRowRanks As ucrCheck
End Class
