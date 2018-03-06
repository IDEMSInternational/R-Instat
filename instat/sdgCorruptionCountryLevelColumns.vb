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

Public Class sdgCorruptionCountryLevelColumns
    Public bControlsInitialised As Boolean = False
    Public clsCountryLevel As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub sdgCorruptionCountryLevelColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        AutoFillReceivers()
    End Sub

    Public Sub InitialiseControls()

        Dim kvpCountry As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("country", {"country"}.ToList())
        Dim kvpCountryISO2 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("iso2", {"iso2"}.ToList())
        Dim kvpCountryISO3 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("iso3", {"iso3"}.ToList())
        Dim kvpWBPPP As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("wb_ppp", {"ppp"}.ToList())
        Dim kvpSS2009 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ss_2009", {"ss2009"}.ToList())
        Dim kvpSS2011 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ss_2011", {"ss2011"}.ToList())
        Dim kvpSS2013 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ss_2013", {"ss2013"}.ToList())
        Dim kvpSS2015 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ss_2015", {"ss2015"}.ToList())
        Dim kvpSmallState As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("small_state", {"smallstate"}.ToList())

        lstRecognisedTypes.AddRange({kvpCountry, kvpCountryISO2, kvpCountryISO3, kvpWBPPP, kvpSS2009, kvpSS2011, kvpSS2013, kvpSS2015, kvpSmallState})
        lstReceivers.AddRange({ucrReceiverCountry, ucrReceiverISO2, ucrReceiverISO3, ucrReceiverWBPPP, ucrReceiverSS2009, ucrReceiverSS2011, ucrReceiverSS2013, ucrReceiverSS2015, ucrReceiverSmallState})

        ucrCountryLevelSelector.SetParameter(New RParameter("country_data_name", 4))
        ucrCountryLevelSelector.SetParameterIsString()

        ucrReceiverCountry.Tag = "country"
        ucrReceiverISO2.Tag = "iso2"
        ucrReceiverISO3.Tag = "iso3"
        ucrReceiverWBPPP.Tag = "wb_ppp"
        ucrReceiverSS2009.Tag = "ss_2009"
        ucrReceiverSS2011.Tag = "ss_2011"
        ucrReceiverSS2013.Tag = "ss_2013"
        ucrReceiverSS2015.Tag = "ss_2015"
        ucrReceiverSmallState.Tag = "small_state"

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsCountryLevel = clsNewRFunction
        SetRCode(Me, clsCountryLevel, bReset)
    End Sub

    Private Sub SetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrCountryLevelSelector
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrCountryLevelSelector.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrCountryLevelSelector.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        'If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                        '    ucrTempReceiver.Add(lviTempVariable.Text, ucrCountryLevelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                        '    bFound = True
                        '    Exit For
                        'End If
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

    Private Sub ucrCountryLevelSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCountryLevelSelector.ControlValueChanged
        AutoFillReceivers()
    End Sub
End Class