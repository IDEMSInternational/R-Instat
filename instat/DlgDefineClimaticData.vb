﻿' R- Instat
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

Public Class DlgDefineClimaticData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim clsTypesFunction As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private clsDefaultFunction As New RFunction
    Private clsAnyDuplicatesFunction, clsConcFunction, clsGetColFunction As New RFunction
    Private strCurrentDataframeName As String
    Private bIsUnique As Boolean = True

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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 328
        Dim kvpRain As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("rain", {"rain", "prec", "rr", "prcp"}.ToList())
        Dim kvpDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("date", {"date", "record"}.ToList())
        Dim kvpStation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "id", "name"}.ToList())
        Dim kvpCloudCover As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("cloud_cover", {"cloud"}.ToList())
        Dim kvpTempMax As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_max", {"tmax", "tx", "max", "tempmax"}.ToList())
        Dim kvpTempMin As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("temp_min", {"tmin", "tn", "min", "tempmin"}.ToList())
        Dim kvpRadiation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("radiation", {"radiation", "rad"}.ToList())
        Dim kvpSunshineHours As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("sunshine_hours", {"sunshine", "sunh"}.ToList())
        Dim kvpWindDirection As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("wind_direction", {"winddirection"}.ToList())
        Dim kvpWindSpeed As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("wind_speed", {"windspeed"}.ToList())
        Dim kvpYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("year", {"year"}.ToList())
        Dim kvpMonth As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("month", {"month"}.ToList())
        Dim kvpDay As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("day", {"day"}.ToList())
        Dim kvpDOY As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("doy", {"doy", "doy_366"}.ToList())

        lstRecognisedTypes.AddRange({kvpRain, kvpStation, kvpCloudCover, kvpTempMax, kvpTempMin, kvpRadiation, kvpSunshineHours, kvpWindDirection, kvpWindSpeed, kvpYear, kvpMonth, kvpDay, kvpDOY, kvpDate})
        lstReceivers.AddRange({ucrReceiverCloudCover, ucrReceiverDay, ucrReceiverMaxTemp, ucrReceiverMinTemp, ucrReceiverMonth, ucrReceiverRadiation, ucrReceiverRain, ucrReceiverStationName, ucrReceiverSunshine, ucrReceiverWindDirection, ucrReceiverWindSpeed, ucrReceiverYear, ucrReceiverDOY, ucrReceiverDate})

        ucrSelectorDefineClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDefineClimaticData.SetParameterIsString()
        ucrReceiverDate.Tag = "date"
        ucrReceiverCloudCover.Tag = "cloud_cover"
        ucrReceiverStationName.Tag = "station"
        ucrReceiverMaxTemp.Tag = "temp_max"
        ucrReceiverMinTemp.Tag = "temp_min"
        ucrReceiverRadiation.Tag = "radiation"
        ucrReceiverRain.Tag = "rain"
        ucrReceiverSunshine.Tag = "sunshine_hours"
        ucrReceiverWindDirection.Tag = "wind_direction"
        ucrReceiverWindSpeed.Tag = "wind_speed"
        ucrReceiverYear.Tag = "year"
        ucrReceiverMonth.Tag = "month"
        ucrReceiverDay.Tag = "day"
        ucrReceiverDOY.Tag = "doy"
        ucrInputCheckInput.IsReadOnly = True

        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        SetRSelector()
        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsGetColFunction = New RFunction
        clsAnyDuplicatesFunction = New RFunction
        clsConcFunction = New RFunction

        ucrSelectorDefineClimaticData.Reset()
        ucrInputCheckInput.Reset()
        ucrReceiverDate.SetMeAsReceiver()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsDefaultFunction.AddParameter("types", clsRFunctionParameter:=clsTypesFunction)
        clsDefaultFunction.AddParameter("key_col_names", clsRFunctionParameter:=clsConcFunction, iPosition:=2)

        clsTypesFunction.SetRCommand("c")

        clsConcFunction.SetRCommand("c")

        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=clsGetColFunction)

        clsGetColFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColFunction.AddParameter("data_name", Chr(34) & strCurrentDataframeName & Chr(34))
        clsGetColFunction.AddParameter("col_names", clsRFunctionParameter:=clsConcFunction)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        AutoFillReceivers()
        EnableDisableCheckUniqueBtn()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorDefineClimaticData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        SetRCodesforReceivers(bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso bIsUnique Then
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

    Private Sub SetRCodesforReceivers(bReset As Boolean)
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetRCode(clsTypesFunction, bReset)
        Next
    End Sub

    Private Sub SetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrSelectorDefineClimaticData
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
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

    Private Sub Selector_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDefineClimaticData.ControlContentsChanged
        AutoFillReceivers()
    End Sub

    Private Sub cmdCheckUnique_Click(sender As Object, e As EventArgs) Handles cmdCheckUnique.Click
        Dim iAnyDuplicated As Integer

        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try

        If iAnyDuplicated = -1 Then
            ucrInputCheckInput.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInput.txtInput.BackColor = Color.Yellow
            bIsUnique = False
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInput.SetName("")
            ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
            bIsUnique = False
            If ucrReceiverStationName.IsEmpty Then
                ucrInputCheckInput.SetName("Duplicate dates found.")
                MsgBox("You have multiple rows with the same dates. Did you forget to add the station column? Otherwise, use the Climatic > Tidy and Examine > Duplicates dialog to investigate these issues.", MsgBoxStyle.Information, Title:="Duplicates")
            Else
                ucrInputCheckInput.SetName("Duplicate dates for station(s) were found.")
                MsgBox("You have multiple rows with the same dates for one or more stations. Use the Climatic > Tidy and Examine > Duplicates dialog to investigate these issues.", MsgBoxStyle.Information, Title:="Duplicates")
            End If
        Else
            ucrInputCheckInput.SetName("No duplicate dates.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightGreen
            bIsUnique = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub EnableDisableCheckUniqueBtn()
        If ucrReceiverDate.IsEmpty Then
            cmdCheckUnique.Enabled = False
        Else
            cmdCheckUnique.Enabled = True
        End If
        ucrInputCheckInput.SetName("")
        ucrInputCheckInput.txtInput.BackColor = SystemColors.Window
        bIsUnique = True
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged, ucrReceiverStationName.ControlValueChanged
        EnableDisableCheckUniqueBtn()
        If Not ucrReceiverStationName.IsEmpty Then
            clsConcFunction.AddParameter("x1", ucrReceiverStationName.GetVariableNames, bIncludeArgumentName:=False)
        Else
            clsConcFunction.RemoveParameterByName("x1")
        End If
        If Not ucrReceiverDate.IsEmpty Then
            clsConcFunction.AddParameter("x2", ucrReceiverDate.GetVariableNames, bIncludeArgumentName:=False)
        Else
            clsConcFunction.RemoveParameterByName("x2")
        End If
    End Sub

    Private Sub ucrSelectorDefineClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDefineClimaticData.ControlValueChanged
        strCurrentDataframeName = ucrSelectorDefineClimaticData.strCurrentDataFrame
        clsGetColFunction.AddParameter("data_name", Chr(34) & strCurrentDataframeName & Chr(34), iPosition:=0)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class