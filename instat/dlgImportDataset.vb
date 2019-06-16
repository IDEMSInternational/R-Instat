﻿' R- Instat
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

Imports System.IO
Imports RDotNet
Imports instat.Translations

Public Class dlgImportDataset

    Private clsImportFixedWidthText, clsImportCSV, clsImportDAT, clsImportRDS, clsReadRDS, clsImportExcel, clsImport As RFunction
    Private clsGetExcelSheetNames As RFunction
    ' Functions for multi file import
    Private clsLapply As RFunction
    Private clsFileList As RFunction
    ' Functions for multi Excel sheet impoty
    Private clsImportExcelMulti As RFunction
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
    Private bMultiFiles As Boolean

    Private strFileName As String

    Private bSupressCheckAllSheets As Boolean = False
    Private bSupressSheetChange As Boolean = False

    Dim dctSelectedExcelSheets As New Dictionary(Of Integer, String)

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
            'if none of the above then try setting the displayed values from the previous contents of ucrInputFilePath.
            If Not String.IsNullOrEmpty(ucrInputFilePath.GetText()) Then
                If File.Exists(ucrInputFilePath.GetText()) Then
                    SetControlsFromFile(ucrInputFilePath.GetText())
                    bDialogLoaded = True
                    RefreshFilePreview()
                    RefreshFrameView()
                Else
                    MsgBox("File no longer exists: " & strFilePathSystem, MsgBoxStyle.Information, "File No Longer Exists")
                    SetControlsFromFile("")
                    bDialogLoaded = True
                    RefreshFilePreview()
                    RefreshFrameView()
                End If
            End If
        End If

        'temprary fix for autotranslate(me) translating this to Label1. Can be removed after that
        ucrSaveFile.SetLabelText("New Data Frame Name:")
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

        '##############################################################

        'CSV Controls

        ucrChkStringsAsFactorsCSV.SetText("Convert Strings to Factor Columns")
        ucrChkStringsAsFactorsCSV.SetParameter(New RParameter("stringsAsFactors"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkStringsAsFactorsCSV.SetRDefault("FALSE")

        ucrInputMissingValueStringCSV.SetParameter(New RParameter("na.strings"))
        ucrInputMissingValueStringCSV.SetRDefault(Chr(34) & "NA" & Chr(34))

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

        ucrNudRowsToSkipCSV.SetParameter(New RParameter("skip"))
        ucrNudRowsToSkipCSV.Maximum = Integer.MaxValue
        ucrNudRowsToSkipCSV.SetRDefault(0)

        ucrChkMaxRowsCSV.SetText("Maximum Rows To Import")
        ucrChkMaxRowsCSV.AddParameterPresentCondition(True, "nrows", True)
        ucrChkMaxRowsCSV.AddParameterPresentCondition(False, "nrows", False)
        ucrChkMaxRowsCSV.AddToLinkedControls(ucrNudMaxRowsCSV, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1000000)

        ucrNudMaxRowsCSV.SetParameter(New RParameter("nrows"))
        ucrNudMaxRowsCSV.Minimum = 0
        ucrNudMaxRowsCSV.Maximum = Decimal.MaxValue

        '##############################################################
        'EXCEL controls
        ucrInputMissingValueStringExcel.SetParameter(New RParameter("na"))
        ucrInputMissingValueStringExcel.SetRDefault(Chr(34) & "" & Chr(34))

        ucrChkTrimWSExcel.SetText("Trim Trailing White Space")
        ucrChkTrimWSExcel.SetParameter(New RParameter("trim_ws"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkTrimWSExcel.SetRDefault("TRUE")

        ucrNudRowsToSkipExcel.SetParameter(New RParameter("skip"))
        ucrNudRowsToSkipExcel.Minimum = 0
        ucrNudRowsToSkipExcel.SetRDefault(0)

        ucrChkColumnNamesExcel.SetText("First Row is Column Headers")
        ucrChkColumnNamesExcel.SetParameter(New RParameter("col_names"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumnNamesExcel.SetRDefault("TRUE")

        ucrChkMaxRowsExcel.SetText("Maximum Rows To Import")
        ucrChkMaxRowsExcel.AddParameterPresentCondition(True, "n_max", True)
        ucrChkMaxRowsExcel.AddParameterPresentCondition(False, "n_max", False)
        ucrChkMaxRowsExcel.AddToLinkedControls(ucrNudMaxRowsExcel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1000000)

        ucrNudMaxRowsExcel.SetParameter(New RParameter("n_max"))
        ucrNudMaxRowsExcel.Minimum = 0
        ucrNudMaxRowsExcel.Maximum = Decimal.MaxValue

        ucrChkSheetsCheckAll.SetText("Select All")

        'hide since no longer using openxlsx package
        ucrInputNamedRegions.Hide()
        lblNamedRegion.Hide()

        '##############################################################
        'Text controls
        ucrPanelFixedWidthText.AddRadioButton(rdoSeparatortext)
        ucrPanelFixedWidthText.AddRadioButton(rdoFixedWidthText)
        ucrPanelFixedWidthText.AddRadioButton(rdoFixedWidthWhiteSpacesText)
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoSeparatortext, {"read_table", "read_table2"}, bNewIsPositive:=False)
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthText, "read_table", bNewIsPositive:=True)
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthWhiteSpacesText, "read_table2", bNewIsPositive:=True)

        ucrChkColumnNamesText.SetText("First Row is Column Headers")
        ucrChkColumnNamesText.SetParameter(New RParameter("col_names"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumnNamesText.SetRDefault("TRUE")

        ucrInputMissingValueStringText.SetParameter(New RParameter("na"))
        ucrInputMissingValueStringText.SetRDefault(Chr(34) & "NA" & Chr(34))

        ucrNudRowsToSkipText.SetParameter(New RParameter("skip"))
        ucrNudRowsToSkipText.Minimum = 0
        ucrNudRowsToSkipText.SetRDefault(0)

        ucrChkMaxRowsText.SetText("Maximum Rows To Import")
        ucrChkMaxRowsText.AddParameterPresentCondition(True, "n_max", True)
        ucrChkMaxRowsText.AddParameterPresentCondition(False, "n_max", False)
        ucrChkMaxRowsText.AddToLinkedControls(ucrNudMaxRowsText, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1000000)

        ucrNudMaxRowsText.SetParameter(New RParameter("n_max"))
        ucrNudMaxRowsText.Minimum = 0
        ucrNudMaxRowsText.Maximum = Decimal.MaxValue

    End Sub

    Private Sub SetDefaults()
        clsImportFixedWidthText = New RFunction
        clsImportCSV = New RFunction
        clsImportRDS = New RFunction
        clsImportExcel = New RFunction
        clsImport = New RFunction
        clsReadRDS = New RFunction
        clsImportDAT = New RFunction
        clsGetExcelSheetNames = New RFunction

        clsLapply = New RFunction

        clsImportExcelMulti = New RFunction
        clsFileList = New RFunction

        clsImportFixedWidthText.SetPackageName("readr")
        clsImportFixedWidthText.SetRCommand("read_table")

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

        clsLapply.SetRCommand("lappy")
        clsLapply.AddParameter("X", clsRFunctionParameter:=clsFileList, iPosition:=0)

        clsImportExcelMulti.SetPackageName("rio")
        clsImportExcelMulti.SetRCommand("import_list")

        clsFileList.SetRCommand("c")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        ucrBase.clsRsyntax.SetBaseRFunction(clsImport)

        strFilePathSystem = ""
        strCurrentDirectory = ""
        strFilePathR = ""
        strFileType = ""

        ucrNudPreviewLines.Value = 10

        ucrPanelFixedWidthText.Hide()
        grpText.Hide()
        grpCSV.Hide()
        grpRDS.Hide()
        grpExcel.Hide()
        clbSheets.Hide()
        lblSelectSheets.Hide()
        ucrChkSheetsCheckAll.Hide()
        TextPreviewVisible(False)
        lblNoPreview.Hide()
        lblCannotImport.Hide()
        GridPreviewVisible(False)
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
            If strFileType = "XLSX" OrElse strFileType = "XLS" Then
                ucrBase.OKEnabled(dctSelectedExcelSheets.Count > 0)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html;|All files|*.*;"
            dlgOpen.Multiselect = False
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
                'TODO This is in place for when we allow multiple files selected.
                bMultiFiles = (dlgOpen.FileNames.Count > 1)
                If NumberOfFileTypes(dlgOpen.FileNames) > 1 Then
                    MsgBox("All files must be of the same type", MsgBoxStyle.Information, "Multiple file types")
                    SetControlsFromFile("")
                Else
                    If dlgOpen.FileName <> "" Then
                        SetControlsFromFile(dlgOpen.FileName)
                    End If
                End If
            Else
                If bFromLibrary Then
                    'TODO something like this so that the Import dialog closes
                    '     when using open from library but library dialog stays open
                    'bFromLibrary = False
                    'Me.Close()
                End If
                If ucrInputFilePath.GetText() = "" Then
                    grpText.Hide()
                    grpCSV.Hide()
                    grpExcel.Hide()
                    clbSheets.Hide()
                    lblSelectSheets.Hide()
                    ucrChkSheetsCheckAll.Hide()
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
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportFixedWidthText, New RParameter("file", 0), iAdditionalPairNo:=1)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportCSV, New RParameter("file", 0), iAdditionalPairNo:=2)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportDAT, New RParameter("file", 0), iAdditionalPairNo:=3)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcel, New RParameter("file", 0), iAdditionalPairNo:=4)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsReadRDS, New RParameter("file", 0), iAdditionalPairNo:=5)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsGetExcelSheetNames, New RParameter("path", 0), iAdditionalPairNo:=6)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("file", 0), iAdditionalPairNo:=7)
        ucrInputFilePath.SetRCode(clsImport, bReset)

        'Save control
        ucrSaveFile.AddAdditionalRCode(clsImportFixedWidthText, iAdditionalPairNo:=1)
        ucrSaveFile.AddAdditionalRCode(clsImportCSV, iAdditionalPairNo:=2)
        ucrSaveFile.AddAdditionalRCode(clsImportDAT, iAdditionalPairNo:=3)
        ucrSaveFile.AddAdditionalRCode(clsImportExcel, iAdditionalPairNo:=4)
        ucrSaveFile.AddAdditionalRCode(clsImportExcelMulti, iAdditionalPairNo:=5)
        ucrSaveFile.SetRCode(clsImport, bReset)

        'Used by both text and csv functions
        ucrPanelFixedWidthText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        'TEXT CONTROLS 
        ucrChkColumnNamesText.SetRCode(clsImportFixedWidthText, bReset)
        ucrInputMissingValueStringText.SetRCode(clsImportFixedWidthText, bReset)
        ucrNudRowsToSkipText.SetRCode(clsImportFixedWidthText, bReset)
        ucrNudMaxRowsText.SetRCode(clsImportFixedWidthText, bReset)
        ucrChkMaxRowsText.SetRCode(clsImportFixedWidthText, bReset)

        'CSV CONTROLS
        ucrInputSeparatorCSV.SetRCode(clsImportCSV, bReset)
        ucrInputHeadersCSV.SetRCode(clsImportCSV, bReset)
        ucrInputDecimalCSV.SetRCode(clsImportCSV, bReset)
        ucrInputEncodingCSV.SetRCode(clsImportCSV, bReset)
        ucrChkStringsAsFactorsCSV.SetRCode(clsImportCSV, bReset)
        ucrInputMissingValueStringCSV.SetRCode(clsImportCSV, bReset)
        ucrNudRowsToSkipCSV.SetRCode(clsImportCSV, bReset)
        ucrNudMaxRowsCSV.SetRCode(clsImportCSV, bReset)
        ucrChkMaxRowsCSV.SetRCode(clsImportCSV, bReset)

        'RDS CONTROLS
        ucrChkImportChangesLogRDS.SetRCode(clsImportRDS, bReset)
        ucrChkKeepExistingDataRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportMetadataRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportObjectsRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportFiltersRDS.SetRCode(clsImportRDS, bReset)
        ucrChkImportCalculationsRDS.SetRCode(clsImportRDS, bReset)
        ucrChkOverwriteRDS.SetRCode(clsImportRDS, bReset)

        'EXCEL CONTROLS
        ucrNudRowsToSkipExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("skip"), iAdditionalPairNo:=1)
        ucrInputMissingValueStringExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("na"), iAdditionalPairNo:=1)
        ucrChkTrimWSExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("trim_ws"), iAdditionalPairNo:=1)
        ucrChkColumnNamesExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("col_names"), iAdditionalPairNo:=1)
        ucrNudMaxRowsExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("n_max"), iAdditionalPairNo:=1)
        ucrChkMaxRowsExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("n_max"), iAdditionalPairNo:=1)

        ucrNudRowsToSkipExcel.SetRCode(clsImportExcel, bReset)
        ucrInputMissingValueStringExcel.SetRCode(clsImportExcel, bReset)
        ucrChkTrimWSExcel.SetRCode(clsImportExcel, bReset)
        ucrChkColumnNamesExcel.SetRCode(clsImportExcel, bReset)
        ucrNudMaxRowsExcel.SetRCode(clsImportExcel, bReset)
        ucrChkMaxRowsExcel.SetRCode(clsImportExcel, bReset)
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

        strFileName = ""
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

        grpText.Hide()
        ucrPanelFixedWidthText.Hide()
        grpRDS.Hide()
        grpExcel.Hide()
        clbSheets.Hide()
        lblSelectSheets.Hide()
        ucrChkSheetsCheckAll.Hide()
        grpCSV.Hide()
        'TODO This needs to be different when RDS is a data frame
        'need to be able to detect RDS as data.frame/Instat Object
        If strFileExt = ".rds" Then
            strFileType = "RDS"
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
            clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
            grpRDS.Show()
        ElseIf strFileExt = ".txt" Then
            strFileType = "TXT"
            'by default the textfiles will be imported using the function we use for csv
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            ucrPanelFixedWidthText.Show()
            grpCSV.Text = "Import Text Options"
            grpCSV.Show()
        ElseIf strFileExt = ".csv" Then
            strFileType = "CSV"
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            grpCSV.Text = "Import CSV Options"
            grpCSV.Show()
        ElseIf strFileExt = ".dat" Then
            strFileType = "DAT"
            clsImportDAT.AddParameter("file", Chr(34) & strFilePathR & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportDAT)
        ElseIf strFileExt = ".xlsx" OrElse strFileExt = ".xls" Then
            strFileType = If(strFileExt = ".xlsx", "XLSX", "XLS")
            If clbSheets.CheckedItems.Count > 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcelMulti)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            End If
            grpExcel.Show()
            clbSheets.Show()
            lblSelectSheets.Show()
            ucrChkSheetsCheckAll.Show()
            FillExcelSheets(strFilePath)
        ElseIf strFileExt <> "" Then
            strFileType = strFileExt.Substring(1).ToUpper()
            ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
        Else
            strFileType = ""
        End If
        If strFileType <> "" AndAlso strFileType <> "RDS" Then
            ucrSaveFile.Show()
            ucrSaveFile.SetName(frmMain.clsRLink.MakeValidText(strFileName), bSilent:=True)
        Else
            ucrSaveFile.Hide()
        End If
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Public Sub RefreshFilePreview(Optional strNewFileType As String = "")
        Dim rowsToSkip As Integer
        If bDialogLoaded Then
            If strNewFileType = "" Then
                strNewFileType = strFileType
            End If
            If (strNewFileType = "CSV" OrElse strNewFileType = "TXT") AndAlso strFilePathSystem <> "" Then
                TextPreviewVisible(True)
                rowsToSkip = If(strNewFileType = "CSV", ucrNudRowsToSkipCSV.Value, ucrNudRowsToSkipText.Value)
                Try
                    Using sReader As New StreamReader(strFilePathSystem)
                        txtTextFilePreview.Text = ""
                        For i = 1 To ucrNudPreviewLines.Value + rowsToSkip + 1
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
            lblImportingSheets.Hide()
            lblImportingSheets.Text = ""
            bValid = False
            If {"TXT", "CSV", "XLSX", "XLS"}.Contains(strFileType) AndAlso Not ucrInputFilePath.IsEmpty() Then
                If strFileType = "TXT" Then
                    If rdoSeparatortext.Checked Then
                        'for separtor we use the function used for csv
                        clsTempImport = clsImportCSV.Clone()
                        strRowMaxParamName = "nrows"
                        clsTempImport.AddParameter("na.strings", Chr(34) & ucrInputMissingValueStringCSV.GetText & Chr(34))
                    Else
                        clsTempImport = clsImportFixedWidthText.Clone()
                        strRowMaxParamName = "n_max"
                        clsTempImport.AddParameter("na", Chr(34) & ucrInputMissingValueStringText.GetText & Chr(34))
                    End If

                ElseIf strFileType = "CSV" Then
                    clsTempImport = clsImportCSV.Clone()
                    strRowMaxParamName = "nrows"
                    clsTempImport.AddParameter("na.strings", Chr(34) & ucrInputMissingValueStringCSV.GetText & Chr(34))
                ElseIf strFileType = "XLSX" OrElse strFileType = "XLS" Then
                    If dctSelectedExcelSheets.Count = 0 Then
                        bCanImport = False
                        lblCannotImport.Hide()
                        lblNoPreview.Show()
                        lblImportingSheets.Show()
                        lblImportingSheets.Text = "No sheet selected."
                        GridPreviewVisible(False)
                        LinesToPreviewVisible(False)
                        cmdRefreshPreview.Enabled = False
                        Cursor = Cursors.Default
                        TestOkEnabled()
                        Exit Sub
                        ' TODO temp until multi sheet preview implemented
                    ElseIf dctSelectedExcelSheets.Count > 1 Then
                        bCanImport = True
                        lblCannotImport.Hide()
                        lblNoPreview.Show()
                        lblImportingSheets.Show()
                        lblImportingSheets.Text = "Importing the following sheets:" & Environment.NewLine & String.Join(", ", dctSelectedExcelSheets.Values)
                        GridPreviewVisible(False)
                        LinesToPreviewVisible(False)
                        cmdRefreshPreview.Enabled = False
                        Cursor = Cursors.Default
                        TestOkEnabled()
                        Exit Sub
                    End If
                    clsTempImport = clsImportExcel.Clone()
                    strRowMaxParamName = "n_max"
                    clsTempImport.AddParameter("na", Chr(34) & ucrInputMissingValueStringExcel.GetText & Chr(34))
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
        Dim expSheet As SymbolicExpression
        Dim chrSheets As CharacterVector

        expSheet = frmMain.clsRLink.RunInternalScriptGetValue(clsGetExcelSheetNames.ToScript())
        If expSheet IsNot Nothing Then
            chrSheets = expSheet.AsCharacter
        Else
            chrSheets = Nothing
        End If

        clbSheets.Items.Clear()
        If chrSheets IsNot Nothing AndAlso chrSheets.Count > 0 Then
            clbSheets.Items.AddRange(chrSheets.ToArray())
            clbSheets.SetItemChecked(0, True)
        End If

        'ucrInputNamedRegions.cboInput.Items.Clear()
        'If chrRegions IsNot Nothing AndAlso chrRegions.Count > 0 Then
        '    For i = 0 To chrRegions.Count - 1
        '        ucrInputNamedRegions.cboInput.Items.Add(chrRegions(i))
        '    Next
        'End If
        'ucrInputNamedRegions.SetName("")
    End Sub

    Private Sub lblRowVector_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmMetaData.Show()
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

    Private Sub ucrNudPreviewLines_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudPreviewLines.ControlContentsChanged
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
        RefreshFilePreview()
        RefreshFrameView()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTrimWSExcel.ControlValueChanged, ucrNudRowsToSkipExcel.ControlValueChanged, ucrChkColumnNamesExcel.ControlValueChanged, ucrChkColumnNamesText.ControlValueChanged, ucrNudRowsToSkipText.ControlValueChanged, ucrChkMaxRowsText.ControlValueChanged, ucrChkMaxRowsCSV.ControlValueChanged, ucrChkMaxRowsExcel.ControlValueChanged, ucrNudMaxRowsText.ControlValueChanged, ucrNudMaxRowsCSV.ControlValueChanged, ucrNudMaxRowsExcel.ControlValueChanged, ucrChkStringsAsFactorsCSV.ControlValueChanged, ucrInputMissingValueStringCSV.ControlValueChanged, ucrInputEncodingCSV.ControlValueChanged, ucrInputSeparatorCSV.ControlValueChanged, ucrInputHeadersCSV.ControlValueChanged, ucrInputDecimalCSV.ControlValueChanged, ucrNudRowsToSkipCSV.ControlValueChanged
        RefreshFrameView()
    End Sub

    Private Sub MissingValuesInputControls_ContentsChanged() Handles ucrInputMissingValueStringText.ContentsChanged, ucrInputMissingValueStringCSV.ContentsChanged, ucrInputMissingValueStringExcel.ContentsChanged
        RefreshFrameView()
    End Sub

    Private Sub UcrPanelFixedWidthText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPanelFixedWidthText.ControlValueChanged
        If strFileType = "TXT" Then
            grpCSV.Visible = False
            grpText.Visible = False
            If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
                If rdoFixedWidthText.Checked Then
                    clsImportFixedWidthText.SetRCommand("read_table")
                Else
                    clsImportFixedWidthText.SetRCommand("read_table2")
                End If
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportFixedWidthText)
                grpText.Visible = True
                RefreshFilePreview("TXT")
            ElseIf rdoSeparatortext.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
                grpCSV.Visible = True
                RefreshFilePreview("CSV")
            End If
            RefreshFrameView()
        End If

    End Sub

    Private Function NumberOfFileTypes(strFileNames As String()) As Integer
        Dim lstExtensions As New List(Of String)

        For Each strFile As String In strFileNames
            lstExtensions.Add(Path.GetExtension(strFile))
        Next
        Return lstExtensions.Distinct.Count
    End Function

    Private Sub clbSheets_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbSheets.ItemCheck
        Dim strSheetNumbers As String

        If Not bSupressSheetChange Then
            dctSelectedExcelSheets.Clear()
            If strFileType = "XLS" OrElse strFileType = "XLSX" Then
                For Each i As Integer In clbSheets.CheckedIndices
                    dctSelectedExcelSheets.Add(i + 1, clbSheets.Items.Item(i).ToString())
                Next
                If e.NewValue = CheckState.Checked Then
                    dctSelectedExcelSheets.Add(e.Index + 1, clbSheets.Items.Item(e.Index).ToString())
                Else
                    dctSelectedExcelSheets.Remove(e.Index + 1)
                End If
                If dctSelectedExcelSheets.Count = 0 Then
                    clsImportExcel.RemoveParameterByName("which")
                    clsImportExcelMulti.RemoveParameterByName("which")
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
                    ucrSaveFile.Show()
                    ucrSaveFile.SetDataFrameNames("")
                ElseIf dctSelectedExcelSheets.Count = 1 Then
                    strSheetNumbers = dctSelectedExcelSheets.Keys.First()
                    clsImportExcel.AddParameter("which", strSheetNumbers)
                    ucrSaveFile.SetName(dctSelectedExcelSheets.Values.First(), bSilent:=True)
                    ucrSaveFile.Focus()
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
                    ucrSaveFile.Show()
                    ucrSaveFile.SetDataFrameNames("")
                Else
                    strSheetNumbers = "c(" & String.Join(",", dctSelectedExcelSheets.Keys) & ")"
                    clsImportExcelMulti.AddParameter("which", strSheetNumbers)
                    ucrSaveFile.SetName(frmMain.clsRLink.MakeValidText(strFileName), bSilent:=True)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcelMulti)
                    ucrSaveFile.Hide()
                    ucrSaveFile.SetDataFrameNames(lstTempDataFrameNames:=dctSelectedExcelSheets.Values.ToList())
                End If
                bSupressCheckAllSheets = True
                If dctSelectedExcelSheets.Count = clbSheets.Items.Count Then
                    ucrChkSheetsCheckAll.Checked = True
                Else
                    ucrChkSheetsCheckAll.Checked = False
                End If
                bSupressCheckAllSheets = False
                ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=(dctSelectedExcelSheets.Count > 1))
                RefreshFrameView()
                TestOkEnabled()
            End If
        End If
    End Sub

    Private Sub ucrChkSheetsCheckAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSheetsCheckAll.ControlValueChanged
        Dim bCheckAll As Boolean

        If Not bSupressCheckAllSheets Then
            bCheckAll = ucrChkSheetsCheckAll.Checked
            bSupressSheetChange = True
            For i As Integer = 0 To clbSheets.Items.Count - 1
                If i = clbSheets.Items.Count - 1 Then
                    bSupressSheetChange = False
                End If
                clbSheets.SetItemChecked(i, bCheckAll)
            Next
        End If
    End Sub
End Class