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

Imports instat.Translations
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

    '--------------------------------------------------------------
    'todo. the properties in this block should eventually be private
    'start block

    ''' <summary>   
    ''' If the output from the R command needs to be assigned, then this string is 
    ''' the part of the script to the left of the assignment operator ('&lt;-').
    ''' This could be a data frame, data frame colmun, model, graph etc.
    ''' If the output from the R command doesn't to be assigned, then this string is null or empty. 
    ''' </summary>
    Protected _strAssignToObject As String
    Protected _strAssignToName As String
    Protected _strAssignToObjectTypeLabel As String
    Protected _strAssignToObjectFormat As String
    Public _strDataFrameNameToAddAssignToObject As String

    ''' <summary>   
    ''' If true then a list of data frames is assigned (i.e. the R "_strAssignToName" 
    ''' parameter needs to be an R string list).
    ''' </summary>
    Private _bDataFrameList As Boolean = False

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
    Private _strAdjacentColumn As String = ""

    ''' <summary>   If true then there is no effect.
    '''             If false then set the R "require_correct_length" parameter to false. 
    '''             Only used when assigning to a column.
    '''             </summary>
    Public bRequireCorrectLength As Boolean = True

    'end block
    '---------------------------------------------------------------------

    ''' <summary>   The list of parameters associated with this R code. </summary>
    Public clsParameters As New List(Of RParameter)

    ''' <summary>   The number of parameters associated with this R command.</summary>
    Protected iNumberOfAddedParameters As Integer = 0 'TODSO Is this used or needed? Couldn't we find the number of parameters from the num of elements in clsParameters?

    ''' <summary>   used as a constant to represent an undefined parameter position.
    '''             Note: This is currently only used in RSyntax as a before/after code to 
    '''             determine whether the position code should be run in the list.
    '''             </summary>
    Public iPosition = -1

    ''' <summary>Deprecated.  What to do with the result returned by executing the R code: 
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
    '''             Normally, the assignment part of the script should only be excluded if the assignement 
    '''             has been set. 
    '''             For example:
    '''             <code>
    '''                 If bExcludeAssignedFunctionOutput AndAlso IsAssigned Then
    '''                     'process script without assignment part
    '''                 Else
    '''                     'process script with assignment part 
    '''             </code>
    '''             </summary>
    Public bExcludeAssignedFunctionOutput As Boolean = True

    ''' <summary>   If true then 'clsRFunction.ToScript' and 'clsROperator.ToScript' return a string 
    '''             that can be passed to R (i.e. double quotes are replaced with single quotes, 
    '''             and the string is wrapped in double quotes).
    '''             <para>
    '''             For example: <c>seq(from = 1, to = 10)</c> becomes <c>"seq(from = 1, to = 10)"</c>.
    '''             </para><para>
    '''             Note: if true then the returned string can no longer be used for the 
    '''             function or its parameters because it will not produce the correct script.</para>
    '''             </summary>
    Public bToScriptAsRString As Boolean = False

    ''' <summary>   Tag object for any use. </summary>
    Public Tag As Object 'TODO SJL 03/04/20 This only seems to be used by dlgCalculationsSummary. Could we add something local to this dialog and then remove the tag from this calss?


    '''--------------------------------------------------------------------------------------------
    ''' <summary> Deprecated.   
    ''' Sets the 'assignTo' variables. 
    ''' </summary>
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
    Public Sub SetAssignTo(strTemp As String,
                           Optional strTempDataframe As String = "",
                           Optional strTempColumn As String = "",
                           Optional strTempModel As String = "",
                           Optional strTempGraph As String = "",
                           Optional strTempSurv As String = "",
                           Optional strTempTable As String = "",
                           Optional bAssignToIsPrefix As Boolean = False,
                           Optional bAssignToColumnWithoutNames As Boolean = False,
                           Optional bInsertColumnBefore As Boolean = False,
                           Optional bRequireCorrectLength As Boolean = True,
                           Optional bDataFrameList As Boolean = False,
                           Optional strDataFrameNames As String = "",
                           Optional strAdjacentColumn As String = "")

        _strAssignToObject = strTemp

        If Not strTempDataframe = "" AndAlso Not strTempColumn = "" Then
            SetAssignToColumnObject(strColToAssignTo:=strTemp,
                                    strColName:=strTempColumn,
                                    strRDataFrameNameToAddObjectTo:=strTempDataframe,
                                    bAssignToIsPrefix:=bAssignToIsPrefix,
                                    bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames,
                                    bRequireCorrectLength:=bRequireCorrectLength,
                                    bInsertColumnBefore:=bInsertColumnBefore,
                                    strAdjacentColumn:=strAdjacentColumn)
            Return
        End If


        If Not strTempDataframe = "" Then
            If bDataFrameList Then
                SetAssignToDataFrameObject(strDataFrameToAssignTo:=strTemp,
                                          strDataFrameName:=strDataFrameNames,
                                           bDataFrameList:=True)
            Else
                SetAssignToDataFrameObject(strDataFrameToAssignTo:=strTemp,
                                           strDataFrameName:=strTempDataframe,
                                           bDataFrameList:=False)
            End If
            Return
        End If


        'for dialogs that produce objects shown to the output viewer
        'using this deprecated subroutine. call the SetAssignToRObject subroutine
        'this part can be deleted once all the dialogs that have these types of outputs are refactored
        Dim strNewRObjectTypeToAssignTo As String = ""
        Dim strNewRObjectTypeLabelToAssignTo As String = ""
        Dim strNewRObjectFormatToAssignTo As String = ""

        If Not strTempGraph = "" Then
            strNewRObjectTypeToAssignTo = strTempGraph
            strNewRObjectTypeLabelToAssignTo = RObjectTypeLabel.Graph
            strNewRObjectFormatToAssignTo = RObjectFormat.Image
        End If

        If Not strTempModel = "" Then
            strNewRObjectTypeToAssignTo = strTempModel
            strNewRObjectTypeLabelToAssignTo = RObjectTypeLabel.Model
            'assumption is, by default a model is in text format
            strNewRObjectFormatToAssignTo = RObjectFormat.Text
        End If

        If Not strTempTable = "" Then
            strNewRObjectTypeToAssignTo = strTempTable
            strNewRObjectTypeLabelToAssignTo = RObjectTypeLabel.Table
            'assumption is, by default a table is in text format
            strNewRObjectFormatToAssignTo = RObjectFormat.Text
        End If

        If Not strTempSurv = "" Then
            strNewRObjectTypeToAssignTo = strTempSurv
            strNewRObjectTypeLabelToAssignTo = RObjectTypeLabel.StructureLabel
            'assumption is, by default a survival is in text format
            strNewRObjectFormatToAssignTo = RObjectFormat.Text
        End If

        If Not strNewRObjectTypeToAssignTo = "" Then
            SetAssignToOutputObject(strRObjectToAssignTo:=strNewRObjectTypeToAssignTo,
                          strRObjectTypeLabelToAssignTo:=strNewRObjectTypeLabelToAssignTo,
                          strRObjectFormatToAssignTo:=strNewRObjectFormatToAssignTo,
                          strRDataFrameNameToAddObjectTo:=strTempDataframe,
                          strObjectName:=strNewRObjectTypeToAssignTo)
        End If

    End Sub


    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Gets the assign to variable
    ''' </summary>
    ''' <returns>assign to value</returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetRObjectToAssignTo() As String
        Return _strAssignToObject
    End Function

    Public Function IsAssigned()
        Return Not String.IsNullOrEmpty(_strAssignToObject)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Sets the assign to variable for objects that will not be added in the data book and displayed in the output viewer.
    ''' For instance objects used as input parameters for other R funtions
    ''' </summary>
    ''' <param name="strRObjectToAssignTo">The new value for the R object assignment string</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToObject(strRObjectToAssignTo As String)
        _strAssignToObject = strRObjectToAssignTo
        _strAssignToObjectTypeLabel = ""
        _strAssignToObjectFormat = ""
        _strDataFrameNameToAddAssignToObject = ""
        _strAssignToName = ""
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Sets the assign to variables for objects that will be added to the databook and possibly displayed in the output viewer.
    ''' To prevent the object from being diplayed in the output viewer,
    ''' set bExcludeAssignedFunctionOutput = False (Not recommended, use the SetAssignToObject subroutine to get similar functionality).
    ''' </summary>
    ''' <param name="strRObjectToAssignTo">The new value for the R object assignment string</param>
    ''' <param name="strRObjectTypeLabelToAssignTo">The new value for the object type label</param>
    ''' <param name="strRObjectFormatToAssignTo">The new value for the object format</param>
    ''' <param name="strRDataFrameNameToAddObjectTo">The new value for the data frame name that the object will be added to.</param>
    ''' <param name="strObjectName">The new value for the object name</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignToOutputObject(strRObjectToAssignTo As String,
                                       strRObjectTypeLabelToAssignTo As String,
                                       strRObjectFormatToAssignTo As String,
                                       Optional strRDataFrameNameToAddObjectTo As String = "",
                                       Optional strObjectName As String = "")

        _strAssignToObject = strRObjectToAssignTo
        _strAssignToObjectTypeLabel = strRObjectTypeLabelToAssignTo
        _strAssignToObjectFormat = strRObjectFormatToAssignTo
        _strDataFrameNameToAddAssignToObject = strRDataFrameNameToAddObjectTo
        _strAssignToName = strObjectName
    End Sub

    Public Sub SetAssignToColumnObject(strColToAssignTo As String,
                                 strColName As String,
                                 strRDataFrameNameToAddObjectTo As String,
                                 Optional bAssignToIsPrefix As Boolean = False,
                                 Optional bAssignToColumnWithoutNames As Boolean = False,
                                 Optional bRequireCorrectLength As Boolean = True,
                                 Optional bInsertColumnBefore As Boolean = False,
                                 Optional strAdjacentColumn As String = "")

        _strAssignToObject = strColToAssignTo
        _strAssignToObjectTypeLabel = RObjectTypeLabel.Column
        _strDataFrameNameToAddAssignToObject = strRDataFrameNameToAddObjectTo
        _strAssignToName = strColName
        Me.bAssignToIsPrefix = bAssignToIsPrefix

        Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        Me.bInsertColumnBefore = bInsertColumnBefore
        _strAdjacentColumn = strAdjacentColumn
        Me.bRequireCorrectLength = bRequireCorrectLength
    End Sub

    Private Sub SetAssignToDataFrameObject(strDataFrameToAssignTo As String,
                                          strDataFrameName As String,
                                          Optional bDataFrameList As Boolean = False)

        _strAssignToObject = strDataFrameToAssignTo
        _strAssignToObjectTypeLabel = RObjectTypeLabel.Dataframe
        _strAssignToName = strDataFrameName
        _bDataFrameList = bDataFrameList
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Resets all the 'AssignTo' variables. 
    '''             String variables are set to "".
    '''             Booleans are set to false. 
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveAssignTo()
        ' TODO SJL 03/04/20 should bRequireCorrectLength, bDataFrameList, strDataFrameNames also be reset?

        bAssignToIsPrefix = False
        bAssignToColumnWithoutNames = False
        bInsertColumnBefore = False

        _strAssignToObject = ""
        _strAssignToName = ""
        _strAssignToObjectTypeLabel = ""
        _strAssignToObjectFormat = ""
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

        ' if R script still needs to be assigned to this object
        If Not String.IsNullOrEmpty(_strAssignToObject) Then

            Dim clsAddRObject As New RFunction
            Dim clsGetRObject As New RFunction
            Dim strRObject As String = _strAssignToObject

            'Append the new script (including the intial assignment part) to 'strScript', e.g. 
            '    'my_stations <- rio::import(file=""C:/myDir/my_stations.csv"", stringsAsFactors=TRUE)" & vbCrLf'
            'Note1: The append allows 'strScript' to be built up into a multi-line string through successive calls of 'ToScript'
            'Note2: Initially, 'strAssignTo' is typically the name of the variable to assign the result of 'strTemp' to, e.g.
            '    'guinea_two_stations'.

            strScript = strScript & ConstructAssignTo(_strAssignToObject, strTemp) & Environment.NewLine

            If _strAssignToObjectTypeLabel = RObjectTypeLabel.Column Then
                'for column object
                clsAddRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
                clsAddRObject.AddParameter("data_name", Chr(34) & _strDataFrameNameToAddAssignToObject & Chr(34))
                'if we need to assign to a named column
                If Not bAssignToColumnWithoutNames Then
                    clsAddRObject.AddParameter("col_name", Chr(34) & _strAssignToName & Chr(34))
                End If
                clsAddRObject.AddParameter("col_data", _strAssignToObject)
                If bAssignToIsPrefix Then
                    clsAddRObject.AddParameter("use_col_name_as_prefix", "TRUE")
                Else
                    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                        clsAddRObject.AddParameter("use_col_name_as_prefix", "FALSE")
                    End If
                End If
                clsAddRObject.AddParameter("before", If(bInsertColumnBefore, "TRUE", "FALSE"))
                If Not String.IsNullOrEmpty(_strAdjacentColumn) Then
                    clsAddRObject.AddParameter("adjacent_column", _strAdjacentColumn)
                End If
                If Not bRequireCorrectLength Then
                    clsAddRObject.AddParameter("require_correct_length", "FALSE")
                End If
                ' add '$add_columns_to_data' parameters to 'strScript' 
                ' e.g. "row_names1 <- data_book$get_row_names(data_name=""survey"")" & vbCrLf & "data_book$add_columns_to_data(data_name=""survey"", col_name=""row_names1"", col_data=row_names1, before=TRUE)" & vbCrLf
                strScript = strScript & clsAddRObject.ToScript() & Environment.NewLine

                'todo. when is this ever used? as of 11/11/2022, this code is not used during execution
                clsGetRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                clsGetRObject.AddParameter("data_name", Chr(34) & _strDataFrameNameToAddAssignToObject & Chr(34))
                clsGetRObject.AddParameter("col_names", Chr(34) & _strAssignToName & Chr(34))
                ' set 'strAssignTo' to e.g. "data_book$get_columns_from_data(data_name=""survey"", col_names=""row_names1"")"
                strRObject = clsGetRObject.ToScript()

            ElseIf _strAssignToObjectTypeLabel = RObjectTypeLabel.Dataframe Then
                'for data frame object
                clsAddRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")

                If _bDataFrameList Then
                    clsAddRObject.AddParameter("data_tables", _strAssignToObject, iPosition:=0)
                    If _strAssignToName <> "" Then
                        clsAddRObject.AddParameter("data_names", _strAssignToName, iPosition:=5)
                    End If
                Else
                    Dim clsDataList As New RFunction
                    clsDataList.SetRCommand("list")
                    clsDataList.AddParameter(_strAssignToName, _strAssignToObject)
                    clsAddRObject.AddParameter("data_tables", clsRFunctionParameter:=clsDataList, iPosition:=0)
                End If

                'append the next line of script to 'strScript' e.g. 
                '     "my_stations <- rio::import(file=""C:/myFolder/my_stations.csv"", stringsAsFactors=TRUE)" & vbCrLf 
                '      & "data_book$import_data(data_tables=list(my_stations=my_stations))" & vbCrLf
                strScript = strScript & clsAddRObject.ToScript() & Environment.NewLine

                'todo. when is this ever used? as of 11/11/2022, this code is not used during execution
                clsGetRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                clsGetRObject.AddParameter("data_name", Chr(34) & _strAssignToName & Chr(34))
                'Set 'strAssignTo' to final assign-to script 
                ' e.g. "data_book$get_columns_from_data(data_name=""my_stations"", col_names=""Calc1"")"
                strRObject = clsGetRObject.ToScript()

            ElseIf Not String.IsNullOrEmpty(_strAssignToObjectFormat) Then
                'for output objects like graphs, texts, table
                'set the R command and parameters for the add object R function. This is used for adding the object in the data book
                'set the R command and parameters for the get object R function. This is used for viewing the object.
                clsAddRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
                clsGetRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

                If Not String.IsNullOrEmpty(_strDataFrameNameToAddAssignToObject) Then
                    clsAddRObject.AddParameter("data_name", Chr(34) & _strDataFrameNameToAddAssignToObject & Chr(34))
                    clsGetRObject.AddParameter("data_name", Chr(34) & _strDataFrameNameToAddAssignToObject & Chr(34))
                End If

                clsGetRObject.AddParameter("object_name", Chr(34) & _strAssignToName & Chr(34))
                clsGetRObject.AddParameter("as_file", "TRUE")

                clsAddRObject.AddParameter("object_name", Chr(34) & _strAssignToName & Chr(34))
                clsAddRObject.AddParameter("object_type_label", Chr(34) & _strAssignToObjectTypeLabel & Chr(34))
                clsAddRObject.AddParameter("object_format", Chr(34) & _strAssignToObjectFormat & Chr(34))

                If _strAssignToObjectTypeLabel = RObjectTypeLabel.Graph Then
                    Dim clsCheckGraphRFunction As New RFunction
                    clsCheckGraphRFunction.SetPackageName("instatExtras")
                    clsCheckGraphRFunction.SetRCommand("check_graph")
                    clsCheckGraphRFunction.AddParameter("graph_object", _strAssignToObject)
                    clsAddRObject.AddParameter("object", clsRFunctionParameter:=clsCheckGraphRFunction)
                Else
                    clsAddRObject.AddParameter("object", strParameterValue:=_strAssignToObject)
                End If

                'construct the scripts 
                strScript = strScript & clsAddRObject.ToScript() & Environment.NewLine
                strRObject = clsGetRObject.ToScript()

            End If

            Return strRObject
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
        'todo. Use the R script library or move this function to a module
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
            ' MsgBoxTranslate("Developer Error: some parameter has been added without specifying a name. We want all
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
        'bIsAssigned = False 'parameters have changed so the output of the R command needs to be reassigned
        iNumberOfAddedParameters = iNumberOfAddedParameters + 1
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sorts the parameters into position order. </summary>
    '''--------------------------------------------------------------------------------------------
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
        iPosition = -1
        iCallType = 0
        bExcludeAssignedFunctionOutput = True
        bToScriptAsRString = False
        RemoveAssignTo()
        ClearParameters()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Clears the parameters. </summary>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Sub ClearParameters()
        clsParameters.Clear()
        iNumberOfAddedParameters = 0
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a deep copy of this object. </summary>
    '''
    ''' <returns>   A copy of this object. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overridable Function Clone() As RCodeStructure
        Dim clsTempCode As New RCodeStructure
        Dim clsRParam As RParameter

        clsTempCode._strAssignToObject = _strAssignToObject
        clsTempCode._strAssignToName = _strAssignToName
        clsTempCode._strAssignToObjectTypeLabel = _strAssignToObjectTypeLabel
        clsTempCode._strAssignToObjectFormat = _strAssignToObjectFormat
        clsTempCode._strDataFrameNameToAddAssignToObject = _strDataFrameNameToAddAssignToObject

        clsTempCode._bDataFrameList = _bDataFrameList
        clsTempCode.bAssignToIsPrefix = bAssignToIsPrefix
        clsTempCode.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        clsTempCode.bInsertColumnBefore = bInsertColumnBefore
        clsTempCode.iNumberOfAddedParameters = iNumberOfAddedParameters
        clsTempCode.iPosition = iPosition
        clsTempCode.iCallType = iCallType
        clsTempCode.bExcludeAssignedFunctionOutput = bExcludeAssignedFunctionOutput
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
        If Not String.IsNullOrEmpty(_strAssignToObject) AndAlso Not lstCodes.Contains(Me) Then
            'add this object and its assign script to the respective lists
            lstCodes.Add(Me)
            lstValues.Add(_strAssignToObject)
        End If
        For Each clsTempParam As RParameter In clsParameters
            ' if parameter is a function or operator then also add its respective RCodeStructure
            '     objects and associated assign scripts to the respective lists.
            clsTempParam.GetAllAssignTo(lstCodes, lstValues)
        Next
    End Sub
End Class