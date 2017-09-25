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
Public Class dlgClimdexIndices
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bSaveIndex As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public clsDefaultFunction As New RFunction
    Public clsRDataName, clsRPCIct, clsRChar, clsRWriteDf, clsRWriteDfIndicesList, clsRMaxMissingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles As New RFunction
    Public clsFrostDays, clsSummerDays, clsIcingDays, clsTropicalNights, clsWarmSpellDI, clsColdSpellDI, clsGrowingSeasonLength, clsMonthlyMaxDailyTMax, clsMonthlyMaxDailyTMin, clsMonthlyMinDailyTMax, clsMonthlyMinDailyTMin, clsTminBelow10Percent, clsTmaxBelow10Percent, clsTminAbove90Percent, clsTmaxAbove90Percent, clsMeanDiurnalTempRange As New RFunction
    Public clsMonthlyMax1DayPrec, clsMonthlyMax5DayPrec, clsSimplePrecII, clsPrecExceed10mm, clsPrecExceed20mm, clsPrecExceedSpecifiedA, clsMaxDrySpell, clsMaxWetSpell, clsPrecExceed95Percent, clsPrecExceed99Percent, clsTotalDailyPrec As New RFunction

    Private Sub dlgClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 190

        ucrSelectorClimdex.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimdex.SetParameterIsString()

        ucrReceiverDate.SetParameter(New RParameter("x", 1))
        ucrReceiverDate.Selector = ucrSelectorClimdex
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverTmax.SetParameter(New RParameter("tmax", 1))
        ucrReceiverTmax.SetParameterIsRFunction()
        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmax.SetClimaticType("temp_max")
        ucrReceiverTmax.bAutoFill = True
        ucrReceiverTmax.strSelectorHeading = "Maximum Temperature"

        ucrReceiverTmin.SetParameter(New RParameter("tmin", 1))
        ucrReceiverTmin.SetParameterIsRFunction()
        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.bAutoFill = True
        ucrReceiverTmin.strSelectorHeading = "Minimum Temperature"

        ucrReceiverPrec.SetParameter(New RParameter("prec", 1))
        ucrReceiverPrec.SetParameterIsRFunction()
        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ucrReceiverPrec.SetClimaticType("rain")
        ucrReceiverPrec.bAutoFill = True
        ucrReceiverPrec.strSelectorHeading = "Rain Variables"

        ucrChkSave.SetText("Save Indices")
        ucrChkSave.bChangeParameterValue = False
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRPCIct = New RFunction
        clsRChar = New RFunction
        clsRWriteDf = New RFunction
        clsRMaxMissingDays = New RFunction
        clsRBaseRange = New RFunction
        clsRTempQTiles = New RFunction
        clsRPrecQTiles = New RFunction
        clsRWriteDfIndicesList = New RFunction

        clsFrostDays = New RFunction
        clsSummerDays = New RFunction
        clsIcingDays = New RFunction
        clsTropicalNights = New RFunction
        clsWarmSpellDI = New RFunction
        clsColdSpellDI = New RFunction
        clsGrowingSeasonLength = New RFunction
        clsMonthlyMaxDailyTMax = New RFunction
        clsMonthlyMaxDailyTMin = New RFunction
        clsMonthlyMinDailyTMax = New RFunction
        clsMonthlyMinDailyTMin = New RFunction
        clsTminBelow10Percent = New RFunction
        clsTmaxBelow10Percent = New RFunction
        clsTminAbove90Percent = New RFunction
        clsTmaxAbove90Percent = New RFunction
        clsMeanDiurnalTempRange = New RFunction
        clsMonthlyMax1DayPrec = New RFunction
        clsMonthlyMax5DayPrec = New RFunction
        clsSimplePrecII = New RFunction
        clsPrecExceed10mm = New RFunction
        clsPrecExceed20mm = New RFunction
        clsPrecExceedSpecifiedA = New RFunction
        clsMaxDrySpell = New RFunction
        clsMaxWetSpell = New RFunction
        clsPrecExceed95Percent = New RFunction
        clsPrecExceed99Percent = New RFunction
        clsTotalDailyPrec = New RFunction

        ucrSelectorClimdex.Reset()
        ucrSelectorClimdex.Focus()
        ucrReceiverDate.SetMeAsReceiver()
        ucrChkSave.Checked = True

        'Define the default RFunction
        clsDefaultFunction.SetPackageName("climdex.pcic")
        clsDefaultFunction.SetRCommand("climdexInput.raw")
        clsDefaultFunction.AddParameter("tmax.dates", clsRFunctionParameter:=clsRPCIct)
        clsDefaultFunction.AddParameter("tmin.dates", clsRFunctionParameter:=clsRPCIct)
        clsDefaultFunction.AddParameter("prec.dates", clsRFunctionParameter:=clsRPCIct)
        clsDefaultFunction.AddParameter("base.range", clsRFunctionParameter:=clsRBaseRange, iPosition:=7)
        clsDefaultFunction.AddParameter("northern.hemisphere", "TRUE", iPosition:=9) ' r-default
        clsDefaultFunction.AddParameter("temp.qtiles", clsRFunctionParameter:=clsRTempQTiles, iPosition:=13)
        clsDefaultFunction.AddParameter("prec.qtiles", clsRFunctionParameter:=clsRPrecQTiles, iPosition:=14)
        clsDefaultFunction.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMissingDays, iPosition:=15)
        clsDefaultFunction.AddParameter("min.base.data.fraction.present", 0.1, iPosition:=16) ' r-default
        clsDefaultFunction.SetAssignTo("climdex_input")

        clsRMaxMissingDays.SetRCommand("c")
        clsRMaxMissingDays.AddParameter("annual", 15, iPosition:=0) ' These are both r-defaults, however, if you change say monthly and so that parameter runs, we get an error that it wants to see annual too. So, I've removed the r-default for now.
        clsRMaxMissingDays.AddParameter("monthly", 3, iPosition:=1) ' Also we don't want to run max.missing.days = c().

        clsRBaseRange.SetRCommand("c")
        clsRBaseRange.AddParameter("lower_base", 1961, bIncludeArgumentName:=False, iPosition:=0)
        clsRBaseRange.AddParameter("upper_base", 1990, bIncludeArgumentName:=False, iPosition:=1)

        clsRTempQTiles.SetRCommand("c")
        clsRTempQTiles.AddParameter("x", "0.1, 0.9", bIncludeArgumentName:=False, iPosition:=0) ' r-default, left in to avoid running temp.qtiles = c()

        clsRPrecQTiles.SetRCommand("c")
        clsRPrecQTiles.AddParameter("x", "0.95, 0.99", bIncludeArgumentName:=False, iPosition:=0)

        clsRPCIct.SetPackageName("PCICt")
        clsRPCIct.SetRCommand("as.PCICt")
        clsRPCIct.AddParameter("x", clsRFunctionParameter:=clsRChar, iPosition:=0)
        clsRPCIct.AddParameter("cal", Chr(34) & "gregorian" & Chr(34), iPosition:=1)

        clsRChar.SetRCommand("as.character")

        ' For the sub dialog
        clsRWriteDf.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_climdex_indices")
        clsRWriteDf.AddParameter("indices", clsRFunctionParameter:=clsRWriteDfIndicesList, iPosition:=1)
        clsRWriteDfIndicesList.SetRCommand("list")

        clsFrostDays.SetPackageName("climdex.pcic")
        clsFrostDays.SetRCommand("climdex.fd")
        clsFrostDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsFrostDays.SetAssignTo("Frost_Days")

        clsSummerDays.SetPackageName("climdex.pcic")
        clsSummerDays.SetRCommand("climdex.su")
        clsSummerDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsSummerDays.SetAssignTo("Summer_Days")

        clsIcingDays.SetPackageName("climdex.pcic")
        clsIcingDays.SetRCommand("climdex.id")
        clsIcingDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsIcingDays.SetAssignTo("Icing_Days")

        clsTropicalNights.SetPackageName("climdex.pcic")
        clsTropicalNights.SetRCommand("climdex.tr")
        clsTropicalNights.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsTropicalNights.SetAssignTo("Tropical_Nights")

        clsWarmSpellDI.SetPackageName("climdex.pcic")
        clsWarmSpellDI.SetRCommand("climdex.wsdi")
        clsWarmSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsWarmSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default
        clsWarmSpellDI.SetAssignTo("Warm_Spell_Duration_Index")

        clsColdSpellDI.SetPackageName("climdex.pcic")
        clsColdSpellDI.SetRCommand("climdex.csdi")
        clsColdSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsColdSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default
        clsColdSpellDI.SetAssignTo("Cold_Spell_Duration_Index")

        clsGrowingSeasonLength.SetPackageName("climdex.pcic")
        clsGrowingSeasonLength.SetRCommand("climdex.gsl")
        clsGrowingSeasonLength.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsGrowingSeasonLength.SetAssignTo("Growing_Season_Length")

        clsMonthlyMaxDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMax.SetRCommand("climdex.txx")
        clsMonthlyMaxDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMaxDailyTMax.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMaxDailyTMax.SetAssignTo("Monthly_Maximum_of_Daily_Maximum_Temperature")

        clsMonthlyMaxDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMin.SetRCommand("climdex.txn")
        clsMonthlyMaxDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMaxDailyTMin.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMaxDailyTMin.SetAssignTo("Monthly_Maximum_of_Daily_Minimum_Temperature")

        clsMonthlyMinDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMax.SetRCommand("climdex.tnx")
        clsMonthlyMinDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMinDailyTMax.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMinDailyTMax.SetAssignTo("Monthly_Minimum_of_Daily_Maximum_Temperature")

        clsMonthlyMinDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMin.SetRCommand("climdex.tnn")
        clsMonthlyMinDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMinDailyTMin.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMinDailyTMin.SetAssignTo("Monthly_Minimum_of_Daily_Minimum_Temperature")

        clsTminBelow10Percent.SetPackageName("climdex.pcic")
        clsTminBelow10Percent.SetRCommand("climdex.tn10p")
        clsTminBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTminBelow10Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTminBelow10Percent.SetAssignTo("Percentage_of_Days_When_Tmin_is_Below_10th_Percentile")

        clsTmaxBelow10Percent.SetPackageName("climdex.pcic")
        clsTmaxBelow10Percent.SetRCommand("climdex.tx10p")
        clsTmaxBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTmaxBelow10Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTmaxBelow10Percent.SetAssignTo("Percentage_of_Days_When_Tmax_is_Below_10th_Percentile")

        clsTminAbove90Percent.SetPackageName("climdex.pcic")
        clsTminAbove90Percent.SetRCommand("climdex.tn90p")
        clsTminAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTminAbove90Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTminAbove90Percent.SetAssignTo("Percentage_of_Days_When_Tmin_is_Above_90th_Percentile")

        clsTmaxAbove90Percent.SetPackageName("climdex.pcic")
        clsTmaxAbove90Percent.SetRCommand("climdex.tx90p")
        clsTmaxAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTmaxAbove90Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTmaxAbove90Percent.SetAssignTo("Percentage_of_Days_When_Tmax_is_Above_90th_Percentile")

        clsMeanDiurnalTempRange.SetPackageName("climdex.pcic")
        clsMeanDiurnalTempRange.SetRCommand("climdex.dtr")
        clsMeanDiurnalTempRange.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMeanDiurnalTempRange.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMeanDiurnalTempRange.SetAssignTo("Mean_Diurnal_Temperature_Range")

        clsMonthlyMax1DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax1DayPrec.SetRCommand("climdex.rx1day")
        clsMonthlyMax1DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMax1DayPrec.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMax1DayPrec.SetAssignTo("Monthly_Maximum_1day_Precipitation")

        clsMonthlyMax5DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax5DayPrec.SetRCommand("climdex.rx5day")
        clsMonthlyMax5DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMax5DayPrec.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=2)
        clsMonthlyMax5DayPrec.SetAssignTo("Monthly_Maximum_5day_Precipitation")

        clsSimplePrecII.SetPackageName("climdex.pcic")
        clsSimplePrecII.SetRCommand("climdex.sdii")
        clsSimplePrecII.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsSimplePrecII.SetAssignTo("Simple_Precipitation_Intensity_Index")

        clsPrecExceed10mm.SetPackageName("climdex.pcic")
        clsPrecExceed10mm.SetRCommand("climdex.r10mm")
        clsPrecExceed10mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed10mm.SetAssignTo("Precipitation_Exceeding_10mm_Per_Day")

        clsPrecExceed20mm.SetPackageName("climdex.pcic")
        clsPrecExceed20mm.SetRCommand("climdex.r20mm")
        clsPrecExceed20mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed20mm.SetAssignTo("Precipitation_Exceeding_20mm_Per_Day")

        clsPrecExceedSpecifiedA.SetPackageName("climdex.pcic")
        clsPrecExceedSpecifiedA.SetRCommand("climdex.rnnmm")
        clsPrecExceedSpecifiedA.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsPrecExceedSpecifiedA.SetAssignTo("Precipitation_Exceeding_a_Specified_Amount_Per_Day")

        clsMaxDrySpell.SetPackageName("climdex.pcic")
        clsMaxDrySpell.SetRCommand("climdex.cdd")
        clsMaxDrySpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMaxDrySpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default
        clsMaxDrySpell.SetAssignTo("Maximum_Length_of_Dry_Spell")

        clsMaxWetSpell.SetPackageName("climdex.pcic")
        clsMaxWetSpell.SetRCommand("climdex.cwd")
        clsMaxWetSpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsMaxWetSpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default
        clsMaxWetSpell.SetAssignTo("Maximum_Length_of_Wet_Spell")

        clsPrecExceed95Percent.SetPackageName("climdex.pcic")
        clsPrecExceed95Percent.SetRCommand("climdex.r95ptot")
        clsPrecExceed95Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed95Percent.SetAssignTo("Total_Daily_Precipitation_Exceeding_95th_Percentile_Threshold")

        clsPrecExceed99Percent.SetPackageName("climdex.pcic")
        clsPrecExceed99Percent.SetRCommand("climdex.r99ptot")
        clsPrecExceed99Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed99Percent.SetAssignTo("Total_Daily_Precipitation_Exceeding_99th_Percentile_Threshold")

        clsTotalDailyPrec.SetPackageName("climdex.pcic")
        clsTotalDailyPrec.SetRCommand("climdex.prcptot")
        clsTotalDailyPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsTotalDailyPrec.SetAssignTo("Total_Daily_Precipitation")

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRWriteDf)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorClimdex.SetRCode(clsRWriteDf, bReset)
        ucrReceiverTmin.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverTmax.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverPrec.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverDate.SetRCode(clsRChar, bReset)
    End Sub

    Private Sub TestOkEnabled() ' check this!
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverTmax.IsEmpty AndAlso Not ucrReceiverTmin.IsEmpty AndAlso Not ucrReceiverPrec.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseClimdex_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdIndices_Click(sender As Object, e As EventArgs) Handles cmdIndices.Click
        sdgClimdexIndices.SetRCode(clsDefaultFunction, clsRWriteDf, clsRWriteDfIndicesList, clsRMaxMissingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles, clsFrostDays, clsSummerDays, clsIcingDays, clsTropicalNights, clsWarmSpellDI, clsColdSpellDI, clsGrowingSeasonLength, clsMonthlyMaxDailyTMax, clsMonthlyMaxDailyTMin, clsMonthlyMinDailyTMax, clsMonthlyMinDailyTMin, clsTminBelow10Percent, clsTmaxBelow10Percent, clsTminAbove90Percent, clsTmaxAbove90Percent, clsMeanDiurnalTempRange, clsMonthlyMax1DayPrec, clsMonthlyMax5DayPrec, clsSimplePrecII, clsPrecExceed10mm, clsPrecExceed20mm, clsPrecExceedSpecifiedA, clsMaxDrySpell, clsMaxWetSpell, clsPrecExceed95Percent, clsPrecExceed99Percent, clsTotalDailyPrec, bResetSubdialog)
        bResetSubdialog = False
        sdgClimdexIndices.ShowDialog()
    End Sub

    Private Sub ucrChkSave_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlContentsChanged
        If ucrChkSave.Checked Then
            bSaveIndex = True
        Else
            bSaveIndex = False
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class