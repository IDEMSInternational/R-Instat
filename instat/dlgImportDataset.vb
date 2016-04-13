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
    Dim strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'shows the dialog first then the open dialog
        Me.Show()

        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)

        autoTranslate(Me)

        If bFirstLoad Then
            SetCSVDefault()
            setExcelDefaults()
            SetRDSDefaults
            bFirstLoad = False
        End If

        GetFileFromOpenDialog()
        TestOkEnabled()

    End Sub


#Region "Shared options"
    Public Sub SetDataName(strName As String)
        txtName.Text = strName
        Select Case Path.GetExtension(txtFilePath.Text)
            Case ".RDS"
                'clsReadRDS.SetAssignTo(strName)
            Case ".xlsx"
                clsReadXLSX.SetAssignTo(strName, strName)
            Case ".csv"
                clsReadCSV.SetAssignTo(strName, strName)
        End Select
        TestOkEnabled()
    End Sub

    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Public Sub SetFilePath(strFilePath As String, strRparameter As String)
        txtFilePath.Text = strFilePath

        If strRparameter <> "xlsxFile" Then
            RefreshFilePreview()
            RefreshFrameView()
        Else
            txtInputFile.Text = "Cannot access file contents"
            FillExcelSheets(strFilePath)
            RefreshFrameView(bPreviewExcel:=True)
        End If

    End Sub
#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetCSVDefault()
        RefreshFrameView()
    End Sub

    Private Sub TestOkEnabled()
        If txtName.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
#End Region

#Region "Import options"
    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog(Optional bFromLibrary As Boolean = False)
        Dim dlgOpen As New OpenFileDialog
        Dim strFilePath As String = ""
        Dim strFileName As String = ""
        Dim strFileExt As String = ""

        If bFromLibrary Then
            dlgOpen.Title = "Import from library"
            dlgOpen.InitialDirectory = strLibraryPath
            dlgOpen.Filter = "RDS R-file (*.RDS)|*.RDS"
        Else
            dlgOpen.Filter = "All Data files (*.csv,.xlsx,*.RDS)|*.csv;*.xlsx;*.RDS|Comma separated file (*.csv)|*.csv|RDS R-file (*.RDS)|*.RDS|Excel files (*.xlsx)|*.xlsx"
            dlgOpen.Title = "Open Data from file"
            dlgOpen.InitialDirectory = "c:\\"
        End If

        If dlgOpen.ShowDialog() = DialogResult.OK Then
            txtName.Text = ""
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
        End If

        Select Case strFileExt
            Case ".RDS"
                clsReadRDS.SetRCommand("readRDS")
                clsReadRDS.SetAssignTo(strFileName)
                clsReadRDS.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                grpExcel.Hide()
                grpCSV.Hide()
                grpRDS.Show()
                clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
                clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
                'txtFilePath.Text = strFilePath
                SetFilePath(strFilePath, "file")
            Case ".csv"
                clsReadCSV.SetRCommand("read.csv")
                ucrBase.clsRsyntax.SetBaseRFunction(clsReadCSV)
                ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
                grpRDS.Hide()
                grpExcel.Hide()
                grpCSV.Show()
                SetFilePath(strFilePath, "file")
            Case ".xlsx"
                clsReadXLSX.SetRCommand("readWorkbook")
                ucrBase.clsRsyntax.SetBaseRFunction(clsReadXLSX)
                ucrBase.clsRsyntax.AddParameter("xlsxFile", Chr(34) & strFilePath & Chr(34))
                SetFilePath(strFilePath, "xlsxFile")
                grpCSV.Hide()
                grpRDS.Hide()
                grpExcel.Show()
        End Select
        SetDataName(strFileName)

    End Sub
#End Region

#Region "File Preview options"
    Public Sub RefreshFilePreview()
        Dim sReader As New StreamReader(txtFilePath.Text)
        txtInputFile.Text = ""
        For i = 1 To intLines + nudSkips.Value + 1
            txtInputFile.Text = txtInputFile.Text & sReader.ReadLine() & vbCrLf
            If sReader.Peek() = -1 Then
                Exit For
            End If
        Next
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        SetDataName(txtName.Text)
    End Sub

    Private Sub RefreshFrameView(Optional bPreviewExcel As Boolean = False)
        Dim dfTemp As CharacterMatrix
        Dim bToBeAssigned As Boolean
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        Try
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            If bPreviewExcel Then
                ucrBase.clsRsyntax.AddParameter("rows", "1:" & intLines)
            Else
                clsReadCSV.AddParameter("nrows", intLines)
            End If
            dfTemp = frmMain.clsRLink.GetData(ucrBase.clsRsyntax.GetScript())
            ucrBase.clsRsyntax.RemoveParameter("nrows")
            ucrBase.clsRsyntax.RemoveParameter("rows")
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
            frmMain.clsGrids.FillSheet(dfTemp, txtName.Text, grdDataPreview)
        Catch
            grdDataPreview.CurrentWorksheet.Reset()
        End Try
    End Sub
#End Region

