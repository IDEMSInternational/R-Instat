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
        Me.ucrChkDefineAsFactor = New instat.ucrCheck()
        Me.ucrNudRepeatValues = New instat.ucrNud()
        Me.ucrInputInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputTo = New instat.ucrInputTextBox()
        Me.ucrInputFrom = New instat.ucrInputTextBox()
        Me.ucrDataFrameLengthForRegularSequence = New instat.ucrDataFrameLength()
        Me.dtpSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.dtpSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.lblInStepsOf = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtGetPreview = New System.Windows.Forms.RichTextBox()
        Me.grpSequenceType = New System.Windows.Forms.GroupBox()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSequenceType = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrSelectDataFrameRegularSequence = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpSequenceDefinition.SuspendLayout()
        Me.grpSequenceType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.ucrChkDefineAsFactor)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputTo)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrInputFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDataFrameLengthForRegularSequence)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorB)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorA)
        Me.grpSequenceDefinition.Controls.Add(Me.lblLength)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTimes)
        Me.grpSequenceDefinition.Controls.Add(Me.lblRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.lblInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTo)
        Me.grpSequenceDefinition.Controls.Add(Me.lblFrom)
        Me.grpSequenceDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceDefinition.Location = New System.Drawing.Point(10, 113)
        Me.grpSequenceDefinition.Name = "grpSequenceDefinition"
        Me.grpSequenceDefinition.Size = New System.Drawing.Size(205, 184)
        Me.grpSequenceDefinition.TabIndex = 2
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.Text = "Sequence Definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'ucrChkDefineAsFactor
        '
        Me.ucrChkDefineAsFactor.Checked = False
        Me.ucrChkDefineAsFactor.Location = New System.Drawing.Point(10, 158)
        Me.ucrChkDefineAsFactor.Name = "ucrChkDefineAsFactor"
        Me.ucrChkDefineAsFactor.Size = New System.Drawing.Size(176, 20)
        Me.ucrChkDefineAsFactor.TabIndex = 13
        '
        'ucrNudRepeatValues
        '
        Me.ucrNudRepeatValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRepeatValues.Location = New System.Drawing.Point(99, 102)
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
        Me.ucrInputInStepsOf.IsMultiline = False
        Me.ucrInputInStepsOf.IsReadOnly = False
        Me.ucrInputInStepsOf.Location = New System.Drawing.Point(99, 76)
        Me.ucrInputInStepsOf.Name = "ucrInputInStepsOf"
        Me.ucrInputInStepsOf.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputInStepsOf.TabIndex = 7
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsMultiline = False
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(99, 50)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputTo.TabIndex = 4
        '
        'ucrInputFrom
        '
        Me.ucrInputFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputFrom.IsMultiline = False
        Me.ucrInputFrom.IsReadOnly = False
        Me.ucrInputFrom.Location = New System.Drawing.Point(99, 24)
        Me.ucrInputFrom.Name = "ucrInputFrom"
        Me.ucrInputFrom.Size = New System.Drawing.Size(50, 23)
        Me.ucrInputFrom.TabIndex = 1
        '
        'ucrDataFrameLengthForRegularSequence
        '
        Me.ucrDataFrameLengthForRegularSequence.Location = New System.Drawing.Point(98, 128)
        Me.ucrDataFrameLengthForRegularSequence.Name = "ucrDataFrameLengthForRegularSequence"
        Me.ucrDataFrameLengthForRegularSequence.Size = New System.Drawing.Size(51, 23)
        Me.ucrDataFrameLengthForRegularSequence.TabIndex = 12
        Me.ucrDataFrameLengthForRegularSequence.ucrDataFrameSelector = Nothing
        '
        'dtpSelectorB
        '
        Me.dtpSelectorB.Location = New System.Drawing.Point(99, 50)
        Me.dtpSelectorB.Name = "dtpSelectorB"
        Me.dtpSelectorB.Size = New System.Drawing.Size(87, 20)
        Me.dtpSelectorB.TabIndex = 5
        '
        'dtpSelectorA
        '
        Me.dtpSelectorA.Location = New System.Drawing.Point(99, 24)
        Me.dtpSelectorA.Name = "dtpSelectorA"
        Me.dtpSelectorA.Size = New System.Drawing.Size(87, 20)
        Me.dtpSelectorA.TabIndex = 2
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(10, 132)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 11
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length:"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(152, 106)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes.TabIndex = 10
        Me.lblTimes.Tag = "Times"
        Me.lblTimes.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.Location = New System.Drawing.Point(10, 106)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(80, 13)
        Me.lblRepeatValues.TabIndex = 8
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat Values:"
        '
        'lblInStepsOf
        '
        Me.lblInStepsOf.AutoSize = True
        Me.lblInStepsOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInStepsOf.Location = New System.Drawing.Point(10, 80)
        Me.lblInStepsOf.Name = "lblInStepsOf"
        Me.lblInStepsOf.Size = New System.Drawing.Size(63, 13)
        Me.lblInStepsOf.TabIndex = 6
        Me.lblInStepsOf.Tag = "In_steps_Of"
        Me.lblInStepsOf.Text = "In Steps Of:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(10, 54)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Tag = ""
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(10, 28)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Tag = "From:"
        Me.lblFrom.Text = "From:"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(221, 50)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(100, 13)
        Me.lblPreview.TabIndex = 3
        Me.lblPreview.Tag = "Preview"
        Me.lblPreview.Text = "Sequence Preview:"
        '
        'txtGetPreview
        '
        Me.txtGetPreview.Location = New System.Drawing.Point(221, 65)
        Me.txtGetPreview.Name = "txtGetPreview"
        Me.txtGetPreview.Size = New System.Drawing.Size(185, 172)
        Me.txtGetPreview.TabIndex = 4
        Me.txtGetPreview.Text = ""
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoNumeric)
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.ucrPnlSequenceType)
        Me.grpSequenceType.Location = New System.Drawing.Point(10, 60)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(205, 52)
        Me.grpSequenceType.TabIndex = 1
        Me.grpSequenceType.TabStop = False
        Me.grpSequenceType.Text = "Sequence Type"
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNumeric.Location = New System.Drawing.Point(10, 19)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(70, 18)
        Me.rdoNumeric.TabIndex = 1
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'rdoDates
        '
        Me.rdoDates.AutoSize = True
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDates.Location = New System.Drawing.Point(93, 20)
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Size = New System.Drawing.Size(59, 18)
        Me.rdoDates.TabIndex = 2
        Me.rdoDates.Tag = "Dates"
        Me.rdoDates.Text = "Dates"
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'ucrPnlSequenceType
        '
        Me.ucrPnlSequenceType.Location = New System.Drawing.Point(4, 18)
        Me.ucrPnlSequenceType.Name = "ucrPnlSequenceType"
        Me.ucrPnlSequenceType.Size = New System.Drawing.Size(189, 29)
        Me.ucrPnlSequenceType.TabIndex = 0
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(10, 304)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColumnName.TabIndex = 6
        '
        'ucrSelectDataFrameRegularSequence
        '
        Me.ucrSelectDataFrameRegularSequence.bUseCurrentFilter = True
        Me.ucrSelectDataFrameRegularSequence.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectDataFrameRegularSequence.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectDataFrameRegularSequence.Name = "ucrSelectDataFrameRegularSequence"
        Me.ucrSelectDataFrameRegularSequence.Size = New System.Drawing.Size(120, 40)
        Me.ucrSelectDataFrameRegularSequence.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 330)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 7
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(221, 245)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(185, 52)
        Me.lblMessage.TabIndex = 8
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 387)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.grpSequenceType)
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
        Me.grpSequenceType.ResumeLayout(False)
        Me.grpSequenceType.PerformLayout()
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
    Friend WithEvents dtpSelectorA As DateTimePicker
    Friend WithEvents dtpSelectorB As DateTimePicker
    Friend WithEvents txtGetPreview As RichTextBox
    Friend WithEvents ucrDataFrameLengthForRegularSequence As ucrDataFrameLength
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents ucrPnlSequenceType As UcrPanel
    Friend WithEvents ucrInputInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputTo As ucrInputTextBox
    Friend WithEvents ucrInputFrom As ucrInputTextBox
    Friend WithEvents ucrNudRepeatValues As ucrNud
    Friend WithEvents ucrChkDefineAsFactor As ucrCheck
    Friend WithEvents lblMessage As Label
End Class
