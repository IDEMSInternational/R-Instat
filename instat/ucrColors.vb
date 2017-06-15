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
    Private dctColours As New Dictionary(Of String, String)
    'TODO move this to a global location so that all controls can access the same colour dialog and user defined colours are kept
    Private dlgColour As New ColorDialog

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If dctColours.Count = 0 Then
            dctColours.Add("NULL", "NULL")
            dctColours.Add(strPickColour, strPickColour)
            dctColours.Add("Black", Chr(34) & "black" & Chr(34))
            dctColours.Add("White", Chr(34) & "white" & Chr(34))
            dctColours.Add("Blue", Chr(34) & "blue" & Chr(34))
            dctColours.Add("Red", Chr(34) & "red" & Chr(34))
            dctColours.Add("Yellow", Chr(34) & "yellow" & Chr(34))
            dctColours.Add("Purple", Chr(34) & "purple" & Chr(34))
            dctColours.Add("Green", Chr(34) & "green" & Chr(34))
            dctColours.Add("Orange", Chr(34) & "orange" & Chr(34))
            dctColours.Add("Grey", Chr(34) & "grey" & Chr(34))
            dctColours.Add("Brown", Chr(34) & "brown" & Chr(34))
            dctColours.Add("Pink", Chr(34) & "pink" & Chr(34))
        End If
        bAllowNonConditionValues = True
    End Sub

    Private Sub ucrColors_Load(sender As Object, e As EventArgs) Handles Me.Load
        If GetParameter() IsNot Nothing Then
            SetItems(dctColours)
        End If
    End Sub

    Private Sub ucrColors_NameChanged() Handles Me.NameChanged
        Dim strColourItem As String
        Dim clrTemp As Color

        If GetText() = strPickColour Then
            Try
                If dlgColour.ShowDialog() = DialogResult.OK Then
                    clrTemp = dlgColour.Color
                    'first two character from Hex are fixed as FF for VB use, not part of colour value
                    'ggplot requires # in front of Hex colour values
                    strColourItem = "#" & Hex(clrTemp.ToArgb).Substring(2, 6)
                    'First item is NULL and needs to be changed before setting text otherwise value will not show in combobox
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