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
        Me.lblDateVariable.AutoSize = True
        Me.lblDateVariable.Location = New System.Drawing.Point(254, 44)
        Me.lblDateVariable.Name = "lblDateVariable"
        Me.lblDateVariable.Size = New System.Drawing.Size(71, 13)
        Me.lblDateVariable.TabIndex = 1
        Me.lblDateVariable.Text = "Date Column:"
        '
        'grpShifted
        '
        Me.grpShifted.Controls.Add(Me.lblMonth)
        Me.grpShifted.Controls.Add(Me.ucrInputComboBoxMonth)
        Me.grpShifted.Controls.Add(Me.lblDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftYear)
        Me.grpShifted.Controls.Add(Me.ucrNudShiftStartDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftDay)
        Me.grpShifted.Location = New System.Drawing.Point(236, 201)
        Me.grpShifted.Name = "grpShifted"
        Me.grpShifted.Size = New System.Drawing.Size(143, 125)
        Me.grpShifted.TabIndex = 4
        Me.grpShifted.TabStop = False
        Me.grpShifted.Text = "Shifted"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(10, 73)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 2
        Me.lblMonth.Text = "Month:"
        '
        'ucrInputComboBoxMonth
        '
        Me.ucrInputComboBoxMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonth.IsReadOnly = False
        Me.ucrInputComboBoxMonth.Location = New System.Drawing.Point(56, 70)
        Me.ucrInputComboBoxMonth.Name = "ucrInputComboBoxMonth"
        Me.ucrInputComboBoxMonth.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputComboBoxMonth.TabIndex = 3
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(10, 98)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 4
        Me.lblDay.Text = "Day:"
        '
        'ucrChkShiftYear
        '
        Me.ucrChkShiftYear.Checked = False
        Me.ucrChkShiftYear.Location = New System.Drawing.Point(13, 46)
        Me.ucrChkShiftYear.Name = "ucrChkShiftYear"
        Me.ucrChkShiftYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkShiftYear.TabIndex = 1
        '
        'ucrNudShiftStartDay
        '
        Me.ucrNudShiftStartDay.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShiftStartDay.Location = New System.Drawing.Point(57, 95)
        Me.ucrNudShiftStartDay.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShiftStartDay.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Name = "ucrNudShiftStartDay"
        Me.ucrNudShiftStartDay.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShiftStartDay.TabIndex = 5
        Me.ucrNudShiftStartDay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkShiftDay
        '
        Me.ucrChkShiftDay.Checked = False
        Me.ucrChkShiftDay.Location = New System.Drawing.Point(13, 19)
        Me.ucrChkShiftDay.Name = "ucrChkShiftDay"
        Me.ucrChkShiftDay.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkShiftDay.TabIndex = 0
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.ucrChkLeapYear)
        Me.grpOthers.Controls.Add(Me.ucrChkDekad)
        Me.grpOthers.Controls.Add(Me.ucrChkPentad)
        Me.grpOthers.Location = New System.Drawing.Point(10, 330)
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.Size = New System.Drawing.Size(369, 48)
        Me.grpOthers.TabIndex = 7
        Me.grpOthers.TabStop = False
        Me.grpOthers.Text = "Other Functions"
        '
        'ucrChkLeapYear
        '
        Me.ucrChkLeapYear.Checked = False
        Me.ucrChkLeapYear.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkLeapYear.Name = "ucrChkLeapYear"
        Me.ucrChkLeapYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLeapYear.TabIndex = 0
        '
        'ucrChkDekad
        '
        Me.ucrChkDekad.Checked = False
        Me.ucrChkDekad.Location = New System.Drawing.Point(221, 19)
        Me.ucrChkDekad.Name = "ucrChkDekad"
        Me.ucrChkDekad.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDekad.TabIndex = 2
        '
        'ucrChkPentad
        '
        Me.ucrChkPentad.Checked = False
        Me.ucrChkPentad.Location = New System.Drawing.Point(112, 19)
        Me.ucrChkPentad.Name = "ucrChkPentad"
        Me.ucrChkPentad.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPentad.TabIndex = 1
        '
        'grpFullName
        '
        Me.grpFullName.Controls.Add(Me.ucrChkFullWeekday)
        Me.grpFullName.Controls.Add(Me.ucrChkFullMonth)
        Me.grpFullName.Location = New System.Drawing.Point(385, 201)
        Me.grpFullName.Name = "grpFullName"
        Me.grpFullName.Size = New System.Drawing.Size(106, 89)
        Me.grpFullName.TabIndex = 5
        Me.grpFullName.TabStop = False
        Me.grpFullName.Text = "Full Name"
        '
        'ucrChkFullWeekday
        '
        Me.ucrChkFullWeekday.Checked = False
        Me.ucrChkFullWeekday.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkFullWeekday.Name = "ucrChkFullWeekday"
        Me.ucrChkFullWeekday.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullWeekday.TabIndex = 0
        '
        'ucrChkFullMonth
        '
        Me.ucrChkFullMonth.Checked = False
        Me.ucrChkFullMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkFullMonth.Name = "ucrChkFullMonth"
        Me.ucrChkFullMonth.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullMonth.TabIndex = 1
        '
        'grpAbbreviation
        '
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrMonth)
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrWeekday)
        Me.grpAbbreviation.Location = New System.Drawing.Point(386, 290)
        Me.grpAbbreviation.Name = "grpAbbreviation"
        Me.grpAbbreviation.Size = New System.Drawing.Size(105, 88)
        Me.grpAbbreviation.TabIndex = 6
        Me.grpAbbreviation.TabStop = False
        Me.grpAbbreviation.Text = "Abbreviation"
        '
        'ucrChkAbbrMonth
        '
        Me.ucrChkAbbrMonth.Checked = False
        Me.ucrChkAbbrMonth.Location = New System.Drawing.Point(5, 43)
        Me.ucrChkAbbrMonth.Name = "ucrChkAbbrMonth"
        Me.ucrChkAbbrMonth.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrMonth.TabIndex = 1
        '
        'ucrChkAbbrWeekday
        '
        Me.ucrChkAbbrWeekday.Checked = False
        Me.ucrChkAbbrWeekday.Location = New System.Drawing.Point(5, 17)
        Me.ucrChkAbbrWeekday.Name = "ucrChkAbbrWeekday"
        Me.ucrChkAbbrWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrWeekday.TabIndex = 0
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
        Me.grpValues.Location = New System.Drawing.Point(10, 199)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(220, 125)
        Me.grpValues.TabIndex = 3
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Values"
        '
        'ucrChkDayYear366
        '
        Me.ucrChkDayYear366.Checked = False
        Me.ucrChkDayYear366.Location = New System.Drawing.Point(108, 69)
        Me.ucrChkDayYear366.Name = "ucrChkDayYear366"
        Me.ucrChkDayYear366.Size = New System.Drawing.Size(109, 20)
        Me.ucrChkDayYear366.TabIndex = 6
        '
        'ucrChkYear
        '
        Me.ucrChkYear.Checked = False
        Me.ucrChkYear.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkYear.Name = "ucrChkYear"
        Me.ucrChkYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkYear.TabIndex = 0
        '
        'ucrChkDayInYear
        '
        Me.ucrChkDayInYear.Checked = False
        Me.ucrChkDayInYear.Location = New System.Drawing.Point(108, 43)
        Me.ucrChkDayInYear.Name = "ucrChkDayInYear"
        Me.ucrChkDayInYear.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkDayInYear.TabIndex = 5
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.Checked = False
        Me.ucrChkMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkMonth.Name = "ucrChkMonth"
        Me.ucrChkMonth.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMonth.TabIndex = 1
        '
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        Me.ucrChkDay.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkDay.Name = "ucrChkDay"
        Me.ucrChkDay.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDay.TabIndex = 2
        '
        'ucrChkWeekday
        '
        Me.ucrChkWeekday.Checked = False
        Me.ucrChkWeekday.Location = New System.Drawing.Point(108, 17)
        Me.ucrChkWeekday.Name = "ucrChkWeekday"
        Me.ucrChkWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkWeekday.TabIndex = 4
        '
        'ucrChkWeek
        '
        Me.ucrChkWeek.Checked = False
        Me.ucrChkWeek.Location = New System.Drawing.Point(6, 95)
        Me.ucrChkWeek.Name = "ucrChkWeek"
        Me.ucrChkWeek.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeek.TabIndex = 3
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.frmParent = Me
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 59)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(151, 20)
        Me.ucrReceiverUseDate.strNcFilePath = ""
        Me.ucrReceiverUseDate.TabIndex = 2
        Me.ucrReceiverUseDate.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 384)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 8
        '
        'ucrSelectorUseDate
        '
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        Me.ucrSelectorUseDate.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectorUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        Me.ucrSelectorUseDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseDate.TabIndex = 0
        '
        'dlgUseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 444)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Date"
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
