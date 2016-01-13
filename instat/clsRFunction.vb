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
    Public clsParameters As List(Of RParameter)
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

    Public Sub SetAssignTo(strTemp As String)
        strAssignTo = strTemp
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
            strTemp = clsParameters(i).ToScript(strScript)
        Next
        strTemp = strTemp & ")"
        If bIsAssigned Then
            strScript = strScript & strAssignTo & " <- " & strTemp & vbCrLf
            If strAssignToDataFrame Then
            End If

        End If
        Return strAssignTo
        Else
        Return strTemp
        End If
    End Function

    Public Sub AddParameter(clsParam As RParameter)
        Dim i As Integer

        i = clsParameters.FindIndex(Function(x) x.strArgumentName.Equals(clsParam.strArgumentName))
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

        clsParam = clsParameters.Find(Function(x) x.strArgumentName = strArgName)
        clsParameters.Remove(clsParam)
        bIsAssigned = False

    End Sub

End Class