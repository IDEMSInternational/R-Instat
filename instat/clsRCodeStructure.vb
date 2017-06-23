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
    Public strAssignToTable As String
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
    Protected iNumberOfAddedParameters As Integer = 0 'This might be temporary, it enables to have a default name for parameters...
    'Currently only used when this is in RSyntax as a before/after code to determine position code should be run in the list
    'Similar behaviour to parameter positions
    Public iPosition = -1

    'Currently only used when this is in RSyntax as a before/after code to determine position code should be run in the list
    'This is because RSyntax has iCallType & bExcludeAssignedFunctionOutput which it uses for the base code
    'Eventually migrate these out of RSyntax
    Public iCallType As Integer = 0
    Public bExcludeAssignedFunctionOutput As Boolean = True

    'The name this code is represented by in the R global environment
    'This is used to clear the global environment of unused variables
    'Will be cleared after running unless bClearFromGlobal = False
    Public bClearFromGlobal As Boolean = False

    ' If True when running ToScript the function will be returned as a string that could be passed to R
    ' e.g. "seq(from = 1, to = 10)" instead of seq(from = 1, to = 10)
    ' When True, assignment cannot be used for the function or its parameters
    Public bToScriptAsRString As Boolean = False

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

    'Most methods from RFunction/ROperator have been moved here
    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional strTempTable As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False)
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
        If Not strTempTable = "" Then
            strAssignToTable = strTempTable
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
        strAssignToGraph = ""
        strAssignToTable = ""
        bToBeAssigned = False
        bIsAssigned = False
        bAssignToIsPrefix = False
        bAssignToColumnWithoutNames = False
        bInsertColumnBefore = False
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
        Dim clsAddTables As New RFunction
        Dim clsGetTables As New RFunction
        Dim clsDataList As New RFunction

        If bIsAssigned Then
            Return (strAssignTo)
        End If

        If bToBeAssigned Then
            If Not frmMain.clsRLink.bInstatObjectExists Then
                frmMain.clsRLink.CreateNewInstatObject()
            End If
            strScript = strScript & strAssignTo & " <- " & strTemp & Environment.NewLine
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
                strScript = strScript & clsAddColumns.ToScript() & Environment.NewLine

                clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsGetColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                clsGetColumns.AddParameter("col_names", Chr(34) & strAssignToColumn & Chr(34))
                strAssignTo = clsGetColumns.ToScript()
            ElseIf Not strAssignToModel = "" Then
                clsAddModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_model")
                clsAddModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                clsAddModels.AddParameter("model", strAssignTo)
                clsAddModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                If Not strAssignToDataFrame = "" Then
                    clsAddModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetModels.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddModels.ToScript() & Environment.NewLine

                clsGetModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                clsGetModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                strAssignTo = clsGetModels.ToScript()
            ElseIf Not strAssignToGraph = "" Then
                clsAddGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_graph")
                clsAddGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                clsAddGraphs.AddParameter("graph", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetGraphs.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddGraphs.ToScript() & Environment.NewLine

                clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
                clsGetGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                strAssignTo = clsGetGraphs.ToScript()
            ElseIf Not strAssignToTable = "" Then
                clsAddTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_table")
                clsAddTables.AddParameter("table_name", Chr(34) & strAssignToTable & Chr(34))
                clsAddTables.AddParameter("table", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddTables.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetTables.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddTables.ToScript() & Environment.NewLine

                clsGetTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_tables")
                clsGetTables.AddParameter("table_name", Chr(34) & strAssignToTable & Chr(34))
                strAssignTo = clsGetTables.ToScript()
            ElseIf Not strAssignToDataFrame = "" Then
                clsAddData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
                clsDataList.SetRCommand("list")
                clsDataList.AddParameter(strAssignToDataFrame, strAssignTo)
                clsAddData.AddParameter("data_tables", clsRFunctionParameter:=clsDataList)
                strScript = strScript & clsAddData.ToScript() & Environment.NewLine

                clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                strAssignTo = clsGetData.ToScript()
            End If
            bIsAssigned = True
            bToBeAssigned = False
            Return strAssignTo
        Else
            Return strTemp
        End If
    End Function

    Public Overridable Function GetParameter(strName As String) As RParameter
        Return New RParameter
    End Function

    Public Overridable Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        Dim clsParam = New RParameter

        If strParameterName = "" Then
            'MsgBox("Developer Error: some parameter has been added without specifying a name. We want all parameters to be given a name eventually.", MsgBoxStyle.OkOnly)
            bIncludeArgumentName = False
            If iPosition = 0 Then
                strParameterName = "First"
            Else
                strParameterName = "Unnamed"
            End If
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
        clsParam.Position = iPosition
        AddParameter(clsParam)
    End Sub

    'TODO This should be call AddParameter but need to make it unambiguous with above
    Public Overridable Sub AddParameterWithCodeStructure(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRCodeObject As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        If TypeOf (clsRCodeObject) Is RFunction Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue, clsRFunctionParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName, iPosition:=iPosition)
        ElseIf TypeOf (clsRCodeObject) Is ROperator Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue, clsROperatorParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName, iPosition:=iPosition)
        End If
    End Sub

    Public Overridable Sub AddParameter(clsNewParam As RParameter)
        Dim i As Integer = -1
        Dim strTempArgumentName As String = clsNewParam.strArgumentName
        If clsParameters IsNot Nothing Then
            If clsNewParam.strArgumentName IsNot Nothing Then
                'Dim match As Predicate(Of RParameter) = Function(x) x.strArgumentName.Equals(clsParam.strArgumentName)
                i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(strTempArgumentName))
            End If
            If i = -1 Then
                ShiftParametersPositions(clsNewParam.Position) 'Checking if there is room in the parameter's positions to add a parameter with position = iPosition
                clsParameters.Add(clsNewParam)
            Else
                If clsNewParam.bIsString AndAlso clsNewParam.strArgumentValue IsNot Nothing Then
                    clsParameters(i).SetArgumentValue(clsNewParam.strArgumentValue)
                ElseIf (clsNewParam.bIsString OrElse clsNewParam.bIsFunction) AndAlso clsNewParam.clsArgumentCodeStructure IsNot Nothing Then
                    clsParameters(i).SetArgument(clsNewParam.clsArgumentCodeStructure)
                Else
                    'message
                End If
                If clsParameters(i).Position <> clsNewParam.Position Then
                    'In case the position needs to be changed, there might exist another parameter with the new position in the list
                    'The parameter i is then temporarily set to unordered until the Shift in positions has been operated within the clsParameters (if necessary).
                    clsParameters(i).Position = -1
                    If clsNewParam.Position <> -1 Then
                        ShiftParametersPositions(clsNewParam.Position)
                        clsParameters(i).Position = clsNewParam.Position
                    End If
                End If
            End If
        Else
            'message
        End If
        bIsAssigned = False
        iNumberOfAddedParameters = iNumberOfAddedParameters + 1
        OnParametersChanged()
    End Sub

    Private Sub ShiftParametersPositions(iPosition As Integer)
        'Assuming that there are no repetitions in the positions of ordered parameters, this sub will shift all positions starting from iPosition until there are no repititions of positions even if a parameter with position iposition was added.
        'In particular it won't do anything if there is no parameter with position iPosition in clsParameters.
        Dim bReady As Boolean = False 'indicates when incrementing will solve all repetitions among positions of ordered parameters.
        Dim lstIndices As New List(Of Integer) 'The list of indices of the parameters of which the position need to be incremented.
        'Only Shift if iPosition is > -1
        If iPosition > -1 Then
            While Not bReady
                bReady = True 'the list is ready unless there is a parameter that has position iPosition. In which case, this parameter's position will be incremented. Now need to check that there is no other parameter with position iposition + 1.
                For i As Integer = 0 To clsParameters.Count - 1
                    If clsParameters(i).Position = iPosition Then
                        iPosition = iPosition + 1
                        lstIndices.Add(i)
                        bReady = False
                    End If
                Next
            End While
            For Each iIndex As Integer In lstIndices
                clsParameters(iIndex).Position = clsParameters(iIndex).Position + 1
            Next
        End If
    End Sub

    Public Sub SortParameters()
        'This sub is used to reorder the parameters according to their Position property.
        'It will be called only in places where it is necessary ie before ToScript or RemoveAdditionalParameters in ROperator.
        clsParameters.Sort(AddressOf CompareParametersPosition)
    End Sub

    Private Function CompareParametersPosition(ByVal clsMain As RParameter, ByVal clsRelative As RParameter) As Integer
        'Compares two RParameters according to their Position property. If x is "smaller" than y, then return -1, if they are "equal" return 0 else return 1.
        If clsMain.Position = clsRelative.Position Then
            Return 0
        ElseIf clsRelative.Position = -1 Then
            Return -1
        ElseIf clsMain.Position = -1 Then
            Return 1
        Else
            Return clsMain.Position.CompareTo(clsRelative.Position)
        End If
    End Function

    Public Sub RemoveUnorderedParameters()
        'Removes all parameters that are of position -1 i e unordered.
        Dim clsParam As RParameter
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.Position = -1)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Sub RemoveParameterByName(strArgName As String)
        Dim clsParam As RParameter
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Sub RemoveParameterByPosition(iPosition As Integer)
        Dim clsParam As RParameter
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.Position = iPosition)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Sub RemoveParameter(clsParam As RParameter)
        If Not clsParameters Is Nothing Then
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Function ContainsParameter(clsParam As RParameter) As Boolean
        Return clsParameters.Contains(clsParam)
    End Function

    Public Overridable Function ContainsParameter(strParameterName As String) As Boolean
        Return (clsParameters.FindIndex(Function(x) x.strArgumentName = strParameterName) <> -1)
    End Function

    Public Overridable Sub Clear()
        'todo tidy up iPosition 
        iPosition = -1
        iCallType = 0
        bExcludeAssignedFunctionOutput = True
        'todo shouldn't this be true by default
        bClearFromGlobal = False
        bToScriptAsRString = False
        RemoveAssignTo()
        ClearParameters()
    End Sub

    Public Overridable Sub ClearParameters()
        clsParameters.Clear()
        iNumberOfAddedParameters = 0
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    Public Overridable Function Clone() As RCodeStructure
        Dim clsTempCode As New RCodeStructure
        Dim clsRParam As RParameter

        clsTempCode.strAssignTo = strAssignTo
        clsTempCode.strAssignToDataFrame = strAssignToDataFrame
        clsTempCode.strAssignToColumn = strAssignToColumn
        clsTempCode.strAssignToModel = strAssignToModel
        clsTempCode.strAssignToGraph = strAssignToGraph
        clsTempCode.strAssignToTable = strAssignToTable
        clsTempCode.bToBeAssigned = bToBeAssigned
        clsTempCode.bIsAssigned = bIsAssigned
        clsTempCode.bAssignToIsPrefix = bAssignToIsPrefix
        clsTempCode.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        clsTempCode.bInsertColumnBefore = bInsertColumnBefore
        clsTempCode.iNumberOfAddedParameters = iNumberOfAddedParameters
        clsTempCode.iPosition = iPosition
        clsTempCode.iCallType = iCallType
        clsTempCode.bExcludeAssignedFunctionOutput = bExcludeAssignedFunctionOutput
        clsTempCode.bClearFromGlobal = bClearFromGlobal
        clsTempCode.bToScriptAsRString = bToScriptAsRString
        For Each clsRParam In clsParameters
            clsTempCode.AddParameter(clsRParam.Clone)
        Next
        Return clsTempCode
    End Function

    Public Sub GetAllAssignTo(lstCodes As List(Of RCodeStructure), lstValues As List(Of String))
        SortParameters()
        If bToBeAssigned AndAlso Not lstCodes.Contains(Me) Then
            lstCodes.Add(Me)
            lstValues.Add(strAssignTo)
        End If
        For Each clsTempParam As RParameter In clsParameters
            clsTempParam.GetAllAssignTo(lstCodes, lstValues)
        Next
    End Sub
End Class
