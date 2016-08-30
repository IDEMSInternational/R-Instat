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
Imports System.ComponentModel

Public Class ucrInputComboBox
    Dim strItemsType As String = ""

    Private Sub cboInput_Validating(sender As Object, e As CancelEventArgs) Handles cboInput.Validating
        e.Cancel = Not ValidateText(cboInput.Text)
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
        Dim strItems As String()

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
                    strItems = frmMain.clsRLink.GetFilterNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray()
                    If strItems.Count > 0 Then
                        cboInput.Items.AddRange(strItems)
                    End If
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
    End Sub

    Private Sub cboInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboInput.KeyPress
        bUserTyped = True
    End Sub

    Public Overrides Function IsEmpty() As Boolean
        If cboInput.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ucrInputComboBox_Load(sender As Object, e As EventArgs) Handles Me.Load
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
End Class
