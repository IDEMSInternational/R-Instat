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

Imports System.ComponentModel
Imports RDotNet

Public Class ucrReceiverSingle

    ''' <summary>
    ''' Specifies the type of information required when calling <see cref="GetText([Enum])"/>.
    ''' </summary>
    Public Enum EnumTextType
        isFactor
        text
    End Enum

    Dim strDataFrameName As String
    Public strCurrDataType As String
    Public Event WithMeSelectionChanged(ucrChangedReceiver As ucrReceiverSingle)
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

    Public Overrides Sub AddSelectedSelectorVariables()
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
        Dim strCurrentItemType As String = ""
        Dim expColumnType As SymbolicExpression
        Dim bRemove As Boolean = False

        MyBase.Add(strItem, strDataFrame)

        strCurrentItemType = If(bTypeSet, strType, Selector?.GetItemType())
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
            If bRemove Then
                RemoveSelected()
            End If
            txtReceiverSingle.Enabled = Not bFixReceiver
        End If
    End Sub

    Public Overrides Sub RemoveSelected()
        If txtReceiverSingle.Enabled Then
            txtReceiverSingle.Text = ""
            strDataFrameName = ""
        End If
        MyBase.RemoveSelected()
    End Sub

    ''' <summary>
    ''' Removes any variable in the single receiver
    ''' that is not in the list of variables of the selector
    ''' </summary>
    Public Overrides Sub RemoveAnyVariablesNotInSelector()
        If Not IsEmpty() AndAlso Selector?.lstAvailableVariable.FindItemWithText(txtReceiverSingle.Text) Is Nothing Then
            Clear()
        End If
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
                Case "object",
                     RObjectTypeLabel.Graph,
                     RObjectTypeLabel.Table,
                     RObjectTypeLabel.Model,
                     RObjectTypeLabel.Summary,
                     RObjectTypeLabel.StructureLabel
                    clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
                    clsGetVariablesFunc.AddParameter("object_name", GetVariableNames())
                    clsGetVariablesFunc.AddParameter("as_file", "FALSE")
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
                clsGetVariablesFunc.SetAssignToObject(strRObjectToAssignTo:=strDataFrameName & "." & txtReceiverSingle.Text)
            Else
                clsGetVariablesFunc.SetAssignToObject(strRObjectToAssignTo:=txtReceiverSingle.Text)
            End If
            Return clsGetVariablesFunc
        Else
            Return clsGetVariablesFunc
        End If
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Return If(bWithQuotes, Chr(34) & txtReceiverSingle.Text & Chr(34), txtReceiverSingle.Text)
    End Function

    Public Overrides Function GetVariableNameslist(Optional bWithQuotes As Boolean = True, Optional strQuotes As String = Chr(34)) As String()
        If bWithQuotes Then
            Return {strQuotes & txtReceiverSingle.Text & strQuotes}
        Else
            Return {txtReceiverSingle.Text}
        End If
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

    Private Sub ParentForm_Shown()
        If bFirstShown Then
            'This is not needed probably
            'CheckAutoFill()
            bFirstShown = False
        End If
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
            'by default multiple receivers will be autoswitched on selection change
            bAutoSwitchFromReceiver = True
        End If
    End Sub

    Public Overrides Sub SetTextColour(clrNew As Color)
        txtReceiverSingle.ForeColor = clrNew
    End Sub

    Public Overrides Function GetItemsDataFrames() As List(Of String)
        Return New List(Of String)({strDataFrameName})
    End Function

    ''' <summary>
    '''  Returns information about the receiver's current selection as specified by 
    '''  <paramref name="enumTextType"/>.
    '''  If <paramref name="enumTextType"/> is not specified, returns the receiver's text.
    '''  If <paramref name="enumTextType"/> is invalid, then throws an exception.
    ''' </summary>
    ''' <param name="enumTextType"></param>
    ''' <returns>Information about the receiver's current selection as specified by 
    '''     <paramref name="enumTextType"/></returns>
    Public Overrides Function GetText(Optional enumTextType As [Enum] = Nothing) As String
        If enumTextType Is Nothing Then
            enumTextType = ucrReceiverSingle.EnumTextType.text
        End If

        Dim textType As EnumTextType
        Try
            textType = DirectCast(enumTextType, EnumTextType)
        Catch ex As InvalidCastException
            Throw New InvalidCastException("Invalid text type requested from single receiver.")
        End Try

        Select Case textType
            Case ucrReceiverSingle.EnumTextType.isFactor
                Return If(strCurrDataType = "factor", "TRUE", "FALSE")
            Case ucrReceiverSingle.EnumTextType.text
                Return txtReceiverSingle.Text
        End Select

        Throw New InvalidEnumArgumentException("Unhandled text type requested from single receiver.")
    End Function

End Class