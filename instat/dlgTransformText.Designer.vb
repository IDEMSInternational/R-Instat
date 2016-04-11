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
        Me.lblPrefixForNewColumns = New System.Windows.Forms.Label()
        Me.grpOperation = New System.Windows.Forms.GroupBox()
        Me.chkLeft = New System.Windows.Forms.CheckBox()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.nudLastWord = New System.Windows.Forms.NumericUpDown()
        Me.lblLastWord = New System.Windows.Forms.Label()
        Me.lblFirstWord = New System.Windows.Forms.Label()
        Me.ucrReceiverOrColumn = New instat.ucrReceiverSingle()
        Me.nudFirstWord = New System.Windows.Forms.NumericUpDown()
        Me.lblPad = New System.Windows.Forms.Label()
        Me.ucrInputPad = New instat.ucrInputComboBox()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ucrInputTo = New instat.ucrInputComboBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.rdoWords = New System.Windows.Forms.RadioButton()
        Me.rdoTrim = New System.Windows.Forms.RadioButton()
        Me.rdoPad = New System.Windows.Forms.RadioButton()
        Me.rdoLength = New System.Windows.Forms.RadioButton()
        Me.rdoConvertCase = New System.Windows.Forms.RadioButton()
        Me.ucrInputPrefixForNewColumn = New instat.ucrInputComboBox()
        Me.ucrReceiverTransformText = New instat.ucrReceiverSingle()
        Me.ucrSelectorForTransformText = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.chkOrColumn = New System.Windows.Forms.CheckBox()
        Me.grpOperation.SuspendLayout()
        CType(Me.nudLastWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFirstWord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblColumnToTransform
        '
        Me.lblColumnToTransform.AutoSize = True
        Me.lblColumnToTransform.Location = New System.Drawing.Point(296, 13)
        Me.lblColumnToTransform.Name = "lblColumnToTransform"
        Me.lblColumnToTransform.Size = New System.Drawing.Size(104, 13)
        Me.lblColumnToTransform.TabIndex = 3
        Me.lblColumnToTransform.Text = "Column to Transform"
        '
        'lblPrefixForNewColumns
        '
        Me.lblPrefixForNewColumns.AutoSize = True
        Me.lblPrefixForNewColumns.Location = New System.Drawing.Point(9, 404)
        Me.lblPrefixForNewColumns.Name = "lblPrefixForNewColumns"
        Me.lblPrefixForNewColumns.Size = New System.Drawing.Size(116, 13)
        Me.lblPrefixForNewColumns.TabIndex = 5
        Me.lblPrefixForNewColumns.Text = "Prefix for New Columns"
        '
        'grpOperation
        '
        Me.grpOperation.Controls.Add(Me.chkOrColumn)
        Me.grpOperation.Controls.Add(Me.chkLeft)
        Me.grpOperation.Controls.Add(Me.lblSeparator)
        Me.grpOperation.Controls.Add(Me.ucrInputSeparator)
        Me.grpOperation.Controls.Add(Me.nudLastWord)
        Me.grpOperation.Controls.Add(Me.lblLastWord)
        Me.grpOperation.Controls.Add(Me.lblFirstWord)
        Me.grpOperation.Controls.Add(Me.ucrReceiverOrColumn)
        Me.grpOperation.Controls.Add(Me.nudFirstWord)
        Me.grpOperation.Controls.Add(Me.lblPad)
        Me.grpOperation.Controls.Add(Me.ucrInputPad)
        Me.grpOperation.Controls.Add(Me.nudWidth)
        Me.grpOperation.Controls.Add(Me.lblWidth)
        Me.grpOperation.Controls.Add(Me.ucrInputTo)
        Me.grpOperation.Controls.Add(Me.lblTo)
        Me.grpOperation.Controls.Add(Me.rdoWords)
        Me.grpOperation.Controls.Add(Me.rdoTrim)
        Me.grpOperation.Controls.Add(Me.rdoPad)
        Me.grpOperation.Controls.Add(Me.rdoLength)
        Me.grpOperation.Controls.Add(Me.rdoConvertCase)
        Me.grpOperation.Location = New System.Drawing.Point(9, 199)
        Me.grpOperation.Name = "grpOperation"
        Me.grpOperation.Size = New System.Drawing.Size(392, 196)
        Me.grpOperation.TabIndex = 6
        Me.grpOperation.TabStop = False
        Me.grpOperation.Text = "Operation"
        '
        'chkLeft
        '
        Me.chkLeft.AutoSize = True
        Me.chkLeft.Location = New System.Drawing.Point(200, 66)
        Me.chkLeft.Name = "chkLeft"
        Me.chkLeft.Size = New System.Drawing.Size(44, 17)
        Me.chkLeft.TabIndex = 19
        Me.chkLeft.Text = "Left"
        Me.chkLeft.UseVisualStyleBackColor = True
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(163, 171)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparator.TabIndex = 18
        Me.lblSeparator.Text = "Seperator"
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.Location = New System.Drawing.Point(242, 164)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(73, 25)
        Me.ucrInputSeparator.TabIndex = 17
        '
        'nudLastWord
        '
        Me.nudLastWord.Location = New System.Drawing.Point(105, 169)
        Me.nudLastWord.Name = "nudLastWord"
        Me.nudLastWord.Size = New System.Drawing.Size(51, 20)
        Me.nudLastWord.TabIndex = 16
        '
        'lblLastWord
        '
        Me.lblLastWord.AutoSize = True
        Me.lblLastWord.Location = New System.Drawing.Point(102, 153)
        Me.lblLastWord.Name = "lblLastWord"
        Me.lblLastWord.Size = New System.Drawing.Size(56, 13)
        Me.lblLastWord.TabIndex = 15
        Me.lblLastWord.Text = "Last Word"
        '
        'lblFirstWord
        '
        Me.lblFirstWord.AutoSize = True
        Me.lblFirstWord.Location = New System.Drawing.Point(102, 113)
        Me.lblFirstWord.Name = "lblFirstWord"
        Me.lblFirstWord.Size = New System.Drawing.Size(55, 13)
        Me.lblFirstWord.TabIndex = 14
        Me.lblFirstWord.Text = "First Word"
        '
        'ucrReceiverOrColumn
        '
        Me.ucrReceiverOrColumn.Location = New System.Drawing.Point(242, 124)
        Me.ucrReceiverOrColumn.Name = "ucrReceiverOrColumn"
        Me.ucrReceiverOrColumn.Selector = Nothing
        Me.ucrReceiverOrColumn.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverOrColumn.TabIndex = 13
        '
        'nudFirstWord
        '
        Me.nudFirstWord.Location = New System.Drawing.Point(105, 130)
        Me.nudFirstWord.Name = "nudFirstWord"
        Me.nudFirstWord.Size = New System.Drawing.Size(51, 20)
        Me.nudFirstWord.TabIndex = 11
        '
        'lblPad
        '
        Me.lblPad.AutoSize = True
        Me.lblPad.Location = New System.Drawing.Point(250, 67)
        Me.lblPad.Name = "lblPad"
        Me.lblPad.Size = New System.Drawing.Size(26, 13)
        Me.lblPad.TabIndex = 10
        Me.lblPad.Text = "Pad"
        '
        'ucrInputPad
        '
        Me.ucrInputPad.Location = New System.Drawing.Point(282, 60)
        Me.ucrInputPad.Name = "ucrInputPad"
        Me.ucrInputPad.Size = New System.Drawing.Size(73, 25)
        Me.ucrInputPad.TabIndex = 9
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(143, 65)
        Me.nudWidth.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.Size = New System.Drawing.Size(51, 20)
        Me.nudWidth.TabIndex = 8
        Me.nudWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(102, 70)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 7
        Me.lblWidth.Text = "Width"
        '
        'ucrInputTo
        '
        Me.ucrInputTo.Location = New System.Drawing.Point(143, 19)
        Me.ucrInputTo.Name = "ucrInputTo"
        Me.ucrInputTo.Size = New System.Drawing.Size(73, 25)
        Me.ucrInputTo.TabIndex = 6
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(102, 21)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To"
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
        'ucrInputPrefixForNewColumn
        '
        Me.ucrInputPrefixForNewColumn.Location = New System.Drawing.Point(142, 401)
        Me.ucrInputPrefixForNewColumn.Name = "ucrInputPrefixForNewColumn"
        Me.ucrInputPrefixForNewColumn.Size = New System.Drawing.Size(73, 25)
        Me.ucrInputPrefixForNewColumn.TabIndex = 4
        '
        'ucrReceiverTransformText
        '
        Me.ucrReceiverTransformText.Location = New System.Drawing.Point(295, 29)
        Me.ucrReceiverTransformText.Name = "ucrReceiverTransformText"
        Me.ucrReceiverTransformText.Selector = Nothing
        Me.ucrReceiverTransformText.Size = New System.Drawing.Size(107, 26)
        Me.ucrReceiverTransformText.TabIndex = 2
        '
        'ucrSelectorForTransformText
        '
        Me.ucrSelectorForTransformText.Location = New System.Drawing.Point(9, 13)
        Me.ucrSelectorForTransformText.Name = "ucrSelectorForTransformText"
        Me.ucrSelectorForTransformText.Size = New System.Drawing.Size(242, 179)
        Me.ucrSelectorForTransformText.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 432)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 0
        '
        'chkOrColumn
        '
        Me.chkOrColumn.AutoSize = True
        Me.chkOrColumn.Location = New System.Drawing.Point(163, 132)
        Me.chkOrColumn.Name = "chkOrColumn"
        Me.chkOrColumn.Size = New System.Drawing.Size(75, 17)
        Me.chkOrColumn.TabIndex = 20
        Me.chkOrColumn.Text = "Or Column"
        Me.chkOrColumn.UseVisualStyleBackColor = True
        '
        'dlgTransformText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 497)
        Me.Controls.Add(Me.grpOperation)
        Me.Controls.Add(Me.lblPrefixForNewColumns)
        Me.Controls.Add(Me.ucrInputPrefixForNewColumn)
        Me.Controls.Add(Me.lblColumnToTransform)
        Me.Controls.Add(Me.ucrReceiverTransformText)
        Me.Controls.Add(Me.ucrSelectorForTransformText)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgTransformText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transform Text Column"
        Me.grpOperation.ResumeLayout(False)
        Me.grpOperation.PerformLayout()
        CType(Me.nudLastWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFirstWord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForTransformText As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverTransformText As ucrReceiverSingle
    Friend WithEvents lblColumnToTransform As Label
    Friend WithEvents ucrInputPrefixForNewColumn As ucrInputComboBox
    Friend WithEvents lblPrefixForNewColumns As Label
    Friend WithEvents grpOperation As GroupBox
    Friend WithEvents rdoTrim As RadioButton
    Friend WithEvents rdoPad As RadioButton
    Friend WithEvents rdoLength As RadioButton
    Friend WithEvents rdoConvertCase As RadioButton
    Friend WithEvents rdoWords As RadioButton
    Friend WithEvents ucrInputTo As ucrInputComboBox
    Friend WithEvents lblTo As Label
    Friend WithEvents nudWidth As NumericUpDown
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblPad As Label
    Friend WithEvents ucrInputPad As ucrInputComboBox
    Friend WithEvents ucrReceiverOrColumn As ucrReceiverSingle
    Friend WithEvents nudFirstWord As NumericUpDown
    Friend WithEvents nudLastWord As NumericUpDown
    Friend WithEvents lblLastWord As Label
    Friend WithEvents lblFirstWord As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents chkLeft As CheckBox
    Friend WithEvents chkOrColumn As CheckBox
End Class
