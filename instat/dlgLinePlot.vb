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

Public Class dlgLinePlot
    Private clsRggplotFunction As New RFunction
    Private clsOptionsFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsGeomLineFunction As New RFunction
    Private clsGeomSmoothFunction As New RFunction
    Private clsGeomDumbbellFunction As New RFunction
    Private clsPointsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsPathFunction As New RFunction
    Private clsGeomStepFunction As New RFunction
    Private clsPeakFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsGeomSmoothFunc As New RFunction
    Private clsGeomSmoothParameter As New RParameter
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsListFunction As New RFunction
    Private clsFormulaFunction As New RFunction
    Private clsGgSlopeFunction As New RFunction
    Private clsSlopeThemeFunction As New RFunction
    Private clsDumbbellFunction As New RFunction
    Private clsGeomAreaFunction As New RFunction
    Private clsAesLinerangeFunction As New RFunction
    Private clsGeomLinerangeFunction As New RFunction
    Private clsGeomRibbonFunction As New RFunction
    Private clsGeomCrossbarFunction As New RFunction
    Private clsGeomErrorbarFunction As New RFunction
    Private clsGeomPointrangeFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strgeomSmoothParameterName As String = "geom_smooth"
    Private strGeomParameterNames() As String = {strFirstParameterName, strgeomSmoothParameterName}

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsGeomPointFunc As New RFunction
        Dim clsGeomPointParam As New RParameter
        Dim clsGeomLineFunction As New RFunction
        Dim clsGeomLineParameter As New RParameter
        Dim dctMethodOptions As New Dictionary(Of String, String)
        Dim dctFamilyOptions As New Dictionary(Of String, String)
        Dim dctColourOptions As New Dictionary(Of String, String)
        Dim dctSlopeLineColourOptions As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 434

        ucrLinePlotSelector.SetParameter(New RParameter("data", 0))
        ucrLinePlotSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.Selector = ucrLinePlotSelector
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrReceiverXEnd.SetParameter(New RParameter("xend", 2))
        ucrReceiverXEnd.Selector = ucrLinePlotSelector
        ucrReceiverXEnd.bWithQuotes = False
        ucrReceiverXEnd.SetParameterIsString()
        ucrReceiverXEnd.SetIncludedDataTypes({"numeric"})

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrLinePlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Factors"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrReceiverGroup.SetParameter(New RParameter("group", 2))
        ucrReceiverGroup.Selector = ucrLinePlotSelector
        ucrReceiverGroup.bWithQuotes = False
        ucrReceiverGroup.SetParameterIsString()

        ucrReceiverSlopeX.SetParameter(New RParameter("x", 1))
        ucrReceiverSlopeX.Selector = ucrLinePlotSelector
        ucrReceiverSlopeX.bWithQuotes = False
        ucrReceiverSlopeX.SetParameterIsString()
        ucrReceiverSlopeX.SetIncludedDataTypes({"factor"})

        ucrReceiverSlopeY.SetParameter(New RParameter("y", 2))
        ucrReceiverSlopeY.Selector = ucrLinePlotSelector
        ucrReceiverSlopeY.bWithQuotes = False
        ucrReceiverSlopeY.SetParameterIsString()
        ucrReceiverSlopeY.SetIncludedDataTypes({"numeric"})

        ucrReceiverSlopeColour.SetParameter(New RParameter("colour", 3))
        ucrReceiverSlopeColour.Selector = ucrLinePlotSelector
        ucrReceiverSlopeColour.bWithQuotes = False
        ucrReceiverSlopeColour.SetParameterIsString()
        ucrReceiverSlopeColour.SetIncludedDataTypes({"factor"})

        ucrVariablesAsFactorForLinePlot.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForLinePlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForLinePlot.Selector = ucrLinePlotSelector
        ucrVariablesAsFactorForLinePlot.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForLinePlot.SetParameterIsString()
        ucrVariablesAsFactorForLinePlot.bWithQuotes = False
        ucrVariablesAsFactorForLinePlot.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForLinePlot.bAddParameterIfEmpty = True

        ucrReceiverYMax.SetParameter(New RParameter("ymax", 0))
        ucrReceiverYMax.Selector = ucrLinePlotSelector
        ucrReceiverYMax.bWithQuotes = False
        ucrReceiverYMax.SetParameterIsString()
        ucrReceiverYMax.SetIncludedDataTypes({"numeric"})

        ucrReceiverYMin.SetParameter(New RParameter("ymin", 1))
        ucrReceiverYMin.Selector = ucrLinePlotSelector
        ucrReceiverYMin.bWithQuotes = False
        ucrReceiverYMin.SetParameterIsString()
        ucrReceiverYMin.SetIncludedDataTypes({"numeric"})

        clsGeomPointFunc.SetPackageName("ggplot2")
        clsGeomPointFunc.SetRCommand("geom_point")
        clsGeomPointParam.SetArgumentName("geom_point")
        clsGeomPointParam.SetArgument(clsGeomPointFunc)
        clsGeomPointParam.Position = 3
        ucrChkAddPoints.SetText("Add Points")
        ucrChkAddPoints.SetParameter(clsGeomPointParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")
        clsGeomLineParameter.SetArgumentName("geom_line")
        clsGeomLineParameter.SetArgument(clsGeomLineFunction)
        clsGeomLineParameter.Position = 4
        ucrChkAddLine.SetText("Add Line")
        ucrChkAddLine.SetParameter(clsGeomLineParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomSmoothFunc.SetPackageName("ggplot2")
        clsGeomSmoothFunc.SetRCommand("geom_smooth")
        clsGeomSmoothFunc.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsGeomSmoothParameter.SetArgumentName(strgeomSmoothParameterName)
        clsGeomSmoothParameter.SetArgument(clsGeomSmoothFunc)
        ucrChkLineofBestFit.SetText("Add Line of Best Fit")
        ucrChkLineofBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineofBestFit.SetParameter(clsGeomSmoothParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)


        ucrChkWithSE.SetText("Add SE")
        ucrChkWithSE.SetParameter(New RParameter("se", 1))
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrChkAddSE.SetText("Add SE")
        ucrChkAddSE.SetParameter(New RParameter("se", 1))
        ucrChkAddSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSave.SetPrefix("line_plot")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrLinePlotSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlStepOrPath.AddRadioButton(rdoArea)
        ucrPnlStepOrPath.AddRadioButton(rdoPath)
        ucrPnlStepOrPath.AddRadioButton(rdoStep)
        ucrPnlStepOrPath.AddFunctionNamesCondition(rdoArea, "geom_area")
        ucrPnlStepOrPath.AddFunctionNamesCondition(rdoPath, "geom_path")
        ucrPnlStepOrPath.AddFunctionNamesCondition(rdoStep, "geom_step")
        ucrChkPathOrStep.AddToLinkedControls(ucrPnlStepOrPath, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPathOrStep.SetText("Area/ Path/ Step")
        ucrChkPathOrStep.AddFunctionNamesCondition(True, {"geom_area", "geom_step", "geom_path"})
        ucrChkPathOrStep.AddFunctionNamesCondition(False, {"geom_area", "geom_step", "geom_path"}, False)

        ucrPnlLinerangeOptions.AddRadioButton(rdoRibbon)
        ucrPnlLinerangeOptions.AddRadioButton(rdoPointrange)
        ucrPnlLinerangeOptions.AddRadioButton(rdoCrossbar)
        ucrPnlLinerangeOptions.AddRadioButton(rdoErrorbar)
        ucrPnlLinerangeOptions.AddFunctionNamesCondition(rdoRibbon, "geom_ribbon")
        ucrPnlLinerangeOptions.AddFunctionNamesCondition(rdoPointrange, "geom_pointrange")
        ucrPnlLinerangeOptions.AddFunctionNamesCondition(rdoCrossbar, "geom_crossbar")
        ucrPnlLinerangeOptions.AddFunctionNamesCondition(rdoErrorbar, "geom_errorbar")

        ucrChkRibbon.SetText("Ribbon/ Point/ Bar")
        ucrChkRibbon.AddFunctionNamesCondition(True, {"geom_ribbon", "geom_pointrange", "geom_crossbar", "geom_errorbar"})
        ucrChkRibbon.AddFunctionNamesCondition(False, {"geom_ribbon", "geom_pointrange", "geom_crossbar", "geom_errorbar"}, False)
        ucrChkRibbon.AddToLinkedControls(ucrPnlLinerangeOptions, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddRadioButton(rdoLine)
        ucrPnlOptions.AddRadioButton(rdoSmoothing)
        ucrPnlOptions.AddRadioButton(rdoLinerange)
        ucrPnlOptions.AddRadioButton(rdoDumbbell)
        ucrPnlOptions.AddRadioButton(rdoSlope)

        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoLine, strFirstParameterName, {"geom_line", "geom_area", "geom_path", "geom_step"})
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoSmoothing, strFirstParameterName, {"geom_smooth"})
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoLinerange, strFirstParameterName, {"geom_linerange", "geom_ribbon", "geom_pointrange", "geom_crossbar", "geom_errorbar"})
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoDumbbell, "dumbbellplot", {"geom_dumbbell"})
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoSlope, "slopeplot", {"slopegraph", "slopegraph_theme"})

        ucrInputMethod.SetParameter(New RParameter("method", 3))
        dctMethodOptions.Add("loess", Chr(34) & "loess" & Chr(34))
        dctMethodOptions.Add("linear", Chr(34) & "lm" & Chr(34))
        dctMethodOptions.Add("glm", Chr(34) & "glm" & Chr(34))
        dctMethodOptions.Add("gam", Chr(34) & "gam" & Chr(34))
        dctMethodOptions.Add("rlm", "MASS::rlm")
        ucrInputMethod.SetItems(dctMethodOptions)
        ucrInputMethod.SetDropDownStyleAsNonEditable()
        ucrInputMethod.SetRDefault(Chr(34) & "loess" & Chr(34))

        ucrNudSpan.SetParameter(New RParameter("span", 4))
        ucrNudSpan.SetMinMax(0, Integer.MaxValue)
        ucrNudSpan.Increment = 0.05
        ucrNudSpan.DecimalPlaces = 2

        ucrInputMethod.AddToLinkedControls(ucrChkSpan, {"loess"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpan.SetText("Span")
        ucrChkSpan.AddToLinkedControls(ucrNudSpan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.75)

        ucrInputFormula.SetParameter(New RParameter("formula", 3))
        ucrInputFormula.SetItems({"y ~ x", "y ~ poly(x, 2)", "y ~ log(x)", "y ~ splines::bs(x,3)"})
        ucrChkFormula.SetText("Formula")
        ucrChkFormula.AddToLinkedControls(ucrInputFormula, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrFamilyInput.SetParameter(New RParameter("family", 4))
        dctFamilyOptions.Add("Binomial", Chr(34) & "binomial" & Chr(34))
        dctFamilyOptions.Add("Gaussian", Chr(34) & "gaussian" & Chr(34))
        dctFamilyOptions.Add("Poisson", Chr(34) & "poisson" & Chr(34))
        dctFamilyOptions.Add("Gamma", Chr(34) & "gamma" & Chr(34))
        dctFamilyOptions.Add("Inverse.gaussian", Chr(34) & "inverse.gaussian" & Chr(34))
        dctFamilyOptions.Add("Guasi", Chr(34) & "quasi" & Chr(34))
        dctFamilyOptions.Add("Quasibinomial", Chr(34) & "quasibinomial" & Chr(34))
        dctFamilyOptions.Add("Quasipoisson", Chr(34) & "quasipoisson" & Chr(34))
        ucrFamilyInput.SetItems(dctFamilyOptions)
        ucrFamilyInput.SetDropDownStyleAsNonEditable()
        ucrFamilyInput.SetRDefault(Chr(34) & "binomial" & Chr(34))

        ucrInputMethod.AddToLinkedControls(ucrFamilyInput, {"gam", "glm"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrFamilyInput.SetLinkedDisplayControl(lblFamily)

        ucrInputDumbbellX.SetParameter(New RParameter("colour_x", 2))
        dctColourOptions.Add("Black", Chr(34) & "black" & Chr(34))
        dctColourOptions.Add("White", Chr(34) & "white" & Chr(34))
        dctColourOptions.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctColourOptions.Add("Red", Chr(34) & "red" & Chr(34))
        dctColourOptions.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctColourOptions.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctColourOptions.Add("Green", Chr(34) & "green" & Chr(34))
        dctColourOptions.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctColourOptions.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctColourOptions.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctColourOptions.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputDumbbellX.SetItems(dctColourOptions)
        ucrInputDumbbellX.SetDropDownStyleAsNonEditable()

        ucrInputDumbbellXEnd.SetParameter(New RParameter("colour_xend", 3))
        ucrInputDumbbellXEnd.SetItems(dctColourOptions)
        ucrInputDumbbellXEnd.SetDropDownStyleAsNonEditable()

        ucrInputDumbbellLine.SetParameter(New RParameter("colour", 4))
        ucrInputDumbbellLine.SetItems(dctColourOptions)
        ucrInputDumbbellLine.SetDropDownStyleAsNonEditable()

        ucrNudDumbbellX.SetParameter(New RParameter("size_x", 5))
        ucrNudDumbbellX.SetMinMax(0, Integer.MaxValue)
        ucrNudDumbbellX.Increment = 0.1
        ucrNudDumbbellX.DecimalPlaces = 1

        ucrNudDumbbellXEnd.SetParameter(New RParameter("size_xend", 6))
        ucrNudDumbbellXEnd.SetMinMax(0, Integer.MaxValue)
        ucrNudDumbbellXEnd.Increment = 0.1
        ucrNudDumbbellXEnd.DecimalPlaces = 1

        ucrNudDumbbellLine.SetParameter(New RParameter("size", 7))
        ucrNudDumbbellLine.SetMinMax(0, Integer.MaxValue)
        ucrNudDumbbellLine.Increment = 0.1
        ucrNudDumbbellLine.DecimalPlaces = 1

        ucrChkDumbbellSize.SetText("Size")
        ucrChkDumbbellSize.AddParameterPresentCondition(True, "size_xend")
        ucrChkDumbbellSize.AddParameterPresentCondition(False, "size_xend", False)

        ucrChkDumbbellColour.SetText("Colour")
        ucrChkDumbbellColour.AddParameterPresentCondition(True, "colour_xend")
        ucrChkDumbbellColour.AddParameterPresentCondition(False, "colour_xend", False)

        ucrInputSlopeLabelColour.SetParameter(New RParameter("data_label_fill_colour", 4))
        ucrInputSlopeLabelColour.SetItems(dctColourOptions)
        ucrInputSlopeLabelColour.SetDropDownStyleAsNonEditable()

        ucrNudSlopeLabelSize.SetParameter(New RParameter("data_label_line_size", 5))
        ucrNudSlopeLabelSize.SetMinMax(0, Integer.MaxValue)
        ucrNudSlopeLabelSize.Increment = 0.05
        ucrNudSlopeLabelSize.DecimalPlaces = 2

        ucrNudSlopeLabelPadding.SetParameter(New RParameter("data_label_padding", 6))
        ucrNudSlopeLabelPadding.SetMinMax(0, Integer.MaxValue)
        ucrNudSlopeLabelPadding.Increment = 0.05
        ucrNudSlopeLabelPadding.DecimalPlaces = 2

        ucrChkSlopeLabelOptions.SetText("Label")
        ucrChkSlopeLabelOptions.AddParameterPresentCondition(True, "data_label_fill_colour")
        ucrChkSlopeLabelOptions.AddParameterPresentCondition(False, "data_label_fill_colour", False)

        ucrInputSlopeTextColour.SetParameter(New RParameter("data_text_colour", 7))
        ucrInputSlopeTextColour.SetItems(dctColourOptions)
        ucrInputSlopeTextColour.SetDropDownStyleAsNonEditable()

        ucrNudSlopeTextSize.SetParameter(New RParameter("data_text_size", 8))
        ucrNudSlopeTextSize.SetMinMax(0, Integer.MaxValue)
        ucrNudSlopeTextSize.Increment = 0.5
        ucrNudSlopeTextSize.DecimalPlaces = 1

        UcrNudSlopeYTextSize.SetParameter(New RParameter("y_text_size", 9))
        UcrNudSlopeYTextSize.SetMinMax(0, Integer.MaxValue)
        UcrNudSlopeYTextSize.Increment = 0.5
        UcrNudSlopeYTextSize.DecimalPlaces = 1

        ucrChkSlopeTextOptions.SetText("Text")
        ucrChkSlopeTextOptions.AddParameterPresentCondition(True, "data_text_colour")
        ucrChkSlopeTextOptions.AddParameterPresentCondition(False, "data_text_colour", False)

        ucrInputSlopeLineColour.SetParameter(New RParameter("line_colour", 10))
        dctSlopeLineColourOptions.Add("ByGroup", Chr(34) & "ByGroup" & Chr(34))
        dctSlopeLineColourOptions.Add("Black", Chr(34) & "black" & Chr(34))
        dctSlopeLineColourOptions.Add("White", Chr(34) & "white" & Chr(34))
        dctSlopeLineColourOptions.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctSlopeLineColourOptions.Add("Red", Chr(34) & "red" & Chr(34))
        dctSlopeLineColourOptions.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctSlopeLineColourOptions.Add("Purple", Chr(34) & "purple" & Chr(34))
        dctSlopeLineColourOptions.Add("Green", Chr(34) & "green" & Chr(34))
        dctSlopeLineColourOptions.Add("Orange", Chr(34) & "orange" & Chr(34))
        dctSlopeLineColourOptions.Add("Grey", Chr(34) & "grey" & Chr(34))
        dctSlopeLineColourOptions.Add("Brown", Chr(34) & "brown" & Chr(34))
        dctSlopeLineColourOptions.Add("Pink", Chr(34) & "pink" & Chr(34))
        ucrInputSlopeLineColour.SetItems(dctSlopeLineColourOptions)
        ucrInputSlopeLineColour.SetDropDownStyleAsNonEditable()

        ucrNudSlopeLineThickness.SetParameter(New RParameter("line_thickness", 12))
        ucrNudSlopeLineThickness.SetMinMax(0, Integer.MaxValue)
        ucrNudSlopeLineThickness.Increment = 0.5
        ucrNudSlopeLineThickness.DecimalPlaces = 1

        ucrChkSlopeLineOptions.SetText("Line")
        ucrChkSlopeLineOptions.AddParameterPresentCondition(True, "line_colour")
        ucrChkSlopeLineOptions.AddParameterPresentCondition(False, "line_colour", False)

        ucrChkSlopeLegend.SetText("Legend")
        ucrChkSlopeLegend.AddParameterPresentCondition(True, "slopetheme")
        ucrChkSlopeLegend.AddParameterPresentCondition(False, "slopetheme", False)

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
        ucr1stFactorReceiver.Selector = ucrLinePlotSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrPnlOptions.AddToLinkedControls({ucrChkPathOrStep, ucrChkWithSE, ucrChkLineofBestFit}, {rdoLine}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkAddLine, ucrInputMethod, ucrInputFormula}, {rdoSmoothing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkAddSE, ucrChkFormula, ucrChkSpan}, {rdoSmoothing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="FALSE")
        ucrPnlOptions.AddToLinkedControls({ucrReceiverXEnd, ucrChkDumbbellColour, ucrChkDumbbellSize}, {rdoDumbbell}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkAddPoints}, {rdoLine, rdoSmoothing, rdoLinerange}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrFactorOptionalReceiver}, {rdoLine, rdoSmoothing, rdoLinerange}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSlopeY}, {rdoDumbbell, rdoSlope, rdoLinerange}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverX}, {rdoLine, rdoDumbbell, rdoSmoothing, rdoLinerange}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrVariablesAsFactorForLinePlot}, {rdoLine, rdoSmoothing}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSlopeX, ucrReceiverSlopeColour, ucrChkSlopeLabelOptions, ucrChkSlopeTextOptions, ucrChkSlopeLineOptions, ucrChkSlopeLegend}, {rdoSlope}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverYMax, ucrReceiverYMin, ucrChkRibbon}, {rdoLinerange}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDumbbellColour.AddToLinkedControls({ucrInputDumbbellX}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Orange")
        ucrChkDumbbellColour.AddToLinkedControls({ucrInputDumbbellXEnd}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Blue")
        ucrChkDumbbellColour.AddToLinkedControls({ucrInputDumbbellLine}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrChkDumbbellSize.AddToLinkedControls({ucrNudDumbbellX}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4.0)
        ucrChkDumbbellSize.AddToLinkedControls({ucrNudDumbbellXEnd}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4.0)
        ucrChkDumbbellSize.AddToLinkedControls({ucrNudDumbbellLine}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)

        ucrChkSlopeLabelOptions.AddToLinkedControls({ucrInputSlopeLabelColour}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="White")
        ucrChkSlopeLabelOptions.AddToLinkedControls({ucrNudSlopeLabelSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkSlopeLabelOptions.AddToLinkedControls({ucrNudSlopeLabelPadding}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.05)

        ucrChkSlopeTextOptions.AddToLinkedControls({ucrInputSlopeTextColour}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrChkSlopeTextOptions.AddToLinkedControls({ucrNudSlopeTextSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2.5)
        ucrChkSlopeTextOptions.AddToLinkedControls({UcrNudSlopeYTextSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=3)

        ucrChkSlopeLineOptions.AddToLinkedControls({ucrInputSlopeLineColour}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="ByGroup")
        ucrChkSlopeLineOptions.AddToLinkedControls({ucrNudSlopeLineThickness}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrChkFormula.SetLinkedDisplayControl(grpSmoothOptions)
        ucrReceiverXEnd.SetLinkedDisplayControl(lblXEnd)
        ucrReceiverX.SetLinkedDisplayControl(lblXVariable)
        ucrReceiverSlopeY.SetLinkedDisplayControl(lblSlopeY)
        ucrReceiverSlopeColour.SetLinkedDisplayControl(lblSlopeColour)
        ucrReceiverSlopeX.SetLinkedDisplayControl(lblSlopeX)
        ucrReceiverYMax.SetLinkedDisplayControl(lblYMax)
        ucrReceiverYMin.SetLinkedDisplayControl(lblYMin)
        ucrFactorOptionalReceiver.SetLinkedDisplayControl(lblFactorOptional)
        ucrReceiverGroup.SetLinkedDisplayControl(lblGroupLine)
        ucrInputDumbbellX.SetLinkedDisplayControl(lblXColour)
        ucrInputDumbbellXEnd.SetLinkedDisplayControl(lblXEndColour)
        ucrInputDumbbellLine.SetLinkedDisplayControl(lblLineColour)
        ucrNudDumbbellX.SetLinkedDisplayControl(lblXSize)
        ucrNudDumbbellXEnd.SetLinkedDisplayControl(lblXEndSize)
        ucrNudDumbbellLine.SetLinkedDisplayControl(lblLineSize)

        ucrInputSlopeLabelColour.SetLinkedDisplayControl(lblSlopeLabelColour)
        ucrNudSlopeLabelSize.SetLinkedDisplayControl(lblSlopeLabelSize)
        ucrNudSlopeLabelPadding.SetLinkedDisplayControl(lblSlopeLabelPadding)
        ucrInputSlopeTextColour.SetLinkedDisplayControl(lblSopeTextColour)
        ucrNudSlopeTextSize.SetLinkedDisplayControl(lblSlopeTextSize)
        UcrNudSlopeYTextSize.SetLinkedDisplayControl(lblSlopeYTextSize)
        ucrInputSlopeLineColour.SetLinkedDisplayControl(lblSlopeLineColour)
        ucrNudSlopeLineThickness.SetLinkedDisplayControl(lblSlopeLineTicknes)
    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsOptionsFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator
        clsListFunction = New RFunction
        clsGgSlopeFunction = New RFunction
        clsSlopeThemeFunction = New RFunction
        clsDumbbellFunction = New RFunction
        clsPointsFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsGeomSmoothFunction = New RFunction
        clsGeomDumbbellFunction = New RFunction
        clsPathFunction = New RFunction
        clsGeomStepFunction = New RFunction
        clsGeomAreaFunction = New RFunction
        clsAesLinerangeFunction = New RFunction
        clsGeomCrossbarFunction = New RFunction
        clsGeomErrorbarFunction = New RFunction
        clsGeomLinerangeFunction = New RFunction
        clsGeomPointrangeFunction = New RFunction
        clsGeomRibbonFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrLinePlotSelector.Reset()
        ucrLinePlotSelector.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrVariablesAsFactorForLinePlot.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True
        rdoArea.Checked = True
        rdoRibbon.Checked = True
        ucrReceiverGroup.Visible = False

        ucrInputFormula.SetText("y ~ x")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsOptionsFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsAesLinerangeFunction.SetRCommand("aes")

        clsOptionsFunction.SetPackageName("ggplot2")
        clsOptionsFunction.SetRCommand("geom_line")
        clsOptionsFunction.AddParameter("se", "FALSE", iPosition:=1)

        clsDumbbellFunction.SetPackageName("ggalt")
        clsDumbbellFunction.SetRCommand("geom_dumbbell")

        clsGgSlopeFunction.SetRCommand("slopegraph")
        clsGgSlopeFunction.AddParameter("data", clsRFunctionParameter:=ucrLinePlotSelector.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsSlopeThemeFunction.SetRCommand("slopegraph_theme")

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

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
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

        clsListFunction.SetRCommand("list")

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")
        clsGeomLineFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        clsGeomLineFunction.AddParameter("size", "0.8")

        clsPathFunction.SetPackageName("ggplot2")
        clsPathFunction.SetRCommand("geom_path")
        clsPathFunction.AddParameter("linemitre", "10")

        clsGeomStepFunction.SetPackageName("ggplot2")
        clsGeomStepFunction.SetRCommand("geom_step")

        clsGeomSmoothFunction.SetPackageName("ggplot2")
        clsGeomSmoothFunction.SetRCommand("geom_smooth")
        clsGeomSmoothFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunction.AddParameter("size", "1")

        clsGeomDumbbellFunction.SetPackageName("ggplot2")
        clsGeomDumbbellFunction.SetRCommand("geom_dumbbell")
        clsGeomDumbbellFunction.AddParameter("dot_guide", "TRUE")
        clsGeomDumbbellFunction.AddParameter("dot_guide_size", "0.3")

        clsPointsFunction.SetPackageName("ggplot2")
        clsPointsFunction.SetRCommand("geom_point")
        clsPointsFunction.AddParameter("size", "3")
        clsPointsFunction.AddParameter("colour", Chr(34) & "red" & Chr(34))

        clsGeomAreaFunction.SetPackageName("ggplot2")
        clsGeomAreaFunction.SetRCommand("geom_area")

        clsGeomLinerangeFunction.SetPackageName("ggplot2")
        clsGeomLinerangeFunction.SetRCommand("geom_linerange")

        clsGeomRibbonFunction.SetPackageName("ggplot2")
        clsGeomRibbonFunction.SetRCommand("geom_ribbon")

        clsGeomCrossbarFunction.SetPackageName("ggplot2")
        clsGeomCrossbarFunction.SetRCommand("geom_crossbar")

        clsGeomErrorbarFunction.SetPackageName("ggplot2")
        clsGeomErrorbarFunction.SetRCommand("geom_errorbar")

        clsGeomPointrangeFunction.SetPackageName("ggplot2")
        clsGeomPointrangeFunction.SetRCommand("geom_pointrange")

        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsBaseOperator.RemoveParameterByName("geom_point")
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorOptionalReceiver.AddAdditionalCodeParameterPair(clsGgSlopeFunction, New RParameter("colour", iNewPosition:=3), iAdditionalPairNo:=1)
        ucrReceiverSlopeY.AddAdditionalCodeParameterPair(clsRaesFunction, New RParameter("y", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrLinePlotSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrReceiverSlopeY.SetRCode(clsGgSlopeFunction, bReset)
        ucrReceiverSlopeX.SetRCode(clsGgSlopeFunction, bReset)
        ucrReceiverSlopeColour.SetRCode(clsGgSlopeFunction, bReset)
        ucrReceiverXEnd.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForLinePlot.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkLineofBestFit.SetRCode(clsBaseOperator, bReset)
        ucrChkAddPoints.SetRCode(clsBaseOperator, bReset)
        ucrChkAddLine.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunc, bReset)
        ucrChkAddSE.SetRCode(clsOptionsFunction, bReset)
        ucrReceiverYMax.SetRCode(clsAesLinerangeFunction, bReset)
        ucrReceiverYMin.SetRCode(clsAesLinerangeFunction, bReset)
        ucrChkPathOrStep.SetRCode(clsOptionsFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrInputMethod.SetRCode(clsOptionsFunction, bReset)
        ucrNudSpan.SetRCode(clsOptionsFunction, bReset)
        ucrFamilyInput.SetRCode(clsListFunction, bReset)
        ucrChkFormula.SetRCode(clsBaseOperator, bReset)
        ucrChkDumbbellColour.SetRCode(clsDumbbellFunction, bReset)
        ucrChkDumbbellSize.SetRCode(clsDumbbellFunction, bReset)
        ucrChkSlopeLabelOptions.SetRCode(clsGgSlopeFunction, bReset)
        ucrChkSlopeTextOptions.SetRCode(clsGgSlopeFunction, bReset)
        ucrChkSlopeLineOptions.SetRCode(clsGgSlopeFunction, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrChkRibbon.SetRCode(clsOptionsFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        'Both x and y aesthetics are mandatory for geom_line. However, when not filled they will be automatically populated by "".
        If Not ucrSave.IsComplete OrElse ((rdoLine.Checked OrElse rdoSmoothing.Checked) AndAlso
            (ucrReceiverX.IsEmpty() AndAlso ucrVariablesAsFactorForLinePlot.IsEmpty())) OrElse
            (rdoDumbbell.Checked AndAlso (ucrReceiverX.IsEmpty() OrElse ucrReceiverSlopeY.IsEmpty() OrElse
            ucrReceiverXEnd.IsEmpty())) OrElse (rdoSlope.Checked AndAlso (ucrReceiverSlopeX.IsEmpty() OrElse
            ucrReceiverSlopeY.IsEmpty() OrElse ucrReceiverSlopeColour.IsEmpty())) OrElse (rdoLinerange.Checked AndAlso
            (ucrReceiverSlopeY.IsEmpty() OrElse ucrReceiverYMax.IsEmpty() OrElse ucrReceiverYMin.IsEmpty() OrElse ucrReceiverX.IsEmpty())) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrLinePlotSelector,
                                   bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the value stored in the clsReasFunction in the multiple variables 
                '  case is "value", however that one shouldn't be written in the multiple 
                '  variables receiver (otherwise it would stack all variables and the stack 
                '  ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables 
                '  independently from the multiple variables method? Here if the receiver is 
                '  actually in single mode, the variable "value" will still be given back, which 
                '  throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForLinePlot.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrVariablesAsFactorForLinePlot.Clear()
                Else
                    ucrVariablesAsFactorForLinePlot.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrReceiverGroup.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged,
        ucrFactorOptionalReceiver.ControlValueChanged, ucrPnlOptions.ControlValueChanged, ucrReceiverGroup.ControlValueChanged
        SetGroupParam()
    End Sub

    Private Sub SetGroupParam()
        If rdoLine.Checked OrElse rdoSmoothing.Checked OrElse rdoLinerange.Checked Then
            ucrReceiverGroup.Visible = False
            If (Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor")) AndAlso ucrFactorOptionalReceiver.IsEmpty Then
                clsRaesFunction.AddParameter("group", "1", iPosition:=3)
                ucrReceiverGroup.Visible = False
            ElseIf (Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor")) AndAlso Not ucrFactorOptionalReceiver.IsEmpty Then
                ucrReceiverGroup.Visible = True
                ucrReceiverGroup.SetText(ucrFactorOptionalReceiver.GetVariableNames(False))
                clsRaesFunction.AddParameter("group", ucrReceiverGroup.GetVariableNames(False), iPosition:=3)
            Else
                ucrReceiverGroup.Visible = False
                clsRaesFunction.RemoveParameterByName("group")
            End If
        Else
            clsRaesFunction.RemoveParameterByName("group")
        End If
    End Sub

    Private Sub SetGraphPrefixAndRcommand()
        ucrVariablesAsFactorForLinePlot.SetMeAsReceiver()
        cmdOptions.Visible = True
        clsBaseOperator.RemoveParameterByName("slopeplot")
        clsBaseOperator.RemoveParameterByName("slopetheme")
        clsBaseOperator.RemoveParameterByName("dumbbellplot")
        clsOptionsFunction.RemoveParameterByName("stat")
        clsOptionsFunction.RemoveParameterByName("position")
        clsOptionsFunction.RemoveParameterByName("aes")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsOptionsFunction, iPosition:=1)
        clsOptionsFunction.SetPackageName("ggplot2")
        If rdoLine.Checked Then
            If ucrChkPathOrStep.Checked Then
                If rdoArea.Checked Then
                    ucrSave.SetPrefix("area_plot")
                    clsRaesFunction.RemoveParameterByName("colour")
                    clsRaesFunction.AddParameter("fill", ucrFactorOptionalReceiver.GetVariableNames(False), iPosition:=2)
                    clsOptionsFunction.SetRCommand("geom_area")
                ElseIf rdoStep.Checked Then
                    ucrSave.SetPrefix("step_plot")
                    clsRaesFunction.RemoveParameterByName("fill")
                    clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False), iPosition:=2)
                    clsOptionsFunction.SetRCommand("geom_step")
                Else
                    ucrSave.SetPrefix("path_plot")
                    clsRaesFunction.RemoveParameterByName("fill")
                    clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False), iPosition:=2)
                    clsOptionsFunction.SetRCommand("geom_path")
                End If
            Else
                ucrSave.SetPrefix("line_plot")
                clsRaesFunction.RemoveParameterByName("fill")
                clsOptionsFunction.SetRCommand("geom_line")
            End If
        ElseIf rdoSmoothing.Checked Then
            clsRaesFunction.RemoveParameterByName("fill")
            ucrSave.SetPrefix("smooth")
            clsOptionsFunction.SetRCommand("geom_smooth")
        ElseIf rdoLinerange.Checked Then
            ucrReceiverSlopeY.SetMeAsReceiver()
            clsRaesFunction.RemoveParameterByName("fill")
            clsOptionsFunction.AddParameter("aes", clsRFunctionParameter:=clsAesLinerangeFunction, iPosition:=0, bIncludeArgumentName:=False)
            clsOptionsFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsOptionsFunction.AddParameter("position", Chr(34) & "identity" & Chr(34), iPosition:=2)
            If ucrChkRibbon.Checked Then
                If rdoRibbon.Checked Then
                    ucrSave.SetPrefix("ribbon")
                    clsOptionsFunction.SetRCommand("geom_ribbon")
                ElseIf rdoPointrange.Checked Then
                    ucrSave.SetPrefix("pointrange")
                    clsOptionsFunction.SetRCommand("geom_pointrange")
                ElseIf rdoCrossbar.Checked Then
                    ucrSave.SetPrefix("crossbar")
                    clsOptionsFunction.SetRCommand("geom_crossbar")
                Else
                    ucrSave.SetPrefix("errorbar")
                    clsOptionsFunction.SetRCommand("geom_errorbar")
                End If
            Else
                ucrSave.SetPrefix("linerange")
                clsOptionsFunction.SetRCommand("geom_linerange")
            End If
        ElseIf rdoDumbbell.Checked Then
            ucrReceiverSlopeY.SetMeAsReceiver()
            clsRaesFunction.RemoveParameterByName("fill")
            ucrSave.SetPrefix("dumbbell")
            clsBaseOperator.RemoveParameterByName(strFirstParameterName)
            clsBaseOperator.AddParameter("dumbbellplot", clsRFunctionParameter:=clsDumbbellFunction, iPosition:=1)
        ElseIf rdoSlope.Checked Then
            ucrReceiverSlopeY.SetMeAsReceiver()
            clsRaesFunction.RemoveParameterByName("fill")
            cmdOptions.Visible = False
            ucrSave.SetPrefix("slope")
            clsBaseOperator.RemoveParameterByName("ggplot")
            clsBaseOperator.RemoveParameterByName(strFirstParameterName)
            clsBaseOperator.AddParameter("slopeplot", clsRFunctionParameter:=clsGgSlopeFunction, iPosition:=0)
            If ucrChkSlopeLegend.Checked Then
                clsBaseOperator.RemoveParameterByName("slopetheme")
            Else
                clsBaseOperator.AddParameter("slopetheme", clsRFunctionParameter:=clsSlopeThemeFunction, iPosition:=-1)
            End If
        End If
    End Sub

    Private Sub ucrChkPathOrStep_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPathOrStep.ControlValueChanged,
        ucrPnlStepOrPath.ControlValueChanged, ucrPnlOptions.ControlValueChanged, ucrChkSlopeLegend.ControlValueChanged,
        ucrPnlLinerangeOptions.ControlValueChanged, ucrChkRibbon.ControlValueChanged, ucrFactorOptionalReceiver.ControlValueChanged
        SetGraphPrefixAndRcommand()
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrReceiverXEnd.ControlContentsChanged,
        ucrReceiverSlopeX.ControlContentsChanged, ucrReceiverSlopeY.ControlContentsChanged, ucrReceiverSlopeColour.ControlContentsChanged,
        ucrVariablesAsFactorForLinePlot.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrFactorOptionalReceiver.ControlContentsChanged,
        ucrReceiverYMax.ControlContentsChanged, ucrReceiverYMin.ControlContentsChanged ', ucrReceiverYVar.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMethod.ControlValueChanged
        If ucrInputMethod.GetText = "glm" OrElse ucrInputMethod.GetText = "gam" Then
            clsOptionsFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        Else
            clsOptionsFunction.RemoveParameterByName("method.args")
        End If
    End Sub

    Private Sub ucrInputFormula_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFormula.ControlValueChanged, ucrChkFormula.ControlValueChanged
        If ucrChkFormula.Checked AndAlso ucrInputFormula.GetText <> "" Then
            clsOptionsFunction.AddParameter("formula", ucrInputFormula.GetText, iPosition:=1)
        Else
            clsOptionsFunction.RemoveParameterByName("formula")
        End If
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, PlotOptionsToolStripMenuItem.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                                clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                                clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrLinePlotSelector, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
 clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
        clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                                strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub AreaOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AreaOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomAreaFunction)
    End Sub

    Private Sub DumbbellOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DumbbellOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomDumbbellFunction)
    End Sub

    Private Sub LineOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LineOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomLineFunction)
    End Sub

    Private Sub SmoothOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmoothOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomSmoothFunction)
    End Sub

    Private Sub PointOptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointOptionToolStripMenuItem.Click
        openSdgLayerOptions(clsPointsFunction)
    End Sub

    Private Sub PathOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PathOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsPathFunction)
    End Sub

    Private Sub StepOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StepOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomStepFunction)
    End Sub

    Private Sub CrossbarOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrossbarOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomCrossbarFunction)
    End Sub

    Private Sub ErrorbarOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorbarOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomErrorbarFunction)
    End Sub

    Private Sub LinerangeOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinerangeOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomLinerangeFunction)
    End Sub

    Private Sub PointrangeOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PointrangeOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomPointrangeFunction)
    End Sub

    Private Sub RibbonOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RibbonOptionsToolStripMenuItem.Click
        openSdgLayerOptions(clsGeomRibbonFunction)
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrLinePlotSelector.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
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
        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
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
        If ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrLinePlotSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrLinePlotSelector.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub
End Class