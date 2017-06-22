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
    Public CurrentReceiver As ucrReceiver
    Public Event ResetAll()
    Public Event ResetReceivers()
    Public Event VariablesInReceiversChanged()
    Public Event DataFrameChanged()
    Public lstVariablesInReceivers As List(Of String)
    Public bFirstLoad As Boolean
    Public bIncludeOverall As Boolean
    Public strCurrentDataFrame As String
    Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Private strType As String
    Private bShowHiddenCols As Boolean = False
    Private WithEvents ucrLinkedSelector As ucrSelector
    Public bIsStacked As Boolean = False
    'Does the selector have its own parameter
    'Usually False as the parameter comes from the data frame selector
    Public bHasOwnParameter As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstVariablesInReceivers = New List(Of String)
        bFirstLoad = True
        bIncludeOverall = False
        strCurrentDataFrame = ""
        lstIncludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        lstExcludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        strType = "column"
    End Sub

    Private Sub ucrSelection_load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            bFirstLoad = False
        End If
        LoadList()
    End Sub

    Protected Sub OnResetAll()
        RaiseEvent ResetAll()
    End Sub

    Protected Sub OnResetReceivers()
        RaiseEvent ResetReceivers()
    End Sub

    Protected Sub OnDataFrameChanged()
        RaiseEvent DataFrameChanged()
    End Sub

    Public Overridable Sub LoadList()
        Dim lstCombinedMetadataLists As List(Of List(Of KeyValuePair(Of String, String())))
        Dim strExclud As String() = Nothing

        If CurrentReceiver IsNot Nothing Then
            lstCombinedMetadataLists = CombineMetadataLists(CurrentReceiver.lstIncludedMetadataProperties, CurrentReceiver.lstExcludedMetadataProperties)
            If CurrentReceiver.bExcludeFromSelector Then
                strExclud = lstVariablesInReceivers.ToArray
            End If
            If CurrentReceiver.bTypeSet Then
                frmMain.clsRLink.FillListView(lstAvailableVariable, strType:=CurrentReceiver.GetItemType(), lstIncludedDataTypes:=lstCombinedMetadataLists(0), lstExcludedDataTypes:=lstCombinedMetadataLists(1), strHeading:=CurrentReceiver.strSelectorHeading, strDataFrameName:=strCurrentDataFrame, strExcludedItems:=strExclud, strDatabaseQuery:=CurrentReceiver.strDatabaseQuery, strNcFilePath:=CurrentReceiver.strNcFilePath)
            Else
                frmMain.clsRLink.FillListView(lstAvailableVariable, strType:=strType, lstIncludedDataTypes:=lstCombinedMetadataLists(0), lstExcludedDataTypes:=lstCombinedMetadataLists(1), strHeading:=CurrentReceiver.strSelectorHeading, strDataFrameName:=strCurrentDataFrame, strExcludedItems:=strExclud, strDatabaseQuery:=CurrentReceiver.strDatabaseQuery, strNcFilePath:=CurrentReceiver.strNcFilePath)
            End If
            'Removed as probably don't need to load when no current receiver
            'Else
            'frmMain.clsRLink.FillListView(lstAvailableVariable, strType:=strType, lstIncludedDataTypes:=lstIncludedMetadataProperties, lstExcludedDataTypes:=lstExcludedMetadataProperties, strDataFrameName:=strCurrentDataFrame)
        End If
    End Sub

    Public Overridable Sub Reset()
        RaiseEvent ResetReceivers()
        lstVariablesInReceivers.Clear()
        LoadList()
        'lstItemsInReceivers.Clear()
    End Sub

    Public Overridable Sub SetIncludeOverall(bInclude As Boolean)
        bIncludeOverall = bInclude
        LoadList()
    End Sub

    Public Sub SetCurrentReceiver(conReceiver As ucrReceiver)
        If CurrentReceiver IsNot Nothing Then
            CurrentReceiver.RemoveColor()
        End If
        If conReceiver IsNot Nothing Then
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
        Else
            CurrentReceiver = Nothing
        End If
    End Sub

    Public Sub AddAll()
        If CurrentReceiver IsNot Nothing Then
            SelectAll()
            Add()
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

    Public Sub ShowDataOptionsDialog()
        sdgDataOptions.ShowDialog()
        SetDataOptionsSettings()
    End Sub

    Public Overridable Sub SetDataOptionsSettings()
        bShowHiddenColumns = sdgDataOptions.ShowHiddenColumns()
        LoadList()
    End Sub

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs) Handles lstAvailableVariable.DoubleClick
        Add()
    End Sub

    Private Sub lstAvailableVariable_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lstAvailableVariable.KeyPress
        If e.KeyChar = vbCr Then
            Add()
        End If
        If lstAvailableVariable.SelectedItems.Count > 0 Then
            If Keys.ControlKey AndAlso Keys.A Then
                SelectAll()
            End If
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
        SelectAll()
    End Sub

    Public Sub SetLinkedSelector(ucrNewLinkedSelector As ucrSelector)
        ucrLinkedSelector = ucrNewLinkedSelector
    End Sub

    Public Sub AddToVariablesList(strVariable As String, Optional strDataFrame As String = "")
        If strDataFrame = "" OrElse strDataFrame = strCurrentDataFrame Then
            lstVariablesInReceivers.Add(strVariable)
            If ucrLinkedSelector IsNot Nothing Then
                ucrLinkedSelector.AddToVariablesList(strVariable, strCurrentDataFrame)
            End If
            RaiseEvent VariablesInReceiversChanged()
        End If
    End Sub

    Public Sub RemoveFromVariablesList(strVariable As String, Optional strDataFrame As String = "")
        If strDataFrame = "" OrElse strDataFrame = strCurrentDataFrame Then
            lstVariablesInReceivers.Remove(strVariable)
            If ucrLinkedSelector IsNot Nothing Then
                ucrLinkedSelector.RemoveFromVariablesList(strVariable, strCurrentDataFrame)
            End If
            RaiseEvent VariablesInReceiversChanged()
        End If
    End Sub

    Public Sub AddIncludedMetadataProperty(strProperty As String, strInclude As String())
        Dim iIncludeIndex As Integer
        'Dim iExcludeIndex As Integer
        Dim kvpIncludeProperty As KeyValuePair(Of String, String())

        kvpIncludeProperty = New KeyValuePair(Of String, String())(strProperty, strInclude)
        iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstIncludedMetadataProperties(iIncludeIndex) = kvpIncludeProperty
        Else
            lstIncludedMetadataProperties.Add(kvpIncludeProperty)
        End If

        'Removes from other list
        'iExcludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        'If iExcludeIndex <> -1 Then
        '    lstExcludedMetadataProperties.RemoveAt(iExcludeIndex)
        'End If

        LoadList()

    End Sub

    Public Sub AddExcludedMetadataProperty(strProperty As String, strExclude As String())
        'Dim iIncludeIndex As Integer
        Dim iExcludeIndex As Integer

        Dim kvpExcludeProperty As KeyValuePair(Of String, String())

        kvpExcludeProperty = New KeyValuePair(Of String, String())(strProperty, strExclude)
        iExcludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iExcludeIndex <> -1 Then
            lstExcludedMetadataProperties(iExcludeIndex) = kvpExcludeProperty
        Else
            lstExcludedMetadataProperties.Add(kvpExcludeProperty)
        End If

        'Removes from other list
        'iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        'If iIncludeIndex <> -1 Then
        '    lstIncludedMetadataProperties.RemoveAt(iIncludeIndex)
        'End If

        LoadList()
    End Sub

    Private Function CombineMetadataLists(lstMajorInclude As List(Of KeyValuePair(Of String, String())), lstMajorExclude As List(Of KeyValuePair(Of String, String()))) As List(Of List(Of KeyValuePair(Of String, String())))
        Dim kvpInclude As KeyValuePair(Of String, String())
        Dim kvpExclude As KeyValuePair(Of String, String())
        Dim lstCombinedIncluded As List(Of KeyValuePair(Of String, String()))
        Dim lstCombinedExcluded As List(Of KeyValuePair(Of String, String()))

        lstCombinedIncluded = New List(Of KeyValuePair(Of String, String()))(lstMajorInclude)
        lstCombinedExcluded = New List(Of KeyValuePair(Of String, String()))(lstMajorExclude)
        For Each kvpInclude In lstIncludedMetadataProperties
            If lstCombinedIncluded.FindIndex(Function(x) x.Key = kvpInclude.Key) = -1 AndAlso lstCombinedExcluded.FindIndex(Function(x) x.Key = kvpInclude.Key) = -1 Then
                lstCombinedIncluded.Add(kvpInclude)
            End If
        Next

        For Each kvpExclude In lstExcludedMetadataProperties
            If lstCombinedIncluded.FindIndex(Function(x) x.Key = kvpExclude.Key) = -1 AndAlso lstCombinedExcluded.FindIndex(Function(x) x.Key = kvpExclude.Key) = -1 Then
                lstCombinedExcluded.Add(kvpExclude)
            End If
        Next

        Return New List(Of List(Of KeyValuePair(Of String, String())))({lstCombinedIncluded, lstCombinedExcluded})
    End Function

    Public Sub SetItemType(strNewType As String)
        strType = strNewType
        LoadList()
    End Sub

    Public Function GetItemType() As String
        Return strType
    End Function

    Public Property bShowHiddenColumns As Boolean
        Get
            Return bShowHiddenCols
        End Get
        Set(bShowHidden As Boolean)
            Dim iHiddenIndex As Integer
            bShowHiddenCols = bShowHidden
            If Not bShowHiddenCols Then
                AddExcludedMetadataProperty("Is_Hidden", {"TRUE"})
            Else
                iHiddenIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = "Is_Hidden")
                If iHiddenIndex <> -1 Then
                    lstExcludedMetadataProperties.RemoveAt(iHiddenIndex)
                End If
            End If
            'temp disabled as causing crash
            'sdgDataOptions.ShowHiddenColumns = bShowHiddenCols
        End Set
    End Property

    Public Function ContainsVariable(strVar As String) As Boolean
        Dim lviItem As ListViewItem
        For Each lviItem In lstAvailableVariable.Items
            If lviItem.Text = strVar Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub AddAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAllToolStripMenuItem.Click
        AddAll()
    End Sub

    Private Sub SelectAll()
        Dim lviTemp As ListViewItem
        lstAvailableVariable.BeginUpdate()
        For Each lviTemp In lstAvailableVariable.Items
            lviTemp.Selected = True
        Next
        lstAvailableVariable.EndUpdate()
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        If bHasOwnParameter Then
            MyBase.UpdateControl(bReset:=bReset, bCloneIfNeeded:=bCloneIfNeeded)
        End If
    End Sub

    Private Sub SelectionMenuStrip_VisibleChanged(sender As Object, e As EventArgs) Handles SelectionMenuStrip.VisibleChanged
        If SelectionMenuStrip.Visible Then
            If CurrentReceiver IsNot Nothing Then
                AddSelectedToolStripMenuItem.Enabled = True
                If TypeOf CurrentReceiver Is ucrReceiverSingle Then
                    AddAllToolStripMenuItem.Enabled = False
                    SelectAllToolStripMenuItem.Enabled = False
                ElseIf TypeOf CurrentReceiver Is ucrReceiverMultiple Then
                    AddAllToolStripMenuItem.Enabled = True
                    SelectAllToolStripMenuItem.Enabled = True
                Else
                    MsgBox("Current receiver is neither ucrReceiverSingle or ucrReceiverMultiple. Cannot determine visibility of menu items.")
                End If
            Else
                AddSelectedToolStripMenuItem.Enabled = False
                AddAllToolStripMenuItem.Enabled = False
                SelectAllToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Public Function HasStackedVariables() As Boolean
        Return bIsStacked OrElse (ucrLinkedSelector IsNot Nothing AndAlso ucrLinkedSelector.bIsStacked)
    End Function
End Class