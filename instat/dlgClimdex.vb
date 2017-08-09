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
Public Class dlgClimdex
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
        ucrBase.clsRsyntax.iCallType = 0

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
        clsDefaultFunction.AddParameter("northern.hemisphere", "TRUE", iPosition:=9) ' R-default
        clsDefaultFunction.AddParameter("min.base.data.fraction.present", 0.1, iPosition:=16) ' r-default
        clsDefaultFunction.AddParameter("max.missing.days", clsRFunctionParameter:=clsRMaxMissingDays, iPosition:=15)
        clsDefaultFunction.AddParameter("base.range", clsRFunctionParameter:=clsRBaseRange, iPosition:=7)
        clsDefaultFunction.AddParameter("temp.qtiles", clsRFunctionParameter:=clsRTempQTiles, iPosition:=13)
        clsDefaultFunction.AddParameter("prec.qtiles", clsRFunctionParameter:=clsRPrecQTiles, iPosition:=14)

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
        clsRWriteDf.SetRCommand("InstatDataObject$add_climdex_indices")
        clsRWriteDf.AddParameter("indices", clsRFunctionParameter:=clsRWriteDfIndicesList, iPosition:=1)
        clsRWriteDf.AddParameter("freq", "annual", iPosition:=2) ' todo: can remove this as it's the r-default
        clsRWriteDfIndicesList.SetRCommand("list")

        clsFrostDays.SetPackageName("climdex.pcic")
        clsFrostDays.SetRCommand("climdex.fd")
        clsFrostDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsSummerDays.SetPackageName("climdex.pcic")
        clsSummerDays.SetRCommand("climdex.su")
        clsSummerDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsIcingDays.SetPackageName("climdex.pcic")
        clsIcingDays.SetRCommand("climdex.id")
        clsIcingDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTropicalNights.SetPackageName("climdex.pcic")
        clsTropicalNights.SetRCommand("climdex.tr")
        clsTropicalNights.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsWarmSpellDI.SetPackageName("climdex.pcic")
        clsWarmSpellDI.SetRCommand("climdex.wsdi")
        clsWarmSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsWarmSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default

        clsColdSpellDI.SetPackageName("climdex.pcic")
        clsColdSpellDI.SetRCommand("climdex.csdi")
        clsColdSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsColdSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default

        clsGrowingSeasonLength.SetPackageName("climdex.pcic")
        clsGrowingSeasonLength.SetRCommand("climdex.gsl")
        clsGrowingSeasonLength.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsGrowingSeasonLength.AddParameter("gsl.mode", Chr(34) & "GSL" & Chr(34), iPosition:=1) ' todo: can remove this as r-default.

        clsMonthlyMaxDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMax.SetRCommand("climdex.txx")
        clsMonthlyMaxDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMonthlyMaxDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMin.SetRCommand("climdex.txn")
        clsMonthlyMaxDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMonthlyMinDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMax.SetRCommand("climdex.tnx")
        clsMonthlyMinDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMonthlyMinDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMin.SetRCommand("climdex.tnn")
        clsMonthlyMinDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTminBelow10Percent.SetPackageName("climdex.pcic")
        clsTminBelow10Percent.SetRCommand("climdex.tn10p")
        clsTminBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTmaxBelow10Percent.SetPackageName("climdex.pcic")
        clsTmaxBelow10Percent.SetRCommand("climdex.tx10p")
        clsTmaxBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTminAbove90Percent.SetPackageName("climdex.pcic")
        clsTminAbove90Percent.SetRCommand("climdex.tn90p")
        clsTminAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTmaxAbove90Percent.SetPackageName("climdex.pcic")
        clsTmaxAbove90Percent.SetRCommand("climdex.tx90p")
        clsTmaxAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMeanDiurnalTempRange.SetPackageName("climdex.pcic")
        clsMeanDiurnalTempRange.SetRCommand("climdex.dtr")
        clsMeanDiurnalTempRange.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMonthlyMax1DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax1DayPrec.SetRCommand("climdex.rx1day")
        clsMonthlyMax1DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsMonthlyMax5DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax5DayPrec.SetRCommand("climdex.rx5day")
        clsMonthlyMax5DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMax5DayPrec.AddParameter("center.mean.on.last.day", "FALSE", iPosition:=1) ' r-default

        clsSimplePrecII.SetPackageName("climdex.pcic")
        clsSimplePrecII.SetRCommand("climdex.sdii")
        clsSimplePrecII.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsPrecExceed10mm.SetPackageName("climdex.pcic")
        clsPrecExceed10mm.SetRCommand("climdex.r10mm")
        clsPrecExceed10mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsPrecExceed20mm.SetPackageName("climdex.pcic")
        clsPrecExceed20mm.SetRCommand("climdex.r20mm")
        clsPrecExceed20mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsPrecExceedSpecifiedA.SetPackageName("climdex.pcic")
        clsPrecExceedSpecifiedA.SetRCommand("climdex.rnnmm")
        clsPrecExceedSpecifiedA.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsPrecExceedSpecifiedA.AddParameter("threshold", 1, iPosition:=1) ' r-default

        clsMaxDrySpell.SetPackageName("climdex.pcic")
        clsMaxDrySpell.SetRCommand("climdex.cdd")
        clsMaxDrySpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMaxDrySpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default

        clsMaxWetSpell.SetPackageName("climdex.pcic")
        clsMaxWetSpell.SetRCommand("climdex.cwd")
        clsMaxWetSpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsMaxWetSpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default

        clsPrecExceed95Percent.SetPackageName("climdex.pcic")
        clsPrecExceed95Percent.SetRCommand("climdex.r95ptot")
        clsPrecExceed95Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsPrecExceed99Percent.SetPackageName("climdex.pcic")
        clsPrecExceed99Percent.SetRCommand("climdex.r99ptot")
        clsPrecExceed99Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        clsTotalDailyPrec.SetPackageName("climdex.pcic")
        clsTotalDailyPrec.SetRCommand("climdex.prcptot")
        clsTotalDailyPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        'add rfunction as parameters of the main function here

        'ucrBaseClimdex.clsRsyntax.AddParameter("temp.qtiles", "c(0.1,0.9)")
        'ucrBaseClimdex.clsRsyntax.AddParameter("prec.qtiles", "c(0.95, 0.99)")
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
        If Not ucrReceiverDate.IsEmpty AndAlso (Not ucrReceiverTmax.IsEmpty OrElse Not ucrReceiverTmin.IsEmpty OrElse Not ucrReceiverPrec.IsEmpty) Then
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
        sdgClimdexIndices.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, clsRWriteDf, clsRWriteDfIndicesList, clsRMaxMissingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles, clsFrostDays, clsSummerDays, clsIcingDays, clsTropicalNights, clsWarmSpellDI, clsColdSpellDI, clsGrowingSeasonLength, clsMonthlyMaxDailyTMax, clsMonthlyMaxDailyTMin, clsMonthlyMinDailyTMax, clsMonthlyMinDailyTMin, clsTminBelow10Percent, clsTmaxBelow10Percent, clsTminAbove90Percent, clsTmaxAbove90Percent, clsMeanDiurnalTempRange, clsMonthlyMax1DayPrec, clsMonthlyMax5DayPrec, clsSimplePrecII, clsPrecExceed10mm, clsPrecExceed20mm, clsPrecExceedSpecifiedA, clsMaxDrySpell, clsMaxWetSpell, clsPrecExceed95Percent, clsPrecExceed99Percent, clsTotalDailyPrec, bResetSubdialog)
        bResetSubdialog = False
        sdgClimdexIndices.ShowDialog()
    End Sub

    Private Sub ucrBaseClimdex_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgClimdexIndices.IndicesOptions(bSaveIndex)
    End Sub

    Private Sub ucrChkSave_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlContentsChanged
        If ucrChkSave.Checked Then
            bSaveIndex = True
        Else
            bSaveIndex = False
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimdex.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged
        TestOkEnabled()
        sdgClimdexIndices.IndicesType() 'is this the right implementation?
    End Sub
End Class