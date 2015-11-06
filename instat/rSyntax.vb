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
    Dim strFunction As String
    Dim strParameter(1, 0) As String

    Public Sub SetFunction(strFunctionName As String)
        strFunction = strFunctionName
    End Sub

    Public Sub AddParameter(strParameterName As String, strParameterValue As String)
        Dim iBound, i, j As Integer
        Dim bNew As Boolean = True
        If strParameter(0, 0) Is Nothing Then
            strParameter(0, 0) = strParameterName
            strParameter(1, 0) = strParameterValue
        Else
            iBound = strParameter.GetUpperBound(1)
            For i = 0 To iBound
                If strParameter(0, i) = strParameterName Then
                    strParameter(1, i) = strParameterValue
                    bNew = False
                End If
            Next
            If bNew Then
                ReDim Preserve strParameter(1, iBound + 1)
                strParameter(0, iBound + 1) = strParameterName
                strParameter(1, iBound + 1) = strParameterValue
            End If
        End If
    End Sub

    Public Sub RemoveParameter(strParameterName As String, strParameterValue As String)

    End Sub

    Public Function GetScript() As String
        Dim strScript As String
        Dim i As Integer
        strScript = strFunction & "("
        For i = 0 To strParameter.GetUpperBound(1)
            If i > 0 Then
                strScript = strScript & ","
            End If
            strScript = strScript & strParameter(0, i) & "=" & strParameter(1, i)
        Next
        strScript = strScript & ")"
        Return strScript
    End Function

End Class
