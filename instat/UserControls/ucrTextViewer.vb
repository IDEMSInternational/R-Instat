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
''' Control for viewing text output content
''' </summary>
'''--------------------------------------------------------------------------------------------
Public Class ucrTextViewer
    Inherits Panel

    Public ReadOnly richTextBox As RichTextBox

    Public Sub New()
        richTextBox = New RichTextBox
        richTextBox.BorderStyle = BorderStyle.None
        Me.Controls.Add(richTextBox)
        richTextBox.Dock = DockStyle.Fill
        AddHandler richTextBox.KeyUp, AddressOf richTextBox_CopySelectedText
    End Sub

    Public ReadOnly Property TextLength As Integer
        Get
            Return richTextBox.Text.Length
        End Get
    End Property

    Public Sub LoadTextFile(strFileName As String)
        Dim strOutput As String = ""
        For Each strLine As String In File.ReadLines(strFileName)
            strOutput = strOutput & strLine & Environment.NewLine
        Next strLine
        AddText(strOutput)
    End Sub

    Public Sub AddText(text As String)
        richTextBox.AppendText(text)
        'by default always set the height of this control to correspond to the height of the rich text box contents
        'todo. what happens when the rich text box has multiple fonts?
        Me.Height = (richTextBox.GetLineFromCharIndex(richTextBox.Text.Length) + 1) * (richTextBox.Font.Height + richTextBox.Margin.Vertical) + 5
    End Sub

    Public Sub AddTextAndFormat(text As String, font As Font, color As Color)
        Dim intStartSelection As Integer = richTextBox.Text.Length
        AddText(text)
        FormatText(font, color, intStartSelection, text.Length)
    End Sub

    Public Sub FormatText(font As Font, color As Color,
                          Optional iSelectionStart As Integer = 0,
                          Optional iSelectionLength As Integer = -1)

        If iSelectionLength = -1 Then
            iSelectionLength = richTextBox.Text.Length
        End If

        If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
            'Mono cannot have multiple fonts and colours within RichTextBox
            richTextBox.SelectAll()
            richTextBox.Font = font
            richTextBox.ForeColor = color
            richTextBox.SelectionLength = 0
        Else
            richTextBox.SelectionStart = iSelectionStart
            richTextBox.SelectionLength = iSelectionLength
            richTextBox.SelectionFont = font
            richTextBox.SelectionColor = color
            richTextBox.SelectionLength = 0
        End If
    End Sub

    Private Sub richTextBox_CopySelectedText(sender As Object, e As KeyEventArgs)
        If e.KeyData = Keys.Control + Keys.C Then
            Try
                Dim richText As RichTextBox = CType(sender, RichTextBox)
                Dim richSelectedText As New RichTextBox
                richSelectedText.AppendText(richText.SelectedText)
                CopySelectedTextToClipBoard(richSelectedText, richText.SelectedRtf)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CopySelectedTextToClipBoard(richText As RichTextBox, richTextFormat As String)
        Dim strClip As String = String.Empty
        Dim dto As New DataObject()

        For Each Line As String In richText.Lines
            strClip &= Line & Environment.NewLine
        Next

        dto.SetText(richTextFormat, TextDataFormat.Rtf)
        dto.SetText(strClip, TextDataFormat.UnicodeText)
        Clipboard.Clear()
        Clipboard.SetDataObject(dto)
    End Sub

End Class