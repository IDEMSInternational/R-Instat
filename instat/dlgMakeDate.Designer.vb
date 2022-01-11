' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgMakeDate))
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
        Me.grpFormats = New System.Windows.Forms.GroupBox()
        Me.txtTextDateFormats = New System.Windows.Forms.RichTextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.ucrDtpSpecifyOrigin = New instat.ucrDateTimePicker()
        Me.ucrInputUnits = New instat.ucrInputComboBox()
        Me.grpFormatField = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox4 = New instat.ucrInputComboBox()
        Me.rdoSpecifyFormat = New System.Windows.Forms.RadioButton()
        Me.rdoOrigin = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultFormat = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrReceiverForDate = New instat.ucrReceiverSingle()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrInputOrigin = New instat.ucrInputComboBox()
        Me.grpThreeColumns = New System.Windows.Forms.GroupBox()
        Me.ucrInputDayThree = New instat.ucrInputTextBox()
        Me.rdoDayValue = New System.Windows.Forms.RadioButton()
        Me.rdoDayColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlDayType = New instat.UcrPanel()
        Me.ucrInputYearThree = New instat.ucrInputTextBox()
        Me.rdoYearValue = New System.Windows.Forms.RadioButton()
        Me.rdoYearColumn = New System.Windows.Forms.RadioButton()
        Me.rdoMonthValue = New System.Windows.Forms.RadioButton()
        Me.rdoMonthColumn = New System.Windows.Forms.RadioButton()
        Me.ucrInputMonthThree = New instat.ucrInputTextBox()
        Me.lblYearFormat = New System.Windows.Forms.Label()
        Me.lblMonthFormat = New System.Windows.Forms.Label()
        Me.ucrInputMonthOption = New instat.ucrInputComboBox()
        Me.ucrInputYearOption = New instat.ucrInputComboBox()
        Me.lblDayofMonth = New System.Windows.Forms.Label()
        Me.lblMonthThree = New System.Windows.Forms.Label()
        Me.lblYearThree = New System.Windows.Forms.Label()
        Me.ucrReceiverYearThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverDayThree = New instat.ucrReceiverSingle()
        Me.ucrReceiverMonthThree = New instat.ucrReceiverSingle()
        Me.ucrPnlYearType = New instat.UcrPanel()
        Me.ucrPnlMonthType = New instat.UcrPanel()
        Me.rdoThreeColumns = New System.Windows.Forms.RadioButton()
        Me.rdoTwoColumns = New System.Windows.Forms.RadioButton()
        Me.rdoSingleColumn = New System.Windows.Forms.RadioButton()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ttMakeDate = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrPnlDate = New instat.UcrPanel()
        Me.ucrSaveDate = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpTwoColumns.SuspendLayout()
        Me.grpSingleColumn.SuspendLayout()
        Me.grpFormats.SuspendLayout()
        Me.grpFormatField.SuspendLayout()
        Me.grpThreeColumns.SuspendLayout()
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
        Me.grpTwoColumns.Location = New System.Drawing.Point(238, 51)
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.Size = New System.Drawing.Size(267, 139)
        Me.grpTwoColumns.TabIndex = 7
        Me.grpTwoColumns.TabStop = False
        Me.grpTwoColumns.Text = "Two Columns"
        '
        'ucrChkTwoDigitYear
        '
        Me.ucrChkTwoDigitYear.AutoSize = True
        Me.ucrChkTwoDigitYear.Checked = False
        Me.ucrChkTwoDigitYear.Location = New System.Drawing.Point(133, 34)
        Me.ucrChkTwoDigitYear.Name = "ucrChkTwoDigitYear"
        Me.ucrChkTwoDigitYear.Size = New System.Drawing.Size(88, 23)
        Me.ucrChkTwoDigitYear.TabIndex = 2
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.AutoSize = True
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoff.Location = New System.Drawing.Point(133, 74)
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Size = New System.Drawing.Size(44, 20)
        Me.ucrNudCutoff.TabIndex = 5
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCutOffTwo
        '
        Me.lblCutOffTwo.AutoSize = True
        Me.lblCutOffTwo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCutOffTwo.Location = New System.Drawing.Point(130, 57)
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        Me.lblCutOffTwo.Size = New System.Drawing.Size(108, 13)
        Me.lblCutOffTwo.TabIndex = 3
        Me.lblCutOffTwo.Text = "Cutoff for 2000 years:"
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonthTwo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxMonthTwo.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        Me.ucrInputComboBoxMonthTwo.Location = New System.Drawing.Point(133, 100)
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        Me.ucrInputComboBoxMonthTwo.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputComboBoxMonthTwo.TabIndex = 7
        '
        'lblYearTwo
        '
        Me.lblYearTwo.AutoSize = True
        Me.lblYearTwo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearTwo.Location = New System.Drawing.Point(9, 19)
        Me.lblYearTwo.Name = "lblYearTwo"
        Me.lblYearTwo.Size = New System.Drawing.Size(32, 13)
        Me.lblYearTwo.TabIndex = 0
        Me.lblYearTwo.Text = "Year:"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.AutoSize = True
        Me.ucrReceiverYearTwo.frmParent = Me
        Me.ucrReceiverYearTwo.Location = New System.Drawing.Point(12, 34)
        Me.ucrReceiverYearTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.TabIndex = 1
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'lblDayofYear
        '
        Me.lblDayofYear.AutoSize = True
        Me.lblDayofYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayofYear.Location = New System.Drawing.Point(9, 86)
        Me.lblDayofYear.Name = "lblDayofYear"
        Me.lblDayofYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayofYear.TabIndex = 4
        Me.lblDayofYear.Text = "Day of Year:"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.AutoSize = True
        Me.ucrReceiverDayTwo.frmParent = Me
        Me.ucrReceiverDayTwo.Location = New System.Drawing.Point(12, 101)
        Me.ucrReceiverDayTwo.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayTwo.strNcFilePath = ""
        Me.ucrReceiverDayTwo.TabIndex = 6
        Me.ucrReceiverDayTwo.ucrSelector = Nothing
        '
        'grpSingleColumn
        '
        Me.grpSingleColumn.Controls.Add(Me.grpFormats)
        Me.grpSingleColumn.Controls.Add(Me.lblUnits)
        Me.grpSingleColumn.Controls.Add(Me.ucrDtpSpecifyOrigin)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputUnits)
        Me.grpSingleColumn.Controls.Add(Me.grpFormatField)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyFormat)
        Me.grpSingleColumn.Controls.Add(Me.rdoOrigin)
        Me.grpSingleColumn.Controls.Add(Me.rdoDefaultFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrPnlFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrReceiverForDate)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputOrigin)
        Me.grpSingleColumn.Location = New System.Drawing.Point(238, 51)
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.Size = New System.Drawing.Size(267, 336)
        Me.grpSingleColumn.TabIndex = 5
        Me.grpSingleColumn.TabStop = False
        Me.grpSingleColumn.Text = "Single Column"
        '
        'grpFormats
        '
        Me.grpFormats.Controls.Add(Me.txtTextDateFormats)
        Me.grpFormats.Location = New System.Drawing.Point(6, 169)
        Me.grpFormats.Name = "grpFormats"
        Me.grpFormats.Size = New System.Drawing.Size(254, 161)
        Me.grpFormats.TabIndex = 12
        Me.grpFormats.TabStop = False
        Me.grpFormats.Text = "Format Description"
        '
        'txtTextDateFormats
        '
        Me.txtTextDateFormats.Location = New System.Drawing.Point(10, 17)
        Me.txtTextDateFormats.Name = "txtTextDateFormats"
        Me.txtTextDateFormats.Size = New System.Drawing.Size(238, 134)
        Me.txtTextDateFormats.TabIndex = 0
        Me.txtTextDateFormats.Text = resources.GetString("txtTextDateFormats.Text")
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUnits.Location = New System.Drawing.Point(111, 144)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 7
        Me.lblUnits.Text = "Units:"
        '
        'ucrDtpSpecifyOrigin
        '
        Me.ucrDtpSpecifyOrigin.AutoSize = True
        Me.ucrDtpSpecifyOrigin.DateValue = New Date(2021, 5, 19, 13, 56, 22, 794)
        Me.ucrDtpSpecifyOrigin.Format = "dd MMM yyyy"
        Me.ucrDtpSpecifyOrigin.Location = New System.Drawing.Point(130, 110)
        Me.ucrDtpSpecifyOrigin.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpSpecifyOrigin.MinDate = New Date(1753, 2, 1, 0, 0, 0, 0)
        Me.ucrDtpSpecifyOrigin.Name = "ucrDtpSpecifyOrigin"
        Me.ucrDtpSpecifyOrigin.Size = New System.Drawing.Size(119, 21)
        Me.ucrDtpSpecifyOrigin.TabIndex = 5
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputUnits.GetSetSelectedIndex = -1
        Me.ucrInputUnits.IsReadOnly = False
        Me.ucrInputUnits.Location = New System.Drawing.Point(145, 140)
        Me.ucrInputUnits.Name = "ucrInputUnits"
        Me.ucrInputUnits.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputUnits.TabIndex = 8
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
        Me.grpFormatField.Location = New System.Drawing.Point(7, 169)
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.Size = New System.Drawing.Size(254, 124)
        Me.grpFormatField.TabIndex = 9
        Me.grpFormatField.TabStop = False
        Me.grpFormatField.Text = "Format Field"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(4, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(4, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Separator:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(75, 69)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 5
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox2.GetSetSelectedIndex = -1
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(75, 95)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox2.TabIndex = 7
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox3.GetSetSelectedIndex = -1
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(75, 43)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox3.TabIndex = 3
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputComboBox4.GetSetSelectedIndex = -1
        Me.UcrInputComboBox4.IsReadOnly = False
        Me.UcrInputComboBox4.Location = New System.Drawing.Point(75, 17)
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        Me.UcrInputComboBox4.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox4.TabIndex = 1
        '
        'rdoSpecifyFormat
        '
        Me.rdoSpecifyFormat.AutoSize = True
        Me.rdoSpecifyFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyFormat.Location = New System.Drawing.Point(15, 110)
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.Size = New System.Drawing.Size(95, 17)
        Me.rdoSpecifyFormat.TabIndex = 3
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.Text = "Specify Format"
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoOrigin
        '
        Me.rdoOrigin.AutoSize = True
        Me.rdoOrigin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoOrigin.Location = New System.Drawing.Point(15, 81)
        Me.rdoOrigin.Name = "rdoOrigin"
        Me.rdoOrigin.Size = New System.Drawing.Size(52, 17)
        Me.rdoOrigin.TabIndex = 2
        Me.rdoOrigin.TabStop = True
        Me.rdoOrigin.Text = "Origin"
        Me.rdoOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        Me.rdoDefaultFormat.AutoSize = True
        Me.rdoDefaultFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDefaultFormat.Location = New System.Drawing.Point(15, 52)
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.Size = New System.Drawing.Size(94, 17)
        Me.rdoDefaultFormat.TabIndex = 1
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.Text = "Default Format"
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlFormat.Location = New System.Drawing.Point(8, 47)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(116, 88)
        Me.ucrPnlFormat.TabIndex = 2
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.AutoSize = True
        Me.ucrReceiverForDate.frmParent = Me
        Me.ucrReceiverForDate.Location = New System.Drawing.Point(6, 25)
        Me.ucrReceiverForDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverForDate.Name = "ucrReceiverForDate"
        Me.ucrReceiverForDate.Selector = Nothing
        Me.ucrReceiverForDate.Size = New System.Drawing.Size(129, 20)
        Me.ucrReceiverForDate.strNcFilePath = ""
        Me.ucrReceiverForDate.TabIndex = 0
        Me.ucrReceiverForDate.ucrSelector = Nothing
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputFormat.GetSetSelectedIndex = -1
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(130, 110)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(120, 21)
        Me.ucrInputFormat.TabIndex = 6
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputOrigin.GetSetSelectedIndex = -1
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(130, 80)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputOrigin.TabIndex = 4
        '
        'grpThreeColumns
        '
        Me.grpThreeColumns.Controls.Add(Me.ucrInputDayThree)
        Me.grpThreeColumns.Controls.Add(Me.rdoDayValue)
        Me.grpThreeColumns.Controls.Add(Me.rdoDayColumn)
        Me.grpThreeColumns.Controls.Add(Me.ucrPnlDayType)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputYearThree)
        Me.grpThreeColumns.Controls.Add(Me.rdoYearValue)
        Me.grpThreeColumns.Controls.Add(Me.rdoYearColumn)
        Me.grpThreeColumns.Controls.Add(Me.rdoMonthValue)
        Me.grpThreeColumns.Controls.Add(Me.rdoMonthColumn)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.lblYearFormat)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthFormat)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputMonthOption)
        Me.grpThreeColumns.Controls.Add(Me.ucrInputYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblDayofMonth)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.lblYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverYearThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverDayThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrReceiverMonthThree)
        Me.grpThreeColumns.Controls.Add(Me.ucrPnlYearType)
        Me.grpThreeColumns.Controls.Add(Me.ucrPnlMonthType)
        Me.grpThreeColumns.Location = New System.Drawing.Point(238, 51)
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.Size = New System.Drawing.Size(267, 292)
        Me.grpThreeColumns.TabIndex = 8
        Me.grpThreeColumns.TabStop = False
        Me.grpThreeColumns.Text = "Year Month Day"
        '
        'ucrInputDayThree
        '
        Me.ucrInputDayThree.AddQuotesIfUnrecognised = True
        Me.ucrInputDayThree.AutoSize = True
        Me.ucrInputDayThree.IsMultiline = False
        Me.ucrInputDayThree.IsReadOnly = False
        Me.ucrInputDayThree.Location = New System.Drawing.Point(8, 247)
        Me.ucrInputDayThree.Name = "ucrInputDayThree"
        Me.ucrInputDayThree.Size = New System.Drawing.Size(53, 21)
        Me.ucrInputDayThree.TabIndex = 16
        '
        'rdoDayValue
        '
        Me.rdoDayValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDayValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayValue.FlatAppearance.BorderSize = 2
        Me.rdoDayValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDayValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDayValue.Location = New System.Drawing.Point(58, 213)
        Me.rdoDayValue.Name = "rdoDayValue"
        Me.rdoDayValue.Size = New System.Drawing.Size(54, 23)
        Me.rdoDayValue.TabIndex = 15
        Me.rdoDayValue.TabStop = True
        Me.rdoDayValue.Text = "Value"
        Me.rdoDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDayValue.UseVisualStyleBackColor = True
        '
        'rdoDayColumn
        '
        Me.rdoDayColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDayColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayColumn.FlatAppearance.BorderSize = 2
        Me.rdoDayColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDayColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDayColumn.Location = New System.Drawing.Point(8, 213)
        Me.rdoDayColumn.Name = "rdoDayColumn"
        Me.rdoDayColumn.Size = New System.Drawing.Size(59, 23)
        Me.rdoDayColumn.TabIndex = 14
        Me.rdoDayColumn.TabStop = True
        Me.rdoDayColumn.Text = "Column"
        Me.rdoDayColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDayColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlDayType
        '
        Me.ucrPnlDayType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDayType.Location = New System.Drawing.Point(5, 207)
        Me.ucrPnlDayType.Name = "ucrPnlDayType"
        Me.ucrPnlDayType.Size = New System.Drawing.Size(109, 34)
        Me.ucrPnlDayType.TabIndex = 13
        '
        'ucrInputYearThree
        '
        Me.ucrInputYearThree.AddQuotesIfUnrecognised = True
        Me.ucrInputYearThree.AutoSize = True
        Me.ucrInputYearThree.IsMultiline = False
        Me.ucrInputYearThree.IsReadOnly = False
        Me.ucrInputYearThree.Location = New System.Drawing.Point(8, 68)
        Me.ucrInputYearThree.Name = "ucrInputYearThree"
        Me.ucrInputYearThree.Size = New System.Drawing.Size(53, 21)
        Me.ucrInputYearThree.TabIndex = 3
        '
        'rdoYearValue
        '
        Me.rdoYearValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYearValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearValue.FlatAppearance.BorderSize = 2
        Me.rdoYearValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYearValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYearValue.Location = New System.Drawing.Point(60, 38)
        Me.rdoYearValue.Name = "rdoYearValue"
        Me.rdoYearValue.Size = New System.Drawing.Size(54, 23)
        Me.rdoYearValue.TabIndex = 2
        Me.rdoYearValue.TabStop = True
        Me.rdoYearValue.Text = "Value"
        Me.rdoYearValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYearValue.UseVisualStyleBackColor = True
        '
        'rdoYearColumn
        '
        Me.rdoYearColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYearColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearColumn.FlatAppearance.BorderSize = 2
        Me.rdoYearColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYearColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYearColumn.Location = New System.Drawing.Point(8, 38)
        Me.rdoYearColumn.Name = "rdoYearColumn"
        Me.rdoYearColumn.Size = New System.Drawing.Size(59, 23)
        Me.rdoYearColumn.TabIndex = 1
        Me.rdoYearColumn.TabStop = True
        Me.rdoYearColumn.Text = "Column"
        Me.rdoYearColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYearColumn.UseVisualStyleBackColor = True
        '
        'rdoMonthValue
        '
        Me.rdoMonthValue.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthValue.FlatAppearance.BorderSize = 2
        Me.rdoMonthValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthValue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthValue.Location = New System.Drawing.Point(58, 128)
        Me.rdoMonthValue.Name = "rdoMonthValue"
        Me.rdoMonthValue.Size = New System.Drawing.Size(54, 23)
        Me.rdoMonthValue.TabIndex = 8
        Me.rdoMonthValue.TabStop = True
        Me.rdoMonthValue.Text = "Value"
        Me.rdoMonthValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthValue.UseVisualStyleBackColor = True
        '
        'rdoMonthColumn
        '
        Me.rdoMonthColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoMonthColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthColumn.FlatAppearance.BorderSize = 2
        Me.rdoMonthColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMonthColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoMonthColumn.Location = New System.Drawing.Point(8, 128)
        Me.rdoMonthColumn.Name = "rdoMonthColumn"
        Me.rdoMonthColumn.Size = New System.Drawing.Size(59, 23)
        Me.rdoMonthColumn.TabIndex = 7
        Me.rdoMonthColumn.TabStop = True
        Me.rdoMonthColumn.Text = "Column"
        Me.rdoMonthColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoMonthColumn.UseVisualStyleBackColor = True
        '
        'ucrInputMonthThree
        '
        Me.ucrInputMonthThree.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthThree.AutoSize = True
        Me.ucrInputMonthThree.IsMultiline = False
        Me.ucrInputMonthThree.IsReadOnly = False
        Me.ucrInputMonthThree.Location = New System.Drawing.Point(8, 159)
        Me.ucrInputMonthThree.Name = "ucrInputMonthThree"
        Me.ucrInputMonthThree.Size = New System.Drawing.Size(53, 21)
        Me.ucrInputMonthThree.TabIndex = 10
        '
        'lblYearFormat
        '
        Me.lblYearFormat.AutoSize = True
        Me.lblYearFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearFormat.Location = New System.Drawing.Point(148, 50)
        Me.lblYearFormat.Name = "lblYearFormat"
        Me.lblYearFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblYearFormat.TabIndex = 4
        Me.lblYearFormat.Text = "Format:"
        '
        'lblMonthFormat
        '
        Me.lblMonthFormat.AutoSize = True
        Me.lblMonthFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthFormat.Location = New System.Drawing.Point(148, 141)
        Me.lblMonthFormat.Name = "lblMonthFormat"
        Me.lblMonthFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblMonthFormat.TabIndex = 9
        Me.lblMonthFormat.Text = "Format:"
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMonthOption.GetSetSelectedIndex = -1
        Me.ucrInputMonthOption.IsReadOnly = False
        Me.ucrInputMonthOption.Location = New System.Drawing.Point(151, 158)
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        Me.ucrInputMonthOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputMonthOption.TabIndex = 11
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.AddQuotesIfUnrecognised = True
        Me.ucrInputYearOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYearOption.GetSetSelectedIndex = -1
        Me.ucrInputYearOption.IsReadOnly = False
        Me.ucrInputYearOption.Location = New System.Drawing.Point(151, 67)
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        Me.ucrInputYearOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputYearOption.TabIndex = 5
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayofMonth.Location = New System.Drawing.Point(9, 194)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(74, 13)
        Me.lblDayofMonth.TabIndex = 12
        Me.lblDayofMonth.Text = "Day of Month:"
        '
        'lblMonthThree
        '
        Me.lblMonthThree.AutoSize = True
        Me.lblMonthThree.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMonthThree.Location = New System.Drawing.Point(9, 110)
        Me.lblMonthThree.Name = "lblMonthThree"
        Me.lblMonthThree.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthThree.TabIndex = 6
        Me.lblMonthThree.Text = "Month:"
        '
        'lblYearThree
        '
        Me.lblYearThree.AutoSize = True
        Me.lblYearThree.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYearThree.Location = New System.Drawing.Point(9, 19)
        Me.lblYearThree.Name = "lblYearThree"
        Me.lblYearThree.Size = New System.Drawing.Size(32, 13)
        Me.lblYearThree.TabIndex = 0
        Me.lblYearThree.Text = "Year:"
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.AutoSize = True
        Me.ucrReceiverYearThree.frmParent = Me
        Me.ucrReceiverYearThree.Location = New System.Drawing.Point(8, 68)
        Me.ucrReceiverYearThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.Size = New System.Drawing.Size(106, 20)
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.TabIndex = 1
        Me.ucrReceiverYearThree.ucrSelector = Nothing
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.AutoSize = True
        Me.ucrReceiverDayThree.frmParent = Me
        Me.ucrReceiverDayThree.Location = New System.Drawing.Point(8, 247)
        Me.ucrReceiverDayThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.Size = New System.Drawing.Size(106, 20)
        Me.ucrReceiverDayThree.strNcFilePath = ""
        Me.ucrReceiverDayThree.TabIndex = 9
        Me.ucrReceiverDayThree.ucrSelector = Nothing
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.AutoSize = True
        Me.ucrReceiverMonthThree.frmParent = Me
        Me.ucrReceiverMonthThree.Location = New System.Drawing.Point(8, 159)
        Me.ucrReceiverMonthThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.Size = New System.Drawing.Size(106, 20)
        Me.ucrReceiverMonthThree.strNcFilePath = ""
        Me.ucrReceiverMonthThree.TabIndex = 5
        Me.ucrReceiverMonthThree.ucrSelector = Nothing
        '
        'ucrPnlYearType
        '
        Me.ucrPnlYearType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlYearType.Location = New System.Drawing.Point(6, 32)
        Me.ucrPnlYearType.Name = "ucrPnlYearType"
        Me.ucrPnlYearType.Size = New System.Drawing.Size(109, 34)
        Me.ucrPnlYearType.TabIndex = 15
        '
        'ucrPnlMonthType
        '
        Me.ucrPnlMonthType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlMonthType.Location = New System.Drawing.Point(5, 122)
        Me.ucrPnlMonthType.Name = "ucrPnlMonthType"
        Me.ucrPnlMonthType.Size = New System.Drawing.Size(109, 34)
        Me.ucrPnlMonthType.TabIndex = 16
        '
        'rdoThreeColumns
        '
        Me.rdoThreeColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreeColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatAppearance.BorderSize = 2
        Me.rdoThreeColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreeColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoThreeColumns.Location = New System.Drawing.Point(324, 8)
        Me.rdoThreeColumns.Name = "rdoThreeColumns"
        Me.rdoThreeColumns.Size = New System.Drawing.Size(137, 28)
        Me.rdoThreeColumns.TabIndex = 3
        Me.rdoThreeColumns.Text = "Year - Month - Day"
        Me.rdoThreeColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoThreeColumns.UseVisualStyleBackColor = True
        '
        'rdoTwoColumns
        '
        Me.rdoTwoColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoTwoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.FlatAppearance.BorderSize = 2
        Me.rdoTwoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTwoColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoTwoColumns.Location = New System.Drawing.Point(189, 8)
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.Size = New System.Drawing.Size(137, 28)
        Me.rdoTwoColumns.TabIndex = 2
        Me.rdoTwoColumns.Text = "Year and Day of Year"
        Me.rdoTwoColumns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        Me.rdoSingleColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSingleColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.FlatAppearance.BorderSize = 2
        Me.rdoSingleColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSingleColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSingleColumn.Location = New System.Drawing.Point(54, 8)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(137, 28)
        Me.rdoSingleColumn.TabIndex = 1
        Me.rdoSingleColumn.Text = "Single Column"
        Me.rdoSingleColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(406, 389)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(78, 22)
        Me.cmdHelp.TabIndex = 9
        Me.cmdHelp.Text = "Help..."
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrPnlDate
        '
        Me.ucrPnlDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlDate.Location = New System.Drawing.Point(10, 4)
        Me.ucrPnlDate.Name = "ucrPnlDate"
        Me.ucrPnlDate.Size = New System.Drawing.Size(495, 35)
        Me.ucrPnlDate.TabIndex = 0
        '
        'ucrSaveDate
        '
        Me.ucrSaveDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveDate.Location = New System.Drawing.Point(10, 394)
        Me.ucrSaveDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveDate.Name = "ucrSaveDate"
        Me.ucrSaveDate.Size = New System.Drawing.Size(290, 24)
        Me.ucrSaveDate.TabIndex = 10
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 422)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 11
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.AutoSize = True
        Me.ucrSelectorMakeDate.bDropUnusedFilterLevels = False
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        Me.ucrSelectorMakeDate.Location = New System.Drawing.Point(10, 51)
        Me.ucrSelectorMakeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        Me.ucrSelectorMakeDate.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorMakeDate.TabIndex = 4
        '
        'dlgMakeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(517, 477)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.rdoThreeColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrPnlDate)
        Me.Controls.Add(Me.ucrSaveDate)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorMakeDate)
        Me.Controls.Add(Me.grpSingleColumn)
        Me.Controls.Add(Me.grpThreeColumns)
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
        Me.grpFormats.ResumeLayout(False)
        Me.grpFormatField.ResumeLayout(False)
        Me.grpFormatField.PerformLayout()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorMakeDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpTwoColumns As GroupBox
    Friend WithEvents grpThreeColumns As GroupBox
    Friend WithEvents grpSingleColumn As GroupBox
    Friend WithEvents ucrSaveDate As ucrSave
    Friend WithEvents lblCutOffTwo As Label
    Friend WithEvents ucrInputComboBoxMonthTwo As ucrInputComboBox
    Friend WithEvents lblYearTwo As Label
    Friend WithEvents ucrReceiverYearTwo As ucrReceiverSingle
    Friend WithEvents lblDayofYear As Label
    Friend WithEvents ucrReceiverDayTwo As ucrReceiverSingle
    Friend WithEvents lblYearFormat As Label
    Friend WithEvents lblMonthFormat As Label
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
    Friend WithEvents ucrReceiverForDate As ucrReceiverSingle
    Friend WithEvents rdoSpecifyFormat As RadioButton
    Friend WithEvents rdoOrigin As RadioButton
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
    Friend WithEvents rdoThreeColumns As RadioButton
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents ucrPnlDate As UcrPanel
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ttMakeDate As ToolTip
    Friend WithEvents ucrDtpSpecifyOrigin As ucrDateTimePicker
    Friend WithEvents ucrInputMonthThree As ucrInputTextBox
    Friend WithEvents ucrInputYearThree As ucrInputTextBox
    Friend WithEvents rdoYearValue As RadioButton
    Friend WithEvents rdoYearColumn As RadioButton
    Friend WithEvents rdoMonthValue As RadioButton
    Friend WithEvents rdoMonthColumn As RadioButton
    Friend WithEvents ucrPnlYearType As UcrPanel
    Friend WithEvents ucrPnlMonthType As UcrPanel
    Friend WithEvents ucrInputDayThree As ucrInputTextBox
    Friend WithEvents rdoDayValue As RadioButton
    Friend WithEvents rdoDayColumn As RadioButton
    Friend WithEvents ucrPnlDayType As UcrPanel
    Friend WithEvents lblUnits As Label
    Friend WithEvents ucrInputUnits As ucrInputComboBox
    Friend WithEvents grpFormats As GroupBox
    Friend WithEvents txtTextDateFormats As RichTextBox
End Class