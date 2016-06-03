' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Imports System.IO
Imports RDotNet
Imports System.ComponentModel

Public Class dlgImportDataset

    Private intLines As Integer
    Private clsReadCSV, clsReadRDS, clsImportRDS, clsReadXLSX As RFunction
    Private clsTempWorkbookImport As RFunction
    Private clsTempExcelPreview As RFunction
    Private strTempWorkbookName As String
    Dim bFirstLoad As Boolean
    Public bFromLibrary As Boolean
    Dim strLibraryPath As String
    Dim strFileType As String
    Dim bCanImport As Boolean
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        intLines = 10
        clsReadCSV = New RFunction
        clsReadRDS = New RFunction
        clsImportRDS = New RFunction
        clsReadXLSX = New RFunction
        clsTempWorkbookImport = New RFunction
        clsTempExcelPreview = New RFunction
        bFirstLoad = True
        bFromLibrary = False
        strLibraryPath = frmMain.strStaticPath & "\Library"
        bCanImport = True
        bComponentsInitialised = True
        bStartOpenDialog = True
    End Sub

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        Me.Show()
        If bFirstLoad Then
            InitialiseDialog()
            SetCSVDefault()
            setExcelDefaults()
            SetRDSDefaults()
            bFirstLoad = False
        End If
        If bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        nudStartRow.Maximum = Integer.MaxValue
        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        ucrInputName.SetValidationTypeAsRVariable()
        clsTempWorkbookImport.SetRCommand("loadWorkbook")
        clsTempExcelPreview.SetRCommand("read.xlsx")
        strTempWorkbookName = "temp_workbook"
        'temporary until good validation can be done
        ucrInputColsToRead.Enabled = False
        ucrInputRowsToRead.Enabled = False
    End Sub

#Region "Shared options"
    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Private Sub ucrInputName_NameChanged() Handles ucrInputName.NameChanged
        If Not ucrInputName.IsEmpty AndAlso strFileType <> "RDS" Then
            ucrBase.clsRsyntax.SetAssignTo(ucrInputName.GetText(), strTempDataframe:=ucrInputName.GetText())
        End If
        TestOkEnabled()
    End Sub
#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetCSVDefault()
        RefreshFrameView()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputName.IsEmpty AndAlso bCanImport Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
#End Region

