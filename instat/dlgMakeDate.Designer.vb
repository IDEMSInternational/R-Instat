﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.grpTwoColumns = New System.Windows.Forms.GroupBox()
        Me.ucrChkTwoDigitYear = New instat.ucrCheck()
        Me.ucrNudCutoff = New instat.ucrNud()
        Me.lblCutOffTwo = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxMonthTwo = New instat.ucrInputComboBox()
        Me.lblYearTwo = New System.Windows.Forms.Label()
        Me.ucrReceiverYearTwo = New instat.ucrReceiverSingle()
        Me.lblDayofYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDayTwo = New instat.ucrReceiverSingle()
        Me.grpSingleColumn = New System.Windows.Forms.GroupBox()
        Me.rdoSpecifyFormat = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyOrigin = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultFormat = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrChkMore = New instat.ucrCheck()
        Me.ucrReceiverForDate = New instat.ucrReceiverSingle()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrInputOrigin = New instat.ucrInputComboBox()
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
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.rdoThreeColumns = New System.Windows.Forms.RadioButton()
        Me.rdoTwoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.ucrSaveDate = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlDate = New instat.UcrPanel()
        Me.grpFormatField = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox4 = New instat.ucrInputComboBox()
        Me.grpTwoColumns.SuspendLayout()
        Me.grpSingleColumn.SuspendLayout()
        Me.grpThreeColumns.SuspendLayout()
        Me.grpFormatField.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTwoColumns
        '
        Me.grpTwoColumns.Controls.Add(Me.ucrChkTwoDigitYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrNudCutoff)
        Me.grpTwoColumns.Controls.Add(Me.lblCutOffTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrInputComboBoxMonthTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverYearTwo)
        Me.grpTwoColumns.Controls.Add(Me.lblDayofYear)
        Me.grpTwoColumns.Controls.Add(Me.ucrReceiverDayTwo)
        Me.grpTwoColumns.Location = New System.Drawing.Point(258, 51)
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.Size = New System.Drawing.Size(225, 139)
        Me.grpTwoColumns.TabIndex = 4
        Me.grpTwoColumns.TabStop = False
        Me.grpTwoColumns.Text = "Two Columns"
        '
        'ucrChkTwoDigitYear
        '
        Me.ucrChkTwoDigitYear.Checked = False
        Me.ucrChkTwoDigitYear.Location = New System.Drawing.Point(130, 34)
        Me.ucrChkTwoDigitYear.Name = "ucrChkTwoDigitYear"
        Me.ucrChkTwoDigitYear.Size = New System.Drawing.Size(89, 20)
        Me.ucrChkTwoDigitYear.TabIndex = 47
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoff.Location = New System.Drawing.Point(146, 77)
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCutoff.TabIndex = 46
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCutOffTwo
        '
        Me.lblCutOffTwo.Location = New System.Drawing.Point(127, 57)
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        Me.lblCutOffTwo.Size = New System.Drawing.Size(92, 19)
        Me.lblCutOffTwo.TabIndex = 41
        Me.lblCutOffTwo.Text = "Cutoff for 2000 years:"
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        Me.ucrInputComboBoxMonthTwo.Location = New System.Drawing.Point(114, 105)
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        Me.ucrInputComboBoxMonthTwo.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputComboBoxMonthTwo.TabIndex = 45
        '
        'lblYearTwo
        '
        Me.lblYearTwo.AutoSize = True
        Me.lblYearTwo.Location = New System.Drawing.Point(7, 19)
        Me.lblYearTwo.Name = "lblYearTwo"
        Me.lblYearTwo.Size = New System.Drawing.Size(32, 13)
        Me.lblYearTwo.TabIndex = 38
        Me.lblYearTwo.Text = "Year:"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Me
        Me.ucrReceiverYearTwo.Location = New System.Drawing.Point(6, 34)
        Me.ucrReceiverYearTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearTwo.TabIndex = 43
        '
        'lblDayofYear
        '
        Me.lblDayofYear.AutoSize = True
        Me.lblDayofYear.Location = New System.Drawing.Point(7, 63)
        Me.lblDayofYear.Name = "lblDayofYear"
        Me.lblDayofYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayofYear.TabIndex = 39
        Me.lblDayofYear.Text = "Day of Year:"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.frmParent = Me
        Me.ucrReceiverDayTwo.Location = New System.Drawing.Point(6, 77)
        Me.ucrReceiverDayTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayTwo.TabIndex = 44
        '
        'grpSingleColumn
        '
        Me.grpSingleColumn.Controls.Add(Me.grpFormatField)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyFormat)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyOrigin)
        Me.grpSingleColumn.Controls.Add(Me.rdoDefaultFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrPnlFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrChkMore)
        Me.grpSingleColumn.Controls.Add(Me.ucrReceiverForDate)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputOrigin)
        Me.grpSingleColumn.Location = New System.Drawing.Point(258, 51)
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.Size = New System.Drawing.Size(254, 281)
        Me.grpSingleColumn.TabIndex = 6
        Me.grpSingleColumn.TabStop = False
        Me.grpSingleColumn.Text = "Single Column"
        '
        'rdoSpecifyFormat
        '
        Me.rdoSpecifyFormat.AutoSize = True
        Me.rdoSpecifyFormat.Location = New System.Drawing.Point(16, 116)
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.Size = New System.Drawing.Size(95, 17)
        Me.rdoSpecifyFormat.TabIndex = 54
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.Text = "Specify Format"
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoSpecifyOrigin
        '
        Me.rdoSpecifyOrigin.AutoSize = True
        Me.rdoSpecifyOrigin.Location = New System.Drawing.Point(16, 86)
        Me.rdoSpecifyOrigin.Name = "rdoSpecifyOrigin"
        Me.rdoSpecifyOrigin.Size = New System.Drawing.Size(90, 17)
        Me.rdoSpecifyOrigin.TabIndex = 53
        Me.rdoSpecifyOrigin.TabStop = True
        Me.rdoSpecifyOrigin.Text = "Specify Origin"
        Me.rdoSpecifyOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        Me.rdoDefaultFormat.AutoSize = True
        Me.rdoDefaultFormat.Location = New System.Drawing.Point(15, 57)
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.Size = New System.Drawing.Size(94, 17)
        Me.rdoDefaultFormat.TabIndex = 52
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.Text = "Default Format"
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.Location = New System.Drawing.Point(8, 52)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(114, 88)
        Me.ucrPnlFormat.TabIndex = 0
        '
        'ucrChkMore
        '
        Me.ucrChkMore.Checked = False
        Me.ucrChkMore.Location = New System.Drawing.Point(159, 22)
        Me.ucrChkMore.Name = "ucrChkMore"
        Me.ucrChkMore.Size = New System.Drawing.Size(86, 20)
        Me.ucrChkMore.TabIndex = 47
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.frmParent = Me
        Me.ucrReceiverForDate.Location = New System.Drawing.Point(13, 20)
        Me.ucrReceiverForDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForDate.Name = "ucrReceiverForDate"
        Me.ucrReceiverForDate.Selector = Nothing
        Me.ucrReceiverForDate.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverForDate.TabIndex = 46
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(127, 115)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputFormat.TabIndex = 45
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(128, 85)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(103, 21)
        Me.ucrInputOrigin.TabIndex = 44
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
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverDayThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpThreeColumns.Location = New System.Drawing.Point(258, 51)
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.Size = New System.Drawing.Size(225, 157)
        Me.grpThreeColumns.TabIndex = 5
        Me.grpThreeColumns.TabStop = False
        Me.grpThreeColumns.Text = "Three Columns"
        '
        'lblYearOption
        '
        Me.lblYearOption.AutoSize = True
        Me.lblYearOption.Location = New System.Drawing.Point(116, 16)
        Me.lblYearOption.Name = "lblYearOption"
        Me.lblYearOption.Size = New System.Drawing.Size(66, 13)
        Me.lblYearOption.TabIndex = 70
        Me.lblYearOption.Text = "Year Option:"
        '
        'lblDayOption
        '
        Me.lblDayOption.AutoSize = True
        Me.lblDayOption.Location = New System.Drawing.Point(116, 103)
        Me.lblDayOption.Name = "lblDayOption"
        Me.lblDayOption.Size = New System.Drawing.Size(63, 13)
        Me.lblDayOption.TabIndex = 69
        Me.lblDayOption.Text = "Day Option:"
        '
        'lblMonthOption
        '
        Me.lblMonthOption.AutoSize = True
        Me.lblMonthOption.Location = New System.Drawing.Point(116, 60)
        Me.lblMonthOption.Name = "lblMonthOption"
        Me.lblMonthOption.Size = New System.Drawing.Size(74, 13)
        Me.lblMonthOption.TabIndex = 68
        Me.lblMonthOption.Text = "Month Option:"
        '
        'ucrInputDayOption
        '
        Me.ucrInputDayOption.AddQuotesIfUnrecognised = True
        Me.ucrInputDayOption.IsReadOnly = False
        Me.ucrInputDayOption.Location = New System.Drawing.Point(119, 119)
        Me.ucrInputDayOption.Name = "ucrInputDayOption"
        Me.ucrInputDayOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputDayOption.TabIndex = 67
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthOption.IsReadOnly = False
        Me.ucrInputMonthOption.Location = New System.Drawing.Point(119, 73)
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        Me.ucrInputMonthOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputMonthOption.TabIndex = 66
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.AddQuotesIfUnrecognised = True
        Me.ucrInputYearOption.IsReadOnly = False
        Me.ucrInputYearOption.Location = New System.Drawing.Point(119, 30)
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        Me.ucrInputYearOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputYearOption.TabIndex = 65
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.Location = New System.Drawing.Point(7, 103)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(74, 13)
        Me.lblDayofMonth.TabIndex = 61
        Me.lblDayofMonth.Text = "Day of Month:"
        '
        'lblMonthThree
        '
        Me.lblMonthThree.AutoSize = True
        Me.lblMonthThree.Location = New System.Drawing.Point(7, 60)
        Me.lblMonthThree.Name = "lblMonthThree"
        Me.lblMonthThree.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthThree.TabIndex = 60
        Me.lblMonthThree.Text = "Month:"
        '
        'lblYearThree
        '
        Me.lblYearThree.AutoSize = True
        Me.lblYearThree.Location = New System.Drawing.Point(7, 16)
        Me.lblYearThree.Name = "lblYearThree"
        Me.lblYearThree.Size = New System.Drawing.Size(32, 13)
        Me.lblYearThree.TabIndex = 59
        Me.lblYearThree.Text = "Year:"
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Me
        Me.ucrReceiverYearThree.Location = New System.Drawing.Point(6, 31)
        Me.ucrReceiverYearThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearThree.TabIndex = 62
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.frmParent = Me
        Me.ucrReceiverDayThree.Location = New System.Drawing.Point(6, 117)
        Me.ucrReceiverDayThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayThree.TabIndex = 63
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.frmParent = Me
        Me.ucrReceiverMonthThree.Location = New System.Drawing.Point(6, 74)
        Me.ucrReceiverMonthThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverMonthThree.TabIndex = 64
        '
        'rdoThreeColumns
        '
        Me.rdoThreeColumns.AutoSize = True
        Me.rdoThreeColumns.Location = New System.Drawing.Point(341, 15)
        Me.rdoThreeColumns.Name = "rdoThreeColumns"
        Me.rdoThreeColumns.Size = New System.Drawing.Size(114, 17)
        Me.rdoThreeColumns.TabIndex = 17
        Me.rdoThreeColumns.TabStop = True
        Me.rdoThreeColumns.Text = "Year - Month - Day"
        Me.rdoThreeColumns.UseVisualStyleBackColor = True
        '
        'rdoTwoColumns
        '
        Me.rdoTwoColumns.AutoSize = True
        Me.rdoTwoColumns.Location = New System.Drawing.Point(164, 15)
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.Size = New System.Drawing.Size(127, 17)
        Me.rdoTwoColumns.TabIndex = 16
        Me.rdoTwoColumns.TabStop = True
        Me.rdoTwoColumns.Text = "Year and Day of Year"
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.AutoSize = True
        Me.rdoSingleColumn.Location = New System.Drawing.Point(19, 15)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(92, 17)
        Me.rdoSingleColumn.TabIndex = 15
        Me.rdoSingleColumn.TabStop = True
        Me.rdoSingleColumn.Text = "Single Column"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveDate
        '
        Me.ucrSaveDate.Location = New System.Drawing.Point(10, 333)
        Me.ucrSaveDate.Name = "ucrSaveDate"
        Me.ucrSaveDate.Size = New System.Drawing.Size(255, 24)
        Me.ucrSaveDate.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 364)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(417, 54)
        Me.ucrBase.TabIndex = 9
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        Me.ucrSelectorMakeDate.Location = New System.Drawing.Point(10, 51)
        Me.ucrSelectorMakeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        Me.ucrSelectorMakeDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMakeDate.TabIndex = 3
        '
        'ucrPnlDate
        '
        Me.ucrPnlDate.Location = New System.Drawing.Point(10, 9)
        Me.ucrPnlDate.Name = "ucrPnlDate"
        Me.ucrPnlDate.Size = New System.Drawing.Size(503, 36)
        Me.ucrPnlDate.TabIndex = 0
        '
        'grpFormatField
        '
        Me.grpFormatField.Controls.Add(Me.Label1)
        Me.grpFormatField.Controls.Add(Me.Label2)
        Me.grpFormatField.Controls.Add(Me.Label3)
        Me.grpFormatField.Controls.Add(Me.Label4)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox1)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox2)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox3)
        Me.grpFormatField.Controls.Add(Me.UcrInputComboBox4)
        Me.grpFormatField.Location = New System.Drawing.Point(8, 146)
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.Size = New System.Drawing.Size(234, 124)
        Me.grpFormatField.TabIndex = 63
        Me.grpFormatField.TabStop = False
        Me.grpFormatField.Text = "Format Field"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Separator:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(75, 69)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 60
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(75, 95)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox2.TabIndex = 62
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(75, 43)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox3.TabIndex = 58
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.IsReadOnly = False
        Me.UcrInputComboBox4.Location = New System.Drawing.Point(75, 17)
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        Me.UcrInputComboBox4.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox4.TabIndex = 56
        '
        'dlgMakeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 427)
        Me.Controls.Add(Me.rdoThreeColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrSaveDate)
        Me.Controls.Add(Me.grpSingleColumn)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.grpThreeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorMakeDate)
        Me.Controls.Add(Me.ucrPnlDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMakeDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Make Date"
        Me.grpTwoColumns.ResumeLayout(False)
        Me.grpTwoColumns.PerformLayout()
        Me.grpSingleColumn.ResumeLayout(False)
        Me.grpSingleColumn.PerformLayout()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.grpFormatField.ResumeLayout(False)
        Me.grpFormatField.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorMakeDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpTwoColumns As GroupBox
    Friend WithEvents grpThreeColumns As GroupBox
    Friend WithEvents grpSingleColumn As GroupBox
    Friend WithEvents ucrSaveDate As ucrSave
    Friend WithEvents rdoThreeColumns As RadioButton
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents ucrPnlDate As UcrPanel
    Friend WithEvents lblCutOffTwo As Label
    Friend WithEvents ucrInputComboBoxMonthTwo As ucrInputComboBox
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverDayTwo As ucrReceiverSingle
    Friend WithEvents lblYearOption As Label
    Friend WithEvents lblDayOption As Label
    Friend WithEvents lblMonthOption As Label
    Friend WithEvents ucrInputDayOption As ucrInputComboBox
    Friend WithEvents ucrInputMonthOption As ucrInputComboBox
    Friend WithEvents ucrInputYearOption As ucrInputComboBox
    Friend WithEvents lblDayofMonth As Label
    Friend WithEvents lblMonthThree As Label
    Friend WithEvents lblYearThree As Label
    Friend WithEvents ucrReceiverYearThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverDayThree As ucrReceiverSingle
    Friend WithEvents ucrReceiverMonthThree As ucrReceiverSingle
    Friend WithEvents ucrChkTwoDigitYear As ucrCheck
    Friend WithEvents ucrNudCutoff As ucrNud
    Friend WithEvents ucrInputFormat As ucrInputComboBox
    Friend WithEvents ucrInputOrigin As ucrInputComboBox
    Friend WithEvents ucrChkMore As ucrCheck
    Friend WithEvents ucrReceiverForDate As ucrReceiverSingle
    Friend WithEvents rdoSpecifyFormat As RadioButton
    Friend WithEvents rdoSpecifyOrigin As RadioButton
    Friend WithEvents rdoDefaultFormat As RadioButton
    Friend WithEvents ucrPnlFormat As UcrPanel
    Friend WithEvents grpFormatField As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox3 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox4 As ucrInputComboBox
End Class