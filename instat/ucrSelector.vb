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

Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver
    Public Event ResetAll()
    Public Event ResetReceivers()
    Public Event VariablesInReceiversChanged()
    Public lstVariablesInReceivers As List(Of String)
    Public bFirstLoad As Boolean = True

    Private Sub ucrSelection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        lstVariablesInReceivers = New List(Of String)
    End Sub

    Protected Sub OnResetAll()
        RaiseEvent ResetAll()
    End Sub

    Protected Sub OnResetReceivers()
        RaiseEvent ResetReceivers()
    End Sub

    Public Overridable Sub LoadList()
        If CurrentReceiver IsNot Nothing Then
            frmMain.clsRLink.FillListView(lstAvailableVariable, strDataType:=CurrentReceiver.strDataType)
        End If
    End Sub

    Public Overridable Sub Reset()
        RaiseEvent ResetReceivers()
        LoadList()
        InitialiseDialog()
        'lstItemsInReceivers.Clear()
    End Sub

    Public Sub SetCurrentReceiver(conReceiver As ucrReceiver)
        If CurrentReceiver IsNot Nothing Then
            CurrentReceiver.RemoveColor()
        End If
        CurrentReceiver = conReceiver
        CurrentReceiver.SetColor()
        LoadList()
        If (TypeOf CurrentReceiver Is ucrReceiverSingle) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.One
            lstAvailableVariable.MultiSelect = False
        ElseIf (TypeOf CurrentReceiver Is ucrReceiverMultiple) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.MultiExtended
            lstAvailableVariable.MultiSelect = True
        End If
    End Sub

    Public Sub Add()
        If CurrentReceiver IsNot Nothing AndAlso (lstAvailableVariable.SelectedItems.Count > 0) Then
            CurrentReceiver.AddSelected()
            CurrentReceiver.Focus()
        End If
    End Sub

    'TODO can this be removed?
    'Public Sub AddVariable(strDataFrameName As String, strVariableName As String)
    '    Dim lviTemp As New ListViewItem
    '    lstAvailableVariable.SelectedItems.Clear()
    '    lstAvailableVariable.FullRowSelect = True
    '    lstAvailableVariable.HideSelection = False
    '    CurrentReceiver.Clear()
    '    For Each lviTemp In lstAvailableVariable.Items
    '        If lviTemp.Name = strVariableName Then
    '            If lviTemp.Group.Name = strDataFrameName Then
    '                lviTemp.Selected = True
    '                lstAvailableVariable.Select()
    '            End If
    '        End If
    '    Next
    '    Add()
    'End Sub
    Public Sub ShowOptionsDialog()
        'code for dislaying dialog goes here
        sdgRestrict.ShowDialog()
    End Sub
    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableVariable.DoubleClick
        Add()
    End Sub

    Private Sub lstAvailableVariable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lstAvailableVariable.KeyPress
        If e.KeyChar = vbCr Then
            Add()
        End If
    End Sub

    Private Sub ucrSelector_ResetAll() Handles Me.ResetAll
        Reset()
    End Sub

    Private Sub AddSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSelectedToolStripMenuItem.Click
        Add()
    End Sub

    Private Sub ClearSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearSelectionToolStripMenuItem.Click
        lstAvailableVariable.SelectedItems.Clear()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim lviTemp As ListViewItem

        lstAvailableVariable.BeginUpdate()
        For Each lviTemp In lstAvailableVariable.Items
            lviTemp.Selected = True
        Next
        lstAvailableVariable.EndUpdate()

    End Sub

    Public Sub AddToVariablesList(strVariable As String)
        lstVariablesInReceivers.Add(strVariable)
        RaiseEvent VariablesInReceiversChanged()
    End Sub

    Public Sub RemoveFromVariablesList(strVariable As String)
        lstVariablesInReceivers.Remove(strVariable)
        RaiseEvent VariablesInReceiversChanged()
    End Sub

End Class