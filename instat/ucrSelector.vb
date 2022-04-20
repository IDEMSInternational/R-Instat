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
Imports instat.Translations
Public Class ucrSelector
    Public CurrentReceiver As ucrReceiver
    Public Event ResetAll()
    Public Event ResetReceivers()
    Public Event VariablesInReceiversChanged()
    Public Event DataFrameChanged()
    Public lstVariablesInReceivers As List(Of Tuple(Of String, String))
    Public bFirstLoad As Boolean
    Public bIncludeOverall As Boolean
    Public strCurrentDataFrame As String
    ' If a dialog has receivers which can have columns from multiple data frames
    ' there may be a primary data frame which some receivers must be from.
    ' Other receivers may only allow columns from data frames linked to the primary data frame
    Public strPrimaryDataFrame As String
    Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Private strType As String
    Private bShowHiddenCols As Boolean = False
    Private WithEvents ucrLinkedSelector As ucrSelector
    Public bIsStacked As Boolean = False
    'Does the selector have its own parameter
    'Usually False as the parameter comes from the data frame selector
    Public bHasOwnParameter As Boolean = False
    Private clsGgplotOperator As ROperator = Nothing

    Protected bSilentDataFrameChange As Boolean = False

    '''<summary> The list of receivers listening to this selector. 
    '''          The receivers are ordered by tab index. This list is used to automatically switch 
    '''          focus to the next receiver whenever this selector changes selection.
    '''</summary>
    Private lstOrderedReceivers As New List(Of ucrReceiver)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstVariablesInReceivers = New List(Of Tuple(Of String, String))
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
    End Sub

    Protected Sub OnResetAll()
        RaiseEvent ResetAll()
    End Sub

    Protected Sub OnResetReceivers()
        RaiseEvent ResetReceivers()
    End Sub

    Protected Sub OnDataFrameChanged()
        Dim ucrPreviousCurrentReceiver As ucrReceiver

        If bSilentDataFrameChange Then
            bSilentDataFrameChange = False
        Else
            ucrPreviousCurrentReceiver = CurrentReceiver
            RaiseEvent DataFrameChanged()
            If ucrPreviousCurrentReceiver IsNot Nothing Then
                ucrPreviousCurrentReceiver.SetMeAsReceiver()
            End If
            If CurrentReceiver IsNot Nothing AndAlso CurrentReceiver.bAttachedToPrimaryDataFrame Then
                ClearGgplotOptions()
            End If
        End If
    End Sub

    Protected Sub ClearGgplotOptions()
        If clsGgplotOperator IsNot Nothing Then
            clsGgplotOperator.RemoveParameterByName("facets")
        End If
    End Sub

    Public Overridable Sub EnableDataOptions(strCurrentType As String)

    End Sub

    Public Overridable Sub LoadList()
        Dim lstCombinedMetadataLists As List(Of List(Of KeyValuePair(Of String, String())))
        Dim arrStrExclud As String() = Nothing
        Dim strCurrentType As String
        Dim strNewSelectorFillCondition As String

        'no need to load elements if receiver is nothing
        If CurrentReceiver Is Nothing Then
            Exit Sub
        End If

        lstCombinedMetadataLists = CombineMetadataLists(CurrentReceiver.lstIncludedMetadataProperties, CurrentReceiver.lstExcludedMetadataProperties)
        If CurrentReceiver.bExcludeFromSelector Then
            arrStrExclud = GetVariablesInReceiver().ToArray
        End If

        'set the type of 'elements' to show. If current receiver is set to a particular 'element' type then use it  
        strCurrentType = If(CurrentReceiver.bTypeSet, CurrentReceiver.GetItemType(), strType)

        'holds the selector's list view 'fill conditions'
        'used as a 'cache' to check if there is need to clear and refill list view based on supplied parameters
        Static _strCurrentSelectorFillCondition As String = ""

        'check if the fill condition is the same, if it is then no need to refill the listview with the same data.
        'LoadList is called several times by different events raised in different places(e.g by linked receivers clearing and setting their contents ).
        'this makes refilling of the listview unnecessarily slow, especially for wide data sets (see comments in issue #7162)
        'long term fix is to find out how the repeated calls to LoadList() can be omitted
        strNewSelectorFillCondition = GetSelectorFillCondition(lstAvailableVariable.Items.Count, strElementType:=strCurrentType, lstCombinedMetadataLists:=lstCombinedMetadataLists, strHeading:=CurrentReceiver.strSelectorHeading, strDataFrameName:=strCurrentDataFrame, arrStrExcludedItems:=arrStrExclud, strDatabaseQuery:=CurrentReceiver.strDatabaseQuery, strNcFilePath:=CurrentReceiver.strNcFilePath)
        If strNewSelectorFillCondition = _strCurrentSelectorFillCondition Then
            Exit Sub
        End If
        _strCurrentSelectorFillCondition = strNewSelectorFillCondition
        frmMain.clsRLink.FillListView(lstAvailableVariable, strType:=strCurrentType, lstIncludedDataTypes:=lstCombinedMetadataLists(0), lstExcludedDataTypes:=lstCombinedMetadataLists(1), strHeading:=CurrentReceiver.strSelectorHeading, strDataFrameName:=strCurrentDataFrame, strExcludedItems:=arrStrExclud, strDatabaseQuery:=CurrentReceiver.strDatabaseQuery, strNcFilePath:=CurrentReceiver.strNcFilePath)
        EnableDataOptions(strCurrentType)

    End Sub

    Private Function GetSelectorFillCondition(iCurrentElementNum As Integer, strElementType As String, lstCombinedMetadataLists As List(Of List(Of KeyValuePair(Of String, String()))), strHeading As String, strDataFrameName As String, arrStrExcludedItems As String(), strDatabaseQuery As String, strNcFilePath As String)
        Dim strSelectorFillCondition As String

        strSelectorFillCondition = iCurrentElementNum

        If Not String.IsNullOrEmpty(strElementType) Then
            strSelectorFillCondition &= strElementType
        End If

        If Not String.IsNullOrEmpty(strHeading) Then
            strSelectorFillCondition &= strHeading
        End If

        If Not String.IsNullOrEmpty(strDataFrameName) Then
            strSelectorFillCondition &= strDataFrameName
        End If

        If Not String.IsNullOrEmpty(strDatabaseQuery) Then
            strSelectorFillCondition &= strDatabaseQuery
        End If

        If Not String.IsNullOrEmpty(strNcFilePath) Then
            strSelectorFillCondition &= strNcFilePath
        End If

        If arrStrExcludedItems IsNot Nothing Then
            strSelectorFillCondition &= String.Join("", arrStrExcludedItems)
        End If

        If lstCombinedMetadataLists IsNot Nothing Then
            For i As Integer = 0 To i < lstCombinedMetadataLists.Count - 1
                For i2 As Integer = 0 To lstCombinedMetadataLists(i).Count
                    strSelectorFillCondition &= lstCombinedMetadataLists.Item(i).Item(i2).Key
                    strSelectorFillCondition &= String.Join("", lstCombinedMetadataLists.Item(i).Item(i2).Value)
                Next
            Next
        End If

        Return strSelectorFillCondition
    End Function
    Private Function GetVariablesInReceiver() As List(Of String)
        Dim lstVars As New List(Of String)

        For Each tplTemp As Tuple(Of String, String) In lstVariablesInReceivers
            lstVars.Add(tplTemp.Item1)
        Next
        Return lstVars
    End Function

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
        Dim lstReceiverDataFrames As List(Of String)

        If CurrentReceiver IsNot Nothing Then
            CurrentReceiver.RemoveColor()
        End If
        If conReceiver IsNot Nothing Then
            CurrentReceiver = conReceiver
            CurrentReceiver.SetColor()
            SetPrimaryDataFrameOptions(strPrimaryDataFrame, Not CurrentReceiver.bAttachedToPrimaryDataFrame AndAlso CurrentReceiver.bOnlyLinkedToPrimaryDataFrames)
            If Not CurrentReceiver.IsEmpty Then
                lstReceiverDataFrames = CurrentReceiver.GetItemsDataFrames()
                If lstReceiverDataFrames.Count = 1 AndAlso lstReceiverDataFrames(0) <> "" AndAlso lstReceiverDataFrames(0) <> strCurrentDataFrame Then
                    SetDataframe(lstReceiverDataFrames(0), bSilent:=True)
                End If
            ElseIf CurrentReceiver.bAttachedToPrimaryDataFrame Then
                If strPrimaryDataFrame <> "" AndAlso strPrimaryDataFrame <> strCurrentDataFrame Then
                    SetDataframe(strPrimaryDataFrame, bSilent:=True)
                End If
            End If
            'TODO possibly move this to avoid repetition loading list
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
            'sets current focus enabling correct tab navigation
            CurrentReceiver.Focus()
            'check if autoswitching from the receiver is allowed before doing an autoswitch. 
            If CurrentReceiver.bAutoSwitchFromReceiver Then
                AutoSwitchCurrentReceiver(CurrentReceiver)
            End If
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
        sdgDataOptions.SetCurrentDataFrame(strCurrentDataFrame, False)
        sdgDataOptions.ShowDialog()
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
            lstVariablesInReceivers.Add(New Tuple(Of String, String)(strVariable, strDataFrame))
            If ucrLinkedSelector IsNot Nothing Then
                ucrLinkedSelector.AddToVariablesList(strVariable, strCurrentDataFrame)
            End If
            RaiseEvent VariablesInReceiversChanged()
        End If
    End Sub

    Public Sub RemoveFromVariablesList(strVariable As String, Optional strDataFrame As String = "")
        For i As Integer = lstVariablesInReceivers.Count - 1 To 0 Step -1
            If lstVariablesInReceivers(i).Item1 = strVariable AndAlso (strDataFrame = "" OrElse lstVariablesInReceivers(i).Item2 = strDataFrame) Then
                lstVariablesInReceivers.RemoveAt(i)
            End If
        Next
        If ucrLinkedSelector IsNot Nothing Then
            ucrLinkedSelector.RemoveFromVariablesList(strVariable, strCurrentDataFrame)
        End If
        RaiseEvent VariablesInReceiversChanged()
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

    Public Sub SetGgplotFunction(clsNewGgplotFunction As ROperator)
        clsGgplotOperator = clsNewGgplotFunction
    End Sub

    Public Overridable Sub SetDataframe(strNewDataFrame As String, Optional bEnableDataframe As Boolean = True, Optional bSilent As Boolean = False)

    End Sub

    Public Overridable Sub SetPrimaryDataFrameOptions(strNewPrimaryDataFrame As String, bNewOnlyLinkedToPrimaryDataFrames As Boolean, Optional bNewIncludePrimaryDataFrameAsLinked As Boolean = False)

    End Sub


    ''' <summary>
    ''' if <paramref name="ucrNewReceiver"/> is not yet in the list of receivers listening to 
    ''' this selector, then inserts the receiver into the list. This list is ordered by tab index.
    ''' If <paramref name="ucrNewReceiver"/> is already in the list then the receiver is not inserted.
    ''' </summary>
    ''' <param name="ucrNewReceiver"> The receiver to insert into the list.</param>
    Public Overridable Sub AddReceiver(ucrNewReceiver As ucrReceiver)
        AddReceivers({ucrNewReceiver})
    End Sub

    ''' <summary>
    ''' For each reciever in <paramref name="ucrNewReceivers"/>, if the receiver is not yet in 
    ''' the list of receivers listening to this selector, then inserts the receiver into the list.  
    ''' This list is ordered by tab index.
    ''' If the receiver is already in the list then the receiver is not inserted.
    ''' </summary>
    ''' <param name="ucrNewReceivers"> The receivers to insert into the list.</param>
    Public Overridable Sub AddReceivers(ucrNewReceivers As IEnumerable(Of ucrReceiver))
        'add the receiver to the list if it's not already added
        For Each ucr As ucrReceiver In ucrNewReceivers
            If Not lstOrderedReceivers.Contains(ucr) Then
                lstOrderedReceivers.Add(ucr)
            End If
        Next
        'then order them by tab index. This will return an IOrderedEnumerable from which we get the list.
        lstOrderedReceivers = (From ucr In lstOrderedReceivers Order By ucr.TabIndex).ToList
    End Sub


    ''' <summary>
    ''' Removes the first occurrence of the passed receiver if found. 
    ''' </summary>
    ''' <param name="ucrReceiver"></param>
    ''' <returns>true if item is successfully removed; otherwise, false. also returns false if item was not found in the list</returns>
    Public Overridable Function RemoveReceiver(ucrReceiver As ucrReceiver) As Boolean
        Return lstOrderedReceivers.Remove(ucrReceiver)
    End Function

    ''' <summary>
    ''' This subroutine is used to automatically switch focus to the next receiver whenever this 
    ''' selector changes selection. 
    ''' This subroutine sets the current receiver to be the next visible/enabled receiver in the 
    ''' list of receivers listening to this selector.  This list is ordered by tab index. 
    ''' </summary>
    ''' <param name="FromSelectedReceiver"> The receiver that has the current focus.</param>
    Private Sub AutoSwitchCurrentReceiver(FromSelectedReceiver As ucrReceiver)
        Dim ucrNewCurrentReceiver As ucrReceiver
        For i As Integer = 0 To lstOrderedReceivers.Count - 2
            If lstOrderedReceivers.Item(i) Is FromSelectedReceiver Then
                ucrNewCurrentReceiver = lstOrderedReceivers.Item(i + 1)
                If ucrNewCurrentReceiver.Visible AndAlso ucrNewCurrentReceiver.Enabled Then
                    ucrNewCurrentReceiver.Focus() 'sets current focus enabling correct tab navigation
                    SetCurrentReceiver(ucrNewCurrentReceiver)
                Else
                    AutoSwitchCurrentReceiver(ucrNewCurrentReceiver)
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "334")
    End Sub
End Class
