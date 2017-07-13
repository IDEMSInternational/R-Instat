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

Public Class dlgDescribeTwoVarGraph
    Public strSecondVarType, strVarType As String
    Private clsRGGplotFunction, clsRBoxPlotGeom, clsRScatterPlotGeom, clsRLinePlotGeom, clsRSummaryAesFunction, clsRStatSummary, clsRFacet As New RFunction
    Private clsRBoxAesFunction, clsRBoxAesFunction2, clsRScatterAesFunction, clsRScatterAesFunction2, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarAesFunction, clsRDotAesFunction, clsRDotAesFunction2 As New RFunction
    Private clsRFrequencyPolygonGeom, clsRHistogramGeom, clsRDensityPlotGeom, clsRFreqPolyAesFunction, clsRFreqPolyAesFunction2, clsRHistAesFunction, clsRHistAesFunction2, clsRDensityAesFunction, clsRDensityAesFunction2 As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    ' Private bResetSubdialog As Boolean = False
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorTwoVarGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoVarGraph.SetParameterIsrfunction()

        ucrReceiverMultipleTwoVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverMultipleTwoVar.SetSingleTypeStatus(True)
        ucrReceiverMultipleTwoVar.SetMultipleOnlyStatus(True)

        ucrSecondVariableReceiver.SetParameter(New RParameter("fill", 0))
        ucrSecondVariableReceiver.Selector = ucrSelectorTwoVarGraph
        ucrSecondVariableReceiver.SetParameterIsString()
        ucrSecondVariableReceiver.bWithQuotes = False

        ucrSaveGraph.SetPrefix("two_var")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
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

        'Reset
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()

        ucrReceiverMultipleTwoVar.SetMeAsReceiver()
        sdgDescribeTwoVarGraph.InitialiseControls()

        'Defining functions and operators
        clsBaseOperator.SetOperation("+")
        clsRGGplotFunction.SetPackageName("ggplot2")
        clsRGGplotFunction.SetRCommand("ggplot")
        clsRFacet.SetPackageName("ggplot2")
        clsRFacet.SetRCommand("facet_wrap")
        clsRFacet.AddParameter("facets", "~variable")
        clsBaseOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsRFacet)
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRGGplotFunction, iPosition:=0)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ' bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorTwoVarGraph.SetRCode(clsRGGplotFunction, bReset)
        ucrSecondVariableReceiver.SetRCode(clsRBarAesFunction, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
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
        If Not ucrReceiverMultipleTwoVar.IsEmpty AndAlso Not ucrSecondVariableReceiver.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        ' sdgDescribeTwoVarGraph.SetRFunction(clsBaseOperator, bResetSubdialog)
        ' bResetSubdialog = False
        sdgDescribeTwoVarGraph.ShowDialog()
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
            clsBaseOperator.RemoveParameterByName("geom_line")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByNumeric.GetText
                Case "Scatter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
                Case "Line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRLinePlotGeom, iPosition:=1)

                Case "Scatter and line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRLinePlotGeom, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=2)
            End Select
            'numeric by categorical case
        ElseIf (strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType <> "numeric" AndAlso strSecondVarType <> "integer") Then
            clsRFacet.RemoveParameterByName("scale")
            clsBaseOperator.RemoveParameterByName("geom_line")
            Select Case sdgDescribeTwoVarGraph.ucrNumericByCategorical.GetText
                Case "Box plot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRFrequencyPolygonGeom, iPosition:=1)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRHistogramGeom, iPosition:=1)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDensityPlotGeom, iPosition:=1)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDotPlotGeom, iPosition:=1)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
            End Select
            'categorical by numeric case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer") Then
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByNumeric.GetText
                Case "Box plot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRFrequencyPolygonGeom, iPosition:=1)
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRHistogramGeom, iPosition:=1)
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDensityPlotGeom, iPosition:=1)
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDotPlotGeom, iPosition:=1)
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
            End Select
            'catogerical by cateogrical case
        ElseIf (strVarType <> "numeric" AndAlso strVarType <> "integer") AndAlso (strVarType <> "numeric" AndAlso strVarType <> "integer") Then
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case sdgDescribeTwoVarGraph.ucrCategoricalByCategorical.GetText
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDotPlotGeom, iPosition:=1)
                Case "Bar plot"
                    BarPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBarAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBarPlotGeom, iPosition:=1)
            End Select
            'Should never reach this case
        Else
            MsgBox("Developer error: Unrecognised column types. Graph may be blank or produce an error.", MsgBoxStyle.Critical)
            ucrBase.clsRsyntax.RemoveOperatorParameter("right")
        End If
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

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSecondVariableReceiver.ControlValueChanged, ucrReceiverMultipleTwoVar.ControlValueChanged
        Results()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSecondVariableReceiver.ControlContentsChanged, ucrReceiverMultipleTwoVar.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class