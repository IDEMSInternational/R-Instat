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

Imports instat.Translations
Public Class dlgDisplayDailyClimaticData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgDisplayDailyClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrReceiverStation.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverElements.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverXaxis.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYaxisLower.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYaxisUpper.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStation.SetMeAsReceiver()

        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverXaxis.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverElements.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoBoth)

        ucrChkMissingRugPlot.SetText("Missing Rug Plot")
        ucrChkValuesOutsideYrange.SetText("Values Outside Y Range")

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDisplayDailyClimaticData.Reset()
        'For now
        rdoGraph.Enabled = False
        rdoBoth.Enabled = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class