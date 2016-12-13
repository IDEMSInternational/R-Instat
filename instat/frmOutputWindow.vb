
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
        For Each block As Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) AndAlso ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentEnd) AndAlso TypeOf (block) Is Windows.Documents.Paragraph AndAlso CType(block, Windows.Documents.Paragraph).Inlines.Count = 1 AndAlso TypeOf (CType(block, Windows.Documents.Paragraph).Inlines.FirstInline) Is Windows.Documents.InlineUIContainer Then
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

    Private Sub CopyUIElementToClipboard(element As Windows.FrameworkElement)
        'This sub is used to copy the image in a UIElement to the clipboard.
        Dim width As Double = element.ActualWidth
        Dim Height As Double = element.ActualHeight
        Dim bmpCopied As Windows.Media.Imaging.RenderTargetBitmap = New Windows.Media.Imaging.RenderTargetBitmap(Convert.ToInt32(width), Convert.ToInt32(Height), 96, 96, Windows.Media.PixelFormats.Default)
        Dim drawingVisual As Windows.Media.DrawingVisual = New Windows.Media.DrawingVisual()

        Using drawingContext As Windows.Media.DrawingContext = drawingVisual.RenderOpen()
            Dim visualBrush As New Windows.Media.VisualBrush(element)
            drawingContext.DrawRectangle(visualBrush, Nothing, New Windows.Rect(New Windows.Point(), New Windows.Size(width, Height)))
        End Using
        bmpCopied.Render(drawingVisual)
        Windows.Clipboard.SetImage(bmpCopied)
    End Sub

    Private Sub CopyImageRTB_Click(sender As Object, e As EventArgs) Handles CopyImageRTB.Click
        'Copies the first selected image into the clipboard.
        Dim prphTemp As Windows.Documents.Paragraph
        Dim conImage As Windows.Documents.InlineUIContainer
        For Each block As Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If TypeOf (block) Is Windows.Documents.Paragraph Then
                prphTemp = block
                If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) AndAlso prphTemp.Inlines.Count = 1 AndAlso TypeOf (prphTemp.Inlines.FirstInline) Is Windows.Documents.InlineUIContainer Then
                    conImage = prphTemp.Inlines.FirstInline
                    CopyUIElementToClipboard(conImage.Child)
                    Exit Sub
                End If
            End If
        Next
    End Sub
End Class