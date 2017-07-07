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
    Public clsFormulaOperator As New ROperator

    Public clsRestpvalFunction, clsFamilyFunction, clsLM, clsConfint, clsAnovaFunction, clsSummaryFunction, clsFormulaFunction, clsRCIFunction, clsRConvert, clsAutoPlot, clsVisReg As New RFunction
    Public bResetModelOptions As Boolean = False
    Public bResetSubDialog As Boolean = False
    Public bResetOptionsSubDialog As Boolean = False

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

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrModelName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("gen_model")
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetCheckBoxText("Save Model:")
        ucrModelName.SetIsComboBox()
        ucrModelName.SetAssignToIfUncheckedValue("last_model")


        ucrSelectorByDataFrameAddRemoveForFitModel.SetParameter(New RParameter("data", 0))
        ucrSelectorByDataFrameAddRemoveForFitModel.SetParameterIsrfunction()

        ucrReceiverResponseVar.SetParameter(New RParameter("x", 0))
        ucrReceiverResponseVar.SetParameterIsRFunction()

        ucrConvertToVariate.AddParameterIsRFunctionCondition(True, "x", True)
        ucrConvertToVariate.AddParameterIsRFunctionCondition(False, "x", False)

        ucrReceiverExpressionFitModel.SetParameter(New RParameter("y", 1))
        ucrReceiverExpressionFitModel.SetParameterIsString()
        ucrReceiverExpressionFitModel.bWithQuotes = False

        ucrConvertToVariate.AddFunctionNamesCondition(True, "as.numeric")
        ucrConvertToVariate.SetText("Convert to Variate")

        ucrBase.iHelpTopicID = 371
        ucrFamily.SetGLMDistributions()
        ucrFamily.SetFunctionIsDistFunction()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverResponseVar.SetRCode(clsRConvert, bReset)
        ucrConvertToVariate.SetRCode(clsFormulaOperator, bReset)
        ucrReceiverExpressionFitModel.SetRCode(clsFormulaOperator, bReset)
        ucrSelectorByDataFrameAddRemoveForFitModel.SetRCode(clsLM, bReset)
        ucrModelName.SetRCode(clsLM, bReset)
        ucrFamily.SetRCode(clsFamilyFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()
        clsRCIFunction = New RFunction
        clsRConvert = New RFunction
        clsSummaryFunction = New RFunction
        clsRestpvalFunction = New RFunction
        clsAutoPlot = New RFunction
        clsFormulaFunction = New RFunction
        clsLM = New RFunction
        clsConfint = New RFunction
        clsAnovaFunction = New RFunction
        clsVisReg = New RFunction
        clsFamilyFunction = New RFunction

        ucrSelectorByDataFrameAddRemoveForFitModel.Reset()
        ucrReceiverResponseVar.SetMeAsReceiver()
        ucrSelectorByDataFrameAddRemoveForFitModel.Focus()

        clsRConvert.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrReceiverExpressionFitModel.Clear()
        ucrReceiverExpressionFitModel.Selector = ucrSelectorByDataFrameAddRemoveForFitModel
        ucrReceiverResponseVar.Selector = ucrSelectorByDataFrameAddRemoveForFitModel
        ucrReceiverResponseVar.SetMeAsReceiver()

        ucrInputModelPreview.SetName("")
        ucrInputModelPreview.IsReadOnly = True

        clsFamilyFunction = ucrFamily.clsCurrRFunction
        clsLM.AddParameter("family", clsRFunctionParameter:=clsFamilyFunction)

        clsLM = clsRegressionDefaults.clsDefaultLmFunction.Clone
        clsLM.AddParameter("formula", clsROperatorParameter:=clsFormulaOperator, iPosition:=1)

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

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.iCallType = 3

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.iCallType = 2

        'Anova + Pvalue
        clsRestpvalFunction = clsRegressionDefaults.clsDefaultRaovPValueFunction.Clone
        clsRestpvalFunction.AddParameter("", clsRFunctionParameter:=clsLM)
        clsRestpvalFunction.iCallType = 2
        'sdgSimpleRegOptions.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)

        sdgSimpleRegOptions.SetRDataFrame(ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames)

        ResponseConvert()

        ChooseRFunction()
        ' sdgSimpleRegOptions.chkDisplayCLimits.Enabled = True
        sdgSimpleRegOptions.lblConfLevel.Enabled = True
        'sdgSimpleRegOptions.nudDisplayCLevel.Enabled = True

        bResetSubDialog = True
        bResetOptionsSubDialog = True

        clsLM.SetAssignTo(ucrModelName.GetText, strTempDataframe:=ucrSelectorByDataFrameAddRemoveForFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsLM)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)
        bResetModelOptions = True
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverResponseVar.IsEmpty AndAlso Not ucrReceiverExpressionFitModel.IsEmpty Then
            ucrInputModelPreview.SetName(clsFormulaOperator.ToScript())
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverResponseVar.IsEmpty()) AndAlso (Not ucrReceiverExpressionFitModel.IsEmpty()) AndAlso Not ucrFamily.ucrInputDistributions.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Private Sub ucrReceiverExpressionFitModel_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverExpressionFitModel.SelectionChanged
    '    clsLM.AddParameter(strParameterValue:=ucrReceiverExpressionFitModel.GetVariableNames(False))
    '    TestOKEnabled()
    'End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
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
        sdgModelOptions.SetRCodeForControls(ucrFamily, clsFamilyFunction, bResetModelOptions)
        sdgModelOptions.ShowDialog()
        bResetModelOptions = False

        ucrFamily.ucrInputDistributions.cboInput.SelectedIndex = ucrFamily.lstCurrentDistributions.FindIndex(Function(dist) dist.strNameTag = sdgModelOptions.ucrDistributionChoice.clsCurrDistribution.strNameTag)
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewAutoplot:=clsAutoPlot, clsNewVisReg:=clsVisReg, clsNewConfint:=clsConfint, bReset:=bResetOptionsSubDialog)
        sdgSimpleRegOptions.ShowDialog()
        bResetOptionsSubDialog = False

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
                ' clsRConvert.AddParameter("x", ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False))
                clsFormulaOperator.AddParameter("x", clsRFunctionParameter:=clsRConvert, iPosition:=0)
                ucrFamily.RecieverDatatype("numeric")
            Else
                clsFormulaOperator.AddParameter("x", strParameterValue:=ucrReceiverResponseVar.GetVariableNames(bWithQuotes:=False), iPosition:=0)
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

    Public Sub ChooseRFunction()
        clsRCIFunction.SetRCommand(ucrFamily.clsCurrDistribution.strGLMFunctionName)
        clsFormulaFunction.AddParameter("x", clsRFunctionParameter:=clsLM)
        clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsLM)
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsLM)
        clsConfint.AddParameter("object", clsRFunctionParameter:=clsLM)
        clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsLM)
        clsAutoPlot.AddParameter("object", clsRFunctionParameter:=clsLM)
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.ControlValueChanged
        ChooseRFunction()
    End Sub

    Private Sub ucrReceiverResponseVar_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverResponseVar.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverExpressionFitModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionFitModel.ControlValueChanged, ucrReceiverResponseVar.ControlValueChanged
        ResponseConvert()
    End Sub

    Private Sub ucrConvertToVariate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrConvertToVariate.ControlValueChanged
        ResponseConvert()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverExpressionFitModel_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionFitModel.ControlContentsChanged, ucrReceiverResponseVar.ControlContentsChanged
        UpdatePreview()
        TestOKEnabled()
    End Sub
End Class