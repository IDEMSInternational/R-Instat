Imports System.Runtime.InteropServices
Imports CefSharp.WinForms
Imports CefSharp
Imports CefSharp.DevTools.DOM

'todo. inherit panel?
Public Class ucrWebview
    Inherits Panel

    Private ReadOnly browser As ChromiumWebBrowser

    Public Sub New()

        If Not RuntimeInformation.IsOSPlatform(OSPlatform.Windows) Then
            MsgBox("Developer error: CefRuntime NOT initialised")
            Return
        End If

        browser = New ChromiumWebBrowser()
        AddHandler browser.LoadingStateChanged, AddressOf OnLoadingStateChanged
        Controls.Add(browser)
    End Sub

    Public Sub LoadFile(strFilePathName As String)
        If browser Is Nothing Then
            Return
        End If
        'todo. this implementation may need to be changed if we face it's limitations
        'the use of file:/// is not preferred 
        'see reason in https://github.com/cefsharp/CefSharp/wiki/General-Usage#file-uri-file
        'it's not yet clear how we can implement a custom schema at this point,
        'not unless we specify R-Instat temp output folder in the R commands.
        'that should be the first step

        Dim strUrl As String = "file:///" + strFilePathName.Replace("\", "/")
        browser.LoadUrl(strUrl)
        browser.Dock = DockStyle.Fill
    End Sub

    Private Sub OnLoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs)
        If Not e.IsLoading Then
            'Get the height of the html document and set it as the controls height
            Dim task2 As Task(Of Rect) = browser.GetContentSizeAsync()
            task2.ContinueWith(Sub(t)
                                   If Not t.IsFaulted Then
                                       Dim response As Rect = t.Result
                                       If response IsNot Nothing Then
                                           Me.Invoke(Sub()
                                                         Me.Height = response.Height
                                                     End Sub)
                                       End If

                                   End If
                               End Sub)
        End If
    End Sub

    Protected Overrides Sub Dispose(bDisposing As Boolean)
        If browser IsNot Nothing Then
            browser.Dispose()
        End If
        MyBase.Dispose(bDisposing)
    End Sub


    'Public Sub LoadUrl(strUrl As String)
    '    'todo. left here for reference
    '    'example; www.google.com
    '    ' browser.LoadUrl(strUrl)
    'End Sub

    'Public Sub LoadHtml(strHtml As String)
    '    'todo.  left here for reference
    '    'browser.LoadHtml(strHtml)
    'End Sub

End Class
