' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgNewMarkovChains
    Public bFirstLoad As Boolean = True
    Private clsIfelseFunction As New RFunction
    Private clsRunCalcFunction As New RFunction
    Private clsWDCalcFunction As New RFunction
    Private clsLagFunction As New RFunction
    Private clsLagCalcFunction As New RFunction
    Private clsSubCalcsList As New RFunction
    Private clsOverallLagCalcFunction As New RFunction
    Private clsFormulaOp As New ROperator
    Private clsMarkovOp As New ROperator
    Private clsAdditionalOp As New ROperator
    Private clsGLMFunction As New RFunction
    Private clsAsFormula As New RFunction
    Private clsModelOutput As New RFunction

    Private Sub dlgNewMarkovChains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverStation.Selector = ucrSelectorMarkovChains
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverDate.Selector = ucrSelectorMarkovChains
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.Selector = ucrSelectorMarkovChains
        ucrReceiverDOY.bAutoFill = True

        'ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.Selector = ucrSelectorMarkovChains
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True

        ucrReceiverAdditionalVariables.Selector = ucrSelectorMarkovChains
        ucrBase.iHelpTopicID = 491
        ucrInputExcludeSep.SetItems({"Exclude", "Separate"})
        ucrInputMarkovType.SetItems({"Full", "Dry", "Both"})
        ucrInputInteractions.SetItems({"None", "All", "Both"})
        ucrInputOptions.SetItems({"No Interactions", "Interactions", "Both"})

        clsIfelseFunction.SetRCommand("ifelse")

        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsWDCalcFunction.SetRCommand("instat_calculation$new")
        clsWDCalcFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))

        clsLagFunction.SetRCommand("lag")
        clsWDCalcFunction.SetRCommand("instat_calculation$new")
        clsWDCalcFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))

        clsLagCalcFunction.SetRCommand("instat_calculation$new")
        clsLagCalcFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))

        clsSubCalcsList.SetRCommand("list")

        clsOverallLagCalcFunction.SetRCommand("instat_calculation$new")

        clsFormulaOp.SetOperation("~")

        clsGLMFunction.SetRCommand("glm")
        clsAsFormula.SetRCommand("as.formula")
    End Sub

    Private Sub SingleModelCheck()
        If nudSeasonalityTo.Value = nudSeasonalityFrom.Value AndAlso nudOrderTo.Value = nudOrderFrom.Value AndAlso ucrInputMarkovType.GetText <> "Both" AndAlso ucrInputInteractions.GetText <> "Both" AndAlso ucrInputOptions.GetText <> "Both" Then
            chkSaveModel.Enabled = True
        Else
            chkSaveModel.Enabled = False
            chkSaveModel.Checked = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorMarkovChains.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        nudSeasonalityFrom.Maximum = 6
        nudSeasonalityTo.Maximum = 6
        nudSeasonalityTo.Minimum = 0
        nudSeasonalityFrom.Minimum = 0
        nudSeasonalityFrom.Value = 3
        nudSeasonalityTo.Value = 3
        nudOrderTo.Minimum = 0
        nudSeasonalityFrom.Minimum = 0
        nudOrderFrom.Maximum = 10
        nudOrderTo.Maximum = 10
        nudOrderTo.Value = 2
        nudOrderTo.Value = 0
        chkSaveModel.Enabled = False
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso nudSeasonalityTo.Value >= nudSeasonalityFrom.Value Then
            If chkSaveModel.Enabled Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverStation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverStation.SelectionChanged, ucrReceiverRainfall.SelectionChanged, ucrReceiverDOY.SelectionChanged, ucrReceiverDate.SelectionChanged, ucrReceiverAdditionalVariables.SelectionChanged
        If ucrReceiverRainfall.IsEmpty() Then
        Else
            clsWDCalcFunction.AddParameter("calculated_from", "list(" & ucrSelectorMarkovChains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & ucrReceiverRainfall.GetVariableNames() & ")")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    'Private Sub ucrInputExcludeSep_NameChanged() Handles ucrInputExcludeSep.NameChanged, ucrInputInteractions.NameChanged, ucrInputMarkovType.NameChanged, ucrInputOptions.NameChanged, ucrInputSaveModel.NameChanged
    '    SingleModelCheck()
    'End Sub

    Private Sub grpSeasonalityHarmonics_TextChanged(sender As Object, e As EventArgs) Handles nudSeasonalityFrom.TextChanged, nudSeasonalityTo.TextChanged
        SingleModelCheck()
    End Sub

    Private Sub grpOrder_TextChanged(sender As Object, e As EventArgs) Handles nudOrderFrom.TextChanged, nudOrderTo.TextChanged
        SingleModelCheck()
    End Sub

    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged, chkGraph.CheckedChanged
        SingleModelCheck()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim clsLagCombineFunction As New RFunction
        Dim clsGreplFunction As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String = ""
        Dim strHarmonic As String = ""

        'Calculating RainDay
        clsLagCombineFunction.SetRCommand("str_c")
        clsGreplFunction.SetRCommand("grepl")
        clsGreplFunction.AddParameter("pattern", Chr(39) & "NA" & Chr(39))
        clsIfelseFunction.AddParameter("test", ucrReceiverRainfall.GetVariableNames(False) & "> 0.85")
        clsIfelseFunction.AddParameter("yes", "'W'")
        clsIfelseFunction.AddParameter("no", "'D'")

        clsWDCalcFunction.AddParameter("function_exp", Chr(34) & clsIfelseFunction.ToScript() & Chr(34))
        clsWDCalcFunction.AddParameter("save", 2)
        clsWDCalcFunction.SetAssignTo("RainDay")
        clsWDCalcFunction.AddParameter("result_name", Chr(34) & "RainDay" & Chr(34))
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsWDCalcFunction)
        clsRunCalcFunction.AddParameter("display", "FALSE")
        strTemp = clsRunCalcFunction.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strTemp)

        'Calculating Lag n
        clsLagFunction.AddParameter("x", "RainDay")
        clsRunCalcFunction.ClearParameters()
        'clsSubCalcsList.AddParameter("Lag" & 0, clsRFunctionParameter:=clsWDCalcFunction.Clone(), iPosition:=0, bIncludeArgumentName:=False)
        clsLagCombineFunction.AddParameter("Lag" & 0, "RainDay", iPosition:=0, bIncludeArgumentName:=False)
        For i As Integer = 1 To nudOrderTo.Value - 1
            clsLagFunction.AddParameter("n", i)
            clsLagFunction.AddParameter("order_by", ucrReceiverDate.GetVariableNames(False))
            clsLagCalcFunction.AddParameter("function_exp", Chr(34) & clsLagFunction.ToScript() & Chr(34))
            clsLagCalcFunction.AddParameter("calculated_from", "list(" & ucrSelectorMarkovChains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & Chr(34) & "RainDay" & Chr(34) & ", " & ucrSelectorMarkovChains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & ucrReceiverDate.GetVariableNames() & ")")
            clsLagCalcFunction.AddParameter("save", 0)
            clsLagCalcFunction.SetAssignTo("Lag" & i)
            clsLagCalcFunction.AddParameter("result_name", Chr(34) & "Lag" & i & Chr(34))
            clsLagCombineFunction.AddParameter("Lag" & i, "Lag" & i, iPosition:=i, bIncludeArgumentName:=False)
            clsSubCalcsList.AddParameter("Lag" & i, clsRFunctionParameter:=clsLagCalcFunction.Clone(), iPosition:=i, bIncludeArgumentName:=False)
        Next
        clsGreplFunction.AddParameter("x", clsRFunctionParameter:=clsLagCombineFunction)
        clsIfelseFunction.AddParameter("test", clsRFunctionParameter:=clsGreplFunction)
        clsIfelseFunction.AddParameter("yes", "NA")
        clsIfelseFunction.AddParameter("no", clsRFunctionParameter:=clsLagCombineFunction)

        clsOverallLagCalcFunction.AddParameter("function_exp", Chr(34) & clsIfelseFunction.ToScript() & Chr(34))
        clsOverallLagCalcFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcsList.Clone())
        clsOverallLagCalcFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsOverallLagCalcFunction.AddParameter("save", 2)
        clsOverallLagCalcFunction.AddParameter("result_name", Chr(34) & "Order" & nudOrderTo.Value & Chr(34))
        clsOverallLagCalcFunction.SetAssignTo("Order" & nudOrderTo.Value)
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsOverallLagCalcFunction)
        clsRunCalcFunction.AddParameter("display", "FALSE")
        strScript = ""
        strTemp = clsRunCalcFunction.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strTemp)

        'Creating formula
        clsFormulaOp.AddParameter("Left", "factor(RainDay)", iPosition:=0)

        For i As Integer = 1 To nudSeasonalityTo.Value
            If i > 1 Then
                strHarmonic = strHarmonic & " + "
            End If
            strHarmonic = strHarmonic & "cos(" & ucrReceiverDOY.GetVariableNames(False) & " * " & i & " * 2* (pi/366) ) + sin( " & ucrReceiverDOY.GetVariableNames(False) & " * " & i & " * 2 * pi/366)"
        Next

        clsMarkovOp.AddParameter("Left", strHarmonic, iPosition:=0)
        clsMarkovOp.AddParameter("Right", "Order" & nudOrderTo.Value, iPosition:=1)
        If ucrReceiverAdditionalVariables.IsEmpty Then
            clsFormulaOp.AddParameter("Right", clsROperatorParameter:=clsMarkovOp, iPosition:=1)
        Else
            clsAdditionalOp.AddParameter("Left", clsROperatorParameter:=clsMarkovOp, iPosition:=0)
            clsAdditionalOp.AddParameter("Right", ucrReceiverAdditionalVariables.GetVariableNames(False))
            clsFormulaOp.AddParameter("Right", clsROperatorParameter:=clsAdditionalOp, iPosition:=1)
        End If

        'Creating model
        clsAsFormula.AddParameter("object", clsROperatorParameter:=clsFormulaOp)
        clsGLMFunction.AddParameter("formula", clsRFunctionParameter:=clsAsFormula)
        clsGLMFunction.AddParameter("family", "binomial")
        clsGLMFunction.AddParameter("weights", "NULL")
        clsGLMFunction.AddParameter("na.action", "na.exclude")
        clsGLMFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorMarkovChains.ucrAvailableDataFrames.clsCurrDataFrame)
        clsGLMFunction.SetAssignTo("MarkovModel")

        'Output from model
        clsModelOutput.SetRCommand("summary")
        clsModelOutput.AddParameter("object", clsRFunctionParameter:=clsGLMFunction)
        strScript = ""
        strTemp = clsModelOutput.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strTemp, 2)

        clsModelOutput.SetRCommand("anova")
        clsModelOutput.AddParameter("object", clsRFunctionParameter:=clsGLMFunction)
        strScript = ""
        strTemp = clsModelOutput.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strTemp, 2)
    End Sub

    Private Sub ucrInputInteractions_NameChanged() Handles ucrInputInteractions.NameChanged
        Select Case ucrInputInteractions.GetText()
            Case "None"
                clsMarkovOp.SetOperation("+")
            Case "All"
                clsMarkovOp.SetOperation("*")
            Case "Both"
        End Select
        TestOkEnabled()
        SingleModelCheck()
    End Sub

    Private Sub ucrInputOptions_NameChanged() Handles ucrInputOptions.NameChanged
        Select Case ucrInputOptions.GetText()
            Case "No Interactions"
                clsAdditionalOp.SetOperation("+")
            Case "Interactions"
                clsAdditionalOp.SetOperation("*")
            Case "Both"

        End Select
        TestOkEnabled()
        SingleModelCheck()
    End Sub
End Class