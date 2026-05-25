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
    Public enumUsedateMode As String = UsedateMode.Prepare
    Public Enum UsedateMode
        Prepare
        Climatic
    End Enum

    Private bReset As Boolean = True
    Public bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""
    Private clsDefaultFunction As New RFunction
    Private clsHelp As New RFunction
    Private ttFormat As New ToolTip()

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
        SetHelpOptions()
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 462

        'Initialize Help function
        clsHelp = New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("topic", Chr(34) & "strptime" & Chr(34))
        clsHelp.AddParameter("package", Chr(34) & "base" & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))

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

        'Format controls
        Dim dctFormat As New Dictionary(Of String, String)
        ' Add the examples at the top of the dropdown - using proper R format codes
        dctFormat.Add("Jan 5", Chr(34) & "%b %d" & Chr(34))
        dctFormat.Add("January 5", Chr(34) & "%B %d" & Chr(34))
        dctFormat.Add("5 Jan 2025", Chr(34) & "%d %b %Y" & Chr(34))
        dctFormat.Add("5 Jan 25", Chr(34) & "%d %b %y" & Chr(34))
        dctFormat.Add("Mon 5 Jan", Chr(34) & "%a %d %b" & Chr(34))
        dctFormat.Add("Monday 5 January 2025", Chr(34) & "%A %d %B %Y" & Chr(34))
        dctFormat.Add("05/01/2025", Chr(34) & "%d/%m/%Y" & Chr(34))

        ' Add individual format codes
        dctFormat.Add("Day as number (01-31)", Chr(34) & "%d" & Chr(34))
        dctFormat.Add("Day of year (001-366)", Chr(34) & "%j" & Chr(34))
        dctFormat.Add("Month as number (01-12)", Chr(34) & "%m" & Chr(34))
        dctFormat.Add("Abbreviated month name", Chr(34) & "%b" & Chr(34))
        dctFormat.Add("Full month name", Chr(34) & "%B" & Chr(34))
        dctFormat.Add("2-digit year", Chr(34) & "%y" & Chr(34))
        dctFormat.Add("4-digit year", Chr(34) & "%Y" & Chr(34))
        dctFormat.Add("Abbreviated weekday name", Chr(34) & "%a" & Chr(34))
        dctFormat.Add("Full weekday name", Chr(34) & "%A" & Chr(34))

        ucrInputComboBoxNewFormat.SetParameter(New RParameter("format_string", 5))
        ucrInputComboBoxNewFormat.SetItems(dctFormat)
        ucrInputComboBoxNewFormat.bUpdateRCodeFromControl = True
        ucrInputComboBoxNewFormat.AddQuotesIfUnrecognised = True
        ucrInputComboBoxNewFormat.bAllowNonConditionValues = True
        ucrInputComboBoxNewFormat.SetToValue("Jan 5")

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
        ucrChkShiftMonthNum.SetParameter(New RParameter("month_val", 7))
        ucrChkShiftMonthNum.SetText("")
        ucrChkShiftMonthNum.SetRDefault("FALSE")

        ucrChkShiftMonthAbbr.SetParameter(New RParameter("month_abbr", 8))
        ucrChkShiftMonthAbbr.SetText("")
        ucrChkShiftMonthAbbr.SetRDefault("FALSE")

        ucrChkShiftMonthName.SetParameter(New RParameter("month_name", 9))
        ucrChkShiftMonthName.SetText("")
        ucrChkShiftMonthName.SetRDefault("FALSE")

        'week
        ucrChkWeekNum.SetParameter(New RParameter("week_val", 10))
        ucrChkWeekNum.SetText("")
        ucrChkWeekNum.SetRDefault("FALSE")

        ucrChkWeekAbbr.SetParameter(New RParameter("week_abbr", 11))
        ucrChkWeekAbbr.SetText("")
        ucrChkWeekAbbr.SetRDefault("FALSE")
        ucrChkWeekAbbr.Enabled = False 'TODO. Temporary

        ucrChkWeekName.SetParameter(New RParameter("week_name", 12))
        ucrChkWeekName.SetText("")
        ucrChkWeekName.SetRDefault("FALSE")
        ucrChkWeekName.Enabled = False 'TODO. Temporary

        'Week day
        ucrChkWeekdayNum.SetParameter(New RParameter("weekday_val", 13))
        ucrChkWeekdayNum.SetText("")
        ucrChkWeekdayNum.SetRDefault("FALSE")

        ucrChkWeekdayAbbr.SetParameter(New RParameter("weekday_abbr", 14))
        ucrChkWeekdayAbbr.SetText("")
        ucrChkWeekdayAbbr.SetRDefault("FALSE")

        ucrChkWeekdayName.SetParameter(New RParameter("weekday_name", 15))
        ucrChkWeekdayName.SetText("")
        ucrChkWeekdayName.SetRDefault("FALSE")

        'Day
        ucrChkDayInMonthNum.SetParameter(New RParameter("day_in_month", 16))
        ucrChkDayInMonthNum.SetText("")
        ucrChkDayInMonthNum.SetRDefault("FALSE")

        ucrChkDaysInMonthNum.SetParameter(New RParameter("days_in_month", 26))
        ucrChkDaysInMonthNum.SetText("")
        ucrChkDaysInMonthNum.SetRDefault("FALSE")

        ucrChkDayInYearNum.SetParameter(New RParameter("day_in_year", 17))
        ucrChkDayInYearNum.SetText("")
        ucrChkDayInYearNum.SetRDefault("FALSE")

        ucrChkShiftDayInYearNum366.SetParameter(New RParameter("day_in_year_366 ", 18))
        ucrChkShiftDayInYearNum366.SetText("")
        ucrChkShiftDayInYearNum366.SetRDefault("FALSE")

        'pentad
        ucrChkShiftPentadNum.SetParameter(New RParameter("pentad_val", 19))
        ucrChkShiftPentadNum.SetText("")
        ucrChkShiftPentadNum.SetRDefault("FALSE")

        ucrChkShiftPentadAbbr.SetParameter(New RParameter("pentad_abbr", 20))
        ucrChkShiftPentadAbbr.SetText("")
        ucrChkShiftPentadAbbr.SetRDefault("FALSE")

        'dekad
        ucrChkShiftDekadNum.SetParameter(New RParameter("dekad_val", 21))
        ucrChkShiftDekadNum.SetText("")
        ucrChkShiftDekadNum.SetRDefault("FALSE")

        ucrChkShiftDekadAbbr.SetParameter(New RParameter("dekad_abbr", 22))
        ucrChkShiftDekadAbbr.SetText("")
        ucrChkShiftDekadAbbr.SetRDefault("FALSE")

        'quarter
        ucrChkShiftQuarterNum.SetParameter(New RParameter("quarter_val", 23))
        ucrChkShiftQuarterNum.SetText("")
        ucrChkShiftQuarterNum.SetRDefault("FALSE")

        ucrChkShiftQuarterAbbr.SetParameter(New RParameter("quarter_abbr", 24))
        ucrChkShiftQuarterAbbr.SetText("")
        ucrChkShiftQuarterAbbr.SetRDefault("FALSE")


        ucrPnluseformat.SetParameter(New RParameter("format_date", 4))
        ucrPnluseformat.AddRadioButton(rdoUseColumn, "FALSE")
        ucrPnluseformat.AddRadioButton(rdoFormatColumn, "TRUE")
        ucrPnluseformat.bUpdateRCodeFromControl = True
        ucrPnluseformat.bChangeParameterValue = True

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
        ucrInputComboBoxStartingMonth.SetParameter(New RParameter("s_start_month", 25))
        ucrInputComboBoxStartingMonth.SetItems(dctMonth)
        ucrInputComboBoxStartingMonth.SetRDefault(1)
        ucrInputComboBoxStartingMonth.SetDropDownStyleAsNonEditable()
        'TODO This should probably be the default for this control, hence this is temporary
        ucrInputComboBoxStartingMonth.bUpdateRCodeFromControl = False

        ttYearNumeric.SetToolTip(ucrChkShiftYearNum.chkCheck, "When the year is shifted, this gives the starting year, for example 1984-1985 is given as 1984")

        'New Column Name
        ucrNewColumnName.SetParameter(New RParameter("new_col_name", 6))
        ucrNewColumnName.SetName("format_date")
        ucrNewColumnName.bUpdateRCodeFromControl = True
        ucrNewColumnName.SetLinkedDisplayControl(lblNewColumnName)

        'Linking
        ucrPnluseformat.AddToLinkedControls(ucrNewColumnName, {rdoFormatColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnluseformat.AddToLinkedControls(ucrInputComboBoxNewFormat, {rdoFormatColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Link "Use" components to rdoUseColumn so they are removed in Format mode
        Dim lstUseControls As New List(Of ucrCore)({ucrChkShiftYearNum, ucrChkShiftYearName, ucrChkLeapYearNum, ucrChkShiftMonthNum, ucrChkShiftMonthAbbr, ucrChkShiftMonthName, ucrChkWeekNum, ucrChkWeekAbbr, ucrChkWeekName, ucrChkWeekdayNum, ucrChkWeekdayAbbr, ucrChkWeekdayName, ucrChkDayInMonthNum, ucrChkDaysInMonthNum, ucrChkDayInYearNum, ucrChkShiftDayInYearNum366, ucrChkShiftPentadNum, ucrChkShiftPentadAbbr, ucrChkShiftDekadNum, ucrChkShiftDekadAbbr, ucrChkShiftQuarterNum, ucrChkShiftQuarterAbbr, ucrInputComboBoxStartingMonth})
        ucrPnluseformat.AddToLinkedControls(lstUseControls.ToArray(), {rdoUseColumn}, bNewLinkedAddRemoveParameter:=True)

        For Each ucr In lstUseControls
            ucr.bUpdateRCodeFromControl = True
        Next

        rdoUseColumn.Checked = True
        UpdatePanelVisibility()
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$split_date")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

        ucrSelectorUseDate.Reset()
        ucrPnluseformat.SetToValue(rdoUseColumn)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, clsDefaultFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoFormatColumn.Checked Then
            If Not ucrReceiverUseDate.IsEmpty() AndAlso Not ucrInputComboBoxNewFormat.IsEmpty() AndAlso Not ucrNewColumnName.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else

            If (Not (ucrReceiverUseDate.IsEmpty) AndAlso (ucrChkWeekName.Checked OrElse ucrChkWeekdayNum.Checked OrElse ucrChkWeekNum.Checked OrElse ucrChkShiftPentadNum.Checked OrElse ucrChkShiftQuarterAbbr.Checked OrElse
                                                      ucrChkShiftPentadAbbr.Checked OrElse ucrChkShiftDekadAbbr.Checked OrElse ucrChkWeekAbbr.Checked OrElse ucrChkShiftMonthNum.Checked OrElse ucrChkLeapYearNum.Checked OrElse
                                                      ucrChkWeekdayName.Checked OrElse ucrChkShiftMonthName.Checked OrElse ucrChkShiftDekadNum.Checked OrElse ucrChkDayInMonthNum.Checked OrElse ucrChkDayInYearNum.Checked OrElse
                                                      ucrChkWeekdayAbbr.Checked OrElse ucrChkShiftMonthAbbr.Checked OrElse ucrChkShiftYearNum.Checked OrElse ucrChkShiftYearName.Checked OrElse ucrChkShiftDayInYearNum366.Checked OrElse
                                                      ucrChkShiftQuarterNum.Checked OrElse ucrChkDaysInMonthNum.Checked AndAlso Not ucrInputComboBoxStartingMonth.IsEmpty)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
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

    Private Sub SetHelpOptions()
        Select Case enumUsedateMode
            Case UsedateMode.Prepare
                ucrBase.iHelpTopicID = 462
            Case UsedateMode.Climatic
                ucrBase.iHelpTopicID = 494
        End Select
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverUseDate.ControlContentsChanged, ucrChkWeekName.ControlContentsChanged, ucrChkWeekdayNum.ControlContentsChanged, ucrChkWeekNum.ControlContentsChanged, ucrChkShiftPentadNum.ControlContentsChanged, ucrChkShiftPentadAbbr.ControlContentsChanged, ucrChkShiftDekadAbbr.ControlContentsChanged, ucrChkWeekAbbr.ControlContentsChanged, ucrChkShiftMonthNum.ControlContentsChanged, ucrChkLeapYearNum.ControlContentsChanged, ucrChkWeekdayName.ControlContentsChanged, ucrChkShiftMonthName.ControlContentsChanged, ucrChkShiftDekadNum.ControlContentsChanged, ucrChkDayInMonthNum.ControlContentsChanged, ucrChkDayInYearNum.ControlContentsChanged, ucrChkWeekdayAbbr.ControlContentsChanged, ucrChkShiftMonthAbbr.ControlContentsChanged, ucrChkShiftDayInYearNum366.ControlContentsChanged, ucrChkShiftYearNum.ControlContentsChanged, ucrChkShiftYearName.ControlContentsChanged, ucrChkShiftQuarterNum.ControlContentsChanged, ucrInputComboBoxStartingMonth.ControlContentsChanged, ucrChkDaysInMonthNum.ControlContentsChanged, ucrChkShiftQuarterAbbr.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged, ucrInputComboBoxNewFormat.ControlContentsChanged, ucrPnluseformat.ControlContentsChanged
        If ucrChangedControl Is ucrPnluseformat Then
            UpdatePanelVisibility()
        End If
        TestOKEnabled()
    End Sub

    Private Sub UpdatePanelVisibility()
        Panelusemode.Visible = rdoUseColumn.Checked
        Panelformatmode.Visible = rdoFormatColumn.Checked
        grpUseColumnnewfrm.Visible = rdoFormatColumn.Checked
        grpfrmdescrp.Visible = rdoFormatColumn.Checked
        cmdHelp.Visible = rdoFormatColumn.Checked
    End Sub

    Private Sub ucrInputComboBoxStartingMonth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboBoxStartingMonth.ControlValueChanged
        Shifted()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        frmMain.clsRLink.RunScript(clsHelp.ToScript, iCallType:=2, strComment:="Display Help page for Date-Time Conversion Functions", bSeparateThread:=False, bUpdateGrids:=False)
    End Sub
End Class