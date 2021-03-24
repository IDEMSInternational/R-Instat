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

Public Class sdgMergeColumnstoInclude
    Private bControlsInitialised As Boolean = False
    Private clsByList As New RFunction
    Private clsMerge As RFunction

    Private Sub sdgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitiatiseControls()
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

    Public Sub Setup(strFirstDataName As String, strSecondDataName As String, clsNewMerge As RFunction, clsNewByList As RFunction, bReset As Boolean, Optional bNewEnableColumnSelection As Boolean = True)
        If Not bControlsInitialised Then
            InitiatiseControls()
        End If

        If bNewEnableColumnSelection Then
            ucrSelectorColumnsToIncludeFirst.SetDataframe(strFirstDataName, False)
            ucrSelectorColumnsToIncludeSecond.SetDataframe(strSecondDataName, False)
        End If
        clsMerge = clsNewMerge
        clsByList = clsNewByList

        If bNewEnableColumnSelection Then
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
        End If
    End Sub

    Private Sub SetXParameter()
        If ucrChkMergeWithSubsetFirst.Checked AndAlso Not ucrReceiverFirstSelected.IsEmpty Then
            clsMerge.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstSelected.GetVariables(bForceAsDataFrame:=True), iPosition:=0)
        Else
            clsMerge.AddParameter("x", clsRFunctionParameter:=ucrSelectorColumnsToIncludeFirst.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If
        ucrSelectorColumnsToIncludeFirst.SetVariablesVisible(ucrChkMergeWithSubsetFirst.Checked)
    End Sub

    Private Sub SetYParameter()
        If ucrChkMergeWithSubsetSecond.Checked AndAlso Not ucrReceiverSecondSelected.IsEmpty Then
            clsMerge.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondSelected.GetVariables(bForceAsDataFrame:=True), iPosition:=1)
        Else
            clsMerge.AddParameter("y", clsRFunctionParameter:=ucrSelectorColumnsToIncludeSecond.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=1)
        End If
        ucrSelectorColumnsToIncludeSecond.SetVariablesVisible(ucrChkMergeWithSubsetSecond.Checked)
    End Sub

    Private Sub FirstSubsetControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMergeWithSubsetFirst.ControlValueChanged, ucrReceiverFirstSelected.ControlValueChanged
        SetXParameter()
    End Sub

    Private Sub SecondSubsetControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMergeWithSubsetSecond.ControlValueChanged, ucrReceiverSecondSelected.ControlValueChanged
        SetYParameter()
    End Sub

    Private Sub sdgMergeColumnsToInclude_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim lstMatchingColumns As New List(Of String)

        ' If user has chosen a subset of columns we need to ensure 'by' columns are also included.
        If ucrChkMergeWithSubsetFirst.Checked Then
            For Each clsTmpParam As RParameter In clsByList.clsParameters
                If Not ucrReceiverFirstSelected.GetVariableNamesAsList.Contains(clsTmpParam.strArgumentName.Trim(Chr(34))) Then
                    ucrReceiverFirstSelected.Add(clsTmpParam.strArgumentName.Trim(Chr(34)), ucrSelectorColumnsToIncludeFirst.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                End If
            Next
        End If
        If ucrChkMergeWithSubsetSecond.Checked Then
            For Each clsTmpParam As RParameter In clsByList.clsParameters
                If Not ucrReceiverSecondSelected.GetVariableNamesAsList.Contains(clsTmpParam.strArgumentValue.Trim(Chr(34))) Then
                    ucrReceiverSecondSelected.Add(clsTmpParam.strArgumentValue.Trim(Chr(34)), ucrSelectorColumnsToIncludeSecond.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                End If
            Next
        End If
    End Sub
End Class
