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

Public Class ROperator

    Public clsAdditionalParameters As New List(Of RParameter)

    Public clsLeftParameter As New RParameter
    Public clsLeftOperator As ROperator
    Public clsLeftFunction As RFunction

    'Public clsRightParameter As New RParameter
    'Public clsRightOperator As ROperator
    'Public clsRightFunction As RFunction

    Public strOperation As String
    Public bBrackets As Boolean = True

    Public strAssignTo As String
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public bToBeAssigned As Boolean = False
    Public bIsAssigned As Boolean = False
    Public bForceIncludeOperation As Boolean = True
    Public bAssignToIsPrefix As Boolean = False

    Public Sub SetOperation(strTemp As String, Optional bBracketsTemp As Boolean = True)
        strOperation = strTemp
        bBrackets = bBracketsTemp
        bIsAssigned = False
    End Sub

    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "", Optional bAssignToIsPrefix As Boolean = False)
        strAssignTo = strTemp
        If Not strTempDataframe = "" Then
            strAssignToDataFrame = strTempDataframe
            If Not strTempColumn = "" Then
                strAssignToColumn = strTempColumn
            End If
        ElseIf Not strTempModel = "" Then
            strAssignToModel = strTempModel
        End If
        bToBeAssigned = True
        bIsAssigned = False
    End Sub

    Public Sub RemoveAssignTo()
        strAssignTo = ""
        strAssignToDataFrame = ""
        strAssignToColumn = ""
        strAssignToModel = ""
        bToBeAssigned = False
        bIsAssigned = False
    End Sub

    Public Function ToScript(Optional ByRef strScript As String = "") As String
        Dim strTemp As String = ""
        Dim bIncludeOperation As Boolean

        'may not need this anymore I believe we can get rid of include operator entirely
        bIncludeOperation = bForceIncludeOperation OrElse ((clsLeftParameter IsNot Nothing OrElse clsLeftFunction IsNot Nothing OrElse clsLeftOperator IsNot Nothing) AndAlso (clsAdditionalParameters.Count > 0))

        If clsLeftParameter IsNot Nothing Then
            strTemp = strTemp & clsLeftParameter.ToScript(strScript, False)
        ElseIf clsLeftFunction IsNot Nothing Then
            strTemp = strTemp & clsLeftFunction.ToScript(strScript)
        ElseIf clsLeftOperator IsNot Nothing Then
            If bBrackets Then
                strTemp = strTemp & "(" & clsLeftOperator.ToScript(strScript) & ")"
            Else
                strTemp = strTemp & clsLeftOperator.ToScript(strScript)
            End If
        End If

        'If bIncludeOperation Then
        '    strTemp = strTemp & Chr(32) & strOperation & Chr(32)
        'End If

        'If clsRightParameter IsNot Nothing Then
        '    strTemp = strTemp & clsRightParameter.ToScript(strScript, False)
        'ElseIf clsrightFunction IsNot Nothing Then
        '    strTemp = strTemp & clsRightFunction.ToScript(strScript)
        'ElseIf clsrightOperator IsNot Nothing Then
        '    strTemp = strTemp & "(" & clsRightOperator.ToScript(strScript) & ")"
        'End If

        For Each clsParam In clsAdditionalParameters
            If bIncludeOperation Then
                strTemp = strTemp & Chr(32) & strOperation & Chr(32)
            End If
            strTemp = strTemp & clsParam.ToScript(strScript, False)
        Next

        If bToBeAssigned Then
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            Return strAssignTo
        Else
            Return strTemp
        End If
    End Function

    Public Sub SetParameter(bSetFirst As Boolean, Optional strParameterName As String = "Right", Optional strValue As String = "", Optional clsParam As RParameter = Nothing, Optional clsRFunc As RFunction = Nothing, Optional clsOp As ROperator = Nothing)

        If strValue <> "" Then
            clsParam = New RParameter
            clsParam.SetArgumentValue(strValue)
        End If

        If bSetFirst Then
            clsLeftParameter = clsParam
            clsLeftFunction = clsRFunc
            clsLeftOperator = clsOp
        Else
            If Not IsNothing(clsParam) Then
                AddAdditionalParameter(clsParam)
            Else
                AddAdditionalParameter(strParameterName, strValue, clsRFunc, clsOp)
            End If
            'clsRightParameter = clsParam
            'clsRightFunction = clsRFunc
            'clsRightOperator = clsOp
        End If
        bIsAssigned = False
    End Sub

    Public Sub AddAdditionalParameter(strParameterName As String, Optional strParameterValue As String = "", Optional clsRFunctionParameter As RFunction = Nothing, Optional clsROperatorParameter As ROperator = Nothing)
        Dim clsParam As New RParameter

        clsParam.SetArgumentName(strParameterName)
        If Not strParameterValue = "" Then
            clsParam.SetArgumentValue(strParameterValue)
        End If
        If Not clsRFunctionParameter Is Nothing Then
            clsParam.SetArgumentFunction(clsRFunctionParameter)
        End If
        If Not clsROperatorParameter Is Nothing Then
            clsParam.SetArgumentOperator(clsROperatorParameter)
        End If
        Me.AddAdditionalParameter(clsParam)

    End Sub

    Public Sub AddAdditionalParameter(clsParam As RParameter)

        Dim i As Integer = -1
        If Not clsAdditionalParameters Is Nothing Then
            If clsParam.strArgumentName IsNot Nothing Then
                i = clsAdditionalParameters.FindIndex(Function(x) x.strArgumentName.Equals(clsParam.strArgumentName))
            End If
        End If

        If i = -1 Then
            clsAdditionalParameters.Add(clsParam)
        Else
            If clsParam.strArgumentValue IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentValue(clsParam.strArgumentValue)
            End If
            If clsParam.clsArgumentFunction IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentFunction(clsParam.clsArgumentFunction)
            End If
            If clsParam.clsArgumentOperator IsNot Nothing Then
                clsAdditionalParameters(i).SetArgumentOperator(clsParam.clsArgumentOperator)
            End If
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveParameterByName(strArgName)
        Dim clsParam
        If Not clsAdditionalParameters Is Nothing Then
            clsParam = clsAdditionalParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsAdditionalParameters.Remove(clsParam)
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveParameter(bRemoveLeftNotRight As Boolean)
        If bRemoveLeftNotRight Then
            clsLeftParameter = Nothing
            clsLeftFunction = Nothing
            clsLeftOperator = Nothing
        Else
            RemoveParameterByName("Right")
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveAllAdditionalParameters()
        clsAdditionalParameters.Clear()
    End Sub

    Public Sub RemoveAllParameters()
        RemoveParameter(True)
        'RemoveParameter(False)
        RemoveAllAdditionalParameters()
    End Sub
End Class