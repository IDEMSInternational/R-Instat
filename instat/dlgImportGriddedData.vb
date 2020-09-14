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

Imports System.IO
Imports instat.Translations
Public Class dlgImportGriddedData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bShowMessageBox As Boolean
    Private clsDownloadFromIRIFunction As New RFunction
    Private clsDefaultStartDate, clsDefaultEndDate As New RFunction
    Private dctDownloadPairs, dctFiles As New Dictionary(Of String, String)
    Private Sub dlgImportGriddedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 526

        ucrInputSource.SetParameter(New RParameter("source", 0))
        dctDownloadPairs.Add("NOAA_RFE2", Chr(34) & "NOAA_RFE2" & Chr(34))
        dctDownloadPairs.Add("CHIRPS_V2P0", Chr(34) & "CHIRPS_V2P0" & Chr(34))
        dctDownloadPairs.Add("TAMSAT", Chr(34) & "TAMSAT" & Chr(34))
        dctDownloadPairs.Add("NOAA_ARC2", Chr(34) & "NOAA_ARC2" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_DAILY", Chr(34) & "NOAA_CMORPH_DAILY" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_3HOURLY", Chr(34) & "NOAA_CMORPH_3HOURLY" & Chr(34))
        dctDownloadPairs.Add("NOAA_CMORPH_DAILY_CALCULATED", Chr(34) & "NOAA_CMORPH_DAILY_CALCULATED" & Chr(34))
        dctDownloadPairs.Add("NASA_TRMM_3B42", Chr(34) & "NASA_TRMM_3B42" & Chr(34))
        ucrInputSource.SetItems(dctDownloadPairs)
        ucrInputSource.SetDropDownStyleAsNonEditable()

        ucrInputData.SetParameter(New RParameter("data", 1))
        dctFiles.Add("Daily_Est._Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
        ucrInputData.SetItems(dctFiles)
        ucrInputData.SetDropDownStyleAsNonEditable()

        ucrInputFilePath.IsReadOnly = True

        ucrInputMinLon.SetParameter(New RParameter("min_lon", 3))
        ucrInputMinLon.AddQuotesIfUnrecognised = False
        ucrInputMinLon.SetValidationTypeAsNumeric(dcmMin:=-180, dcmMax:=180)

        ucrInputMaxLon.SetParameter(New RParameter("max_lon", 4))
        ucrInputMaxLon.AddQuotesIfUnrecognised = False
        ucrInputMaxLon.SetValidationTypeAsNumeric(dcmMin:=-180, dcmMax:=180)

        ucrInputMinLat.SetParameter(New RParameter("min_lat", 5))
        ucrInputMinLat.AddQuotesIfUnrecognised = False
        ucrInputMinLat.SetValidationTypeAsNumeric(dcmMin:=-90, dcmMax:=90)

        ucrInputMaxLat.SetParameter(New RParameter("max_lat", 6))
        ucrInputMaxLat.AddQuotesIfUnrecognised = False
        ucrInputMaxLat.SetValidationTypeAsNumeric(dcmMin:=-90, dcmMax:=90)

        ucrDtpMinDate.SetParameter(New RParameter("min_date", 7))

        ucrDtpMaxDate.SetParameter(New RParameter("max_date", 8))

        ucrInputNewDataFrameName.SetParameter(New RParameter("name", 9))

        ucrPnlDownloadType.SetParameter(New RParameter("download_type", 10))
        ucrPnlDownloadType.AddRadioButton(rdoArea, Chr(34) & "area" & Chr(34))
        ucrPnlDownloadType.AddRadioButton(rdoPoint, Chr(34) & "point" & Chr(34))

        ucrChkDontImportData.SetParameter(New RParameter("import", 11))
        ucrChkDontImportData.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkDontImportData.SetText("Don' t import data after downloading")
        ucrChkDontImportData.SetRDefault("TRUE")

        ucrPnlDownloadType.AddToLinkedControls({ucrInputMaxLat, ucrInputMaxLon}, {rdoArea}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSaveFileLocation.AddToLinkedControls(ucrChkDontImportData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSaveFileLocation.AddToLinkedControls(ucrInputFilePath, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkWholeRange.AddToLinkedControls({ucrDtpMinDate, ucrDtpMaxDate}, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMinLon.SetLinkedDisplayControl(lblMinLon)
        ucrInputMinLon.SetLinkedDisplayControl(lblMinLon)
        ucrInputMaxLon.SetLinkedDisplayControl(lblMaxLon)
        ucrInputMinLat.SetLinkedDisplayControl(lblMinLat)
        ucrInputMaxLat.SetLinkedDisplayControl(lblMaxLat)
        ucrInputFilePath.SetLinkedDisplayControl(cmdBrowse)
        ucrDtpMinDate.SetLinkedDisplayControl(lblFrom)
        ucrDtpMaxDate.SetLinkedDisplayControl(lblTo)

        ucrChkSaveFileLocation.SetText("Save Downloaded File:")
        ucrChkSaveFileLocation.AddParameterPresentCondition(True, "path")
        ucrChkSaveFileLocation.AddParameterPresentCondition(False, "path", False)

        ucrChkWholeRange.SetText("Whole range")
        ucrChkWholeRange.AddParameterPresentCondition(True, {"min_date", "max_date"})
        ucrChkWholeRange.AddParameterPresentCondition(False, {"min_date", "max_date"}, False)

        clsDefaultStartDate = New RFunction
        clsDefaultStartDate.SetRCommand("as.Date")
        clsDefaultStartDate.AddParameter("x", Chr(34) & "2000/10/31" & Chr(34))

        clsDefaultEndDate = ucrDtpMaxDate.ValueAsRDate
    End Sub

    Private Sub SetDefaults()
        clsDownloadFromIRIFunction = New RFunction
        bShowMessageBox = True

        clsDownloadFromIRIFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$download_from_IRI")
        clsDownloadFromIRIFunction.AddParameter("source", Chr(34) & "NOAA_RFE2" & Chr(34), iPosition:=0)
        clsDownloadFromIRIFunction.AddParameter("data", Chr(34) & "daily_estimated_prcp" & Chr(34), iPosition:=1)
        'clsDownloadFromIRIFunction.AddParameter("path", Chr(34) & System.IO.Path.Combine(System.IO.Path.GetTempPath()).Replace("\", "/") & Chr(34), iPosition:=2)
        'opted to set this as default location since it has data for all sources
        clsDownloadFromIRIFunction.AddParameter("min_lon", 10, iPosition:=3)
        clsDownloadFromIRIFunction.AddParameter("max_lon", 10.5, iPosition:=4)
        clsDownloadFromIRIFunction.AddParameter("min_lat", 10, iPosition:=5)
        clsDownloadFromIRIFunction.AddParameter("max_lat", 10.5, iPosition:=6)
        clsDownloadFromIRIFunction.AddParameter("min_date", clsRFunctionParameter:=clsDefaultStartDate, iPosition:=7)
        clsDownloadFromIRIFunction.AddParameter("max_date", clsRFunctionParameter:=clsDefaultEndDate, iPosition:=8)
        clsDownloadFromIRIFunction.AddParameter("download_type", Chr(34) & "area" & Chr(34), iPosition:=10)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDownloadFromIRIFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        If bReset Then
            SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrInputNewDataFrameName.IsEmpty OrElse (rdoPoint.Checked AndAlso (ucrInputMinLon.IsEmpty OrElse ucrInputMinLat.IsEmpty)) OrElse (rdoArea.Checked AndAlso (ucrInputMinLon.IsEmpty OrElse ucrInputMinLat.IsEmpty OrElse ucrInputMaxLon.IsEmpty OrElse ucrInputMaxLat.IsEmpty)) OrElse (ucrChkSaveFileLocation.Checked AndAlso ucrInputFilePath.IsEmpty) OrElse (Not ucrChkWholeRange.Checked AndAlso ucrDtpMinDate.DateValue > ucrDtpMaxDate.DateValue) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlDownloadType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDownloadType.ControlValueChanged
        If rdoArea.Checked Then
            lblMinLat.Text = "Minimum Latitude:"
            lblMinLon.Text = "Minimum Longitude:"
        ElseIf rdoPoint.Checked Then
            lblMinLat.Text = "Latitude:"
            lblMinLon.Text = "Longitude:"
        End If
    End Sub

    Private Sub ucrInputSource_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSource.ControlValueChanged
        Select Case ucrInputSource.GetText
            Case "NOAA_RFE2"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily_Est._Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Daily_Est._Prcp."
                ucrDtpMinDate.MinDate = New Date(2000, 10, 31)
                ucrDtpMaxDate.MinDate = New Date(2000, 10, 31)
            Case "CHIRPS_V2P0"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily_0p25", Chr(34) & "daily_0p25" & Chr(34))
                dctFiles.Add("Daily_Improved_0p25", Chr(34) & "daily_improved_0p25" & Chr(34))
                dctFiles.Add("Daily_0p05", Chr(34) & "daily_0p05" & Chr(34))
                dctFiles.Add("Daily_Improved_0p05", Chr(34) & "daily_improved_0p05" & Chr(34))
                dctFiles.Add("Dekad", Chr(34) & "dekad" & Chr(34))
                dctFiles.Add("Monthly_c8113", Chr(34) & "monthly_c8113" & Chr(34))
                dctFiles.Add("Monthly_deg1p0", Chr(34) & "monthly_deg1p0" & Chr(34))
                dctFiles.Add("Monthly_NMME_deg1p0", Chr(34) & "monthly_NMME_deg1p0" & Chr(34))
                dctFiles.Add("Monthly_Precipitation", Chr(34) & "monthly_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Daily_0p25"
                ucrDtpMinDate.MinDate = New Date(1981, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1981, 1, 1)
            Case "TAMSAT"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Rainfall_Estimates", Chr(34) & "rainfall_estimates" & Chr(34))
                dctFiles.Add("Rainfall_Estimates_0p1", Chr(34) & "rainfall_estimates_0p1" & Chr(34))
                dctFiles.Add("Reconstructed_Rainfall_Anomaly", Chr(34) & "reconstructed_rainfall_anomaly" & Chr(34))
                dctFiles.Add("Sahel_Dry_Mask", Chr(34) & "sahel_dry_mask" & Chr(34))
                dctFiles.Add("Standard_Precipitation_Index_1-dekad", Chr(34) & "SPI_1_dekad" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Rainfall_Estimates"
                ucrDtpMinDate.MinDate = New Date(1983, 1, 11)
                ucrDtpMaxDate.MinDate = New Date(1983, 1, 11)
            Case "NOAA_ARC2"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily_Est._Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                dctFiles.Add("Monthly_Average_Est._Prcp.", Chr(34) & "monthly_average_estimated_prcp" & Chr(34))
                'monthly,climatology and TAMSAT RFE 0p1 are yet to be implemented.
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Daily_Est._Prcp."
                ucrDtpMinDate.MinDate = New Date(1983, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1983, 1, 1)
            Case "NOAA_CMORPH_DAILY", "NOAA_CMORPH_3HOURLY", "NOAA_CMORPH_DAILY_CALCULATED"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Mean_Morphed_Est._Prcp.", Chr(34) & "mean_morphed_est_prcp" & Chr(34))
                dctFiles.Add("Mean_Microwave_Only_Est._Prcp.", Chr(34) & "mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Orignames_Mean_Microwave_Only_Est._Prcp.", Chr(34) & "orignames_mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Orignames_Mean_Morphed_Est._Prcp.", Chr(34) & "orignames_mean_morphed_est_prcp" & Chr(34))
                dctFiles.Add("Renamed102015_Mean_Microwave_Only_Est._Prcp.", Chr(34) & "renamed102015_mean_microwave_only_est_prcp" & Chr(34))
                dctFiles.Add("Renamed102015_Mean_Morphed_Est._Prcp.", Chr(34) & "renamed102015_mean_morphed_est_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Mean_Morphed_Est._Prcp."
                'ucrDtpMinDate.MinDate = New Date(2000, 10, 31) This source(CMORPH) is currently not available seems to have been moved elsewhere!
            Case "NASA_TRMM_3B42"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily_Est._Prcp.", Chr(34) & "daily_estimated_prcp" & Chr(34))
                dctFiles.Add("3-Hourly_Est._Prcp.", Chr(34) & "3_hourly_estimated_prcp" & Chr(34))
                dctFiles.Add("3-Hourly_Pre-gauge_Adjusted_Infrared_Est._Prcp.", Chr(34) & "3_hourly_pre_gauge_adjusted_infrared_est_prcp" & Chr(34))
                dctFiles.Add("3-Hourly_Pre-gauge_Adjusted_Microwave_Est._Prcp.", Chr(34) & "3_hourly_pre_gauge_adjusted_microwave_est_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Daily_Est._Prcp."
                ucrDtpMinDate.MinDate = New Date(1998, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1998, 1, 1)
        End Select
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Import from IRI Data Library Dialog"
            dlgSave.Filter = "NetCDF files|*.nc"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
        End Using
    End Sub

    Private Sub ucrInputData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputData.ControlValueChanged, ucrInputSource.ControlValueChanged
        ucrInputNewDataFrameName.SetName(ucrInputSource.GetText & "_" & ucrInputData.GetText)
    End Sub

    Private Sub ucrInputFilePath_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlValueChanged, ucrChkSaveFileLocation.ControlValueChanged
        If ucrChkSaveFileLocation.Checked AndAlso ucrInputFilePath.GetText <> "" Then
            clsDownloadFromIRIFunction.AddParameter("path", Chr(34) & ucrInputFilePath.GetText & Chr(34), iPosition:=2)
        Else
            clsDownloadFromIRIFunction.RemoveParameterByName("path")
        End If
    End Sub

    Private Sub ucrDtpMaxDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDtpMaxDate.ControlValueChanged, ucrDtpMinDate.ControlValueChanged
        If ucrDtpMinDate.DateValue > ucrDtpMaxDate.DateValue AndAlso bShowMessageBox Then
            MsgBox("From date is greater than To date. Ok will Not be enabled on the dialog.", Title:="Date bounds", Buttons:=MsgBoxStyle.Information)
            bShowMessageBox = False
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputNewDataFrameName.ControlContentsChanged, ucrPnlDownloadType.ControlContentsChanged, ucrInputMinLon.ControlContentsChanged, ucrInputMaxLon.ControlContentsChanged, ucrInputMinLat.ControlContentsChanged, ucrInputMaxLat.ControlContentsChanged, ucrChkSaveFileLocation.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged, ucrChkWholeRange.ControlContentsChanged, ucrDtpMinDate.ControlContentsChanged, ucrDtpMaxDate.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class