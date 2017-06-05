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
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrChkLastOr = New instat.ucrCheck()
        Me.ucrChkFirstOr = New instat.ucrCheck()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.Location = New System.Drawing.Point(250, 85)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(107, 13)
        Me.lblColumnToTransform.TabIndex = 8
        Me.lblColumnToTransform.Text = "Column to Transform:"
        '
        'ucrPnlOperation
        '
        Me.ucrPnlOperation.Location = New System.Drawing.Point(16, 4)
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        Me.ucrPnlOperation.Size = New System.Drawing.Size(393, 43)
        Me.ucrPnlOperation.TabIndex = 0
        '
        'lblToSubstring
        '
        Me.lblToSubstring.AutoSize = True
        Me.lblToSubstring.Location = New System.Drawing.Point(11, 54)
        Me.lblToSubstring.Name = "lblToSubstring"
        Me.lblToSubstring.Size = New System.Drawing.Size(59, 13)
        Me.lblToSubstring.TabIndex = 24
        Me.lblToSubstring.Text = "End Value:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(10, 26)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(62, 13)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "Start Value:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(21, 383)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 18
        Me.lblSeparator.Text = "Separator:"
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.Location = New System.Drawing.Point(11, 89)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(59, 13)
        Me.lblLastWord.TabIndex = 15
        Me.lblLastWord.Text = "Last Word:"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(11, 26)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word:"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.ucrInputSeparator)
        Me.grpParameters.Controls.Add(Me.ucrChkLastOr)
        Me.grpParameters.Controls.Add(Me.ucrChkFirstOr)
        Me.grpParameters.Controls.Add(Me.ucrReceiverLastWord)
        Me.grpParameters.Controls.Add(Me.ucrNudLastWord)
        Me.grpParameters.Controls.Add(Me.ucrInputPad)
        Me.grpParameters.Controls.Add(Me.lblToSubstring)
        Me.grpParameters.Controls.Add(Me.lblLastWord)
        Me.grpParameters.Controls.Add(Me.lblPad)
        Me.grpParameters.Controls.Add(Me.ucrNudTo)
        Me.grpParameters.Controls.Add(Me.ucrReceiverFirstWord)
        Me.grpParameters.Controls.Add(Me.rdoBothPad)
        Me.grpParameters.Controls.Add(Me.ucrNudFirstWord)
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
        Me.grpParameters.Location = New System.Drawing.Point(10, 238)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(397, 173)
        Me.grpParameters.TabIndex = 10
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(78, 139)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(136, 23)
        Me.ucrInputSeparator.TabIndex = 17
        '
        'ucrChkLastOr
        '
        Me.ucrChkLastOr.Checked = False
        Me.ucrChkLastOr.Location = New System.Drawing.Point(19, 110)
        Me.ucrChkLastOr.Name = "ucrChkLastOr"
        Me.ucrChkLastOr.Size = New System.Drawing.Size(75, 20)
        Me.ucrChkLastOr.TabIndex = 43
        '
        'ucrChkFirstOr
        '
        Me.ucrChkFirstOr.Checked = False
        Me.ucrChkFirstOr.Location = New System.Drawing.Point(19, 50)
        Me.ucrChkFirstOr.Name = "ucrChkFirstOr"
        Me.ucrChkFirstOr.Size = New System.Drawing.Size(75, 20)
        Me.ucrChkFirstOr.TabIndex = 42
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.frmParent = Me
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(106, 110)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(136, 26)
        Me.ucrReceiverLastWord.strNcFilePath = ""
        Me.ucrReceiverLastWord.TabIndex = 27
        Me.ucrReceiverLastWord.ucrSelector = Nothing
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLastWord.Location = New System.Drawing.Point(78, 84)
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLastWord.TabIndex = 45
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.Location = New System.Drawing.Point(11, 89)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(29, 13)
        Me.lblPad.TabIndex = 14
        Me.lblPad.Text = "Pad:"
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(78, 50)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 46
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.frmParent = Me
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(106, 50)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(136, 26)
        Me.ucrReceiverFirstWord.strNcFilePath = ""
        Me.ucrReceiverFirstWord.TabIndex = 13
        Me.ucrReceiverFirstWord.ucrSelector = Nothing
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.Location = New System.Drawing.Point(212, 24)
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothPad.TabIndex = 40
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.Text = "Both"
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFirstWord.Location = New System.Drawing.Point(78, 23)
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFirstWord.TabIndex = 44
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(78, 23)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 45
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRightPad
        '
        Me.rdoRightPad.AutoSize = True
        Me.rdoRightPad.Location = New System.Drawing.Point(112, 24)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightPad.TabIndex = 39
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'rdoLeftPad
        '
        Me.rdoLeftPad.AutoSize = True
        Me.rdoLeftPad.Location = New System.Drawing.Point(19, 24)
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftPad.TabIndex = 38
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.Text = "Left"
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(78, 50)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 47
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPad
        '
        Me.ucrPnlPad.Location = New System.Drawing.Point(6, 14)
        Me.ucrPnlPad.Name = "ucrPnlPad"
        Me.ucrPnlPad.Size = New System.Drawing.Size(298, 30)
        Me.ucrPnlPad.TabIndex = 9
        '
        'ucrInputTo
        '
        Me.ucrInputTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(75, 22)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(136, 25)
        Me.ucrInputTo.TabIndex = 8
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(10, 54)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(7, 26)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(59, 13)
        Me.lblTo.TabIndex = 7
        Me.lblTo.Text = "Convert to:"
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.frmParent = Me
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(253, 100)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(135, 26)
        Me.ucrReceiverTransformText.strNcFilePath = ""
        Me.ucrReceiverTransformText.TabIndex = 9
        Me.ucrReceiverTransformText.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 442)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 12
        '
        'ucrNewColName
        '
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 417)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(272, 24)
        Me.ucrNewColName.TabIndex = 11
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.bShowHiddenColumns = False
        Me.ucrSelectorForTransformText.bUseCurrentFilter = True
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectorForTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(242, 185)
        Me.ucrSelectorForTransformText.TabIndex = 7
        '
        'rdoConvertCase
        '
        Me.rdoConvertCase.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoConvertCase.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConvertCase.FlatAppearance.BorderSize = 2
        Me.rdoConvertCase.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoConvertCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoConvertCase.Location = New System.Drawing.Point(20, 12)
        Me.rdoConvertCase.Name = "rdoConvertCase"
        Me.rdoConvertCase.Size = New System.Drawing.Size(83, 27)
        Me.rdoConvertCase.TabIndex = 1
        Me.rdoConvertCase.TabStop = True
        Me.rdoConvertCase.Text = "Convert Case"
        Me.rdoConvertCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoConvertCase.UseVisualStyleBackColor = True
        '
        'rdoLength
        '
        Me.rdoLength.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoLength.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.FlatAppearance.BorderSize = 2
        Me.rdoLength.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoLength.Location = New System.Drawing.Point(101, 12)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(61, 27)
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
        Me.rdoPad.Location = New System.Drawing.Point(160, 12)
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.Size = New System.Drawing.Size(61, 27)
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
        Me.rdoSubstring.Location = New System.Drawing.Point(337, 12)
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.Size = New System.Drawing.Size(63, 27)
        Me.rdoSubstring.TabIndex = 6
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
        Me.rdoWords.Location = New System.Drawing.Point(278, 12)
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.Size = New System.Drawing.Size(61, 27)
        Me.rdoWords.TabIndex = 5
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
        Me.rdoTrim.Location = New System.Drawing.Point(219, 12)
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.Size = New System.Drawing.Size(61, 27)
        Me.rdoTrim.TabIndex = 4
        Me.rdoTrim.TabStop = True
        Me.rdoTrim.Text = "Trim"
        Me.rdoTrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTrim.UseVisualStyleBackColor = True
        '
        'ucrInputPad
        '
        Me.ucrInputPad.AddQuotesIfUnrecognised = True
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(78, 84)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(136, 25)
        Me.ucrInputPad.TabIndex = 13
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 498)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.rdoTrim)
        Me.Controls.Add(Me.rdoWords)
        Me.Controls.Add(Me.rdoSubstring)
        Me.Controls.Add(Me.rdoPad)
        Me.Controls.Add(Me.rdoLength)
        Me.Controls.Add(Me.rdoConvertCase)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.grpParameters)
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
    Friend WithEvents rdoConvertCase As RadioButton
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents rdoSubstring As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents ucrInputPad As ucrInputComboBox
End Class
