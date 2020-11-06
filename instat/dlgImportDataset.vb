Imports System.IO
Imports RDotNet
Imports instat.Translations

Public Class dlgImportDataset

    Private clsImportFixedWidthText, clsImportCSV, clsImportDAT, clsImportRDS, clsReadRDS, clsImportExcel, clsImport As RFunction
    Private clsGetExcelSheetNames As RFunction
    Private clsRangeOperator As ROperator
    ''' <summary>   Ensures that any file paths containing special characters (e.g. accents) are 
    '''             correctly encoded.
    '''             </summary>
    Private clsEnc2Native As RFunction
    ' Functions for multi file import
    Private clsLapply As RFunction
    Private clsFileList As RFunction
    ' Functions for multi Excel sheet impoty
    Private clsImportExcelMulti As RFunction
    Private bFirstLoad As Boolean
    Public bFromLibrary As Boolean
    Private strLibraryPath As String
    ' Private strFileType As String
    Private enumFileType As FileType
    Private bCanImport As Boolean
    Private bReset As Boolean = True
    Public bStartOpenDialog As Boolean
    Private strFilePathSystem As String
    Private strFilePathSystemTemp As String 'to hold and set back what was previously the path in the case of open from library
    'Private strFilePathR As String
    'Private strCurrentDirectory As String
    Public strFileToOpenOn As String
    Private bDialogLoaded As Boolean
    Private iDataFrameCount As Integer
    Private bMultiFiles As Boolean

    'Private strFileName As String

    Private bSupressCheckAllSheets As Boolean = False
    Private bSupressSheetChange As Boolean = False

    Dim dctSelectedExcelSheets As New Dictionary(Of Integer, String)

    Public Enum FileType
        XLSX
        XLS
        RDS
        TXT
        CSV
        DAT
        OTHER
    End Enum

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        bFromLibrary = False
        strLibraryPath = Path.Combine(frmMain.strStaticPath & "\Library")
        bCanImport = True
        bStartOpenDialog = True
        strFilePathSystem = ""
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
            If File.Exists(strFileToOpenOn) Then
                SetFilePathName(strFileToOpenOn)
            Else
                MsgBox("File no longer exists: " & strFileToOpenOn)
                SetFilePathName("")
            End If
            SetSelectedFileProperties()
            SetControlsAndBaseFunction()
            bStartOpenDialog = False
            strFileToOpenOn = ""
            bDialogLoaded = True
            RefreshFilePreview()
            RefreshGridPreview()
        ElseIf bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
            bDialogLoaded = True
            RefreshFilePreview()
            RefreshGridPreview()
        Else
            'if none of the above then try setting the displayed values from the previous contents of ucrInputFilePath.
            If Not String.IsNullOrEmpty(GetFilePathName()) AndAlso Not File.Exists(GetFilePathName(bInSystemFormat:=True)) Then
                MsgBox("File no longer exists: " & strFilePathSystem, MsgBoxStyle.Information, "File No Longer Exists")
                SetFilePathName("")
            End If
            SetSelectedFileProperties()
            SetControlsAndBaseFunction()
            'still refresh the preview. Incase the dialog was previously opened from the library
            bDialogLoaded = True
            RefreshFilePreview()
            RefreshGridPreview()
        End If

        'temporary fix for autotranslate(me) translating this to Label1. Can be removed after that
        ucrSaveFile.SetLabelText("New Data Frame Name:")
        bDialogLoaded = True
        bReset = False
        TestOkEnabled()
    End Sub

    Private Function GetFilePathName(Optional bInSystemFormat As Boolean = False) As String
        Return If(bInSystemFormat, Strings.Replace(ucrInputFilePath.GetText, "/", "\"), ucrInputFilePath.GetText)
    End Function

    Private Sub SetFilePathName(strFilePath As String)
        'set file path in R format. Control is used in producibf R code
        ucrInputFilePath.SetName(Strings.Replace(strFilePath, "\", "/"))
    End Sub

    Private Function GetFileName() As String
        Return Path.GetFileNameWithoutExtension(GetFilePathName(bInSystemFormat:=True))
    End Function

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
    Private Function GetCleanFileName() As String
        Dim strCleanFileName As String
        strCleanFileName = System.Text.RegularExpressions.Regex.Replace(GetFileName(), "[^A-Za-z0-9_\-]", "")
        If String.IsNullOrEmpty(strCleanFileName) Then
            strCleanFileName = "defaultCleanFileName"
        End If
        Return strCleanFileName
    End Function

    Private Function GetFileExtension() As String
        Return Path.GetExtension(GetFilePathName(bInSystemFormat:=True))
    End Function

    Private Sub InitialiseDialog()
        Dim dctucrInputSeparatorCSV As New Dictionary(Of String, String)
        Dim dctucrInputEncodingCSV As New Dictionary(Of String, String)
        Dim dctucrInputDecimalCSV As New Dictionary(Of String, String)
        Dim dctucrInputHeadersCSV As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 11

        'Removes the Sheet Tab control
        grdDataPreview.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdDataPreview.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)

        '##############################################################
        'General Controls
        ucrInputFilePath.SetParameter(New RParameter("file"))

        ucrSaveFile.SetLabelText("New Data Frame Name:")
        ucrSaveFile.SetIsTextBox()
        ucrSaveFile.SetSaveTypeAsDataFrame()
        ucrSaveFile.ucrInputTextSave.bAutoChangeOnLeave = True

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
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoSeparatortext, {"read_table", "read_table2"}, bNewIsPositive:=False)
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthText, "read_table", bNewIsPositive:=True)
        ucrPanelFixedWidthText.AddFunctionNamesCondition(rdoFixedWidthWhiteSpacesText, "read_table2", bNewIsPositive:=True)

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
        clsRangeOperator = New ROperator
        clsEnc2Native = New RFunction

        clsLapply = New RFunction

        clsImportExcelMulti = New RFunction
        clsFileList = New RFunction

        clsImportFixedWidthText.SetPackageName("readr")
        clsImportFixedWidthText.SetRCommand("read_table")

        clsImportExcel.SetPackageName("rio")
        clsImportExcel.SetRCommand("import")
        clsImportExcel.AddParameter("guess_max", "Inf")

        clsRangeOperator.SetOperation(":", bBracketsTemp:=False)
        clsRangeOperator.bToScriptAsRString = True
        clsRangeOperator.bSpaceAroundOperation = False

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

        'This R command ensures that any file paths containing special characters (e.g. accents) 
        'are correctly encoded
        clsEnc2Native.SetRCommand("enc2native")

        clsGetExcelSheetNames.SetPackageName("readxl")
        clsGetExcelSheetNames.SetRCommand("excel_sheets")
        'Ensure that the file path is enclosed by 'enc2native' to ensure that file paths containing 
        'special characters(e.g.accents) are correctly encoded
        clsGetExcelSheetNames.AddParameter("path", "", clsEnc2Native, Nothing, Nothing, True, 0)

        clsLapply.SetRCommand("lappy")
        clsLapply.AddParameter("X", clsRFunctionParameter:=clsFileList, iPosition:=0)

        clsImportExcelMulti.SetPackageName("rio")
        clsImportExcelMulti.SetRCommand("import_list")
        clsImportExcelMulti.AddParameter("guess_max", "Inf", iPosition:=6)

        clsFileList.SetRCommand("c")

        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")

        ucrBase.clsRsyntax.SetBaseRFunction(clsImport)

        strFilePathSystem = ""
        enumFileType = Nothing

        dctSelectedExcelSheets.Clear()
        clbSheets.Items.Clear() 'reset this here. Not set by R code
        ucrInputMissingValueStringExcel.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringCSV.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringText.SetName("") 'reset this here. Not set by R code 

        ucrNudPreviewLines.Value = 10

        grpExcel.Visible = False
        ucrPanelFixedWidthText.Hide()
        grpText.Visible = False
        grpCSV.Visible = False
        grpRDS.Visible = False
        ExcelSheetPreviewVisible(False)
        TextPreviewVisible(False, "")
        GridPreviewVisible(False, "")
        ucrSaveFile.Visible = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        SetSelectedFileProperties()
        SetControlsAndBaseFunction()
        'RefreshGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrInputFilePath.IsEmpty() Then
            ucrBase.OKEnabled(False)
        ElseIf Not bCanImport AndAlso Not ucrSaveFile.IsComplete Then
            ucrBase.OKEnabled(False)
        ElseIf enumFileType = FileType.RDS Then
            ucrBase.OKEnabled(True)
        ElseIf enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            ucrBase.OKEnabled(dctSelectedExcelSheets.Count > 0)
        End If

        'If (ucrSaveFile.IsComplete OrElse enumFileType = FileType.RDS) AndAlso bCanImport Then
        '    If enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
        '        ucrBase.OKEnabled(dctSelectedExcelSheets.Count > 0)
        '    Else
        '        ucrBase.OKEnabled(True)
        '    End If
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    'Loads the open dialog on load and click
    Private Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html;*.dly|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html|DLY|*.dly|All files|*.*"
            dlgOpen.Multiselect = False
            If bFromLibrary Then
                dlgOpen.Title = "Import from library"
                dlgOpen.InitialDirectory = strLibraryPath
            Else
                dlgOpen.Title = "Open Data from file"
                dlgOpen.InitialDirectory = If(String.IsNullOrEmpty(strFilePathSystem), frmMain.clsInstatOptions.strWorkingDirectory, Path.GetDirectoryName(strFilePathSystem))
            End If

            If DialogResult.OK = dlgOpen.ShowDialog() Then
                ucrSaveFile.Reset()
                dctSelectedExcelSheets.Clear()
                SetFilePathName(dlgOpen.FileName)
                SetSelectedFileProperties()
                SetControlsAndBaseFunction()
            Else
                If String.IsNullOrEmpty(GetFilePathName()) Then
                    SetSelectedFileProperties()
                    SetControlsAndBaseFunction()
                End If
            End If
        End Using
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportFixedWidthText, New RParameter("file", 0), iAdditionalPairNo:=1)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportCSV, New RParameter("file", 0), iAdditionalPairNo:=2)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportDAT, New RParameter("file", 0), iAdditionalPairNo:=3)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcel, New RParameter("file", 0), iAdditionalPairNo:=4)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsReadRDS, New RParameter("file", 0), iAdditionalPairNo:=5)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsEnc2Native, New RParameter("path", 0, False), iAdditionalPairNo:=6)
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
        ucrNudRowsToSkipText.SetRCode(clsImportFixedWidthText, bReset)
        ucrNudMaxRowsText.SetRCode(clsImportFixedWidthText, bReset)
        ucrChkMaxRowsText.SetRCode(clsImportFixedWidthText, bReset)

        'CSV CONTROLS
        ucrInputSeparatorCSV.SetRCode(clsImportCSV, bReset)
        ucrInputHeadersCSV.SetRCode(clsImportCSV, bReset)
        ucrInputDecimalCSV.SetRCode(clsImportCSV, bReset)
        ucrInputEncodingCSV.SetRCode(clsImportCSV, bReset)
        ucrChkStringsAsFactorsCSV.SetRCode(clsImportCSV, bReset)
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
    End Sub

    Private Sub TextPreviewVisible(bVisible As Boolean, strTextRead As String)
        panelTextPreview.Visible = bVisible
        txtTextFilePreview.Text = strTextRead
    End Sub

    Private Sub ExcelSheetPreviewVisible(bVisible As Boolean)
        panelSheets.Visible = bVisible
    End Sub

    Private Sub GridPreviewVisible(bVisible As Boolean, strGridText As String)
        lblDataFramePreview.Visible = bVisible
        lblLinesToPreview.Visible = bVisible
        ucrNudPreviewLines.Visible = bVisible
        btnRefreshPreview.Visible = bVisible
        grdDataPreview.Visible = bVisible
        lblCannotImport.Visible = bVisible

        If Not bVisible AndAlso Not String.IsNullOrEmpty(strGridText) Then
            lblCannotImport.Visible = True
            'todo. check if text is a multiline. if so change the alignement in the label
            If dctSelectedExcelSheets.Count > 1 Then
                lblCannotImport.TextAlign = ContentAlignment.TopLeft
            Else
                lblCannotImport.TextAlign = ContentAlignment.TopCenter
            End If
            lblCannotImport.Text = strGridText
        End If
    End Sub

    Private Sub SetSelectedFileProperties()
        If String.IsNullOrEmpty(GetFilePathName()) Then
            strFilePathSystem = ""
        Else
            If bFromLibrary Then
                strFilePathSystemTemp = strFilePathSystem 'store what was there temporarily first 
            End If
            strFilePathSystem = GetFilePathName(bInSystemFormat:=True)
        End If

        enumFileType = GetFileType(GetFileExtension)
    End Sub

    Private Sub SetControlsAndBaseFunction()

        grpExcel.Visible = False
        ucrPanelFixedWidthText.Visible = False
        grpText.Visible = False
        grpRDS.Visible = False
        grpCSV.Visible = False
        TextPreviewVisible(False, "")
        ExcelSheetPreviewVisible(False)
        GridPreviewVisible(False, "")
        ucrSaveFile.Visible = False

        'If String.IsNullOrEmpty(GetFilePathName()) Then
        '    strFilePathSystem = ""
        'Else
        '    If bFromLibrary Then
        '        strFilePathSystemTemp = strFilePathSystem 'store what was there temporarily first 
        '    End If
        '    strFilePathSystem = GetFilePathName(bInSystemFormat:=True)
        'End If
        'enumFileType = GetFileType(GetFileExtension)


        If IsNothing(enumFileType) Then
            Exit Sub
        End If

        'TODO This needs to be different when RDS is a data frame
        'need to be able to detect RDS as data.frame/Instat Object
        If enumFileType = FileType.RDS Then
            clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
            grpRDS.Visible = True
        ElseIf enumFileType = FileType.TXT Then
            'add or change format parameter values
            clsImportCSV.AddParameter("format", Chr(34) & "txt" & Chr(34), iPosition:=1)
            'by default the textfiles will be imported using the function we use for csv
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            ucrPanelFixedWidthText.Visible = True
            grpCSV.Text = "Import Text Options"
            grpCSV.Location = New System.Drawing.Point(9, 99) 'set the location of the groupbox to adjust gaps in the form UI
            grpCSV.Visible = True
        ElseIf enumFileType = FileType.CSV Then
            'add format. forces rio to treat other csv format files, like .dly files, as csv 
            clsImportCSV.AddParameter("format", Chr(34) & "csv" & Chr(34), iPosition:=1)
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            grpCSV.Text = "Import CSV Options"
            grpCSV.Location = New System.Drawing.Point(9, 50) 'set the location of the groupbox to adjust gaps in the form UI
            grpCSV.Visible = True
        ElseIf enumFileType = FileType.DAT Then
            clsImportDAT.AddParameter("file", Chr(34) & GetFilePathName() & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportDAT)
        ElseIf enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            ucrBase.clsRsyntax.SetBaseRFunction(If(clbSheets.CheckedItems.Count > 1, clsImportExcelMulti, clsImportExcel))
            grpExcel.Visible = True
            ExcelSheetPreviewVisible(True)
            FillExcelSheets()
        ElseIf enumFileType = FileType.OTHER Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
        End If

        'make file names valid, overwrite if file name except for excel(done elsewhere) and rds files
        If enumFileType <> FileType.RDS AndAlso enumFileType <> FileType.XLSX AndAlso enumFileType AndAlso FileType.XLS Then
            ucrSaveFile.SetName(frmMain.clsRLink.MakeValidText(GetCleanFileName), bSilent:=True)
        End If

        'for rds and null file types hide ucrSave controls
        If enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            'if excel file then make ucrSave control visible if only 1 file selected 
            ucrSaveFile.Visible = (clbSheets.CheckedItems.Count = 0)
        ElseIf enumFileType <> FileType.RDS Then
            ucrSaveFile.Visible = True
        End If
    End Sub

    Private Function RefreshFilePreview() As Boolean
        Dim bValid As Boolean = False
        Dim strRead As String
        Dim iRowsToSkip As Integer = 0
        Dim strFilePathWindowsSystem As String = GetFilePathName(bInSystemFormat:=True)

        TextPreviewVisible(False, "")

        If Not bDialogLoaded OrElse String.IsNullOrEmpty(strFilePathWindowsSystem) Then
            Return bValid
        End If

        'only read files that are of type txt and csv
        If enumFileType <> FileType.CSV OrElse enumFileType <> FileType.TXT Then
            Return bValid
        End If

        'change path from R format to windows format
        strFilePathWindowsSystem = Strings.Replace(strFilePathWindowsSystem, "/", "\",)

        If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
            iRowsToSkip = ucrNudRowsToSkipText.Value
        ElseIf rdoSeparatortext.Checked Then
            iRowsToSkip = ucrNudRowsToSkipCSV.Value
        End If

        Try
            Using sReader As New StreamReader(strFilePathWindowsSystem)
                strRead = ""
                For i = 1 To ucrNudPreviewLines.Value + iRowsToSkip + 1
                    strRead = strRead & sReader.ReadLine() & Environment.NewLine
                    If sReader.Peek() = -1 Then
                        Exit For
                    End If
                Next
            End Using

            bValid = True
            TextPreviewVisible(True, strRead)
        Catch ex As Exception
            TextPreviewVisible(True, "Cannot show text preview of file:" & strFilePathWindowsSystem & ". The file may have moved or be in use by another program. Close the file and select it again from the dialog to refresh the preview.")
        End Try

        Return bValid
    End Function

    Private Function RefreshGridPreview() As Boolean
        Dim bValid As Boolean = False

        GridPreviewVisible(False, "")
        If Not bDialogLoaded Then
            Return bValid
        End If

        Dim dfTemp As DataFrame
        Dim expTemp As SymbolicExpression
        Dim strTempDataFrameName As String = "temp"
        Dim clsAsCharacterFunc As New RFunction
        Dim clsTempImport As New RFunction
        Dim iTemp As Integer
        Dim strRowMaxParamName As String = ""
        Dim bshowPreview As Boolean = False

        GridPreviewVisible(False, "")
        If enumFileType = FileType.TXT Then
            If rdoSeparatortext.Checked Then
                'for separator we use the function used for csv
                clsTempImport = clsImportCSV.Clone()
                strRowMaxParamName = "nrows"
            Else
                clsTempImport = clsImportFixedWidthText.Clone()
                strRowMaxParamName = "n_max"
            End If
            bshowPreview = True
        ElseIf enumFileType = FileType.CSV Then
            clsTempImport = clsImportCSV.Clone()
            strRowMaxParamName = "nrows"
            bshowPreview = True
        ElseIf enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            If dctSelectedExcelSheets.Count = 0 Then
                GridPreviewVisible(False, "No sheet selected.")
            ElseIf dctSelectedExcelSheets.Count > 1 Then
                bValid = True
                GridPreviewVisible(False, "Importing the following sheets:" & Environment.NewLine & String.Join(", ", dctSelectedExcelSheets.Values))
            Else
                clsTempImport = clsImportExcel.Clone()
                strRowMaxParamName = "n_max"
                bshowPreview = True
            End If
        Else
            GridPreviewVisible(False, "Preview not yet implemented for this file type.")
        End If

        If Not bshowPreview Then
            Return bValid
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
        clsAsCharacterFunc.SetRCommand("convert_to_character_matrix")
        clsAsCharacterFunc.AddParameter("data", clsRFunctionParameter:=clsTempImport)
        'Cursor = Cursors.WaitCursor
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunc.ToScript(), bSilent:=True)
        dfTemp = expTemp?.AsDataFrame
        'Cursor = Cursors.Default
        If dfTemp IsNot Nothing Then
            Try
                grdDataPreview.Worksheets.Clear()
                frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=False, iColMax:=frmMain.clsGrids.iMaxCols)
                'grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
                'grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
                bValid = True
                GridPreviewVisible(True, "")
            Catch
                GridPreviewVisible(False, "Could not preview file.")
            End Try
        End If

        Return bValid
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        GetFileFromOpenDialog()
        TestOkEnabled()
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
        ' add the item to the MRU (Most Recently Used) list...
        'Disabled until implemented correctly
        frmMain.clsRecentItems.addToMenu(strFilePathSystem)
        'Sets the current data frame as the first new data frame
        'Needed so that if multiple data frames imported, the last one is not the current data frame
        frmMain.SetCurrentDataFrame(iDataFrameCount)
    End Sub

    Private Sub ucrNudPreviewLines_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudPreviewLines.ControlContentsChanged
        RefreshFilePreview()
        RefreshGridPreview()
    End Sub

    Private Sub btnRefreshPreview_Click(sender As Object, e As EventArgs) Handles btnRefreshPreview.Click
        RefreshFilePreview()
        RefreshGridPreview()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTrimWSExcel.ControlValueChanged, ucrNudRowsToSkipExcel.ControlValueChanged, ucrChkColumnNamesExcel.ControlValueChanged, ucrChkColumnNamesText.ControlValueChanged, ucrNudRowsToSkipText.ControlValueChanged, ucrChkMaxRowsText.ControlValueChanged, ucrChkMaxRowsCSV.ControlValueChanged, ucrChkMaxRowsExcel.ControlValueChanged, ucrNudMaxRowsText.ControlValueChanged, ucrNudMaxRowsCSV.ControlValueChanged, ucrNudMaxRowsExcel.ControlValueChanged, ucrChkStringsAsFactorsCSV.ControlValueChanged, ucrInputEncodingCSV.ControlValueChanged, ucrInputSeparatorCSV.ControlValueChanged, ucrInputHeadersCSV.ControlValueChanged, ucrInputDecimalCSV.ControlValueChanged, ucrNudRowsToSkipCSV.ControlValueChanged
        RefreshGridPreview()
    End Sub

    Private Sub MissingValuesInputControls_ContentsChanged() Handles ucrInputMissingValueStringText.ContentsChanged, ucrInputMissingValueStringCSV.ContentsChanged, ucrInputMissingValueStringExcel.ContentsChanged
        'currently we have no way of knowing which control has raised this event and therefore can't do that check
        'so instead we are using the strFileType to identify which RFunctions should be updated accordingly
        If enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            'set for single imports and multiple imports 
            clsImportExcelMulti.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringExcel.GetText()))
            clsImportExcel.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringExcel.GetText()))
        ElseIf enumFileType = FileType.CSV Then
            clsImportCSV.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
        ElseIf enumFileType = FileType.TXT Then
            'for separator we use the function used for csv
            If rdoSeparatortext.Checked Then
                clsImportCSV.AddParameter("na.strings", GetMissingValueRString(ucrInputMissingValueStringCSV.GetText()), iPosition:=2)
            Else
                clsImportFixedWidthText.AddParameter("na", GetMissingValueRString(ucrInputMissingValueStringText.GetText()), iPosition:=2)
            End If
        End If
        'RefreshGridPreview()
        TestOkEnabled()
    End Sub

    Private Sub UcrPanelFixedWidthText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPanelFixedWidthText.ControlValueChanged
        If enumFileType <> FileType.TXT Then
            Exit Sub
        End If

        grpCSV.Visible = False
        grpText.Visible = False
        If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
            clsImportFixedWidthText.SetRCommand(If(rdoFixedWidthText.Checked, "read_table", "read_table2"))
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportFixedWidthText)
            grpText.Visible = True
        ElseIf rdoSeparatortext.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            grpCSV.Visible = True
        End If



        'RefreshFilePreview()
        'RefreshGridPreview()

    End Sub

    Private Sub clbSheets_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbSheets.ItemCheck

        If bSupressSheetChange Then
            Exit Sub
        End If

        If enumFileType <> FileType.XLSX OrElse enumFileType <> FileType.XLS Then
            Exit Sub
        End If

        Dim strSheetNumbers As String

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
            clsImportExcel.RemoveParameterByName("which")
            clsImportExcelMulti.RemoveParameterByName("which")
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            ucrSaveFile.Visible = True
            ucrSaveFile.SetDataFrameNames("")
        ElseIf dctSelectedExcelSheets.Count = 1 Then
            strSheetNumbers = dctSelectedExcelSheets.Keys.First()
            clsImportExcel.AddParameter("which", strSheetNumbers)
            ucrSaveFile.SetName(dctSelectedExcelSheets.Values.First(), bSilent:=True)
            ucrSaveFile.Focus()
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcel)
            ucrSaveFile.Visible = True
            ucrSaveFile.SetDataFrameNames("")
        Else
            strSheetNumbers = "c(" & String.Join(",", dctSelectedExcelSheets.Keys) & ")"
            clsImportExcelMulti.AddParameter("which", strSheetNumbers)
            ucrSaveFile.SetName(frmMain.clsRLink.MakeValidText(GetCleanFileName), bSilent:=True)
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportExcelMulti)
            ucrSaveFile.Visible = False
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
        'RefreshGridPreview()
        TestOkEnabled()

    End Sub

    Private Sub ucrChkSheetsCheckAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSheetsCheckAll.ControlValueChanged
        If bSupressCheckAllSheets Then
            Exit Sub
        End If

        Dim bCheckAll As Boolean
        bCheckAll = ucrChkSheetsCheckAll.Checked
        bSupressSheetChange = True
        For i As Integer = 0 To clbSheets.Items.Count - 1
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
                enumFileType = Nothing
                strFilePathSystem = ""
                SetFilePathName("")
            Else
                SetFilePathName(strFilePathSystemTemp)
                enumFileType = GetFileType(GetFileExtension)
                strFilePathSystem = strFilePathSystemTemp
            End If
        End If
    End Sub

    Private Sub ucrChkRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRange.ControlValueChanged
        If ucrChkRange.Checked Then
            clsImportExcel.AddParameter("range", clsROperatorParameter:=clsRangeOperator)
        Else
            clsImportExcel.RemoveParameterByName("range")
        End If
    End Sub

    ''' <summary>
    ''' Creates an R string to be used as the parameter value for na.strings and na parameters 
    ''' </summary>
    ''' <param name="strText">The string that will be used to create the R Text</param>
    ''' <returns></returns>
    Private Function GetMissingValueRString(strText As String) As String
        Dim arrStr() As String = strText.Split(",")

        'if length is = 1 return an R string else return a vector of strings for R.
        'please note the array length will never be 0
        If arrStr.Length = 1 Then
            Return Chr(34) & arrStr(0) & Chr(34)
        End If

        Dim strRmissingValueString As String = ""
        For Each strTemp As String In arrStr
            If strRmissingValueString = "" Then
                strRmissingValueString = Chr(34) & strTemp.Trim & Chr(34)
            Else
                strRmissingValueString = strRmissingValueString & "," & Chr(34) & strTemp.Trim & Chr(34)
            End If
        Next
        strRmissingValueString = "c(" & strRmissingValueString & ")"
        Return strRmissingValueString
    End Function


    ''' <summary>
    ''' gets file type enumeration that corresponds to the passed file extension
    ''' </summary>
    ''' <param name="strFileExtension">File extension</param>
    ''' <returns></returns>
    Private Function GetFileType(strFileExtension As String) As FileType
        If String.IsNullOrEmpty(strFileExtension) Then
            Return Nothing
        End If

        strFileExtension = strFileExtension.ToLower
        Select Case strFileExtension
            Case ".rds"
                Return FileType.RDS
            Case ".xlsx"
                Return FileType.XLSX
            Case ".xls"
                Return FileType.XLS
            Case ".txt"
                Return FileType.TXT
            Case ".csv", ".dly"
                '.dly are read and supported as normal csv file
                Return FileType.CSV
            Case ".dat"
                Return FileType.DAT
            Case Else
                Return FileType.OTHER
        End Select

    End Function

End Class
