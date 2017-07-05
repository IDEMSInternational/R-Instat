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
Public Class dlgFitModel
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public clsRCIFunction, clsRConvert As New RFunction
    Private clsFormulaOperator As New ROperator
    Private clsFormulaFunction As New RFunction
    Private clsSummaryFunction As New RFunction
    Private clsAnovaFunction As New RFunction
    Private clsConfint As New RFunction
    Private clsRestpvalFunction, clsLM As New RFunction

    Private Sub dlgFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverResponseVar.SetRCode(clsRConvert, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrModelName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("reg")
        ucrModelName.SetIsComboBox()
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetAssignToIfUncheckedValue("last_model")
        ucrModelName.SetCheckBoxText("Save Model:")


        ucrSelectorByDataFrameAddRemoveForFitModel.SetParameter(New RParameter("data", 0))
        ucrSelectorByDataFrameAddRemoveForFitModel.SetParameterIsrfunction()

        ucrReceiverResponseVar.SetParameter(New RParameter("x", 0))
        ucrReceiverResponseVar.SetParameterIsRFunction()

        ucrConvertToVariate.AddParameterIsRFunctionCondition(True, "x", True)
        ucrConvertToVariate.AddParameterIsRFunctionCondition(False, "x", False)

        ucrConvertToVariate.AddFunctionNamesCondition(True, "as.numeric")
        ucrConvertToVariate.SetText("Convert to Variate")

        ucrBase.iHelpTopicID = 371
        ucrFamily.SetGLMDistributions()


    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator
        clsRCIFunction = New RFunction
        clsRConvert = New RFunction
        clsSummaryFunction = New RFunction
        clsRestpvalFunction = New RFunction


        ucrSelectorByDataFrameAddRemoveForFitModel.Reset()
        ucrReceiverResponseVar.SetMeAsReceiver()
        ucrSelectorByDataFrameAddRemoveForFitModel.Focus()

        clsRConvert.SetRCommand("as.numeric")


        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrReceiverExpressionFitModel.Clear()
        ucrReceiverExpressionFitModel.Selector = ucrSelectorByDataFrameAddRemoveForFitModel
        ucrReceiverResponseVar.Selector = ucrSelectorByDataFrameAddRemoveForFitModel
        ucrReceiverResponseVar.SetMeAsReceiver()

        ucrInputModelPreview.IsReadOnly = True

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)


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
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=clsLM)

        'sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)

        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames)

        'sdgSimpleRegOptions.SetRYVariable(ucrReceiverResponseVar)
        'sdgVariableTransformations.SetRYVariable(ucrReceiverResponseVar)
        'sdgVariableTransformations.SetRModelOperator(clsModel)
        'sdgModelOptions.SetRCIFunction(clsRCIFunction)
        'sdgVariableTransformations.SetRCIFunction(clsRCIFunction)
        AssignModelName()
        ucrModelName.SetName("reg")
        'sdgSimpleRegOptions.SetDefaults()
        ResponseConvert()
        ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        sdgSimpleRegOptions.lblConfLevel.Enabled = True
        'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverResponseVar.IsEmpty()) AndAlso (Not ucrReceiverExpressionFitModel.IsEmpty()) Then
            'ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsModel)
            ucrBase.OKEnabled(True)
            'ucrInputModelPreview.SetName(clsModel.ToScript)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrReceiverExpressionFitModel_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExpressionFitModel.SelectionChanged
        clsLM.AddParameter(strParameterValue:=ucrReceiverExpressionFitModel.GetVariableNames(False))
        TestOKEnabled()
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("0")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpressionFitModel.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        ucrReceiverExpressionFitModel.AddToReceiverAtCursorPosition("tan( )", 2)
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgModelOptions.ShowDialog()
        ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.ShowDialog()
    End Sub


    Private Sub ucrReceiverResponseVar_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverResponseVar.SelectionChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Public Sub ResponseConvert()
        If Not ucrReceiverResponseVar.IsEmpty Then
            ucrFamily.RecieverDatatype(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False))

            If ucrFamily.strDataType = "numeric" Then
                ucrConvertToVariate.Checked = False
                ucrConvertToVariate.Visible = False
            Else
                ucrConvertToVariate.Visible = True
            End If

            If ucrConvertToVariate.Checked Then
                'clsRConvert.AddParameter("x", ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False))
                clsFormulaOperator.AddParameter("x", iPosition:=0, clsRFunctionParameter:=clsRConvert)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsFormulaOperator.AddParameter("x", iPosition:=0, strParameterValue:=ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False))
                ucrFamily.RecieverDatatype(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False))
            End If
            sdgModelOptions.ucrDistributionChoice.RecieverDatatype(ucrFamily.strDataType)
        End If

        If ucrFamily.lstCurrentDistributions.Count = 0 Or ucrReceiverResponseVar.IsEmpty() Then
            ucrFamily.Enabled = False
            ucrFamily.ucrInputDistributions.SetName("")
            cmdModelOptions.Enabled = False
        Else
            ucrFamily.Enabled = True
            cmdModelOptions.Enabled = True
        End If
    End Sub
    Private Sub ucrReceiveResponseVar_SelectionChanged() Handles ucrReceiverResponseVar.SelectionChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub chkConvertToVariate_CheckedChanged(sender As Object, e As EventArgs)
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ucrModelName_NameChanged()
        AssignModelName()
        TestOKEnabled()
    End Sub

    Private Sub AssignModelName()
        If ucrModelName.ucrChkSave.Checked AndAlso Not ucrModelName.IsComplete Then
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Public Sub ChooseRFunction()
        sdgModelOptions.ucrDistributionChoice.RecieverDatatype(ucrFamily.strDataType)
        sdgModelOptions.ucrDistributionChoice.ucrInputDistributions.cboInput.SelectedIndex = sdgModelOptions.ucrDistributionChoice.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = ucrFamily.clsCurrDistribution.strNameTag)
        sdgModelOptions.SetLinkFunctionsAvailable()
        'TODO:   Include multinomial as an option And the appropriate function
        'If (ucrFamily.clsCurrDistribution.strNameTag = "Normal") Then
        '    ucrBase.clsRsyntax.SetFunction("lm")
        '    ucrBase.clsRsyntax.RemoveParameter("family")
        'ElseIf (ucrFamily.clsCurrDistribution.strNameTag = "Normal" And ucrInputModelOperators2.GetText = "|") Then
        '    ucrBase.clsRsyntax.SetFunction("lmer")
        '    ucrBase.clsRsyntax.RemoveParameter("family")
        'ElseIf (ucrFamily.clsCurrDistribution.strNameTag <> "Normal" And ucrInputModelOperators2.GetText = "|") Then
        '    clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        '    ucrBase.clsRsyntax.SetFunction("glmer")
        '    ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        'Else

        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        ucrBase.clsRsyntax.SetFunction("glm")
        ucrBase.clsRsyntax.AddParameter("family", clsRFunctionParameter:=clsRCIFunction)
        'End If
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.ControlValueChanged
        ChooseRFunction()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'sdgSimpleRegOptions.RegOptions()
    End Sub
End Class