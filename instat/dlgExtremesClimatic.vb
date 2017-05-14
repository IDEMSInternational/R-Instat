'' Instat-R
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
Imports instat
Imports instat.Translations
Public Class dlgExtremesClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsExtreme As New RFunction
    Private clsRunCalcFunc, clsMinMaxCalcFunction, clsMinMaxFilterFunc, clsMinMaxGroupByFunc, clsMinMaxManipulationsFunc, clsMinMaxSummariseFunc, clsMinMaxFuncExp, clsPeaksFunction As New RFunction

    Private Sub dlgExtremesClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
        'helpID
        ucrBase.iHelpTopicID = 203

        ucrReceiverData.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStations.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.Selector = ucrSelectorClimaticExtremes
        ucrReceiverYear.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDOY.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.SetMeAsReceiver()

        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverYear.SetClimaticType("year")

        ucrReceiverStations.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        ucrReceiverData.SetParameter(New RParameter("x", 0))
        ucrReceiverData.bWithQuotes = False

        'ucrRdoOptions
        ucrPnlMinMaxPeaks.AddRadioButton(rdoMinMax)
        ucrPnlMinMaxPeaks.AddRadioButton(rdoPeaks)

        ucrNudFrom.Minimum = 0
        ucrNudFrom.Maximum = 366
        ucrNudTo.Minimum = 0
        ucrNudTo.Maximum = 366

        'ucrchk
        ucrChkMaxima.SetText("Maxima")
        ucrChkMaxima.Checked = True
        ucrChkThreshold.SetText("Values above Threshold")
        ucrChkDayNumber.SetText("Day Number")
        ucrInputThreshhold.SetValidationTypeAsNumeric()

        ucrInputSave.SetParameter(New RParameter("result_name"))

        'ursaveExtremes       
        'ucrSaveExtremes.SetSaveTypeAsColumn()
        'ucrSaveExtremes.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        'ucrSaveExtremes.SetIsTextBox()
        'ucrSaveExtremes.SetLabelText("New Column Name")
        'ucrSaveExtremes.SetPrefix("Value")

        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrInputThreshhold, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputThreshhold.SetLinkedDisplayControl(lblThresh)
        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrChkThreshold, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinMaxPeaks.AddToLinkedControls(ucrChkMaxima, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        'ucrNudFrom.SetRCode(clsMinMaxSummariseFunc, bReset)
        'ucrNudTo.SetRCode(clsMinMaxSummariseFunc, bReset)
        ucrReceiverData.SetRCode(clsMinMaxFuncExp, bReset)
        ucrInputSave.SetRCode(clsMinMaxSummariseFunc, bReset)
    End Sub

    Private Sub SetDefaults()
        clsRunCalcFunc = New RFunction
        clsMinMaxCalcFunction = New RFunction
        clsMinMaxFilterFunc = New RFunction
        clsMinMaxGroupByFunc = New RFunction
        clsMinMaxSummariseFunc = New RFunction
        clsMinMaxManipulationsFunc = New RFunction
        clsMinMaxFuncExp = New RFunction

        ucrSelectorClimaticExtremes.Reset()
        ucrInputThreshhold.ResetText()
        'ucrChkMaxima.Checked = True
        'ucrChkDayNumber.Checked = True
        'ucrChkThreshold.Checked = True

        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("display", "FALSE")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunc)

        clsMinMaxSummariseFunc.SetRCommand("instat_calculation$new")
        clsMinMaxSummariseFunc.SetAssignTo("min_max_summary")
        clsMinMaxSummariseFunc.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsMinMaxSummariseFunc.AddParameter("save", 2)
        clsMinMaxSummariseFunc.AddParameter("manipulations", clsRFunctionParameter:=clsMinMaxManipulationsFunc)

        clsMinMaxManipulationsFunc.SetRCommand("list")
        clsMinMaxManipulationsFunc.AddParameter("filter", clsRFunctionParameter:=clsMinMaxFilterFunc, bIncludeArgumentName:=False)
        clsMinMaxManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsMinMaxGroupByFunc, bIncludeArgumentName:=False)

        clsMinMaxFilterFunc.SetRCommand("instat_calculation$new")
        clsMinMaxFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsMinMaxFilterFunc.SetAssignTo("day_of_year_filter")

        clsMinMaxGroupByFunc.SetRCommand("instat_calculation$new")
        clsMinMaxGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsMinMaxGroupByFunc.SetAssignTo("grouping")

        clsMinMaxFuncExp.SetRCommand("max")
        'TODO Make option on dialog
        clsMinMaxFuncExp.AddParameter("na.rm", "TRUE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub TestOkEnabled()
        'If (rdoMinMax.Checked AndAlso Not ucrReceiverYear.IsEmpty() AndAlso Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDOY.IsEmpty() AndAlso Not ucrReceiverData.IsEmpty()) Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkMaxima_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMaxima.ControlValueChanged
        If ucrChkMaxima.Checked Then
            clsMinMaxFuncExp.SetRCommand("max")
        Else
            clsMinMaxFuncExp.SetRCommand("min")
        End If
        SetMinMaxFunctionExp()
    End Sub

    Private Sub SetSummaryFuncCalcFrom()
        Dim strCurrDataName As String = ""

        If Not ucrReceiverData.IsEmpty() Then
            clsMinMaxSummariseFunc.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
        Else
            clsMinMaxSummariseFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub SetFilterFuncCalcFrom()
        Dim strCurrDataName As String = ""

        If Not ucrReceiverDOY.IsEmpty() Then
            clsMinMaxFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
            clsMinMaxFilterFunc.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
        Else
            clsMinMaxFilterFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""

        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverStations.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverStations.GetVariableNames() & ")"
        ElseIf Not ucrReceiverYear.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverStations.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStations.GetVariableNames() & ")"
        End If
        If strGroupByCalcFrom <> "" Then
            clsMinMaxGroupByFunc.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsMinMaxGroupByFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub SetMinMaxFunctionExp()
        clsMinMaxSummariseFunc.AddParameter("function_exp", Chr(34) & clsMinMaxFuncExp.ToScript() & Chr(34))
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMinMaxPeaks.ControlValueChanged
        If Not ucrInputSave.bUserTyped Then
            If rdoMinMax.Checked Then
                If ucrChkMaxima.Checked Then
                    ucrInputSave.SetName("max")
                Else
                    ucrInputSave.SetName("min")
                End If
            ElseIf rdoPeaks.Checked Then
                ucrInputSave.SetName("value")
            End If
        End If
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrReceiverStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStations.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        SetFilterFuncCalcFrom()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged
        SetSummaryFuncCalcFrom()
    End Sub
End Class