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
        resources.ApplyResources(Me.grpTwoColumns, "grpTwoColumns")
        Me.grpTwoColumns.Name = "grpTwoColumns"
        Me.grpTwoColumns.TabStop = False
        '
        'ucrChkTwoDigitYear
        '
        Me.ucrChkTwoDigitYear.Checked = False
        resources.ApplyResources(Me.ucrChkTwoDigitYear, "ucrChkTwoDigitYear")
        Me.ucrChkTwoDigitYear.Name = "ucrChkTwoDigitYear"
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCutoff, "ucrNudCutoff")
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCutOffTwo
        '
        resources.ApplyResources(Me.lblCutOffTwo, "lblCutOffTwo")
        Me.lblCutOffTwo.Name = "lblCutOffTwo"
        '
        'ucrInputComboBoxMonthTwo
        '
        Me.ucrInputComboBoxMonthTwo.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonthTwo.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxMonthTwo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxMonthTwo, "ucrInputComboBoxMonthTwo")
        Me.ucrInputComboBoxMonthTwo.Name = "ucrInputComboBoxMonthTwo"
        '
        'lblYearTwo
        '
        resources.ApplyResources(Me.lblYearTwo, "lblYearTwo")
        Me.lblYearTwo.Name = "lblYearTwo"
        '
        'ucrReceiverYearTwo
        '
        Me.ucrReceiverYearTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearTwo, "ucrReceiverYearTwo")
        Me.ucrReceiverYearTwo.Name = "ucrReceiverYearTwo"
        Me.ucrReceiverYearTwo.Selector = Nothing
        Me.ucrReceiverYearTwo.strNcFilePath = ""
        Me.ucrReceiverYearTwo.ucrSelector = Nothing
        '
        'lblDayofYear
        '
        resources.ApplyResources(Me.lblDayofYear, "lblDayofYear")
        Me.lblDayofYear.Name = "lblDayofYear"
        '
        'ucrReceiverDayTwo
        '
        Me.ucrReceiverDayTwo.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayTwo, "ucrReceiverDayTwo")
        Me.ucrReceiverDayTwo.Name = "ucrReceiverDayTwo"
        Me.ucrReceiverDayTwo.Selector = Nothing
        Me.ucrReceiverDayTwo.strNcFilePath = ""
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
        resources.ApplyResources(Me.grpSingleColumn, "grpSingleColumn")
        Me.grpSingleColumn.Name = "grpSingleColumn"
        Me.grpSingleColumn.TabStop = False
        '
        'grpFormats
        '
        Me.grpFormats.Controls.Add(Me.txtTextDateFormats)
        resources.ApplyResources(Me.grpFormats, "grpFormats")
        Me.grpFormats.Name = "grpFormats"
        Me.grpFormats.TabStop = False
        '
        'txtTextDateFormats
        '
        resources.ApplyResources(Me.txtTextDateFormats, "txtTextDateFormats")
        Me.txtTextDateFormats.Name = "txtTextDateFormats"
        '
        'lblUnits
        '
        resources.ApplyResources(Me.lblUnits, "lblUnits")
        Me.lblUnits.Name = "lblUnits"
        '
        'ucrDtpSpecifyOrigin
        '
        Me.ucrDtpSpecifyOrigin.DateValue = New Date(2021, 5, 19, 13, 56, 22, 794)
        Me.ucrDtpSpecifyOrigin.Format = "dd MMM yyyy"
        resources.ApplyResources(Me.ucrDtpSpecifyOrigin, "ucrDtpSpecifyOrigin")
        Me.ucrDtpSpecifyOrigin.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.ucrDtpSpecifyOrigin.MinDate = New Date(1753, 2, 1, 0, 0, 0, 0)
        Me.ucrDtpSpecifyOrigin.Name = "ucrDtpSpecifyOrigin"
        '
        'ucrInputUnits
        '
        Me.ucrInputUnits.AddQuotesIfUnrecognised = True
        Me.ucrInputUnits.GetSetSelectedIndex = -1
        Me.ucrInputUnits.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputUnits, "ucrInputUnits")
        Me.ucrInputUnits.Name = "ucrInputUnits"
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
        resources.ApplyResources(Me.grpFormatField, "grpFormatField")
        Me.grpFormatField.Name = "grpFormatField"
        Me.grpFormatField.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox1, "UcrInputComboBox1")
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.GetSetSelectedIndex = -1
        Me.UcrInputComboBox2.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox2, "UcrInputComboBox2")
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.GetSetSelectedIndex = -1
        Me.UcrInputComboBox3.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox3, "UcrInputComboBox3")
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        '
        'UcrInputComboBox4
        '
        Me.UcrInputComboBox4.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox4.GetSetSelectedIndex = -1
        Me.UcrInputComboBox4.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox4, "UcrInputComboBox4")
        Me.UcrInputComboBox4.Name = "UcrInputComboBox4"
        '
        'rdoSpecifyFormat
        '
        resources.ApplyResources(Me.rdoSpecifyFormat, "rdoSpecifyFormat")
        Me.rdoSpecifyFormat.Name = "rdoSpecifyFormat"
        Me.rdoSpecifyFormat.TabStop = True
        Me.rdoSpecifyFormat.UseVisualStyleBackColor = True
        '
        'rdoOrigin
        '
        resources.ApplyResources(Me.rdoOrigin, "rdoOrigin")
        Me.rdoOrigin.Name = "rdoOrigin"
        Me.rdoOrigin.TabStop = True
        Me.rdoOrigin.UseVisualStyleBackColor = True
        '
        'rdoDefaultFormat
        '
        resources.ApplyResources(Me.rdoDefaultFormat, "rdoDefaultFormat")
        Me.rdoDefaultFormat.Name = "rdoDefaultFormat"
        Me.rdoDefaultFormat.TabStop = True
        Me.rdoDefaultFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlFormat
        '
        resources.ApplyResources(Me.ucrPnlFormat, "ucrPnlFormat")
        Me.ucrPnlFormat.Name = "ucrPnlFormat"
        '
        'ucrReceiverForDate
        '
        Me.ucrReceiverForDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverForDate, "ucrReceiverForDate")
        Me.ucrReceiverForDate.Name = "ucrReceiverForDate"
        Me.ucrReceiverForDate.Selector = Nothing
        Me.ucrReceiverForDate.strNcFilePath = ""
        Me.ucrReceiverForDate.ucrSelector = Nothing
        '
        'ucrInputFormat
        '
        Me.ucrInputFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputFormat.GetSetSelectedIndex = -1
        Me.ucrInputFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFormat, "ucrInputFormat")
        Me.ucrInputFormat.Name = "ucrInputFormat"
        '
        'ucrInputOrigin
        '
        Me.ucrInputOrigin.AddQuotesIfUnrecognised = True
        Me.ucrInputOrigin.GetSetSelectedIndex = -1
        Me.ucrInputOrigin.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputOrigin, "ucrInputOrigin")
        Me.ucrInputOrigin.Name = "ucrInputOrigin"
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
        resources.ApplyResources(Me.grpThreeColumns, "grpThreeColumns")
        Me.grpThreeColumns.Name = "grpThreeColumns"
        Me.grpThreeColumns.TabStop = False
        '
        'ucrInputDayThree
        '
        Me.ucrInputDayThree.AddQuotesIfUnrecognised = True
        Me.ucrInputDayThree.IsMultiline = False
        Me.ucrInputDayThree.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDayThree, "ucrInputDayThree")
        Me.ucrInputDayThree.Name = "ucrInputDayThree"
        '
        'rdoDayValue
        '
        resources.ApplyResources(Me.rdoDayValue, "rdoDayValue")
        Me.rdoDayValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayValue.FlatAppearance.BorderSize = 2
        Me.rdoDayValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayValue.Name = "rdoDayValue"
        Me.rdoDayValue.TabStop = True
        Me.rdoDayValue.UseVisualStyleBackColor = True
        '
        'rdoDayColumn
        '
        resources.ApplyResources(Me.rdoDayColumn, "rdoDayColumn")
        Me.rdoDayColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayColumn.FlatAppearance.BorderSize = 2
        Me.rdoDayColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDayColumn.Name = "rdoDayColumn"
        Me.rdoDayColumn.TabStop = True
        Me.rdoDayColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlDayType
        '
        resources.ApplyResources(Me.ucrPnlDayType, "ucrPnlDayType")
        Me.ucrPnlDayType.Name = "ucrPnlDayType"
        '
        'ucrInputYearThree
        '
        Me.ucrInputYearThree.AddQuotesIfUnrecognised = True
        Me.ucrInputYearThree.IsMultiline = False
        Me.ucrInputYearThree.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYearThree, "ucrInputYearThree")
        Me.ucrInputYearThree.Name = "ucrInputYearThree"
        '
        'rdoYearValue
        '
        resources.ApplyResources(Me.rdoYearValue, "rdoYearValue")
        Me.rdoYearValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearValue.FlatAppearance.BorderSize = 2
        Me.rdoYearValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearValue.Name = "rdoYearValue"
        Me.rdoYearValue.TabStop = True
        Me.rdoYearValue.UseVisualStyleBackColor = True
        '
        'rdoYearColumn
        '
        resources.ApplyResources(Me.rdoYearColumn, "rdoYearColumn")
        Me.rdoYearColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearColumn.FlatAppearance.BorderSize = 2
        Me.rdoYearColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYearColumn.Name = "rdoYearColumn"
        Me.rdoYearColumn.TabStop = True
        Me.rdoYearColumn.UseVisualStyleBackColor = True
        '
        'rdoMonthValue
        '
        resources.ApplyResources(Me.rdoMonthValue, "rdoMonthValue")
        Me.rdoMonthValue.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthValue.FlatAppearance.BorderSize = 2
        Me.rdoMonthValue.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthValue.Name = "rdoMonthValue"
        Me.rdoMonthValue.TabStop = True
        Me.rdoMonthValue.UseVisualStyleBackColor = True
        '
        'rdoMonthColumn
        '
        resources.ApplyResources(Me.rdoMonthColumn, "rdoMonthColumn")
        Me.rdoMonthColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthColumn.FlatAppearance.BorderSize = 2
        Me.rdoMonthColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoMonthColumn.Name = "rdoMonthColumn"
        Me.rdoMonthColumn.TabStop = True
        Me.rdoMonthColumn.UseVisualStyleBackColor = True
        '
        'ucrInputMonthThree
        '
        Me.ucrInputMonthThree.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthThree.IsMultiline = False
        Me.ucrInputMonthThree.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMonthThree, "ucrInputMonthThree")
        Me.ucrInputMonthThree.Name = "ucrInputMonthThree"
        '
        'lblYearFormat
        '
        resources.ApplyResources(Me.lblYearFormat, "lblYearFormat")
        Me.lblYearFormat.Name = "lblYearFormat"
        '
        'lblMonthFormat
        '
        resources.ApplyResources(Me.lblMonthFormat, "lblMonthFormat")
        Me.lblMonthFormat.Name = "lblMonthFormat"
        '
        'ucrInputMonthOption
        '
        Me.ucrInputMonthOption.AddQuotesIfUnrecognised = True
        Me.ucrInputMonthOption.GetSetSelectedIndex = -1
        Me.ucrInputMonthOption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMonthOption, "ucrInputMonthOption")
        Me.ucrInputMonthOption.Name = "ucrInputMonthOption"
        '
        'ucrInputYearOption
        '
        Me.ucrInputYearOption.AddQuotesIfUnrecognised = True
        Me.ucrInputYearOption.GetSetSelectedIndex = -1
        Me.ucrInputYearOption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYearOption, "ucrInputYearOption")
        Me.ucrInputYearOption.Name = "ucrInputYearOption"
        '
        'lblDayofMonth
        '
        resources.ApplyResources(Me.lblDayofMonth, "lblDayofMonth")
        Me.lblDayofMonth.Name = "lblDayofMonth"
        '
        'lblMonthThree
        '
        resources.ApplyResources(Me.lblMonthThree, "lblMonthThree")
        Me.lblMonthThree.Name = "lblMonthThree"
        '
        'lblYearThree
        '
        resources.ApplyResources(Me.lblYearThree, "lblYearThree")
        Me.lblYearThree.Name = "lblYearThree"
        '
        'ucrReceiverYearThree
        '
        Me.ucrReceiverYearThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverYearThree, "ucrReceiverYearThree")
        Me.ucrReceiverYearThree.Name = "ucrReceiverYearThree"
        Me.ucrReceiverYearThree.Selector = Nothing
        Me.ucrReceiverYearThree.strNcFilePath = ""
        Me.ucrReceiverYearThree.ucrSelector = Nothing
        '
        'ucrReceiverDayThree
        '
        Me.ucrReceiverDayThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverDayThree, "ucrReceiverDayThree")
        Me.ucrReceiverDayThree.Name = "ucrReceiverDayThree"
        Me.ucrReceiverDayThree.Selector = Nothing
        Me.ucrReceiverDayThree.strNcFilePath = ""
        Me.ucrReceiverDayThree.ucrSelector = Nothing
        '
        'ucrReceiverMonthThree
        '
        Me.ucrReceiverMonthThree.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverMonthThree, "ucrReceiverMonthThree")
        Me.ucrReceiverMonthThree.Name = "ucrReceiverMonthThree"
        Me.ucrReceiverMonthThree.Selector = Nothing
        Me.ucrReceiverMonthThree.strNcFilePath = ""
        Me.ucrReceiverMonthThree.ucrSelector = Nothing
        '
        'ucrPnlYearType
        '
        resources.ApplyResources(Me.ucrPnlYearType, "ucrPnlYearType")
        Me.ucrPnlYearType.Name = "ucrPnlYearType"
        '
        'ucrPnlMonthType
        '
        resources.ApplyResources(Me.ucrPnlMonthType, "ucrPnlMonthType")
        Me.ucrPnlMonthType.Name = "ucrPnlMonthType"
        '
        'rdoThreeColumns
        '
        resources.ApplyResources(Me.rdoThreeColumns, "rdoThreeColumns")
        Me.rdoThreeColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.FlatAppearance.BorderSize = 2
        Me.rdoThreeColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoThreeColumns.Name = "rdoThreeColumns"
        Me.rdoThreeColumns.UseVisualStyleBackColor = True
        '
        'rdoTwoColumns
        '
        resources.ApplyResources(Me.rdoTwoColumns, "rdoTwoColumns")
        Me.rdoTwoColumns.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.FlatAppearance.BorderSize = 2
        Me.rdoTwoColumns.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTwoColumns.Name = "rdoTwoColumns"
        Me.rdoTwoColumns.UseVisualStyleBackColor = True
        '
        'rdoSingleColumn
        '
        resources.ApplyResources(Me.rdoSingleColumn, "rdoSingleColumn")
        Me.rdoSingleColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.FlatAppearance.BorderSize = 2
        Me.rdoSingleColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSingleColumn.Name = "rdoSingleColumn"
        Me.rdoSingleColumn.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'ucrPnlDate
        '
        resources.ApplyResources(Me.ucrPnlDate, "ucrPnlDate")
        Me.ucrPnlDate.Name = "ucrPnlDate"
        '
        'ucrSaveDate
        '
        resources.ApplyResources(Me.ucrSaveDate, "ucrSaveDate")
        Me.ucrSaveDate.Name = "ucrSaveDate"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorMakeDate
        '
        Me.ucrSelectorMakeDate.bDropUnusedFilterLevels = False
        Me.ucrSelectorMakeDate.bShowHiddenColumns = False
        Me.ucrSelectorMakeDate.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorMakeDate, "ucrSelectorMakeDate")
        Me.ucrSelectorMakeDate.Name = "ucrSelectorMakeDate"
        '
        'dlgMakeDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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