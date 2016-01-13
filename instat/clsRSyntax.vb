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
    Public clsBaseFunction As New RFunction
    Public iFunctionType As Integer = 0
    Public iCallType As Integer = 0
    Dim strParameter(1, 0) As String
    Public strScript As String
    Public i As Integer
    Public strAssignTo As String

    Public Sub SetFunction(strFunctionName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetRCommand(strFunctionName)
    End Sub

    Public Sub SetAssignTo(strAssignToName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetAssignTo(strAssignToName)
    End Sub

    Public Sub AddParameter(strParameterName As String, strParameterValue As String, Optional ByRef clsFunction As RFunction = Nothing)
        Dim clsParam As New RParameter

        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsParam.SetArgumentName(strParameterName)
        clsParam.SetArgumentValue(strParameterValue)
        clsFunction.AddParameter(clsParam)
    End Sub

    Public Sub RemoveParameter(strParameterName As String, Optional ByRef clsFunction As RFunction = Nothing)
        Dim clsParam As New RParameter

        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.RemoveParameterByName(strParameterName)
    End Sub

    Public Function GetScript(Optional ByRef clsFunction As RFunction = Nothing) As String
        Dim strScript As String = ""

        If IsNothing(clsFunction) Then
            clsFunction = clsBaseFunction
        End If

        strScript = clsFunction.ToScript(strScript)
        Return strScript
    End Function

    Public Function writeScript() As String
        strScript = strFunction & "("
        If strAssignTo IsNot Nothing Then
            strScript = strAssignTo & "<-" & strScript
        End If
        For i = 0 To strParameter.GetUpperBound(1)
            If i = 1 Then
                strScript = strScript & "~"
            ElseIf i > 2 Then
                strScript = strScript & "+"
            End If
            strScript = strScript & strParameter(0, i)
        Next
        strScript = strScript & ",data = data_temp))"
        Return strScript
    End Function

    Public Function orderScript() As String
        strScript = strFunction & "("
        If strAssignTo IsNot Nothing Then
            strScript = strAssignTo & "<-" & strScript
        End If
        For i = 0 To strParameter.GetUpperBound(1)
            If i > 0 Then
                strScript = strScript & ","
            End If
            strScript = strScript & strParameter(1, i) & "=" & strParameter(0, i)
        Next
        strScript = strScript & ")"
        Return strScript
    End Function
End Class