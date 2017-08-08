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
Public Class sdgClimdexIndices
    Public bControlsInitialised As Boolean = False
    Public clsNewClimdexInput, clsRWriteDf As New RFunction
    Public clsRMaxMisingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles, clsROneArg, clsRTwoArg1, clsRTwoArg2, clsRTwoArg3, clsRTwoArg4, clsRTwoArg5, clsRThreeArg As New RFunction
    Public clsNewFrostDays, clsNewSummerDays, clsNewIcingDays, clsNewTropicalNights, clsNewWarmSpellDI, clsNewColdSpellDI, clsNewGrowingSeasonLength, clsNewMonthlyMaxDailyTMax, clsNewMonthlyMaxDailyTMin, clsNewMonthlyMinDailyTMax, clsNewMonthlyMinDailyTMin, clsNewTminBelow10Percent, clsNewTmaxBelow10Percent, clsNewTminAbove90Percent, clsNewTmaxAbove90Percent, clsNewMeanDiurnalTempRange As New RFunction
    Public clsNewMonthlyMax1DayPrec, clsNewMonthlyMax5DayPrec, clsNewSimplePrecII, clsNewPrecExceed10mm, clsNewPrecExceed20mm, clsNewPrecExceedSpecifiedA, clsNewMaxDrySpell, clsNewMaxWetSpell, clsNewPrecExceed95Percent, clsNewPrecExceed99Percent, clsNewTotalDailyPrec As New RFunction

    Dim lstGroupboxes As List(Of GroupBox)
    Dim dctInputindicesTriples As New Dictionary(Of String, List(Of String))
    Private Sub sdgClimdexIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctInputFreqPairs As New Dictionary(Of String, String)
        Dim dctNumericPairs As New Dictionary(Of String, String)
        Dim dctCategoricalPairs As New Dictionary(Of String, String)
        clsRMaxMisingDays.SetRCommand("c")
        clsRBaseRange.SetRCommand("c")
        clsRTempQTiles.SetRCommand("c")
        clsRPrecQTiles.SetRCommand("c")
        'we may need to have the climdex object created by default then the user specifies the indices to display.

        'Annual for Max and Min Temperatures
        'ucrChkFrostDays.Checked = True
        ucrChkFrostDays.SetText("Frost Days [1]")
        'dctInputindicesTriples.Add(ucrChkFrostDays.chkCheck.Text, {"Frost_Days", "climdex.fd"}.ToList)
        ucrChkFrostDays.AddParameterPresentCondition(True, "climdex.fd", True)
        ucrChkFrostDays.AddParameterPresentCondition(False, "climdex.fd", False)
        ucrChkFrostDays.bChangeParameterValue = False

        'ucrChkSummerDays.Checked = False
        ucrChkSummerDays.SetText("Summer Days [2]")
        '        dctInputindicesTriples.Add(ucrChkSummerDays.chkCheck.Text, {"Summer_Days", "climdex.su"}.ToList)
        ucrChkSummerDays.AddParameterPresentCondition(True, "climdex.su", True)
        ucrChkSummerDays.AddParameterPresentCondition(False, "climdex.su", False)
        ucrChkSummerDays.bChangeParameterValue = False

        'ucrChkIcingDays.Checked = False
        ucrChkIcingDays.SetText("Icing Days [3]")
        '        dctInputindicesTriples.Add(ucrChkIcingDays.chkCheck.Text, {"Icing_Days", "climdex.id"}.ToList)
        ucrChkIcingDays.AddParameterPresentCondition(True, "climdex.id", True)
        ucrChkIcingDays.AddParameterPresentCondition(False, "climdex.id", False)
        ucrChkIcingDays.bChangeParameterValue = False

        'ucrChkTropicalNights.Checked = False
        ucrChkTropicalNights.SetText("Tropical Nights [4]")
        '        dctInputindicesTriples.Add(ucrChkTropicalNights.chkCheck.Text, {"Tropical_Nights", "climdex.tr"}.ToList)
        ucrChkTropicalNights.AddParameterPresentCondition(True, "climdex.tr", True)
        ucrChkTropicalNights.AddParameterPresentCondition(False, "climdex.tr", False)
        ucrChkTropicalNights.bChangeParameterValue = False

        'ucrChkWarmSpellDI.Checked = False
        ucrChkWarmSpellDI.SetText("Warm Spell Duration Index [14]")
        '        dctInputindicesTriples.Add(ucrChkWarmSpellDI.chkCheck.Text, {"Warm_Spell_Duration_Index", "climdex.wsdi"}.ToList)
        ucrChkWarmSpellDI.AddParameterPresentCondition(True, "climdex.wsdi", True)
        ucrChkWarmSpellDI.AddParameterPresentCondition(False, "climdex.wsdi", False)
        ucrChkWarmSpellDI.bChangeParameterValue = False

        'ucrChkColdSpellDI.Checked = False
        ucrChkColdSpellDI.SetText("Cold Spell Duration Index [15]")
        '        dctInputindicesTriples.Add(ucrChkColdSpellDI.chkCheck.Text, {"Cold_Spell_Duration_Index", "climdex.csdi"}.ToList)
        ucrChkColdSpellDI.AddParameterPresentCondition(True, "climdex.csdi", True)
        ucrChkColdSpellDI.AddParameterPresentCondition(False, "climdex.csdi", False)
        ucrChkColdSpellDI.bChangeParameterValue = False

        'ucrChkGrowingSeasonLength.Checked = False
        ucrChkGrowingSeasonLength.SetText("Growing Season Length [5]")
        '        dctInputindicesTriples.Add(ucrChkGrowingSeasonLength.chkCheck.Text, {"Growing_Season_Length", "climdex.gsl"}.ToList)
        ucrChkGrowingSeasonLength.AddParameterPresentCondition(True, "climdex.gsl", True)
        ucrChkGrowingSeasonLength.AddParameterPresentCondition(False, "climdex.gsl", False)
        ucrChkGrowingSeasonLength.bChangeParameterValue = False

        ' Annual/Monthly
        'ucrChkMonthlyMaxDailyTMax.Checked = False
        ucrChkMonthlyMaxDailyTMax.SetText("Monthly Maximum of Daily Maximum Temperature [6]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMaxDailyTMax.chkCheck.Text, {"Monthly_Maximum_of_Daily_Maximum_Temperature", "climdex.txx"}.ToList)
        ucrChkMonthlyMaxDailyTMax.AddParameterPresentCondition(True, "climdex.txx", True)
        ucrChkMonthlyMaxDailyTMax.AddParameterPresentCondition(False, "climdex.txx", False)
        ucrChkMonthlyMaxDailyTMax.bChangeParameterValue = False

        'ucrChkMonthlyMaxDailyTMin.Checked = False
        ucrChkMonthlyMaxDailyTMin.SetText("Monthly Maximum of Daily Minimum Temperature [7]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMaxDailyTMin.chkCheck.Text, {"Monthly_Maximum_of_Daily_Minimum_Temperature", "climdex.txn"}.ToList)
        ucrChkMonthlyMaxDailyTMin.AddParameterPresentCondition(True, "climdex.txn", True)
        ucrChkMonthlyMaxDailyTMin.AddParameterPresentCondition(False, "climdex.txn", False)
        ucrChkMonthlyMaxDailyTMin.bChangeParameterValue = False

        'ucrChkMonthlyMinDailyTMax.Checked = False
        ucrChkMonthlyMinDailyTMax.SetText("Monthly Minimum of Daily Maximum Temperature [8]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMinDailyTMax.chkCheck.Text, {"Monthly_Minimum_of_Daily_Maximum_Temperature", "climdex.tnx"}.ToList)
        ucrChkMonthlyMinDailyTMax.AddParameterPresentCondition(True, "climdex.tnx", True)
        ucrChkMonthlyMinDailyTMax.AddParameterPresentCondition(False, "climdex.tnx", False)
        ucrChkMonthlyMinDailyTMax.bChangeParameterValue = False

        'ucrChkMonthlyMinDailyTMin.Checked = False
        ucrChkMonthlyMinDailyTMin.SetText("Monthly Minimum of Daily Minimum Temperature [9]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMinDailyTMin.chkCheck.Text, {"Monthly_Minimum_of_Daily_Minimum_Temperature", "climdex.tnn"}.ToList)
        ucrChkMonthlyMinDailyTMin.AddParameterPresentCondition(True, "climdex.tnn", True)
        ucrChkMonthlyMinDailyTMin.AddParameterPresentCondition(False, "climdex.tnn", False)
        ucrChkMonthlyMinDailyTMin.bChangeParameterValue = False

        'ucrChkTminBelow10Percent.Checked = False
        ucrChkTminBelow10Percent.SetText("Percentage of Days When Tmin is Below 10th Percentile [10]")
        '        dctInputindicesTriples.Add(ucrChkTminBelow10Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmin_is_Below_10th_Percentile", "climdex.tn10p"}.ToList)
        ucrChkTminBelow10Percent.AddParameterPresentCondition(True, "climdex.tn10p", True)
        ucrChkTminBelow10Percent.AddParameterPresentCondition(False, "climdex.tn10p", False)
        ucrChkTminBelow10Percent.bChangeParameterValue = False

        'ucrChkTmaxBelow10Percent.Checked = False
        ucrChkTmaxBelow10Percent.SetText("Percentage of Days When Tmax is Below 10th Percentile [11]")
        '        dctInputindicesTriples.Add(ucrChkTmaxBelow10Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmax_is_Below_10th_Percentile", "climdex.tx10p"}.ToList)
        ucrChkTmaxBelow10Percent.AddParameterPresentCondition(True, "climdex.tx10p", True)
        ucrChkTmaxBelow10Percent.AddParameterPresentCondition(False, "climdex.tx10p", False)
        ucrChkTmaxBelow10Percent.bChangeParameterValue = False

        'ucrChkTminAbove90Percent.Checked = False
        ucrChkTminAbove90Percent.SetText("Percentage of Days When Tmin is Above 90th Percentile [12]")
        '        dctInputindicesTriples.Add(ucrChkTminAbove90Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmin_is_Above_90th_Percentile", "climdex.tn90p"}.ToList)
        ucrChkTminAbove90Percent.AddParameterPresentCondition(True, "climdex.tn90p", True)
        ucrChkTminAbove90Percent.AddParameterPresentCondition(False, "climdex.tn90p", False)
        ucrChkTminAbove90Percent.bChangeParameterValue = False

        'ucrChkTmaxAbove90Percent.Checked = False
        ucrChkTmaxAbove90Percent.SetText("Percentage of Days When Tmax is Above 90th Percentile [13]")
        '        dctInputindicesTriples.Add(ucrChkTmaxAbove90Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmax_is_Above_90th_Percentile", "climdex.tx90p"}.ToList)
        ucrChkTmaxAbove90Percent.AddParameterPresentCondition(True, "climdex.tx90p", True)
        ucrChkTmaxAbove90Percent.AddParameterPresentCondition(False, "climdex.tx90p", False)
        ucrChkTmaxAbove90Percent.bChangeParameterValue = False

        'ucrChkMeanDiurnalTempRange.Checked = False
        ucrChkMeanDiurnalTempRange.SetText("Mean Diurnal Temperature Range [16]")
        '        dctInputindicesTriples.Add(ucrChkMeanDiurnalTempRange.chkCheck.Text, {"Mean_Diurnal_Temperature_Range", "climdex.dtr"}.ToList)
        ucrChkMeanDiurnalTempRange.AddParameterPresentCondition(True, "climdex.dtr", True)
        ucrChkMeanDiurnalTempRange.AddParameterPresentCondition(False, "climdex.dtr", False)
        ucrChkMeanDiurnalTempRange.bChangeParameterValue = False

        ' Precipitation tab:
        'ucrChkMonthlyMax1dayPrec.Checked = False
        ucrChkMonthlyMax1dayPrec.SetText("Monthly Maximum 1-day Precipitation [17]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMax1dayPrec.chkCheck.Text, {"Monthly_Maximum_1day_Precipitation", "climdex.rx1day"}.ToList)
        ucrChkMonthlyMax1dayPrec.AddParameterPresentCondition(True, "climdex.rx1day", True)
        ucrChkMonthlyMax1dayPrec.AddParameterPresentCondition(False, "climdex.rx1day", False)
        ucrChkMonthlyMax1dayPrec.bChangeParameterValue = False

        'ucrChkMonthlyMax5dayPrec.Checked = False
        ucrChkMonthlyMax5dayPrec.SetText("Monthly Maximum Consecutive 5-day Precipitation [18]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMax5dayPrec.chkCheck.Text, {"Monthly_Maximum_Consecutive_5day_Precipitation", "climdex.rx5day"}.ToList)
        ucrChkMonthlyMax5dayPrec.AddParameterPresentCondition(True, "climdex.rx5day", True)
        ucrChkMonthlyMax5dayPrec.AddParameterPresentCondition(False, "climdex.rx5day", False)
        ucrChkMonthlyMax5dayPrec.bChangeParameterValue = False

        'ucrChkSimplePrecII.Checked = False
        ucrChkSimplePrecII.SetText("Simple Precipitation Intensity Index [19]")
        '        dctInputindicesTriples.Add(ucrChkSimplePrecII.chkCheck.Text, {"Simple_Precipitation_Intensity_Index", "climdex.sdii"}.ToList)
        ucrChkSimplePrecII.AddParameterPresentCondition(True, "climdex.sdii", True)
        ucrChkSimplePrecII.AddParameterPresentCondition(False, "climdex.sdii", False)
        ucrChkSimplePrecII.bChangeParameterValue = False

        'ucrChkPrecExceed10mm.Checked = False
        ucrChkPrecExceed10mm.SetText("Precipitation Exceeding 10mm Per Day [20]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed10mm.chkCheck.Text, {"Precipitation_Exceeding_10mm_Per_Day", "climdex.r10mm"}.ToList)
        ucrChkPrecExceed10mm.AddParameterPresentCondition(True, "climdex.r10mm", True)
        ucrChkPrecExceed10mm.AddParameterPresentCondition(False, "climdex.r10mm", False)
        ucrChkPrecExceed10mm.bChangeParameterValue = False

        'ucrChkPrecExceed20mm.Checked = False
        ucrChkPrecExceed20mm.SetText("Precipitation Exceeding 20mm Per Day [21]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed20mm.chkCheck.Text, {"Precipitation_Exceeding_20mm_Per_Day", "climdex.r20mm"}.ToList)
        ucrChkPrecExceed20mm.AddParameterPresentCondition(True, "climdex.r20mm", True)
        ucrChkPrecExceed20mm.AddParameterPresentCondition(False, "climdex.r20mm", False)
        ucrChkPrecExceed20mm.bChangeParameterValue = False

        'ucrChkPrecExceedSpecifiedA.Checked = False
        ucrChkPrecExceedSpecifiedA.SetText("Precipitation Exceeding a Specified Amount Per Day [22]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceedSpecifiedA.chkCheck.Text, {"Precipitation_Exceeding_a_Specified_Amount_Per_Day", "climdex.rnnmm"}.ToList)
        ucrChkPrecExceedSpecifiedA.AddParameterPresentCondition(True, "climdex.rnnmm", True)
        ucrChkPrecExceedSpecifiedA.AddParameterPresentCondition(False, "climdex.rnnmm", False)
        ucrChkPrecExceedSpecifiedA.bChangeParameterValue = False

        'ucrChkMaxDrySpell.Checked = False
        ucrChkMaxDrySpell.SetText("Maximum Length of Dry Spell [23]")
        '        dctInputindicesTriples.Add(ucrChkMaxDrySpell.chkCheck.Text, {"Maximum_Length_of_Dry_Spell", "climdex.cdd"}.ToList)
        ucrChkMaxDrySpell.AddParameterPresentCondition(True, "climdex.cdd", True)
        ucrChkMaxDrySpell.AddParameterPresentCondition(False, "climdex.cdd", False)
        ucrChkMaxDrySpell.bChangeParameterValue = False

        'ucrChkMaxWetSpell.Checked = False
        ucrChkMaxWetSpell.SetText("Maximum Length of Wet Spell [24]")
        '        dctInputindicesTriples.Add(ucrChkMaxWetSpell.chkCheck.Text, {"Maximum_Length_of_Wet_Spell", "climdex.cwd"}.ToList)
        ucrChkMaxWetSpell.AddParameterPresentCondition(True, "climdex.cwd", True)
        ucrChkMaxWetSpell.AddParameterPresentCondition(False, "climdex.cwd", False)
        ucrChkMaxWetSpell.bChangeParameterValue = False

        'ucrChkPrecExceed95Percent.Checked = False
        ucrChkPrecExceed95Percent.SetText("Total Daily Precipitation Exceeding 95th Percentile Threshold [25]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed95Percent.chkCheck.Text, {"Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold", "climdex.r95ptot"}.ToList)
        ucrChkPrecExceed95Percent.AddParameterPresentCondition(True, "climdex.r95ptot", True)
        ucrChkPrecExceed95Percent.AddParameterPresentCondition(False, "climdex.r95ptot", False)
        ucrChkPrecExceed95Percent.bChangeParameterValue = False

        'ucrChkPrecExceed99Percent.Checked = False
        ucrChkPrecExceed99Percent.SetText("Total Daily Precipitation Exceeding 99th Percentile Threshold [26]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed99Percent.chkCheck.Text, {"Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold", "climdex.r99ptot"}.ToList)
        ucrChkPrecExceed99Percent.AddParameterPresentCondition(True, "climdex.r99ptot", True)
        ucrChkPrecExceed99Percent.AddParameterPresentCondition(False, "climdex.r99ptot", False)
        ucrChkPrecExceed99Percent.bChangeParameterValue = False

        'ucrChkTotalDailyPrec.Checked = False
        ucrChkTotalDailyPrec.SetText("Total Daily Precipitation [27]")
        '        dctInputindicesTriples.Add(ucrChkTotalDailyPrec.chkCheck.Text, {"Total_Daily_Precipitation", "climdex.prcptot"}.ToList)
        ucrChkTotalDailyPrec.AddParameterPresentCondition(True, "climdex.prcptot", True)
        ucrChkTotalDailyPrec.AddParameterPresentCondition(False, "climdex.prcptot", False)
        ucrChkTotalDailyPrec.bChangeParameterValue = False

        ' Settings tab:

        ucrInputFreq.SetParameter(New RParameter("freq", 2))
        dctInputFreqPairs.Add("annual", Chr(34) & "annual" & Chr(34))
        dctInputFreqPairs.Add("monthly", Chr(34) & "monthly" & Chr(34))
        ucrInputFreq.SetItems(dctInputFreqPairs)
        ucrInputFreq.SetRDefault(Chr(34) & "annual" & Chr(34))
        ucrInputFreq.SetDropDownStyleAsNonEditable()

        ' TODO are these the r default or our default?
        ' TODO parameter positions
        ucrInputGSLMode.SetParameter(New RParameter("gsl.mode"))
        dctNumericPairs.Add("GSL", Chr(34) & "GSL" & Chr(34))
        dctNumericPairs.Add("GSL_first", Chr(34) & "GSL_first" & Chr(34))
        dctNumericPairs.Add("GSL_max", Chr(34) & "GSL_max" & Chr(34))
        dctNumericPairs.Add("GSL_sum", Chr(34) & "GSL_sum" & Chr(34))
        ucrInputGSLMode.SetItems(dctNumericPairs)
        ucrInputGSLMode.SetDropDownStyleAsNonEditable()
        ucrInputGSLMode.SetRDefault(Chr(34) & "GSL" & Chr(34))

        ucrNudThreshold.SetParameter(New RParameter("threshold"))
        ucrNudThreshold.SetRDefault(1)
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.SetMinMax(0, 1)
        ucrNudThreshold.Increment = 0.01

        ucrChkMaxSpellSpanYears.SetText("Maximum Spell Length Span Years")
        ucrChkMaxSpellSpanYears.SetParameter(New RParameter("spells.can.span.years"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMaxSpellSpanYears.SetRDefault("TRUE")

        ucrChkSpellDISpanYear.SetText("Spell Duration Index Span Years")
        ucrChkSpellDISpanYear.SetParameter(New RParameter("spells.can.span.years"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSpellDISpanYear.SetRDefault("FALSE")

        ucrChkNHemisphere.SetText("Northern Hemisphere")
        ucrChkNHemisphere.SetParameter(New RParameter("northern.hemisphere"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkNHemisphere.SetRDefault("TRUE")

        ucrChkCentreMean.SetText("Centre Mean on Last Day")
        ucrChkCentreMean.SetParameter(New RParameter("center.mean.on.last.day"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCentreMean.SetRDefault("FALSE")

        ucrNudMinBaseData.SetParameter(New RParameter("min.base.data.fraction.present"))
        ucrNudMinBaseData.SetRDefault(0.1)
        ucrNudMinBaseData.DecimalPlaces = 2
        ucrNudMinBaseData.SetMinMax(0, 1)
        ucrNudMinBaseData.Increment = 0.01

        ucrNudN.SetParameter(New RParameter("n"))
        ucrNudN.SetRDefault(5)
        ucrNudN.SetMinMax(1, 100)

        ' Maximum Missing Days
        ucrNudAnnualMissingDays.SetParameter(New RParameter("annual"))
        ucrNudAnnualMissingDays.SetRDefault(15)
        ucrNudAnnualMissingDays.SetMinMax(1, 366)

        ucrNudMonthlyMissingDays.SetParameter(New RParameter("monthly"))
        ucrNudMonthlyMissingDays.SetRDefault(3)
        ucrNudMonthlyMissingDays.SetMinMax(1, 31)

        ' Base Range
        ucrNudLowerBase.SetParameter(New RParameter("lower_base", 0))
        ucrNudLowerBase.SetParameterIncludeArgumentName(False)
        ucrNudLowerBase.SetRDefault(1961)
        ucrNudLowerBase.SetMinMax(1900, 9999)

        ucrNudUpperBase.SetParameter(New RParameter("upper_base", 1))
        ucrNudUpperBase.SetParameterIncludeArgumentName(False)
        ucrNudUpperBase.SetRDefault(1990)
        ucrNudUpperBase.SetMinMax(1900, 9999)

        ucrInputTempQtiles.SetParameter(New RParameter("x"))
        ucrInputTempQtiles.SetValidationTypeAsNumericList()
        ucrInputTempQtiles.AddQuotesIfUnrecognised = False
        ucrInputTempQtiles.SetParameterIncludeArgumentName(False)
        ucrInputTempQtiles.SetRDefault("0.1, 0.9")

        ucrInputPrecQtiles.SetParameter(New RParameter("x"))
        ucrInputPrecQtiles.SetValidationTypeAsNumericList()
        ucrInputPrecQtiles.AddQuotesIfUnrecognised = False
        ucrInputPrecQtiles.SetParameterIncludeArgumentName(False)
        ucrInputPrecQtiles.SetRDefault("0.95, 0.99")

        lstGroupboxes = New List(Of GroupBox)
        lstGroupboxes.AddRange({grpPrecAnnual, grpPrecAnnualMonthly, grpTmaxAnnual, grpTmaxAnnualMonthly, grpTminAnnual, grpTminAnnualMonthly, grpTmaxTminAnnual, grpTmaxTminAnnualMonthly})

        ' Tool tips
        ttClimdexIndices.SetToolTip(ucrChkFrostDays.chkCheck, "The annual count of days where daily minimum temperature drops below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkSummerDays.chkCheck, "The annual count of days where daily maximum temperature exceeds 25 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkIcingDays.chkCheck, "The annual count of days where daily maximum temperature is below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkTropicalNights.chkCheck, "The annual count of days where daily minimum temperature stays above 20 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkGrowingSeasonLength.chkCheck, "The number of days between the start of the first spell of warm days in the first half of the year, and the start of the first spell of cold days in the second half of the year")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMaxDailyTMax.chkCheck, "Computes the monthly or annual maximum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMaxDailyTMin.chkCheck, "Computes the monthly or annual maximum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMinDailyTMax.chkCheck, "Computes the monthly or annual minimum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMinDailyTMin.chkCheck, "Computes the monthly or annual minimum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(ucrChkTminBelow10Percent.chkCheck, "Computes  the monthly or annual proportion of minimum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTmaxBelow10Percent.chkCheck, "Computes  the monthly or annual proportion of maximum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTminAbove90Percent.chkCheck, "Computes  the monthly or annual proportion of minimum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTmaxAbove90Percent.chkCheck, "Computes  the monthly or annual proportion of maximum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(ucrChkWarmSpellDI.chkCheck, "Warm spell is defined as a sequence of 6 or more days in which the daily maximum temperature exceeds the 90th percentile of daily maximum temperature for a 5-day running window surrounding this day during the baseline period")
        ttClimdexIndices.SetToolTip(ucrChkColdSpellDI.chkCheck, "Cold spell is defined as a sequence of 6 or more days in which the daily minimum temperature is below the 10th percentile of daily minimum temperature for a 5-day running window surrounding this day during the baseline period")
        ttClimdexIndices.SetToolTip(ucrChkMeanDiurnalTempRange.chkCheck, "Computes the mean daily diurnal temperature range. The frequency of observation can be either monthly or annual")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMax1dayPrec.chkCheck, "Computes the climdex index Rx1day: monthly or annual maximum 1-day precipitation")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMax5dayPrec.chkCheck, "Computes the monthly or annual maximum consecutive 5-day precipitation")
        ttClimdexIndices.SetToolTip(ucrChkSimplePrecII.chkCheck, "The sum of precipitation in wet days (days with preciptitation over 1mm) during the year divided by the number of wet days in the year.")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed10mm.chkCheck, "Computes the annual count of days where daily precipitation is more than 10mm per day")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed20mm.chkCheck, "Computes the annual count of days where daily precipitation is more than 20mm per day")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceedSpecifiedA.chkCheck, "Computes the climdex index Rnnmm: the annual count of days where daily precipitation is more than nn mm per day")
        ttClimdexIndices.SetToolTip(ucrChkMaxDrySpell.chkCheck, "Maximum number of days when precipitation is less than 1mm.")
        ttClimdexIndices.SetToolTip(ucrChkMaxWetSpell.chkCheck, "Maximum number of days when precipitation is greater than 1mm")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed95Percent.chkCheck, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 95th percentile of daily precipitation in the base period")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed99Percent.chkCheck, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 99th percentile of daily precipitation in the base period")
        ttClimdexIndices.SetToolTip(ucrChkTotalDailyPrec.chkCheck, "Computes the annual sum of precipitation in wet days (days where precipitation is at least 1mm)")

        ' sort this.
        clsNewClimdexInput.AddParameter("base.range", clsRFunctionParameter:=clsRBaseRange)
        clsNewClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        clsNewClimdexInput.AddParameter("temp.qtiles", clsRFunctionParameter:=clsRTempQTiles)
        clsNewClimdexInput.AddParameter("prec.qtiles", clsRFunctionParameter:=clsRPrecQTiles)

        ' this should run in the main dialog and connect in
        clsROneArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg1.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg2.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg3.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg4.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg5.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRThreeArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)

        clsROneArg.SetPackageName("climdex.pcic")
        clsRTwoArg1.SetPackageName("climdex.pcic")
        clsRTwoArg2.SetPackageName("climdex.pcic")
        clsRTwoArg3.SetPackageName("climdex.pcic")
        clsRTwoArg4.SetPackageName("climdex.pcic")
        clsRTwoArg5.SetPackageName("climdex.pcic")
        clsRThreeArg.SetPackageName("climdex.pcic")
        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Private Sub SaveIndices(ucrchkTemp As ucrCheck, clsIndex As RFunction, bSave As Boolean)
        Dim clsRListDF, clsRConvertDF As New RFunction
        clsRWriteDf.SetRCommand("InstatDataObject$add_climdex_indices")
        clsRListDF.SetRCommand("list")
        clsRListDF.AddParameter(dctInputindicesTriples.Item(ucrchkTemp.chkCheck.Text)(0), clsRFunctionParameter:=clsIndex)
        clsRWriteDf.AddParameter("indices", clsRFunctionParameter:=clsRListDF)
        If bSave Then
            frmMain.clsRLink.RunScript(clsRWriteDf.ToScript(), 0)
        Else
            frmMain.clsRLink.RunScript(clsIndex.ToScript(), 2)
        End If
    End Sub

    Public Sub IndicesOptions(bSaveIndex As Boolean)
        If (ucrChkFrostDays.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkFrostDays.chkCheck.Text)(1))
            SaveIndices(ucrChkFrostDays, clsROneArg, bSaveIndex)
        End If
        If (ucrChkSummerDays.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkSummerDays.chkCheck.Text)(1))
            SaveIndices(ucrChkSummerDays, clsROneArg, bSaveIndex)
        End If
        If (ucrChkIcingDays.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkIcingDays.chkCheck.Text)(1))
            SaveIndices(ucrChkIcingDays, clsROneArg, bSaveIndex)
        End If
        If (ucrChkTropicalNights.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkTropicalNights.chkCheck.Text)(1))
            SaveIndices(ucrChkTropicalNights, clsROneArg, bSaveIndex)
        End If
        If (ucrChkGrowingSeasonLength.Checked = True) Then
            clsRTwoArg2.SetRCommand(dctInputindicesTriples.Item(ucrChkGrowingSeasonLength.chkCheck.Text)(1))
            SaveIndices(ucrChkGrowingSeasonLength, clsRTwoArg2, bSaveIndex)
        End If
        If (ucrChkMonthlyMaxDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMaxDailyTMax.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMaxDailyTMax, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkMonthlyMaxDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMaxDailyTMin.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMaxDailyTMin, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkMonthlyMinDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMinDailyTMax.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMinDailyTMax, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkMonthlyMinDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMinDailyTMin.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMinDailyTMin, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkTminBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTminBelow10Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkTminBelow10Percent, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkTmaxBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTmaxBelow10Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkTmaxBelow10Percent, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkTminAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTminAbove90Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkTminAbove90Percent, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkTmaxAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTmaxAbove90Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkTmaxAbove90Percent, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkWarmSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand(dctInputindicesTriples.Item(ucrChkWarmSpellDI.chkCheck.Text)(1))
            SaveIndices(ucrChkWarmSpellDI, clsRTwoArg5, bSaveIndex)
        End If
        If (ucrChkColdSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand(dctInputindicesTriples.Item(ucrChkColdSpellDI.chkCheck.Text)(1))
            SaveIndices(ucrChkColdSpellDI, clsRTwoArg5, bSaveIndex)
        End If
        If (ucrChkMeanDiurnalTempRange.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMeanDiurnalTempRange.chkCheck.Text)(1))
            SaveIndices(ucrChkMeanDiurnalTempRange, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkMonthlyMax1dayPrec.Checked = True) Then
            clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMax1dayPrec.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMax1dayPrec, clsRTwoArg1, bSaveIndex)
        End If
        If (ucrChkMonthlyMax5dayPrec.Checked = True) Then
            clsRThreeArg.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMax5dayPrec.chkCheck.Text)(1))
            SaveIndices(ucrChkMonthlyMax5dayPrec, clsRThreeArg, bSaveIndex)
        End If
        If (ucrChkSimplePrecII.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkSimplePrecII.chkCheck.Text)(1))
            SaveIndices(ucrChkSimplePrecII, clsROneArg, bSaveIndex)
        End If
        If (ucrChkPrecExceed10mm.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed10mm.chkCheck.Text)(1))
            SaveIndices(ucrChkPrecExceed10mm, clsROneArg, bSaveIndex)
        End If
        If (ucrChkPrecExceed20mm.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed20mm.chkCheck.Text)(1))
            SaveIndices(ucrChkPrecExceed20mm, clsROneArg, bSaveIndex)
        End If
        If (ucrChkPrecExceedSpecifiedA.Checked = True) Then
            clsRTwoArg3.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceedSpecifiedA.chkCheck.Text)(1))
            SaveIndices(ucrChkPrecExceedSpecifiedA, clsRTwoArg3, bSaveIndex)
        End If
        If (ucrChkMaxDrySpell.Checked = True) Then
            clsRTwoArg4.SetRCommand(dctInputindicesTriples.Item(ucrChkMaxDrySpell.chkCheck.Text)(1))
            SaveIndices(ucrChkMaxDrySpell, clsRTwoArg4, bSaveIndex)
        End If
        If (ucrChkMaxWetSpell.Checked = True) Then
            clsRTwoArg4.SetRCommand(dctInputindicesTriples.Item(ucrChkMaxWetSpell.chkCheck.Text)(1))
            SaveIndices(ucrChkMaxWetSpell, clsRTwoArg4, bSaveIndex)
        End If
        If (ucrChkPrecExceed95Percent.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed95Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkPrecExceed95Percent, clsROneArg, bSaveIndex)
        End If
        If (ucrChkPrecExceed99Percent.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed99Percent.chkCheck.Text)(1))
            SaveIndices(ucrChkPrecExceed99Percent, clsROneArg, bSaveIndex)
        End If
        If (ucrChkTotalDailyPrec.Checked = True) Then
            clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkTotalDailyPrec.chkCheck.Text)(1))
            SaveIndices(ucrChkTotalDailyPrec, clsROneArg, bSaveIndex)
        End If
    End Sub

    Public Sub SetRCode(clsNewRFunction As RFunction, clsFrostDays As RFunction, clsSummerDays As RFunction, clsIcingDays As RFunction, clsTropicalNights As RFunction, clsWarmSpellDI As RFunction, clsColdSpellDI As RFunction, clsGrowingSeasonLength As RFunction, clsMonthlyMaxDailyTMax As RFunction, clsMonthlyMaxDailyTMin As RFunction, clsMonthlyMinDailyTMax As RFunction, clsMonthlyMinDailyTMin As RFunction, clsTminBelow10Percent As RFunction, clsTmaxBelow10Percent As RFunction, clsTminAbove90Percent As RFunction, clsTmaxAbove90Percent As RFunction, clsMeanDiurnalTempRange As RFunction, clsMonthlyMax1DayPrec As RFunction, clsMonthlyMax5DayPrec As RFunction, clsSimplePrecII As RFunction, clsPrecExceed10mm As RFunction, clsPrecExceed20mm As RFunction, clsPrecExceedSpecifiedA As RFunction, clsMaxDrySpell As RFunction, clsMaxWetSpell As RFunction, clsPrecExceed95Percent As RFunction, clsPrecExceed99Percent As RFunction, clsTotalDailyPrec As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsNewClimdexInput = clsNewRFunction
        clsFrostDays = clsNewFrostDays
        clsSummerDays = clsNewSummerDays
        clsIcingDays = clsNewIcingDays
        clsTropicalNights = clsNewTropicalNights
        clsWarmSpellDI = clsNewWarmSpellDI
        clsColdSpellDI = clsNewColdSpellDI
        clsGrowingSeasonLength = clsNewGrowingSeasonLength
        clsMonthlyMaxDailyTMax = clsNewMonthlyMaxDailyTMax
        clsMonthlyMaxDailyTMin = clsNewMonthlyMaxDailyTMin
        clsMonthlyMinDailyTMax = clsNewMonthlyMinDailyTMax
        clsMonthlyMinDailyTMin = clsNewMonthlyMinDailyTMin
        clsTminBelow10Percent = clsNewTminBelow10Percent
        clsTmaxBelow10Percent = clsNewTmaxBelow10Percent
        clsTminAbove90Percent = clsNewTminAbove90Percent
        clsTmaxAbove90Percent = clsNewTmaxAbove90Percent
        clsMeanDiurnalTempRange = clsNewMeanDiurnalTempRange
        clsMonthlyMax1DayPrec = clsNewMonthlyMax1DayPrec
        clsMonthlyMax5DayPrec = clsNewMonthlyMax5DayPrec
        clsSimplePrecII = clsNewSimplePrecII
        clsPrecExceed10mm = clsNewPrecExceed10mm
        clsPrecExceed20mm = clsNewPrecExceed20mm
        clsPrecExceedSpecifiedA = clsNewPrecExceedSpecifiedA
        clsMaxDrySpell = clsNewMaxDrySpell
        clsMaxWetSpell = clsNewMaxWetSpell
        clsPrecExceed95Percent = clsNewPrecExceed95Percent
        clsPrecExceed99Percent = clsNewPrecExceed99Percent
        clsTotalDailyPrec = clsNewTotalDailyPrec

        ucrChkFrostDays.SetRCode(clsFrostDays, bReset, bCloneIfNeeded:=True)
        ucrChkSummerDays.SetRCode(clsSummerDays, bReset, bCloneIfNeeded:=True)
        ucrChkIcingDays.SetRCode(clsIcingDays, bReset, bCloneIfNeeded:=True)
        ucrChkTropicalNights.SetRCode(clsTropicalNights, bReset, bCloneIfNeeded:=True)
        ucrChkWarmSpellDI.SetRCode(clsWarmSpellDI, bReset, bCloneIfNeeded:=True)
        ucrChkColdSpellDI.SetRCode(clsColdSpellDI, bReset, bCloneIfNeeded:=True)
        ucrChkGrowingSeasonLength.SetRCode(clsGrowingSeasonLength, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMaxDailyTMax.SetRCode(clsMonthlyMaxDailyTMax, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMaxDailyTMin.SetRCode(clsMonthlyMaxDailyTMin, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMinDailyTMax.SetRCode(clsMonthlyMinDailyTMax, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMinDailyTMin.SetRCode(clsMonthlyMinDailyTMin, bReset, bCloneIfNeeded:=True)
        ucrChkTminBelow10Percent.SetRCode(clsTminBelow10Percent, bReset, bCloneIfNeeded:=True)
        ucrChkTmaxBelow10Percent.SetRCode(clsTmaxBelow10Percent, bReset, bCloneIfNeeded:=True)
        ucrChkTminAbove90Percent.SetRCode(clsTminAbove90Percent, bReset, bCloneIfNeeded:=True)
        ucrChkTmaxAbove90Percent.SetRCode(clsTmaxAbove90Percent, bReset, bCloneIfNeeded:=True)
        ucrChkMeanDiurnalTempRange.SetRCode(clsMeanDiurnalTempRange, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMax1dayPrec.SetRCode(clsMonthlyMax1DayPrec, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMax5dayPrec.SetRCode(clsMonthlyMax5DayPrec, bReset, bCloneIfNeeded:=True)
        ucrChkSimplePrecII.SetRCode(clsSimplePrecII, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed10mm.SetRCode(clsPrecExceed10mm, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed20mm.SetRCode(clsPrecExceed20mm, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceedSpecifiedA.SetRCode(clsPrecExceedSpecifiedA, bReset, bCloneIfNeeded:=True)
        ucrChkMaxDrySpell.SetRCode(clsMaxDrySpell, bReset, bCloneIfNeeded:=True)
        ucrChkMaxWetSpell.SetRCode(clsMaxWetSpell, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed95Percent.SetRCode(clsPrecExceed95Percent, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed99Percent.SetRCode(clsPrecExceed99Percent, bReset, bCloneIfNeeded:=True)
        ucrChkTotalDailyPrec.SetRCode(clsTotalDailyPrec, bReset, bCloneIfNeeded:=True)


        ' TODO: go through this
        ucrNudN.SetRCode(clsNewClimdexInput, bReset, bCloneIfNeeded:=True)
        ucrNudThreshold.SetRCode(clsRTwoArg3, bReset, bCloneIfNeeded:=True)
        ucrNudAnnualMissingDays.SetRCode(clsRMaxMisingDays, bReset, bCloneIfNeeded:=True)
        ucrNudMonthlyMissingDays.SetRCode(clsRMaxMisingDays, bReset, bCloneIfNeeded:=True)
        ucrNudLowerBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)
        ucrNudUpperBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)
        ucrNudMinBaseData.SetRCode(clsNewClimdexInput, bReset, bCloneIfNeeded:=True)
        ucrInputFreq.SetRCode(clsRTwoArg1, bReset, bCloneIfNeeded:=True)
        ucrInputFreq.SetRCode(clsRThreeArg, bReset, bCloneIfNeeded:=True)
        ucrInputFreq.SetRCode(clsRWriteDf, bReset, bCloneIfNeeded:=True)
        ucrInputTempQtiles.SetRCode(clsRTempQTiles, bReset, bCloneIfNeeded:=True)
        ucrInputPrecQtiles.SetRCode(clsRPrecQTiles, bReset, bCloneIfNeeded:=True)
        ucrChkNHemisphere.SetRCode(clsNewClimdexInput, bReset, bCloneIfNeeded:=True)
        ucrChkCentreMean.SetRCode(clsRThreeArg, bReset, bCloneIfNeeded:=True)
        ucrChkMaxSpellSpanYears.SetRCode(clsRTwoArg4, bReset, bCloneIfNeeded:=True)
        ucrChkSpellDISpanYear.SetRCode(clsRTwoArg5, bReset, bCloneIfNeeded:=True)
        ucrInputGSLMode.SetRCode(clsRTwoArg2, bReset, bCloneIfNeeded:=True)
        IndicesType()

        If bReset Then
            tbpClimdex.SelectedIndex = 0
        End If
    End Sub

    Private Sub grpTmaxAnnualMonthly_Enter(sender As Object, e As EventArgs) Handles grpTmaxAnnualMonthly.Enter

    End Sub

    Private Sub GroupBoxControl(TempGroupBox As GroupBox)
        For Each ChkBox As ucrCheck In TempGroupBox.Controls
            ChkBox.Checked = False
        Next
    End Sub

    Public Sub IndicesType()
        If dlgClimdex.ucrReceiverPrec.IsEmpty Then
            GroupBoxControl(grpPrecAnnual)
            GroupBoxControl(grpPrecAnnualMonthly)
            grpPrecAnnualMonthly.Enabled = False
            grpPrecAnnual.Enabled = False
        Else
            If ucrInputFreq.cboInput.SelectedItem = "monthly" Then
                GroupBoxControl(grpPrecAnnual)
                grpPrecAnnual.Enabled = False
            ElseIf ucrInputFreq.cboInput.SelectedItem = "annual" Then
                grpPrecAnnual.Enabled = True
            End If
            grpPrecAnnualMonthly.Enabled = True
        End If

        If dlgClimdex.ucrReceiverTmax.IsEmpty Then
            GroupBoxControl(grpTmaxAnnual)
            GroupBoxControl(grpTmaxAnnualMonthly)
            grpTmaxAnnualMonthly.Enabled = False
            grpTmaxAnnual.Enabled = False
        Else
            If ucrInputFreq.cboInput.SelectedItem = "monthly" Then
                GroupBoxControl(grpTmaxAnnual)
                grpTmaxAnnual.Enabled = False
            ElseIf ucrInputFreq.cboInput.SelectedItem = "annual" Then
                grpTmaxAnnual.Enabled = True
            End If
            grpTmaxAnnualMonthly.Enabled = True
        End If

        If dlgClimdex.ucrReceiverTmin.IsEmpty Then
            GroupBoxControl(grpTminAnnual)
            GroupBoxControl(grpTminAnnualMonthly)
            grpTminAnnualMonthly.Enabled = False
            grpTminAnnual.Enabled = False
        Else
            If ucrInputFreq.cboInput.SelectedItem = "monthly" Then
                GroupBoxControl(grpTminAnnual)
                grpTminAnnual.Enabled = False
            ElseIf ucrInputFreq.cboInput.SelectedItem = "annual" Then
                grpTminAnnual.Enabled = True
            End If
            grpTminAnnualMonthly.Enabled = True
        End If

        If dlgClimdex.ucrReceiverTmin.IsEmpty OrElse dlgClimdex.ucrReceiverTmax.IsEmpty Then
            GroupBoxControl(grpTmaxTminAnnual)
            GroupBoxControl(grpTmaxTminAnnualMonthly)
            grpTmaxTminAnnualMonthly.Enabled = False
            grpTmaxTminAnnual.Enabled = False
        Else
            If ucrInputFreq.cboInput.SelectedItem = "monthly" Then
                GroupBoxControl(grpTmaxTminAnnual)
                grpTmaxTminAnnual.Enabled = False
            ElseIf ucrInputFreq.cboInput.SelectedItem = "annual" Then
                grpTmaxTminAnnual.Enabled = True
            End If
            grpTmaxTminAnnualMonthly.Enabled = True
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        IndicesHelp()
    End Sub

    Private Sub IndicesHelp()
        Dim clsHelp As New RFunction
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & "climdex.pcic" & Chr(34))
        If IndicesCount = 1 Then
            clsHelp.AddParameter("topic", Chr(34) & CheckedBoxFunction() & Chr(34))
        Else
            clsHelp.RemoveParameterByName("topic")
        End If
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:=" dlgClimdexIndices Opening help page climdex indices")
    End Sub

    Public ReadOnly Property IndicesCount As Integer
        Get
            Dim iCount As Integer = 0
            For Each grpTemp As GroupBox In lstGroupboxes
                For Each TempChkBox As ucrCheck In grpTemp.Controls
                    If TempChkBox.Checked Then
                        iCount = iCount + 1
                    End If
                Next
            Next
            Return iCount
        End Get
    End Property

    Private Function CheckedBoxFunction()
        Dim strCheckedBox As String = ""
        For Each grpTemp As GroupBox In lstGroupboxes
            For Each TempChkBox As ucrCheck In grpTemp.Controls
                If TempChkBox.Checked Then
                    strCheckedBox = dctInputindicesTriples.Item(TempChkBox.chkCheck.Text)(1)
                End If
            Next
        Next
        Return strCheckedBox
    End Function

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudLowerBase.ControlContentsChanged, ucrNudUpperBase.ControlContentsChanged
        clsNewClimdexInput.AddParameter("base.range", clsRFunctionParameter:=clsRBaseRange)
    End Sub

    Private Sub TempQTiles_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTempQtiles.ControlContentsChanged
        clsNewClimdexInput.AddParameter("temp.qtiles", clsRFunctionParameter:=clsRTempQTiles)
    End Sub

    Private Sub PrecQTiles_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputPrecQtiles.ControlContentsChanged
        clsNewClimdexInput.AddParameter("prec.qtiles", clsRFunctionParameter:=clsRPrecQTiles)
    End Sub

    Private Sub ucrInputFreq_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFreq.ControlContentsChanged
        IndicesType()
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpClimdex.TabCount - 1
            tbpClimdex.SelectedIndex = i
        Next
        tbpClimdex.TabPages(2).Enabled = False
        tbpClimdex.TabPages(1).Enabled = False
        tbpClimdex.SelectedIndex = 0
    End Sub
End Class