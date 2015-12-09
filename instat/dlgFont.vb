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