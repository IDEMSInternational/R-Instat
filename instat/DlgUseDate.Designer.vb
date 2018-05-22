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
        Me.grpShifted = New System.Windows.Forms.GroupBox()
        Me.ucrChkShiftQuarter = New instat.ucrCheck()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxMonth = New instat.ucrInputComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ucrChkShiftYear = New instat.ucrCheck()
        Me.ucrNudShiftStartDay = New instat.ucrNud()
        Me.ucrChkShiftDay = New instat.ucrCheck()
        Me.grpOthers = New System.Windows.Forms.GroupBox()
        Me.ucrChkQuarter = New instat.ucrCheck()
        Me.ucrChkLeapYear = New instat.ucrCheck()
        Me.ucrChkDekad = New instat.ucrCheck()
        Me.ucrChkPentad = New instat.ucrCheck()
        Me.ucrChkFullWeekday = New instat.ucrCheck()
        Me.ucrChkFullMonth = New instat.ucrCheck()
        Me.ucrChkAbbrMonth = New instat.ucrCheck()
        Me.ucrChkAbbrWeekday = New instat.ucrCheck()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkDayInYear = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkWeekday = New instat.ucrCheck()
        Me.ucrChkWeek = New instat.ucrCheck()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.UcrCheck3 = New instat.ucrCheck()
        Me.UcrCheck4 = New instat.ucrCheck()
        Me.grpShifted.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        'grpShifted
        '
        Me.grpShifted.Controls.Add(Me.UcrCheck4)
        Me.grpShifted.Controls.Add(Me.UcrCheck3)
        Me.grpShifted.Controls.Add(Me.UcrCheck2)
        Me.grpShifted.Controls.Add(Me.ucrChkAbbrMonth)
        Me.grpShifted.Controls.Add(Me.Label9)
        Me.grpShifted.Controls.Add(Me.ucrChkDekad)
        Me.grpShifted.Controls.Add(Me.ucrChkFullMonth)
        Me.grpShifted.Controls.Add(Me.ucrChkPentad)
        Me.grpShifted.Controls.Add(Me.Label8)
        Me.grpShifted.Controls.Add(Me.Label7)
        Me.grpShifted.Controls.Add(Me.ucrChkMonth)
        Me.grpShifted.Controls.Add(Me.Label6)
        Me.grpShifted.Controls.Add(Me.lblDay)
        Me.grpShifted.Controls.Add(Me.ucrNudShiftStartDay)
        Me.grpShifted.Controls.Add(Me.Label5)
        Me.grpShifted.Controls.Add(Me.Label4)
        Me.grpShifted.Controls.Add(Me.Label3)
        Me.grpShifted.Controls.Add(Me.Label2)
        Me.grpShifted.Controls.Add(Me.Label1)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftQuarter)
        Me.grpShifted.Controls.Add(Me.lblMonth)
        Me.grpShifted.Controls.Add(Me.ucrInputComboBoxMonth)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftYear)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftDay)
        resources.ApplyResources(Me.grpShifted, "grpShifted")
        Me.grpShifted.Name = "grpShifted"
        Me.grpShifted.TabStop = False
        '
        'ucrChkShiftQuarter
        '
        Me.ucrChkShiftQuarter.Checked = False
        resources.ApplyResources(Me.ucrChkShiftQuarter, "ucrChkShiftQuarter")
        Me.ucrChkShiftQuarter.Name = "ucrChkShiftQuarter"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'ucrInputComboBoxMonth
        '
        Me.ucrInputComboBoxMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxMonth, "ucrInputComboBoxMonth")
        Me.ucrInputComboBoxMonth.Name = "ucrInputComboBoxMonth"
        '
        'lblDay
        '
        resources.ApplyResources(Me.lblDay, "lblDay")
        Me.lblDay.Name = "lblDay"
        '
        'ucrChkShiftYear
        '
        Me.ucrChkShiftYear.Checked = False
        resources.ApplyResources(Me.ucrChkShiftYear, "ucrChkShiftYear")
        Me.ucrChkShiftYear.Name = "ucrChkShiftYear"
        '
        'ucrNudShiftStartDay
        '
        Me.ucrNudShiftStartDay.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudShiftStartDay, "ucrNudShiftStartDay")
        Me.ucrNudShiftStartDay.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShiftStartDay.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Name = "ucrNudShiftStartDay"
        Me.ucrNudShiftStartDay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkShiftDay
        '
        Me.ucrChkShiftDay.Checked = False
        resources.ApplyResources(Me.ucrChkShiftDay, "ucrChkShiftDay")
        Me.ucrChkShiftDay.Name = "ucrChkShiftDay"
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.ucrChkQuarter)
        Me.grpOthers.Controls.Add(Me.ucrChkYear)
        Me.grpOthers.Controls.Add(Me.ucrChkFullWeekday)
        Me.grpOthers.Controls.Add(Me.ucrChkAbbrWeekday)
        Me.grpOthers.Controls.Add(Me.Label17)
        Me.grpOthers.Controls.Add(Me.Label16)
        Me.grpOthers.Controls.Add(Me.ucrChkDayInYear)
        Me.grpOthers.Controls.Add(Me.ucrChkWeek)
        Me.grpOthers.Controls.Add(Me.ucrChkWeekday)
        Me.grpOthers.Controls.Add(Me.Label15)
        Me.grpOthers.Controls.Add(Me.Label14)
        Me.grpOthers.Controls.Add(Me.Label10)
        Me.grpOthers.Controls.Add(Me.Label11)
        Me.grpOthers.Controls.Add(Me.Label12)
        Me.grpOthers.Controls.Add(Me.Label13)
        Me.grpOthers.Controls.Add(Me.UcrCheck1)
        Me.grpOthers.Controls.Add(Me.ucrChkLeapYear)
        resources.ApplyResources(Me.grpOthers, "grpOthers")
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.TabStop = False
        '
        'ucrChkQuarter
        '
        Me.ucrChkQuarter.Checked = False
        resources.ApplyResources(Me.ucrChkQuarter, "ucrChkQuarter")
        Me.ucrChkQuarter.Name = "ucrChkQuarter"
        '
        'ucrChkLeapYear
        '
        Me.ucrChkLeapYear.Checked = False
        resources.ApplyResources(Me.ucrChkLeapYear, "ucrChkLeapYear")
        Me.ucrChkLeapYear.Name = "ucrChkLeapYear"
        '
        'ucrChkDekad
        '
        Me.ucrChkDekad.Checked = False
        resources.ApplyResources(Me.ucrChkDekad, "ucrChkDekad")
        Me.ucrChkDekad.Name = "ucrChkDekad"
        '
        'ucrChkPentad
        '
        Me.ucrChkPentad.Checked = False
        resources.ApplyResources(Me.ucrChkPentad, "ucrChkPentad")
        Me.ucrChkPentad.Name = "ucrChkPentad"
        '
        'ucrChkFullWeekday
        '
        Me.ucrChkFullWeekday.Checked = False
        resources.ApplyResources(Me.ucrChkFullWeekday, "ucrChkFullWeekday")
        Me.ucrChkFullWeekday.Name = "ucrChkFullWeekday"
        '
        'ucrChkFullMonth
        '
        Me.ucrChkFullMonth.Checked = False
        resources.ApplyResources(Me.ucrChkFullMonth, "ucrChkFullMonth")
        Me.ucrChkFullMonth.Name = "ucrChkFullMonth"
        '
        'ucrChkAbbrMonth
        '
        Me.ucrChkAbbrMonth.Checked = False
        resources.ApplyResources(Me.ucrChkAbbrMonth, "ucrChkAbbrMonth")
        Me.ucrChkAbbrMonth.Name = "ucrChkAbbrMonth"
        '
        'ucrChkAbbrWeekday
        '
        Me.ucrChkAbbrWeekday.Checked = False
        resources.ApplyResources(Me.ucrChkAbbrWeekday, "ucrChkAbbrWeekday")
        Me.ucrChkAbbrWeekday.Name = "ucrChkAbbrWeekday"
        '
        'ucrChkYear
        '
        Me.ucrChkYear.Checked = False
        resources.ApplyResources(Me.ucrChkYear, "ucrChkYear")
        Me.ucrChkYear.Name = "ucrChkYear"
        '
        'ucrChkDayInYear
        '
        Me.ucrChkDayInYear.Checked = False
        resources.ApplyResources(Me.ucrChkDayInYear, "ucrChkDayInYear")
        Me.ucrChkDayInYear.Name = "ucrChkDayInYear"
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.Checked = False
        resources.ApplyResources(Me.ucrChkMonth, "ucrChkMonth")
        Me.ucrChkMonth.Name = "ucrChkMonth"
        '
        'ucrChkWeekday
        '
        Me.ucrChkWeekday.Checked = False
        resources.ApplyResources(Me.ucrChkWeekday, "ucrChkWeekday")
        Me.ucrChkWeekday.Name = "ucrChkWeekday"
        '
        'ucrChkWeek
        '
        Me.ucrChkWeek.Checked = False
        resources.ApplyResources(Me.ucrChkWeek, "ucrChkWeek")
        Me.ucrChkWeek.Name = "ucrChkWeek"
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
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'UcrCheck1
        '
        Me.UcrCheck1.Checked = False
        resources.ApplyResources(Me.UcrCheck1, "UcrCheck1")
        Me.UcrCheck1.Name = "UcrCheck1"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'UcrCheck2
        '
        Me.UcrCheck2.Checked = False
        resources.ApplyResources(Me.UcrCheck2, "UcrCheck2")
        Me.UcrCheck2.Name = "UcrCheck2"
        '
        'UcrCheck3
        '
        Me.UcrCheck3.Checked = False
        resources.ApplyResources(Me.UcrCheck3, "UcrCheck3")
        Me.UcrCheck3.Name = "UcrCheck3"
        '
        'UcrCheck4
        '
        Me.UcrCheck4.Checked = False
        resources.ApplyResources(Me.UcrCheck4, "UcrCheck4")
        Me.UcrCheck4.Name = "UcrCheck4"
        '
        'dlgUseDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpOthers)
        Me.Controls.Add(Me.grpShifted)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.grpShifted.ResumeLayout(False)
        Me.grpShifted.PerformLayout()
        Me.grpOthers.ResumeLayout(False)
        Me.grpOthers.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpOthers As GroupBox
    Friend WithEvents ucrChkDayInYear As ucrCheck
    Friend WithEvents ucrChkWeekday As ucrCheck
    Friend WithEvents ucrChkWeek As ucrCheck
    Friend WithEvents ucrChkMonth As ucrCheck
    Friend WithEvents ucrChkYear As ucrCheck
    Friend WithEvents ucrChkFullWeekday As ucrCheck
    Friend WithEvents ucrChkFullMonth As ucrCheck
    Friend WithEvents ucrChkAbbrMonth As ucrCheck
    Friend WithEvents ucrChkAbbrWeekday As ucrCheck
    Friend WithEvents ucrChkLeapYear As ucrCheck
    Friend WithEvents ucrChkDekad As ucrCheck
    Friend WithEvents ucrChkPentad As ucrCheck
    Friend WithEvents ucrNudShiftStartDay As ucrNud
    Friend WithEvents ucrChkShiftDay As ucrCheck
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrChkShiftYear As ucrCheck
    Friend WithEvents grpShifted As GroupBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrInputComboBoxMonth As ucrInputComboBox
    Friend WithEvents ucrChkShiftQuarter As ucrCheck
    Friend WithEvents ucrChkQuarter As ucrCheck
    Friend WithEvents UcrCheck4 As ucrCheck
    Friend WithEvents UcrCheck3 As ucrCheck
    Friend WithEvents UcrCheck2 As ucrCheck
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents UcrCheck1 As ucrCheck
End Class
