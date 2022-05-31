﻿' R- Instat
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
Partial Class dlgSummaryTables
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
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.grpMargin = New System.Windows.Forms.GroupBox()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.rdoOuter = New System.Windows.Forms.RadioButton()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.cmdFormatTable = New System.Windows.Forms.Button()
        Me.rdoFrequencyTable = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryTable = New System.Windows.Forms.RadioButton()
        Me.grpPercentages = New System.Windows.Forms.GroupBox()
        Me.lblFactorsAsPercentage = New System.Windows.Forms.Label()
        Me.lblFrequencyMarginName = New System.Windows.Forms.Label()
        Me.ucrChkFrequencyDisplayMargins = New instat.ucrCheck()
        Me.ucrReceiverMultiplePercentages = New instat.ucrReceiverMultiple()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.ucrPnlSummaryFrequencyTables = New instat.UcrPanel()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrNudColumnFactors = New instat.ucrNud()
        Me.ucrChkDisplaySummaryVariablesAsRow = New instat.ucrCheck()
        Me.ucrChkDisplayVariablesAsRows = New instat.ucrCheck()
        Me.ucrChkDisplaySummariesAsRow = New instat.ucrCheck()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSummaryCols = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlMargin = New instat.UcrPanel()
        Me.ucrInputFrequencyMarginName = New instat.ucrInputTextBox()
        Me.grpDisplay.SuspendLayout()
        Me.grpMargin.SuspendLayout()
        Me.grpPercentages.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(286, 43)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(48, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors :"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(286, 280)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(104, 23)
        Me.cmdSummaries.TabIndex = 13
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigFigs.Location = New System.Drawing.Point(8, 26)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 4
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrNudColumnFactors)
        Me.grpDisplay.Controls.Add(Me.lblColumnFactors)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplaySummaryVariablesAsRow)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplayVariablesAsRows)
        Me.grpDisplay.Controls.Add(Me.ucrChkDisplaySummariesAsRow)
        Me.grpDisplay.Controls.Add(Me.ucrNudSigFigs)
        Me.grpDisplay.Controls.Add(Me.lblSigFigs)
        Me.grpDisplay.Location = New System.Drawing.Point(10, 353)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(259, 126)
        Me.grpDisplay.TabIndex = 11
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display"
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnFactors.Location = New System.Drawing.Point(8, 52)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(86, 13)
        Me.lblColumnFactors.TabIndex = 18
        Me.lblColumnFactors.Tag = ""
        Me.lblColumnFactors.Text = "Column Factors :"
        '
        'grpMargin
        '
        Me.grpMargin.Controls.Add(Me.rdoBoth)
        Me.grpMargin.Controls.Add(Me.rdoSummary)
        Me.grpMargin.Controls.Add(Me.rdoOuter)
        Me.grpMargin.Controls.Add(Me.ucrPnlMargin)
        Me.grpMargin.Location = New System.Drawing.Point(10, 311)
        Me.grpMargin.Name = "grpMargin"
        Me.grpMargin.Size = New System.Drawing.Size(203, 37)
        Me.grpMargin.TabIndex = 13
        Me.grpMargin.TabStop = False
        '
        'rdoBoth
        '
        Me.rdoBoth.AutoSize = True
        Me.rdoBoth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoth.Location = New System.Drawing.Point(140, 17)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(47, 17)
        Me.rdoBoth.TabIndex = 16
        Me.rdoBoth.TabStop = True
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        Me.rdoSummary.AutoSize = True
        Me.rdoSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummary.Location = New System.Drawing.Point(67, 17)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(68, 17)
        Me.rdoSummary.TabIndex = 16
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Text = "Summary"
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'rdoOuter
        '
        Me.rdoOuter.AutoSize = True
        Me.rdoOuter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOuter.Location = New System.Drawing.Point(10, 17)
        Me.rdoOuter.Name = "rdoOuter"
        Me.rdoOuter.Size = New System.Drawing.Size(51, 17)
        Me.rdoOuter.TabIndex = 15
        Me.rdoOuter.TabStop = True
        Me.rdoOuter.Text = "Outer"
        Me.rdoOuter.UseVisualStyleBackColor = True
        '
        'lblMarginName
        '
        Me.lblMarginName.AutoSize = True
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(159, 287)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(41, 13)
        Me.lblMarginName.TabIndex = 15
        Me.lblMarginName.Text = "Name :"
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariables.Location = New System.Drawing.Point(285, 162)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(56, 13)
        Me.lblVariables.TabIndex = 17
        Me.lblVariables.Tag = ""
        Me.lblVariables.Text = "Variables :"
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(286, 464)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(104, 23)
        Me.cmdFormatTable.TabIndex = 19
        Me.cmdFormatTable.Text = "Format Table..."
        Me.cmdFormatTable.UseVisualStyleBackColor = True
        '
        'rdoFrequencyTable
        '
        Me.rdoFrequencyTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrequencyTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyTable.FlatAppearance.BorderSize = 2
        Me.rdoFrequencyTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrequencyTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequencyTable.Location = New System.Drawing.Point(107, 7)
        Me.rdoFrequencyTable.Name = "rdoFrequencyTable"
        Me.rdoFrequencyTable.Size = New System.Drawing.Size(129, 27)
        Me.rdoFrequencyTable.TabIndex = 22
        Me.rdoFrequencyTable.TabStop = True
        Me.rdoFrequencyTable.Text = "Frequency Table"
        Me.rdoFrequencyTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrequencyTable.UseVisualStyleBackColor = True
        '
        'rdoSummaryTable
        '
        Me.rdoSummaryTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummaryTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryTable.FlatAppearance.BorderSize = 2
        Me.rdoSummaryTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummaryTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummaryTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummaryTable.Location = New System.Drawing.Point(235, 7)
        Me.rdoSummaryTable.Name = "rdoSummaryTable"
        Me.rdoSummaryTable.Size = New System.Drawing.Size(133, 27)
        Me.rdoSummaryTable.TabIndex = 21
        Me.rdoSummaryTable.TabStop = True
        Me.rdoSummaryTable.Text = "Summary Table"
        Me.rdoSummaryTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummaryTable.UseVisualStyleBackColor = True
        '
        'grpPercentages
        '
        Me.grpPercentages.Controls.Add(Me.lblFactorsAsPercentage)
        Me.grpPercentages.Controls.Add(Me.ucrReceiverMultiplePercentages)
        Me.grpPercentages.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpPercentages.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpPercentages.Location = New System.Drawing.Point(286, 178)
        Me.grpPercentages.Name = "grpPercentages"
        Me.grpPercentages.Size = New System.Drawing.Size(174, 192)
        Me.grpPercentages.TabIndex = 23
        Me.grpPercentages.TabStop = False
        Me.grpPercentages.Text = "Percentages"
        '
        'lblFactorsAsPercentage
        '
        Me.lblFactorsAsPercentage.AutoSize = True
        Me.lblFactorsAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorsAsPercentage.Location = New System.Drawing.Point(18, 44)
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Size = New System.Drawing.Size(117, 13)
        Me.lblFactorsAsPercentage.TabIndex = 1
        Me.lblFactorsAsPercentage.Tag = "Factors as Percentage:"
        Me.lblFactorsAsPercentage.Text = "Factors as Percentage:"
        '
        'lblFrequencyMarginName
        '
        Me.lblFrequencyMarginName.AutoSize = True
        Me.lblFrequencyMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrequencyMarginName.Location = New System.Drawing.Point(7, 275)
        Me.lblFrequencyMarginName.Name = "lblFrequencyMarginName"
        Me.lblFrequencyMarginName.Size = New System.Drawing.Size(76, 13)
        Me.lblFrequencyMarginName.TabIndex = 25
        Me.lblFrequencyMarginName.Text = "Margin Name :"
        '
        'ucrChkFrequencyDisplayMargins
        '
        Me.ucrChkFrequencyDisplayMargins.AutoSize = True
        Me.ucrChkFrequencyDisplayMargins.Checked = False
        Me.ucrChkFrequencyDisplayMargins.Location = New System.Drawing.Point(10, 245)
        Me.ucrChkFrequencyDisplayMargins.Name = "ucrChkFrequencyDisplayMargins"
        Me.ucrChkFrequencyDisplayMargins.Size = New System.Drawing.Size(213, 23)
        Me.ucrChkFrequencyDisplayMargins.TabIndex = 24
        '
        'ucrReceiverMultiplePercentages
        '
        Me.ucrReceiverMultiplePercentages.AutoSize = True
        Me.ucrReceiverMultiplePercentages.frmParent = Nothing
        Me.ucrReceiverMultiplePercentages.Location = New System.Drawing.Point(18, 59)
        Me.ucrReceiverMultiplePercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePercentages.Name = "ucrReceiverMultiplePercentages"
        Me.ucrReceiverMultiplePercentages.Selector = Nothing
        Me.ucrReceiverMultiplePercentages.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePercentages.strNcFilePath = ""
        Me.ucrReceiverMultiplePercentages.TabIndex = 2
        Me.ucrReceiverMultiplePercentages.ucrSelector = Nothing
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.AutoSize = True
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(5, 171)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(160, 23)
        Me.ucrChkPercentageProportion.TabIndex = 3
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(14, 19)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(135, 23)
        Me.ucrChkDisplayAsPercentage.TabIndex = 0
        '
        'ucrPnlSummaryFrequencyTables
        '
        Me.ucrPnlSummaryFrequencyTables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaryFrequencyTables.Location = New System.Drawing.Point(107, 3)
        Me.ucrPnlSummaryFrequencyTables.Name = "ucrPnlSummaryFrequencyTables"
        Me.ucrPnlSummaryFrequencyTables.Size = New System.Drawing.Size(260, 33)
        Me.ucrPnlSummaryFrequencyTables.TabIndex = 20
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.AutoSize = True
        Me.ucrReorderSummary.Location = New System.Drawing.Point(286, 305)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(200, 156)
        Me.ucrReorderSummary.TabIndex = 18
        Me.ucrReorderSummary.ucrDataFrameList = Nothing
        Me.ucrReorderSummary.ucrReceiver = Nothing
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(206, 284)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(74, 21)
        Me.ucrInputMarginName.TabIndex = 16
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(10, 490)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(319, 24)
        Me.ucrSaveTable.TabIndex = 12
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(10, 266)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(271, 23)
        Me.ucrChkOmitMissing.TabIndex = 9
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(10, 219)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(230, 23)
        Me.ucrChkStoreResults.TabIndex = 8
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(10, 287)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(150, 23)
        Me.ucrChkDisplayMargins.TabIndex = 10
        '
        'ucrNudColumnFactors
        '
        Me.ucrNudColumnFactors.AutoSize = True
        Me.ucrNudColumnFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColumnFactors.Location = New System.Drawing.Point(111, 49)
        Me.ucrNudColumnFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColumnFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColumnFactors.Name = "ucrNudColumnFactors"
        Me.ucrNudColumnFactors.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudColumnFactors.TabIndex = 19
        Me.ucrNudColumnFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkDisplaySummaryVariablesAsRow
        '
        Me.ucrChkDisplaySummaryVariablesAsRow.AutoSize = True
        Me.ucrChkDisplaySummaryVariablesAsRow.Checked = False
        Me.ucrChkDisplaySummaryVariablesAsRow.Location = New System.Drawing.Point(11, 73)
        Me.ucrChkDisplaySummaryVariablesAsRow.Name = "ucrChkDisplaySummaryVariablesAsRow"
        Me.ucrChkDisplaySummaryVariablesAsRow.Size = New System.Drawing.Size(231, 23)
        Me.ucrChkDisplaySummaryVariablesAsRow.TabIndex = 17
        '
        'ucrChkDisplayVariablesAsRows
        '
        Me.ucrChkDisplayVariablesAsRows.AutoSize = True
        Me.ucrChkDisplayVariablesAsRows.Checked = False
        Me.ucrChkDisplayVariablesAsRows.Location = New System.Drawing.Point(11, 97)
        Me.ucrChkDisplayVariablesAsRows.Name = "ucrChkDisplayVariablesAsRows"
        Me.ucrChkDisplayVariablesAsRows.Size = New System.Drawing.Size(186, 23)
        Me.ucrChkDisplayVariablesAsRows.TabIndex = 11
        '
        'ucrChkDisplaySummariesAsRow
        '
        Me.ucrChkDisplaySummariesAsRow.AutoSize = True
        Me.ucrChkDisplaySummariesAsRow.Checked = False
        Me.ucrChkDisplaySummariesAsRow.Location = New System.Drawing.Point(11, 73)
        Me.ucrChkDisplaySummariesAsRow.Name = "ucrChkDisplaySummariesAsRow"
        Me.ucrChkDisplaySummariesAsRow.Size = New System.Drawing.Size(175, 23)
        Me.ucrChkDisplaySummariesAsRow.TabIndex = 10
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.AutoSize = True
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(111, 23)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 5
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkSummaries
        '
        Me.ucrChkSummaries.AutoSize = True
        Me.ucrChkSummaries.Checked = False
        Me.ucrChkSummaries.Location = New System.Drawing.Point(10, 244)
        Me.ucrChkSummaries.Name = "ucrChkSummaries"
        Me.ucrChkSummaries.Size = New System.Drawing.Size(242, 23)
        Me.ucrChkSummaries.TabIndex = 7
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 517)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 14
        '
        'ucrReceiverSummaryCols
        '
        Me.ucrReceiverSummaryCols.AutoSize = True
        Me.ucrReceiverSummaryCols.frmParent = Me
        Me.ucrReceiverSummaryCols.Location = New System.Drawing.Point(286, 178)
        Me.ucrReceiverSummaryCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSummaryCols.Name = "ucrReceiverSummaryCols"
        Me.ucrReceiverSummaryCols.Selector = Nothing
        Me.ucrReceiverSummaryCols.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverSummaryCols.strNcFilePath = ""
        Me.ucrReceiverSummaryCols.TabIndex = 4
        Me.ucrReceiverSummaryCols.ucrSelector = Nothing
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.AutoSize = True
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(286, 59)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.TabIndex = 2
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(109, 222)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 6
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.AutoSize = True
        Me.ucrChkWeight.Checked = False
        Me.ucrChkWeight.Location = New System.Drawing.Point(10, 222)
        Me.ucrChkWeight.Name = "ucrChkWeight"
        Me.ucrChkWeight.Size = New System.Drawing.Size(84, 23)
        Me.ucrChkWeight.TabIndex = 5
        '
        'ucrSelectorSummaryTables
        '
        Me.ucrSelectorSummaryTables.AutoSize = True
        Me.ucrSelectorSummaryTables.bDropUnusedFilterLevels = False
        Me.ucrSelectorSummaryTables.bShowHiddenColumns = False
        Me.ucrSelectorSummaryTables.bUseCurrentFilter = True
        Me.ucrSelectorSummaryTables.Location = New System.Drawing.Point(10, 30)
        Me.ucrSelectorSummaryTables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSummaryTables.Name = "ucrSelectorSummaryTables"
        Me.ucrSelectorSummaryTables.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorSummaryTables.TabIndex = 0
        '
        'ucrPnlMargin
        '
        Me.ucrPnlMargin.AutoSize = True
        Me.ucrPnlMargin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMargin.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlMargin.Name = "ucrPnlMargin"
        Me.ucrPnlMargin.Size = New System.Drawing.Size(0, 0)
        Me.ucrPnlMargin.TabIndex = 13
        '
        'ucrInputFrequencyMarginName
        '
        Me.ucrInputFrequencyMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputFrequencyMarginName.AutoSize = True
        Me.ucrInputFrequencyMarginName.IsMultiline = False
        Me.ucrInputFrequencyMarginName.IsReadOnly = False
        Me.ucrInputFrequencyMarginName.Location = New System.Drawing.Point(92, 271)
        Me.ucrInputFrequencyMarginName.Name = "ucrInputFrequencyMarginName"
        Me.ucrInputFrequencyMarginName.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputFrequencyMarginName.TabIndex = 26
        '
        'dlgSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(489, 571)
        Me.Controls.Add(Me.ucrChkFrequencyDisplayMargins)
        Me.Controls.Add(Me.grpPercentages)
        Me.Controls.Add(Me.rdoFrequencyTable)
        Me.Controls.Add(Me.rdoSummaryTable)
        Me.Controls.Add(Me.ucrPnlSummaryFrequencyTables)
        Me.Controls.Add(Me.cmdFormatTable)
        Me.Controls.Add(Me.ucrReorderSummary)
        Me.Controls.Add(Me.lblVariables)
        Me.Controls.Add(Me.ucrInputMarginName)
        Me.Controls.Add(Me.lblMarginName)
        Me.Controls.Add(Me.ucrSaveTable)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.ucrChkStoreResults)
        Me.Controls.Add(Me.cmdSummaries)
        Me.Controls.Add(Me.ucrChkDisplayMargins)
        Me.Controls.Add(Me.grpDisplay)
        Me.Controls.Add(Me.ucrChkSummaries)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverSummaryCols)
        Me.Controls.Add(Me.ucrReceiverFactors)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeight)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrSelectorSummaryTables)
        Me.Controls.Add(Me.grpMargin)
        Me.Controls.Add(Me.lblFrequencyMarginName)
        Me.Controls.Add(Me.ucrInputFrequencyMarginName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary\Frequency Tables"
        Me.grpDisplay.ResumeLayout(False)
        Me.grpDisplay.PerformLayout()
        Me.grpMargin.ResumeLayout(False)
        Me.grpMargin.PerformLayout()
        Me.grpPercentages.ResumeLayout(False)
        Me.grpPercentages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorSummaryTables As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrChkWeight As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactors As ucrReceiverMultiple
    Friend WithEvents ucrReceiverSummaryCols As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkSummaries As ucrCheck
    Friend WithEvents cmdSummaries As Button
    Friend WithEvents ucrChkDisplayMargins As ucrCheck
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents ucrChkStoreResults As ucrCheck
    Friend WithEvents ucrSaveTable As ucrSave
    Friend WithEvents grpDisplay As GroupBox
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents grpMargin As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents rdoOuter As RadioButton
    Friend WithEvents ucrPnlMargin As UcrPanel
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents ucrChkDisplaySummaryVariablesAsRow As ucrCheck
    Friend WithEvents ucrChkDisplayVariablesAsRows As ucrCheck
    Friend WithEvents ucrChkDisplaySummariesAsRow As ucrCheck
    Friend WithEvents ucrNudColumnFactors As ucrNud
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents lblVariables As Label
    Friend WithEvents ucrReorderSummary As ucrReorder
    Friend WithEvents cmdFormatTable As Button
    Friend WithEvents ucrPnlSummaryFrequencyTables As UcrPanel
    Friend WithEvents rdoFrequencyTable As RadioButton
    Friend WithEvents rdoSummaryTable As RadioButton
    Friend WithEvents grpPercentages As GroupBox
    Friend WithEvents lblFactorsAsPercentage As Label
    Friend WithEvents ucrReceiverMultiplePercentages As ucrReceiverMultiple
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrInputFrequencyMarginName As ucrInputTextBox
    Friend WithEvents lblFrequencyMarginName As Label
    Friend WithEvents ucrChkFrequencyDisplayMargins As ucrCheck
End Class