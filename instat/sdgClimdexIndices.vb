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
        Dim lstCheckboxes As New List(Of ucrCheck)
        cmdHelp.Enabled = False ' temporary

        'Annual for Max and Min Temperatures
        ucrChkFrostDays.SetParameter(New RParameter("FD", "FD", 0), bNewChangeParameterValue:=False)
        ucrChkFrostDays.SetText("Frost Days [1:FD]")

        ucrChkSummerDays.SetParameter(New RParameter("SU", "SU", 1), bNewChangeParameterValue:=False)
        ucrChkSummerDays.SetText("Summer Days [2:SU]")

        ucrChkIcingDays.SetParameter(New RParameter("ID", "Icing_Days", 2), bNewChangeParameterValue:=False)
        ucrChkIcingDays.SetText("Icing Days [3:ID]")

        ucrChkTropicalNights.SetParameter(New RParameter("TR", "Tropical_Nights", 3), bNewChangeParameterValue:=False)
        ucrChkTropicalNights.SetText("Tropical Nights [4:TR]")

        ucrChkWarmSpellDI.SetParameter(New RParameter("WSDI", "Warm_Spell_Duration_Index", 4), bNewChangeParameterValue:=False)
        ucrChkWarmSpellDI.SetText("Warm Spell Duration Index [14:WSDI]")

        ucrChkColdSpellDI.SetParameter(New RParameter("CSDI", "Cold_Spell_Duration_Index", 5), bNewChangeParameterValue:=False)
        ucrChkColdSpellDI.SetText("Cold Spell Duration Index [15:CSDI]")

        ucrChkGrowingSeasonLength.SetParameter(New RParameter("GSL", "Growing_Season_Length", 6), bNewChangeParameterValue:=False)
        ucrChkGrowingSeasonLength.SetText("Growing Season Length [5:GSL]")
        ucrChkGrowingSeasonLength.AddToLinkedControls(ucrInputGSLMode, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'climdex.gsl: used gsl.mode = ...
        ucrInputGSLMode.SetParameter(New RParameter("gsl.mode", 1))
        dctNumericPairs.Add("GSL", Chr(34) & "GSL" & Chr(34))
        dctNumericPairs.Add("GSL_first", Chr(34) & "GSL_first" & Chr(34))
        dctNumericPairs.Add("GSL_max", Chr(34) & "GSL_max" & Chr(34))
        dctNumericPairs.Add("GSL_sum", Chr(34) & "GSL_sum" & Chr(34))
        ucrInputGSLMode.SetItems(dctNumericPairs)
        ucrInputGSLMode.SetDropDownStyleAsNonEditable()
        ucrInputGSLMode.SetRDefault(Chr(34) & "GSL" & Chr(34))
        ucrInputGSLMode.SetLinkedDisplayControl(lblGSLMode)

        ' Annual/Monthly
        ucrChkMonthlyMaxDailyTMax.SetParameter(New RParameter("TXx", "Monthly_Maximum_of_Daily_Maximum_Temperature", 7), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMax.SetText("Monthly/Yearly Maximum of Daily Maximum Temperature [6:TXx]")

        ucrChkMonthlyMaxDailyTMin.SetParameter(New RParameter("TNx", "Monthly_Maximum_of_Daily_Minimum_Temperature", 8), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMin.SetText("Monthly/Yearly Maximum of Daily Minimum Temperature [7:TNx]")

        ucrChkMonthlyMinDailyTMax.SetParameter(New RParameter("TXn", "Monthly_Minimum_of_Daily_Maximum_Temperature", 9), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMax.SetText("Monthly/Yearly Minimum of Daily Maximum Temperature [8:TXn]")

        ucrChkMonthlyMinDailyTMin.SetParameter(New RParameter("TNn", "Monthly_Minimum_of_Daily_Minimum_Temperature", 10), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMin.SetText("Monthly/Yearly Minimum of Daily Minimum Temperature [9:TNn]")

        ucrChkTminBelow10Percent.SetParameter(New RParameter("TN10p", "Percentage_of_Days_When_Tmin_is_Below_10th_Percentile", 11), bNewChangeParameterValue:=False)
        ucrChkTminBelow10Percent.SetText("Percentage of Days When Tmin is Below 10th Percentile [10:TN10p]")

        ucrChkTmaxBelow10Percent.SetParameter(New RParameter("TX10p", "Percentage_of_Days_When_Tmax_is_Below_10th_Percentile", 12), bNewChangeParameterValue:=False)
        ucrChkTmaxBelow10Percent.SetText("Percentage of Days When Tmax is Below 10th Percentile [11:TX10p]")

        ucrChkTminAbove90Percent.SetParameter(New RParameter("TN90p", "Percentage_of_Days_When_Tmin_is_Above_90th_Percentile", 13), bNewChangeParameterValue:=False)
        ucrChkTminAbove90Percent.SetText("Percentage of Days When Tmin is Above 90th Percentile [12:TN90p]")

        ucrChkTmaxAbove90Percent.SetParameter(New RParameter("TX90p", "Percentage_of_Days_When_Tmax_is_Above_90th_Percentile", 14), bNewChangeParameterValue:=False)
        ucrChkTmaxAbove90Percent.SetText("Percentage of Days When Tmax is Above 90th Percentile [13:TX90p]")

        ucrChkMeanDiurnalTempRange.SetParameter(New RParameter("DTR", "Mean_Diurnal_Temperature_Range", 15), bNewChangeParameterValue:=False)
        ucrChkMeanDiurnalTempRange.SetText("Mean Diurnal Temperature Range [16:DTR]")

        ' Precipitation tab:
        ucrChkMonthlyMax1dayPrec.SetParameter(New RParameter("Rx1day", "Monthly_Maximum_1day_Precipitation", 16), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax1dayPrec.SetText("Monthly/Yearly Maximum 1-day Precipitation [17:Rx1day]")

        ucrChkMonthlyMax5dayPrec.SetParameter(New RParameter("Rx5day", "Monthly_Maximum_5day_Precipitation", 17), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax5dayPrec.SetText("Monthly/Yearly Maximum Consecutive 5-day Precipitation [18:Rx5day]")
        ucrChkMonthlyMax5dayPrec.AddToLinkedControls(ucrChkCentreMean, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkCentreMean.SetParameter(New RParameter("center.mean.on.last.day", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkCentreMean.SetText("Centre Mean on Last Day")
        ucrChkCentreMean.SetRDefault("FALSE")

        ucrChkSimplePrecII.SetParameter(New RParameter("SDII", "Simple_Precipitation_Intensity_Index", 18), bNewChangeParameterValue:=False)
        ucrChkSimplePrecII.SetText("Simple Precipitation Intensity Index [19:SDII]")

        ucrChkPrecExceed10mm.SetParameter(New RParameter("R10mm", "Precipitation_Exceeding_10mm_Per_Day", 19), bNewChangeParameterValue:=False)
        ucrChkPrecExceed10mm.SetText("Precipitation >= 10mm Per Day [20:R10mm]")

        ucrChkPrecExceed20mm.SetParameter(New RParameter("R20mm", "Precipitation_Exceeding_20mm_Per_Day", 20), bNewChangeParameterValue:=False)
        ucrChkPrecExceed20mm.SetText("Precipitation >= 20mm Per Day [21:R20mm]")

        ucrChkPrecExceedSpecifiedA.SetParameter(New RParameter("Rnnmm", "Precipitation_Exceeding_a_Specified_Amount_Per_Day", 21), bNewChangeParameterValue:=False)
        ucrChkPrecExceedSpecifiedA.SetText("Precipitation >= a Specified Amount Per Day [22:Rnnmm]")
        ucrChkPrecExceedSpecifiedA.AddToLinkedControls(ucrInputThreshold, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputThreshold.SetParameter(New RParameter("threshold", 1))
        ucrInputThreshold.SetRDefault(1)
        ucrInputThreshold.SetValidationTypeAsNumeric()
        ucrInputThreshold.AddQuotesIfUnrecognised = False
        ucrInputThreshold.SetLinkedDisplayControl(lblThreshold)

        ucrChkMaxDrySpell.SetParameter(New RParameter("CDD", "Maximum_Length_of_Dry_Spell", 22), bNewChangeParameterValue:=False)
        ucrChkMaxDrySpell.SetText("Maximum Length of Dry Spell [23:CDD]")

        ucrChkMaxWetSpell.SetParameter(New RParameter("CWD", "Maximum_Length_of_Wet_Spell", 23), bNewChangeParameterValue:=False)
        ucrChkMaxWetSpell.SetText("Maximum Length of Wet Spell [24:CWD]")

        ucrChkPrecExceed95Percent.SetParameter(New RParameter("R95p", "Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold", 24), bNewChangeParameterValue:=False)
        ucrChkPrecExceed95Percent.SetText("Total Daily Precipitation Exceeding 95th Percentile Threshold [25:R95p]")

        ucrChkPrecExceed99Percent.SetParameter(New RParameter("R99p", "Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold", 25), bNewChangeParameterValue:=False)
        ucrChkPrecExceed99Percent.SetText("Total Daily Precipitation Exceeding 99th Percentile Threshold [26:R99p]")

        ucrChkTotalDailyPrec.SetParameter(New RParameter("PRCPTOT", "Total_Daily_Precipitation", 26), bNewChangeParameterValue:=False)
        ucrChkTotalDailyPrec.SetText("Total Daily Precipitation [27:PRCPTOT]")

        lstCheckboxes = New List(Of ucrCheck)
        lstCheckboxes.AddRange({ucrChkFrostDays, ucrChkSummerDays, ucrChkIcingDays, ucrChkTropicalNights, ucrChkWarmSpellDI, ucrChkColdSpellDI, ucrChkGrowingSeasonLength, ucrChkMonthlyMaxDailyTMax, ucrChkMonthlyMaxDailyTMin, ucrChkMonthlyMinDailyTMax, ucrChkMonthlyMinDailyTMin, ucrChkTminBelow10Percent, ucrChkTmaxBelow10Percent, ucrChkTminAbove90Percent, ucrChkTmaxAbove90Percent, ucrChkMeanDiurnalTempRange, ucrChkMonthlyMax1dayPrec, ucrChkMonthlyMax5dayPrec, ucrChkSimplePrecII, ucrChkPrecExceed10mm, ucrChkPrecExceed20mm, ucrChkPrecExceedSpecifiedA, ucrChkMaxDrySpell, ucrChkMaxWetSpell, ucrChkPrecExceed95Percent, ucrChkPrecExceed99Percent, ucrChkTotalDailyPrec})

        For Each ucrChk As ucrCheck In lstCheckboxes
            ucrChk.AddParameterPresentCondition(True, ucrChk.GetParameterName, True)
            ucrChk.AddParameterPresentCondition(False, ucrChk.GetParameterName, False)
        Next

        ucrChkMaxSpellSpanYears.SetParameter(New RParameter("spells.can.span.years", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkMaxSpellSpanYears.SetText("Maximum Spell Length Span Years")
        ' this is used in four functions, do we want to have four checkboxes or one? If four: can change it for each option, if one: cannot change it for each option

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

        'bCloneIfNeeded:=False for climdex functions which have a parameter (excluding ci)
        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsMaxDrySpell, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=1)
        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsColdSpellDI, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=2)
        ucrChkMaxSpellSpanYears.AddAdditionalCodeParameterPair(clsMaxWetSpell, New RParameter("spells.can.span.years", 1), iAdditionalPairNo:=3)

        ucrChkFrostDays.SetParameterValue(clsFrostDays)
        ucrChkFrostDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkSummerDays.SetParameterValue(clsSummerDays)
        ucrChkSummerDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkIcingDays.SetParameterValue(clsIcingDays)
        ucrChkIcingDays.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkTropicalNights.SetParameterValue(clsTropicalNights)
        ucrChkTropicalNights.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkWarmSpellDI.SetParameterValue(clsWarmSpellDI)
        ucrChkWarmSpellDI.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)
        ucrChkMaxSpellSpanYears.SetRCode(clsWarmSpellDI, bReset, bCloneIfNeeded:=True)

        ucrChkColdSpellDI.SetParameterValue(clsColdSpellDI)
        ucrChkColdSpellDI.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)

        ucrChkGrowingSeasonLength.SetParameterValue(clsGrowingSeasonLength)
        ucrChkGrowingSeasonLength.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)
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
        ucrChkMonthlyMax5dayPrec.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)
        ucrChkCentreMean.SetRCode(clsMonthlyMax5DayPrec, bReset, bCloneIfNeeded:=True)

        ucrChkSimplePrecII.SetParameterValue(clsSimplePrecII)
        ucrChkSimplePrecII.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed10mm.SetParameterValue(clsPrecExceed10mm)
        ucrChkPrecExceed10mm.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceed20mm.SetParameterValue(clsPrecExceed20mm)
        ucrChkPrecExceed20mm.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=True)

        ucrChkPrecExceedSpecifiedA.SetParameterValue(clsPrecExceedSpecifiedA)
        ucrChkPrecExceedSpecifiedA.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)
        ucrInputThreshold.SetRCode(clsPrecExceedSpecifiedA, bReset, bCloneIfNeeded:=True)

        ucrChkMaxDrySpell.SetParameterValue(clsMaxDrySpell)
        ucrChkMaxDrySpell.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)

        ucrChkMaxWetSpell.SetParameterValue(clsMaxWetSpell)
        ucrChkMaxWetSpell.SetRCode(clsRWriteDfIndicesList, bReset, bCloneIfNeeded:=False)

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
        If bReset Then
            tbpClimdex.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        'IndicesHelp()
    End Sub

    'Private Sub IndicesHelp()
    '    Dim clsHelp As New RFunction
    '    clsHelp.SetRCommand("help")
    '    clsHelp.AddParameter("package", Chr(34) & "climdex.pcic" & Chr(34))
    '    If IndicesCount = 1 Then
    '        clsHelp.AddParameter("topic", Chr(34) & CheckedBoxFunction() & Chr(34))
    '    Else
    '        clsHelp.RemoveParameterByName("topic")
    '    End If
    '    clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
    '    frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page climdex indices generated by sub dialog Climdex Indices")
    'End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpClimdex.TabCount - 1
            tbpClimdex.SelectedIndex = i
        Next
        ' tbpClimdex.TabPages(2).Enabled = False
        ' tbpClimdex.TabPages(1).Enabled = False
        tbpClimdex.SelectedIndex = 0
    End Sub
End Class