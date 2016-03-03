Imports System.IO
Imports instat.Translations
Public Class dlgSaveAs
    Dim returnResults As KeyValuePair(Of String, String)
    Public Function SaveDialog(strFilter As String) As KeyValuePair(Of String, String)
        Dim dlgOpen As New SaveFileDialog
        Dim strFilePath, strFileName As String
        Select Case strFilter
            Case ".txt"
                dlgOpen.Filter = "Text file (*.txt)|*.txt"
            Case ".rtf"
                dlgOpen.Filter = "Rich Text file (*.rtf)|*.rtf"
            Case ".dataFile"
                dlgOpen.Filter = "Comma separated file (*.csv)|*.csv|RDS (*.RDS)|*.RDS"
        End Select
        dlgOpen.Title = "Save workbook"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                strFilePath = Replace(dlgOpen.FileName, "\", "/")
                Return New KeyValuePair(Of String, String)(strFileName, strFilePath)
            End If
        End If
        Return New KeyValuePair(Of String, String)("", "")
    End Function

    Public Sub setFilePath(strFilePath As String)
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
    End Sub

    Public Sub setFileExtension(strFileExtension As String)
        Select Case strFileExtension
            Case ".RDS"
                'set function
                setFunction("saveRDS")
                ucrBase.clsRsyntax.RemoveParameter("x")
                ucrBase.clsRsyntax.AddParameter("object", frmMain.clsRLink.strInstatDataObject)
            Case ".csv"
                'set function
                setFunction("write.csv")
                ucrBase.clsRsyntax.RemoveParameter("object")
                ucrBase.clsRsyntax.AddParameter("x", frmEditor.grdData.CurrentWorksheet.Name)
        End Select
    End Sub

    Public Sub setFunction(strRfunction As String)
        ucrBase.clsRsyntax.SetFunction(strRfunction)
    End Sub

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
        grpLog.Enabled = False
        grpOutput.Enabled = False
        grpScript.Enabled = False
        TestOKEnabled()
    End Sub

    Private Sub cmdLogSave_Click(sender As Object, e As EventArgs) Handles cmdLogSave.Click
        returnResults = SaveDialog(".txt")
        'Save the path
        txtLogSave.Text = returnResults.Value
    End Sub

    Private Sub cmdOutputSave_Click(sender As Object, e As EventArgs) Handles cmdOutputSave.Click
        returnResults = SaveDialog(".rtf")
        'Save path
        txtOutputSave.Text = returnResults.Value
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim sWriter As StreamWriter
        If chkLog.Checked Then
            Try
                sWriter = File.AppendText(txtLogSave.Text)
                sWriter.Write(frmLog.txtLog.Text)
                sWriter.Flush()
                sWriter.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        If chkScript.Checked Then
            Try
                sWriter = File.AppendText(txtScriptSave.Text)
                sWriter.Write(frmScript.txtScript.Text)
                sWriter.Flush()
                sWriter.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        If chkOutput.Checked = True Then
            Try
                frmCommand.txtCommand.SaveFile(txtOutputSave.Text, RichTextBoxStreamType.RichText)
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub txtEditorSave_TextChanged(sender As Object, e As EventArgs) Handles txtEditorSave.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdEditorSave_Click(sender As Object, e As EventArgs) Handles cmdEditorSave.Click
        returnResults = SaveDialog(".dataFile")
        'Save path
        txtEditorSave.Text = returnResults.Value
        'Pass the File extension
        setFileExtension(Path.GetExtension(returnResults.Value))
        setFilePath(returnResults.Value)
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

    Private Sub TestOKEnabled()
        If txtEditorSave.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdScriptSave_Click(sender As Object, e As EventArgs) Handles cmdScriptSave.Click
        returnResults = SaveDialog(".txt")
        'Save the path
        txtScriptSave.Text = returnResults.Value
    End Sub
End Class