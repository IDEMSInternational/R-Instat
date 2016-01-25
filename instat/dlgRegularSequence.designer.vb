<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRegularSequence
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
        Me.grpSequenceType = New System.Windows.Forms.GroupBox()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.rdoSingleValue = New System.Windows.Forms.RadioButton()
        Me.rdoSequence = New System.Windows.Forms.RadioButton()
        Me.grpSequence = New System.Windows.Forms.GroupBox()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSteps = New System.Windows.Forms.TextBox()
        Me.grpRepeatSingle = New System.Windows.Forms.GroupBox()
        Me.lblTimes3 = New System.Windows.Forms.Label()
        Me.lblRepeated = New System.Windows.Forms.Label()
        Me.txtRepeatTimes = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.grpSequence2 = New System.Windows.Forms.GroupBox()
        Me.cboBy = New System.Windows.Forms.ComboBox()
        Me.dtSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.dtSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ucrColName = New instat.ucrNewColumnName()
        Me.ucrSelectDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.lstPreview = New System.Windows.Forms.ListBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.cmdShowHide = New System.Windows.Forms.Button()
        Me.cmdRefreshPreview = New System.Windows.Forms.Button()
        Me.grpFillFrom = New System.Windows.Forms.GroupBox()
        Me.lblOverwrite = New System.Windows.Forms.Label()
        Me.txtOverwrite = New System.Windows.Forms.TextBox()
        Me.rdoAppend = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.grpSequenceType.SuspendLayout()
        Me.grpSequence.SuspendLayout()
        Me.grpRepeatSingle.SuspendLayout()
        Me.grpSequence2.SuspendLayout()
        Me.grpFillFrom.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.rdoSingleValue)
        Me.grpSequenceType.Controls.Add(Me.rdoSequence)
        Me.grpSequenceType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSequenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceType.Location = New System.Drawing.Point(228, 12)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(107, 76)
        Me.grpSequenceType.TabIndex = 0
        Me.grpSequenceType.TabStop = False
        '
        'rdoDates
        '
        Me.rdoDates.AutoSize = True
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDates.Location = New System.Drawing.Point(0, 58)
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Size = New System.Drawing.Size(59, 18)
        Me.rdoDates.TabIndex = 2
        Me.rdoDates.Text = "Dates"
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'rdoSingleValue
        '
        Me.rdoSingleValue.AutoSize = True
        Me.rdoSingleValue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoSingleValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSingleValue.Location = New System.Drawing.Point(0, 34)
        Me.rdoSingleValue.Name = "rdoSingleValue"
        Me.rdoSingleValue.Size = New System.Drawing.Size(89, 18)
        Me.rdoSingleValue.TabIndex = 1
        Me.rdoSingleValue.Text = "Single value"
        Me.rdoSingleValue.UseVisualStyleBackColor = True
        '
        'rdoSequence
        '
        Me.rdoSequence.AutoSize = True
        Me.rdoSequence.Checked = True
        Me.rdoSequence.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSequence.Location = New System.Drawing.Point(0, 10)
        Me.rdoSequence.Name = "rdoSequence"
        Me.rdoSequence.Size = New System.Drawing.Size(85, 18)
        Me.rdoSequence.TabIndex = 0
        Me.rdoSequence.TabStop = True
        Me.rdoSequence.Text = "Sequences"
        Me.rdoSequence.UseVisualStyleBackColor = True
        '
        'grpSequence
        '
        Me.grpSequence.Controls.Add(Me.lblSteps)
        Me.grpSequence.Controls.Add(Me.lblTo)
        Me.grpSequence.Controls.Add(Me.lblFrom)
        Me.grpSequence.Controls.Add(Me.txtFrom)
        Me.grpSequence.Controls.Add(Me.txtTo)
        Me.grpSequence.Controls.Add(Me.txtSteps)
        Me.grpSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequence.Location = New System.Drawing.Point(14, 89)
        Me.grpSequence.Name = "grpSequence"
        Me.grpSequence.Size = New System.Drawing.Size(180, 96)
        Me.grpSequence.TabIndex = 0
        Me.grpSequence.TabStop = False
        Me.grpSequence.Text = "Sequence Definition"
        Me.grpSequence.UseCompatibleTextRendering = True
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.Location = New System.Drawing.Point(6, 71)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(56, 13)
        Me.lblSteps.TabIndex = 2
        Me.lblSteps.Text = "In steps of"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(6, 43)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(6, 19)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(78, 19)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(60, 20)
        Me.txtFrom.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(78, 43)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(60, 20)
        Me.txtTo.TabIndex = 4
        '
        'txtSteps
        '
        Me.txtSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSteps.Location = New System.Drawing.Point(78, 67)
        Me.txtSteps.Name = "txtSteps"
        Me.txtSteps.Size = New System.Drawing.Size(60, 20)
        Me.txtSteps.TabIndex = 5
        '
        'grpRepeatSingle
        '
        Me.grpRepeatSingle.Controls.Add(Me.lblTimes3)
        Me.grpRepeatSingle.Controls.Add(Me.lblRepeated)
        Me.grpRepeatSingle.Controls.Add(Me.txtRepeatTimes)
        Me.grpRepeatSingle.Controls.Add(Me.txtValue)
        Me.grpRepeatSingle.Controls.Add(Me.lblValue)
        Me.grpRepeatSingle.Location = New System.Drawing.Point(12, 106)
        Me.grpRepeatSingle.Name = "grpRepeatSingle"
        Me.grpRepeatSingle.Size = New System.Drawing.Size(179, 100)
        Me.grpRepeatSingle.TabIndex = 9
        Me.grpRepeatSingle.TabStop = False
        Me.grpRepeatSingle.Text = "Repeat Single Value"
        '
        'lblTimes3
        '
        Me.lblTimes3.AutoSize = True
        Me.lblTimes3.Location = New System.Drawing.Point(130, 59)
        Me.lblTimes3.Name = "lblTimes3"
        Me.lblTimes3.Size = New System.Drawing.Size(37, 13)
        Me.lblTimes3.TabIndex = 2
        Me.lblTimes3.Text = "time(s)"
        '
        'lblRepeated
        '
        Me.lblRepeated.AutoSize = True
        Me.lblRepeated.Location = New System.Drawing.Point(6, 59)
        Me.lblRepeated.Name = "lblRepeated"
        Me.lblRepeated.Size = New System.Drawing.Size(54, 13)
        Me.lblRepeated.TabIndex = 1
        Me.lblRepeated.Text = "Repeated"
        '
        'txtRepeatTimes
        '
        Me.txtRepeatTimes.Location = New System.Drawing.Point(66, 52)
        Me.txtRepeatTimes.Name = "txtRepeatTimes"
        Me.txtRepeatTimes.Size = New System.Drawing.Size(58, 20)
        Me.txtRepeatTimes.TabIndex = 4
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(66, 26)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(58, 20)
        Me.txtValue.TabIndex = 3
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(5, 33)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Value"
        '
        'grpSequence2
        '
        Me.grpSequence2.Controls.Add(Me.cboBy)
        Me.grpSequence2.Controls.Add(Me.dtSelectorA)
        Me.grpSequence2.Controls.Add(Me.dtSelectorB)
        Me.grpSequence2.Controls.Add(Me.Label2)
        Me.grpSequence2.Controls.Add(Me.Label4)
        Me.grpSequence2.Controls.Add(Me.Label5)
        Me.grpSequence2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequence2.Location = New System.Drawing.Point(11, 104)
        Me.grpSequence2.Name = "grpSequence2"
        Me.grpSequence2.Size = New System.Drawing.Size(180, 95)
        Me.grpSequence2.TabIndex = 10
        Me.grpSequence2.TabStop = False
        Me.grpSequence2.Text = "Sequence Definition"
        Me.grpSequence2.UseCompatibleTextRendering = True
        '
        'cboBy
        '
        Me.cboBy.FormattingEnabled = True
        Me.cboBy.Items.AddRange(New Object() {"day", "week", "month", "quarter", "year"})
        Me.cboBy.Location = New System.Drawing.Point(78, 68)
        Me.cboBy.Name = "cboBy"
        Me.cboBy.Size = New System.Drawing.Size(62, 21)
        Me.cboBy.TabIndex = 12
        '
        'dtSelectorA
        '
        Me.dtSelectorA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSelectorA.Location = New System.Drawing.Point(78, 20)
        Me.dtSelectorA.Name = "dtSelectorA"
        Me.dtSelectorA.Size = New System.Drawing.Size(84, 20)
        Me.dtSelectorA.TabIndex = 10
        '
        'dtSelectorB
        '
        Me.dtSelectorB.CustomFormat = "dd/mm/yyyy"
        Me.dtSelectorB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSelectorB.Location = New System.Drawing.Point(78, 46)
        Me.dtSelectorB.Name = "dtSelectorB"
        Me.dtSelectorB.Size = New System.Drawing.Size(84, 20)
        Me.dtSelectorB.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "From"
        '
        'ucrColName
        '
        Me.ucrColName.Location = New System.Drawing.Point(11, 212)
        Me.ucrColName.Name = "ucrColName"
        Me.ucrColName.Size = New System.Drawing.Size(402, 35)
        Me.ucrColName.TabIndex = 16
        '
        'ucrSelectDataFrame
        '
        Me.ucrSelectDataFrame.Location = New System.Drawing.Point(14, 12)
        Me.ucrSelectDataFrame.Name = "ucrSelectDataFrame"
        Me.ucrSelectDataFrame.Size = New System.Drawing.Size(150, 63)
        Me.ucrSelectDataFrame.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 253)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 55)
        Me.ucrBase.TabIndex = 5
        '
        'lstPreview
        '
        Me.lstPreview.FormattingEnabled = True
        Me.lstPreview.Location = New System.Drawing.Point(453, 83)
        Me.lstPreview.Name = "lstPreview"
        Me.lstPreview.Size = New System.Drawing.Size(120, 225)
        Me.lstPreview.TabIndex = 17
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(512, 12)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(58, 20)
        Me.txtLength.TabIndex = 18
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(450, 61)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(45, 13)
        Me.lblPreview.TabIndex = 19
        Me.lblPreview.Tag = "Preview"
        Me.lblPreview.Text = "Preview"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(450, 19)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 19
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length"
        '
        'cmdShowHide
        '
        Me.cmdShowHide.Location = New System.Drawing.Point(341, 12)
        Me.cmdShowHide.Name = "cmdShowHide"
        Me.cmdShowHide.Size = New System.Drawing.Size(75, 36)
        Me.cmdShowHide.TabIndex = 20
        Me.cmdShowHide.Tag = "Show/Hide_preview"
        Me.cmdShowHide.Text = "Show/Hide Preview"
        Me.cmdShowHide.UseVisualStyleBackColor = True
        '
        'cmdRefreshPreview
        '
        Me.cmdRefreshPreview.Location = New System.Drawing.Point(341, 61)
        Me.cmdRefreshPreview.Name = "cmdRefreshPreview"
        Me.cmdRefreshPreview.Size = New System.Drawing.Size(75, 47)
        Me.cmdRefreshPreview.TabIndex = 20
        Me.cmdRefreshPreview.Tag = "Refresh_Preview"
        Me.cmdRefreshPreview.Text = "Refresh Preview"
        Me.cmdRefreshPreview.UseVisualStyleBackColor = True
        '
        'grpFillFrom
        '
        Me.grpFillFrom.Controls.Add(Me.lblOverwrite)
        Me.grpFillFrom.Controls.Add(Me.txtOverwrite)
        Me.grpFillFrom.Controls.Add(Me.rdoAppend)
        Me.grpFillFrom.Controls.Add(Me.rdoRow)
        Me.grpFillFrom.Controls.Add(Me.rdoTop)
        Me.grpFillFrom.Location = New System.Drawing.Point(228, 114)
        Me.grpFillFrom.Name = "grpFillFrom"
        Me.grpFillFrom.Size = New System.Drawing.Size(188, 100)
        Me.grpFillFrom.TabIndex = 21
        Me.grpFillFrom.TabStop = False
        Me.grpFillFrom.Tag = "Fill_from"
        Me.grpFillFrom.Text = "Fill from"
        '
        'lblOverwrite
        '
        Me.lblOverwrite.AutoSize = True
        Me.lblOverwrite.Location = New System.Drawing.Point(113, 51)
        Me.lblOverwrite.Name = "lblOverwrite"
        Me.lblOverwrite.Size = New System.Drawing.Size(58, 13)
        Me.lblOverwrite.TabIndex = 2
        Me.lblOverwrite.Tag = "Overwrite"
        Me.lblOverwrite.Text = "(Overwrite)"
        '
        'txtOverwrite
        '
        Me.txtOverwrite.Location = New System.Drawing.Point(53, 44)
        Me.txtOverwrite.Name = "txtOverwrite"
        Me.txtOverwrite.Size = New System.Drawing.Size(54, 20)
        Me.txtOverwrite.TabIndex = 1
        '
        'rdoAppend
        '
        Me.rdoAppend.AutoSize = True
        Me.rdoAppend.Location = New System.Drawing.Point(0, 65)
        Me.rdoAppend.Name = "rdoAppend"
        Me.rdoAppend.Size = New System.Drawing.Size(62, 17)
        Me.rdoAppend.TabIndex = 0
        Me.rdoAppend.TabStop = True
        Me.rdoAppend.Tag = "Append"
        Me.rdoAppend.Text = "Append"
        Me.rdoAppend.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(0, 42)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(47, 17)
        Me.rdoRow.TabIndex = 0
        Me.rdoRow.TabStop = True
        Me.rdoRow.Tag = "Row"
        Me.rdoRow.Text = "Row"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(0, 19)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 321)
        Me.Controls.Add(Me.grpFillFrom)
        Me.Controls.Add(Me.cmdRefreshPreview)
        Me.Controls.Add(Me.cmdShowHide)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lstPreview)
        Me.Controls.Add(Me.ucrColName)
        Me.Controls.Add(Me.ucrSelectDataFrame)
        Me.Controls.Add(Me.grpRepeatSingle)
        Me.Controls.Add(Me.grpSequence2)
        Me.Controls.Add(Me.grpSequence)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpSequenceType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegularSequence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entry of regular sequence"
        Me.grpSequenceType.ResumeLayout(False)
        Me.grpSequenceType.PerformLayout()
        Me.grpSequence.ResumeLayout(False)
        Me.grpSequence.PerformLayout()
        Me.grpRepeatSingle.ResumeLayout(False)
        Me.grpRepeatSingle.PerformLayout()
        Me.grpSequence2.ResumeLayout(False)
        Me.grpSequence2.PerformLayout()
        Me.grpFillFrom.ResumeLayout(False)
        Me.grpFillFrom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdoSequence As RadioButton
    Friend WithEvents grpSequence As GroupBox
    Friend WithEvents rdoSingleValue As RadioButton
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents lblSteps As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtSteps As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpRepeatSingle As GroupBox
    Friend WithEvents lblTimes3 As Label
    Friend WithEvents lblRepeated As Label
    Friend WithEvents txtRepeatTimes As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents lblValue As Label
    Friend WithEvents grpSequence2 As GroupBox
    Friend WithEvents dtSelectorA As DateTimePicker
    Friend WithEvents dtSelectorB As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBy As ComboBox
    Friend WithEvents ucrSelectDataFrame As ucrDataFrame
    Friend WithEvents ucrColName As ucrNewColumnName
    Friend WithEvents lstPreview As ListBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents cmdShowHide As Button
    Friend WithEvents cmdRefreshPreview As Button
    Friend WithEvents grpFillFrom As GroupBox
    Friend WithEvents lblOverwrite As Label
    Friend WithEvents txtOverwrite As TextBox
    Friend WithEvents rdoAppend As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoTop As RadioButton
End Class
