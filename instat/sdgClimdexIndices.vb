' Instat-R
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
Imports instat
Imports instat.Translations
Public Class sdgClimdexIndices
    Public bControlsInitialised As Boolean = False
    Public clsNewClimdexInput As New RFunction
    Public clsRMaxMisingDays, clsROneArg, clsRTwoArg1, clsRTwoArg2, clsRTwoArg3, clsRTwoArg4, clsRTwoArg5, clsRThreeArg As New RFunction

    Private Sub chkGrowingSeasonLength_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub sdgClimdexIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctInputFreqPairs As New Dictionary(Of String, String)
        clsRMaxMisingDays.SetRCommand("c")
        ucrChkFrostDays.Checked = True
        ucrChkFrostDays.SetText("Frost Days")
        ucrChkFrostDays.bChangeParameterValue = False
        ucrChkSummerDays.Checked = False
        ucrChkSummerDays.SetText("Summer Days")
        ucrChkSummerDays.bChangeParameterValue = False
        ucrChkIcingDays.Checked = False
        ucrChkIcingDays.SetText("Icing Days")
        ucrChkIcingDays.bChangeParameterValue = False
        ucrChkTropicalNights.Checked = False
        ucrChkTropicalNights.SetText("Tropical Nights")
        ucrChkTropicalNights.bChangeParameterValue = False
        ucrChkGrowingSeasonLength.Checked = False
        ucrChkGrowingSeasonLength.SetText("Growing Season Length")
        ucrChkGrowingSeasonLength.bChangeParameterValue = False
        ucrChkMonthlyMaxDailyTMax.Checked = False
        ucrChkMonthlyMaxDailyTMax.SetText("Monthly Maximum of Daily Maximum Temperature")
        ucrChkMonthlyMaxDailyTMax.bChangeParameterValue = False
        ucrChkMonthlyMaxDailyTMin.Checked = False
        ucrChkMonthlyMaxDailyTMin.SetText("Monthly Maximum of Daily Minimum Temperature")
        ucrChkMonthlyMaxDailyTMin.bChangeParameterValue = False
        ucrChkMonthlyMinDailyTMax.Checked = False
        ucrChkMonthlyMinDailyTMax.SetText("Monthly Minimum of Daily Maximum Temperature")
        ucrChkMonthlyMinDailyTMax.bChangeParameterValue = False
        ucrChkMonthlyMinDailyTMin.Checked = False
        ucrChkMonthlyMinDailyTMin.SetText("Monthly Minimum of Daily Minimum Temperature")
        ucrChkMonthlyMinDailyTMin.bChangeParameterValue = False
        ucrChkTminBelow10Percent.Checked = False
        ucrChkTminBelow10Percent.SetText("Percentage of Days When Tmin is Below 10th Percentile")
        ucrChkTminBelow10Percent.bChangeParameterValue = False
        ucrChkTmaxBelow10Percent.Checked = False
        ucrChkTmaxBelow10Percent.SetText("Percentage of Days When Tmax is Below 10th Percentile ")
        ucrChkTmaxBelow10Percent.bChangeParameterValue = False
        ucrChkTminAbove90Percent.Checked = False
        ucrChkTminAbove90Percent.SetText("Percentage of Days When Tmin is Above 90th Percentile ")
        ucrChkTminAbove90Percent.bChangeParameterValue = False
        ucrChkTmaxAbove90Percent.Checked = False
        ucrChkTmaxAbove90Percent.SetText("Percentage of Days When Tmax is Above 90th Percentile")
        ucrChkTmaxAbove90Percent.bChangeParameterValue = False
        ucrChkWarmSpellDI.Checked = False
        ucrChkWarmSpellDI.SetText("Warm Spell Duration Index ")
        ucrChkWarmSpellDI.bChangeParameterValue = False
        ucrChkColdSpellDI.Checked = False
        ucrChkColdSpellDI.SetText("Cold Spell Duration Index")
        ucrChkColdSpellDI.bChangeParameterValue = False
        ucrChkMeanDiurnalTempRange.Checked = False
        ucrChkMeanDiurnalTempRange.SetText("Mean Diurnal Temperature Range")
        ucrChkMeanDiurnalTempRange.bChangeParameterValue = False
        ucrChkMonthlyMax1dayPrec.Checked = False
        ucrChkMonthlyMax1dayPrec.SetText("Monthly Maximum 1-day Precipitation ")
        ucrChkMonthlyMax1dayPrec.bChangeParameterValue = False
        ucrChkMonthlyMax5dayPrec.Checked = False
        ucrChkMonthlyMax5dayPrec.SetText("Monthly Maximum Consecutive 5-day Precipitation ")
        ucrChkMonthlyMax5dayPrec.bChangeParameterValue = False
        ucrChkSimplePrecII.Checked = False
        ucrChkSimplePrecII.SetText("Simple Precipitation Intensity Index")
        ucrChkSimplePrecII.bChangeParameterValue = False
        ucrChkPrecExceed10mm.Checked = False
        ucrChkPrecExceed10mm.SetText("Precipitation Exceeding 10mm Per Day ")
        ucrChkPrecExceed10mm.bChangeParameterValue = False
        ucrChkPrecExceed20mm.Checked = False
        ucrChkPrecExceed20mm.SetText("Precipitation Exceeding 20mm Per Day ")
        ucrChkPrecExceed20mm.bChangeParameterValue = False
        ucrChkPrecExceedSpecifiedA.Checked = False
        ucrChkPrecExceedSpecifiedA.SetText("Precipitation Exceeding  a Specified Amount Per Day")
        ucrChkPrecExceedSpecifiedA.bChangeParameterValue = False
        ucrChkMaxDrySpell.Checked = False
        ucrChkMaxDrySpell.SetText("Maximum Length of Dry Spell ")
        ucrChkMaxDrySpell.bChangeParameterValue = False
        ucrChkMaxWetSpell.Checked = False
        ucrChkMaxWetSpell.SetText("Maximum Length of Wet Spell ")
        ucrChkMaxWetSpell.bChangeParameterValue = False
        ucrChkPrecExceed95Percent.Checked = False
        ucrChkPrecExceed95Percent.SetText("Total Daily Precipitation Exceeding 95th Percentile Threshold")
        ucrChkPrecExceed95Percent.bChangeParameterValue = False
        ucrChkPrecExceed99Percent.Checked = False
        ucrChkPrecExceed99Percent.SetText("Total Daily Precipitation Exceeding 99th Percentile Threshold ")
        ucrChkPrecExceed99Percent.bChangeParameterValue = False
        ucrChkTotalDailyPrec.Checked = False
        ucrChkTotalDailyPrec.SetText("Total Daily Precipitation")
        ucrChkTotalDailyPrec.bChangeParameterValue = False

        ucrNudThreshold.SetParameter(New RParameter("threshold"))
        ucrNudThreshold.SetRDefault(1)
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.SetMinMax(0, 1)
        ucrNudN.SetParameter(New RParameter("n"))
        ucrNudN.SetRDefault(5)
        ucrNudN.SetMinMax(1, 100)

        ucrNudMinBaseData.SetParameter(New RParameter("min.base.data.fraction.present"))
        ucrNudMinBaseData.SetRDefault(0.1)
        ucrNudMinBaseData.DecimalPlaces = 2
        ucrNudMinBaseData.SetMinMax(0, 1)


        ucrNudAnnualMissingDays.SetParameter(New RParameter("annual"))
        ucrNudAnnualMissingDays.SetRDefault(15)
        ucrNudAnnualMissingDays.SetMinMax(1, 366)

        ucrNudMothlyMissingDays.SetParameter(New RParameter("monthly"))
        ucrNudMothlyMissingDays.SetRDefault(3)
        ucrNudMothlyMissingDays.SetMinMax(1, 31)

        clsNewClimdexInput.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        ucrInputFreq.SetParameter(New RParameter("freq"))
        dctInputFreqPairs.Add("annual", Chr(34) & "annual" & Chr(34))
        dctInputFreqPairs.Add("monthly", Chr(34) & "monthly" & Chr(34))
        ucrInputFreq.SetItems(dctInputFreqPairs)
        ucrInputFreq.cboInput.SelectedItem = "annual"

        ucrMultipleInputTempQtiles.SetParameter(New RParameter("temp.qtiles"))
        ucrMultipleInputTempQtiles.bIsNumericInput = True
        ucrMultipleInputTempQtiles.txtNumericItems.Text = "0.1, 0.9"
        ucrMultipleInputTempQtiles.SetRDefault("0.1, 0.9")

        ucrMultipleInputPrecQtiles.SetParameter(New RParameter("prec.qtiles"))
        ucrMultipleInputPrecQtiles.bIsNumericInput = True
        ucrMultipleInputPrecQtiles.txtNumericItems.Text = "0.95, 0.99"
        ucrMultipleInputPrecQtiles.SetRDefault("0.95, 0.99")

        ucrMultipleInputBaseRange.SetParameter(New RParameter("base.range"))
        ucrMultipleInputBaseRange.bIsNumericInput = True
        ucrMultipleInputBaseRange.txtNumericItems.Text = "1961, 1990"
        ucrMultipleInputBaseRange.SetRDefault("1961, 1990")
        ucrChkNHemisphere.SetText("Northern Hemisphere")
        ucrChkNHemisphere.SetParameter(New RParameter("northern.hemisphere"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkNHemisphere.SetRDefault("TRUE")

        ucrChkCenterMean.SetText("Center Mean on Last Day")
        ucrChkCenterMean.SetParameter(New RParameter("center.mean.on.last.day"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCenterMean.SetRDefault("FALSE")

        ucrChkMaxSpellSpanYears.SetText("Maximum Spell Length Span Years")
        ucrChkMaxSpellSpanYears.SetParameter(New RParameter("spells.can.span.years"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMaxSpellSpanYears.SetRDefault("TRUE")

        ucrChkSpellDISpanYear.SetText("Spell Duration Index Span Years")
        ucrChkSpellDISpanYear.SetParameter(New RParameter("spells.can.span.years"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkSpellDISpanYear.SetRDefault("FALSE")

        ttClimdexIndices.SetToolTip(ucrChkFrostDays.chkCheck, "The annual count of days where daily minimum temperature drops below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkSummerDays.chkCheck, "The annual count of days where daily maximum temperature exceeds 25 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkIcingDays.chkCheck, "The annual count of days where daily maximum temperature is below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(ucrChkTropicalNights.chkCheck, "Annual count of days where daily minimum temperature stays above 20 degrees Celsius. ")
        ttClimdexIndices.SetToolTip(ucrChkGrowingSeasonLength.chkCheck, "Is the number of days between the start of the first spell of warm days in the first half of the year, and the start of the first spell of cold days in the second half of the year")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMaxDailyTMax.chkCheck, "Computes the monthly or annual maximum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMaxDailyTMin.chkCheck, "Computes the monthly or annual maximum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMinDailyTMax.chkCheck, "Computes the monthly or annual minimum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMinDailyTMin.chkCheck, "Computes the monthly or annual minimum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(ucrChkTminBelow10Percent.chkCheck, "Computes  the monthly or annual proportion of minimum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTmaxBelow10Percent.chkCheck, "Computes  the monthly or annual proportion of maximum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTminAbove90Percent.chkCheck, "Computes  the monthly or annual proportion of minimum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(ucrChkTmaxAbove90Percent.chkCheck, "Computes  the monthly or annual proportion of maximum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(ucrChkWarmSpellDI.chkCheck, "Warm spell is defined as a sequence of 6 or more days in which the daily maximum temperature exceeds the 90th percentile of daily maximum temperature for a 5-day running window surrounding this day during the baseline period")
        ttClimdexIndices.SetToolTip(ucrChkColdSpellDI.chkCheck, "Cold spell is defined as a sequence of 6 or more days in which the daily minimum temperature is below the 10th percentile of daily minimum temperature for a 5-day running window surrounding this day during the baseline period.")
        ttClimdexIndices.SetToolTip(ucrChkMeanDiurnalTempRange.chkCheck, "Computes the mean daily diurnal temperature range. The frequency of observation can be either monthly or annual")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMax1dayPrec.chkCheck, "Computes the climdex index Rx1day: monthly or annual maximum 1-day precipitation")
        ttClimdexIndices.SetToolTip(ucrChkMonthlyMax5dayPrec.chkCheck, "Computes the monthly or annual maximum consecutive 5-day precipitation")
        ttClimdexIndices.SetToolTip(ucrChkSimplePrecII.chkCheck, "This is defined as the sum of precipitation in wet days (days with preciptitation over 1mm) during the year divided by the number of wet days in the year.")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed10mm.chkCheck, "Computes the annual count of days where daily precipitation is more than 10mm per day")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed20mm.chkCheck, "Computes the annual count of days where daily precipitation is more than 20mm per day")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceedSpecifiedA.chkCheck, "Computes the climdex index Rnnmm: the annual count of days where daily precipitation is more than nn mm per day")
        ttClimdexIndices.SetToolTip(ucrChkMaxDrySpell.chkCheck, "Maximum number of days when precipitation is less than 1mm.")
        ttClimdexIndices.SetToolTip(ucrChkMaxWetSpell.chkCheck, "Maximum number of days when precipitation is greater than 1mm")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed95Percent.chkCheck, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 95th percentile of daily precipitation in the base period ")
        ttClimdexIndices.SetToolTip(ucrChkPrecExceed99Percent.chkCheck, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 99th percentile of daily precipitation in the base period ")
        ttClimdexIndices.SetToolTip(ucrChkTotalDailyPrec.chkCheck, "Computes the annual sum of precipitation in wet days (days where precipitation is at least 1mm). ")

        clsROneArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg1.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg2.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg2.AddParameter("gsl.mode", Chr(34) & "GSL" & Chr(34))
        clsRTwoArg3.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg4.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRTwoArg5.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)
        clsRThreeArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsDefaultFunction)

        bControlsInitialised = True
    End Sub

    Public Sub IndicesOptions()
        If (ucrChkFrostDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.fd")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkSummerDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.su")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkIcingDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.id")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkTropicalNights.Checked = True) Then
            clsROneArg.SetRCommand("climdex.tr")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkGrowingSeasonLength.Checked = True) Then
            clsRTwoArg2.SetRCommand("climdex.gsl")
            frmMain.clsRLink.RunScript(clsRTwoArg2.ToScript(), 2)
        End If
        If (ucrChkMonthlyMaxDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.txx")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkMonthlyMaxDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tnx")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkMonthlyMinDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.txn")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkMonthlyMinDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tnn")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkTminBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tn10p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkTmaxBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tx10p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkTminAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tn90p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkTmaxAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tx90p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkWarmSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand("climdex.wsdi")
            frmMain.clsRLink.RunScript(clsRTwoArg5.ToScript(), 2)
        End If
        If (ucrChkColdSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand("climdex.csdi")
            frmMain.clsRLink.RunScript(clsRTwoArg5.ToScript(), 2)
        End If
        If (ucrChkMeanDiurnalTempRange.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.dtr")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkMonthlyMax1dayPrec.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.rx1day")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (ucrChkMonthlyMax5dayPrec.Checked = True) Then
            clsRThreeArg.SetRCommand("climdex.rx5day")
            frmMain.clsRLink.RunScript(clsRThreeArg.ToScript(), 2)
        End If
        If (ucrChkSimplePrecII.Checked = True) Then
            clsROneArg.SetRCommand("climdex.sdii")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkPrecExceed10mm.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r10mm")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkPrecExceed20mm.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r20mm")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkPrecExceedSpecifiedA.Checked = True) Then
            clsRTwoArg3.SetRCommand("climdex.rnnmm")
            frmMain.clsRLink.RunScript(clsRTwoArg3.ToScript(), 2)
        End If
        If (ucrChkMaxDrySpell.Checked = True) Then
            clsRTwoArg4.SetRCommand("climdex.cdd")
            frmMain.clsRLink.RunScript(clsRTwoArg4.ToScript(), 2)
        End If
        If (ucrChkMaxWetSpell.Checked = True) Then
            clsRTwoArg4.SetRCommand("climdex.cwd")
            frmMain.clsRLink.RunScript(clsRTwoArg4.ToScript(), 2)
        End If
        If (ucrChkPrecExceed95Percent.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r95ptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkPrecExceed99Percent.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r99ptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (ucrChkTotalDailyPrec.Checked = True) Then
            clsROneArg.SetRCommand("climdex.prcptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
    End Sub

    'Private Sub nudYearFromTo_ValueChanged(sender As Object, e As EventArgs)
    '    dlgClimdex.clsDefaultFunction.AddParameter("base.range", "c(" & nudYearFrom.Value & "," & nudYearTo.Value & ")")
    '    If nudYearFrom.Value = 1961 AndAlso nudYearTo.Value = 1990 Then
    '        dlgClimdex.clsDefaultFunction.RemoveParameterByName("base.range")
    '    End If
    'End Sub

    'Private Sub ucrMultipleInputPrecQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputPrecQtiles.Leave
    '    If ucrMultipleInputPrecQtiles.txtNumericItems.Text <> "0.95, 0.99" Then
    '        dlgClimdex.clsDefaultFunction.AddParameter("prec.qtiles", ucrMultipleInputPrecQtiles.clsNumericList.ToScript)
    '    Else
    '        dlgClimdex.clsDefaultFunction.RemoveParameterByName("prec.qtiles")
    '    End If
    'End Sub

    'Private Sub ucrMultipleInputTempQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputTempQtiles.Leave
    '    If ucrMultipleInputTempQtiles.txtNumericItems.Text <> "0.1, 0.9" Then
    '        dlgClimdex.clsDefaultFunction.AddParameter("temp.qtiles", ucrMultipleInputTempQtiles.clsNumericList.ToScript)
    '    Else
    '        dlgClimdex.clsDefaultFunction.RemoveParameterByName("temp.qtiles")
    '    End If
    'End Sub

    'Private Sub ucrInputFreq_Leave(sender As Object, e As EventArgs) Handles ucrInputFreq.Leave
    '    Select Case ucrInputFreq.GetText
    '        Case "annual"
    '            clsRTwoArg1.AddParameter("freq", Chr(34) & "annual" & Chr(34))
    '            clsRThreeArg.AddParameter("freq", Chr(34) & "annual" & Chr(34))
    '        Case "monthly"
    '            clsRTwoArg1.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
    '            clsRThreeArg.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
    '    End Select
    'End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsNewClimdexInput = clsNewRFunction
        ucrNudN.SetRCode(clsNewClimdexInput, bReset)
        ucrNudThreshold.SetRCode(clsRTwoArg3, bReset)
        ucrNudAnnualMissingDays.SetRCode(clsRMaxMisingDays, bReset)
        ucrNudMothlyMissingDays.SetRCode(clsRMaxMisingDays, bReset)
        ucrNudMinBaseData.SetRCode(clsNewClimdexInput, bReset)
        ucrInputFreq.SetRCode(clsRTwoArg1, bReset)
        ucrInputFreq.SetRCode(clsRThreeArg, bReset)
        ucrMultipleInputTempQtiles.SetRCode(clsNewClimdexInput, bReset)
        ucrMultipleInputPrecQtiles.SetRCode(clsNewClimdexInput, bReset)
        ucrMultipleInputBaseRange.SetRCode(clsNewClimdexInput, bReset)
        ucrChkNHemisphere.SetRCode(clsNewClimdexInput, bReset)
        ucrChkCenterMean.SetRCode(clsRThreeArg, bReset)
        ucrChkMaxSpellSpanYears.SetRCode(clsRTwoArg4, bReset)
        ucrChkSpellDISpanYear.SetRCode(clsRTwoArg5, bReset)
    End Sub
End Class