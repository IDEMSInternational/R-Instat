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
Public Class dlgHeatMapPlot
    Private bFirstLoad As Boolean = True
    Private bRCodeSet As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bResetRugLayerSubdialog As Boolean = True
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    'Parameter names for geoms
    Private strFirstParameterName As String = "geomrug"
    Private strGeomParameterNames() As String = {strFirstParameterName}
    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private clsCoordPolarStartOperator, clsBaseOperator, clsPipeOperator As New ROperator

    Private clsCoordPolarFunction, clsAnnotateFunction, clsLocalRaesFunction, clsXScaleDateFunction, clsYScaleDateFunction,
    clsScaleFillViridisFunction, clsScaleColourViridisFunction, clsGeomTextFunction,
    clsLabelAesFunction, clsColourPaletteFunction, clsForecatsReverseFunction,
    clsForecatsReverseValueFunction, clsReorderFunction, clsReorderValueFunction, clsGeomPolygonAesFunction, clsRggplotFunction,
    clsRgeomTileFunction, clsLabsFunction, clsGeomPointSizeHeatMapFunction, clsGeomPointSizeChoroplethFunction,
    clsGeomPointShapeHeatMapFunction, clsShapeHeatMapAesFunction, clsGroupFunction, clsSizeHeatMapAesFunction,
    clsSizeChoroplethAesFunction, clsHeatmapAesFunction, clsChoroplethAesFunction, clsXlabsFunction, clsYlabFunction,
    clsXScalecontinuousFunction, clsYScalecontinuousFunction, clsRFacetFunction, clsThemeFunction, clsRoundFunction,
    clsXRangeFunction, clsYRangeFunction, clsXMeanFunction, clsYMeanFunction, clsGroupByFunction,
    clsSummariseFunction, clsDummyFunction As New RFunction

    Private Sub dlgHeatMapPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunction As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)
        Dim dctColourPallette As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 476
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlOptions.AddRadioButton(rdoHeatMap)
        ucrPnlOptions.AddRadioButton(rdoChoroplethMap)

        ucrPnlOptions.AddParameterPresentCondition(rdoHeatMap, "geom_tile")
        ucrPnlOptions.AddParameterPresentCondition(rdoChoroplethMap, "geom_polygon")

        ucrPnlOptions.AddToLinkedControls({ucrChkAddLabels, ucrChkColourPalette}, {rdoHeatMap, rdoChoroplethMap})
        ucrPnlOptions.AddToLinkedControls({ucrChkPoints, ucrReceiverFillChoropleth, ucrReceiverLongitude, ucrReceiverLatitude, ucrReceiverGroup}, {rdoChoroplethMap}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkColourPalette, ucrChkFlipCoordinates, ucrInputReorderValue, ucrReceiverPointsHeatMap, ucrReceiverFill, ucrInputReorderVariableX, ucrReceiverX, ucrVariableAsFactorForHeatMap}, {rdoHeatMap}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverX.SetLinkedDisplayControl(lblXVariable)
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrReceiverFill.SetLinkedDisplayControl(lblFill)
        ucrReceiverFillChoropleth.SetLinkedDisplayControl(lblFillChoropleth)
        ucrReceiverPointsHeatMap.SetLinkedDisplayControl(lblPointsOptional)
        ucrReceiverGroup.SetLinkedDisplayControl(lblGroup)

        ucrHeatMapSelector.SetParameter(New RParameter("data", 0))
        ucrHeatMapSelector.SetParameterIsrfunction()

        ucrReceiverX.Selector = ucrHeatMapSelector
        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bChangeParameterValue = False
        ucrReceiverX.bWithQuotes = False

        ucrReceiverLongitude.Selector = ucrHeatMapSelector
        ucrReceiverLongitude.SetParameter(New RParameter("x", 0))
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.bWithQuotes = False

        ucrReceiverLatitude.Selector = ucrHeatMapSelector
        ucrReceiverLatitude.SetParameter(New RParameter("y", 1))
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.bWithQuotes = False

        ucrReceiverFillChoropleth.Selector = ucrHeatMapSelector
        ucrReceiverFillChoropleth.SetParameter(New RParameter("fill", 2))
        ucrReceiverFillChoropleth.SetParameterIsString()
        ucrReceiverFillChoropleth.bWithQuotes = False

        ucrReceiverGroup.Selector = ucrHeatMapSelector
        ucrReceiverGroup.SetParameter(New RParameter("group", 0))
        ucrReceiverGroup.SetParameterIsString()
        ucrReceiverGroup.bWithQuotes = False

        ucrVariableAsFactorForHeatMap.Selector = ucrHeatMapSelector
        ucrVariableAsFactorForHeatMap.SetFactorReceiver(ucrReceiverX)
        ucrVariableAsFactorForHeatMap.SetParameter(New RParameter("y", 1))
        ucrVariableAsFactorForHeatMap.SetParameterIsString()
        ucrVariableAsFactorForHeatMap.bChangeParameterValue = False
        ucrVariableAsFactorForHeatMap.bWithQuotes = False
        ucrVariableAsFactorForHeatMap.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariableAsFactorForHeatMap.bAddParameterIfEmpty = True

        ucrReceiverFill.Selector = ucrHeatMapSelector
        ucrReceiverFill.SetParameter(New RParameter("fill", 2))
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverPointsHeatMap.Selector = ucrHeatMapSelector
        ucrReceiverPointsHeatMap.SetParameter(New RParameter("size", 0))
        ucrReceiverPointsHeatMap.SetParameterIsString()
        ucrReceiverPointsHeatMap.bWithQuotes = False
        ucrReceiverPointsHeatMap.AddToLinkedControls(ucrNudShapeHeatMap, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudShapeHeatMap.SetParameter(New RParameter("size", 2))
        ucrNudShapeHeatMap.Visible = False
        ucrNudShapeHeatMap.SetLinkedDisplayControl(lblPointsSize)

        ucrSaveGraph.SetPrefix("heatmap")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrHeatMapSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputColour.SetParameter(New RParameter("colour", 4))
        dctLabelColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLabelColours.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputColour.SetItems(dctLabelColours)
        ucrInputColour.bAllowNonConditionValues = True

        ucrInputPosition.SetParameter(New RParameter("vjust", 2))
        dctLabelPositions.Add("Middle", "0")
        dctLabelPositions.Add("Up", "-1")
        dctLabelPositions.Add("Down", "2")
        ucrInputPosition.SetItems(dctLabelPositions)
        ucrInputPosition.SetDropDownStyleAsNonEditable()

        ucrInputSize.SetParameter(New RParameter("size", 5))
        dctLabelSizes.Add("Default", "4")
        dctLabelSizes.Add("Small", "3")
        dctLabelSizes.Add("Big", "7")
        ucrInputSize.SetItems(dctLabelSizes)
        ucrInputSize.SetDropDownStyleAsNonEditable()

        ucrInputColourPalette.SetParameter(New RParameter("option", 0))
        dctColourPallette.Add("Viridis", Chr(34) & "viridis" & Chr(34))
        dctColourPallette.Add("Magma", Chr(34) & "magma" & Chr(34))
        dctColourPallette.Add("Inferno", Chr(34) & "inferno" & Chr(34))
        dctColourPallette.Add("Plasma", Chr(34) & "plasma" & Chr(34))
        dctColourPallette.Add("Cividis", Chr(34) & "cividis" & Chr(34))
        ucrInputColourPalette.SetItems(dctColourPallette)
        ucrInputColourPalette.SetDropDownStyleAsNonEditable()

        ucrChkPoints.SetText("Include Points")
        ucrChkPoints.AddParameterValuesCondition(True, "choropleth_geom_point", "True")
        ucrChkPoints.AddParameterValuesCondition(False, "choropleth_geom_point", "False")

        ucrChkColourPalette.SetText("Colour Palette")
        ucrChkColourPalette.AddParameterPresentCondition(True, "option")
        ucrChkColourPalette.AddParameterPresentCondition(False, "option", False)

        ucrChkAddLabels.SetText("Add Labels")
        ucrChkAddLabels.AddParameterPresentCondition(True, "geom_text")
        ucrChkAddLabels.AddParameterPresentCondition(False, "geom_text", False)

        ucrChkAddLabels.AddToLinkedControls({ucrInputPosition, ucrInputSize, ucrInputColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourPalette.AddToLinkedControls({ucrInputColourPalette}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Viridis")
        ucrInputColour.SetLinkedDisplayControl(lblLabelColour)
        ucrInputPosition.SetLinkedDisplayControl(lblLabelPosition)
        ucrInputSize.SetLinkedDisplayControl(lblLabelSize)

        ucrInputReorderValue.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderValue.SetDropDownStyleAsNonEditable()
        ucrInputReorderValue.SetLinkedDisplayControl(lblReorderValue)

        ucrInputReorderVariableX.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderVariableX.SetDropDownStyleAsNonEditable()
        ucrInputReorderVariableX.SetLinkedDisplayControl(lblReorderVariableX)

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrHeatMapSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        clsCoordFlipFunction.SetPackageName("ggplot2")
        clsCoordFlipFunction.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunction)
        ucrChkFlipCoordinates.SetText("Swap x and y")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsPipeOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomTileFunction = New RFunction
        clsGeomTextFunction = New RFunction
        clsLabelAesFunction = New RFunction
        clsColourPaletteFunction = New RFunction
        clsGeomPointSizeHeatMapFunction = New RFunction
        clsGeomPointSizeChoroplethFunction = New RFunction
        clsSizeHeatMapAesFunction = New RFunction
        clsSizeChoroplethAesFunction = New RFunction
        clsGeomPointShapeHeatMapFunction = New RFunction
        clsShapeHeatMapAesFunction = New RFunction
        clsGroupFunction = New RFunction
        clsGeomPolygonAesFunction = New RFunction
        clsForecatsReverseFunction = New RFunction
        clsForecatsReverseValueFunction = New RFunction
        clsReorderFunction = New RFunction
        clsReorderValueFunction = New RFunction
        clsHeatmapAesFunction = New RFunction
        clsChoroplethAesFunction = New RFunction
        clsRoundFunction = New RFunction
        clsXRangeFunction = New RFunction
        clsYRangeFunction = New RFunction
        clsXMeanFunction = New RFunction
        clsYMeanFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsSummariseFunction = New RFunction
        clsDummyFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrSaveGraph.Reset()
        ucrVariableAsFactorForHeatMap.SetMeAsReceiver()
        ucrHeatMapSelector.Reset()
        ucrHeatMapSelector.SetGgplotFunction(clsBaseOperator)
        bResetSubdialog = True
        bResetRugLayerSubdialog = True

        ucrInputReorderValue.SetText(strNone)
        ucrInputReorderValue.bUpdateRCodeFromControl = True

        ucrInputReorderVariableX.SetText(strNone)
        ucrInputReorderVariableX.bUpdateRCodeFromControl = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_tile", clsRFunctionParameter:=clsRgeomTileFunction, iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHeatmapAesFunction, iPosition:=1)

        clsHeatmapAesFunction.SetPackageName("ggplot2")
        clsHeatmapAesFunction.SetRCommand("aes")

        clsRgeomTileFunction.SetPackageName("ggplot2")
        clsRgeomTileFunction.SetRCommand("geom_tile")

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=2)
        clsGeomTextFunction.AddParameter("vjust", "-1", iPosition:=3)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=4)

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")
        clsLabelAesFunction.AddParameter("label", clsRFunctionParameter:=clsRoundFunction, iPosition:=2)

        clsRoundFunction.SetRCommand("round")
        clsRoundFunction.AddParameter("digits", 2, iPosition:=0)

        clsGeomPointSizeHeatMapFunction.SetPackageName("ggplot2")
        clsGeomPointSizeHeatMapFunction.SetRCommand("geom_point")
        clsGeomPointSizeHeatMapFunction.AddParameter("mapping", clsRFunctionParameter:=clsSizeHeatMapAesFunction, iPosition:=0)

        clsSizeHeatMapAesFunction.SetPackageName("ggplot2")
        clsSizeHeatMapAesFunction.SetRCommand("aes")

        clsGeomPointShapeHeatMapFunction.SetPackageName("ggplot2")
        clsGeomPointShapeHeatMapFunction.SetRCommand("geom_point")
        clsGeomPointShapeHeatMapFunction.AddParameter("mapping", clsRFunctionParameter:=clsShapeHeatMapAesFunction, iPosition:=0)
        clsGeomPointShapeHeatMapFunction.AddParameter("size", 5, iPosition:=1)

        clsShapeHeatMapAesFunction.SetPackageName("ggplot2")
        clsShapeHeatMapAesFunction.SetRCommand("aes")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)

        clsColourPaletteFunction.SetPackageName("viridis")
        clsColourPaletteFunction.SetRCommand("scale_fill_viridis")

        clsForecatsReverseFunction.SetPackageName("forcats")
        clsForecatsReverseFunction.SetRCommand("fct_rev")

        clsForecatsReverseValueFunction.SetPackageName("forcats")
        clsForecatsReverseValueFunction.SetRCommand("fct_rev")

        clsReorderValueFunction.SetRCommand("reorder")

        clsReorderFunction.SetRCommand("reorder")

        clsChoroplethAesFunction.SetPackageName("ggplot2")
        clsChoroplethAesFunction.SetRCommand("aes")

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")

        clsGeomPolygonAesFunction.SetPackageName("ggplot2")
        clsGeomPolygonAesFunction.SetRCommand("geom_polygon")
        clsGeomPolygonAesFunction.AddParameter("mapping", clsRFunctionParameter:=clsGroupFunction, iPosition:=0)

        clsGroupFunction.SetPackageName("ggplot2")
        clsGroupFunction.SetRCommand("aes")

        clsDummyFunction.AddParameter("choropleth_geom_point", False, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("data", ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
        clsPipeOperator.AddParameter("summarise", clsRFunctionParameter:=clsSummariseFunction, iPosition:=2)
        clsPipeOperator.SetAssignTo("cnames")

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsSummariseFunction.SetPackageName("dplyr")
        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter("x", clsRFunctionParameter:=clsXMeanFunction, iPosition:=0)
        clsSummariseFunction.AddParameter("y", clsRFunctionParameter:=clsYMeanFunction, iPosition:=1)

        clsXMeanFunction.SetRCommand("mean")
        clsXMeanFunction.AddParameter("x", clsRFunctionParameter:=clsXRangeFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsXRangeFunction.SetRCommand("range")

        clsYMeanFunction.SetRCommand("mean")
        clsYMeanFunction.AddParameter("y", clsRFunctionParameter:=clsYRangeFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsYRangeFunction.SetRCommand("range")

        clsGeomPointSizeChoroplethFunction.SetPackageName("ggplot2")
        clsGeomPointSizeChoroplethFunction.SetRCommand("geom_point")
        clsGeomPointSizeChoroplethFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsGeomPointSizeChoroplethFunction.AddParameter("mapping", clsRFunctionParameter:=clsSizeChoroplethAesFunction, iPosition:=1)

        clsSizeChoroplethAesFunction.SetPackageName("ggplot2")
        clsSizeChoroplethAesFunction.SetRCommand("aes")
        clsSizeChoroplethAesFunction.AddParameter("x", "x", iPosition:=0)
        clsSizeChoroplethAesFunction.AddParameter("y", "y", iPosition:=1)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        ' clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        'clsGroupByFunction.SetPackageName("dplyr")
        'clsGroupByFunction.SetRCommand("group_by")


        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverFill.AddAdditionalCodeParameterPair(clsRoundFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverFillChoropleth.AddAdditionalCodeParameterPair(clsSizeChoroplethAesFunction, New RParameter("size", 0), iAdditionalPairNo:=1)
        ucrReceiverFillChoropleth.AddAdditionalCodeParameterPair(clsGroupByFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverFillChoropleth.AddAdditionalCodeParameterPair(clsLabelAesFunction, New RParameter("label", 0), iAdditionalPairNo:=3)

        ucrReceiverPointsHeatMap.AddAdditionalCodeParameterPair(clsShapeHeatMapAesFunction, New RParameter("shape", 0), iAdditionalPairNo:=1)

        ucrReceiverX.AddAdditionalCodeParameterPair(clsReorderFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrVariableAsFactorForHeatMap.AddAdditionalCodeParameterPair(clsReorderValueFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsXRangeFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsYRangeFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrHeatMapSelector.SetRCode(clsRggplotFunction, bReset)

        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        ucrReceiverX.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsChoroplethAesFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsChoroplethAesFunction, bReset)
        ucrVariableAsFactorForHeatMap.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverFill.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverFillChoropleth.SetRCode(clsChoroplethAesFunction, bReset)
        ucrReceiverGroup.SetRCode(clsGroupFunction, bReset)
        ucrChkPoints.SetRCode(clsDummyFunction, bReset)
        ucrChkAddLabels.SetRCode(clsBaseOperator, bReset)
        ucrInputColour.SetRCode(clsGeomTextFunction, bReset)
        ucrInputPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputSize.SetRCode(clsGeomTextFunction, bReset)
        ucrChkColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrInputColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrReceiverPointsHeatMap.SetRCode(clsSizeHeatMapAesFunction, bReset)
        ucrNudShapeHeatMap.SetRCode(clsGeomPointShapeHeatMapFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        bRCodeSet = True

        UnstackColumns()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrSaveGraph.IsComplete Then
            ucrBase.OKEnabled(False)
            Exit Sub
        End If

        If rdoHeatMap.Checked Then
            ucrBase.OKEnabled(Not ucrVariableAsFactorForHeatMap.IsEmpty AndAlso Not ucrReceiverX.IsEmpty)
        Else
            If Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty Then
                ucrBase.OKEnabled(Not ucrChkAddLabels.Checked _
                                  OrElse Not String.IsNullOrEmpty(ucrInputColour.GetText))
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        cmdOptions.Enabled = True
        toolStripMenuItemTileOptions.Enabled = rdoHeatMap.Checked AndAlso ucrVariableAsFactorForHeatMap.bSingleVariable
        toolStripMenuItemPolygonOptions.Enabled = rdoChoroplethMap.Checked
    End Sub

    Private Sub UcrVariablesAsFactor_ControlValueChanged() Handles ucrVariableAsFactorForHeatMap.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
             clsNewGlobalAesFunction:=If(rdoHeatMap.Checked, clsHeatmapAesFunction, clsChoroplethAesFunction), clsNewXLabsTitleFunction:=clsXlabsFunction,
             clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
             clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrHeatMapSelector, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
             strMainDialogGeomParameterNames:=strGeomParameterNames, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
             clsNewAnnotateFunction:=clsAnnotateFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bChangeAesParameter:=True, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemTileOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTileOptions.Click, toolStripMenuItemPolygonOptions.Click

        ''''''' i wonder if all this will be needed for the new system
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction,
                                   clsNewGeomFunc:=If(rdoChoroplethMap.Checked, clsGeomPolygonAesFunction, clsRgeomTileFunction),
                                   clsNewGlobalAesFunc:=If(rdoChoroplethMap.Checked, clsChoroplethAesFunction, clsHeatmapAesFunction),
                                   clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHeatMapSelector,
                                   bApplyAesGlobally:=True, bReset:=bResetRugLayerSubdialog)

        sdgLayerOptions.ShowDialog()
        bResetRugLayerSubdialog = False
        If rdoHeatMap.Checked Then
            For Each clsParam In clsHeatmapAesFunction.clsParameters
                If clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariableAsFactorForHeatMap.bSingleVariable) Then
                    ucrVariableAsFactorForHeatMap.Add(clsParam.strArgumentValue)
                ElseIf clsParam.strArgumentName = "x" Then
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                ElseIf clsParam.strArgumentName = "fill" Then
                    ucrReceiverFill.Add(clsParam.strArgumentValue)
                End If
            Next
        Else
            'We need this here because in the ucrGeom we are removing the mapping
            clsGeomPolygonAesFunction.AddParameter("mapping", clsRFunctionParameter:=clsGroupFunction, iPosition:=0)
            For Each clsParam In clsChoroplethAesFunction.clsParameters
                If clsParam.strArgumentName = "x" Then
                    ucrReceiverLongitude.Add(clsParam.strArgumentValue)
                ElseIf clsParam.strArgumentName = "y" Then
                    ucrReceiverLatitude.Add(clsParam.strArgumentValue)
                ElseIf clsParam.strArgumentName = "fill" Then
                    ucrReceiverFillChoropleth.Add(clsParam.strArgumentValue)
                End If
            Next
        End If
    End Sub

    Private Sub ucrChkColourPalette_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColourPalette.ControlValueChanged
        If ucrChkColourPalette.Checked Then
            clsBaseOperator.AddParameter("palette", clsRFunctionParameter:=clsColourPaletteFunction, iPosition:=6)
        Else
            clsBaseOperator.RemoveParameterByName("palette")
        End If
    End Sub

    Private Sub ucrReceiverPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPointsHeatMap.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        If bRCodeSet Then
            clsBaseOperator.RemoveParameterByName("heatmap_geom_point")
            MakeNudVisible()
            If ucrReceiverPointsHeatMap.IsEmpty OrElse Not rdoHeatMap.Checked Then
                Exit Sub
            ElseIf ucrReceiverPointsHeatMap.strCurrDataType = "numeric" Then
                clsBaseOperator.AddParameter("heatmap_geom_point", clsRFunctionParameter:=clsGeomPointSizeHeatMapFunction, iPosition:=7)
            ElseIf ucrReceiverPointsHeatMap.strCurrDataType = "factor" Then
                clsBaseOperator.AddParameter("heatmap_geom_point", clsRFunctionParameter:=clsGeomPointShapeHeatMapFunction, iPosition:=7)
            Else
                clsBaseOperator.RemoveParameterByName("heatmap_geom_point")
            End If
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrReceiverFill.ControlValueChanged, ucrInputReorderVariableX.ControlValueChanged, ucrInputReorderValue.ControlValueChanged
        clsGeomTextFunction.RemoveParameterByName("data")
        clsLabelAesFunction.RemoveParameterByName("x")
        clsLabelAesFunction.RemoveParameterByName("y")
        If rdoHeatMap.Checked Then
            clsLabelAesFunction.AddParameter("label", clsRFunctionParameter:=clsRoundFunction, iPosition:=0)
            clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_tile", clsRFunctionParameter:=clsRgeomTileFunction, iPosition:=1)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHeatmapAesFunction, iPosition:=1)
            clsBaseOperator.RemoveParameterByName("geom_polygon")
            ucrSaveGraph.SetPrefix("heatmap")
        Else
            clsGeomTextFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
            clsLabelAesFunction.AddParameter("x", "x", iPosition:=0)
            clsLabelAesFunction.AddParameter("y", "y", iPosition:=1)
            clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName("geom_tile")
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsChoroplethAesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_polygon", clsRFunctionParameter:=clsGeomPolygonAesFunction, iPosition:=1)
            ucrSaveGraph.SetPrefix("choroplethmap")

        End If
        UnstackColumns()
    End Sub

    Private Sub ucrVariableAsFactorForHeatMap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariableAsFactorForHeatMap.ControlValueChanged
        MakeVisible()
    End Sub

    Private Sub MakeVisible()
        If rdoHeatMap.Checked Then
            ucrInputReorderValue.Visible = If(ucrVariableAsFactorForHeatMap.bSingleVariable, True, False)
        End If
    End Sub

    Private Sub ucrReceiverLongitude_ControlContentsChanged() Handles ucrReceiverLongitude.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        If rdoChoroplethMap.Checked Then
            ucrReceiverLongitude.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrVariableAsFactorForHeatMap_ControlContentsChanged() Handles ucrVariableAsFactorForHeatMap.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        If rdoHeatMap.Checked Then
            ucrVariableAsFactorForHeatMap.SetMeAsReceiver()
        End If
    End Sub

    Private Sub MakeNudVisible()
        If rdoHeatMap.Checked Then
            ucrNudShapeHeatMap.Visible = If(Not ucrReceiverPointsHeatMap.IsEmpty AndAlso ucrReceiverPointsHeatMap.strCurrDataType = "factor", True, False)
        End If
    End Sub

    Private Sub UpdateParameter()
        If rdoHeatMap.Checked Then
            Select Case ucrInputReorderValue.GetText()
                Case strAscending
                    clsReorderValueFunction.AddParameter("X", ucrReceiverX.GetVariableNames(False), iPosition:=1)
                    clsHeatmapAesFunction.AddParameter("y", clsRFunctionParameter:=clsReorderValueFunction, iPosition:=0)
                Case strDescending
                    clsReorderValueFunction.AddParameter("X", "-" & ucrReceiverX.GetVariableNames(False), iPosition:=1)
                    clsHeatmapAesFunction.AddParameter("y", clsRFunctionParameter:=clsReorderValueFunction, iPosition:=0)
                Case strReverse
                    clsForecatsReverseValueFunction.AddParameter("f", ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=0)
                    clsHeatmapAesFunction.AddParameter("y", clsRFunctionParameter:=clsForecatsReverseValueFunction, iPosition:=0)
                Case strNone
                    clsHeatmapAesFunction.AddParameter("y", ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=0)
            End Select
            Select Case ucrInputReorderVariableX.GetText()
                Case strAscending
                    clsReorderFunction.AddParameter("X", ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=1)
                    clsHeatmapAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                Case strDescending
                    clsReorderFunction.AddParameter("X", "-" & ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=1)
                    clsHeatmapAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                Case strReverse
                    clsForecatsReverseFunction.AddParameter("f", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                    clsHeatmapAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverseFunction, iPosition:=0)
                Case strNone
                    clsHeatmapAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            End Select
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariableAsFactorForHeatMap.ControlValueChanged,
        ucrReceiverX.ControlValueChanged, ucrReceiverFill.ControlValueChanged, ucrChkAddLabels.ControlValueChanged, ucrInputReorderValue.ControlValueChanged,
        ucrInputReorderVariableX.ControlValueChanged
        MakeNudVisible()
        UpdateParameter()
        MakeVisible()
        AddRemoveGeomParameter()
    End Sub

    Private Sub UnstackColumns()
        If Not bRCodeSet Then
            Exit Sub
        End If
        If rdoChoroplethMap.Checked Then
            If Not ucrVariableAsFactorForHeatMap.bSingleVariable Then
                ucrHeatMapSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
                ucrHeatMapSelector.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("stack_data")
            End If
        Else
            If Not ucrVariableAsFactorForHeatMap.bSingleVariable Then
                ucrHeatMapSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("stack_data", "TRUE")
                If Not ucrVariableAsFactorForHeatMap.ucrMultipleVariables.IsEmpty Then
                    ucrHeatMapSelector.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("measure.vars", ucrVariableAsFactorForHeatMap.ucrMultipleVariables.GetVariableNames())
                End If
            End If
        End If
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrHeatMapSelector.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            currentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso
                    Not ucrInputStation.Equals(ucrChangedControl) AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso ucrInputStation.GetText = strFacetRow) OrElse (strChangedText = strFacetRow AndAlso
                    ucrInputStation.GetText = strFacetWrap) OrElse (strChangedText = strFacetWrap AndAlso
                    ucrInputStation.GetText = strFacetCol) OrElse (strChangedText = strFacetCol AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        If Not clsHeatmapAesFunction.ContainsParameter("x") Then
            clsHeatmapAesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If

            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrHeatMapSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrHeatMapSelector.ControlValueChanged
        clsPipeOperator.AddParameter("data", ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub AddRemoveGeomParameter()
        clsBaseOperator.RemoveParameterByName("choropleth_geom_point")
        If rdoChoroplethMap.Checked AndAlso ucrChkPoints.Checked Then
            clsBaseOperator.AddParameter("choropleth_geom_point", clsRFunctionParameter:=clsGeomPointSizeChoroplethFunction, iPosition:=2)
        End If
    End Sub

    Private Sub ucrChkPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPoints.ControlValueChanged
        AddRemoveGeomParameter()
        clsDummyFunction.AddParameter("choropleth_geom_point", ucrChkPoints.Checked, iPosition:=0)
    End Sub

    Private Sub AllControlsContentsChanged() Handles ucrInputColour.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrVariableAsFactorForHeatMap.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
