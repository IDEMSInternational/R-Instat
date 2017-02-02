' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Imports System.Text.RegularExpressions

Public Class DlgDefineClimaticData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim clsTypesFunction As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub DlgDefineClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 328
        ucrBase.clsRsyntax.iCallType = 0
        Dim kvpRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("rain", {"rain", "prec", "rr", "prcp"}.ToList())
        Dim kvpDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("date", {"date", "record"}.ToList())
        Dim kvpStation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "id", "name"}.ToList())
        Dim kvpCloudCover As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("cloud_cover", {"cloud"}.ToList())
        Dim kvpTempMax As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_max", {"tmax", "tx", "max", "tempmax"}.ToList())
        Dim kvpTempMin As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_min", {"tmin", "tn", "min", "tempmin"}.ToList())
        Dim kvpRadiation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("radiation", {"radiation"}.ToList())
        Dim kvpSunshineHours As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("sunshine_hours", {"sunshine"}.ToList())
        Dim kvpWindDirection As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("wind_direction", {"winddirection"}.ToList())
        Dim kvpWindSpeed As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("wind_speed", {"windspeed"}.ToList())
        Dim kvpYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("year", {"year"}.ToList())
        Dim kvpMonth As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("month", {"month"}.ToList())
        Dim kvpDay As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("day", {"day"}.ToList())
        Dim kvpDOY As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("doy", {"doy", "DOY"}.ToList())

        lstRecognisedTypes.AddRange({kvpRain, kvpDate, kvpStation, kvpCloudCover, kvpTempMax, kvpTempMin, kvpRadiation, kvpSunshineHours, kvpWindDirection, kvpWindSpeed, kvpYear, kvpMonth, kvpDay})

        ucrSelectorDefineClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDefineClimaticData.SetParameterIsString()

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
        ucrReceiverDOY.Selector = ucrSelectorDefineClimaticData
        ucrReceiverDOY.Tag = "doy"
        lstReceivers.AddRange({ucrReceiverCloudCover, ucrReceiverDate, ucrReceiverDay, ucrReceiverMaxTemp, ucrReceiverMinTemp, ucrReceiverMonth, ucrReceiverRadiation, ucrReceiverRain, ucrReceiverStation, ucrReceiverSunshine, ucrReceiverWindDirection, ucrReceiverWindSpeed, ucrReceiverYear, ucrReceiverDOY})
        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorDefineClimaticData.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsTypesFunction.SetRCommand("c")
        clsDefaultFunction.AddParameter("types", clsRFunctionParameter:=clsTypesFunction)
        'TestOKEnabled()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        AutoFillReceivers()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged, ucrReceiverCloudCover.SelectionChanged, ucrReceiverDate.SelectionChanged, ucrReceiverDay.SelectionChanged, ucrReceiverMaxTemp.SelectionChanged, ucrReceiverMinTemp.SelectionChanged, ucrReceiverMonth.SelectionChanged, ucrReceiverRadiation.SelectionChanged, ucrReceiverRain.SelectionChanged, ucrReceiverStation.SelectionChanged, ucrReceiverSunshine.SelectionChanged, ucrReceiverWindDirection.SelectionChanged, ucrReceiverWindSpeed.SelectionChanged, ucrReceiverYear.SelectionChanged
    '    FillClimaticTypes()
    '    TestOKEnabled()
    'End Sub

    'Private Sub ucrSelectorDefineClimaticData_DataFrameChanged() Handles ucrSelectorDefineClimaticData.DataFrameChanged
    '    ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDefineClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    '    AutoFillReceivers()
    'End Sub

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

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorDefineClimaticData.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorDefineClimaticData.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrSelectorDefineClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverCloudCover.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDay.ControlContentsChanged, ucrReceiverMaxTemp.ControlContentsChanged, ucrReceiverMinTemp.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverRadiation.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverSunshine.ControlContentsChanged, ucrReceiverWindDirection.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrSelectorDefineClimaticData.ControlContentsChanged
        FillClimaticTypes()
        TestOKEnabled()
    End Sub
End Class