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
        Me.chkIncludingMaximum = New System.Windows.Forms.CheckBox()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.lblRangeMin = New System.Windows.Forms.Label()
        Me.chkIncludeMinimum = New System.Windows.Forms.CheckBox()
        Me.rdoRange = New System.Windows.Forms.RadioButton()
        Me.rdoOldMissing = New System.Windows.Forms.RadioButton()
        Me.rdoOldValue = New System.Windows.Forms.RadioButton()
        Me.grpNew = New System.Windows.Forms.GroupBox()
        Me.rdoNewMissing = New System.Windows.Forms.RadioButton()
        Me.rdoNewValue = New System.Windows.Forms.RadioButton()
        Me.rdoFromAbove = New System.Windows.Forms.RadioButton()
        Me.lblSelectedColumns = New System.Windows.Forms.Label()
        Me.ucrInputNewValue = New instat.ucrInputTextBox()
        Me.ucrInputRangeTo = New instat.ucrInputTextBox()
        Me.ucrInputRangeFrom = New instat.ucrInputTextBox()
        Me.ucrInputOldValue = New instat.ucrInputTextBox()
        Me.ucrReceiverReplace = New instat.ucrReceiverMultiple()
        Me.ucrSelectorReplace = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBaseReplace = New instat.ucrButtons()
        Me.grpOld.SuspendLayout()
        Me.grpNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpOld
        '
        Me.grpOld.Controls.Add(Me.chkIncludingMaximum)
        Me.grpOld.Controls.Add(Me.lblMaximum)
        Me.grpOld.Controls.Add(Me.lblRangeMin)
        Me.grpOld.Controls.Add(Me.chkIncludeMinimum)
        Me.grpOld.Controls.Add(Me.ucrInputRangeTo)
        Me.grpOld.Controls.Add(Me.ucrInputRangeFrom)
        Me.grpOld.Controls.Add(Me.ucrInputOldValue)
        Me.grpOld.Controls.Add(Me.rdoRange)
        Me.grpOld.Controls.Add(Me.rdoOldMissing)
        Me.grpOld.Controls.Add(Me.rdoOldValue)
        Me.grpOld.Location = New System.Drawing.Point(10, 194)
        Me.grpOld.Name = "grpOld"
        Me.grpOld.Size = New System.Drawing.Size(229, 132)
        Me.grpOld.TabIndex = 3
        Me.grpOld.TabStop = False
        Me.grpOld.Tag = "Old"
        Me.grpOld.Text = "Old"
        '
        'chkIncludingMaximum
        '
        Me.chkIncludingMaximum.AutoSize = True
        Me.chkIncludingMaximum.Location = New System.Drawing.Point(155, 103)
        Me.chkIncludingMaximum.Name = "chkIncludingMaximum"
        Me.chkIncludingMaximum.Size = New System.Drawing.Size(69, 17)
        Me.chkIncludingMaximum.TabIndex = 9
        Me.chkIncludingMaximum.Tag = "Including"
        Me.chkIncludingMaximum.Text = "Including"
        Me.chkIncludingMaximum.UseVisualStyleBackColor = True
        '
        'lblMaximum
        '
        Me.lblMaximum.AutoSize = True
        Me.lblMaximum.Location = New System.Drawing.Point(23, 104)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(54, 13)
        Me.lblMaximum.TabIndex = 7
        Me.lblMaximum.Tag = "Maximum"
        Me.lblMaximum.Text = "Maximum:"
        '
        'lblRangeMin
        '
        Me.lblRangeMin.AutoSize = True
        Me.lblRangeMin.Location = New System.Drawing.Point(23, 80)
        Me.lblRangeMin.Name = "lblRangeMin"
        Me.lblRangeMin.Size = New System.Drawing.Size(51, 13)
        Me.lblRangeMin.TabIndex = 4
        Me.lblRangeMin.Tag = "Minimum"
        Me.lblRangeMin.Text = "Minimum:"
        '
        'chkIncludeMinimum
        '
        Me.chkIncludeMinimum.AutoSize = True
        Me.chkIncludeMinimum.Location = New System.Drawing.Point(155, 79)
        Me.chkIncludeMinimum.Name = "chkIncludeMinimum"
        Me.chkIncludeMinimum.Size = New System.Drawing.Size(69, 17)
        Me.chkIncludeMinimum.TabIndex = 6
        Me.chkIncludeMinimum.Tag = "Including"
        Me.chkIncludeMinimum.Text = "Including"
        Me.chkIncludeMinimum.UseVisualStyleBackColor = True
        '
        'rdoRange
        '
        Me.rdoRange.AutoSize = True
        Me.rdoRange.Location = New System.Drawing.Point(5, 60)
        Me.rdoRange.Name = "rdoRange"
        Me.rdoRange.Size = New System.Drawing.Size(57, 17)
        Me.rdoRange.TabIndex = 3
        Me.rdoRange.TabStop = True
        Me.rdoRange.Tag = "Range"
        Me.rdoRange.Text = "Range"
        Me.rdoRange.UseVisualStyleBackColor = True
        '
        'rdoOldMissing
        '
        Me.rdoOldMissing.AutoSize = True
        Me.rdoOldMissing.Location = New System.Drawing.Point(5, 40)
        Me.rdoOldMissing.Name = "rdoOldMissing"
        Me.rdoOldMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoOldMissing.TabIndex = 2
        Me.rdoOldMissing.TabStop = True
        Me.rdoOldMissing.Tag = "Missing"
        Me.rdoOldMissing.Text = "Missing"
        Me.rdoOldMissing.UseVisualStyleBackColor = True
        '
        'rdoOldValue
        '
        Me.rdoOldValue.AutoSize = True
        Me.rdoOldValue.Location = New System.Drawing.Point(5, 20)
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
        Me.grpNew.Location = New System.Drawing.Point(240, 194)
        Me.grpNew.Name = "grpNew"
        Me.grpNew.Size = New System.Drawing.Size(168, 132)
        Me.grpNew.TabIndex = 4
        Me.grpNew.TabStop = False
        Me.grpNew.Tag = "New"
        Me.grpNew.Text = "New"
        '
        'rdoNewMissing
        '
        Me.rdoNewMissing.AutoSize = True
        Me.rdoNewMissing.Location = New System.Drawing.Point(5, 40)
        Me.rdoNewMissing.Name = "rdoNewMissing"
        Me.rdoNewMissing.Size = New System.Drawing.Size(60, 17)
        Me.rdoNewMissing.TabIndex = 2
        Me.rdoNewMissing.TabStop = True
        Me.rdoNewMissing.Tag = "Missing"
        Me.rdoNewMissing.Text = "Missing"
        Me.rdoNewMissing.UseVisualStyleBackColor = True
        '
        'rdoNewValue
        '
        Me.rdoNewValue.AutoSize = True
        Me.rdoNewValue.Location = New System.Drawing.Point(5, 20)
        Me.rdoNewValue.Name = "rdoNewValue"
        Me.rdoNewValue.Size = New System.Drawing.Size(52, 17)
        Me.rdoNewValue.TabIndex = 0
        Me.rdoNewValue.TabStop = True
        Me.rdoNewValue.Tag = "Value"
        Me.rdoNewValue.Text = "Value"
        Me.rdoNewValue.UseVisualStyleBackColor = True
        '
        'rdoFromAbove
        '
        Me.rdoFromAbove.AutoSize = True
        Me.rdoFromAbove.Location = New System.Drawing.Point(5, 60)
        Me.rdoFromAbove.Name = "rdoFromAbove"
        Me.rdoFromAbove.Size = New System.Drawing.Size(82, 17)
        Me.rdoFromAbove.TabIndex = 3
        Me.rdoFromAbove.TabStop = True
        Me.rdoFromAbove.Tag = "From_Above"
        Me.rdoFromAbove.Text = "From Above"
        Me.rdoFromAbove.UseVisualStyleBackColor = True
        '
        'lblSelectedColumns
        '
        Me.lblSelectedColumns.AutoSize = True
        Me.lblSelectedColumns.Location = New System.Drawing.Point(249, 46)
        Me.lblSelectedColumns.Name = "lblSelectedColumns"
        Me.lblSelectedColumns.Size = New System.Drawing.Size(101, 13)
        Me.lblSelectedColumns.TabIndex = 1
        Me.lblSelectedColumns.Tag = "Selected_Column(s)"
        Me.lblSelectedColumns.Text = "Selected Column(s):"
        '
        'ucrInputNewValue
        '
        Me.ucrInputNewValue.IsReadOnly = False
        Me.ucrInputNewValue.Location = New System.Drawing.Point(63, 19)
        Me.ucrInputNewValue.Name = "ucrInputNewValue"
        Me.ucrInputNewValue.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputNewValue.TabIndex = 1
        '
        'ucrInputRangeTo
        '
        Me.ucrInputRangeTo.IsReadOnly = False
        Me.ucrInputRangeTo.Location = New System.Drawing.Point(80, 102)
        Me.ucrInputRangeTo.Name = "ucrInputRangeTo"
        Me.ucrInputRangeTo.Size = New System.Drawing.Size(69, 21)
        Me.ucrInputRangeTo.TabIndex = 8
        '
        'ucrInputRangeFrom
        '
        Me.ucrInputRangeFrom.IsReadOnly = False
        Me.ucrInputRangeFrom.Location = New System.Drawing.Point(80, 76)
        Me.ucrInputRangeFrom.Name = "ucrInputRangeFrom"
        Me.ucrInputRangeFrom.Size = New System.Drawing.Size(69, 21)
        Me.ucrInputRangeFrom.TabIndex = 5
        '
        'ucrInputOldValue
        '
        Me.ucrInputOldValue.IsReadOnly = False
        Me.ucrInputOldValue.Location = New System.Drawing.Point(58, 19)
        Me.ucrInputOldValue.Name = "ucrInputOldValue"
        Me.ucrInputOldValue.Size = New System.Drawing.Size(95, 21)
        Me.ucrInputOldValue.TabIndex = 1
        '
        'ucrReceiverReplace
        '
        Me.ucrReceiverReplace.Location = New System.Drawing.Point(247, 61)
        Me.ucrReceiverReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverReplace.Name = "ucrReceiverReplace"
        Me.ucrReceiverReplace.Selector = Nothing
        Me.ucrReceiverReplace.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverReplace.TabIndex = 2
        '
        'ucrSelectorReplace
        '
        Me.ucrSelectorReplace.bShowHiddenColumns = False
        Me.ucrSelectorReplace.bUseCurrentFilter = True
        Me.ucrSelectorReplace.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorReplace.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorReplace.Name = "ucrSelectorReplace"
        Me.ucrSelectorReplace.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorReplace.TabIndex = 0
        '
        'ucrBaseReplace
        '
        Me.ucrBaseReplace.Location = New System.Drawing.Point(10, 333)
        Me.ucrBaseReplace.Name = "ucrBaseReplace"
        Me.ucrBaseReplace.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseReplace.TabIndex = 5
        '
        'dlgReplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 397)
        Me.Controls.Add(Me.lblSelectedColumns)
        Me.Controls.Add(Me.grpNew)
        Me.Controls.Add(Me.grpOld)
        Me.Controls.Add(Me.ucrReceiverReplace)
        Me.Controls.Add(Me.ucrSelectorReplace)
        Me.Controls.Add(Me.ucrBaseReplace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
    Friend WithEvents ucrInputRangeFrom As ucrInputTextBox
    Friend WithEvents ucrInputOldValue As ucrInputTextBox
    Friend WithEvents rdoRange As RadioButton
    Friend WithEvents rdoOldMissing As RadioButton
    Friend WithEvents rdoOldValue As RadioButton
    Friend WithEvents ucrInputNewValue As ucrInputTextBox
    Friend WithEvents rdoNewMissing As RadioButton
    Friend WithEvents rdoNewValue As RadioButton
    Friend WithEvents rdoFromAbove As RadioButton
    Friend WithEvents lblSelectedColumns As Label
    Friend WithEvents chkIncludeMinimum As CheckBox
    Friend WithEvents chkIncludingMaximum As CheckBox
    Friend WithEvents lblMaximum As Label
    Friend WithEvents lblRangeMin As Label
End Class
