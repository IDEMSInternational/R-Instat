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

Public Class dlgHomogenization
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetRCode As Boolean = True
    Private clsCptMeanFunction, clsCptVarianceFunction, clsCptMeanVarianceFunction, clsExcludeNAFunction, clsPlotFunction, clsSummaryFunction, clsSnhtFunction,
        clsPettittFunction, clsBuishandFunction, clsTapplyFunction, clsDummyFunction, clsCsv2climatolFunction, clsHomogenQCFunctin, clsDdm2Function, clsHomogenFunction,
        clsGetColumnsFunction, clsGetStnColumnsFunction, clsCompleteCasesFunction, clsPmatchFunction, clsPmatch2Function, clsColumnsFunction, clsColumns2Function As New RFunction
    Private clsBracketsOperator, clsLeftBracketOperator, clsVars2ColumnsFunction, clsVars1ColumnsFunction, clsRightBracketOperator As New ROperator

    ' Counter variable to keep track of the enabled radio button
    Private iEnabledRadioButtonIndex As Integer = 0

    Private lstOfRadioButtons As List(Of RadioButton)

    Private Sub dlgHomogenization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        DialogSize()
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPenaltyOptions As New Dictionary(Of String, String)
        Dim dctMethodOptions As New Dictionary(Of String, String)
        Dim dctMeanDistribution As New Dictionary(Of String, String)
        Dim dctVarDistribution As New Dictionary(Of String, String)
        Dim dctMeanVarDistribution As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 621
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorStationFile.SetParameter(New RParameter("stnfile", 1))
        ucrSelectorStationFile.SetParameterIsrfunction()

        ucrSelectorDataFiles.SetParameter(New RParameter("csvfile", 0))
        ucrSelectorDataFiles.SetParameterIsrfunction()

        ucrReceiverDataFiles.SetParameter(New RParameter("datacol", 2))
        ucrReceiverDataFiles.Selector = ucrSelectorDataFiles
        ucrReceiverDataFiles.SetParameterIsString()

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 3, bNewIncludeArgumentName:=False))
        ucrReceiverLatitude.Selector = ucrSelectorStationFile
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrReceiverLatitude.SetMeAsReceiver()

        ucrReceiverLongtitude.Selector = ucrSelectorStationFile
        ucrReceiverLongtitude.SetParameterIsString()
        ucrReceiverLongtitude.SetLinkedDisplayControl(lblLongtude)

        ucrReceiverElavation.Selector = ucrSelectorStationFile
        ucrReceiverElavation.SetParameterIsString()
        ucrReceiverElavation.SetLinkedDisplayControl(lblElavation)

        ucrReceiverStationName.Selector = ucrSelectorStationFile
        ucrReceiverStationName.SetParameterIsString()
        ucrReceiverStationName.SetLinkedDisplayControl(lblStationName)

        ucrReceiverStationId.Selector = ucrSelectorStationFile
        ucrReceiverStationId.SetParameterIsString()
        ucrReceiverStationId.SetLinkedDisplayControl(lblStationID)

        ucrInputClimateVariables.SetParameter(New RParameter("varcli", 8))
        ucrInputClimateVariables.SetLinkedDisplayControl(lblClimaticVariable)

        ucrInputInitialYear.SetParameter(New RParameter("anyi", 1))
        ucrInputInitialYear.SetValidationTypeAsNumeric()
        ucrInputInitialYear.SetLinkedDisplayControl(lblInitialYear)

        ucrInputFinalYear.SetParameter(New RParameter("anyf", 2))
        ucrInputFinalYear.SetValidationTypeAsNumeric()
        ucrInputFinalYear.SetLinkedDisplayControl(lblFinalYear)

        ucrReceiverStation.SetParameter(New RParameter("station", 0))
        ucrReceiverStation.Selector = ucrSelectorHomogenization
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("object", 0))
        ucrReceiverElement.Selector = ucrSelectorHomogenization
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.SetDataType("numeric", bStrict:=True)
        ucrReceiverElement.strSelectorHeading = "Numerics"

        ucrPnlMethods.AddRadioButton(rdoCptMean)
        ucrPnlMethods.AddRadioButton(rdoCptVariance)
        ucrPnlMethods.AddRadioButton(rdoCptMeanVariance)
        ucrPnlMethods.AddRadioButton(rdoSnht)
        ucrPnlMethods.AddRadioButton(rdoPettitt)
        ucrPnlMethods.AddRadioButton(rdoBuishand)
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMean, "cpt.mean")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptVariance, "cpt.var")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMeanVariance, "cpt.meanvar")
        ucrPnlMethods.AddFunctionNamesCondition(rdoSnht, "snh.test")
        ucrPnlMethods.AddFunctionNamesCondition(rdoPettitt, "pettitt.test")
        ucrPnlMethods.AddFunctionNamesCondition(rdoBuishand, "br.test")
        ttOptions.SetToolTip(rdoSnht, "Performes the Standard Normal Homogeinity Test (SNHT) for change-point detection of a normal variate.")
        ttOptions.SetToolTip(rdoPettitt, "Performes a non-parametric test after Pettitt in order to test for a shift in the central tendency of a time series. The H0-hypothesis, no change, is tested against the HA-Hypothesis, change")
        ttOptions.SetToolTip(rdoBuishand, "Performes the Buishand range test for change-point detection of a normal variate.")

        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddRadioButton(rdoPrepare)
        ucrPnlOptions.AddRadioButton(rdoQualityControl)
        ucrPnlOptions.AddRadioButton(rdoMonthlyTotals)
        ucrPnlOptions.AddRadioButton(rdoHomogenization)
        ucrPnlOptions.AddParameterValuesCondition(rdoSingle, "checked", "single")
        ucrPnlOptions.AddParameterValuesCondition(rdoPrepare, "checked", "prepare")
        ucrPnlOptions.AddParameterValuesCondition(rdoQualityControl, "checked", "quality")
        ucrPnlOptions.AddParameterValuesCondition(rdoMonthlyTotals, "checked", "month_totals")
        ucrPnlOptions.AddParameterValuesCondition(rdoHomogenization, "checked", "homogen")

        ucrChkPlot.SetText("Plot")
        ucrChkPlot.AddRSyntaxContainsFunctionNamesCondition(True, {"plot"})
        ucrChkPlot.AddRSyntaxContainsFunctionNamesCondition(False, {"plot"}, False)

        ucrChkSummary.SetText("Summary")
        ucrChkSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})
        ucrChkSummary.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

        ucrInputComboPenalty.SetParameter(New RParameter("penalty", 1))
        dctPenaltyOptions.Add("None", Chr(34) & "None" & Chr(34))
        dctPenaltyOptions.Add("SIC", Chr(34) & "SIC" & Chr(34))
        dctPenaltyOptions.Add("BIC", Chr(34) & "BIC" & Chr(34))
        dctPenaltyOptions.Add("MBIC", Chr(34) & "MBIC" & Chr(34))
        dctPenaltyOptions.Add("AIC", Chr(34) & "AIC" & Chr(34))
        dctPenaltyOptions.Add("Hannan-Quinn", Chr(34) & "Hannan-Quinn" & Chr(34))
        dctPenaltyOptions.Add("Asymptotic", Chr(34) & "Asymptotic" & Chr(34))
        dctPenaltyOptions.Add("Manual", Chr(34) & "Manual" & Chr(34))
        dctPenaltyOptions.Add("CROPS", Chr(34) & "CROPS" & Chr(34))
        ucrInputComboPenalty.SetItems(dctPenaltyOptions)
        ucrInputComboPenalty.SetDropDownStyleAsNonEditable()

        ucrInputComboMethod.SetParameter(New RParameter("method", 2))
        dctMethodOptions.Add("AMOC", Chr(34) & "AMOC" & Chr(34))
        dctMethodOptions.Add("PELT", Chr(34) & "PELT" & Chr(34))
        dctMethodOptions.Add("SegNeigh", Chr(34) & "SegNeigh" & Chr(34))
        dctMethodOptions.Add("BinSeg", Chr(34) & "BinSeg" & Chr(34))
        ucrInputComboMethod.SetItems(dctMethodOptions)
        ucrInputComboMethod.SetDropDownStyleAsNonEditable()

        ucrInputComboMeanDistribution.SetParameter(New RParameter("test.stat", 3))
        dctMeanDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctMeanDistribution.Add("CUSUM", Chr(34) & "CUSUM" & Chr(34))
        ucrInputComboMeanDistribution.SetItems(dctMeanDistribution)
        ucrInputComboMeanDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboMeanDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrInputComboVarDistribution.SetParameter(New RParameter("test.stat", 3))
        dctVarDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctVarDistribution.Add("CSS", Chr(34) & "CSS" & Chr(34))
        ucrInputComboVarDistribution.SetItems(dctVarDistribution)
        ucrInputComboVarDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboVarDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrInputComboMeanVarDistribution.SetParameter(New RParameter("test.stat", 3))
        dctMeanVarDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctMeanVarDistribution.Add("Gamma", Chr(34) & "Gamma" & Chr(34))
        dctMeanVarDistribution.Add("Exponential", Chr(34) & "Exponential" & Chr(34))
        dctMeanVarDistribution.Add("Poisson", Chr(34) & "Poisson" & Chr(34))
        ucrInputComboMeanVarDistribution.SetItems(dctMeanVarDistribution)
        ucrInputComboMeanVarDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboMeanVarDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrNudMinSegLen.SetParameter(New RParameter("minseglen", 4))
        ucrNudMinSegLen.SetRDefault(1)
        ucrNudMinSegLen.SetMinMax(0, Integer.MaxValue)
        ttOptions.SetToolTip(ucrNudMinSegLen.nudUpDown, "Positive integer giving the minimum segment length (no. of observations between changes), default is the minimum allowed by theory.")

        ucrInputQ.SetParameter(New RParameter("Q", 5))
        ucrInputQ.AddQuotesIfUnrecognised = False
        ucrInputQ.SetValidationTypeAsNumeric()
        ttOptions.SetToolTip(ucrInputQ.txtInput, "The maximum number of changepoints to search for using the BinSeg method")

        ucrInputPenValue.SetParameter(New RParameter("pen.value", 6))
        ucrInputPenValue.AddQuotesIfUnrecognised = False
        ucrInputPenValue.SetValidationTypeAsNumeric()
        ttOptions.SetToolTip(ucrInputPenValue.txtInput, "The theoretical type I error e.g.0.05 when using the Asymptotic penalty. A vector of length 2 (min,max) if using the CROPS penalty")

        ucrSaveResult.SetCheckBoxText("Save Test Object:")

        ucrPnlOptions.AddToLinkedControls({ucrSelectorHomogenization, ucrSaveResult, ucrReceiverNeighbour, ucrReceiverStation, ucrReceiverElement}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrInputClimateVariables}, {rdoPrepare, rdoQualityControl, rdoHomogenization, rdoMonthlyTotals}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrInputInitialYear, ucrInputFinalYear}, {rdoQualityControl, rdoHomogenization, rdoMonthlyTotals}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboPenalty.AddToLinkedControls(ucrInputPenValue, {"Asymptotic", "CROPS"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputComboMethod.AddToLinkedControls(ucrInputQ, {"SegNeigh", "BinSeg"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanDistribution, {rdoCptMean}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboVarDistribution, {rdoCptVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanVarDistribution, {rdoCptMeanVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMethod, {rdoCptMean, rdoCptVariance, rdoCptMeanVariance}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboMethod.SetLinkedDisplayControl(grpCptOptions)
        ucrReceiverNeighbour.SetLinkedDisplayControl(lblNeighbouring)
        ucrInputPenValue.SetLinkedDisplayControl(lblPenaltyValue)
        ucrInputQ.SetLinkedDisplayControl(lblQ)
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        lstOfRadioButtons = New List(Of RadioButton) From {rdoPrepare, rdoQualityControl, rdoMonthlyTotals, rdoHomogenization}

    End Sub

    Private Sub SetDefaults()
        clsCptMeanFunction = New RFunction
        clsCptVarianceFunction = New RFunction
        clsCptMeanVarianceFunction = New RFunction
        clsExcludeNAFunction = New RFunction
        clsPlotFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsSnhtFunction = New RFunction
        clsPettittFunction = New RFunction
        clsBuishandFunction = New RFunction
        clsCompleteCasesFunction = New RFunction
        clsCsv2climatolFunction = New RFunction
        clsDummyFunction = New RFunction
        clsGetColumnsFunction = New RFunction
        clsPmatchFunction = New RFunction
        clsColumnsFunction = New RFunction
        clsPmatch2Function = New RFunction
        clsColumns2Function = New RFunction
        clsGetStnColumnsFunction = New RFunction
        clsHomogenQCFunctin = New RFunction
        clsDdm2Function = New RFunction
        clsHomogenFunction = New RFunction

        clsBracketsOperator = New ROperator
        clsLeftBracketOperator = New ROperator
        clsRightBracketOperator = New ROperator
        clsVars1ColumnsFunction = New ROperator
        clsVars2ColumnsFunction = New ROperator

        ucrSelectorHomogenization.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrReceiverDataFiles.SetMeAsReceiver()
        ucrSelectorDataFiles.Reset()
        ucrSelectorStationFile.Reset()
        'TODO: Set conditions properly!
        rdoSnht.Checked = True

        clsDummyFunction.AddParameter("checked", "single", iPosition:=0)

        clsCptMeanFunction.SetPackageName("changepoint")
        clsCptMeanFunction.SetRCommand("cpt.mean")
        clsCptMeanFunction.AddParameter("Q", 5, iPosition:=5)
        clsCptMeanFunction.AddParameter("pen.value", 0, iPosition:=6)
        clsCptMeanFunction.AddParameter("penalty", Chr(34) & "None" & Chr(34), iPosition:=1)
        clsCptMeanFunction.AddParameter("method", Chr(34) & "BinSeg" & Chr(34), iPosition:=2)

        clsCptVarianceFunction.SetPackageName("changepoint")
        clsCptVarianceFunction.SetRCommand("cpt.var")

        clsCptMeanVarianceFunction.SetPackageName("changepoint")
        clsCptMeanVarianceFunction.SetRCommand("cpt.meanvar")

        clsExcludeNAFunction.SetRCommand("na.exclude")

        clsPlotFunction.SetRCommand("plot")
        clsPlotFunction.iCallType = 3

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        clsSnhtFunction.SetPackageName("trend")
        clsSnhtFunction.SetRCommand("snh.test")
        clsSnhtFunction.AddParameter("m", 5, iPosition:=1)

        clsPettittFunction.SetPackageName("trend")
        clsPettittFunction.SetRCommand("pettitt.test")

        clsBuishandFunction.SetPackageName("trend")
        clsBuishandFunction.SetRCommand("br.test")
        clsBuishandFunction.AddParameter("m", 5, iPosition:=1)

        clsTapplyFunction.SetRCommand("tapply")
        clsTapplyFunction.AddParameter("X", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
        clsTapplyFunction.AddParameter("INDEX", clsROperatorParameter:=clsRightBracketOperator, iPosition:=1)
        clsTapplyFunction.AddParameter("FUN", clsROperatorParameter:=clsBracketsOperator, iPosition:=2)

        clsBracketsOperator.SetOperation(") ")
        clsBracketsOperator.AddParameter("left", "function(X", iPosition:=0)
        clsBracketsOperator.bSpaceAroundOperation = False

        clsCompleteCasesFunction.SetRCommand("complete.cases")

        clsLeftBracketOperator.SetOperation("[")
        clsLeftBracketOperator.AddParameter("right", clsRFunctionParameter:=clsCompleteCasesFunction, iPosition:=1)
        clsLeftBracketOperator.bSpaceAroundOperation = False
        clsLeftBracketOperator.bBrackets = False

        clsRightBracketOperator.SetOperation("]")
        clsRightBracketOperator.AddParameter("left", clsROperatorParameter:=clsLeftBracketOperator, iPosition:=0)
        clsRightBracketOperator.AddParameter("right", "", iPosition:=1)
        clsRightBracketOperator.bSpaceAroundOperation = False
        clsRightBracketOperator.bBrackets = False

        clsCsv2climatolFunction.SetPackageName("climatol")
        clsCsv2climatolFunction.SetRCommand("csv2climatol")
        clsCsv2climatolFunction.AddParameter("datacol", clsRFunctionParameter:=clsPmatchFunction, iPosition:=1)
        clsCsv2climatolFunction.AddParameter("stncol", clsRFunctionParameter:=clsPmatch2Function, iPosition:=3)
        clsCsv2climatolFunction.AddParameter("header", "TRUE", iPosition:=4)

        clsGetColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFunction.SetAssignTo("col_data")

        clsGetStnColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetStnColumnsFunction.SetAssignTo("stn_data")

        clsVars1ColumnsFunction.SetOperation("", bBracketsTemp:=False)
        clsVars1ColumnsFunction.SetAssignTo("var_1")

        clsColumnsFunction.SetRCommand("colnames")

        clsPmatchFunction.SetRCommand("pmatch")
        clsPmatchFunction.AddParameter("elements", clsRFunctionParameter:=clsColumnsFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatchFunction.AddParameter("duplicates.ok", "TRUE", iPosition:=1)
        clsPmatchFunction.AddParameter("cols", clsROperatorParameter:=clsVars1ColumnsFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatchFunction.SetAssignTo("data_file")

        clsVars2ColumnsFunction.SetOperation("", bBracketsTemp:=False)
        clsVars2ColumnsFunction.SetAssignTo("var_2")

        clsColumns2Function.SetRCommand("colnames")

        clsPmatch2Function.SetRCommand("pmatch")
        clsPmatch2Function.AddParameter("stn_data", clsRFunctionParameter:=clsColumns2Function, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatch2Function.AddParameter("duplicates.ok", "TRUE", iPosition:=1)
        clsPmatch2Function.AddParameter("cols", clsROperatorParameter:=clsVars2ColumnsFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsPmatch2Function.SetAssignTo("stns_file")

        clsHomogenQCFunctin.SetPackageName("climatol")
        clsHomogenQCFunctin.SetRCommand("homogen")
        clsHomogenQCFunctin.AddParameter("onlyQC", "TRUE", iPosition:=3)
        clsHomogenQCFunctin.SetAssignTo("QC")

        clsDdm2Function.SetPackageName("climatol")
        clsDdm2Function.SetRCommand("dd2m")
        clsDdm2Function.AddParameter("valm", 1, iPosition:=3)

        clsHomogenFunction.SetPackageName("climatol")
        clsHomogenFunction.SetRCommand("homogen")
        clsHomogenFunction.AddParameter("std", 1, iPosition:=3)
        clsHomogenFunction.AddParameter("annual", Chr(34) & "total" & Chr(34), iPosition:=4)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
        AddPlotSummaryParameters()

        ResetRadioButtons()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsCompleteCasesFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement.SetRCode(clsExcludeNAFunction, bReset)

        ucrInputComboPenalty.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputComboPenalty.GetParameter, iAdditionalPairNo:=1)
        ucrInputComboPenalty.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputComboPenalty.GetParameter, iAdditionalPairNo:=2)
        ucrInputComboPenalty.SetRCode(clsCptMeanFunction, bReset)

        ucrInputComboMethod.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputComboMethod.GetParameter, iAdditionalPairNo:=1)
        ucrInputComboMethod.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputComboMethod.GetParameter, iAdditionalPairNo:=2)
        ucrInputComboMethod.SetRCode(clsCptMeanFunction, bReset)

        ucrInputComboMeanDistribution.SetRCode(clsCptMeanFunction, bReset)
        ucrInputComboVarDistribution.SetRCode(clsCptVarianceFunction, bReset)
        ucrInputComboMeanVarDistribution.SetRCode(clsCptMeanVarianceFunction, bReset)

        ucrNudMinSegLen.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrNudMinSegLen.GetParameter, iAdditionalPairNo:=1)
        ucrNudMinSegLen.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrNudMinSegLen.GetParameter, iAdditionalPairNo:=2)
        ucrNudMinSegLen.SetRCode(clsCptMeanFunction, bReset)

        ucrInputQ.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputQ.GetParameter, iAdditionalPairNo:=1)
        ucrInputQ.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputQ.GetParameter, iAdditionalPairNo:=2)
        ucrInputQ.SetRCode(clsCptMeanFunction, bReset)

        ucrInputPenValue.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputPenValue.GetParameter, iAdditionalPairNo:=1)
        ucrInputPenValue.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputPenValue.GetParameter, iAdditionalPairNo:=2)
        ucrInputPenValue.SetRCode(clsCptMeanFunction, bReset)

        ucrReceiverStation.SetRCode(clsLeftBracketOperator, bReset)

        If bReset Then
            ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
        End If

        ucrReceiverDataFiles.SetRCode(clsGetColumnsFunction, bReset)
        ucrSelectorDataFiles.SetRCode(clsGetColumnsFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsGetColumnsFunction, bReset)
        ucrReceiverLongtitude.SetRCode(clsGetColumnsFunction, bReset)
        ucrReceiverElavation.SetRCode(clsGetColumnsFunction, bReset)
        ucrReceiverStationId.SetRCode(clsGetColumnsFunction, bReset)
        ucrReceiverStationName.SetRCode(clsGetColumnsFunction, bReset)
        ucrInputClimateVariables.SetRCode(clsCsv2climatolFunction, bReset)
        ucrSelectorStationFile.SetRCode(clsGetStnColumnsFunction, bReset)
        ucrChkPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrInputFinalYear.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrInputInitialYear.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub ResetRadioButtons()
        With lstOfRadioButtons
            .ForEach(Sub(radioButton) radioButton.Enabled = False)
            .First().Enabled = True
        End With
    End Sub

    Private Sub TestOkEnabled()
        If rdoSingle.Checked Then
            If ucrReceiverElement.IsEmpty OrElse Not ucrSaveResult.IsComplete OrElse (ucrInputComboMethod.GetText = "BinSeg" AndAlso ucrInputQ.IsEmpty) OrElse (ucrInputComboPenalty.GetText = "Asymptotic" AndAlso ucrInputPenValue.IsEmpty) OrElse ucrNudMinSegLen.GetText = "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoPrepare.Checked Then
            ucrBase.OKEnabled((Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongtitude.IsEmpty AndAlso (Not ucrReceiverStationName.IsEmpty OrElse Not ucrReceiverStationId.IsEmpty) AndAlso Not ucrReceiverDataFiles.IsEmpty) AndAlso Not ucrInputClimateVariables.IsEmpty)
        Else
            ucrBase.OKEnabled(Not ucrInputClimateVariables.IsEmpty AndAlso Not ucrInputInitialYear.IsEmpty AndAlso Not ucrInputFinalYear.IsEmpty)
        End If
    End Sub

    Private Sub ucrPnlMethods_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethods.ControlValueChanged
        AddPlotSummaryParameters()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrPnlMethods.ControlValueChanged
        If rdoCptMean.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanFunction)
            clsCptMeanFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptMeanFunction, iPosition:=1)
        ElseIf rdoCptVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptVarianceFunction)
            clsCptVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptVarianceFunction, iPosition:=1)
        ElseIf rdoCptMeanVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanVarianceFunction)
            clsCptMeanVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptMeanVarianceFunction, iPosition:=1)
        ElseIf rdoSnht.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
            clsSnhtFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsSnhtFunction, iPosition:=1)
        ElseIf rdoPettitt.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPettittFunction)
            clsPettittFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsPettittFunction, iPosition:=1)
        ElseIf rdoBuishand.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBuishandFunction)
            clsBuishandFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsBuishandFunction, iPosition:=1)
        End If
        If Not ucrReceiverStation.IsEmpty Then
            clsSnhtFunction.RemoveParameterByName("x")
            clsPettittFunction.RemoveParameterByName("x")
            clsBuishandFunction.RemoveParameterByName("x")
            clsCptMeanFunction.RemoveParameterByName("data")
            clsCptVarianceFunction.RemoveParameterByName("data")
            clsCptMeanVarianceFunction.RemoveParameterByName("data")
            clsCptMeanFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsCptVarianceFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsCptMeanVarianceFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsSnhtFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsPettittFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsBuishandFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            ucrBase.clsRsyntax.SetBaseRFunction(clsTapplyFunction)
        Else
            clsCptMeanFunction.RemoveParameterByName("X")
            clsCptVarianceFunction.RemoveParameterByName("X")
            clsCptMeanVarianceFunction.RemoveParameterByName("X")
            clsSnhtFunction.RemoveParameterByName("X")
            clsPettittFunction.RemoveParameterByName("X")
            clsBuishandFunction.RemoveParameterByName("X")
        End If
    End Sub

    Private Sub AddPlotSummaryParameters()
        clsPlotFunction.AddParameter("x", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If ucrChkPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsPlotFunction, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsPlotFunction)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoSingle.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsHomogenQCFunctin)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDdm2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsHomogenFunction)
        ElseIf rdoPrepare.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCsv2climatolFunction)
        ElseIf rdoQualityControl.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsHomogenQCFunctin)
        ElseIf rdoMonthlyTotals.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDdm2Function)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsHomogenFunction)
        End If
        DialogSize()
        HideShowControls()
    End Sub

    Private Sub HideShowControls()
        If rdoPrepare.Checked Then
            grpDataFile.Show()
            grpStationFile.Show()
            grpMethods.Hide()
            grpCptOptions.Hide()
            grpOutputOptions.Hide()
        ElseIf rdoHomogenization.Checked Then
            grpMethods.Hide()
            grpCptOptions.Hide()
            grpOutputOptions.Hide()
            grpStationFile.Hide()
            grpDataFile.Hide()
        ElseIf rdoMonthlyTotals.Checked Then
            grpMethods.Hide()
            grpCptOptions.Hide()
            grpOutputOptions.Hide()
            grpStationFile.Hide()
            grpDataFile.Hide()
        ElseIf rdoQualityControl.Checked Then
            grpMethods.Hide()
            grpCptOptions.Hide()
            grpOutputOptions.Hide()
            grpStationFile.Hide()
            grpDataFile.Hide()
        Else
            grpStationFile.Hide()
            grpDataFile.Hide()
            grpMethods.Show()
            grpCptOptions.Show()
            grpOutputOptions.Show()
        End If
    End Sub

    Private Sub DialogSize()
        If rdoSingle.Checked Then
            Me.Size = New Size(438, 550)
            Me.ucrBase.Location = New Point(12, 460)
        ElseIf rdoPrepare.Checked Then
            Me.Size = New Size(438, 609)
            Me.ucrBase.Location = New Point(12, 515)
            Me.ucrInputClimateVariables.Location = New Point(284, 464)
            Me.lblClimaticVariable.Location = New Point(195, 468)
        Else
            Me.Size = New Size(438, 160)
            Me.ucrBase.Location = New Point(12, 130)
            Me.ucrInputClimateVariables.Location = New Point(272, 61)
            Me.ucrInputInitialYear.Location = New Point(77, 59)
            Me.ucrInputFinalYear.Location = New Point(77, 90)
            Me.lblClimaticVariable.Location = New Point(182, 65)
            Me.lblFinalYear.Location = New Point(15, 94)
            Me.lblInitialYear.Location = New Point(15, 63)
        End If
    End Sub

    Private Sub ucrReceiverDataFiles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDataFiles.ControlValueChanged
        If Not ucrReceiverDataFiles.IsEmpty Then
            clsVars1ColumnsFunction.AddParameter("cols", ucrReceiverDataFiles.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsVars1ColumnsFunction.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucrSelectorDataFiles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDataFiles.ControlValueChanged
        If Not ucrSelectorDataFiles.IsEmpty Then
            clsColumnsFunction.AddParameter("data", clsRCodeStructureParameter:=ucrSelectorDataFiles.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            clsCsv2climatolFunction.AddParameter("data", Chr(34) & ucrSelectorDataFiles.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & ".csv" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsColumnsFunction.RemoveParameterByName("data")
            clsCsv2climatolFunction.RemoveParameterByName("data")
        End If
    End Sub

    Private Sub ucrSelectorStationFile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorStationFile.ControlValueChanged
        If Not ucrSelectorStationFile.IsEmpty Then
            clsColumns2Function.AddParameter("stndata", clsRCodeStructureParameter:=ucrSelectorStationFile.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            clsCsv2climatolFunction.AddParameter("stnfile", Chr(34) & ucrSelectorStationFile.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & ".csv" & Chr(34), iPosition:=2)
        Else
            clsColumns2Function.RemoveParameterByName("stndata")
            clsCsv2climatolFunction.RemoveParameterByName("stnfile")
        End If
    End Sub

    Private Sub ucrInputClimateVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputClimateVariables.ControlValueChanged
        If Not ucrInputClimateVariables.IsEmpty Then
            clsCsv2climatolFunction.AddParameter("varcli", Chr(34) & ucrInputClimateVariables.GetText & Chr(34), iPosition:=5)
            clsHomogenQCFunctin.AddParameter("par", Chr(34) & ucrInputClimateVariables.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
            clsDdm2Function.AddParameter("var", Chr(34) & ucrInputClimateVariables.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
            clsHomogenFunction.AddParameter("name", Chr(34) & ucrInputClimateVariables.GetText & "-m" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCsv2climatolFunction.RemoveParameterByName("varcli")
            clsHomogenQCFunctin.RemoveParameterByName("par")
            clsDdm2Function.RemoveParameterByName("var")
            clsHomogenFunction.RemoveParameterByName("name")
        End If
    End Sub

    Private Sub ucrInputFinalYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFinalYear.ControlValueChanged
        If Not ucrInputFinalYear.IsEmpty Then
            clsHomogenQCFunctin.AddParameter("anyf", ucrInputFinalYear.GetText, iPosition:=2, bIncludeArgumentName:=False)
            clsDdm2Function.AddParameter("initial", ucrInputFinalYear.GetText, bIncludeArgumentName:=False, iPosition:=2)
            clsHomogenFunction.AddParameter("in_yr", ucrInputFinalYear.GetText, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsHomogenQCFunctin.RemoveParameterByName("anyf")
            clsDdm2Function.RemoveParameterByName("par")
            clsHomogenFunction.RemoveParameterByName("in_yr")
        End If
    End Sub

    Private Sub ucrInputInitialYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputInitialYear.ControlValueChanged
        If Not ucrInputInitialYear.IsEmpty Then
            clsHomogenQCFunctin.AddParameter("anyi", ucrInputInitialYear.GetText, iPosition:=1, bIncludeArgumentName:=False)
            clsDdm2Function.AddParameter("final", ucrInputInitialYear.GetText, bIncludeArgumentName:=False, iPosition:=1)
            clsHomogenFunction.AddParameter("final_yr", ucrInputInitialYear.GetText, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsHomogenQCFunctin.RemoveParameterByName("anyi")
            clsDdm2Function.RemoveParameterByName("final")
            clsHomogenFunction.RemoveParameterByName("final_yr")
        End If
    End Sub

    Private Sub ucrReceiverLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlValueChanged, ucrReceiverElavation.ControlValueChanged,
            ucrReceiverLongtitude.ControlValueChanged, ucrReceiverStationId.ControlValueChanged, ucrReceiverStationName.ControlValueChanged
        If Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongtitude.IsEmpty Then
            Dim lstVariables As New List(Of String)()

            lstVariables.Add(ucrReceiverLatitude.GetVariableNames())
            lstVariables.Add(ucrReceiverLongtitude.GetVariableNames())

            If Not ucrReceiverElavation.IsEmpty Then
                lstVariables.Add(ucrReceiverElavation.GetVariableNames())
            Else
                lstVariables.Add(0)
            End If

            If Not ucrReceiverStationName.IsEmpty Then
                lstVariables.Add(ucrReceiverStationName.GetVariableNames())
            End If

            If Not ucrReceiverStationId.IsEmpty Then
                lstVariables.Add(ucrReceiverStationId.GetVariableNames())
            End If
            clsVars2ColumnsFunction.AddParameter("cols", "c(" & String.Join(", ", lstVariables) & ")", iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsVars2ColumnsFunction.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If iEnabledRadioButtonIndex >= 0 AndAlso iEnabledRadioButtonIndex < lstOfRadioButtons.Count - 1 Then
            ' Enable the next radio button
            iEnabledRadioButtonIndex += 1
            lstOfRadioButtons(iEnabledRadioButtonIndex).Enabled = True
        Else
            ' If all radio buttons are enabled, you may want to reset the counter or handle it as per your requirements
            ' For this example, I am resetting the counter to 0
            iEnabledRadioButtonIndex = 0
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSaveResult.ControlContentsChanged,
        ucrInputQ.ControlContentsChanged, ucrInputPenValue.ControlContentsChanged, ucrNudMinSegLen.ControlContentsChanged,
        ucrInputComboMethod.ControlContentsChanged, ucrInputComboPenalty.ControlContentsChanged, ucrReceiverDataFiles.ControlContentsChanged, ucrInputFinalYear.ControlContentsChanged, ucrInputInitialYear.ControlContentsChanged, ucrInputClimateVariables.ControlContentsChanged,
        ucrReceiverStationName.ControlContentsChanged, ucrReceiverStationId.ControlContentsChanged, ucrReceiverLongtitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class