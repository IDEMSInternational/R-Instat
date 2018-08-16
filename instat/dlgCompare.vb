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
    Private strCurrDataName As String

    Private iReceiverSateliteY As Integer
    Private iReceiverLabelSateliteY As Integer
    Private iReceiverStationY As Integer
    Private iReceiverLabelStationY As Integer
    'Difference
    Private clsBiasCalculation, clsListFunction, clsAbsDevCalculation, clsAbsDevFunction, clsCombinedCalculation, clsRunInstatCalculation As New RFunction
    Private clsGroupByStationDOY As New RFunction
    Private clsDiffOperator, clsMinusOperator As New ROperator

    'Anomalies
    Private clsSateliteAnomalies, clsSateliteMeanFunction, clsStationAnomalies, clsStationMeanFunction, clsListManipulation As New RFunction
    Private clsSateliteMinusOperator, clsStationMinusOperator As New ROperator

    Private Sub dlgCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        'TODO:This is really temporary as setting conditions properly will be done once anomalies option is working
        'rdoAnomalies.Enabled = False
        ucrPnlCompare.bAllowNonConditionValues = True

        ucrPnlCompare.AddRadioButton(rdoDifferences)
        ucrPnlCompare.AddRadioButton(rdoAnomalies)
        ucrPnlCompare.AddParameterPresentCondition(rdoDifferences, "sub1")

        ucrSelectorCompare.SetParameter(New RParameter("", 0))
        ucrSelectorCompare.SetParameterIsrfunction()

        ucrReceiverSateliteElement.SetParameter(New RParameter("satelite_element", 0, bNewIncludeArgumentName:=False))
        ucrReceiverSateliteElement.SetParameterIsString()
        ucrReceiverSateliteElement.bWithQuotes = False
        ucrReceiverSateliteElement.Selector = ucrSelectorCompare
        ucrReceiverSateliteElement.SetDataType("numeric")

        ucrReceiverStationElement.SetParameter(New RParameter("station_element", 1, bNewIncludeArgumentName:=False))
        ucrReceiverStationElement.SetParameterIsString()
        ucrReceiverStationElement.bWithQuotes = False
        ucrReceiverStationElement.Selector = ucrSelectorCompare
        ucrReceiverStationElement.SetDataType("numeric")

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorCompare
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bWithQuotes = False

        ucrReceiverWithinYear.SetParameter(New RParameter("", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.Selector = ucrSelectorCompare

        ucrChkMovingAverage.SetText("Moving Average")

        ucrChkBias.AddParameterPresentCondition(True, "sub1", True)
        ucrChkBias.AddParameterPresentCondition(False, "sub1", False)
        ucrChkBias.SetText("Bias")

        ucrChkAbsDev.AddParameterPresentCondition(True, "sub2", True)
        ucrChkAbsDev.AddParameterPresentCondition(False, "sub2", False)
        ucrChkAbsDev.SetText("Absolute deviation")

        ucrPnlCompare.AddToLinkedControls(ucrReceiverStation, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverWithinYear, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrInputSateliteAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompare.AddToLinkedControls(ucrInputStationAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkBias.AddToLinkedControls(ucrInputBias, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBias.AddToLinkedControls(ucrInputBias, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBias.AddToLinkedControls(ucrInputBias, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAbsDev.AddToLinkedControls(ucrInputAbsDev, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompare.AddToLinkedControls(ucrChkBias, {rdoDifferences}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrChkAbsDev, {rdoDifferences}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrChkMovingAverage, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkMovingAverage.AddToLinkedControls(ucrNudMovingAverage, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)
        ucrReceiverSateliteElement.SetLinkedDisplayControl(lblSateliteElement)
        ucrReceiverStationElement.SetLinkedDisplayControl(lblStationElement)
        ucrInputSateliteAnomalies.SetLinkedDisplayControl(lblSateliteAnomalies)
        ucrInputStationAnomalies.SetLinkedDisplayControl(lblStationAnomalies)

        ucrInputBias.SetParameter(New RParameter("result_name", 2))
        ucrInputBias.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputBias.SetName("bias")

        ucrInputAbsDev.SetParameter(New RParameter("result_name", 2))
        ucrInputAbsDev.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputAbsDev.SetName("absdev1")


        ucrInputSateliteAnomalies.SetParameter(New RParameter("result_name", 2))
        ucrInputSateliteAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputSateliteAnomalies.SetName("satellite_anom")

        ucrInputStationAnomalies.SetParameter(New RParameter("result_name", 2))
        ucrInputStationAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputStationAnomalies.SetName("anom")
    End Sub

    Private Sub SetDefaults()
        clsBiasCalculation.Clear()
        clsDiffOperator.Clear()
        clsListFunction.Clear()
        clsAbsDevCalculation.Clear()
        clsGroupByStationDOY.Clear()
        clsMinusOperator.Clear()
        clsAbsDevFunction.Clear()
        clsCombinedCalculation.Clear()
        clsRunInstatCalculation.Clear()

        ucrSelectorCompare.Reset()
        ucrReceiverSateliteElement.SetMeAsReceiver()

        'group_by_station_day_of_year
        clsGroupByStationDOY.SetRCommand("instat_calculation$new")
        clsGroupByStationDOY.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationDOY.SetAssignTo("grouping")

        clsBiasCalculation.SetRCommand("instat_calculation$new")
        clsBiasCalculation.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsBiasCalculation.AddParameter("function_exp", clsROperatorParameter:=clsDiffOperator, iPosition:=1)
        clsBiasCalculation.AddParameter("result_name", Chr(34) & "bias1" & Chr(34), iPosition:=2)
        clsBiasCalculation.AddParameter("save", 2, iPosition:=2)
        clsBiasCalculation.SetAssignTo("bias_calculation")

        clsDiffOperator.SetOperation("-")
        clsDiffOperator.bToScriptAsRString = True

        clsAbsDevCalculation.SetRCommand("instat_calculation$new")
        clsAbsDevCalculation.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsAbsDevCalculation.AddParameter("function_exp", clsRFunctionParameter:=clsAbsDevFunction, iPosition:=1)
        clsAbsDevCalculation.AddParameter("result_name", Chr(34) & "absdev1" & Chr(34), iPosition:=2)
        clsAbsDevCalculation.AddParameter("save", 2, iPosition:=2)
        clsAbsDevCalculation.SetAssignTo("absdev_calculation ")

        clsMinusOperator.SetOperation("-")

        clsAbsDevFunction.SetRCommand("abs")
        clsAbsDevFunction.bToScriptAsRString = True
        clsAbsDevFunction.AddParameter("diff", clsROperatorParameter:=clsMinusOperator, bIncludeArgumentName:=False)

        clsCombinedCalculation.SetRCommand("instat_calculation$new")
        clsCombinedCalculation.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinedCalculation.AddParameter("sub_calculation", clsRFunctionParameter:=clsListFunction, iPosition:=2)

        clsListFunction.SetRCommand("list")

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
        clsStationAnomalies.AddParameter("result_name", Chr(34) & "anom" & Chr(34), iPosition:=2)
        clsStationAnomalies.AddParameter("save", 2, iPosition:=2)
        clsStationAnomalies.SetAssignTo("station_anomalies")

        clsStationMinusOperator.SetOperation("-")
        clsStationMinusOperator.bToScriptAsRString = True
        clsStationMinusOperator.AddParameter("mean", clsRFunctionParameter:=clsStationMeanFunction, iPosition:=1)

        clsStationMeanFunction.SetRCommand("mean")
        clsStationMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsListManipulation.SetRCommand("list")
        clsListManipulation.AddParameter("group_by", clsRFunctionParameter:=clsGroupByStationDOY, bIncludeArgumentName:=False)

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
        ucrChkBias.SetRCode(clsListFunction, bReset)
        ucrChkAbsDev.SetRCode(clsListFunction, bReset)
        ucrInputBias.SetRCode(clsBiasCalculation, bReset)
        ucrInputAbsDev.SetRCode(clsAbsDevCalculation, bReset)
        ucrPnlCompare.SetRCode(clsListFunction, bReset)
        ucrInputSateliteAnomalies.SetRCode(clsSateliteAnomalies, bReset)
        ucrInputStationAnomalies.SetRCode(clsStationAnomalies, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean
        If rdoDifferences.Checked Then
            If Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrReceiverStationElement.IsEmpty AndAlso (ucrChkBias.Checked OrElse ucrChkAbsDev.Checked) Then
                If ucrChkBias.Checked AndAlso ucrInputBias.IsEmpty Then
                    bOkEnabled = False
                ElseIf ucrChkAbsDev.Checked AndAlso ucrInputAbsDev.IsEmpty Then
                    bOkEnabled = False
                Else
                    bOkEnabled = True
                End If
            Else
                bOkEnabled = False
            End If
        Else
            bOkEnabled = True
        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ElementsLabelReceiverLocation()
        If rdoDifferences.Checked Then
            lblSateliteElement.Location = New Point(lblSateliteElement.Location.X, iReceiverLabelSateliteY / 2.0)
            lblStationElement.Location = New Point(lblStationElement.Location.X, iReceiverLabelStationY / 1.7)
            ucrReceiverSateliteElement.Location = New Point(ucrReceiverSateliteElement.Location.X, iReceiverSateliteY / 1.85)
            ucrReceiverStationElement.Location = New Point(ucrReceiverStationElement.Location.X, iReceiverStationY / 1.6)
        Else
            lblSateliteElement.Location = New Point(lblSateliteElement.Location.X, iReceiverLabelSateliteY)
            ucrReceiverSateliteElement.Location = New Point(ucrReceiverSateliteElement.Location.X, iReceiverSateliteY)
            lblStationElement.Location = New Point(lblStationElement.Location.X, iReceiverLabelStationY)
            ucrReceiverStationElement.Location = New Point(ucrReceiverStationElement.Location.X, iReceiverStationY)
        End If
    End Sub

    Private Sub ucrPnlCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompare.ControlValueChanged
        'ElementsLabelReceiverLocation()
        If rdoAnomalies.Checked Then
            clsCombinedCalculation.AddParameter("manipulations", clsRFunctionParameter:=clsListManipulation, iPosition:=1)
            clsListFunction.AddParameter("sub3", clsRFunctionParameter:=clsSateliteAnomalies, bIncludeArgumentName:=False, iPosition:=2)
            clsListFunction.AddParameter("sub4", clsRFunctionParameter:=clsStationAnomalies, bIncludeArgumentName:=False, iPosition:=3)
        Else
            clsCombinedCalculation.RemoveParameterByName("manipulations")
            clsListFunction.RemoveParameterByName("sub3")
            clsListFunction.RemoveParameterByName("sub4")
        End If
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlValueChanged, ucrReceiverStationElement.ControlValueChanged
        clsBiasCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsAbsDevCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsSateliteAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & ")", iPosition:=3)
        clsStationAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrSelectorCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCompare.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorCompare.strCurrentDataFrame & Chr(34)
    End Sub

    Private Sub ucrChkBias_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBias.ControlValueChanged
        If ucrChkBias.Checked Then
            clsListFunction.AddParameter("sub1", clsRFunctionParameter:=clsBiasCalculation, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsListFunction.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrChkAbsDev_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAbsDev.ControlValueChanged
        If ucrChkAbsDev.Checked Then
            clsListFunction.AddParameter("sub2", clsRFunctionParameter:=clsAbsDevCalculation, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsListFunction.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverWithinYear.ControlValueChanged
        clsGroupByStationDOY.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverWithinYear.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkBias.ControlContentsChanged, ucrChkAbsDev.ControlContentsChanged, ucrInputBias.ControlContentsChanged, ucrInputAbsDev.ControlContentsChanged, ucrPnlCompare.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
