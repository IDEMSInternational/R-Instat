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
Public Class dlgClimaticNCMPCountRecords
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private bSubDialogOKEnabled As Boolean = True

    Private Sub dlgClimaticNCMPCountRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctResolution As New Dictionary(Of String, String)

        ucrSelectorForA2.SetParameter(New RParameter("a2", 0))
        ucrSelectorForA2.SetParameterIsrfunction()
        ucrSelectorForA2.ucrAvailableDataFrames.lblDataFrame.Text = "Indices Data Frame:"

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForA2
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.SetParameter(New RParameter("a2_year", 2))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorForA2
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 3))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorForA2
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrSelectorForA4.SetParameter(New RParameter("a4", 4))
        ucrSelectorForA4.SetParameterIsRFunction()
        ucrSelectorForA4.lblDataFrame.Text = "Region Average Data Frame:"

        ucrSaveCountRecords.SetSaveTypeAsDataFrame()
        ucrSaveCountRecords.SetLabelText("New Data Frame Name:")
        ucrSaveCountRecords.SetIsTextBox()
        ucrSaveCountRecords.SetPrefix("count_records")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorForA2.Reset()
        ucrSelectorForA4.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrSaveCountRecords.Reset()
        bResetSubdialog = True
        bSubDialogOKEnabled = False

        clsDefaultFunction.SetRCommand("p6_count_records")
        clsDefaultFunction.SetAssignTo(ucrSaveCountRecords.GetText(), strTempDataframe:=ucrSaveCountRecords.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverStation.IsEmpty OrElse ucrReceiverYear.IsEmpty OrElse ucrReceiverMonth.IsEmpty OrElse Not ucrSaveCountRecords.IsComplete() OrElse Not bSubDialogOKEnabled Then
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrSaveCountRecords.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class