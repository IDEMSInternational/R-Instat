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
    Private clsClimdex As New RFunction
    Public clsIndices As New RFunction
    Private clsMaxMissingDays, clsRBaseRange, clsTempQTiles, clsPrecQTiles As New RFunction
    Private lstGroupboxes As List(Of GroupBox)

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
        ucrChkFrostDays.SetParameter(New RParameter("fd", Chr(34) & "fd" & Chr(34), iNewPosition:=0, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkFrostDays.SetText("Frost Days [1:FD]")

        ucrChkSummerDays.SetParameter(New RParameter("su", Chr(34) & "su" & Chr(34), iNewPosition:=1, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkSummerDays.SetText("Summer Days [2:SU]")

        ucrChkIcingDays.SetParameter(New RParameter("id", Chr(34) & "id" & Chr(34), iNewPosition:=2, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkIcingDays.SetText("Icing Days [3:ID]")

        ucrChkTropicalNights.SetParameter(New RParameter("tr", Chr(34) & "tr" & Chr(34), iNewPosition:=3, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTropicalNights.SetText("Tropical Nights [4:TR]")

        ucrChkWarmSpellDI.SetParameter(New RParameter("wsdi", Chr(34) & "wsdi" & Chr(34), iNewPosition:=4, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkWarmSpellDI.SetText("Warm Spell Duration Index [14:WSDI]")

        ucrChkColdSpellDI.SetParameter(New RParameter("csdi", Chr(34) & "csdi" & Chr(34), iNewPosition:=5, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkColdSpellDI.SetText("Cold Spell Duration Index [15:CSDI]")

        ucrChkGrowingSeasonLength.SetParameter(New RParameter("gsl", Chr(34) & "gsl" & Chr(34), iNewPosition:=6, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkGrowingSeasonLength.SetText("Growing Season Length [5:GSL]")
        ucrChkGrowingSeasonLength.AddToLinkedControls(ucrInputGSLMode, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Normal")

        dctNumericPairs.Add("Normal", Chr(34) & "GSL" & Chr(34))
        dctNumericPairs.Add("First", Chr(34) & "GSL_first" & Chr(34))
        dctNumericPairs.Add("Max", Chr(34) & "GSL_max" & Chr(34))
        dctNumericPairs.Add("Sum", Chr(34) & "GSL_sum" & Chr(34))

        'climdex.gsl
        ucrInputGSLMode.SetParameter(New RParameter("gsl.mode", 1))
        ucrInputGSLMode.SetItems(dctNumericPairs)
        ucrInputGSLMode.SetDropDownStyleAsNonEditable()
        ucrInputGSLMode.SetRDefault(Chr(34) & "Normal" & Chr(34))
        ucrInputGSLMode.SetLinkedDisplayControl(lblGSLMethod)

        ' Annual/Monthly
        ucrChkMonthlyMaxDailyTMax.SetParameter(New RParameter("txx", Chr(34) & "txx" & Chr(34), iNewPosition:=7, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMax.SetText("Monthly/Yearly Maximum of Daily Maximum Temperature [6:TXx]")

        ucrChkMonthlyMaxDailyTMin.SetParameter(New RParameter("tnx", Chr(34) & "tnx" & Chr(34), iNewPosition:=8, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMaxDailyTMin.SetText("Monthly/Yearly Maximum of Daily Minimum Temperature [7:TNx]")

        ucrChkMonthlyMinDailyTMax.SetParameter(New RParameter("txn", Chr(34) & "txn" & Chr(34), iNewPosition:=9, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMax.SetText("Monthly/Yearly Minimum of Daily Maximum Temperature [8:TXn]")

        ucrChkMonthlyMinDailyTMin.SetParameter(New RParameter("tnn", Chr(34) & "tnn" & Chr(34), iNewPosition:=10, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMinDailyTMin.SetText("Monthly/Yearly Minimum of Daily Minimum Temperature [9:TNn]")

        ucrChkTminBelow10Percent.SetParameter(New RParameter("tn10p", Chr(34) & "tn10p" & Chr(34), iNewPosition:=11, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTminBelow10Percent.SetText("Percentage of Days When Tmin is Below 10th Percentile [10:TN10p]")

        ucrChkTmaxBelow10Percent.SetParameter(New RParameter("tx10p", Chr(34) & "tx10p" & Chr(34), iNewPosition:=12, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTmaxBelow10Percent.SetText("Percentage of Days When Tmax is Below 10th Percentile [11:TX10p]")

        ucrChkTminAbove90Percent.SetParameter(New RParameter("tn90p", Chr(34) & "tn90p" & Chr(34), iNewPosition:=13, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTminAbove90Percent.SetText("Percentage of Days When Tmin is Above 90th Percentile [12:TN90p]")

        ucrChkTmaxAbove90Percent.SetParameter(New RParameter("tx90p", Chr(34) & "tx90p" & Chr(34), iNewPosition:=14, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTmaxAbove90Percent.SetText("Percentage of Days When Tmax is Above 90th Percentile [13:TX90p]")

        ucrChkMeanDiurnalTempRange.SetParameter(New RParameter("dtr", Chr(34) & "dtr" & Chr(34), iNewPosition:=15, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMeanDiurnalTempRange.SetText("Mean Diurnal Temperature Range [16:DTR]")

        ' Precipitation tab:
        ucrChkMonthlyMax1dayPrec.SetParameter(New RParameter("rx1day", Chr(34) & "rx1day" & Chr(34), iNewPosition:=16, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax1dayPrec.SetText("Monthly/Yearly Maximum 1-day Precipitation [17:Rx1day]")

        ucrChkMonthlyMax5dayPrec.SetParameter(New RParameter("rx5day", Chr(34) & "rx5day" & Chr(34), iNewPosition:=17, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMonthlyMax5dayPrec.SetText("Monthly/Yearly Maximum Consecutive 5-day Precipitation [18:Rx5day]")
        ucrChkMonthlyMax5dayPrec.AddToLinkedControls(ucrChkCentreMean, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkCentreMean.SetParameter(New RParameter("center.mean.on.last.day", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True)
        ucrChkCentreMean.SetText("Centre Mean on Last Day")
        ucrChkCentreMean.SetRDefault("FALSE")

        ucrChkSimplePrecII.SetParameter(New RParameter("sdii", Chr(34) & "sdii" & Chr(34), iNewPosition:=18, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkSimplePrecII.SetText("Simple Precipitation Intensity Index [19:SDII]")

        ucrChkPrecExceed10mm.SetParameter(New RParameter("r10mm", Chr(34) & "r10mm" & Chr(34), iNewPosition:=19, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed10mm.SetText("Precipitation >= 10mm Per Day [20:R10mm]")

        ucrChkPrecExceed20mm.SetParameter(New RParameter("r20mm", Chr(34) & "r20mm" & Chr(34), iNewPosition:=20, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed20mm.SetText("Precipitation >= 20mm Per Day [21:R20mm]")

        ucrChkPrecExceedSpecifiedA.SetParameter(New RParameter("rnnmm", Chr(34) & "rnnmm" & Chr(34), iNewPosition:=21, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkPrecExceedSpecifiedA.SetText("Precipitation >= a Specified Amount Per Day [22:Rnnmm]")
        ucrChkPrecExceedSpecifiedA.AddToLinkedControls(ucrInputThreshold, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrInputThreshold.SetParameter(New RParameter("threshold", 1))
        ucrInputThreshold.SetRDefault(1)
        ucrInputThreshold.SetValidationTypeAsNumeric()
        ucrInputThreshold.AddQuotesIfUnrecognised = False
        ucrInputThreshold.SetLinkedDisplayControl(lblThreshold)

        ucrChkMaxDrySpell.SetParameter(New RParameter("cdd", Chr(34) & "cdd" & Chr(34), iNewPosition:=22, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMaxDrySpell.SetText("Maximum Length of Dry Spell [23:CDD]")

        ucrChkMaxWetSpell.SetParameter(New RParameter("cwd", Chr(34) & "cwd" & Chr(34), iNewPosition:=23, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkMaxWetSpell.SetText("Maximum Length of Wet Spell [24:CWD]")

        ucrChkPrecExceed95Percent.SetParameter(New RParameter("r95ptot", Chr(34) & "r95ptot" & Chr(34), iNewPosition:=24, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed95Percent.SetText("Total Daily Precipitation Exceeding 95th Percentile Threshold [25:R95pTOT]")

        ucrChkPrecExceed99Percent.SetParameter(New RParameter("r99ptot", Chr(34) & "r99ptot" & Chr(34), iNewPosition:=25, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkPrecExceed99Percent.SetText("Total Daily Precipitation Exceeding 99th Percentile Threshold [26:R99pTOT]")

        ucrChkTotalDailyPrec.SetParameter(New RParameter("prcptot", Chr(34) & "prcptot" & Chr(34), iNewPosition:=26, bNewIncludeArgumentName:=False), bNewChangeParameterValue:=False)
        ucrChkTotalDailyPrec.SetText("Total Daily Precipitation [27:PRCPTOT]")

        lstCheckboxes = New List(Of ucrCheck)
        lstCheckboxes.AddRange({ucrChkFrostDays, ucrChkSummerDays, ucrChkIcingDays, ucrChkTropicalNights, ucrChkWarmSpellDI, ucrChkColdSpellDI, ucrChkGrowingSeasonLength, ucrChkMonthlyMaxDailyTMax, ucrChkMonthlyMaxDailyTMin, ucrChkMonthlyMinDailyTMax, ucrChkMonthlyMinDailyTMin, ucrChkTminBelow10Percent, ucrChkTmaxBelow10Percent, ucrChkTminAbove90Percent, ucrChkTmaxAbove90Percent, ucrChkMeanDiurnalTempRange, ucrChkMonthlyMax1dayPrec, ucrChkMonthlyMax5dayPrec, ucrChkSimplePrecII, ucrChkPrecExceed10mm, ucrChkPrecExceed20mm, ucrChkPrecExceedSpecifiedA, ucrChkMaxDrySpell, ucrChkMaxWetSpell, ucrChkPrecExceed95Percent, ucrChkPrecExceed99Percent, ucrChkTotalDailyPrec})

        For Each ucrChk As ucrCheck In lstCheckboxes
            ucrChk.AddParameterPresentCondition(True, ucrChk.GetParameterName, True)
            ucrChk.AddParameterPresentCondition(False, ucrChk.GetParameterName, False)
        Next

        ucrChkMaxSpellSpanYears.SetParameter(New RParameter("spells.can.span.years", iNewPosition:=17), bNewChangeParameterValue:=True)
        ucrChkMaxSpellSpanYears.SetText("Spell Can Span Years")
        ucrChkMaxSpellSpanYears.SetRDefault("FALSE")

        ucrNudN.SetParameter(New RParameter("n", 10))
        ucrNudN.SetRDefault(5)
        ucrNudN.SetMinMax(1, 366)

        ucrChkNHemisphere.SetParameter(New RParameter("northern.hemisphere", 9), bNewChangeParameterValue:=True)
        ucrChkNHemisphere.SetText("Northern Hemisphere")
        ucrChkNHemisphere.SetRDefault("TRUE")

        ucrNudMinBaseData.SetParameter(New RParameter("min.base.data.fraction.present", 16))
        ucrNudMinBaseData.SetRDefault(0.1)
        ucrNudMinBaseData.DecimalPlaces = 2
        ucrNudMinBaseData.SetMinMax(0, 1)
        ucrNudMinBaseData.Increment = 0.01

        ' Maximum Missing Days
        ucrNudAnnualMissingDays.SetParameter(New RParameter("annual", 0))
        ucrNudAnnualMissingDays.SetMinMax(0, 366)

        ucrNudMonthlyMissingDays.SetParameter(New RParameter("monthly", 1))
        ucrNudMonthlyMissingDays.SetMinMax(0, 31)

        ' Base Range
        ucrNudLowerBase.SetParameter(New RParameter("0", 0))
        ucrNudLowerBase.SetParameterIncludeArgumentName(False)
        ucrNudLowerBase.SetMinMax(1900, 2100)

        ucrNudUpperBase.SetParameter(New RParameter("1", 1))
        ucrNudUpperBase.SetParameterIncludeArgumentName(False)
        ucrNudUpperBase.SetMinMax(1900, 2100)

        ucrInputTempQtiles.SetParameter(New RParameter("0", 0))
        ucrInputTempQtiles.SetValidationTypeAsNumericList()
        ucrInputTempQtiles.AddQuotesIfUnrecognised = False
        ucrInputTempQtiles.SetParameterIncludeArgumentName(False)

        ucrInputPrecQtiles.SetParameter(New RParameter("0", 0))
        ucrInputPrecQtiles.SetValidationTypeAsNumericList()
        ucrInputPrecQtiles.AddQuotesIfUnrecognised = False
        ucrInputPrecQtiles.SetParameterIncludeArgumentName(False)

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

    Public Sub SetRCode(clsNewClimdex As RFunction, clsNewIndices As RFunction, clsNewMaxMissingDays As RFunction, clsNewBaseRange As RFunction, clsNewTempQTiles As RFunction, clsNewPrecQTiles As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsClimdex = clsNewClimdex
        clsIndices = clsNewIndices
        clsMaxMissingDays = clsNewMaxMissingDays
        clsRBaseRange = clsNewBaseRange
        clsTempQTiles = clsNewTempQTiles
        clsPrecQTiles = clsNewPrecQTiles

        ucrChkMaxSpellSpanYears.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)

        ucrChkFrostDays.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkSummerDays.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkIcingDays.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTropicalNights.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkWarmSpellDI.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkColdSpellDI.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkGrowingSeasonLength.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkMonthlyMaxDailyTMax.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMaxDailyTMin.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMinDailyTMax.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMinDailyTMin.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTminBelow10Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTmaxBelow10Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTminAbove90Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTmaxAbove90Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMeanDiurnalTempRange.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMax1dayPrec.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkMonthlyMax5dayPrec.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkSimplePrecII.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed10mm.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed20mm.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceedSpecifiedA.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkMaxDrySpell.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkMaxWetSpell.SetRCode(clsIndices, bReset, bCloneIfNeeded:=False)
        ucrChkPrecExceed95Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkPrecExceed99Percent.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)
        ucrChkTotalDailyPrec.SetRCode(clsIndices, bReset, bCloneIfNeeded:=True)

        ' For climdex the function
        ucrChkNHemisphere.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)
        ucrNudMinBaseData.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)
        ucrNudN.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)
        ucrInputGSLMode.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)
        ucrInputThreshold.SetRCode(clsClimdex, bReset, bCloneIfNeeded:=True)

        ' for parameter function in climdex function:
        'max.missing.days
        ucrNudAnnualMissingDays.SetRCode(clsMaxMissingDays, bReset, bCloneIfNeeded:=True)
        ucrNudMonthlyMissingDays.SetRCode(clsMaxMissingDays, bReset, bCloneIfNeeded:=True)

        'base.range
        ucrNudLowerBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)
        ucrNudUpperBase.SetRCode(clsRBaseRange, bReset, bCloneIfNeeded:=True)

        'temp.qtiles
        ucrInputTempQtiles.SetRCode(clsTempQTiles, bReset, bCloneIfNeeded:=True)

        'prec.qtiles
        ucrInputPrecQtiles.SetRCode(clsPrecQTiles, bReset, bCloneIfNeeded:=True)

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
        tbpClimdex.SelectedIndex = 0
    End Sub
End Class