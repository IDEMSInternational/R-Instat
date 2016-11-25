Imports System.Windows
Imports System.Windows.Input

Public Class ucrWPFRichTextBox
    Private Sub rtbOutput_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles rtbOutput.MouseDoubleClick
        Dim pos As Point = e.GetPosition(rtbOutput)
        Dim pointer As Documents.TextPointer = rtbOutput.GetPositionFromPoint(pos, False)
        If pointer IsNot Nothing Then
            For Each block As Documents.Block In rtbOutput.Document.Blocks
                rtbOutput.Selection.Select(block.ContentStart, block.ContentEnd)
                If Not rtbOutput.Selection.IsEmpty AndAlso rtbOutput.Selection.Contains(pointer) Then
                    Exit For
                Else
                    rtbOutput.Selection.Select(pointer, pointer)
                End If
            Next
        Else
            rtbOutput.Selection.Select(rtbOutput.Selection.End, rtbOutput.Selection.End)
        End If
    End Sub

    Public Sub AddIntoWebBrowser(Optional strHtmlCode As String = Nothing, Optional strFilePath As String = Nothing)
        Dim conWebBrowser As Documents.BlockUIContainer
        Dim NewWebBrowser As New Controls.WebBrowser()
        Dim thickness As New Thickness(1)

        NewWebBrowser.BeginInit()
        If strHtmlCode IsNot Nothing Then
            NewWebBrowser.NavigateToString(strHtmlCode)
        ElseIf strFilePath IsNot Nothing Then
            NewWebBrowser.Navigate(New Uri(strFilePath))
        End If
        NewWebBrowser.MinHeight = 400
        NewWebBrowser.EndInit()

        conWebBrowser = New Documents.BlockUIContainer(NewWebBrowser)
        conWebBrowser.BorderThickness = thickness
        conWebBrowser.BorderBrush = Media.Brushes.Black
        conWebBrowser.Padding = thickness
        rtbOutput.Document.Blocks.Add(conWebBrowser)
        rtbOutput.Document.Blocks.Add(New Documents.Paragraph)
    End Sub

    Public Sub CleanWebBrowsers()
        For Each block As Documents.BlockUIContainer In rtbOutput.Document.Blocks
            If TypeOf (block.Child) Is Controls.WebBrowser Then
                ' block.Child.ClearValue(Controls.WebBrowser.)
            End If
        Next
    End Sub
End Class
