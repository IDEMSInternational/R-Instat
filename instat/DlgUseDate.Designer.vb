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
        Me.ucrChkDaysInMonthNum = New instat.ucrCheck()
        Me.lblDaysInMonth = New System.Windows.Forms.Label()
        Me.ucrChkWeekName = New instat.ucrCheck()
        Me.lblDayInMonth = New System.Windows.Forms.Label()
        Me.ucrChkDayInMonthNum = New instat.ucrCheck()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrChkWeekAbbr = New instat.ucrCheck()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.ucrChkWeekdayName = New instat.ucrCheck()
        Me.lblWeekDay = New System.Windows.Forms.Label()
        Me.ucrChkWeekdayAbbr = New instat.ucrCheck()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrChkWeekNum = New instat.ucrCheck()
        Me.lblLeapYear = New System.Windows.Forms.Label()
        Me.ucrChkWeekdayNum = New instat.ucrCheck()
        Me.ucrChkLeapYearNum = New instat.ucrCheck()
        Me.lblAbbr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblShifted = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxStartingMonth = New instat.ucrInputComboBox()
        Me.lblShiftStartingMonth = New System.Windows.Forms.Label()
        Me.ucrChkShiftYearName = New instat.ucrCheck()
        Me.ucrChkShiftPentadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftYearNum = New instat.ucrCheck()
        Me.ucrChkShiftDekadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftMonthAbbr = New instat.ucrCheck()
        Me.ucrChkShiftMonthName = New instat.ucrCheck()
        Me.ucrChkShiftQuarterAbbr = New instat.ucrCheck()
        Me.ucrChkShiftDekadNum = New instat.ucrCheck()
        Me.ucrChkShiftQuarterNum = New instat.ucrCheck()
        Me.ucrChkDayInYearNum = New instat.ucrCheck()
        Me.ucrChkShiftMonthNum = New instat.ucrCheck()
        Me.ucrChkShiftDayInYearNum366 = New instat.ucrCheck()
        Me.ucrChkShiftPentadNum = New instat.ucrCheck()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        'lblDayinYear366
        '
        resources.ApplyResources(Me.lblDayinYear366, "lblDayinYear366")
        Me.lblDayinYear366.Name = "lblDayinYear366"
        '
        'lblShiftYear
        '
        resources.ApplyResources(Me.lblShiftYear, "lblShiftYear")
        Me.lblShiftYear.Name = "lblShiftYear"
        '
        'lblShiftMonth
        '
        resources.ApplyResources(Me.lblShiftMonth, "lblShiftMonth")
        Me.lblShiftMonth.Name = "lblShiftMonth"
        '
        'lblShiftPentad
        '
        resources.ApplyResources(Me.lblShiftPentad, "lblShiftPentad")
        Me.lblShiftPentad.Name = "lblShiftPentad"
        '
        'lblDayInYear
        '
        resources.ApplyResources(Me.lblDayInYear, "lblDayInYear")
        Me.lblDayInYear.Name = "lblDayInYear"
        '
        'lblShiftNumeric
        '
        resources.ApplyResources(Me.lblShiftNumeric, "lblShiftNumeric")
        Me.lblShiftNumeric.Name = "lblShiftNumeric"
        '
        'lblShiftQuarter
        '
        resources.ApplyResources(Me.lblShiftQuarter, "lblShiftQuarter")
        Me.lblShiftQuarter.Name = "lblShiftQuarter"
        '
        'lblShiftAbbr
        '
        resources.ApplyResources(Me.lblShiftAbbr, "lblShiftAbbr")
        Me.lblShiftAbbr.Name = "lblShiftAbbr"
        '
        'lblShiftDekad
        '
        resources.ApplyResources(Me.lblShiftDekad, "lblShiftDekad")
        Me.lblShiftDekad.Name = "lblShiftDekad"
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ucrChkDaysInMonthNum)
        Me.GroupBox2.Controls.Add(Me.lblDaysInMonth)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekName)
        Me.GroupBox2.Controls.Add(Me.lblDayInMonth)
        Me.GroupBox2.Controls.Add(Me.ucrChkDayInMonthNum)
        Me.GroupBox2.Controls.Add(Me.lblNumeric)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekAbbr)
        Me.GroupBox2.Controls.Add(Me.lblWeek)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayName)
        Me.GroupBox2.Controls.Add(Me.lblWeekDay)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayAbbr)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekNum)
        Me.GroupBox2.Controls.Add(Me.lblLeapYear)
        Me.GroupBox2.Controls.Add(Me.ucrChkWeekdayNum)
        Me.GroupBox2.Controls.Add(Me.ucrChkLeapYearNum)
        Me.GroupBox2.Controls.Add(Me.lblAbbr)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'ucrChkDaysInMonthNum
        '
        Me.ucrChkDaysInMonthNum.Checked = False
        resources.ApplyResources(Me.ucrChkDaysInMonthNum, "ucrChkDaysInMonthNum")
        Me.ucrChkDaysInMonthNum.Name = "ucrChkDaysInMonthNum"
        '
        'lblDaysInMonth
        '
        resources.ApplyResources(Me.lblDaysInMonth, "lblDaysInMonth")
        Me.lblDaysInMonth.Name = "lblDaysInMonth"
        '
        'ucrChkWeekName
        '
        resources.ApplyResources(Me.ucrChkWeekName, "ucrChkWeekName")
        Me.ucrChkWeekName.Checked = False
        Me.ucrChkWeekName.Name = "ucrChkWeekName"
        '
        'lblDayInMonth
        '
        resources.ApplyResources(Me.lblDayInMonth, "lblDayInMonth")
        Me.lblDayInMonth.Name = "lblDayInMonth"
        '
        'ucrChkDayInMonthNum
        '
        resources.ApplyResources(Me.ucrChkDayInMonthNum, "ucrChkDayInMonthNum")
        Me.ucrChkDayInMonthNum.Checked = False
        Me.ucrChkDayInMonthNum.Name = "ucrChkDayInMonthNum"
        '
        'lblNumeric
        '
        resources.ApplyResources(Me.lblNumeric, "lblNumeric")
        Me.lblNumeric.Name = "lblNumeric"
        '
        'ucrChkWeekAbbr
        '
        resources.ApplyResources(Me.ucrChkWeekAbbr, "ucrChkWeekAbbr")
        Me.ucrChkWeekAbbr.Checked = False
        Me.ucrChkWeekAbbr.Name = "ucrChkWeekAbbr"
        '
        'lblWeek
        '
        resources.ApplyResources(Me.lblWeek, "lblWeek")
        Me.lblWeek.Name = "lblWeek"
        '
        'ucrChkWeekdayName
        '
        resources.ApplyResources(Me.ucrChkWeekdayName, "ucrChkWeekdayName")
        Me.ucrChkWeekdayName.Checked = False
        Me.ucrChkWeekdayName.Name = "ucrChkWeekdayName"
        '
        'lblWeekDay
        '
        resources.ApplyResources(Me.lblWeekDay, "lblWeekDay")
        Me.lblWeekDay.Name = "lblWeekDay"
        '
        'ucrChkWeekdayAbbr
        '
        resources.ApplyResources(Me.ucrChkWeekdayAbbr, "ucrChkWeekdayAbbr")
        Me.ucrChkWeekdayAbbr.Checked = False
        Me.ucrChkWeekdayAbbr.Name = "ucrChkWeekdayAbbr"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'ucrChkWeekNum
        '
        resources.ApplyResources(Me.ucrChkWeekNum, "ucrChkWeekNum")
        Me.ucrChkWeekNum.Checked = False
        Me.ucrChkWeekNum.Name = "ucrChkWeekNum"
        '
        'lblLeapYear
        '
        resources.ApplyResources(Me.lblLeapYear, "lblLeapYear")
        Me.lblLeapYear.Name = "lblLeapYear"
        '
        'ucrChkWeekdayNum
        '
        resources.ApplyResources(Me.ucrChkWeekdayNum, "ucrChkWeekdayNum")
        Me.ucrChkWeekdayNum.Checked = False
        Me.ucrChkWeekdayNum.Name = "ucrChkWeekdayNum"
        '
        'ucrChkLeapYearNum
        '
        resources.ApplyResources(Me.ucrChkLeapYearNum, "ucrChkLeapYearNum")
        Me.ucrChkLeapYearNum.Checked = False
        Me.ucrChkLeapYearNum.Name = "ucrChkLeapYearNum"
        '
        'lblAbbr
        '
        resources.ApplyResources(Me.lblAbbr, "lblAbbr")
        Me.lblAbbr.Name = "lblAbbr"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblShifted)
        Me.GroupBox1.Controls.Add(Me.ucrInputComboBoxStartingMonth)
        Me.GroupBox1.Controls.Add(Me.lblShiftStartingMonth)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblShifted
        '
        resources.ApplyResources(Me.lblShifted, "lblShifted")
        Me.lblShifted.Name = "lblShifted"
        '
        'ucrInputComboBoxStartingMonth
        '
        Me.ucrInputComboBoxStartingMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxStartingMonth.GetSetSelectedIndex = -1
        Me.ucrInputComboBoxStartingMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxStartingMonth, "ucrInputComboBoxStartingMonth")
        Me.ucrInputComboBoxStartingMonth.Name = "ucrInputComboBoxStartingMonth"
        '
        'lblShiftStartingMonth
        '
        resources.ApplyResources(Me.lblShiftStartingMonth, "lblShiftStartingMonth")
        Me.lblShiftStartingMonth.Name = "lblShiftStartingMonth"
        '
        'ucrChkShiftYearName
        '
        resources.ApplyResources(Me.ucrChkShiftYearName, "ucrChkShiftYearName")
        Me.ucrChkShiftYearName.Checked = False
        Me.ucrChkShiftYearName.Name = "ucrChkShiftYearName"
        '
        'ucrChkShiftPentadAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftPentadAbbr, "ucrChkShiftPentadAbbr")
        Me.ucrChkShiftPentadAbbr.Checked = False
        Me.ucrChkShiftPentadAbbr.Name = "ucrChkShiftPentadAbbr"
        '
        'ucrChkShiftYearNum
        '
        resources.ApplyResources(Me.ucrChkShiftYearNum, "ucrChkShiftYearNum")
        Me.ucrChkShiftYearNum.Checked = False
        Me.ucrChkShiftYearNum.Name = "ucrChkShiftYearNum"
        '
        'ucrChkShiftDekadAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftDekadAbbr, "ucrChkShiftDekadAbbr")
        Me.ucrChkShiftDekadAbbr.Checked = False
        Me.ucrChkShiftDekadAbbr.Name = "ucrChkShiftDekadAbbr"
        '
        'ucrChkShiftMonthAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftMonthAbbr, "ucrChkShiftMonthAbbr")
        Me.ucrChkShiftMonthAbbr.Checked = False
        Me.ucrChkShiftMonthAbbr.Name = "ucrChkShiftMonthAbbr"
        '
        'ucrChkShiftMonthName
        '
        resources.ApplyResources(Me.ucrChkShiftMonthName, "ucrChkShiftMonthName")
        Me.ucrChkShiftMonthName.Checked = False
        Me.ucrChkShiftMonthName.Name = "ucrChkShiftMonthName"
        '
        'ucrChkShiftQuarterAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftQuarterAbbr, "ucrChkShiftQuarterAbbr")
        Me.ucrChkShiftQuarterAbbr.Checked = False
        Me.ucrChkShiftQuarterAbbr.Name = "ucrChkShiftQuarterAbbr"
        '
        'ucrChkShiftDekadNum
        '
        resources.ApplyResources(Me.ucrChkShiftDekadNum, "ucrChkShiftDekadNum")
        Me.ucrChkShiftDekadNum.Checked = False
        Me.ucrChkShiftDekadNum.Name = "ucrChkShiftDekadNum"
        '
        'ucrChkShiftQuarterNum
        '
        resources.ApplyResources(Me.ucrChkShiftQuarterNum, "ucrChkShiftQuarterNum")
        Me.ucrChkShiftQuarterNum.Checked = False
        Me.ucrChkShiftQuarterNum.Name = "ucrChkShiftQuarterNum"
        '
        'ucrChkDayInYearNum
        '
        resources.ApplyResources(Me.ucrChkDayInYearNum, "ucrChkDayInYearNum")
        Me.ucrChkDayInYearNum.Checked = False
        Me.ucrChkDayInYearNum.Name = "ucrChkDayInYearNum"
        '
        'ucrChkShiftMonthNum
        '
        resources.ApplyResources(Me.ucrChkShiftMonthNum, "ucrChkShiftMonthNum")
        Me.ucrChkShiftMonthNum.Checked = False
        Me.ucrChkShiftMonthNum.Name = "ucrChkShiftMonthNum"
        '
        'ucrChkShiftDayInYearNum366
        '
        resources.ApplyResources(Me.ucrChkShiftDayInYearNum366, "ucrChkShiftDayInYearNum366")
        Me.ucrChkShiftDayInYearNum366.Checked = False
        Me.ucrChkShiftDayInYearNum366.Name = "ucrChkShiftDayInYearNum366"
        '
        'ucrChkShiftPentadNum
        '
        resources.ApplyResources(Me.ucrChkShiftPentadNum, "ucrChkShiftPentadNum")
        Me.ucrChkShiftPentadNum.Checked = False
        Me.ucrChkShiftPentadNum.Name = "ucrChkShiftPentadNum"
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverUseDate, "ucrReceiverUseDate")
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.strNcFilePath = ""
        Me.ucrReceiverUseDate.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorUseDate
        '
        Me.ucrSelectorUseDate.bDropUnusedFilterLevels = False
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorUseDate, "ucrSelectorUseDate")
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        '
        'dlgUseDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrChkShiftYearName)
        Me.Controls.Add(Me.lblDayinYear366)
        Me.Controls.Add(Me.ucrChkShiftPentadAbbr)
        Me.Controls.Add(Me.lblShiftYear)
        Me.Controls.Add(Me.ucrChkShiftYearNum)
        Me.Controls.Add(Me.lblShiftMonth)
        Me.Controls.Add(Me.ucrChkShiftDekadAbbr)
        Me.Controls.Add(Me.lblShiftPentad)
        Me.Controls.Add(Me.lblDayInYear)
        Me.Controls.Add(Me.ucrChkShiftMonthAbbr)
        Me.Controls.Add(Me.lblShiftNumeric)
        Me.Controls.Add(Me.lblShiftQuarter)
        Me.Controls.Add(Me.ucrChkShiftMonthName)
        Me.Controls.Add(Me.ucrChkShiftQuarterAbbr)
        Me.Controls.Add(Me.lblShiftAbbr)
        Me.Controls.Add(Me.lblShiftDekad)
        Me.Controls.Add(Me.ucrChkShiftDekadNum)
        Me.Controls.Add(Me.ucrChkShiftQuarterNum)
        Me.Controls.Add(Me.ucrChkDayInYearNum)
        Me.Controls.Add(Me.ucrChkShiftMonthNum)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.ucrChkShiftDayInYearNum366)
        Me.Controls.Add(Me.ucrChkShiftPentadNum)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class