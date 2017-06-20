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
    Inherits RCodeStructure
    Public bForceIncludeOperation As Boolean = False
    Public strOperation As String
    Public bBrackets As Boolean = True

    Public Sub New(Optional strOp As String = "", Optional bBracketsTemp As Boolean = True)
        SetOperation(strOp, bBracketsTemp)
    End Sub

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        'Parameters are sorted in the appropriate order and then the script is built.
        SortParameters()
        If clsParameters(0) IsNot Nothing Then
            If clsParameters(0).bIsOperator AndAlso bBrackets Then
                strTemp = strTemp & "(" & clsParameters(0).ToScript(strScript) & ")"
            Else
                strTemp = strTemp & clsParameters(0).ToScript(strScript)
            End If
            'If there's only one parameter and bForceIncludeOperation then we include the operator
            'The position of the operator depends on the parameter position
            If bForceIncludeOperation AndAlso clsParameters.Count = 1 Then
                If clsParameters(0).Position = 0 Then
                    strTemp = strTemp & Chr(32) & strOperation & Chr(32)
                Else
                    strTemp = Chr(32) & strOperation & Chr(32) & strTemp
                End If
            End If
        Else
            'message
        End If
        For Each clsParam In clsParameters.GetRange(1, clsParameters.Count - 1)
            'If bIncludeOperation Then
            strTemp = strTemp & Chr(32) & strOperation & Chr(32)
            strTemp = strTemp & clsParam.ToScript(strScript)
        Next
        If bToScriptAsRString Then
            'TODO should also check assignment of parameters
            If bToBeAssigned OrElse bIsAssigned Then
                MsgBox("Developer error: Using bToScriptAsRString = True when RFunction is assigned will not produce the correct script. Remove assignment to use this options correctly.")
            End If
            'Cannot have double quotes ("") in the string because strTemp will be wrapped with ""
            'In most cases signle quotes (') will give same functionality, though it's preferable to avoid this when constructing the RFunction
            strTemp = strTemp.Replace(Chr(34), Chr(39))
            strTemp = Chr(34) & strTemp & Chr(34)
        End If
        Return MyBase.ToScript(strScript, strTemp)
    End Function

    Public Overrides Sub AddParameter(clsParam As RParameter)
        clsParam.bIncludeArgumentName = False 'We don't want to allow names in operator parameters...
        MyBase.AddParameter(clsParam)
    End Sub

    Public Overrides Function GetParameter(strName As String) As RParameter
        Dim iTempIndex As Integer = -1
        If Not clsParameters Is Nothing Then
            iTempIndex = clsParameters.FindIndex(Function(x) x.strArgumentName = strName)
            If iTempIndex <> -1 Then
                Return clsParameters(iTempIndex)
            End If
        End If
        Return Nothing
    End Function

    Public Sub RemoveAllAdditionalParameters() 'Needs to be edited once first things merged...
        SortParameters() 'This is used to bring the parameter with position 0 to the front if it exists, then clear all the others using range.
        If clsParameters(0).Position = 0 Then
            If clsParameters.Count > 1 Then
                clsParameters.RemoveRange(1, clsParameters.Count - 1)
            End If
        Else
            clsParameters.Clear()
        End If
        OnParametersChanged()
    End Sub

    Public Overrides Function Clone() As RCodeStructure
        Dim clsTempROperator As New ROperator

        clsTempROperator.strOperation = strOperation
        clsTempROperator.bBrackets = bBrackets
        clsTempROperator.strAssignTo = strAssignTo
        clsTempROperator.strAssignToDataFrame = strAssignToDataFrame
        clsTempROperator.strAssignToColumn = strAssignToColumn
        clsTempROperator.strAssignToModel = strAssignToModel
        clsTempROperator.strAssignToGraph = strAssignToGraph
        clsTempROperator.bToBeAssigned = bToBeAssigned
        clsTempROperator.bIsAssigned = bIsAssigned
        clsTempROperator.bForceIncludeOperation = bForceIncludeOperation
        clsTempROperator.bAssignToIsPrefix = bAssignToIsPrefix

        For Each clsParam As RParameter In MyBase.clsParameters
            clsTempROperator.AddParameter(clsParam.Clone)
        Next
        Return clsTempROperator
    End Function
End Class