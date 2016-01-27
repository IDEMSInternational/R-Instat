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
    Public iCallType As Integer = 0
    Public strScript As String
    Public i As Integer
    Public strAssignTo As String

    Public Sub SetFunction(strFunctionName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetRCommand(strFunctionName)
    End Sub

    Public Sub SetAssignTo(strAssignToName As String, Optional ByRef clsFunction As RFunction = Nothing, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "")
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetAssignTo(strAssignToName, strTempDataframe, strTempColumn, strTempModel)
    End Sub

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional ByRef clsRFunction As RFunction = Nothing)
        Dim clsParam As New RParameter

        If clsRFunction Is Nothing Then
            clsRFunction = clsBaseFunction
        End If
        clsParam.SetArgumentName(strParameterName)
        If Not strParameterName = "" Then
            clsParam.SetArgumentValue(strParameterValue)
        End If
        If Not clsRFunctionParameter Is Nothing Then
            clsParam.SetArgumentFunction(clsRFunctionParameter)
        End If
        clsRFunction.AddParameter(clsParam)
    End Sub

    Public Sub RemoveParameter(strParameterName As String, Optional ByRef clsFunction As RFunction = Nothing)
        Dim clsParam As New RParameter

        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.RemoveParameterByName(strParameterName)
    End Sub

    Public Sub ClearParameters(Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If

        For Each clsCurrParam In clsFunction.clsParameters
            clsFunction.RemoveParameterByName(clsCurrParam.strArgumentName)
        Next
    End Sub

    Public Function GetScript(Optional ByRef clsFunction As RFunction = Nothing, Optional bExcludeAssignedFunctionOutput As Boolean = True) As String

        Dim strTemp As String

        If IsNothing(clsFunction) Then
            clsFunction = clsBaseFunction
        End If

        strTemp = clsFunction.ToScript(strScript)
        If bExcludeAssignedFunctionOutput And clsFunction.bIsAssigned Then
            Return strScript
        Else
            Return strScript & strTemp
        End If

    End Function

End Class