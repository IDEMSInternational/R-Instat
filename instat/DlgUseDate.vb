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

Imports instat.Translations
Public Class dlgUseDate
    Private bReset As Boolean = True
    Public bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""
    Private clsDefaultFunction As New RFunction

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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 462

        'Selector
        ucrSelectorUseDate.SetParameter(New RParameter("data_name", 0))
        ucrSelectorUseDate.SetParameterIsString()

        'Receiver
        ucrReceiverUseDate.SetParameter(New RParameter("col_name", 1))
        ucrReceiverUseDate.Selector = ucrSelectorUseDate
        ucrReceiverUseDate.SetMeAsReceiver()
        ucrReceiverUseDate.bUseFilteredData = False
        ucrReceiverUseDate.SetIncludedDataTypes({"Date"})
        ucrReceiverUseDate.strSelectorHeading = "Dates"
        ucrReceiverUseDate.bAutoFill = True
        ucrReceiverUseDate.SetParameterIsString()

        'Year
        ucrChkShiftYearNum.SetParameter(New RParameter("year_val", 2))
        ucrChkShiftYearNum.SetText("")
        ucrChkShiftYearNum.SetRDefault("FALSE")

        ucrChkShiftYearName.SetParameter(New RParameter("year_name", 2))
        ucrChkShiftYearName.SetText("")
        ucrChkShiftYearName.SetRDefault("FALSE")

        ucrChkLeapYearNum.SetParameter(New RParameter("leap_year", 3))
        ucrChkLeapYearNum.SetText("")
        ucrChkLeapYearNum.SetRDefault("FALSE")

        'Month
        ucrChkShiftMonthNum.SetParameter(New RParameter("month_val", 4))
        ucrChkShiftMonthNum.SetText("")
        ucrChkShiftMonthNum.SetRDefault("FALSE")

        ucrChkShiftMonthAbbr.SetParameter(New RParameter("month_abbr", 5))
        ucrChkShiftMonthAbbr.SetText("")
        ucrChkShiftMonthAbbr.SetRDefault("FALSE")

        ucrChkShiftMonthName.SetParameter(New RParameter("month_name", 6))
        ucrChkShiftMonthName.SetText("")
        ucrChkShiftMonthName.SetRDefault("FALSE")

        'week
        ucrChkWeekNum.SetParameter(New RParameter("week_val", 7))
        ucrChkWeekNum.SetText("")
        ucrChkWeekNum.SetRDefault("FALSE")

        ucrChkWeekAbbr.SetParameter(New RParameter("week_abbr", 8))
        ucrChkWeekAbbr.SetText("")
        ucrChkWeekAbbr.SetRDefault("FALSE")
        ucrChkWeekAbbr.Enabled = False 'TODO. Temporary

        ucrChkWeekName.SetParameter(New RParameter("week_name", 9))
        ucrChkWeekName.SetText("")
        ucrChkWeekName.SetRDefault("FALSE")
        ucrChkWeekName.Enabled = False 'TODO. Temporary

        'Week day
        ucrChkWeekdayNum.SetParameter(New RParameter("weekday_val", 10))
        ucrChkWeekdayNum.SetText("")
        ucrChkWeekdayNum.SetRDefault("FALSE")

        ucrChkWeekdayAbbr.SetParameter(New RParameter("weekday_abbr", 11))
        ucrChkWeekdayAbbr.SetText("")
        ucrChkWeekdayAbbr.SetRDefault("FALSE")

        ucrChkWeekdayName.SetParameter(New RParameter("weekday_name", 12))
        ucrChkWeekdayName.SetText("")
        ucrChkWeekdayName.SetRDefault("FALSE")

        'Day
        ucrChkDayInMonthNum.SetParameter(New RParameter("day_in_month", 13))
        ucrChkDayInMonthNum.SetText("")
        ucrChkDayInMonthNum.SetRDefault("FALSE")

        ucrChkDaysInMonthNum.SetParameter(New RParameter("days_in_month", 23))
        ucrChkDaysInMonthNum.SetText("")
        ucrChkDaysInMonthNum.SetRDefault("FALSE")

        ucrChkDayInYearNum.SetParameter(New RParameter("day_in_year", 14))
        ucrChkDayInYearNum.SetText("")
        ucrChkDayInYearNum.SetRDefault("FALSE")

        ucrChkShiftDayInYearNum366.SetParameter(New RParameter("day_in_year_366 ", 15))
        ucrChkShiftDayInYearNum366.SetText("")
        ucrChkShiftDayInYearNum366.SetRDefault("FALSE")

        'pentad
        ucrChkShiftPentadNum.SetParameter(New RParameter("pentad_val", 16))
        ucrChkShiftPentadNum.SetText("")
        ucrChkShiftPentadNum.SetRDefault("FALSE")

        ucrChkShiftPentadAbbr.SetParameter(New RParameter("pentad_abbr", 17))
        ucrChkShiftPentadAbbr.SetText("")
        ucrChkShiftPentadAbbr.SetRDefault("FALSE")

        'dekad
        ucrChkShiftDekadNum.SetParameter(New RParameter("dekad_val", 18))
        ucrChkShiftDekadNum.SetText("")
        ucrChkShiftDekadNum.SetRDefault("FALSE")

        ucrChkShiftDekadAbbr.SetParameter(New RParameter("dekad_abbr", 19))
        ucrChkShiftDekadAbbr.SetText("")
        ucrChkShiftDekadAbbr.SetRDefault("FALSE")

        'quarter
        ucrChkShiftQuarterNum.SetParameter(New RParameter("quarter_val", 20))
        ucrChkShiftQuarterNum.SetText("")
        ucrChkShiftQuarterNum.SetRDefault("FALSE")

        ucrChkShiftQuarterAbbr.SetParameter(New RParameter("quarter_abbr", 21))
        ucrChkShiftQuarterAbbr.SetText("")
        ucrChkShiftQuarterAbbr.SetRDefault("FALSE")

        'start month
        Dim dctMonth As New Dictionary(Of String, String)
        dctMonth.Add("January", 1)
        dctMonth.Add("February", 2)
        dctMonth.Add("March", 3)
        dctMonth.Add("April", 4)
        dctMonth.Add("May", 5)
        dctMonth.Add("June", 6)
        dctMonth.Add("July", 7)
        dctMonth.Add("August", 8)
        dctMonth.Add("September", 9)
        dctMonth.Add("October", 10)
        dctMonth.Add("November", 11)
        dctMonth.Add("December", 12)
        ucrInputComboBoxStartingMonth.SetParameter(New RParameter("s_start_month", 22))
        ucrInputComboBoxStartingMonth.SetItems(dctMonth)
        ucrInputComboBoxStartingMonth.SetRDefault(1)
        ucrInputComboBoxStartingMonth.SetDropDownStyleAsNonEditable()
        'TODO This should probably be the default for this control, hence this is temporary
        ucrInputComboBoxStartingMonth.bUpdateRCodeFromControl = False

        ttYearNumeric.SetToolTip(ucrChkShiftYearNum.chkCheck, "When the year is shifted, this gives the starting year, for example 1984-1985 is given as 1984")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorUseDate.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$split_date")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not (ucrReceiverUseDate.IsEmpty) AndAlso (ucrChkWeekName.Checked OrElse ucrChkWeekdayNum.Checked OrElse ucrChkWeekNum.Checked OrElse ucrChkShiftPentadNum.Checked OrElse ucrChkShiftQuarterAbbr.Checked OrElse
                                                      ucrChkShiftPentadAbbr.Checked OrElse ucrChkShiftDekadAbbr.Checked OrElse ucrChkWeekAbbr.Checked OrElse ucrChkShiftMonthNum.Checked OrElse ucrChkLeapYearNum.Checked OrElse
                                                      ucrChkWeekdayName.Checked OrElse ucrChkShiftMonthName.Checked OrElse ucrChkShiftDekadNum.Checked OrElse ucrChkDayInMonthNum.Checked OrElse ucrChkDayInYearNum.Checked OrElse
                                                      ucrChkWeekdayAbbr.Checked OrElse ucrChkShiftMonthAbbr.Checked OrElse ucrChkShiftYearNum.Checked OrElse ucrChkShiftYearName.Checked OrElse ucrChkShiftDayInYearNum366.Checked OrElse
                                                      ucrChkShiftQuarterNum.Checked OrElse ucrChkDaysInMonthNum.Checked AndAlso Not ucrInputComboBoxStartingMonth.IsEmpty)) Then
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

    Private Sub Shifted()
        If ucrInputComboBoxStartingMonth.GetText() = "January" Then
            lblShifted.Visible = False
        Else
            lblShifted.Visible = True
        End If
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverUseDate.ControlContentsChanged, ucrChkWeekName.ControlContentsChanged, ucrChkWeekdayNum.ControlContentsChanged, ucrChkWeekNum.ControlContentsChanged, ucrChkShiftPentadNum.ControlContentsChanged, ucrChkShiftPentadAbbr.ControlContentsChanged, ucrChkShiftDekadAbbr.ControlContentsChanged, ucrChkWeekAbbr.ControlContentsChanged, ucrChkShiftMonthNum.ControlContentsChanged, ucrChkLeapYearNum.ControlContentsChanged, ucrChkWeekdayName.ControlContentsChanged, ucrChkShiftMonthName.ControlContentsChanged, ucrChkShiftDekadNum.ControlContentsChanged, ucrChkDayInMonthNum.ControlContentsChanged, ucrChkDayInYearNum.ControlContentsChanged, ucrChkWeekdayAbbr.ControlContentsChanged, ucrChkShiftMonthAbbr.ControlContentsChanged, ucrChkShiftDayInYearNum366.ControlContentsChanged, ucrChkShiftYearNum.ControlContentsChanged, ucrChkShiftYearName.ControlContentsChanged, ucrChkShiftDayInYearNum366.ControlContentsChanged, ucrChkShiftQuarterNum.ControlContentsChanged, ucrInputComboBoxStartingMonth.ControlContentsChanged, ucrChkDaysInMonthNum.ControlContentsChanged, ucrChkShiftQuarterAbbr.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputComboBoxStartingMonth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboBoxStartingMonth.ControlValueChanged
        Shifted()
    End Sub
End Class