' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports System.IO
Imports RDotNet
Imports System.ComponentModel
Imports instat

Public Class dlgImportDataset

    Private clsImportCSV, clsImportDAT, clsImportRDS, clsReadRDS, clsImportExcel, clsImport As RFunction
    Private clsGetExcelSheetNames As RFunction
    Private bFirstLoad As Boolean
    Public bFromLibrary As Boolean
    Private strLibraryPath As String
    Private strFileType As String
    Private bCanImport As Boolean
    Private bReset As Boolean = True
    Private bComponentsInitialised As Boolean
    Public bStartOpenDialog As Boolean
    Public strFilePathSystem As String
    Public strFilePathR As String
    Public strCurrentDirectory As String
    Public strFileToOpenOn As String
    Private bDialogLoaded As Boolean
    Private iDataFrameCount As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        bFromLibrary = False
        strLibraryPath = Path.Combine(frmMain.strStaticPath & "\Library")
        bCanImport = True
        bComponentsInitialised = True
        bStartOpenDialog = True
        strFilePathSystem = ""
        strCurrentDirectory = ""
        strFileToOpenOn = ""
    End Sub

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bDialogLoaded = False
        autoTranslate(Me)
        Me.Show()
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetRCodeForControls(bReset)
        If strFileToOpenOn <> "" Then
            If Not File.Exists(strFileToOpenOn) Then
                MsgBox("File no longer exists: " & strFileToOpenOn)
                SetControlsFromFile("")
            Else
                SetControlsFromFile(strFileToOpenOn)
            End If
            bStartOpenDialog = False
            strFileToOpenOn = ""
            bDialogLoaded = True
            RefreshFilePreview()
            RefreshFrameView()
        ElseIf bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
            bDialogLoaded = True
            RefreshFilePreview()
            RefreshFrameView()
        Else
            If Not File.Exists(strFilePathSystem) Then
                MsgBox("File no longer exists: " & strFilePathSystem, MsgBoxStyle.Information, "File No Longer Exists")
                SetControlsFromFile("")
                bDialogLoaded = True
                RefreshFilePreview()
                RefreshFrameView()
            End If
        End If
        bDialogLoaded = True
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctucrInputSeparatorCSV As New Dictionary(Of String, String)
        Dim dctucrInputEncodingCSV As New Dictionary(Of String, String)
        Dim dctucrInputDecimalCSV As New Dictionary(Of String, String)
        Dim dctucrInputHeadersCSV As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 11

        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        txtTextFilePreview.ReadOnly = True
        '##############################################################

        'General Controls

        ucrInputFilePath.SetParameter(New RParameter("file"))
        ucrInputFilePath.IsReadOnly = True

        ucrSaveFile.SetLabelText("New Data Frame Name:")
        ucrSaveFile.SetIsTextBox()
        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.ucrInputTextSave.bAutoChangeOnLeave = True

        ucrNudPreviewLines.Value = 10

        '##############################################################

        'RDS Controls

        ucrChkImportChangesLogRDS.SetText("Import changes log")
        ucrChkImportChangesLogRDS.SetParameter(New RParameter("include_logs"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportChangesLogRDS.SetRDefault("TRUE")
        'ucrChkImportChangesLog.AddParameterPresentCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        'ucrChkImportChangesLog.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$import_RDS", False)

        ucrChkKeepExistingDataRDS.SetText("Keep existing data frames")
        ucrChkKeepExistingDataRDS.SetParameter(New RParameter("keep_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkKeepExistingDataRDS.SetRDefault("TRUE")
        'ucrChkExistingData.AddParameterPresentCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        'ucrChkExistingData.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$import_RDS", False)

        ucrChkImportMetadataRDS.SetText("Import metadata")
        ucrChkImportMetadataRDS.SetParameter(New RParameter("include_metadata"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportMetadataRDS.SetRDefault("TRUE")
        'ucrChkImportMetadata.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        'ucrChkImportMetadata.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$import_RDS", False)

        ucrChkImportObjectsRDS.SetText("Import objects")
        ucrChkImportObjectsRDS.SetParameter(New RParameter("include_objects"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportObjectsRDS.SetRDefault("TRUE")

        'ucrChkImportObjects.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        'ucrChkImportObjects.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$import_RDS", False)

        ucrChkImportFiltersRDS.SetText("Import filters")
        ucrChkImportFiltersRDS.SetParameter(New RParameter("include_filters"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportFiltersRDS.SetRDefault("TRUE")
        'ucrChkImportFilters.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        ucrChkImportCalculationsRDS.SetText("Import calculations")
        ucrChkImportCalculationsRDS.SetParameter(New RParameter("include_calculations"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportCalculationsRDS.SetRDefault("TRUE")
        'ucrChkImportCalculations.AddFunctionNamesCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        'ucrChkImportCalculations.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$import_RDS", False)

        ucrChkOverwriteRDS.SetText("Overwrite existing if duplicates found")
        ucrChkOverwriteRDS.SetParameter(New RParameter("overwrite_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkOverwriteRDS.SetRDefault("FALSE")
        'ucrChkOverWrite.AddParameterPresentCondition(True, frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        'ucrPnlRowNames.SetParameter(New RParameter("row.names"))
        'ucrPnlRowNames.AddRadioButton(rdoRowNamesYes, Chr(34) & "TRUE" & Chr(34))
        'ucrPnlRowNames.AddRadioButton(rdoRowNamesNo, Chr(34) & "FALSE" & Chr(34))
        'ucrPnlRowNames.SetRDefault(Chr(34) & "TRUE" & Chr(34))

        '##############################################################

        'CSV Controls

        ucrChkStringsAsFactorsCSV.SetText("Convert Strings to Factor Columns")
        ucrChkStringsAsFactorsCSV.SetParameter(New RParameter("stringsAsFactors"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkStringsAsFactorsCSV.SetRDefault("FALSE")

        ucrInputNAStringsCSV.SetParameter(New RParameter("na.strings"))
        ucrInputNAStringsCSV.SetRDefault(Chr(34) & "NA" & Chr(34))

        ucrInputEncodingCSV.SetParameter(New RParameter("encoding", 1))
        dctucrInputEncodingCSV.Add("unknown", Chr(34) & "unknown" & Chr(34))
        dctucrInputEncodingCSV.Add("UTF-8", Chr(34) & "UTF-8" & Chr(34))
        dctucrInputEncodingCSV.Add("Latin-1", Chr(34) & "Latin-1" & Chr(34))
        ucrInputEncodingCSV.SetItems(dctucrInputEncodingCSV)
        ucrInputEncodingCSV.SetRDefault(Chr(34) & "unknown" & Chr(34))
        ucrInputEncodingCSV.SetDropDownStyleAsNonEditable()

        ucrInputSeparatorCSV.SetParameter(New RParameter("sep"))
        dctucrInputSeparatorCSV.Add("Automatic", Chr(34) & "auto" & Chr(34))
        dctucrInputSeparatorCSV.Add("Comma(,)", Chr(34) & "," & Chr(34))
        dctucrInputSeparatorCSV.Add("Whitespace", Chr(34) & " " & Chr(34))
        dctucrInputSeparatorCSV.Add("Colon(:)", Chr(34) & ":" & Chr(34))
        dctucrInputSeparatorCSV.Add("Semi-Colon(;)", Chr(34) & ";" & Chr(34))
        dctucrInputSeparatorCSV.Add("Vertcal-Line(|)", Chr(34) & "|" & Chr(34))
        dctucrInputSeparatorCSV.Add("Caret(^)", Chr(34) & "^" & Chr(34))
        ucrInputSeparatorCSV.SetItems(dctucrInputSeparatorCSV)
        ucrInputSeparatorCSV.SetRDefault(Chr(34) & "auto" & Chr(34))
        ucrInputSeparatorCSV.bAllowNonConditionValues = True

        ucrInputHeadersCSV.SetParameter(New RParameter("header"))
        dctucrInputHeadersCSV.Add("Automatic", Chr(34) & "auto" & Chr(34))
        dctucrInputHeadersCSV.Add("Yes", "TRUE")
        dctucrInputHeadersCSV.Add("No", "FALSE")
        ucrInputHeadersCSV.SetItems(dctucrInputHeadersCSV)
        ucrInputHeadersCSV.SetRDefault(Chr(34) & "auto" & Chr(34))
        ucrInputHeadersCSV.SetDropDownStyleAsNonEditable()

        ucrInputDecimalCSV.SetParameter(New RParameter("dec"))
        dctucrInputDecimalCSV.Add("Automatic", Chr(34) & "auto" & Chr(34))
        dctucrInputDecimalCSV.Add("Period(.)", Chr(34) & "." & Chr(34))
        dctucrInputDecimalCSV.Add("Comma(,)", Chr(34) & "," & Chr(34))
        ucrInputDecimalCSV.SetItems(dctucrInputDecimalCSV)
        ucrInputDecimalCSV.SetRDefault(Chr(34) & "auto" & Chr(34))
        ucrInputDecimalCSV.SetDropDownStyleAsNonEditable()

        ucrNudLinesToSkipCSV.SetParameter(New RParameter("skip"))
        ucrNudLinesToSkipCSV.Maximum = Integer.MaxValue
        ucrNudLinesToSkipCSV.SetRDefault(0)

        'temp disabled until can easily switch between fread and read.csv
        'disabled until issue is resolved: http://stackoverflow.com/questions/37635541/rio-r-package-can-i-import-a-csv-file-with-non-comma-separator
        ucrInputSeparatorCSV.Enabled = False
        ucrPnlRowNamesCSV.Enabled = False
        rdoRowNamesYesCSV.Enabled = False
        rdoRowNamesNoCSV.Enabled = False

        '##############################################################

        'EXCEL controls
        ucrInputSelectSheetExcel.SetDropDownStyleAsNonEditable()
        ucrInputSelectSheetExcel.bAllowNonConditionValues = True

        ucrInputMissingValueStringExcel.SetParameter(New RParameter("na"))
        ucrInputMissingValueStringExcel.SetRDefault(Chr(34) & "" & Chr(34))

        ucrChkTrimWSExcel.SetParameter(New RParameter("trim_ws"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkTrimWSExcel.SetText("Trim Trailing White Space")

        ucrNudRowsToSkipExcel.SetParameter(New RParameter("skip"))
        ucrNudRowsToSkipExcel.Minimum = 0
        ucrNudRowsToSkipExcel.SetRDefault(0)

        ucrChkMaxRowsExcel.SetText("Maximum Rows To Import")
        ucrChkMaxRowsExcel.AddParameterPresentCondition(True, "n_max", True)
        ucrChkMaxRowsExcel.AddParameterPresentCondition(False, "n_max", False)
        ucrChkMaxRowsExcel.AddToLinkedControls(ucrInputMaxRowsExcel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1000000)

        ucrInputMaxRowsExcel.SetParameter(New RParameter("n_max"))
        ucrInputMaxRowsExcel.AddQuotesIfUnrecognised = False
        ucrInputMaxRowsExcel.SetValidationTypeAsNumeric()

        'hide since no longer using openxlsx package
        ucrInputNamedRegions.Hide()
        lblNamedRegion.Hide()
    End Sub

    Private Sub SetDefaults()
        clsImportCSV = New RFunction
        clsImportRDS = New RFunction
        clsImportExcel = New RFunction
        clsImport = New RFunction
        clsReadRDS = New RFunction
        clsImportDAT = New RFunction
        clsGetExcelSheetNames = New RFunction

        clsImportExcel.SetPackageName("rio")
        clsImportExcel.SetRCommand("import")
        clsImportExcel.AddParameter("guess_max", "Inf")

        clsImportCSV.SetPackageName("rio")
        clsImportCSV.SetRCommand("import")
        clsImportCSV.AddParameter("stringsAsFactors", "TRUE")

        clsImport.SetPackageName("rio")
        clsImport.SetRCommand("import")

        clsImportDAT.SetPackageName("rio")
        clsImportDAT.SetRCommand("import")
        'Needed as rio currently doesn't support .DAT files
        'https://github.com/leeper/rio/issues/155
        'This only works if .DAT file is text based, this seems to be common usage
        clsImportDAT.AddParameter("format", Chr(34) & "txt" & Chr(34))

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.SetAssignTo("new_RDS")

        clsGetExcelSheetNames.SetPackageName("readxl")
        clsGetExcelSheetNames.SetRCommand("excel_sheets")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        ucrNudPreviewLines.Value = 10

        grpCSV.Hide()
        grpRDS.Hide()
        grpExcel.Hide()
        txtTextFilePreview.Hide()
        lblTextFilePreview.Hide()
        lblNoPreview.Hide()
        lblCannotImport.Hide()
        lblDataFrame.Hide()
        grdDataPreview.Hide()
        ucrSaveFile.Hide()
    End Sub

    'Private Sub ucrInputName_NameChanged() Handles ucrInputName.ControlValueChanged
    '    If Not ucrInputName.IsEmpty AndAlso strFileType <> "RDS" Then
    '        ucrBase.clsRsyntax.SetAssignTo(ucrInputName.GetText(), strTempDataframe:=ucrInputName.GetText())
    '    Else
    '        ucrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    '    TestOkEnabled()
    'End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        RefreshFrameView()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If (ucrSaveFile.IsComplete OrElse strFileType = "RDS") AndAlso bCanImport Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html;|All files|*.*;"
            If bFromLibrary Then
                dlgOpen.Title = "Import from Library"
                dlgOpen.InitialDirectory = strLibraryPath
                bFromLibrary = False
            Else
                dlgOpen.Title = "Open Data from file"
                If strCurrentDirectory <> "" Then
                    dlgOpen.InitialDirectory = strCurrentDirectory
                Else
                    dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
                End If
            End If

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                ucrSaveFile.Reset()
                If dlgOpen.FileName <> "" Then
                    SetControlsFromFile(dlgOpen.FileName)
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
                    txtTextFilePreview.Hide()
                    lblTextFilePreview.Hide()
                End If
            End If
            TestOkEnabled()
        End Using
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportCSV, New RParameter("file", 0), iAdditionalPairNo:=1)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportDAT, New RParameter("file", 0), iAdditionalPairNo:=2)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcel, New RParameter("file", 0), iAdditionalPairNo:=3)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsReadRDS, New RParameter("file", 0), iAdditionalPairNo:=4)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsGetExcelSheetNames, New RParameter("path", 0), iAdditionalPairNo:=5)
        ucrInputFilePath.SetRCode(clsImport, bReset)

        ucrSaveFile.AddAdditionalRCode(clsImportCSV, iAdditionalPairNo:=1)
        ucrSaveFile.AddAdditionalRCode(clsImportDAT, iAdditionalPairNo:=2)
        ucrSaveFile.AddAdditionalRCode(clsImportExcel, iAdditionalPairNo:=3)
        ucrSaveFile.SetRCode(clsImport, bReset)

        'ucrInputSeparatorCSV.SetRCode(clsImportCSV, bReset)
        'ucrPnlRowNamesCSV.SetRCode(clsImportCSV, bReset)
        ucrInputHeadersCSV.SetRCode(clsImportCSV, bReset)
        ucrInputDecimalCSV.SetRCode(clsImportCSV, bReset)
        ucrInputEncodingCSV.SetRCode(clsImportCSV, bReset)
        ucrChkStringsAsFactorsCSV.SetRCode(clsImportCSV, bReset)
        ucrInputNAStringsCSV.SetRCode(clsImportCSV, bReset)
        ucrNudLinesToSkipCSV.SetRCode(clsImportCSV, bReset)

        ucrChkImportChangesLogRDS.SetRCode(clsImportRDS, bReset)
        ucrChkKeepExistingDataRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportMetadataRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportObjectsRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportFiltersRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportCalculationsRDS.SetRCode(clsImportRDS, bReset)
        ucrChkOverwriteRDS.SetRCode(clsImportRDS, bReset)

        ucrNudRowsToSkipExcel.SetRCode(clsImportExcel, bReset)
        ucrInputMaxRowsExcel.SetRCode(clsImportExcel, bReset)
        ucrChkMaxRowsExcel.SetRCode(clsImportExcel, bReset)
        ucrInputSelectSheetExcel.SetRCode(clsImportExcel, bReset)
        ucrInputMissingValueStringExcel.SetRCode(clsImportExcel, bReset)
        ucrChkTrimWSExcel.SetRCode(clsImportExcel, bReset)
    End Sub

    Private Sub TextPreviewVisible(bVisible As Boolean)
        txtTextFilePreview.Visible = bVisible
        lblTextFilePreview.Visible = bVisible
    End Sub

    Private Sub GridPreviewVisible(bVisible As Boolean)
        grdDataPreview.Visible = bVisible
        lblDataFrame.Visible = bVisible
    End Sub

    Private Sub LinesToPreviewVisible(bVisible As Boolean)
        lblLinesToPreview.Visible = bVisible
        ucrNudPreviewLines.Visible = bVisible
    End Sub

    Public Sub SetControlsFromFile(strFilePath As String)
        Dim strFileExt As String
        Dim strFileName As String
        Dim strValidName As String

        If strFilePath <> "" Then
            strFileName = Path.GetFileNameWithoutExtension(strFilePath)
            strFileExt = Path.GetExtension(strFilePath).ToLower()
            strFilePathSystem = strFilePath
            strFilePathR = Replace(strFilePath, "\", "/")
            strCurrentDirectory = Path.GetDirectoryName(strFilePath)
        Else
            strFileName = ""
            strFileExt = ""
            strFilePathSystem = ""
            strFilePathR = ""
        End If

        ucrInputFilePath.SetName(strFilePathR)

        ucrSaveFile.Show()
        grpRDS.Hide()
        grpExcel.Hide()
        grpCSV.Hide()

        'TODO This needs to be different when RDS is a data frame
        'need to be able to detect RDS as data.frame/Instat Object
        If strFileExt = ".rds" Then
            strFileType = "RDS"
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
            clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
            grpRDS.Show()
            ucrSaveFile.Hide()
        ElseIf strFileExt = ".csv" Then
            strFileType = "CSV"
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            TextPreviewVisible(True)
            grpCSV.Show()
        ElseIf strFileExt = ".dat" Then
            strFileType = "DAT"
            clsImportDAT.AddParameter("file", Chr(34) & strFilePathR & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportDAT)
        ElseIf strFileExt = ".xlsx" OrElse strFileExt = ".xls" Then
            If strFileExt = ".xlsx" Then
                strFileType = "XLSX"
            Else
                strFileType = "XLS"
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            grpExcel.Show()
            FillExcelSheets(strFilePath)
        ElseIf strFileExt <> "" Then
            strFileType = strFileExt.Substring(1).ToUpper()
            ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
        Else
            strFileType = ""
        End If
        If strFileType <> "" AndAlso strFileType <> "RDS" Then
            ucrSaveFile.Visible = True
            strValidName = frmMain.clsRLink.MakeValidText(strFileName)
            ucrSaveFile.SetName(strValidName, bSilent:=True)
        Else
            ucrSaveFile.Visible = False
        End If
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Public Sub RefreshFilePreview()
        If bDialogLoaded Then
            If strFileType = "CSV" AndAlso strFilePathSystem <> "" Then
                TextPreviewVisible(True)
                Try
                    Using sReader As New StreamReader(strFilePathSystem)
                        txtTextFilePreview.Text = ""
                        For i = 1 To ucrNudPreviewLines.Value + ucrNudLinesToSkipCSV.Value + 1
                            txtTextFilePreview.Text = txtTextFilePreview.Text & sReader.ReadLine() & Environment.NewLine
                            If sReader.Peek() = -1 Then
                                Exit For
                            End If
                        Next
                    End Using
                Catch ex As Exception
                    txtTextFilePreview.Text = "Cannot show text preview of file:" & strFilePathSystem & ". The file may have moved or be in use by another program. Close the file and select it again from the dialog to refresh the preview."
                    bCanImport = False
                End Try
            Else
                TextPreviewVisible(False)
            End If
        End If
    End Sub

    Private Sub RefreshFrameView()
        Dim dfTemp As DataFrame
        Dim expTemp As SymbolicExpression
        Dim strTempDataFrameName As String
        Dim bValid As Boolean
        Dim clsAsCharacterFunc As New RFunction
        Dim clsTempImport As New RFunction
        Dim iTemp As Integer
        Dim strRowMaxParamName As String = ""

        If bDialogLoaded Then
            Cursor = Cursors.WaitCursor
            ucrBase.OKEnabled(False)
            clsAsCharacterFunc.SetRCommand("convert_to_character_matrix")
            strTempDataFrameName = "temp"
            grdDataPreview.Worksheets.Clear()
            grdDataPreview.Enabled = False
            lblCannotImport.Hide()
            bValid = False
            If {"CSV", "XLSX", "XLS"}.Contains(strFileType) AndAlso Not ucrInputFilePath.IsEmpty() Then
                If strFileType = "CSV" Then
                    clsTempImport = clsImportCSV.Clone()
                    strRowMaxParamName = "nrows"
                ElseIf strFileType = "XLSX" OrElse strFileType = "XLS" Then
                    clsTempImport = clsImportExcel.Clone()
                    strRowMaxParamName = "n_max"
                End If
                If clsTempImport.ContainsParameter(strRowMaxParamName) Then
                    If Integer.TryParse(clsTempImport.GetParameter(strRowMaxParamName).strArgumentValue, iTemp) Then
                        clsTempImport.AddParameter(strRowMaxParamName, Math.Min(iTemp, ucrNudPreviewLines.Value))
                    Else
                        clsTempImport.AddParameter(strRowMaxParamName, ucrNudPreviewLines.Value)
                    End If
                Else
                    clsTempImport.AddParameter(strRowMaxParamName, ucrNudPreviewLines.Value)
                End If
                clsTempImport.RemoveAssignTo()
                clsAsCharacterFunc.AddParameter("data", clsRFunctionParameter:=clsTempImport)
                expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunc.ToScript(), bSilent:=True)
                If expTemp IsNot Nothing Then
                    dfTemp = expTemp.AsDataFrame
                    If dfTemp IsNot Nothing Then
                        Try
                            frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=False, iColMax:=frmMain.clsGrids.iMaxCols)
                            grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
                            grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
                            grdDataPreview.Enabled = True
                            bValid = True
                            bCanImport = True
                        Catch

                        End Try
                    End If
                End If
                If bValid Then
                    GridPreviewVisible(True)
                    LinesToPreviewVisible(True)
                    lblNoPreview.Hide()
                    cmdRefreshPreview.Enabled = True
                Else
                    lblCannotImport.Show()
                    bCanImport = False
                End If
            ElseIf ucrInputFilePath.IsEmpty() Then
                bCanImport = False
                lblCannotImport.Hide()
                lblNoPreview.Hide()
                GridPreviewVisible(False)
                LinesToPreviewVisible(False)
                cmdRefreshPreview.Enabled = False
            Else
                bCanImport = True
                lblCannotImport.Hide()
                lblNoPreview.Show()
                GridPreviewVisible(False)
                LinesToPreviewVisible(False)
                cmdRefreshPreview.Enabled = False
            End If
            Cursor = Cursors.Default
            TestOkEnabled()
        End If
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub FillExcelSheets(strFilePath As String)
        Dim i As Integer
        Dim expSheet As SymbolicExpression
        Dim chrSheets As CharacterVector

        expSheet = frmMain.clsRLink.RunInternalScriptGetValue(clsGetExcelSheetNames.ToScript())
        If expSheet IsNot Nothing Then
            chrSheets = expSheet.AsCharacter
        Else
            chrSheets = Nothing
        End If

        ucrInputSelectSheetExcel.SetItems()
        If chrSheets IsNot Nothing AndAlso chrSheets.Count > 0 Then
            ucrInputSelectSheetExcel.SetItems(chrSheets.ToArray)
            ucrInputSelectSheetExcel.SetName(ucrInputSelectSheetExcel.cboInput.Items(0), bSilent:=True)
        Else
            ucrInputSelectSheetExcel.SetName("")
        End If

        'ucrInputNamedRegions.cboInput.Items.Clear()
        'If chrRegions IsNot Nothing AndAlso chrRegions.Count > 0 Then
        '    For i = 0 To chrRegions.Count - 1
        '        ucrInputNamedRegions.cboInput.Items.Add(chrRegions(i))
        '    Next
        'End If
        'ucrInputNamedRegions.SetName("")
    End Sub

    'Private Sub ucrchkColumnNames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrchkColumnNames.ControlValueChanged
    '    XlColNamesParameter()
    'End Sub

    'Private Sub XlColNamesParameter()
    '    Dim strColNameParam As String

    '    If strFileType = "xlsx" Then
    '        strColNameParam = "colNames"
    '        clsImportExcel.RemoveParameterByName("col_names")
    '    Else
    '        strColNameParam = "col_names"
    '        clsImportExcel.RemoveParameterByName("colNames")
    '    End If

    '    If ucrchkColumnNames.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsImportExcel.AddParameter(strColNameParam, "TRUE")
    '        Else
    '            clsImportExcel.RemoveParameterByName(strColNameParam)
    '        End If
    '    Else
    '        clsImportExcel.AddParameter(strColNameParam, "FALSE")
    '    End If
    '    RefreshFrameView()
    'End Sub


    Private Sub lblRowVector_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMetaData.Show()
    End Sub

    'Not implemented yet
    'Private Sub rdoRowNames_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRowNamesYes.CheckedChanged, rdoRowNamesNo.CheckedChanged
    '    If rdoRowNamesYes.Checked Then
    '        'TODO this is not an option for fread so have to change function here
    '        clsReadCSV.AddParameter("row.names", 1)
    '    Else
    '        'TODO find out what difference there is between
    '        'row.names = NULL and row.names missing
    '        'disabled as import (fread) does not support row.names
    '        'clsReadCSV.AddParameter("row.names", "NULL")
    '        clsReadCSV.RemoveParameterByName("row.names")
    '    End If
    'End Sub

    Private Sub ucrInputSheets_ControlValueChanged() Handles ucrInputSelectSheetExcel.ControlValueChanged
        If strFileType = "XLS" OrElse strFileType = "XLSX" Then
            If Not ucrInputSelectSheetExcel.IsEmpty() Then
                clsImportExcel.AddParameter("which", ucrInputSelectSheetExcel.cboInput.SelectedIndex + 1)
                If Not ucrSaveFile.UserTyped() Then
                    ucrSaveFile.SetName(ucrInputSelectSheetExcel.GetText(), bSilent:=True)
                End If
            End If
            RefreshFrameView()
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'Gets the current number of (visible) data frame before importing
        'So correct current data frame can be set after
        iDataFrameCount = frmMain.GetDataFrameCount()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ' add the item to the MRU (Most Recently Used) list...
        'Disabled until implemented correctly
        frmMain.clsRecentItems.addToMenu(strFilePathSystem)
        'Sets the current data frame as the first new data frame
        'Needed so that if multiple data frames imported, the last one is not the current data frame
        frmMain.SetCurrentDataFrame(iDataFrameCount)
    End Sub

    Private Sub CSVControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkStringsAsFactorsCSV.ControlValueChanged, ucrInputNAStringsCSV.ControlValueChanged, ucrInputEncodingCSV.ControlValueChanged, ucrInputSeparatorCSV.ControlValueChanged, ucrInputHeadersCSV.ControlValueChanged, ucrInputDecimalCSV.ControlValueChanged, ucrNudLinesToSkipCSV.ControlValueChanged, ucrPnlRowNamesCSV.ControlValueChanged
        RefreshFrameView()
    End Sub

    Private Sub ucrNudPreviewLines_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudPreviewLines.ControlContentsChanged
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Private Sub ExcelControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMaxRowsExcel.ControlValueChanged, ucrChkTrimWSExcel.ControlValueChanged, ucrNudRowsToSkipExcel.ControlValueChanged, ucrChkMaxRowsExcel.ControlValueChanged, ucrInputMaxRowsExcel.ControlValueChanged, ucrInputMissingValueStringExcel.ControlValueChanged
        RefreshFrameView()
    End Sub
End Class