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
    Private clsMinmaxFunction, clsMinmaxFilterFunction, clsMinmaxGroupFunction, clsMinmaxsummaryFunction, clsPeaksFunction As New RFunction
    Private strCurrDataName As String = ""
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

        ucrReceiverStations.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        'ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "Data" & Chr(34)})


        ucrReceiverStations.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        'clsMinmaxFunction.SetRCommand("instat_calculation$new")
        'clsMinmaxFunction.SetAssignTo("extreme_calculation")
        clsMinmaxFilterFunction.SetRCommand("instat_calculation$new")
        clsMinmaxFilterFunction.SetAssignTo("min_max_filter")
        clsMinmaxGroupFunction.SetRCommand("instat_calculation$new")
        clsMinmaxGroupFunction.SetAssignTo("min_max_group")
        clsMinmaxsummaryFunction.SetRCommand("instat_calculation$new")
        clsMinmaxsummaryFunction.SetAssignTo("min_max_summary")
        'clsSumFuncExpr.SetRCommand("rollapply")

        'ucrRdoOptions
        ucrPnlMinMaxPeaks.AddRadioButton(rdoMinMax)
        ucrPnlMinMaxPeaks.AddRadioButton(rdoPeaks)

        ucrNudFrom.Minimum = 0
        ucrNudTo.Minimum = 0

        'ucrchk
        ucrChkMaxima.SetText("Maxima")
        ucrChkMaxima.Checked = True
        ucrChkThreshold.SetText("Values above Threshold")
        ucrChkDayNumber.SetText("Day Number")
        ucrInputThreshhold.SetValidationTypeAsNumeric()

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
        ucrNudFrom.SetRCode(clsMinmaxFunction, bReset)
        ucrNudTo.SetRCode(clsMinmaxFunction, bReset)
        ucrReceiverData.SetRCode(clsMinmaxFunction, bReset)
        'ucrPnlMinMaxPeaks.SetRCode(clsMinmaxFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorClimaticExtremes.Reset()
        'ucrSaveExtremes.Reset()
        ucrInputThreshhold.ResetText()
        ucrChkMaxima.Checked = True
        ucrChkDayNumber.Checked = True
        ucrChkThreshold.Checked = True

        clsMinmaxFilterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsMinmaxGroupFunction.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsMinmaxsummaryFunction.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsMinmaxsummaryFunction.AddParameter("manipulations", "list(min_max_filter,min_max_group)")
        clsMinmaxsummaryFunction.AddParameter("save", 2)
        clsMinmaxsummaryFunction.AddParameter("result_name", Chr(34) & "new_column" & Chr(34))
        clsMinmaxsummaryFunction.AddParameter("function_exp", Chr(34) & "max(Rain)" & Chr(34))
        clsMinmaxFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsMinmaxFunction.AddParameter("calc", clsRFunctionParameter:=clsMinmaxsummaryFunction)
        ucrBase.clsRsyntax.SetBaseRFunction(clsMinmaxFunction)
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

    Private Sub ucrSelectorClimaticExtremes_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorClimaticExtremes.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsMinmaxFilterFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
        clsMinmaxGroupFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "= " & ucrReceiverYear.GetVariableNames() & ")")
        clsMinmaxsummaryFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
    End Sub


    'Private Sub ucrSelectorClimaticExtremes_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorClimaticExtremes.ControlContentsChanged
    '    strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
    '    clsMinmaxFilterFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
    'End Sub

    Private Sub ucrNudControlsFromTo_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged
        If ucrNudFrom.Text <> "" AndAlso ucrNudTo.Text <> "" AndAlso (Not ucrReceiverDOY.IsEmpty) Then
            clsMinmaxFilterFunction.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
            'clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
            'clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
        Else
            'clsDayFromAndTo.RemoveParameterByName("function_exp")
            'clsDayFromAndTo.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlMinMaxPeaks.ControlContentsChanged
        If rdoMinMax.Checked Then
            ucrInputSave.SetName("min_value")
        ElseIf rdoPeaks.Checked Then
            ucrInputSave.SetName("peak_value")
        End If
    End Sub
End Class