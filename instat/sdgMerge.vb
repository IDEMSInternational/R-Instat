' Instat+R
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

Public Class sdgMerge
    Private clsByList As New RFunction
    Private clsRSyntax As New RSyntax
    Private bFirstLoad As Boolean = True

    Private Sub sdgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
        End If
    End Sub

    Private Sub InitialiseDialog()
        cmdAddAnotherPair.Enabled = False
        ucrReceiverFirstDF.Selector = ucrSelectorFirstDataFrame
        ucrReceiverSecondDF.Selector = ucrSelectorSecondDataFrame
        clsByList.SetRCommand("c")
        ucrReceiverFirstDF.bExcludeFromSelector = True
        ucrReceiverSecondDF.bExcludeFromSelector = True
    End Sub

    Public Sub SetDefaults()
        ucrReceiverFirstDF.SetMeAsReceiver()
        ucrReceiverSecondDF.SetMeAsReceiver()
    End Sub

    Private Sub ResetKeyList()
        lstKeyColumns.Columns.Clear()
        lstKeyColumns.Clear()
        lstKeyColumns.Columns.Add(ucrSelectorFirstDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        lstKeyColumns.Columns.Add("-")
        lstKeyColumns.Columns.Add(ucrSelectorSecondDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        lstKeyColumns.Columns(0).Width = 95
        lstKeyColumns.Columns(1).Width = 80
        lstKeyColumns.Columns(2).Width = 95
        pnlKeyColumns.Hide()
    End Sub

    Public Sub SetRSyntax(clsNewRSyntax As RSyntax)
        clsRSyntax = clsNewRSyntax
    End Sub

    Private Sub SetByArgument()
        Dim lviItem As ListViewItem
        clsByList.ClearParameters()
        If Not ucrReceiverFirstDF.IsEmpty() AndAlso Not ucrReceiverSecondDF.IsEmpty() Then
            clsByList.AddParameter(ucrReceiverFirstDF.GetVariableNames(), ucrReceiverFirstDF.GetVariableNames())
        End If
        For Each lviItem In lstKeyColumns.Items
            clsByList.AddParameter(lviItem.Text(), lviItem.SubItems(2).Text())
        Next
        ByParameterCheck()
    End Sub

    Private Sub ucrReceiverFirstDF_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstDF.SelectionChanged
        AutoAddInOtherReceiver(ucrReceiverFirstDF, ucrReceiverSecondDF)
    End Sub

    Private Sub ucrReceiverSecondDF_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondDF.SelectionChanged
        AutoAddInOtherReceiver(ucrReceiverSecondDF, ucrReceiverFirstDF)
    End Sub

    Public Sub AutoAddInOtherReceiver(ucrChangedReceiver As ucrReceiverSingle, ucrOtherReceiver As ucrReceiverSingle)
        If Not ucrChangedReceiver.IsEmpty() Then
            If ucrOtherReceiver.IsEmpty AndAlso ucrOtherReceiver.Selector.ContainsVariable(ucrChangedReceiver.GetVariableNames(False)) Then
                ucrOtherReceiver.Add(ucrChangedReceiver.GetVariableNames(False))
            End If
        End If
        If ucrChangedReceiver.IsEmpty() OrElse ucrOtherReceiver.IsEmpty Then
            cmdAddAnotherPair.Enabled = False
        Else
            cmdAddAnotherPair.Enabled = True
        End If
        SetByArgument()
    End Sub

    Private Sub cmdAddAnotherPair_Click(sender As Object, e As EventArgs) Handles cmdAddAnotherPair.Click
        lstKeyColumns.Items.Add(ucrReceiverFirstDF.GetVariableNames()).SubItems.AddRange({"Matched With", ucrReceiverSecondDF.GetVariableNames()})
        pnlKeyColumns.Show()
        ucrReceiverFirstDF.Clear()
        ucrReceiverSecondDF.Clear()
        SetByArgument()
    End Sub

    Private Sub cmdRemoveSelectedPair_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelectedPair.Click
        Dim i As Integer

        If lstKeyColumns.SelectedItems.Count > 0 Then
            For i = lstKeyColumns.SelectedItems.Count - 1 To 0 Step -1
                lstKeyColumns.Items.RemoveAt(lstKeyColumns.SelectedIndices(i))
            Next
        End If
    End Sub

    Private Sub lstKeyColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKeyColumns.SelectedIndexChanged
        If lstKeyColumns.SelectedItems.Count = 0 Then
            cmdRemoveSelectedPair.Enabled = False
        Else
            cmdRemoveSelectedPair.Enabled = True
        End If
    End Sub

    Public Sub ByParameterCheck()
        If (Not ucrReceiverFirstDF.IsEmpty() AndAlso Not ucrReceiverSecondDF.IsEmpty) OrElse lstKeyColumns.Items.Count > 0 Then
            clsRSyntax.AddParameter("by", clsRFunctionParameter:=clsByList)
        Else
            clsRSyntax.RemoveParameter("by")
        End If
    End Sub

    Public Function IsOkEnabled() As Boolean
        If lstKeyColumns.Items.Count > 0 Then
            Return True
        Else
            If Not ucrReceiverFirstDF.IsEmpty AndAlso Not ucrReceiverSecondDF.IsEmpty Then
                Return True
            Else
                Return False
            End If
        End If
    End Function

    Public Sub SetDataFrame(bFirst As Boolean, strDataFrame As String, Optional bEnabled As Boolean = False)
        Dim ucrCurrentDataFrame As ucrDataFrame
        If bFirst Then
            ucrCurrentDataFrame = ucrSelectorFirstDataFrame.ucrAvailableDataFrames
        Else
            ucrCurrentDataFrame = ucrSelectorSecondDataFrame.ucrAvailableDataFrames
        End If
        ucrCurrentDataFrame.SetDataframe(strDataFrame, bEnabled)
    End Sub

    Private Sub ucrSelectorsChanged_DataFrameChanged() Handles ucrSelectorFirstDataFrame.DataFrameChanged, ucrSelectorSecondDataFrame.DataFrameChanged
        ResetKeyList()
    End Sub
End Class