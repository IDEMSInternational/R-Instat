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
        Me.rdDates = New System.Windows.Forms.RadioButton()
        Me.rdSIngleValue = New System.Windows.Forms.RadioButton()
        Me.rdSequence = New System.Windows.Forms.RadioButton()
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
        Me.lblNewColName = New System.Windows.Forms.Label()
        Me.txtNewColName = New System.Windows.Forms.TextBox()
        Me.grpFindFrom = New System.Windows.Forms.GroupBox()
        Me.rdoTop = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoAppend = New System.Windows.Forms.RadioButton()
        Me.lblInto = New System.Windows.Forms.Label()
        Me.cboInto = New System.Windows.Forms.ComboBox()
        Me.UcrDataFrame1 = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.txtOvertype = New System.Windows.Forms.TextBox()
        Me.lblOvertype = New System.Windows.Forms.Label()
        Me.grpSequenceType.SuspendLayout()
        Me.grpSequence.SuspendLayout()
        Me.grpRepeatSingle.SuspendLayout()
        Me.grpSequence2.SuspendLayout()
        Me.grpFindFrom.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdDates)
        Me.grpSequenceType.Controls.Add(Me.rdSequence)
        Me.grpSequenceType.Controls.Add(Me.rdSIngleValue)
        Me.grpSequenceType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSequenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceType.Location = New System.Drawing.Point(21, 20)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(278, 30)
        Me.grpSequenceType.TabIndex = 0
        Me.grpSequenceType.TabStop = False
        '
        'rdDates
        '
        Me.rdDates.AutoSize = True
        Me.rdDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDates.Location = New System.Drawing.Point(192, 12)
        Me.rdDates.Name = "rdDates"
        Me.rdDates.Size = New System.Drawing.Size(59, 18)
        Me.rdDates.TabIndex = 2
        Me.rdDates.Text = "Dates"
        Me.rdDates.UseVisualStyleBackColor = True
        '
        'rdSIngleValue
        '
        Me.rdSIngleValue.AutoSize = True
        Me.rdSIngleValue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdSIngleValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSIngleValue.Location = New System.Drawing.Point(97, 12)
        Me.rdSIngleValue.Name = "rdSIngleValue"
        Me.rdSIngleValue.Size = New System.Drawing.Size(89, 18)
        Me.rdSIngleValue.TabIndex = 1
        Me.rdSIngleValue.Text = "Single value"
        Me.rdSIngleValue.UseVisualStyleBackColor = True
        '
        'rdSequence
        '
        Me.rdSequence.AutoSize = True
        Me.rdSequence.Checked = True
        Me.rdSequence.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSequence.Location = New System.Drawing.Point(6, 12)
        Me.rdSequence.Name = "rdSequence"
        Me.rdSequence.Size = New System.Drawing.Size(85, 18)
        Me.rdSequence.TabIndex = 0
        Me.rdSequence.TabStop = True
        Me.rdSequence.Text = "Sequences"
        Me.rdSequence.UseVisualStyleBackColor = True
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
        Me.grpSequence.Location = New System.Drawing.Point(12, 82)
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
        Me.grpRepeatSingle.Location = New System.Drawing.Point(10, 99)
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
        Me.grpSequence2.Location = New System.Drawing.Point(9, 97)
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
        'lblNewColName
        '
        Me.lblNewColName.AutoSize = True
        Me.lblNewColName.Location = New System.Drawing.Point(12, 233)
        Me.lblNewColName.Name = "lblNewColName"
        Me.lblNewColName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColName.TabIndex = 13
        Me.lblNewColName.Text = "New Column Name:"
        '
        'txtNewColName
        '
        Me.txtNewColName.Location = New System.Drawing.Point(119, 230)
        Me.txtNewColName.Name = "txtNewColName"
        Me.txtNewColName.Size = New System.Drawing.Size(234, 20)
        Me.txtNewColName.TabIndex = 14
        '
        'grpFindFrom
        '
        Me.grpFindFrom.Controls.Add(Me.lblOvertype)
        Me.grpFindFrom.Controls.Add(Me.txtOvertype)
        Me.grpFindFrom.Controls.Add(Me.rdoAppend)
        Me.grpFindFrom.Controls.Add(Me.rdoRow)
        Me.grpFindFrom.Controls.Add(Me.rdoTop)
        Me.grpFindFrom.Location = New System.Drawing.Point(198, 124)
        Me.grpFindFrom.Name = "grpFindFrom"
        Me.grpFindFrom.Size = New System.Drawing.Size(183, 100)
        Me.grpFindFrom.TabIndex = 16
        Me.grpFindFrom.TabStop = False
        Me.grpFindFrom.Tag = "Find_from"
        Me.grpFindFrom.Text = "Find from"
        '
        'rdoTop
        '
        Me.rdoTop.AutoSize = True
        Me.rdoTop.Location = New System.Drawing.Point(16, 14)
        Me.rdoTop.Name = "rdoTop"
        Me.rdoTop.Size = New System.Drawing.Size(44, 17)
        Me.rdoTop.TabIndex = 0
        Me.rdoTop.TabStop = True
        Me.rdoTop.Tag = "Top"
        Me.rdoTop.Text = "Top"
        Me.rdoTop.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        Me.rdoRow.AutoSize = True
        Me.rdoRow.Location = New System.Drawing.Point(16, 37)
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.Size = New System.Drawing.Size(47, 17)
        Me.rdoRow.TabIndex = 0
        Me.rdoRow.TabStop = True
        Me.rdoRow.Tag = "Row"
        Me.rdoRow.Text = "Row"
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoAppend
        '
        Me.rdoAppend.AutoSize = True
        Me.rdoAppend.Location = New System.Drawing.Point(16, 62)
        Me.rdoAppend.Name = "rdoAppend"
        Me.rdoAppend.Size = New System.Drawing.Size(62, 17)
        Me.rdoAppend.TabIndex = 0
        Me.rdoAppend.TabStop = True
        Me.rdoAppend.Tag = "Append"
        Me.rdoAppend.Text = "Append"
        Me.rdoAppend.UseVisualStyleBackColor = True
        '
        'lblInto
        '
        Me.lblInto.AutoSize = True
        Me.lblInto.Location = New System.Drawing.Point(307, 9)
        Me.lblInto.Name = "lblInto"
        Me.lblInto.Size = New System.Drawing.Size(25, 13)
        Me.lblInto.TabIndex = 17
        Me.lblInto.Tag = "Into"
        Me.lblInto.Text = "Into"
        '
        'cboInto
        '
        Me.cboInto.FormattingEnabled = True
        Me.cboInto.Location = New System.Drawing.Point(310, 29)
        Me.cboInto.Name = "cboInto"
        Me.cboInto.Size = New System.Drawing.Size(43, 21)
        Me.cboInto.TabIndex = 18
        '
        'UcrDataFrame1
        '
        Me.UcrDataFrame1.Location = New System.Drawing.Point(198, 63)
        Me.UcrDataFrame1.Name = "UcrDataFrame1"
        Me.UcrDataFrame1.Size = New System.Drawing.Size(150, 55)
        Me.UcrDataFrame1.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 266)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 32)
        Me.ucrBase.TabIndex = 5
        '
        'txtOvertype
        '
        Me.txtOvertype.Location = New System.Drawing.Point(69, 34)
        Me.txtOvertype.Name = "txtOvertype"
        Me.txtOvertype.Size = New System.Drawing.Size(31, 20)
        Me.txtOvertype.TabIndex = 1
        '
        'lblOvertype
        '
        Me.lblOvertype.AutoSize = True
        Me.lblOvertype.Location = New System.Drawing.Point(109, 41)
        Me.lblOvertype.Name = "lblOvertype"
        Me.lblOvertype.Size = New System.Drawing.Size(56, 13)
        Me.lblOvertype.TabIndex = 2
        Me.lblOvertype.Tag = "Overtype"
        Me.lblOvertype.Text = "(Overtype)"
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 305)
        Me.Controls.Add(Me.cboInto)
        Me.Controls.Add(Me.lblInto)
        Me.Controls.Add(Me.grpFindFrom)
        Me.Controls.Add(Me.UcrDataFrame1)
        Me.Controls.Add(Me.txtNewColName)
        Me.Controls.Add(Me.lblNewColName)
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
        Me.grpFindFrom.ResumeLayout(False)
        Me.grpFindFrom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdSequence As RadioButton
    Friend WithEvents grpSequence As GroupBox
    Friend WithEvents rdSIngleValue As RadioButton
    Friend WithEvents rdDates As RadioButton
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
    Friend WithEvents lblNewColName As Label
    Friend WithEvents txtNewColName As TextBox
    Friend WithEvents UcrDataFrame1 As ucrDataFrame
    Friend WithEvents grpFindFrom As GroupBox
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoTop As RadioButton
    Friend WithEvents rdoAppend As RadioButton
    Friend WithEvents lblInto As Label
    Friend WithEvents cboInto As ComboBox
    Friend WithEvents lblOvertype As Label
    Friend WithEvents txtOvertype As TextBox
End Class
