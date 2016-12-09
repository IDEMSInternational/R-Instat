Imports System.Windows
Imports System.Windows.Input
Imports System.IO
Public Class ucrWPFRichTextBox
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
    Public Sub AppendText(color As Color, font As Font, text As String, Optional color2 As Color = Nothing, Optional font2 As Font = Nothing, Optional text2 As String = Nothing)
        'Task: migrate the sub to the ucrWPFRichTextBox...
        Dim run1 As New Documents.Run(text)
        run1.FontFamily = New Media.FontFamily(font.FontFamily.Name)
        run1.Foreground = New Media.BrushConverter().ConvertFromString(color.Name)
        Dim Paragraph As New Documents.Paragraph(run1)
        If font2 IsNot Nothing AndAlso text2 IsNot Nothing AndAlso color2 <> Nothing Then 'Note: IsNot only works for reference types...
            Dim run2 As New Documents.Run(text2)
            run2.FontFamily = New Media.FontFamily(font2.FontFamily.Name)
            run2.Foreground = New Media.BrushConverter().ConvertFromString(color2.Name)
            Paragraph.Inlines.Add(run2)
        End If
        rtbOutput.Document.Blocks.Add(Paragraph)
    End Sub

    Public Sub DisplayGraphInOutput(strImageLocation As String)
        'Task: migrate the sub to the ucrWPFRichTextBox class ?
        'TEST temporary
        Dim conImage As Windows.Documents.BlockUIContainer
        Dim UIEimage As New Windows.Controls.Image()
        Dim bimg As New Windows.Media.Imaging.BitmapImage()
        Dim thickness As New Windows.Thickness(1)
        Using fstream As New IO.FileStream(strImageLocation, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            bimg.BeginInit()
            bimg.CacheOption = Windows.Media.Imaging.BitmapCacheOption.OnLoad
            bimg.StreamSource = fstream
            bimg.EndInit()
        End Using
        bimg.Freeze()
        UIEimage.Source = bimg
        UIEimage.Stretch = Windows.Media.Stretch.Uniform
        UIEimage.StretchDirection = Windows.Controls.StretchDirection.DownOnly
        conImage = New Windows.Documents.BlockUIContainer(UIEimage)
        conImage.BorderThickness = thickness
        conImage.BorderBrush = Windows.Media.Brushes.Black
        conImage.Padding = thickness
        rtbOutput.Document.Blocks.Add(conImage)
        rtbOutput.Document.Blocks.Add(New Windows.Documents.Paragraph)

        'TESTING TO BE REMOVED
        Dim strStargazer As String = "<table style=" & Chr(34) & "text-align:center" & Chr(34) & "><tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">Statistic</td><td>N</td><td>Mean</td><td>St. Dev.</td><td>Min</td><td>Max</td></tr>
<tr><td colspan = " & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom:  1px solid black" & Chr(34) & "></td></tr><tr><td style=" & Chr(34) & "text-align:Left" & Chr(34) & ">rating</td><td>30</td><td>64.633</td><td>12.173</td><td>40</td><td>85</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">complaints</td><td>30</td><td>66.600</td><td>13.315</td><td>37</td><td>90</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">privileges</td><td>30</td><td>53.133</td><td>12.235</td><td>30</td><td>83</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">learning</td><td>30</td><td>56.367</td><td>11.737</td><td>34</td><td>75</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">raises</td><td>30</td><td>64.633</td><td>10.397</td><td>43</td><td>88</td></tr>
<tr><td style=" & Chr(34) & "text-align: Left" & Chr(34) & ">critical</td><td>30</td><td>74.767</td><td>9.895</td><td>49</td><td>92</td></tr>
<tr><td style = " & Chr(34) & "text-align: Left" & Chr(34) & ">advance</td><td>30</td><td>42.933</td><td>10.289</td><td>25</td><td>72</td></tr>
<tr><td colspan=" & Chr(34) & "6" & Chr(34) & " style=" & Chr(34) & "border-bottom: 1px solid black" & Chr(34) & "></td></tr></table>"
        AddIntoWebBrowser(strFilePath:="file:///C:/Users/Fran%C3%A7ois/Documents/Administratif/jobs/ADI/R_HTML_Files/firstggplotgrphinhtml.html")
        AddIntoWebBrowser(strHtmlCode:=strStargazer)
    End Sub

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
        clsNewWebBrowser.NewWebBrowser.MinHeight = 350
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

    ' Save XAML in RichTextBox to a file specified by strFileName
    Public Sub SaveXamlPackage(ByVal strFileName As String)
        Dim range As Documents.TextRange
        Dim fStream As FileStream
        range = New Documents.TextRange(rtbOutput.Document.ContentStart, rtbOutput.Document.ContentEnd)
        fStream = New FileStream(strFileName, FileMode.Create)
        range.Save(fStream, DataFormats.XamlPackage)
        fStream.Close()
    End Sub

    ' Print RichTextBox content
    Public Sub PrintCommand() 'Warning !!! using a controls PrintDialog :(
        Dim pd As New Controls.PrintDialog()
        If (pd.ShowDialog() = True) Then
            'use either one of the below      
            pd.PrintVisual(TryCast(rtbOutput, Media.Visual), "printing as visual")
            pd.PrintDocument(((CType(rtbOutput.Document, Documents.IDocumentPaginatorSource)).DocumentPaginator), "printing as paginator")
        End If
    End Sub

End Class