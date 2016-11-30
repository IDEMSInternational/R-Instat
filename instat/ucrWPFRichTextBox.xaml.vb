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

    Private Class NewWebBrowser
        'This class enables to keep some control over these NewWebbrowsers that are added while the software is running. 
        'It enables to create subs that 
        Public WithEvents NewWebBrowser As Controls.WebBrowser

        Public Sub New()
            NewWebBrowser = New Controls.WebBrowser()
        End Sub
        Private Sub NewWebBrowser_On_LoadCompleted() Handles NewWebBrowser.LoadCompleted
            'NewWebBrowser.Height = NewWebBrowser.Document.Body.ScrollRectangle.Size.Height 'Unfortunately this is for the windows forms webbrowser... 
        End Sub
    End Class
    Public Sub AddIntoWebBrowser(Optional strHtmlCode As String = Nothing, Optional strFilePath As String = Nothing)
        Dim conWebBrowser As Documents.BlockUIContainer
        Dim clsNewWebBrowser As New NewWebBrowser()
        Dim thickness As New Thickness(1)

        clsNewWebBrowser.NewWebBrowser.BeginInit()
        If strHtmlCode IsNot Nothing Then
            clsNewWebBrowser.NewWebBrowser.NavigateToString(strHtmlCode)
        ElseIf strFilePath IsNot Nothing Then
            clsNewWebBrowser.NewWebBrowser.Navigate(New Uri(strFilePath))
        End If
        clsNewWebBrowser.NewWebBrowser.MinHeight = 300
        clsNewWebBrowser.NewWebBrowser.EndInit()
        conWebBrowser = New Documents.BlockUIContainer(clsNewWebBrowser.NewWebBrowser)
        conWebBrowser.BorderThickness = thickness
        conWebBrowser.BorderBrush = Media.Brushes.Black
        conWebBrowser.Padding = thickness
        rtbOutput.Document.Blocks.Add(conWebBrowser)
        rtbOutput.Document.Blocks.Add(New Documents.Paragraph)
        'Warning: Maybe find a way to keep track of these webbrowsers... Set this as a function ?
    End Sub

    Public Sub CleanWebBrowsers()
        For Each block As Documents.BlockUIContainer In rtbOutput.Document.Blocks
            If TypeOf (block.Child) Is Controls.WebBrowser Then
                ' block.Child.ClearValue(Controls.WebBrowser.)
            End If
        Next
    End Sub
End Class
