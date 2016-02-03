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

Imports RDotNet
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As New ucrReceiver

    Private Sub ucrdataselection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList(strDataType:=CurrentReceiver.strDataType)
    End Sub

    Public Overridable Sub LoadList(Optional strDataType As String = "all")
        frmMain.clsRLink.FillListView(lstAvailableVariable, strDataType)
    End Sub

    Public Sub SetCurrentReceiver(conReceiver As ucrReceiver)
        If CurrentReceiver.strDataType <> conReceiver.strDataType Then
            LoadList(strDataType:=conReceiver.strDataType)
        End If
        CurrentReceiver = conReceiver
        If (TypeOf CurrentReceiver Is ucrReceiverSingle) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.One
            lstAvailableVariable.MultiSelect = False
        ElseIf (TypeOf CurrentReceiver Is ucrReceiverMultiple) Then
            'lstAvailableVariable.SelectionMode = SelectionMode.MultiExtended
            lstAvailableVariable.MultiSelect = True
        End If
    End Sub

    Public Sub Add()
        If (lstAvailableVariable.SelectedItems.Count > 0) Then
            CurrentReceiver.AddSelected()
            CurrentReceiver.Focus()
        End If
    End Sub

    Public Sub AddVariable(strDataFrameName As String, strVariableName As String)
        Dim lviTemp As New ListViewItem
        Dim j As Integer
        lstAvailableVariable.SelectedItems.Clear()
        lstAvailableVariable.FullRowSelect = True
        lstAvailableVariable.HideSelection = False
        CurrentReceiver.Clear()
        For Each lviTemp In lstAvailableVariable.Items
            If lviTemp.Name = strVariableName Then
                If lviTemp.Group.Name = strDataFrameName Then
                    lviTemp.Selected = True
                    lstAvailableVariable.Select()
                End If
            End If
        Next
        Add()
    End Sub

    Public Sub Remove()
        CurrentReceiver.RemoveSelected()
    End Sub

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableVariable.DoubleClick
        Add()
    End Sub

    Private Sub lstAvailableVariable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lstAvailableVariable.KeyPress
        If e.KeyChar = vbCr Then
            Add()
        End If
    End Sub

End Class