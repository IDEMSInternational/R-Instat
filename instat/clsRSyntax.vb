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
    Public clsBaseOperator As New ROperator
    Public bUseBaseFunction As Boolean = False
    Public bUseBaseOperator As Boolean = False
    Public iCallType As Integer = 0
    Public strScript As String
    Public i As Integer
    Public strAssignTo As String

    Public Sub SetFunction(strFunctionName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.SetRCommand(strFunctionName)
        bUseBaseFunction = True
        bUseBaseOperator = False
    End Sub

    Public Sub SetOperation(strOp As String)
        clsBaseOperator.SetOperation(strOp)
        bUseBaseFunction = False
        bUseBaseOperator = True
    End Sub

    Public Sub SetAssignTo(strAssignToName As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "")
        If bUseBaseOperator Then
            clsBaseOperator.SetAssignTo(strAssignToName)
        End If
        If bUseBaseFunction Then
            clsBaseFunction.SetAssignTo(strAssignToName, strTempDataframe, strTempColumn, strTempModel)
        End If
    End Sub

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing)
        clsBaseFunction.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter)
    End Sub

    Public Sub AddParameter(clsRParam As RParameter)
        clsBaseFunction.AddParameter(clsRParam)
    End Sub

    Public Sub SetOperatorParameter(bSetLeftNotRight As Boolean, Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)
        clsBaseOperator.SetParameter(bSetLeftNotRight, clsParam, clsRFunc, clsOp)
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

        clsFunction.ClearParameters()
    End Sub

    Public Function GetScript(Optional ByRef clsFunction As RFunction = Nothing, Optional bExcludeAssignedFunctionOutput As Boolean = True) As String

        Dim strTemp As String = ""

        If IsNothing(clsFunction) Then
            If bUseBaseFunction Then
                clsFunction = clsBaseFunction
                strTemp = clsBaseFunction.ToScript(strScript)
            End If
            If bUseBaseOperator Then
                strTemp = clsBaseOperator.ToScript(strScript)
            End If
        Else
            strTemp = clsFunction.ToScript(strScript)
        End If
        If bUseBaseFunction Then
            If bExcludeAssignedFunctionOutput And clsFunction.bIsAssigned Then
                Return strScript
                Exit Function
            End If
        End If
        Return strScript & strTemp

    End Function

End Class