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
        Me.lblShiftStartingMonth = New System.Windows.Forms.Label()
        Me.lblDayInMonth = New System.Windows.Forms.Label()
        Me.lblLeapYear = New System.Windows.Forms.Label()
        Me.lblAbbr = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblWeekDay = New System.Windows.Forms.Label()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrChkShiftYearName = New instat.ucrCheck()
        Me.lblShifted = New System.Windows.Forms.Label()
        Me.lblDayinYear366 = New System.Windows.Forms.Label()
        Me.ucrChkShiftPentadAbbr = New instat.ucrCheck()
        Me.ucrInputComboBoxStartingMonth = New instat.ucrInputComboBox()
        Me.lblShiftYear = New System.Windows.Forms.Label()
        Me.ucrChkShiftYearNum = New instat.ucrCheck()
        Me.lblShiftMonth = New System.Windows.Forms.Label()
        Me.ucrChkShiftDekadAbbr = New instat.ucrCheck()
        Me.lblShiftPentad = New System.Windows.Forms.Label()
        Me.lblDayInYear = New System.Windows.Forms.Label()
        Me.ucrChkShiftMonthAbbr = New instat.ucrCheck()
        Me.lblShiftNumeric = New System.Windows.Forms.Label()
        Me.lblShiftQuarter = New System.Windows.Forms.Label()
        Me.ucrChkShiftMonthName = New instat.ucrCheck()
        Me.ucrChkShiftQuarterAbbr = New instat.ucrCheck()
        Me.lblShiftAbbr = New System.Windows.Forms.Label()
        Me.lblShiftDekad = New System.Windows.Forms.Label()
        Me.ucrChkShiftDekadNum = New instat.ucrCheck()
        Me.ucrChkShiftQuarterNum = New instat.ucrCheck()
        Me.ucrChkDayInYearNum = New instat.ucrCheck()
        Me.ucrChkShiftMonthNum = New instat.ucrCheck()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.ucrChkShiftDayInYearNum366 = New instat.ucrCheck()
        Me.ucrChkShiftPentadNum = New instat.ucrCheck()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ucrChkDaysInMonthNum = New instat.ucrCheck()
        Me.lblDaysInMonth = New System.Windows.Forms.Label()
        Me.ucrChkWeekName = New instat.ucrCheck()
        Me.ucrChkDayInMonthNum = New instat.ucrCheck()
        Me.ucrChkWeekAbbr = New instat.ucrCheck()
        Me.ucrChkWeekdayName = New instat.ucrCheck()
        Me.ucrChkWeekdayAbbr = New instat.ucrCheck()
        Me.ucrChkWeekNum = New instat.ucrCheck()
        Me.ucrChkWeekdayNum = New instat.ucrCheck()
        Me.ucrChkLeapYearNum = New instat.ucrCheck()
        Me.ttYearNumeric = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        'lblShiftStartingMonth
        '
        resources.ApplyResources(Me.lblShiftStartingMonth, "lblShiftStartingMonth")
        Me.lblShiftStartingMonth.Name = "lblShiftStartingMonth"
        '
        'lblDayInMonth
        '
        resources.ApplyResources(Me.lblDayInMonth, "lblDayInMonth")
        Me.lblDayInMonth.Name = "lblDayInMonth"
        '
        'lblLeapYear
        '
        resources.ApplyResources(Me.lblLeapYear, "lblLeapYear")
        Me.lblLeapYear.Name = "lblLeapYear"
        '
        'lblAbbr
        '
        resources.ApplyResources(Me.lblAbbr, "lblAbbr")
        Me.lblAbbr.Name = "lblAbbr"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'lblWeekDay
        '
        resources.ApplyResources(Me.lblWeekDay, "lblWeekDay")
        Me.lblWeekDay.Name = "lblWeekDay"
        '
        'lblWeek
        '
        resources.ApplyResources(Me.lblWeek, "lblWeek")
        Me.lblWeek.Name = "lblWeek"
        '
        'lblNumeric
        '
        resources.ApplyResources(Me.lblNumeric, "lblNumeric")
        Me.lblNumeric.Name = "lblNumeric"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftYearName)
        Me.GroupBox1.Controls.Add(Me.lblShifted)
        Me.GroupBox1.Controls.Add(Me.lblDayinYear366)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftPentadAbbr)
        Me.GroupBox1.Controls.Add(Me.ucrInputComboBoxStartingMonth)
        Me.GroupBox1.Controls.Add(Me.lblShiftYear)
        Me.GroupBox1.Controls.Add(Me.lblShiftStartingMonth)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftYearNum)
        Me.GroupBox1.Controls.Add(Me.lblShiftMonth)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDekadAbbr)
        Me.GroupBox1.Controls.Add(Me.lblShiftPentad)
        Me.GroupBox1.Controls.Add(Me.lblDayInYear)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthAbbr)
        Me.GroupBox1.Controls.Add(Me.lblShiftNumeric)
        Me.GroupBox1.Controls.Add(Me.lblShiftQuarter)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthName)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftQuarterAbbr)
        Me.GroupBox1.Controls.Add(Me.lblShiftAbbr)
        Me.GroupBox1.Controls.Add(Me.lblShiftDekad)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDekadNum)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftQuarterNum)
        Me.GroupBox1.Controls.Add(Me.ucrChkDayInYearNum)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftMonthNum)
        Me.GroupBox1.Controls.Add(Me.lblShift)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftDayInYearNum366)
        Me.GroupBox1.Controls.Add(Me.ucrChkShiftPentadNum)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ucrChkShiftYearName
        '
        resources.ApplyResources(Me.ucrChkShiftYearName, "ucrChkShiftYearName")
        Me.ucrChkShiftYearName.Checked = False
        Me.ucrChkShiftYearName.Name = "ucrChkShiftYearName"
        '
        'lblShifted
        '
        resources.ApplyResources(Me.lblShifted, "lblShifted")
        Me.lblShifted.Name = "lblShifted"
        '
        'lblDayinYear366
        '
        resources.ApplyResources(Me.lblDayinYear366, "lblDayinYear366")
        Me.lblDayinYear366.Name = "lblDayinYear366"
        '
        'ucrChkShiftPentadAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftPentadAbbr, "ucrChkShiftPentadAbbr")
        Me.ucrChkShiftPentadAbbr.Checked = False
        Me.ucrChkShiftPentadAbbr.Name = "ucrChkShiftPentadAbbr"
        '
        'ucrInputComboBoxStartingMonth
        '
        Me.ucrInputComboBoxStartingMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxStartingMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxStartingMonth, "ucrInputComboBoxStartingMonth")
        Me.ucrInputComboBoxStartingMonth.Name = "ucrInputComboBoxStartingMonth"
        '
        'lblShiftYear
        '
        resources.ApplyResources(Me.lblShiftYear, "lblShiftYear")
        Me.lblShiftYear.Name = "lblShiftYear"
        '
        'ucrChkShiftYearNum
        '
        resources.ApplyResources(Me.ucrChkShiftYearNum, "ucrChkShiftYearNum")
        Me.ucrChkShiftYearNum.Checked = False
        Me.ucrChkShiftYearNum.Name = "ucrChkShiftYearNum"
        '
        'lblShiftMonth
        '
        resources.ApplyResources(Me.lblShiftMonth, "lblShiftMonth")
        Me.lblShiftMonth.Name = "lblShiftMonth"
        '
        'ucrChkShiftDekadAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftDekadAbbr, "ucrChkShiftDekadAbbr")
        Me.ucrChkShiftDekadAbbr.Checked = False
        Me.ucrChkShiftDekadAbbr.Name = "ucrChkShiftDekadAbbr"
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
        'ucrChkShiftMonthAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftMonthAbbr, "ucrChkShiftMonthAbbr")
        Me.ucrChkShiftMonthAbbr.Checked = False
        Me.ucrChkShiftMonthAbbr.Name = "ucrChkShiftMonthAbbr"
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
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
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
        'ucrChkDayInMonthNum
        '
        resources.ApplyResources(Me.ucrChkDayInMonthNum, "ucrChkDayInMonthNum")
        Me.ucrChkDayInMonthNum.Checked = False
        Me.ucrChkDayInMonthNum.Name = "ucrChkDayInMonthNum"
        '
        'ucrChkWeekAbbr
        '
        resources.ApplyResources(Me.ucrChkWeekAbbr, "ucrChkWeekAbbr")
        Me.ucrChkWeekAbbr.Checked = False
        Me.ucrChkWeekAbbr.Name = "ucrChkWeekAbbr"
        '
        'ucrChkWeekdayName
        '
        resources.ApplyResources(Me.ucrChkWeekdayName, "ucrChkWeekdayName")
        Me.ucrChkWeekdayName.Checked = False
        Me.ucrChkWeekdayName.Name = "ucrChkWeekdayName"
        '
        'ucrChkWeekdayAbbr
        '
        resources.ApplyResources(Me.ucrChkWeekdayAbbr, "ucrChkWeekdayAbbr")
        Me.ucrChkWeekdayAbbr.Checked = False
        Me.ucrChkWeekdayAbbr.Name = "ucrChkWeekdayAbbr"
        '
        'ucrChkWeekNum
        '
        resources.ApplyResources(Me.ucrChkWeekNum, "ucrChkWeekNum")
        Me.ucrChkWeekNum.Checked = False
        Me.ucrChkWeekNum.Name = "ucrChkWeekNum"
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents ucrChkWeekdayNum As ucrCheck
    Friend WithEvents ucrChkWeekNum As ucrCheck
    Friend WithEvents ucrChkWeekName As ucrCheck
    Friend WithEvents ucrChkWeekdayName As ucrCheck
    Friend WithEvents ucrChkWeekdayAbbr As ucrCheck
    Friend WithEvents ucrChkLeapYearNum As ucrCheck
    Friend WithEvents lblShiftStartingMonth As Label
    Friend WithEvents ucrInputComboBoxStartingMonth As ucrInputComboBox
    Friend WithEvents ucrChkWeekAbbr As ucrCheck
    Friend WithEvents ucrChkDayInMonthNum As ucrCheck
    Friend WithEvents lblLeapYear As Label
    Friend WithEvents lblAbbr As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblWeekDay As Label
    Friend WithEvents lblWeek As Label
    Friend WithEvents lblNumeric As Label
    Friend WithEvents lblDayInMonth As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrChkShiftPentadAbbr As ucrCheck
    Friend WithEvents lblShiftYear As Label
    Friend WithEvents ucrChkShiftYearNum As ucrCheck
    Friend WithEvents ucrChkShiftDekadAbbr As ucrCheck
    Friend WithEvents ucrChkShiftMonthAbbr As ucrCheck
    Friend WithEvents ucrChkShiftMonthName As ucrCheck
    Friend WithEvents lblShiftAbbr As Label
    Friend WithEvents ucrChkShiftDekadNum As ucrCheck
    Friend WithEvents ucrChkShiftMonthNum As ucrCheck
    Friend WithEvents ucrChkShiftPentadNum As ucrCheck
    Friend WithEvents ucrChkShiftDayInYearNum366 As ucrCheck
    Friend WithEvents lblShift As Label
    Friend WithEvents ucrChkDayInYearNum As ucrCheck
    Friend WithEvents ucrChkShiftQuarterNum As ucrCheck
    Friend WithEvents lblShiftDekad As Label
    Friend WithEvents ucrChkShiftQuarterAbbr As ucrCheck
    Friend WithEvents lblShiftQuarter As Label
    Friend WithEvents lblShiftNumeric As Label
    Friend WithEvents lblDayInYear As Label
    Friend WithEvents lblShiftMonth As Label
    Friend WithEvents lblShiftPentad As Label
    Friend WithEvents lblDayinYear366 As Label
    Friend WithEvents lblShifted As Label
    Friend WithEvents ucrChkShiftYearName As ucrCheck
    Friend WithEvents ttYearNumeric As ToolTip
    Friend WithEvents ucrChkDaysInMonthNum As ucrCheck
    Friend WithEvents lblDaysInMonth As Label
End Class