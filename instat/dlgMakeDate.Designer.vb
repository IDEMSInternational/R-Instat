<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMakeDate
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
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.rdoYearandDayofYear = New System.Windows.Forms.RadioButton()
        Me.rdoYearMonthDay = New System.Windows.Forms.RadioButton()
        Me.grpTwoColumns = New System.Windows.Forms.GroupBox()
        Me.nudCutOffTwo = New System.Windows.Forms.NumericUpDown()
        Me.lblCutOffTwo = New System.Windows.Forms.Label()
        Me.chkTwoDigitYearTwo = New System.Windows.Forms.CheckBox()
        Me.ucrInputComboBoxMonthTwo = New instat.ucrInputComboBox()
        Me.UcrReceiverSingle4 = New instat.ucrReceiverSingle()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDayTwo = New instat.ucrReceiverSingle()
        Me.grpThreeColumns = New System.Windows.Forms.GroupBox()
        Me.lblYearOption = New System.Windows.Forms.Label()
        Me.lblDayOption = New System.Windows.Forms.Label()
        Me.lblMonthOption = New System.Windows.Forms.Label()
        Me.ucrInputDayOption = New instat.ucrInputComboBox()
        Me.ucrInputMonthOption = New instat.ucrInputComboBox()
        Me.ucrInputYearOption = New instat.ucrInputComboBox()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.grpSingleColumn = New System.Windows.Forms.GroupBox()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.chkMore = New System.Windows.Forms.CheckBox()
        Me.ucrInputOrigin = New instat.ucrInputComboBox()
        Me.grpFormatField = New System.Windows.Forms.GroupBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.ucrInputMonth = New instat.ucrInputComboBox()
        Me.ucrInputDay = New instat.ucrInputComboBox()
        Me.ucrInputYear = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.rdoSpecifyFormat = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyOrigin = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultFormat = New System.Windows.Forms.RadioButton()
        Me.ucrReceiverForDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputNewColumnName = New instat.ucrInputComboBox()
        Me.ucrSelectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpTwoColumns.SuspendLayout()
        CType(Me.nudCutOffTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpThreeColumns.SuspendLayout()
        Me.grpSingleColumn.SuspendLayout()
        Me.grpFormatField.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(8, 306)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 7
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.AutoSize = True
        Me.rdoSingleColumn.Location = New System.Drawing.Point(18, 12)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(92, 17)
        Me.rdoSingleColumn.TabIndex = 0
        Me.rdoSingleColumn.TabStop = True
        Me.rdoSingleColumn.Text = "Single Column"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'rdoYearandDayofYear
        '
        Me.rdoYearandDayofYear.AutoSize = True
        Me.rdoYearandDayofYear.Location = New System.Drawing.Point(163, 12)
        Me.rdoYearandDayofYear.Name = "rdoYearandDayofYear"
        Me.rdoYearandDayofYear.Size = New System.Drawing.Size(127, 17)
        Me.rdoYearandDayofYear.TabIndex = 1
        Me.rdoYearandDayofYear.TabStop = True
        Me.rdoYearandDayofYear.Text = "Year and Day of Year"
        Me.rdoYearandDayofYear.UseVisualStyleBackColor = True
        '
        'rdoYearMonthDay
        '
        Me.rdoYearMonthDay.AutoSize = True
        Me.rdoYearMonthDay.Location = New System.Drawing.Point(340, 12)
        Me.rdoYearMonthDay.Name = "rdoYearMonthDay"
        Me.rdoYearMonthDay.Size = New System.Drawing.Size(114, 17)
        Me.rdoYearMonthDay.TabIndex = 2
        Me.rdoYearMonthDay.TabStop = True
        Me.rdoYearMonthDay.Text = "Year - Month - Day"
        Me.rdoYearMonthDay.UseVisualStyleBackColor = True
        '
        'grpTwoColumns
        '
        Me.grpTwoColumns.Controls.Add(Me.nudCutOffTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblCutOffTwo)
        Me.grpTwoColumns.Controls.Add(Me.chkTwoDigitYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrInputComboBoxMonthTwo)
        Me.grpTwoColumns.Controls.Add(Me.UcrReceiverSingle4)
        Me.grpTwoColumns.Controls.Add(Me.lblYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblDayofYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverDayTwo)
        Me.grpTwoColumns.Location = New System.Drawing.Point(253, 35)
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.Size = New System.Drawing.Size(225, 134)
        Me.grpTwoColumns.TabIndex = 4
        Me.grpTwoColumns.TabStop = False
        Me.grpTwoColumns.Text = "Two Columns"
        '
        'nudCutOffTwo
        '
        Me.nudCutOffTwo.Location = New System.Drawing.Point(131, 76)
        Me.nudCutOffTwo.Name = "nudCutOffTwo"
        Me.nudCutOffTwo.Size = New System.Drawing.Size(47, 20)
        Me.nudCutOffTwo.TabIndex = 6
        '
        'lblCutOffTwo
        '
        Me.lblCutOffTwo.Location = New System.Drawing.Point(128, 56)
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        Me.lblCutOffTwo.Size = New System.Drawing.Size(92, 19)
        Me.lblCutOffTwo.TabIndex = 5
        Me.lblCutOffTwo.Text = "Cutoff for 2000 years:"
        '
        'chkTwoDigitYearTwo
        '
        Me.chkTwoDigitYearTwo.AutoSize = True
        Me.chkTwoDigitYearTwo.Location = New System.Drawing.Point(131, 33)
        Me.chkTwoDigitYearTwo.Name = "chkTwoDigitYearTwo"
        Me.chkTwoDigitYearTwo.Size = New System.Drawing.Size(82, 17)
        Me.chkTwoDigitYearTwo.TabIndex = 4
        Me.chkTwoDigitYearTwo.Text = "2-digit years"
        Me.chkTwoDigitYearTwo.UseVisualStyleBackColor = True
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        Me.ucrInputComboBoxMonthTwo.Location = New System.Drawing.Point(115, 104)
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        Me.ucrInputComboBoxMonthTwo.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputComboBoxMonthTwo.TabIndex = 10
        '
        'UcrReceiverSingle4
        '
        Me.UcrReceiverSingle4.Location = New System.Drawing.Point(0, -40)
        Me.UcrReceiverSingle4.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle4.Name = "UcrReceiverSingle4"
        Me.UcrReceiverSingle4.Selector = Nothing
        Me.UcrReceiverSingle4.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle4.TabIndex = 7
        '
        'lblYearTwo
        '
        Me.lblYearTwo.AutoSize = True
        Me.lblYearTwo.Location = New System.Drawing.Point(8, 18)
        Me.lblYearTwo.Name = "lblYearTwo"
        Me.lblYearTwo.Size = New System.Drawing.Size(32, 13)
        Me.lblYearTwo.TabIndex = 0
        Me.lblYearTwo.Text = "Year:"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.Location = New System.Drawing.Point(7, 33)
        Me.ucrReceiverYearTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearTwo.TabIndex = 7
        '
        'lblDayofYear
        '
        Me.lblDayofYear.AutoSize = True
        Me.lblDayofYear.Location = New System.Drawing.Point(8, 62)
        Me.lblDayofYear.Name = "lblDayofYear"
        Me.lblDayofYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayofYear.TabIndex = 2
        Me.lblDayofYear.Text = "Day of Year:"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.Location = New System.Drawing.Point(7, 76)
        Me.ucrReceiverDayTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayTwo.TabIndex = 7
        '
        'grpThreeColumns
        '
        Me.grpThreeColumns.Controls.Add(Me.lblYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblDayOption)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputDayOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputMonthOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblDayofMonth)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.lblYearThree)
        Me.grpThreeColumns.Controls.Add(Me.UcrReceiverSingle2)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverDayThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpThreeColumns.Location = New System.Drawing.Point(253, 35)
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.Size = New System.Drawing.Size(225, 157)
        Me.grpThreeColumns.TabIndex = 5
        Me.grpThreeColumns.TabStop = False
        Me.grpThreeColumns.Text = "Three Columns"
        '
        'lblYearOption
        '
        Me.lblYearOption.AutoSize = True
        Me.lblYearOption.Location = New System.Drawing.Point(130, 18)
        Me.lblYearOption.Name = "lblYearOption"
        Me.lblYearOption.Size = New System.Drawing.Size(66, 13)
        Me.lblYearOption.TabIndex = 14
        Me.lblYearOption.Text = "Year Option:"
        '
        'lblDayOption
        '
        Me.lblDayOption.AutoSize = True
        Me.lblDayOption.Location = New System.Drawing.Point(130, 105)
        Me.lblDayOption.Name = "lblDayOption"
        Me.lblDayOption.Size = New System.Drawing.Size(63, 13)
        Me.lblDayOption.TabIndex = 13
        Me.lblDayOption.Text = "Day Option:"
        '
        'lblMonthOption
        '
        Me.lblMonthOption.AutoSize = True
        Me.lblMonthOption.Location = New System.Drawing.Point(130, 62)
        Me.lblMonthOption.Name = "lblMonthOption"
        Me.lblMonthOption.Size = New System.Drawing.Size(74, 13)
        Me.lblMonthOption.TabIndex = 12
        Me.lblMonthOption.Text = "Month Option:"
        '
        'ucrInputDayOption
        '
        Me.ucrInputDayOption.IsReadOnly = False
        Me.ucrInputDayOption.Location = New System.Drawing.Point(133, 121)
        Me.ucrInputDayOption.Name = "ucrInputDayOption"
        Me.ucrInputDayOption.Size = New System.Drawing.Size(54, 21)
        Me.ucrInputDayOption.TabIndex = 11
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.IsReadOnly = False
        Me.ucrInputMonthOption.Location = New System.Drawing.Point(133, 75)
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        Me.ucrInputMonthOption.Size = New System.Drawing.Size(54, 21)
        Me.ucrInputMonthOption.TabIndex = 10
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.IsReadOnly = False
        Me.ucrInputYearOption.Location = New System.Drawing.Point(133, 32)
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        Me.ucrInputYearOption.Size = New System.Drawing.Size(54, 21)
        Me.ucrInputYearOption.TabIndex = 9
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.Location = New System.Drawing.Point(8, 105)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(74, 13)
        Me.lblDayofMonth.TabIndex = 7
        Me.lblDayofMonth.Text = "Day of Month:"
        '
        'lblMonthThree
        '
        Me.lblMonthThree.AutoSize = True
        Me.lblMonthThree.Location = New System.Drawing.Point(8, 62)
        Me.lblMonthThree.Name = "lblMonthThree"
        Me.lblMonthThree.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthThree.TabIndex = 4
        Me.lblMonthThree.Text = "Month:"
        '
        'lblYearThree
        '
        Me.lblYearThree.AutoSize = True
        Me.lblYearThree.Location = New System.Drawing.Point(8, 18)
        Me.lblYearThree.Name = "lblYearThree"
        Me.lblYearThree.Size = New System.Drawing.Size(32, 13)
        Me.lblYearThree.TabIndex = 0
        Me.lblYearThree.Text = "Year:"
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(0, -40)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.TabIndex = 7
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.Location = New System.Drawing.Point(7, 33)
        Me.ucrReceiverYearThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearThree.TabIndex = 7
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.Location = New System.Drawing.Point(7, 119)
        Me.ucrReceiverDayThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayThree.TabIndex = 7
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.Location = New System.Drawing.Point(7, 76)
        Me.ucrReceiverMonthThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverMonthThree.TabIndex = 7
        '
        'grpSingleColumn
        '
        Me.grpSingleColumn.Controls.Add(Me.ucrInputFormat)
        Me.grpSingleColumn.Controls.Add(Me.chkMore)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputOrigin)
        Me.grpSingleColumn.Controls.Add(Me.grpFormatField)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyFormat)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyOrigin)
        Me.grpSingleColumn.Controls.Add(Me.rdoDefaultFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrReceiverForDate)
        Me.grpSingleColumn.Location = New System.Drawing.Point(253, 35)
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.Size = New System.Drawing.Size(228, 285)
        Me.grpSingleColumn.TabIndex = 6
        Me.grpSingleColumn.TabStop = False
        Me.grpSingleColumn.Text = "Single Column"
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(117, 113)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputFormat.TabIndex = 6
        '
        'chkMore
        '
        Me.chkMore.AutoSize = True
        Me.chkMore.Location = New System.Drawing.Point(162, 35)
        Me.chkMore.Name = "chkMore"
        Me.chkMore.Size = New System.Drawing.Size(50, 17)
        Me.chkMore.TabIndex = 4
        Me.chkMore.Text = "More"
        Me.chkMore.UseVisualStyleBackColor = True
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(117, 86)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputOrigin.TabIndex = 5
        '
        'grpFormatField
        '
        Me.grpFormatField.Controls.Add(Me.lblDay)
        Me.grpFormatField.Controls.Add(Me.lblMonth)
        Me.grpFormatField.Controls.Add(Me.lblYear)
        Me.grpFormatField.Controls.Add(Me.lblSeparator)
        Me.grpFormatField.Controls.Add(Me.ucrInputMonth)
        Me.grpFormatField.Controls.Add(Me.ucrInputDay)
        Me.grpFormatField.Controls.Add(Me.ucrInputYear)
        Me.grpFormatField.Controls.Add(Me.ucrInputSeparator)
        Me.grpFormatField.Location = New System.Drawing.Point(5, 150)
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.Size = New System.Drawing.Size(219, 129)
        Me.grpFormatField.TabIndex = 7
        Me.grpFormatField.TabStop = False
        Me.grpFormatField.Text = "Format Field"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(6, 102)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 6
        Me.lblDay.Text = "Day:"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(6, 76)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month:"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(6, 50)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year:"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(6, 24)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 0
        Me.lblSeparator.Text = "Separator:"
        '
        'ucrInputMonth
        '
        Me.ucrInputMonth.IsReadOnly = False
        Me.ucrInputMonth.Location = New System.Drawing.Point(77, 72)
        Me.ucrInputMonth.Name = "ucrInputMonth"
        Me.ucrInputMonth.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMonth.TabIndex = 5
        '
        'ucrInputDay
        '
        Me.ucrInputDay.IsReadOnly = False
        Me.ucrInputDay.Location = New System.Drawing.Point(77, 98)
        Me.ucrInputDay.Name = "ucrInputDay"
        Me.ucrInputDay.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDay.TabIndex = 7
        '
        'ucrInputYear
        '
        Me.ucrInputYear.IsReadOnly = False
        Me.ucrInputYear.Location = New System.Drawing.Point(77, 46)
        Me.ucrInputYear.Name = "ucrInputYear"
        Me.ucrInputYear.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputYear.TabIndex = 3
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(77, 20)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparator.TabIndex = 1
        '
        'rdoSpecifyFormat
        '
        Me.rdoSpecifyFormat.AutoSize = True
        Me.rdoSpecifyFormat.Location = New System.Drawing.Point(7, 108)
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.Size = New System.Drawing.Size(100, 30)
        Me.rdoSpecifyFormat.TabIndex = 3
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.Text = "Specify Format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Select or Type)"
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoSpecifyOrigin
        '
        Me.rdoSpecifyOrigin.AutoSize = True
        Me.rdoSpecifyOrigin.Location = New System.Drawing.Point(7, 87)
        Me.rdoSpecifyOrigin.Name = "rdoSpecifyOrigin"
        Me.rdoSpecifyOrigin.Size = New System.Drawing.Size(90, 17)
        Me.rdoSpecifyOrigin.TabIndex = 2
        Me.rdoSpecifyOrigin.TabStop = True
        Me.rdoSpecifyOrigin.Text = "Specify Origin"
        Me.rdoSpecifyOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        Me.rdoDefaultFormat.AutoSize = True
        Me.rdoDefaultFormat.Location = New System.Drawing.Point(7, 62)
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.Size = New System.Drawing.Size(94, 17)
        Me.rdoDefaultFormat.TabIndex = 1
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.Text = "Default Format"
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.Location = New System.Drawing.Point(7, 33)
        Me.ucrReceiverForDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForDate.Name = "ucrReceiverForDate"
        Me.ucrReceiverForDate.Selector = Nothing
        Me.ucrReceiverForDate.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverForDate.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 332)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(417, 54)
        Me.ucrBase.TabIndex = 9
        '
        'ucrInputNewColumnName
        '
        Me.ucrInputNewColumnName.IsReadOnly = False
        Me.ucrInputNewColumnName.Location = New System.Drawing.Point(112, 303)
        Me.ucrInputNewColumnName.Name = "ucrInputNewColumnName"
        Me.ucrInputNewColumnName.Size = New System.Drawing.Size(133, 23)
        Me.ucrInputNewColumnName.TabIndex = 8
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        Me.ucrSelectorMakeDate.Location = New System.Drawing.Point(10, 45)
        Me.ucrSelectorMakeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        Me.ucrSelectorMakeDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMakeDate.TabIndex = 3
        '
        'dlgMakeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 389)
        Me.Controls.Add(Me.grpSingleColumn)
        Me.Controls.Add(Me.grpThreeColumns)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.rdoYearMonthDay)
        Me.Controls.Add(Me.rdoYearandDayofYear)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrInputNewColumnName)
        Me.Controls.Add(Me.ucrSelectorMakeDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMakeDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Date"
        Me.grpTwoColumns.ResumeLayout(False)
        Me.grpTwoColumns.PerformLayout()
        CType(Me.nudCutOffTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.grpSingleColumn.ResumeLayout(False)
        Me.grpSingleColumn.PerformLayout()
        Me.grpFormatField.ResumeLayout(False)
        Me.grpFormatField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorMakeDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrInputNewColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents rdoYearandDayofYear As RadioButton
    Friend WithEvents rdoYearMonthDay As RadioButton
    Friend WithEvents ucrReceiverDayTwo As ucrReceiverSingle
    Friend WithEvents grpTwoColumns As GroupBox
    Friend WithEvents UcrReceiverSingle4 As ucrReceiverSingle
    Friend WithEvents ucrReceiverForDate As ucrReceiverSingle
    Friend WithEvents grpThreeColumns As GroupBox
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents ucrInputComboBoxMonthTwo As ucrInputComboBox
    Friend WithEvents grpSingleColumn As GroupBox
    Friend WithEvents rdoSpecifyFormat As RadioButton
    Friend WithEvents rdoSpecifyOrigin As RadioButton
    Friend WithEvents rdoDefaultFormat As RadioButton
    Friend WithEvents grpFormatField As GroupBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents ucrInputMonth As ucrInputComboBox
    Friend WithEvents ucrInputDay As ucrInputComboBox
    Friend WithEvents ucrInputYear As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputOrigin As ucrInputComboBox
    Friend WithEvents chkMore As CheckBox
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents nudCutOffTwo As NumericUpDown
    Friend WithEvents lblCutOffTwo As Label
    Friend WithEvents chkTwoDigitYearTwo As CheckBox
    Friend WithEvents lblYearOption As Label
    Friend WithEvents lblDayOption As Label
    Friend WithEvents lblMonthOption As Label
    Friend WithEvents ucrInputDayOption As ucrInputComboBox
    Friend WithEvents ucrInputMonthOption As ucrInputComboBox
    Friend WithEvents ucrInputYearOption As ucrInputComboBox
End Class