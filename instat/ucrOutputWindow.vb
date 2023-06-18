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

Imports System.ComponentModel
Imports instat.Translations

Public Class ucrOutputWindow

    Public Sub SetLogger(outputLogger As clsOutputLogger)
        UcrOutputPages.SetLogger(outputLogger)
    End Sub

    Public Sub SetInstatOptions(clsInstatOptions As InstatOptions)
        UcrOutputPages.clsInstatOptions = clsInstatOptions
    End Sub

    Private Sub ucrOutputWindow_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        'for some reason the normal KeyDown event is not raised when del key is pressed
        'probably because the del is not recognised as an inputkey to ucrRichTextBox 
        '  AddHandler ucrRichTextBox.PreviewKeyDown, AddressOf ucrRichTextBox_KeyDownEventHandler
    End Sub

End Class
