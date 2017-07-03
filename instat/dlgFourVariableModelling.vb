﻿' R- Instat
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
    Public bResetFunction As Boolean = False
    Public clsRCIFunction, clsRConvert, clsFamilyFunction, clsVisReg, clsAutoPlot As New RFunction
    Public clsRSingleModelFunction, clsRNumeric, clsGLM, clsLM, clsFormulaFunction, clsSummaryFunction, clsConfint As RFunction
    Public clsFormulaOperator1, clsFormulaOperator2 As ROperator
    Private clsFirstPowerOperator As ROperator
    Public clsFirstExplanatoryOperator, clsSecondExplanatoryOperator As New ROperator
    Private clsFirstTransformFunction, clsAnovaFunction, clsLMOrGLM, clsLmer, clsGlmer As RFunction

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

        ucrReceiverResponse.SetParameter(New RParameter("x", 0))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.Selector = ucrSelectorFourVariableModelling

        ucrReceiverFirstExplanatory.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.bWithQuotes = False
        ucrReceiverFirstExplanatory.Selector = ucrSelectorFourVariableModelling

        ucrReceiverSecondExplanatory.SetParameter(New RParameter("x", 0))
        ucrReceiverSecondExplanatory.SetParameterIsString()
        ucrReceiverSecondExplanatory.bWithQuotes = False
        ucrReceiverSecondExplanatory.Selector = ucrSelectorFourVariableModelling

        ucrReceiverThirdExplanatory.SetParameter(New RParameter("x", 0))
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
        clsLmer = New RFunction
        clsLMOrGLM = New RFunction
        clsGlmer = New RFunction

        clsFirstPowerOperator = New ROperator
        clsFormulaOperator1 = New ROperator
        clsFormulaOperator2 = New ROperator
        clsFirstExplanatoryOperator = New ROperator
        clsSecondExplanatoryOperator = New ROperator

        ucrSelectorFourVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrBaseFourVariableModelling.clsRsyntax.ClearCodes()

        clsSecondExplanatoryOperator.SetOperation("|")
        ' clsSecondExplanatoryOperator.AddParameter(iPosition:=0, strParameterValue:=ucrReceiverSecondExplanatory.GetVariableNames(bWithQuotes:=False))
        clsSecondExplanatoryOperator.bBrackets = False

        clsFirstExplanatoryOperator.SetOperation("+")
        '  clsFirstExplanatoryOperator.AddParameter(strParameterValue:="(" & clsSecondExplanatoryOperator.ToScript.ToString & ")")
        clsFirstExplanatoryOperator.bBrackets = False



        ucrDistributionChoice.SetDataType("numeric")
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsRNumeric.SetRCommand("as.numeric")

        clsFormulaOperator1.SetOperation("~")
        clsFormulaOperator1.AddParameter("x", clsROperatorParameter:=clsFirstExplanatoryOperator, iPosition:=1)

        clsFormulaOperator2.SetOperation("*")
        clsFormulaOperator2.AddParameter("x", clsROperatorParameter:=clsSecondExplanatoryOperator, iPosition:=1)

        '    clsFormulaOperator.AddParameter("y", clsROperatorParameter:=clsSecondExplanatoryOperator, iPosition:=2)



        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator1, iPosition:=0)

        clsLmer.SetPackageName("lme4")
        clsLmer.SetRCommand("lmer")
        clsLmer.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator1, iPosition:=0)

        clsGLM = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator1, iPosition:=0)

        clsGlmer.SetPackageName("lme4")
        clsGlmer.SetRCommand("glmer")
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
        bResetFunction = True

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

        ucrInputModelOperators1.SetName(clsFirstExplanatoryOperator.strOperation)
        ucrInputModelOperators2.SetName(clsSecondExplanatoryOperator.strOperation)

        ucrChkConvertToNumeric.SetRCode(clsFormulaOperator1, bReset)
        ucrSelectorFourVariableModelling.SetRCode(clsLM, bReset)
        ucrSaveModel.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverResponse.SetRCode(clsRNumeric, bReset)
        ucrReceiverFirstExplanatory.SetRCode(clsFirstTransformFunction, bReset)
        ucrReceiverSecondExplanatory.SetRCode(clsFirstTransformFunction, bReset)
        ucrReceiverThirdExplanatory.SetRCode(clsFirstTransformFunction, bReset)

        bRCodeSet = True
        ExplanatoryFunctionEnabled()
        TestOKEnabled()

    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrReceiverResponse.IsEmpty()) AndAlso (Not ucrReceiverFirstExplanatory.IsEmpty()) AndAlso (Not ucrReceiverSecondExplanatory.IsEmpty()) AndAlso (Not ucrReceiverThirdExplanatory.IsEmpty()) AndAlso (ucrInputModelOperators1.GetText <> "") AndAlso (ucrInputModelOperators2.GetText <> "") Then
            ' clsModel2.bBrackets = False
            ' clsModel1.AddParameter(strParameterValue:="(" & clsModel2.ToScript.ToString & ")")
            ' clsModel1.SetOperation(ucrInputModelOperators1.GetText)
            ' clsModel1.bBrackets = False
            ucrBaseFourVariableModelling.OKEnabled(True)
        Else
            ucrBaseFourVariableModelling.OKEnabled(False)
        End If
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponse.IsEmpty Then
            ucrModelPreview.SetName(clsFormulaOperator1.ToScript)
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
                    clsFormulaOperator1.AddParameter("y", clsRFunctionParameter:=clsRNumeric, iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype("numeric")
                Else
                    clsFormulaOperator1.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
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

    Private Sub ExplanatoryFunctionEnabled()
        If Not ucrReceiverResponse.IsEmpty AndAlso {"numeric", "integer"}.Contains(ucrReceiverFirstExplanatory.strCurrDataType) Then
            cmdFunction.Enabled = True
        Else
            cmdFunction.Enabled = False
        End If
    End Sub

    Private Sub ucrFirstRandomEffect_SelectionChanged() Handles ucrReceiverSecondExplanatory.ControlValueChanged
        '  clsSecondExplanatoryOperator.AddParameter(iPosition:=0, strParameterValue:=ucrReceiverSecondExplanatory.GetVariableNames(bWithQuotes:=False))
        'TestOKEnabled()
    End Sub
    Private Sub ucrSecondRandomEffect_SelectionChanged() Handles ucrReceiverThirdExplanatory.ControlValueChanged
        '   clsSecondExplanatoryOperator.AddParameter(strParameterValue:=ucrReceiverThirdExplanatory.GetVariableNames(bWithQuotes:=False))
        '  TestOKEnabled()
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

    Private Sub cmdFunction_Click(sender As Object, e As EventArgs) Handles cmdFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsFirstExplanatoryOperator, clsNewTransformParameter:=clsFirstExplanatoryOperator.GetParameter("exp"), clsNewTransformFunction:=clsFirstTransformFunction, clsNewPowerOperator:=clsFirstPowerOperator, strVariableName:=ucrReceiverFirstExplanatory.GetVariableNames(False), bReset:=bResetFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFunction = False
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

    Private Sub SetExplanatoryOperator()
        If Not ucrInputModelOperators1.IsEmpty Then
            clsFirstExplanatoryOperator.SetOperation(ucrInputModelOperators1.GetText())
        End If
        If Not ucrInputModelOperators2.IsEmpty Then
            clsSecondExplanatoryOperator.SetOperation(ucrInputModelOperators2.GetText())

        End If
    End Sub

    Private Sub ucrFirstExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverFirstExplanatory.IsEmpty Then
                clsFirstExplanatoryOperator.AddParameter("exp", ucrReceiverFirstExplanatory.GetVariableNames(False), iPosition:=0)
            Else
                clsFirstExplanatoryOperator.RemoveParameterByName("exp")
            End If
            If Not ucrReceiverSecondExplanatory.IsEmpty Then
                clsSecondExplanatoryOperator.AddParameter("exp", ucrReceiverSecondExplanatory.GetVariableNames(False), iPosition:=0)
            Else
                clsSecondExplanatoryOperator.RemoveParameterByName("exp")
            End If

        End If
        SetBaseFunction()
        ExplanatoryFunctionEnabled()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrInputModelOperators1.ControlContentsChanged, ucrInputModelOperators2.ControlContentsChanged, ucrReceiverThirdExplanatory.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputModelOperators1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelOperators1.ControlValueChanged, ucrInputModelOperators2.ControlValueChanged
        SetBaseFunction()
        SetExplanatoryOperator()
        UpdatePreview()
    End Sub
End Class