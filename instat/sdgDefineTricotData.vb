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

Public Class sdgDefineTricotData
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstReceiversLevelID As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private clsSetColumnSelection, clsTricotDataFunction, clsAddColumnSelection As New RFunction

    Private ReadOnly strPos As String = "_pos"
    Private ReadOnly strBest As String = "_best"
    Private ReadOnly strNeg As String = "_neg"
    Private ReadOnly strWorst As String = "_worst"
    Private ReadOnly strNot As String = "Not Observed"
    Private ReadOnly strMissing As String = "Missing"
    Private ReadOnly strNA As String = "NA"

    Private Sub sdgDefineTricotData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()

        Dim kvpID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("id", {"id", "ID", "participant_id", "participant_name"}.ToList())

        lstRecognisedTypes.AddRange({kvpID})
        lstReceiversLevelID.AddRange({ucrReceiverTricotData})

        ucrSelectorTricotData.SetParameter(New RParameter("id_level_data", 0))
        ucrSelectorTricotData.SetParameterIsString()

        ucrInputGoodTrait.SetItems({strPos, strBest})
        ucrInputGoodTrait.SetDropDownStyleAsNonEditable()
        ucrInputGoodTrait.SetLinkedDisplayControl(lblGoodtrait)
        ucrInputGoodTrait.SetParameter(New RParameter("good_suffixes", 2))

        ucrInputBadTrait.SetItems({strNeg, strWorst})
        ucrInputBadTrait.SetDropDownStyleAsNonEditable()
        ucrInputBadTrait.SetLinkedDisplayControl(lblBadTrait)
        ucrInputBadTrait.SetParameter(New RParameter("bad_suffixes", 3))

        ucrInputNAs.SetItems({strNot, strMissing, strNA})
        ucrInputNAs.SetDropDownStyleAsNonEditable()
        ucrInputNAs.SetLinkedDisplayControl(lblNAs)
        ucrInputNAs.SetParameter(New RParameter("na_candidates", 4))
        AutoFillReceivers(ucrSelectorTricotData, lstReceiversLevelID)
    End Sub

    Private Sub SetDefaults()
        clsSetColumnSelection = New RFunction
        clsTricotDataFunction = New RFunction
        clsAddColumnSelection = New RFunction

        ucrInputGoodTrait.SetText(strPos)
        ucrInputGoodTrait.bUpdateRCodeFromControl = True
        ucrInputBadTrait.SetText(strNeg)
        ucrInputBadTrait.bUpdateRCodeFromControl = True
        ucrInputNAs.SetText(strNot)
        ucrInputNAs.bUpdateRCodeFromControl = True
        ucrReceiverTricotData.SetMeAsReceiver()

        clsTricotDataFunction.SetPackageName("databook")
        clsTricotDataFunction.SetRCommand("create_tricot_data")
        clsTricotDataFunction.AddParameter("output_data_levels", "NULL")
        clsTricotDataFunction.AddParameter("id_level_data", ucrSelectorTricotData.strCurrentDataFrame)
        clsTricotDataFunction.AddParameter("id_col", ucrReceiverTricotData.GetVariableNames)
        clsTricotDataFunction.AddParameter("good_suffixes", ucrInputGoodTrait.GetText)
        clsTricotDataFunction.AddParameter("bad_suffixes", ucrInputBadTrait.GetText)
        clsTricotDataFunction.AddParameter("na_candidates ", ucrInputNAs.GetText)

        clsSetColumnSelection.SetRCommand("data_book$set_current_column_selection")
        clsSetColumnSelection.AddParameter("data_name", ucrSelectorTricotData.strCurrentDataFrame, iPosition:=1)
        clsSetColumnSelection.AddParameter("name", Chr(34) & "remove_traits" & Chr(34), iPosition:=2)

        clsAddColumnSelection.SetRCommand("add_column_selection")
        clsAddColumnSelection.AddParameter("data_name", ucrSelectorTricotData.strCurrentDataFrame, iPosition:=1)
        clsAddColumnSelection.AddParameter("name", Chr(34) & "remove_traits" & Chr(34), iPosition:=2)
        clsAddColumnSelection.AddParameter("column_selection")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorTricotData.AddAdditionalCodeParameterPair(clsAddColumnSelection, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrSelectorTricotData.AddAdditionalCodeParameterPair(clsSetColumnSelection, New RParameter("data_name", 0), iAdditionalPairNo:=2)

        ucrSelectorTricotData.SetRCode(clsTricotDataFunction, bReset)
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

    Private Sub ucrSelectorTricotData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTricotData.ControlValueChanged
        AutoFillReceivers(ucrSelectorTricotData, lstReceiversLevelID)
    End Sub



End Class