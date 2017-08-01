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
Public Class dlgDisplayDailyData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSummaryTable As RFunction
    Private clsDailyClimaticData As RFunction
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

        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_names"))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsrfunction()

        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverStations.SetParameter(New RParameter("station"))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.bWithQuotes = False

        ucrReceiverYear.SetParameter(New RParameter("year"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.bWithQuotes = False

        ucrReceiverDate.SetParameter(New RParameter("rain"))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.bWithQuotes = False

        ucrReceiverStations.SetParameter(New RParameter("doy"))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.bWithQuotes = False

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

        ucrReceiverXaxis.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverXaxis.SetClimaticType("doy")
        ucrReceiverXaxis.bAutoFill = True

        ucrNudUpperYaxis.SetLinkedDisplayControl(lblYaxisUpper)
        ucrNudLowerYaxis.SetLinkedDisplayControl(lblYaxisLower)
        ucrReceiverXaxis.SetLinkedDisplayControl(lblXaxis)

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrNudLowerYaxis, ucrNudUpperYaxis, ucrReceiverXaxis, ucrChkMissingRugPlot, ucrChkValuesOutsideYrange}, {rdoGraph}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.SetLinkedDisplayControl(grpGraph)
        ucrChkMissingRugPlot.SetLinkedDisplayControl(grpGraph)
        ucrChkMissingRugPlot.SetText("Indicate Missing Rug Plot")
        ucrChkValuesOutsideYrange.SetText("Indicate  Values Outside Y Range")

    End Sub

    Private Sub SetDefaults()
        clsSummaryTable = New RFunction
        clsDailyClimaticData = New RFunction
        ucrSelectorDisplayDailyClimaticData.Reset()

        clsSummaryTable.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDailyClimaticData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$daily_climatic_data")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDailyClimaticData)
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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