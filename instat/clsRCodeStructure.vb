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

'''--------------------------------------------------------------------------------------------
''' <summary>   An object of this class represents an R command. 
'''             The R command may include parameters and an assignment part.
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Insert, update and delete the R command's parameters.
'''     </description></item><item><description>
'''             Change the relative position of the R command's parameters.
'''     </description></item><item><description>
'''             Define what to assign to (e.g. data frame, column, model etc.).
'''     </description></item><item><description>
'''             Whether the assignment part has been created (or needs to be created).
'''     </description></item><item><description>
'''             Define what to do with the result returned from the R command (e.g. ignore, show 
'''             the result as text, show the result as a graph or store in a temporary variable).
'''     </description></item><item><description>
'''             Return the R command as an executable R string.
'''     </description></item>
''' </list>
'''             </summary>
'''--------------------------------------------------------------------------------------------
Public Class RCodeStructure
    ''' <summary>   If the output from the R command needs to be assigned, then this string is 
    '''             the part of the script to the left of the assignment operator ('&lt;-').
    '''             This could be a data frame, data frame colmun, model, graph, surv or table.
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

    ''' <summary>   If true then, <b>at the current stage</b> of running code within R, the output of
    '''             the R command needs to be assigned to:
    ''' <list type="bullet">
    '''     <item><description>
    '''                 The variable defined by 'strAssignTo'
    '''     </description></item><item><description>
    '''                 R elements such as data frame, columns, graphs, models etc. (only if 
    '''                 specified by the 'AssignTo...' variables).
    '''     </description></item>
    ''' </list>
    ''' </summary>
    Public bToBeAssigned As Boolean = False

    ''' <summary>   If true then the output of the R-command has been assigned to:
    ''' <list type="bullet">
    '''     <item><description>
    '''                 The variable defined by 'strAssignTo'
    '''     </description></item><item><description>
    '''                 R elements such as data frame, columns, graphs, models etc. (only if 
    '''                 specified by the 'AssignTo...' variables).
    '''     </description></item>
    ''' </list>
    '''             This variable is only relevant in the string case, as RFunction and
    '''             ROperator have internal equivalents.
    '''             <para>
    '''             Note: Both bToBeAssigned and bIsAssigned are needed. 
    '''             bToBeAssigned defines if the R command actually needs to be defined.
    '''             bIsAssigned defines if the R command has already been defined (only relevent 
    '''             if bToBeAssigned is true).
    '''             </para>
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

    ''' <summary>   The number of parameters associated with this R command.</summary>
    Protected iNumberOfAddedParameters As Integer = 0 'TODSO Is this used or needed? Couldn't we find the number of parameters from the num of elements in clsParameters?

    ''' <summary>   used as a constant to represent an undefined parameter position.
    '''             Note: This is currently only used in RSyntax as a before/after code to 
    '''             determine whether the position code should be run in the list.
    '''             </summary>
    Public iPosition = -1 ' TODO SJL 03/04/20 This seems to be a constant, should we declare it with 'const'? 
    'TODO SJL 03/04/20 - Also, it only seems to be used by RSyntax. Move the constant to that class and give it a less confusing name?

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
    Public iCallType As Integer = 0 'TODO SJL 03/04/20 In RInstat, iCallType only seems to be 0, 2 or 3. Are call types 1 and 4 used?

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
    '''             </summary>
    Public bClearFromGlobal As Boolean = False 'TODO SJL 03/04/20 This variable is never checked or set to true, can we remove?

    ''' <summary>   If true then 'clsRFunction.ToScript' and 'clsROperator.ToScript' return a string 
    '''             that can be passed to R (i.e. double quotes are replaced with single quotes, 
    '''             and the string is wrapped in double quotes).
    '''             <para>
    '''             For example: <c>seq(from = 1, to = 10)</c> becomes <c>"seq(from = 1, to = 10)"</c>.
    '''             </para><para>
    '''             Note: if true then the returned string can no longer be used for the 
    '''             function or its parameters because it will not produce the correct script
    '''             (i.e. it should not be true if 'bToBeAssigned' or 'bIsAssigned' is true.</para>
    '''             </summary>
    Public bToScriptAsRString As Boolean = False

    ''' <summary>   Tag object for any use. </summary>
    Public Tag As Object 'TODO SJL 03/04/20 This only seems to be used by dlgCalculationsSummary. Could we add something local to this dialog and then remove the tag from this calss?

    ''' <summary>   Event queue for all listeners interested in ParametersChanged events. </summary>
    Public Event ParametersChanged() 'TODO SJL 03/04/20 Is this used? Can it be removed?

    ''' <summary>   Executes the parameters changed action. 
    '''             </summary>
    Protected Sub OnParametersChanged()
        RaiseEvent ParametersChanged()
        'TODO SJL 03/04/20 Is this still used? Can it be removed?
        ' Currently only used when this is in RSyntax as a before/after code to determine if 
        ' position code should be run in the list. This is because RSyntax has iCallType and 
        ' bExcludeAssignedFunctionOutput which it uses for the base code. Eventually migrate these out of RSyntax.
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
    ''' <param name="strAdjacentColumn">            (Optional) The new value for strAdjacentColumn. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional strTempSurv As String = "", Optional strTempTable As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False, Optional bRequireCorrectLength As Boolean = True, Optional bDataFrameList As Boolean = False, Optional strDataFrameNames As String = "", Optional strAdjacentColumn As String = "")
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
        Me.strAdjacentColumn = strAdjacentColumn
        Me.bRequireCorrectLength = bRequireCorrectLength
        Me.bDataFrameList = bDataFrameList
        Me.strDataFrameNames = strDataFrameNames
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Resets all the 'AssignTo' variables. 
    '''             String variables are set to "".
    '''             Booleans are set to false. 
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveAssignTo()
        ' TODO SJL 03/04/20 should bRequireCorrectLength, bDataFrameList, strDataFrameNames also be reset?
        strAssignTo = ""
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
    ''' <summary>   Creates and returns the assignment part of the R script associated with this 
    '''             object. (i.e. the left side of the assignment, hereafter referred to as the 
    '''             'assign-to script').
    '''             The assign-to script may just be the name of the variable where the script 
    '''             stores the output (e.g. 'my_stations'). 
    '''             Or it may be a short R script, e.g. 
    '''             'data_book$get_columns_from_data(data_name="my_stations", col_names="Calc1")'.
    '''             <para>
    '''             This function is powerful but potentially confusing. It works as follows:
    '''             </para><para>
    '''             If the assign-to script is not needed then just returns <paramref name="strTemp"/>.
    '''             </para><para>
    '''             Else if the assign-to script already already exists then returns the existing 
    '''             assign-to script.
    '''             </para><para>
    '''             Else creates and returns a new assign-to script:
    '''             </para><para>
    '''             First, adds a new line (that includes the assignment part) to  
    '''             <paramref name="strScript"/> e.g. 
    '''             'new_RDS &lt;- readRDS(file=""C:/myDir/experimental_survey.RDS"")" &amp; vbCrLf'.
    '''             Note that the new line is appended to <paramref name="strScript"/>. This allows
    '''             <paramref name="strScript"/> to be built up into a multi-line script through 
    '''             successive (potentially recursive) calls of this function.
    '''             Note also that the right side of the assignment should be created by the 
    '''             child's 'ToScript' function, and passed to this function via <paramref name="strTemp"/>.
    '''             </para><para>
    '''             If the assign-to script requires an extra assign line (e.g. to assign to a 
    '''             dataframe, column, model, graph, surv or table) then adds these extra elements. 
    '''             The elements are added by creating an additional line of R script, and 
    '''             appending to <paramref name="strScript"/>. The additional line of R script is 
    '''             generated by creating a new 'RFunction', and then generating the script for this
    '''             new RFunction. Generating the script for the new 'RFunction' in turn generates 
    '''             a recursive call again to this function.
    '''             </para><para>
    '''             This function has a return value (the assign-to string). It also returns the 
    '''             entire R script via the 'ByRef' <paramref name="strScript"/> parameter. This
    '''             parameter can be thought of as a paragraph of R statements that, when executed,
    '''             generate the expected output for this object.
    '''             </para><para>
    '''             This function sets the value of several data members. It stores the new 
    '''             assign-to script in 'strAssignTo' (replacing the previous value stored).
    '''             This function also updates the 'bIsAssigned' and 'bToBeAssigned' flags that
    '''             store this object's assignment status.
    '''             </para></summary>
    '''
    ''' <param name="strScript">    [in,out] (Optional) The existing script including any 
    '''                             assignment part. This script may be multi-line.
    '''                             If the assignment requires extra elements (e.g. columns, models, 
    '''                             graphs etc.) then this script is updated to include the 
    '''                             addition of the new elements.
    '''                             This script may be built up, line by line, by successive calls 
    '''                             to this function.</param>
    ''' <param name="strTemp">      (Optional) The expression to assign (i.e. the right side of the
    '''                             assignment). </param>
    '''
    ''' <returns>   If object needs to be assigned to, then returns the assign-to script. 
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

            'Append the new script (including the intial assignment part) to 'strScript', e.g. 
            '    'my_stations <- rio::import(file=""C:/myDir/my_stations.csv"", stringsAsFactors=TRUE)" & vbCrLf'
            'Note1: The append allows 'strScript' to be built up into a multi-line string through successive calls of 'ToScript'
            'Note2: Initially, 'strAssignTo' is typically the name of the variable to assign the result of 'strTemp' to, e.g.
            '    'guinea_two_stations'.
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
                clsAddColumns.AddParameter("before", If(bInsertColumnBefore, "TRUE", "FALSE"))
                If Not String.IsNullOrEmpty(strAdjacentColumn) Then
                    clsAddColumns.AddParameter("adjacent_column", strAdjacentColumn)
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

                'append the next line of script to 'strScript' e.g. 
                '     "my_stations <- rio::import(file=""C:/myFolder/my_stations.csv"", stringsAsFactors=TRUE)" & vbCrLf 
                '      & "data_book$import_data(data_tables=list(my_stations=my_stations))" & vbCrLf
                strScript = strScript & clsAddData.ToScript() & Environment.NewLine

                clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataFrame & Chr(34))
                'Set 'strAssignTo' to final assign-to script 
                ' e.g. "data_book$get_columns_from_data(data_name=""my_stations"", col_names=""Calc1"")"
                strAssignTo = clsGetData.ToScript()
            End If
            bIsAssigned = True
            bToBeAssigned = False

            'return the final assign-to script 
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
    '''             If <paramref name="strTemp"/> is multiple lines then the assignment is done
    '''             on <paramref name="strTemp"/>'s last line. All previous lines are returned 
    '''             unchanged.
    '''             </summary>
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
        Dim arrScriptParts As String()
        If Not String.IsNullOrEmpty(strTemp) Then
            'if string contains more than one line, assign the last line of the multi-line string
            arrScriptParts = frmMain.clsRLink.GetRunnableCommandLines(strTemp)
            If arrScriptParts.Length > 1 Then
                're-assemble the string, apart from the last line
                strReconstructed = String.Join(Environment.NewLine, arrScriptParts, 0, arrScriptParts.Length - 1)
                'assign the last line of the multi-line string
                strReconstructed = strReconstructed & Environment.NewLine & strAssignTo & " <- " & arrScriptParts.Last
            Else
                'else if string has only one line, then assign to the whole string
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
    ''' <summary>   Creates and adds a parameter to this operator.
    '''             Sets the parameter's name to <paramref name="strParameterName"/>.
    '''             <para>Sets the parameter's argument to <b>one of</b> <paramref name="strParameterValue"/>,
    '''             <paramref name="clsRFunctionParameter"/>, <paramref name="clsROperatorParameter"/>,
    '''             or <paramref name="clsRCodeStructureParameter"/>.</para>
    '''             Sets the parameter's position and include/exclude argument name flag to 
    '''             <paramref name="iPosition"/> and <paramref name="bIncludeArgumentName"/> 
    '''             respectively.
    '''             </summary>
    '''
    ''' <param name="strParameterName">             (Optional) Name of the parameter. </param>
    ''' <param name="strParameterValue">            (Optional) The parameter value. </param>
    ''' <param name="clsRFunctionParameter">        (Optional) The R function parameter. </param>
    ''' <param name="clsROperatorParameter">        (Optional) The R operator parameter. </param>
    ''' <param name="clsRCodeStructureParameter">   (Optional) The R code structure parameter. </param>
    ''' <param name="bIncludeArgumentName">         (Optional) True to include, false to exclude the
    '''                                             argument name. </param>
    ''' <param name="iPosition">                    (Optional) (Optional) The relative position of the
    '''                                             parameter in this object's parameter list. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional clsRCodeStructureParameter As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        Dim clsParam = New RParameter

        If strParameterName = "" Then
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
        If Not strParameterValue = "" Then 'TODO SJL 03/04/20 If the caller specifies more than one of these parameters then the result may be unexpected. Safer use an enum parameter to enforce correct usage??
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
    ''' <summary>   TODO SJL 03/04/20 This function is not used, and is not overridden by any child classes. Can we remove?
    '''             </summary>
    '''
    ''' <param name="strParameterName">     (Optional) Name of the parameter. </param>
    ''' <param name="strParameterValue">    (Optional) The parameter value. </param>
    ''' <param name="clsRCodeObject">       (Optional) The R code structure parameter. </param>
    ''' <param name="bIncludeArgumentName"> (Optional) True to include, false to exclude the argument
    '''                                     name. </param>
    ''' <param name="iPosition">            (Optional) (Optional) The relative position of the
    '''                                     parameter in this object's parameter list. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub AddParameterWithCodeStructure(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRCodeObject As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        ' TODO Legacy - This should be call AddParameter but need to make it unambiguous with above. 
        ' TODO SJL 03/04/20 I think this function has a bug: If strParameterValue is specified then the
        ' clsRFunctionParameter and clsROperatorParameter parameters will be ignored.
        If TypeOf (clsRCodeObject) Is RFunction Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue,
                         clsRFunctionParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName,
                         iPosition:=iPosition)
        ElseIf TypeOf (clsRCodeObject) Is ROperator Then
            AddParameter(strParameterName:=strParameterName, strParameterValue:=strParameterValue,
                         clsROperatorParameter:=clsRCodeObject, bIncludeArgumentName:=bIncludeArgumentName,
                         iPosition:=iPosition)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If the object already has a parameter with the same name then changes the 
    '''             parameter's value to the value in <paramref name="clsNewParam"/>.
    '''             Else adds <paramref name="clsNewParam"/> to the object as a new parameter.
    '''             <para>
    '''             This function also ensures that there is no existing parameter with the same 
    '''             position as the newly added/updated parameter.</para>
    '''             </summary>
    '''
    ''' <param name="clsNewParam">  The new parameter to add. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub AddParameter(clsNewParam As RParameter)
        Dim i As Integer = -1
        Dim strTempArgumentName As String = clsNewParam.strArgumentName

        If clsParameters IsNot Nothing Then
            If clsNewParam.strArgumentName IsNot Nothing Then
                i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(strTempArgumentName))
            End If
            'if there's no existing parameter with the same name
            If i = -1 Then
                'ensure that there is no existing parameter with the same position
                ShiftParametersPositions(clsNewParam.Position)
                'add the new parameter
                clsParameters.Add(clsNewParam)
            Else 'else if a parameter with the same name already exists
                If clsNewParam.bIsString AndAlso clsNewParam.strArgumentValue IsNot Nothing Then
                    clsParameters(i).SetArgumentValue(clsNewParam.strArgumentValue)
                ElseIf (clsNewParam.bIsOperator OrElse clsNewParam.bIsFunction) AndAlso clsNewParam.clsArgumentCodeStructure IsNot Nothing Then
                    clsParameters(i).SetArgument(clsNewParam.clsArgumentCodeStructure)
                Else
                    'TODO SJL 03/04/20 Do something here?
                End If

                'if the parameter's position has changed
                If clsParameters(i).Position <> clsNewParam.Position Then
                    'Ensure that there is no existing parameter with the same position.
                    'Temporarily set the changed parameter's position to unordered until the other
                    'parameters have had their positions incremented (if needed).
                    clsParameters(i).Position = -1
                    If clsNewParam.Position <> -1 Then
                        ShiftParametersPositions(clsNewParam.Position)
                        clsParameters(i).Position = clsNewParam.Position
                    End If
                End If
            End If
        Else
            'TODO SJL 03/04/20 Do something here?
        End If
        bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        iNumberOfAddedParameters = iNumberOfAddedParameters + 1
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Ensures that there is no existing parameter with position <paramref name="iPosition"/>.
    '''             It does this by searching for a parameter with position <paramref name="iPosition"/>. 
    '''             If it finds one then it increments that parameter's position (and if needed, 
    '''             also increments the position of any subsequent parameters to avoid new 
    '''             duplications).
    '''             <para>
    '''             This function assumes that each existing parameter has a unique position.
    '''             </para> </summary>
    '''
    ''' <param name="iPosition">    The position that needs to be made free for a new parameter.
    '''                             If this parameter is less than zero then this function does 
    '''                             nothing.</param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ShiftParametersPositions(iPosition As Integer)
        'TODO SJL 03/04/20 if we sorted the parameter list by position (see functions below) then this function could be simpler

        Dim bReady As Boolean = False 'true if no more duplicate parameter positions potentially still exist
        Dim lstIndices As New List(Of Integer) 'list of indices of the parameters which have positions that need to be incremented

        If iPosition > -1 Then
            ' while duplicate parameter positions potentially still exist
            While Not bReady
                bReady = True
                'for each parameter
                For i As Integer = 0 To clsParameters.Count - 1
                    'If an existing parameter already has the required position
                    If clsParameters(i).Position = iPosition Then
                        ' The parameter with the duplicated position will have its position incremented. 
                        ' But this in turn may duplicate the position of another parameter.
                        ' So increment 'iPosition' so that this duplication is also checked for.
                        iPosition = iPosition + 1 ' TODO SJL 03/04/20 if there are more duplicates of iPosition then we won't find them. Should we check for this?
                        'store the index of the parameter with the duplicate position
                        lstIndices.Add(i)
                        'indicate that we need to iterate at least once more through all the parameters
                        bReady = False 'TODO SJL 03/04/20 All the parameters will be checked again in the next while loop iteration. Could we break out of the for loop here?
                    End If
                Next
            End While
            ' for each parameter with a duplicated position
            For Each iIndex As Integer In lstIndices
                ' increment that paremeter's position
                ' (the new position is guaranteed not to be a duplicate because of the checks done in the previous while loop)
                clsParameters(iIndex).Position = clsParameters(iIndex).Position + 1
            Next
        End If
    End Sub

    ''' <summary>   Sorts the parameters into position order. </summary>
    Public Sub SortParameters()
        'This sub is used to reorder the parameters according to their Position property.
        'It will be called only in places where it is necessary ie before ToScript or RemoveAdditionalParameters in ROperator.
        clsParameters.Sort(AddressOf CompareParametersPosition)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Compares the positions of <paramref name="clsMain"/> and <paramref name="clsRelative"/>.
    '''             If the 2 parameters have the same position then return 0.
    '''             If <paramref name="clsMain"/>'s position is less than
    '''             <paramref name="clsRelative"/>'s position, then return -1.
    '''             Else return 1.
    '''             </summary>
    '''
    ''' <param name="clsMain">      The first parameter. </param>
    ''' <param name="clsRelative">  The second parameter. </param>
    '''
    ''' <returns>   If the 2 parameters have the same position then returns 0.
    '''             If <paramref name="clsMain"/>'s position is less than 
    '''             <paramref name="clsRelative"/>'s position, then returns -1.
    '''             Else returns 1. </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function CompareParametersPosition(ByVal clsMain As RParameter, ByVal clsRelative As RParameter) As Integer
        'TODO SJL 04/04/20 As far as I can see, this function is functionally identical to 'clsMain.Position.CompareTo'.
        '                  Can we remove this function?
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

    ''' <summary>   Removes all parameters that do not have a specified position 
    '''             (i.e. parameter's position is -1).
    '''             </summary>
    Public Sub RemoveUnorderedParameters()
        'TODO SJL 03/04/20 This function is not used, remove it?
        Dim clsParam As RParameter
        'TODO SJL 03/04/20 This function only seems to remove the first unordered param, is this a bug?
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.Position = -1)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter named <paramref name="strArgName"/>. </summary>
    '''
    ''' <param name="strArgName">   Name of the parameter to remove. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameterByName(strArgName As String)
        Dim clsParam As RParameter

        ' TODO SJL 03/04/20 If there is no parameter with the required name then Find returns a default 
        '     RParameter, is this a problem?
        '     Remove will then try and remove this default parameter. It returns False if the removal 
        '     fails. Should we check this return value?
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam) '
        End If
        bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter with position <paramref name="iPosition"/>. </summary>
    '''
    ''' <param name="iPosition">    The position of the parameter to remove. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameterByPosition(iPosition As Integer)
        Dim clsParam As RParameter

        ' TODO SJL 03/04/20 If there is no parameter with the required position then Find returns a default 
        '     RParameter, is this a problem?
        '     Remove will then try and remove this default parameter. It returns False if the removal 
        '     fails. Should we check this return value?
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.Position = iPosition)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter <paramref name="clsParam"/>. </summary>
    '''
    ''' <param name="clsParam"> The parameter to remove. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub RemoveParameter(clsParam As RParameter)
        ' TODO SJL 03/04/20 Remove returns false if the removal fails. Should we check this return parameter?
        If Not clsParameters Is Nothing Then
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if <paramref name="clsParam"/> exists, else returns false. </summary>
    '''
    ''' <param name="clsParam"> The parameter to look for. </param>
    '''
    ''' <returns>   Returns true if <paramref name="clsParam"/> exists, else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function ContainsParameter(clsParam As RParameter) As Boolean
        Return clsParameters.Contains(clsParam)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if there is a parameter named <paramref name="strParameterName"/>,
    '''             else returns false. </summary>
    '''
    ''' <param name="strParameterName"> Name of the parameter to look for. </param>
    '''
    ''' <returns>   Returns true if there is a parameter named <paramref name="strParameterName"/>,
    '''             else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function ContainsParameter(strParameterName As String) As Boolean
        Return (clsParameters.FindIndex(Function(x) x.strArgumentName = strParameterName) <> -1)
    End Function

    ''' <summary>   Clears this object to its blank/initial state. </summary>
    Public Overridable Sub Clear()
        'TODO legacy  tidy up iPosition 
        iPosition = -1
        iCallType = 0
        bExcludeAssignedFunctionOutput = True
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
        OnParametersChanged() 'TODO SJL 03/04/20 can this line be removed?
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
    ''' <summary>   Adds this object and its associated assign script to <paramref name="lstCodes"/>
    '''             and <paramref name="lstValues"/> respectively.<para>
    '''             If this object's parameters also contain functions or operators then also 
    '''             recursively add their respective RCodeStructure objects and associated assign 
    '''             scripts to the respective lists.
    '''             </para> </summary>
    '''
    ''' <param name="lstCodes">     The list of RCodeStructure objects. </param>
    ''' <param name="lstValues">    The list of assign scripts . </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub GetAllAssignTo(lstCodes As List(Of RCodeStructure), lstValues As List(Of String))
        'TBD SJL 06/04/20 This is a 'get' function but it does not return any value! Rename?
        SortParameters()
        ' if this object is to be assigned, but is not yet in the lists
        If bToBeAssigned AndAlso Not lstCodes.Contains(Me) Then
            'add this object and its assign script to the respective lists
            lstCodes.Add(Me)
            lstValues.Add(strAssignTo)
        End If
        For Each clsTempParam As RParameter In clsParameters
            ' if parameter is a function or operator then also add its respective RCodeStructure
            '     objects and associated assign scripts to the respective lists.
            clsTempParam.GetAllAssignTo(lstCodes, lstValues)
        Next
    End Sub
End Class
