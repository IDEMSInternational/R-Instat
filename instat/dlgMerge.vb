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
Imports instat.Translations

Public Class dlgMerge
    Private bFirstLoad As Boolean = True
    Private clsByList As New RFunction

    Private Sub dlgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 60
        ucrNewDataFrameName.SetValidationTypeAsRVariable()
        cmdAddAnotherPair.Enabled = False
        ucrReceiverFirstDF.Selector = ucrSelectorFirstDataFrame
        ucrReceiverSecondDF.Selector = ucrSelectorSecondDataFrame
        clsByList.SetRCommand("c")
        ucrBase.clsRsyntax.AddParameter("by", clsRFunctionParameter:=clsByList)
        ucrReceiverFirstDF.bExcludeFromSelector = True
        ucrReceiverSecondDF.bExcludeFromSelector = True
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrSelectorFirstDataFrame.Reset()
        ucrSelectorSecondDataFrame.Reset()
        ucrReceiverFirstDF.SetMeAsReceiver()
        ucrReceiverSecondDF.SetMeAsReceiver()
        rdoLeftJoin.Checked = True
        rdoChooseMergeColumns.Checked = True
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrNewDataFrameName.IsEmpty() Then
            ucrBase.OKEnabled(False)
        Else
            If rdoChooseMergeColumns.Checked Then
                If (Not ucrReceiverFirstDF.IsEmpty() AndAlso Not ucrReceiverSecondDF.IsEmpty) OrElse lstKeyColumns.Items.Count > 0 Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoMergeByAllColumns.Checked Then
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDataFrames_DataFrameChanged() Handles ucrSelectorFirstDataFrame.DataFrameChanged, ucrSelectorSecondDataFrame.DataFrameChanged
        If Not ucrNewDataFrameName.UserTyped() Then
            ucrNewDataFrameName.SetName(ucrSelectorFirstDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_merged_with_" & ucrSelectorSecondDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrSelectorFirstDataFrame.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrSelectorSecondDataFrame.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("suffix", "c(" & Chr(34) & ucrSelectorFirstDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34) & ", " & Chr(34) & ucrSelectorSecondDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34) & ")")
        ResetKeyList()
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

    Private Sub JoinType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFullJoin.CheckedChanged, rdoInnerJoin.CheckedChanged, rdoLeftJoin.CheckedChanged, rdoRightJoin.CheckedChanged
        If rdoLeftJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("left_join")
        ElseIf rdoFullJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("full_join")
        ElseIf rdoInnerJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("inner_join")
        ElseIf rdoRightJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("right_join")
        End If
    End Sub

    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If ucrNewDataFrameName.IsEmpty Then
            ucrBase.clsRsyntax.RemoveAssignTo()
        Else
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        End If
        TestOKEnabled()
    End Sub

    Private Sub KeyOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMergeByAllColumns.CheckedChanged, rdoChooseMergeColumns.CheckedChanged
        If rdoChooseMergeColumns.Checked Then
            grpKeys.Visible = True
            SetByArgument()
            ucrSelectorFirstDataFrame.SetVariablesEnabled(True)
            ucrSelectorSecondDataFrame.SetVariablesEnabled(True)
        Else
            grpKeys.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("by")
            ucrSelectorFirstDataFrame.SetVariablesEnabled(False)
            ucrSelectorSecondDataFrame.SetVariablesEnabled(False)
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFirstDFKey1_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstDF.SelectionChanged
        If Not ucrReceiverFirstDF.IsEmpty() Then
            If ucrReceiverSecondDF.IsEmpty AndAlso ucrSelectorSecondDataFrame.ContainsVariable(ucrReceiverFirstDF.GetVariableNames(False)) Then
                ucrReceiverSecondDF.Add(ucrReceiverFirstDF.GetVariableNames(False))
            End If
        End If
        If ucrReceiverFirstDF.IsEmpty() OrElse ucrReceiverSecondDF.IsEmpty Then
            cmdAddAnotherPair.Enabled = False
        Else
            cmdAddAnotherPair.Enabled = True
        End If
        SetByArgument()
        TestOKEnabled()
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
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondDF_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondDF.SelectionChanged

    End Sub
End Class