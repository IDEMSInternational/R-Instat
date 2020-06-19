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
''' <summary>   An object of this class represents an R operation (e.g. 'x+y, 'x+y+z', '!x',
'''             'data_book &lt;- DataBook$new()' etc.).
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Insert and delete the R operator's parameters.
'''     </description></item><item><description>
'''             Create the R script that generates the expected output for this operation.
'''     </description></item>
''' </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class ROperator
    Inherits RCodeStructure

    'TODO Danny Parsons 15/04/20:
    ' There is some tidying of the code that can be done around this class relating to its 
    ' inheritance from RCodeStructure.
    ' 
    ' There are a number of functions which have both an RFunction And an ROperator as optional 
    ' parameters, with the idea that you usually pass in one or the other. These could be 
    ' replaced with a single RCodeStructure parameter. There are also classes which may store both 
    ' an RFunction and an ROperator but only ever expect one, so this may be able to be replaced 
    ' by an RCodeStructure.
    ' 
    ' There may be some functions within the RFunction And ROperator classes which could be pushed 
    ' down to the RCodeStructure because they actually do the same thing regardless of which one it 
    ' is. I think this has mostly already been done but I think I remember seeing one example of 
    ' this recently. <-- Note from Lloyd - GetParameter?
    '
    ' Both of these things exist because originally these two classes were separate before we 
    ' realised they should inherit from a common class. So  RCodeStructure was created later as the 
    ' parent class, so I think you can see the remains of this sort of being done backwards.
    '
    ' Another reason this hasn't been done is that much of this tidying up could affect every single 
    ' dialog so it's not clear how we coordinate this with all developers so that it doesn't cause a 
    ' huge number of conflicts. But it's something we should do at some point to improve the code.

    ''' <summary>   If true then include the operation symbol in the script even if there's 
    '''             only a single parameter (e.g. to create a script such as '!x').
    '''             Else don't include the operation symbol in a script with only one parameter.
    '''             </summary>
    Public bForceIncludeOperation As Boolean = False

    ''' <summary>   The operation symbol (e.g. "+"). </summary>
    Public strOperation As String

    ''' <summary>   If true then enclose first parameter in brackets. </summary>
    Public bBrackets As Boolean = True

    ''' <summary>   If true then enclose second, and any subsequent parameters, in brackets. </summary>
    Public bAllBrackets As Boolean = False

    ''' <summary>   If true then put spaces around operator e.g. " + ". </summary>
    Public bSpaceAroundOperation As Boolean = True

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Constructor. </summary>
    '''
    ''' <param name="strOp">            (Optional) The operation symbol (e.g. "+"). </param>
    ''' <param name="bBracketsTemp">    (Optional) If true then enclose first parameter in brackets.
    '''                                  </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub New(Optional strOp As String = "", Optional bBracketsTemp As Boolean = True)
        SetOperation(strOp, bBracketsTemp)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the operation's symbol (e.g. "+") and defines whether to include the first
    '''             operation parameter in brackets. </summary>
    '''
    ''' <param name="strTemp">          The operation symbol (e.g. "+"). </param>
    ''' <param name="bBracketsTemp">    (Optional) If true then enclose first parameter in brackets. 
    '''                                 </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Creates, updates and returns the script that generates the expected output for this 
    '''     operation. An operation will have an operation symbol (e.g. '+') and parameters.
    '''     <para>
    '''     This function aims to create a human-readable script. It appends the first parameter 
    '''     to <paramref name="strTemp"/> and then appends the operation symbol (e.g. appends'x+'). 
    '''     It then appends the remaining parameters using the same symbol (e.g. 'x+y+z'). 
    '''     Finally it calls the 'ToScript' function of the base class. This completes the script
    '''     by adding the assignment part.
    '''     </para><para>
    '''     Additional options:</para>
    ''' <list type="bullet">
    '''     <item><description>
    '''         If there's only one parameter, then the operation symbol may be put first (e.g. '!x').
    '''     </description></item><item><description>
    '''         The operation symbol may  be surrounded by spaces (e.g. '+' becomes ' + ').
    '''     </description></item><item><description>
    '''         Each parameter may be surrounded by brackets '()'.
    '''     </description></item><item><description>
    '''         "There is one further use of the operator which has proved really useful. That 
    '''         is the use of the ',' operator to define additional optional parameters. This Is 
    '''         sort of a cheat because of course it is not an operator in R but there are a number 
    '''         of cases where it has been useful to manage a set of parameters together. This also 
    '''         provides the reason why in that context it can make sense for that operator to have 
    '''         no operator symbols and no parameters!" - David Stern 15/04/20
    '''     </description></item>
    ''' </list></summary>
    ''' <param name="strScript">    [in,out] (Optional) The existing script including any
    '''                             assignment part. 
    '''                             This script is passed to the 'ToScript' function of the base 
    '''                             class. This script is also passed to the 'ToScript' function 
    '''                             of the operator's parameters. </param>
    ''' <param name="strTemp">      (Optional) The current expression to assign. The script for 
    '''                             this operation is appended to this parameter and then passed 
    '''                             to the 'ToScript' function of the base class. </param>
    '''
    ''' <returns> If object needs to be assigned to, then returns the complete assign-to script.
    '''           Else returns the script without an assignment part. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim strAdjustedOperation As String
        'TODO SJL 03/04/20 Parts of this function seem to duplicate the ToScript function in RFunction. Refactor?

        SortParameters()

        'if needed, put spaces around operator e.g. " <- "
        If bSpaceAroundOperation Then
            strAdjustedOperation = Chr(32) & strOperation & Chr(32)
        Else
            strAdjustedOperation = strOperation
        End If

        'if operator has parameters
        If clsParameters.Count > 0 Then

            'process first parameter
            If clsParameters(0) IsNot Nothing Then
                'if first parameter needs brackets, then append the first parameter inside brackets
                If clsParameters(0).bIsOperator AndAlso bBrackets Then
                    strTemp = strTemp & "(" & clsParameters(0).ToScript(strScript) & ")"
                Else 'else just append the parameter without brackets
                    strTemp = strTemp & clsParameters(0).ToScript(strScript)
                End If

                'if there is only one parameter, and we need to include the operation symbol
                If bForceIncludeOperation AndAlso clsParameters.Count = 1 Then
                    'if parameter's position is 0 then put parameter's script on left side 
                    If clsParameters(0).Position = 0 Then
                        strTemp = strTemp & strAdjustedOperation
                    Else 'else put parameter's script on right side
                        strTemp = strAdjustedOperation & strTemp
                    End If
                End If
            Else
                'TODO message
            End If

            'for each remaining parameter (starting from 2nd parameter)
            'Note: an operation may have >2 parameters (e.g. x+y+z ...)
            For Each clsParam In clsParameters.GetRange(1, clsParameters.Count - 1)
                'append the operator to the script
                strTemp = strTemp & strAdjustedOperation

                'if parameter needs brackets, then append the parameter inside brackets
                'TODO SJL 03/04/20 repeats code above. Refactor?
                If bAllBrackets AndAlso (clsParam.bIsFunction OrElse clsParam.bIsOperator) Then
                    strTemp = strTemp & "(" & clsParam.ToScript(strScript) & ")"
                Else 'else just append the parameter without brackets
                    strTemp = strTemp & clsParam.ToScript(strScript)
                End If
            Next

            'if the string needs to be passed directly to R
            ' TODO SJL 15/04/20 This functionality is duplicated in RFunction. Move this functionality to a shared function in RCodeStructure?
            If bToScriptAsRString Then
                'if string is intended to be assigned to a script then raise error (because modified script will no longer suitable for this)
                'TODO SJL 03/04/20 if we only allow these 3 flags to be accessed through 'set/get' functions then we can guarantee that this error situation doesn't occur
                'TODO Legacy comment:'should also check assignment of parameters'
                If bToBeAssigned OrElse bIsAssigned Then
                    MsgBox("Developer error: Using bToScriptAsRString = True when RFunction is assigned will not produce the correct script. Remove assignment to use this options correctly.")
                End If

                'replace double quotes with single quotes
                '  Note : Can't have double quotes ("") in the string because strTemp will be wrapped 
                '         with "". In most cases single quotes (') will give the same functionality, 
                '         though it's preferable to avoid this when constructing the RFunction.
                strTemp = strTemp.Replace(Chr(34), Chr(39))

                'wrap the entire string in double quotes
                strTemp = Chr(34) & strTemp & Chr(34)
            End If
        End If

        'if object needs to be assigned to, then create/update the assignment script (if needed) 
        '    and return the assignment script. Otherwise just return 'strTemp'.
        Return MyBase.ToScript(strScript, strTemp)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     If the object already has a parameter with the same name then changes the parameter's 
    '''     value to the value in <paramref name="clsParam"/>. Else adds <paramref name="clsParam"/> 
    '''     to the object as a new parameter.
    '''     <para>
    '''     This function also ensures that there is no existing parameter with the same position as
    '''     the newly added/updated parameter.
    '''     </para><para>
    '''     Note about parameter names for operators: They are not named in the display when you do 
    '''     ToScript() on an ROperator compared to an RFunction, but they are named within this 
    '''     class since the naming is used to be able to identify them for the purpose of adding 
    '''     and removing. We usually use the naming convention "0", "1", "2"... for ROperator 
    '''     parameters so that there is no confusion about the order. 
    '''     </para><para>
    '''     Note about parameter position for operators: By default, when the script for this 
    '''     operator is created then the operator is placed after the parameter (e.g. 'x + ').
    '''     However, if an operator has only one parameter, and that parameter's position is 0,
    '''     then this parameter will be put on the left side of the operation symbol (e.g. '!x'). 
    '''     </para></summary>
    '''
    ''' <param name="clsParam"> The new parameter to add. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub AddParameter(clsParam As RParameter)
        clsParam.bIncludeArgumentName = False 'an operator parameter shouldn't be named in the script
        MyBase.AddParameter(clsParam)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Returns the parameter object named <paramref name="strName"/>.
    ''' </summary>
    '''
    ''' <param name="strName">  The name of the parameter to return. </param>
    '''
    ''' <returns>   A new RParameter object. </returns>
    '''--------------------------------------------------------------------------------------------
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

    ''' <summary>   Removes all additional parameters. </summary>
    Public Sub RemoveAllAdditionalParameters()
        'TODO SJL 03/04/20 this function is only used by 1 dialog. This hints that there may be an alternative way of doing the same thing.
        '   It's also suspicious that the other RCodeStructure classes don't have such a function. Why is it only needed for an operator? 
        '   Can this function be removed?
        SortParameters() 'This is used to bring the parameter with position 0 to the front if it exists, then clear all the others using range.
        If clsParameters(0).Position = 0 Then
            If clsParameters.Count > 1 Then
                clsParameters.RemoveRange(1, clsParameters.Count - 1)
            End If
        Else
            clsParameters.Clear()
        End If
        OnParametersChanged()
    End Sub

    ''' <summary>   Clears this object to its blank/initial state. </summary>
    Public Overrides Sub Clear()
        SetOperation("")
        bForceIncludeOperation = False
        MyBase.Clear()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a deep copy of this object. </summary>
    '''
    ''' <returns>   A copy of this object. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Function Clone() As RCodeStructure
        Dim clsTempROperator As New ROperator
        Dim clsRParam As RParameter

        'RCode properties
        clsTempROperator.strAssignTo = strAssignTo
        clsTempROperator.strAssignToDataFrame = strAssignToDataFrame
        clsTempROperator.strAssignToColumn = strAssignToColumn
        clsTempROperator.strAssignToModel = strAssignToModel
        clsTempROperator.strAssignToGraph = strAssignToGraph
        clsTempROperator.strAssignToTable = strAssignToTable
        clsTempROperator.bToBeAssigned = bToBeAssigned
        clsTempROperator.bIsAssigned = bIsAssigned
        clsTempROperator.bAssignToIsPrefix = bAssignToIsPrefix
        clsTempROperator.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
        clsTempROperator.bInsertColumnBefore = bInsertColumnBefore
        clsTempROperator.iNumberOfAddedParameters = iNumberOfAddedParameters
        clsTempROperator.iPosition = iPosition
        clsTempROperator.iCallType = iCallType
        clsTempROperator.bExcludeAssignedFunctionOutput = bExcludeAssignedFunctionOutput
        clsTempROperator.bClearFromGlobal = bClearFromGlobal
        clsTempROperator.bToScriptAsRString = bToScriptAsRString
        clsTempROperator.Tag = Tag
        For Each clsRParam In clsParameters
            clsTempROperator.AddParameter(clsRParam.Clone())
        Next

        'ROperator specific properties
        clsTempROperator.bForceIncludeOperation = bForceIncludeOperation
        clsTempROperator.strOperation = strOperation
        clsTempROperator.bBrackets = bBrackets
        clsTempROperator.bAllBrackets = bAllBrackets
        clsTempROperator.bSpaceAroundOperation = bSpaceAroundOperation

        Return clsTempROperator
    End Function
End Class