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
Imports System.IO
Imports System.Runtime.InteropServices

'''--------------------------------------------------------------------------------------------
''' <summary>
''' Form for viewing maximised output content
''' </summary>
'''--------------------------------------------------------------------------------------------
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
                MessageBox.Show(Me, "The file type to be viewed is currently not suported",
                            "Developer Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
                Return
        End Select

        MyBase.Show()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        'copies displayed file to the destination folder selected by user
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output"
            dlgSaveFile.Filter = _strFileFilter
            dlgSaveFile.InitialDirectory = If(String.IsNullOrEmpty(_strFileDestinationDirectory),
                    frmMain.clsInstatOptions.strWorkingDirectory, _strFileDestinationDirectory)
            If DialogResult.OK = dlgSaveFile.ShowDialog() Then

                _strFileDestinationDirectory = Path.GetDirectoryName(dlgSaveFile.FileName)

                If Path.GetExtension(_strDisplayedFileName).ToLower = ".html" Then
                    'for html copy the html file associated directories, css, javascript files etc
                    For Each strFoundDirectory As String In My.Computer.FileSystem.GetDirectories(
                                                           Path.GetDirectoryName(_strDisplayedFileName),
                                                           FileIO.SearchOption.SearchTopLevelOnly,
                                                           "*" & Path.GetFileNameWithoutExtension(_strDisplayedFileName) & "*")

                        'create the destination folder first
                        Dim strDestDir As String = Path.Combine(_strFileDestinationDirectory,
                                                             Path.GetFileName(strFoundDirectory))
                        If Not Directory.Exists(strDestDir) Then
                            Directory.CreateDirectory(strDestDir)
                        End If
                        My.Computer.FileSystem.CopyDirectory(strFoundDirectory, strDestDir, True)
                    Next
                End If

                'then copy the file
                My.Computer.FileSystem.CopyFile(_strDisplayedFileName, dlgSaveFile.FileName, True)
            End If
        End Using

    End Sub

End Class