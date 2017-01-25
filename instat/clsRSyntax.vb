﻿' Instat+R
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


Public Class RSyntax
    'RSyntax is intended to store all the R-commands that are raised by the activity of a dialogue. 
    'So far, it consists in a main R-command (Base), that takes the form of: 
    '- an "RFunction", dealing with R-commands of the form __(__=__, __=__, ...), 
    '- "ROperator", dealing with R-commands of the form: __+__, 
    '- or more generally a string.
    'See also RLink to understand how these commands, as RSyntax fields, are then communicated to, and run in R.
    'Task: Adapt RSyntax to new style... 
    Public clsBaseFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public clsBaseCommandString As New RCodeStructure
    Public strCommandString As String = ""

    Public bUseBaseFunction As Boolean = False
    Public bUseBaseOperator As Boolean = False
    Public bUseCommandString As Boolean = False
    'Above, the three types of Base R-commands, and their associated "radio bottons booleans".
    Public iCallType As Integer = 0
    Public strScript As String
    Public i As Integer
    Public bExcludeAssignedFunctionOutput As Boolean = True

    Public Sub SetFunction(strFunctionName As String)
        'Warning: confusing name
        clsBaseFunction.SetRCommand(strFunctionName)
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub

    Public Sub SetBaseRFunction(clsFunction As RFunction)
        clsBaseFunction = clsFunction
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub
    'Both SetFunction and SetBaseRFunction set the Base R-command to the RFunction type, 
    'and set the clsBaseFunction by giving respectively the desired RFunction as parameter, or the R-command that characterizes the desired RFunction as parameter.
    Public Sub SetBaseROperator(clsOperator As ROperator)
        clsBaseOperator = clsOperator
        bUseBaseFunction = False
        bUseBaseOperator = True
        bUseCommandString = False
    End Sub

    Public Sub SetOperation(strOp As String, Optional bBracketTemp As Boolean = True)
        clsBaseOperator.SetOperation(strOp, bBracketTemp)
        bUseBaseFunction = False
        bUseBaseOperator = True
        bUseCommandString = False
    End Sub
    'Similarly, both SetBaseROperator and SetOperation set the Base R-command to the ROperator type, 
    'and set the clsBaseOperator by giving respectively the desired ROperator itself as parameter, or the desired R-command that characterize the desired ROperator as parameters.
    Public Sub SetCommandString(strCommand As String)
        strCommandString = strCommand
        bUseBaseFunction = False
        bUseBaseOperator = False
        bUseCommandString = True
    End Sub
    'In the string case, the class used for the Base R-command is simply a string...

    Public Sub SetAssignTo(strAssignToName As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False)
        If bUseBaseOperator Then
            clsBaseOperator.SetAssignTo(strTemp:=strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore)
        End If
        If bUseBaseFunction Then
            clsBaseFunction.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore)
        ElseIf bUseCommandString Then
            clsBaseCommandString.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore)
        End If
    End Sub

    Public Sub RemoveAssignTo()
        If bUseBaseOperator Then
            clsBaseOperator.RemoveAssignTo()
        End If
        If bUseBaseFunction Then
            clsBaseFunction.RemoveAssignTo()
        ElseIf bUseCommandString Then
            clsBaseCommandString.RemoveAssignTo()
        End If
    End Sub

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        clsBaseFunction.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, bIncludeArgumentName)
    End Sub

    Public Sub AddParameter(clsRParam As RParameter)
        clsBaseFunction.AddParameter(clsRParam)
    End Sub

    Public Function GetParameter(strName As String) As RParameter
        If bUseBaseFunction Then
            Return clsBaseFunction.GetParameter(strName)
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.GetParameter(strName)
        End If
        Return Nothing
    End Function

    'The two next methods need to be changed... all the corresponding files as well...
    Public Sub SetOperatorParameter(iPos As Boolean, Optional strParameterName As String = "", Optional strValue As String = "", Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        'This is temporary, just don't want to change all the files in one pull request... Will have to change the first argument to an integer...
        Dim iPosition As Integer
        If iPos Then
            iPosition = 0
        Else
            iPosition = -1
        End If
        clsBaseOperator.AddParameter(strParameterName, strValue, clsRFunc, clsOp, bIncludeArgumentName, iPosition)
    End Sub

    Public Sub SetOperatorParameter(iPosition As Integer, Optional strParameterName As String = "", Optional strValue As String = "", Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        'This will replace the above
        clsBaseOperator.AddParameter(strParameterName, strValue, clsRFunc, clsOp, bIncludeArgumentName, iPosition)
    End Sub

    Public Sub AddOperatorParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        clsBaseOperator.AddParameter(strParameterName, strParameterValue, clsRFunc, clsOp, bIncludeArgumentName)
    End Sub

    Public Sub RemoveParameter(strParameterName As String, Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If
        clsFunction.RemoveParameterByName(strParameterName)
    End Sub

    Public Sub RemoveOperatorParameter(strParameterName As String)
        clsBaseOperator.RemoveParameterByName(strParameterName)
    End Sub

    Public Sub ClearParameters(Optional ByRef clsFunction As RFunction = Nothing)
        If clsFunction Is Nothing Then
            clsFunction = clsBaseFunction
        End If

        clsFunction.ClearParameters()
    End Sub

    Public Function GetScript() As String

        Dim strTemp As String = ""

        If bUseBaseFunction Then
            strTemp = clsBaseFunction.ToScript(strScript)
        End If
        If bUseBaseOperator Then
            strTemp = clsBaseOperator.ToScript(strScript)
        ElseIf bUseCommandString Then
            strTemp = clsBaseCommandString.ToScript(strScript, strCommandString)
        End If
        If bExcludeAssignedFunctionOutput Then
            'Sometimes the output of the R-command we deal with should not be part of the script... That's only the case when this output has already been assigned.
            If (bUseBaseFunction AndAlso clsBaseFunction.bIsAssigned) OrElse (bUseBaseOperator AndAlso clsBaseOperator.bIsAssigned) OrElse (bUseCommandString AndAlso clsBaseCommandString.bIsAssigned) Then
                Return strScript
            End If
        End If
        Return strScript & strTemp
    End Function

    Public Function GetbIsAssigned() As Boolean
        If bUseBaseFunction Then
            Return clsBaseFunction.bIsAssigned
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.bIsAssigned
        ElseIf bUseCommandString Then
            Return clsBaseCommandString.bIsAssigned
        Else
            Return False
        End If
    End Function

    Public Function GetbToBeAssigned() As Boolean
        If bUseBaseFunction Then
            Return clsBaseFunction.bToBeAssigned
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.bToBeAssigned
        ElseIf bUseCommandString Then
            Return clsBaseCommandString.bToBeAssigned
        Else
            Return False
        End If
    End Function

    Public Function GetstrAssignTo() As String
        If bUseBaseFunction Then
            Return clsBaseFunction.strAssignTo
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.strAssignTo
        ElseIf bUseCommandString Then
            Return clsBaseCommandString.strAssignTo
        Else
            Return ""
        End If
    End Function

    Public Function GetstrAssignToColumn() As String
        If bUseBaseFunction Then
            Return clsBaseFunction.strAssignToColumn
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.strAssignToColumn
        ElseIf bUseCommandString Then
            Return clsBaseCommandString.strAssignToColumn
        Else
            Return ""
        End If
    End Function

    Public Function GetstrAssignToDataFrame() As String
        If bUseBaseFunction Then
            Return clsBaseFunction.strAssignToDataFrame
        ElseIf bUseBaseOperator Then
            Return clsBaseOperator.strAssignToDataFrame
        ElseIf bUseCommandString Then
            Return clsBaseCommandString.strAssignToDataFrame
        Else
            Return ""
        End If
    End Function

    ' WARNING These should only be called to reset previous values.
    ' They should generally not be set directly.
    Public Sub SetbIsAssigned(bNew As Boolean)
        If bUseBaseFunction Then
            clsBaseFunction.bIsAssigned = bNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.bIsAssigned = bNew
        ElseIf bUseCommandString Then
            clsBaseCommandString.bIsAssigned = bNew
        End If
    End Sub

    Public Sub SetbToBeAssigned(bNew As Boolean)
        If bUseBaseFunction Then
            clsBaseFunction.bToBeAssigned = bNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.bToBeAssigned = bNew
        ElseIf bUseCommandString Then
            clsBaseCommandString.bToBeAssigned = bNew
        End If
    End Sub

    Public Sub SetstrAssignTo(strNew As String)
        If bUseBaseFunction Then
            clsBaseFunction.strAssignTo = strNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.strAssignTo = strNew
        ElseIf bUseCommandString Then
            clsBaseCommandString.strAssignTo = strNew
        End If
    End Sub

    Public Sub SetstrAssignToColumn(strNew As String)
        If bUseBaseFunction Then
            clsBaseFunction.strAssignToColumn = strNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.strAssignToColumn = strNew
        ElseIf bUseCommandString Then
            clsBaseCommandString.strAssignToColumn = strNew
        End If
    End Sub

    Public Sub SetstrAssignToDataFrame(strNew As String)
        If bUseBaseFunction Then
            clsBaseFunction.strAssignToDataFrame = strNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.strAssignToDataFrame = strNew
        ElseIf bUseCommandString Then
            clsBaseCommandString.strAssignToDataFrame = strNew
        End If
    End Sub
End Class