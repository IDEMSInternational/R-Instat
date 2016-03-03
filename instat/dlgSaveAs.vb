Imports System.IO
Imports instat.Translations
Public Class dlgSaveAs
    Dim dlgSave As New SaveFileDialog
    Dim bFirstLoad As Boolean = True

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
        ttScript.SetToolTip(chkScript, "You cannot save an empty script.")
        autoTranslate(Me)
        If bFirstLoad Then
            setDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdLogSave_Click(sender As Object, e As EventArgs) Handles cmdLogSave.Click
        dlgSave.Reset()
        dlgSave.Title = "Save Log File"
        dlgSave.Filter = "Text file (*.txt)|*.txt"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtLogSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
    End Sub

    Private Sub cmdOutputSave_Click(sender As Object, e As EventArgs) Handles cmdOutputSave.Click
        dlgSave.Reset()
        dlgSave.Title = "Save Output File"
        dlgSave.Filter = "Rich Text file (*.rtf)|*.rtf"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtOutputSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
    End Sub

    Private Sub TestOKEnabled()
        If txtEditorSave.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If chkLog.Checked And txtLogSave.Text <> "" Then
            saveTextFiles(txtLogSave.Text, frmLog.txtLog.Text)
        End If

        If chkScript.Checked Then
            saveTextFiles(txtScriptSave.Text, frmScript.txtScript.Text)
        End If

        If chkOutput.Checked And txtOutputSave.Text <> "" Then
            Try
                frmCommand.txtCommand.SaveFile(txtOutputSave.Text, RichTextBoxStreamType.RichText)
            Catch ex As Exception
            End Try
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

        TestOKEnabled()
    End Sub

    Private Sub txtEditorSave_TextChanged(sender As Object, e As EventArgs) Handles txtEditorSave.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub chkScript_CheckStateChanged(sender As Object, e As EventArgs) Handles chkScript.CheckStateChanged
        If frmScript.txtScript.Text <> "" Then
            If chkScript.Checked Then
                grpScript.Enabled = True
            Else
                grpScript.Enabled = False
            End If
        Else
            chkScript.Checked = False
            Exit Sub
        End If
    End Sub

    Private Sub cmdScriptSave_Click(sender As Object, e As EventArgs) Handles cmdScriptSave.Click
        dlgSave.Reset()
        dlgSave.Title = "Save Script File"
        dlgSave.Filter = "Text file (*.txt)|*.txt"
        If dlgSave.ShowDialog() = DialogResult.OK Then
            txtScriptSave.Text = dlgSave.FileName.Replace("\", "/")
        End If
    End Sub

    Private Sub saveTextFiles(strPath As String, strFile As String)
        Dim sWrite As New StreamWriter(strPath)
        Try
            sWrite.Write(strFile)
            sWrite.Flush()
            sWrite.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
    End Sub

    Private Sub setDefaults()
        txtEditorSave.Text = ""
        txtLogSave.Text = ""
        txtOutputSave.Text = ""
        txtScriptSave.Text = ""
        chkLog.Checked = False
        chkOutput.Checked = False
        chkScript.Checked = False

    End Sub
End Class
