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

Public Class dlgDescribeTwoVarGraph
    Public strSecondVarType, strVarType As String
    Private clsRGGplotFunction, clsRBoxPlotGeom, clsRScatterPlotGeom, clsRLinePlotGeom, clsRSummaryAesFunction, clsRStatSummary, clsRFacet As New RFunction
    Private clsRBoxAesFunction, clsRBoxAesFunction2, clsRScatterAesFunction, clsRScatterAesFunction2, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarAesFunction, clsRDotAesFunction, clsRDotAesFunction2 As New RFunction
    Private clsRFrequencyPolygonGeom, clsRHistogramGeom, clsRDensityPlotGeom, clsRFreqPolyAesFunction, clsRFreqPolyAesFunction2, clsRHistAesFunction, clsRHistAesFunction2, clsRDensityAesFunction, clsRDensityAesFunction2 As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Private Sub dlgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        clsRGGplotFunction = New RFunction
        clsRBoxPlotGeom = New RFunction
        clsRScatterPlotGeom = New RFunction
        clsRLinePlotGeom = New RFunction
        clsRSummaryAesFunction = New RFunction
        clsRStatSummary = New RFunction
        clsRFacet = New RFunction
        clsRBoxAesFunction = New RFunction
        clsRBoxAesFunction2 = New RFunction
        clsRScatterAesFunction = New RFunction
        clsRScatterAesFunction2 = New RFunction
        clsRDotPlotGeom = New RFunction
        clsRBarPlotGeom = New RFunction
        clsRBarAesFunction = New RFunction
        clsRDotAesFunction = New RFunction
        clsRDotAesFunction2 = New RFunction
        clsRFrequencyPolygonGeom = New RFunction
        clsRHistogramGeom = New RFunction
        clsRDensityPlotGeom = New RFunction
        clsRFreqPolyAesFunction = New RFunction
        clsRFreqPolyAesFunction2 = New RFunction
        clsRHistAesFunction = New RFunction
        clsRHistAesFunction2 = New RFunction
        clsRDensityAesFunction = New RFunction
        clsRDensityAesFunction2 = New RFunction
        clsBaseOperator = New ROperator
        ucrReceiverMultipleTwoVar.SetMeAsReceiver()
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrSelectorTwoVarGraph.Focus()
        'ucrTwoVarGraphSave.strPrefix = "TwoVariableGraph"
        sdgDescribeTwoVarGraph.Initialise()

        clsBaseOperator.SetOperation("+")
        clsRGGplotFunction.SetPackageName("ggplot2")
        clsRGGplotFunction.SetRCommand("ggplot")
        clsRFacet.SetPackageName("ggplot2")
        clsRFacet.SetRCommand("facet_wrap")
        clsRFacet.AddParameter("facets", "~variable")
        clsBaseOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsRFacet)
        clsBaseOperator.AddParameter(True, clsRFunctionParameter:=clsRGGplotFunction)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub ucrTwoVarGraphSave_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorTwoVarGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoVarGraph.SetParameterIsrfunction()

        ucrReceiverMultipleTwoVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverMultipleTwoVar.SetSingleTypeStatus(True)
        ucrReceiverMultipleTwoVar.SetMultipleOnlyStatus(True)

        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrSecondVariableReceiver.SetParameter(New RParameter("fill", 0))
        ucrSecondVariableReceiver.SetParameterIsString()
        ucrSecondVariableReceiver.bWithQuotes = False

        ucrSaveGraph.SetPrefix("two_var")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorTwoVarGraph.SetRCode(clsRGGplotFunction, bReset)
        ucrSecondVariableReceiver.SetRCode(clsRBarAesFunction, bReset)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRScatterAesFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRBoxAesFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRDotAesFunction, New RParameter("y", 0), iAdditionalPairNo:=3)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRFreqPolyAesFunction, New RParameter("color", 0), iAdditionalPairNo:=4)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRHistAesFunction, New RParameter("color", 0), iAdditionalPairNo:=5)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRDensityAesFunction, New RParameter("color", 0), iAdditionalPairNo:=6)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRScatterAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=7)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRBoxAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=8)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRDotAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=9)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRFreqPolyAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=10)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRHistAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrSecondVariableReceiver.AddAdditionalCodeParameterPair(clsRDensityAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=12)

    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverMultipleTwoVar.IsEmpty Or ucrSecondVariableReceiver.IsEmpty Or Not ucrSaveGraph.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
            Results()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrTwoVarGraphSave_Load()
        'If ucrTwoVarGraphSave.bSaveGraph Then
        '    '  ucrBase.clsRsyntax.SetAssignTo(ucrTwoVarGraphSave.strGraphName, strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrTwoVarGraphSave.strGraphName)
        'Else
        '    'ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        'End If
        'TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgDescribeTwoVarGraph.ShowDialog()
        'sdgDescribeTwoVarGraph.SetRFunction(clsSummariesList, bResetSubdialog)
        'bResetSubdialog = False
        'sdgDescribeTwoVarGraph.ShowDialog()
        TestOkEnabled()
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
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRScatterPlotGeom)
                Case "Line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRLinePlotGeom)
                    ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
                Case "Scatter and line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRLinePlotGeom)
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
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRBoxPlotGeom)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRFrequencyPolygonGeom)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRHistogramGeom)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRDensityPlotGeom)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRDotPlotGeom)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRScatterPlotGeom)
            End Select
            'categorical by numeric case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer") Then
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByNumeric.GetText
                Case "Box plot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRBoxPlotGeom)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRFrequencyPolygonGeom)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRHistogramGeom)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRDensityPlotGeom)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRDotPlotGeom)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction2)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRScatterPlotGeom)
            End Select
            'catogerical by cateogrical case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strVarType <> "numeric" AndAlso strVarType <> "integer") Then
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByCategorical.GetText
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction)
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRDotPlotGeom)
                Case "Bar plot"
                    BarPlot()
                    clsBaseOperator.AddParameter(False, clsRFunctionParameter:=clsRBarPlotGeom)
            End Select
            'Should never reach this case
        Else
            MsgBox("Developer error: Unrecognised column types. Graph may be blank or produce an error.", MsgBoxStyle.Critical)
            ucrBase.clsRsyntax.RemoveOperatorParameter("right")
        End If
    End Sub

    Private Sub ucrSelectorTwoVarGraph_DataFrameChanged() Handles ucrSelectorTwoVarGraph.DataFrameChanged
        '  clsRGGplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrSecondVariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondVariableReceiver.SelectionChanged

    End Sub

    Private Sub BoxPlot()
        clsRBoxPlotGeom.SetPackageName("ggplot2")
        clsRBoxPlotGeom.SetRCommand("geom_boxplot")
        clsRBoxAesFunction.SetPackageName("ggplot2")
        clsRBoxAesFunction.SetRCommand("aes")
        clsRBoxAesFunction.AddParameter("y", "value")
        clsRBoxAesFunction2.SetPackageName("ggplot2")
        clsRBoxAesFunction2.SetRCommand("aes")
        clsRBoxAesFunction2.AddParameter("x", "value")
    End Sub

    Private Sub ScatterLinePlot()
        clsRScatterPlotGeom.SetPackageName("ggplot2")
        clsRScatterPlotGeom.SetRCommand("geom_point")
        clsRLinePlotGeom.SetPackageName("ggplot2")
        clsRLinePlotGeom.SetRCommand("geom_line")
        clsRScatterAesFunction.SetPackageName("ggplot2")
        clsRScatterAesFunction.SetRCommand("aes")
        clsRScatterAesFunction.AddParameter("y", "value")
        clsRScatterAesFunction2.SetPackageName("ggplot2")
        clsRScatterAesFunction2.SetRCommand("aes")
        clsRScatterAesFunction2.AddParameter("x", "value")
    End Sub


    Private Sub DotPlot()
        clsRDotPlotGeom.SetPackageName("ggplot2")
        clsRDotPlotGeom.SetPackageName("ggplot2")
        clsRDotPlotGeom.SetRCommand("geom_dotplot")
        clsRDotPlotGeom.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        clsRDotAesFunction.SetPackageName("ggplot2")
        clsRDotAesFunction.SetRCommand("aes")
        clsRDotAesFunction.AddParameter("x", "value")
        clsRDotAesFunction2.SetPackageName("ggplot2")
        clsRDotAesFunction2.SetRCommand("aes")
        clsRDotAesFunction2.AddParameter("y", "value")
    End Sub

    Private Sub BarPlot()
        clsRBarPlotGeom.SetPackageName("ggplot2")
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarPlotGeom.AddParameter("position", Chr(34) & "dodge" & Chr(34))
        clsRBarAesFunction.SetPackageName("ggplot2")
        clsRBarAesFunction.SetRCommand("aes")
        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBarAesFunction)
        clsRBarAesFunction.AddParameter("x", "value")
    End Sub

    Private Sub FrequencyPolygon()
        clsRFrequencyPolygonGeom.SetPackageName("ggplot2")
        clsRFrequencyPolygonGeom.SetRCommand("geom_freqpoly")
        clsRFreqPolyAesFunction.SetPackageName("ggplot2")
        clsRFreqPolyAesFunction.SetRCommand("aes")
        clsRFreqPolyAesFunction.AddParameter("x", "value")
        clsRFreqPolyAesFunction2.SetPackageName("ggplot2")
        clsRFreqPolyAesFunction2.SetRCommand("aes")
        clsRFreqPolyAesFunction2.AddParameter("color", "value")
    End Sub

    Private Sub DensityPlot()
        clsRDensityPlotGeom.SetPackageName("ggplot2")
        clsRDensityPlotGeom.SetRCommand("geom_density")
        clsRDensityAesFunction.SetPackageName("ggplot2")
        clsRDensityAesFunction.SetRCommand("aes")
        clsRDensityAesFunction.AddParameter("x", "value")
        clsRDensityAesFunction2.SetPackageName("ggplot2")
        clsRDensityAesFunction2.SetRCommand("aes")
        clsRDensityAesFunction2.AddParameter("color", "value")
    End Sub

    Private Sub Histogram()
        clsRHistogramGeom.SetPackageName("ggplot2")
        clsRHistogramGeom.SetRCommand("geom_histogram")
        clsRHistogramGeom.AddParameter("position", Chr(34) & "dodge" & Chr(34))
        clsRHistAesFunction.SetPackageName("ggplot2")
        clsRHistAesFunction.SetRCommand("aes")
        clsRHistAesFunction.AddParameter("x", "value")
        clsRHistAesFunction2.SetPackageName("ggplot2")
        clsRHistAesFunction2.SetRCommand("aes")
        clsRHistAesFunction2.AddParameter("color", "value")
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSecondVariableReceiver.ControlContentsChanged, ucrReceiverMultipleTwoVar.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class