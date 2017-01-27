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
        '        ucrSelectorUseDate.SetParameterIsString()

        ' Receiver
        ucrReceiverUseDate.SetParameter(New RParameter("col_name"))
        ucrReceiverUseDate.Selector = ucrSelectorUseDate
        ucrReceiverUseDate.SetMeAsReceiver()
        ucrReceiverUseDate.bUseFilteredData = False
        ucrReceiverUseDate.SetIncludedDataTypes({"Date"})
        ucrReceiverUseDate.SetParameterIsString()

        ' Default R Function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$graph_one_variable")


        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$split_date")

        'Restricting the datatypes that the date-time functions take to avoid errors in execution







    End Sub

    Private Sub SetDefaults()
        ucrSelectorUseDate.Reset()
        chkAbbrMonthName.Checked = False
        chkAbbrWeekDay.Checked = False
        chkDayInMonth.Checked = False
        chkDayInYear.Checked = False
        chkDayYear366.Checked = False
        chkDekade.Checked = False
        chkLeapYear.Checked = False
        chkMonthNam.Checked = False
        chkMonthValue.Checked = False
        chkPentad.Checked = False
        chkWeek.Checked = False
        chkWeekdayName.Checked = False
        chkWeekDayVal.Checked = False
        chkYear.Checked = False
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not (ucrReceiverUseDate.IsEmpty) AndAlso (chkYear.Checked OrElse chkDayInMonth.Checked OrElse chkDayInYear.Checked OrElse chkDayYear366.Checked OrElse chkDekade.Checked OrElse chkLeapYear.Checked OrElse chkMonthValue.Checked OrElse chkPentad.Checked OrElse chkWeekDayVal.Checked OrElse chkWeek.Checked OrElse chkAbbrMonthName.Checked OrElse chkMonthNam.Checked OrElse chkWeekdayName.Checked OrElse chkAbbrWeekDay.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverUseDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverUseDate.SelectionChanged
        If Not ucrReceiverUseDate.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverUseDate.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetParameters()
        If chkYear.Checked Then
            ucrBase.clsRsyntax.AddParameter("year", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("year")
        End If

        If chkMonthValue.Checked Then
            ucrBase.clsRsyntax.AddParameter("month_val", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("month_val")
        End If

        If chkMonthNam.Checked Then
            ucrBase.clsRsyntax.AddParameter("month_name", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("month_name")
        End If

        If chkAbbrMonthName.Checked Then
            ucrBase.clsRsyntax.AddParameter("month_abbr", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("month_abbr")
        End If

        If chkWeekDayVal.Checked Then
            ucrBase.clsRsyntax.AddParameter("weekday_val", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("weekday_val")
        End If

        If chkAbbrWeekDay.Checked Then
            ucrBase.clsRsyntax.AddParameter("weekday_abbr", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("weekday_abbr")
        End If

        If chkWeekdayName.Checked Then
            ucrBase.clsRsyntax.AddParameter("weekday_name", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("weekday_name")
        End If

        If chkWeek.Checked Then
            ucrBase.clsRsyntax.AddParameter("week", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("week")
        End If

        If chkDayInMonth.Checked Then
            ucrBase.clsRsyntax.AddParameter("day_in_month", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("day_in_month")
        End If

        If chkDayInYear.Checked Then
            ucrBase.clsRsyntax.AddParameter("day_in_year", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("day_in_year")
        End If

        If chkLeapYear.Checked Then
            ucrBase.clsRsyntax.AddParameter("leap_year", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("leap_year")
        End If

        If chkDayYear366.Checked Then
            ucrBase.clsRsyntax.AddParameter("day_in_year_366", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("day_in_year_366")
        End If


        If chkDekade.Checked Then
            ucrBase.clsRsyntax.AddParameter("dekade", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("dekade")
        End If

        If chkPentad.Checked Then
            ucrBase.clsRsyntax.AddParameter("pentad", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("pentad")
        End If


    End Sub

    Private Sub grpDateFunctions_CheckedChanged(sender As Object, e As EventArgs) Handles chkDekade.CheckedChanged, chkLeapYear.CheckedChanged, chkPentad.CheckedChanged, chkAbbrWeekDay.CheckedChanged
        SetParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorUseDate_DataFrameChanged() Handles ucrSelectorUseDate.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorUseDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

End Class