﻿' R- Instat
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

Public Class dlgBarAndPieChart
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsRgeomBarFunction1 As New RFunction
    Private clsRgeomBarFunction2 As New RFunction
    Private clsGeomLollipopFunction As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsLevelsFunction As New RFunction
    Private clsSubsetFunction1 As New RFunction
    Private clsSubsetFunction2 As New RFunction
    Private clsPolarCoordFunction As New RFunction
    Private clsScaleYSymmetricFunction As New RFunction
    Private clsAesFunction1 As New RFunction
    Private clsAesFunction2 As New RFunction
    Private clsPieAesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsIsEqualToOperator1 As New ROperator
    Private clsIsEqualToOperator2 As New ROperator
    Private clsOpeningSubsetOperator1 As New ROperator
    Private clsOpeningSubsetOperator2 As New ROperator
    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsScaleXdiscretFunction As New RFunction
    Private clsExpansionFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFuction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBarLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private clsTextAesFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsForecatsInfreq As New RFunction
    Private clsForecatsReverse As New RFunction
    Private clsForecatsInfreqValue As New RFunction
    Private clsForecatsReverseValue As New RFunction
    Private clsReorderFunction As New RFunction
    Private clsReorderFunctionValue As New RFunction
    Private clsGeomTreemapAesFunction As New RFunction
    Private clsGeomTreemapFunction As New RFunction
    Private clsGeomTreemapTextFunction As New RFunction
    Private clsGeomTreemapTextAesFunction As New RFunction
    Private clsAsNumericFunction As New RFunction
    Private clsGeomTextWordcloudFunction As New RFunction
    Private clsGeomTextWordcloudAesFunction As New RFunction
    Private clsScaleSizeAreaFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsPointsFunction As New RFunction
    Private clsGeomLollipopAesFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strStatSummaryParameterName As String = "stat_summary"
    Private strAdditionalPointsParameterName As String = "add_jitter"
    Private strGeomParameterNames() As String = {strFirstParameterName, strStatSummaryParameterName, strAdditionalPointsParameterName}

    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsRCoordPolarFunction As New RFunction
        Dim dctPositionPairs As New Dictionary(Of String, String)
        Dim dctStatOptions As New Dictionary(Of String, String)
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLollipopColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)
        Dim dctLayout As New Dictionary(Of String, String)
        Dim dctStart As New Dictionary(Of String, String)
        Dim dctPlace As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 438

        ucrPnlOptions.AddRadioButton(rdoFrequency)
        ucrPnlOptions.AddRadioButton(rdoValue)
        ucrPnlOptions.AddRadioButton(rdoTreeMap)
        ucrPnlOptions.AddRadioButton(rdoWordCloud)

        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequency, {"coordpolar", "geom_bar", "geom_text"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoValue, {"coordpolar", "geom_bar", "geom_text", "geom_lollipop"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoTreeMap, {"geom_treemap", "geom_treemap_text"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoWordCloud, {"geom_text_wordcloud", "scale_size_area"})

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates, ucrChkPolarCoordinates, ucrReceiverByFactor, ucrInputBarChartPositions, ucrChkAddLabelsText, ucrVariablesAsFactorForBarChart, ucrChkBacktoback}, {rdoFrequency, rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverX, ucrChkReorderValue, ucrInputAddReorder, ucrChkLollipop}, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkReorderFrequency, ucrInputAddReorder}, {rdoFrequency}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverArea, ucrReceiverFill, ucrChkLayout, ucrChkStart, ucrChkAddLabelsTreemap}, {rdoTreeMap}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverWordcloudAngle, ucrReceiverWordcloudColor, ucrReceiverWordcloudLabel, ucrReceiverWordcloudSize, ucrChkIncreaseSize}, {rdoWordCloud}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverByFactor.SetLinkedDisplayControl(lblByFactor)
        ucrReceiverX.SetLinkedDisplayControl(lblXvariable)
        ucrInputBarChartPositions.SetLinkedDisplayControl(lblPosition)
        ucrReceiverArea.SetLinkedDisplayControl(lblArea)
        ucrReceiverFill.SetLinkedDisplayControl(lblFill)
        ucrReceiverWordcloudLabel.SetLinkedDisplayControl(lblWordcloudLabel)
        ucrReceiverWordcloudSize.SetLinkedDisplayControl(lblWordcloudSize)
        ucrReceiverWordcloudColor.SetLinkedDisplayControl(lblWordcloudColor)
        ucrReceiverWordcloudAngle.SetLinkedDisplayControl(lblWordcloudAngle)

        ucrBarChartSelector.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrBarChartSelector.SetParameterIsrfunction()

        ucrVariablesAsFactorForBarChart.SetParameterIsString()
        ucrVariablesAsFactorForBarChart.Selector = ucrBarChartSelector
        ucrVariablesAsFactorForBarChart.SetFactorReceiver(ucrReceiverByFactor)
        ucrVariablesAsFactorForBarChart.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForBarChart.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForBarChart.bAddParameterIfEmpty = True

        ucrReceiverX.Selector = ucrBarChartSelector
        ucrReceiverX.strSelectorHeading = "X Variable"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()

        ucrReceiverByFactor.Selector = ucrBarChartSelector
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverByFactor.strSelectorHeading = "Factors"
        ucrReceiverByFactor.bWithQuotes = False
        ucrReceiverByFactor.SetParameterIsString()

        ucrReceiverArea.SetParameter(New RParameter("area", 0))
        ucrReceiverArea.bWithQuotes = False
        ucrReceiverArea.SetParameterIsString()
        ucrReceiverArea.Selector = ucrBarChartSelector
        ucrReceiverArea.SetIncludedDataTypes({"numeric", "factor"})

        ucrReceiverFill.SetParameter(New RParameter("fill", 1))
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.bWithQuotes = False
        ucrReceiverFill.Selector = ucrBarChartSelector

        ttArea.SetToolTip(ucrReceiverArea.txtReceiverSingle, "A numeric-type variable that gives the area of each tile, or rectangle")
        ttFill.SetToolTip(ucrReceiverFill.txtReceiverSingle, "A scale to fill each tile or rectangle. This may be the same as the variable used for the areas")

        ucrReceiverLabel.SetParameter(New RParameter("label", 0))
        ucrReceiverLabel.SetParameterIsString()
        ucrReceiverLabel.bWithQuotes = False
        ucrReceiverLabel.Selector = ucrBarChartSelector

        ucrReceiverWordcloudLabel.SetParameter(New RParameter("label", 0))
        ucrReceiverWordcloudLabel.SetParameterIsString()
        ucrReceiverWordcloudLabel.bWithQuotes = False
        ucrReceiverWordcloudLabel.Selector = ucrBarChartSelector

        ucrReceiverWordcloudSize.SetParameter(New RParameter("size", 1))
        ucrReceiverWordcloudSize.SetParameterIsString()
        ucrReceiverWordcloudSize.bWithQuotes = False
        ucrReceiverWordcloudSize.Selector = ucrBarChartSelector

        ucrReceiverWordcloudColor.SetParameter(New RParameter("color", 2))
        ucrReceiverWordcloudColor.SetParameterIsString()
        ucrReceiverWordcloudColor.bWithQuotes = False
        ucrReceiverWordcloudColor.Selector = ucrBarChartSelector

        ucrReceiverWordcloudAngle.SetParameter(New RParameter("angle", 3))
        ucrReceiverWordcloudAngle.SetParameterIsString()
        ucrReceiverWordcloudAngle.bWithQuotes = False
        ucrReceiverWordcloudAngle.Selector = ucrBarChartSelector

        ucrSaveBar.SetIsComboBox()
        ucrSaveBar.SetCheckBoxText("Save Graph")
        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.SetSaveTypeAsGraph()
        ucrSaveBar.SetPrefix("bar_plot")
        ucrSaveBar.SetAssignToIfUncheckedValue("last_graph")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkBacktoback.SetText("Back to back")
        ucrChkBacktoback.SetParameter(New RParameter("labels", 0))
        ucrChkBacktoback.SetValueIfChecked("abs")

        ucrChkPolarCoordinates.SetText("Polar")
        ucrChkPolarCoordinates.SetParameter(New RParameter("theta"))
        ucrChkPolarCoordinates.SetValueIfChecked(Chr(34) & "y" & Chr(34))
        ucrChkPolarCoordinates.AddToLinkedControls({ucrPnlPolar}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlPolar.AddRadioButton(rdoPie)
        ucrPnlPolar.AddRadioButton(rdoDonut)

        ucrInputBarChartPositions.SetParameter(New RParameter("position", 0))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        dctPositionPairs.Add("Fill in reverse", "position_fill(reverse = TRUE)")
        ucrInputBarChartPositions.SetItems(dctPositionPairs)
        ucrInputBarChartPositions.SetDropDownStyleAsNonEditable()
        ucrInputBarChartPositions.SetRDefault(Chr(34) & "stack" & Chr(34))

        ucrInputLabelColour.SetParameter(New RParameter("colour", 4))
        dctLabelColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLabelColours.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputLabelColour.SetItems(dctLabelColours)
        ucrInputLabelColour.bAllowNonConditionValues = True

        ucrInputLabelPosition.SetParameter(New RParameter("vjust", 2))
        dctLabelPositions.Add("Out", "-0.25")
        dctLabelPositions.Add("In", "1.5")
        ucrInputLabelPosition.SetItems(dctLabelPositions)
        ucrInputLabelPosition.SetDropDownStyleAsNonEditable()

        ucrInputLabelSize.SetParameter(New RParameter("size", 5))
        dctLabelSizes.Add("Default", "4")
        dctLabelSizes.Add("Small", "3")
        dctLabelSizes.Add("Big", "7")
        ucrInputLabelSize.SetItems(dctLabelSizes)
        ucrInputLabelSize.SetDropDownStyleAsNonEditable()

        ucrChkAddLabelsText.SetText("Add Labels")
        ucrChkAddLabelsText.AddParameterPresentCondition(True, "geom_text")
        ucrChkAddLabelsText.AddParameterPresentCondition(False, "geom_text", False)
        ucrChkAddLabelsText.AddToLinkedControls({ucrInputLabelPosition, ucrInputLabelSize, ucrInputLabelColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLabelColour.SetLinkedDisplayControl(lblLabelColour)
        ucrInputLabelPosition.SetLinkedDisplayControl(lblLabelPosition)
        ucrInputLabelSize.SetLinkedDisplayControl(lblLabelSize)

        ucrChkAddLabelsTreemap.SetText("Add Labels")
        ucrChkAddLabelsTreemap.AddParameterPresentCondition(True, "geom_treemap_text")
        ucrChkAddLabelsTreemap.AddParameterPresentCondition(False, "geom_treemap_text", False)
        ucrChkAddLabelsTreemap.AddToLinkedControls({ucrInputPlace, ucrReceiverLabel}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPlace.SetLinkedDisplayControl(lblPlace)
        ucrReceiverLabel.SetLinkedDisplayControl(lblLabel)

        ucrNudLollipopSize.SetParameter(New RParameter("point.size", 1))
        ucrNudLollipopSize.DecimalPlaces = 0
        ucrNudLollipopSize.Increment = 1
        ucrNudLollipopSize.Minimum = 1
        ucrNudLollipopSize.Maximum = 15

        ucrChkLollipop.SetText("Lollipop")
        ucrChkLollipop.AddParameterPresentCondition(True, "geom_lollipop")
        ucrChkLollipop.AddParameterPresentCondition(False, "geom_lollipop", False)
        ucrChkLollipop.AddToLinkedControls({ucrNudLollipopSize}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudLollipopSize.SetLinkedDisplayControl(lblLollipopSize)

        ucrInputAddReorder.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputAddReorder.SetDropDownStyleAsNonEditable()
        ucrInputAddReorder.SetLinkedDisplayControl(lblReorder)

        ucrInputReorderX.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderX.SetDropDownStyleAsNonEditable()

        ucrInputReorderValue.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderValue.SetDropDownStyleAsNonEditable()
        ucrChkReorderValue.SetText("Reorder")
        ucrChkReorderValue.AddFunctionNamesCondition(True, "reorder", True)
        ucrChkReorderValue.AddFunctionNamesCondition(False, "reorder", False)
        ucrChkReorderValue.AddToLinkedControls(ucrInputReorderValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkReorderFrequency.SetText("Reorder")
        ucrChkReorderFrequency.SetParameter(New RParameter("Checked", iNewPosition:=0))
        ucrChkReorderFrequency.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkReorderFrequency.AddToLinkedControls(ucrInputReorderX, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrInputLayout.SetParameter(New RParameter("layout", 2))
        dctLayout.Add("Squarified", Chr(34) & "squarified" & Chr(34))
        dctLayout.Add("Scol", Chr(34) & "scol" & Chr(34))
        dctLayout.Add("Srow", Chr(34) & "srow" & Chr(34))
        dctLayout.Add("Fixed", Chr(34) & "fixed" & Chr(34))
        ucrInputLayout.SetItems(dctLayout)
        ucrInputLayout.SetRDefault(Chr(34) & "squarified" & Chr(34))
        ucrInputLayout.SetDropDownStyleAsNonEditable()
        ucrChkLayout.SetText("Layout")
        ucrChkLayout.AddToLinkedControls(ucrInputLayout, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputStart.SetParameter(New RParameter("start", 3))
        dctStart.Add("Bottomleft", Chr(34) & "bottomleft" & Chr(34))
        dctStart.Add("Topleft", Chr(34) & "topleft" & Chr(34))
        dctStart.Add("Topright", Chr(34) & "topright" & Chr(34))
        dctStart.Add("Bottomright", Chr(34) & "bottomright" & Chr(34))
        ucrInputStart.SetItems(dctStart)
        ucrInputStart.SetRDefault(Chr(34) & "bottomleft" & Chr(34))
        ucrInputStart.SetDropDownStyleAsNonEditable()
        ucrChkStart.SetText("Start")
        ucrChkStart.AddToLinkedControls(ucrInputStart, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputPlace.SetParameter(New RParameter("place", 1))
        dctPlace.Add("Middle", Chr(34) & "middle" & Chr(34))
        dctPlace.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctPlace.Add("Top", Chr(34) & "top" & Chr(34))
        dctPlace.Add("Topleft", Chr(34) & "topleft" & Chr(34))
        dctPlace.Add("Topright", Chr(34) & "topright" & Chr(34))
        ucrInputPlace.SetItems(dctPlace)
        ucrInputPlace.SetRDefault(Chr(34) & "middle" & Chr(34))
        ucrInputPlace.SetDropDownStyleAsNonEditable()

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
        ucr1stFactorReceiver.Selector = ucrBarChartSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrNudMaxSize.SetParameter(New RParameter("max_size", 0))
        ucrChkIncreaseSize.SetText("Increase size")
        ucrChkIncreaseSize.AddToLinkedControls(ucrNudMaxSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=20)
        ucrChkIncreaseSize.AddParameterPresentCondition(True, "max_size")
        ucrChkIncreaseSize.AddParameterPresentCondition(False, "max_size", False)
    End Sub

    Private Sub SetDefaults()
        bResetLineLayerSubdialog = True
        clsBaseOperator = New ROperator
        clsIsEqualToOperator1 = New ROperator
        clsIsEqualToOperator2 = New ROperator
        clsOpeningSubsetOperator2 = New ROperator
        clsOpeningSubsetOperator1 = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsRgeomBarFunction1 = New RFunction
        clsRgeomBarFunction2 = New RFunction
        clsGeomLollipopFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsPieAesFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsSubsetFunction1 = New RFunction
        clsSubsetFunction2 = New RFunction
        clsAesFunction1 = New RFunction
        clsAesFunction2 = New RFunction
        clsScaleYSymmetricFunction = New RFunction
        clsPolarCoordFunction = New RFunction
        clsScaleXdiscretFunction = New RFunction
        clsExpansionFunction = New RFunction
        clsGeomTextFunction = New RFunction
        clsTextAesFunction = New RFunction
        clsForecatsInfreq = New RFunction
        clsForecatsReverse = New RFunction
        clsForecatsInfreqValue = New RFunction
        clsForecatsReverseValue = New RFunction
        clsReorderFunction = New RFunction
        clsReorderFunctionValue = New RFunction
        clsGeomTreemapAesFunction = New RFunction
        clsGeomTreemapFunction = New RFunction
        clsGeomTreemapTextAesFunction = New RFunction
        clsGeomTreemapTextFunction = New RFunction
        clsAsNumericFunction = New RFunction
        clsGeomTextWordcloudFunction = New RFunction
        clsGeomTextWordcloudAesFunction = New RFunction
        clsScaleSizeAreaFunction = New RFunction
        clsDummyFunction = New RFunction
        clsPointsFunction = New RFunction
        clsGeomLollipopAesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrBarChartSelector.Reset()
        ucrBarChartSelector.SetGgplotFunction(clsBaseOperator)
        ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True

        ucrInputAddReorder.SetText(strNone)
        ucrInputAddReorder.bUpdateRCodeFromControl = True

        ucrInputReorderX.SetText(strNone)
        ucrInputReorderX.bUpdateRCodeFromControl = True

        ucrInputReorderValue.SetText(strNone)
        ucrInputReorderValue.bUpdateRCodeFromControl = True

        'Temp fix: Set panel conditions properly!
        rdoPie.Checked = True
        rdoFrequency.Checked = True

        clsDummyFunction.AddParameter("Checked", "FALSE", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)

        clsScaleXdiscretFunction.SetRCommand("scale_x_discrete")
        clsScaleXdiscretFunction.AddParameter("expand", clsRFunctionParameter:=clsExpansionFunction, iPosition:=0)

        clsExpansionFunction.SetRCommand("expansion")
        clsExpansionFunction.AddParameter("add", "c(" & 2 & "," & 0 & ")", iPosition:=0)

        clsPolarCoordFunction.SetPackageName("ggplot2")
        clsPolarCoordFunction.SetRCommand("coord_polar")

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "stack" & Chr(34), iPosition:=0)
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsGeomLollipopFunction.SetPackageName("ggalt")
        clsGeomLollipopFunction.SetRCommand("geom_lollipop")
        clsGeomLollipopFunction.AddParameter("point.size", "1", iPosition:=1)

        clsGeomLollipopAesFunction.SetPackageName("ggplot2")
        clsGeomLollipopAesFunction.SetRCommand("aes")

        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")

        clsForecatsReverse.SetPackageName("forcats")
        clsForecatsReverse.SetRCommand("fct_rev")

        clsForecatsInfreq.SetPackageName("forcats")
        clsForecatsInfreq.SetRCommand("fct_infreq")

        clsForecatsReverseValue.SetPackageName("forcats")
        clsForecatsReverseValue.SetRCommand("fct_rev")

        clsForecatsInfreqValue.SetPackageName("forcats")
        clsForecatsInfreqValue.SetRCommand("fct_infreq")

        clsReorderFunctionValue.SetRCommand("reorder")

        clsReorderFunction.SetRCommand("reorder")

        clsAesFunction1.SetRCommand("aes")

        clsAesFunction2.SetRCommand("aes")

        clsLevelsFunction.SetRCommand("levels")

        clsPointsFunction.SetPackageName("ggplot2")
        clsPointsFunction.SetRCommand("geom_point")
        clsPointsFunction.AddParameter("size", "3", iPosition:=0)
        clsPointsFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsIsEqualToOperator1.SetOperation("==")
        clsIsEqualToOperator1.AddParameter("right", clsROperatorParameter:=clsOpeningSubsetOperator1, iPosition:=1)

        clsIsEqualToOperator2.SetOperation("==")
        clsIsEqualToOperator2.AddParameter("right", clsROperatorParameter:=clsOpeningSubsetOperator2, iPosition:=1)

        clsOpeningSubsetOperator1.SetOperation("[")
        clsOpeningSubsetOperator1.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsOpeningSubsetOperator1.AddParameter("right", "2]", iPosition:=1)
        clsOpeningSubsetOperator1.bSpaceAroundOperation = False
        clsOpeningSubsetOperator1.bBrackets = False

        clsOpeningSubsetOperator2.SetOperation("[")
        clsOpeningSubsetOperator2.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsOpeningSubsetOperator2.AddParameter("right", "1]", iPosition:=1)
        clsOpeningSubsetOperator2.bSpaceAroundOperation = False
        clsOpeningSubsetOperator2.bBrackets = False

        clsSubsetFunction1.SetRCommand("subset")

        clsRgeomBarFunction1.SetPackageName("ggplot2")
        clsRgeomBarFunction1.SetRCommand("geom_bar")
        clsRgeomBarFunction1.AddParameter("data", clsRFunctionParameter:=clsSubsetFunction1, iPosition:=0)
        clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1)

        clsRgeomBarFunction2.SetPackageName("ggplot2")
        clsRgeomBarFunction2.SetRCommand("geom_bar")
        clsRgeomBarFunction2.AddParameter("data", clsRFunctionParameter:=clsSubsetFunction2, iPosition:=0)

        clsSubsetFunction2.SetRCommand("subset")

        clsScaleYSymmetricFunction.SetPackageName("lemon")
        clsScaleYSymmetricFunction.SetRCommand("scale_y_symmetric")

        clsTextAesFunction.SetPackageName("ggplot2")
        clsTextAesFunction.SetRCommand("aes")
        clsTextAesFunction.AddParameter("label", "..count..", iPosition:=0)

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsTextAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsGeomTreemapFunction.SetPackageName("treemapify")
        clsGeomTreemapFunction.SetRCommand("geom_treemap")
        clsGeomTreemapFunction.AddParameter("layout", Chr(34) & "squarified" & Chr(34), iPosition:=0)
        clsGeomTreemapFunction.AddParameter("start", Chr(34) & "bottomleft" & Chr(34), iPosition:=1)

        clsGeomTreemapTextFunction.SetPackageName("treemapify")
        clsGeomTreemapTextFunction.SetRCommand("geom_treemap_text")
        clsGeomTreemapTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapTextAesFunction, iPosition:=0)
        clsGeomTreemapTextFunction.AddParameter("layout", Chr(34) & "squarified" & Chr(34), iPosition:=1)
        clsGeomTreemapTextFunction.AddParameter("place", Chr(34) & "middle" & Chr(34), iPosition:=2)

        clsGeomTreemapAesFunction.SetPackageName("ggplot2")
        clsGeomTreemapAesFunction.SetRCommand("aes")
        clsGeomTreemapAesFunction.AddParameter("area", clsRFunctionParameter:=clsAsNumericFunction, iPosition:=0)

        clsAsNumericFunction.SetRCommand("as.numeric")
        clsAsNumericFunction.AddParameter("area", ucrReceiverArea.GetVariableNames(False), bIncludeArgumentName:=False)

        clsGeomTreemapTextAesFunction.SetPackageName("ggplot2")
        clsGeomTreemapTextAesFunction.SetRCommand("aes")

        clsGeomTextWordcloudAesFunction.SetPackageName("ggplot2")
        clsGeomTextWordcloudAesFunction.SetRCommand("aes")

        clsGeomTextWordcloudFunction.SetPackageName("ggwordcloud")
        clsGeomTextWordcloudFunction.SetRCommand("geom_text_wordcloud")

        clsScaleSizeAreaFunction.SetPackageName("ggplot2")
        clsScaleSizeAreaFunction.SetRCommand("scale_size_area")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFuction = GgplotDefaults.clsDefaultThemeFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator1, New RParameter("left", 0), iAdditionalPairNo:=1)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator2, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsLevelsFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsReorderFunctionValue, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsReorderFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrInputLayout.AddAdditionalCodeParameterPair(clsGeomTreemapTextFunction, New RParameter("layout", 1), iAdditionalPairNo:=1)

        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkPolarCoordinates.SetRCode(clsPolarCoordFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkBacktoback.SetRCode(clsScaleYSymmetricFunction, bReset)
        ucrChkReorderValue.SetRCode(clsReorderFunctionValue, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
        ucrInputLabelColour.SetRCode(clsGeomTextFunction, bReset)
        ucrChkAddLabelsText.SetRCode(clsBaseOperator, bReset)
        ucrInputLabelPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputLabelSize.SetRCode(clsGeomTextFunction, bReset)
        ucrNudLollipopSize.SetRCode(clsGeomLollipopFunction, bReset)
        ucrChkLollipop.SetRCode(clsBaseOperator, bReset)
        ucrReceiverArea.SetRCode(clsAsNumericFunction, bReset)
        ucrReceiverFill.SetRCode(clsGeomTreemapAesFunction, bReset)
        ucrReceiverLabel.SetRCode(clsGeomTreemapTextAesFunction, bReset)
        ucrInputLayout.SetRCode(clsGeomTreemapFunction, bReset)
        ucrInputStart.SetRCode(clsGeomTreemapFunction, bReset)
        ucrInputPlace.SetRCode(clsGeomTreemapTextFunction, bReset)
        ucrReceiverWordcloudLabel.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudSize.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudColor.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudAngle.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrChkAddLabelsTreemap.SetRCode(clsBaseOperator, bReset)
        ucrNudMaxSize.SetRCode(clsScaleSizeAreaFunction, bReset)
        ucrChkReorderFrequency.SetRCode(clsDummyFunction, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            ucrChkStart.SetRCode(clsGeomTreemapFunction, bReset)
            ucrChkLayout.SetRCode(clsGeomTreemapFunction, bReset)
            ucrChkIncreaseSize.SetRCode(clsScaleSizeAreaFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If rdoFrequency.Checked Then
            If ucrSaveBar.IsComplete AndAlso (Not ucrVariablesAsFactorForBarChart.IsEmpty OrElse Not ucrReceiverByFactor.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoValue.Checked Then
            If ucrSaveBar.IsComplete AndAlso (Not ucrVariablesAsFactorForBarChart.IsEmpty OrElse Not ucrReceiverX.IsEmpty OrElse Not ucrReceiverByFactor.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoTreeMap.Checked Then
            If ucrSaveBar.IsComplete AndAlso (Not ucrReceiverArea.IsEmpty AndAlso Not ucrReceiverFill.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoWordCloud.Checked Then
            If ucrSaveBar.IsComplete AndAlso (Not ucrReceiverWordcloudLabel.IsEmpty AndAlso Not ucrReceiverWordcloudSize.IsEmpty) Then
                ucrBase.OKEnabled(True)
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

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction, clsNewAesFunction As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsNewAesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector,
                                   bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.
        Try
            'The aesthetics parameters on the main dialog are repopulated as required.
            For Each clsParam In clsNewAesFunction.clsParameters
                If clsParam.strArgumentName = "x" Then
                    If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                        ucrReceiverX.Clear()
                    Else
                        'ucrReceiverX.Add(clsParam.strArgumentValue)
                    End If
                    'In the y case, the value stored in the clsReasFunction in the multiple variables 
                    '  case is "value", however that one shouldn't be written in the multiple 
                    '  variables receiver (otherwise it would stack all variables and the stack 
                    '  ("value") itself!).
                    'Warning: what if someone used the name value for one of it's variables 
                    '  independently from the multiple variables method? Here if the receiver is 
                    '  actually in single mode, the variable "value" will still be given back, which 
                    '  throws the problem back to the creation of "value" in the multiple receiver case.
                ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForBarChart.bSingleVariable) Then
                    'Still might be in the case of bSingleVariable with mapping y="".
                    If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                        ucrVariablesAsFactorForBarChart.Clear()
                    Else
                        ucrReceiverWordcloudSize.Add(clsParam.strArgumentValue)
                    End If
                ElseIf clsParam.strArgumentName = "colour" Then
                    ucrReceiverByFactor.Add(clsParam.strArgumentValue)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SetGeomTextOptions()
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        Dim clsTempGlobalAesFunction As New RFunction
        If rdoValue.Checked OrElse rdoFrequency.Checked Then
            clsTempGlobalAesFunction = If(ucrChkPolarCoordinates.Checked, clsPieAesFunction, clsBarAesFunction)
        End If
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                                clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                                clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsTempGlobalAesFunction, ucrNewBaseSelector:=ucrBarChartSelector,
                                clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                                clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                                strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemBarchartOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemBarchartOptions.Click
        openSdgLayerOptions(clsRgeomBarFunction1, clsBarAesFunction)
    End Sub

    Private Sub toolStripMenuItemLollipopOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemLollipopOptions.Click
        openSdgLayerOptions(clsGeomLollipopFunction, clsGeomLollipopAesFunction)
    End Sub

    Private Sub toolStripMenuItemTreemapOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTreemapOptions.Click
        openSdgLayerOptions(clsGeomTreemapFunction, clsGeomTreemapAesFunction)
    End Sub

    Private Sub toolStripMenuItemWordcloudOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemWordcloudOptions.Click
        openSdgLayerOptions(clsGeomTextWordcloudFunction, clsGeomTextWordcloudAesFunction)
    End Sub

    Private Sub toolStripMenuItemTreemapTextOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTreemapTextOptionsOptions.Click
        openSdgLayerOptions(clsGeomTreemapTextFunction, clsGeomTreemapTextAesFunction)
    End Sub

    Private Sub toolStripMenuItemPointOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTextOptions.Click
        openSdgLayerOptions(clsGeomTextFunction, clsTextAesFunction)
    End Sub

    Private Sub SetDialogOptions()
        If rdoValue.Checked Or rdoFrequency.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameterByName("geom_col")
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("bar_plot")
            End If
            ucrVariablesAsFactorForBarChart.RemoveIncludedMetadataProperty("class")
            ucrVariablesAsFactorForBarChart.strSelectorHeading = "Variables"
            ucrInputBarChartPositions.Visible = Not ucrReceiverByFactor.IsEmpty()
        ElseIf rdoTreeMap.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapAesFunction, iPosition:=1)
        Else
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTextWordcloudAesFunction, iPosition:=1)
        End If
        ucrChkLollipop.Enabled = If(rdoValue.Checked, True, False)
        If rdoFrequency.Checked Then
            If ucrVariablesAsFactorForBarChart.bSingleVariable Then
                If ucrReceiverByFactor.IsEmpty Then
                    ucrInputAddReorder.Visible = False
                    ucrInputAddReorder.SetText(strNone)
                Else
                    ucrInputAddReorder.Visible = True
                End If
            Else
                ucrInputReorderX.SetText(strNone)
            End If
        ElseIf rdoValue.Checked Then
            If ucrVariablesAsFactorForBarChart.bSingleVariable Then
                ucrChkReorderValue.Visible = True
                ucrInputAddReorder.Visible = Not ucrReceiverByFactor.IsEmpty()
            Else
                ucrChkReorderValue.Visible = False
            End If
        End If
    End Sub

    Private Sub UpdateParameter()
        Dim strChangedTextFreq As String = ucrInputReorderX.GetText()
        Dim strChangedTextValue As String = ucrInputAddReorder.GetText()
        Dim strChangeTextReorder As String = ucrInputReorderValue.GetText()
        If rdoFrequency.Checked Then
            clsForecatsInfreq.AddParameter("f", "as.factor(" & ucrVariablesAsFactorForBarChart.GetVariableNames(False) & ")", iPosition:=0)
            clsForecatsInfreqValue.AddParameter("f", "as.factor(" & ucrReceiverByFactor.GetVariableNames(False) & ")", iPosition:=0)
            If ucrChkReorderFrequency.Checked Then
                Select Case strChangedTextFreq
                    Case strAscending
                        clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                    Case strDescending
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                    Case strReverse
                        clsForecatsReverse.AddParameter("f", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                    Case strNone
                        clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                        clsPieAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                End Select
            Else
                clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                clsPieAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            End If
            If ucrChkPolarCoordinates.Checked Then
                If rdoPie.Checked OrElse rdoDonut.Checked Then
                    If ucrReceiverByFactor.IsEmpty Then
                        clsPieAesFunction.AddParameter("x", "1", iPosition:=0)
                        Select Case strChangedTextFreq
                            Case strAscending
                                clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=2)
                            Case strDescending
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=2)
                            Case strReverse
                                clsForecatsReverse.AddParameter("f", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=2)
                            Case strNone
                                clsPieAesFunction.AddParameter("fill", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=2)
                        End Select
                    End If
                End If
            End If
            If Not ucrReceiverByFactor.IsEmpty Then
                Select Case strChangedTextValue
                    Case strAscending
                        clsForecatsReverseValue.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                    Case strDescending
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=1)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=2)
                    Case strReverse
                        clsForecatsReverseValue.AddParameter("f", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                    Case strNone
                        clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
                        clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
                End Select
            End If
        ElseIf rdoValue.Checked Then
            clsReorderFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsReorderFunctionValue.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            If ucrChkReorderValue.Checked Then
                Select Case strChangeTextReorder
                    Case strAscending
                        clsReorderFunction.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                        clsGeomLollipopAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                    Case strDescending
                        clsReorderFunction.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                        clsGeomLollipopAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                    Case strReverse
                        clsForecatsReverse.AddParameter("f", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                        clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        clsPieAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        clsGeomLollipopAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                    Case strNone
                        clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                        clsPieAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                        clsGeomLollipopAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                End Select
            Else
                clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=1)
                clsPieAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                clsGeomLollipopAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=1)
            End If
            If ucrChkPolarCoordinates.Checked Then
                If rdoPie.Checked OrElse rdoDonut.Checked Then
                    If ucrReceiverByFactor.IsEmpty Then
                        clsPieAesFunction.AddParameter("x", "1", iPosition:=0)
                        Select Case strChangeTextReorder
                            Case strAscending
                                clsReorderFunctionValue.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                            Case strDescending
                                clsReorderFunctionValue.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                            Case strReverse
                                clsForecatsReverseValue.AddParameter("f", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                                clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                            Case strNone
                                clsPieAesFunction.AddParameter("fill", ucrReceiverX.GetVariableNames(False), iPosition:=2)
                        End Select
                    End If
                End If
            End If
            If Not ucrReceiverByFactor.IsEmpty Then
                Select Case strChangedTextValue
                    Case strAscending
                        clsReorderFunctionValue.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                        clsGeomLollipopAesFunction.AddParameter("colour", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                    Case strDescending
                        clsReorderFunctionValue.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                        clsGeomLollipopAesFunction.AddParameter("colour", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                    Case strReverse
                        clsForecatsReverseValue.AddParameter("f", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                        clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                        clsPieAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                        clsGeomLollipopAesFunction.AddParameter("colour", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
                    Case strNone
                        clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
                        clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
                        clsGeomLollipopAesFunction.AddParameter("colour", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
                End Select
            End If
        End If
    End Sub

    Private Sub ChangeParameterName()
        clsBaseOperator.RemoveParameterByName("geom_lollipop")
        clsBarAesFunction.RemoveParameterByName("x")
        clsBarAesFunction.RemoveParameterByName("y")
        clsPieAesFunction.RemoveParameterByName("x")
        clsPieAesFunction.RemoveParameterByName("y")
        clsPieAesFunction.RemoveParameterByName("fill")
        clsRggplotFunction.RemoveParameterByName("mapping")
        clsRggplotFunction.RemoveParameterByName("aes")
        clsGeomLollipopAesFunction.RemoveParameterByName("x")
        clsGeomLollipopAesFunction.RemoveParameterByName("y")
        clsGeomLollipopAesFunction.RemoveParameterByName("colour")
        clsRgeomBarFunction1.RemoveParameterByName("stat")
        clsRgeomBarFunction2.RemoveParameterByName("stat")
        clsRgeomBarFunction.RemoveParameterByName("stat")
        If rdoValue.Checked Then
            clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsBarAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsPieAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsPieAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            If ucrChkPolarCoordinates.Checked Then
                clsRggplotFunction.RemoveParameterByName("mapping")
                clsRggplotFunction.AddParameter("aes", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1, bIncludeArgumentName:=False)
            End If
            clsGeomLollipopAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsGeomLollipopAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsGeomLollipopAesFunction.AddParameter("colour", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=2)
            clsRgeomBarFunction2.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_treemap_text")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
            If ucrReceiverX.IsEmpty Then
                clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsGeomLollipopAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
            End If
            If ucrVariablesAsFactorForBarChart.IsEmpty Then
                clsBarAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
                clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
            End If
            If ucrReceiverByFactor.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
                clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
                clsRgeomBarFunction.RemoveParameterByName("position")
                clsGeomLollipopAesFunction.AddParameter("colour", Chr(34) & Chr(34), iPosition:=2)
            End If
            If ucrChkLollipop.Checked Then
                clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomLollipopAesFunction, iPosition:=1)
                clsBaseOperator.AddParameter("geom_lollipop", clsRFunctionParameter:=clsGeomLollipopFunction, iPosition:=2)
                clsBaseOperator.RemoveParameterByName("geom_bar")
            End If
        ElseIf rdoFrequency.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            If ucrChkPolarCoordinates.Checked Then
                clsRggplotFunction.RemoveParameterByName("mapping")
                clsRggplotFunction.AddParameter("aes", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1, bIncludeArgumentName:=False)
            Else
                If ucrVariablesAsFactorForBarChart.IsEmpty Then
                    clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                    clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                Else
                    clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                    clsPieAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                End If
                If ucrReceiverByFactor.IsEmpty Then
                    clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
                    clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
                    clsRgeomBarFunction.RemoveParameterByName("position")
                Else
                    clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
                    clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
                End If
                clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
                clsRgeomBarFunction2.RemoveParameterByName("stat")
            End If
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
        ElseIf rdoTreeMap.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameterByName("geom_text")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapAesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_treemap", clsRFunctionParameter:=clsGeomTreemapFunction, iPosition:=2)
        ElseIf rdoWordCloud.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_treemap_text")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTextWordcloudAesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_text_wordcloud", clsRFunctionParameter:=clsGeomTextWordcloudFunction, iPosition:=2)
            If ucrChkIncreaseSize.Checked Then
                clsBaseOperator.AddParameter("scale_size_area", clsRFunctionParameter:=clsScaleSizeAreaFunction, iPosition:=3)
            Else
                clsBaseOperator.RemoveParameterByName("scale_size_area")
            End If
        End If
        UpdateParameter()
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrBarChartSelector.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
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
        If Not clsRFacetFunction.ContainsParameter("x") Then
            clsRFacetFunction.AddParameter("x", Chr(34) & Chr(34))
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
        If ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrBarChartSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrBarChartSelector.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged,
        ucrReceiverX.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged, ucrReceiverLabel.ControlValueChanged,
        ucrChkAddLabelsText.ControlValueChanged, ucrChkReorderValue.ControlValueChanged, ucrInputReorderX.ControlValueChanged,
        ucrInputAddReorder.ControlValueChanged, ucrInputReorderValue.ControlValueChanged, ucrNudMaxSize.ControlValueChanged,
        ucrChkIncreaseSize.ControlValueChanged, ucrChkLollipop.ControlValueChanged
        SetDialogOptions()
        ChangeParameterName()
        If rdoTreeMap.Checked Then
            ucrReceiverArea.SetMeAsReceiver()
        ElseIf rdoWordCloud.Checked Then
            ucrReceiverWordcloudLabel.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverByFactor_ControlContentsChanged() Handles ucrReceiverByFactor.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        ucrChkBacktoback.Enabled = If(Not ucrReceiverByFactor.IsEmpty AndAlso (rdoFrequency.Checked OrElse rdoValue.Checked), True, False)
    End Sub

    Private Sub ucrReceiverX_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        If Not ucrReceiverX.Visible Then
            ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkBacktoback_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBacktoback.ControlValueChanged,
        ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        If rdoFrequency.Checked OrElse rdoValue.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_bar1")
            clsBaseOperator.RemoveParameterByName("geom_bar2")
            clsBaseOperator.RemoveParameterByName("scale_y_symmetric")
            clsAesFunction1.RemoveParameterByName("y")
            clsAesFunction2.RemoveParameterByName("y")
            clsRgeomBarFunction2.RemoveParameterByName("aes")
            clsRgeomBarFunction1.RemoveParameterByName("aes")
            ucrChkPolarCoordinates.Enabled = True
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            clsRggplotFunction.RemoveParameterByName("aes")
            If ucrChkBacktoback.Checked Then
                ucrChkPolarCoordinates.Enabled = False
                ucrChkPolarCoordinates.Checked = Not ucrChkBacktoback.Checked
                clsBaseOperator.RemoveParameterByName("geom_bar")
                clsSubsetFunction1.AddParameter("data", ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=1, bIncludeArgumentName:=False)
                clsSubsetFunction1.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator1, iPosition:=2, bIncludeArgumentName:=False)
                clsSubsetFunction2.AddParameter("data", ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=1, bIncludeArgumentName:=False)
                clsSubsetFunction2.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator2, iPosition:=2, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("geom_bar2", clsRFunctionParameter:=clsRgeomBarFunction2, iPosition:=1)
                clsBaseOperator.AddParameter("geom_bar1", clsRFunctionParameter:=clsRgeomBarFunction1, iPosition:=2)
                clsBaseOperator.AddParameter("scale_y_symmetric", clsRFunctionParameter:=clsScaleYSymmetricFunction, iPosition:=3)
                If rdoValue.Checked Then
                    clsAesFunction1.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                    clsAesFunction2.AddParameter("y", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                    clsRgeomBarFunction2.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1)
                    clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction2, iPosition:=1)
                Else
                    clsAesFunction1.AddParameter("y", "after_stat(count) * (-1)", iPosition:=0)
                    clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        End If
        ChangeParameterName()
        SetGeomTextOptions()
    End Sub

    Private Sub ucrChkPolarCoordinates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPolarCoordinates.ControlValueChanged, ucrPnlPolar.ControlValueChanged,
        ucrChkReorderValue.ControlValueChanged, ucrChkReorderFrequency.ControlValueChanged, ucrChkAddLabelsText.ControlValueChanged
        ' adding coordpolar geom
        clsBaseOperator.RemoveParameterByName("coordpolar")
        ChangeParameterName()
        If Not rdoDonut.Checked OrElse Not ucrChkPolarCoordinates.Checked Then
            clsBaseOperator.RemoveParameterByName("scale")
        End If
        If ucrChkPolarCoordinates.Checked Then
            ucrChkBacktoback.Checked = Not ucrChkPolarCoordinates.Checked
            If rdoDonut.Checked Then
                clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsScaleXdiscretFunction, iPosition:=4, bIncludeArgumentName:=False)
            End If
            clsBaseOperator.AddParameter("coordpolar", clsRFunctionParameter:=clsPolarCoordFunction, iPosition:=3)
        End If
    End Sub

    Private Sub ucrChkAddLabelsText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabelsText.ControlValueChanged
        If ucrChkAddLabelsText.Checked Then
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub SetGeomTextOptions()
        If ucrInputBarChartPositions.GetText = "Stack" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Fill" Then
            clsGeomTextFunction.AddParameter("position", "position_fill(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Dodge" Then
            clsGeomTextFunction.AddParameter("position", "position_dodge(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Jitter" Then
            clsGeomTextFunction.AddParameter("position", "position_jitter(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack in reverse" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.5, reverse = TRUE)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Fill in reverse" Then
            clsGeomTextFunction.AddParameter("position", "position_fill(reverse = TRUE)", iPosition:=2)
        Else
            clsGeomTextFunction.AddParameter("position", "position_identity()", iPosition:=2)
        End If
        If rdoFrequency.Checked Then
            clsGeomTextFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=0)
            If ucrChkAddLabelsText.Checked AndAlso
                clsTextAesFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "label") < 0 Then
                clsTextAesFunction.AddParameter("label", "..count..", iPosition:=0)
            End If
        Else
            clsGeomTextFunction.RemoveParameterByName("stat")
            clsTextAesFunction.AddParameter("label", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputBarChartPositions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBarChartPositions.ControlValueChanged
        SetGeomTextOptions()
    End Sub

    Private Sub ucrSaveBar_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForBarChart.ControlContentsChanged,
        ucrReceiverByFactor.ControlContentsChanged, ucrSaveBar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged,
        ucrPnlOptions.ControlContentsChanged, ucrChkBacktoback.ControlContentsChanged, ucrChkPolarCoordinates.ControlContentsChanged,
        ucrReceiverArea.ControlContentsChanged, ucrReceiverFill.ControlContentsChanged, ucrReceiverLabel.ControlContentsChanged,
        ucrChkAddLabelsText.ControlContentsChanged, ucrChkAddLabelsTreemap.ControlContentsChanged, ucrReceiverWordcloudLabel.ControlContentsChanged,
        ucrReceiverWordcloudSize.ControlContentsChanged, ucrReceiverWordcloudColor.ControlContentsChanged, ucrReceiverWordcloudAngle.ControlContentsChanged,
        ucrChkIncreaseSize.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAddLabelsTreemap_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabelsTreemap.ControlValueChanged
        If ucrChkAddLabelsTreemap.Checked Then
            clsBaseOperator.AddParameter("geom_treemap_text", clsRFunctionParameter:=clsGeomTreemapTextFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("geom_treemap_text")
        End If
    End Sub
End Class