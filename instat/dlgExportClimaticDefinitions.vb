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
Public Class dlgExportClimaticDefinitions
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetRCode As Boolean = True
    Private clsExportRinstatToBucketFunction As New RFunction

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
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.Selector = ucrSelectorExportDefinitions
        ucrReceiverData.SetParameterIsRFunction()
        ucrReceiverData.SetMeAsReceiver()

        ucrReceiverDataYear.SetParameter(New RParameter("data_by_year", 1))
        ucrReceiverDataYear.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYear.SetParameterIsRFunction()

        ucrReceiverDataYearMonth.SetParameter(New RParameter("data_by_year_month", 2))
        ucrReceiverDataYearMonth.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYearMonth.SetParameterIsRFunction()

        ucrReceiverCropData.SetParameter(New RParameter("crop_data", 3))
        ucrReceiverCropData.Selector = ucrSelectorExportDefinitions
        ucrReceiverCropData.SetParameterIsRFunction()

        ucrReceiverMinTemp.SetParameter(New RParameter("tmin", 4))
        ucrReceiverMinTemp.Selector = ucrSelectorExportDefinitions
        ucrReceiverMinTemp.SetParameterIsRFunction()

        ucrReceiverMaxTemp.SetParameter(New RParameter("tmax", 5))
        ucrReceiverMaxTemp.Selector = ucrSelectorExportDefinitions
        ucrReceiverMaxTemp.SetParameterIsRFunction()

        ucrReceiverRain.SetParameter(New RParameter("rain", 6))
        ucrReceiverRain.Selector = ucrSelectorExportDefinitions
        ucrReceiverRain.SetParameterIsRFunction()

        ucrReceiverYear.SetParameter(New RParameter("year", 7))
        ucrReceiverYear.Selector = ucrSelectorExportDefinitions
        ucrReceiverYear.SetParameterIsRFunction()

        ucrReceiverMonth.SetParameter(New RParameter("month", 8))
        ucrReceiverMonth.Selector = ucrSelectorExportDefinitions
        ucrReceiverMonth.SetParameterIsRFunction()

        ucrChkAnnualRainfall.SetText("Annual Rainfall")
        ucrChkAnnualRainfall.SetParameter(New RParameter("annual_rainfall", 10))
        ucrChkAnnualRainfall.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAnnualRainfall.SetRDefault("FALSE")


        ucrChkAnnualTemp.SetText("Annual Temperature")
        ucrChkAnnualTemp.SetParameter(New RParameter("annual_temperature", 11))
        ucrChkAnnualTemp.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAnnualTemp.SetRDefault("FALSE")

        ucrChkExtremes.SetText("Extremes")
        ucrChkExtremes.SetParameter(New RParameter("extremes", 12))
        ucrChkExtremes.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkExtremes.SetRDefault("FALSE")

        ucrChkMonthlyTemp.SetText("Monthly Temperature")
        ucrChkMonthlyTemp.SetParameter(New RParameter("monthly_temperature", 13))
        ucrChkMonthlyTemp.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMonthlyTemp.SetRDefault("FALSE")

        ucrChkSeasonStartProp.SetText("Season Start Probabilities")
        ucrChkSeasonStartProp.SetParameter(New RParameter("start_season", 14))
        ucrChkSeasonStartProp.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSeasonStartProp.SetRDefault("FALSE")

        ucrChkSeasonStartProp.SetText("Season Start Probabilities")
        ucrChkSeasonStartProp.SetParameter(New RParameter("start_season", 15))
        ucrChkSeasonStartProp.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSeasonStartProp.SetRDefault("FALSE")

        ucrChkCropSuccessProp.SetText("Crop Success Probabilities")
        ucrChkCropSuccessProp.SetParameter(New RParameter("crop_success", 16))
        ucrChkCropSuccessProp.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCropSuccessProp.SetRDefault("FALSE")

        ucrChkIncludeSummaryData.SetText("Include Summary Data")
        ucrChkIncludeSummaryData.SetParameter(New RParameter("include_summary_data", 17))
        ucrChkIncludeSummaryData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIncludeSummaryData.SetRDefault("FALSE")

        ucrInputExportFile.SetParameter(New RParameter("file_name", 1))
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetLinkedDisplayControl(lblExport)

    End Sub

    Private Sub SetDefaults()
        clsExportRinstatToBucketFunction = New RFunction

        ucrSelectorExportDefinitions.Reset()

        clsExportRinstatToBucketFunction.SetPackageName("")
        clsExportRinstatToBucketFunction.SetRCommand("export_r_instat_to_bucket")

        ucrBase.clsRsyntax.SetBaseRFunction(clsExportRinstatToBucketFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverData.IsEmpty _
                             AndAlso Not ucrReceiverMonth.IsEmpty _
                             AndAlso Not ucrReceiverYear.IsEmpty _
                             AndAlso Not ucrReceiverCropData.IsEmpty _
                             AndAlso Not ucrReceiverRain.IsEmpty _
                             AndAlso Not ucrReceiverMinTemp.IsEmpty _
                             AndAlso Not ucrReceiverDataYear.IsEmpty _
                             AndAlso Not ucrReceiverDataYearMonth.IsEmpty _
                             AndAlso Not ucrReceiverMaxTemp.IsEmpty
                             )
        If ucrInputExportFile.IsEmpty Then
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectFileToSave()
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Climatic Def File"
            dlgSave.Filter = "JavaScript Object Notation (*.json)|*.json"
            If ucrInputExportFile.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputExportFile.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputExportFile.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

    Private Sub ucrReceiverData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged,
            ucrReceiverMaxTemp.ControlContentsChanged, ucrReceiverMinTemp.ControlContentsChanged, ucrReceiverCropData.ControlContentsChanged, ucrReceiverDataYearMonth.ControlContentsChanged, ucrReceiverDataYear.ControlContentsChanged,
            ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class