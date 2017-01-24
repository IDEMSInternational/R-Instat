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
Imports instat
Public Class UcrPanel
    Public Sub AddRadioButtons(lstRadioButtons As RadioButton(), Optional bRepositionControls As Boolean = True)
        pnlRadios.Controls.AddRange(lstRadioButtons)
        For Each rdoTemp As RadioButton In lstRadioButtons
            AddHandler rdoTemp.CheckedChanged, AddressOf OnControlValueChanged
            If bRepositionControls Then
                If rdoTemp.Location.X - Me.Location.X < 0 OrElse rdoTemp.Location.Y - Me.Location.Y < 0 Then
                    MsgBox("Developer error: Radio button is not within the bounds of the panel. Reposition the radio button in the designer.")
                End If
                rdoTemp.Location = New System.Drawing.Point(Math.Max(rdoTemp.Location.X - Me.Location.X, 0), Math.Max(rdoTemp.Location.Y - Me.Location.Y, 0))
            End If
        Next
    End Sub

End Class
