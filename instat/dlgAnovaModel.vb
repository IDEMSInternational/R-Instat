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

    Private Const strAovNameTag As String = "Normal_aov"

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

        'Model: aov
        clsAOVFunction = clsRegressionDefaults.clsDefaultAovFunction.Clone()
        clsAOVFunction.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=0)
        clsAOVFunction.AddParameter("na.action", "na.exclude", iPosition:=4)
        clsAOVFunction.bExcludeAssignedFunctionOutput = False
        clsAOVFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveAnovaModel.strCurrentDataFrame,
                                           strObjectName:="last_model")

        'Residual Plots
        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        'Model
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.bExcludeAssignedFunctionOutput = False

        'Summary. For aov this is the ANOVA table
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.bExcludeAssignedFunctionOutput = False

        'ANOVA. Only used by the Display Options sub dialog, not part of the default output
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.bExcludeAssignedFunctionOutput = False

        'Model plot
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "FALSE")
        clsVisReg.bExcludeAssignedFunctionOutput = False

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.bExcludeAssignedFunctionOutput = False

        bResetOptionsSubDialog = True

        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsAOVFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 1)

        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrModelName.ControlValueChanged
        Dim strModel As String = clsAOVFunction.GetRObjectToAssignTo()

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
        ucrSelectorByDataFrameAddRemoveAnovaModel.SetRCode(clsAOVFunction, bReset)
        ucrModelName.SetRCode(clsAOVFunction, bReset)
        ucrChkConvertToVariate.SetRCode(clsFormulaOperator, bReset)
        ucrReceiverAnovaResponseVar.SetRCode(clsRConvert, bReset)
        bRCodeSet = True
        ResponseConvert()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverAnovaResponseVar.IsEmpty()) AndAlso (Not ucrReceiverExpressionAnovaModel.IsEmpty()) AndAlso Not ucrFamily.ucrInputDistributions.IsEmpty Then
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


    Private Sub UpdateFormulaRhs()
        Dim strRhs As String = ucrReceiverExpressionAnovaModel.GetText().Trim()
        If strRhs = "" Then
            clsFormulaOperator.RemoveParameterByName("y")
            Exit Sub
        End If
        Dim strError As String = ucrReceiverErrorAnovaModel.GetText().Trim()
        If strError <> "" Then
            strRhs &= " + Error(" & strError & ")"
        End If
        clsFormulaOperator.AddParameter("y", strParameterValue:=strRhs, iPosition:=1)
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverAnovaResponseVar.IsEmpty Then
            ucrInputModelPreview.SetName(clsFormulaOperator.ToScript())
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Private Sub ExpressionReceivers_Changed(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionAnovaModel.ControlValueChanged, ucrReceiverExpressionAnovaModel.ControlContentsChanged, ucrReceiverErrorAnovaModel.ControlValueChanged, ucrReceiverErrorAnovaModel.ControlContentsChanged
        UpdateFormulaRhs()
        UpdatePreview()
        TestOKEnabled()
    End Sub

    Public Sub ResponseConvert()
        If Not bRCodeSet Then
            Exit Sub
        End If

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
            RestrictFamilyToAov()
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

    Private Sub RestrictFamilyToAov()
        Dim lstDistributions = ucrFamily.lstCurrentDistributions
        Dim cboDistributions = ucrFamily.ucrInputDistributions.cboInput
        For i As Integer = lstDistributions.Count - 1 To 0 Step -1
            If lstDistributions(i).strNameTag <> strAovNameTag Then
                lstDistributions.RemoveAt(i)
                If i < cboDistributions.Items.Count Then
                    cboDistributions.Items.RemoveAt(i)
                End If
            End If
        Next
        If lstDistributions.Count > 0 Then
            cboDistributions.SelectedIndex = 0
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