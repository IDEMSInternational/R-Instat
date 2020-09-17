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
    Private clsPipeOperator, clsAndOperator, clsRefGreaterOperator, clsEstGreaterOperator, clsRefLessOperator, clsEstLessOperator, clsDivideOperator As New ROperator
    Private clsFilterFunction, clsRefIsNotNaFunction, clsEstIsNotNaFunction, clsMutateFunction, clsPivotLongerFunction, clsGroupByFunction, clsSummariseFunction, clsMovingMutateFunction, clsMovingFunction, clsNSumFunction, clsPropSumFunction, clsNotIsNaThreshFunction, clsMeanFunction As New RFunction
    'ggplot functions + operators
    Private clsPlusOperator, clsFacetWrapTildeOperator, clsPbsSplinesTildeOperator As New ROperator
    Private clsGgplotFunction, clsGeomPointFunction, clsGeomLineFunction, clsGeomSmoothFunction, clsGgPlotAesFunction, clsGeomLineAesFunction, clsFacetWrapFunction, clsAsFormulaFunction, clsPasteFunction, clsFourierSeriesFunction, clsListFunction, clsBinomialFunction, clsPbsFunction, clsNsFunction As New RFunction

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

        ucrReceiverStation.SetParameter(New RParameter("station", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrInputReferenceSummary.SetItems({"Prop Above", "Prop Below", "Mean"})
        ucrInputReferenceSummary.SetDropDownStyleAsNonEditable()

        ucrInputEstimateSummary.SetItems({"Prop Above", "Prop Below", "Mean"})
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

        ucrInputReferenceSummary.AddToLinkedControls(ucrInputReferenceThreshold, {"Prop Above", "Prop Below"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputEstimateSummary.AddToLinkedControls(ucrInputEstimateThreshold, {"Prop Above", "Prop Below"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMovingAverage.AddToLinkedControls(ucrInputN, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls({ucrNudHarmonics, ucrNudPeriod}, {"Fourier Series"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls(ucrNudSpan, {"LOESS"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSmoothing.AddToLinkedControls(ucrNudDf, {"Periodic Splines", "Natural Splines"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputN.SetLinkedDisplayControl(lblN)
        ucrNudHarmonics.SetLinkedDisplayControl(lblHarmonics)
        ucrNudPeriod.SetLinkedDisplayControl(lblPeriod)
        ucrNudSpan.SetLinkedDisplayControl(lblSpan)
        ucrNudDf.SetLinkedDisplayControl(lblDf)

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
        clsEstGreaterOperator = New ROperator
        clsRefLessOperator = New ROperator
        clsEstLessOperator = New ROperator
        clsDivideOperator = New ROperator

        clsFacetWrapTildeOperator = New ROperator
        clsPbsSplinesTildeOperator = New ROperator

        clsFilterFunction = New RFunction
        clsRefIsNotNaFunction = New RFunction
        clsEstIsNotNaFunction = New RFunction
        clsMutateFunction = New RFunction
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

        ucrSelectorSeasonalityComparisons.Reset()
        ucrReceiverReference.SetMeAsReceiver()
        ucrInputEstimateSummary.cboInput.SelectedItem = "Prop Above"
        ucrInputReferenceSummary.cboInput.SelectedItem = "Prop Above"
        ucrInputSmoothing.cboInput.SelectedItem = "Fourier Series"

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterFunction, iPosition:=1)
        clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=2)
        clsPipeOperator.AddParameter("pivot_longer", clsRFunctionParameter:=clsPivotLongerFunction, iPosition:=3)
        clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=4)
        clsPipeOperator.AddParameter("summarise", clsRFunctionParameter:=clsSummariseFunction, iPosition:=5)
        clsPipeOperator.AddParameter("moving_mutate", clsRFunctionParameter:=clsMovingMutateFunction, iPosition:=6)
        clsPipeOperator.AddParameter("ggplot", clsROperatorParameter:=clsPlusOperator, iPosition:=7)


        clsAndOperator.SetOperation("&")
        clsAndOperator.AddParameter("ref", clsRFunctionParameter:=clsRefIsNotNaFunction, iPosition:=0)
        clsAndOperator.AddParameter("est", clsRFunctionParameter:=clsEstIsNotNaFunction, iPosition:=1)

        clsRefGreaterOperator.SetOperation(">")
        clsRefGreaterOperator.AddParameter("value", 0.85, iPosition:=1)

        clsEstGreaterOperator.SetOperation(">")
        clsEstGreaterOperator.AddParameter("value", 0.85, iPosition:=1)

        clsRefLessOperator.SetOperation("<")

        clsEstLessOperator.SetOperation("<")

        clsDivideOperator.SetOperation("/")
        clsDivideOperator.bSpaceAroundOperation = False
        clsDivideOperator.AddParameter("sum", clsRFunctionParameter:=clsPropSumFunction, iPosition:=0)
        clsDivideOperator.AddParameter("n", "n", iPosition:=1)

        clsFilterFunction.SetPackageName("dplyr")
        clsFilterFunction.SetRCommand("filter")
        clsFilterFunction.AddParameter("and", clsROperatorParameter:=clsAndOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsRefIsNotNaFunction.SetRCommand("!is.na")

        clsEstIsNotNaFunction.SetRCommand("!is.na")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefGreaterOperator, iPosition:=0)
        clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEstGreaterOperator, iPosition:=1)


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

        'ggplot functions + operators
        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgPlotAesFunction, iPosition:=0)

        clsPlusOperator.SetOperation("+")
        clsPlusOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsPlusOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsGeomSmoothFunction, iPosition:=3)

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
        clsGeomLineAesFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsGeomSmoothFunction.AddParameter("se", "FALSE", iPosition:=3)

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
        clsPbsFunction.AddParameter("x", "x", bIncludeArgumentName:=False, iPosition:=0)

        clsNsFunction.SetPackageName("splines")
        clsNsFunction.SetRCommand("ns")
        clsNsFunction.AddParameter("x", "x", bIncludeArgumentName:=False, iPosition:=0)

        clsPipeOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorSeasonalityComparisons.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefGreaterOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=2)

        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEstGreaterOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverEstimate.AddAdditionalCodeParameterPair(clsEstLessOperator, ucrReceiverEstimate.GetParameter, iAdditionalPairNo:=2)

        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=1)

        ucrInputEstimateThreshold.AddAdditionalCodeParameterPair(clsEstLessOperator, ucrInputEstimateThreshold.GetParameter, iAdditionalPairNo:=1)

        ucrReceiverSeasonality.AddAdditionalCodeParameterPair(clsGgPlotAesFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverStation.AddAdditionalCodeParameterPair(clsFacetWrapTildeOperator, New RParameter("station", 1), iAdditionalPairNo:=1)

        ucrNudDf.AddAdditionalCodeParameterPair(clsPbsFunction, ucrNudDf.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorSeasonalityComparisons.SetRCode(clsPipeOperator, bReset)
        ucrReceiverEstimate.SetRCode(clsEstIsNotNaFunction, bReset)
        ucrReceiverReference.SetRCode(clsRefIsNotNaFunction, bReset)
        ucrInputReferenceThreshold.SetRCode(clsRefGreaterOperator, bReset)
        ucrInputEstimateThreshold.SetRCode(clsEstGreaterOperator, bReset)
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
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverReference.IsEmpty OrElse ucrReceiverEstimate.IsEmpty OrElse ucrReceiverSeasonality.IsEmpty OrElse (ucrChkMovingAverage.Checked AndAlso ucrInputN.IsEmpty) OrElse ((ucrInputReferenceSummary.GetText = "Prop Above" OrElse ucrInputReferenceSummary.GetText = "Prop Below") AndAlso ucrInputReferenceThreshold.IsEmpty) OrElse ((ucrInputEstimateSummary.GetText = "Prop Above" OrElse ucrInputEstimateSummary.GetText = "Prop Below") AndAlso ucrInputEstimateThreshold.IsEmpty) OrElse Not ucrSaveGraph.IsComplete OrElse (ucrInputSmoothing.GetText = "Fourier Series" AndAlso (ucrNudHarmonics.GetText = "" OrElse ucrNudPeriod.GetText = "")) OrElse (ucrInputSmoothing.GetText = "LOESS" AndAlso ucrNudSpan.GetText = "") OrElse ((ucrInputSmoothing.GetText = "Periodic Splines" OrElse ucrInputSmoothing.GetText = "Natural Splines") AndAlso ucrNudDf.GetText = "") Then
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

    Private Sub ucrInputReferenceSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputReferenceSummary.ControlValueChanged, ucrReceiverReference.ControlValueChanged, ucrReceiverEstimate.ControlValueChanged
        Select Case ucrInputReferenceSummary.GetText
            Case "Prop Above"
                clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefGreaterOperator, iPosition:=0)
            Case "Prop Below"
                clsMutateFunction.AddParameter("reference", clsROperatorParameter:=clsRefLessOperator, iPosition:=0)
            Case "Mean"
                clsMutateFunction.AddParameter("reference", clsRFunctionParameter:=ucrReceiverReference.GetVariables, iPosition:=0)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
        End Select

    End Sub

    Private Sub ucrInputEstimateSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputEstimateSummary.ControlValueChanged, ucrReceiverReference.ControlValueChanged, ucrReceiverEstimate.ControlValueChanged
        Select Case ucrInputEstimateSummary.GetText
            Case "Prop Above"
                clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEstGreaterOperator, iPosition:=1)
            Case "Prop Below"
                clsMutateFunction.AddParameter("estimate", clsROperatorParameter:=clsEstLessOperator, iPosition:=1)
            Case "Mean"
                clsMutateFunction.AddParameter("estimate", clsRFunctionParameter:=ucrReceiverEstimate.GetVariables, iPosition:=1)
                clsSummariseFunction.AddParameter("calc_summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
        End Select
    End Sub

    Private Sub ucrChkRemoveMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRemoveMissing.ControlValueChanged
        If ucrChkRemoveMissing.Checked Then
            clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterFunction, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("filter")
        End If
    End Sub

    Private Sub ucrChkMovingAverage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMovingAverage.ControlValueChanged
        If ucrChkMovingAverage.Checked Then
            clsPipeOperator.AddParameter("moving_mutate", clsRFunctionParameter:=clsMovingMutateFunction, iPosition:=6)
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
            clsPlusOperator.RemoveParameterByName("ggplot")
        End If
    End Sub

    Private Sub ucrInputSmoothing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSmoothing.ControlValueChanged
        Select Case ucrInputSmoothing.GetText
            Case "Fourier Series"
                clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
                clsGeomLineAesFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
                clsGeomSmoothFunction.AddParameter("formula", clsRFunctionParameter:=clsAsFormulaFunction, iPosition:=1)
            Case "Periodic Splines"
                clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
                clsGeomLineAesFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
                clsPbsSplinesTildeOperator.AddParameter("pbs", clsRFunctionParameter:=clsPbsFunction, iPosition:=1)
                clsPbsSplinesTildeOperator.RemoveParameterByName("ns")
                clsPbsSplinesTildeOperator.RemoveParameterByName("x")
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
            Case "Natural Splines"
                clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
                clsGeomLineAesFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
                clsPbsSplinesTildeOperator.RemoveParameterByName("pbs")
                clsPbsSplinesTildeOperator.RemoveParameterByName("x")
                clsPbsSplinesTildeOperator.AddParameter("ns", clsRFunctionParameter:=clsNsFunction, iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
            Case "LOESS"
                clsGeomSmoothFunction.AddParameter("method", Chr(34) & "loess" & Chr(34), iPosition:=0)
                clsPbsSplinesTildeOperator.RemoveParameterByName("pbs")
                clsPbsSplinesTildeOperator.RemoveParameterByName("ns")
                clsPbsSplinesTildeOperator.AddParameter("x", "x", iPosition:=1)
                clsGeomSmoothFunction.RemoveParameterByName("method.args")
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsPbsSplinesTildeOperator, iPosition:=1)
        End Select

    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        If Not ucrReceiverStation.IsEmpty Then
            clsPlusOperator.AddParameter("facet_wrap", clsRFunctionParameter:=clsFacetWrapFunction, iPosition:=4)
        Else
            clsPlusOperator.RemoveParameterByName("facet_wrap")
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlContentsChanged, ucrReceiverEstimate.ControlContentsChanged, ucrReceiverSeasonality.ControlContentsChanged, ucrChkMovingAverage.ControlContentsChanged, ucrInputN.ControlContentsChanged, ucrInputReferenceSummary.ControlContentsChanged, ucrInputReferenceThreshold.ControlContentsChanged, ucrInputEstimateSummary.ControlContentsChanged, ucrInputEstimateThreshold.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrInputSmoothing.ControlContentsChanged, ucrNudHarmonics.ControlContentsChanged, ucrNudPeriod.ControlContentsChanged, ucrNudSpan.ControlContentsChanged, ucrNudDf.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
