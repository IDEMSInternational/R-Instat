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
Public Class dlgSurvey
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = True
    Private clsSvydesignFunction As New RFunction
    Private clsSvrepDesignFunction, clsSvysmoothFunction, clsSvyhistFunction, clsSvyboxplotFunction, clsSvyTotalFunction, clsSvycoFunction, clsSvymeanFunction, clsVarFunction, clsSvyQuantileFunction, clsSvySDFunction As New RFunction
    Private clsPoissonFunction, clsGetObjectRFunction, clsSvyqqplotFunction, clsSvyqqmathFunction, clsBinomialFunction, clsPlotsFunction, clsSummaryFunction, clsDummyFunction, clsRatioFunction, clsSvychisqFunction, clsSvyglmFunction As New RFunction
    Private clsVariablesOperator2, clsPlusSignOperator, clsVariablesPlusOperator, clsVariablesOperator, clsformulaOperator, clsVar2Operator, clsWeightsOperator, clsIDNewOperator, clsIdOperator, clsFpcOperator, clsStrataOperator As New ROperator

    Private Sub dlgSurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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
        Dim dctInputSummaryStat As New Dictionary(Of String, String)

        ucrSelectorSurvey.SetParameter(New RParameter("data", 0))
        ucrSelectorSurvey.SetParameterIsString()

        ucrReceiverFPC.SetParameter(New RParameter("fpc", 1))
        ucrReceiverFPC.Selector = ucrSelectorSurvey
        ucrReceiverFPC.bWithQuotes = False
        ucrReceiverFPC.SetParameterIsString()
        ucrReceiverFPC.SetMeAsReceiver()
        ucrReceiverFPC.SetLinkedDisplayControl(lblFPC)
        ucrReceiverFPC.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverFPC.strSelectorHeading = "Numerics"

        ucrReceiverVar1srs.SetParameter(New RParameter("x", 6))
        ucrReceiverVar1srs.Selector = ucrSelectorSurvey
        ucrReceiverVar1srs.bWithQuotes = False
        ucrReceiverVar1srs.SetParameterIsString()
        ucrReceiverVar1srs.SetMeAsReceiver()
        ucrReceiverVar1srs.SetLinkedDisplayControl(lblVar1srs)

        ucrReceiverVar2srs.SetParameter(New RParameter("variable2", 7))
        ucrReceiverVar2srs.Selector = ucrSelectorSurvey
        ucrReceiverVar2srs.bWithQuotes = False
        ucrReceiverVar2srs.SetParameterIsString()
        ucrReceiverVar2srs.SetMeAsReceiver()
        ucrReceiverVar2srs.SetLinkedDisplayControl(lblVar2srs)

        ucrReceiverSingleID.SetParameter(New RParameter("ids", 11))
        ucrReceiverSingleID.Selector = ucrSelectorSurvey
        ucrReceiverSingleID.bWithQuotes = False
        ucrReceiverSingleID.SetParameterIsString()
        ucrReceiverSingleID.SetMeAsReceiver()
        ucrReceiverSingleID.strSelectorHeading = "Numerics"
        ucrReceiverSingleID.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverSingleID.SetLinkedDisplayControl(lblId)

        ucrInputId.SetParameter(New RParameter("ids", 2, bNewIncludeArgumentName:=False))
        ucrInputId.AddQuotesIfUnrecognised = False
        ucrInputId.SetLinkedDisplayControl(lblInputID)

        ucrReceiverStrata.SetParameter(New RParameter("strata", 4))
        ucrReceiverStrata.Selector = ucrSelectorSurvey
        ucrReceiverStrata.bWithQuotes = False
        ucrReceiverStrata.SetParameterIsString()
        ucrReceiverStrata.strSelectorHeading = "Factors"
        ucrReceiverStrata.SetIncludedDataTypes({"factor"})
        ucrReceiverStrata.SetMeAsReceiver()
        ucrReceiverStrata.SetLinkedDisplayControl(lblStrata)

        ucrReceiverWeights.SetParameter(New RParameter("weights", 3))
        ucrReceiverWeights.Selector = ucrSelectorSurvey
        ucrReceiverWeights.bWithQuotes = False
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.SetMeAsReceiver()
        ucrReceiverWeights.SetLinkedDisplayControl(lblWeights)
        ucrReceiverWeights.strSelectorHeading = "Numerics"
        ucrReceiverWeights.SetIncludedDataTypes({"numeric"}, bStrict:=True)

        ucrVariablesAsFactorForContengy.SetParameter(New RParameter("formula", 13))
        ucrVariablesAsFactorForContengy.SetParameterIsString()
        ucrVariablesAsFactorForContengy.bWithQuotes = False
        ucrVariablesAsFactorForContengy.Selector = ucrSelectorSurvey
        ucrVariablesAsFactorForContengy.strSelectorHeading = "factors"
        ucrVariablesAsFactorForContengy.SetIncludedDataTypes({"factor"})

        ucrChkSummary.SetText("Summary")
        ucrChkSummary.AddParameterPresentCondition(True, "Summary")
        ucrChkSummary.AddParameterPresentCondition(False, "Summary", False)

        ucrChkRatios.SetText("Ratios")
        ucrChkRatios.SetParameter(New RParameter("check", 11))
        ucrChkRatios.SetValuesCheckedAndUnchecked("True", "False")
        ucrChkRatios.SetRDefault("FALSE")

        ucrChkContingencyTables.SetText("Contingency Tables")
        ucrChkContingencyTables.AddParameterValuesCondition(True, "check", "False")
        ucrChkContingencyTables.AddParameterValuesCondition(False, "check", "True")
        ucrChkContingencyTables.AddToLinkedControls(ucrVariablesAsFactorForContengy, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSummaryStat.SetParameter(New RParameter("x", 11, bNewIncludeArgumentName:=False))
        dctInputSummaryStat.Add("total", Chr(34) & "total" & Chr(34))
        dctInputSummaryStat.Add("mean", Chr(34) & "mean" & Chr(34))
        dctInputSummaryStat.Add("variance", Chr(34) & "variance" & Chr(34))
        dctInputSummaryStat.Add("quantile", Chr(34) & "quantile" & Chr(34))
        dctInputSummaryStat.Add("standard deviation", Chr(34) & "standard deviation" & Chr(34))
        dctInputSummaryStat.Add("correlation", Chr(34) & "correlation" & Chr(34))
        ucrInputSummaryStat.SetItems(dctInputSummaryStat)
        ucrInputSummaryStat.SetDropDownStyleAsNonEditable()

        ucrInputPlots.SetParameter(New RParameter("y", 11, bNewIncludeArgumentName:=False))
        ucrInputPlots.SetItems({"Boxplot", "Histogram", "Smooth Plot", "Quantile Plot"})
        ucrInputPlots.SetDropDownStyleAsNonEditable()

        'panel setting
        ucrPnlMethod.SetParameter(New RParameter("checked", 0))
        ucrPnlMethod.AddRadioButton(rdoSRS, "srs")
        ucrPnlMethod.AddRadioButton(rdoStratified, "strati")
        ucrPnlMethod.AddRadioButton(rdoClustered, "cluster")

        ucrPnlMethod.AddToLinkedControls(ucrInputId, {rdoSRS, rdoStratified}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls({ucrReceiverVar1srs, ucrReceiverVar2srs}, {rdoSRS}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverSingleID, {rdoClustered}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverStrata, {rdoStratified}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethod.AddToLinkedControls(ucrReceiverWeights, {rdoStratified, rdoClustered}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkModels.SetText("Models")
        ucrChkModels.AddParameterValuesCondition(True, "check", "False")
        ucrChkModels.AddParameterValuesCondition(False, "check", "True")
        ucrChkModels.AddToLinkedControls({ucrVariablesAsFactorForContengy, ucrInputModelsType, ucrChkModelsSummary, ucrChkModelsPlot}, {True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputModelsType.SetParameter(New RParameter("x", 11, bNewIncludeArgumentName:=False))
        ucrInputModelsType.SetDropDownStyleAsNonEditable()
        ucrInputModelsType.SetItems({"Linear regression", "Multiple regression", "Logistic regression", "log-linear regression", "Linear association"})
        ucrInputModelsType.SetRDefault(Chr(34) & "Linear regression" & Chr(34))
        ucrInputModelsType.SetLinkedDisplayControl(lblModelsType)

        ucrChkModelsSummary.SetText("Model Summary")
        ucrChkModelsSummary.AddParameterValuesCondition(True, "check", "False")
        ucrChkModelsSummary.AddParameterValuesCondition(False, "check", "True")

        ucrChkModelsPlot.SetText("Model Plot")
        ucrChkModelsPlot.AddParameterValuesCondition(True, "check", "False")
        ucrChkModelsPlot.AddParameterValuesCondition(False, "check", "True")
        ucrChkModelsPlot.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("SPI_plot")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorSurvey.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsGetObjectRFunction = New RFunction
        clsSvydesignFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsPlotsFunction = New RFunction
        clsSvrepDesignFunction = New RFunction
        clsSvymeanFunction = New RFunction
        clsVarFunction = New RFunction
        clsSvyTotalFunction = New RFunction
        clsSvyQuantileFunction = New RFunction
        clsSvySDFunction = New RFunction
        clsSvycoFunction = New RFunction
        clsDummyFunction = New RFunction
        clsRatioFunction = New RFunction
        clsSvychisqFunction = New RFunction
        clsSvyboxplotFunction = New RFunction
        clsSvyhistFunction = New RFunction
        clsSvysmoothFunction = New RFunction
        clsSvyglmFunction = New RFunction
        clsPoissonFunction = New RFunction
        clsBinomialFunction = New RFunction
        clsSvyqqmathFunction = New RFunction
        clsSvyqqplotFunction = New RFunction
        clsPlusSignOperator = New ROperator
        clsWeightsOperator = New ROperator
        clsIDNewOperator = New ROperator
        clsIdOperator = New ROperator
        clsFpcOperator = New ROperator
        clsStrataOperator = New ROperator
        clsVar2Operator = New ROperator
        clsformulaOperator = New ROperator
        clsVariablesOperator = New ROperator
        clsVariablesOperator2 = New ROperator
        clsVariablesPlusOperator = New ROperator

        ucrSaveGraph.Reset()

        ucrInputModelsType.SetName("Linear regression")
        ucrInputSummaryStat.SetName("mean")
        ucrInputPlots.SetName("Boxplot")

        clsDummyFunction.AddParameter("checked", "srs", iPosition:=0)
        clsDummyFunction.AddParameter("...", "True", iPosition:=1)
        clsDummyFunction.AddParameter("Sampling", "True", iPosition:=2)
        clsDummyFunction.AddParameter("check", "True", iPosition:=1)

        clsPlusSignOperator.SetOperation("+", bBracketsTemp:=False)
        clsPlusSignOperator.bSpaceAroundOperation = False
        clsPlusSignOperator.AddParameter("variable1", clsROperatorParameter:=clsVariablesOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsPlusSignOperator.AddParameter("variable2", clsROperatorParameter:=clsVariablesPlusOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsWeightsOperator.SetOperation("~")
        clsWeightsOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsWeightsOperator.bSpaceAroundOperation = False

        clsIdOperator.SetOperation("~")
        clsIdOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsIdOperator.bSpaceAroundOperation = False

        clsIDNewOperator.SetOperation("~")
        clsIDNewOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsIDNewOperator.bSpaceAroundOperation = False

        clsFpcOperator.SetOperation("~")
        clsFpcOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsFpcOperator.bSpaceAroundOperation = False

        clsStrataOperator.SetOperation("~")
        clsStrataOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsStrataOperator.bSpaceAroundOperation = False

        clsformulaOperator.SetOperation("~")
        clsformulaOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsformulaOperator.bSpaceAroundOperation = False

        clsVar2Operator.SetOperation("~")
        clsVar2Operator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVar2Operator.bSpaceAroundOperation = False

        clsVariablesOperator.SetOperation("~", bBracketsTemp:=False)
        clsVariablesOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVariablesOperator.bSpaceAroundOperation = False

        clsVariablesOperator2.SetOperation("~", bBracketsTemp:=False)
        clsVariablesOperator2.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVariablesOperator2.bSpaceAroundOperation = False

        clsVariablesPlusOperator.SetOperation("", bBracketsTemp:=False)
        clsVariablesPlusOperator.AddParameter(strParameterValue:="", iPosition:=0, bIncludeArgumentName:=False)
        clsVariablesPlusOperator.bSpaceAroundOperation = False

        ucrSelectorSurvey.Reset()
        ucrReceiverFPC.SetMeAsReceiver()

        clsSvydesignFunction.SetPackageName("survey")
        clsSvydesignFunction.SetRCommand("svydesign")
        clsSvydesignFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorSurvey.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=4)
        ' clsSvydesignFunction.AddParameter("weights", clsROperatorParameter:=clsWeightsOperator, iPosition:=3)
        clsSvydesignFunction.AddParameter("fpc", clsROperatorParameter:=clsFpcOperator, iPosition:=2)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        clsRatioFunction.SetPackageName("survey")
        clsRatioFunction.SetRCommand("svyratio")
        clsRatioFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
        clsRatioFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=2)
        clsRatioFunction.iCallType = 2

        clsSvychisqFunction.SetPackageName("survey")
        clsSvychisqFunction.SetRCommand("svychisq")
        ' clsSvychisqFunction.AddParameter("formula", clsROperatorParameter:=clsformulaOperator, iPosition:=0)
        clsSvychisqFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvychisqFunction.AddParameter("statistic", Chr(34) & "F" & Chr(34), iPosition:=2)
        clsSvychisqFunction.iCallType = 2

        clsSvrepDesignFunction.SetPackageName("survey")
        clsSvrepDesignFunction.SetRCommand("as.svrepdesign")
        clsSvrepDesignFunction.AddParameter("design", clsRFunctionParameter:=clsSvydesignFunction, iPosition:=0)
        clsSvrepDesignFunction.iCallType = 2

        clsSvymeanFunction.SetPackageName("survey")
        clsSvymeanFunction.SetRCommand("svymean")
        clsSvymeanFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
        clsSvymeanFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvymeanFunction.iCallType = 2

        clsSvyQuantileFunction.SetPackageName("survey")
        clsSvyQuantileFunction.SetRCommand("svyquantile")
        clsSvyQuantileFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
        clsSvyQuantileFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyQuantileFunction.AddParameter("quantiles", "c(.25,.5,.75)", iPosition:=2, bIncludeArgumentName:=False)
        clsSvyQuantileFunction.iCallType = 2

        clsSvyboxplotFunction.SetPackageName("survey")
        clsSvyboxplotFunction.SetRCommand("svyboxplot")
        clsSvyboxplotFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyboxplotFunction.iCallType = 3

        clsSvysmoothFunction.SetPackageName("survey")
        clsSvysmoothFunction.SetRCommand("svysmooth")
        clsSvysmoothFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvysmoothFunction.iCallType = 3

        clsSvySDFunction.SetPackageName("jtools")
        clsSvySDFunction.SetRCommand("svysd")
        clsSvySDFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvySDFunction.iCallType = 2

        clsSvycoFunction.SetPackageName("jtools")
        clsSvycoFunction.SetRCommand("svycor")
        'clsSvycoFunction.AddParameter("formula", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
        clsSvycoFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvycoFunction.iCallType = 2

        clsSvyTotalFunction.SetPackageName("survey")
        clsSvyTotalFunction.SetRCommand("svytotal")
        clsSvyTotalFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
        clsSvyTotalFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyTotalFunction.iCallType = 2

        clsVarFunction.SetPackageName("survey")
        clsVarFunction.SetRCommand("svyvar")
        clsVarFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
        clsVarFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsVarFunction.iCallType = 2

        clsSvyglmFunction.SetPackageName("survey")
        clsSvyglmFunction.SetRCommand("svyglm")
        clsSvyglmFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyglmFunction.iCallType = 2

        clsSvyqqmathFunction.SetPackageName("survey")
        clsSvyqqmathFunction.SetRCommand("svycoplot")
        clsSvyqqmathFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyqqmathFunction.iCallType = 2

        clsSvyqqplotFunction.SetPackageName("survey")
        clsSvyqqplotFunction.SetRCommand("svycoplot")
        clsSvyqqplotFunction.AddParameter("design", clsRFunctionParameter:=clsSvrepDesignFunction, iPosition:=1)
        clsSvyqqplotFunction.iCallType = 2

        ' clsPoissonFunction.SetPackageName("stats")
        clsPoissonFunction.SetRCommand("poisson")
        clsPoissonFunction.AddParameter("link", Chr(34) & "log" & Chr(34), iPosition:=0)

        ' clsBinomialFunction.SetPackageName("stats")
        clsBinomialFunction.SetRCommand("binomial")
        clsBinomialFunction.AddParameter("link", Chr(34) & "logit" & Chr(34), iPosition:=0)

        clsPlotsFunction.SetRCommand("plot")

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectRFunction.AddParameter("data_name", Chr(34) & ucrSelectorSurvey.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectRFunction.AddParameter("as_file", "TRUE", iPosition:=3)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSvydesignFunction)
        AddSummaryParameters()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVar2srs.AddAdditionalCodeParameterPair(clsVariablesOperator2, New RParameter("variable2", iNewPosition:=7), iAdditionalPairNo:=1)
        ucrVariablesAsFactorForContengy.AddAdditionalCodeParameterPair(clsSvyglmFunction, New RParameter("formula", 13), iAdditionalPairNo:=1)

        ucrSaveGraph.SetRCode(clsPlotsFunction, bReset)
        ucrReceiverFPC.SetRCode(clsFpcOperator, bReset)
        ucrReceiverSingleID.SetRCode(clsIDNewOperator, bReset)
        ucrReceiverStrata.SetRCode(clsStrataOperator, bReset)
        ucrReceiverWeights.SetRCode(clsWeightsOperator, bReset)
        ucrChkSummary.SetRCode(clsSummaryFunction, bReset)
        ucrChkModelsSummary.SetRCode(clsSummaryFunction, bReset)
        ucrPnlMethod.SetRCode(clsDummyFunction, bReset)
        ucrReceiverVar1srs.SetRCode(clsVariablesOperator, bReset)
        ucrReceiverVar2srs.SetRCode(clsVariablesPlusOperator, bReset)
        ucrChkRatios.SetRCode(clsRatioFunction, bReset)
        ucrVariablesAsFactorForContengy.SetRCode(clsSvychisqFunction, bReset)
        If bReset Then
            ucrChkContingencyTables.SetRCode(clsDummyFunction, bReset)
            ucrInputId.SetRCode(clsIdOperator, bReset)
        End If
        AddSummaryStatParameters()
    End Sub

    Private Sub TestOkEnabled()
        If rdoStratified.Checked Then
            If Not ucrReceiverFPC.IsEmpty AndAlso Not ucrInputId.IsEmpty AndAlso Not ucrReceiverWeights.IsEmpty AndAlso Not ucrReceiverStrata.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoClustered.Checked Then
            If Not ucrReceiverFPC.IsEmpty AndAlso Not ucrReceiverSingleID.IsEmpty AndAlso Not ucrReceiverWeights.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(Not ucrReceiverFPC.IsEmpty AndAlso Not ucrInputId.IsEmpty AndAlso Not ucrReceiverVar1srs.IsEmpty)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethod.ControlValueChanged
        RemoveStrata()
        ' UpdateContextVariables()
    End Sub

    Private Sub AddSummaryParameters()
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
    End Sub

    Private Sub AddSummaryStatParameters()
        If ucrInputSummaryStat.GetText = "mean" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvymeanFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "variance" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsVarFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "total" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyTotalFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "standard deviation" Then
            If Not ucrReceiverVar2srs.IsEmpty Then
                clsSvySDFunction.AddParameter("formula", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
            Else
                clsSvySDFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvySDFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        ElseIf ucrInputSummaryStat.GetText = "quantile" Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyQuantileFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvycoFunction)
        Else
            If Not ucrReceiverVar2srs.IsEmpty Then
                clsSvycoFunction.AddParameter("formula", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
            Else
                clsSvycoFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvycoFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvymeanFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsVarFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyTotalFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvySDFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyQuantileFunction)
        End If
    End Sub

    Private Sub Plots()
        If ucrInputPlots.GetText = "Boxplot" Then
            If ucrReceiverVar2srs.IsEmpty Then
                clsSvyboxplotFunction.AddParameter("formula", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
            Else
                clsSvyboxplotFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyboxplotFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyhistFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvysmoothFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqmathFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqplotFunction)
        ElseIf ucrInputPlots.GetText = "Histogram" Then
            clsSvyhistFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvyhistFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyboxplotFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvysmoothFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqmathFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqplotFunction)
        ElseIf ucrInputPlots.GetText = "Smooth Plot" Then
            If ucrReceiverVar2srs.IsEmpty Then
                clsSvysmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
            Else
                clsSvysmoothFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvysmoothFunction, iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyboxplotFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyhistFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqmathFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqplotFunction)
        Else
            If ucrReceiverVar2srs.IsEmpty Then
                clsSvyqqmathFunction.AddParameter("x", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyqqmathFunction, iPosition:=0)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqplotFunction)
            Else
                clsSvyqqmathFunction.AddParameter("formula", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyqqplotFunction, iPosition:=0)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyqqmathFunction)
            End If
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvysmoothFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyboxplotFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyhistFunction)
        End If
    End Sub

    Private Sub UpdateContextVariables2()
        If ucrVariablesAsFactorForContengy.bSingleVariable Then
            clsSvychisqFunction.AddParameter("formula", "~" & ucrVariablesAsFactorForContengy.GetVariableNames(False))
        Else
            Dim lstVariables = ucrVariablesAsFactorForContengy.ucrMultipleVariables.GetVariableNamesList(False).Where(Function(item) item IsNot Nothing).ToList()
            Dim strVar = If(lstVariables.Count > 1, String.Join("+", lstVariables), lstVariables(0))
            clsSvychisqFunction.AddParameter("formula", "~" & strVar)
        End If
    End Sub

    Private Sub RemoveStrata()
        clsSvydesignFunction.RemoveParameterByName("strata")
        If rdoStratified.Checked Then
            clsSvydesignFunction.AddParameter("strata", clsROperatorParameter:=clsStrataOperator, iPosition:=1)
        Else
            clsSvydesignFunction.RemoveParameterByName("strata")
        End If
    End Sub

    Private Sub ucrReceiverStrata_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStrata.ControlValueChanged
        RemoveStrata()
    End Sub

    Private Sub ucrPnlMethod_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWeights.ControlContentsChanged, ucrReceiverVar2srs.ControlContentsChanged, ucrReceiverVar1srs.ControlContentsChanged, ucrReceiverStrata.ControlContentsChanged, ucrReceiverSingleID.ControlContentsChanged, ucrReceiverFPC.ControlContentsChanged, ucrPnlMethod.ControlContentsChanged, ucrInputId.ControlContentsChanged
        TestOkEnabled()
        ChangeId()
    End Sub

    Private Sub ucrInputSummaryStat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSummaryStat.ControlValueChanged
        AddSummaryStatParameters()
    End Sub

    Private Sub ChangeId()
        If rdoClustered.Checked Then
            ucrInputId.Visible = False
            ucrReceiverSingleID.Visible = True
            clsSvydesignFunction.AddParameter("ids", clsROperatorParameter:=clsIDNewOperator, iPosition:=0)
        Else
            ucrInputId.Visible = True
            ucrReceiverSingleID.Visible = False
            clsSvydesignFunction.AddParameter("ids", clsROperatorParameter:=clsIdOperator, iPosition:=0)
        End If
    End Sub

    Private Sub ucrReceiverSingleID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleID.ControlValueChanged, ucrInputId.ControlValueChanged
        ChangeId()
    End Sub

    Private Sub ucrChkContingencyTables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkContingencyTables.ControlValueChanged
        If ucrChkContingencyTables.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSvychisqFunction, iPosition:=0)
            ucrVariablesAsFactorForContengy.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvychisqFunction)
            ucrVariablesAsFactorForContengy.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverVar1srs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVar2srs.ControlValueChanged, ucrReceiverVar1srs.ControlValueChanged, ucrChkSummary.ControlValueChanged, ucrChkRatios.ControlValueChanged

        If rdoSRS.Checked Then
            'Dim additionOperator As New ROperator
            'additionOperator.SetOperation("+", bBracketsTemp:=False)
            'additionOperator.bSpaceAroundOperation = False
            'additionOperator.AddParameter("variable1", clsROperatorParameter:=clsVariablesOperator, iPosition:=0, bIncludeArgumentName:=False)
            'additionOperator.AddParameter("variable2", clsROperatorParameter:=clsVariablesPlusOperator, iPosition:=1, bIncludeArgumentName:=False)
            If Not ucrReceiverVar1srs.IsEmpty Then
                If Not ucrReceiverVar2srs.IsEmpty Then
                    clsSvydesignFunction.AddParameter("variables", clsROperatorParameter:=clsPlusSignOperator, iPosition:=5)
                Else
                    clsSvydesignFunction.AddParameter("variables", clsROperatorParameter:=clsVariablesOperator, iPosition:=5)
                End If
            ElseIf Not ucrReceiverVar2srs.IsEmpty Then
                If Not ucrReceiverVar1srs.IsEmpty Then
                    clsSvydesignFunction.AddParameter("variables", clsROperatorParameter:=clsPlusSignOperator, iPosition:=5)
                Else
                    clsSvydesignFunction.AddParameter("variables", clsROperatorParameter:=clsVariablesOperator2, iPosition:=5)
                End If
            Else
                clsSvydesignFunction.RemoveParameterByName("variables")
            End If
            If ucrChkSummary.Checked Then
                If Not ucrReceiverVar1srs.IsEmpty AndAlso ucrReceiverVar2srs.IsEmpty Then
                    clsSummaryFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator, iPosition:=0)
                    ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
                ElseIf Not ucrReceiverVar1srs.IsEmpty AndAlso Not ucrReceiverVar2srs.IsEmpty Then
                    clsSummaryFunction.AddParameter("x", clsROperatorParameter:=clsPlusSignOperator, iPosition:=0)
                    ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
                ElseIf ucrReceiverVar1srs.IsEmpty AndAlso Not ucrReceiverVar2srs.IsEmpty Then
                    clsSummaryFunction.AddParameter("x", clsROperatorParameter:=clsVariablesOperator2, iPosition:=0)
                    ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
                Else
                    clsSummaryFunction.RemoveParameterByName("x")
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
                End If
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
            End If
            If ucrChkRatios.Checked Then
                If Not ucrReceiverVar2srs.IsEmpty Then
                    clsRatioFunction.AddParameter("denominator", clsROperatorParameter:=clsVariablesOperator2, iPosition:=1)
                Else
                    clsRatioFunction.RemoveParameterByName("denominator")
                End If
                ucrBase.clsRsyntax.AddToAfterCodes(clsRatioFunction, iPosition:=0)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRatioFunction)
            End If
        End If
        Plots()
    End Sub

    Private Sub ucrVariablesAsFactorForContengy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForContengy.ControlValueChanged
        UpdateContextVariables2()
    End Sub

    Private Sub ucrChkModels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModels.ControlValueChanged, ucrInputModelsType.ControlValueChanged, ucrChkModelsPlot.ControlValueChanged, ucrChkModelsSummary.ControlValueChanged
        If ucrChkModels.Checked AndAlso Not ucrVariablesAsFactorForContengy.bSingleVariable Then
            Dim lstVariables = ucrVariablesAsFactorForContengy.ucrMultipleVariables.GetVariableNamesList(False).Where(Function(item) item IsNot Nothing).ToList()
            Dim strVar1 = If(lstVariables.Count > 1, String.Join("+", lstVariables), lstVariables(1))
            Dim strVar0 = If(lstVariables.Count > 1, String.Join("~", lstVariables(1)), lstVariables(0))
            clsSvyglmFunction.AddParameter("formula", strVar0 & strVar1, iPosition:=0)

            If ucrInputModelsType.GetText = "Linear regression" Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyglmFunction, iPosition:=0)
            ElseIf ucrInputModelsType.GetText = "Multiple regression" Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyglmFunction, iPosition:=0)
            ElseIf ucrInputModelsType.GetText = "Logistic regression" Then
                clsSvyglmFunction.AddParameter("family", clsRFunctionParameter:=clsBinomialFunction, iPosition:=2)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyglmFunction, iPosition:=0)
            ElseIf ucrInputModelsType.GetText = "log-linear regression" Then
                clsSvyglmFunction.AddParameter("family", clsRFunctionParameter:=clsPoissonFunction, iPosition:=2)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyglmFunction, iPosition:=0)
            Else
                ucrBase.clsRsyntax.AddToAfterCodes(clsSvyglmFunction, iPosition:=0)
            End If
            If ucrChkModelsSummary.Checked Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
            End If
            If ucrChkModelsPlot.Checked Then
                clsPlotsFunction.AddParameter("plot", clsRFunctionParameter:=clsSvyglmFunction, iPosition:=0, bIncludeArgumentName:=False)
                ucrBase.clsRsyntax.AddToAfterCodes(clsPlotsFunction, iPosition:=0)
                ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectRFunction, iPosition:=1)
                clsPlotsFunction.iCallType = 3
                clsGetObjectRFunction.iCallType = 3
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsPlotsFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectRFunction)
            End If
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSvyglmFunction)
        End If
    End Sub

    Private Sub ucrInputPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPlots.ControlValueChanged
        Plots()
    End Sub

    Private Sub ucrSaveGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlValueChanged
        If ucrSaveGraph.ucrChkSave.Checked Then
            clsGetObjectRFunction.AddParameter("object_name", Chr(34) & ucrSaveGraph.GetText & Chr(34), iPosition:=1)
        Else
            clsGetObjectRFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        End If
    End Sub
End Class
