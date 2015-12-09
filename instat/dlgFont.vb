' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing
Imports instat.Translations
Public Class dlgFont
    Private Sub dlgFont_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dlgFont As System.Windows.Forms.FontDialog

        autoTranslate(Me)
        dlgFont = New System.Windows.Forms.FontDialog
        'setting font
        If dlgFont.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine(dlgFont.Font)
            Debug.WriteLine(dlgFont.Color)

        End If

    End Sub
End Class