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

    Public clsReforMattAnnualSummaries As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False

    Private Sub sdgDefineAnnualRainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrSelectorDefineAnnualRain.SetParameter(New RParameter("data", 0))
        ucrSelectorDefineAnnualRain.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStation.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStation.SetParameterIsRFunction()

        ucrReceiverYear.SetParameter(New RParameter("year_col", 2))
        ucrReceiverYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverYear.SetParameterIsRFunction()

        ucrReceiverStartRainDOY.SetParameter(New RParameter("start_rains_doy_col", 3))
        ucrReceiverStartRainDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDOY.SetParameterIsRFunction()

        ucrReceiverStartRainDate.SetParameter(New RParameter("start_rains_date_col", 4))
        ucrReceiverStartRainDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverStartRainDate.SetParameterIsRFunction()

        ucrReceiverEndRainsDOY.SetParameter(New RParameter("end_rains_doy_col", 5))
        ucrReceiverEndRainsDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDOY.SetParameterIsRFunction()

        ucrReceiverEndRainsDate.SetParameter(New RParameter("end_rains_date_col", 6))
        ucrReceiverEndRainsDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndRainsDate.SetParameterIsRFunction()

        ucrReceiverEndSeasonDOY.SetParameter(New RParameter("end_season_doy_col", 7))
        ucrReceiverEndSeasonDOY.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDOY.SetParameterIsRFunction()

        ucrReceiverEndSeasonDate.SetParameter(New RParameter("end_season_date_col", 8))
        ucrReceiverEndSeasonDate.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverEndSeasonDate.SetParameterIsRFunction()

        ucrReceiverSeasonalRain.SetParameter(New RParameter("seasonal_rain_col", 9))
        ucrReceiverSeasonalRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalRain.SetParameterIsRFunction()

        ucrReceiverRainDaysSeason.SetParameter(New RParameter("n_seasonal_rain_col", 10))
        ucrReceiverRainDaysSeason.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysSeason.SetParameterIsRFunction()

        ucrReceiverRainDaysYear.SetParameter(New RParameter("n_rain_col", 11))
        ucrReceiverRainDaysYear.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverRainDaysYear.SetParameterIsRFunction()

        ucrReceiverSeasonalLength.SetParameter(New RParameter("season_length_col", 12))
        ucrReceiverSeasonalLength.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverSeasonalLength.SetParameterIsRFunction()

        ucrReceiverAnnualRain.SetParameter(New RParameter("annual_rain_col", 13))
        ucrReceiverAnnualRain.Selector = ucrSelectorDefineAnnualRain
        ucrReceiverAnnualRain.SetParameterIsRFunction()

    End Sub
    Public Sub SetRCode(clsNewReforMattAnnualSummaries As RFunction, clsNewRSyntax As RSyntax, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsReforMattAnnualSummaries = clsNewReforMattAnnualSummaries
        clsRsyntax = clsNewRSyntax

        ucrReceiverAnnualRain.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverEndRainsDate.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverEndRainsDOY.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverEndSeasonDate.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverEndSeasonDOY.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverRainDaysSeason.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverRainDaysYear.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverSeasonalLength.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverSeasonalRain.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverStartRainDate.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverStartRainDOY.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverStation.SetRCode(clsReforMattAnnualSummaries, bReset)
        ucrReceiverYear.SetRCode(clsReforMattAnnualSummaries, bReset)

    End Sub

End Class