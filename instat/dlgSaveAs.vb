Imports System.IO
Imports instat.Translations
Public Class dlgSaveAs
    Dim dlgSave As New SaveFileDialog

    Private Sub chkLog_CheckedChanged(sender As Object, e As EventArgs) Handles chkLog.CheckedChanged
        If chkLog.Checked = True Then
            grpLog.Enabled = True
        Else
            grpLog.Enabled = False
        End If
    End Sub

    Private Sub chkOutput_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutput.CheckedChanged
        If chkOutput.Checked = True Then
            grpOutput.Enabled = True
        Else
            grpOutput.Enabled = False
        End If
    End Sub

    Private Sub dlgSaveAs_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        ucrBase.OKEnabled(False)
        grpLog.Enabled = False
        grpOutput.Enabled = False
    End Sub

    Private Sub cmdLogSave_Click(sender As Object, e As EventArgs) Handles cmdLogSave.Click
        dlgSave.Title = "Save Log File"
        dlgSave.Filter = "Text file (*.txt)|*.txt"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtLogSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
    End Sub

    Private Sub cmdOutputSave_Click(sender As Object, e As EventArgs) Handles cmdOutputSave.Click
        dlgSave.Title = "Save Output File"
        dlgSave.Filter = "Rich Text file (*.rtf)|*.rtf"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtOutputSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If chkLog.Checked = True And txtLogSave.Text <> "" Then
            Try
                Dim sWriter As New StreamWriter(txtOutputSave.Text)
                sWriter.Write(frmLog.txtLog.Text)
                sWriter.Flush()
            Catch ex As Exception
            End Try
        End If
        If chkOutput.Checked = True And txtOutputSave.Text <> "" Then
            Try
                frmCommand.txtCommand.SaveFile(txtOutputSave.Text, RichTextBoxStreamType.RichText)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub txtEditorSave_TextChanged(sender As Object, e As EventArgs) Handles txtEditorSave.Click
        If txtEditorSave.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdEditorSave_Click(sender As Object, e As EventArgs) Handles cmdEditorSave.Click
        dlgSave.Title = "Save Data File"
        dlgSave.Filter = "RDS Data file (*.RDS)|*.RDS"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            'Save path
            txtEditorSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
        'Pass the function
        ucrBase.clsRsyntax.SetFunction("saveRDS")
        'Pass the object
        ucrBase.clsRsyntax.AddParameter("object", frmMain.clsRLink.strInstatDataObject)
        'Pass the file
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & txtEditorSave.Text & Chr(34))
    End Sub
End Class
