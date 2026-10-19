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
Imports RDotNet

Public Class dlgAnovaModel
    Public strVariableType As String
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = False
    Public clsFormulaOperator As New ROperator
    Public clsAOVFunction, clsRConvert As New RFunction
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint, clsVisReg As New RFunction
    Private clsRstandardFunction, clsHatvaluesFunction, clsResidualFunction, clsFittedValuesFunction As New RFunction
    Public bResetOptionsSubDialog As Boolean = False
    Private dctPlotFunctions As New Dictionary(Of String, RFunction)
    Private ucrActiveExpression As ucrReceiverExpression

    'Mixed model functions
    Public clsLmerFunction, clsLmeFunction, clsGlmerFunction, clsFamilyFunction As New RFunction
    'The model function currently used as the base function (equivalent of clsLMOrGLM in dlgFitModel)
    Public clsCurrentModelFunction As RFunction

    Private Const strAovNameTag As String = "Normal_aov"
    Private Const strModelAov As String = "aov"
    Private Const strModelLmer As String = "lmer"
    Private Const strModelLme As String = "lme"
    Private Const strModelGlmer As String = "glmer"

    'Distributions that are not glm-style families, so cannot be passed to glmer(family = ...)
    Private ReadOnly lstNonGlmerFamilies As New List(Of String) From {strAovNameTag, "Negative_Binomial_GLM", "Ordered_Logistic", "Multinomial"}

    'True when summary() is in the after codes instead of anova() (aov with an Error() term)
    Private bUseSummaryOutput As Boolean = False

    Private Sub dlgAnovaModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 371
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorByDataFrameAddRemoveAnovaModel.SetParameter(New RParameter("data", 0))
        ucrSelectorByDataFrameAddRemoveAnovaModel.SetParameterIsrfunction()

        ucrReceiverAnovaResponseVar.SetParameter(New RParameter("x", 0))
        ucrReceiverAnovaResponseVar.SetParameterIsRFunction()

        ucrChkConvertToVariate.SetText("Convert to Variate")
        ucrChkConvertToVariate.AddParameterIsRFunctionCondition(True, "x", True)
        ucrChkConvertToVariate.AddParameterIsRFunctionCondition(False, "x", False)

        ucrReceiverExpressionAnovaModel.bWithQuotes = False
        ucrReceiverErrorAnovaModel.bWithQuotes = False
        ucrTryModelling.SetReceiver(ucrReceiverExpressionAnovaModel)
        ucrTryModelling.SetIsModel()

        ucrFamily.SetGLMDistributions()
        ucrFamily.SetFunctionIsDistFunction()

        'Model type pull-down
        ucrInputModelType.SetItems({strModelAov, strModelLmer, strModelLme, strModelGlmer})
        ucrInputModelType.SetDropDownStyleAsNonEditable()

        ucrModelName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveAnovaModel.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("anova_model")
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetCheckBoxText("Store Model")
        ucrModelName.SetIsComboBox()
        ucrModelName.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator

        clsRConvert = New RFunction
        clsAOVFunction = New RFunction
        clsLmerFunction = New RFunction
        clsLmeFunction = New RFunction
        clsGlmerFunction = New RFunction
        clsFamilyFunction = New RFunction
        clsFormulaFunction = New RFunction
        clsAnovaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction
        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction

        ucrSelectorByDataFrameAddRemoveAnovaModel.Reset()
        ucrModelName.Reset()
        ucrReceiverAnovaResponseVar.SetMeAsReceiver()
        ucrSelectorByDataFrameAddRemoveAnovaModel.Focus()

        clsRConvert.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrReceiverExpressionAnovaModel.Selector = ucrSelectorByDataFrameAddRemoveAnovaModel
        ucrReceiverErrorAnovaModel.Selector = ucrSelectorByDataFrameAddRemoveAnovaModel
        ucrReceiverAnovaResponseVar.Selector = ucrSelectorByDataFrameAddRemoveAnovaModel
        ucrReceiverAnovaResponseVar.SetMeAsReceiver()
        ucrReceiverExpressionAnovaModel.Clear()
        ucrReceiverErrorAnovaModel.Clear()
        ucrActiveExpression = ucrReceiverExpressionAnovaModel

        ucrInputModelPreview.SetName("")
        ucrInputModelPreview.IsReadOnly = True

        'aov
        clsAOVFunction = clsRegressionDefaults.clsDefaultAovFunction.Clone()
        clsAOVFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsAOVFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        SetModelOutput(clsAOVFunction)

        'lme4::lmer(formula = y ~ x + (1 | g), data = ...)
        clsLmerFunction.SetPackageName("lme4")
        clsLmerFunction.SetRCommand("lmer")
        clsLmerFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsLmerFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        SetModelOutput(clsLmerFunction)

        'nlme::lme(fixed = y ~ x, random = ~ 1 | g, data = ...)
        clsLmeFunction.SetPackageName("nlme")
        clsLmeFunction.SetRCommand("lme")
        clsLmeFunction.AddParameter("fixed", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsLmeFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        SetModelOutput(clsLmeFunction)

        'lme4::glmer(formula = y ~ x + (1 | g), family = ..., data = ...)
        clsFamilyFunction = ucrFamily.clsCurrRFunction
        clsGlmerFunction.SetPackageName("lme4")
        clsGlmerFunction.SetRCommand("glmer")
        clsGlmerFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsGlmerFunction.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction, iPosition:=1)
        clsGlmerFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        SetModelOutput(clsGlmerFunction)

        clsCurrentModelFunction = clsAOVFunction

        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.bExcludeAssignedFunctionOutput = False
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.bExcludeAssignedFunctionOutput = False

        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.bExcludeAssignedFunctionOutput = False
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "FALSE")
        clsVisReg.bExcludeAssignedFunctionOutput = False
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.bExcludeAssignedFunctionOutput = False

        bResetOptionsSubDialog = True

        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsAOVFunction)
        bUseSummaryOutput = False
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)

        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorByDataFrameAddRemoveAnovaModel.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorByDataFrameAddRemoveAnovaModel.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)

        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)

        'Set last, so the ControlValueChanged handler finds every function already built
        ucrInputModelType.SetName(strModelAov)
    End Sub

    Private Sub SetModelOutput(clsModelFunction As RFunction)
        clsModelFunction.bExcludeAssignedFunctionOutput = False
        clsModelFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_model")
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrModelName.ControlValueChanged
        Dim strModel As String = clsCurrentModelFunction.GetRObjectToAssignTo()

        clsFormulaFunction.AddParameter("x", strParameterValue:=strModel, iPosition:=0)
        clsFormulaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        clsAnovaFunction.AddParameter("object", strParameterValue:=strModel, iPosition:=0)
        clsAnovaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        clsSummaryFunction.AddParameter("object", strParameterValue:=strModel, iPosition:=0)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        clsConfint.AddParameter("object", strParameterValue:=strModel, iPosition:=0)
        clsConfint.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        clsResidualFunction.AddParameter("object", strParameterValue:=strModel, iPosition:=0)
        clsFittedValuesFunction.AddParameter("object", strParameterValue:=strModel, iPosition:=0)
        clsRstandardFunction.AddParameter("model", strParameterValue:=strModel, iPosition:=0)
        clsHatvaluesFunction.AddParameter("model", strParameterValue:=strModel, iPosition:=0)

        clsVisReg.AddParameter("fit", strParameterValue:=strModel, iPosition:=0)
        clsVisReg.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                  strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                  strObjectName:="last_graph")

        For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
            kvp.Value.AddParameter("x", strParameterValue:=strModel, iPosition:=0)
            kvp.Value.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                        strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                        strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                        strObjectName:="last_graph")
        Next
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        'Keep data and model name in sync across all the model functions (as in dlgFitModel)
        ucrSelectorByDataFrameAddRemoveAnovaModel.AddAdditionalCodeParameterPair(clsLmerFunction, ucrSelectorByDataFrameAddRemoveAnovaModel.GetParameter(), 1)
        ucrSelectorByDataFrameAddRemoveAnovaModel.AddAdditionalCodeParameterPair(clsLmeFunction, ucrSelectorByDataFrameAddRemoveAnovaModel.GetParameter(), 2)
        ucrSelectorByDataFrameAddRemoveAnovaModel.AddAdditionalCodeParameterPair(clsGlmerFunction, ucrSelectorByDataFrameAddRemoveAnovaModel.GetParameter(), 3)
        ucrModelName.AddAdditionalRCode(clsLmerFunction, bReset)
        ucrModelName.AddAdditionalRCode(clsLmeFunction, bReset)
        ucrModelName.AddAdditionalRCode(clsGlmerFunction, bReset)

        ucrSelectorByDataFrameAddRemoveAnovaModel.SetRCode(clsAOVFunction, bReset)
        ucrModelName.SetRCode(clsAOVFunction, bReset)
        ucrChkConvertToVariate.SetRCode(clsFormulaOperator, bReset)
        ucrReceiverAnovaResponseVar.SetRCode(clsRConvert, bReset)
        ucrFamily.SetRCode(clsFamilyFunction, bReset)
        bRCodeSet = True
        ResponseConvert()
    End Sub

    Private Function GetModelType() As String
        Dim strType As String = ucrInputModelType.GetText()
        If String.IsNullOrEmpty(strType) Then
            Return strModelAov
        End If
        Return strType
    End Function

    Private Sub TestOKEnabled()
        'lmer, lme and glmer all need at least one random effect term
        Dim bRandomOk As Boolean = GetModelType() = strModelAov OrElse Not ucrReceiverErrorAnovaModel.IsEmpty()
        If (Not ucrReceiverAnovaResponseVar.IsEmpty()) AndAlso (Not ucrReceiverExpressionAnovaModel.IsEmpty()) AndAlso Not ucrFamily.ucrInputDistributions.IsEmpty AndAlso bRandomOk Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverExpressionAnovaModel.AddtoCombobox(ucrReceiverExpressionAnovaModel.GetText)
        If Not ucrReceiverErrorAnovaModel.IsEmpty() Then
            ucrReceiverErrorAnovaModel.AddtoCombobox(ucrReceiverErrorAnovaModel.GetText)
        End If
    End Sub

    Private Sub ucrExpressionReceivers_Enter(sender As Object, e As EventArgs) Handles ucrReceiverExpressionAnovaModel.Enter, ucrReceiverErrorAnovaModel.Enter
        ucrActiveExpression = DirectCast(sender, ucrReceiverExpression)
    End Sub

    Private Sub AddToActiveExpression(strText As String, Optional iCursorOffset As Integer = 0)
        If iCursorOffset = 0 Then
            ucrActiveExpression.AddToReceiverAtCursorPosition(strText)
        Else
            ucrActiveExpression.AddToReceiverAtCursorPosition(strText, iCursorOffset)
        End If
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        AddToActiveExpression("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        AddToActiveExpression(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        AddToActiveExpression("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        AddToActiveExpression("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        AddToActiveExpression("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        AddToActiveExpression("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        AddToActiveExpression(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        AddToActiveExpression("^")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        AddToActiveExpression("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        AddToActiveExpression("I()", 1)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrActiveExpression.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        AddToActiveExpression("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        AddToActiveExpression("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        AddToActiveExpression("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        AddToActiveExpression("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        AddToActiveExpression("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        AddToActiveExpression("tan( )", 2)
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, dctNewPlot:=dctPlotFunctions, ucrNewAvailableDatafrane:=ucrSelectorByDataFrameAddRemoveAnovaModel.ucrAvailableDataFrames, bReset:=bResetOptionsSubDialog)
        sdgSimpleRegOptions.ShowDialog()
        bResetOptionsSubDialog = False
    End Sub

    ''' <summary>
    ''' Equivalent of dlgFitModel.ChooseRFunction: picks the base R function from the model type pull-down.
    ''' </summary>
    Public Sub ChooseRFunction()
        Select Case GetModelType()
            Case strModelLmer
                clsCurrentModelFunction = clsLmerFunction
            Case strModelLme
                clsCurrentModelFunction = clsLmeFunction
            Case strModelGlmer
                clsCurrentModelFunction = clsGlmerFunction
            Case Else
                clsCurrentModelFunction = clsAOVFunction
        End Select

        ucrBase.clsRsyntax.SetBaseRFunction(clsCurrentModelFunction)
    End Sub

    ''' <summary>
    ''' Builds the right-hand side of the formula. The second receiver holds the
    ''' Error() term for aov, or the random effects for lmer / lme / glmer.
    ''' </summary>
    Private Sub UpdateFormulaRhs()
        Dim strRhs As String = ucrReceiverExpressionAnovaModel.GetText().Trim()
        Dim strRandom As String = ucrReceiverErrorAnovaModel.GetText().Trim()

        clsLmeFunction.RemoveParameterByName("random")
        If strRhs = "" Then
            clsFormulaOperator.RemoveParameterByName("y")
            Exit Sub
        End If

        If strRandom <> "" Then
            Select Case GetModelType()
                Case strModelAov
                    'y ~ x + Error(block)
                    strRhs &= " + Error(" & strRandom & ")"
                Case strModelLmer, strModelGlmer
                    'y ~ x + (1 | block)
                    If strRandom.StartsWith("(") AndAlso strRandom.EndsWith(")") Then
                        strRhs &= " + " & strRandom
                    Else
                        strRhs &= " + (" & strRandom & ")"
                    End If
                Case strModelLme
                    'fixed = y ~ x, random = ~ 1 | block
                    If Not strRandom.StartsWith("~") Then
                        strRandom = "~ " & strRandom
                    End If
                    clsLmeFunction.AddParameter("random", strParameterValue:=strRandom, iPosition:=2)
            End Select
        End If
        clsFormulaOperator.AddParameter("y", strParameterValue:=strRhs, iPosition:=1)
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverAnovaResponseVar.IsEmpty Then
            Dim strPreview As String = clsFormulaOperator.ToScript()
            If GetModelType() = strModelLme AndAlso clsLmeFunction.ContainsParameter("random") Then
                strPreview &= ",  random = " & clsLmeFunction.GetParameter("random").strArgumentValue
            End If
            ucrInputModelPreview.SetName(strPreview)
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Private Sub ExpressionReceivers_Changed(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionAnovaModel.ControlValueChanged, ucrReceiverExpressionAnovaModel.ControlContentsChanged, ucrReceiverErrorAnovaModel.ControlValueChanged, ucrReceiverErrorAnovaModel.ControlContentsChanged
        UpdateFormulaRhs()
        ChooseOutputFunction()
        UpdatePreview()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputModelType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputModelType.ControlValueChanged
        If GetModelType() = strModelAov Then
            lblErrorModel.Text = "Error/Residuals:"
        Else
            lblErrorModel.Text = "Random Effects (e.g. 1|block):"
        End If
        ResponseConvert()
        ResponseVariableType()
        ChooseRFunction()
        UpdateFormulaRhs()
        ChooseOutputFunction()
        UpdatePreview()
        TestOKEnabled()
    End Sub

    ''' <summary>
    ''' anova() works for aov, lmer, lme and glmer. Only aov with an Error() term
    ''' needs summary() instead.
    ''' </summary>
    Private Sub ChooseOutputFunction()
        Dim bUseSummaryNow As Boolean = GetModelType() = strModelAov AndAlso
                                        Not ucrReceiverErrorAnovaModel.IsEmpty() AndAlso
                                        Not ucrReceiverExpressionAnovaModel.IsEmpty()
        If bUseSummaryNow = bUseSummaryOutput Then
            Exit Sub
        End If
        bUseSummaryOutput = bUseSummaryNow
        If bUseSummaryNow Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAnovaFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        End If
    End Sub

    Public Sub ResponseConvert()
        If Not bRCodeSet Then
            Exit Sub
        End If

        Dim bGlmer As Boolean = GetModelType() = strModelGlmer

        If Not ucrReceiverAnovaResponseVar.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorByDataFrameAddRemoveAnovaModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverAnovaResponseVar.GetVariableNames(bWithQuotes:=False))
            If ucrFamily.strDataType.Contains("factor") Then
                ucrChkConvertToVariate.Visible = True
            Else
                ucrChkConvertToVariate.Checked = False
                ucrChkConvertToVariate.Visible = False
            End If

            If ucrChkConvertToVariate.Checked Then
                clsFormulaOperator.AddParameter("x", clsRFunctionParameter:=clsRConvert, iPosition:=0)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsFormulaOperator.AddParameter("x", strParameterValue:=ucrReceiverAnovaResponseVar.GetVariableNames(bWithQuotes:=False), iPosition:=0)
                ucrFamily.RecieverDatatype(ucrReceiverAnovaResponseVar.strCurrDataType)
            End If

            If bGlmer Then
                'glmer: offer the glm families that suit the response type
                FilterFamilyDistributions(Function(strTag) Not lstNonGlmerFamilies.Contains(strTag))
            Else
                'aov / lmer / lme: Normal response only
                FilterFamilyDistributions(Function(strTag) strTag = strAovNameTag)
            End If
        Else
            ucrChkConvertToVariate.Visible = False
        End If

        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrReceiverAnovaResponseVar.IsEmpty() Then
            ucrFamily.Enabled = False
            ucrFamily.ucrInputDistributions.SetName("")
        Else
            ucrFamily.Enabled = True
        End If
        UpdatePreview()
        TestOKEnabled()
    End Sub

    Private Sub FilterFamilyDistributions(fnKeep As Func(Of String, Boolean))
        Dim lstDistributions = ucrFamily.lstCurrentDistributions
        Dim cboDistributions = ucrFamily.ucrInputDistributions.cboInput
        For i As Integer = lstDistributions.Count - 1 To 0 Step -1
            If Not fnKeep(lstDistributions(i).strNameTag) Then
                lstDistributions.RemoveAt(i)
                If i < cboDistributions.Items.Count Then
                    cboDistributions.Items.RemoveAt(i)
                End If
            End If
        Next
        'Show "aov" in the pull-down instead of the internal name "Normal_aov"
        Dim iSelected As Integer = cboDistributions.SelectedIndex
        For i As Integer = 0 To Math.Min(lstDistributions.Count, cboDistributions.Items.Count) - 1
            If lstDistributions(i).strNameTag = strAovNameTag Then
                cboDistributions.Items(i) = strModelAov
            End If
        Next
        If lstDistributions.Count > 0 Then
            cboDistributions.SelectedIndex = If(iSelected < 0 OrElse iSelected >= cboDistributions.Items.Count, 0, iSelected)
        End If
    End Sub

    Public Sub ResponseVariableType()
        If bRCodeSet Then
            If Not ucrReceiverAnovaResponseVar.IsEmpty() Then
                strVariableType = ucrFamily.strDataType
                If strVariableType.Contains("positive integer") Then
                    strVariableType = "positive integer"
                ElseIf strVariableType.Contains("integer") Then
                    strVariableType = "integer"
                ElseIf strVariableType.Contains("two level numeric") OrElse strVariableType.Contains("two level factor") Then
                    strVariableType = "binary"
                ElseIf strVariableType.Contains("numeric") Then
                    strVariableType = "numeric"
                ElseIf strVariableType.Contains("logical") Then
                    strVariableType = "logical"
                ElseIf strVariableType.Contains("factor") Then
                    strVariableType = "factor"
                Else
                    strVariableType = "unsuitable type"
                End If
                lblType.Text = strVariableType
                lblType.ForeColor = SystemColors.Highlight
            Else
                strVariableType = ""
                lblType.Text = "________"
                lblType.ForeColor = SystemColors.ControlText
            End If
        End If
        autoTranslate(Me)
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged
        ResponseVariableType()
        clsFamilyFunction.RemoveParameterByName("link")
    End Sub

    Private Sub ucrReceiverAnovaResponseVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnovaResponseVar.ControlValueChanged
        ResponseConvert()
        ResponseVariableType()
    End Sub

    Private Sub ucrChkConvertToVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertToVariate.ControlValueChanged
        ResponseConvert()
        ResponseVariableType()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkConvertToVariate.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class