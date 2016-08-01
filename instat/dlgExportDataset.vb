Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private clsWriteCSV, clsWriteXLSX, clsWriteTSV, clsWritePSV, clsWriteFEATHER, clsWriteFWF, clsWriteRDS, clsWriteRDATA, clsWriteJSON, clsWriteYML, clsWriteDTA, clsWriteSAV, clsWriteDBF, clsWriteARFF, clsWriteR, clsWriteXML, clsWriteHTML As New RFunction

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
        chkOptions.Enabled = False
        grpOptions.Enabled = False
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
                chkOptions.Enabled = True
                clsWriteXLSX.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteXLSX.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteXLSX)
            'TAB-separated data (.tsv), using write.table with row.names = FALSE.
            Case ".tsv"
                clsWriteTSV.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteTSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteTSV.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteTSV)
            'Pipe-separated data (.psv), using write.table with sep = '|' and row.names = FALSE.
            Case ".psv"
                clsWritePSV.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWritePSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWritePSV.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWritePSV)
            'Feather r / Python interchange format (.feather), using write_feather
            Case ".feather"
                clsWriteFEATHER.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteFEATHER.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteFEATHER.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteFEATHER)
            'Fixed-Width format data (.fwf), using write.table with row.names = FALSE, quote = FALSE, And col.names = FALSE
            Case ".fwf"
                clsWriteFWF.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteFWF.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteFWF.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteFWF)
            ' Serialized r objects (.rds), using saveRDS
            Case ".rds"
                clsWriteRDS.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteRDS.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteRDS.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteRDS)
            'Saved r objects (.RData), using save
            Case ".RData"
                clsWriteRDATA.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteRDATA.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteRDATA.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteRDATA)
            'JSON(.json), Using toJSON
            Case ".json"
                clsWriteJSON.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteJSON.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteJSON.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteJSON)
            'YAML(.yml), Using As.yaml
            Case ".yml"
                clsWriteYML.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteYML.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteYML.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteYML)
            ' Stata(.dta), Using write_dta
            Case ".dta"
                clsWriteDTA.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteDTA.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteDTA.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteDTA)
            'SPSS(.sav), Using write_sav
            Case ".sav"
                clsWriteSAV.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteSAV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteSAV.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteSAV)

            '"XBASE" database files (.dbf), using write.dbf
            Case ".dbf"
                clsWriteDBF.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteDBF.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteDBF.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteDBF)
            ' Weka Attribute - Relation File Format (.arff), using write.arff
            Case ".arff"
                clsWriteARFF.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteARFF.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteARFF.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteARFF)
            'r syntax object (.R), using dput (by default) Or dump (if format = 'dump'
            Case ".R"
                clsWriteR.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteR.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteR.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteR)
            'Xml(.xml), Using a custom method To create a simple XML tree
            Case ".xml"
                clsWriteXML.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteXML.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteXML.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteXML)
            ' HTML(.html), Using a custom method To create a Single-table HTML file
            Case ".html"
                clsWriteHTML.SetRCommand("rio::export")
                chkOptions.Enabled = True
                clsWriteHTML.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                clsWriteHTML.AddParameter("x", clsRFunctionParameter:=ucrAvailableSheets.clsCurrDataFrame)
                ucrBase.clsRsyntax.SetBaseRFunction(clsWriteHTML)
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