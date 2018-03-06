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

Public Class ucrMultipleInput
    Public clsNumericList As New RFunction
    Public bIsNumericInput As Boolean = False

    Private Sub ucrMultipleNumeric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clsNumericList.SetRCommand("c")
    End Sub

    Private Sub txtNumericItems_Leave(sender As Object, e As EventArgs) Handles txtNumericItems.Leave
        Dim strItems As String()
        Dim strTemp As String
        clsNumericList.ClearParameters()
        'TODO deal with spaces differently e.g. "8 8" should give error/warning instead of "88"
        strTemp = txtNumericItems.Text.Replace(" ", "")
        If strTemp <> "" Then
            strItems = strTemp.Split(",")
            For Each strVal In strItems
                Dim clsTempParam As New RParameter
                If bIsNumericInput Then
                    If Not IsNumeric(strVal) Then
                        MsgBox("Textbox requires a list of numbers separated by commas.", vbOKOnly, "Validation Error")
                        txtNumericItems.Focus()
                        Exit Sub
                    End If
                    clsTempParam.SetArgumentValue(strVal)
                Else
                    clsTempParam.SetArgumentValue(Chr(34) & strVal & Chr(34))
                End If
                clsNumericList.AddParameter(clsTempParam)
            Next
        End If
    End Sub

End Class