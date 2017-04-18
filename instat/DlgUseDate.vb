' Instat-R
' Copyright (C) 2015
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

Imports instat
Imports instat.Translations
Public Class dlgUseDate
    Private bReset As Boolean = True
    Public bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""

    Private Sub dlgUseDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        SetDefaultColumn()
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 462

        ' Selector
        ucrSelectorUseDate.SetParameter(New RParameter("data_name"))
        ucrSelectorUseDate.SetParameterIsString()

        ' Receiver
        ucrReceiverUseDate.SetParameter(New RParameter("col_name"))
        ucrReceiverUseDate.Selector = ucrSelectorUseDate
        ucrReceiverUseDate.SetMeAsReceiver()
        ucrReceiverUseDate.bUseFilteredData = False
        ucrReceiverUseDate.SetIncludedDataTypes({"Date"})
        ucrReceiverUseDate.bAutoFill = True
        ucrReceiverUseDate.SetParameterIsString()

        'Check boxes
        ucrChkYear.SetParameter(New RParameter("year"))
        ucrChkYear.SetText("Year")
        ucrChkYear.SetRDefault("FALSE")

        ucrChkWeekday.SetParameter(New RParameter("weekday_val"))
        ucrChkWeekday.SetText("Weekday")
        ucrChkWeekday.SetRDefault("FALSE")

        ucrChkWeek.SetParameter(New RParameter("week"))
        ucrChkWeek.SetText("Week")
        ucrChkWeek.SetRDefault("FALSE")

        ucrChkMonth.SetParameter(New RParameter("month_val"))
        ucrChkMonth.SetText("Month")
        ucrChkMonth.SetRDefault("FALSE")

        ucrChkDayYear366.SetParameter(New RParameter("day_in_year_366"))
        ucrChkDayYear366.SetText("Day in Year (366)")
        ucrChkDayYear366.SetRDefault("FALSE")

        ucrChkDayInYear.SetParameter(New RParameter("day_in_year"))
        ucrChkDayInYear.SetText("Day in Year")
        ucrChkDayInYear.SetRDefault("FALSE")

        ucrChkDay.SetParameter(New RParameter("day_in_month"))
        ucrChkDay.SetText("Day")
        ucrChkDay.SetRDefault("FALSE")

        ucrChkFullWeekday.SetParameter(New RParameter("weekday_name"))
        ucrChkFullWeekday.SetText("Weekday")
        ucrChkFullWeekday.SetRDefault("FALSE")

        ucrChkFullMonth.SetParameter(New RParameter("month_name"))
        ucrChkFullMonth.SetText("Month")
        ucrChkFullMonth.SetRDefault("FALSE")

        ucrChkDekad.SetParameter(New RParameter("dekade"))
        ucrChkDekad.SetText("Dekad")
        ucrChkDekad.SetRDefault("FALSE")

        ucrChkPentad.SetParameter(New RParameter("pentad"))
        ucrChkPentad.SetText("Pentad")
        ucrChkPentad.SetRDefault("FALSE")

        ucrChkLeapYear.SetParameter(New RParameter("leap_year"))
        ucrChkLeapYear.SetText("Leap Year")
        ucrChkLeapYear.SetRDefault("FALSE")

        ucrChkAbbrWeekday.SetParameter(New RParameter("weekday_abbr"))
        ucrChkAbbrWeekday.SetText("Weekday")
        ucrChkAbbrWeekday.SetRDefault("FALSE")

        ucrChkAbbrMonth.SetParameter(New RParameter("month_abbr"))
        ucrChkAbbrMonth.SetText("Month")
        ucrChkAbbrMonth.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorUseDate.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$split_date")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorUseDate.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverUseDate.Add(strDefaultColumn, strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub TestOKEnabled()
        If (Not (ucrReceiverUseDate.IsEmpty) AndAlso (ucrChkYear.Checked OrElse ucrChkWeekday.Checked OrElse ucrChkWeek.Checked OrElse ucrChkPentad.Checked OrElse ucrChkMonth.Checked OrElse ucrChkLeapYear.Checked OrElse ucrChkFullWeekday.Checked OrElse ucrChkFullMonth.Checked OrElse ucrChkDekad.Checked OrElse ucrChkDayYear366.Checked OrElse ucrChkDayInYear.Checked OrElse ucrChkDay.Checked OrElse ucrChkAbbrWeekday.Checked OrElse ucrChkAbbrMonth.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverUseDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverUseDate.ControlContentsChanged, ucrChkYear.ControlContentsChanged, ucrChkWeekday.ControlContentsChanged, ucrChkWeek.ControlContentsChanged, ucrChkPentad.ControlContentsChanged, ucrChkMonth.ControlContentsChanged, ucrChkLeapYear.ControlContentsChanged, ucrChkFullWeekday.ControlContentsChanged, ucrChkFullMonth.ControlContentsChanged, ucrChkDekad.ControlContentsChanged, ucrChkDayYear366.ControlContentsChanged, ucrChkDayInYear.ControlContentsChanged, ucrChkDay.ControlContentsChanged, ucrChkAbbrWeekday.ControlContentsChanged, ucrChkAbbrMonth.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class