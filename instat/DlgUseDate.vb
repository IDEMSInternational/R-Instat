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
    Public bFirstLoad As Boolean = True
    Private Sub dlgUseDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 462
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$split_date")
        ucrSaveDateResultInto.SetItemsTypeAsColumns()
        ucrSaveDateResultInto.SetDefaultTypeAsColumn()
        ucrSaveDateResultInto.SetDataFrameSelector(ucrSelectorUseDate.ucrAvailableDataFrames)
        ucrSaveDateResultInto.SetValidationTypeAsRVariable()
        ucrReceiverUseDate.Selector = ucrSelectorUseDate
        ucrReceiverUseDate.SetMeAsReceiver()

    End Sub

    Private Sub ReopenDialog()
        SaveResults()
    End Sub

    Private Sub SetDefaults()
        chkDayInMonth.Checked = False
        chkDayInYear.Checked = False
        chkDayYear.Checked = False
        chkDecade.Checked = False
        chkLeapYear.Checked = False
        chkMonth.Checked = False
        chkPentade.Checked = False
        chkWeekDay.Checked = False
        chkYear.Checked = False
        chkWeek.Checked = False
        chkSaveDateResultInto.Checked = True
        rdoNone.Checked = True
        ucrReceiverUseDate.Clear()
        ucrSaveDateResultInto.SetPrefix("Date")
        ucrSaveDateResultInto.Reset()
        'Remains Disabled until implemented
        chkPentade.Enabled = False
        chkDecade.Enabled = False
        chkLeapYear.Enabled = False
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not (ucrReceiverUseDate.IsEmpty) AndAlso (chkYear.Checked OrElse chkDayInMonth.Checked OrElse chkDayInYear.Checked OrElse chkDayYear.Checked OrElse chkDecade.Checked OrElse chkLeapYear.Checked OrElse chkMonth.Checked OrElse chkPentade.Checked OrElse chkWeekDay.Checked OrElse chkWeek.Checked) AndAlso (rdoFull.Checked OrElse rdoNone.Checked OrElse rdoAbrreviated.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverUseDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverUseDate.SelectionChanged
        'Restricting the datatypes that the date-time functions take to avoid errors in execution
        ucrReceiverUseDate.SetIncludedDataTypes({"Date"})
        If Not ucrReceiverUseDate.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverUseDate.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetParameters()
        If rdoNone.Checked Then
            chkDayYear.Enabled = True
            chkDayInYear.Enabled = True
            chkDayInMonth.Enabled = True
            chkDayInYear.Enabled = True
            chkWeek.Enabled = True
            chkYear.Enabled = True
            If chkYear.Checked Then
                ucrBase.clsRsyntax.AddParameter("year", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("year")

            End If

            If chkMonth.Checked Then
                ucrBase.clsRsyntax.AddParameter("month_val", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("month_val")

            End If
            If chkWeekDay.Checked Then
                ucrBase.clsRsyntax.AddParameter("weekday_val", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("weekday_val")
            End If

            If chkDayInMonth.Checked Then
                ucrBase.clsRsyntax.AddParameter("day", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("day")
            End If

            If chkWeek.Checked Then
                ucrBase.clsRsyntax.AddParameter("week", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("week")
            End If
        ElseIf rdoAbrreviated.Checked Then
            chkDayYear.Enabled = False
            chkDayInYear.Enabled = False
            chkDayInMonth.Enabled = False
            chkDayInYear.Enabled = False
            chkWeek.Enabled = False
            chkYear.Enabled = False
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("month_val")
            ucrBase.clsRsyntax.RemoveParameter("month_name")
            ucrBase.clsRsyntax.RemoveParameter("week")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("weekday_name")
            ucrBase.clsRsyntax.RemoveParameter("weekday_val")
            If chkMonth.Checked Then
                ucrBase.clsRsyntax.AddParameter("month_abbr", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("month_abbr")

            End If

            If chkWeekDay.Checked Then
                ucrBase.clsRsyntax.AddParameter("weekday_abbr", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("weekday_abbr")
            End If

        Else

            chkDayYear.Enabled = False
            chkDayInYear.Enabled = False
            chkDayInMonth.Enabled = False
            chkDayInYear.Enabled = False
            chkLeapYear.Enabled -= False
            chkWeek.Enabled = False
            chkYear.Enabled = False
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("month_val")
            ucrBase.clsRsyntax.RemoveParameter("month_abbr")
            ucrBase.clsRsyntax.RemoveParameter("week")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("weekday_abbr")
            ucrBase.clsRsyntax.RemoveParameter("weekday_val")
            If chkMonth.Checked Then
                ucrBase.clsRsyntax.AddParameter("month_name", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("month_name")

            End If

            If chkWeekDay.Checked Then
                ucrBase.clsRsyntax.AddParameter("weekday_name", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("weekday_name")
            End If

        End If
    End Sub

    Private Sub chkYear_CheckedChanged(sender As Object, e As EventArgs) Handles chkYear.CheckedChanged, chkDayInMonth.CheckedChanged, chkDayInYear.CheckedChanged, chkDayYear.CheckedChanged, chkDecade.CheckedChanged, chkLeapYear.CheckedChanged, chkMonth.CheckedChanged, chkPentade.CheckedChanged, chkWeekDay.CheckedChanged, chkWeek.CheckedChanged
        SetParameters()
        TestOKEnabled()
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorUseDate_DataFrameChanged() Handles ucrSelectorUseDate.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorUseDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub SaveResults()
        If chkSaveDateResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveDateResultInto.GetText(), strTempColumn:=ucrSaveDateResultInto.GetText(), strTempDataframe:=ucrSelectorUseDate.ucrAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrSaveDateResultInto_NameChanged() Handles ucrSaveDateResultInto.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveDateResultInto.GetText, strTempDataframe:=ucrSelectorUseDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDateResultInto.GetText, bAssignToIsPrefix:=False)
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub chkSaveEnterResultInto_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveDateResultInto.CheckedChanged
        If chkSaveDateResultInto.Checked Then
            ucrSaveDateResultInto.Visible = True
        Else
            ucrSaveDateResultInto.Visible = False
        End If
        SaveResults()
    End Sub

    Private Sub rdoNone_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNone.CheckedChanged, rdoAbrreviated.CheckedChanged, rdoFull.CheckedChanged
        SetParameters()
        TestOKEnabled()
    End Sub
End Class