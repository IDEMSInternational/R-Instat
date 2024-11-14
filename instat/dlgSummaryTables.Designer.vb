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
        Me.lblColumnSummariesFactors = New System.Windows.Forms.Label()
        Me.UcrNudColumnSumFactors = New instat.ucrNud()
        Me.lblPositionSum = New System.Windows.Forms.Label()
        Me.lblPositionVar = New System.Windows.Forms.Label()
        Me.ucrNudPositionVar = New instat.ucrNud()
        Me.ucrNudPositionSum = New instat.ucrNud()
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
        Me.rdoMultipleResponse = New System.Windows.Forms.RadioButton()
        Me.ttMultipleResponse = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblSigFigs = New System.Windows.Forms.Label()
        Me.lblColumnFactors = New System.Windows.Forms.Label()
        Me.btnMoreOptions = New System.Windows.Forms.Button()
        Me.ucrNudColFactors = New instat.ucrNud()
        Me.ucrNudSigFigs = New instat.ucrNud()
        Me.ucrPnlSummaryFrequencyTables = New instat.UcrPanel()
        Me.ucrReorderSummary = New instat.ucrReorder()
        Me.ucrInputMarginName = New instat.ucrInputTextBox()
        Me.ucrSaveTable = New instat.ucrSave()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrChkStoreResults = New instat.ucrCheck()
        Me.ucrChkDisplayMargins = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverSummaryCols = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFactors = New instat.ucrReceiverMultiple()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeight = New instat.ucrCheck()
        Me.ucrSelectorSummaryTables = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrInputFrequencyMarginName = New instat.ucrInputTextBox()
        Me.ucrChkFrequencyDisplayMargins = New instat.ucrCheck()
        Me.ucrChkDropLevels = New instat.ucrCheck()
        Me.grpDisplay.SuspendLayout()
        Me.grpMargin.SuspendLayout()
        Me.grpPercentages.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(429, 64)
        Me.lblFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(71, 20)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Tag = "Factors:"
        Me.lblFactors.Text = "Factors :"
        '
        'cmdSummaries
        '
        Me.cmdSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaries.Location = New System.Drawing.Point(429, 420)
        Me.cmdSummaries.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSummaries.Name = "cmdSummaries"
        Me.cmdSummaries.Size = New System.Drawing.Size(156, 34)
        Me.cmdSummaries.TabIndex = 13
        Me.cmdSummaries.Text = "Summaries..."
        Me.cmdSummaries.UseVisualStyleBackColor = True
        '
        'grpDisplay
        '
        Me.grpDisplay.Controls.Add(Me.lblColumnSummariesFactors)
        Me.grpDisplay.Controls.Add(Me.UcrNudColumnSumFactors)
        Me.grpDisplay.Controls.Add(Me.lblPositionSum)
        Me.grpDisplay.Controls.Add(Me.lblPositionVar)
        Me.grpDisplay.Controls.Add(Me.ucrNudPositionVar)
        Me.grpDisplay.Controls.Add(Me.ucrNudPositionSum)
        Me.grpDisplay.Location = New System.Drawing.Point(15, 597)
        Me.grpDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Name = "grpDisplay"
        Me.grpDisplay.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDisplay.Size = New System.Drawing.Size(368, 133)
        Me.grpDisplay.TabIndex = 11
        Me.grpDisplay.TabStop = False
        Me.grpDisplay.Text = "Layout"
        '
        'lblColumnSummariesFactors
        '
        Me.lblColumnSummariesFactors.AutoSize = True
        Me.lblColumnSummariesFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnSummariesFactors.Location = New System.Drawing.Point(39, 23)
        Me.lblColumnSummariesFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnSummariesFactors.Name = "lblColumnSummariesFactors"
        Me.lblColumnSummariesFactors.Size = New System.Drawing.Size(137, 20)
        Me.lblColumnSummariesFactors.TabIndex = 38
        Me.lblColumnSummariesFactors.Tag = "Significant_Figures:"
        Me.lblColumnSummariesFactors.Text = "Column ""Factors"":"
        '
        'UcrNudColumnSumFactors
        '
        Me.UcrNudColumnSumFactors.AutoSize = True
        Me.UcrNudColumnSumFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudColumnSumFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UcrNudColumnSumFactors.Location = New System.Drawing.Point(245, 18)
        Me.UcrNudColumnSumFactors.Margin = New System.Windows.Forms.Padding(9)
        Me.UcrNudColumnSumFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudColumnSumFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudColumnSumFactors.Name = "UcrNudColumnSumFactors"
        Me.UcrNudColumnSumFactors.Size = New System.Drawing.Size(75, 30)
        Me.UcrNudColumnSumFactors.TabIndex = 37
        Me.UcrNudColumnSumFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPositionSum
        '
        Me.lblPositionSum.AutoSize = True
        Me.lblPositionSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPositionSum.Location = New System.Drawing.Point(8, 98)
        Me.lblPositionSum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionSum.Name = "lblPositionSum"
        Me.lblPositionSum.Size = New System.Drawing.Size(171, 20)
        Me.lblPositionSum.TabIndex = 36
        Me.lblPositionSum.Tag = "Significant_Figures:"
        Me.lblPositionSum.Text = "Position of Summaries:"
        '
        'lblPositionVar
        '
        Me.lblPositionVar.AutoSize = True
        Me.lblPositionVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPositionVar.Location = New System.Drawing.Point(19, 62)
        Me.lblPositionVar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPositionVar.Name = "lblPositionVar"
        Me.lblPositionVar.Size = New System.Drawing.Size(157, 20)
        Me.lblPositionVar.TabIndex = 35
        Me.lblPositionVar.Tag = "Significant_Figures:"
        Me.lblPositionVar.Text = "Position of Variables:"
        '
        'ucrNudPositionVar
        '
        Me.ucrNudPositionVar.AutoSize = True
        Me.ucrNudPositionVar.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVar.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPositionVar.Location = New System.Drawing.Point(245, 57)
        Me.ucrNudPositionVar.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudPositionVar.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPositionVar.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionVar.Name = "ucrNudPositionVar"
        Me.ucrNudPositionVar.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudPositionVar.TabIndex = 34
        Me.ucrNudPositionVar.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudPositionSum
        '
        Me.ucrNudPositionSum.AutoSize = True
        Me.ucrNudPositionSum.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionSum.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPositionSum.Location = New System.Drawing.Point(245, 95)
        Me.ucrNudPositionSum.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudPositionSum.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPositionSum.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPositionSum.Name = "ucrNudPositionSum"
        Me.ucrNudPositionSum.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudPositionSum.TabIndex = 33
        Me.ucrNudPositionSum.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'grpMargin
        '
        Me.grpMargin.Controls.Add(Me.rdoBoth)
        Me.grpMargin.Controls.Add(Me.rdoSummary)
        Me.grpMargin.Controls.Add(Me.rdoOuter)
        Me.grpMargin.Controls.Add(Me.ucrPnlMargin)
        Me.grpMargin.Location = New System.Drawing.Point(15, 480)
        Me.grpMargin.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMargin.Name = "grpMargin"
        Me.grpMargin.Padding = New System.Windows.Forms.Padding(4)
        Me.grpMargin.Size = New System.Drawing.Size(320, 60)
        Me.grpMargin.TabIndex = 13
        Me.grpMargin.TabStop = False
        '
        'rdoBoth
        '
        Me.rdoBoth.AutoSize = True
        Me.rdoBoth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoth.Location = New System.Drawing.Point(210, 36)
        Me.rdoBoth.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.Size = New System.Drawing.Size(68, 24)
        Me.rdoBoth.TabIndex = 16
        Me.rdoBoth.TabStop = True
        Me.rdoBoth.Text = "Both"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        Me.rdoSummary.AutoSize = True
        Me.rdoSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummary.Location = New System.Drawing.Point(100, 36)
        Me.rdoSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(101, 24)
        Me.rdoSummary.TabIndex = 16
        Me.rdoSummary.TabStop = True
        Me.rdoSummary.Text = "Summary"
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'rdoOuter
        '
        Me.rdoOuter.AutoSize = True
        Me.rdoOuter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOuter.Location = New System.Drawing.Point(15, 36)
        Me.rdoOuter.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoOuter.Name = "rdoOuter"
        Me.rdoOuter.Size = New System.Drawing.Size(74, 24)
        Me.rdoOuter.TabIndex = 15
        Me.rdoOuter.TabStop = True
        Me.rdoOuter.Text = "Outer"
        Me.rdoOuter.UseVisualStyleBackColor = True
        '
        'ucrPnlMargin
        '
        Me.ucrPnlMargin.AutoSize = True
        Me.ucrPnlMargin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMargin.Location = New System.Drawing.Point(9, 21)
        Me.ucrPnlMargin.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlMargin.Name = "ucrPnlMargin"
        Me.ucrPnlMargin.Size = New System.Drawing.Size(0, 0)
        Me.ucrPnlMargin.TabIndex = 13
        '
        'lblMarginName
        '
        Me.lblMarginName.AutoSize = True
        Me.lblMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMarginName.Location = New System.Drawing.Point(238, 452)
        Me.lblMarginName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarginName.Name = "lblMarginName"
        Me.lblMarginName.Size = New System.Drawing.Size(59, 20)
        Me.lblMarginName.TabIndex = 15
        Me.lblMarginName.Text = "Name :"
        '
        'lblVariables
        '
        Me.lblVariables.AutoSize = True
        Me.lblVariables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariables.Location = New System.Drawing.Point(428, 243)
        Me.lblVariables.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariables.Name = "lblVariables"
        Me.lblVariables.Size = New System.Drawing.Size(83, 20)
        Me.lblVariables.TabIndex = 17
        Me.lblVariables.Tag = ""
        Me.lblVariables.Text = "Variables :"
        '
        'cmdFormatTable
        '
        Me.cmdFormatTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFormatTable.Location = New System.Drawing.Point(429, 696)
        Me.cmdFormatTable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFormatTable.Name = "cmdFormatTable"
        Me.cmdFormatTable.Size = New System.Drawing.Size(156, 34)
        Me.cmdFormatTable.TabIndex = 19
        Me.cmdFormatTable.Text = "Format Table..."
        Me.cmdFormatTable.UseVisualStyleBackColor = True
        Me.cmdFormatTable.Visible = False
        '
        'rdoFrequencyTable
        '
        Me.rdoFrequencyTable.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrequencyTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyTable.FlatAppearance.BorderSize = 2
        Me.rdoFrequencyTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrequencyTable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequencyTable.Location = New System.Drawing.Point(76, 0)
        Me.rdoFrequencyTable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFrequencyTable.Name = "rdoFrequencyTable"
        Me.rdoFrequencyTable.Size = New System.Drawing.Size(194, 40)
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
        Me.rdoSummaryTable.Location = New System.Drawing.Point(267, 0)
        Me.rdoSummaryTable.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSummaryTable.Name = "rdoSummaryTable"
        Me.rdoSummaryTable.Size = New System.Drawing.Size(200, 40)
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
        Me.grpPercentages.Location = New System.Drawing.Point(429, 267)
        Me.grpPercentages.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPercentages.Name = "grpPercentages"
        Me.grpPercentages.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPercentages.Size = New System.Drawing.Size(261, 134)
        Me.grpPercentages.TabIndex = 23
        Me.grpPercentages.TabStop = False
        Me.grpPercentages.Text = "Percentages"
        '
        'ucrReceiverPercentages
        '
        Me.ucrReceiverPercentages.AutoSize = True
        Me.ucrReceiverPercentages.frmParent = Me
        Me.ucrReceiverPercentages.Location = New System.Drawing.Point(24, 90)
        Me.ucrReceiverPercentages.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverPercentages.Name = "ucrReceiverPercentages"
        Me.ucrReceiverPercentages.Selector = Nothing
        Me.ucrReceiverPercentages.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverPercentages.strNcFilePath = ""
        Me.ucrReceiverPercentages.TabIndex = 4
        Me.ucrReceiverPercentages.ucrSelector = Nothing
        '
        'lblFactorsAsPercentage
        '
        Me.lblFactorsAsPercentage.AutoSize = True
        Me.lblFactorsAsPercentage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorsAsPercentage.Location = New System.Drawing.Point(27, 66)
        Me.lblFactorsAsPercentage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorsAsPercentage.Name = "lblFactorsAsPercentage"
        Me.lblFactorsAsPercentage.Size = New System.Drawing.Size(150, 20)
        Me.lblFactorsAsPercentage.TabIndex = 1
        Me.lblFactorsAsPercentage.Tag = "Factors as Percentage:"
        Me.lblFactorsAsPercentage.Text = "of Factor (Optional):"
        '
        'ucrChkPercentageProportion
        '
        Me.ucrChkPercentageProportion.AutoSize = True
        Me.ucrChkPercentageProportion.Checked = False
        Me.ucrChkPercentageProportion.Location = New System.Drawing.Point(8, 256)
        Me.ucrChkPercentageProportion.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkPercentageProportion.Name = "ucrChkPercentageProportion"
        Me.ucrChkPercentageProportion.Size = New System.Drawing.Size(240, 51)
        Me.ucrChkPercentageProportion.TabIndex = 3
        '
        'ucrChkDisplayAsPercentage
        '
        Me.ucrChkDisplayAsPercentage.AutoSize = True
        Me.ucrChkDisplayAsPercentage.Checked = False
        Me.ucrChkDisplayAsPercentage.Location = New System.Drawing.Point(21, 28)
        Me.ucrChkDisplayAsPercentage.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayAsPercentage.Name = "ucrChkDisplayAsPercentage"
        Me.ucrChkDisplayAsPercentage.Size = New System.Drawing.Size(202, 51)
        Me.ucrChkDisplayAsPercentage.TabIndex = 0
        '
        'lblFrequencyMarginName
        '
        Me.lblFrequencyMarginName.AutoSize = True
        Me.lblFrequencyMarginName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrequencyMarginName.Location = New System.Drawing.Point(10, 412)
        Me.lblFrequencyMarginName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrequencyMarginName.Name = "lblFrequencyMarginName"
        Me.lblFrequencyMarginName.Size = New System.Drawing.Size(111, 20)
        Me.lblFrequencyMarginName.TabIndex = 25
        Me.lblFrequencyMarginName.Text = "Margin Name :"
        '
        'cmdMissingOptions
        '
        Me.cmdMissingOptions.Enabled = False
        Me.cmdMissingOptions.Location = New System.Drawing.Point(308, 406)
        Me.cmdMissingOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMissingOptions.Name = "cmdMissingOptions"
        Me.cmdMissingOptions.Size = New System.Drawing.Size(112, 34)
        Me.cmdMissingOptions.TabIndex = 27
        Me.cmdMissingOptions.Text = "Options"
        Me.cmdMissingOptions.UseVisualStyleBackColor = True
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
        Me.rdoMultipleResponse.Location = New System.Drawing.Point(464, 0)
        Me.rdoMultipleResponse.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMultipleResponse.Name = "rdoMultipleResponse"
        Me.rdoMultipleResponse.Size = New System.Drawing.Size(200, 40)
        Me.rdoMultipleResponse.TabIndex = 28
        Me.rdoMultipleResponse.TabStop = True
        Me.rdoMultipleResponse.Text = "Multiple Response"
        Me.rdoMultipleResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttMultipleResponse.SetToolTip(Me.rdoMultipleResponse, "Not Yet Available")
        Me.rdoMultipleResponse.UseVisualStyleBackColor = True
        '
        'lblSigFigs
        '
        Me.lblSigFigs.AutoSize = True
        Me.lblSigFigs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSigFigs.Location = New System.Drawing.Point(22, 538)
        Me.lblSigFigs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSigFigs.Name = "lblSigFigs"
        Me.lblSigFigs.Size = New System.Drawing.Size(144, 20)
        Me.lblSigFigs.TabIndex = 29
        Me.lblSigFigs.Tag = "Significant_Figures:"
        Me.lblSigFigs.Text = "Significant Figures:"
        '
        'lblColumnFactors
        '
        Me.lblColumnFactors.AutoSize = True
        Me.lblColumnFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnFactors.Location = New System.Drawing.Point(34, 506)
        Me.lblColumnFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnFactors.Name = "lblColumnFactors"
        Me.lblColumnFactors.Size = New System.Drawing.Size(125, 20)
        Me.lblColumnFactors.TabIndex = 32
        Me.lblColumnFactors.Tag = "Significant_Figures:"
        Me.lblColumnFactors.Text = "Column Factors:"
        '
        'btnMoreOptions
        '
        Me.btnMoreOptions.Location = New System.Drawing.Point(15, 310)
        Me.btnMoreOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMoreOptions.Name = "btnMoreOptions"
        Me.btnMoreOptions.Size = New System.Drawing.Size(212, 32)
        Me.btnMoreOptions.TabIndex = 33
        Me.btnMoreOptions.Text = "Table Options"
        Me.btnMoreOptions.UseVisualStyleBackColor = True
        '
        'ucrNudColFactors
        '
        Me.ucrNudColFactors.AutoSize = True
        Me.ucrNudColFactors.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColFactors.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudColFactors.Location = New System.Drawing.Point(178, 501)
        Me.ucrNudColFactors.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudColFactors.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudColFactors.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudColFactors.Name = "ucrNudColFactors"
        Me.ucrNudColFactors.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudColFactors.TabIndex = 31
        Me.ucrNudColFactors.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSigFigs
        '
        Me.ucrNudSigFigs.AutoSize = True
        Me.ucrNudSigFigs.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSigFigs.Location = New System.Drawing.Point(177, 534)
        Me.ucrNudSigFigs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudSigFigs.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSigFigs.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSigFigs.Name = "ucrNudSigFigs"
        Me.ucrNudSigFigs.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudSigFigs.TabIndex = 30
        Me.ucrNudSigFigs.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlSummaryFrequencyTables
        '
        Me.ucrPnlSummaryFrequencyTables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSummaryFrequencyTables.Location = New System.Drawing.Point(66, -6)
        Me.ucrPnlSummaryFrequencyTables.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlSummaryFrequencyTables.Name = "ucrPnlSummaryFrequencyTables"
        Me.ucrPnlSummaryFrequencyTables.Size = New System.Drawing.Size(610, 50)
        Me.ucrPnlSummaryFrequencyTables.TabIndex = 20
        '
        'ucrReorderSummary
        '
        Me.ucrReorderSummary.AutoSize = True
        Me.ucrReorderSummary.Location = New System.Drawing.Point(429, 458)
        Me.ucrReorderSummary.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrReorderSummary.Name = "ucrReorderSummary"
        Me.ucrReorderSummary.Size = New System.Drawing.Size(300, 234)
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
        Me.ucrInputMarginName.Location = New System.Drawing.Point(309, 447)
        Me.ucrInputMarginName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputMarginName.Name = "ucrInputMarginName"
        Me.ucrInputMarginName.Size = New System.Drawing.Size(111, 32)
        Me.ucrInputMarginName.TabIndex = 16
        '
        'ucrSaveTable
        '
        Me.ucrSaveTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveTable.Location = New System.Drawing.Point(15, 735)
        Me.ucrSaveTable.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveTable.Name = "ucrSaveTable"
        Me.ucrSaveTable.Size = New System.Drawing.Size(478, 36)
        Me.ucrSaveTable.TabIndex = 12
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(15, 414)
        Me.ucrChkOmitMissing.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(228, 34)
        Me.ucrChkOmitMissing.TabIndex = 9
        '
        'ucrChkStoreResults
        '
        Me.ucrChkStoreResults.AutoSize = True
        Me.ucrChkStoreResults.Checked = False
        Me.ucrChkStoreResults.Location = New System.Drawing.Point(15, 350)
        Me.ucrChkStoreResults.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkStoreResults.Name = "ucrChkStoreResults"
        Me.ucrChkStoreResults.Size = New System.Drawing.Size(345, 34)
        Me.ucrChkStoreResults.TabIndex = 8
        '
        'ucrChkDisplayMargins
        '
        Me.ucrChkDisplayMargins.AutoSize = True
        Me.ucrChkDisplayMargins.Checked = False
        Me.ucrChkDisplayMargins.Location = New System.Drawing.Point(15, 450)
        Me.ucrChkDisplayMargins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayMargins.Name = "ucrChkDisplayMargins"
        Me.ucrChkDisplayMargins.Size = New System.Drawing.Size(225, 34)
        Me.ucrChkDisplayMargins.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 776)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 14
        '
        'ucrReceiverSummaryCols
        '
        Me.ucrReceiverSummaryCols.AutoSize = True
        Me.ucrReceiverSummaryCols.frmParent = Me
        Me.ucrReceiverSummaryCols.Location = New System.Drawing.Point(429, 267)
        Me.ucrReceiverSummaryCols.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSummaryCols.Name = "ucrReceiverSummaryCols"
        Me.ucrReceiverSummaryCols.Selector = Nothing
        Me.ucrReceiverSummaryCols.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverSummaryCols.strNcFilePath = ""
        Me.ucrReceiverSummaryCols.TabIndex = 4
        Me.ucrReceiverSummaryCols.ucrSelector = Nothing
        '
        'ucrReceiverFactors
        '
        Me.ucrReceiverFactors.AutoSize = True
        Me.ucrReceiverFactors.frmParent = Me
        Me.ucrReceiverFactors.Location = New System.Drawing.Point(429, 88)
        Me.ucrReceiverFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactors.Name = "ucrReceiverFactors"
        Me.ucrReceiverFactors.Selector = Nothing
        Me.ucrReceiverFactors.Size = New System.Drawing.Size(180, 150)
        Me.ucrReceiverFactors.strNcFilePath = ""
        Me.ucrReceiverFactors.TabIndex = 2
        Me.ucrReceiverFactors.ucrSelector = Nothing
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(164, 333)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 6
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrChkWeight
        '
        Me.ucrChkWeight.AutoSize = True
        Me.ucrChkWeight.Checked = False
        Me.ucrChkWeight.Location = New System.Drawing.Point(15, 333)
        Me.ucrChkWeight.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkWeight.Name = "ucrChkWeight"
        Me.ucrChkWeight.Size = New System.Drawing.Size(126, 34)
        Me.ucrChkWeight.TabIndex = 5
        '
        'ucrSelectorSummaryTables
        '
        Me.ucrSelectorSummaryTables.AutoSize = True
        Me.ucrSelectorSummaryTables.bDropUnusedFilterLevels = False
        Me.ucrSelectorSummaryTables.bShowHiddenColumns = False
        Me.ucrSelectorSummaryTables.bUseCurrentFilter = True
        Me.ucrSelectorSummaryTables.Location = New System.Drawing.Point(15, 36)
        Me.ucrSelectorSummaryTables.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorSummaryTables.Name = "ucrSelectorSummaryTables"
        Me.ucrSelectorSummaryTables.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorSummaryTables.TabIndex = 0
        '
        'ucrInputFrequencyMarginName
        '
        Me.ucrInputFrequencyMarginName.AddQuotesIfUnrecognised = True
        Me.ucrInputFrequencyMarginName.AutoSize = True
        Me.ucrInputFrequencyMarginName.IsMultiline = False
        Me.ucrInputFrequencyMarginName.IsReadOnly = False
        Me.ucrInputFrequencyMarginName.Location = New System.Drawing.Point(138, 422)
        Me.ucrInputFrequencyMarginName.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFrequencyMarginName.Name = "ucrInputFrequencyMarginName"
        Me.ucrInputFrequencyMarginName.Size = New System.Drawing.Size(105, 32)
        Me.ucrInputFrequencyMarginName.TabIndex = 26
        '
        'ucrChkFrequencyDisplayMargins
        '
        Me.ucrChkFrequencyDisplayMargins.AutoSize = True
        Me.ucrChkFrequencyDisplayMargins.Checked = False
        Me.ucrChkFrequencyDisplayMargins.Location = New System.Drawing.Point(15, 382)
        Me.ucrChkFrequencyDisplayMargins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFrequencyDisplayMargins.Name = "ucrChkFrequencyDisplayMargins"
        Me.ucrChkFrequencyDisplayMargins.Size = New System.Drawing.Size(320, 34)
        Me.ucrChkFrequencyDisplayMargins.TabIndex = 24
        '
        'ucrChkDropLevels
        '
        Me.ucrChkDropLevels.AutoSize = True
        Me.ucrChkDropLevels.Checked = False
        Me.ucrChkDropLevels.Location = New System.Drawing.Point(15, 381)
        Me.ucrChkDropLevels.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkDropLevels.Name = "ucrChkDropLevels"
        Me.ucrChkDropLevels.Size = New System.Drawing.Size(225, 34)
        Me.ucrChkDropLevels.TabIndex = 34
        '
        'dlgSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(734, 860)
        Me.Controls.Add(Me.ucrChkDropLevels)
        Me.Controls.Add(Me.btnMoreOptions)
        Me.Controls.Add(Me.lblColumnFactors)
        Me.Controls.Add(Me.ucrNudColFactors)
        Me.Controls.Add(Me.ucrNudSigFigs)
        Me.Controls.Add(Me.lblSigFigs)
        Me.Controls.Add(Me.rdoMultipleResponse)
        Me.Controls.Add(Me.cmdMissingOptions)
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
        Me.Controls.Add(Me.ucrChkFrequencyDisplayMargins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents ucrNudSigFigs As ucrNud
    Friend WithEvents lblSigFigs As Label
    Friend WithEvents lblColumnFactors As Label
    Friend WithEvents ucrNudColFactors As ucrNud
    Friend WithEvents btnMoreOptions As Button
    Friend WithEvents lblPositionSum As Label
    Friend WithEvents lblPositionVar As Label
    Friend WithEvents ucrNudPositionVar As ucrNud
    Friend WithEvents ucrNudPositionSum As ucrNud
    Friend WithEvents lblColumnSummariesFactors As Label
    Friend WithEvents UcrNudColumnSumFactors As ucrNud
    Friend WithEvents ucrChkDropLevels As ucrCheck
End Class