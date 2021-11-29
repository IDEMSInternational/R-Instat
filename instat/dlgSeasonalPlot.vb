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
    ''' <summary> 
    ''' Dummy ROperator set to either clsRefGreaterOperator or clsRefLessOperator depending on 
    ''' summary option. This is used in SetRCode for ucrInputReferenceSummary. 
    ''' </summary>
    Private clsRefGreaterOrLessOperator As ROperator

    Private clsMissingFilterFunction As RFunction
    Private clsRefIsNotNaFunction As RFunction
    Private clsEstIsNotNaFunction As RFunction
    Private clsMutateFunction As RFunction
    Private clsPivotLongerFunction As RFunction
    Private clsPivotCFunction As RFunction
    Private clsPivotListFunction As RFunction
    Private clsPivotFactorFunction As RFunction
    Private clsPivotFactorLevelsCFunction As New RFunction
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
    Private clsTildeOperator As ROperator

    ''' <summary> Dummy RCodeStructure set to either clsAsFormulaFunction or clsTildeOperator depending on smoothing option. This is used in SetRCode for ucrInputSmoothing. </summary>
    Private clsFormulaRCode As RCodeStructure

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
        If bFirstLoad Then
            InitiliseDialog()
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

    Private Sub InitiliseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorSeasonalityComparisons.SetParameter(New RParameter("data", 0))
        ucrSelectorSeasonalityComparisons.SetParameterIsrfunction()

        ucrReceiverReference.SetParameter(New RParameter("x", 0))
        ucrReceiverReference.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverReference.SetParameterIsString()
        ucrReceiverReference.bWithQuotes = False
        ucrReceiverReference.SetDataType("numeric")
        ucrReceiverReference.strSelectorHeading = "Numerics"

        ucrReceiverEstimates.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimates.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.bWithQuotes = False
        ucrReceiverEstimates.SetDataType("numeric")
        ucrReceiverEstimates.strSelectorHeading = "Numerics"

        ucrReceiverSeasonality.SetParameter(New RParameter("seasonality", 2, bNewIncludeArgumentName:=False))
        ucrReceiverSeasonality.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverSeasonality.SetParameterIsString()
        ucrReceiverSeasonality.bWithQuotes = False
        ucrReceiverSeasonality.SetClimaticType("doy")
        ucrReceiverSeasonality.bAutoFill = True
        ' Lines don't appear if x is not numeric. 
        ' DP: I thought it can work with x as a factor so this could be TODO
        ucrReceiverSeasonality.SetDataType("numeric")
        ucrReceiverSeasonality.strSelectorHeading = "Numerics"

        ucrReceiverStation.SetParameter(New RParameter("station", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorSeasonalityComparisons
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetDataType("factor")
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrInputReferenceSummary.SetItems({"Mean", "Mean Above", "Mean Below", "Prop Above", "Prop Below", "Std.dev"})
        ucrInputReferenceSummary.SetDropDownStyleAsNonEditable()

        ucrInputEstimatesSummary.IsReadOnly = True

        ucrInputReferenceThreshold.SetParameter(New RParameter("value", 1))
        ucrInputReferenceThreshold.SetValidationTypeAsNumeric()
        ucrInputReferenceThreshold.AddQuotesIfUnrecognised = False

        ucrInputEstimatesThreshold.SetParameter(New RParameter("value", 1))
        ucrInputEstimatesThreshold.SetValidationTypeAsNumeric()
        ucrInputEstimatesThreshold.AddQuotesIfUnrecognised = False

        ucrInputN.SetParameter(New RParameter("n", 1))
        ucrInputN.SetValidationTypeAsNumeric()
        ucrInputN.AddQuotesIfUnrecognised = False

        ucrChkRemoveMissing.SetText("Remove rows with any missing values")
        ucrChkRemoveMissing.AddParameterPresentCondition(True, "filter")
        ucrChkRemoveMissing.AddParameterPresentCondition(False, "filter", False)

        ucrInputReferenceSummary.AddToLinkedControls(ucrInputReferenceThreshold, {"Prop Above", "Prop Below", "Mean Above", "Mean Below"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputReferenceSummary.AddToLinkedControls(ucrInputEstimatesThreshold, {"Prop Above", "Prop Below", "Mean Above", "Mean Below"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMovingAverage.AddToLinkedControls(ucrInputN, {True}, bNewLinkedHideIfParameterMissing:=True)
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

        ucrSaveGraph.SetPrefix("seasonality_plot")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorSeasonalityComparisons.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputSmoothing.SetItems({"Fourier Series", "Periodic Splines", "Natural Splines", "LOESS"})
        ucrInputSmoothing.SetDropDownStyleAsNonEditable()
        ucrInputSmoothing.AddRCodeIsRFunctionCondition("Fourier Series", bNewIsPositive:=True)
        ucrInputSmoothing.AddRCodeIsRFunctionCondition("Periodic Splines", bNewIsPositive:=False)
        ucrInputSmoothing.AddParameterValueFunctionNamesCondition("Periodic Splines", strParameterName:="1", strFunctionName:="pbs")
        ucrInputSmoothing.AddRCodeIsRFunctionCondition("Natural Splines", bNewIsPositive:=False)
        ucrInputSmoothing.AddParameterValueFunctionNamesCondition("Natural Splines", strParameterName:="1", strFunctionName:="ns")
        ucrInputSmoothing.AddRCodeIsRFunctionCondition("LOESS", bNewIsPositive:=False)
        ucrInputSmoothing.AddParameterIsStringCondition("LOESS", "1")

        ucrNudSpan.SetParameter(New RParameter("span", 4))
        ucrNudSpan.DecimalPlaces = 2
        ucrNudSpan.Increment = 0.05
        ucrNudSpan.SetRDefault(0.75)
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
        clsTildeOperator = New ROperator

        clsMissingFilterFunction = New RFunction
        clsRefIsNotNaFunction = New RFunction
        clsEstIsNotNaFunction = New RFunction
        clsMutateFunction = New RFunction
        clsPivotLongerFunction = New RFunction
        clsPivotCFunction = New RFunction
        clsPivotListFunction = New RFunction
        clsPivotFactorFunction = New RFunction
        clsPivotFactorLevelsCFunction = New RFunction
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

        clsFormulaRCode = New RCodeStructure

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
        ' Need to reset so that bUserTyped is reset to False
        ucrInputEstimatesThreshold.Reset()

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsMissingFilterFunction, iPosition:=1)
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
        clsMutateFunction.AddParameter("reference", ucrReceiverReference.GetVariableNames(False), iPosition:=0)
        clsMutateFunction.AddParameter("estimates", ucrReceiverEstimates.GetVariableNames(False), iPosition:=1)

        clsPivotLongerFunction.SetPackageName("tidyr")
        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.AddParameter("cols", clsRFunctionParameter:=clsPivotCFunction, iPosition:=0)
        clsPivotLongerFunction.AddParameter("names_to", Chr(34) & "data" & Chr(34), iPosition:=1)
        clsPivotLongerFunction.AddParameter("values_to", Chr(34) & "value" & Chr(34), iPosition:=2)
        clsPivotLongerFunction.AddParameter("names_ptypes", clsRFunctionParameter:=clsPivotListFunction, iPosition:=6)

        clsPivotCFunction.SetRCommand("c")

        clsPivotListFunction.SetRCommand("list")
        clsPivotListFunction.AddParameter("data", clsRFunctionParameter:=clsPivotFactorFunction, iPosition:=0)

        clsPivotFactorFunction.SetRCommand("factor")
        clsPivotFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsPivotFactorLevelsCFunction, iPosition:=1)

        clsPivotFactorLevelsCFunction.SetRCommand("c")

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")
        clsGroupByFunction.AddParameter("data", "data", bIncludeArgumentName:=False, iPosition:=1)

        clsSummariseFunction.SetPackageName("dplyr")
        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter("n", clsRFunctionParameter:=clsNSumFunction, iPosition:=0)
        clsSummariseFunction.AddParameter("summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=1)

        clsMovingMutateFunction.SetPackageName("dplyr")
        clsMovingMutateFunction.SetRCommand("mutate")
        clsMovingMutateFunction.AddParameter("moving", clsRFunctionParameter:=clsMovingFunction, iPosition:=0)

        clsMovingFunction.SetPackageName("raster")
        clsMovingFunction.SetRCommand("movingFun")
        clsMovingFunction.AddParameter("summary", "summary", bIncludeArgumentName:=False, iPosition:=0)
        clsMovingFunction.AddParameter("n", 5, iPosition:=1)
        clsMovingFunction.AddParameter("circular", "TRUE", iPosition:=2)
        clsMovingFunction.AddParameter("na.rm", "TRUE", iPosition:=3)

        clsNSumFunction.SetRCommand("sum")
        clsNSumFunction.AddParameter("x", clsRFunctionParameter:=clsNotIsNaThreshFunction, iPosition:=0)

        clsPropSumFunction.SetRCommand("sum")
        clsPropSumFunction.AddParameter("x", "value", iPosition:=0)
        clsPropSumFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsNotIsNaThreshFunction.SetRCommand("!is.na")
        clsNotIsNaThreshFunction.AddParameter("x", "value", iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("x", "value", iPosition:=0)
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
        clsStdFunction.AddParameter("x", "value", iPosition:=0)
        clsStdFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        ' Set to clsAsFormulaFunction by default since "Fourier Series" is the default.
        clsFormulaRCode = clsAsFormulaFunction

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
        clsFacetWrapTildeOperator.bForceIncludeOperation = True

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("0", "y", iPosition:=0)

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
        clsGgPlotAesFunction.AddParameter("y", "summary", iPosition:=1)
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefGreaterOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrReceiverReference.GetParameter, iAdditionalPairNo:=2)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("0", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsEst1GreaterOperator, ucrReceiverEstimates.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsEst1LessOperator, ucrReceiverEstimates.GetParameter, iAdditionalPairNo:=2)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsEst2GreaterOperator, ucrReceiverEstimates.GetParameter, iAdditionalPairNo:=3)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsEst2LessOperator, ucrReceiverEstimates.GetParameter, iAdditionalPairNo:=4)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("1", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)

        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsRefLessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=1)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsLessOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=2)
        ucrInputReferenceThreshold.AddAdditionalCodeParameterPair(clsGreaterOperator, ucrInputReferenceThreshold.GetParameter, iAdditionalPairNo:=3)

        ucrInputEstimatesThreshold.AddAdditionalCodeParameterPair(clsEst1LessOperator, ucrInputEstimatesThreshold.GetParameter, iAdditionalPairNo:=1)
        ucrInputEstimatesThreshold.AddAdditionalCodeParameterPair(clsEst2GreaterOperator, ucrInputEstimatesThreshold.GetParameter, iAdditionalPairNo:=2)
        ucrInputEstimatesThreshold.AddAdditionalCodeParameterPair(clsEst2LessOperator, ucrInputEstimatesThreshold.GetParameter, iAdditionalPairNo:=3)

        ucrReceiverSeasonality.AddAdditionalCodeParameterPair(clsGgPlotAesFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverStation.AddAdditionalCodeParameterPair(clsFacetWrapTildeOperator, New RParameter("station", 1), iAdditionalPairNo:=1)

        ucrNudDf.AddAdditionalCodeParameterPair(clsPbsFunction, ucrNudDf.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorSeasonalityComparisons.SetRCode(clsPipeOperator, bReset)
        ucrReceiverEstimates.SetRCode(clsEstIsNotNaFunction, bReset)
        ucrReceiverReference.SetRCode(clsRefIsNotNaFunction, bReset)
        ucrInputReferenceThreshold.SetRCode(clsRefGreaterOperator, bReset)
        ucrInputEstimatesThreshold.SetRCode(clsEst1GreaterOperator, bReset)
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
        ucrInputSmoothing.SetRCode(clsFormulaRCode, bReset)
        ' Cannot easily set R code using conditions because checks on multiple functions is needed hence done "manually" in this sub.
        ReferenceSummarySetRCode(bReset)
    End Sub

    ''' <summary>
    ''' Sets the R Code for ucrInputReferenceSummary. This is done manually by this sub instead of 
    ''' through conditions because of the complex checks on multiple functions required.
    ''' </summary>
    ''' <param name="bReset">True if the dialog is being reset.</param>
    Private Sub ReferenceSummarySetRCode(bReset As Boolean)
        Dim clsTempParam As RParameter
        Dim clsTempRFunc As RFunction
        Dim strReferenceName As String = ""
        Dim strEstimatesName As String = ""

        strReferenceName = ucrReceiverReference.GetVariableNames(False)
        strEstimatesName = ucrReceiverEstimates.GetVariableNames(False)

        ' Used to return a developer error if R Code cannot be set.
        Dim ReferenceSummaryDevError = Sub()
                                           MsgBox("Developer error: in " & ucrInputReferenceSummary.Name & ". Cannot determine how to set the control from the RCode. Modify conditions so that only one state can satisfy its conditions.")
                                       End Sub

        ' mutate is used in clsPipeOperator to calculate proportions for "Prop Above" and "Prop Below" summaries
        If clsPipeOperator.ContainsParameter("mutate") Then
            ' If the "reference" parameter in clsMutateFunction has clsRefGreaterOperator as its value then the summary is "Prop Above"
            ' clsRefGreaterOrLessOperator is the reference parameter in clsMutateFunction
            If clsRefGreaterOrLessOperator IsNot Nothing AndAlso clsRefGreaterOrLessOperator.Equals(clsRefGreaterOperator) Then
                ucrInputReferenceSummary.SetName("Prop Above")
            ElseIf clsRefGreaterOrLessOperator IsNot Nothing AndAlso clsRefGreaterOrLessOperator.Equals(clsRefLessOperator) Then
                ucrInputReferenceSummary.SetName("Prop Below")
            Else
                ReferenceSummaryDevError()
            End If
            ' filter2 is used in clsPipeOperator to filter the data to for "Mean Above" or "Mean Below" summaries
        ElseIf clsPipeOperator.ContainsParameter("filter2") Then
            ' If clsMeanFilterFunction contains an "operator" parameter and its value is clsGreaterOperator then the summary is "Mean Above"
            If clsMeanFilterFunction.ContainsParameter("operator") AndAlso clsMeanFilterFunction.GetParameter("operator").clsArgumentCodeStructure IsNot Nothing AndAlso clsMeanFilterFunction.GetParameter("operator").clsArgumentCodeStructure.Equals(clsGreaterOperator) Then
                ucrInputReferenceSummary.SetName("Mean Above")
                ' If clsMeanFilterFunction contains an "operator" parameter and its value is clsLessOperator then the summary is "Mean Below"
            ElseIf clsMeanFilterFunction.ContainsParameter("operator") AndAlso clsMeanFilterFunction.GetParameter("operator").clsArgumentCodeStructure IsNot Nothing AndAlso clsMeanFilterFunction.GetParameter("operator").clsArgumentCodeStructure.Equals(clsLessOperator) Then
                ucrInputReferenceSummary.SetName("Mean Below")
            Else
                ReferenceSummaryDevError()
            End If
            ' If filter2 is not in clsPipeOperator then the summary is either "Mean" or "Std.dev" and can be determined by the "summary" parameter in clsSummariseFunction
        ElseIf clsSummariseFunction.ContainsParameter("summary") Then
            clsTempParam = clsSummariseFunction.GetParameter("summary")
            clsTempRFunc = TryCast(clsTempParam.clsArgumentCodeStructure, RFunction)
            ' If "summary" parameter contains an RFunction then it is either for "Mean" or "Std.dev"
            ' Check the name of the RFunction to confirm which one.
            If clsTempRFunc IsNot Nothing Then
                If clsTempRFunc.strRCommand = "mean" Then
                    ucrInputReferenceSummary.SetName("Mean")
                ElseIf clsTempRFunc.strRCommand = "sd" Then
                    ucrInputReferenceSummary.SetName("Std.dev")
                Else
                    ReferenceSummaryDevError()
                End If
            Else
                ReferenceSummaryDevError()
            End If
        Else
            ReferenceSummaryDevError()
        End If
        ucrInputReferenceSummary.UpdateLinkedControls(bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverReference.IsEmpty OrElse ucrReceiverEstimates.IsEmpty OrElse ucrReceiverSeasonality.IsEmpty OrElse (ucrChkMovingAverage.Checked AndAlso ucrInputN.IsEmpty) OrElse ((ucrInputReferenceSummary.GetText = "Prop Above" OrElse ucrInputReferenceSummary.GetText = "Prop Below" OrElse ucrInputReferenceSummary.GetText = "Mean Above" OrElse ucrInputReferenceSummary.GetText = "Mean Below") AndAlso ucrInputReferenceThreshold.IsEmpty) OrElse ((ucrInputEstimatesSummary.GetText = "Prop Above" OrElse ucrInputEstimatesSummary.GetText = "Prop Below" OrElse ucrInputEstimatesSummary.GetText = "Mean Above" OrElse ucrInputEstimatesSummary.GetText = "Mean Below") AndAlso ucrInputEstimatesThreshold.IsEmpty) OrElse Not ucrSaveGraph.IsComplete OrElse (ucrInputSmoothing.GetText = "Fourier Series" AndAlso (ucrNudHarmonics.GetText = "" OrElse ucrNudPeriod.GetText = "")) OrElse (ucrInputSmoothing.GetText = "LOESS" AndAlso ucrNudSpan.GetText = "") OrElse ((ucrInputSmoothing.GetText = "Periodic Splines" OrElse ucrInputSmoothing.GetText = "Natural Splines") AndAlso ucrNudDf.GetText = "") Then
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

    Private Sub UpdateSummaryParameters()
        Dim strReferenceName As String
        Dim strEstimatesName As String

        strReferenceName = ucrReceiverReference.GetVariableNames(False)
        strEstimatesName = ucrReceiverEstimates.GetVariableNames(False)

        If clsMutateFunction IsNot Nothing Then
            clsMutateFunction.ClearParameters()
        End If
        Select Case ucrInputReferenceSummary.GetText
            Case "Prop Above"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter(strReferenceName, clsROperatorParameter:=clsRefGreaterOperator, iPosition:=0)
                clsMutateFunction.AddParameter(strEstimatesName, clsROperatorParameter:=clsEst2GreaterOperator, iPosition:=1)
                clsSummariseFunction.AddParameter("summary", clsROperatorParameter:=clsDivideOperator, iPosition:=3)
                clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=2)
                clsRefGreaterOrLessOperator = clsRefGreaterOperator
            Case "Prop Below"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsMutateFunction.AddParameter(strReferenceName, clsROperatorParameter:=clsRefLessOperator, iPosition:=0)
                clsMutateFunction.AddParameter(strEstimatesName, clsROperatorParameter:=clsEst2LessOperator, iPosition:=1)
                clsSummariseFunction.AddParameter("summary", clsROperatorParameter:=clsDivideOperator, iPosition:=3)
                clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=2)
                clsRefGreaterOrLessOperator = clsRefLessOperator
            Case "Mean"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsPipeOperator.RemoveParameterByName("mutate")
                clsSummariseFunction.AddParameter("summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Mean Above"
                clsPipeOperator.RemoveParameterByName("mutate")
                clsMeanFilterFunction.AddParameter("operator", clsROperatorParameter:=clsGreaterOperator, bIncludeArgumentName:=False, iPosition:=0)
                clsPipeOperator.AddParameter("filter2", clsRFunctionParameter:=clsMeanFilterFunction, iPosition:=4)
                clsSummariseFunction.AddParameter("summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Mean Below"
                clsPipeOperator.RemoveParameterByName("mutate")
                clsMeanFilterFunction.AddParameter("operator", clsROperatorParameter:=clsLessOperator, bIncludeArgumentName:=False, iPosition:=0)
                clsPipeOperator.AddParameter("filter2", clsRFunctionParameter:=clsMeanFilterFunction, iPosition:=4)
                clsSummariseFunction.AddParameter("summary", clsRFunctionParameter:=clsMeanFunction, iPosition:=3)
            Case "Std.dev"
                clsPipeOperator.RemoveParameterByName("filter2")
                clsPipeOperator.RemoveParameterByName("mutate")
                clsSummariseFunction.AddParameter("summary", clsRFunctionParameter:=clsStdFunction, iPosition:=3)
        End Select
    End Sub

    Private Sub UpdateSmoothingParameters()
        Select Case ucrInputSmoothing.GetText
            Case "Fourier Series"
                clsGeomSmoothFunction.AddParameter("formula", clsRFunctionParameter:=clsAsFormulaFunction, iPosition:=1)
                clsFormulaRCode = clsAsFormulaFunction
            Case "Periodic Splines"
                clsTildeOperator.AddParameter("1", clsRFunctionParameter:=clsPbsFunction, iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
                clsFormulaRCode = clsTildeOperator
            Case "Natural Splines"
                clsTildeOperator.AddParameter("1", clsRFunctionParameter:=clsNsFunction, iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
                clsFormulaRCode = clsTildeOperator
            Case "LOESS"
                clsTildeOperator.AddParameter("1", "x", iPosition:=1)
                clsGeomSmoothFunction.AddParameter("formula", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
                clsFormulaRCode = clsTildeOperator
        End Select
        If ucrInputSmoothing.GetText = "LOESS" Then
            clsGeomSmoothFunction.AddParameter("method", Chr(34) & "loess" & Chr(34), iPosition:=0)
            clsGeomSmoothFunction.RemoveParameterByName("method.args")
        Else
            Select Case ucrInputReferenceSummary.GetText
                Case "Prop Above", "Prop Below"
                    clsGeomSmoothFunction.AddParameter("method", Chr(34) & "glm" & Chr(34), iPosition:=0)
                    clsGeomSmoothFunction.AddParameter("method.args", clsRFunctionParameter:=clsListFunction, iPosition:=2)
                Case "Mean", "Mean Above", "Mean Below", "Std.dev"
                    clsGeomSmoothFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
                    clsGeomSmoothFunction.RemoveParameterByName("method.args")
            End Select
        End If
        ucrInputEstimatesSummary.SetName(ucrInputReferenceSummary.GetText())
        Select Case ucrInputReferenceSummary.GetText
            Case "Prop Above", "Prop Below"
                clsYlabFunction.AddParameter("label", Chr(34) & "Prop" & Chr(34))
            Case "Mean", "Mean Above", "Mean Below"
                clsYlabFunction.AddParameter("label", Chr(34) & "Mean" & Chr(34))
            Case "Std.dev"
                clsYlabFunction.AddParameter("label", Chr(34) & "Std.dev" & Chr(34))
        End Select
    End Sub

    Private Sub Summary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputReferenceSummary.ControlValueChanged, ucrReceiverReference.ControlValueChanged, ucrReceiverEstimates.ControlValueChanged
        If ucrReceiverReference.IsEmpty Then
            clsPivotFactorLevelsCFunction.RemoveParameterByName("0")
        Else
            clsPivotFactorLevelsCFunction.AddParameter("0", ucrReceiverReference.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        End If
        If ucrReceiverEstimates.IsEmpty Then
            clsPivotFactorLevelsCFunction.RemoveParameterByName("1")
        Else
            clsPivotFactorLevelsCFunction.AddParameter("1", ucrReceiverEstimates.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
        End If
        UpdateSummaryParameters()
    End Sub

    Private Sub Smoothing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputReferenceSummary.ControlValueChanged, ucrInputSmoothing.ControlValueChanged
        UpdateSmoothingParameters()
    End Sub

    Private Sub ucrInputReferenceThreshold_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputReferenceThreshold.ControlContentsChanged
        ' By default estimates has the same threshold as reference values, unless the user has 
        ' already typed in ucrInputEstimatesThreshold to make them different.
        If Not ucrInputEstimatesThreshold.UserTyped Then
            ucrInputEstimatesThreshold.SetName(ucrInputReferenceThreshold.GetText())
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
        ' Facets are handled manually since they could also be managed on a sub dialog.
        ' The check for clsFacetWrapTildeOperator.clsParameters.Count = 0 ensures that facets added 
        ' on a subdialog are not removed when ucrReceiverStation is empty.
        If ucrReceiverStation.IsEmpty AndAlso clsFacetWrapTildeOperator.clsParameters.Count = 0 Then
            clsPlusOperator.RemoveParameterByName("facets")
        Else
            clsPlusOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetWrapFunction, iPosition:=5)
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlContentsChanged, ucrReceiverEstimates.ControlContentsChanged, ucrReceiverSeasonality.ControlContentsChanged, ucrChkMovingAverage.ControlContentsChanged, ucrInputN.ControlContentsChanged, ucrInputReferenceSummary.ControlContentsChanged, ucrInputReferenceThreshold.ControlContentsChanged, ucrInputEstimatesThreshold.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrInputSmoothing.ControlContentsChanged, ucrNudHarmonics.ControlContentsChanged, ucrNudPeriod.ControlContentsChanged, ucrNudSpan.ControlContentsChanged, ucrNudDf.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
