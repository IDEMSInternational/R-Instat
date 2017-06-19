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
    Private clsReadCSV, clsReadRDS, clsImportRDS, clsReadXL As RFunction
    Private strTempWorkbookName As String
    Dim bFirstLoad As Boolean
    Public bFromLibrary As Boolean
    Dim strLibraryPath As String
    Dim strFileType As String
    Dim bCanImport As Boolean
    Private bReset As Boolean = True
    Dim bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean
    Public strFilePathToUseOnLoad As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        intLines = 10
        clsReadCSV = New RFunction
        clsReadRDS = New RFunction
        clsImportRDS = New RFunction
        clsReadXL = New RFunction
        'clsTempWorkbookImport = New RFunction
        'clsTempExcelPreview = New RFunction
        ucrBase.clsRsyntax.SetFunction("import")
        ucrBase.clsRsyntax.SetPackageName("rio")
        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        bFirstLoad = True
        bFromLibrary = False
        strLibraryPath = frmMain.strStaticPath & "\Library"
        bCanImport = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        ucrInputName.bAutoChangeOnLeave = True
        strFilePathToUseOnLoad = ""
    End Sub

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        Me.Show()
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        If strFilePathToUseOnLoad <> "" Then
            SetDialogWithFile(strFilePathToUseOnLoad)
            bStartOpenDialog = False
        ElseIf bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctucrInputSeparator As New Dictionary(Of String, String)
        Dim dctucrInputEncoding As New Dictionary(Of String, String)
        Dim dctucrInputDecimal As New Dictionary(Of String, String)
        Dim dctucrInputHeaders As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 11
        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        ucrInputName.SetValidationTypeAsRVariable()
        strTempWorkbookName = "temp_workbook"

        ucrChkStringsAsFactors.SetText("Convert Strings to Factor Columns")

        ucrChkExistingData.SetText("Keep existing data frames")
        ucrChkExistingData.SetParameter(New RParameter("keep_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkImportMetadata.SetText("Import metadata")
        ucrChkImportMetadata.SetParameter(New RParameter("include_metadata"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkImportObjects.SetText("Import objects")
        ucrChkImportObjects.SetParameter(New RParameter("include_objects"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkImportFilters.SetText("Import filters")
        ucrChkImportFilters.SetParameter(New RParameter("include_filters"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkImportCalculations.SetText("Import calculations")
        ucrChkImportCalculations.SetParameter(New RParameter("include_calculations"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkOverWrite.SetText("Overwrite existing if duplicates found")
        ucrChkOverWrite.SetParameter(New RParameter("overwrite_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        'temp disabled until can easily switch between fread and read.csv
        rdoRowNamesYes.Enabled = False
        'disabled until issue is resolved: http://stackoverflow.com/questions/37635541/rio-r-package-can-i-import-a-csv-file-with-non-comma-separator
        ucrInputSeparator.Enabled = False

        'hide since no longer using openxlsx package
        ucrInputNamedRegions.Hide()
        lblNamedRegion.Hide()

        ucrInputFilePath.IsReadOnly = True

        'xl options settings
        ucrNudxlRowsToSkip.Maximum = Integer.MaxValue

        ' ucrInputEncoding.SetItems({"unknown"})
        ucrInputEncoding.SetParameter(New RParameter("encoding", 1))
        dctucrInputEncoding.Add("Unknown ,", Chr(34) & "unknown" & Chr(34))
        ucrInputEncoding.SetRDefault(Chr(34) & "unknown" & Chr(34))
        'csv options settings
        clsReadCSV.AddParameter("check.names", "TRUE")

        ' ucrInputSeparator.SetItems({"Automatic", ", ", "Whitespace", ": ", ";", "|", "^"})
        ucrInputSeparator.SetParameter(New RParameter("sep"))
        dctucrInputSeparator.Add("Automatic ,", Chr(34) & "auto" & Chr(34))
        dctucrInputSeparator.Add("Comma(,) ,", Chr(34) & "," & Chr(34))
        dctucrInputSeparator.Add("Whitespace ,", Chr(34) & " " & Chr(34))
        dctucrInputSeparator.Add("Colon(:) ,", Chr(34) & ":" & Chr(34))
        dctucrInputSeparator.Add("Semi-Colon(;) ,", Chr(34) & ";" & Chr(34))
        dctucrInputSeparator.Add("Vertcal-Line ,", Chr(34) & "|" & Chr(34))
        dctucrInputSeparator.Add("Power ,", Chr(34) & "^" & Chr(34))
        ucrInputSeparator.SetRDefault(Chr(34) & "" & Chr(34))

        'Check...Changed NO to FALSE!
        'ucrInputHeaders.SetItems({"Automatic", "Yes", "No"})
        ucrInputHeaders.SetParameter(New RParameter("header"))
        dctucrInputHeaders.Add("Automatic", Chr(34) & "auto" & Chr(34))
        dctucrInputHeaders.Add("Yes", Chr(34) & "TRUE" & Chr(34))
        dctucrInputHeaders.Add("No", Chr(34) & "FALSE" & Chr(34))
        ucrInputHeaders.SetRDefault(Chr(34) & "FALSE" & Chr(34))

        ' ucrInputDecimal.SetItems({"Automatic", ".", ","})
        ucrInputDecimal.SetParameter(New RParameter("dec"))
        'dec param absent
        dctucrInputDecimal.Add("Automatic", Chr(34) & Chr(34))
        dctucrInputDecimal.Add("Period(.)", Chr(34) & "." & Chr(34))
        dctucrInputDecimal.Add("Comma(,)", Chr(34) & "," & Chr(34))
        ucrInputDecimal.SetRDefault(Chr(34) & "." & Chr(34))

        ucrNudSkip.SetParameter(New RParameter("skip"))
        ucrNudSkip.Maximum = Integer.MaxValue
    End Sub

    Private Sub SetDefaults()
        grpCSV.Hide()
        grpRDS.Hide()
        grpExcel.Hide()
        txtPreview.Hide()
        lblInputFile.Hide()
        lblNoPreview.Hide()
        lblCannotImport.Hide()
        lblDataFrame.Hide()
        grdDataPreview.Hide()
        ucrInputFilePath.SetName("")
        ucrInputName.SetName("")
        SetCSVDefault()
        setExcelDefaults()
        SetRDSDefaults()

        clsReadCSV.AddParameter("encoding", Chr(34) & "unknown" & Chr(34))
        clsReadCSV.AddParameter("sep", Chr(34) & "" & Chr(34))
        clsReadCSV.AddParameter("header", Chr(34) & "FALSE" & Chr(34))
        clsReadCSV.AddParameter("dec", Chr(34) & "." & Chr(34))
    End Sub

#Region "Shared options"
    Public Sub setLinesToRead(lines As Integer)
        intLines = lines
    End Sub

    Private Sub ucrInputName_NameChanged() Handles ucrInputName.ControlValueChanged
        If Not ucrInputName.IsEmpty AndAlso strFileType <> "RDS" Then
            ucrBase.clsRsyntax.SetAssignTo(ucrInputName.GetText(), strTempDataframe:=ucrInputName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
        TestOkEnabled()
    End Sub
#End Region

#Region "Dialog options"
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        RefreshFrameView()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrInputName.IsEmpty OrElse strFileType = "RDS") AndAlso bCanImport Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
#End Region

#Region "Import options"
    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html;|All files|*.*;"
            If bFromLibrary Then
                dlgOpen.Title = "Import from library"
                dlgOpen.InitialDirectory = strLibraryPath
                bFromLibrary = False
            Else
                dlgOpen.Title = "Open Data from file"
                If Not ucrInputFilePath.IsEmpty() Then
                    dlgOpen.InitialDirectory = Path.GetDirectoryName(Replace(ucrInputFilePath.GetText(), "/", "\"))
                Else
                    dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
                End If
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ucrInputName.SetName("")
                ucrInputName.Reset()
                'checks if the file name is not blank'
                If dlgOpen.FileName <> "" Then
                    SetDialogWithFile(dlgOpen.FileName)
                End If
            Else
                If bFromLibrary Then
                    'TODO something like this so that the Import dialog closes
                    '     when using open from library but library dialog stays open
                    'bFromLibrary = False
                    'Me.Close()
                End If
                If ucrInputFilePath.GetText() = "" Then
                    grpCSV.Hide()
                    grpExcel.Hide()
                    grpRDS.Hide()
                    grdDataPreview.Hide()
                    lblDataFrame.Hide()
                    txtPreview.Hide()
                    lblInputFile.Hide()
                End If
            End If
            TestOkEnabled()
        End Using
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrChkExistingData.SetRCode(clsImportRDS, bReset)
        ucrInputSeparator.SetRCode(clsReadCSV, bReset)
        ucrInputHeaders.SetRCode(clsReadCSV, bReset)
        ucrInputDecimal.SetRCode(clsReadCSV, bReset)
        ucrInputEncoding.SetRCode(clsReadCSV, bReset)
        ' ucrChkExistingData.AddAdditionalCodeParameterPair(cls)
    End Sub

    Public Sub SetDialogWithFile(strFilePath As String)
        Dim strFileExt As String
        Dim strFileName As String

        strFileName = Path.GetFileNameWithoutExtension(strFilePath)
        strFilePath = Replace(strFilePath, "\", "/")
        strFileExt = Path.GetExtension(strFilePath)

        strFileExt = Path.GetExtension(strFilePath)
        ucrInputFilePath.SetName(strFilePath)
        grdDataPreview.Show()
        lblDataFrame.Show()
        txtPreview.Show()
        lblInputFile.Show()
        ucrInputName.Show()
        lblName.Show()
        If strFileExt = ".RDS" Then
            clsReadRDS.SetRCommand("readRDS")
            clsReadRDS.AddParameter("file", Chr(34) & strFilePath & Chr(34))
            'TODO This needs to be different when RDS is a data frame
            'need to be able to detect RDS as data.frame/Instat Object
            clsReadRDS.SetAssignTo("new_RDS")
            grpExcel.Hide()
            grpCSV.Hide()
            grpRDS.Show()
            txtPreview.Text = ""
            txtPreview.Enabled = False
            grdDataPreview.Enabled = False
            ucrBase.clsRsyntax.clsBaseFunction.ClearParameters()
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
            ucrBase.clsRsyntax.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
            strFileType = "RDS"
            ucrInputName.Hide()
            lblName.Hide()
            'ucrInputName.SetName(strFileName, bSilent:=True)
        ElseIf strFileExt = ".csv" Then
            clsReadCSV.SetPackageName("rio")
            clsReadCSV.SetRCommand("import")
            clsReadCSV.AddParameter("file", Chr(34) & strFilePath & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsReadCSV)
            grpRDS.Hide()
            grpExcel.Hide()
            grpCSV.Show()
            txtPreview.Enabled = True
            grdDataPreview.Enabled = True
            strFileType = "csv"
            ucrInputName.SetName(strFileName, bSilent:=True)
            RefreshFilePreview()
            ucrInputName.Focus()
        ElseIf strFileExt = ".xlsx" OrElse strFileExt = ".xls" Then
            clsReadXL.SetPackageName("rio")
            clsReadXL.SetRCommand("import")
            clsReadXL.AddParameter("file", Chr(34) & strFilePath & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsReadXL)
            grpCSV.Hide()
            grpRDS.Hide()
            grpExcel.Show()
            txtPreview.Text = ""
            txtPreview.Enabled = False
            grdDataPreview.Enabled = True
            If strFileExt = ".xlsx" Then
                strFileType = "xlsx"
                clsReadXL.AddParameter("readxl", "FALSE")
            Else
                strFileType = "xls"
                clsReadXL.RemoveParameterByName("readxl")
            End If
            FillExcelSheetsAndRegions(strFilePath)

            'ucrInputName.SetName(strFileName, bSilent:=True)
        Else
            strFileType = strFileExt.Substring(1)
            ucrBase.clsRsyntax.clsBaseFunction.SetPackageName("rio")
            ucrBase.clsRsyntax.clsBaseFunction.ClearParameters()
            ucrBase.clsRsyntax.SetFunction("import")
            ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
            grpCSV.Hide()
            grpExcel.Hide()
            grpRDS.Hide()
            grdDataPreview.Show()
            lblDataFrame.Show()
            txtPreview.Hide()
            lblInputFile.Hide()
            ucrInputName.SetName(strFileName, bSilent:=True)
            ucrInputName.Focus()
        End If
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

#End Region

#Region "File Preview options"
    Public Sub RefreshFilePreview()
        Dim sReader As StreamReader
        If strFileType = "csv" AndAlso ucrInputFilePath.GetText() <> "" Then
            Try
                sReader = New StreamReader(ucrInputFilePath.GetText())
                txtPreview.Text = ""
                For i = 1 To intLines + ucrNudSkip.Value + 1
                    txtPreview.Text = txtPreview.Text & sReader.ReadLine() & Environment.NewLine
                    If sReader.Peek() = -1 Then
                        Exit For
                    End If
                Next
            Catch ex As Exception
                txtPreview.Text = "Cannot show text preview of file:" & ucrInputFilePath.GetText() & ". The file may be in use by another program. Close the file and select it again from the dialog to refresh the preview."
                bCanImport = False
            End Try
        Else
            txtPreview.Text = "Preview only available for text files"
        End If
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As DataFrame
        Dim expTemp As SymbolicExpression = Nothing
        Dim bToBeAssigned As Boolean
        Dim strTempDataFrameName As String
        Dim bValid As Boolean
        Dim clsAsCharacterFunc As New RFunction
        'Dim control As Control

        'Remove as may have other effects
        'For Each control In Me.Controls
        '    control.Enabled = False
        'Next
        Cursor = Cursors.WaitCursor
        ucrBase.OKEnabled(False)
        clsAsCharacterFunc.SetRCommand("convert_to_character_matrix")
        strTempDataFrameName = "temp"
        bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
        ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
        If strFileType <> "RDS" Then
            grdDataPreview.Show()
            lblDataFrame.Show()
            If strFileType = "csv" Then
                clsReadCSV.AddParameter("nrows", intLines)
            ElseIf strFileType = "xlsx" Then
                'iPosition = 0 is needed because of a bug in rio::import
                clsReadXL.AddParameter("rows", "1:" & intLines, iPosition:=0)
            End If
            lblCannotImport.Hide()
            lblNoPreview.Hide()
            If ucrInputFilePath.IsEmpty() Then
                bValid = False
            Else
                clsAsCharacterFunc.AddParameter("data", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction)
                expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunc.ToScript(), bSilent:=True)
                bValid = (expTemp IsNot Nothing)
            End If
            If bValid Then
                dfTemp = Nothing
                If expTemp IsNot Nothing Then
                    dfTemp = expTemp.AsDataFrame
                End If
                If dfTemp Is Nothing Then
                    bValid = False
                Else
                    ucrBase.clsRsyntax.RemoveParameter("nrows")
                    ucrBase.clsRsyntax.RemoveParameter("rows")
                    'If readXL is not the base function this may be needed.
                    clsReadXL.RemoveParameterByName("rows")
                    ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
                    Try
                        frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=False)
                        grdDataPreview.Enabled = True
                        bCanImport = True
                    Catch
                        bValid = False
                    End Try
                End If
            End If
            If Not bValid Then
                grdDataPreview.CurrentWorksheet.Reset()
                grdDataPreview.Enabled = False
                If Not ucrInputFilePath.IsEmpty() Then
                    lblCannotImport.Show()
                Else
                    lblCannotImport.Hide()
                End If
                bCanImport = False
            End If
        Else
            bCanImport = True
            lblCannotImport.Hide()
            lblNoPreview.Show()
            grdDataPreview.CurrentWorksheet.Reset()
            grdDataPreview.Hide()
            lblDataFrame.Hide()
        End If
        If grdDataPreview.CurrentWorksheet IsNot Nothing Then
            grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        End If
        'Remove as may have other effects
        'For Each control In Me.Controls
        '    control.Enabled = True
        'Next
        Cursor = Cursors.Default
        TestOkEnabled()
    End Sub
#End Region

#Region "RDS options"
    Private Sub SetRDSDefaults()
        'chkExistingData.Checked = True
        'chkImportObjects.Checked = True
        'chkImportMetadata.Checked = True
        'chkImportChangesLog.Checked = True
        'chkImportFilters.Checked = True
        'chkImportCalculations.Checked = True
        'chkOverWrite.Checked = False
    End Sub


    'Private Sub chkExisting_CheckStateChanged(sender As Object, e As EventArgs)
    '    If chkExistingData.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("keep_existing", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("keep_existing")
    '        End If
    '    Else
    '        clsImportRDS.AddParameter("keep_existing", "FALSE")
    '    End If
    'End Sub

    'Private Sub chkLogs_CheckStateChanged(sender As Object, e As EventArgs)
    '    If chkImportChangesLog.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("include_logs", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("include_logs")
    '        End If
    '    Else
    '        clsImportRDS.RemoveParameterByName("include_logs")
    '    End If
    'End Sub

    'Private Sub chkOverWrite_CheckStateChanged(sender As Object, e As EventArgs)
    '    If chkOverWrite.Checked Then
    '        clsImportRDS.AddParameter("overwrite_existing", "TRUE")
    '    Else
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("overwrite_existing", "FALSE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("overwrite_existing")
    '        End If
    '    End If
    'End Sub

    'Private Sub chkMetadata_CheckStateChanged(sender As Object, e As EventArgs)
    '    If chkImportMetadata.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("include_metadata", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("include_metadata")
    '        End If
    '    Else
    '        clsImportRDS.AddParameter("include_metadata", "FALSE")
    '    End If
    'End Sub

    'Private Sub chkKeepFilters_CheckedChanged(sender As Object, e As EventArgs)
    '    If chkImportFilters.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("include_filters", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("include_filters")
    '        End If
    '    Else
    '        clsImportRDS.AddParameter("include_filters", "FALSE")
    '    End If
    'End Sub

    'Private Sub chkImportCalculations_CheckedChanged(sender As Object, e As EventArgs)
    '    If chkImportCalculations.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("include_calculations", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("include_calculations")
    '        End If
    '    Else
    '        clsImportRDS.AddParameter("include_calculations", "FALSE")
    '    End If
    'End Sub

    'Private Sub chkKeepObjects_CheckStateChanged(sender As Object, e As EventArgs)
    '    If chkImportObjects.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportRDS.AddParameter("include_objects", "TRUE")
    '        Else
    '            clsImportRDS.RemoveParameterByName("include_objects")
    '        End If
    '    Else
    '        clsImportRDS.AddParameter("include_objects", "FALSE")
    '    End If
    'End Sub

#End Region

#Region "CSV options"
    Private Sub SetCSVDefault()
        ucrInputEncoding.SetName("unknown")
        rdoRowNamesNo.Checked = True
        ucrInputSeparator.SetName("Automatic")
        ucrInputHeaders.SetName("Automatic")
        ucrInputDecimal.SetName("Automatic")
        ucrInputNAStrings.SetName("NA")
        '  ucrNudSkip.Value = 0
        'ucrChkStringsAsFactors.Checked = True
    End Sub

    Private Sub ucrInputEncoding_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputEncoding.ControlValueChanged

        If ucrInputEncoding.GetText() <> "" AndAlso (ucrInputEncoding.GetText() <> "unknown" OrElse frmMain.clsInstatOptions.bIncludeRDefaultParameters) Then
            clsReadCSV.AddParameter("encoding", ucrInputEncoding.GetText)
        Else
            clsReadCSV.RemoveParameterByName("encoding")
        End If
        RefreshFrameView()

    End Sub

    Private Sub rdoRowNames_CheckedChanged() Handles ucrPnlRowNames.ControlValueChanged
        If rdoRowNamesYes.Checked Then
            'TODO this is not an option for fread so have to change function here
            clsReadCSV.AddParameter("row.names", 1)
        Else
            'TODO find out what difference there is between
            'row.names = NULL and row.names missing
            'disabled as import (fread) does not support row.names
            'clsReadCSV.AddParameter("row.names", "NULL")
            clsReadCSV.RemoveParameterByName("row.names")
        End If
    End Sub

    Private Sub ucrInputHeaders_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaders.ControlValueChanged
        '    Select Case ucrInputHeaders.GetText()
        '        Case "Automatic"
        '            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '                clsReadCSV.AddParameter("header", Chr(34) & "auto" & Chr(34))
        '            Else
        '                clsReadCSV.RemoveParameterByName("header")
        '            End If
        '            clsReadCSV.RemoveParameterByName("header")
        '        Case "Yes"
        '            clsReadCSV.AddParameter("header", "TRUE")
        '        Case "No"
        '            clsReadCSV.AddParameter("header", "FALSE")
        '        Case Else
        '            'clsReadCSV.RemoveParameterByName("header")
        '    End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputDecimal_ControlValueChanged() Handles ucrInputDecimal.ControlValueChanged
        'Select Case ucrInputDecimal.GetText
        '    Case "Automatic"
        '        clsReadCSV.RemoveParameterByName("dec")
        '    Case Else
        '        clsReadCSV.AddParameter("dec", Chr(34) & ucrInputDecimal.GetText() & Chr(34))
        'End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputSeparator_ControlValueChanged() Handles ucrInputSeparator.ControlValueChanged
        'Select Case ucrInputSeparator.GetText
        '    Case "Automatic"
        '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '            clsReadCSV.AddParameter("sep", Chr(34) & "auto" & Chr(34))
        '        Else
        '            clsReadCSV.RemoveParameterByName("sep")
        '        End If
        '        clsReadCSV.RemoveParameterByName("sep")
        '    Case "Whitespace"
        '        clsReadCSV.AddParameter("sep", Chr(34) & "" & Chr(34))
        '    Case ""
        '        clsReadCSV.RemoveParameterByName("sep")
        '    Case Else
        '        clsReadCSV.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText() & Chr(34))
        'End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputDecimal_TextChanged() Handles ucrInputDecimal.ControlValueChanged
        'Select Case ucrInputDecimal.GetText
        '    Case "Period"
        '        clsReadCSV.AddParameter("dec", Chr(34) & "." & Chr(34))
        '    Case "Comma"
        '        clsReadCSV.AddParameter("dec", Chr(34) & "," & Chr(34))
        'End Select
        RefreshFrameView()
    End Sub

    Private Sub ucrInputNAStrings_ControlValueChanged() Handles ucrInputNAStrings.ControlValueChanged
        If ucrInputNAStrings.GetText() <> "" AndAlso (ucrInputNAStrings.GetText() <> "NA" OrElse frmMain.clsInstatOptions.bIncludeRDefaultParameters) Then
            clsReadCSV.AddParameter("na.strings", Chr(34) & ucrInputNAStrings.GetText() & Chr(34))
        Else
            clsReadCSV.RemoveParameterByName("na.strings")
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrNudSkip_ControlValueChanged() Handles ucrNudSkip.ControlValueChanged
        If bComponentsInitialised Then
            If ucrNudSkip.Value = 0 Then
                clsReadCSV.RemoveParameterByName("skip")
            Else
                clsReadCSV.AddParameter("skip", ucrNudSkip.Value)
            End If
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
        ucrNudxlRowsToSkip.Value = 0
        XlSkipRowsParameter()
        ucrchkColumnNames.Checked = True
        XlStringsAsFactorsParameter()
        XlColNamesParameter()
        ucrInputXlMissingValueString.SetName("")
    End Sub

    Private Sub FillExcelSheetsAndRegions(strFilePath As String)
        Dim i As Integer
        Dim chrSheets As CharacterVector
        'Dim chrRegions As CharacterVector
        Dim clsGetSheetNames As New RFunction
        'Dim clsGetNamedRegions As New RFunction

        clsGetSheetNames.SetPackageName("readxl")
        clsGetSheetNames.SetRCommand("excel_sheets")
        clsGetSheetNames.AddParameter("path", Chr(34) & ucrInputFilePath.GetText() & Chr(34))
        'not needed now since not using openxlsx
        ' temporary solutions until issue with getNamedRegions is resolved
        ' https://github.com/awalker89/openxlsx/issues/174
        'clsGetNamedRegions.SetPackageName("openxlsx")
        'clsGetNamedRegions.SetRCommand("getNamedRegions")
        'clsGetNamedRegions.SetRCommand("regmatches")
        'clsGetNamedRegions.AddParameter("xlsxFile", strTempWorkbookName)
        'clsGetNamedRegions.AddParameter("x", strTempWorkbookName & "$workbook$definedNames")
        'clsGetNamedRegions.AddParameter("m", "regexpr('(?<=name=" & Chr(34) & ")[^" & Chr(34) & "]+', " & strTempWorkbookName & "$workbook$definedNames" & ", perl = TRUE)")
        chrSheets = frmMain.clsRLink.RunInternalScriptGetValue(clsGetSheetNames.ToScript()).AsCharacter
        'chrRegions = frmMain.clsRLink.RunInternalScriptGetValue(clsGetNamedRegions.ToScript()).AsCharacter

        ucrInputSheets.cboInput.Items.Clear()
        If chrSheets IsNot Nothing AndAlso chrSheets.Count > 0 Then
            For i = 0 To chrSheets.Count - 1
                ucrInputSheets.cboInput.Items.Add(chrSheets(i))
            Next
            ucrInputSheets.SetName(ucrInputSheets.cboInput.Items(0), bSilent:=True)
        Else
            ucrInputSheets.SetName("")
        End If

        'ucrInputNamedRegions.cboInput.Items.Clear()
        'If chrRegions IsNot Nothing AndAlso chrRegions.Count > 0 Then
        '    For i = 0 To chrRegions.Count - 1
        '        ucrInputNamedRegions.cboInput.Items.Add(chrRegions(i))
        '    Next
        'End If
        'ucrInputNamedRegions.SetName("")
    End Sub

    ' Private Sub nudxlRowsToSkip_TextChanged(sender As Object, e As EventArgs) Handles ucrNudxlRowsToSkip.ControlValueChanged
    '   XlSkipRowsParameter()
    '    ucrchkColumnNames.SetText("Trim Trailing WhiteSpace")
    ' End Sub
    'Private Sub nudxlRowsToSkip_TextChanged(sender As Object, e As EventArgs) Handles ucrchkColumnNames.ControlValueChanged
    '    XlSkipRowsParameter()
    '    ucrchkColumnNames.SetText("Trim Trailing WhiteSpace")
    'End Sub

    Private Sub XlSkipRowsParameter()
        If bComponentsInitialised Then
            If ucrNudxlRowsToSkip.Text <> "" Then
                If ucrNudxlRowsToSkip.Value = 0 AndAlso Not frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsReadXL.RemoveParameterByName("skip")
                Else
                    clsReadXL.AddParameter("skip", ucrNudxlRowsToSkip.Value)
                End If
            Else
                clsReadXL.RemoveParameterByName("skip")
            End If
            RefreshFrameView()
        End If
    End Sub

    'Private Sub chkColumnNames_CheckedChanged(sender As Object, e As EventArgs) Handles ucrchkColumnNames.ControlValueChanged
    '    XlColNamesParameter()
    'End Sub

    Private Sub XlColNamesParameter()
        Dim strColNameParam As String

        If strFileType = "xlsx" Then
            strColNameParam = "colNames"
            clsReadXL.RemoveParameterByName("col_names")
        Else
            strColNameParam = "col_names"
            clsReadXL.RemoveParameterByName("colNames")
        End If

        If ucrchkColumnNames.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXL.AddParameter(strColNameParam, "TRUE")
            Else
                clsReadXL.RemoveParameterByName(strColNameParam)
            End If
        Else
            clsReadXL.AddParameter(strColNameParam, "FALSE")
        End If
        RefreshFrameView()
    End Sub

    Private Sub Control_ControlValueChanged() Handles ucrChkStringsAsFactors.ControlValueChanged
        XlStringsAsFactorsParameter()
    End Sub

    Private Sub XlStringsAsFactorsParameter()
        If ucrChkStringsAsFactors.Checked Then
            clsReadCSV.AddParameter("stringsAsFactors", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadCSV.AddParameter("stringsAsFactors", "FALSE")
            Else
                clsReadCSV.RemoveParameterByName("stringsAsFactors")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub lblRowVector_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMetaData.Show()
    End Sub

    Private Sub ucrInputXlMissingValueString_ControlValueChanged() Handles ucrInputXlMissingValueString.ControlValueChanged
        If Not ucrInputXlMissingValueString.IsEmpty() Then
            clsReadXL.AddParameter("na", Chr(34) & ucrInputXlMissingValueString.GetText() & Chr(34))
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsReadXL.AddParameter("na", Chr(34) & Chr(34))
            Else
                clsReadXL.RemoveParameterByName("na")
            End If
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrInputSheets_ControlValueChanged() Handles ucrInputSheets.ControlValueChanged
        If Not ucrInputSheets.IsEmpty() Then
            If strFileType = "xlsx" Then
                clsReadXL.AddParameter("which", ucrInputSheets.cboInput.SelectedIndex + 1)
                clsReadXL.RemoveParameterByName("sheet")
                If Not ucrInputName.UserTyped() Then
                    ucrInputName.SetName(ucrInputSheets.GetText(), bSilent:=True)
                    ucrInputName.Focus()
                End If
            ElseIf strFileType = "xls" Then
                clsReadXL.AddParameter("sheet", ucrInputSheets.cboInput.SelectedIndex + 1)
                clsReadXL.RemoveParameterByName("which")
                If Not ucrInputName.UserTyped() Then
                    ucrInputName.SetName(ucrInputSheets.GetText(), bSilent:=True)
                    ucrInputName.Focus()
                End If
            Else
                clsReadXL.RemoveParameterByName("sheet")
                clsReadXL.RemoveParameterByName("which")
            End If
            'ucrInputNamedRegions.SetName("")
        Else
            clsReadXL.RemoveParameterByName("sheet")
            clsReadXL.RemoveParameterByName("which")
        End If
        RefreshFrameView()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ' add the item to the MRU (Most Recently Used) list...
        'Disabled until implemented correctly
        frmMain.clsRecentItems.addToMenu(Replace(ucrInputFilePath.GetText(), "/", "\"))
        If strFileType = "RDS" Then
            frmMain.strSaveFilePath = ucrInputFilePath.GetText()
        End If
    End Sub

    'Private Sub ucrInputNamedRegions_ControlValueChanged() Handles ucrInputNamedRegions.ControlValueChanged
    '    If Not ucrInputNamedRegions.IsEmpty() Then
    '        clsReadXLSX.AddParameter("namedRegion", Chr(34) & ucrInputNamedRegions.GetText() & Chr(34))
    '        ucrInputSheets.SetName("")
    '        nudStartRow.Value = 1
    '        nudStartRow.Enabled = False
    '        If Not ucrInputName.UserTyped() Then
    '            ucrInputName.SetName(ucrInputNamedRegions.GetText(), bSilent:=True)
    '            ucrInputName.Focus()
    '        End If
    '    Else
    '        clsReadXLSX.RemoveParameterByName("namedRegion")
    '        nudStartRow.Enabled = True
    '    End If
    '    RefreshFrameView()
    'End Sub

#End Region
End Class