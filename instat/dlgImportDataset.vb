Imports System.Runtime.InteropServices
Imports System.IO
Imports RDotNet
Imports instat.Translations

Public Class dlgImportDataset

    Private clsImportTextFileFormats, clsImportCSVFileFormats, clsImportRDS, clsReadRDS, clsImportExcel, clsImport As RFunction
    Private clsGetExcelSheetNames As RFunction
    Private clsRangeOperator As ROperator
    ''' <summary>   
    ''' Ensures that any file paths containing special characters (e.g. accents) are 
    ''' correctly encoded.
    ''' </summary>
    Private clsEnc2Native As RFunction
    'functions for multi Excel sheet impoty
    Private clsImportExcelMulti As RFunction
    Private clsGetFilesList, clsImportMultipleFiles, clsImportMultipleTextFiles, clsFileNamesWithExt As RFunction
    'functions for importing multiple files
    Private bFirstLoad As Boolean = True
    Public bFromLibrary As Boolean = False
    Private strLibraryPath As String = Path.Combine(frmMain.strStaticPath & "\Library")
    Private strFileExtension As String = ""
    Private bCanImport As Boolean = False
    Private bReset As Boolean = True
    Public bStartOpenDialog As Boolean = True
    Private strFilePathSystem As String = ""
    'holds what was previously the path in the case of open from library, its value is used to set back the path 
    Private strFilePathSystemTemp As String = ""
    Private strFilePathR As String = ""
    Private strCurrentDirectory As String = ""
    Private bImportFromFolder As Boolean = False
    Private strFileName As String = ""
    Private strlastFileName As String = ""
    Public strFileToOpenOn As String = ""
    Private bDialogLoaded As Boolean = False
    Private iDataFrameCount As Integer
    Private bSupressCheckAllSheets As Boolean = False
    Private bSupressSheetChange As Boolean = False
    'key value map of excel sheet number and sheet name
    Private dctSelectedExcelSheets As New Dictionary(Of Integer, String)
    Private clsDetectEmptyColsFunction As New RFunction
    Private clsConcFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsEmptyDummyFunction As New RFunction

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bDialogLoaded = False
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetRCodeForControls(bReset)
        bDialogLoaded = True
        If strFileToOpenOn <> "" Then
            'if path is not a file or folder then it no longer exists
            If Not File.Exists(strFileToOpenOn) AndAlso Not Directory.Exists(strFileToOpenOn) Then
                MsgBox("File or folder no longer exists: " & strFileToOpenOn)
                strFileToOpenOn = "" 'reset
                strFileExtension = "" 'reset
            End If
            SetDialogStateFromFile(strFileToOpenOn, strFileExtension)
            strFileToOpenOn = ""
            bStartOpenDialog = False
        ElseIf bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        Else
            'if none of the above then try setting the displayed values from the previous contents of ucrInputFilePath.
            If String.IsNullOrEmpty(ucrInputFilePath.GetText()) Then
                SetDialogStateFromFile("")
            Else
                If Not File.Exists(ucrInputFilePath.GetText()) AndAlso Not Directory.Exists(ucrInputFilePath.GetText()) Then
                    MsgBox("File or folder no longer exists: " & strFilePathSystem, MsgBoxStyle.Information, "File/Folder No Longer Exists")
                    SetDialogStateFromFile("")
                Else
                    'get file or folder path from the control and use previous extension incase it was a folder
                    SetDialogStateFromFile(ucrInputFilePath.GetText(), strFileExtension)
                End If
            End If
        End If

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

        ucrChkMultipleFiles.SetText("All files of this type")
        'todo. set tooltip for checkbox


        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.SetLabelText("New Data Frame Name:")
        ucrSaveFile.SetIsTextBox()
        ucrSaveFile.ucrInputTextSave.bAutoChangeOnLeave = True

        ucrNudPreviewLines.Value = 10

        '##############################################################
        'RDS Controls

        ucrChkImportChangesLogRDS.SetText("Import changes log")
        ucrChkImportChangesLogRDS.SetParameter(New RParameter("include_logs"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportChangesLogRDS.SetRDefault("TRUE")

        ucrChkKeepExistingDataRDS.SetText("Keep existing data frames")
        ucrChkKeepExistingDataRDS.SetParameter(New RParameter("keep_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkKeepExistingDataRDS.SetRDefault("TRUE")

        ucrChkImportMetadataRDS.SetText("Import metadata")
        ucrChkImportMetadataRDS.SetParameter(New RParameter("include_metadata"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportMetadataRDS.SetRDefault("TRUE")

        ucrChkImportObjectsRDS.SetText("Import objects")
        ucrChkImportObjectsRDS.SetParameter(New RParameter("include_objects"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportObjectsRDS.SetRDefault("TRUE")


        ucrChkImportFiltersRDS.SetText("Import filters")
        ucrChkImportFiltersRDS.SetParameter(New RParameter("include_filters"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportFiltersRDS.SetRDefault("TRUE")

        ucrChkImportCalculationsRDS.SetText("Import calculations")
        ucrChkImportCalculationsRDS.SetParameter(New RParameter("include_calculations"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkImportCalculationsRDS.SetRDefault("TRUE")

        ucrChkOverwriteRDS.SetText("Overwrite existing if duplicates found")
        ucrChkOverwriteRDS.SetParameter(New RParameter("overwrite_existing"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkOverwriteRDS.SetRDefault("FALSE")

        '##############################################################
        'CSV Controls

        ucrChkStringsAsFactorsCSV.SetText("Convert Strings to Factor Columns")
        ucrChkStringsAsFactorsCSV.SetParameter(New RParameter("stringsAsFactors"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkStringsAsFactorsCSV.SetRDefault("FALSE")

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

        ucrChkTrimWSExcel.SetText("Trim Trailing White Space")
        ucrChkTrimWSExcel.SetParameter(New RParameter("trim_ws"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkTrimWSExcel.SetRDefault("TRUE")

        ucrNudRowsToSkipExcel.SetParameter(New RParameter("skip"))
        ucrNudRowsToSkipExcel.Minimum = 0
        ucrNudRowsToSkipExcel.Maximum = Decimal.MaxValue
        ucrNudRowsToSkipExcel.SetRDefault(0)

        ucrChkColumnNamesExcel.SetText("First Row is Column Headers")
        ucrChkColumnNamesExcel.SetParameter(New RParameter("col_names"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumnNamesExcel.SetRDefault("TRUE")

        ucrChkRange.SetText("Range:")
        ucrChkRange.AddParameterPresentCondition(True, "range", True)
        ucrChkRange.AddParameterPresentCondition(False, "range", False)
        ucrChkRange.AddToLinkedControls({ucrInputTextFrom}, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="A1")
        ucrChkRange.AddToLinkedControls({ucrInputTextTo}, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="AA100")

        ucrInputTextFrom.SetParameter(New RParameter("from", bNewIncludeArgumentName:=False, iNewPosition:=0))
        ucrInputTextTo.SetParameter(New RParameter("To", bNewIncludeArgumentName:=False, iNewPosition:=1))
        ucrInputTextTo.AddQuotesIfUnrecognised = False
        ucrInputTextFrom.AddQuotesIfUnrecognised = False

        ucrInputTextFrom.SetLinkedDisplayControl(lblFrom)
        ucrInputTextTo.SetLinkedDisplayControl(lblTo)

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

        'todo. commented temporarily until we are able to add an OR condition for the panel; for multiple files function
        'ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoSeparatortext, {"read_table", "read_table2"}, bNewIsPositive:=False)
        'ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthText, {"read_table"}, bNewIsPositive:=True)
        'ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthWhiteSpacesText, {"read_table2"}, bNewIsPositive:=True)

        ucrChkColumnNamesText.SetText("First Row is Column Headers")
        ucrChkColumnNamesText.SetParameter(New RParameter("col_names"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumnNamesText.SetRDefault("TRUE")

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

        ucrChkDropEmptyCols.SetText("Drop Empty Rows and Columns")
        ucrChkDropEmptyCols.SetParameter(New RParameter("isRFunction", 0))
        ucrChkDropEmptyCols.SetValuesCheckedAndUnchecked("True", "False")
    End Sub

    Private Sub SetDefaults()
        Dim clsSetNames As New RFunction
        Dim clsFileNamesWithoutExt As New RFunction

        clsImportTextFileFormats = New RFunction
        clsImportCSVFileFormats = New RFunction
        clsImportRDS = New RFunction
        clsImportExcel = New RFunction
        clsImport = New RFunction
        clsReadRDS = New RFunction
        clsGetExcelSheetNames = New RFunction
        clsRangeOperator = New ROperator
        clsEnc2Native = New RFunction
        clsImportExcelMulti = New RFunction
        clsGetFilesList = New RFunction
        clsImportMultipleFiles = New RFunction
        clsImportMultipleTextFiles = New RFunction
        clsFileNamesWithExt = New RFunction
        clsDetectEmptyColsFunction = New RFunction
        clsEmptyDummyFunction = New RFunction

        ucrChkDropEmptyCols.Visible = False

        clsImportTextFileFormats.SetPackageName("readr")
        clsImportTextFileFormats.SetRCommand("read_table")

        clsImportExcel.SetPackageName("rio")
        clsImportExcel.SetRCommand("import")
        clsImportExcel.AddParameter("guess_max", "Inf")

        clsRangeOperator.SetOperation(":", bBracketsTemp:=False)
        clsRangeOperator.bToScriptAsRString = True
        clsRangeOperator.bSpaceAroundOperation = False

        clsImportCSVFileFormats.SetPackageName("rio")
        clsImportCSVFileFormats.SetRCommand("import")
        clsImportCSVFileFormats.AddParameter("stringsAsFactors", "TRUE")

        clsImport.SetPackageName("rio")
        clsImport.SetRCommand("import")

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.SetAssignTo("new_RDS")

        'This R command ensures that any file paths containing special characters (e.g. accents) 
        'are correctly encoded
        clsEnc2Native.SetRCommand("enc2native")

        clsGetExcelSheetNames.SetPackageName("readxl")
        clsGetExcelSheetNames.SetRCommand("excel_sheets")
        'Ensure that the file path is enclosed by 'enc2native' to ensure that file paths containing 
        'special characters(e.g.accents) are correctly encoded
        clsGetExcelSheetNames.AddParameter("path", "", clsEnc2Native, Nothing, Nothing, True, 0)

        clsImportExcelMulti.SetPackageName("rio")
        clsImportExcelMulti.SetRCommand("import_list")
        clsImportExcelMulti.AddParameter("guess_max", "Inf", iPosition:=6)

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        'commands for multiple files
        clsGetFilesList.SetRCommand("list.files")
        clsGetFilesList.AddParameter("full.names", "TRUE", iPosition:=2)
        clsGetFilesList.AddParameter("ignore.case", "TRUE", iPosition:=3)

        clsImportMultipleFiles.SetPackageName("rio")
        clsImportMultipleFiles.SetRCommand("import_list")
        clsImportMultipleFiles.AddParameter("file", clsRFunctionParameter:=clsGetFilesList, iPosition:=0)
        clsImportMultipleFiles.AddParameter("stringsAsFactors", "TRUE")

        clsFileNamesWithExt.SetRCommand("list.files")
        clsFileNamesWithExt.AddParameter("full.names", "FALSE", iPosition:=2)
        clsFileNamesWithExt.AddParameter("ignore.case", "TRUE", iPosition:=3)

        clsFileNamesWithoutExt.SetPackageName("tools")
        clsFileNamesWithoutExt.SetRCommand("file_path_sans_ext")
        clsFileNamesWithoutExt.AddParameter("x", clsRFunctionParameter:=clsFileNamesWithExt, iPosition:=0)

        clsSetNames.SetPackageName("stats")
        clsSetNames.SetRCommand("setNames")
        clsSetNames.AddParameter("object", clsRFunctionParameter:=clsGetFilesList, iPosition:=0)
        clsSetNames.AddParameter("nm", clsRFunctionParameter:=clsFileNamesWithoutExt, iPosition:=1)

        clsImportMultipleTextFiles.SetRCommand("lapply")
        clsImportMultipleTextFiles.AddParameter("X", clsRFunctionParameter:=clsSetNames, iPosition:=0)
        clsImportMultipleTextFiles.AddParameter("FUN", strParameterValue:="readr::read_table", iPosition:=1)

        clsConcFunction.SetRCommand("c")
        clsConcFunction.AddParameter("x", Chr(34) & "rows" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsConcFunction.AddParameter("y", Chr(34) & "cols" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsDetectEmptyColsFunction.SetPackageName("janitor")
        clsDetectEmptyColsFunction.SetRCommand("remove_empty")
        clsDetectEmptyColsFunction.AddParameter("which", clsRFunctionParameter:=clsConcFunction, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("x", clsRFunctionParameter:=clsDetectEmptyColsFunction, iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsImport)


        dctSelectedExcelSheets.Clear()
        clbSheets.Items.Clear() 'reset this here. Not set by R code
        ucrInputMissingValueStringExcel.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringCSV.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringText.SetName("") 'reset this here. Not set by R code 
        ucrNudPreviewLines.Value = 10
        'todo. temporarily done this until when we can add OR conditions for the panel
        ucrChkMultipleFiles.Checked = False
        rdoSeparatortext.Checked = True
        SetDialogStateFromFile("")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If bImportFromFolder Then
            ucrBase.OKEnabled(GetDirectoryFiles(False).Count > 0)
        Else
            If IsExcelFileFormat() Then
                ucrBase.OKEnabled(dctSelectedExcelSheets.Count > 0 AndAlso bCanImport)
            ElseIf (ucrSaveFile.IsComplete OrElse strFileExtension = ".rds") AndAlso bCanImport Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    'Loads the open dialog on load and click
    Public Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html;*.dly;*.dat|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html|DLY|*.dly|DAT|*.dat|All files|*.*"
            dlgOpen.Multiselect = False
            If bFromLibrary Then
                dlgOpen.Title = "Import from Library"
                ' TODO There should be a way of using Path.GetDirectoryName to avoid needing the If but couldn't get this to work
                If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
                    dlgOpen.InitialDirectory = Replace(strLibraryPath, "\", "/")
                Else
                    dlgOpen.InitialDirectory = strLibraryPath
                End If
            Else
                dlgOpen.Title = "Open Data from file"
                dlgOpen.InitialDirectory = If(String.IsNullOrEmpty(strCurrentDirectory), frmMain.clsInstatOptions.strWorkingDirectory, strCurrentDirectory)
            End If
            If DialogResult.OK = dlgOpen.ShowDialog() Then
                'always reset the multiple files checkbox
                ucrChkMultipleFiles.Checked = False
                ucrSaveFile.Reset()
                If NumberOfFileTypes(dlgOpen.FileNames) > 1 Then
                    MsgBox("All files must be of the same type", MsgBoxStyle.Information, "Multiple file types")
                    SetDialogStateFromFile("")
                Else
                    dctSelectedExcelSheets.Clear()
                    clbSheets.Items.Clear()
                    SetDialogStateFromFile(dlgOpen.FileName)
                End If
            End If
        End Using
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportTextFileFormats, New RParameter("file", 0), iAdditionalPairNo:=1)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportCSVFileFormats, New RParameter("file", 0), iAdditionalPairNo:=2)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcel, New RParameter("file", 0), iAdditionalPairNo:=3)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsReadRDS, New RParameter("file", 0), iAdditionalPairNo:=4)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsEnc2Native, New RParameter("path", 0, False), iAdditionalPairNo:=5)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("file", 0), iAdditionalPairNo:=6)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsGetFilesList, New RParameter("path", 0), iAdditionalPairNo:=7)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsFileNamesWithExt, New RParameter("path", 0), iAdditionalPairNo:=8)
        ucrInputFilePath.SetRCode(clsImport, bReset)

        'Save control
        ucrSaveFile.AddAdditionalRCode(clsImportTextFileFormats, iAdditionalPairNo:=1)
        ucrSaveFile.AddAdditionalRCode(clsImportCSVFileFormats, iAdditionalPairNo:=2)
        ucrSaveFile.AddAdditionalRCode(clsImportExcel, iAdditionalPairNo:=3)
        ucrSaveFile.AddAdditionalRCode(clsImportExcelMulti, iAdditionalPairNo:=4)
        ucrSaveFile.AddAdditionalRCode(clsImportMultipleFiles, iAdditionalPairNo:=5)
        ucrSaveFile.AddAdditionalRCode(clsImportMultipleTextFiles, iAdditionalPairNo:=6)
        ucrSaveFile.AddAdditionalRCode(clsPipeOperator, iAdditionalPairNo:=7)
        ucrSaveFile.SetRCode(clsImport, bReset)

        'todo. commented temporarily until we are able to add an OR condition for the panel
        'Used by both text and csv functions
        'ucrPanelFixedWidthText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        'TEXT CONTROLS
        ucrChkColumnNamesText.SetRCode(clsImportTextFileFormats, bReset)
        ucrNudRowsToSkipText.SetRCode(clsImportTextFileFormats, bReset)
        ucrNudMaxRowsText.SetRCode(clsImportTextFileFormats, bReset)
        ucrChkMaxRowsText.SetRCode(clsImportTextFileFormats, bReset)

        ucrChkColumnNamesText.AddAdditionalCodeParameterPair(clsImportMultipleTextFiles, New RParameter("col_names"), iAdditionalPairNo:=1)
        ucrNudRowsToSkipText.AddAdditionalCodeParameterPair(clsImportMultipleTextFiles, New RParameter("skip"), iAdditionalPairNo:=1)
        ucrNudMaxRowsText.AddAdditionalCodeParameterPair(clsImportMultipleTextFiles, New RParameter("n_max"), iAdditionalPairNo:=1)

        'CSV CONTROLS
        ucrInputSeparatorCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrInputHeadersCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrInputDecimalCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrInputEncodingCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrChkStringsAsFactorsCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrNudRowsToSkipCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrNudMaxRowsCSV.SetRCode(clsImportCSVFileFormats, bReset)
        ucrChkMaxRowsCSV.SetRCode(clsImportCSVFileFormats, bReset)

        'multiple controls
        ucrInputSeparatorCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("sep"), iAdditionalPairNo:=1)
        ucrInputHeadersCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("header"), iAdditionalPairNo:=1)
        ucrInputDecimalCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("dec"), iAdditionalPairNo:=1)
        ucrInputEncodingCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("encoding"), iAdditionalPairNo:=1)
        ucrChkStringsAsFactorsCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("stringsAsFactors"), iAdditionalPairNo:=1)
        ucrNudRowsToSkipCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("skip"), iAdditionalPairNo:=1)
        ucrNudMaxRowsCSV.AddAdditionalCodeParameterPair(clsImportMultipleFiles, New RParameter("nrows", strParamValue:=ucrNudMaxRowsCSV.Value), iAdditionalPairNo:=1)

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
        ucrChkTrimWSExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("trim_ws"), iAdditionalPairNo:=1)
        ucrChkColumnNamesExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("col_names"), iAdditionalPairNo:=1)
        ucrNudMaxRowsExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("n_max"), iAdditionalPairNo:=1)
        ucrChkMaxRowsExcel.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("n_max"), iAdditionalPairNo:=1)

        ucrNudRowsToSkipExcel.SetRCode(clsImportExcel, bReset)
        ucrChkTrimWSExcel.SetRCode(clsImportExcel, bReset)
        ucrChkColumnNamesExcel.SetRCode(clsImportExcel, bReset)
        ucrNudMaxRowsExcel.SetRCode(clsImportExcel, bReset)
        ucrChkMaxRowsExcel.SetRCode(clsImportExcel, bReset)

        ucrChkRange.SetRCode(clsImportExcel, bReset)
        ucrInputTextFrom.SetRCode(clsRangeOperator, bReset)
        ucrInputTextTo.SetRCode(clsRangeOperator, bReset)
        ucrChkDropEmptyCols.SetRCode(clsEmptyDummyFunction, bReset)
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

    Private Sub ExcelSheetsPreviewVisible(bVisible As Boolean)
        grpExcel.Visible = bVisible
        clbSheets.Visible = bVisible
        lblSelectSheets.Visible = bVisible
        ucrChkSheetsCheckAll.Visible = bVisible
    End Sub

    Public Sub SetDialogStateFromFile(strFileOrFolderPath As String, Optional strFolderFileExt As String = "")
        bImportFromFolder = False
        strFileName = ""
        strFileExtension = ""
        strFilePathSystem = ""
        strFilePathR = ""

        If Not String.IsNullOrEmpty(strFileOrFolderPath) Then
            If bFromLibrary Then
                'store what was there temporarily first 
                strFilePathSystemTemp = strFilePathSystem
            End If
            'always set the appropriate file path separators
            strFilePathSystem = Replace(strFileOrFolderPath, "/", "\")
            strFilePathR = Replace(strFileOrFolderPath, "\", "/")
            If File.Exists(strFileOrFolderPath) Then
                'get the name of the file (without extension), with any special characters removed
                strFileName = GetCleanFileName(strFileOrFolderPath)
                'getting the name of the file without replacing any characters
                'so that its possible to reload the file after checking and unchecking the all file check box 
                strlastFileName = Path.GetFileNameWithoutExtension(strFileOrFolderPath)
                strCurrentDirectory = Path.GetDirectoryName(strFileOrFolderPath)
                strFileExtension = Path.GetExtension(strFileOrFolderPath).ToLower 'extension check is done in lower case
                            ElseIf Directory.Exists(strFileOrFolderPath) AndAlso strFolderFileExt <> "" Then
                strCurrentDirectory = strFileOrFolderPath
                strFileExtension = strFolderFileExt.ToLower 'extension check is done in lower case
                bImportFromFolder = True
            End If
        End If

        ucrInputFilePath.SetName(strFilePathR)
        grpText.Hide()
        grpCSV.Hide()
        grpRDS.Hide()
        ucrPanelFixedWidthText.Hide()
        ExcelSheetsPreviewVisible(False)
        ucrSaveFile.Hide()

        If bImportFromFolder Then
            'set the cleaned file names as the data frame names
            ucrChkMultipleFiles.SetVisible(True)
            ucrChkMultipleFiles.Checked = True
            ucrSaveFile.SetName("files", bSilent:=True)
            ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=True)
            ucrSaveFile.Hide()
            clsGetFilesList.AddParameter("pattern", Chr(34) & "\\" & strFileExtension & "$" & Chr(34), iPosition:=1)
            clsFileNamesWithExt.AddParameter("pattern", Chr(34) & "\\" & strFileExtension & "$" & Chr(34), iPosition:=1)

            If IsTextFileFormat() Then
                clsImportMultipleFiles.AddParameter("format", Chr(34) & "txt" & Chr(34), iPosition:=1)
                grpCSV.Text = "Import Text Options"
                grpCSV.Location = New Point(9, 99) 'set the location of the groupbox to adjust gaps in the form UI
                ucrPanelFixedWidthText.Show()
                If rdoSeparatortext.Checked Then
                    grpCSV.Show()
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportMultipleFiles)
                Else
                    grpText.Show()
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportMultipleTextFiles)
                End If
            ElseIf IsCSVFileFormat() Then
                clsImportMultipleFiles.AddParameter("format", Chr(34) & "csv" & Chr(34), iPosition:=1)
                grpCSV.Text = "Import Options"
                grpCSV.Location = New Point(9, 50) 'set the location of the groupbox to adjust gaps in the form UI 
                grpCSV.Show()
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportMultipleFiles)
            Else
                clsImportMultipleFiles.AddParameter("format", Chr(34) & strFileExtension.Substring(1) & Chr(34), iPosition:=1)
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportMultipleFiles)
            End If

        Else
            'don't enable multiple files import for the following files; .rds, .xlsx, .xls
            ucrChkMultipleFiles.SetVisible(Not {".rds", ".xls", ".xlsx"}.Contains(strFileExtension))
            ucrChkMultipleFiles.Checked = False
            'TODO This needs to be different when RDS is a data frame
            'need to be able to detect RDS as data.frame/Instat Object
            If strFileExtension = ".rds" Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
                clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
                grpRDS.Show()
            ElseIf IsTextFileFormat() Then
                'add or change format parameter values. forces rio to treat .dat files as text files 
                'needed as rio currently doesn't support .DAT files. Only works if .DAT file is text based,
                'this seems to be common usage, check https://github.com/leeper/rio/issues/155
                If strFileExtension = ".dat" Then
                    clsImportCSVFileFormats.AddParameter("format", Chr(34) & "txt" & Chr(34), iPosition:=1)
                End If
                ucrPanelFixedWidthText.Show()
                grpCSV.Text = "Import Text Options"
                grpCSV.Location = New Point(9, 99) 'set the location of the groupbox to adjust gaps in the form UI
                If rdoSeparatortext.Checked Then
                    grpCSV.Show()
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSVFileFormats)
                Else
                    grpText.Show()
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportTextFileFormats)
                End If
            ElseIf IsCSVFileFormat() Then
                'add or change format parameter values. forces rio to treat .dly files as csv files
                If strFileExtension = ".dly" Then
                    clsImportCSVFileFormats.AddParameter("format", Chr(34) & "csv" & Chr(34), iPosition:=1)
                End If
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSVFileFormats)
                grpCSV.Text = "Import CSV Options"
                grpCSV.Location = New System.Drawing.Point(9, 50) 'set the location of the groupbox to adjust gaps in the form UI
                grpCSV.Show()
            ElseIf IsExcelFileFormat() Then
                ucrBase.clsRsyntax.SetBaseRFunction(If(clbSheets.CheckedItems.Count > 1, clsImportExcelMulti, clsImportExcel))
                ExcelSheetsPreviewVisible(True)
                FillExcelSheets()
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
            End If

            If IsExcelFileFormat() Then
                ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=clbSheets.CheckedItems.Count > 1)
                ucrSaveFile.Show()
                Select Case clbSheets.CheckedItems.Count
                    Case 1
                        ucrSaveFile.SetName(GetCleanFileName(dctSelectedExcelSheets.Values.First()), bSilent:=True)
                    Case Else
                        ucrSaveFile.SetName(GetCleanFileName(strFileName), bSilent:=True)
                End Select
            ElseIf Not {".rds", ""}.Contains(strFileExtension) Then
                ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=False)
                ucrSaveFile.Show()
                ucrSaveFile.SetName(GetCleanFileName(strFileName), bSilent:=True)
            End If

            If strFileExtension = ".r" Then
                If Not frmMain.mnuViewScriptWindow.Checked Then
                    frmMain.mnuViewScriptWindow.Checked = True
                    frmMain.UpdateLayout()
                End If
                If frmMain.ucrScriptWindow.txtScript.TextLength = 0 OrElse MessageBox.Show("Loading a script from file will clear your current script" &
                              Environment.NewLine & "Do you still want to load?",
                              "Load Script From File", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Try
                        frmMain.ucrScriptWindow.txtScript.Text = File.ReadAllText(strFilePathSystem)
                    Catch
                        MessageBox.Show("Could not load the script from file." &
                              Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.",
                              "Load Script", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
                SetDialogStateFromFile("")
                Me.Close()
            End If
        End If

        TryTextPreview()
        TryGridPreview()
        TestOkEnabled()

        autoTranslate(Me)
        RemoveMissingValues()
    End Sub

    Private Sub TryTextPreview()
        If Not bDialogLoaded Then
            Exit Sub
        End If

        txtTextFilePreview.Text = ""
        TextPreviewVisible(False)
        If bImportFromFolder Then
            Dim lstFileNames As List(Of String) = GetDirectoryFiles(True)
            lblTextFilePreview.Text = If(lstFileNames.Count = 0, "No Files found", "Files found: " & lstFileNames.Count)
            For Each strFilePathName As String In lstFileNames
                txtTextFilePreview.Text &= strFilePathName & Environment.NewLine
            Next
            TextPreviewVisible(True)
        ElseIf IsTextFileFormat() OrElse IsCSVFileFormat() Then
            'show preview for the following file types only
            Dim iLinesToPreview As Integer = ucrNudPreviewLines.Value + If(IsCSVFileFormat(), ucrNudRowsToSkipCSV.Value, ucrNudRowsToSkipText.Value)
            lblTextFilePreview.Text = "Text File Preview:"
            Try
                Using sReader As New StreamReader(strFilePathSystem)
                    For k = 0 To iLinesToPreview
                        txtTextFilePreview.Text &= sReader.ReadLine() & Environment.NewLine
                        If sReader.Peek() = -1 Then
                            Exit For
                        End If
                    Next
                End Using
            Catch ex As Exception
                txtTextFilePreview.Text = "Cannot show text preview of file:" & strFilePathSystem & ". The file may have moved or be in use by another program. Close the file and select it again from the dialog to refresh the preview."
            End Try
            TextPreviewVisible(True)
        End If

    End Sub

    Private Sub TryGridPreview()
        If Not bDialogLoaded Then
            Exit Sub
        End If

        lblCannotImport.Hide()
        lblImportingSheets.Hide()
        lblNoPreview.Hide()

        GridPreviewVisible(False)
        LinesToPreviewVisible(False)
        cmdRefreshPreview.Enabled = False
        bCanImport = False

        'grid preview is only supported for a few file formats. It is also not supported for folders
        If bImportFromFolder OrElse Not (IsTextFileFormat() OrElse IsCSVFileFormat() OrElse IsExcelFileFormat()) Then
            lblNoPreview.Show()
            bCanImport = True 'assume its true if preview is not supported for the file
            Exit Sub
        End If

        Dim strRowMaxParamName As String = ""
        If IsTextFileFormat() Then
            strRowMaxParamName = If(rdoSeparatortext.Checked, "nrows", "n_max")
        ElseIf IsCSVFileFormat() Then
            strRowMaxParamName = "nrows"
        ElseIf IsExcelFileFormat() Then
            If dctSelectedExcelSheets.Count = 0 Then
                lblNoPreview.Show()
                lblImportingSheets.Show()
                lblImportingSheets.Text = "No sheet selected."
                bCanImport = True 'assume can still import the entire excel file
                Exit Sub
            ElseIf dctSelectedExcelSheets.Count > 1 Then
                lblNoPreview.Show()
                lblImportingSheets.Show()
                lblImportingSheets.Text = "Importing the following sheets:" & Environment.NewLine & String.Join(", ", dctSelectedExcelSheets.Values)
                bCanImport = True 'assume can import all selected sheets
                Exit Sub
            End If
            strRowMaxParamName = "n_max"
        End If

        Dim dfTemp As DataFrame
        Dim expTemp As SymbolicExpression
        Dim clsAsCharacterFunc As New RFunction
        Dim clsTempImport As RFunction
        Dim iTemp As Integer
        'clone the base function to be used for data frame preview and also add the correct maximum number of lines to preview
        clsTempImport = ucrBase.clsRsyntax.clsBaseFunction.Clone()
        'determine the correct maximum number of lines to preview 
        If clsTempImport.ContainsParameter(strRowMaxParamName) _
            AndAlso Integer.TryParse(clsTempImport.GetParameter(strRowMaxParamName).strArgumentValue, iTemp) Then
            clsTempImport.AddParameter(strRowMaxParamName, Math.Min(iTemp, ucrNudPreviewLines.Value))
        Else
            clsTempImport.AddParameter(strRowMaxParamName, ucrNudPreviewLines.Value)
        End If

        clsTempImport.RemoveAssignTo()

        clsAsCharacterFunc.SetRCommand("convert_to_character_matrix")
        clsAsCharacterFunc.AddParameter("data", clsRFunctionParameter:=clsTempImport)
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunc.ToScript(), bSilent:=True)
        Try
            dfTemp = expTemp?.AsDataFrame
            If dfTemp IsNot Nothing Then
                grdDataPreview.Worksheets.Clear()
                frmMain.clsGrids.FillSheet(dfTemp, "temp", grdDataPreview, bIncludeDataTypes:=False, iColMax:=frmMain.clsGrids.iMaxCols)
                grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
                grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
                GridPreviewVisible(True)
                LinesToPreviewVisible(True)
                cmdRefreshPreview.Enabled = True
                bCanImport = True
            Else
                'if no data frame is returned
                lblCannotImport.Show()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        GetFileFromOpenDialog()
    End Sub

    Private Sub FillExcelSheets()
        Dim expSheet As SymbolicExpression
        Dim chrSheets As CharacterVector
        Dim lstCheckedItems As New List(Of String)

        expSheet = frmMain.clsRLink.RunInternalScriptGetValue(clsGetExcelSheetNames.ToScript())
        chrSheets = expSheet?.AsCharacter

        'store the checked items first temporarily 
        For i As Integer = 0 To clbSheets.CheckedItems.Count - 1
            lstCheckedItems.Add(clbSheets.CheckedItems(i).ToString)
        Next

        clbSheets.Items.Clear()
        If chrSheets IsNot Nothing AndAlso chrSheets.Count > 0 Then
            clbSheets.Items.AddRange(chrSheets.ToArray())
            'if there were previously checked items then restore them
            For Each strSelected As String In lstCheckedItems
                For i As Integer = 0 To clbSheets.Items.Count - 1
                    If strSelected = clbSheets.Items(i).ToString Then
                        bSupressSheetChange = True
                        clbSheets.SetItemChecked(i, True)
                        bSupressSheetChange = False
                        'sheet names are expected to be unique so exit inner for loop
                        Exit For
                    End If
                Next
            Next
        End If
        'set checked status of select all checkbox
        bSupressCheckAllSheets = True
        ucrChkSheetsCheckAll.Checked = chrSheets IsNot Nothing AndAlso clbSheets.CheckedItems.Count = chrSheets.Count
        bSupressCheckAllSheets = False
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'Gets the current number of (visible) data frame before importing
        'So correct current data frame can be set after
        iDataFrameCount = frmMain.GetDataFrameCount()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'add the item to the MRU (Most Recently Used) list...
        'only add if its a file that was selected, don't add if folder path was selected
        If Not bImportFromFolder Then
            frmMain.clsRecentItems.addToMenu(Replace(strFilePathSystem, "\", "/"))
        End If

        'Sets the current data frame as the first new data frame
        'Needed so that if multiple data frames imported, the last one is not the current data frame
        frmMain.SetCurrentDataFrame(iDataFrameCount)
    End Sub

    Private Sub ucrNudPreviewLines_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudPreviewLines.ControlContentsChanged
        TryTextPreview()
        TryGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub cmdRefreshPreview_Click(sender As Object, e As EventArgs) Handles cmdRefreshPreview.Click
        TryTextPreview()
        TryGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTrimWSExcel.ControlValueChanged, ucrNudRowsToSkipExcel.ControlValueChanged, ucrChkColumnNamesExcel.ControlValueChanged, ucrChkColumnNamesText.ControlValueChanged, ucrNudRowsToSkipText.ControlValueChanged,
        ucrChkMaxRowsText.ControlValueChanged, ucrChkMaxRowsCSV.ControlValueChanged, ucrChkMaxRowsExcel.ControlValueChanged, ucrNudMaxRowsText.ControlValueChanged, ucrNudMaxRowsCSV.ControlValueChanged, ucrChkDropEmptyCols.ControlValueChanged,
        ucrNudMaxRowsExcel.ControlValueChanged, ucrChkStringsAsFactorsCSV.ControlValueChanged, ucrInputEncodingCSV.ControlValueChanged, ucrInputSeparatorCSV.ControlValueChanged, ucrInputHeadersCSV.ControlValueChanged, ucrInputDecimalCSV.ControlValueChanged, ucrNudRowsToSkipCSV.ControlValueChanged
        TryGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub MissingValuesInputControls_ContentsChanged() Handles ucrInputMissingValueStringText.ContentsChanged, ucrInputMissingValueStringCSV.ContentsChanged, ucrInputMissingValueStringExcel.ContentsChanged
        'currently we have no way of knowing which control has raised this event and therefore can't do that check
        'so instead we are using the strFileType to identify which RFunctions should be updated accordingly
        If IsExcelFileFormat() Then
            'set for single imports and multiple imports 
            clsImportExcelMulti.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringExcel.GetText()))
            clsImportExcel.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringExcel.GetText()))
        ElseIf IsCSVFileFormat() Then
            clsImportCSVFileFormats.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
            clsImportMultipleFiles.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
        ElseIf IsTextFileFormat() Then
            'for separator we use the function used for csv
            If rdoSeparatortext.Checked Then
                clsImportCSVFileFormats.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
                clsImportMultipleFiles.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
            Else
                clsImportTextFileFormats.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringText.GetText()), iPosition:=2)
                clsImportMultipleTextFiles.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringText.GetText()), iPosition:=2)
            End If
        End If
        TryGridPreview()
        TestOkEnabled()
    End Sub

    'todo. This event could be changed to UcrPanelFixedWidthText_ControlValueChanged
    'when OR conditions are supported by ucrPanels 
    Private Sub UcrPanelFixedWidthText_RadiosChanged(sender As Object, e As EventArgs) Handles rdoSeparatortext.CheckedChanged, rdoFixedWidthText.CheckedChanged, rdoFixedWidthWhiteSpacesText.CheckedChanged
        If Not IsTextFileFormat() Then
            Exit Sub
        End If

        grpCSV.Hide()
        grpText.Hide()
        If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
            If rdoFixedWidthText.Checked Then
                clsImportTextFileFormats.SetRCommand("read_table")
                clsImportMultipleTextFiles.AddParameter("FUN", strParameterValue:="readr::read_table", iPosition:=1)
            Else
                clsImportTextFileFormats.SetRCommand("read_table2")
                clsImportMultipleTextFiles.AddParameter("FUN", strParameterValue:="readr::read_table2", iPosition:=1)
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(If(bImportFromFolder, clsImportMultipleTextFiles, clsImportTextFileFormats))
            grpText.Show()
        ElseIf rdoSeparatortext.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(If(bImportFromFolder, clsImportMultipleFiles, clsImportCSVFileFormats))
            grpCSV.Show()
        End If
        TryTextPreview()
        TryGridPreview()
        RemoveMissingValues()
        TestOkEnabled()
    End Sub

    Private Sub clbSheets_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbSheets.ItemCheck
        If bSupressSheetChange OrElse Not IsExcelFileFormat() Then
            Exit Sub
        End If

        dctSelectedExcelSheets.Clear()
        For Each i As Integer In clbSheets.CheckedIndices
            dctSelectedExcelSheets.Add(i + 1, clbSheets.Items.Item(i).ToString())
        Next

        If e.NewValue = CheckState.Checked Then
            dctSelectedExcelSheets.Add(e.Index + 1, clbSheets.Items.Item(e.Index).ToString())
        Else
            dctSelectedExcelSheets.Remove(e.Index + 1)
        End If

        If dctSelectedExcelSheets.Count = 0 Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            clsImportExcel.RemoveParameterByName("which")
            clsImportExcelMulti.RemoveParameterByName("which")
            ucrSaveFile.Show()
            ucrSaveFile.SetDataFrameNames("")
        ElseIf dctSelectedExcelSheets.Count = 1 Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            clsImportExcel.AddParameter("which", dctSelectedExcelSheets.Keys.First())
            ucrSaveFile.SetName(GetCleanFileName(dctSelectedExcelSheets.Values.First()), bSilent:=True)
            ucrSaveFile.Show()
            ucrSaveFile.SetDataFrameNames("")
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcelMulti)
            clsImportExcelMulti.AddParameter("which", "c(" & String.Join(",", dctSelectedExcelSheets.Keys) & ")")
            ucrSaveFile.SetName(GetCleanFileName(strFileName), bSilent:=True)
            ucrSaveFile.Hide()
            ucrSaveFile.SetDataFrameNames(lstTempDataFrameNames:=dctSelectedExcelSheets.Values.ToList())
        End If
        bSupressCheckAllSheets = True
        ucrChkSheetsCheckAll.Checked = (dctSelectedExcelSheets.Count = clbSheets.Items.Count)
        bSupressCheckAllSheets = False
        ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=dctSelectedExcelSheets.Count > 1)
        TryGridPreview()
        RemoveMissingValues()
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveFile_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveFile.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSheetsCheckAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSheetsCheckAll.ControlValueChanged
        If bSupressCheckAllSheets Then
            Exit Sub
        End If

        Dim bCheckAll As Boolean = ucrChkSheetsCheckAll.Checked
        bSupressSheetChange = True
        For i As Integer = 0 To clbSheets.Items.Count - 1
            'raise the checked event in the last element
            If i = clbSheets.Items.Count - 1 Then
                bSupressSheetChange = False
            End If
            clbSheets.SetItemChecked(i, bCheckAll)
        Next
    End Sub

    Private Sub dlgImportDataset_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Not Me.Visible) AndAlso bFromLibrary Then
            bFromLibrary = False
            If String.IsNullOrEmpty(strFilePathSystemTemp) Then
                strCurrentDirectory = ""
                strFileName = ""
                strFileExtension = ""
                strFilePathSystem = ""
                strFilePathR = ""
                ucrInputFilePath.SetName("")
            Else
                If File.Exists(strFilePathSystemTemp) Then
                    strCurrentDirectory = Path.GetDirectoryName(strFilePathSystemTemp)
                    'get the name of the file (without extension), with any special characters removed
                    strFileName = GetCleanFileName(strFilePathSystemTemp)
                    strFileExtension = Path.GetExtension(strFilePathSystemTemp)
                ElseIf Directory.Exists(strFilePathSystemTemp) Then
                    strCurrentDirectory = strFilePathSystemTemp
                    strFileName = ""
                    'file extension retained. Used when importing directories
                End If

                strFilePathSystem = strFilePathSystemTemp
                strFilePathR = Replace(strFilePathSystemTemp, "\", "/")
                ucrInputFilePath.SetName(strFilePathR)
            End If
        End If
    End Sub

    Private Sub ucrChkRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRange.ControlValueChanged
        If ucrChkRange.Checked Then
            clsImportExcel.AddParameter("range", clsROperatorParameter:=clsRangeOperator)
        Else
            clsImportExcel.RemoveParameterByName("range")
        End If
        TryGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkMultipleFiles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultipleFiles.ControlValueChanged
        If ucrChkMultipleFiles.Checked Then
            SetDialogStateFromFile(strCurrentDirectory, strFileExtension)
        Else
            SetDialogStateFromFile(strCurrentDirectory & "\" & strlastFileName & strFileExtension)
        End If
        TestOkEnabled()
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Extracts the name of the file (without the extension) from 
    '''             <paramref name="strFilePathTmp"/>. It removes any special characters (i.e. any 
    '''             characters that are not letters, digits '_' or '-'). It returns the resulting 
    '''             clean name. If the cleaned name is an empty string then returns 
    '''             'defaultCleanFileName'.
    '''             The special characters need to be removed because otherwise they trigger an 
    '''             error in some R commands.
    '''             </summary>
    '''
    ''' <param name="strFilePathTmp">      The full path of the file. </param>
    '''
    ''' <returns>   Returns the file name (without extension) with any special characters removed.
    '''             If the cleaned name is an empty string then returns 'defaultCleanFileName'.
    ''' </returns>
    '''--------------------------------------------------------------------------------------------
    Private Function GetCleanFileName(strFilePathTmp As String) As String
        Dim strCleanFileName As String = System.Text.RegularExpressions.Regex.Replace(Path.GetFileNameWithoutExtension(strFilePathTmp), "[^A-Za-z0-9_\-]", "")
        If String.IsNullOrEmpty(strCleanFileName) Then
            strCleanFileName = "defaultCleanFileName"
        End If
        Return frmMain.clsRLink.MakeValidText(strCleanFileName)
    End Function

    ''' <summary>
    ''' Creates an R string to be used as the parameter value for na.strings and na parameters 
    ''' </summary>
    ''' <param name="strText">The string that will be used to create the R Text</param>
    ''' <returns></returns>
    Private Function GetMissingValueRString(strText As String) As String
        Dim arrStr() As String = strText.Split(",")
        Dim strRmissingValueString As String = ""
        For Each strTemp As String In arrStr
            If strRmissingValueString = "" Then
                strRmissingValueString = Chr(34) & strTemp.Trim & Chr(34)
            Else
                strRmissingValueString = strRmissingValueString & "," & Chr(34) & strTemp.Trim & Chr(34)
            End If
        Next
        strRmissingValueString = "c(" & strRmissingValueString & "," & Chr(34) & Chr(34) & ")"
        Return strRmissingValueString
    End Function

    Private Function GetDirectoryFiles(bOnlyCleanedFileNames As Boolean) As List(Of String)
        Dim lstFileNames As New List(Of String)
        Dim arrFilePathsAndNames() As String
        If strFilePathSystem <> "" AndAlso Directory.Exists(strFilePathSystem) Then
            arrFilePathsAndNames = Directory.GetFiles(strFilePathSystem, "*" & strFileExtension)
            If bOnlyCleanedFileNames Then
                For Each strFilePathName As String In arrFilePathsAndNames
                    lstFileNames.Add(GetCleanFileName(strFilePathName))
                Next
            Else
                lstFileNames.AddRange(arrFilePathsAndNames)
            End If
        End If
        Return lstFileNames
    End Function

    Private Function NumberOfFileTypes(strFileNames As String()) As Integer
        Dim lstExtensions As New List(Of String)
        For Each strFile As String In strFileNames
            lstExtensions.Add(Path.GetExtension(strFile))
        Next
        Return lstExtensions.Distinct.Count
    End Function

    Private Function IsCSVFileFormat() As Boolean
        'dly are well read as csv files when using rio package
        Return {".csv", ".dly", ".tsv"}.Contains(strFileExtension)
    End Function

    Private Function IsTextFileFormat() As Boolean
        '.dat are well read as text files by readr pakage
        Return {".txt", ".dat"}.Contains(strFileExtension)
    End Function

    Private Function IsExcelFileFormat() As Boolean
        Return {".xlsx", ".xls"}.Contains(strFileExtension)
    End Function

    Private Sub RemoveMissingValues()
        Dim clsPreviousBaseFunction As RFunction = ucrBase.clsRsyntax.clsBaseFunction
        If strFileExtension = ".rds" _
               OrElse ucrBase.clsRsyntax.clsBaseFunction Is clsImportExcelMulti _
               OrElse ucrBase.clsRsyntax.clsBaseFunction Is clsImportMultipleFiles _
               OrElse ucrBase.clsRsyntax.clsBaseFunction Is clsImportMultipleTextFiles Then
            ucrChkDropEmptyCols.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsPreviousBaseFunction)
        Else
            ucrChkDropEmptyCols.Visible = True
            If ucrChkDropEmptyCols.Checked Then
                Dim clsTempFunction As RFunction = clsPreviousBaseFunction.Clone
                clsTempFunction.RemoveAssignTo()
                clsTempFunction.bExcludeAssignedFunctionOutput = False
                clsPipeOperator.AddParameter("y", clsRFunctionParameter:=clsTempFunction, iPosition:=0)
                ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsPreviousBaseFunction)
            End If
        End If
    End Sub

    Private Sub ucrChkDropEmptyCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDropEmptyCols.ControlValueChanged
        RemoveMissingValues()
    End Sub
End Class
