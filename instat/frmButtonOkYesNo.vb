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

Public Class frmButtonOkYesNo
    Private _dialogResult As DialogResult = DialogResult.None

    'form setup
    Public Overloads Function ShowDialog(prompt As String,
                               Optional title As String = "",
                               Optional buttons As MessageBoxButtons = MessageBoxButtons.OK,
                               Optional icon As MessageBoxIcon = MessageBoxIcon.None) As DialogResult

        Me.Text = title
        lblMessage.Text = prompt
        ResizeDialog(prompt, icon)
        SetupButtons(buttons)
        PlayIconSound(icon)
        MyBase.ShowDialog()
        Return _dialogResult
    End Function

    Private Sub ResizeDialog(prompt As String, icon As MessageBoxIcon)
        Dim imessagewidth As Integer = 300
        Dim iwidth As Integer = 50
        Dim iNoticonwidth As Integer = 10
        Dim iconWidth As Integer = If(icon <> MessageBoxIcon.None, iwidth, iNoticonwidth)
        Dim ihorizontalform As Integer = 30

        ' width form
        Dim iformWidth As Integer = iconWidth + imessagewidth + ihorizontalform

        ' text height
        Dim textSize As SizeF
        Using g As Graphics = Me.CreateGraphics()
            textSize = g.MeasureString(prompt, Me.Font, imessagewidth)
        End Using

        ' final height from ---
        Dim iheight As Integer = 150
        Dim iformHeight As Integer = iheight
        Dim iheightbefore As Integer = 60
        Dim iextraheight As Integer = 100
        Dim imassagemargin As Integer = 20

        If textSize.Height > iheightbefore Then
            iformHeight = CInt(textSize.Height) + iextraheight
        End If

        Me.ClientSize = New Size(iformWidth, iformHeight)
        lblMessage.Size = New Size(imessagewidth, iformHeight - 60)
        lblMessage.Location = New Point(iconWidth, imassagemargin)
    End Sub


    Private Sub SetupButtons(buttons As MessageBoxButtons)
        cmdOk.Visible = False
        cmdYes.Visible = False
        cmdNo.Visible = False

        Select Case buttons
            Case MessageBoxButtons.OK
                cmdOk.Text = GetTranslation("Ok")
                cmdOk.Visible = True
                cmdOk.Left = (Me.ClientSize.Width - cmdOk.Width) \ 2
            Case MessageBoxButtons.YesNo
                cmdYes.Visible = True
                cmdNo.Visible = True
                cmdNo.Text = GetTranslation("No")
                cmdYes.Text = GetTranslation("Yes")
                Dim itotalWidth As Integer = cmdYes.Width + cmdNo.Width + 10
                Dim istartX As Integer = (Me.ClientSize.Width - itotalWidth) \ 2
                cmdYes.Left = istartX
                cmdNo.Left = istartX + cmdYes.Width + 10
        End Select
        Dim iposition As Integer = Me.ClientSize.Height - 40
        cmdOk.Top = iposition
        cmdYes.Top = iposition
        cmdNo.Top = iposition
    End Sub

    Private Sub PlayIconSound(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error
                SystemSounds.Hand.Play()
            Case MessageBoxIcon.Warning
                SystemSounds.Exclamation.Play()
            Case MessageBoxIcon.Question
                SystemSounds.Question.Play()
            Case MessageBoxIcon.Information
                SystemSounds.Asterisk.Play()
        End Select
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
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