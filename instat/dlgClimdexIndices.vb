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
    Private clsDefaultFunction As New RFunction
    Private clsRDataName, clsRPCIct, clsRChar, clsRWriteDf, clsRWriteDfIndicesList, clsRMaxMissingDays, clsRBaseRange, clsRTempQTiles, clsRPrecQTiles As New RFunction
    Private clsFrostDays, clsSummerDays, clsIcingDays, clsTropicalNights, clsWarmSpellDI, clsColdSpellDI, clsGrowingSeasonLength, clsMonthlyMaxDailyTMax, clsMonthlyMaxDailyTMin, clsMonthlyMinDailyTMax, clsMonthlyMinDailyTMin, clsTminBelow10Percent, clsTmaxBelow10Percent, clsTminAbove90Percent, clsTmaxAbove90Percent, clsMeanDiurnalTempRange As New RFunction
    Private clsMonthlyMax1DayPrec, clsMonthlyMax5DayPrec, clsSimplePrecII, clsPrecExceed10mm, clsPrecExceed20mm, clsPrecExceedSpecifiedA, clsMaxDrySpell, clsMaxWetSpell, clsPrecExceed95Percent, clsPrecExceed99Percent, clsTotalDailyPrec As New RFunction

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

        ucrReceiverYear.SetParameter(New RParameter("year", 3))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorClimdex
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 4))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimdex
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

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


        ucrPnlAnnualMonthly.AddToLinkedControls({ucrReceiverMonth}, {rdoMonthly}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrPnlAnnualMonthly.SetParameter(New RParameter("freq", 2))
        ucrPnlAnnualMonthly.AddRadioButton(rdoAnnual, Chr(34) & "annual" & Chr(34))
        ucrPnlAnnualMonthly.AddRadioButton(rdoMonthly, Chr(34) & "monthly" & Chr(34))
        ucrPnlAnnualMonthly.SetRDefault(Chr(34) & "annual" & Chr(34))

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
        clsFrostDays.SetAssignTo("FD")

        clsSummerDays.SetPackageName("climdex.pcic")
        clsSummerDays.SetRCommand("climdex.su")
        clsSummerDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsSummerDays.SetAssignTo("SU")

        clsIcingDays.SetPackageName("climdex.pcic")
        clsIcingDays.SetRCommand("climdex.id")
        clsIcingDays.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsIcingDays.SetAssignTo("ID")

        clsTropicalNights.SetPackageName("climdex.pcic")
        clsTropicalNights.SetRCommand("climdex.tr")
        clsTropicalNights.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsTropicalNights.SetAssignTo("TR")

        clsWarmSpellDI.SetPackageName("climdex.pcic")
        clsWarmSpellDI.SetRCommand("climdex.wsdi")
        clsWarmSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsWarmSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default
        clsWarmSpellDI.SetAssignTo("WSDI")

        clsColdSpellDI.SetPackageName("climdex.pcic")
        clsColdSpellDI.SetRCommand("climdex.csdi")
        clsColdSpellDI.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsColdSpellDI.AddParameter("spells.can.span.years", "FALSE", iPosition:=1) ' r-default
        clsColdSpellDI.SetAssignTo("CSDI")

        clsGrowingSeasonLength.SetPackageName("climdex.pcic")
        clsGrowingSeasonLength.SetRCommand("climdex.gsl")
        clsGrowingSeasonLength.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsGrowingSeasonLength.SetAssignTo("GSL")

        clsMonthlyMaxDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMax.SetRCommand("climdex.txx")
        clsMonthlyMaxDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMaxDailyTMax.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMaxDailyTMax.SetAssignTo("TXx")

        clsMonthlyMaxDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMaxDailyTMin.SetRCommand("climdex.txn")
        clsMonthlyMaxDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMaxDailyTMin.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMaxDailyTMin.SetAssignTo("TNx")

        clsMonthlyMinDailyTMax.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMax.SetRCommand("climdex.tnx")
        clsMonthlyMinDailyTMax.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMinDailyTMax.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMinDailyTMax.SetAssignTo("TXn")

        clsMonthlyMinDailyTMin.SetPackageName("climdex.pcic")
        clsMonthlyMinDailyTMin.SetRCommand("climdex.tnn")
        clsMonthlyMinDailyTMin.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMinDailyTMin.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMinDailyTMin.SetAssignTo("TNn")

        clsTminBelow10Percent.SetPackageName("climdex.pcic")
        clsTminBelow10Percent.SetRCommand("climdex.tn10p")
        clsTminBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTminBelow10Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTminBelow10Percent.SetAssignTo("TN10p")

        clsTmaxBelow10Percent.SetPackageName("climdex.pcic")
        clsTmaxBelow10Percent.SetRCommand("climdex.tx10p")
        clsTmaxBelow10Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTmaxBelow10Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTmaxBelow10Percent.SetAssignTo("TX10p")

        clsTminAbove90Percent.SetPackageName("climdex.pcic")
        clsTminAbove90Percent.SetRCommand("climdex.tn90p")
        clsTminAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTminAbove90Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTminAbove90Percent.SetAssignTo("TN90p")

        clsTmaxAbove90Percent.SetPackageName("climdex.pcic")
        clsTmaxAbove90Percent.SetRCommand("climdex.tx90p")
        clsTmaxAbove90Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsTmaxAbove90Percent.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsTmaxAbove90Percent.SetAssignTo("TX90p")

        clsMeanDiurnalTempRange.SetPackageName("climdex.pcic")
        clsMeanDiurnalTempRange.SetRCommand("climdex.dtr")
        clsMeanDiurnalTempRange.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMeanDiurnalTempRange.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMeanDiurnalTempRange.SetAssignTo("DTR")

        clsMonthlyMax1DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax1DayPrec.SetRCommand("climdex.rx1day")
        clsMonthlyMax1DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMax1DayPrec.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsMonthlyMax1DayPrec.SetAssignTo("Rx1day")

        clsMonthlyMax5DayPrec.SetPackageName("climdex.pcic")
        clsMonthlyMax5DayPrec.SetRCommand("climdex.rx5day")
        clsMonthlyMax5DayPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMonthlyMax5DayPrec.AddParameter("freq", Chr(34) & "annual" & Chr(34), iPosition:=2)
        clsMonthlyMax5DayPrec.SetAssignTo("Rx5day")

        clsSimplePrecII.SetPackageName("climdex.pcic")
        clsSimplePrecII.SetRCommand("climdex.sdii")
        clsSimplePrecII.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsSimplePrecII.SetAssignTo("SDII")

        clsPrecExceed10mm.SetPackageName("climdex.pcic")
        clsPrecExceed10mm.SetRCommand("climdex.r10mm")
        clsPrecExceed10mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed10mm.SetAssignTo("R10mm")

        clsPrecExceed20mm.SetPackageName("climdex.pcic")
        clsPrecExceed20mm.SetRCommand("climdex.r20mm")
        clsPrecExceed20mm.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed20mm.SetAssignTo("R20mm")

        clsPrecExceedSpecifiedA.SetPackageName("climdex.pcic")
        clsPrecExceedSpecifiedA.SetRCommand("climdex.rnnmm")
        clsPrecExceedSpecifiedA.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsPrecExceedSpecifiedA.SetAssignTo("Rnnmm")

        clsMaxDrySpell.SetPackageName("climdex.pcic")
        clsMaxDrySpell.SetRCommand("climdex.cdd")
        clsMaxDrySpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsMaxDrySpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default
        clsMaxDrySpell.SetAssignTo("CDD")

        clsMaxWetSpell.SetPackageName("climdex.pcic")
        clsMaxWetSpell.SetRCommand("climdex.cwd")
        clsMaxWetSpell.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsMaxWetSpell.AddParameter("spells.can.span.years", "TRUE", iPosition:=1) ' r-default
        clsMaxWetSpell.SetAssignTo("CWD")

        clsPrecExceed95Percent.SetPackageName("climdex.pcic")
        clsPrecExceed95Percent.SetRCommand("climdex.r95ptot")
        clsPrecExceed95Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed95Percent.SetAssignTo("R95p")

        clsPrecExceed99Percent.SetPackageName("climdex.pcic")
        clsPrecExceed99Percent.SetRCommand("climdex.r99ptot")
        clsPrecExceed99Percent.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsPrecExceed99Percent.SetAssignTo("R99p")

        clsTotalDailyPrec.SetPackageName("climdex.pcic")
        clsTotalDailyPrec.SetRCommand("climdex.prcptot")
        clsTotalDailyPrec.AddParameter("ci", clsRFunctionParameter:=clsDefaultFunction)
        clsTotalDailyPrec.SetAssignTo("PRCPTOT")

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRWriteDf)
        bResetSubdialog = True
        ParameterCount()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorClimdex.SetRCode(clsRWriteDf, bReset)
        ucrReceiverYear.SetRCode(clsRWriteDf, bReset)
        ucrReceiverMonth.SetRCode(clsRWriteDf, bReset)
        ucrPnlAnnualMonthly.SetRCode(clsRWriteDf, bReset)
        ucrReceiverTmin.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverTmax.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverPrec.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverDate.SetRCode(clsRChar, bReset)
    End Sub

    Private Sub TestOkEnabled() ' check this!
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverTmax.IsEmpty AndAlso Not ucrReceiverTmin.IsEmpty AndAlso Not ucrReceiverPrec.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty Then
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
        ParameterCount()
    End Sub

    Private Sub ucrPnlAnnualMonthly_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnualMonthly.ControlContentsChanged
        If rdoAnnual.Checked Then
            sdgClimdexIndices.grpTminAnnual.Enabled = True
            sdgClimdexIndices.grpTmaxAnnual.Enabled = True
            sdgClimdexIndices.grpTmaxTminAnnual.Enabled = True
            sdgClimdexIndices.grpPrecAnnual.Enabled = True
        ElseIf rdoMonthly.Checked Then
            clsRWriteDfIndicesList.RemoveParameterByName("FD")
            clsRWriteDfIndicesList.RemoveParameterByName("TR")
            clsRWriteDfIndicesList.RemoveParameterByName("CSDI")
            clsRWriteDfIndicesList.RemoveParameterByName("SU")
            clsRWriteDfIndicesList.RemoveParameterByName("ID")
            clsRWriteDfIndicesList.RemoveParameterByName("GSL")
            clsRWriteDfIndicesList.RemoveParameterByName("SDII")
            clsRWriteDfIndicesList.RemoveParameterByName("R10mm")
            clsRWriteDfIndicesList.RemoveParameterByName("R20mm")
            clsRWriteDfIndicesList.RemoveParameterByName("Rnnmm")
            clsRWriteDfIndicesList.RemoveParameterByName("WSDI")
            clsRWriteDfIndicesList.RemoveParameterByName("CDD")
            clsRWriteDfIndicesList.RemoveParameterByName("CWD")
            clsRWriteDfIndicesList.RemoveParameterByName("R95p")
            clsRWriteDfIndicesList.RemoveParameterByName("R99p")
            clsRWriteDfIndicesList.RemoveParameterByName("PRCPTOT")
            sdgClimdexIndices.grpTminAnnual.Enabled = False
            sdgClimdexIndices.grpTmaxAnnual.Enabled = False
            sdgClimdexIndices.grpTmaxTminAnnual.Enabled = False
            sdgClimdexIndices.grpPrecAnnual.Enabled = False
        End If
    End Sub

    Private Sub ucrChkSave_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlContentsChanged
        If ucrChkSave.Checked Then
            bSaveIndex = True
        Else
            bSaveIndex = False
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ParameterCount()
        lblSelectedIndices.Text = clsRWriteDfIndicesList.iParameterCount
        lblSelectedIndices.ForeColor = Color.Red
        If rdoAnnual.Checked Then
            lblTotalIndices.Text = 27
            lblTotalIndices.ForeColor = Color.Green
        Else
            lblTotalIndices.Text = 11
            lblTotalIndices.ForeColor = Color.Green
        End If

    End Sub

    Private Sub EnableGroupBoxes()
        If ucrReceiverPrec.IsEmpty Then
            sdgClimdexIndices.tbpPrecipitation.Enabled = False
        Else
            sdgClimdexIndices.tbpPrecipitation.Enabled = True
        End If
        If ucrReceiverTmax.IsEmpty AndAlso ucrReceiverTmin.IsEmpty Then
            sdgClimdexIndices.tbpTemperature.Enabled = False
        Else
            sdgClimdexIndices.tbpTemperature.Enabled = True
        End If
    End Sub

    Private Sub ucrPnlAnnualMonthly_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnualMonthly.ControlValueChanged
        ParameterCount()
    End Sub

    Private Sub ucrReceiverPrec_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrec.ControlValueChanged, ucrReceiverTmin.ControlValueChanged, ucrReceiverTmax.ControlValueChanged
        EnableGroupBoxes()
    End Sub
End Class