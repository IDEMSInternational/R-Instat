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

Public Class dlgBarAndPieChart
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
    Private clsLabelAesFunction As New RFunction
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

    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

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
        ChangeButtonsText()
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

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 438

        ucrPnlOptions.AddRadioButton(rdoFrequency)
        ucrPnlOptions.AddRadioButton(rdoValue)
        ucrPnlOptions.AddRadioButton(rdoTreeMap)
        ucrPnlOptions.AddRadioButton(rdoWordCloud)

        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequency, {"coordpolar", "geom_bar", "geom_text"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoValue, {"coordpolar", "geom_bar", "geom_text"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoTreeMap, {"geom_treemap", "geom_treemap_text"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoWordCloud, {"geom_text_wordcloud", "scale_size_area"})

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates, ucrChkPolarCoordinates, ucrInputBarChartPositions, ucrReceiverByFactor, ucrInputAddReorder, ucrChkAddLabelsText, ucrVariablesAsFactorForBarChart, ucrChkBacktoback}, {rdoFrequency, rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverX, ucrInputReorderValue, ucrChkLollipop}, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputReorderX, {rdoFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        ucrReceiverByFactor.SetParameter(New RParameter("fill", 2))
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
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
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
        dctLabelPositions.Add("In", "5")
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

        ucrInputLollipopColour.SetParameter(New RParameter("point.colour", 0))
        dctLollipopColours.Add("SteelBlue", Chr(34) & "steelBlue" & Chr(34))
        dctLollipopColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLollipopColours.Add("White", Chr(34) & "white" & Chr(34))
        dctLollipopColours.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctLollipopColours.Add("Red", Chr(34) & "red" & Chr(34))
        dctLollipopColours.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctLollipopColours.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctLollipopColours.Add("Green", Chr(34) & "green" & Chr(34))
        dctLollipopColours.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctLollipopColours.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctLollipopColours.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctLollipopColours.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputLollipopColour.SetItems(dctLollipopColours)
        ucrInputLollipopColour.bAllowNonConditionValues = True

        ucrNudLollipopSize.SetParameter(New RParameter("point.size", 1))
        ucrNudLollipopSize.DecimalPlaces = 0
        ucrNudLollipopSize.Increment = 1
        ucrNudLollipopSize.Minimum = 1
        ucrNudLollipopSize.Maximum = 15

        ucrChkLollipop.SetText("Lollipop")
        ucrChkLollipop.AddParameterPresentCondition(True, "geom_lollipop")
        ucrChkLollipop.AddParameterPresentCondition(False, "geom_lollipop", False)
        ucrChkLollipop.AddToLinkedControls({ucrNudLollipopSize, ucrInputLollipopColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudLollipopSize.SetLinkedDisplayControl(lblLollipopSize)
        ucrInputLollipopColour.SetLinkedDisplayControl(lblLollipopColour)

        ucrInputAddReorder.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputAddReorder.SetDropDownStyleAsNonEditable()
        ucrInputAddReorder.SetLinkedDisplayControl(lblReorder)

        ucrInputReorderX.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderX.SetDropDownStyleAsNonEditable()
        ucrInputReorderX.SetLinkedDisplayControl(lblReorderX)

        ucrInputReorderValue.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputReorderValue.SetDropDownStyleAsNonEditable()
        ucrInputReorderValue.SetLinkedDisplayControl(lblReorderValue)

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

        ucrNudMaxSize.SetParameter(New RParameter("max_size", 0))
        ucrChkIncreaseSize.SetText("Increase size")
        ucrChkIncreaseSize.AddToLinkedControls(ucrNudMaxSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=20)
        ucrChkIncreaseSize.AddParameterPresentCondition(True, "max_size")
        ucrChkIncreaseSize.AddParameterPresentCondition(False, "max_size", False)
    End Sub

    Private Sub SetDefaults()
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
        clsLabelAesFunction = New RFunction
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
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsGeomLollipopFunction.SetPackageName("ggalt")
        clsGeomLollipopFunction.SetRCommand("geom_lollipop")
        clsGeomLollipopFunction.AddParameter("point.colour", "steelblue", iPosition:=0)
        clsGeomLollipopFunction.AddParameter("point.size", "1", iPosition:=1)

        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")
        clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34))

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

        clsAesFunction1.SetRCommand("aes")

        clsAesFunction2.SetRCommand("aes")

        clsLevelsFunction.SetRCommand("levels")

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

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")

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
        clsGeomTreemapTextAesFunction.AddParameter("label", clsRFunctionParameter:=clsGeomTreemapAesFunction, iPosition:=0)

        clsGeomTextWordcloudAesFunction.SetPackageName("ggplot2")
        clsGeomTextWordcloudAesFunction.SetRCommand("aes")

        clsGeomTextWordcloudFunction.SetPackageName("ggwordcloud")
        clsGeomTextWordcloudFunction.SetRCommand("geom_text_wordcloud")

        clsScaleSizeAreaFunction.SetPackageName("ggplot2")
        clsScaleSizeAreaFunction.SetRCommand("scale_size_area")

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
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction1, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=1)
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction2, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsPieAesFunction, ucrReceiverByFactor.GetParameter(), iAdditionalPairNo:=1)
        ucrVariablesAsFactorForBarChart.AddAdditionalCodeParameterPair(clsPieAesFunction, ucrVariablesAsFactorForBarChart.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator1, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator2, New RParameter("left", 0), iAdditionalPairNo:=3)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsLevelsFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsReorderFunctionValue, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsReorderFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverFill.AddAdditionalCodeParameterPair(clsGeomTreemapTextAesFunction, New RParameter("label", 0), iAdditionalPairNo:=1)
        ucrInputLayout.AddAdditionalCodeParameterPair(clsGeomTreemapTextFunction, New RParameter("layout", 1), iAdditionalPairNo:=1)

        ucrVariablesAsFactorForBarChart.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverX.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsBarAesFunction, bReset)
        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkPolarCoordinates.SetRCode(clsPolarCoordFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkBacktoback.SetRCode(clsScaleYSymmetricFunction, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
        ucrInputLabelColour.SetRCode(clsGeomTextFunction, bReset)
        ucrChkAddLabelsText.SetRCode(clsBaseOperator, bReset)
        ucrInputLabelPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputLabelSize.SetRCode(clsGeomTextFunction, bReset)
        ucrNudLollipopSize.SetRCode(clsGeomLollipopFunction, bReset)
        ucrInputLollipopColour.SetRCode(clsGeomLollipopFunction, bReset)
        ucrChkLollipop.SetRCode(clsBaseOperator, bReset)
        ucrReceiverArea.SetRCode(clsAsNumericFunction, bReset)
        ucrReceiverFill.SetRCode(clsGeomTreemapAesFunction, bReset)
        ucrReceiverLabel.SetRCode(clsGeomTreemapTextAesFunction, bReset)
        ucrInputLayout.SetRCode(clsGeomTreemapFunction, bReset)
        ucrChkLayout.SetRCode(clsGeomTreemapFunction, bReset)
        ucrInputStart.SetRCode(clsGeomTreemapFunction, bReset)
        ucrChkStart.SetRCode(clsGeomTreemapFunction, bReset)
        ucrInputPlace.SetRCode(clsGeomTreemapTextFunction, bReset)
        ucrReceiverWordcloudLabel.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudSize.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudColor.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrReceiverWordcloudAngle.SetRCode(clsGeomTextWordcloudAesFunction, bReset)
        ucrChkAddLabelsTreemap.SetRCode(clsBaseOperator, bReset)
        ucrNudMaxSize.SetRCode(clsScaleSizeAreaFunction, bReset)
        ucrChkIncreaseSize.SetRCode(clsScaleSizeAreaFunction, bReset)
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If rdoValue.Checked Or rdoFrequency.Checked Then
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsBarAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog, bNewEnableDiscrete:=False)
        Else
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsPieAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog)
        End If
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        'What should global and local aes be?
        If rdoValue.Checked Or rdoFrequency.Checked Then
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsBarAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
            sdgLayerOptions.ShowDialog()
            bResetBarLayerSubdialog = False
            If clsBarAesFunction.ContainsParameter("x") Then
                ucrVariablesAsFactorForBarChart.Add(clsBarAesFunction.GetParameter("x").strArgumentValue)
            Else
                ucrVariablesAsFactorForBarChart.Clear()
            End If
            If clsBarAesFunction.ContainsParameter("fill") Then
                ucrReceiverByFactor.Add(clsBarAesFunction.GetParameter("fill").strArgumentValue)
            Else
                ucrReceiverByFactor.Clear()
            End If
            'Allows for sync with the layer parameters
            ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
            TestOkEnabled()
        End If

        If rdoTreeMap.Checked Then
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsGeomTreemapFunction, clsNewGlobalAesFunc:=clsGeomTreemapAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
            sdgLayerOptions.ShowDialog()
            bResetBarLayerSubdialog = False
        End If

        If rdoWordCloud.Checked Then
            sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsGeomTextWordcloudFunction, clsNewGlobalAesFunc:=clsGeomTextWordcloudAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
            sdgLayerOptions.ShowDialog()
            bResetBarLayerSubdialog = False
        End If
    End Sub

    Private Sub SetDialogOptions()
        If rdoValue.Checked Or rdoFrequency.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            cmdBarChartOptions.Visible = True
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameterByName("geom_col")
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("bar_plot")
            End If
            ucrVariablesAsFactorForBarChart.RemoveIncludedMetadataProperty("class")
            ucrVariablesAsFactorForBarChart.strSelectorHeading = "Variables"
        ElseIf rdoTreeMap.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTreemapAesFunction, iPosition:=1)
        Else
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomTextWordcloudAesFunction, iPosition:=1)
        End If

        ucrChkLollipop.Enabled = If(rdoValue.Checked, True, False)
        If rdoFrequency.Checked Then
            ucrChkLollipop.Checked = False
            If ucrVariablesAsFactorForBarChart.bSingleVariable Then
                ucrInputReorderX.Visible = True
                ucrInputAddReorder.Visible = True
            Else
                ucrInputReorderX.Visible = False
                ucrInputReorderX.SetText(strNone)
                ucrInputAddReorder.Visible = False
                ucrInputAddReorder.SetText(strNone)
            End If
        ElseIf rdoValue.Checked Then
            If ucrVariablesAsFactorForBarChart.bSingleVariable Then
                ucrInputReorderValue.Visible = True
                ucrInputAddReorder.Visible = True
            Else
                ucrInputReorderValue.Visible = False
                ucrInputReorderValue.SetText(strNone)
                ucrInputAddReorder.Visible = False
                ucrInputAddReorder.SetText(strNone)
            End If
        End If
    End Sub

    Private Sub UpdateParameter()
        Dim strChangedTextFreq As String = ucrInputReorderX.GetText()
        Dim strChangedTextValue As String = ucrInputAddReorder.GetText()
        Dim strChangeTextReorder As String = ucrInputReorderValue.GetText()
        If rdoFrequency.Checked Then
            clsForecatsInfreq.AddParameter("f", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            clsForecatsInfreqValue.AddParameter("f", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
            Select Case strChangedTextFreq
                Case strAscending
                    clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                Case strDescending
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsInfreq, iPosition:=0)
                Case strReverse
                    clsForecatsReverse.AddParameter("f", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            End Select
            Select Case strChangedTextValue
                Case strAscending
                    clsForecatsReverseValue.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
                Case strDescending
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=1)
                Case strReverse
                    clsForecatsReverseValue.AddParameter("f", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=1)
            End Select

        Else
            Select Case strChangeTextReorder
                Case strAscending
                    clsReorderFunction.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                Case strDescending
                    clsReorderFunction.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsReorderFunction, iPosition:=0)
                Case strReverse
                    clsForecatsReverse.AddParameter("f", ucrReceiverX.GetVariableNames(False), iPosition:=0)
                    clsBarAesFunction.AddParameter("x", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            End Select
            Select Case strChangedTextValue
                Case strAscending
                    clsReorderFunctionValue.AddParameter("X", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                Case strDescending
                    clsReorderFunctionValue.AddParameter("X", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsReorderFunctionValue, iPosition:=2)
                Case strReverse
                    clsForecatsReverseValue.AddParameter("f", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                    clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverseValue, iPosition:=2)
            End Select
        End If
    End Sub

    Private Sub ChangeButtonsText()
        If rdoValue.Checked Then
            If ucrChkLollipop.Checked Then
                cmdBarChartOptions.Text = "Lollipop Options"
            Else
                cmdBarChartOptions.Text = "Bar Chart Options"
            End If
        ElseIf rdoFrequency.Checked Then
            cmdBarChartOptions.Text = "Bar Chart Options"
        ElseIf rdoTreeMap.Checked Then
            cmdBarChartOptions.Text = "Treemap Options"
        ElseIf rdoWordCloud.Checked Then
            cmdBarChartOptions.Text = "Wordcloud Options"
        End If
    End Sub

    Private Sub ChangeParameterName()
        clsBarAesFunction.RemoveParameterByName("x")
        clsBarAesFunction.RemoveParameterByName("y")
        clsPieAesFunction.RemoveParameterByName("x")
        clsPieAesFunction.RemoveParameterByName("y")
        clsBaseOperator.RemoveParameterByName("geom_lollipop")
        If rdoValue.Checked Then
            clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsBarAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsPieAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsPieAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=2)
            clsRgeomBarFunction2.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_treemap_text")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
            If ucrReceiverX.IsEmpty Then
                clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
            End If
            If ucrVariablesAsFactorForBarChart.IsEmpty Then
                clsBarAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
                clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
            End If
            If ucrReceiverByFactor.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
                clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
            End If
            If ucrChkLollipop.Checked Then
                clsBaseOperator.AddParameter("geom_lollipop", clsRFunctionParameter:=clsGeomLollipopFunction, iPosition:=2)
            Else
                clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            End If
        ElseIf rdoFrequency.Checked Then
            If ucrVariablesAsFactorForBarChart.IsEmpty Then
                clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
            End If
            If ucrReceiverByFactor.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
                clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
            End If
            clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            clsPieAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
            clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
            clsRgeomBarFunction2.RemoveParameterByName("stat")
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
        ElseIf rdoTreeMap.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameterByName("geom_text")
            clsBaseOperator.RemoveParameterByName("geom_text_wordcloud")
            clsBaseOperator.AddParameter("geom_treemap", clsRFunctionParameter:=clsGeomTreemapFunction, iPosition:=2)
        ElseIf rdoWordCloud.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_treemap")
            clsBaseOperator.RemoveParameterByName("geom_treemap_text")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.AddParameter("geom_text_wordcloud", clsRFunctionParameter:=clsGeomTextWordcloudFunction, iPosition:=2)
            If ucrChkIncreaseSize.Checked Then
                clsBaseOperator.AddParameter("scale_size_area", clsRFunctionParameter:=clsScaleSizeAreaFunction, iPosition:=3)
            Else
                clsBaseOperator.RemoveParameterByName("scale_size_area")
            End If
        End If
        UpdateParameter()
        ChangeButtonsText()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged, ucrReceiverLabel.ControlValueChanged, ucrChkAddLabelsText.ControlValueChanged,
    ucrInputReorderX.ControlValueChanged, ucrInputAddReorder.ControlValueChanged, ucrInputReorderValue.ControlValueChanged, ucrNudMaxSize.ControlValueChanged, ucrChkIncreaseSize.ControlValueChanged
        SetDialogOptions()
        ChangeParameterName()
        If rdoTreeMap.Checked Then
            ucrReceiverArea.SetMeAsReceiver()
        End If
        If rdoWordCloud.Checked Then
            ucrReceiverWordcloudLabel.SetMeAsReceiver()
        End If
        ucrChkLollipop.Enabled = If(rdoValue.Checked, True, False)
    End Sub

    Private Sub ucrReceiverByFactor_ControlContentsChanged() Handles ucrReceiverByFactor.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        ucrChkBacktoback.Enabled = If(Not ucrReceiverByFactor.IsEmpty AndAlso (rdoFrequency.Checked OrElse rdoValue.Checked), True, False)
    End Sub

    Private Sub ucrReceiverX_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        If Not ucrReceiverX.Visible Then
            ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkBacktoback_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBacktoback.ControlValueChanged, ucrChkLollipop.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        If rdoFrequency.Checked OrElse rdoValue.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_bar1")
            clsBaseOperator.RemoveParameterByName("geom_bar2")
            clsBaseOperator.RemoveParameterByName("scale_y_symmetric")
            clsAesFunction1.RemoveParameterByName("y")
            clsAesFunction2.RemoveParameterByName("y")
            clsRgeomBarFunction2.RemoveParameterByName("aes")
            ucrChkPolarCoordinates.Enabled = True
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            clsRggplotFunction.RemoveParameterByName("aes")
            If ucrChkBacktoback.Checked Then
                ucrChkPolarCoordinates.Enabled = False
                ucrChkPolarCoordinates.Checked = Not ucrChkBacktoback.Checked
                clsBaseOperator.RemoveParameterByName("geom_bar")
                clsSubsetFunction1.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator1, iPosition:=1, bIncludeArgumentName:=False)
                clsSubsetFunction2.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator2, iPosition:=1, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("geom_bar2", clsRFunctionParameter:=clsRgeomBarFunction2, iPosition:=1)
                clsBaseOperator.AddParameter("geom_bar1", clsRFunctionParameter:=clsRgeomBarFunction1, iPosition:=2)
                clsBaseOperator.AddParameter("scale_y_symmetric", clsRFunctionParameter:=clsScaleYSymmetricFunction, iPosition:=3)
                If rdoValue.Checked Then
                    clsAesFunction1.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                    clsAesFunction2.AddParameter("y", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                    clsRgeomBarFunction2.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)
                    clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction2, iPosition:=1, bIncludeArgumentName:=False)
                Else
                    clsAesFunction1.AddParameter("y", "..count..*(-1)", iPosition:=0)
                    clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        End If
        ChangeParameterName()
        SetGeomTextOptions()
    End Sub

    Private Sub ucrChkPolarCoordinates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPolarCoordinates.ControlValueChanged, ucrPnlPolar.ControlValueChanged
        clsBaseOperator.RemoveParameterByName("coordpolar")
        ChangeParameterName()
        If Not rdoDonut.Checked OrElse Not ucrChkPolarCoordinates.Checked Then
            clsBaseOperator.RemoveParameterByName("scale")
        End If
        If Not rdoDonut.Checked OrElse Not rdoPie.Checked Then
            ChangeParameterName()
        End If
        If ucrChkPolarCoordinates.Checked Then
            ucrChkBacktoback.Checked = Not ucrChkPolarCoordinates.Checked
            clsRggplotFunction.RemoveParameterByName("mapping")
            clsRggplotFunction.AddParameter("aes", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1, bIncludeArgumentName:=False)
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
        If ucrInputBarChartPositions.GetText = "Dodge" Then
            clsGeomTextFunction.AddParameter("position", "position_dodge(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Fill" Then
            clsGeomTextFunction.AddParameter("position", "position_fill(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Jitter" Then
            clsGeomTextFunction.AddParameter("position", "position_jitter(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack in reverse" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.5, reverse = TRUE)", iPosition:=2)
        Else
            clsGeomTextFunction.AddParameter("position", "position_identity()", iPosition:=2)
        End If
        If rdoFrequency.Checked Then
            clsGeomTextFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=0)
            clsLabelAesFunction.AddParameter("label", "..count..", iPosition:=0)
        Else
            clsGeomTextFunction.RemoveParameterByName("stat")
            clsLabelAesFunction.AddParameter("label", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputBarChartPositions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBarChartPositions.ControlValueChanged
        SetGeomTextOptions()
    End Sub

    Private Sub ucrSaveBar_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForBarChart.ControlContentsChanged, ucrReceiverByFactor.ControlContentsChanged, ucrSaveBar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrChkBacktoback.ControlContentsChanged, ucrChkPolarCoordinates.ControlContentsChanged, ucrReceiverArea.ControlContentsChanged,
        ucrReceiverFill.ControlContentsChanged, ucrReceiverLabel.ControlContentsChanged, ucrChkAddLabelsText.ControlContentsChanged, ucrChkAddLabelsTreemap.ControlContentsChanged, ucrReceiverWordcloudLabel.ControlContentsChanged, ucrReceiverWordcloudSize.ControlContentsChanged, ucrReceiverWordcloudColor.ControlContentsChanged, ucrReceiverWordcloudAngle.ControlContentsChanged, ucrChkIncreaseSize.ControlContentsChanged
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