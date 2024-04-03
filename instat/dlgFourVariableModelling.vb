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
Public Class dlgFourVariableModelling
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bResetModelOptions As Boolean = False
    Public bResetThirdFunction As Boolean = False
    Public bResetDisplayOptions As Boolean = False
    Public bResetFirstFunction As Boolean = False
    Public bResetSecondFunction As Boolean = False
    Public bRCodeSet As Boolean = False
    Public clsRCIFunction, clsRConvert, clsFamilyFunction, clsVisReg As New RFunction
    Public clsRSingleModelFunction, clsThirdTransformFunction, clsLmer, clsGLMFunctioner, clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As New RFunction
    Public clsFormulaOperator As New ROperator
    Public clsGLMFunction, clsAOVFunction, clsLM, clsLMOrGLM, clsAsNumeric As New RFunction

    'Saving Operators/Functions
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction

    Private clsExplanatoryOperator As New ROperator
    Private clsFirstTransformFunction As New RFunction
    Private clsFirstPowerOperator, clsThirdPowerOperator, clsSecoandndThirdExplanatoryOpertor, clsOverallExplanatoryOperator As New ROperator
    Private clsSecondTransformFunction As New RFunction
    Private clsSecondPowerOperator As New ROperator

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgFourVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrBaseFourVariableModelling.clsRsyntax.iCallType = 2
        ucrBaseFourVariableModelling.iHelpTopicID = 385
        ucrBaseFourVariableModelling.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorFourVariableModelling.SetParameter(New RParameter("data", 0))
        ucrSelectorFourVariableModelling.SetParameterIsrfunction()

        'The main parameter will be in the as.numeric() function since it's always present there
        ucrReceiverResponse.SetParameter(New RParameter("x", 0))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.Selector = ucrSelectorFourVariableModelling

        'The main parameter will be in the transformation function since it's always present there
        ucrReceiverFirstExplanatory.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.bWithQuotes = False
        ucrReceiverFirstExplanatory.Selector = ucrSelectorFourVariableModelling

        'The main parameter will be in the transformation function since it's always present there
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

        ucrChkConvertToNumeric.SetText("Convert to Variate")
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(False, "y", False)

        ucrInputModelOperators1.SetItems({"+", "*", ":", "/", "|"})
        ucrInputModelOperators1.SetDropDownStyleAsNonEditable()

        ucrInputModelOperators2.SetItems({"+", "*", ":", "/", "|"})
        ucrInputModelOperators2.SetDropDownStyleAsNonEditable()

        ucrModelPreview.IsReadOnly = True

        'temp hidden until working
        'cmdResponseFunction.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsFamilyFunction = New RFunction
        clsAsNumeric = New RFunction
        clsLM = New RFunction
        clsAOVFunction = New RFunction
        clsGLMFunction = New RFunction
        clsFirstTransformFunction = New RFunction
        clsSecondTransformFunction = New RFunction
        clsFormulaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction
        clsThirdTransformFunction = New RFunction
        clsLmer = New RFunction
        clsLMOrGLM = New RFunction
        clsGLMFunctioner = New RFunction

        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction

        clsFirstTransformFunction = New RFunction
        clsFirstPowerOperator = New ROperator
        clsSecondTransformFunction = New RFunction
        clsSecondPowerOperator = New ROperator

        clsFormulaOperator = New ROperator
        clsExplanatoryOperator = New ROperator

        clsFirstPowerOperator = New ROperator
        clsSecondPowerOperator = New ROperator
        clsThirdPowerOperator = New ROperator
        clsFormulaOperator = New ROperator
        clsSecoandndThirdExplanatoryOpertor = New ROperator
        clsOverallExplanatoryOperator = New ROperator

        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction

        ucrSelectorFourVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrChkConvertToNumeric.Visible = False

        ucrBaseFourVariableModelling.clsRsyntax.ClearCodes()

        clsSecoandndThirdExplanatoryOpertor.SetOperation("+")
        clsSecoandndThirdExplanatoryOpertor.bBrackets = False

        ucrDistributionChoice.SetDataType("numeric")
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsAsNumeric.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsFormulaOperator.AddParameter("operator", clsROperatorParameter:=clsOverallExplanatoryOperator, iPosition:=1)
        clsFormulaOperator.bBrackets = True

        clsOverallExplanatoryOperator.SetOperation("+")
        clsOverallExplanatoryOperator.AddParameter("operator2&3", clsROperatorParameter:=clsSecoandndThirdExplanatoryOpertor, iPosition:=1)
        clsOverallExplanatoryOperator.bBrackets = False


        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsLM.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsLM.bExcludeAssignedFunctionOutput = False
        clsLM.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_model")


        clsLmer.SetPackageName("lme4")
        clsLmer.SetRCommand("lmer")
        clsLmer.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)

        clsGLMFunctioner.SetPackageName("lme4")
        clsGLMFunctioner.SetRCommand("glmer")
        clsGLMFunctioner.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGLMFunctioner.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)


        clsGLMFunction = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLMFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGLMFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsGLMFunction.bExcludeAssignedFunctionOutput = False
        clsGLMFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_model")

        clsAOVFunction = clsRegressionDefaults.clsDefaultAovFunction.Clone()
        clsAOVFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsAOVFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsAOVFunction.bExcludeAssignedFunctionOutput = False
        clsAOVFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_model")

        clsFamilyFunction = ucrDistributionChoice.clsCurrRFunction
        clsGLMFunction.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        clsFirstPowerOperator.SetOperation("^")
        clsFirstPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsFirstPowerOperator.bBrackets = False

        clsSecondPowerOperator.SetOperation("^")
        clsSecondPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsSecondPowerOperator.bBrackets = False

        'Residual Plots
        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        'Model
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.bExcludeAssignedFunctionOutput = False

        'Summary
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.bExcludeAssignedFunctionOutput = False

        'ANOVA
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.bExcludeAssignedFunctionOutput = False

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.bExcludeAssignedFunctionOutput = False

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        'changed gg parameter to FALSE since when TRUE no plot is given (not compatible with ggplot2 package)
        clsVisReg.AddParameter("gg", "FALSE")
        clsVisReg.bExcludeAssignedFunctionOutput = False

        clsFirstPowerOperator.SetOperation("^")
        clsFirstPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsFirstPowerOperator.bBrackets = False

        clsSecondPowerOperator.SetOperation("^")
        clsSecondPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsSecondPowerOperator.bBrackets = False

        clsThirdPowerOperator.SetOperation("^")
        clsThirdPowerOperator.AddParameter("power", 2, iPosition:=1)
        clsThirdPowerOperator.bBrackets = False
        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        clsLMOrGLM = clsLmer
        ucrBaseFourVariableModelling.clsRsyntax.SetBaseRFunction(clsLmer)
        ucrBaseFourVariableModelling.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBaseFourVariableModelling.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        bResetModelOptions = True
        bResetDisplayOptions = True
        bResetFirstFunction = True
        bResetSecondFunction = True
        bResetThirdFunction = True
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlValueChanged

        '---------------------------------------------------------------------
        'model summaries outputs

        'stats output formula for the model
        clsFormulaFunction.AddParameter("x", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsFormulaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'anova output summary for the model
        clsAnovaFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsAnovaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'estimates output for the model
        clsSummaryFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")


        'confidence output limits for the model
        clsConfint.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsConfint.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        '---------------------------------------------------------------------
        'column outputs
        'note set assign has not been set here because it's done at the sub dialog level
        'through individual save controls linked to this dialog data frame selector

        clsResidualFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsFittedValuesFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsRstandardFunction.AddParameter("model", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsHatvaluesFunction.AddParameter("model", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)

        '---------------------------------------------------------------------
        'graphical outputs

        'model plot output
        clsVisReg.AddParameter("fit", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsVisReg.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                  strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                  strObjectName:="last_graph")

        'residual plots outputs
        For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
            kvp.Value.AddParameter("x", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
            kvp.Value.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                        strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                        strRDataFrameNameToAddObjectTo:=ucrSelectorFourVariableModelling.strCurrentDataFrame,
                                        strObjectName:="last_graph")
        Next

    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        bRCodeSet = False
        ucrSaveModel.AddAdditionalRCode(clsGLMFunction, 1)
        ucrSaveModel.AddAdditionalRCode(clsGLMFunctioner, 2)
        ucrSaveModel.AddAdditionalRCode(clsLmer, 3)
        ucrSaveModel.AddAdditionalRCode(clsAOVFunction, 4)

        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsGLMFunction, ucrSelectorFourVariableModelling.GetParameter(), 1)
        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsGLMFunctioner, ucrSelectorFourVariableModelling.GetParameter(), 2)
        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsLmer, ucrSelectorFourVariableModelling.GetParameter(), 3)
        ucrSelectorFourVariableModelling.AddAdditionalCodeParameterPair(clsAOVFunction, ucrSelectorFourVariableModelling.GetParameter(), 4)

        ucrInputModelOperators1.SetName(clsOverallExplanatoryOperator.strOperation)
        ucrInputModelOperators2.SetName(clsSecoandndThirdExplanatoryOpertor.strOperation)
        ucrChkConvertToNumeric.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorFourVariableModelling.SetRCode(clsLM, bReset)
        ucrSaveModel.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bReset)
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
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrInputModelOperators1.IsEmpty AndAlso Not ucrInputModelOperators2.IsEmpty AndAlso Not ucrDistributionChoice.ucrInputDistributions.IsEmpty Then
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
                    'temp disabled
                    'cmdResponseFunction.Visible = True
                Else
                    ucrChkConvertToNumeric.Visible = True
                    'temp disabled
                    'cmdResponseFunction.Visible = False
                End If
                If ucrChkConvertToNumeric.Checked Then
                    clsFormulaOperator.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype("numeric")
                Else
                    clsFormulaOperator.AddParameter("y", ucrReceiverResponse.GetVariableNames(False), iPosition:=0)
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
                    clsFormulaOperator.bBrackets = False
                End If
            Else
                ucrChkConvertToNumeric.Visible = False
                'temp disabled
                'cmdResponseFunction.Visible = False
            End If
            If ucrDistributionChoice.lstCurrentDistributions.Count = 0 OrElse ucrReceiverResponse.IsEmpty() Then
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

    Private Sub ResponseControls_ControlValueChanged() Handles ucrReceiverResponse.ControlValueChanged, ucrChkConvertToNumeric.ControlValueChanged
        SetBaseFunction()
        ResponseConvert()
        UpdatePreview()
    End Sub

    Private Sub ucrBaseFourVariableModellingThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ThirdExplanatoryFunctionEnabled()
        If Not ucrReceiverThirdExplanatory.IsEmpty AndAlso {"numeric", "integer", "factor", "logical"}.Contains(ucrReceiverThirdExplanatory.strCurrDataType) Then
            cmdThirdExplanatoryFunction.Enabled = True
        Else
            cmdThirdExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub ucrBaseFourVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseFourVariableModelling.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetBaseFunction()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrReceiverResponse.IsEmpty Then

            If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText <> "|") Then
                clsLMOrGLM = clsLM
            ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText = "|") Then
                clsLMOrGLM = clsLmer
            ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag <> "Normal" And ucrInputModelOperators2.GetText = "|") Then
                clsLMOrGLM = clsGLMFunctioner
            ElseIf (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal_aov") Then
                clsLMOrGLM = clsAOVFunction
            Else
                clsLMOrGLM = clsGLMFunction
            End If
            ucrBaseFourVariableModelling.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
        End If
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBaseFourVariableModelling.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, dctNewPlot:=dctPlotFunctions, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, ucrNewAvailableDatafrane:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        GraphAssignTo()
        bResetDisplayOptions = False
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
        clsFamilyFunction.RemoveParameterByName("link")
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

    Private Sub cmdFirstExplanatoryFunction_Click(sender As Object, e As EventArgs) Handles cmdFirstExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsOverallExplanatoryOperator, clsNewTransformParameter:=clsOverallExplanatoryOperator.GetParameter("var2"), clsNewTransformFunction:=clsFirstTransformFunction, clsNewPowerOperator:=clsFirstPowerOperator, strVariableName:=ucrReceiverFirstExplanatory.GetVariableNames(False), bReset:=bResetFirstFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFirstFunction = False
        UpdatePreview()
    End Sub

    Private Sub cmdSecondExplanatoryFunction_Click(sender As Object, e As EventArgs) Handles cmdSecondExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsSecoandndThirdExplanatoryOpertor, clsNewTransformParameter:=clsSecoandndThirdExplanatoryOpertor.GetParameter("var3"), clsNewTransformFunction:=clsSecondTransformFunction, clsNewPowerOperator:=clsSecondPowerOperator, strVariableName:=ucrReceiverSecondExplanatory.GetVariableNames(False), bReset:=bResetSecondFunction)
        sdgVariableTransformations.ShowDialog()
        bResetSecondFunction = False
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrInputModelOperators1.ControlContentsChanged, ucrInputModelOperators2.ControlContentsChanged, ucrReceiverThirdExplanatory.ControlContentsChanged
        TestOKEnabled()
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
        '   UpdatePreview()
    End Sub

    Private Sub ucrDistributionChoice_DistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        SetBaseFunction()
        clsFamilyFunction.RemoveParameterByName("link")
    End Sub

    Private Sub ucrSelectorFourVariableModelling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFourVariableModelling.ControlValueChanged
        SetBaseFunction()
        GraphAssignTo()
    End Sub

    Private Sub GraphAssignTo()
        'temp fix for graph display problem with RDotNet
        clsVisReg.SetAssignTo("last_visreg", strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_visreg")

        'Dim lstPlotNames As New List(Of String)
        'Dim i As Integer = 0

        'lstPlotNames = New List(Of String)({"last_residplot", "last_qqplot", "last_scaleloc", "last_cooksdist", "last_residlev", "last_cookslev"})

        'For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
        '    kvp.Value.SetAssignTo(lstPlotNames(index:=i), strTempDataframe:=ucrSelectorFourVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=lstPlotNames(index:=i))
        '    i = i + 1
        'Next
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

    Private Sub FirstExplanatoryFunctionEnabled()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso {"numeric", "integer", "factor", "logical"}.Contains(ucrReceiverFirstExplanatory.strCurrDataType) Then
            cmdFirstExplanatoryFunction.Enabled = True
        Else
            cmdFirstExplanatoryFunction.Enabled = False
        End If
    End Sub

    Private Sub SecondExplanatoryFunctionEnabled()
        If Not ucrReceiverSecondExplanatory.IsEmpty AndAlso {"numeric", "integer", "factor", "logical"}.Contains(ucrReceiverSecondExplanatory.strCurrDataType) Then
            cmdSecondExplanatoryFunction.Enabled = True
        Else
            cmdSecondExplanatoryFunction.Enabled = False
        End If
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