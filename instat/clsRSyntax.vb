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
    'RSyntax is intended to store all the R-commands that are raised by the activity of a dialogue. 
    'So far, it consists in a main R-command (Base), that takes the form of: 
    '- an "RFunction", dealing with R-commands of the form __(__=__, __=__, ...), 
    '- "ROperator", dealing with R-commands of the form: __+__, 
    '- or more generally a string.
    'See also RLink to understand how these commands, as RSyntax fields, are then communicated to, and run in R.
    Public clsBaseFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public strCommandString As String = ""
    Public bUseBaseFunction As Boolean = False
    Public bUseBaseOperator As Boolean = False
    Public bUseCommandString As Boolean = False
    'Above, the three types of Base R-commands, and their associated "radio bottons booleans".
    Public iCallType As Integer = 0
    Public strScript As String
    Public i As Integer
    Public bExcludeAssignedFunctionOutput As Boolean = True
    Private strAssignTo As String
    'strAssignTo is the name that should be used to assign in R the output of the main (Base) R-command.
    Private strAssignToDataframe As String
    Private strAssignToColumn As String
    Private strAssignToModel As String
    Private strAssignToGraph As String
    'These AssingTo's are only relevant in the string case, as RFunction and ROperator have internal equivalents.
    Public bToBeAssigned As Boolean = False
    'bToBeAssigned is a boolean telling whether or not, AT THE CURRENT STAGE of running code within R, the output of the Base R-command NEEDS TO BE assigned to the variable with the appropriate name: strAssignTo.
    Public bIsAssigned As Boolean = False
    'bIsAssigned tells blindly whether or not the variabe with the appropriate name has been assigned to the output of the Base R-command.
    Private bAssignToIsPrefix As Boolean
    Private bAssignToColumnWithoutNames As Boolean
    Private bInsertColumnBefore As String

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
        End If
        If bUseCommandString Then
            strAssignTo = strAssignToName
            If Not strTempDataframe = "" Then
                strAssignToDataframe = strTempDataframe
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
            Me.bAssignToIsPrefix = bAssignToIsPrefix
            Me.bAssignToColumnWithoutNames = bAssignToColumnWithoutNames
            Me.bInsertColumnBefore = bInsertColumnBefore
            bToBeAssigned = True
            bIsAssigned = False
        End If
    End Sub

    Public Sub RemoveAssignTo()
        If bUseBaseOperator Then
            clsBaseOperator.RemoveAssignTo()
        End If
        If bUseBaseFunction Then
            clsBaseFunction.RemoveAssignTo()
        End If
        If bUseCommandString Then
            strAssignTo = ""
            strAssignToDataframe = ""
            strAssignToColumn = ""
            strAssignToModel = ""
            bToBeAssigned = False
            bIsAssigned = False
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

    Public Sub SetOperatorParameter(bSetFirst As Boolean, Optional strParameterName As String = "", Optional strValue As String = "", Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        clsBaseOperator.SetParameter(bSetFirst, strParameterName, strValue, clsParam, clsRFunc, clsOp, bIncludeArgumentName)
    End Sub

    Public Sub AddOperatorParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing, Optional bIncludeArgumentName As Boolean = True)
        clsBaseOperator.AddAdditionalParameter(strParameterName, strParameterValue, clsRFunc, clsOp, bIncludeArgumentName)
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

    Public Function GetScript(Optional ByRef clsFunction As RFunction = Nothing) As String

        Dim strTemp As String = ""

        If IsNothing(clsFunction) Then
            If bUseBaseFunction Then
                clsFunction = clsBaseFunction
                strTemp = clsBaseFunction.ToScript(strScript)
            End If
            If bUseBaseOperator Then
                strTemp = clsBaseOperator.ToScript(strScript)
            End If
            If bUseCommandString Then
                Dim clsAddColumns As New RFunction
                Dim clsGetColumns As New RFunction
                Dim clsAddData As New RFunction
                Dim clsGetData As New RFunction
                Dim clsAddModels As New RFunction
                Dim clsGetModels As New RFunction
                Dim clsAddGraphs As New RFunction
                Dim clsGetGraphs As New RFunction
                Dim clsDataList As New RFunction

                strTemp = strCommandString
                If bToBeAssigned Then
                    If Not frmMain.clsRLink.bInstatObjectExists Then
                        frmMain.clsRLink.CreateNewInstatObject()
                    End If
                    strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
                    If Not strAssignToDataframe = "" AndAlso (Not strAssignToColumn = "" OrElse bAssignToColumnWithoutNames) Then
                        clsAddColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
                        clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
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
                        strScript = strScript & clsAddColumns.ToScript() & vbCrLf

                        clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
                        clsGetColumns.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                        clsGetColumns.AddParameter("col_name", Chr(34) & strAssignToColumn & Chr(34))
                        strAssignTo = clsGetColumns.ToScript()

                        bIsAssigned = True
                        bToBeAssigned = False
                    ElseIf Not strAssignToModel = "" Then
                        clsAddModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_model")
                        clsAddModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                        clsAddModels.AddParameter("model", strAssignTo)
                        If Not strAssignToDataframe = "" Then
                            clsAddColumns.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                            clsGetModels.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                        End If
                        strScript = strScript & clsAddModels.ToScript() & vbCrLf

                        clsGetModels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
                        clsGetModels.AddParameter("model_name", Chr(34) & strAssignToModel & Chr(34))
                        strAssignTo = clsGetModels.ToScript()

                        bIsAssigned = True
                        bToBeAssigned = False
                    ElseIf Not strAssignToGraph = "" Then
                        clsAddGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_graph")
                        clsAddGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                        clsAddGraphs.AddParameter("graph", strAssignTo)
                        If Not strAssignToDataframe = "" Then
                            clsAddGraphs.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                            clsGetGraphs.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                        End If
                        strScript = strScript & clsAddGraphs.ToScript() & vbCrLf

                        clsGetGraphs.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_graphs")
                        clsGetGraphs.AddParameter("graph_name", Chr(34) & strAssignToGraph & Chr(34))
                        strAssignTo = clsGetGraphs.ToScript()

                        bIsAssigned = True
                        bToBeAssigned = False
                    ElseIf Not strAssignToDataframe = "" Then
                        clsAddData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
                        clsDataList.SetRCommand("list")
                        clsDataList.AddParameter(strAssignToDataframe, strAssignTo)
                        clsAddData.AddParameter("data_tables", clsRFunctionParameter:=clsDataList)
                        strScript = strScript & clsAddData.ToScript() & vbCrLf

                        clsGetData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
                        clsGetData.AddParameter("data_name", Chr(34) & strAssignToDataframe & Chr(34))
                        strAssignTo = clsGetData.ToScript()

                        bIsAssigned = True
                        bToBeAssigned = False
                    End If
                    strTemp = strAssignTo
                Else
                    'Return strTemp
                End If
            End If
        Else
            strTemp = clsFunction.ToScript(strScript)
        End If
        If bExcludeAssignedFunctionOutput Then
            If (bUseBaseFunction AndAlso clsFunction.bIsAssigned) OrElse (bUseBaseOperator AndAlso clsBaseOperator.bIsAssigned) OrElse (bUseCommandString AndAlso bIsAssigned) Then
                Return strScript
                Exit Function
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
            Return bIsAssigned
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
            Return bToBeAssigned
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
            Return strAssignTo
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
            bIsAssigned = bNew
        End If
    End Sub

    Public Sub SetbToBeAssigned(bNew As Boolean)
        If bUseBaseFunction Then
            clsBaseFunction.bToBeAssigned = bNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.bToBeAssigned = bNew
        ElseIf bUseCommandString Then
            bToBeAssigned = bNew
        End If
    End Sub

    Public Sub SetstrAssignTo(strNew As String)
        If bUseBaseFunction Then
            clsBaseFunction.strAssignTo = strNew
        ElseIf bUseBaseOperator Then
            clsBaseOperator.strAssignTo = strNew
        ElseIf bUseCommandString Then
            strAssignTo = strNew
        End If
    End Sub
End Class