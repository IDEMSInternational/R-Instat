Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Controls
Imports CefSharp.DevTools

Public Class frmMaximiseOutput
    Private _strDisplayedFileName As String = ""
    Private _strFileFilter As String = ""
    'todo. to be used by the output page to remember paths selected by user when saving outputs
    Public _strFileDestinationDirectory As String = ""

    Public Overloads Sub Show(strFileName As String)
        Me._strDisplayedFileName = strFileName
        Dim strFileExtension As String = Path.GetExtension(_strDisplayedFileName).ToLower
        Me.panelControl.Controls.Clear()

        Select Case strFileExtension
            Case ".txt"
                _strFileFilter = "txt (*.txt)|*.txt"
                Dim ucrTextViewer As New ucrTextViewer
                ucrTextViewer.LoadTextFile(strFileName)
                ucrTextViewer.FormatText(OutputFont.ROutputFont, OutputFont.ROutputColour)
                Me.panelControl.Controls.Add(ucrTextViewer)
                ucrTextViewer.Dock = DockStyle.Fill
            Case ".png"
                _strFileFilter = "png (*.png)|*.png"
                Dim pictureBox As New PictureBox
                pictureBox.Load(_strDisplayedFileName)
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom
                Me.panelControl.Controls.Add(pictureBox)
                pictureBox.Dock = DockStyle.Fill
            Case ".html"
                If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) AndAlso CefRuntimeWrapper.IsCefInitilised Then
                    _strFileFilter = "html (*.html)|*.html"
                    Dim ucrWebView As New ucrWebViewer
                    ucrWebView.LoadHtmlFile(_strDisplayedFileName)
                    Me.panelControl.Controls.Add(ucrWebView)
                    ucrWebView.Dock = DockStyle.Fill
                Else
                    'display the html output in default browser
                    Cursor = Cursors.WaitCursor
                    Process.Start(_strDisplayedFileName)
                    Cursor = Cursors.Default
                    'important. just return don't show the form
                    Return
                End If
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

                'for htmls copy the html file with it's associated directory; css, javascript files etc
                If Path.GetExtension(_strDisplayedFileName).ToLower = ".html" Then
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