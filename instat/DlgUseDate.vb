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
    Private clsDefaultFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgUseDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
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
        ucrReceiverUseDate.SetParameterIsString()

        'Check boxes
        ucrChkYear.SetParameter(New RParameter("year"))
        ucrChkYear.SetText("Year")
        ucrChkYear.SetDefault("FALSE")

        ucrChkWeekday.SetParameter(New RParameter("weekday_val"))
        ucrChkWeekday.SetText("Weekday")
        ucrChkWeekday.SetDefault("FALSE")

        ucrChkWeek.SetParameter(New RParameter("week"))
        ucrChkWeek.SetText("Week")
        ucrChkWeek.SetDefault("FALSE")

        ucrChkMonth.SetParameter(New RParameter("month_val"))
        ucrChkMonth.SetText("Month")
        ucrChkMonth.SetDefault("FALSE")

        ucrChkDayYear366.SetParameter(New RParameter("day_in_year_366"))
        ucrChkDayYear366.SetText("Day in Year (366)")
        ucrChkDayYear366.SetDefault("FALSE")

        ucrChkDayInYear.SetParameter(New RParameter("day_in_year"))
        ucrChkDayInYear.SetText("Day in Year")
        ucrChkDayInYear.SetDefault("FALSE")

        ucrChkDay.SetParameter(New RParameter("day_in_month"))
        ucrChkDay.SetText("Day")
        ucrChkDay.SetDefault("FALSE")

        ucrChkFullWeekday.SetParameter(New RParameter("weekday_name"))
        ucrChkFullWeekday.SetText("Weekday")
        ucrChkFullWeekday.SetDefault("FALSE")

        ucrChkFullMonth.SetParameter(New RParameter("month_name"))
        ucrChkFullMonth.SetText("Month")
        ucrChkFullMonth.SetDefault("FALSE")

        ucrChkDekad.SetParameter(New RParameter("dekade"))
        ucrChkDekad.SetText("Dekad")
        ucrChkDekad.SetDefault("FALSE")

        ucrChkPentad.SetParameter(New RParameter("pentad"))
        ucrChkPentad.SetText("Pentad")
        ucrChkPentad.SetDefault("FALSE")

        ucrChkLeapYear.SetParameter(New RParameter("leap_year"))
        ucrChkLeapYear.SetText("Leap Year")
        ucrChkLeapYear.SetDefault("FALSE")

        ucrChkAbbrWeekday.SetParameter(New RParameter("weekday_abbr"))
        ucrChkAbbrWeekday.SetText("Weekday")
        ucrChkAbbrWeekday.SetDefault("FALSE")

        ucrChkAbbrMonth.SetParameter(New RParameter("month_abbr"))
        ucrChkAbbrMonth.SetText("Month")
        ucrChkAbbrMonth.SetDefault("FALSE")

        ' Default R Function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$split_date")
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorUseDate.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOKEnabled()
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
    End Sub

    Private Sub ucrReceiverUseDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverUseDate.ControlContentsChanged, ucrChkYear.ControlContentsChanged, ucrChkWeekday.ControlContentsChanged, ucrChkWeek.ControlContentsChanged, ucrChkPentad.ControlContentsChanged, ucrChkMonth.ControlContentsChanged, ucrChkLeapYear.ControlContentsChanged, ucrChkFullWeekday.ControlContentsChanged, ucrChkFullMonth.ControlContentsChanged, ucrChkDekad.ControlContentsChanged, ucrChkDayYear366.ControlContentsChanged, ucrChkDayInYear.ControlContentsChanged, ucrChkDay.ControlContentsChanged, ucrChkAbbrWeekday.ControlContentsChanged, ucrChkAbbrMonth.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class