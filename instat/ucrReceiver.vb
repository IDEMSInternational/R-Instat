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
    Public strDataType As String = "all"

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()

    End Sub

    Public Overridable Sub Clear()

    End Sub

    Public Overridable Sub SetColor()

    End Sub

    Public Overridable Sub RemoveColor()

    End Sub

    Public Overridable Function GetVariables() As RFunction
        Dim clsGetVariablesFunc As New RFunction
        Return clsGetVariablesFunc
    End Function

    Public Overridable Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strVarNames As String = ""
        Return strVarNames
    End Function

    Public Sub SetMeAsReceiver()
        Selector.CurrentReceiver.RemoveColor()
        Selector.SetCurrentReceiver(Me)
        Selector.CurrentReceiver.SetColor()
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub

    Private Sub ucrReceiver_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        SetMeAsReceiver()
    End Sub

    Public Event ValueChanged(ByVal sender As Object, ByVal e As EventArgs)

    Public Sub OnValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        RaiseEvent ValueChanged(sender, e)
    End Sub

    Public Sub SetDataType(strTemp As String)
        strDataType = strTemp
        If Selector IsNot Nothing Then
            Selector.LoadList()
        End If
    End Sub

    Public Function MakeValidRString(strTemp As String) As String
        Dim InvalidStrings() As String = {" ", "-"}
        For Each strInvalid In InvalidStrings
            strTemp = Replace(strTemp, strInvalid, "")
        Next
        Return strTemp
    End Function

    Private Sub Selector_ListChanged() Handles Selector.DataFrameChanged
        If (TypeOf Selector Is ucrSelectorByDataFrame) Then
            Clear()
        End If
    End Sub
End Class
