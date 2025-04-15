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
Imports System.Text.RegularExpressions
Imports RDotNet
Public Class dlgDefineTricotData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstReceiversLevelID, lstReceiversVarityLevel, lstReceiversIDVarietyLevel As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub dlgDefineTricotData_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())
        Dim kvpLongitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lon", {"lon", "long", "lont", "longitude", "Longitude", "Lon"}.ToList())
        Dim kvpLatitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lat", {"lat", "latitude", "Lat", "Latitude"}.ToList())
        Dim kvpPlantingDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("planting_date", {"planting_date", "Planting_date", "plantingdate"}.ToList())
        Dim kvpOverAll As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("overall", {"overall", "overall_perf", "Overall"}.ToList())
        Dim kvpVariety As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("item", {"item", "items", "variety", "varieties"}.ToList())


        lstRecognisedTypes.AddRange({kvpID, kvpLongitude, kvpLatitude, kvpPlantingDate, kvpOverAll, kvpVariety})
        lstReceiversLevelID.AddRange({ucrReceiverLevelID, ucrReceiverLevelLatitude, ucrReceiverLevelLongitude, ucrReceiverLevelPlantingDate})
        lstReceiversVarityLevel.AddRange({ucrReceiverVarietyLevelVariety})
        lstReceiversIDVarietyLevel.AddRange({ucrReceiverIDVarietyLevelID, ucrReceiverIDVarietyLevelVariety})

        ucrReceiverLevelID.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelLatitude.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelLongitude.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelPlantingDate.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelOverallTraits.Selector = ucrSelectorIDLevelData
        ucrReceiverLevelVarieties.Selector = ucrSelectorIDLevelData

        ucrReceiverVarietyLevelVariety.Selector = ucrSelectorVarietyLevelData

        ucrReceiverIDVarietyLevelID.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevelVariety.Selector = ucrSelectorIDVarietyLevel
        ucrReceiverIDVarietyLevelTraits.Selector = ucrSelectorIDVarietyLevel

    End Sub

    Private Sub SetDefaults()
        ucrReceiverLevelID.SetMeAsReceiver()

        AutoFillReceivers(ucrSelectorIDLevelData, lstReceiversLevelID)
        AutoFillReceivers(ucrSelectorVarietyLevelData, lstReceiversVarityLevel)
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub AutoFillReceivers(sender As ucrSelectorByDataFrameAddRemove, lstReceivers As List(Of ucrReceiverSingle))
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        If lstReceivers.Count = 0 Then
            Exit Sub
        End If

        ucrCurrentReceiver = sender.CurrentReceiver
        Dim strData As String = sender.strCurrentDataFrame
        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In sender.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, strData)
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

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrSelectorIDLevelData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDLevelData.ControlValueChanged
        AutoFillReceivers(ucrSelectorIDLevelData, lstReceiversLevelID)
    End Sub

    Private Sub ucrSelectorVarietyLevelData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevelData.ControlValueChanged
        AutoFillReceivers(ucrSelectorVarietyLevelData, lstReceiversVarityLevel)
    End Sub

    Private Sub ucrSelectorIDVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorIDVarietyLevel.ControlValueChanged
        AutoFillReceivers(ucrSelectorIDVarietyLevel, lstReceiversIDVarietyLevel)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub


End Class