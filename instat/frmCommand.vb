Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmCommand
    Private Sub frmCommand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

End Class