﻿'Instat-R
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

Imports instat.Translations
Public Class dlgRegressionSimple
    Public bFirstLoad As Boolean = True
    Public clsModel, clsFormulaOperator, clsRGraphicsOperator, clsFunctionOperation, clsPoissonOperation, clsPoissonOperation2, clsRBinomialOperation, clsRBinomialOperation2, clsRBinomialOperation3 As New ROperator
    Public clsRPoisson, clsRggplotFunction, clsRLeverage, clsRWriteLeverage, clsRResiduals, clsRStdResiduals, clsRWriteResiduals, clsRWriteStdResiduals, clsRgeom_point, clsRResidualPlots, clsRModelsFunction, clsRWriteFitted, clsRFittedValues, clsRSummaryFunction, clsRestpvalFunction, clsRanovaFunction, clsRConfint, clsRaovpvalFunction, clsRModelFunction, clsRaovFunction, clsRTTest, clsRFTest, clsRKruskalTest, clsRBinomial, clsRWilcoxTest, clsRConvert, clsRCIFunction, clsRFactor, clsRFactor2, clsRNumeric, clsGLM, clsxFunc, clsRMean, clsRMean2, clsRGroup, clsRGroup2, clsRLmOrGLM, clsTFunc, clsRLength As New RFunction
    Public clsRYVariable, clsRXVariable As String

    Private Sub ucrExplanatory_Load() Handles ucrExplanatory.ControlValueChanged

    End Sub

    Private bReset As Boolean = True


    Public bResetSubDialog As Boolean = False
    Public bResetOptionsSubDialog As Boolean = False
    Private Sub dlgRegressionSimple_Load(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub SetRCodeForControls(bReset)
        ucrResponse.SetRCode(clsFormulaOperator, bReset)
        ucrExplanatory.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorSimpleReg.SetRCode(clsRLmOrGLM, bReset)
        ucrPnlModelType.SetRCode(clsRLmOrGLM, bReset)
        ucrSaveModels.SetRCode(clsRLmOrGLM, bReset)
        ' ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorSimpleReg.GetParameter, 1)
        ' ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorSimpleReg.GetParameter, 1)
        ' ucrSelectorSimpleReg.AddAdditionalCodeParameterPair(clsRTTest, ucrSelectorSimpleReg.GetParameter, 2)
        ' ucrResponse.AddAdditionalCodeParameterPair(clsRConvert, New RParameter("x", 1))
        'ucrNudCI.AddAdditionalCodeParameterPair(clsRPoisson, New RParameter("conf.int"), 1)
        'ucrNudHypothesis.AddAdditionalCodeParameterPair(clsRPoisson, New RParameter("r"), 1)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        cmdModelOptions.Enabled = False

        ucrResponse.Selector = ucrSelectorSimpleReg
        ucrExplanatory.Selector = ucrSelectorSimpleReg
        ucrBase.iHelpTopicID = 366

        ucrResponse.SetParameter(New RParameter("y", 0))
        ucrResponse.SetParameterIsString()
        ucrResponse.bWithQuotes = False

        ucrExplanatory.SetParameter(New RParameter("x", 1))
        ucrExplanatory.SetParameterIsString()
        ucrExplanatory.bWithQuotes = False

        ucrChkConvertToVariate.SetText("Convert to  Variate")

        ucrSaveModels.SetPrefix("reg")
        ucrSaveModels.SetSaveTypeAsModel()
        ucrSaveModels.SetDataFrameSelector(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        ucrSaveModels.SetCheckBoxText("Save Model")
        ucrSaveModels.SetIsComboBox()



        ucrPnlMeansAndVariance.AddRadioButton(rdoCompareMeans)
        ucrPnlMeansAndVariance.AddRadioButton(rdoCompareVariance)

        ucrModelPreview.IsReadOnly = True

        ucrPnlModelType.AddRadioButton(rdoGeneralCase)
        ucrPnlModelType.AddRadioButton(rdoTwoSample)
        ucrPnlModelType.AddFunctionNamesCondition(rdoTwoSample, "t.test")
        ucrPnlModelType.AddFunctionNamesCondition(rdoTwoSample, "lm", False)
        ucrPnlModelType.AddFunctionNamesCondition(rdoGeneralCase, "lm")


        ucrPnlModelType.AddToLinkedControls(ucrModelPreview, {rdoGeneralCase}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrModelPreview.SetLinkedDisplayControl(lblModelPreview)
        ucrModelPreview.SetLinkedDisplayControl(cmdDisplayOptions)
        ucrModelPreview.SetLinkedDisplayControl(cmdModelOptions)


        ucrPnlModelType.AddToLinkedControls(ucrNudCI, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0.95)
        ucrNudCI.SetLinkedDisplayControl(lblConfidenceInterval)
        ucrNudCI.SetLinkedDisplayControl(grpParameters)
        ucrNudCI.DecimalPlaces = 2


        ucrPnlModelType.AddToLinkedControls(ucrNudHypothesis, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=0)
        ucrNudHypothesis.SetLinkedDisplayControl(lblDifferenceInMeans)
        ucrNudHypothesis.SetLinkedDisplayControl(grpParameters)
        ucrNudHypothesis.DecimalPlaces = 2

        ucrPnlModelType.AddToLinkedControls(ucrPnlMeansAndVariance, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=rdoCompareMeans)
        ucrPnlMeansAndVariance.SetLinkedDisplayControl(grpParameters)

        ucrPnlModelType.AddToLinkedControls(ucrChkPairedTest, {rdoTwoSample}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=False)
        ucrChkPairedTest.SetText("Paired Text")
        ucrChkPairedTest.Enabled = False 'for the time being


        ucrSelectorSimpleReg.SetParameter(New RParameter("data", 0))
        ucrSelectorSimpleReg.SetParameterIsrfunction()

        'ucrPnlModelType.AddToLinkedControls(ucrChkFunction, {rdoge}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=True)
        ucrChkFunction.SetText("Function")

        ucrNudCI.SetParameter(New RParameter("conf.level"))
        ucrNudHypothesis.SetParameter(New RParameter("r"))

        ucrPnlMeansAndVariance.AddToLinkedControls(ucrNudHypothesis, {rdoCompareVariance}, bNewLinkedDisabledIfParameterMissing:=True)



        ' sdgSimpleRegOptions.SetRModelFunction(clsRLmOrGLM)
        'sdgSimpleRegOptions.SetRDataFrame(ucrSelectorSimpleReg.ucrAvailableDataFrames)
        'sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        ' sdgSimpleRegOptions.SetRXVariable(ucrExplanatory)
        ' sdgModelOptions.SetRCIFunction(clsRCIFunction)


    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator
        clsPoissonOperation = New ROperator
        clsRGraphicsOperator = New ROperator

        clsRLmOrGLM = New RFunction
        clsGLM = New RFunction
        clsRConvert = New RFunction
        clsRCIFunction = New RFunction
        clsRTTest = New RFunction
        clsRPoisson = New RFunction
        clsxFunc = New RFunction
        clsRLength = New RFunction
        clsRKruskalTest = New RFunction
        clsRFTest = New RFunction
        clsRModelsFunction = New RFunction
        clsRModelFunction = New RFunction
        clsRaovFunction = New RFunction
        clsRaovpvalFunction = New RFunction
        clsRConfint = New RFunction
        clsRestpvalFunction = New RFunction
        clsRFittedValues = New RFunction
        clsRResiduals = New RFunction
        clsRStdResiduals = New RFunction
        clsRWriteResiduals = New RFunction
        clsRWriteLeverage = New RFunction
        clsRLeverage = New RFunction
        clsRWriteStdResiduals = New RFunction
        clsRWriteFitted = New RFunction
        clsRSummaryFunction = New RFunction
        clsRanovaFunction = New RFunction
        clsRResidualPlots = New RFunction
        clsRgeom_point = New RFunction
        clsRggplotFunction = New RFunction
        'clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrSelectorSimpleReg.Reset()
        ucrResponse.SetMeAsReceiver()
        ucrSelectorSimpleReg.Focus()
        ucrModelPreview.Reset()



        DataTypeAccepted()

        clsRGraphicsOperator = clsRegressionDefaults.clsDefaultRGraphicsOperator.Clone
        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsRGraphicsOperator.iCallType = 3

        clsRLmOrGLM = clsRegressionDefaults.clsDefaultRLmOrGLM.Clone
        clsRLmOrGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)

        'Residual Plots
        clsRResidualPlots = clsRegressionDefaults.clsDefaultRResidualPlots.Clone
        clsRResidualPlots.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)

        clsRgeom_point = clsRegressionDefaults.clsDefaultRgeom_pointFunction.Clone


        clsRaovFunction.SetPackageName("stats")
        clsRaovFunction.SetRCommand("anova")
        clsRaovFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRaovFunction.iCallType = 2

        'FitModel
        clsRggplotFunction = clsRegressionDefaults.clsDefaultRggplot.Clone
        clsRggplotFunction.AddParameter("fit", clsRFunctionParameter:=clsRLmOrGLM)
        clsRggplotFunction.iCallType = 3

        'Model
        clsRModelsFunction = clsRegressionDefaults.clsDefaultModel.Clone
        clsRModelsFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRModelsFunction.iCallType = 2

        'Summary
        clsRSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsRSummaryFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRSummaryFunction.iCallType = 2

        'ANOVA
        clsRanovaFunction = clsRegressionDefaults.clsDefaultRanovaFunction.Clone
        clsRanovaFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRanovaFunction.iCallType = 2

        'Confidence Interval
        clsRConfint = clsRegressionDefaults.clsDefaultRConfinterval.Clone
        clsRConfint.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        clsRConfint.iCallType = 2

        'Anova + Pvalue
        clsRestpvalFunction = clsRegressionDefaults.clsDefaultRaovPValueFunction.Clone
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        '  clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        clsRestpvalFunction.iCallType = 2

        'ucrSave (sdgSimpleRegOptions) Fitted Values
        clsRFittedValues.SetPackageName("stats")
        clsRFittedValues.SetRCommand("fitted")
        clsRFittedValues.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        clsRWriteFitted = clsRegressionDefaults.clsDefaultRWriteFitted.Clone
        clsRWriteFitted.AddParameter("col_data", clsRFunctionParameter:=clsRFittedValues)
        clsRWriteFitted.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Residuals
        clsRResiduals.SetPackageName("stats")
        clsRResiduals.SetRCommand("resid")
        clsRResiduals.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        clsRWriteResiduals = clsRegressionDefaults.clsDefaultRWriteResiduals.Clone
        clsRWriteResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRResiduals)
        clsRWriteResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) StdResiduals
        clsRStdResiduals.SetPackageName("stats")
        clsRStdResiduals.SetRCommand("rstandard")
        clsRStdResiduals.AddParameter("model", clsRFunctionParameter:=clsRLmOrGLM)
        clsRWriteStdResiduals = clsRegressionDefaults.clsDefaultRWriteStdResiduals.Clone
        clsRWriteStdResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRStdResiduals)
        clsRWriteStdResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Leverage
        clsRLeverage.SetPackageName("stats")
        clsRLeverage.SetRCommand("hatvalues")
        clsRLeverage.AddParameter("model", clsRFunctionParameter:=clsRLmOrGLM)
        clsRWriteLeverage = clsRegressionDefaults.clsDefaultRWriteLeverage.Clone
        clsRWriteLeverage.AddParameter("col_data", clsRFunctionParameter:=clsRLeverage)
        clsRWriteLeverage.iCallType = 3

        clsRConvert.SetRCommand("as.numeric")

        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)


        clsRTTest.SetPackageName("mosaic")
        clsRTTest.SetRCommand("t.test")

        clsRPoisson.SetPackageName("stats")
        clsRPoisson.SetRCommand("poisson.test")

        clsGLM.SetRCommand("glm")
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator)

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


        ucrBase.clsRsyntax.SetBaseRFunction(clsRLmOrGLM)

        clsRLmOrGLM.SetAssignTo(ucrSaveModels.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        'sdgSimpleRegOptions.SetDefaults()
        'sdgModelOptions.SetDefaults()
        ucrModelPreview.SetName("")
        SetRCode()
        ucrFamily.SetGLMDistributions()
        'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        'sdgSimpleRegOptions.lblDisplayCLevel.Enabled = True
        'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
        rdoCompareMeans.Checked = True
        SetEnableDists()
        TestOKEnabled()
        bResetSubDialog = True
        bResetOptionsSubDialog = True
    End Sub

    Private Sub ucrDistWithParameters_ucrInputDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged
        sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = sdgModelOptions.ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.RestrictLink()
        ExplanatoryFunctionSelect()
        SetRCode()
        DataTypeAccepted()
    End Sub

    Public Sub DataTypeAccepted()
        If rdoTwoSample.Checked Then
            ucrResponse.SetIncludedDataTypes({"integer", "numeric"})
            ucrExplanatory.SetIncludedDataTypes({"character", "factor"})
            If ucrResponse.strCurrDataType = "factor" OrElse ucrResponse.strCurrDataType = "character" Then
                ucrResponse.Clear()
            End If
            If ucrExplanatory.strCurrDataType = "integer" OrElse ucrExplanatory.strCurrDataType = "numeric" OrElse ucrResponse.strCurrDataType = "positive integer" Then
                ucrExplanatory.Clear()
            End If
        ElseIf rdoGeneralCase.Checked Then
            ucrResponse.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
            ucrExplanatory.SetIncludedDataTypes({"integer", "numeric", "character", "factor"})
        End If
    End Sub

    Private Sub ucrChkFunction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFunction.ControlValueChanged
        If ucrChkFunction.Checked Then
            sdgVariableTransformations.SetRCodeForControls(clsNewLMorGLM:=clsRLmOrGLM, clsNewFormulaOperator:=clsFormulaOperator, bReset:=bResetSubDialog, clsRXVariableNew:=clsRXVariable, clsRYVariableNew:=clsRYVariable, clsRModelNew:=clsModel, clsNewFunction:=clsRCIFunction)
            sdgVariableTransformations.ShowDialog()
            ExplanatoryFunctionSelect()
            bResetSubDialog = False
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(ucrBase.clsRsyntax, clsNewRGraphicsOperator:=clsRGraphicsOperator, clsNewRanovaFunction:=clsRanovaFunction, clsNewRSummaryFunction:=clsRSummaryFunction, clsNewRgeom_point:=clsRgeom_point, clsNewRResidualPlots:=clsRResidualPlots, clsNewRggplotFunction:=clsRggplotFunction, clsNewRConfint:=clsRConfint, clsNewRWriteResiduals:=clsRWriteResiduals, clsNewRWriteStdResiduals:=clsRWriteStdResiduals, clsNewRWriteLeverage:=clsRWriteLeverage, clsNewRModelsFunction:=clsRModelsFunction, clsNewRaovpvalFunction:=clsRaovpvalFunction, clsNewRestpvalFunction:=clsRestpvalFunction, clsNewRLmOrGLM:=clsRLmOrGLM, clsNewRXVariable:=clsRXVariable, clsNewRYVariable:=clsRYVariable, clsNewRWriteFitted:=clsRWriteFitted, clsNewRFittedValues:=clsRFittedValues, bReset:=bResetOptionsSubDialog)
        bResetOptionsSubDialog = False
        sdgSimpleRegOptions.ShowDialog()
    End Sub

    Private Sub grpParameters_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub ucrResponse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrResponse.ControlValueChanged
        clsRYVariable = ucrResponse.GetVariableNames(bWithQuotes:=False)
    End Sub


    Private Sub ucrSelectorSimpleReg_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorSimpleReg.ControlValueChanged
        ConvertToVariate()
        TestOKEnabled()
        DataTypeAccepted()
        SetEnableDists()
    End Sub

    Private Sub ucrExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrExplanatory.ControlValueChanged
        clsRXVariable = ucrExplanatory.GetVariableNames(bWithQuotes:=False)
    End Sub


    'Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
    '    sdgModelOptions.ShowDialog()
    '    ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrFamily.clsCurrDistribution.strNameTag)
    'End Sub

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
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
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
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRFTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetWilcoxTest()
        clsRWilcoxTest.SetPackageName("stats")
        clsRWilcoxTest.SetRCommand("wilcox.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRWilcoxTest)
        '  clsRWilcoxTest.AddParameter("conf.level", nudCI.Value.ToString())
        '    clsRWilcoxTest.AddParameter("mu", nudHypothesis.Value.ToString())
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRWilcoxTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub

    Private Sub SetKruskalTest()

        ucrBase.clsRsyntax.SetBaseRFunction(clsRKruskalTest)
        clsModel.SetOperation("~")
        clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
        clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRKruskalTest.AddParameter("", clsROperatorParameter:=clsModel)
    End Sub


    Private Sub SetBinomTest()
        Dim clsyFunc, clsnFunc As New RFunction
        clsRBinomial.SetRCommand("mosaic")
        clsRBinomial.SetRCommand("prop.test")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRBinomial)
        '  clsRBinomial.AddParameter("conf.level", nudCI.Value.ToString())

        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRGroup.ToScript & "]")
        clsRGroup.AddParameter("x", clsROperatorParameter:=clsPoissonOperation)
        clsPoissonOperation.SetOperation("==")
        clsPoissonOperation.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())


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
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRFactor.ToScript & "&" & clsRNumeric.ToScript & "]")

        ' LengthTwo
        ' length(x=ucrResponse[(x=ucrExplanatory == 2)&(x=ucrResponse ==1)]))
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRFactor2.ToScript & "&" & clsRNumeric.ToScript & "]")


        ' Total counts for each level:
        ' c(length(x=ucrResponse[LevelOne]), length(ucrResponse[LevelTwo]))

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRFactor.ToScript & "]")

        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=clsRLength)
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRFactor2.ToScript & "]")


        ' The three groups of interest:
        '' x=ucrExplanatory == Level1
        clsRFactor.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation)
        clsRBinomialOperation.SetOperation("==")
        clsRBinomialOperation.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())
        '    clsRBinomialOperation.AddParameter(strParameterValue:=ucrLevel1.GetText())

        '' x=ucrExplanatory == Level2
        clsRFactor2.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation2)
        clsRBinomialOperation2.SetOperation("==")
        clsRBinomialOperation2.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())
        '  clsRBinomialOperation2.AddParameter(strParameterValue:=ucrLevel2.GetText())

        '' x=ucrResponse == SuccessIf
        clsRNumeric.AddParameter("x", clsROperatorParameter:=clsRBinomialOperation3)
        clsRBinomialOperation3.SetOperation("==")
        clsRBinomialOperation3.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
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
        clsRLength.AddParameter("x", ucrResponse.GetVariables().ToScript & "[" & clsRGroup2.ToScript & "]")
        clsRGroup2.AddParameter("x", clsROperatorParameter:=clsPoissonOperation2)
        clsPoissonOperation2.SetOperation("==")
        clsPoissonOperation2.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrExplanatory.GetVariables())
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
        clsRLength.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        clsRLength.SetRCommand("length")
        clsRLength.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
        clsRMean.SetRCommand("mean")
        clsRMean.AddParameter("x", clsRFunctionParameter:=ucrResponse.GetVariables())
        clsRMean2.SetRCommand("mean")
        clsRMean2.AddParameter("x", clsRFunctionParameter:=ucrExplanatory.GetVariables())
    End Sub

    Private Sub SetRCode()
        'clsRPoisson.ClearParameters()
        'clsRBinomial.ClearParameters()
        'clsRTTest.ClearParameters()
        'clsRLmOrGLM.ClearParameters()
        If rdoGeneralCase.Checked Then
            If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRLmOrGLM)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsGLM)
            End If
        ElseIf rdoTwoSample.Checked Then
            If ucrFamily.clsCurrDistribution.strNameTag = "Normal" Then
                If rdoCompareMeans.Checked Then
                    SetTTest()
                ElseIf rdoCompareVariance.Checked Then
                    SetFTest()
                End If
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Poisson" Then
                SetPoissonTest()
            ElseIf ucrFamily.clsCurrDistribution.strNameTag = "Bernouli" Then
                SetBinomTest()
            Else
                If rdoCompareMeans.Checked Then
                    SetWilcoxTest()
                ElseIf rdoCompareVariance.Checked Then
                    SetKruskalTest()
                End If
            End If
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        '  If Not ucrResponse.IsEmpty() AndAlso Not ucrExplanatory.IsEmpty() AndAlso ucrFamily.Enabled AndAlso Not ucrFamily.ucrInputDistributions.IsEmpty() AndAlso (ucrSaveModels.IsComplete) Then
        'ucrModelPreview.SetName(clsRLmOrGLM.ToScript)
        '            If rdoSpecific.Checked AndAlso (ucrFamily.clsCurrDistribution.strNameTag = "Poisson" OrElse ucrFamily.clsCurrDistribution.strNameTag = "Binomial") AndAlso Not (ucrLevel1.IsEmpty OrElse ucrLevel2.IsEmpty) Then
        'ucrBase.OKEnabled(True)
        '            Else
        '           ucrBase.OKEnabled(False)
        '      End If
        'If rdoGeneralCase.Checked Then
        'ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
        'End If
        'Else
        'ucrBase.OKEnabled(False)
        ' End If
        If Not ucrResponse.IsEmpty() Then
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrSelectorSimpleReg_DataFrameChanged() Handles ucrSelectorSimpleReg.ControlValueChanged
        AssignModelName()
        SetRCode()
    End Sub

    Public Sub ConvertToVariate()
        If rdoGeneralCase.Checked Then
            If Not ucrResponse.IsEmpty Then
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
                If ucrFamily.strDataType = "numeric" Then
                    ucrChkConvertToVariate.Checked = False
                    ucrChkConvertToVariate.Visible = False
                Else
                    ucrChkConvertToVariate.Visible = True
                End If
                sdgModelOptions.ucrFamily.RecieverDatatype(ucrFamily.strDataType)
                If ucrChkConvertToVariate.Checked Then

                    clsRConvert.AddParameter("x", ucrResponse.GetVariableNames(bWithQuotes:=False))
                    clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRConvert)
                    clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
                    ucrFamily.RecieverDatatype("numeric")
                Else
                    clsModel.AddParameter(iPosition:=0, clsRFunctionParameter:=ucrResponse.GetVariables())
                    clsModel.AddParameter(clsRFunctionParameter:=ucrExplanatory.GetVariables())
                    clsModel.AddParameter(iPosition:=0, strParameterValue:=ucrResponse.GetVariableNames(bWithQuotes:=False))
                    ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
                End If
            Else
                If ucrFamily.lstCurrentDistributions.Count = 0 OrElse ucrResponse.IsEmpty() Then
                    ucrFamily.ucrInputDistributions.SetName("")
                    cmdModelOptions.Enabled = False
                Else
                    cmdModelOptions.Enabled = True
                End If
            End If
        Else
            If Not ucrResponse.IsEmpty Then
                ucrFamily.RecieverDatatype(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrResponse.GetVariableNames(bWithQuotes:=False))
            End If
        End If
        TestOKEnabled()
    End Sub

    Public Sub SetEnableDists()
        ucrFamily.Enabled = Not ucrResponse.IsEmpty
    End Sub

    Private Sub ucrExplanatory_SelectionChanged(sender As Object, e As EventArgs) Handles ucrExplanatory.SelectionChanged
        If Not ucrExplanatory.IsEmpty Then
            '            ucrLevel1.SetItems({ucrExplanatory.GetItemType("Levels")})
        End If
    End Sub

    Private Sub ucrchkConvertToVariate_CheckedChanged() Handles ucrChkConvertToVariate.ControlValueChanged
        SetRCode()
        ConvertToVariate()
    End Sub

    Private Sub ExplanatoryFunctionSelect()
        Dim strExplanatoryType As String
        If Not ucrExplanatory.IsEmpty AndAlso rdoGeneralCase.Checked Then
            strExplanatoryType = frmMain.clsRLink.GetDataType(ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            If rdoGeneralCase.Checked AndAlso (strExplanatoryType = "numeric" OrElse strExplanatoryType = "positive integer" OrElse strExplanatoryType = "integer") Then
                ucrChkFunction.Visible = True
            Else
                ucrChkFunction.Checked = False
                ucrChkFunction.Visible = False
            End If
            If ucrChkFunction.Checked Then
                sdgVariableTransformations.ModelFunction(False)
            Else
                sdgVariableTransformations.rdoIdentity.Checked = True
                'clsRLmOrGLM.AddParameter(strParameterValue:=ucrExplanatory.GetVariableNames(bWithQuotes:=False))
            End If
        End If
    End Sub

    Private Sub ucrExplanatory_SelectionChanged() Handles ucrExplanatory.ControlValueChanged
        ' ExplanatoryFunctionSelect()
        SetRCode()
        DataTypeAccepted()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrModelName_NameChanged()
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'If rdoGeneral.Checked Then
        '    sdgSimpleRegOptions.RegOptions()
        'End If
    End Sub

    Private Sub chkModelName_CheckedChanged(sender As Object, e As EventArgs)
        'If chkSaveModel.Checked Then
        '    ucrModelName.Visible = True
        'Else
        '    ucrModelName.Visible = False
        'End If
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub AssignModelName()
        'If chkSaveModel.Checked AndAlso Not ucrModelName.IsEmpty Then
        '    ucrBase.clsRsyntax.SetAssignTo(ucrModelName.GetText, strTempModel:=ucrModelName.GetText, strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '    If rdoGeneral.Checked Then
        '        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        '    Else
        '        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        '    End If
        'Else
        '    ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorSimpleReg.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        '    ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'End If
    End Sub

    Private Sub chkFunction_CheckedChanged() Handles ucrChkFunction.ControlValueChanged
        If ucrChkFunction.Checked Then
            ExplanatoryFunctionSelect()
        End If
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

    Private Sub chkboxes_VisibleChanged(sender As Object, e As EventArgs)
        ' ExplanatoryFunctionSelect()
        ConvertToVariate()
        TestOKEnabled()
    End Sub

    Private Sub rdoTop_CheckedChanged(sender As Object, e As EventArgs)
        If rdoGeneralCase.Checked Then
            ucrFamily.SetGLMDistributions()
        Else
            ucrFamily.SetExactDistributions()
        End If
        ucrFamily.ucrInputDistributions.SetName("")
        SetRCode()
        TestOKEnabled()
        DataTypeAccepted()
        AssignModelName()
        ConvertToVariate()
    End Sub

    Private Sub ucrFamily_EnabledChanged(sender As Object, e As EventArgs) Handles ucrFamily.EnabledChanged
        DataTypeAccepted()
        TestOKEnabled()
        SetEnableDists()
    End Sub

    Private Sub ucrResponse_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrResponse.ControlValueChanged
        TestOKEnabled()
    End Sub
End Class