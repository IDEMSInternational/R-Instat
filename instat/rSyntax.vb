' Instat+R
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


Public Class RSyntax
    Dim strFunction As String
    Dim strParameter As String()

    Public Sub SetFunction(strFunctionName As String)
        strFunction = strFunctionName
    End Sub

    Public Sub AddParameter(strParameterName As String, strParameterValue As String)
        strParameter = {strParameterName, strParameterValue}
        'Dim boundA As Integer = strParameter.GetUpperBound(0)
        'Dim boundB As Integer = strParameter.GetUpperBound(1)
        'If strParameter.Length < 1 Then
        '    strParameter = {strParameterName, strParameterValue}
        '    'Else
        '    '    For i As Integer = 0 To boundA
        '    '        For j As Integer = 0 To boundB
        '    '            strParameter = {strParameterName, strParameterValue}
        '    '        Next
        '    '    Next
        'End If
    End Sub

    Public Sub RemoveParameter(strParameterName As String, strParameterValue As String)

    End Sub

    Public Function GetScript() As String
        Return MsgBox("WIP")
    End Function

End Class
