﻿' R- Instat
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

Imports RDotNet

Public Class ucrReceiverSingle
    Dim strDataFrameName As String
    Public strCurrDataType As String
    Public Event WithMeSelectionChanged(ucrChangedReceiver As ucrReceiverSingle)
    Public bAutoFill As Boolean = False
    'We have not added this to multiple receiver because we have no case yet that we want not to print graph
    Public bPrintGraph As Boolean = True
    'If True variable will be assigned to e.g. DF.x instead of x (where DF is strDataFrameName and x is receiver value)
    'This is useful e.g. to ensure uniqueness when a dialog uses multiple data frames
    Public bIncludeDataFrameInAssignment As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strDataFrameName = ""
        strCurrDataType = ""
    End Sub

    Public Overrides Sub AddSelected()
        'Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As ListViewItem

        If Selector.lstAvailableVariable.SelectedItems.Count = 1 Then
            'Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
            Add(Selector.lstAvailableVariable.SelectedItems.Item(0).Text, Selector.lstAvailableVariable.SelectedItems.Item(0).Tag)
        Else
            'Error?
        End If

    End Sub

    Public Overrides Sub Add(strItem As String, Optional strDataFrame As String = "", Optional bFixReceiver As Boolean = False)
        Dim clsGetDataType As New RFunction
        Dim strCurrentItemType As String
        Dim expColumnType As SymbolicExpression
        Dim bRemove As Boolean = False

        'Would prefer to have remove selected but that will first clear the receiver
        'This has issues when reading RSyntax and filling receivers e.g. in Specific plot dialogs
        'Because it modifies the list of parameters it is looping through when clearing first, crashing
        'Below is the part from RemoveSelected() that is needed
        'This is only an issue with single receiver
        'If RemoveSelected() later contains other things, this may need to be updated.
        'RemoveSelected()
        If Selector IsNot Nothing Then
            Selector.RemoveFromVariablesList(txtReceiverSingle.Text, strDataFrame)
        End If
        MyBase.Add(strItem, strDataFrame)

        If bTypeSet Then
            strCurrentItemType = strType
        Else
            strCurrentItemType = Selector.GetItemType()
        End If
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        If txtReceiverSingle.Enabled Then
            If strCurrentItemType = "column" Then
                If strDataFrame = "" Then
                    SetMeAsReceiver()
                    For i = 0 To Selector.lstAvailableVariable.Items.Count - 1
                        If Selector.lstAvailableVariable.Items(i).Text = strItem Then
                            strDataFrame = Selector.lstAvailableVariable.Items(i).Tag
                        End If
                    Next
                End If
                If strDataFrame <> "" Then
                    clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
                    clsGetDataType.AddParameter("column", Chr(34) & strItem & Chr(34))
                    If ucrSelector IsNot Nothing AndAlso ucrSelector.HasStackedVariables() Then
                        If strItem = "variable" Then
                            strCurrDataType = "factor"
                        ElseIf strItem = "value" Then
                            strCurrDataType = ""
                        Else
                            expColumnType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
                            If expColumnType IsNot Nothing AndAlso expColumnType.Type <> Internals.SymbolicExpressionType.Null Then
                                strCurrDataType = expColumnType.AsCharacter(0)
                            Else
                                strCurrDataType = ""
                                bRemove = True
                            End If
                        End If
                    Else
                        expColumnType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
                        If expColumnType IsNot Nothing AndAlso expColumnType.Type <> Internals.SymbolicExpressionType.Null Then
                            If expColumnType.AsCharacter.Count > 1 Then
                                strCurrDataType = Join(expColumnType.AsCharacter.ToArray, ",")
                            Else
                                strCurrDataType = expColumnType.AsCharacter(0)
                            End If
                        Else
                            strCurrDataType = ""
                            bRemove = True
                        End If
                    End If
                End If
            Else
                strCurrDataType = ""
            End If
            strDataFrameName = strDataFrame
            txtReceiverSingle.Text = strItem
            Selector.AddToVariablesList(strItem, strDataFrameName)
            If bRemove Then
                RemoveSelected()
            End If
            txtReceiverSingle.Enabled = Not bFixReceiver
        End If
    End Sub

    Public Overrides Sub RemoveSelected()
        If txtReceiverSingle.Enabled Then
            If Selector IsNot Nothing Then
                Selector.RemoveFromVariablesList(txtReceiverSingle.Text, strDataFrameName)
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
                    clsGetVariablesFunc.AddParameter("col_names", GetVariableNames())
                    If bForceAsDataFrame Then
                        clsGetVariablesFunc.AddParameter("force_as_data_frame", "TRUE")
                    Else
                        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                            clsGetVariablesFunc.AddParameter("force_as_data_frame", "FALSE")
                        End If
                    End If
                    If bRemoveLabels Then
                        'temp fix to bug in sjPlot needing labels removed for factor columns
                        clsGetVariablesFunc.AddParameter("remove_labels", "TRUE")
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
                    If bDropUnusedFilterLevels Then
                        clsGetVariablesFunc.AddParameter("drop_unused_filter_levels", "TRUE")
                    Else
                        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                            clsGetVariablesFunc.AddParameter("drop_unused_filter_levels", "FALSE")
                        Else
                            clsGetVariablesFunc.RemoveParameterByName("drop_unused_filter_levels")
                        End If
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
                    If Not bPrintGraph Then
                        clsGetVariablesFunc.AddParameter("print_graph", "FALSE")
                    End If
                Case "model"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                    clsGetVariablesFunc.AddParameter("model_name", GetVariableNames())
                Case "dataframe"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                    clsGetVariablesFunc.AddParameter("data_name", GetVariableNames())
                Case "key"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_keys")
                    clsGetVariablesFunc.AddParameter("key_name", GetVariableNames())
                Case "link"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_links")
                    clsGetVariablesFunc.AddParameter("link_name", GetVariableNames())
            End Select

            'TODO make this an option set in Options menu
            If bIncludeDataFrameInAssignment AndAlso strDataFrameName <> "" Then
                clsGetVariablesFunc.SetAssignTo(strDataFrameName & "." & txtReceiverSingle.Text)
            Else
                clsGetVariablesFunc.SetAssignTo(txtReceiverSingle.Text)
            End If
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

    Public Overrides Function GetVariableNameslist(Optional bWithQuotes As Boolean = True, Optional strQuotes As String = Chr(34)) As String()
        Dim arrTemp As String() = Nothing
        arrTemp = {GetVariableNames()}
        Return arrTemp
    End Function

    Public Function GetDataName() As String
        Return strDataFrameName
    End Function

    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged
        OnValueChanged(sender, e)
        OnSelectionChanged()
    End Sub

    'TODO make these global options
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

    Public Sub SetStackedFactorMode(bDisableReceiver As Boolean)
        'This sub is called by ucrVariableAsFactors on dialogs such as BoxPLot, where the ReiceiverSingle, used as factor receiver for the x aesthetics, need to take as fixed value the variable "variable" created to distinguish the variables from the multiple receiver that will have been stacked into one variable called "value".
        If bDisableReceiver Then
            Add("variable", "")
            Me.Enabled = False
            Selector.RemoveFromVariablesList("variable")
        Else
            Me.Enabled = True
            If txtReceiverSingle.Text = "variable" Then
                RemoveSelected()
            End If
        End If
    End Sub

    Private Sub ucrReceiverSingle_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        RaiseEvent WithMeSelectionChanged(Me)
    End Sub

    Private Sub mnuRightClickCopy_Click(sender As Object, e As EventArgs) Handles mnuRightClickCopy.Click
        txtReceiverSingle.Copy()
    End Sub

    Private Sub mnuRightClickRemove_Click(sender As Object, e As EventArgs) Handles mnuRightClickRemove.Click
        RemoveSelected()
    End Sub

    Private Sub Selector_DataFrameChanged() Handles ucrSelector.DataFrameChanged
        CheckAutoFill()
    End Sub

    Public Sub CheckAutoFill()

        'TODO When there are receivers with bAttachedToPrimaryDataFrame = False
        '     don't always want to autofill when dataframe is changed.
        '     Something like AndAlso Selector.CurrentReceiver.bAttachedToPrimaryDataFrame
        '     except always want to autofill when resetting regardless of current receiver
        If bAutoFill AndAlso Selector IsNot Nothing AndAlso (Selector.CurrentReceiver Is Nothing OrElse Selector.CurrentReceiver.bAttachedToPrimaryDataFrame) Then
            SetMeAsReceiver()
            If Selector.lstAvailableVariable.Items.Count = 1 Then
                Add(Selector.lstAvailableVariable.Items(0).Text, Selector.strCurrentDataFrame)
            End If
        End If
    End Sub

    Private Sub ParentForm_Shown()
        If bFirstShown Then
            'This is not needed probably
            'CheckAutoFill()
            bFirstShown = False
        End If
    End Sub

    Protected Overrides Sub Selector_ResetAll()
        MyBase.Selector_ResetAll()
        CheckAutoFill()
    End Sub

    Private Sub ucrReceiverSingle_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            If ParentForm IsNot Nothing Then
                AddHandler ParentForm.Shown, AddressOf ParentForm_Shown
            End If
            bFirstLoad = False
            If Selector IsNot Nothing AndAlso Selector.CurrentReceiver IsNot Nothing AndAlso Not Selector.CurrentReceiver.Equals(Me) Then
                RemoveColor()
            End If
        End If
    End Sub

    Public Overrides Sub SetTextColour(clrNew As Color)
        txtReceiverSingle.ForeColor = clrNew
    End Sub

    Public Overrides Function GetItemsDataFrames() As List(Of String)
        Return New List(Of String)({strDataFrameName})
    End Function
End Class