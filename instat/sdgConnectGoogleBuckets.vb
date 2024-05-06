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

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "Text Files|*.json"
            dlgOpen.Title = "Import JSON File"

            dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputTokenPath.GetText(), "/", "\"))

            If dlgOpen.ShowDialog() = DialogResult.OK AndAlso dlgOpen.FileName <> "" Then
                ucrInputTokenPath.SetName(Replace(dlgOpen.FileName, "\", "/"))
            End If
        End Using
    End Sub
End Class