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
Imports System.IO
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

        ucrBase.iHelpTopicID = 526

        'temporary until working
        cmdBrowse.Enabled = False
        ucrInputExportFile.Enabled = False

        ucrInputDownloadFrom.SetParameter(New RParameter("download_from", 0))
        dctDownloadPairs.Add("CHIRPS_V2P0", Chr(34) & "CHIRPS_V2P0" & Chr(34))
        dctDownloadPairs.Add("TAMSAT", Chr(34) & "TAMSAT" & Chr(34))
        dctDownloadPairs.Add("NOAA_ARC2", Chr(34) & "NOAA_ARC2" & Chr(34))
        dctDownloadPairs.Add("NOAA_RFE2", Chr(34) & "NOAA_RFE2" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_DAILY", Chr(34) & "NOAA_CMORPH_DAILY" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_3HOURLY", Chr(34) & "NOAA_CMORPH_3HOURLY" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_DAILY_CALCULATED", Chr(34) & "NOAA_CMORPH_DAILY_CALCULATED" & Chr(34))
        'dctDownloadPairs.Add("NOAA_CMORPH_PENTAD", Chr(34) & "NOAA_CMORPH_PENTAD" & Chr(34))
        'dctDownloadPairs.Add("NOAA_CMORPH_V0PX", Chr(34) & "NOAA_CMORPH_V0PX" & Chr(34))
        dctDownloadPairs.Add("NASA_TRMM_3B42", Chr(34) & "NASA_TRMM_3B42" & Chr(34))
        ucrInputDownloadFrom.SetItems(dctDownloadPairs)

        ucrInputDataFile.SetParameter(New RParameter("data_file", 1))

        ucrInputMainDataName.SetParameter(New RParameter("data_frame_name", 2))
        ucrInputMainDataName.SetParameterIncludeArgumentName(False)
        ucrInputLocDataName.SetParameter(New RParameter("location_data_name", 3))
        ucrInputLocDataName.SetParameterIncludeArgumentName(False)

        'ucrInputExportFile.SetParameter(New RParameter("path", 4))

        ucrPnlGetArea.SetParameter(New RParameter("get_area_point", 5))
        ucrPnlGetArea.AddRadioButton(rdoArea, Chr(34) & "area" & Chr(34))
        ucrPnlGetArea.AddRadioButton(rdoPoint, Chr(34) & "point" & Chr(34))
        ucrPnlGetArea.SetRDefault(Chr(34) & "area" & Chr(34))

        ucrPnlGetArea.AddToLinkedControls({ucrNudMaxLat, ucrNudMaxLon}, {rdoArea}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudMinLon.SetParameter(New RParameter("X1", 6))
        ucrNudMinLon.SetMinMax(-180, 180)
        ucrNudMinLon.DecimalPlaces = 4
        ucrNudMinLon.Increment = 0.0001
        ucrNudMinLon.SetLinkedDisplayControl(lblMinLon)
        ucrNudMaxLon.SetParameter(New RParameter("X2", 7))
        ucrNudMaxLon.SetMinMax(-180, 180)
        ucrNudMaxLon.DecimalPlaces = 4
        ucrNudMaxLon.Increment = 0.0001
        ucrNudMaxLon.SetLinkedDisplayControl(lblMaxLon)
        ucrNudMinLat.SetParameter(New RParameter("Y1", 8))
        ucrNudMinLat.SetMinMax(-50, 50)
        ucrNudMinLat.DecimalPlaces = 4
        ucrNudMinLat.Increment = 0.0001
        ucrNudMinLat.SetLinkedDisplayControl(lblMinLat)
        ucrNudMaxLat.SetParameter(New RParameter("Y2", 9))
        ucrNudMaxLat.SetMinMax(-50, 50)
        ucrNudMaxLat.DecimalPlaces = 4
        ucrNudMaxLat.Increment = 0.0001
        ucrNudMaxLat.SetLinkedDisplayControl(lblMaxLat)
    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction

        'ucrInputExportFile.IsReadOnly = True
        'ucrInputExportFile.SetName("")

        dctFiles = New Dictionary(Of String, String)
        dctFiles.Add("Daily 0p05", Chr(34) & "daily_0p05" & Chr(34))
        dctFiles.Add("Daily 0p25", Chr(34) & "daily_0p25" & Chr(34))
        dctFiles.Add("Daily Improved 0p05", Chr(34) & "daily_improved_0p05" & Chr(34))
        dctFiles.Add("Daily Improved 0p25", Chr(34) & "daily_improved_0p25" & Chr(34))
        dctFiles.Add("Dekad", Chr(34) & "dekad" & Chr(34))
        dctFiles.Add("Monthly c8113", Chr(34) & "monthly_c8113" & Chr(34))
        dctFiles.Add("Monthly deg1p0", Chr(34) & "monthly_deg1p0" & Chr(34))
        dctFiles.Add("Monthly NMME deg1p0", Chr(34) & "monthly_NMME_deg1p0" & Chr(34))
        dctFiles.Add("Monthly Precipitation", Chr(34) & "monthly_prcp" & Chr(34))
        ucrInputDataFile.SetItems(dctFiles)

        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_iri")
        clsRDefaultFunction.AddParameter("download_from", Chr(34) & "CHIRPS_V2P0" & Chr(34))
        clsRDefaultFunction.AddParameter("data_file", Chr(34) & "daily_0p05" & Chr(34))
        clsRDefaultFunction.AddParameter("data_frame_name", "IRI_Library_Data")
        clsRDefaultFunction.AddParameter("location_data_name", "Lat_Lon_Data")
        clsRDefaultFunction.AddParameter("path", Chr(34) & System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_IRI_Download").Replace("\", "/") & Chr(34))
        'opted to set this as default location since it has data for all sources
        clsRDefaultFunction.AddParameter("X1", 10)
        clsRDefaultFunction.AddParameter("X2", 10.5)
        clsRDefaultFunction.AddParameter("Y1", 10)
        clsRDefaultFunction.AddParameter("Y2", 10.5)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
    End Sub

    Private Sub TestOkEnabled()
        'download from and datafile should be added to test ok
        If (ucrInputMainDataName.Text <> "") Then
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputMainDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub pnlControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlGetArea.ControlContentsChanged
        If rdoArea.Checked Then
            lblMinLat.Text = "Minimum Latitude:"
            lblMinLon.Text = "Minimum Longitude:"
        ElseIf rdoPoint.Checked Then
            lblMinLat.Text = "Latitude:"
            lblMinLon.Text = "Longitude:"
        End If
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
            dctFiles = New Dictionary(Of String, String)
            dctFiles.Add("Daily 0p05", Chr(34) & "daily_0p05" & Chr(34))
            dctFiles.Add("Daily 0p25", Chr(34) & "daily_0p25" & Chr(34))
            dctFiles.Add("Daily Improved 0p05", Chr(34) & "daily_improved_0p05" & Chr(34))
            dctFiles.Add("Daily Improved 0p25", Chr(34) & "daily_improved_0p25" & Chr(34))
            dctFiles.Add("Dekad", Chr(34) & "Dekad" & Chr(34))
            dctFiles.Add("Monthly c8113", Chr(34) & "monthly_c8113" & Chr(34))
            dctFiles.Add("Monthly deg1p0", Chr(34) & "monthly_deg1p0" & Chr(34))
            dctFiles.Add("Monthly NMME deg1p0", Chr(34) & "monthly_NMME_deg1p0" & Chr(34))
            dctFiles.Add("Monthly Precipitation", Chr(34) & "monthly_prcp" & Chr(34))
            ucrInputDataFile.SetItems(dctFiles)
            ucrInputDataFile.cboInput.SelectedItem = "Daily 0p05"
        Else
            ucrNudMinLon.SetMinMax(-20, 55)
            ucrNudMaxLon.SetMinMax(-20, 55)
            ucrNudMinLat.SetMinMax(-40, 40)
            ucrNudMaxLat.SetMinMax(-40, 40)
            If ucrInputDownloadFrom.cboInput.SelectedItem = "TAMSAT" Then
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Rainfall Estimates", Chr(34) & "rainfall_estimates" & Chr(34))
                dctFiles.Add("Reconstructed Rainfall Anomaly", Chr(34) & "reconstructed_rainfall_anomaly" & Chr(34))
                dctFiles.Add("Sahel Dry Mask", Chr(34) & "sahel_dry_mask" & Chr(34))
                dctFiles.Add("Standard Precipitation Index 1-dekad", Chr(34) & "SPI_1_dekad" & Chr(34))
                'monthly,climatology and TAMSAT RFE 0p1 are yet to be implemented.
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Rainfall Estimates"
            ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_ARC2" Then
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily Est. Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                dctFiles.Add("Monthly Average Est. Prcp.", Chr(34) & "monthly_average_estimated_prcp" & Chr(34))
                'monthly,climatology and TAMSAT RFE 0p1 are yet to be implemented.
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Daily Est. Prcp."
            ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_RFE2" Then
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily Est. Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Daily Est. Prcp."
            ElseIf (ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_CMORPH_DAILY" OrElse ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_CMORPH_3HOURLY" OrElse ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_CMORPH_DAILY_CALCULATED") Then
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Mean Microwave Only Est. Prcp.", Chr(34) & "mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Mean Morphed Est. Prcp.", Chr(34) & "mean_morphed_est_prcp" & Chr(34))
                dctFiles.Add("Orignames Mean Microwave Only Est. Prcp.", Chr(34) & "orignames_mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Orignames Mean Morphed Est. Prcp.", Chr(34) & "orignames_mean_morphed_est_prcp" & Chr(34))
                dctFiles.Add("Renamed102015 Mean Microwave Only Est. Prcp.", Chr(34) & "renamed102015_mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Renamed102015 Mean Morphed Est. Prcp.", Chr(34) & "renamed102015_mean_morphed_est_prcp" & Chr(34))
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Mean Morphed Est. Prcp."

                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_CMORPH_PENTAD" Then
                'ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "NOAA_CMORPH_V0PX" Then
            ElseIf ucrInputDownloadFrom.cboInput.SelectedItem = "NASA_TRMM_3B42" Then
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily Est. Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                dctFiles.Add("3-Hourly Est. Prcp.", Chr(34) & "3_hourly_estimated_prcp" & Chr(34))
                dctFiles.Add("3-Hourly Pre-gauge Adjusted Infrared Est. Prcp.", Chr(34) & "3_hourly_pre_gauge_adjusted_infrared_est_prcp" & Chr(34))
                dctFiles.Add("3-Hourly Pre-gauge Adjusted Microwave Est. Prcp.", Chr(34) & "3_hourly_pre_gauge_adjusted_microwave_est_prcp" & Chr(34))
                ucrInputDataFile.SetItems(dctFiles)
                ucrInputDataFile.cboInput.SelectedItem = "Daily Est. Prcp."
            End If
            'other data sources to be added here.
        End If
    End Sub

    'Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
    '    Dim dlgSave As New FolderBrowserDialog
    '    Dim strTempDownloadDirectory As String
    '    'dlgSave. = "Create Temporary Directory"
    '    strTempDownloadDirectory = System.IO.Path.Combine(System.IO.Path.GetTempPath() & "R_Instat_Temp_IRI_Download")
    '    dlgSave.RootFolder = strTempDownloadDirectory
    '    'frmMain.clsInstatOptions.strWorkingDirectory
    '    'dlgSave.Filter = "Text separated file (*.txt)|*.txt"
    '    If dlgSave.ShowDialog = DialogResult.OK Then
    '        If dlgSave.RootFolder <> "" Then
    '            ucrInputExportFile.SetName(Path.GetFullPath(dlgSave.RootFolder).ToString.Replace("\", "/"))
    '        End If
    '    End If
    'End Sub

    'Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
    '    cmdBrowse_Click(sender, e)
    'End Sub
End Class