Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        'ToAdd
    End Sub

    Private Sub txtExportFile_Click(sender As Object, e As EventArgs) Handles txtExportFile.Click
        cmdBrowse_Click(sender, e)
    End Sub

    Private Sub setDefaultValues()
        ucrAvailableSheets.Reset()
        txtExportFile.Text = ""
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaultValues()
    End Sub

    Private Sub dlgExportDataset_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            setDefaultValues()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If txtExportFile.Text <> "" AndAlso Directory.Exists(txtExportFile.Text) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub txtExportFile_TextChanged(sender As Object, e As EventArgs) Handles txtExportFile.TextChanged
        TestOkEnabled()
    End Sub
End Class