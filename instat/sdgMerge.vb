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

Imports System.ComponentModel
Imports instat.Translations

Public Class sdgMerge
    Private bControlsInitialised As Boolean = False
    Private clsByList As New RFunction
    Private clsMerge As RFunction

    Private Sub sdgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitiatiseControls()
        ucrSelectorFirstDF.SetLabelText("First Data Frame")
        ucrSelectorSecondDF.SetLabelText("Second Data Frame")

        ucrReceiverFirstDF.Selector = ucrSelectorFirstDF
        ucrReceiverFirstDF.SetMeAsReceiver()

        ucrReceiverSecondDF.Selector = ucrSelectorSecondDF
        ucrReceiverSecondDF.SetMeAsReceiver()

        bControlsInitialised = True
    End Sub

    Public Sub Setup(strFirstDataName As String, strSecondDataName As String, clsNewMerge As RFunction, clsNewByList As RFunction, bReset As Boolean)
        If Not bControlsInitialised Then
            InitiatiseControls()
        End If
        ucrSelectorFirstDF.SetDataframe(strFirstDataName, False)
        ucrSelectorSecondDF.SetDataframe(strSecondDataName, False)

        clsMerge = clsNewMerge
        clsByList = clsNewByList
        ResetKeyList()
        For Each clsTempParam In clsByList.clsParameters
            lstKeyColumns.Items.Add(clsTempParam.strArgumentName.Trim(Chr(34))).SubItems.AddRange({"and", clsTempParam.strArgumentValue.Trim(Chr(34))})
        Next
    End Sub

    Public Sub AutoAddInOtherReceiver(ucrChangedReceiver As ucrReceiverSingle, ucrOtherReceiver As ucrReceiverSingle)
        If Not ucrChangedReceiver.IsEmpty() Then
            If ucrOtherReceiver.IsEmpty AndAlso ucrOtherReceiver.Selector.ContainsVariable(ucrChangedReceiver.GetVariableNames(False)) Then
                ucrOtherReceiver.Add(ucrChangedReceiver.GetVariableNames(False))
            End If
        End If
        If ucrChangedReceiver.IsEmpty() OrElse ucrOtherReceiver.IsEmpty Then
            cmdAddPair.Enabled = False
        Else
            cmdAddPair.Enabled = True
        End If
    End Sub

    Private Sub SetByArgument()
        Dim lviItem As ListViewItem

        clsByList.ClearParameters()
        For Each lviItem In lstKeyColumns.Items
            clsByList.AddParameter(Chr(34) & lviItem.Text() & Chr(34), Chr(34) & lviItem.SubItems(2).Text() & Chr(34))
        Next
        If lstKeyColumns.Items.Count > 0 Then
            clsMerge.AddParameter("by", clsRFunctionParameter:=clsByList, iPosition:=2)
        Else
            clsMerge.RemoveParameterByName("by")
        End If
    End Sub

    Private Sub ResetKeyList()
        lstKeyColumns.Columns.Clear()
        lstKeyColumns.Clear()
        lstKeyColumns.Columns.Add(ucrSelectorFirstDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        lstKeyColumns.Columns.Add(" ")
        lstKeyColumns.Columns.Add(ucrSelectorSecondDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        lstKeyColumns.Columns(0).Width = 75
        lstKeyColumns.Columns(1).Width = 31
        lstKeyColumns.Columns(2).Width = 75
        cmdRemoveAll.Enabled = False
    End Sub

    Private Sub cmdAddPair_Click(sender As Object, e As EventArgs) Handles cmdAddPair.Click
        Dim i As Integer
        Dim bFound As Boolean = False

        ' If either column of pair already appears in the list, modify that list, since we can't have a column matched to multiple columns
        For i = 0 To lstKeyColumns.Items.Count - 1
            If lstKeyColumns.Items(i).Text = ucrReceiverFirstDF.GetVariableNames(False) Then
                lstKeyColumns.Items(i).SubItems(2).Text() = ucrReceiverSecondDF.GetVariableNames(False)
                bFound = True
            ElseIf lstKeyColumns.Items(i).SubItems(2).Text() = ucrReceiverSecondDF.GetVariableNames(False) Then
                lstKeyColumns.Items(i).Text = ucrReceiverFirstDF.GetVariableNames(False)
                bFound = True
            End If
        Next

        If Not bFound Then
            lstKeyColumns.Items.Add(ucrReceiverFirstDF.GetVariableNames(False)).SubItems.AddRange({"and", ucrReceiverSecondDF.GetVariableNames(False)})
        End If
        cmdRemoveAll.Enabled = True
        ucrReceiverFirstDF.Clear()
        ucrReceiverSecondDF.Clear()
        SetByArgument()
    End Sub

    Private Sub lstKeyColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKeyColumns.SelectedIndexChanged
        If lstKeyColumns.SelectedItems.Count = 0 Then
            cmdRemoveSelectedPair.Enabled = False
        Else
            cmdRemoveSelectedPair.Enabled = True
        End If
    End Sub

    Private Sub cmdRemoveSelectedPair_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelectedPair.Click
        Dim i As Integer

        If lstKeyColumns.SelectedItems.Count > 0 Then
            For i = lstKeyColumns.SelectedItems.Count - 1 To 0 Step -1
                lstKeyColumns.Items.RemoveAt(lstKeyColumns.SelectedIndices(i))
            Next
        End If
        SetByArgument()
    End Sub

    Private Sub cmdRemoveAll_Click(sender As Object, e As EventArgs) Handles cmdRemoveAll.Click
        ResetKeyList()
    End Sub

    Private Sub ucrReceiverFirstDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstDF.ControlValueChanged
        AutoAddInOtherReceiver(ucrReceiverFirstDF, ucrReceiverSecondDF)
    End Sub

    Private Sub ucrReceiverSecondDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondDF.ControlValueChanged
        AutoAddInOtherReceiver(ucrReceiverSecondDF, ucrReceiverFirstDF)
    End Sub
End Class