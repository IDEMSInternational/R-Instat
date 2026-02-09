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
    Public enumTwovarMode As String = TwovarMode.Describe
    Public Enum TwovarMode
        Describe
        Climatic
        Tricot
    End Enum

    Private clsBaseOperator, clsPairOperator, clsCoordPolarStartOperator As New ROperator
    Private clsRGGplotFunction, clsMosaicGgplotFunction, clsRFacet, clsThemeFunction,
            clsGlobalAes, clsLabsFunction, clsXlabsFunction, clsYlabFunction,
            clsXScaleContinuousFunction, clsYScaleContinuousFunction, clsCoordPolarFunction,
            clsXScaleDateFunction, clsYScaleDateFunction, clsScaleFillViridisFunction,
            clsScaleColourViridisFunction, clsPairThemesFunction As New RFunction
    'Geoms
    Private clsGeomJitter, clsGeomViolin, clsGeomBar, clsGeomMosaic, clsGeomBoxplot,
            clsGeomPoint, clsGeomLine, clsStatSummaryHline, clsStatSummaryCrossbar,
            clsGeomFreqPoly, clsGeomHistogram, clsGeomDensity, clsAnnotateFunction, clsGGpairsFunction,
            clsDummyFunction, clsGGpairAesFunction, clsUpperListFunction, clsLowerListFunction,
            clsDiagonalListFunction As New RFunction
    ' Use this aes for numeric by numeric graphs e.g. scatter and line plots
    Private clsAesNumericByNumeric As New RFunction
    ' Use this aes for categorical by categorical bar graphs
    Private clsAesCategoricalByCategoricalBarChart As New RFunction
    Private clsGgmosaicProduct As New RFunction
    ' Use this aes for categorical by categorical mosiac plots
    Private clsAesCategoricalByCategoricalMosaicPlot As New RFunction
    ' Use this aes for numeric by categorical when the y axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesNumericByCategoricalYNumeric As New RFunction
    ' Use this aes for numeric by categorical when the x axis is the numeric variable(s)  e.g. histogram, density
    Private clsAesNumericByCategoricalXNumeric As New RFunction
    ' Use this aes for categorical by numeric when the y axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesCategoricalByNumericYNumeric As New RFunction
    ' Aes for stat_summary hlineclsBaseOperator
    Private clsAesStatSummaryHlineCategoricalByNumeric As New RFunction
    Private clsAesStatSummaryHlineNumericByCategorical As New RFunction
    ' Use this aes for categorical by numeric when the x axis is the numeric variable(s) e.g. boxplot, violin, point
    Private clsAesCategoricalByNumericXNumeric As New RFunction
    Private clsLabelAesFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private strGeomParameterNames() As String = {"geom_jitter", "geom_violin", "geom_bar", "geom_mosaic", "geom_boxplot", "geom_point", "geom_line", "stat_summary_hline", "stat_summary_crossline", "geom_freqpoly", "geom_histogram", "geom_density"}

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsRFacetFunction As New RFunction

    Private strFirstVariablesType, strSecondVariableType, strThirdVariableType As String

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True
    Private bResetSubdialog As Boolean = True

    Private Sub dlgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim strNumericCategoricalPlots() As String
        Dim dctPositionPairs As New Dictionary(Of String, String)
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlByPairs.AddRadioButton(rdoBy)
        ucrPnlByPairs.AddRadioButton(rdoPairs)
        ucrPnlByPairs.AddRadioButton(rdoThreeVariable)

        ucrPnlByPairs.AddParameterValuesCondition(rdoBy, "checked", "by")
        ucrPnlByPairs.AddParameterValuesCondition(rdoPairs, "checked", "pair")
        ucrPnlByPairs.AddParameterValuesCondition(rdoThreeVariable, "checked", "three")

        ucrPnlByPairs.AddToLinkedControls({ucrReceiverSecondVar, ucrChkFlipCoordinates}, {rdoBy}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrChkLower, ucrReceiverColour}, {rdoPairs}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrReceiverThreeVariable, ucrReceiverThreeVariableSecond}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrChkLegend}, {rdoThreeVariable, rdoBy}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLower.SetLinkedDisplayControl(grpTypeOfDispaly)

        ucrSelectorTwoVarGraph.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoVarGraph.SetParameterIsrfunction()

        ucrReceiverFirstVars.Selector = ucrSelectorTwoVarGraph
        ucrReceiverFirstVars.SetMultipleOnlyStatus(True)
        ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(False)

        ucrReceiverColour.SetParameter(New RParameter("colour", iNewPosition:=0))
        ucrReceiverColour.SetParameterIsString()
        ucrReceiverColour.SetDataType("factor")
        ucrReceiverColour.strSelectorHeading = "Factors"
        ucrReceiverColour.Selector = ucrSelectorTwoVarGraph
        ucrReceiverColour.SetLinkedDisplayControl(lblColour)
        ucrReceiverColour.bWithQuotes = False

        ucrReceiverSecondVar.SetParameter(New RParameter("fill", 0))
        ucrReceiverSecondVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.bWithQuotes = False
        ucrReceiverSecondVar.SetLinkedDisplayControl(lblSecondVariable)

        ucrReceiverThreeVariableSecond.SetParameter(New RParameter("second_variable", 2, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableSecond.Selector = ucrSelectorTwoVarGraph
        ucrReceiverThreeVariableSecond.SetParameterIsString()
        ucrReceiverThreeVariableSecond.bWithQuotes = False
        ucrReceiverThreeVariableSecond.SetLinkedDisplayControl(lblThreeVariableSecond)

        ucrReceiverThreeVariable.SetParameter(New RParameter("third_variable", 3, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariable.Selector = ucrSelectorTwoVarGraph
        ucrReceiverThreeVariable.SetParameterIsString()
        ucrReceiverThreeVariable.bWithQuotes = False
        ucrReceiverThreeVariable.SetLinkedDisplayControl(lblThreeVariable)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorTwoVarGraph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrInputNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Line plot + points"})
        ucrInputNumericByNumeric.SetName("Scatter plot")
        ucrInputNumericByNumeric.SetDropDownStyleAsNonEditable()

        strNumericCategoricalPlots = {"Boxplot", "Point plot", "Jitter plot", "Violin plot", "Boxplot + Jitter", "Violin plot + Jitter plot", "Violin plot + Boxplot", "Summary Plot", "Summary Plot + Points", "Histogram", "Density plot", "Frequency polygon"}

        ucrInputNumericByCategorical.SetItems(strNumericCategoricalPlots)
        ucrInputNumericByCategorical.SetName("Boxplot")
        ucrInputNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByNumeric.SetItems(strNumericCategoricalPlots)
        ucrInputCategoricalByNumeric.SetName("Summary Plot + Points")
        ucrInputCategoricalByNumeric.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByCategorical.SetItems({"Bar Chart", "Mosaic Plot"})
        ucrInputCategoricalByCategorical.SetName("Bar Chart")
        ucrInputCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        ucrChkAddLabelsText.SetText("Add Labels")
        ucrChkAddLabelsText.AddParameterPresentCondition(True, "text")
        ucrChkAddLabelsText.AddParameterPresentCondition(False, "text", False)
        ucrChkAddLabelsText.AddToLinkedControls({ucrInputLabelPosition, ucrInputLabelSize, ucrInputLabelColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLabelColour.SetLinkedDisplayControl(lblLabelColour)
        ucrInputLabelPosition.SetLinkedDisplayControl(lblLabelPosition)
        ucrInputLabelSize.SetLinkedDisplayControl(lblLabelSize)

        ucrChkColour.SetText("Colour")
        ucrChkColour.Enabled = False

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

        ucrInputLabelPosition.SetParameter(New RParameter("vjust", 2))
        dctLabelPositions.Add("Out", "-0.25")
        dctLabelPositions.Add("In", "5")
        ucrInputLabelPosition.SetItems(dctLabelPositions)
        ucrInputLabelPosition.SetDropDownStyleAsNonEditable()

        ucrInputLabelColour.SetParameter(New RParameter("colour", 4))
        dctLabelColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLabelColours.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputLabelColour.SetItems(dctLabelColours)
        ucrInputLabelColour.bAllowNonConditionValues = True

        ucrInputLabelSize.SetParameter(New RParameter("size", 5))
        dctLabelSizes.Add("Default", "4")
        dctLabelSizes.Add("Small", "3")
        dctLabelSizes.Add("Big", "7")
        ucrInputLabelSize.SetItems(dctLabelSizes)
        ucrInputLabelSize.SetDropDownStyleAsNonEditable()

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkFlipCoordinates.SetLinkedDisplayControl(New List(Of Control)({grpSummaries, grpOptions}))

        ucrChkFreeScaleYAxis.SetText("Free Scale Y Axis")
        ucrChkFreeScaleYAxis.SetParameter(New RParameter("scales", iNewPosition:=3), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=False)
        ucrChkFreeScaleYAxis.AddParameterPresentCondition(True, "scales")
        ucrChkFreeScaleYAxis.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)})

        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputPosition.SetParameter(New RParameter("position", 0))
        ucrInputPosition.SetItems(dctPositionPairs)
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrInputPosition.SetRDefault(Chr(34) & "stack" & Chr(34))
        ucrInputPosition.SetLinkedDisplayControl(lblPosition)

        ucrNudJitter.SetParameter(New RParameter("width", 2))
        ucrNudJitter.Minimum = 0
        ucrNudJitter.DecimalPlaces = 2
        ucrNudJitter.Increment = 0.01
        ucrNudJitter.SetLinkedDisplayControl(lblPointJitter)

        ucrNudTransparency.SetParameter(New RParameter("alpha", 2))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01
        ucrNudTransparency.SetLinkedDisplayControl(lblPointTransparency)
        ucrNudTransparency.SetRDefault(1)

        ucrChkDiagonal.SetText("Diagonal")
        ucrChkDiagonal.AddParameterPresentCondition(True, "diag")
        ucrChkDiagonal.AddParameterPresentCondition(False, "diag", False)
        ucrChkDiagonal.AddToLinkedControls({ucrInputDiagonalContinous, ucrInputDiagonalDiscrete,
                                           ucrInputDiagonalNA}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLower.SetText("Lower")
        ucrChkLower.AddParameterPresentCondition(True, "lower")
        ucrChkLower.AddParameterPresentCondition(False, "lower", False)
        ucrChkLower.AddToLinkedControls({ucrInputLowerContinous, ucrInputLowerDiscrete, ucrInputLowerCombo,
                                           ucrInputLowerNA}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkUpper.SetText("Upper")
        ucrChkUpper.AddParameterPresentCondition(True, "upper")
        ucrChkUpper.AddParameterPresentCondition(False, "upper", False)
        ucrChkUpper.AddToLinkedControls({ucrInputUpperContinous, ucrInputUpperDiscrete, ucrInputUpperCombo,
                                           ucrInputUpperNA}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLowerContinous.SetParameter(New RParameter("continuous", iNewPosition:=0))
        ucrInputLowerContinous.SetItems({"points", "smooth", "smooth_loess", "density", "cor", "blank"}, bAddConditions:=True)
        ucrInputLowerContinous.SetLinkedDisplayControl(lblLowerContinous)

        ucrInputLowerCombo.SetParameter(New RParameter("combo", iNewPosition:=1))
        ucrInputLowerCombo.SetItems({"box", "box_no_facet", "dot", "dot_no_facet", "facethist", "facetdensity",
                                    "denstrip", "blank"}, bAddConditions:=True)
        ucrInputLowerCombo.SetLinkedDisplayControl(lblLowerCombo)

        ucrInputLowerDiscrete.SetParameter(New RParameter("discrete", iNewPosition:=2))
        ucrInputLowerDiscrete.SetItems({"facetbar", "ratio", "blank"}, bAddConditions:=True)
        ucrInputLowerDiscrete.SetLinkedDisplayControl(lblLowerDiscrete)

        ucrInputLowerNA.SetParameter(New RParameter("na", iNewPosition:=3))
        ucrInputLowerNA.SetItems({"na", "blank"}, bAddConditions:=True)
        ucrInputLowerNA.SetLinkedDisplayControl(lblLowerNA)

        ucrInputUpperContinous.SetParameter(New RParameter("continuous", iNewPosition:=0))
        ucrInputUpperContinous.SetItems({"point", "smooth", "smooth_loess", "density", "cor", "blank"}, bAddConditions:=True)
        ucrInputUpperContinous.SetLinkedDisplayControl(lblUpperContinous)

        ucrInputUpperCombo.SetParameter(New RParameter("combo", iNewPosition:=1))
        ucrInputUpperCombo.SetItems({"box", "box_no_facet", "dot", "dot_no_facet", "facethist", "facetdensity",
                                    "denstrip", "blank"}, bAddConditions:=True)
        ucrInputUpperCombo.SetLinkedDisplayControl(lblUpperCombo)

        ucrInputUpperDiscrete.SetParameter(New RParameter("discrete", iNewPosition:=2))
        ucrInputUpperDiscrete.SetItems({"facetbar", "count", "ratio", "blank"}, bAddConditions:=True)
        ucrInputUpperDiscrete.SetLinkedDisplayControl(lblUpperDiscrete)

        ucrInputUpperNA.SetParameter(New RParameter("na", iNewPosition:=3))
        ucrInputUpperNA.SetItems({"na", "blank"}, bAddConditions:=True)
        ucrInputUpperNA.SetLinkedDisplayControl(lblUpperNA)

        ucrInputDiagonalContinous.SetParameter(New RParameter("continuous", iNewPosition:=0))
        ucrInputDiagonalContinous.SetItems({"densityDiag", "barDiag", "blankDiag"}, bAddConditions:=True)
        ucrInputDiagonalContinous.SetLinkedDisplayControl(lblDiagonalContinuous)

        ucrInputDiagonalDiscrete.SetParameter(New RParameter("discrete", iNewPosition:=1))
        ucrInputDiagonalDiscrete.SetItems({"barDiag", "blankDiag"}, bAddConditions:=True)
        ucrInputDiagonalDiscrete.SetLinkedDisplayControl(lblDiagonalDiscrete)

        ucrInputDiagonalNA.SetParameter(New RParameter("na", iNewPosition:=2))
        ucrInputDiagonalNA.SetItems({"naDiag", "blankDiag"}, bAddConditions:=True)
        ucrInputDiagonalNA.SetLinkedDisplayControl(lblDiagonalNA)

        ucrSaveGraph.SetPrefix("two_var")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStation.ControlValueChanged

    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore)

    End Sub

    Private Sub SetDefaults()
        clsGGpairsFunction = New RFunction
        clsRGGplotFunction = New RFunction
        clsPairThemesFunction = New RFunction
        clsMosaicGgplotFunction = New RFunction
        clsDummyFunction = New RFunction
        clsPairOperator = New ROperator
        clsRFacet = New RFunction
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsGlobalAes = New RFunction
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()

        clsGeomBoxplot = New RFunction
        clsGeomJitter = New RFunction
        clsGeomViolin = New RFunction
        clsGeomPoint = New RFunction
        clsGeomLine = New RFunction
        clsGeomBar = New RFunction
        clsGeomFreqPoly = New RFunction
        clsGeomHistogram = New RFunction
        clsGeomDensity = New RFunction
        clsGeomMosaic = New RFunction
        clsGgmosaicProduct = New RFunction
        clsStatSummaryHline = New RFunction

        clsAesNumericByNumeric = New RFunction
        clsAesCategoricalByCategoricalBarChart = New RFunction
        clsAesCategoricalByCategoricalMosaicPlot = New RFunction
        clsAesNumericByCategoricalYNumeric = New RFunction
        clsAesNumericByCategoricalXNumeric = New RFunction
        clsAesCategoricalByNumericYNumeric = New RFunction
        clsAesCategoricalByNumericXNumeric = New RFunction
        clsAesStatSummaryHlineCategoricalByNumeric = New RFunction
        clsAesStatSummaryHlineNumericByCategorical = New RFunction
        clsGGpairAesFunction = New RFunction
        clsUpperListFunction = New RFunction
        clsLowerListFunction = New RFunction
        clsDiagonalListFunction = New RFunction
        clsGeomTextFunction = New RFunction
        clsLabelAesFunction = New RFunction
        clsBaseOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        bResetSubdialog = True

        'Reset
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()

        ucrReceiverFirstVars.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "pair", iPosition:=0)

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=0)
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")
        clsLabelAesFunction.AddParameter("label", "..count..", iPosition:=0)

        clsUpperListFunction.SetRCommand("list")
        clsUpperListFunction.AddParameter("continuous", Chr(34) & "cor" & Chr(34), iPosition:=0)
        clsUpperListFunction.AddParameter("combo", Chr(34) & "box_no_facet" & Chr(34), iPosition:=1)
        clsUpperListFunction.AddParameter("discrete", Chr(34) & "count" & Chr(34), iPosition:=2)
        clsUpperListFunction.AddParameter("na", Chr(34) & "na" & Chr(34), iPosition:=3)

        clsLowerListFunction.SetRCommand("list")
        clsLowerListFunction.AddParameter("continuous", Chr(34) & "points" & Chr(34), iPosition:=0)
        clsLowerListFunction.AddParameter("combo", Chr(34) & "facethist" & Chr(34), iPosition:=1)
        clsLowerListFunction.AddParameter("discrete", Chr(34) & "facetbar" & Chr(34), iPosition:=2)
        clsLowerListFunction.AddParameter("na", Chr(34) & "na" & Chr(34), iPosition:=3)

        clsDiagonalListFunction.SetRCommand("list")
        clsDiagonalListFunction.AddParameter("continuous", Chr(34) & "densityDiag" & Chr(34), iPosition:=0)
        clsDiagonalListFunction.AddParameter("discrete", Chr(34) & "barDiag" & Chr(34), iPosition:=1)
        clsDiagonalListFunction.AddParameter("na", Chr(34) & "naDiag" & Chr(34), iPosition:=2)

        clsGGpairAesFunction.SetPackageName("ggplot2")
        clsGGpairAesFunction.SetRCommand("aes")

        clsGGpairsFunction.SetPackageName("GGally")
        clsGGpairsFunction.SetRCommand("ggpairs")

        clsPairThemesFunction.SetPackageName("ggplot2")
        clsPairThemesFunction.SetRCommand("theme")
        clsPairThemesFunction.AddParameter("legend.position", Chr(34) & "none" & Chr(34), iPosition:=0)

        clsPairOperator.SetOperation("+")
        clsPairOperator.AddParameter("left", clsRFunctionParameter:=clsGGpairsFunction, iPosition:=0)

        clsBaseOperator.SetOperation("+")

        clsRGGplotFunction.SetPackageName("ggplot2")
        clsRGGplotFunction.SetRCommand("ggplot")

        clsMosaicGgplotFunction.SetPackageName("ggplot2")
        clsMosaicGgplotFunction.SetRCommand("ggplot")

        clsRFacet.SetPackageName("ggplot2")
        clsRFacet.SetRCommand("facet_wrap")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)


        clsGeomViolin.SetPackageName("ggplot2")
        clsGeomViolin.SetRCommand("geom_violin")

        clsGeomJitter.SetPackageName("ggplot2")
        clsGeomJitter.SetRCommand("geom_jitter")
        clsGeomJitter.AddParameter("width", "0.2", iPosition:=4)
        clsGeomJitter.AddParameter("height", "0", iPosition:=5)
        clsGeomJitter.AddParameter("alpha", "0.4", iPosition:=6)

        clsGeomBoxplot.SetPackageName("ggplot2")
        clsGeomBoxplot.SetRCommand("geom_boxplot")

        clsGeomMosaic.SetPackageName("ggmosaic")
        clsGeomMosaic.SetRCommand("geom_mosaic")

        clsAesNumericByNumeric.SetPackageName("ggplot2")
        clsAesNumericByNumeric.SetRCommand("aes")
        clsAesNumericByNumeric.AddParameter("y", "value")

        clsAesNumericByCategoricalYNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalYNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalYNumeric.AddParameter("y", "value", iPosition:=1)

        clsAesNumericByCategoricalXNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalXNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalXNumeric.AddParameter("x", "value", iPosition:=1)

        clsAesCategoricalByNumericYNumeric.SetPackageName("ggplot2")
        clsAesCategoricalByNumericYNumeric.SetRCommand("aes")
        clsAesCategoricalByNumericYNumeric.AddParameter("x", "value", iPosition:=0)

        clsAesCategoricalByNumericXNumeric.SetPackageName("ggplot2")
        clsAesCategoricalByNumericXNumeric.SetRCommand("aes")
        clsAesCategoricalByNumericXNumeric.AddParameter("colour", "value", iPosition:=1)

        clsAesNumericByCategoricalXNumeric.SetPackageName("ggplot2")
        clsAesNumericByCategoricalXNumeric.SetRCommand("aes")
        clsAesNumericByCategoricalXNumeric.AddParameter("x", "value", iPosition:=1)

        clsAesCategoricalByCategoricalBarChart.SetPackageName("ggplot2")
        clsAesCategoricalByCategoricalBarChart.SetRCommand("aes")
        clsAesCategoricalByCategoricalBarChart.AddParameter("x", "value")

        clsAesCategoricalByCategoricalMosaicPlot.SetPackageName("ggplot2")
        clsAesCategoricalByCategoricalMosaicPlot.SetRCommand("aes")
        clsAesCategoricalByCategoricalMosaicPlot.AddParameter("x", clsRFunctionParameter:=clsGgmosaicProduct, iPosition:=0)
        clsAesCategoricalByCategoricalMosaicPlot.AddParameter("fill", "value", iPosition:=1)

        clsAesStatSummaryHlineCategoricalByNumeric.SetPackageName("ggplot2")
        clsAesStatSummaryHlineCategoricalByNumeric.SetRCommand("aes")
        clsAesStatSummaryHlineCategoricalByNumeric.AddParameter("x", "1", iPosition:=0)
        clsAesStatSummaryHlineCategoricalByNumeric.AddParameter("yintercept", "..y..", iPosition:=2)

        clsAesStatSummaryHlineNumericByCategorical.SetPackageName("ggplot2")
        clsAesStatSummaryHlineNumericByCategorical.SetRCommand("aes")
        clsAesStatSummaryHlineNumericByCategorical.AddParameter("x", "1", iPosition:=0)
        clsAesStatSummaryHlineNumericByCategorical.AddParameter("y", "value", iPosition:=1)
        clsAesStatSummaryHlineNumericByCategorical.AddParameter("yintercept", "..y..", iPosition:=2)

        clsGgmosaicProduct.SetPackageName("ggmosaic")
        clsGgmosaicProduct.SetRCommand("product")

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")

        clsGeomBar.SetPackageName("ggplot2")
        clsGeomBar.SetRCommand("geom_bar")
        clsGeomBar.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)
        clsGeomBar.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        clsGeomFreqPoly.SetPackageName("ggplot2")
        clsGeomFreqPoly.SetRCommand("geom_freqpoly")

        clsGeomDensity.SetPackageName("ggplot2")
        clsGeomDensity.SetRCommand("geom_density")

        clsGeomHistogram.SetPackageName("ggplot2")
        clsGeomHistogram.SetRCommand("geom_histogram")
        clsGeomHistogram.AddParameter("position", Chr(34) & "dodge" & Chr(34))

        clsStatSummaryHline.SetPackageName("ggplot2")
        clsStatSummaryHline.SetRCommand("stat_summary")
        clsStatSummaryHline.AddParameter("geom", Chr(34) & "hline" & Chr(34), iPosition:=2)
        clsStatSummaryHline.AddParameter("fun.y", Chr(34) & "mean" & Chr(34), iPosition:=3)
        clsStatSummaryHline.AddParameter("inherit.aes", "FALSE", iPosition:=4)

        clsStatSummaryCrossbar.SetPackageName("ggplot2")
        clsStatSummaryCrossbar.SetRCommand("stat_summary")
        clsStatSummaryCrossbar.AddParameter("geom", Chr(34) & "crossbar" & Chr(34), iPosition:=2)
        clsStatSummaryCrossbar.AddParameter("fun.y", Chr(34) & "mean" & Chr(34), iPosition:=3)
        clsStatSummaryCrossbar.AddParameter("fun.ymax", Chr(34) & "mean" & Chr(34), iPosition:=4)
        clsStatSummaryCrossbar.AddParameter("fun.ymin", Chr(34) & "mean" & Chr(34), iPosition:=5)
        clsStatSummaryCrossbar.AddParameter("size", "0.5", iPosition:=6)
        clsStatSummaryCrossbar.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=7)

        clsBaseOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsRFacet)
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRGGplotFunction, iPosition:=0)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsPairOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsPairOperator)

        AddDataFrame()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByCategoricalYNumeric, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByCategoricalXNumeric, New RParameter("colour", 2), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesCategoricalByNumericYNumeric, New RParameter("y", 1), iAdditionalPairNo:=3)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesCategoricalByNumericXNumeric, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesNumericByNumeric, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsAesStatSummaryHlineCategoricalByNumeric, New RParameter("y", 1), iAdditionalPairNo:=6)
        ucrSaveGraph.AddAdditionalRCode(clsPairOperator, bReset)

        ucrSelectorTwoVarGraph.SetRCode(clsRGGplotFunction, bReset)
        ucrReceiverSecondVar.SetRCode(clsAesCategoricalByCategoricalBarChart, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkFreeScaleYAxis.SetRCode(clsRFacet, bReset)
        ucrInputPosition.SetRCode(clsGeomBar, bReset)
        ucrNudJitter.SetRCode(clsGeomJitter, bReset)
        ucrNudTransparency.SetRCode(clsGeomJitter, bReset)
        ucrPnlByPairs.SetRCode(clsDummyFunction, bReset)
        ucrReceiverColour.SetRCode(clsGGpairAesFunction, bReset)
        ucrInputLowerContinous.SetRCode(clsLowerListFunction, bReset)
        ucrInputLowerDiscrete.SetRCode(clsLowerListFunction, bReset)
        ucrInputLowerCombo.SetRCode(clsLowerListFunction, bReset)
        ucrInputLowerNA.SetRCode(clsLowerListFunction, bReset)
        ucrInputUpperContinous.SetRCode(clsUpperListFunction, bReset)
        ucrInputUpperDiscrete.SetRCode(clsUpperListFunction, bReset)
        ucrInputUpperCombo.SetRCode(clsUpperListFunction, bReset)
        ucrInputUpperNA.SetRCode(clsUpperListFunction, bReset)
        ucrInputDiagonalContinous.SetRCode(clsDiagonalListFunction, bReset)
        ucrInputDiagonalDiscrete.SetRCode(clsDiagonalListFunction, bReset)
        ucrInputDiagonalNA.SetRCode(clsDiagonalListFunction, bReset)
        ucrChkLower.SetRCode(clsGGpairsFunction, bReset)
        ucrChkUpper.SetRCode(clsGGpairsFunction, bReset)
        ucrChkDiagonal.SetRCode(clsGGpairsFunction, bReset)
        ucrInputLabelPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputLabelColour.SetRCode(clsGeomTextFunction, bReset)
        ucrInputLabelSize.SetRCode(clsGeomTextFunction, bReset)

        bRCodeSet = True
        Results()
        ThreeVariableResult()
        SetFreeYAxis()
        EnableVisibleLabelControls()
    End Sub

    Private Sub TestOkEnabled()
        If rdoBy.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty AndAlso Not ucrReceiverSecondVar.IsEmpty AndAlso ucrSaveGraph.IsComplete)
        Else
            ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Public Sub Results()
        Dim lstFirstItemTypes As List(Of String)

        If bRCodeSet Then
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

            ucrChkFreeScaleYAxis.Visible = True
            ucrInputPosition.Visible = False
            ucrNudJitter.Visible = False
            ucrNudTransparency.Visible = False
            lblGraphName.Visible = False
            ucrInputNumericByNumeric.Visible = False
            ucrInputCategoricalByNumeric.Visible = False
            ucrInputNumericByCategorical.Visible = False
            ucrInputCategoricalByCategorical.Visible = False
            RemoveAllGeomsStats()
            If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
                ucrInputNumericByNumeric.Visible = True
                AddRemoveFreeScaleX(False)
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
                clsGlobalAes = clsAesNumericByNumeric
                Select Case ucrInputNumericByNumeric.GetText
                    Case "Scatter plot"
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                    Case "Line plot"
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                    Case "Line plot + points"
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
                ucrInputCategoricalByNumeric.Visible = True
                ucrChkFreeScaleYAxis.Checked = False
                ucrChkFreeScaleYAxis.Visible = False
                AddRemoveFreeScaleX(True)
                Select Case ucrInputCategoricalByNumeric.GetText
                    Case "Boxplot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Summary Plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                        clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                        clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                    Case "Summary Plot + Points"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericYNumeric
                        clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                        clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                        clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                    Case "Histogram"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericXNumeric
                        clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                    Case "Density plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                    Case "Frequency polygon"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericXNumeric
                        clsBaseOperator.AddParameter("geom_freqpoly", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                ucrInputNumericByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                Select Case ucrInputNumericByCategorical.GetText
                    Case "Boxplot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=0)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Summary Plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                        clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                        clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                    Case "Summary Plot + Points"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                        clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                        clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                    Case "Histogram"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalXNumeric
                        clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                    Case "Density plot"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                    Case "Frequency polygon"
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalXNumeric
                        clsBaseOperator.AddParameter("geom_freqpolygon", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                ucrInputCategoricalByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                If ucrInputCategoricalByCategorical IsNot Nothing Then
                    Select Case ucrInputCategoricalByCategorical.GetText
                        Case "Bar Chart"
                            ucrInputPosition.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                            clsGlobalAes = clsAesCategoricalByCategoricalBarChart
                            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
                        Case "Mosaic Plot"
                            clsRGGplotFunction.RemoveParameterByName("mapping")
                            clsGlobalAes = GgplotDefaults.clsAesFunction.Clone()
                            clsGeomMosaic.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalMosaicPlot, iPosition:=0)
                            clsBaseOperator.AddParameter("geom_mosaic", clsRFunctionParameter:=clsGeomMosaic, iPosition:=1)
                    End Select
                End If
            Else
                lblGraphName.Visible = True
                lblGraphName.Text = "__________"
                lblGraphName.ForeColor = SystemColors.ControlText
                clsGlobalAes = GgplotDefaults.clsAesFunction.Clone()
            End If
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverFirstVars_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged
        Dim iPosition As Integer = 0
        Dim iNumVariables As Integer = ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False).Count
        Results()
        ThreeVariableResult()
        EnableVisibleLabelControls()
        clsGGpairsFunction.AddParameter("columns", ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNames(), iPosition:=1)
        clsGgmosaicProduct.ClearParameters()
        For Each strVariables In ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False)
            clsGgmosaicProduct.AddParameter("columns" & iPosition, strVariables,
                                            iPosition:=iPosition, bIncludeArgumentName:=False)
            iPosition = iPosition + 1
        Next
        ChangeGeomToMosaicAndFacet()

        If iNumVariables > 0 Then
            clsAesCategoricalByCategoricalMosaicPlot.AddParameter("fill", ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False)(0), iPosition:=1)
        End If
    End Sub

    Private Sub ucrReceiverSecondVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlValueChanged
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        Results()
        EnableVisibleLabelControls()
        ChangeGeomToMosaicAndFacet()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlContentsChanged,
        ucrReceiverFirstVars.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged,
        ucrPnlByPairs.ControlContentsChanged, ucrReceiverColour.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCategoricalByCategorical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNumericByNumeric.ControlValueChanged, ucrInputNumericByCategorical.ControlValueChanged, ucrInputCategoricalByNumeric.ControlValueChanged, ucrInputCategoricalByCategorical.ControlValueChanged
        Results()
        ThreeVariableResult()
        EnableVisibleLabelControls()
        AddRemoveTextParameter()
        ChangeGeomToMosaicAndFacet()
    End Sub

    Private Sub RemoveAllGeomsStats()
        If clsBaseOperator.clsParameters.Count > 0 Then
            For i As Integer = (clsBaseOperator.clsParameters.Count - 1) To 0 Step -1
                If clsBaseOperator.clsParameters(i).strArgumentName.StartsWith("geom") OrElse clsBaseOperator.clsParameters(i).strArgumentName.StartsWith("stat") Then
                    clsBaseOperator.RemoveParameter(clsBaseOperator.clsParameters(i))
                End If
            Next
        End If
    End Sub

    Private Sub ucrChkFreeScaleYAxis_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFreeScaleYAxis.ControlValueChanged
        SetFreeYAxis()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsGlobalAes, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
                          clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                          clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsRFacet, clsNewCoordPolarFunction:=clsCoordPolarFunction,
                          clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorTwoVarGraph,
                          clsNewAnnotateFunction:=clsAnnotateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        sdgPlots.tbpFacet.Enabled = True
        clsRFacet.AddParameter("facets", "~variable", iPosition:=0)
        bResetSubdialog = False
    End Sub

    Private Sub cmdPairOptions_Click(sender As Object, e As EventArgs) Handles cmdPairOptions.Click
        sdgPairPlotOptions.SetRCode(clsNewPairOperator:=clsPairOperator, clsNewPairThemesFunction:=clsPairThemesFunction, clsNewGGpairAesFunction:=clsGGpairsFunction, bReset:=bResetSubdialog)

        sdgPairPlotOptions.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub SetFreeYAxis()
        Dim clsScaleParam As RParameter
        Dim strXName As String
        Dim strYName As String

        If IsCoordFlip() Then
            strXName = "y"
            strYName = "x"
        Else
            strXName = "x"
            strYName = "y"
        End If
        If bRCodeSet Then
            If ucrChkFreeScaleYAxis.Checked Then
                If clsRFacet.ContainsParameter("scales") Then
                    clsScaleParam = clsRFacet.GetParameter("scales")
                    If clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) Then
                        clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34)
                    Else
                        clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34)
                    End If
                Else
                    clsRFacet.AddParameter("scales", Chr(34) & "free_" & strYName & Chr(34), iPosition:=3)
                End If
            Else
                If clsRFacet.ContainsParameter("scales") Then
                    clsScaleParam = clsRFacet.GetParameter("scales")
                    If clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34) Then
                        clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34)
                    Else
                        clsRFacet.RemoveParameter(clsScaleParam)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveFreeScaleX(bAdd As Boolean)
        Dim clsScaleParam As RParameter
        Dim strXName As String
        Dim strYName As String

        If IsCoordFlip() Then
            strXName = "y"
            strYName = "x"
        Else
            strXName = "x"
            strYName = "y"
        End If
        If bAdd Then
            If clsRFacet.ContainsParameter("scales") Then
                clsScaleParam = clsRFacet.GetParameter("scales")
                If clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34)
                Else
                    clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34)
                End If
            Else
                clsRFacet.AddParameter("scales", Chr(34) & "free_" & strXName & Chr(34), iPosition:=3)
            End If
        Else
            If clsRFacet.ContainsParameter("scales") Then
                clsScaleParam = clsRFacet.GetParameter("scales")
                If clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free_y" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34)
                Else
                    clsRFacet.RemoveParameter(clsScaleParam)
                End If
            End If
        End If
    End Sub

    Private Function IsCoordFlip() As Boolean
        Return clsBaseOperator.ContainsParameter("coord_flip")
    End Function

    Private Sub ucrFlipCoordinates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFlipCoordinates.ControlValueChanged
        Dim clsScaleParam As RParameter

        If bRCodeSet Then
            If clsRFacet.ContainsParameter("scales") Then
                clsScaleParam = clsRFacet.GetParameter("scales")
                If clsScaleParam.strArgumentValue = Chr(34) & "free_x" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free_y" & Chr(34)
                ElseIf clsScaleParam.strArgumentValue = Chr(34) & "free_y" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free_x" & Chr(34)
                End If
            End If
            ucrChkFreeScaleYAxis.ClearConditions()
            ucrChkFreeScaleYAxis.AddParameterPresentCondition(True, "scales")
            If ucrChkFlipCoordinates.Checked Then
                ucrChkFreeScaleYAxis.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_x" & Chr(34)})
            Else
                ucrChkFreeScaleYAxis.AddParameterValuesCondition(True, "scales", {Chr(34) & "free" & Chr(34), Chr(34) & "free_y" & Chr(34)})
            End If
        End If
    End Sub

    Private Sub ucrPnlByPairs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlByPairs.ControlValueChanged
        ucrReceiverFirstVars.ucrMultipleVariables.Clear()
        ucrReceiverFirstVars.SetMeAsReceiver()
        If rdoBy.Checked Then
            ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        Else
            ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(False)
        End If
        If bRCodeSet Then
            If rdoBy.Checked Then
                ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
                clsDummyFunction.AddParameter("checked", "by", iPosition:=0)
            Else
                ucrBase.clsRsyntax.SetBaseROperator(clsPairOperator)
                clsDummyFunction.AddParameter("checked", "pair", iPosition:=0)
            End If
        End If
        EnableVisibleLabelControls()
        AddRemoveColourParameter()
        ChangeGeomToMosaicAndFacet()
        HideShowOptions()
    End Sub

    Private Sub ucrSelectorTwoVarGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTwoVarGraph.ControlValueChanged
        AddDataFrame()
    End Sub

    Private Sub AddDataFrame()
        Dim clsGetDataFrameFunction As RFunction = ucrSelectorTwoVarGraph.ucrAvailableDataFrames.clsCurrDataFrame.Clone
        clsGetDataFrameFunction.RemoveParameterByName("stack_data")
        clsGGpairsFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsMosaicGgplotFunction.AddParameter("data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
    End Sub

    Private Sub ucrReceiverColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColour.ControlValueChanged
        AddRemoveColourParameter()
        HideShowOptions()
    End Sub

    Private Sub HideShowOptions()
        cmdOptions.Visible = Not rdoPairs.Checked
        cmdPairOptions.Visible = rdoPairs.Checked
        cmdPairOptions.Enabled = cmdPairOptions.Visible AndAlso Not ucrReceiverColour.IsEmpty
    End Sub

    Private Sub AddRemoveColourParameter()
        If Not ucrReceiverColour.IsEmpty And rdoPairs.Checked Then
            clsGGpairsFunction.AddParameter("colour", clsRFunctionParameter:=clsGGpairAesFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGGpairsFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub EnableVisibleLabelControls()
        ucrChkAddLabelsText.Visible = False
        ucrInputLabelPosition.Visible = False
        ucrInputLabelColour.Visible = False
        ucrInputLabelSize.Visible = False
        grpSummaries.Visible = rdoThreeVariable.Checked OrElse rdoBy.Checked
        ucrChkLegend.Visible = rdoThreeVariable.Checked OrElse rdoBy.Checked
        ucrInputStation.Visible = rdoThreeVariable.Checked OrElse rdoBy.Checked
        ucr1stFactorReceiver.Visible = rdoThreeVariable.Checked OrElse rdoBy.Checked
        lblFacetBy.Visible = rdoThreeVariable.Checked OrElse rdoBy.Checked
        grpOptions.Visible = rdoBy.Checked OrElse rdoThreeVariable.Checked
        lblThirdType.Visible = rdoThreeVariable.Checked
        lblThreeBy.Visible = rdoThreeVariable.Checked
        ucrChkColour.Visible = rdoBy.Checked
        If rdoBy.Checked AndAlso strFirstVariablesType = "categorical" AndAlso
            strSecondVariableType = "categorical" AndAlso bRCodeSet AndAlso
           ucrInputCategoricalByCategorical.GetText = "Bar Chart" Then
            ucrChkAddLabelsText.Visible = True
            ucrChkAddLabelsText.SetRCode(clsBaseOperator)
        End If
        If ucrReceiverFirstVars.ucrMultipleVariables.Count > 1 Then
            ucrInputStation.Enabled = False
            ucr1stFactorReceiver.Enabled = False
        Else
            ucrInputStation.Enabled = True
            ucr1stFactorReceiver.Enabled = True
        End If
    End Sub

    Private Sub ucrChkAddLabelsText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabelsText.ControlValueChanged
        AddRemoveTextParameter()
    End Sub

    Private Sub ChangeGeomToMosaicAndFacet()
        If rdoBy.Checked AndAlso strFirstVariablesType = "categorical" AndAlso
            strSecondVariableType = "categorical" AndAlso
           ucrInputCategoricalByCategorical.GetText = "Mosaic Plot" Then
            clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsMosaicGgplotFunction, iPosition:=0)
            clsRFacet.AddParameter("facets", "~ " & ucrReceiverSecondVar.GetVariableNames(False), iPosition:=0)
        Else
            clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRGGplotFunction, iPosition:=0)
            clsRFacet.AddParameter("facets", "~variable", iPosition:=0)
        End If
    End Sub

    Private Sub AddRemoveTextParameter()
        If ucrChkAddLabelsText.Checked AndAlso
            ucrInputCategoricalByCategorical.GetText = "Bar Chart" AndAlso
            strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso
            bRCodeSet Then
            clsBaseOperator.AddParameter("text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("text")
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumTwovarMode
            Case TwovarMode.Describe
                ucrBase.iHelpTopicID = 416
            Case TwovarMode.Climatic
                ucrBase.iHelpTopicID = 424
            Case TwovarMode.Tricot
                ucrBase.iHelpTopicID = 744
        End Select
    End Sub

    Private Sub LowerUpperDiagonal_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLower.ControlValueChanged, ucrChkUpper.ControlValueChanged, ucrChkDiagonal.ControlValueChanged
        If bRCodeSet Then
            If ucrChkDiagonal.Checked Then
                clsGGpairsFunction.AddParameter("diag", clsRFunctionParameter:=clsDiagonalListFunction, iPosition:=3)
            Else
                clsGGpairsFunction.RemoveParameterByName("diag")
            End If
            If ucrChkLower.Checked Then
                clsGGpairsFunction.AddParameter("lower", clsRFunctionParameter:=clsLowerListFunction, iPosition:=4)
            Else
                clsGGpairsFunction.RemoveParameterByName("lower")
            End If
            If ucrChkUpper.Checked Then
                clsGGpairsFunction.AddParameter("upper", clsRFunctionParameter:=clsUpperListFunction, iPosition:=5)
            Else
                clsGGpairsFunction.RemoveParameterByName("upper")
            End If
        End If
    End Sub
    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrSelectorTwoVarGraph.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
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

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
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

        'SetPipeAssignTo()
    End Sub

    Private Sub ThreeVariableResult()
        Dim lstFirstItemTypes As List(Of String)
        If bRCodeSet Then
            If rdoThreeVariable.Checked Then
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
                If Not ucrReceiverThreeVariableSecond.IsEmpty() Then
                    strSecondVariableType = ucrReceiverThreeVariableSecond.strCurrDataType
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
                If Not ucrReceiverThreeVariable.IsEmpty() Then
                    strThirdVariableType = ucrReceiverThreeVariable.strCurrDataType
                    If strThirdVariableType.Contains("factor") OrElse strThirdVariableType.Contains("character") OrElse strThirdVariableType.Contains("logical") Then
                        strThirdVariableType = "categorical"
                    Else
                        strThirdVariableType = "numeric"
                    End If
                    lblThirdType.Text = strThirdVariableType
                    lblThirdType.ForeColor = SystemColors.Highlight
                Else
                    strThirdVariableType = ""
                    lblThirdType.Text = "________"
                    lblThirdType.ForeColor = SystemColors.ControlText
                End If
                RemoveAllGeomsStats()
                If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "numeric" Then
                    ucrInputNumericByNumeric.Visible = True
                    AddRemoveFreeScaleX(False)
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
                    clsGlobalAes = clsAesNumericByNumeric
                    Select Case ucrInputNumericByNumeric.GetText
                        Case "Scatter plot"
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                        Case "Line plot"
                            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                        Case "Line plot + points"
                            ucrNudTransparency.Visible = True
                            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
                    End Select
                ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "numeric" Then
                    ucrInputCategoricalByNumeric.Visible = True
                    ucrChkFreeScaleYAxis.Checked = False
                    ucrChkFreeScaleYAxis.Visible = False
                    AddRemoveFreeScaleX(True)
                    Select Case ucrInputCategoricalByNumeric.GetText
                        Case "Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        Case "Point plot"
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                        Case "Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                        Case "Violin plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        Case "Boxplot + Jitter"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                        Case "Summary Plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                        Case "Summary Plot + Points"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                        Case "Histogram"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                        Case "Density plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                        Case "Frequency polygon"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_freqpoly", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                    End Select
                ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "numeric" Then
                    ucrInputNumericByCategorical.Visible = True
                    AddRemoveFreeScaleX(True)
                    Select Case ucrInputNumericByCategorical.GetText
                        Case "Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        Case "Point plot"
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                        Case "Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                        Case "Violin plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        Case "Boxplot + Jitter"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=0)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                        Case "Summary Plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                        Case "Summary Plot + Points"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                        Case "Histogram"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                        Case "Density plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                        Case "Frequency polygon"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_freqpolygon", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                    End Select
                ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "numeric" Then
                    ucrInputCategoricalByCategorical.Visible = True
                    AddRemoveFreeScaleX(True)
                    If ucrInputCategoricalByCategorical IsNot Nothing Then
                        Select Case ucrInputCategoricalByCategorical.GetText
                            Case "Bar Chart"
                                ucrInputPosition.Visible = True
                                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                                clsGlobalAes = clsAesCategoricalByCategoricalBarChart
                                clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
                            Case "Mosaic Plot"
                                clsRGGplotFunction.RemoveParameterByName("mapping")
                                clsGlobalAes = GgplotDefaults.clsAesFunction.Clone()
                                clsGeomMosaic.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalMosaicPlot, iPosition:=0)
                                clsBaseOperator.AddParameter("geom_mosaic", clsRFunctionParameter:=clsGeomMosaic, iPosition:=1)
                        End Select
                    End If
                ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical" Then
                    ucrInputNumericByNumeric.Visible = True
                    AddRemoveFreeScaleX(False)
                    clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
                    clsGlobalAes = clsAesNumericByNumeric
                    Select Case ucrInputNumericByNumeric.GetText
                        Case "Scatter plot"
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                        Case "Line plot"
                            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                        Case "Line plot + points"
                            ucrNudTransparency.Visible = True
                            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
                    End Select
                ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical" Then
                    ucrInputCategoricalByNumeric.Visible = True
                    ucrChkFreeScaleYAxis.Checked = False
                    ucrChkFreeScaleYAxis.Visible = False
                    AddRemoveFreeScaleX(True)
                    Select Case ucrInputCategoricalByNumeric.GetText
                        Case "Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        Case "Point plot"
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                        Case "Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                        Case "Violin plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        Case "Boxplot + Jitter"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                        Case "Summary Plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                        Case "Summary Plot + Points"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineCategoricalByNumeric, iPosition:=0)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                        Case "Histogram"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                        Case "Density plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                        Case "Frequency polygon"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesCategoricalByNumericXNumeric
                            clsBaseOperator.AddParameter("geom_freqpoly", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                    End Select
                ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical" Then
                    ucrInputNumericByCategorical.Visible = True
                    AddRemoveFreeScaleX(True)
                    Select Case ucrInputNumericByCategorical.GetText
                        Case "Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        Case "Point plot"
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                        Case "Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                        Case "Violin plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        Case "Boxplot + Jitter"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Jitter plot"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                        Case "Violin plot + Boxplot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=0)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                        Case "Summary Plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                        Case "Summary Plot + Points"
                            ucrNudJitter.Visible = True
                            ucrNudTransparency.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalYNumeric
                            clsBaseOperator.AddParameter("stat_summary_crossbar", clsRFunctionParameter:=clsStatSummaryCrossbar, iPosition:=1)
                            clsBaseOperator.AddParameter("stat_summary_hline", clsRFunctionParameter:=clsStatSummaryHline, iPosition:=2)
                            clsStatSummaryHline.AddParameter("mapping", clsRFunctionParameter:=clsAesStatSummaryHlineNumericByCategorical, iPosition:=0)
                            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=3)
                        Case "Histogram"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_histogram", clsRFunctionParameter:=clsGeomHistogram, iPosition:=1)
                        Case "Density plot"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                        Case "Frequency polygon"
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                            clsGlobalAes = clsAesNumericByCategoricalXNumeric
                            clsBaseOperator.AddParameter("geom_freqpolygon", clsRFunctionParameter:=clsGeomFreqPoly, iPosition:=1)
                    End Select
                ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical" Then
                    ucrInputCategoricalByCategorical.Visible = True
                    AddRemoveFreeScaleX(True)
                    If ucrInputCategoricalByCategorical IsNot Nothing Then
                        Select Case ucrInputCategoricalByCategorical.GetText
                            Case "Bar Chart"
                                ucrInputPosition.Visible = True
                                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                                clsGlobalAes = clsAesCategoricalByCategoricalBarChart
                                clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
                            Case "Mosaic Plot"
                                clsRGGplotFunction.RemoveParameterByName("mapping")
                                clsGlobalAes = GgplotDefaults.clsAesFunction.Clone()
                                clsGeomMosaic.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalMosaicPlot, iPosition:=0)
                                clsBaseOperator.AddParameter("geom_mosaic", clsRFunctionParameter:=clsGeomMosaic, iPosition:=1)
                        End Select
                    End If
                Else
                    lblGraphName.Visible = True
                    lblGraphName.Text = "__________"
                    lblGraphName.ForeColor = SystemColors.ControlText
                    clsGlobalAes = GgplotDefaults.clsAesFunction.Clone()
                End If
            End If
        End If

    End Sub

    Private Sub ucrReceiverThreeVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariable.ControlValueChanged, ucrReceiverThreeVariableSecond.ControlValueChanged
        ThreeVariableResult()
    End Sub
End Class