#Region "Import options"
    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Dim dlgOpen As New OpenFileDialog
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""

        If bFromLibrary Then
            dlgOpen.Title = "Import from library"
            dlgOpen.InitialDirectory = strLibraryPath
            dlgOpen.Filter = "All Data files (*.xlsx,*.RDS)|*.xlsx;*.RDS|RDS R-file (*.RDS)|*.RDS|Excel files (*.xlsx)|*.xlsx"
            bFromLibrary = False
        Else
            dlgOpen.Filter = "All Data files (*.csv,.xlsx,*.RDS)|*.csv;*.xlsx;*.RDS|Comma separated file (*.csv)|*.csv|RDS R-file (*.RDS)|*.RDS|Excel files (*.xlsx)|*.xlsx"
            dlgOpen.Title = "Open Data from file"
            dlgOpen.InitialDirectory = "c:\\"
        End If

        If dlgOpen.ShowDialog() = DialogResult.OK Then
            ucrInputName.SetName("")
            ucrInputName.Reset()
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strFileName = Path.GetFileNameWithoutExtension(dlgOpen.FileName)
                strFilePath = Replace(dlgOpen.FileName, "\", "/")
                strFileExt = Path.GetExtension(strFilePath)
                ucrInputFilePath.Name = strFilePath
                grdDataPreview.Show()
                txt.Show()
                Select Case strFileExt
                    Case ".RDS"
                        clsReadRDS.SetRCommand("readRDS")
                        clsReadRDS.SetAssignTo(strFileName)
                        clsReadRDS.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpExcel.Hide()
                        grpCSV.Hide()
                        grpRDS.Show()
                        txt.Text = ""
                        txt.Enabled = False
                        grdDataPreview.Enabled = False
                        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
                        clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
                        ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
                        strFileType = "RDS"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                    Case ".csv"
                        clsReadCSV.SetRCommand("read.csv")
                        ucrBase.clsRsyntax.SetBaseRFunction(clsReadCSV)
                        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                        grpRDS.Hide()
                        grpExcel.Hide()
                        grpCSV.Show()
                        txt.Enabled = True
                        grdDataPreview.Enabled = True
                        strFileType = "csv"
                        ucrInputName.SetName(strFileName, bSilent:=True)
                        RefreshFilePreview()
                        RefreshFrameView()
                    Case ".xlsx"
                        clsReadXLSX.SetRCommand("readWorkbook")
                        ucrBase.clsRsyntax.SetBaseRFunction(clsReadXLSX)
                        clsTempWorkbookImport.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
                        frmMain.clsRLink.RunInternalScript(clsTempWorkbookImport.ToScript(), strTempWorkbookName, bSilent:=True)
                        clsTempExcelPreview.AddParameter("xlsxFile", strTempWorkbookName)
                            ucrBase.clsRsyntax.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
                        grpCSV.Hide()
                        grpRDS.Hide()
                        grpExcel.Show()
                        txt.Text = ""
                        txt.Enabled = False
                        grdDataPreview.Enabled = True
                        strFileType = "xlsx"
                        FillExcelSheetsAndRegions(strFilePath)
                        RefreshFrameView()
                        'ucrInputName.SetName(strFileName, bSilent:=True)
                End Select
                ucrInputName.Focus()
            End If
        Else
            If ucrInputFilePath.Name = "" Then
                grpCSV.Hide()
                grpExcel.Hide()
                grpRDS.Hide()
                grdDataPreview.Hide()
                txt.Hide()
            End If
        End If
        TestOkEnabled()
    End Sub


#End Region

#Region "File Preview options"
    Public Sub RefreshFilePreview()
        Dim sReader As StreamReader
        Try
            sReader = New StreamReader(ucrInputFilePath.Name)
            txt.Text = ""
            For i = 1 To intLines + nudSkips.Value + 1
                txt.Text = txt.Text & sReader.ReadLine() & vbCrLf
                If sReader.Peek() = -1 Then
                    Exit For
                End If
            Next
        Catch ex As Exception
            txt.Text = "Cannot show text preview of file:" & ucrInputFilePath.Name & ". The file may be in use by another program. Close the file and select it again from the dialog to refresh the preview."
        End Try
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As CharacterMatrix
        Dim expTemp As SymbolicExpression
        Dim bToBeAssigned As Boolean
        Dim strTempDataFrameName As String
        Dim bValid As Boolean

        strTempDataFrameName = "temp"
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
        If strFileType <> "RDS" Then
            If strFileType = "xlsx" Then
                If chkColumnNames.Checked Then
                    clsTempExcelPreview.AddParameter("rows", nudStartRow.Value & ":" & nudStartRow.Value + intLines)
                Else
                    clsTempExcelPreview.AddParameter("rows", nudStartRow.Value & ":" & nudStartRow.Value + intLines - 1)
                End If
            ElseIf strFileType = "csv" Then
                clsReadCSV.AddParameter("nrows", intLines)
            End If
            lblCannotImport.Hide()
            If strFileType = "xlsx" Then
                bValid = frmMain.clsRLink.RunInternalScript(clsTempExcelPreview.ToScript(), strTempDataFrameName, bSilent:=True)
            Else
                bValid = frmMain.clsRLink.RunInternalScript(ucrBase.clsRsyntax.GetScript(), strTempDataFrameName, bSilent:=True)
            End If
            If bValid Then
                expTemp = frmMain.clsRLink.RunInternalScriptGetValue("convert_to_character_matrix(" & strTempDataFrameName & ")", bSilent:=True)
                dfTemp = Nothing
                If expTemp IsNot Nothing Then dfTemp = expTemp.AsCharacterMatrix
                If dfTemp Is Nothing Then
                    bValid = False
                Else
                    ucrBase.clsRsyntax.RemoveParameter("nrows")
                    clsTempExcelPreview.RemoveParameterByName("rows")
                    ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
                    frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=True)
                    grdDataPreview.Enabled = True
                    bCanImport = True
                End If
            End If
            If Not bValid Then
                grdDataPreview.CurrentWorksheet.Reset()
                grdDataPreview.Enabled = False
                lblCannotImport.Show()
                bCanImport = False
            End If
        Else
            bCanImport = True
            lblCannotImport.Hide()
            grdDataPreview.Enabled = False
        End If
        TestOkEnabled()
    End Sub
