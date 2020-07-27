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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstCheckboxes As New List(Of ucrCheck)
    Private clsDisplayDailyTable, clsDisplayDailyGraphFunction, clsConcFunction As New RFunction
    Private clsGGplotFunction, clsGeomLineFunction, clsGeomRugFunction, clsThemeFunction, clsThemeGreyFunction As New RFunction
    Private clsIdVarsFunction, clsFacetFunction, clsGgplotAesFunction, clsGGplotElementText, clsXLabFunction As New RFunction
    Private clsGgPlotOperator, clsDisplayDailyGraphOperator, clsDisplayDailyTableOperator, clsNAFilterOperator As New ROperator
    Private clsFacetOperator As New ROperator

    Private Sub dlgDisplayDailyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            iBasicHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        DialogSize()
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 361

        Dim dctBarColour As New Dictionary(Of String, String)
        Dim dctRugColour As New Dictionary(Of String, String)
        Dim dctSummary As New Dictionary(Of String, String)
        Dim dctMissingvalues As New Dictionary(Of String, String)
        Dim dctTracevalues As New Dictionary(Of String, String)
        Dim dctZeroValues As New Dictionary(Of String, String)
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

        ucrInputBarColour.SetParameter(New RParameter("bar_colour", 7))
        dctBarColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctBarColour.Add("Red", Chr(34) & "red" & Chr(34))
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

        ucrChkFreeYScales.SetParameter(New RParameter("scales", 2), bNewChangeParameterValue:=False)
        ucrChkFreeYScales.SetText("Free y Scale")

        lstCheckboxes.AddRange({ucrChkSum, ucrChkMax, ucrChkMin, ucrChkMean, ucrChkMedian, ucrChkIQR, ucrChkSumMissing})

        ucrChkMissing.SetParameter(ucrInputComboMissing.GetParameter)
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

        ucrSaveGraph.SetPrefix("Graph")
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
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrReceiverMultipleElements, ucrChkFreeYScales}, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboMissing, ucrChkMissing}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboTrace, ucrChkTrace}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboZero, ucrChkZero}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrChkSum, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSum.SetLinkedDisplayControl(grpSummary)

        ucrChkMissing.AddToLinkedControls({ucrInputComboMissing}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        clsFacetOperator = New ROperator

        clsXLabFunction.SetPackageName("ggplot2")
        clsXLabFunction.SetRCommand("xlab")
        clsXLabFunction.AddParameter("label", Chr(34) & "" & Chr(34),, iPosition:=0, bIncludeArgumentName:=False)


        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_grid")
        clsFacetFunction.AddParameter("scales", Chr(34) & "free_y" & Chr(34), iPosition:=0)

        clsNAFilterOperator.SetOperation("%>%")
        clsNAFilterOperator.AddParameter("filter", "filter(is.na(value))", iPosition:=1)

        clsDisplayDailyGraphOperator.SetOperation("")
        clsDisplayDailyTableOperator.SetOperation("")


        ucrSelectorDisplayDailyClimaticData.Reset()
        ucrReceiverElement.SetMeAsReceiver()

        clsIdVarsFunction.SetRCommand("c")
        clsGGplotFunction.SetPackageName("ggplot2")
        clsGGplotFunction.SetRCommand("ggplot")
        clsGGplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAesFunction)

        clsGgplotAesFunction.SetPackageName("ggplot2")
        clsGgplotAesFunction.SetRCommand("aes")
        clsGgplotAesFunction.AddParameter("y", "value", iPosition:=1)
        clsGgplotAesFunction.AddParameter("colour", "variable", iPosition:=2)

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")

        clsFacetOperator.SetOperation("~")
        clsFacetOperator.AddParameter("variable", "variable", bIncludeArgumentName:=False, iPosition:=0)

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
        clsDisplayDailyTable.AddParameter("Misscode", Chr(34) & "m" & Chr(34), iPosition:=5)
        clsDisplayDailyGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")

        clsDisplayDailyGraphOperator.AddParameter("daily_graph", clsRFunctionParameter:=clsDisplayDailyGraphFunction)
        clsDisplayDailyTableOperator.AddParameter("daily_table", clsRFunctionParameter:=clsDisplayDailyTable)

        ucrBase.clsRsyntax.SetBaseROperator(clsDisplayDailyTableOperator)

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

        ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsGGplotFunction, New RParameter("data", iNewPosition:=0), iAdditionalPairNo:=1)
        ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsNAFilterOperator, New RParameter("data", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

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
        ucrInputComboMissing.SetRCode(clsDisplayDailyTable, bReset)
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
        ucrPnlFrequencyDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseOperator, bReset)
        ucrChkFreeYScales.SetRCode(clsFacetFunction, bReset)
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
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight * 0.86)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.2)
        ElseIf rdoTable.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iBasicHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
        End If
    End Sub

    Private Sub ucrPnlFrequencyDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFrequencyDisplay.ControlValueChanged
        DialogSize()
        If rdoGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            ucrReceiverMultipleElements.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseROperator(clsGgPlotOperator)
            ucrSelectorDisplayDailyClimaticData.SetParameterIsrfunction()
            ucrReceiverDate.SetValuesToIgnore({Chr(34) & Chr(34)})
        Else
            ucrSelectorDisplayDailyClimaticData.SetParameterIsString()
            If rdoGraphByYear.Checked Then
                ucrBase.clsRsyntax.iCallType = 3
                ucrBase.clsRsyntax.SetBaseROperator(clsDisplayDailyGraphOperator)
            Else
                ucrReceiverElement.SetMeAsReceiver()
                ucrBase.clsRsyntax.iCallType = 2
                ucrBase.clsRsyntax.SetBaseROperator(clsDisplayDailyTableOperator)
            End If
        End If
        StackingFunction()
        FacetControl()
    End Sub

    Private Sub ucrSelectorDisplayDailyClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDisplayDailyClimaticData.ControlValueChanged
        clsDisplayDailyGraphFunction.AddParameter("data_name", Chr(34) & ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        StackingFunction()
        FacetControl()
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary> 
    ''' If the Graph radio button is checked, adds the rows, facets and space parameters to the 
    ''' facet function.
    ''' If the radio button is unchecked, it removes these parameters.
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub FacetControl()
        If rdoGraph.Checked AndAlso Not ucrReceiverStations.IsEmpty Then
            clsFacetOperator.AddParameter("station", ucrReceiverStations.GetVariableNames(False), bIncludeArgumentName:=False, iPosition:=1)
            clsFacetFunction.RemoveParameterByName("rows")
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=1)
            clsFacetFunction.AddParameter("space", Chr(34) & "fixed" & Chr(34), iPosition:=2)
        Else
            clsFacetFunction.RemoveParameterByName("facets")
            clsFacetFunction.RemoveParameterByName("space")
            clsFacetFunction.AddParameter("rows", "vars(variable)", iPosition:=1)
        End If

    End Sub
    Private Sub ucrReceiverMultipleElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleElements.ControlValueChanged
        StackingFunction()
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        clsGgplotAesFunction.AddParameter("x", ucrReceiverDate.GetVariableNames(False), iPosition:=0)
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverDayOfYear.ControlContentsChanged, ucrReceiverMultipleElements.ControlValueChanged, ucrNudUpperYaxis.ControlContentsChanged, ucrInputRugColour.ControlContentsChanged, ucrInputBarColour.ControlContentsChanged, ucrPnlFrequencyDisplay.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrChkSum.ControlContentsChanged, ucrChkMax.ControlContentsChanged, ucrChkMin.ControlContentsChanged, ucrChkMean.ControlContentsChanged, ucrChkMedian.ControlContentsChanged, ucrChkIQR.ControlContentsChanged, ucrChkSumMissing.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class