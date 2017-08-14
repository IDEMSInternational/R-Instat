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
    Public clsClimdexInput, clsRWriteDf, clsRWriteDfIndicesList As New RFunction
    Public clsRMaxMissingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles As New RFunction
    Public clsFrostDays, clsSummerDays, clsIcingDays, clsTropicalNights, clsWarmSpellDI, clsColdSpellDI, clsGrowingSeasonLength, clsMonthlyMaxDailyTMax, clsMonthlyMaxDailyTMin, clsMonthlyMinDailyTMax, clsMonthlyMinDailyTMin, clsTminBelow10Percent, clsTmaxBelow10Percent, clsTminAbove90Percent, clsTmaxAbove90Percent, clsMeanDiurnalTempRange As New RFunction
    Public clsMonthlyMax1DayPrec, clsMonthlyMax5DayPrec, clsSimplePrecII, clsPrecExceed10mm, clsPrecExceed20mm, clsPrecExceedSpecifiedA, clsMaxDrySpell, clsMaxWetSpell, clsPrecExceed95Percent, clsPrecExceed99Percent, clsTotalDailyPrec As New RFunction
    Dim lstGroupboxes As List(Of GroupBox)
    Dim dctInputindicesTriples As New Dictionary(Of String, List(Of String))
    Private Sub sdgClimdexIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctInputFreqPairs As New Dictionary(Of String, String)
        Dim dctNumericPairs As New Dictionary(Of String, String)
        Dim dctCategoricalPairs As New Dictionary(Of String, String)

        'Annual for Max and Min Temperatures
        ucrChkFrostDays.SetParameter(New RParameter("Frost_Days", clsFrostDays, 0, False), bNewChangeParameterValue:=False)
        ucrChkFrostDays.SetText("Frost Days [1]")
        'dctInputindicesTriples.Add(ucrChkFrostDays.chkCheck.Text, {"Frost_Days", "climdex.fd"}.ToList)
        ucrChkFrostDays.AddParameterPresentCondition(True, "list", True)
        ucrChkFrostDays.AddParameterPresentCondition(False, "list", False)

        ucrChkSummerDays.SetParameter(New RParameter("Summer_Days", clsSummerDays, 1, False), bNewChangeParameterValue:=False)
        ucrChkSummerDays.SetText("Summer Days [2]")
        '        dctInputindicesTriples.Add(ucrChkSummerDays.chkCheck.Text, {"Summer_Days", "climdex.su"}.ToList)
        ucrChkSummerDays.AddParameterPresentCondition(True, "list", True)
        ucrChkSummerDays.AddParameterPresentCondition(False, "list", False)

        ucrChkIcingDays.SetParameter(New RParameter("Icing_Days", clsIcingDays, 2, False), bNewChangeParameterValue:=False)
        ucrChkIcingDays.SetText("Icing Days [3]")
        '        dctInputindicesTriples.Add(ucrChkIcingDays.chkCheck.Text, {"Icing_Days", "climdex.id"}.ToList)
        ucrChkIcingDays.AddParameterPresentCondition(True, "list", True)
        ucrChkIcingDays.AddParameterPresentCondition(False, "list", False)

        ucrChkTropicalNights.SetParameter(New RParameter("Tropical_Nights", clsTropicalNights, 3, False), bNewChangeParameterValue:=False)
        ucrChkTropicalNights.SetText("Tropical Nights [4]")
        '        dctInputindicesTriples.Add(ucrChkTropicalNights.chkCheck.Text, {"Tropical_Nights", "climdex.tr"}.ToList)
        ucrChkTropicalNights.AddParameterPresentCondition(True, "list", True)
        ucrChkTropicalNights.AddParameterPresentCondition(False, "list", False)

        ucrChkWarmSpellDI.SetParameter(New RParameter("Warm_Spell_Duration_Index", clsWarmSpellDI, 4, False), bNewChangeParameterValue:=False)
        ucrChkWarmSpellDI.SetText("Warm Spell Duration Index [14]")
        '        dctInputindicesTriples.Add(ucrChkWarmSpellDI.chkCheck.Text, {"Warm_Spell_Duration_Index", "climdex.wsdi"}.ToList)
        ucrChkWarmSpellDI.AddParameterPresentCondition(True, "list", True)
        ucrChkWarmSpellDI.AddParameterPresentCondition(False, "list", False)

        ucrChkColdSpellDI.SetParameter(New RParameter("Cold_Spell_Duration_Index", clsColdSpellDI, 5, False), bNewChangeParameterValue:=False)
        ucrChkColdSpellDI.SetText("Cold Spell Duration Index [15]")
        '        dctInputindicesTriples.Add(ucrChkColdSpellDI.chkCheck.Text, {"Cold_Spell_Duration_Index", "climdex.csdi"}.ToList)
        ucrChkColdSpellDI.AddParameterPresentCondition(True, "list", True)
        ucrChkColdSpellDI.AddParameterPresentCondition(False, "list", False)

        ucrChkGrowingSeasonLength.SetParameter(New RParameter("Growing_Season_Length", clsGrowingSeasonLength, 6, False), bNewChangeParameterValue:=False)
        ucrChkGrowingSeasonLength.SetText("Growing Season Length [5]")
        '        dctInputindicesTriples.Add(ucrChkGrowingSeasonLength.chkCheck.Text, {"Growing_Season_Length", "climdex.gsl"}.ToList)
        ucrChkGrowingSeasonLength.AddParameterPresentCondition(True, "list", True)
        ucrChkGrowingSeasonLength.AddParameterPresentCondition(False, "list", False)

        ' Annual/Monthly
        ucrChkMonthlyMaxDailyTMax.SetParameter(New RParameter("Monthly_Maximum_of_Daily_Maximum_Temperature", clsMonthlyMaxDailyTMax, 7, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMax.SetText("Monthly Maximum of Daily Maximum Temperature [6]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMaxDailyTMax.chkCheck.Text, {"Monthly_Maximum_of_Daily_Maximum_Temperature", "climdex.txx"}.ToList)
        ucrChkMonthlyMaxDailyTMax.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMaxDailyTMax.AddParameterPresentCondition(False, "list", False)

        ucrChkMonthlyMaxDailyTMin.SetParameter(New RParameter("Monthly_Maximum_of_Daily_Minimum_Temperature", clsMonthlyMaxDailyTMin, 8, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMin.SetText("Monthly Maximum of Daily Minimum Temperature [7]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMaxDailyTMin.chkCheck.Text, {"Monthly_Maximum_of_Daily_Minimum_Temperature", "climdex.txn"}.ToList)
        ucrChkMonthlyMaxDailyTMin.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMaxDailyTMin.AddParameterPresentCondition(False, "list", False)

        ucrChkMonthlyMinDailyTMax.SetParameter(New RParameter("Monthly_Minimum_of_Daily_Maximum_Temperature", clsMonthlyMinDailyTMax, 9, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMax.SetText("Monthly Minimum of Daily Maximum Temperature [8]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMinDailyTMax.chkCheck.Text, {"Monthly_Minimum_of_Daily_Maximum_Temperature", "climdex.tnx"}.ToList)
        ucrChkMonthlyMinDailyTMax.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMinDailyTMax.AddParameterPresentCondition(False, "list", False)

        ucrChkMonthlyMinDailyTMin.SetParameter(New RParameter("Monthly_Minimum_of_Daily_Minimum_Temperature", clsMonthlyMinDailyTMin, 10, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMin.SetText("Monthly Minimum of Daily Minimum Temperature [9]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMinDailyTMin.chkCheck.Text, {"Monthly_Minimum_of_Daily_Minimum_Temperature", "climdex.tnn"}.ToList)
        ucrChkMonthlyMinDailyTMin.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMinDailyTMin.AddParameterPresentCondition(False, "list", False)

        ucrChkTminBelow10Percent.SetParameter(New RParameter("Percentage_of_Days_When_Tmin_is_Below_10th_Percentile", clsTminBelow10Percent, 11, False), bNewChangeParameterValue:=False)
        ucrChkTminBelow10Percent.SetText("Percentage of Days When Tmin is Below 10th Percentile [10]")
        '        dctInputindicesTriples.Add(ucrChkTminBelow10Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmin_is_Below_10th_Percentile", "climdex.tn10p"}.ToList)
        ucrChkTminBelow10Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkTminBelow10Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkTmaxBelow10Percent.SetParameter(New RParameter("Percentage_of_Days_When_Tmax_is_Below_10th_Percentile", clsTmaxBelow10Percent, 12, False), bNewChangeParameterValue:=False)
        ucrChkTmaxBelow10Percent.SetText("Percentage of Days When Tmax is Below 10th Percentile [11]")
        '        dctInputindicesTriples.Add(ucrChkTmaxBelow10Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmax_is_Below_10th_Percentile", "climdex.tx10p"}.ToList)
        ucrChkTmaxBelow10Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkTmaxBelow10Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkTminAbove90Percent.SetParameter(New RParameter("Percentage_of_Days_When_Tmin_is_Above_90th_Percentile", clsTminAbove90Percent, 13, False), bNewChangeParameterValue:=False)
        ucrChkTminAbove90Percent.SetText("Percentage of Days When Tmin is Above 90th Percentile [12]")
        '        dctInputindicesTriples.Add(ucrChkTminAbove90Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmin_is_Above_90th_Percentile", "climdex.tn90p"}.ToList)
        ucrChkTminAbove90Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkTminAbove90Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkTmaxAbove90Percent.SetParameter(New RParameter("Percentage_of_Days_When_Tmax_is_Above_90th_Percentile", clsTmaxAbove90Percent, 14, False), bNewChangeParameterValue:=False)
        ucrChkTmaxAbove90Percent.SetText("Percentage of Days When Tmax is Above 90th Percentile [13]")
        '        dctInputindicesTriples.Add(ucrChkTmaxAbove90Percent.chkCheck.Text, {"Percentage_of_Days_When_Tmax_is_Above_90th_Percentile", "climdex.tx90p"}.ToList)
        ucrChkTmaxAbove90Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkTmaxAbove90Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkMeanDiurnalTempRange.SetParameter(New RParameter("Mean_Diurnal_Temperature_Range", clsMeanDiurnalTempRange, 15, False), bNewChangeParameterValue:=False)
        ucrChkMeanDiurnalTempRange.SetText("Mean Diurnal Temperature Range [16]")
        '        dctInputindicesTriples.Add(ucrChkMeanDiurnalTempRange.chkCheck.Text, {"Mean_Diurnal_Temperature_Range", "climdex.dtr"}.ToList)
        ucrChkMeanDiurnalTempRange.AddParameterPresentCondition(True, "list", True)
        ucrChkMeanDiurnalTempRange.AddParameterPresentCondition(False, "list", False)

        ' Precipitation tab:
        ucrChkMonthlyMax1dayPrec.SetParameter(New RParameter("Monthly_Maximum_1day_Precipitation", clsMonthlyMax1DayPrec, 16, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax1dayPrec.SetText("Monthly Maximum 1-day Precipitation [17]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMax1dayPrec.chkCheck.Text, {"Monthly_Maximum_1day_Precipitation", "climdex.rx1day"}.ToList)
        ucrChkMonthlyMax1dayPrec.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMax1dayPrec.AddParameterPresentCondition(False, "list", False)

        ucrChkMonthlyMax5dayPrec.SetParameter(New RParameter("Monthly_Maximum_5day_Precipitation", clsMonthlyMax5DayPrec, 17, False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax5dayPrec.SetText("Monthly Maximum Consecutive 5-day Precipitation [18]")
        '        dctInputindicesTriples.Add(ucrChkMonthlyMax5dayPrec.chkCheck.Text, {"Monthly_Maximum_Consecutive_5day_Precipitation", "climdex.rx5day"}.ToList)
        ucrChkMonthlyMax5dayPrec.AddParameterPresentCondition(True, "list", True)
        ucrChkMonthlyMax5dayPrec.AddParameterPresentCondition(False, "list", False)

        ucrChkSimplePrecII.SetParameter(New RParameter("Simple_Precipitation_Intensity_Index", clsSimplePrecII, 18, False), bNewChangeParameterValue:=False)
        ucrChkSimplePrecII.SetText("Simple Precipitation Intensity Index [19]")
        '        dctInputindicesTriples.Add(ucrChkSimplePrecII.chkCheck.Text, {"Simple_Precipitation_Intensity_Index", "climdex.sdii"}.ToList)
        ucrChkSimplePrecII.AddParameterPresentCondition(True, "list", True)
        ucrChkSimplePrecII.AddParameterPresentCondition(False, "list", False)

        ucrChkPrecExceed10mm.SetParameter(New RParameter("Precipitation_Exceeding_10mm_Per_Day", clsPrecExceed10mm, 19, False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed10mm.SetText("Precipitation Exceeding 10mm Per Day [20]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed10mm.chkCheck.Text, {"Precipitation_Exceeding_10mm_Per_Day", "climdex.r10mm"}.ToList)
        ucrChkPrecExceed10mm.AddParameterPresentCondition(True, "list", True)
        ucrChkPrecExceed10mm.AddParameterPresentCondition(False, "list", False)

        ucrChkPrecExceed20mm.SetParameter(New RParameter("Precipitation_Exceeding_20mm_Per_Day", clsPrecExceed20mm, 20, False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed20mm.SetText("Precipitation Exceeding 20mm Per Day [21]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed20mm.chkCheck.Text, {"Precipitation_Exceeding_20mm_Per_Day", "climdex.r20mm"}.ToList)
        ucrChkPrecExceed20mm.AddParameterPresentCondition(True, "list", True)
        ucrChkPrecExceed20mm.AddParameterPresentCondition(False, "list", False)

        ucrChkPrecExceedSpecifiedA.SetParameter(New RParameter("Precipitation_Exceeding_a_Specified_Amount_Per_Day", clsPrecExceedSpecifiedA, 21, False), bNewChangeParameterValue:=False)
        ucrChkPrecExceedSpecifiedA.SetText("Precipitation Exceeding a Specified Amount Per Day [22]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceedSpecifiedA.chkCheck.Text, {"Precipitation_Exceeding_a_Specified_Amount_Per_Day", "climdex.rnnmm"}.ToList)
        ucrChkPrecExceedSpecifiedA.AddParameterPresentCondition(True, "list", True)
        ucrChkPrecExceedSpecifiedA.AddParameterPresentCondition(False, "list", False)

        ucrChkMaxDrySpell.SetParameter(New RParameter("Maximum_Length_of_Dry_Spell", clsMaxDrySpell, 22, False), bNewChangeParameterValue:=False)
        ucrChkMaxDrySpell.SetText("Maximum Length of Dry Spell [23]")
        '        dctInputindicesTriples.Add(ucrChkMaxDrySpell.chkCheck.Text, {"Maximum_Length_of_Dry_Spell", "climdex.cdd"}.ToList)
        ucrChkMaxDrySpell.AddParameterPresentCondition(True, "list", True)
        ucrChkMaxDrySpell.AddParameterPresentCondition(False, "list", False)

        ucrChkMaxWetSpell.SetParameter(New RParameter("Maximum_Length_of_Wet_Spell", clsMaxWetSpell, 23, False), bNewChangeParameterValue:=False)
        ucrChkMaxWetSpell.SetText("Maximum Length of Wet Spell [24]")
        '        dctInputindicesTriples.Add(ucrChkMaxWetSpell.chkCheck.Text, {"Maximum_Length_of_Wet_Spell", "climdex.cwd"}.ToList)
        ucrChkMaxWetSpell.AddParameterPresentCondition(True, "list", True)
        ucrChkMaxWetSpell.AddParameterPresentCondition(False, "list", False)

        ucrChkPrecExceed95Percent.SetParameter(New RParameter("Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold", clsPrecExceed95Percent, 24, False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed95Percent.SetText("Total Daily Precipitation Exceeding 95th Percentile Threshold [25]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed95Percent.chkCheck.Text, {"Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold", "climdex.r95ptot"}.ToList)
        ucrChkPrecExceed95Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkPrecExceed95Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkPrecExceed99Percent.SetParameter(New RParameter("Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold", clsPrecExceed99Percent, 25, False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed99Percent.SetText("Total Daily Precipitation Exceeding 99th Percentile Threshold [26]")
        '        dctInputindicesTriples.Add(ucrChkPrecExceed99Percent.chkCheck.Text, {"Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold", "climdex.r99ptot"}.ToList)
        ucrChkPrecExceed99Percent.AddParameterPresentCondition(True, "list", True)
        ucrChkPrecExceed99Percent.AddParameterPresentCondition(False, "list", False)

        ucrChkTotalDailyPrec.SetParameter(New RParameter("Total_Daily_Precipitation", clsTotalDailyPrec, 26, False), bNewChangeParameterValue:=False)
        ucrChkTotalDailyPrec.SetText("Total Daily Precipitation [27]")
        '        dctInputindicesTriples.Add(ucrChkTotalDailyPrec.chkCheck.Text, {"Total_Daily_Precipitation", "climdex.prcptot"}.ToList)
        ucrChkTotalDailyPrec.AddParameterPresentCondition(True, "list", True)
        ucrChkTotalDailyPrec.AddParameterPresentCondition(False, "list", False)

        ' Settings tab:
        ucrInputFreq.SetParameter(New RParameter("freq", 2))
        dctInputFreqPairs.Add("annual", Chr(34) & "annual" & Chr(34))
        dctInputFreqPairs.Add("monthly", Chr(34) & "monthly" & Chr(34))
        ucrInputFreq.SetItems(dctInputFreqPairs)
        ucrInputFreq.SetRDefault(Chr(34) & "annual" & Chr(34))
        ucrInputFreq.SetDropDownStyleAsNonEditable()

        'climdex.gsl: used gsl.mode = ...
        ucrInputGSLMode.SetParameter(New RParameter("gsl.mode", 1))
        dctNumericPairs.Add("GSL", Chr(34) & "GSL" & Chr(34))
        dctNumericPairs.Add("GSL_first", Chr(34) & "GSL_first" & Chr(34))
        dctNumericPairs.Add("GSL_max", Chr(34) & "GSL_max" & Chr(34))
        dctNumericPairs.Add("GSL_sum", Chr(34) & "GSL_sum" & Chr(34))
        ucrInputGSLMode.SetItems(dctNumericPairs)
        ucrInputGSLMode.SetDropDownStyleAsNonEditable()
        ucrInputGSLMode.SetRDefault(Chr(34) & "GSL" & Chr(34))

        'clsPrecExceedSpecifiedA: climdex.rnnmm uses threshold = 1 as default
        ucrNudThreshold.SetParameter(New RParameter("threshold", 1))
        ucrNudThreshold.SetRDefault(1)
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.SetMinMax(0, 1)
        ucrNudThreshold.Increment = 0.01

        ucrChkMaxSpellSpanYears.SetParameter(New RParameter("spells.can.span.years", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkMaxSpellSpanYears.SetText("Maximum Spell Length Span Years")
        ' this is used in four functions, do we want to have four checkboxes or one? If four: can change it for each option, if one: cannot change it for each option

        'clsMonthlyMax5DayPrec
        ucrChkCentreMean.SetParameter(New RParameter("center.mean.on.last.day", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkCentreMean.SetText("Centre Mean on Last Day")
        ucrChkCentreMean.SetRDefault("FALSE")

        ' base
        ucrNudN.SetParameter(New RParameter("n", 8))
        ucrNudN.SetRDefault(5)
        ucrNudN.SetMinMax(1, 366)

        ucrChkNHemisphere.SetParameter(New RParameter("northern.hemisphere", 9), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkNHemisphere.SetText("Northern Hemisphere")
        ucrChkNHemisphere.SetRDefault("TRUE")

        ucrNudMinBaseData.SetParameter(New RParameter("min.base.data.fraction.present", 16))
        ucrNudMinBaseData.SetRDefault(0.1)
        ucrNudMinBaseData.DecimalPlaces = 2
        ucrNudMinBaseData.SetMinMax(0, 1)
        ucrNudMinBaseData.Increment = 0.01

        ' function within base function
        ' Maximum Missing Days
        ucrNudAnnualMissingDays.SetParameter(New RParameter("annual", 0))
        'ucrNudAnnualMissingDays.SetRDefault(15) ' This and ucrNudMonthlyMissingDays are both r-defaults, however, if you change say monthly and so that parameter runs, we get an error that it wants to see annual too. So, I've removed the r-default for now.
        ucrNudAnnualMissingDays.SetMinMax(1, 366)

        ucrNudMonthlyMissingDays.SetParameter(New RParameter("monthly", 1))
        'ucrNudMonthlyMissingDays.SetRDefault(3)
        ucrNudMonthlyMissingDays.SetMinMax(1, 31)

        ' Base Range
        ucrNudLowerBase.SetParameter(New RParameter("lower_base", 0))
        ucrNudLowerBase.SetParameterIncludeArgumentName(False)
        'ucrNudLowerBase.SetRDefault(1961)
        ucrNudLowerBase.SetMinMax(1900, 9999) ' is this right?

        ucrNudUpperBase.SetParameter(New RParameter("upper_base", 1))
        ucrNudUpperBase.SetParameterIncludeArgumentName(False)
        'ucrNudUpperBase.SetRDefault(1990)
        ucrNudUpperBase.SetMinMax(1900, 9999) ' is this right?

        ucrInputTempQtiles.SetParameter(New RParameter("x", 0))
        ucrInputTempQtiles.SetValidationTypeAsNumericList()
        ucrInputTempQtiles.AddQuotesIfUnrecognised = False
        ucrInputTempQtiles.SetParameterIncludeArgumentName(False)
        'ucrInputTempQtiles.SetRDefault("0.1, 0.9")

        ucrInputPrecQtiles.SetParameter(New RParameter("x", 0))
        ucrInputPrecQtiles.SetValidationTypeAsNumericList()
        ucrInputPrecQtiles.AddQuotesIfUnrecognised = False
        ucrInputPrecQtiles.SetParameterIncludeArgumentName(False)
        'ucrInputPrecQtiles.SetRDefault("0.95, 0.99")

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

        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRFunction As RFunction, clsRNewWriteDf As RFunction, clsRNewWriteDfIndicesList As RFunction, clsRNewMaxMissingDays As RFunction, clsRNewBaseRange As RFunction, clsRNewTempQTiles As RFunction, clsRNewPrecQTiles As RFunction, clsNewFrostDays As RFunction, clsNewSummerDays As RFunction, clsNewIcingDays As RFunction, clsNewTropicalNights As RFunction, clsNewWarmSpellDI As RFunction, clsNewColdSpellDI As RFunction, clsNewGrowingSeasonLength As RFunction, clsNewMonthlyMaxDailyTMax As RFunction, clsNewMonthlyMaxDailyTMin As RFunction, clsNewMonthlyMinDailyTMax As RFunction, clsNewMonthlyMinDailyTMin As RFunction, clsNewTminBelow10Percent As RFunction, clsNewTmaxBelow10Percent As RFunction, clsNewTminAbove90Percent As RFunction, clsNewTmaxAbove90Percent As RFunction, clsNewMeanDiurnalTempRange As RFunction, clsNewMonthlyMax1DayPrec As RFunction, clsNewMonthlyMax5DayPrec As RFunction, clsNewSimplePrecII As RFunction, clsNewPrecExceed10mm As RFunction, clsNewPrecExceed20mm As RFunction, clsNewPrecExceedSpecifiedA As RFunction, clsNewMaxDrySpell As RFunction, clsNewMaxWetSpell As RFunction, clsNewPrecExceed95Percent As RFunction, clsNewPrecExceed99Percent As RFunction, clsNewTotalDailyPrec As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsClimdexInput = clsNewRFunction
        clsRWriteDf = clsRNewWriteDf
        clsRWriteDfIndicesList = clsRNewWriteDfIndicesList
        clsRMaxMissingDays = clsRNewMaxMissingDays
        clsRBaseRange = clsRNewBaseRange
        clsRTempQTiles = clsRNewTempQTiles
        clsRPrecQTiles = clsRNewPrecQTiles
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

        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsMaxDrySpell, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=1)
        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsColdSpellDI, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=2)
        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsMaxWetSpell, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=3)

        ucrInputFreq.SetRCode(clsRWriteDf, bReset, bCloneIfNeeded:=True)

        ucrChkFrostDays.SetParameterValue(clsFrostDays)
        ucrChkFrostDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkSummerDays.SetParameterValue(clsSummerDays)
        ucrChkSummerDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkIcingDays.SetParameterValue(clsIcingDays)
        ucrChkIcingDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTropicalNights.SetParameterValue(clsTropicalNights)
        ucrChkTropicalNights.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkWarmSpellDI.SetParameterValue(clsWarmSpellDI)
        ucrChkWarmSpellDI.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)
        ucrChkMaxSpellSpanYears.SetRCode(clsWarmSpellDI, bReset, bCloneIfNeeded:=True)

        ucrChkColdSpellDI.SetParameterValue(clsColdSpellDI)
        ucrChkColdSpellDI.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkGrowingSeasonLength.SetParameterValue(clsGrowingSeasonLength)
        ucrChkGrowingSeasonLength.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)
        ucrInputGSLMode.SetRCode(clsGrowingSeasonLength, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMaxDailyTMax.SetParameterValue(clsMonthlyMaxDailyTMax)
        ucrChkMonthlyMaxDailyTMax.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMaxDailyTMin.SetParameterValue(clsMonthlyMaxDailyTMin)
        ucrChkMonthlyMaxDailyTMin.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMinDailyTMax.SetParameterValue(clsMonthlyMinDailyTMax)
        ucrChkMonthlyMinDailyTMax.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMinDailyTMin.SetParameterValue(clsMonthlyMinDailyTMin)
        ucrChkMonthlyMinDailyTMin.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTminBelow10Percent.SetParameterValue(clsTminBelow10Percent)
        ucrChkTminBelow10Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTmaxBelow10Percent.SetParameterValue(clsTmaxBelow10Percent)
        ucrChkTmaxBelow10Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTminAbove90Percent.SetParameterValue(clsTminAbove90Percent)
        ucrChkTminAbove90Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTmaxAbove90Percent.SetParameterValue(clsTmaxAbove90Percent)
        ucrChkTmaxAbove90Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMeanDiurnalTempRange.SetParameterValue(clsMeanDiurnalTempRange)
        ucrChkMeanDiurnalTempRange.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMax1dayPrec.SetParameterValue(clsMonthlyMax1DayPrec)
        ucrChkMonthlyMax1dayPrec.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMonthlyMax5dayPrec.SetParameterValue(clsMonthlyMax5DayPrec)
        ucrChkMonthlyMax5dayPrec.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)
        ucrChkCentreMean.SetRCode(clsMonthlyMax5DayPrec, bReset, bCloneIfNeeded:=True)

        ucrChkSimplePrecII.SetParameterValue(clsSimplePrecII)
        ucrChkSimplePrecII.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed10mm.SetParameterValue(clsPrecExceed10mm)
        ucrChkPrecExceed10mm.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed20mm.SetParameterValue(clsPrecExceed20mm)
        ucrChkPrecExceed20mm.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceedSpecifiedA.SetParameterValue(clsPrecExceedSpecifiedA)
        ucrChkPrecExceedSpecifiedA.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)
        ucrNudThreshold.SetRCode(clsPrecExceedSpecifiedA, bReset, bCloneIfNeeded:=True)

        ucrChkMaxDrySpell.SetParameterValue(clsMaxDrySpell)
        ucrChkMaxDrySpell.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkMaxWetSpell.SetParameterValue(clsMaxWetSpell)
        ucrChkMaxWetSpell.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed95Percent.SetParameterValue(clsPrecExceed95Percent)
        ucrChkPrecExceed95Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed99Percent.SetParameterValue(clsPrecExceed99Percent)
        ucrChkPrecExceed99Percent.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTotalDailyPrec.SetParameterValue(clsTotalDailyPrec)
        ucrChkTotalDailyPrec.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ' For base the function
        ucrChkNHemisphere.SetRCode(clsClimdexInput, bReset, bCloneIfNeeded:=True)
        ucrNudMinBaseData.SetRCode(clsClimdexInput, bReset, bCloneIfNeeded:=True)
        ucrNudN.SetRCode(clsClimdexInput, bReset, bCloneIfNeeded:=True)

        ' for parameter function in base function:
        'max.missing.days
        ucrNudAnnualMissingDays.SetRCode(clsRMaxMissingDays, bReset, bCloneIfNeeded:=True)
        ucrNudMonthlyMissingDays.SetRCode(clsRMaxMissingDays, bReset, bCloneIfNeeded:=True)

        'base.range
        ucrNudLowerBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)
        ucrNudUpperBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)

        'temp.qtiles
        ucrInputTempQtiles.SetRCode(clsRTempQTiles, bReset, bCloneIfNeeded:=True)

        'prec.qtiles
        ucrInputPrecQtiles.SetRCode(clsRPrecQTiles, bReset, bCloneIfNeeded:=True)

        IndicesType()

        If bReset Then
            tbpClimdex.SelectedIndex = 0
        End If
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
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page climdex indices generated by sub dialog Climdex Indices")
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

    Private Sub ucrInputFreq_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFreq.ControlContentsChanged
        IndicesType()
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpClimdex.TabCount - 1
            tbpClimdex.SelectedIndex = i
        Next
        ' tbpClimdex.TabPages(2).Enabled = False
        ' tbpClimdex.TabPages(1).Enabled = False
        tbpClimdex.SelectedIndex = 0
    End Sub

    Public Sub IndicesOptions(bSaveIndex As Boolean)
        'If (ucrChkFrostDays.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkFrostDays.chkCheck.Text)(1))
        '    SaveIndices(ucrChkFrostDays, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkSummerDays.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkSummerDays.chkCheck.Text)(1))
        '    SaveIndices(ucrChkSummerDays, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkIcingDays.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkIcingDays.chkCheck.Text)(1))
        '    SaveIndices(ucrChkIcingDays, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkTropicalNights.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkTropicalNights.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTropicalNights, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkGrowingSeasonLength.Checked = True) Then
        '    clsRTwoArg2.SetRCommand(dctInputindicesTriples.Item(ucrChkGrowingSeasonLength.chkCheck.Text)(1))
        '    SaveIndices(ucrChkGrowingSeasonLength, clsRTwoArg2, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMaxDailyTMax.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMaxDailyTMax.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMaxDailyTMax, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMaxDailyTMin.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMaxDailyTMin.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMaxDailyTMin, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMinDailyTMax.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMinDailyTMax.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMinDailyTMax, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMinDailyTMin.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMinDailyTMin.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMinDailyTMin, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkTminBelow10Percent.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTminBelow10Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTminBelow10Percent, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkTmaxBelow10Percent.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTmaxBelow10Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTmaxBelow10Percent, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkTminAbove90Percent.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTminAbove90Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTminAbove90Percent, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkTmaxAbove90Percent.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkTmaxAbove90Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTmaxAbove90Percent, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkWarmSpellDI.Checked = True) Then
        '    clsRTwoArg5.SetRCommand(dctInputindicesTriples.Item(ucrChkWarmSpellDI.chkCheck.Text)(1))
        '    SaveIndices(ucrChkWarmSpellDI, clsRTwoArg5, bSaveIndex)
        'End If
        'If (ucrChkColdSpellDI.Checked = True) Then
        '    clsRTwoArg5.SetRCommand(dctInputindicesTriples.Item(ucrChkColdSpellDI.chkCheck.Text)(1))
        '    SaveIndices(ucrChkColdSpellDI, clsRTwoArg5, bSaveIndex)
        'End If
        'If (ucrChkMeanDiurnalTempRange.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMeanDiurnalTempRange.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMeanDiurnalTempRange, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMax1dayPrec.Checked = True) Then
        '    clsRTwoArg1.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMax1dayPrec.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMax1dayPrec, clsRTwoArg1, bSaveIndex)
        'End If
        'If (ucrChkMonthlyMax5dayPrec.Checked = True) Then
        '    clsRThreeArg.SetRCommand(dctInputindicesTriples.Item(ucrChkMonthlyMax5dayPrec.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMonthlyMax5dayPrec, clsRThreeArg, bSaveIndex)
        'End If
        'If (ucrChkSimplePrecII.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkSimplePrecII.chkCheck.Text)(1))
        '    SaveIndices(ucrChkSimplePrecII, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkPrecExceed10mm.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed10mm.chkCheck.Text)(1))
        '    SaveIndices(ucrChkPrecExceed10mm, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkPrecExceed20mm.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed20mm.chkCheck.Text)(1))
        '    SaveIndices(ucrChkPrecExceed20mm, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkPrecExceedSpecifiedA.Checked = True) Then
        '    clsRTwoArg3.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceedSpecifiedA.chkCheck.Text)(1))
        '    SaveIndices(ucrChkPrecExceedSpecifiedA, clsRTwoArg3, bSaveIndex)
        'End If
        'If (ucrChkMaxDrySpell.Checked = True) Then
        '    clsRTwoArg4.SetRCommand(dctInputindicesTriples.Item(ucrChkMaxDrySpell.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMaxDrySpell, clsRTwoArg4, bSaveIndex)
        'End If
        'If (ucrChkMaxWetSpell.Checked = True) Then
        '    clsRTwoArg4.SetRCommand(dctInputindicesTriples.Item(ucrChkMaxWetSpell.chkCheck.Text)(1))
        '    SaveIndices(ucrChkMaxWetSpell, clsRTwoArg4, bSaveIndex)
        'End If
        'If (ucrChkPrecExceed95Percent.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed95Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkPrecExceed95Percent, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkPrecExceed99Percent.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkPrecExceed99Percent.chkCheck.Text)(1))
        '    SaveIndices(ucrChkPrecExceed99Percent, clsROneArg, bSaveIndex)
        'End If
        'If (ucrChkTotalDailyPrec.Checked = True) Then
        '    clsROneArg.SetRCommand(dctInputindicesTriples.Item(ucrChkTotalDailyPrec.chkCheck.Text)(1))
        '    SaveIndices(ucrChkTotalDailyPrec, clsROneArg, bSaveIndex)
        'End If
    End Sub
End Class