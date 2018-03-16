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
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxMonth = New instat.ucrInputComboBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.ucrChkShiftYear = New instat.ucrCheck()
        Me.ucrNudShiftStartDay = New instat.ucrNud()
        Me.ucrChkShiftDay = New instat.ucrCheck()
        Me.grpOthers = New System.Windows.Forms.GroupBox()
        Me.ucrChkLeapYear = New instat.ucrCheck()
        Me.ucrChkDekad = New instat.ucrCheck()
        Me.ucrChkPentad = New instat.ucrCheck()
        Me.grpFullName = New System.Windows.Forms.GroupBox()
        Me.ucrChkFullWeekday = New instat.ucrCheck()
        Me.ucrChkFullMonth = New instat.ucrCheck()
        Me.grpAbbreviation = New System.Windows.Forms.GroupBox()
        Me.ucrChkAbbrMonth = New instat.ucrCheck()
        Me.ucrChkAbbrWeekday = New instat.ucrCheck()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.ucrChkDayYear366 = New instat.ucrCheck()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkDayInYear = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkDay = New instat.ucrCheck()
        Me.ucrChkWeekday = New instat.ucrCheck()
        Me.ucrChkWeek = New instat.ucrCheck()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpShifted.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.grpFullName.SuspendLayout()
        Me.grpAbbreviation.SuspendLayout()
        Me.grpValues.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        'grpShifted
        '
        Me.grpShifted.Controls.Add(Me.lblMonth)
        Me.grpShifted.Controls.Add(Me.ucrInputComboBoxMonth)
        Me.grpShifted.Controls.Add(Me.lblDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftYear)
        Me.grpShifted.Controls.Add(Me.ucrNudShiftStartDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftDay)
        resources.ApplyResources(Me.grpShifted, "grpShifted")
        Me.grpShifted.Name = "grpShifted"
        Me.grpShifted.TabStop = False
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
        Me.grpOthers.Controls.Add(Me.ucrChkLeapYear)
        Me.grpOthers.Controls.Add(Me.ucrChkDekad)
        Me.grpOthers.Controls.Add(Me.ucrChkPentad)
        resources.ApplyResources(Me.grpOthers, "grpOthers")
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.TabStop = False
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
        'grpFullName
        '
        Me.grpFullName.Controls.Add(Me.ucrChkFullWeekday)
        Me.grpFullName.Controls.Add(Me.ucrChkFullMonth)
        resources.ApplyResources(Me.grpFullName, "grpFullName")
        Me.grpFullName.Name = "grpFullName"
        Me.grpFullName.TabStop = False
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
        'grpAbbreviation
        '
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrMonth)
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrWeekday)
        resources.ApplyResources(Me.grpAbbreviation, "grpAbbreviation")
        Me.grpAbbreviation.Name = "grpAbbreviation"
        Me.grpAbbreviation.TabStop = False
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
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.ucrChkDayYear366)
        Me.grpValues.Controls.Add(Me.ucrChkYear)
        Me.grpValues.Controls.Add(Me.ucrChkDayInYear)
        Me.grpValues.Controls.Add(Me.ucrChkMonth)
        Me.grpValues.Controls.Add(Me.ucrChkDay)
        Me.grpValues.Controls.Add(Me.ucrChkWeekday)
        Me.grpValues.Controls.Add(Me.ucrChkWeek)
        resources.ApplyResources(Me.grpValues, "grpValues")
        Me.grpValues.Name = "grpValues"
        Me.grpValues.TabStop = False
        '
        'ucrChkDayYear366
        '
        Me.ucrChkDayYear366.Checked = False
        resources.ApplyResources(Me.ucrChkDayYear366, "ucrChkDayYear366")
        Me.ucrChkDayYear366.Name = "ucrChkDayYear366"
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
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        resources.ApplyResources(Me.ucrChkDay, "ucrChkDay")
        Me.ucrChkDay.Name = "ucrChkDay"
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
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorUseDate, "ucrSelectorUseDate")
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        '
        'dlgUseDate
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpOthers)
        Me.Controls.Add(Me.grpShifted)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.grpFullName)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.grpAbbreviation)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpValues)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.grpShifted.ResumeLayout(False)
        Me.grpShifted.PerformLayout()
        Me.grpOthers.ResumeLayout(False)
        Me.grpFullName.ResumeLayout(False)
        Me.grpAbbreviation.ResumeLayout(False)
        Me.grpValues.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpOthers As GroupBox
    Friend WithEvents grpFullName As GroupBox
    Friend WithEvents grpAbbreviation As GroupBox
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents ucrChkDayYear366 As ucrCheck
    Friend WithEvents ucrChkDayInYear As ucrCheck
    Friend WithEvents ucrChkWeekday As ucrCheck
    Friend WithEvents ucrChkWeek As ucrCheck
    Friend WithEvents ucrChkDay As ucrCheck
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
End Class
