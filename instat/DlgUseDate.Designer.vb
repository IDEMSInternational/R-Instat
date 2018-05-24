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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.grpOthers = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkQuarter = New instat.ucrCheck()
        Me.ucrChkDayInYear = New instat.ucrCheck()
        Me.ucrChkFullWeekday = New instat.ucrCheck()
        Me.ucrChkAbbrWeekday = New instat.ucrCheck()
        Me.ucrChkWeek = New instat.ucrCheck()
        Me.UcrCheck1 = New instat.ucrCheck()
        Me.ucrChkWeekday = New instat.ucrCheck()
        Me.ucrChkLeapYear = New instat.ucrCheck()
        Me.UcrCheck4 = New instat.ucrCheck()
        Me.UcrCheck3 = New instat.ucrCheck()
        Me.ucrChkShiftQuarter = New instat.ucrCheck()
        Me.UcrCheck2 = New instat.ucrCheck()
        Me.ucrChkDekad = New instat.ucrCheck()
        Me.ucrChkShiftYear = New instat.ucrCheck()
        Me.ucrChkAbbrMonth = New instat.ucrCheck()
        Me.ucrChkPentad = New instat.ucrCheck()
        Me.ucrChkFullMonth = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkShiftDay = New instat.ucrCheck()
        Me.ucrInputComboBoxMonth = New instat.ucrInputComboBox()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpShifted.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        resources.ApplyResources(Me.lblDateVariable, "lblDateVariable")
        Me.lblDateVariable.Name = "lblDateVariable"
        '
        'grpShifted
        '
        Me.grpShifted.Controls.Add(Me.TableLayoutPanel1)
        Me.grpShifted.Controls.Add(Me.lblMonth)
        Me.grpShifted.Controls.Add(Me.ucrInputComboBoxMonth)
        resources.ApplyResources(Me.grpShifted, "grpShifted")
        Me.grpShifted.Name = "grpShifted"
        Me.grpShifted.TabStop = False
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'lblMonth
        '
        resources.ApplyResources(Me.lblMonth, "lblMonth")
        Me.lblMonth.Name = "lblMonth"
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.TableLayoutPanel2)
        resources.ApplyResources(Me.grpOthers, "grpOthers")
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.TabStop = False
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.UcrCheck4, 6, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UcrCheck3, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkShiftQuarter, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UcrCheck2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkDekad, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkShiftYear, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkAbbrMonth, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkPentad, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkFullMonth, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkMonth, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ucrChkShiftDay, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkYear, 3, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkQuarter, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkDayInYear, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkFullWeekday, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkAbbrWeekday, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkWeek, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.UcrCheck1, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label22, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label23, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkWeekday, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label24, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label25, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label26, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ucrChkLeapYear, 5, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'ucrChkYear
        '
        resources.ApplyResources(Me.ucrChkYear, "ucrChkYear")
        Me.ucrChkYear.Checked = False
        Me.ucrChkYear.Name = "ucrChkYear"
        '
        'ucrChkQuarter
        '
        resources.ApplyResources(Me.ucrChkQuarter, "ucrChkQuarter")
        Me.ucrChkQuarter.Checked = False
        Me.ucrChkQuarter.Name = "ucrChkQuarter"
        '
        'ucrChkDayInYear
        '
        resources.ApplyResources(Me.ucrChkDayInYear, "ucrChkDayInYear")
        Me.ucrChkDayInYear.Checked = False
        Me.ucrChkDayInYear.Name = "ucrChkDayInYear"
        '
        'ucrChkFullWeekday
        '
        resources.ApplyResources(Me.ucrChkFullWeekday, "ucrChkFullWeekday")
        Me.ucrChkFullWeekday.Checked = False
        Me.ucrChkFullWeekday.Name = "ucrChkFullWeekday"
        '
        'ucrChkAbbrWeekday
        '
        resources.ApplyResources(Me.ucrChkAbbrWeekday, "ucrChkAbbrWeekday")
        Me.ucrChkAbbrWeekday.Checked = False
        Me.ucrChkAbbrWeekday.Name = "ucrChkAbbrWeekday"
        '
        'ucrChkWeek
        '
        resources.ApplyResources(Me.ucrChkWeek, "ucrChkWeek")
        Me.ucrChkWeek.Checked = False
        Me.ucrChkWeek.Name = "ucrChkWeek"
        '
        'UcrCheck1
        '
        resources.ApplyResources(Me.UcrCheck1, "UcrCheck1")
        Me.UcrCheck1.Checked = False
        Me.UcrCheck1.Name = "UcrCheck1"
        '
        'ucrChkWeekday
        '
        resources.ApplyResources(Me.ucrChkWeekday, "ucrChkWeekday")
        Me.ucrChkWeekday.Checked = False
        Me.ucrChkWeekday.Name = "ucrChkWeekday"
        '
        'ucrChkLeapYear
        '
        resources.ApplyResources(Me.ucrChkLeapYear, "ucrChkLeapYear")
        Me.ucrChkLeapYear.Checked = False
        Me.ucrChkLeapYear.Name = "ucrChkLeapYear"
        '
        'UcrCheck4
        '
        resources.ApplyResources(Me.UcrCheck4, "UcrCheck4")
        Me.UcrCheck4.Checked = False
        Me.UcrCheck4.Name = "UcrCheck4"
        '
        'UcrCheck3
        '
        resources.ApplyResources(Me.UcrCheck3, "UcrCheck3")
        Me.UcrCheck3.Checked = False
        Me.UcrCheck3.Name = "UcrCheck3"
        '
        'ucrChkShiftQuarter
        '
        resources.ApplyResources(Me.ucrChkShiftQuarter, "ucrChkShiftQuarter")
        Me.ucrChkShiftQuarter.Checked = False
        Me.ucrChkShiftQuarter.Name = "ucrChkShiftQuarter"
        '
        'UcrCheck2
        '
        resources.ApplyResources(Me.UcrCheck2, "UcrCheck2")
        Me.UcrCheck2.Checked = False
        Me.UcrCheck2.Name = "UcrCheck2"
        '
        'ucrChkDekad
        '
        resources.ApplyResources(Me.ucrChkDekad, "ucrChkDekad")
        Me.ucrChkDekad.Checked = False
        Me.ucrChkDekad.Name = "ucrChkDekad"
        '
        'ucrChkShiftYear
        '
        resources.ApplyResources(Me.ucrChkShiftYear, "ucrChkShiftYear")
        Me.ucrChkShiftYear.Checked = False
        Me.ucrChkShiftYear.Name = "ucrChkShiftYear"
        '
        'ucrChkAbbrMonth
        '
        resources.ApplyResources(Me.ucrChkAbbrMonth, "ucrChkAbbrMonth")
        Me.ucrChkAbbrMonth.Checked = False
        Me.ucrChkAbbrMonth.Name = "ucrChkAbbrMonth"
        '
        'ucrChkPentad
        '
        resources.ApplyResources(Me.ucrChkPentad, "ucrChkPentad")
        Me.ucrChkPentad.Checked = False
        Me.ucrChkPentad.Name = "ucrChkPentad"
        '
        'ucrChkFullMonth
        '
        resources.ApplyResources(Me.ucrChkFullMonth, "ucrChkFullMonth")
        Me.ucrChkFullMonth.Checked = False
        Me.ucrChkFullMonth.Name = "ucrChkFullMonth"
        '
        'ucrChkMonth
        '
        resources.ApplyResources(Me.ucrChkMonth, "ucrChkMonth")
        Me.ucrChkMonth.Checked = False
        Me.ucrChkMonth.Name = "ucrChkMonth"
        '
        'ucrChkShiftDay
        '
        resources.ApplyResources(Me.ucrChkShiftDay, "ucrChkShiftDay")
        Me.ucrChkShiftDay.Checked = False
        Me.ucrChkShiftDay.Name = "ucrChkShiftDay"
        '
        'ucrInputComboBoxMonth
        '
        Me.ucrInputComboBoxMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboBoxMonth, "ucrInputComboBoxMonth")
        Me.ucrInputComboBoxMonth.Name = "ucrInputComboBoxMonth"
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
        Me.Controls.Add(Me.grpOthers)
        Me.Controls.Add(Me.grpShifted)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.grpShifted.ResumeLayout(False)
        Me.grpShifted.PerformLayout()
        Me.grpOthers.ResumeLayout(False)
        Me.grpOthers.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents ucrChkShiftDay As ucrCheck
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
    Friend WithEvents UcrCheck1 As ucrCheck
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
End Class
