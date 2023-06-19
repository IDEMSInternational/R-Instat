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
Partial Class dlgStack
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
        Me.lblColumnsTostack = New System.Windows.Forms.Label()
        Me.lblValuesTo = New System.Windows.Forms.Label()
        Me.lblNamesTo = New System.Windows.Forms.Label()
        Me.rdoPivotLonger = New System.Windows.Forms.RadioButton()
        Me.rdoUnnest = New System.Windows.Forms.RadioButton()
        Me.lblToken = New System.Windows.Forms.Label()
        Me.lblFormat = New System.Windows.Forms.Label()
        Me.lblPattern = New System.Windows.Forms.Label()
        Me.ttPattern = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblSets = New System.Windows.Forms.Label()
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.rdoExpand = New System.Windows.Forms.RadioButton()
        Me.lblExpandFactor = New System.Windows.Forms.Label()
        Me.lblFrequencyVar = New System.Windows.Forms.Label()
        Me.rdoCarryAllColumns = New System.Windows.Forms.RadioButton()
        Me.rdoCarryColumns = New System.Windows.Forms.RadioButton()
        Me.ucrChkDropVariables = New instat.ucrCheck()
        Me.ucrPnlCarryColumns = New instat.UcrPanel()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.ucrChkToLowerCase = New instat.ucrCheck()
        Me.ucrInputNamesTo = New instat.ucrInputTextBox()
        Me.ucrNudNoSets = New instat.ucrNud()
        Me.ucrInputDropPrefix = New instat.ucrInputTextBox()
        Me.ucrInputOutput = New instat.ucrInputTextBox()
        Me.ucrReceiverTextColumn = New instat.ucrReceiverSingle()
        Me.ucrPnlStack = New instat.UcrPanel()
        Me.ucrInputValuesTo = New instat.ucrInputTextBox()
        Me.ucrReceiverColumnsToCarry = New instat.ucrReceiverMultiple()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputToken = New instat.ucrInputComboBox()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrChkPunctuation = New instat.ucrCheck()
        Me.ucrChkDropMissingValues = New instat.ucrCheck()
        Me.ucrChkUrl = New instat.ucrCheck()
        Me.ucrChkDropPrefix = New instat.ucrCheck()
        Me.ucrChkStackMultipleSets = New instat.ucrCheck()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrReceiverFrequency = New instat.ucrReceiverSingle()
        Me.ucrReceiverExpand = New instat.ucrReceiverMultiple()
        Me.ucrReceiverDropValues = New instat.ucrReceiverMultiple()
        Me.lblDropValues = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        Me.lblColumnsTostack.AutoSize = True
        Me.lblColumnsTostack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnsTostack.Location = New System.Drawing.Point(256, 65)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(93, 13)
        Me.lblColumnsTostack.TabIndex = 4
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblValuesTo
        '
        Me.lblValuesTo.AutoSize = True
        Me.lblValuesTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValuesTo.Location = New System.Drawing.Point(7, 274)
        Me.lblValuesTo.Name = "lblValuesTo"
        Me.lblValuesTo.Size = New System.Drawing.Size(54, 13)
        Me.lblValuesTo.TabIndex = 10
        Me.lblValuesTo.Tag = "Stack_Data_Into"
        Me.lblValuesTo.Text = "Values to:"
        '
        'lblNamesTo
        '
        Me.lblNamesTo.AutoSize = True
        Me.lblNamesTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNamesTo.Location = New System.Drawing.Point(8, 250)
        Me.lblNamesTo.Name = "lblNamesTo"
        Me.lblNamesTo.Size = New System.Drawing.Size(55, 13)
        Me.lblNamesTo.TabIndex = 8
        Me.lblNamesTo.Tag = ""
        Me.lblNamesTo.Text = "Names to:"
        '
        'rdoPivotLonger
        '
        Me.rdoPivotLonger.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPivotLonger.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPivotLonger.FlatAppearance.BorderSize = 2
        Me.rdoPivotLonger.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPivotLonger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPivotLonger.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPivotLonger.Location = New System.Drawing.Point(76, 12)
        Me.rdoPivotLonger.Name = "rdoPivotLonger"
        Me.rdoPivotLonger.Size = New System.Drawing.Size(95, 28)
        Me.rdoPivotLonger.TabIndex = 1
        Me.rdoPivotLonger.Text = "Pivot Longer"
        Me.rdoPivotLonger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPivotLonger.UseVisualStyleBackColor = True
        '
        'rdoUnnest
        '
        Me.rdoUnnest.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUnnest.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnnest.FlatAppearance.BorderSize = 2
        Me.rdoUnnest.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUnnest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUnnest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUnnest.Location = New System.Drawing.Point(169, 12)
        Me.rdoUnnest.Name = "rdoUnnest"
        Me.rdoUnnest.Size = New System.Drawing.Size(92, 28)
        Me.rdoUnnest.TabIndex = 2
        Me.rdoUnnest.Text = "Unnest"
        Me.rdoUnnest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUnnest.UseVisualStyleBackColor = True
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToken.Location = New System.Drawing.Point(252, 105)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(41, 13)
        Me.lblToken.TabIndex = 8
        Me.lblToken.Text = "Token:"
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormat.Location = New System.Drawing.Point(254, 145)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblFormat.TabIndex = 10
        Me.lblFormat.Text = "Format:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPattern.Location = New System.Drawing.Point(255, 186)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(80, 13)
        Me.lblPattern.TabIndex = 12
        Me.lblPattern.Text = "Pattern/Option:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutput.Location = New System.Drawing.Point(7, 326)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(42, 13)
        Me.lblOutput.TabIndex = 22
        Me.lblOutput.Text = "Output:"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(252, 67)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(48, 13)
        Me.lblVariable.TabIndex = 5
        Me.lblVariable.Tag = "Columns_to_Stack:"
        Me.lblVariable.Text = "Variable:"
        '
        'lblSets
        '
        Me.lblSets.AutoSize = True
        Me.lblSets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSets.Location = New System.Drawing.Point(181, 323)
        Me.lblSets.Name = "lblSets"
        Me.lblSets.Size = New System.Drawing.Size(31, 13)
        Me.lblSets.TabIndex = 31
        Me.lblSets.Text = "Sets:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorInto.Location = New System.Drawing.Point(8, 248)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(61, 13)
        Me.lblFactorInto.TabIndex = 33
        Me.lblFactorInto.Tag = ""
        Me.lblFactorInto.Text = "Factor Into:"
        '
        'rdoExpand
        '
        Me.rdoExpand.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoExpand.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExpand.FlatAppearance.BorderSize = 2
        Me.rdoExpand.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoExpand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoExpand.Location = New System.Drawing.Point(259, 12)
        Me.rdoExpand.Name = "rdoExpand"
        Me.rdoExpand.Size = New System.Drawing.Size(91, 28)
        Me.rdoExpand.TabIndex = 34
        Me.rdoExpand.Text = "Expand"
        Me.rdoExpand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExpand.UseVisualStyleBackColor = True
        '
        'lblExpandFactor
        '
        Me.lblExpandFactor.AutoSize = True
        Me.lblExpandFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpandFactor.Location = New System.Drawing.Point(254, 64)
        Me.lblExpandFactor.Name = "lblExpandFactor"
        Me.lblExpandFactor.Size = New System.Drawing.Size(51, 13)
        Me.lblExpandFactor.TabIndex = 36
        Me.lblExpandFactor.Tag = "Columns_to_Stack:"
        Me.lblExpandFactor.Text = "Factor(s):"
        '
        'lblFrequencyVar
        '
        Me.lblFrequencyVar.AutoSize = True
        Me.lblFrequencyVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrequencyVar.Location = New System.Drawing.Point(255, 189)
        Me.lblFrequencyVar.Name = "lblFrequencyVar"
        Me.lblFrequencyVar.Size = New System.Drawing.Size(68, 13)
        Me.lblFrequencyVar.TabIndex = 38
        Me.lblFrequencyVar.Tag = "Columns_to_Stack:"
        Me.lblFrequencyVar.Text = "Frequencies:"
        '
        'rdoCarryAllColumns
        '
        Me.rdoCarryAllColumns.AutoSize = True
        Me.rdoCarryAllColumns.Location = New System.Drawing.Point(258, 193)
        Me.rdoCarryAllColumns.Name = "rdoCarryAllColumns"
        Me.rdoCarryAllColumns.Size = New System.Drawing.Size(106, 17)
        Me.rdoCarryAllColumns.TabIndex = 40
        Me.rdoCarryAllColumns.TabStop = True
        Me.rdoCarryAllColumns.Text = "Carry All Columns"
        Me.rdoCarryAllColumns.UseVisualStyleBackColor = True
        '
        'rdoCarryColumns
        '
        Me.rdoCarryColumns.AutoSize = True
        Me.rdoCarryColumns.Location = New System.Drawing.Point(258, 215)
        Me.rdoCarryColumns.Name = "rdoCarryColumns"
        Me.rdoCarryColumns.Size = New System.Drawing.Size(92, 17)
        Me.rdoCarryColumns.TabIndex = 41
        Me.rdoCarryColumns.TabStop = True
        Me.rdoCarryColumns.Text = "Carry Columns"
        Me.rdoCarryColumns.UseVisualStyleBackColor = True
        '
        'ucrChkDropVariables
        '
        Me.ucrChkDropVariables.AutoSize = True
        Me.ucrChkDropVariables.Checked = False
        Me.ucrChkDropVariables.Location = New System.Drawing.Point(257, 197)
        Me.ucrChkDropVariables.Name = "ucrChkDropVariables"
        Me.ucrChkDropVariables.Size = New System.Drawing.Size(161, 24)
        Me.ucrChkDropVariables.TabIndex = 42
        '
        'ucrPnlCarryColumns
        '
        Me.ucrPnlCarryColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCarryColumns.Location = New System.Drawing.Point(251, 189)
        Me.ucrPnlCarryColumns.Name = "ucrPnlCarryColumns"
        Me.ucrPnlCarryColumns.Size = New System.Drawing.Size(159, 48)
        Me.ucrPnlCarryColumns.TabIndex = 39
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.AutoSize = True
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(257, 81)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(120, 103)
        Me.ucrReceiverColumnsToBeStack.strNcFilePath = ""
        Me.ucrReceiverColumnsToBeStack.TabIndex = 7
        Me.ucrReceiverColumnsToBeStack.ucrSelector = Nothing
        '
        'ucrChkToLowerCase
        '
        Me.ucrChkToLowerCase.AutoSize = True
        Me.ucrChkToLowerCase.Checked = False
        Me.ucrChkToLowerCase.Location = New System.Drawing.Point(10, 246)
        Me.ucrChkToLowerCase.Name = "ucrChkToLowerCase"
        Me.ucrChkToLowerCase.Size = New System.Drawing.Size(120, 23)
        Me.ucrChkToLowerCase.TabIndex = 17
        '
        'ucrInputNamesTo
        '
        Me.ucrInputNamesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputNamesTo.AutoSize = True
        Me.ucrInputNamesTo.IsMultiline = False
        Me.ucrInputNamesTo.IsReadOnly = False
        Me.ucrInputNamesTo.Location = New System.Drawing.Point(143, 247)
        Me.ucrInputNamesTo.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputNamesTo.Name = "ucrInputNamesTo"
        Me.ucrInputNamesTo.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputNamesTo.TabIndex = 18
        '
        'ucrNudNoSets
        '
        Me.ucrNudNoSets.AutoSize = True
        Me.ucrNudNoSets.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNoSets.Location = New System.Drawing.Point(220, 320)
        Me.ucrNudNoSets.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNoSets.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNoSets.Name = "ucrNudNoSets"
        Me.ucrNudNoSets.Size = New System.Drawing.Size(31, 24)
        Me.ucrNudNoSets.TabIndex = 30
        Me.ucrNudNoSets.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputDropPrefix
        '
        Me.ucrInputDropPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputDropPrefix.AutoSize = True
        Me.ucrInputDropPrefix.IsMultiline = False
        Me.ucrInputDropPrefix.IsReadOnly = False
        Me.ucrInputDropPrefix.Location = New System.Drawing.Point(143, 296)
        Me.ucrInputDropPrefix.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputDropPrefix.Name = "ucrInputDropPrefix"
        Me.ucrInputDropPrefix.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputDropPrefix.TabIndex = 28
        '
        'ucrInputOutput
        '
        Me.ucrInputOutput.AddQuotesIfUnrecognised = True
        Me.ucrInputOutput.AutoSize = True
        Me.ucrInputOutput.IsMultiline = False
        Me.ucrInputOutput.IsReadOnly = False
        Me.ucrInputOutput.Location = New System.Drawing.Point(87, 323)
        Me.ucrInputOutput.Name = "ucrInputOutput"
        Me.ucrInputOutput.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputOutput.TabIndex = 23
        '
        'ucrReceiverTextColumn
        '
        Me.ucrReceiverTextColumn.AutoSize = True
        Me.ucrReceiverTextColumn.frmParent = Me
        Me.ucrReceiverTextColumn.Location = New System.Drawing.Point(256, 81)
        Me.ucrReceiverTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTextColumn.Name = "ucrReceiverTextColumn"
        Me.ucrReceiverTextColumn.Selector = Nothing
        Me.ucrReceiverTextColumn.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverTextColumn.strNcFilePath = ""
        Me.ucrReceiverTextColumn.TabIndex = 6
        Me.ucrReceiverTextColumn.ucrSelector = Nothing
        '
        'ucrPnlStack
        '
        Me.ucrPnlStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStack.Location = New System.Drawing.Point(67, 3)
        Me.ucrPnlStack.Name = "ucrPnlStack"
        Me.ucrPnlStack.Size = New System.Drawing.Size(299, 49)
        Me.ucrPnlStack.TabIndex = 0
        '
        'ucrInputValuesTo
        '
        Me.ucrInputValuesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputValuesTo.AutoSize = True
        Me.ucrInputValuesTo.IsMultiline = False
        Me.ucrInputValuesTo.IsReadOnly = False
        Me.ucrInputValuesTo.Location = New System.Drawing.Point(143, 272)
        Me.ucrInputValuesTo.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrInputValuesTo.Name = "ucrInputValuesTo"
        Me.ucrInputValuesTo.Size = New System.Drawing.Size(75, 21)
        Me.ucrInputValuesTo.TabIndex = 20
        '
        'ucrReceiverColumnsToCarry
        '
        Me.ucrReceiverColumnsToCarry.AutoSize = True
        Me.ucrReceiverColumnsToCarry.frmParent = Me
        Me.ucrReceiverColumnsToCarry.Location = New System.Drawing.Point(259, 240)
        Me.ucrReceiverColumnsToCarry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToCarry.Name = "ucrReceiverColumnsToCarry"
        Me.ucrReceiverColumnsToCarry.Selector = Nothing
        Me.ucrReceiverColumnsToCarry.Size = New System.Drawing.Size(120, 97)
        Me.ucrReceiverColumnsToCarry.strNcFilePath = ""
        Me.ucrReceiverColumnsToCarry.TabIndex = 16
        Me.ucrReceiverColumnsToCarry.ucrSelector = Nothing
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.AutoSize = True
        Me.ucrSelectorStack.bDropUnusedFilterLevels = False
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        Me.ucrSelectorStack.Location = New System.Drawing.Point(10, 55)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorStack.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 387)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 25
        '
        'ucrInputToken
        '
        Me.ucrInputToken.AddQuotesIfUnrecognised = True
        Me.ucrInputToken.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputToken.GetSetSelectedIndex = -1
        Me.ucrInputToken.IsReadOnly = False
        Me.ucrInputToken.Location = New System.Drawing.Point(257, 119)
        Me.ucrInputToken.Name = "ucrInputToken"
        Me.ucrInputToken.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputToken.TabIndex = 9
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFormat.GetSetSelectedIndex = -1
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(256, 160)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputFormat.TabIndex = 11
        '
        'ucrChkPunctuation
        '
        Me.ucrChkPunctuation.AutoSize = True
        Me.ucrChkPunctuation.Checked = False
        Me.ucrChkPunctuation.Location = New System.Drawing.Point(10, 273)
        Me.ucrChkPunctuation.Name = "ucrChkPunctuation"
        Me.ucrChkPunctuation.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkPunctuation.TabIndex = 19
        '
        'ucrChkDropMissingValues
        '
        Me.ucrChkDropMissingValues.AutoSize = True
        Me.ucrChkDropMissingValues.Checked = False
        Me.ucrChkDropMissingValues.Location = New System.Drawing.Point(10, 343)
        Me.ucrChkDropMissingValues.Name = "ucrChkDropMissingValues"
        Me.ucrChkDropMissingValues.Size = New System.Drawing.Size(193, 23)
        Me.ucrChkDropMissingValues.TabIndex = 26
        '
        'ucrChkUrl
        '
        Me.ucrChkUrl.AutoSize = True
        Me.ucrChkUrl.Checked = False
        Me.ucrChkUrl.Location = New System.Drawing.Point(10, 297)
        Me.ucrChkUrl.Name = "ucrChkUrl"
        Me.ucrChkUrl.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkUrl.TabIndex = 21
        '
        'ucrChkDropPrefix
        '
        Me.ucrChkDropPrefix.AutoSize = True
        Me.ucrChkDropPrefix.Checked = False
        Me.ucrChkDropPrefix.Location = New System.Drawing.Point(10, 297)
        Me.ucrChkDropPrefix.Name = "ucrChkDropPrefix"
        Me.ucrChkDropPrefix.Size = New System.Drawing.Size(193, 23)
        Me.ucrChkDropPrefix.TabIndex = 27
        '
        'ucrChkStackMultipleSets
        '
        Me.ucrChkStackMultipleSets.AutoSize = True
        Me.ucrChkStackMultipleSets.Checked = False
        Me.ucrChkStackMultipleSets.Location = New System.Drawing.Point(10, 320)
        Me.ucrChkStackMultipleSets.Name = "ucrChkStackMultipleSets"
        Me.ucrChkStackMultipleSets.Size = New System.Drawing.Size(231, 24)
        Me.ucrChkStackMultipleSets.TabIndex = 29
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.AddQuotesIfUnrecognised = True
        Me.ucrFactorInto.AutoSize = True
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(82, 245)
        Me.ucrFactorInto.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(75, 21)
        Me.ucrFactorInto.TabIndex = 32
        '
        'ucrSaveNewDataName
        '
        Me.ucrSaveNewDataName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataName.Location = New System.Drawing.Point(8, 364)
        Me.ucrSaveNewDataName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        Me.ucrSaveNewDataName.Size = New System.Drawing.Size(372, 20)
        Me.ucrSaveNewDataName.TabIndex = 24
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(257, 202)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputPattern.TabIndex = 13
        '
        'ucrReceiverFrequency
        '
        Me.ucrReceiverFrequency.AutoSize = True
        Me.ucrReceiverFrequency.frmParent = Me
        Me.ucrReceiverFrequency.Location = New System.Drawing.Point(257, 204)
        Me.ucrReceiverFrequency.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrequency.Name = "ucrReceiverFrequency"
        Me.ucrReceiverFrequency.Selector = Nothing
        Me.ucrReceiverFrequency.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFrequency.strNcFilePath = ""
        Me.ucrReceiverFrequency.TabIndex = 37
        Me.ucrReceiverFrequency.ucrSelector = Nothing
        '
        'ucrReceiverExpand
        '
        Me.ucrReceiverExpand.AutoSize = True
        Me.ucrReceiverExpand.frmParent = Me
        Me.ucrReceiverExpand.Location = New System.Drawing.Point(256, 81)
        Me.ucrReceiverExpand.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExpand.Name = "ucrReceiverExpand"
        Me.ucrReceiverExpand.Selector = Nothing
        Me.ucrReceiverExpand.Size = New System.Drawing.Size(120, 103)
        Me.ucrReceiverExpand.strNcFilePath = ""
        Me.ucrReceiverExpand.TabIndex = 35
        Me.ucrReceiverExpand.ucrSelector = Nothing
        '
        'ucrReceiverDropValues
        '
        Me.ucrReceiverDropValues.AutoSize = True
        Me.ucrReceiverDropValues.frmParent = Me
        Me.ucrReceiverDropValues.Location = New System.Drawing.Point(257, 240)
        Me.ucrReceiverDropValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDropValues.Name = "ucrReceiverDropValues"
        Me.ucrReceiverDropValues.Selector = Nothing
        Me.ucrReceiverDropValues.Size = New System.Drawing.Size(120, 97)
        Me.ucrReceiverDropValues.strNcFilePath = ""
        Me.ucrReceiverDropValues.TabIndex = 43
        Me.ucrReceiverDropValues.ucrSelector = Nothing
        '
        'lblDropValues
        '
        Me.lblDropValues.AutoSize = True
        Me.lblDropValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDropValues.Location = New System.Drawing.Point(257, 221)
        Me.lblDropValues.Name = "lblDropValues"
        Me.lblDropValues.Size = New System.Drawing.Size(85, 13)
        Me.lblDropValues.TabIndex = 44
        Me.lblDropValues.Tag = "Columns_to_Stack:"
        Me.lblDropValues.Text = "Drop Variable(s):"
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(422, 442)
        Me.Controls.Add(Me.ucrNudNoSets)
        Me.Controls.Add(Me.ucrReceiverDropValues)
        Me.Controls.Add(Me.lblDropValues)
        Me.Controls.Add(Me.rdoCarryColumns)
        Me.Controls.Add(Me.ucrReceiverColumnsToBeStack)
        Me.Controls.Add(Me.lblExpandFactor)
        Me.Controls.Add(Me.rdoExpand)
        Me.Controls.Add(Me.ucrChkToLowerCase)
        Me.Controls.Add(Me.ucrInputNamesTo)
        Me.Controls.Add(Me.lblSets)
        Me.Controls.Add(Me.ucrInputDropPrefix)
        Me.Controls.Add(Me.ucrInputOutput)
        Me.Controls.Add(Me.ucrReceiverTextColumn)
        Me.Controls.Add(Me.rdoUnnest)
        Me.Controls.Add(Me.rdoPivotLonger)
        Me.Controls.Add(Me.ucrPnlStack)
        Me.Controls.Add(Me.ucrInputValuesTo)
        Me.Controls.Add(Me.ucrSelectorStack)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrInputToken)
        Me.Controls.Add(Me.ucrInputFormat)
        Me.Controls.Add(Me.ucrChkPunctuation)
        Me.Controls.Add(Me.lblValuesTo)
        Me.Controls.Add(Me.ucrChkUrl)
        Me.Controls.Add(Me.ucrChkDropPrefix)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.ucrChkStackMultipleSets)
        Me.Controls.Add(Me.ucrFactorInto)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.lblNamesTo)
        Me.Controls.Add(Me.lblFactorInto)
        Me.Controls.Add(Me.lblPattern)
        Me.Controls.Add(Me.ucrInputPattern)
        Me.Controls.Add(Me.lblFrequencyVar)
        Me.Controls.Add(Me.ucrReceiverFrequency)
        Me.Controls.Add(Me.lblColumnsTostack)
        Me.Controls.Add(Me.ucrReceiverExpand)
        Me.Controls.Add(Me.lblFormat)
        Me.Controls.Add(Me.lblToken)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.ucrReceiverColumnsToCarry)
        Me.Controls.Add(Me.ucrChkDropVariables)
        Me.Controls.Add(Me.rdoCarryAllColumns)
        Me.Controls.Add(Me.ucrPnlCarryColumns)
        Me.Controls.Add(Me.ucrChkDropMissingValues)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStack"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Stack_join_columns"
        Me.Text = "Stack (Pivot Longer)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrReceiverColumnsToBeStack As ucrReceiverMultiple
    Friend WithEvents lblColumnsTostack As Label
    Friend WithEvents lblValuesTo As Label
    Friend WithEvents lblNamesTo As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorStack As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverColumnsToCarry As ucrReceiverMultiple
    Friend WithEvents ucrInputNamesTo As ucrInputTextBox
    Friend WithEvents ucrInputValuesTo As ucrInputTextBox
    Friend WithEvents ucrSaveNewDataName As ucrSave
    Friend WithEvents ucrPnlStack As UcrPanel
    Friend WithEvents rdoUnnest As RadioButton
    Friend WithEvents rdoPivotLonger As RadioButton
    Friend WithEvents ucrReceiverTextColumn As ucrReceiverSingle
    Friend WithEvents ucrInputToken As ucrInputComboBox
    Friend WithEvents lblToken As Label
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents lblFormat As Label
    Friend WithEvents ucrChkToLowerCase As ucrCheck
    Friend WithEvents lblPattern As Label
    Friend WithEvents ucrInputPattern As ucrInputTextBox
    Friend WithEvents ttPattern As ToolTip
    Friend WithEvents ucrChkUrl As ucrCheck
    Friend WithEvents ucrChkPunctuation As ucrCheck
    Friend WithEvents ucrInputOutput As ucrInputTextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents ucrChkDropMissingValues As ucrCheck
    Friend WithEvents ucrChkDropPrefix As ucrCheck
    Friend WithEvents ucrInputDropPrefix As ucrInputTextBox
    Friend WithEvents lblSets As Label
    Friend WithEvents ucrNudNoSets As ucrNud
    Friend WithEvents ucrChkStackMultipleSets As ucrCheck
    Friend WithEvents ucrFactorInto As ucrInputTextBox
    Friend WithEvents lblFactorInto As Label
    Friend WithEvents lblFrequencyVar As Label
    Friend WithEvents ucrReceiverFrequency As ucrReceiverSingle
    Friend WithEvents lblExpandFactor As Label
    Friend WithEvents ucrReceiverExpand As ucrReceiverMultiple
    Friend WithEvents rdoExpand As RadioButton
    Friend WithEvents rdoCarryColumns As RadioButton
    Friend WithEvents rdoCarryAllColumns As RadioButton
    Friend WithEvents ucrPnlCarryColumns As UcrPanel
    Friend WithEvents ucrChkDropVariables As ucrCheck
    Friend WithEvents ucrReceiverDropValues As ucrReceiverMultiple
    Friend WithEvents lblDropValues As Label
End Class