#Region "RDS options"
    Private Sub SetRDSDefaults()
        chkExisting.Checked = True
        chkModel.Checked = True
        chkMetadata.Checked = True
    End Sub

    'Private Sub chkExisting_CheckStateChanged(sender As Object, e As EventArgs) Handles chkExisting.CheckStateChanged, chkMetadata.CheckStateChanged, chkModel.CheckStateChanged
    '    If chkExisting.Checked Then
    '        clsImportRDS.AddParameter("keep_existing", "TRUE")
    '    ElseIf chkMetadata.Checked Then
    '        clsImportRDS.AddParameter("include_metadata", "TRUE")
    '    ElseIf chkModel.Checked Then
    '        clsImportRDS.AddParameter("include_models", "TRUE")
    '    Else
    '        clsImportRDS.AddParameter("include_metadata", "FALSE")
    '        clsImportRDS.AddParameter("include_metadata", "FALSE")
    '        clsImportRDS.AddParameter("keep_existing", "FALSE")
    '    End If
    'End Sub

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
        chkDates.Checked = False
        chkSkipEmptyRows.Checked = True
        chkNamedRegion.Checked = False
        txtNamedRegion.ReadOnly = True
        txtNamedRegion.Text = "NULL"
        txtRows.Text = "NULL"
        txtCols.Text = "NULL"
    End Sub

    Private Sub cboAvailableSheets_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAvailableSheets.SelectedValueChanged
        SetDataName(cboAvailableSheets.SelectedItem)
        clsReadXLSX.AddParameter("sheet", Chr(34) & cboAvailableSheets.SelectedItem & Chr(34))
        RefreshFrameView(bPreviewExcel:=True)
    End Sub

    Private Sub FillExcelSheets(strFilePath As String)
        Dim i As Integer
        Dim dfSheetList As CharacterMatrix
        dfSheetList = frmMain.clsRLink.clsEngine.Evaluate("getSheetNames(" & Chr(34) & strFilePath & Chr(34) & ")").AsCharacterMatrix
        'fills the combo box
        cboAvailableSheets.Items.Clear()
        For i = 0 To dfSheetList.RowCount - 1
            cboAvailableSheets.Items.Add(dfSheetList(i, 0))
        Next
        cboAvailableSheets.SelectedItem = cboAvailableSheets.Items(0)
        cboAvailableSheets.Focus()
        RefreshFrameView(bPreviewExcel:=True)
    End Sub

    Private Sub nudStartRow_ValueChanged(sender As Object, e As EventArgs) Handles nudStartRow.ValueChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            clsReadXLSX.AddParameter("startRow", nudStartRow.Value)
            RefreshFrameView(bPreviewExcel:=True)
        End If
    End Sub

    Private Sub chkColumnNames_CheckStateChanged(sender As Object, e As EventArgs) Handles chkColumnNames.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkColumnNames.Checked Then
                clsReadXLSX.AddParameter("colNames", "TRUE")
            Else
                clsReadXLSX.AddParameter("colNames", "FALSE")
            End If
            RefreshFrameView(bPreviewExcel:=True)
        End If
    End Sub

    Private Sub chkDates_CheckStateChanged(sender As Object, e As EventArgs) Handles chkDates.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkDates.Checked Then
                clsReadXLSX.AddParameter("detectDates", "TRUE")
            Else
                clsReadXLSX.AddParameter("detectDates", "FALSE")
            End If
            RefreshFrameView(bPreviewExcel:=True)
        End If
    End Sub

    Private Sub chkNames_CheckStateChanged(sender As Object, e As EventArgs) Handles chkNames.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkNames.Checked Then
                clsReadXLSX.AddParameter("check.names", "TRUE")
            Else
                clsReadXLSX.AddParameter("check.names", "FALSE")
            End If
            RefreshFrameView(bPreviewExcel:=True)
        End If
    End Sub

    Private Sub chkSkipEmptyRows_CheckStateChanged(sender As Object, e As EventArgs) Handles chkSkipEmptyRows.CheckStateChanged
        If cboAvailableSheets.SelectedItem <> "" Then
            If chkSkipEmptyRows.Checked Then
                clsReadXLSX.AddParameter("skipEmptyRows", "TRUE")
            Else
                clsReadXLSX.AddParameter("skipEmptyRows", "FALSE")
            End If
            RefreshFrameView(bPreviewExcel:=True)
        End If
    End Sub

    Private Sub chkNamedRegion_CheckStateChanged(sender As Object, e As EventArgs) Handles chkNamedRegion.CheckStateChanged
        If chkNamedRegion.Checked Then
            txtNamedRegion.ReadOnly = False
            nudStartRow.Enabled = False
            txtCols.ReadOnly = True
            txtRows.ReadOnly = True
        Else
            txtNamedRegion.ReadOnly = True
            nudStartRow.Enabled = True
            txtCols.ReadOnly = False
            txtRows.ReadOnly = False
        End If
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

    Private Sub txtNamedRegion_Leave(sender As Object, e As EventArgs) Handles txtNamedRegion.Leave
        If txtNamedRegion.Text <> "NULL" Then
            clsReadXLSX.AddParameter("namedRegion", txtNamedRegion.Text)
        End If
    End Sub

    Private Sub cboAvailableSheets_Enter(sender As Object, e As EventArgs) Handles cboAvailableSheets.Enter
        cboAvailableSheets_SelectedValueChanged(sender, e)
    End Sub

#End Region
End Class