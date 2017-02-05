<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTransformText
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblColumnToTransform = New System.Windows.Forms.Label()
        Me.grpOperation = New System.Windows.Forms.GroupBox()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOperation = New instat.UcrPanel()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.ucrNudFirstWord = New instat.ucrNud()
        Me.ucrChkFirstOrColumn = New instat.ucrCheck()
        Me.ucrNudLastWord = New instat.ucrNud()
        Me.ucrChkOrColumn = New instat.ucrCheck()
        Me.ucrNudWidth = New instat.ucrNud()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.ucrPnlPad = New instat.UcrPanel()
        Me.ucrNewColName = New instat.ucrSave()
        Me.grpOperation.SuspendLayout()
        Me.grpParameters.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.Location = New System.Drawing.Point(252, 31)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(107, 13)
        Me.lblColumnToTransform.TabIndex = 3
        Me.lblColumnToTransform.Text = "Column to Transform:"
        '
        'grpOperation
        '
        Me.grpOperation.Controls.Add(Me.rdoSubstring)
        Me.grpOperation.Controls.Add(Me.rdoWords)
        Me.grpOperation.Controls.Add(Me.rdoTrim)
        Me.grpOperation.Controls.Add(Me.rdoPad)
        Me.grpOperation.Controls.Add(Me.rdoLength)
        Me.grpOperation.Controls.Add(Me.rdoConvertCase)
        Me.grpOperation.Controls.Add(Me.ucrPnlOperation)
        Me.grpOperation.Location = New System.Drawing.Point(10, 205)
        Me.grpOperation.Name = "grpOperation"
        Me.grpOperation.Size = New System.Drawing.Size(106, 155)
        Me.grpOperation.TabIndex = 6
        Me.grpOperation.TabStop = False
        Me.grpOperation.Text = "Operation"
        '
        'rdoSubstring
        '
        Me.rdoSubstring.AutoSize = True
        Me.rdoSubstring.Location = New System.Drawing.Point(6, 134)
        Me.rdoSubstring.Name = "rdoSubstring"
        Me.rdoSubstring.Size = New System.Drawing.Size(69, 17)
        Me.rdoSubstring.TabIndex = 21
        Me.rdoSubstring.TabStop = True
        Me.rdoSubstring.Text = "Substring"
        Me.rdoSubstring.UseVisualStyleBackColor = True
        '
        'rdoWords
        '
        Me.rdoWords.AutoSize = True
        Me.rdoWords.Location = New System.Drawing.Point(6, 111)
        Me.rdoWords.Name = "rdoWords"
        Me.rdoWords.Size = New System.Drawing.Size(56, 17)
        Me.rdoWords.TabIndex = 4
        Me.rdoWords.TabStop = True
        Me.rdoWords.Text = "Words"
        Me.rdoWords.UseVisualStyleBackColor = True
        '
        'rdoTrim
        '
        Me.rdoTrim.AutoSize = True
        Me.rdoTrim.Location = New System.Drawing.Point(6, 88)
        Me.rdoTrim.Name = "rdoTrim"
        Me.rdoTrim.Size = New System.Drawing.Size(45, 17)
        Me.rdoTrim.TabIndex = 3
        Me.rdoTrim.TabStop = True
        Me.rdoTrim.Text = "Trim"
        Me.rdoTrim.UseVisualStyleBackColor = True
        '
        'rdoPad
        '
        Me.rdoPad.AutoSize = True
        Me.rdoPad.Location = New System.Drawing.Point(6, 65)
        Me.rdoPad.Name = "rdoPad"
        Me.rdoPad.Size = New System.Drawing.Size(44, 17)
        Me.rdoPad.TabIndex = 2
        Me.rdoPad.TabStop = True
        Me.rdoPad.Text = "Pad"
        Me.rdoPad.UseVisualStyleBackColor = True
        '
        'rdoLength
        '
        Me.rdoLength.AutoSize = True
        Me.rdoLength.Location = New System.Drawing.Point(6, 42)
        Me.rdoLength.Name = "rdoLength"
        Me.rdoLength.Size = New System.Drawing.Size(58, 17)
        Me.rdoLength.TabIndex = 1
        Me.rdoLength.TabStop = True
        Me.rdoLength.Text = "Length"
        Me.rdoLength.UseVisualStyleBackColor = True
        '
        'rdoConvertCase
        '
        Me.rdoConvertCase.AutoSize = True
        Me.rdoConvertCase.Location = New System.Drawing.Point(6, 19)
        Me.rdoConvertCase.Name = "rdoConvertCase"
        Me.rdoConvertCase.Size = New System.Drawing.Size(89, 17)
        Me.rdoConvertCase.TabIndex = 0
        Me.rdoConvertCase.TabStop = True
        Me.rdoConvertCase.Text = "Convert Case"
        Me.rdoConvertCase.UseVisualStyleBackColor = True
        '
        'ucrPnlOperation
        '
        Me.ucrPnlOperation.bAddRemoveParameter = True
        Me.ucrPnlOperation.bChangeParameterValue = True
        Me.ucrPnlOperation.Location = New System.Drawing.Point(2, 15)
        Me.ucrPnlOperation.Name = "ucrPnlOperation"
        Me.ucrPnlOperation.Size = New System.Drawing.Size(100, 136)
        Me.ucrPnlOperation.TabIndex = 9
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(16, 25)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 22
        Me.lblFrom.Text = "From:"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(11, 25)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word:"
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.Location = New System.Drawing.Point(128, 25)
        Me.rdoBothPad.Name = "rdoBothPad"
        Me.rdoBothPad.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothPad.TabIndex = 40
        Me.rdoBothPad.TabStop = True
        Me.rdoBothPad.Text = "Both"
        Me.rdoBothPad.UseVisualStyleBackColor = True
        '
        'rdoLeftPad
        '
        Me.rdoLeftPad.AutoSize = True
        Me.rdoLeftPad.Location = New System.Drawing.Point(21, 25)
        Me.rdoLeftPad.Name = "rdoLeftPad"
        Me.rdoLeftPad.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftPad.TabIndex = 38
        Me.rdoLeftPad.TabStop = True
        Me.rdoLeftPad.Text = "Left"
        Me.rdoLeftPad.UseVisualStyleBackColor = True
        '
        'rdoRightPad
        '
        Me.rdoRightPad.AutoSize = True
        Me.rdoRightPad.Location = New System.Drawing.Point(72, 25)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightPad.TabIndex = 39
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(14, 25)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 7
        Me.lblTo.Text = "To:"
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.bAddRemoveParameter = True
        Me.ucrReceiverTransformText.bChangeParameterValue = True
        Me.ucrReceiverTransformText.frmParent = Me
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(252, 46)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(133, 26)
        Me.ucrReceiverTransformText.TabIndex = 2
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.bAddRemoveParameter = True
        Me.ucrSelectorForTransformText.bChangeParameterValue = True
        Me.ucrSelectorForTransformText.bShowHiddenColumns = False
        Me.ucrSelectorForTransformText.bUseCurrentFilter = True
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorForTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(242, 185)
        Me.ucrSelectorForTransformText.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 399)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.bAddRemoveParameter = True
        Me.ucrReceiverFirstWord.bChangeParameterValue = True
        Me.ucrReceiverFirstWord.frmParent = Me
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(92, 45)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverFirstWord.TabIndex = 13
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.bAddRemoveParameter = True
        Me.ucrInputSeparator.bChangeParameterValue = True
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(92, 126)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(107, 23)
        Me.ucrInputSeparator.TabIndex = 17
        '
        'ucrInputPad
        '
        Me.ucrInputPad.bAddRemoveParameter = True
        Me.ucrInputPad.bChangeParameterValue = True
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(153, 78)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(94, 25)
        Me.ucrInputPad.TabIndex = 13
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.bAddRemoveParameter = True
        Me.ucrReceiverLastWord.bChangeParameterValue = True
        Me.ucrReceiverLastWord.frmParent = Me
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(92, 103)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverLastWord.TabIndex = 27
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(14, 131)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 18
        Me.lblSeparator.Text = "Separator:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(11, 65)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.Location = New System.Drawing.Point(11, 80)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(59, 13)
        Me.lblLastWord.TabIndex = 15
        Me.lblLastWord.Text = "Last Word:"
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.Location = New System.Drawing.Point(14, 80)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(29, 13)
        Me.lblPad.TabIndex = 14
        Me.lblPad.Text = "Pad:"
        '
        'lblToSubstring
        '
        Me.lblToSubstring.AutoSize = True
        Me.lblToSubstring.Location = New System.Drawing.Point(124, 25)
        Me.lblToSubstring.Name = "lblToSubstring"
        Me.lblToSubstring.Size = New System.Drawing.Size(23, 13)
        Me.lblToSubstring.TabIndex = 24
        Me.lblToSubstring.Text = "To:"
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.ucrNudTo)
        Me.grpParameters.Controls.Add(Me.rdoLeftPad)
        Me.grpParameters.Controls.Add(Me.ucrNudFrom)
        Me.grpParameters.Controls.Add(Me.rdoBothPad)
        Me.grpParameters.Controls.Add(Me.ucrNudFirstWord)
        Me.grpParameters.Controls.Add(Me.rdoRightPad)
        Me.grpParameters.Controls.Add(Me.ucrChkFirstOrColumn)
        Me.grpParameters.Controls.Add(Me.ucrPnlPad)
        Me.grpParameters.Controls.Add(Me.ucrNudLastWord)
        Me.grpParameters.Controls.Add(Me.ucrChkOrColumn)
        Me.grpParameters.Controls.Add(Me.ucrNudWidth)
        Me.grpParameters.Controls.Add(Me.lblToSubstring)
        Me.grpParameters.Controls.Add(Me.lblPad)
        Me.grpParameters.Controls.Add(Me.lblLastWord)
        Me.grpParameters.Controls.Add(Me.lblWidth)
        Me.grpParameters.Controls.Add(Me.lblSeparator)
        Me.grpParameters.Controls.Add(Me.ucrReceiverLastWord)
        Me.grpParameters.Controls.Add(Me.lblFrom)
        Me.grpParameters.Controls.Add(Me.ucrInputPad)
        Me.grpParameters.Controls.Add(Me.lblTo)
        Me.grpParameters.Controls.Add(Me.lblFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrInputTo)
        Me.grpParameters.Controls.Add(Me.ucrInputSeparator)
        Me.grpParameters.Controls.Add(Me.ucrReceiverFirstWord)
        Me.grpParameters.Location = New System.Drawing.Point(118, 205)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(267, 155)
        Me.grpParameters.TabIndex = 8
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
        '
        'ucrNudTo
        '
        Me.ucrNudTo.bAddRemoveParameter = True
        Me.ucrNudTo.bChangeParameterValue = True
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(153, 22)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 42
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.bAddRemoveParameter = True
        Me.ucrNudFrom.bChangeParameterValue = True
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(64, 22)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 43
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFirstWord
        '
        Me.ucrNudFirstWord.bAddRemoveParameter = True
        Me.ucrNudFirstWord.bChangeParameterValue = True
        Me.ucrNudFirstWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFirstWord.Location = New System.Drawing.Point(64, 22)
        Me.ucrNudFirstWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFirstWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFirstWord.Name = "ucrNudFirstWord"
        Me.ucrNudFirstWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFirstWord.TabIndex = 43
        Me.ucrNudFirstWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFirstOrColumn
        '
        Me.ucrChkFirstOrColumn.bAddRemoveParameter = True
        Me.ucrChkFirstOrColumn.bChangeParameterValue = True
        Me.ucrChkFirstOrColumn.Checked = False
        Me.ucrChkFirstOrColumn.Location = New System.Drawing.Point(14, 46)
        Me.ucrChkFirstOrColumn.Name = "ucrChkFirstOrColumn"
        Me.ucrChkFirstOrColumn.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFirstOrColumn.TabIndex = 42
        '
        'ucrNudLastWord
        '
        Me.ucrNudLastWord.bAddRemoveParameter = True
        Me.ucrNudLastWord.bChangeParameterValue = True
        Me.ucrNudLastWord.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLastWord.Location = New System.Drawing.Point(73, 77)
        Me.ucrNudLastWord.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLastWord.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLastWord.Name = "ucrNudLastWord"
        Me.ucrNudLastWord.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLastWord.TabIndex = 30
        Me.ucrNudLastWord.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkOrColumn
        '
        Me.ucrChkOrColumn.bAddRemoveParameter = True
        Me.ucrChkOrColumn.bChangeParameterValue = True
        Me.ucrChkOrColumn.Checked = False
        Me.ucrChkOrColumn.Location = New System.Drawing.Point(14, 103)
        Me.ucrChkOrColumn.Name = "ucrChkOrColumn"
        Me.ucrChkOrColumn.Size = New System.Drawing.Size(100, 19)
        Me.ucrChkOrColumn.TabIndex = 29
        '
        'ucrNudWidth
        '
        Me.ucrNudWidth.bAddRemoveParameter = True
        Me.ucrNudWidth.bChangeParameterValue = True
        Me.ucrNudWidth.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWidth.Location = New System.Drawing.Point(53, 47)
        Me.ucrNudWidth.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWidth.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWidth.Name = "ucrNudWidth"
        Me.ucrNudWidth.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWidth.TabIndex = 28
        Me.ucrNudWidth.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputTo
        '
        Me.ucrInputTo.bAddRemoveParameter = True
        Me.ucrInputTo.bChangeParameterValue = True
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(68, 22)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(94, 25)
        Me.ucrInputTo.TabIndex = 8
        '
        'ucrPnlPad
        '
        Me.ucrPnlPad.bAddRemoveParameter = True
        Me.ucrPnlPad.bChangeParameterValue = True
        Me.ucrPnlPad.Location = New System.Drawing.Point(15, 15)
        Me.ucrPnlPad.Name = "ucrPnlPad"
        Me.ucrPnlPad.Size = New System.Drawing.Size(169, 41)
        Me.ucrPnlPad.TabIndex = 41
        '
        'ucrNewColName
        '
        Me.ucrNewColName.bAddRemoveParameter = True
        Me.ucrNewColName.bChangeParameterValue = True
        Me.ucrNewColName.Location = New System.Drawing.Point(10, 369)
        Me.ucrNewColName.Name = "ucrNewColName"
        Me.ucrNewColName.Size = New System.Drawing.Size(275, 24)
        Me.ucrNewColName.TabIndex = 42
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 457)
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
        Me.grpParameters.PerformLayout()
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
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents rdoSubstring As RadioButton
    Friend WithEvents lblTo As Label
    Friend WithEvents rdoBothPad As RadioButton
    Friend WithEvents rdoRightPad As RadioButton
    Friend WithEvents rdoLeftPad As RadioButton
    Friend WithEvents ucrPnlOperation As UcrPanel
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents lblToSubstring As Label
    Friend WithEvents lblPad As Label
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrReceiverLastWord As ucrReceiverSingle
    Friend WithEvents ucrInputPad As ucrInputComboBox
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrReceiverFirstWord As ucrReceiverSingle
    Friend WithEvents ucrPnlPad As UcrPanel
    Friend WithEvents ucrNudWidth As ucrNud
    Friend WithEvents ucrChkOrColumn As ucrCheck
    Friend WithEvents ucrNudLastWord As ucrNud
    Friend WithEvents ucrChkFirstOrColumn As ucrCheck
    Friend WithEvents ucrNudFirstWord As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents ucrNewColName As ucrSave
End Class
