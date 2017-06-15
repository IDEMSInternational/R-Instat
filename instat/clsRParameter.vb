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
    'strArgumentName is, in the function case, the name of the parameter as in R. However, in general the name will not always be displayed in the script (depends on value of bIncludeParameterName below) and is merely used to distinguish different parameters.
    Public strArgumentName As String
    'The parameter can either take a simple value in the form of a string, or take as value another RFunction or ROperator (then stored as an RCodeStructure).
    Public strArgumentValue As String
    Public clsArgumentCodeStructure As RCodeStructure
    'The three next booleans keep track of what type of value is stored.
    Public bIsFunction As Boolean = False
    Public bIsOperator As Boolean = False
    Public bIsString As Boolean = False
    'iPosition determines the position this parameter should take among other parameters of an Operator or Function. If iPosition is 0, then it is part of the unordered parameters that are added after the ordered ones. 
    'Note, it is allowed to have gaps in the positions: parameters with positions a 0, b 2, c 5, d 3, e 0 will be sorted as b d c (a e). See CompareParametersPosition in clsRCodeStructure.
    Private iPosition As Integer = -1
    'See strArgumentName
    Public bIncludeArgumentName As Boolean = True

    Public Sub New()
    End Sub

    Public Sub New(strParameterName As String, Optional iNewPosition As Integer = -1)
        SetArgumentName(strParameterName)
        Position = iNewPosition
    End Sub

    ''Public Event PositionChanged()

    Public Property Position As Integer
        'Position is the property associated to the iPosition.
        Get
            Return iPosition
        End Get
        Set(ByVal Value As Integer)
            If Value <> iPosition Then
                iPosition = Value
                ''RaiseEvent PositionChanged()
            End If
        End Set
    End Property

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
        clsArgumentCodeStructure = clsArg
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

    Public Sub ClearAllArguments()
        strArgumentValue = ""
        clsArgumentCodeStructure = Nothing
        bIsString = False
        bIsOperator = False
        bIsFunction = False
    End Sub

    Public Function ToScript(ByRef strScript As String) As String
        Dim strRet As String = ""

        If strArgumentName <> "" AndAlso bIncludeArgumentName Then
            strRet = strArgumentName & "="
        End If
        If bIsFunction OrElse bIsOperator Then
            strRet = strRet & clsArgumentCodeStructure.ToScript(strScript)
        ElseIf bIsString Then
            strRet = strRet & strArgumentValue
        ElseIf clsArgumentCodeStructure IsNot Nothing Then
            strRet = strRet & clsArgumentCodeStructure.ToScript(strScript)
            'message
        Else
            'message
        End If
        Return strRet
    End Function

    Public Function HasValue() As Boolean
        If bIsString Then
            Return strArgumentValue IsNot Nothing
        ElseIf bIsFunction OrElse bIsOperator Then
            Return clsArgumentCodeStructure IsNot Nothing
        Else
            Return False
        End If
    End Function

    Public Function Clone() As RParameter
        Dim clsTempRParam As New RParameter

        clsTempRParam.strArgumentName = strArgumentName
        clsTempRParam.strArgumentValue = strArgumentValue
        clsTempRParam.bIsFunction = bIsFunction
        clsTempRParam.bIsOperator = bIsOperator
        clsTempRParam.bIsString = bIsString
        clsTempRParam.iPosition = iPosition
        clsTempRParam.bIncludeArgumentName = bIncludeArgumentName
        If clsArgumentCodeStructure IsNot Nothing Then
            clsTempRParam.clsArgumentCodeStructure = clsArgumentCodeStructure.Clone
        End If
        Return clsTempRParam
    End Function
End Class