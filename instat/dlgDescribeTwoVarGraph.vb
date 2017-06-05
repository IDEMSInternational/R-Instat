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
    Private clsRBoxAesFunction, clsRBoxAesFunction2, clsRScatterAesFunction, clsRScatterAesFunction2, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarAesFunction, clsRDotAesFunction, clsRDotAesFunction2 As New RFunction
    Private clsRFrequencyPolygonGeom, clsRHistogramGeom, clsRDensityPlotGeom, clsRFreqPolyAesFunction, clsRFreqPolyAesFunction2, clsRHistAesFunction, clsRHistAesFunction2, clsRDensityAesFunction, clsRDensityAesFunction2 As New RFunction
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
        ucrReceiverMultipleTwoVar.SetMeAsReceiver()
        ucrTwoVarGraphSave.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrSelectorTwoVarGraph.Focus()
        ucrTwoVarGraphSave.strPrefix = "TwoVariableGraph"
        sdgDescribeTwoVarGraph.Initialise()
        TestOkEnabled()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRGGplotFunction.SetRCommand("ggplot")
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRGGplotFunction)
        ucrReceiverMultipleTwoVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverMultipleTwoVar.SetSingleTypeStatus(True)
        ucrReceiverMultipleTwoVar.SetMultipleOnlyStatus(True)
        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrTwoVarGraphSave.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        clsRFacet.SetRCommand("facet_wrap")
        clsRFacet.AddParameter("facets", "~variable")
        ucrBase.clsRsyntax.AddOperatorParameter("facet_wrap", clsRFunc:=clsRFacet)
        ucrBase.iHelpTopicID = 416
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
        sdgDescribeTwoVarGraph.ShowDialog()
    End Sub

    Public Sub Results()
        If ucrReceiverMultipleTwoVar.ucrMultipleVariables.GetCurrentItemTypes.Count > 0 Then
            strVarType = ucrReceiverMultipleTwoVar.ucrMultipleVariables.GetCurrentItemTypes.Item(0)
        Else
            strVarType = ""
        End If
        strSecondVarType = ucrSecondVariableReceiver.strCurrDataType
        'numeric by numeric case
        If ((strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            ScatterLinePlot()
            clsRFacet.RemoveParameterByName("scale")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByNumeric.GetText
                Case "Scatter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRScatterPlotGeom)
                Case "Line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRLinePlotGeom)
                    ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
                Case "Scatter and line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRLinePlotGeom)
                    ucrBase.clsRsyntax.AddOperatorParameter("geom_point", clsRFunc:=clsRScatterPlotGeom)
            End Select
            'numeric by categorical case
        ElseIf (strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType <> "numeric" AndAlso strSecondVarType <> "integer") Then
            clsRFacet.RemoveParameterByName("scale")
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByCategorical.GetText
                Case "Box plot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBoxPlotGeom)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRFrequencyPolygonGeom)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRHistogramGeom)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDensityPlotGeom)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDotPlotGeom)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRScatterPlotGeom)
            End Select
            'categorical by numeric case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer") Then
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByNumeric.GetText
                Case "Box plot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBoxPlotGeom)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRFrequencyPolygonGeom)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRHistogramGeom)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDensityPlotGeom)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDotPlotGeom)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction2)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRScatterPlotGeom)
            End Select
            'catogerical by cateogrical case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strVarType <> "numeric" AndAlso strVarType <> "integer") Then
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByCategorical.GetText
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction)
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRDotPlotGeom)
                Case "Bar plot"
                    BarPlot()
                    ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRBarPlotGeom)
            End Select
            'Should never reach this case
        Else
            MsgBox("Developer error: Unrecognised column types. Graph may be blank or produce an error.", MsgBoxStyle.Critical)
            ucrBase.clsRsyntax.RemoveOperatorParameter("right")
        End If
    End Sub

    Private Sub ucrSelectorTwoVarGraph_DataFrameChanged() Handles ucrSelectorTwoVarGraph.DataFrameChanged
        clsRGGplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrSecondVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondVariableReceiver.SelectionChanged
        If ucrSecondVariableReceiver.IsEmpty() = False Then
            clsRScatterAesFunction.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRBarAesFunction.AddParameter("fill", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRBoxAesFunction.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRDotAesFunction.AddParameter("y", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRFreqPolyAesFunction.AddParameter("color", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRHistAesFunction.AddParameter("color", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRDensityAesFunction.AddParameter("color", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRScatterAesFunction2.AddParameter("y", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRBoxAesFunction2.AddParameter("y", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRDotAesFunction2.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRFreqPolyAesFunction2.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRHistAesFunction2.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
            clsRDensityAesFunction2.AddParameter("x", ucrSecondVariableReceiver.GetVariableNames(False))
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleTwoVar_SelectionChanged() Handles ucrReceiverMultipleTwoVar.SelectionChanged
        TestOkEnabled()
    End Sub

    Private Sub BoxPlot()
        clsRBoxPlotGeom.SetRCommand("geom_boxplot")
        clsRBoxAesFunction.SetRCommand("aes")
        clsRBoxAesFunction.AddParameter("y", "value")
        clsRBoxAesFunction2.SetRCommand("aes")
        clsRBoxAesFunction2.AddParameter("x", "value")
    End Sub

    Private Sub ScatterLinePlot()
        clsRScatterPlotGeom.SetRCommand("geom_point")
        clsRLinePlotGeom.SetRCommand("geom_line")
        clsRScatterAesFunction.SetRCommand("aes")
        clsRScatterAesFunction.AddParameter("y", "value")
        clsRScatterAesFunction2.SetRCommand("aes")
        clsRScatterAesFunction2.AddParameter("x", "value")
    End Sub


    Private Sub DotPlot()
        clsRDotPlotGeom.SetRCommand("geom_dotplot")
        clsRDotPlotGeom.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        clsRDotAesFunction.SetRCommand("aes")
        clsRDotAesFunction.AddParameter("x", "value")
        clsRDotAesFunction2.SetRCommand("aes")
        clsRDotAesFunction2.AddParameter("y", "value")
    End Sub

    Private Sub BarPlot()
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarPlotGeom.AddParameter("position", Chr(34) & "dodge" & Chr(34))
        clsRBarAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBarAesFunction)
        clsRBarAesFunction.AddParameter("x", "value")
    End Sub

    Private Sub FrequencyPolygon()
        clsRFrequencyPolygonGeom.SetRCommand("geom_freqpoly")
        clsRFreqPolyAesFunction.SetRCommand("aes")
        clsRFreqPolyAesFunction.AddParameter("x", "value")
        clsRFreqPolyAesFunction2.SetRCommand("aes")
        clsRFreqPolyAesFunction2.AddParameter("color", "value")
    End Sub

    Private Sub DensityPlot()
        clsRDensityPlotGeom.SetRCommand("geom_density")
        clsRDensityAesFunction.SetRCommand("aes")
        clsRDensityAesFunction.AddParameter("x", "value")
        clsRDensityAesFunction2.SetRCommand("aes")
        clsRDensityAesFunction2.AddParameter("color", "value")
    End Sub

    Private Sub Histogram()
        clsRHistogramGeom.SetRCommand("geom_histogram")
        clsRHistogramGeom.AddParameter("position", Chr(34) & "dodge" & Chr(34))
        clsRHistAesFunction.SetRCommand("aes")
        clsRHistAesFunction.AddParameter("x", "value")
        clsRHistAesFunction2.SetRCommand("aes")
        clsRHistAesFunction2.AddParameter("color", "value")
    End Sub
End Class