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
    Private clsRunCalcFunc, clsMinMaxCalcFunction, clsMinMaxGroupByFunc, clsMinMaxManipulationsFunc, clsMinMaxSummariseFunc, clsMinMaxFuncExp, clsPeaksFunction As New RFunction

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

        ucrReceiverYear.Selector = ucrSelectorClimaticExtremes

        ucrReceiverStations.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True

        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetMeAsReceiver()

        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.Selector = ucrSelectorClimaticExtremes

        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True

        ucrReceiverElement.Selector = ucrSelectorClimaticExtremes
        ucrReceiverElement.SetParameter(New RParameter("x", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.bAutoFill = True

        'ucrRdoOptions
        ucrPnlExtremesType.AddRadioButton(rdoMinMax)
        ucrPnlExtremesType.AddRadioButton(rdoPeaks)

        ucrPnlMaxMin.AddRadioButton(rdoMax)
        ucrPnlMaxMin.AddRadioButton(rdoMin)
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMax, "max")
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMin, "min")

        ucrChkDayNumber.SetText("Include Day of Occurance")

        ucrInputThresholdValue.SetValidationTypeAsNumeric()
        ucrInputThresholdValue.SetLinkedDisplayControl(lblValues)

        ucrInputThresholdOperator.SetItems({"Greater than", "Less than", "Greater than or equal to", "Less than or equal to"})

        ucrInputSave.SetParameter(New RParameter("result_name"))

        'ursaveExtremes       
        'ucrSaveExtremes.SetSaveTypeAsColumn()
        'ucrSaveExtremes.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        'ucrSaveExtremes.SetIsTextBox()
        'ucrSaveExtremes.SetLabelText("New Column Name")
        'ucrSaveExtremes.SetPrefix("Value")

        ucrPnlExtremesType.AddToLinkedControls({ucrInputThresholdValue, ucrInputThresholdOperator}, {rdoPeaks}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrPnlMaxMin, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverElement.SetRCode(clsMinMaxFuncExp, bReset)
        ucrInputSave.SetRCode(clsMinMaxSummariseFunc, bReset)
        ucrPnlMaxMin.SetRCode(clsMinMaxFuncExp)
    End Sub

    Private Sub SetDefaults()
        clsRunCalcFunc = New RFunction
        clsMinMaxCalcFunction = New RFunction
        clsMinMaxGroupByFunc = New RFunction
        clsMinMaxSummariseFunc = New RFunction
        clsMinMaxManipulationsFunc = New RFunction
        clsMinMaxFuncExp = New RFunction

        ucrSelectorClimaticExtremes.Reset()
        ucrInputThresholdValue.Reset()

        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("display", "FALSE")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunc)

        clsMinMaxSummariseFunc.SetRCommand("instat_calculation$new")
        clsMinMaxSummariseFunc.SetAssignTo("min_max_summary")
        clsMinMaxSummariseFunc.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsMinMaxSummariseFunc.AddParameter("save", 2)
        clsMinMaxSummariseFunc.AddParameter("manipulations", clsRFunctionParameter:=clsMinMaxManipulationsFunc)

        clsMinMaxManipulationsFunc.SetRCommand("list")
        clsMinMaxManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsMinMaxGroupByFunc, bIncludeArgumentName:=False)

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

    Private Sub SetMinMaxSummaryParams()
        Dim strCurrDataName As String = ""

        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverElement.IsEmpty() Then
            clsMinMaxSummariseFunc.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")")
            clsMinMaxSummariseFunc.AddParameter("function_exp", Chr(34) & clsMinMaxFuncExp.ToScript() & Chr(34))
        Else
            clsMinMaxSummariseFunc.RemoveParameterByName("calculated_from")
            clsMinMaxSummariseFunc.RemoveParameterByName("function_exp")
        End If
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremesType.ControlValueChanged
        If Not ucrInputSave.bUserTyped Then
            If rdoMinMax.Checked Then
                If rdoMax.Checked Then
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

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged
        SetMinMaxSummaryParams()
    End Sub

    Private Sub ucrPnlMaxMin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMaxMin.ControlValueChanged
        If rdoMax.Checked Then
            clsMinMaxFuncExp.SetRCommand("max")
        ElseIf rdoMin.Checked Then
            clsMinMaxFuncExp.SetRCommand("min")
        End If
        SetMinMaxSummaryParams()
    End Sub
End Class