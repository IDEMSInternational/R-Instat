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

Public Class sdgLinkedStationData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTypesFunction, clsNewTypesFunction As New RFunction
    Private lstReceivers As New List(Of ucrReceiverSingle)
    Private lstNewReceivers As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private lstNewRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private clsDefaultFunction, clsNewDefautFunction As New RFunction
    Private clsAnyDuplicatesFunction, clsConcFunction, clsNewConcFunction, clsGetColFunction, clsDummyFunction As New RFunction
    Private strCurrentDataframeName As String
    Private bIsUnique As Boolean = True

    Private Sub sdgLinkedStationData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        SetRCodeForControls(bReset)
    End Sub

    Private Sub InitialiseDialog()
        Dim kvpStation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "id", "name"}.ToList())
        Dim kvpDistrict As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("district", {"district", "country", "countries"}.ToList())
        Dim kvpAltitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("alt", {"alt", "altitude", "elevation", "elev"}.ToList())
        Dim kvpLongitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lon", {"lon", "lont", "longitude"}.ToList())
        Dim kvpLatitude As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("lat", {"lat", "latitude"}.ToList())

        lstNewReceivers.AddRange({ucrReceiverStationMeta, ucrReceiverAltMeta, ucrReceiverLatMeta, ucrReceiverLonMeta, ucrReceiverDiscritMeta})

        ucrSelectorLinkedDataFrame.SetParameter(New RParameter("data_name", 1))
        ucrSelectorLinkedDataFrame.SetParameterIsString()

        ucrReceiverAltMeta.Tag = "alt"
        ucrReceiverLonMeta.Tag = "lon"
        ucrReceiverLatMeta.Tag = "lat"
        ucrReceiverStationMeta.Tag = "station"
        ucrReceiverDiscritMeta.Tag = "district"
        ucrInputCheckInput.IsReadOnly = True

        NewSetRSelector()
    End Sub

    Private Sub NewSetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstNewReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrSelectorLinkedDataFrame
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub NewAutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrSelectorLinkedDataFrame.CurrentReceiver
        Dim strData As String = ucrSelectorLinkedDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text

        For Each ucrTempReceiver As ucrReceiver In lstNewReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetNewRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrSelectorLinkedDataFrame.lstAvailableVariable.Items
                    Dim strClimaticType As String = GetClimaticTypeFromRCommand(lviTempVariable.Text, strData)
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) OrElse (strClimaticType IsNot Nothing AndAlso strClimaticType.Contains(strValue)) Then
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
            If ucrReceiverStationMeta.IsEmpty Then
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
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorLinkedDataFrame.SetRCode(clsNewDefautFunction, bReset)
        SetRCodesforReceivers(bReset)
    End Sub

    Private Sub SetRCodesforReceivers(bReset As Boolean)
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetRCode(clsTypesFunction, bReset)
        Next

        For Each ucrTempReceiver In lstNewReceivers
            ucrTempReceiver.SetRCode(clsNewTypesFunction, bReset)
        Next
    End Sub

    Private Sub ucrSelectorLinkedDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorLinkedDataFrame.ControlValueChanged
        clsGetColFunction.AddParameter("data_name", Chr(34) & ucrSelectorLinkedDataFrame.strCurrentDataFrame & Chr(34), iPosition:=1)
        NewAutoFillReceivers()
    End Sub

    Private Sub ucrChkLinkedMetaData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLinkedMetaData.ControlValueChanged, ucrReceiverAltMeta.ControlValueChanged, ucrReceiverLatMeta.ControlValueChanged, ucrReceiverLonMeta.ControlValueChanged, ucrReceiverStationMeta.ControlValueChanged, ucrReceiverDiscritMeta.ControlValueChanged
        ucrSelectorLinkedDataFrame.Visible = True
        ucrBase.clsRsyntax.AddToAfterCodes(clsNewDefautFunction, iPosition:=0)
            clsNewDefautFunction.iCallType = 2
        ucrSelectorLinkedDataFrame.Visible = False
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsNewDefautFunction)
        If Not ucrReceiverStationMeta.IsEmpty Then
            clsNewConcFunction.AddParameter("x1", ucrReceiverStationMeta.GetVariableNames, bIncludeArgumentName:=False)
        Else
            clsNewConcFunction.RemoveParameterByName("x1")
        End If
    End Sub

    Private Function GetNewRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstNewRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Function GetClimaticTypeFromRCommand(strName As String, strDataName As String) As String
        Try
            Dim clsGetClimaticTypeFunction As New RFunction

            clsGetClimaticTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_climatic_type")
            clsGetClimaticTypeFunction.AddParameter("attr_name", Chr(34) & "Climatic_Type" & Chr(34))
            clsGetClimaticTypeFunction.AddParameter("col_name", Chr(34) & strName & Chr(34))
            clsGetClimaticTypeFunction.AddParameter("data_name", Chr(34) & strDataName & Chr(34))

            Dim result As SymbolicExpression
            result = frmMain.clsRLink.RunInternalScriptGetValue(clsGetClimaticTypeFunction.ToScript())

            ' Check if result is Nothing or has no values before trying to access
            If result IsNot Nothing AndAlso result.Type <> Internals.SymbolicExpressionType.Null Then
                Dim strClimaticType As String = result.AsCharacter(0)
                If Not String.IsNullOrEmpty(strClimaticType) Then
                    Return strClimaticType
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return String.Empty
    End Function
End Class