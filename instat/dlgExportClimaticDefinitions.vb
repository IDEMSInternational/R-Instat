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
    Public clsExportRinstatToBucketFunction, ClsGcsAuthFileFunction, clsSummariesFunction As New RFunction
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
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverStation.SetParameter(New RParameter("station", 0))
        ucrReceiverStation.Selector = ucrSelectorExportDefinitions
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetMeAsReceiver()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

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
        ucrInputCountry.SetParameter(New RParameter("country", 20))

        ucrInputTokenPath.SetParameter(New RParameter("filename", 0))

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
        clsDummyFunction = New RFunction
        bResetSubdialog = True

        ucrSelectorExportDefinitions.Reset()

        clsDummyFunction.AddParameter("rain", "False", iPosition:=0)
        clsDummyFunction.AddParameter("temp", "False", iPosition:=1)
        clsDummyFunction.AddParameter("monthly_temp", "False", iPosition:=2)
        clsDummyFunction.AddParameter("extrem", "False", iPosition:=3)
        clsDummyFunction.AddParameter("season", "False", iPosition:=4)
        clsDummyFunction.AddParameter("crop", "False", iPosition:=5)

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

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(ClsGcsAuthFileFunction, 0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsExportRinstatToBucketFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverCropData.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverStation.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverDataYear.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverDataYearMonth.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverMonth.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverRain.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverYear.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrSelectorExportDefinitions.SetRCode(clsExportRinstatToBucketFunction)
        ucrInputTokenPath.SetRCode(ClsGcsAuthFileFunction, bReset)

        ucrInputDefinitionsID.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrInputCountry.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrChkIncludeSummaryData.SetRCode(clsExportRinstatToBucketFunction, bReset)
        If bReset Then
            ucrChkAnnualRainfall.SetRCode(clsDummyFunction, bReset)
            ucrChkAnnualTemp.SetRCode(clsDummyFunction, bReset)
            ucrChkCropSuccessProp.SetRCode(clsDummyFunction, bReset)
            ucrChkExtremes.SetRCode(clsDummyFunction, bReset)
            ucrChkMonthlyTemp.SetRCode(clsDummyFunction, bReset)
            ucrChkSeasonStartProp.SetRCode(clsDummyFunction, bReset)
        End If
        AddRemoveSummary()
        EnableDisableDefineButton()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverStation.IsEmpty AndAlso
           Not ucrReceiverYear.IsEmpty AndAlso
           Not ucrInputCountry.IsEmpty AndAlso
           Not ucrInputDefinitionsID.IsEmpty AndAlso
           Not ucrInputTokenPath.IsEmpty Then

            If (ucrChkCropSuccessProp.Checked OrElse ucrChkSeasonStartProp.Checked) AndAlso
               Not ucrReceiverCropData.IsEmpty Then
                ucrBase.OKEnabled(True)
            ElseIf ucrChkAnnualRainfall.Checked AndAlso
                   Not ucrReceiverRain.IsEmpty Then
                ucrBase.OKEnabled(True)
            ElseIf (ucrChkAnnualRainfall.Checked OrElse ucrChkAnnualTemp.Checked) AndAlso
                   Not ucrReceiverDataYear.IsEmpty Then
                ucrBase.OKEnabled(True)
            ElseIf ucrChkMonthlyTemp.Checked AndAlso
                   Not ucrReceiverMonth.IsEmpty AndAlso
                   Not ucrReceiverDataYearMonth.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
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
        ucrReceiverDataYearMonth.Visible = ucrChkMonthlyTemp.Checked
        ucrReceiverDataYear.Visible = ucrChkAnnualRainfall.Checked OrElse ucrChkAnnualTemp.Checked
        ucrReceiverRain.Visible = ucrChkAnnualRainfall.Checked
        ucrReceiverCropData.Visible = ucrChkCropSuccessProp.Checked OrElse ucrChkSeasonStartProp.Checked

    End Sub

    Private Sub ucrChkIncludeSummaryData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeSummaryData.ControlValueChanged
        EnableDisableDefineButton()
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "JSON Files|*.json"
            dlgOpen.Title = "Import JSON File"

            dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputTokenPath.GetText(), "/", "\"))

            If dlgOpen.ShowDialog() = DialogResult.OK AndAlso dlgOpen.FileName <> "" Then
                ucrInputTokenPath.SetName(Replace(dlgOpen.FileName, "\", "/"))
            End If
        End Using

    End Sub

    Private Sub ucrReceiverData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRain.ControlContentsChanged, ucrReceiverCropData.ControlContentsChanged, ucrReceiverDataYearMonth.ControlContentsChanged, ucrReceiverDataYear.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged,
            ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrChkSeasonStartProp.ControlContentsChanged, ucrInputCountry.ControlContentsChanged, ucrInputDefinitionsID.ControlContentsChanged, ucrChkIncludeSummaryData.ControlContentsChanged,
            ucrChkMonthlyTemp.ControlContentsChanged, ucrChkCropSuccessProp.ControlContentsChanged, ucrChkAnnualTemp.ControlContentsChanged, ucrChkAnnualRainfall.ControlContentsChanged, ucrInputTokenPath.ControlContentsChanged, ucrSelectorExportDefinitions.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorExportDefinitions_DataFrameChanged() Handles ucrSelectorExportDefinitions.DataFrameChanged
        TestOkEnabled()
    End Sub
End Class