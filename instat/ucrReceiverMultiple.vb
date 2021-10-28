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

Imports RDotNet

Public Class ucrReceiverMultiple

    Public bSingleType As Boolean = False
    ' If bSingleType and bCategoricalNumeric then categorical and numeric are the only considered types
    Public bCategoricalNumeric As Boolean = False

    Private Sub ucrReceiverMultiple_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            If lstSelectedVariables.Columns.Count = 0 Then
                lstSelectedVariables.Columns.Add("Selected Data")
                lstSelectedVariables.Columns(0).Width = lstSelectedVariables.Width - 25
            End If
            'by default multiple receivers will not be autoswitched on selection change
            bAutoSwitchFromReceiver = False
            bFirstLoad = False
        End If
    End Sub

    Public Overrides Sub AddSelected()
        Dim lstItems(Selector.lstAvailableVariable.SelectedItems.Count - 1) As KeyValuePair(Of String, String)
        Dim lviTemp As ListViewItem
        Dim i As Integer = 0

        For Each lviTemp In Selector.lstAvailableVariable.SelectedItems
            lstItems(i) = New KeyValuePair(Of String, String)(lviTemp.Tag, lviTemp.Text)
            i = i + 1
        Next
        AddMultiple(lstItems)
    End Sub

    Private Function GetCurrItemNames() As List(Of String)
        Dim strItemNames As New List(Of String)
        Dim currItem As ListViewItem

        For Each currItem In lstSelectedVariables.Items
            strItemNames.Add(currItem.Text)
        Next
        Return strItemNames
    End Function

    Private Function GetCurrGroupNames() As List(Of String)
        Dim strHeaders As New List(Of String)
        Dim grpTemp As ListViewGroup

        For Each grpTemp In lstSelectedVariables.Groups
            strHeaders.Add(grpTemp.Name)
        Next
        Return strHeaders
    End Function

    Public Overrides Sub RemoveSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(lstSelectedVariables.SelectedItems.Count - 1) As Object

        If lstSelectedVariables.SelectedItems.Count > 0 Then
            lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                lstSelectedVariables.Items.Remove(objItem)
                Selector.RemoveFromVariablesList(objItem.Text, objItem.Tag)
            Next
        End If
        OnSelectionChanged()
        MyBase.RemoveSelected()
    End Sub

    Public Overrides Sub Remove(strItems() As String)
        MyBase.Remove(strItems)
        Dim strTempItem As String

        If strItems.Count > 0 Then
            For Each strTempItem In strItems
                lstSelectedVariables.Items.RemoveByKey(strTempItem)
                'TODO pass data frame for variables
                Selector.RemoveFromVariablesList(strTempItem)
            Next
            OnSelectionChanged()
            MyBase.RemoveSelected()
        End If
    End Sub

    Public Overrides Sub Clear()
        Dim lviVar As ListViewItem
        Dim strItems As New List(Of String)

        For Each lviVar In lstSelectedVariables.Items
            strItems.Add(lviVar.Text)
        Next
        Remove(strItems.ToArray())
    End Sub

    Public Overrides Function IsEmpty() As Boolean

        If lstSelectedVariables.Items.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function Count() As Integer
        Return lstSelectedVariables.Items.Count
    End Function

    Public Overrides Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        'TODO sort this out
        Dim clsGetVariablesFunc As New RFunction
        Dim lstCurrDataFrames As List(Of String)
        Dim strCurrDataFrame As String
        Dim strCurrentType As String
        lstCurrDataFrames = GetDataFrameNames()

        If lstCurrDataFrames.Count = 1 Then
            strCurrDataFrame = lstCurrDataFrames(0)
            clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34))
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
                Case "surv"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_surv")
                    clsGetVariablesFunc.AddParameter("surv_name", GetVariableNames())
                Case "model"
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                    clsGetVariablesFunc.AddParameter("model_name", GetVariableNames())
                    If bForceVariablesAsList Then
                        clsGetVariablesFunc.AddParameter("force_as_list", "TRUE", iPosition:=3)
                    Else
                        clsGetVariablesFunc.RemoveParameterByName("force_as_list")
                    End If
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
            'clsRSyntax.SetAssignTo(MakeValidRString(strCurrDataFrame) & "_temp", clsFunction:=clsGetVariablesFunc)
        End If
        Return clsGetVariablesFunc
    End Function

    Public Function GetVariablesAsList() As List(Of RFunction)
        Dim lstColumnFunctions As New List(Of RFunction)
        Dim strColumn As String
        Dim clsColumnFunction As RFunction
        Dim strCurrDataFrame As String
        Dim lstCurrDataFrames As List(Of String)

        lstCurrDataFrames = GetDataFrameNames()
        If lstCurrDataFrames.Count = 1 Then
            strCurrDataFrame = lstCurrDataFrames(0)
            For i = 0 To lstSelectedVariables.Items.Count - 1
                clsColumnFunction = New RFunction
                strColumn = lstSelectedVariables.Items(i).Text
                clsColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsColumnFunction.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34))
                clsColumnFunction.AddParameter("col_names", Chr(34) & strColumn & Chr(34))
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsColumnFunction.AddParameter("force_as_data_frame", "FALSE")
                End If
                If Not bUseFilteredData Then
                    clsColumnFunction.AddParameter("use_current_filter", "FALSE")
                End If
                lstColumnFunctions.Add(clsColumnFunction)
            Next
        End If
        Return lstColumnFunctions
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstSelectedVariables.Items.Count = 1 AndAlso Not bForceVariablesAsList Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstSelectedVariables.Items(0).Text & Chr(34)
            Else
                strTemp = lstSelectedVariables.Items(0).Text
            End If
        ElseIf lstSelectedVariables.Items.Count > 1 OrElse bForceVariablesAsList Then
            If strVariablesListPackageName <> "" Then
                strTemp = strVariablesListPackageName & "::"
            End If
            strTemp = strTemp & strVariablesListFunctionName & "("
            For i = 0 To lstSelectedVariables.Items.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstSelectedVariables.Items(i).Text <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstSelectedVariables.Items(i).Text & Chr(34)
                    Else
                        strTemp = strTemp & lstSelectedVariables.Items(i).Text
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If

        Return strTemp
    End Function

    Public Overrides Function GetVariableNamesList(Optional bWithQuotes As Boolean = True, Optional strQuotes As String = Chr(34)) As String()
        Dim lstItems As String()

        ReDim lstItems(0 To lstSelectedVariables.Items.Count - 1)
        For i = 0 To lstSelectedVariables.Items.Count - 1
            If bWithQuotes Then
                lstItems(i) = strQuotes & lstSelectedVariables.Items(i).Text & strQuotes
            Else
                lstItems(i) = lstSelectedVariables.Items(i).Text
            End If
        Next
        Return lstItems
    End Function

    Public Function GetVariableNamesAsList() As List(Of String)
        Dim lstItems As New List(Of String)

        For i = 0 To lstSelectedVariables.Items.Count - 1
            lstItems.Add(lstSelectedVariables.Items(i).Text)
        Next
        Return lstItems
    End Function

    Public Function GetDataFrameNames() As List(Of String)
        Dim strDataFrames As New List(Of String)
        Dim CurrObj As ListViewItem

        For Each CurrObj In lstSelectedVariables.Items
            If Not strDataFrames.Contains(CurrObj.Group.Header) Then
                strDataFrames.Add(CurrObj.Group.Header)
            End If
        Next

        Return strDataFrames
    End Function

    Public Overrides Sub SetColor()
        lstSelectedVariables.BackColor = Color.Aqua
    End Sub

    Public Overrides Sub RemoveColor()
        lstSelectedVariables.BackColor = Color.White
    End Sub

    Private Sub lstSelectedVariables_KeyDown(sender As Object, e As KeyEventArgs) Handles lstSelectedVariables.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            RemoveSelected()
        End If
    End Sub

    Private Sub lstSelectedVariables_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstSelectedVariables.MouseDoubleClick
        RemoveSelected()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveSelected()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Public Function GetCount() As Integer
        If lstSelectedVariables IsNot Nothing Then
            Return lstSelectedVariables.Items.Count
        Else
            Return 0
        End If
    End Function

    Public Sub AddMultiple(lstItems As KeyValuePair(Of String, String)())
        Dim kvpTempItem As KeyValuePair(Of String, String)
        Dim grpCurr As New ListViewGroup

        For Each kvpTempItem In lstItems
            If Not GetCurrItemNames().Contains(kvpTempItem.Value) Then
                If Not GetCurrGroupNames().Contains(kvpTempItem.Key) Then
                    grpCurr = New ListViewGroup(key:=kvpTempItem.Key, headerText:=kvpTempItem.Key)
                    lstSelectedVariables.Groups.Add(grpCurr)
                Else
                    grpCurr = lstSelectedVariables.Groups(GetCurrGroupNames().IndexOf(kvpTempItem.Key))
                End If
                lstSelectedVariables.Items.Add(kvpTempItem.Value).Group = grpCurr
                lstSelectedVariables.Items(lstSelectedVariables.Items.Count - 1).Tag = kvpTempItem.Key
                lstSelectedVariables.Items(lstSelectedVariables.Items.Count - 1).Name = kvpTempItem.Value
                lstSelectedVariables.Items(lstSelectedVariables.Items.Count - 1).ToolTipText = kvpTempItem.Value
                Selector.AddToVariablesList(kvpTempItem.Value, kvpTempItem.Key)
            End If
        Next
        OnSelectionChanged()
    End Sub

    Public Overrides Sub Add(strItem As String, Optional strDataFrame As String = "", Optional bFixreceiver As Boolean = False)
        Dim kvpItems(0) As KeyValuePair(Of String, String)
        If strDataFrame = "" Then
            For i = 0 To Selector.lstAvailableVariable.Items.Count - 1
                If Selector.lstAvailableVariable.Items(i).Text = strItem Then
                    strDataFrame = Selector.lstAvailableVariable.Items(i).Tag
                End If
            Next
        End If
        kvpItems(0) = New KeyValuePair(Of String, String)(strDataFrame, strItem)
        AddMultiple(kvpItems)

        lstSelectedVariables.Enabled = Not bFixreceiver
    End Sub

    Public Function GetCurrentItemTypes(Optional bUnique As Boolean = False, Optional bIsCategoricalNumeric As Boolean = False) As List(Of String)
        Dim clsGetDataType As New RFunction
        Dim strDataTypes As New List(Of String)
        Dim strDataFrame As String
        Dim strCurrentType As String
        Dim expTypes As SymbolicExpression

        If Selector IsNot Nothing Then
            If bTypeSet Then
                strCurrentType = strType
            Else
                strCurrentType = Selector.GetItemType()
            End If

            If strCurrentType = "column" AndAlso GetDataFrameNames().Count = 1 Then
                strDataFrame = GetDataFrameNames()(0)
                clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
                clsGetDataType.AddParameter("property", "data_type_label")
                clsGetDataType.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
                clsGetDataType.AddParameter("column", GetVariableNames())
                expTypes = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript(), bSilent:=True)
                If expTypes IsNot Nothing AndAlso expTypes.Type <> Internals.SymbolicExpressionType.Null Then
                    strDataTypes = expTypes.AsCharacter.ToList()
                End If
                If strDataTypes.Count = 2 AndAlso strDataTypes.Contains("ordered") AndAlso strDataTypes.Contains("factor") Then
                    strDataTypes = {"factor"}.ToList
                End If
                If bIsCategoricalNumeric Then
                    ' logical can be considered as both categorical or numeric so should be dealt with on individual dialogs
                    For i As Integer = 0 To strDataTypes.Count - 1
                        If strDataTypes(i).Contains("factor") OrElse strDataTypes(i).Contains("character") Then
                            strDataTypes(i) = "categorical"
                        ElseIf Not strDataTypes(i).Contains("logical") Then
                            strDataTypes(i) = "numeric"
                        End If
                    Next
                End If
                If bUnique Then
                    strDataTypes = strDataTypes.Distinct().ToList()
                End If
            End If
        End If
        Return strDataTypes
    End Function

    Public Function IsSingleType() As Boolean
        Return GetCurrentItemTypes(True).Count = 1
    End Function

    Public Function IsAllNumeric() As Boolean
        Dim lstUniqueTypes As List(Of String)
        Dim i As Integer

        lstUniqueTypes = GetCurrentItemTypes(True)
        For i = 0 To lstUniqueTypes.Count - 1
            If lstUniqueTypes(i) = "integer" Then
                lstUniqueTypes(i) = "numeric"
            End If
        Next
        lstUniqueTypes = lstUniqueTypes.Distinct.ToList()
        Return lstUniqueTypes.Count = 1
    End Function

    ' Categorical is defined as everything that isnt numeric
    ' This may change as more types are added
    Public Function IsAllCategorical() As Boolean
        Dim lstUniqueTypes As List(Of String)
        Dim i As Integer
        Dim bAllCat As Boolean

        bAllCat = True
        lstUniqueTypes = GetCurrentItemTypes(True)
        For i = 0 To lstUniqueTypes.Count - 1
            If lstUniqueTypes(i) = "integer" OrElse lstUniqueTypes(i) = "numeric" Then
                bAllCat = False
                Exit For
            End If
        Next
        Return bAllCat
    End Function

    Public Sub CheckSingleType()
        Dim strVariableTypes As List(Of String)

        If bSingleType Then
            If (Not IsEmpty()) Then
                strVariableTypes = GetCurrentItemTypes(True, bCategoricalNumeric)
                If strVariableTypes.Count > 1 AndAlso Not (strVariableTypes.Count = 2 AndAlso strVariableTypes.Contains("numeric") AndAlso strVariableTypes.Contains("integer")) AndAlso Not (strVariableTypes.Count = 2 AndAlso strVariableTypes.Contains("factor") AndAlso strVariableTypes.Contains("ordered,factor")) AndAlso Not (bCategoricalNumeric AndAlso strVariableTypes.Count = 2 AndAlso strVariableTypes.Contains("logical")) Then
                    MsgBox("Cannot add these variables. All variables must be of the same data type.", MsgBoxStyle.OkOnly, "Cannot add variables.")
                    Clear()
                    SetSelectorHeading("Variables")
                ElseIf strVariableTypes.Count > 0 Then
                    If bCategoricalNumeric Then
                        If strVariableTypes.Contains("categorical") Then
                            SetIncludedDataTypes({"factor", "character", "logical"}, bStrict:=True)
                            SetSelectorHeading("Categorical Variables")
                        ElseIf strVariableTypes.Contains("numeric") Then
                            SetExcludedDataTypes({"factor", "character"})
                            SetSelectorHeading("Numerics")
                        Else
                            ' Else it is logical only
                            RemoveIncludedMetadataProperty(strProperty:="class")
                            RemoveExcludedMetadataProperty(strProperty:="class")
                            SetSelectorHeading("Variables")
                        End If
                    Else
                        If strVariableTypes(0) = "integer" OrElse strVariableTypes(0) = "numeric" Then
                            SetDataType("numeric", bStrict:=True)
                            SetSelectorHeading("Numerics")
                        ElseIf strVariableTypes(0) = "ordered,factor" OrElse strVariableTypes(0) = "factor" Then
                            SetDataType("factor", bStrict:=True)
                            SetSelectorHeading("Factors")
                        Else
                            SetDataType(strVariableTypes(0), bStrict:=True)
                            SetSelectorHeading(strVariableTypes(0) & " Variables")
                        End If
                    End If
                Else
                    RemoveIncludedMetadataProperty(strProperty:="class")
                    RemoveExcludedMetadataProperty(strProperty:="class")
                    SetSelectorHeading("Variables")
                End If
            Else
                RemoveIncludedMetadataProperty(strProperty:="class")
                RemoveExcludedMetadataProperty(strProperty:="class")
                SetSelectorHeading("Variables")
            End If
        End If
    End Sub

    Public Sub SetSingleTypeStatus(bIsSingleType As Boolean, Optional bIsCategoricalNumeric As Boolean = False)
        bSingleType = bIsSingleType
        bCategoricalNumeric = bIsCategoricalNumeric
        CheckSingleType()
    End Sub

    Private Sub ucrReceiverMultiple_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        CheckSingleType()
    End Sub

    Public Overrides Function GetItemsDataFrames() As List(Of String)
        Return GetCurrGroupNames()
    End Function
End Class