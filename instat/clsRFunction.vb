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
    Public clsParameters As New List(Of RParameter)
    Public strRCommand As String
    Public strAssignTo As String
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public strAssignToGraph As String
    Public bToBeAssigned As Boolean = False
    Public bIsAssigned As Boolean = False
    Public bAssignToIsPrefix As Boolean = False
    Public bAssignToColumnWithoutNames As Boolean = False
    Public bInsertColumnBefore As Boolean = False

    Public Sub New()
        RaiseEvent ParametersChanged()
    End Sub

    Public Event ParametersChanged()

    Public Sub SetRCommand(strTemp As String)
        'Warning/Question/Task: would be nice to clear the RParameters when the RCommand is changed (really changed)... Don't know if this would have any consequence elsewhere... Could comment it out if needed.
        If strRCommand <> strTemp Then
            ClearParameters()
        strRCommand = strTemp
        End If
        bIsAssigned = False 'Question to be discussed: Why is the bIsAssigned set to False when Parameters are cleared ?
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
        Me.bAssignToIsPrefix = bAssignToIsPrefix
        Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        Me.bInsertColumnBefore = bInsertColumnBefore
        bToBeAssigned = True
        bIsAssigned = False
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
        'Converting the RFunction into a string that when run in R gives the appropriate output
        Dim strTemp As String = ""
        Dim i As Integer
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
        'In case R has already stored the output of the function in the string of the appropriate name -AssignTo-, then that variable can be used as script.

        strTemp = strRCommand & "("

        For i = 0 To clsParameters.Count - 1
            If i > 0 Then
                strTemp = strTemp & ", "
            End If
            strTemp = strTemp & clsParameters(i).ToScript(strScript)
        Next
        strTemp = strTemp & ")"
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
                    clsAddModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
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

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
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
        Me.AddParameter(clsParam)
    End Sub

    Public Sub AddParameter(clsParam As RParameter)
        Dim i As Integer = -1
        If Not clsParameters Is Nothing Then
            If clsParam.strArgumentName IsNot Nothing Then
                i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(clsParam.strArgumentName))
            End If
        End If

        If i = -1 Then
            clsParameters.Add(clsParam)
        Else
            If clsParam.strArgumentValue IsNot Nothing Then
                clsParameters(i).SetArgumentValue(clsParam.strArgumentValue)
            End If
            If clsParam.clsArgumentFunction IsNot Nothing Then
                clsParameters(i).SetArgumentFunction(clsParam.clsArgumentFunction)
            End If
            If clsParam.clsArgumentOperator IsNot Nothing Then
                clsParameters(i).SetArgumentOperator(clsParam.clsArgumentOperator)
            End If
        End If
        bIsAssigned = False
        RaiseEvent ParametersChanged()
    End Sub

    Public Function GetParameter(strName As String) As RParameter
        Dim iTempIndex As Integer = -1
        If Not clsParameters Is Nothing Then
            iTempIndex = clsParameters.FindIndex(Function(x) x.strArgumentName = strName)
            If iTempIndex <> -1 Then
                Return clsParameters(iTempIndex)
            End If
        End If
        Return Nothing
    End Function

    Public Sub RemoveParameterByName(strArgName)
        Dim clsParam
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        RaiseEvent ParametersChanged()
    End Sub

    Public Sub ClearParameters()
        clsParameters.Clear()
        bIsAssigned = False 'Question to be discussed: Why is the bIsAssigned set to False when Parameters are cleared ?
        RaiseEvent ParametersChanged()
    End Sub

    Public Function Clone() As RFunction

        Dim clsRFunction As New RFunction
        Dim clsRParam As RParameter
        clsRFunction.strRCommand = strRCommand
        clsRFunction.strAssignTo = strAssignTo
        clsRFunction.strAssignToDataFrame = strAssignToDataFrame
        clsRFunction.strAssignToColumn = strAssignToColumn
        clsRFunction.strAssignToModel = strAssignToModel
        clsRFunction.strAssignToGraph = strAssignToGraph
        clsRFunction.bToBeAssigned = bToBeAssigned
        clsRFunction.bIsAssigned = bIsAssigned
        clsRFunction.bAssignToIsPrefix = bAssignToIsPrefix

        For Each clsRParam In clsParameters
            clsRFunction.AddParameter(clsRParam.Clone)
        Next

        Return clsRFunction

    End Function

    Public ReadOnly Property iParameterCount() As Integer
        Get
            Return clsParameters.Count
        End Get
    End Property
End Class