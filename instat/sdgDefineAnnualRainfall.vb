'R-Instat
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
Public Class sdgDefineAnnualRainfall

    Public clsReforMattAnnualSummariesFunction, clsExportRinstatToBucketFunction, clsReformatCropSuccessFunction, clsReformatSeasonStartFunction, clsReformatTempSummariesFunction, clsReformatMonthlyTempSummaries As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False

    Private Sub sdgDefineAnnualRainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrSelectorDefineAnnualRain.SetParameter(New RParameter("data", 0))
        ucrSelectorDefineAnnualRain.SetParameterIsrfunction()

        ucrSelectorAnnualTemp.SetParameter(New RParameter("data", 0))
        ucrSelectorAnnualTemp.SetParameterIsrfunction()

        ucrSelectorCropProp.SetParameter(New RParameter("data", 0))
        ucrSelectorCropProp.SetParameterIsrfunction()

        ucrSelectorSeasonStartProp.SetParameter(New RParameter("data", 0))
        ucrSelectorSeasonStartProp.SetParameterIsrfunction()

        ucrSelecetorMonthlyTemp.SetParameter(New RParameter("data", 0))
        ucrSelecetorMonthlyTemp.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStation.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverYear.SetParameter(New RParameter("year_col", 2))
        ucrReceiverYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverYear.SetParameterIsString()

        ucrReceiverStartRainDOY.SetParameter(New RParameter("start_rains_doy_col", 3))
        ucrReceiverStartRainDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDOY.SetParameterIsString()

        ucrReceiverStartRainDate.SetParameter(New RParameter("start_rains_date_col", 4))
        ucrReceiverStartRainDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDate.SetParameterIsString()

        ucrReceiverEndRainsDOY.SetParameter(New RParameter("end_rains_doy_col", 5))
        ucrReceiverEndRainsDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDOY.SetParameterIsString()

        ucrReceiverEndRainsDate.SetParameter(New RParameter("end_rains_date_col", 6))
        ucrReceiverEndRainsDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDate.SetParameterIsString()

        ucrReceiverEndSeasonDOY.SetParameter(New RParameter("end_season_doy_col", 7))
        ucrReceiverEndSeasonDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDOY.SetParameterIsString()

        ucrReceiverEndSeasonDate.SetParameter(New RParameter("end_season_date_col", 8))
        ucrReceiverEndSeasonDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDate.SetParameterIsString()

        ucrReceiverSeasonalRain.SetParameter(New RParameter("seasonal_rain_col", 9))
        ucrReceiverSeasonalRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalRain.SetParameterIsString()

        ucrReceiverRainDaysSeason.SetParameter(New RParameter("n_seasonal_rain_col", 10))
        ucrReceiverRainDaysSeason.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysSeason.SetParameterIsString()

        ucrReceiverRainDaysYear.SetParameter(New RParameter("n_rain_col", 11))
        ucrReceiverRainDaysYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysYear.SetParameterIsString()

        ucrReceiverSeasonalLength.SetParameter(New RParameter("season_length_col", 12))
        ucrReceiverSeasonalLength.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalLength.SetParameterIsString()

        ucrReceiverAnnualRain.SetParameter(New RParameter("annual_rain_col", 13))
        ucrReceiverAnnualRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverAnnualRain.SetParameterIsString()

        ucrReceiverStationCrop.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStationCrop.Selector = ucrSelectorCropProp
        ucrReceiverStationCrop.SetParameterIsString()

        ucrReceiverTotalRain.SetParameter(New RParameter("total_rain_col", 2))
        ucrReceiverTotalRain.Selector = ucrSelectorCropProp
        ucrReceiverTotalRain.SetParameterIsString()

        ucrReceiverPlantingDay.SetParameter(New RParameter("plant_day_col", 3))
        ucrReceiverPlantingDay.Selector = ucrSelectorCropProp
        ucrReceiverPlantingDay.SetParameterIsString()

        ucrReceiverPlantingLenghth.SetParameter(New RParameter("plant_length_col", 4))
        ucrReceiverPlantingLenghth.Selector = ucrSelectorCropProp
        ucrReceiverPlantingLenghth.SetParameterIsString()

        ucrReceiverPropSuccess.SetParameter(New RParameter("prop_success_col", 5))
        ucrReceiverPropSuccess.Selector = ucrSelectorCropProp
        ucrReceiverPropSuccess.SetParameterIsString()

        'Season start
        ucrReceiverSeasonStationProb.SetParameter(New RParameter("station_col", 1))
        ucrReceiverSeasonStationProb.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonStationProb.SetParameterIsString()

        ucrReceiverSeasonYear.SetParameter(New RParameter("year_col", 2))
        ucrReceiverSeasonYear.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonYear.SetParameterIsString()


        ucrReceiverSeasonPlantingDay.SetParameter(New RParameter("plant_day_col", 3))
        ucrReceiverSeasonPlantingDay.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonPlantingDay.SetParameterIsString()


        ucrReceiverPlantingDayCondition.SetParameter(New RParameter("plant_day_cond_col", 5))
        ucrReceiverPlantingDayCondition.Selector = ucrSelectorSeasonStartProp
        ucrReceiverPlantingDayCondition.SetParameterIsString()

        'Annual Temp
        ucrReceiverAnnualTempStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverAnnualTempStation.Selector = ucrSelectorAnnualTemp
        ucrReceiverAnnualTempStation.SetParameterIsString()

        ucrReceiverAnnualTempYr.SetParameter(New RParameter("year_col", 2))
        ucrReceiverAnnualTempYr.Selector = ucrSelectorAnnualTemp
        ucrReceiverAnnualTempYr.SetParameterIsString()

        ucrReceiverMeanAnnual.SetParameter(New RParameter("mean_tmin_col", 3))
        ucrReceiverMeanAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMeanAnnual.SetParameterIsString()

        ucrReceiverMinMinAnnual.SetParameter(New RParameter("min_tmin_col", 4))
        ucrReceiverMinMinAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMinMinAnnual.SetParameterIsString()

        ucrReceiverMaxMinAnnual.SetParameter(New RParameter("max_tmin_col", 5))
        ucrReceiverMaxMinAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMaxMinAnnual.SetParameterIsString()

        ucrReceiverMeanMaxAnnual.SetParameter(New RParameter("mean_tmax_col", 6))
        ucrReceiverMeanMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMeanMaxAnnual.SetParameterIsString()

        ucrReceiverMinMaxAnnual.SetParameter(New RParameter("min_tmax_col", 7))
        ucrReceiverMinMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMinMaxAnnual.SetParameterIsString()

        ucrReceiverMaxMaxAnnual.SetParameter(New RParameter("max_tmax_col", 8))
        ucrReceiverMaxMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMaxMaxAnnual.SetParameterIsString()

        'Monthly Temp
        ucrReceiverMonthlyTemp.SetParameter(New RParameter("station_col", 1))
        ucrReceiverMonthlyTemp.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMonthlyTemp.SetParameterIsString()

        ucrReceiverYearMonthly.SetParameter(New RParameter("year_col", 2))
        ucrReceiverYearMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverYearMonthly.SetParameterIsString()

        ucrReceiverMonthMonthly.SetParameter(New RParameter("month_col", 3))
        ucrReceiverMonthMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMonthMonthly.SetParameterIsString()


        ucrReceiverMeanminMontly.SetParameter(New RParameter("mean_tmin_col", 4))
        ucrReceiverMeanminMontly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMeanminMontly.SetParameterIsString()

        ucrReceiverMinMinMonthly.SetParameter(New RParameter("min_tmin_col", 5))
        ucrReceiverMinMinMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMinMinMonthly.SetParameterIsString()

        ucrReceiverMaxMinMonthly.SetParameter(New RParameter("max_tmin_col", 6))
        ucrReceiverMaxMinMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMaxMinMonthly.SetParameterIsString()

        ucrReceiverMeanmaxMonthly.SetParameter(New RParameter("mean_tmax_col", 7))
        ucrReceiverMeanmaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMeanmaxMonthly.SetParameterIsString()

        ucrReceiverMinMaxMonthly.SetParameter(New RParameter("min_tmax_col", 8))
        ucrReceiverMinMaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMinMaxMonthly.SetParameterIsString()

        ucrReceiverMaxMaxMonthly.SetParameter(New RParameter("max_tmax_col", 9))
        ucrReceiverMaxMaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMaxMaxMonthly.SetParameterIsString()

    End Sub
    Public Sub SetRCode(clsNewReforMattAnnualSummaries As RFunction, clsNewExportRinstatToBucketFunction As RFunction, clsNewReformatCropSuccessFunction As RFunction, clsNewReformatMonthlyTempSummaries As RFunction, clsNewReformatSeasonStartFunction As RFunction, clsNewReformatTempSummariesFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsReforMattAnnualSummariesFunction = clsNewReforMattAnnualSummaries
        clsReformatCropSuccessFunction = clsNewReformatCropSuccessFunction
        clsReformatMonthlyTempSummaries = clsNewReformatMonthlyTempSummaries
        clsReformatSeasonStartFunction = clsNewReformatSeasonStartFunction
        clsReformatTempSummariesFunction = clsNewReformatTempSummariesFunction
        clsExportRinstatToBucketFunction = clsNewExportRinstatToBucketFunction

        ucrReceiverAnnualRain.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverEndRainsDate.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverEndRainsDOY.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverEndSeasonDate.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverEndSeasonDOY.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverRainDaysSeason.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverRainDaysYear.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverSeasonalLength.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverSeasonalRain.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverStartRainDate.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverStartRainDOY.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverStation.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverYear.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrSelectorDefineAnnualRain.SetRCode(clsReforMattAnnualSummariesFunction, bReset)

        ucrReceiverStationCrop.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverTotalRain.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPlantingDay.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPlantingLenghth.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPropSuccess.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrSelectorCropProp.SetRCode(clsReformatCropSuccessFunction, bReset)

        ucrReceiverSeasonStationProb.SetRCode(clsReformatSeasonStartFunction, bReset)
        ucrReceiverSeasonYear.SetRCode(clsReformatSeasonStartFunction, bReset)
        ucrReceiverSeasonPlantingDay.SetRCode(clsReformatSeasonStartFunction, bReset)
        ucrReceiverPlantingDayCondition.SetRCode(clsReformatSeasonStartFunction, bReset)
        ucrSelectorSeasonStartProp.SetRCode(clsReformatSeasonStartFunction, bReset)

        ucrReceiverAnnualTempStation.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverAnnualTempYr.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMeanAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMinMaxAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMaxMinAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMaxMaxAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMinMinAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrReceiverMeanMaxAnnual.SetRCode(clsReformatTempSummariesFunction, bReset)
        ucrSelectorAnnualTemp.SetRCode(clsReformatTempSummariesFunction, bReset)

        ucrReceiverMonthlyTemp.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverYearMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMonthMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMeanmaxMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMinMaxMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMaxMinMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMaxMaxMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMinMinMonthly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrReceiverMeanminMontly.SetRCode(clsReformatMonthlyTempSummaries, bReset)
        ucrSelecetorMonthlyTemp.SetRCode(clsReformatMonthlyTempSummaries, bReset)
    End Sub

    Private Sub ucrReceiverAnnualRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRain.ControlValueChanged, ucrReceiverEndRainsDate.ControlValueChanged, ucrReceiverEndRainsDOY.ControlValueChanged, ucrReceiverEndSeasonDate.ControlValueChanged,
            ucrReceiverEndSeasonDOY.ControlValueChanged, ucrReceiverRainDaysSeason.ControlValueChanged, ucrReceiverRainDaysYear.ControlValueChanged, ucrReceiverSeasonalLength.ControlValueChanged, ucrReceiverSeasonalRain.ControlValueChanged,
            ucrReceiverStartRainDate.ControlValueChanged, ucrReceiverStartRainDOY.ControlValueChanged, ucrReceiverStation.ControlValueChanged, ucrReceiverYear.ControlValueChanged

        If Not (ucrReceiverAnnualRain.IsEmpty AndAlso ucrReceiverEndRainsDate.IsEmpty AndAlso ucrReceiverEndRainsDOY.IsEmpty AndAlso ucrReceiverSeasonalLength.IsEmpty AndAlso ucrReceiverSeasonalRain.IsEmpty AndAlso
            ucrReceiverEndSeasonDate.IsEmpty AndAlso ucrReceiverEndSeasonDOY.IsEmpty AndAlso ucrReceiverRainDaysSeason.IsEmpty AndAlso ucrReceiverRainDaysYear.IsEmpty AndAlso ucrReceiverStartRainDate.IsEmpty AndAlso
           ucrReceiverStartRainDOY.IsEmpty AndAlso ucrReceiverStation.IsEmpty AndAlso ucrReceiverYear.IsEmpty) Then
            clsExportRinstatToBucketFunction.AddParameter("annual_rainfall_data", clsRFunctionParameter:=clsReforMattAnnualSummariesFunction, iPosition:=1)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_rainfall_data")
        End If
    End Sub

    Private Sub ucrReceiverStationCrop_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStationCrop.ControlValueChanged, ucrReceiverTotalRain.ControlValueChanged, ucrReceiverPlantingDay.ControlValueChanged, ucrReceiverPlantingLenghth.ControlValueChanged,
            ucrReceiverPropSuccess.ControlValueChanged

        If Not (ucrReceiverStationCrop.IsEmpty AndAlso ucrReceiverTotalRain.IsEmpty AndAlso ucrReceiverPlantingDay.IsEmpty AndAlso ucrReceiverPlantingLenghth.IsEmpty AndAlso ucrReceiverPropSuccess.IsEmpty) Then
            clsExportRinstatToBucketFunction.AddParameter("crop_success_data", clsRFunctionParameter:=clsReformatCropSuccessFunction, iPosition:=2)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("crop_success_data")
        End If
    End Sub

    Private Sub ucrReceiverSeasonStationProb_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSeasonStationProb.ControlValueChanged, ucrReceiverSeasonPlantingDay.ControlValueChanged, ucrReceiverPlantingDayCondition.ControlValueChanged, ucrReceiverSeasonYear.ControlValueChanged

        If Not (ucrReceiverSeasonStationProb.IsEmpty AndAlso ucrReceiverSeasonPlantingDay.IsEmpty AndAlso ucrReceiverPlantingDayCondition.IsEmpty AndAlso ucrReceiverSeasonYear.IsEmpty) Then
            clsExportRinstatToBucketFunction.AddParameter("season_start_data", clsRFunctionParameter:=clsReformatSeasonStartFunction, iPosition:=3)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("season_start_data")
        End If
    End Sub

    Private Sub ucrReceiverAnnualTempStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualTempStation.ControlValueChanged, ucrReceiverAnnualTempYr.ControlValueChanged, ucrReceiverMaxMaxAnnual.ControlValueChanged, ucrReceiverMaxMinAnnual.ControlValueChanged, ucrReceiverMeanAnnual.ControlValueChanged, ucrReceiverMeanMaxAnnual.ControlValueChanged, ucrReceiverMinMaxAnnual.ControlValueChanged, ucrReceiverMinMinAnnual.ControlValueChanged
        If Not (ucrReceiverAnnualTempStation.IsEmpty AndAlso ucrReceiverAnnualTempYr.IsEmpty AndAlso ucrReceiverMaxMaxAnnual.IsEmpty AndAlso
                ucrReceiverMaxMinAnnual.IsEmpty AndAlso ucrReceiverMeanAnnual.IsEmpty AndAlso ucrReceiverMeanMaxAnnual.IsEmpty AndAlso ucrReceiverMinMaxAnnual.IsEmpty AndAlso ucrReceiverMinMinAnnual.IsEmpty) Then
            clsExportRinstatToBucketFunction.AddParameter("annual_temperature_data", clsRFunctionParameter:=clsReformatTempSummariesFunction, iPosition:=4)
        Else

            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_temperature_data")
        End If
    End Sub

    Private Sub ucrReceiverMonthlyTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonthlyTemp.ControlValueChanged, ucrReceiverYearMonthly.ControlValueChanged, ucrReceiverMonthMonthly.ControlValueChanged, ucrReceiverMeanmaxMonthly.ControlValueChanged, ucrReceiverMeanminMontly.ControlValueChanged, ucrReceiverMinMaxMonthly.ControlValueChanged, ucrReceiverMinMinMonthly.ControlValueChanged, ucrReceiverMaxMinMonthly.ControlValueChanged, ucrReceiverMaxMaxMonthly.ControlValueChanged
        If Not (ucrReceiverMonthlyTemp.IsEmpty AndAlso ucrReceiverYearMonthly.IsEmpty AndAlso ucrReceiverMonthMonthly.IsEmpty AndAlso ucrReceiverMeanmaxMonthly.IsEmpty AndAlso ucrReceiverMeanminMontly.IsEmpty AndAlso ucrReceiverMinMaxMonthly.IsEmpty AndAlso ucrReceiverMinMinMonthly.IsEmpty AndAlso ucrReceiverMaxMinMonthly.IsEmpty AndAlso ucrReceiverMaxMaxMonthly.IsEmpty) Then
            clsExportRinstatToBucketFunction.AddParameter("monthly_temperature_data", clsRFunctionParameter:=clsReformatMonthlyTempSummaries, iPosition:=5)
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("monthly_temperature_data")
        End If
    End Sub

End Class