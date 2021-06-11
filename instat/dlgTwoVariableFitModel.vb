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
    Private strFirstVariableType, strSecondVariableType As String
    Private iNumberOfSecondFactorLevels As Integer
    Private iNumberOfFirstFactorLevels As Integer
    Private bFirstLoad As Boolean = True
    Private clsVisReg, clsFamilyFunction As New RFunction
    Private clsTransformFunction As New RFunction
    Private clsBrokenStickFirstOperator, clsBrokenStickSecondOperator, clsBrokenStickThirdOperator, clsBrokenStickGeneralOperator As New ROperator
    Private clsBrokenStickSecondOperFunction, clsBrokenStickIFunc As New RFunction
    Private clsSplineFunc As New RFunction

    'Tests
    Private clsNumericTtestFunction, clsTtestFunction, clsNumericWilcoxTestFunction, clsWilcoxTestFunction,
        clsNumericVarTestFunction, clsVarTestFunction, clsAnsariTestFunction, clsNumericAnsariTestFuntion,
        clsMoodTestFunction, clsNumericMoodTestFunction, clsCorTestFunction, clsKruskalTestFunction,
        clsNumericKruskalTestFunction, clsOnewayTestFunction, clsBarletteTestFunction, clsNumericBarletteTestFunction,
        clsMcnemarTestFunction, clsFlignerTestFunction, clsNumericFlignerTestFunction, clsFisherTestFunction,
        clsXchisgTestFunction, clsPropTestFunction As New RFunction

    Private clsTtestOperator, clsWilcoxTestOperator, clsVarTestOperator, clsAnsariTestOperator,
        clsMoodTestOperator, clsKruskalTestOperator, clsBarletteTestOperator,
                clsFlignerTestOperator, clsPropTestOperator As New ROperator

    Private clsOneWayFormulaOperator As New ROperator

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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctConfidenceInterval As New Dictionary(Of String, String)
        Dim lstControl As New List(Of Control)(New Control() {lblTest, lblFirstVariable, lblFirstVariableType,
             lblSecondVariable, lblSecondVariableType})

        cmdExplanatoryFunction.Enabled = False
        ucrBase.iHelpTopicID = 366
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrModelPreview.IsReadOnly = True
        ucrModelPreview.SetLinkedDisplayControl(lblModelPreview)

        ucrPnlModelType.AddRadioButton(rdoGeneralCase)
        ucrPnlModelType.AddRadioButton(rdoTest)
        ucrPnlModelType.AddToLinkedControls(ucrModelPreview, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlModelType.AddFunctionNamesCondition(rdoTest, {"t.test", "wilcox.test", "var.test", "ansari.test",
                                                  "mood.test", "cor.test", "cor", "kruskal.test", "bartlett.test",
                                                  "fligner.test", "fisher.test", "xchisq.test", "prop.test", "aov",
                                                   "mcnemar.test"})
        ucrPnlModelType.AddFunctionNamesCondition(rdoGeneralCase, {"t.test", "wilcox.test", "var.test", "ansari.test",
                                                  "mood.test", "cor.test", "cor", "kruskal.test", "bartlett.test",
                                                  "fligner.test", "fisher.test", "xchisq.test", "prop.test", "aov",
                                                  "mcnemar.test"}, False)
        ucrPnlModelType.AddToLinkedControls(ucrDistributionChoice, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlModelType.AddToLinkedControls(ucrChkConvertToVariate, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlModelType.AddToLinkedControls(ucrInputTest, {rdoTest}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)


        ucrInputTest.SetItems({"t", "t paired", "wilcox", "var", "ansari", "mood",
                                  "cor", "kruskal", "bartlett", "fligner", "fisher", "chisq",
                                  "propotion", "mcnemar"})
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

        'Test Controls
        ucrInputConfidenceInterval.SetParameter(New RParameter("conf.level", 2))
        dctConfidenceInterval.Add("0.900", "0.90")
        dctConfidenceInterval.Add("0.950", "0.95")
        dctConfidenceInterval.Add("0.980", "0.98")
        dctConfidenceInterval.Add("0.990", "0.99")
        dctConfidenceInterval.Add("0.999", "0.999")
        ucrInputConfidenceInterval.SetItems(dctConfidenceInterval)
        ucrInputConfidenceInterval.AddQuotesIfUnrecognised = False
        ucrInputConfidenceInterval.SetValidationTypeAsNumeric(dcmMin:=0.0, bIncludeMin:=True, dcmMax:=1.0, bIncludeMax:=True)
        ucrInputConfidenceInterval.bAllowNonConditionValues = True

        ucrInputNullHypothesis.SetParameter(New RParameter("mu", 3))
        ucrInputNullHypothesis.SetValidationTypeAsNumeric()
        ucrInputNullHypothesis.AddQuotesIfUnrecognised = False

        ucrInputTest.AddToLinkedControls(ucrInputConfidenceInterval, {"t", "t paired", "wilcox",
                                         "var", "ansari", "cor", "spearman", "kendall"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputTest.AddToLinkedControls(ucrInputNullHypothesis, {"t", "t paired", "wilcox"},
                                         bNewLinkedHideIfParameterMissing:=True)
        ucrInputConfidenceInterval.SetLinkedDisplayControl(lblConfidenceLevel)
        ucrInputTest.SetLinkedDisplayControl(lstControl)
        ucrInputNullHypothesis.SetLinkedDisplayControl(lblNullHypothesis)

        ucrSaveModels.SetPrefix("two_var")
        ucrSaveModels.SetSaveTypeAsModel()
        ucrSaveModels.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrSaveModels.SetCheckBoxText("Save Model")
        ucrSaveModels.SetIsComboBox()
        ucrSaveModels.SetAssignToIfUncheckedValue("last_model")

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
        clsNumericWilcoxTestFunction = New RFunction
        clsWilcoxTestFunction = New RFunction
        clsNumericVarTestFunction = New RFunction
        clsVarTestFunction = New RFunction
        clsNumericAnsariTestFuntion = New RFunction
        clsNumericMoodTestFunction = New RFunction
        clsCorTestFunction = New RFunction
        clsNumericKruskalTestFunction = New RFunction
        clsOnewayTestFunction = New RFunction
        clsNumericBarletteTestFunction = New RFunction
        clsNumericFlignerTestFunction = New RFunction
        clsFisherTestFunction = New RFunction
        clsXchisgTestFunction = New RFunction
        clsPropTestFunction = New RFunction
        clsNumericTtestFunction = New RFunction
        clsTtestFunction = New RFunction
        clsMcnemarTestFunction = New RFunction
        clsAnsariTestFunction = New RFunction
        clsMoodTestFunction = New RFunction
        clsKruskalTestFunction = New RFunction
        clsBarletteTestFunction = New RFunction
        clsFlignerTestFunction = New RFunction
        clsAnsariTestOperator = New ROperator
        clsMoodTestOperator = New ROperator
        clsKruskalTestOperator = New ROperator
        clsBarletteTestOperator = New ROperator
        clsFlignerTestOperator = New ROperator
        clsOneWayFormulaOperator = New ROperator
        clsTtestOperator = New ROperator
        clsWilcoxTestOperator = New ROperator
        clsVarTestOperator = New ROperator
        clsPropTestOperator = New ROperator

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
        clsNumericWilcoxTestFunction.SetRCommand("wilcox.test")

        clsWilcoxTestFunction.SetRCommand("wilcox.test")
        clsWilcoxTestFunction.AddParameter("wilcoxOperator", clsROperatorParameter:=clsWilcoxTestOperator,
                                           iPosition:=0, bIncludeArgumentName:=False)

        clsWilcoxTestOperator.SetOperation("~")
        clsWilcoxTestOperator.bSpaceAroundOperation = True

        clsNumericVarTestFunction.SetRCommand("var.test")

        clsVarTestFunction.SetRCommand("var.test")
        clsVarTestFunction.AddParameter("varOperator", clsROperatorParameter:=clsVarTestOperator,
                                        bIncludeArgumentName:=False, iPosition:=0)

        clsVarTestOperator.SetOperation("~")
        clsVarTestOperator.bSpaceAroundOperation = True

        clsAnsariTestFunction.SetRCommand("ansari.test")
        clsAnsariTestOperator.SetOperation("~")
        clsAnsariTestFunction.AddParameter("ansariOperator", clsROperatorParameter:=clsAnsariTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsNumericAnsariTestFuntion.SetRCommand("ansari.test")

        clsMoodTestFunction.SetRCommand("mood.test")
        clsMoodTestOperator.SetOperation("~")
        clsMoodTestFunction.AddParameter("moodOperator", clsROperatorParameter:=clsMoodTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsNumericMoodTestFunction.SetRCommand("mood.test")

        clsCorTestFunction.SetRCommand("cor.test")

        clsKruskalTestFunction.SetRCommand("kruskal.test")
        clsKruskalTestOperator.SetOperation("~")
        clsKruskalTestFunction.AddParameter("kruskalOperator", clsROperatorParameter:=clsKruskalTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsNumericKruskalTestFunction.SetRCommand("kruskal.test")

        clsOneWayFormulaOperator.SetOperation("~")

        clsOnewayTestFunction.SetRCommand("aov")
        clsOnewayTestFunction.AddParameter("formula", clsROperatorParameter:=clsOneWayFormulaOperator, iPosition:=0)

        clsBarletteTestFunction.SetRCommand("bartlett.test")
        clsBarletteTestOperator.SetOperation("~")
        clsBarletteTestFunction.AddParameter("barletteOperator", clsROperatorParameter:=clsBarletteTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsNumericBarletteTestFunction.SetRCommand("bartlett.test")

        clsFlignerTestFunction.SetRCommand("fligner.test")
        clsFlignerTestOperator.SetOperation("~")
        clsFlignerTestFunction.AddParameter("fligneroperator", clsROperatorParameter:=clsFlignerTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsNumericFlignerTestFunction.SetRCommand("fligner.test")

        clsFisherTestFunction.SetRCommand("fisher.test")

        clsXchisgTestFunction.SetPackageName("mosaic")
        clsXchisgTestFunction.SetRCommand("xchisq.test")

        clsPropTestFunction.SetPackageName("mosaic")
        clsPropTestFunction.SetRCommand("prop.test")
        clsPropTestFunction.AddParameter("propOperator", clsROperatorParameter:=clsPropTestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsPropTestOperator.SetOperation("~")

        clsNumericTtestFunction.SetRCommand("t.test")

        clsTtestFunction.SetRCommand("t.test")
        clsTtestFunction.AddParameter("testOperator", clsROperatorParameter:=clsTtestOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsTtestFunction.AddParameter("conf.level", "0.95", iPosition:=2)
        clsTtestFunction.AddParameter("mu", "0", iPosition:=3)

        clsTtestOperator.SetOperation("~")
        clsTtestOperator.bSpaceAroundOperation = True

        clsMcnemarTestFunction.SetRCommand("mcnemar.test")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        ucrTryModelling.AssociatedControls({ucrReceiverExplanatory, ucrReceiverResponse, ucrInputTest})
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
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsWilcoxTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=8)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsVarTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=9)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericAnsariTestFuntion, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=10)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericMoodTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=11)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsCorTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=12)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericKruskalTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=13)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericBarletteTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=14)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericFlignerTestFunction, New RParameter("g", iNewPosition:=1), iAdditionalPairNo:=15)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsXchisgTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=16)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsFisherTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=17)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsTtestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=18)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsMcnemarTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=19)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsOneWayFormulaOperator, New RParameter("SecondOperator", iNewPosition:=1), iAdditionalPairNo:=20)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericTtestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=21)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericVarTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=22)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsNumericWilcoxTestFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=23)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsBarletteTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=24)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsAnsariTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=25)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsMoodTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=26)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsKruskalTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=27)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsFlignerTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=28)
        ucrReceiverExplanatory.AddAdditionalCodeParameterPair(clsPropTestOperator, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=29)

        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsWilcoxTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsVarTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=2)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericAnsariTestFuntion, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=3)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericMoodTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=4)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsCorTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=5)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericKruskalTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=6)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericBarletteTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=7)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericFlignerTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=8)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsXchisgTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=9)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsFisherTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=10)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsTtestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=11)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsMcnemarTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=12)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsOneWayFormulaOperator, New RParameter("firstOperator", iNewPosition:=0), iAdditionalPairNo:=13)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericWilcoxTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=14)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericVarTestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=15)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsNumericTtestFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=16)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsAnsariTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=17)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsMoodTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=18)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsBarletteTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=19)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsFlignerTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=20)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsPropTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=21)
        ucrReceiverResponse.AddAdditionalCodeParameterPair(clsKruskalTestOperator, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=22)

        ' Additional Rcode for test functions
        ucrSaveModels.AddAdditionalRCode(clsWilcoxTestFunction, iAdditionalPairNo:=1)
        ucrSaveModels.AddAdditionalRCode(clsVarTestFunction, iAdditionalPairNo:=2)
        ucrSaveModels.AddAdditionalRCode(clsNumericAnsariTestFuntion, iAdditionalPairNo:=3)
        ucrSaveModels.AddAdditionalRCode(clsTtestFunction, iAdditionalPairNo:=4)
        ucrSaveModels.AddAdditionalRCode(clsNumericMoodTestFunction, iAdditionalPairNo:=5)
        ucrSaveModels.AddAdditionalRCode(clsCorTestFunction, iAdditionalPairNo:=6)
        ucrSaveModels.AddAdditionalRCode(clsNumericKruskalTestFunction, iAdditionalPairNo:=7)
        ucrSaveModels.AddAdditionalRCode(clsNumericBarletteTestFunction, iAdditionalPairNo:=8)
        ucrSaveModels.AddAdditionalRCode(clsNumericFlignerTestFunction, iAdditionalPairNo:=9)
        ucrSaveModels.AddAdditionalRCode(clsXchisgTestFunction, iAdditionalPairNo:=10)
        ucrSaveModels.AddAdditionalRCode(clsPropTestFunction, iAdditionalPairNo:=11)
        ucrSaveModels.AddAdditionalRCode(clsTtestFunction, iAdditionalPairNo:=12)
        ucrSaveModels.AddAdditionalRCode(clsMcnemarTestFunction, iAdditionalPairNo:=13)
        ucrSaveModels.AddAdditionalRCode(clsGLM, iAdditionalPairNo:=14)
        ucrSaveModels.AddAdditionalRCode(clsOnewayTestFunction, iAdditionalPairNo:=15)
        ucrSaveModels.AddAdditionalRCode(clsNumericTtestFunction, iAdditionalPairNo:=16)
        ucrSaveModels.AddAdditionalRCode(clsNumericVarTestFunction, iAdditionalPairNo:=17)
        ucrSaveModels.AddAdditionalRCode(clsNumericWilcoxTestFunction, iAdditionalPairNo:=18)
        ucrSaveModels.AddAdditionalRCode(clsAnsariTestFunction, iAdditionalPairNo:=19)
        ucrSaveModels.AddAdditionalRCode(clsMoodTestFunction, iAdditionalPairNo:=20)
        ucrSaveModels.AddAdditionalRCode(clsKruskalTestFunction, iAdditionalPairNo:=21)
        ucrSaveModels.AddAdditionalRCode(clsBarletteTestFunction, iAdditionalPairNo:=22)
        ucrSaveModels.AddAdditionalRCode(clsFlignerTestFunction, iAdditionalPairNo:=23)

        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsWilcoxTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=1)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsVarTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=2)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsNumericAnsariTestFuntion, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=3)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsNumericMoodTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=4)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsCorTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=5)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsNumericTtestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=6)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsNumericVarTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=7)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsNumericWilcoxTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=8)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsAnsariTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=9)
        ucrInputConfidenceInterval.AddAdditionalCodeParameterPair(clsMoodTestFunction, New RParameter("conf.level", iNewPosition:=2), iAdditionalPairNo:=10)

        ucrInputConfidenceInterval.SetRCode(clsTtestFunction, bReset)

        ucrInputNullHypothesis.AddAdditionalCodeParameterPair(clsWilcoxTestFunction, New RParameter("mu", iNewPosition:=4), iAdditionalPairNo:=1)
        ucrInputNullHypothesis.SetRCode(clsTtestFunction, bReset)
        'General case controls 
        ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorSimpleReg.GetParameter(), 1)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bReset)
        ucrReceiverExplanatory.SetRCode(clsTransformFunction, bReset)
        ucrPnlModelType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        ElseIf rdoTest.Checked Then
            If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverExplanatory.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
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
            ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)
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
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAnovaFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)

            Select Case ucrInputTest.GetText()
                Case "t"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        clsTtestFunction.AddParameter("paired", "FALSE", iPosition:=4)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsTtestFunction)
                    Else
                        clsNumericTtestFunction.AddParameter("paired", "FALSE", iPosition:=4)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericTtestFunction)
                    End If
                Case "t paired"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        clsTtestFunction.AddParameter("paired", "TRUE", iPosition:=4)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsTtestFunction)
                    Else
                        clsNumericTtestFunction.AddParameter("paired", "TRUE", iPosition:=4)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericTtestFunction)
                    End If
                Case "wilcox"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsWilcoxTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericWilcoxTestFunction)
                    End If
                Case "var"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsVarTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericVarTestFunction)
                    End If
                Case "ansari"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsAnsariTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericAnsariTestFuntion)
                    End If
                Case "mood"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsMoodTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericMoodTestFunction)
                    End If
                Case "cor"
                    clsCorTestFunction.AddParameter("method", Chr(34) & "pearson" & Chr(34))
                    ucrBase.clsRsyntax.SetBaseRFunction(clsCorTestFunction)
                Case "kruskal"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsKruskalTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericKruskalTestFunction)
                    End If
                Case "bartlett"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsBarletteTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericBarletteTestFunction)
                    End If
                Case "fligner"
                    If strFirstVariableType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                        ucrBase.clsRsyntax.SetBaseRFunction(clsFlignerTestFunction)
                    Else
                        ucrBase.clsRsyntax.SetBaseRFunction(clsNumericFlignerTestFunction)
                    End If
                Case "fisher"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFisherTestFunction)
                Case "chisq"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsXchisgTestFunction)
                Case "proportion"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsPropTestFunction)
                Case "mcnemar"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMcnemarTestFunction)
                Case "spearman"
                    clsCorTestFunction.AddParameter("method", Chr(34) & "spearman" & Chr(34))
                    ucrBase.clsRsyntax.SetBaseRFunction(clsCorTestFunction)
                Case "kendall"
                    clsCorTestFunction.AddParameter("method", Chr(34) & "kendall" & Chr(34))
                    ucrBase.clsRsyntax.SetBaseRFunction(clsCorTestFunction)
                Case "oneway"
                    ucrBase.clsRsyntax.SetBaseRFunction(clsOnewayTestFunction)
            End Select
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
        ReceiverColumnType()
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
        ReceiverColumnType()
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
            cmdDisplayOptions.Visible = True
            cmdModelOptions.Visible = True
        Else
            ucrDistributionChoice.SetExactDistributions()
            cmdDisplayOptions.Visible = False
            cmdModelOptions.Visible = False
        End If
        lblNumeric.Visible = rdoGeneralCase.Checked
        lblFactor.Visible = rdoGeneralCase.Checked
        cmdExplanatoryFunction.Visible = rdoGeneralCase.Checked
        SetBaseFunction()
        ReceiverColumnType()
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

    Private Sub ReceiverColumnType()
        If rdoTest.Checked Then
            If bRCodeSet Then
                If Not ucrReceiverResponse.IsEmpty Then
                    strFirstVariableType = ucrReceiverResponse.strCurrDataType
                    If strFirstVariableType.Contains("factor") OrElse strFirstVariableType.Contains("character") OrElse strFirstVariableType.Contains("logical") Then
                        strFirstVariableType = "categorical"
                        iNumberOfFirstFactorLevels = GetNumberOfFactorLevels(ucrReceiverResponse.GetVariableNames(False))
                        lblFirstVariableType.Text = "(" & strFirstVariableType & ")" & "  Levels: " & iNumberOfFirstFactorLevels
                    Else
                        strFirstVariableType = "numeric"
                        lblFirstVariableType.Text = "(" & strFirstVariableType & ")"
                    End If
                    lblFirstVariableType.ForeColor = SystemColors.Highlight
                Else
                    strFirstVariableType = ""
                    lblFirstVariableType.Text = "________"
                    lblFirstVariableType.ForeColor = SystemColors.ControlText
                End If
                If Not ucrReceiverExplanatory.IsEmpty Then
                    strSecondVariableType = ucrReceiverExplanatory.strCurrDataType
                    If strSecondVariableType.Contains("factor") OrElse strSecondVariableType.Contains("character") OrElse strSecondVariableType.Contains("logical") Then
                        strSecondVariableType = "categorical"
                        iNumberOfSecondFactorLevels = GetNumberOfFactorLevels(ucrReceiverExplanatory.GetVariableNames(False))
                        lblSecondVariableType.Text = "(" & strSecondVariableType & ")" & "  Levels: " & iNumberOfSecondFactorLevels
                    Else
                        strSecondVariableType = "numeric"
                        lblSecondVariableType.Text = "(" & strSecondVariableType & ")"
                    End If
                    lblSecondVariableType.ForeColor = SystemColors.Highlight
                Else
                    strSecondVariableType = ""
                    lblSecondVariableType.Text = "________"
                    lblSecondVariableType.ForeColor = SystemColors.ControlText
                End If
                UpdatingTests()
            End If
        End If
    End Sub

    Private Function GetNumberOfFactorLevels(strColumnName As String) As String
        Dim expColumn As SymbolicExpression
        Dim clsGetFactorLevles As New RFunction
        Dim iFactorCount As Integer = 0
        clsGetFactorLevles.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels")
        clsGetFactorLevles.AddParameter("data_name", Chr(34) & ucrSelectorSimpleReg.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsGetFactorLevles.AddParameter("col_name", Chr(34) & strColumnName & Chr(34), iPosition:=1)

        expColumn = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFactorLevles.ToScript(), bSilent:=False)
        If expColumn IsNot Nothing AndAlso Not expColumn.Type = Internals.SymbolicExpressionType.Null Then
            iFactorCount = expColumn.AsCharacter().ToList.Count
            Return iFactorCount
        Else
            Return ""
        End If
    End Function

    Private Sub UpdatingTests()
        If strFirstVariableType = "numeric" Then
            If strSecondVariableType = "numeric" Then
                ucrInputTest.SetItems({"t", "t paired", "wilcox",
                                      "________", "var", "ansari", "mood", "________", "cor", "spearman", "kendall"})
                ucrInputTest.SetText("t")
            ElseIf strSecondVariableType = "categorical" Then
                If iNumberOfSecondFactorLevels = 2 Then
                    ucrInputTest.SetItems({"t", "wilcox", "var", "ansari", "mood", "________",
                      "oneway", "kruskal", "bartlett", "fligner"})
                    ucrInputTest.SetText("t")
                ElseIf iNumberOfSecondFactorLevels > 2 Then
                    ucrInputTest.SetItems({"oneway", "kruskal", "bartlett", "fligner"})
                    ucrInputTest.SetText("oneway")
                End If

            ElseIf strSecondVariableType = "" Then
                ucrInputTest.SetItems({"None"})
                ucrInputTest.SetText("None")
            End If
        ElseIf strFirstVariableType = "categorical" Then
            If strSecondVariableType = "categorical" Then
                If iNumberOfFirstFactorLevels = 2 Then
                    If strSecondVariableType = "categorical" AndAlso iNumberOfSecondFactorLevels = 2 Then
                        ucrInputTest.SetItems({"proportion", "chisq", "fisher", "mcnemar"})
                        ucrInputTest.SetText("proportion")
                    Else
                        ucrInputTest.SetItems({"None"})
                        ucrInputTest.SetText("None")
                    End If
                Else
                    ucrInputTest.SetItems({"chisq", "fisher", "________", "mcnemar"})
                    ucrInputTest.SetText("chisq")
                End If
            ElseIf strSecondVariableType = "" Then
                ucrInputTest.SetItems({"None"})
                ucrInputTest.SetText("None")
            End If
        ElseIf strFirstVariableType = "" Then
            ucrInputTest.SetItems({"None"})
            ucrInputTest.SetText("None")
        End If
    End Sub

    Private Sub ucrInputTest_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTest.ControlValueChanged
        SetBaseFunction()
    End Sub
End Class