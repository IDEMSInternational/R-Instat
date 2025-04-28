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

Public Class ucrInputComboBox

    ''' <summary>
    ''' Specifies the type of information required when calling <see cref="GetText([Enum])"/>.
    ''' In this case, either the combo box's key or value.
    ''' </summary>
    Public Enum EnumTextType
        key
        value
    End Enum

    Private _strRObjectItemsTypeLabel As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bAllowNonConditionValues = False
    End Sub

    'temporary event which is only raised when index is changed
    'NameChanged raised any time value is set (even if it's the same)
    Public Event SelectionIndexChanged()

    Private Sub cboInput_Validating(sender As Object, e As CancelEventArgs) Handles cboInput.Validating
        Dim strCurrent As String

        strCurrent = cboInput.Text
        If bAutoChangeOnLeave Then
            If Not IsValid(strCurrent) Then
                'TODO This message should contain the same message from ValidateText()
                'Select Case MsgBox(Chr(34) & strCurrent & Chr(34) & " is an invalid name." & Environment.NewLine & "Would you like it to be automatically corrected?", vbYesNo, "Invalid Name")
                '    Case MsgBoxResult.Yes
                '        SetName(frmMain.clsRLink.MakeValidText(strCurrent))
                '    Case Else
                '        e.Cancel = True
                'End Select
                SetName(frmMain.clsRLink.MakeValidText(strCurrent))
            End If
        Else
            e.Cancel = Not ValidateText(strCurrent)
        End If
        If Not e.Cancel Then OnNameChanged()
    End Sub

    Public Sub SetRObjectItemsTypeLabel(strRObjectItemsTypeLabel As String)
        _strRObjectItemsTypeLabel = strRObjectItemsTypeLabel
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsColumns()
        _strRObjectItemsTypeLabel = "Columns"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsDataFrames()
        _strRObjectItemsTypeLabel = "Data Frames"
        FillItemTypes()
    End Sub


    Public Sub SetItemsTypeAsFilters()
        _strRObjectItemsTypeLabel = "Filters"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsColumnSelection()
        _strRObjectItemsTypeLabel = "Column Selection"

        FillItemTypes()
    End Sub


    Public Sub SetItemsTypeAsKeys()
        _strRObjectItemsTypeLabel = "Keys"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsLinks()
        _strRObjectItemsTypeLabel = "Links"
        FillItemTypes()
    End Sub

    Private Sub FillItemTypes()
        If ucrDataFrameSelector Is Nothing Then
            Exit Sub
        End If

        Select Case _strRObjectItemsTypeLabel
            Case "Columns"
                frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboInput)
            Case "Keys"
                cboInput.Items.Clear()
                cboInput.Items.AddRange(frmMain.clsRLink.GetKeyNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray)
            Case "Data Frames"
                'TODO not yet implemented
            Case RObjectTypeLabel.Graph,
                 RObjectTypeLabel.Table,
                 RObjectTypeLabel.Model,
                 RObjectTypeLabel.StructureLabel,
                 RObjectTypeLabel.Summary
                'for objects that are shown in the output viewer. do the following
                cboInput.Items.Clear()
                cboInput.Items.AddRange(frmMain.clsRLink.GetObjectNames(
                                            strDataFrameName:=Me.ucrDataFrameSelector.strCurrDataFrame,
                                            strRObjectTypeLabel:=Me._strRObjectItemsTypeLabel).ToArray)

            Case "Filters"
                cboInput.Items.Clear()
                cboInput.Items.AddRange(frmMain.clsRLink.GetFilterNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray())
            Case "Column Selection"
                cboInput.Items.Clear()
                cboInput.Items.AddRange(frmMain.clsRLink.GetColumnSelectionNames(ucrDataFrameSelector.cboAvailableDataFrames.Text).ToArray())
        End Select
    End Sub

    Public Sub ucrDataFrameSelector_ControlValueChanged() Handles ucrDataFrameSelector.ControlValueChanged
        FillItemTypes()
    End Sub

    Public Overrides Sub SetDataFrameSelector(ucrNewSelector As ucrDataFrame)
        MyBase.SetDataFrameSelector(ucrNewSelector)
        FillItemTypes()
    End Sub

    Public Overrides Sub SetName(strName As String, Optional bSilent As Boolean = False)
        MyBase.SetName(strName, bSilent)
        If bSilent Then
            cboInput.Text = strName
            If cboInput.FindStringExact(strName) <> -1 Then
                cboInput.SelectedIndex = cboInput.FindStringExact(strName)
            End If
            OnNameChanged()
        Else
            If ValidateText(strName) Then
                cboInput.Text = strName
                OnNameChanged()
            End If
        End If
    End Sub

    ''' <summary>
    '''  Returns information about the combo box's current selection as specified by 
    '''  <paramref name="enumTextType"/>.
    '''  If <paramref name="enumTextType"/> is not specified, returns the combo box's key value.
    '''  If <paramref name="enumTextType"/> is invalid, then throws an exception.
    ''' </summary>
    ''' <param name="enumTextType"></param>
    ''' <returns>Information about the combo box's current selection as specified by 
    '''     <paramref name="enumTextType"/></returns>
    Public Overrides Function GetText(Optional enumTextType As [Enum] = Nothing) As String
        If enumTextType Is Nothing Then
            enumTextType = ucrInputComboBox.EnumTextType.key
        End If

        Dim textType As EnumTextType
        Try
            textType = DirectCast(enumTextType, EnumTextType)
        Catch ex As InvalidCastException
            Throw New InvalidCastException("Invalid text type requested from input combo box.")
        End Try

        Select Case textType
            Case ucrInputComboBox.EnumTextType.key
                Return cboInput.Text
            Case ucrInputComboBox.EnumTextType.value
                Dim value As String = String.Empty
                If dctDisplayParameterValues.TryGetValue(cboInput.Text, value) Then
                    Return value
                End If
                Throw New Exception("Value not found for input combo box key: " & cboInput.Text)
        End Select

        Throw New InvalidEnumArgumentException("Unhandled text type requested from input combo box.")
    End Function

    Public Overrides Function GetValue() As Object
        If cboInput.SelectedValue IsNot Nothing Then
            Return cboInput.SelectedValue
        Else
            Return GetText()
        End If
    End Function

    Public Property GetSetSelectedIndex As Integer
        Get
            Return cboInput.SelectedIndex
        End Get
        Set(value As Integer)
            cboInput.SelectedIndex = value
        End Set
    End Property

    Public ReadOnly Property GetItemsCount As Integer
        Get
            Return cboInput.Items.Count
        End Get
    End Property

    Public Sub SetItems(Optional strItems As String() = Nothing, Optional bClearExisting As Boolean = True, Optional bAddConditions As Boolean = False, Optional bAddQuotes As Boolean = True)
        Dim dctValues As New Dictionary(Of String, String)
        If bAddConditions Then
            For Each strTemp As String In strItems
                If bAddQuotes Then
                    dctValues.Add(strTemp, Chr(34) & strTemp & Chr(34))
                Else
                    dctValues.Add(strTemp, strTemp)
                End If
            Next
            SetItems(dctValues, bClearExisting)
        Else
            If bClearExisting Then
                cboInput.Items.Clear()
            End If
            If strItems IsNot Nothing Then
                cboInput.Items.AddRange(strItems)
            End If
            AdjustComboBoxWidth(cboInput)
        End If
    End Sub

    Public Sub SetItems(dctItemParameterValuePairs As Dictionary(Of String, String), Optional bClearExisting As Boolean = True, Optional bSetConditions As Boolean = True)
        Dim kvpTemp As KeyValuePair(Of String, String)

        If bClearExisting Then
            cboInput.Items.Clear()
            dctDisplayParameterValues.Clear()
        End If
        If bSetConditions Then
            If GetParameter() Is Nothing Then
                MsgBox("Developer error: Parameter must be set before items can be set. Modify setup for " & Name & " so that the parameter is set first.")
            End If
        End If
        For Each kvpTemp In dctItemParameterValuePairs
            cboInput.Items.Add(kvpTemp.Key)
            dctDisplayParameterValues.Add(kvpTemp.Key, kvpTemp.Value)
            If bSetConditions AndAlso GetParameter() IsNot Nothing Then
                AddParameterValuesCondition(kvpTemp.Key, GetParameter().strArgumentName, kvpTemp.Value)
            End If
        Next
        AdjustComboBoxWidth(cboInput)
    End Sub

    Public Sub AddItems(strItems As String())
        SetItems(strItems, bClearExisting:=False)
    End Sub

    Private Sub cboInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboInput.KeyPress
        bUserTyped = False
    End Sub

    'Public Sub SetEditable(bEditable As Boolean)

    '    If bEditable Then
    '        cboInput.DropDownStyle = ComboBoxStyle.DropDownList
    '    Else
    '        cboInput.DropDownStyle = ComboBoxStyle.DropDown
    '    End If
    'End Sub
    Public Overrides Function IsEmpty() As Boolean
        If cboInput.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub ucrInputComboBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillItemTypes()
        If bFirstLoad Then
            bFirstLoad = False
        End If
    End Sub

    Private Sub cboInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboInput.SelectedIndexChanged
        OnNameChanged()
        RaiseEvent SelectionIndexChanged()
    End Sub

    Private Sub ucrInputComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'If bIsReadOnly Then
        '    e.Handled = True
        'End If
    End Sub

    Private Sub cboInput_TextChanged(sender As Object, e As EventArgs) Handles cboInput.TextChanged
        'shouldn't we be raising OnControlValueChanged instead? see issue #7367
        OnControlContentsChanged()
    End Sub
    Private Sub cboInput_Click(sender As Object, e As EventArgs) Handles cboInput.Click
        OnControlClicked()
    End Sub

    Private Sub mnuRightClickCopy_Click(sender As Object, e As EventArgs) Handles mnuRightClickCopy.Click
        If cboInput.SelectedText <> "" Then
            Clipboard.SetText(cboInput.SelectedText)
        ElseIf cboInput.DropDownStyle = ComboBoxStyle.DropDownList AndAlso cboInput.Text <> "" Then
            Clipboard.SetText(cboInput.Text)
        End If
    End Sub

    'This seems overly complicated, but appears only way to auto size
    'Adapted from: http://dotnetanaya.blogspot.co.uk/2012/12/vbnet-adjusting-combobox-dropdownlist.html
    'Need to make sure this is called from all places needed
    'There is no build in event to check items added
    'TODO this is repeat in clsRLink for ucrDataFrame, will not be needed once controls changed
    'Should have a place for shared methods
    Public Sub AdjustComboBoxWidth(cboCurrent As ComboBox)
        Dim iWidth As Integer = cboCurrent.DropDownWidth
        Dim graTemp As Graphics = cboCurrent.CreateGraphics()
        Dim font As Font = cboCurrent.Font
        Dim iScrollBarWidth As Integer
        Dim iNewWidth As Integer

        If cboCurrent.Items.Count > cboCurrent.MaxDropDownItems Then
            iScrollBarWidth = SystemInformation.VerticalScrollBarWidth
        Else
            iScrollBarWidth = 0
        End If

        For Each strItem As String In cboCurrent.Items
            iNewWidth = CInt(graTemp.MeasureString(strItem, font).Width) + iScrollBarWidth
            iWidth = Math.Max(iWidth, iNewWidth)
        Next
        cboCurrent.DropDownWidth = iWidth
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        MyBase.UpdateControl(bReset:=bReset, bCloneIfNeeded:=bCloneIfNeeded)
    End Sub

    Public Sub SetDropDownStyleAsNonEditable()
        cboInput.DropDownStyle = ComboBoxStyle.DropDownList
        cboInput.AutoCompleteMode = AutoCompleteMode.None
        cboInput.AutoCompleteSource = AutoCompleteSource.None
    End Sub

    Public Sub SetDropDownStyleAsEditable(bAdditionsAllowed As Boolean)
        cboInput.DropDownStyle = ComboBoxStyle.DropDown
        cboInput.AutoCompleteMode = AutoCompleteMode.Append
        cboInput.AutoCompleteSource = AutoCompleteSource.ListItems
        'TODO implement validation settings for this		
        If bAdditionsAllowed Then

        Else

        End If
    End Sub

    Public Sub SetDataSource(objDataSource As Object, Optional strDisplayMember As String = "", Optional strValueMember As String = "")
        cboInput.DataSource = objDataSource
        If strDisplayMember <> "" Then
            cboInput.DisplayMember = strDisplayMember
        End If
        If strValueMember <> "" Then
            cboInput.ValueMember = strValueMember
        End If
    End Sub

    Friend Sub AddToReceiverAtCursorPosition(v As String)
        Throw New NotImplementedException()
    End Sub
End Class