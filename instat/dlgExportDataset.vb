Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private clsWriteCSV, clsWriteXLSX, clsWriteOthers As New RFunction

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog
        dlgSave.Title = "Export file dialog"
        dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
        dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html"
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
        txtExportFile.Text = ""
        chkOptions.Checked = False
        ucrAvailableSheets.Reset()
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
        grpOptions.Visible = False
        chkOptions.Enabled = False
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
                clsWriteCSV.SetRCommand("rio::export")
                chkOptions.Enabled = False
                grpOptions.Enabled = False
                clsWriteCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteCSV.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteCSV)
            Case ".xlsx"
                clsWriteXLSX.SetRCommand("rio::export")
                'temp disabled
                'chkOptions.Enabled = True
                clsWriteXLSX.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteXLSX.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteXLSX)
            'TAB-separated data (.tsv), using write.table with row.names = FALSE.

            Case ".tsv", ".psv", ".feather", ".fwf", ".rds", ".RData", ".json", ".yml", ".dta", ".sav", ".dbf", ".arff", ".R", ".xml", ".html"
                clsWriteOthers.SetRCommand("rio::export")
                'temp disabled
                'chkOptions.Enabled = True
                clsWriteOthers.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteOthers.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteOthers)
        End Select
    End Sub

    Private Sub chkOptions_CheckStateChanged(sender As Object, e As EventArgs) Handles chkOptions.CheckStateChanged
        If chkOptions.Checked Then
            grpOptions.Enabled = True
        Else
            grpOptions.Enabled = False
        End If
    End Sub

    Private Sub txtAuthor_Leave(sender As Object, e As EventArgs) Handles txtAuthor.Leave
        If txtAuthor.Text <> "" Then
            clsWriteXLSX.AddParameter("creator", Chr(34) & txtAuthor.Text & Chr(34))
        End If
    End Sub

    Private Sub txtSheetName_Leave(sender As Object, e As EventArgs) Handles txtSheetName.Leave
        If txtSheetName.Text <> "" Then
            clsWriteXLSX.AddParameter("sheetName", Chr(34) & txtSheetName.Text & Chr(34))
        End If
    End Sub

    Private Sub txtRows_Leave(sender As Object, e As EventArgs) Handles txtRows.Leave
        If txtRows.Text <> "" Then
            clsWriteXLSX.AddParameter("startRow", txtRows.Text)
        End If
    End Sub

    Private Sub txtCols_Leave(sender As Object, e As EventArgs) Handles txtCols.Leave
        If txtRows.Text <> "" Then
            clsWriteXLSX.AddParameter("startCol", txtCols.Text)
        End If
    End Sub

    Private Sub chkRowNames_CheckStateChanged(sender As Object, e As EventArgs) Handles chkRowNames.CheckStateChanged, chkColNames.CheckStateChanged
        If chkRowNames.Checked Then
            ucrBase.clsRsyntax.AddParameter("rowNames", "TRUE")
        ElseIf chkColNames.Checked Then
            ucrBase.clsRsyntax.AddParameter("colNames", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("rowNames", "FALSE")
            ucrBase.clsRsyntax.AddParameter("colNames", "FALSE")
        End If
    End Sub
End Class