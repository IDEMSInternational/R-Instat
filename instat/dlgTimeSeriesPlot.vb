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

    ' Constants
    Private strReference As String = ""
    Private strEstimates As String = ""
    Private strData As String = "data"
    Private strValue As String = "value"

    ' Adjust NA values
    Private clsAdjustNAOperator As ROperator
    Private clsAdjustNAMutateParameter As RParameter
    Private clsAdjustNAMutate As RFunction
    Private clsIfElseReference As RFunction
    Private clsIsNaReference As RFunction
    Private clsIfElseEstimates As RFunction
    Private clsIsNaEstimates As RFunction

    ' Stack data
    Private clsStackOperator As ROperator
    Private clsPivotLonger As RFunction
    Private clsPivotCFunction As RFunction

    ' Calculate means
    Private clsMeansOperator As ROperator
    Private clsMeansGroupBy As RFunction
    Private clsMeansSummarise As RFunction
    Private clsMeanFunction As RFunction

    ' Calculate Text Summaries
    Private clsSummaryOperator As ROperator
    Private clsSummaryGroupBy As RFunction
    Private clsSummarise As RFunction
    Private clsN As RFunction
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

    Private dctSummaries As Dictionary(Of String, Tuple(Of RFunction, RFunction))

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
    Private clsGeomText As RFunction
    Private clsGeomTextAes As RFunction
    Private clsPasteLabel As RFunction

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)

    'Parameter names for geoms
    Private strGeomLineParameterName As String = "geom_line"
    Private strGeomPointParameterName As String = "geom_point"
    Private strGeomHLineParameterName As String = "geom_hline"
    Private strGeomTextParameterName As String = "geom_text"
    Private strGeomParameterNames() As String = {strGeomLineParameterName, strGeomPointParameterName, strGeomHLineParameterName, strGeomTextParameterName}

    Private Sub dlgTimeSeriesPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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

        ucrReceiverEstimates.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimates.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.bWithQuotes = False
        ucrReceiverEstimates.SetDataType("numeric")

        ucrReceiverTime.SetParameter(New RParameter("x", 0))
        ucrReceiverTime.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverTime.SetParameterIsString()
        ucrReceiverTime.bWithQuotes = False
        ucrReceiverTime.SetClimaticType("year")
        ucrReceiverTime.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.SetDataType("factor")
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

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

        clsMeansOperator = New ROperator
        clsMeansGroupBy = New RFunction
        clsMeansSummarise = New RFunction
        clsMeanFunction = New RFunction

        clsSummaryOperator = New ROperator
        clsSummaryGroupBy = New RFunction
        clsSummarise = New RFunction
        clsN = New RFunction
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

        dctSummaries = New Dictionary(Of String, Tuple(Of RFunction, RFunction))
        dctSummaries.Add("n", New Tuple(Of RFunction, RFunction)(clsN, clsPasteN))
        dctSummaries.Add("cor", New Tuple(Of RFunction, RFunction)(clsCor, clsPasteCor))
        dctSummaries.Add("pbias", New Tuple(Of RFunction, RFunction)(clsPbias, clsPastePbias))
        dctSummaries.Add("rsd", New Tuple(Of RFunction, RFunction)(clsRSd, clsPasteRSd))
        dctSummaries.Add("me", New Tuple(Of RFunction, RFunction)(clsMe, clsPasteMe))
        dctSummaries.Add("mae", New Tuple(Of RFunction, RFunction)(clsMae, clsPasteMae))
        dctSummaries.Add("rmse", New Tuple(Of RFunction, RFunction)(clsRmse, clsPasteRmse))
        dctSummaries.Add("kge", New Tuple(Of RFunction, RFunction)(clsKge, clsPasteKge))

        clsGgplotOperator = New ROperator
        clsGgplotFunction = New RFunction
        clsGgplotAes = New RFunction
        clsGeomLine = New RFunction
        clsGeomPoint.Clear()
        clsGeomHLine.Clear()
        clsGeomHLineAes.Clear()
        clsGeomText = New RFunction
        clsGeomTextAes = New RFunction
        clsPasteLabel = New RFunction

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
        clsPivotLonger.AddParameter("names_to", Chr(34) & strData & Chr(34), iPosition:=2)
        clsPivotLonger.AddParameter("values_to", Chr(34) & strValue & Chr(34), iPosition:=8)

        clsPivotCFunction.SetRCommand("c")

        ' Calculate means

        clsMeansOperator.SetOperation("%>%")
        clsMeansOperator.AddParameter("0", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsMeansOperator.AddParameter("1", clsRFunctionParameter:=clsMeansGroupBy, iPosition:=1)
        clsMeansOperator.AddParameter("2", clsRFunctionParameter:=clsMeansSummarise, iPosition:=2)
        clsMeansOperator.bBrackets = False

        clsMeansGroupBy.SetPackageName("dplyr")
        clsMeansGroupBy.SetRCommand("group_by")
        clsMeansGroupBy.AddParameter("1", strData, iPosition:=1, bIncludeArgumentName:=False)

        clsMeansSummarise.SetPackageName("dplyr")
        clsMeansSummarise.SetRCommand("summarise")
        clsMeansSummarise.AddParameter("mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("x", strValue, iPosition:=0)
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        ' Calculate summaries
        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("0", clsROperatorParameter:=clsAdjustNAOperator, iPosition:=0)
        clsSummaryOperator.AddParameter("2", clsRFunctionParameter:=clsSummarise, iPosition:=2)

        clsSummaryGroupBy.SetPackageName("dplyr")
        clsSummaryGroupBy.SetRCommand("group_by")

        clsSummarise.SetPackageName("dplyr")
        clsSummarise.SetRCommand("summarise")

        clsN.SetPackageName("dplyr")
        clsN.SetRCommand("n")

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
        clsGgplotOperator.AddParameter(strGeomHLineParameterName, clsRFunctionParameter:=clsGeomHLine, iPosition:=3)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsStackOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAes, iPosition:=1)

        clsGgplotAes.SetPackageName("ggplot2")
        clsGgplotAes.SetRCommand("aes")
        clsGgplotAes.AddParameter("y", strValue, iPosition:=1)
        clsGgplotAes.AddParameter("colour", strData, iPosition:=2)

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")

        clsGeomHLine.SetPackageName("ggplot2")
        clsGeomHLine.SetRCommand("geom_hline")
        clsGeomHLine.AddParameter("data", clsROperatorParameter:=clsMeansOperator, iPosition:=0)
        clsGeomHLine.AddParameter("mapping", clsRFunctionParameter:=clsGeomHLineAes, iPosition:=1)

        clsGeomHLineAes.SetPackageName("ggplot2")
        clsGeomHLineAes.SetRCommand("aes")
        clsGeomHLineAes.AddParameter("yintercept", "mean", iPosition:=0)
        clsGeomHLineAes.AddParameter("colour", strData, iPosition:=1)

        clsGeomText.SetPackageName("ggplot2")
        clsGeomText.SetRCommand("geom_text")
        clsGeomText.AddParameter("data", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
        clsGeomText.AddParameter("mapping", clsRFunctionParameter:=clsGeomTextAes, iPosition:=1)
        clsGeomText.AddParameter("x", "-Inf", iPosition:=3)
        clsGeomText.AddParameter("y", "Inf", iPosition:=4)
        clsGeomText.AddParameter("hjust", "0", iPosition:=5)
        clsGeomText.AddParameter("vjust", "1", iPosition:=6)
        clsGeomText.AddParameter("size", "5", iPosition:=7)
        clsGeomText.AddParameter("inherit.aes", "FALSE", iPosition:=10)

        clsGeomTextAes.SetPackageName("ggplot2")
        clsGeomTextAes.SetRCommand("aes")
        clsGeomTextAes.AddParameter("label", clsRFunctionParameter:=clsPasteLabel, iPosition:=0)

        clsPasteLabel.SetRCommand("paste")

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
        clsPasteMe.AddParameter("0", Chr(34) & "me" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteMe.AddParameter("1", clsRFunctionParameter:=clsSignifMe, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifMe.SetRCommand("signif")
        clsSignifMe.AddParameter("x", "me", iPosition:=0)
        clsSignifMe.AddParameter("digits", "2", iPosition:=1)

        clsPasteMae.SetRCommand("paste")
        clsPasteMae.AddParameter("0", Chr(34) & "mae" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteMae.AddParameter("1", clsRFunctionParameter:=clsSignifMae, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifMae.SetRCommand("signif")
        clsSignifMae.AddParameter("x", "mae", iPosition:=0)
        clsSignifMae.AddParameter("digits", "2", iPosition:=1)

        clsPasteRmse.SetRCommand("paste")
        clsPasteRmse.AddParameter("0", Chr(34) & "rmse" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPasteRmse.AddParameter("1", clsRFunctionParameter:=clsSignifRmse, iPosition:=1, bIncludeArgumentName:=False)

        clsSignifRmse.SetRCommand("signif")
        clsSignifRmse.AddParameter("x", "rmse", iPosition:=0)
        clsSignifRmse.AddParameter("digits", "2", iPosition:=1)

        clsPastePbias.SetRCommand("paste")
        clsPastePbias.AddParameter("0", Chr(34) & "%bias" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
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

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_wrap")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True

        clsGgplotOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

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
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsFacetOperator, New RParameter("1", 1), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsSummaryGroupBy, New RParameter("0", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrSelectorTimeSeriesPlots.SetRCode(clsAdjustNAOperator, bReset)
        ucrReceiverReference.SetRCode(clsIsNaReference, bReset)
        ucrReceiverEstimates.SetRCode(clsIsNaEstimates, bReset)
        ucrReceiverStation.SetRCode(clsMeansGroupBy, bReset)
        ucrReceiverTime.SetRCode(clsGgplotAes, bReset)
        ucrChkNAValues.SetRCode(clsAdjustNAOperator, bReset)
        ucrChkIncludePoints.SetRCode(clsGgplotOperator, bReset)
        ucrChkIncludeMeanLines.SetRCode(clsGgplotOperator, bReset)

        SetDataFrameAssignTo()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverEstimates.IsEmpty And Not ucrReceiverReference.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDataFrameAssignTo()
        If ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If ucrChkNAValues.Checked Then
                clsAdjustNAOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            Else
                clsAdjustNAOperator.RemoveAssignTo()
            End If
            clsStackOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stack")
            clsMeansOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_mean")
            clsSummaryOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_summary")
        Else
            clsAdjustNAOperator.RemoveAssignTo()
            clsStackOperator.RemoveAssignTo()
            clsMeansOperator.RemoveAssignTo()
            clsSummaryOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorTimeSeriesPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTimeSeriesPlots.ControlValueChanged, ucrChkNAValues.ControlValueChanged
        SetDataFrameAssignTo()
    End Sub

    Private Sub ucrReceiverEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlValueChanged
        If ucrReceiverEstimates.IsEmpty Then
            If strEstimates <> "" Then
                clsAdjustNAMutate.RemoveParameterByName(strEstimates)
                strEstimates = ""
            End If
        Else
            strEstimates = ucrReceiverEstimates.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strEstimates, clsRFunctionParameter:=clsIfElseEstimates, iPosition:=1)
        End If
    End Sub

    Private Sub ucrReceiverReference_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverReference.ControlValueChanged
        If ucrReceiverReference.IsEmpty Then
            If strReference <> "" Then
                clsAdjustNAMutate.RemoveParameterByName(strReference)
                strReference = ""
            End If
        Else
            strReference = ucrReceiverReference.GetVariableNames(False)
            clsAdjustNAMutate.AddParameter(strReference, clsRFunctionParameter:=clsIfElseReference, iPosition:=0)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverEstimates.ControlContentsChanged, ucrReceiverReference.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        If ucrReceiverStation.IsEmpty AndAlso clsFacetOperator.clsParameters.Count = 0 Then
            clsGgplotOperator.RemoveParameterByName("facets")
        Else
            clsGgplotOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=30)
        End If
        If ucrReceiverStation.IsEmpty Then
            clsSummaryOperator.RemoveParameterByName("1")
        Else
            clsSummaryOperator.AddParameter("1", clsRFunctionParameter:=clsSummaryGroupBy, iPosition:=1)
        End If
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgTimeSeries.SetRCode(clsNewSummarise:=clsSummarise, dctNewSummaries:=dctSummaries, clsNewGgplotOperator:=clsGgplotOperator, clsNewGeomText:=clsGeomText, clsNewPasteLabel:=clsPasteLabel, bReset:=bResetSubdialog)
        sdgTimeSeries.ShowDialog()
        bResetSubdialog = False
    End Sub
End Class