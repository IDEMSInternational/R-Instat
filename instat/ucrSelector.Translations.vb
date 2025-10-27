' Partial helpers for ucrSelector: non-invasive translation routine.
' Place this file in the same folder as ucrSelector.vb (instat/) so it compiles as the same partial class.

Imports System.Windows.Forms
Imports instat.Translations

Partial Public Class ucrSelector

    ''' <summary>
    ''' Translate a ToolStripItemCollection (and nested drop-down items) using
    ''' the translation fallback in Translations.vb (GetTranslationWithFallback).
    ''' This method does not handle events or designer properties to avoid duplicates.
    ''' </summary>
    Public Sub TranslateSelectionMenuItems(items As ToolStripItemCollection)
        If items Is Nothing Then Return
        For Each tsi As ToolStripItem In items
            If tsi Is Nothing Then Continue For
            If Not String.IsNullOrEmpty(tsi.Text) Then
                Dim newText As String = Translations.GetTranslationWithFallback(tsi.Text)
                If Not String.IsNullOrEmpty(newText) Then
                    tsi.Text = newText
                End If
            End If
            Dim mi = TryCast(tsi, ToolStripMenuItem)
            If mi IsNot Nothing AndAlso mi.HasDropDownItems Then
                TranslateSelectionMenuItems(mi.DropDownItems)
            End If
        Next
    End Sub

End Class