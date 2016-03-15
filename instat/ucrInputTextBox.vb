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
Imports System.ComponentModel

Public Class ucrInputTextBox
    Public Overrides Sub SetName(strName As String)
        If ValidateText(strName) Then
            txtInput.Text = strName
            OnNameChanged()
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        bUserTyped = True
    End Sub

    Private Sub txtInput_Validating(sender As Object, e As CancelEventArgs) Handles txtInput.Validating
        e.Cancel = Not ValidateText(txtInput.Text)
    End Sub

    Public Overrides Function GetText() As String
        Return txtInput.Text
    End Function

    Public Overrides Function IsEmpty() As Boolean
        If txtInput.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
