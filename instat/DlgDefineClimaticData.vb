' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or♦
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class DlgDefineClimaticData
    Public bFirstLoad As Boolean = True
    Dim clsTypesFunction As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)

    Private Sub DlgDefineClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsTypesFunction.SetRCommand("c")
        ucrBase.clsRsyntax.AddParameter("types", clsRFunctionParameter:=clsTypesFunction)
        ucrReceiverDate.Selector = ucrSelectorDefineClimaticData
        ucrReceiverDate.Tag = "date"
        ucrReceiverCloudCover.Selector = ucrSelectorDefineClimaticData
        ucrReceiverCloudCover.Tag = "cloud_cover"
        ucrReceiverStation.Selector = ucrSelectorDefineClimaticData
        ucrReceiverStation.Tag = "station"
        ucrReceiverMaxTemp.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMaxTemp.Tag = "temp_max"
        ucrReceiverMinTemp.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMinTemp.Tag = "temp_min"
        ucrReceiverRadiation.Selector = ucrSelectorDefineClimaticData
        ucrReceiverRadiation.Tag = "radiation"
        ucrReceiverRain.Selector = ucrSelectorDefineClimaticData
        ucrReceiverRain.Tag = "rain"
        ucrReceiverSunshine.Selector = ucrSelectorDefineClimaticData
        ucrReceiverSunshine.Tag = "sunshine_hours"
        ucrReceiverWindDirection.Selector = ucrSelectorDefineClimaticData
        ucrReceiverWindDirection.Tag = "wind_direction"
        ucrReceiverWindSpeed.Selector = ucrSelectorDefineClimaticData
        ucrReceiverWindSpeed.Tag = "wind_speed"
        ucrReceiverYear.Selector = ucrSelectorDefineClimaticData
        ucrReceiverYear.Tag = "year"
        ucrReceiverMonth.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMonth.Tag = "month"
        ucrReceiverDay.Selector = ucrSelectorDefineClimaticData
        ucrReceiverDay.Tag = "day"
        lstReceivers.AddRange({ucrReceiverCloudCover, ucrReceiverDate, ucrReceiverDay, ucrReceiverMaxTemp, ucrReceiverMinTemp, ucrReceiverMonth, ucrReceiverRadiation, ucrReceiverRain, ucrReceiverStation, ucrReceiverSunshine, ucrReceiverWindDirection, ucrReceiverWindSpeed, ucrReceiverYear})
    End Sub

    Private Sub SetDefaults()
        ucrReceiverDate.SetMeAsReceiver()
        ucrSelectorDefineClimaticData.Reset()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged, ucrReceiverCloudCover.SelectionChanged, ucrReceiverDate.SelectionChanged, ucrReceiverDay.SelectionChanged, ucrReceiverMaxTemp.SelectionChanged, ucrReceiverMinTemp.SelectionChanged, ucrReceiverMonth.SelectionChanged, ucrReceiverRadiation.SelectionChanged, ucrReceiverRain.SelectionChanged, ucrReceiverStation.SelectionChanged, ucrReceiverSunshine.SelectionChanged, ucrReceiverWindDirection.SelectionChanged, ucrReceiverWindSpeed.SelectionChanged, ucrReceiverYear.SelectionChanged
        FillClimaticTypes()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDefineClimaticData_DataFrameChanged() Handles ucrSelectorDefineClimaticData.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDefineClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub FillClimaticTypes()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            If Not ucrTempReceiver.IsEmpty Then
                clsTypesFunction.AddParameter(ucrTempReceiver.Tag, ucrTempReceiver.GetVariableNames)
            Else
                clsTypesFunction.RemoveParameterByName(ucrTempReceiver.Tag)
            End If
        Next
    End Sub
End Class