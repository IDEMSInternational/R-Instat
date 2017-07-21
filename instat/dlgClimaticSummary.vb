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
Public Class dlgClimaticSummary
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsGroupByFunction, clsFilterFunction As RFunction
    Dim strCurrDataName As String = ""
    Private Sub dlgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 510
        'setting selector
        ucrSelectorVariable.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariable.SetParameterIsString()

        'setting up receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 1, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0, False))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDay.SetParameter(New RParameter("day", 0))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.Selector = ucrSelectorVariable
        ucrReceiverDay.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDay.bAutoFill = True
        ucrReceiverDay.strSelectorHeading = "Day Variables"

        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 0))
        ucrReceiverMonth.SetParameterIsRFunction()
        ucrReceiverMonth.bWithQuotes = False
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.Selector = ucrSelectorVariable
        ucrReceiverMonth.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("data", 0))
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.strSelectorHeading = "Rain Variables"
        ucrReceiverElement.Selector = ucrSelectorVariable
        ucrReceiverElement.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverElement.bAutoFill = True

        ucrReceiverFrom.Selector = ucrSelectorVariable
        ucrReceiverTo.Selector = ucrSelectorVariable

        'setting up Nuds
        ucrNudFrom.SetMinMax(1, 366)

        ucrNudTo.SetMinMax(1, 366)

        'panel setting
        ucrPnlAnnual.AddRadioButton(rdoAnnual)
        ucrPnlAnnual.AddRadioButton(rdoAnnualVariable)
        ucrPnlAnnual.AddRadioButton(rdoWithinYear)

        ucrInputSave.SetParameter(New RParameter("result_data_frame", 0))

        'linking controls
        ucrPnlAnnual.AddToLinkedControls({ucrNudFrom, ucrNudTo}, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverFrom, ucrReceiverTo}, {rdoAnnualVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverMonth}, {rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrReceiverFrom.SetLinkedDisplayControl(lblReceiverFrom)
        ucrReceiverTo.SetLinkedDisplayControl(lblReceiverTo)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

    End Sub

    Private Sub SetDefaults()
        bResetSubdialog = True
        clsGroupByFunction = New RFunction
        clsFilterFunction = New RFunction

        clsGroupByFunction.SetRCommand("instat_calculation$new")
        clsGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsGroupByFunction.SetAssignTo("grouping")

        clsFilterFunction.SetRCommand("instat_calculation$new")
        clsFilterFunction.SetAssignTo("Annual_filter")
        clsFilterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsFilterFunction.AddParameter("save", 2)
        clsFilterFunction.SetAssignTo("grouping")

        SetGroupByFunction()
        ucrBase.clsRsyntax.SetBaseRFunction(clsGroupByFunction)

    End Sub

    Private Sub SetGroupByFunction()
        'Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""

        strCurrDataName = Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverStation.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverYear.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverStation.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        End If
        If strGroupByCalcFrom <> "" Then
            clsGroupByFunction.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsGroupByFunction.RemoveParameterByName("calculated_from")
        End If

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputSave.AddAdditionalCodeParameterPair(clsFilterFunction, New RParameter("result_data_frame"), iAdditionalPairNo:=1)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdSummary_Click(sender As Object, e As EventArgs) Handles cmdSummary.Click
        sdgClimaticSummary.SetRCode(bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgClimaticSummary.ShowDialog()
    End Sub

    Private Sub ucrReceiverYear_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged
        SetGroupByFunction()
    End Sub

    Private Sub ucrPnlAnnual_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnual.ControlContentsChanged
        If rdoAnnual.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsFilterFunction, iPosition:=1)
        ElseIf rdoAnnualVariable.Checked Then

        ElseIf rdoWithinYear.Checked Then

        End If
    End Sub

    Private Sub ucrReceiverElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged
        clsFilterFunction.AddParameter("function_exp", Chr(34) & ucrReceiverElement.GetVariableNames(False) & ucrNudFrom.GetText & ucrNudTo.GetText & Chr(34))
    End Sub

    Private Sub ucrSelectorVariable_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVariable.ControlContentsChanged
        clsFilterFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")")
    End Sub
End Class