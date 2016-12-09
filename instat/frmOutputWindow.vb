
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
        CopyContent()
    End Sub

    Public Sub CopyContent()
        Dim lstImages As New List(Of Windows.UIElement)
        Dim range As Windows.Documents.TextRange


        For Each block As Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If TypeOf (block) Is Windows.Documents.BlockUIContainer AndAlso ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) Then
                'There are two cases now: consider webbrowser case ...
                'Dim conImage As Windows.Documents.BlockUIContainer = block
                'lstImages.Add(conImage.Child)
            End If
        Next
        ucrRichTextBox.rtbOutput.Copy() 'Warning: Copy is a text method, only copies text...



        '       Using stream As New IO.MemoryStream
        '      range = New Windows.Documents.TextRange(ucrRichTextBox.rtbOutput.Document.ContentStart, ucrRichTextBox.rtbOutput.Document.ContentEnd)
        '     range.Save(stream, Windows.DataFormats.XamlPackage)
        '    Clipboard.SetData(DataFormats.Rtf, System.Text.Encoding.UTF8.GetString(stream.ToArray()))
        '    stream.Close()
        '    End Using

    End Sub

    Public Sub selectAllText()
        ucrRichTextBox.rtbOutput.SelectAll()
    End Sub

    Private Sub frmCommand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewOutputWindow.Checked = Me.Visible
    End Sub
    'Warning !! the events mouse down and click copy above are never raised, the strip menu seems to come from somewhere else, ... for the moment quite mysterious, need to investigate...
End Class