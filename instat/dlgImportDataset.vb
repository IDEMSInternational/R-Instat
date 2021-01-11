Imports System.IO
Imports RDotNet
Imports instat.Translations

Public Class dlgImportDataset
    'RFunctions used for importing different file types
    Private clsImportFixedWidthText, clsImportCSV, clsImportRDS, clsReadRDS, clsImportExcel, clsImportExcelMulti, clsImport As RFunction
    'used as a "range" parameter for clsImportExcel RFunction
    Private clsRangeOperator As ROperator
    'used in getting excel sheet names from selected excel file
    Private clsGetExcelSheetNames As RFunction
    'used to ensure that any file paths containing special characters (e.g. accents) are correctly encoded.
    Private clsEnc2Native As RFunction

    'to be used, in future, when multi file import is supported
    Private clsLapply As RFunction
    Private clsFileList As RFunction

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bDialogLoaded As Boolean

    'holds supported enumeration file type of selected file
    Private enumFileType As FileType

    Public bStartOpenDialog As Boolean = True
    Public bFromLibrary As Boolean = False
    Public strFileToOpenOn As String = ""

    'holds and set back what was previously the path in the case of open from library
    Private strFilePathSystemTemp As String = ""

    'todo. delete this
    Private iDataFrameCount As Integer

    'flag used to suppress click event of select all sheets checkbox
    Private bSupressCheckAllSheets As Boolean = False
    'flag used to suppress click event of checked list box that has list of sheet names
    Private bSupressSheetChange As Boolean = False
    'holds list of selected excel sheet names(sheet number, sheet name)
    Dim dctSelectedExcelSheets As New Dictionary(Of Integer, String)

    Public Enum FileType
        XLSX
        XLS
        RDS
        TXT
        CSV
        DLY
        DAT
        OTHER
    End Enum

    Private Sub dlgImportDataset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bDialogLoaded = False
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetRCodeForControls(bReset)
        bReset = False
        If Not String.IsNullOrEmpty(strFileToOpenOn) Then
            If File.Exists(strFileToOpenOn) Then
                SetSelectedFileProperties(strFileToOpenOn)
            Else
                MsgBox("File no longer exists: " & strFileToOpenOn, MsgBoxStyle.Information, "File No Longer Exists")
                SetSelectedFileProperties("")
            End If
            SetControlsAndBaseFunction()
            bStartOpenDialog = False
            strFileToOpenOn = ""
        ElseIf bStartOpenDialog Then
            GetFileFromOpenDialog()
            bStartOpenDialog = False
        Else
            'if none of the above then try setting displayed values from the previous selected file path.
            If Not String.IsNullOrEmpty(GetSelectedFilePath()) AndAlso Not File.Exists(GetSelectedFilePath(bInSystemFormat:=True)) Then
                MsgBox("File no longer exists: " & GetSelectedFilePath(), MsgBoxStyle.Information, "File No Longer Exists")
                SetSelectedFileProperties("")
            End If
            SetControlsAndBaseFunction()
        End If

        'temporary fix for autotranslate(me) translating this to Label1. Can be removed after that
        ucrSaveFile.SetLabelText("New Data Frame Name:")
        bDialogLoaded = True
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
        clsImport = New RFunction

        clsImportFixedWidthText = New RFunction
        clsImportCSV = New RFunction

        clsImportRDS = New RFunction
        clsReadRDS = New RFunction

        clsImportExcel = New RFunction
        clsImportExcelMulti = New RFunction
        clsRangeOperator = New ROperator
        clsGetExcelSheetNames = New RFunction
        clsEnc2Native = New RFunction

        clsLapply = New RFunction
        clsFileList = New RFunction


        clsImport.SetPackageName("rio")
        clsImport.SetRCommand("import")

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


        'This R command ensures that any file paths containing special characters (e.g. accents) 
        'are correctly encoded
        clsEnc2Native.SetRCommand("enc2native")

        clsGetExcelSheetNames.SetPackageName("readxl")
        clsGetExcelSheetNames.SetRCommand("excel_sheets")
        'Ensure that the file path is enclosed by 'enc2native' to ensure that file paths containing 
        'special characters(e.g.accents) are correctly encoded
        clsGetExcelSheetNames.AddParameter("path", "", clsEnc2Native, Nothing, Nothing, True, 0)

        clsFileList.SetRCommand("c")
        clsLapply.SetRCommand("lappy")
        clsLapply.AddParameter("X", clsRFunctionParameter:=clsFileList, iPosition:=0)

        clsImportExcelMulti.SetPackageName("rio")
        clsImportExcelMulti.SetRCommand("import_list")
        clsImportExcelMulti.AddParameter("guess_max", "Inf", iPosition:=6)

        clsReadRDS.SetRCommand("readRDS")
        clsReadRDS.SetAssignTo("new_RDS")
        clsImportRDS.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_RDS")
        clsImportRDS.AddParameter("data_RDS", clsRFunctionParameter:=clsReadRDS)

        SetSelectedFileProperties("")
        SetControlsAndBaseFunction()
        ucrSaveFile.Reset()
        dctSelectedExcelSheets.Clear()
        chkListBoxSheetNames.Items.Clear() 'reset this here. Not set by R code
        ucrInputMissingValueStringExcel.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringCSV.SetName("") 'reset this here. Not set by R code 
        ucrInputMissingValueStringText.SetName("") 'reset this here. Not set by R code 
        ucrNudPreviewLines.Value = 10
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportFixedWidthText, New RParameter("file", 0), iAdditionalPairNo:=1)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportCSV, New RParameter("file", 0), iAdditionalPairNo:=2)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcel, New RParameter("file", 0), iAdditionalPairNo:=3)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsReadRDS, New RParameter("file", 0), iAdditionalPairNo:=4)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsEnc2Native, New RParameter("path", 0, False), iAdditionalPairNo:=5)
        ucrInputFilePath.AddAdditionalCodeParameterPair(clsImportExcelMulti, New RParameter("file", 0), iAdditionalPairNo:=6)
        ucrInputFilePath.SetRCode(clsImport, bReset)

        'Save control
        ucrSaveFile.AddAdditionalRCode(clsImportFixedWidthText, iAdditionalPairNo:=1)
        ucrSaveFile.AddAdditionalRCode(clsImportCSV, iAdditionalPairNo:=2)
        ucrSaveFile.AddAdditionalRCode(clsImportExcel, iAdditionalPairNo:=3)
        ucrSaveFile.AddAdditionalRCode(clsImportExcelMulti, iAdditionalPairNo:=4) 'todo. 6??
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

    ''' <summary>
    ''' sets the selected file path and file type used in the dialog 
    ''' </summary>
    ''' <param name="strFilePath"></param>
    Private Sub SetSelectedFileProperties(strFilePath As String)
        If String.IsNullOrEmpty(strFilePath) Then
            ucrInputFilePath.SetName("")
            enumFileType = FileType.OTHER
        Else
            If bFromLibrary Then
                'store what was there temporarily first 
                strFilePathSystemTemp = GetSelectedFilePath(bInSystemFormat:=True)
            End If
            'set file path in R format. Control is used in R code
            ucrInputFilePath.SetName(Strings.Replace(strFilePath, "\", "/"))
            enumFileType = GetFileType(Path.GetExtension(GetSelectedFilePath(bInSystemFormat:=True)))
        End If
    End Sub

    ''' <summary>
    ''' get select file path, file name and extension is included
    ''' </summary>
    ''' <param name="bInSystemFormat">
    ''' Optional. Default is False
    ''' if set to true, file path returned is in system format. 
    ''' If set to false, file path returned is in R format </param>
    ''' <returns></returns>
    Private Function GetSelectedFilePath(Optional bInSystemFormat As Boolean = False) As String
        Return If(bInSystemFormat, Strings.Replace(ucrInputFilePath.GetText, "/", "\"), ucrInputFilePath.GetText)
    End Function

    ''' <summary>
    ''' Extracts the name of the file (without the extension) from selected file path.
    ''' It removes any special characters (i.e. any characters that are not letters, digits '_' or '-').
    ''' It returns the resulting clean name. If the cleaned name is an empty string then returns 'defaultCleanName'.
    ''' The special characters need to be removed otherwise they trigger an error in some R commands.
    ''' </summary>
    ''' <returns>  
    ''' Returns the file name (without extension) with any special characters removed.
    ''' If the cleaned name is an empty string then returns 'defaultCleanName'.
    ''' </returns>
    Private Function GetCleanedSelectedFileName() As String
        Return GetCleanedName(Path.GetFileNameWithoutExtension(GetSelectedFilePath(bInSystemFormat:=True)))
    End Function
    ''' <summary>
    ''' It removes any special characters (i.e. any characters that are not letters, digits '_' or '-') from the passed string name
    ''' It returns the resulting clean name. If the cleaned name is an empty string then returns 'defaultCleanName'.
    ''' The special characters need to be removed otherwise they trigger an error in some R commands.
    ''' </summary>
    ''' <returns>  
    ''' Returns the file name (without extension) with any special characters removed.
    ''' If the cleaned name is an empty string then returns 'defaultCleanName'.
    ''' </returns>
    Private Function GetCleanedName(strName As String) As String
        Dim strCleanName As String
        strCleanName = System.Text.RegularExpressions.Regex.Replace(strName, "[^A-Za-z0-9_\-]", "")
        If String.IsNullOrEmpty(strCleanName) Then
            strCleanName = "defaultCleanName"
        End If
        Return frmMain.clsRLink.MakeValidText(strCleanName)
    End Function

    Private Sub SetControlsAndBaseFunction()
        grpExcel.Visible = False
        ucrPanelFixedWidthText.Visible = False
        grpText.Visible = False
        grpRDS.Visible = False
        grpCSV.Visible = False
        TextPreviewVisible(False, "")
        ExcelSheetsNamesVisible(False)
        GridPreviewVisible(False, "")
        ucrSaveFile.Visible = False

        'TODO. In future, this needs to be different when RDS is a data frame
        'need to be able to detect RDS as data.frame/Instat Object
        If enumFileType = FileType.RDS Then
            grpRDS.Visible = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportRDS)
        ElseIf enumFileType = FileType.TXT Then
            ucrPanelFixedWidthText.Visible = True
            If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
                grpText.Visible = True
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportFixedWidthText)
            ElseIf rdoSeparatortext.Checked Then
                grpCSV.Visible = True
                grpCSV.Text = "Import Text Options"
                'set the location of the groupbox to adjust gaps in the form UI
                grpCSV.Location = New System.Drawing.Point(9, 99)
                'by default the textfiles will be imported using the function we use for csv
                ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
            End If
        ElseIf enumFileType = FileType.CSV OrElse enumFileType = FileType.DLY Then
            '.dly are read and supported as normal csv file, therefore use csv controls
            grpCSV.Visible = True
            grpCSV.Text = "Import CSV Options"
            'set the location of the groupbox to adjust gaps in the form UI
            grpCSV.Location = New System.Drawing.Point(9, 50)
            'add format. forces rio to treat other csv format files, e.g .dly files, as csv 
            clsImportCSV.AddParameter("format", Chr(34) & "csv" & Chr(34), iPosition:=1)
            ucrBase.clsRsyntax.SetBaseRFunction(clsImportCSV)
        ElseIf enumFileType = FileType.DAT Then
            'needed as rio currently doesn't support .DAT files https://github.com/leeper/rio/issues/155
            'so force rio to read .DAT file as text based, this seems to be common usage
            clsImport.AddParameter("format", Chr(34) & "txt" & Chr(34))
            ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
        ElseIf enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            grpExcel.Visible = True
            ExcelSheetsNamesVisible(True)
            FillExcelSheets()
            SetExcelBaseFunctionAndSaveProperties()
        ElseIf enumFileType = FileType.OTHER Then
            clsImport.RemoveParameterByName("format")
            ucrBase.clsRsyntax.SetBaseRFunction(clsImport)
        End If

        'overwrite file names except for excel and rds file
        If enumFileType <> FileType.RDS AndAlso enumFileType <> FileType.XLSX AndAlso enumFileType <> FileType.XLS Then
            If Not String.IsNullOrEmpty(GetSelectedFilePath()) Then
                ucrSaveFile.Visible = True
                ucrSaveFile.SetName(GetCleanedSelectedFileName, bSilent:=True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' fills sheet names to be displayed in the list box
    ''' </summary>
    Private Sub FillExcelSheets()
        Dim expSheet As SymbolicExpression
        Dim chrSheets As CharacterVector

        expSheet = frmMain.clsRLink.RunInternalScriptGetValue(clsGetExcelSheetNames.ToScript())
        chrSheets = expSheet?.AsCharacter

        If chrSheets Is Nothing OrElse chrSheets.Count = 0 Then
            dctSelectedExcelSheets.Clear()
            chkListBoxSheetNames.Items.Clear()
            Exit Sub
        End If

        'check if sheet names are different from those already in the list box 
        Dim arrStrSheetNames() As String = chrSheets.ToArray()
        Dim bSheetNamesDifferent As Boolean = False
        Dim bFound As Boolean
        For Each strSheetName As String In arrStrSheetNames
            bFound = False
            'find the sheet name in the list box
            For i As Integer = 0 To chkListBoxSheetNames.Items.Count - 1
                If strSheetName = chkListBoxSheetNames.Items.Item(i).ToString Then
                    bFound = True
                    Exit For
                End If
            Next
            'if sheet name was not found then exit for. Sheet names are different
            If Not bFound Then
                bSheetNamesDifferent = True
                Exit For
            End If
        Next

        'if sheet names are same then no need to fill them to the listbox again
        If Not bSheetNamesDifferent Then
            Exit Sub
        End If

        'clear all the previously selected and filled items, then add the new sheet names 
        dctSelectedExcelSheets.Clear()
        chkListBoxSheetNames.Items.Clear()
        chkListBoxSheetNames.Items.AddRange(chrSheets.ToArray())
    End Sub

    Private Sub TestOkEnabled()
        If Not bDialogLoaded Then
            Exit Sub
        End If

        If ucrInputFilePath.IsEmpty() Then
            ucrBase.OKEnabled(False)
        ElseIf enumFileType = FileType.RDS Then
            GridPreviewVisible(False, "Preview not yet implemented for this file type")
            ucrBase.OKEnabled(True)
        ElseIf enumFileType = FileType.TXT OrElse enumFileType = FileType.CSV OrElse enumFileType = FileType.DLY Then
            If TestFileTextPreview() AndAlso TestFileGridPreview() Then
                ucrBase.OKEnabled(ucrSaveFile.IsComplete)
            End If
        ElseIf enumFileType = FileType.XLSX OrElse enumFileType = FileType.XLS Then
            If TestFileGridPreview() Then
                If dctSelectedExcelSheets.Count = 1 Then
                    ucrBase.OKEnabled(ucrSaveFile.IsComplete)
                Else
                    ucrBase.OKEnabled(dctSelectedExcelSheets.Count > 0)
                End If
            End If
        Else
            GridPreviewVisible(False, "Preview not yet implemented for this file type")
            ucrBase.OKEnabled(ucrSaveFile.IsComplete)
        End If
    End Sub

    ''' <summary>
    ''' used to preview text related files only e.g .txt,.csv and .dly files
    ''' also hides or shows the text preview controls if preview was successful 
    ''' </summary>
    ''' <returns>true if preview was successful</returns>
    Private Function TestFileTextPreview() As Boolean
        Dim bValid As Boolean = False
        Dim strRead As String
        Dim iRowsToSkip As Integer = 0
        Dim strFilePathSystemFormat As String

        TextPreviewVisible(False, "")
        'change path from R format to windows format
        strFilePathSystemFormat = GetSelectedFilePath(bInSystemFormat:=True)

        If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
            iRowsToSkip = ucrNudRowsToSkipText.Value
        ElseIf rdoSeparatortext.Checked Then
            iRowsToSkip = ucrNudRowsToSkipCSV.Value
        End If

        Try
            'todo. check if rows to skip has be well implemented
            Using sReader As New StreamReader(strFilePathSystemFormat)
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
            TextPreviewVisible(True, "Cannot show text preview of file:" & strFilePathSystemFormat & ". The file may have moved or be in use by another program. Close the file and select it again from the dialog to refresh the preview.")
        End Try

        Return bValid
    End Function

    ''' <summary>
    ''' used to preview excel or text related files e.g .xlsx, .xls, .txt, .dly
    ''' also hides or shows the grid preview controls if preview was successful 
    ''' </summary>
    ''' <returns>true if preview was successful</returns>
    Private Function TestFileGridPreview() As Boolean
        Dim bValid As Boolean = False
        Dim dfTemp As DataFrame
        Dim expTemp As SymbolicExpression
        Dim strTempDataFrameName As String = "temp"
        Dim clsAsCharacterFunc As New RFunction
        Dim clsTempImport As RFunction
        Dim iMaxRows As Integer
        Dim strRowMaxParamName As String

        Select Case enumFileType
            Case FileType.XLSX, FileType.XLS
                If dctSelectedExcelSheets.Count = 0 Then
                    GridPreviewVisible(False, "No sheet selected.")
                    Return bValid
                ElseIf dctSelectedExcelSheets.Count > 1 Then
                    bValid = True
                    GridPreviewVisible(False, "Importing the following sheets:" & Environment.NewLine & String.Join(", ", dctSelectedExcelSheets.Values))
                    Return bValid
                Else
                    strRowMaxParamName = "n_max"
                End If
            Case FileType.TXT
                'if separator selected use the csv "nrows" as parameter
                strRowMaxParamName = If(rdoSeparatortext.Checked, "nrows", "n_max")
            Case FileType.CSV, FileType.DLY
                strRowMaxParamName = "nrows"
            Case Else
                GridPreviewVisible(False, "Preview not yet implemented for this file type.")
                Return bValid
        End Select

        clsTempImport = ucrBase.clsRsyntax.clsBaseFunction.Clone()
        'set ideal maximum rows parameter value.
        If clsTempImport.ContainsParameter(strRowMaxParamName) AndAlso Integer.TryParse(clsTempImport.GetParameter(strRowMaxParamName).strArgumentValue, iMaxRows) Then
            iMaxRows = Math.Min(iMaxRows, ucrNudPreviewLines.Value)
        Else
            iMaxRows = ucrNudPreviewLines.Value
        End If
        'overwrite the maximum rows parameter value based on lowest set maximum rows
        clsTempImport.AddParameter(strRowMaxParamName, iMaxRows)

        clsTempImport.RemoveAssignTo()
        clsAsCharacterFunc.SetRCommand("convert_to_character_matrix")
        clsAsCharacterFunc.AddParameter("data", clsRFunctionParameter:=clsTempImport)
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacterFunc.ToScript(), bSilent:=True)
        dfTemp = expTemp?.AsDataFrame
        If dfTemp IsNot Nothing Then
            Try
                grdDataPreview.Worksheets.Clear()
                frmMain.clsGrids.FillSheet(dfTemp, strTempDataFrameName, grdDataPreview, bIncludeDataTypes:=False, iColMax:=frmMain.clsGrids.iMaxCols)
                grdDataPreview.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
                bValid = True
                GridPreviewVisible(True, "")
            Catch
                GridPreviewVisible(False, "Could not preview file.")
            End Try
        End If

        Return bValid
    End Function

    ''' <summary>
    ''' Loads the open dialog on load and browse click
    ''' </summary>
    Private Sub GetFileFromOpenDialog()
        Using dlgOpen As New OpenFileDialog
            dlgOpen.Filter = "All Data files|*.csv;*.txt;*.xls;*.xlsx;*.RDS;*.sav;*.tsv;*.csvy;*.feather;*.psv;*.RData;*.json;*.yml;*.dta;*.dbf;*.arff;*.R;*.sas7bdat;*.xpt;*.mtp;*.rec;*.syd;*.dif;*.ods;*.xml;*.html;*.dly|Comma separated files|*.csv|Text data file|*.txt|Excel files|*.xls;*.xlsx|R Data Structure files|*.RDS|SPSS files|*.sav|Tab separated files|*.tsv|CSV with a YAML metadata header|*.csvy|Feather R/Python interchange format|*.feather|Pipe separates files|*.psv|Saved R objects|*.RData|JSON|*.json|YAML|*.yml|Stata files|*.dta|XBASE database files|*.dbf|Weka Attribute-Relation File Format|*.arff|R syntax object|*.R|SAS Files|*.sas7bdat|SAS XPORT|*.xpt|Minitab Files|*.mtp|Epiinfo Files|*.rec|Systat Files|*.syd|Data Interchange Format|*.dif|OpenDocument Spreadsheet|*.ods|Shallow XML documents|*.xml|Single-table HTML documents|*.html|DLY|*.dly|All files|*.*"
            If bFromLibrary Then
                dlgOpen.Title = "Import from library"
                dlgOpen.InitialDirectory = Path.Combine(frmMain.strStaticPath & "\Library")
            Else
                dlgOpen.Title = "Open Data from file"
                dlgOpen.InitialDirectory = If(String.IsNullOrEmpty(GetSelectedFilePath), frmMain.clsInstatOptions.strWorkingDirectory, Path.GetDirectoryName(GetSelectedFilePath(bInSystemFormat:=True)))
            End If

            If DialogResult.OK = dlgOpen.ShowDialog() Then
                ucrSaveFile.Reset()
                SetSelectedFileProperties(dlgOpen.FileName)
                SetControlsAndBaseFunction()
            Else
                If String.IsNullOrEmpty(GetSelectedFilePath()) Then
                    SetSelectedFileProperties("")
                    SetControlsAndBaseFunction()
                End If
            End If
        End Using
    End Sub

    Private Sub TextPreviewVisible(bVisible As Boolean, strTextRead As String)
        panelTextPreview.Visible = bVisible
        txtTextFilePreview.Text = strTextRead
    End Sub

    Private Sub ExcelSheetsNamesVisible(bVisible As Boolean)
        panelSheets.Visible = bVisible
    End Sub

    Private Sub GridPreviewVisible(bVisible As Boolean, strGridText As String)
        lblImportPreview.Visible = False
        lblDataFramePreview.Visible = bVisible
        lblLinesToPreview.Visible = bVisible
        ucrNudPreviewLines.Visible = bVisible
        btnRefreshPreview.Visible = bVisible
        grdDataPreview.Visible = bVisible

        If Not String.IsNullOrEmpty(strGridText) Then
            lblImportPreview.Visible = True
            lblImportPreview.Text = strGridText
            lblDataFramePreview.Visible = False
            lblLinesToPreview.Visible = False
            ucrNudPreviewLines.Visible = False
            btnRefreshPreview.Visible = False
            grdDataPreview.Visible = False
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        GetFileFromOpenDialog()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'Gets the current number of (visible) data frame before importing
        'So correct current data frame can be set after
        iDataFrameCount = frmMain.GetDataFrameCount()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'add the item to the recent opened files munu list...
        frmMain.clsRecentItems.addToMenu(GetSelectedFilePath(bInSystemFormat:=True))
        'Sets the current data frame as the first new data frame
        'Needed so that if multiple data frames imported, the last one is not the current data frame
        'iDataFrameCount = frmMain.GetDataFrameCount() - 1
        frmMain.SetCurrentDataFrame(iDataFrameCount)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub UcrPanelFixedWidthText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPanelFixedWidthText.ControlValueChanged
        If enumFileType <> FileType.TXT Then
            Exit Sub
        End If
        If rdoFixedWidthText.Checked OrElse rdoFixedWidthWhiteSpacesText.Checked Then
            clsImportFixedWidthText.SetRCommand(If(rdoFixedWidthText.Checked, "read_table", "read_table2"))
        ElseIf rdoSeparatortext.Checked Then
            clsImportCSV.AddParameter("format", Chr(34) & "txt" & Chr(34), iPosition:=1)
        End If
        SetControlsAndBaseFunction()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTrimWSExcel.ControlValueChanged, ucrNudRowsToSkipExcel.ControlValueChanged, ucrChkColumnNamesExcel.ControlValueChanged, ucrChkColumnNamesText.ControlValueChanged, ucrNudRowsToSkipText.ControlValueChanged, ucrChkMaxRowsText.ControlValueChanged, ucrChkMaxRowsCSV.ControlValueChanged, ucrChkMaxRowsExcel.ControlValueChanged, ucrNudMaxRowsText.ControlValueChanged, ucrNudMaxRowsCSV.ControlValueChanged, ucrNudMaxRowsExcel.ControlValueChanged, ucrChkStringsAsFactorsCSV.ControlValueChanged, ucrInputEncodingCSV.ControlValueChanged, ucrInputSeparatorCSV.ControlValueChanged, ucrInputHeadersCSV.ControlValueChanged, ucrInputDecimalCSV.ControlValueChanged, ucrNudRowsToSkipCSV.ControlValueChanged, ucrNudPreviewLines.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub btnRefreshPreview_Click(sender As Object, e As EventArgs) Handles btnRefreshPreview.Click
        TestOkEnabled()
    End Sub

    Private Sub ucrInputMissingValueStringExcel_ContentsChanged() Handles ucrInputMissingValueStringExcel.ContentsChanged
        Dim strMissingvalueRString As String = GetMissingValueRString(ucrInputMissingValueStringExcel.GetText())
        'set for single imports and multiple imports 
        If String.IsNullOrEmpty(strMissingvalueRString) Then
            clsImportExcel.RemoveParameterByName("na")
            clsImportExcelMulti.RemoveParameterByName("na")
        Else
            clsImportExcel.AddParameter("na", strMissingvalueRString)
            clsImportExcelMulti.AddParameter("na", strMissingvalueRString)
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrInputMissingValueStringCSV_ContentsChanged() Handles ucrInputMissingValueStringCSV.ContentsChanged
        Dim strMissingvalueRString As String = GetMissingValueRString(ucrInputMissingValueStringCSV.GetText())
        If String.IsNullOrEmpty(strMissingvalueRString) Then
            clsImportCSV.RemoveParameterByName("na.strings")
        Else
            clsImportCSV.AddParameter("na.strings", strMissingvalueRString)
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrInputMissingValueStringText_ContentsChanged() Handles ucrInputMissingValueStringText.ContentsChanged
        Dim strMissingvalueRString As String = GetMissingValueRString(ucrInputMissingValueStringText.GetText())
        'todo. test this
        If String.IsNullOrEmpty(strMissingvalueRString) Then
            If rdoSeparatortext.Checked Then
                clsImportCSV.RemoveParameterByName("na.strings")
            Else
                clsImportFixedWidthText.RemoveParameterByName("na")
            End If
        Else
            'for separator we use the function used for csv
            If rdoSeparatortext.Checked Then
                clsImportCSV.AddParameter("na.strings", strMissingvalueRString)
            Else
                clsImportFixedWidthText.AddParameter("na", strMissingvalueRString)
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrChkRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRange.ControlValueChanged
        If ucrChkRange.Checked Then
            clsImportExcel.AddParameter("range", clsROperatorParameter:=clsRangeOperator)
        Else
            clsImportExcel.RemoveParameterByName("range")
        End If
        TestOkEnabled()
    End Sub

    Private Sub chkListBoxSheetNames_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chkListBoxSheetNames.ItemCheck
        If bSupressSheetChange Then
            Exit Sub
        End If

        'clear all selected sheets first
        dctSelectedExcelSheets.Clear()
        'add/remove checked item to dictionary of selected sheets
        For Each i As Integer In chkListBoxSheetNames.CheckedIndices
            dctSelectedExcelSheets.Add(i + 1, chkListBoxSheetNames.Items.Item(i).ToString())
        Next
        If e.NewValue = CheckState.Checked Then
            dctSelectedExcelSheets.Add(e.Index + 1, chkListBoxSheetNames.Items.Item(e.Index).ToString())
        Else
            dctSelectedExcelSheets.Remove(e.Index + 1)
        End If

        bSupressCheckAllSheets = True
        ucrChkSheetsCheckAll.Checked = (dctSelectedExcelSheets.Count = chkListBoxSheetNames.Items.Count)
        bSupressCheckAllSheets = False

        If dctSelectedExcelSheets.Count = 0 Then
            clsImportExcel.RemoveParameterByName("which")
            clsImportExcelMulti.RemoveParameterByName("which")
        ElseIf dctSelectedExcelSheets.Count = 1 Then
            clsImportExcel.AddParameter("which", dctSelectedExcelSheets.Keys.First().ToString)
        Else
            clsImportExcelMulti.AddParameter("which", "c(" & String.Join(",", dctSelectedExcelSheets.Keys) & ")")
        End If

        SetExcelBaseFunctionAndSaveProperties()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkSheetsCheckAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSheetsCheckAll.ControlValueChanged
        If bSupressCheckAllSheets Then
            Exit Sub
        End If

        Dim bCheckAll As Boolean = ucrChkSheetsCheckAll.Checked
        For i As Integer = 0 To chkListBoxSheetNames.Items.Count - 1
            'don't suppress event change when changed checked status of last item
            bSupressSheetChange = i <> chkListBoxSheetNames.Items.Count - 1
            chkListBoxSheetNames.SetItemChecked(i, bCheckAll)
        Next
    End Sub

    Private Sub dlgImportDataset_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If (Not Me.Visible) AndAlso bFromLibrary Then
            'restore previous path if current opeing was from the library
            bFromLibrary = False
            SetSelectedFileProperties(strFilePathSystemTemp)
        End If
    End Sub

    Private Sub SetExcelBaseFunctionAndSaveProperties()
        ucrBase.clsRsyntax.SetBaseRFunction(If(dctSelectedExcelSheets.Count > 1, clsImportExcelMulti, clsImportExcel))
        ucrSaveFile.Visible = (dctSelectedExcelSheets.Count = 1)
        If dctSelectedExcelSheets.Count = 0 Then
            ucrSaveFile.SetName("", bSilent:=True)
            ucrSaveFile.SetDataFrameNames("")
        ElseIf dctSelectedExcelSheets.Count = 1 Then
            ucrSaveFile.SetName(GetCleanedName(dctSelectedExcelSheets.Values.First), bSilent:=True)
            ucrSaveFile.SetDataFrameNames("")
            'ucrSaveFile.Focus()
        Else
            ucrSaveFile.SetName(GetCleanedSelectedFileName, bSilent:=True)
            ucrSaveFile.SetDataFrameNames(lstTempDataFrameNames:=dctSelectedExcelSheets.Values.ToList())
        End If
        ucrSaveFile.SetAssignToBooleans(bTempDataFrameList:=(dctSelectedExcelSheets.Count > 1))
    End Sub


    ''' <summary>
    ''' Creates an R string to be used as the parameter value for na.strings and na parameters 
    ''' </summary>
    ''' <param name="strText">string used to create the R Text</param>
    ''' <returns></returns>
    Private Function GetMissingValueRString(strText As String) As String
        If String.IsNullOrEmpty(strText) Then
            Return ""
        End If

        Dim arrStr() As String = strText.Split(",")
        'if length is = 1 return an R string else return a vector of strings for R. 
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
            Case ".csv"
                Return FileType.CSV
            Case ".dly"
                Return FileType.DLY
            Case ".dat"
                Return FileType.DAT
            Case Else
                Return FileType.OTHER
        End Select
    End Function

End Class
