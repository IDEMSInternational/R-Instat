Imports System.Windows
Imports System.Windows.Input

Public Class ucrWPFRichTextBox
    Private Sub rtbOutput_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles rtbOutput.MouseDoubleClick
        Dim pos As Point = e.GetPosition(rtbOutput)
        Dim pointer As Documents.TextPointer = rtbOutput.GetPositionFromPoint(pos, False)
        If pointer IsNot Nothing Then
            For Each block As Documents.Block In rtbOutput.Document.Blocks
                rtbOutput.Selection.Select(block.ContentStart, block.ContentEnd)
                If Not rtbOutput.Selection.IsEmpty AndAlso rtbOutput.Selection.Contains(pointer) Then
                    Exit For
                Else
                    rtbOutput.Selection.Select(pointer, pointer)
                End If
            Next
        Else
            rtbOutput.Selection.Select(rtbOutput.Selection.End, rtbOutput.Selection.End)
        End If
    End Sub
End Class
