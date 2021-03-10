' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class Condition
    Private bIsParameterValues As Boolean = False
    Private bIsParameterPresent As Boolean = False
    Private bIsFunctionNames As Boolean = False
    Private bIsParameterType As Boolean = False
    Private bIsParameterValuesRFunctionNames As Boolean = False
    Private bIsRSyntaxFunctionNames As Boolean = False
    Private bIsRSyntaxContainsCode As Boolean = False
    Private bIsRCodeRFunction As Boolean = False
    Private strParameterType As String = ""
    Private strParameterName As String = ""
    Private lstValues As List(Of String) = New List(Of String)
    Private bIsPositive As Boolean = True

    Public Sub SetParameterPresentNames(strParamName As String, Optional bNewIsPositive As Boolean = True)
        SetParameterPresentNames(New List(Of String)({strParamName}), bNewIsPositive)
    End Sub

    Public Sub SetParameterPresentNames(lstParamName As List(Of String), Optional bNewIsPositive As Boolean = True)
        strParameterName = ""
        lstValues = lstParamName
        bIsParameterPresent = True
        bIsParameterValues = False
        bIsFunctionNames = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValues(strParamName As String, lstParamValues As List(Of String), Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        lstValues = lstParamValues
        bIsParameterValues = True
        bIsParameterPresent = False
        bIsFunctionNames = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValues(strParamName As String, strParamValues As String, Optional bNewIsPositive As Boolean = True)
        SetParameterValues(strParamName, New List(Of String)({strParamValues}), bNewIsPositive)
    End Sub

    Public Sub SetParameterValuesRFunctionNames(strParamName As String, lstRCodeNames As List(Of String), Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        lstValues = lstRCodeNames
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsFunctionNames = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = True
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValuesRFunctionNames(strParamName As String, strRCodeNames As String, Optional bNewIsPositive As Boolean = True)
        SetParameterValuesRFunctionNames(strParamName, New List(Of String)({strRCodeNames}), bNewIsPositive)
    End Sub

    Public Sub SetFunctionName(strFuncName As String, Optional bNewIsPositive As Boolean = True)
        SetFunctionNamesMultiple(New List(Of String)({strFuncName}), bNewIsPositive)
    End Sub

    Public Sub SetFunctionNamesMultiple(lstFuncNames As List(Of String), Optional bNewIsPositive As Boolean = True)
        lstValues = lstFuncNames
        bIsFunctionNames = True
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterType(strType As String, strParamName As String, Optional bNewIsPositive As Boolean = True)
        bIsFunctionNames = False
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = True
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        bIsParameterValuesRFunctionNames = False
        strParameterName = strParamName
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
        If Not {"string", "RFunction", "ROperator"}.Contains(strType) Then
            MsgBox("Developer error: strType must be either string, RFunction or ROperator.")
            strParameterType = ""
        Else
            strParameterType = strType
        End If
    End Sub

    Public Sub SetRSyntaxFunctionNamesMultiple(lstFuncNames As List(Of String), Optional bNewIsPositive As Boolean = True)
        lstValues = lstFuncNames
        bIsFunctionNames = False
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = True
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetRSyntaxFunctionName(strFuncName As String, Optional bNewIsPositive As Boolean = True)
        SetRSyntaxFunctionNamesMultiple(New List(Of String)({strFuncName}), bNewIsPositive)
    End Sub

    Public Sub SetRSyntaxContainsCode(Optional bNewIsPositive As Boolean = True)
        lstValues = New List(Of String)
        bIsFunctionNames = False
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = True
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetRCodeIsRFunction(Optional bNewIsPositive As Boolean = True)
        lstValues = New List(Of String)
        bIsFunctionNames = False
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = False
        bIsRSyntaxFunctionNames = False
        bIsRSyntaxContainsCode = False
        strParameterType = ""
        bIsParameterValuesRFunctionNames = False
        bIsRCodeRFunction = True
        bIsPositive = bNewIsPositive
    End Sub

    Public Function IsSatisfied(clsRCode As RCodeStructure, Optional clsParameter As RParameter = Nothing, Optional clsRSyntax As RSyntax = Nothing) As Boolean
        Dim clsTempParam As RParameter
        Dim clsTempFunc As RFunction

        If bIsParameterValues Then
            If clsParameter IsNot Nothing AndAlso clsParameter.strArgumentName IsNot Nothing AndAlso clsParameter.strArgumentName = strParameterName Then
                clsTempParam = clsParameter
            Else
                clsTempParam = clsRCode.GetParameter(strParameterName)
            End If
            If clsTempParam.bIsString Then
                Return (bIsPositive = (clsTempParam IsNot Nothing AndAlso clsTempParam.strArgumentValue IsNot Nothing AndAlso lstValues.Contains(clsTempParam.strArgumentValue)))

            Else
                Return (bIsPositive = (clsTempParam IsNot Nothing AndAlso clsTempParam.strArgumentValue Is Nothing AndAlso lstValues.Contains(clsTempParam.clsArgumentCodeStructure.ToScript)))
            End If
        ElseIf bIsParameterPresent Then
            Return (bIsPositive = lstValues.Any(Function(x) clsRCode.ContainsParameter(x)))
        ElseIf bIsFunctionNames Then
            If TypeOf clsRCode Is RFunction Then
                clsTempFunc = CType(clsRCode, RFunction)
                Return (bIsPositive = lstValues.Contains(clsTempFunc.strRCommand))
            Else
                Return False
            End If
        ElseIf bIsParameterType Then
            If Not clsRCode.ContainsParameter(strParameterName) Then
                Return Not bIsPositive
            Else
                clsTempParam = clsRCode.GetParameter(strParameterName)
                Select Case strParameterType
                    Case "string"
                        Return (bIsPositive = clsTempParam.bIsString)
                    Case "RFunction"
                        Return (bIsPositive = clsTempParam.bIsFunction)
                    Case "ROperator"
                        Return (bIsPositive = clsTempParam.bIsOperator)
                    Case Else
                        MsgBox("Developer error: strType must be either string, RFunction or ROperator.")
                        Return False
                End Select
            End If
        ElseIf bIsParameterValuesRFunctionNames Then
            If clsParameter IsNot Nothing Then
                If clsParameter.strArgumentName = strParameterName Then
                    clsTempParam = clsParameter
                Else
                    clsTempParam = clsRCode.GetParameter(strParameterName)
                End If
            Else
                clsTempParam = clsRCode.GetParameter(strParameterName)
            End If
            If Not (clsTempParam IsNot Nothing AndAlso clsTempParam.bIsFunction AndAlso clsTempParam.clsArgumentCodeStructure IsNot Nothing) Then
                Return Not bIsPositive
            End If
            Return ((bIsPositive = lstValues.Contains(DirectCast(clsTempParam.clsArgumentCodeStructure, RFunction).strRCommand)))
        ElseIf bIsRSyntaxFunctionNames Then
            If clsRSyntax IsNot Nothing Then
                Return (bIsPositive = lstValues.Any(Function(x) clsRSyntax.GetFunctionNames().Contains(x)))
            Else
                Return Not bIsPositive
            End If
        ElseIf bIsRSyntaxContainsCode Then
            If clsRSyntax IsNot Nothing AndAlso clsRCode IsNot Nothing Then
                Return (bIsPositive = clsRSyntax.ContainsCode(clsRCode))
            Else
                Return Not bIsPositive
            End If
        ElseIf bIsRCodeRFunction Then
            Return (bIsPositive = (TypeOf clsRCode Is RFunction))
        Else
            Return True
        End If
    End Function
End Class
