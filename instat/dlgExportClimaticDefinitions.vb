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
    Private clsExportRinstatToBucketFunction, clsSummariesFunction As New RFunction

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
        ucrReceiverData.SetItemType("dataframe")

        ucrReceiverDataYear.SetParameter(New RParameter("data_by_year", 1))
        ucrReceiverDataYear.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYear.SetParameterIsRFunction()
        ucrReceiverDataYear.SetItemType("dataframe")

        ucrReceiverDataYearMonth.SetParameter(New RParameter("data_by_year_month", 2))
        ucrReceiverDataYearMonth.Selector = ucrSelectorExportDefinitions
        ucrReceiverDataYearMonth.SetParameterIsRFunction()
        ucrReceiverDataYearMonth.SetItemType("dataframe")

        ucrReceiverCropData.SetParameter(New RParameter("crop_data", 3))
        ucrReceiverCropData.Selector = ucrSelectorExportDefinitions
        ucrReceiverCropData.SetParameterIsRFunction()
        ucrReceiverCropData.SetItemType("dataframe")

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

        ucrInputStationID.SetParameter(New RParameter("station_id", 18))

        ucrInputCountry.SetParameter(New RParameter("country", 19))


    End Sub

    Private Sub SetDefaults()
        clsExportRinstatToBucketFunction = New RFunction
        clsSummariesFunction = New RFunction

        ucrSelectorExportDefinitions.Reset()

        clsSummariesFunction.SetRCommand("c")

        clsExportRinstatToBucketFunction.SetPackageName("epicsawrap")
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
    End Sub

    Private Sub AddRemoveSummary()
        If ucrChkAnnualRainfall.Checked Then
            clsSummariesFunction.AddParameter("rain", "annual_rainfall", iPosition:=0, bIncludeArgumentName:=False)
        ElseIf ucrChkAnnualTemp.Checked Then
            clsSummariesFunction.AddParameter("temp", "annual_temperature", iPosition:=1, bIncludeArgumentName:=False)
        ElseIf ucrChkCropSuccessProp.Checked Then
            clsSummariesFunction.AddParameter("prop", "crop_success", iPosition:=2, bIncludeArgumentName:=False)
        ElseIf ucrChkExtremes.Checked Then
            clsSummariesFunction.AddParameter("extreme", "extremes", iPosition:=3, bIncludeArgumentName:=False)
        ElseIf ucrChkMonthlyTemp.Checked Then
            clsSummariesFunction.AddParameter("month_temp", "monthly_temperature", iPosition:=4, bIncludeArgumentName:=False)
        ElseIf ucrChkSeasonStartProp.Checked Then
            clsSummariesFunction.AddParameter("start_prop", "start_season", iPosition:=5, bIncludeArgumentName:=False)
        End If
        clsExportRinstatToBucketFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesFunction)
    End Sub
    Private Sub ucrReceiverData_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged,
            ucrReceiverMaxTemp.ControlContentsChanged, ucrReceiverMinTemp.ControlContentsChanged, ucrReceiverCropData.ControlContentsChanged, ucrReceiverDataYearMonth.ControlContentsChanged, ucrReceiverDataYear.ControlContentsChanged,
            ucrReceiverMonth.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAnnualRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAnnualRainfall.ControlValueChanged, ucrChkAnnualTemp.ControlValueChanged, ucrChkCropSuccessProp.ControlValueChanged,
            ucrChkExtremes.ControlValueChanged, ucrChkMonthlyTemp.ControlValueChanged, ucrChkSeasonStartProp.ControlValueChanged
        AddRemoveSummary()
    End Sub
End Class