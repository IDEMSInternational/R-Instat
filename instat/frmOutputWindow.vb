
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
        'copies the content of the selection in rich text format.
        ucrRichTextBox.rtbOutput.Copy() 'Warning: Copy is a text method, only copies text...
        'Using stream As New IO.MemoryStream
        'Range = New Windows.Documents.TextRange(ucrRichTextBox.rtbOutput.Document.ContentStart, ucrRichTextBox.rtbOutput.Document.ContentEnd)
        'Range.Save(stream, Windows.DataFormats.XamlPackage)
        'Clipboard.SetData(DataFormats.Rtf, System.Text.Encoding.UTF8.GetString(stream.ToArray()))
        'stream.Close()
        'End Using
    End Sub

    Public Sub selectAllText()
        ucrRichTextBox.rtbOutput.SelectAll()
    End Sub

    Private Sub frmCommand_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewOutputWindow.Checked = Me.Visible
    End Sub

    Private Sub mnuContextRTB_Opening(sender As Object, e As CancelEventArgs) Handles mnuContextRTB.Opening
        'This sub checks whether or not Copy Image should be enabled. It is enabled if one of the selected block is an "1 image paragraph".
        'Could add SaveImageRTB enabled when it exists.
        For Each block As System.Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) AndAlso ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentEnd) AndAlso TypeOf (block) Is System.Windows.Documents.Paragraph AndAlso CType(block, System.Windows.Documents.Paragraph).Inlines.Count = 1 AndAlso TypeOf (CType(block, System.Windows.Documents.Paragraph).Inlines.FirstInline) Is System.Windows.Documents.InlineUIContainer Then
                CopyImageRTB.Enabled = True
                Exit Sub
            End If
        Next
        CopyImageRTB.Enabled = False
    End Sub

    'Private Function RtfToImage(ByVal strRtf As String) As Image
    ''Load RTF Document
    'Dim file As IO.File
    'Save to Image
    'Dim image As Image = document.SaveToImages(0, ImageType.Bitmap)
    'image.FromStream(stream)
    'image.Save(“RTF2Image.jpg”, ImageFormat.Jpeg)
    'System.Diagnostics.Process.Start(“RTF2Image.jpg)
    'End Function

    Private Sub CopyImageRTB_Click(sender As Object, e As EventArgs) Handles CopyImageRTB.Click
        'Copies the first selected image into the clipboard.
        Dim prphTemp As System.Windows.Documents.Paragraph
        Dim conImage As System.Windows.Documents.InlineUIContainer
        For Each block As System.Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If TypeOf (block) Is System.Windows.Documents.Paragraph Then
                prphTemp = block
                If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) AndAlso prphTemp.Inlines.Count = 1 AndAlso TypeOf (prphTemp.Inlines.FirstInline) Is System.Windows.Documents.InlineUIContainer Then
                    conImage = prphTemp.Inlines.FirstInline
                    ucrRichTextBox.CopyUIElementToClipboard(conImage.Child)
                    Exit Sub
                End If
            End If
        Next
    End Sub
End Class