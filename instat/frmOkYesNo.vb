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
    ' Private lblMessage As Label
    Private picIcon As PictureBox
    Private _dialogResult As DialogResult = DialogResult.None

    Private Sub frmOkYesNo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    'Public Shared Function Show(prompt As String,
    '                            title As String,
    '                            buttons As MessageBoxButtons,
    '                            icon As MessageBoxIcon) As DialogResult

    '    Using frm As New frmOkYesNo()

    '        frm.SetupDialog(prompt, title, buttons, icon)

    '        ' Son système
    '        Select Case icon
    '            Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
    '                SystemSounds.Hand.Play()
    '            Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
    '                SystemSounds.Exclamation.Play()
    '            Case MessageBoxIcon.Question
    '                SystemSounds.Question.Play()
    '            Case MessageBoxIcon.Information
    '                SystemSounds.Asterisk.Play()
    '        End Select

    '        frm.ShowDialog()
    '        Return frm._dialogResult
    '    End Using
    'End Function

    'form setup
    Public Function ShowDialog(prompt As String,
                               Optional title As String = "",
                               Optional buttons As MessageBoxButtons = MessageBoxButtons.OK,
                               Optional icon As MessageBoxIcon = MessageBoxIcon.None) As DialogResult

        '=====Titre=====
        Me.Text = title

        '===== Message =====
        lblMessage.Text = prompt

        '===== Ajuster automatiquement la taille =====
        ResizeDialog(prompt)

        '===== Gérer les boutons =====
        SetupButtons(buttons)

        '===== Jouer l’icône sonore =====
        PlayIconSound(icon)

        '===== Afficher =====
        MyBase.ShowDialog()
        Return _dialogResult
    End Function

    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    ' Ajustement automatique de la fenêtre au texte
    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    Private Sub ResizeDialog(prompt As String)
        Dim messageWidth As Integer = 360

        Dim textSize As Size = TextRenderer.MeasureText(
            prompt,
            lblMessage.Font,
            New Size(messageWidth, Integer.MaxValue),
            TextFormatFlags.WordBreak
        )

        Dim neededHeight As Integer = textSize.Height + 150
        If neededHeight < 180 Then neededHeight = 180

        Me.ClientSize = New Size(420, neededHeight)
        lblMessage.Size = New Size(messageWidth, neededHeight - 90)
    End Sub

    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    ' Boutons visibles selon MessageBoxButtons
    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    Private Sub SetupButtons(buttons As MessageBoxButtons)

        cmdOk.Visible = False
        cmdYes.Visible = False
        cmdNo.Visible = False

        Select Case buttons

            Case MessageBoxButtons.OK
                cmdOk.Visible = True
                cmdOk.Left = (Me.ClientSize.Width - cmdOk.Width) \ 2

            Case MessageBoxButtons.YesNo
                cmdYes.Visible = True
                cmdNo.Visible = True

                Dim totalWidth As Integer = cmdYes.Width + cmdNo.Width + 10
                Dim startX As Integer = (Me.ClientSize.Width - totalWidth) \ 2

                cmdYes.Left = startX
                cmdNo.Left = startX + cmdYes.Width + 10

            Case MessageBoxButtons.OKCancel
                cmdOk.Visible = True
                cmdNo.Visible = True
                cmdNo.Text = Translations.GetTranslation("Cancel")

                Dim totalWidth As Integer = cmdOk.Width + cmdNo.Width + 10
                Dim startX As Integer = (Me.ClientSize.Width - totalWidth) \ 2

                cmdOk.Left = startX
                cmdNo.Left = startX + cmdOk.Width + 10

        End Select

        ' Position verticale des boutons
        Dim y As Integer = Me.ClientSize.Height - 40
        cmdOk.Top = y
        cmdYes.Top = y
        cmdNo.Top = y
    End Sub

    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    ' Jouer le son Windows correspondant à l’icône
    '=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
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