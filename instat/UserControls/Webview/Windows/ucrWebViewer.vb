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

Imports CefSharp.WinForms
Imports CefSharp
Imports CefSharp.DevTools.DOM

'''--------------------------------------------------------------------------------------------
''' <summary>
''' Control for viewing html output content
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class ucrWebViewer
    Inherits Panel

    Private ReadOnly _browser As ChromiumWebBrowser

    Public Sub New()
        Me.Margin = New Padding(0)
        _browser = New ChromiumWebBrowser()
        AddHandler _browser.LoadingStateChanged, AddressOf OnLoadingStateChanged
        Me.Controls.Add(_browser)
    End Sub

    Public Sub LoadHtmlFile(strFileName As String, Optional bReplace As Boolean = True)
        If _browser Is Nothing Then
            Return
        End If
        'todo. this implementation may need to be changed if we face it's limitations
        'the use of file:/// is not preferred
        'see reason in https://github.com/cefsharp/CefSharp/wiki/General-Usage#file-uri-file
        'it's not yet clear how we can implement a custom schema at this point,
        'not unless we specify R-Instat temp output folder in the R commands.
        'that should be the first step
        Dim strUrl As String = strFileName
        If bReplace Then
            strUrl = "file:///" + strFileName.Replace("\", "/")
        End If
        _browser.LoadUrl(strUrl)
        _browser.Dock = DockStyle.Fill
    End Sub

    Private Sub OnLoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs)
        'by default always set the height of this control to correspond to the html document after loading.
        If Not e.IsLoading Then
            'Get the height of the html document and set it as the controls height
            Dim task2 As Task(Of Rect) = _browser.GetContentSizeAsync()
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
        If _browser IsNot Nothing Then
            _browser.Dispose()
        End If
        MyBase.Dispose(bDisposing)
    End Sub

    'Private Sub InitializeComponent()
    '    Me.SuspendLayout()
    '    Me.ResumeLayout(False)

    'End Sub


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