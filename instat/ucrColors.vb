' Instat-R
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

Public Class ucrColors
    Private strPickColour As String = "Pick Colour..."
    Private strColours As String() = {"NULL", strPickColour, Chr(34) & "black" & Chr(34), Chr(34) & "white" & Chr(34), Chr(34) & "blue" & Chr(34), Chr(34) & "red" & Chr(34), Chr(34) & "yellow" & Chr(34), Chr(34) & "purple" & Chr(34), Chr(34) & "green" & Chr(34), Chr(34) & "orange" & Chr(34), Chr(34) & "grey" & Chr(34), Chr(34) & "brown" & Chr(34), Chr(34) & "pink" & Chr(34)}
    Private dlgColour As New ColorDialog

    Private Sub ucrColors_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetItems(strColours)
    End Sub

    Private Sub ucrColors_NameChanged() Handles Me.NameChanged
        Dim strColourItem As String
        Dim clrTemp As Color

        If GetText() = strPickColour Then
            Try
                If dlgColour.ShowDialog() = DialogResult.OK Then
                    clrTemp = dlgColour.Color
                    strColourItem = Chr(34) & "#" & Hex(clrTemp.ToArgb).Substring(2, 6) & Chr(34)
                    cboInput.Items.Item(0) = strColourItem
                    SetName(strColourItem)
                Else
                    SetName("NULL")
                End If
            Catch ex As Exception
                dlgColour.Dispose()
            End Try
        End If
    End Sub
End Class