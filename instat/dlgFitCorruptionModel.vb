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

Public Class dlgFitCorruptionModel
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetDisplayOptions As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsCorruptionModel, clsBinomialModel As New RFunction
    Private clsFormula, clsExplanatoryVariables As New ROperator
    'Function for display sub dialog
    Public clsVisReg, clsAutoPlot, clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction

    Private Sub dlgFitCorruptionModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 529
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrInputModelPreview.IsReadOnly = True

        'Selector
        ucrSelectorFitModel.SetParameter(New RParameter("data", 0))
        ucrSelectorFitModel.SetParameterIsrfunction()

        'Receivers
        ucrReceiverOutput.SetParameter(New RParameter("output", 0))
        ucrReceiverOutput.SetParameterIsRFunction()
        ucrReceiverOutput.Selector = ucrSelectorFitModel
        ucrReceiverOutput.SetIncludedDataTypes({"integer", "numeric", "logical"})
        ucrReceiverOutput.strSelectorHeading = "Numeric & Logical Output Variables"
        ucrReceiverOutput.AddIncludedMetadataProperty("Is_Corruption_Risk_Output", {"TRUE"})

        ucrReceiverControlVariables.SetParameter(New RParameter("x", 2))
        ucrReceiverControlVariables.SetParameterIsString()
        ucrReceiverControlVariables.Selector = ucrSelectorFitModel

        ucrReceiverIndicators.SetParameter(New RParameter("z", 3))
        ucrReceiverIndicators.SetParameterIsString()
        ucrReceiverIndicators.Selector = ucrSelectorFitModel

        'ucrSave
        ucrSaveCorruptionModel.SetPrefix("Corruption_Model")
        ucrSaveCorruptionModel.SetSaveTypeAsModel()
        ucrSaveCorruptionModel.SetDataFrameSelector(ucrSelectorFitModel.ucrAvailableDataFrames)
        ucrSaveCorruptionModel.SetCheckBoxText("Save Model")
        ucrSaveCorruptionModel.SetIsComboBox()
        ucrSaveCorruptionModel.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsCorruptionModel = New RFunction
        clsFormulaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsConfint = New RFunction
        clsVisReg = New RFunction
        clsAutoPlot = New RFunction
        clsAnovaFunction = New RFunction
        clsBinomialModel = New RFunction
        clsExplanatoryVariables = New ROperator
        clsFormula = New ROperator

        clsBinomialModel.SetRCommand("binomial")
        clsBinomialModel.AddParameter("link", Chr(34) & "logit" & Chr(34))

        clsExplanatoryVariables.SetOperation("+")

        clsFormula.SetOperation("~")
        clsFormula.AddParameter("input", clsROperatorParameter:=clsExplanatoryVariables, iPosition:=1)

        'Residual Plots
        clsAutoPlot = clsRegressionDefaults.clsDefaultAutoplot.Clone

        ucrReceiverOutput.SetMeAsReceiver()

        'Reset 
        ucrSelectorFitModel.Reset()
        ucrSaveCorruptionModel.Reset()
        ucrInputModelPreview.SetName("")

        'Residual Plots
        clsAutoPlot = clsRegressionDefaults.clsDefaultAutoplot.Clone
        clsAutoPlot.AddParameter("object", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)

        'Display formula
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.iCallType = 2
        clsFormulaFunction.AddParameter("x", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)

        'Summary
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.iCallType = 2
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)

        'ANOVA
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.iCallType = 2
        clsAnovaFunction.AddParameter("object", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.iCallType = 2
        clsConfint.AddParameter("object", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.iCallType = 3
        clsVisReg.AddParameter("fit", clsRFunctionParameter:=clsCorruptionModel, iPosition:=0)


        clsCorruptionModel.SetRCommand("glm")
        clsCorruptionModel.AddParameter("formula", clsROperatorParameter:=clsFormula)
        clsCorruptionModel.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseRFunction(clsCorruptionModel)

        ucrBase.clsRsyntax.AddToAfterCodes(clsAnovaFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAutoPlot, 5)

        bResetDisplayOptions = True
        SetBaseFunction()
        UpdateModelPreview()
    End Sub

    Private Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverControlVariables.Add(strSelectedColumn, strSelectedDataFrame)
        ucrReceiverIndicators.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorFitModel.SetRCode(clsCorruptionModel, bReset)
        ucrReceiverOutput.SetRCode(clsFormula, bReset)
        ucrSaveCorruptionModel.SetRCode(clsCorruptionModel, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverOutput.IsEmpty AndAlso (Not ucrReceiverIndicators.IsEmpty OrElse Not ucrReceiverControlVariables.IsEmpty) AndAlso ucrSaveCorruptionModel.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If Not ucrReceiverOutput.IsEmpty Then
            If frmMain.clsRLink.IsBinary(ucrSelectorFitModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text, ucrReceiverOutput.GetVariableNames(False)) Then
                clsCorruptionModel.SetRCommand("glm")
                clsCorruptionModel.AddParameter("family", clsRFunctionParameter:=clsBinomialModel)
            Else
                clsCorruptionModel.SetRCommand("lm")
                clsCorruptionModel.RemoveParameterByName("family")
            End If
        End If
    End Sub

    Private Sub SetFormula()
        Dim i As Integer = 0
        If Not ucrReceiverOutput.IsEmpty AndAlso (Not ucrReceiverIndicators.IsEmpty OrElse Not ucrReceiverControlVariables.IsEmpty) Then
            clsExplanatoryVariables.ClearParameters()
            For Each strControlVar As String In ucrReceiverControlVariables.GetVariableNamesAsList
                clsExplanatoryVariables.AddParameter(i, strControlVar, iPosition:=i)
                i = i + 1
            Next
            For Each strIndicatorVar As String In ucrReceiverIndicators.GetVariableNamesAsList
                clsExplanatoryVariables.AddParameter(i, strIndicatorVar, iPosition:=i)
                i = i + 1
            Next
        End If
        UpdateModelPreview()
    End Sub

    Private Sub UpdateModelPreview()
        If Not ucrReceiverOutput.IsEmpty Then
            ucrInputModelPreview.SetName(clsFormula.ToScript)
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOutput.ControlContentsChanged, ucrReceiverIndicators.ControlContentsChanged, ucrReceiverControlVariables.ControlContentsChanged, ucrSaveCorruptionModel.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, clsNewAutoplot:=clsAutoPlot, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        bResetDisplayOptions = False
    End Sub

    Private Sub ucrReceiverOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOutput.ControlValueChanged, ucrReceiverControlVariables.ControlValueChanged, ucrReceiverIndicators.ControlValueChanged
        SetBaseFunction()
        SetFormula()
    End Sub
End Class