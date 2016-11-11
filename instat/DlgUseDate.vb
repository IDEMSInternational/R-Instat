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
' You should have received a copy of the GNU General Public License k
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
        chkWeek.Checked = False
        chkWeekDay.Checked = False
        chkYear.Checked = False
        ucrSaveDateResultInto.SetPrefix("Year")
        ucrSaveDateResultInto.Reset()
        chkSaveDateResultInto.Checked = True
        rdoNone.Checked = True
        ucrReceiverUseDate.Clear()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ((ucrReceiverUseDate.IsEmpty) AndAlso Not (chkYear.Checked OrElse chkDayInMonth.Checked OrElse chkDayInYear.Checked OrElse chkDayYear.Checked OrElse chkDecade.Checked OrElse chkLeapYear.Checked OrElse chkMonth.Checked OrElse chkPentade.Checked OrElse chkWeek.Checked OrElse chkWeekDay.Checked)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverUseDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverUseDate.SelectionChanged
        If Not ucrReceiverUseDate.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverUseDate.GetVariables())
        End If
        DateFunctions()
        TestOKEnabled()
    End Sub

    Private Sub chkYear_CheckedChanged(sender As Object, e As EventArgs) Handles chkYear.CheckedChanged, chkDayInMonth.CheckedChanged, chkDayInYear.CheckedChanged, chkDayYear.CheckedChanged, chkDecade.CheckedChanged, chkLeapYear.CheckedChanged, chkMonth.CheckedChanged, chkPentade.CheckedChanged, chkWeek.CheckedChanged, chkWeekDay.CheckedChanged
        DateFunctions()
    End Sub

    Private Sub DateFunctions()
        If chkYear.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::year")
        End If

        If chkMonth.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::month")
        End If

        If chkWeek.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::week")
        End If

        If chkDayInYear.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::yday")
        End If

        If chkDayInMonth.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::mday")
        End If

        If chkWeekDay.Checked Then
            ucrBase.clsRsyntax.SetFunction("lubridate::wday")
        End If

        If chkDayYear.Checked Then
            ucrBase.clsRsyntax.SetFunction("")
        End If

        If chkLeapYear.Checked Then
            ucrBase.clsRsyntax.SetFunction("")
        End If

        If chkPentade.Checked Then
            ucrBase.clsRsyntax.SetFunction("")
        End If
        If chkDecade.Checked Then
            ucrBase.clsRsyntax.SetFunction("")
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub


    Private Sub ucrSelectorUseDate_DataFrameChanged() Handles ucrSelectorUseDate.DataFrameChanged
        DateFunctions()
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

End Class