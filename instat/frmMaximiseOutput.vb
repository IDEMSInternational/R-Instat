Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Controls
Imports CefSharp.DevTools

Public Class frmMaximiseOutput
    Private _strDisplayedFileName As String = ""
    Private _strFileFilter As String = ""
    'todo. to be used by the output page to remember paths selected by user when saving outputs
    Public _strFileDestinationDirectory As String = ""

    'Public Sub SetOutput(strFileName As String)
    '    Me._strDisplayedFileName = strFileName
    'End Sub

    Public Overloads Sub Show(strFileName As String)
        Me._strDisplayedFileName = strFileName
        Dim strExtension As String = Path.GetExtension(_strDisplayedFileName).ToLower

        Select Case strExtension
            Case ".png"
                Dim pictureBox As New PictureBox
                pictureBox.Load(_strDisplayedFileName)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Me.Controls.Add(pictureBox)
                pictureBox.Dock = DockStyle.Fill
                _strFileFilter = "png (*.png)|*.png"
            Case ".html"
                If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) AndAlso CefRuntimeWrapper.IsCefInitilised Then
                    Dim ucrWebView As New ucrWebview
                    ucrWebView.LoadHtmlFile(_strDisplayedFileName)
                    Me.Controls.Add(ucrWebView)
                    ucrWebView.Dock = DockStyle.Fill
                    _strFileFilter = "html (*.html)|*.html"
                Else
                    'display the html output in default browser
                    Cursor = Cursors.WaitCursor
                    Process.Start(_strDisplayedFileName)
                    Cursor = Cursors.Default
                    'important. just return don't show the form
                    Return
                End If

            Case ".txt"
                'todo
                _strFileFilter = "txt (*.txt)|*.txt"
            Case Else
                'todo. developer error
                Return
        End Select
        MyBase.Show()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output"
            dlgSaveFile.Filter = _strFileFilter
            dlgSaveFile.InitialDirectory = If(String.IsNullOrEmpty(_strFileDestinationDirectory),
                    frmMain.clsInstatOptions.strWorkingDirectory, _strFileDestinationDirectory)
            If DialogResult.OK = dlgSaveFile.ShowDialog() Then

                _strFileDestinationDirectory = Path.GetDirectoryName(dlgSaveFile.FileName)

                If Path.GetExtension(_strDisplayedFileName).ToLower = ".html" Then
                    'copy the html file with it's associated directory; css, javascript files etc
                    For Each foundDirectory As String In My.Computer.FileSystem.GetDirectories(
                        Path.GetDirectoryName(_strDisplayedFileName),
                        FileIO.SearchOption.SearchTopLevelOnly,
                        "*" & Path.GetFileNameWithoutExtension(_strDisplayedFileName) & "*")
                        My.Computer.FileSystem.CopyDirectory(foundDirectory, _strFileDestinationDirectory, True)
                    Next
                Else
                    My.Computer.FileSystem.CopyFile(_strDisplayedFileName, dlgSaveFile.FileName, True)
                End If
            End If
        End Using

    End Sub

End Class