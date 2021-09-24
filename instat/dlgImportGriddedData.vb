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
Public Class dlgImportGriddedData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bShowMessageBox As Boolean
    Private clsDownloadFromIRIFunction As RFunction
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
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 526

        ucrInputSource.SetParameter(New RParameter("source", 0))
        dctDownloadPairs.Add("NASA", Chr(34) & "NASA" & Chr(34))
        dctDownloadPairs.Add("NOAA", Chr(34) & "NOAA" & Chr(34))
        dctDownloadPairs.Add("TAMSAT v3.0", Chr(34) & "TAMSAT_v3.0" & Chr(34))
        dctDownloadPairs.Add("TAMSAT v3.1", Chr(34) & "TAMSAT_v3.1" & Chr(34))
        dctDownloadPairs.Add("UCSB CHIRPS", Chr(34) & "UCSB_CHIRPS" & Chr(34))
        ucrInputSource.SetItems(dctDownloadPairs)
        ucrInputSource.SetDropDownStyleAsNonEditable()

        ucrInputData.SetParameter(New RParameter("data", 1))
        ucrInputData.SetDropDownStyleAsNonEditable()

        ucrInputFilePath.SetParameter(New RParameter("path", 2))
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

        ucrPnlLocationRange.SetParameter(New RParameter("download_type", 10))
        ucrPnlLocationRange.AddRadioButton(rdoArea, Chr(34) & "Area" & Chr(34))
        ucrPnlLocationRange.AddRadioButton(rdoPoint, Chr(34) & "Point" & Chr(34))

        ucrPnlDateRange.AddRadioButton(rdoEntireRange)
        ucrPnlDateRange.AddRadioButton(rdoCustomRange)
        ucrPnlDateRange.AddParameterPresentCondition(rdoCustomRange, {"min_date", "max_date"})
        ucrPnlDateRange.AddParameterPresentCondition(rdoEntireRange, {"min_date", "max_date"}, False)

        ucrChkDontImportData.SetParameter(New RParameter("import", 11))
        ucrChkDontImportData.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkDontImportData.SetText("Don' t import data after downloading")
        ucrChkDontImportData.SetRDefault("TRUE")

        ucrPnlLocationRange.AddToLinkedControls({ucrInputMaxLat, ucrInputMaxLon}, {rdoArea}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDateRange.AddToLinkedControls({ucrDtpMinDate, ucrDtpMaxDate}, {rdoCustomRange}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDontImportData.AddToLinkedControls(ucrInputNewDataFrameName, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMaxLon.SetLinkedDisplayControl(lblMaxLon)
        ucrInputMinLat.SetLinkedDisplayControl(lblLat)
        ucrInputMaxLat.SetLinkedDisplayControl(lblMaxLat)
        ucrDtpMinDate.SetLinkedDisplayControl(lblFrom)
        ucrDtpMaxDate.SetLinkedDisplayControl(lblTo)
        ucrInputNewDataFrameName.SetLinkedDisplayControl(lblNewDataFrameName)
    End Sub

    Private Sub SetDefaults()
        clsDownloadFromIRIFunction = New RFunction
        bShowMessageBox = True

        dctFiles = New Dictionary(Of String, String)
        dctFiles.Add("TRMM 3B42 3-Hourly Precipitation", Chr(34) & "3_hourly_prcp" & Chr(34))
        dctFiles.Add("TRMM 3B42 Daily Precipitation", Chr(34) & "daily_prcp" & Chr(34))
        ucrInputData.SetItems(dctFiles)

        clsDownloadFromIRIFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$download_from_IRI")
        clsDownloadFromIRIFunction.AddParameter("source", Chr(34) & "NASA" & Chr(34), iPosition:=0)
        clsDownloadFromIRIFunction.AddParameter("data", Chr(34) & "3_hourly_prcp" & Chr(34), iPosition:=1)
        clsDownloadFromIRIFunction.AddParameter("path", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).Replace("\", "/"), iPosition:=2)
        clsDownloadFromIRIFunction.AddParameter("min_lon", 34.58, iPosition:=3)
        clsDownloadFromIRIFunction.AddParameter("max_lon", 35.08, iPosition:=4)
        clsDownloadFromIRIFunction.AddParameter("min_lat", 0, iPosition:=5)
        clsDownloadFromIRIFunction.AddParameter("max_lat", 0.5, iPosition:=6)
        clsDownloadFromIRIFunction.AddParameter("download_type", Chr(34) & "Point" & Chr(34), iPosition:=10)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDownloadFromIRIFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        If bReset Then
            SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrInputNewDataFrameName.IsEmpty OrElse (rdoPoint.Checked AndAlso (ucrInputMinLon.IsEmpty OrElse ucrInputMinLat.IsEmpty)) OrElse (rdoArea.Checked AndAlso (ucrInputMinLon.IsEmpty OrElse ucrInputMinLat.IsEmpty OrElse ucrInputMaxLon.IsEmpty OrElse ucrInputMaxLat.IsEmpty)) OrElse ucrInputFilePath.IsEmpty OrElse (Not rdoCustomRange.Checked AndAlso ucrDtpMinDate.DateValue > ucrDtpMaxDate.DateValue) Then
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

    Private Sub ucrInputSource_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSource.ControlValueChanged
        Select Case ucrInputSource.GetText
            Case "NASA"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("TRMM 3B42 3-Hourly Precipitation", Chr(34) & "3_hourly_prcp" & Chr(34))
                dctFiles.Add("TRMM 3B42 Daily Precipitation", Chr(34) & "daily_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "TRMM 3B42 3-Hourly Precipitation"
                ucrDtpMinDate.MinDate = New Date(1998, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1998, 1, 1)
            Case "NOAA"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("RFE2 Daily Precipitation", Chr(34) & "daily_rfev2_est_prcp" & Chr(34))
                dctFiles.Add("RFE2 10-day Precipitation", Chr(34) & "10day_rfev2_est_prcp" & Chr(34))
                dctFiles.Add("ARC2 Daily Precipitation", Chr(34) & "daily_est_prcp" & Chr(34))
                dctFiles.Add("ARC2 Monthly Precipitation", Chr(34) & "monthly_est_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "RFE2 Daily Precipitation"
            Case "TAMSAT v3.0"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("v3.0 Daily Rainfall", Chr(34) & "daily_rfe" & Chr(34))
                dctFiles.Add("v3.0 Dekadal Rainfall", Chr(34) & "dekadal_rfe" & Chr(34))
                dctFiles.Add("v3.0 Monthly Rainfall", Chr(34) & "monthly_rfe" & Chr(34))
                dctFiles.Add("v3.0 Monthly Rainfall (Calculated)", Chr(34) & "monthly_rfe_calc" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "v3.0 Daily Rainfall"
                ucrDtpMinDate.MinDate = New Date(1983, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1983, 1, 1)
            Case "TAMSAT v3.1"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("v3.1 Daily Rainfall", Chr(34) & "daily_rfe" & Chr(34))
                dctFiles.Add("v3.1 Daily Rainfall Complete (Filled)", Chr(34) & "daily_rfe_filled" & Chr(34))
                dctFiles.Add("v3.1 Dekadal Rainfall", Chr(34) & "dekadal_rfe" & Chr(34))
                dctFiles.Add("v3.1 Dekadal Rainfall Complete (Filled)", Chr(34) & "dekadal_rfe_filled" & Chr(34))
                dctFiles.Add("v3.1 Monthly Rainfall", Chr(34) & "monthly_rfe" & Chr(34))
                dctFiles.Add("v3.1 Monthly Rainfall Complete (Filled)", Chr(34) & "monthly_rfe_filled" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "v3.1 Daily Rainfall"
                ucrDtpMinDate.MinDate = New Date(1983, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1983, 1, 1)
            Case "UCSB CHIRPS"
                dctFiles = New Dictionary(Of String, String)
                dctFiles.Add("Daily Precipitation 0.05 degree", Chr(34) & "daily_improved_global_0p05_prcp" & Chr(34))
                dctFiles.Add("Dekad Precipitation 0.05 degree", Chr(34) & "dekad_prcp" & Chr(34))
                dctFiles.Add("Monthly Precipitation 0.05 degree", Chr(34) & "monthly_global_prcp" & Chr(34))
                dctFiles.Add("Daily Precipitation 0.25 degree", Chr(34) & "daily_improved_global_0p25_prcp" & Chr(34))
                ucrInputData.SetItems(dctFiles)
                ucrInputData.cboInput.SelectedItem = "Daily Precipitation 0.25 degree"
                ucrDtpMinDate.MinDate = New Date(1981, 1, 1)
                ucrDtpMaxDate.MinDate = New Date(1981, 1, 1)
        End Select
        ucrInputNewDataFrameName.SetName(ucrInputSource.GetText.ToLower)
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim strPath As String

        Using dlgFolder As New FolderBrowserDialog
            dlgFolder.Description = "Choose Folder"
            If dlgFolder.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName("")
                strPath = dlgFolder.SelectedPath
                ucrInputFilePath.SetName(Replace(strPath, "\", "/"))
            End If
        End Using
    End Sub

    Private Sub ucrDtpMaxDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDtpMaxDate.ControlValueChanged, ucrDtpMinDate.ControlValueChanged
        If ucrDtpMinDate.DateValue > ucrDtpMaxDate.DateValue AndAlso bShowMessageBox Then
            MsgBox("From date is greater than To date. Ok will Not be enabled on the dialog.", Title:="Date bounds", Buttons:=MsgBoxStyle.Information)
            bShowMessageBox = False
        End If
    End Sub

    Private Sub ucrPnlLocationRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlLocationRange.ControlValueChanged
        lblMinLon.Visible = rdoArea.Checked
        lblMinLat.Visible = rdoArea.Checked
    End Sub

    Private Sub ucrPnlDateRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDateRange.ControlValueChanged
        If rdoCustomRange.Checked Then
            clsDownloadFromIRIFunction.AddParameter("min_date", clsRFunctionParameter:=ucrDtpMinDate.ValueAsRDate, iPosition:=7)
            clsDownloadFromIRIFunction.AddParameter("max_date", clsRFunctionParameter:=ucrDtpMaxDate.ValueAsRDate, iPosition:=8)
        ElseIf rdoEntireRange.Checked Then
            clsDownloadFromIRIFunction.RemoveParameterByName("min_date")
            clsDownloadFromIRIFunction.RemoveParameterByName("max_date")
        End If
    End Sub

    Private Sub ucrInputData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputData.ControlValueChanged
        If ucrInputData.GetText = "RFE2 Daily Precipitation" OrElse ucrInputData.GetText = "RFE2 10-day Precipitation" Then
            ucrDtpMinDate.MinDate = New Date(2000, 10, 31)
            ucrDtpMaxDate.MinDate = New Date(2000, 10, 31)
        ElseIf ucrInputData.GetText = "ARC2 Daily Precipitation" OrElse ucrInputData.GetText = "ARC2 Monthly Precipitation" Then
            ucrDtpMinDate.MinDate = New Date(1983, 1, 1)
            ucrDtpMaxDate.MinDate = New Date(1983, 1, 1)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputNewDataFrameName.ControlContentsChanged, ucrInputMinLon.ControlContentsChanged, ucrInputMaxLon.ControlContentsChanged, ucrInputMinLat.ControlContentsChanged, ucrInputMaxLat.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged, ucrDtpMinDate.ControlContentsChanged, ucrDtpMaxDate.ControlContentsChanged, ucrPnlDateRange.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
