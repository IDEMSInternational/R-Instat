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

Imports System.Windows.Forms
Imports System.Media
Imports instat.Translations

Public Class frmOkYesNo
    Private lblMessage As Label
    Private picIcon As PictureBox
    Private _dialogResult As DialogResult = DialogResult.None

    Private Sub frmOkYesNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub SetupDialog(prompt As String, title As String, buttons As MessageBoxButtons)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ShowInTaskbar = False
        Me.Text = If(String.IsNullOrEmpty(title), "", title)
        Me.BackColor = SystemColors.Control
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Dim formWidth As Integer = 420
        Dim formHeight As Integer = 150

        Using g As Graphics = Me.CreateGraphics()
            Dim textSize As SizeF = g.MeasureString(prompt, Me.Font, 360)
            If textSize.Height > 60 Then
                formHeight = CInt(textSize.Height) + 100
            End If
        End Using

        Me.ClientSize = New Size(formWidth, formHeight)

        lblMessage = New Label()
        lblMessage.Text = prompt
        lblMessage.AutoSize = False
        lblMessage.Size = New Size(360, formHeight - 70)
        lblMessage.Location = New Point(30, 15)
        lblMessage.TextAlign = ContentAlignment.MiddleLeft
        lblMessage.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Me.Controls.Add(lblMessage)

        ' Configuration des boutons
        SetupButtons(buttons)
    End Sub

    Private Sub SetupButtons(buttons As MessageBoxButtons)
        Select Case buttons
            Case MessageBoxButtons.OK
                cmdYes.Visible = False
                cmdNo.Visible = False
                cmdOk.Visible = True
            Case MessageBoxButtons.YesNo
                cmdYes.Visible = True
                cmdNo.Visible = True
                cmdOk.Visible = False
        End Select
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        _dialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdYes_Click(sender As Object, e As EventArgs) Handles cmdYes.Click
        _dialogResult = DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        _dialogResult = DialogResult.No
        Me.Close()
    End Sub
End Class