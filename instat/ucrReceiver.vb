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
    Public lstIncludedDataTypes As List(Of String)
    Public lstExcludedDataTypes As List(Of String)
    Public bFirstLoad As Boolean = True
    Public strSelectorHeading As String = "Available Variables"

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
        If bFirstLoad Then
            lstIncludedDataTypes = New List(Of String)
            lstExcludedDataTypes = New List(Of String)
            bFirstLoad = False
        End If
    End Sub

    Public Function GetIncludedDataTypes(Optional bWithQuotes As Boolean = True) As String
        Return GetListAsRString(lstIncludedDataTypes, bWithQuotes)
    End Function

    Public Function GetExcludedDataTypes(Optional bWithQuotes As Boolean = True) As String
        Return GetListAsRString(lstExcludedDataTypes, bWithQuotes)
    End Function

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
        lstIncludedDataTypes.Add(strTemp)
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Public Sub SetIncludedDataTypes(strInclude As String())
        lstIncludedDataTypes.AddRange(strInclude)
        lstExcludedDataTypes.Clear()
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Public Sub SetExcludedDataTypes(strExclude As String())
        lstExcludedDataTypes.AddRange(strExclude)
        lstIncludedDataTypes.Clear()
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
