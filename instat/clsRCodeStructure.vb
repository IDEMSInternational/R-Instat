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

Public Class RCodeStructure
    'Decides whether or not the output of the R-command should be part of the script or not, in the case this has already been assigned.
    Public strAssignTo As String
    'strAssignTo is the name that should be used to assign in R the output of the main (Base) R-command.
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public strAssignToGraph As String
    'These AssingTo's are only relevant in the string case, as RFunction and ROperator have internal equivalents.
    'If they are empty, the output Of the command Is Not linked To an R-instat object.
    'If they are non-empty, that gives the name of the R-instat Object fields it needs to be linked with.
    Public bToBeAssigned As Boolean = False
    'bToBeAssigned is a boolean telling whether or not, AT THE CURRENT STAGE of running code within R, the output of the Base R-command NEEDS TO BE assigned to 
    ' - the variable With the appropriate name: strAssignTo, 
    ' - And potentially assigned to elements in an R-instat object, if specified in the AssignToDataFrame,... parameters.
    Public bIsAssigned As Boolean = False
    'bIsAssigned tells blindly whether or not the output of the R-command has been assigned and, if relevant, the link with the appropriate R-instat object has been done.
    'Both booleans are necessary to distinguish the case where nothing needs to be assigned, and nothing is indeed assigned from the case, nothing needs to be assigned as it has already been assigned. 
    'So bIsAssigned Is Not enough To decide whether Or Not we should assign, unless we use the information "is strAssignTo empty or not", but for the moment we keep it like it is.
    Public bAssignToIsPrefix As Boolean = False
    Public bAssignToColumnWithoutNames As Boolean = False
    Public bInsertColumnBefore As Boolean = False
    Public clsParameters As New List(Of RParameter)
    Private iNumberOfAddedParameters As Integer = 0 'This might be temporary, it enables to have a default name for parameters...

    ''lstOrderedIndices provides a way to identify in which order the parameters should be understood in the list of parameters, depending on the Position property of the Parameter. We could instead reorder the parameters according to the same information...
    'Private lstOrderedIndices As New List(Of Integer)

    Public Event ParametersChanged()

    'Public ReadOnly Property OrderedIndices As List(Of Integer)
    'This was initially intended to provide
    '    Get
    '        Return lstOrderedIndices
    '    End Get
    'End Property

    Protected Sub OnParametersChanged()
        RaiseEvent ParametersChanged()
    End Sub

    'Protected Sub UpdateListOfOrderedIndices() Handles Me.ParametersChanged
    '    'When parameters are changed, their order in the list needs to be updated. The order is determined by the Position property of each parameter.
    '    'If this is inefficient, might change the AddParameter method for it to add parameters at the right position.
    'lstOrderedIndices.Clear()
    'For i As Integer = 0 To clsParameters.Count - 1
    '    If clsParameters(i).Position > 0 AndAlso lstOrderedIndices.Count > 0 Then
    '    lstOrderedIndices.Insert(lstOrderedIndices.FindIndex(Function(x) (x = 0 OrElse x > clsParameters(i).Position)), i)
    '    Else
    '    lstOrderedIndices.Add(i)
    '    End If
    'Next
    'End Sub

    'Most methods from RFunction/ROperator have been moved here
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

    Public Overridable Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
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

    Public Overridable Function GetParameter(strName As String) As RParameter
        Return New RParameter
    End Function

    Public Overridable Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional clsParam As RParameter = Nothing, Optional iPosition As Integer = 0)
        If clsParam Is Nothing Then
            clsParam = New RParameter
            If strParameterName = "" Then
                MsgBox("Developer Error: some parameter has been added without specifying a name. We want all parameters to be given a name eventually.", MsgBoxStyle.OkOnly)
                bIncludeArgumentName = False
                strParameterName = "Parameter." & iNumberOfAddedParameters
            End If
            clsParam.SetArgumentName(strParameterName)
            If Not strParameterValue = "" Then
                clsParam.SetArgumentValue(strParameterValue)
            ElseIf clsRFunctionParameter IsNot Nothing Then
                clsParam.SetArgument(clsRFunctionParameter)
            ElseIf clsROperatorParameter IsNot Nothing Then
                clsParam.SetArgument(clsROperatorParameter)
            End If
            clsParam.bIncludeArgumentName = bIncludeArgumentName
        End If
        AddParameter(clsParam, iPosition)
    End Sub

    Public Overridable Sub AddParameter(clsParam As RParameter, Optional iPosition As Integer = 0)
        Dim i As Integer = -1
        Dim strTempArgumentName As String = clsParam.strArgumentName
        clsParam.Position = iPosition
        If clsParameters IsNot Nothing Then
            If clsParam.strArgumentName IsNot Nothing Then
                'Dim match As Predicate(Of RParameter) = Function(x) x.strArgumentName.Equals(clsParam.strArgumentName)
                i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(strTempArgumentName))
            End If
            If i = -1 Then
                clsParameters.Add(clsParam)
                'SortParameters() 'Not needed, can do this only when necessary...
            Else
                If clsParam.bIsString AndAlso clsParam.strArgumentValue IsNot Nothing Then
                    clsParameters(i).SetArgumentValue(clsParam.strArgumentValue)
                ElseIf (clsParam.bIsString OrElse clsParam.bIsFunction) AndAlso clsParam.clsArgument IsNot Nothing Then
                    clsParameters(i).SetArgument(clsParam.clsArgument)
                Else
                    'message
                End If
                If clsParameters(i).Position <> clsParam.Position Then
                    clsParameters(i).Position = clsParam.Position
                    'SortParameters() 'Not needed, can do this only when necessary...
                End If
            End If
        Else
            'message
        End If
        bIsAssigned = False
        iNumberOfAddedParameters = iNumberOfAddedParameters + 1
        OnParametersChanged()
    End Sub

    Public Sub SortParameters()
        'This sub is used to reorder the parameters according to their Position property.
        'It will be called only in places where it is necessary ie before ToScript or RemoveAdditionalParameters in ROperator.
        clsParameters.Sort(AddressOf CompareParametersPosition)
    End Sub
    Private Function CompareParametersPosition(ByVal x As RParameter, ByVal y As RParameter) As Integer
        'Compares two RParameters according to their Position property. If x is "smaller" than y, then return -1, if they are "equal" return 0 else return 1.
        If x.Position = y.Position Then
            Return 0
        ElseIf x.Position = 0 Then
            Return 1
        ElseIf y.Position = 0 Then
            Return -1
        Else
            Return x.Position.CompareTo(y.Position)
        End If
    End Function

    'Private Sub InsertParameter(ByRef clsParam As RParameter)
    '   Dim iPosition As Integer = clsParam.Position
    '   If clsParameters.Count > 0 AndAlso clsParameters.FindIndex(Function(x) x.Position = 0 OrElse x.Position > iPosition) <> -1 Then
    '           clsParameters.Insert(clsParameters.FindIndex(Function(x) x.Position = 0 OrElse x.Position > iPosition), clsParam)
    '   Else
    '           clsParameters.Add(clsParam)
    '   End If
    'End Sub
    Public Overridable Sub RemoveParameterByName(strArgName)
        Dim clsParam
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Sub ClearParameters()
        clsParameters.Clear()
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Function Clone() As RCodeStructure
        Dim clsTemp As New RCodeStructure
        Return clsTemp
    End Function

End Class
