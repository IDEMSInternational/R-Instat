Imports System.ComponentModel
Imports System.Globalization
Imports System.Threading
Imports instat.Translations

'TEST temporary
Public Class frmWebBrowser
    Private Sub frmWebBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        wbOutput.Dispose()
    End Sub

    Private Sub frmWebBrowser_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        Initialise()
    End Sub

    Private Sub Initialise()
        'Warning, need to initialise this webbrowser with some file, url or something... That's the reason for which it is not printing anything ...
        'https://msdn.microsoft.com/en-us/library/system.windows.forms.webbrowser.objectforscripting(v=vs.110).aspx
        'Dim appPath As String
        'appPath = Application.StartupPath
        'WebBrowser1.Navigate(appPath & "/html-file-name-here.html")
    End Sub
End Class