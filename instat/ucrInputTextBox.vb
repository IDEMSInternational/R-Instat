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

Imports System.ComponentModel

Public Class ucrInputTextBox
    Public Overrides Sub SetName(strName As String, Optional bSilent As Boolean = False)
        MyBase.SetName(strName, bSilent)
        If bSilent Then
            txtInput.Text = strName
            OnNameChanged()
        Else
            If ValidateText(strName) Then
                txtInput.Text = strName
                OnNameChanged()
            End If
        End If
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        bUserTyped = True
    End Sub

    Private Sub txtInput_Validating(sender As Object, e As CancelEventArgs) Handles txtInput.Validating
        Dim strCurrent As String

        strCurrent = txtInput.Text
        If bAutoChangeOnLeave Then
            If Not IsValid(strCurrent) Then
                'TODO This message should contain the same message from ValidateText()
                'Temp disabled so that change is done automatically
                'TODO Think about more subtle ways to do this without being annoying to the user
                'Select Case MsgBox(Chr(34) & strCurrent & Chr(34) & " is an invalid name." & Environment.NewLine & "Would you like it to be automatically corrected?", vbYesNo, "Invalid Name")
                '    Case MsgBoxResult.Yes
                '        SetName(frmMain.clsRLink.MakeValidText(strCurrent))
                '    Case Else
                '        e.Cancel = True
                'End Select
                SetName(frmMain.clsRLink.MakeValidText(strCurrent))
            End If
        Else
            e.Cancel = Not ValidateText(strCurrent)
        End If
        If Not e.Cancel Then OnNameChanged()
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

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        OnContentsChanged()
    End Sub

    Public Property IsMultiline As Boolean
        Get
            Return txtInput.Multiline
        End Get
        Set(bMultiline As Boolean)
            txtInput.Multiline = bMultiline
        End Set
    End Property

    Private Sub mnuRightClickCopy_Click(sender As Object, e As EventArgs) Handles mnuRightClickCopy.Click
        txtInput.Copy()
    End Sub

    Private Sub ucrInputTextBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            bFirstLoad = False
        End If
    End Sub

    Public Overrides Property IsReadOnly As Boolean
        Get
            Return MyBase.IsReadOnly
        End Get
        Set(bReadOnly As Boolean)
            MyBase.IsReadOnly = bReadOnly
            txtInput.ReadOnly = bReadOnly
        End Set
    End Property
End Class
