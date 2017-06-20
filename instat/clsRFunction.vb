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

Public Class RFunction
    Inherits RCodeStructure

    Public strRCommand As String
    Private strPackageName As String = ""

    Public Sub New()
        OnParametersChanged()
    End Sub

    Public Sub SetRCommand(strTemp As String)
        strRCommand = strTemp
        bIsAssigned = False
    End Sub

    Public Sub SetPackageName(strName As String)
        strPackageName = strName
    End Sub

    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        'Converting the RFunction into a string that when run in R gives the appropriate output
        Dim i As Integer
        'For method with OrderedIndices, replace clsParameters.count by Mybase.OrderedIndices.count and i by Mybase.OrderedIndices(i)

        'Parameters are sorted in the appropriate order and then the script is built.
        SortParameters()
        If strPackageName <> "" Then
            strTemp = strPackageName & "::"
        End If
        strTemp = strTemp & strRCommand & "("
        For i = 0 To clsParameters.Count - 1
            If i > 0 Then
                strTemp = strTemp & ", "
            End If
            strTemp = strTemp & clsParameters(i).ToScript(strScript)
        Next
        strTemp = strTemp & ")"
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

    Public Overrides Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        MyBase.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, bIncludeArgumentName, iPosition)
    End Sub

    Public Overrides Sub AddParameter(clsParam As RParameter)
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

    Public Overrides Sub ClearParameters()
        MyBase.ClearParameters()
    End Sub

    Public Overrides Function Clone() As RCodeStructure
        Dim clsRFunction As New RFunction
        Dim clsRParam As RParameter

        'RCode properties
        clsRFunction.strAssignTo = strAssignTo
        clsRFunction.strAssignToDataFrame = strAssignToDataFrame
        clsRFunction.strAssignToColumn = strAssignToColumn
        clsRFunction.strAssignToModel = strAssignToModel
        clsRFunction.strAssignToGraph = strAssignToGraph
        clsRFunction.strAssignToTable = strAssignToTable
        clsRFunction.bToBeAssigned = bToBeAssigned
        clsRFunction.bIsAssigned = bIsAssigned
        clsRFunction.bAssignToIsPrefix = bAssignToIsPrefix
        clsRFunction.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        clsRFunction.bInsertColumnBefore = bInsertColumnBefore
        clsRFunction.iNumberOfAddedParameters = iNumberOfAddedParameters
        clsRFunction.iPosition = iPosition
        clsRFunction.iCallType = iCallType
        clsRFunction.bExcludeAssignedFunctionOutput = bExcludeAssignedFunctionOutput
        clsRFunction.bClearFromGlobal = bClearFromGlobal
        clsRFunction.bToScriptAsRString = bToScriptAsRString
        For Each clsRParam In clsParameters
            clsRFunction.AddParameter(clsRParam.Clone)
        Next

        'RFunction specific properties
        clsRFunction.strPackageName = strPackageName
        clsRFunction.strRCommand = strRCommand

        Return clsRFunction
    End Function

    Public ReadOnly Property iParameterCount() As Integer
        Get
            Return clsParameters.Count
        End Get
    End Property
End Class