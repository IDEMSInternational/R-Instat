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
Partial Class ucrFilter
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSelectLevels = New System.Windows.Forms.Label()
        Me.cmdAddCondition = New System.Windows.Forms.Button()
        Me.cmdToggleSelectAll = New System.Windows.Forms.Button()
        Me.lstFilters = New System.Windows.Forms.ListView()
        Me.lblFilterPreview = New System.Windows.Forms.Label()
        Me.lblFilterBy = New System.Windows.Forms.Label()
        Me.cmdClearConditions = New System.Windows.Forms.Button()
        Me.mcdEditCondition = New System.Windows.Forms.Button()
        Me.lblNewFilterName = New System.Windows.Forms.Label()
        Me.grpNumeric = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmdCombineWithAndOr = New System.Windows.Forms.Button()
        Me.ttpCombineWithAndOr = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverExpression = New instat.ucrReceiverExpression()
        Me.ucrLogicalCombobox = New instat.ucrInputComboBox()
        Me.ucrDatePicker = New instat.ucrDateTimePicker()
        Me.ucrInputFilterName = New instat.ucrInputComboBox()
        Me.ucrFilterPreview = New instat.ucrInputTextBox()
        Me.ucrFilterOperation = New instat.ucrInputComboBox()
        Me.ucrFactorLevels = New instat.ucrFactor()
        Me.ucrFilterByReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorForFitler = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkNotForAllConditions = New instat.ucrCheck()
        Me.ucrChkNotForEachCondition = New instat.ucrCheck()
        Me.grpNumeric.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectLevels
        '
        Me.lblSelectLevels.AutoSize = True
        Me.lblSelectLevels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectLevels.Location = New System.Drawing.Point(413, 48)
        Me.lblSelectLevels.Name = "lblSelectLevels"
        Me.lblSelectLevels.Size = New System.Drawing.Size(74, 13)
        Me.lblSelectLevels.TabIndex = 3
        Me.lblSelectLevels.Text = "Select Levels:"
        '
        'cmdAddCondition
        '
        Me.cmdAddCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAddCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAddCondition.Location = New System.Drawing.Point(278, 64)
        Me.cmdAddCondition.Name = "cmdAddCondition"
        Me.cmdAddCondition.Size = New System.Drawing.Size(120, 29)
        Me.cmdAddCondition.TabIndex = 4
        Me.cmdAddCondition.Tag = "Add_Condition"
        Me.cmdAddCondition.Text = "Add Condition"
        Me.cmdAddCondition.UseVisualStyleBackColor = True
        '
        'cmdToggleSelectAll
        '
        Me.cmdToggleSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdToggleSelectAll.Location = New System.Drawing.Point(674, 363)
        Me.cmdToggleSelectAll.Name = "cmdToggleSelectAll"
        Me.cmdToggleSelectAll.Size = New System.Drawing.Size(93, 23)
        Me.cmdToggleSelectAll.TabIndex = 7
        Me.cmdToggleSelectAll.Text = "Select All Levels"
        Me.cmdToggleSelectAll.UseVisualStyleBackColor = True
        '
        'lstFilters
        '
        Me.lstFilters.HideSelection = False
        Me.lstFilters.Location = New System.Drawing.Point(5, 195)
        Me.lstFilters.Name = "lstFilters"
        Me.lstFilters.Size = New System.Drawing.Size(247, 132)
        Me.lstFilters.TabIndex = 8
        Me.lstFilters.UseCompatibleStateImageBehavior = False
        Me.lstFilters.View = System.Windows.Forms.View.Details
        '
        'lblFilterPreview
        '
        Me.lblFilterPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilterPreview.Location = New System.Drawing.Point(5, 339)
        Me.lblFilterPreview.Name = "lblFilterPreview"
        Me.lblFilterPreview.Size = New System.Drawing.Size(91, 19)
        Me.lblFilterPreview.TabIndex = 9
        Me.lblFilterPreview.Text = "Fliter Preview:"
        '
        'lblFilterBy
        '
        Me.lblFilterBy.AutoSize = True
        Me.lblFilterBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFilterBy.Location = New System.Drawing.Point(281, 27)
        Me.lblFilterBy.Name = "lblFilterBy"
        Me.lblFilterBy.Size = New System.Drawing.Size(47, 13)
        Me.lblFilterBy.TabIndex = 13
        Me.lblFilterBy.Text = "Filter By:"
        '
        'cmdClearConditions
        '
        Me.cmdClearConditions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClearConditions.Location = New System.Drawing.Point(256, 298)
        Me.cmdClearConditions.Name = "cmdClearConditions"
        Me.cmdClearConditions.Size = New System.Drawing.Size(142, 30)
        Me.cmdClearConditions.TabIndex = 14
        Me.cmdClearConditions.Tag = "Clear_Conditions"
        Me.cmdClearConditions.Text = "Clear Conditions"
        Me.cmdClearConditions.UseVisualStyleBackColor = True
        '
        'mcdEditCondition
        '
        Me.mcdEditCondition.Enabled = False
        Me.mcdEditCondition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.mcdEditCondition.Location = New System.Drawing.Point(256, 267)
        Me.mcdEditCondition.Name = "mcdEditCondition"
        Me.mcdEditCondition.Size = New System.Drawing.Size(142, 27)
        Me.mcdEditCondition.TabIndex = 15
        Me.mcdEditCondition.Tag = "Edit_Condition"
        Me.mcdEditCondition.Text = "Edit Condition"
        Me.mcdEditCondition.UseVisualStyleBackColor = True
        '
        'lblNewFilterName
        '
        Me.lblNewFilterName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNewFilterName.Location = New System.Drawing.Point(5, 366)
        Me.lblNewFilterName.Name = "lblNewFilterName"
        Me.lblNewFilterName.Size = New System.Drawing.Size(158, 19)
        Me.lblNewFilterName.TabIndex = 17
        Me.lblNewFilterName.Text = "New Filter Name:"
        '
        'grpNumeric
        '
        Me.grpNumeric.Controls.Add(Me.cmdClear)
        Me.grpNumeric.Controls.Add(Me.cmdComma)
        Me.grpNumeric.Controls.Add(Me.cmdBrackets)
        Me.grpNumeric.Controls.Add(Me.cmdPower)
        Me.grpNumeric.Controls.Add(Me.cmdDivide)
        Me.grpNumeric.Controls.Add(Me.cmdPlus)
        Me.grpNumeric.Controls.Add(Me.cmdMinus)
        Me.grpNumeric.Controls.Add(Me.cmdMultiply)
        Me.grpNumeric.Controls.Add(Me.cmdDot)
        Me.grpNumeric.Controls.Add(Me.cmd9)
        Me.grpNumeric.Controls.Add(Me.cmd8)
        Me.grpNumeric.Controls.Add(Me.cmd7)
        Me.grpNumeric.Controls.Add(Me.cmd6)
        Me.grpNumeric.Controls.Add(Me.cmd5)
        Me.grpNumeric.Controls.Add(Me.cmd4)
        Me.grpNumeric.Controls.Add(Me.cmd3)
        Me.grpNumeric.Controls.Add(Me.cmd2)
        Me.grpNumeric.Controls.Add(Me.cmd0)
        Me.grpNumeric.Controls.Add(Me.cmd1)
        Me.grpNumeric.Location = New System.Drawing.Point(398, 66)
        Me.grpNumeric.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpNumeric.Name = "grpNumeric"
        Me.grpNumeric.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpNumeric.Size = New System.Drawing.Size(205, 134)
        Me.grpNumeric.TabIndex = 180
        Me.grpNumeric.TabStop = False
        Me.grpNumeric.Text = "Numeric"
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(151, 71)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 60)
        Me.cmdClear.TabIndex = 190
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdComma
        '
        Me.cmdComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdComma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComma.Location = New System.Drawing.Point(3, 100)
        Me.cmdComma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.Size = New System.Drawing.Size(38, 30)
        Me.cmdComma.TabIndex = 138
        Me.cmdComma.Text = ","
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(77, 100)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(38, 30)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(151, 42)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(49, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDivide.Location = New System.Drawing.Point(114, 13)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(38, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(114, 100)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(38, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(114, 71)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(38, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(114, 42)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(38, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDot.Location = New System.Drawing.Point(151, 13)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(49, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd9.Location = New System.Drawing.Point(77, 13)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(38, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd8.Location = New System.Drawing.Point(40, 13)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(38, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd7.Location = New System.Drawing.Point(3, 13)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(38, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd6.Location = New System.Drawing.Point(77, 42)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(38, 30)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd5.Location = New System.Drawing.Point(40, 42)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(38, 30)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd4.Location = New System.Drawing.Point(3, 42)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(38, 30)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd3.Location = New System.Drawing.Point(77, 71)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(38, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd2.Location = New System.Drawing.Point(40, 71)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(38, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd0.Location = New System.Drawing.Point(40, 100)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(38, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd1.Location = New System.Drawing.Point(3, 71)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(38, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmdCombineWithAndOr
        '
        Me.cmdCombineWithAndOr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCombineWithAndOr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCombineWithAndOr.Location = New System.Drawing.Point(256, 196)
        Me.cmdCombineWithAndOr.Name = "cmdCombineWithAndOr"
        Me.cmdCombineWithAndOr.Size = New System.Drawing.Size(142, 27)
        Me.cmdCombineWithAndOr.TabIndex = 182
        Me.cmdCombineWithAndOr.Tag = "Clear_Conditions"
        Me.cmdCombineWithAndOr.Text = "All Combined with &&"
        Me.cmdCombineWithAndOr.UseVisualStyleBackColor = True
        '
        'ucrReceiverExpression
        '
        Me.ucrReceiverExpression.AutoSize = True
        Me.ucrReceiverExpression.frmParent = Nothing
        Me.ucrReceiverExpression.Location = New System.Drawing.Point(456, 44)
        Me.ucrReceiverExpression.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrReceiverExpression.Name = "ucrReceiverExpression"
        Me.ucrReceiverExpression.Selector = Nothing
        Me.ucrReceiverExpression.Size = New System.Drawing.Size(89, 21)
        Me.ucrReceiverExpression.strNcFilePath = ""
        Me.ucrReceiverExpression.TabIndex = 181
        Me.ucrReceiverExpression.ucrSelector = Nothing
        '
        'ucrLogicalCombobox
        '
        Me.ucrLogicalCombobox.AddQuotesIfUnrecognised = True
        Me.ucrLogicalCombobox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrLogicalCombobox.GetSetSelectedIndex = -1
        Me.ucrLogicalCombobox.IsReadOnly = False
        Me.ucrLogicalCombobox.Location = New System.Drawing.Point(456, 44)
        Me.ucrLogicalCombobox.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrLogicalCombobox.Name = "ucrLogicalCombobox"
        Me.ucrLogicalCombobox.Size = New System.Drawing.Size(89, 21)
        Me.ucrLogicalCombobox.TabIndex = 20
        '
        'ucrDatePicker
        '
        Me.ucrDatePicker.AutoSize = True
        Me.ucrDatePicker.DateValue = New Date(2021, 7, 7, 8, 39, 9, 171)
        Me.ucrDatePicker.Format = "dd MMM yyyy"
        Me.ucrDatePicker.Location = New System.Drawing.Point(457, 44)
        Me.ucrDatePicker.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrDatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDatePicker.Name = "ucrDatePicker"
        Me.ucrDatePicker.Size = New System.Drawing.Size(140, 21)
        Me.ucrDatePicker.TabIndex = 19
        '
        'ucrInputFilterName
        '
        Me.ucrInputFilterName.AddQuotesIfUnrecognised = True
        Me.ucrInputFilterName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFilterName.GetSetSelectedIndex = -1
        Me.ucrInputFilterName.IsReadOnly = False
        Me.ucrInputFilterName.Location = New System.Drawing.Point(204, 362)
        Me.ucrInputFilterName.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputFilterName.Name = "ucrInputFilterName"
        Me.ucrInputFilterName.Size = New System.Drawing.Size(176, 21)
        Me.ucrInputFilterName.TabIndex = 18
        '
        'ucrFilterPreview
        '
        Me.ucrFilterPreview.AddQuotesIfUnrecognised = True
        Me.ucrFilterPreview.AutoSize = True
        Me.ucrFilterPreview.IsMultiline = False
        Me.ucrFilterPreview.IsReadOnly = False
        Me.ucrFilterPreview.Location = New System.Drawing.Point(100, 337)
        Me.ucrFilterPreview.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrFilterPreview.Name = "ucrFilterPreview"
        Me.ucrFilterPreview.Size = New System.Drawing.Size(280, 21)
        Me.ucrFilterPreview.TabIndex = 10
        '
        'ucrFilterOperation
        '
        Me.ucrFilterOperation.AddQuotesIfUnrecognised = True
        Me.ucrFilterOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrFilterOperation.GetSetSelectedIndex = -1
        Me.ucrFilterOperation.IsReadOnly = False
        Me.ucrFilterOperation.Location = New System.Drawing.Point(399, 44)
        Me.ucrFilterOperation.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrFilterOperation.Name = "ucrFilterOperation"
        Me.ucrFilterOperation.Size = New System.Drawing.Size(56, 21)
        Me.ucrFilterOperation.TabIndex = 5
        '
        'ucrFactorLevels
        '
        Me.ucrFactorLevels.AutoSize = True
        Me.ucrFactorLevels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucrFactorLevels.clsReceiver = Nothing
        Me.ucrFactorLevels.Location = New System.Drawing.Point(398, 65)
        Me.ucrFactorLevels.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrFactorLevels.Name = "ucrFactorLevels"
        Me.ucrFactorLevels.shtCurrSheet = Nothing
        Me.ucrFactorLevels.Size = New System.Drawing.Size(354, 262)
        Me.ucrFactorLevels.TabIndex = 2
        Me.ucrFactorLevels.ucrChkLevels = Nothing
        '
        'ucrFilterByReceiver
        '
        Me.ucrFilterByReceiver.AutoSize = True
        Me.ucrFilterByReceiver.frmParent = Nothing
        Me.ucrFilterByReceiver.Location = New System.Drawing.Point(278, 43)
        Me.ucrFilterByReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFilterByReceiver.Name = "ucrFilterByReceiver"
        Me.ucrFilterByReceiver.Selector = Nothing
        Me.ucrFilterByReceiver.Size = New System.Drawing.Size(120, 21)
        Me.ucrFilterByReceiver.strNcFilePath = ""
        Me.ucrFilterByReceiver.TabIndex = 1
        Me.ucrFilterByReceiver.ucrSelector = Nothing
        '
        'ucrSelectorForFitler
        '
        Me.ucrSelectorForFitler.AutoSize = True
        Me.ucrSelectorForFitler.bDropUnusedFilterLevels = False
        Me.ucrSelectorForFitler.bShowHiddenColumns = False
        Me.ucrSelectorForFitler.bUseCurrentFilter = True
        Me.ucrSelectorForFitler.Location = New System.Drawing.Point(5, 4)
        Me.ucrSelectorForFitler.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForFitler.Name = "ucrSelectorForFitler"
        Me.ucrSelectorForFitler.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForFitler.TabIndex = 0
        '
        'ucrChkNotForAllConditions
        '
        Me.ucrChkNotForAllConditions.AutoSize = True
        Me.ucrChkNotForAllConditions.Checked = False
        Me.ucrChkNotForAllConditions.Location = New System.Drawing.Point(256, 249)
        Me.ucrChkNotForAllConditions.Name = "ucrChkNotForAllConditions"
        Me.ucrChkNotForAllConditions.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkNotForAllConditions.TabIndex = 184
        '
        'ucrChkNotForEachCondition
        '
        Me.ucrChkNotForEachCondition.AutoSize = True
        Me.ucrChkNotForEachCondition.Checked = False
        Me.ucrChkNotForEachCondition.Location = New System.Drawing.Point(256, 223)
        Me.ucrChkNotForEachCondition.Name = "ucrChkNotForEachCondition"
        Me.ucrChkNotForEachCondition.Size = New System.Drawing.Size(142, 23)
        Me.ucrChkNotForEachCondition.TabIndex = 183
        Me.ucrChkNotForEachCondition.Visible = False
        '
        'ucrFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.cmdCombineWithAndOr)
        Me.Controls.Add(Me.grpNumeric)
        Me.Controls.Add(Me.ucrLogicalCombobox)
        Me.Controls.Add(Me.ucrDatePicker)
        Me.Controls.Add(Me.ucrInputFilterName)
        Me.Controls.Add(Me.lblNewFilterName)
        Me.Controls.Add(Me.mcdEditCondition)
        Me.Controls.Add(Me.cmdClearConditions)
        Me.Controls.Add(Me.lblFilterBy)
        Me.Controls.Add(Me.ucrFilterPreview)
        Me.Controls.Add(Me.lblFilterPreview)
        Me.Controls.Add(Me.lstFilters)
        Me.Controls.Add(Me.cmdToggleSelectAll)
        Me.Controls.Add(Me.ucrFilterOperation)
        Me.Controls.Add(Me.cmdAddCondition)
        Me.Controls.Add(Me.lblSelectLevels)
        Me.Controls.Add(Me.ucrFactorLevels)
        Me.Controls.Add(Me.ucrFilterByReceiver)
        Me.Controls.Add(Me.ucrSelectorForFitler)
        Me.Controls.Add(Me.ucrChkNotForAllConditions)
        Me.Controls.Add(Me.ucrChkNotForEachCondition)
        Me.Controls.Add(Me.ucrReceiverExpression)
        Me.Name = "ucrFilter"
        Me.Size = New System.Drawing.Size(772, 395)
        Me.grpNumeric.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorForFitler As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFilterByReceiver As ucrReceiverSingle
    Friend WithEvents ucrFactorLevels As ucrFactor
    Friend WithEvents lblSelectLevels As Label
    Friend WithEvents cmdAddCondition As Button
    Friend WithEvents ucrFilterOperation As ucrInputComboBox
    Friend WithEvents cmdToggleSelectAll As Button
    Friend WithEvents lstFilters As ListView
    Friend WithEvents lblFilterPreview As Label
    Friend WithEvents ucrFilterPreview As ucrInputTextBox
    Friend WithEvents lblFilterBy As Label
    Friend WithEvents cmdClearConditions As Button
    Friend WithEvents mcdEditCondition As Button
    Friend WithEvents lblNewFilterName As Label
    Friend WithEvents ucrInputFilterName As ucrInputComboBox
    Friend WithEvents ucrDatePicker As ucrDateTimePicker
    Friend WithEvents ucrLogicalCombobox As ucrInputComboBox
    Friend WithEvents grpNumeric As GroupBox
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents ucrReceiverExpression As ucrReceiverExpression
    Friend WithEvents cmdCombineWithAndOr As Button
    Friend WithEvents ttpCombineWithAndOr As ToolTip
    Friend WithEvents ucrChkNotForEachCondition As ucrCheck
    Friend WithEvents ucrChkNotForAllConditions As ucrCheck
End Class
