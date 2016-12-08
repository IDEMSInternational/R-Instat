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

    Public clsAdditionalParameters As New List(Of RParameter)
    Public bForceIncludeOperation As Boolean = True

    Public clsLeftParameter As New RParameter
    Public clsLeftOperator As ROperator
    Public clsLeftFunction As RFunction

    Public strOperation As String
    Public bBrackets As Boolean = True

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim bIncludeOperation As Boolean

        'may not need this anymore I believe we can get rid of include operator entirely
        bIncludeOperation = bForceIncludeOperation OrElse ((clsLeftParameter IsNot Nothing OrElse clsLeftFunction IsNot Nothing OrElse clsLeftOperator IsNot Nothing) AndAlso (clsAdditionalParameters.Count > 0))

        If clsLeftParameter IsNot Nothing Then
            'TODO Where should this be done?
            clsLeftParameter.bIncludeArgumentName = False
            strTemp = strTemp & clsLeftParameter.ToScript(strScript)
        ElseIf clsLeftFunction IsNot Nothing Then
            strTemp = strTemp & clsLeftFunction.ToScript(strScript)
        ElseIf clsLeftOperator IsNot Nothing Then
            If bBrackets Then
                strTemp = strTemp & "(" & clsLeftOperator.ToScript(strScript) & ")"
            Else
                strTemp = strTemp & clsLeftOperator.ToScript(strScript)
            End If
        End If

        For Each clsParam In clsAdditionalParameters
            If bIncludeOperation Then
                strTemp = strTemp & Chr(32) & strOperation & Chr(32)
            End If
            'TODO Where should this be done?
            clsParam.bIncludeArgumentName = False
            strTemp = strTemp & clsParam.ToScript(strScript)
        Next

        Return MyBase.ToScript(strScript, strTemp)
    End Function

    Public Sub SetParameter(bSetFirst As Boolean, Optional strParameterName As String = "Right", Optional strValue As String = "", Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        'Only one of the nonboolean parameters should ever be nonempty, but strParameterName.
        'bSetFirst decides wether we are modifying/adding the first parameter.
        'The default new parameter name is "Right", in case we are not modyfying the first parameter. Cannot be recursively adding parameters using default name as it will overwrite.
        If strValue <> "" Then
            clsParam = New RParameter
            clsParam.SetArgumentValue(strValue)
            clsParam.SetArgumentName(strParameterName)
        End If

        If bSetFirst Then
            clsLeftParameter = clsParam
            clsLeftFunction = clsRFunc
            clsLeftOperator = clsOp
        Else
            If Not IsNothing(clsParam) Then
                AddAdditionalParameter(clsParam)
            Else
                AddAdditionalParameter(strParameterName, strValue, clsRFunc, clsOp, bIncludeArgumentName)
            End If
            'clsRightParameter = clsParam
            'clsRightFunction = clsRFunc
            'clsRightOperator = clsOp
        End If
        bIsAssigned = False
    End Sub

    Public Sub AddAdditionalParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        Dim clsParam As New RParameter

        clsParam.SetArgumentName(strParameterName)
        If Not strParameterValue = "" Then
            clsParam.SetArgumentValue(strParameterValue)
        End If
        If Not clsRFunctionParameter Is Nothing Then
            clsParam.SetArgumentFunction(clsRFunctionParameter)
        End If
        If Not clsROperatorParameter Is Nothing Then
            clsParam.SetArgumentOperator(clsROperatorParameter)
        End If
        clsParam.bIncludeArgumentName = bIncludeArgumentName
        Me.AddAdditionalParameter(clsParam)

    End Sub

    Public Sub AddAdditionalParameter(clsParam As RParameter)

        Dim i As Integer = -1
        If Not clsAdditionalParameters Is Nothing Then
            If clsParam.strArgumentName IsNot Nothing Then
                i = clsAdditionalParameters.FindIndex(Function(x) x.strArgumentName.Equals(clsParam.strArgumentName))
            End If
        End If

        If i = -1 Then
            clsAdditionalParameters.Add(clsParam)
        Else
            If clsParam.strArgumentValue IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentValue(clsParam.strArgumentValue)
            End If
            If clsParam.clsArgumentFunction IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentFunction(clsParam.clsArgumentFunction)
            End If
            If clsParam.clsArgumentOperator IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentOperator(clsParam.clsArgumentOperator)
            End If
        End If
        bIsAssigned = False
    End Sub

    Public Overrides Function GetParameter(strName As String) As RParameter
        Dim iTempIndex As Integer = -1
        If Not clsAdditionalParameters Is Nothing Then
            iTempIndex = clsAdditionalParameters.FindIndex(Function(x) x.strArgumentName = strName)
            If iTempIndex <> -1 Then
                Return clsAdditionalParameters(iTempIndex)
            End If
        End If
        Return Nothing
    End Function

    Public Sub RemoveParameterByName(strArgName)
        Dim clsParam
        If Not clsAdditionalParameters Is Nothing Then
            clsParam = clsAdditionalParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsAdditionalParameters.Remove(clsParam)
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveParameter(bRemoveLeftNotRight As Boolean)
        If bRemoveLeftNotRight Then
            clsLeftParameter = Nothing
            clsLeftFunction = Nothing
            clsLeftOperator = Nothing
        Else
            RemoveParameterByName("Right")
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveAllAdditionalParameters()
        clsAdditionalParameters.Clear()
    End Sub

    Public Sub RemoveAllParameters()
        RemoveParameter(True)
        'RemoveParameter(False)
        RemoveAllAdditionalParameters()
    End Sub

    Public Function Clone() As ROperator
        Dim clsTempROperator As New ROperator
        Dim clsAdditionalParams As RParameter

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

        If clsLeftFunction IsNot Nothing Then
            clsTempROperator.clsLeftFunction = clsLeftFunction.Clone
        End If
        If clsLeftOperator IsNot Nothing Then
            clsTempROperator.clsLeftOperator = clsLeftOperator.Clone
        End If
        If clsLeftParameter IsNot Nothing Then
            clsTempROperator.clsLeftParameter = clsLeftParameter.Clone
        End If
        For Each clsAdditionalParams In clsAdditionalParameters
            clsTempROperator.AddAdditionalParameter(clsAdditionalParams.Clone)
        Next

        Return clsTempROperator
    End Function
End Class