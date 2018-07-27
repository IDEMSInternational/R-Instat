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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgUseDate))
        Me.lblDateVariable = New System.Windows.Forms.Label()
        Me.s = New System.Windows.Forms.TableLayoutPanel()
        Me.lblShiftYear = New System.Windows.Forms.Label()
        Me.ucrChkShiftPentadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftYearNum = New instat.ucrCheck()
        Me.ucrChkShiftDekadAbbr = New instat.ucrCheck()
        Me.ucrChkShiftMonthAbbr = New instat.ucrCheck()
        Me.lblShiftAbbr = New System.Windows.Forms.Label()
        Me.ucrChkShiftMonthName = New instat.ucrCheck()
        Me.ucrChkShiftDekadNum = New instat.ucrCheck()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.lblShiftMonth = New System.Windows.Forms.Label()
        Me.lblShiftDekad = New System.Windows.Forms.Label()
        Me.ucrChkShiftMonthNum = New instat.ucrCheck()
        Me.lblShiftNumeric = New System.Windows.Forms.Label()
        Me.lblShiftDayInYear366 = New System.Windows.Forms.Label()
        Me.ucrChkShiftPentadNum = New instat.ucrCheck()
        Me.ucrChkShiftDayInYearNum366 = New instat.ucrCheck()
        Me.lblShiftPentad = New System.Windows.Forms.Label()
        Me.lblDayInYear = New System.Windows.Forms.Label()
        Me.ucrChkDayInYearNum = New instat.ucrCheck()
        Me.lblShiftQuarter = New System.Windows.Forms.Label()
        Me.ucrChkShiftQuarterNum = New instat.ucrCheck()
        Me.ucrChkShiftQuarterAbbr = New instat.ucrCheck()
        Me.ucrChkDayInMonthNum = New instat.ucrCheck()
        Me.lblShiftStartingMonth = New System.Windows.Forms.Label()
        Me.tblLayoutOthers = New System.Windows.Forms.TableLayoutPanel()
        Me.ucrChkWeekName = New instat.ucrCheck()
        Me.lblDayInMonth = New System.Windows.Forms.Label()
        Me.ucrChkWeekAbbr = New instat.ucrCheck()
        Me.ucrChkWeekdayName = New instat.ucrCheck()
        Me.lblLeapYear = New System.Windows.Forms.Label()
        Me.ucrChkWeekdayAbbr = New instat.ucrCheck()
        Me.ucrChkWeekNum = New instat.ucrCheck()
        Me.lblAbbr = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.ucrChkWeekdayNum = New instat.ucrCheck()
        Me.lblWeekDay = New System.Windows.Forms.Label()
        Me.lblWeek = New System.Windows.Forms.Label()
        Me.lblNumeric = New System.Windows.Forms.Label()
        Me.ucrChkLeapYearNum = New instat.ucrCheck()
        Me.ucrInputComboBoxStartingMonth = New instat.ucrInputComboBox()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.s.SuspendLayout()
        Me.tblLayoutOthers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        's
        '
        resources.ApplyResources(Me.s, "s")
        Me.s.Controls.Add(Me.lblShiftYear, 1, 0)
        Me.s.Controls.Add(Me.ucrChkShiftPentadAbbr, 6, 2)
        Me.s.Controls.Add(Me.ucrChkShiftYearNum, 1, 1)
        Me.s.Controls.Add(Me.ucrChkShiftDekadAbbr, 7, 2)
        Me.s.Controls.Add(Me.ucrChkShiftMonthAbbr, 2, 2)
        Me.s.Controls.Add(Me.lblShiftAbbr, 0, 2)
        Me.s.Controls.Add(Me.ucrChkShiftMonthName, 2, 3)
        Me.s.Controls.Add(Me.ucrChkShiftDekadNum, 7, 1)
        Me.s.Controls.Add(Me.lblShift, 0, 3)
        Me.s.Controls.Add(Me.lblShiftMonth, 2, 0)
        Me.s.Controls.Add(Me.lblShiftDekad, 7, 0)
        Me.s.Controls.Add(Me.ucrChkShiftMonthNum, 2, 1)
        Me.s.Controls.Add(Me.lblShiftNumeric, 0, 1)
        Me.s.Controls.Add(Me.lblShiftDayInYear366, 3, 0)
        Me.s.Controls.Add(Me.ucrChkShiftPentadNum, 6, 1)
        Me.s.Controls.Add(Me.ucrChkShiftDayInYearNum366, 3, 1)
        Me.s.Controls.Add(Me.lblShiftPentad, 6, 0)
        Me.s.Controls.Add(Me.lblDayInYear, 4, 0)
        Me.s.Controls.Add(Me.ucrChkDayInYearNum, 4, 1)
        Me.s.Controls.Add(Me.lblShiftQuarter, 5, 0)
        Me.s.Controls.Add(Me.ucrChkShiftQuarterNum, 5, 1)
        Me.s.Controls.Add(Me.ucrChkShiftQuarterAbbr, 5, 2)
        Me.s.Name = "s"
        '
        'lblShiftYear
        '
        resources.ApplyResources(Me.lblShiftYear, "lblShiftYear")
        Me.lblShiftYear.Name = "lblShiftYear"
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
        'lblShiftAbbr
        '
        resources.ApplyResources(Me.lblShiftAbbr, "lblShiftAbbr")
        Me.lblShiftAbbr.Name = "lblShiftAbbr"
        '
        'ucrChkShiftMonthName
        '
        resources.ApplyResources(Me.ucrChkShiftMonthName, "ucrChkShiftMonthName")
        Me.ucrChkShiftMonthName.Checked = False
        Me.ucrChkShiftMonthName.Name = "ucrChkShiftMonthName"
        '
        'ucrChkShiftDekadNum
        '
        resources.ApplyResources(Me.ucrChkShiftDekadNum, "ucrChkShiftDekadNum")
        Me.ucrChkShiftDekadNum.Checked = False
        Me.ucrChkShiftDekadNum.Name = "ucrChkShiftDekadNum"
        '
        'lblShift
        '
        resources.ApplyResources(Me.lblShift, "lblShift")
        Me.lblShift.Name = "lblShift"
        '
        'lblShiftMonth
        '
        resources.ApplyResources(Me.lblShiftMonth, "lblShiftMonth")
        Me.lblShiftMonth.Name = "lblShiftMonth"
        '
        'lblShiftDekad
        '
        resources.ApplyResources(Me.lblShiftDekad, "lblShiftDekad")
        Me.lblShiftDekad.Name = "lblShiftDekad"
        '
        'ucrChkShiftMonthNum
        '
        resources.ApplyResources(Me.ucrChkShiftMonthNum, "ucrChkShiftMonthNum")
        Me.ucrChkShiftMonthNum.Checked = False
        Me.ucrChkShiftMonthNum.Name = "ucrChkShiftMonthNum"
        '
        'lblShiftNumeric
        '
        resources.ApplyResources(Me.lblShiftNumeric, "lblShiftNumeric")
        Me.lblShiftNumeric.Name = "lblShiftNumeric"
        '
        'lblShiftDayInYear366
        '
        resources.ApplyResources(Me.lblShiftDayInYear366, "lblShiftDayInYear366")
        Me.lblShiftDayInYear366.Name = "lblShiftDayInYear366"
        '
        'ucrChkShiftPentadNum
        '
        resources.ApplyResources(Me.ucrChkShiftPentadNum, "ucrChkShiftPentadNum")
        Me.ucrChkShiftPentadNum.Checked = False
        Me.ucrChkShiftPentadNum.Name = "ucrChkShiftPentadNum"
        '
        'ucrChkShiftDayInYearNum366
        '
        resources.ApplyResources(Me.ucrChkShiftDayInYearNum366, "ucrChkShiftDayInYearNum366")
        Me.ucrChkShiftDayInYearNum366.Checked = False
        Me.ucrChkShiftDayInYearNum366.Name = "ucrChkShiftDayInYearNum366"
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
        'ucrChkDayInYearNum
        '
        resources.ApplyResources(Me.ucrChkDayInYearNum, "ucrChkDayInYearNum")
        Me.ucrChkDayInYearNum.Checked = False
        Me.ucrChkDayInYearNum.Name = "ucrChkDayInYearNum"
        '
        'lblShiftQuarter
        '
        resources.ApplyResources(Me.lblShiftQuarter, "lblShiftQuarter")
        Me.lblShiftQuarter.Name = "lblShiftQuarter"
        '
        'ucrChkShiftQuarterNum
        '
        resources.ApplyResources(Me.ucrChkShiftQuarterNum, "ucrChkShiftQuarterNum")
        Me.ucrChkShiftQuarterNum.Checked = False
        Me.ucrChkShiftQuarterNum.Name = "ucrChkShiftQuarterNum"
        '
        'ucrChkShiftQuarterAbbr
        '
        resources.ApplyResources(Me.ucrChkShiftQuarterAbbr, "ucrChkShiftQuarterAbbr")
        Me.ucrChkShiftQuarterAbbr.Checked = False
        Me.ucrChkShiftQuarterAbbr.Name = "ucrChkShiftQuarterAbbr"
        '
        'ucrChkDayInMonthNum
        '
        resources.ApplyResources(Me.ucrChkDayInMonthNum, "ucrChkDayInMonthNum")
        Me.ucrChkDayInMonthNum.Checked = False
        Me.ucrChkDayInMonthNum.Name = "ucrChkDayInMonthNum"
        '
        'lblShiftStartingMonth
        '
        resources.ApplyResources(Me.lblShiftStartingMonth, "lblShiftStartingMonth")
        Me.lblShiftStartingMonth.Name = "lblShiftStartingMonth"
        '
        'tblLayoutOthers
        '
        resources.ApplyResources(Me.tblLayoutOthers, "tblLayoutOthers")
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekName, 2, 3)
        Me.tblLayoutOthers.Controls.Add(Me.lblDayInMonth, 1, 0)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkDayInMonthNum, 1, 1)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekAbbr, 2, 2)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekdayName, 3, 3)
        Me.tblLayoutOthers.Controls.Add(Me.lblLeapYear, 4, 0)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekdayAbbr, 3, 2)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekNum, 2, 1)
        Me.tblLayoutOthers.Controls.Add(Me.lblAbbr, 0, 2)
        Me.tblLayoutOthers.Controls.Add(Me.lblName, 0, 3)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkWeekdayNum, 3, 1)
        Me.tblLayoutOthers.Controls.Add(Me.lblWeekDay, 3, 0)
        Me.tblLayoutOthers.Controls.Add(Me.lblWeek, 2, 0)
        Me.tblLayoutOthers.Controls.Add(Me.lblNumeric, 0, 1)
        Me.tblLayoutOthers.Controls.Add(Me.ucrChkLeapYearNum, 4, 1)
        Me.tblLayoutOthers.Name = "tblLayoutOthers"
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
        'lblLeapYear
        '
        resources.ApplyResources(Me.lblLeapYear, "lblLeapYear")
        Me.lblLeapYear.Name = "lblLeapYear"
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
        'ucrChkWeekdayNum
        '
        resources.ApplyResources(Me.ucrChkWeekdayNum, "ucrChkWeekdayNum")
        Me.ucrChkWeekdayNum.Checked = False
        Me.ucrChkWeekdayNum.Name = "ucrChkWeekdayNum"
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
        'ucrChkLeapYearNum
        '
        resources.ApplyResources(Me.ucrChkLeapYearNum, "ucrChkLeapYearNum")
        Me.ucrChkLeapYearNum.Checked = False
        Me.ucrChkLeapYearNum.Name = "ucrChkLeapYearNum"
        '
        'ucrInputComboBoxStartingMonth
        '
        Me.ucrInputComboBoxStartingMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxStartingMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxStartingMonth, "ucrInputComboBoxStartingMonth")
        Me.ucrInputComboBoxStartingMonth.Name = "ucrInputComboBoxStartingMonth"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.s)
        Me.GroupBox1.Controls.Add(Me.ucrInputComboBoxStartingMonth)
        Me.GroupBox1.Controls.Add(Me.lblShiftStartingMonth)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tblLayoutOthers)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
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
        Me.s.ResumeLayout(False)
        Me.s.PerformLayout()
        Me.tblLayoutOthers.ResumeLayout(False)
        Me.tblLayoutOthers.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents ucrChkDayInYearNum As ucrCheck
    Friend WithEvents ucrChkWeekdayNum As ucrCheck
    Friend WithEvents ucrChkWeekNum As ucrCheck
    Friend WithEvents ucrChkShiftMonthNum As ucrCheck
    Friend WithEvents ucrChkWeekName As ucrCheck
    Friend WithEvents ucrChkWeekdayName As ucrCheck
    Friend WithEvents ucrChkShiftMonthName As ucrCheck
    Friend WithEvents ucrChkShiftMonthAbbr As ucrCheck
    Friend WithEvents ucrChkWeekdayAbbr As ucrCheck
    Friend WithEvents ucrChkLeapYearNum As ucrCheck
    Friend WithEvents ucrChkShiftDekadNum As ucrCheck
    Friend WithEvents ucrChkShiftPentadNum As ucrCheck
    Friend WithEvents ucrChkShiftDayInYearNum366 As ucrCheck
    Friend WithEvents ucrChkShiftYearNum As ucrCheck
    Friend WithEvents lblShiftStartingMonth As Label
    Friend WithEvents ucrInputComboBoxStartingMonth As ucrInputComboBox
    Friend WithEvents ucrChkShiftQuarterNum As ucrCheck
    Friend WithEvents ucrChkWeekAbbr As ucrCheck
    Friend WithEvents ucrChkShiftQuarterAbbr As ucrCheck
    Friend WithEvents ucrChkShiftDekadAbbr As ucrCheck
    Friend WithEvents ucrChkShiftPentadAbbr As ucrCheck
    Friend WithEvents lblShiftQuarter As Label
    Friend WithEvents lblShiftDekad As Label
    Friend WithEvents lblShift As Label
    Friend WithEvents lblShiftAbbr As Label
    Friend WithEvents lblShiftNumeric As Label
    Friend WithEvents lblShiftYear As Label
    Friend WithEvents lblShiftMonth As Label
    Friend WithEvents lblShiftDayInYear366 As Label
    Friend WithEvents lblShiftPentad As Label
    Friend WithEvents ucrChkDayInMonthNum As ucrCheck
    Friend WithEvents s As TableLayoutPanel
    Friend WithEvents tblLayoutOthers As TableLayoutPanel
    Friend WithEvents lblLeapYear As Label
    Friend WithEvents lblAbbr As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblDayInYear As Label
    Friend WithEvents lblWeekDay As Label
    Friend WithEvents lblWeek As Label
    Friend WithEvents lblNumeric As Label
    Friend WithEvents lblDayInMonth As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
End Class