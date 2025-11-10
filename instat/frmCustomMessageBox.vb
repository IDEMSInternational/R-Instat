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

''' <summary>
''' Custom message box form that displays translated button text based on R-Instat's
''' configured language rather than the Windows system language.
''' </summary>
Public Class frmCustomMessageBox
    Inherits Form

    Private lblMessage As Label
    Private btnButton1 As Button
    Private btnButton2 As Button
    Private btnButton3 As Button
    Private picIcon As PictureBox
    Private _dialogResult As DialogResult = DialogResult.None

    ''' <summary>
    ''' Displays a custom message box with translated buttons.
    ''' </summary>
    Public Shared Function Show(prompt As String,
                                 title As String,
                                 buttons As MessageBoxButtons,
                                 icon As MessageBoxIcon) As DialogResult
        Using frm As New frmCustomMessageBox()
            frm.Text = prompt
            frm.SetupDialog(prompt, title, buttons, icon)
            frm.ShowDialog()
            Return frm._dialogResult
        End Using
    End Function

    Private Sub SetupDialog(prompt As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        ' Initialize form
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.Text = If(String.IsNullOrEmpty(title), "", title)
        Me.Size = New Size(400, 150)

        ' Create and configure label for message
        lblMessage = New Label()
        lblMessage.Text = prompt
        lblMessage.AutoSize = False
        lblMessage.Size = New Size(350, 60)
        lblMessage.Location = New Point(60, 20)
        Me.Controls.Add(lblMessage)

        ' Create and configure icon (if specified)
        If icon <> MessageBoxIcon.None Then
            picIcon = New PictureBox()
            picIcon.Size = New Size(32, 32)
            picIcon.Location = New Point(15, 20)
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage

            ' Set icon based on type
            Select Case icon
                Case MessageBoxIcon.Information
                    picIcon.Image = SystemIcons.Information.ToBitmap()
                Case MessageBoxIcon.Question
                    picIcon.Image = SystemIcons.Question.ToBitmap()
                Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
                    picIcon.Image = SystemIcons.Warning.ToBitmap()
                Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
                    picIcon.Image = SystemIcons.Error.ToBitmap()
            End Select

            Me.Controls.Add(picIcon)
        End If

        ' Setup buttons based on MessageBoxButtons type
        SetupButtons(buttons)
    End Sub

    Private Sub SetupButtons(buttons As MessageBoxButtons)
        Dim buttonWidth As Integer = 75
        Dim buttonHeight As Integer = 23
        Dim buttonY As Integer = 90
        Dim spacing As Integer = 10

        Select Case buttons
            Case MessageBoxButtons.OK
                ' Single OK button - centered
                btnButton1 = CreateButton(Translations.GetTranslation("OK"), DialogResult.OK)
                btnButton1.Location = New Point((Me.ClientSize.Width - buttonWidth) \ 2, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                Me.Controls.Add(btnButton1)
                Me.AcceptButton = btnButton1

            Case MessageBoxButtons.OKCancel
                ' OK and Cancel buttons - right aligned
                btnButton1 = CreateButton(Translations.GetTranslation("OK"), DialogResult.OK)
                btnButton2 = CreateButton(Translations.GetTranslation("Cancel"), DialogResult.Cancel)
                
                Dim totalWidth As Integer = buttonWidth * 2 + spacing
                Dim startX As Integer = Me.ClientSize.Width - totalWidth - 15
                
                btnButton1.Location = New Point(startX, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                btnButton2.Location = New Point(startX + buttonWidth + spacing, buttonY)
                btnButton2.Size = New Size(buttonWidth, buttonHeight)
                
                Me.Controls.Add(btnButton1)
                Me.Controls.Add(btnButton2)
                Me.AcceptButton = btnButton1
                Me.CancelButton = btnButton2

            Case MessageBoxButtons.YesNo
                ' Yes and No buttons - right aligned
                btnButton1 = CreateButton(Translations.GetTranslation("Yes"), DialogResult.Yes)
                btnButton2 = CreateButton(Translations.GetTranslation("No"), DialogResult.No)
                
                Dim totalWidth As Integer = buttonWidth * 2 + spacing
                Dim startX As Integer = Me.ClientSize.Width - totalWidth - 15
                
                btnButton1.Location = New Point(startX, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                btnButton2.Location = New Point(startX + buttonWidth + spacing, buttonY)
                btnButton2.Size = New Size(buttonWidth, buttonHeight)
                
                Me.Controls.Add(btnButton1)
                Me.Controls.Add(btnButton2)
                Me.AcceptButton = btnButton1
                Me.CancelButton = btnButton2

            Case MessageBoxButtons.YesNoCancel
                ' Yes, No, and Cancel buttons - right aligned
                btnButton1 = CreateButton(Translations.GetTranslation("Yes"), DialogResult.Yes)
                btnButton2 = CreateButton(Translations.GetTranslation("No"), DialogResult.No)
                btnButton3 = CreateButton(Translations.GetTranslation("Cancel"), DialogResult.Cancel)
                
                Dim totalWidth As Integer = buttonWidth * 3 + spacing * 2
                Dim startX As Integer = Me.ClientSize.Width - totalWidth - 15
                
                btnButton1.Location = New Point(startX, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                btnButton2.Location = New Point(startX + buttonWidth + spacing, buttonY)
                btnButton2.Size = New Size(buttonWidth, buttonHeight)
                btnButton3.Location = New Point(startX + buttonWidth * 2 + spacing * 2, buttonY)
                btnButton3.Size = New Size(buttonWidth, buttonHeight)
                
                Me.Controls.Add(btnButton1)
                Me.Controls.Add(btnButton2)
                Me.Controls.Add(btnButton3)
                Me.AcceptButton = btnButton1
                Me.CancelButton = btnButton3

            Case MessageBoxButtons.RetryCancel
                ' Retry and Cancel buttons - right aligned
                btnButton1 = CreateButton(Translations.GetTranslation("Retry"), DialogResult.Retry)
                btnButton2 = CreateButton(Translations.GetTranslation("Cancel"), DialogResult.Cancel)
                
                Dim totalWidth As Integer = buttonWidth * 2 + spacing
                Dim startX As Integer = Me.ClientSize.Width - totalWidth - 15
                
                btnButton1.Location = New Point(startX, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                btnButton2.Location = New Point(startX + buttonWidth + spacing, buttonY)
                btnButton2.Size = New Size(buttonWidth, buttonHeight)
                
                Me.Controls.Add(btnButton1)
                Me.Controls.Add(btnButton2)
                Me.AcceptButton = btnButton1
                Me.CancelButton = btnButton2

            Case MessageBoxButtons.AbortRetryIgnore
                ' Abort, Retry, and Ignore buttons - right aligned
                btnButton1 = CreateButton(Translations.GetTranslation("Abort"), DialogResult.Abort)
                btnButton2 = CreateButton(Translations.GetTranslation("Retry"), DialogResult.Retry)
                btnButton3 = CreateButton(Translations.GetTranslation("Ignore"), DialogResult.Ignore)
                
                Dim totalWidth As Integer = buttonWidth * 3 + spacing * 2
                Dim startX As Integer = Me.ClientSize.Width - totalWidth - 15
                
                btnButton1.Location = New Point(startX, buttonY)
                btnButton1.Size = New Size(buttonWidth, buttonHeight)
                btnButton2.Location = New Point(startX + buttonWidth + spacing, buttonY)
                btnButton2.Size = New Size(buttonWidth, buttonHeight)
                btnButton3.Location = New Point(startX + buttonWidth * 2 + spacing * 2, buttonY)
                btnButton3.Size = New Size(buttonWidth, buttonHeight)
                
                Me.Controls.Add(btnButton1)
                Me.Controls.Add(btnButton2)
                Me.Controls.Add(btnButton3)
                Me.AcceptButton = btnButton2
        End Select
    End Sub

    Private Function CreateButton(text As String, result As DialogResult) As Button
        Dim btn As New Button()
        btn.Text = text
        btn.Tag = result
        AddHandler btn.Click, AddressOf Button_Click
        Return btn
    End Function

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        _dialogResult = DirectCast(btn.Tag, DialogResult)
        Me.Close()
    End Sub

End Class
