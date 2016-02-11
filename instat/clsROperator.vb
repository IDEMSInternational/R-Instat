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

Public Class ROperator
    Public clsLeftParameter As New RParameter
    Public clsLeftOperator As ROperator
    Public clsLeftFunction As RFunction

    Public clsRightParameter As New RParameter
    Public clsRightOperator As ROperator
    Public clsRightFunction As RFunction

    Public strOperation As String

    Public strAssignTo As String
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public bToBeAssigned As Boolean = False
    Public bIsAssigned As Boolean = False

    Public Sub SetOperation(strTemp As String)
        strOperation = strTemp
        bIsAssigned = False
    End Sub

    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "")
        strAssignTo = strTemp
        If Not strTempDataframe = "" Then
            strAssignToDataFrame = strTempDataframe
            If Not strTempColumn = "" Then
                strAssignToColumn = strTempColumn
            End If
        ElseIf Not strTempModel = "" Then
            strAssignToModel = strTempModel
        End If
        bToBeAssigned = True
        bIsAssigned = False
    End Sub

    Public Function ToScript(Optional ByRef strScript As String = "") As String
        Dim strTemp As String = ""

        If clsLeftParameter IsNot Nothing Then
            strTemp = strTemp & clsLeftParameter.ToScript(strScript)
        ElseIf clsLeftFunction IsNot Nothing Then
            strTemp = strTemp & clsLeftFunction.ToScript(strScript)
        ElseIf clsLeftOperator IsNot Nothing Then
            strTemp = strTemp & "(" & clsLeftOperator.ToScript(strScript) & ")"
        End If

        strTemp = strTemp & Chr(32) & strOperation & Chr(32)

        If clsRightParameter IsNot Nothing Then
            strTemp = strTemp & clsRightParameter.ToScript(strScript)
        ElseIf clsrightFunction IsNot Nothing Then
            strTemp = strTemp & clsRightFunction.ToScript(strScript)
        ElseIf clsrightOperator IsNot Nothing Then
            strTemp = strTemp & "(" & clsRightOperator.ToScript(strScript) & ")"
        End If

        If bToBeAssigned Then
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            Return strAssignTo
        Else
            Return strTemp
        End If
    End Function

    Public Sub SetParameter(bSetLeftNotRight As Boolean, Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)

        If bSetLeftNotRight Then
            clsLeftParameter = clsParam
            clsLeftFunction = clsRFunc
            clsLeftOperator = clsOp
        Else
            clsRightParameter = clsParam
            clsRightFunction = clsRFunc
            clsRightOperator = clsOp
        End If
        bIsAssigned = False
    End Sub
End Class