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

Imports instat
Imports instat.Translations
Imports RDotNet
Public Class dlgTwoVariableFitModel
    Private bFirstLoad As Boolean = True
    Private clsVisReg, clsFamilyFunction As New RFunction
    Private clsTransformFunction As New RFunction
    Private clsBrokenStickFirstOperator, clsBrokenStickSecondOperator, clsBrokenStickThirdOperator, clsBrokenStickGeneralOperator As New ROperator
    Private clsBrokenStickSecondOperFunction, clsBrokenStickIFunc As New RFunction
    Private clsSplineFunc As New RFunction

    'Tests
    Private clsTtestFunction, clsWilcoxTestFunction, clsVarTestFunction, clsAnsariTestFuntion, clsMoodTestFunction,
    clsCorTestFunction, clsKruskalTestFunction, clsOnewayTestFunction, clsBarletteTestFunction,
    clsFlignerTestFunction, clsFisherTestFunction, clsXchisgTestFunction, clsPropTestFunction As New RFunction

    'General case codes
    Private clsFormulaOperator As New ROperator
    Private clsGLM, clsLM, clsLMOrGLM, clsAsNumeric, clsPolynomialFunc As New RFunction
    Private clsMonthFunc, clsYearFunc, clsAsFactorFunc As New RFunction
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction

    'Saving Operators/Functions
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction

    'Display options codes
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction

    Private bRCodeSet As Boolean
    Private bReset As Boolean = True
    Public bResetOptionsSubDialog As Boolean = False
    Public bResetFirstFunction As Boolean = False
    Private dctPlotFunctions As New Dictionary(Of String, RFunction)
    Public StrMedianValue As String = ""

    Private Sub dlgTwoVariableFitModel_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        cmdExplanatoryFunction.Enabled = False
        ucrBase.iHelpTopicID = 366
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrModelPreview.IsReadOnly = True

        ucrPnlModelType.AddRadioButton(rdoGeneralCase)
        ucrPnlModelType.AddRadioButton(rdoTest)
        ucrPnlModelType.AddFunctionNamesCondition(rdoTest, "t.test")
        ucrPnlModelType.AddFunctionNamesCondition(rdoGeneralCase, "t.test", False)
        ucrPnlModelType.AddToLinkedControls(ucrModelPreview, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlModelType.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrInputTest.SetLinkedDisplayControl(lblTest)

        ucrInputTest.SetItems({"ConoverTest", "DunnettTest", "DunnTest", "MosesTest", "NemenyiTest", "PageTest",
                                  "RunsTest", "ScheffeTest", "SiegeTukeyRank", "SignTest", "VanWaerdenTest", "VarTest",
                                  "GTest", "JoneKheereTerpstraTest", "LehmacherTest", "LeveneTest", "LillieTest"})

        ucrInputTest.SetDropDownStyleAsNonEditable()

        'General case controls
        ucrSelectorSimpleReg.SetParameter(New RParameter("data", 0))
        ucrSelectorSimpleReg.SetParameterIsrfunction()

        'The main parameter will be in the as.numeric() function since it's always present there
        ucrReceiverResponse.SetParameter(New RParameter("x", 0))
        ucrReceiverResponse.Selector = ucrSelectorSimpleReg
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False

        ucrReceiverExplanatory.SetParameter(New RParameter("x", 1))
        ucrReceiverExplanatory.Selector = ucrSelectorSimpleReg
        ucrReceiverExplanatory.SetParameterIsString()
        ucrReceiverExplanatory.bWithQuotes = False

        ucrChkConvertToVariate.SetText("Convert to Numeric")
        ucrChkConvertToVariate.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToVariate.AddParameterIsRFunctionCondition(False, "y", False)

        ucrSaveModels.SetPrefix("two_var")
        ucrSaveModels.SetSaveTypeAsModel()
        ucrSaveModels.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrSaveModels.SetCheckBoxText("Save Model")
        ucrSaveModels.SetIsComboBox()
        ucrSaveModels.SetAssignToIfUncheckedValue("last_model")

        ucrTryModelling.SetReceiver(ucrNewInputTextBox:=ucrModelPreview)
        ucrTryModelling.SetIsModel()
    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator
        clsPolynomialFunc = New RFunction
        clsLM = New RFunction
        clsGLM = New RFunction
        clsAsNumeric = New RFunction
        clsFamilyFunction = New RFunction
        clsFormulaFunction = New RFunction
        clsConfint = New RFunction
        clsSummaryFunction = New RFunction
        clsAnovaFunction = New RFunction
        clsVisReg = New RFunction
        clsTransformFunction = New RFunction
        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction
        clsBrokenStickFirstOperator = New ROperator
        clsBrokenStickSecondOperator = New ROperator
        clsBrokenStickThirdOperator = New ROperator
        clsBrokenStickGeneralOperator = New ROperator
        clsBrokenStickIFunc = New RFunction
        clsSplineFunc = New RFunction
        clsMonthFunc = New RFunction
        clsYearFunc = New RFunction
        clsAsFactorFunc = New RFunction
        clsBrokenStickSecondOperFunction = New RFunction
        clsWilcoxTestFunction = New RFunction
        clsVarTestFunction = New RFunction
        clsAnsariTestFuntion = New RFunction
        clsMoodTestFunction = New RFunction
        clsCorTestFunction = New RFunction
        clsKruskalTestFunction = New RFunction
        clsOnewayTestFunction = New RFunction
        clsBarletteTestFunction = New RFunction
        clsFlignerTestFunction = New RFunction
        clsFisherTestFunction = New RFunction
        clsXchisgTestFunction = New RFunction
        clsPropTestFunction = New RFunction
        clsTtestFunction = New RFunction

        ucrBase.clsRsyntax.ClearCodes()

        ucrSaveModels.Reset()
        ucrSelectorSimpleReg.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrModelPreview.SetName("")
        ucrChkConvertToVariate.Visible = False

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)
        clsLM.AddParameter("na.action", "na.exclude", iPosition:=4)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)
        clsGLM.AddParameter("na.action", "na.exclude", iPosition:=4)

        clsPolynomialFunc.SetRCommand("poly")

        'Residual Plots
        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.iCallType = 3
        clsVisReg.bExcludeAssignedFunctionOutput = False

        'Model
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.iCallType = 2

        'Summary
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.iCallType = 2

        'ANOVA
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.iCallType = 2

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.iCallType = 2

        clsAsNumeric.SetRCommand("as.numeric")

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        clsLM.SetAssignTo(strTemp:=ucrSaveModels.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)
        clsGLM.SetAssignTo(strTemp:=ucrSaveModels.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)
        clsLMOrGLM = clsLM

        clsResidualFunction.SetRCommand("residuals")

        clsFittedValuesFunction.SetRCommand("fitted.values")

        clsRstandardFunction.SetRCommand("rstandard")

        clsHatvaluesFunction.SetRCommand("hatvalues")

        'Broken stick
        clsBrokenStickSecondOperFunction.SetRCommand("*")
        clsBrokenStickSecondOperFunction.AddParameter("brokenOp", clsROperatorParameter:=clsBrokenStickSecondOperator, bIncludeArgumentName:=False)

        clsBrokenStickFirstOperator.SetOperation("-")

        clsBrokenStickSecondOperator.SetOperation(">", bBracketsTemp:=False)

        clsBrokenStickThirdOperator.SetOperation("", bBracketsTemp:=False)
        clsBrokenStickThirdOperator.bSpaceAroundOperation = False
        clsBrokenStickThirdOperator.AddParameter("first", clsROperatorParameter:=clsBrokenStickFirstOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsBrokenStickThirdOperator.AddParameter("second", clsRFunctionParameter:=clsBrokenStickSecondOperFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsBrokenStickIFunc.SetRCommand("I")
        clsBrokenStickIFunc.AddParameter(clsROperatorParameter:=clsBrokenStickThirdOperator)

        clsBrokenStickGeneralOperator.SetOperation("+")
        clsBrokenStickGeneralOperator.AddParameter(clsRFunctionParameter:=clsBrokenStickIFunc, iPosition:=1)

        clsSplineFunc.SetPackageName("splines")
        clsSplineFunc.SetRCommand("bs")

        clsAsFactorFunc.SetRCommand("as.factor")

        clsMonthFunc.SetPackageName("lubridate")
        clsMonthFunc.SetRCommand("month")

        clsYearFunc.SetRCommand("year")
        clsYearFunc.SetPackageName("lubridate")

        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")

        'Tests
        clsWilcoxTestFunction.SetPackageName("stats")
        clsWilcoxTestFunction.SetRCommand("wilcox.test")

        clsVarTestFunction.SetPackageName("stats")
        clsVarTestFunction.SetRCommand("var.test")

        clsAnsariTestFuntion.SetPackageName("stats")
        clsAnsariTestFuntion.SetRCommand("ansari.test")

        clsMoodTestFunction.SetPackageName("stats")
        clsMoodTestFunction.SetRCommand("mood.test")

        clsCorTestFunction.SetPackageName("stats")
        clsCorTestFunction.SetRCommand("cor.test")

        clsKruskalTestFunction.SetPackageName("stats")
        clsKruskalTestFunction.SetRCommand("kruskal.test")

        clsOnewayTestFunction.SetPackageName("stats")
        clsOnewayTestFunction.SetRCommand("oneway.test")


        clsBarletteTestFunction.SetPackageName("stats")
        clsBarletteTestFunction.SetRCommand("barlette.test")

        clsFlignerTestFunction.SetPackageName("stats")
        clsFlignerTestFunction.SetRCommand("fligner.test")

        clsFisherTestFunction.SetPackageName("stats")
        clsFisherTestFunction.SetRCommand("fisher")

        clsXchisgTestFunction.SetPackageName("mosaic")
        clsXchisgTestFunction.SetRCommand("xchisq.test")

        clsPropTestFunction.SetPackageName("mosaic")
        clsPropTestFunction.SetRCommand("prop")

        clsTtestFunction.SetPackageName("stats")
        clsTtestFunction.SetRCommand("t.test")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
        bResetOptionsSubDialog = True
        bResetFirstFunction = True
    End Sub

    Private Sub SetRCodeForControls(bReset)
        bRCodeSet = False
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsBrokenStickGeneralOperator, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsBrokenStickFirstOperator, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsBrokenStickSecondOperator, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsSplineFunc, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=4)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsPolynomialFunc, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=5)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsMonthFunc, New RParameter("month", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=6)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsYearFunc, New RParameter("year", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=7)

        'Test
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsWilcoxTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=8)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsVarTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=9)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsAnsariTestFuntion, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=10)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsMoodTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=11)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsCorTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=12)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsKruskalTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=13)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsBarletteTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=14)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsFlignerTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=15)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsXchisgTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=16)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsFisherTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=17)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsTtestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=18)

        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsWilcoxTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsVarTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=2)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsAnsariTestFuntion, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=3)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsMoodTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=4)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsCorTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=5)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsKruskalTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=6)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBarletteTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=7)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsFlignerTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=8)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsXchisgTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=9)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsFisherTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=10)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsPropTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=11)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsTtestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=12)

        'General case controls 
        ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorSimpleReg.GetParameter(), 1)
        ucrSaveModels.AddAdditionalRCode(clsGLM, 1)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bReset)
        ucrReceiverExplanatory.SetRCode(clsTransformFunction, bReset)
        ucrPnlModelType.SetRCode(clsLMOrGLM, bReset)
        ucrSelectorSimpleReg.SetRCode(clsLM, bReset)
        ucrChkConvertToVariate.SetRCode(clsFormulaOperator)
        ucrSaveModels.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        bRCodeSet = True
    End Sub

    Private Sub TestOKEnabled()
        If rdoGeneralCase.Checked Then
            If Not ucrReceiverResponse.IsEmpty() AndAlso Not ucrReceiverExplanatory.IsEmpty() AndAlso ucrSaveModels.IsComplete AndAlso Not ucrDistributionChoice.ucrInputDistributions.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            'TODO
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, dctNewPlot:=dctPlotFunctions, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, ucrNewAvailableDatafrane:=ucrSelectorSimpleReg.ucrAvailableDataFrames, bReset:=bResetOptionsSubDialog)
        sdgSimpleRegOptions.ShowDialog()
        GraphAssignTo()
        bResetOptionsSubDialog = False
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub cmdExplanatoryFunction_Click(sender As Object, e As EventArgs) Handles cmdExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsFormulaOperator, clsNewTransformParameter:=clsFormulaOperator.GetParameter("exp1"), clsNewTransformFunction:=clsTransformFunction, clsNewPolynomialFunc:=clsPolynomialFunc, clsNewBrokenStickFirstOperator:=clsBrokenStickFirstOperator, clsNewBrokenStickSecondOperator:=clsBrokenStickSecondOperator, clsNewBrokenStickGeneralOperator:=clsBrokenStickGeneralOperator, strVariableName:=ucrReceiverExplanatory.GetVariableNames(False), clsNewSplineFunc:=clsSplineFunc, clsNewYearFunc:=clsYearFunc, clsNewMonthFunc:=clsMonthFunc, clsNewAsFactorFunc:=clsAsFactorFunc, strNewMedianValue:=StrMedianValue, strNewCurDataType:=ucrReceiverExplanatory.strCurrDataType, bReset:=bResetFirstFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFirstFunction = False
        UpdatePreview()
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverExplanatory.IsEmpty Then
            ucrModelPreview.SetName(clsFormulaOperator.ToScript())
        Else
            ucrModelPreview.SetName("")
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoGeneralCase.Checked Then
            If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal") Then
                clsLMOrGLM = clsLM
            Else
                clsLMOrGLM = clsGLM
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
            'Update display functions to contain correct model
            clsFormulaFunction.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM)
            clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
            clsConfint.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
            clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsLMOrGLM)

            For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
                kvp.Value.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            Next

            clsResidualFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsFittedValuesFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsRstandardFunction.AddParameter("model", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsHatvaluesFunction.AddParameter("model", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
        ElseIf rdoTest.Checked Then

        End If
    End Sub

    Private Sub ucrDistWithParameters_ucrInputDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrResponse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlValueChanged
        ucrDistributionChoice.Enabled = Not ucrReceiverResponse.IsEmpty
        If bRCodeSet Then
            If Not ucrReceiverResponse.IsEmpty Then
                ucrDistributionChoice.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                If Not ucrDistributionChoice.strDataType = "numeric" Then
                    If ucrDistributionChoice.lstCurrentDistributions.Count = 0 Then
                        ucrDistributionChoice.ucrInputDistributions.SetName("")
                        ucrDistributionChoice.Enabled = False
                        cmdModelOptions.Enabled = False
                    End If
                    ucrChkConvertToVariate.Checked = False
                End If
                ucrChkConvertToVariate.Visible = Not (ucrDistributionChoice.strDataType = "numeric")
            Else
                ucrDistributionChoice.ucrInputDistributions.SetName("")
                ucrDistributionChoice.Enabled = False
                cmdModelOptions.Enabled = False
                ucrChkConvertToVariate.Checked = False
                ucrChkConvertToVariate.Visible = False
            End If
        End If
        UpdatePreview()
    End Sub

    Private Sub ucrSelectorSimpleReg_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorSimpleReg.ControlValueChanged
        GraphAssignTo()
    End Sub

    'temp fix for graph display problem with RDotNet
    'correct solution is to have save controls linked to each graph
    Private Sub GraphAssignTo()
        clsVisReg.SetAssignTo("last_visreg", strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_visreg")
    End Sub

    Private Sub ucrReceiverExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverExplanatory.IsEmpty Then
                clsFormulaOperator.AddParameter("exp1", ucrReceiverExplanatory.GetVariableNames(False), iPosition:=1)
            Else
                clsFormulaOperator.RemoveParameterByName("exp1")
            End If
            UpdatePreview()
        End If
        If Not ucrReceiverExplanatory.IsEmpty AndAlso {"numeric", "integer", "Date"}.Contains(ucrReceiverExplanatory.strCurrDataType) Then
            GetColumnMedian()
            cmdExplanatoryFunction.Enabled = True
        Else
            cmdExplanatoryFunction.Enabled = False
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>  Finds the median of the X variable from the main dialogue and sets the
    '''            broken stick textbox to this value
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub GetColumnMedian()
        Dim expColumn As SymbolicExpression
        Dim clsGetColumnMedianFunc As New RFunction
        Dim clsGetVariablesFunc As New RFunction

        clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVariablesFunc.AddParameter("data_name", Chr(34) & ucrSelectorSimpleReg.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsGetVariablesFunc.AddParameter("col_names", Chr(34) & ucrReceiverExplanatory.GetVariableNames(False) & Chr(34), iPosition:=1)

        clsGetColumnMedianFunc.SetRCommand("summary_median")
        clsGetColumnMedianFunc.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunc, iPosition:=0)
        clsGetColumnMedianFunc.AddParameter("na.rm", "TRUE", iPosition:=1)

        expColumn = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumnMedianFunc.ToScript(), bSilent:=False)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            StrMedianValue = expColumn.AsCharacter(0)
        End If
    End Sub

    Private Sub ucrPnlModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlValueChanged
        If rdoGeneralCase.Checked Then
            ucrDistributionChoice.SetGLMDistributions()
        Else
            ucrDistributionChoice.SetExactDistributions()
        End If
        lblNumeric.Visible = rdoGeneralCase.Checked
        lblFactor.Visible = rdoGeneralCase.Checked
        lblFirstVariable.Visible = Not rdoGeneralCase.Checked
        lblSecondVariable.Visible = Not rdoGeneralCase.Checked
        SetBaseFunction()
    End Sub

    Private Sub ucrChkConvertToVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertToVariate.ControlValueChanged
        If bRCodeSet Then
            If ucrChkConvertToVariate.Checked Then
                clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                ucrDistributionChoice.RecieverDatatype("numeric")
                ucrDistributionChoice.Enabled = True
            Else
                clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                ucrDistributionChoice.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))

            End If
            UpdatePreview()
        End If
        If ucrDistributionChoice.lstCurrentDistributions.Count = 0 Then
            ucrDistributionChoice.ucrInputDistributions.SetName("")
            ucrDistributionChoice.Enabled = False
            cmdModelOptions.Enabled = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlContentsChanged, ucrPnlModelType.ControlContentsChanged, ucrReceiverExplanatory.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class