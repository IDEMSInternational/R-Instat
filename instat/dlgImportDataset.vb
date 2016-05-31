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

Public Class dlgImportDataset

    Private intLines As Integer = 10
    Private clsReadCSV, clsReadRDS, clsImportRDS, clsReadXLSX As New RFunction
    Dim bFirstLoad As Boolean = True
    Public bFromLibrary As Boolean = False
    Dim strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"
    Dim strFileType As String

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetCSVDefault()
            setExcelDefaults()
            SetRDSDefaults()
            bFirstLoad = False
        End If

        autoTranslate(Me)

        'shows the dialog first then the open dialog
        Me.Show()

        GetFileFromOpenDialog()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        nudStartRow.Maximum = Integer.MaxValue
        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        ucrInputName.SetValidationTypeAsRVariable()
    End Sub

#Region "Shared options"
    'Public Sub SetDataName()
    '    Dim strName As String
    '    strName = ucrInputName.GetText()
    '    Select Case strFileType
    '        Case "RDS"
    '            ucrInputName.SetName(strName, bSilent:=True)
    '        Case "xlsx"
    '            'clsReadXLSX.SetAssignTo(strName, strName)
    '        Case "csv"
    '            clsReadCSV.SetAssignTo(strName, strName)
    '            ucrInputName.SetName(strName, bSilent:=True)
    '    End Select
    '    TestOkEnabled()
    'End Sub

    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Public Sub SetFilePath(strFilePath As String, strRparameter As String)
        txtFilePath.Text = strFilePath

        If Path.GetExtension(strFilePath) = ".csv" Then
            txtInputFile.Show()
            RefreshFilePreview()
            strFileType = "csv"
            RefreshFrameView()
        ElseIf Path.GetExtension(strFilePath) = ".xlsx" Then
            'txtInputFile.Text = "Cannot access file contents"
            txtInputFile.Hide()
            FillExcelSheetsAndRegions(strFilePath)
            strFileType = "xlsx"
            RefreshFrameView()
        ElseIf Path.GetExtension(strFilePath).ToLower() = ".rds" Then
            txtInputFile.Hide()
            strFileType = "RDS"
        End If

    End Sub
#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetCSVDefault()
        RefreshFrameView()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrInputName.IsEmpty Then
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
                'TODO where should this go?
                If Not frmMain.clsRLink.bInstatObjectExists Then
                    frmMain.clsRLink.CreateNewInstatObject()
                End If
            End If
        Else
            grpCSV.Hide()
            grpExcel.Hide()
            grpRDS.Hide()
            grdDataPreview.Hide()
            txtInputFile.Hide()
        End If

        Select Case strFileExt
            Case ".RDS"
                clsReadRDS.SetRCommand("readRDS")
                clsReadRDS.SetAssignTo(strFileName)
                clsReadRDS.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                grpExcel.Hide()
                grpCSV.Hide()
                grpRDS.Show()
                txtInputFile.Text = ""
                txtInputFile.Enabled = False
                grdDataPreview.Hide()
                clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
                clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
                'txtFilePath.Text = strFilePath
                SetFilePath(strFilePath, "file")
                ucrInputName.SetName(strFileName, bSilent:=True)
            Case ".csv"
                clsReadCSV.SetRCommand("read.csv")
                ucrBase.clsRsyntax.SetBaseRFunction(clsReadCSV)
                ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                grpRDS.Hide()
                grpExcel.Hide()
                grpCSV.Show()
                txtInputFile.Enabled = True
                grdDataPreview.Show()
                SetFilePath(strFilePath, "file")
                ucrInputName.SetName(strFileName, bSilent:=True)
            Case ".xlsx"
                clsReadXLSX.SetRCommand("readWorkbook")
                ucrBase.clsRsyntax.SetBaseRFunction(clsReadXLSX)
                ucrBase.clsRsyntax.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
                grpCSV.Hide()
                grpRDS.Hide()
                grpExcel.Show()
                txtInputFile.Text = ""
                txtInputFile.Enabled = False
                grdDataPreview.Show()
                SetFilePath(strFilePath, "xlsx")
                'ucrInputName.SetName(strFileName, bSilent:=True)
        End Select
        ucrInputName.Focus()
    End Sub


