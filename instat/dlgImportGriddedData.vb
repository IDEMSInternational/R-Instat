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
Public Class dlgImportGriddedData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction As New RFunction
    Private dctDownloadPairs, dctFiles As New Dictionary(Of String, String)
    Private Sub dlgImportGriddedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        dctDownloadPairs = New Dictionary(Of String, String)
        'ucrBase.iHelpTopicID = 

        ucrInputDataName.SetParameter(New RParameter("data_names", 0))
        ucrInputDataName.clsParameter.bIncludeArgumentName = False

        ucrInputDownloadFrom.SetParameter(New RParameter("download_from", 1))
        dctDownloadPairs.Add("CHIRPS_V2P0", Chr(34) & "CHIRPS_V2P0" & Chr(34))
        dctDownloadPairs.Add("TAMSAT", Chr(34) & "TAMSAT" & Chr(34))
        dctDownloadPairs.Add("NOAA_ARC2", Chr(34) & "NOAA_ARC2" & Chr(34))
        dctDownloadPairs.Add("NOAA_RFE2", Chr(34) & "NOAA_RFE2" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH", Chr(34) & "NOAA_CMORPH" & Chr(34))
        dctDownloadPairs.Add("NASA_TRMM_3B42", Chr(34) & "NASA_TRMM_3B42" & Chr(34))
        ucrInputDownloadFrom.SetItems(dctDownloadPairs)



        ucrNudMinLon.SetParameter(New RParameter("X1", 3))
        ucrNudMinLon.SetMinMax(-180, 180)
        ucrNudMinLon.DecimalPlaces = 2
        ucrNudMinLon.Increment = 0.01
        ucrNudMinLon.SetLinkedDisplayControl(lblMinLon)
        ucrNudMaxLon.SetParameter(New RParameter("X2", 4))
        ucrNudMaxLon.SetMinMax(-180, 180)
        ucrNudMaxLon.DecimalPlaces = 2
        ucrNudMaxLon.Increment = 0.01
        ucrNudMaxLon.SetLinkedDisplayControl(lblMaxLon)
        ucrNudMinLat.SetParameter(New RParameter("Y1", 5))
        ucrNudMinLat.SetMinMax(-50, 50)
        ucrNudMinLat.DecimalPlaces = 2
        ucrNudMinLat.Increment = 0.01
        ucrNudMinLat.SetLinkedDisplayControl(lblMinLat)
        ucrNudMaxLat.SetParameter(New RParameter("Y2", 6))
        ucrNudMaxLat.SetMinMax(-50, 50)
        ucrNudMaxLat.DecimalPlaces = 2
        ucrNudMaxLat.Increment = 0.01
        ucrNudMaxLat.SetLinkedDisplayControl(lblMaxLat)

    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction
        'ucrInputDataFile = New ucrInputComboBox
        dctFiles = New Dictionary(Of String, String)
        ucrInputDataFile.SetText("")
        ucrInputDataFile.SetParameter(New RParameter("data_file", 2))
        dctFiles.Add("Daily_0p05", Chr(34) & "Daily_0p05" & Chr(34))
        dctFiles.Add("Daily_0p25", Chr(34) & "Daily_0p25" & Chr(34))
        dctFiles.Add("Daily Improved 0p05(CHIRPS)", Chr(34) & "Daily_improved_0p05" & Chr(34))
        dctFiles.Add("Daily Improved 0p25(CHIRPS)", Chr(34) & "Daily_improved_0p25" & Chr(34))
        dctFiles.Add("Dekad(CHIRPS)", Chr(34) & "Dekad" & Chr(34))
        dctFiles.Add("Monthly c8113(CHIRPS)", Chr(34) & "Monthly_c8113" & Chr(34))
        dctFiles.Add("Monthly deg1p0(CHIRPS)", Chr(34) & "Monthly_deg1p0" & Chr(34))
        dctFiles.Add("Monthly NMME deg1p0(CHIRPS)", Chr(34) & "Monthly_NMME_deg1p0" & Chr(34))
        dctFiles.Add("Monthly Precipitation(CHIRPS)", Chr(34) & "Monthly_prcp" & Chr(34))
        ucrInputDataFile.SetItems(dctFiles, bClearExisting:=False)


        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_iri")
        clsRDefaultFunction.AddParameter("download_from", Chr(34) & "CHIRPS_V2P0" & Chr(34))
        clsRDefaultFunction.AddParameter("data_file", Chr(34) & "Daily_0p05" & Chr(34))
        clsRDefaultFunction.AddParameter("data_names", "CHIRPS")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)

    End Sub

    Private Sub TestOkEnabled()
        'If (ucrInputDataName.Text <> "" AndAlso ucrInputLocDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" AndAlso (Not ucrInputDataName.Text = ucrInputLocDataName.Text)) Then
        If (ucrInputDataName.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub nudControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDownloadFrom.ControlContentsChanged
        DataSettings()
    End Sub

    Private Sub DataSettings()
        If ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS_V2P0" Then
            ucrNudMinLon.SetMinMax(-180, 180)
            ucrNudMaxLon.SetMinMax(-180, 180)
            ucrNudMinLat.SetMinMax(-50, 50)
            ucrNudMaxLat.SetMinMax(-50, 50)
            'ucrInputDataFile = New ucrInputComboBox
            'clsRDefaultFunction = New RFunction
            dctFiles = New Dictionary(Of String, String)
            ucrInputDataFile.SetParameter(New RParameter("data_file", 2))
            dctFiles.Add("Daily_0p05", Chr(34) & "Daily_0p05" & Chr(34))
            dctFiles.Add("Daily_0p25", Chr(34) & "Daily_0p25" & Chr(34))
            dctFiles.Add("Daily_Improved_0p05", Chr(34) & "Daily_improved_0p05" & Chr(34))
            dctFiles.Add("Daily Improved 0p25(CHIRPS)", Chr(34) & "Daily_improved_0p25" & Chr(34))
            dctFiles.Add("Dekad(CHIRPS)", Chr(34) & "Dekad" & Chr(34))
            dctFiles.Add("Monthly c8113(CHIRPS)", Chr(34) & "Monthly_c8113" & Chr(34))
            dctFiles.Add("Monthly deg1p0(CHIRPS)", Chr(34) & "Monthly_deg1p0" & Chr(34))
            dctFiles.Add("Monthly NMME deg1p0(CHIRPS)", Chr(34) & "Monthly_NMME_deg1p0" & Chr(34))
            dctFiles.Add("Monthly Precipitation(CHIRPS)", Chr(34) & "Monthly_prcp" & Chr(34))
            ucrInputDataFile.SetItems(dctFiles)
            ucrInputDataFile.cboInput.SelectedItem = "Daily_0p05"
            'ucrInputDataFile.UpdateControl()
        Else
            ucrNudMinLon.SetMinMax(-20, 55)
            ucrNudMaxLon.SetMinMax(-20, 55)
            ucrNudMinLat.SetMinMax(-40, 40)
            ucrNudMaxLat.SetMinMax(-40, 40)
            If ucrInputDownloadFrom.cboInput.SelectedItem = "TAMSAT" Then
                'clsRDefaultFunction = New RFunction
                'ucrInputDataFile = New ucrInputComboBox
                dctFiles = New Dictionary(Of String, String)
                'dctFiles.Clear()
                ucrInputDataFile.SetParameter(New RParameter("data_file", 2))
                dctFiles.Add("Rainfall_Estimates", Chr(34) & "Rainfall_estimates" & Chr(34))
                dctFiles.Add("Reconstructed Rainfall Anomaly(TAMSAT)", Chr(34) & "Reconstructed_rainfall_anomaly" & Chr(34))
                dctFiles.Add("Sahel Dry Mask(TAMSAT)", Chr(34) & "Sahel_dry_mask" & Chr(34))
                dctFiles.Add("Standard Precipitation Index 1-dekad(TAMSAT)", Chr(34) & "SPI_1_dekad" & Chr(34))
                'monthly,climatology and TAMSAT RFE 0p1 are yet to be implemented.
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Rainfall_Estimates"
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS" Then
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS" Then
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS" Then
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS" Then
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "CHIRPS" Then
            End If
        End If
        'SetRCodeForControls(False)
    End Sub
End Class