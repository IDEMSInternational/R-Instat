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
''' <summary>   An object of this class represents an R function of the form
'''             'RCommand(param1=param1Val, param2=param2Val, ...)'.
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Set the R function's package and command name.
'''     </description></item><item><description>
'''             Insert and update the R function's parameters.
'''     </description></item><item><description>
'''             Create the R script that generates the expected output for this function.
'''     </description></item>
''' </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class RFunction
    Inherits RCodeStructure

    ''' <summary>   The R command associated with this object (e.g. "plot").
    '''             Note that this variable only stores the command's name, it doesn't include any
    '''             the parameters associated with the command. </summary>
    Public strRCommand As String

    ''' <summary>   The R command's package name. </summary>
    Private strPackageName As String = ""

    ''' <summary>   Initializes a new instance of this class. </summary>
    Public Sub New()
        OnParametersChanged() 'TODO SJL is this still needed?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the R command's name (e.g. "facet_grid") and flags that the R script 
    '''             associated with this object is no longer correctly assigned.</summary>
    '''
    ''' <param name="strTemp">  Name of the R command. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetRCommand(strTemp As String)
        strRCommand = strTemp
        bIsAssigned = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets package name. </summary>
    '''
    ''' <param name="strName">  The package name </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetPackageName(strName As String)
        strPackageName = strName
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Creates, updates and returns the script that generates the expected output for this 
    '''     object. This script will have the form 'RCommand(param1=param1Val, param2=param2Val, ...)'.
    ''' </summary>
    '''
    ''' <param name="strScript">    [in,out] (Optional) The existing script including any
    '''                             assignment part.
    '''                             This script is passed to the 'ToScript' function of the base
    '''                             class. This script is also passed to the 'ToScript' function
    '''                             of the operator's parameters. </param>
    ''' <param name="strTemp">      (Optional) Ignored, only included so that this function overrides 
    '''                             its parent function. </param>
    '''
    ''' <returns>                   The script that generates the expected output for this object.
    ''' </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Function ToScript(Optional ByRef strScript As String = "", Optional strTemp As String = "") As String
        Dim i As Integer
        'TODO Legacy comment:'For method with OrderedIndices, replace clsParameters.count by Mybase.OrderedIndices.count and i by Mybase.OrderedIndices(i)'

        SortParameters()
        'if the object has an associated package name, then prefix the script with the package name
        If strPackageName <> "" Then
            strTemp = strPackageName & "::"
        End If

        'add each parameter to the script (e.g. "source(file=""Rsetup.R"")"
        strTemp = strTemp & strRCommand & "("
        For i = 0 To clsParameters.Count - 1 'e,g, set strTemp to "data_book$get_data_frame(convert_to_character=TRUE, max_cols=30, data_name=""survey"""
            If i > 0 Then
                strTemp = strTemp & ", "
            End If
            'append the script associated with the parameter (e.g. "max_cols=30")
            strTemp = strTemp & clsParameters(i).ToScript(strScript)
        Next

        'close final bracket e.g. set strTemp to "data_book$get_data_frame(convert_to_character=TRUE, max_cols=30, data_name=""survey"")"
        strTemp = strTemp & ")"

        'if the string needs to be passed directly to R
        If bToScriptAsRString Then
            'if string is intended to be assigned to a script then raise error (because modified script will no longer suitable for this)
            'TODO SJL if we only allow these 3 flags to be accessed through 'set/get' functions then we can guarantee that this error situation doesn't occur
            'TODO legacy comment:'should also check assignment of parameters'
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

        'if object needs to be assigned to then create/update the assignment script (if needed) 
        '    and return the assignment script. Otherwise just return 'strTemp'.
        Return MyBase.ToScript(strScript, strTemp)
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Adds a parameter to this function. Sets the parameter's name to
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
    Public Overrides Sub AddParameter(Optional strParameterName As String = "", Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional clsRCodeStructureParameter As RCodeStructure = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        'TODO SJL what's the purpose of overriding this function if it just calls the parent function?
        MyBase.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, clsRCodeStructureParameter, bIncludeArgumentName, iPosition)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     If the R function already has a parameter with the same name then changes the parameter's
    '''     value to the value in <paramref name="clsParam"/>. Else adds
    '''     <paramref name="clsParam"/> to the object as a new parameter.
    '''     <para>
    '''     This function also ensures that there is no existing parameter with the same position as
    '''     the newly added/updated parameter.</para>
    ''' </summary>
    '''
    ''' <param name="clsParam"> The new parameter to add. </param>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Sub AddParameter(clsParam As RParameter)
        'TODO SJL what's the purpose of overriding this function if it just calls the parent function?
        MyBase.AddParameter(clsParam)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Returns the parameter object named <paramref name="strName"/>.
    ''' </summary>
    '''
    ''' <param name="strName">  The name of the parameter to return. </param>
    '''
    ''' <returns>   The parameter object named <paramref name="strName"/>. If the parameter 
    '''             doesn't exist then returns 'Nothing'. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Overrides Function GetParameter(strName As String) As RParameter
        Dim iTempIndex As Integer = -1 'TODO SJL remove this variable?
        If Not clsParameters Is Nothing Then
            iTempIndex = clsParameters.FindIndex(Function(x) x.strArgumentName = strName)
            If iTempIndex <> -1 Then
                Return clsParameters(iTempIndex)
            End If
        End If
        Return Nothing
    End Function

    ''' <summary>   Clears this object to its blank/initial state. </summary>
    Public Overrides Sub Clear()
        SetRCommand("")
        SetPackageName("")
        MyBase.Clear()
    End Sub

    ''' <summary>   Clears the parameters. </summary>
    Public Overrides Sub ClearParameters()
        'TODO SJL what's the purpose of overriding this function if it just calls the parent function?
        MyBase.ClearParameters()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a deep copy of this object. </summary>
    '''
    ''' <returns>   A copy of this object. </returns>
    '''--------------------------------------------------------------------------------------------
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
        clsRFunction.Tag = Tag
        For Each clsRParam In clsParameters
            clsRFunction.AddParameter(clsRParam.Clone)
        Next

        'RFunction specific properties
        clsRFunction.strPackageName = strPackageName
        clsRFunction.strRCommand = strRCommand

        Return clsRFunction
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets the number of parameters. </summary>
    '''
    ''' <value> The number of parameters. </value>
    '''--------------------------------------------------------------------------------------------
    Public ReadOnly Property iParameterCount() As Integer
        Get
            Return clsParameters.Count
        End Get
    End Property
End Class