#End Region

#Region "RDS options"
    Private Sub SetRDSDefaults()
        chkExisting.Checked = True
        chkModel.Checked = True
        chkMetadata.Checked = True
        chkGraphics.Checked = True
        chkLogs.Checked = True
        chkOverWrite.Checked = False
    End Sub


    Private Sub chkExisting_CheckStateChanged(sender As Object, e As EventArgs) Handles chkExisting.CheckStateChanged
        If chkExisting.Checked Then
            clsImportRDS.AddParameter("keep_existing", "TRUE")
        Else
            clsImportRDS.AddParameter("keep_existing", "FALSE")
        End If
    End Sub

    Private Sub chkGraphics_CheckStateChanged(sender As Object, e As EventArgs) Handles chkGraphics.CheckStateChanged
        If chkGraphics.Checked Then
            clsImportRDS.AddParameter("include_graphics", "TRUE")
        Else
            clsImportRDS.RemoveParameterByName("include_graphics")
        End If
    End Sub

    Private Sub chkLogs_CheckStateChanged(sender As Object, e As EventArgs) Handles chkLogs.CheckStateChanged
        If chkLogs.Checked Then
            clsImportRDS.AddParameter("include_logs", "TRUE")
        Else
            clsImportRDS.RemoveParameterByName("include_logs")
        End If
    End Sub

    Private Sub chkOverWrite_CheckStateChanged(sender As Object, e As EventArgs) Handles chkOverWrite.CheckStateChanged
        If chkOverWrite.Checked Then
            clsImportRDS.AddParameter("overwrite_existing", "TRUE")
        Else
            clsImportRDS.RemoveParameterByName("overwrite_existing")
        End If
    End Sub

    Private Sub chkMetadata_CheckStateChanged(sender As Object, e As EventArgs) Handles chkMetadata.CheckStateChanged
        If chkMetadata.Checked Then
            clsImportRDS.AddParameter("include_metadata", "TRUE")
        Else
            clsImportRDS.AddParameter("include_metadata", "FALSE")
        End If
    End Sub

    Private Sub chkModel_CheckStateChanged(sender As Object, e As EventArgs) Handles chkModel.CheckStateChanged
        If chkModel.Checked Then
            clsImportRDS.AddParameter("include_models", "TRUE")
        Else
            clsImportRDS.AddParameter("include_models", "FALSE")
        End If
    End Sub

#End Region

