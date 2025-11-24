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

''' <summary>
''' Custom message box form that displays translated button text based on R-Instat's
''' configured language rather than the Windows system language.
''' </summary>
Public Class frmCustomMessageBox
    Inherits Form
    Private lblMessage As Label
    Private picIcon As PictureBox
    Private _dialogResult As DialogResult = DialogResult.None
    ' ==== Layout Constants ====
    Private Const ICON_PRESENT_WIDTH As Integer = 50
    Private Const ICON_ABSENT_WIDTH As Integer = 10

    Private Const MESSAGE_WIDTH As Integer = 300
    Private Const FORM_HORIZONTAL_PADDING As Integer = 30
    Private Const DEFAULT_FORM_HEIGHT As Integer = 150
    Private Const EXTRA_HEIGHT_FOR_TEXT As Integer = 100
    Private Const MAX_TEXT_HEIGHT_BEFORE_GROW As Integer = 60

    Private Const ICON_SIZE As Integer = 32
    Private Const ICON_MARGIN_LEFT As Integer = 10
    Private Const ICON_MARGIN_TOP As Integer = 20

    Private Const MESSAGE_MARGIN_TOP As Integer = 20

    'Private Const BUTTON_WIDTH As Integer = 75
    'Private Const BUTTON_HEIGHT As Integer = 23
    'Private Const BUTTON_BOTTOM_MARGIN As Integer = 35
    'Private Const BUTTON_SPACING As Integer = 6
    Friend WithEvents cmdYes As ucrSplitButton
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdNo As Button

    ''' <summary>
    ''' Displays a custom message box with translated buttons.
    ''' </summary>
    Public Shared Function Show(prompt As String,
                                 title As String,
                                 buttons As MessageBoxButtons,
                                 icon As MessageBoxIcon) As DialogResult
        Using frm As New frmCustomMessageBox()
            frm.Text = If(String.IsNullOrEmpty(title), "", title)
            frm.SetupDialog(prompt, title, buttons, icon)

            ' Play system sound based on icon
            Select Case icon
                Case MessageBoxIcon.Error, MessageBoxIcon.Hand, MessageBoxIcon.Stop
                    SystemSounds.Hand.Play()
                Case MessageBoxIcon.Warning, MessageBoxIcon.Exclamation
                    SystemSounds.Exclamation.Play()
                Case MessageBoxIcon.Question
                    SystemSounds.Question.Play()
                Case MessageBoxIcon.Information
                    SystemSounds.Asterisk.Play()
            End Select

            frm.ShowDialog()
            Return frm._dialogResult
        End Using
    End Function

    Private Sub SetupDialog(prompt As String, title As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterParent
        Me.ShowInTaskbar = False
        Me.Text = If(String.IsNullOrEmpty(title), "", title)
        Me.BackColor = SystemColors.Control
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        Dim iconWidth As Integer = If(icon <> MessageBoxIcon.None, ICON_PRESENT_WIDTH, ICON_ABSENT_WIDTH)
        Dim formWidth As Integer = iconWidth + MESSAGE_WIDTH + FORM_HORIZONTAL_PADDING
        Dim formHeight As Integer = DEFAULT_FORM_HEIGHT

        Using g As Graphics = Me.CreateGraphics()
            Dim textSize As SizeF = g.MeasureString(prompt, Me.Font, MESSAGE_WIDTH)
            If textSize.Height > MAX_TEXT_HEIGHT_BEFORE_GROW Then
                formHeight = CInt(textSize.Height) + EXTRA_HEIGHT_FOR_TEXT
            End If
        End Using

        Me.ClientSize = New Size(formWidth, formHeight)

        lblMessage = New Label()
        lblMessage.Text = prompt
        lblMessage.AutoSize = False
        lblMessage.Size = New Size(MESSAGE_WIDTH, formHeight - 60)
        lblMessage.Location = New Point(iconWidth, MESSAGE_MARGIN_TOP)
        lblMessage.TextAlign = ContentAlignment.MiddleLeft
        lblMessage.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        Me.Controls.Add(lblMessage)

        If icon <> MessageBoxIcon.None Then
            picIcon = New PictureBox()
            picIcon.Size = New Size(ICON_SIZE, ICON_SIZE)
            picIcon.Location = New Point(ICON_MARGIN_LEFT, ICON_MARGIN_TOP)
            picIcon.SizeMode = PictureBoxSizeMode.Normal

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

        SetupButtons(buttons)
    End Sub


    Private Sub SetupButtons(buttons As MessageBoxButtons)

        Select Case buttons

            Case MessageBoxButtons.OK
                cmdYes.Visible = False
                cmdNo.Visible = False
                cmdOk.Visible = True
              '  cmdOk = CreateButton(Translations.GetTranslation("OK"), DialogResult.OK)

            Case MessageBoxButtons.YesNo
                cmdYes.Visible = True
                cmdNo.Visible = True
                cmdOk.Visible = False
                ' cmdYes = CreateButton(Translations.GetTranslation("Yes"), DialogResult.Yes)
                '   cmdNo = CreateButton(Translations.GetTranslation("No"), DialogResult.No)

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




    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        _dialogResult = DirectCast(btn.Tag, DialogResult)
        Me.Close()
    End Sub

    Private Sub InitializeComponent()

        'frmCustomMessageBox
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdYes)
        Me.Controls.Add(Me.cmdNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
