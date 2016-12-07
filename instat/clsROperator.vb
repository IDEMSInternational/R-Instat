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
    Public bForceIncludeOperation As Boolean = True
    Public strOperation As String
    Public bBrackets As Boolean = True

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String

        Dim i As Integer
        'Alternative method using OrderedIndices.
        'If MyBase.OrderedIndices.Count > 0 Then
        'clsParameters(MyBase.OrderedIndices(0)).bIncludeArgumentName = False
        'If clsParameters(MyBase.OrderedIndices(0)).bIsOperator AndAlso bBrackets Then
        'strTemp = strTemp & "(" & clsParameters(MyBase.OrderedIndices(0)).ToScript(strScript) & ")"
        'Else
        'strTemp = strTemp & clsParameters(MyBase.OrderedIndices(0)).ToScript(strScript)
        'End If
        'End If
        'For i = 1 To MyBase.OrderedIndices.Count - 1
        'strTemp = strTemp & Chr(32) & strOperation & Chr(32)
        'clsParameters(MyBase.OrderedIndices(i)).bIncludeArgumentName = False
        'strTemp = strTemp & clsParameters(MyBase.OrderedIndices(i)).ToScript(strScript)
        'Next

        'Parameters are sorted in the appropriate order and then the script is built.
        SortParameters()
        If clsParameters(0) IsNot Nothing Then
            clsParameters(0).bIncludeArgumentName = False
            If clsParameters(0).bIsOperator AndAlso bBrackets Then
                strTemp = strTemp & "(" & clsParameters(0).ToScript(strScript) & ")"
            Else
                strTemp = strTemp & clsParameters(0).ToScript(strScript)
            End If
        Else
            'message
        End If

        For Each clsParam In clsParameters.GetRange(1, clsParameters.Count - 1)
            'If bIncludeOperation Then
            strTemp = strTemp & Chr(32) & strOperation & Chr(32)
            clsParam.bIncludeArgumentName = False
            strTemp = strTemp & clsParam.ToScript(strScript)
        Next
        Return MyBase.ToScript(strScript, strTemp)
    End Function

    Public Overrides Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional clsParam As RParameter = Nothing, Optional iPosition As Integer = 0)
        bIncludeArgumentName = False
        MyBase.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, bIncludeArgumentName, clsParam, iPosition)
    End Sub
    Public Overrides Sub AddParameter(clsParam As RParameter, Optional iPosition As Integer = 0)
        MyBase.AddParameter(clsParam, iPosition)
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

    Public Sub RemoveAllAdditionalParameters() 'Needs to be changed if using OrderedIndices method.
        SortParameters() 'This is used to bring the parameter with position 1 to the front, then clear all the others using range.
        If clsParameters.Count > 1 Then
            clsParameters.RemoveRange(1, clsParameters.Count - 1)
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