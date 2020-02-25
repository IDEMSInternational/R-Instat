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

' deals with R-commands of the form: __+__
Public Class ROperator
    Inherits RCodeStructure
    Public bForceIncludeOperation As Boolean = False
    Public strOperation As String
    Public bBrackets As Boolean = True
    ' This could be replaced by bBrackets once tested
    Public bAllBrackets As Boolean = False
    Public bSpaceAroundOperation As Boolean = True

    Public Sub New(Optional strOp As String = "", Optional bBracketsTemp As Boolean = True)
        SetOperation(strOp, bBracketsTemp)
    End Sub

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim strAdjustedOperation As String
        'TODO SJL Parts of this function seem to duplicate the ToScript function in RFunction. Refactor?

        'Parameters are sorted in the appropriate order and then the script is built.
        SortParameters()
        'if needed, put spaces around assignment operator (e.g. " <- ")
        If bSpaceAroundOperation Then
            strAdjustedOperation = Chr(32) & strOperation & Chr(32)
        Else
            strAdjustedOperation = strOperation
        End If
        'if operator has parameters
        If clsParameters.Count > 0 Then
            If clsParameters(0) IsNot Nothing Then
                'if first parameter is an operator that needs brackets, then add brackets
                If clsParameters(0).bIsOperator AndAlso bBrackets Then
                    strTemp = strTemp & "(" & clsParameters(0).ToScript(strScript) & ")"
                Else 'else just add the parameter without brackets
                    strTemp = strTemp & clsParameters(0).ToScript(strScript)
                End If
                'If there's only one parameter and bForceIncludeOperation then we include the operator
                'The position of the operator depends on the parameter position
                If bForceIncludeOperation AndAlso clsParameters.Count = 1 Then
                    If clsParameters(0).Position = 0 Then
                        strTemp = strTemp & strAdjustedOperation
                    Else
                        strTemp = strAdjustedOperation & strTemp
                    End If
                End If
            Else
                'TODO message
            End If
            'for each parameter (starting from 2nd parameter)
            For Each clsParam In clsParameters.GetRange(1, clsParameters.Count - 1)
                strTemp = strTemp & strAdjustedOperation
                'if parameter is an operator that needs brackets, then add brackets
                If bAllBrackets AndAlso (clsParam.bIsFunction OrElse clsParam.bIsOperator) Then
                    strTemp = strTemp & "(" & clsParam.ToScript(strScript) & ")"
                Else 'else just add the parameter without brackets
                    strTemp = strTemp & clsParam.ToScript(strScript) 'e.g. set 'strTemp' to "data_book <- DataBook$new()"
                End If
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

    Public Overrides Sub Clear()
        SetOperation("")
        bForceIncludeOperation = False
        MyBase.Clear()
    End Sub

    Public Overrides Function Clone() As RCodeStructure
        Dim clsTempROperator As New ROperator
        Dim clsRParam As RParameter

        'RCode properties
        clsTempROperator.strAssignTo = strAssignTo
        clsTempROperator.strAssignToDataFrame = strAssignToDataFrame
        clsTempROperator.strAssignToColumn = strAssignToColumn
        clsTempROperator.strAssignToModel = strAssignToModel
        clsTempROperator.strAssignToGraph = strAssignToGraph
        clsTempROperator.strAssignToTable = strAssignToTable
        clsTempROperator.bToBeAssigned = bToBeAssigned
        clsTempROperator.bIsAssigned = bIsAssigned
        clsTempROperator.bAssignToIsPrefix = bAssignToIsPrefix
        clsTempROperator.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        clsTempROperator.bInsertColumnBefore = bInsertColumnBefore
        clsTempROperator.iNumberOfAddedParameters = iNumberOfAddedParameters
        clsTempROperator.iPosition = iPosition
        clsTempROperator.iCallType = iCallType
        clsTempROperator.bExcludeAssignedFunctionOutput = bExcludeAssignedFunctionOutput
        clsTempROperator.bClearFromGlobal = bClearFromGlobal
        clsTempROperator.bToScriptAsRString = bToScriptAsRString
        clsTempROperator.Tag = Tag
        For Each clsRParam In clsParameters
            clsTempROperator.AddParameter(clsRParam.Clone())
        Next

        'ROperator specific properties
        clsTempROperator.bForceIncludeOperation = bForceIncludeOperation
        clsTempROperator.strOperation = strOperation
        clsTempROperator.bBrackets = bBrackets
        clsTempROperator.bAllBrackets = bAllBrackets
        clsTempROperator.bSpaceAroundOperation = bSpaceAroundOperation

        Return clsTempROperator
    End Function
End Class