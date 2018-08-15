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

    Private clsBiasCalculation, clsListFunction, clsAbsDevCalculation, clsAbsDevFunction, clsCombinedCalculation, clsRunInstatCalculation As New RFunction
    Private clsGroupByStationDOY As New RFunction
    Private clsDiffOperator, clsMinusOperator As New ROperator

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
        rdoAnomalies.Enabled = False
        ucrPnlCompare.bAllowNonConditionValues = True

        ucrPnlCompare.AddRadioButton(rdoDifferences)
        ucrPnlCompare.AddRadioButton(rdoAnomalies)
        ucrPnlCompare.AddParameterPresentCondition(rdoDifferences, "sub1")

        ucrSelectorCompare.SetParameter(New RParameter("", 0))
        ucrSelectorCompare.SetParameterIsrfunction()

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetParameter(New RParameter(""))
        ucrReceiverStation.Selector = ucrSelectorCompare
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bWithQuotes = False

        ucrReceiverWithinYear.SetParameter(New RParameter("", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.Selector = ucrSelectorCompare

        ucrReceiverSateliteElement.SetParameter(New RParameter("satelite_element", 0, bNewIncludeArgumentName:=False))
        ucrReceiverSateliteElement.SetParameterIsString()
        ucrReceiverSateliteElement.bWithQuotes = False
        ucrReceiverSateliteElement.Selector = ucrSelectorCompare

        ucrReceiverStationElement.SetParameter(New RParameter("station_element", 1, bNewIncludeArgumentName:=False))
        ucrReceiverStationElement.SetParameterIsString()
        ucrReceiverStationElement.bWithQuotes = False
        ucrReceiverStationElement.Selector = ucrSelectorCompare

        ucrChkMovingAverage.SetText("Moving Average")

        ucrChkBias.AddParameterPresentCondition(True, "sub1", True)
        ucrChkBias.AddParameterPresentCondition(False, "sub1", False)
        ucrChkBias.SetText("Bias")

        ucrChkAbsDev.AddParameterPresentCondition(True, "sub2", True)
        ucrChkAbsDev.AddParameterPresentCondition(False, "sub2", False)
        ucrChkAbsDev.SetText("Absolute deviation")

        ucrPnlCompare.AddToLinkedControls(ucrReceiverStation, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverWithinYear, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
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

        ucrInputBias.SetParameter(New RParameter("result_name", 2))
        ucrInputBias.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputBias.SetName("bias")

        ucrInputAbsDev.SetParameter(New RParameter("result_name", 2))
        ucrInputAbsDev.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputAbsDev.SetName("absdev1")
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
        clsCombinedCalculation.AddParameter("sub_calculation", clsRFunctionParameter:=clsListFunction, iPosition:=1)

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("sub1", clsRFunctionParameter:=clsBiasCalculation, bIncludeArgumentName:=False, iPosition:=0)

        'Run Calculations
        clsRunInstatCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunInstatCalculation.AddParameter("display", "FALSE", iPosition:=1)
        clsRunInstatCalculation.AddParameter("calc", clsRFunctionParameter:=clsCombinedCalculation, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunInstatCalculation)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverSateliteElement.AddAdditionalCodeParameterPair(clsMinusOperator, New RParameter("satelite_element", 0), iAdditionalPairNo:=1)
        ucrReceiverStationElement.AddAdditionalCodeParameterPair(clsMinusOperator, New RParameter("station_element", 1), iAdditionalPairNo:=1)

        ucrReceiverSateliteElement.SetRCode(clsDiffOperator, bReset)
        ucrReceiverStationElement.SetRCode(clsDiffOperator, bReset)
        ucrChkBias.SetRCode(clsListFunction, bReset)
        ucrChkAbsDev.SetRCode(clsListFunction, bReset)
        ucrInputBias.SetRCode(clsBiasCalculation, bReset)
        ucrInputAbsDev.SetRCode(clsAbsDevCalculation, bReset)
        ucrPnlCompare.SetRCode(clsListFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean

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
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore)
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
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlValueChanged, ucrReceiverStationElement.ControlValueChanged
        clsBiasCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsAbsDevCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
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

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        clsGroupByStationDOY.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverWithinYear.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlContentsChanged, ucrReceiverStationElement.ControlContentsChanged, ucrChkBias.ControlContentsChanged, ucrChkAbsDev.ControlContentsChanged, ucrInputBias.ControlContentsChanged, ucrInputAbsDev.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
