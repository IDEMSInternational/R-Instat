Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog
        dlgSave.Title = "Export file dialog"
        dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Excel files (*xlsx)|*.xlsx"
        If dlgSave.ShowDialog = DialogResult.OK Then
            If dlgSave.FileName <> "" Then
                txtExportFile.Text = Path.GetFileName(dlgSave.FileName)
                SaveFileType(dlgSave.FileName.Replace("\", "/"))
            End If
        End If
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
        If txtExportFile.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub txtExportFile_TextChanged(sender As Object, e As EventArgs) Handles txtExportFile.TextChanged
        TestOkEnabled()
    End Sub

    Private Sub SaveFileType(strFilePath As String)
        Select Case Path.GetExtension(strFilePath)
            Case ".csv"
                ucrBase.clsRsyntax.SetFunction("write.csv")

                'ToDo
            Case ".xlsx"
                ucrBase.clsRsyntax.SetFunction("write.xlsx")
                'ToDo
        End Select
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
        ucrBase.clsRsyntax.AddParameter("x", ucrAvailableSheets.cboAvailableDataFrames.SelectedItem)
    End Sub
End Class