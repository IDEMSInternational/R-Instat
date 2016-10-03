' Instat-R
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
    Public strSecondVarType, strVarType As String
    Private clsRGGplotFunction, clsRBoxPlotGeom, clsRScatterPlotGeom, clsRLinePlotGeom, clsRSummaryAesFunction, clsRStatSummary, clsRFacet As New RFunction
    Private clsRBoxAesFunction, clsRScatterAesFunction, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarDotAesFunction As New RFunction
    Private clsRFrequencyPolygonGeom, clsRHistogramGeom, clsRDensityPlotGeom, clsRFreqPolyAesFunction, clsRHistAesFunction, clsRDensityAesFunction As New RFunction
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
        ucrTwoVarGraphSave.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrSelectorTwoVarGraph.Focus()
        sdgDescribeTwoVarGraph.SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRGGplotFunction.SetRCommand("ggplot")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRGGplotFunction)
        ucrReceiverMultipleTwoVar.SetSelector(ucrSelectorTwoVarGraph)
        ucrReceiverMultipleTwoVar.SetSingleTypeStatus(True)
        ucrReceiverMultipleTwoVar.SetMultipleOnlyStatus(True)
        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrTwoVarGraphSave.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrTwoVarGraphSave.strPrefix = "TwoVariableGraph"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 0
        clsRFacet.SetRCommand("facet_wrap")
        clsRFacet.AddParameter("facets", "~variable")
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverMultipleTwoVar.IsEmpty Or ucrSecondVariableReceiver.IsEmpty Or (ucrTwoVarGraphSave.chkSaveGraph.Checked And ucrTwoVarGraphSave.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
            Results()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load() Handles ucrTwoVarGraphSave.GraphNameChanged, ucrTwoVarGraphSave.SaveGraphCheckedChanged, ucrTwoVarGraphSave.Load
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
            ucrBase.clsRsyntax.RemoveOperatorParameter("facet_wrap")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByNumeric.GetText
                Case "Scatter plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRScatterPlotGeom)
                Case "Line plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRLinePlotGeom)
                    ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
                Case "Scatter and line plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRLinePlotGeom)
                    ucrBase.clsRsyntax.AddOperatorParameter("geom_point", clsRFunc:=clsRScatterPlotGeom)
            End Select
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "factor")) Then
            ucrBase.clsRsyntax.AddOperatorParameter("facet_wrap", clsRFunc:=clsRFacet)
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByCategorical.GetText
                Case "Box plot"
                    BoxPlot()
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBoxPlotGeom)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRFrequencyPolygonGeom)
                Case "Histogram"
                    Histogram()
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRHistogramGeom)
                Case "Density plot"
                    DensityPlot()
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDensityPlotGeom)
            End Select
        ElseIf ((strVarType = "factor") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            SummaryPlot()
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            ucrBase.clsRsyntax.AddOperatorParameter("facet_wrap", clsRFunc:=clsRFacet)
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByNumeric.GetText
                Case "Summary plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRStatSummary)
            End Select
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            BarDotPlot()
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            ucrBase.clsRsyntax.AddOperatorParameter("facet_wrap", clsRFunc:=clsRFacet)
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByCategorical.GetText
                Case "Dot plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDotPlotGeom)
                Case "Bar plot"
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBarPlotGeom)
            End Select
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
        clsRFreqPolyAesFunction.AddParameter("color", ucrSecondVariableReceiver.GetVariableNames(False))
        clsRHistAesFunction.AddParameter("fill", ucrSecondVariableReceiver.GetVariableNames(False))
        clsRDensityAesFunction.AddParameter("color", ucrSecondVariableReceiver.GetVariableNames(False))
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleTwoVar_SelectionChanged() Handles ucrReceiverMultipleTwoVar.SelectionChanged
        TestOkEnabled()
    End Sub

    Private Sub BoxPlot()
        clsRBoxPlotGeom.SetRCommand("geom_boxplot")
        clsRBoxAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction)
        clsRBoxAesFunction.AddParameter("x", Chr(34) & "" & Chr(34))
        clsRBoxAesFunction.AddParameter("y", "value")
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
        clsRDotPlotGeom.SetRCommand("geom_dotplot")
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarDotAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBarDotAesFunction)
        clsRBarDotAesFunction.AddParameter("fill", "value")
    End Sub

    Private Sub SummaryPlot()
        clsRStatSummary.SetRCommand("stat_summary")
        clsRStatSummary.AddParameter("fun.y", Chr(34) & "mean" & Chr(34))
        clsRStatSummary.AddParameter("geom", Chr(34) & "point" & Chr(34))
        clsRSummaryAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRSummaryAesFunction)
        clsRSummaryAesFunction.AddParameter("x", "value")
    End Sub

    Private Sub FrequencyPolygon()
        clsRFrequencyPolygonGeom.SetRCommand("geom_freqpoly")
        clsRFreqPolyAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction)
        clsRFreqPolyAesFunction.AddParameter("x", "value")
    End Sub

    Private Sub DensityPlot()
        clsRDensityPlotGeom.SetRCommand("geom_density")
        clsRDensityAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction)
        clsRDensityAesFunction.AddParameter("x", "value")
    End Sub

    Private Sub Histogram()
        clsRHistogramGeom.SetRCommand("geom_histogram")
        clsRHistAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction)
        clsRHistAesFunction.AddParameter("x", "value")
    End Sub
End Class