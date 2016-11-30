﻿Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmCommand
    Private Sub frmCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        txtCommand.ScrollBars = RichTextBoxScrollBars.Both
        'If set WrapText to false, two scrollBars will appear which would enable to see the whole graph when this one is bigger than the outputwindow.
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub CopyRTB_Click(sender As Object, e As EventArgs) Handles CopyRTB.Click
        copyText()
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
