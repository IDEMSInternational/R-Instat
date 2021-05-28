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

Public Class dlgTimeSeriesPlot

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True

    ' These store the names of the selected reference/estimates columns. 
    ' This is used to ensure old parameters are correctly removed from dplyr::mutate when selected columns are changed.
    ' See ucrReceiverEstimates.ControlValueChanged and ucrReceiverReference.ControlValueChanged event handles for their use.
    ''' <summary> Store the name of the selected reference column. </summary>
    Private strReference As String = ""
    ''' <summary> Store the name of the selected estimates column. </summary>
    Private strEstimates As String = ""

    ' Constants
    ' 
    ''' <summary> The name of the "names" column when the data is stacked </summary>
    Private Const strName As String = "data"
    ''' <summary> The name of the "values" column when the data is stacked </summary>
    Private Const strValue As String = "value"

    ' Adjust NA values
    ' These functions construct the R code below if ucrChkNAValues is checked. This ensures the two columns have the same missing values.
    ' df <- df %>% 
    '   mutate(gauge = ifelse(is.na(estimate), NA, gauge),
    '          estimate = ifelse(is.na(gauge), NA, estimate))
    Private clsAdjustNAOperator As ROperator
    Private clsAdjustNAMutateParameter As RParameter
    Private clsAdjustNAMutate As RFunction
    Private clsIfElseReference As RFunction
    Private clsIsNaReference As RFunction
    Private clsIfElseEstimates As RFunction
    Private clsIsNaEstimates As RFunction

    ' Stack data
    ' These functions construct the R code below. This stacks the two columns which is needed for plotting.
    ' df_stack <- df %>% 
    '   pivot_longer(cols = c(gauge, estimate), names_to = "data", values_to = "value", names_ptypes = list(data = factor(levels = c("gauge", "estimates"))))
    Private clsStackOperator As ROperator
    Private clsPivotLonger As RFunction
    Private clsPivotCFunction As RFunction
    Private clsPivotListFunction As RFunction
    Private clsPivotFactorFunction As RFunction
    Private clsPivotFactorLevelsCFunction As RFunction

    ' Calculate Individual Summaries.
    ' These functions construct the R code below if mean lines and/or if annotated individual summaries are added.
    ' df_individual <- df_stack %>%
    '   group_by(station, data) %>%
    '   summarise(mean = mean(value, na.rm = TRUE)
    '             sd = sd(value, na.rm = TRUE))
    Private clsIndividualSummariesOperator As ROperator
    Private clsIndividualSummariesGroupBy As RFunction
    Private clsIndividualSummariesSummarise As RFunction
    Private clsNIndividual As RFunction
    Private clsMean As RFunction
    Private clsSd As RFunction
    Private clsSlope As RFunction
    Private clsPasteNIndividual As RFunction
    Private clsPasteMean As RFunction
    Private clsPasteSd As RFunction
    Private clsPasteSlope As RFunction
    Private clsSignifMean As RFunction
    Private clsRoundSd As RFunction
    Private clsSignifSlope As RFunction

    ' Calculate Comparison Summaries
    ' These functions construct the R code below if annotated comparison summaries are added.
    '  df_comparison <- df %>%
    '    group_by(station) %>%
    '    summarise(n = n(),
    '              cor = cor(estimate, gauge, use = "na.or.complete"),
    '              me = hydroGOF : Me(estimate, gauge),
    '              mae = hydroGOF:mae(estimate, gauge))
    Private clsComparisonSummariesOperator As ROperator
    Private clsComparisonSummariesGroupBy As RFunction
    Private clsComparisonSummariesSummarise As RFunction
    Private clsNComparison As RFunction
    Private clsCor As RFunction
    Private clsMe As RFunction
    Private clsMae As RFunction
    Private clsRmse As RFunction
    Private clsPbias As RFunction
    Private clsRSd As RFunction
    Private clsKge As RFunction
    Private clsPasteN As RFunction
    Private clsPasteCor As RFunction
    Private clsPasteMe As RFunction
    Private clsPasteMae As RFunction
    Private clsPasteRmse As RFunction
    Private clsPastePbias As RFunction
    Private clsPasteRSd As RFunction
    Private clsPasteKge As RFunction
    Private clsRoundCor As RFunction
    Private clsSignifMe As RFunction
    Private clsSignifMae As RFunction
    Private clsSignifRmse As RFunction
    Private clsRoundPbias As RFunction
    Private clsRoundRSd As RFunction
    Private clsRoundKge As RFunction

    ' Dictionaries of the comparison/individual summary functions above. 
    ' The key is the summary name in lower case e.g. "bias"
    ' The value is a tuple of two RFunctions. 
    ' Item1 is the summary function. 
    ' Item2 is the paste function containing the summary.
    ' These dictionary are created to avoid passing all the RFunctions to the sub dialog individually.
    ''' <summary>
    ''' A dictionary of the comparison summary functions. The key is the summary name in lower case e.g. "bias". The value is a tuple of two RFunctions: the summary function and it's paste function. 
    ''' </summary>
    Private dctComparisonSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))
    ''' <summary>
    ''' A dictionary of the individual summary functions. The key is the summary name in lower case e.g. "mean". The value is a tuple of two RFunctions: the summary function and it's paste function. 
    ''' </summary>
    Private dctIndividualSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))

    ' ggplot functions
    Private clsGgplotOperator As ROperator
    Private clsGgplotFunction As RFunction
    Private clsGgplotAes As RFunction
    Private clsGeomLine As RFunction
    Private clsGeomPointParameter As RParameter
    Private clsGeomPoint As RFunction
    Private clsGeomHLineParameter As RParameter
    Private clsGeomHLine As RFunction
    Private clsGeomHLineAes As RFunction
    Private clsComparisonGeomText As RFunction
    Private clsComparisonGeomTextAes As RFunction
    Private clsComparisonPasteLabel As RFunction
    Private clsGeomSmoothParameter As RParameter
    Private clsGeomSmooth As RFunction

    Private clsReferenceGeomText As RFunction
    Private clsReferenceGeomTextAes As RFunction
    Private clsReferencePasteLabel As RFunction
    Private clsReferenceFilter As RFunction
    Private clsEstimatesGeomText As RFunction
    Private clsEstimatesGeomTextAes As RFunction
    Private clsEstimatesPasteLabel As RFunction
    Private clsEstimatesFilter As RFunction

    ' These will be needed when the dialog implements the Plot Options subdialog
    'Private clsLabsFunction As New RFunction
    'Private clsXlabsFunction As New RFunction
    'Private clsYlabFunction As New RFunction
    'Private clsXScaleContinuousFunction As New RFunction
    'Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    'Private clsThemeFunction As New RFunction
    'Private dctThemeFunctions As Dictionary(Of String, RFunction)

    'Parameter names for geoms
    Private strGeomLineParameterName As String = "geom_line"
    Private strGeomPointParameterName As String = "geom_point"
    Private strGeomHLineParameterName As String = "geom_hline"
    Private strGeomTextReferenceParameterName As String = "reference_geom_text"
    Private strGeomTextEstimatesParameterName As String = "estimates_geom_text"
    Private strGeomTextComparisonParameterName As String = "comparison_geom_text"
    Private strGeomSmoothParameterName As String = "geom_smooth"
    ' This will be needed when the dialog implements the Plot Options subdialog
    'Private strGeomParameterNames() As String = {strGeomLineParameterName, strGeomPointParameterName, strGeomHLineParameterName, strGeomTextReferenceParameterName, strGeomTextEstimatesParameterName, strGeomTextComparisonParameterName}

    Private Sub dlgTimeSeriesPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'ucrBase.iHelpTopicID =
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorTimeSeriesPlots.SetParameter(New RParameter("0", 0))
        ucrSelectorTimeSeriesPlots.SetParameterIsrfunction()

        ucrReceiverReference.SetParameter(New RParameter("x", 0))
        ucrReceiverReference.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverReference.SetParameterIsString()
        ucrReceiverReference.bWithQuotes = False
        ucrReceiverReference.SetDataType("numeric")
        ucrReceiverReference.strSelectorHeading = "Numerics"

        ucrReceiverEstimates.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimates.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.bWithQuotes = False
        ucrReceiverEstimates.SetDataType("numeric")
        ucrReceiverEstimates.strSelectorHeading = "Numerics"

        ucrReceiverTime.SetParameter(New RParameter("x", 0))
        ucrReceiverTime.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverTime.SetParameterIsString()
        ucrReceiverTime.bWithQuotes = False

        ucrReceiverFacetBy.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))
        ucrReceiverFacetBy.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverFacetBy.SetParameterIsString()
        ucrReceiverFacetBy.bWithQuotes = False
        ucrReceiverFacetBy.SetDataType("factor")
        ucrReceiverFacetBy.SetClimaticType("station")
        ucrReceiverFacetBy.bAutoFill = True
        ucrReceiverFacetBy.strSelectorHeading = "Factors"

        clsAdjustNAMutate = New RFunction
        clsAdjustNAMutateParameter = New RParameter("1", clsAdjustNAMutate, iNewPosition:=1)
        ucrChkNAValues.SetText("Remove rows with any missing values")
        ucrChkNAValues.SetParameter(clsAdjustNAMutateParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomPoint = New RFunction
        clsGeomPointParameter = New RParameter(strGeomPointParameterName, clsGeomPoint, iNewPosition:=2)
        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.SetParameter(clsGeomPointParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomHLine = New RFunction
        clsGeomHLineAes = New RFunction
        clsGeomHLineParameter = New RParameter(strGeomHLineParameterName, clsGeomHLine, iNewPosition:=3)
        ucrChkIncludeMeanLines.SetText("Include Mean Lines")
        ucrChkIncludeMeanLines.SetParameter(clsGeomHLineParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomSmooth = New RFunction
        clsGeomSmoothParameter = New RParameter(strGeomSmoothParameterName, clsGeomSmooth, iNewPosition:=4)
        ucrChkIncludeLineOfBestFit.SetText("Include Lines of Best Fit")
        ucrChkIncludeLineOfBestFit.SetParameter(clsGeomSmoothParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkIncludeLineOfBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.SetParameter(New RParameter("se", 1))
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrSavePlot.SetPrefix("line")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsAdjustNAOperator = New ROperator
        clsIfElseReference = New RFunction
        clsIfElseEstimates = New RFunction
        clsIsNaReference = New RFunction
        clsIsNaEstimates = New RFunction

        clsStackOperator = New ROperator
        clsPivotLonger = New RFunction
        clsPivotCFunction = New RFunction
        clsPivotListFunction = New RFunction
        clsPivotFactorFunction = New RFunction
        clsPivotFactorLevelsCFunction = New RFunction

        clsIndividualSummariesOperator = New ROperator
        clsIndividualSummariesGroupBy = New RFunction
        clsIndividualSummariesSummarise = New RFunction
        clsNIndividual = New RFunction
        clsMean = New RFunction
        clsSd = New RFunction
        clsSlope = New RFunction
        clsPasteNIndividual = New RFunction
        clsPasteMean = New RFunction
        clsPasteSd = New RFunction
        clsPasteSlope = New RFunction
        clsSignifMean = New RFunction
        clsRoundSd = New RFunction
        clsSignifSlope = New RFunction

        clsComparisonSummariesOperator = New ROperator
        clsComparisonSummariesGroupBy = New RFunction
        clsComparisonSummariesSummarise = New RFunction
        clsNComparison = New RFunction
        clsCor = New RFunction
        clsPbias = New RFunction
        clsRSd = New RFunction
        clsMe = New RFunction
        clsMae = New RFunction
        clsRmse = New RFunction
        clsKge = New RFunction
        clsPasteN = New RFunction
        clsPasteCor = New RFunction
        clsPastePbias = New RFunction
        clsPasteRSd = New RFunction
        clsPasteMe = New RFunction
        clsPasteMae = New RFunction
        clsPasteRmse = New RFunction
        clsPasteKge = New RFunction
        clsRoundCor = New RFunction
        clsRoundPbias = New RFunction
        clsRoundRSd = New RFunction
        clsSignifMe = New RFunction
        clsSignifMae = New RFunction
        clsSignifRmse = New RFunction
        clsRoundKge = New RFunction

        clsGgplotOperator = New ROperator
        clsGgplotFunction = New RFunction
        clsGgplotAes = New RFunction
        clsGeomLine = New RFunction
        clsGeomPoint.Clear()
        clsGeomHLine.Clear()
        clsGeomHLineAes.Clear()
        clsGeomSmooth.Clear()
        clsComparisonGeomText = New RFunction
        clsComparisonGeomTextAes = New RFunction
        clsComparisonPasteLabel = New RFunction

        clsReferenceGeomText = New RFunction
        clsReferenceGeomTextAes = New RFunction
        clsReferencePasteLabel = New RFunction
        clsReferenceFilter = New RFunction
        clsEstimatesGeomText = New RFunction
        clsEstimatesGeomTextAes = New RFunction
        clsEstimatesPasteLabel = New RFunction
        clsEstimatesFilter = New RFunction

        dctComparisonSummaries = New Dictionary(Of String, Tuple(Of RFunction, RFunction))
        dctComparisonSummaries.Add("n", New Tuple(Of RFunction, RFunction)(clsNComparison, clsPasteN))
        dctComparisonSummaries.Add("cor", New Tuple(Of RFunction, RFunction)(clsCor, clsPasteCor))
        dctComparisonSummaries.Add("pbias", New Tuple(Of RFunction, RFunction)(clsPbias, clsPastePbias))
        dctComparisonSummaries.Add("rsd", New Tuple(Of RFunction, RFunction)(clsRSd, clsPasteRSd))
        dctComparisonSummaries.Add("me", New Tuple(Of RFunction, RFunction)(clsMe, clsPasteMe))
        dctComparisonSummaries.Add("mae", New Tuple(Of RFunction, RFunction)(clsMae, clsPasteMae))
        dctComparisonSummaries.Add("rmse", New Tuple(Of RFunction, RFunction)(clsRmse, clsPasteRmse))
        dctComparisonSummaries.Add("kge", New Tuple(Of RFunction, RFunction)(clsKge, clsPasteKge))

        dctIndividualSummaries = New Dictionary(Of String, Tuple(Of RFunction, RFunction))
        dctIndividualSummaries.Add("n", New Tuple(Of RFunction, RFunction)(clsNIndividual, clsPasteNIndividual))
        dctIndividualSummaries.Add("mean", New Tuple(Of RFunction, RFunction)(clsMean, clsPasteMean))
        dctIndividualSummaries.Add("sd", New Tuple(Of RFunction, RFunction)(clsSd, clsPasteSd))
        dctIndividualSummaries.Add("slope", New Tuple(Of RFunction, RFunction)(clsSlope, clsPasteSlope))

        ucrSelectorTimeSeriesPlots.Reset()
        ucrSelectorTimeSeriesPlots.SetGgplotFunction(clsGgplotOperator)
        ucrSavePlot.Reset()
        ucrReceiverReference.SetMeAsReceiver()

        ' Adjust NA values

        clsAdjustNAOperator.SetOperation("%>%")
        clsAdjustNAOperator.AddParameter(clsAdjustNAMutateParameter)

        clsAdjustNAMutate.Clear()
        clsAdjustNAMutate.SetPackageName("dplyr")
        clsAdjustNAMutate.SetRCommand("mutate")

        clsIfElseReference.SetRCommand("ifelse")
        clsIfElseReference.AddParameter("test", clsRFunctionParameter:=clsIsNaEstimates, iPosition:=0)
        clsIfElseReference.AddParameter("yes", "NA", iPosition:=1)

        clsIfElseEstimates.SetRCommand("ifelse")
        clsIfElseEstimates.AddParameter("test", clsRFunctionParameter:=clsIsNaReference, iPosition:=0)
        clsIfElseEstimates.AddParameter("yes", "NA", iPosition:=1)

        clsIsNaReference.SetRCommand("is.na")
        clsIsNaEstimates.SetRCommand("is.na")

        ' Stack data

        clsStackOperator.SetOperation("%>%")
        clsStackOperator.AddParameter("0", clsROperatorParameter:=clsAdjustNAOperator, iPosition:=0)
        clsStackOperator.AddParameter("1", clsRFunctionParameter:=clsPivotLonger, iPosition:=1)
        clsStackOperator.bBrackets = False

        clsPivotLonger.SetPackageName("tidyr")
        clsPivotLonger.SetRCommand("pivot_longer")
        clsPivotLonger.AddParameter("cols", clsRFunctionParameter:=clsPivotCFunction, iPosition:=1)
        clsPivotLonger.AddParameter("names_to", Chr(34) & strName & Chr(34), iPosition:=2)
        clsPivotLonger.AddParameter("names_ptypes", clsRFunctionParameter:=clsPivotListFunction, iPosition:=6)
        clsPivotLonger.AddParameter("values_to", Chr(34) & strValue & Chr(34), iPosition:=8)

        clsPivotCFunction.SetRCommand("c")

        clsPivotListFunction.SetRCommand("list")
        clsPivotListFunction.AddParameter(strName, clsRFunctionParameter:=clsPivotFactorFunction, iPosition:=0)

        clsPivotFactorFunction.SetRCommand("factor")
        clsPivotFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsPivotFactorLevelsCFunction, iPosition:=1)

        clsPivotFactorLevelsCFunction.SetRCommand("c")

        ' Calculate individual summaries

        clsIndividualSummariesOperator.SetOperation("%>%")
        clsIndividualSummariesOperator.AddParameter("0", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsIndividualSummariesOperator.AddParameter("1", clsRFunctionParameter:=clsIndividualSummariesGroupBy, iPosition:=1)
        clsIndividualSummariesOperator.AddParameter("2", clsRFunctionParameter:=clsIndividualSummariesSummarise, iPosition:=2)
        clsIndividualSummariesOperator.bBrackets = False

        clsIndividualSummariesGroupBy.SetPackageName("dplyr")
        clsIndividualSummariesGroupBy.SetRCommand("group_by")
        clsIndividualSummariesGroupBy.AddParameter("1", strName, iPosition:=1, bIncludeArgumentName:=False)

        clsIndividualSummariesSummarise.SetPackageName("dplyr")
        clsIndividualSummariesSummarise.SetRCommand("summarise")
        clsIndividualSummariesSummarise.AddParameter("mean", clsRFunctionParameter:=clsMean, iPosition:=0)

        clsNIndividual.SetPackageName("dplyr")
        clsNIndividual.SetRCommand("n")

        clsMean.SetRCommand("mean")
        clsMean.AddParameter("x", strValue, iPosition:=0)
        clsMean.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsSd.SetRCommand("sd")
        clsSd.AddParameter("x", strValue, iPosition:=0)
        clsSd.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsSlope.SetRCommand("slope")
        clsSlope.AddParameter("y", strValue, iPosition:=0)

        ' Calculate comparison summaries

        clsComparisonSummariesOperator.SetOperation("%>%")
        clsComparisonSummariesOperator.AddParameter("0", clsROperatorParameter:=clsAdjustNAOperator, iPosition:=0)
        clsComparisonSummariesOperator.AddParameter("2", clsRFunctionParameter:=clsComparisonSummariesSummarise, iPosition:=2)
        clsComparisonSummariesOperator.bBrackets = False

        clsComparisonSummariesGroupBy.SetPackageName("dplyr")
        clsComparisonSummariesGroupBy.SetRCommand("group_by")

        clsComparisonSummariesSummarise.SetPackageName("dplyr")
        clsComparisonSummariesSummarise.SetRCommand("summarise")

        clsNComparison.SetPackageName("dplyr")
        clsNComparison.SetRCommand("n")

        clsCor.SetRCommand("cor")
        clsCor.AddParameter("use", Chr(34) & "na.or.complete" & Chr(34))

        clsMe.SetPackageName("hydroGOF")
        clsMe.SetRCommand("me")

        clsMae.SetPackageName("hydroGOF")
        clsMae.SetRCommand("mae")

        clsRmse.SetPackageName("hydroGOF")
        clsRmse.SetRCommand("rmse")

        clsPbias.SetPackageName("hydroGOF")
        clsPbias.SetRCommand("pbias")

        clsRSd.SetPackageName("hydroGOF")
        clsRSd.SetRCommand("rSD")

        clsKge.SetPackageName("hydroGOF")
        clsKge.SetRCommand("KGE")

        ' Ggplot functions

        clsGgplotOperator.SetOperation("+")
        clsGgplotOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsGgplotOperator.AddParameter(strGeomLineParameterName, clsRFunctionParameter:=clsGeomLine, iPosition:=1)
        clsGgplotOperator.AddParameter(clsGeomPointParameter)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAes, iPosition:=1)

        clsGgplotAes.SetPackageName("ggplot2")
        clsGgplotAes.SetRCommand("aes")
        clsGgplotAes.AddParameter("y", strValue, iPosition:=1)
        clsGgplotAes.AddParameter("colour", strName, iPosition:=2)

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")

        clsGeomHLine.SetPackageName("ggplot2")
        clsGeomHLine.SetRCommand("geom_hline")
        clsGeomHLine.AddParameter("data", clsROperatorParameter:=clsIndividualSummariesOperator, iPosition:=0)
        clsGeomHLine.AddParameter("mapping", clsRFunctionParameter:=clsGeomHLineAes, iPosition:=1)

        clsGeomHLineAes.SetPackageName("ggplot2")
        clsGeomHLineAes.SetRCommand("aes")
        clsGeomHLineAes.AddParameter("yintercept", "mean", iPosition:=0)
        clsGeomHLineAes.AddParameter("colour", strName, iPosition:=1)

        clsGeomSmooth.SetPackageName("ggplot2")
        clsGeomSmooth.SetRCommand("geom_smooth")
        clsGeomSmooth.AddParameter("data", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsGeomSmooth.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=5)
        clsGeomSmooth.AddParameter("se", "FALSE", iPosition:=7)

        ' Comparison summaries

        clsComparisonGeomText.SetPackageName("ggplot2")
        clsComparisonGeomText.SetRCommand("geom_text")
        clsComparisonGeomText.AddParameter("data", clsROperatorParameter:=clsComparisonSummariesOperator, iPosition:=0)
        clsComparisonGeomText.AddParameter("mapping", clsRFunctionParameter:=clsComparisonGeomTextAes, iPosition:=1)
        clsComparisonGeomText.AddParameter("x", "-Inf", iPosition:=3)
        clsComparisonGeomText.AddParameter("y", "Inf", iPosition:=4)
        clsComparisonGeomText.AddParameter("hjust", "0", iPosition:=5)
        clsComparisonGeomText.AddParameter("vjust", "1", iPosition:=6)
        clsComparisonGeomText.AddParameter("size", "5", iPosition:=7)
        clsComparisonGeomText.AddParameter("inherit.aes", "FALSE", iPosition:=10)

        clsComparisonGeomTextAes.SetPackageName("ggplot2")
        clsComparisonGeomTextAes.SetRCommand("aes")
        clsComparisonGeomTextAes.AddParameter("label", clsRFunctionParameter:=clsComparisonPasteLabel, iPosition:=0)

        clsComparisonPasteLabel.SetRCommand("paste")
        clsComparisonPasteLabel.AddParameter("sep", Chr(34) & " ; " & Chr(34), iPosition:=8)

        clsPasteN.SetRCommand("paste")
        clsPasteN.AddParameter("0", Chr(34) & "n" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteN.AddParameter("1", "n", iPosition:=1, bIncludeArgumentName:=False)

        clsPasteCor.SetRCommand("paste")
        clsPasteCor.AddParameter("0", Chr(34) & "cor" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteCor.AddParameter("1", clsRFunctionParameter:=clsRoundCor, iPosition:=1, bIncludeArgumentName:=False)

        clsRoundCor.SetRCommand("round")
        clsRoundCor.AddParameter("x", "cor", iPosition:=0)
        clsRoundCor.AddParameter("digits", "2", iPosition:=1)

        clsPasteMe.SetRCommand("paste")
        clsPasteMe.AddParameter("0", Chr(34) & "ME" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteMe.AddParameter("1", clsRFunctionParameter:=clsSignifMe, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifMe.SetRCommand("signif")
        clsSignifMe.AddParameter("x", "me", iPosition:=0)
        clsSignifMe.AddParameter("digits", "2", iPosition:=1)

        clsPasteMae.SetRCommand("paste")
        clsPasteMae.AddParameter("0", Chr(34) & "MAE" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteMae.AddParameter("1", clsRFunctionParameter:=clsSignifMae, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifMae.SetRCommand("signif")
        clsSignifMae.AddParameter("x", "mae", iPosition:=0)
        clsSignifMae.AddParameter("digits", "2", iPosition:=1)

        clsPasteRmse.SetRCommand("paste")
        clsPasteRmse.AddParameter("0", Chr(34) & "RMSE" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteRmse.AddParameter("1", clsRFunctionParameter:=clsSignifRmse, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifRmse.SetRCommand("signif")
        clsSignifRmse.AddParameter("x", "rmse", iPosition:=0)
        clsSignifRmse.AddParameter("digits", "2", iPosition:=1)

        clsPastePbias.SetRCommand("paste")
        clsPastePbias.AddParameter("0", Chr(34) & "% Bias" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPastePbias.AddParameter("1", clsRFunctionParameter:=clsRoundPbias, iPosition:=1, bIncludeArgumentName:=False)

        clsRoundPbias.SetRCommand("round")
        clsRoundPbias.AddParameter("x", "pbias", iPosition:=0)
        clsRoundPbias.AddParameter("digits", "2", iPosition:=1)

        clsPasteRSd.SetRCommand("paste")
        clsPasteRSd.AddParameter("0", Chr(34) & "rSD" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteRSd.AddParameter("1", clsRFunctionParameter:=clsRoundRSd, iPosition:=1, bIncludeArgumentName:=False)

        clsRoundRSd.SetRCommand("round")
        clsRoundRSd.AddParameter("x", "rsd", iPosition:=0)
        clsRoundRSd.AddParameter("digits", "2", iPosition:=1)

        clsPasteKge.SetRCommand("paste")
        clsPasteKge.AddParameter("0", Chr(34) & "KGE" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteKge.AddParameter("1", clsRFunctionParameter:=clsRoundKge, iPosition:=1, bIncludeArgumentName:=False)

        clsRoundKge.SetRCommand("round")
        clsRoundKge.AddParameter("x", "kge", iPosition:=0)
        clsRoundKge.AddParameter("digits", "2", iPosition:=1)

        ' Individual summaries

        clsReferenceGeomText.SetPackageName("ggplot2")
        clsReferenceGeomText.SetRCommand("geom_text")
        clsReferenceGeomText.AddParameter("data", clsRFunctionParameter:=clsReferenceFilter, iPosition:=0)
        clsReferenceGeomText.AddParameter("mapping", clsRFunctionParameter:=clsReferenceGeomTextAes, iPosition:=1)
        clsReferenceGeomText.AddParameter("x", "-Inf", iPosition:=3)
        clsReferenceGeomText.AddParameter("y", "Inf", iPosition:=4)
        clsReferenceGeomText.AddParameter("hjust", "0", iPosition:=5)
        clsReferenceGeomText.AddParameter("vjust", "1", iPosition:=6)
        clsReferenceGeomText.AddParameter("size", "5", iPosition:=7)
        clsReferenceGeomText.AddParameter("inherit.aes", "FALSE", iPosition:=10)

        clsReferenceFilter.SetPackageName("dplyr")
        clsReferenceFilter.SetRCommand("filter")
        clsReferenceFilter.AddParameter(".data", clsROperatorParameter:=clsIndividualSummariesOperator, iPosition:=0)

        clsReferenceGeomTextAes.SetPackageName("ggplot2")
        clsReferenceGeomTextAes.SetRCommand("aes")
        clsReferenceGeomTextAes.AddParameter("label", clsRFunctionParameter:=clsReferencePasteLabel, iPosition:=0)

        clsReferencePasteLabel.SetRCommand("paste")
        clsReferencePasteLabel.AddParameter("sep", Chr(34) & " ; " & Chr(34), iPosition:=8)

        clsPasteNIndividual.SetRCommand("paste")
        clsPasteNIndividual.AddParameter("0", Chr(34) & "n" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteNIndividual.AddParameter("1", "n", iPosition:=1, bIncludeArgumentName:=False)

        clsPasteMean.SetRCommand("paste")
        clsPasteMean.AddParameter("0", Chr(34) & "mean" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteMean.AddParameter("1", clsRFunctionParameter:=clsSignifMean, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifMean.SetRCommand("signif")
        clsSignifMean.AddParameter("x", "mean", iPosition:=0)
        clsSignifMean.AddParameter("digits", "3", iPosition:=1)

        clsPasteSd.SetRCommand("paste")
        clsPasteSd.AddParameter("0", Chr(34) & "sd" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteSd.AddParameter("1", clsRFunctionParameter:=clsRoundSd, iPosition:=1, bIncludeArgumentName:=False)

        clsRoundSd.SetRCommand("round")
        clsRoundSd.AddParameter("x", "sd", iPosition:=0)
        clsRoundSd.AddParameter("digits", "2", iPosition:=1)

        clsPasteSlope.SetRCommand("paste")
        clsPasteSlope.AddParameter("0", Chr(34) & "slope" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteSlope.AddParameter("1", clsRFunctionParameter:=clsSignifSlope, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifSlope.SetRCommand("signif")
        clsSignifSlope.AddParameter("x", "slope", iPosition:=0)
        clsSignifSlope.AddParameter("digits", "2", iPosition:=1)

        clsEstimatesGeomText.SetPackageName("ggplot2")
        clsEstimatesGeomText.SetRCommand("geom_text")
        clsEstimatesGeomText.AddParameter("data", clsRFunctionParameter:=clsEstimatesFilter, iPosition:=0)
        clsEstimatesGeomText.AddParameter("mapping", clsRFunctionParameter:=clsEstimatesGeomTextAes, iPosition:=1)
        clsEstimatesGeomText.AddParameter("x", "Inf", iPosition:=3)
        clsEstimatesGeomText.AddParameter("y", "-Inf", iPosition:=4)
        clsEstimatesGeomText.AddParameter("hjust", "1", iPosition:=5)
        clsEstimatesGeomText.AddParameter("vjust", "0", iPosition:=6)
        clsEstimatesGeomText.AddParameter("size", "5", iPosition:=7)
        clsEstimatesGeomText.AddParameter("inherit.aes", "FALSE", iPosition:=10)

        clsEstimatesFilter.SetPackageName("dplyr")
        clsEstimatesFilter.SetRCommand("filter")
        clsEstimatesFilter.AddParameter(".data", clsROperatorParameter:=clsIndividualSummariesOperator, iPosition:=0)

        clsEstimatesGeomTextAes.SetPackageName("ggplot2")
        clsEstimatesGeomTextAes.SetRCommand("aes")
        clsEstimatesGeomTextAes.AddParameter("label", clsRFunctionParameter:=clsEstimatesPasteLabel, iPosition:=0)

        clsEstimatesPasteLabel.SetRCommand("paste")
        clsEstimatesPasteLabel.AddParameter("sep", Chr(34) & " ; " & Chr(34), iPosition:=8)

        ' Facets

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_wrap")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True

        clsGgplotOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        ' Commented until Plot Options subdialog is implemented.
        'clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        'clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        'clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        'clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        'clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        'clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        'dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsGgplotOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsGgplotOperator)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsIfElseReference, New RParameter("no", 2), iAdditionalPairNo:=1)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("0", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsCor, New RParameter("y", 1), iAdditionalPairNo:=3)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsMe, New RParameter("obs", 1), iAdditionalPairNo:=4)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsMae, New RParameter("obs", 1), iAdditionalPairNo:=5)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRmse, New RParameter("obs", 1), iAdditionalPairNo:=6)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsPbias, New RParameter("obs", 1), iAdditionalPairNo:=7)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsRSd, New RParameter("obs", 1), iAdditionalPairNo:=8)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsKge, New RParameter("obs", 1), iAdditionalPairNo:=9)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsIfElseEstimates, New RParameter("no", 2), iAdditionalPairNo:=1)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsPivotCFunction, New RParameter("1", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsCor, New RParameter("x", 1), iAdditionalPairNo:=3)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsMe, New RParameter("sim", 1), iAdditionalPairNo:=4)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsMae, New RParameter("sim", 1), iAdditionalPairNo:=5)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsRmse, New RParameter("sim", 1), iAdditionalPairNo:=6)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsPbias, New RParameter("sim", 1), iAdditionalPairNo:=7)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsRSd, New RParameter("sim", 1), iAdditionalPairNo:=8)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsKge, New RParameter("sim", 1), iAdditionalPairNo:=9)
        ucrReceiverFacetBy.AddAdditionalCodeParameterPair(clsFacetOperator, New RParameter("1", 1), iAdditionalPairNo:=1)
        ucrReceiverFacetBy.AddAdditionalCodeParameterPair(clsComparisonSummariesGroupBy, New RParameter("0", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverTime.AddAdditionalCodeParameterPair(clsSlope, New RParameter("x", 1), iAdditionalPairNo:=1)

        ucrSelectorTimeSeriesPlots.SetRCode(clsAdjustNAOperator, bReset)
        ucrReceiverReference.SetRCode(clsIsNaReference, bReset)
        ucrReceiverEstimates.SetRCode(clsIsNaEstimates, bReset)
        ucrReceiverFacetBy.SetRCode(clsIndividualSummariesGroupBy, bReset)
        ucrReceiverTime.SetRCode(clsGgplotAes, bReset)
        ucrChkNAValues.SetRCode(clsAdjustNAOperator, bReset)
        ucrChkIncludePoints.SetRCode(clsGgplotOperator, bReset)
        ucrChkIncludeMeanLines.SetRCode(clsGgplotOperator, bReset)
        ucrChkIncludeLineOfBestFit.SetRCode(clsGgplotOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmooth, bReset)
        ucrSavePlot.SetRCode(clsGgplotOperator, bReset)

        SetDataFrameAssignTo()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverEstimates.IsEmpty And Not ucrReceiverReference.IsEmpty And Not ucrReceiverTime.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ''' <summary>
    ''' Assigns the ROperators that correspond to a calculated data frame a standard assignment name based on the selected data frame. 
    ''' This makes the R code more readable and shorter.
    ''' </summary>
    Private Sub SetDataFrameAssignTo()
        If ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If ucrChkNAValues.Checked Then
                clsAdjustNAOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Else
                clsAdjustNAOperator.RemoveAssignTo()
            End If
            clsStackOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stack")
            clsIndividualSummariesOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_individual")
            clsComparisonSummariesOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_comparison")
        Else
            clsAdjustNAOperator.RemoveAssignTo()
            clsStackOperator.RemoveAssignTo()
            clsIndividualSummariesOperator.RemoveAssignTo()
            clsComparisonSummariesOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorTimeSeriesPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTimeSeriesPlots.ControlValueChanged, ucrChkNAValues.ControlValueChanged
        SetDataFrameAssignTo()
    End Sub

    Private Sub ucrReceiverEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlValueChanged
        ' This ensures clsAdjustNAMutate has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strEstimates as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        If ucrReceiverEstimates.IsEmpty Then
            clsAdjustNAMutate.RemoveParameterByName(strEstimates)
            strEstimates = ""
            clsEstimatesFilter.RemoveParameterByName("1")
            clsEstimatesPasteLabel.RemoveParameterByName("0")
            clsPivotFactorLevelsCFunction.RemoveParameterByName("1")
        Else
            strEstimates = ucrReceiverEstimates.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strEstimates, clsRFunctionParameter:=clsIfElseEstimates, iPosition:=1)
            clsEstimatesFilter.AddParameter("1", strName & "==" & ucrReceiverEstimates.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
            clsEstimatesPasteLabel.AddParameter("0", Chr(34) & strEstimates & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsPivotFactorLevelsCFunction.AddParameter("1", Chr(34) & strEstimates & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlValueChanged
        ' This ensures clsAdjustNAMutate has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strReference as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        If ucrReceiverReference.IsEmpty Then
            clsAdjustNAMutate.RemoveParameterByName(strReference)
            strReference = ""
            clsReferenceFilter.RemoveParameterByName("1")
            clsReferencePasteLabel.RemoveParameterByName("0")
            clsPivotFactorLevelsCFunction.RemoveParameterByName("0")
        Else
            strReference = ucrReceiverReference.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strReference, clsRFunctionParameter:=clsIfElseReference, iPosition:=0)
            clsReferenceFilter.AddParameter("1", strName & "==" & ucrReceiverReference.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
            clsReferencePasteLabel.AddParameter("0", Chr(34) & strReference & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsPivotFactorLevelsCFunction.AddParameter("0", Chr(34) & strReference & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlContentsChanged, ucrReceiverReference.ControlContentsChanged, ucrReceiverTime.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFacetBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacetBy.ControlValueChanged
        ' Facets are handles manually since they could also be managed on a sub dialog.
        ' The check for clsFacetOperator.clsParameters.Count = 0 ensures that facets added on a subdialog are not removed when ucrReceiverFacetBy is empty.
        If ucrReceiverFacetBy.IsEmpty AndAlso clsFacetOperator.clsParameters.Count = 0 Then
            clsGgplotOperator.RemoveParameterByName("facets")
        Else
            clsGgplotOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=30)
        End If
        If ucrReceiverFacetBy.IsEmpty Then
            clsComparisonSummariesOperator.RemoveParameterByName("1")
        Else
            clsComparisonSummariesOperator.AddParameter("1", clsRFunctionParameter:=clsComparisonSummariesGroupBy, iPosition:=1)
        End If
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgTimeSeries.SetRCode(clsNewComparisonSummariesSummarise:=clsComparisonSummariesSummarise, dctNewComparisonSummaries:=dctComparisonSummaries, clsNewIndividualSummariesSummarise:=clsIndividualSummariesSummarise, dctNewIndividualSummaries:=dctIndividualSummaries, clsNewGgplotOperator:=clsGgplotOperator, clsNewComparisonGeomText:=clsComparisonGeomText, clsNewReferenceGeomText:=clsReferenceGeomText, clsNewEstimatesGeomText:=clsEstimatesGeomText, clsNewComparisonPasteLabel:=clsComparisonPasteLabel, clsNewReferencePasteLabel:=clsReferencePasteLabel, clsNewEstimatesPasteLabel:=clsEstimatesPasteLabel, bReset:=bResetSubdialog)
        sdgTimeSeries.ShowDialog()
        bResetSubdialog = False
    End Sub
End Class