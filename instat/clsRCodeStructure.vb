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

''' <summary>   This class TBD. </summary>
Public Class RCodeStructure
    ''' <summary>   If the output from the R command needs to be assigned, then this string is 
    '''             the part of the script to the left of the assignment operator ('&lt;-'), 
    '''             i.e. the name that should be used to assign in R the output of the main 
    '''             (Base) R-command.
    '''             If the output from the R command doesn't to be assigned, then this string is
    '''             empty. </summary>
    Public strAssignTo As String

    ''' <summary>   The name of the data frame to assign to 
    '''             (i.e. the data frame name associated with the R "data_name" parameter). 
    '''             </summary>
    Public strAssignToDataFrame As String

    ''' <summary>   The name of the column to assign to
    '''             (i.e. the column name associated with the R "col_name" or "col_names" 
    '''             parameters).
    '''             </summary>
    Public strAssignToColumn As String

    ''' <summary>   The name of the model to assign to
    '''             (i.e. the model name associated with the R "model_name" parameter).
    '''             </summary>
    Public strAssignToModel As String

    ''' <summary>   The name of the graph to assign to
    '''             (i.e. the graph name associated with the R "graph_name" parameter).
    '''             </summary>
    Public strAssignToGraph As String

    ''' <summary>   The name of the surv to assign to
    '''             (i.e. the surv name associated with the R "surv_name" parameter).
    '''             </summary>
    Public strAssignToSurv As String

    ''' <summary>   The name of the table to assign to
    '''             (i.e. the table name associated with the R "table_name" parameter).
    '''             </summary>
    Public strAssignToTable As String

    ''' <summary>   If true then a list of data frames is assigned (i.e. the R "data_names" 
    '''             parameter needs to be set).
    '''             </summary>
    Public bDataFrameList As Boolean = False

    ''' <summary>   The names of the new data frames (i.e. the data frame names associated with 
    '''             the R "data_names" parameter). Only used if 'bDataFrameList' is true. 
    '''             </summary>
    Public strDataFrameNames As String

    ''' <summary>    
    '''             If true then, AT THE CURRENT STAGE of running code within R, the output of 
    '''             the Base R-command NEEDS TO BE assigned to:
    ''' <list type="bullet">
    '''     <item>
    '''             <description>the variable With the appropriate name: strAssignTo</description>
    '''     </item>
    '''     <item>
    '''             <description>and potentially assigned to elements in an R-instat object, if specified
    '''               in the AssignToDataFrame,... parameters</description>
    '''     </item>
    ''' </list>
    '''             Note: Both bToBeAssigned and bIsAssigned are necessary to distinguish between:
    ''' <list type="bullet">
    '''     <item>
    '''             <description>the output hasn't been assigned but doesn't need to be</description>
    '''     </item>
    '''     <item>
    '''             <description>the output has already been assigned</description>
    '''     </item>
    ''' </list>
    '''             (i.e. bIsAssigned isn't enough to decide whether or not we should assign, 
    '''             unless we use the information "is strAssignTo empty or not", but for the moment 
    '''             we keep it like it is.)
    '''             
    '''             Note: This variable is only relevant in the string case, as RFunction and
    '''             ROperator have internal equivalents.
    ''' </summary>
    Public bToBeAssigned As Boolean = False

    ''' <summary>   Tells blindly whether or not the output of the R-command has been 
    '''             assigned and, if relevant, the link with the appropriate R-instat object has 
    '''             been done.
    '''             
    '''             Note: Both bToBeAssigned and bIsAssigned are necessary to distinguish between:
    ''' <list type="bullet">
    '''     <item>
    '''             <description>the output hasn't been assigned but doesn't need to be</description>
    '''     </item>
    '''     <item>
    '''             <description>the output has already been assigned</description>
    '''     </item>
    ''' </list>
    '''             (i.e. bIsAssigned isn't enough to decide whether or not we should assign, 
    '''             unless we use the information "is strAssignTo empty or not", but for the moment 
    '''             we keep it like it is.)
    '''             
    '''             Note: This variable is only relevant in the string case, as RFunction and
    '''             ROperator have internal equivalents.
    ''' </summary>
    Public bIsAssigned As Boolean = False

    ''' <summary>   If true then the R parameter "use_col_name_as_prefix" is set to true, 
    '''             else the parameter is set to false.
    '''             </summary>
    Public bAssignToIsPrefix As Boolean = False

    ''' <summary>   If true then don't assign to a specific named column. If false then assign to 
    '''             a named column (i.e. the R "col_name" parameter needs to be set). 
    '''             </summary>
    Public bAssignToColumnWithoutNames As Boolean = False

    ''' <summary>   If true then set the R "before" parameter to true, else set it to false.
    '''             Only used when assigning to a column.
    '''             </summary>
    Public bInsertColumnBefore As Boolean = False

    ''' <summary>   The name of the column to associate with the R "adjacent_column" parameter.
    '''             Only used when assigning to a column.
    '''             </summary>
    Public strAdjacentColumn As String = ""

    ''' <summary>   If true then there is no effect.
    '''             If false then set the R "require_correct_length" parameter to false. 
    '''             Only used when assigning to a column.
    '''             </summary>
    Public bRequireCorrectLength As Boolean = True

    ''' <summary>   The list of parameters associated with this R code. </summary>
    Public clsParameters As New List(Of RParameter)

    ''' <summary>   The number of parameters associated with this R code.</summary>
    Protected iNumberOfAddedParameters As Integer = 0 'TODSO Is this used or needed? Couldn't we find the number of parameters from the num of elements in clsParameters?

    ''' <summary>   An enum constant representing the position option.
    '''             Note: This is currently only used in RSyntax as a before/after code to 
    '''             determine the position code should be run in the list.
    '''    Similar behaviour to parameter positions. </summary>
    Public iPosition = -1 ' TODO SJL This seems to be a constant, should we declare it with 'const'?

    ''' <summary>   What to do with the result returned by executing the R code: 
    ''' <list type="bullet">
    '''     <item>
    '''        <description>0 Ignore the result of the R code.</description>
    '''     </item>
    '''     <item>
    '''        <description>1 Store the result of the R code in a temporary R variable, and then 
    '''                     output the variable's value as text.</description>
    '''     </item>
    '''     <item>
    '''        <description>2 If the R code executes successfully then show the result as text.
    '''                     </description>
    '''     </item>
    '''     <item>
    '''        <description>3 If the R code executes successfully then show the result as a graph.
    '''                     </description>
    '''     </item>
    '''     <item>
    '''        <description>4 Store the result of the R code in a temporary R variable, and then 
    '''                     output the variable's value in a web browser.
    '''                     </description>
    '''     </item>
    ''' </list>
    ''' </summary>
    Public iCallType As Integer = 0 'TODO SJL In RInstat, iCallType only seems to be 0, 2 or 3. Are call types 1 and 4 used?

    ''' <summary>   If true then potentially exclude the assignment part of the script from the R 
    '''             command.
    '''             Normally, the assignment part of the script should only be excluded if the 
    '''             output has already been assigned. 
    '''             For example:
    '''             <code>
    '''                 If bExcludeAssignedFunctionOutput AndAlso bIsAssigned Then
    '''                     'process script without assignment part
    '''                 Else
    '''                     'process script with assignment part 
    '''             </code>
    '''             </summary>
    Public bExcludeAssignedFunctionOutput As Boolean = True

    ''' <summary>   This is used to clear the global environment of unused variables. 
    '''             Will be cleared after running unless bClearFromGlobal = False 
    '''             </summary>
    Public bClearFromGlobal As Boolean = False 'TODO SJL This variable is never checked or set to true, can we remove?

    ''' <summary>   If true then 'clsRFunction.ToScript' and 'clsROperator.ToScript' return a string 
    '''             that can be passed to R (i.e. double quotes are replaced with single quotes, 
    '''             and the string is wrapped in double quotes).
    '''             For example: <c>seq(from = 1, to = 10)</c> becomes <c>"seq(from = 1, to = 10)"</c>.
    '''             Note: if true then then the returned string can no longer be used for the 
    '''             function or its parameters because it will not produce the correct script
    '''             (i.e. it should not be true if 'bToBeAssigned' or 'bIsAssigned' is true.
    '''             </summary>
    Public bToScriptAsRString As Boolean = False

    ''' <summary>   Tag object for any use. </summary>
    Public Tag As Object 'TODO SJL This only seems to be used by dlgCalculationsSummary. Could we add something local to this dialog and then remove the tag from this calss?

    ''' <summary>   Event queue for all listeners interested in ParametersChanged events. </summary>
    Public Event ParametersChanged() 'TODO SJL Is this still used? Can it be removed?

    ''' <summary>   Executes the parameters changed action. Currently only used when this is in 
    '''             RSyntax as a before/after code to determine position code should be run in the 
    '''             list. This is because RSyntax has iCallType and bExcludeAssignedFunctionOutput 
    '''             which it uses for the base code. Eventually migrate these out of RSyntax.
    '''             </summary>
    Protected Sub OnParametersChanged()
        RaiseEvent ParametersChanged() 'TODO SJL Is this still used? Can it be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the 'assignTo' variables. </summary>
    '''
    ''' <param name="strTemp">                      The new value for the assignment string. </param>
    ''' <param name="strTempDataframe">             (Optional) The new value for the dataframe. </param>
    ''' <param name="strTempColumn">                (Optional) The new value for the column. </param>
    ''' <param name="strTempModel">                 (Optional) The new value for the model. </param>
    ''' <param name="strTempGraph">                 (Optional) The new value for the graph. </param>
    ''' <param name="strTempSurv">                  (Optional) The new value for the surv. </param>
    ''' <param name="strTempTable">                 (Optional) The new value for the table. </param>
    ''' <param name="bAssignToIsPrefix">            (Optional) The new value for bAssignToIsPrefix. </param>
    ''' <param name="bAssignToColumnWithoutNames">  (Optional) The new value for bAssignToColumnWithoutNames. </param>
    ''' <param name="bInsertColumnBefore">          (Optional) The new value for bInsertColumnBefore. </param>
    ''' <param name="bRequireCorrectLength">        (Optional) The new value for bRequireCorrectLength. </param>
    ''' <param name="bDataFrameList">               (Optional) If true then a list of data frames is
    '''                                             being assigned, otherwise a single data frame. </param>
    ''' <param name="strDataFrameNames">            (Optional) Optional R character vector to give
    '''                                             names of new data frames if data frame list is
    '''                                             not named. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional strTempSurv As String = "", Optional strTempTable As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False, Optional bRequireCorrectLength As Boolean = True, Optional bDataFrameList As Boolean = False, Optional strDataFrameNames As String = "")

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
        If Not strTempSurv = "" Then
            strAssignToSurv = strTempSurv
        End If

        If Not strTempTable = "" Then
            strAssignToTable = strTempTable
        End If
        bToBeAssigned = True
        bIsAssigned = False
        Me.bAssignToIsPrefix = bAssignToIsPrefix
        Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        Me.bInsertColumnBefore = bInsertColumnBefore
        Me.bRequireCorrectLength = bRequireCorrectLength
        Me.bDataFrameList = bDataFrameList
        Me.strDataFrameNames = strDataFrameNames

    End Sub

    ''' <summary>   Resets all the 'AssignTo' variables. 
    '''             String variables are set to "".
    '''             Booleans are set to false. 
    '''             </summary>
    Public Sub RemoveAssignTo()
        strAssignTo = "" ' TODO SJL should bRequireCorrectLength, bDataFrameList, strDataFrameNames also be reset?
        strAssignToDataFrame = ""
        strAssignToColumn = ""
        strAssignToModel = ""
        strAssignToGraph = ""
        strAssignToSurv = ""
        strAssignToTable = ""
        bToBeAssigned = False
        bIsAssigned = False
        bAssignToIsPrefix = False
        bAssignToColumnWithoutNames = False
        bInsertColumnBefore = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If object needs to be assigned to, then creates/updates the assignment script 
    '''             (if needed) amd returns the assignment script.
    '''             If object doesn't need to be assigned to, then returns <paramref name="strTemp"/>.
    '''             </summary>
    '''
    ''' <param name="strScript">    [in,out] (Optional) The existing script. 
    '''                             If the assignment requires extra elements (e.g. columns, models, 
    '''                             graphs etc.) then this script is updated to include the 
    '''                             addition of the new elements.</param>
    ''' <param name="strTemp">      (Optional) The expression to assign (i.e. the right side of the
    '''                             assignment). </param>
    '''
    ''' <returns>   If object needs to be assigned to, then returns the assign string. 
    '''             Else returns <paramref name="strTemp"/>. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim clsAddColumns As New RFunction
        Dim clsGetColumns As New RFunction
        Dim clsAddData As New RFunction
        Dim clsGetData As New RFunction
        Dim clsAddModels As New RFunction
        Dim clsGetModels As New RFunction
        Dim clsAddGraphs As New RFunction
        Dim clsGetGraphs As New RFunction
        Dim clsAddSurv As New RFunction
        Dim clsGetSurv As New RFunction
        Dim clsAddTables As New RFunction
        Dim clsGetTables As New RFunction
        Dim clsDataList As New RFunction

        ' if R script already assigned for this object then return the existing assign script
        If bIsAssigned Then
            Return (strAssignTo)
        End If

        ' if R script still needs to be assigned to this object
        If bToBeAssigned Then

            'assign 'strTemp' to 'strAssignTo'. 
            'Same as the following (but handles multi-line strings):
            '    strScript = strScript & strAssignTo & " <- " & strTemp & Environment.NewLine
            '    e.g. 'strScript' set to "new_RDS <- readRDS(file=""C:/Users/myName/Library/experimental_survey.RDS"")" & vbCrLf
            strScript = strScript & ConstructAssignTo(strAssignTo, strTemp) & Environment.NewLine

            'if we need to assign to a column in a data frame
            If Not strAssignToDataFrame = "" AndAlso (Not strAssignToColumn = "" OrElse bAssignToColumnWithoutNames) Then
                clsAddColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
                clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                'if we need to assign to a named column
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

                If Not String.IsNullOrEmpty(strAdjacentColumn) Then
                    clsAddColumns.AddParameter("before", If(bInsertColumnBefore, "TRUE", "FALSE"))
                    clsAddColumns.AddParameter("adjacent_column", strAdjacentColumn)
                Else
                    If bInsertColumnBefore Then
                        clsAddColumns.AddParameter("before", "TRUE")
                    Else
                        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                            clsAddColumns.AddParameter("before", "FALSE")
                        End If

                    End If
                End If
                If Not bRequireCorrectLength Then
                    clsAddColumns.AddParameter("require_correct_length", "FALSE")
                End If
                ' add '$add-columns_to_data' parameters to 'strScript' 
                ' e.g. "row_names1 <- data_book$get_row_names(data_name=""survey"")" & vbCrLf & "data_book$add_columns_to_data(data_name=""survey"", col_name=""row_names1"", col_data=row_names1, before=TRUE)" & vbCrLf
                strScript = strScript & clsAddColumns.ToScript() & Environment.NewLine

                clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsGetColumns.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                clsGetColumns.AddParameter("col_names", Chr(34) & strAssignToColumn & Chr(34))
                ' set 'strAssignTo' to e.g. "data_book$get_columns_from_data(data_name=""survey"", col_names=""row_names1"")"
                strAssignTo = clsGetColumns.ToScript()
            ElseIf Not strAssignToModel = "" Then 'else if we need to assign to a model
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
            ElseIf Not strAssignToGraph = "" Then 'else if we need to assign to a graph
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
            ElseIf Not strAssignToSurv = "" Then 'else if we need to assign to a surv
                clsAddSurv.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_surv")
                clsAddSurv.AddParameter("surv_name", Chr(34) & strAssignToSurv & Chr(34))
                clsAddSurv.AddParameter("surv", strAssignTo)
                If Not strAssignToDataFrame = "" Then
                    clsAddSurv.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                    clsGetSurv.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                End If
                strScript = strScript & clsAddSurv.ToScript() & Environment.NewLine

                clsGetSurv.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_surv")
                clsGetSurv.AddParameter("surv_name", Chr(34) & strAssignToSurv & Chr(34))
                strAssignTo = clsGetSurv.ToScript()

            ElseIf Not strAssignToTable = "" Then 'else if we need to assign to a table
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
            ElseIf Not strAssignToDataFrame = "" Then 'else if we need to assign to a data frame
                clsAddData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")

                If bDataFrameList Then
                    clsAddData.AddParameter("data_tables", strAssignTo, iPosition:=0)
                    If strDataFrameNames <> "" Then
                        clsAddData.AddParameter("data_names", strDataFrameNames, iPosition:=5)
                    End If
                Else
                    clsDataList.SetRCommand("list")
                    clsDataList.AddParameter(strAssignToDataFrame, strAssignTo)
                    clsAddData.AddParameter("data_tables", clsRFunctionParameter:=clsDataList, iPosition:=0)
                End If

                strScript = strScript & clsAddData.ToScript() & Environment.NewLine

                clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                strAssignTo = clsGetData.ToScript()
            End If
            bIsAssigned = True
            bToBeAssigned = False
            Return strAssignTo
        Else 'else if R script doesn't need to be assigned to this object
            ' just return the right side of the assignment
            Return strTemp
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns an assignment statement of the form:
    '''             <code>
    '''             <paramref name="strAssignTo"/> &lt;- <paramref name="strTemp"/> 
    '''             </code>
    '''             If <paramref name="strTemp"/> is multiple lines then <paramref name="strTemp"/> 
    '''             is assigned to the final line. All previous lines are returned unchanged.
    '''              </summary>
    '''
    ''' <param name="strAssignTo">  The variable to assign to (i.e. the left side of the 
    '''                             assignment). </param>
    ''' <param name="strTemp">      The expression to assign (i.e. the right side of the 
    '''                             assignment). </param>
    '''
    ''' <returns>   The constructed assignment statement. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function ConstructAssignTo(strAssignTo As String, strTemp As String) As String
        Dim strReconstructed As String = ""
        Dim strParts As String()
        If Not String.IsNullOrEmpty(strTemp) Then
            'if string contains more than one line, then divide it up into an array of separate lines
            strParts = strTemp.Split(ControlChars.CrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            If strParts.Length > 1 Then
                're-assemble the string, apart from the last line
                For i As Integer = 0 To strParts.Length - 2
                    strReconstructed = strReconstructed & strParts(i) & Environment.NewLine
                Next
                'assign just the last line of the multi-line string
                strReconstructed = strReconstructed & strAssignTo & " <- " & strParts.Last
            Else 'else if string has only one line, then assign to the whole string
                strReconstructed = strAssignTo & " <- " & strTemp
            End If
        End If
        Return strReconstructed
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Creates and returns a new RParameter object. Child classes that override this
    '''             function should return the parameter named <paramref name="strName"/>. 
    '''             </summary>
    '''
    ''' <param name="strName">  The name of the parameter to return (only used when this function
    '''                         is overridden by a child class). </param>
    '''
    ''' <returns>   A new RParameter object. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function GetParameter(strName As String) As RParameter
        Return New RParameter
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Creates and adds a parameter to this object.
    '''             Sets the parameter's name to <paramref name="strParameterName"/>.
    '''             Sets the parameter's argument to ONE OF <paramref name="strParameterValue"/>,
    '''             <paramref name="clsRFunctionParameter"/>, <paramref name="clsROperatorParameter"/>,
    '''             or <paramref name="clsRCodeStructureParameter"/>.
    '''             Sets the parameter's position and include/exclude argument name flag to 
    '''             <paramref name="iPosition"/> and <paramref name="bIncludeArgumentName"/> 
    '''             respectively.
    '''             </summary>
    '''
    ''' <param name="strParameterName">             (Optional) Name of the parameter. </param>
    ''' <param name="strParameterValue">            (Optional) The parameter value. </param>
    ''' <param name="clsRFunctionParameter">        (Optional) The cls r function parameter. </param>
    ''' <param name="clsROperatorParameter">        (Optional) The cls r operator parameter. </param>
    ''' <param name="clsRCodeStructureParameter">   (Optional) The cls r code structure parameter. </param>
    ''' <param name="bIncludeArgumentName">         (Optional) True to include, false to exclude the
    '''                                             argument name. </param>
    ''' <param name="iPosition">                    (Optional) Zero-based index of the position. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional clsRCodeStructureParameter As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        Dim clsParam = New RParameter

        If strParameterName = "" Then 'TODO SJL If we make strParameterName a mandatory parameter then we can remove this check.
            ' MsgBox("Developer Error: some parameter has been added without specifying a name. We want all
            ' parameters to be given a name eventually.", MsgBoxStyle.OkOnly)
            bIncludeArgumentName = False
            If iPosition = 0 Then
                strParameterName = "First"
            Else
                strParameterName = "Unnamed"
            End If
        End If
        clsParam.SetArgumentName(strParameterName)
        If Not strParameterValue = "" Then 'TODO SJL If the caller specifies more than one of these parameters then the result may be unexpected. Safer use an enum parameter to enforce correct usage??
            clsParam.SetArgumentValue(strParameterValue)
        ElseIf clsRFunctionParameter IsNot Nothing Then
            clsParam.SetArgument(clsRFunctionParameter)
        ElseIf clsROperatorParameter IsNot Nothing Then
            clsParam.SetArgument(clsROperatorParameter)
        ElseIf clsRCodeStructureParameter IsNot Nothing Then
            clsParam.SetArgument(clsRCodeStructureParameter)
        End If
        clsParam.bIncludeArgumentName = bIncludeArgumentName
        clsParam.Position = iPosition
        AddParameter(clsParam)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds a parameter with code structure. 
    '''             TODO This should be call AddParameter but need to make it unambiguous with above. 
    '''             TODO SJL This function is not used, and is not overridden by any child classes. Can we remove?
    '''             </summary>
    '''
    ''' <param name="strParameterName">     (Optional) Name of the parameter. </param>
    ''' <param name="strParameterValue">    (Optional) The parameter value. </param>
    ''' <param name="clsRCodeObject">       (Optional) The cls r code object. </param>
    ''' <param name="bIncludeArgumentName"> (Optional) True to include, false to exclude the argument
    '''                                     name. </param>
    ''' <param name="iPosition">            (Optional) Zero-based index of the position. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub AddParameterWithCodeStructure(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRCodeObject As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        If TypeOf (clsRCodeObject) Is RFunction Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue, clsRFunctionParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName, iPosition:=iPosition)
        ElseIf TypeOf (clsRCodeObject) Is ROperator Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue, clsROperatorParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName, iPosition:=iPosition)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If the object already has a parameter with the same name then changes the 
    '''             parameter's value to the value in <paramref name="clsNewParam"/>.
    '''             Else adds <paramref name="clsNewParam"/> to the object as as a new parameter.
    '''             </summary>
    '''
    ''' <param name="clsNewParam">  The cls new parameter. </param>
    '''--------------------------------------------------------------------------------------------
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
                ElseIf (clsNewParam.bIsOperator OrElse clsNewParam.bIsFunction) AndAlso clsNewParam.clsArgumentCodeStructure IsNot Nothing Then
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Shift parameters positions. </summary>
    '''
    ''' <param name="iPosition">    Zero-based index of the position. </param>
    '''--------------------------------------------------------------------------------------------
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

    ''' <summary>   Sort parameters. </summary>
    Public Sub SortParameters()
        'This sub is used to reorder the parameters according to their Position property.
        'It will be called only in places where it is necessary ie before ToScript or RemoveAdditionalParameters in ROperator.
        clsParameters.Sort(AddressOf CompareParametersPosition)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Compare parameters position. </summary>
    '''
    ''' <param name="clsMain">      The cls main. </param>
    ''' <param name="clsRelative">  The cls relative. </param>
    '''
    ''' <returns>   An Integer. </returns>
    '''--------------------------------------------------------------------------------------------
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

    ''' <summary>   Removes the unordered parameters. </summary>
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter by name described by strArgName. </summary>
    '''
    ''' <param name="strArgName">   Name of the argument. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameterByName(strArgName As String)
        Dim clsParam As RParameter
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter by position described by iPosition. </summary>
    '''
    ''' <param name="iPosition">    Zero-based index of the position. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameterByPosition(iPosition As Integer)
        Dim clsParam As RParameter
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.Position = iPosition)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter described by clsParam. </summary>
    '''
    ''' <param name="clsParam"> The cls parameter. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameter(clsParam As RParameter)
        If Not clsParameters Is Nothing Then
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Query if 'strParameterName' contains parameter. </summary>
    '''
    ''' <param name="clsParam"> The cls parameter. </param>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function ContainsParameter(clsParam As RParameter) As Boolean
        Return clsParameters.Contains(clsParam)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Query if 'strParameterName' contains parameter. </summary>
    '''
    ''' <param name="strParameterName"> Name of the parameter. </param>
    '''
    ''' <returns>   True if it succeeds, false if it fails. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function ContainsParameter(strParameterName As String) As Boolean
        Return (clsParameters.FindIndex(Function(x) x.strArgumentName = strParameterName) <> -1)
    End Function

    ''' <summary>   Clears this object to its blank/initial state. </summary>
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

    ''' <summary>   Clears the parameters. </summary>
    Public Overridable Sub ClearParameters()
        clsParameters.Clear()
        iNumberOfAddedParameters = 0
        bIsAssigned = False
        OnParametersChanged()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a deep copy of this object. </summary>
    '''
    ''' <returns>   A copy of this object. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function Clone() As RCodeStructure
        Dim clsTempCode As New RCodeStructure
        Dim clsRParam As RParameter

        clsTempCode.strAssignTo = strAssignTo
        clsTempCode.strAssignToDataFrame = strAssignToDataFrame
        clsTempCode.strAssignToColumn = strAssignToColumn
        clsTempCode.strAssignToModel = strAssignToModel
        clsTempCode.strAssignToGraph = strAssignToGraph
        clsTempCode.strAssignToSurv = strAssignToSurv
        clsTempCode.strAssignToTable = strAssignToTable
        clsTempCode.bDataFrameList = bDataFrameList
        clsTempCode.strDataFrameNames = strDataFrameNames
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
        clsTempCode.Tag = Tag
        For Each clsRParam In clsParameters
            clsTempCode.AddParameter(clsRParam.Clone)
        Next
        Return clsTempCode
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets all assign to. </summary>
    '''
    ''' <param name="lstCodes">     The list codes. </param>
    ''' <param name="lstValues">    The list values. </param>
    '''--------------------------------------------------------------------------------------------
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
