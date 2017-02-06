﻿' Instat-R
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
Imports System.ComponentModel
Imports instat

Public Class ucrInputComboBox
    Dim strItemsType As String = ""

    Private Sub cboInput_Validating(sender As Object, e As CancelEventArgs) Handles cboInput.Validating
        Dim strCurrent As String

        strCurrent = cboInput.Text
        If bAutoChangeOnLeave Then
            If Not IsValid(strCurrent) Then
                'TODO This message should contain the same message from ValidateText()
                'Select Case MsgBox(Chr(34) & strCurrent & Chr(34) & " is an invalid name." & vbNewLine & "Would you like it to be automatically corrected?", vbYesNo, "Invalid Name")
                '    Case MsgBoxResult.Yes
                '        SetName(frmMain.clsRLink.MakeValidText(strCurrent))
                '    Case Else
                '        e.Cancel = True
                'End Select
                SetName(frmMain.clsRLink.MakeValidText(strCurrent))
            End If
        Else
            e.Cancel = Not ValidateText(strCurrent)
        End If
        If Not e.Cancel Then OnNameChanged()
    End Sub

    Public Sub SetItemsTypeAsColumns()
        strItemsType = "Columns"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsDataFrames()
        strItemsType = "Data Frames"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsModels()
        strItemsType = "Models"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsGraphs()
        strItemsType = "Graphs"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsFilters()
        strItemsType = "Filters"
        FillItemTypes()
    End Sub

    Private Sub FillItemTypes()
        Select Case strItemsType
            Case "Columns"
                If ucrDataFrameSelector IsNot Nothing Then
                    frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboInput)
                End If
            Case "Data Frames"
            Case "Models"
                If ucrDataFrameSelector IsNot Nothing Then
                    cboInput.Items.Clear()
                    cboInput.Items.AddRange(frmMain.clsRLink.GetModelNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray)
                End If
            Case "Graphs"
                If ucrDataFrameSelector IsNot Nothing Then
                    cboInput.Items.Clear()
                    cboInput.Items.AddRange(frmMain.clsRLink.GetGraphNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray())
                End If

            Case "Filters"
                If ucrDataFrameSelector IsNot Nothing Then
                    cboInput.Items.Clear()
                    cboInput.Items.AddRange(frmMain.clsRLink.GetFilterNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray())
                End If
        End Select
    End Sub

    Public Sub ucrDataFrameSelector_DataFrameChanged() Handles ucrDataFrameSelector.DataFrameChanged
        FillItemTypes()
    End Sub

    Public Overrides Sub SetDataFrameSelector(ucrNewSelector As ucrDataFrame)
        MyBase.SetDataFrameSelector(ucrNewSelector)
        FillItemTypes()
    End Sub

    Public Overrides Sub SetName(strName As String, Optional bSilent As Boolean = False)
        MyBase.SetName(strName, bSilent)
        If bSilent Then
            cboInput.Text = strName
            If cboInput.FindStringExact(strName) <> -1 Then
                cboInput.SelectedIndex = cboInput.FindStringExact(strName)
            End If
            OnNameChanged()
        Else
            If ValidateText(strName) Then
                cboInput.Text = strName
                OnNameChanged()
            End If
        End If
    End Sub

    Public Overrides Function GetText() As String
        Return cboInput.Text
    End Function

    Public Sub SetItems(strItems As String(), Optional bClearExisting As Boolean = True)
        If bClearExisting Then
            cboInput.Items.Clear()
        End If
        cboInput.Items.AddRange(strItems)
        AdjustComboBoxWidth(cboInput)
    End Sub

    Public Sub SetItems(dctItemParameterValuePairs As Dictionary(Of String, String), Optional bClearExisting As Boolean = True)
        Dim kvpTemp As KeyValuePair(Of String, String)

        If bClearExisting Then
            cboInput.Items.Clear()
        End If
        If clsParameter Is Nothing Then
            MsgBox("Developer error: Parameter must be set before items can be set. Modify setup for " & Name & " so that the parameter is set first.")
        End If
        For Each kvpTemp In dctItemParameterValuePairs
            cboInput.Items.Add(kvpTemp.Key)
            dctDisplayParameterValues.Add(kvpTemp.Key, kvpTemp.Value)
            AddParameterValuesCondition(kvpTemp.Key, clsParameter.strArgumentName, kvpTemp.Value)
        Next
        AdjustComboBoxWidth(cboInput)
    End Sub

    Private Sub cboInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboInput.KeyPress
        bUserTyped = True
    End Sub

    'Public Sub SetEditable(bEditable As Boolean)

    '    If bEditable Then
    '        cboInput.DropDownStyle = ComboBoxStyle.DropDownList
    '    Else
    '        cboInput.DropDownStyle = ComboBoxStyle.DropDown
    '    End If
    'End Sub
    Public Overrides Function IsEmpty() As Boolean
        If cboInput.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ucrInputComboBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        bAllowNonConditionValues = False
        FillItemTypes()
    End Sub

    Private Sub cboInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInput.SelectedIndexChanged
        OnNameChanged()
    End Sub

    Private Sub ucrInputComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'If bIsReadOnly Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub cboInput_TextChanged(sender As Object, e As EventArgs) Handles cboInput.TextChanged
        OnContentsChanged()
    End Sub

    Private Sub mnuRightClickCopy_Click(sender As Object, e As EventArgs) Handles mnuRightClickCopy.Click
        Clipboard.SetText(cboInput.SelectedText)
    End Sub

    'This seems overly complicated, but appears only way to auto size
    'Adapted from: http://dotnetanaya.blogspot.co.uk/2012/12/vbnet-adjusting-combobox-dropdownlist.html
    'Need to make sure this is called from all places needed
    'There is no build in event to check items added
    'TODO this is repeat in clsRLink for ucrDataFrame, will not be needed once controls changed
    'Should have a place for shared methods
    Public Sub AdjustComboBoxWidth(cboCurrent As ComboBox)
        Dim iWidth As Integer = cboCurrent.DropDownWidth
        Dim graTemp As Graphics = cboCurrent.CreateGraphics()
        Dim font As Font = cboCurrent.Font
        Dim iScrollBarWidth As Integer
        Dim iNewWidth As Integer

        If cboCurrent.Items.Count > cboCurrent.MaxDropDownItems Then
            iScrollBarWidth = SystemInformation.VerticalScrollBarWidth
        Else
            iScrollBarWidth = 0
        End If

        For Each strItem As String In cboCurrent.Items
            iNewWidth = CInt(graTemp.MeasureString(strItem, font).Width) + iScrollBarWidth
            iWidth = Math.Max(iWidth, iNewWidth)
        Next
        cboCurrent.DropDownWidth = iWidth
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
        MyBase.UpdateControl(bReset)
    End Sub
End Class
