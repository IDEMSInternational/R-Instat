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

Public Class dlgPICSARainfall
    Public bFirstLoad As Boolean = True
    Private clsBaseOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsMutateFunction As New RFunction
    Public enumPICSAMode As String = PICSAMode.Rainfall
    Public Enum PICSAMode
        Rainfall
        Temperature
        General
    End Enum

    Private clsRggplotFunction As New RFunction
    Private clsGeomLine As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private bReset As Boolean = True
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsCLimitsYContinuous As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsCLimitsYDate As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private clsPointsFunc As New RFunction
    Private clsYLabsFunction, clsXLabsFunction, clsLabsFunction As RFunction
    Private clsFactorLevels As New RFunction
    Private clsGeomRugFunction As New RFunction
    Private clsFilterFunction As New RFunction
    Private clsEqualToOperator As New ROperator
    Private clsGeomSegmentFunction As New RFunction
    Private clsSegmentAesFunction As New RFunction
    Private clsGeomPoint2Function As RFunction
    Private clsPoint2AesFunction As RFunction

    Private clsDatePeriodOperator As New ROperator

    Private clsAsFactorFunction As New RFunction

    Private clsMeanFunction As New RFunction
    Private clsRoundMeanY As New RFunction
    Private clsAsDateMeanY As New RFunction
    Private clsMedianFunction As New RFunction
    Private clsRoundMedianY As New RFunction
    Private clsAsDateMedianY As New RFunction
    Private clsLowerTercileFunction As New RFunction
    Private clsRoundLowerTercileY As New RFunction
    Private clsAsDateLowerTercileY As New RFunction
    Private clsUpperTercileFunction As New RFunction
    Private clsRoundUpperTercileY As New RFunction
    Private clsAsDateUpperTercileY As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsGeomSmoothFunction As New RFunction
    Private clsStatRegEquationFunction As New RFunction
    Private clsStatsCorFunction As New RFunction

    Private strMeanName As String = ".mean_y"
    Private strMedianName As String = ".median_y"
    Private strLowerTercileName As String = ".lower_ter_y"
    Private strUpperTercileName As String = ".upper_ter_y"

    Private clsDummyFunction As New RFunction

    Private clsAsDateYLimit As New RFunction
    Private clsGeomHlineMean As New RFunction
    Private clsGeomHlineMedian As New RFunction
    Private clsGeomHlineLowerTercile As New RFunction
    Private clsGeomHlineUpperTercile As New RFunction

    Private clsGeomHlineAesMean As New RFunction
    Private clsGeomHlineAesMedian As New RFunction
    Private clsGeomHlineAesLowerTercile As New RFunction
    Private clsGeomHlineAesUpperTercile As New RFunction

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private clsGeomTextLabelMeanLine As New RFunction
    Private clsAesGeomTextLabelMeanLine As New RFunction
    Private clsPasteMeanY As New RFunction
    Private clsFormatMeanY As New RFunction
    Private clsGeomTextLabelMedianLine As New RFunction
    Private clsAesGeomTextLabelMedianLine As New RFunction
    Private clsPasteMedianY As New RFunction
    Private clsFormatMedianY As New RFunction
    Private clsGeomTextLabelLowerTercileLine As New RFunction
    Private clsAesGeomTextLabelLowerTercileLine As New RFunction
    Private clsPasteLowerTercileY As New RFunction
    Private clsFormatLowerTercileY As New RFunction
    Private clsGeomTextLabelUpperTercileLine As New RFunction
    Private clsAesGeomTextLabelUpperTercileLine As New RFunction
    Private clsPasteUpperTercileY As New RFunction
    Private clsFormatUpperTercileY As New RFunction
    Private clsVarsFunction As New RFunction

    Private clsAsDate As New RFunction
    Private clsAsNumeric As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator

    Private Sub dlgPCSARainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        XAxisDataTypeCheck()
        TestOkEnabled()
        OpeningMode()
        RemoveFunction()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 118
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPICSARainfall.SetParameter(New RParameter("data", 0))
        ucrSelectorPICSARainfall.SetParameterIsrfunction()

        ucrReceiverForPICSA.SetParameter(New RParameter("y", 0))
        ucrReceiverForPICSA.Selector = ucrSelectorPICSARainfall
        ucrReceiverForPICSA.SetIncludedDataTypes({"numeric"}, True)
        ucrReceiverForPICSA.SetSelectorHeading("Numerics")
        ucrReceiverForPICSA.SetParameterIsString()
        ucrReceiverForPICSA.bWithQuotes = False

        ucrReceiverSecondYVar.SetParameter(New RParameter("yend"))
        ucrReceiverSecondYVar.Selector = ucrSelectorPICSARainfall
        ucrReceiverSecondYVar.SetIncludedDataTypes({"numeric"}, True)
        ucrReceiverSecondYVar.SetSelectorHeading("Numerics")
        ucrReceiverSecondYVar.bWithQuotes = False
        ucrReceiverSecondYVar.SetParameterIsString()

        ucrReceiverX.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrSelectorPICSARainfall
        ucrReceiverX.SetClimaticType("year")
        ucrReceiverX.bAutoFill = True
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrReceiverColourBy.SetParameter(New RParameter("colour", 2))
        ucrReceiverColourBy.Selector = ucrSelectorPICSARainfall
        ucrReceiverColourBy.SetIncludedDataTypes({"factor"})
        ucrReceiverColourBy.strSelectorHeading = "Factors"
        ucrReceiverColourBy.bWithQuotes = False
        ucrReceiverColourBy.SetParameterIsString()

        ucrReceiverFacetBy.SetParameter(New RParameter(""))
        ucrReceiverFacetBy.Selector = ucrSelectorPICSARainfall
        ucrReceiverFacetBy.SetIncludedDataTypes({"factor"})
        ucrReceiverFacetBy.strSelectorHeading = "Factors"
        ucrReceiverFacetBy.bWithQuotes = False
        ucrReceiverFacetBy.SetParameterIsString()
        ucrReceiverFacetBy.SetValuesToIgnore({"."})

        ucrReceiverIncludeStatus.SetParameter(New RParameter("left", 0))
        ucrReceiverIncludeStatus.Selector = ucrSelectorPICSARainfall
        ucrReceiverIncludeStatus.strSelectorHeading = "Factors"
        ucrReceiverIncludeStatus.bWithQuotes = False
        ucrReceiverIncludeStatus.SetParameterIsString()
        ucrReceiverIncludeStatus.SetIncludedDataTypes({"factor", "logical"})

        ucrReceiverIncludeStatus.SetLinkedDisplayControl(lblIncludeStatus)

        ucrChkIncludeStatus.SetText("Include Status")
        ucrChkIncludeStatus.AddParameterPresentCondition(True, "geom_rug")
        ucrChkIncludeStatus.AddParameterPresentCondition(False, "geom_rug", False)
        ucrChkIncludeStatus.AddToLinkedControls(ucrReceiverIncludeStatus, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPoints.SetText("Add Points")
        ucrChkPoints.AddParameterPresentCondition(True, "geom_point")
        ucrChkPoints.AddParameterPresentCondition(False, "geom_point", False)

        ucrChkLineofBestFit.SetText("Add Line of Best Fit")
        ucrChkLineofBestFit.AddParameterPresentCondition(True, "geom_smooth")
        ucrChkLineofBestFit.AddParameterPresentCondition(False, "geom_smooth", False)
        ucrChkLineofBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.SetParameter(New RParameter("se"), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetColAll, strFacetRowAll, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSave.SetPrefix("picsa_rainfall_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Store Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorPICSARainfall.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        Dim clsPanelBackgroundElementRect As New RFunction
        Dim clsXElementLabels As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsYElementLabels As New RFunction
        Dim clsPanelGridMajorElementLine As New RFunction
        Dim clsPanelGridMinorElementLine As New RFunction
        Dim clsPanelBorderElementRect As New RFunction
        Dim clsPlotElementTitle As New RFunction
        Dim clsPlotElementSubTitle As New RFunction
        Dim clsPlotElementCaption As New RFunction

        clsBaseOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsMutateFunction = New RFunction
        clsDummyFunction = New RFunction

        clsRggplotFunction = New RFunction
        clsGeomLine = New RFunction
        clsRaesFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFactorLevels = New RFunction

        clsVarsFunction = New RFunction
        clsCLimitsYContinuous = New RFunction
        clsCLimitsYDate = New RFunction
        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsAsDateYLimit = New RFunction
        clsGeomHlineMean = New RFunction
        clsGeomHlineAesMean = New RFunction
        clsMeanFunction = New RFunction
        clsRoundMeanY = New RFunction
        clsAsDateMeanY = New RFunction
        clsGeomHlineMedian = New RFunction
        clsGeomHlineAesMedian = New RFunction
        clsMedianFunction = New RFunction
        clsRoundMedianY = New RFunction
        clsAsDateMedianY = New RFunction
        clsGeomHlineLowerTercile = New RFunction
        clsGeomHlineAesLowerTercile = New RFunction
        clsLowerTercileFunction = New RFunction
        clsRoundLowerTercileY = New RFunction
        clsAsDateLowerTercileY = New RFunction
        clsGeomHlineUpperTercile = New RFunction
        clsGeomHlineAesUpperTercile = New RFunction
        clsUpperTercileFunction = New RFunction
        clsRoundUpperTercileY = New RFunction
        clsAsDateUpperTercileY = New RFunction

        clsStatRegEquationFunction = New RFunction
        clsStatsCorFunction = New RFunction
        clsGeomSmoothFunction = New RFunction
        clsPointsFunc = New RFunction
        clsGeomTextLabelMeanLine = New RFunction
        clsPasteMeanY = New RFunction
        clsFormatMeanY = New RFunction
        clsGeomTextLabelMedianLine = New RFunction
        clsPasteMedianY = New RFunction
        clsFormatMedianY = New RFunction
        clsGeomTextLabelLowerTercileLine = New RFunction
        clsPasteLowerTercileY = New RFunction
        clsFormatLowerTercileY = New RFunction
        clsGeomTextLabelUpperTercileLine = New RFunction
        clsPasteUpperTercileY = New RFunction
        clsFormatUpperTercileY = New RFunction
        clsGeomRugFunction = New RFunction
        clsFilterFunction = New RFunction
        clsEqualToOperator = New ROperator
        clsGeomSegmentFunction = New RFunction
        clsSegmentAesFunction = New RFunction
        clsGeomPoint2Function = New RFunction
        clsPoint2AesFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        clsDatePeriodOperator = New ROperator

        clsAsDate = New RFunction
        clsAsNumeric = New RFunction

        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsDummyFunction.AddParameter("upper_limit", "FALSE", iPosition:=0)
        clsDummyFunction.AddParameter("lower_limit", "FALSE", iPosition:=1)

        clsYScalecontinuousFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYContinuous, iPosition:=3)
        clsCLimitsYContinuous.SetRCommand("c")
        clsCLimitsYContinuous.AddParameter("lowerlimit", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsCLimitsYContinuous.AddParameter("upperlimit", "NA", bIncludeArgumentName:=False, iPosition:=1)

        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsYScaleDateFunction.AddParameter("date_labels", Chr(34) & "%d %b" & Chr(34), iPosition:=0)
        clsYScaleDateFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYDate, iPosition:=3)
        clsAsDateYLimit.SetRCommand("as.Date")
        clsAsDateYLimit.AddParameter("x", clsRFunctionParameter:=clsCLimitsYDate, iPosition:=0)
        clsAsDateYLimit.AddParameter("format", Chr(34) & "%Y/%B/%d" & Chr(34), iPosition:=1)

        clsCLimitsYDate.SetRCommand("c")
        clsCLimitsYDate.AddParameter("lowerlimit", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsCLimitsYDate.AddParameter("upperlimit", "NA", bIncludeArgumentName:=False, iPosition:=1)

        'TODO Not yet implemented so do not add
        'clsYScaleDateFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYDate, iPosition:=8)

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        ucrSelectorPICSARainfall.Reset()
        ucrSelectorPICSARainfall.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrReceiverForPICSA.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsGeomLine, iPosition:=3)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsAsFactorFunction = New RFunction

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsAsFactorFunction.SetRCommand("as.factor")

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")
        clsGeomLine.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        clsGeomLine.AddParameter("size", "0.8")

        clsGeomSmoothFunction.SetPackageName("ggplot2")
        clsGeomSmoothFunction.SetRCommand("geom_smooth")
        clsGeomSmoothFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunction.AddParameter("se", "FALSE", iPosition:=1)

        clsPointsFunc.SetPackageName("ggplot2")
        clsPointsFunc.SetRCommand("geom_point")
        clsPointsFunc.AddParameter("size", "2")
        clsPointsFunc.AddParameter("colour", Chr(34) & "red" & Chr(34))

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False

        clsFilterFunction.SetPackageName("dplyr")
        clsFilterFunction.SetRCommand("filter")
        clsFilterFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPICSARainfall.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0, bIncludeArgumentName:=False)
        clsFilterFunction.AddParameter("var", clsROperatorParameter:=clsEqualToOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsEqualToOperator.SetOperation("==")
        clsEqualToOperator.AddParameter("right", "FALSE", iPosition:=1, bIncludeArgumentName:=False)

        clsGeomRugFunction.SetPackageName("ggplot2")
        clsGeomRugFunction.SetRCommand("geom_rug")
        clsGeomRugFunction.AddParameter("data", clsRFunctionParameter:=clsFilterFunction, iPosition:=0)
        clsGeomRugFunction.AddParameter("sides", Chr(34) & "t" & Chr(34), iPosition:=1)
        clsGeomRugFunction.AddParameter("alpha", "0.8", iPosition:=2)
        clsGeomRugFunction.AddParameter("linewidth", "1", iPosition:=3)
        clsGeomRugFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=4)

        clsGeomSegmentFunction.SetPackageName("ggplot2")
        clsGeomSegmentFunction.SetRCommand("geom_segment")
        clsGeomSegmentFunction.AddParameter("x", clsRFunctionParameter:=clsSegmentAesFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomSegmentFunction.AddParameter("linewidth", "0.8", iPosition:=1)
        clsGeomSegmentFunction.AddParameter("lty", "2", iPosition:=2)

        clsSegmentAesFunction.SetRCommand("aes")
        clsSegmentAesFunction.AddParameter("x", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)

        clsGeomPoint2Function.SetPackageName("ggplot2")
        clsGeomPoint2Function.SetRCommand("geom_point")
        clsGeomPoint2Function.AddParameter("data", clsRFunctionParameter:=ucrSelectorPICSARainfall.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsGeomPoint2Function.AddParameter("mapping", clsRFunctionParameter:=clsPoint2AesFunction, iPosition:=1)
        clsGeomPoint2Function.AddParameter("size", "2", iPosition:=2)
        clsGeomPoint2Function.AddParameter("colour", Chr(34) & "darkgreen" & Chr(34), iPosition:=3)
        clsGeomPoint2Function.AddParameter("shape", "17", iPosition:=4)

        clsPoint2AesFunction.SetRCommand("aes")
        clsPoint2AesFunction.AddParameter("x", clsRFunctionParameter:=clsAsNumeric, iPosition:=0)

        'Mean Line
        clsGeomHlineMean.SetPackageName("ggplot2")
        clsGeomHlineMean.SetRCommand("geom_hline")
        clsGeomHlineMean.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMean, iPosition:=0)
        clsGeomHlineMean.AddParameter("size", "1.5", iPosition:=2)

        clsGeomHlineAesMean.SetPackageName("ggplot2")
        clsGeomHlineAesMean.SetRCommand("aes")
        clsGeomHlineAesMean.AddParameter("yintercept", strMeanName, iPosition:=3)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("x", "value")
        clsMeanFunction.AddParameter("na.rm", "TRUE")

        clsRoundMeanY.SetRCommand("round")

        clsAsDateMeanY.SetRCommand("as.Date")
        clsAsDateMeanY.AddParameter("x", clsRFunctionParameter:=clsRoundMeanY, iPosition:=0)
        clsAsDateMeanY.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        'Regression Equation line
        clsStatRegEquationFunction.SetPackageName("ggpubr")
        clsStatRegEquationFunction.SetRCommand("stat_regline_equation")
        clsStatRegEquationFunction.AddParameter("label.x.npc", Chr(34) & "left" & Chr(34), iPosition:=0)
        clsStatRegEquationFunction.AddParameter("label.y.npc", Chr(34) & "bottom" & Chr(34), iPosition:=1)

        'Significance level
        clsStatsCorFunction.SetPackageName("ggpubr")
        clsStatsCorFunction.SetRCommand("stat_cor")
        clsStatsCorFunction.AddParameter("label.x.npc", Chr(34) & "left" & Chr(34), iPosition:=0)
        clsStatsCorFunction.AddParameter("label.y.npc", Chr(34) & "top" & Chr(34), iPosition:=1)

        ' Mean Line Label
        clsGeomTextLabelMeanLine.SetPackageName("ggplot2")
        clsGeomTextLabelMeanLine.SetRCommand("geom_label")
        clsGeomTextLabelMeanLine.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextLabelMeanLine, iPosition:=0)
        clsGeomTextLabelMeanLine.AddParameter("hjust", "0", iPosition:=9)
        clsGeomTextLabelMeanLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsAesGeomTextLabelMeanLine.SetPackageName("ggplot2")
        clsAesGeomTextLabelMeanLine.SetRCommand("aes")
        clsAesGeomTextLabelMeanLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAesGeomTextLabelMeanLine.AddParameter("y", strMeanName, iPosition:=2)
        clsAesGeomTextLabelMeanLine.AddParameter("label", clsRFunctionParameter:=clsPasteMeanY, iPosition:=3)

        clsPasteMeanY.SetRCommand("paste")
        clsPasteMeanY.AddParameter("0", Chr(34) & "Mean:" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteMeanY.AddParameter("1", clsRFunctionParameter:=clsRoundMeanY, bIncludeArgumentName:=False, iPosition:=1)

        clsFormatMeanY.SetRCommand("format")
        clsFormatMeanY.AddParameter("x", strMeanName, iPosition:=0)
        clsFormatMeanY.AddParameter("format", Chr(34) & "%d %b" & Chr(34), iPosition:=1)

        'Median Line
        clsGeomHlineMedian.SetPackageName("ggplot2")
        clsGeomHlineMedian.SetRCommand("geom_hline")
        clsGeomHlineMedian.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMedian, iPosition:=0)
        clsGeomHlineMedian.AddParameter("size", "1.5", iPosition:=2)

        clsGeomHlineAesMedian.SetPackageName("ggplot2")
        clsGeomHlineAesMedian.SetRCommand("aes")
        clsGeomHlineAesMedian.AddParameter("yintercept", strMedianName, iPosition:=3)

        clsMedianFunction.SetRCommand("median")
        clsMedianFunction.AddParameter("x", "value")
        clsMedianFunction.AddParameter("na.rm", "TRUE")

        clsRoundMedianY.SetRCommand("round")

        clsAsDateMedianY.SetRCommand("as.Date")
        clsAsDateMedianY.AddParameter("x", clsRFunctionParameter:=clsRoundMedianY, iPosition:=0)
        clsAsDateMedianY.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        ' Median Line Label
        clsGeomTextLabelMedianLine.SetPackageName("ggplot2")
        clsGeomTextLabelMedianLine.SetRCommand("geom_label")
        clsGeomTextLabelMedianLine.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextLabelMedianLine, iPosition:=0)
        clsGeomTextLabelMedianLine.AddParameter("hjust", "0", iPosition:=9)
        clsGeomTextLabelMedianLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsAesGeomTextLabelMedianLine.SetPackageName("ggplot2")
        clsAesGeomTextLabelMedianLine.SetRCommand("aes")
        clsAesGeomTextLabelMedianLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAesGeomTextLabelMedianLine.AddParameter("y", strMedianName, iPosition:=2)
        clsAesGeomTextLabelMedianLine.AddParameter("label", clsRFunctionParameter:=clsPasteMedianY, iPosition:=3)

        clsPasteMedianY.SetRCommand("paste")
        clsPasteMedianY.AddParameter("0", Chr(34) & "Median:" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteMedianY.AddParameter("1", clsRFunctionParameter:=clsRoundMedianY, bIncludeArgumentName:=False, iPosition:=1)

        clsFormatMedianY.SetRCommand("format")
        clsFormatMedianY.AddParameter("x", strMedianName, iPosition:=0)
        clsFormatMedianY.AddParameter("format", Chr(34) & "%d %b" & Chr(34), iPosition:=1)

        'Lower Tercile Line
        clsGeomHlineLowerTercile.SetPackageName("ggplot2")
        clsGeomHlineLowerTercile.SetRCommand("geom_hline")
        clsGeomHlineLowerTercile.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesLowerTercile, iPosition:=0)
        clsGeomHlineLowerTercile.AddParameter("size", "1.5", iPosition:=2)

        clsGeomHlineAesLowerTercile.SetPackageName("ggplot2")
        clsGeomHlineAesLowerTercile.SetRCommand("aes")
        clsGeomHlineAesLowerTercile.AddParameter("yintercept", strLowerTercileName, iPosition:=3)

        clsLowerTercileFunction.SetRCommand("quantile")
        clsLowerTercileFunction.AddParameter("x", "value", iPosition:=0)
        clsLowerTercileFunction.AddParameter("probs", "1/3", iPosition:=1)
        clsLowerTercileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)

        clsRoundLowerTercileY.SetRCommand("round")

        clsAsDateLowerTercileY.SetRCommand("as.Date")
        clsAsDateLowerTercileY.AddParameter("x", clsRFunctionParameter:=clsRoundLowerTercileY, iPosition:=0)
        clsAsDateLowerTercileY.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        ' Lower Tercile Line Label
        clsGeomTextLabelLowerTercileLine.SetPackageName("ggplot2")
        clsGeomTextLabelLowerTercileLine.SetRCommand("geom_label")
        clsGeomTextLabelLowerTercileLine.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextLabelLowerTercileLine, iPosition:=0)
        clsGeomTextLabelLowerTercileLine.AddParameter("hjust", "0", iPosition:=9)
        clsGeomTextLabelLowerTercileLine.AddParameter("vjust", "1.2", iPosition:=10)

        clsAesGeomTextLabelLowerTercileLine.SetPackageName("ggplot2")
        clsAesGeomTextLabelLowerTercileLine.SetRCommand("aes")
        clsAesGeomTextLabelLowerTercileLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAesGeomTextLabelLowerTercileLine.AddParameter("y", strLowerTercileName, iPosition:=2)
        clsAesGeomTextLabelLowerTercileLine.AddParameter("label", clsRFunctionParameter:=clsPasteLowerTercileY, iPosition:=3)

        clsPasteLowerTercileY.SetRCommand("paste")
        clsPasteLowerTercileY.AddParameter("0", Chr(34) & "33%:" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteLowerTercileY.AddParameter("1", clsRFunctionParameter:=clsRoundLowerTercileY, bIncludeArgumentName:=False, iPosition:=1)

        clsFormatLowerTercileY.SetRCommand("format")
        clsFormatLowerTercileY.AddParameter("x", strLowerTercileName, iPosition:=0)
        clsFormatLowerTercileY.AddParameter("format", Chr(34) & "%d %b" & Chr(34), iPosition:=1)

        'Upper Tercile Line
        clsGeomHlineUpperTercile.SetPackageName("ggplot2")
        clsGeomHlineUpperTercile.SetRCommand("geom_hline")
        clsGeomHlineUpperTercile.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesUpperTercile, iPosition:=0)
        clsGeomHlineUpperTercile.AddParameter("size", "1.5", iPosition:=2)

        clsGeomHlineAesUpperTercile.SetPackageName("ggplot2")
        clsGeomHlineAesUpperTercile.SetRCommand("aes")
        clsGeomHlineAesUpperTercile.AddParameter("yintercept", strUpperTercileName, iPosition:=3)

        clsUpperTercileFunction.SetRCommand("quantile")
        clsUpperTercileFunction.AddParameter("x", "value", iPosition:=0)
        clsUpperTercileFunction.AddParameter("probs", "2/3", iPosition:=1)
        clsUpperTercileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)

        clsRoundUpperTercileY.SetRCommand("round")

        clsAsDateUpperTercileY.SetRCommand("as.Date")
        clsAsDateUpperTercileY.AddParameter("x", clsRFunctionParameter:=clsRoundUpperTercileY, iPosition:=0)
        clsAsDateUpperTercileY.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        'Upper Tercile Line Label
        clsGeomTextLabelUpperTercileLine.SetPackageName("ggplot2")
        clsGeomTextLabelUpperTercileLine.SetRCommand("geom_label")
        clsGeomTextLabelUpperTercileLine.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextLabelUpperTercileLine, iPosition:=0)
        clsGeomTextLabelUpperTercileLine.AddParameter("hjust", "0", iPosition:=9)
        clsGeomTextLabelUpperTercileLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsAesGeomTextLabelUpperTercileLine.SetPackageName("ggplot2")
        clsAesGeomTextLabelUpperTercileLine.SetRCommand("aes")
        clsAesGeomTextLabelUpperTercileLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAesGeomTextLabelUpperTercileLine.AddParameter("y", strUpperTercileName, iPosition:=2)
        clsAesGeomTextLabelUpperTercileLine.AddParameter("label", clsRFunctionParameter:=clsPasteUpperTercileY, iPosition:=3)

        clsPasteUpperTercileY.SetRCommand("paste")
        clsPasteUpperTercileY.AddParameter("0", Chr(34) & "67%:" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsPasteUpperTercileY.AddParameter("1", clsRFunctionParameter:=clsRoundUpperTercileY, bIncludeArgumentName:=False, iPosition:=1)

        clsFormatUpperTercileY.SetRCommand("format")
        clsFormatUpperTercileY.AddParameter("x", strUpperTercileName, iPosition:=0)
        clsFormatUpperTercileY.AddParameter("format", Chr(34) & "%d %b" & Chr(34), iPosition:=1)

        If dctThemeFunctions.TryGetValue("panel.background", clsPanelBackgroundElementRect) Then
            clsPanelBackgroundElementRect.AddParameter("colour", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("fill", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("size", "0.5")
            clsPanelBackgroundElementRect.AddParameter("linetype", Chr(34) & "solid" & Chr(34))
            clsThemeFunction.AddParameter("panel.background", clsRFunctionParameter:=clsPanelBackgroundElementRect)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.major", clsPanelGridMajorElementLine) Then
            clsPanelGridMajorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMajorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsPanelGridMajorElementLine.AddParameter("size", 1)
            clsThemeFunction.AddParameter("panel.grid.major", clsRFunctionParameter:=clsPanelGridMajorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.minor", clsPanelGridMinorElementLine) Then
            clsPanelGridMinorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMinorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsPanelGridMinorElementLine.AddParameter("size", 1)
            clsThemeFunction.AddParameter("panel.grid.minor", clsRFunctionParameter:=clsPanelGridMinorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.border", clsPanelBorderElementRect) Then
            clsPanelBorderElementRect.AddParameter("colour", Chr(34) & "black" & Chr(34))
            clsPanelBorderElementRect.AddParameter("fill", Chr(34) & "NA" & Chr(34))
            clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels) Then
            clsXElementLabels.AddParameter("angle", "90")
            clsXElementLabels.AddParameter("vjust", "0.4")
            clsXElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle) Then
            clsXElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.y", clsYElementLabels) Then
            clsYElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsYElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle) Then
            clsYElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("title", clsPlotElementTitle) Then
            clsPlotElementTitle.AddParameter("size", 20)
            clsThemeFunction.AddParameter("title", clsRFunctionParameter:=clsPlotElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("sub.title", clsPlotElementSubTitle) Then
            clsPlotElementSubTitle.AddParameter("size", 15)
            clsThemeFunction.AddParameter("plot.subtitle", clsRFunctionParameter:=clsPlotElementSubTitle)
        End If

        If dctThemeFunctions.TryGetValue("caption", clsPlotElementCaption) Then
            clsPlotElementCaption.AddParameter("size", 8)
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaption)
        End If

        clsFactorLevels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels")

        clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXLabsFunction)
        clsXLabsFunction.AddParameter("label", Chr(34) & Chr(34))

        clsBaseOperator.AddParameter("ylab", clsRFunctionParameter:=clsYLabsFunction)
        clsYLabsFunction.AddParameter("label", Chr(34) & Chr(34))

        clsAsDate.SetRCommand("as.Date")
        clsAsDate.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        clsDatePeriodOperator.SetOperation(" ")
        clsDatePeriodOperator.AddParameter("left", "1", iPosition:=0)
        clsDatePeriodOperator.AddParameter("right", "months", iPosition:=1)
        clsDatePeriodOperator.bSpaceAroundOperation = False
        clsDatePeriodOperator.bToScriptAsRString = True

        clsAsNumeric.SetRCommand("as.numeric")

        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)
        clsRaesFunction.AddParameter("y", ucrReceiverForPICSA.GetVariableNames, iPosition:=2)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsPointsFunc, iPosition:=4)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsAsDate, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsLowerTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsUpperTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverForPICSA.AddAdditionalCodeParameterPair(clsSegmentAesFunction, New RParameter("y", 1), iAdditionalPairNo:=6)

        ucrReceiverSecondYVar.AddAdditionalCodeParameterPair(clsPoint2AesFunction, New RParameter("y", 1), iAdditionalPairNo:=1)

        ucrSelectorPICSARainfall.SetRCode(clsPipeOperator, bReset)
        ucrReceiverForPICSA.SetRCode(clsRaesFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrReceiverX.SetRCode(clsAsNumeric, bReset)
        ucrChkLineofBestFit.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunction, bReset)
        ucrChkIncludeStatus.SetRCode(clsBaseOperator, bReset)
        ucrReceiverIncludeStatus.SetRCode(clsEqualToOperator, bReset)
        ucrReceiverSecondYVar.SetRCode(clsSegmentAesFunction, bReset)

        If bReset Then
            AutoFacetStation()
        End If
    End Sub

    Private Sub TestOkEnabled()
        If (ucrReceiverForPICSA.IsEmpty OrElse ucrReceiverX.IsEmpty) OrElse (ucrChkIncludeStatus.Checked AndAlso ucrReceiverIncludeStatus.IsEmpty) OrElse Not ucrSave.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        UpdateParameters()
        TestOkEnabled()
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then

                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) Then

                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetOperator.RemoveParameterByName("var1")
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucrReceiverFacetBy.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucrReceiverFacetBy.ChangeParameterName("var1")
                ucrReceiverFacetBy.SetRCode(clsFacetOperator)
            Case strFacetCol, strFacetColAll
                ucrReceiverFacetBy.ChangeParameterName("col" & ucrInputStation.Name)
                clsVarsFunction.AddParameter("var", ucrReceiverFacetBy.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)

            Case strFacetRow, strFacetRowAll
                ucrReceiverFacetBy.ChangeParameterName("row" & ucrInputStation.Name)
                clsVarsFunction.AddParameter("var", ucrReceiverFacetBy.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
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
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If
        clsBaseOperator.RemoveParameterByName("facets")
        clsFacetFunction.RemoveParameterByName("facets")
        clsFacetFunction.RemoveParameterByName("rows")
        clsFacetFunction.RemoveParameterByName("cols")
        If Not ucrReceiverFacetBy.IsEmpty Then
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
            End Select
        End If

        If bWrap Then
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)
        ElseIf bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsVarsFunction)
        ElseIf bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsVarsFunction)
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll OrElse bWrap Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If

        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If
    End Sub

    'add more functions 
    Private Sub cmdPICSAOptions_Click(sender As Object, e As EventArgs) Handles cmdPICSAOptions.Click
        sdgPICSARainfallGraph.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewPipeOperator:=clsPipeOperator, clsNewStatRegEquation:=clsStatRegEquationFunction, clsNewStatsCorFunction:=clsStatsCorFunction,
                                       dctNewThemeFunctions:=dctThemeFunctions, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewDummyFunction:=clsDummyFunction,
                                       clsNewXScaleContinuousFunction:=clsXScalecontinuousFunction, clsNewYScaleContinuousFunction:=clsYScalecontinuousFunction,
                                       clsNewGeomhlineMean:=clsGeomHlineMean, clsNewGeomhlineMedian:=clsGeomHlineMedian, clsNewGeomhlineLowerTercile:=clsGeomHlineLowerTercile,
                                       clsNewGeomhlineUpperTercile:=clsGeomHlineUpperTercile, clsNewXLabsFunction:=clsXLabsFunction, clsNewYLabsFunction:=clsYLabsFunction,
                                       clsNewRaesFunction:=clsRaesFunction, clsNewAsDate:=clsAsDate, clsNewAsDateYLimit:=clsAsDateYLimit, clsNewAsNumeric:=clsAsNumeric, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                                       clsNewDatePeriodOperator:=clsDatePeriodOperator, clsNewGeomTextLabelMeanLine:=clsGeomTextLabelMeanLine, clsNewRoundMeanY:=clsRoundMeanY, clsNewPasteMeanY:=clsPasteMeanY,
                                       clsNewGeomTextLabelMedianLine:=clsGeomTextLabelMedianLine, clsNewRoundMedianY:=clsRoundMedianY, clsNewPasteMedianY:=clsPasteMedianY, clsNewGeomTextLabelLowerTercileLine:=clsGeomTextLabelLowerTercileLine,
                                       clsNewRoundLowerTercileY:=clsRoundLowerTercileY, clsNewPasteLowerTercileY:=clsPasteLowerTercileY, clsNewGeomTextLabelUpperTercileLine:=clsGeomTextLabelUpperTercileLine, clsNewRoundUpperTercileY:=clsRoundUpperTercileY,
                                       clsNewPasteUpperTercileY:=clsPasteUpperTercileY, strXAxisType:=ucrReceiverX.strCurrDataType, clsNewMutateFunction:=clsMutateFunction, clsNewMeanFunction:=clsMeanFunction, clsNewMedianFunction:=clsMedianFunction,
                                       clsNewLowerTercileFunction:=clsLowerTercileFunction, clsNewUpperTercileFunction:=clsUpperTercileFunction, clsNewAsDateMeanY:=clsAsDateMeanY, clsNewAsDateMedianY:=clsAsDateMedianY, clsNewAsDateLowerTercileY:=clsAsDateLowerTercileY,
                                       clsNewAsDateUpperTercileY:=clsAsDateUpperTercileY, clsNewFormatMeanY:=clsFormatMeanY, clsNewFormatMedianY:=clsFormatMedianY, clsNewFormatLowerTercileY:=clsFormatLowerTercileY, clsNewFormatUpperTercileY:=clsFormatUpperTercileY, bReset:=bResetSubdialog)
        sdgPICSARainfallGraph.ShowDialog()
        AddRemoveGroupBy()
        bResetSubdialog = False
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSave.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrReceiverForPICSA.ControlContentsChanged, ucrChkIncludeStatus.ControlContentsChanged, ucrReceiverIncludeStatus.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub RemoveFunction()
        Select Case enumPICSAMode
            Case PICSAMode.General
                clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
            Case PICSAMode.Rainfall
                clsBaseOperator.RemoveParameterByName("geom_smooth")
                clsBaseOperator.RemoveParameterByName("stat_regline")
                clsBaseOperator.RemoveParameterByName("stat_cor")
                clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
            Case PICSAMode.Temperature
                clsBaseOperator.RemoveParameterByName("hlinemedian")
                clsBaseOperator.RemoveParameterByName("annotate_median")
                clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPICSARainfall.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                clsBaseOperator.RemoveParameterByName("hlinemean")
                clsBaseOperator.RemoveParameterByName("annotate_mean")
                clsBaseOperator.RemoveParameterByName("hlinelowertercile")
                clsBaseOperator.RemoveParameterByName("hlineuppertercile")
                clsBaseOperator.RemoveParameterByName("annotate_lower_tercile")
                clsBaseOperator.RemoveParameterByName("annotate_upper_tercile")
        End Select
    End Sub


    Private Sub ucrFactorOptionalReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColourBy.ControlValueChanged
        'TODO this should run when levels of factor >1
        If Not ucrReceiverColourBy.IsEmpty Then
            clsGeomLine.RemoveParameterByName("colour")
        Else
            clsGeomLine.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        End If
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged
        XAxisDataTypeCheck()
    End Sub

    Private Sub XAxisDataTypeCheck()
        If Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor") Then
            clsGeomLine.AddParameter("group", 1)
            clsBaseOperator.RemoveParameterByName("scale_x_continuous")
        Else
            clsGeomLine.RemoveParameterByName("group")
        End If
    End Sub

    Private Sub OpeningMode()
        Select Case enumPICSAMode
            Case PICSAMode.General
                ucrChkLineofBestFit.Visible = True
                ucrChkWithSE.Visible = True
                Me.Text = "PICSA General Graphs"
                ucrBase.iHelpTopicID = 521
            Case PICSAMode.Rainfall
                ucrChkLineofBestFit.Visible = False
                ucrChkWithSE.Visible = False
                Me.Text = "PICSA Rainfall Graphs"
            Case PICSAMode.Temperature
                ucrChkLineofBestFit.Visible = True
                ucrChkWithSE.Visible = True
                Me.Text = "PICSA Temperature Graphs"
                ucrBase.iHelpTopicID = 479
        End Select
    End Sub


    Private Sub YAxisDataTypeCheck()
        If Not ucrReceiverForPICSA.IsEmpty Then
            clsGeomLine.AddParameter("group", 0)
        Else
            clsGeomLine.RemoveParameterByName("group")
        End If
    End Sub

    Private Sub ucrReceiverFacetBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacetBy.ControlValueChanged, ucrReceiverColourBy.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub AutoFacetStation()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If ucrSelectorPICSARainfall.CurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver = ucrSelectorPICSARainfall.CurrentReceiver
        End If
        ucrReceiverFacetBy.AddItemsWithMetadataProperty(ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
        AddRemoveGroupBy()
    End Sub

    Private Sub ucrVariablesAsFactorForPicsa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColourBy.ControlValueChanged, ucrReceiverFacetBy.ControlValueChanged, ucrReceiverForPICSA.ControlValueChanged
        AddRemoveGroupBy()
        YAxisDataTypeCheck()
    End Sub

    Private Sub ucrSelectorPICSARainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPICSARainfall.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
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
                        GetParameterValue(clsFacetOperator)
                End Select
            End If
            If clsRaesFunction.ContainsParameter("colour") Then
                clsGroupByFunction.AddParameter("colour",
                                            ucrReceiverColourBy.GetVariableNames(bWithQuotes:=False),
                                            bIncludeArgumentName:=False,
                                            iPosition:=0)
            End If
            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by",
                                         clsRFunctionParameter:=clsGroupByFunction,
                                         iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If
        SetPipeAssignTo()
    End Sub


    Private Sub SetPipeAssignTo()
        If ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub toolStripMenuItemLineOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemLineOptions.Click
        openSdgLayerOptions(clsGeomLine)
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorPICSARainfall,
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
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value") Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrReceiverForPICSA.Clear()
                Else
                    ucrReceiverForPICSA.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrReceiverColourBy.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction, clsNewLabsFunction:=clsLabsFunction,
                          clsNewFacetFunction:=clsFacetFunction, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, dctNewThemeFunctions:=dctThemeFunctions,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrSelectorPICSARainfall, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'AddRemoveGroupByAndHlines()
    End Sub


    Private Sub PlotOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotOptionsToolStripMenuItem.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction, clsNewLabsFunction:=clsLabsFunction,
                          clsNewFacetFunction:=clsFacetFunction, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, dctNewThemeFunctions:=dctThemeFunctions,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrSelectorPICSARainfall, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'AddRemoveGroupByAndHlines()
    End Sub

    Private Sub ucrChkLineofBestFit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLineofBestFit.ControlValueChanged
        If ucrChkLineofBestFit.Checked Then
            clsBaseOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsGeomSmoothFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_smooth")
        End If
    End Sub

    Private Sub ucrChkPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPoints.ControlValueChanged
        If ucrChkPoints.Checked Then
            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsPointsFunc, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_point")
        End If
    End Sub

    Private Sub toolStripMenuItemPointOption_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemPointOption.Click
        openSdgLayerOptions(clsPointsFunc)
    End Sub

    Private Sub ucrChkIncludeStatus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeStatus.ControlValueChanged
        If ucrChkIncludeStatus.Checked Then
            ucrReceiverIncludeStatus.SetMeAsReceiver()
            clsEqualToOperator.AddParameter("left", ucrReceiverIncludeStatus.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("geom_rug", clsRFunctionParameter:=clsGeomRugFunction, iPosition:=6)
        Else
            clsBaseOperator.RemoveParameterByName("geom_rug")
        End If
    End Sub

    Private Sub ucrReceiverSecondYVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondYVar.ControlValueChanged
        If Not ucrReceiverSecondYVar.IsEmpty Then
            clsPoint2AesFunction.AddParameter("y", ucrReceiverSecondYVar.GetVariableNames(bWithQuotes:=False), , iPosition:=1)
            clsBaseOperator.AddParameter("geom_segment", clsRFunctionParameter:=clsGeomSegmentFunction, iPosition:=1, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("geom_point2", clsRFunctionParameter:=clsGeomPoint2Function, iPosition:=2, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("geom_segment")
            clsBaseOperator.RemoveParameterByName("geom_point2")
        End If
    End Sub

End Class
