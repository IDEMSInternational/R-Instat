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
Partial Class ucrAxes
    Inherits instat.ucrCore

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpScaleDiscrete = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrChkLimitsFrom = New instat.ucrCheck()
        Me.ucrInputNaValueDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputExpandDiscrete = New instat.ucrInputTextBox()
        Me.ucrInputDropUnusedLevels = New instat.ucrInputComboBox()
        Me.ucrInputPositionDiscrete = New instat.ucrInputComboBox()
        Me.ucrChkExpandDiscrete = New instat.ucrCheck()
        Me.ucrChkDropUnusedLevels = New instat.ucrCheck()
        Me.ucrChkPositionDiscrete = New instat.ucrCheck()
        Me.ucrChkNaValueDiscrete = New instat.ucrCheck()
        Me.ucrInputRelaceMissingvalues = New instat.ucrInputTextBox()
        Me.ucrChkLabelsDiscrete = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabelsDiscrete = New instat.ucrInputTextBox()
        Me.grpMajorBreaksDiscrete = New System.Windows.Forms.GroupBox()
        Me.ucrInputBreaksDiscrete = New instat.ucrInputTextBox()
        Me.ucrChkBreakDiscret = New instat.ucrCheck()
        Me.ucrInputLimitDiscrete = New instat.ucrInputTextBox()
        Me.ucrChkLimit = New instat.ucrCheck()
        Me.ucrInputComboDateLabel = New instat.ucrInputComboBox()
        Me.grpScaleXDate = New System.Windows.Forms.GroupBox()
        Me.ucrChkDateLabels = New instat.ucrCheck()
        Me.ucrInputComboDateBreak = New instat.ucrInputComboBox()
        Me.lbXscaleDateLowerLimit = New System.Windows.Forms.Label()
        Me.lblXScalDateUpperLimit = New System.Windows.Forms.Label()
        Me.ucrNudDateBreak = New instat.ucrNud()
        Me.ucrDtpLowerLimit = New instat.ucrDateTimePicker()
        Me.ucrDtpUpperLimit = New instat.ucrDateTimePicker()
        Me.ucrChkLimits = New instat.ucrCheck()
        Me.ucrChkBreaks = New instat.ucrCheck()
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.ucrInputExpand = New instat.ucrInputTextBox()
        Me.ucrInputTransformation = New instat.ucrInputComboBox()
        Me.ucrInputPosition = New instat.ucrInputComboBox()
        Me.ucrChkExpand = New instat.ucrCheck()
        Me.ucrChkTransformation = New instat.ucrCheck()
        Me.ucrChkPosition = New instat.ucrCheck()
        Me.ucrChkNaValue = New instat.ucrCheck()
        Me.ucrInputUpperLimit = New instat.ucrInputTextBox()
        Me.ucrInputLowerLimit = New instat.ucrInputTextBox()
        Me.lblUpperLimit = New System.Windows.Forms.Label()
        Me.lblLowerLimit = New System.Windows.Forms.Label()
        Me.rdoScalesCustom = New System.Windows.Forms.RadioButton()
        Me.rdoMinorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.ucrChkLabels = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabels = New instat.ucrInputTextBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.rdoMajorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdoSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoNoTitle = New System.Windows.Forms.RadioButton()
        Me.grpMinorBreaks = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFrom = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.lblMinorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.lblMinorBreaksTo = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrPnlMinorBreaks = New instat.UcrPanel()
        Me.ucrInputMinorBreaksFrom = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksCustom = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMajorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.lblMajorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMajorBreaksFrom = New System.Windows.Forms.Label()
        Me.lblMajorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMajorBreaks = New instat.UcrPanel()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputMajorBreaksCustom = New instat.ucrInputTextBox()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.grpMajorBreaks = New System.Windows.Forms.GroupBox()
        Me.grpScaleDiscrete.SuspendLayout()
        Me.grpMajorBreaksDiscrete.SuspendLayout()
        Me.lblMinorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMinorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMinorBreaks = New instat.UcrPanel()
        Me.grpMinorBreaks = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFrom = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.grpSecondAxis = New System.Windows.Forms.GroupBox()
        Me.ucrInputOffset = New instat.ucrInputComboBox()
        Me.ucrChkOffset = New instat.ucrCheck()
        Me.rdoSecondAxisSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSecondAxisNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSecondAxisTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSecondAxisTitle = New instat.UcrPanel()
        Me.lblTitleSA = New System.Windows.Forms.Label()
        Me.ucrInputTextNameSAxis = New instat.ucrInputTextBox()
        Me.ucrInputSecondaryAxis = New instat.ucrInputComboBox()
        Me.ucrChkSecondaryAxis = New instat.ucrCheck()
        Me.ucrInputTrans = New instat.ucrInputComboBox()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpMajorBreaks.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.grpScaleXDate.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.grpMinorBreaks.SuspendLayout()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpMajorBreaks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpScaleDiscrete
        '
        Me.grpScaleDiscrete.Controls.Add(Me.lblTo)
        Me.grpScaleDiscrete.Controls.Add(Me.lblFrom)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrNudFrom)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrNudTo)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkLimitsFrom)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputNaValueDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputExpandDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputDropUnusedLevels)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrInputPositionDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkExpandDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkDropUnusedLevels)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkPositionDiscrete)
        Me.grpScaleDiscrete.Controls.Add(Me.ucrChkNaValueDiscrete)
        Me.grpScaleDiscrete.Location = New System.Drawing.Point(1, 98)
        Me.grpScaleDiscrete.Name = "grpScaleDiscrete"
        Me.grpScaleDiscrete.Size = New System.Drawing.Size(332, 181)
        Me.grpScaleDiscrete.TabIndex = 40
        Me.grpScaleDiscrete.TabStop = False
        Me.grpScaleDiscrete.Text = "Scales "
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(198, 29)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 35
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(87, 29)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 34
        Me.lblFrom.Text = "From:"
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.AutoSize = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(124, 25)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 33
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.AutoSize = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(231, 25)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 31
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkLimitsFrom
        '
        Me.ucrChkLimitsFrom.AutoSize = True
        Me.ucrChkLimitsFrom.Checked = False
        Me.ucrChkLimitsFrom.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkLimitsFrom.Name = "ucrChkLimitsFrom"
        Me.ucrChkLimitsFrom.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLimitsFrom.TabIndex = 28
        '
        'ucrInputNaValueDiscrete
        '
        Me.ucrInputNaValueDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputNaValueDiscrete.AutoSize = True
        Me.ucrInputNaValueDiscrete.IsMultiline = False
        Me.ucrInputNaValueDiscrete.IsReadOnly = False
        Me.ucrInputNaValueDiscrete.Location = New System.Drawing.Point(191, 59)
        Me.ucrInputNaValueDiscrete.Name = "ucrInputNaValueDiscrete"
        Me.ucrInputNaValueDiscrete.Size = New System.Drawing.Size(78, 22)
        Me.ucrInputNaValueDiscrete.TabIndex = 27
        '
        'ucrInputExpandDiscrete
        '
        Me.ucrInputExpandDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputExpandDiscrete.AutoSize = True
        Me.ucrInputExpandDiscrete.IsMultiline = False
        Me.ucrInputExpandDiscrete.IsReadOnly = False
        Me.ucrInputExpandDiscrete.Location = New System.Drawing.Point(191, 143)
        Me.ucrInputExpandDiscrete.Name = "ucrInputExpandDiscrete"
        Me.ucrInputExpandDiscrete.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputExpandDiscrete.TabIndex = 27
        '
        'ucrInputDropUnusedLevels
        '
        Me.ucrInputDropUnusedLevels.AddQuotesIfUnrecognised = True
        Me.ucrInputDropUnusedLevels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDropUnusedLevels.GetSetSelectedIndex = -1
        Me.ucrInputDropUnusedLevels.IsReadOnly = False
        Me.ucrInputDropUnusedLevels.Location = New System.Drawing.Point(191, 115)
        Me.ucrInputDropUnusedLevels.Name = "ucrInputDropUnusedLevels"
        Me.ucrInputDropUnusedLevels.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputDropUnusedLevels.TabIndex = 26
        '
        'ucrInputPositionDiscrete
        '
        Me.ucrInputPositionDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputPositionDiscrete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPositionDiscrete.GetSetSelectedIndex = -1
        Me.ucrInputPositionDiscrete.IsReadOnly = False
        Me.ucrInputPositionDiscrete.Location = New System.Drawing.Point(191, 87)
        Me.ucrInputPositionDiscrete.Name = "ucrInputPositionDiscrete"
        Me.ucrInputPositionDiscrete.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputPositionDiscrete.TabIndex = 26
        '
        'ucrChkExpandDiscrete
        '
        Me.ucrChkExpandDiscrete.AutoSize = True
        Me.ucrChkExpandDiscrete.Checked = False
        Me.ucrChkExpandDiscrete.Location = New System.Drawing.Point(6, 143)
        Me.ucrChkExpandDiscrete.Name = "ucrChkExpandDiscrete"
        Me.ucrChkExpandDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkExpandDiscrete.TabIndex = 23
        '
        'ucrChkDropUnusedLevels
        '
        Me.ucrChkDropUnusedLevels.AutoSize = True
        Me.ucrChkDropUnusedLevels.Checked = False
        Me.ucrChkDropUnusedLevels.Location = New System.Drawing.Point(6, 115)
        Me.ucrChkDropUnusedLevels.Name = "ucrChkDropUnusedLevels"
        Me.ucrChkDropUnusedLevels.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkDropUnusedLevels.TabIndex = 23
        '
        'ucrChkPositionDiscrete
        '
        Me.ucrChkPositionDiscrete.AutoSize = True
        Me.ucrChkPositionDiscrete.Checked = False
        Me.ucrChkPositionDiscrete.Location = New System.Drawing.Point(6, 87)
        Me.ucrChkPositionDiscrete.Name = "ucrChkPositionDiscrete"
        Me.ucrChkPositionDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkPositionDiscrete.TabIndex = 23
        '
        'ucrChkNaValueDiscrete
        '
        Me.ucrChkNaValueDiscrete.AutoSize = True
        Me.ucrChkNaValueDiscrete.Checked = False
        Me.ucrChkNaValueDiscrete.Location = New System.Drawing.Point(6, 59)
        Me.ucrChkNaValueDiscrete.Name = "ucrChkNaValueDiscrete"
        Me.ucrChkNaValueDiscrete.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkNaValueDiscrete.TabIndex = 23
        Me.grpSecondAxis.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.lblTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoSpecifyTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoNoTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(3, 1)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(301, 83)
        Me.grpAxisTitle.TabIndex = 0
        Me.grpAxisTitle.TabStop = False
        Me.grpAxisTitle.Text = "Axis Title"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(4, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Title:"
        '
        'rdoSpecifyTitle
        '
        Me.rdoSpecifyTitle.AutoSize = True
        Me.rdoSpecifyTitle.Location = New System.Drawing.Point(94, 21)
        Me.rdoSpecifyTitle.Name = "rdoSpecifyTitle"
        Me.rdoSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoSpecifyTitle.TabIndex = 3
        Me.rdoSpecifyTitle.TabStop = True
        Me.rdoSpecifyTitle.Text = "Specify Title"
        Me.rdoSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoNoTitle
        '
        Me.rdoNoTitle.AutoSize = True
        Me.rdoNoTitle.Location = New System.Drawing.Point(215, 21)
        Me.rdoNoTitle.Name = "rdoNoTitle"
        Me.rdoNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitle.TabIndex = 3
        Me.rdoNoTitle.TabStop = True
        Me.rdoNoTitle.Text = "No Title"
        Me.rdoNoTitle.UseVisualStyleBackColor = True
        '
        'rdoTitleAuto
        '
        Me.rdoTitleAuto.AutoSize = True
        Me.rdoTitleAuto.Location = New System.Drawing.Point(7, 21)
        Me.rdoTitleAuto.Name = "rdoTitleAuto"
        Me.rdoTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoTitleAuto.TabIndex = 2
        Me.rdoTitleAuto.TabStop = True
        Me.rdoTitleAuto.Text = "Auto"
        Me.rdoTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrInputRelaceMissingvalues
        '
        Me.ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = True
        Me.ucrInputRelaceMissingvalues.AutoSize = True
        Me.ucrInputRelaceMissingvalues.IsMultiline = False
        Me.ucrInputRelaceMissingvalues.IsReadOnly = False
        Me.ucrInputRelaceMissingvalues.Location = New System.Drawing.Point(191, 103)
        Me.ucrInputRelaceMissingvalues.Name = "ucrInputRelaceMissingvalues"
        Me.ucrInputRelaceMissingvalues.Size = New System.Drawing.Size(78, 22)
        Me.ucrInputRelaceMissingvalues.TabIndex = 27
        '
        'ucrChkLabelsDiscrete
        '
        Me.ucrChkLabelsDiscrete.AutoSize = True
        Me.ucrChkLabelsDiscrete.Checked = False
        Me.ucrChkLabelsDiscrete.Location = New System.Drawing.Point(5, 55)
        Me.ucrChkLabelsDiscrete.Name = "ucrChkLabelsDiscrete"
        Me.ucrChkLabelsDiscrete.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLabelsDiscrete.TabIndex = 22
        '
        'ucrInputMajorBreaksLabelsDiscrete
        '
        Me.ucrInputMajorBreaksLabelsDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabelsDiscrete.AutoSize = True
        Me.ucrInputMajorBreaksLabelsDiscrete.IsMultiline = False
        Me.ucrInputMajorBreaksLabelsDiscrete.IsReadOnly = False
        Me.ucrInputMajorBreaksLabelsDiscrete.Location = New System.Drawing.Point(98, 56)
        Me.ucrInputMajorBreaksLabelsDiscrete.Name = "ucrInputMajorBreaksLabelsDiscrete"
        Me.ucrInputMajorBreaksLabelsDiscrete.Size = New System.Drawing.Size(250, 21)
        Me.ucrInputMajorBreaksLabelsDiscrete.TabIndex = 4
        '
        'grpMajorBreaksDiscrete
        '
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputBreaksDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrChkBreakDiscret)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputLimitDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrChkLimit)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrChkLabelsDiscrete)
        Me.grpMajorBreaksDiscrete.Controls.Add(Me.ucrInputMajorBreaksLabelsDiscrete)
        Me.grpMajorBreaksDiscrete.Location = New System.Drawing.Point(417, 35)
        Me.grpMajorBreaksDiscrete.Name = "grpMajorBreaksDiscrete"
        Me.grpMajorBreaksDiscrete.Size = New System.Drawing.Size(354, 150)
        Me.grpMajorBreaksDiscrete.TabIndex = 39
        Me.grpMajorBreaksDiscrete.TabStop = False
        Me.grpMajorBreaksDiscrete.Text = "Options"
        '
        'ucrInputBreaksDiscrete
        '
        Me.ucrInputBreaksDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputBreaksDiscrete.AutoSize = True
        Me.ucrInputBreaksDiscrete.IsMultiline = False
        Me.ucrInputBreaksDiscrete.IsReadOnly = False
        Me.ucrInputBreaksDiscrete.Location = New System.Drawing.Point(98, 94)
        Me.ucrInputBreaksDiscrete.Name = "ucrInputBreaksDiscrete"
        Me.ucrInputBreaksDiscrete.Size = New System.Drawing.Size(251, 21)
        Me.ucrInputBreaksDiscrete.TabIndex = 26
        '
        'ucrChkBreakDiscret
        '
        Me.ucrChkBreakDiscret.AutoSize = True
        Me.ucrChkBreakDiscret.Checked = False
        Me.ucrChkBreakDiscret.Location = New System.Drawing.Point(5, 94)
        Me.ucrChkBreakDiscret.Name = "ucrChkBreakDiscret"
        Me.ucrChkBreakDiscret.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkBreakDiscret.TabIndex = 25
        '
        'ucrInputLimitDiscrete
        '
        Me.ucrInputLimitDiscrete.AddQuotesIfUnrecognised = True
        Me.ucrInputLimitDiscrete.AutoSize = True
        Me.ucrInputLimitDiscrete.IsMultiline = False
        Me.ucrInputLimitDiscrete.IsReadOnly = False
        Me.ucrInputLimitDiscrete.Location = New System.Drawing.Point(98, 15)
        Me.ucrInputLimitDiscrete.Name = "ucrInputLimitDiscrete"
        Me.ucrInputLimitDiscrete.Size = New System.Drawing.Size(250, 21)
        Me.ucrInputLimitDiscrete.TabIndex = 24
        '
        'ucrChkLimit
        '
        Me.ucrChkLimit.AutoSize = True
        Me.ucrChkLimit.Checked = False
        Me.ucrChkLimit.Location = New System.Drawing.Point(5, 14)
        Me.ucrChkLimit.Name = "ucrChkLimit"
        Me.ucrChkLimit.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLimit.TabIndex = 23
        '
        'ucrInputComboDateLabel
        '
        Me.ucrInputComboDateLabel.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboDateLabel.GetSetSelectedIndex = -1
        Me.ucrInputComboDateLabel.IsReadOnly = False
        Me.ucrInputComboDateLabel.Location = New System.Drawing.Point(95, 54)
        Me.ucrInputComboDateLabel.Name = "ucrInputComboDateLabel"
        Me.ucrInputComboDateLabel.Size = New System.Drawing.Size(135, 21)
        Me.ucrInputComboDateLabel.TabIndex = 9
        '
        'grpScaleXDate
        '
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateLabel)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkDateLabels)
        Me.grpScaleXDate.Controls.Add(Me.ucrInputComboDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.lbXscaleDateLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.lblXScalDateUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrNudDateBreak)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpLowerLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrDtpUpperLimit)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkLimits)
        Me.grpScaleXDate.Controls.Add(Me.ucrChkBreaks)
        Me.grpScaleXDate.Location = New System.Drawing.Point(4, 97)
        Me.grpScaleXDate.Name = "grpScaleXDate"
        Me.grpScaleXDate.Size = New System.Drawing.Size(301, 153)
        Me.grpScaleXDate.TabIndex = 42
        Me.grpScaleXDate.TabStop = False
        Me.grpScaleXDate.Text = "Date Scales"
        '
        'ucrChkDateLabels
        '
        Me.ucrChkDateLabels.AutoSize = True
        Me.ucrChkDateLabels.Checked = False
        Me.ucrChkDateLabels.Location = New System.Drawing.Point(14, 54)
        Me.ucrChkDateLabels.Name = "ucrChkDateLabels"
        Me.ucrChkDateLabels.Size = New System.Drawing.Size(92, 23)
        Me.ucrChkDateLabels.TabIndex = 8
        '
        'ucrInputComboDateBreak
        '
        Me.ucrInputComboDateBreak.AddQuotesIfUnrecognised = True
        Me.ucrInputComboDateBreak.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboDateBreak.GetSetSelectedIndex = -1
        Me.ucrInputComboDateBreak.IsReadOnly = False
        Me.ucrInputComboDateBreak.Location = New System.Drawing.Point(145, 31)
        Me.ucrInputComboDateBreak.Name = "ucrInputComboDateBreak"
        Me.ucrInputComboDateBreak.Size = New System.Drawing.Size(85, 21)
        Me.ucrInputComboDateBreak.TabIndex = 7
        '
        'lbXscaleDateLowerLimit
        '
        Me.lbXscaleDateLowerLimit.AutoSize = True
        Me.lbXscaleDateLowerLimit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbXscaleDateLowerLimit.Location = New System.Drawing.Point(10, 100)
        Me.lbXscaleDateLowerLimit.Name = "lbXscaleDateLowerLimit"
        Me.lbXscaleDateLowerLimit.Size = New System.Drawing.Size(60, 13)
        Me.lbXscaleDateLowerLimit.TabIndex = 6
        Me.lbXscaleDateLowerLimit.Text = "Lower Limit"
        '
        'lblXScalDateUpperLimit
        '
        Me.lblXScalDateUpperLimit.AutoSize = True
        Me.lblXScalDateUpperLimit.Location = New System.Drawing.Point(9, 123)
        Me.lblXScalDateUpperLimit.Name = "lblXScalDateUpperLimit"
        Me.lblXScalDateUpperLimit.Size = New System.Drawing.Size(60, 13)
        Me.lblXScalDateUpperLimit.TabIndex = 5
        Me.lblXScalDateUpperLimit.Text = "Upper Limit"
        '
        'ucrNudDateBreak
        '
        Me.ucrNudDateBreak.AutoSize = True
        Me.ucrNudDateBreak.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDateBreak.Location = New System.Drawing.Point(95, 31)
        Me.ucrNudDateBreak.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreak.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreak.Name = "ucrNudDateBreak"
        Me.ucrNudDateBreak.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDateBreak.TabIndex = 4
        Me.ucrNudDateBreak.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrDtpLowerLimit
        '
        Me.ucrDtpLowerLimit.AutoSize = True
        Me.ucrDtpLowerLimit.DateValue = New Date(2021, 6, 19, 11, 15, 36, 159)
        Me.ucrDtpLowerLimit.Format = "dd MMM yyyy"
        Me.ucrDtpLowerLimit.Location = New System.Drawing.Point(95, 100)
        Me.ucrDtpLowerLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpLowerLimit.Name = "ucrDtpLowerLimit"
        Me.ucrDtpLowerLimit.Size = New System.Drawing.Size(136, 20)
        Me.ucrDtpLowerLimit.TabIndex = 3
        '
        'ucrDtpUpperLimit
        '
        Me.ucrDtpUpperLimit.AutoSize = True
        Me.ucrDtpUpperLimit.DateValue = New Date(2021, 6, 19, 11, 15, 36, 170)
        Me.ucrDtpUpperLimit.Format = "dd MMM yyyy"
        Me.ucrDtpUpperLimit.Location = New System.Drawing.Point(95, 123)
        Me.ucrDtpUpperLimit.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.ucrDtpUpperLimit.Name = "ucrDtpUpperLimit"
        Me.ucrDtpUpperLimit.Size = New System.Drawing.Size(135, 20)
        Me.ucrDtpUpperLimit.TabIndex = 2
        '
        'ucrChkLimits
        '
        Me.ucrChkLimits.AutoSize = True
        Me.ucrChkLimits.Checked = False
        Me.ucrChkLimits.Location = New System.Drawing.Point(14, 77)
        Me.ucrChkLimits.Name = "ucrChkLimits"
        Me.ucrChkLimits.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkLimits.TabIndex = 1
        '
        'ucrChkBreaks
        '
        Me.ucrChkBreaks.AutoSize = True
        Me.ucrChkBreaks.Checked = False
        Me.ucrChkBreaks.Location = New System.Drawing.Point(14, 31)
        Me.ucrChkBreaks.Name = "ucrChkBreaks"
        Me.ucrChkBreaks.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBreaks.TabIndex = 0
        '
        'rdoScalesAuto
        '
        Me.rdoScalesAuto.AutoSize = True
        Me.rdoScalesAuto.Location = New System.Drawing.Point(9, 20)
        Me.rdoScalesAuto.Name = "rdoScalesAuto"
        Me.rdoScalesAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoScalesAuto.TabIndex = 3
        Me.rdoScalesAuto.TabStop = True
        Me.rdoScalesAuto.Text = "Auto"
        Me.rdoScalesAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlScales
        '
        Me.ucrPnlScales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlScales.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlScales.Name = "ucrPnlScales"
        Me.ucrPnlScales.Size = New System.Drawing.Size(233, 23)
        Me.ucrPnlScales.TabIndex = 20
        '
        'grpScales
        '
        Me.grpScales.Controls.Add(Me.ucrInputRelaceMissingvalues)
        Me.grpScales.Controls.Add(Me.ucrInputExpand)
        Me.grpScales.Controls.Add(Me.ucrInputTransformation)
        Me.grpScales.Controls.Add(Me.ucrInputPosition)
        Me.grpScales.Controls.Add(Me.ucrChkExpand)
        Me.grpScales.Controls.Add(Me.ucrChkTransformation)
        Me.grpScales.Controls.Add(Me.ucrChkPosition)
        Me.grpScales.Controls.Add(Me.ucrChkNaValue)
        Me.grpScales.Controls.Add(Me.ucrInputUpperLimit)
        Me.grpScales.Controls.Add(Me.ucrInputLowerLimit)
        Me.grpScales.Controls.Add(Me.lblUpperLimit)
        Me.grpScales.Controls.Add(Me.lblLowerLimit)
        Me.grpScales.Controls.Add(Me.rdoScalesCustom)
        Me.grpScales.Controls.Add(Me.rdoScalesAuto)
        Me.grpScales.Controls.Add(Me.ucrPnlScales)
        Me.grpScales.Location = New System.Drawing.Point(4, 97)
        Me.grpScales.Name = "grpScales"
        Me.grpScales.Size = New System.Drawing.Size(274, 228)
        Me.grpScales.TabIndex = 37
        Me.grpScales.TabStop = False
        Me.grpScales.Text = "Scales"
        '
        'ucrInputExpand
        '
        Me.ucrInputExpand.AddQuotesIfUnrecognised = True
        Me.ucrInputExpand.AutoSize = True
        Me.ucrInputExpand.IsMultiline = False
        Me.ucrInputExpand.IsReadOnly = False
        Me.ucrInputExpand.Location = New System.Drawing.Point(191, 187)
        Me.ucrInputExpand.Name = "ucrInputExpand"
        Me.ucrInputExpand.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputExpand.TabIndex = 27
        '
        'ucrInputTransformation
        '
        Me.ucrInputTransformation.AddQuotesIfUnrecognised = True
        Me.ucrInputTransformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTransformation.GetSetSelectedIndex = -1
        Me.ucrInputTransformation.IsReadOnly = False
        Me.ucrInputTransformation.Location = New System.Drawing.Point(191, 159)
        Me.ucrInputTransformation.Name = "ucrInputTransformation"
        Me.ucrInputTransformation.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputTransformation.TabIndex = 26
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(191, 131)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputPosition.TabIndex = 26
        '
        'ucrChkExpand
        '
        Me.ucrChkExpand.AutoSize = True
        Me.ucrChkExpand.Checked = False
        Me.ucrChkExpand.Location = New System.Drawing.Point(6, 187)
        Me.ucrChkExpand.Name = "ucrChkExpand"
        Me.ucrChkExpand.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkExpand.TabIndex = 23
        '
        'ucrChkTransformation
        '
        Me.ucrChkTransformation.AutoSize = True
        Me.ucrChkTransformation.Checked = False
        Me.ucrChkTransformation.Location = New System.Drawing.Point(6, 159)
        Me.ucrChkTransformation.Name = "ucrChkTransformation"
        Me.ucrChkTransformation.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkTransformation.TabIndex = 23
        '
        'ucrChkPosition
        '
        Me.ucrChkPosition.AutoSize = True
        Me.ucrChkPosition.Checked = False
        Me.ucrChkPosition.Location = New System.Drawing.Point(6, 131)
        Me.ucrChkPosition.Name = "ucrChkPosition"
        Me.ucrChkPosition.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkPosition.TabIndex = 23
        '
        'ucrChkNaValue
        '
        Me.ucrChkNaValue.AutoSize = True
        Me.ucrChkNaValue.Checked = False
        Me.ucrChkNaValue.Location = New System.Drawing.Point(6, 103)
        Me.ucrChkNaValue.Name = "ucrChkNaValue"
        Me.ucrChkNaValue.Size = New System.Drawing.Size(202, 23)
        Me.ucrChkNaValue.TabIndex = 23
        '
        'ucrInputUpperLimit
        '
        Me.ucrInputUpperLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputUpperLimit.AutoSize = True
        Me.ucrInputUpperLimit.IsMultiline = False
        Me.ucrInputUpperLimit.IsReadOnly = False
        Me.ucrInputUpperLimit.Location = New System.Drawing.Point(90, 76)
        Me.ucrInputUpperLimit.Name = "ucrInputUpperLimit"
        Me.ucrInputUpperLimit.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputUpperLimit.TabIndex = 22
        '
        'ucrInputLowerLimit
        '
        Me.ucrInputLowerLimit.AddQuotesIfUnrecognised = True
        Me.ucrInputLowerLimit.AutoSize = True
        Me.ucrInputLowerLimit.IsMultiline = False
        Me.ucrInputLowerLimit.IsReadOnly = False
        Me.ucrInputLowerLimit.Location = New System.Drawing.Point(90, 46)
        Me.ucrInputLowerLimit.Name = "ucrInputLowerLimit"
        Me.ucrInputLowerLimit.Size = New System.Drawing.Size(79, 21)
        Me.ucrInputLowerLimit.TabIndex = 22
        '
        'lblUpperLimit
        '
        Me.lblUpperLimit.AutoSize = True
        Me.lblUpperLimit.Location = New System.Drawing.Point(3, 75)
        Me.lblUpperLimit.Name = "lblUpperLimit"
        Me.lblUpperLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblUpperLimit.TabIndex = 5
        Me.lblUpperLimit.Text = "Upper Limit :"
        '
        'lblLowerLimit
        '
        Me.lblLowerLimit.AutoSize = True
        Me.lblLowerLimit.Location = New System.Drawing.Point(3, 48)
        Me.lblLowerLimit.Name = "lblLowerLimit"
        Me.lblLowerLimit.Size = New System.Drawing.Size(66, 13)
        Me.lblLowerLimit.TabIndex = 3
        Me.lblLowerLimit.Text = "Lower Limit :"
        '
        'rdoScalesCustom
        '
        Me.rdoScalesCustom.AutoSize = True
        Me.rdoScalesCustom.Location = New System.Drawing.Point(137, 20)
        Me.rdoScalesCustom.Name = "rdoScalesCustom"
        Me.rdoScalesCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoScalesCustom.TabIndex = 4
        Me.rdoScalesCustom.TabStop = True
        Me.rdoScalesCustom.Text = "Custom"
        Me.rdoScalesCustom.UseVisualStyleBackColor = True
        '
        'rdoMinorBreaksNone
        '
        Me.rdoMinorBreaksNone.AutoSize = True
        Me.rdoMinorBreaksNone.Location = New System.Drawing.Point(278, 20)
        Me.rdoMinorBreaksNone.Name = "rdoMinorBreaksNone"
        Me.rdoMinorBreaksNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoMinorBreaksNone.TabIndex = 22
        Me.rdoMinorBreaksNone.TabStop = True
        Me.rdoMinorBreaksNone.Text = "None"
        Me.rdoMinorBreaksNone.UseVisualStyleBackColor = True
        '
        'ucrChkLabels
        '
        Me.ucrChkLabels.AutoSize = True
        Me.ucrChkLabels.Checked = False
        Me.ucrChkLabels.Location = New System.Drawing.Point(5, 133)
        Me.ucrChkLabels.Name = "ucrChkLabels"
        Me.ucrChkLabels.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkLabels.TabIndex = 22
        '
        'ucrInputMajorBreaksLabels
        '
        Me.ucrInputMajorBreaksLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabels.AutoSize = True
        Me.ucrInputMajorBreaksLabels.IsMultiline = False
        Me.ucrInputMajorBreaksLabels.IsReadOnly = False
        Me.ucrInputMajorBreaksLabels.Location = New System.Drawing.Point(98, 132)
        Me.ucrInputMajorBreaksLabels.Name = "ucrInputMajorBreaksLabels"
        Me.ucrInputMajorBreaksLabels.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputMajorBreaksLabels.TabIndex = 4
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(62, 47)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputTitle.TabIndex = 1
        '
        'ucrPnlAxisTitle
        '
        Me.ucrPnlAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlAxisTitle.Location = New System.Drawing.Point(5, 18)
        Me.ucrPnlAxisTitle.Name = "ucrPnlAxisTitle"
        Me.ucrPnlAxisTitle.Size = New System.Drawing.Size(290, 23)
        Me.ucrPnlAxisTitle.TabIndex = 19
        '
        'rdoMajorBreaksSeq
        '
        Me.rdoMajorBreaksSeq.AutoSize = True
        Me.rdoMajorBreaksSeq.Location = New System.Drawing.Point(98, 21)
        Me.rdoMajorBreaksSeq.Name = "rdoMajorBreaksSeq"
        Me.rdoMajorBreaksSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdoMajorBreaksSeq.TabIndex = 21
        Me.rdoMajorBreaksSeq.TabStop = True
        Me.rdoMajorBreaksSeq.Text = "Sequence"
        Me.rdoMajorBreaksSeq.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(6, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Title:"
        '
        'rdoSpecifyTitle
        '
        Me.rdoSpecifyTitle.AutoSize = True
        Me.rdoSpecifyTitle.Location = New System.Drawing.Point(93, 21)
        Me.rdoSpecifyTitle.Name = "rdoSpecifyTitle"
        Me.rdoSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoSpecifyTitle.TabIndex = 3
        Me.rdoSpecifyTitle.TabStop = True
        Me.rdoSpecifyTitle.Text = "Specify Title"
        Me.rdoSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoNoTitle
        '
        Me.rdoNoTitle.AutoSize = True
        Me.rdoNoTitle.Location = New System.Drawing.Point(214, 21)
        Me.rdoNoTitle.Name = "rdoNoTitle"
        Me.rdoNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitle.TabIndex = 3
        Me.rdoNoTitle.TabStop = True
        Me.rdoNoTitle.Text = "No Title"
        Me.rdoNoTitle.UseVisualStyleBackColor = True
        '
        'grpMinorBreaks
        '
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksNone)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksAuto)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksSeq)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrPnlMinorBreaks)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksCustom)
        Me.grpMinorBreaks.Location = New System.Drawing.Point(417, 204)
        Me.grpMinorBreaks.Name = "grpMinorBreaks"
        Me.grpMinorBreaks.Size = New System.Drawing.Size(354, 121)
        Me.grpMinorBreaks.TabIndex = 41
        Me.grpMinorBreaks.TabStop = False
        Me.grpMinorBreaks.Text = "Minor Tick Marks"
        '
        'lblMinorBreaksFrom
        '
        Me.lblMinorBreaksFrom.AutoSize = True
        Me.lblMinorBreaksFrom.Location = New System.Drawing.Point(9, 48)
        Me.lblMinorBreaksFrom.Name = "lblMinorBreaksFrom"
        Me.lblMinorBreaksFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblMinorBreaksFrom.TabIndex = 34
        Me.lblMinorBreaksFrom.Text = "From:"
        '
        'rdoMinorBreaksAuto
        '
        Me.rdoMinorBreaksAuto.AutoSize = True
        Me.rdoMinorBreaksAuto.Location = New System.Drawing.Point(6, 19)
        Me.rdoMinorBreaksAuto.Name = "rdoMinorBreaksAuto"
        Me.rdoMinorBreaksAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoMinorBreaksAuto.TabIndex = 22
        Me.rdoMinorBreaksAuto.TabStop = True
        Me.rdoMinorBreaksAuto.Text = "Auto"
        Me.rdoMinorBreaksAuto.UseVisualStyleBackColor = True
        '
        'lblMinorBreaksInStepsOf
        '
        Me.lblMinorBreaksInStepsOf.AutoSize = True
        Me.lblMinorBreaksInStepsOf.Location = New System.Drawing.Point(9, 101)
        Me.lblMinorBreaksInStepsOf.Name = "lblMinorBreaksInStepsOf"
        Me.lblMinorBreaksInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblMinorBreaksInStepsOf.TabIndex = 25
        Me.lblMinorBreaksInStepsOf.Text = "In Steps of:"
        '
        'rdoMinorBreaksSeq
        '
        Me.rdoMinorBreaksSeq.AutoSize = True
        Me.rdoMinorBreaksSeq.Location = New System.Drawing.Point(98, 20)
        Me.rdoMinorBreaksSeq.Name = "rdoMinorBreaksSeq"
        Me.rdoMinorBreaksSeq.Size = New System.Drawing.Size(74, 17)
        Me.rdoMinorBreaksSeq.TabIndex = 32
        Me.rdoMinorBreaksSeq.TabStop = True
        Me.rdoMinorBreaksSeq.Text = "Sequence"
        Me.rdoMinorBreaksSeq.UseVisualStyleBackColor = True
        '
        'lblMinorBreaksTo
        '
        Me.lblMinorBreaksTo.AutoSize = True
        Me.lblMinorBreaksTo.Location = New System.Drawing.Point(9, 75)
        Me.lblMinorBreaksTo.Name = "lblMinorBreaksTo"
        Me.lblMinorBreaksTo.Size = New System.Drawing.Size(23, 13)
        Me.lblMinorBreaksTo.TabIndex = 24
        Me.lblMinorBreaksTo.Text = "To:"
        '
        'rdoMinorBreaksCustom
        '
        Me.rdoMinorBreaksCustom.AutoSize = True
        Me.rdoMinorBreaksCustom.Location = New System.Drawing.Point(179, 20)
        Me.rdoMinorBreaksCustom.Name = "rdoMinorBreaksCustom"
        Me.rdoMinorBreaksCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoMinorBreaksCustom.TabIndex = 31
        Me.rdoMinorBreaksCustom.TabStop = True
        Me.rdoMinorBreaksCustom.Text = "Custom"
        Me.rdoMinorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrPnlMinorBreaks
        '
        Me.ucrPnlMinorBreaks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMinorBreaks.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlMinorBreaks.Name = "ucrPnlMinorBreaks"
        Me.ucrPnlMinorBreaks.Size = New System.Drawing.Size(332, 23)
        Me.ucrPnlMinorBreaks.TabIndex = 27
        '
        'ucrInputMinorBreaksFrom
        '
        Me.ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksFrom.AutoSize = True
        Me.ucrInputMinorBreaksFrom.IsMultiline = False
        Me.ucrInputMinorBreaksFrom.IsReadOnly = False
        Me.ucrInputMinorBreaksFrom.Location = New System.Drawing.Point(125, 43)
        Me.ucrInputMinorBreaksFrom.Name = "ucrInputMinorBreaksFrom"
        Me.ucrInputMinorBreaksFrom.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksFrom.TabIndex = 30
        '
        'ucrInputMinorBreaksInStepsOf
        '
        Me.ucrInputMinorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksInStepsOf.AutoSize = True
        Me.ucrInputMinorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMinorBreaksInStepsOf.IsReadOnly = False
        Me.ucrInputMinorBreaksInStepsOf.Location = New System.Drawing.Point(126, 97)
        Me.ucrInputMinorBreaksInStepsOf.Name = "ucrInputMinorBreaksInStepsOf"
        Me.ucrInputMinorBreaksInStepsOf.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksInStepsOf.TabIndex = 28
        '
        'ucrInputMinorBreaksTo
        '
        Me.ucrInputMinorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksTo.AutoSize = True
        Me.ucrInputMinorBreaksTo.IsMultiline = False
        Me.ucrInputMinorBreaksTo.IsReadOnly = False
        Me.ucrInputMinorBreaksTo.Location = New System.Drawing.Point(126, 71)
        Me.ucrInputMinorBreaksTo.Name = "ucrInputMinorBreaksTo"
        Me.ucrInputMinorBreaksTo.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksTo.TabIndex = 29
        '
        'ucrInputMinorBreaksCustom
        '
        Me.ucrInputMinorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksCustom.AutoSize = True
        Me.ucrInputMinorBreaksCustom.IsMultiline = False
        Me.ucrInputMinorBreaksCustom.IsReadOnly = False
        Me.ucrInputMinorBreaksCustom.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputMinorBreaksCustom.Name = "ucrInputMinorBreaksCustom"
        Me.ucrInputMinorBreaksCustom.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMinorBreaksCustom.TabIndex = 26
        '
        'rdoMajorBreaksCustom
        '
        Me.rdoMajorBreaksCustom.AutoSize = True
        Me.rdoMajorBreaksCustom.Location = New System.Drawing.Point(179, 21)
        Me.rdoMajorBreaksCustom.Name = "rdoMajorBreaksCustom"
        Me.rdoMajorBreaksCustom.Size = New System.Drawing.Size(60, 17)
        Me.rdoMajorBreaksCustom.TabIndex = 20
        Me.rdoMajorBreaksCustom.TabStop = True
        Me.rdoMajorBreaksCustom.Text = "Custom"
        Me.rdoMajorBreaksCustom.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksInStepsOf
        '
        Me.ucrInputMajorBreaksInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksInStepsOf.AutoSize = True
        Me.ucrInputMajorBreaksInStepsOf.IsMultiline = False
        Me.ucrInputMajorBreaksInStepsOf.IsReadOnly = False
        Me.ucrInputMajorBreaksInStepsOf.Location = New System.Drawing.Point(114, 99)
        Me.ucrInputMajorBreaksInStepsOf.Name = "ucrInputMajorBreaksInStepsOf"
        Me.ucrInputMajorBreaksInStepsOf.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksInStepsOf.TabIndex = 19
        '
        'rdoMajorBreaksNone
        '
        Me.rdoMajorBreaksNone.AutoSize = True
        Me.rdoMajorBreaksNone.Location = New System.Drawing.Point(278, 21)
        Me.rdoMajorBreaksNone.Name = "rdoMajorBreaksNone"
        Me.rdoMajorBreaksNone.Size = New System.Drawing.Size(56, 17)
        Me.rdoMajorBreaksNone.TabIndex = 3
        Me.rdoMajorBreaksNone.TabStop = True
        Me.rdoMajorBreaksNone.Text = "Aucun"
        Me.rdoMajorBreaksNone.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksTo
        '
        Me.ucrInputMajorBreaksTo.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksTo.AutoSize = True
        Me.ucrInputMajorBreaksTo.IsMultiline = False
        Me.ucrInputMajorBreaksTo.IsReadOnly = False
        Me.ucrInputMajorBreaksTo.Location = New System.Drawing.Point(114, 72)
        Me.ucrInputMajorBreaksTo.Name = "ucrInputMajorBreaksTo"
        Me.ucrInputMajorBreaksTo.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksTo.TabIndex = 19
        '
        'ucrInputMajorBreaksFrom
        '
        Me.ucrInputMajorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksFrom.AutoSize = True
        Me.ucrInputMajorBreaksFrom.IsMultiline = False
        Me.ucrInputMajorBreaksFrom.IsReadOnly = False
        Me.ucrInputMajorBreaksFrom.Location = New System.Drawing.Point(114, 46)
        Me.ucrInputMajorBreaksFrom.Name = "ucrInputMajorBreaksFrom"
        Me.ucrInputMajorBreaksFrom.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMajorBreaksFrom.TabIndex = 19
        '
        'rdoMajorBreaksAuto
        '
        Me.rdoMajorBreaksAuto.AutoSize = True
        Me.rdoMajorBreaksAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoMajorBreaksAuto.Name = "rdoMajorBreaksAuto"
        Me.rdoMajorBreaksAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoMajorBreaksAuto.TabIndex = 2
        Me.rdoMajorBreaksAuto.TabStop = True
        Me.rdoMajorBreaksAuto.Text = "Auto"
        Me.rdoMajorBreaksAuto.UseVisualStyleBackColor = True
        '
        'lblMajorBreaksInStepsOf
        '
        Me.lblMajorBreaksInStepsOf.AutoSize = True
        Me.lblMajorBreaksInStepsOf.Location = New System.Drawing.Point(9, 103)
        Me.lblMajorBreaksInStepsOf.Name = "lblMajorBreaksInStepsOf"
        Me.lblMajorBreaksInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblMajorBreaksInStepsOf.TabIndex = 9
        Me.lblMajorBreaksInStepsOf.Text = "In Steps of:"
        '
        'lblMajorBreaksFrom
        '
        Me.lblMajorBreaksFrom.AutoSize = True
        Me.lblMajorBreaksFrom.Location = New System.Drawing.Point(9, 50)
        Me.lblMajorBreaksFrom.Name = "lblMajorBreaksFrom"
        Me.lblMajorBreaksFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblMajorBreaksFrom.TabIndex = 5
        Me.lblMajorBreaksFrom.Text = "From:"
        '
        'lblMajorBreaksTo
        '
        Me.lblMajorBreaksTo.AutoSize = True
        Me.lblMajorBreaksTo.Location = New System.Drawing.Point(9, 75)
        Me.lblMajorBreaksTo.Name = "lblMajorBreaksTo"
        Me.lblMajorBreaksTo.Size = New System.Drawing.Size(23, 13)
        Me.lblMajorBreaksTo.TabIndex = 6
        Me.lblMajorBreaksTo.Text = "To:"
        '
        'ucrPnlMajorBreaks
        '
        Me.ucrPnlMajorBreaks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMajorBreaks.Location = New System.Drawing.Point(3, 19)
        Me.ucrPnlMajorBreaks.Name = "ucrPnlMajorBreaks"
        Me.ucrPnlMajorBreaks.Size = New System.Drawing.Size(335, 23)
        Me.ucrPnlMajorBreaks.TabIndex = 18
        '
        'rdoTitleAuto
        '
        Me.rdoTitleAuto.AutoSize = True
        Me.rdoTitleAuto.Location = New System.Drawing.Point(6, 21)
        Me.rdoTitleAuto.Name = "rdoTitleAuto"
        Me.rdoTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoTitleAuto.TabIndex = 2
        Me.rdoTitleAuto.TabStop = True
        Me.rdoTitleAuto.Text = "Auto"
        Me.rdoTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrInputMajorBreaksCustom
        '
        Me.ucrInputMajorBreaksCustom.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksCustom.AutoSize = True
        Me.ucrInputMajorBreaksCustom.IsMultiline = False
        Me.ucrInputMajorBreaksCustom.IsReadOnly = False
        Me.ucrInputMajorBreaksCustom.Location = New System.Drawing.Point(6, 46)
        Me.ucrInputMajorBreaksCustom.Name = "ucrInputMajorBreaksCustom"
        Me.ucrInputMajorBreaksCustom.Size = New System.Drawing.Size(238, 21)
        Me.ucrInputMajorBreaksCustom.TabIndex = 15
        '
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAxisType.GetSetSelectedIndex = -1
        Me.ucrInputAxisType.IsReadOnly = False
        Me.ucrInputAxisType.Location = New System.Drawing.Point(634, 14)
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        Me.ucrInputAxisType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAxisType.TabIndex = 38
        '
        'grpAxisTitle
        '
        Me.grpAxisTitle.Controls.Add(Me.lblTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoSpecifyTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoNoTitle)
        Me.grpAxisTitle.Controls.Add(Me.rdoTitleAuto)
        Me.grpAxisTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpAxisTitle.Controls.Add(Me.ucrPnlAxisTitle)
        Me.grpAxisTitle.Location = New System.Drawing.Point(4, 8)
        Me.grpAxisTitle.Name = "grpAxisTitle"
        Me.grpAxisTitle.Size = New System.Drawing.Size(301, 83)
        Me.grpAxisTitle.TabIndex = 35
        Me.grpAxisTitle.TabStop = False
        Me.grpAxisTitle.Text = "Axis Title"
        '
        'grpMajorBreaks
        '
        Me.grpMajorBreaks.Controls.Add(Me.ucrChkLabels)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksLabels)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksSeq)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksCustom)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksNone)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.rdoMajorBreaksAuto)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksInStepsOf)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksFrom)
        Me.grpMajorBreaks.Controls.Add(Me.lblMajorBreaksTo)
        Me.grpMajorBreaks.Controls.Add(Me.ucrPnlMajorBreaks)
        Me.grpMajorBreaks.Controls.Add(Me.ucrInputMajorBreaksCustom)
        Me.grpMajorBreaks.Location = New System.Drawing.Point(417, 36)
        Me.grpMajorBreaks.Name = "grpMajorBreaks"
        Me.grpMajorBreaks.Size = New System.Drawing.Size(354, 162)
        Me.grpMajorBreaks.TabIndex = 36
        Me.grpMajorBreaks.TabStop = False
        Me.grpMajorBreaks.Text = "Major Tick Marks"
        '
        'grpSecondAxis
        '
        Me.grpSecondAxis.Controls.Add(Me.ucrInputTrans)
        Me.grpSecondAxis.Controls.Add(Me.ucrInputOffset)
        Me.grpSecondAxis.Controls.Add(Me.rdoSecondAxisSpecifyTitle)
        Me.grpSecondAxis.Controls.Add(Me.rdoSecondAxisNoTitle)
        Me.grpSecondAxis.Controls.Add(Me.rdoSecondAxisTitleAuto)
        Me.grpSecondAxis.Controls.Add(Me.ucrPnlSecondAxisTitle)
        Me.grpSecondAxis.Controls.Add(Me.lblTitleSA)
        Me.grpSecondAxis.Controls.Add(Me.ucrInputTextNameSAxis)
        Me.grpSecondAxis.Controls.Add(Me.ucrInputSecondaryAxis)
        Me.grpSecondAxis.Controls.Add(Me.ucrChkSecondaryAxis)
        Me.grpSecondAxis.Controls.Add(Me.ucrChkOffset)
        Me.grpSecondAxis.Location = New System.Drawing.Point(3, 324)
        Me.grpSecondAxis.Name = "grpSecondAxis"
        Me.grpSecondAxis.Size = New System.Drawing.Size(384, 109)
        Me.grpSecondAxis.TabIndex = 35
        Me.grpSecondAxis.TabStop = False
        Me.grpSecondAxis.Text = "Secondary Axis"
        '
        'ucrInputOffset
        '
        Me.ucrInputOffset.AddQuotesIfUnrecognised = True
        Me.ucrInputOffset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOffset.GetSetSelectedIndex = -1
        Me.ucrInputOffset.IsReadOnly = False
        Me.ucrInputOffset.Location = New System.Drawing.Point(325, 16)
        Me.ucrInputOffset.Name = "ucrInputOffset"
        Me.ucrInputOffset.Size = New System.Drawing.Size(40, 23)
        Me.ucrInputOffset.TabIndex = 35
        '
        'ucrChkOffset
        '
        Me.ucrChkOffset.AutoSize = True
        Me.ucrChkOffset.Checked = False
        Me.ucrChkOffset.Location = New System.Drawing.Point(267, 17)
        Me.ucrChkOffset.Name = "ucrChkOffset"
        Me.ucrChkOffset.Size = New System.Drawing.Size(93, 23)
        Me.ucrChkOffset.TabIndex = 36
        '
        'rdoSecondAxisSpecifyTitle
        '
        Me.rdoSecondAxisSpecifyTitle.AutoSize = True
        Me.rdoSecondAxisSpecifyTitle.Location = New System.Drawing.Point(94, 53)
        Me.rdoSecondAxisSpecifyTitle.Name = "rdoSecondAxisSpecifyTitle"
        Me.rdoSecondAxisSpecifyTitle.Size = New System.Drawing.Size(83, 17)
        Me.rdoSecondAxisSpecifyTitle.TabIndex = 32
        Me.rdoSecondAxisSpecifyTitle.TabStop = True
        Me.rdoSecondAxisSpecifyTitle.Text = "Specify Title"
        Me.rdoSecondAxisSpecifyTitle.UseVisualStyleBackColor = True
        '
        'rdoSecondAxisNoTitle
        '
        Me.rdoSecondAxisNoTitle.AutoSize = True
        Me.rdoSecondAxisNoTitle.Location = New System.Drawing.Point(215, 53)
        Me.rdoSecondAxisNoTitle.Name = "rdoSecondAxisNoTitle"
        Me.rdoSecondAxisNoTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoSecondAxisNoTitle.TabIndex = 33
        Me.rdoSecondAxisNoTitle.TabStop = True
        Me.rdoSecondAxisNoTitle.Text = "No Title"
        Me.rdoSecondAxisNoTitle.UseVisualStyleBackColor = True
        '
        'rdoSecondAxisTitleAuto
        '
        Me.rdoSecondAxisTitleAuto.AutoSize = True
        Me.rdoSecondAxisTitleAuto.Location = New System.Drawing.Point(7, 53)
        Me.rdoSecondAxisTitleAuto.Name = "rdoSecondAxisTitleAuto"
        Me.rdoSecondAxisTitleAuto.Size = New System.Drawing.Size(47, 17)
        Me.rdoSecondAxisTitleAuto.TabIndex = 31
        Me.rdoSecondAxisTitleAuto.TabStop = True
        Me.rdoSecondAxisTitleAuto.Text = "Auto"
        Me.rdoSecondAxisTitleAuto.UseVisualStyleBackColor = True
        '
        'ucrPnlSecondAxisTitle
        '
        Me.ucrPnlSecondAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSecondAxisTitle.Location = New System.Drawing.Point(6, 50)
        Me.ucrPnlSecondAxisTitle.Name = "ucrPnlSecondAxisTitle"
        Me.ucrPnlSecondAxisTitle.Size = New System.Drawing.Size(290, 23)
        Me.ucrPnlSecondAxisTitle.TabIndex = 34
        '
        'lblTitleSA
        '
        Me.lblTitleSA.AutoSize = True
        Me.lblTitleSA.Location = New System.Drawing.Point(4, 83)
        Me.lblTitleSA.Name = "lblTitleSA"
        Me.lblTitleSA.Size = New System.Drawing.Size(30, 13)
        Me.lblTitleSA.TabIndex = 30
        Me.lblTitleSA.Text = "Title:"
        '
        'ucrInputTextNameSAxis
        '
        Me.ucrInputTextNameSAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputTextNameSAxis.AutoSize = True
        Me.ucrInputTextNameSAxis.IsMultiline = False
        Me.ucrInputTextNameSAxis.IsReadOnly = False
        Me.ucrInputTextNameSAxis.Location = New System.Drawing.Point(62, 80)
        Me.ucrInputTextNameSAxis.Name = "ucrInputTextNameSAxis"
        Me.ucrInputTextNameSAxis.Size = New System.Drawing.Size(131, 21)
        Me.ucrInputTextNameSAxis.TabIndex = 29
        '
        'ucrInputSecondaryAxis
        '
        Me.ucrInputSecondaryAxis.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondaryAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSecondaryAxis.GetSetSelectedIndex = -1
        Me.ucrInputSecondaryAxis.IsReadOnly = False
        Me.ucrInputSecondaryAxis.Location = New System.Drawing.Point(107, 15)
        Me.ucrInputSecondaryAxis.Name = "ucrInputSecondaryAxis"
        Me.ucrInputSecondaryAxis.Size = New System.Drawing.Size(40, 23)
        Me.ucrInputSecondaryAxis.TabIndex = 27
        '
        'ucrChkSecondaryAxis
        '
        Me.ucrChkSecondaryAxis.AutoSize = True
        Me.ucrChkSecondaryAxis.Checked = False
        Me.ucrChkSecondaryAxis.Location = New System.Drawing.Point(9, 17)
        Me.ucrChkSecondaryAxis.Name = "ucrChkSecondaryAxis"
        Me.ucrChkSecondaryAxis.Size = New System.Drawing.Size(124, 23)
        Me.ucrChkSecondaryAxis.TabIndex = 24
        '
        'ucrInputTrans
        '
        Me.ucrInputTrans.AddQuotesIfUnrecognised = True
        Me.ucrInputTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTrans.GetSetSelectedIndex = -1
        Me.ucrInputTrans.IsReadOnly = False
        Me.ucrInputTrans.Location = New System.Drawing.Point(170, 15)
        Me.ucrInputTrans.Name = "ucrInputTrans"
        Me.ucrInputTrans.Size = New System.Drawing.Size(78, 23)
        Me.ucrInputTrans.TabIndex = 37
        '
        'ucrAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.grpScaleDiscrete)
        Me.Controls.Add(Me.grpSecondAxis)
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpScaleXDate)
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpMinorBreaks)
        Me.Controls.Add(Me.ucrInputAxisType)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Controls.Add(Me.grpMajorBreaksDiscrete)
        Me.Controls.Add(Me.grpMajorBreaks)
        Me.Name = "ucrAxes"
        Me.Size = New System.Drawing.Size(774, 334)
        Me.grpScaleDiscrete.ResumeLayout(False)
        Me.grpScaleDiscrete.PerformLayout()
        Me.grpMajorBreaksDiscrete.ResumeLayout(False)
        Me.grpMajorBreaksDiscrete.PerformLayout()
        Me.Size = New System.Drawing.Size(670, 489)
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpMajorBreaks.ResumeLayout(False)
        Me.grpMajorBreaks.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.grpScaleXDate.ResumeLayout(False)
        Me.grpScaleXDate.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.grpMinorBreaks.ResumeLayout(False)
        Me.grpMinorBreaks.PerformLayout()
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpMajorBreaks.ResumeLayout(False)
        Me.grpMajorBreaks.PerformLayout()
        Me.grpSecondAxis.ResumeLayout(False)
        Me.grpSecondAxis.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpScaleDiscrete As GroupBox
    Friend WithEvents ucrInputNaValueDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputExpandDiscrete As ucrInputTextBox
    Friend WithEvents ucrInputDropUnusedLevels As ucrInputComboBox
    Friend WithEvents ucrInputPositionDiscrete As ucrInputComboBox
    Friend WithEvents ucrChkExpandDiscrete As ucrCheck
    Friend WithEvents ucrChkDropUnusedLevels As ucrCheck
    Friend WithEvents ucrChkPositionDiscrete As ucrCheck
    Friend WithEvents ucrChkNaValueDiscrete As ucrCheck
    Friend WithEvents ucrInputRelaceMissingvalues As ucrInputTextBox
    Friend WithEvents ucrChkLabelsDiscrete As ucrCheck
    Friend WithEvents ucrInputMajorBreaksLabelsDiscrete As ucrInputTextBox
    Friend WithEvents grpMajorBreaksDiscrete As GroupBox
    Friend WithEvents ucrInputComboDateLabel As ucrInputComboBox
    Friend WithEvents grpScaleXDate As GroupBox
    Friend WithEvents ucrChkDateLabels As ucrCheck
    Friend WithEvents ucrInputComboDateBreak As ucrInputComboBox
    Friend WithEvents lbXscaleDateLowerLimit As Label
    Friend WithEvents lblXScalDateUpperLimit As Label
    Friend WithEvents ucrNudDateBreak As ucrNud
    Friend WithEvents ucrDtpLowerLimit As ucrDateTimePicker
    Friend WithEvents ucrDtpUpperLimit As ucrDateTimePicker
    Friend WithEvents ucrChkLimits As ucrCheck
    Friend WithEvents ucrChkBreaks As ucrCheck
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents grpScales As GroupBox
    Friend WithEvents ucrInputExpand As ucrInputTextBox
    Friend WithEvents ucrInputTransformation As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkExpand As ucrCheck
    Friend WithEvents ucrChkTransformation As ucrCheck
    Friend WithEvents ucrChkPosition As ucrCheck
    Friend WithEvents ucrChkNaValue As ucrCheck
    Friend WithEvents ucrInputUpperLimit As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimit As ucrInputTextBox
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoMinorBreaksNone As RadioButton
    Friend WithEvents ucrChkLabels As ucrCheck
    Friend WithEvents ucrInputMajorBreaksLabels As ucrInputTextBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents rdoMajorBreaksSeq As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents rdoSpecifyTitle As RadioButton
    Friend WithEvents rdoNoTitle As RadioButton
    Friend WithEvents grpMinorBreaks As GroupBox
    Friend WithEvents lblMinorBreaksFrom As Label
    Friend WithEvents rdoMinorBreaksAuto As RadioButton
    Friend WithEvents lblMinorBreaksInStepsOf As Label
    Friend WithEvents rdoMinorBreaksSeq As RadioButton
    Friend WithEvents lblMinorBreaksTo As Label
    Friend WithEvents rdoMinorBreaksCustom As RadioButton
    Friend WithEvents ucrPnlMinorBreaks As UcrPanel
    Friend WithEvents ucrInputMinorBreaksFrom As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksCustom As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksCustom As RadioButton
    Friend WithEvents ucrInputMajorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksNone As RadioButton
    Friend WithEvents ucrInputMajorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksAuto As RadioButton
    Friend WithEvents lblMajorBreaksInStepsOf As Label
    Friend WithEvents lblMajorBreaksFrom As Label
    Friend WithEvents lblMajorBreaksTo As Label
    Friend WithEvents ucrPnlMajorBreaks As UcrPanel
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrInputMajorBreaksCustom As ucrInputTextBox
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents grpMajorBreaks As GroupBox
    Friend WithEvents ucrInputBreaksDiscrete As ucrInputTextBox
    Friend WithEvents ucrChkBreakDiscret As ucrCheck
    Friend WithEvents ucrInputLimitDiscrete As ucrInputTextBox
    Friend WithEvents ucrChkLimit As ucrCheck
    Friend WithEvents ucrChkLimitsFrom As ucrCheck
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblMinorBreaksInStepsOf As Label
    Friend WithEvents lblMinorBreaksTo As Label
    Friend WithEvents ucrPnlMinorBreaks As UcrPanel
    Friend WithEvents grpMinorBreaks As GroupBox
    Friend WithEvents lblMinorBreaksFrom As Label
    Friend WithEvents rdoMinorBreaksNone As RadioButton
    Friend WithEvents ucrChkLabels As ucrCheck
    Friend WithEvents ucrInputTransformation As ucrInputComboBox
    Friend WithEvents ucrInputPosition As ucrInputComboBox
    Friend WithEvents ucrChkNaValue As ucrCheck
    Friend WithEvents ucrInputExpand As ucrInputTextBox
    Friend WithEvents ucrInputRelaceMissingvalues As ucrInputTextBox
    Friend WithEvents ucrChkPosition As ucrCheck
    Friend WithEvents ucrChkExpand As ucrCheck
    Friend WithEvents ucrChkTransformation As ucrCheck
    Friend WithEvents grpScaleXDate As GroupBox
    Friend WithEvents ucrChkLimits As ucrCheck
    Friend WithEvents ucrChkBreaks As ucrCheck
    Friend WithEvents lbXscaleDateLowerLimit As Label
    Friend WithEvents lblXScalDateUpperLimit As Label
    Friend WithEvents ucrNudDateBreak As ucrNud
    Friend WithEvents ucrDtpLowerLimit As ucrDateTimePicker
    Friend WithEvents ucrDtpUpperLimit As ucrDateTimePicker
    Friend WithEvents ucrInputComboDateBreak As ucrInputComboBox
    Friend WithEvents ucrChkDateLabels As ucrCheck
    Friend WithEvents ucrInputComboDateLabel As ucrInputComboBox
    Friend WithEvents grpSecondAxis As GroupBox
    Friend WithEvents ucrInputSecondaryAxis As ucrInputComboBox
    Friend WithEvents ucrChkSecondaryAxis As ucrCheck
    Friend WithEvents ucrInputTextNameSAxis As ucrInputTextBox
    Friend WithEvents lblTitleSA As Label
    Friend WithEvents rdoSecondAxisSpecifyTitle As RadioButton
    Friend WithEvents rdoSecondAxisNoTitle As RadioButton
    Friend WithEvents rdoSecondAxisTitleAuto As RadioButton
    Friend WithEvents ucrPnlSecondAxisTitle As UcrPanel
    Friend WithEvents ucrChkOffset As ucrCheck
    Friend WithEvents ucrInputOffset As ucrInputComboBox
    Friend WithEvents ucrInputTrans As ucrInputComboBox
End Class
