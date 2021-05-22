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

Public Class dlgCompare
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private iReceiverSateliteY As Integer
    Private iReceiverLabelSateliteY As Integer
    Private iReceiverStationY As Integer
    Private iReceiverLabelStationY As Integer
    'Difference
    Private clsBiasCalculation, clsListFunction, clsAbsDevCalculation, clsAbsDevFunction, clsCombinedCalculation, clsRunInstatCalculation As New RFunction
    Private clsGroupByStationWithinYear As New RFunction
    Private clsDiffOperator, clsMinusOperator As New ROperator

    'Anomalies
    Private clsSateliteAnomalies, clsSateliteMeanFunction, clsStationAnomalies, clsStationMeanFunction, clsListManipulation As New RFunction
    Private clsSateliteMinusOperator, clsStationMinusOperator As New ROperator

    Private Sub dlgCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 562
        ucrPnlCompare.AddRadioButton(rdoDifferences)
        ucrPnlCompare.AddRadioButton(rdoAnomalies)
        ucrPnlCompare.AddParameterPresentCondition(rdoDifferences, "manipulations", False)
        ucrPnlCompare.AddParameterPresentCondition(rdoAnomalies, "manipulations")

        ucrSelectorCompare.SetParameter(New RParameter("", 0))
        ucrSelectorCompare.SetParameterIsrfunction()

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorCompare
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.Selector = ucrSelectorCompare

        ucrReceiverStationElement.SetParameter(New RParameter("station_element", 1, bNewIncludeArgumentName:=False))
        ucrReceiverStationElement.SetParameterIsString()
        ucrReceiverStationElement.bWithQuotes = False
        ucrReceiverStationElement.Selector = ucrSelectorCompare
        ucrReceiverStationElement.SetDataType("numeric")
        ucrReceiverStationElement.strSelectorHeading = "Numerics"

        ucrReceiverSateliteElement.SetParameter(New RParameter("satelite_element", 0, bNewIncludeArgumentName:=False))
        ucrReceiverSateliteElement.SetParameterIsString()
        ucrReceiverSateliteElement.bWithQuotes = False
        ucrReceiverSateliteElement.Selector = ucrSelectorCompare
        ucrReceiverSateliteElement.SetDataType("numeric")
        ucrReceiverSateliteElement.strSelectorHeading = "Numerics"

        ucrChkMovingAverage.SetText("Moving Average")
        'TODO:This is temporarily disabled!
        ucrChkMovingAverage.Enabled = False
        ucrNudMovingAverage.Enabled = False



        'ucrSaveFirstCol.SetPrefix("bias")
        ucrSaveFirstCol.SetSaveTypeAsColumn()
        ucrSaveFirstCol.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrSaveFirstCol.SetIsComboBox()
        ucrSaveFirstCol.SetPositionParametersDirectly(False, "result_name")
        ucrSaveFirstCol.setLinkedReceiver(ucrReceiverStationElement)

        'ucrSaveSecondCol.SetPrefix("absdev")
        ucrSaveSecondCol.SetSaveTypeAsColumn()
        ucrSaveSecondCol.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrSaveSecondCol.SetIsComboBox()
        ucrSaveSecondCol.SetPositionParametersDirectly(False, "result_name")
        ucrSaveSecondCol.setLinkedReceiver(ucrReceiverStationElement)

        ucrPnlCompare.AddToLinkedControls(ucrReceiverStation, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverWithinYear, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrChkMovingAverage, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkMovingAverage.AddToLinkedControls(ucrNudMovingAverage, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)
        ucrReceiverSateliteElement.SetLinkedDisplayControl(lblSateliteElement)
        ucrReceiverStationElement.SetLinkedDisplayControl(lblStationElement)

    End Sub

    Private Sub SetDefaults()
        'clsBiasCalculation.Clear()
        clsDiffOperator.Clear()
        clsListFunction.Clear()
        'clsAbsDevCalculation.Clear()
        clsGroupByStationWithinYear.Clear()
        clsMinusOperator.Clear()
        clsAbsDevFunction.Clear()
        clsCombinedCalculation.Clear()
        clsRunInstatCalculation.Clear()

        clsSateliteAnomalies.Clear()
        clsStationAnomalies.Clear()
        clsSateliteMeanFunction.Clear()
        clsStationMeanFunction.Clear()
        clsListManipulation.Clear()
        clsStationMinusOperator.Clear()

        ucrSelectorCompare.Reset()
        ucrReceiverSateliteElement.SetMeAsReceiver()
        ucrSaveFirstCol.ucrChkSave.Checked = True
        ucrSaveSecondCol.ucrChkSave.Checked = True
        ucrSaveFirstCol.Reset()
        ucrSaveSecondCol.Reset()

        'group_by_station_day_of_year
        clsGroupByStationWithinYear.SetRCommand("instat_calculation$new")
        clsGroupByStationWithinYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationWithinYear.SetAssignTo("grouping")

        clsBiasCalculation.SetRCommand("instat_calculation$new")
        clsBiasCalculation.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsBiasCalculation.AddParameter("function_exp", clsROperatorParameter:=clsDiffOperator, iPosition:=1)
        clsBiasCalculation.AddParameter("result_name", Chr(34) & "bias" & Chr(34), iPosition:=2)
        clsBiasCalculation.AddParameter("save", 2, iPosition:=2)
        clsBiasCalculation.SetAssignTo("bias_calculation")

        clsDiffOperator.SetOperation("-")
        clsDiffOperator.bToScriptAsRString = True

        clsAbsDevCalculation.SetRCommand("instat_calculation$new")
        clsAbsDevCalculation.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsAbsDevCalculation.AddParameter("function_exp", clsRFunctionParameter:=clsAbsDevFunction, iPosition:=1)
        clsAbsDevCalculation.AddParameter("result_name", Chr(34) & "absdev" & Chr(34), iPosition:=2)
        clsAbsDevCalculation.AddParameter("save", 2, iPosition:=2)
        clsAbsDevCalculation.SetAssignTo("absdev_calculation ")

        clsMinusOperator.SetOperation("-")

        clsAbsDevFunction.SetRCommand("abs")
        clsAbsDevFunction.bToScriptAsRString = True
        clsAbsDevFunction.AddParameter("diff", clsROperatorParameter:=clsMinusOperator, bIncludeArgumentName:=False)

        clsCombinedCalculation.SetRCommand("instat_calculation$new")
        clsCombinedCalculation.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinedCalculation.AddParameter("sub_calculation", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsCombinedCalculation.SetAssignTo("combined_calculation")

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("sub1", clsRFunctionParameter:=clsBiasCalculation, bIncludeArgumentName:=False, iPosition:=0)
        clsListFunction.AddParameter("sub2", clsRFunctionParameter:=clsAbsDevCalculation, bIncludeArgumentName:=False, iPosition:=1)

        clsListManipulation.SetRCommand("list")

        'Anomalies calculations
        clsSateliteAnomalies.SetRCommand("instat_calculation$new")
        clsSateliteAnomalies.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSateliteAnomalies.AddParameter("function_exp", clsROperatorParameter:=clsSateliteMinusOperator, iPosition:=1)
        clsSateliteAnomalies.AddParameter("result_name", Chr(34) & "satellite_anom" & Chr(34), iPosition:=2)
        clsSateliteAnomalies.AddParameter("save", 2, iPosition:=2)
        clsSateliteAnomalies.SetAssignTo("satellite_anomalies")

        clsSateliteMinusOperator.SetOperation("-")
        clsSateliteMinusOperator.bToScriptAsRString = True
        clsSateliteMinusOperator.AddParameter("mean", clsRFunctionParameter:=clsSateliteMeanFunction, iPosition:=1)

        clsSateliteMeanFunction.SetRCommand("mean")
        clsSateliteMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsStationAnomalies.SetRCommand("instat_calculation$new")
        clsStationAnomalies.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStationAnomalies.AddParameter("function_exp", clsROperatorParameter:=clsStationMinusOperator, iPosition:=1)
        clsStationAnomalies.AddParameter("result_name", Chr(34) & "station_anom" & Chr(34), iPosition:=2)
        clsStationAnomalies.AddParameter("save", 2, iPosition:=2)
        clsStationAnomalies.SetAssignTo("station_anomalies")

        clsStationMinusOperator.SetOperation("-")
        clsStationMinusOperator.bToScriptAsRString = True
        clsStationMinusOperator.AddParameter("mean", clsRFunctionParameter:=clsStationMeanFunction, iPosition:=1)

        clsStationMeanFunction.SetRCommand("mean")
        clsStationMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        'Run Calculations
        clsRunInstatCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunInstatCalculation.AddParameter("display", "FALSE", iPosition:=1)
        clsRunInstatCalculation.AddParameter("calc", clsRFunctionParameter:=clsCombinedCalculation, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunInstatCalculation)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverSateliteElement.AddAdditionalCodeParameterPair(clsMinusOperator, New RParameter("satelite_element", 0), iAdditionalPairNo:=1)
        ucrReceiverSateliteElement.AddAdditionalCodeParameterPair(clsSateliteMinusOperator, New RParameter("satelite_element", 0), iAdditionalPairNo:=2)
        ucrReceiverSateliteElement.AddAdditionalCodeParameterPair(clsSateliteMeanFunction, New RParameter("station_element", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverStationElement.AddAdditionalCodeParameterPair(clsMinusOperator, New RParameter("station_element", 1), iAdditionalPairNo:=1)
        ucrReceiverStationElement.AddAdditionalCodeParameterPair(clsStationMinusOperator, New RParameter("station_element", 0), iAdditionalPairNo:=2)
        ucrReceiverStationElement.AddAdditionalCodeParameterPair(clsStationMeanFunction, New RParameter("station_element", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrReceiverSateliteElement.SetRCode(clsDiffOperator, bReset)
        ucrReceiverStationElement.SetRCode(clsDiffOperator, bReset)

        ucrPnlCompare.SetRCode(clsCombinedCalculation, bReset)

        ucrSaveFirstCol.AddAdditionalRCode(clsSateliteAnomalies, bReset)
        ucrSaveSecondCol.AddAdditionalRCode(clsStationAnomalies, bReset)
        ucrSaveFirstCol.SetRCode(clsBiasCalculation, bReset)
        ucrSaveSecondCol.SetRCode(clsAbsDevCalculation, bReset)

    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean = True

        If rdoDifferences.Checked Then
            If Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrReceiverStationElement.IsEmpty AndAlso (ucrSaveFirstCol.ucrChkSave.Checked OrElse ucrSaveSecondCol.ucrChkSave.Checked) Then
                bOkEnabled = ucrSaveFirstCol.IsComplete OrElse ucrSaveSecondCol.IsComplete
            Else
                bOkEnabled = False
            End If
        ElseIf rdoAnomalies.Checked Then
            If ucrReceiverWithinYear.IsEmpty OrElse (ucrReceiverSateliteElement.IsEmpty AndAlso ucrReceiverStationElement.IsEmpty()) Then
                bOkEnabled = False
            ElseIf (Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrSaveFirstCol.IsComplete) OrElse (Not ucrReceiverStationElement.IsEmpty AndAlso Not ucrSaveSecondCol.IsComplete) Then
                bOkEnabled = False
            End If
        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetCurrentReceiver()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If rdoDifferences.Checked Then
            If ucrSelectorCompare.CurrentReceiver IsNot Nothing Then
                ucrCurrentReceiver = ucrSelectorCompare.CurrentReceiver
            End If
            If ucrCurrentReceiver Is Nothing OrElse ucrCurrentReceiver.Equals(ucrReceiverStation) OrElse ucrCurrentReceiver.Equals(ucrReceiverWithinYear) Then
                ucrReceiverSateliteElement.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrPnlCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompare.ControlValueChanged
        SetCurrentReceiver()

        If rdoAnomalies.Checked Then
            ucrSaveFirstCol.SetCheckBoxText("Satelite Anomalies:")
            ucrSaveFirstCol.SetPrefix("satellite_anom")

            ucrSaveSecondCol.SetCheckBoxText("Station Anomalies:")
            ucrSaveSecondCol.SetPrefix("station_anom")
        Else
            ucrSaveFirstCol.SetLabelText("Bias:")
            ucrSaveFirstCol.SetPrefix("bias")

            ucrSaveSecondCol.SetLabelText("Absolute deviation:")
            ucrSaveSecondCol.SetPrefix("absdev")
        End If

        SetSaveColumnControlsParameters()

    End Sub

    Private Sub ucrReceiverSateliteElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlValueChanged, ucrReceiverStationElement.ControlValueChanged
        Dim strCurrDataName As String

        strCurrDataName = Chr(34) & ucrSelectorCompare.strCurrentDataFrame & Chr(34)

        clsBiasCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsAbsDevCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsSateliteAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & ")", iPosition:=3)
        clsStationAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverWithinYear.ControlValueChanged
        Dim strCurrDataName As String

        strCurrDataName = Chr(34) & ucrSelectorCompare.strCurrentDataFrame & Chr(34)

        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverWithinYear.IsEmpty Then
            clsGroupByStationWithinYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverWithinYear.GetVariableNames & ")", iPosition:=3)
        ElseIf Not ucrReceiverWithinYear.IsEmpty Then
            clsGroupByStationWithinYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverWithinYear.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupByStationWithinYear.RemoveParameterByName("calculated_from")
        End If
        If Not ucrReceiverStation.IsEmpty OrElse Not ucrReceiverWithinYear.IsEmpty Then
            clsListManipulation.AddParameter("group_by", clsRFunctionParameter:=clsGroupByStationWithinYear, bIncludeArgumentName:=False)
        Else
            clsListManipulation.RemoveParameterByName("group_by")
        End If
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlContentsChanged, ucrReceiverStationElement.ControlContentsChanged, ucrPnlCompare.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged, ucrSaveFirstCol.ControlContentsChanged, ucrSaveSecondCol.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveFirstCol.ControlValueChanged, ucrSaveSecondCol.ControlValueChanged
        SetSaveColumnControlsParameters()
    End Sub

    Private Sub SetSaveColumnControlsParameters()
        If rdoDifferences.Checked AndAlso ucrSaveFirstCol.ucrChkSave.Checked Then
            clsListFunction.AddParameter("sub1", clsRFunctionParameter:=clsBiasCalculation, bIncludeArgumentName:=False, iPosition:=0)
            clsBiasCalculation.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveFirstCol.GetText & Chr(34), iPosition:=2)
            clsBiasCalculation.SetAssignTo("bias_calculation")
        Else
            clsListFunction.RemoveParameterByName("sub1")
        End If

        If rdoDifferences.Checked AndAlso ucrSaveSecondCol.ucrChkSave.Checked Then
            clsListFunction.AddParameter("sub2", clsRFunctionParameter:=clsAbsDevCalculation, bIncludeArgumentName:=False, iPosition:=1)
            clsAbsDevCalculation.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveSecondCol.GetText & Chr(34), iPosition:=2)
            clsAbsDevCalculation.SetAssignTo("absdev_calculation")
        Else
            clsListFunction.RemoveParameterByName("sub2")
        End If


        If rdoAnomalies.Checked Then
            clsCombinedCalculation.AddParameter("manipulations", clsRFunctionParameter:=clsListManipulation, iPosition:=1)

            clsListFunction.AddParameter("sub3", clsRFunctionParameter:=clsSateliteAnomalies, bIncludeArgumentName:=False, iPosition:=0)
            clsSateliteAnomalies.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveFirstCol.GetText & Chr(34), iPosition:=2)
            clsSateliteAnomalies.SetAssignTo("satellite_anomalies")

            clsListFunction.AddParameter("sub4", clsRFunctionParameter:=clsStationAnomalies, bIncludeArgumentName:=False, iPosition:=1)
            clsStationAnomalies.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveSecondCol.GetText & Chr(34), iPosition:=2)
            clsStationAnomalies.SetAssignTo("station_anomalies")

        Else
            clsCombinedCalculation.RemoveParameterByName("manipulations")
            clsListFunction.RemoveParameterByName("sub3")
            clsListFunction.RemoveParameterByName("sub4")
        End If
    End Sub



End Class
