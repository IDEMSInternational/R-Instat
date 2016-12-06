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
    Public clsArgument As RCodeStructure
    Public bIsFunction As Boolean = False
    Public bIsOperator As Boolean = False
    Public bIsString As Boolean = False
    Public bIncludeArgumentName As Boolean = True

    Public Sub SetArgumentName(strTemp As String)
        strArgumentName = strTemp
    End Sub

    Public Sub SetArgumentValue(strTemp As String)
        strArgumentValue = strTemp
        bIsFunction = False
        bIsOperator = False
        bIsString = True
    End Sub

    Public Sub SetArgument(clsArg As RCodeStructure)
        clsArgument = clsArg
        bIsString = False
        If TypeOf (clsArg) Is RFunction Then
            bIsFunction = True
            bIsOperator = False
        ElseIf TypeOf (clsArg) Is ROperator Then
            bIsOperator = True
            bIsFunction = False
        Else
            'message
            bIsOperator = False
            bIsFunction = False
        End If
    End Sub

    Public Function ToScript(ByRef strScript As String) As String
        Dim strRet As String = ""

        If strArgumentName <> "" AndAlso bIncludeArgumentName Then
            strRet = strArgumentName & "="
        End If
        If bIsFunction OrElse bIsOperator Then
            strRet = strRet & clsArgument.ToScript(strScript)
        ElseIf bIsString Then
            strRet = strRet & strArgumentValue
        ElseIf clsArgument IsNot Nothing Then
            strRet = strRet & clsArgument.ToScript(strScript)
            'message
        Else
            'message
        End If
        Return strRet
    End Function

    Public Function Clone() As RParameter
        Dim clsTempRParam As New RParameter

        clsTempRParam.strArgumentName = strArgumentName
        clsTempRParam.strArgumentValue = strArgumentValue
        clsTempRParam.bIsFunction = bIsFunction
        clsTempRParam.bIsOperator = bIsOperator
        clsTempRParam.bIsString = bIsString
        If clsArgument IsNot Nothing Then
            clsTempRParam.clsArgument = clsArgument.Clone
        End If
        Return clsTempRParam
    End Function
End Class