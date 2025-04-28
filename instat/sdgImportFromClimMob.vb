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

Public Class sdgImportFromClimMob
    Private Sub sdgImportFromClimMob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputKeyPath.IsReadOnly = False
        autoTranslate(Me)
    End Sub

    Public Sub Setup(clsNewKeyParameter As RParameter)
        ucrInputKeyPath.SetParameter(clsNewKeyParameter, 0)
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "Text Files|*.txt"
            dlgOpen.Title = "Import Text File"

            dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputKeyPath.GetText(), "/", "\"))

            If dlgOpen.ShowDialog() = DialogResult.OK AndAlso dlgOpen.FileName <> "" Then
                ucrInputKeyPath.SetName(Replace(dlgOpen.FileName, "\", "/"))
            End If
        End Using
    End Sub

End Class