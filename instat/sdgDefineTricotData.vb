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
    Public bControlsInitialised As Boolean = False
    Private bInitialised As Boolean = False
    Public clsRsyntax As New RSyntax

    Private lstReceiversLevelID As New List(Of ucrReceiverSingle)
    Private lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Public clsSetColumnSelection, clsListCoFunction, clsList1CoFunction, clsList1Function, clsListFunction, clsList2Function, clsGetDataFrameFunction, clsTricotDataFunction, clsAddColumnSelection As New RFunction

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
            InitialiseControls()
            bFirstLoad = False
        End If

        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Public Sub InitialiseControls()

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
    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewSetColumnSelection As RFunction, clsNewList1CoFunction As RFunction, clsNewListCoFunction As RFunction, clsNewList1Function As RFunction, clsNewList2Function As RFunction, clsNewListFunction As RFunction, clsNewTricotDataFunction As RFunction, clsNewAddColumnSelection As RFunction, clsNewGetDataFrameFunction As RFunction, Optional bReset As Boolean = False)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsSetColumnSelection = clsNewSetColumnSelection
        clsTricotDataFunction = clsNewTricotDataFunction
        clsAddColumnSelection = clsNewAddColumnSelection
        clsGetDataFrameFunction = clsNewGetDataFrameFunction
        clsList2Function = clsNewList2Function
        clsListFunction = clsNewListFunction
        clsList1Function = clsNewList1Function
        clsListCoFunction = clsNewListCoFunction
        clsList1CoFunction = clsNewList1CoFunction
        clsRsyntax = clsNewRSyntax

        ucrInputBadTrait.SetText(strNeg)
        ucrInputGoodTrait.SetText(strPos)

        SetBaseFunctions()
    End Sub


    Private Sub SetRCodeForControls(bReset As Boolean)

        'ucrInputBadTrait.SetRCode(clsList1CoFunction, bReset)
        'ucrInputGoodTrait.SetRCode(clsList2Function, bReset)


        SetBaseFunctions()
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
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorTricotData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsAddColumnSelection.AddParameter("data_name", Chr(34) & ucrSelectorTricotData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsTricotDataFunction.AddParameter("id_level_data", Chr(34) & ucrSelectorTricotData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)

        clsGetDataFrameFunction.SetAssignTo(ucrSelectorTricotData.strCurrentDataFrame)
    End Sub

    Private Sub ucrInputGoodTrait_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputGoodTrait.ControlValueChanged
        If Not ucrInputGoodTrait.IsEmpty Then
            clsList2Function.AddParameter("match", Chr(34) & ucrInputGoodTrait.GetText & Chr(34), iPosition:=0)
        Else
            clsList2Function.RemoveParameterByName("match")
        End If
    End Sub

    Private Sub ucrInputBadTrait_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBadTrait.ControlValueChanged
        If Not ucrInputBadTrait.IsEmpty Then
            clsList1CoFunction.AddParameter("match", Chr(34) & ucrInputBadTrait.GetText & Chr(34), iPosition:=0)
        Else
            clsList1CoFunction.RemoveParameterByName("match")

        End If
    End Sub

    Public Sub SetBaseFunctions()
        clsRsyntax.ClearCodes()
        clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, 0)
        clsRsyntax.AddToBeforeCodes(clsTricotDataFunction, 1)
        clsRsyntax.AddToBeforeCodes(clsAddColumnSelection, 2)
        clsRsyntax.AddToBeforeCodes(clsSetColumnSelection, 3)
    End Sub
End Class