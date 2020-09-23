'R-Instat
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

Public Class dlgSeasonalPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    'summary functions + operators
    Private clsPipeOperator As ROperator
    Private clsAndOperator As ROperator
    Private clsRefGreaterOperator As ROperator
    Private clsEst1GreaterOperator As ROperator
    Private clsRefLessOperator As ROperator
    Private clsEst1LessOperator As ROperator
    Private clsDivideOperator As ROperator
    Private clsLessOperator As ROperator
    Private clsGreaterOperator As ROperator
    Private clsEst2GreaterOperator As ROperator
    Private clsEst2LessOperator As ROperator

    Private clsMissingFilterFunction As RFunction
    Private clsRefIsNotNaFunction As RFunction
    Private clsEstIsNotNaFunction As RFunction
    Private clsMutateFunction As RFunction
    Private clsPivotLongerFunction As RFunction
    Private clsGroupByFunction As RFunction
    Private clsSummariseFunction As RFunction
    Private clsMovingMutateFunction As RFunction
    Private clsMovingFunction As RFunction
    Private clsNSumFunction As RFunction
    Private clsPropSumFunction As RFunction
    Private clsNotIsNaThreshFunction As RFunction
    Private clsMeanFunction As RFunction
    Private clsMeanFilterFunction As RFunction
    Private clsStdFunction As RFunction

    'ggplot functions + operators
    Private clsPlusOperator As ROperator
    Private clsFacetWrapTildeOperator As ROperator
    Private clsPbsSplinesTildeOperator As ROperator

    Private clsGgplotFunction As RFunction
    Private clsGeomPointFunction As RFunction
    Private clsGeomLineFunction As RFunction
    Private clsGeomSmoothFunction As RFunction
    Private clsGgPlotAesFunction As RFunction
    Private clsGeomLineAesFunction As RFunction
    Private clsFacetWrapFunction As RFunction
    Private clsAsFormulaFunction As RFunction
    Private clsPasteFunction As RFunction
    Private clsFourierSeriesFunction As RFunction
    Private clsListFunction As RFunction
    Private clsBinomialFunction As RFunction
    Private clsPbsFunction As RFunction
    Private clsNsFunction As RFunction
    Private clsYlabFunction As RFunction

    Private Sub dlgSeasonalPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
            SetRcodeForControls(bReset)
        End If
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorSeasonalityComparisons.SetParameter(New RParameter("data", 0))
        ucrSelectorSeasonalityComparisons.SetParameterIsrfunction()

        ucrReceiverReference.SetParameter(New RParameter("x", 0))
        ucrReceiverReference.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverReference.SetParameterIsRFunction()

        ucrReceiverEstimate.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimate.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverEstimate.SetParameterIsRFunction()

        ucrReceiverSeasonality.SetParameter(New RParameter("seasonality", 2, bNewIncludeArgumentName:=False))
        ucrReceiverSeasonality.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverSeasonality.SetParameterIsRFunction()
        ucrReceiverSeasonality.SetClimaticType("doy")
        ucrReceiverSeasonality.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("station", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrInputReferenceSummary.SetItems({"Mean", "Mean Above", "Mean Below", "Prop Above", "Prop Below", "Std.dev"})
        ucrInputReferenceSummary.SetDropDownStyleAsNonEditable()

        ucrInputEstimateSummary.SetItems({"Prop Above", "Prop Below"})
        ucrInputEstimateSummary.SetDropDownStyleAsNonEditable()

        ucrInputReferenceThreshold.SetParameter(New RParameter("value", 1))
        ucrInputReferenceThreshold.SetValidationTypeAsNumeric()
        ucrInputReferenceThreshold.AddQuotesIfUnrecognised = False

        ucrInputEstimateThreshold.SetParameter(New RParameter("value", 1))
        ucrInputEstimateThreshold.SetValidationTypeAsNumeric()
        ucrInputEstimateThreshold.AddQuotesIfUnrecognised = False

        ucrInputN.SetParameter(New RParameter("n", 1))
        ucrInputN.SetValidationTypeAsNumeric()
        ucrInputN.AddQuotesIfUnrecognised = False

        ucrChkRemoveMissing.SetText("Remove rows with any missing values")
        ucrChkRemoveMissing.AddParameterPresentCondition(True, "filter")
        ucrChkRemoveMissing.AddParameterPresentCondition(False, "filter", False)

        ucrChkOptionalSummary.SetText("Different summary for estimate")

        ucrInputReferenceSummary.AddToLinkedControls(ucrInputReferenceThreshold, {"Prop Above", "Prop Below", "Mean Above", "Mean Below"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMovingAverage.AddToLinkedControls(ucrInputN, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls({ucrNudHarmonics, ucrNudPeriod}, {"Fourier Series"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls(ucrNudSpan, {"LOESS"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls(ucrNudDf, {"Periodic Splines", "Natural Splines"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkOptionalSummary.AddToLinkedControls(ucrInputEstimateSummary, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputN.SetLinkedDisplayControl(lblN)
        ucrNudHarmonics.SetLinkedDisplayControl(lblHarmonics)
        ucrNudPeriod.SetLinkedDisplayControl(lblPeriod)
        ucrNudSpan.SetLinkedDisplayControl(lblSpan)
        ucrNudDf.SetLinkedDisplayControl(lblDf)
        ucrInputEstimateSummary.SetLinkedDisplayControl(ucrInputEstimateThreshold)

        ucrChkPoints.SetText("Points")
        ucrChkPoints.AddParameterPresentCondition(True, "geom_point")
        ucrChkPoints.AddParameterPresentCondition(False, "geom_point", False)

        ucrChkMovingAverage.SetText("Moving average")
        ucrChkMovingAverage.AddParameterPresentCondition(True, "moving_mutate")
        ucrChkMovingAverage.AddParameterPresentCondition(False, "moving_mutate", False)

        ucrSaveGraph.SetPrefix("seasonalityplot")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorSeasonalityComparisons.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputSmoothing.SetItems({"Fourier Series", "Periodic Splines", "Natural Splines", "LOESS"})
        ucrInputSmoothing.SetDropDownStyleAsNonEditable()

        ucrNudSpan.SetParameter(New RParameter("span", 4))
        ucrNudSpan.DecimalPlaces = 2
        ucrNudSpan.Increment = 0.05
        ucrNudSpan.SetMinMax(0, Integer.MaxValue)

        ucrNudDf.SetParameter(New RParameter("df", 1))
        ucrNudDf.SetMinMax(1, Integer.MaxValue)

        ucrNudHarmonics.SetParameter(New RParameter("n", 1))
        ucrNudHarmonics.SetMinMax(1, Integer.MaxValue)

        ucrNudPeriod.SetParameter(New RParameter("period", 2))
        ucrNudPeriod.SetMinMax(1, Integer.MaxValue)
    End Sub

    Private Sub SetDefaults()
        clsPipeOperator = New ROperator
        clsAndOperator = New ROperator
        clsRefGreaterOperator = New ROperator
        clsEst1GreaterOperator = New ROperator
        clsRefLessOperator = New ROperator
        clsEst1LessOperator = New ROperator
        clsDivideOperator = New ROperator
        clsLessOperator = New ROperator
        clsGreaterOperator = New ROperator
        clsEst2GreaterOperator = New ROperator
        clsEst2LessOperator = New ROperator

        clsPlusOperator = New ROperator
        clsFacetWrapTildeOperator = New ROperator
        clsPbsSplinesTildeOperator = New ROperator

        clsMissingFilterFunction = New RFunction
        clsRefIsNotNaFunction = New RFunction
        clsEstIsNotNaFunction = New RFunction
        clsMutateFunction = New RFunction
        clsPivotLongerFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsSummariseFunction = New RFunction
        clsMovingMutateFunction = New RFunction
        clsMovingFunction = New RFunction
        clsNSumFunction = New RFunction
        clsPropSumFunction = New RFunction
        clsNotIsNaThreshFunction = New RFunction
        clsMeanFunction = New RFunction
        clsMeanFilterFunction = New RFunction
        clsStdFunction = New RFunction

        clsGgplotFunction = New RFunction
        clsGeomPointFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsGeomSmoothFunction = New RFunction
        clsGgPlotAesFunction = New RFunction
        clsGeomLineAesFunction = New RFunction
        clsFacetWrapFunction = New RFunction
        clsAsFormulaFunction = New RFunction
        clsPasteFunction = New RFunction
        clsFourierSeriesFunction = New RFunction
        clsListFunction = New RFunction
        clsBinomialFunction = New RFunction
        clsPbsFunction = New RFunction
        clsNsFunction = New RFunction
        clsYlabFunction = New RFunction

        ucrSelectorSeasonalityComparisons.Reset()
        ucrReceiverReference.SetMeAsReceiver()
        ucrInputEstimateSummary.cboInput.SelectedItem = "Prop Above"
        ucrInputReferenceSummary.cboInput.SelectedItem = "Mean"
        ucrInputSmoothing.cboInput.SelectedItem = "Fourier Series"

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsMissingFilterFunction, iPosition:=1)
        clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=2)
        clsPipeOperator.AddParameter("pivot_longer", clsRFunctionParameter:=clsPivotLongerFunction, iPosition:=3)
        clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=5)
        clsPipeOperator.AddParameter("summarise", clsRFunctionParameter:=clsSummariseFunction, iPosition:=6)
        clsPipeOperator.AddParameter("moving_mutate", clsRFunctionParameter:=clsMovingMutateFunction, iPosition:=7)
        clsPipeOperator.AddParameter("ggplot", clsROperatorParameter:=clsPlusOperator, iPosition:=8)


        clsAndOperator.SetOperation("&")
        clsAndOperator.AddParameter("ref", clsRFunctionParameter:=clsRefIsNotNaFunction, iPosition:=0)
        clsAndOperator.AddParameter("est", clsRFunctionParameter:=clsEstIsNotNaFunction, iPosition:=1)

        clsRefGreaterOperator.SetOperation(">")
        clsRefGreaterOperator.AddParameter("value", 0.85, iPosition:=1)

        clsEst1GreaterOperator.SetOperation(">")
        clsEst1GreaterOperator.AddParameter("value", 0.85, iPosition:=1)

        clsRefLessOperator.SetOperation("<")

        clsEst1LessOperator.SetOperation("<")

        clsDivideOperator.SetOperation("/")
        clsDivideOperator.bSpaceAroundOperation = False
        clsDivideOperator.AddParameter("sum", clsRFunctionParameter:=clsPropSumFunction, iPosition:=0)
        clsDivideOperator.AddParameter("n", "n", iPosition:=1)

        clsMissingFilterFunction.SetPackageName("dplyr")
        clsMissingFilterFunction.SetRCommand("filter")
        clsMissingFilterFunction.AddParameter("and", clsROperatorParameter:=clsAndOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsRefIsNotNaFunction.SetRCommand("!is.na")

        clsEstIsNotNaFunction.SetRCommand("!is.na")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefGreaterOperator, iPosition:=0)
        clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEst1GreaterOperator, iPosition:=1)

        clsPivotLongerFunction.SetPackageName("tidyr")
        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.AddParameter("cols", "c(" & "reference" & "," & "estimate" & ")", iPosition:=0)
        clsPivotLongerFunction.AddParameter("names_to", Chr(34) & "data" & Chr(34), iPosition:=1)
        clsPivotLongerFunction.AddParameter("values_to", Chr(34) & "value" & Chr(34), iPosition:=2)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")
        clsGroupByFunction.AddParameter("data", "data", bIncludeArgumentName:=False, iPosition:=1)

        clsSummariseFunction.SetPackageName("dplyr")
        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter("n", clsRFunctionParameter:=clsNSumFunction, iPosition:=0)
        clsSummariseFunction.AddParameter("calc_summary", clsROperatorParameter:=clsDivideOperator, iPosition:=1)

        clsMovingMutateFunction.SetPackageName("dplyr")
        clsMovingMutateFunction.SetRCommand("mutate")
        clsMovingMutateFunction.AddParameter("moving", clsRFunctionParameter:=clsMovingFunction, iPosition:=0)

        clsMovingFunction.SetPackageName("raster")
        clsMovingFunction.SetRCommand("movingFun")
        clsMovingFunction.AddParameter("calc_summary", "calc_summary", bIncludeArgumentName:=False, iPosition:=0)
        clsMovingFunction.AddParameter("n", 5, iPosition:=1)
        clsMovingFunction.AddParameter("circular", "TRUE", iPosition:=2)
        clsMovingFunction.AddParameter("na.rm", "TRUE", iPosition:=3)

        clsNSumFunction.SetRCommand("sum")
        clsNSumFunction.AddParameter("sum", clsRFunctionParameter:=clsNotIsNaThreshFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPropSumFunction.SetRCommand("sum")
        clsPropSumFunction.AddParameter("value", "value", bIncludeArgumentName:=False, iPosition:=0)
        clsPropSumFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsNotIsNaThreshFunction.SetRCommand("!is.na")
        clsNotIsNaThreshFunction.AddParameter("value", "value", bIncludeArgumentName:=False, iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("value", "value", bIncludeArgumentName:=False, iPosition:=0)
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsMeanFilterFunction.SetPackageName("dplyr")
        clsMeanFilterFunction.SetRCommand("filter")

        clsLessOperator.SetOperation("<")
        clsLessOperator.AddParameter("0", "value", iPosition:=0)

        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("1", "value", iPosition:=0)

        clsEst2GreaterOperator.SetOperation(">")

        clsEst2LessOperator.SetOperation("<")

        clsStdFunction.SetRCommand("sd")
        clsStdFunction.AddParameter("value", "value", bIncludeArgumentName:=False, iPosition:=0)
        clsStdFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        'ggplot functions + operators
        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgPlotAesFunction, iPosition:=0)

        clsPlusOperator.SetOperation("+")
        clsPlusOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsPlusOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineFunction, iPosition:=2)
        clsPlusOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsGeomSmoothFunction, iPosition:=3)
        clsPlusOperator.AddParameter("ylab", clsRFunctionParameter:=clsYlabFunction, iPosition:=4)

        clsFacetWrapTildeOperator.SetOperation("~")
        clsFacetWrapTildeOperator.AddParameter("", "", iPosition:=0)

        clsPbsSplinesTildeOperator.SetOperation("~")
        clsPbsSplinesTildeOperator.AddParameter("y", "y", iPosition:=0)

        clsGeomPointFunction.SetPackageName("ggplot2")
        clsGeomPointFunction.SetRCommand("geom_point")

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")
        clsGeomLineFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomLineAesFunction, iPosition:=0)

        clsGeomSmoothFunction.SetPackageName("ggplot2")
        clsGeomSmoothFunction.SetRCommand("geom_smooth")
        clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsGeomSmoothFunction.AddParameter("se", "FALSE", iPosition:=3)
        clsGeomSmoothFunction.AddParameter("span", 0.5, iPosition:=4)

        clsGgPlotAesFunction.SetPackageName("ggplot2")
        clsGgPlotAesFunction.SetRCommand("aes")
        clsGgPlotAesFunction.AddParameter("y", "calc_summary", iPosition:=1)
        clsGgPlotAesFunction.AddParameter("colour", "data", iPosition:=2)
        clsGgPlotAesFunction.AddParameter("weight", "n", iPosition:=3)

        clsGeomLineAesFunction.SetPackageName("ggplot2")
        clsGeomLineAesFunction.SetRCommand("aes")

        clsFacetWrapFunction.SetPackageName("ggplot2")
        clsFacetWrapFunction.SetRCommand("facet_wrap")
        clsFacetWrapFunction.AddParameter("tilde", clsROperatorParameter:=clsFacetWrapTildeOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsAsFormulaFunction.SetRCommand("as.formula")
        clsAsFormulaFunction.AddParameter("paste", clsRFunctionParameter:=clsPasteFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPasteFunction.SetRCommand("paste")
        clsPasteFunction.AddParameter("y", Chr(34) & "y~" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteFunction.AddParameter("fourier", clsRFunctionParameter:=clsFourierSeriesFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsFourierSeriesFunction.SetRCommand("fourier_series")
        clsFourierSeriesFunction.AddParameter("x", Chr(34) & "x" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsFourierSeriesFunction.AddParameter("n", 3, iPosition:=1)
        clsFourierSeriesFunction.AddParameter("period", 366, iPosition:=2)

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("binomial", clsRFunctionParameter:=clsBinomialFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsBinomialFunction.SetRCommand("binomial")
        clsBinomialFunction.AddParameter("link", Chr(34) & "logit" & Chr(34), iPosition:=0)

        clsPbsFunction.SetPackageName("pbs")
        clsPbsFunction.SetRCommand("pbs")
        clsPbsFunction.AddParameter("df", 6, iPosition:=1)

        clsNsFunction.SetPackageName("splines")
        clsNsFunction.SetRCommand("ns")
        clsNsFunction.AddParameter("x", "x", bIncludeArgumentName:=False, iPosition:=0)
        clsNsFunction.AddParameter("df", 6, iPosition:=1)

        clsYlabFunction.SetPackageName("ggplot2")
        clsYlabFunction.SetRCommand("ylab")

        clsPipeOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorSeasonalityComparisons.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefGreaterOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=2)

        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEst1GreaterOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEst1LessOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=2)
        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEst2GreaterOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=3)
        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEst2LessOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=4)

        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=1)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsLessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=2)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsGreaterOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=3)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsEst2GreaterOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=4)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsEst2LessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=5)

        ucrInputEstimateThreshold.AddAdditionalCodeParameterPair(clsEst1LessOperator, ucrInputEstimateThreshold.GetParameter, iAdditionalPairNo:=1)

        ucrReceiverSeasonality.AddAdditionalCodeParameterPair(clsGgPlotAesFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverStation.AddAdditionalCodeParameterPair(clsFacetWrapTildeOperator, New RParameter("station", 1), iAdditionalPairNo:=1)

        ucrNudDf.AddAdditionalCodeParameterPair(clsPbsFunction, ucrNudDf.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorSeasonalityComparisons.SetRCode(clsPipeOperator, bReset)
        ucrReceiverEstimate.SetRCode(clsEstIsNotNaFunction, bReset)
        ucrReceiverReference.SetRCode(clsRefIsNotNaFunction, bReset)
        ucrInputReferenceThreshold.SetRCode(clsRefGreaterOperator, bReset)
        ucrInputEstimateThreshold.SetRCode(clsEst1GreaterOperator, bReset)
        ucrReceiverStation.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSeasonality.SetRCode(clsGroupByFunction, bReset)
        ucrInputN.SetRCode(clsMovingFunction, bReset)
        ucrChkRemoveMissing.SetRCode(clsPipeOperator, bReset)
        ucrChkMovingAverage.SetRCode(clsPipeOperator, bReset)
        ucrChkPoints.SetRCode(clsPlusOperator, bReset)
        ucrSaveGraph.SetRCode(clsPipeOperator, bReset)
        ucrNudSpan.SetRCode(clsGeomSmoothFunction, bReset)
        ucrNudDf.SetRCode(clsNsFunction, bReset)
        ucrNudHarmonics.SetRCode(clsFourierSeriesFunction, bReset)
        ucrNudPeriod.SetRCode(clsFourierSeriesFunction, bReset)
        ucrChkOptionalSummary.SetRCode(clsEst1GreaterOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverReference.IsEmpty OrElse ucrReceiverEstimate.IsEmpty OrElse ucrReceiverSeasonality.IsEmpty OrElse (ucrChkMovingAverage.Checked AndAlso ucrInputN.IsEmpty) OrElse ((ucrInputReferenceSummary.GetText = "Prop Above" OrElse ucrInputReferenceSummary.GetText = "Prop Below") AndAlso ucrInputReferenceThreshold.IsEmpty) OrElse (ucrChkOptionalSummary.Checked AndAlso (ucrInputEstimateSummary.GetText = "Prop Above" OrElse ucrInputEstimateSummary.GetText = "Prop Below") AndAlso ucrInputEstimateThreshold.IsEmpty) OrElse Not ucrSaveGraph.IsComplete OrElse (ucrInputSmoothing.GetText = "Fourier Series" AndAlso (ucrNudHarmonics.GetText = "" OrElse ucrNudPeriod.GetText = "")) OrElse (ucrInputSmoothing.GetText = "LOESS" AndAlso ucrNudSpan.GetText = "") OrElse ((ucrInputSmoothing.GetText = "Periodic Splines" OrElse ucrInputSmoothing.GetText = "Natural Splines") AndAlso ucrNudDf.GetText = "") Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub UpdateSummaryParameters()
        Select Case ucrInputReferenceSummary.GetText
            Case "Prop Above"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefGreaterOperator, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEst2GreaterOperator, iPosition:=1)
                clsSummariseFunction.AddParameter("calc_summary", clsROperatorParameter:=clsDivideOperator, iPosition:=3)
            Case "Prop Below"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefLessOperator, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEst2LessOperator, iPosition:=1)
                clsSummariseFunction.AddParameter("calc_summary", clsROperatorParameter:=clsDivideOperator, iPosition:=3)
            Case "Mean"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter("reference", clsRFunctionParameter:=ucrReceiverReference.GetVariables, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsRFunctionParameter:=ucrReceiverEstimate.GetVariables, iPosition:=1)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Mean Above"
                clsMutateFunction.AddParameter("reference", clsRFunctionParameter:=ucrReceiverReference.GetVariables, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsRFunctionParameter:=ucrReceiverEstimate.GetVariables, iPosition:=1)
                clsMeanFilterFunction.AddParameter("operator", clsROperatorParameter:=clsGreaterOperator, bIncludeArgumentName:=False, iPosition:=0)
                clsPipeOperator.AddParameter("filter2", clsRFunctionParameter:=clsMeanFilterFunction, iPosition:=4)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Mean Below"
                clsMutateFunction.AddParameter("reference", clsRFunctionParameter:=ucrReceiverReference.GetVariables, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsRFunctionParameter:=ucrReceiverEstimate.GetVariables, iPosition:=1)
                clsMeanFilterFunction.AddParameter("operator", clsROperatorParameter:=clsLessOperator, bIncludeArgumentName:=False, iPosition:=0)
                clsPipeOperator.AddParameter("filter2", clsRFunctionParameter:=clsMeanFilterFunction, iPosition:=4)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Std.dev"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter("reference", clsRFunctionParameter:=ucrReceiverReference.GetVariables, iPosition:=0)
                clsMutateFunction.AddParameter("estimate", clsRFunctionParameter:=ucrReceiverEstimate.GetVariables, iPosition:=1)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsStdFunction, iPosition:=3)
        End Select
    End Sub

    Private Sub ucrInputReferenceSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputReferenceSummary.ControlValueChanged, ucrReceiverReference.ControlValueChanged, ucrReceiverEstimate.ControlValueChanged, ucrInputSmoothing.ControlValueChanged
        UpdateSummaryParameters()
        Select Case ucrInputSmoothing.GetText
            Case "Fourier Series"
                clsGeomSmoothFunction.AddParameter("formula", clsRFunctionParameter:=clsAsFormulaFunction, iPosition:=1)
            Case "Periodic Splines"
                clsPbsSplinesTildeOperator.AddParameter("pbs", clsRFunctionParameter:=clsPbsFunction, iPosition:=1)
                clsPbsSplinesTildeOperator.RemoveParameterByName("ns")
                clsPbsSplinesTildeOperator.RemoveParameterByName("x")
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
            Case "Natural Splines"
                clsPbsSplinesTildeOperator.RemoveParameterByName("pbs")
                clsPbsSplinesTildeOperator.RemoveParameterByName("x")
                clsPbsSplinesTildeOperator.AddParameter("ns", clsRFunctionParameter:=clsNsFunction, iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
            Case "LOESS"
                clsPbsSplinesTildeOperator.RemoveParameterByName("pbs")
                clsPbsSplinesTildeOperator.RemoveParameterByName("ns")
                clsPbsSplinesTildeOperator.AddParameter("x", "x", iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
        End Select

        If ucrInputSmoothing.GetText = "LOESS" Then
            clsGeomSmoothFunction.AddParameter("method", Chr(34) & "loess" & Chr(34), iPosition:=0)
            clsGeomSmoothFunction.RemoveParameterByName("method.args")
        Else
            Select Case ucrInputReferenceSummary.GetText
                Case "Prop Above", "Prop Below"
                    clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
                    clsGeomSmoothFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
                    clsYlabFunction.AddParameter("label", "Prop")
                Case "Mean", "Mean Above", "Mean Below", "Std.dev"
                    clsGeomSmoothFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
                    clsGeomSmoothFunction.RemoveParameterByName("method.args")
                    clsYlabFunction.AddParameter("label", "Std.dev")
            End Select
        End If

        Select Case ucrInputReferenceSummary.GetText
            Case "Prop Above", "Prop Below"
                clsYlabFunction.AddParameter("label", Chr(34) & "Prop" & Chr(34))
            Case "Mean", "Mean Above", "Mean Below"
                clsYlabFunction.AddParameter("label", Chr(34) & "Mean" & Chr(34))
            Case "Std.dev"
                clsYlabFunction.AddParameter("label", Chr(34) & "Std.dev" & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputEstimateSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputEstimateSummary.ControlValueChanged, ucrReceiverReference.ControlValueChanged, ucrReceiverEstimate.ControlValueChanged, ucrChkOptionalSummary.ControlValueChanged
        If ucrChkOptionalSummary.Checked Then
            Select Case ucrInputEstimateSummary.GetText
                Case "Prop Above"
                    clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEst1GreaterOperator, iPosition:=1)
                Case "Prop Below"
                    clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEst1LessOperator, iPosition:=1)
            End Select
        Else
            UpdateSummaryParameters()
        End If
    End Sub

    Private Sub ucrChkRemoveMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRemoveMissing.ControlValueChanged
        If ucrChkRemoveMissing.Checked Then
            clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsMissingFilterFunction, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("filter")
        End If
    End Sub

    Private Sub ucrChkMovingAverage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMovingAverage.ControlValueChanged
        If ucrChkMovingAverage.Checked Then
            clsPipeOperator.AddParameter("moving_mutate", clsRFunctionParameter:=clsMovingMutateFunction, iPosition:=7)
            clsPlusOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineFunction, iPosition:=2)
            clsGeomLineAesFunction.AddParameter("y", "moving", iPosition:=0)
        Else
            clsPipeOperator.RemoveParameterByName("moving_mutate")
            clsPlusOperator.RemoveParameterByName("geom_line")
            clsGeomLineAesFunction.RemoveParameterByName("y")
        End If
    End Sub

    Private Sub ucrChkPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPoints.ControlValueChanged
        If ucrChkPoints.Checked Then
            clsPlusOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointFunction, iPosition:=1)
        Else
            clsPlusOperator.RemoveParameterByName("geom_point")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        If Not ucrReceiverStation.IsEmpty Then
            clsPlusOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsFacetWrapFunction, iPosition:=5)
        Else
            clsPlusOperator.RemoveParameterByName("facet_wrap")
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlContentsChanged, ucrReceiverEstimate.ControlContentsChanged, ucrReceiverSeasonality.ControlContentsChanged, ucrChkMovingAverage.ControlContentsChanged, ucrInputN.ControlContentsChanged, ucrInputReferenceSummary.ControlContentsChanged, ucrInputReferenceThreshold.ControlContentsChanged, ucrInputEstimateSummary.ControlContentsChanged, ucrInputEstimateThreshold.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrInputSmoothing.ControlContentsChanged, ucrNudHarmonics.ControlContentsChanged, ucrNudPeriod.ControlContentsChanged, ucrNudSpan.ControlContentsChanged, ucrNudDf.ControlContentsChanged, ucrChkOptionalSummary.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
