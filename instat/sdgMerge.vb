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
    Private clsRSyntax As New RSyntax
    Private bControlsInitialised As Boolean = False
    Private clsByList As New RFunction
    Private clsMerge As RFunction

    'Private Sub sdgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'End Sub

    Public Sub InitiatiseControls()
        'Merge by Columns tab
        ucrSelectorFirstDF.SetLabelText("First Data Frame")
        ucrSelectorSecondDF.SetLabelText("Second Data Frame")

        ucrReceiverFirstDF.Selector = ucrSelectorFirstDF
        ucrReceiverFirstDF.SetMeAsReceiver()

        ucrReceiverSecondDF.Selector = ucrSelectorSecondDF
        ucrReceiverSecondDF.SetMeAsReceiver()

        ucrPnlMergeByOptions.AddRadioButton(rdoByAllMatching)
        ucrPnlMergeByOptions.AddRadioButton(rdoChooseColumns)

        ucrPnlMergeByOptions.AddParameterPresentCondition(rdoByAllMatching, "by", False)
        ucrPnlMergeByOptions.AddParameterPresentCondition(rdoChooseColumns, "by")
        ucrPnlMergeByOptions.AddToLinkedControls(ucrSelectorFirstDF, {rdoChooseColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMergeByOptions.AddToLinkedControls(ucrSelectorSecondDF, {rdoChooseColumns}, bNewLinkedHideIfParameterMissing:=True)

        ' Columns to Include tab
        ucrChkMergeWithSubsetFirst.SetText("Choose Subset of Columns to Merge")
        ucrChkMergeWithSubsetFirst.AddToLinkedControls(ucrReceiverFirstSelected, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMergeWithSubsetFirst.AddParameterValueFunctionNamesCondition(True, "x", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrChkMergeWithSubsetFirst.AddParameterValueFunctionNamesCondition(False, "x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        ucrChkMergeWithSubsetSecond.SetText("Choose Subset of Columns to Merge")
        ucrChkMergeWithSubsetSecond.AddToLinkedControls(ucrReceiverSecondSelected, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMergeWithSubsetSecond.AddParameterValueFunctionNamesCondition(True, "y", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        ucrChkMergeWithSubsetSecond.AddParameterValueFunctionNamesCondition(False, "y", frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        ucrReceiverFirstSelected.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstSelected.SetParameterIsRFunction()
        ucrReceiverFirstSelected.SetLinkedDisplayControl(lblVariablesToIncludeFirst)
        ucrReceiverFirstSelected.Selector = ucrSelectorColumnsToIncludeFirst
        ucrReceiverFirstSelected.SetMeAsReceiver()
        ucrReceiverFirstSelected.bForceAsDataFrame = True

        ucrReceiverSecondSelected.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondSelected.SetParameterIsRFunction()
        ucrReceiverSecondSelected.SetLinkedDisplayControl(lblVariablesToIncludeSecond)
        ucrReceiverSecondSelected.Selector = ucrSelectorColumnsToIncludeSecond
        ucrReceiverSecondSelected.SetMeAsReceiver()
        ucrReceiverSecondSelected.bForceAsDataFrame = True

        bControlsInitialised = True
    End Sub

    Public Sub Setup(strFirstDataName As String, strSecondDataName As String, clsNewMerge As RFunction, clsNewByList As RFunction, bReset As Boolean)
        If Not bControlsInitialised Then
            InitiatiseControls()
        End If
        ucrSelectorFirstDF.SetDataframe(strFirstDataName, False)
        ucrSelectorSecondDF.SetDataframe(strSecondDataName, False)

        ucrSelectorColumnsToIncludeFirst.SetDataframe(strFirstDataName, False)
        ucrSelectorColumnsToIncludeSecond.SetDataframe(strSecondDataName, False)

        clsMerge = clsNewMerge
        clsByList = clsNewByList
        ResetKeyList()
        For Each clsTempParam In clsByList.clsParameters
            lstKeyColumns.Items.Add(clsTempParam.strArgumentName.Trim(Chr(34))).SubItems.AddRange({"and", clsTempParam.strArgumentValue.Trim(Chr(34))})
        Next
        If bReset Then
            tbcMergeOptions.SelectedIndex = 0
        End If

        ucrPnlMergeByOptions.SetRCode(clsMerge, bReset, bCloneIfNeeded:=True)
        ucrChkMergeWithSubsetFirst.SetRCode(clsMerge, bReset, bCloneIfNeeded:=True)
        ucrChkMergeWithSubsetSecond.SetRCode(clsMerge, bReset, bCloneIfNeeded:=True)
        If ucrChkMergeWithSubsetFirst.Checked Then
            ucrReceiverFirstSelected.SetRCode(clsMerge, bReset, bCloneIfNeeded:=True)
        Else
            ucrReceiverFirstSelected.Clear()
        End If
        If ucrChkMergeWithSubsetSecond.Checked Then
            ucrReceiverSecondSelected.SetRCode(clsMerge, bReset, bCloneIfNeeded:=True)
        Else
            ucrReceiverSecondSelected.Clear()
        End If
        SetXParameter()
        SetYParameter()
    End Sub

    Public ReadOnly Property IsComplete() As Boolean
        Get
            If rdoByAllMatching.Checked Then
                Return True
            ElseIf rdoChooseColumns.Checked Then
                If lstKeyColumns.Items.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End Get
    End Property

    Private Sub AddRemoveBy()
        If rdoByAllMatching.Checked Then
            ucrSelectorFirstDF.SetVariablesVisible(False)
            ucrSelectorSecondDF.SetVariablesVisible(False)
            grpKeys.Visible = False
            pnlKeyColumns.Visible = False
            clsMerge.RemoveParameterByName("by")
        ElseIf rdoChooseColumns.Checked Then
            ucrSelectorFirstDF.SetVariablesVisible(True)
            ucrSelectorSecondDF.SetVariablesVisible(True)
            grpKeys.Visible = True
            pnlKeyColumns.Visible = True
            SetByArgument()
        End If
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
            clsMerge.AddParameter("by", clsRFunctionParameter:=clsByList)
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

    Private Sub SetXParameter()
        If ucrChkMergeWithSubsetFirst.Checked AndAlso Not ucrReceiverFirstSelected.IsEmpty Then
            clsMerge.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstSelected.GetVariables(bForceAsDataFrame:=True))
        Else
            clsMerge.AddParameter("x", clsRFunctionParameter:=ucrSelectorColumnsToIncludeFirst.ucrAvailableDataFrames.clsCurrDataFrame)
        End If
        ucrSelectorColumnsToIncludeFirst.SetVariablesVisible(ucrChkMergeWithSubsetFirst.Checked)
    End Sub

    Private Sub SetYParameter()
        If ucrChkMergeWithSubsetSecond.Checked AndAlso Not ucrReceiverSecondSelected.IsEmpty Then
            clsMerge.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondSelected.GetVariables(bForceAsDataFrame:=True))
        Else
            clsMerge.AddParameter("y", clsRFunctionParameter:=ucrSelectorColumnsToIncludeSecond.ucrAvailableDataFrames.clsCurrDataFrame)
        End If
        ucrSelectorColumnsToIncludeSecond.SetVariablesVisible(ucrChkMergeWithSubsetSecond.Checked)
    End Sub

    Private Sub ucrPnlMergeByOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMergeByOptions.ControlValueChanged
        pnlKeyColumns.Visible = rdoChooseColumns.Checked
        grpKeys.Visible = rdoChooseColumns.Checked
        AddRemoveBy()
    End Sub

    Private Sub cmdRemoveAll_Click(sender As Object, e As EventArgs) Handles cmdRemoveAll.Click
        ResetKeyList()
    End Sub

    Private Sub ucrReceiverSecondDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondDF.ControlValueChanged
        AutoAddInOtherReceiver(ucrReceiverSecondDF, ucrReceiverFirstDF)
    End Sub

    Private Sub ucrReceiverFirstDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstDF.ControlValueChanged
        AutoAddInOtherReceiver(ucrReceiverFirstDF, ucrReceiverSecondDF)
    End Sub

    Private Sub FirstSubsetControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMergeWithSubsetFirst.ControlValueChanged, ucrReceiverFirstSelected.ControlValueChanged
        SetXParameter()
    End Sub

    Private Sub SecondSubsetControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMergeWithSubsetSecond.ControlValueChanged, ucrReceiverSecondSelected.ControlValueChanged
        SetYParameter()
    End Sub
End Class