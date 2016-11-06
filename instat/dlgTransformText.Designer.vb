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
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.grpOperation = New System.Windows.Forms.GroupBox()
        Me.rdoSubstring = New System.Windows.Forms.RadioButton()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblToSubstring = New System.Windows.Forms.Label()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.chkFirstWord = New System.Windows.Forms.CheckBox()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.nudLastWord = New System.Windows.Forms.NumericUpDown()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.nudFirstWord = New System.Windows.Forms.NumericUpDown()
        Me.grpParameters = New System.Windows.Forms.GroupBox()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.pnlTrim = New System.Windows.Forms.Panel()
        Me.rdoBothTrim = New System.Windows.Forms.RadioButton()
        Me.rdoLeftTrim = New System.Windows.Forms.RadioButton()
        Me.rdoRightTrim = New System.Windows.Forms.RadioButton()
        Me.pnlPad = New System.Windows.Forms.Panel()
        Me.rdoBothPad = New System.Windows.Forms.RadioButton()
        Me.rdoLeftPad = New System.Windows.Forms.RadioButton()
        Me.rdoRightPad = New System.Windows.Forms.RadioButton()
        Me.chkLastWord = New System.Windows.Forms.CheckBox()
        Me.ucrReceiverLastWord = New instat.ucrReceiverSingle()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrReceiverFirstWord = New instat.ucrReceiverSingle()
        Me.ucrInputPrefixForNewColumn = New instat.ucrInputComboBox()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpOperation.SuspendLayout()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLastWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFirstWord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParameters.SuspendLayout()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTrim.SuspendLayout()
        Me.pnlPad.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.Location = New System.Drawing.Point(265, 31)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(107, 13)
        Me.lblColumnToTransform.TabIndex = 3
        Me.lblColumnToTransform.Text = "Column to Transform:"
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(8, 373)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 5
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'grpOperation
        '
        Me.grpOperation.Controls.Add(Me.rdoSubstring)
        Me.grpOperation.Controls.Add(Me.rdoWords)
        Me.grpOperation.Controls.Add(Me.rdoTrim)
        Me.grpOperation.Controls.Add(Me.rdoPad)
        Me.grpOperation.Controls.Add(Me.rdoLength)
        Me.grpOperation.Controls.Add(Me.rdoConvertCase)
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
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(153, 22)
        Me.nudTo.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(51, 20)
        Me.nudTo.TabIndex = 25
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
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
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(53, 21)
        Me.nudFrom.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {200, 0, 0, -2147483648})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(51, 20)
        Me.nudFrom.TabIndex = 23
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
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
        'chkFirstWord
        '
        Me.chkFirstWord.AutoSize = True
        Me.chkFirstWord.Location = New System.Drawing.Point(14, 48)
        Me.chkFirstWord.Name = "chkFirstWord"
        Me.chkFirstWord.Size = New System.Drawing.Size(75, 17)
        Me.chkFirstWord.TabIndex = 20
        Me.chkFirstWord.Text = "Or Column"
        Me.chkFirstWord.UseVisualStyleBackColor = True
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
        'nudLastWord
        '
        Me.nudLastWord.Location = New System.Drawing.Point(75, 78)
        Me.nudLastWord.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudLastWord.Minimum = New Decimal(New Integer() {100000, 0, 0, -2147483648})
        Me.nudLastWord.Name = "nudLastWord"
        Me.nudLastWord.Size = New System.Drawing.Size(51, 20)
        Me.nudLastWord.TabIndex = 16
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
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(11, 25)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(58, 13)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word:"
        '
        'nudFirstWord
        '
        Me.nudFirstWord.Location = New System.Drawing.Point(75, 22)
        Me.nudFirstWord.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudFirstWord.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudFirstWord.Name = "nudFirstWord"
        Me.nudFirstWord.Size = New System.Drawing.Size(51, 20)
        Me.nudFirstWord.TabIndex = 11
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.pnlTrim)
        Me.grpParameters.Controls.Add(Me.pnlPad)
        Me.grpParameters.Controls.Add(Me.lblToSubstring)
        Me.grpParameters.Controls.Add(Me.nudTo)
        Me.grpParameters.Controls.Add(Me.lblPad)
        Me.grpParameters.Controls.Add(Me.lblLastWord)
        Me.grpParameters.Controls.Add(Me.lblWidth)
        Me.grpParameters.Controls.Add(Me.nudFrom)
        Me.grpParameters.Controls.Add(Me.lblSeparator)
        Me.grpParameters.Controls.Add(Me.ucrReceiverLastWord)
        Me.grpParameters.Controls.Add(Me.lblFrom)
        Me.grpParameters.Controls.Add(Me.chkLastWord)
        Me.grpParameters.Controls.Add(Me.ucrInputPad)
        Me.grpParameters.Controls.Add(Me.lblTo)
        Me.grpParameters.Controls.Add(Me.lblFirstWord)
        Me.grpParameters.Controls.Add(Me.ucrInputTo)
        Me.grpParameters.Controls.Add(Me.nudFirstWord)
        Me.grpParameters.Controls.Add(Me.chkFirstWord)
        Me.grpParameters.Controls.Add(Me.nudLastWord)
        Me.grpParameters.Controls.Add(Me.ucrInputSeparator)
        Me.grpParameters.Controls.Add(Me.nudWidth)
        Me.grpParameters.Controls.Add(Me.ucrReceiverFirstWord)
        Me.grpParameters.Location = New System.Drawing.Point(118, 205)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(267, 155)
        Me.grpParameters.TabIndex = 8
        Me.grpParameters.TabStop = False
        Me.grpParameters.Text = "Options"
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
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(14, 25)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 7
        Me.lblTo.Text = "To:"
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(63, 45)
        Me.nudWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(51, 20)
        Me.nudWidth.TabIndex = 12
        Me.nudWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(12, 49)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(38, 13)
        Me.lblWidth.TabIndex = 11
        Me.lblWidth.Text = "Width:"
        '
        'pnlTrim
        '
        Me.pnlTrim.Controls.Add(Me.rdoBothTrim)
        Me.pnlTrim.Controls.Add(Me.rdoLeftTrim)
        Me.pnlTrim.Controls.Add(Me.rdoRightTrim)
        Me.pnlTrim.Location = New System.Drawing.Point(13, 19)
        Me.pnlTrim.Name = "pnlTrim"
        Me.pnlTrim.Size = New System.Drawing.Size(154, 24)
        Me.pnlTrim.TabIndex = 42
        '
        'rdoBothTrim
        '
        Me.rdoBothTrim.AutoSize = True
        Me.rdoBothTrim.Location = New System.Drawing.Point(104, 4)
        Me.rdoBothTrim.Name = "rdoBothTrim"
        Me.rdoBothTrim.Size = New System.Drawing.Size(47, 17)
        Me.rdoBothTrim.TabIndex = 37
        Me.rdoBothTrim.TabStop = True
        Me.rdoBothTrim.Text = "Both"
        Me.rdoBothTrim.UseVisualStyleBackColor = True
        '
        'rdoLeftTrim
        '
        Me.rdoLeftTrim.AutoSize = True
        Me.rdoLeftTrim.Location = New System.Drawing.Point(3, 4)
        Me.rdoLeftTrim.Name = "rdoLeftTrim"
        Me.rdoLeftTrim.Size = New System.Drawing.Size(43, 17)
        Me.rdoLeftTrim.TabIndex = 35
        Me.rdoLeftTrim.TabStop = True
        Me.rdoLeftTrim.Text = "Left"
        Me.rdoLeftTrim.UseVisualStyleBackColor = True
        '
        'rdoRightTrim
        '
        Me.rdoRightTrim.AutoSize = True
        Me.rdoRightTrim.Location = New System.Drawing.Point(50, 4)
        Me.rdoRightTrim.Name = "rdoRightTrim"
        Me.rdoRightTrim.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightTrim.TabIndex = 36
        Me.rdoRightTrim.TabStop = True
        Me.rdoRightTrim.Text = "Right"
        Me.rdoRightTrim.UseVisualStyleBackColor = True
        '
        'pnlPad
        '
        Me.pnlPad.Controls.Add(Me.rdoBothPad)
        Me.pnlPad.Controls.Add(Me.rdoLeftPad)
        Me.pnlPad.Controls.Add(Me.rdoRightPad)
        Me.pnlPad.Location = New System.Drawing.Point(13, 19)
        Me.pnlPad.Name = "pnlPad"
        Me.pnlPad.Size = New System.Drawing.Size(154, 24)
        Me.pnlPad.TabIndex = 41
        '
        'rdoBothPad
        '
        Me.rdoBothPad.AutoSize = True
        Me.rdoBothPad.Location = New System.Drawing.Point(104, 4)
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
        Me.rdoLeftPad.Location = New System.Drawing.Point(3, 4)
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
        Me.rdoRightPad.Location = New System.Drawing.Point(50, 4)
        Me.rdoRightPad.Name = "rdoRightPad"
        Me.rdoRightPad.Size = New System.Drawing.Size(50, 17)
        Me.rdoRightPad.TabIndex = 39
        Me.rdoRightPad.TabStop = True
        Me.rdoRightPad.Text = "Right"
        Me.rdoRightPad.UseVisualStyleBackColor = True
        '
        'chkLastWord
        '
        Me.chkLastWord.AutoSize = True
        Me.chkLastWord.Location = New System.Drawing.Point(14, 104)
        Me.chkLastWord.Name = "chkLastWord"
        Me.chkLastWord.Size = New System.Drawing.Size(75, 17)
        Me.chkLastWord.TabIndex = 26
        Me.chkLastWord.Text = "Or Column"
        Me.chkLastWord.UseVisualStyleBackColor = True
        '
        'ucrReceiverLastWord
        '
        Me.ucrReceiverLastWord.Location = New System.Drawing.Point(92, 101)
        Me.ucrReceiverLastWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverLastWord.Name = "ucrReceiverLastWord"
        Me.ucrReceiverLastWord.Selector = Nothing
        Me.ucrReceiverLastWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverLastWord.TabIndex = 27
        '
        'ucrInputPad
        '
        Me.ucrInputPad.IsReadOnly = False
        Me.ucrInputPad.Location = New System.Drawing.Point(63, 74)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(94, 25)
        Me.ucrInputPad.TabIndex = 13
        '
        'ucrInputTo
        '
        Me.ucrInputTo.IsReadOnly = False
        Me.ucrInputTo.Location = New System.Drawing.Point(53, 21)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(94, 25)
        Me.ucrInputTo.TabIndex = 8
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(92, 127)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(107, 23)
        Me.ucrInputSeparator.TabIndex = 17
        '
        'ucrReceiverFirstWord
        '
        Me.ucrReceiverFirstWord.Location = New System.Drawing.Point(92, 45)
        Me.ucrReceiverFirstWord.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFirstWord.Name = "ucrReceiverFirstWord"
        Me.ucrReceiverFirstWord.Selector = Nothing
        Me.ucrReceiverFirstWord.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverFirstWord.TabIndex = 13
        '
        'ucrInputPrefixForNewColumn
        '
        Me.ucrInputPrefixForNewColumn.IsReadOnly = False
        Me.ucrInputPrefixForNewColumn.Location = New System.Drawing.Point(112, 369)
        Me.ucrInputPrefixForNewColumn.Name = "ucrInputPrefixForNewColumn"
        Me.ucrInputPrefixForNewColumn.Size = New System.Drawing.Size(187, 25)
        Me.ucrInputPrefixForNewColumn.TabIndex = 4
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(266, 46)
        Me.ucrReceiverTransformText.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(119, 26)
        Me.ucrReceiverTransformText.TabIndex = 2
        '
        'ucrSelectorForTransformText
        '
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
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 457)
        Me.Controls.Add(Me.grpParameters)
        Me.Controls.Add(Me.grpOperation)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputPrefixForNewColumn)
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
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLastWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFirstWord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTrim.ResumeLayout(False)
        Me.pnlTrim.PerformLayout()
        Me.pnlPad.ResumeLayout(False)
        Me.pnlPad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForTransformText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTransformText As ucrReceiverSingle
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents ucrInputPrefixForNewColumn As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents grpOperation As GroupBox
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents rdoConvertCase As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents ucrReceiverFirstWord As ucrReceiverSingle
    Friend WithEvents nudFirstWord As NumericUpDown
    Friend WithEvents nudLastWord As NumericUpDown
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents chkFirstWord As CheckBox
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents lblToSubstring As Label
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents lblFrom As Label
    Friend WithEvents rdoSubstring As RadioButton
    Friend WithEvents grpParameters As GroupBox
    Friend WithEvents lblPad As Label
    Friend WithEvents ucrInputPad As ucrInputComboBox
    Friend WithEvents nudWidth As NumericUpDown
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents ucrReceiverLastWord As ucrReceiverSingle
    Friend WithEvents chkLastWord As CheckBox
    Friend WithEvents rdoBothPad As RadioButton
    Friend WithEvents rdoRightPad As RadioButton
    Friend WithEvents rdoLeftPad As RadioButton
    Friend WithEvents rdoBothTrim As RadioButton
    Friend WithEvents rdoRightTrim As RadioButton
    Friend WithEvents rdoLeftTrim As RadioButton
    Friend WithEvents pnlPad As Panel
    Friend WithEvents pnlTrim As Panel
End Class
