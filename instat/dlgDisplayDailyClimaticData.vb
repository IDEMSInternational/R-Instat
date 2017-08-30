﻿' R- Instat
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
Public Class dlgDisplayDailyData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSummaryTable, clsDisplayDailyGraph As RFunction

    Private Sub dlgDisplayDailyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_name"))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsString()

        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverStations.SetParameter(New RParameter("station_col"))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.bWithQuotes = False

        ucrReceiverYear.SetParameter(New RParameter("year_col"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.bWithQuotes = False

        ucrReceiverDate.SetParameter(New RParameter("climatic_element"))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.bWithQuotes = False

        ucrReceiverDayOfYear.SetParameter(New RParameter("doy_col"))
        ucrReceiverDayOfYear.SetParameterIsString()
        ucrReceiverDayOfYear.bWithQuotes = False

        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverElements.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverElements.SetParameter(New RParameter("x", 0))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.bWithQuotes = False

        ucrNudUpperYaxis.SetParameter(New RParameter("upper_limit"))

        ucrInputBarColour.SetParameter(New RParameter("bar_colour"))

        ucrInputRugColour.SetParameter(New RParameter("rug_colour"))

        ucrReceiverDayOfYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDayOfYear.SetClimaticType("doy")
        ucrReceiverDayOfYear.bAutoFill = True

        ucrNudUpperYaxis.SetLinkedDisplayControl(lblYaxisUpper)
        ucrReceiverDayOfYear.SetLinkedDisplayControl(lblDayOfTheYear)

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.SetLinkedDisplayControl(grpGraph)
    End Sub

    Private Sub SetDefaults()
        clsSummaryTable = New RFunction
        clsDisplayDailyGraph = New RFunction
        ucrSelectorDisplayDailyClimaticData.Reset()

        clsSummaryTable.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDisplayDailyGraph.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyGraph)
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        ucrReceiverDate.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverStations.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverDayOfYear.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverYear.SetRCode(clsDisplayDailyGraph, bReset)
        ucrSelectorDisplayDailyClimaticData.SetRCode(clsDisplayDailyGraph, bReset)
        ucrInputRugColour.SetRCode(clsDisplayDailyGraph, bReset)
        ucrInputBarColour.SetRCode(clsDisplayDailyGraph, bReset)
        ucrNudUpperYaxis.SetRCode(clsDisplayDailyGraph, bReset)
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