Imports System.IO
Imports System.Runtime.InteropServices

Public Class ucrTextViewer
    Inherits Panel

    Public ReadOnly _richTextBox As RichTextBox

    Public Sub New()
        _richTextBox = New RichTextBox
        _richTextBox.BorderStyle = BorderStyle.None
        Me.Controls.Add(_richTextBox)
        _richTextBox.Dock = DockStyle.Fill
        AddHandler _richTextBox.KeyUp, AddressOf richTextBox_CopySelectedText
    End Sub

    Public ReadOnly Property TextLength As Integer
        Get
            Return _richTextBox.Text.Length
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
        _richTextBox.AppendText(text)
        'by default always set the height of this control to correspond to the heigh of the rich text box contents
        'todo. what happens when the rich text box has multiple fonts?
        Me.Height = (_richTextBox.GetLineFromCharIndex(_richTextBox.Text.Length) + 1) * (_richTextBox.Font.Height + _richTextBox.Margin.Vertical) + 5
    End Sub

    Public Sub AddTextAndFormat(text As String, font As Font, color As Color)
        Dim intStartSelection As Integer = _richTextBox.Text.Length
        AddText(text)
        FormatText(font, color, intStartSelection, text.Length)
    End Sub

    Public Sub FormatText(font As Font, color As Color,
                          Optional iSelectionStart As Integer = 0,
                          Optional iSelectionLength As Integer = -1)

        If iSelectionLength = -1 Then
            iSelectionLength = _richTextBox.Text.Length
        End If

        If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
            'Mono cannot have multiple fonts and colours within RichTextBox
            _richTextBox.SelectAll()
            _richTextBox.Font = font
            _richTextBox.ForeColor = color
            _richTextBox.SelectionLength = 0
        Else
            _richTextBox.SelectionStart = iSelectionStart
            _richTextBox.SelectionLength = iSelectionLength
            _richTextBox.SelectionFont = font
            _richTextBox.SelectionColor = color
            _richTextBox.SelectionLength = 0
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