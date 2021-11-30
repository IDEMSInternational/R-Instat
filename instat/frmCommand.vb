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

Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmCommand
    Private Sub frmCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Close()
        End If
    End Sub

    Private Sub CopyRTB_Click(sender As Object, e As EventArgs) Handles CopyRTB.Click
        txtCommand.Copy()
    End Sub

    Private Sub txtCommand_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCommand.MouseDown
        If e.Button = MouseButtons.Right And txtCommand.SelectedText <> "" Then
            txtCommand.ContextMenuStrip = mnuContextRTB
            'mnuContextRTB.Enabled = True
        Else
            txtCommand.ContextMenuStrip = Nothing
            'mnuContextRTB.Enabled = False
        End If
    End Sub

    Public Sub copyText()
        txtCommand.Copy()
    End Sub

    Public Sub selectAllText()
        txtCommand.SelectAll()
    End Sub

    Private Sub frmCommand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewOutputWindow.Checked = Me.Visible
    End Sub

End Class
