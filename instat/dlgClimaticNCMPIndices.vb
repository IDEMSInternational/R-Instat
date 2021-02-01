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
Public Class dlgClimaticNCMPIndices
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private bSubDialogOKEnabled As Boolean = True

    Private Sub dlgClimaticNCMPIndices_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorIndices.SetParameter(New RParameter("df", 0))
        ucrSelectorIndices.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorIndices
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 2))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorIndices
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrReceiverRain.SetParameter(New RParameter("precip", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorIndices
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True

        ucrReceiverTmin.SetParameter(New RParameter("tmin", 4))
        ucrReceiverTmin.SetParameterIsString()
        ucrReceiverTmin.Selector = ucrSelectorIndices
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.bAutoFill = True

        ucrReceiverTmax.SetParameter(New RParameter("tmax", 5))
        ucrReceiverTmax.SetParameterIsString()
        ucrReceiverTmax.Selector = ucrSelectorIndices
        ucrReceiverTmax.SetClimaticType("temp_max")
        ucrReceiverTmax.bAutoFill = True

        grpOptions.Visible = False

        ucrNudQCT.SetParameter(New RParameter("qct", 6))
        ucrNudQCT.SetMinMax(0, 2)
        ucrNudQCT.SetRDefault(0)

        ucrNudQCPR.SetParameter(New RParameter("qcpr", 7))
        ucrNudQCPR.SetMinMax(0, 2)
        ucrNudQCPR.SetRDefault(0)

        ucrNudNYBR.SetParameter(New RParameter("nybr", 8))
        ucrNudNYBR.SetMinMax(1900, 2000)  ' TODO: suitable start/end years.
        ucrNudNYBR.SetRDefault(1981)

        ucrNudNYER.SetParameter(New RParameter("nyer", 9))
        ucrNudNYER.SetMinMax(2000, 2020) ' TODO: how to set as current year - 1
        ucrNudNYER.SetRDefault(2010)

        ' ucrsave
        ucrSaveIndices.SetSaveTypeAsDataFrame()
        ucrSaveIndices.SetLabelText("New Data Frame Name:")
        ucrSaveIndices.SetIsTextBox()
        ucrSaveIndices.SetPrefix("indices")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorIndices.Reset()
        ucrSaveIndices.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        bSubDialogOKEnabled = False
        bResetSubdialog = True

        clsDefaultFunction.SetRCommand("p2_indices")
        clsDefaultFunction.SetAssignTo(ucrSaveIndices.GetText(), strTempDataframe:=ucrSaveIndices.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverStation.IsEmpty OrElse ucrReceiverDate.IsEmpty OrElse ucrReceiverRain.IsEmpty OrElse ucrReceiverTmax.IsEmpty OrElse ucrReceiverTmin.IsEmpty OrElse ucrNudQCT.GetText = "" OrElse ucrNudQCPR.GetText = "" OrElse ucrNudNYBR.GetText = "" OrElse ucrNudNYER.GetText = "" OrElse Not ucrSaveIndices.IsComplete OrElse Not bSubDialogOKEnabled Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub cmdStationMetadata_click(sender As Object, e As EventArgs) Handles cmdStationMetadata.Click
        sdgClimaticNCMPMetadata.SetRFunction(clsDefaultFunction, bReset:=bResetSubdialog)
        bResetSubdialog = True
        sdgClimaticNCMPMetadata.ShowDialog()
        bSubDialogOKEnabled = sdgClimaticNCMPMetadata.bOKEnabled
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrNudQCT.ControlContentsChanged, ucrNudQCPR.ControlContentsChanged, ucrNudNYBR.ControlContentsChanged, ucrNudNYER.ControlContentsChanged, ucrSaveIndices.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class