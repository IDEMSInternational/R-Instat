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
Public Class dlgExportToWWR
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'Add R functions and  operators
    Private Sub dlgExportToWWR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        ucrBase.iHelpTopicID = 355

        ucrSelectorExportToWWR.SetParameter(New RParameter("data"))
        'ucrSelectorExportToWWR.SetParameterIsrfunction()

        ucrReceiverYear.Selector = ucrSelectorExportToWWR
        ucrReceiverYear.SetParameter(New RParameter("year"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.Selector = ucrSelectorExportToWWR
        ucrReceiverMonth.SetParameter(New RParameter("year"))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.SetLinkedDisplayControl(lblYear)
        ucrReceiverMonth.SetClimaticType("year")
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverMeanStationPressure.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanStationPressure.SetParameter(New RParameter("element"))
        ucrReceiverMeanStationPressure.SetParameterIsString()
        ucrReceiverMeanStationPressure.SetLinkedDisplayControl(lblMeanStationPressure)

        ucrReceiverMeanSeaLevelPressure.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanSeaLevelPressure.SetParameter(New RParameter("station"))
        ucrReceiverMeanSeaLevelPressure.SetParameterIsString()
        ucrReceiverMeanSeaLevelPressure.SetLinkedDisplayControl(lblMeanSeaLevelPressure)

        ucrReceiverPrecipitation.SetParameter(New RParameter("latitude"))
        ucrReceiverPrecipitation.SetParameterIsString()
        ucrReceiverPrecipitation.SetLinkedDisplayControl(lblPrecipitation)
        ucrReceiverPrecipitation.bAutoFill = True

        ucrReceiverMeanRelativeHumidity.SetParameter(New RParameter("longitude"))
        ucrReceiverMeanRelativeHumidity.SetParameterIsString()
        ucrReceiverMeanRelativeHumidity.SetLinkedDisplayControl(lblMeanRelativeHumidity)
        ucrReceiverMeanRelativeHumidity.bAutoFill = True

        ucrReceiverMeanDailyMaxAirTemperature.SetParameter(New RParameter("longitude"))
        ucrReceiverMeanDailyMaxAirTemperature.SetParameterIsString()
        ucrReceiverMeanDailyMaxAirTemperature.SetLinkedDisplayControl(lblMeanDailyMaxAirTemperature)
        ucrReceiverMeanDailyMaxAirTemperature.bAutoFill = True

        ucrReceiverMeanDailyMinAirTemperature.SetParameter(New RParameter("longitude"))
        ucrReceiverMeanDailyMinAirTemperature.SetParameterIsString()
        ucrReceiverMeanDailyMinAirTemperature.SetLinkedDisplayControl(lblMeanDailyMinAirTemperature)
        ucrReceiverMeanDailyMinAirTemperature.bAutoFill = True

        ucrReceiverMeanMonthlyAirTemperature.SetParameter(New RParameter("longitude"))
        ucrReceiverMeanMonthlyAirTemperature.SetParameterIsString()
        ucrReceiverMeanMonthlyAirTemperature.SetLinkedDisplayControl(lblMeanMonthlyAirTemperature)
        ucrReceiverMeanMonthlyAirTemperature.bAutoFill = True

        ucrNudWMONumber.SetParameter(New RParameter("wmo_number", 4))
        'ucrNudWMONumber.SetMinMax(0, Integer.MaxValue)
    End Sub

    Private Sub SetDefaults()
        Throw New NotImplementedException()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        Throw New NotImplementedException()
    End Sub

    Private Sub TestOkEnabled()
        Throw New NotImplementedException()
    End Sub
End Class

