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
        Me.grpOperation = New System.Windows.Forms.GroupBox()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.pnlWords = New System.Windows.Forms.Panel()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.ucrChkFirstOr = New instat.ucrCheck()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrChkLastOr = New instat.ucrCheck()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrNewColName = New instat.ucrSave()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpOperation.SuspendLayout()
        Me.grpParameters.SuspendLayout()
        Me.pnlWords.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.Location = New System.Drawing.Point(250, 43)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(107, 13)
        Me.lblColumnToTransform.TabIndex = 1
        Me.lblColumnToTransform.Text = "Column to Transform:"
        '
        'grpOperation
        '
        Me.grpOperation.Controls.Add(Me.rdoSubstring)
        Me.grpOperation.Controls.Add(Me.rdoWords)
        Me.grpOperation.Controls.Add(Me.rdoTrim)
        Me.grpOperation.Controls.Add(Me.rdoConvertCase)
        Me.grpOperation.Controls.Add(Me.rdoPad)
        Me.grpOperation.Controls.Add(Me.rdoLength)
        Me.grpOperation.Controls.Add(Me.ucrPnlOperation)
        Me.grpOperation.Location = New System.Drawing.Point(11, 205)
        Me.grpOperation.Name = "grpOperation"
        Me.grpOperation.Size = New System.Drawing.Size(108, 181)
        Me.grpOperation.TabIndex = 3
        Me.grpOperation.TabStop = False
        Me.grpOperation.Text = "Operation"
        '
        'rdoSubstring
        '
        Me.rdoSubstring.AutoSize = True
        Me.rdoSubstring.Location = New System.Drawing.Point(8, 138)
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.Size = New System.Drawing.Size(69, 17)
        Me.rdoSubstring.TabIndex = 6
        Me.rdoSubstring.TabStop = True
        Me.rdoSubstring.Text = "Substring"
        Me.rdoSubstring.UseVisualStyleBackColor = True
        '
        'rdoWords
        '
        Me.rdoWords.AutoSize = True
        Me.rdoWords.Location = New System.Drawing.Point(8, 115)
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.Size = New System.Drawing.Size(56, 17)
        Me.rdoWords.TabIndex = 5
        Me.rdoWords.TabStop = True
        Me.rdoWords.Text = "Words"
        Me.rdoWords.UseVisualStyleBackColor = True
        '
        'rdoTrim
        '
        Me.rdoTrim.AutoSize = True
        Me.rdoTrim.Location = New System.Drawing.Point(8, 92)
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.Size = New System.Drawing.Size(45, 17)
        Me.rdoTrim.TabIndex = 4
        Me.rdoTrim.TabStop = True
        Me.rdoTrim.Text = "Trim"
        Me.rdoTrim.UseVisualStyleBackColor = True
        '
        'rdoConvertCase
        '
        Me.rdoConvertCase.AutoSize = True
        Me.rdoConvertCase.Location = New System.Drawing.Point(8, 23)
        Me.rdoConvertCase.Name = "rdoConvertCase"
        Me.rdoConvertCase.Size = New System.Drawing.Size(89, 17)
        Me.rdoConvertCase.TabIndex = 1
        Me.rdoConvertCase.TabStop = True
        Me.rdoConvertCase.Text = "Convert Case"
        Me.rdoConvertCase.UseVisualStyleBackColor = True
        '
        'rdoPad
        '
        Me.rdoPad.AutoSize = True
        Me.rdoPad.Location = New System.Drawing.Point(8, 69)
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.Size = New System.Drawing.Size(44, 17)
        Me.rdoPad.TabIndex = 3
        Me.rdoPad.TabStop = True
        Me.rdoPad.Text = "Pad"
        Me.rdoPad.UseVisualStyleBackColor = True
        '
        'rdoLength
        '
        Me.rdoLength.AutoSize = True
        Me.rdoLength.Location = New System.Drawing.Point(8, 46)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(58, 17)
        Me.rdoLength.TabIndex = 2
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'ucrPnlOperation
        '
        Me.ucrPnlOperation.Location = New System.Drawing.Point(4, 15)
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        Me.ucrPnlOperation.Size = New System.Drawing.Size(98, 156)
        Me.ucrPnlOperation.TabIndex = 0
        '
        'lblToSubstring
        '
        Me.lblToSubstring.AutoSize = True
        Me.lblToSubstring.Location = New System.Drawing.Point(10, 41)
        Me.lblToSubstring.Name = "lblToSubstring"
        Me.lblToSubstring.Size = New System.Drawing.Size(59, 13)
        Me.lblToSubstring.TabIndex = 24
        Me.lblToSubstring.Text = "End Value:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(10, 15)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(62, 13)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "Start Value:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(10, 130)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 18
        Me.lblSeparator.Text = "Separator:"
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.Location = New System.Drawing.Point(10, 70)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(59, 13)
        Me.lblLastWord.TabIndex = 15
        Me.lblLastWord.Text = "Last Word:"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(10, 15)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word:"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.pnlWords)
        Me.grpParameters.Location = New System.Drawing.Point(127, 205)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(267, 181)
        Me.grpParameters.TabIndex = 4
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
        '
        'pnlWords
        '
        Me.pnlWords.Controls.Add(Me.rdoBothPad)
        Me.pnlWords.Controls.Add(Me.ucrInputTo)
        Me.pnlWords.Controls.Add(Me.rdoLeftPad)
        Me.pnlWords.Controls.Add(Me.lblTo)
        Me.pnlWords.Controls.Add(Me.rdoRightPad)
        Me.pnlWords.Controls.Add(Me.ucrNudTo)
        Me.pnlWords.Controls.Add(Me.ucrPnlPad)
        Me.pnlWords.Controls.Add(Me.ucrNudFrom)
        Me.pnlWords.Controls.Add(Me.ucrInputPad)
        Me.pnlWords.Controls.Add(Me.lblPad)
        Me.pnlWords.Controls.Add(Me.lblToSubstring)
        Me.pnlWords.Controls.Add(Me.ucrChkFirstOr)
        Me.pnlWords.Controls.Add(Me.ucrNudWidth)
        Me.pnlWords.Controls.Add(Me.ucrChkLastOr)
        Me.pnlWords.Controls.Add(Me.ucrNudLastWord)
        Me.pnlWords.Controls.Add(Me.lblWidth)
        Me.pnlWords.Controls.Add(Me.lblFrom)
        Me.pnlWords.Controls.Add(Me.lblSeparator)
        Me.pnlWords.Controls.Add(Me.ucrNudFirstWord)
        Me.pnlWords.Controls.Add(Me.lblLastWord)
        Me.pnlWords.Controls.Add(Me.ucrInputSeparator)
        Me.pnlWords.Controls.Add(Me.ucrReceiverLastWord)
        Me.pnlWords.Controls.Add(Me.lblFirstWord)
        Me.pnlWords.Controls.Add(Me.ucrReceiverFirstWord)
        Me.pnlWords.Location = New System.Drawing.Point(6, 19)
        Me.pnlWords.Name = "pnlWords"
        Me.pnlWords.Size = New System.Drawing.Size(237, 152)
        Me.pnlWords.TabIndex = 0
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.Location = New System.Drawing.Point(151, 14)
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothPad.TabIndex = 40
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.Text = "Both"
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'ucrInputTo
        '
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(84, 10)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(107, 25)
        Me.ucrInputTo.TabIndex = 8
        '
        'rdoLeftPad
        '
        Me.rdoLeftPad.AutoSize = True
        Me.rdoLeftPad.Location = New System.Drawing.Point(13, 14)
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftPad.TabIndex = 38
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.Text = "Left"
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(10, 15)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 7
        Me.lblTo.Text = "To:"
        '
        'rdoRightPad
        '
        Me.rdoRightPad.AutoSize = True
        Me.rdoRightPad.Location = New System.Drawing.Point(77, 14)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightPad.TabIndex = 39
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(84, 38)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 46
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlPad
        '
        Me.ucrPnlPad.Location = New System.Drawing.Point(3, 8)
        Me.ucrPnlPad.Name = "ucrPnlPad"
        Me.ucrPnlPad.Size = New System.Drawing.Size(217, 30)
        Me.ucrPnlPad.TabIndex = 9
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(84, 12)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 45
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPad
        '
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(84, 126)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(107, 25)
        Me.ucrInputPad.TabIndex = 13
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.Location = New System.Drawing.Point(10, 130)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(29, 13)
        Me.lblPad.TabIndex = 14
        Me.lblPad.Text = "Pad:"
        '
        'ucrChkFirstOr
        '
        Me.ucrChkFirstOr.Checked = False
        Me.ucrChkFirstOr.Location = New System.Drawing.Point(3, 38)
        Me.ucrChkFirstOr.Name = "ucrChkFirstOr"
        Me.ucrChkFirstOr.Size = New System.Drawing.Size(75, 20)
        Me.ucrChkFirstOr.TabIndex = 42
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(84, 38)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 47
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkLastOr
        '
        Me.ucrChkLastOr.Checked = False
        Me.ucrChkLastOr.Location = New System.Drawing.Point(3, 95)
        Me.ucrChkLastOr.Name = "ucrChkLastOr"
        Me.ucrChkLastOr.Size = New System.Drawing.Size(75, 20)
        Me.ucrChkLastOr.TabIndex = 43
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLastWord.Location = New System.Drawing.Point(84, 66)
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLastWord.TabIndex = 45
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(10, 41)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFirstWord.Location = New System.Drawing.Point(84, 12)
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFirstWord.TabIndex = 44
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(84, 126)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(107, 23)
        Me.ucrInputSeparator.TabIndex = 17
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.frmParent = Me
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(84, 95)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverLastWord.TabIndex = 27
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.frmParent = Me
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(84, 38)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverFirstWord.TabIndex = 13
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.frmParent = Me
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(252, 58)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(135, 26)
        Me.ucrReceiverTransformText.TabIndex = 2
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 429)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrNewColName
        '
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 399)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(272, 24)
        Me.ucrNewColName.TabIndex = 5
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.bShowHiddenColumns = False
        Me.ucrSelectorForTransformText.bUseCurrentFilter = True
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(242, 185)
        Me.ucrSelectorForTransformText.TabIndex = 0
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 484)
        Me.Controls.Add(Me.ucrNewColName)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.grpOperation)
        Me.Controls.Add(Me.lblColumnToTransform)
        Me.Controls.Add(Me.ucrReceiverTransformText)
        Me.Controls.Add(Me.ucrSelectorForTransformText)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTransformText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform Text Column"
        Me.grpOperation.ResumeLayout(False)
        Me.grpOperation.PerformLayout()
        Me.grpParameters.ResumeLayout(False)
        Me.pnlWords.ResumeLayout(False)
        Me.pnlWords.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForTransformText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTransformText As ucrReceiverSingle
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents grpOperation As GroupBox
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents rdoConvertCase As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents ucrReceiverFirstWord As ucrReceiverSingle
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents lblToSubstring As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents rdoSubstring As RadioButton
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
    Friend WithEvents pnlWords As Panel
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
End Class
