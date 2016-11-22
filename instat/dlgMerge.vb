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

    ' This dialog has a bug when using numeric and integer columns as the joining columns.
    ' Issue reported here: https://github.com/hadley/dplyr/issues/2164
    ' The current fix we suggest is to first convert integer joining columns to numeric columns.
    ' Alternatives would be to use the much slower base merge 
    ' or plyr::join which cannot handle joining columns with different names
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
        sdgMerge.SetRSyntax(ucrBase.clsRsyntax)
        ucrReceiverFirstDF.Selector = ucrSelectorFirstDF
        ucrReceiverSecondDF.Selector = ucrSelectorSecondDF
        ' Ideally this is what we want but the functionality of the selectors/receivers doesn't allow for this yet
        ' The list should be set up so that errors and not possible with the by argument
        'ucrReceiverFirstDF.bExcludeFromSelector = True
        'ucrReceiverSecondDF.bExcludeFromSelector = True
        ucrReceiverFirstDF.SetMeAsReceiver()
        ucrReceiverSecondDF.SetMeAsReceiver()
        clsByList.SetRCommand("c")
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrSelectorFirstDF.Reset()
        ucrSelectorSecondDF.Reset()
        sdgMerge.SetDefaults()
        rdoByAllMatching.Checked = True
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrNewDataFrameName.IsEmpty() Then
            ucrBase.OKEnabled(False)
        Else
            If rdoByAllMatching.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoChooseColumns.Checked Then
                If lstKeyColumns.Items.Count > 0 Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        sdgMerge.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorFirstDF_DataFrameChanged() Handles ucrSelectorFirstDF.DataFrameChanged
        SetDataFrameParameters()
        ResetKeyList()
    End Sub

    Private Sub ucrSelectorSecondDF_DataFrameChanged() Handles ucrSelectorSecondDF.DataFrameChanged
        SetDataFrameParameters()
        ResetKeyList()
    End Sub

    Private Sub SetDataFrameParameters()
        If Not ucrNewDataFrameName.UserTyped() Then
            ucrNewDataFrameName.SetName("Merge_" & ucrSelectorFirstDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_" & ucrSelectorSecondDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrSelectorFirstDF.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrSelectorSecondDF.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("suffix", "c(" & Chr(34) & ucrSelectorFirstDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34) & ", " & Chr(34) & ucrSelectorSecondDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34) & ")")
    End Sub

    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If ucrNewDataFrameName.IsEmpty Then
            ucrBase.clsRsyntax.RemoveAssignTo()
        Else
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdChooseMergeColumns_Click(sender As Object, e As EventArgs)
        sdgMerge.ShowDialog()
    End Sub

    Private Sub MatchingColumns_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByAllMatching.CheckedChanged, rdoChooseColumns.CheckedChanged
        If rdoByAllMatching.Checked Then
            ucrSelectorFirstDF.SetVariablesVisible(False)
            ucrSelectorSecondDF.SetVariablesVisible(False)
            grpKeys.Visible = False
            pnlKeyColumns.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("by")
        ElseIf rdoChooseColumns.Checked Then
            ucrSelectorFirstDF.SetVariablesVisible(True)
            ucrSelectorSecondDF.SetVariablesVisible(True)
            grpKeys.Visible = True
            pnlKeyColumns.Visible = True
            SetByArgument()
        End If
        TestOKEnabled()
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
        ucrBase.clsRsyntax.AddParameter("by", clsRFunctionParameter:=clsByList)
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
        ucrBase.clsRsyntax.RemoveParameter("by")
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
        TestOKEnabled()
    End Sub

    Private Sub lstKeyColumns_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKeyColumns.SelectedIndexChanged
        If lstKeyColumns.SelectedItems.Count = 0 Then
            cmdRemoveSelectedPair.Enabled = False
        Else
            cmdRemoveSelectedPair.Enabled = True
        End If
    End Sub

    Private Sub ucrReceiverFirstDF_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstDF.SelectionChanged
        AutoAddInOtherReceiver(ucrReceiverFirstDF, ucrReceiverSecondDF)
    End Sub

    Private Sub ucrReceiverSecondDF_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondDF.SelectionChanged
        AutoAddInOtherReceiver(ucrReceiverSecondDF, ucrReceiverFirstDF)
    End Sub

    Private Sub cmdRemoveSelectedPair_Click(sender As Object, e As EventArgs) Handles cmdRemoveSelectedPair.Click
        Dim i As Integer

        If lstKeyColumns.SelectedItems.Count > 0 Then
            For i = lstKeyColumns.SelectedItems.Count - 1 To 0 Step -1
                lstKeyColumns.Items.RemoveAt(lstKeyColumns.SelectedIndices(i))
            Next
        End If
        SetByArgument()
        TestOKEnabled()
    End Sub

    Private Sub cmdRemoveAll_Click(sender As Object, e As EventArgs) Handles cmdRemoveAll.Click
        ResetKeyList()
        TestOKEnabled()
    End Sub

    Private Sub cmdJoinOptions_Click(sender As Object, e As EventArgs) Handles cmdJoinOptions.Click
        sdgMerge.ShowDialog()
    End Sub

    Private Sub ucrNewDataFrameName_ContentsChanged() Handles ucrNewDataFrameName.ContentsChanged
        TestOKEnabled()
    End Sub
End Class