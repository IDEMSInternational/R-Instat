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
        Me.lblTimes2 = New System.Windows.Forms.Label()
        Me.lblRepeatSequence = New System.Windows.Forms.Label()
        Me.lblTimes1 = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.txtRepeatSequence = New System.Windows.Forms.TextBox()
        Me.txtRepeatValues = New System.Windows.Forms.TextBox()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSteps = New System.Windows.Forms.TextBox()
        Me.grpRepeatSingle = New System.Windows.Forms.GroupBox()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.lblRepeated = New System.Windows.Forms.Label()
        Me.txtRepeatTimes = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.grpSequence2 = New System.Windows.Forms.GroupBox()
        Me.lblTimesDate1 = New System.Windows.Forms.Label()
        Me.txtRepeatSequenceDate = New System.Windows.Forms.TextBox()
        Me.lblRepeatSequenceDate = New System.Windows.Forms.Label()
        Me.lblTimesDate = New System.Windows.Forms.Label()
        Me.txtRepeatValuesDate = New System.Windows.Forms.TextBox()
        Me.lblRepeatValuesDate = New System.Windows.Forms.Label()
        Me.cboBy = New System.Windows.Forms.ComboBox()
        Me.dtSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.dtSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.lblFromDate = New System.Windows.Forms.Label()
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
        Me.ucrColName = New instat.ucrNewColumnName()
        Me.ucrSelectDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
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
        Me.grpSequenceType.Location = New System.Drawing.Point(227, 12)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(108, 87)
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
        Me.grpSequence.Controls.Add(Me.lblTimes2)
        Me.grpSequence.Controls.Add(Me.lblRepeatSequence)
        Me.grpSequence.Controls.Add(Me.lblTimes1)
        Me.grpSequence.Controls.Add(Me.lblRepeatValues)
        Me.grpSequence.Controls.Add(Me.txtRepeatSequence)
        Me.grpSequence.Controls.Add(Me.txtRepeatValues)
        Me.grpSequence.Controls.Add(Me.lblSteps)
        Me.grpSequence.Controls.Add(Me.lblTo)
        Me.grpSequence.Controls.Add(Me.lblFrom)
        Me.grpSequence.Controls.Add(Me.txtFrom)
        Me.grpSequence.Controls.Add(Me.txtTo)
        Me.grpSequence.Controls.Add(Me.txtSteps)
        Me.grpSequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequence.Location = New System.Drawing.Point(20, 76)
        Me.grpSequence.Name = "grpSequence"
        Me.grpSequence.Size = New System.Drawing.Size(189, 167)
        Me.grpSequence.TabIndex = 0
        Me.grpSequence.TabStop = False
        Me.grpSequence.Text = "Sequence definition"
        Me.grpSequence.UseCompatibleTextRendering = True
        '
        'lblTimes2
        '
        Me.lblTimes2.AutoSize = True
        Me.lblTimes2.Location = New System.Drawing.Point(144, 134)
        Me.lblTimes2.Name = "lblTimes2"
        Me.lblTimes2.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes2.TabIndex = 22
        Me.lblTimes2.Text = "Time(s)"
        '
        'lblRepeatSequence
        '
        Me.lblRepeatSequence.AutoSize = True
        Me.lblRepeatSequence.Location = New System.Drawing.Point(6, 130)
        Me.lblRepeatSequence.Name = "lblRepeatSequence"
        Me.lblRepeatSequence.Size = New System.Drawing.Size(92, 13)
        Me.lblRepeatSequence.TabIndex = 22
        Me.lblRepeatSequence.Tag = "Repeat_sequence"
        Me.lblRepeatSequence.Text = "Repeat sequence"
        '
        'lblTimes1
        '
        Me.lblTimes1.AutoSize = True
        Me.lblTimes1.Location = New System.Drawing.Point(144, 108)
        Me.lblTimes1.Name = "lblTimes1"
        Me.lblTimes1.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes1.TabIndex = 22
        Me.lblTimes1.Tag = "Times"
        Me.lblTimes1.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.Location = New System.Drawing.Point(6, 108)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(76, 13)
        Me.lblRepeatValues.TabIndex = 22
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat values"
        '
        'txtRepeatSequence
        '
        Me.txtRepeatSequence.Location = New System.Drawing.Point(100, 127)
        Me.txtRepeatSequence.Name = "txtRepeatSequence"
        Me.txtRepeatSequence.Size = New System.Drawing.Size(38, 20)
        Me.txtRepeatSequence.TabIndex = 6
        '
        'txtRepeatValues
        '
        Me.txtRepeatValues.Location = New System.Drawing.Point(100, 101)
        Me.txtRepeatValues.Name = "txtRepeatValues"
        Me.txtRepeatValues.Size = New System.Drawing.Size(38, 20)
        Me.txtRepeatValues.TabIndex = 6
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.Location = New System.Drawing.Point(6, 82)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(56, 13)
        Me.lblSteps.TabIndex = 2
        Me.lblSteps.Text = "In steps of"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(6, 56)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 1
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(6, 30)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From"
        '
        'txtFrom
        '
        Me.txtFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(100, 23)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(38, 20)
        Me.txtFrom.TabIndex = 3
        '
        'txtTo
        '
        Me.txtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(100, 49)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(38, 20)
        Me.txtTo.TabIndex = 4
        '
        'txtSteps
        '
        Me.txtSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSteps.Location = New System.Drawing.Point(100, 75)
        Me.txtSteps.Name = "txtSteps"
        Me.txtSteps.Size = New System.Drawing.Size(38, 20)
        Me.txtSteps.TabIndex = 5
        '
        'grpRepeatSingle
        '
        Me.grpRepeatSingle.Controls.Add(Me.lblTimes)
        Me.grpRepeatSingle.Controls.Add(Me.lblRepeated)
        Me.grpRepeatSingle.Controls.Add(Me.txtRepeatTimes)
        Me.grpRepeatSingle.Controls.Add(Me.txtValue)
        Me.grpRepeatSingle.Controls.Add(Me.lblValue)
        Me.grpRepeatSingle.Location = New System.Drawing.Point(14, 78)
        Me.grpRepeatSingle.Name = "grpRepeatSingle"
        Me.grpRepeatSingle.Size = New System.Drawing.Size(183, 100)
        Me.grpRepeatSingle.TabIndex = 9
        Me.grpRepeatSingle.TabStop = False
        Me.grpRepeatSingle.Tag = "Repeat_single_value"
        Me.grpRepeatSingle.Text = "Repeat Single Value"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(129, 59)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(37, 13)
        Me.lblTimes.TabIndex = 2
        Me.lblTimes.Text = "time(s)"
        '
        'lblRepeated
        '
        Me.lblRepeated.AutoSize = True
        Me.lblRepeated.Location = New System.Drawing.Point(6, 59)
        Me.lblRepeated.Name = "lblRepeated"
        Me.lblRepeated.Size = New System.Drawing.Size(54, 13)
        Me.lblRepeated.TabIndex = 1
        Me.lblRepeated.Tag = "Repeated"
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
        Me.lblValue.Tag = "Value"
        Me.lblValue.Text = "Value"
        '
        'grpSequence2
        '
        Me.grpSequence2.Controls.Add(Me.lblTimesDate1)
        Me.grpSequence2.Controls.Add(Me.txtRepeatSequenceDate)
        Me.grpSequence2.Controls.Add(Me.lblRepeatSequenceDate)
        Me.grpSequence2.Controls.Add(Me.lblTimesDate)
        Me.grpSequence2.Controls.Add(Me.txtRepeatValuesDate)
        Me.grpSequence2.Controls.Add(Me.lblRepeatValuesDate)
        Me.grpSequence2.Controls.Add(Me.cboBy)
        Me.grpSequence2.Controls.Add(Me.dtSelectorA)
        Me.grpSequence2.Controls.Add(Me.dtSelectorB)
        Me.grpSequence2.Controls.Add(Me.lblBy)
        Me.grpSequence2.Controls.Add(Me.lblToDate)
        Me.grpSequence2.Controls.Add(Me.lblFromDate)
        Me.grpSequence2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequence2.Location = New System.Drawing.Point(14, 77)
        Me.grpSequence2.Name = "grpSequence2"
        Me.grpSequence2.Size = New System.Drawing.Size(195, 166)
        Me.grpSequence2.TabIndex = 10
        Me.grpSequence2.TabStop = False
        Me.grpSequence2.Tag = "Sequence_definition"
        Me.grpSequence2.Text = "Sequence definition"
        Me.grpSequence2.UseCompatibleTextRendering = True
        '
        'lblTimesDate1
        '
        Me.lblTimesDate1.AutoSize = True
        Me.lblTimesDate1.Location = New System.Drawing.Point(146, 128)
        Me.lblTimesDate1.Name = "lblTimesDate1"
        Me.lblTimesDate1.Size = New System.Drawing.Size(41, 13)
        Me.lblTimesDate1.TabIndex = 28
        Me.lblTimesDate1.Text = "Time(s)"
        '
        'txtRepeatSequenceDate
        '
        Me.txtRepeatSequenceDate.Location = New System.Drawing.Point(102, 121)
        Me.txtRepeatSequenceDate.Name = "txtRepeatSequenceDate"
        Me.txtRepeatSequenceDate.Size = New System.Drawing.Size(38, 20)
        Me.txtRepeatSequenceDate.TabIndex = 27
        '
        'lblRepeatSequenceDate
        '
        Me.lblRepeatSequenceDate.AutoSize = True
        Me.lblRepeatSequenceDate.Location = New System.Drawing.Point(4, 128)
        Me.lblRepeatSequenceDate.Name = "lblRepeatSequenceDate"
        Me.lblRepeatSequenceDate.Size = New System.Drawing.Size(92, 13)
        Me.lblRepeatSequenceDate.TabIndex = 26
        Me.lblRepeatSequenceDate.Tag = "Repeat_sequence"
        Me.lblRepeatSequenceDate.Text = "Repeat sequence"
        '
        'lblTimesDate
        '
        Me.lblTimesDate.AutoSize = True
        Me.lblTimesDate.Location = New System.Drawing.Point(146, 102)
        Me.lblTimesDate.Name = "lblTimesDate"
        Me.lblTimesDate.Size = New System.Drawing.Size(41, 13)
        Me.lblTimesDate.TabIndex = 25
        Me.lblTimesDate.Tag = "Times"
        Me.lblTimesDate.Text = "Time(s)"
        '
        'txtRepeatValuesDate
        '
        Me.txtRepeatValuesDate.Location = New System.Drawing.Point(102, 93)
        Me.txtRepeatValuesDate.Name = "txtRepeatValuesDate"
        Me.txtRepeatValuesDate.Size = New System.Drawing.Size(38, 20)
        Me.txtRepeatValuesDate.TabIndex = 24
        '
        'lblRepeatValuesDate
        '
        Me.lblRepeatValuesDate.AutoSize = True
        Me.lblRepeatValuesDate.Location = New System.Drawing.Point(6, 102)
        Me.lblRepeatValuesDate.Name = "lblRepeatValuesDate"
        Me.lblRepeatValuesDate.Size = New System.Drawing.Size(76, 13)
        Me.lblRepeatValuesDate.TabIndex = 23
        Me.lblRepeatValuesDate.Tag = "Repeat_values"
        Me.lblRepeatValuesDate.Text = "Repeat values"
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
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(10, 74)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(19, 13)
        Me.lblBy.TabIndex = 2
        Me.lblBy.Tag = "By"
        Me.lblBy.Text = "By"
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDate.Location = New System.Drawing.Point(6, 43)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(20, 13)
        Me.lblToDate.TabIndex = 1
        Me.lblToDate.Text = "To"
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFromDate.Location = New System.Drawing.Point(6, 19)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(30, 13)
        Me.lblFromDate.TabIndex = 0
        Me.lblFromDate.Text = "From"
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
        Me.grpFillFrom.Location = New System.Drawing.Point(227, 114)
        Me.grpFillFrom.Name = "grpFillFrom"
        Me.grpFillFrom.Size = New System.Drawing.Size(189, 93)
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
        'ucrColName
        '
        Me.ucrColName.Location = New System.Drawing.Point(25, 255)
        Me.ucrColName.Name = "ucrColName"
        Me.ucrColName.Size = New System.Drawing.Size(402, 35)
        Me.ucrColName.TabIndex = 16
        '
        'ucrSelectDataFrame
        '
        Me.ucrSelectDataFrame.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectDataFrame.Name = "ucrSelectDataFrame"
        Me.ucrSelectDataFrame.Size = New System.Drawing.Size(150, 63)
        Me.ucrSelectDataFrame.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(21, 296)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 55)
        Me.ucrBase.TabIndex = 5
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 357)
        Me.Controls.Add(Me.grpFillFrom)
        Me.Controls.Add(Me.cmdRefreshPreview)
        Me.Controls.Add(Me.cmdShowHide)
        Me.Controls.Add(Me.grpSequence)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.grpRepeatSingle)
        Me.Controls.Add(Me.lstPreview)
        Me.Controls.Add(Me.ucrColName)
        Me.Controls.Add(Me.ucrSelectDataFrame)
        Me.Controls.Add(Me.grpSequence2)
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
    Friend WithEvents lblTimes As Label
    Friend WithEvents lblRepeated As Label
    Friend WithEvents txtRepeatTimes As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents lblValue As Label
    Friend WithEvents grpSequence2 As GroupBox
    Friend WithEvents dtSelectorA As DateTimePicker
    Friend WithEvents dtSelectorB As DateTimePicker
    Friend WithEvents lblBy As Label
    Friend WithEvents lblToDate As Label
    Friend WithEvents lblFromDate As Label
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
    Friend WithEvents lblTimes2 As Label
    Friend WithEvents lblRepeatSequence As Label
    Friend WithEvents lblTimes1 As Label
    Friend WithEvents lblRepeatValues As Label
    Friend WithEvents txtRepeatSequence As TextBox
    Friend WithEvents txtRepeatValues As TextBox
    Friend WithEvents lblTimesDate1 As Label
    Friend WithEvents txtRepeatSequenceDate As TextBox
    Friend WithEvents lblRepeatSequenceDate As Label
    Friend WithEvents lblTimesDate As Label
    Friend WithEvents txtRepeatValuesDate As TextBox
    Friend WithEvents lblRepeatValuesDate As Label
End Class
