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

    Public clsAdditionalParameters As New List(Of RParameter)

    Public clsLeftParameter As New RParameter
    Public clsLeftOperator As ROperator
    Public clsLeftFunction As RFunction

    'Public clsRightParameter As New RParameter
    'Public clsRightOperator As ROperator
    'Public clsRightFunction As RFunction

    Public strOperation As String
    Public bBrackets As Boolean = True

    Public strAssignTo As String
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public strAssignToGraph As String
    Public bToBeAssigned As Boolean = False
    Public bIsAssigned As Boolean = False
    Public bForceIncludeOperation As Boolean = True
    Public bAssignToIsPrefix As Boolean = False
    Public bAssignToColumnWithoutNames As Boolean = False
    Public bInsertColumnBefore As Boolean = False

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False)
        strAssignTo = strTemp
        If Not strTempDataframe = "" Then
            strAssignToDataFrame = strTempDataframe
            If Not strTempColumn = "" Then
                strAssignToColumn = strTempColumn
            End If
        End If
        If Not strTempModel = "" Then
            strAssignToModel = strTempModel
        End If
        If Not strTempGraph = "" Then
            strAssignToGraph = strTempGraph
        End If
        bToBeAssigned = True
        bIsAssigned = False
        Me.bAssignToIsPrefix = bAssignToIsPrefix
        Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        Me.bInsertColumnBefore = bInsertColumnBefore
    End Sub

    Public Sub RemoveAssignTo()
        strAssignTo = ""
        strAssignToDataFrame = ""
        strAssignToColumn = ""
        strAssignToModel = ""
        bToBeAssigned = False
        bIsAssigned = False
    End Sub

    Public Function ToScript(Optional ByRef strScript As String = "") As String
        Dim strTemp As String = ""
        Dim bIncludeOperation As Boolean
        Dim clsAddColumns As New RFunction
        Dim clsGetColumns As New RFunction
        Dim clsAddData As New RFunction
        Dim clsGetData As New RFunction
        Dim clsAddModels As New RFunction
        Dim clsGetModels As New RFunction
        Dim clsAddGraphs As New RFunction
        Dim clsGetGraphs As New RFunction
        Dim clsDataList As New RFunction

        If bIsAssigned Then
            Return (strAssignTo)
        End If

        'may not need this anymore I believe we can get rid of include operator entirely
        bIncludeOperation = bForceIncludeOperation OrElse ((clsLeftParameter IsNot Nothing OrElse clsLeftFunction IsNot Nothing OrElse clsLeftOperator IsNot Nothing) AndAlso (clsAdditionalParameters.Count > 0))

        If clsLeftParameter IsNot Nothing Then
            strTemp = strTemp & clsLeftParameter.ToScript(strScript, False)
        ElseIf clsLeftFunction IsNot Nothing Then
            strTemp = strTemp & clsLeftFunction.ToScript(strScript)
        ElseIf clsLeftOperator IsNot Nothing Then
            If bBrackets Then
                strTemp = strTemp & "(" & clsLeftOperator.ToScript(strScript) & ")"
            Else
                strTemp = strTemp & clsLeftOperator.ToScript(strScript)
            End If
        End If

        'If bIncludeOperation Then
        '    strTemp = strTemp & Chr(32) & strOperation & Chr(32)
        'End If

        'If clsRightParameter IsNot Nothing Then
        '    strTemp = strTemp & clsRightParameter.ToScript(strScript, False)
        'ElseIf clsrightFunction IsNot Nothing Then
        '    strTemp = strTemp & clsRightFunction.ToScript(strScript)
        'ElseIf clsrightOperator IsNot Nothing Then
        '    strTemp = strTemp & "(" & clsRightOperator.ToScript(strScript) & ")"
        'End If

        For Each clsParam In clsAdditionalParameters
            If bIncludeOperation Then
                strTemp = strTemp & Chr(32) & strOperation & Chr(32)
            End If
            strTemp = strTemp & clsParam.ToScript(strScript, False)
        Next

        If bToBeAssigned Then
            If Not frmMain.clsRLink.bInstatObjectExists Then
                frmMain.clsRLink.CreateNewInstatObject()
            End If
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            If Not strAssignToDataFrame = "" AndAlso (Not strAssignToColumn = "" OrElse bAssignToColumnWithoutNames) Then
                clsAddColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
                clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                If Not bAssignToColumnWithoutNames Then
                    clsAddColumns.AddParameter("col_name", Chr(34) & strAssignToColumn & Chr(34))
                End If
                clsAddColumns.AddParameter("col_data", strAssignTo)
                If bAssignToIsPrefix Then
                    clsAddColumns.AddParameter("use_col_name_as_prefix", "TRUE")
                Else
                    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                        clsAddColumns.AddParameter("use_col_name_as_prefix", "FALSE")
                    End If
                End If
                If bInsertColumnBefore Then
                    clsAddColumns.AddParameter("before", "TRUE")
                Else
                    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                        clsAddColumns.AddParameter("before", "FALSE")
                    End If
                End If
                strScript = strScript & clsAddColumns.ToScript() & vbCrLf

                clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsGetColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                clsGetColumns.AddParameter("col_name", Chr(34) & strAssignToColumn & Chr(34))
                strAssignTo = clsGetColumns.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToModel = "" Then
                clsAddModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_model")
                clsAddModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                clsAddModels.AddParameter("model", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddModels.ToScript() & vbCrLf

                clsGetModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                clsGetModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                strAssignTo = clsGetModels.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToGraph = "" Then
                clsAddGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_graph")
                clsAddGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                clsAddGraphs.AddParameter("graph", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddGraphs.ToScript() & vbCrLf

                clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
                clsGetGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                strAssignTo = clsGetGraphs.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            ElseIf Not strAssignToDataFrame = "" Then
                clsAddData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
                clsDataList.SetRCommand("list")
                clsDataList.AddParameter(strAssignToDataFrame, strAssignTo)
                clsAddData.AddParameter("data_tables", clsRFunctionParameter:=clsDataList)
                strScript = strScript & clsAddData.ToScript() & vbCrLf

                clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                strAssignTo = clsGetData.ToScript()

                bIsAssigned = True
                bToBeAssigned = False
            End If
            Return strAssignTo
        Else
            Return strTemp
        End If

    End Function

    Public Sub SetParameter(bSetFirst As Boolean, Optional strParameterName As String = "Right", Optional strValue As String = "", Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)

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
                AddAdditionalParameter(strParameterName, strValue, clsRFunc, clsOp)
            End If
            'clsRightParameter = clsParam
            'clsRightFunction = clsRFunc
            'clsRightOperator = clsOp
        End If
        bIsAssigned = False
    End Sub

    Public Sub AddAdditionalParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing)
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

    Public Function GetParameter(strName As String) As RParameter
        If Not clsAdditionalParameters Is Nothing Then
            Return clsAdditionalParameters.Find(Function(x) x.strArgumentName = strName)
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