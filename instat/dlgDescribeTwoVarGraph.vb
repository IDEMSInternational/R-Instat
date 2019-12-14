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

Imports instat
Imports instat.Translations

Public Class dlgDescribeTwoVarGraph
    Public strFirstVariablesType, strSecondVariableType As String
    Private clsRGGplotFunction, clsRBoxPlotGeom, clsRScatterPlotGeom, clsRLinePlotGeom, clsRSummaryAesFunction, clsRStatSummary, clsRFacet As New RFunction
    Private clsRBoxAesFunction, clsRBoxAesFunction2, clsRScatterAesFunction, clsRScatterAesFunction2, clsRDotPlotGeom, clsRBarPlotGeom, clsRBarAesFunction, clsRDotAesFunction, clsRDotAesFunction2 As New RFunction
    Private clsRFrequencyPolygonGeom, clsRHistogramGeom, clsRDensityPlotGeom, clsRFreqPolyAesFunction, clsRFreqPolyAesFunction2, clsRHistAesFunction, clsRHistAesFunction2, clsRDensityAesFunction, clsRDensityAesFunction2 As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    ' Private bResetSubdialog As Boolean = False
    Private clsBaseOperator As New ROperator
    Private clsRJitterPlotGeom As New RFunction
    Private clsRJitterAesFunction As New RFunction
    Private clsRViolinPlotGeom As New RFunction
    Private clsRJitterAesFunction2 As New RFunction
    Private clsRViolinAesFunction As New RFunction
    Private clsRViolinAesFunction2 As New RFunction

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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorTwoVarGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoVarGraph.SetParameterIsrfunction()

        ucrReceiverFirstVars.Selector = ucrSelectorTwoVarGraph
        ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        ucrReceiverFirstVars.SetMultipleOnlyStatus(True)

        ucrReceiverSecondVar.SetParameter(New RParameter("fill", 0))
        ucrReceiverSecondVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.bWithQuotes = False

        ucrInputNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Scatter and line plot"})
        ucrInputNumericByNumeric.SetName("Scatter plot")
        ucrInputNumericByNumeric.SetDropDownStyleAsNonEditable()

        ucrInputNumericByCategorical.SetItems({"Boxplot", "Histogram", "Density plot", "Frequency polygon", "Dot plot", "Point plot", "Violin plot", "Jitter plot", "Boxplot + Jitter", "Violin plot + Jitter plot", "Violin plot + Boxplot"})
        ucrInputNumericByCategorical.SetName("Boxplot")
        ucrInputNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByNumeric.SetItems({"Boxplot", "Histogram", "Density plot", "Frequency polygon", "Dot plot", "Point plot", "Violin plot", "Jitter plot", "Boxplot + Jitter", "Violin plot + Jitter plot", "Violin plot + Boxplot"})
        ucrInputCategoricalByNumeric.SetName("Boxplot")
        ucrInputCategoricalByNumeric.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByCategorical.SetItems({"Bar plot", "Dot plot"})
        ucrInputCategoricalByCategorical.SetName("Bar plot")
        ucrInputCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrFlipCoordinates.SetText("Flip Coordinates")
        ucrFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

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
        clsRJitterPlotGeom = New RFunction
        clsRViolinPlotGeom = New RFunction
        clsRJitterAesFunction2 = New RFunction
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
        clsRViolinAesFunction = New RFunction
        clsRViolinAesFunction2 = New RFunction

        'Reset
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()

        ucrReceiverFirstVars.SetMeAsReceiver()
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
        ucrReceiverSecondVar.SetRCode(clsRBarAesFunction, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRScatterAesFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRBoxAesFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRDotAesFunction, New RParameter("y", 0), iAdditionalPairNo:=3)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRFreqPolyAesFunction, New RParameter("color", 0), iAdditionalPairNo:=4)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRHistAesFunction, New RParameter("color", 0), iAdditionalPairNo:=5)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRDensityAesFunction, New RParameter("color", 0), iAdditionalPairNo:=6)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRScatterAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=7)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRBoxAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=8)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRDotAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=9)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRFreqPolyAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=10)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRHistAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRDensityAesFunction2, New RParameter("x", 0), iAdditionalPairNo:=12)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRViolinAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=13)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRViolinAesFunction, New RParameter("x", 0), iAdditionalPairNo:=14)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRJitterAesFunction2, New RParameter("y", 0), iAdditionalPairNo:=15)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRJitterAesFunction, New RParameter("x", 0), iAdditionalPairNo:=16)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFirstVars.IsEmpty AndAlso Not ucrReceiverSecondVar.IsEmpty AndAlso ucrSaveGraph.IsComplete Then
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
        TestOkEnabled()
    End Sub

    Public Sub Results()
        Dim lstFirstItemTypes As List(Of String)

        If Not ucrReceiverFirstVars.IsEmpty() Then
            lstFirstItemTypes = ucrReceiverFirstVars.ucrMultipleVariables.GetCurrentItemTypes(True, bIsCategoricalNumeric:=True)
            If lstFirstItemTypes.Count = 1 AndAlso lstFirstItemTypes.Contains("logical") Then
                lstFirstItemTypes(0) = "categorical"
            Else
                lstFirstItemTypes.RemoveAll(Function(x) x.Contains("logical"))
            End If
            If (lstFirstItemTypes.Count > 0) Then
                strFirstVariablesType = lstFirstItemTypes(0)
            Else
                strFirstVariablesType = ""
                lblFirstType.Text = "________"
                lblFirstType.ForeColor = SystemColors.ControlText
            End If
            lblFirstType.Text = strFirstVariablesType
            lblFirstType.ForeColor = SystemColors.Highlight
        Else
            strFirstVariablesType = ""
            lblFirstType.Text = "________"
            lblFirstType.ForeColor = SystemColors.ControlText
        End If
        If Not ucrReceiverSecondVar.IsEmpty() Then
            strSecondVariableType = ucrReceiverSecondVar.strCurrDataType
            If strSecondVariableType.Contains("factor") OrElse strSecondVariableType.Contains("character") OrElse strSecondVariableType.Contains("logical") Then
                strSecondVariableType = "categorical"
            Else
                strSecondVariableType = "numeric"
            End If
            lblSecondType.Text = strSecondVariableType
            lblSecondType.ForeColor = SystemColors.Highlight
        Else
            strSecondVariableType = ""
            lblSecondType.Text = "________"
            lblSecondType.ForeColor = SystemColors.ControlText
        End If

        lblGraphName.Visible = False
        ucrInputNumericByNumeric.Visible = False
        ucrInputCategoricalByNumeric.Visible = False
        ucrInputNumericByCategorical.Visible = False
        ucrInputCategoricalByCategorical.Visible = False
        If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = True
            ucrInputNumericByNumeric.Visible = True
            ScatterLinePlot()
            clsRFacet.RemoveParameterByName("scale")
            clsBaseOperator.RemoveParameterByName("geom_line")
            Select Case ucrInputNumericByNumeric.GetText
                Case "Scatter plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")

                Case "Line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRLinePlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")

                Case "Scatter and line plot"
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRLinePlotGeom, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=2)
                    clsBaseOperator.RemoveParameterByName("geom1")
            End Select
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = False
            ucrInputCategoricalByNumeric.Visible = True
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            Select Case ucrInputCategoricalByNumeric.GetText
                Case "Boxplot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRFrequencyPolygonGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRHistogramGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDensityPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDotPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Violin plot"
                    ViolinPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRViolinAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Jitter plot"
                    JitterPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRJitterAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Boxplot + Jitter"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    JitterPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=1)
                Case "Violin plot + Jitter plot"
                    ViolinPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRViolinAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=1)
                    JitterPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=1)
                Case "Violin plot + Boxplot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction2, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    ViolinPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=2)
            End Select
        ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = True
            ucrInputNumericByCategorical.Visible = True
            clsRFacet.RemoveParameterByName("scale")
            clsBaseOperator.RemoveParameterByName("geom_line")
            Select Case ucrInputNumericByCategorical.GetText
                Case "Boxplot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Frequency polygon"
                    FrequencyPolygon()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRFreqPolyAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRFrequencyPolygonGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Histogram"
                    Histogram()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRHistAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRHistogramGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Density plot"
                    DensityPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDensityAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDensityPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Dot plot"
                    DotPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRDotAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRDotPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Point plot"
                    ScatterLinePlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRScatterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRScatterPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Violin plot"
                    ViolinPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRViolinAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Jitter plot"
                    JitterPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRJitterAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=1)
                    clsBaseOperator.RemoveParameterByName("geom1")
                Case "Boxplot + Jitter"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRBoxAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    JitterPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=2)
                Case "Violin plot + Jitter plot"
                    ViolinPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRViolinAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=1)
                    JitterPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRJitterPlotGeom, iPosition:=2)
                Case "Violin plot + Boxplot"
                    BoxPlot()
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRViolinAesFunction, iPosition:=0)
                    clsBaseOperator.AddParameter("geom", clsRFunctionParameter:=clsRBoxPlotGeom, iPosition:=1)
                    ViolinPlot()
                    clsBaseOperator.AddParameter("geom1", clsRFunctionParameter:=clsRViolinPlotGeom, iPosition:=2)
            End Select
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = False
            ucrInputCategoricalByCategorical.Visible = True
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsRFacet.AddParameter("scale", Chr(34) & "free_x" & Chr(34))
            If ucrInputCategoricalByCategorical IsNot Nothing Then
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
            End If
        Else
            grpOptions.Visible = False
            lblGraphName.Visible = True
            lblGraphName.Text = "__________"
            lblGraphName.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub ViolinPlot()
        clsRViolinPlotGeom.SetPackageName("ggplot2")
        clsRViolinPlotGeom.SetRCommand("geom_violin")

        clsRViolinAesFunction.SetPackageName("ggplot2")
        clsRViolinAesFunction.SetRCommand("aes")
        clsRViolinAesFunction.AddParameter("y", "value")

        clsRViolinAesFunction2.SetPackageName("ggplot2")
        clsRViolinAesFunction2.SetRCommand("aes")
        clsRViolinAesFunction2.AddParameter("x", "value")
    End Sub

    Private Sub JitterPlot()
        clsRJitterPlotGeom.SetPackageName("ggplot2")
        clsRJitterPlotGeom.SetRCommand("geom_jitter")
        clsRJitterAesFunction.SetPackageName("ggplot2")
        clsRJitterAesFunction.SetRCommand("aes")
        clsRJitterAesFunction.AddParameter("y", "value")
        clsRJitterAesFunction2.SetPackageName("ggplot2")
        clsRJitterAesFunction2.SetRCommand("aes")
        clsRJitterAesFunction2.AddParameter("x", "value")
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

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlValueChanged, ucrReceiverFirstVars.ControlValueChanged
        Results()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlContentsChanged, ucrReceiverFirstVars.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCategoricalByCategorical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNumericByNumeric.ControlValueChanged, ucrInputNumericByCategorical.ControlValueChanged, ucrInputCategoricalByNumeric.ControlValueChanged, ucrInputCategoricalByCategorical.ControlValueChanged
        Results()
    End Sub
End Class