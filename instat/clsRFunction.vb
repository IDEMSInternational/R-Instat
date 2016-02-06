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

Public Class RFunction
    Public clsParameters As New List(Of RParameter)
    Public strRCommand As String
    Public strAssignTo As String
    Public strAssignToDataFrame As String
    Public strAssignToColumn As String
    Public strAssignToModel As String
    Public bToBeAssigned As Boolean = False
    Public bIsAssigned As Boolean = False

    Public Sub SetRCommand(strTemp As String)
        strRCommand = strTemp
        bIsAssigned = False
    End Sub

    Public Sub SetAssignTo(strTemp As String, Optional strTempDataframe As String = "", Optional strTempColumn As String = "", Optional strTempModel As String = "")
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

    Public Function ToScript(Optional ByRef strScript As String = "") As String
        Dim strTemp As String = ""
        Dim i As Integer

        strTemp = strRCommand & "("

        For i = 0 To clsParameters.Count - 1
            If i > 0 Then
                strTemp = strTemp & ","
            End If
            strTemp = strTemp & clsParameters(i).ToScript(strScript)
        Next
        strTemp = strTemp & ")"
        If bToBeAssigned Then
            If Not frmMain.clsRLink.bInstatObjectExists Then
                frmMain.clsRLink.CreateNewInstatObject()
            End If
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            If Not strAssignToDataFrame = "" Then
                If Not strAssignToColumn = "" Then
                    strScript = strScript & frmMain.clsRLink.strInstatDataObject & "$add_column_to_data(data_name = " & Chr(34) & strAssignToDataFrame & Chr(34) & ", col_name = " & Chr(34) & strAssignToColumn & Chr(34) & ", col_data = " & strAssignTo & ")" & vbCrLf
                    strAssignTo = frmMain.clsRLink.strInstatDataObject & "$get_column_from_data(data_name = " & Chr(34) & strAssignToDataFrame & Chr(34) & ", col_name = " & Chr(34) & strAssignToColumn & Chr(34) & ")"
                    bIsAssigned = True
                    bToBeAssigned = False
                Else
                    strScript = strScript & frmMain.clsRLink.strInstatDataObject & "$import_data(data_tables = list(" & strAssignToDataFrame & "=" & strAssignTo & "))" & vbCrLf
                    strAssignTo = frmMain.clsRLink.strInstatDataObject & "$get_data_frame(data_name = " & Chr(34) & strAssignToDataFrame & Chr(34) & ")"
                    bIsAssigned = True
                    bToBeAssigned = False
                End If
            ElseIf Not strAssignToModel = "" Then
                strScript = strScript & frmMain.clsRLink.strInstatDataObject & "$add_model(model_name = " & Chr(34) & strAssignToModel & Chr(34) & ", model = " & strAssignTo & ")" & vbCrLf
                strAssignTo = frmMain.clsRLink.strInstatDataObject & "$get_model( model_name = " & Chr(34) & strAssignToModel & Chr(34) & ")"
                bIsAssigned = True
                bToBeAssigned = False
            End If
            Return strAssignTo
        Else
            Return strTemp
        End If
    End Function

    Public Sub AddParameter(clsParam As RParameter)
        Dim i As Integer = -1
        If Not clsParameters Is Nothing Then
            If clsParam.strArgumentName IsNot Nothing Then
                i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(clsParam.strArgumentName))
            End If
        End If

        If i = -1 Then
            clsParameters.Add(clsParam)
        Else
            If clsParam.strArgumentValue IsNot Nothing Then
                clsParameters(i).SetArgumentValue(clsParam.strArgumentValue)
            End If
            If clsParam.clsArgumentFunction IsNot Nothing Then
                clsParameters(i).SetArgumentFunction(clsParam.clsArgumentFunction)
            End If
        End If
        bIsAssigned = False
    End Sub

    Public Sub RemoveParameterByName(strArgName)
        Dim clsParam
        If Not clsParameters Is Nothing Then
            clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
            clsParameters.Remove(clsParam)
        End If
        bIsAssigned = False
    End Sub

    Public Sub ClearParameters()
        clsParameters.Clear()
        bIsAssigned = False
    End Sub
End Class