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
    Private clsRggplotFunction As New RFunction
    Private clsRgeomTileFunction As New RFunction
    Private clsHeatmapAesFunction, clsChoroplethAesFunction, clsXlabsFunction, clsYlabFunction, clsXScalecontinuousFunction,
        clsYScalecontinuousFunction, clsRFacetFunction, clsThemeFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bRCodeSet As Boolean = True
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsLabsFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsLocalRaesFunction As New RFunction
    Private bResetRugLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private clsLabelAesFuction As New RFunction
    Private clsColourPaletteFunction As New RFunction
    Private clsGeomPointSizeHeatMapFunction, clsGeomPointSizeChoroplethFunction As New RFunction
    Private clsGeomPointShapeHeatMapFunction, clsGeomPointShapeChoroplethFunction As New RFunction
    Private clsShapeHeatMapAesFunction, clsShapeChoroplethAesFunction As New RFunction
    Private clsSizeHeatMapAesFunction, clsSizeChoroplethAesFunction As New RFunction
    Private clsForecatsInfreq As New RFunction
    Private clsForecatsReverse As New RFunction
    Private clsForecatsInfreqValue As New RFunction
    Private clsForecatsReverseValue As New RFunction
    Private clsReorderFunction As New RFunction
    Private clsReorderFunctionValue As New RFunction
    Private clsGeomPolygonAesFunction As New RFunction


    'Parameter names for geoms
    Private strFirstParameterName As String = "geomrug"
    Private strGeomParameterNames() As String = {strFirstParameterName}

    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelColoursChoropleth As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelPositionsChoropleth As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)
        Dim dctLabelSizesChoropleth As New Dictionary(Of String, String)
        Dim dctColourPallette As New Dictionary(Of String, String)
        Dim dctColourPalletteChoropleth As New Dictionary(Of String, String)


        ucrBase.iHelpTopicID = 476
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlOptions.AddRadioButton(rdoHeatMap)
        ucrPnlOptions.AddRadioButton(rdoChoroplethMap)

        ucrPnlOptions.AddParameterPresentCondition(rdoHeatMap, "geom_tile")
        ucrPnlOptions.AddParameterPresentCondition(rdoChoroplethMap, "geom_tile", False)

        ucrPnlOptions.AddToLinkedControls({ucrChkAddLabels, ucrChkColourPalette}, {rdoHeatMap, rdoChoroplethMap})
        ucrPnlOptions.AddToLinkedControls({ucrReceiverPointsChoropleth, ucrReceiverFillChoropleth, ucrReceiverLongitude, ucrReceiverLatitude}, {rdoChoroplethMap}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkAddLabels, ucrChkColourPalette, ucrChkFlipCoordinates, ucrInputReorderValue, ucrReceiverPoints, ucrReceiverFill, ucrInputReorderVariableX, ucrReceiverX, ucrVariableAsFactorForHeatMap}, {rdoHeatMap}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverX.SetLinkedDisplayControl(lblXVariable)
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrReceiverFill.SetLinkedDisplayControl(lblFill)
        ucrReceiverFillChoropleth.SetLinkedDisplayControl(lblFillChoropleth)
        ucrReceiverPoints.SetLinkedDisplayControl(lblPointsOptional)
        ucrReceiverPointsChoropleth.SetLinkedDisplayControl(lblPointsChoropleth)

        ucrHeatMapSelector.SetParameter(New RParameter("data", 0))
        ucrHeatMapSelector.SetParameterIsrfunction()

        ucrReceiverX.Selector = ucrHeatMapSelector
        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
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

        ucrVariableAsFactorForHeatMap.Selector = ucrHeatMapSelector
        ucrVariableAsFactorForHeatMap.SetParameter(New RParameter("y", 1))
        ucrVariableAsFactorForHeatMap.SetParameterIsString()
        ucrVariableAsFactorForHeatMap.bWithQuotes = False
        ucrVariableAsFactorForHeatMap.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariableAsFactorForHeatMap.bAddParameterIfEmpty = True

        ucrReceiverFill.Selector = ucrHeatMapSelector
        ucrReceiverFill.SetParameter(New RParameter("fill", 2))
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverPoints.Selector = ucrHeatMapSelector
        ucrReceiverPoints.SetParameter(New RParameter("size", 0))
        ucrReceiverPoints.SetParameterIsString()
        ucrReceiverPoints.bWithQuotes = False
        ucrReceiverPoints.AddToLinkedControls(ucrNudShapeHeatMap, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudShapeHeatMap.SetParameter(New RParameter("size", 2))
        ucrNudShapeHeatMap.Visible = False
        ucrNudShapeHeatMap.SetLinkedDisplayControl(lblPointsSize)

        ucrReceiverPointsChoropleth.Selector = ucrHeatMapSelector
        ucrReceiverPointsChoropleth.SetParameter(New RParameter("size", 0))
        ucrReceiverPointsChoropleth.SetParameterIsString()
        ucrReceiverPointsChoropleth.bWithQuotes = False
        ucrReceiverPointsChoropleth.AddToLinkedControls(ucrNudShapeChoropleth, {True}, bNewLinkedHideIfParameterMissing:=True)


        ucrNudShapeChoropleth.SetParameter(New RParameter("size", 2))
        ucrNudShapeChoropleth.Visible = False
        ucrNudShapeChoropleth.SetLinkedDisplayControl(lblSizeChoropleth)

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
        dctLabelPositions.Add("Out", "-0.25")
        dctLabelPositions.Add("In", "5")
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

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Swap x and y")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsRgeomTileFunction = New RFunction
        clsBaseOperator = New ROperator
        clsGeomTextFunction = New RFunction
        clsLabelAesFuction = New RFunction
        clsColourPaletteFunction = New RFunction
        clsGeomPointSizeHeatMapFunction = New RFunction
        clsGeomPointSizeChoroplethFunction = New RFunction
        clsSizeHeatMapAesFunction = New RFunction
        clsSizeChoroplethAesFunction = New RFunction
        clsGeomPointShapeHeatMapFunction = New RFunction
        clsGeomPointShapeChoroplethFunction = New RFunction
        clsShapeHeatMapAesFunction = New RFunction
        clsShapeChoroplethAesFunction = New RFunction
        clsGeomPolygonAesFunction = New RFunction
        clsForecatsInfreq = New RFunction
        clsForecatsReverse = New RFunction
        clsForecatsInfreqValue = New RFunction
        clsForecatsReverseValue = New RFunction
        clsReorderFunction = New RFunction
        clsReorderFunctionValue = New RFunction
        clsHeatmapAesFunction = New RFunction
        clsChoroplethAesFunction = New RFunction

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

        clsChoroplethAesFunction.SetPackageName("ggplot2")
        clsChoroplethAesFunction.SetRCommand("aes")

        clsHeatmapAesFunction.SetPackageName("ggplot2")
        clsHeatmapAesFunction.SetRCommand("aes")

        clsRgeomTileFunction.SetPackageName("ggplot2")
        clsRgeomTileFunction.SetRCommand("geom_tile")

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFuction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsLabelAesFuction.SetPackageName("ggplot2")
        clsLabelAesFuction.SetRCommand("aes")
        clsLabelAesFuction.AddParameter("label", ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=0)

        clsGeomPointSizeHeatMapFunction.SetPackageName("ggplot2")
        clsGeomPointSizeHeatMapFunction.SetRCommand("geom_point")
        clsGeomPointSizeHeatMapFunction.AddParameter("mapping", clsRFunctionParameter:=clsSizeHeatMapAesFunction, iPosition:=0)

        clsSizeHeatMapAesFunction.SetPackageName("ggplot2")
        clsSizeHeatMapAesFunction.SetRCommand("aes")

        clsGeomPointSizeChoroplethFunction.SetPackageName("ggplot2")
        clsGeomPointSizeChoroplethFunction.SetRCommand("geom_point")
        clsGeomPointSizeChoroplethFunction.AddParameter("mapping", clsRFunctionParameter:=clsSizeChoroplethAesFunction, iPosition:=0)

        clsSizeChoroplethAesFunction.SetPackageName("ggplot2")
        clsSizeChoroplethAesFunction.SetRCommand("aes")


        clsGeomPointShapeHeatMapFunction.SetPackageName("ggplot2")
        clsGeomPointShapeHeatMapFunction.SetRCommand("geom_point")
        clsGeomPointShapeHeatMapFunction.AddParameter("mapping", clsRFunctionParameter:=clsShapeHeatMapAesFunction, iPosition:=0)
        clsGeomPointShapeHeatMapFunction.AddParameter("size", 5, iPosition:=2)

        clsShapeHeatMapAesFunction.SetPackageName("ggplot2")
        clsShapeHeatMapAesFunction.SetRCommand("aes")

        clsGeomPointShapeChoroplethFunction.SetPackageName("ggplot2")
        clsGeomPointShapeChoroplethFunction.SetRCommand("geom_point")
        clsGeomPointShapeChoroplethFunction.AddParameter("mapping", clsRFunctionParameter:=clsShapeChoroplethAesFunction, iPosition:=0)
        clsGeomPointShapeChoroplethFunction.AddParameter("size", 5, iPosition:=2)

        clsShapeChoroplethAesFunction.SetPackageName("ggplot2")
        clsShapeChoroplethAesFunction.SetRCommand("aes")


        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)

        clsGeomPolygonAesFunction.SetPackageName("ggplot2")
        clsGeomPolygonAesFunction.SetRCommand("geom_polygon")

        clsColourPaletteFunction.SetPackageName("viridis")
        clsColourPaletteFunction.SetRCommand("scale_fill_viridis")

        clsForecatsReverse.SetPackageName("forcats")
        clsForecatsReverse.SetRCommand("fct_rev")

        clsForecatsInfreq.SetPackageName("forcats")
        clsForecatsInfreq.SetRCommand("fct_infreq")

        clsForecatsReverseValue.SetPackageName("forcats")
        clsForecatsReverseValue.SetRCommand("fct_rev")

        clsForecatsInfreqValue.SetPackageName("forcats")
        clsForecatsInfreqValue.SetRCommand("fct_infreq")

        clsReorderFunctionValue.SetRCommand("reorder")
        clsReorderFunctionValue.SetRCommand("reorder")

        clsReorderFunction.SetRCommand("reorder")
        clsReorderFunction.SetRCommand("reorder")

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
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverFill.AddAdditionalCodeParameterPair(clsLabelAesFuction, New RParameter("label", 2), iAdditionalPairNo:=1)
        ucrReceiverFillChoropleth.AddAdditionalCodeParameterPair(clsLabelAesFuction, New RParameter("label", 2), iAdditionalPairNo:=1)
        ucrReceiverPoints.AddAdditionalCodeParameterPair(clsShapeHeatMapAesFunction, New RParameter("shape", 0), iAdditionalPairNo:=1)
        ucrReceiverPointsChoropleth.AddAdditionalCodeParameterPair(clsShapeChoroplethAesFunction, New RParameter("shape", 0), iAdditionalPairNo:=1)

        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrHeatMapSelector.SetRCode(clsRggplotFunction, bReset)

        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        ucrReceiverX.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsChoroplethAesFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsChoroplethAesFunction, bReset)
        ucrVariableAsFactorForHeatMap.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverFill.SetRCode(clsHeatmapAesFunction, bReset)
        ucrReceiverFillChoropleth.SetRCode(clsChoroplethAesFunction, bReset)
        ucrChkAddLabels.SetRCode(clsBaseOperator, bReset)
        ucrInputColour.SetRCode(clsGeomTextFunction, bReset)
        ucrInputPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputSize.SetRCode(clsGeomTextFunction, bReset)
        ucrChkColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrInputColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrReceiverPoints.SetRCode(clsSizeHeatMapAesFunction, bReset)
        ucrReceiverPointsChoropleth.SetRCode(clsSizeChoroplethAesFunction, bReset)
        ucrNudShapeHeatMap.SetRCode(clsGeomPointShapeHeatMapFunction, bReset)
        ucrNudShapeChoropleth.SetRCode(clsGeomPointShapeChoroplethFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        bRCodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If rdoHeatMap.Checked Then
            If ucrSaveGraph.IsComplete AndAlso Not ucrVariableAsFactorForHeatMap.IsEmpty AndAlso Not ucrReceiverX.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If ucrSaveGraph.IsComplete AndAlso Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub AllControlsContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrVariableAsFactorForHeatMap.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If rdoHeatMap.Checked Then
            sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                         clsNewGlobalAesFunction:=clsHeatmapAesFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                         clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrHeatMapSelector,
                         strMainDialogGeomParameterNames:=strGeomParameterNames, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        Else
            sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                         clsNewGlobalAesFunction:=clsChoroplethAesFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                         clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrHeatMapSelector,
                         strMainDialogGeomParameterNames:=strGeomParameterNames, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        End If
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdTileOptions_Click(sender As Object, e As EventArgs) Handles cmdTileOptions.Click
        ''''''' i wonder if all this will be needed for the new system
        If rdoChoroplethMap.Checked Then
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsGeomPolygonAesFunction, clsNewGlobalAesFunc:=clsHeatmapAesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                       bFixGeom:=True, ucrNewBaseSelector:=ucrHeatMapSelector, bApplyAesGlobally:=True, bReset:=bResetRugLayerSubdialog)
        Else
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomTileFunction, clsNewGlobalAesFunc:=clsChoroplethAesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                       bFixGeom:=True, ucrNewBaseSelector:=ucrHeatMapSelector, bApplyAesGlobally:=True, bReset:=bResetRugLayerSubdialog)
        End If

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
        End If
    End Sub

    Private Sub ucrChkColourPalette_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColourPalette.ControlValueChanged
        If ucrChkColourPalette.Checked Then
            clsBaseOperator.AddParameter("palette", clsRFunctionParameter:=clsColourPaletteFunction, iPosition:=6)
        Else
            clsBaseOperator.RemoveParameterByName("palette")
        End If
    End Sub

    Private Sub ucrReceiverPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPoints.ControlValueChanged
        If bRCodeSet Then
            MakeNudVisible()
            If ucrReceiverPoints.IsEmpty Then
                clsBaseOperator.RemoveParameterByName("geom_point")
            Else
                If ucrReceiverPoints.strCurrDataType = "numeric" Then
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointSizeHeatMapFunction, iPosition:=7)
                ElseIf ucrReceiverPoints.strCurrDataType = "factor" Then
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointShapeHeatMapFunction, iPosition:=7)
                Else
                    clsBaseOperator.RemoveParameterByName("geom_point")
                End If
            End If
        End If
    End Sub

    Private Sub ucrReceiverPointsChoropleth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPointsChoropleth.ControlValueChanged
        If bRCodeSet Then
            ucrNudShapeChoropleth.Visible = False
            If ucrReceiverPointsChoropleth.IsEmpty Then
                clsBaseOperator.RemoveParameterByName("geom_point")
            Else
                If ucrReceiverPointsChoropleth.strCurrDataType = "numeric" Then
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointSizeChoroplethFunction, iPosition:=7)
                ElseIf ucrReceiverPointsChoropleth.strCurrDataType = "factor" Then
                    ucrNudShapeChoropleth.Visible = True
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointShapeChoroplethFunction, iPosition:=7)
                Else
                    clsBaseOperator.RemoveParameterByName("geom_point")
                End If

            End If
        End If

    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoHeatMap.Checked Then
            clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFuction, iPosition:=1)
            cmdTileOptions.Text = "Tile Options"
            clsBaseOperator.AddParameter("geom_tile", clsRFunctionParameter:=clsRgeomTileFunction, iPosition:=1)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHeatmapAesFunction, iPosition:=1)
            clsBaseOperator.RemoveParameterByName("geom_polygon")
        Else
            clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFuction, iPosition:=1)
            cmdTileOptions.Text = "Polygon Options"
            clsBaseOperator.RemoveParameterByName("geom_tile")
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsChoroplethAesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_polygon", clsRFunctionParameter:=clsGeomPolygonAesFunction, iPosition:=1)
        End If
        MakeVisible()
        MakeNudVisible()
    End Sub

    Private Sub ucrVariableAsFactorForHeatMap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariableAsFactorForHeatMap.ControlValueChanged
        MakeVisible()
    End Sub

    Private Sub MakeVisible()
        If rdoHeatMap.Checked Then
            If ucrVariableAsFactorForHeatMap.bSingleVariable Then
                ucrInputReorderValue.Visible = True
            Else
                ucrInputReorderValue.Visible = False
            End If
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
            ucrNudShapeHeatMap.Visible = False
            If Not ucrReceiverPoints.IsEmpty AndAlso ucrReceiverPoints.strCurrDataType = "factor" Then
                ucrNudShapeHeatMap.Visible = True
            End If
        Else
            ucrNudShapeChoropleth.Visible = False
            If Not ucrReceiverPointsChoropleth.IsEmpty AndAlso ucrReceiverPointsChoropleth.strCurrDataType = "factor" Then
                ucrNudShapeChoropleth.Visible = True
            End If
        End If
    End Sub
End Class