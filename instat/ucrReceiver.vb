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

Imports instat.Translations
Public Class ucrReceiver
    Public WithEvents Selector As ucrSelector
    Public lstIncludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public lstExcludedMetadataProperties As List(Of KeyValuePair(Of String, String()))
    Public bFirstLoad As Boolean
    Public strSelectorHeading As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstIncludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        lstExcludedMetadataProperties = New List(Of KeyValuePair(Of String, String()))
        bFirstLoad = True
        strSelectorHeading = "Variables"
    End Sub

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()

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

    Public Sub SetMeAsReceiver()
        If Selector IsNot Nothing Then
            Selector.SetCurrentReceiver(Me)
        End If
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
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
    End Sub

    'TODO remove this method and replace with SetIncludedDataTypes
    Public Sub SetDataType(strTemp As String)
        AddIncludedMetadataProperty("Data_Type", {Chr(34) & strTemp & Chr(34)})
    End Sub

    Public Sub SetIncludedDataTypes(strInclude As String())
        Dim strTypes(strInclude.Count - 1) As String

        Array.Copy(strInclude, strTypes, strInclude.Length)
        For i = 0 To strInclude.Count - 1
            strTypes(i) = Chr(34) & strInclude(i) & Chr(34)
        Next
        AddIncludedMetadataProperty("Data_Type", strTypes)
    End Sub

    Public Sub SetExcludedDataTypes(strExclude As String())
        For i = 0 To strExclude.Count - 1
            strExclude(i) = Chr(34) & strExclude(i) & Chr(34)
        Next
        AddExcludedMetadataProperty("Data_Type", strExclude)
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

        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If

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

        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Private Sub Selector_ResetAll() Handles Selector.ResetReceivers
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

End Class
