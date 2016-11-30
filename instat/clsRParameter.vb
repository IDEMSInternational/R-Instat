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

Public Class RParameter
    Public strArgumentName As String
    Public strArgumentValue As String
    Public clsArgumentFunction As RFunction
    Public clsArgumentOperator As ROperator
    Public bIsFunction As Boolean = False
    Public bIsOperator As Boolean = False
    Public bIncludeArgumentName As Boolean = True

    Public Sub SetArgumentName(strTemp As String)
        strArgumentName = strTemp
    End Sub

    Public Sub SetArgumentValue(strTemp As String)
        strArgumentValue = strTemp
        bIsFunction = False
        bIsOperator = False
    End Sub

    Public Sub SetArgumentFunction(clsFunc As RFunction)
        clsArgumentFunction = clsFunc
        bIsFunction = True
        bIsOperator = False
    End Sub

    Public Sub SetArgumentOperator(clsROp As ROperator)
        clsArgumentOperator = clsROp
        bIsFunction = False
        bIsOperator = True
    End Sub

    Public Function ToScript(ByRef strScript As String) As String
        Dim strRet As String = ""

        If strArgumentName <> "" AndAlso bIncludeArgumentName Then
            strRet = strArgumentName & "="
        End If
        If bIsFunction Then
            strRet = strRet & clsArgumentFunction.ToScript(strScript)
        ElseIf bIsOperator Then
            strRet = strRet & clsArgumentOperator.ToScript(strScript)
        Else
            strRet = strRet & strArgumentValue
        End If
        Return strRet
    End Function

    Public Function Clone() As RParameter
        Dim clsTempRParam As New RParameter

        clsTempRParam.strArgumentName = strArgumentName
        clsTempRParam.strArgumentValue = strArgumentValue
        clsTempRParam.bIsFunction = bIsFunction
        clsTempRParam.bIsOperator = bIsOperator
        If clsArgumentFunction IsNot Nothing Then
            clsTempRParam.clsArgumentFunction = clsArgumentFunction.Clone
        End If
        If clsArgumentOperator IsNot Nothing Then
            clsTempRParam.clsArgumentOperator = clsArgumentOperator.Clone
        End If
        Return clsTempRParam
    End Function
End Class