#End Region

#Region "File Preview options"
    Public Sub RefreshFilePreview()
        Dim sReader As StreamReader
        Try
            sReader = New StreamReader(txtFilePath.Text)
            txtInputFile.Text = ""
            For i = 1 To intLines + nudSkips.Value + 1
                txtInputFile.Text = txtInputFile.Text & sReader.ReadLine() & vbCrLf
                If sReader.Peek() = -1 Then
                    Exit For
                End If
            Next
        Catch ex As Exception
            txtInputFile.Text = "Cannot show text preview of file:" & txtFilePath.Text & ". The file may be in use by another program. Close the file and select it again from the dialog to refresh the preview."
        End Try
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As CharacterMatrix
        Dim bToBeAssigned As Boolean
        Dim strTempDataFrameName As String

        strTempDataFrameName = "temp"
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        Try
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            If strFileType = "xlsx" Then
                ucrBase.clsRsyntax.AddParameter("rows", "1:" & intLines)
            ElseIf strFileType = "csv" Then
                clsReadCSV.AddParameter("nrows", intLines)
            End If
            frmMain.clsRLink.RunInternalScript(ucrBase.clsRsyntax.GetScript(), strTempDataFrameName)
            dfTemp = frmMain.clsRLink.RunInternalScriptGetValue("convert_to_character_matrix(" & strTempDataFrameName & ")").AsCharacterMatrix
            ucrBase.clsRsyntax.RemoveParameter("nrows")
            ucrBase.clsRsyntax.RemoveParameter("rows")
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
            frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=True)
            lblNoPreviewDataFrame.Hide()
        Catch
            grdDataPreview.CurrentWorksheet.Reset()
            lblNoPreviewDataFrame.Show()
        End Try
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
        cboEncoding.Text = "Automatic"
        rdoHeadingsYes.Checked = True
        cboRowNames.Text = "Automatic"
        cboSeparator.SelectedIndex = cboSeparator.Items.IndexOf("Comma")
        cboDecimal.SelectedIndex = cboDecimal.Items.IndexOf("Period")
        cboQuote.SelectedIndex = cboQuote.Items.IndexOf("Double quote")
        cboComment.SelectedIndex = cboComment.Items.IndexOf("None")
        SetNAStringsText("NA")
        nudSkips.Value = 0
    End Sub

    Private Sub SetNAStringsText(strTemp As String)
        If strTemp = "NA" Then
            clsReadCSV.AddParameter("na.strings", strTemp)
        Else
            clsReadCSV.AddParameter("na.strings", Chr(34) & strTemp & Chr(34))
        End If
        txtNAStrings.Text = strTemp
    End Sub

    Private Sub cboEncoding_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboEncoding.SelectedIndexChanged

        If cboEncoding.Text <> "Automatic" Then
            clsReadCSV.AddParameter("encoding", cboEncoding.Text)
        Else
            clsReadCSV.RemoveParameterByName("encoding")
        End If
        RefreshFrameView()

    End Sub

    Private Sub cboRowNames_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboRowNames.SelectedIndexChanged

        If cboRowNames.Text <> "Automatic" Then
            Select Case cboRowNames.Text
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

    Private Sub cboSeparator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSeparator.SelectedIndexChanged
        Select Case cboSeparator.SelectedItem
            Case "Whitespace"
                clsReadCSV.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case "Comma"
                clsReadCSV.AddParameter("sep", Chr(34) & "," & Chr(34))
            Case "Semicolon"
                clsReadCSV.AddParameter("sep", Chr(34) & ";" & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub cboDecimal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDecimal.SelectedIndexChanged
        Select Case cboDecimal.Text
            Case "Period"
                clsReadCSV.AddParameter("dec", Chr(34) & "." & Chr(34))
            Case "Comma"
                clsReadCSV.AddParameter("dec", Chr(34) & "," & Chr(34))
        End Select
        RefreshFrameView()
    End Sub

    Private Sub cboQuote_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboQuote.SelectedIndexChanged
        If cboQuote.Text <> "None" Then
            Select Case cboQuote.Text
                Case "Double quote (" & Chr(34) & ")"
                    clsReadCSV.AddParameter("quote", Chr(34) & "\" & Chr(34) & Chr(34))
                Case "Single quote (" & Chr(39) & ")"
                    clsReadCSV.AddParameter("quote", Chr(34) & "\" & Chr(39) & Chr(34))
            End Select
        End If
        RefreshFrameView()
    End Sub

    Private Sub cboComment_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboComment.SelectedIndexChanged
        If cboComment.Text = "None" Then
            clsReadCSV.AddParameter("comment.char", Chr(34) & Chr(34))
        Else
            clsReadCSV.AddParameter("comment.char", Chr(34) & cboComment.Text & Chr(34))
        End If
        RefreshFrameView()
    End Sub

    Private Sub txtNAStrings_TextChanged(sender As Object, e As EventArgs) Handles txtNAStrings.Leave
        SetNAStringsText(txtNAStrings.Text)
        RefreshFrameView()
    End Sub

    Private Sub rdoHeadingsYesNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHeadingsYes.CheckedChanged, rdoHeadingsNo.CheckedChanged

        If rdoHeadingsYes.Checked Then
            clsReadCSV.AddParameter("header", "TRUE")
        ElseIf rdoHeadingsNo.Checked Then
            clsReadCSV.AddParameter("header", "FALSE")
        Else
            clsReadCSV.RemoveParameterByName("header")
        End If
        RefreshFrameView()
    End Sub


    Private Sub nudSkips_ValueChanged(sender As Object, e As EventArgs) Handles nudSkips.ValueChanged
        clsReadCSV.AddParameter("skip", nudSkips.Value)
        'TODO R gives an error if skip is too large
        RefreshFilePreview()
        RefreshFrameView()
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
        txtRows.Text = "NULL"
        txtCols.Text = "NULL"
    End Sub

    Private Sub FillExcelSheetsAndRegions(strFilePath As String)
        Dim i As Integer
        Dim chrSheets As CharacterVector
        Dim chrRegions As CharacterVector
        Dim clsGetSheetNames As New RFunction
        Dim clsGetNamedRegions As New RFunction

        clsGetSheetNames.SetRCommand("getSheetNames")
        clsGetSheetNames.AddParameter("file", Chr(34) & strFilePath & Chr(34))
        clsGetNamedRegions.SetRCommand("getNamedRegions")
        clsGetNamedRegions.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
        chrSheets = frmMain.clsRLink.RunInternalScriptGetValue(clsGetSheetNames.ToScript()).AsCharacter
        chrRegions = frmMain.clsRLink.RunInternalScriptGetValue(clsGetNamedRegions.ToScript()).AsCharacter

        ucrInputSheets.cboInput.Items.Clear()
        For i = 0 To chrSheets.Count - 1
            ucrInputSheets.cboInput.Items.Add(chrSheets(i))
        Next
        If chrSheets.Count > 0 Then
            ucrInputSheets.SetName(ucrInputSheets.cboInput.Items(0), bSilent:=True)
        Else
            ucrInputSheets.SetName("")
        End If

        ucrInputNamedRegions.cboInput.Items.Clear()
        If chrRegions.Count > 0 Then
            For i = 0 To chrRegions.Count - 1
                ucrInputNamedRegions.cboInput.Items.Add(chrRegions(i))
            Next
        End If
        ucrInputNamedRegions.SetName("")
        RefreshFrameView()
    End Sub

    Private Sub nudStartRow_TextChanged(sender As Object, e As EventArgs) Handles nudStartRow.TextChanged
        If nudStartRow.Text <> "" Then
            If nudStartRow.Value = 1 AndAlso Not frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.RemoveParameterByName("startRow")
            Else
                clsReadXLSX.AddParameter("startRow", nudStartRow.Value)
            End If
        Else
            clsReadXLSX.RemoveParameterByName("startRow")
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkColumnNames_CheckedChanged(sender As Object, e As EventArgs) Handles chkColumnNames.CheckedChanged
        If chkColumnNames.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("colNames", "TRUE")
            Else
                clsReadXLSX.RemoveParameterByName("colNames")
            End If
        Else
            clsReadXLSX.AddParameter("colNames", "FALSE")
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkDates_CheckedChanged(sender As Object, e As EventArgs) Handles chkDates.CheckedChanged
        If chkDates.Checked Then
            clsReadXLSX.AddParameter("detectDates", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("detectDates", "FALSE")
            Else
                clsReadXLSX.RemoveParameterByName("detectDates")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkNames_CheckedChanged(sender As Object, e As EventArgs) Handles chkValidateColumnNames.CheckedChanged
        If chkValidateColumnNames.Checked Then
            clsReadXLSX.AddParameter("check.names", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("check.names", "FALSE")
            Else
                clsReadXLSX.RemoveParameterByName("check.names")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub chkSkipEmptyRows_CheckedChanged(sender As Object, e As EventArgs) Handles chkSkipEmptyRows.CheckedChanged
        If chkSkipEmptyRows.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXLSX.AddParameter("skipEmptyRows", "TRUE")
            Else
                clsReadXLSX.RemoveParameterByName("skipEmptyRows")
            End If
        Else
            clsReadXLSX.AddParameter("skipEmptyRows", "FALSE")
        End If
        RefreshFrameView()
    End Sub

    Private Sub txtCols_Leave(sender As Object, e As EventArgs) Handles txtCols.Leave
        If txtCols.Text <> "NULL" Then
            clsReadXLSX.AddParameter("cols", txtCols.Text)
        End If
    End Sub

    Private Sub txtRows_Leave(sender As Object, e As EventArgs) Handles txtRows.Leave
        If txtRows.Text <> "NULL" Then
            clsReadXLSX.AddParameter("rows", txtRows.Text)
        End If
    End Sub

    Private Sub ucrInputName_NameChanged() Handles ucrInputName.NameChanged
        If Not ucrInputName.IsEmpty AndAlso strFileType <> "RDS" Then
            ucrBase.clsRsyntax.SetAssignTo(ucrInputName.GetText(), strTempDataframe:=ucrInputName.GetText())
        End If
    End Sub

    Private Sub ucrInputSheets_NameChanged() Handles ucrInputSheets.NameChanged
        If Not ucrInputSheets.IsEmpty() Then
            clsReadXLSX.AddParameter("sheet", Chr(34) & ucrInputSheets.GetText() & Chr(34))
            ucrInputNamedRegions.SetName("")
            If Not ucrInputName.UserTyped() Then
                ucrInputName.SetName(ucrInputSheets.GetText(), bSilent:=True)
                ucrInputName.Focus()
            End If
        Else
            clsReadXLSX.RemoveParameterByName("sheet")
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrInputNamedRegions_NameChanged() Handles ucrInputNamedRegions.NameChanged
        If Not ucrInputNamedRegions.IsEmpty() Then
            clsReadXLSX.AddParameter("namedRegion", Chr(34) & ucrInputNamedRegions.GetText() & Chr(34))
            ucrInputSheets.SetName("")
            If Not ucrInputName.UserTyped() Then
                ucrInputName.SetName(ucrInputNamedRegions.GetText(), bSilent:=True)
                ucrInputName.Focus()
            End If
        Else
            clsReadXLSX.RemoveParameterByName("namedRegion")
        End If
        RefreshFrameView()
    End Sub

#End Region
End Class
