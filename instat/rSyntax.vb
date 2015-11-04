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
    Dim strScript As String
    Public Sub SetFunction(strFunctionName As String)
        strScript = strFunctionName
    End Sub

    Public Sub AddParameter(strParameterName As String, strParameterValue As String)
        strScript = strParameterName & "=" & strParameterValue
    End Sub

    Public Sub RemoveParameter(strParameterName As String, strParameterValue As String)
        strScript = strParameterName & "=" & strParameterValue
    End Sub

    Public Function GetScript() As String
        Return MsgBox("Empty")
    End Function

End Class
