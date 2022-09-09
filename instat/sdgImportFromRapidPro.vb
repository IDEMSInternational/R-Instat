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

Public Class sdgImportFromRapidPro

    Private Sub sdgImportFromRapidPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputTokenPath.IsReadOnly = True
        autoTranslate(Me)
    End Sub

    Public Sub Setup(clsNewKeyParameter As RParameter)
        ucrInputTokenPath.SetParameter(clsNewKeyParameter, 0)
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "Text Files|*.txt"
            dlgOpen.Title = "Import Text File"

            dlgOpen.InitialDirectory = If(ucrInputTokenPath.IsEmpty(),
                frmMain.clsInstatOptions.strWorkingDirectory,
                Path.GetDirectoryName(Replace(ucrInputTokenPath.GetText(), "/", "\")))

            If DialogResult.OK = dlgOpen.ShowDialog() Then
                If Not String.IsNullOrEmpty(dlgOpen.FileName) Then
                    Dim strFileName As String = Replace(dlgOpen.FileName, "\", "/")
                    strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                    'display the file path to the user
                    ucrInputTokenPath.SetName(strFileName)
                End If
            End If
        End Using
    End Sub

End Class