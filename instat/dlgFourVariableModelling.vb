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
Public Class dlgFourVariableModelling
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public bRCodeSet As Boolean = False
    Public bResetModelOptions As Boolean = False
    Public bResetDisplayOptions As Boolean = False
    Public bResetFirstFunction As Boolean = False
    Public bResetSecondFunction As Boolean = False
    Public bResetThirdFunction As Boolean = False
    Public clsRCIFunction, clsRConvert, clsFamilyFunction, clsVisReg, clsAutoPlot As New RFunction
    Public clsRSingleModelFunction, clsRNumeric, clsGLM, clsLM, clsFormulaFunction, clsSummaryFunction, clsConfint As RFunction
    Public clsFormulaOperator As ROperator
    Private clsFirstPowerOperator, clsSecondPowerOperator, clsThirdPowerOperator As ROperator
    Public clsSecoandndThirdExplanatoryOpertor, clsOverallExplanatoryOperator As New ROperator
    Private clsAnovaFunction, clsLMOrGLM, clsLmer, clsGlmer As RFunction
    Private clsFirstTransformFunction, clsSecondTransformFunction, clsThirdTransformFunction As RFunction

    Private Sub dlgFourVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBaseFourVariableModelling.iHelpTopicID = 385
        ucrBaseFourVariableModelling.clsRsyntax.iCallType = 2
        ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorFourVariableModelling.SetParameter(New RParameter("data", 0))
        ucrSelectorFourVariableModelling.SetParameterIsrfunction()

        ucrReceiverResponse.SetParameter(New RParameter("x", 1))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.Selector = ucrSelectorFourVariableModelling

        ucrReceiverFirstExplanatory.SetParameter(New RParameter("x", 2))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.bWithQuotes = False
        ucrReceiverFirstExplanatory.Selector = ucrSelectorFourVariableModelling

        ucrReceiverSecondExplanatory.SetParameter(New RParameter("x", 3))
        ucrReceiverSecondExplanatory.SetParameterIsString()
        ucrReceiverSecondExplanatory.bWithQuotes = False
        ucrReceiverSecondExplanatory.Selector = ucrSelectorFourVariableModelling

        ucrReceiverThirdExplanatory.SetParameter(New RParameter("x", 4))
        ucrReceiverThirdExplanatory.SetParameterIsString()
        ucrReceiverThirdExplanatory.bWithQuotes = False
        ucrReceiverThirdExplanatory.Selector = ucrSelectorFourVariableModelling

        ucrChkConvertToNumeric.SetText("Convert to Variate")
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(False, "y", False)

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrSaveModel.SetPrefix("reg")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorFourVariableModelling.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrInputModelOperators1.SetItems({"+", "*", ":", "/", "|"})
        ucrInputModelOperators1.SetDropDownStyleAsNonEditable()

        ucrInputModelOperators2.SetItems({"+", "*", ":", "/", "|"})
        ucrInputModelOperators2.SetDropDownStyleAsNonEditable()

        '  sdgSimpleRegOptions.SetRModelFunction(ucrBaseFourVariableModelling.clsRsyntax.clsBaseFunction)
        ucrModelPreview.IsReadOnly = True
        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorFourVariableModelling.ucrAvailableDataFrames)
        'sdgSimpleRegOptions.SetRYVariable(ucrResponse)
        ' sdgSimpleRegOptions.SetRXVariable(ucrFirstExplanatory)
        'sdgVariableTransformations.SetRYVariable(ucrResponse)
        'sdgVariableTransformations.SetRModelOperator(clsModel1)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        'AssignModelName()
    End Sub

    Private Sub SetDefaults()
        clsFamilyFunction = New RFunction
        clsRNumeric = New RFunction
        clsLM = New RFunction
        clsGLM = New RFunction
        clsFormulaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction
        clsAutoPlot = New RFunction
        clsFirstTransformFunction = New RFunction
        clsSecondTransformFunction = New RFunction
        clsThirdTransformFunction = New RFunction
        clsLmer = New RFunction
        clsLMOrGLM = New RFunction
        clsGlmer = New RFunction

        clsFirstPowerOperator = New ROperator
        clsSecondPowerOperator = New ROperator
        clsThirdPowerOperator = New ROperator
        clsFormulaOperator = New ROperator
        clsSecoandndThirdExplanatoryOpertor = New ROperator
        clsOverallExplanatoryOperator = New ROperator

        ucrSelectorFourVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrBaseFourVariableModelling.clsRsyntax.ClearCodes()

        clsSecoandndThirdExplanatoryOpertor.SetOperation("*")
        clsSecoandndThirdExplanatoryOpertor.bBrackets = False

        ucrDistributionChoice.SetDataType("numeric")
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsRNumeric.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsFormulaOperator.AddParameter("operator", clsROperatorParameter:=clsOverallExplanatoryOperator, iPosition:=1)
        clsFormulaOperator.bBrackets = True

        clsOverallExplanatoryOperator.SetOperation("+")
        clsOverallExplanatoryOperator.AddParameter("operator2&3", clsROperatorParameter:=clsSecoandndThirdExplanatoryOpertor, iPosition:=1)
        clsOverallExplanatoryOperator.bBrackets = False

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)

        clsLmer.SetPackageName("lme4")
        clsLmer.SetRCommand("lmer")
        clsLmer.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)

        clsGlmer.SetPackageName("lme4")
        clsGlmer.SetRCommand("glmer")
        clsGlmer.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGlmer.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)


        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsGLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        'Residual Plots
        clsAutoPlot = clsRegressionDefaults.clsDefaultAutoplot.Clone

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

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.iCallType = 3

        clsFirstPowerOperator.SetOperation("^")
        clsFirstPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsFirstPowerOperator.bBrackets = False

        clsSecondPowerOperator.SetOperation("^")
        clsSecondPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsSecondPowerOperator.bBrackets = False

        clsThirdPowerOperator.SetOperation("^")
        clsThirdPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsThirdPowerOperator.bBrackets = False

        clsLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        clsGLM.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        clsLmer.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)
        clsGlmer.SetAssignTo(ucrSaveModel.GetText, strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:=ucrSaveModel.GetText, bAssignToIsPrefix:=True)

        ucrBaseFourVariableModelling.clsRsyntax.SetBaseRFunction(clsLmer)

        ucrBaseFourVariableModelling.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBaseFourVariableModelling.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)
        ucrBaseFourVariableModelling.clsRsyntax.AddToAfterCodes(clsAutoPlot, 5)
        clsLMOrGLM = clsLmer

        bResetModelOptions = True
        bResetDisplayOptions = True
        bResetFirstFunction = True
        bResetSecondFunction = True
        bResetThirdFunction = True
        ' sdgSimpleRegOptions.SetDefaults()
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        bRCodeSet = False

        ucrSaveModel.AddAdditionalRCode(clsGLM, 1)
        ucrSaveModel.AddAdditionalRCode(clsGlmer, 2)
        ucrSaveModel.AddAdditionalRCode(clsLmer, 3)

        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsGLM, ucrSelectorFourVariableModelling.GetParameter(), 1)
        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsGlmer, ucrSelectorFourVariableModelling.GetParameter(), 2)
        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsLmer, ucrSelectorFourVariableModelling.GetParameter(), 3)

        ucrInputModelOperators1.SetName(clsOverallExplanatoryOperator.strOperation)
        ucrInputModelOperators2.SetName(clsSecoandndThirdExplanatoryOpertor.strOperation)

        ucrChkConvertToNumeric.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorFourVariableModelling.SetRCode(clsLM, bReset)
        ucrSaveModel.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverResponse.SetRCode(clsRNumeric, bReset)
        ucrReceiverFirstExplanatory.SetRCode(clsFirstTransformFunction, bReset)
        ucrReceiverSecondExplanatory.SetRCode(clsSecondTransformFunction, bReset)
        ucrReceiverThirdExplanatory.SetRCode(clsThirdTransformFunction, bReset)

        bRCodeSet = True
        FirstExplanatoryFunctionEnabled()
        SecondExplanatoryFunctionEnabled()
        ThirdExplanatoryFunctionEnabled()
        TestOKEnabled()

    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrReceiverResponse.IsEmpty()) AndAlso (Not ucrReceiverFirstExplanatory.IsEmpty()) AndAlso (Not ucrReceiverSecondExplanatory.IsEmpty()) AndAlso (Not ucrReceiverThirdExplanatory.IsEmpty()) AndAlso (ucrInputModelOperators1.GetText <> "") AndAlso (ucrInputModelOperators2.GetText <> "") Then
            ucrBaseFourVariableModelling.OKEnabled(True)
        Else
            ucrBaseFourVariableModelling.OKEnabled(False)
        End If
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrModelPreview.SetName(clsFormulaOperator.ToScript)
        Else
            ucrModelPreview.SetName("")
        End If
    End Sub

    Public Sub ResponseConvert()
        If bRCodeSet Then
            If Not ucrReceiverResponse.IsEmpty Then
                ucrDistributionChoice.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))

                If ucrReceiverResponse.strCurrDataType = "numeric" Then
                    ucrChkConvertToNumeric.Checked = False
                    ucrChkConvertToNumeric.Visible = False
                Else
                    ucrChkConvertToNumeric.Visible = True
                End If
                If ucrChkConvertToNumeric.Checked Then
                    clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsRNumeric, iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype("numeric")
                Else
                    clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                    clsFormulaOperator.bBrackets = False
                End If
            Else
                ucrChkConvertToNumeric.Visible = False
            End If

            If ucrDistributionChoice.lstCurrentDistributions.Count = 0 Or ucrReceiverResponse.IsEmpty() Then
                ucrDistributionChoice.Enabled = False
                ucrDistributionChoice.ucrInputDistributions.SetName("")
                cmdModelOptions.Enabled = False
            Else
                ucrDistributionChoice.Enabled = True
                cmdModelOptions.Enabled = True
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub

    Private Sub FirstExplanatoryFunctionEnabled()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso {"numeric", "integer"}.Contains(ucrReceiverFirstExplanatory.strCurrDataType) Then
            cmdFirstExplanatoryFunction.Enabled = True
        Else
            cmdFirstExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub SecondExplanatoryFunctionEnabled()
        If Not ucrReceiverSecondExplanatory.IsEmpty AndAlso {"numeric", "integer"}.Contains(ucrReceiverSecondExplanatory.strCurrDataType) Then
            cmdSecondExplanatoryFunction.Enabled = True
        Else
            cmdSecondExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub ThirdExplanatoryFunctionEnabled()
        If Not ucrReceiverThirdExplanatory.IsEmpty AndAlso {"numeric", "integer"}.Contains(ucrReceiverThirdExplanatory.strCurrDataType) Then
            cmdThirdExplanatoryFunction.Enabled = True
        Else
            cmdThirdExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverSecondExplanatory_ControlValueChanged() Handles ucrReceiverSecondExplanatory.ControlValueChanged
        '   clsSecondExplanatoryOperator.AddParameter("var2", ucrReceiverSecondExplanatory.GetVariableNames(bWithQuotes:=False))
    End Sub

    Private Sub ucrReceiverThird_ControlValueChanged() Handles ucrReceiverThirdExplanatory.ControlValueChanged
        '     clsFormulaOperator.AddParameter("var3", clsROperatorParameter:=clsSecondExplanatoryOperator, iPosition:=2)
        'clsSecondExplanatoryOperator.AddParameter("var3", ucrReceiverThirdExplanatory.GetVariableNames(bWithQuotes:=False))
    End Sub

    Private Sub ucrBaseFourVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseFourVariableModelling_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickOk
        'sdgSimpleRegOptions.RegOptions()
    End Sub

    Public Sub SetBaseFunction()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrReceiverResponse.IsEmpty Then
            'TODO:   Include multinomial as an option And the appropriate function
            If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText <> "|") Then
                'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
                sdgSimpleRegOptions.lblConfLevel.Enabled = True
                'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
                clsLMOrGLM = clsLM
            ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText = "|") Then
                ' sdgSimpleRegOptions.chkDisplayCLimits.Checked = False
                ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = False
                sdgSimpleRegOptions.lblConfLevel.Enabled = False
                ' sdgSimpleRegOptions.nudDisplayCLevel.Enabled = False
                clsLMOrGLM = clsLmer
            ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag <> "Normal" And ucrInputModelOperators2.GetText = "|") Then
                'sdgSimpleRegOptions.chkDisplayCLimits.Checked = False
                'sdgSimpleRegOptions.chkDisplayCLimits.Enabled = False
                sdgSimpleRegOptions.lblConfLevel.Enabled = False
                'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = False
                clsLMOrGLM = clsGlmer
            Else
                ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
                sdgSimpleRegOptions.lblConfLevel.Enabled = True
                'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
                clsLMOrGLM = clsGLM
            End If
            clsFormulaFunction.AddParameter("x", clsRFunctionParameter:=clsLMOrGLM)
            clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsConfint.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            clsAutoPlot.AddParameter("object", clsRFunctionParameter:=clsLMOrGLM, iPosition:=0)
            ucrBaseFourVariableModelling.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(ucrBaseFourVariableModelling.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, clsNewAutoplot:=clsAutoPlot, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        bResetDisplayOptions = False

    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        Dim clsTempParam As RParameter = Nothing

        sdgModelOptions.SetRCodeForControls(ucrDistributionChoice, clsFamilyFunction, bResetModelOptions)
        sdgModelOptions.ShowDialog()
        bResetModelOptions = False
        If clsFamilyFunction.ContainsParameter("link") Then
            clsTempParam = clsFamilyFunction.GetParameter("link")
        End If
        ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
        If clsTempParam IsNot Nothing Then
            clsFamilyFunction.AddParameter(clsTempParam)
        End If
        SetBaseFunction()
    End Sub

    Private Sub cmdFirstFunction_Click(sender As Object, e As EventArgs) Handles cmdFirstExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsOverallExplanatoryOperator, clsNewTransformParameter:=clsOverallExplanatoryOperator.GetParameter("var2"), clsNewTransformFunction:=clsFirstTransformFunction, clsNewPowerOperator:=clsFirstPowerOperator, strVariableName:=ucrReceiverFirstExplanatory.GetVariableNames(False), bReset:=bResetFirstFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFirstFunction = False
        UpdatePreview()
    End Sub

    Private Sub cmdSecondFunction_Click(sender As Object, e As EventArgs) Handles cmdSecondExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsSecoandndThirdExplanatoryOpertor, clsNewTransformParameter:=clsSecoandndThirdExplanatoryOpertor.GetParameter("var3"), clsNewTransformFunction:=clsSecondTransformFunction, clsNewPowerOperator:=clsSecondPowerOperator, strVariableName:=ucrReceiverSecondExplanatory.GetVariableNames(False), bReset:=bResetSecondFunction)
        sdgVariableTransformations.ShowDialog()
        bResetSecondFunction = False
        UpdatePreview()
    End Sub

    Private Sub cmdThirdFunction_Click(sender As Object, e As EventArgs) Handles cmdThirdExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsSecoandndThirdExplanatoryOpertor, clsNewTransformParameter:=clsSecoandndThirdExplanatoryOpertor.GetParameter("var4"), clsNewTransformFunction:=clsThirdTransformFunction, clsNewPowerOperator:=clsThirdPowerOperator, strVariableName:=ucrReceiverThirdExplanatory.GetVariableNames(False), bReset:=bResetThirdFunction)
        sdgVariableTransformations.ShowDialog()
        bResetThirdFunction = False
        UpdatePreview()
    End Sub

    Private Sub ucrResponse_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponse.ControlValueChanged, ucrChkConvertToNumeric.ControlValueChanged, ucrReceiverSecondExplanatory.ControlValueChanged
        SetBaseFunction()
        ResponseConvert()
        UpdatePreview()
    End Sub

    Private Sub ucrDistributionChoice_DistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
        clsFamilyFunction.RemoveParameterByName("link")
    End Sub

    Private Sub ucrSelectorFourVariableModelling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFourVariableModelling.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub SetOverallExplanatoryOperator()
        clsOverallExplanatoryOperator.SetOperation(ucrInputModelOperators1.GetText())
    End Sub

    Private Sub SetSecondandThirdExplanatoryOperator()
        clsSecoandndThirdExplanatoryOpertor.SetOperation(ucrInputModelOperators2.GetText())
    End Sub

    Private Sub ucrFirstExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverFirstExplanatory.IsEmpty Then
                clsOverallExplanatoryOperator.AddParameter("var2", ucrReceiverFirstExplanatory.GetVariableNames(False), iPosition:=0)
            Else
                clsOverallExplanatoryOperator.RemoveParameterByName("var2")
            End If
        End If
        SetBaseFunction()
        FirstExplanatoryFunctionEnabled()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverSecondExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverSecondExplanatory.IsEmpty Then
                clsSecoandndThirdExplanatoryOpertor.AddParameter("var3", ucrReceiverSecondExplanatory.GetVariableNames(False), iPosition:=0)
            Else
                clsSecoandndThirdExplanatoryOpertor.RemoveParameterByName("var3")
            End If
        End If
        SetBaseFunction()
        SecondExplanatoryFunctionEnabled()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverThirdExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThirdExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverThirdExplanatory.IsEmpty Then
                clsSecoandndThirdExplanatoryOpertor.AddParameter("var4", ucrReceiverThirdExplanatory.GetVariableNames(False), iPosition:=1)
            Else
                clsSecoandndThirdExplanatoryOpertor.RemoveParameterByName("var4")
            End If
        End If
        SetBaseFunction()
        ThirdExplanatoryFunctionEnabled()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrInputModelOperators1.ControlContentsChanged, ucrInputModelOperators2.ControlContentsChanged, ucrReceiverThirdExplanatory.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputModelOperators1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelOperators1.ControlValueChanged
        SetBaseFunction()
        SetOverallExplanatoryOperator()
        UpdatePreview()
    End Sub

    Private Sub ucrInputModelOperators2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelOperators2.ControlValueChanged
        SetBaseFunction()
        SetSecondandThirdExplanatoryOperator()
        UpdatePreview()
    End Sub
End Class