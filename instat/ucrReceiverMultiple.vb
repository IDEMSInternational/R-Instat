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
    Public iMaxItems As Integer

    Private Sub ucrReceiverMultiple_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            If lstSelectedVariables.Columns.Count = 0 Then
                lstSelectedVariables.Columns.Add("Selected Data")
            End If
            'by default multiple receivers will not be autoswitched on selection change
            bAutoSwitchFromReceiver = False
            bFirstLoad = False
        End If
    End Sub

    Public Overrides Sub AddSelectedSelectorVariables()
        Dim lstItems As New List(Of KeyValuePair(Of String, String))
        For Each lviTemp As ListViewItem In Selector.lstAvailableVariable.SelectedItems
            lstItems.Add(New KeyValuePair(Of String, String)(lviTemp.Tag, lviTemp.Text))
        Next
        AddMultiple(lstItems)
    End Sub

    Public Sub AddMultiple(lstItems As IEnumerable(Of KeyValuePair(Of String, String)))
        Dim lstActualItemsToAdd As New List(Of KeyValuePair(Of String, String))
        'first eliminate all items that already exist
        'this improves perfomance significantly for wide data sets
        For Each kvpTempItem As KeyValuePair(Of String, String) In lstItems
            Dim isMatchFound As Boolean = False
            For Each item As ListViewItem In lstSelectedVariables.Items
                If item.Text.Equals(kvpTempItem.Value, StringComparison.Ordinal) Then
                    isMatchFound = True
                    Exit For
                End If
            Next
            If Not isMatchFound Then
                lstActualItemsToAdd.Add(kvpTempItem)
            End If
        Next
        lstSelectedVariables.Columns(0).Width = -2 ' Auto-resize to fit content

        If lstActualItemsToAdd.Count = 0 Then
            Exit Sub
        End If

        'Then add the new items with limit check
        For Each kvpTempItem As KeyValuePair(Of String, String) In lstActualItemsToAdd
            If iMaxItems <> 0 AndAlso lstSelectedVariables.Items.Count >= iMaxItems Then
                MessageBox.Show($"Cannot add more than {iMaxItems} items.", "Item Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit For ' Exit the loop if the maximum limit is reached
            End If
            lstSelectedVariables.Items.Add(New ListViewItem With {
                    .Name = kvpTempItem.Value,
                    .Text = kvpTempItem.Value,
                    .ToolTipText = kvpTempItem.Value,
                    .Tag = kvpTempItem.Key,
                    .Group = AddGroupName(kvpTempItem.Key)
                })
        Next

        SetGroupHeaderVariablesCount()

        OnSelectionChanged()
    End Sub

    Private Sub lstSelectedVariables_Resize(sender As Object, e As EventArgs) Handles lstSelectedVariables.Resize
        If lstSelectedVariables.Columns.Count > 0 Then
            lstSelectedVariables.Columns(0).Width = lstSelectedVariables.ClientSize.Width
        End If
    End Sub


    'add new group if it exist and return it
    'support of multiple groups assumes that the receiver may have variables from more than one data frame
    'this feature is not yet supported fully
    Private Function AddGroupName(strNewGroupName As String) As ListViewGroup
        For Each grp In lstSelectedVariables.Groups
            If grp.Name = strNewGroupName Then
                Return grp
            End If
        Next
        Dim newGrp As New ListViewGroup(key:=strNewGroupName, headerText:=strNewGroupName)
        lstSelectedVariables.Groups.Add(newGrp)
        Return newGrp
    End Function

    Public Overrides Sub Add(strItem As String, Optional strDataFrame As String = "", Optional bFixreceiver As Boolean = False)
        Dim kvpItems(0) As KeyValuePair(Of String, String)
        If strDataFrame = "" Then
            Dim lvi As ListViewItem = Selector.lstAvailableVariable.FindItemWithText(strItem)
            If lvi IsNot Nothing Then
                strDataFrame = lvi.Tag
            End If
        End If
        kvpItems(0) = New KeyValuePair(Of String, String)(strDataFrame, strItem)
        AddMultiple(kvpItems)

        RemoveAnyVariablesNotInSelector() 'needed due to the Autofill option

        lstSelectedVariables.Enabled = Not bFixreceiver
    End Sub

    Public Overrides Sub RemoveSelected()
        For Each lvi As ListViewItem In lstSelectedVariables.SelectedItems
            lstSelectedVariables.Items.Remove(lvi)
        Next
        SetGroupHeaderVariablesCount()
        OnSelectionChanged()
        MyBase.RemoveSelected()
    End Sub

    Public Overrides Sub Remove(strItems() As String)
        For Each strTempItem In strItems
            lstSelectedVariables.Items.RemoveByKey(strTempItem)
        Next
        SetGroupHeaderVariablesCount()
        OnSelectionChanged()
        MyBase.RemoveSelected()
    End Sub

    Public Overrides Sub Clear()
        'as of 23/08/2023. this block can be called several times. to prevent recursive events just exit sub if already empty
        If lstSelectedVariables.Items.Count = 0 AndAlso lstSelectedVariables.Groups.Count = 0 Then
            Exit Sub
        End If
        lstSelectedVariables.Items.Clear()
        lstSelectedVariables.Groups.Clear()
        OnSelectionChanged()
        MyBase.RemoveSelected()
    End Sub


    ''' <summary>
    ''' Removes any variable in the multiple receiver
    ''' that is not in the list of variables of the selector
    ''' </summary>
    Public Overrides Sub RemoveAnyVariablesNotInSelector()
        Dim lstItemsToRemove As New List(Of ListViewItem)
        For Each lvi As ListViewItem In lstSelectedVariables.Items
            If Selector.lstAvailableVariable.FindItemWithText(lvi.Text) Is Nothing Then
                lstItemsToRemove.Add(lvi)
            End If
        Next

        'as of 23/08/2023. this subroutine can be called several times. to prevent recursive events just exit sub if there is nothing to remove
        If lstItemsToRemove.Count = 0 Then
            Exit Sub
        End If

        For Each lvi As ListViewItem In lstItemsToRemove
            lstSelectedVariables.Items.Remove(lvi)
        Next

        SetGroupHeaderVariablesCount()
        OnSelectionChanged()
        MyBase.RemoveSelected()
    End Sub

    Private Sub SetGroupHeaderVariablesCount()

        If lstSelectedVariables.Groups.Count = 0 Then
            Exit Sub
        End If

        'show count selection at the header of the receiver
        'todo. support this feature for receivers that may have more than 1 data frame later
        'it's not clear when the receiver will ever have more than one data frame

        'reset the header text with the name
        lstSelectedVariables.Groups(0).Header = ShortenString(lstSelectedVariables.Groups(0).Name)
        If lstSelectedVariables.Groups.Count = 1 AndAlso lstSelectedVariables.Items.Count > 0 Then
            lstSelectedVariables.Groups(0).Header = lstSelectedVariables.Groups(0).Header & " (" & lstSelectedVariables.Items.Count & ")"
        End If
    End Sub

    Private Function ShortenString(strText As String) As String
        Dim maxLength As Integer = 10
        If strText.Length > maxLength Then
            ' Trim the string to the specified length and add ellipsis
            Return strText.Substring(0, maxLength) & "..."
        End If
        Return strText
    End Function

    Public Overrides Function IsEmpty() As Boolean
        Return lstSelectedVariables.Items.Count = 0
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
                Case "object",
                     RObjectTypeLabel.Graph,
                     RObjectTypeLabel.Table,
                     RObjectTypeLabel.Model,
                     RObjectTypeLabel.Summary,
                     RObjectTypeLabel.StructureLabel
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_objects_data")
                    clsGetVariablesFunc.AddParameter("object_names", GetVariableNames())
                    clsGetVariablesFunc.AddParameter("as_files", "FALSE")
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

    'todo. this function is used by dlgCombineText dialog only. 
    'after refactoring the dialog, remove it from here.
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
        Dim strTempBuilder As New Text.StringBuilder
        Dim strQuoteHolder As String = If(bWithQuotes, Chr(34), "")

        If lstSelectedVariables.Items.Count = 1 AndAlso Not bForceVariablesAsList Then
            strTempBuilder.Append(strQuoteHolder).Append(lstSelectedVariables.Items(0).Text).Append(strQuoteHolder)
        ElseIf lstSelectedVariables.Items.Count > 1 OrElse bForceVariablesAsList Then
            strTempBuilder.Append(If(strVariablesListPackageName <> "", strVariablesListPackageName & "::", ""))
            strTempBuilder.Append(strVariablesListFunctionName).Append("(")
            For Each lvi As ListViewItem In lstSelectedVariables.Items
                strTempBuilder.Append(strQuoteHolder).Append(lvi.Text).Append(strQuoteHolder).Append(",")
            Next
            strTempBuilder.Length -= 1 'remove last comma
            strTempBuilder.Append(")")
        End If
        Return strTempBuilder.ToString()
    End Function

    Public Overrides Function GetVariableNamesList(Optional bWithQuotes As Boolean = True, Optional strQuotes As String = Chr(34)) As String()
        Dim arrItems(lstSelectedVariables.Items.Count - 1) As String
        Dim strQuoteHolder As String = If(bWithQuotes, strQuotes, "")
        For i = 0 To lstSelectedVariables.Items.Count - 1
            arrItems(i) = strQuoteHolder & lstSelectedVariables.Items(i).Text & strQuoteHolder
        Next
        Return arrItems
    End Function

    Public Function GetVariableNamesAsList() As List(Of String)
        Dim lstItems As New List(Of String)(lstSelectedVariables.Items.Count)
        For Each lvi As ListViewItem In lstSelectedVariables.Items
            lstItems.Add(lvi.Text)
        Next
        Return lstItems
    End Function

    Public Function GetDataFrameNames() As List(Of String)
        Dim strDataFrames As New List(Of String)
        For Each CurrObj As ListViewGroup In lstSelectedVariables.Groups
            strDataFrames.Add(CurrObj.Name)
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
                        If strDataTypes(i).Contains("factor") OrElse strDataTypes(i).Contains("character") OrElse strDataTypes(i).Contains("ordered") Then
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
        Dim strHeaders As New List(Of String)
        Dim grpTemp As ListViewGroup

        For Each grpTemp In lstSelectedVariables.Groups
            strHeaders.Add(grpTemp.Name)
        Next
        Return strHeaders
    End Function

End Class