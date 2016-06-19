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

Public Class ucrReceiverSingle
    Dim strDataFrameName As String
    Public strCurrDataType As String
    Public Event WithMeSelectionChanged(ucrChangedReceiver As ucrReceiverSingle)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strDataFrameName = ""
        strCurrDataType = ""
    End Sub

    Public Overrides Sub AddSelected()
        Dim objItem As ListViewItem
        Dim clsGetDataType As New RFunction
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As ListViewItem
        Dim strCurrentItemType As String

        If bTypeSet Then
            strCurrentItemType = strType
        Else
            strCurrentItemType = Selector.GetItemType()
        End If
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        If txtReceiverSingle.Enabled Then
            Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                If strCurrentItemType = "column" Then
                    clsGetDataType.AddParameter("data_name", Chr(34) & objItem.Tag & Chr(34))
                    clsGetDataType.AddParameter("column", Chr(34) & objItem.Text & Chr(34))
                    strCurrDataType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter(0)
                Else
                    strCurrDataType = ""
                End If
                SetSelected(objItem.Text, objItem.Tag)
            Next
        End If
    End Sub

    Public Sub SetSelected(strColumn As String, strDataFrame As String)
        strDataFrameName = strDataFrame
        txtReceiverSingle.Text = strColumn
        Selector.AddToVariablesList(strColumn)
    End Sub

    Public Overrides Sub RemoveSelected()
        If txtReceiverSingle.Enabled Then
            If Selector IsNot Nothing Then
                Selector.RemoveFromVariablesList(txtReceiverSingle.Text)
            End If
            txtReceiverSingle.Text = ""
            strDataFrameName = ""
        End If
        MyBase.RemoveSelected()
    End Sub

    Public Overrides Sub Clear()
        RemoveSelected()
    End Sub

    Public Overrides Function IsEmpty() As Boolean

        If txtReceiverSingle.Text <> "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Overrides Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        'return columns (in data frame) in both cases
        'call GetVariableNames
        Dim clsGetVariablesFunc As New RFunction
        Dim clsParam As New RParameter
        Dim strCurrentType As String
        If Selector IsNot Nothing AndAlso txtReceiverSingle.Text <> "" Then
            clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            If bTypeSet Then
                strCurrentType = strType
            Else
                strCurrentType = Selector.GetItemType()
            End If
            Select Case strCurrentType
                Case "column"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                    clsGetVariablesFunc.AddParameter("col_name", GetVariableNames())
                    If bForceAsDataFrame Then
                        clsGetVariablesFunc.AddParameter("force_as_data_frame", "TRUE")
                    Else
                        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                            clsGetVariablesFunc.AddParameter("force_as_data_frame", "FALSE")
                        End If
                    End If
                    If bUseFilteredData Then
                        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                            clsGetVariablesFunc.AddParameter("use_current_filter", "TRUE")
                        Else
                            clsGetVariablesFunc.RemoveParameterByName("use_current_filter")
                        End If
                    Else
                        clsGetVariablesFunc.AddParameter("use_current_filter", "FALSE")
                    End If
                Case "filter"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_filter")
                    clsGetVariablesFunc.AddParameter("filter_name", GetVariableNames())
                Case "object"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects")
                    clsGetVariablesFunc.AddParameter("object_name", GetVariableNames())
                Case "graph"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
                    clsGetVariablesFunc.AddParameter("graph_name", GetVariableNames())
                Case "model"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                    clsGetVariablesFunc.AddParameter("model_name", GetVariableNames())
            End Select

            'TODO make this an option set in Options menu
            clsGetVariablesFunc.SetAssignTo(txtReceiverSingle.Text)
            Return clsGetVariablesFunc
        Else
            Return clsGetVariablesFunc
        End If
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        If txtReceiverSingle.Text <> "" Then
            If bWithQuotes Then
                strTemp = Chr(34) & txtReceiverSingle.Text & Chr(34)
            Else
                strTemp = txtReceiverSingle.Text
            End If
        End If
        Return strTemp
    End Function

    Public Overrides Function GetVariableNameslist(Optional bWithQuotes As Boolean = True) As String()
        Dim arrTemp As String() = Nothing
        arrTemp = {GetVariableNames()}
        Return arrTemp
    End Function

    Public Function GetDataName() As String
        Return strDataFrameName
    End Function

    Public Event SelectionChanged(sender As Object, e As EventArgs)



    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged
        OnValueChanged(sender, e)
        RaiseEvent SelectionChanged(sender, e)
    End Sub

    Public Overrides Sub SetColor()
        txtReceiverSingle.BackColor = Color.Aqua
    End Sub

    Public Overrides Sub RemoveColor()
        txtReceiverSingle.BackColor = Color.White
    End Sub

    Private Sub txtReceiverSingle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReceiverSingle.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            RemoveSelected()
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveSelected()
    End Sub

    Public Sub SetStackedFactorMode(bDisableReceiver As Boolean)
        If bDisableReceiver Then
            SetSelected("variable", "")
            Me.Enabled = False
            Selector.RemoveFromVariablesList("variable")
        Else
            Me.Enabled = True
            RemoveSelected()
        End If
    End Sub

    Private Sub ucrReceiverSingle_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        RaiseEvent WithMeSelectionChanged(Me)
    End Sub
End Class