﻿' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Imports RDotNet
Public Class dlgDescribeTwoVarGraph
    Public strSecondVarType As String
    Public strVarType As String
    Private clsRGGplotFunction As New RFunction
    Private clsRBoxPlotGeom, clsRBoxPlotFacet, clsRScatterPlotGeom, clsRLinePlotGeom, clsRBarDotPlotFacet As New RFunction
    Private clsRBoxAesFunction, clsRScatterAesFunction, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarDotAesFunction As New RFunction
    Public clsRSummaryAesFunction, clsRStatSummary, clsRSummaryPlotFacet As New RFunction
    Dim clsRGGBoxPlot, clsRGGBarDotPlot, clsRGGSummaryPlot As New ROperator
    Private bFirstLoad As Boolean = True
    Private Sub dlgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        clsRBoxAesFunction.ClearParameters()
        clsRScatterAesFunction.ClearParameters()
        ucrTwoVarGraphSave.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrSelectorTwoVarGraph.Focus()
        sdgDescribeTwoVarGraph.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRGGplotFunction.SetRCommand("ggplot")
        ucrReceiverMultipleTwoVar.SetSelector(ucrSelectorTwoVarGraph)
        ucrReceiverMultipleTwoVar.SetSingleTypeStatus(True)
        ucrReceiverMultipleTwoVar.SetMultipleOnlyStatus(True)
        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrTwoVarGraphSave.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrTwoVarGraphSave.strPrefix = "TwoVaribleGraph"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverMultipleTwoVar.IsEmpty AndAlso Not ucrSecondVariableReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
            Results()
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load() Handles ucrTwoVarGraphSave.GraphNameChanged, ucrTwoVarGraphSave.SaveGraphCheckedChanged
        If ucrTwoVarGraphSave.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrTwoVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrTwoVarGraphSave.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgDescribeTwoVarGraph.GrpBoxEnable()
        sdgDescribeTwoVarGraph.ShowDialog()
    End Sub

    Public Sub Results()
        sdgDescribeTwoVarGraph.GrpBoxEnable()
        If ucrReceiverMultipleTwoVar.ucrMultipleVariables.GetCurrentItemTypes.Count > 0 Then
            strVarType = ucrReceiverMultipleTwoVar.ucrMultipleVariables.GetCurrentItemTypes.Item(0)
        Else
            strVarType = ""
        End If
        strSecondVarType = ucrSecondVariableReceiver.strCurrDataType
        If ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            ScatterLinePlot()
            If sdgDescribeTwoVarGraph.rdoScatterPlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRGGplotFunction)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRScatterPlotGeom)
            ElseIf sdgDescribeTwoVarGraph.rdoLinePlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRGGplotFunction)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRLinePlotGeom)
            End If
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "factor")) Then
            BoxPlot()
            If sdgDescribeTwoVarGraph.rdoBoxPlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsRGGBoxPlot)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBoxPlotFacet)
            End If
        ElseIf ((strVarType = "factor") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            SummaryPlot()
            If sdgDescribeTwoVarGraph.rdoSummaryPlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsRGGSummaryPlot)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRSummaryPlotFacet)
            End If
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            BarDotPlot()
            If sdgDescribeTwoVarGraph.rdoDotPlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsRGGBarDotPlot)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDotPlotGeom)
            ElseIf sdgDescribeTwoVarGraph.rdoBarPlot.Checked Then
                ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsRGGBarDotPlot)
                ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBarPlotGeom)
            End If
        End If
    End Sub

    Private Sub ucrSelectorTwoVarGraph_DataFrameChanged() Handles ucrSelectorTwoVarGraph.DataFrameChanged
        clsRGGplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrSecondVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondVariableReceiver.SelectionChanged
        clsRBoxAesFunction.AddParameter("fill", ucrSecondVariableReceiver.GetVariableNames(False))
        clsRScatterAesFunction.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
        clsRBarDotAesFunction.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
        clsRSummaryAesFunction.AddParameter("y", ucrSecondVariableReceiver.GetVariableNames(False))
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleTwoVar_SelectionChanged() Handles ucrReceiverMultipleTwoVar.SelectionChanged
        TestOkEnabled()
    End Sub

    Private Sub BoxPlot()
        clsRGGBoxPlot.SetOperation("+")
        clsRBoxPlotGeom.SetRCommand("geom_boxplot")
        clsRBoxAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction)
        clsRBoxAesFunction.AddParameter("x", Chr(34) & "" & Chr(34))
        clsRBoxAesFunction.AddParameter("y", "value")
        clsRBoxPlotFacet.SetRCommand("facet_wrap")
        clsRBoxPlotFacet.AddParameter("", "~variable")
        clsRGGBoxPlot.SetParameter(True, clsRFunc:=clsRGGplotFunction)
        clsRGGBoxPlot.SetParameter(False, clsRFunc:=clsRBoxPlotGeom)
    End Sub

    Private Sub ScatterLinePlot()
        clsRScatterPlotGeom.SetRCommand("geom_point")
        clsRLinePlotGeom.SetRCommand("geom_line")
        clsRScatterAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
        clsRScatterAesFunction.AddParameter("y", "value")
        clsRScatterAesFunction.AddParameter("colour", "variable")
    End Sub

    Private Sub BarDotPlot()
        clsRGGBarDotPlot.SetOperation("+")
        clsRDotPlotGeom.SetRCommand("geom_dotplot")
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarDotAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBarDotAesFunction)
        clsRBarDotAesFunction.AddParameter("fill", "value")
        clsRBarDotPlotFacet.SetRCommand("facet_wrap")
        clsRBarDotPlotFacet.AddParameter("", "~variable")
        clsRGGBarDotPlot.SetParameter(True, clsRFunc:=clsRGGplotFunction)
        clsRGGBarDotPlot.SetParameter(False, clsRFunc:=clsRBarDotPlotFacet)
    End Sub

    Private Sub SummaryPlot()
        clsRGGSummaryPlot.SetOperation("+")
        clsRStatSummary.SetRCommand("stat_summary")
        clsRStatSummary.AddParameter("fun.y", Chr(34) & "mean" & Chr(34))
        clsRStatSummary.AddParameter("geom", Chr(34) & "point" & Chr(34))
        clsRSummaryAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRSummaryAesFunction)
        clsRSummaryAesFunction.AddParameter("x", "value")
        clsRSummaryPlotFacet.SetRCommand("facet_wrap")
        clsRSummaryPlotFacet.AddParameter("", "~variable")
        clsRGGSummaryPlot.SetParameter(True, clsRFunc:=clsRGGplotFunction)
        clsRGGSummaryPlot.SetParameter(False, clsRFunc:=clsRStatSummary)
    End Sub
End Class