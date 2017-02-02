Imports System.IO
Imports instat.Translations
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction, clsWriteCSV, clsWriteXLSX, clsWriteOthers As New RFunction

    Private Sub dlgExportDataset_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        grpOptions.Visible = False
        ucrChkOptions.Enabled = False
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSave As New SaveFileDialog
        dlgSave.Title = "Export file dialog"
        dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
        dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Excel files (*.xlsx)|*.xlsx|TAB-separated data (*.tsv)|*.tsv|Pipe-separated data (*.psv)|*.psv|Feather r / Python interchange format (*.feather)|*.feather|Fixed-Width format data (*.fwf)|*.fwf|Serialized r objects (*.rds)|*.rds|Saved r objects (*.RData)|*.RData|JSON(*.json)|*.json|YAML(*.yml)|*.yml|Stata(*.dta)|*.dta|SPSS(*.sav)|*.sav|XBASE database files (*.dbf)|*.dbf| Weka Attribute - Relation File Format (*.arff)|*.arff|r syntax object (*.R)|*.R|Xml(*.xml)|*.xml|HTML(*.html)|*.html"
        If dlgSave.ShowDialog = DialogResult.OK Then
            If dlgSave.FileName <> "" Then
                ucrInputExportFile.SetName(Path.GetFileName(dlgSave.FileName))
                SaveFileType(dlgSave.FileName.Replace("\", "/"))
            End If
        End If
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        cmdBrowse_Click(sender, e)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub SetDefaults()
        ucrAvailableSheets.Reset()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub InitialiseDialog()
        ucrChkOptions.SetText("Additional Options")
        ucrChkUseColumnNames.SetText("Use Column Names")
        ucrChkUseRowNames.SetText("Use Row Names")
        ucrInputExportFile.SetName("")
        ucrChkOptions.Checked = False

        ucrInputAuthor.SetParameter(New RParameter("creator", 0))
        ucrInputSheetName.SetParameter(New RParameter("sheetName", 1))
        ucrInputRows.SetParameter(New RParameter("startRow", 2))
        ucrInputCols.SetParameter(New RParameter("startCol", 3))
        ucrChkUseRowNames.SetParameter(New RParameter("rowNames", 4))
        ucrChkUseRowNames.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkUseColumnNames.SetParameter(New RParameter("colNames", 5))
        ucrChkUseColumnNames.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputExportFile.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SaveFileType(strFilePath As String)
        Select Case Path.GetExtension(strFilePath)
            Case ".csv"
                clsWriteCSV.SetRCommand("rio::export")
                ucrChkOptions.Enabled = False
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

    Private Sub chkOptions_CheckStateChanged(ucrchangedControl As ucrCore) Handles ucrChkOptions.ControlContentsChanged
        If ucrChkOptions.Checked Then
            grpOptions.Enabled = True
        Else
            grpOptions.Enabled = False
        End If
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputExportFile.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class