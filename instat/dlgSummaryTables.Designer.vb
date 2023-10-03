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
        Me.components = New System.ComponentModel.Container()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdSummaries = New System.Windows.Forms.Button()
        Me.grpDisplay = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.rdoVariable = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryVariable = New System.Windows.Forms.RadioButton()
        Me.rdoFactorVariable = New System.Windows.Forms.RadioButton()
        Me.rdoNoColumnFactor = New System.Windows.Forms.RadioButton()
        Me.ucrPnlColumnFactor = New instat.UcrPanel()
        Me.grpMargin = New System.Windows.Forms.GroupBox()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.rdoOuter = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMargin = New instat.UcrPanel()
        Me.lblMarginName = New System.Windows.Forms.Label()
        Me.lblVariables = New System.Windows.Forms.Label()
        Me.cmdFormatTable = New System.Windows.Forms.Button()
        Me.rdoFrequencyTable = New System.Windows.Forms.RadioButton()
        Me.rdoSummaryTable = New System.Windows.Forms.RadioButton()
        Me.grpPercentages = New System.Windows.Forms.GroupBox()
        Me.ucrReceiverPercentages = New instat.ucrReceiverSingle()
        Me.lblFactorsAsPercentage = New System.Windows.Forms.Label()
        Me.ucrChkPercentageProportion = New instat.ucrCheck()
        Me.ucrChkDisplayAsPercentage = New instat.ucrCheck()
        Me.lblFrequencyMarginName = New System.Windows.Forms.Label()
        Me.cmdMissingOptions = New System.Windows.Forms.Button()
        Me.ucrChkFrequencyDisplayMargins = New instat.ucrCheck()
        Me.ucrPnlSummaryFrequencyTables = New instat.UcrPanel()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrChkSummaries = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSummaryCols = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrInputFrequencyMarginName = New instat.ucrInputTextBox()
        Me.rdoMultipleResponse = New System.Windows.Forms.RadioButton()
        Me.ttMultipleResponse = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.lblSigFigs = New System.Windows.Forms.Label()
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
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.grpDisplay.Controls.Add(Me.rdoVariable)
        Me.grpDisplay.Controls.Add(Me.rdoSummaryVariable)
        Me.grpDisplay.Controls.Add(Me.rdoFactorVariable)
        Me.grpDisplay.Controls.Add(Me.rdoNoColumnFactor)
        Me.grpDisplay.Controls.Add(Me.ucrPnlColumnFactor)
        Me.grpDisplay.Location = New System.Drawing.Point(10, 379)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Size = New System.Drawing.Size(270, 103)
        Me.grpDisplay.TabIndex = 11
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Display Column Factors"
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.AutoSize = True
        Me.ucrReceiverColumnFactor.frmParent = Me
        Me.ucrReceiverColumnFactor.Location = New System.Drawing.Point(140, 35)
        Me.ucrReceiverColumnFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.TabIndex = 34
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'rdoVariable
        '
        Me.rdoVariable.AutoSize = True
        Me.rdoVariable.Location = New System.Drawing.Point(14, 74)
        Me.rdoVariable.Name = "rdoVariable"
        Me.rdoVariable.Size = New System.Drawing.Size(63, 17)
        Me.rdoVariable.TabIndex = 32
        Me.rdoVariable.TabStop = True
        Me.rdoVariable.Text = "Variable"
        Me.rdoVariable.UseVisualStyleBackColor = True
        '
        'rdoSummaryVariable
        '
        Me.rdoSummaryVariable.AutoSize = True
        Me.rdoSummaryVariable.Location = New System.Drawing.Point(14, 55)
        Me.rdoSummaryVariable.Name = "rdoSummaryVariable"
        Me.rdoSummaryVariable.Size = New System.Drawing.Size(109, 17)
        Me.rdoSummaryVariable.TabIndex = 31
        Me.rdoSummaryVariable.TabStop = True
        Me.rdoSummaryVariable.Text = "Summary-Variable"
        Me.rdoSummaryVariable.UseVisualStyleBackColor = True
        '
        'rdoFactorVariable
        '
        Me.rdoFactorVariable.AutoSize = True
        Me.rdoFactorVariable.Checked = True
        Me.rdoFactorVariable.Location = New System.Drawing.Point(14, 36)
        Me.rdoFactorVariable.Name = "rdoFactorVariable"
        Me.rdoFactorVariable.Size = New System.Drawing.Size(96, 17)
        Me.rdoFactorVariable.TabIndex = 30
        Me.rdoFactorVariable.TabStop = True
        Me.rdoFactorVariable.Text = "Factor Variable"
        Me.rdoFactorVariable.UseVisualStyleBackColor = True
        '
        'rdoNoColumnFactor
        '
        Me.rdoNoColumnFactor.AutoSize = True
        Me.rdoNoColumnFactor.Location = New System.Drawing.Point(14, 17)
        Me.rdoNoColumnFactor.Name = "rdoNoColumnFactor"
        Me.rdoNoColumnFactor.Size = New System.Drawing.Size(110, 17)
        Me.rdoNoColumnFactor.TabIndex = 29
        Me.rdoNoColumnFactor.Text = "No Column Factor"
        Me.rdoNoColumnFactor.UseVisualStyleBackColor = True
        '
        'ucrPnlColumnFactor
        '
        Me.ucrPnlColumnFactor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnFactor.Location = New System.Drawing.Point(11, 17)
        Me.ucrPnlColumnFactor.Name = "ucrPnlColumnFactor"
        Me.ucrPnlColumnFactor.Size = New System.Drawing.Size(124, 80)
        Me.ucrPnlColumnFactor.TabIndex = 29
        '
        'grpMargin
        '
        Me.grpMargin.Controls.Add(Me.rdoBoth)
        Me.grpMargin.Controls.Add(Me.rdoSummary)
        Me.grpMargin.Controls.Add(Me.rdoOuter)
        Me.grpMargin.Controls.Add(Me.ucrPnlMargin)
        Me.grpMargin.Location = New System.Drawing.Point(10, 313)
        Me.grpMargin.Name = "grpMargin"
        Me.grpMargin.Size = New System.Drawing.Size(213, 40)
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
        'ucrPnlMargin
        '
        Me.ucrPnlMargin.AutoSize = True
        Me.ucrPnlMargin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMargin.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlMargin.Name = "ucrPnlMargin"
        Me.ucrPnlMargin.Size = New System.Drawing.Size(0, 0)
        Me.ucrPnlMargin.TabIndex = 13
        '
        'lblMarginName
        '
        Me.lblMarginName.AutoSize = True
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(159, 288)
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
        Me.rdoFrequencyTable.Location = New System.Drawing.Point(51, 7)
        Me.rdoFrequencyTable.Name = "rdoFrequencyTable"
        Me.rdoFrequencyTable.Size = New System.Drawing.Size(129, 27)
        Me.rdoFrequencyTable.TabIndex = 22
        Me.rdoFrequencyTable.TabStop = True
        Me.rdoFrequencyTable.Text = "Frequency"
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
        Me.rdoSummaryTable.Location = New System.Drawing.Point(178, 7)
        Me.rdoSummaryTable.Name = "rdoSummaryTable"
        Me.rdoSummaryTable.Size = New System.Drawing.Size(133, 27)
        Me.rdoSummaryTable.TabIndex = 21
        Me.rdoSummaryTable.TabStop = True
        Me.rdoSummaryTable.Text = "Summary"
        Me.rdoSummaryTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummaryTable.UseVisualStyleBackColor = True
        '
        'grpPercentages
        '
        Me.grpPercentages.Controls.Add(Me.ucrReceiverPercentages)
        Me.grpPercentages.Controls.Add(Me.lblFactorsAsPercentage)
        Me.grpPercentages.Controls.Add(Me.ucrChkPercentageProportion)
        Me.grpPercentages.Controls.Add(Me.ucrChkDisplayAsPercentage)
        Me.grpPercentages.Location = New System.Drawing.Point(286, 178)
        Me.grpPercentages.Name = "grpPercentages"
        Me.grpPercentages.Size = New System.Drawing.Size(174, 89)
        Me.grpPercentages.TabIndex = 23
        Me.grpPercentages.TabStop = False
        Me.grpPercentages.Text = "Percentages"
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Me
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(16, 60)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 4
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'lblFactorsAsPercentage
        '
        Me.lblFactorsAsPercentage.AutoSize = True
        Me.lblFactorsAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorsAsPercentage.Location = New System.Drawing.Point(18, 44)
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Size = New System.Drawing.Size(100, 13)
        Me.lblFactorsAsPercentage.TabIndex = 1
        Me.lblFactorsAsPercentage.Tag = "Factors as Percentage:"
        Me.lblFactorsAsPercentage.Text = "of Factor (Optional):"
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
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.Enabled = False
        Me.cmdMissingOptions.Location = New System.Drawing.Point(205, 261)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(75, 23)
        Me.cmdMissingOptions.TabIndex = 27
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
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
        'ucrPnlSummaryFrequencyTables
        '
        Me.ucrPnlSummaryFrequencyTables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaryFrequencyTables.Location = New System.Drawing.Point(44, 3)
        Me.ucrPnlSummaryFrequencyTables.Name = "ucrPnlSummaryFrequencyTables"
        Me.ucrPnlSummaryFrequencyTables.Size = New System.Drawing.Size(407, 33)
        Me.ucrPnlSummaryFrequencyTables.TabIndex = 20
        '
        'ucrInputMarginName
        '
        Me.ucrInputMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputMarginName.AutoSize = True
        Me.ucrInputMarginName.IsMultiline = False
        Me.ucrInputMarginName.IsReadOnly = False
        Me.ucrInputMarginName.Location = New System.Drawing.Point(206, 285)
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
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(152, 23)
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
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
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
        'rdoMultipleResponse
        '
        Me.rdoMultipleResponse.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMultipleResponse.Enabled = False
        Me.rdoMultipleResponse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultipleResponse.FlatAppearance.BorderSize = 2
        Me.rdoMultipleResponse.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMultipleResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMultipleResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultipleResponse.Location = New System.Drawing.Point(309, 7)
        Me.rdoMultipleResponse.Name = "rdoMultipleResponse"
        Me.rdoMultipleResponse.Size = New System.Drawing.Size(133, 27)
        Me.rdoMultipleResponse.TabIndex = 28
        Me.rdoMultipleResponse.TabStop = True
        Me.rdoMultipleResponse.Text = "Multiple Response"
        Me.rdoMultipleResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttMultipleResponse.SetToolTip(Me.rdoMultipleResponse, "Not Yet Available")
        Me.rdoMultipleResponse.UseVisualStyleBackColor = True
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
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.AutoSize = True
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(118, 356)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSigFigs.TabIndex = 30
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigFigs.Location = New System.Drawing.Point(15, 359)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(96, 13)
        Me.lblSigFigs.TabIndex = 29
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'dlgSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(489, 571)
        Me.Controls.Add(Me.ucrNudSigFigs)
        Me.Controls.Add(Me.lblSigFigs)
        Me.Controls.Add(Me.rdoMultipleResponse)
        Me.Controls.Add(Me.cmdMissingOptions)
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
        Me.Text = "Frequency/Summary Tables"
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
    Friend WithEvents grpMargin As GroupBox
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents rdoOuter As RadioButton
    Friend WithEvents ucrPnlMargin As UcrPanel
    Friend WithEvents lblMarginName As Label
    Friend WithEvents ucrInputMarginName As ucrInputTextBox
    Friend WithEvents lblVariables As Label
    Friend WithEvents ucrReorderSummary As ucrReorder
    Friend WithEvents cmdFormatTable As Button
    Friend WithEvents ucrPnlSummaryFrequencyTables As UcrPanel
    Friend WithEvents rdoFrequencyTable As RadioButton
    Friend WithEvents rdoSummaryTable As RadioButton
    Friend WithEvents grpPercentages As GroupBox
    Friend WithEvents lblFactorsAsPercentage As Label
    Friend WithEvents ucrChkPercentageProportion As ucrCheck
    Friend WithEvents ucrChkDisplayAsPercentage As ucrCheck
    Friend WithEvents ucrInputFrequencyMarginName As ucrInputTextBox
    Friend WithEvents lblFrequencyMarginName As Label
    Friend WithEvents ucrChkFrequencyDisplayMargins As ucrCheck
    Friend WithEvents ucrReceiverPercentages As ucrReceiverSingle
    Friend WithEvents cmdMissingOptions As Button
    Friend WithEvents rdoMultipleResponse As RadioButton
    Friend WithEvents ttMultipleResponse As ToolTip
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents rdoVariable As RadioButton
    Friend WithEvents rdoSummaryVariable As RadioButton
    Friend WithEvents rdoFactorVariable As RadioButton
    Friend WithEvents rdoNoColumnFactor As RadioButton
    Friend WithEvents ucrPnlColumnFactor As UcrPanel
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
End Class