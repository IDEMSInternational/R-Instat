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
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private clsPointsFunc As New RFunction
    Private clsPointsParam As New RParameter
    Private clsYLabsFunction, clsXLabsFunction, clsLabsFunction As RFunction
    Private clsFactorLevels As New RFunction

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

    Private strMeanName As String = ".mean_y"
    Private strMedianName As String = ".median_y"
    Private strLowerTercileName As String = ".lower_ter_y"
    Private strUpperTercileName As String = ".upper_ter_y"

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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 118
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPICSARainfall.SetParameter(New RParameter("data", 0))
        ucrSelectorPICSARainfall.SetParameterIsrfunction()

        ucrVariablesAsFactorForPicsa.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorForPicsa.SetFactorReceiver(ucrReceiverColourBy)
        ucrVariablesAsFactorForPicsa.Selector = ucrSelectorPICSARainfall
        ucrVariablesAsFactorForPicsa.SetIncludedDataTypes({"numeric"}, True)
        ucrVariablesAsFactorForPicsa.SetSelectorHeading("Numerics")
        ucrVariablesAsFactorForPicsa.SetParameterIsString()
        ucrVariablesAsFactorForPicsa.bWithQuotes = False

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrSelectorPICSARainfall
        ucrReceiverX.SetClimaticType("year")
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

        ucrChkPoints.SetText("Add Points")
        ucrChkPoints.AddParameterPresentCondition(True, "points")
        ucrChkPoints.AddParameterPresentCondition(False, "points", False)
        clsPointsFunc.SetPackageName("ggplot2")
        clsPointsFunc.SetRCommand("geom_point")
        clsPointsParam.SetArgumentName("points")
        clsPointsParam.SetArgument(clsPointsFunc)
        clsPointsParam.Position = 3
        clsPointsFunc.AddParameter("size", "3")
        clsPointsFunc.AddParameter("colour", Chr(34) & "red" & Chr(34))
        ucrChkPoints.SetParameter(clsPointsParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrSave.SetPrefix("picsa_rainfall_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
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

        clsRggplotFunction = New RFunction
        clsGeomLine = New RFunction
        clsRaesFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFactorLevels = New RFunction

        clsCLimitsYContinuous = New RFunction
        clsCLimitsYDate = New RFunction

        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

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

        ucrInputStation.SetName(strNone)
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
        ucrVariablesAsFactorForPicsa.SetMeAsReceiver()
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
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsGeomLine, iPosition:=2)

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
        clsBaseOperator.AddParameter(clsPointsParam)


        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)


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

        clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsAsDate, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsLowerTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsUpperTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=5)

        ucrSelectorPICSARainfall.SetRCode(clsPipeOperator, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrVariablesAsFactorForPicsa.SetRCode(clsAsNumeric, bReset)

        If bReset Then
            AutoFacetStation()
        End If
    End Sub

    Private Sub TestOkEnabled()
        If (ucrVariablesAsFactorForPicsa.IsEmpty OrElse ucrReceiverX.IsEmpty) OrElse Not ucrSave.IsComplete Then
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

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForPicsa.bSingleVariable Then
            'Added this because this sub is called on sed defaults and  it over writes the enabled property 
            cmdPICSAOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            'cmdPICSAOptions.Enabled = False
            cmdOptions.Enabled = False
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
        clsFacetOperator.RemoveParameterByName("wrap" & ucrInputStation.Name)
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucrReceiverFacetBy.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucrReceiverFacetBy.ChangeParameterName("wrap" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetOperator)
            Case strFacetCol
                ucrReceiverFacetBy.ChangeParameterName("col" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucrReceiverFacetBy.ChangeParameterName("row" & ucrInputStation.Name)
                ucrReceiverFacetBy.SetRCode(clsFacetRowOp)
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
        If Not ucrReceiverFacetBy.IsEmpty Then
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
            clsFacetOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucrVariablesAsFactorForPicsa_ControlValueChanged() Handles ucrVariablesAsFactorForPicsa.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    'add more functions 
    Private Sub cmdPICSAOptions_Click(sender As Object, e As EventArgs) Handles cmdPICSAOptions.Click
        sdgPICSARainfallGraph.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewPipeOperator:=clsPipeOperator, dctNewThemeFunctions:=dctThemeFunctions, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewXScaleContinuousFunction:=clsXScalecontinuousFunction, clsNewYScaleContinuousFunction:=clsYScalecontinuousFunction, clsNewGeomhlineMean:=clsGeomHlineMean, clsNewGeomhlineMedian:=clsGeomHlineMedian, clsNewGeomhlineLowerTercile:=clsGeomHlineLowerTercile, clsNewGeomhlineUpperTercile:=clsGeomHlineUpperTercile, clsNewXLabsFunction:=clsXLabsFunction, clsNewYLabsFunction:=clsYLabsFunction, clsNewRaesFunction:=clsRaesFunction, clsNewAsDate:=clsAsDate, clsNewAsDateYLimit:=clsAsDateYLimit, clsNewAsNumeric:=clsAsNumeric, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewDatePeriodOperator:=clsDatePeriodOperator, clsNewGeomTextLabelMeanLine:=clsGeomTextLabelMeanLine, clsNewRoundMeanY:=clsRoundMeanY, clsNewPasteMeanY:=clsPasteMeanY, clsNewGeomTextLabelMedianLine:=clsGeomTextLabelMedianLine, clsNewRoundMedianY:=clsRoundMedianY, clsNewPasteMedianY:=clsPasteMedianY, clsNewGeomTextLabelLowerTercileLine:=clsGeomTextLabelLowerTercileLine, clsNewRoundLowerTercileY:=clsRoundLowerTercileY, clsNewPasteLowerTercileY:=clsPasteLowerTercileY, clsNewGeomTextLabelUpperTercileLine:=clsGeomTextLabelUpperTercileLine, clsNewRoundUpperTercileY:=clsRoundUpperTercileY, clsNewPasteUpperTercileY:=clsPasteUpperTercileY, strXAxisType:=ucrReceiverX.strCurrDataType, clsNewMutateFunction:=clsMutateFunction, clsNewMeanFunction:=clsMeanFunction, clsNewMedianFunction:=clsMedianFunction, clsNewLowerTercileFunction:=clsLowerTercileFunction, clsNewUpperTercileFunction:=clsUpperTercileFunction, clsNewAsDateMeanY:=clsAsDateMeanY, clsNewAsDateMedianY:=clsAsDateMedianY, clsNewAsDateLowerTercileY:=clsAsDateLowerTercileY, clsNewAsDateUpperTercileY:=clsAsDateUpperTercileY, clsNewFormatMeanY:=clsFormatMeanY, clsNewFormatMedianY:=clsFormatMedianY, clsNewFormatLowerTercileY:=clsFormatLowerTercileY, clsNewFormatUpperTercileY:=clsFormatUpperTercileY, bReset:=bResetSubdialog)
        sdgPICSARainfallGraph.ShowDialog()
        AddRemoveGroupBy()
        bResetSubdialog = False
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

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsGeomLine, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorPICSARainfall, bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForPicsa.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForPicsa.Clear()
                Else ucrVariablesAsFactorForPicsa.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrReceiverColourBy.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForPicsa.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
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

    Private Sub ucrVariablesAsFactorForPicsa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForPicsa.ControlValueChanged, ucrReceiverColourBy.ControlValueChanged, ucrReceiverFacetBy.ControlValueChanged
        AddRemoveGroupBy()
    End Sub

    Private Sub ucrSelectorPICSARainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPICSARainfall.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub AddRemoveGroupBy()
        Dim i As Integer = 0

        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                For Each clsTempParam As RParameter In clsFacetOperator.clsParameters
                    If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                        clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                        i = i + 1
                    End If
                Next
            End If

            If clsRaesFunction.ContainsParameter("colour") Then
                clsGroupByFunction.AddParameter(i, ucrReceiverColourBy.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=0)
                i = i + 1
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
        If ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorPICSARainfall.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub
End Class
