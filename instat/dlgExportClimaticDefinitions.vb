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
Imports System.IO
Public Class dlgExportClimaticDefinitions
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsDummyFunction As New RFunction
    Private clsGetDataFrameFunction, clsUpdateMetadataInfoFunction, ClsGcsAuthFileFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public clsExportRinstatToBucketFunction, clsSummariesFunction As New RFunction
    Public clsReforMattAnnualSummariesFunction, clsReformatCropSuccessFunction, clsReformatSeasonStartFunction, clsReformatTempSummariesFunction, clsReformatMonthlyTempSummaries As New RFunction

    Private Sub dlgExportClimaticDefinitions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        DialogSize()
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlExportGoogle.AddRadioButton(rdoUpdateMetadata)
        ucrPnlExportGoogle.AddRadioButton(rdoUploadSummaries)
        ucrPnlExportGoogle.AddParameterValuesCondition(rdoUpdateMetadata, "checked", "metadata")
        ucrPnlExportGoogle.AddParameterValuesCondition(rdoUploadSummaries, "checked", "summary")

        ucrReceiverStation.SetParameter(New RParameter("station", 0))
        ucrReceiverStation.Selector = ucrSelectorExportDefinitions
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrReceiverDataYear.SetParameter(New RParameter("data_by_year", 1))
        ucrReceiverDataYear.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYear.SetParameterIsString()
        ucrReceiverDataYear.SetItemType("dataframe")
        ucrReceiverDataYear.strSelectorHeading = "Data Sets"
        ucrReceiverDataYear.SetLinkedDisplayControl(lblDataByYear)

        ucrReceiverDataYearMonth.SetParameter(New RParameter("data_by_year_month", 2))
        ucrReceiverDataYearMonth.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYearMonth.SetParameterIsString()
        ucrReceiverDataYearMonth.SetItemType("dataframe")
        ucrReceiverDataYearMonth.strSelectorHeading = "Data Sets"
        ucrReceiverDataYearMonth.SetLinkedDisplayControl(lblDataByYearMonth)

        ucrReceiverCropData.SetParameter(New RParameter("crop_data", 3))
        ucrReceiverCropData.Selector = ucrSelectorExportDefinitions
        ucrReceiverCropData.SetParameterIsString()
        ucrReceiverCropData.SetItemType("dataframe")
        ucrReceiverCropData.strSelectorHeading = "Data Sets"
        ucrReceiverCropData.SetLinkedDisplayControl(lblCropData)

        ucrReceiverRain.SetParameter(New RParameter("rain", 6))
        ucrReceiverRain.Selector = ucrSelectorExportDefinitions
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverYear.SetParameter(New RParameter("year", 7))
        ucrReceiverYear.Selector = ucrSelectorExportDefinitions
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)

        ucrReceiverMonth.SetParameter(New RParameter("month", 8))
        ucrReceiverMonth.Selector = ucrSelectorExportDefinitions
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverRainIndicator.SetParameter(New RParameter("rain_days_name", 9))
        ucrReceiverRainIndicator.Selector = ucrSelectorExportDefinitions
        ucrReceiverRainIndicator.SetParameterIsString()
        ucrReceiverRainIndicator.SetLinkedDisplayControl(lblRainIndicator)

        ucrReceiverExtremIndicator.SetParameter(New RParameter("extreme_rainfall_column", 10))
        ucrReceiverExtremIndicator.Selector = ucrSelectorExportDefinitions
        ucrReceiverExtremIndicator.SetParameterIsString()
        ucrReceiverExtremIndicator.SetLinkedDisplayControl(lblExtremRain)

        ucrChkAnnualRainfall.SetText("Annual Rainfall")
        ucrChkAnnualRainfall.AddParameterValuesCondition(True, "rain", "True")
        ucrChkAnnualRainfall.AddParameterValuesCondition(False, "rain", "False")

        ucrChkAnnualTemp.SetText("Annual Temperature")
        ucrChkAnnualTemp.AddParameterValuesCondition(True, "temp", "True")
        ucrChkAnnualTemp.AddParameterValuesCondition(False, "temp", "False")

        ucrChkExtremes.SetText("Extremes")
        ucrChkExtremes.AddParameterValuesCondition(True, "extrem", "True")
        ucrChkExtremes.AddParameterValuesCondition(False, "extrem", "False")

        ucrChkMonthlyTemp.SetText("Monthly Temperature")
        ucrChkMonthlyTemp.AddParameterValuesCondition(True, "monthly_temp", "True")
        ucrChkMonthlyTemp.AddParameterValuesCondition(False, "monthly_temp", "False")

        ucrChkSeasonStartProp.SetText("Season Start Probabilities")
        ucrChkSeasonStartProp.AddParameterValuesCondition(True, "season", "True")
        ucrChkSeasonStartProp.AddParameterValuesCondition(False, "season", "False")

        ucrChkCropSuccessProp.SetText("Crop Success Probabilities")
        ucrChkCropSuccessProp.AddParameterValuesCondition(True, "crop", "True")
        ucrChkCropSuccessProp.AddParameterValuesCondition(False, "crop", "False")

        ucrChkIncludeSummaryData.SetText("Include Summary Data")
        ucrChkIncludeSummaryData.SetParameter(New RParameter("include_summary_data", 17))
        ucrChkIncludeSummaryData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeSummaryData.SetRDefault("FALSE")

        ucrInputDefinitionsID.SetParameter(New RParameter("definitions_id", 19))
        ucrInputDefinitionsID.SetLinkedDisplayControl(lblDefinitionsID)

        ucrInputCountry.SetParameter(New RParameter("country", 20))
        ucrInputCountry.SetLinkedDisplayControl(lblCountry)

        ucrInputTokenPath.SetParameter(New RParameter("filename", 0))
        ucrInputTokenPath.SetLinkedDisplayControl(lblExport)

        ucrReceiverStationName.SetParameter(New RParameter("station_var", 1))
        ucrReceiverStationName.Selector = ucrSelectorExportDefinitions
        ucrReceiverStationName.SetParameterIsString()
        ucrReceiverStationName.SetClimaticType("station")
        ucrReceiverStationName.bAutoFill = True
        ucrReceiverStationName.SetLinkedDisplayControl(lblStationName)

        ucrReceiverLongititude.SetParameter(New RParameter("longitude_var", 2))
        ucrReceiverLongititude.Selector = ucrSelectorExportDefinitions
        ucrReceiverLongititude.SetParameterIsString()
        ucrReceiverLongititude.SetClimaticType("lon")
        ucrReceiverLongititude.bAutoFill = True
        ucrReceiverLongititude.SetLinkedDisplayControl(lblLongitude)

        ucrReceiverLatitude.SetParameter(New RParameter("latitude_var", 3))
        ucrReceiverLatitude.Selector = ucrSelectorExportDefinitions
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetClimaticType("lat")
        ucrReceiverLatitude.bAutoFill = True
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)

        ucrReceiverElavation.SetParameter(New RParameter("elevation_var", 4))
        ucrReceiverElavation.Selector = ucrSelectorExportDefinitions
        ucrReceiverElavation.SetParameterIsString()
        ucrReceiverElavation.SetClimaticType("alt")
        ucrReceiverElavation.bAutoFill = True
        ucrReceiverElavation.SetLinkedDisplayControl(lblElavation)

        ucrReceiverDistrict.SetParameter(New RParameter("district_var", 5))
        ucrReceiverDistrict.Selector = ucrSelectorExportDefinitions
        ucrReceiverDistrict.SetParameterIsString()
        ucrReceiverDistrict.SetClimaticType("district")
        ucrReceiverDistrict.bAutoFill = True
        ucrReceiverDistrict.SetLinkedDisplayControl(lblDistrict)

        ucrInputCountryMetadata.SetParameter(New RParameter("country", 6))
        ucrInputCountryMetadata.SetLinkedDisplayControl(lblCountryMetada)

        ucrPnlExportGoogle.AddToLinkedControls({ucrReceiverMonth, ucrReceiverYear, ucrReceiverStation}, {rdoUploadSummaries}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExportGoogle.AddToLinkedControls({ucrReceiverDistrict, ucrReceiverElavation, ucrReceiverLatitude, ucrInputCountryMetadata, ucrReceiverLongititude, ucrReceiverStationName}, {rdoUpdateMetadata}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExportGoogle.AddToLinkedControls({ucrInputCountry, ucrChkIncludeSummaryData, ucrInputDefinitionsID}, {rdoUploadSummaries}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        DialogSize()
    End Sub

    Private Sub SetDefaults()
        clsExportRinstatToBucketFunction = New RFunction
        clsSummariesFunction = New RFunction
        clsReformatCropSuccessFunction = New RFunction
        clsReformatMonthlyTempSummaries = New RFunction
        clsReformatSeasonStartFunction = New RFunction
        clsReforMattAnnualSummariesFunction = New RFunction
        clsReformatTempSummariesFunction = New RFunction
        ClsGcsAuthFileFunction = New RFunction
        clsUpdateMetadataInfoFunction = New RFunction
        clsDummyFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        bResetSubdialog = True

        ucrSelectorExportDefinitions.Reset()

        clsDummyFunction.AddParameter("rain", "False", iPosition:=0)
        clsDummyFunction.AddParameter("temp", "False", iPosition:=1)
        clsDummyFunction.AddParameter("monthly_temp", "False", iPosition:=2)
        clsDummyFunction.AddParameter("extrem", "False", iPosition:=3)
        clsDummyFunction.AddParameter("season", "False", iPosition:=4)
        clsDummyFunction.AddParameter("crop", "False", iPosition:=5)
        clsDummyFunction.AddParameter("checked", "metadata", iPosition:=6)

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsReformatTempSummariesFunction.SetPackageName("epicsawrap")
        clsReformatTempSummariesFunction.SetRCommand("reformat_temperature_summaries")
        clsReformatTempSummariesFunction.SetAssignTo("annual_temp")

        clsReforMattAnnualSummariesFunction.SetPackageName("epicsawrap")
        clsReforMattAnnualSummariesFunction.SetRCommand("reformat_annual_summaries")
        clsReforMattAnnualSummariesFunction.SetAssignTo("annual_rain")

        clsReformatSeasonStartFunction.SetPackageName("epicsawrap")
        clsReformatSeasonStartFunction.SetRCommand("reformat_season_start")
        clsReformatSeasonStartFunction.SetAssignTo("crop_def")

        clsReformatMonthlyTempSummaries.SetPackageName("epicsawrap")
        clsReformatMonthlyTempSummaries.SetRCommand("reformat_temperature_summaries")
        clsReformatMonthlyTempSummaries.SetAssignTo("monthly_temp")

        clsReformatCropSuccessFunction.SetPackageName("epicsawrap")
        clsReformatCropSuccessFunction.SetRCommand("reformat_crop_success")
        clsReformatCropSuccessFunction.SetAssignTo("crop_prop")

        clsSummariesFunction.SetRCommand("c")

        clsExportRinstatToBucketFunction.SetPackageName("epicsawrap")
        clsExportRinstatToBucketFunction.SetRCommand("export_r_instat_to_bucket")

        ClsGcsAuthFileFunction.SetPackageName("epicsawrap")
        ClsGcsAuthFileFunction.SetRCommand("gcs_auth_file")

        clsUpdateMetadataInfoFunction.SetPackageName("epicsawrap")
        clsUpdateMetadataInfoFunction.SetRCommand("update_metadata_info")
        ucrBase.clsRsyntax.ClearCodes()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverCropData.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverStation.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverDataYear.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverDataYearMonth.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverMonth.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverRain.SetRCode(clsExportRinstatToBucketFunction, bReset)
        'ucrReceiverRainIndicator.SetRCode(clsExportRinstatToBucketFunction, bReset)
        'ucrReceiverExtremIndicator.SetRCode(clsExportRinstatToBucketFunction, bReset)

        ucrReceiverYear.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrSelectorExportDefinitions.SetRCode(clsExportRinstatToBucketFunction)
        ucrInputTokenPath.SetRCode(ClsGcsAuthFileFunction, bReset)

        ucrInputDefinitionsID.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrInputCountry.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrChkIncludeSummaryData.SetRCode(clsExportRinstatToBucketFunction, bReset)

        ucrReceiverDistrict.SetRCode(clsUpdateMetadataInfoFunction, bReset)
        ucrReceiverElavation.SetRCode(clsUpdateMetadataInfoFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsUpdateMetadataInfoFunction, bReset)
        ucrReceiverLongititude.SetRCode(clsUpdateMetadataInfoFunction, bReset)
        ucrReceiverStationName.SetRCode(clsUpdateMetadataInfoFunction, bReset)
        ucrInputCountryMetadata.SetRCode(clsUpdateMetadataInfoFunction, bReset)

        If bReset Then
            ucrChkAnnualRainfall.SetRCode(clsDummyFunction, bReset)
            ucrChkAnnualTemp.SetRCode(clsDummyFunction, bReset)
            ucrChkCropSuccessProp.SetRCode(clsDummyFunction, bReset)
            ucrChkExtremes.SetRCode(clsDummyFunction, bReset)
            ucrChkMonthlyTemp.SetRCode(clsDummyFunction, bReset)
            ucrChkSeasonStartProp.SetRCode(clsDummyFunction, bReset)
            ucrPnlExportGoogle.SetRCode(clsDummyFunction, bReset)
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
    End Sub

    Private Sub TestOkEnabled()
        If rdoUploadSummaries.Checked Then
            ' Basic required fields
            Dim bRequiredFieldsFilled As Boolean = Not ucrReceiverStation.IsEmpty AndAlso
                                               Not ucrReceiverYear.IsEmpty AndAlso
                                               Not ucrInputCountry.IsEmpty AndAlso
                                               Not ucrInputDefinitionsID.IsEmpty AndAlso
                                               Not ucrInputTokenPath.IsEmpty

            If bRequiredFieldsFilled Then
                ' Individual validity checks
                Dim bCropChecked As Boolean = ucrChkCropSuccessProp.Checked OrElse ucrChkSeasonStartProp.Checked
                Dim bCropOK As Boolean = Not bCropChecked OrElse Not ucrReceiverCropData.IsEmpty

                Dim bAnnualRainOK As Boolean = Not ucrChkAnnualRainfall.Checked OrElse
                                           (Not ucrReceiverRain.IsEmpty AndAlso Not ucrReceiverDataYear.IsEmpty)

                Dim bAnnualTempOK As Boolean = Not ucrChkAnnualTemp.Checked OrElse
                                           Not ucrReceiverDataYear.IsEmpty

                Dim bMonthlyTempOK As Boolean = Not ucrChkMonthlyTemp.Checked OrElse
                                            (Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDataYearMonth.IsEmpty)

                ' Final OK decision
                If bCropOK AndAlso bAnnualRainOK AndAlso bAnnualTempOK AndAlso bMonthlyTempOK Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(False)
            End If

        Else
            ' Non-upload mode (metadata)
            If Not ucrReceiverStationName.IsEmpty AndAlso
           Not ucrInputTokenPath.IsEmpty AndAlso
           Not ucrInputCountryMetadata.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub


    Private Sub AddRemoveSummary()
        If ucrChkAnnualRainfall.Checked OrElse ucrChkAnnualTemp.Checked OrElse ucrChkCropSuccessProp.Checked OrElse ucrChkExtremes.Checked OrElse ucrChkMonthlyTemp.Checked OrElse ucrChkSeasonStartProp.Checked Then
            clsExportRinstatToBucketFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesFunction, iPosition:=0)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("summaries")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        EnableDisableDefineButton()
    End Sub

    Private Sub cmdDefine_Click(sender As Object, e As EventArgs) Handles cmdDefine.Click
        sdgDefineAnnualRainfall.SetRCode(clsNewReformatCropSuccessFunction:=clsReformatCropSuccessFunction, clsNewReformatSeasonStartFunction:=clsReformatSeasonStartFunction, clsNewReformatMonthlyTempSummaries:=clsReformatMonthlyTempSummaries,
                                      clsNewReforMattAnnualSummaries:=clsReforMattAnnualSummariesFunction, clsNewReformatTempSummariesFunction:=clsReformatTempSummariesFunction, clsNewExportRinstatToBucketFunction:=clsExportRinstatToBucketFunction, bReset:=bResetSubdialog)
        sdgDefineAnnualRainfall.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ucrChkAnnualRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAnnualRainfall.ControlValueChanged
        If ucrChkAnnualRainfall.Checked Then
            clsSummariesFunction.AddParameter("rain", Chr(34) & "annual_rainfall" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("rain")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
        AddExtremeRainParameter()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAnnualTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAnnualTemp.ControlValueChanged
        If ucrChkAnnualTemp.Checked Then
            clsSummariesFunction.AddParameter("temp", Chr(34) & "annual_temperature" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("temp")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkCropSuccessProp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCropSuccessProp.ControlValueChanged
        If ucrChkCropSuccessProp.Checked Then
            clsSummariesFunction.AddParameter("prop", Chr(34) & "crop_success" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("prop")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExtremes.ControlValueChanged
        If ucrChkExtremes.Checked Then
            clsSummariesFunction.AddParameter("extreme", Chr(34) & "extremes" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("extreme")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
    End Sub

    Private Sub ucrChkMonthlyTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMonthlyTemp.ControlValueChanged
        If ucrChkMonthlyTemp.Checked Then
            clsSummariesFunction.AddParameter("month_temp", Chr(34) & "monthly_temperature" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("month_temp")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSeasonStartProp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSeasonStartProp.ControlValueChanged
        If ucrChkSeasonStartProp.Checked Then
            clsSummariesFunction.AddParameter("start_prop", Chr(34) & "start_season" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        Else
            clsSummariesFunction.RemoveParameterByName("start_prop")
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCountry_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCountry.ControlValueChanged
        If Not ucrInputCountry.IsEmpty Then
            clsExportRinstatToBucketFunction.AddParameter("country", Chr(34) & ucrInputCountry.GetText & Chr(34), iPosition:=20)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("country")
        End If
    End Sub

    Private Sub ucrInputDefinitionsID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDefinitionsID.ControlValueChanged
        If Not ucrInputDefinitionsID.IsEmpty Then
            clsExportRinstatToBucketFunction.AddParameter("definitions_id", Chr(34) & ucrInputDefinitionsID.GetText & Chr(34), iPosition:=19)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("definitions_id")
        End If
    End Sub

    Private Sub EnableDisableDefineButton()
        ucrReceiverDataYearMonth.Visible = False
        ucrReceiverDataYear.Visible = False
        ucrReceiverRain.Visible = False
        ucrReceiverRainIndicator.Visible = False
        ucrReceiverExtremIndicator.Visible = False
        ucrReceiverCropData.Visible = False
        If rdoUploadSummaries.Checked Then
            ucrReceiverDataYearMonth.Visible = ucrChkMonthlyTemp.Checked
            ucrReceiverDataYear.Visible = ucrChkAnnualRainfall.Checked OrElse ucrChkAnnualTemp.Checked
            ucrReceiverRain.Visible = ucrChkAnnualRainfall.Checked
            ucrReceiverExtremIndicator.Visible = ucrChkAnnualRainfall.Checked
            ucrReceiverRainIndicator.Visible = ucrChkAnnualRainfall.Checked
            ucrReceiverCropData.Visible = ucrChkCropSuccessProp.Checked OrElse ucrChkSeasonStartProp.Checked
        Else
            ucrReceiverDataYearMonth.Visible = False
            ucrReceiverDataYear.Visible = False
            ucrReceiverRain.Visible = False
            ucrReceiverRainIndicator.Visible = False
            ucrReceiverExtremIndicator.Visible = False
            ucrReceiverCropData.Visible = False
        End If

    End Sub

    Private Sub cmdChooseFile_Click_1(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "JSON Files|*.json"
            dlgOpen.Title = "Import JSON File"

            dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputTokenPath.GetText(), "/", "\"))

            If dlgOpen.ShowDialog() = DialogResult.OK AndAlso dlgOpen.FileName <> "" Then
                ucrInputTokenPath.SetName(Replace(dlgOpen.FileName, "\", "/"))
            End If
        End Using
    End Sub

    Private Sub ucrChkIncludeSummaryData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeSummaryData.ControlValueChanged
        EnableDisableDefineButton()
    End Sub

    Private Sub ucrSelectorExportDefinitions_DataFrameChanged() Handles ucrSelectorExportDefinitions.DataFrameChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlExportGoogle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExportGoogle.ControlValueChanged, ucrInputTokenPath.ControlValueChanged
        ucrBase.clsRsyntax.AddToBeforeCodes(ClsGcsAuthFileFunction, 0)
        If rdoUpdateMetadata.Checked Then
            grpSummaries.Visible = False
            cmdDefine.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsUpdateMetadataInfoFunction)
            ucrReceiverStationName.SetMeAsReceiver()
        Else
            grpSummaries.Visible = True
            cmdDefine.Visible = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportRinstatToBucketFunction)
            ucrReceiverStation.SetMeAsReceiver()
        End If
        EnableDisableDefineButton()
        DialogSize()
        TestOkEnabled()
    End Sub

    Private Sub DialogSize()
        If rdoUpdateMetadata.Checked Then
            Me.Size = New Size(475, 455)
            Me.ucrBase.Location = New Point(4, 360)
        Else
            Me.Size = New Size(475, 570)
            Me.ucrBase.Location = New Point(4, 475)
        End If
    End Sub

    Private Sub ucrSelectorExportDefinitions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorExportDefinitions.ControlValueChanged
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorExportDefinitions.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorExportDefinitions.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsUpdateMetadataInfoFunction.AddParameter("metadata_data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
    End Sub

    Private Sub ucrReceiverData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRain.ControlContentsChanged, ucrReceiverCropData.ControlContentsChanged, ucrReceiverDataYearMonth.ControlContentsChanged, ucrReceiverDataYear.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrInputTokenPath.ControlContentsChanged, ucrInputCountryMetadata.ControlContentsChanged,
            ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrChkSeasonStartProp.ControlContentsChanged, ucrInputCountry.ControlContentsChanged, ucrInputDefinitionsID.ControlContentsChanged, ucrChkIncludeSummaryData.ControlContentsChanged, ucrReceiverLongititude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged,
            ucrChkMonthlyTemp.ControlContentsChanged, ucrChkCropSuccessProp.ControlContentsChanged, ucrChkAnnualTemp.ControlContentsChanged, ucrChkAnnualRainfall.ControlContentsChanged, ucrSelectorExportDefinitions.ControlContentsChanged, ucrReceiverElavation.ControlContentsChanged, ucrReceiverDistrict.ControlContentsChanged, ucrReceiverStationName.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputCountryMetadata_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCountryMetadata.ControlValueChanged
        If Not ucrInputCountryMetadata.IsEmpty Then
            clsUpdateMetadataInfoFunction.AddParameter("country", Chr(34) & ucrInputCountryMetadata.GetText & Chr(34), iPosition:=6)
        Else
            clsUpdateMetadataInfoFunction.RemoveParameterByName("country")
        End If
    End Sub

    Private Sub AddExtremeRainParameter()
        If ucrChkAnnualRainfall.Checked Then
            If Not ucrReceiverExtremIndicator.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("extreme_rainfall_column", ucrReceiverExtremIndicator.GetVariableNames, iPosition:=10)

            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("extreme_rainfall_column")
            End If

            If Not ucrReceiverRainIndicator.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("rain_days_name", ucrReceiverRainIndicator.GetVariableNames, iPosition:=9)

            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("rain_days_name")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("rain_days_name")
            clsExportRinstatToBucketFunction.RemoveParameterByName("extreme_rainfall_column")

        End If
    End Sub

    Private Sub ucrReceiverRainIndicator_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainIndicator.ControlValueChanged, ucrReceiverExtremIndicator.ControlValueChanged
        AddExtremeRainParameter()
    End Sub

End Class