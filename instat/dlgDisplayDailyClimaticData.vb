﻿' Instat-R
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

        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrReceiverElements.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverElements.SetParameter(New RParameter("x", 0))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.bWithQuotes = False

        ucrReceiverXaxis.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverXaxis.SetClimaticType("doy")
        ucrReceiverXaxis.bAutoFill = True

        ucrNudUpperYaxis.SetLinkedDisplayControl(lblYaxisUpper)
        ucrNudLowerYaxis.SetLinkedDisplayControl(lblYaxisLower)
        ucrReceiverXaxis.SetLinkedDisplayControl(lblXaxis)

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoBoth)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrNudLowerYaxis, ucrNudUpperYaxis, ucrReceiverXaxis, ucrChkMissingRugPlot, ucrChkValuesOutsideYrange}, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.SetLinkedDisplayControl(grpGraph)
        ucrChkMissingRugPlot.SetLinkedDisplayControl(grpGraph)
        ucrChkMissingRugPlot.SetText("Indicate Missing Rug Plot")
        ucrChkValuesOutsideYrange.SetText("Indicate  Values Outside Y Range")

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDisplayDailyClimaticData.Reset()
        rdoTable.Enabled = False 'for now

    End Sub

    Private Sub SetRCodeForControls(bReset As Object)

    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class