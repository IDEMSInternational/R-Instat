
Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmOutputWindow2
    'TEST temporary
    Private Sub frmOutputWindow2_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
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

    Public Sub copyText()
        ucrRichTextBox.rtfCommand.Copy()
    End Sub

    Public Sub selectAllText()
        ucrRichTextBox.rtfCommand.SelectAll()
    End Sub

    Private Sub frmCommand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewOutputWindow.Checked = Me.Visible
    End Sub

    Private Sub ucrWPFrtfElementHost_MouseDown(sender As Object, e As MouseEventArgs) Handles ucrWPFrtfElementHost.MouseDown
        If e.Button = MouseButtons.Right And ucrRichTextBox.rtfCommand.Selection IsNot Nothing Then
            ucrWPFrtfElementHost.ContextMenuStrip = mnuContextRTB
        Else
            ucrWPFrtfElementHost.ContextMenu = Nothing
        End If
    End Sub
End Class