' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgStartofRains
    Public clsRainyDays, clsRainyDaysFunction, clsFirstDOYPerYear, clsManipulationFirstDOYPerYear, clsCombinedFilter, clsCombinedList As New RFunction
    Private clsDayFromAndTo, clsGroupBy, clsAddKey, clsAddKeyColName As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsRainyDaysOperator, clsFirstDOYPerYearOperator As New ROperator
    'Total Rainfall classes
    Private clsTRRollingSum, clsTRRollingSumFunction, clsTRWetSpell, clsTRWetSpellList, clsTRWetSpellFunction As New RFunction
    'Rainy Day classes
    Private clsRDRollingRainDays, clsRDRollingRainDaysFunction, clsRDRollingRainDaysSub As New RFunction
    'Dry Spell classes
    Private clsDSDryPeriodTen, clsDSDrySpell, clsDSDryPeriodTenFunctionLead, clsDSDryPeriodTenFunction, clsDSDryPeriodTenList, clsDSDrySpellSub As New RFunction
    'Dry Period classes
    Private clsDPOverallInterval, clsDPOverallIntervalList, clsDPRain, clsDPRainList, clsDPRainInDays, clsDPRainInDaysFunctionLead, clsDPRainInDaysFunction, clsDPRainFunction, clsDPOverallIntervalFunction As New RFunction
    Private clsDPRainFunctionOperator, clsDPOverallIntervalFunctionOperator, clsDPOverallIntervalFunctionOperatorRight As New ROperator

    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 199

        ' setting the selector
        ucrSelectorForStartofRains.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForStartofRains.SetParameterIsString()

        ' setting receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForStartofRains
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 0))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        ucrReceiverRainfall.SetParameter(New RParameter("data", 0))
        ucrReceiverRainfall.SetParameterIsRFunction()
        ucrReceiverRainfall.bWithQuotes = False
        '        ucrReceiverRainfall.SetParameterIncludeArgumentName(False)
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True

        'Days
        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudFrom.SetMinMax(1, 365)

        ucrNudTo.SetParameter(New RParameter("to", 0))
        ucrNudTo.SetMinMax(2, 366)

        ucrNudThreshold.DecimalPlaces = 2

        'Total Rainfall
        ' ucrChkTotalRainfall if not checked then it doesn't run anything - do manually that this runs if checked.
        ucrChkTotalRainfall.SetText("Total Rainfall")
        ucrChkTotalRainfall.AddToLinkedControls(ucrNudTROverDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTROverDays.SetLinkedDisplayControl(lblTROverDays)
        ucrChkTotalRainfall.AddToLinkedControls(ucrPnlTRCalculateBy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRPercentile, {rdoTRPercentile}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRAmount, {rdoTRAmount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTRCalculateBy.SetLinkedDisplayControl(lblTRVal)

        ' set up panel correctly!
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRAmount)
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRPercentile)

        ' pecentile adds a function, check for amount.

        ' nud
        ucrNudTROverDays.SetParameter(New RParameter("width", 1))
        ucrNudTROverDays.SetMinMax(1, 366) ' I think?
        ' don't allow quotes around it

        ucrNudTRPercentile.SetParameter(New RParameter("probs", 1))
        ucrNudTRPercentile.SetMinMax(0, 1)
        ucrNudTRPercentile.DecimalPlaces = 2
        ucrNudTRPercentile.Increment = 0.1

        'Number of Rainy days
        ' ucrChkTotalRainfall if not checked then it doesn't run anything
        ' if checked, then it runs a function: instat_calculation$new TODO: How to do that? Do manually.
        ucrChkNumberOfRainyDays.SetText("Number of Rainy Days")
        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDMinimumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDOutOfDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudRDMinimumDays.SetLinkedDisplayControl(lblRDMinimum)
        ucrNudRDOutOfDays.SetLinkedDisplayControl(lblRDWidth)

        ucrNudRDOutOfDays.SetParameter(New RParameter("width", 1))
        'ucrNudRDOutOfDays.SetMinMax(1, 366)  what is appropriate here?

        'Dry Spell
        ucrChkDrySpell.SetText("Dry Spell")
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSLengthOfTime, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSMaximumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudDSLengthOfTime.SetLinkedDisplayControl(lblDSLengthofTime)
        ucrNudDSMaximumDays.SetLinkedDisplayControl(lblDSMaximumDays)
        ucrNudDSLengthOfTime.SetParameter(New RParameter("width", 1))
        ' what is a min/max for this

        ' Dry Period
        ucrChkDryPeriod.SetText("Dry Period")
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPMaxRain, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPOverallInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPRainPeriod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudDPMaxRain.SetLinkedDisplayControl(lblDPMaxRain)
        ucrNudDPOverallInterval.SetLinkedDisplayControl(lblDPOverallInterval)
        ucrNudDPRainPeriod.SetLinkedDisplayControl(lblDPLength)
        ucrNudDPRainPeriod.SetParameter(New RParameter("width", 1))
        ucrNudDPMaxRain.SetParameter(New RParameter("right", 1))
        ucrNudDPOverallInterval.SetParameter(New RParameter("Overall", 0))
        ' minmax?

        'clsMinimumRainfall.SetRCommand("instat_calculation$new")
        'clsMinimumRainfall.SetAssignTo("Minimum_Rainfall")


        'clsWithinThirtyDays.SetRCommand("instat_calculation$new")
        'clsWithinThirtyDays.SetAssignTo("dry_spell_10")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")

        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        'save
        ucrSaveStartofRains.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrSaveStartofRains.SetLabelText("New Column Name:")
        ucrSaveStartofRains.SetIsTextBox()
        ucrSaveStartofRains.SetPrefix("Start_of_Rains")
        ucrSaveStartofRains.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        '        clsAddKey = New RFunction
        clsAddKeyColName = New RFunction
        clsDayFromAndTo = New RFunction
        clsDayFromAndToOperator = New ROperator
        clsGroupBy = New RFunction
        clsRainyDays = New RFunction
        clsRainyDaysFunction = New RFunction
        clsRainyDaysOperator = New ROperator
        clsFirstDOYPerYear = New RFunction
        clsFirstDOYPerYearOperator = New ROperator
        clsCombinedFilter = New RFunction
        clsCombinedList = New RFunction

        clsTRRollingSum = New RFunction
        clsTRRollingSumFunction = New RFunction
        clsTRWetSpellList = New RFunction
        clsTRWetSpell = New RFunction
        clsTRWetSpellFunction = New RFunction
        clsRDRollingRainDays = New RFunction
        clsRDRollingRainDaysFunction = New RFunction
        clsRDRollingRainDaysSub = New RFunction

        clsDSDrySpell = New RFunction
        clsDSDryPeriodTenList = New RFunction
        clsDSDryPeriodTen = New RFunction
        clsDSDryPeriodTenFunction = New RFunction
        clsDSDrySpellSub = New RFunction
        clsDSDryPeriodTenFunctionLead = New RFunction

        clsDPRainInDays = New RFunction
        clsDPRain = New RFunction
        clsDPOverallIntervalList = New RFunction
        clsDPOverallInterval = New RFunction
        clsDPOverallIntervalFunction = New RFunction
        clsDPRainInDaysFunctionLead = New RFunction
        clsDPRainInDaysFunction = New RFunction
        clsDPRainFunction = New RFunction
        clsDPRainFunctionOperator = New ROperator
        clsDPOverallIntervalFunction = New RFunction
        clsDPOverallIntervalFunctionOperator = New ROperator
        clsDPOverallIntervalFunctionOperatorRight = New ROperator

        ucrReceiverDate.SetMeAsReceiver()
        ucrSaveStartofRains.Reset()
        ucrSelectorForStartofRains.Reset()

        ' Adding a key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'DayFromandTo
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        '        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & clsDayFromAndToOperator.ToScript & Chr(34), iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366)

        ' group
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34))

        'rainydays
        clsRainyDays.SetRCommand("instat_calculation$new")
        clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '        clsRainyDays.AddParameter("function_exp", Chr(34) & clsRainyDaysFunction.ToScript & Chr(34))
        clsRainyDaysFunction.SetRCommand("match")
        clsRainyDaysFunction.AddParameter("x", clsROperatorParameter:=clsRainyDaysOperator, iPosition:=0)
        clsRainyDaysOperator.SetOperation(">=")
        clsRainyDaysOperator.AddParameter("threshold", 0.85, iPosition:=1) ' rain
        clsRainyDaysFunction.AddParameter("table", "1", iPosition:=1)
        clsRainyDaysFunction.AddParameter("nomatch", "0", iPosition:=2)
        '"match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
        clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34), iPosition:=2)
        clsRainyDays.AddParameter("save", 0, iPosition:=6)

        ' First DOY
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        '        clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & clsFirstDOYPerYearOperator.ToScript & Chr(34), iPosition:=1)
        clsFirstDOYPerYearOperator.SetOperation("[")
        clsFirstDOYPerYearOperator.AddParameter("rightside", "1]", iPosition:=1)
        clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & ucrSaveStartofRains.GetText() & Chr(34), iPosition:=2)
        clsFirstDOYPerYear.AddParameter("save", 2, iPosition:=6)
        clsFirstDOYPerYear.SetAssignTo(ucrSaveStartofRains.ucrInputTextSave.GetText)

        ' Combined filter
        clsCombinedList.SetRCommand("list")
        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsCombinedFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList)

        'TOTAL RAINFALL: associated with ucrChkTRTotalRainfall
        clsTRRollingSum.SetRCommand("instat_calculation$new")
        clsTRRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsTRRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34), iPosition:=2)
        '        clsTRRollingSum.AddParameter("function_exp", Chr(34) & clsTRRollingSumFunction.ToScript & Chr(34), iPosition:=1)
        clsTRRollingSumFunction.SetPackageName("zoo")
        clsTRRollingSumFunction.SetRCommand("rollapply")
        clsTRRollingSumFunction.AddParameter("width", 2, iPosition:=1)
        clsTRRollingSumFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsTRRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsTRRollingSumFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4) ' chr(39) = ' ??
        clsTRRollingSumFunction.AddParameter("fill", "NA", iPosition:=5) ' chr(39) = ' ??
        clsTRRollingSum.AddParameter("save", 0, iPosition:=6)

        ' Quantile checked:
        ' this function is associated with that rdo.
        clsTRWetSpellList.SetRCommand("list")
        clsTRWetSpell.SetRCommand("instat_calculation$new")
        clsTRWetSpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        '        clsTRWetSpell.AddParameter("function_exp", Chr(34) & clsTRWetSpellFunction.ToScript & Chr(34), iPosition:=1)
        clsTRWetSpellFunction.SetRCommand("quantile")
        clsTRWetSpellFunction.AddParameter("x", "roll_sum_Rain", iPosition:=0)
        clsTRWetSpellFunction.AddParameter("probs", 0.8, iPosition:=1) ' do I write: 0.8 or "0.8"?
        clsTRWetSpellFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsTRWetSpell.AddParameter("result_name", Chr(34) & "wet_spell" & Chr(34), iPosition:=2)
        clsTRWetSpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsTRWetSpellList, iPosition:=5) ' check position
        clsTRWetSpell.AddParameter("save", "0", iPosition:=6)

        ' What if amount is checked??
        ' move to approp. place


        ' RAINY DAY
        clsRDRollingRainDays.SetRCommand("instat_calculation$new")
        clsRDRollingRainDaysSub.SetRCommand("list")
        clsRDRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRDRollingRainDays.AddParameter("function_exp", Chr(34) & clsRDRollingRainDaysFunction.ToScript & Chr(34), iPosition:=1)
        clsRDRollingRainDaysFunction.SetPackageName("zoo")
        clsRDRollingRainDaysFunction.SetRCommand("rollapply")
        clsRDRollingRainDaysFunction.AddParameter("data", "rain_day", iPosition:=0)
        clsRDRollingRainDaysFunction.AddParameter("width", 2, iPosition:=1) ' default = 2?
        clsRDRollingRainDaysFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRDRollingRainDaysFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRDRollingRainDaysFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4) ' check this is chr(39) for '
        clsRDRollingRainDaysFunction.AddParameter("fill", "NA", iPosition:=5)
        clsRDRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34), iPosition:=2)
        clsRDRollingRainDays.AddParameter("save", 0, iPosition:=6)

        'DRY SPELL
        clsDSDrySpell.SetRCommand("instat_calculation$new")
        clsDSDryPeriodTen.SetRCommand("instat_calculation$new")
        clsDSDryPeriodTenList.SetRCommand("list")
        clsDSDrySpellSub.SetRCommand("list")

        clsDSDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34), iPosition:=1)
        clsDSDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34), iPosition:=2)
        clsDSDrySpell.AddParameter("save", 0, iPosition:=6)

        clsDSDryPeriodTen.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDSDryPeriodTen.AddParameter("function_exp", Chr(34) & clsDSDryPeriodTenFunctionLead.ToScript & Chr(34))
        clsDSDryPeriodTenFunctionLead.SetRCommand("lead")
        clsDSDryPeriodTenFunctionLead.AddParameter("x", clsRFunctionParameter:=clsDSDryPeriodTenFunction)
        clsDSDryPeriodTenFunction.SetPackageName("zoo")
        clsDSDryPeriodTenFunction.SetRCommand("rollapply")
        clsDSDryPeriodTenFunction.AddParameter("data", "Dry_Spell", iPosition:=0)
        clsDSDryPeriodTenFunction.AddParameter("width", 30, iPosition:=1)
        clsDSDryPeriodTenFunction.AddParameter("FUN", "max", iPosition:=2)
        clsDSDryPeriodTenFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDSDryPeriodTenFunction.AddParameter("align", Chr(39) & "left" & Chr(39), iPosition:=4)
        clsDSDryPeriodTenFunction.AddParameter("fill", "NA", iPosition:=5)
        clsDSDryPeriodTen.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34), iPosition:=2)
        clsDSDryPeriodTen.AddParameter("save", 2, iPosition:=6)

        'DRY PERIOD
        clsDPOverallInterval.SetRCommand("instat_calculation$new")
        clsDPOverallIntervalList.SetRCommand("list")
        clsDPRainList.SetRCommand("list")
        clsDPRain.SetRCommand("instat_calculation$new")
        clsDPRainInDays.SetRCommand("instat_calculation$new")

        clsDPRainInDays.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'width = " & nudDPRainPeriod.Value & ", FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
        'clsDPRainInDays.AddParameter("function_exp", Chr(34) & clsDPRainInDaysFunctionLead.ToScript & Chr(34), iPosition:=2)
        clsDPRainInDaysFunctionLead.SetRCommand("lead") ' i assume lead is wanted if it's the NEXT x days.
        clsDPRainInDaysFunctionLead.AddParameter("x", clsRFunctionParameter:=clsDPRainInDaysFunction)
        clsDPRainInDaysFunction.SetPackageName("zoo")
        clsDPRainInDaysFunction.SetRCommand("rollapply")
        clsDPRainInDaysFunction.AddParameter("width", 30, iPosition:=1)
        clsDPRainInDaysFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsDPRainInDaysFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDPRainInDaysFunction.AddParameter("align", Chr(39) & "left" & Chr(39), iPosition:=4)
        clsDPRainInDaysFunction.AddParameter("fill", "NA", iPosition:=5)
        clsDPRainInDays.AddParameter("result_name", Chr(34) & "Rain_in_Days" & Chr(34), iPosition:=2) ' sub calc running?
        clsDPRainInDays.AddParameter("save", "0", iPosition:=6)

        clsDPRain.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        '        clsDPRain.AddParameter("function_exp", Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
        clsDPRain.AddParameter("function_exp", Chr(34) & clsDPRainFunction.ToScript & Chr(34))
        clsDPRainFunction.SetRCommand("match")
        clsDPRainFunction.AddParameter("x", clsROperatorParameter:=clsDPRainFunctionOperator)
        clsDPRainFunctionOperator.SetOperation("<=")
        clsDPRainFunctionOperator.AddParameter("left", "Rain_in_Days", iPosition:=0)
        clsDPRainFunctionOperator.AddParameter("right", 40, iPosition:=1)
        clsDPRainFunction.AddParameter("table", 1, iPosition:=1)
        clsDPRainFunction.AddParameter("nomatch", 0, iPosition:=2)
        'Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
        clsDPRain.AddParameter("result_name", Chr(34) & "Above_Threshold" & Chr(34), iPosition:=1)
        clsDPRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPRainList, iPosition:=4)
        clsDPRain.AddParameter("save", 0, iPosition:=6)

        clsDPRainList.AddParameter("sub1", clsRFunctionParameter:=clsDPRainInDays, bIncludeArgumentName:=False)
        clsDPOverallInterval.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPOverallIntervalList, iPosition:=4)
        clsDPOverallIntervalList.AddParameter("sub1", clsRFunctionParameter:=clsDPRain, bIncludeArgumentName:=False)
        clsDPOverallInterval.AddParameter("function_exp", Chr(34) & clsDPOverallIntervalFunction.ToScript & Chr(34), iPosition:=1)

        clsDPOverallInterval.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'clsDPOverallInterval.AddParameter("function_exp", Chr(34) & clsDPOverallIntervalFunction.ToScript & Chr(34), iPosition:=1)
        clsDPOverallIntervalFunction.SetRCommand("rollapply")
        clsDPOverallIntervalFunction.AddParameter("data", "Above_Threshold", iPosition:=0)
        clsDPOverallIntervalFunction.AddParameter("width", clsROperatorParameter:=clsDPOverallIntervalFunctionOperator, iPosition:=1)
        clsDPOverallIntervalFunctionOperator.SetOperation("-")
        clsDPOverallIntervalFunctionOperator.AddParameter("Overall", 45, iPosition:=0)
        clsDPOverallIntervalFunctionOperator.AddParameter("right", clsROperatorParameter:=clsDPOverallIntervalFunctionOperatorRight, iPosition:=1)
        clsDPOverallIntervalFunctionOperatorRight.SetOperation("+")
        clsDPOverallIntervalFunctionOperatorRight.AddParameter("Rain", 30, iPosition:=0)
        clsDPOverallIntervalFunctionOperatorRight.AddParameter("1", 1, iPosition:=1)
        clsDPOverallIntervalFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsDPOverallIntervalFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDPOverallIntervalFunction.AddParameter("align", Chr(39) & "left" & Chr(39), iPosition:=4)
        clsDPOverallIntervalFunction.AddParameter("fill", "NA", iPosition:=5)
        clsDPOverallInterval.AddParameter("result_name", Chr(34) & "DP_Overall_Interval_Rain" & Chr(34), iPosition:=2)
        clsDPOverallInterval.AddParameter("save", "2", iPosition:=6)


        CheckBoxesSetting()
        TestOKEnabled()
        ucrNudTRAmount.Value = 20
        ucrNudDSMaximumDays.Value = 10
        'DefaultNudValue()
    End Sub

    'TODO: start of rains changes discussed with francis. leap() and also nud -1 for something and also left?
    'ine 399 in R-Instat:
    'Add in the lead, this Is because we want to count the NEXT x days with less than y days of rain. Without lead, we were counting the current day
    '2. If the user wishes to start from day 122, then the nud can say 122. BUT, the value that we call has to be 121. This can be fixed properly when we have more time, but for now will do
    ' does that start from 122 mess up the lead()??
    ' add to start of rains to sort the order at the end

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDOYPerYearOperator, New RParameter("doy", 0), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainyDaysOperator, New RParameter("Rain", 1), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsDPRainInDaysFunction, New RParameter("data", 0), iAdditionalPairNo:=2)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForStartofRains.SetRCode(clsAddKey, bReset)

        ucrReceiverRainfall.SetRCode(clsTRRollingSumFunction, bReset)

        'Total Rainfall
        ucrNudTROverDays.SetRCode(clsTRRollingSumFunction, bReset)
        ucrNudTRPercentile.SetRCode(clsTRWetSpellFunction, bReset)

        'Rain Days
        ucrNudRDOutOfDays.SetRCode(clsRDRollingRainDaysFunction, bReset)

        'DrySpell
        ucrNudDSLengthOfTime.SetRCode(clsDSDryPeriodTenFunction, bReset)

        'DryPeriod
        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsDPOverallIntervalFunctionOperatorRight, New RParameter("Rain", 0), iAdditionalPairNo:=1)
        ucrNudDPRainPeriod.SetRCode(clsDPRainInDaysFunction, bReset)
        ucrNudDPMaxRain.SetRCode(clsDPRainFunctionOperator, bReset)
        ucrNudDPOverallInterval.SetRCode(clsDPOverallIntervalFunctionOperator, bReset)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining column(s) as key")
        clsCombinedFilter.SetAssignTo("combined_filter")

        clsFirstDOYPerYear.SetAssignTo("First_doy_per_year")
        clsManipulationFirstDOYPerYear.AddParameter("sub1", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False)
        clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear, iPosition:=5) ' if I run this in SetDefaults, will this update automatically
        clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=4)
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsFirstDOYPerYear)

        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & clsDayFromAndToOperator.ToScript & Chr(34), iPosition:=1)

        clsGroupBy.SetAssignTo("Grouping")

        clsRainyDays.AddParameter("function_exp", Chr(34) & clsRainyDaysFunction.ToScript & Chr(34))
        If ucrChkTotalRainfall.Checked Then
            TotalRainfall()
            clsTRRollingSum.SetAssignTo("rolling_sum_day")
            clsTRRollingSum.AddParameter("function_exp", Chr(34) & clsTRRollingSumFunction.ToScript & Chr(34))
            clsTRWetSpell.SetAssignTo("Wet_Spell")

            'if quantile checked
            clsTRWetSpell.AddParameter("function_exp", Chr(34) & clsTRWetSpellFunction.ToScript & Chr(34), iPosition:=1)
        End If

        If ucrChkNumberOfRainyDays.Checked Then
            TotalRainyDays()
            clsRDRollingRainDays.SetAssignTo("Rolling_rain")
        End If

        If ucrChkDrySpell.Checked Then
            clsDSDrySpell.SetAssignTo("Dry_Spell")
            clsDSDryPeriodTen.SetAssignTo("Dry_Period_10")
        End If

        If ucrChkDryPeriod.Checked Then
            clsDPOverallInterval.SetAssignTo("Overall_Interval")
            clsDPRainInDays.SetAssignTo("Rain_Period_Length")
            clsDPRain.SetAssignTo("Above_Threshold")
            clsDPRainInDays.AddParameter("function_exp", Chr(34) & clsDPRainInDaysFunctionLead.ToScript & Chr(34), iPosition:=2)
            clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
        End If
        clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & clsFirstDOYPerYearOperator.ToScript & Chr(34), iPosition:=1)
    End Sub

    Private Sub RainDays()
        clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")", iPosition:=5) ' is that meant to be True?
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
    End Sub

    Private Sub TotalRainfall()
        clsTRRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=0)
        ' if quantiles checked:
        clsTRWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
        '        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=5)
        '        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        ' does this update if I change the data name?
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")")
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        End If
        clsManipulationFirstDOYPerYear.AddParameter("sub2", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForStartofRains.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
    End Sub

    Private Sub TotalRainyDays()
        clsRDRollingRainDays.AddParameter("sub_calculations", clsRFunctionParameter:=clsRDRollingRainDaysSub)
        clsRDRollingRainDaysSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub DrySpell()
        clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDrySpellSub, iPosition:=4)
        clsDSDrySpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        clsDSDryPeriodTen.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDryPeriodTenList, iPosition:=5)
        clsDSDryPeriodTenList.AddParameter("sub1", clsRFunctionParameter:=clsDSDrySpell, bIncludeArgumentName:=False)
    End Sub

    Private Sub DryPeriod()
        clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=5)
    End Sub















    Private Sub ucrReceiverDOY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDOY.SelectionChanged
        firstDayofTheYear()
        FirstDOYPerYear()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        firstDayofTheYear()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        'If ucrSaveStartofRains.IsComplete AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrNudThreshold.Text <> "" AndAlso ucrNudFrom.Text = "" AndAlso ucrNudTo.Text = "" AndAlso ((ucrChkNumberOfRainyDays.Checked AndAlso ucrNudRDMinimumDays.Text <> "" AndAlso ucrNudRDOutOfDays.Text <> "") OrElse Not ucrChkNumberOfRainyDays.Checked) AndAlso (((ucrChkTotalRainfall.Checked AndAlso Not ucrNudTROverDays.GetText = "") AndAlso ((rdoTRAmount.Checked AndAlso ucrNudTRAmount.Text <> "") OrElse (rdoTRPercentile.Checked AndAlso Not ucrNudTRPercentile.Text = ""))) OrElse Not ucrChkTotalRainfall.Checked) AndAlso ((chkDrySpell.Checked AndAlso nudDSMaximumDays.Text <> "" AndAlso ucrNudDSLengthOfTime.Text <> "") OrElse Not chkDrySpell.Checked) AndAlso ((chkDryPeriod.Checked AndAlso nudDPMaxRain.Text <> "" AndAlso nudDPRainPeriod.Text <> "" AndAlso nudDPOverallInterval.Text <> "") OrElse Not chkDryPeriod.Checked) Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub ' ucrNudDPRainPeriod, ucrNudDPMaxRain, ucrNudDPOverallInterval

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub grpRainParameters_Enter(sender As Object, e As EventArgs)
        RainyDaysMethod()
        nudValues()
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub DryPeriod(sender As Object, e As EventArgs)
        CheckBoxesSetting()
        DryPeriodOld()
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub TotalRainfall(sender As Object, e As EventArgs) Handles rdoTRAmount.CheckedChanged, rdoTRPercentile.CheckedChanged
        CheckBoxesSetting()
        CombinedFilter()
        RollingSumMethod()
        TotalRainPercentileWetSpell()
        nudValues() ' new
        'DefaultNudValue()
        TestOKEnabled()
    End Sub

    Private Sub TotalRainfallNuds(sender As Object, e As EventArgs)
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub RainyDays(sender As Object, e As EventArgs)
        CheckBoxesSetting()
        RollingOfRainDays()
        nudValues()
        CombinedFilter()
        TestOKEnabled()
    End Sub

    Private Sub DrySpell_Spe(sender As Object, e As EventArgs)
        CheckBoxesSetting()
        DrySpellOld()
        nudValues()
        CombinedFilter()
        TestOKEnabled()
    End Sub


    'Private Sub grpConditionsForStartofRains_Enter(sender As Object, e As EventArgs) Handles nudTRAmount.TextChanged, nudTRPercentile.TextChanged, nudRDMinimum.TextChanged, nudDSMaximumDays.TextChanged, nudDSLengthofTime.TextChanged, nudTROverDays.TextChanged, nudRDOutOfDays.TextChanged
    '    RainyDaysMethod()
    '    DayFromAndToMethod()
    '    CombinedFilter()
    '    RollingOfRainDays()
    '    DrySpellOld()
    '    RollingSumMethod()
    '    TotalRainPercentileWetSpell()
    '    nudValues()
    '    TestOKEnabled()
    'End Sub

    'Private Sub grpConditionsForStartofRains1_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkDrySpell.CheckedChanged, chkDryPeriod.CheckedChanged
    '    CheckBoxesSetting()
    '    DrySpell()
    '    RainyDaysMethod()
    '    CombinedFilter()
    '    FirstDOYPerYear()
    '    TestOKEnabled()
    '    nudValues()
    'End Sub

    ' yep
    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        RainyDaysMethod()
        RollingSumMethod()
        DryPeriodOld()
        TestOKEnabled()
    End Sub

    Private Sub CheckBoxesSetting()
        'If chkTotalRainfall.Checked Then
        '    pnlTotalRainfall.Visible = True
        '    nudTRAmount.Visible = False
        '    '            nudTRPercentile.Visible = False
        '    If rdoTRAmount.Checked Then
        '        nudTRAmount.Visible = True
        '        nudTRPercentile.Visible = False
        '    ElseIf rdoTRPercentile.Checked Then
        '        nudTRAmount.Visible = False
        '        nudTRPercentile.Visible = True
        '    Else
        '        nudTRAmount.Visible = False
        '        nudTRPercentile.Visible = False
        '    End If
        'Else
        '    pnlTotalRainfall.Visible = False
        'End If
        'If chkDrySpell.Checked Then
        '    pnlDrySpell.Visible = True
        'Else
        '    pnlDrySpell.Visible = False
        'End If
        'If chkConsecutiveRainyDays.Checked Then
        '    pnlConsecutiveRainyDays.Visible = True
        'Else
        '    pnlConsecutiveRainyDays.Visible = False
        'End If
        'If chkDryPeriod.Checked Then
        '    pnlDryPeriod.Visible = True
        'Else
        '    pnlDryPeriod.Visible = False
        'End If
    End Sub

    ' nud max and mins.
    Private Sub nudValues()
        '  nudFrom.Maximum = nudTo.Value - 1
        ' nudTo.Minimum = nudFrom.Value + 1
        'If chkConsecutiveRainyDays.Checked Then
        '    nudRDMinimum.Maximum = nudRDOutOfDays.Value - 1
        '    nudRDOutOfDays.Minimum = nudRDMinimum.Value + 1
        'End If
        'If chkDrySpell.Checked Then
        '    nudDSMaximumDays.Maximum = nudDSLengthofTime.Value - 1
        '    nudDSLengthofTime.Minimum = nudDSMaximumDays.Value + 1
        'End If
        'If chkDryPeriod.Checked Then
        '    nudDPRainPeriod.Maximum = nudDPOverallInterval.Value - 1
        '    nudDPOverallInterval.Minimum = nudDPRainPeriod.Value + 1
        'End If
    End Sub

    Private Sub RainyDaysMethod()
        If ((Not ucrReceiverRainfall.IsEmpty) AndAlso (ucrNudThreshold.Text <> "")) Then
            'clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            'clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
            'clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
            'clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")")
            'clsRainyDays.AddParameter("save", 0)
            '            clsSubRainDays.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub RollingSumMethod()
        'If chkTotalRainfall.Checked AndAlso Not ucrReceiverRainfall.IsEmpty Then
        '    clsTRRollingSum.AddParameter("function_exp", Chr(34) & " zoo::rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudTROverDays.Value & ", FUN = sum, na.rm = FALSE, align='right', fill=NA)" & Chr(34))
        '    clsTRRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '    clsTRRollingSum.AddParameter("result_name", Chr(34) & "roll_sum_Rain" & Chr(34))
        '    clsTRRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
        '    clsTRRollingSum.AddParameter("save", 0)
        'Else
        '    clsTRRollingSum.RemoveParameterByName("function_exp")
        '    clsTRRollingSum.RemoveParameterByName("type")
        '    clsTRRollingSum.RemoveParameterByName("result_name")
        '    clsTRRollingSum.RemoveParameterByName("calculated_from")
        '    clsTRRollingSum.RemoveParameterByName("save")
        'End If
    End Sub

    ' If we have 'Percentile' checked
    Private Sub TotalRainPercentileWetSpell()
        'If rdoTRPercentile.Checked Then
        '    clsTRWetSpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '    clsTRWetSpell.AddParameter("function_exp", Chr(34) & "quantile(roll_sum_Rain, c(" & nudTRPercentile.Value & "), na.rm=T)" & Chr(34))
        '    clsTRWetSpell.AddParameter("result_name", Chr(34) & "wet_spell" & Chr(34))
        '    clsTRWetSpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsTRWetSpellList)
        '    clsTRWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
        '    clsTRWetSpell.AddParameter("save", "0")
        'Else
        '    clsTRWetSpell.RemoveParameterByName("type")
        '    clsTRWetSpell.RemoveParameterByName("function_exp")
        '    clsTRWetSpell.RemoveParameterByName("result_name")
        '    clsTRWetSpell.RemoveParameterByName("sub_calculations")
        '    clsTRWetSpellList.RemoveParameterByName("sub1")
        '    clsTRWetSpell.RemoveParameterByName("save")
        'End If
    End Sub

    Private Sub RollingOfRainDays()
        '        '  If rolling of rain days one is checked Then
        'clsRDRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        'clsRDRollingRainDays.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data=rain_day, width = " & nudRDOutOfDays.Value & ", FUN = sum, na.rm = FALSE, align = 'right', fill=NA)" & Chr(34))
        'clsRDRollingRainDays.AddParameter("result_name", Chr(34) & "Rolling_Rain_Days" & Chr(34))
        'clsRDRollingRainDays.AddParameter("sub_calculations", clsRFunctionParameter:=clsRDRollingRainDaysSub)
        'clsRDRollingRainDaysSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        'clsRDRollingRainDays.AddParameter("save", 0)
    End Sub

    Private Sub DrySpellOld()
        'If chkDrySpell.Checked Then
        '    clsDSDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '    clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
        '    clsDSDrySpell.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
        '    clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDrySpellSub)
        '    clsDSDrySpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        '    clsDSDrySpell.AddParameter("save", 0)
        '    clsDSDryPeriodTen.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        '    clsDSDryPeriodTen.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = Dry_Spell, width=" & ucrNudDSLengthOfTime.Value & ", FUN=max, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
        '    clsDSDryPeriodTen.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
        '    clsDSDryPeriodTen.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDryPeriodTenList)
        '    clsDSDryPeriodTenList.AddParameter("sub1", clsRFunctionParameter:=clsDSDrySpell, bIncludeArgumentName:=False)
        '    clsDSDryPeriodTen.AddParameter("save", 2)
        'Else
        '    clsDSDrySpell.RemoveParameterByName("type")
        '    clsDSDrySpell.RemoveParameterByName("function_exp")
        '    clsDSDrySpell.RemoveParameterByName("result_name")
        '    clsDSDrySpell.RemoveParameterByName("sub_calculations")
        '    clsDSDrySpellSub.RemoveParameterByName("sub1")
        '    clsDSDrySpell.RemoveParameterByName("save")
        '    clsDSDryPeriodTen.RemoveParameterByName("type")
        '    clsDSDryPeriodTen.RemoveParameterByName("function_exp")
        '    clsDSDryPeriodTen.RemoveParameterByName("sub_calculations")
        '    clsDSDryPeriodTen.RemoveParameterByName("result_name")
        '    clsDSDryPeriodTen.RemoveParameterByName("save")
        '    clsDSDryPeriodTenList.RemoveParameterByName("sub1")
        'End If
    End Sub

    Private Sub DryPeriodOld()
        If ucrChkDryPeriod.Checked Then
            '    clsDPRainInDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            '    clsDPRainInDays.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = " & ucrReceiverRainfall.GetVariableNames(False) & " ,width = " & nudDPRainPeriod.Value & ", FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            '    clsDPRainInDays.AddParameter("result_name", Chr(34) & "Rain_in_Days" & Chr(34))
            '    clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")")
            '    clsDPRainInDays.AddParameter("save", "0")

            '    clsDPRain.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            '    clsDPRain.AddParameter("function_exp", Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
            '    clsDPRain.AddParameter("result_name", Chr(34) & "Above_Threshold" & Chr(34))
            '    clsDPRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPRainList)
            '    clsDPRainList.AddParameter("sub1", clsRFunctionParameter:=clsDPRainInDays, bIncludeArgumentName:=False)
            '    clsDPRain.AddParameter("save", 0)

            '    clsDPOverallInterval.AddParameter("type", Chr(34) & "calculation" & Chr(34))
            '    clsDPOverallInterval.AddParameter("function_exp", Chr(34) & "zoo::rollapply(data = Above_Threshold ,width = (" & nudDPOverallInterval.Value & "-" & nudDPRainPeriod.Value & "+ 1), FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
            '    clsDPOverallInterval.AddParameter("result_name", Chr(34) & "DP_Overall_Interval_Rain" & Chr(34))
            '    clsDPOverallInterval.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPOverallIntervalList)
            '    clsDPOverallIntervalList.AddParameter("sub1", clsRFunctionParameter:=clsDPRain, bIncludeArgumentName:=False)
            '    clsDPOverallInterval.AddParameter("save", "2")
            'Else
            '    clsDPRainInDays.RemoveParameterByName("type")
            '    clsDPRainInDays.RemoveParameterByName("function_exp")
            '    clsDPRainInDays.RemoveParameterByName("result_name")
            '    clsDPRainInDays.RemoveParameterByName("calculated_from")
            '    clsDPRainInDays.RemoveParameterByName("save")
            '    clsDPRain.RemoveParameterByName("type")
            '    clsDPRain.RemoveParameterByName("function_exp")
            '    clsDPRain.RemoveParameterByName("result_name")
            '    clsDPRain.RemoveParameterByName("sub_calculations")
            '    clsDPRainList.RemoveParameterByName("sub1")
            '    clsDPRain.RemoveParameterByName("save")
            '    clsDPOverallInterval.RemoveParameterByName("type")
            '    clsDPOverallInterval.RemoveParameterByName("function_exp")
            '    clsDPOverallInterval.RemoveParameterByName("result_name")
            '    clsDPOverallInterval.RemoveParameterByName("sub_calculations")
            '    clsDPOverallInterval.RemoveParameterByName("sub1")
            '    clsDPOverallInterval.RemoveParameterByName("save")
        End If
    End Sub

    Private Sub CombinedFilter()
        Dim strTempFunExpression As String = Chr(34)

        clsCombinedFilter.RemoveParameterByName("function_exp")

        If ucrChkTotalRainfall.Checked Then
            strTempFunExpression = strTempFunExpression & "roll_sum_Rain > "
            If rdoTRAmount.Checked Then
                strTempFunExpression = strTempFunExpression & ucrNudTRAmount.Value
                clsCombinedList.RemoveParameterByName("sub4")
            ElseIf rdoTRPercentile.Checked Then
                strTempFunExpression = strTempFunExpression & "wet_spell"
                clsCombinedList.AddParameter("sub4", clsRFunctionParameter:=clsTRWetSpell, bIncludeArgumentName:=False)
            End If
            strTempFunExpression = strTempFunExpression & " & "
            clsCombinedList.AddParameter("sub3", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub3")
        End If
        If ucrChkNumberOfRainyDays.Checked Then
            strTempFunExpression = strTempFunExpression & "Rolling_Rain_Days >= " & ucrNudRDMinimumDays.Value & " & "
            clsCombinedList.AddParameter("sub2", clsRFunctionParameter:=clsRDRollingRainDays, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub2")
        End If
        If ucrChkDrySpell.Checked Then
            strTempFunExpression = strTempFunExpression & "Dry_Spell < " & ucrNudDSMaximumDays.Value & " & "
            clsCombinedList.AddParameter("sub1", clsRFunctionParameter:=clsDSDryPeriodTen, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub1")
        End If
        If ucrChkDryPeriod.Checked Then
            strTempFunExpression = strTempFunExpression & "DP_Overall_Interval_Rain == 0 " & " & "
            clsCombinedList.AddParameter("sub5", clsRFunctionParameter:=clsDPOverallInterval, bIncludeArgumentName:=False)
        Else
            clsCombinedList.RemoveParameterByName("sub5")
        End If

        strTempFunExpression = strTempFunExpression & ucrReceiverRainfall.GetVariableNames(False) & ">=" & ucrNudThreshold.Value & Chr(34)

        clsCombinedFilter.AddParameter("function_exp", strTempFunExpression)
    End Sub

    Private Sub FirstDOYPerYear()
        '' run these when things are checked
        'If Not ucrReceiverDOY.IsEmpty Then

        '    clsManipulationFirstDOYPerYear.AddParameter("sub1", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False)
        '    clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

        '    clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34))
        '    clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        '    clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        '    clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear)
        '    clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & ucrSaveStartofRains.GetText() & Chr(34))
        '    clsFirstDOYPerYear.AddParameter("save", 2)

        'Else
        '    clsManipulationFirstDOYPerYear.RemoveParameterByName("sub1")
        '    clsManipulationFirstDOYPerYear.RemoveParameterByName("sub2")
        '    clsManipulationFirstDOYPerYear.RemoveParameterByName("sub3")
        '    clsFirstDOYPerYear.RemoveParameterByName("type")
        '    clsFirstDOYPerYear.RemoveParameterByName("function_exp")
        '    clsFirstDOYPerYear.RemoveParameterByName("calculated_from")
        '    clsFirstDOYPerYear.RemoveParameterByName("manipulations")
        'End If
    End Sub

    Private Sub firstDayofTheYear()
        'clsManipulationFirstDOYPerYear.AddParameter("sub1", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False)
        'clsManipulationFirstDOYPerYear.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

        'clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34))
        'clsFirstDOYPerYear.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        'clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        'clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear)
        'clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & ucrSaveStartofRains.GetText() & Chr(34))
        'clsFirstDOYPerYear.AddParameter("save", 2)

        'ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsFirstDOYPerYear)
    End Sub

    Private Sub ucrSaveStartofRains_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveStartofRains.ControlContentsChanged
        TestOKEnabled()
    End Sub

    'Private Sub ucrSaveStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveStartofRains.ControlValueChanged
    '    FirstDOYPerYear()
    'End Sub

    'Private Sub DefaultNudValue()
    '    nudRDOutOfDays.Value = nudTROverDays.Value ' crashes if I go to 100+, can crash upon a reset, also what if I change the nudOverDays then the nudOutofDays - then I lose my nudOverDays value I put in
    'End Sub
End Class