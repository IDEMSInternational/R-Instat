<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgReplace
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
        Me.grpOld = New System.Windows.Forms.GroupBox()
        Me.chkClosedLowerRange = New System.Windows.Forms.CheckBox()
        Me.rdoRange = New System.Windows.Forms.RadioButton()
        Me.rdoOldMissing = New System.Windows.Forms.RadioButton()
        Me.rdoOldValue = New System.Windows.Forms.RadioButton()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.rdoNewMissing = New System.Windows.Forms.RadioButton()
        Me.rdoNewValue = New System.Windows.Forms.RadioButton()
        Me.rdoFromAbove = New System.Windows.Forms.RadioButton()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.chkClosedUpperRange = New System.Windows.Forms.CheckBox()
        Me.ucrInputNewValue = New instat.ucrInputTextBox()
        Me.ucrInputRangeTo = New instat.ucrInputTextBox()
        Me.ucrInputRangeFro = New instat.ucrInputTextBox()
        Me.ucrInputOldValue = New instat.ucrInputTextBox()
        Me.ucrReceiverReplace = New instat.ucrReceiverMultiple()
        Me.ucrSelectorReplace = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseReplace = New instat.ucrButtons()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.grpOld.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOld
        '
        Me.grpOld.Controls.Add(Me.lblTo)
        Me.grpOld.Controls.Add(Me.lblFrom)
        Me.grpOld.Controls.Add(Me.chkClosedLowerRange)
        Me.grpOld.Controls.Add(Me.ucrInputRangeTo)
        Me.grpOld.Controls.Add(Me.ucrInputRangeFro)
        Me.grpOld.Controls.Add(Me.ucrInputOldValue)
        Me.grpOld.Controls.Add(Me.rdoRange)
        Me.grpOld.Controls.Add(Me.rdoOldMissing)
        Me.grpOld.Controls.Add(Me.rdoOldValue)
        Me.grpOld.Location = New System.Drawing.Point(12, 189)
        Me.grpOld.Name = "grpOld"
        Me.grpOld.Size = New System.Drawing.Size(203, 123)
        Me.grpOld.TabIndex = 11
        Me.grpOld.TabStop = False
        Me.grpOld.Tag = "Old"
        Me.grpOld.Text = "Old"
        '
        'chkClosedLowerRange
        '
        Me.chkClosedLowerRange.AutoSize = True
        Me.chkClosedLowerRange.Location = New System.Drawing.Point(140, 76)
        Me.chkClosedLowerRange.Name = "chkClosedLowerRange"
        Me.chkClosedLowerRange.Size = New System.Drawing.Size(58, 17)
        Me.chkClosedLowerRange.TabIndex = 6
        Me.chkClosedLowerRange.Tag = "Closed"
        Me.chkClosedLowerRange.Text = "Closed"
        Me.chkClosedLowerRange.UseVisualStyleBackColor = True
        '
        'rdoRange
        '
        Me.rdoRange.AutoSize = True
        Me.rdoRange.Location = New System.Drawing.Point(6, 56)
        Me.rdoRange.Name = "rdoRange"
        Me.rdoRange.Size = New System.Drawing.Size(57, 17)
        Me.rdoRange.TabIndex = 2
        Me.rdoRange.TabStop = True
        Me.rdoRange.Tag = "Range"
        Me.rdoRange.Text = "Range"
        Me.rdoRange.UseVisualStyleBackColor = True
        '
        'rdoOldMissing
        '
        Me.rdoOldMissing.AutoSize = True
        Me.rdoOldMissing.Location = New System.Drawing.Point(7, 37)
        Me.rdoOldMissing.Name = "rdoOldMissing"
        Me.rdoOldMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoOldMissing.TabIndex = 1
        Me.rdoOldMissing.TabStop = True
        Me.rdoOldMissing.Tag = "Missing"
        Me.rdoOldMissing.Text = "Missing"
        Me.rdoOldMissing.UseVisualStyleBackColor = True
        '
        'rdoOldValue
        '
        Me.rdoOldValue.AutoSize = True
        Me.rdoOldValue.Location = New System.Drawing.Point(7, 17)
        Me.rdoOldValue.Name = "rdoOldValue"
        Me.rdoOldValue.Size = New System.Drawing.Size(52, 17)
        Me.rdoOldValue.TabIndex = 0
        Me.rdoOldValue.TabStop = True
        Me.rdoOldValue.Tag = "Value"
        Me.rdoOldValue.Text = "Value"
        Me.rdoOldValue.UseVisualStyleBackColor = True
        '
        'grpNew
        '
        Me.grpNew.Controls.Add(Me.ucrInputNewValue)
        Me.grpNew.Controls.Add(Me.rdoNewMissing)
        Me.grpNew.Controls.Add(Me.rdoNewValue)
        Me.grpNew.Controls.Add(Me.rdoFromAbove)
        Me.grpNew.Location = New System.Drawing.Point(221, 201)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(174, 94)
        Me.grpNew.TabIndex = 12
        Me.grpNew.TabStop = False
        Me.grpNew.Tag = "New"
        Me.grpNew.Text = "New"
        '
        'rdoNewMissing
        '
        Me.rdoNewMissing.AutoSize = True
        Me.rdoNewMissing.Location = New System.Drawing.Point(13, 43)
        Me.rdoNewMissing.Name = "rdoNewMissing"
        Me.rdoNewMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoNewMissing.TabIndex = 5
        Me.rdoNewMissing.TabStop = True
        Me.rdoNewMissing.Tag = "Missing"
        Me.rdoNewMissing.Text = "Missing"
        Me.rdoNewMissing.UseVisualStyleBackColor = True
        '
        'rdoNewValue
        '
        Me.rdoNewValue.AutoSize = True
        Me.rdoNewValue.Location = New System.Drawing.Point(13, 20)
        Me.rdoNewValue.Name = "rdoNewValue"
        Me.rdoNewValue.Size = New System.Drawing.Size(52, 17)
        Me.rdoNewValue.TabIndex = 4
        Me.rdoNewValue.TabStop = True
        Me.rdoNewValue.Tag = "Value"
        Me.rdoNewValue.Text = "Value"
        Me.rdoNewValue.UseVisualStyleBackColor = True
        '
        'rdoFromAbove
        '
        Me.rdoFromAbove.AutoSize = True
        Me.rdoFromAbove.Location = New System.Drawing.Point(16, 70)
        Me.rdoFromAbove.Name = "rdoFromAbove"
        Me.rdoFromAbove.Size = New System.Drawing.Size(81, 17)
        Me.rdoFromAbove.TabIndex = 3
        Me.rdoFromAbove.TabStop = True
        Me.rdoFromAbove.Tag = "From_above"
        Me.rdoFromAbove.Text = "From above"
        Me.rdoFromAbove.UseVisualStyleBackColor = True
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(283, 41)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(98, 13)
        Me.lblSelectedColumns.TabIndex = 13
        Me.lblSelectedColumns.Tag = "Selected_Column(s)"
        Me.lblSelectedColumns.Text = "Selected Column(s)"
        '
        'chkClosedUpperRange
        '
        Me.chkClosedUpperRange.AutoSize = True
        Me.chkClosedUpperRange.Location = New System.Drawing.Point(152, 291)
        Me.chkClosedUpperRange.Name = "chkClosedUpperRange"
        Me.chkClosedUpperRange.Size = New System.Drawing.Size(58, 17)
        Me.chkClosedUpperRange.TabIndex = 7
        Me.chkClosedUpperRange.Tag = "Closed"
        Me.chkClosedUpperRange.Text = "Closed"
        Me.chkClosedUpperRange.UseVisualStyleBackColor = True
        '
        'ucrInputNewValue
        '
        Me.ucrInputNewValue.IsReadOnly = False
        Me.ucrInputNewValue.Location = New System.Drawing.Point(80, 16)
        Me.ucrInputNewValue.Name = "ucrInputNewValue"
        Me.ucrInputNewValue.Size = New System.Drawing.Size(69, 21)
        Me.ucrInputNewValue.TabIndex = 6
        '
        'ucrInputRangeTo
        '
        Me.ucrInputRangeTo.IsReadOnly = False
        Me.ucrInputRangeTo.Location = New System.Drawing.Point(58, 98)
        Me.ucrInputRangeTo.Name = "ucrInputRangeTo"
        Me.ucrInputRangeTo.Size = New System.Drawing.Size(69, 21)
        Me.ucrInputRangeTo.TabIndex = 5
        '
        'ucrInputRangeFro
        '
        Me.ucrInputRangeFro.IsReadOnly = False
        Me.ucrInputRangeFro.Location = New System.Drawing.Point(58, 73)
        Me.ucrInputRangeFro.Name = "ucrInputRangeFro"
        Me.ucrInputRangeFro.Size = New System.Drawing.Size(69, 21)
        Me.ucrInputRangeFro.TabIndex = 4
        '
        'ucrInputOldValue
        '
        Me.ucrInputOldValue.IsReadOnly = False
        Me.ucrInputOldValue.Location = New System.Drawing.Point(73, 14)
        Me.ucrInputOldValue.Name = "ucrInputOldValue"
        Me.ucrInputOldValue.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputOldValue.TabIndex = 3
        '
        'ucrReceiverReplace
        '
        Me.ucrReceiverReplace.Location = New System.Drawing.Point(275, 61)
        Me.ucrReceiverReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReplace.Name = "ucrReceiverReplace"
        Me.ucrReceiverReplace.Selector = Nothing
        Me.ucrReceiverReplace.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverReplace.TabIndex = 10
        '
        'ucrSelectorReplace
        '
        Me.ucrSelectorReplace.bShowHiddenColumns = False
        Me.ucrSelectorReplace.Location = New System.Drawing.Point(12, 6)
        Me.ucrSelectorReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorReplace.Name = "ucrSelectorReplace"
        Me.ucrSelectorReplace.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorReplace.TabIndex = 9
        '
        'ucrBaseReplace
        '
        Me.ucrBaseReplace.Location = New System.Drawing.Point(4, 318)
        Me.ucrBaseReplace.Name = "ucrBaseReplace"
        Me.ucrBaseReplace.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseReplace.TabIndex = 8
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(21, 78)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 7
        Me.lblFrom.Tag = "From"
        Me.lblFrom.Text = "From"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(28, 101)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 8
        Me.lblTo.Tag = "To"
        Me.lblTo.Text = "To"
        '
        'dlgReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 376)
        Me.Controls.Add(Me.chkClosedUpperRange)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpOld)
        Me.Controls.Add(Me.ucrReceiverReplace)
        Me.Controls.Add(Me.ucrSelectorReplace)
        Me.Controls.Add(Me.ucrBaseReplace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgReplace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Replace"
        Me.Text = "Replace"
        Me.grpOld.ResumeLayout(False)
        Me.grpOld.PerformLayout()
        Me.grpNew.ResumeLayout(False)
        Me.grpNew.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBaseReplace As ucrButtons
    Friend WithEvents ucrSelectorReplace As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverReplace As ucrReceiverMultiple
    Friend WithEvents grpOld As GroupBox
    Friend WithEvents grpNew As GroupBox
    Friend WithEvents ucrInputRangeTo As ucrInputTextBox
    Friend WithEvents ucrInputRangeFro As ucrInputTextBox
    Friend WithEvents ucrInputOldValue As ucrInputTextBox
    Friend WithEvents rdoRange As RadioButton
    Friend WithEvents rdoOldMissing As RadioButton
    Friend WithEvents rdoOldValue As RadioButton
    Friend WithEvents ucrInputNewValue As ucrInputTextBox
    Friend WithEvents rdoNewMissing As RadioButton
    Friend WithEvents rdoNewValue As RadioButton
    Friend WithEvents rdoFromAbove As RadioButton
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents chkClosedLowerRange As CheckBox
    Friend WithEvents chkClosedUpperRange As CheckBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
End Class
