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

Imports instat
Imports instat.Translations
Public Class ucrReceiver
    Public WithEvents Selector As ucrSelector
    Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public bFirstLoad As Boolean
    Public bFirstShown As Boolean
    Public strSelectorHeading As String
    Public bUseFilteredData As Boolean = True
    Public bTypeSet As Boolean
    Protected strType As String
    Public bExcludeFromSelector As Boolean = False
    Public Event SelectionChanged(sender As Object, e As EventArgs)
    Public WithEvents frmParent As Form

    Public strDatabaseQuery As String = ""

    Public bAddParameterIfEmpty As Boolean = False
    'If the control is used to set a parameter that is a string i.e. column = "ID"
    Private bParameterIsString As Boolean = False
    'If the control is used to set a parameter that is an RFunction i.e. x = InstatDataObject$get_columns_from_data()
    Private bParameterIsRFunction As Boolean = False
    'The name of the data parameter in the get columns instat object method (should always be the same)
    Private strColumnsParameterNameInRFunction As String = "col_names"

    'Should quotes be used when bParameterIsString = False
    Public bWithQuotes As Boolean = True

    'Should columns be forced as a data frame object when bParameterIsRFunction = True
    Public bForceAsDataFrame As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstIncludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        lstExcludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        bFirstLoad = True
        bFirstShown = True
        bTypeSet = False
        strSelectorHeading = "Variables"
        strType = "column"
        bUpdateRCodeFromControl = True
    End Sub

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Public Overridable Sub Remove(strItems As String())

    End Sub

    Public Overridable Sub Clear()

    End Sub

    Public Overridable Function IsEmpty() As Boolean
        Return True
    End Function

    Public Overridable Sub SetColor()

    End Sub

    Public Overridable Sub RemoveColor()

    End Sub

    Public Overridable Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        Dim clsGetVariablesFunc As New RFunction
        Return clsGetVariablesFunc
    End Function

    Public Overridable Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVarNames As String = ""
        Return strVarNames
    End Function

    Public Overridable Function GetVariableNamesList(Optional bWithQuotes As Boolean = True) As String()
        Dim strVarNames As String() = Nothing
        Return strVarNames
    End Function

    Public Sub SetMeAsReceiver()
        If Selector IsNot Nothing Then
            Selector.SetCurrentReceiver(Me)
        End If
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
        If bFirstLoad Then
            frmParent = ParentForm
            'Remove this line so that single/multiple code can run things on first load as well
            'We never have a receiver not as a single or multiple
            'bFirstLoad = False
        End If
    End Sub

    'TODO make this function available throughout project
    Public Function GetListAsRString(lstStrings As List(Of String), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstStrings.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstStrings.Item(0) & Chr(34)
            Else
                strTemp = lstStrings.Item(0)
            End If
        ElseIf lstStrings.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstStrings.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstStrings.Item(i) <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstStrings.Item(i) & Chr(34)
                    Else
                        strTemp = strTemp & lstStrings.Item(i)
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    Private Sub ucrReceiver_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        SetMeAsReceiver()
    End Sub

    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub OnValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent ValueChanged(sender, e)
        OnControlContentsChanged()
        OnControlValueChanged()
    End Sub

    'TODO remove this method and replace with SetIncludedDataTypes
    Public Sub SetDataType(strTemp As String)
        AddIncludedMetadataProperty("class", {Chr(34) & strTemp & Chr(34)})
    End Sub

    Public Sub SetIncludedDataTypes(strInclude As String())
        Dim strTypes(strInclude.Count - 1) As String

        Array.Copy(strInclude, strTypes, strInclude.Length)
        'If the two previous lines where not added, the modification of value performed on strTypes was immediately performed on strInclude, then the argument passed into the function such as clsCurrGeom.clsAesParameters(i).strIncludedDataTypes in ucrGeomListWithAes.SetParameters would have been edited (i.e. quotes would have been added to the types names in the strIncludedDataTypes of the i'th AesParameter of the current Geom...), which we don't want !
        For i = 0 To strInclude.Count - 1
            strTypes(i) = Chr(34) & strInclude(i) & Chr(34)
        Next
        AddIncludedMetadataProperty("class", strTypes)
    End Sub

    Public Sub SetExcludedDataTypes(strExclude As String())
        Dim strTypes(strExclude.Count - 1) As String

        Array.Copy(strExclude, strTypes, strExclude.Length)
        'If the two previous lines where not added, the modification of value performed on strTypes was immediately performed on strInclude, then the argument passed into the function such as clsCurrGeom.clsAesParameters(i).strExcludedDataTypes in ucrGeomListWithAes.SetParameters would have been edited (i.e. quotes would have been added to the types names in the strExcludedDataTypes of the i'th AesParameter of the current Geom...), which we don't want !
        For i = 0 To strExclude.Count - 1
            strTypes(i) = Chr(34) & strTypes(i) & Chr(34)
        Next
        AddExcludedMetadataProperty("class", strTypes)
    End Sub

    Public Sub AddIncludedMetadataProperty(strProperty As String, strInclude As String())
        Dim iIncludeIndex As Integer
        'Dim iExcludeIndex As Integer
        Dim kvpIncludeProperty As KeyValuePair(Of String, String())
        If strProperty = "class" AndAlso strInclude.Contains(Chr(34) & "factor" & Chr(34)) Then
            Array.Resize(strInclude, strInclude.Length + 1)
            ' WARNING: This is dependent on the way the metadata is displayed by the Instat object
            ' If this changes in Instat object, ordered factors will not be displayed
            ' TODO: Make this solid - should somehow use is.factor() in R
            strInclude(strInclude.Length - 1) = Chr(34) & "ordered,factor" & Chr(34)
        End If
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

        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If

    End Sub

    Public Sub RemoveIncludedMetadataProperty(strProperty As String)
        Dim iIncludeIndex As Integer

        iIncludeIndex = lstIncludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstIncludedMetadataProperties.RemoveAt(iIncludeIndex)
        End If
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If

    End Sub

    Public Sub RemoveExcludedMetadataProperty(strProperty As String)
        Dim iIncludeIndex As Integer

        iIncludeIndex = lstExcludedMetadataProperties.FindIndex(Function(x) x.Key = strProperty)
        If iIncludeIndex <> -1 Then
            lstExcludedMetadataProperties.RemoveAt(iIncludeIndex)
        End If
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub
    Public Sub AddExcludedMetadataProperty(strProperty As String, strExclude As String())
        'Dim iIncludeIndex As Integer
        Dim iExcludeIndex As Integer

        Dim kvpExcludeProperty As KeyValuePair(Of String, String())
        If strProperty = "class" AndAlso strExclude.Contains(Chr(34) & "factor" & Chr(34)) Then
            Array.Resize(strExclude, strExclude.Length + 1)
            ' WARNING: This is dependent on the way the metadata is displayed by the Instat object
            ' If this changes in Instat object, ordered factors will not be displayed
            ' TODO: Make this solid - should somehow use is.factor() in R
            strExclude(strExclude.Length - 1) = Chr(34) & "ordered,factor" & Chr(34)
        End If
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

        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Protected Overridable Sub Selector_ResetAll() Handles Selector.ResetReceivers
        Clear()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Shift + Keys.Tab) Then
            Selector.Focus()
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    Public Function GetItemType() As String
        Return strType
    End Function

    Public Sub SetItemType(strNewType As String)
        strType = strNewType
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
        bTypeSet = True
    End Sub

    Public Overridable Sub Add(strItem As String, Optional strDataFrame As String = "")
        'SetMeAsReceiver()
        'For i = 0 To Selector.lstAvailableVariable.Items.Count - 1
        '    If Selector.lstAvailableVariable.Items(i).Text = strItem Then
        '        Selector.lstAvailableVariable.SelectedItems.Clear()
        '        Selector.lstAvailableVariable.Items(i).Selected = True
        '        AddSelected()
        '        Selector.lstAvailableVariable.SelectedItems.Clear()
        '        Exit For
        '    End If
        'Next
    End Sub

    Public Sub OnSelectionChanged()
        Dim sender As New Object
        Dim e As New EventArgs
        RaiseEvent SelectionChanged(sender, e)
        OnControlValueChanged()
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim clsTempDataParameter As RParameter
        Dim lstCurrentVariables As String() = Nothing

        If clsParameter IsNot Nothing Then
            If bChangeParameterValue Then
                If bParameterIsString AndAlso clsParameter.bIsString Then
                    lstCurrentVariables = ExtractItemsFromRList(clsParameter.strArgumentValue)
                ElseIf bParameterIsRFunction AndAlso clsParameter.bIsFunction Then
                    clsTempDataParameter = clsParameter.clsArgumentCodeStructure.GetParameter(strColumnsParameterNameInRFunction)
                    If clsTempDataParameter IsNot Nothing Then
                        lstCurrentVariables = ExtractItemsFromRList(clsParameter.clsArgumentCodeStructure.GetParameter(strColumnsParameterNameInRFunction).strArgumentValue)
                    End If
                End If
                Clear()
                If lstCurrentVariables IsNot Nothing Then
                    For Each strTemp As String In lstCurrentVariables
                        'TODO This only works if the selector is updated before receivers!
                        '     Needs to change eventually.
                        If Selector IsNot Nothing AndAlso strTemp <> "" Then
                            Add(strTemp, Selector.strCurrentDataFrame)
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub ucrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles Me.SelectionChanged
        UpdateParameter()
    End Sub

    Public Sub UpdateParameter()
        If clsParameter Is Nothing Then
            clsParameter = New RParameter
        End If
        If bParameterIsString Then
            clsParameter.SetArgumentValue(GetVariableNames(bWithQuotes))
        ElseIf bParameterIsRFunction Then
            clsParameter.SetArgument(GetVariables(bForceAsDataFrame))
        End If
    End Sub

    Public Sub SetParameterIsString()
        bParameterIsString = True
        bParameterIsRFunction = False
        UpdateParameter()
    End Sub

    Public Sub SetParameterIsRFunction()
        bParameterIsRFunction = True
        bParameterIsString = False
        UpdateParameter()
    End Sub

    Public Overrides Function IsRDefault() As Boolean
        If bAddParameterIfEmpty Then
            Return False
        Else
            Return IsEmpty()
        End If
    End Function

    Public Sub SetClimaticType(strTemp As String)
        AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & strTemp & Chr(34)})
    End Sub
End Class