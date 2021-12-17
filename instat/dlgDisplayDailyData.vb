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

Imports instat
Imports instat.Translations
Public Class dlgDisplayDailyData
    Private iBasicHeight As Integer
    Private iBaseMaxY As Integer
    Private iSaveYLocation As Integer
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True
    Private lstCheckboxes As New List(Of ucrCheck)
    Private clsDisplayDailyTable, clsDisplayDailyGraphFunction, clsConcFunction As New RFunction
    Private clsGGplotFunction, clsGeomLineFunction, clsGeomRugFunction, clsThemeFunction, clsThemeGreyFunction As New RFunction
    Private clsIdVarsFunction, clsFacetFunction, clsGgplotAesFunction, clsGGplotElementText, clsXLabFunction As New RFunction
    Private clsGgPlotOperator, clsDisplayDailyGraphOperator, clsDisplayDailyTableOperator, clsNAFilterOperator As New ROperator
    Private clsStationElemFacetOperator As New ROperator
    Private clsLabelWrapGenFunction As New RFunction

    Private Sub dlgDisplayDailyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bRCodeSet = False
        If bFirstLoad Then
            iBasicHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            iSaveYLocation = ucrSaveGraph.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bRCodeSet = True
        DialogSize()
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 361

        Dim dctBarColour As New Dictionary(Of String, String)
        Dim dctRugColour As New Dictionary(Of String, String)
        Dim dctGRugColour As New Dictionary(Of String, String)
        Dim dctSummary As New Dictionary(Of String, String)
        Dim dctMissingvalues As New Dictionary(Of String, String)
        Dim dctTracevalues As New Dictionary(Of String, String)
        Dim dctZeroValues As New Dictionary(Of String, String)
        Dim dctScale As New Dictionary(Of String, String)
        lstCheckboxes = New List(Of ucrCheck)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsString()

        ucrReceiverMultipleElements.SetParameter(New RParameter("data", 0))
        ucrReceiverMultipleElements.SetParameterIsString()
        ucrReceiverMultipleElements.Selector = ucrSelectorDisplayDailyClimaticData

        ucrReceiverStations.SetParameter(New RParameter("station_col", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True

        ucrReceiverYear.SetParameter(New RParameter("year_col", 3))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.SetClimaticType("year")

        ucrReceiverDate.SetParameter(New RParameter("date_col", 2))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDayOfYear.SetParameter(New RParameter("doy_col", 5))
        ucrReceiverDayOfYear.SetParameterIsString()
        ucrReceiverDayOfYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDayOfYear.SetClimaticType("doy")
        ucrReceiverDayOfYear.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("climatic_element", 1))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.Selector = ucrSelectorDisplayDailyClimaticData


        ucrNudUpperYaxis.SetParameter(New RParameter("upper_limit", 9))
        ucrNudUpperYaxis.SetMinMax(0, Integer.MaxValue)


        ucrInputGraphRugColur.SetParameter(New RParameter("colour", 1))
        dctGRugColour.Add("Black", Chr(34) & "black" & Chr(34))
        dctGRugColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctGRugColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctGRugColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctGRugColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctGRugColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        dctGRugColour.Add("White", Chr(34) & "white" & Chr(34))
        dctGRugColour.Add("None", Chr(34) & "none" & Chr(34))
        ucrInputGraphRugColur.SetItems(dctGRugColour)
        ucrInputGraphRugColur.bAllowNonConditionValues = True


        ucrInputBarColour.SetParameter(New RParameter("bar_colour", 7))
        dctBarColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctBarColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctBarColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctBarColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctBarColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        ucrInputBarColour.SetItems(dctBarColour)

        ucrInputRugColour.SetParameter(New RParameter("rug_colour", 8))
        dctRugColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctRugColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctRugColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctRugColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctRugColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        ucrInputRugColour.SetItems(dctRugColour)
        ucrInputRugColour.bAllowNonConditionValues = True

        ucrChkSum.SetParameter(New RParameter("sum", 0), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "sum" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSum.SetText("Sum")

        ucrChkMax.SetParameter(New RParameter("max", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "max" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMax.SetText("Max")

        ucrChkMin.SetParameter(New RParameter("min", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "min" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMin.SetText("Min")

        ucrChkMean.SetParameter(New RParameter("mean", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mean" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMean.SetText("Mean")

        ucrChkMedian.SetParameter(New RParameter("median", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "median" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMedian.SetText("Median")

        ucrChkIQR.SetParameter(New RParameter("IQR", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "IQR" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkIQR.SetText("IQR")

        ucrChkSumMissing.SetParameter(New RParameter("summary_count_missing", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_count_missing" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSumMissing.SetText("N Missing")

        ucrNudNumberOfColumns.SetParameter(New RParameter("ncol", 1))
        ucrNudNumberOfColumns.SetMinMax(1, Integer.MaxValue)

        ucrChkNumberOfColumns.AddParameterPresentCondition(True, "ncol")
        ucrChkNumberOfColumns.AddParameterPresentCondition(False, "ncol", False)
        ucrChkNumberOfColumns.SetText("Number of Column(s):")

        ucrInputScale.SetParameter(New RParameter("scales", 0))
        dctScale.Add("Free_y", Chr(34) & "free_y" & Chr(34))
        dctScale.Add("Free_x", Chr(34) & "free_x" & Chr(34))
        dctScale.Add("Free", Chr(34) & "free" & Chr(34))
        dctScale.Add("Fixed", Chr(34) & "fixed" & Chr(34))
        ucrInputScale.SetItems(dctScale)
        ucrInputScale.SetDropDownStyleAsNonEditable()


        lstCheckboxes.AddRange({ucrChkSum, ucrChkMax, ucrChkMin, ucrChkMean, ucrChkMedian, ucrChkIQR, ucrChkSumMissing})

        ucrChkMissing.AddParameterPresentCondition(True, "Misscode")
        ucrChkMissing.AddParameterPresentCondition(False, "Misscode", False)
        ucrChkMissing.SetText("Missing Values")

        ucrInputComboMissing.SetParameter(New RParameter("Misscode", 5))
        dctMissingvalues.Add("m", Chr(34) & "m" & Chr(34))
        dctMissingvalues.Add("miss", Chr(34) & "miss" & Chr(34))
        dctMissingvalues.Add("NA", Chr(34) & "NA" & Chr(34))
        dctMissingvalues.Add("-", Chr(34) & "-" & Chr(34))
        ucrInputComboMissing.SetItems(dctMissingvalues)
        ucrInputComboMissing.bAllowNonConditionValues = True

        ucrChkTrace.SetParameter(ucrInputComboTrace.GetParameter())
        ucrChkTrace.AddParameterPresentCondition(True, "Tracecode")
        ucrChkTrace.AddParameterPresentCondition(False, "Tracecode", False)
        ucrChkTrace.SetText("Trace Values")
        ucrInputComboTrace.SetParameter(New RParameter("Tracecode", 6))
        dctTracevalues.Add("tr", Chr(34) & "tr" & Chr(34))
        ucrInputComboTrace.SetItems(dctTracevalues)
        ucrInputComboTrace.bAllowNonConditionValues = True

        ucrChkZero.SetParameter(ucrInputComboZero.GetParameter())
        ucrChkZero.AddParameterPresentCondition(True, "Zerocode")
        ucrChkZero.AddParameterPresentCondition(False, "Zerocode", False)
        ucrChkZero.SetText("Zero Values")
        ucrInputComboZero.SetParameter(New RParameter("Zerocode", 7))
        dctZeroValues.Add("--", Chr(34) & "--" & Chr(34))
        ucrInputComboZero.SetItems(dctZeroValues)
        ucrInputComboZero.bAllowNonConditionValues = True

        ucrInputFacetBy.SetLinkedDisplayControl(lblFacetby)
        ucrInputFacetBy.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames)
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraphByYear)
        ucrPnlFrequencyDisplay.AddParameterPresentCondition(rdoGraph, "ggplot")
        ucrPnlFrequencyDisplay.AddParameterPresentCondition(rdoGraphByYear, "daily_graph")
        ucrPnlFrequencyDisplay.AddParameterPresentCondition(rdoTable, "daily_table")
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrNudUpperYaxis, {rdoGraphByYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=100)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrReceiverMultipleElements, ucrInputFacetBy, ucrChkNumberOfColumns}, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputScale, ucrInputGraphRugColur}, {rdoGraph}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkMissing, {rdoTable}, bNewLinkedChangeToDefaultState:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboTrace, ucrChkTrace}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboZero, ucrChkZero}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkSum, {rdoTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrSaveGraph, {rdoGraph, rdoGraphByYear}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkNumberOfColumns.AddToLinkedControls(ucrNudNumberOfColumns, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkSum.SetLinkedDisplayControl(grpSummary)
        ucrInputScale.SetLinkedDisplayControl(grpFacet)
        ucrInputScale.SetLinkedDisplayControl(lblScales)
        ucrInputGraphRugColur.SetLinkedDisplayControl(lblGRugColour)
        ucrReceiverMultipleElements.SetLinkedDisplayControl(lblElements)
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)


        ucrChkMissing.AddToLinkedControls({ucrInputComboMissing}, {True}, bNewLinkedUpdateFunction:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="m")
        ucrChkTrace.AddToLinkedControls({ucrInputComboTrace}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="tr")
        ucrChkZero.AddToLinkedControls({ucrInputComboZero}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="--")
        ucrNudUpperYaxis.SetLinkedDisplayControl(grpGraph)
    End Sub

    Private Sub SetDefaults()
        clsGgPlotOperator = New ROperator
        clsGGplotFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsGeomRugFunction = New RFunction
        clsThemeGreyFunction = New RFunction
        clsThemeFunction = New RFunction
        clsGgplotAesFunction = New RFunction
        clsGGplotElementText = New RFunction
        clsIdVarsFunction = New RFunction
        clsDisplayDailyGraphOperator = New ROperator
        clsDisplayDailyTableOperator = New ROperator

        clsDisplayDailyTable = New RFunction
        clsDisplayDailyGraphFunction = New RFunction
        clsConcFunction = New RFunction
        clsNAFilterOperator = New ROperator
        clsFacetFunction = New RFunction
        clsXLabFunction = New RFunction
        clsStationElemFacetOperator = New ROperator
        clsLabelWrapGenFunction = New RFunction

        ucrNudNumberOfColumns.SetText("1")
        ucrSaveGraph.Reset()

        clsStationElemFacetOperator.SetOperation("~")

        clsXLabFunction.SetPackageName("ggplot2")
        clsXLabFunction.SetRCommand("xlab")
        clsXLabFunction.AddParameter("label", "NULL", iPosition:=0, bIncludeArgumentName:=False)

        clsLabelWrapGenFunction.SetRCommand("label_wrap_gen")
        clsLabelWrapGenFunction.AddParameter("multi_line", "FALSE", iPosition:=0)


        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_wrap")
        clsFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34), iPosition:=0)
        clsFacetFunction.AddParameter("ncol", 1, iPosition:=1)
        clsFacetFunction.AddParameter("facet", clsROperatorParameter:=clsStationElemFacetOperator, iPosition:=2)

        clsNAFilterOperator.SetOperation("%>%")
        clsNAFilterOperator.AddParameter("filter", "filter(is.na(value))", iPosition:=1)
        clsNAFilterOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsDisplayDailyGraphOperator.SetOperation("")
        clsDisplayDailyTableOperator.SetOperation("")


        ucrSelectorDisplayDailyClimaticData.Reset()
        ucrReceiverMultipleElements.SetMeAsReceiver()

        clsIdVarsFunction.SetRCommand("c")
        clsGGplotFunction.SetPackageName("ggplot2")
        clsGGplotFunction.SetRCommand("ggplot")
        clsGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAesFunction)
        clsGGplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsGgplotAesFunction.SetPackageName("ggplot2")
        clsGgplotAesFunction.SetRCommand("aes")
        clsGgplotAesFunction.AddParameter("y", "value", iPosition:=1)
        clsGgplotAesFunction.AddParameter("colour", "variable", iPosition:=2)

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")

        clsGeomRugFunction.SetPackageName("ggplot2")
        clsGeomRugFunction.SetRCommand("geom_rug")
        clsGeomRugFunction.AddParameter("data", clsROperatorParameter:=clsNAFilterOperator, iPosition:=0)
        clsGeomRugFunction.AddParameter("colour", Chr(34) & "black" & Chr(34), iPosition:=1)

        clsThemeGreyFunction.SetRCommand("theme_grey")

        clsThemeFunction.SetPackageName("ggplot2")
        clsThemeFunction.SetRCommand("theme")
        clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsGGplotElementText, iPosition:=0)
        clsThemeFunction.AddParameter("legend.position", Chr(34) & "none" & Chr(34), iPosition:=1)

        clsGGplotElementText.SetPackageName("ggplot2")
        clsGGplotElementText.SetRCommand("element_text")

        clsGgPlotOperator.SetOperation("+")
        clsGgPlotOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGGplotFunction, iPosition:=0)
        clsGgPlotOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineFunction, iPosition:=1)
        clsGgPlotOperator.AddParameter("geom_rug", clsRFunctionParameter:=clsGeomRugFunction, iPosition:=2)
        clsGgPlotOperator.AddParameter("theme_grey", clsRFunctionParameter:=clsThemeGreyFunction, iPosition:=3)
        clsGgPlotOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=4)
        clsGgPlotOperator.AddParameter("facet", clsRFunctionParameter:=clsFacetFunction, iPosition:=5)
        clsGgPlotOperator.AddParameter("xlab", clsRFunctionParameter:=clsXLabFunction, iPosition:=6)

        clsGgPlotOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsConcFunction.SetRCommand("c")
        clsConcFunction.AddParameter("sum", Chr(34) & "sum" & Chr(34), iPosition:=0)
        clsDisplayDailyGraphFunction.AddParameter("rug_colour", Chr(34) & "red" & Chr(34))
        clsDisplayDailyGraphFunction.AddParameter("bar_colour", Chr(34) & "blue" & Chr(34))
        clsDisplayDailyGraphFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_graph")
        clsDisplayDailyTable.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_table")
        clsDisplayDailyTable.AddParameter("monstats", clsRFunctionParameter:=clsConcFunction, iPosition:=8)
        clsDisplayDailyGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")

        clsDisplayDailyGraphOperator.AddParameter("daily_graph", clsRFunctionParameter:=clsDisplayDailyGraphFunction)
        clsDisplayDailyTableOperator.AddParameter("daily_table", clsRFunctionParameter:=clsDisplayDailyTable)

        ucrBase.clsRsyntax.SetBaseROperator(clsGgPlotOperator)

        SetFacetItems()

        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("year_col", 3), iAdditionalPairNo:=1)

        ucrReceiverStations.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("station_col", 4), iAdditionalPairNo:=1)
        ucrReceiverStations.AddAdditionalCodeParameterPair(clsIdVarsFunction, New RParameter("station", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrReceiverDate.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("date_col", 2), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsIdVarsFunction, New RParameter("date", iNewPosition:=1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsDisplayDailyGraphFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)

        ucrChkSum.SetRCode(clsConcFunction, bReset)
        ucrChkMax.SetRCode(clsConcFunction, bReset)
        ucrChkMin.SetRCode(clsConcFunction, bReset)
        ucrChkMean.SetRCode(clsConcFunction, bReset)
        ucrChkMedian.SetRCode(clsConcFunction, bReset)
        ucrChkIQR.SetRCode(clsConcFunction, bReset)
        ucrChkSumMissing.SetRCode(clsConcFunction, bReset)

        ucrChkTrace.SetRCode(clsDisplayDailyTable, bReset)
        ucrChkZero.SetRCode(clsDisplayDailyTable, bReset)
        ucrChkMissing.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboZero.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboTrace.SetRCode(clsDisplayDailyTable, bReset)
        ucrReceiverDate.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverStations.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverDayOfYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrSelectorDisplayDailyClimaticData.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputRugColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrInputBarColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrNudUpperYaxis.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverElement.SetRCode(clsDisplayDailyTable, bReset)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsDisplayDailyGraphFunction, New RParameter("climatic_element", 1), iAdditionalPairNo:=1)
        ucrSaveGraph.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrSaveGraph.AddAdditionalRCode(clsGgPlotOperator)
        ucrPnlFrequencyDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrInputScale.SetRCode(clsFacetFunction, bReset)
        ucrNudNumberOfColumns.SetRCode(clsFacetFunction, bReset)
        ucrChkNumberOfColumns.SetRCode(clsFacetFunction, bReset)
        ucrInputGraphRugColur.SetRCode(clsGeomRugFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoGraphByYear.Checked AndAlso (Not ucrReceiverDate.IsEmpty OrElse Not ucrReceiverDayOfYear.IsEmpty OrElse Not ucrReceiverStations.IsEmpty) AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso ucrNudUpperYaxis.GetText <> "" AndAlso Not ucrInputRugColour.IsEmpty AndAlso Not ucrInputBarColour.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf rdoTable.Checked AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso (ucrChkSum.Checked OrElse ucrChkMin.Checked OrElse ucrChkMax.Checked OrElse ucrChkMean.Checked OrElse ucrChkMedian.Checked OrElse ucrChkIQR.Checked OrElse ucrChkSumMissing.Checked) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoGraph.Checked AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverMultipleElements.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub DialogSize()
        If rdoGraphByYear.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight * 0.93)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.1)
            ucrSaveGraph.Location = New Point(ucrSaveGraph.Location.X, iSaveYLocation / 1.1)
        ElseIf rdoTable.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
        ElseIf rdoGraph.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight / 1.1)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.116)
            ucrSaveGraph.Location = New Point(ucrSaveGraph.Location.X, iSaveYLocation / 1.12)
        End If
    End Sub

    Private Sub ucrPnlFrequencyDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFrequencyDisplay.ControlValueChanged
        DialogSize()
        If rdoGraphByYear.Checked Then
            ucrSaveGraph.SetPrefix("graph_by_year")
        ElseIf rdoGraph.checked Then
            ucrSaveGraph.SetPrefix("graph")
        End If
        If rdoGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            ucrReceiverMultipleElements.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseROperator(clsGgPlotOperator)
            ucrSelectorDisplayDailyClimaticData.SetParameterIsrfunction()
            ucrReceiverDate.SetValuesToIgnore({Chr(34) & Chr(34)})
        Else
            ucrSelectorDisplayDailyClimaticData.SetParameterIsString()
            If rdoGraphByYear.Checked Then
                ucrReceiverElement.SetMeAsReceiver()
                ucrBase.clsRsyntax.iCallType = 3
                ucrBase.clsRsyntax.SetBaseROperator(clsDisplayDailyGraphOperator)
            Else
                ucrReceiverElement.SetMeAsReceiver()
                ucrBase.clsRsyntax.iCallType = 2
                ucrBase.clsRsyntax.SetBaseROperator(clsDisplayDailyTableOperator)
            End If
        End If
        StackingFunction()
    End Sub

    Private Sub ucrSelectorDisplayDailyClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDisplayDailyClimaticData.ControlValueChanged, ucrReceiverStations.ControlValueChanged
        StackingFunction()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary> 
    ''' If the Graph radio button is checked, takes all the columns in the multiple receiver, 
    ''' excluding date and station columns, and stacks them.
    ''' If the radio button is unchecked, unstacks the columns in the multiple receiver.
    ''' If the multiple receiver is empty then this subroutine does nothing.
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub StackingFunction()
        If Not ucrReceiverMultipleElements.IsEmpty Then
            If rdoGraph.Checked Then
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("stack_data", "TRUE")
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("measure.vars", ucrReceiverMultipleElements.GetVariableNames())
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.AddParameter("id.vars", clsRFunctionParameter:=clsIdVarsFunction)
            Else
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("measure.vars")
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("stack_data")
                ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame.RemoveParameterByName("id.vars")
            End If
        End If
    End Sub

    Private Sub ucrReceiverMultipleElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleElements.ControlValueChanged, ucrReceiverStations.ControlValueChanged
        If bRCodeSet Then
            SetFacetItems()
        End If
        StackingFunction()
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        clsGgplotAesFunction.AddParameter("x", ucrReceiverDate.GetVariableNames(False), iPosition:=0)
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverDayOfYear.ControlContentsChanged, ucrReceiverMultipleElements.ControlContentsChanged, ucrNudUpperYaxis.ControlContentsChanged, ucrInputRugColour.ControlContentsChanged, ucrInputBarColour.ControlContentsChanged, ucrPnlFrequencyDisplay.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrChkSum.ControlContentsChanged, ucrChkMax.ControlContentsChanged, ucrChkMin.ControlContentsChanged, ucrChkMean.ControlContentsChanged, ucrChkMedian.ControlContentsChanged, ucrChkIQR.ControlContentsChanged, ucrChkSumMissing.ControlContentsChanged
        TestOkEnabled()
    End Sub
    '''--------------------------------------------------------------------------------------------
    ''' <summary> 
    ''' Sets the facet combobox text:
    ''' <list type="bullet">
    '''     <item><description>
    '''             If the station receiver is not empty and the multiple element receiver has more 
    '''             one element then sets the facet combobox text to "Station-Element " and 
    '''             "Element - station"
    '''     </description></item><item><description>
    '''             If the station receiver is not empty and the multiple element receiver has 
    '''             less than 2 elements then sets the facet combobox text to "Station"
    '''     </description></item><item><description>
    '''             If the station receiver is empty and the multiple element receiver has 2 or 
    '''             more elements then sets the facet combobox text to "Element"
    '''     </description></item><item><description>
    '''             If the station receiver is empty and the multiple element receiver has no 
    '''             elements then sets the facet combobox text to "No Facets"
    '''     </description></item>
    ''' </list>   
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub SetFacetItems()
        If Not ucrReceiverStations.IsEmpty AndAlso ucrReceiverMultipleElements.GetCount > 1 Then
            ucrInputFacetBy.SetItems({"Station-Element", "Element-Station"})
            ucrInputFacetBy.SetText("Station-Element")
        ElseIf Not ucrReceiverStations.IsEmpty AndAlso ucrReceiverMultipleElements.GetCount <= 1 Then
            ucrInputFacetBy.SetItems({"Station"})
            ucrInputFacetBy.SetText("Station")
        ElseIf ucrReceiverStations.IsEmpty AndAlso ucrReceiverMultipleElements.GetCount >= 1 Then
            ucrInputFacetBy.SetItems({"Element"})
            ucrInputFacetBy.SetText("Element")
        Else
            ucrInputFacetBy.SetItems({"No Facets"})
            ucrInputFacetBy.SetText("No Facets")
        End If
    End Sub

    Private Sub ucrInputFacetBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFacetBy.ControlValueChanged
        clsStationElemFacetOperator.ClearParameters()
        Select Case ucrInputFacetBy.GetText()
            Case "Station-Element"
                clsStationElemFacetOperator.AddParameter("station", ucrReceiverStations.GetVariableNames(False), iPosition:=0)
                clsStationElemFacetOperator.AddParameter("variable", "variable", iPosition:=1)
            Case "Element-Station"
                clsStationElemFacetOperator.AddParameter("variable", "variable", iPosition:=0)
                clsStationElemFacetOperator.AddParameter("station", ucrReceiverStations.GetVariableNames(False), iPosition:=1)
            Case "Station"
                clsStationElemFacetOperator.AddParameter("First", "", iPosition:=0)
                clsStationElemFacetOperator.AddParameter("station", ucrReceiverStations.GetVariableNames(False), iPosition:=1)
            Case "Element"
                clsStationElemFacetOperator.AddParameter("variable", "variable", iPosition:=1)
                clsStationElemFacetOperator.AddParameter("First", "", iPosition:=0)
        End Select

        If ucrInputFacetBy.GetText() = "Station-Element" OrElse ucrInputFacetBy.GetText() = "Element-Station" Then
            clsFacetFunction.AddParameter("labeller", clsRFunctionParameter:=clsLabelWrapGenFunction, iPosition:=3)
        Else
            clsFacetFunction.RemoveParameterByName("labeller")
        End If
    End Sub

    Private Sub ucrSelectorDisplayDailyClimaticData_DataFrameChanged() Handles ucrSelectorDisplayDailyClimaticData.DataFrameChanged
        clsGGplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsNAFilterOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub ucrInputGraphRugColur_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputGraphRugColur.ControlValueChanged
        If ucrInputGraphRugColur.GetText = "None" Then
            clsGgPlotOperator.RemoveParameterByName("geom_rug")
        Else

            clsGgPlotOperator.AddParameter("geom_rug", clsRFunctionParameter:=clsGeomRugFunction, iPosition:=2)
        End If
    End Sub
End Class