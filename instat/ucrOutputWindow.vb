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

Imports System.ComponentModel
Imports instat.Translations

Public Class ucrOutputWindow
    'TEST temporary
    Private Sub ucrOutputWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        'for some reason the normal KeyDown event is not raised when del key is pressed
        'probably because the del is not recognised as an inputkey to ucrRichTextBox 
        AddHandler ucrRichTextBox.PreviewKeyDown, AddressOf ucrRichTextBox_KeyDownEventHandler
    End Sub

    Private Sub ucrRichTextBox_KeyDownEventHandler(sender As Object, e As EventArgs)
        'if its a delete key then delete the selection
        If DirectCast(e, System.Windows.Input.KeyEventArgs).Key = System.Windows.Input.Key.Delete Then
            ucrRichTextBox.rtbOutput.Selection.Text = ""
        End If
    End Sub

    'Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
    '    MyBase.OnFormClosing(e)
    '    If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
    '        e.Cancel = True
    '        Me.Hide()
    '    End If
    'End Sub

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

    Public Sub SelectAllText()
        ucrRichTextBox.rtbOutput.SelectAll()
    End Sub

    Private Sub mnuContextRTB_Opening(sender As Object, e As CancelEventArgs) Handles mnuContextRTB.Opening
        CopyImageRTB.Enabled = False
        deleteRTB.Enabled = False
        'This sub checks whether or not Copy Image should be enabled. It is enabled if one of the selected block is an "1 image paragraph".
        'Could add SaveImageRTB enabled when it exists.
        For Each block As System.Windows.Documents.Block In ucrRichTextBox.rtbOutput.Document.Blocks
            If ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentStart) AndAlso ucrRichTextBox.rtbOutput.Selection.Contains(block.ContentEnd) AndAlso TypeOf (block) Is System.Windows.Documents.Paragraph AndAlso CType(block, System.Windows.Documents.Paragraph).Inlines.Count = 1 AndAlso TypeOf (CType(block, System.Windows.Documents.Paragraph).Inlines.FirstInline) Is System.Windows.Documents.InlineUIContainer Then
                CopyImageRTB.Enabled = True
                Exit For
            End If
        Next

        'checks whether to enable delete of selected content 
        If Not String.IsNullOrEmpty(ucrRichTextBox.rtbOutput.Selection.Text) Then
            deleteRTB.Enabled = True
        End If

        If frmMain.clsInstatOptions.bCommandsinOutput Then
            mnuHideCommands.Text = GetTranslation("Hide (future) commands")
        Else
            mnuHideCommands.Text = GetTranslation("Show commands")
        End If

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

    Private Sub clearRTB_Click(sender As Object, e As EventArgs) Handles clearRTB.Click
        Dim rstResponse As DialogResult
        rstResponse = MessageBox.Show("Are you sure you want to clear the Output Window?", "Clear Output Window", MessageBoxButtons.YesNo)
        If rstResponse = DialogResult.Yes Then
            ucrRichTextBox.rtbOutput.Document.Blocks.Clear()
        End If
    End Sub

    Private Sub deleteRTB_Click(sender As Object, e As EventArgs) Handles deleteRTB.Click
        ucrRichTextBox.rtbOutput.Selection.Text = ""
    End Sub

    Private Sub mnuHideCommands_Click(sender As Object, e As EventArgs) Handles mnuHideCommands.Click
        frmMain.clsInstatOptions.SetCommandInOutpt(Not frmMain.clsInstatOptions.bCommandsinOutput)
    End Sub

    Private Sub HelpRTB_Click(sender As Object, e As EventArgs) Handles HelpRTB.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "540")
    End Sub

End Class
