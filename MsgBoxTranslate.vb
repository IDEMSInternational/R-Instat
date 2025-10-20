Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Module MsgBoxTranslateModule

    ''' <summary>
    ''' Shows a message box after translating the text. Supports multi-line messages by translating each line separately.
    ''' Matches the common MsgBox usage with optional style and title parameters.
    ''' </summary>
    Public Sub MsgBoxTranslate(text As String, Optional style As MsgBoxStyle = MsgBoxStyle.OkOnly, Optional title As String = "")
        If text Is Nothing Then text = String.Empty

        ' Split on any of CRLF, CR or LF so we handle vbCrLf, vbCr, vbLf, Environment.NewLine, etc.
        ' Use Regex.Split so we don't lose empty lines.
        Dim lines() As String = Regex.Split(text, "\r\n|\r|\n")

        For i As Integer = 0 To lines.Length - 1
            Dim originalLine = lines(i)
            ' Do not discard empty lines; preserve them
            If Not String.IsNullOrEmpty(originalLine) Then
                Try
                    Dim translated = GetTranslationSafe(originalLine)
                    If Not String.IsNullOrEmpty(translated) Then
                        lines(i) = translated
                    Else
                        lines(i) = originalLine
                    End If
                Catch ex As Exception
                    ' Defensive: if translation lookup fails for any reason, keep the original line.
                    lines(i) = originalLine
                End Try
            Else
                lines(i) = originalLine
            End If
        Next

        Dim newText = String.Join(Environment.NewLine, lines)
        MsgBox(newText, style, title)
    End Sub

    ''' <summary>
    ''' Wrapper around the project's GetTranslation function.
    ''' Calls existing GetTranslation and falls back to original text on error.
    ''' </summary>
    Private Function GetTranslationSafe(ByVal text As String) As String
        If String.IsNullOrEmpty(text) Then
            Return text
        End If

        Try
            ' Call the project's existing GetTranslation function. If your translation API has a different name,
            ' replace this call accordingly.
            Return GetTranslation(text)
        Catch ex As Exception
            ' On any error, return the original text to avoid breaking the UI.
            Return text
        End Try
    End Function

End Module