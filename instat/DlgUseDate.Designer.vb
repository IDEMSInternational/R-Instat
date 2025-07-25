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
Partial Class dlgUseDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUseDate))
        Me.lblDateVariable = New System.Windows.Forms.Label()
        Me.ttYearNumeric = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDayinYear366 = New System.Windows.Forms.Label()
        Me.lblShiftYear = New System.Windows.Forms.Label()
        Me.lblShiftMonth = New System.Windows.Forms.Label()
        Me.lblShiftPentad = New System.Windows.Forms.Label()
        Me.lblDayInYear = New System.Windows.Forms.Label()
        Me.lblShiftNumeric = New System.Windows.Forms.Label()
        Me.lblShiftQuarter = New System.Windows.Forms.Label()
        Me.lblShiftAbbr = New System.Windows.Forms.Label()
        Me.lblShiftDekad = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDaysInMonth = New System.Windows.Forms.Label()
        Me.lblDayInMonth = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.lblWeekDay = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLeapYear = New System.Windows.Forms.Label()
        Me.lblAbbr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblShifted = New System.Windows.Forms.Label()
        Me.lblShiftStartingMonth = New System.Windows.Forms.Label()
        Me.Panelformatmode = New System.Windows.Forms.Panel()
        Me.grpfrmdescrp = New System.Windows.Forms.GroupBox()
        Me.txtTextDateFormats = New System.Windows.Forms.RichTextBox()
        Me.rdoUseColumn = New System.Windows.Forms.RadioButton()
        Me.rdoFormatColumn = New System.Windows.Forms.RadioButton()
        Me.ComboBoxnewformat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpUseColumnnewfrm = New System.Windows.Forms.GroupBox()
        Me.Panelusemode = New System.Windows.Forms.Panel()
        Me.ucrInputComboBoxStartingMonth = New instat.ucrInputComboBox()
        Me.ucrChkShiftDekadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftPentadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftDekadNum = New instat.ucrCheck()
        Me.ucrChkShiftQuarterAbbr = New instat.ucrCheck()
        Me.ucrChkShiftPentadNum = New instat.ucrCheck()
        Me.ucrChkShiftQuarterNum = New instat.ucrCheck()
        Me.ucrChkDayInYearNum = New instat.ucrCheck()
        Me.ucrChkShiftDayInYearNum366 = New instat.ucrCheck()
        Me.ucrChkShiftMonthName = New instat.ucrCheck()
        Me.ucrChkShiftMonthNum = New instat.ucrCheck()
        Me.ucrChkShiftMonthAbbr = New instat.ucrCheck()
        Me.ucrChkShiftYearNum = New instat.ucrCheck()
        Me.ucrChkShiftYearName = New instat.ucrCheck()
        Me.ucrChkDaysInMonthNum = New instat.ucrCheck()
        Me.ucrChkWeekdayName = New instat.ucrCheck()
        Me.ucrChkWeekdayAbbr = New instat.ucrCheck()
        Me.ucrChkWeekdayNum = New instat.ucrCheck()
        Me.ucrChkLeapYearNum = New instat.ucrCheck()
        Me.ucrChkWeekAbbr = New instat.ucrCheck()
        Me.ucrChkWeekName = New instat.ucrCheck()
        Me.ucrChkWeekNum = New instat.ucrCheck()
        Me.ucrChkDayInMonthNum = New instat.ucrCheck()
        Me.ucrPnluseformat = New instat.UcrPanel()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panelformatmode.SuspendLayout()
        Me.grpfrmdescrp.SuspendLayout()
        Me.grpUseColumnnewfrm.SuspendLayout()
        Me.Panelusemode.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        Me.lblDateVariable.AutoSize = True
        Me.lblDateVariable.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDateVariable.Location = New System.Drawing.Point(251, 65)
        Me.lblDateVariable.Name = "lblDateVariable"
        Me.lblDateVariable.Size = New System.Drawing.Size(33, 13)
        Me.lblDateVariable.TabIndex = 2
        Me.lblDateVariable.Text = "Date:"
        '
        'lblDayinYear366
        '
        Me.lblDayinYear366.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDayinYear366.AutoSize = True
        Me.lblDayinYear366.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayinYear366.Location = New System.Drawing.Point(151, 35)
        Me.lblDayinYear366.Name = "lblDayinYear366"
        Me.lblDayinYear366.Size = New System.Drawing.Size(56, 26)
        Me.lblDayinYear366.TabIndex = 6
        Me.lblDayinYear366.Text = "Day in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year (366)"
        '
        'lblShiftYear
        '
        Me.lblShiftYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftYear.AutoSize = True
        Me.lblShiftYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftYear.Location = New System.Drawing.Point(60, 48)
        Me.lblShiftYear.Name = "lblShiftYear"
        Me.lblShiftYear.Size = New System.Drawing.Size(29, 13)
        Me.lblShiftYear.TabIndex = 4
        Me.lblShiftYear.Text = "Year"
        '
        'lblShiftMonth
        '
        Me.lblShiftMonth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftMonth.AutoSize = True
        Me.lblShiftMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftMonth.Location = New System.Drawing.Point(106, 48)
        Me.lblShiftMonth.Name = "lblShiftMonth"
        Me.lblShiftMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblShiftMonth.TabIndex = 5
        Me.lblShiftMonth.Text = "Month"
        '
        'lblShiftPentad
        '
        Me.lblShiftPentad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftPentad.AutoSize = True
        Me.lblShiftPentad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftPentad.Location = New System.Drawing.Point(343, 48)
        Me.lblShiftPentad.Name = "lblShiftPentad"
        Me.lblShiftPentad.Size = New System.Drawing.Size(41, 13)
        Me.lblShiftPentad.TabIndex = 9
        Me.lblShiftPentad.Text = "Pentad"
        '
        'lblDayInYear
        '
        Me.lblDayInYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDayInYear.AutoSize = True
        Me.lblDayInYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayInYear.Location = New System.Drawing.Point(218, 35)
        Me.lblDayInYear.Name = "lblDayInYear"
        Me.lblDayInYear.Size = New System.Drawing.Size(56, 26)
        Me.lblDayInYear.TabIndex = 7
        Me.lblDayInYear.Text = "Day in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year (365)"
        '
        'lblShiftNumeric
        '
        Me.lblShiftNumeric.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftNumeric.AutoSize = True
        Me.lblShiftNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftNumeric.Location = New System.Drawing.Point(7, 78)
        Me.lblShiftNumeric.Name = "lblShiftNumeric"
        Me.lblShiftNumeric.Size = New System.Drawing.Size(49, 13)
        Me.lblShiftNumeric.TabIndex = 11
        Me.lblShiftNumeric.Text = "Numeric:"
        '
        'lblShiftQuarter
        '
        Me.lblShiftQuarter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftQuarter.AutoSize = True
        Me.lblShiftQuarter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftQuarter.Location = New System.Drawing.Point(282, 48)
        Me.lblShiftQuarter.Name = "lblShiftQuarter"
        Me.lblShiftQuarter.Size = New System.Drawing.Size(42, 13)
        Me.lblShiftQuarter.TabIndex = 8
        Me.lblShiftQuarter.Text = "Quarter"
        '
        'lblShiftAbbr
        '
        Me.lblShiftAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftAbbr.AutoSize = True
        Me.lblShiftAbbr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftAbbr.Location = New System.Drawing.Point(10, 106)
        Me.lblShiftAbbr.Name = "lblShiftAbbr"
        Me.lblShiftAbbr.Size = New System.Drawing.Size(35, 13)
        Me.lblShiftAbbr.TabIndex = 20
        Me.lblShiftAbbr.Text = "Abbr.:"
        '
        'lblShiftDekad
        '
        Me.lblShiftDekad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShiftDekad.AutoSize = True
        Me.lblShiftDekad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftDekad.Location = New System.Drawing.Point(390, 48)
        Me.lblShiftDekad.Name = "lblShiftDekad"
        Me.lblShiftDekad.Size = New System.Drawing.Size(39, 13)
        Me.lblShiftDekad.TabIndex = 10
        Me.lblShiftDekad.Text = "Dekad"
        '
        'lblShift
        '
        Me.lblShift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblShift.AutoSize = True
        Me.lblShift.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShift.Location = New System.Drawing.Point(10, 135)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(38, 13)
        Me.lblShift.TabIndex = 25
        Me.lblShift.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ucrChkDaysInMonthNum)
        Me.GroupBox2.Controls.Add(Me.lblDaysInMonth)
        Me.GroupBox2.Controls.Add(Me.lblDayInMonth)
        Me.GroupBox2.Controls.Add(Me.lblNumeric)
        Me.GroupBox2.Controls.Add(Me.lblWeek)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayName)
        Me.GroupBox2.Controls.Add(Me.lblWeekDay)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayAbbr)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.lblLeapYear)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayNum)
        Me.GroupBox2.Controls.Add(Me.ucrChkLeapYearNum)
        Me.GroupBox2.Controls.Add(Me.lblAbbr)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekAbbr)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekName)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekNum)
        Me.GroupBox2.Controls.Add(Me.ucrChkDayInMonthNum)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 110)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        '
        'lblDaysInMonth
        '
        Me.lblDaysInMonth.AutoSize = True
        Me.lblDaysInMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDaysInMonth.Location = New System.Drawing.Point(369, 12)
        Me.lblDaysInMonth.Name = "lblDaysInMonth"
        Me.lblDaysInMonth.Size = New System.Drawing.Size(75, 13)
        Me.lblDaysInMonth.TabIndex = 4
        Me.lblDaysInMonth.Text = "Days in Month"
        '
        'lblDayInMonth
        '
        Me.lblDayInMonth.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDayInMonth.AutoSize = True
        Me.lblDayInMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDayInMonth.Location = New System.Drawing.Point(48, 8)
        Me.lblDayInMonth.Name = "lblDayInMonth"
        Me.lblDayInMonth.Size = New System.Drawing.Size(70, 13)
        Me.lblDayInMonth.TabIndex = 0
        Me.lblDayInMonth.Text = "Day in Month"
        '
        'lblNumeric
        '
        Me.lblNumeric.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNumeric.AutoSize = True
        Me.lblNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNumeric.Location = New System.Drawing.Point(6, 32)
        Me.lblNumeric.Name = "lblNumeric"
        Me.lblNumeric.Size = New System.Drawing.Size(49, 13)
        Me.lblNumeric.TabIndex = 5
        Me.lblNumeric.Text = "Numeric:"
        '
        'lblWeek
        '
        Me.lblWeek.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeek.AutoSize = True
        Me.lblWeek.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeek.Location = New System.Drawing.Point(133, 8)
        Me.lblWeek.Name = "lblWeek"
        Me.lblWeek.Size = New System.Drawing.Size(36, 13)
        Me.lblWeek.TabIndex = 1
        Me.lblWeek.Text = "Week"
        '
        'lblWeekDay
        '
        Me.lblWeekDay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWeekDay.AutoSize = True
        Me.lblWeekDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeekDay.Location = New System.Drawing.Point(186, 8)
        Me.lblWeekDay.Name = "lblWeekDay"
        Me.lblWeekDay.Size = New System.Drawing.Size(58, 13)
        Me.lblWeekDay.TabIndex = 2
        Me.lblWeekDay.Text = "Week Day"
        '
        'lblName
        '
        Me.lblName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblName.AutoSize = True
        Me.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblName.Location = New System.Drawing.Point(6, 88)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name:"
        '
        'lblLeapYear
        '
        Me.lblLeapYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblLeapYear.AutoSize = True
        Me.lblLeapYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLeapYear.Location = New System.Drawing.Point(281, 8)
        Me.lblLeapYear.Name = "lblLeapYear"
        Me.lblLeapYear.Size = New System.Drawing.Size(56, 13)
        Me.lblLeapYear.TabIndex = 3
        Me.lblLeapYear.Text = "Leap Year"
        '
        'lblAbbr
        '
        Me.lblAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAbbr.AutoSize = True
        Me.lblAbbr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAbbr.Location = New System.Drawing.Point(6, 60)
        Me.lblAbbr.Name = "lblAbbr"
        Me.lblAbbr.Size = New System.Drawing.Size(35, 13)
        Me.lblAbbr.TabIndex = 11
        Me.lblAbbr.Text = "Abbr.:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShifted)
        Me.GroupBox1.Controls.Add(Me.ucrInputComboBoxStartingMonth)
        Me.GroupBox1.Controls.Add(Me.lblShiftStartingMonth)
        Me.GroupBox1.Controls.Add(Me.lblShiftYear)
        Me.GroupBox1.Controls.Add(Me.lblShiftMonth)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDekadAbbr)
        Me.GroupBox1.Controls.Add(Me.lblDayinYear366)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftPentadAbbr)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDekadNum)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftQuarterAbbr)
        Me.GroupBox1.Controls.Add(Me.lblDayInYear)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftPentadNum)
        Me.GroupBox1.Controls.Add(Me.lblShiftQuarter)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftQuarterNum)
        Me.GroupBox1.Controls.Add(Me.lblShiftPentad)
        Me.GroupBox1.Controls.Add(Me.ucrChkDayInYearNum)
        Me.GroupBox1.Controls.Add(Me.lblShiftDekad)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDayInYearNum366)
        Me.GroupBox1.Controls.Add(Me.lblShiftNumeric)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthName)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthNum)
        Me.GroupBox1.Controls.Add(Me.lblShiftAbbr)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthAbbr)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftYearNum)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftYearName)
        Me.GroupBox1.Controls.Add(Me.lblShift)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 165)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'lblShifted
        '
        Me.lblShifted.AutoSize = True
        Me.lblShifted.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShifted.Location = New System.Drawing.Point(219, 19)
        Me.lblShifted.Name = "lblShifted"
        Me.lblShifted.Size = New System.Drawing.Size(40, 13)
        Me.lblShifted.TabIndex = 2
        Me.lblShifted.Text = "Shifted"
        '
        'lblShiftStartingMonth
        '
        Me.lblShiftStartingMonth.AutoSize = True
        Me.lblShiftStartingMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblShiftStartingMonth.Location = New System.Drawing.Point(8, 16)
        Me.lblShiftStartingMonth.Name = "lblShiftStartingMonth"
        Me.lblShiftStartingMonth.Size = New System.Drawing.Size(79, 13)
        Me.lblShiftStartingMonth.TabIndex = 0
        Me.lblShiftStartingMonth.Text = "Starting Month:"
        '
        'Panelformatmode
        '
        Me.Panelformatmode.Controls.Add(Me.grpfrmdescrp)
        Me.Panelformatmode.Location = New System.Drawing.Point(10, 222)
        Me.Panelformatmode.Name = "Panelformatmode"
        Me.Panelformatmode.Size = New System.Drawing.Size(468, 282)
        Me.Panelformatmode.TabIndex = 28
        '
        'grpfrmdescrp
        '
        Me.grpfrmdescrp.Controls.Add(Me.txtTextDateFormats)
        Me.grpfrmdescrp.Location = New System.Drawing.Point(10, 15)
        Me.grpfrmdescrp.Name = "grpfrmdescrp"
        Me.grpfrmdescrp.Size = New System.Drawing.Size(440, 225)
        Me.grpfrmdescrp.TabIndex = 28
        Me.grpfrmdescrp.TabStop = False
        Me.grpfrmdescrp.Text = "Format Description"
        Me.grpfrmdescrp.Visible = False
        '
        'txtTextDateFormats
        '
        Me.txtTextDateFormats.Location = New System.Drawing.Point(6, 16)
        Me.txtTextDateFormats.Name = "txtTextDateFormats"
        Me.txtTextDateFormats.ReadOnly = True
        Me.txtTextDateFormats.Size = New System.Drawing.Size(416, 224)
        Me.txtTextDateFormats.TabIndex = 1
        Me.txtTextDateFormats.Text = resources.GetString("txtTextDateFormats.Text")
        '
        'rdoUseColumn
        '
        Me.rdoUseColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoUseColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUseColumn.FlatAppearance.BorderSize = 2
        Me.rdoUseColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoUseColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoUseColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoUseColumn.Location = New System.Drawing.Point(101, 12)
        Me.rdoUseColumn.Name = "rdoUseColumn"
        Me.rdoUseColumn.Size = New System.Drawing.Size(121, 28)
        Me.rdoUseColumn.TabIndex = 31
        Me.rdoUseColumn.Text = "Use "
        Me.rdoUseColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoUseColumn.UseVisualStyleBackColor = True
        '
        'rdoFormatColumn
        '
        Me.rdoFormatColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFormatColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFormatColumn.FlatAppearance.BorderSize = 2
        Me.rdoFormatColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFormatColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFormatColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFormatColumn.Location = New System.Drawing.Point(219, 12)
        Me.rdoFormatColumn.Name = "rdoFormatColumn"
        Me.rdoFormatColumn.Size = New System.Drawing.Size(136, 28)
        Me.rdoFormatColumn.TabIndex = 32
        Me.rdoFormatColumn.Text = "Format"
        Me.rdoFormatColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFormatColumn.UseVisualStyleBackColor = True
        '
        'ComboBoxnewformat
        '
        Me.ComboBoxnewformat.FormattingEnabled = True
        Me.ComboBoxnewformat.Location = New System.Drawing.Point(0, 13)
        Me.ComboBoxnewformat.Name = "ComboBoxnewformat"
        Me.ComboBoxnewformat.Size = New System.Drawing.Size(163, 21)
        Me.ComboBoxnewformat.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 34
        '
        'grpUseColumnnewfrm
        '
        Me.grpUseColumnnewfrm.Controls.Add(Me.ComboBoxnewformat)
        Me.grpUseColumnnewfrm.Controls.Add(Me.Label1)
        Me.grpUseColumnnewfrm.Location = New System.Drawing.Point(254, 115)
        Me.grpUseColumnnewfrm.Name = "grpUseColumnnewfrm"
        Me.grpUseColumnnewfrm.Size = New System.Drawing.Size(164, 34)
        Me.grpUseColumnnewfrm.TabIndex = 35
        Me.grpUseColumnnewfrm.TabStop = False
        Me.grpUseColumnnewfrm.Text = "New Format"
        '
        'Panelusemode
        '
        Me.Panelusemode.Controls.Add(Me.GroupBox1)
        Me.Panelusemode.Controls.Add(Me.GroupBox2)
        Me.Panelusemode.Location = New System.Drawing.Point(10, 222)
        Me.Panelusemode.Name = "Panelusemode"
        Me.Panelusemode.Size = New System.Drawing.Size(468, 282)
        Me.Panelusemode.TabIndex = 28
        '
        'ucrInputComboBoxStartingMonth
        '
        Me.ucrInputComboBoxStartingMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxStartingMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboBoxStartingMonth.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxStartingMonth.IsReadOnly = False
        Me.ucrInputComboBoxStartingMonth.Location = New System.Drawing.Point(98, 15)
        Me.ucrInputComboBoxStartingMonth.Margin = New System.Windows.Forms.Padding(9, 12, 9, 12)
        Me.ucrInputComboBoxStartingMonth.Name = "ucrInputComboBoxStartingMonth"
        Me.ucrInputComboBoxStartingMonth.Size = New System.Drawing.Size(114, 21)
        Me.ucrInputComboBoxStartingMonth.TabIndex = 1
        '
        'ucrChkShiftDekadAbbr
        '
        Me.ucrChkShiftDekadAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftDekadAbbr.AutoSize = True
        Me.ucrChkShiftDekadAbbr.Checked = False
        Me.ucrChkShiftDekadAbbr.Location = New System.Drawing.Point(409, 106)
        Me.ucrChkShiftDekadAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftDekadAbbr.Name = "ucrChkShiftDekadAbbr"
        Me.ucrChkShiftDekadAbbr.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftDekadAbbr.TabIndex = 24
        '
        'ucrChkShiftPentadAbbr
        '
        Me.ucrChkShiftPentadAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftPentadAbbr.AutoSize = True
        Me.ucrChkShiftPentadAbbr.Checked = False
        Me.ucrChkShiftPentadAbbr.Location = New System.Drawing.Point(351, 106)
        Me.ucrChkShiftPentadAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftPentadAbbr.Name = "ucrChkShiftPentadAbbr"
        Me.ucrChkShiftPentadAbbr.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftPentadAbbr.TabIndex = 23
        '
        'ucrChkShiftDekadNum
        '
        Me.ucrChkShiftDekadNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftDekadNum.AutoSize = True
        Me.ucrChkShiftDekadNum.Checked = False
        Me.ucrChkShiftDekadNum.Location = New System.Drawing.Point(409, 78)
        Me.ucrChkShiftDekadNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftDekadNum.Name = "ucrChkShiftDekadNum"
        Me.ucrChkShiftDekadNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftDekadNum.TabIndex = 18
        '
        'ucrChkShiftQuarterAbbr
        '
        Me.ucrChkShiftQuarterAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftQuarterAbbr.AutoSize = True
        Me.ucrChkShiftQuarterAbbr.Checked = False
        Me.ucrChkShiftQuarterAbbr.Location = New System.Drawing.Point(293, 106)
        Me.ucrChkShiftQuarterAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftQuarterAbbr.Name = "ucrChkShiftQuarterAbbr"
        Me.ucrChkShiftQuarterAbbr.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftQuarterAbbr.TabIndex = 22
        '
        'ucrChkShiftPentadNum
        '
        Me.ucrChkShiftPentadNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftPentadNum.AutoSize = True
        Me.ucrChkShiftPentadNum.Checked = False
        Me.ucrChkShiftPentadNum.Location = New System.Drawing.Point(351, 78)
        Me.ucrChkShiftPentadNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftPentadNum.Name = "ucrChkShiftPentadNum"
        Me.ucrChkShiftPentadNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftPentadNum.TabIndex = 17
        '
        'ucrChkShiftQuarterNum
        '
        Me.ucrChkShiftQuarterNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftQuarterNum.AutoSize = True
        Me.ucrChkShiftQuarterNum.Checked = False
        Me.ucrChkShiftQuarterNum.Location = New System.Drawing.Point(293, 78)
        Me.ucrChkShiftQuarterNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftQuarterNum.Name = "ucrChkShiftQuarterNum"
        Me.ucrChkShiftQuarterNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftQuarterNum.TabIndex = 16
        '
        'ucrChkDayInYearNum
        '
        Me.ucrChkDayInYearNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkDayInYearNum.AutoSize = True
        Me.ucrChkDayInYearNum.Checked = False
        Me.ucrChkDayInYearNum.Location = New System.Drawing.Point(224, 78)
        Me.ucrChkDayInYearNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDayInYearNum.Name = "ucrChkDayInYearNum"
        Me.ucrChkDayInYearNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkDayInYearNum.TabIndex = 15
        '
        'ucrChkShiftDayInYearNum366
        '
        Me.ucrChkShiftDayInYearNum366.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftDayInYearNum366.AutoSize = True
        Me.ucrChkShiftDayInYearNum366.Checked = False
        Me.ucrChkShiftDayInYearNum366.Location = New System.Drawing.Point(174, 78)
        Me.ucrChkShiftDayInYearNum366.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftDayInYearNum366.Name = "ucrChkShiftDayInYearNum366"
        Me.ucrChkShiftDayInYearNum366.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftDayInYearNum366.TabIndex = 14
        '
        'ucrChkShiftMonthName
        '
        Me.ucrChkShiftMonthName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftMonthName.AutoSize = True
        Me.ucrChkShiftMonthName.Checked = False
        Me.ucrChkShiftMonthName.Location = New System.Drawing.Point(119, 135)
        Me.ucrChkShiftMonthName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftMonthName.Name = "ucrChkShiftMonthName"
        Me.ucrChkShiftMonthName.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftMonthName.TabIndex = 27
        '
        'ucrChkShiftMonthNum
        '
        Me.ucrChkShiftMonthNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftMonthNum.AutoSize = True
        Me.ucrChkShiftMonthNum.Checked = False
        Me.ucrChkShiftMonthNum.Location = New System.Drawing.Point(119, 78)
        Me.ucrChkShiftMonthNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftMonthNum.Name = "ucrChkShiftMonthNum"
        Me.ucrChkShiftMonthNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftMonthNum.TabIndex = 13
        '
        'ucrChkShiftMonthAbbr
        '
        Me.ucrChkShiftMonthAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftMonthAbbr.AutoSize = True
        Me.ucrChkShiftMonthAbbr.Checked = False
        Me.ucrChkShiftMonthAbbr.Location = New System.Drawing.Point(119, 106)
        Me.ucrChkShiftMonthAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftMonthAbbr.Name = "ucrChkShiftMonthAbbr"
        Me.ucrChkShiftMonthAbbr.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftMonthAbbr.TabIndex = 21
        '
        'ucrChkShiftYearNum
        '
        Me.ucrChkShiftYearNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftYearNum.AutoSize = True
        Me.ucrChkShiftYearNum.Checked = False
        Me.ucrChkShiftYearNum.Location = New System.Drawing.Point(65, 78)
        Me.ucrChkShiftYearNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftYearNum.Name = "ucrChkShiftYearNum"
        Me.ucrChkShiftYearNum.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftYearNum.TabIndex = 12
        '
        'ucrChkShiftYearName
        '
        Me.ucrChkShiftYearName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkShiftYearName.AutoSize = True
        Me.ucrChkShiftYearName.Checked = False
        Me.ucrChkShiftYearName.Location = New System.Drawing.Point(63, 135)
        Me.ucrChkShiftYearName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkShiftYearName.Name = "ucrChkShiftYearName"
        Me.ucrChkShiftYearName.Size = New System.Drawing.Size(87, 23)
        Me.ucrChkShiftYearName.TabIndex = 26
        '
        'ucrChkDaysInMonthNum
        '
        Me.ucrChkDaysInMonthNum.AutoSize = True
        Me.ucrChkDaysInMonthNum.Checked = False
        Me.ucrChkDaysInMonthNum.Location = New System.Drawing.Point(399, 35)
        Me.ucrChkDaysInMonthNum.Name = "ucrChkDaysInMonthNum"
        Me.ucrChkDaysInMonthNum.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkDaysInMonthNum.TabIndex = 10
        '
        'ucrChkWeekdayName
        '
        Me.ucrChkWeekdayName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekdayName.AutoSize = True
        Me.ucrChkWeekdayName.Checked = False
        Me.ucrChkWeekdayName.Location = New System.Drawing.Point(210, 85)
        Me.ucrChkWeekdayName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekdayName.Name = "ucrChkWeekdayName"
        Me.ucrChkWeekdayName.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekdayName.TabIndex = 16
        '
        'ucrChkWeekdayAbbr
        '
        Me.ucrChkWeekdayAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekdayAbbr.AutoSize = True
        Me.ucrChkWeekdayAbbr.Checked = False
        Me.ucrChkWeekdayAbbr.Location = New System.Drawing.Point(210, 58)
        Me.ucrChkWeekdayAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekdayAbbr.Name = "ucrChkWeekdayAbbr"
        Me.ucrChkWeekdayAbbr.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekdayAbbr.TabIndex = 13
        '
        'ucrChkWeekdayNum
        '
        Me.ucrChkWeekdayNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekdayNum.AutoSize = True
        Me.ucrChkWeekdayNum.Checked = False
        Me.ucrChkWeekdayNum.Location = New System.Drawing.Point(210, 31)
        Me.ucrChkWeekdayNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekdayNum.Name = "ucrChkWeekdayNum"
        Me.ucrChkWeekdayNum.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekdayNum.TabIndex = 8
        '
        'ucrChkLeapYearNum
        '
        Me.ucrChkLeapYearNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkLeapYearNum.AutoSize = True
        Me.ucrChkLeapYearNum.Checked = False
        Me.ucrChkLeapYearNum.Location = New System.Drawing.Point(298, 31)
        Me.ucrChkLeapYearNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkLeapYearNum.Name = "ucrChkLeapYearNum"
        Me.ucrChkLeapYearNum.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkLeapYearNum.TabIndex = 9
        '
        'ucrChkWeekAbbr
        '
        Me.ucrChkWeekAbbr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekAbbr.AutoSize = True
        Me.ucrChkWeekAbbr.Checked = False
        Me.ucrChkWeekAbbr.Location = New System.Drawing.Point(145, 58)
        Me.ucrChkWeekAbbr.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekAbbr.Name = "ucrChkWeekAbbr"
        Me.ucrChkWeekAbbr.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekAbbr.TabIndex = 12
        '
        'ucrChkWeekName
        '
        Me.ucrChkWeekName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekName.AutoSize = True
        Me.ucrChkWeekName.Checked = False
        Me.ucrChkWeekName.Location = New System.Drawing.Point(145, 85)
        Me.ucrChkWeekName.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekName.Name = "ucrChkWeekName"
        Me.ucrChkWeekName.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekName.TabIndex = 15
        '
        'ucrChkWeekNum
        '
        Me.ucrChkWeekNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkWeekNum.AutoSize = True
        Me.ucrChkWeekNum.Checked = False
        Me.ucrChkWeekNum.Location = New System.Drawing.Point(145, 31)
        Me.ucrChkWeekNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkWeekNum.Name = "ucrChkWeekNum"
        Me.ucrChkWeekNum.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkWeekNum.TabIndex = 7
        '
        'ucrChkDayInMonthNum
        '
        Me.ucrChkDayInMonthNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ucrChkDayInMonthNum.AutoSize = True
        Me.ucrChkDayInMonthNum.Checked = False
        Me.ucrChkDayInMonthNum.Location = New System.Drawing.Point(76, 31)
        Me.ucrChkDayInMonthNum.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrChkDayInMonthNum.Name = "ucrChkDayInMonthNum"
        Me.ucrChkDayInMonthNum.Size = New System.Drawing.Size(85, 23)
        Me.ucrChkDayInMonthNum.TabIndex = 6
        '
        'ucrPnluseformat
        '
        Me.ucrPnluseformat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnluseformat.Location = New System.Drawing.Point(85, 5)
        Me.ucrPnluseformat.Name = "ucrPnluseformat"
        Me.ucrPnluseformat.Size = New System.Drawing.Size(284, 42)
        Me.ucrPnluseformat.TabIndex = 30
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.AutoSize = True
        Me.ucrReceiverUseDate.frmParent = Me
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 78)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(163, 20)
        Me.ucrReceiverUseDate.strNcFilePath = ""
        Me.ucrReceiverUseDate.TabIndex = 3
        Me.ucrReceiverUseDate.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 512)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorUseDate
        '
        Me.ucrSelectorUseDate.AutoSize = True
        Me.ucrSelectorUseDate.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        Me.ucrSelectorUseDate.Location = New System.Drawing.Point(10, 36)
        Me.ucrSelectorUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        Me.ucrSelectorUseDate.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorUseDate.TabIndex = 1
        '
        'cmdHelp
        '
        Me.cmdHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelp.Location = New System.Drawing.Point(425, 15)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(25, 25)
        Me.cmdHelp.TabIndex = 36
        Me.cmdHelp.Text = "?"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'dlgUseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(483, 567)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.Panelformatmode)
        Me.Controls.Add(Me.Panelusemode)
        Me.Controls.Add(Me.grpUseColumnnewfrm)
        Me.Controls.Add(Me.rdoFormatColumn)
        Me.Controls.Add(Me.rdoUseColumn)
        Me.Controls.Add(Me.ucrPnluseformat)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Date"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panelformatmode.ResumeLayout(False)
        Me.grpfrmdescrp.ResumeLayout(False)
        Me.grpUseColumnnewfrm.ResumeLayout(False)
        Me.grpUseColumnnewfrm.PerformLayout()
        Me.Panelusemode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents ttYearNumeric As ToolTip
    Friend WithEvents ucrChkShiftYearName As ucrCheck
    Friend WithEvents lblDayinYear366 As Label
    Friend WithEvents ucrChkShiftPentadAbbr As ucrCheck
    Friend WithEvents lblShiftYear As Label
    Friend WithEvents ucrChkShiftYearNum As ucrCheck
    Friend WithEvents lblShiftMonth As Label
    Friend WithEvents ucrChkShiftDekadAbbr As ucrCheck
    Friend WithEvents lblShiftPentad As Label
    Friend WithEvents lblDayInYear As Label
    Friend WithEvents ucrChkShiftMonthAbbr As ucrCheck
    Friend WithEvents lblShiftNumeric As Label
    Friend WithEvents lblShiftQuarter As Label
    Friend WithEvents ucrChkShiftMonthName As ucrCheck
    Friend WithEvents ucrChkShiftQuarterAbbr As ucrCheck
    Friend WithEvents lblShiftAbbr As Label
    Friend WithEvents lblShiftDekad As Label
    Friend WithEvents ucrChkShiftDekadNum As ucrCheck
    Friend WithEvents ucrChkShiftQuarterNum As ucrCheck
    Friend WithEvents ucrChkDayInYearNum As ucrCheck
    Friend WithEvents ucrChkShiftMonthNum As ucrCheck
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrChkShiftDayInYearNum366 As ucrCheck
    Friend WithEvents ucrChkShiftPentadNum As ucrCheck
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ucrChkDaysInMonthNum As ucrCheck
    Friend WithEvents lblDaysInMonth As Label
    Friend WithEvents ucrChkWeekName As ucrCheck
    Friend WithEvents lblDayInMonth As Label
    Friend WithEvents ucrChkDayInMonthNum As ucrCheck
    Friend WithEvents lblNumeric As Label
    Friend WithEvents ucrChkWeekAbbr As ucrCheck
    Friend WithEvents lblWeek As Label
    Friend WithEvents ucrChkWeekdayName As ucrCheck
    Friend WithEvents lblWeekDay As Label
    Friend WithEvents ucrChkWeekdayAbbr As ucrCheck
    Friend WithEvents lblName As Label
    Friend WithEvents ucrChkWeekNum As ucrCheck
    Friend WithEvents lblLeapYear As Label
    Friend WithEvents ucrChkWeekdayNum As ucrCheck
    Friend WithEvents ucrChkLeapYearNum As ucrCheck
    Friend WithEvents lblAbbr As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblShifted As Label
    Friend WithEvents ucrInputComboBoxStartingMonth As ucrInputComboBox
    Friend WithEvents lblShiftStartingMonth As Label
    Friend WithEvents ucrPnluseformat As UcrPanel
    Friend WithEvents rdoUseColumn As RadioButton
    Friend WithEvents rdoFormatColumn As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxnewformat As ComboBox
    Friend WithEvents grpUseColumnnewfrm As GroupBox
    Friend WithEvents grpfrmdescrp As GroupBox
    Friend WithEvents Panelusemode As Panel
    Friend WithEvents Panelformatmode As Panel
    Friend WithEvents txtTextDateFormats As RichTextBox
    Friend WithEvents cmdHelp As Button
End Class