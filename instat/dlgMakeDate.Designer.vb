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
        Me.rdoSpecifyOrigin = New System.Windows.Forms.RadioButton()
        Me.rdoDefaultFormat = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFormat = New instat.UcrPanel()
        Me.ucrReceiverForDate = New instat.ucrReceiverSingle()
        Me.ucrInputFormat = New instat.ucrInputComboBox()
        Me.ucrInputOrigin = New instat.ucrInputComboBox()
        Me.grpThreeColumns = New System.Windows.Forms.GroupBox()
        Me.lblYearOption = New System.Windows.Forms.Label()
        Me.lblMonthOption = New System.Windows.Forms.Label()
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
        Me.grpFormats = New System.Windows.Forms.GroupBox()
        Me.txtTextDateFormats = New System.Windows.Forms.RichTextBox()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.ucrPnlDate = New instat.UcrPanel()
        Me.ucrSaveDate = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorMakeDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ttMakeDate = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpTwoColumns.SuspendLayout()
        Me.grpSingleColumn.SuspendLayout()
        Me.grpFormatField.SuspendLayout()
        Me.grpThreeColumns.SuspendLayout()
        Me.grpFormats.SuspendLayout()
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
        Me.grpTwoColumns.Size = New System.Drawing.Size(252, 139)
        Me.grpTwoColumns.TabIndex = 6
        Me.grpTwoColumns.TabStop = False
        Me.grpTwoColumns.Text = "Two Columns"
        '
        'ucrChkTwoDigitYear
        '
        Me.ucrChkTwoDigitYear.Checked = False
        Me.ucrChkTwoDigitYear.Location = New System.Drawing.Point(130, 34)
        Me.ucrChkTwoDigitYear.Name = "ucrChkTwoDigitYear"
        Me.ucrChkTwoDigitYear.Size = New System.Drawing.Size(88, 20)
        Me.ucrChkTwoDigitYear.TabIndex = 2
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoff.Location = New System.Drawing.Point(130, 76)
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
        Me.lblCutOffTwo.Location = New System.Drawing.Point(127, 57)
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        Me.lblCutOffTwo.Size = New System.Drawing.Size(108, 13)
        Me.lblCutOffTwo.TabIndex = 3
        Me.lblCutOffTwo.Text = "Cutoff for 2000 years:"
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        Me.ucrInputComboBoxMonthTwo.Location = New System.Drawing.Point(113, 100)
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        Me.ucrInputComboBoxMonthTwo.Size = New System.Drawing.Size(105, 21)
        Me.ucrInputComboBoxMonthTwo.TabIndex = 7
        '
        'lblYearTwo
        '
        Me.lblYearTwo.AutoSize = True
        Me.lblYearTwo.Location = New System.Drawing.Point(7, 19)
        Me.lblYearTwo.Name = "lblYearTwo"
        Me.lblYearTwo.Size = New System.Drawing.Size(32, 13)
        Me.lblYearTwo.TabIndex = 0
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
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.TabIndex = 1
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'lblDayofYear
        '
        Me.lblDayofYear.AutoSize = True
        Me.lblDayofYear.Location = New System.Drawing.Point(7, 86)
        Me.lblDayofYear.Name = "lblDayofYear"
        Me.lblDayofYear.Size = New System.Drawing.Size(66, 13)
        Me.lblDayofYear.TabIndex = 4
        Me.lblDayofYear.Text = "Day of Year:"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.frmParent = Me
        Me.ucrReceiverDayTwo.Location = New System.Drawing.Point(6, 101)
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
        Me.grpSingleColumn.Controls.Add(Me.grpFormatField)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyFormat)
        Me.grpSingleColumn.Controls.Add(Me.rdoSpecifyOrigin)
        Me.grpSingleColumn.Controls.Add(Me.rdoDefaultFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrPnlFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrReceiverForDate)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputFormat)
        Me.grpSingleColumn.Controls.Add(Me.ucrInputOrigin)
        Me.grpSingleColumn.Location = New System.Drawing.Point(258, 51)
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.Size = New System.Drawing.Size(252, 320)
        Me.grpSingleColumn.TabIndex = 5
        Me.grpSingleColumn.TabStop = False
        Me.grpSingleColumn.Text = "Single Column"
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
        Me.grpFormatField.Location = New System.Drawing.Point(8, 153)
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.Size = New System.Drawing.Size(234, 124)
        Me.grpFormatField.TabIndex = 7
        Me.grpFormatField.TabStop = False
        Me.grpFormatField.Text = "Format Field"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Day:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Month:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Separator:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(75, 69)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox1.TabIndex = 5
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(75, 95)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox2.TabIndex = 7
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(75, 43)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox3.TabIndex = 3
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.IsReadOnly = False
        Me.UcrInputComboBox4.Location = New System.Drawing.Point(75, 17)
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        Me.UcrInputComboBox4.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputComboBox4.TabIndex = 1
        '
        'rdoSpecifyFormat
        '
        Me.rdoSpecifyFormat.AutoSize = True
        Me.rdoSpecifyFormat.Location = New System.Drawing.Point(15, 122)
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.Size = New System.Drawing.Size(95, 17)
        Me.rdoSpecifyFormat.TabIndex = 5
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.Text = "Specify Format"
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoSpecifyOrigin
        '
        Me.rdoSpecifyOrigin.AutoSize = True
        Me.rdoSpecifyOrigin.Location = New System.Drawing.Point(15, 93)
        Me.rdoSpecifyOrigin.Name = "rdoSpecifyOrigin"
        Me.rdoSpecifyOrigin.Size = New System.Drawing.Size(90, 17)
        Me.rdoSpecifyOrigin.TabIndex = 3
        Me.rdoSpecifyOrigin.TabStop = True
        Me.rdoSpecifyOrigin.Text = "Specify Origin"
        Me.rdoSpecifyOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        Me.rdoDefaultFormat.AutoSize = True
        Me.rdoDefaultFormat.Location = New System.Drawing.Point(15, 64)
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.Size = New System.Drawing.Size(94, 17)
        Me.rdoDefaultFormat.TabIndex = 2
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.Text = "Default Format"
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        Me.ucrPnlFormat.Location = New System.Drawing.Point(8, 59)
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        Me.ucrPnlFormat.Size = New System.Drawing.Size(113, 88)
        Me.ucrPnlFormat.TabIndex = 1
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.frmParent = Me
        Me.ucrReceiverForDate.Location = New System.Drawing.Point(6, 34)
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
        Me.ucrInputFormat.IsReadOnly = False
        Me.ucrInputFormat.Location = New System.Drawing.Point(128, 122)
        Me.ucrInputFormat.Name = "ucrInputFormat"
        Me.ucrInputFormat.Size = New System.Drawing.Size(114, 21)
        Me.ucrInputFormat.TabIndex = 6
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.IsReadOnly = False
        Me.ucrInputOrigin.Location = New System.Drawing.Point(128, 92)
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
        Me.ucrInputOrigin.Size = New System.Drawing.Size(114, 21)
        Me.ucrInputOrigin.TabIndex = 4
        '
        'grpThreeColumns
        '
        Me.grpThreeColumns.Controls.Add(Me.lblYearOption)
        Me.grpThreeColumns.Controls.Add(Me.lblMonthOption)
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
        Me.grpThreeColumns.Size = New System.Drawing.Size(252, 157)
        Me.grpThreeColumns.TabIndex = 9
        Me.grpThreeColumns.TabStop = False
        Me.grpThreeColumns.Text = "Three Columns"
        '
        'lblYearOption
        '
        Me.lblYearOption.AutoSize = True
        Me.lblYearOption.Location = New System.Drawing.Point(116, 17)
        Me.lblYearOption.Name = "lblYearOption"
        Me.lblYearOption.Size = New System.Drawing.Size(66, 13)
        Me.lblYearOption.TabIndex = 2
        Me.lblYearOption.Text = "Year Option:"
        '
        'lblMonthOption
        '
        Me.lblMonthOption.AutoSize = True
        Me.lblMonthOption.Location = New System.Drawing.Point(116, 59)
        Me.lblMonthOption.Name = "lblMonthOption"
        Me.lblMonthOption.Size = New System.Drawing.Size(74, 13)
        Me.lblMonthOption.TabIndex = 6
        Me.lblMonthOption.Text = "Month Option:"
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthOption.IsReadOnly = False
        Me.ucrInputMonthOption.Location = New System.Drawing.Point(119, 74)
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        Me.ucrInputMonthOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputMonthOption.TabIndex = 7
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.AddQuotesIfUnrecognised = True
        Me.ucrInputYearOption.IsReadOnly = False
        Me.ucrInputYearOption.Location = New System.Drawing.Point(119, 32)
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        Me.ucrInputYearOption.Size = New System.Drawing.Size(99, 21)
        Me.ucrInputYearOption.TabIndex = 3
        '
        'lblDayofMonth
        '
        Me.lblDayofMonth.AutoSize = True
        Me.lblDayofMonth.Location = New System.Drawing.Point(7, 103)
        Me.lblDayofMonth.Name = "lblDayofMonth"
        Me.lblDayofMonth.Size = New System.Drawing.Size(74, 13)
        Me.lblDayofMonth.TabIndex = 8
        Me.lblDayofMonth.Text = "Day of Month:"
        '
        'lblMonthThree
        '
        Me.lblMonthThree.AutoSize = True
        Me.lblMonthThree.Location = New System.Drawing.Point(7, 60)
        Me.lblMonthThree.Name = "lblMonthThree"
        Me.lblMonthThree.Size = New System.Drawing.Size(40, 13)
        Me.lblMonthThree.TabIndex = 4
        Me.lblMonthThree.Text = "Month:"
        '
        'lblYearThree
        '
        Me.lblYearThree.AutoSize = True
        Me.lblYearThree.Location = New System.Drawing.Point(7, 19)
        Me.lblYearThree.Name = "lblYearThree"
        Me.lblYearThree.Size = New System.Drawing.Size(32, 13)
        Me.lblYearThree.TabIndex = 0
        Me.lblYearThree.Text = "Year:"
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Me
        Me.ucrReceiverYearThree.Location = New System.Drawing.Point(6, 34)
        Me.ucrReceiverYearThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.TabIndex = 1
        Me.ucrReceiverYearThree.ucrSelector = Nothing
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.frmParent = Me
        Me.ucrReceiverDayThree.Location = New System.Drawing.Point(6, 117)
        Me.ucrReceiverDayThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverDayThree.strNcFilePath = ""
        Me.ucrReceiverDayThree.TabIndex = 9
        Me.ucrReceiverDayThree.ucrSelector = Nothing
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.frmParent = Me
        Me.ucrReceiverMonthThree.Location = New System.Drawing.Point(6, 74)
        Me.ucrReceiverMonthThree.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.Size = New System.Drawing.Size(95, 20)
        Me.ucrReceiverMonthThree.strNcFilePath = ""
        Me.ucrReceiverMonthThree.TabIndex = 5
        Me.ucrReceiverMonthThree.ucrSelector = Nothing
        '
        'rdoThreeColumns
        '
        Me.rdoThreeColumns.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoThreeColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatAppearance.BorderSize = 2
        Me.rdoThreeColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoThreeColumns.Location = New System.Drawing.Point(315, 11)
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
        Me.rdoTwoColumns.Location = New System.Drawing.Point(180, 11)
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
        Me.rdoSingleColumn.Location = New System.Drawing.Point(45, 11)
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.Size = New System.Drawing.Size(137, 28)
        Me.rdoSingleColumn.TabIndex = 1
        Me.rdoSingleColumn.Text = "Single Column"
        Me.rdoSingleColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'grpFormats
        '
        Me.grpFormats.Controls.Add(Me.txtTextDateFormats)
        Me.grpFormats.Location = New System.Drawing.Point(258, 197)
        Me.grpFormats.Name = "grpFormats"
        Me.grpFormats.Size = New System.Drawing.Size(252, 174)
        Me.grpFormats.TabIndex = 10
        Me.grpFormats.TabStop = False
        Me.grpFormats.Text = "Format Description"
        '
        'txtTextDateFormats
        '
        Me.txtTextDateFormats.Location = New System.Drawing.Point(10, 17)
        Me.txtTextDateFormats.Name = "txtTextDateFormats"
        Me.txtTextDateFormats.Size = New System.Drawing.Size(241, 144)
        Me.txtTextDateFormats.TabIndex = 0
        Me.txtTextDateFormats.Text = resources.GetString("txtTextDateFormats.Text")
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(426, 377)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(78, 22)
        Me.cmdHelp.TabIndex = 11
        Me.cmdHelp.Text = "Help..."
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrPnlDate
        '
        Me.ucrPnlDate.Location = New System.Drawing.Point(33, 7)
        Me.ucrPnlDate.Name = "ucrPnlDate"
        Me.ucrPnlDate.Size = New System.Drawing.Size(450, 35)
        Me.ucrPnlDate.TabIndex = 0
        '
        'ucrSaveDate
        '
        Me.ucrSaveDate.Location = New System.Drawing.Point(10, 377)
        Me.ucrSaveDate.Name = "ucrSaveDate"
        Me.ucrSaveDate.Size = New System.Drawing.Size(237, 24)
        Me.ucrSaveDate.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 407)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(417, 54)
        Me.ucrBase.TabIndex = 1
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        Me.ucrSelectorMakeDate.Location = New System.Drawing.Point(10, 51)
        Me.ucrSelectorMakeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        Me.ucrSelectorMakeDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorMakeDate.TabIndex = 7
        '
        'dlgMakeDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 466)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.grpFormats)
        Me.Controls.Add(Me.rdoThreeColumns)
        Me.Controls.Add(Me.rdoTwoColumns)
        Me.Controls.Add(Me.rdoSingleColumn)
        Me.Controls.Add(Me.ucrPnlDate)
        Me.Controls.Add(Me.ucrSaveDate)
        Me.Controls.Add(Me.grpSingleColumn)
        Me.Controls.Add(Me.grpTwoColumns)
        Me.Controls.Add(Me.grpThreeColumns)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorMakeDate)
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
        Me.grpFormatField.ResumeLayout(False)
        Me.grpFormatField.PerformLayout()
        Me.grpThreeColumns.ResumeLayout(False)
        Me.grpThreeColumns.PerformLayout()
        Me.grpFormats.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents lblYearOption As Label
    Friend WithEvents lblMonthOption As Label
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
    Friend WithEvents rdoThreeColumns As RadioButton
    Friend WithEvents rdoTwoColumns As RadioButton
    Friend WithEvents rdoSingleColumn As RadioButton
    Friend WithEvents ucrPnlDate As UcrPanel
    Friend WithEvents grpFormats As GroupBox
    Friend WithEvents txtTextDateFormats As RichTextBox
    Friend WithEvents cmdHelp As Button
    Friend WithEvents ttMakeDate As ToolTip
End Class