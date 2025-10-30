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
Partial Class dlgTransformText
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
        Me.lblColumnToTransform = New System.Windows.Forms.Label()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblSideTrunc = New System.Windows.Forms.Label()
        Me.lblSide = New System.Windows.Forms.Label()
        Me.lblWidthWrap = New System.Windows.Forms.Label()
        Me.lblWidthTrunc = New System.Windows.Forms.Label()
        Me.rdoSquish = New System.Windows.Forms.RadioButton()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoMiddle = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoBothSide = New System.Windows.Forms.RadioButton()
        Me.rdoRightSide = New System.Windows.Forms.RadioButton()
        Me.rdoLeftSide = New System.Windows.Forms.RadioButton()
        Me.rdoCase = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoWrap = New System.Windows.Forms.RadioButton()
        Me.rdoTruncate = New System.Windows.Forms.RadioButton()
        Me.grpVar = New System.Windows.Forms.GroupBox()
        Me.rdoMultiple = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.ucrChkOverWriteColumns = New instat.ucrCheck()
        Me.ucrPnlColumnSelectOptions = New instat.UcrPanel()
        Me.ucrNudWidthWrap = New instat.ucrNud()
        Me.ucrNudWidthTrunc = New instat.ucrNud()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrChkLastOr = New instat.ucrCheck()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrChkFirstOr = New instat.ucrCheck()
        Me.ucrPnlSide = New instat.UcrPanel()
        Me.ucrPnlSideTrunc = New instat.UcrPanel()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.grpParameters.SuspendLayout()
        Me.grpVar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnToTransform.Location = New System.Drawing.Point(397, 155)
        Me.lblColumnToTransform.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(0, 20)
        Me.lblColumnToTransform.TabIndex = 10
        '
        'lblToSubstring
        '
        Me.lblToSubstring.AutoSize = True
        Me.lblToSubstring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToSubstring.Location = New System.Drawing.Point(16, 81)
        Me.lblToSubstring.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToSubstring.Name = "lblToSubstring"
        Me.lblToSubstring.Size = New System.Drawing.Size(87, 20)
        Me.lblToSubstring.TabIndex = 10
        Me.lblToSubstring.Text = "End Value:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(15, 39)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(93, 20)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "Start Value:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeparator.Location = New System.Drawing.Point(32, 574)
        Me.lblSeparator.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(84, 20)
        Me.lblSeparator.TabIndex = 13
        Me.lblSeparator.Text = "Separator:"
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastWord.Location = New System.Drawing.Point(16, 134)
        Me.lblLastWord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(86, 20)
        Me.lblLastWord.TabIndex = 19
        Me.lblLastWord.Text = "Last Word:"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstWord.Location = New System.Drawing.Point(16, 39)
        Me.lblFirstWord.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(86, 20)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word:"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.lblSideTrunc)
        Me.grpParameters.Controls.Add(Me.lblSide)
        Me.grpParameters.Controls.Add(Me.ucrNudWidthWrap)
        Me.grpParameters.Controls.Add(Me.ucrNudWidthTrunc)
        Me.grpParameters.Controls.Add(Me.lblWidthWrap)
        Me.grpParameters.Controls.Add(Me.lblWidthTrunc)
        Me.grpParameters.Controls.Add(Me.lblLastWord)
        Me.grpParameters.Controls.Add(Me.rdoSquish)
        Me.grpParameters.Controls.Add(Me.ucrInputSeparator)
        Me.grpParameters.Controls.Add(Me.ucrChkLastOr)
        Me.grpParameters.Controls.Add(Me.ucrReceiverLastWord)
        Me.grpParameters.Controls.Add(Me.ucrNudLastWord)
        Me.grpParameters.Controls.Add(Me.ucrInputPad)
        Me.grpParameters.Controls.Add(Me.lblPad)
        Me.grpParameters.Controls.Add(Me.rdoBothPad)
        Me.grpParameters.Controls.Add(Me.ucrNudFrom)
        Me.grpParameters.Controls.Add(Me.rdoRightPad)
        Me.grpParameters.Controls.Add(Me.rdoLeftPad)
        Me.grpParameters.Controls.Add(Me.lblFrom)
        Me.grpParameters.Controls.Add(Me.lblFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrNudWidth)
        Me.grpParameters.Controls.Add(Me.ucrPnlPad)
        Me.grpParameters.Controls.Add(Me.ucrInputTo)
        Me.grpParameters.Controls.Add(Me.lblWidth)
        Me.grpParameters.Controls.Add(Me.lblTo)
        Me.grpParameters.Controls.Add(Me.ucrNudFirstWord)
        Me.grpParameters.Controls.Add(Me.rdoMiddle)
        Me.grpParameters.Controls.Add(Me.rdoRight)
        Me.grpParameters.Controls.Add(Me.rdoLeft)
        Me.grpParameters.Controls.Add(Me.rdoBothSide)
        Me.grpParameters.Controls.Add(Me.rdoRightSide)
        Me.grpParameters.Controls.Add(Me.rdoLeftSide)
        Me.grpParameters.Controls.Add(Me.ucrReceiverFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrNudTo)
        Me.grpParameters.Controls.Add(Me.ucrChkFirstOr)
        Me.grpParameters.Controls.Add(Me.lblToSubstring)
        Me.grpParameters.Controls.Add(Me.ucrPnlSide)
        Me.grpParameters.Controls.Add(Me.ucrPnlSideTrunc)
        Me.grpParameters.Location = New System.Drawing.Point(15, 352)
        Me.grpParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Padding = New System.Windows.Forms.Padding(4)
        Me.grpParameters.Size = New System.Drawing.Size(638, 256)
        Me.grpParameters.TabIndex = 12
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
        '
        'lblSideTrunc
        '
        Me.lblSideTrunc.AutoSize = True
        Me.lblSideTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSideTrunc.Location = New System.Drawing.Point(16, 86)
        Me.lblSideTrunc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSideTrunc.Name = "lblSideTrunc"
        Me.lblSideTrunc.Size = New System.Drawing.Size(45, 20)
        Me.lblSideTrunc.TabIndex = 12
        Me.lblSideTrunc.Text = "Side:"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSide.Location = New System.Drawing.Point(15, 86)
        Me.lblSide.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(45, 20)
        Me.lblSide.TabIndex = 53
        Me.lblSide.Text = "Side:"
        '
        'lblWidthWrap
        '
        Me.lblWidthWrap.AutoSize = True
        Me.lblWidthWrap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidthWrap.Location = New System.Drawing.Point(15, 36)
        Me.lblWidthWrap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidthWrap.Name = "lblWidthWrap"
        Me.lblWidthWrap.Size = New System.Drawing.Size(54, 20)
        Me.lblWidthWrap.TabIndex = 3
        Me.lblWidthWrap.Text = "Width:"
        '
        'lblWidthTrunc
        '
        Me.lblWidthTrunc.AutoSize = True
        Me.lblWidthTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidthTrunc.Location = New System.Drawing.Point(15, 36)
        Me.lblWidthTrunc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidthTrunc.Name = "lblWidthTrunc"
        Me.lblWidthTrunc.Size = New System.Drawing.Size(54, 20)
        Me.lblWidthTrunc.TabIndex = 3
        Me.lblWidthTrunc.Text = "Width:"
        '
        'rdoSquish
        '
        Me.rdoSquish.AutoSize = True
        Me.rdoSquish.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSquish.Location = New System.Drawing.Point(447, 36)
        Me.rdoSquish.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSquish.Name = "rdoSquish"
        Me.rdoSquish.Size = New System.Drawing.Size(83, 24)
        Me.rdoSquish.TabIndex = 9
        Me.rdoSquish.TabStop = True
        Me.rdoSquish.Text = "Squish"
        Me.rdoSquish.UseVisualStyleBackColor = True
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPad.Location = New System.Drawing.Point(16, 134)
        Me.lblPad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(41, 20)
        Me.lblPad.TabIndex = 14
        Me.lblPad.Text = "Pad:"
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBothPad.Location = New System.Drawing.Point(308, 36)
        Me.rdoBothPad.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.Size = New System.Drawing.Size(68, 24)
        Me.rdoBothPad.TabIndex = 8
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.Text = "Both"
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'rdoRightPad
        '
        Me.rdoRightPad.AutoSize = True
        Me.rdoRightPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRightPad.Location = New System.Drawing.Point(168, 36)
        Me.rdoRightPad.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(72, 24)
        Me.rdoRightPad.TabIndex = 7
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'rdoLeftPad
        '
        Me.rdoLeftPad.AutoSize = True
        Me.rdoLeftPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeftPad.Location = New System.Drawing.Point(28, 36)
        Me.rdoLeftPad.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.Size = New System.Drawing.Size(62, 24)
        Me.rdoLeftPad.TabIndex = 2
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.Text = "Left"
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidth.Location = New System.Drawing.Point(15, 36)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(54, 20)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(10, 39)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(86, 20)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "Convert to:"
        '
        'rdoMiddle
        '
        Me.rdoMiddle.AutoSize = True
        Me.rdoMiddle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMiddle.Location = New System.Drawing.Point(382, 82)
        Me.rdoMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoMiddle.Name = "rdoMiddle"
        Me.rdoMiddle.Size = New System.Drawing.Size(80, 24)
        Me.rdoMiddle.TabIndex = 18
        Me.rdoMiddle.TabStop = True
        Me.rdoMiddle.Text = "Middle"
        Me.rdoMiddle.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRight.Location = New System.Drawing.Point(243, 82)
        Me.rdoRight.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(72, 24)
        Me.rdoRight.TabIndex = 17
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeft.Location = New System.Drawing.Point(104, 82)
        Me.rdoLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(62, 24)
        Me.rdoLeft.TabIndex = 16
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoBothSide
        '
        Me.rdoBothSide.AutoSize = True
        Me.rdoBothSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBothSide.Location = New System.Drawing.Point(384, 82)
        Me.rdoBothSide.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoBothSide.Name = "rdoBothSide"
        Me.rdoBothSide.Size = New System.Drawing.Size(68, 24)
        Me.rdoBothSide.TabIndex = 51
        Me.rdoBothSide.TabStop = True
        Me.rdoBothSide.Text = "Both"
        Me.rdoBothSide.UseVisualStyleBackColor = True
        '
        'rdoRightSide
        '
        Me.rdoRightSide.AutoSize = True
        Me.rdoRightSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRightSide.Location = New System.Drawing.Point(244, 82)
        Me.rdoRightSide.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoRightSide.Name = "rdoRightSide"
        Me.rdoRightSide.Size = New System.Drawing.Size(72, 24)
        Me.rdoRightSide.TabIndex = 50
        Me.rdoRightSide.TabStop = True
        Me.rdoRightSide.Text = "Right"
        Me.rdoRightSide.UseVisualStyleBackColor = True
        '
        'rdoLeftSide
        '
        Me.rdoLeftSide.AutoSize = True
        Me.rdoLeftSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeftSide.Location = New System.Drawing.Point(105, 82)
        Me.rdoLeftSide.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLeftSide.Name = "rdoLeftSide"
        Me.rdoLeftSide.Size = New System.Drawing.Size(62, 24)
        Me.rdoLeftSide.TabIndex = 49
        Me.rdoLeftSide.TabStop = True
        Me.rdoLeftSide.Text = "Left"
        Me.rdoLeftSide.UseVisualStyleBackColor = True
        '
        'rdoCase
        '
        Me.rdoCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCase.FlatAppearance.BorderSize = 2
        Me.rdoCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCase.Location = New System.Drawing.Point(128, 12)
        Me.rdoCase.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoCase.Name = "rdoCase"
        Me.rdoCase.Size = New System.Drawing.Size(81, 51)
        Me.rdoCase.TabIndex = 1
        Me.rdoCase.TabStop = True
        Me.rdoCase.Text = "Case"
        Me.rdoCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoCase.UseVisualStyleBackColor = True
        '
        'rdoLength
        '
        Me.rdoLength.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.FlatAppearance.BorderSize = 2
        Me.rdoLength.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLength.Location = New System.Drawing.Point(206, 12)
        Me.rdoLength.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(96, 51)
        Me.rdoLength.TabIndex = 2
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'rdoPad
        '
        Me.rdoPad.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPad.FlatAppearance.BorderSize = 2
        Me.rdoPad.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPad.Location = New System.Drawing.Point(296, 12)
        Me.rdoPad.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.Size = New System.Drawing.Size(82, 51)
        Me.rdoPad.TabIndex = 3
        Me.rdoPad.TabStop = True
        Me.rdoPad.Text = "Pad"
        Me.rdoPad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPad.UseVisualStyleBackColor = True
        '
        'rdoSubstring
        '
        Me.rdoSubstring.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSubstring.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSubstring.FlatAppearance.BorderSize = 2
        Me.rdoSubstring.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSubstring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSubstring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSubstring.Location = New System.Drawing.Point(10, 12)
        Me.rdoSubstring.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.Size = New System.Drawing.Size(122, 51)
        Me.rdoSubstring.TabIndex = 8
        Me.rdoSubstring.TabStop = True
        Me.rdoSubstring.Text = "Substring"
        Me.rdoSubstring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSubstring.UseVisualStyleBackColor = True
        '
        'rdoWords
        '
        Me.rdoWords.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWords.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWords.FlatAppearance.BorderSize = 2
        Me.rdoWords.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWords.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWords.Location = New System.Drawing.Point(627, 12)
        Me.rdoWords.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.Size = New System.Drawing.Size(86, 51)
        Me.rdoWords.TabIndex = 7
        Me.rdoWords.TabStop = True
        Me.rdoWords.Text = "Words"
        Me.rdoWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWords.UseVisualStyleBackColor = True
        '
        'rdoTrim
        '
        Me.rdoTrim.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTrim.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrim.FlatAppearance.BorderSize = 2
        Me.rdoTrim.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTrim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTrim.Location = New System.Drawing.Point(465, 12)
        Me.rdoTrim.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.Size = New System.Drawing.Size(82, 51)
        Me.rdoTrim.TabIndex = 5
        Me.rdoTrim.TabStop = True
        Me.rdoTrim.Text = "Trim"
        Me.rdoTrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTrim.UseVisualStyleBackColor = True
        '
        'rdoWrap
        '
        Me.rdoWrap.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoWrap.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWrap.FlatAppearance.BorderSize = 2
        Me.rdoWrap.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoWrap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoWrap.Location = New System.Drawing.Point(542, 12)
        Me.rdoWrap.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoWrap.Name = "rdoWrap"
        Me.rdoWrap.Size = New System.Drawing.Size(88, 51)
        Me.rdoWrap.TabIndex = 6
        Me.rdoWrap.TabStop = True
        Me.rdoWrap.Text = "Wrap"
        Me.rdoWrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoWrap.UseVisualStyleBackColor = True
        '
        'rdoTruncate
        '
        Me.rdoTruncate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTruncate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTruncate.FlatAppearance.BorderSize = 2
        Me.rdoTruncate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTruncate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTruncate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTruncate.Location = New System.Drawing.Point(370, 12)
        Me.rdoTruncate.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoTruncate.Name = "rdoTruncate"
        Me.rdoTruncate.Size = New System.Drawing.Size(99, 51)
        Me.rdoTruncate.TabIndex = 4
        Me.rdoTruncate.TabStop = True
        Me.rdoTruncate.Text = "Truncate"
        Me.rdoTruncate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTruncate.UseVisualStyleBackColor = True
        '
        'grpVar
        '
        Me.grpVar.Controls.Add(Me.rdoMultiple)
        Me.grpVar.Controls.Add(Me.rdoSingle)
        Me.grpVar.Controls.Add(Me.ucrPnlColumnSelectOptions)
        Me.grpVar.Location = New System.Drawing.Point(397, 83)
        Me.grpVar.Margin = New System.Windows.Forms.Padding(4)
        Me.grpVar.Name = "grpVar"
        Me.grpVar.Padding = New System.Windows.Forms.Padding(4)
        Me.grpVar.Size = New System.Drawing.Size(309, 64)
        Me.grpVar.TabIndex = 74
        Me.grpVar.TabStop = False
        Me.grpVar.Text = "Variables"
        '
        'rdoMultiple
        '
        Me.rdoMultiple.AutoSize = True
        Me.rdoMultiple.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMultiple.Location = New System.Drawing.Point(145, 25)
        Me.rdoMultiple.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoMultiple.Name = "rdoMultiple"
        Me.rdoMultiple.Size = New System.Drawing.Size(88, 24)
        Me.rdoMultiple.TabIndex = 73
        Me.rdoMultiple.TabStop = True
        Me.rdoMultiple.Text = "Multiple"
        Me.rdoMultiple.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingle.Location = New System.Drawing.Point(15, 27)
        Me.rdoSingle.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(78, 24)
        Me.rdoSingle.TabIndex = 72
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'ucrChkOverWriteColumns
        '
        Me.ucrChkOverWriteColumns.AutoSize = True
        Me.ucrChkOverWriteColumns.Checked = False
        Me.ucrChkOverWriteColumns.Location = New System.Drawing.Point(15, 615)
        Me.ucrChkOverWriteColumns.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOverWriteColumns.Name = "ucrChkOverWriteColumns"
        Me.ucrChkOverWriteColumns.Size = New System.Drawing.Size(344, 34)
        Me.ucrChkOverWriteColumns.TabIndex = 75
        '
        'ucrPnlColumnSelectOptions
        '
        Me.ucrPnlColumnSelectOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlColumnSelectOptions.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlColumnSelectOptions.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrPnlColumnSelectOptions.Name = "ucrPnlColumnSelectOptions"
        Me.ucrPnlColumnSelectOptions.Size = New System.Drawing.Size(284, 42)
        Me.ucrPnlColumnSelectOptions.TabIndex = 71
        '
        'ucrNudWidthWrap
        '
        Me.ucrNudWidthWrap.AutoSize = True
        Me.ucrNudWidthWrap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidthWrap.Location = New System.Drawing.Point(105, 33)
        Me.ucrNudWidthWrap.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWidthWrap.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidthWrap.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Name = "ucrNudWidthWrap"
        Me.ucrNudWidthWrap.Size = New System.Drawing.Size(75, 32)
        Me.ucrNudWidthWrap.TabIndex = 6
        Me.ucrNudWidthWrap.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidthTrunc
        '
        Me.ucrNudWidthTrunc.AutoSize = True
        Me.ucrNudWidthTrunc.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthTrunc.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidthTrunc.Location = New System.Drawing.Point(105, 33)
        Me.ucrNudWidthTrunc.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWidthTrunc.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidthTrunc.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthTrunc.Name = "ucrNudWidthTrunc"
        Me.ucrNudWidthTrunc.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudWidthTrunc.TabIndex = 5
        Me.ucrNudWidthTrunc.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSeparator.GetSetSelectedIndex = -1
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(110, 208)
        Me.ucrInputSeparator.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(204, 34)
        Me.ucrInputSeparator.TabIndex = 25
        '
        'ucrChkLastOr
        '
        Me.ucrChkLastOr.AutoSize = True
        Me.ucrChkLastOr.Checked = False
        Me.ucrChkLastOr.Location = New System.Drawing.Point(28, 165)
        Me.ucrChkLastOr.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLastOr.Name = "ucrChkLastOr"
        Me.ucrChkLastOr.Size = New System.Drawing.Size(112, 51)
        Me.ucrChkLastOr.TabIndex = 23
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.AutoSize = True
        Me.ucrReceiverLastWord.frmParent = Nothing
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(159, 165)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(204, 39)
        Me.ucrReceiverLastWord.strNcFilePath = ""
        Me.ucrReceiverLastWord.TabIndex = 24
        Me.ucrReceiverLastWord.ucrSelector = Nothing
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.AutoSize = True
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLastWord.Location = New System.Drawing.Point(147, 126)
        Me.ucrNudLastWord.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudLastWord.TabIndex = 21
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPad
        '
        Me.ucrInputPad.AddQuotesIfUnrecognised = True
        Me.ucrInputPad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPad.GetSetSelectedIndex = -1
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(104, 134)
        Me.ucrInputPad.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(204, 34)
        Me.ucrInputPad.TabIndex = 22
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.AutoSize = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(146, 34)
        Me.ucrNudFrom.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudFrom.TabIndex = 5
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(105, 33)
        Me.ucrNudWidth.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudWidth.TabIndex = 47
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPad
        '
        Me.ucrPnlPad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPad.Location = New System.Drawing.Point(9, 21)
        Me.ucrPnlPad.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlPad.Name = "ucrPnlPad"
        Me.ucrPnlPad.Size = New System.Drawing.Size(537, 45)
        Me.ucrPnlPad.TabIndex = 0
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTo.GetSetSelectedIndex = -1
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(112, 33)
        Me.ucrInputTo.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(204, 38)
        Me.ucrInputTo.TabIndex = 8
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.AutoSize = True
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFirstWord.Location = New System.Drawing.Point(146, 34)
        Me.ucrNudFirstWord.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudFirstWord.TabIndex = 44
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.AutoSize = True
        Me.ucrReceiverFirstWord.frmParent = Nothing
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(159, 75)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(204, 39)
        Me.ucrReceiverFirstWord.strNcFilePath = ""
        Me.ucrReceiverFirstWord.TabIndex = 15
        Me.ucrReceiverFirstWord.ucrSelector = Nothing
        '
        'ucrNudTo
        '
        Me.ucrNudTo.AutoSize = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(146, 75)
        Me.ucrNudTo.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudTo.TabIndex = 14
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFirstOr
        '
        Me.ucrChkFirstOr.AutoSize = True
        Me.ucrChkFirstOr.Checked = False
        Me.ucrChkFirstOr.Location = New System.Drawing.Point(28, 75)
        Me.ucrChkFirstOr.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkFirstOr.Name = "ucrChkFirstOr"
        Me.ucrChkFirstOr.Size = New System.Drawing.Size(112, 51)
        Me.ucrChkFirstOr.TabIndex = 11
        '
        'ucrPnlSide
        '
        Me.ucrPnlSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSide.Location = New System.Drawing.Point(99, 72)
        Me.ucrPnlSide.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlSide.Name = "ucrPnlSide"
        Me.ucrPnlSide.Size = New System.Drawing.Size(376, 45)
        Me.ucrPnlSide.TabIndex = 13
        '
        'ucrPnlSideTrunc
        '
        Me.ucrPnlSideTrunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSideTrunc.Location = New System.Drawing.Point(99, 70)
        Me.ucrPnlSideTrunc.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlSideTrunc.Name = "ucrPnlSideTrunc"
        Me.ucrPnlSideTrunc.Size = New System.Drawing.Size(376, 46)
        Me.ucrPnlSideTrunc.TabIndex = 21
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(15, 663)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(496, 33)
        Me.ucrNewColName.TabIndex = 14
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.AutoSize = True
        Me.ucrReceiverTransformText.frmParent = Me
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(397, 177)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(202, 39)
        Me.ucrReceiverTransformText.strNcFilePath = ""
        Me.ucrReceiverTransformText.TabIndex = 11
        Me.ucrReceiverTransformText.ucrSelector = Nothing
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.AutoSize = True
        Me.ucrSelectorForTransformText.bDropUnusedFilterLevels = False
        Me.ucrSelectorForTransformText.bShowHiddenColumns = False
        Me.ucrSelectorForTransformText.bUseCurrentFilter = True
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(15, 75)
        Me.ucrSelectorForTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(363, 278)
        Me.ucrSelectorForTransformText.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 706)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 15
        '
        'ucrPnlOperation
        '
        Me.ucrPnlOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOperation.Location = New System.Drawing.Point(4, 6)
        Me.ucrPnlOperation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        Me.ucrPnlOperation.Size = New System.Drawing.Size(784, 64)
        Me.ucrPnlOperation.TabIndex = 0
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(728, 791)
        Me.Controls.Add(Me.ucrChkOverWriteColumns)
        Me.Controls.Add(Me.grpVar)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.rdoTruncate)
        Me.Controls.Add(Me.rdoWrap)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.rdoTrim)
        Me.Controls.Add(Me.rdoWords)
        Me.Controls.Add(Me.rdoSubstring)
        Me.Controls.Add(Me.rdoPad)
        Me.Controls.Add(Me.rdoLength)
        Me.Controls.Add(Me.rdoCase)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.lblColumnToTransform)
        Me.Controls.Add(Me.ucrReceiverTransformText)
        Me.Controls.Add(Me.ucrSelectorForTransformText)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOperation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform Text Column"
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        Me.grpVar.ResumeLayout(False)
        Me.grpVar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForTransformText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTransformText As ucrReceiverSingle
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents ucrReceiverFirstWord As ucrReceiverSingle
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents lblToSubstring As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents lblPad As Label
    Friend WithEvents ucrInputPad As ucrInputComboBox
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrReceiverLastWord As ucrReceiverSingle
    Friend WithEvents rdoBothPad As RadioButton
    Friend WithEvents rdoRightPad As RadioButton
    Friend WithEvents rdoLeftPad As RadioButton
    Friend WithEvents ucrChkFirstOr As ucrCheck
    Friend WithEvents ucrChkLastOr As ucrCheck
    Friend WithEvents ucrNudLastWord As ucrNud
    Friend WithEvents ucrNudFirstWord As ucrNud
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrPnlPad As UcrPanel
    Friend WithEvents ucrNewColName As ucrSave
    Friend WithEvents ucrPnlOperation As UcrPanel
    Friend WithEvents rdoCase As RadioButton
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents rdoSubstring As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents rdoSquish As RadioButton
    Friend WithEvents rdoBothSide As RadioButton
    Friend WithEvents rdoRightSide As RadioButton
    Friend WithEvents rdoLeftSide As RadioButton
    Friend WithEvents ucrPnlSide As UcrPanel
    Friend WithEvents rdoTruncate As RadioButton
    Friend WithEvents rdoWrap As RadioButton
    Friend WithEvents ucrNudWidthTrunc As ucrNud
    Friend WithEvents lblWidthTrunc As Label
    Friend WithEvents ucrNudWidthWrap As ucrNud
    Friend WithEvents lblWidthWrap As Label
    Friend WithEvents lblSide As Label
    Friend WithEvents rdoRight As RadioButton
    Friend WithEvents rdoLeft As RadioButton
    Friend WithEvents rdoMiddle As RadioButton
    Friend WithEvents lblSideTrunc As Label
    Friend WithEvents ucrPnlSideTrunc As UcrPanel
    Friend WithEvents grpVar As GroupBox
    Friend WithEvents rdoMultiple As RadioButton
    Friend WithEvents rdoSingle As RadioButton
    Friend WithEvents ucrPnlColumnSelectOptions As UcrPanel
    Friend WithEvents ucrChkOverWriteColumns As ucrCheck
End Class