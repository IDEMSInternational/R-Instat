Imports System.Runtime.InteropServices
Imports CefSharp.WinForms
Imports CefSharp

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

    'Public Sub LoadUrl(strUrl As String)
    '    'todo.
    '    'example; www.google.com
    '    ' browser.LoadUrl(strUrl)
    'End Sub

    'Public Sub LoadHtml(strHtml As String)
    '    'todo.
    '    'browser.LoadHtml(strHtml)
    'End Sub

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
        If Not e.IsLoading AndAlso browser.CanExecuteJavascriptInMainFrame Then
            'javascript for getting document height
            Dim script As String = "(function() { var body = document.body; var html = document.documentElement; return  Math.max( body.scrollHeight, body.offsetHeight, html.clientHeight, html.scrollHeight, html.offsetHeight ); })();"
            Dim task As Task(Of JavascriptResponse) = browser.EvaluateScriptAsync(script)
            task.ContinueWith(Sub(t)
                                  If t.IsFaulted = False Then
                                      Dim response = t.Result 'Error: Result is not a member of Task' 
                                      If response.Success And response.Result IsNot Nothing Then
                                          Dim taskResult As String = response.Result
                                          Me.Invoke(Sub()
                                                        Height = Integer.Parse(taskResult)
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

End Class
