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
        Me.lblFactorInto = New System.Windows.Forms.Label()
        Me.rdoExpand = New System.Windows.Forms.RadioButton()
        Me.lblExpandFactor = New System.Windows.Forms.Label()
        Me.lblFrequencyVar = New System.Windows.Forms.Label()
        Me.rdoCarryAllColumns = New System.Windows.Forms.RadioButton()
        Me.rdoCarryColumns = New System.Windows.Forms.RadioButton()
        Me.lblDropValues = New System.Windows.Forms.Label()
        Me.ucrSaveNewDataName = New instat.ucrSave()
        Me.ucrReceiverDropValues = New instat.ucrReceiverMultiple()
        Me.ucrReceiverColumnsToBeStack = New instat.ucrReceiverMultiple()
        Me.ucrChkToLowerCase = New instat.ucrCheck()
        Me.ucrInputNamesTo = New instat.ucrInputTextBox()
        Me.ucrInputDropPrefix = New instat.ucrInputTextBox()
        Me.ucrInputOutput = New instat.ucrInputTextBox()
        Me.ucrReceiverTextColumn = New instat.ucrReceiverSingle()
        Me.ucrPnlStack = New instat.UcrPanel()
        Me.ucrInputValuesTo = New instat.ucrInputTextBox()
        Me.ucrSelectorStack = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputToken = New instat.ucrInputComboBox()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrChkPunctuation = New instat.ucrCheck()
        Me.ucrChkUrl = New instat.ucrCheck()
        Me.ucrChkDropPrefix = New instat.ucrCheck()
        Me.ucrChkStackMultipleSets = New instat.ucrCheck()
        Me.ucrFactorInto = New instat.ucrInputTextBox()
        Me.ucrInputPattern = New instat.ucrInputTextBox()
        Me.ucrReceiverFrequency = New instat.ucrReceiverSingle()
        Me.ucrReceiverExpand = New instat.ucrReceiverMultiple()
        Me.ucrReceiverColumnsToCarry = New instat.ucrReceiverMultiple()
        Me.ucrChkDropVariables = New instat.ucrCheck()
        Me.ucrPnlCarryColumns = New instat.UcrPanel()
        Me.ucrChkDropMissingValues = New instat.ucrCheck()
        Me.lblSets = New System.Windows.Forms.Label()
        Me.ucrInputNamesSep = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'lblColumnsTostack
        '
        Me.lblColumnsTostack.AutoSize = True
        Me.lblColumnsTostack.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnsTostack.Location = New System.Drawing.Point(466, 98)
        Me.lblColumnsTostack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnsTostack.Name = "lblColumnsTostack"
        Me.lblColumnsTostack.Size = New System.Drawing.Size(138, 20)
        Me.lblColumnsTostack.TabIndex = 4
        Me.lblColumnsTostack.Tag = "Columns_to_Stack:"
        Me.lblColumnsTostack.Text = "Columns to Stack:"
        '
        'lblValuesTo
        '
        Me.lblValuesTo.AutoSize = True
        Me.lblValuesTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblValuesTo.Location = New System.Drawing.Point(10, 411)
        Me.lblValuesTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValuesTo.Name = "lblValuesTo"
        Me.lblValuesTo.Size = New System.Drawing.Size(80, 20)
        Me.lblValuesTo.TabIndex = 10
        Me.lblValuesTo.Tag = "Stack_Data_Into"
        Me.lblValuesTo.Text = "Values to:"
        '
        'lblNamesTo
        '
        Me.lblNamesTo.AutoSize = True
        Me.lblNamesTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNamesTo.Location = New System.Drawing.Point(12, 375)
        Me.lblNamesTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNamesTo.Name = "lblNamesTo"
        Me.lblNamesTo.Size = New System.Drawing.Size(81, 20)
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
        Me.rdoPivotLonger.Location = New System.Drawing.Point(114, 18)
        Me.rdoPivotLonger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoPivotLonger.Name = "rdoPivotLonger"
        Me.rdoPivotLonger.Size = New System.Drawing.Size(142, 42)
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
        Me.rdoUnnest.Location = New System.Drawing.Point(254, 18)
        Me.rdoUnnest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoUnnest.Name = "rdoUnnest"
        Me.rdoUnnest.Size = New System.Drawing.Size(138, 42)
        Me.rdoUnnest.TabIndex = 2
        Me.rdoUnnest.Text = "Unnest"
        Me.rdoUnnest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUnnest.UseVisualStyleBackColor = True
        '
        'lblToken
        '
        Me.lblToken.AutoSize = True
        Me.lblToken.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToken.Location = New System.Drawing.Point(462, 158)
        Me.lblToken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToken.Name = "lblToken"
        Me.lblToken.Size = New System.Drawing.Size(57, 20)
        Me.lblToken.TabIndex = 8
        Me.lblToken.Text = "Token:"
        '
        'lblFormat
        '
        Me.lblFormat.AutoSize = True
        Me.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFormat.Location = New System.Drawing.Point(465, 218)
        Me.lblFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormat.Name = "lblFormat"
        Me.lblFormat.Size = New System.Drawing.Size(64, 20)
        Me.lblFormat.TabIndex = 10
        Me.lblFormat.Text = "Format:"
        '
        'lblPattern
        '
        Me.lblPattern.AutoSize = True
        Me.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPattern.Location = New System.Drawing.Point(465, 279)
        Me.lblPattern.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPattern.Name = "lblPattern"
        Me.lblPattern.Size = New System.Drawing.Size(116, 20)
        Me.lblPattern.TabIndex = 12
        Me.lblPattern.Text = "Pattern/Option:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblOutput.Location = New System.Drawing.Point(10, 489)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(62, 20)
        Me.lblOutput.TabIndex = 22
        Me.lblOutput.Text = "Output:"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVariable.Location = New System.Drawing.Point(460, 100)
        Me.lblVariable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(71, 20)
        Me.lblVariable.TabIndex = 5
        Me.lblVariable.Tag = "Columns_to_Stack:"
        Me.lblVariable.Text = "Variable:"
        '
        'lblFactorInto
        '
        Me.lblFactorInto.AutoSize = True
        Me.lblFactorInto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactorInto.Location = New System.Drawing.Point(12, 372)
        Me.lblFactorInto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactorInto.Name = "lblFactorInto"
        Me.lblFactorInto.Size = New System.Drawing.Size(91, 20)
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
        Me.rdoExpand.Location = New System.Drawing.Point(388, 18)
        Me.rdoExpand.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoExpand.Name = "rdoExpand"
        Me.rdoExpand.Size = New System.Drawing.Size(136, 42)
        Me.rdoExpand.TabIndex = 34
        Me.rdoExpand.Text = "Expand"
        Me.rdoExpand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoExpand.UseVisualStyleBackColor = True
        '
        'lblExpandFactor
        '
        Me.lblExpandFactor.AutoSize = True
        Me.lblExpandFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpandFactor.Location = New System.Drawing.Point(464, 96)
        Me.lblExpandFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExpandFactor.Name = "lblExpandFactor"
        Me.lblExpandFactor.Size = New System.Drawing.Size(77, 20)
        Me.lblExpandFactor.TabIndex = 36
        Me.lblExpandFactor.Tag = "Columns_to_Stack:"
        Me.lblExpandFactor.Text = "Factor(s):"
        '
        'lblFrequencyVar
        '
        Me.lblFrequencyVar.AutoSize = True
        Me.lblFrequencyVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrequencyVar.Location = New System.Drawing.Point(466, 284)
        Me.lblFrequencyVar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrequencyVar.Name = "lblFrequencyVar"
        Me.lblFrequencyVar.Size = New System.Drawing.Size(101, 20)
        Me.lblFrequencyVar.TabIndex = 38
        Me.lblFrequencyVar.Tag = "Columns_to_Stack:"
        Me.lblFrequencyVar.Text = "Frequencies:"
        '
        'rdoCarryAllColumns
        '
        Me.rdoCarryAllColumns.AutoSize = True
        Me.rdoCarryAllColumns.Location = New System.Drawing.Point(470, 284)
        Me.rdoCarryAllColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCarryAllColumns.Name = "rdoCarryAllColumns"
        Me.rdoCarryAllColumns.Size = New System.Drawing.Size(158, 24)
        Me.rdoCarryAllColumns.TabIndex = 40
        Me.rdoCarryAllColumns.TabStop = True
        Me.rdoCarryAllColumns.Text = "Carry All Columns"
        Me.rdoCarryAllColumns.UseVisualStyleBackColor = True
        '
        'rdoCarryColumns
        '
        Me.rdoCarryColumns.AutoSize = True
        Me.rdoCarryColumns.Location = New System.Drawing.Point(470, 322)
        Me.rdoCarryColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoCarryColumns.Name = "rdoCarryColumns"
        Me.rdoCarryColumns.Size = New System.Drawing.Size(137, 24)
        Me.rdoCarryColumns.TabIndex = 41
        Me.rdoCarryColumns.TabStop = True
        Me.rdoCarryColumns.Text = "Carry Columns"
        Me.rdoCarryColumns.UseVisualStyleBackColor = True
        '
        'lblDropValues
        '
        Me.lblDropValues.AutoSize = True
        Me.lblDropValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDropValues.Location = New System.Drawing.Point(468, 332)
        Me.lblDropValues.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDropValues.Name = "lblDropValues"
        Me.lblDropValues.Size = New System.Drawing.Size(128, 20)
        Me.lblDropValues.TabIndex = 44
        Me.lblDropValues.Tag = "Columns_to_Stack:"
        Me.lblDropValues.Text = "Drop Variable(s):"
        '
        'ucrSaveNewDataName
        '
        Me.ucrSaveNewDataName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveNewDataName.Location = New System.Drawing.Point(15, 548)
        Me.ucrSaveNewDataName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveNewDataName.Name = "ucrSaveNewDataName"
        Me.ucrSaveNewDataName.Size = New System.Drawing.Size(604, 33)
        Me.ucrSaveNewDataName.TabIndex = 45
        '
        'ucrReceiverDropValues
        '
        Me.ucrReceiverDropValues.AutoSize = True
        Me.ucrReceiverDropValues.frmParent = Me
        Me.ucrReceiverDropValues.Location = New System.Drawing.Point(468, 360)
        Me.ucrReceiverDropValues.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDropValues.Name = "ucrReceiverDropValues"
        Me.ucrReceiverDropValues.Selector = Nothing
        Me.ucrReceiverDropValues.Size = New System.Drawing.Size(180, 146)
        Me.ucrReceiverDropValues.strNcFilePath = ""
        Me.ucrReceiverDropValues.TabIndex = 43
        Me.ucrReceiverDropValues.ucrSelector = Nothing
        '
        'ucrReceiverColumnsToBeStack
        '
        Me.ucrReceiverColumnsToBeStack.AutoSize = True
        Me.ucrReceiverColumnsToBeStack.frmParent = Me
        Me.ucrReceiverColumnsToBeStack.Location = New System.Drawing.Point(468, 122)
        Me.ucrReceiverColumnsToBeStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToBeStack.Name = "ucrReceiverColumnsToBeStack"
        Me.ucrReceiverColumnsToBeStack.Selector = Nothing
        Me.ucrReceiverColumnsToBeStack.Size = New System.Drawing.Size(180, 154)
        Me.ucrReceiverColumnsToBeStack.strNcFilePath = ""
        Me.ucrReceiverColumnsToBeStack.TabIndex = 7
        Me.ucrReceiverColumnsToBeStack.ucrSelector = Nothing
        '
        'ucrChkToLowerCase
        '
        Me.ucrChkToLowerCase.AutoSize = True
        Me.ucrChkToLowerCase.Checked = False
        Me.ucrChkToLowerCase.Location = New System.Drawing.Point(15, 369)
        Me.ucrChkToLowerCase.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkToLowerCase.Name = "ucrChkToLowerCase"
        Me.ucrChkToLowerCase.Size = New System.Drawing.Size(180, 34)
        Me.ucrChkToLowerCase.TabIndex = 17
        '
        'ucrInputNamesTo
        '
        Me.ucrInputNamesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputNamesTo.AutoSize = True
        Me.ucrInputNamesTo.IsMultiline = False
        Me.ucrInputNamesTo.IsReadOnly = False
        Me.ucrInputNamesTo.Location = New System.Drawing.Point(214, 370)
        Me.ucrInputNamesTo.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputNamesTo.Name = "ucrInputNamesTo"
        Me.ucrInputNamesTo.Size = New System.Drawing.Size(112, 32)
        Me.ucrInputNamesTo.TabIndex = 18
        '
        'ucrInputDropPrefix
        '
        Me.ucrInputDropPrefix.AddQuotesIfUnrecognised = True
        Me.ucrInputDropPrefix.AutoSize = True
        Me.ucrInputDropPrefix.IsMultiline = False
        Me.ucrInputDropPrefix.IsReadOnly = False
        Me.ucrInputDropPrefix.Location = New System.Drawing.Point(214, 444)
        Me.ucrInputDropPrefix.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputDropPrefix.Name = "ucrInputDropPrefix"
        Me.ucrInputDropPrefix.Size = New System.Drawing.Size(112, 32)
        Me.ucrInputDropPrefix.TabIndex = 28
        '
        'ucrInputOutput
        '
        Me.ucrInputOutput.AddQuotesIfUnrecognised = True
        Me.ucrInputOutput.AutoSize = True
        Me.ucrInputOutput.IsMultiline = False
        Me.ucrInputOutput.IsReadOnly = False
        Me.ucrInputOutput.Location = New System.Drawing.Point(130, 484)
        Me.ucrInputOutput.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputOutput.Name = "ucrInputOutput"
        Me.ucrInputOutput.Size = New System.Drawing.Size(112, 32)
        Me.ucrInputOutput.TabIndex = 23
        '
        'ucrReceiverTextColumn
        '
        Me.ucrReceiverTextColumn.AutoSize = True
        Me.ucrReceiverTextColumn.frmParent = Me
        Me.ucrReceiverTextColumn.Location = New System.Drawing.Point(466, 122)
        Me.ucrReceiverTextColumn.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTextColumn.Name = "ucrReceiverTextColumn"
        Me.ucrReceiverTextColumn.Selector = Nothing
        Me.ucrReceiverTextColumn.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverTextColumn.strNcFilePath = ""
        Me.ucrReceiverTextColumn.TabIndex = 6
        Me.ucrReceiverTextColumn.ucrSelector = Nothing
        '
        'ucrPnlStack
        '
        Me.ucrPnlStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlStack.Location = New System.Drawing.Point(100, 4)
        Me.ucrPnlStack.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlStack.Name = "ucrPnlStack"
        Me.ucrPnlStack.Size = New System.Drawing.Size(448, 74)
        Me.ucrPnlStack.TabIndex = 0
        '
        'ucrInputValuesTo
        '
        Me.ucrInputValuesTo.AddQuotesIfUnrecognised = True
        Me.ucrInputValuesTo.AutoSize = True
        Me.ucrInputValuesTo.IsMultiline = False
        Me.ucrInputValuesTo.IsReadOnly = False
        Me.ucrInputValuesTo.Location = New System.Drawing.Point(214, 408)
        Me.ucrInputValuesTo.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputValuesTo.Name = "ucrInputValuesTo"
        Me.ucrInputValuesTo.Size = New System.Drawing.Size(112, 32)
        Me.ucrInputValuesTo.TabIndex = 20
        '
        'ucrSelectorStack
        '
        Me.ucrSelectorStack.AutoSize = True
        Me.ucrSelectorStack.bDropUnusedFilterLevels = False
        Me.ucrSelectorStack.bShowHiddenColumns = False
        Me.ucrSelectorStack.bUseCurrentFilter = True
        Me.ucrSelectorStack.Location = New System.Drawing.Point(15, 82)
        Me.ucrSelectorStack.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorStack.Name = "ucrSelectorStack"
        Me.ucrSelectorStack.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorStack.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 580)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 25
        '
        'ucrInputToken
        '
        Me.ucrInputToken.AddQuotesIfUnrecognised = True
        Me.ucrInputToken.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputToken.GetSetSelectedIndex = -1
        Me.ucrInputToken.IsReadOnly = False
        Me.ucrInputToken.Location = New System.Drawing.Point(468, 178)
        Me.ucrInputToken.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputToken.Name = "ucrInputToken"
        Me.ucrInputToken.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputToken.TabIndex = 9
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFormat.GetSetSelectedIndex = -1
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(466, 240)
        Me.ucrInputFormat.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputFormat.TabIndex = 11
        '
        'ucrChkPunctuation
        '
        Me.ucrChkPunctuation.AutoSize = True
        Me.ucrChkPunctuation.Checked = False
        Me.ucrChkPunctuation.Location = New System.Drawing.Point(15, 410)
        Me.ucrChkPunctuation.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkPunctuation.Name = "ucrChkPunctuation"
        Me.ucrChkPunctuation.Size = New System.Drawing.Size(234, 34)
        Me.ucrChkPunctuation.TabIndex = 19
        '
        'ucrChkUrl
        '
        Me.ucrChkUrl.AutoSize = True
        Me.ucrChkUrl.Checked = False
        Me.ucrChkUrl.Location = New System.Drawing.Point(15, 446)
        Me.ucrChkUrl.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkUrl.Name = "ucrChkUrl"
        Me.ucrChkUrl.Size = New System.Drawing.Size(234, 34)
        Me.ucrChkUrl.TabIndex = 21
        '
        'ucrChkDropPrefix
        '
        Me.ucrChkDropPrefix.AutoSize = True
        Me.ucrChkDropPrefix.Checked = False
        Me.ucrChkDropPrefix.Location = New System.Drawing.Point(15, 446)
        Me.ucrChkDropPrefix.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDropPrefix.Name = "ucrChkDropPrefix"
        Me.ucrChkDropPrefix.Size = New System.Drawing.Size(290, 34)
        Me.ucrChkDropPrefix.TabIndex = 27
        '
        'ucrChkStackMultipleSets
        '
        Me.ucrChkStackMultipleSets.AutoSize = True
        Me.ucrChkStackMultipleSets.Checked = False
        Me.ucrChkStackMultipleSets.Location = New System.Drawing.Point(15, 480)
        Me.ucrChkStackMultipleSets.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkStackMultipleSets.Name = "ucrChkStackMultipleSets"
        Me.ucrChkStackMultipleSets.Size = New System.Drawing.Size(346, 36)
        Me.ucrChkStackMultipleSets.TabIndex = 29
        '
        'ucrFactorInto
        '
        Me.ucrFactorInto.AddQuotesIfUnrecognised = True
        Me.ucrFactorInto.AutoSize = True
        Me.ucrFactorInto.IsMultiline = False
        Me.ucrFactorInto.IsReadOnly = False
        Me.ucrFactorInto.Location = New System.Drawing.Point(123, 368)
        Me.ucrFactorInto.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrFactorInto.Name = "ucrFactorInto"
        Me.ucrFactorInto.Size = New System.Drawing.Size(112, 32)
        Me.ucrFactorInto.TabIndex = 32
        '
        'ucrInputPattern
        '
        Me.ucrInputPattern.AddQuotesIfUnrecognised = True
        Me.ucrInputPattern.AutoSize = True
        Me.ucrInputPattern.IsMultiline = False
        Me.ucrInputPattern.IsReadOnly = False
        Me.ucrInputPattern.Location = New System.Drawing.Point(468, 303)
        Me.ucrInputPattern.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputPattern.Name = "ucrInputPattern"
        Me.ucrInputPattern.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputPattern.TabIndex = 13
        '
        'ucrReceiverFrequency
        '
        Me.ucrReceiverFrequency.AutoSize = True
        Me.ucrReceiverFrequency.frmParent = Me
        Me.ucrReceiverFrequency.Location = New System.Drawing.Point(468, 306)
        Me.ucrReceiverFrequency.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFrequency.Name = "ucrReceiverFrequency"
        Me.ucrReceiverFrequency.Selector = Nothing
        Me.ucrReceiverFrequency.Size = New System.Drawing.Size(180, 30)
        Me.ucrReceiverFrequency.strNcFilePath = ""
        Me.ucrReceiverFrequency.TabIndex = 37
        Me.ucrReceiverFrequency.ucrSelector = Nothing
        '
        'ucrReceiverExpand
        '
        Me.ucrReceiverExpand.AutoSize = True
        Me.ucrReceiverExpand.frmParent = Me
        Me.ucrReceiverExpand.Location = New System.Drawing.Point(466, 122)
        Me.ucrReceiverExpand.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverExpand.Name = "ucrReceiverExpand"
        Me.ucrReceiverExpand.Selector = Nothing
        Me.ucrReceiverExpand.Size = New System.Drawing.Size(180, 154)
        Me.ucrReceiverExpand.strNcFilePath = ""
        Me.ucrReceiverExpand.TabIndex = 35
        Me.ucrReceiverExpand.ucrSelector = Nothing
        '
        'ucrReceiverColumnsToCarry
        '
        Me.ucrReceiverColumnsToCarry.AutoSize = True
        Me.ucrReceiverColumnsToCarry.frmParent = Me
        Me.ucrReceiverColumnsToCarry.Location = New System.Drawing.Point(471, 360)
        Me.ucrReceiverColumnsToCarry.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverColumnsToCarry.Name = "ucrReceiverColumnsToCarry"
        Me.ucrReceiverColumnsToCarry.Selector = Nothing
        Me.ucrReceiverColumnsToCarry.Size = New System.Drawing.Size(180, 146)
        Me.ucrReceiverColumnsToCarry.strNcFilePath = ""
        Me.ucrReceiverColumnsToCarry.TabIndex = 16
        Me.ucrReceiverColumnsToCarry.ucrSelector = Nothing
        '
        'ucrChkDropVariables
        '
        Me.ucrChkDropVariables.AutoSize = True
        Me.ucrChkDropVariables.Checked = False
        Me.ucrChkDropVariables.Location = New System.Drawing.Point(468, 296)
        Me.ucrChkDropVariables.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDropVariables.Name = "ucrChkDropVariables"
        Me.ucrChkDropVariables.Size = New System.Drawing.Size(242, 36)
        Me.ucrChkDropVariables.TabIndex = 42
        '
        'ucrPnlCarryColumns
        '
        Me.ucrPnlCarryColumns.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCarryColumns.Location = New System.Drawing.Point(388, 284)
        Me.ucrPnlCarryColumns.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlCarryColumns.Name = "ucrPnlCarryColumns"
        Me.ucrPnlCarryColumns.Size = New System.Drawing.Size(344, 72)
        Me.ucrPnlCarryColumns.TabIndex = 39
        '
        'ucrChkDropMissingValues
        '
        Me.ucrChkDropMissingValues.AutoSize = True
        Me.ucrChkDropMissingValues.Checked = False
        Me.ucrChkDropMissingValues.Location = New System.Drawing.Point(15, 514)
        Me.ucrChkDropMissingValues.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkDropMissingValues.Name = "ucrChkDropMissingValues"
        Me.ucrChkDropMissingValues.Size = New System.Drawing.Size(290, 34)
        Me.ucrChkDropMissingValues.TabIndex = 26
        '
        'lblSets
        '
        Me.lblSets.AutoSize = True
        Me.lblSets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSets.Location = New System.Drawing.Point(10, 446)
        Me.lblSets.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSets.Name = "lblSets"
        Me.lblSets.Size = New System.Drawing.Size(108, 20)
        Me.lblSets.TabIndex = 31
        Me.lblSets.Text = "Separated by:"
        '
        'ucrInputNamesSep
        '
        Me.ucrInputNamesSep.AddQuotesIfUnrecognised = True
        Me.ucrInputNamesSep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNamesSep.GetSetSelectedIndex = -1
        Me.ucrInputNamesSep.IsReadOnly = False
        Me.ucrInputNamesSep.Location = New System.Drawing.Point(145, 446)
        Me.ucrInputNamesSep.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputNamesSep.Name = "ucrInputNamesSep"
        Me.ucrInputNamesSep.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputNamesSep.TabIndex = 46
        '
        'dlgStack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(724, 663)
        Me.Controls.Add(Me.ucrInputNamesSep)
        Me.Controls.Add(Me.ucrSaveNewDataName)
        Me.Controls.Add(Me.rdoCarryAllColumns)
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
        Me.Controls.Add(Me.ucrPnlCarryColumns)
        Me.Controls.Add(Me.ucrChkDropMissingValues)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents ucrSaveNewDataName As ucrSave
    Friend WithEvents ucrInputNamesSep As ucrInputComboBox
    Friend WithEvents lblSets As Label
End Class
