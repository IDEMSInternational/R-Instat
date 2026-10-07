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
    Private clsRGGplotFunction, clsXsideDensityFunction, clsXsideBarFunction, clsXsideBoxplotFunction,
            clsXsideFreqpolyFunction, clsXsideHistogramFunction, clsYsideDensityFunction,
            clsYsideBarFunction, clsYsideBoxplotFunction, clsYsideFreqployFunction,
            clsYsideHistogramFunction, clsMosaicGgplotFunction, clsThemeFunction,
            clsGlobalAes, clsLabsFunction, clsXlabsFunction, clsYlabFunction,
            clsXScaleContinuousFunction, clsYScaleContinuousFunction, clsCoordPolarFunction,
            clsXScaleDateFunction, clsYScaleDateFunction, clsScaleFillViridisFunction,
            clsScaleColourViridisFunction, clsAesLabelFunction, clsAesXLabelFunction, clsAesYLabelFunction, clsPairThemesFunction, clsSidePlotThemeFunction,
            clsTextXTopElementFunction, clsTicksXTopElementFunction, clsTitleXTopElementFunction As New RFunction
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

    Private clsFacetFunction As New RFunction
    Private clsRowVarsFunction, clsColVarsFunction As New RFunction

    'Private clsGeomTextFunction As New RFunction
    Private strGeomParameterNames() As String = {"geom_jitter", "geom_violin", "geom_bar", "geom_mosaic", "geom_boxplot", "geom_point", "geom_line", "stat_summary_hline", "stat_summary_crossline", "geom_freqpoly", "geom_histogram", "geom_density"}

    Private strFirstVariablesType, strSecondVariableType, strThirdVariableType As String

    Private strXSidePlotInputDefault As String = ""
    Private strYSidePlotInputDefault As String = ""

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"
    Private ReadOnly strFacetRowAndCol As String = "Facet Row & Col"
    Private ReadOnly strFacetRowAndColAll As String = "Facet Row & Col + O"
    Private ReadOnly strNone As String = "None"

    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bUpdatingParameters As Boolean = False
    Private bUpdateComboOptions As Boolean = True
    Private bNotSubdialogue As Boolean = False

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
        ChangeLocations()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim strNumericCategoricalPlots() As String
        Dim dctPositionPairs As New Dictionary(Of String, String)
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 416
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlByPairs.AddRadioButton(rdoTwoVars)
        ucrPnlByPairs.AddRadioButton(rdoThreeVars)
        ucrPnlByPairs.AddRadioButton(rdoSide)
        ucrPnlByPairs.AddRadioButton(rdoSummarize)
        ucrPnlByPairs.AddRadioButton(rdoPairs)
        ucrPnlByPairs.AddParameterValuesCondition(rdoTwoVars, "checked", "two_vars")
        ucrPnlByPairs.AddParameterValuesCondition(rdoThreeVars, "checked", "three_vars")
        ucrPnlByPairs.AddParameterValuesCondition(rdoSide, "checked", "side")
        ucrPnlByPairs.AddParameterValuesCondition(rdoSummarize, "checked", "summarize")
        ucrPnlByPairs.AddParameterValuesCondition(rdoPairs, "checked", "pair")
        rdoSummarize.Enabled = False

        ucrPnlByPairs.AddToLinkedControls({ucrReceiverSecondVar, ucrChkFlipCoordinates, ucr1stFactorReceiver, ucrInputStation}, {rdoTwoVars, rdoThreeVars, rdoSide}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrReceiverFill}, {rdoThreeVars}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrChkXSidePlot, ucrChkYSidePlot}, {rdoSide}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlByPairs.AddToLinkedControls({ucrChkLower, ucrReceiverColour}, {rdoPairs}, bNewLinkedHideIfParameterMissing:=True)

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

        ucrReceiverFill.SetParameter(New RParameter("fill", iNewPosition:=0))
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.SetDataType("factor")
        ucrReceiverFill.strSelectorHeading = "Factors"
        ucrReceiverFill.Selector = ucrSelectorTwoVarGraph
        ucrReceiverFill.SetLinkedDisplayControl(lblFillThirdVariable)
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverSecondVar.SetParameter(New RParameter("fill", 0))
        ucrReceiverSecondVar.Selector = ucrSelectorTwoVarGraph
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.bWithQuotes = False
        ucrReceiverSecondVar.SetLinkedDisplayControl(lblSecondVariable)

        ucrInputNumericByNumeric.SetItems({"Scatter plot", "Line plot", "Line plot + points"})
        ucrInputNumericByNumeric.SetName("Scatter plot")
        ucrInputNumericByNumeric.SetDropDownStyleAsNonEditable()

        strNumericCategoricalPlots = {"Boxplot", "Point plot", "Jitter plot", "Violin plot", "Boxplot + Jitter", "Violin plot + Jitter plot", "Violin plot + Boxplot", "Density plot"}

        ucrInputNumericByCategorical.SetItems(strNumericCategoricalPlots)
        ucrInputNumericByCategorical.SetName("Boxplot")
        ucrInputNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByNumeric.SetItems(strNumericCategoricalPlots)
        ucrInputCategoricalByNumeric.SetName("Boxplot")
        ucrInputCategoricalByNumeric.SetDropDownStyleAsNonEditable()
        ucrInputCategoricalByCategorical.SetItems({"Bar Chart"})
        ucrInputCategoricalByCategorical.SetName("Bar Chart")
        ucrInputCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByCategoricalByCategorical.SetItems({"Bar Chart"})
        ucrInputCategoricalByCategoricalByCategorical.SetName("Bar Chart")
        ucrInputCategoricalByCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputCategoricalByNumericByCategorical.SetItems(strNumericCategoricalPlots)
        ucrInputCategoricalByNumericByCategorical.SetName("Boxplot")
        ucrInputCategoricalByNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputNumericByCategoricalByCategorical.SetItems(strNumericCategoricalPlots)
        ucrInputNumericByCategoricalByCategorical.SetName("Boxplot")
        ucrInputNumericByCategoricalByCategorical.SetDropDownStyleAsNonEditable()

        ucrInputNumericByNumericByCategorical.SetItems({"Scatter plot", "Line plot", "Line plot + points"})
        ucrInputNumericByNumericByCategorical.SetName("Scatter plot")
        ucrInputNumericByNumericByCategorical.SetDropDownStyleAsNonEditable()

        ucrChkAddLabelsText.Visible = False
        lblLabelColour.Visible = False
        lblLabelPosition.Visible = False
        lblLabelSize.Visible = False
        ucrInputLabelPosition.Visible = False
        ucrInputLabelColour.Visible = False
        ucrInputLabelSize.Visible = False

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

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

        ucrChkXSidePlot.SetText("X Side Plot")
        ucrChkXSidePlot.AddParameterValuesCondition(True, "x_side_plot", "True")
        ucrChkXSidePlot.AddParameterValuesCondition(False, "x_side_plot", "False")
        ucrChkXSidePlot.AddToLinkedControls({ucrInputXSidePlotOptions}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkYSidePlot.SetText("Y Side Plot")
        ucrChkYSidePlot.AddParameterValuesCondition(True, "y_side_plot", "True")
        ucrChkYSidePlot.AddParameterValuesCondition(False, "y_side_plot", "False")
        ucrChkYSidePlot.AddToLinkedControls({ucrInputYSidePlotOptions}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputXSidePlotOptions.SetItems({"Density", "Bar", "Boxplot", "Frequency Polygon", "Histogram"})
        ucrInputXSidePlotOptions.SetName("Density")
        ucrInputXSidePlotOptions.SetDropDownStyleAsNonEditable()

        ucrInputYSidePlotOptions.SetItems({"Density", "Bar", "Boxplot", "Frequency Polygon", "Histogram"})
        ucrInputYSidePlotOptions.SetName("Density")
        ucrInputYSidePlotOptions.SetDropDownStyleAsNonEditable()

        ucr1stFactorReceiver.SetParameter(New RParameter("rows", bNewIncludeArgumentName:=False))
        ucr1stFactorReceiver.Selector = ucrSelectorTwoVarGraph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(0)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strFacetRowAndCol, strFacetRowAndColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("two_var_graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoVarGraph.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        HideShowFillReceiver()
        HideShowGroupSummariesControl()
        HideShowGroupOptionsControl()
    End Sub

    Private Sub SetDefaults()
        clsGGpairsFunction = New RFunction
        clsRGGplotFunction = New RFunction
        clsXsideDensityFunction = New RFunction
        clsXsideBarFunction = New RFunction
        clsXsideBoxplotFunction = New RFunction
        clsXsideHistogramFunction = New RFunction
        clsXsideFreqpolyFunction = New RFunction
        clsYsideDensityFunction = New RFunction
        clsYsideBarFunction = New RFunction
        clsYsideBoxplotFunction = New RFunction
        clsYsideHistogramFunction = New RFunction
        clsYsideFreqployFunction = New RFunction
        clsPairThemesFunction = New RFunction
        clsMosaicGgplotFunction = New RFunction
        clsDummyFunction = New RFunction
        clsPairOperator = New ROperator
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

        clsAesXLabelFunction = New RFunction
        clsAesLabelFunction = New RFunction
        clsAesYLabelFunction = New RFunction

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
        clsLabelAesFunction = New RFunction
        clsSidePlotThemeFunction = New RFunction
        clsTextXTopElementFunction = New RFunction
        clsTicksXTopElementFunction = New RFunction
        clsTitleXTopElementFunction = New RFunction
        clsBaseOperator = New ROperator
        clsFacetFunction = New RFunction
        clsRowVarsFunction = New RFunction
        clsColVarsFunction = New RFunction

        bResetSubdialog = True

        'Reset
        ucrSaveGraph.Reset()
        ucrSelectorTwoVarGraph.Reset()
        ucrInputXSidePlotOptions.SetItems({"Density", "Bar", "Boxplot", "Frequency Polygon", "Histogram"})
        ucrInputXSidePlotOptions.SetName("Density")

        ucrInputYSidePlotOptions.SetItems({"Density", "Bar", "Boxplot", "Frequency Polygon", "Histogram"})
        ucrInputYSidePlotOptions.SetName("Density")

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrReceiverFirstVars.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "two_vars", iPosition:=0)
        clsDummyFunction.AddParameter("x_side_plot", "False", iPosition:=1)
        clsDummyFunction.AddParameter("y_side_plot", "False", iPosition:=2)

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

        clsXsideDensityFunction.SetPackageName("ggside")
        clsXsideDensityFunction.SetRCommand("geom_xsidedensity")
        clsXsideDensityFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=2)
        clsXsideDensityFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=2)

        clsXsideBarFunction.SetPackageName("ggside")
        clsXsideBarFunction.SetRCommand("geom_xsidebar")
        clsXsideBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsXsideBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
        clsXsideBarFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=3)

        clsXsideBoxplotFunction.SetPackageName("ggside")
        clsXsideBoxplotFunction.SetRCommand("geom_xsideboxplot")
        clsXsideBoxplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=3)

        clsXsideFreqpolyFunction.SetPackageName("ggside")
        clsXsideFreqpolyFunction.SetRCommand("geom_xsidefreqpoly")
        clsXsideFreqpolyFunction.AddParameter("aes", clsRFunctionParameter:=clsAesXLabelFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsXsideHistogramFunction.SetPackageName("ggside")
        clsXsideHistogramFunction.SetRCommand("geom_xsidehistogram")
        clsXsideHistogramFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=3)

        clsAesLabelFunction.SetPackageName("ggplot2")
        clsAesLabelFunction.SetRCommand("aes")
        clsAesLabelFunction.AddParameter("colour", ucrReceiverFill.GetVariableNames, iPosition:=0)

        clsAesXLabelFunction.SetPackageName("ggplot2")
        clsAesXLabelFunction.SetRCommand("aes")
        clsAesXLabelFunction.AddParameter("fill", ucrReceiverFill.GetVariableNames, bIncludeArgumentName:=False, iPosition:=0)

        clsYsideDensityFunction.SetPackageName("ggside")
        clsYsideDensityFunction.SetRCommand("geom_ysidedensity")
        clsYsideDensityFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, bIncludeArgumentName:=False, iPosition:=3)
        clsYsideDensityFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=2)

        clsAesYLabelFunction.SetPackageName("ggplot2")
        clsAesYLabelFunction.SetRCommand("aes")
        clsAesYLabelFunction.AddParameter("fill", ucrReceiverFill.GetVariableNames, bIncludeArgumentName:=False, iPosition:=0)

        clsYsideBarFunction.SetPackageName("ggside")
        clsYsideBarFunction.SetRCommand("geom_ysidebar")
        clsYsideBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=2)
        clsYsideBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
        clsYsideBarFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=3)

        clsYsideBoxplotFunction.SetPackageName("ggside")
        clsYsideBoxplotFunction.SetRCommand("geom_ysideboxplot")
        clsYsideBoxplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=1)

        clsYsideFreqployFunction.SetPackageName("ggside")
        clsYsideFreqployFunction.SetRCommand("geom_ysidefreqpoly")
        clsYsideFreqployFunction.AddParameter("aes", clsRFunctionParameter:=clsAesYLabelFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsYsideHistogramFunction.SetPackageName("ggside")
        clsYsideHistogramFunction.SetRCommand("geom_ysidehistogram")
        clsYsideHistogramFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=3)

        clsMosaicGgplotFunction.SetPackageName("ggplot2")
        clsMosaicGgplotFunction.SetRCommand("ggplot")

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
        clsGeomPoint.AddParameter("size", "3", iPosition:=3)

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

        clsTextXTopElementFunction.SetPackageName("ggplot2")
        clsTextXTopElementFunction.SetRCommand("element_blank")

        clsTicksXTopElementFunction.SetPackageName("ggplot2")
        clsTicksXTopElementFunction.SetRCommand("element_blank")

        clsTitleXTopElementFunction.SetPackageName("ggplot2")
        clsTitleXTopElementFunction.SetRCommand("element_blank")

        clsSidePlotThemeFunction.SetPackageName("ggplot2")
        clsSidePlotThemeFunction.SetRCommand("theme")
        clsSidePlotThemeFunction.AddParameter("ggside.panel.scale", "0.3", iPosition:=0)
        clsSidePlotThemeFunction.AddParameter("axis.text.x.top", clsRFunctionParameter:=clsTextXTopElementFunction, iPosition:=1)
        clsSidePlotThemeFunction.AddParameter("axis.ticks.x.top", clsRFunctionParameter:=clsTicksXTopElementFunction, iPosition:=2)
        clsSidePlotThemeFunction.AddParameter("axis.title.x.top", clsRFunctionParameter:=clsTitleXTopElementFunction, iPosition:=3)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.AddParameter("facets", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)

        clsRowVarsFunction.SetPackageName("ggplot2")
        clsRowVarsFunction.SetRCommand("vars")

        clsColVarsFunction.SetPackageName("ggplot2")
        clsColVarsFunction.SetRCommand("vars")

        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRGGplotFunction, iPosition:=0)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsPairOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoVarGraph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        AddDataFrame()
        HideShowGroupSummariesControl()
        HideShowGroupOptionsControl()
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
        ucrChkFreeScaleYAxis.SetRCode(clsFacetFunction, bReset)
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
        ucr1stFactorReceiver.SetRCode(clsRowVarsFunction, bReset)
        ucrReceiverFill.SetRCode(clsAesNumericByCategoricalYNumeric, bReset)
        If bReset Then
            ucrChkXSidePlot.SetRCode(clsDummyFunction, bReset)
            ucrChkYSidePlot.SetRCode(clsDummyFunction, bReset)
        End If

        bRCodeSet = True
        Results()
        SetFreeYAxis()
    End Sub

    Private Sub TestOkEnabled()
        If rdoTwoVars.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty AndAlso Not ucrReceiverSecondVar.IsEmpty AndAlso ucrSaveGraph.IsComplete)
        ElseIf rdoThreeVars.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty AndAlso Not ucrReceiverSecondVar.IsEmpty AndAlso Not ucrReceiverFill.IsEmpty AndAlso ucrSaveGraph.IsComplete)
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
            If rdoThreeVars.Checked Then
                If Not ucrReceiverFill.IsEmpty() Then
                    strThirdVariableType = If({"factor", "ordered,factor", "character", "logical"}.Contains(ucrReceiverFill.strCurrDataType),
                                      "categorical", "numeric")
                    lblThirdType.Text = strThirdVariableType
                    lblThirdType.ForeColor = SystemColors.Highlight
                Else
                    strThirdVariableType = ""
                    lblThirdType.Text = "________"
                    lblThirdType.ForeColor = SystemColors.ControlText
                End If
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
            ucrInputCategoricalByCategoricalByCategorical.Visible = False
            ucrInputCategoricalByNumericByCategorical.Visible = False
            ucrInputNumericByCategoricalByCategorical.Visible = False
            ucrInputNumericByNumericByCategorical.Visible = False
            RemoveAllGeomsStats()

            If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical" Then
                ucrInputNumericByNumericByCategorical.Visible = True
                AddRemoveFreeScaleX(False)
                AddRemoveAesFillParam(clsTempAesFunction:=clsAesNumericByNumeric, strParamName:="fill", iPosition:=6)
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
                clsGlobalAes = clsAesNumericByNumeric
                Select Case ucrInputNumericByNumericByCategorical.GetText
                    Case "Scatter plot"
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Line plot"
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                    Case "Line plot + points"
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical" Then
                Debug.Print("Motherfucking R-Instat Codebase")
                ucrInputCategoricalByNumericByCategorical.Visible = True
                ucrChkFreeScaleYAxis.Checked = False
                ucrChkFreeScaleYAxis.Visible = False
                AddRemoveFreeScaleX(True)
                AddRemoveAesFillParam(clsTempAesFunction:=clsAesCategoricalByNumericYNumeric, strParamName:="fill", iPosition:=6)
                Debug.Print($"Fucker 3 AES FUNC: {clsAesCategoricalByNumericYNumeric.ToScript()}")
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                clsGlobalAes = clsAesCategoricalByNumericYNumeric
                Select Case ucrInputCategoricalByNumericByCategorical.GetText
                    Case "Boxplot"
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Density plot"
                        AddRemoveAesFillParam(clsTempAesFunction:=clsAesCategoricalByNumericXNumeric, strParamName:="fill", iPosition:=6)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical" Then
                ucrInputNumericByCategoricalByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                AddRemoveAesFillParam(clsTempAesFunction:=clsAesNumericByCategoricalYNumeric, strParamName:="fill", iPosition:=6)
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                clsGlobalAes = clsAesNumericByCategoricalYNumeric
                Select Case ucrInputNumericByCategoricalByCategorical.GetText
                    Case "Boxplot"
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Density plot"
                        AddRemoveAesFillParam(clsTempAesFunction:=clsAesNumericByCategoricalXNumeric, strParamName:="fill", iPosition:=6)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical" Then
                ucrInputCategoricalByCategoricalByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                If ucrInputCategoricalByCategoricalByCategorical IsNot Nothing Then
                    Select Case ucrInputCategoricalByCategoricalByCategorical.GetText
                        Case "Bar Chart"
                            AddRemoveAesFillParam(clsTempAesFunction:=clsAesCategoricalByCategoricalBarChart, strParamName:="fill", iPosition:=6)
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                            clsGlobalAes = clsAesCategoricalByCategoricalBarChart
                            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
                    End Select
                End If
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
                ucrChkXSidePlot.Visible = True
                ucrChkYSidePlot.Visible = True
                ucrInputXSidePlotOptions.Visible = ucrChkXSidePlot.Checked
                ucrInputYSidePlotOptions.Visible = ucrChkYSidePlot.Checked
                ucrInputNumericByNumeric.Visible = True
                AddRemoveFreeScaleX(False)
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByNumeric, iPosition:=0)
                clsGlobalAes = clsAesNumericByNumeric
                ucrInputYSidePlotOptions.SetItems({"Density", "Boxplot", "Frequency Polygon", "Histogram"})
                ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                ucrInputXSidePlotOptions.SetItems({"Density", "Boxplot", "Frequency Polygon", "Histogram"})
                ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                Select Case ucrInputNumericByNumeric.GetText
                    Case "Scatter plot"
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Line plot"
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                    Case "Line plot + points"
                        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLine, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
                Debug.Print("Yoooo.... Chill...")
                ucrChkXSidePlot.Visible = True
                ucrChkYSidePlot.Visible = True
                ucrInputXSidePlotOptions.Visible = ucrChkXSidePlot.Checked
                ucrInputYSidePlotOptions.Visible = ucrChkYSidePlot.Checked
                ucrInputCategoricalByNumeric.Visible = True
                ucrChkFreeScaleYAxis.Checked = False
                ucrChkFreeScaleYAxis.Visible = False
                AddRemoveFreeScaleX(True)
                clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericYNumeric, iPosition:=1)
                Debug.Print($"Fucker 2 AES FUNC: {clsAesCategoricalByNumericYNumeric.ToScript()}")
                clsGlobalAes = clsAesCategoricalByNumericYNumeric
                Select Case ucrInputCategoricalByNumeric.GetText
                    Case "Boxplot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Density plot"
                        ucrChkXSidePlot.Visible = False
                        ucrChkYSidePlot.Visible = False
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByNumericXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesCategoricalByNumericXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                ucrChkXSidePlot.Visible = True
                ucrChkYSidePlot.Visible = True
                ucrInputXSidePlotOptions.Visible = ucrChkXSidePlot.Checked
                ucrInputYSidePlotOptions.Visible = ucrChkYSidePlot.Checked
                ucrInputNumericByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                Select Case ucrInputNumericByCategorical.GetText
                    Case "Boxplot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                    Case "Point plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=1)
                    Case "Jitter plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=1)
                    Case "Violin plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                    Case "Boxplot + Jitter"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Jitter plot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        ucrNudJitter.Visible = True
                        ucrNudTransparency.Visible = True
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsGeomJitter, iPosition:=2)
                    Case "Violin plot + Boxplot"
                        ucrInputYSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputYSidePlotOptions.SetName(strYSidePlotInputDefault)
                        ucrInputXSidePlotOptions.SetItems({"Boxplot"})
                        ucrInputXSidePlotOptions.SetName(strXSidePlotInputDefault)
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalYNumeric, iPosition:=0)
                        clsGlobalAes = clsAesNumericByCategoricalYNumeric
                        clsBaseOperator.AddParameter("geom_violin", clsRFunctionParameter:=clsGeomViolin, iPosition:=1)
                        clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxplot, iPosition:=2)
                    Case "Density plot"
                        ucrChkXSidePlot.Visible = False
                        ucrChkYSidePlot.Visible = False
                        clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesNumericByCategoricalXNumeric, iPosition:=1)
                        clsGlobalAes = clsAesNumericByCategoricalXNumeric
                        clsBaseOperator.AddParameter("geom_density", clsRFunctionParameter:=clsGeomDensity, iPosition:=1)
                End Select
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                ucrChkYSidePlot.Visible = False
                ucrChkXSidePlot.Visible = False
                ucrInputXSidePlotOptions.Visible = False
                ucrInputYSidePlotOptions.Visible = False
                ucrInputCategoricalByCategorical.Visible = True
                AddRemoveFreeScaleX(True)
                If ucrInputCategoricalByCategorical IsNot Nothing Then
                    Select Case ucrInputCategoricalByCategorical.GetText
                        Case "Bar Chart"
                            ucrInputPosition.Visible = True
                            clsRGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesCategoricalByCategoricalBarChart, iPosition:=0)
                            clsGlobalAes = clsAesCategoricalByCategoricalBarChart
                            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBar, iPosition:=1)
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

    Private Sub AddRemoveAesFillParam(clsTempAesFunction As RFunction, strParamName As String, iPosition As Integer)
        If rdoThreeVars.Checked AndAlso Not ucrReceiverFill.IsEmpty() Then
            clsTempAesFunction.AddParameter(strParamName, ucrReceiverFill.GetVariableNames(bWithQuotes:=False), iPosition:=iPosition)
        Else
            clsTempAesFunction.RemoveParameterByName(strParamName)
        End If
    End Sub

    Private Sub UpdateParameters()
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(clsRowVarsFunction)

        If bNotSubdialogue Then
            clsFacetFunction.ClearParameters()
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False
        Dim bRowsAndCols As Boolean = False
        Dim bRowsAndColsAll As Boolean = False

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
                Case strFacetColAll
                    bColAll = True
                Case strFacetRowAll
                    bRowAll = True
                Case strFacetRowAndCol
                    bRowsAndCols = True
                Case strFacetRowAndColAll
                    bRowsAndColsAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll OrElse bRowsAndCols OrElse bRowsAndColsAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If

        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
            clsFacetFunction.AddParameter("facets", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
            clsFacetFunction.RemoveParameterByName("rows")
            clsFacetFunction.RemoveParameterByName("cols")
        Else
            clsFacetFunction.RemoveParameterByName("facets")
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll OrElse bRowsAndCols OrElse bRowsAndColsAll Then
            clsFacetFunction.SetRCommand("facet_grid")
            clsFacetFunction.RemoveParameterByName("facets")
        End If

        If bRowAll OrElse bColAll OrElse bRowsAndColsAll Then
            clsFacetFunction.AddParameter("margins", "TRUE")
        Else
            clsFacetFunction.RemoveParameterByName("margins")
        End If

        If bRowsAndCols OrElse bRowsAndColsAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsColVarsFunction, iPosition:=1)
        ElseIf bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
            clsFacetFunction.RemoveParameterByName("cols")
        ElseIf bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsRowVarsFunction, iPosition:=0)
            clsFacetFunction.RemoveParameterByName("rows")
        End If
    End Sub

    Private Sub ChangeLocations()
        Me.ucrReceiverFirstVars.Size = New Size(145, 110)
        Me.ucrReceiverFirstVars.ucrMultipleVariables.Size = New Size(140, 90)
        Me.ucrReceiverFirstVars.ucrSingleVariable.Size = New Size(140, 30)
        Me.ucrReceiverFirstVars.cmdVariables.Size = New Size(140, 30)

        If rdoTwoVars.Checked Then
            grpOptions.Location = New Point(325, 240)
            ucr1stFactorReceiver.Location = New Point(290, 425)
            ucrInputStation.Location = New Point(390, 425)
            lblFacetBy.Location = New Point(291, 410)
        ElseIf rdoThreeVars.Checked Then
            ucr1stFactorReceiver.Location = New Point(290, 425)
            ucrInputStation.Location = New Point(390, 425)
            lblFacetBy.Location = New Point(291, 410)
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll OrElse strChangedText = strFacetRowAndCol OrElse strChangedText = strFacetRowAndColAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then

                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll _
            OrElse ucrInputStation.GetText = strFacetRowAndCol OrElse ucrInputStation.GetText = strFacetRowAndColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
            OrElse ((strChangedText = strFacetRowAndCol OrElse strChangedText = strFacetRowAndColAll) _
             AndAlso ucrInputStation.GetText = strFacetWrap) Then

                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
    End Sub


    Private Sub FacetControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrReceiverFirstVars_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged, UcrVariablesAsFactor1.ControlValueChanged
        Dim iPosition As Integer = 0
        Dim iNumVariables As Integer = ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False).Count
        RestoreXSidePlotInputOption()
        RestoreYSidePlotInputOption()
        Results()
        clsGGpairsFunction.AddParameter("columns", ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNames(), iPosition:=1)
        clsGgmosaicProduct.ClearParameters()
        For Each strVariables In ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False)
            clsGgmosaicProduct.AddParameter("columns" & iPosition, strVariables,
                                            iPosition:=iPosition, bIncludeArgumentName:=False)
            iPosition = iPosition + 1
        Next

        If iNumVariables > 0 Then
            clsAesCategoricalByCategoricalMosaicPlot.AddParameter("fill", ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList(bWithQuotes:=False)(0), iPosition:=1)
        End If
        MatchSameCategoricalVariablesInReceivers(ucrReceiverFirstVars)
    End Sub

    Private Sub ucrReceiverSecondVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlValueChanged
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        RestoreXSidePlotInputOption()
        RestoreYSidePlotInputOption()
        Results()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlContentsChanged,
        ucrReceiverFirstVars.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged,
        ucrPnlByPairs.ControlContentsChanged, ucrReceiverColour.ControlContentsChanged, ucrPnlByPairs.ControlContentsChanged,
        ucrReceiverColour.ControlContentsChanged,
        ucrReceiverFill.ControlContentsChanged, UcrVariablesAsFactor1.ControlContentsChanged, UcrReceiverSingle2.ControlContentsChanged, UcrReceiverSingle1.ControlContentsChanged
        AddedXSidePlots()
        AddedYSidePlots()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCategoricalByCategorical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNumericByNumeric.ControlValueChanged, ucrInputNumericByCategorical.ControlValueChanged,
        ucrInputCategoricalByNumeric.ControlValueChanged, ucrInputCategoricalByCategorical.ControlValueChanged, ucrInputCategoricalByNumericByCategorical.ControlValueChanged,
        ucrInputCategoricalByCategoricalByCategorical.ControlValueChanged, ucrInputNumericByCategoricalByCategorical.ControlValueChanged,
        ucrInputNumericByNumericByCategorical.ControlValueChanged
        Results()
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
                          clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsFacetFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction,
                          clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorTwoVarGraph, clsNewRowVarsFunction:=clsRowVarsFunction, clsNewColVarsFunction:=clsColVarsFunction,
                          clsNewAnnotateFunction:=clsAnnotateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        sdgPlots.tbpFacet.Enabled = True
        bNotSubdialogue = False
        If clsFacetFunction.strRCommand = "facet_grid" Then
            If clsFacetFunction.ContainsParameter("rows") AndAlso clsFacetFunction.ContainsParameter("cols") Then
                If clsFacetFunction.ContainsParameter("margins") Then
                    ucrInputStation.SetName(strFacetRowAndColAll)
                Else
                    ucrInputStation.SetName(strFacetRowAndCol)
                End If
            ElseIf clsFacetFunction.ContainsParameter("rows") Then
                If clsFacetFunction.ContainsParameter("margins") Then
                    ucrInputStation.SetName(strFacetRowAll)
                Else
                    ucrInputStation.SetName(strFacetRow)
                End If
            ElseIf clsFacetFunction.ContainsParameter("cols") Then
                If clsFacetFunction.ContainsParameter("margins") Then
                    ucrInputStation.SetName(strFacetColAll)
                Else
                    ucrInputStation.SetName(strFacetCol)
                End If
            End If
        Else
            ucrInputStation.SetName(strFacetWrap)
        End If
        bNotSubdialogue = True
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
                If clsFacetFunction.ContainsParameter("scales") Then
                    clsScaleParam = clsFacetFunction.GetParameter("scales")
                    If clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) Then
                        clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34)
                    Else
                        clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34)
                    End If
                Else
                    clsFacetFunction.AddParameter("scales", Chr(34) & "free_" & strYName & Chr(34), iPosition:=3)
                End If
            Else
                If clsFacetFunction.ContainsParameter("scales") Then
                    clsScaleParam = clsFacetFunction.GetParameter("scales")
                    If clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34) Then
                        clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34)
                    Else
                        clsFacetFunction.RemoveParameter(clsScaleParam)
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
            If clsFacetFunction.ContainsParameter("scales") Then
                clsScaleParam = clsFacetFunction.GetParameter("scales")
                If clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34)
                Else
                    clsScaleParam.strArgumentValue = Chr(34) & "free_" & strXName & Chr(34)
                End If
            Else
                clsFacetFunction.AddParameter("scales", Chr(34) & "free_" & strXName & Chr(34), iPosition:=3)
            End If
        Else
            If clsFacetFunction.ContainsParameter("scales") Then
                clsScaleParam = clsFacetFunction.GetParameter("scales")
                If clsScaleParam.strArgumentValue = Chr(34) & "free" & Chr(34) OrElse clsScaleParam.strArgumentValue = Chr(34) & "free_y" & Chr(34) Then
                    clsScaleParam.strArgumentValue = Chr(34) & "free_" & strYName & Chr(34)
                Else
                    clsFacetFunction.RemoveParameter(clsScaleParam)
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
            If clsFacetFunction.ContainsParameter("scales") Then
                clsScaleParam = clsFacetFunction.GetParameter("scales")
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
        If rdoTwoVars.Checked Then
            lblThirdType.Visible = False
            lblSecondBy.Visible = False
            ucrSaveGraph.SetPrefix("two_var_graph")
            ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        ElseIf rdoThreeVars.Checked Then
            lblThirdType.Visible = True
            lblSecondBy.Visible = True
            ucrReceiverFill.Visible = True
            ucrSaveGraph.SetPrefix("three_var_graph")
        ElseIf rdoSide.Checked Then
            lblThirdType.Visible = False
            lblSecondBy.Visible = False
            ucr1stFactorReceiver.Visible = False
            ucrInputStation.Visible = False
            lblFacetBy.Visible = False
            ucrSaveGraph.SetPrefix("graph_with_side_plots")
            ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        Else
            lblThirdType.Visible = False
            lblSecondBy.Visible = False
            ucrReceiverFill.Visible = False
            ucrReceiverFirstVars.ucrMultipleVariables.SetSingleTypeStatus(False)
        End If
        If bRCodeSet Then
            If rdoTwoVars.Checked Then
                ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
                clsDummyFunction.AddParameter("checked", "two_vars", iPosition:=0)
            ElseIf rdoThreeVars.Checked Then
                clsDummyFunction.AddParameter("checked", "three_vars", iPosition:=0)
            ElseIf rdoSide.Checked Then
                If clsBaseOperator.ContainsParameter("facets") Then
                    clsBaseOperator.RemoveParameterByName("facets")
                End If
                ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
                clsDummyFunction.AddParameter("checked", "side", iPosition:=0)
            Else
                ucrBase.clsRsyntax.SetBaseROperator(clsPairOperator)
                clsDummyFunction.AddParameter("checked", "pair", iPosition:=0)
            End If
        End If
        HideShowGroupSummariesControl()
        HideShowGroupOptionsControl()
        AddRemoveColourParameter()
        HideShowOptions()
        AddedXSidePlots()
        AddedYSidePlots()
        ChangeLocations()
        Results()
        HideShowFillReceiver()
        ChangeLocations()
    End Sub

    Private Sub HideShowGroupSummariesControl()
        If rdoTwoVars.Checked OrElse rdoThreeVars.Checked OrElse rdoSide.Checked Then
            grpSummaries.Visible = True
        Else
            grpSummaries.Visible = False
        End If
    End Sub

    Private Sub HideShowGroupOptionsControl()
        If rdoTwoVars.Checked Then
            grpOptions.Visible = True
        Else
            grpOptions.Visible = False
        End If
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

    Private Sub ucrReceiverColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColour.ControlValueChanged, UcrReceiverSingle1.ControlValueChanged
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

    Private Sub ucrChkXSidePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged, ucrChkXSidePlot.ControlValueChanged, ucrInputXSidePlotOptions.ControlValueChanged, UcrReceiverSingle2.ControlValueChanged
        RestoreXSidePlotInputOption()
        HideShowFillReceiver()
        AddedXSidePlots()
        clsAesLabelFunction.AddParameter("colour", ucrReceiverFill.GetVariableNames(bWithQuotes:=False), iPosition:=0)
        clsGeomPoint.AddParameter("aes", clsRFunctionParameter:=clsAesLabelFunction, bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub ucrReceiverFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged
        Results()
    End Sub
    Private Sub ucrChkYSidePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged, ucrChkYSidePlot.ControlValueChanged, ucrInputYSidePlotOptions.ControlValueChanged
        RestoreYSidePlotInputOption()
        HideShowFillReceiver()
        AddedYSidePlots()
    End Sub

    Private Sub RestoreXSidePlotInputOption()
        If Not ucrInputXSidePlotOptions.IsEmpty() Then
            strXSidePlotInputDefault = ucrInputXSidePlotOptions.GetText()
        Else
            If Not ucrInputXSidePlotOptions.cboInput.Items().Contains(strXSidePlotInputDefault) AndAlso ucrInputXSidePlotOptions.cboInput.Items().Count > 0 Then
                strXSidePlotInputDefault = ucrInputXSidePlotOptions.cboInput.Items(0)
            End If
        End If
    End Sub
    Private Sub RestoreYSidePlotInputOption()
        If Not ucrInputYSidePlotOptions.IsEmpty() Then
            strYSidePlotInputDefault = ucrInputYSidePlotOptions.GetText()
        Else
            If Not ucrInputYSidePlotOptions.cboInput.Items().Contains(strYSidePlotInputDefault) AndAlso ucrInputYSidePlotOptions.cboInput.Items().Count > 0 Then
                strYSidePlotInputDefault = ucrInputYSidePlotOptions.cboInput.Items(0)
            End If
        End If
    End Sub

    Private Sub AddedXSidePlots()
        clsBaseOperator.RemoveParameterByName("ggside_x")
        clsXsideDensityFunction.RemoveParameterByName("alpha")
        clsXsideFreqpolyFunction.RemoveParameterByName("stat")
        clsXsideDensityFunction.RemoveParameterByName("colour")
        clsXsideDensityFunction.RemoveParameterByName("mapping")
        clsXsideBarFunction.RemoveParameterByName("stat")
        clsXsideBarFunction.RemoveParameterByName("colour")
        clsXsideBarFunction.RemoveParameterByName("mapping")
        clsXsideBoxplotFunction.RemoveParameterByName("alpha")
        clsXsideBoxplotFunction.RemoveParameterByName("mapping")
        clsXsideHistogramFunction.RemoveParameterByName("alpha")
        clsXsideHistogramFunction.RemoveParameterByName("mapping")
        clsXsideHistogramFunction.RemoveParameterByName("stat")
        clsAesXLabelFunction.RemoveParameterByName("fill")
        If Not ucrChkXSidePlot.Checked Then
            Exit Sub
        End If
        Select Case ucrInputXSidePlotOptions.GetText()
            Case "Density"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesXLabelFunction, paramName:="fill", iPosition:=0)
                clsXsideDensityFunction.AddParameter("alpha", "0.35", iPosition:=1)
                clsXsideDensityFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=2)
                clsXsideDensityFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=3)
                clsBaseOperator.AddParameter("ggside_x", clsRFunctionParameter:=clsXsideDensityFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Bar"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesXLabelFunction, paramName:="fill", iPosition:=0)
                clsXsideBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=1)
                clsXsideBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
                clsXsideBarFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=3)
                clsBaseOperator.AddParameter("ggside_x", clsRFunctionParameter:=clsXsideBarFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Boxplot"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesXLabelFunction, paramName:="fill", iPosition:=5)
                clsXsideBoxplotFunction.AddParameter("alpha", "0.35", iPosition:=2)
                clsXsideBoxplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, iPosition:=3)
                clsBaseOperator.AddParameter("ggside_x", clsRFunctionParameter:=clsXsideBoxplotFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Frequency Polygon"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesXLabelFunction, paramName:="colour", iPosition:=4)
                If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" OrElse
                    strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                    clsXsideFreqpolyFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=5)
                End If
                clsXsideFreqpolyFunction.AddParameter("aes", clsRFunctionParameter:=clsAesXLabelFunction, bIncludeArgumentName:=False, iPosition:=2)
                clsBaseOperator.AddParameter("ggside_x", clsRFunctionParameter:=clsXsideFreqpolyFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Histogram"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesXLabelFunction, paramName:="fill", iPosition:=5)
                If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" OrElse
                    strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                    clsXsideHistogramFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=5)
                End If
                clsXsideHistogramFunction.AddParameter("alpha", "0.35", iPosition:=2)
                clsXsideHistogramFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesXLabelFunction, bIncludeArgumentName:=False, iPosition:=3)
                clsBaseOperator.AddParameter("ggside_x", clsRFunctionParameter:=clsXsideHistogramFunction, iPosition:=1)
        End Select
        AddRemoveSidePlotThemeFunction()
    End Sub

    Private Sub AddedYSidePlots()
        clsYsideDensityFunction.RemoveParameterByName("alpha")
        clsYsideDensityFunction.RemoveParameterByName("colour")
        clsYsideDensityFunction.RemoveParameterByName("mapping")
        clsYsideBarFunction.RemoveParameterByName("stat")
        clsYsideBarFunction.RemoveParameterByName("colour")
        clsYsideBarFunction.RemoveParameterByName("mapping")
        clsYsideBoxplotFunction.RemoveParameterByName("alpha")
        clsYsideBoxplotFunction.RemoveParameterByName("mapping")
        clsYsideHistogramFunction.RemoveParameterByName("alpha")
        clsYsideHistogramFunction.RemoveParameterByName("mapping")
        clsAesYLabelFunction.RemoveParameterByName("fill")
        clsAesYLabelFunction.RemoveParameterByName("x")
        clsBaseOperator.RemoveParameterByName("ggside_y")
        If Not ucrChkYSidePlot.Checked Then
            Exit Sub
        End If
        Select Case ucrInputYSidePlotOptions.GetText()
            Case "Density"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesYLabelFunction, paramName:="fill", iPosition:=5)
                clsYsideDensityFunction.AddParameter("alpha", "0.35", iPosition:=2)
                clsYsideDensityFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=3)
                clsYsideDensityFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=4)
                clsBaseOperator.AddParameter("ggside_y", clsRFunctionParameter:=clsYsideDensityFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Bar"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesYLabelFunction, paramName:="fill", iPosition:=5)
                clsYsideBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=2)
                clsYsideBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=3)
                clsYsideBarFunction.AddParameter("colour", Chr(34) & "NA" & Chr(34), iPosition:=4)
                clsBaseOperator.AddParameter("ggside_y", clsRFunctionParameter:=clsYsideBarFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Boxplot"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesYLabelFunction, paramName:="fill", iPosition:=4)
                clsYsideBoxplotFunction.AddParameter("alpha", "0.35", iPosition:=2)
                clsAesYLabelFunction.AddParameter("x", "1", iPosition:=3)
                clsYsideBoxplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=1)
                clsYsideBoxplotFunction.AddParameter("orientation", Chr(34) & "x" & Chr(34), iPosition:=3)
                clsBaseOperator.AddParameter("ggside_y", clsRFunctionParameter:=clsYsideBoxplotFunction, bIncludeArgumentName:=False, iPosition:=7)
            Case "Frequency Polygon"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesYLabelFunction, paramName:="colour", iPosition:=3)
                clsYsideFreqployFunction.AddParameter("aes", clsRFunctionParameter:=clsAesYLabelFunction, bIncludeArgumentName:=False, iPosition:=2)
                clsBaseOperator.AddParameter("ggside_y", clsRFunctionParameter:=clsYsideFreqployFunction, bIncludeArgumentName:=False, iPosition:=1)
            Case "Histogram"
                AddRemoveFillColorParams(ucrReceiverTemp:=ucrReceiverFill, clsTempRFunction:=clsAesYLabelFunction, paramName:="fill", iPosition:=4)
                clsYsideHistogramFunction.AddParameter("alpha", "0.35", iPosition:=2)
                clsYsideHistogramFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesYLabelFunction, iPosition:=3)
                clsBaseOperator.AddParameter("ggside_y", clsRFunctionParameter:=clsYsideHistogramFunction, bIncludeArgumentName:=False, iPosition:=1)
        End Select
        AddRemoveSidePlotThemeFunction()
    End Sub

    Private Sub AddRemoveFillColorParams(ucrReceiverTemp As ucrReceiverSingle, clsTempRFunction As RFunction, paramName As String, iPosition As Integer)
        If Not ucrReceiverTemp.IsEmpty() Then
            clsTempRFunction.AddParameter(paramName, ucrReceiverTemp.GetVariableNames(bWithQuotes:=False), iPosition:=iPosition)
        Else
            clsTempRFunction.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub HideShowFillReceiver()
        If rdoThreeVars.Checked Then
            ucrReceiverFill.Visible = True
        ElseIf rdoSide.Checked Then
            If Not ucrChkXSidePlot.Checked AndAlso Not ucrChkYSidePlot.Checked Then
                ucrReceiverFill.Visible = False
            Else
                ucrReceiverFill.Visible = True
            End If
        Else
            ucrReceiverFill.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverSecondVar_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondVar.SelectionChanged
        MatchSameCategoricalVariablesInReceivers(ucrReceiverSecondVar)
    End Sub

    Private Sub ucrReceiverFill_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFill.SelectionChanged, UcrReceiverSingle2.SelectionChanged
        MatchSameCategoricalVariablesInReceivers(ucrReceiverFill)
    End Sub

    Private Function GetReceiverVariableType(ucrTempReceiver As ucrReceiverSingle) As String
        Dim strTempVariableType As String = ""

        If Not ucrTempReceiver.IsEmpty() Then
            strTempVariableType = ucrTempReceiver.strCurrDataType
        End If

        If strTempVariableType.Contains("factor") OrElse strTempVariableType.Contains("character") OrElse strTempVariableType.Contains("logical") Then
            strTempVariableType = "categorical"
        End If

        Return strTempVariableType
    End Function

    Private Sub MatchSameCategoricalVariablesInReceivers(sender As ucrReceiver)
        If Not bRCodeSet OrElse rdoPairs.Checked OrElse sender.IsEmpty() Then
            Exit Sub
        End If
        Dim bContainedInMultipleReceiver As Boolean = False
        Dim strFillVariableType As String = ""
        Dim strColorVariableType As String = ""

        strFillVariableType = GetReceiverVariableType(ucrReceiverFill)
        strColorVariableType = GetReceiverVariableType(ucrReceiverColour)

        Dim bIsCategoricalVariables As Boolean = ((strFirstVariablesType = "categorical" OrElse strFirstVariablesType = "categoric") AndAlso strSecondVariableType = "categorical") OrElse
                                     (strFillVariableType <> "" AndAlso strFirstVariablesType = "categorical" AndAlso strFillVariableType = "categorical") OrElse
                                     (strColorVariableType <> "" AndAlso strFirstVariablesType = "categorical" AndAlso strColorVariableType = "categorical")


        If bIsCategoricalVariables AndAlso ucrReceiverFill IsNot Nothing AndAlso ucrReceiverFirstVars IsNot Nothing AndAlso
            ucrReceiverSecondVar IsNot Nothing AndAlso ucrReceiverColour IsNot Nothing AndAlso sender IsNot Nothing Then
            If TypeOf (sender) Is ucrReceiverSingle Then
                bContainedInMultipleReceiver = ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList().Contains(
                    TryCast(sender, ucrReceiverSingle).GetVariableNames()
                )
            Else
                Dim lstMultipleVariables As String() = ucrReceiverFirstVars.ucrMultipleVariables.GetVariableNamesList()
                If rdoThreeVars.Checked OrElse rdoTwoVars.Checked OrElse rdoSide.Checked Then
                    Dim bTempConContainedInMultipleReceiver As Boolean = False
                    bContainedInMultipleReceiver = lstMultipleVariables.Contains(ucrReceiverSecondVar.GetVariableNames())
                    If ucrReceiverFill IsNot Nothing AndAlso ucrReceiverFill.Visible AndAlso Not ucrReceiverFill.IsEmpty() Then
                        bTempConContainedInMultipleReceiver = lstMultipleVariables.Contains(ucrReceiverFill.GetVariableNames())
                    End If
                    bContainedInMultipleReceiver = bContainedInMultipleReceiver OrElse bTempConContainedInMultipleReceiver
                End If
            End If

            If sender Is ucrReceiverFirstVars Then
                If bContainedInMultipleReceiver And strFirstVariablesType = "categorical" Then
                    DisplayWarning("First Variable")
                End If
            ElseIf sender Is ucrReceiverSecondVar Then
                If bContainedInMultipleReceiver And strSecondVariableType = "categorical" Then
                    DisplayWarning("Second Variable")
                End If
            ElseIf sender Is ucrReceiverFill Then
                If bContainedInMultipleReceiver And strFillVariableType = "categorical" Then
                    DisplayWarning("Fill Variable")
                End If
            End If
        End If
    End Sub

    Private Sub DisplayWarning(strMessage As String)
        MsgBoxTranslate("Pick a categorical variable different from those selected in the " & strMessage & " to avoid Errors", vbOKOnly, "Matching Factor Variables")
    End Sub

    Private Sub AddRemoveSidePlotThemeFunction()
        If ucrChkXSidePlot.Checked OrElse ucrChkYSidePlot.Checked Then
            clsBaseOperator.AddParameter("side_plot_theme", clsRFunctionParameter:=clsSidePlotThemeFunction, bIncludeArgumentName:=False, iPosition:=12)
        Else
            clsBaseOperator.RemoveParameterByName("side_plot_theme")
        End If
    End Sub

End Class