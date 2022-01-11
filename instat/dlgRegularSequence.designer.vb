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
Partial Class dlgRegularSequence
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
        Me.grpSequenceDefinition = New System.Windows.Forms.GroupBox()
        Me.ucrInputComboDatesBy = New instat.ucrInputComboBox()
        Me.ucrChkDefineAsFactor = New instat.ucrCheck()
        Me.ucrNudRepeatValues = New instat.ucrNud()
        Me.ucrInputInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.ucrDataFrameLengthForRegularSequence = New instat.ucrDataFrameLength()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrDateTimePickerTo = New instat.ucrDateTimePicker()
        Me.ucrDateTimePickerFrom = New instat.ucrDateTimePicker()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtGetPreview = New System.Windows.Forms.RichTextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSequenceType = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrSelectDataFrameRegularSequence = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSequenceDefinition.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputComboDatesBy)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrChkDefineAsFactor)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputTo)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDataFrameLengthForRegularSequence)
        Me.grpSequenceDefinition.Controls.Add(Me.lblLength)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTimes)
        Me.grpSequenceDefinition.Controls.Add(Me.lblRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.lblInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTo)
        Me.grpSequenceDefinition.Controls.Add(Me.lblFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDateTimePickerTo)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDateTimePickerFrom)
        Me.grpSequenceDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grpSequenceDefinition.Location = New System.Drawing.Point(10, 111)
        Me.grpSequenceDefinition.Name = "grpSequenceDefinition"
        Me.grpSequenceDefinition.Size = New System.Drawing.Size(239, 184)
        Me.grpSequenceDefinition.TabIndex = 4
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.Text = "Sequence Definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'ucrInputComboDatesBy
        '
        Me.ucrInputComboDatesBy.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDatesBy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboDatesBy.GetSetSelectedIndex = -1
        Me.ucrInputComboDatesBy.IsReadOnly = False
        Me.ucrInputComboDatesBy.Location = New System.Drawing.Point(173, 76)
        Me.ucrInputComboDatesBy.Name = "ucrInputComboDatesBy"
        Me.ucrInputComboDatesBy.Size = New System.Drawing.Size(62, 23)
        Me.ucrInputComboDatesBy.TabIndex = 17
        '
        'ucrChkDefineAsFactor
        '
        Me.ucrChkDefineAsFactor.AutoSize = True
        Me.ucrChkDefineAsFactor.Checked = False
        Me.ucrChkDefineAsFactor.Location = New System.Drawing.Point(5, 158)
        Me.ucrChkDefineAsFactor.Name = "ucrChkDefineAsFactor"
        Me.ucrChkDefineAsFactor.Size = New System.Drawing.Size(176, 23)
        Me.ucrChkDefineAsFactor.TabIndex = 13
        '
        'ucrNudRepeatValues
        '
        Me.ucrNudRepeatValues.AutoSize = True
        Me.ucrNudRepeatValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRepeatValues.Location = New System.Drawing.Point(111, 101)
        Me.ucrNudRepeatValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRepeatValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Name = "ucrNudRepeatValues"
        Me.ucrNudRepeatValues.Size = New System.Drawing.Size(50, 23)
        Me.ucrNudRepeatValues.TabIndex = 9
        Me.ucrNudRepeatValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputInStepsOf
        '
        Me.ucrInputInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputInStepsOf.AutoSize = True
        Me.ucrInputInStepsOf.IsMultiline = False
        Me.ucrInputInStepsOf.IsReadOnly = False
        Me.ucrInputInStepsOf.Location = New System.Drawing.Point(111, 76)
        Me.ucrInputInStepsOf.Name = "ucrInputInStepsOf"
        Me.ucrInputInStepsOf.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputInStepsOf.TabIndex = 7
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.AutoSize = True
        Me.ucrInputTo.IsMultiline = False
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(111, 50)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputTo.TabIndex = 4
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputFrom.AutoSize = True
        Me.ucrInputFrom.IsMultiline = False
        Me.ucrInputFrom.IsReadOnly = False
        Me.ucrInputFrom.Location = New System.Drawing.Point(111, 24)
        Me.ucrInputFrom.Name = "ucrInputFrom"
        Me.ucrInputFrom.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputFrom.TabIndex = 1
        '
        'ucrDataFrameLengthForRegularSequence
        '
        Me.ucrDataFrameLengthForRegularSequence.AutoSize = True
        Me.ucrDataFrameLengthForRegularSequence.Location = New System.Drawing.Point(111, 128)
        Me.ucrDataFrameLengthForRegularSequence.Name = "ucrDataFrameLengthForRegularSequence"
        Me.ucrDataFrameLengthForRegularSequence.Size = New System.Drawing.Size(54, 23)
        Me.ucrDataFrameLengthForRegularSequence.TabIndex = 12
        Me.ucrDataFrameLengthForRegularSequence.ucrDataFrameSelector = Nothing
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLength.Location = New System.Drawing.Point(5, 132)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 11
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length:"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTimes.Location = New System.Drawing.Point(166, 106)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes.TabIndex = 10
        Me.lblTimes.Tag = "Times"
        Me.lblTimes.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRepeatValues.Location = New System.Drawing.Point(5, 106)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(80, 13)
        Me.lblRepeatValues.TabIndex = 8
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat Values:"
        '
        'lblInStepsOf
        '
        Me.lblInStepsOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblInStepsOf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblInStepsOf.Location = New System.Drawing.Point(5, 80)
        Me.lblInStepsOf.Name = "lblInStepsOf"
        Me.lblInStepsOf.Size = New System.Drawing.Size(109, 13)
        Me.lblInStepsOf.TabIndex = 6
        Me.lblInStepsOf.Tag = "In_steps_Of"
        Me.lblInStepsOf.Text = "In Steps Of:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(5, 54)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(5, 28)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Tag = "From:"
        Me.lblFrom.Text = "From:"
        '
        'ucrDateTimePickerTo
        '
        Me.ucrDateTimePickerTo.AutoSize = True
        Me.ucrDateTimePickerTo.DateValue = New Date(2021, 5, 19, 13, 55, 53, 370)
        Me.ucrDateTimePickerTo.Format = "dd MMM yyyy"
        Me.ucrDateTimePickerTo.Location = New System.Drawing.Point(78, 50)
        Me.ucrDateTimePickerTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateTimePickerTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateTimePickerTo.Name = "ucrDateTimePickerTo"
        Me.ucrDateTimePickerTo.Size = New System.Drawing.Size(157, 20)
        Me.ucrDateTimePickerTo.TabIndex = 15
        '
        'ucrDateTimePickerFrom
        '
        Me.ucrDateTimePickerFrom.AutoSize = True
        Me.ucrDateTimePickerFrom.DateValue = New Date(2021, 5, 19, 13, 55, 53, 410)
        Me.ucrDateTimePickerFrom.Format = "dd MMM yyyy"
        Me.ucrDateTimePickerFrom.Location = New System.Drawing.Point(78, 24)
        Me.ucrDateTimePickerFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDateTimePickerFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDateTimePickerFrom.Name = "ucrDateTimePickerFrom"
        Me.ucrDateTimePickerFrom.Size = New System.Drawing.Size(157, 20)
        Me.ucrDateTimePickerFrom.TabIndex = 14
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreview.Location = New System.Drawing.Point(258, 80)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(100, 13)
        Me.lblPreview.TabIndex = 5
        Me.lblPreview.Tag = "Preview"
        Me.lblPreview.Text = "Sequence Preview:"
        '
        'txtGetPreview
        '
        Me.txtGetPreview.Location = New System.Drawing.Point(256, 96)
        Me.txtGetPreview.Name = "txtGetPreview"
        Me.txtGetPreview.ReadOnly = True
        Me.txtGetPreview.Size = New System.Drawing.Size(185, 140)
        Me.txtGetPreview.TabIndex = 6
        Me.txtGetPreview.Text = ""
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMessage.Location = New System.Drawing.Point(256, 243)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(185, 52)
        Me.lblMessage.TabIndex = 7
        '
        'rdoDates
        '
        Me.rdoDates.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDates.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDates.FlatAppearance.BorderSize = 2
        Me.rdoDates.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDates.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDates.Location = New System.Drawing.Point(228, 12)
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Size = New System.Drawing.Size(100, 28)
        Me.rdoDates.TabIndex = 2
        Me.rdoDates.Text = "Dates"
        Me.rdoDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatAppearance.BorderSize = 2
        Me.rdoNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNumeric.Location = New System.Drawing.Point(129, 12)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(100, 28)
        Me.rdoNumeric.TabIndex = 1
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'ucrPnlSequenceType
        '
        Me.ucrPnlSequenceType.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ucrPnlSequenceType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSequenceType.Location = New System.Drawing.Point(102, 7)
        Me.ucrPnlSequenceType.Name = "ucrPnlSequenceType"
        Me.ucrPnlSequenceType.Size = New System.Drawing.Size(256, 46)
        Me.ucrPnlSequenceType.TabIndex = 0
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 304)
        Me.ucrNewColumnName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(325, 24)
        Me.ucrNewColumnName.TabIndex = 8
        '
        'ucrSelectDataFrameRegularSequence
        '
        Me.ucrSelectDataFrameRegularSequence.AutoSize = True
        Me.ucrSelectDataFrameRegularSequence.bDropUnusedFilterLevels = False
        Me.ucrSelectDataFrameRegularSequence.bUseCurrentFilter = True
        Me.ucrSelectDataFrameRegularSequence.Location = New System.Drawing.Point(10, 59)
        Me.ucrSelectDataFrameRegularSequence.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectDataFrameRegularSequence.Name = "ucrSelectDataFrameRegularSequence"
        Me.ucrSelectDataFrameRegularSequence.Size = New System.Drawing.Size(152, 43)
        Me.ucrSelectDataFrameRegularSequence.TabIndex = 3
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 330)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(448, 387)
        Me.Controls.Add(Me.rdoNumeric)
        Me.Controls.Add(Me.rdoDates)
        Me.Controls.Add(Me.ucrPnlSequenceType)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.txtGetPreview)
        Me.Controls.Add(Me.grpSequenceDefinition)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrSelectDataFrameRegularSequence)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegularSequence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Entry_of_regular_sequence"
        Me.Text = "Regular Sequence"
        Me.grpSequenceDefinition.ResumeLayout(False)
        Me.grpSequenceDefinition.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSequenceDefinition As GroupBox
    Friend WithEvents lblInStepsOf As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectDataFrameRegularSequence As ucrDataFrame
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblTimes As Label
    Friend WithEvents lblRepeatValues As Label
    Friend WithEvents txtGetPreview As RichTextBox
    Friend WithEvents ucrDataFrameLengthForRegularSequence As ucrDataFrameLength
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents ucrInputInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputTo As ucrInputTextBox
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrNudRepeatValues As ucrNud
    Friend WithEvents ucrChkDefineAsFactor As ucrCheck
    Friend WithEvents lblMessage As Label
    Friend WithEvents ucrPnlSequenceType As UcrPanel
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents ucrDateTimePickerTo As ucrDateTimePicker
    Friend WithEvents ucrDateTimePickerFrom As ucrDateTimePicker
    Friend WithEvents ucrInputComboDatesBy As ucrInputComboBox
End Class
