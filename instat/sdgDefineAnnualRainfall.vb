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
Imports System.Text.RegularExpressions
Imports RDotNet
Public Class sdgDefineAnnualRainfall
    Private isFilling As Boolean = False
    Public clsReforMattAnnualSummariesFunction, clsExportRinstatToBucketFunction, clsReformatCropSuccessFunction, clsReformatSeasonStartFunction, clsReformatTempSummariesFunction, clsReformatMonthlyTempSummaries As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstReceiversCrop As New List(Of ucrReceiverSingle)
    Dim lstReceiversMonthTemp As New List(Of ucrReceiverSingle)
    Dim lstReceiversAnnualTemp As New List(Of ucrReceiverSingle)
    Dim lstReceiversProp As New List(Of ucrReceiverSingle)

    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedCropTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedPropTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedAnnTempTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Dim lstRecognisedMonthTempTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub sdgDefineAnnualRainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        AutoFillReceivers()
        AutoFillReceiversCrop()
        AutoFillReceiversForAnnualTemp()
        AutoFillReceiversForMonthlyTemp()
        AutoFillReceiversForSeasonsStart()

    End Sub

    Public Sub InitialiseControls()
        Dim kvpAnnualRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("annual_rain_col", {"annual_rainfall", "annual_rain", "annual_precip", "annual_precipitation", "annual_rr", "annual_prec", "annual_prcp", "sum_rainfall", "sum_rain", "sum_precip", "sum_precipitation", "sum_rr", "sum_pre", "sum_prcp"}.ToList())
        Dim kvpSeasonalRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("seasonal_rain_col", {"seasonal_rainfall", "seasonal_rain", "seasonal_precip", "seasonal_precipitation", "seasonal_rr", "seasonal_prec", "seasonal_prcp"}.ToList())
        Dim kvpRainDaysYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("n_rain_col", {"annual_rainday", "sum_rainday"}.ToList())
        Dim kvpRainDaysSeason As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("n_seasonal_rain_col", {"seasonal_rainday"}.ToList())
        Dim kvpSeasonalLength As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("season_length_col", {"length"}.ToList())
        Dim kvpStartRainDOY As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("start_rains_doy_col", {"start_rain"}.ToList())
        Dim kvpStartRainDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("start_rains_date_col", {"start_rain_date"}.ToList())
        Dim kvpEndRainDOY As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_rains_doy_col", {"end_rains"}.ToList())
        Dim kvpEndRainDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_rains_date_col", {"end_rains_date"}.ToList())
        Dim kvpEndSeasonDOY As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_season_doy_col", {"end_season"}.ToList())
        Dim kvpEndSeasonDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_season_date_col", {"end_season_date"}.ToList())
        Dim kvpStartRainStatus As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("start_rains_status_column", {"start_rain_status"}.ToList())
        Dim kvpEndRainStatus As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_rains_status_column", {"end_rains_status"}.ToList())
        Dim kvpEndSeasonStatus As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("end_season_status_column", {"end_season_status"}.ToList())

        Dim kvpMeanMinTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("mean_tmin_col", {"mean_tmin", "mean_tn", "mean_tempmin", "mean_tmp_min", "mean_tmpmin", "mean_temperature_min", "mean_min_temperature"}.ToList())
        Dim kvpMinMinTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("min_tmin_col", {"min_tmin", "min_tn", "min_tempmin", "min_tmp_min", "min_tmpmin", "min_temperature_min", "min_min_temperature"}.ToList())
        Dim kvpMaxMinTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("max_tmin_col", {"max_tmin", "max_tn", "max_tempmin", "max_tmp_min", "max_tmpmin", "max_temperature_min", "max_min_temperature"}.ToList())
        Dim kvpMeanMaxTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("mean_tmax_col", {"mean_tmax", "mean_tx", "mean_tempmax", "mean_tmp_max", "mean_tmpmax", "mean_temperature_max", "mean_max_temperature"}.ToList())
        Dim kvpMinMaxTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("min_tmax_col", {"min_tmax", "min_tx", "min_tempmax", "min_tmp_max", "min_tmpmax", "min_temperature_max", "min_max_temperature"}.ToList())
        Dim kvpMaxMaxTemp As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("max_tmax_col", {"max_tmax", "max_tx", "max_tempmax", "max_tmp_max", "max_tmpmax", "max_temperature_max", "max_max_temperature"}.ToList())

        Dim kvpTotalRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("total_rain_col", {"rain_total"}.ToList())
        Dim kvpPlantDay As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("plant_day_col", {"plant_day"}.ToList())
        Dim kvpPlantLength As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("plant_length_col", {"plant_length"}.ToList())
        Dim kvpPropSuccess As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("prop_success_col", {"prop_success", "prop_success_with_start"}.ToList())
        Dim kvpPropSuccessNoStart As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("prop_success_no_start_col", {"prop_success", "prop_success_no_start"}.ToList())
        Dim kvpStationCrop As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "id", "name"}.ToList())

        Dim kvpPlantingDay As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("plant_day_col", {"plant_day"}.ToList())
        Dim kvpPlantDayCond As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("plant_day_cond_col", {"plant_day_cond"}.ToList())
        Dim kvpStationProb As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "id", "name"}.ToList())
        Dim kvpYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("year", {"year", "s_year"}.ToList())

        lstRecognisedTypes.AddRange({kvpAnnualRain, kvpEndRainDate, kvpEndRainDOY, kvpEndRainStatus, kvpEndSeasonDate, kvpEndSeasonDOY, kvpEndSeasonStatus,
                                     kvpRainDaysSeason, kvpRainDaysYear, kvpSeasonalLength, kvpSeasonalRain, kvpStartRainDate,
                                    kvpStartRainDOY, kvpStartRainStatus})
        lstRecognisedCropTypes.AddRange({kvpTotalRain, kvpStationCrop, kvpPlantDay, kvpPlantLength, kvpPropSuccess, kvpPropSuccessNoStart})
        lstRecognisedPropTypes.AddRange({kvpPlantingDay, kvpYear, kvpStationProb, kvpPlantDayCond})
        lstRecognisedMonthTempTypes.AddRange({kvpMeanMinTemp, kvpMinMinTemp, kvpMaxMinTemp, kvpMeanMaxTemp, kvpMinMaxTemp, kvpMaxMaxTemp})
        lstRecognisedAnnTempTypes.AddRange({kvpMeanMinTemp, kvpMinMinTemp, kvpMaxMinTemp, kvpMeanMaxTemp, kvpMinMaxTemp, kvpMaxMaxTemp})

        lstReceivers.AddRange({ucrReceiverAnnualRain, ucrReceiverEndRainsDate, ucrReceiverEndRainsDOY, ucrReceiverEndRainStatus, ucrReceiverEndSeasonDate, ucrReceiverEndSeasonDOY, ucrReceiverEndSeasonStatus, ucrReceiverRainDaysSeason, ucrReceiverRainDaysYear, ucrReceiverSeasonalLength, ucrReceiverSeasonalRain, ucrReceiverStartRainDate, ucrReceiverStartRainDOY, ucrReceiverStartRainStatus})
        lstReceiversAnnualTemp.AddRange({ucrReceiverMaxMaxAnnual, ucrReceiverMaxMaxMonthly, ucrReceiverMaxMinAnnual, ucrReceiverMaxMinMonthly, ucrReceiverMeanAnnual, ucrReceiverMeanMaxAnnual, ucrReceiverMeanmaxMonthly, ucrReceiverMeanminMontly, ucrReceiverMinMaxAnnual, ucrReceiverMinMaxMonthly, ucrReceiverMinMinAnnual, ucrReceiverMinMinMonthly})
        lstReceiversMonthTemp.AddRange({ucrReceiverMaxMaxAnnual, ucrReceiverMaxMaxMonthly, ucrReceiverMaxMinAnnual, ucrReceiverMaxMinMonthly, ucrReceiverMeanAnnual, ucrReceiverMeanMaxAnnual, ucrReceiverMeanmaxMonthly, ucrReceiverMeanminMontly, ucrReceiverMinMaxAnnual, ucrReceiverMinMaxMonthly, ucrReceiverMinMinAnnual, ucrReceiverMinMinMonthly})
        lstReceiversCrop.AddRange({ucrReceiverPlantingDay, ucrReceiverStationCrop, ucrReceiverPlantingLenghth, ucrReceiverPropSuccess, ucrReceiverPropSuccessNoStart, ucrReceiverTotalRain})
        lstReceiversProp.AddRange({ucrReceiverPlantingDayCondition, ucrReceiverSeasonYear, ucrReceiverSeasonStationProb, ucrReceiverSeasonPlantingDay})

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
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bExcludeFromSelector = True

        ucrReceiverYear.SetParameter(New RParameter("year_col", 2))
        ucrReceiverYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bExcludeFromSelector = True

        ucrReceiverStartRainDOY.SetParameter(New RParameter("start_rains_doy_col", 3))
        ucrReceiverStartRainDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDOY.SetParameterIsString()
        ucrReceiverStartRainDOY.Tag = "start_rains_doy_col"
        ucrReceiverStartRainDOY.bExcludeFromSelector = True

        ucrReceiverStartRainDate.SetParameter(New RParameter("start_rains_date_col", 4))
        ucrReceiverStartRainDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDate.SetParameterIsString()
        ucrReceiverStartRainDate.Tag = "start_rains_date_col"
        ucrReceiverStartRainDate.bExcludeFromSelector = True

        ucrReceiverEndRainsDOY.SetParameter(New RParameter("end_rains_doy_col", 5))
        ucrReceiverEndRainsDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDOY.SetParameterIsString()
        ucrReceiverEndRainsDOY.Tag = "end_rains_doy_col"
        ucrReceiverEndRainsDOY.bExcludeFromSelector = True

        ucrReceiverEndRainsDate.SetParameter(New RParameter("end_rains_date_col", 6))
        ucrReceiverEndRainsDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDate.SetParameterIsString()
        ucrReceiverEndRainsDate.Tag = "end_rains_date_col"
        ucrReceiverEndRainsDate.bExcludeFromSelector = True

        ucrReceiverEndSeasonDOY.SetParameter(New RParameter("end_season_doy_col", 7))
        ucrReceiverEndSeasonDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDOY.SetParameterIsString()
        ucrReceiverEndSeasonDOY.Tag = "end_season_doy_col"
        ucrReceiverEndSeasonDOY.bExcludeFromSelector = True

        ucrReceiverEndSeasonDate.SetParameter(New RParameter("end_season_date_col", 8))
        ucrReceiverEndSeasonDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDate.SetParameterIsString()
        ucrReceiverEndSeasonDate.Tag = "end_season_date_col"
        ucrReceiverEndSeasonDate.bExcludeFromSelector = True

        ucrReceiverSeasonalRain.SetParameter(New RParameter("seasonal_rain_col", 9))
        ucrReceiverSeasonalRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalRain.SetParameterIsString()
        ucrReceiverSeasonalRain.Tag = "seasonal_rain_col"
        ucrReceiverSeasonalRain.bExcludeFromSelector = True

        ucrReceiverRainDaysSeason.SetParameter(New RParameter("n_seasonal_rain_col", 10))
        ucrReceiverRainDaysSeason.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysSeason.SetParameterIsString()
        ucrReceiverRainDaysSeason.Tag = "n_seasonal_rain_col"
        ucrReceiverRainDaysSeason.bExcludeFromSelector = True

        ucrReceiverRainDaysYear.SetParameter(New RParameter("n_rain_col", 11))
        ucrReceiverRainDaysYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysYear.SetParameterIsString()
        ucrReceiverRainDaysYear.Tag = "n_rain_col"
        ucrReceiverRainDaysYear.bExcludeFromSelector = True

        ucrReceiverSeasonalLength.SetParameter(New RParameter("season_length_col", 12))
        ucrReceiverSeasonalLength.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalLength.SetParameterIsString()
        ucrReceiverSeasonalLength.Tag = "season_length_col"
        ucrReceiverSeasonalLength.bExcludeFromSelector = True

        ucrReceiverAnnualRain.SetParameter(New RParameter("annual_rain_col", 13))
        ucrReceiverAnnualRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverAnnualRain.SetParameterIsString()
        ucrReceiverAnnualRain.Tag = "annual_rain_col"
        ucrReceiverAnnualRain.bExcludeFromSelector = True

        ucrReceiverExtremRian.SetParameter(New RParameter("extreme_rain_days_col", 13))
        ucrReceiverExtremRian.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverExtremRian.SetParameterIsString()
        ucrReceiverExtremRian.bExcludeFromSelector = True

        ucrReceiverStartRainStatus.SetParameter(New RParameter("start_rains_status_column", 14))
        ucrReceiverStartRainStatus.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainStatus.SetParameterIsString()
        ucrReceiverStartRainStatus.Tag = "start_rains_status_column"
        ucrReceiverStartRainStatus.bExcludeFromSelector = True

        ucrReceiverEndRainStatus.SetParameter(New RParameter("end_rains_status_column", 15))
        ucrReceiverEndRainStatus.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainStatus.SetParameterIsString()
        ucrReceiverEndRainStatus.Tag = "end_rains_status_column"
        ucrReceiverEndRainStatus.bExcludeFromSelector = True

        ucrReceiverEndSeasonStatus.SetParameter(New RParameter("end_season_status_column", 16))
        ucrReceiverEndSeasonStatus.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonStatus.SetParameterIsString()
        ucrReceiverEndSeasonStatus.Tag = "end_season_status_column"
        ucrReceiverEndSeasonStatus.bExcludeFromSelector = True

        ucrReceiverStationCrop.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStationCrop.Selector = ucrSelectorCropProp
        ucrReceiverStationCrop.SetParameterIsString()
        ucrReceiverStationCrop.Tag = "station"
        ucrReceiverStationCrop.bExcludeFromSelector = True

        ucrReceiverTotalRain.SetParameter(New RParameter("total_rain_col", 2))
        ucrReceiverTotalRain.Selector = ucrSelectorCropProp
        ucrReceiverTotalRain.SetParameterIsString()
        ucrReceiverTotalRain.Tag = "total_rain_col"
        ucrReceiverTotalRain.bExcludeFromSelector = True

        ucrReceiverPlantingDay.SetParameter(New RParameter("plant_day_col", 3))
        ucrReceiverPlantingDay.Selector = ucrSelectorCropProp
        ucrReceiverPlantingDay.SetParameterIsString()
        ucrReceiverPlantingDay.Tag = "plant_day_col"
        ucrReceiverPlantingDay.bExcludeFromSelector = True

        ucrReceiverPlantingLenghth.SetParameter(New RParameter("plant_length_col", 4))
        ucrReceiverPlantingLenghth.Selector = ucrSelectorCropProp
        ucrReceiverPlantingLenghth.SetParameterIsString()
        ucrReceiverPlantingLenghth.Tag = "plant_length_col"
        ucrReceiverPlantingLenghth.bExcludeFromSelector = True

        ucrReceiverPropSuccess.SetParameter(New RParameter("prop_success_with_start_col", 5))
        ucrReceiverPropSuccess.Selector = ucrSelectorCropProp
        ucrReceiverPropSuccess.SetParameterIsString()
        ucrReceiverPropSuccess.Tag = "prop_success_col"
        ucrReceiverPropSuccess.bExcludeFromSelector = True

        ucrReceiverPropSuccessNoStart.SetParameter(New RParameter("prop_success_no_start_col", 5))
        ucrReceiverPropSuccessNoStart.Selector = ucrSelectorCropProp
        ucrReceiverPropSuccessNoStart.SetParameterIsString()
        ucrReceiverPropSuccessNoStart.Tag = "prop_success_no_start_col"
        ucrReceiverPropSuccessNoStart.bExcludeFromSelector = True

        'Season start
        ucrReceiverSeasonStationProb.SetParameter(New RParameter("station_col", 1))
        ucrReceiverSeasonStationProb.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonStationProb.SetParameterIsString()
        ucrReceiverSeasonStationProb.Tag = "station"
        ucrReceiverSeasonStationProb.bExcludeFromSelector = True

        ucrReceiverSeasonYear.SetParameter(New RParameter("year_col", 2))
        ucrReceiverSeasonYear.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonYear.SetParameterIsString()
        ucrReceiverSeasonYear.Tag = "year"
        ucrReceiverSeasonYear.bExcludeFromSelector = True

        ucrReceiverSeasonPlantingDay.SetParameter(New RParameter("plant_day_col", 3))
        ucrReceiverSeasonPlantingDay.Selector = ucrSelectorSeasonStartProp
        ucrReceiverSeasonPlantingDay.SetParameterIsString()
        ucrReceiverSeasonPlantingDay.Tag = "plant_day_col"
        ucrReceiverSeasonPlantingDay.bExcludeFromSelector = True

        ucrReceiverPlantingDayCondition.SetParameter(New RParameter("plant_day_cond_col", 5))
        ucrReceiverPlantingDayCondition.Selector = ucrSelectorSeasonStartProp
        ucrReceiverPlantingDayCondition.SetParameterIsString()
        ucrReceiverPlantingDayCondition.Tag = "plant_day_cond_col"
        ucrReceiverPlantingDayCondition.bExcludeFromSelector = True

        'Annual Temp
        ucrReceiverAnnualTempStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverAnnualTempStation.Selector = ucrSelectorAnnualTemp
        ucrReceiverAnnualTempStation.SetParameterIsString()
        ucrReceiverAnnualTempStation.SetClimaticType("station")
        ucrReceiverAnnualTempStation.bAutoFill = True
        ucrReceiverAnnualTempStation.bExcludeFromSelector = True

        ucrReceiverAnnualTempYr.SetParameter(New RParameter("year_col", 2))
        ucrReceiverAnnualTempYr.Selector = ucrSelectorAnnualTemp
        ucrReceiverAnnualTempYr.SetParameterIsString()
        ucrReceiverAnnualTempYr.SetClimaticType("year")
        ucrReceiverAnnualTempYr.bAutoFill = True
        ucrReceiverAnnualTempYr.bExcludeFromSelector = True

        ucrReceiverMeanAnnual.SetParameter(New RParameter("mean_tmin_col", 3))
        ucrReceiverMeanAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMeanAnnual.SetParameterIsString()
        ucrReceiverMeanAnnual.Tag = "mean_tmin_col"
        ucrReceiverMeanAnnual.bExcludeFromSelector = True

        ucrReceiverMinMinAnnual.SetParameter(New RParameter("min_tmin_col", 4))
        ucrReceiverMinMinAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMinMinAnnual.SetParameterIsString()
        ucrReceiverMinMinAnnual.Tag = "min_tmin_col"
        ucrReceiverMinMinAnnual.bExcludeFromSelector = True

        ucrReceiverMaxMinAnnual.SetParameter(New RParameter("max_tmin_col", 5))
        ucrReceiverMaxMinAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMaxMinAnnual.SetParameterIsString()
        ucrReceiverMaxMinAnnual.Tag = "max_tmin_col"
        ucrReceiverMaxMinAnnual.bExcludeFromSelector = True

        ucrReceiverMeanMaxAnnual.SetParameter(New RParameter("mean_tmax_col", 6))
        ucrReceiverMeanMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMeanMaxAnnual.SetParameterIsString()
        ucrReceiverMeanMaxAnnual.Tag = "mean_tmax_col"
        ucrReceiverMeanMaxAnnual.bExcludeFromSelector = True

        ucrReceiverMinMaxAnnual.SetParameter(New RParameter("min_tmax_col", 7))
        ucrReceiverMinMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMinMaxAnnual.SetParameterIsString()
        ucrReceiverMinMaxAnnual.Tag = "min_tmax_col"
        ucrReceiverMinMaxAnnual.bExcludeFromSelector = True

        ucrReceiverMaxMaxAnnual.SetParameter(New RParameter("max_tmax_col", 8))
        ucrReceiverMaxMaxAnnual.Selector = ucrSelectorAnnualTemp
        ucrReceiverMaxMaxAnnual.SetParameterIsString()
        ucrReceiverMaxMaxAnnual.Tag = "max_tmax_col"
        ucrReceiverMaxMaxAnnual.bExcludeFromSelector = True

        'Monthly Temp
        ucrReceiverMonthlyTemp.SetParameter(New RParameter("station_col", 1))
        ucrReceiverMonthlyTemp.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMonthlyTemp.SetParameterIsString()
        ucrReceiverMonthlyTemp.SetClimaticType("station")
        ucrReceiverMonthlyTemp.bAutoFill = True
        ucrReceiverMonthlyTemp.bExcludeFromSelector = True

        ucrReceiverYearMonthly.SetParameter(New RParameter("year_col", 2))
        ucrReceiverYearMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverYearMonthly.SetParameterIsString()
        ucrReceiverYearMonthly.SetClimaticType("year")
        ucrReceiverYearMonthly.bAutoFill = True
        ucrReceiverYearMonthly.bExcludeFromSelector = True

        ucrReceiverMonthMonthly.SetParameter(New RParameter("month_col", 3))
        ucrReceiverMonthMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMonthMonthly.SetParameterIsString()
        ucrReceiverMonthMonthly.SetClimaticType("month")
        ucrReceiverMonthMonthly.bAutoFill = True
        ucrReceiverMonthMonthly.bExcludeFromSelector = True

        ucrReceiverMeanminMontly.SetParameter(New RParameter("mean_tmin_col", 4))
        ucrReceiverMeanminMontly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMeanminMontly.SetParameterIsString()
        ucrReceiverMeanminMontly.Tag = "mean_tmin_col"
        ucrReceiverMeanminMontly.bExcludeFromSelector = True

        ucrReceiverMinMinMonthly.SetParameter(New RParameter("min_tmin_col", 5))
        ucrReceiverMinMinMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMinMinMonthly.SetParameterIsString()
        ucrReceiverMinMinMonthly.Tag = "min_tmin_col"
        ucrReceiverMinMinMonthly.bExcludeFromSelector = True

        ucrReceiverMaxMinMonthly.SetParameter(New RParameter("max_tmin_col", 6))
        ucrReceiverMaxMinMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMaxMinMonthly.SetParameterIsString()
        ucrReceiverMaxMinMonthly.Tag = "max_tmin_col"
        ucrReceiverMaxMinMonthly.bExcludeFromSelector = True

        ucrReceiverMeanmaxMonthly.SetParameter(New RParameter("mean_tmax_col", 7))
        ucrReceiverMeanmaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMeanmaxMonthly.SetParameterIsString()
        ucrReceiverMeanmaxMonthly.Tag = "mean_tmax_col"
        ucrReceiverMeanmaxMonthly.bExcludeFromSelector = True

        ucrReceiverMinMaxMonthly.SetParameter(New RParameter("min_tmax_col", 8))
        ucrReceiverMinMaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMinMaxMonthly.SetParameterIsString()
        ucrReceiverMinMaxMonthly.Tag = "min_tmax_col"
        ucrReceiverMinMaxMonthly.bExcludeFromSelector = True

        ucrReceiverMaxMaxMonthly.SetParameter(New RParameter("max_tmax_col", 9))
        ucrReceiverMaxMaxMonthly.Selector = ucrSelecetorMonthlyTemp
        ucrReceiverMaxMaxMonthly.SetParameterIsString()
        ucrReceiverMaxMaxMonthly.Tag = "max_tmax_col"
        ucrReceiverMaxMaxMonthly.bExcludeFromSelector = True
        bControlsInitialised = True

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

        ucrReceiverSeasonalLength.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("seasonal_length_column", 12), iAdditionalPairNo:=1)
        ucrReceiverEndSeasonDOY.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("end_season_column", 7), iAdditionalPairNo:=1)
        ucrReceiverStartRainDOY.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("start_rains_column", 3), iAdditionalPairNo:=1)
        ucrReceiverEndRainsDOY.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("end_rains_column", 6), iAdditionalPairNo:=1)

        ucrReceiverMinMaxAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("min_tmax_column", 7), iAdditionalPairNo:=1)
        ucrReceiverMaxMaxAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("max_tmax_column", 8), iAdditionalPairNo:=1)
        ucrReceiverMeanMaxAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("mean_tmax_column", 6), iAdditionalPairNo:=1)
        ucrReceiverMeanAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("mean_tmin_column", 3), iAdditionalPairNo:=1)
        ucrReceiverMinMinAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("min_tmin_column", 4), iAdditionalPairNo:=1)
        ucrReceiverMaxMinAnnual.AddAdditionalCodeParameterPair(clsExportRinstatToBucketFunction, New RParameter("max_tmin_column", 5), iAdditionalPairNo:=1)

        ucrReceiverAnnualRain.SetRCode(clsReforMattAnnualSummariesFunction, bReset)
        ucrReceiverExtremRian.SetRCode(clsReforMattAnnualSummariesFunction, bReset)

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
        ucrReceiverStartRainStatus.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverEndRainStatus.SetRCode(clsExportRinstatToBucketFunction, bReset)
        ucrReceiverEndSeasonStatus.SetRCode(clsExportRinstatToBucketFunction, bReset)

        ucrReceiverStationCrop.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverTotalRain.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPlantingDay.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPlantingLenghth.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPropSuccess.SetRCode(clsReformatCropSuccessFunction, bReset)
        ucrReceiverPropSuccessNoStart.SetRCode(clsReformatCropSuccessFunction, bReset)
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
        AutoFillReceivers()
        AutoFillReceiversCrop()
        AutoFillReceiversForAnnualTemp()
        AutoFillReceiversForMonthlyTemp()
        AutoFillReceiversForSeasonsStart()
    End Sub

    Private Sub ucrReceiverAnnualRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRain.ControlValueChanged, ucrReceiverEndRainsDate.ControlValueChanged, ucrReceiverEndRainsDOY.ControlValueChanged, ucrReceiverEndSeasonDate.ControlValueChanged,
            ucrReceiverEndSeasonDOY.ControlValueChanged, ucrReceiverRainDaysSeason.ControlValueChanged, ucrReceiverRainDaysYear.ControlValueChanged, ucrReceiverSeasonalLength.ControlValueChanged, ucrReceiverSeasonalRain.ControlValueChanged,
            ucrReceiverStartRainDate.ControlValueChanged, ucrReceiverStartRainDOY.ControlValueChanged, ucrReceiverStation.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverExtremRian.ControlValueChanged

        If dlgExportClimaticDefinitions.ucrChkAnnualRainfall.Checked Then
            If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso (Not ucrReceiverAnnualRain.IsEmpty OrElse Not ucrReceiverEndRainsDate.IsEmpty OrElse Not ucrReceiverEndRainsDOY.IsEmpty OrElse Not ucrReceiverSeasonalLength.IsEmpty OrElse Not ucrReceiverExtremRian.IsEmpty OrElse Not ucrReceiverSeasonalRain.IsEmpty OrElse
             Not ucrReceiverEndSeasonDate.IsEmpty OrElse Not ucrReceiverEndSeasonDOY.IsEmpty OrElse Not ucrReceiverRainDaysSeason.IsEmpty OrElse Not ucrReceiverRainDaysYear.IsEmpty OrElse Not ucrReceiverStartRainDate.IsEmpty OrElse
             Not ucrReceiverStartRainDOY.IsEmpty) Then

                clsExportRinstatToBucketFunction.AddParameter("annual_rainfall_data", clsRFunctionParameter:=clsReforMattAnnualSummariesFunction, iPosition:=1)

            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("annual_rainfall_data")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_rainfall_data")
        End If
        AddAnnualSummariesPar()
    End Sub

    Private Sub ucrReceiverStationCrop_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStationCrop.ControlValueChanged, ucrReceiverTotalRain.ControlValueChanged, ucrReceiverPlantingDay.ControlValueChanged, ucrReceiverPlantingLenghth.ControlValueChanged,
            ucrReceiverPropSuccess.ControlValueChanged, ucrReceiverPropSuccessNoStart.ControlValueChanged

        If dlgExportClimaticDefinitions.ucrChkCropSuccessProp.Checked Then

            If Not ucrReceiverStationCrop.IsEmpty AndAlso (Not ucrReceiverTotalRain.IsEmpty OrElse Not ucrReceiverPlantingDay.IsEmpty OrElse Not ucrReceiverPlantingLenghth.IsEmpty OrElse Not ucrReceiverPropSuccess.IsEmpty OrElse Not ucrReceiverPropSuccessNoStart.IsEmpty) Then
                clsExportRinstatToBucketFunction.AddParameter("crop_success_data", clsRFunctionParameter:=clsReformatCropSuccessFunction, iPosition:=9)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("crop_success_data")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("crop_success_data")
        End If
    End Sub

    Private Sub ucrReceiverSeasonStationProb_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSeasonStationProb.ControlValueChanged, ucrReceiverSeasonPlantingDay.ControlValueChanged, ucrReceiverPlantingDayCondition.ControlValueChanged, ucrReceiverSeasonYear.ControlValueChanged
        If dlgExportClimaticDefinitions.ucrChkSeasonStartProp.Checked Then
            If Not ucrReceiverSeasonStationProb.IsEmpty AndAlso Not ucrReceiverSeasonYear.IsEmpty AndAlso (Not ucrReceiverSeasonPlantingDay.IsEmpty OrElse Not ucrReceiverPlantingDayCondition.IsEmpty) Then
                clsExportRinstatToBucketFunction.AddParameter("season_start_data", clsRFunctionParameter:=clsReformatSeasonStartFunction, iPosition:=10)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("season_start_data")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("season_start_data")
        End If
    End Sub

    Private Sub ucrReceiverAnnualTempStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualTempStation.ControlValueChanged, ucrReceiverAnnualTempYr.ControlValueChanged, ucrReceiverMaxMaxAnnual.ControlValueChanged, ucrReceiverMaxMinAnnual.ControlValueChanged, ucrReceiverMeanAnnual.ControlValueChanged, ucrReceiverMeanMaxAnnual.ControlValueChanged, ucrReceiverMinMaxAnnual.ControlValueChanged, ucrReceiverMinMinAnnual.ControlValueChanged

        If dlgExportClimaticDefinitions.ucrChkAnnualTemp.Checked Then
            If Not ucrReceiverAnnualTempStation.IsEmpty AndAlso Not ucrReceiverAnnualTempYr.IsEmpty AndAlso (Not ucrReceiverMaxMaxAnnual.IsEmpty OrElse
                            Not ucrReceiverMaxMinAnnual.IsEmpty OrElse Not ucrReceiverMeanAnnual.IsEmpty OrElse Not ucrReceiverMeanMaxAnnual.IsEmpty OrElse Not ucrReceiverMinMaxAnnual.IsEmpty OrElse Not ucrReceiverMinMinAnnual.IsEmpty) Then
                clsExportRinstatToBucketFunction.AddParameter("annual_temperature_data", clsRFunctionParameter:=clsReformatTempSummariesFunction, iPosition:=11)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("annual_temperature_data")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_temperature_data")
        End If
    End Sub

    Private Sub ucrReceiverMonthlyTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonthlyTemp.ControlValueChanged, ucrReceiverYearMonthly.ControlValueChanged, ucrReceiverMonthMonthly.ControlValueChanged, ucrReceiverMeanmaxMonthly.ControlValueChanged, ucrReceiverMeanminMontly.ControlValueChanged, ucrReceiverMinMaxMonthly.ControlValueChanged, ucrReceiverMinMinMonthly.ControlValueChanged, ucrReceiverMaxMinMonthly.ControlValueChanged, ucrReceiverMaxMaxMonthly.ControlValueChanged
        If dlgExportClimaticDefinitions.ucrChkMonthlyTemp.Checked Then
            If Not ucrReceiverMonthlyTemp.IsEmpty AndAlso Not ucrReceiverYearMonthly.IsEmpty AndAlso Not ucrReceiverMonthMonthly.IsEmpty AndAlso (Not ucrReceiverMeanmaxMonthly.IsEmpty OrElse Not ucrReceiverMeanminMontly.IsEmpty OrElse Not ucrReceiverMinMaxMonthly.IsEmpty OrElse Not ucrReceiverMinMinMonthly.IsEmpty OrElse Not ucrReceiverMaxMinMonthly.IsEmpty OrElse Not ucrReceiverMaxMaxMonthly.IsEmpty) Then
                clsExportRinstatToBucketFunction.AddParameter("monthly_temperature_data", clsRFunctionParameter:=clsReformatMonthlyTempSummaries, iPosition:=18)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("monthly_temperature_data")
            End If
        Else
            clsExportRinstatToBucketFunction.RemoveParameterByName("monthly_temperature_data")
        End If
    End Sub

    Private Sub AutoFillReceivers()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorDefineAnnualRain.ControlValueChanged, AddressOf AutoFillReceivers

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorDefineAnnualRain.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorDefineAnnualRain.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorDefineAnnualRain.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorDefineAnnualRain.ControlValueChanged, AddressOf AutoFillReceivers

        isFilling = False
    End Sub

    Private Sub AutoFillReceiversCrop()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorCropProp.ControlValueChanged, AddressOf AutoFillReceiversCrop

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorCropProp.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversCrop
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesCrop(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorCropProp.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorCropProp.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorCropProp.ControlValueChanged, AddressOf AutoFillReceiversCrop

        isFilling = False
    End Sub

    Private Sub AutoFillReceiversForSeasonsStart()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorSeasonStartProp.ControlValueChanged, AddressOf AutoFillReceiversForSeasonsStart

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorSeasonStartProp.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversProp
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesProp(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorSeasonStartProp.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorSeasonStartProp.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorSeasonStartProp.ControlValueChanged, AddressOf AutoFillReceiversForSeasonsStart

        isFilling = False
    End Sub

    Private Sub AutoFillReceiversForAnnualTemp()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrSelectorAnnualTemp.ControlValueChanged, AddressOf AutoFillReceiversForAnnualTemp

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorAnnualTemp.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversAnnualTemp
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesAnnTemp(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorAnnualTemp.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorAnnualTemp.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelectorAnnualTemp.ControlValueChanged, AddressOf AutoFillReceiversForAnnualTemp

        isFilling = False
    End Sub

    Private Sub AutoFillReceiversForMonthlyTemp()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        Me.SuspendLayout()
        ' Temporarily remove the event handler
        RemoveHandler ucrSelecetorMonthlyTemp.ControlValueChanged, AddressOf AutoFillReceiversForMonthlyTemp

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelecetorMonthlyTemp.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceiversMonthTemp
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValuesMothTemp(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelecetorMonthlyTemp.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelecetorMonthlyTemp.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrSelecetorMonthlyTemp.ControlValueChanged, AddressOf AutoFillReceiversForMonthlyTemp

        Me.ResumeLayout()

        isFilling = False
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Function GetRecognisedValuesCrop(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedCropTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Function GetRecognisedValuesProp(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedPropTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Function GetRecognisedValuesAnnTemp(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedAnnTempTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Function GetRecognisedValuesMothTemp(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedMonthTempTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function
    Private Sub ucrSelecetorMonthlyTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelecetorMonthlyTemp.ControlValueChanged
        AutoFillReceiversForMonthlyTemp()
    End Sub

    Private Sub ucrSelectorAnnualTemp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorAnnualTemp.ControlValueChanged
        AutoFillReceiversForAnnualTemp()
    End Sub

    Private Sub ucrSelectorCropProp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCropProp.ControlValueChanged
        AutoFillReceiversCrop()
    End Sub

    Private Sub ucrSelectorDefineAnnualRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDefineAnnualRain.ControlValueChanged
        AutoFillReceivers()
    End Sub

    Private Sub ucrSelectorSeasonStartProp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorSeasonStartProp.ControlValueChanged
        AutoFillReceiversForSeasonsStart()
    End Sub

    Private Sub AddAnnualSummariesPar()
        ' Always handle all 4 parameters regardless of checkbox state
        If dlgExportClimaticDefinitions.ucrChkAnnualRainfall.Checked Then
            If Not ucrReceiverAnnualRain.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("annual_total_rain_col", ucrReceiverAnnualRain.GetVariableNames)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("annual_total_rain_col")
            End If

            If Not ucrReceiverSeasonalRain.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("seasonal_total_rain_col", ucrReceiverSeasonalRain.GetVariableNames)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("seasonal_total_rain_col")
            End If

            If Not ucrReceiverRainDaysYear.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("annual_rainday_col", ucrReceiverRainDaysYear.GetVariableNames)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("annual_rainday_col")
            End If

            If Not ucrReceiverRainDaysSeason.IsEmpty Then
                clsExportRinstatToBucketFunction.AddParameter("seasonal_rainday_col", ucrReceiverRainDaysSeason.GetVariableNames)
            Else
                clsExportRinstatToBucketFunction.RemoveParameterByName("seasonal_rainday_col")
            End If
        Else
            ' Remove all 4 parameters if the checkbox is not checked
            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_total_rain_col")
            clsExportRinstatToBucketFunction.RemoveParameterByName("seasonal_total_rain_col")
            clsExportRinstatToBucketFunction.RemoveParameterByName("annual_rainday_col")
            clsExportRinstatToBucketFunction.RemoveParameterByName("seasonal_rainday_col")
        End If
    End Sub

End Class