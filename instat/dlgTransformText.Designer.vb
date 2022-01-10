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
        Me.ucrNudWidthWrap = New instat.ucrNud()
        Me.ucrNudWidthTrunc = New instat.ucrNud()
        Me.lblWidthWrap = New System.Windows.Forms.Label()
        Me.lblWidthTrunc = New System.Windows.Forms.Label()
        Me.rdoSquish = New System.Windows.Forms.RadioButton()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrChkLastOr = New instat.ucrCheck()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.rdoMiddle = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoBothSide = New System.Windows.Forms.RadioButton()
        Me.rdoRightSide = New System.Windows.Forms.RadioButton()
        Me.rdoLeftSide = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrChkFirstOr = New instat.ucrCheck()
        Me.ucrPnlSide = New instat.UcrPanel()
        Me.ucrPnlSideTrunc = New instat.UcrPanel()
        Me.rdoCase = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoWrap = New System.Windows.Forms.RadioButton()
        Me.rdoTruncate = New System.Windows.Forms.RadioButton()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumnToTransform.Location = New System.Drawing.Point(267, 85)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(107, 13)
        Me.lblColumnToTransform.TabIndex = 10
        Me.lblColumnToTransform.Text = "Column to Transform:"
        '
        'lblToSubstring
        '
        Me.lblToSubstring.AutoSize = True
        Me.lblToSubstring.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblToSubstring.Location = New System.Drawing.Point(11, 54)
        Me.lblToSubstring.Name = "lblToSubstring"
        Me.lblToSubstring.Size = New System.Drawing.Size(59, 13)
        Me.lblToSubstring.TabIndex = 10
        Me.lblToSubstring.Text = "End Value:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(10, 26)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(62, 13)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "Start Value:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeparator.Location = New System.Drawing.Point(21, 383)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 13
        Me.lblSeparator.Text = "Separator:"
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLastWord.Location = New System.Drawing.Point(11, 89)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(59, 13)
        Me.lblLastWord.TabIndex = 19
        Me.lblLastWord.Text = "Last Word:"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFirstWord.Location = New System.Drawing.Point(11, 26)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(58, 13)
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
        Me.grpParameters.Location = New System.Drawing.Point(10, 238)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(397, 173)
        Me.grpParameters.TabIndex = 12
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
        '
        'lblSideTrunc
        '
        Me.lblSideTrunc.AutoSize = True
        Me.lblSideTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSideTrunc.Location = New System.Drawing.Point(11, 57)
        Me.lblSideTrunc.Name = "lblSideTrunc"
        Me.lblSideTrunc.Size = New System.Drawing.Size(31, 13)
        Me.lblSideTrunc.TabIndex = 12
        Me.lblSideTrunc.Text = "Side:"
        '
        'lblSide
        '
        Me.lblSide.AutoSize = True
        Me.lblSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSide.Location = New System.Drawing.Point(10, 57)
        Me.lblSide.Name = "lblSide"
        Me.lblSide.Size = New System.Drawing.Size(31, 13)
        Me.lblSide.TabIndex = 53
        Me.lblSide.Text = "Side:"
        '
        'ucrNudWidthWrap
        '
        Me.ucrNudWidthWrap.AutoSize = True
        Me.ucrNudWidthWrap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidthWrap.Location = New System.Drawing.Point(70, 22)
        Me.ucrNudWidthWrap.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidthWrap.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthWrap.Name = "ucrNudWidthWrap"
        Me.ucrNudWidthWrap.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudWidthWrap.TabIndex = 6
        Me.ucrNudWidthWrap.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudWidthTrunc
        '
        Me.ucrNudWidthTrunc.AutoSize = True
        Me.ucrNudWidthTrunc.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthTrunc.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidthTrunc.Location = New System.Drawing.Point(70, 22)
        Me.ucrNudWidthTrunc.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidthTrunc.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidthTrunc.Name = "ucrNudWidthTrunc"
        Me.ucrNudWidthTrunc.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidthTrunc.TabIndex = 5
        Me.ucrNudWidthTrunc.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWidthWrap
        '
        Me.lblWidthWrap.AutoSize = True
        Me.lblWidthWrap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidthWrap.Location = New System.Drawing.Point(10, 24)
        Me.lblWidthWrap.Name = "lblWidthWrap"
        Me.lblWidthWrap.Size = New System.Drawing.Size(38, 13)
        Me.lblWidthWrap.TabIndex = 3
        Me.lblWidthWrap.Text = "Width:"
        '
        'lblWidthTrunc
        '
        Me.lblWidthTrunc.AutoSize = True
        Me.lblWidthTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidthTrunc.Location = New System.Drawing.Point(10, 24)
        Me.lblWidthTrunc.Name = "lblWidthTrunc"
        Me.lblWidthTrunc.Size = New System.Drawing.Size(38, 13)
        Me.lblWidthTrunc.TabIndex = 3
        Me.lblWidthTrunc.Text = "Width:"
        '
        'rdoSquish
        '
        Me.rdoSquish.AutoSize = True
        Me.rdoSquish.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSquish.Location = New System.Drawing.Point(298, 24)
        Me.rdoSquish.Name = "rdoSquish"
        Me.rdoSquish.Size = New System.Drawing.Size(57, 17)
        Me.rdoSquish.TabIndex = 9
        Me.rdoSquish.TabStop = True
        Me.rdoSquish.Text = "Squish"
        Me.rdoSquish.UseVisualStyleBackColor = True
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSeparator.GetSetSelectedIndex = -1
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(73, 139)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(136, 23)
        Me.ucrInputSeparator.TabIndex = 25
        '
        'ucrChkLastOr
        '
        Me.ucrChkLastOr.AutoSize = True
        Me.ucrChkLastOr.Checked = False
        Me.ucrChkLastOr.Location = New System.Drawing.Point(19, 110)
        Me.ucrChkLastOr.Name = "ucrChkLastOr"
        Me.ucrChkLastOr.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkLastOr.TabIndex = 23
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.AutoSize = True
        Me.ucrReceiverLastWord.frmParent = Me
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(106, 110)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(136, 26)
        Me.ucrReceiverLastWord.strNcFilePath = ""
        Me.ucrReceiverLastWord.TabIndex = 24
        Me.ucrReceiverLastWord.ucrSelector = Nothing
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.AutoSize = True
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLastWord.Location = New System.Drawing.Point(98, 84)
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLastWord.TabIndex = 21
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPad
        '
        Me.ucrInputPad.AddQuotesIfUnrecognised = True
        Me.ucrInputPad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPad.GetSetSelectedIndex = -1
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(69, 89)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(136, 23)
        Me.ucrInputPad.TabIndex = 22
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPad.Location = New System.Drawing.Point(11, 89)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(29, 13)
        Me.lblPad.TabIndex = 14
        Me.lblPad.Text = "Pad:"
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBothPad.Location = New System.Drawing.Point(205, 24)
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothPad.TabIndex = 8
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.Text = "Both"
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.AutoSize = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(97, 23)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 5
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRightPad
        '
        Me.rdoRightPad.AutoSize = True
        Me.rdoRightPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRightPad.Location = New System.Drawing.Point(112, 24)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightPad.TabIndex = 7
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'rdoLeftPad
        '
        Me.rdoLeftPad.AutoSize = True
        Me.rdoLeftPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeftPad.Location = New System.Drawing.Point(19, 24)
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftPad.TabIndex = 2
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.Text = "Left"
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.AutoSize = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(70, 22)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 47
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPad
        '
        Me.ucrPnlPad.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPad.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlPad.Name = "ucrPnlPad"
        Me.ucrPnlPad.Size = New System.Drawing.Size(358, 30)
        Me.ucrPnlPad.TabIndex = 0
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTo.GetSetSelectedIndex = -1
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(75, 22)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(136, 25)
        Me.ucrInputTo.TabIndex = 8
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidth.Location = New System.Drawing.Point(10, 24)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(7, 26)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(59, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "Convert to:"
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.AutoSize = True
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFirstWord.Location = New System.Drawing.Point(97, 23)
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFirstWord.TabIndex = 44
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoMiddle
        '
        Me.rdoMiddle.AutoSize = True
        Me.rdoMiddle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMiddle.Location = New System.Drawing.Point(255, 55)
        Me.rdoMiddle.Name = "rdoMiddle"
        Me.rdoMiddle.Size = New System.Drawing.Size(56, 17)
        Me.rdoMiddle.TabIndex = 18
        Me.rdoMiddle.TabStop = True
        Me.rdoMiddle.Text = "Middle"
        Me.rdoMiddle.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRight.Location = New System.Drawing.Point(162, 55)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(50, 17)
        Me.rdoRight.TabIndex = 17
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Right"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeft.Location = New System.Drawing.Point(69, 55)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeft.TabIndex = 16
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Left"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoBothSide
        '
        Me.rdoBothSide.AutoSize = True
        Me.rdoBothSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBothSide.Location = New System.Drawing.Point(256, 55)
        Me.rdoBothSide.Name = "rdoBothSide"
        Me.rdoBothSide.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothSide.TabIndex = 51
        Me.rdoBothSide.TabStop = True
        Me.rdoBothSide.Text = "Both"
        Me.rdoBothSide.UseVisualStyleBackColor = True
        '
        'rdoRightSide
        '
        Me.rdoRightSide.AutoSize = True
        Me.rdoRightSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRightSide.Location = New System.Drawing.Point(163, 55)
        Me.rdoRightSide.Name = "rdoRightSide"
        Me.rdoRightSide.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightSide.TabIndex = 50
        Me.rdoRightSide.TabStop = True
        Me.rdoRightSide.Text = "Right"
        Me.rdoRightSide.UseVisualStyleBackColor = True
        '
        'rdoLeftSide
        '
        Me.rdoLeftSide.AutoSize = True
        Me.rdoLeftSide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoLeftSide.Location = New System.Drawing.Point(70, 55)
        Me.rdoLeftSide.Name = "rdoLeftSide"
        Me.rdoLeftSide.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftSide.TabIndex = 49
        Me.rdoLeftSide.TabStop = True
        Me.rdoLeftSide.Text = "Left"
        Me.rdoLeftSide.UseVisualStyleBackColor = True
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.AutoSize = True
        Me.ucrReceiverFirstWord.frmParent = Me
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(106, 50)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(136, 26)
        Me.ucrReceiverFirstWord.strNcFilePath = ""
        Me.ucrReceiverFirstWord.TabIndex = 15
        Me.ucrReceiverFirstWord.ucrSelector = Nothing
        '
        'ucrNudTo
        '
        Me.ucrNudTo.AutoSize = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(97, 50)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 14
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFirstOr
        '
        Me.ucrChkFirstOr.AutoSize = True
        Me.ucrChkFirstOr.Checked = False
        Me.ucrChkFirstOr.Location = New System.Drawing.Point(19, 50)
        Me.ucrChkFirstOr.Name = "ucrChkFirstOr"
        Me.ucrChkFirstOr.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkFirstOr.TabIndex = 11
        '
        'ucrPnlSide
        '
        Me.ucrPnlSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSide.Location = New System.Drawing.Point(66, 48)
        Me.ucrPnlSide.Name = "ucrPnlSide"
        Me.ucrPnlSide.Size = New System.Drawing.Size(251, 30)
        Me.ucrPnlSide.TabIndex = 13
        '
        'ucrPnlSideTrunc
        '
        Me.ucrPnlSideTrunc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSideTrunc.Location = New System.Drawing.Point(66, 47)
        Me.ucrPnlSideTrunc.Name = "ucrPnlSideTrunc"
        Me.ucrPnlSideTrunc.Size = New System.Drawing.Size(251, 31)
        Me.ucrPnlSideTrunc.TabIndex = 21
        '
        'rdoCase
        '
        Me.rdoCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCase.FlatAppearance.BorderSize = 2
        Me.rdoCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoCase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoCase.Location = New System.Drawing.Point(11, 8)
        Me.rdoCase.Name = "rdoCase"
        Me.rdoCase.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoLength.Location = New System.Drawing.Point(74, 8)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoPad.Location = New System.Drawing.Point(137, 8)
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoSubstring.Location = New System.Drawing.Point(452, 8)
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoWords.Location = New System.Drawing.Point(389, 8)
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoTrim.Location = New System.Drawing.Point(263, 8)
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoWrap.Location = New System.Drawing.Point(326, 8)
        Me.rdoWrap.Name = "rdoWrap"
        Me.rdoWrap.Size = New System.Drawing.Size(65, 34)
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
        Me.rdoTruncate.Location = New System.Drawing.Point(200, 8)
        Me.rdoTruncate.Name = "rdoTruncate"
        Me.rdoTruncate.Size = New System.Drawing.Size(65, 34)
        Me.rdoTruncate.TabIndex = 4
        Me.rdoTruncate.TabStop = True
        Me.rdoTruncate.Text = "Truncate"
        Me.rdoTruncate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTruncate.UseVisualStyleBackColor = True
        '
        'ucrNewColName
        '
        Me.ucrNewColName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 417)
        Me.ucrNewColName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(331, 22)
        Me.ucrNewColName.TabIndex = 14
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.AutoSize = True
        Me.ucrReceiverTransformText.frmParent = Me
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(267, 100)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(135, 26)
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
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectorForTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(242, 185)
        Me.ucrSelectorForTransformText.TabIndex = 9
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 442)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrPnlOperation
        '
        Me.ucrPnlOperation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOperation.Location = New System.Drawing.Point(3, 4)
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        Me.ucrPnlOperation.Size = New System.Drawing.Size(523, 43)
        Me.ucrPnlOperation.TabIndex = 0
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(530, 498)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform Text Column"
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
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
End Class