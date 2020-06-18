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
    Private dctBinaryForecastTypes As New Dictionary(Of String, String)
    Private dctContForecastTypes As New Dictionary(Of String, String)
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
    'Verification
    Private clsVerifyFunction, clsSummaryFunction, clsROCPlotFunction, clsReliabilityPlotFunction, clsDiscriminationPlotFunction, clsConditionalPlotFunction As New RFunction
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
        Dim lstControls As New List(Of Control)
        ucrBase.iHelpTopicID = 562

        ucrPnlCompare.AddRadioButton(rdoDifferences)
        ucrPnlCompare.AddRadioButton(rdoAnomalies)
        ucrPnlCompare.AddRadioButton(rdoVerification)
        ucrPnlCompare.AddParameterPresentCondition(rdoDifferences, "manipulations", False)
        ucrPnlCompare.AddParameterPresentCondition(rdoAnomalies, "manipulations")
        ucrPnlCompare.AddParameterPresentCondition(rdoVerification, "obs.type")

        ucrPnlObsType.SetParameter(New RParameter("obs.type", 5))
        ucrPnlObsType.AddRadioButton(rdoContinuous, Chr(34) & "cont" & Chr(34))
        ucrPnlObsType.AddRadioButton(rdoBinary, Chr(34) & "binary" & Chr(34))
        ucrPnlObsType.AddRadioButton(rdoCategorical, Chr(34) & "cat" & Chr(34))

        ucrInputComboForecastType.SetParameter(New RParameter("frcst.type", 4))
        dctBinaryForecastTypes.Add("Probability", Chr(34) & "prob" & Chr(34))
        dctBinaryForecastTypes.Add("Binary", Chr(34) & "binary" & Chr(34))
        ucrInputComboForecastType.SetItems(dctBinaryForecastTypes)
        ucrInputComboForecastType.SetDropDownStyleAsNonEditable()
        ucrInputComboForecastType.SetRDefault(Chr(34) & "prob" & Chr(34))

        dctContForecastTypes.Add("Continuous", Chr(34) & "cont" & Chr(34))
        dctContForecastTypes.Add("Normal", Chr(34) & "norm.dist" & Chr(34))

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

        ucrChkBias.SetParameter(New RParameter("sub1", clsBiasCalculation, 0, bNewIncludeArgumentName:=False), False)
        ucrChkBias.SetText("Bias")

        ucrChkAbsDev.SetParameter(New RParameter("sub2", clsAbsDevCalculation, 1, bNewIncludeArgumentName:=False), False)
        ucrChkAbsDev.SetText("Absolute deviation")

        ucrPnlCompare.AddToLinkedControls(ucrReceiverStation, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverWithinYear, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrInputSateliteAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompare.AddToLinkedControls(ucrInputStationAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompare.AddToLinkedControls(ucrPnlObsType, {rdoVerification}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlCompare.AddToLinkedControls(ucrSaveModel, {rdoVerification}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlObsType.AddToLinkedControls(ucrChkROCPlot, {rdoBinary}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlObsType.AddToLinkedControls(ucrChkConditionalQuantile, {rdoBinary, rdoContinuous}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlObsType.AddToLinkedControls(ucrChkReliabilityPlot, {rdoBinary}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlObsType.AddToLinkedControls(ucrChkDiscriminationPlot, {rdoBinary}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlObsType.AddToLinkedControls(ucrInputComboForecastType, {rdoBinary}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Probability")
        ucrInputComboForecastType.AddToLinkedControls(ucrChkReliabilityPlot, {"Probability"}, bNewLinkedHideIfParameterMissing:=True)
        lstControls.AddRange({grpObsType, grpGraphics})
        ucrPnlObsType.SetLinkedDisplayControl(lstControls)
        ucrInputComboForecastType.SetLinkedDisplayControl(lblForecastType)

        ucrChkBias.AddToLinkedControls(ucrInputBias, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkBias.AddToLinkedControls(ucrInputBias, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
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
        ucrInputBias.SetDefaultTypeAsColumn()
        ucrInputBias.SetPrefix("bias")

        ucrInputAbsDev.SetParameter(New RParameter("result_name", 2))
        ucrInputAbsDev.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputAbsDev.SetDefaultTypeAsColumn()
        ucrInputAbsDev.SetPrefix("absdev")

        ucrInputSateliteAnomalies.SetParameter(New RParameter("result_name", 2))
        ucrInputSateliteAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputSateliteAnomalies.SetDefaultTypeAsColumn()
        ucrInputSateliteAnomalies.SetPrefix("satellite_anom")

        ucrInputStationAnomalies.SetParameter(New RParameter("result_name", 2))
        ucrInputStationAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
        ucrInputStationAnomalies.SetDefaultTypeAsColumn()
        ucrInputStationAnomalies.SetPrefix("station_anom")

        ucrChkROCPlot.SetText("ROC")
        ucrChkROCPlot.AddRSyntaxContainsFunctionNamesCondition(True, {"roc.plot"})
        ucrChkROCPlot.AddRSyntaxContainsFunctionNamesCondition(False, {"roc.plot"}, False)

        ucrChkReliabilityPlot.SetText("Reliability")
        ucrChkReliabilityPlot.AddRSyntaxContainsFunctionNamesCondition(True, {"reliability.plot"})
        ucrChkReliabilityPlot.AddRSyntaxContainsFunctionNamesCondition(False, {"reliability.plot"}, False)

        ucrChkConditionalQuantile.SetText("Conditional Quantile")
        ucrChkConditionalQuantile.AddRSyntaxContainsFunctionNamesCondition(True, {"plot"})
        ucrChkConditionalQuantile.AddRSyntaxContainsFunctionNamesCondition(False, {"plot"}, False)

        ucrChkDiscriminationPlot.SetText("Discrimination")
        ucrChkDiscriminationPlot.AddRSyntaxContainsFunctionNamesCondition(True, {"discrimination.plot"})
        ucrChkDiscriminationPlot.AddRSyntaxContainsFunctionNamesCondition(False, {"discrimination.plot"}, False)

        ucrChkLinePlot.SetText("Lineplot")
        ucrChkLinePlot.Enabled = False

        ucrChkBoxplot.SetText("Boxplot")
        ucrChkBoxplot.Enabled = False

        ucrSaveModel.SetPrefix("model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsVerifyFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsROCPlotFunction = New RFunction
        clsReliabilityPlotFunction = New RFunction
        clsConditionalPlotFunction = New RFunction
        clsDiscriminationPlotFunction = New RFunction
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

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        rdoDifferences.Checked = True 'temp fix
        ucrSelectorCompare.Reset()
        ucrReceiverSateliteElement.SetMeAsReceiver()

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

        clsVerifyFunction.SetPackageName("verification")
        clsVerifyFunction.SetRCommand("verify")
        clsVerifyFunction.AddParameter("frcst.type", Chr(34) & "prob" & Chr(34), iPosition:=4)
        clsVerifyFunction.AddParameter("obs.type", Chr(34) & "cont" & Chr(34), iPosition:=5)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsVerifyFunction, iPosition:=0)

        clsROCPlotFunction.SetPackageName("verification")
        clsROCPlotFunction.SetRCommand("roc.plot")
        clsROCPlotFunction.AddParameter("x", clsRFunctionParameter:=clsVerifyFunction, iPosition:=0)

        clsReliabilityPlotFunction.SetPackageName("verification")
        clsReliabilityPlotFunction.SetRCommand("reliability.plot")
        clsReliabilityPlotFunction.AddParameter("x", clsRFunctionParameter:=clsVerifyFunction, iPosition:=0)

        clsDiscriminationPlotFunction.SetPackageName("verification")
        clsDiscriminationPlotFunction.SetRCommand("discrimination.plot")

        clsConditionalPlotFunction.SetRCommand("plot")
        clsConditionalPlotFunction.AddParameter("x", clsRFunctionParameter:=clsVerifyFunction, iPosition:=0)

        ucrBase.clsRsyntax.ClearCodes()
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
        ucrInputSateliteAnomalies.SetRCode(clsSateliteAnomalies, bReset)
        ucrInputStationAnomalies.SetRCode(clsStationAnomalies, bReset)
        ucrPnlObsType.SetRCode(clsVerifyFunction, bReset)
        ucrSaveModel.SetRCode(clsVerifyFunction, bReset)
        ucrInputComboForecastType.SetRCode(clsVerifyFunction, bReset)

        ucrChkROCPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkReliabilityPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkConditionalQuantile.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkDiscriminationPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean = True

        If rdoDifferences.Checked Then
            If Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrReceiverStationElement.IsEmpty AndAlso (ucrChkBias.Checked OrElse ucrChkAbsDev.Checked) Then
                If (ucrChkBias.Checked AndAlso ucrInputBias.IsEmpty) OrElse (ucrChkAbsDev.Checked AndAlso ucrInputAbsDev.IsEmpty) Then
                    bOkEnabled = False
                End If
            Else
                bOkEnabled = False
            End If
        ElseIf rdoAnomalies.Checked Then
            If ucrReceiverWithinYear.IsEmpty OrElse (ucrReceiverSateliteElement.IsEmpty AndAlso ucrReceiverStationElement.IsEmpty()) Then
                bOkEnabled = False
            ElseIf (Not ucrReceiverSateliteElement.IsEmpty AndAlso ucrInputSateliteAnomalies.IsEmpty) OrElse (Not ucrReceiverStationElement.IsEmpty AndAlso ucrInputStationAnomalies.IsEmpty) Then
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

    Private Sub AddObservationPredictionValues()
        clsVerifyFunction.AddParameter("obs", clsRFunctionParameter:=ucrReceiverStationElement.GetVariables(), iPosition:=0)
        clsVerifyFunction.AddParameter("pred", clsRFunctionParameter:=ucrReceiverSateliteElement.GetVariables(), iPosition:=1)
    End Sub

    Private Sub SetCurrentReceiver()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If rdoDifferences.Checked OrElse rdoVerification.Checked Then
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
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunInstatCalculation)
        If rdoAnomalies.Checked Then
            clsCombinedCalculation.AddParameter("manipulations", clsRFunctionParameter:=clsListManipulation, iPosition:=1)
            clsListFunction.AddParameter("sub3", clsRFunctionParameter:=clsSateliteAnomalies, bIncludeArgumentName:=False, iPosition:=2)
            clsListFunction.AddParameter("sub4", clsRFunctionParameter:=clsStationAnomalies, bIncludeArgumentName:=False, iPosition:=3)
        ElseIf rdoVerification.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            ucrBase.clsRsyntax.iCallType = 2
        Else
            clsCombinedCalculation.RemoveParameterByName("manipulations")
            clsListFunction.RemoveParameterByName("sub3")
            clsListFunction.RemoveParameterByName("sub4")
        End If
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlValueChanged, ucrReceiverStationElement.ControlValueChanged
        Dim strCurrDataName As String

        strCurrDataName = Chr(34) & ucrSelectorCompare.strCurrentDataFrame & Chr(34)

        clsBiasCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsAbsDevCalculation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        clsSateliteAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverSateliteElement.GetVariableNames & ")", iPosition:=3)
        clsStationAnomalies.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStationElement.GetVariableNames & ")", iPosition:=3)
        AddObservationPredictionValues()
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

    Private Sub ucrPnlObsType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlObsType.ControlValueChanged
        If rdoContinuous.Checked Then
            clsVerifyFunction.AddParameter("frcst.type", Chr(34) & "cont" & Chr(34), iPosition:=4)
        ElseIf rdoCategorical.Checked Then
            clsVerifyFunction.AddParameter("frcst.type", Chr(34) & "cat" & Chr(34), iPosition:=4)
        End If
    End Sub

    Private Sub ucrChkROCPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkROCPlot.ControlValueChanged
        If ucrChkROCPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsROCPlotFunction, iPosition:=0)
            clsROCPlotFunction.iCallType = 3
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsROCPlotFunction)
        End If
    End Sub

    Private Sub ucrChkReliabilityPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkReliabilityPlot.ControlValueChanged
        If ucrChkReliabilityPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsReliabilityPlotFunction, iPosition:=1)
            clsReliabilityPlotFunction.iCallType = 3
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsReliabilityPlotFunction)
        End If
    End Sub

    Private Sub ucrChkConditionalQuantile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConditionalQuantile.ControlValueChanged
        If ucrChkConditionalQuantile.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsConditionalPlotFunction, iPosition:=3)
            clsConditionalPlotFunction.iCallType = 3
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsConditionalPlotFunction)
        End If
    End Sub

    Private Sub ucrChkDiscriminationPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDiscriminationPlot.ControlValueChanged
        If ucrChkDiscriminationPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDiscriminationPlotFunction, iPosition:=2)
            clsDiscriminationPlotFunction.iCallType = 3
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDiscriminationPlotFunction)
        End If
    End Sub

    Private Sub ucrReceiverSateliteElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSateliteElement.ControlContentsChanged, ucrReceiverStationElement.ControlContentsChanged, ucrChkBias.ControlContentsChanged, ucrChkAbsDev.ControlContentsChanged, ucrInputBias.ControlContentsChanged, ucrInputAbsDev.ControlContentsChanged, ucrPnlCompare.ControlContentsChanged, ucrInputSateliteAnomalies.ControlContentsChanged, ucrInputStationAnomalies.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
