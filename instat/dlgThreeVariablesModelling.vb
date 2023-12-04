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
Public Class dlgThreeVariableModelling

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bResetModelOptions As Boolean = False
    Public bResetDisplayOptions As Boolean = False
    Public bResetFirstFunction As Boolean = False
    Public bResetSecondFunction As Boolean = False
    Public bRCodeSet As Boolean = False
    Public clsFamilyFunction, clsVisReg As New RFunction
    Public clsRSingleModelFunction, clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As New RFunction
    Public clsFormulaOperator As New ROperator
    Public clsGLMFunction, clsLM, clsAOVFunction, clsLMOrGLM, clsAsNumeric As New RFunction

    'Saving Operators/Functions
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction

    Private clsExplanatoryOperator As New ROperator
    Private clsFirstTransformFunction As New RFunction
    Private clsFirstPowerOperator As New ROperator
    Private clsSecondTransformFunction As New RFunction
    Private clsSecondPowerOperator As New ROperator

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)
    Private Sub dlgThreeVariableModelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 369
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorThreeVariableModelling.SetParameter(New RParameter("data", 0))
        ucrSelectorThreeVariableModelling.SetParameterIsrfunction()

        'The main parameter will be in the as.numeric() function since it's always present there
        ucrReceiverResponse.SetParameter(New RParameter("x", 0))
        ucrReceiverResponse.SetParameterIsString()
        ucrReceiverResponse.bWithQuotes = False
        ucrReceiverResponse.Selector = ucrSelectorThreeVariableModelling

        'The main parameter will be in the transformation function since it's always present there
        ucrReceiverFirstExplanatory.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstExplanatory.SetParameterIsString()
        ucrReceiverFirstExplanatory.bWithQuotes = False
        ucrReceiverFirstExplanatory.Selector = ucrSelectorThreeVariableModelling

        'The main parameter will be in the transformation function since it's always present there
        ucrReceiverSecondExplanatory.SetParameter(New RParameter("x", 0))
        ucrReceiverSecondExplanatory.SetParameterIsString()
        ucrReceiverSecondExplanatory.bWithQuotes = False
        ucrReceiverSecondExplanatory.Selector = ucrSelectorThreeVariableModelling

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()

        ucrSaveModel.SetPrefix("reg")
        ucrSaveModel.SetDataFrameSelector(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames)
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrChkConvertToNumeric.SetText("Convert to Variate")
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(True, "y", True)
        ucrChkConvertToNumeric.AddParameterIsRFunctionCondition(False, "y", False)

        ucrInputModelOperator.SetItems({"+", "*", ":", "/"})
        ucrInputModelOperator.SetDropDownStyleAsNonEditable()

        ucrModelPreview.IsReadOnly = True

        'temp hidden until working
        cmdResponseFunction.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsFamilyFunction = New RFunction
        clsAsNumeric = New RFunction
        clsLM = New RFunction
        clsGLMFunction = New RFunction
        clsFormulaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction
        clsAOVFunction = New RFunction


        clsFirstTransformFunction = New RFunction
        clsFirstPowerOperator = New ROperator
        clsSecondTransformFunction = New RFunction
        clsSecondPowerOperator = New ROperator

        clsFormulaOperator = New ROperator
        clsExplanatoryOperator = New ROperator

        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction

        ucrSelectorThreeVariableModelling.Reset()
        ucrReceiverResponse.SetMeAsReceiver()
        ucrChkConvertToNumeric.Visible = False

        ucrBase.clsRsyntax.ClearCodes()

        clsExplanatoryOperator.SetOperation("+")
        clsExplanatoryOperator.bBrackets = False

        ucrDistributionChoice.SetDataType("numeric")
        ucrSaveModel.Reset()
        ucrModelPreview.Reset()

        clsAsNumeric.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone
        clsFormulaOperator.AddParameter("x", clsROperatorParameter:=clsExplanatoryOperator, iPosition:=1)

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone()
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsLM.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsLM.bExcludeAssignedFunctionOutput = False
        clsLM.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_model")

        clsAOVFunction = clsRegressionDefaults.clsDefaultAovFunction.Clone()
        clsAOVFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsAOVFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsAOVFunction.bExcludeAssignedFunctionOutput = False
        clsAOVFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_model")

        clsGLMFunction = clsRegressionDefaults.clsDefaultGlmFunction.Clone()
        clsGLMFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGLMFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsGLMFunction.bExcludeAssignedFunctionOutput = False
        clsGLMFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
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

        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        clsLMOrGLM = clsLM
        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        bResetModelOptions = True
        bResetDisplayOptions = True
        bResetFirstFunction = True
        bResetSecondFunction = True
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrSaveModel.ControlValueChanged

        '---------------------------------------------------------------------
        'model summaries outputs

        'stats output formula for the model
        clsFormulaFunction.AddParameter("x", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsFormulaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'anova output summary for the model
        clsAnovaFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsAnovaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'estimates output for the model
        clsSummaryFunction.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")


        'confidence output limits for the model
        clsConfint.AddParameter("object", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
        clsConfint.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
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
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                  strObjectName:="last_graph")

        'residual plots outputs
        For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
            kvp.Value.AddParameter("x", strParameterValue:=clsLMOrGLM.GetRObjectToAssignTo(), iPosition:=0)
            kvp.Value.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                        strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                        strRDataFrameNameToAddObjectTo:=ucrSelectorThreeVariableModelling.strCurrentDataFrame,
                                        strObjectName:="last_graph")
        Next

    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        bRCodeSet = False

        ucrSaveModel.AddAdditionalRCode(clsAOVFunction, 1)
        ucrSaveModel.AddAdditionalRCode(clsGLMFunction, 1)
        ucrSelectorThreeVariableModelling.AddAdditionalCodeParameterPair(clsGLMFunction, ucrSelectorThreeVariableModelling.GetParameter(), 1)
        ucrReceiverFirstExplanatory.AddAdditionalCodeParameterPair(clsFirstPowerOperator, New RParameter("x", 0), 1)
        ucrReceiverSecondExplanatory.AddAdditionalCodeParameterPair(clsSecondPowerOperator, New RParameter("x", 0), 1)
        ucrSelectorThreeVariableModelling.AddAdditionalCodeParameterPair(clsAOVFunction, ucrSelectorThreeVariableModelling.GetParameter(), 1)

        ucrInputModelOperator.SetName(clsExplanatoryOperator.strOperation)
        ucrChkConvertToNumeric.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorThreeVariableModelling.SetRCode(clsLM, bReset)
        ucrSaveModel.SetRCode(clsLM, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)
        ucrReceiverResponse.SetRCode(clsAsNumeric, bReset)
        ucrReceiverFirstExplanatory.SetRCode(clsFirstTransformFunction, bReset)
        ucrReceiverSecondExplanatory.SetRCode(clsSecondTransformFunction, bReset)
        bRCodeSet = True
        FirstExplanatoryFunctionEnabled()
        SecondExplanatoryFunctionEnabled()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverResponse.IsEmpty AndAlso Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrInputModelOperator.IsEmpty AndAlso Not ucrDistributionChoice.ucrInputDistributions.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
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
                ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
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
                    ucrDistributionChoice.RecieverDatatype(ucrSelectorThreeVariableModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponse.GetVariableNames(bWithQuotes:=False))
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

    Private Sub ucrBaseThreeVariableModelling_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, dctNewPlot:=dctPlotFunctions, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, ucrNewAvailableDatafrane:=ucrSelectorThreeVariableModelling.ucrAvailableDataFrames, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        bResetDisplayOptions = False
    End Sub

    Private Sub SetExplanatoryOperator()
        clsExplanatoryOperator.SetOperation(ucrInputModelOperator.GetText())
    End Sub

    Private Sub SetBaseFunction()
        If Not ucrReceiverFirstExplanatory.IsEmpty AndAlso Not ucrReceiverSecondExplanatory.IsEmpty AndAlso Not ucrReceiverResponse.IsEmpty Then

            If (ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal") AndAlso (Not clsFamilyFunction.ContainsParameter("link") OrElse clsFamilyFunction.GetParameter("link").strArgumentValue = Chr(34) & "identity" & Chr(34)) Then
                clsLMOrGLM = clsLM
            ElseIf ucrDistributionChoice.clsCurrDistribution.strNameTag = "Normal_aov" Then
                clsLMOrGLM = clsAOVFunction
            Else
                clsLMOrGLM = clsGLMFunction
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsLMOrGLM)
        End If
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
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsExplanatoryOperator, clsNewTransformParameter:=clsExplanatoryOperator.GetParameter("exp1"), clsNewTransformFunction:=clsFirstTransformFunction, clsNewPowerOperator:=clsFirstPowerOperator, strVariableName:=ucrReceiverFirstExplanatory.GetVariableNames(False), bReset:=bResetFirstFunction)
        sdgVariableTransformations.ShowDialog()
        bResetFirstFunction = False
        UpdatePreview()
    End Sub

    Private Sub cmdSecondExplanatoryFunction_Click(sender As Object, e As EventArgs) Handles cmdSecondExplanatoryFunction.Click
        sdgVariableTransformations.SetRCodeForControls(clsNewFormulaOperator:=clsExplanatoryOperator, clsNewTransformParameter:=clsExplanatoryOperator.GetParameter("exp2"), clsNewTransformFunction:=clsSecondTransformFunction, clsNewPowerOperator:=clsSecondPowerOperator, strVariableName:=ucrReceiverSecondExplanatory.GetVariableNames(False), bReset:=bResetSecondFunction)
        sdgVariableTransformations.ShowDialog()
        bResetSecondFunction = False
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverFirstExplanatory_contents() Handles ucrReceiverResponse.ControlContentsChanged, ucrReceiverFirstExplanatory.ControlContentsChanged, ucrReceiverSecondExplanatory.ControlContentsChanged, ucrInputModelOperator.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrInputModelOperator_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelOperator.ControlValueChanged
        SetExplanatoryOperator()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverFirstExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverFirstExplanatory.IsEmpty Then
                clsExplanatoryOperator.AddParameter("exp1", ucrReceiverFirstExplanatory.GetVariableNames(False), iPosition:=0)
            Else
                clsExplanatoryOperator.RemoveParameterByName("exp1")
            End If
        End If
        SetBaseFunction()
        FirstExplanatoryFunctionEnabled()
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverSecondExplanatory_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondExplanatory.ControlValueChanged
        If bRCodeSet Then
            If Not ucrReceiverSecondExplanatory.IsEmpty Then
                clsExplanatoryOperator.AddParameter("exp2", ucrReceiverSecondExplanatory.GetVariableNames(False), iPosition:=1)
            Else
                clsExplanatoryOperator.RemoveParameterByName("exp2")
            End If
        End If
        SetBaseFunction()
        SecondExplanatoryFunctionEnabled()
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

    Private Sub ucrSelectorThreeVariableModelling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorThreeVariableModelling.ControlValueChanged
        SetBaseFunction()
    End Sub


End Class