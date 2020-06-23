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
''' <summary>   An object of this class represents an R parameter.
'''             <para>
'''             This class provides methods and fields to:</para>
''' <list type="bullet">
'''     <item><description>
'''             Set the parameter's name and type.
'''     </description></item><item><description>
'''             Set the parameter's position in relation to the associated R command's other 
'''             parameters.
'''     </description></item><item><description>
'''             Create the R script associated with this parameter.
'''     </description></item>
''' </list>
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class RParameter
    ''' <summary>   The parameter's name. This is only used if the parameter's name needs to be 
    '''             included in the R script (see 'bIncludeArgumentName' below).</summary>
    Public strArgumentName As String

    ''' <summary>   The parameter's argument value. Only used if the parammter's argument is a 
    '''             string. This can either be a simple string value, or 
    '''             it can be an RFunction or ROperator (then stored as an RCodeStructure).</summary>
    Public strArgumentValue As String

    ''' <summary>   The paramer's argument RCodeStructure object. Only used if the parameter's
    '''             argument is a function or operator. </summary>
    Public clsArgumentCodeStructure As RCodeStructure

    'TODO SJL 03/04/20 The argument must be exclusively either a string, function or operator.
    '    Would an enumeration be better than 3 booleans?

    ''' <summary>   If true then the parameter's argument is a function. </summary>
    Public bIsFunction As Boolean = False

    ''' <summary>   If true then the parameter's argument is an operator. </summary>
    Public bIsOperator As Boolean = False

    ''' <summary>   If true then the parameter's argument is a string. </summary>
    Public bIsString As Boolean = False

    ''' <summary>   This parameter's (zero-based) position in relation to the associated 
    '''             R command's other parameters.<para>
    '''             For example, parameters with positions a 0, b 2, c 5, d 3 will be sorted 
    '''             as a, b, d, c. </para><para>
    '''             Note that a position of 0 has a special meaning for ROperators with only one 
    '''             parameter. In this case, a position of 0 means that the parameter will be put 
    '''             on the left side of the operation symbol (e.g. '!x')</para>
    '''             </summary> 
    Private iPosition As Integer = -1

    ''' <summary>   If true then include the name of the parameter in the R script 
    '''             (e.g. 'dir="C:/Users/myName/InstatObject/R"'. </summary>
    Public bIncludeArgumentName As Boolean = True

    ''' <summary>   Default constructor. </summary>
    Public Sub New()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Constructor for a named parameter.</summary>
    '''
    ''' <param name="strParameterName">         The parameter's name. </param>
    ''' <param name="iNewPosition">             (Optional) The parameter's (zero-based) position 
    '''                                         in relation to the associated R command's other 
    '''                                         parameters. </param>
    ''' <param name="bNewIncludeArgumentName">  (Optional) If true then include the name of the 
    '''                                         parameter in the R script. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub New(strParameterName As String, Optional iNewPosition As Integer = -1, Optional bNewIncludeArgumentName As Boolean = True)
        SetArgumentName(strParameterName)
        Position = iNewPosition
        bIncludeArgumentName = bNewIncludeArgumentName
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Constructor for a named parameter with an assigned string value.</summary>
    '''
    ''' <param name="strParameterName">         The parameter's name. </param>
    ''' <param name="strParamValue">            The parameter's string value. </param>
    ''' <param name="iNewPosition">             (Optional) The parameter's (zero-based) position
    '''                                         in relation to the associated R command's other
    '''                                         parameters. </param>
    ''' <param name="bNewIncludeArgumentName">  (Optional) If true then include the name of the
    '''                                         parameter in the R script. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub New(strParameterName As String, strParamValue As String, Optional iNewPosition As Integer = -1, Optional bNewIncludeArgumentName As Boolean = True)
        SetArgumentName(strParameterName)
        SetArgumentValue(strParamValue)
        Position = iNewPosition
        bIncludeArgumentName = bNewIncludeArgumentName
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Constructor for a named parameter with an assigned function or operator. 
    '''             </summary>
    '''
    ''' <param name="strParameterName">         The parameter's name. </param>
    ''' <param name="strParamValue">            The parameter's function or operator. </param>
    ''' <param name="iNewPosition">             (Optional) The parameter's (zero-based) position
    '''                                         in relation to the associated R command's other
    '''                                         parameters. </param>
    ''' <param name="bNewIncludeArgumentName">  (Optional) If true then include the name of the
    '''                                         parameter in the R script. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub New(strParameterName As String, strParamValue As RCodeStructure, Optional iNewPosition As Integer = -1, Optional bNewIncludeArgumentName As Boolean = True)
        SetArgumentName(strParameterName)
        SetArgument(strParamValue)
        Position = iNewPosition
        bIncludeArgumentName = bNewIncludeArgumentName
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Gets or sets the parameter's position in the parameter list. </summary>
    '''--------------------------------------------------------------------------------------------
    Public Property Position As Integer
        'Position is the property associated to the iPosition.
        Get
            Return iPosition
        End Get
        Set(ByVal Value As Integer)
            If Value <> iPosition Then 'TODO SJL 03/04/20 remove this if statement?
                iPosition = Value
                ''RaiseEvent PositionChanged()
            End If
        End Set
    End Property

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets argument name. </summary>
    '''
    ''' <param name="strTemp">  The temporary. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetArgumentName(strTemp As String)
        strArgumentName = strTemp 'TODO SJL 03/04/20 this data member is public, delete this function?
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the parameter's argument value to a string. </summary>
    '''
    ''' <param name="strTemp">  The parameter's string value. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetArgumentValue(strTemp As String)
        strArgumentValue = strTemp
        bIsFunction = False
        bIsOperator = False
        bIsString = True
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Sets the parameter's argument value to a function or operator. </summary>
    '''
    ''' <param name="clsArg">   The parameter's function or operator. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub SetArgument(clsArg As RCodeStructure)
        clsArgumentCodeStructure = clsArg
        bIsString = False
        If TypeOf (clsArg) Is RFunction Then
            bIsFunction = True
            bIsOperator = False
        ElseIf TypeOf (clsArg) Is ROperator Then
            bIsOperator = True
            bIsFunction = False
        Else
            'message
            bIsOperator = False
            bIsFunction = False
        End If
    End Sub

    ''' <summary>   Clears all arguments. </summary>
    Public Sub ClearAllArguments()
        strArgumentValue = ""
        clsArgumentCodeStructure = Nothing
        bIsString = False
        bIsOperator = False
        bIsFunction = False
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Creates and returns the R script associated with this parameter. </summary>
    '''
    ''' <param name="strScript">    [in,out] The existing script to be passed to the
    '''                             'ToScript' function of the parameter's operator or function.
    '''                             If parameter is a string then this is not used. </param>
    '''
    ''' <returns>   The R script associated with this parameter. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function ToScript(ByRef strScript As String) As String
        Dim strRet As String = ""

        'if the parameter's argument name is needed, then prefix it to the script
        If strArgumentName <> "" AndAlso bIncludeArgumentName Then
            strRet = strArgumentName & "="
        End If

        'if parameter is a function or operator, then append the function/operator script to the return string
        'TODO SJL 03/04/20 simplify this if statement to 'If bIsString Then ... Else ...'?
        If bIsFunction OrElse bIsOperator Then
            strRet = strRet & clsArgumentCodeStructure.ToScript(strScript) 'e.g. set 'strRet' to "data_RDS=new_RDS"
            'else if parameter is a string then just append it
        ElseIf bIsString Then
            strRet = strRet & strArgumentValue 'e.g. set 'strRet' to "dir=""C:/Users/myName/InstatObject/R"""
        ElseIf clsArgumentCodeStructure IsNot Nothing Then
            strRet = strRet & clsArgumentCodeStructure.ToScript(strScript)
            'message
        Else
            'message
        End If
        Return strRet
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Returns true if the parameter has a value, otherwise returns false. The value 
    '''             may be a string, function or operator). </summary>
    '''
    ''' <returns>   True if the parameter has a value, otherwise returns false. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function HasValue() As Boolean
        If bIsString Then
            Return strArgumentValue IsNot Nothing
        ElseIf bIsFunction OrElse bIsOperator OrElse clsArgumentCodeStructure IsNot Nothing Then
            Return clsArgumentCodeStructure IsNot Nothing
        Else
            Return False
        End If
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Makes a deep copy of this object.  </summary>
    '''
    ''' <returns>   A copy of this object. </returns>
    '''--------------------------------------------------------------------------------------------
    Public Function Clone() As RParameter
        Dim clsTempRParam As New RParameter

        clsTempRParam.strArgumentName = strArgumentName
        clsTempRParam.strArgumentValue = strArgumentValue
        clsTempRParam.bIsFunction = bIsFunction
        clsTempRParam.bIsOperator = bIsOperator
        clsTempRParam.bIsString = bIsString
        clsTempRParam.iPosition = iPosition
        clsTempRParam.bIncludeArgumentName = bIncludeArgumentName
        If clsArgumentCodeStructure IsNot Nothing Then
            clsTempRParam.clsArgumentCodeStructure = clsArgumentCodeStructure.Clone
        End If
        Return clsTempRParam
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   If this parameter is a function or operator, then adds this parameter's 
    '''             function/operator and its associated R script to <paramref name="lstCodes"/>
    '''             and <paramref name="lstValues"/> respectively.<para>
    '''             If this parameter's function/operator parameters also contain functions or 
    '''             operators, then also recursively adds these operators/functions/scripts to the 
    '''             respective lists.
    '''             </para></summary>
    '''
    ''' <param name="lstCodes">     The existing list of functions/operators. </param>
    ''' <param name="lstValues">    The existing list the functions/operators' R scripts. </param>
    '''--------------------------------------------------------------------------------------------
    Public Sub GetAllAssignTo(lstCodes As List(Of RCodeStructure), lstValues As List(Of String))
        If bIsFunction OrElse bIsOperator Then
            clsArgumentCodeStructure.GetAllAssignTo(lstCodes, lstValues)
        End If
    End Sub
End Class