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
        Me.grpAxisTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rdoSpecifyTitle = New System.Windows.Forms.RadioButton()
        Me.rdoNoTitle = New System.Windows.Forms.RadioButton()
        Me.rdoTitleAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrPnlAxisTitle = New instat.UcrPanel()
        Me.grpMajorBreaks = New System.Windows.Forms.GroupBox()
        Me.ucrChkLabels = New instat.ucrCheck()
        Me.ucrInputMajorBreaksLabels = New instat.ucrInputTextBox()
        Me.rdoMajorBreaksSeq = New System.Windows.Forms.RadioButton()
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
        Me.ucrInputMajorBreaksCustom = New instat.ucrInputTextBox()
        Me.grpScales = New System.Windows.Forms.GroupBox()
        Me.ucrInputRelaceMissingvalues = New instat.ucrInputTextBox()
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
        Me.rdoScalesAuto = New System.Windows.Forms.RadioButton()
        Me.ucrPnlScales = New instat.UcrPanel()
        Me.grpScaleXDate = New System.Windows.Forms.GroupBox()
        Me.ucrInputComboDateLabel = New instat.ucrInputComboBox()
        Me.ucrChkDateLabels = New instat.ucrCheck()
        Me.ucrInputComboDateBreak = New instat.ucrInputComboBox()
        Me.lbXscaleDateLowerLimit = New System.Windows.Forms.Label()
        Me.lblXScalDateUpperLimit = New System.Windows.Forms.Label()
        Me.ucrNudDateBreak = New instat.ucrNud()
        Me.ucrDtpLowerLimit = New instat.ucrDateTimePicker()
        Me.ucrDtpUpperLimit = New instat.ucrDateTimePicker()
        Me.ucrChkLimits = New instat.ucrCheck()
        Me.ucrChkBreaks = New instat.ucrCheck()
        Me.ucrInputAxisType = New instat.ucrInputComboBox()
        Me.rdoMinorBreaksSeq = New System.Windows.Forms.RadioButton()
        Me.rdoMinorBreaksCustom = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksTo = New instat.ucrInputTextBox()
        Me.ucrInputMinorBreaksFrom = New instat.ucrInputTextBox()
        Me.rdoMinorBreaksAuto = New System.Windows.Forms.RadioButton()
        Me.ucrInputMinorBreaksCustom = New instat.ucrInputTextBox()
        Me.lblMinorBreaksInStepsOf = New System.Windows.Forms.Label()
        Me.lblMinorBreaksTo = New System.Windows.Forms.Label()
        Me.ucrPnlMinorBreaks = New instat.UcrPanel()
        Me.grpMinorBreaks = New System.Windows.Forms.GroupBox()
        Me.lblMinorBreaksFrom = New System.Windows.Forms.Label()
        Me.rdoMinorBreaksNone = New System.Windows.Forms.RadioButton()
        Me.grpAxisTitle.SuspendLayout()
        Me.grpMajorBreaks.SuspendLayout()
        Me.grpScales.SuspendLayout()
        Me.grpScaleXDate.SuspendLayout()
        Me.grpMinorBreaks.SuspendLayout()
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
        Me.grpMajorBreaks.Location = New System.Drawing.Point(310, 29)
        Me.grpMajorBreaks.Name = "grpMajorBreaks"
        Me.grpMajorBreaks.Size = New System.Drawing.Size(354, 162)
        Me.grpMajorBreaks.TabIndex = 1
        Me.grpMajorBreaks.TabStop = False
        Me.grpMajorBreaks.Text = "Major Tick Marks"
        '
        'ucrChkLabels
        '
        Me.ucrChkLabels.AutoSize = True
        Me.ucrChkLabels.Checked = False
        Me.ucrChkLabels.Location = New System.Drawing.Point(5, 133)
        Me.ucrChkLabels.Name = "ucrChkLabels"
        Me.ucrChkLabels.Size = New System.Drawing.Size(65, 23)
        Me.ucrChkLabels.TabIndex = 22
        '
        'ucrInputMajorBreaksLabels
        '
        Me.ucrInputMajorBreaksLabels.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorBreaksLabels.AutoSize = True
        Me.ucrInputMajorBreaksLabels.IsMultiline = False
        Me.ucrInputMajorBreaksLabels.IsReadOnly = False
        Me.ucrInputMajorBreaksLabels.Location = New System.Drawing.Point(74, 132)
        Me.ucrInputMajorBreaksLabels.Name = "ucrInputMajorBreaksLabels"
        Me.ucrInputMajorBreaksLabels.Size = New System.Drawing.Size(170, 21)
        Me.ucrInputMajorBreaksLabels.TabIndex = 4
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
        Me.ucrInputMajorBreaksInStepsOf.Location = New System.Drawing.Point(74, 99)
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
        Me.ucrInputMajorBreaksTo.Location = New System.Drawing.Point(74, 72)
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
        Me.ucrInputMajorBreaksFrom.Location = New System.Drawing.Point(74, 46)
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
        Me.grpScales.Location = New System.Drawing.Point(3, 90)
        Me.grpScales.Name = "grpScales"
        Me.grpScales.Size = New System.Drawing.Size(274, 228)
        Me.grpScales.TabIndex = 2
        Me.grpScales.TabStop = False
        Me.grpScales.Text = "Scales"
        '
        'ucrInputRelaceMissingvalues
        '
        Me.ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = True
        Me.ucrInputRelaceMissingvalues.AutoSize = True
        Me.ucrInputRelaceMissingvalues.IsMultiline = False
        Me.ucrInputRelaceMissingvalues.IsReadOnly = False
        Me.ucrInputRelaceMissingvalues.Location = New System.Drawing.Point(112, 103)
        Me.ucrInputRelaceMissingvalues.Name = "ucrInputRelaceMissingvalues"
        Me.ucrInputRelaceMissingvalues.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputRelaceMissingvalues.TabIndex = 27
        '
        'ucrInputExpand
        '
        Me.ucrInputExpand.AddQuotesIfUnrecognised = True
        Me.ucrInputExpand.AutoSize = True
        Me.ucrInputExpand.IsMultiline = False
        Me.ucrInputExpand.IsReadOnly = False
        Me.ucrInputExpand.Location = New System.Drawing.Point(112, 187)
        Me.ucrInputExpand.Name = "ucrInputExpand"
        Me.ucrInputExpand.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputExpand.TabIndex = 27
        '
        'ucrInputTransformation
        '
        Me.ucrInputTransformation.AddQuotesIfUnrecognised = True
        Me.ucrInputTransformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTransformation.GetSetSelectedIndex = -1
        Me.ucrInputTransformation.IsReadOnly = False
        Me.ucrInputTransformation.Location = New System.Drawing.Point(112, 159)
        Me.ucrInputTransformation.Name = "ucrInputTransformation"
        Me.ucrInputTransformation.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputTransformation.TabIndex = 26
        '
        'ucrInputPosition
        '
        Me.ucrInputPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPosition.GetSetSelectedIndex = -1
        Me.ucrInputPosition.IsReadOnly = False
        Me.ucrInputPosition.Location = New System.Drawing.Point(112, 131)
        Me.ucrInputPosition.Name = "ucrInputPosition"
        Me.ucrInputPosition.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputPosition.TabIndex = 26
        '
        'ucrChkExpand
        '
        Me.ucrChkExpand.AutoSize = True
        Me.ucrChkExpand.Checked = False
        Me.ucrChkExpand.Location = New System.Drawing.Point(6, 187)
        Me.ucrChkExpand.Name = "ucrChkExpand"
        Me.ucrChkExpand.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkExpand.TabIndex = 23
        '
        'ucrChkTransformation
        '
        Me.ucrChkTransformation.AutoSize = True
        Me.ucrChkTransformation.Checked = False
        Me.ucrChkTransformation.Location = New System.Drawing.Point(6, 159)
        Me.ucrChkTransformation.Name = "ucrChkTransformation"
        Me.ucrChkTransformation.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkTransformation.TabIndex = 23
        '
        'ucrChkPosition
        '
        Me.ucrChkPosition.AutoSize = True
        Me.ucrChkPosition.Checked = False
        Me.ucrChkPosition.Location = New System.Drawing.Point(6, 131)
        Me.ucrChkPosition.Name = "ucrChkPosition"
        Me.ucrChkPosition.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPosition.TabIndex = 23
        '
        'ucrChkNaValue
        '
        Me.ucrChkNaValue.AutoSize = True
        Me.ucrChkNaValue.Checked = False
        Me.ucrChkNaValue.Location = New System.Drawing.Point(6, 103)
        Me.ucrChkNaValue.Name = "ucrChkNaValue"
        Me.ucrChkNaValue.Size = New System.Drawing.Size(100, 23)
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
        Me.grpScaleXDate.Location = New System.Drawing.Point(3, 90)
        Me.grpScaleXDate.Name = "grpScaleXDate"
        Me.grpScaleXDate.Size = New System.Drawing.Size(301, 153)
        Me.grpScaleXDate.TabIndex = 34
        Me.grpScaleXDate.TabStop = False
        Me.grpScaleXDate.Text = "Date Scales"
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
        'ucrInputAxisType
        '
        Me.ucrInputAxisType.AddQuotesIfUnrecognised = True
        Me.ucrInputAxisType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAxisType.GetSetSelectedIndex = -1
        Me.ucrInputAxisType.IsReadOnly = False
        Me.ucrInputAxisType.Location = New System.Drawing.Point(527, 7)
        Me.ucrInputAxisType.Name = "ucrInputAxisType"
        Me.ucrInputAxisType.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputAxisType.TabIndex = 3
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
        'ucrInputMinorBreaksFrom
        '
        Me.ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorBreaksFrom.AutoSize = True
        Me.ucrInputMinorBreaksFrom.IsMultiline = False
        Me.ucrInputMinorBreaksFrom.IsReadOnly = False
        Me.ucrInputMinorBreaksFrom.Location = New System.Drawing.Point(74, 45)
        Me.ucrInputMinorBreaksFrom.Name = "ucrInputMinorBreaksFrom"
        Me.ucrInputMinorBreaksFrom.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputMinorBreaksFrom.TabIndex = 30
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
        'lblMinorBreaksInStepsOf
        '
        Me.lblMinorBreaksInStepsOf.AutoSize = True
        Me.lblMinorBreaksInStepsOf.Location = New System.Drawing.Point(9, 101)
        Me.lblMinorBreaksInStepsOf.Name = "lblMinorBreaksInStepsOf"
        Me.lblMinorBreaksInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblMinorBreaksInStepsOf.TabIndex = 25
        Me.lblMinorBreaksInStepsOf.Text = "In Steps of:"
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
        'ucrPnlMinorBreaks
        '
        Me.ucrPnlMinorBreaks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMinorBreaks.Location = New System.Drawing.Point(6, 16)
        Me.ucrPnlMinorBreaks.Name = "ucrPnlMinorBreaks"
        Me.ucrPnlMinorBreaks.Size = New System.Drawing.Size(332, 23)
        Me.ucrPnlMinorBreaks.TabIndex = 27
        '
        'grpMinorBreaks
        '
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksNone)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksAuto)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksSeq)
        Me.grpMinorBreaks.Controls.Add(Me.lblMinorBreaksTo)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.rdoMinorBreaksCustom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrPnlMinorBreaks)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksFrom)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksInStepsOf)
        Me.grpMinorBreaks.Controls.Add(Me.ucrInputMinorBreaksTo)
        Me.grpMinorBreaks.Location = New System.Drawing.Point(310, 197)
        Me.grpMinorBreaks.Name = "grpMinorBreaks"
        Me.grpMinorBreaks.Size = New System.Drawing.Size(354, 121)
        Me.grpMinorBreaks.TabIndex = 33
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
        'ucrAxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.grpScaleXDate)
        Me.Controls.Add(Me.grpMinorBreaks)
        Me.Controls.Add(Me.ucrInputAxisType)
        Me.Controls.Add(Me.grpScales)
        Me.Controls.Add(Me.grpMajorBreaks)
        Me.Controls.Add(Me.grpAxisTitle)
        Me.Name = "ucrAxes"
        Me.Size = New System.Drawing.Size(667, 334)
        Me.grpAxisTitle.ResumeLayout(False)
        Me.grpAxisTitle.PerformLayout()
        Me.grpMajorBreaks.ResumeLayout(False)
        Me.grpMajorBreaks.PerformLayout()
        Me.grpScales.ResumeLayout(False)
        Me.grpScales.PerformLayout()
        Me.grpScaleXDate.ResumeLayout(False)
        Me.grpScaleXDate.PerformLayout()
        Me.grpMinorBreaks.ResumeLayout(False)
        Me.grpMinorBreaks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpAxisTitle As GroupBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents grpMajorBreaks As GroupBox
    Friend WithEvents lblMajorBreaksFrom As Label
    Friend WithEvents rdoMajorBreaksNone As RadioButton
    Friend WithEvents rdoMajorBreaksAuto As RadioButton
    Friend WithEvents lblMajorBreaksTo As Label
    Friend WithEvents lblMajorBreaksInStepsOf As Label
    Friend WithEvents ucrInputMajorBreaksCustom As ucrInputTextBox

    Friend WithEvents grpScales As GroupBox
    Friend WithEvents rdoScalesCustom As RadioButton
    Friend WithEvents rdoScalesAuto As RadioButton
    Friend WithEvents lblUpperLimit As Label
    Friend WithEvents lblLowerLimit As Label
    Friend WithEvents rdoNoTitle As RadioButton
    Friend WithEvents rdoTitleAuto As RadioButton
    Friend WithEvents ucrPnlAxisTitle As UcrPanel
    Friend WithEvents ucrPnlMajorBreaks As UcrPanel
    Friend WithEvents ucrPnlScales As UcrPanel
    Friend WithEvents ucrInputUpperLimit As ucrInputTextBox
    Friend WithEvents ucrInputLowerLimit As ucrInputTextBox
    Friend WithEvents rdoSpecifyTitle As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrInputMajorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMajorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMajorBreaksSeq As RadioButton
    Friend WithEvents rdoMajorBreaksCustom As RadioButton
    Friend WithEvents ucrInputAxisType As ucrInputComboBox
    Friend WithEvents ucrInputMajorBreaksLabels As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksSeq As RadioButton
    Friend WithEvents rdoMinorBreaksCustom As RadioButton
    Friend WithEvents ucrInputMinorBreaksInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksTo As ucrInputTextBox
    Friend WithEvents ucrInputMinorBreaksFrom As ucrInputTextBox
    Friend WithEvents rdoMinorBreaksAuto As RadioButton
    Friend WithEvents ucrInputMinorBreaksCustom As ucrInputTextBox
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
End Class
