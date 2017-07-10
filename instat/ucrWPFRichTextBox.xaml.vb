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

Imports System.Windows
Imports System.Windows.Input
Imports System.IO
Public Class ucrWPFRichTextBox
    Private Class NewWebBrowser
        'This class enables to keep some control over these NewWebbrowsers that are added while the software is running. 
        Public WithEvents NewWebBrowser As Controls.WebBrowser
        Public Sub New()
            NewWebBrowser = New Controls.WebBrowser()
        End Sub
        Private Sub NewWebBrowser_On_LoadCompleted() Handles NewWebBrowser.LoadCompleted
            'NewWebBrowser.Height = NewWebBrowser.Document.Body.ScrollRectangle.Size.Height 'Unfortunately this is for the windows forms webbrowser... 
        End Sub
    End Class

    Public Sub AppendText(color As Color, font As Font, text As String, Optional color2 As Color = Nothing, Optional font2 As Font = Nothing, Optional text2 As String = Nothing)
        'Adds a block (paragraph) of text to the output window in the required font and color. Can add up to two "lines" of distinct text for now (e.g. one line comment other line RCommand). 
        Dim run1 As New Documents.Run(text)

        'TODO Need to extract more options from font into run1
        If font.Bold Then
            run1.FontWeight = FontWeights.Bold
        End If
        If font.Italic Then
            run1.FontStyle = FontStyles.Italic
        End If
        If font.Strikeout Then
            run1.TextDecorations = TextDecorations.Strikethrough
        End If
        If font.Underline Then
            run1.TextDecorations = TextDecorations.Underline
        End If
        run1.FontSize = font.SizeInPoints
        run1.FontFamily = New Media.FontFamily(font.FontFamily.Name)
        run1.Foreground = New Media.BrushConverter().ConvertFromString(color.Name)
        Dim blkParagraph As New Documents.Paragraph(run1)
        'blkParagraph.Inlines.Add(New Documents.LineBreak)
        If font2 IsNot Nothing AndAlso text2 IsNot Nothing AndAlso color2 <> Nothing Then 'Note: IsNot only works for reference types...
            Dim run2 As New Documents.Run(text2)
            If font2.Bold Then
                run2.FontWeight = FontWeights.Bold
            End If
            If font2.Italic Then
                run2.FontStyle = FontStyles.Italic
            End If
            run2.FontSize = font2.Size
            'TODO This will not allow strikethrough and underline
            If font2.Strikeout Then
                run2.TextDecorations = TextDecorations.Strikethrough
            End If
            If font2.Underline Then
                run2.TextDecorations = TextDecorations.Underline
            End If
            run2.FontFamily = New Media.FontFamily(font2.FontFamily.Name)
            run2.Foreground = New Media.BrushConverter().ConvertFromString(color2.Name)
            blkParagraph.Inlines.Add(run2)
        End If
        rtbOutput.Document.Blocks.Add(blkParagraph)
        rtbOutput.ScrollToEnd()
    End Sub

    Public Sub CreateTempDirectory()
        'This sub should be called during the setup, maybe write it as R code within the setup method ? For the moment it is called on load of frmMain in the OutputWindow setup.
        Dim strDirectoryPath As String
        strDirectoryPath = Path.Combine(IO.Path.GetTempPath() & "R_Instat_Temp_Graphs")
        Console.WriteLine("Creating the directory: " & strDirectoryPath)
        'Specify the directories you want to manipulate.
        Dim diDirectoryInfo As IO.DirectoryInfo = New IO.DirectoryInfo(strDirectoryPath)
        Try
            ' Determine whether the directory exists.
            If diDirectoryInfo.Exists Then
                ' Indicate that it already exists.
                Console.WriteLine("The directory: " & strDirectoryPath & " already exists.")
                Return
            End If
            ' Try to create the directory.
            diDirectoryInfo.Create()
            Console.WriteLine("The directory: " & strDirectoryPath & " was created successfully.")
        Catch e As Exception
            Console.WriteLine("The process failed: {0}", e.Message)
            'Temporarily adding a vb message box for debug purposes.
            MsgBox(e.Message & Environment.NewLine & "A problem occured in attempting to create the directory: " & strDirectoryPath, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub DisplayGraph(strImageLocation As String)
        'Adds a graph to the output window.
        Dim blkParagraph As Documents.Paragraph
        Dim conImage As System.Windows.Documents.InlineUIContainer
        Dim UIEimage As New System.Windows.Controls.Image()
        Dim bimg As New System.Windows.Media.Imaging.BitmapImage()
        Dim thickness As New System.Windows.Thickness(1)
        Using fstream As New IO.FileStream(strImageLocation, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            bimg.BeginInit()
            bimg.CacheOption = System.Windows.Media.Imaging.BitmapCacheOption.OnLoad
            bimg.StreamSource = fstream
            bimg.EndInit()
        End Using
        bimg.Freeze()
        UIEimage.Source = bimg
        UIEimage.Stretch = System.Windows.Media.Stretch.Uniform
        UIEimage.StretchDirection = System.Windows.Controls.StretchDirection.DownOnly
        conImage = New System.Windows.Documents.InlineUIContainer(UIEimage)
        blkParagraph = New Documents.Paragraph(conImage)
        blkParagraph.BorderThickness = thickness
        blkParagraph.BorderBrush = System.Windows.Media.Brushes.Black
        blkParagraph.Padding = thickness
        rtbOutput.Document.Blocks.Add(blkParagraph)
        rtbOutput.Document.Blocks.Add(New System.Windows.Documents.Paragraph)
        rtbOutput.ScrollToEnd()
        'TESTING TO BE REMOVED
        'Dim strStargazer As String = "<table style=" & Chr(34) & "text-align:center" & Chr(34) & "><tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">Statistic</td><td>N</td><td>Mean</td><td>St. Dev.</td><td>Min</td><td>Max</td></tr>
        '<tr><td colspan = " & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">rating</td><td>30</td><td>64.633</td><td>12.173</td><td>40</td><td>85</td></tr>
        '<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">complaints</td><td>30</td><td>66.600</td><td>13.315</td><td>37</td><td>90</td></tr>
        '<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">privileges</td><td>30</td><td>53.133</td><td>12.235</td><td>30</td><td>83</td></tr>
        '<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">learning</td><td>30</td><td>56.367</td><td>11.737</td><td>34</td><td>75</td></tr>
        '<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">raises</td><td>30</td><td>64.633</td><td>10.397</td><td>43</td><td>88</td></tr>
        '<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">critical</td><td>30</td><td>74.767</td><td>9.895</td><td>49</td><td>92</td></tr>
        '<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">advance</td><td>30</td><td>42.933</td><td>10.289</td><td>25</td><td>72</td></tr>
        '<tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom: 1px solid black" & Chr(34) & "></td></tr></table>"
        '        AddIntoWebBrowser(strFilePath:="file:///C:/Users/Fran%C3%A7ois/Documents/Administratif/jobs/ADI/R_HTML_Files/firstggplotgrphinhtml.html")
        '       AddIntoWebBrowser(strHtmlCode:=strStargazer)
    End Sub

    Public Sub AddIntoWebBrowser(Optional strHtmlCode As String = Nothing, Optional strFilePath As String = Nothing)
        'This sub is used to add HTML content to the output window. It can take as arguments a string of Html code or a path to an Html file. In both cases, it will create a small webbrowser within the output window and display the html content there.
        'Note that a class has been created for these temp webbrowsers in case one would want to add common features or introduce a dispose method if necessary.
        Dim conWebBrowser As Documents.BlockUIContainer
        Dim clsNewWebBrowser As New NewWebBrowser()
        Dim thickness As New Thickness(1)

        clsNewWebBrowser.NewWebBrowser.BeginInit()
        If strHtmlCode IsNot Nothing Then
            clsNewWebBrowser.NewWebBrowser.NavigateToString(strHtmlCode)
        ElseIf strFilePath IsNot Nothing Then
            clsNewWebBrowser.NewWebBrowser.Navigate(New Uri(strFilePath))
        End If
        clsNewWebBrowser.NewWebBrowser.MinHeight = 350
        clsNewWebBrowser.NewWebBrowser.EndInit()
        conWebBrowser = New Documents.BlockUIContainer(clsNewWebBrowser.NewWebBrowser)
        conWebBrowser.BorderThickness = thickness
        conWebBrowser.BorderBrush = Media.Brushes.Black
        conWebBrowser.Padding = thickness
        rtbOutput.Document.Blocks.Add(conWebBrowser)
        rtbOutput.Document.Blocks.Add(New Documents.Paragraph)
        rtbOutput.ScrollToEnd()
    End Sub

    Private Sub rtbOutput_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles rtbOutput.MouseDoubleClick
        'On double click, the content of the Paragraph under the mouse is selected. This will be used to repopulate dialogues from RCommands displayed in the output window.
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

    Public Sub CopyUIElementToClipboard(element As System.Windows.FrameworkElement)
        'This sub is used to copy the image in a UIElement to the clipboard. It is called within the CopyImage sub on the frmOutputWindow.
        Dim width As Double = element.ActualWidth
        Dim Height As Double = element.ActualHeight
        Dim bmpCopied As System.Windows.Media.Imaging.RenderTargetBitmap = New System.Windows.Media.Imaging.RenderTargetBitmap(Convert.ToInt32(width), Convert.ToInt32(Height), 96, 96, System.Windows.Media.PixelFormats.Default)
        Dim drawingVisual As System.Windows.Media.DrawingVisual = New System.Windows.Media.DrawingVisual()

        Using drawingContext As System.Windows.Media.DrawingContext = drawingVisual.RenderOpen()
            Dim visualBrush As New System.Windows.Media.VisualBrush(element)
            drawingContext.DrawRectangle(visualBrush, Nothing, New System.Windows.Rect(New System.Windows.Point(), New System.Windows.Size(width, Height)))
        End Using
        bmpCopied.Render(drawingVisual)
        System.Windows.Clipboard.SetImage(bmpCopied)
    End Sub

    Public Sub SaveRtf(ByVal strFileName As String)
        'Save rtf content of RichTextBox to a file specified by strFileName. This is called on the frmMain to save the content of the OutputWindow.
        Dim range As Documents.TextRange
        range = New Documents.TextRange(rtbOutput.Document.ContentStart, rtbOutput.Document.ContentEnd)
        Using fStream As New FileStream(strFileName, FileMode.Create)
            range.Save(fStream, DataFormats.Rtf)
        End Using
    End Sub

    Public Sub PrintCommand() 'Warning !!! using a controls PrintDialog :(
        'Question: Where should this be used ?
        'Print RichTextBox content
        Dim pd As New Controls.PrintDialog()
        If (pd.ShowDialog()) Then
            'use either one of the below      
            pd.PrintVisual(TryCast(rtbOutput, Media.Visual), "printing as visual")
            pd.PrintDocument(((CType(rtbOutput.Document, Documents.IDocumentPaginatorSource)).DocumentPaginator), "printing as paginator")
        End If
    End Sub

End Class