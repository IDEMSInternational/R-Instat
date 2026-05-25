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
Imports System.Text.RegularExpressions

Public Class dlgClimograph
    Private isFilling As Boolean = False
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsGgwalterliethFunction, clsDummyFunction As RFunction
    Private clsBaseOperator As New ROperator
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"
    Private ReadOnly strFacetRowStationAll As String = "Facet Row + O"
    Private ReadOnly strFacetColStationAll As String = "Facet Col + O"
    Private ReadOnly strFacetRowBarAll As String = "Facet Row + O"
    Private ReadOnly strFacetColBarAll As String = "Facet Col + O"
    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap1 As String = "Facet Wrap"
    Private ReadOnly strFacetRow1 As String = "Facet Row"
    Private ReadOnly strFacetCol1 As String = "Facet Column"
    Private ReadOnly strNone1 As String = "None"
    Private ReadOnly strFacetWrap2 As String = "Facet Wrap"
    Private ReadOnly strFacetRow2 As String = "Facet Row"
    Private ReadOnly strFacetCol2 As String = "Facet Column"
    Private ReadOnly strNone2 As String = "None"
    Private clsFacetFunction As New RFunction
    Private clsGroupByFunction As New RFunction
    Private clsGeomBarFunction As New RFunction
    Private clsGeomLineStarFunction As New RFunction
    Private clsGeomLineStar1Function As New RFunction
    Private clsRggplotFunction As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsAesLineStarFunction As New RFunction
    Private clsAesLineStar1Function As New RFunction
    Private clsFacetFunction1 As New RFunction
    Private clsGroupByFunction1 As New RFunction
    Private clsFacetFunction2 As New RFunction
    Private clsGroupByFunction2 As New RFunction
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsLabFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsSecondaryAxisFunction As New RFunction
    Private clsSecondaryAxis1Function As New RFunction
    Private clsSecondaryAxis2Function As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsXScalecontinuousFunction As New RFunction
    Private clsXScalediscreteFunction As New RFunction
    Private clsScaleycontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsGeomRibbonFunction As New RFunction
    Private clsGeomRibbon1Function As New RFunction
    Private clsGeomTileFunction As New RFunction
    Private clsAesGeomRibbonFunction As New RFunction
    Private clsAesGeomRibbon1Function As New RFunction
    Private clsGeomTextBarFunction As New RFunction
    Private clsGeomTextTmaxFunction As New RFunction
    Private clsGeomTextTminFunction As New RFunction
    Private clsGeomTextTmaxStarFunction As New RFunction
    Private clsGeomTextTminStarFunction As New RFunction
    Private clsRoundBarFunction As New RFunction
    Private clsGeomBarTmaxFunction As New RFunction
    Private clsAesTmaxBarFunction As New RFunction
    Private clsAesTminBarFunction As New RFunction
    Private clsGeomBarTminFunction As New RFunction
    Private clsRoundTmaxFunction As New RFunction
    Private clsRoundTminFunction As New RFunction
    Private clsAesGeomTextBarFunction As New RFunction
    Private clsAesGeomTextTmaxFunction As New RFunction
    Private clsAesGeomTextStarTmaxFunction As New RFunction
    Private clsAesGeomTextTminFunction As New RFunction
    Private clsAesGeomTextStarTminFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsMaxFunction As New RFunction
    Private clsMax1Function As New RFunction
    Private clsVectorFunction As New RFunction
    Private clsGetObjectDataFunction, clsGetDataFrameFunction, clsColourPaletteFunction, clsLocalRaesFunction, clsFillBrewerFunction, clsScalefillDistillerFunction As New RFunction
    Private clsStarOperator As New ROperator
    Private clsStar1Operator As New ROperator
    Private clsDivideOperator As New ROperator
    Private clsDivide1Operator As ROperator
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp1 As New ROperator
    Private clsFacetColOp1 As New ROperator
    Private clsPipeOperator1 As New ROperator
    Private clsFacetRowOp2 As New ROperator
    Private clsFacetColOp2 As New ROperator
    Private clsPipeOperator2 As New ROperator
    Private clsFacetOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False
    Private bUpdateComboOptions1 As Boolean = True
    Private bUpdateComboOptions2 As Boolean = True
    Private bUpdatingParameters1 As Boolean = False
    Private bUpdatingParameters2 As Boolean = False
    Private strTemBar As String = "Tem"
    Private strRainBar As String = "Rain"
    Private clsPlus1Operator, clsPlus2Operator, clsPlus3Operator, clsPlus5Operator As New ROperator
    Private clsPlus6Operator, clsPlus7Operator, clsPlus8Operator, clsPlus9Operator, clsPlus10Operator, clsPlus11Operator As New ROperator
    Private clsRainBarFunction, clsTmaxBarFunction, clsTminBarFunction, clsLabsRainFunction, clsLabsTempFunction As New RFunction
    Private clsRainBarTextFunction, clsTmaxBarTextFunction, clsTminBarTextFunction, clsRainGgplotFunction, clsTemGgplotFunction As New RFunction
    Private clsAesTmaxBarFunction1, clsAesTminBarFunction1, clsAesTemGgplotFunction, clsAesRainGgplotFunction, clsSecAxisRainFunction, clsSecAxisTemFunction As New RFunction
    Private clsAesRainBarTextFunction, clsPlotGridFunction, clsAesTmaxBarTextFunction, clsAesTminBarTextFunction, clsRainRoundFunction, clsTmaxRoundFunction, clsTminRoundFunction As New RFunction
    Private strScale As String = "scale_Factor"
    Private lstRainReceivers As New List(Of ucrReceiverSingle)
    Private lstTmaxReceivers As New List(Of ucrReceiverSingle)
    Private lstTminReceivers As New List(Of ucrReceiverSingle)
    Private lstTminminReceivers As New List(Of ucrReceiverSingle)

    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub dlgClimograph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
        ResizeDialogue()

        AutoFillReceivers(lstRainReceivers)
        AutoFillReceivers(lstTmaxReceivers)
        AutoFillReceivers(lstTminReceivers)
        AutoFillReceivers(lstTminminReceivers)
    End Sub

    Private Sub InitialiseDialog()
        Dim kvpRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("rain", {"sumrainfall", "rain", "rainfall", "prec", "rr", "prcp", "sum_rainfall", "sum_rain", "sum_precip", "sum_precipitation", "sum_rr", "sum_pre", "sum_prcp", "mean_rainfall", "mean_rain", "mean_precip", "mean_precipitation", "mean_rr", "mean_pre", "mean_prcp", "max_rainfall", "max_rain", "max_precip", "max_precipitation", "max_rr", "max_pre", "max_prcp", "min_rainfall", "min_rain", "min_precip", "min_precipitation", "min_rr", "min_pre", "min_prcp", "mean_sum_rain", "mean_sum_precip", "mean_sum_precipitation", "mean_sum_rr", "mean_sum_pre", "mean_sum_prcp", "mean_sum_rainfall", "max_sum_rain", "max_sum_precip", "max_sum_precipitation", "max_sum_rr", "max_sum_pre", "max_sum_prcp", "max_sum_rainfall", "min_sum_rain", "min_sum_precip", "min_sum_precipitation", "min_sum_rr", "min_sum_pre", "min_sum_prcp", "min_sum_rainfall"}.ToList())
        Dim kvpTMax As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_max", {"tmax", "tx", "tempmax", "tmp_max", "tmpmax", "max_temperature", "temperature_max", "mean_tmax", "mean_tx", "mean_tempmax", "mean_tmp_max", "mean_tmpmax", "mean_temperature_max", "mean_max_temperature", "max_tmax", "max_tx", "max_tempmax", "max_tmp_max", "max_tmpmax", "max_temperature_max", "max_max_temperature", "min_tmax", "min_tx", "min_tempmax", "min_tmp_max", "min_tmpmax", "min_temperature_max", "min_max_temperature"}.ToList())
        Dim kvpTMin As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_min", {"tmin", "tn", "tempmin", "tmp_min", "tmpmin", "min_temperature", "temperature_min", "mean_tmin", "mean_tn", "mean_tempmin", "mean_tmp_min", "mean_tmpmin", "mean_temperature_min", "mean_min_temperature", "max_tmin", "max_tn", "max_tempmin", "max_tmp_min", "max_tmpmin", "max_temperature_min", "max_min_temperature"}.ToList())
        Dim kvpTMinmin As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("tem_min_min", {"min_tmin", "min_tn", "min_tempmin", "min_tmp_min", "min_tmpmin", "min_temperature_min", "min_min_temperature"}.ToList())

        lstRecognisedTypes.AddRange({kvpRain, kvpTMax, kvpTMin, kvpTMinmin})

        lstRainReceivers.AddRange({ucrReceiverRainBar, ucrReceiverRain, ucrReceiverRainC})

        lstTmaxReceivers.AddRange({ucrReceiverElement1, ucrReceiverElement1Bar, ucrReceiverMaxtem})

        lstTminReceivers.AddRange({ucrReceiverElement2, ucrReceiverElement2Bar, ucrReceiverMintemp})

        lstTminminReceivers.AddRange({ucrReceiverAbsolute})

        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctColourPallette As New Dictionary(Of String, String)
        Dim dctPalette As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 432

        ucrSelectorClimograph.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrSelectorClimograph.SetParameterIsrfunction()

        ucrPnlClimograph.AddRadioButton(rdoClimograph)
        ucrPnlClimograph.AddRadioButton(rdoWalterLieth)
        ucrPnlClimograph.AddRadioButton(rdoClimateBars)
        ucrPnlClimograph.AddParameterValuesCondition(rdoWalterLieth, "checked", "WalterLieth")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimograph, "checked", "Climograph")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimateBars, "checked", "climate Charts")

        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverMonthC.SetParameter(New RParameter("x", 2))
        ucrReceiverMonthC.SetParameterIsRFunction()
        ucrReceiverMonthC.Selector = ucrSelectorClimograph
        ucrReceiverMonthC.bWithQuotes = False
        ucrReceiverMonthC.SetClimaticType("month")
        ucrReceiverMonthC.bAutoFill = True
        ucrReceiverMonthC.strSelectorHeading = "Month Variables"
        ucrReceiverMonthC.SetLinkedDisplayControl(lblMonthC)

        ucrReceiverMonthBar.SetParameter(New RParameter("x", 2))
        ucrReceiverMonthBar.SetParameterIsRFunction()
        ucrReceiverMonthBar.Selector = ucrSelectorClimograph
        ucrReceiverMonthBar.bWithQuotes = False
        ucrReceiverMonthBar.SetClimaticType("month")
        ucrReceiverMonthBar.bAutoFill = True
        ucrReceiverMonthBar.strSelectorHeading = "Month Variables"
        ucrReceiverMonthBar.SetLinkedDisplayControl(lblMonthBar)

        ucrReceiverRain.SetParameter(New RParameter("p_mes", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.Tag = "rain"
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverRainC.SetParameter(New RParameter("y", 1))
        ucrReceiverRainC.SetParameterIsRFunction()
        ucrReceiverRainC.Selector = ucrSelectorClimograph
        ucrReceiverRainC.bWithQuotes = False
        ucrReceiverRainC.Tag = "rain"
        ucrReceiverRainC.SetLinkedDisplayControl(lblRainC)

        ucrReceiverRainBar.SetParameter(New RParameter("y", 1))
        ucrReceiverRainBar.SetParameterIsRFunction()
        ucrReceiverRainBar.Selector = ucrSelectorClimograph
        ucrReceiverRainBar.bWithQuotes = False
        ucrReceiverRainBar.Tag = "rain"
        ucrReceiverRainBar.SetLinkedDisplayControl(lblRainBar)

        ucrReceiverMaxtem.SetParameter(New RParameter("tm_max", 4))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.Tag = "temp_max"
        ucrReceiverMaxtem.strSelectorHeading = "Variables"
        ucrReceiverMaxtem.SetLinkedDisplayControl(lblMaxtem)

        ucrReceiverMintemp.SetParameter(New RParameter("tm_min", 5))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.Tag = "temp_min"
        ucrReceiverMintemp.strSelectorHeading = "Variables"
        ucrReceiverMintemp.SetLinkedDisplayControl(lblMintem)

        ucrReceiverElement1.SetParameter(New RParameter("y", 4, False))
        ucrReceiverElement1.SetParameterIsRFunction()
        ucrReceiverElement1.Selector = ucrSelectorClimograph
        ucrReceiverElement1.bWithQuotes = False
        ucrReceiverElement1.Tag = "temp_max"
        ucrReceiverElement1.strSelectorHeading = "Variables"
        ucrReceiverElement1.SetLinkedDisplayControl(lblElement1)

        ucrReceiverElement1Bar.SetParameter(New RParameter("y", 4, False))
        ucrReceiverElement1Bar.SetParameterIsRFunction()
        ucrReceiverElement1Bar.Selector = ucrSelectorClimograph
        ucrReceiverElement1Bar.bWithQuotes = False
        ucrReceiverElement1Bar.Tag = "temp_max"
        ucrReceiverElement1Bar.strSelectorHeading = "Variables"
        ucrReceiverElement1Bar.SetLinkedDisplayControl(lblElement1Bar)

        ucrReceiverElement2.SetParameter(New RParameter("tmin", 5, False))
        ucrReceiverElement2.SetParameterIsRFunction()
        ucrReceiverElement2.Selector = ucrSelectorClimograph
        ucrReceiverElement2.bWithQuotes = False
        ucrReceiverElement2.Tag = "temp_min"
        ucrReceiverElement2.strSelectorHeading = "Variables"
        ucrReceiverElement2.SetLinkedDisplayControl(lblElement2)

        ucrReceiverElement2Bar.SetParameter(New RParameter("tmin", 5, False))
        ucrReceiverElement2Bar.SetParameterIsRFunction()
        ucrReceiverElement2Bar.Selector = ucrSelectorClimograph
        ucrReceiverElement2Bar.bWithQuotes = False
        ucrReceiverElement2Bar.Tag = "temp_min"
        ucrReceiverElement2Bar.strSelectorHeading = "Variables"
        ucrReceiverElement2Bar.SetLinkedDisplayControl(lblElement2Bar)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorClimograph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrReceiverFacet.SetParameter(New RParameter("var1"))
        ucrReceiverFacet.Selector = ucrSelectorClimograph
        ucrReceiverFacet.SetClimaticType("station")
        ucrReceiverFacet.bAutoFill = True
        ucrReceiverFacet.bWithQuotes = False
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.SetValuesToIgnore({"."})

        ucrReceiverFacetBar.SetParameter(New RParameter("var1"))
        ucrReceiverFacetBar.Selector = ucrSelectorClimograph
        ucrReceiverFacetBar.SetClimaticType("station")
        ucrReceiverFacetBar.bAutoFill = True
        ucrReceiverFacetBar.bWithQuotes = False
        ucrReceiverFacetBar.SetParameterIsString()
        ucrReceiverFacetBar.SetValuesToIgnore({"."})

        ucrInputFacet.SetItems({strFacetWrap1, strFacetRowStationAll, strFacetColStationAll, strFacetRow1, strFacetCol1, strNone1})
        ucrInputFacet.SetDropDownStyleAsNonEditable()

        ucrInputFacetBar.SetItems({strFacetWrap2, strFacetRowBarAll, strFacetColBarAll, strFacetRow2, strFacetCol2, strNone2})
        ucrInputFacetBar.SetDropDownStyleAsNonEditable()

        ucrReceiverAbsolute.SetParameter(New RParameter("ta_min", 6))
        ucrReceiverAbsolute.SetParameterIsString()
        ucrReceiverAbsolute.Selector = ucrSelectorClimograph
        ucrReceiverAbsolute.Tag = "tem_min_min"
        ucrReceiverAbsolute.strSelectorHeading = "Variables"
        ucrReceiverAbsolute.SetLinkedDisplayControl(lblAbsolute)

        ucrPnlClimograph.AddToLinkedControls({ucr1stFactorReceiver, ucrReceiverAbsolute, ucrReceiverMintemp, ucrReceiverMonth, ucrReceiverMaxtem, ucrReceiverRain, ucrInputStation}, {rdoWalterLieth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlClimograph.AddToLinkedControls({ucrChkColour, ucrChkTile, ucrChkLegend, ucrReceiverElement2, ucrReceiverElement1, ucrReceiverMonthC, ucrReceiverRainC, ucrChkRibbon, ucrChkText}, {rdoClimograph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlClimograph.AddToLinkedControls({ucrReceiverElement2Bar, ucrReceiverElement1Bar, ucrReceiverMonthBar, ucrReceiverRainBar}, {rdoClimateBars}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlClimograph.AddToLinkedControls({ucrReceiverFacet, ucrInputFacet}, {rdoClimograph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlClimograph.AddToLinkedControls({ucrReceiverFacetBar, ucrInputFacetBar}, {rdoClimateBars}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlColour.AddRadioButton(rdoViridis)
        ucrPnlColour.AddRadioButton(rdoPalette)
        ucrPnlColour.AddRadioButton(rdoSinglecolour)
        ucrPnlColour.AddParameterValuesCondition(rdoPalette, "Check", "palette")
        ucrPnlColour.AddParameterValuesCondition(rdoViridis, "Check", "viridis")
        ucrPnlColour.AddParameterValuesCondition(rdoSinglecolour, "Check", "single")
        ucrPnlColour.AddToLinkedControls(ucrInputPalette, {rdoPalette}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Blues")
        ucrPnlColour.AddToLinkedControls(ucrInputColourPalette, {rdoViridis}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Viridis")

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

        ucrChkRibbon.SetText("Add Ribbon")
        ucrChkRibbon.AddParameterValuesCondition(True, "checked", "True")
        ucrChkRibbon.AddParameterValuesCondition(False, "checked", "False")

        ucrChkTile.SetText("Add Tile")
        ucrChkTile.AddParameterValuesCondition(True, "checked", "True")
        ucrChkTile.AddParameterValuesCondition(False, "checked", "False")

        ucrChkText.SetText("Add Label")
        ucrChkText.AddParameterValuesCondition(True, "checked", "True")
        ucrChkText.AddParameterValuesCondition(False, "checked", "False")

        ucrInputPalette.SetParameter(New RParameter("palette", 10))
        ucrInputPalette.SetDropDownStyleAsNonEditable()
        dctPalette.Add("Blues", Chr(34) & "Blues" & Chr(34))
        dctPalette.Add("Greens", Chr(34) & "Greens" & Chr(34))
        dctPalette.Add("Greys", Chr(34) & "Greys" & Chr(34))
        dctPalette.Add("Oranges", Chr(34) & "Oranges" & Chr(34))
        dctPalette.Add("Purples", Chr(34) & "Purples" & Chr(34))
        dctPalette.Add("Reds", Chr(34) & "Reds" & Chr(34))
        dctPalette.Add("BuGn", Chr(34) & "BuGn" & Chr(34))
        dctPalette.Add("BuPu", Chr(34) & "BuPu" & Chr(34))
        dctPalette.Add("GnBu", Chr(34) & "GnBu" & Chr(34))
        dctPalette.Add("OrRd", Chr(34) & "OrRd" & Chr(34))
        dctPalette.Add("PuBu", Chr(34) & "PuBu" & Chr(34))
        dctPalette.Add("PuBuGn", Chr(34) & "PuBuGn" & Chr(34))
        dctPalette.Add("PuRd", Chr(34) & "PuRd" & Chr(34))
        dctPalette.Add("RdPu", Chr(34) & "RdPu" & Chr(34))
        dctPalette.Add("YlGn", Chr(34) & "YlGn" & Chr(34))
        dctPalette.Add("YlGnBu", Chr(34) & "YlGnBu" & Chr(34))
        dctPalette.Add("YlOrBr", Chr(34) & "YlOrBr" & Chr(34))
        dctPalette.Add("YlOrRd", Chr(34) & "YlOrRd" & Chr(34))
        dctPalette.Add("Spectral", Chr(34) & "Spectral" & Chr(34))
        dctPalette.Add("BrBG", Chr(34) & "BrBG" & Chr(34))
        dctPalette.Add("PiYG", Chr(34) & "PiYG" & Chr(34))
        dctPalette.Add("PRGn", Chr(34) & "PRGn" & Chr(34))
        dctPalette.Add("PuOr", Chr(34) & "PuOr" & Chr(34))
        dctPalette.Add("RdBu", Chr(34) & "RdBu" & Chr(34))
        dctPalette.Add("RdGy", Chr(34) & "RdGy" & Chr(34))
        dctPalette.Add("RdYlBu", Chr(34) & "RdYlBu" & Chr(34))
        dctPalette.Add("RdYlGn", Chr(34) & "RdYlGn" & Chr(34))
        dctPalette.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctPalette.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctPalette.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctPalette.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctPalette.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctPalette.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctPalette.Add("Set3", Chr(34) & "Set3" & Chr(34))
        ucrInputPalette.SetItems(dctPalette)

        ucrInputColourPalette.SetParameter(New RParameter("option", 0))
        dctColourPallette.Add("viridis", Chr(34) & "viridis" & Chr(34))
        dctColourPallette.Add("magma", Chr(34) & "magma" & Chr(34))
        dctColourPallette.Add("inferno", Chr(34) & "inferno" & Chr(34))
        dctColourPallette.Add("plasma", Chr(34) & "plasma" & Chr(34))
        dctColourPallette.Add("cividis", Chr(34) & "cividis" & Chr(34))
        dctColourPallette.Add("mako", Chr(34) & "mako" & Chr(34))
        dctColourPallette.Add("rocket", Chr(34) & "rocket" & Chr(34))
        dctColourPallette.Add("turbo", Chr(34) & "turbo" & Chr(34))
        ucrInputColourPalette.SetItems(dctColourPallette)
        ucrInputColourPalette.SetDropDownStyleAsNonEditable()

        ucrChkColour.SetText("Change Bars Colour")
        ucrChkColour.AddParameterValuesCondition(True, "checked", "True")
        ucrChkColour.AddParameterValuesCondition(False, "checked", "False")
        ucrChkColour.AddToLinkedControls({ucrPnlColour}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrSave.SetPrefix("wl_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Store Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
        ResizeDialogue()
    End Sub

    Private Sub SetDefaults()
        clsGgwalterliethFunction = New RFunction
        clsBaseOperator = New ROperator
        clsDummyFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsGeomRibbonFunction = New RFunction
        clsGeomRibbon1Function = New RFunction
        clsAesGeomRibbonFunction = New RFunction
        clsAesGeomRibbon1Function = New RFunction
        clsGeomBarFunction = New RFunction
        clsGeomLineStarFunction = New RFunction
        clsGeomLineStar1Function = New RFunction
        clsAesLineStarFunction = New RFunction
        clsAesLineStar1Function = New RFunction
        clsRggplotFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsFacetFunction1 = New RFunction
        clsFacetFunction2 = New RFunction
        clsSecondaryAxisFunction = New RFunction
        clsSecondaryAxis1Function = New RFunction
        clsSecondaryAxis2Function = New RFunction
        clsGeomTextBarFunction = New RFunction
        clsGeomTextTmaxFunction = New RFunction
        clsGeomTextTminFunction = New RFunction
        clsAesGeomTextBarFunction = New RFunction
        clsAesGeomTextTmaxFunction = New RFunction
        clsAesGeomTextTminFunction = New RFunction
        clsGeomTextTmaxStarFunction = New RFunction
        clsGeomTextTminStarFunction = New RFunction
        clsAesGeomTextStarTmaxFunction = New RFunction
        clsAesGeomTextStarTminFunction = New RFunction
        clsXScalediscreteFunction = New RFunction
        clsRoundBarFunction = New RFunction
        clsRoundTmaxFunction = New RFunction
        clsRoundTminFunction = New RFunction
        clsGeomTileFunction = New RFunction
        clsStarOperator = New ROperator
        clsStar1Operator = New ROperator
        clsDivideOperator = New ROperator
        clsDivide1Operator = New ROperator
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp1 = New ROperator
        clsFacetColOp1 = New ROperator
        clsPipeOperator1 = New ROperator
        clsGroupByFunction1 = New RFunction
        clsGroupByFunction2 = New RFunction
        clsMaxFunction = New RFunction
        clsMax1Function = New RFunction
        clsVectorFunction = New RFunction
        clsScaleycontinuousFunction = New RFunction
        clsLabFunction = New RFunction
        clsGetObjectDataFunction = New RFunction
        clsColourPaletteFunction = New RFunction
        clsScalefillDistillerFunction = New RFunction
        clsFillBrewerFunction = New RFunction
        clsGeomBarTminFunction = New RFunction
        clsGeomBarTmaxFunction = New RFunction
        clsAesTmaxBarFunction = New RFunction
        clsAesTminBarFunction = New RFunction
        clsPlus1Operator = New ROperator
        clsPlus2Operator = New ROperator
        clsPlus3Operator = New ROperator
        clsPlus5Operator = New ROperator
        clsPlus6Operator = New ROperator
        clsPlus7Operator = New ROperator
        clsPlus8Operator = New ROperator
        clsPlus9Operator = New ROperator
        clsRainBarFunction = New RFunction
        clsTmaxBarFunction = New RFunction
        clsTminBarFunction = New RFunction
        clsLabsRainFunction = New RFunction
        clsLabsTempFunction = New RFunction
        clsRainBarTextFunction = New RFunction
        clsTmaxBarTextFunction = New RFunction
        clsTminBarTextFunction = New RFunction
        clsRainGgplotFunction = New RFunction
        clsTemGgplotFunction = New RFunction
        clsAesTmaxBarFunction1 = New RFunction
        clsAesTminBarFunction1 = New RFunction
        clsAesTemGgplotFunction = New RFunction
        clsAesRainGgplotFunction = New RFunction
        clsSecAxisRainFunction = New RFunction
        clsSecAxisTemFunction = New RFunction
        clsAesRainBarTextFunction = New RFunction
        clsAesTmaxBarTextFunction = New RFunction
        clsAesTminBarTextFunction = New RFunction
        clsRainRoundFunction = New RFunction
        clsTmaxRoundFunction = New RFunction
        clsTminRoundFunction = New RFunction
        clsPlotGridFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsPlus10Operator = New ROperator
        clsPlus11Operator = New ROperator

        ucrSelectorClimograph.Reset()
        ucrSelectorClimograph.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrInputFacet.SetName(strFacetWrap)
        ucrInputFacet.bUpdateRCodeFromControl = True

        ucrInputFacetBar.SetName(strFacetWrap)
        ucrInputFacetBar.bUpdateRCodeFromControl = True

        clsDummyFunction.AddParameter("checked", "Climograph", iPosition:=0)
        clsDummyFunction.AddParameter("Check", "viridis", iPosition:=1)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)

        clsFacetFunction1.SetPackageName("ggplot2")
        clsFacetRowOp1.SetOperation("+")
        clsFacetRowOp1.bBrackets = False
        clsFacetColOp1.SetOperation("+")
        clsFacetColOp1.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction1.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator1.SetOperation("%>%")
        SetPipeAssignTo1()

        clsGroupByFunction1.SetPackageName("dplyr")
        clsGroupByFunction1.SetRCommand("group_by")

        clsFacetFunction2.SetPackageName("ggplot2")
        clsFacetRowOp2.SetOperation("+")
        clsFacetRowOp2.bBrackets = False
        clsFacetColOp2.SetOperation("+")
        clsFacetColOp2.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction2.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator2.SetOperation("%>%")
        SetPipeAssignTo2()

        clsGroupByFunction2.SetPackageName("dplyr")
        clsGroupByFunction2.SetRCommand("group_by")

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGgwalterliethFunction.SetPackageName("instatClimatic")
        clsGgwalterliethFunction.SetRCommand("ggwalter_lieth")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsBarAesFunction.SetRCommand("aes")

        clsGeomBarFunction.SetRCommand("geom_bar")
        clsGeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsGeomBarFunction.AddParameter("alpha", "0.5", iPosition:=2)

        clsGeomBarTmaxFunction.SetRCommand("geom_bar")
        clsGeomBarTmaxFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsGeomBarTmaxFunction.AddParameter("fill", "red", iPosition:=2)

        clsAesTmaxBarFunction.SetRCommand("aes")

        clsGeomBarTminFunction.SetRCommand("geom_bar")
        clsGeomBarTminFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsGeomBarTminFunction.AddParameter("fill", "blue", iPosition:=2)

        clsAesTminBarFunction.SetRCommand("aes")

        clsGeomLineStarFunction.SetRCommand("geom_line")
        clsGeomLineStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesLineStarFunction, iPosition:=0)
        clsGeomLineStarFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsGeomLineStar1Function.SetRCommand("geom_line")
        clsGeomLineStar1Function.AddParameter("mapping", clsRFunctionParameter:=clsAesLineStar1Function, iPosition:=0)
        clsGeomLineStar1Function.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=1)

        clsAesLineStarFunction.SetRCommand("aes")
        clsAesLineStarFunction.AddParameter("group", "1", iPosition:=2)

        clsAesLineStar1Function.SetRCommand("aes")
        clsAesLineStar1Function.AddParameter("group", "1", iPosition:=2)

        clsSecondaryAxisFunction.SetRCommand("sec_axis")
        clsSecondaryAxisFunction.AddParameter("x", "~.*0.0393701", iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxisFunction.AddParameter("name", Chr(34) & "Rainfall (inches)" & Chr(34), iPosition:=1)

        clsSecondaryAxis1Function.SetRCommand("sec_axis")
        clsSecondaryAxis1Function.AddParameter("x", "~.*32", iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxis1Function.AddParameter("name", Chr(34) & "Temperature (F)" & Chr(34), iPosition:=1)

        clsXScalediscreteFunction.SetRCommand("scale_x_discrete")
        clsXScalediscreteFunction.AddParameter("name", Chr(34) & "Month" & Chr(34), iPosition:=0)

        clsGeomRibbonFunction.SetRCommand("geom_ribbon")
        clsGeomRibbonFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomRibbonFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomRibbonFunction.AddParameter("fill", Chr(34) & "#000000" & Chr(34), iPosition:=1)
        clsGeomRibbonFunction.AddParameter("alpha", "0.2", iPosition:=2)

        clsAesGeomRibbonFunction.SetRCommand("aes")
        clsAesGeomRibbonFunction.AddParameter("group", "1", iPosition:=2)

        clsGeomTileFunction.SetRCommand("geom_tile")
        clsGeomTileFunction.AddParameter("alpha", "0.5", iPosition:=0)

        clsGeomRibbon1Function.SetRCommand("geom_ribbon")
        clsGeomRibbon1Function.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomRibbon1Function, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomRibbon1Function.AddParameter("fill", Chr(34) & "#000000" & Chr(34), iPosition:=1)
        clsGeomRibbon1Function.AddParameter("alpha", "0.2", iPosition:=2)

        clsAesGeomRibbon1Function.SetRCommand("aes")
        clsAesGeomRibbon1Function.AddParameter("ymin", clsROperatorParameter:=clsStar1Operator, iPosition:=0)
        clsAesGeomRibbon1Function.AddParameter("ymax", clsROperatorParameter:=clsStarOperator, iPosition:=1)
        clsAesGeomRibbon1Function.AddParameter("group", "1", iPosition:=2)

        clsGeomTextBarFunction.SetRCommand("geom_text")
        clsGeomTextBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextBarFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextBarFunction.AddParameter("vjust", "-0.5", iPosition:=1)
        clsGeomTextBarFunction.AddParameter("size", "3", iPosition:=2)

        clsAesGeomTextBarFunction.SetRCommand("aes")
        clsAesGeomTextBarFunction.AddParameter("label", clsRFunctionParameter:=clsRoundBarFunction, iPosition:=1)

        clsRoundBarFunction.SetRCommand("round")
        clsRoundBarFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsGeomTextTmaxFunction.SetRCommand("geom_text")
        clsGeomTextTmaxFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextTmaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTmaxFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=1)
        clsGeomTextTmaxFunction.AddParameter("vjust", "-0.5", iPosition:=2)
        clsGeomTextTmaxFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTmaxFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextTmaxFunction.SetRCommand("aes")
        clsAesGeomTextTmaxFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTmaxFunction, iPosition:=1)

        clsGeomTextTmaxStarFunction.SetRCommand("geom_text")
        clsGeomTextTmaxStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextStarTmaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTmaxStarFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=1)
        clsGeomTextTmaxStarFunction.AddParameter("vjust", "-0.5", iPosition:=2)
        clsGeomTextTmaxStarFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTmaxStarFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextStarTmaxFunction.SetRCommand("aes")
        clsAesGeomTextStarTmaxFunction.AddParameter("y", clsROperatorParameter:=clsStarOperator, iPosition:=0)
        clsAesGeomTextStarTmaxFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTmaxFunction, iPosition:=1)

        clsRoundTmaxFunction.SetRCommand("round")
        clsRoundTmaxFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsGeomTextTminFunction.SetRCommand("geom_text")
        clsGeomTextTminFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextTminFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTminFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsGeomTextTminFunction.AddParameter("vjust", "1.5", iPosition:=2)
        clsGeomTextTminFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTminFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextTminFunction.SetRCommand("aes")
        clsAesGeomTextTminFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTminFunction, iPosition:=1)

        clsGeomTextTminStarFunction.SetRCommand("geom_text")
        clsGeomTextTminStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextStarTminFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTminStarFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsGeomTextTminStarFunction.AddParameter("vjust", "1.5", iPosition:=2)
        clsGeomTextTminStarFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTminStarFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextStarTminFunction.SetRCommand("aes")
        clsAesGeomTextStarTminFunction.AddParameter("y", clsROperatorParameter:=clsStar1Operator, iPosition:=0)
        clsAesGeomTextStarTminFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTminFunction, iPosition:=1)

        clsRoundTminFunction.SetRCommand("round")
        clsRoundTminFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsSecondaryAxis2Function.SetRCommand("sec_axis")
        clsSecondaryAxis2Function.AddParameter("x", clsROperatorParameter:=clsDivide1Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxis2Function.AddParameter("name", Chr(34) & "Temperature (c)" & Chr(34), iPosition:=1)

        clsDivide1Operator.SetOperation("/")
        clsDivide1Operator.AddParameter("left", "~ .", iPosition:=0, bIncludeArgumentName:=False)
        clsDivide1Operator.AddParameter("right", clsROperatorParameter:=clsDivideOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsStarOperator.SetOperation("*")
        clsStarOperator.AddParameter("right", strScale, iPosition:=1, bIncludeArgumentName:=False)

        clsStar1Operator.SetOperation("*")
        clsStar1Operator.AddParameter("right", strScale, iPosition:=1, bIncludeArgumentName:=False)

        clsDivideOperator.SetOperation("/")
        clsDivideOperator.AddParameter("left", clsRFunctionParameter:=clsMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDivideOperator.AddParameter("right", clsRFunctionParameter:=clsMax1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsDivideOperator.SetAssignTo(strScale,)

        clsMaxFunction.SetRCommand("max")

        clsMax1Function.SetRCommand("max")
        clsMax1Function.AddParameter("x", clsRFunctionParameter:=clsVectorFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsVectorFunction.SetRCommand("c")

        clsScaleycontinuousFunction.SetRCommand("scale_y_continuous")

        clsLabFunction.SetRCommand("labs")

        clsColourPaletteFunction.SetPackageName("viridis")
        clsColourPaletteFunction.SetRCommand("scale_fill_viridis")

        clsScalefillDistillerFunction.SetPackageName("ggplot2")
        clsScalefillDistillerFunction.SetRCommand("scale_fill_distiller")

        clsFillBrewerFunction.SetPackageName("ggplot2")
        clsFillBrewerFunction.SetRCommand("scale_fill_brewer")

        clsPlus1Operator.SetOperation("+")
        clsPlus1Operator.AddParameter("left", clsRFunctionParameter:=clsRainGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPlus1Operator.AddParameter("right", clsROperatorParameter:=clsPlus2Operator, iPosition:=1, bIncludeArgumentName:=False)
        clsPlus1Operator.SetAssignTo(strRainBar)

        clsPlus2Operator.SetOperation("+")
        clsPlus2Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPlus2Operator.AddParameter("right", clsROperatorParameter:=clsPlus3Operator, iPosition:=1, bIncludeArgumentName:=False)

        clsPlus3Operator.SetOperation("+")
        clsPlus3Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPlus3Operator.AddParameter("right", clsRFunctionParameter:=clsLabsRainFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsRainGgplotFunction.SetRCommand("ggplot")

        clsAesRainGgplotFunction.SetRCommand("aes")

        clsRainBarFunction.SetRCommand("geom_bar")
        clsRainBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=0)
        clsRainBarFunction.AddParameter("alpha", "0.5", iPosition:=1)
        clsRainBarFunction.AddParameter("fill", Chr(34) & "purple" & Chr(34), iPosition:=2)

        clsRainBarTextFunction.SetRCommand("geom_text")
        clsRainBarTextFunction.AddParameter("size", "3", iPosition:=2)

        clsRainRoundFunction.SetRCommand("round")
        clsRainRoundFunction.AddParameter("y", "1", bIncludeArgumentName:=False)

        clsAesRainBarTextFunction.SetRCommand("aes")

        clsLabsRainFunction.SetRCommand("scale_y_continuous")
        clsLabsRainFunction.AddParameter("name", Chr(34) & "Rainfall (mm)" & Chr(34), iPosition:=0)
        clsLabsRainFunction.AddParameter("sec.axis", clsRFunctionParameter:=clsSecAxisRainFunction, iPosition:=1)

        clsSecAxisRainFunction.SetRCommand("sec_axis")
        clsSecAxisRainFunction.AddParameter("x", "~.*0.0393701", iPosition:=0, bIncludeArgumentName:=False)
        clsSecAxisRainFunction.AddParameter("name", Chr(34) & "Rainfall (inches)" & Chr(34), iPosition:=1)

        clsPlus5Operator.SetOperation("+")
        clsPlus5Operator.SetAssignTo(strTemBar)

        clsPlus6Operator.SetOperation("+")

        clsPlus7Operator.SetOperation("+")

        clsPlus8Operator.SetOperation("+")

        clsPlus9Operator.SetOperation("+")

        clsPlus10Operator.SetOperation("+")

        clsPlus11Operator.SetOperation("+")

        clsTemGgplotFunction.SetRCommand("ggplot")

        clsAesTemGgplotFunction.SetRCommand("aes")

        clsTmaxBarFunction.SetRCommand("geom_bar")
        clsTmaxBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsTmaxBarFunction.AddParameter("fill", Chr(34) & "red" & Chr(34), iPosition:=2)

        clsAesTmaxBarFunction1.SetRCommand("aes")

        clsTminBarFunction.SetRCommand("geom_bar")
        clsTminBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsTminBarFunction.AddParameter("fill", Chr(34) & "blue" & Chr(34), iPosition:=2)

        clsAesTminBarFunction1.SetRCommand("aes")

        clsTmaxBarTextFunction.SetRCommand("geom_text")
        clsTmaxBarTextFunction.AddParameter("size", "3", iPosition:=2)

        clsAesTmaxBarTextFunction.SetRCommand("aes")

        clsTmaxRoundFunction.SetRCommand("round")
        clsTmaxRoundFunction.AddParameter("y", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsTminBarTextFunction.SetRCommand("geom_text")
        clsTminBarTextFunction.AddParameter("size", "3", iPosition:=2)

        clsAesTminBarTextFunction.SetRCommand("aes")

        clsTminRoundFunction.SetRCommand("round")
        clsTminRoundFunction.AddParameter("y", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsLabsTempFunction.SetRCommand("scale_y_continuous")
        clsLabsTempFunction.AddParameter("name", Chr(34) & "Temperature (C)" & Chr(34), iPosition:=0)
        clsLabsTempFunction.AddParameter("sec.axis", clsRFunctionParameter:=clsSecAxisTemFunction, iPosition:=1)

        clsSecAxisTemFunction.SetRCommand("sec_axis")
        clsSecAxisTemFunction.AddParameter("x", "~.*32", iPosition:=0, bIncludeArgumentName:=False)
        clsSecAxisTemFunction.AddParameter("name", Chr(34) & "Temperature (F)" & Chr(34), iPosition:=1)

        clsPlotGridFunction.SetPackageName("cowplot")
        clsPlotGridFunction.SetRCommand("plot_grid")
        clsPlotGridFunction.AddParameter("x", strTemBar, iPosition:=0, bIncludeArgumentName:=False)
        clsPlotGridFunction.AddParameter("y", strRainBar, iPosition:=1, bIncludeArgumentName:=False)
        clsPlotGridFunction.AddParameter("ncol", "1", iPosition:=2)

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsGetObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverRainC.SetRCode(clsMaxFunction, bReset)
        ucrReceiverMonth.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverRain.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMintemp.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMaxtem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverAbsolute.SetRCode(clsGgwalterliethFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrReceiverElement2.SetRCode(clsVectorFunction, bReset)
            ucrReceiverElement1.SetRCode(clsVectorFunction, bReset)
            ucrPnlClimograph.SetRCode(clsDummyFunction, bReset)
            ucrChkRibbon.SetRCode(clsGeomRibbonFunction, bReset)
            ucrChkTile.SetRCode(clsGeomTileFunction, bReset)
            ucrChkText.SetRCode(clsBaseOperator, bReset)
            ucrPnlColour.SetRCode(clsDummyFunction, bReset)
            ucrChkColour.SetRCode(clsBaseOperator, bReset)
        End If

        AutoFillReceivers(lstRainReceivers)
        AutoFillReceivers(lstTmaxReceivers)
        AutoFillReceivers(lstTminReceivers)
        AutoFillReceivers(lstTminminReceivers)
    End Sub

    Private Sub TestOKEnabled()
        If rdoClimograph.Checked AndAlso Not ucrReceiverMonthC.IsEmpty AndAlso ((Not ucrReceiverElement1.IsEmpty OrElse Not ucrReceiverElement2.IsEmpty OrElse Not ucrReceiverRainC.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoWalterLieth.Checked AndAlso ((Not ucrReceiverAbsolute.IsEmpty AndAlso Not ucrReceiverMaxtem.IsEmpty AndAlso Not ucrReceiverMintemp.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverRain.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoClimateBars.Checked AndAlso Not ucrReceiverMonthBar.IsEmpty AndAlso ((Not ucrReceiverElement1Bar.IsEmpty AndAlso Not ucrReceiverElement2Bar.IsEmpty OrElse Not ucrReceiverRainBar.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrPnlClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlValueChanged
        ResizeDialogue()
        If rdoClimograph.Checked Then
            cmdOptions.Visible = True
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPlus1Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPlus5Operator)
            clsBaseOperator.RemoveParameterByName("ggwalter_lieth")
            ucrReceiverMonthC.SetMeAsReceiver()
            clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
        ElseIf rdoWalterLieth.Checked Then
            cmdOptions.Visible = False
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPlus1Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPlus5Operator)
            clsBaseOperator.RemoveParameterByName("ggplot")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            ucrReceiverMonth.SetMeAsReceiver()
            clsGgwalterliethFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
            clsBaseOperator.AddParameter("ggwalter_lieth", clsRFunctionParameter:=clsGgwalterliethFunction, iPosition:=0)
        Else
            cmdOptions.Visible = False
            clsBaseOperator.RemoveParameterByName("ggwalter_lieth")
            clsBaseOperator.RemoveParameterByName("ggplot")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameterByName("facets")
            clsBaseOperator.RemoveParameterByName("facets1")
            clsBaseOperator.AddParameter("plot_grid", clsRFunctionParameter:=clsPlotGridFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPlus1Operator, iPosition:=1)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPlus5Operator, iPosition:=2)
        End If
        AutoFacetStation()
        AddRemoveFacetClimograph()
        AddRemoveFacetsWalterLieth()
        AddRemoveGeomBar()
        AddRemoveGeomLine1()
        AddRemoveGeomLines()
        AddRemoveSecondaryAxis()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
        EnableTileAndRibbon()
        AddRemoveTemBars()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        UpdateParametersForStation()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                                clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                                dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSelectorClimograph, clsNewThemeFunction:=clsThemeFunction, clsNewGlobalAesFunction:=clsBarAesFunction,
                                clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                                clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        AutoFacetStation()
        AddRemoveFacetClimograph()
        AddRemoveFacetsWalterLieth()
        AddRemoveGeomBar()
        AddRemoveGeomLine1()
        AddRemoveGeomLines()
        AddRemoveSecondaryAxis()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
        bResetSubdialog = False
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsBarAesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimograph,
                                   bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsBarAesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverMonthC.Clear()
                End If
                'In the y case, the value stored in the clsReasFunction in the multiple variables 
                '  case is "value", however that one shouldn't be written in the multiple 
                '  variables receiver (otherwise it would stack all variables and the stack 
                '  ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables 
                '  independently from the multiple variables method? Here if the receiver is 
                '  actually in single mode, the variable "value" will still be given back, which 
                '  throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso clsParam.strArgumentValue <> "value" Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverRainC.Clear()
                Else
                    ucrReceiverRainC.Add(clsParam.strArgumentValue)
                End If
            End If
        Next
        TestOKEnabled()
        AddRemoveGeomBar()
    End Sub

    Private Sub openSdgLayerOptionstmax(clsNewGeomFunc As RFunction, clsNewAesFunction As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsLocalRaesFunction, clsNewLocalAes:=clsNewAesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimograph,
                                   bApplyAesGlobally:=False, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsNewAesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverMonthC.Clear()
                End If
            ElseIf clsParam.strArgumentName = "y" AndAlso clsParam.strArgumentValue <> "value" Then
                ucrReceiverElement1.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOKEnabled()
    End Sub

    Private Sub openSdgLayerOptionstmin(clsNewGeomFunc As RFunction, clsNewAesFunction As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsLocalRaesFunction, clsNewLocalAes:=clsNewAesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimograph,
                                   bApplyAesGlobally:=False, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        For Each clsParam In clsNewAesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverMonthC.Clear()
                End If
            ElseIf clsParam.strArgumentName = "y" AndAlso clsParam.strArgumentValue <> "value" Then
                ucrReceiverElement2.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOKEnabled()
    End Sub

    Private Sub ucrInputFacet_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputFacet.ControlValueChanged
        If Not bUpdateComboOptions1 Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone1 Then
            If Not (strChangedText = strFacetCol1 OrElse strChangedText = strFacetColStationAll _
            OrElse strChangedText = strFacetRow1 OrElse strChangedText = strFacetRowStationAll) _
            AndAlso Not ucrInputFacet.Equals(ucrChangedControl) _
            AndAlso ucrInputFacet.GetText() = strChangedText Then

                bUpdateComboOptions1 = False
                ucrInputFacet.SetName(strNone1)
                bUpdateComboOptions1 = True
            End If
            If (strChangedText = strFacetWrap1 AndAlso
            (ucrInputFacet.GetText = strFacetRow1 OrElse ucrInputFacet.GetText = strFacetRowStationAll _
            OrElse ucrInputFacet.GetText = strFacetCol1 OrElse ucrInputFacet.GetText = strFacetColStationAll)) _
        OrElse ((strChangedText = strFacetRow1 OrElse strChangedText = strFacetRowStationAll) _
            AndAlso ucrInputFacet.GetText = strFacetWrap1) _
        OrElse ((strChangedText = strFacetCol1 OrElse strChangedText = strFacetColStationAll) _
            AndAlso ucrInputFacet.GetText = strFacetWrap1) Then

                ucrInputFacet.SetName(strNone1)
            End If
        End If
        UpdateParametersForStationClimograph()
        AddRemoveFacets1()
        AddRemoveGroupBy1()
    End Sub

    Private Sub UpdateParametersForStationClimograph()
        bUpdatingParameters1 = False
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp1.RemoveParameterByName("col" & ucrInputFacet.Name)
        clsFacetRowOp1.RemoveParameterByName("row" & ucrInputFacet.Name)
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters1 = True
        ucrReceiverFacet.SetRCode(Nothing)
        Select Case ucrInputFacet.GetText()
            Case strFacetWrap1
                ucrReceiverFacet.ChangeParameterName("var1")
                ucrReceiverFacet.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol1, strFacetColStationAll
                ucrReceiverFacet.ChangeParameterName("col" & ucrInputFacet.Name)
                ucrReceiverFacet.SetRCode(clsFacetColOp1)
            Case strFacetRow1, strFacetRowStationAll
                ucrReceiverFacet.ChangeParameterName("row" & ucrInputFacet.Name)
                ucrReceiverFacet.SetRCode(clsFacetRowOp1)
        End Select
        If Not clsRFacetFunction.ContainsParameter("x") Then
            clsRFacetFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters1 = False
    End Sub

    Private Sub ucrInputFacetBar_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputFacetBar.ControlValueChanged
        If Not bUpdateComboOptions2 Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone2 Then
            If Not (strChangedText = strFacetCol2 OrElse strChangedText = strFacetColBarAll _
            OrElse strChangedText = strFacetRow2 OrElse strChangedText = strFacetRowBarAll) _
            AndAlso Not ucrInputFacetBar.Equals(ucrChangedControl) _
            AndAlso ucrInputFacetBar.GetText() = strChangedText Then

                bUpdateComboOptions2 = False
                ucrInputFacet.SetName(strNone2)
                bUpdateComboOptions2 = True
            End If
            If (strChangedText = strFacetWrap2 AndAlso
            (ucrInputFacetBar.GetText = strFacetRow2 OrElse ucrInputFacetBar.GetText = strFacetRowBarAll _
            OrElse ucrInputFacetBar.GetText = strFacetCol2 OrElse ucrInputFacetBar.GetText = strFacetColBarAll)) _
        OrElse ((strChangedText = strFacetRow2 OrElse strChangedText = strFacetRowBarAll) _
            AndAlso ucrInputFacetBar.GetText = strFacetWrap2) _
        OrElse ((strChangedText = strFacetCol2 OrElse strChangedText = strFacetColBarAll) _
            AndAlso ucrInputFacetBar.GetText = strFacetWrap2) Then

                ucrInputFacetBar.SetName(strNone2)
            End If
        End If
        UpdateParametersForFacetBar()
        AddRemoveFacets2()
        AddRemoveGroupBy2()
        AddRemoveTemBars()
    End Sub

    Private Sub UpdateParametersForFacetBar()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp2.RemoveParameterByName("col" & ucrInputFacetBar.Name)
        clsFacetRowOp2.RemoveParameterByName("row" & ucrInputFacetBar.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters2 = True
        ucrReceiverFacetBar.SetRCode(Nothing)
        Select Case ucrInputFacetBar.GetText()
            Case strFacetWrap2
                ucrReceiverFacetBar.ChangeParameterName("var1")
                ucrReceiverFacetBar.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol2, strFacetColBarAll
                ucrReceiverFacetBar.ChangeParameterName("col" & ucrInputFacetBar.Name)
                ucrReceiverFacetBar.SetRCode(clsFacetColOp2)
            Case strFacetRow2, strFacetRowBarAll
                ucrReceiverFacetBar.ChangeParameterName("row" & ucrInputFacetBar.Name)
                ucrReceiverFacetBar.SetRCode(clsFacetRowOp2)
        End Select
        If Not clsRFacetFunction.ContainsParameter("x") Then
            clsRFacetFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters2 = False
    End Sub

    Private Sub AddRemoveFacets1()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters1 Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucrReceiverFacet.IsEmpty Then
            Select Case ucrInputFacet.GetText()
                Case strFacetWrap1
                    bWrap = True
                Case strFacetCol1
                    bCol = True
                Case strFacetRow1
                    bRow = True
                Case strFacetColStationAll
                    bColAll = True
                Case strFacetRowStationAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction1)
        End If

        If bWrap Then
            clsFacetFunction1.SetRCommand("facet_wrap")
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction1.SetRCommand("facet_grid")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction1.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction1.RemoveParameterByName("margin")
        End If

        If bRow OrElse bRowAll Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp1, iPosition:=0)
        ElseIf (bCol OrElse bColAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If

        If bCol OrElse bColAll Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp1, iPosition:=1)
        ElseIf (bRow OrElse bRowAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveFacets2()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters2 Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucrReceiverFacetBar.IsEmpty Then
            Select Case ucrInputFacetBar.GetText()
                Case strFacetWrap2
                    bWrap = True
                Case strFacetCol2
                    bCol = True
                Case strFacetRow2
                    bRow = True
                Case strFacetColBarAll
                    bColAll = True
                Case strFacetRowBarAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction2)
        End If

        If bWrap Then
            clsFacetFunction2.SetRCommand("facet_wrap")
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction2.SetRCommand("facet_grid")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction2.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction2.RemoveParameterByName("margin")
        End If

        If bRow OrElse bRowAll Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp2, iPosition:=0)
        ElseIf (bCol OrElse bColAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If

        If bCol OrElse bColAll Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp2, iPosition:=1)
        ElseIf (bRow OrElse bRowAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveFacetClimograph()
        If rdoClimograph.Checked Then
            If Not ucrReceiverFacet.IsEmpty Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction1)
            Else
                clsBaseOperator.RemoveParameterByName("facets")
            End If
        ElseIf rdoClimateBars.Checked Then
            AddRemoveTemBars()
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If
    End Sub

    Private Sub ucrReceiverFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacet.ControlValueChanged
        AddRemoveFacetClimograph()
        AddRemoveFacets1()
        AddRemoveGroupBy1()
    End Sub

    Private Sub ucrReceiverFacetBar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacetBar.ControlValueChanged
        AddRemoveFacetClimograph()
        AddRemoveFacets2()
        AddRemoveGroupBy2()
    End Sub

    Private Sub GetParameterValue1(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction1.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy1()
        If clsPipeOperator1.ContainsParameter("mutate") Then
            clsGroupByFunction1.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputFacet.GetText()
                    Case strFacetWrap1
                        GetParameterValue1(clsFacetVariablesOperator)
                    Case strFacetCol1, strFacetColStationAll
                        GetParameterValue1(clsFacetColOp1)
                    Case strFacetRow1, strFacetRowStationAll
                        GetParameterValue1(clsFacetRowOp1)
                End Select
            End If
            If clsGroupByFunction1.iParameterCount > 0 Then
                clsPipeOperator1.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction1, iPosition:=1)
            Else
                clsPipeOperator1.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator1.RemoveParameterByName("group_by")
        End If
        SetPipeAssignTo1()
    End Sub

    Private Sub SetPipeAssignTo1()
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator1.clsParameters.Count > 1 Then
            clsPipeOperator1.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator1.RemoveAssignTo()
        End If
    End Sub

    Private Sub GetParameterValue2(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction2.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy2()
        If clsPipeOperator2.ContainsParameter("mutate") Then
            clsGroupByFunction2.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputFacetBar.GetText()
                    Case strFacetWrap2
                        GetParameterValue2(clsFacetVariablesOperator)
                    Case strFacetCol2, strFacetColBarAll
                        GetParameterValue2(clsFacetColOp2)
                    Case strFacetRow2, strFacetRowBarAll
                        GetParameterValue2(clsFacetRowOp2)
                End Select
            End If
            If clsGroupByFunction2.iParameterCount > 0 Then
                clsPipeOperator2.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction2, iPosition:=1)
            Else
                clsPipeOperator2.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator2.RemoveParameterByName("group_by")
        End If
        SetPipeAssignTo2()
    End Sub

    Private Sub SetPipeAssignTo2()
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator2.clsParameters.Count > 1 Then
            clsPipeOperator2.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator2.RemoveAssignTo()
        End If
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
        UpdateParametersForStation()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParametersForStation()
        clsFacetOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol, strFacetColAll
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow, strFacetRowAll
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
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
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
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

        If bRow OrElse bRowAll Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf (bCol OrElse bColAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If

        If bCol OrElse bColAll Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf (bRow OrElse bRowAll) AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveFacetsWalterLieth()
        If rdoWalterLieth.Checked Then
            If Not ucr1stFactorReceiver.IsEmpty Then
                clsGgwalterliethFunction.AddParameter("station", ucr1stFactorReceiver.GetVariableNames(), iPosition:=1)
            Else
                clsGgwalterliethFunction.RemoveParameterByName("station")
                clsBaseOperator.RemoveParameterByName("facets1")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("facets1")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacetsWalterLieth()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub AutoFacetStation()
        If rdoClimograph.Checked Then
            Dim currentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver

            If currentReceiver IsNot Nothing Then
                ucrReceiverFacet.AddItemsWithMetadataProperty(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
                currentReceiver.SetMeAsReceiver()
                AddRemoveGroupBy1()
            End If
        Else
            Dim ucrCurrentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver

            If ucrCurrentReceiver IsNot Nothing Then
                ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
                ucrCurrentReceiver.SetMeAsReceiver()
                AddRemoveGroupBy()
            End If
        End If
    End Sub

    Private Sub ucrSelectorClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimograph.ControlValueChanged
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorClimograph.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsRggplotFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        AutoFacetStation()
        SetPipeAssignTo()
        SetPipeAssignTo1()
        AddRemoveGeomRibbon()
        Dataframechange()
        AddRemoveTemBars()

        AutoFillReceivers(lstRainReceivers)
        AutoFillReceivers(lstTmaxReceivers)
        AutoFillReceivers(lstTminReceivers)
        AutoFillReceivers(lstTminminReceivers)
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
                    Case strFacetCol, strFacetColAll
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow, strFacetRowAll
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
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverElement1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomLines()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmax()
        EnableTileAndRibbon()
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


    Private Sub AddRemoveGeomTextBar()
        If rdoClimograph.Checked AndAlso ucrChkText.Checked AndAlso Not ucrReceiverRainC.IsEmpty Then
            clsRoundBarFunction.AddParameter("y", ucrReceiverRainC.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            clsAesGeomTextBarFunction.AddParameter("label", clsRFunctionParameter:=clsRoundBarFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextBarFunction, iPosition:=5, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub AddRemoveGeomTextTmax()
        If rdoClimograph.Checked And ucrChkText.Checked And Not ucrReceiverElement1.IsEmpty Then
            clsRoundTmaxFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)

            If Not ucrReceiverRainC.IsEmpty Then
                clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("geom_text1", clsRFunctionParameter:=clsGeomTextTmaxStarFunction, iPosition:=6, bIncludeArgumentName:=False)
            Else
                clsAesGeomTextTmaxFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0)
                clsBaseOperator.AddParameter("geom_text1", clsRFunctionParameter:=clsGeomTextTmaxFunction, iPosition:=6, bIncludeArgumentName:=False)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_text1")
        End If
    End Sub

    Private Sub AddRemoveGeomTextTmin()
        If rdoClimograph.Checked And ucrChkText.Checked And Not ucrReceiverElement2.IsEmpty Then
            clsRoundTminFunction.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)

            If Not ucrReceiverRainC.IsEmpty Then
                clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("geom_text2", clsRFunctionParameter:=clsGeomTextTminStarFunction, iPosition:=7, bIncludeArgumentName:=False)
            Else
                clsAesGeomTextTminFunction.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
                clsBaseOperator.AddParameter("geom_text2", clsRFunctionParameter:=clsGeomTextTminFunction, iPosition:=7, bIncludeArgumentName:=False)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_text2")
        End If
    End Sub

    Private Sub AddRemoveGeomRibbon()
        If rdoClimograph.Checked And ucrChkRibbon.Checked And ucrChkRibbon.Enabled Then
            clsBaseOperator.AddParameter("scale_x_discrete", clsRFunctionParameter:=clsXScalediscreteFunction, iPosition:=12)

            If Not ucrReceiverRainC.IsEmpty Then
                clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbon1Function, iPosition:=1)
            Else
                clsAesGeomRibbonFunction.AddParameter("ymin", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
                clsAesGeomRibbonFunction.AddParameter("ymax", ucrReceiverElement1.GetVariableNames(False), iPosition:=1)
                clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbonFunction, iPosition:=1)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_ribbon")
            clsBaseOperator.RemoveParameterByName("scale_x_discrete")
        End If
    End Sub

    Private Sub ucrChkTile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTile.ControlValueChanged
        AddRemoveGeomBar()
        EnableTileAndRibbon()
    End Sub

    Private Sub ucrChkRibbon_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRibbon.ControlValueChanged
        AddRemoveGeomRibbon()
        EnableTileAndRibbon()
    End Sub

    Private Sub AddRemoveGeomLines()
        If rdoClimograph.Checked And Not ucrReceiverElement1.IsEmpty Then
            clsAesLineStarFunction.AddParameter("x", ucrReceiverMonthC.GetVariableNames(False), iPosition:=0)

            If Not ucrReceiverRainC.IsEmpty Then
                clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesLineStarFunction.AddParameter("y", clsROperatorParameter:=clsStarOperator, iPosition:=1)
            Else
                clsAesLineStarFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0)
            End If

            clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineStarFunction, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_line")
        End If
    End Sub

    Private Sub AddRemoveGeomLine1()
        If rdoClimograph.Checked And Not ucrReceiverElement2.IsEmpty Then
            clsAesLineStar1Function.AddParameter("x", ucrReceiverMonthC.GetVariableNames(False), iPosition:=0)

            If Not ucrReceiverRainC.IsEmpty Then
                clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesLineStar1Function.AddParameter("y", clsROperatorParameter:=clsStar1Operator, iPosition:=1)
            Else
                clsAesLineStar1Function.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
            End If

            clsBaseOperator.AddParameter("geom_line1", clsRFunctionParameter:=clsGeomLineStar1Function, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_line1")
        End If
    End Sub

    Private Sub AddRemoveGeomBar()
        ' Handle case when rdoClimograph is not checked or ucrReceiverRainC is empty
        If Not rdoClimograph.Checked OrElse ucrReceiverRainC.IsEmpty Then
            RemoveAllParameters()
            Return
        End If

        ' Set common parameters
        clsBarAesFunction.AddParameter("y", ucrReceiverRainC.GetVariableNames(False), iPosition:=0)
        clsLabFunction.AddParameter("fill", Chr(34) & "Rainfall" & Chr(34), iPosition:=0)
        clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabFunction, iPosition:=13)

        ' Handle geom parameters
        If ucrChkTile.Checked Then
            clsBarAesFunction.AddParameter("fill", ucrReceiverRainC.GetVariableNames(False), iPosition:=3)
            clsBaseOperator.AddParameter("geom_tile", clsRFunctionParameter:=clsGeomTileFunction, iPosition:=1)
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
        Else
            clsBarAesFunction.AddParameter("fill", ucrReceiverMonthC.GetVariableNames(False), iPosition:=3)
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName("geom_tile")
        End If

        ' Handle color parameters
        If ucrChkColour.Checked Then
            Dim clsAsnumericFunction As New RFunction
            clsAsnumericFunction.SetRCommand("as.numeric")
            clsAsnumericFunction.AddParameter("x", ucrReceiverMonthC.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)

            clsBaseOperator.RemoveParameterByName("palette")
            clsBaseOperator.RemoveParameterByName("scale_fill_brewer")
            clsBaseOperator.RemoveParameterByName("scale_fill_distiller")

            If rdoViridis.Checked Then
                clsBarAesFunction.AddParameter("fill", clsRFunctionParameter:=clsAsnumericFunction, iPosition:=3)
                clsColourPaletteFunction.AddParameter("option", Chr(34) & ucrInputColourPalette.GetText() & Chr(34), iPosition:=0)
                clsBaseOperator.AddParameter("palette", clsRFunctionParameter:=clsColourPaletteFunction, iPosition:=6)
            ElseIf rdoPalette.Checked AndAlso Not ucrReceiverMonthC.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", ucrReceiverMonthC.GetVariableNames(False), iPosition:=3)
                If ucrReceiverMonthC.strCurrDataType = "factor" OrElse ucrReceiverMonthC.strCurrDataType = "ordered,factor" Then
                    clsFillBrewerFunction.AddParameter("palette", Chr(34) & ucrInputPalette.GetText() & Chr(34))
                    clsBaseOperator.AddParameter("scale_fill_brewer", clsRFunctionParameter:=clsFillBrewerFunction, iPosition:=6)
                Else
                    clsScalefillDistillerFunction.AddParameter("palette", Chr(34) & ucrInputPalette.GetText() & Chr(34))
                    clsBaseOperator.AddParameter("scale_fill_distiller", clsRFunctionParameter:=clsScalefillDistillerFunction, iPosition:=6)
                End If
            Else
                clsBarAesFunction.AddParameter("fill", Chr(34) & "" & Chr(34), iPosition:=3)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("palette")
            clsBaseOperator.RemoveParameterByName("scale_fill_brewer")
            clsBaseOperator.RemoveParameterByName("scale_fill_distiller")
        End If
    End Sub

    Private Sub RemoveAllParameters()
        clsBarAesFunction.RemoveParameterByName("y")
        clsBaseOperator.RemoveParameterByName("geom_tile")
        clsBaseOperator.RemoveParameterByName("geom_bar")
        clsBaseOperator.RemoveParameterByName("labs")
        clsBaseOperator.RemoveParameterByName("palette")
        clsBaseOperator.RemoveParameterByName("scale_fill_brewer")
        clsBaseOperator.RemoveParameterByName("scale_fill_distiller")
    End Sub

    Private Sub EnableTileAndRibbon()
        ucrChkRibbon.Enabled = (Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty) AndAlso Not ucrChkTile.Checked
        ucrChkTile.Enabled = Not ucrChkRibbon.Checked AndAlso Not ucrReceiverRainC.IsEmpty
    End Sub

    Private Sub AddRemoveSecondaryAxis()
        If Not rdoClimograph.Checked Then
            clsBaseOperator.RemoveParameterByName("scale_y_continuous")
            Return
        End If

        ' Add the scale_y_continuous parameter
        clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsScaleycontinuousFunction, iPosition:=9)

        ' Set the "name" parameter based on ucrReceiverRainC
        Dim name As String
        Dim secondaryAxisFunction As RFunction

        If Not ucrReceiverRainC.IsEmpty Then
            name = "Rainfall (mm)"
            secondaryAxisFunction = If(Not ucrReceiverElement1.IsEmpty OrElse Not ucrReceiverElement2.IsEmpty, clsSecondaryAxis2Function, clsSecondaryAxisFunction)
        Else
            name = "Temperature (c)"
            secondaryAxisFunction = clsSecondaryAxis1Function
        End If

        ' Add parameters to clsScaleycontinuousFunction
        clsScaleycontinuousFunction.AddParameter("name", Chr(34) & name & Chr(34), iPosition:=0)
        clsScaleycontinuousFunction.AddParameter("sec.axis", clsRFunctionParameter:=secondaryAxisFunction, iPosition:=1)
    End Sub

    Private Sub ucrReceiverElement2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement2.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomLine1()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmin()
        EnableTileAndRibbon()
        AddRemoveTemBars()
    End Sub

    Private Sub ucrReceiverRainC_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainC.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomBar()
        AddRemoveGeomTextBar()
        EnableTileAndRibbon()
        AddRemoveGeomLines()
        AddRemoveGeomLine1()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmin()
        AddRemoveGeomTextTmax()
    End Sub

    Private Sub ucrReceiverMonthC_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonthC.ControlValueChanged
        If Not ucrReceiverMonthC.IsEmpty Then
            clsBarAesFunction.AddParameter("x", ucrReceiverMonthC.GetVariableNames(False), iPosition:=1)
        Else
            clsBarAesFunction.AddParameter("x", Chr(34) & "" & Chr(34), iPosition:=1)
        End If
        AddRemoveGeomRibbon()
        AddRemoveGeomBar()
        AddRemoveGeomLines()
        AddRemoveGeomLine1()
    End Sub

    Private Sub ucrSelectorClimograph_DataFrameChanged() Handles ucrSelectorClimograph.DataFrameChanged
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        AddRemoveGeomRibbon()
        Dataframechange()
    End Sub

    Private Sub Dataframechange()
        If rdoWalterLieth.Checked Then
            clsGgwalterliethFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        Else
            clsBaseOperator.RemoveParameterByName("ggwalter_lieth")
        End If
    End Sub

    Private Sub toolStripMenuItemBarchartOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemBarchartOptions.Click
        openSdgLayerOptions(clsGeomBarFunction)
    End Sub

    Private Sub toolStripMenuItemTminLineOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTminLineOptions.Click
        openSdgLayerOptionstmin(clsGeomLineStar1Function, clsAesLineStar1Function)
        clsAesLineStar1Function.AddParameter("group", "1", iPosition:=2)
        AddRemoveGeomLine1()
    End Sub

    Private Sub toolStripMenuItemTmaxLineOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTmaxLineOptions.Click
        openSdgLayerOptionstmax(clsGeomLineStarFunction, clsAesLineStarFunction)
        clsAesLineStarFunction.AddParameter("group", "1", iPosition:=2)
        AddRemoveGeomLines()
    End Sub

    Private Sub ucrChkText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkText.ControlValueChanged
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
    End Sub

    Private Sub AddRemoveTemBars()
        If rdoClimateBars.Checked Then
            clsBaseOperator.RemoveParameterByName("geom_text")
            clsBaseOperator.RemoveParameterByName("geom_text1")
            clsBaseOperator.RemoveParameterByName("geom_tile")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameterByName("labs")
            clsBaseOperator.RemoveParameterByName("palette")
            clsBaseOperator.RemoveParameterByName("scale_fill_brewer")
            clsBaseOperator.RemoveParameterByName("scale_fill_distiller")
            clsBaseOperator.RemoveParameterByName("geom_line1")
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsBaseOperator.RemoveParameterByName("geom_text2")
            clsBaseOperator.RemoveParameterByName("geom_ribbon")
            clsBaseOperator.RemoveParameterByName("scale_x_discrete")
            clsBaseOperator.RemoveParameterByName("scale_y_continuous")
            clsBaseOperator.RemoveParameterByName("facets")
            clsBaseOperator.RemoveParameterByName("facets1")
            If Not ucrReceiverFacetBar.IsEmpty Then
                'Tem Functions
                clsAesRainGgplotFunction.AddParameter("x", ucrReceiverMonthBar.GetVariableNames(False), iPosition:=0)
                clsAesRainGgplotFunction.AddParameter("y", ucrReceiverRainBar.GetVariableNames(False), iPosition:=1)
                clsRainGgplotFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
                clsRainGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesRainGgplotFunction, iPosition:=1, bIncludeArgumentName:=False)

                clsRainRoundFunction.AddParameter("x", ucrReceiverRainBar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesRainBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsRainRoundFunction, iPosition:=0)
                clsRainBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesRainBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)

                clsPlus10Operator.AddParameter("left", clsRFunctionParameter:=clsLabsRainFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus10Operator.AddParameter("right", clsRFunctionParameter:=clsFacetFunction2, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus3Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus3Operator.AddParameter("right", clsROperatorParameter:=clsPlus10Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus2Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus2Operator.AddParameter("right", clsROperatorParameter:=clsPlus3Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus1Operator.AddParameter("left", clsRFunctionParameter:=clsRainGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus1Operator.AddParameter("right", clsROperatorParameter:=clsPlus2Operator, iPosition:=1, bIncludeArgumentName:=False)

                'Tem Functions
                clsAesTemGgplotFunction.AddParameter("x", ucrReceiverMonthBar.GetVariableNames(False), iPosition:=0)
                clsTemGgplotFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
                clsTemGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTemGgplotFunction, iPosition:=1, bIncludeArgumentName:=False)

                clsAesTmaxBarFunction1.AddParameter("y", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0)
                clsTmaxBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTmaxBarFunction1, iPosition:=0, bIncludeArgumentName:=False)

                clsAesTminBarFunction1.AddParameter("y", "-" & ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0)
                clsTminBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTminBarFunction1, iPosition:=0, bIncludeArgumentName:=False)

                clsTmaxRoundFunction.AddParameter("x", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesTmaxBarTextFunction.AddParameter("y", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0)
                clsAesTmaxBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsTmaxRoundFunction, iPosition:=1)
                clsTmaxBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTmaxBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)

                clsTminRoundFunction.AddParameter("x", ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesTminBarTextFunction.AddParameter("y", "-" & ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0)
                clsAesTminBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsTminRoundFunction, iPosition:=1)
                clsTminBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTminBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)

                clsPlus11Operator.AddParameter("left", clsRFunctionParameter:=clsLabsTempFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus11Operator.AddParameter("right", clsRFunctionParameter:=clsFacetFunction2, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus9Operator.AddParameter("left", clsRFunctionParameter:=clsTminBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus9Operator.AddParameter("right", clsROperatorParameter:=clsPlus11Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus8Operator.AddParameter("left", clsRFunctionParameter:=clsTmaxBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus8Operator.AddParameter("right", clsROperatorParameter:=clsPlus9Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus7Operator.AddParameter("left", clsRFunctionParameter:=clsTminBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus7Operator.AddParameter("right", clsROperatorParameter:=clsPlus8Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus6Operator.AddParameter("left", clsRFunctionParameter:=clsTmaxBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus6Operator.AddParameter("right", clsROperatorParameter:=clsPlus7Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus5Operator.AddParameter("left", clsRFunctionParameter:=clsTemGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus5Operator.AddParameter("right", clsROperatorParameter:=clsPlus6Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("plot_grid", clsRFunctionParameter:=clsPlotGridFunction, iPosition:=0)

            Else
                clsAesRainGgplotFunction.AddParameter("x", ucrReceiverMonthBar.GetVariableNames(False), iPosition:=0)
                clsAesRainGgplotFunction.AddParameter("y", ucrReceiverRainBar.GetVariableNames(False), iPosition:=1)
                clsRainGgplotFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
                clsRainGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesRainGgplotFunction, iPosition:=1, bIncludeArgumentName:=False)
                clsRainRoundFunction.AddParameter("x", ucrReceiverRainBar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesRainBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsRainRoundFunction, iPosition:=0)
                clsRainBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesRainBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus3Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus3Operator.AddParameter("right", clsRFunctionParameter:=clsLabsRainFunction, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus2Operator.AddParameter("left", clsRFunctionParameter:=clsRainBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus2Operator.AddParameter("right", clsROperatorParameter:=clsPlus3Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus1Operator.AddParameter("left", clsRFunctionParameter:=clsRainGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus1Operator.AddParameter("right", clsROperatorParameter:=clsPlus2Operator, iPosition:=1, bIncludeArgumentName:=False)

                clsAesTemGgplotFunction.AddParameter("x", ucrReceiverMonthBar.GetVariableNames(False), iPosition:=0)
                clsTemGgplotFunction.AddParameter("data", ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
                clsTemGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTemGgplotFunction, iPosition:=1, bIncludeArgumentName:=False)

                clsAesTmaxBarFunction1.AddParameter("y", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0)
                clsTmaxBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTmaxBarFunction1, iPosition:=0, bIncludeArgumentName:=False)

                clsAesTminBarFunction1.AddParameter("y", "-" & ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0)
                clsTminBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTminBarFunction1, iPosition:=0, bIncludeArgumentName:=False)

                clsTmaxRoundFunction.AddParameter("x", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesTmaxBarTextFunction.AddParameter("y", ucrReceiverElement1Bar.GetVariableNames(False), iPosition:=0)
                clsAesTmaxBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsTmaxRoundFunction, iPosition:=1)
                clsTmaxBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTmaxBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)

                clsTminRoundFunction.AddParameter("x", ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                clsAesTminBarTextFunction.AddParameter("y", "-" & ucrReceiverElement2Bar.GetVariableNames(False), iPosition:=0)
                clsAesTminBarTextFunction.AddParameter("label", clsRFunctionParameter:=clsTminRoundFunction, iPosition:=1)
                clsTminBarTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesTminBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus9Operator.AddParameter("left", clsRFunctionParameter:=clsTminBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus9Operator.AddParameter("right", clsRFunctionParameter:=clsLabsTempFunction, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus8Operator.AddParameter("left", clsRFunctionParameter:=clsTmaxBarTextFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus8Operator.AddParameter("right", clsROperatorParameter:=clsPlus9Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus7Operator.AddParameter("left", clsRFunctionParameter:=clsTminBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus7Operator.AddParameter("right", clsROperatorParameter:=clsPlus8Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus6Operator.AddParameter("left", clsRFunctionParameter:=clsTmaxBarFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus6Operator.AddParameter("right", clsROperatorParameter:=clsPlus7Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsPlus5Operator.AddParameter("left", clsRFunctionParameter:=clsTemGgplotFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsPlus5Operator.AddParameter("right", clsROperatorParameter:=clsPlus6Operator, iPosition:=1, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("plot_grid", clsRFunctionParameter:=clsPlotGridFunction, iPosition:=0)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("plot_grid")
        End If
    End Sub

    Private Sub ucrSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSave.ControlValueChanged
        If ucrSave.ucrChkSave.Checked Then
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & ucrSave.GetText & Chr(34), iPosition:=1)
        Else
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColour.ControlValueChanged, ucrChkColour.ControlValueChanged, ucrInputPalette.ControlValueChanged, ucrInputColourPalette.ControlValueChanged
        AddRemoveGeomBar()
    End Sub

    Private Sub ResizeDialogue()
        If rdoClimograph.Checked Then
            Me.Size = New Size(488, 617)
            Me.ucrSave.Location = New Point(14, 493)
            Me.ucrBase.Location = New Point(12, 520)
        Else
            Me.Size = New Size(488, 417)
            Me.ucrSave.Location = New Point(14, 293)
            Me.ucrBase.Location = New Point(12, 320)
        End If
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverAbsolute.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMaxtem.ControlContentsChanged, ucrReceiverMintemp.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrReceiverElement1.ControlContentsChanged, ucrReceiverElement2.ControlContentsChanged, ucrReceiverMonthC.ControlContentsChanged, ucrReceiverRainC.ControlContentsChanged, ucrReceiverElement1Bar.ControlContentsChanged, ucrReceiverElement2Bar.ControlContentsChanged, ucrReceiverMonthBar.ControlContentsChanged, ucrReceiverRainBar.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverElement1Bar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1Bar.ControlValueChanged, ucrReceiverMonthBar.ControlValueChanged, ucrReceiverRainBar.ControlValueChanged, ucrReceiverElement2Bar.ControlValueChanged
        AddRemoveTemBars()
    End Sub

    Private Sub AutoFillReceivers(lstReceivers As List(Of ucrReceiverSingle))

        If isFilling OrElse lstReceivers Is Nothing Then
            Exit Sub
        End If

        isFilling = True

        ' Change the event handler to the new method
        'RemoveHandler ucrSelectorClimograph.ControlValueChanged, AddressOf OnControlValueChanged

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver
        Dim bFound As Boolean = False

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorClimograph.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        'AddHandler ucrSelectorClimograph.ControlValueChanged, AddressOf OnControlValueChanged

        isFilling = False
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function
End Class