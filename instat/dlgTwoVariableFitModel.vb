'Instat-R
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

Public Class dlgTwoVariableFitModel
    Public bFirstLoad As Boolean = True
    Public clsModel, clsRGraphicsOperator, clsFunctionOperation, clsPoissonOperation, clsPoissonOperation2, clsRBinomialOperation, clsRBinomialOperation2, clsRBinomialOperation3 As New ROperator
    Public clsRPoisson, clsVisReg, clsRLeverage, clsRWriteLeverage, clsRResiduals, clsRStdResiduals, clsRWriteResiduals, clsRWriteStdResiduals, clsRgeom_point, clsAutoPlot, clsRWriteFitted, clsRFittedValues, clsRestpvalFunction, clsRaovpvalFunction, clsRModelFunction, clsRaovFunction, clsRTTest, clsRFTest, clsRKruskalTest, clsRBinomial, clsRWilcoxTest, clsFamilyFunction, clsRFactor, clsRFactor2, clsRNumeric, clsxFunc, clsRMean, clsRMean2, clsRGroup, clsRGroup2, clsTFunc, clsRLength As New RFunction
    Private clsTransformFunction As RFunction

    'General case codes
    Public clsFormulaOperator, clsPowerOperator As ROperator
    Public clsGLM, clsLM, clsLMOrGLM, clsAsNumeric As RFunction

    'Display options codes
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction

    Private bRCodeSet As Boolean

    Public clsRYVariable, clsRXVariable, ModelPreview As String
    Private bReset As Boolean = True
    Public bResetSubDialog As Boolean = False
    Public bResetOptionsSubDialog As Boolean = False
    Public bResetFirstFunction As Boolean = False

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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'temp disabled until implemented
        rdoTwoSample.Enabled = False

        ucrBase.iHelpTopicID = 366
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrModelPreview.IsReadOnly = True

        ucrPnlModelType.AddRadioButton(rdoGeneralCase)
        ucrPnlModelType.AddRadioButton(rdoTwoSample)
        ucrPnlModelType.AddFunctionNamesCondition(rdoTwoSample, "t.test")
        ucrPnlModelType.AddFunctionNamesCondition(rdoGeneralCase, "t.test", False)
        ucrPnlModelType.AddToLinkedControls(ucrModelPreview, {rdoGeneralCase}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlModelType.AddToLinkedControls(ucrNudCI, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0.95)
        ucrPnlModelType.AddToLinkedControls(ucrNudHypothesis, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0)
        ucrPnlModelType.AddToLinkedControls(ucrPnlMeansAndVariance, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=rdoCompareMeans)
        ucrPnlModelType.AddToLinkedControls(ucrChkPairedTest, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=False)

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

        'ucrPnlMeansAndVariance.AddRadioButton(rdoCompareMeans)
        'ucrPnlMeansAndVariance.AddRadioButton(rdoCompareVariance)

        '###################################

        ' Two sample controls

        ucrNudCI.SetParameter(New RParameter("conf.level"))
        ucrNudCI.SetLinkedDisplayControl(lblConfidenceInterval)
        ucrNudCI.SetLinkedDisplayControl(grpParameters)
        ucrNudCI.DecimalPlaces = 2


        ucrNudHypothesis.SetLinkedDisplayControl(lblDifferenceInMeans)
        ucrNudHypothesis.SetLinkedDisplayControl(grpParameters)
        ucrNudHypothesis.DecimalPlaces = 2


        ucrChkPairedTest.SetText("Paired Text")
        ucrChkPairedTest.Enabled = False 'for the time being

        ucrNudHypothesis.SetParameter(New RParameter("r"))

        ucrPnlMeansAndVariance.SetLinkedDisplayControl(grpParameters)
        ucrPnlMeansAndVariance.AddToLinkedControls(ucrNudHypothesis, {rdoCompareVariance}, bNewLinkedDisabledIfParameterMissing:=True)

    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator
        clsPoissonOperation = New ROperator
        clsRGraphicsOperator = New ROperator
        clsPowerOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()
        clsLM = New RFunction
        clsGLM = New RFunction
        clsAsNumeric = New RFunction
        clsFamilyFunction = New RFunction
        clsRTTest = New RFunction
        clsRPoisson = New RFunction
        clsxFunc = New RFunction
        clsRLength = New RFunction
        clsRKruskalTest = New RFunction
        clsRFTest = New RFunction
        clsFormulaFunction = New RFunction
        clsRModelFunction = New RFunction
        clsRaovFunction = New RFunction
        clsRaovpvalFunction = New RFunction
        clsConfint = New RFunction
        clsRestpvalFunction = New RFunction
        clsRFittedValues = New RFunction
        clsRResiduals = New RFunction
        clsRStdResiduals = New RFunction
        clsRWriteResiduals = New RFunction
        clsRWriteLeverage = New RFunction
        clsRLeverage = New RFunction
        clsRWriteStdResiduals = New RFunction
        clsRWriteFitted = New RFunction
        clsSummaryFunction = New RFunction
        clsAnovaFunction = New RFunction
        clsAutoPlot = New RFunction
        clsRgeom_point = New RFunction
        clsVisReg = New RFunction
        clsTransformFunction = New RFunction

        ucrSelectorSimpleReg.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrModelPreview.SetName("")

        clsRGraphicsOperator = clsRegressionDefaults.clsDefaultRGraphicsOperator.Clone
        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsRGraphicsOperator.iCallType = 3

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)

        clsPowerOperator.SetOperation("^")
        clsPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsPowerOperator.bBrackets = False

        'Residual Plots
        clsAutoPlot = clsRegressionDefaults.clsDefaultAutoplot.Clone

        clsRgeom_point = clsRegressionDefaults.clsDefaultRgeom_pointFunction.Clone
        clsRGraphicsOperator.AddParameter("geom_point", clsRFunctionParameter:=clsRgeom_point, iPosition:=1)


        clsRaovFunction.SetPackageName("stats")
        clsRaovFunction.SetRCommand("anova")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=clsLMOrGLM)
        clsRaovFunction.iCallType = 2

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.iCallType = 3

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

        'Anova + Pvalue
        clsRestpvalFunction = clsRegressionDefaults.clsDefaultRaovPValueFunction.Clone
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=clsLMOrGLM)
        '  clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRestpvalFunction.iCallType = 2

        'ucrSave (sdgSimpleRegOptions) Fitted Values
        clsRWriteFitted = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        clsRWriteFitted.SetAssignTo(sdgSimpleRegOptions.ucrSaveFittedColumnName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveFittedColumnName.GetText, bAssignToIsPrefix:=True)
        ' clsRWriteFitted.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Residuals
        clsRWriteResiduals = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        clsRWriteResiduals.SetAssignTo(sdgSimpleRegOptions.ucrSaveResidualsColumnName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveResidualsColumnName.GetText, bAssignToIsPrefix:=True)
        ' clsRWriteResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) StdResiduals
        clsRWriteStdResiduals = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        clsRWriteStdResiduals.SetAssignTo(sdgSimpleRegOptions.ucrSaveStdResidualsColumnName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveStdResidualsColumnName.GetText, bAssignToIsPrefix:=True)
        ' clsRWriteStdResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Leverage
        clsRWriteLeverage = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        clsRWriteLeverage.SetAssignTo(sdgSimpleRegOptions.ucrSaveLeverageColumnName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveLeverageColumnName.GetText, bAssignToIsPrefix:=True)
        'clsRWriteLeverage.iCallType = 3

        clsAsNumeric.SetRCommand("as.numeric")

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        'clsFamilyFunction.SetRCommand(ucrDistributionChoice.clsCurrDistribution.strGLMFunctionName)
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)


        clsRTTest.SetPackageName("mosaic")
        clsRTTest.SetRCommand("t.test")

        clsRPoisson.SetPackageName("stats")
        clsRPoisson.SetRCommand("poisson.test")

        clsRFTest.SetPackageName("stats")
        clsRFTest.SetRCommand("var.test")

        clsxFunc.SetRCommand("c")
        clsxFunc.AddParameter("l1", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)
        clsxFunc.AddParameter("l2", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)
        clsRPoisson.AddParameter("x", clsRFunctionParameter:=clsxFunc)

        clsRLength.SetRCommand("length")

        clsRKruskalTest.SetPackageName("stats")
        clsRKruskalTest.SetRCommand("kruskal.test")

        clsTFunc.SetRCommand("c")

        clsLM.SetAssignTo(ucrSaveModels.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)
        clsGLM.SetAssignTo(ucrSaveModels.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)
        clsLMOrGLM = clsLM

        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        bResetSubDialog = True
        bResetOptionsSubDialog = True
        bResetFirstFunction = True
    End Sub

    Private Sub SetRCodeForControls(bReset)
        bRCodeSet = False

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

        '###################################################

        'Two sample controls
        ' ucrResponse.AddAdditionalCodeParameterPair(clsGLM, ucrResponse.GetParameter, iAdditionalPairNo:=1)
        ' ucrExplanatory.AddAdditionalCodeParameterPair(clsGLM, ucrExplanatory.GetParameter, iAdditionalPairNo:=1)
        'ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, New RParameter("data"), iAdditionalPairNo:=1)
        ' ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorSimpleReg.GetParameter, 1)
        ' ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsRTTest, ucrSelectorSimpleReg.GetParameter, 2)
        ' ucrResponse.AddAdditionalCodeParameterPair(clsRConvert, New RParameter("x", 1))
        'ucrNudCI.AddAdditionalCodeParameterPair(clsRPoisson, New RParameter("conf.int"), 1)
        'ucrNudHypothesis.AddAdditionalCodeParameterPair(clsRPoisson, New RParameter("r"), 1)
        bRCodeSet = True
        SetEnableDists()
        ConvertToVariate()
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverExplanatory.IsEmpty Then
            ucrModelPreview.SetName(clsFormulaOperator.ToScript())
        Else
            ucrModelPreview.SetName("")
        End If
    End Sub

    Private Sub ucrDistWithParameters_ucrInputDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        'sdgModelOptions.ucrFamily.RecieverDatatype(ucrDistributionChoice.strDataType)
        'sdgModelOptions.ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrDistributionChoice.clsCurrDistribution.strNameTag)
        'sdgModelOptions.RestrictLink()
        SetBaseFunction()
        DataTypeAccepted()
    End Sub

    Public Sub DataTypeAccepted()
        If rdoTwoSample.Checked Then
            ucrReceiverResponse.SetIncludedDataTypes({"integer", "numeric"})
            ucrReceiverExplanatory.SetIncludedDataTypes({"character", "factor"})
            If ucrReceiverResponse.strCurrDataType = "factor" OrElse ucrReceiverResponse.strCurrDataType = "character" Then
                ucrReceiverResponse.Clear()
            End If
            If ucrReceiverExplanatory.strCurrDataType = "integer" OrElse ucrReceiverExplanatory.strCurrDataType = "numeric" OrElse ucrReceiverResponse.strCurrDataType = "positive integer" Then
                ucrReceiverExplanatory.Clear()
            End If
        ElseIf rdoGeneralCase.Checked Then
            ucrReceiverResponse.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
            ucrReceiverExplanatory.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, clsNewAutoplot:=clsAutoPlot, bReset:=bResetOptionsSubDialog)
        sdgSimpleRegOptions.ShowDialog()
        bResetOptionsSubDialog = False
    End Sub

    Private Sub ucrResponse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlValueChanged
        UpdatePreview()
        ConvertToVariate()
        clsRYVariable = ucrReceiverResponse.GetVariableNames(bWithQuotes:=False)
        SetEnableDists()
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub cmdExplanatoryFunction_Click(sender As Object, e As EventArgs) Handles cmdExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsFormulaOperator, clsNewTransformParameter:=clsFormulaOperator.GetParameter("exp1"), clsNewTransformFunction:=clsTransformFunction, clsNewPowerOperator:=clsPowerOperator, strVariableName:=ucrReceiverExplanatory.GetVariableNames(False), bReset:=bResetFirstFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFirstFunction = False
        UpdatePreview()
    End Sub

    Private Sub SetTTest()

        ucrBase.clsRsyntax.SetBaseRFunction(clsRTTest)
        ' clsRTTest.AddParameter("conf.level", nudCI.Value.ToString())
        clsRTTest.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        '  clsRTTest.AddParameter("mu", nudHypothesis.Value.ToString())
        '        If ucrExplanatory.strCurrDataType = "numeric" OrElse ucrExplanatory.strCurrDataType = "integer" Then
        '        clsRTTest.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        '        clsRTTest.AddParameter("y", clsRFunctionParameter:=ucrExplanatory.GetVariables())
        '        Else
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        clsRTTest.AddParameter("x", clsROperatorParameter:=clsModel)
        '        End If
        If ucrChkPairedTest.Checked Then
            clsRTTest.AddParameter("paired", "TRUE")
        Else
            clsRTTest.RemoveParameterByName("paired")
        End If
    End Sub

    Private Sub SetFTest()

        ucrBase.clsRsyntax.SetBaseRFunction(clsRFTest)
        '   clsRFTest.AddParameter("conf.level", nudCI.Value.ToString())
        clsRFTest.AddParameter("data", clsRFunctionParameter:=ucrSelectorSimpleReg.ucrAvailableDataFrames.clsCurrDataFrame)
        ' clsRFTest.AddParameter("mu", nudHypothesis.Value.ToString())
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        clsRFTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetWilcoxTest()
        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
        '  clsRWilcoxTest.AddParameter("conf.level", nudCI.Value.ToString())
        '    clsRWilcoxTest.AddParameter("mu", nudHypothesis.Value.ToString())
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        clsRWilcoxTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetKruskalTest()

        ucrBase.clsRsyntax.SetBaseRFunction(clsRKruskalTest)
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        clsRKruskalTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetBinomTest()
        Dim clsyFunc, clsnFunc As New RFunction
        clsRBinomial.SetRCommand("mosaic")
        clsRBinomial.SetRCommand("prop.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRBinomial)
        '  clsRBinomial.AddParameter("conf.level", nudCI.Value.ToString())

        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRGroup.ToScript & "]")
        clsRGroup.AddParameter("x", clsROperatorParameter:=clsPoissonOperation)
        clsPoissonOperation.SetOperation("==")
        clsPoissonOperation.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())


        clsRBinomial.AddParameter("data", ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsRBinomial.AddParameter("x", clsRFunctionParameter:=clsyFunc)
        clsRBinomial.AddParameter("n", clsRFunctionParameter:=clsnFunc)

        ' y = ...
        clsyFunc.SetRCommand("c")
        clsyFunc.AddParameter("l1", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)
        clsyFunc.AddParameter("l2", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)

        ' n = ...
        clsnFunc.SetRCommand("c")
        clsnFunc.AddParameter("l3", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)
        clsnFunc.AddParameter("l4", clsRFunctionParameter:=clsRLength, bIncludeArgumentName:=False)


        ' Success if LABEL = ...
        'c(length(x=ucrResponse[LevelOne]&SuccessIf]), length(x=ucrResponse[LevelTwo&SuccessIf]))
        '  LengthOne
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRFactor.ToScript & "&" & clsRNumeric.ToScript & "]")

        ' LengthTwo
        ' length(x=ucrResponse[(x=ucrExplanatory == 2)&(x=ucrResponse ==1)]))
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRFactor2.ToScript & "&" & clsRNumeric.ToScript & "]")


        ' Total counts for each level:
        ' c(length(x=ucrResponse[LevelOne]), length(ucrResponse[LevelTwo]))

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRFactor.ToScript & "]")

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRFactor2.ToScript & "]")


        ' The three groups of interest:
        '' x=ucrExplanatory == Level1
        clsRFactor.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation)
        clsRBinomialOperation.SetOperation("==")
        clsRBinomialOperation.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        '    clsRBinomialOperation.AddParameter(strParameterValue:=ucrLevel1.GetText())

        '' x=ucrExplanatory == Level2
        clsRFactor2.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation2)
        clsRBinomialOperation2.SetOperation("==")
        clsRBinomialOperation2.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        '  clsRBinomialOperation2.AddParameter(strParameterValue:=ucrLevel2.GetText())

        '' x=ucrResponse == SuccessIf
        clsRNumeric.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation3)
        clsRBinomialOperation3.SetOperation("==")
        clsRBinomialOperation3.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        ' clsRBinomialOperation3.AddParameter(strParameterValue:=ucrNud.Value)

        ' If two factors:
        ' clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        'clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        'clsRBinomial.AddParameter("x", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetPoissonTest()
        ' poisson.test(x = c(length(x=Calls[Group == 1]), length(x=Calls[Group == 2])), T =c(mean(Calls[Group == 1]), mean(Calls[Group == 2])))

        ' clsPoissonOperation.AddParameter(strParameterValue:=ucrLevel1.GetText())

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrReceiverResponse.GetVariables().ToScript & "[" & clsRGroup2.ToScript & "]")
        clsRGroup2.AddParameter("x", clsROperatorParameter:=clsPoissonOperation2)
        clsPoissonOperation2.SetOperation("==")
        clsPoissonOperation2.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        '  clsPoissonOperation2.AddParameter(strParameterValue:=ucrLevel2.GetText())

        ' T = ...
        ' T =c(mean(Calls[Group == 1]), mean(Calls[Group == 2])))

        clsTFunc.AddParameter("m1", clsRFunctionParameter:=clsRMean, bIncludeArgumentName:=False)
        clsTFunc.AddParameter("m2", clsRFunctionParameter:=clsRMean2, bIncludeArgumentName:=False)
        clsRPoisson.AddParameter("T", clsRFunctionParameter:=clsTFunc)



        clsRMean2.SetRCommand("mean")
        clsRMean2.AddParameter("x", clsRFunctionParameter:=clsRGroup)

        ' Note this is currently not running adding the dataset but everything else is.

        ' For two numeric variables:
        clsRPoisson.SetRCommand("poisson.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRPoisson)
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
        clsRMean.SetRCommand("mean")
        clsRMean.AddParameter("x", clsRFunctionParameter:=ucrReceiverResponse.GetVariables())
        clsRMean2.SetRCommand("mean")
        clsRMean2.AddParameter("x", clsRFunctionParameter:=ucrReceiverExplanatory.GetVariables())
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
            clsAutoPlot.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM)
        ElseIf rdoTwoSample.Checked Then
            If ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" Then
                If rdoCompareMeans.Checked Then
                    SetTTest()
                ElseIf rdoCompareVariance.Checked Then
                    SetFTest()
                End If
            ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "Bernouli" Then
                SetBinomTest()
            Else
                If rdoCompareMeans.Checked Then
                    SetWilcoxTest()
                ElseIf rdoCompareVariance.Checked Then
                    SetKruskalTest()
                End If
            End If
        End If
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
        'If Not ucrReceiverResponse.IsEmpty() AndAlso Not ucrReceiverExplanatory.IsEmpty() AndAlso (ucrSaveModels.IsComplete) Then
        '    'If rdoSpecific.Checked AndAlso (ucrFamily.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Binomial") AndAlso Not (ucrLevel1.IsEmpty OrElse ucrLevel2.IsEmpty) Then
        '    '    ucrBase.OKEnabled(True)
        '    'Else
        '    '    ucrBase.OKEnabled(False)
        '    'End If
        '    'If rdoGeneralCase.Checked Then
        '    '    ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
        '    'End If
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        ''If Not ucrResponse.IsEmpty() Then
        ''    ucrBase.OKEnabled(True)
        ''End If
    End Sub

    Private Sub ucrSelectorSimpleReg_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorSimpleReg.ControlValueChanged
        SetBaseFunction()
    End Sub

    Public Sub ConvertToVariate()
        If bRCodeSet Then
            If rdoGeneralCase.Checked Then
                If Not ucrReceiverResponse.IsEmpty Then
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                    If ucrDistributionChoice.strDataType = "numeric" Then
                        ucrChkConvertToVariate.Checked = False
                        ucrChkConvertToVariate.Visible = False
                    Else
                        ucrChkConvertToVariate.Visible = True
                    End If
                    'sdgModelOptions.ucrFamily.RecieverDatatype(ucrDistributionChoice.strDataType)
                    If ucrChkConvertToVariate.Checked Then
                        clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                        ucrDistributionChoice.RecieverDatatype("numeric")
                    Else
                        clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                        'clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
                        ' clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
                        'clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                        ucrDistributionChoice.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                    End If
                Else
                    ucrChkConvertToVariate.Visible = False
                    If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverResponse.IsEmpty() Then
                        ucrDistributionChoice.ucrInputDistributions.SetName("")
                        ucrDistributionChoice.Enabled = False
                        cmdModelOptions.Enabled = False
                    Else
                        cmdModelOptions.Enabled = True
                        ucrDistributionChoice.Enabled = True
                    End If
                End If
            Else
                If Not ucrReceiverResponse.IsEmpty Then
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                End If
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub

    Private Sub ucrExplanatory_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExplanatory.SelectionChanged
        If Not ucrReceiverExplanatory.IsEmpty Then
            'ucrLevel1.SetItems({ucrExplanatory.GetItemType("Levels")})
        End If
    End Sub

    Private Sub ucrChkConvertToVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertToVariate.ControlValueChanged
        SetBaseFunction()
        ConvertToVariate()
    End Sub

        Private Sub ucrExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverExplanatory.IsEmpty Then
                clsFormulaOperator.AddParameter("exp1", ucrReceiverExplanatory.GetVariableNames(False), iPosition:=1)
            Else
                clsFormulaOperator.RemoveParameterByName("exp1")
            End If
        End If
        FirstExplanatoryFunctionEnabled()
        UpdatePreview()
        SetBaseFunction()
        DataTypeAccepted()
        clsRXVariable = ucrReceiverExplanatory.GetVariableNames(bWithQuotes:=False)
    End Sub

    Private Sub FirstExplanatoryFunctionEnabled()
        If Not ucrReceiverExplanatory.IsEmpty AndAlso {"numeric", "integer"}.Contains(ucrReceiverExplanatory.strCurrDataType) Then
            cmdExplanatoryFunction.Enabled = True
        Else
            cmdExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Display()
        'If rdoGeneral.Checked Then
        '    lblFactor.Visible = False
        '    lblNumeric.Visible = False
        '    ucrModelPreview.Visible = True
        '    lblModelPreview.Visible = True
        '    lblResponse.Visible = True
        '    lblExplanatory.Visible = True
        '    cmdDisplayOptions.Visible = True
        '    cmdModelOptions.Visible = True
        '    grpParameters.Visible = False
        'ElseIf rdoSpecific.Checked Then
        '    ucrModelPreview.Visible = False
        '    lblModelPreview.Visible = False
        '    lblResponse.Visible = False
        '    lblExplanatory.Visible = False
        '    cmdDisplayOptions.Visible = False
        '    cmdModelOptions.Visible = False
        '    lblFactor.Visible = True
        '    lblNumeric.Visible = True
        '    chkConvertToVariate.Visible = False
        '    chkFunction.Visible = False
        '    grpParameters.Visible = True
        '    If ucrFamily.clsCurrDistribution.bIsExact = True Then
        '        lblHyp1.Text = ucrFamily.clsCurrDistribution.lstExact(1)
        '        nudHypothesis.Value = ucrFamily.clsCurrDistribution.lstExact(2)
        '        nudHypothesis.Increment = ucrFamily.clsCurrDistribution.lstExact(3)
        '        nudHypothesis.DecimalPlaces = ucrFamily.clsCurrDistribution.lstExact(4)
        '        nudHypothesis.Minimum = ucrFamily.clsCurrDistribution.lstExact(5)
        '        nudHypothesis.Maximum = ucrFamily.clsCurrDistribution.lstExact(6)
        '        If ucrFamily.clsCurrDistribution.strNameTag = "Normal" OrElse ucrFamily.clsCurrDistribution.strNameTag = "No_Distribution" Then
        '            rdoCompareMeans.Visible = True
        '            rdoCompareVar.Visible = True
        '            lblConfidenceInterval.Visible = False
        '            lblDifferenceInMeans.Visible = False
        '            ucrLevel1.Visible = False
        '            ucrLevel2.Visible = False
        '            If rdoCompareMeans.Checked Then
        '                chkPaired.Visible = True
        '                nudHypothesis.Enabled = True
        '                nudCI.Enabled = True
        '            ElseIf rdoCompareVar.Checked Then
        '                chkPaired.Visible = False
        '                nudHypothesis.Enabled = False
        '                nudCI.Enabled = True ' poss want this false for No_Dist here
        '            End If
        '        Else
        '            chkPaired.Visible = False
        '            rdoCompareMeans.Visible = False
        '            rdoCompareVar.Visible = False
        '            nudHypothesis.Enabled = True
        '            nudCI.Enabled = True
        '            lblConfidenceInterval.Visible = True
        '            lblDifferenceInMeans.Visible = True
        '            ucrLevel1.Visible = True
        '            ucrLevel2.Visible = True
        '        End If
        '        If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
        '            rdoCompareMeans.Text = "Compare Means"
        '            rdoCompareVar.Text = "Compare Variances"
        '        End If
        '        If ucrFamily.clsCurrDistribution.strNameTag = "No_Distribution" Then
        '            rdoCompareMeans.Text = "Wilcoxon Test"
        '            rdoCompareVar.Text = "Kruskal Test"
        '        End If
        '        If ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
        '            lblSuccessIf.Visible = True
        '            ucrNud.Visible = True
        '        Else
        '            lblSuccessIf.Visible = False
        '            ucrNud.Visible = False
        '        End If
        'End If
        '  End If
    End Sub

    Public Sub SetEnableDists()
        ucrDistributionChoice.Enabled = Not ucrReceiverResponse.IsEmpty
    End Sub

    Private Sub ucrFamily_EnabledChanged() Handles ucrDistributionChoice.EnabledChanged
        DataTypeAccepted()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlContentsChanged, ucrPnlModelType.ControlContentsChanged, ucrReceiverExplanatory.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlModelType.ControlValueChanged
        If rdoGeneralCase.Checked Then
            ucrDistributionChoice.SetGLMDistributions()
        Else
            ucrDistributionChoice.SetExactDistributions()
        End If
        SetBaseFunction()
        ConvertToVariate()
        DataTypeAccepted()
    End Sub
End Class