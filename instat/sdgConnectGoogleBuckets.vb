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

Imports instat.Translations
Imports System.IO

Public Class sdgConnectGoogleBuckets
    Public ClsGcsAuthFileFunction As RFunction
    Public bControlsInitialised As Boolean = False

    Private Sub sdgImportFromRapidPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputTokenPath.IsReadOnly = True
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        ucrInputTokenPath.SetParameter(New RParameter("file", 0))
    End Sub
    Public Sub SetRCode(ClsNewGcsAuthFileFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        ClsGcsAuthFileFunction = ClsNewGcsAuthFileFunction

        ucrInputTokenPath.SetRCode(ClsGcsAuthFileFunction, bReset)
    End Sub
    Public Sub Setup(clsNewKeyParameter As RParameter)
        ucrInputTokenPath.SetParameter(clsNewKeyParameter, 0)
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save JSON File"
            dlgSave.Filter = "Text Files|*.json"
            If ucrInputTokenPath.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputTokenPath.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputTokenPath.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
        End Using
    End Sub

    Private Sub ucrInputTokenPath_Click(sender As Object, e As EventArgs) Handles ucrInputTokenPath.Click
        If ucrInputTokenPath.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectFileToSave()
    End Sub
End Class