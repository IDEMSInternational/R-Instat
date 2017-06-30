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

Public Class RSyntax
    'RSyntax is intended to store all the R-commands that are raised by the activity of a dialog. 
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

    'Lists of code structures which run before/after the the base code
    Public lstBeforeCodes As New List(Of RCodeStructure)
    Public lstAfterCodes As New List(Of RCodeStructure)

    Public bUseBaseFunction As Boolean = False
    Public bUseBaseOperator As Boolean = False
    Public bUseCommandString As Boolean = False
    'Above, the three types of Base R-commands, and their associated "radio bottons booleans".
    Public iCallType As Integer = 0
    Public bHTMLOutput As Boolean = False
    Public strScript As String
    Public i As Integer
    Public bExcludeAssignedFunctionOutput As Boolean = True

    Public bSeparateThread As Boolean = True

    Public Sub SetFunction(strFunctionName As String)
        'Warning: confusing name
        clsBaseFunction.SetRCommand(strFunctionName)
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub

    Public Sub SetPackageName(strName As String)
        If clsBaseFunction Is Nothing Then
            MsgBox("Developer error: base function must be set before package name is set.")
        Else
            clsBaseFunction.SetPackageName(strName)
            bUseBaseFunction = True
            bUseBaseOperator = False
            bUseCommandString = False
        End If
    End Sub

    'Both SetFunction and SetBaseRFunction set the Base R-command to the RFunction type, 
    'and set the clsBaseFunction by giving respectively the desired RFunction as parameter, or the R-command that characterizes the desired RFunction as parameter.
    Public Sub SetBaseRFunction(clsFunction As RFunction)
        clsBaseFunction = clsFunction
        bUseBaseFunction = True
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub

    'Similarly, both SetBaseROperator and SetOperation set the Base R-command to the ROperator type, 
    'and set the clsBaseOperator by giving respectively the desired ROperator itself as parameter, or the desired R-command that characterize the desired ROperator as parameters.
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

    'In the string case, the class used for the Base R-command is simply a string...
    Public Sub SetCommandString(strCommand As String)
        strCommandString = strCommand
        bUseBaseFunction = False
        bUseBaseOperator = False
        bUseCommandString = True
    End Sub

    Public Sub SetAssignTo(strAssignToName As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional strTempGraph As String = "", Optional bAssignToIsPrefix As Boolean = False, Optional bAssignToColumnWithoutNames As Boolean = False, Optional bInsertColumnBefore As Boolean = False, Optional bRequireCorrectLength As Boolean = True)
        If bUseBaseOperator Then
            clsBaseOperator.SetAssignTo(strTemp:=strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength)
        End If
        If bUseBaseFunction Then
            clsBaseFunction.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength)
        ElseIf bUseCommandString Then
            clsBaseCommandString.SetAssignTo(strAssignToName, strTempDataframe:=strTempDataframe, strTempColumn:=strTempColumn, strTempModel:=strTempModel, strTempGraph:=strTempGraph, bAssignToIsPrefix:=bAssignToIsPrefix, bAssignToColumnWithoutNames:=bAssignToColumnWithoutNames, bInsertColumnBefore:=bInsertColumnBefore, bRequireCorrectLength:=bRequireCorrectLength)
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

    Public Sub AddParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True, Optional iPosition As Integer = -1)
        clsBaseFunction.AddParameter(strParameterName, strParameterValue, clsRFunctionParameter, clsROperatorParameter, bIncludeArgumentName, iPosition)
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
        ElseIf bUseBaseOperator Then
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

    Private Function GetScriptsFromCodeList(lstCodes As List(Of RCodeStructure)) As List(Of String)
        Dim strScript As String = ""
        Dim strTemp As String = ""
        Dim lstScripts As New List(Of String)

        For Each clsTempCode In lstCodes
            strTemp = clsTempCode.ToScript(strScript)
            'Sometimes the output of the R-command we deal with should not be part of the script... That's only the case when this output has already been assigned.
            If clsTempCode.bExcludeAssignedFunctionOutput AndAlso clsTempCode.bIsAssigned Then
                lstScripts.Add(strScript)
            Else
                lstScripts.Add(strScript & strTemp)
            End If
        Next
        Return lstScripts
    End Function

    Public Function GetBeforeCodesScripts() As List(Of String)
        lstBeforeCodes.Sort(AddressOf CompareCodePositions)
        Return GetScriptsFromCodeList(lstBeforeCodes)
    End Function

    Public Function GetBeforeCodes() As List(Of RCodeStructure)
        lstBeforeCodes.Sort(AddressOf CompareCodePositions)
        Return lstBeforeCodes
    End Function

    Public Function GetAfterCodesScripts() As List(Of String)
        lstAfterCodes.Sort(AddressOf CompareCodePositions)
        Return GetScriptsFromCodeList(lstAfterCodes)
    End Function

    Public Function GetAfterCodes() As List(Of RCodeStructure)
        lstAfterCodes.Sort(AddressOf CompareCodePositions)
        Return lstAfterCodes
    End Function

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

    Public Sub SortParameters()
        'This sub is used to reorder the parameters according to their Position property.
        'It will be called only in places where it is necessary ie before ToScript or RemoveAdditionalParameters in ROperator.
    End Sub

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

    Public Function BeforeCodesContain(clsNewRCode As RCodeStructure) As Boolean
        Return lstBeforeCodes.Contains(clsNewRCode)
    End Function

    Public Function AfterCodesContain(clsNewRCode As RCodeStructure) As Boolean
        Return lstAfterCodes.Contains(clsNewRCode)
    End Function

    Public Function BeforeCodesContain(strFunctionName As String) As Boolean
        Dim clsTempFunc As RFunction
        For Each clsRCode As RCodeStructure In lstBeforeCodes
            clsTempFunc = TryCast(clsRCode, RFunction)
            If clsTempFunc IsNot Nothing AndAlso clsTempFunc.strRCommand = strFunctionName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function AfterCodesContain(strFunctionName As String) As Boolean
        Dim clsTempFunc As RFunction
        For Each clsRCode As RCodeStructure In lstBeforeCodes
            clsTempFunc = TryCast(clsRCode, RFunction)
            If clsTempFunc IsNot Nothing AndAlso clsTempFunc.strRCommand = strFunctionName Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function ContainsCode(clsRCode As RCodeStructure) As Boolean
        Return (clsBaseFunction IsNot Nothing AndAlso clsBaseFunction.Equals(clsRCode)) OrElse (clsBaseOperator.Equals(clsRCode) AndAlso clsBaseOperator.Equals(clsRCode)) OrElse BeforeCodesContain(clsRCode) OrElse AfterCodesContain(clsRCode)
    End Function

    Public Function ContainsFunctionName(strFunctionName As String) As Boolean
        Return (clsBaseFunction IsNot Nothing AndAlso clsBaseFunction.strRCommand = strFunctionName) OrElse BeforeCodesContain(strFunctionName) OrElse AfterCodesContain(strFunctionName)
    End Function

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

    Public Sub AddToBeforeCodes(clsNewRCode As RCodeStructure, Optional iPosition As Integer = -1)
        If Not BeforeCodesContain(clsNewRCode) Then
            lstBeforeCodes.Add(clsNewRCode)
        End If
        lstBeforeCodes.Find(Function(x) x.Equals(clsNewRCode)).iPosition = iPosition
    End Sub

    Public Sub AddToAfterCodes(clsNewRCode As RCodeStructure, Optional iPosition As Integer = -1)
        If Not AfterCodesContain(clsNewRCode) Then
            lstAfterCodes.Add(clsNewRCode)
            clsNewRCode.iPosition = iPosition
        Else
            lstAfterCodes.Find(Function(x) x.Equals(clsNewRCode)).iPosition = iPosition
        End If
    End Sub

    Public Sub RemoveFromBeforeCodes(clsNewRCode As RCodeStructure)
        lstBeforeCodes.Remove(clsNewRCode)
    End Sub

    Public Sub RemoveFromAfterCodes(clsNewRCode As RCodeStructure)
        lstAfterCodes.Remove(clsNewRCode)
    End Sub

    Public Sub ClearCodes()
        lstBeforeCodes = New List(Of RCodeStructure)
        lstAfterCodes = New List(Of RCodeStructure)
        clsBaseFunction = Nothing
        clsBaseOperator = Nothing
        clsBaseCommandString = Nothing
        strCommandString = ""
        bUseBaseFunction = False
        bUseBaseOperator = False
        bUseCommandString = False
    End Sub
End Class