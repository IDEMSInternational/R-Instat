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
    'Public bFirstLoad As Boolean = True

    Private Sub sdgClimdexIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        clsRMaxMisingDays.SetRCommand("c")

        chkNHemisphere.Checked = True
        nudYearFrom.Value = 1961
        nudYearTo.Value = 1990
        nudN.Value = 5
        nudAnnualMissingDays.Value = 15
        nudMothlyMissingDays.Value = 3
        nudMinBaseData.Value = 0.1
        ucrInputFreq.cboInput.SelectedItem = "annual"
        ucrMultipleInputPrecQtiles.txtNumericItems.Text = "0.95, 0.99"
        ucrMultipleInputTempQtiles.txtNumericItems.Text = "0.1, 0.9"
        ucrMultipleInputTempQtiles.bIsNumericInput = True
        ucrMultipleInputPrecQtiles.bIsNumericInput = True
        ucrInputFreq.SetItems({"monthly", "annual"})
        chkFrostDays.Checked = True
        chkSummerDays.Checked = False
        chkIcingDays.Checked = False
        chkTropicalNights.Checked = False
        chkGrowingSeasonLength.Checked = False
        chkMonthlyMaxDailyTMax.Checked = False
        chkMonthlyMaxDailyTMin.Checked = False
        chkMonthlyMinDailyTMax.Checked = False
        chkMonthlyMinDailyTMin.Checked = False
        chkTminBelow10Percent.Checked = False
        chkTmaxBelow10Percent.Checked = False
        chkTminAbove90Percent.Checked = False
        chkTmaxAbove90Percent.Checked = False
        chkWarmSpellDI.Checked = False
        chkColdSpellDI.Checked = False
        chkMeanDiurnalTempRange.Checked = False
        chkMonthlyMax1dayPrec.Checked = False
        chkMonthlyMax5dayPrec.Checked = False
        chkSimplePrecII.Checked = False
        chkPrecExceed10mm.Checked = False
        chkPrecExceed20mm.Checked = False
        chkPrecExceedSpecifiedA.Checked = False
        chkMaxDrySpell.Checked = False
        chkMaxWetSpell.Checked = False
        chkPrecExceed95Percent.Checked = False
        chkPrecExceed99Percent.Checked = False
        chkTotalDailyPrec.Checked = False
        chkCenterMean.Checked = False
        chkMaxSpellSpanYears.Checked = True
        chkSpellDISpanYear.Checked = False
        nudThreshold.Value = 1.0
        ttClimdexIndices.SetToolTip(chkFrostDays, "The annual count of days where daily minimum temperature drops below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(chkSummerDays, "The annual count of days where daily maximum temperature exceeds 25 degrees Celsius")
        ttClimdexIndices.SetToolTip(chkIcingDays, "The annual count of days where daily maximum temperature is below 0 degrees Celsius")
        ttClimdexIndices.SetToolTip(chkTropicalNights, "Annual count of days where daily minimum temperature stays above 20 degrees Celsius. ")
        ttClimdexIndices.SetToolTip(chkGrowingSeasonLength, "Is the number of days between the start of the first spell of warm days in the first half of the year, and the start of the first spell of cold days in the second half of the year")
        ttClimdexIndices.SetToolTip(chkMonthlyMaxDailyTMax, "Computes the monthly or annual maximum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(chkMonthlyMaxDailyTMin, "Computes the monthly or annual maximum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(chkMonthlyMinDailyTMax, "Computes the monthly or annual minimum of daily maximum temperature")
        ttClimdexIndices.SetToolTip(chkMonthlyMinDailyTMin, "Computes the monthly or annual minimum of daily minimum temperature")
        ttClimdexIndices.SetToolTip(chkTminBelow10Percent, "Computes  the monthly or annual proportion of minimum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(chkTmaxBelow10Percent, "Computes  the monthly or annual proportion of maximum temperature below 10th percentile")
        ttClimdexIndices.SetToolTip(chkTminAbove90Percent, "Computes  the monthly or annual proportion of minimum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(chkTmaxAbove90Percent, "Computes  the monthly or annual proportion of maximum temperature above 90th percentile")
        ttClimdexIndices.SetToolTip(chkWarmSpellDI, "Warm spell is defined as a sequence of 6 or more days in which the daily maximum temperature exceeds the 90th percentile of daily maximum temperature for a 5-day running window surrounding this day during the baseline period")
        ttClimdexIndices.SetToolTip(chkColdSpellDI, "Cold spell is defined as a sequence of 6 or more days in which the daily minimum temperature is below the 10th percentile of daily minimum temperature for a 5-day running window surrounding this day during the baseline period.")
        ttClimdexIndices.SetToolTip(chkMeanDiurnalTempRange, "Computes the mean daily diurnal temperature range. The frequency of observation can be either monthly or annual")
        ttClimdexIndices.SetToolTip(chkMonthlyMax1dayPrec, "Computes the climdex index Rx1day: monthly or annual maximum 1-day precipitation")
        ttClimdexIndices.SetToolTip(chkMonthlyMax5dayPrec, "Computes the monthly or annual maximum consecutive 5-day precipitation")
        ttClimdexIndices.SetToolTip(chkSimplePrecII, "This is defined as the sum of precipitation in wet days (days with preciptitation over 1mm) during the year divided by the number of wet days in the year.")
        ttClimdexIndices.SetToolTip(chkPrecExceed10mm, "Computes the annual count of days where daily precipitation is more than 10mm per day")
        ttClimdexIndices.SetToolTip(chkPrecExceed20mm, "Computes the annual count of days where daily precipitation is more than 20mm per day")
        ttClimdexIndices.SetToolTip(chkPrecExceedSpecifiedA, "Computes the climdex index Rnnmm: the annual count of days where daily precipitation is more than nn mm per day")
        ttClimdexIndices.SetToolTip(chkMaxDrySpell, "Maximum number of days when precipitation is less than 1mm.")
        ttClimdexIndices.SetToolTip(chkMaxWetSpell, "Maximum number of days when precipitation is greater than 1mm")
        ttClimdexIndices.SetToolTip(chkPrecExceed95Percent, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 95th percentile of daily precipitation in the base period ")
        ttClimdexIndices.SetToolTip(chkPrecExceed99Percent, "Computes the annual sum of precipitation in days where daily precipitation exceeds the 99th percentile of daily precipitation in the base period ")
        ttClimdexIndices.SetToolTip(chkTotalDailyPrec, "Computes the annual sum of precipitation in wet days (days where precipitation is at least 1mm). ")
        'clsROneArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRTwoArg1.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRTwoArg2.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRTwoArg2.AddParameter("gsl.mode", Chr(34) & "GSL" & Chr(34))
        'clsRTwoArg3.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRTwoArg4.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRTwoArg5.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)
        'clsRThreeArg.AddParameter("ci", clsRFunctionParameter:=dlgClimdex.clsRClimdexInput)

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

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsNewClimdexInput = clsNewRFunction
        SetRCode(Me, clsNewClimdexInput, bReset)
        'include all the other rfunctions
    End Sub

    Private Sub nudThreshold_ValueChanged(sender As Object, e As EventArgs) Handles nudThreshold.ValueChanged
        If nudThreshold.Value = 1.0 Then
            clsRTwoArg3.RemoveParameterByName("threshold")
        Else
            clsRTwoArg3.AddParameter("threshold", nudThreshold.Value)
        End If
    End Sub

    Private Sub chkCenterMean_CheckedChanged(sender As Object, e As EventArgs) Handles chkCenterMean.CheckedChanged
        If chkCenterMean.Checked Then
            clsRThreeArg.AddParameter("center.mean.on.last.day", "TRUE")
        Else
            clsRThreeArg.RemoveParameterByName("center.mean.on.last.day")
        End If
    End Sub

    Private Sub chkSpellDISpanYear_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpellDISpanYear.CheckedChanged
        If chkSpellDISpanYear.Checked Then
            clsRTwoArg5.AddParameter("spells.can.span.years", "TRUE")
        Else
            clsRTwoArg5.RemoveParameterByName("spells.can.span.years")
        End If
    End Sub

    Private Sub chkMaxSpellSpanYears_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaxSpellSpanYears.CheckedChanged
        If chkMaxSpellSpanYears.Checked Then
            clsRTwoArg4.RemoveParameterByName("spells.can.span.years")
        Else
            clsRTwoArg4.AddParameter("spells.can.span.years", "FALSE")
        End If
    End Sub

    Public Sub IndicesOptions()
        If (chkFrostDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.fd")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkSummerDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.su")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkIcingDays.Checked = True) Then
            clsROneArg.SetRCommand("climdex.id")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkTropicalNights.Checked = True) Then
            clsROneArg.SetRCommand("climdex.tr")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkGrowingSeasonLength.Checked = True) Then
            clsRTwoArg2.SetRCommand("climdex.gsl")
            frmMain.clsRLink.RunScript(clsRTwoArg2.ToScript(), 2)
        End If
        If (chkMonthlyMaxDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.txx")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkMonthlyMaxDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tnx")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkMonthlyMinDailyTMax.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.txn")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkMonthlyMinDailyTMin.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tnn")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkTminBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tn10p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkTmaxBelow10Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tx10p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkTminAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tn90p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkTmaxAbove90Percent.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.tx90p")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkWarmSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand("climdex.wsdi")
            frmMain.clsRLink.RunScript(clsRTwoArg5.ToScript(), 2)
        End If
        If (chkColdSpellDI.Checked = True) Then
            clsRTwoArg5.SetRCommand("climdex.csdi")
            frmMain.clsRLink.RunScript(clsRTwoArg5.ToScript(), 2)
        End If
        If (chkMeanDiurnalTempRange.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.dtr")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkMonthlyMax1dayPrec.Checked = True) Then
            clsRTwoArg1.SetRCommand("climdex.rx1day")
            frmMain.clsRLink.RunScript(clsRTwoArg1.ToScript(), 2)
        End If
        If (chkMonthlyMax5dayPrec.Checked = True) Then
            clsRThreeArg.SetRCommand("climdex.rx5day")
            frmMain.clsRLink.RunScript(clsRThreeArg.ToScript(), 2)
        End If
        If (chkSimplePrecII.Checked = True) Then
            clsROneArg.SetRCommand("climdex.sdii")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkPrecExceed10mm.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r10mm")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkPrecExceed20mm.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r20mm")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkPrecExceedSpecifiedA.Checked = True) Then
            clsRTwoArg3.SetRCommand("climdex.rnnmm")
            frmMain.clsRLink.RunScript(clsRTwoArg3.ToScript(), 2)
        End If
        If (chkMaxDrySpell.Checked = True) Then
            clsRTwoArg4.SetRCommand("climdex.cdd")
            frmMain.clsRLink.RunScript(clsRTwoArg4.ToScript(), 2)
        End If
        If (chkMaxWetSpell.Checked = True) Then
            clsRTwoArg4.SetRCommand("climdex.cwd")
            frmMain.clsRLink.RunScript(clsRTwoArg4.ToScript(), 2)
        End If
        If (chkPrecExceed95Percent.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r95ptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkPrecExceed99Percent.Checked = True) Then
            clsROneArg.SetRCommand("climdex.r99ptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
        If (chkTotalDailyPrec.Checked = True) Then
            clsROneArg.SetRCommand("climdex.prcptot")
            frmMain.clsRLink.RunScript(clsROneArg.ToScript(), 2)
        End If
    End Sub

    Private Sub nudYearFromTo_ValueChanged(sender As Object, e As EventArgs) Handles nudYearFrom.ValueChanged, nudYearTo.ValueChanged
        dlgClimdex.clsDefaultFunction.AddParameter("base.range", "c(" & nudYearFrom.Value & "," & nudYearTo.Value & ")")
        If nudYearFrom.Value = 1961 AndAlso nudYearTo.Value = 1990 Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("base.range")
        End If
    End Sub

    Private Sub nudN_ValueChanged(sender As Object, e As EventArgs) Handles nudN.ValueChanged
        dlgClimdex.clsDefaultFunction.AddParameter("n", nudN.Value)
        If nudN.Value = 5 Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub chkNHemisphere_CheckedChanged(sender As Object, e As EventArgs) Handles chkNHemisphere.CheckedChanged
        If chkNHemisphere.Checked Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("northern.hemisphere")
        Else
            dlgClimdex.clsDefaultFunction.AddParameter("northern.hemisphere", "FALSE")
        End If
    End Sub

    Private Sub nudAnnualMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudAnnualMissingDays.ValueChanged
        clsRMaxMisingDays.AddParameter("annual", nudAnnualMissingDays.Value)
        If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("max.missing.days")
        Else
            dlgClimdex.clsDefaultFunction.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        End If
    End Sub

    Private Sub nudMonthlyMaxMissingDays_ValueChanged(sender As Object, e As EventArgs) Handles nudMothlyMissingDays.ValueChanged
        clsRMaxMisingDays.AddParameter("monthly", nudMothlyMissingDays.Value)
        If nudAnnualMissingDays.Value = 15 AndAlso nudMothlyMissingDays.Value = 3 Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("max.missing.days")
        Else
            dlgClimdex.clsDefaultFunction.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMisingDays)
        End If
    End Sub

    Private Sub nudMinBaseData_ValueChanged(sender As Object, e As EventArgs) Handles nudMinBaseData.ValueChanged
        dlgClimdex.clsDefaultFunction.AddParameter("min.base.data.fraction.present ", nudMinBaseData.Value)
        If nudMinBaseData.Value = 0.1 Then
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("min.base.data.fraction.present ")
        End If
    End Sub

    Private Sub ucrMultipleInputPrecQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputPrecQtiles.Leave
        If ucrMultipleInputPrecQtiles.txtNumericItems.Text <> "0.95, 0.99" Then
            dlgClimdex.clsDefaultFunction.AddParameter("prec.qtiles", ucrMultipleInputPrecQtiles.clsNumericList.ToScript)
        Else
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("prec.qtiles")
        End If
    End Sub

    Private Sub ucrMultipleInputTempQtiles_Leave(sender As Object, e As EventArgs) Handles ucrMultipleInputTempQtiles.Leave
        If ucrMultipleInputTempQtiles.txtNumericItems.Text <> "0.1, 0.9" Then
            dlgClimdex.clsDefaultFunction.AddParameter("temp.qtiles", ucrMultipleInputTempQtiles.clsNumericList.ToScript)
        Else
            dlgClimdex.clsDefaultFunction.RemoveParameterByName("temp.qtiles")
        End If
    End Sub

    Private Sub ucrInputFreq_Leave(sender As Object, e As EventArgs) Handles ucrInputFreq.Leave
        Select Case ucrInputFreq.GetText
            Case "annual"
                clsRTwoArg1.AddParameter("freq", Chr(34) & "annual" & Chr(34))
                clsRThreeArg.AddParameter("freq", Chr(34) & "annual" & Chr(34))
            Case "monthly"
                clsRTwoArg1.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
                clsRThreeArg.AddParameter("freq", Chr(34) & "monthly" & Chr(34))
        End Select
    End Sub
End Class