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
    Private clsClimdex As New RFunction
    Private clsIndices As New RFunction
    Private clsBaseRange As New RFunction
    Private clsMaxMissingDays As New RFunction
    Private clsTempQTiles As New RFunction
    Private clsPrecQTiles As New RFunction
    Private clsAddClimexIndices As New RFunction

    Private Sub dlgClimdex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 190

        ucrSelectorClimdex.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimdex.SetParameterIsString()

        ucrReceiverStation.Selector = ucrSelectorClimdex
        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorClimdex
        ucrReceiverDate.SetParameter(New RParameter("date", 2))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorClimdex
        ucrReceiverYear.SetParameter(New RParameter("year", 3))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.Selector = ucrSelectorClimdex
        ucrReceiverMonth.SetParameter(New RParameter("month", 4))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverPrec.Selector = ucrSelectorClimdex
        ucrReceiverPrec.SetParameter(New RParameter("prec", 5))
        ucrReceiverPrec.SetParameterIsString()
        ucrReceiverPrec.SetClimaticType("rain")
        ucrReceiverPrec.SetIncludedDataTypes({"numeric"})
        ucrReceiverPrec.bAutoFill = True

        ucrReceiverTmax.Selector = ucrSelectorClimdex
        ucrReceiverTmax.SetParameter(New RParameter("tmax", 6))
        ucrReceiverTmax.SetParameterIsString()
        ucrReceiverTmax.SetClimaticType("temp_max")
        ucrReceiverTmax.SetIncludedDataTypes({"numeric"})
        ucrReceiverTmax.bAutoFill = True

        ucrReceiverTmin.Selector = ucrSelectorClimdex
        ucrReceiverTmin.SetParameter(New RParameter("tmin", 7))
        ucrReceiverTmin.SetParameterIsString()
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.SetIncludedDataTypes({"numeric"})
        ucrReceiverTmin.bAutoFill = True

        ucrPnlAnnualMonthly.SetParameter(New RParameter("freq", 2))
        ucrPnlAnnualMonthly.AddRadioButton(rdoAnnual, Chr(34) & "annual" & Chr(34))
        ucrPnlAnnualMonthly.AddRadioButton(rdoMonthly, Chr(34) & "monthly" & Chr(34))
        ucrPnlAnnualMonthly.SetRDefault(Chr(34) & "annual" & Chr(34))
        ucrPnlAnnualMonthly.AddToLinkedControls({ucrReceiverMonth}, {rdoMonthly}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSave.SetText("Save Indices")
        ucrChkSave.bChangeParameterValue = False
    End Sub

    Private Sub SetDefaults()
        clsClimdex = New RFunction
        clsIndices = New RFunction
        clsBaseRange = New RFunction
        clsMaxMissingDays = New RFunction
        clsTempQTiles = New RFunction
        clsPrecQTiles = New RFunction

        ucrSelectorClimdex.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrChkSave.Checked = True

        clsClimdex.SetRCommand("climdex")

        clsClimdex.AddParameter("indices", clsRFunctionParameter:=clsIndices, iPosition:=8)
        clsClimdex.AddParameter("base.range", clsRFunctionParameter:=clsBaseRange, iPosition:=11)
        clsClimdex.AddParameter("temp.qtiles", clsRFunctionParameter:=clsTempQTiles, iPosition:=14)
        clsClimdex.AddParameter("prec.qtiles", clsRFunctionParameter:=clsPrecQTiles, iPosition:=15)
        clsClimdex.AddParameter("max.missing.days", clsRFunctionParameter:=clsMaxMissingDays, iPosition:=16)
        clsClimdex.SetAssignTo("ci")

        clsIndices.SetRCommand("c")

        clsMaxMissingDays.SetRCommand("c")
        clsMaxMissingDays.AddParameter("annual", 15, iPosition:=0)
        clsMaxMissingDays.AddParameter("monthly", 3, iPosition:=1)

        clsBaseRange.SetRCommand("c")
        clsBaseRange.AddParameter("0", 1961, bIncludeArgumentName:=False, iPosition:=0)
        clsBaseRange.AddParameter("1", 1990, bIncludeArgumentName:=False, iPosition:=1)

        clsTempQTiles.SetRCommand("c")
        clsTempQTiles.AddParameter("0", "0.1, 0.9", bIncludeArgumentName:=False, iPosition:=0)

        clsPrecQTiles.SetRCommand("c")
        clsPrecQTiles.AddParameter("0", "0.95, 0.99", bIncludeArgumentName:=False, iPosition:=0)

        ' For the sub dialog
        clsAddClimexIndices.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_climdex_indices")
        clsAddClimexIndices.AddParameter("climdex_output", clsRFunctionParameter:=clsClimdex, iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAddClimexIndices)
        bResetSubdialog = True
        ParameterCount()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlAnnualMonthly.AddAdditionalCodeParameterPair(clsAddClimexIndices, New RParameter("freq", iNewPosition:=2), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsAddClimexIndices, New RParameter("station", iNewPosition:=3), iAdditionalPairNo:=1)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsAddClimexIndices, New RParameter("year", iNewPosition:=4), iAdditionalPairNo:=1)
        ucrReceiverMonth.AddAdditionalCodeParameterPair(clsAddClimexIndices, New RParameter("month", iNewPosition:=5), iAdditionalPairNo:=1)

        ucrPnlAnnualMonthly.SetRCode(clsClimdex, bReset)
        ucrSelectorClimdex.SetRCode(clsAddClimexIndices, bReset)
        ucrReceiverStation.SetRCode(clsClimdex, bReset)
        ucrReceiverDate.SetRCode(clsClimdex, bReset)
        ucrReceiverYear.SetRCode(clsClimdex, bReset)
        ucrReceiverMonth.SetRCode(clsClimdex, bReset)
        ucrReceiverPrec.SetRCode(clsClimdex, bReset)
        ucrReceiverTmax.SetRCode(clsClimdex, bReset)
        ucrReceiverTmin.SetRCode(clsClimdex, bReset)

        SetClimdexData()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverTmax.IsEmpty AndAlso Not ucrReceiverTmin.IsEmpty AndAlso Not ucrReceiverPrec.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso (rdoAnnual.Checked OrElse Not ucrReceiverMonth.IsEmpty) AndAlso clsIndices.iParameterCount > 0 Then
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
        sdgClimdexIndices.SetRCode(clsNewClimdex:=clsClimdex, clsNewIndices:=clsIndices, clsNewMaxMissingDays:=clsMaxMissingDays, clsNewBaseRange:=clsBaseRange, clsNewTempQTiles:=clsTempQTiles, clsNewPrecQTiles:=clsPrecQTiles, bResetSubdialog)
        bResetSubdialog = False
        sdgClimdexIndices.ShowDialog()
        ParameterCount()
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlAnnualMonthly_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnualMonthly.ControlContentsChanged
        If rdoAnnual.Checked Then
            sdgClimdexIndices.grpTminAnnual.Enabled = True
            sdgClimdexIndices.grpTmaxAnnual.Enabled = True
            sdgClimdexIndices.grpTmaxTminAnnual.Enabled = True
            sdgClimdexIndices.grpPrecAnnual.Enabled = True
        ElseIf rdoMonthly.Checked Then
            clsIndices.RemoveParameterByName("fd")
            clsIndices.RemoveParameterByName("tr")
            clsIndices.RemoveParameterByName("csdi")
            clsIndices.RemoveParameterByName("su")
            clsIndices.RemoveParameterByName("id")
            clsIndices.RemoveParameterByName("gsl")
            clsIndices.RemoveParameterByName("sdii")
            clsIndices.RemoveParameterByName("r10mm")
            clsIndices.RemoveParameterByName("r20mm")
            clsIndices.RemoveParameterByName("rnnmm")
            clsIndices.RemoveParameterByName("wsdi")
            clsIndices.RemoveParameterByName("cdd")
            clsIndices.RemoveParameterByName("cwd")
            clsIndices.RemoveParameterByName("r95p")
            clsIndices.RemoveParameterByName("r99p")
            clsIndices.RemoveParameterByName("prcptot")
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverPrec.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrPnlAnnualMonthly.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ParameterCount()
        lblSelectedIndices.Text = clsIndices.iParameterCount
        If rdoAnnual.Checked Then
            lblTotalIndices.Text = 27
        Else
            lblTotalIndices.Text = 11
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

    Private Sub ucrSelectorClimdex_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimdex.ControlValueChanged
        ' This is done manually since we need the data both as a string and as a variable in the two functions.
        SetClimdexData()
    End Sub

    Private Sub SetClimdexData()
        clsClimdex.AddParameter("data", clsRFunctionParameter:=ucrSelectorClimdex.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub
End Class