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
''' <summary>   This class encapsulates the R commands associated with a specific dialog box.
'''             It is a composite of the RCodeStructure, RFunction, ROperator and RParameter 
'''             classes. It provides a single interface for using these classes.
'''             <para>
'''             An object of this Class represents <b>either</b> an R Function, an R Operator
'''             or a generic R command. This R function/operation/command is known as the
'''             'base R command'. </para><para>
'''             An object of this class may also include a list of R commands to be executed 
'''             before/after the base R command.</para><para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Add/remove/sort parameters for the 'base R command'.
'''     </description></item><item><description>
'''             Manage other configuration settings of the 'base R command'.
'''     </description></item><item><description>
'''             Get the R script associated with the 'base R command'.
'''     </description></item><item><description>
'''             Manage the lists of R commands to be executed before/after the 'base R command'.
'''     </description></item><item><description>
'''             Get the R scripts associated with the  lists of R commands to be executed 
'''             before/after the 'base R command'.
'''     </description></item>
''' </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class RSyntax
    ''' <summary>   If true then don't include the output part in the script (i.e. the part of the 
    '''             script to the left of the assignment operator '&lt;-'). </summary>
    Public bExcludeAssignedFunctionOutput As Boolean = True

    ''' <summary>   If true then run the R script in a separate thread. </summary>
    Public bSeparateThread As Boolean = True

    ''' <summary>   TODO SJL 07/04/20 Is only ever Nothing (or in one rare case False). Remove? </summary>
    Public bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing

    ' An object of this class is associated with a base R code. This R code must be (only one of):
    '   - An R function,
    '   - An R operator
    '   - A generic R command
    ' 
    ' Use the 3 booleans below to set the type
    ' 'TODO SJL It's not valid for an object of this class to be more than one of the 3 types above. 
    '     However the booleans potentially allow this. Replace with an enumeration?

    ''' <summary>   If true then use 'clsBaseFunction' as this object's base R code. </summary>
    Public bUseBaseFunction As Boolean = False

    ''' <summary>   If true then use 'clsBaseOperator' as this object's base R code. </summary>
    Public bUseBaseOperator As Boolean = False

    ''' <summary>   If true then use 'clsBaseCommandString' as this object's base R code. </summary>
    Public bUseCommandString As Boolean = False


    ''' <summary>   An R command (of any type). </summary>
    Public clsBaseCommandString As New RCodeStructure 'TODO SJL 17/04/20 What's the connection between this and 'bUseCommandString' and 'strCommandString'? 

    ''' <summary>   An R function of the form 'RCommand(param1=param1Val, param2=param2Val, ...)'. </summary>
    Public clsBaseFunction As New RFunction

    ''' <summary>   An R operation of the form 'leftSide Operator rightSide' (e.g. "x+y"). </summary>
    Public clsBaseOperator As New ROperator

    ''' <summary>   Defines how to display the R output.
    ''' <list type="bullet">
    '''     <item><description>0 Ignore the result.</description></item>
    '''     <item><description>1 Store result in a temporary variable, then output the variable's 
    '''                          value as text.</description></item>
    '''     <item><description>2 Show the result as text.</description></item>
    '''     <item><description>3 Show the result as a graph.</description></item>
    '''     <item><description>4 Show the result in a web browser.</description></item>
    ''' </list> </summary>
    Public iCallType As Integer = 0 'TODO SJL 07/04/20 Use enumeration?

    ''' <summary>   The R command in the form of a string. </summary>
    Public strCommandString As String = ""


    ''' <summary>   The R functions/operators/commands that should be run before the base R code. </summary>
    Private lstBeforeCodes As New List(Of RCodeStructure)

    ''' <summary>   The R functions/operators/commands that should be run after the base R code. </summary>
    Private lstAfterCodes As New List(Of RCodeStructure)


    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Adds a parameter to the function. Sets the parameter's name to
    '''     <paramref name="strParameterName"/>.<para>
    '''     Sets the parameter's argument to <b>one of</b> <paramref name="strParameterValue"/>,
    '''     <paramref name="clsRFunctionParameter"/>, <paramref name="clsROperatorParameter"/>,
    '''     or <paramref name="clsRCodeStructureParameter"/>.</para>
    ''' </summary>
    '''
    ''' <param name="strParameterName">             (Optional) Name of the parameter. </param>
    ''' <param name="strParameterValue">            (Optional) The parameter value. </param>
    ''' <param name="clsRFunctionParameter">        (Optional) The R function parameter. </param>
    ''' <param name="clsROperatorParameter">        (Optional) The R operator parameter. </param>
    ''' <param name="clsRCodeStructureParameter">   (Optional) The R code structure parameter. </param>
    ''' <param name="bIncludeArgumentName">         (Optional) True to include, false to exclude the
    '''                                             argument name. </param>
    ''' <param name="iPosition">                    (Optional) The relative position of the 
    '''                                             parameter in this object's parameter list.</param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional clsRCodeStructureParameter As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        'TODO SJL 17/04/20 This function should only be used if this class encapsulates a function. But it doesn't check the booleans for this.
        clsBaseFunction.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, clsRCodeStructureParameter, bIncludeArgumentName, iPosition)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds R function/operation/command <paramref name="clsNewRCode"/> to the 
    '''             'after' list. </summary>
    '''
    ''' <param name="clsNewRCode">  The R function/operation/command to add. </param>
    ''' <param name="iPosition">    (Optional) The relative position of the parameter in this 
    '''                             object's 'after' list. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AddToAfterCodes(clsNewRCode As RCodeStructure, Optional iPosition As Integer = -1)
        If Not lstAfterCodes.Contains(clsNewRCode) Then
            lstAfterCodes.Add(clsNewRCode)
            clsNewRCode.iPosition = iPosition 'TODO SJL 06/04/20 remove this line and the 'Else' (see AddToBeforeCodes)?
        Else
            lstAfterCodes.Find(Function(x) x.Equals(clsNewRCode)).iPosition = iPosition
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds R function/operation/command <paramref name="clsNewRCode"/> to the 
    '''             'before' list. </summary>
    '''
    ''' <param name="clsNewRCode">  The R function/operation/command to add. </param>
    ''' <param name="iPosition">    (Optional) The relative position of the parameter in this 
    '''                             object's 'before' list. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub AddToBeforeCodes(clsNewRCode As RCodeStructure, Optional iPosition As Integer = -1)
        If Not lstBeforeCodes.Contains(clsNewRCode) Then
            lstBeforeCodes.Add(clsNewRCode)
        End If
        lstBeforeCodes.Find(Function(x) x.Equals(clsNewRCode)).iPosition = iPosition
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Resets all the data members to default values. </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub ClearCodes()
        lstBeforeCodes = New List(Of RCodeStructure)
        lstAfterCodes = New List(Of RCodeStructure)
        clsBaseFunction = New RFunction
        clsBaseOperator = New ROperator
        clsBaseCommandString = New RCodeStructure
        strCommandString = ""
        bUseBaseFunction = False
        bUseBaseOperator = False
        bUseCommandString = False
        'TODO SJL 19/03/24 also reset iCallType?
        'iCallType = 0
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if the <paramref name="clsRCode"/> R function/operator/command is
    '''             the R function/operator/command associated with this object. Also returns true 
    '''             if <paramref name="clsRCode"/> is in this object's 'before' or 'after' lists. 
    '''             Else returns false.
    '''             </summary>
    '''
    ''' <param name="clsRCode"> The R function/operator/command to search for. </param>
    '''
    ''' <returns>   True if the <paramref name="clsRCode"/> R function/operator/command is
    '''             the R function/operator/command associated with this object. Also returns true
    '''             if <paramref name="clsRCode"/> is in this object's 'before' or 'after' lists.
    '''             Else returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function ContainsCode(clsRCode As RCodeStructure) As Boolean
        Return (clsBaseFunction IsNot Nothing AndAlso clsBaseFunction.Equals(clsRCode)) _
                OrElse (clsBaseOperator IsNot Nothing _
                        AndAlso clsBaseOperator.Equals(clsRCode) _
                        AndAlso clsBaseOperator.Equals(clsRCode)) _
                OrElse lstBeforeCodes.Contains(clsRCode) _
                OrElse lstAfterCodes.Contains(clsRCode)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the list of 'after' R functions/operators/commands (i.e. the ones that
    '''             run after the base R code). </summary>
    '''
    ''' <returns>   The list of 'after' R functions/operators/commands (i.e. the ones that run
    '''             after the base R code). </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetAfterCodes() As List(Of RCodeStructure)
        lstAfterCodes.Sort(AddressOf CompareCodePositions)
        Return lstAfterCodes
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Adds this object and its associated assign script to <paramref name="lstCodes"/>
    '''             and <paramref name="lstValues"/> respectively.<para>
    '''             If this object's parameters also contain functions or operators then also 
    '''             recursively adds their respective RCodeStructure objects and associated assign 
    '''             scripts to the respective lists.
    '''             If this object has lists of 'before' or 'after' functions/operators/commands, 
    '''             then also adds these objects and their associated assign scripts to the 
    '''             respective lists.
    '''             </para> </summary>
    '''
    ''' <param name="lstCodes">     The list of RCodeStructure objects. </param>
    ''' <param name="lstValues">    The list of assign scripts . </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub GetAllAssignTo(lstCodes As List(Of RCodeStructure), lstValues As List(Of String))
        If bUseBaseFunction Then
            clsBaseFunction.GetAllAssignTo(lstCodes, lstValues)
        ElseIf bUseBaseOperator Then
            clsBaseOperator.GetAllAssignTo(lstCodes, lstValues)
        ElseIf bUseCommandString Then
            clsBaseCommandString.GetAllAssignTo(lstCodes, lstValues)
        End If
        lstBeforeCodes.Sort(AddressOf CompareCodePositions)
        For Each clsTempCode As RCodeStructure In lstBeforeCodes
            clsTempCode.GetAllAssignTo(lstCodes, lstValues)
        Next
        lstAfterCodes.Sort(AddressOf CompareCodePositions)
        For Each clsTempCode As RCodeStructure In lstAfterCodes
            clsTempCode.GetAllAssignTo(lstCodes, lstValues)
        Next
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the list of 'before' R functions/operators/commands (i.e. the ones that 
    '''             run before the base R code). </summary>
    '''
    ''' <returns>   The list of 'before' R functions/operators/commands (i.e. the ones that run 
    '''             before the base R code). </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetBeforeCodes() As List(Of RCodeStructure)
        lstBeforeCodes.Sort(AddressOf CompareCodePositions)
        Return lstBeforeCodes
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns all the function names in the 'before' and 'after' lists. If this object
    '''             is an R function then also return the name of this function. </summary>
    '''
    ''' <returns>   All the function names in the 'before' and 'after' lists. If this object
    '''             is an R function then also return the name of this function. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetFunctionNames() As List(Of String)
        Dim lstNames As New List(Of String)
        Dim clsTempFunc As RFunction

        If clsBaseFunction IsNot Nothing Then
            lstNames.Add(clsBaseFunction.strRCommand)
        End If
        For Each clsRCode As RCodeStructure In lstBeforeCodes
            clsTempFunc = TryCast(clsRCode, RFunction)
            If clsTempFunc IsNot Nothing Then
                lstNames.Add(clsTempFunc.strRCommand)
            End If
        Next
        For Each clsRCode As RCodeStructure In lstAfterCodes
            clsTempFunc = TryCast(clsRCode, RFunction)
            If clsTempFunc IsNot Nothing Then
                lstNames.Add(clsTempFunc.strRCommand)
            End If
        Next
        Return lstNames
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the script associated with this object's R function, R operator or 
    '''             R command string. 
    '''             If this object is flagged to exclude the script's output, and the output has 
    '''             already been assigned, then the returned script does not include the output 
    '''             part.</summary>
    '''
    ''' <returns>   The script associated with this object's R function, R operator or R command 
    '''             string. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetScript() As String
        Dim strTemp As String = ""
        Dim strScript As String = ""

        If bUseBaseFunction Then
            strTemp = clsBaseFunction.ToScript(strScript)
        ElseIf bUseBaseOperator Then
            strTemp = clsBaseOperator.ToScript(strScript)
        ElseIf bUseCommandString Then
            strTemp = clsBaseCommandString.ToScript(strScript, strCommandString)
        End If

        If bExcludeAssignedFunctionOutput Then
            'Sometimes the output of the R-command we deal with should not be part of the script...  
            'That's only the case when this output has already been assigned.
            If (bUseBaseFunction AndAlso clsBaseFunction.IsAssigned()) OrElse
                (bUseBaseOperator AndAlso clsBaseOperator.IsAssigned()) OrElse
                (bUseCommandString AndAlso clsBaseCommandString.IsAssigned()) Then
                Return strScript
            End If
        End If
        Return strScript & strTemp
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the list of scripts associated with the <paramref name="lstCodes"/> 
    '''             list of R functions/operators/commands.
    '''             If a list object is flagged to exclude the script's output, and the output has 
    '''             already been assigned, then the list object's script does not include the output 
    '''             part.</summary>
    '''
    ''' <param name="lstCodes"> The list of R functions/operators/commands. </param>
    '''
    ''' <returns>   list of scripts associated with the <paramref name="lstCodes"/>
    '''             list of R functions/operators/commands. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function GetScriptsFromCodeList(lstCodes As List(Of RCodeStructure)) As List(Of String)
        Dim strItemScript As String
        Dim strTemp As String
        Dim lstScripts As New List(Of String)

        For Each clsTempCode In lstCodes
            strItemScript = ""
            strTemp = clsTempCode.ToScript(strItemScript)
            'Sometimes the output of the R-command we deal with should not be part of the script... 
            If clsTempCode.bExcludeAssignedFunctionOutput AndAlso Not String.IsNullOrEmpty(clsTempCode.GetRObjectToAssignTo) Then
                lstScripts.Add(strItemScript)
            Else
                lstScripts.Add(strItemScript & strTemp)
            End If
        Next
        Return lstScripts
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Resets all the 'AssignTo' variables. 
    '''             String variables are set to "".
    '''             Booleans are set to false. 
    '''             </summary>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveAssignTo()
        If bUseBaseOperator Then
            clsBaseOperator.RemoveAssignTo()
        End If
        If bUseBaseFunction Then 'TODO SJL 04/04/20 should this be ElseIf?
            clsBaseFunction.RemoveAssignTo()
        ElseIf bUseCommandString Then
            clsBaseCommandString.RemoveAssignTo()
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Removes <paramref name="clsNewRCode"/> from the statements executed after the 
    ''' base statement.</summary>
    '''
    ''' <param name="clsNewRCode">  The R statement to remove. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveFromAfterCodes(clsNewRCode As RCodeStructure)
        lstAfterCodes.Remove(clsNewRCode)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary> Removes <paramref name="clsNewRCode"/> from the statements executed before the 
    ''' base statement.</summary>
    '''
    ''' <param name="clsNewRCode">  The R statement to remove. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveFromBeforeCodes(clsNewRCode As RCodeStructure)
        lstBeforeCodes.Remove(clsNewRCode)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Removes the parameter named <paramref name="strParameterName"/>. </summary>
    '''
    ''' <param name="strParameterName"> Name of the parameter. </param>
    ''' <param name="clsFunction">      [in,out] (Optional) The function to add the parameter to.
    '''                                 If not specified then adds the parameter to 'clsBaseFunction'. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub RemoveParameter(strParameterName As String, Optional ByRef clsFunction As RFunction = Nothing)
        'TODO SJL 17/04/20 This function should only be used if this class encapsulates a function. But it doesn't check the booleans for this.
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.RemoveParameterByName(strParameterName)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>    Sets the 'assignTo' variables for this object's associated R function, R 
    '''              operation or R command string. </summary>
    '''
    ''' <param name="strAssignToName">              The new value for the assignment string. </param>
    ''' <param name="strTempDataframe">             (Optional) The new value for the dataframe. </param>
    ''' <param name="strTempColumn">                (Optional) The new value for the column. </param>
    ''' <param name="strTempModel">                 (Optional) The new value for the model. </param>
    ''' <param name="strTempGraph">                 (Optional) The new value for the graph. </param>
    ''' <param name="bAssignToIsPrefix">            (Optional) The new value for bAssignToIsPrefix. </param>
    ''' <param name="bAssignToColumnWithoutNames">  (Optional) The new value for bAssignToColumnWithoutNames. </param>
    ''' <param name="bInsertColumnBefore">          (Optional) The new value for bInsertColumnBefore. </param>
    ''' <param name="bRequireCorrectLength">        (Optional) The new value for bRequireCorrectLength. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetAssignTo(strAssignToName As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False, Optional bRequireCorrectLength As Boolean = True, Optional strAdjacentColumn As String = "")
        If bUseBaseOperator Then
            clsBaseOperator.SetAssignTo(strTemp:=strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength, strAdjacentColumn:=strAdjacentColumn)
        ElseIf bUseBaseFunction Then
            clsBaseFunction.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength, strAdjacentColumn:=strAdjacentColumn)
        ElseIf bUseCommandString Then
            clsBaseCommandString.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength, strAdjacentColumn:=strAdjacentColumn)
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets this object to be R function <paramref name="clsFunction"/>. </summary>
    '''
    ''' <param name="clsFunction">  The R function to associate with this object. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetBaseRFunction(clsFunction As RFunction)
        clsBaseFunction = clsFunction
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets this object to be R operator <paramref name="clsOperator"/>. </summary>
    '''
    ''' <param name="clsOperator">  The R operator to associate with this object. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetBaseROperator(clsOperator As ROperator)
        clsBaseOperator = clsOperator
        bUseBaseFunction = False
        bUseBaseOperator = True
        bUseCommandString = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets this object's R command to <paramref name="strCommand"/>. This object's 
    '''             R command is then just a string (rather than a function or operation object)
    '''             </summary>
    '''
    ''' <param name="strCommand">   The R command string. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetCommandString(strCommand As String)
        strCommandString = strCommand
        bUseBaseFunction = False
        bUseBaseOperator = False
        bUseCommandString = True
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the function's name (e.g. "facet_grid") and flags that the R script 
    '''             associated with this object is no longer correctly assigned.</summary>
    '''
    ''' <param name="strFunctionName">  Name of the R command. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetFunction(strFunctionName As String)
        clsBaseFunction.SetRCommand(strFunctionName)
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns the relative positions of <paramref name="clsMain"/> and 
    '''             <paramref name="clsRelative"/>.
    '''             If both have the same position then returns 0.
    '''             If <paramref name="clsMain"/> is positioned before, then returns -1.
    '''             If <paramref name="clsRelative"/> is positioned before, then returns 1. </summary>
    '''
    ''' <param name="clsMain">      First object to compare </param>
    ''' <param name="clsRelative">  Second object to compare. </param>
    '''
    ''' <returns>   The relative positions of <paramref name="clsMain"/> and <paramref name="clsRelative"/>.
    '''             If both have the same position then returns 0.
    '''             If <paramref name="clsMain"/> is positioned before, then returns -1.
    '''             If <paramref name="clsRelative"/> is positioned before, then returns 1.
    '''             </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function CompareCodePositions(ByVal clsMain As RCodeStructure, ByVal clsRelative As RCodeStructure) As Integer
        'Compares two RParameters according to their Position property. If x is "smaller" than y, then return -1, if they are "equal" return 0 else return 1.
        If clsMain.iPosition = clsRelative.iPosition Then
            Return 0
        ElseIf clsRelative.iPosition = -1 Then
            Return -1
        ElseIf clsMain.iPosition = -1 Then
            Return 1
        Else
            Return clsMain.iPosition.CompareTo(clsRelative.iPosition)
        End If
    End Function

End Class