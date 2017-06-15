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
    Private Sub ucrColors_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.SetItems({Chr(34) & "Pick Colour" & Chr(34), Chr(34) & "black" & Chr(34), Chr(34) & "white" & Chr(34), Chr(34) & "blue" & Chr(34), Chr(34) & "red" & Chr(34), Chr(34) & "yellow" & Chr(34), Chr(34) & "purple" & Chr(34), Chr(34) & "green" & Chr(34), Chr(34) & "orange" & Chr(34), Chr(34) & "grey" & Chr(34), Chr(34) & "brown" & Chr(34), Chr(34) & "pink" & Chr(34)})
    End Sub

    Private Sub ucrColors_NameChanged() Handles Me.NameChanged
        Dim dlgColour As New ColorDialog
        If Me.cboInput.Text = Chr(34) & "Pick Colour" & Chr(34) Then
            dlgColour.ShowDialog()
            SetName(Chr(34) & dlgColour.Color.Name & Chr(34))
        End If
    End Sub
End Class