#Region "CSV options"
    Private Sub SetCSVDefault()
        ucrInputEncoding.SetName("Automatic")
        rdoHeadingsYes.Checked = True
        ucrInputRowNames.SetName("Automatic")
        ucrInputSeparator.SetName("Comma")
        ucrInputDecimal.SetName("Period")
        ucrInputQuote.SetName("Double quote")
        ucrInputComment.SetName("None")
        SetNAStringsText("NA")
        ucrInputNAStrings.SetName("NA")
        nudSkips.Value = 0
    End Sub

    Private Sub SetNAStringsText(strTemp As String)
        If strTemp = "NA" Then
            clsReadCSV.AddParameter("na.strings", strTemp)
        Else
            clsReadCSV.AddParameter("na.strings", Chr(34) & strTemp & Chr(34))
        End If
        ucrInputNAStrings.Text = strTemp
    End Sub

    Private Sub ucrInputEncoding_TextChanged(sender As Object, e As EventArgs) Handles ucrInputEncoding.TextChanged

        If ucrInputEncoding.Name <> "Automatic" Then
            clsReadCSV.AddParameter("encoding", ucrInputEncoding.GetText)
        Else
            clsReadCSV.RemoveParameterByName("encoding")
        End If
        RefreshFrameView()

    End Sub

    Private Sub ucrInputRowNames_TextChanged(sender As Object, e As EventArgs) Handles ucrInputRowNames.TextChanged
        If ucrInputRowNames.cboInput.SelectedItem <> "Automatic" Then
            Select Case ucrInputRowNames.GetText
                Case "Use first column"
                    clsReadCSV.AddParameter("row.names", 1)
                Case "Use numbers"
                    clsReadCSV.AddParameter("row.names", "NULL")
            End Select
        Else
            clsReadCSV.RemoveParameterByName("row.names")
        End If
        RefreshFrameView()

    End Sub

    Private Sub ucrInputSeparator_TextChanged(sender As Object, e As EventArgs) Handles ucrInputSeparator.TextChanged
        Select Case ucrInputSeparator.GetText
            Case "Whitespace"
                clsReadCSV.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case "Comma"
                clsReadCSV.AddParameter("sep", Chr(34) & "," & Chr(34))
            Case "Semicolon"
                clsReadCSV.AddParameter("sep", Chr(34) & ";" & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputDecimal_TextChanged(sender As Object, e As EventArgs) Handles ucrInputDecimal.TextChanged
        Select Case ucrInputDecimal.GetText
            Case "Period"
                clsReadCSV.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                clsReadCSV.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputQuote_TextChanged(sender As Object, e As EventArgs) Handles ucrInputQuote.TextChanged
        If ucrInputQuote.cboInput.SelectedItem <> "None" Then
            Select Case ucrInputQuote.GetText
                Case "Double quote (" & Chr(34) & ")"
                    clsReadCSV.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))
                Case "Single quote (" & Chr(39) & ")"
                    clsReadCSV.AddParameter("quote", Chr(34) & "\" & Chr(39) & Chr(34))
            End Select
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrInputComment_TextChanged(sender As Object, e As EventArgs) Handles ucrInputComment.TextChanged
        CommentParameter()
    End Sub

    Private Sub CommentParameter()
        If ucrInputComment.cboInput.SelectedItem = "None" Then
            clsReadCSV.AddParameter("comment.char", Chr(34) & Chr(34))
        Else
            clsReadCSV.AddParameter("comment.char", Chr(34) & ucrInputComment.GetText & Chr(34))
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrInputNAStrings_TextChanged() Handles ucrInputNAStrings.NameChanged
        SetNAStringsText(ucrInputNAStrings.GetText())
        RefreshFrameView()
    End Sub

    Private Sub rdoHeadingsYesNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsYes.CheckedChanged, rdoHeadingsNo.CheckedChanged
        HeaderParameter()
    End Sub

    Private Sub HeaderParameter()
        If rdoHeadingsYes.Checked Then
            clsReadCSV.AddParameter("header", "TRUE")
        ElseIf rdoHeadingsNo.Checked Then
            clsReadCSV.AddParameter("header", "FALSE")
        Else
            clsReadCSV.RemoveParameterByName("header")
        End If
        RefreshFrameView()
    End Sub

    Private Sub nudSkips_TextChanged(sender As Object, e As EventArgs) Handles nudSkips.TextChanged
        SkipParameter()
    End Sub

    Private Sub SkipParameter()
        If bComponentsInitialised Then
            clsReadCSV.AddParameter("skip", nudSkips.Value)
            'TODO R gives an error if skip is too large
            RefreshFilePreview()
            RefreshFrameView()
        End If
    End Sub

    Private Sub cmdOpenDataSet_Click(sender As Object, e As EventArgs) Handles cmdOpenDataSet.Click
        GetFileFromOpenDialog()
    End Sub
#End Region


#Region "Excel options"

    Private Sub setExcelDefaults()
        nudStartRow.Value = 1
        chkColumnNames.Checked = True
        chkDates.Checked = True
        chkValidateColumnNames.Checked = True
        chkSkipEmptyRows.Checked = True
    End Sub

    Private Sub FillExcelSheetsAndRegions(strFilePath As String)
        Dim i As Integer
        Dim chrSheets As CharacterVector
        Dim chrRegions As CharacterVector
        Dim clsGetSheetNames As New RFunction
        Dim clsGetNamedRegions As New RFunction

        clsGetSheetNames.SetRCommand("names")
        clsGetSheetNames.AddParameter("x", strTempWorkbookName)
        ' temporary solutions until issue with getNamedRegions is resolved
        ' https://github.com/awalker89/openxlsx/issues/174
        'clsGetNamedRegions.SetRCommand("getNamedRegions")
        clsGetNamedRegions.SetRCommand("regmatches")
        'clsGetNamedRegions.AddParameter("xlsxFile", strTempWorkbookName)
        clsGetNamedRegions.AddParameter("x", strTempWorkbookName & "$workbook$definedNames")
        clsGetNamedRegions.AddParameter("m", "regexpr('(?<=name=" & Chr(34) & ")[^" & Chr(34) & "]+', " & strTempWorkbookName & "$workbook$definedNames" & ", perl = TRUE)")
        chrSheets = frmMain.clsRLink.RunInternalScriptGetValue(clsGetSheetNames.ToScript()).AsCharacter
        chrRegions = frmMain.clsRLink.RunInternalScriptGetValue(clsGetNamedRegions.ToScript()).AsCharacter

        ucrInputSheets.cboInput.Items.Clear()
        If chrSheets IsNot Nothing AndAlso chrSheets.Count > 0 Then
            For i = 0 To chrSheets.Count - 1
                ucrInputSheets.cboInput.Items.Add(chrSheets(i))
            Next
            ucrInputSheets.SetName(ucrInputSheets.cboInput.Items(0), bSilent:=True)
        Else
            ucrInputSheets.SetName("")
        End If

        ucrInputNamedRegions.cboInput.Items.Clear()
        If chrRegions IsNot Nothing AndAlso chrRegions.Count > 0 Then
            For i = 0 To chrRegions.Count - 1
                ucrInputNamedRegions.cboInput.Items.Add(chrRegions(i))
            Next
        End If
        ucrInputNamedRegions.SetName("")
    End Sub

    Private Sub nudStartRow_TextChanged(sender As Object, e As EventArgs) Handles nudStartRow.TextChanged
        startRow()
    End Sub

    Private Sub startRow()
        If bComponentsInitialised Then
            If nudStartRow.Value <> "" Then
                If nudStartRow.Value = 1 AndAlso Not frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsReadXLSX.RemoveParameterByName("startRow")
                    clsTempExcelPreview.RemoveParameterByName("startRow")
                Else
                    clsReadXLSX.AddParameter("startRow", nudStartRow.Value)
                    clsTempExcelPreview.AddParameter("startRow", nudStartRow.Value)
                End If
            Else
                clsReadXLSX.RemoveParameterByName("startRow")
                clsTempExcelPreview.RemoveParameterByName("startRow")
            End If
            RefreshFrameView()
        End If
    End Sub

    Private Sub chkColumnNames_CheckedChanged(sender As Object, e As EventArgs) Handles chkColumnNames.CheckedChanged
        Colnames()
    End Sub

    Private Sub Colnames()
        If chkColumnNames.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("colNames", "TRUE")
                clsTempExcelPreview.AddParameter("colNames", "TRUE")
            Else
                clsReadXLSX.RemoveParameterByName("colNames")
                clsTempExcelPreview.RemoveParameterByName("colNames")
            End If
        Else
            clsReadXLSX.AddParameter("colNames", "FALSE")
            clsTempExcelPreview.AddParameter("colNames", "FALSE")
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkDates_CheckedChanged(sender As Object, e As EventArgs) Handles chkDates.CheckedChanged
        detectDates()
    End Sub

    Private Sub detectDates()
        If chkDates.Checked Then
            clsReadXLSX.AddParameter("detectDates", "TRUE")
            clsTempExcelPreview.AddParameter("detectDates", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("detectDates", "FALSE")
                clsTempExcelPreview.AddParameter("detectDates", "FALSE")
            Else
                clsReadXLSX.RemoveParameterByName("detectDates")
                clsTempExcelPreview.RemoveParameterByName("detectDates")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkNames_CheckedChanged(sender As Object, e As EventArgs) Handles chkValidateColumnNames.CheckedChanged
        checkNames()
    End Sub

    Private Sub checkNames()
        If chkValidateColumnNames.Checked Then
            clsReadXLSX.AddParameter("check.names", "TRUE")
            clsTempExcelPreview.AddParameter("check.names", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("check.names", "FALSE")
                clsTempExcelPreview.AddParameter("check.names", "FALSE")
            Else
                clsReadXLSX.RemoveParameterByName("check.names")
                clsTempExcelPreview.RemoveParameterByName("check.names")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkSkipEmptyRows_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkipEmptyRows.CheckedChanged
        skipEmptyRows()
    End Sub

    Private Sub skipEmptyRows()
        If chkSkipEmptyRows.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("skipEmptyRows", "TRUE")
                clsTempExcelPreview.AddParameter("skipEmptyRows", "TRUE")
            Else
                clsReadXLSX.RemoveParameterByName("skipEmptyRows")
                clsTempExcelPreview.RemoveParameterByName("skipEmptyRows")
            End If
        Else
            clsReadXLSX.AddParameter("skipEmptyRows", "FALSE")
            clsTempExcelPreview.AddParameter("skipEmptyRows", "FALSE")
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkRowNames_CheckedChanged(sender As Object, e As EventArgs) Handles chkRowNames.CheckedChanged
        rowNames()
    End Sub

    Private Sub rowNames()
        If chkRowNames.Checked Then
            clsReadXLSX.AddParameter("rowNames", "TRUE")
            clsTempExcelPreview.AddParameter("rowNames", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("rowNames", "FALSE")
                clsTempExcelPreview.AddParameter("rowNames", "FALSE")
            Else
                clsReadXLSX.RemoveParameterByName("rowNames")
                clsTempExcelPreview.RemoveParameterByName("rowNames")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub lblRowVector_Click(sender As Object, e As EventArgs) Handles lblRowsToRead.Click
        Me.Hide()
        frmMetaData.Show()
    End Sub

    Private Sub ucrInputSheets_NameChanged() Handles ucrInputSheets.NameChanged
        If Not ucrInputSheets.IsEmpty() Then
            clsReadXLSX.AddParameter("sheet", Chr(34) & ucrInputSheets.GetText() & Chr(34))
            clsTempExcelPreview.AddParameter("sheet", Chr(34) & ucrInputSheets.GetText() & Chr(34))
            ucrInputNamedRegions.SetName("")
            If Not ucrInputName.UserTyped() Then
                ucrInputName.SetName(ucrInputSheets.GetText(), bSilent:=True)
                ucrInputName.Focus()
            End If
        Else
            clsReadXLSX.RemoveParameterByName("sheet")
            clsTempExcelPreview.RemoveParameterByName("sheet")
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrInputNamedRegions_NameChanged() Handles ucrInputNamedRegions.NameChanged
        If Not ucrInputNamedRegions.IsEmpty() Then
            clsReadXLSX.AddParameter("namedRegion", Chr(34) & ucrInputNamedRegions.GetText() & Chr(34))
            clsTempExcelPreview.AddParameter("namedRegion", Chr(34) & ucrInputNamedRegions.GetText() & Chr(34))
            ucrInputSheets.SetName("")
            nudStartRow.Value = 1
            nudStartRow.Enabled = False
            If Not ucrInputName.UserTyped() Then
                ucrInputName.SetName(ucrInputNamedRegions.GetText(), bSilent:=True)
                ucrInputName.Focus()
            End If
        Else
            clsReadXLSX.RemoveParameterByName("namedRegion")
            clsTempExcelPreview.RemoveParameterByName("namedRegion")
            nudStartRow.Enabled = True
        End If
        RefreshFrameView()
    End Sub

#End Region
End Class