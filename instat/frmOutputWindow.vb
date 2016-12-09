
Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmOutputWindow
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
        Dim lstImages As New List(Of Windows.UIElement)
        For Each block As Windows.Documents.BlockUIContainer In ucrRichTextBox.rtbOutput.Document.Blocks
            If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) Then
                'There are two cases now: consider webbrowser case ...
                'Dim conImage As Windows.Documents.BlockUIContainer = block
                'lstImages.Add(conImage.Child)
            End If
        Next

        ucrRichTextBox.rtbOutput.Copy()
    End Sub

    Public Sub selectAllText()
        ucrRichTextBox.rtbOutput.SelectAll()
    End Sub

    Private Sub frmCommand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewOutputWindow.Checked = Me.Visible
    End Sub

    Private Sub ucrWPFrtfElementHost_MouseDown(sender As Object, e As MouseEventArgs) Handles ucrWPFrtfElementHost.MouseDown
        If e.Button = MouseButtons.Right And ucrRichTextBox.rtbOutput.Selection IsNot Nothing Then
            ucrWPFrtfElementHost.ContextMenuStrip = mnuContextRTB
        Else
            ucrWPFrtfElementHost.ContextMenu = Nothing
        End If
    End Sub

    Private Sub frmOutputWindow2_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Right And ucrRichTextBox.rtbOutput.Selection IsNot Nothing Then
            ucrWPFrtfElementHost.ContextMenuStrip = mnuContextRTB
        Else
            ucrWPFrtfElementHost.ContextMenu = Nothing
        End If
    End Sub
    'Warning !! the events mouse down and click copy above are never raised, the strip menu seems to come from somewhere else, ... for the moment quite mysterious, need to investigate...
End Class