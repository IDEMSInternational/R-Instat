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

Public Class ucrReceiverExpression
    Private lstItemsInExpression As List(Of KeyValuePair(Of String, String))
    Private lstDataFrames As List(Of String)
    Private iCurrentPosition As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstItemsInExpression = New List(Of KeyValuePair(Of String, String))
        lstDataFrames = New List(Of String)
    End Sub

    Public Overrides Sub AddSelected()
        If Selector.lstAvailableVariable.SelectedItems.Count = 1 Then
            Add(Selector.lstAvailableVariable.SelectedItems.Item(0).Text, Selector.lstAvailableVariable.SelectedItems.Item(0).Tag)
        Else
            'Error?
        End If
    End Sub

    Public Overrides Sub Add(strItem As String, Optional strDataFrame As String = "")
        Dim strCurrentItemType As String
        Dim kvpItem As KeyValuePair(Of String, String)

        MyBase.Add(strItem, strDataFrame)

        If bTypeSet Then
            strCurrentItemType = strType
        Else
            strCurrentItemType = Selector.GetItemType()
        End If
        If cboExpression.Enabled Then
            If strCurrentItemType = "column" Then
                If strDataFrame = "" Then
                    SetMeAsReceiver()
                    For i = 0 To Selector.lstAvailableVariable.Items.Count - 1
                        If Selector.lstAvailableVariable.Items(i).Text = strItem Then
                            strDataFrame = Selector.lstAvailableVariable.Items(i).Tag
                        End If
                    Next
                End If
            End If
            If Not lstDataFrames.Contains(strDataFrame) Then
                lstDataFrames.Add(strDataFrame)
            End If
            kvpItem = New KeyValuePair(Of String, String)(strDataFrame, strItem)
            AddToItemsInExpressionList(kvpItem)
            AddToReceiverAtCursorPosition(strItem)
            Selector.AddToVariablesList(strItem)
            OnSelectionChanged()
        End If
    End Sub

    Private Sub AddToItemsInExpressionList(kvpItem As KeyValuePair(Of String, String))
        If Not lstItemsInExpression.Contains(kvpItem) Then
            lstItemsInExpression.Add(kvpItem)
        End If
    End Sub

    Public Sub AddToReceiverAtPosition(strText As String, iPosition As Integer)
        cboExpression.Text = cboExpression.Text.Insert(iPosition, strText)
        iCurrentPosition = iCurrentPosition + strText.Length
        cboExpression.SelectionStart = iCurrentPosition
        cboExpression.SelectedText = ""
    End Sub

    Public Sub AddToReceiverAtCursorPosition(strText As String)
        AddToReceiverAtPosition(strText, iCurrentPosition)
    End Sub

    Public Overrides Sub RemoveSelected()
        Dim kvpItem As KeyValuePair(Of String, String)

        If cboExpression.Enabled Then
            If Selector IsNot Nothing Then
                For Each kvpItem In lstItemsInExpression
                    Selector.RemoveFromVariablesList(kvpItem.Value)
                Next
            End If
            cboExpression.Text = ""
        End If
        MyBase.RemoveSelected()
    End Sub

    Public Overrides Sub Clear()
        RemoveSelected()
        iCurrentPosition = 0
    End Sub

    Public Overrides Function IsEmpty() As Boolean
        Return cboExpression.Text = ""
    End Function

    Private Sub cboExpression_KeyUp(sender As Object, e As KeyEventArgs) Handles cboExpression.KeyUp
        iCurrentPosition = cboExpression.SelectionStart
    End Sub

    Private Sub cboExpression_MouseDown(sender As Object, e As MouseEventArgs) Handles cboExpression.MouseDown
        iCurrentPosition = cboExpression.SelectionStart
    End Sub

    Private Sub cboExpression_TextChanged(sender As Object, e As EventArgs) Handles cboExpression.TextChanged
        OnSelectionChanged()
    End Sub

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        If bWithQuotes Then
            Return Chr(34) & cboExpression.Text & Chr(34)
        Else
            Return cboExpression.Text
        End If
    End Function
End Class
