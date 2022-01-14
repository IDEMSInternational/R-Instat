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

Imports RDotNet
Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports System.ComponentModel
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmMain
    Public clsRLink As RLink
    Public clsGrids As New clsGridLink
    Public strStaticPath As String
    Public strHelpFilePath As String = "Help\R-Instat.chm"
    Public strAppDataPath As String
    Public strInstatOptionsFile As String = "Options.bin"
    Public clsInstatOptions As InstatOptions
    Public clsRecentItems As clsRecentFiles
    Public strCurrentDataFrame As String
    Public dlgLastDialog As Form
    Public strSaveFilePath As String = ""
    Public clsOutputLogger As clsOutputLogger
    Private mnuItems As New List(Of Form)
    Private ctrActive As Control
    Private WithEvents timer As New System.Windows.Forms.Timer
    Private iAutoSaveDataMilliseconds As Integer
    Private clsDataBook As clsDataBook

    Public strAutoSaveDataFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_data_auto_save")
    Public strAutoSaveLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_log_auto_save")
    Public strAutoSaveInternalLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_debug_log_auto_save")

    Public strCurrentAutoSaveDataFilePath As String = ""


    Public isMinimised As Boolean = False
    Public isMaximised As Boolean = False

    'This is the default data frame to appear in the data frame selector
    'If "" the current worksheet will be used
    'TODO This should be an option in the Options dialog
    '     User can choose a default data frame or set the default as the current worksheet
    Public strDefaultDataFrame As String = ""

    Private strCurrentOutputFileName As String = "" 'holds the saved ouput file name to help remember the current selected folder path
    Private strCurrentScriptFileName As String = "" 'holds the saved script file name to help remember the current selected folder path
    Private strCurrentLogFileName As String = "" 'holds the saved log file name to help remember the current selected folder path

    ''' <summary>
    ''' flag used to indicate if current state of selected data has been saved
    ''' it's set to false by ucrDataView control when state of data has been changed
    ''' it's set to true by dlgSaveAs dialog and save menu when data has been successfully saved 
    ''' </summary>
    Public Property bDataSaved As Boolean = False

    Private strCurrLang As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsOutputLogger = New clsOutputLogger
        clsRLink = New RLink(clsOutputLogger)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prdCustom As New clsCustomRenderer(New clsCustomColourTable)
        Dim bClose As Boolean = False

        mnuBar.Renderer = prdCustom
        Tool_strip.Renderer = prdCustom
        SetMainMenusEnabled(False)
        Cursor = Cursors.WaitCursor
        'temporary
        mnuHelpAboutRInstat.Visible = False

        ' This must be fixed because CurrentCulture affects functions such as Decimal.TryParse
        ' e.g. "1.0" fails Decimal.TryParse if CurrentCulture = "fr-FR" because it expects "1,0"
        ' Decimal point must be `.` and not `,` because R only accepts `.`
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")

        ucrDataViewer.StartupMenuItemsVisibility(False)
        clsDataBook = New clsDataBook(clsRLink)

        ucrDataViewer.DataBook = clsDataBook
        ucrColumnMeta.DataBook = clsDataBook
        ucrDataFrameMeta.DataBook = clsDataBook

        clsRLink.SetLog(ucrLogWindow.txtLog)

        ucrOutput.SetLogger(clsOutputLogger)

        SetToDefaultLayout()

        'Gets the path for the executable file that started the application, not including the 
        'executable name.
        'We use `Application.StartupPath` because this returns the correct path even if the 
        'application was started by double-clicking a data file in another folder.
        'We need the full path of the static folder to set the working folder containing files 
        'needed when the application is loading.         
        strStaticPath = String.Concat(Application.StartupPath, "\static")

        strAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RInstat\")

        bClose = AutoRecoverAndStartREngine()
        If bClose Then
            Application.Exit()
        Else
            'Do this after setting up R Link because loading options may run R code
            LoadInstatOptions()
            'Must come after loading options as options may change language.
            TranslateFrmMainMenu()

            'Do this after loading options because interval depends on options
            'Interval is in milliseconds and option is in minutes
            timer.Interval = (clsInstatOptions.iAutoSaveDataMinutes * 60 * 1000)
            timer.Start()

            AddHandler System.Windows.Forms.Application.Idle, AddressOf Application_Idle

            'Sets up the Recent items
            clsRecentItems = New clsRecentFiles(strAppDataPath)
            clsRecentItems.setToolStripItems(mnuFile, mnuTbOpen, mnuTbLast10Dialogs, sepStart, sepEnd)
            clsRecentItems.SetDataViewWindow(ucrDataViewer)
            'checks existence of MRU list
            clsRecentItems.checkOnLoad()
            ucrDataViewer.StartupMenuItemsVisibility(True)
            Cursor = Cursors.Default
            SetMainMenusEnabled(True)

            mnuViewStructuredMenu.Checked = clsInstatOptions.bShowStructuredMenu
            mnuViewClimaticMenu.Checked = clsInstatOptions.bShowClimaticMenu
            mnuViewProcurementMenu.Checked = clsInstatOptions.bShowProcurementMenu
        End If

        Try
            If (Environment.GetCommandLineArgs.Length > 1) Then
                dlgImportDataset.strFileToOpenOn = Environment.GetCommandLineArgs(1)
                dlgImportDataset.bStartOpenDialog = False
                dlgImportDataset.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If Me.clsInstatOptions IsNot Nothing Then
            If Me.clsInstatOptions.strLanguageCultureCode <> "en-GB" Then
                mnuTbLan.Visible = True
            Else
                mnuTbLan.Visible = False
            End If
            strCurrLang = Me.clsInstatOptions.strLanguageCultureCode
        End If

        ucrOutput.SetInstatOptions(clsInstatOptions)
        isMaximised = True 'Need to get the windowstate when the application is loaded
    End Sub

    ''' <summary>
    ''' Updates data view, column meta and data frame meta grids.
    ''' </summary>
    Public Sub UpdateAllGrids()
        ucrDataViewer.RefreshGridData()
        ucrColumnMeta.RefreshGridData()
        ucrDataFrameMeta.RefreshGridData()
    End Sub

    ''' <summary>
    ''' Updates styles on data view, column meta and data frame meta grids.
    ''' </summary>
    Public Sub UpdateFontsOnlyOnAllGrids()
        ucrDataViewer.UpdateAllWorksheetStyles()
        ucrColumnMeta.UpdateAllWorksheetStyles()
        ucrDataFrameMeta.UpdateAllWorksheetStyles()
    End Sub

    ' TODO This is used instead of autoTranslate so that split container isn't shifted
    ' Need to fix this so that all of frmMain can be translated
    Public Sub TranslateFrmMainMenu()
        translateMenu(mnuBar.Items, Me)
    End Sub

    Public Sub SetLanButtonVisibility(bVisible As Boolean)
        mnuTbLan.Visible = bVisible
    End Sub

    Private Sub SetMainMenusEnabled(bEnabled As Boolean)
        mnuFile.Enabled = bEnabled
        mnuEdit.Enabled = bEnabled
        mnuPrepare.Enabled = bEnabled
        mnuDescribe.Enabled = bEnabled
        mnuModel.Enabled = bEnabled
        mnuStructured.Enabled = bEnabled
        mnuClimatic.Enabled = bEnabled
        mnuProcurement.Enabled = bEnabled
        mnuOptionsByContext.Enabled = bEnabled
        mnuTools.Enabled = bEnabled
        mnuView.Enabled = bEnabled
        mnuHelp.Enabled = bEnabled
        Tool_strip.Enabled = bEnabled
    End Sub

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        If clsInstatOptions.bAutoSaveData AndAlso Not timer.Enabled AndAlso (ActiveForm Is Nothing OrElse ActiveForm.Equals(Me)) AndAlso Not clsRLink.bRCodeRunning Then
            AutoSaveData()
            ResetTimer()
        End If
    End Sub

    Public Sub ResetTimer()
        If clsInstatOptions IsNot Nothing AndAlso clsInstatOptions.bAutoSaveData IsNot Nothing AndAlso clsInstatOptions.bAutoSaveData Then
            timer.Interval = (clsInstatOptions.iAutoSaveDataMinutes * 60 * 1000)
            timer.Start()
        End If
    End Sub

    Private Function AutoRecoverAndStartREngine() As Boolean
        Dim iLogFiles As Integer = 0
        Dim iInternalLogFiles As Integer = 0
        Dim iDataFiles As Integer = 0
        Dim strScript As String = ""
        Dim strDataFilePath As String = ""
        Dim strAutoSavedLogFilePaths() As String = Nothing
        Dim strAutoSavedInternalLogFilePaths() As String = Nothing
        Dim strAutoSavedDataFilePaths() As String = Nothing
        Dim bClose As Boolean = False

        If Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1 Then
            bClose = clsRLink.StartREngine(clsRLink.GetRSetupScript())
        Else
            If (Directory.Exists(strAutoSaveLogFolderPath)) Then
                strAutoSavedLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveLogFolderPath).ToArray
                iLogFiles = strAutoSavedLogFilePaths.Count
            End If
            If (Directory.Exists(strAutoSaveInternalLogFolderPath)) Then
                strAutoSavedInternalLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveInternalLogFolderPath).ToArray
                iInternalLogFiles = strAutoSavedInternalLogFilePaths.Count
            End If
            If Directory.Exists(strAutoSaveDataFolderPath) Then
                strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveDataFolderPath).ToArray
                iDataFiles = strAutoSavedDataFilePaths.Count
            End If
            If iLogFiles > 0 OrElse iDataFiles > 0 OrElse iInternalLogFiles > 0 Then
                If MsgBox("We have detected that R-Instat may have closed unexpectedly last time." & Environment.NewLine & "Would you like to see auto recovery options?", MessageBoxButtons.YesNo, "Auto Recovery") = MsgBoxResult.Yes Then
                    dlgAutoSaveRecovery.strAutoSavedLogFilePaths = strAutoSavedLogFilePaths
                    dlgAutoSaveRecovery.strAutoSavedDataFilePaths = strAutoSavedDataFilePaths
                    dlgAutoSaveRecovery.strAutoSavedInternalLogFilePaths = strAutoSavedInternalLogFilePaths
                    dlgAutoSaveRecovery.ShowDialog()
                    strScript = dlgAutoSaveRecovery.GetScript()
                    strDataFilePath = dlgAutoSaveRecovery.GetDataFilePath()
                End If
            End If
            bClose = clsRLink.StartREngine(strScript)
            If Not bClose Then
                If strDataFilePath <> "" Then
                    clsRLink.LoadInstatDataObjectFromFile(strDataFilePath, strComment:="Loading auto recovered data file")
                End If
                If iLogFiles > 0 Then
                    Try
                        File.Delete(strAutoSavedLogFilePaths(0))
                    Catch ex As Exception
                        MsgBox("Could not delete backup log file" & Environment.NewLine, "Error deleting file")
                    End Try
                End If
                If iInternalLogFiles > 0 Then
                    Try
                        File.Delete(strAutoSavedInternalLogFilePaths(0))
                    Catch ex As Exception
                        MsgBox("Could not delete backup internal log file." & Environment.NewLine & ex.Message, "Error deleting file")
                    End Try
                End If
                If iDataFiles > 0 Then
                    Try
                        File.Delete(strAutoSavedDataFilePaths(0))
                    Catch ex As Exception
                        MsgBox("Could not delete back data file." & Environment.NewLine & ex.Message, "Error deleting file")
                    End Try
                End If
            End If
        End If
        Return bClose
    End Function

    Private Sub LoadInstatOptions()
        If File.Exists(Path.Combine(strAppDataPath, strInstatOptionsFile)) Then
            LoadInstatOptionsFromFile(Path.Combine(strAppDataPath, strInstatOptionsFile))
        Else
            clsInstatOptions = New InstatOptions
            'TODO Should these be here or in the constructor (New) of InstatOptions?
        End If
    End Sub

    Private Sub SetToDefaultLayout()
        splOverall.SplitterDistance = splOverall.Height / 4
        splDataOutput.SplitterDistance = splDataOutput.Width / 2
        splExtraWindows.SplitterDistance = splExtraWindows.Width / 2
        splLogScript.SplitterDistance = splLogScript.Width / 2
        splMetadata.SplitterDistance = splMetadata.Width / 2

        mnuViewDataView.Checked = True
        mnuViewOutputWindow.Checked = True
        mnuViewLog.Checked = False
        mnuViewDataFrameMetadata.Checked = False
        mnuViewColumnMetadata.Checked = False
        mnuViewScriptWindow.Checked = False
        mnuViewSwapDataAndMetadata.Checked = False
        mnuLogWindow.Checked = False
        mnuScriptWindow.Checked = False
        mnuColumnMetadat.Checked = False
        mnuDataFrameMetadat.Checked = False

        mnuTbDataView.Checked = True
        mnuTbOutput.Checked = True
        UpdateLayout()
    End Sub

    Public Sub LoadInstatOptionsFromFile(strFilePath As String)
        'Dim FileStream As Stream
        Dim deserializer As New BinaryFormatter()

        'TODO Check if any options are not in loaded file, add defaults if missing
        '     Could happen when updating to newer version with more options, and old options file remains on disk.
        '     Alternative could be to create new instance with defaults and add/override only non empty fields from the imported file
        '     to ensure all fields have some value
        If File.Exists(strFilePath) Then
            Try
                Using FileStream As Stream = File.OpenRead(strFilePath)
                    clsInstatOptions = CType(deserializer.Deserialize(FileStream), InstatOptions)
                    clsInstatOptions.SetOptions()
                    'TODO Check whether this is needed or not. Using should do it automatically.
                    '     Also check general structure of this code.
                    'FileStream.Close()
                End Using
            Catch ex As Exception
                MsgBox("Could not load options from:" & strFilePath & Environment.NewLine & "The file may be in use by another program or the file does not contain an instance of InstatOptions." & Environment.NewLine & "Options will be reset to factory defaults." & vbNewLine & "System error message: " & ex.Message, MsgBoxStyle.Information, "Cannot open options file")
                clsInstatOptions = New InstatOptions
            End Try
        Else
            MsgBox("Options file:" & strFilePath & " does not exist." & Environment.NewLine & "File will not be loaded." & vbNewLine & "Options will be reset to factory defaults.", MsgBoxStyle.Information)
            clsInstatOptions = New InstatOptions
        End If
    End Sub

    Public Sub SaveInstatOptions(strFilePath As String)
        Dim serializer As New BinaryFormatter()

        Try
            Using FileStream As Stream = File.Create(strFilePath)
                'If the program is closed during startup of the RLink e.g. if R is not installed correctly
                'then clsInstatOptions = Nothing because this is initialised after setup.
                'Hence we do not need to save or give an error message.
                If clsInstatOptions IsNot Nothing Then
                    serializer.Serialize(FileStream, clsInstatOptions)
                    'TODO Check whether this is needed or not. Using should do it automatically.
                    '     Also check general structure of this code.
                    'FileStream.Close()
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error attempting to save to file:" & strFilePath & Environment.NewLine & "The file may be in use by another program." & Environment.NewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error saving to file")
        End Try
    End Sub

    Public Sub AddGraphForm(strFilePath As String)
        Dim frmNewGraph As New frmGraphDisplay

        frmNewGraph.SetImageFromFile(strFilePath)
        frmNewGraph.Show()
        frmNewGraph.BringToFront()
    End Sub

    Public Sub AddToScriptWindow(strText As String, Optional bMakeVisible As Boolean = True)
        ucrScriptWindow.AppendText(strText)
        If bMakeVisible Then
            mnuViewScriptWindow.Checked = True
            UpdateLayout()
        End If
    End Sub

    Private Sub mnuFileNewDataFrame_Click(sender As Object, e As EventArgs) Handles mnuFileNewDataFrame.Click
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericRegularSequence_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericRegularSequence.Click
        dlgRegularSequence.bNumericIsDefault = True
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub FrequencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificFrequency.Click
        dlgFrequency.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificSummary.Click
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeStack_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeStack.Click
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeUnstack_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeUnstack.Click
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRecode_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorRecodeNumeric.Click
        dlgRecodeNumeric.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericRandomSamples_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericRandomSamples.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameViewData.Click
        dlgView.ShowDialog()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeSubset.Click
        dlgRestrict.bIsSubsetDialog = True
        dlgRestrict.ShowDialog()
    End Sub

    'Private Sub mnuStatsNonParametricTwoWayAnova_Click_1(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Click
    '    dlgNon_ParametricTwoWayAnova.ShowDialog()
    'End Sub

    Private Sub ShiftDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareShiftDailyData.Click
        dlgShiftDailyData.ShowDialog()
    End Sub

    Private Sub StackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareStackDailyData.Click
        dlgStackDailyData.ShowDialog()
    End Sub
    Private Sub mnuClimaticExamine_Click(sender As Object, e As EventArgs) Handles mnuClimaticExamine.Click
        dlgExamine.ShowDialog()
    End Sub

    Private Sub mnuClimaticEvaporationSite_Click(sender As Object, e As EventArgs) Handles mnuClimaticEvaporationSite.Click
        dlgSite.ShowDialog()
    End Sub

    Private Sub mnuFIleExit_Click(sender As Object, e As EventArgs) Handles mnuFIleExit.Click
        Me.Close()
    End Sub

    Private Sub mnuFileOpenFromFile_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromFile.Click
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub mnuFileOpenFromLibrary_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromLibrary.Click
        dlgFromLibrary.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataRename_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameRenameColumn.Click
        dlgName.ShowDialog()
    End Sub

    Public Sub UpdateLayout()
        If Not mnuViewDataView.Checked AndAlso Not mnuViewOutputWindow.Checked AndAlso Not mnuViewColumnMetadata.Checked AndAlso Not mnuViewDataFrameMetadata.Checked AndAlso Not mnuViewLog.Checked AndAlso Not mnuViewScriptWindow.Checked AndAlso Not mnuViewSwapDataAndMetadata.Checked Then
            splOverall.Hide()
        Else
            splOverall.Show()
            If mnuViewDataView.Checked OrElse mnuViewOutputWindow.Checked Then
                splOverall.Panel2Collapsed = False
                splDataOutput.Panel1Collapsed = Not mnuViewDataView.Checked
                splDataOutput.Panel2Collapsed = Not mnuViewOutputWindow.Checked
            Else
                splOverall.Panel2Collapsed = True
            End If
            If mnuViewColumnMetadata.Checked OrElse mnuViewDataFrameMetadata.Checked OrElse mnuViewLog.Checked OrElse mnuViewScriptWindow.Checked Then
                splOverall.Panel1Collapsed = False
                If mnuViewColumnMetadata.Checked OrElse mnuViewDataFrameMetadata.Checked Then
                    splExtraWindows.Panel1Collapsed = False
                    splMetadata.Panel1Collapsed = Not mnuViewColumnMetadata.Checked
                    splMetadata.Panel2Collapsed = Not mnuViewDataFrameMetadata.Checked
                Else
                    splExtraWindows.Panel1Collapsed = True
                End If
                If mnuViewLog.Checked OrElse mnuViewScriptWindow.Checked Then
                    splExtraWindows.Panel2Collapsed = False
                    splLogScript.Panel1Collapsed = Not mnuViewLog.Checked
                    splLogScript.Panel2Collapsed = Not mnuViewScriptWindow.Checked
                Else
                    splExtraWindows.Panel2Collapsed = True
                End If
            Else
                splOverall.Panel1Collapsed = True
            End If
        End If
        mnuTbDataView.Checked = mnuViewDataView.Checked
        mnuTbOutput.Checked = mnuViewOutputWindow.Checked
    End Sub

    Private Sub UpdateSwapDataAndMetadata()
        If mnuViewSwapDataAndMetadata.Checked Then
            splDataOutput.Panel1.Controls.Add(ucrColumnMeta)
            splMetadata.Panel1.Controls.Add(ucrDataViewer)
            mnuViewColumnMetadata.Text = "Data View"
            mnuViewDataView.Text = "Column Metadata"
        Else
            splDataOutput.Panel1.Controls.Add(ucrDataViewer)
            splMetadata.Panel1.Controls.Add(ucrColumnMeta)
            mnuViewColumnMetadata.Text = "Column Metadata"
            mnuViewDataView.Text = "Data View"
        End If
    End Sub

    Private Sub mnuWindowVariable_Click(sender As Object, e As EventArgs) Handles mnuViewColumnMetadata.Click
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        mnuColumnMetadat.Checked = mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs) Handles mnuViewDataFrameMetadata.Click
        mnuViewDataFrameMetadata.Checked = Not mnuViewDataFrameMetadata.Checked
        mnuDataFrameMetadat.Checked = mnuViewDataFrameMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewLog.Click
        mnuViewLog.Checked = Not mnuViewLog.Checked
        mnuLogWindow.Checked = mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewScriptWindow.Click
        mnuViewScriptWindow.Checked = Not mnuViewScriptWindow.Checked
        mnuScriptWindow.Checked = mnuViewScriptWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareReshapeMerge_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeMerge.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuWindowsEditor_Click(sender As Object, e As EventArgs) Handles mnuViewDataView.Click
        mnuViewDataView.Checked = Not mnuViewDataView.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuFilePrintPreview_Click(sender As Object, e As EventArgs) Handles mnuFilePrintPreview.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileSheetMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectDataFrameMetadata.Click
        dlgDataFrameMetaData.ShowDialog()
    End Sub

    Private Sub mnuPrepareSheetColumnMetadata_Click(sender As Object, e As EventArgs)
        mnuViewColumnMetadata.Checked = True
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareSheetInsertColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameInsertColumnsRows.Click
        dlgInsertColumn.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericPermuteRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericPermuteRows.Click
        dlgPermuteColumn.ShowDialog()
    End Sub
    Private Sub mnuPrepareDataFileDeleteSheets_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectDeleteDataFrame.Click
        dlgDeleteDataFrames.ShowDialog()
    End Sub


    Private Sub mnuPrepareSheetDeleteColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameDeleteColumnsRows.Click
        dlgDeleteRowsOrColums.ShowDialog()
    End Sub

    Private Sub EditLastDialogueToolStrip_Click(sender As Object, e As EventArgs) Handles mnuTbEditLastDialog.Click
        If clsRecentItems.lstRecentDialogs.Count > 0 Then
            clsRecentItems.lstRecentDialogs.Last.ShowDialog()
        End If
    End Sub

    Private Sub mnuTbSave_Click(sender As Object, e As EventArgs) Handles mnuTbSave.Click
        mnuFileSave_Click(sender, e)
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim clsSaveRDS As New RFunction

        If strSaveFilePath = "" Then
            dlgSaveAs.ShowDialog()
        Else
            clsSaveRDS.SetRCommand("saveRDS")
            clsSaveRDS.AddParameter("object", clsRLink.strInstatDataObject)
            clsSaveRDS.AddParameter("file", Chr(34) & Replace(strSaveFilePath, "\", "/") & Chr(34))
            clsRLink.RunScript(clsSaveRDS.ToScript(), strComment:="File > Save: save file")
            bDataSaved = True
        End If
    End Sub

    Private Sub mnuHelpHelp_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TableOfContents, "")
    End Sub

    Private Sub mnuTbHelp_Click(sender As Object, e As EventArgs) Handles mnuTbHelp.Click
        mnuHelpHelp_Click(sender, e)
    End Sub

    Private Sub mnuPrepareFactorRecode_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorRecodeFactor.Click
        dlgRecodeFactor.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileCopySheet_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectCopyDataFrame.Click
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileReorderSheets_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectReorderDataFrames.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileRenameSheet_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectRenameDataFrame.Click
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareRechapeColumnSummaries_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeColumnSummaries.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuPrepareSheetReorder_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorReferenceLevels_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorReferenceLevel.Click
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorLabel_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorLevelsLabels.Click
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorViewLabels_Click(sender As Object, e As EventArgs) Handles mnuPrepareFactorViewLabels.Click
        dlgViewFactorLabels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorConvertToFactor.Click
        dlgConvertColumns.bToFactorOnly = True
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorReorderLevels_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorReorderLevels.Click
        dlgReorderLevels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorUnusedLevels_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorUnusedLevels.Click
        dlgRemoveUnusedLevels.ShowDialog()
    End Sub
    Private Sub mnuPrepareDataSort_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameSort.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuPrepareViewObjects_Click(sender As Object, e As EventArgs) Handles mnuPrepareRObjectsView.Click
        dlgViewObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareReorderObjects_Click(sender As Object, e As EventArgs) Handles mnuPrepareRObjectsReorder.Click
        dlgReorderObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareRenameObjects_Click(sender As Object, e As EventArgs) Handles mnuPrepareRObjectsRename.Click
        dlgRenameObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareDeleteObjects_Click(sender As Object, e As EventArgs) Handles mnuPrepareRObjectsDelete.Click
        dlgDeleteObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorContrasts_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorContrasts.Click
        dlgContrasts.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorSheet_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorFactorDataFrame.Click
        dlgFactorDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextSplit_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextSplit.Click
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextCombine_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextCombine.Click
        dlgCombineText.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFilter_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = ""
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataConvertTo_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameConvertColumns.Click
        dlgConvertColumns.bToFactorOnly = False
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeTranspose_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeTranspose.Click
        dlgTransposeColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorCombine_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorCombineFactors.Click
        dlgCombine.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorDummyVariable_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorDummyVariables.Click
        dlgDummyVariables.ShowDialog()
    End Sub

    'Private Sub mnuStatisticsAnalysisOfVarianceGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralANOVAGeneral.Click
    '    dlgGeneralANOVA.ShowDialog()
    'End Sub

    'Private Sub mnuStatisticsRegressionGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralRegression.Click
    '    dlgGeneralRegression.ShowDialog()
    'End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeGeneralGraphics.Click
        dlgGeneralForGraphics.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextTransform_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextTransform.Click
        dlgTransformText.ShowDialog()
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuEditSelectAll.Click
        If ctrActive IsNot Nothing Then
            If ctrActive.Equals(ucrDataViewer) Then
                ucrDataViewer.SelectAllText()
            ElseIf ctrActive.Equals(ucrColumnMeta) Then
                ucrColumnMeta.SelectAllText()
            ElseIf ctrActive.Equals(ucrDataFrameMeta) Then
                ucrDataFrameMeta.SelectAllText()
            ElseIf ctrActive.Equals(ucrLogWindow) Then
                ucrLogWindow.SelectAllText()
            ElseIf ctrActive.Equals(ucrScriptWindow) Then
                ucrScriptWindow.SelectAllText()
            End If
        End If
    End Sub

    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs) Handles mnuToolsOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameHideColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameHideColumns.Click
        dlgHideShowColumns.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsRandomSamplesUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsRandomSamplesUseModel.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableExactResults_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableExactResults.Click
        dlgOneSample.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableNonParametric_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableNonParametric.Click
        dlgNon_ParametricOneSampleTests.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesSimpleRegression_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesSimpleRegression.Click
        dlgTwoVariableFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesOneWayANOVA_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesOneWayANOVA.Click
        dlgOneWayANOVA.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesNonParametricOneWayANOVA_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesNonParametricOneWayANOVA.Click
        dlgNon_ParametricOneWayANOVA.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesSimpleWithGroups_Click(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesSimpleWithGroups.Click
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesNonParametricTwoWayANOVA_Click(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Click
        dlgNon_ParametricTwoWayAnova.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesChisquareTest_Click(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesChisquareTest.Click
        dlgChiSquareTest.ShowDialog()
    End Sub

    Private Sub mnuModelOtherGeneralANOVAGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralANOVAGeneral.Click
        dlgGeneralANOVA.ShowDialog()
    End Sub

    Private Sub OutputWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewOutputWindow.Click
        mnuViewOutputWindow.Checked = Not mnuViewOutputWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuOrganiseColumnReshapeRandomSubset_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeRandomSubset.Click
        dlgRandomSubsets.ShowDialog()
    End Sub

    Private Sub mnuToolsClearOutputWindow_Click(sender As Object, e As EventArgs) Handles mnuToolsClearOutputWindow.Click
        Dim rstResponse As DialogResult
        rstResponse = MessageBox.Show("Are you sure you want to clear the Output Window?", "Clear Output Window", MessageBoxButtons.YesNo)
        If rstResponse = DialogResult.Yes Then
            ucrOutput.UcrOutputPages.ClearOutputWindow()
        End If
    End Sub

    Private Sub mnuOrganiseDataObjectDeleteMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectDeleteMetadata.Click
        dlgDeleteMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectMetadata.Click
        'TODO Change this dialog
        '     currently dlgMetadata is colouring grid dialog
        dlgMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectReorderMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectReorderMetadata.Click
        dlgReorderMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectRenameMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectRenameMetadata.Click
        dlgRenameMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameRowNumbersNames_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameRowNumbersNames.Click
        dlgRowNamesOrNumbers.ShowDialog()
    End Sub

    Private Sub JitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPreparePrepareToShareJitter.Click
        dlgJitter.ShowDialog()
    End Sub

    Private Sub mnuEditFind_Click(sender As Object, e As EventArgs) Handles mnuEditFind.Click
        dlgFind.currWindow = ActiveMdiChild
        dlgFind.Owner = Me
        dlgFind.Show()
    End Sub

    Private Sub mnuEditFindNext_Click(sender As Object, e As EventArgs) Handles mnuEditFindNext.Click
        mnuEditFind_Click(sender, e)
    End Sub

    Private Sub ColourByPropertyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataframeColourByProperty.Click
        'TODO change this dialog
        '     dlgMetadata should be separate
        dlgColourbyProperty.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnTextFindReplace_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextFindReplace.Click
        dlgStringHandling.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableSummarise.Click
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim bClose As DialogResult = DialogResult.Yes

        If e.CloseReason = CloseReason.UserClosing Then
            bClose = MsgBox("Are you sure you want to exit R-Instat?" & Environment.NewLine & "Any unsaved changes will be lost.", MessageBoxButtons.YesNo, "Exit")
        End If
        If bClose = DialogResult.Yes Then
            Try
                If (Not System.IO.Directory.Exists(strAppDataPath)) Then
                    System.IO.Directory.CreateDirectory(strAppDataPath)
                End If
                If clsRLink IsNot Nothing AndAlso clsRLink.bREngineInitialised Then
                    If clsRecentItems IsNot Nothing Then
                        clsRecentItems.saveOnClose()
                    End If
                    If clsInstatOptions IsNot Nothing Then
                        SaveInstatOptions(Path.Combine(strAppDataPath, strInstatOptionsFile))
                    End If
                    DeleteAutoSaveData()
                    DeleteAutoSaveLog()
                    DeleteAutoSaveDebugLog()
                End If
                clsRLink.CloseREngine()
            Catch ex As Exception
                MsgBox("Error attempting to save setting files to App Data folder." & Environment.NewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error saving settings")
            End Try
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub AutoSaveData()
        Dim clsSaveRDS As New RFunction
        Dim strTempFile As String
        Dim i As Integer = 0
        Dim strCurrentStatus As String

        strCurrentStatus = tstatus.Text
        If clsRLink.bInstatObjectExists Then
            tstatus.Text = "Auto saving data..."
            Cursor = Cursors.WaitCursor
            If Not Directory.Exists(strAutoSaveDataFolderPath) Then
                Directory.CreateDirectory(strAutoSaveDataFolderPath)
            End If
            If strCurrentAutoSaveDataFilePath = "" Then
                strTempFile = "data.rds"
                While File.Exists(Path.Combine(strAutoSaveDataFolderPath, strTempFile))
                    i = i + 1
                    strTempFile = "data" & i & ".rds"
                End While
                strCurrentAutoSaveDataFilePath = Path.Combine(strAutoSaveDataFolderPath, strTempFile)
            End If
            clsSaveRDS.SetRCommand("saveRDS")
            clsSaveRDS.AddParameter("object", clsRLink.strInstatDataObject)
            clsSaveRDS.AddParameter("file", Chr(34) & strCurrentAutoSaveDataFilePath.Replace("\", "/") & Chr(34))
            clsRLink.RunInternalScript(clsSaveRDS.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
            tstatus.Text = strCurrentStatus
            Cursor = Cursors.Default
        End If
        autoTranslate(Me)
    End Sub

    Public Sub DeleteAutoSaveData()
        If strCurrentAutoSaveDataFilePath <> "" Then
            Try
                File.Delete(strCurrentAutoSaveDataFilePath)
            Catch ex As Exception
                MsgBox("Could not delete auto save data file at: " & strCurrentAutoSaveDataFilePath & Environment.NewLine & ex.Message)
            End Try
        End If
    End Sub

    Public Sub DeleteAutoSaveLog()
        If clsRLink.strAutoSaveLogFilePath <> "" Then
            Try
                File.Delete(clsRLink.strAutoSaveLogFilePath)
            Catch ex As Exception
                MsgBox("Could not delete auto save log file at: " & clsRLink.strAutoSaveLogFilePath & Environment.NewLine & ex.Message)
            End Try
        End If
    End Sub

    Public Sub DeleteAutoSaveDebugLog()
        If clsRLink.strAutoSaveDebugLogFilePath <> "" Then
            Try
                File.Delete(clsRLink.strAutoSaveDebugLogFilePath)
            Catch ex As Exception
                MsgBox("Could not delete auto save debug log file at: " & clsRLink.strAutoSaveDebugLogFilePath & Environment.NewLine & ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuOrganiseDataObjectHideDataframes_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectHideDataframes.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameReplaceValues_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameReplaceValues.Click
        dlgReplaceValues.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesSummarise.Click
        dlgDescribeTwoVariable.ShowDialog()
    End Sub

    Private Sub mnuAppendDataFrame_Click(sender As Object, e As EventArgs) Handles mnuPrepareAppendDataFrame.Click
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsOutputAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsOutputAs.Click
        ucrOutput.UcrOutputPages.SaveTab()
    End Sub

    Private Sub mnuFileSaveAsLogAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsLogAs.Click
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Log Window"
            dlgSaveFile.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            If Not String.IsNullOrEmpty(strCurrentLogFileName) Then
                dlgSaveFile.FileName = Path.GetFileName(strCurrentLogFileName)
                dlgSaveFile.InitialDirectory = Path.GetDirectoryName(strCurrentLogFileName)
            Else
                dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            End If
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, ucrLogWindow.txtLog.Text)
                    strCurrentLogFileName = dlgSaveFile.FileName
                Catch
                    MsgBox("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuFileSaveAsScriptAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsScriptAs.Click
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Script Window"
            dlgSaveFile.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            If Not String.IsNullOrEmpty(strCurrentScriptFileName) Then
                dlgSaveFile.FileName = Path.GetFileName(strCurrentScriptFileName)
                dlgSaveFile.InitialDirectory = Path.GetDirectoryName(strCurrentScriptFileName)
            Else
                dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            End If
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, ucrScriptWindow.txtScript.Text)
                    strCurrentScriptFileName = dlgSaveFile.FileName
                Catch
                    MsgBox("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuOrganiseDataFrameColumnStructure_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameColumnStructure.Click
        dlgColumnStructure.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesGraph.Click
        dlgDescribeTwoVarGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileOpensst_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportSST.Click
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub mnuFileOpenFromODK_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromODK.Click
        dlgImportFromODK.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericEnter_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericEnter.Click
        dlgEnter.ShowDialog()
    End Sub

    Private Sub TablesPlusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsShowModel.Click
        dlgShowModel.ShowDialog()
    End Sub

    Private Sub mnuDescribeUseGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeUseGraph.Click
        dlgUseGraph.ShowDialog()
    End Sub

    Private Sub mnuDescribeCombineGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeCombineGraph.Click
        dlgCombineforGraphics.ShowDialog()
    End Sub

    Private Sub mnuDescribeThemes_Click(sender As Object, e As EventArgs) Handles mnuDescribeThemes.Click
        dlgThemes.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateCorrelations_Click(sender As Object, e As EventArgs) Handles mnuDescribeMultivariateCorrelations.Click
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateprincipalComponents_Click(sender As Object, e As EventArgs) Handles mnuDescribeMultivariateprincipalComponents.Click
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateCanonicalCorrelations_Click(sender As Object, e As EventArgs) Handles mnuDescribeMultivariateCanonicalCorrelations.Click
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub
    Private Sub mnuClimaticOrganiseSummary_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareSummary.Click
        dlgSummary.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsStartoftheRains_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareStartoftheRains.Click
        dlgStartofRains.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsSpells_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareSpells.Click
        dlgSpells.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsWaterBalance_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareEndOfRains.Click
        dlgEndOfRainsSeason.ShowDialog()
    End Sub


    Private Sub mnuDescribeSpecificScatterPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificPointPlot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificLinePlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificLineSmoothPlot.Click
        dlgLinePlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificHistogram_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificHistogramDensityFrequencyPlot.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBoxplot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificBoxplotJitterViolinPlot.Click
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificDotPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificDotPlot.Click
        dlgDotPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificRugPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificMapPlot.Click
        dlgHeatMapPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBarChart_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificBarPieChart.Click
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnMakeDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateMakeDate.Click
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataExportOpenRefine_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataExportOpenRefine.Click
        dlgExportToOpenRefine.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataImportOpenRefine_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataImportOpenRefine.Click
        dlgImportOpenRefine.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsDataAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsDataAs.Click
        dlgSaveAs.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsCompareModels_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsCompareModels.Click
        dlgCompareModels.ShowDialog()
    End Sub

    Private Sub mnuDescribeGeneralColumnSummaries_Click(sender As Object, e As EventArgs) Handles mnuDescribeGeneralColumnSummaries.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnUseDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateUseDate.Click
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuHelpHelpIntroduction_Click(sender As Object, e As EventArgs) Handles mnuHelpHelpIntroduction.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "0")
    End Sub

    Private Sub mnuHelpHistFAQ_Click(sender As Object, e As EventArgs) Handles mnuHelpHistFAQ.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "290")
    End Sub

    Private Sub mnuHelpGetingStarted_Click(sender As Object, e As EventArgs) Handles mnuHelpGetingStarted.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "3")
    End Sub

    Private Sub mnuHelpDataset_Click(sender As Object, e As EventArgs) Handles mnuHelpDataset.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "71")
    End Sub

    Private Sub mnuHelpRPackagesCommands_Click(sender As Object, e As EventArgs) Handles mnuHelpRPackagesCommands.Click
        dlgHelpVignettes.ShowDialog()
    End Sub

    Private Sub mnuHelpR_Click(sender As Object, e As EventArgs) Handles mnuHelpAboutR.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "133")
    End Sub

    Private Sub mnuHelpMenus_Click(sender As Object, e As EventArgs) Handles mnuHelpMenus.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "12")
    End Sub


    Private Sub mnuHelpGuidesCaseStudy_Click(sender As Object, e As EventArgs) Handles mnuHelpGuidesCaseStudy.Click
        Process.Start(Path.Combine(strStaticPath, "Help", "Case_Study_Guide_June_2016.pdf"))
    End Sub

    Private Sub mnuHelpGuideGlosary_Click(sender As Object, e As EventArgs) Handles mnuHelpGuideGlosary.Click
        Process.Start(Path.Combine(strStaticPath, "Help", "Statistics Glossary.pdf"))
    End Sub

    Private Sub mnuHelpLicence_Click(sender As Object, e As EventArgs) Handles mnuHelpLicence.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "323")
    End Sub

    Private Sub mnuClimaticFileExportToCPT_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileExportToCPT.Click
        dlgExportToCPT.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportExporttoCPT_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportExporttoCPT.Click
        dlgExportToCPT.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportOpenSST_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportOpenSST.Click
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub GeneralSummariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeGeneralSummaries.Click
        dlgCalculationsSummary.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksViewAndRemoveKey_Click(sender As Object, e As EventArgs) Handles mnuPrepareKeysAndLinksViewAndRemoveKey.Click
        dlgViewAndRemoveKeys.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksAddLink_Click(sender As Object, e As EventArgs) Handles mnuPrepareKeysAndLinksAddLink.Click
        dlgAddLink.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksViewAndRemoveKeys_Click(sender As Object, e As EventArgs) Handles mnuPrepareKeysAndLinksViewAndRemoveKeys.Click
        dlgViewAndRemoveLinks.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksAddComment_Click(sender As Object, e As EventArgs) Handles mnuPrepareKeysAndLinksAddComment.Click
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuClimaticMarkovModelling_Click(sender As Object, e As EventArgs) Handles mnuClimaticModelMarkovModelling.Click
        dlgNewMarkovChains.ShowDialog()
    End Sub

    Private Sub mnuClimaticDefineClimaticData_Click(sender As Object, e As EventArgs) Handles mnuClimaticDefineClimaticData.Click
        DlgDefineClimaticData.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataInventory_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataInventory.Click
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateFileImportfromClimSoft_Click(sender As Object, e As EventArgs) Handles mnuClimateFileImportfromClimSoft.Click
        dlgClimSoft.ShowDialog()
    End Sub

    Private Sub mnuClimateFileImportfromClimSoftWizard_Click(sender As Object, e As EventArgs) Handles mnuClimateFileImportfromClimSoftWizard.Click
        dlgClimsoftWizard.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileImportFromCliData_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportfromCliData.Click
        dlgCliData.ShowDialog()
    End Sub

    Private Sub mnuPrepareKeysAndLinksAddKey_Click(sender As Object, e As EventArgs) Handles mnuPrepareKeysAndLinksAddKey.Click
        dlgAddKey.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesMakeDate_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesMakeDate.Click
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesUseDate_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesUseDate.Click
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareInfillMissingDates_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesInfillMissingDates.Click
        dlgInfill.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeTemperatures_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeTemperatures.Click
        dlgTemperature.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeSunshineRadiation_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeSunshineRadiation.Click
        dlgSunshine.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSARainfall_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSARainfall.Click
        dlgPICSARainfall.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSATemperature_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSATemperature.Click
        dlgPICSATemperature.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSACrops_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSACrops.Click
        dlgPICSACrops.ShowDialog()
    End Sub

    Private Sub mnuCimaticPrepareTransform_Click(sender As Object, e As EventArgs) Handles mnuCimaticPrepareTransform.Click
        dlgTransformClimatic.ShowDialog()
    End Sub

    Private Sub mnuClimaticModelsExtremes_Click(sender As Object, e As EventArgs) Handles mnuClimaticModelsExtremes.Click
        dlgExtremes.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCorrelations_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportCorrelations.Click
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportPrincipalComponents_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportPrincipalComponents.Click
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCanonicalCorrelations_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportCanonicalCorrelations.Click
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineData_Click(sender As Object, e As EventArgs) Handles mnuProcurementDefineData.Click
        dlgDefineCorruption.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCumulativeExceedanceGraphs_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportCumulativeExceedanceGraph.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareFilterByCountry_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareFilterByCountry.Click
        Dim lstDataNames As List(Of String)

        dlgRestrict.bIsSubsetDialog = False
        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgRestrict.strDefaultDataframe = lstDataNames(0)
            dlgRestrict.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label")
            dlgRestrict.bAutoOpenSubDialog = True
        Else
            dlgRestrict.strDefaultDataframe = ""
            dlgRestrict.strDefaultColumn = ""
            dlgRestrict.bAutoOpenSubDialog = False
        End If
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuProcurementModelFitModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementModelFitModelToolStripMenuItem.Click
        dlgCorruptionFitModel.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineRedFlags_Click(sender As Object, e As EventArgs) Handles mnuProcurementDefineRedFlags.Click
        dlgDefineRedFlags.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesFrequencies.Click
        dlgTwoWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuFileOpenFromCSPRO_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromCSPRO.Click
        dlgImportFromCSPRO.ShowDialog()
    End Sub

    Private Sub mnuFileImportFromDatabases_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromDatabases.Click
        dlgImportFromDatabases.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileImportandTidyNetCDF_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportandTidyNetCDF.Click
        dlgOpenNetCDF.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareSetFactorReferenceLevel_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareSetFactorReferenceLevel.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgReferenceLevel.strDefaultDataFrame = lstDataNames(0)
        End If
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareDefineContractValueCategories_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareDefineContractValueCategories.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgRecodeNumeric.strDefaultDataFrame = lstDataNames(0)
            If clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_ppp_adjusted_contract_value_label") <> "" Then
                dlgRecodeNumeric.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_ppp_adjusted_contract_value_label")
            Else
                dlgRecodeNumeric.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_original_contract_value_label")
            End If
        Else
            dlgRecodeNumeric.strDefaultDataFrame = ""
            dlgRecodeNumeric.strDefaultColumn = ""
        End If
        dlgRecodeNumeric.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareMergeAdditionalData_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareMergeAdditionalData.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareUseAwardDate_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareUseAwardDate.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgUseDate.strDefaultDataFrame = lstDataNames(0)
            dlgUseDate.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_award_date_label")
        Else
            dlgUseDate.strDefaultDataFrame = ""
            dlgUseDate.strDefaultColumn = ""
        End If
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableFrequencies.Click
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    'Private Sub mnuProcurementPrepareStandardiseCountryName_Click(sender As Object, e As EventArgs)
    '    Dim lstDataNames As List(Of String)

    '    lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
    '    If lstDataNames.Count > 0 Then
    '        dlgStandardiseCountryNames.strDefaultDataFrame = lstDataNames(0)
    '        dlgStandardiseCountryNames.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label")
    '    Else
    '        dlgStandardiseCountryNames.strDefaultDataFrame = ""
    '        dlgStandardiseCountryNames.strDefaultColumn = ""
    '    End If
    '    dlgStandardiseCountryNames.ShowDialog()
    'End Sub

    Private Sub mnuProcurementPrepareRecodeNumericIntoQuantiles_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareRecodeNumericIntoQuantiles.Click
        dlgRecodeNumericIntoQuantiles.ShowDialog()
    End Sub

    Private Sub mnuViewResetToDefaultLayout_Click(sender As Object, e As EventArgs) Handles mnuViewResetToDefaultLayout.Click
        SetToDefaultLayout()
    End Sub

    Private Sub ucrDataViewer_Enter(sender As Object, e As EventArgs) Handles ucrDataViewer.Enter
        ctrActive = ucrDataViewer
    End Sub

    Private Sub ucrOutput_Enter(sender As Object, e As EventArgs) Handles ucrOutput.Enter
        ctrActive = ucrOutput
    End Sub

    Private Sub ucrScriptWindow_Enter(sender As Object, e As EventArgs) Handles ucrScriptWindow.Enter
        ctrActive = ucrScriptWindow
    End Sub

    Private Sub ucrLogWindow_Enter(sender As Object, e As EventArgs) Handles ucrLogWindow.Enter
        ctrActive = ucrLogWindow
    End Sub

    Private Sub ucrColumnMeta_Enter(sender As Object, e As EventArgs) Handles ucrColumnMeta.Enter
        ctrActive = ucrColumnMeta
    End Sub

    Private Sub ucrDataFrameMeta_Enter(sender As Object, e As EventArgs) Handles ucrDataFrameMeta.Enter
        ctrActive = ucrDataFrameMeta
    End Sub

    Private Sub mnuClimaticFileImportfromIRIDataLibrary_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportfromIRIDataLibrary.Click
        dlgImportGriddedData.ShowDialog()
    End Sub

    Private Sub RatingDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableRatingData.Click
        dlgRatingScales.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnTextDistance_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextDistance.Click
        dlgStringDistance.ShowDialog()
    End Sub

    Private Sub mnuDescribeThreeVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeThreeVariableFrequencies.Click
        dlgThreeVariableFrequencies.ShowDialog()
    End Sub

    Private Sub mnuDescribeViewGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeViewGraph.Click
        dlgViewGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareExtremes_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareExtremes.Click
        dlgExtremesClimatic.ShowDialog()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        dlgExportRObjects.ShowDialog()
    End Sub

    Private Sub ExportDataSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExportExportDataSet.Click
        dlgExportDataset.ShowDialog()
    End Sub

    Private Sub ExportRWorkspaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExportExportRWorkspace.Click
        dlgExportRWorkspace.ShowDialog()
    End Sub

    Private Sub ExportGraphAsImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExportExportGraphAsImage.Click
        dlgExportGraphAsImage.ShowDialog()
    End Sub

    Private Sub ExportRObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileExportExportRObjectsToolStripMenuItem.Click
        dlgExportRObjects.ShowDialog()
    End Sub

    Private Sub FrequencyTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeGeneralUseSummaries.Click
        dlgSummaryBarOrPieChart.ShowDialog()
    End Sub
    Private Sub mnuClimaticPrepareClimaticSummaries_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimaticSummaries.Click
        dlgClimaticSummary.ShowDialog()
    End Sub

    Public Function GetDataFrameCount() As Integer
        If clsDataBook IsNot Nothing Then
            Return clsDataBook.DataFrames.Count
        End If
        Return 0
    End Function

    Public Sub SetCurrentDataFrame(strDataName As String)
        ucrDataViewer.SetCurrentDataFrame(strDataName)
        ucrColumnMeta.SetCurrentDataFrame(strDataName)
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        ucrDataViewer.SetCurrentDataFrame(iIndex)
        ucrColumnMeta.SetCurrentDataFrame(iIndex)
    End Sub

    Private Sub CummulativeDistributionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificCummulativeDistribution.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        timer.Stop()
    End Sub

    Private Sub mnuProcurementUseCRISummariseCRIbyCountry_Click(sender As Object, e As EventArgs) Handles mnuProcurementUseCRISummariseCRIbyCountry.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgColumnStats.strDefaultDataFrame = lstDataNames(0)
            dlgColumnStats.strDefaultVariables = clsRLink.GetCRIColumnNames(lstDataNames(0))
            dlgColumnStats.strDefaultFactors = {clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label")}
        Else
            dlgColumnStats.strDefaultDataFrame = ""
            dlgColumnStats.strDefaultVariables = Nothing
            dlgColumnStats.strDefaultFactors = Nothing
        End If
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuProcurementDescribeCategoricalOneVarFreq_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeCategoricalOneVarFreq.Click
        Dim lstDataNames As List(Of String)
        Dim lstColumns As New List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgOneWayFrequencies.strDefaultDataFrame = lstDataNames(0)
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_single_bidder_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_all_bids_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_procurement_type_3_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_tax_haven_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_contract_sector_label"))
            lstColumns.RemoveAll(Function(x) x = "")
            dlgOneWayFrequencies.strDefaultColumns = lstColumns.ToArray()
        Else
            dlgOneWayFrequencies.strDefaultDataFrame = ""
            dlgOneWayFrequencies.strDefaultColumns = Nothing
        End If
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuProcurementDescribeCategoricalTwoVarFreq_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeCategoricalTwoVarFreq.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgTwoWayFrequencies.strDefaultDataFrame = lstDataNames(0)
            dlgTwoWayFrequencies.strDefaultColumnVariable = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_contract_sector_label")
        Else
            dlgTwoWayFrequencies.strDefaultDataFrame = ""
            dlgTwoWayFrequencies.strDefaultColumnVariable = Nothing
        End If
        dlgTwoWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuFileCloseData_Click(sender As Object, e As EventArgs) Handles mnuFileCloseData.Click
        If Not bDataSaved Then
            If DialogResult.No = MsgBox("Are you sure you want to close you data?" &
                                         Environment.NewLine & "Any unsaved changes will be lost.",
                                         MessageBoxButtons.YesNo, "Close Data") Then
                Exit Sub
            End If
        End If
        clsRLink.CloseData()
        strSaveFilePath = ""
    End Sub

    Private Sub mnuPrepareCheckDataDuplicates_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataDuplicates.Click
        dlgDuplicates.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataBoxplot_Click_1(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataBoxplot.Click
        dlgClimaticBoxPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeWindSpeedDirectionWindRose_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeWindSpeedDirectionWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuClimaticCMSAFPlotRegion_Click(sender As Object, e As EventArgs) Handles mnuClimaticCMSAFPlotRegion.Click
        dlgPlotRegion.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataDisplayDaily_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataDisplayDaily.Click
        dlgDisplayDailyData.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnInfillMissingDates_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateInfillMissingDates.Click
        dlgInfill.ShowDialog()
    End Sub

    Private Sub mnuDataView_Click(sender As Object, e As EventArgs) Handles mnuTbDataView.Click
        mnuViewDataView.Checked = Not mnuViewDataView.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuTbOutput_Click(sender As Object, e As EventArgs) Handles mnuTbOutput.Click
        mnuViewOutputWindow.Checked = Not mnuViewOutputWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuTbResetLayout_Click(sender As Object, e As EventArgs) Handles mnuTbResetLayout.Click
        SetToDefaultLayout()
    End Sub

    Public Sub SetToolbarHeight(iHeight As Integer)
        'Not currently working, do not use this method
        'Tool_strip.ImageScalingSize = New Size(iHeight, iHeight)
    End Sub

    Private Sub mnuTbOpenFromLibrary_Click(sender As Object, e As EventArgs) Handles mnuTbOpenFromLibrary.Click
        dlgFromLibrary.ShowDialog()
    End Sub

    Private Sub mnuTbOpen_ButtonClick(sender As Object, e As EventArgs) Handles mnuTbOpen.ButtonClick
        dlgImportDataset.ShowDialog()
    End Sub

    Public Sub SetShowProcurementMenu(bNewShowProcurementMenu As Boolean)
        mnuProcurement.Visible = bNewShowProcurementMenu
        mnuViewProcurementMenu.Checked = bNewShowProcurementMenu
    End Sub

    Public Sub SetShowStructuredMenu(bNewShowStructuredMenu As Boolean)
        mnuStructured.Visible = bNewShowStructuredMenu
        mnuViewStructuredMenu.Checked = bNewShowStructuredMenu
    End Sub
    Public Sub SetShowClimaticMenu(bNewShowClimaticMenu As Boolean)
        mnuClimatic.Visible = bNewShowClimaticMenu
        mnuViewClimaticMenu.Checked = bNewShowClimaticMenu
    End Sub

    Public Sub SetShowOptionsByContextMenu(bNewShowOptionsByContextMenu As Boolean)
        mnuOptionsByContext.Visible = bNewShowOptionsByContextMenu
        mnuViewOptionsByContextMenu.Checked = bNewShowOptionsByContextMenu
    End Sub

    Private Sub mnuViewStructuredMenu_Click(sender As Object, e As EventArgs) Handles mnuViewStructuredMenu.Click
        clsInstatOptions.SetShowStructuredMenu(Not mnuViewStructuredMenu.Checked)
    End Sub
    Private Sub mnuViewClimaticMenu_Click(sender As Object, e As EventArgs) Handles mnuViewClimaticMenu.Click
        clsInstatOptions.SetShowClimaticMenu(Not mnuViewClimaticMenu.Checked)
    End Sub

    Private Sub mnuViewProcurementMenu_Click(sender As Object, e As EventArgs) Handles mnuViewProcurementMenu.Click
        clsInstatOptions.SetShowProcurementMenu(Not mnuViewProcurementMenu.Checked)
    End Sub

    Private Sub mnuPrepareCheckDataBoxplot_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataBoxplot.Click
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneVariableSummarise.Click
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneWayFrequencies_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneWayFrequencies.Click
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    Private Sub SummariseRedFlagsByCountryorOtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareSummariseRedFlagsByCountryorOther.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgColumnStats.strDefaultDataFrame = lstDataNames(0)
            dlgColumnStats.strDefaultVariables = clsRLink.GetRedFlagColumnNames(lstDataNames(0))
            dlgColumnStats.strDefaultFactors = {clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label")}
        Else
            dlgColumnStats.strDefaultDataFrame = ""
            dlgColumnStats.strDefaultVariables = Nothing
            dlgColumnStats.strDefaultFactors = Nothing
        End If
        dlgColumnStats.ShowDialog()
    End Sub


    Private Sub mnuProcurementCalculateCRI_Click(sender As Object, e As EventArgs) Handles mnuProcurementCTFVCalculateCRI.Click
        dlgCorruptionDefineCRI.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineCorruption_Click_1(sender As Object, e As EventArgs) Handles mnuProcurementModelDefineCorruption.Click
        dlgCorruptionDefineOutputs.ShowDialog()

    End Sub

    Private Sub SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareSummariseRedFlagsByCountryAndYearorOther.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgColumnStats.strDefaultDataFrame = lstDataNames(0)
            dlgColumnStats.strDefaultVariables = clsRLink.GetRedFlagColumnNames(lstDataNames(0))
            dlgColumnStats.strDefaultFactors = {clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label"), clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_fiscal_year_label")}
        Else
            dlgColumnStats.strDefaultDataFrame = ""
            dlgColumnStats.strDefaultVariables = Nothing
            dlgColumnStats.strDefaultFactors = Nothing
        End If
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub OneVariableSummariseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeOneVariableSummarise.Click
        Dim lstDataNames As List(Of String)
        Dim lstColumns As New List(Of String)
        Dim strRedFlags() As String

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgOneVariableSummarise.strDefaultDataFrame = lstDataNames(0)
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_single_bidder_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_all_bids_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_procurement_type_3_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_tax_haven_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_contract_sector_label"))
            strRedFlags = clsRLink.GetRedFlagColumnNames(lstDataNames(0))
            If strRedFlags IsNot Nothing Then
                lstColumns.AddRange(strRedFlags)
            End If
            lstColumns.RemoveAll(Function(x) x = "")
            lstColumns = lstColumns.Distinct.ToList
            dlgOneVariableSummarise.strDefaultColumns = lstColumns.ToArray()
        Else
            dlgOneVariableSummarise.strDefaultDataFrame = ""
            dlgOneVariableSummarise.strDefaultColumns = Nothing
        End If
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub OneVariableGraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeOneVariableGraph.Click
        Dim lstDataNames As List(Of String)
        Dim lstColumns As New List(Of String)
        Dim strRedFlags() As String

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgOneVariableGraph.strDefaultDataFrame = lstDataNames(0)
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_single_bidder_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_all_bids_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_procurement_type_3_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_tax_haven_label"))
            lstColumns.Add(clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_contract_sector_label"))
            strRedFlags = clsRLink.GetRedFlagColumnNames(lstDataNames(0))
            If strRedFlags IsNot Nothing Then
                lstColumns.AddRange(strRedFlags)
            End If
            lstColumns.RemoveAll(Function(x) x = "")
            dlgOneVariableGraph.strDefaultColumns = lstColumns.ToArray()
        Else
            dlgOneVariableGraph.strDefaultDataFrame = ""
            dlgOneVariableGraph.strDefaultColumns = Nothing
        End If
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub CorrelationsRedFlagsOrOthersToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles mnuProcurementDescribeNumericCorrelationsRedFlagsOrOthers.Click
        Dim lstDataNames As List(Of String)
        Dim strComponentColumnNames() As String

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgCorrelation.strDefaultDataFrame = lstDataNames(0)
            strComponentColumnNames = clsRLink.GetRedFlagColumnNames(lstDataNames(0))
            If strComponentColumnNames IsNot Nothing AndAlso strComponentColumnNames.Count > 0 Then
                dlgCorrelation.strDefaultColumns = strComponentColumnNames
            End If
        Else
            dlgCorrelation.strDefaultDataFrame = ""
            dlgCorrelation.strDefaultColumns = Nothing
        End If
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub MapCountryValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementMappingMapCountryValues.Click
        dlgCountryColouredMap.ShowDialog()
    End Sub

    Private Sub mnuFileImportandTidyNetCDFFile_Click(sender As Object, e As EventArgs) Handles mnuFileImportandTidyNetCDFFile.Click
        dlgOpenNetCDF.ShowDialog()
    End Sub


    Private Sub mnuClimaticCheckDataQCTemperatures_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataQCTemperatures.Click
        dlgClimaticCheckDataTemperature.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataQCRainfall_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataQCRainfall.Click
        dlgClimaticCheckDataRain.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificParallelCoordinatePlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificParallelCoordinatePlot.Click
        dlgParallelCoordinatePlot.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnGenerateDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateGenerateDate.Click
        dlgRegularSequence.bNumericIsDefault = False
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuClimaticDatesGenerateDates_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesGenerateDates.Click
        dlgRegularSequence.bNumericIsDefault = False
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareEvapotranspiration_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareEvapotranspiration.Click
        dlgEvapotranspiration.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataCompareColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataCompareColumns.Click
        dlgCompareColumns.ShowDialog()
    End Sub

    Private Sub mnuDefineOptionsByContexts_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextDefineOptionsByContexts.Click
        dlgDefineOptionsByContext.ShowDialog()
    End Sub

    Private Sub MergeAdditionalDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextMergeAdditionalData.Click
        dlgMergeAdditionalData.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataDuplicates_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataDuplicates.Click
        dlgDuplicates.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataCompareColumns_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataCompareColumns.Click
        dlgCompareColumns.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsPrepareStack_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextPrepareStack.Click
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsPrepareUnstack_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextPrepareUnstack.Click
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataOneVariableSummarise.Click
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataOneVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataOneVariableFrequencies.Click
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuViewOptionsByContextMenu_Click(sender As Object, e As EventArgs) Handles mnuViewOptionsByContextMenu.Click
        clsInstatOptions.SetShowOptionsByContextMenu(Not mnuViewOptionsByContextMenu.Checked)
    End Sub

    Private Sub mnuOptionsByContextDescribeCompareTwoTreatments_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextDescribeCompareTwoTreatments.Click
        dlgCompareTreatmentLines.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextModelFitModel_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextModelFitModel.Click
        dlgOptionsByContextFitModel.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextPrepareCalculateDIfferenceBetweenOptions.Click
        dlgCalculateTreatmentDifferences.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextDescribeBoxplot_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextDescribeBoxplot.Click
        dlgOptionsByContextBoxplot.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataNonNumericCases_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataNonNumericCases.Click
        dlgFindNonnumericValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineNonNumericCases_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineNonNumericCases.Click
        dlgFindNonnumericValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineReplaceValues_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineReplaceValues.Click
        dlgReplaceValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineOneVariableSummarize_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineOneVariableSummarize.Click
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareLengthOfSeason_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareLengthOfSeason.Click
        dlgClimaticLengthOfSeason.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataAnonymiseIDColumn_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataAnonymiseIDColumn.Click
        dlgAnonymiseIDColumn.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileImportandTidyShapefile_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportandTidyShapefile.Click
        dlgImportShapeFiles.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineTidyDailyData_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineTidyDailyData.Click
        dlgTidyDailyData.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineMerge_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineMerge.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuClimaticCMSAFExporttoCMSAFRToolbox_Click(sender As Object, e As EventArgs) Handles mnuClimaticCMSAFExporttoCMSAFRToolbox.Click
        dlgExportToCMSAF.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareConversions_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareConversions.Click
        dlgConversions.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextGeneralFitModel_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextGeneralFitModel.Click
        dlgFitModel.ShowDialog()
    End Sub

    Private Sub mnuHelpAcknowledgments_Click(sender As Object, e As EventArgs) Handles mnuHelpAcknowledgments.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "151")
    End Sub

    Private Sub mnuDescribeSpecificMosaic_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificMosaic.Click
        dlgMosaicPlot.ShowDialog()
    End Sub

    Private Sub BarChartsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeCategoricalBarCharts.Click
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub MosaicPlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeCategoricalMosaic.Click
        dlgMosaicPlot.ShowDialog()
    End Sub

    Private Sub BoxplotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeNumericBoxplot.Click
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub HistogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramToolStripMenuItem.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub OpenFromLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProcurementOpenFromLibrary.Click
        dlgImportDataset.strFileToOpenOn = ""
        dlgImportDataset.bStartOpenDialog = True
        dlgImportDataset.bFromLibrary = True
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub MnuClimaticTidyandExamineUnstack_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineUnstack.Click
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineStack_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineStack.Click
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineAppend_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineAppend.Click
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareClimdex_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimdex.Click
        dlgClimdexIndices.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareSPI_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareSPI.Click
        dlgSPI.ShowDialog()
    End Sub

    Private Sub mnuHelpWindows_Click(sender As Object, e As EventArgs) Handles mnuHelpWindows.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "539")
    End Sub

    Private Sub mnuHelpDataViewSpreadsheet_Click(sender As Object, e As EventArgs) Handles mnuHelpDataViewSpreadsheet.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "134")
    End Sub

    Private Sub mnuClimaticTidyandExamineOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineOneVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineOneVariableFrequencies.Click
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineDuplicates_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineDuplicates.Click
        dlgDuplicates.ShowDialog()
    End Sub

    Private Sub mnuCumExeedenceGraph_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSACumExeedenceGraph.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnDefineCircular_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDefineCircular.Click
        dlgCircular.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnDefineConvertColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDefineConvertColumns.Click
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuProcurementDescribeCategoricalTreemap_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeCategoricalTreemap.Click
        dlgTreemap.ShowDialog()
    End Sub


    Private Sub mnuToolsInstallRPackage_Click(sender As Object, e As EventArgs) Handles mnuToolsInstallRPackage.Click
        dlgInstallRPackage.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFrameDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameDuplicateColumn.Click
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericRowSummaries_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericRowSummaries.Click
        dlgRowSummary.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericTransform_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericTransform.Click
        dlgTransform.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericPolynomials_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericPolynomials.Click
        dlgPolynomials.ShowDialog()
    End Sub

    Private Sub mnuPrepareCalculateCalculations_Click(sender As Object, e As EventArgs) Handles mnuPrepareCalculator.Click
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnFactorCountInFactor_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorCountInFactor.Click
        dlgCountinFactor.ShowDialog()
    End Sub

    Private Sub MnuScriptFile_Click(sender As Object, e As EventArgs) Handles mnuScriptFile.Click
        mnuViewScriptWindow.Checked = Not mnuViewScriptWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuLogFile_Click(sender As Object, e As EventArgs) Handles mnuLogFile.Click
        mnuViewLog.Checked = Not mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuLastGraph_ButtonClick(sender As Object, e As EventArgs) Handles mnuLastGraph.ButtonClick
        Me.Enabled = False
        clsRLink.ViewLastGraph()
        Me.Enabled = True
    End Sub

    Private Sub MnuMetadata_ButtonClick(sender As Object, e As EventArgs) Handles mnuMetadata.ButtonClick
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        mnuColumnMetadat.Checked = mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuTbLog_ButtonClick(sender As Object, e As EventArgs) Handles mnuTbLog.ButtonClick
        mnuViewLog.Checked = Not mnuViewLog.Checked
        mnuLogWindow.Checked = mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuColumnMetadat_Click(sender As Object, e As EventArgs) Handles mnuColumnMetadat.Click
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        mnuColumnMetadat.Checked = mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuDataFrameMetadat_Click(sender As Object, e As EventArgs) Handles mnuDataFrameMetadat.Click
        mnuViewDataFrameMetadata.Checked = Not mnuViewDataFrameMetadata.Checked
        mnuDataFrameMetadat.Checked = mnuViewDataFrameMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuScriptWindow_Click(sender As Object, e As EventArgs) Handles mnuScriptWindow.Click
        mnuViewScriptWindow.Checked = Not mnuViewScriptWindow.Checked
        mnuScriptWindow.Checked = mnuViewScriptWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuLogWindow_Click(sender As Object, e As EventArgs) Handles mnuLogWindow.Click
        mnuViewLog.Checked = Not mnuViewLog.Checked
        mnuLogWindow.Checked = mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub MnuViewer_Click(sender As Object, e As EventArgs) Handles mnuViewer.Click
        Me.Enabled = False
        clsRLink.ViewLastGraph()
        Me.Enabled = True
    End Sub

    Private Sub Mnuploty_Click(sender As Object, e As EventArgs) Handles mnuploty.Click
        Me.Enabled = False
        clsRLink.ViewLastGraph(bAsPlotly:=True)
        Me.Enabled = True
    End Sub

    Private Sub mnuModelFitModelOneVariable_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelOneVariable.Click
        dlgOneVarFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelTwoVariables_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelTwoVariables.Click
        dlgTwoVariableFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelThreeVariables_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelThreeVariables.Click
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelFourVariables_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelFourVariables.Click
        dlgFourVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelGeneral.Click
        dlgFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelModelKeyboard_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelModelKeyboard.Click
        dlgModelling.ShowDialog()
    End Sub

    Private Sub mnuModelCompareModelsOneVariable_Click(sender As Object, e As EventArgs) Handles mnuModelCompareModelsOneVariable.Click
        dlgOneVarCompareModels.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelOneVariable_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelOneVariable.Click
        dlgOneVarUseModel.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelTwoVariables_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelTwoVariables.Click
        dlgTwoVariableUseModel.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelUseModelKeyboard_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelUseModelKeyboard.Click
        dlgUseModel.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelGlance_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelGlance.Click
        dlgGlance.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelTidy_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelTidy.Click
        dlgTidy.ShowDialog()
    End Sub

    Private Sub mnuModelUseModelAugment_Click(sender As Object, e As EventArgs) Handles mnuModelUseModelAugment.Click
        dlgAugment.ShowDialog()
    End Sub

    Private Sub DisplayTopNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayTopNToolStripMenuItem.Click
        dlgDisplayTopN.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelHypothesisTestsKeyboard_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelHypothesisTestsKeyboard.Click
        dlgHypothesisTestsCalculator.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataHomogenization_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataHomogenization.Click
        dlgHomogenization.ShowDialog() 'partially working now
    End Sub

    Private Sub mnuStructuredCircularDefine_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularDefine.Click
        dlgCircular.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataFillMissingValues_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataFillMissingValues.Click
        dlgInfillMissingValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineVisualiseData.Click
        dlgVisualizeData.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataVisualiseData.Click
        dlgVisualizeData.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareCalculation_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareCalculation.Click
        dlgCompare.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareSummary_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareSummary.Click
        dlgCompareSummary.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareTaylorDiagram_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareTaylorDiagram.Click
        dlgTaylorDiagram.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareCorrelations_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareCorrelations.Click
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareScatterplot_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareScatterplot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareDensityPlot_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareDensityPlot.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularSummaries_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularSummaries.Click
        If dlgColumnStats.bFirstLoad Then
            dlgColumnStats.SetDefaultTab("Circular")
        End If
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularWindRose_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularCalculator_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularCalculator.Click
        If dlgCalculator.bFirstLoad Then
            dlgCalculator.SetDefaultKeyboard("Circular")
        End If
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularWindPollutionRose_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularWindPollutionRose.Click
        dlgWindPollutionRose.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareTimeSeriesPlot_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareTimeSeriesPlot.Click
        dlgTimeSeriesPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareSeasonalPlot_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareSeasonalPlot.Click
        dlgSeasonalPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticCompareConditionalQuantiles_Click(sender As Object, e As EventArgs) Handles mnuClimaticCompareConditionalQuantiles.Click
        dlgConditionalQuantilePlot.ShowDialog()
    End Sub

    Private Sub ExportToWWRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExportToWWRToolStrip.Click
        dlgExportToWWR.ShowDialog()
    End Sub

    Private Sub mnuStructuredSurvivalDefine_Click(sender As Object, e As EventArgs) Handles mnuStructuredSurvivalDefine.Click
        dlgSurvivalObject.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPIndices_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPIndices.Click
        dlgClimaticNCMPIndices.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPVariogram_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPVariogram.Click
        dlgClimaticNCMPVariogram.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPRegionAverage_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPRegionAverage.Click
        dlgClimaticNCMPRegionAverage.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPTrendGraphs_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPTrendGraphs.Click
        dlgClimaticNCMPTrendGraphs.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPCountRecords_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPCountRecords.Click
        dlgClimaticNCMPCountRecords.ShowDialog()
    End Sub

    Private Sub mnuClimaticNCMPSummary_Click(sender As Object, e As EventArgs) Handles mnuClimaticNCMPSummary.Click
        dlgClimaticNCMPSummaryFile.ShowDialog()
    End Sub

    Private Sub mnuViewSwapDataAndMetadata_Click(sender As Object, e As EventArgs) Handles mnuViewSwapDataAndMetadata.Click
        mnuViewSwapDataAndMetadata.Checked = Not mnuViewSwapDataAndMetadata.Checked
        UpdateSwapDataAndMetadata()
        UpdateLayout()
    End Sub

    Private Sub mnuViewSwapDataAndMetadata_CheckStateChanged(sender As Object, e As EventArgs) Handles mnuViewSwapDataAndMetadata.CheckStateChanged
        If Not mnuViewSwapDataAndMetadata.Checked AndAlso Not mnuViewDataView.Checked AndAlso mnuViewColumnMetadata.Checked Then
            mnuViewColumnMetadata.Checked = False
            mnuViewDataView.Checked = True
        End If
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            isMaximised = True
        End If
        If Me.WindowState = FormWindowState.Minimized Then
            isMinimised = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            isMaximised = False
        End If
    End Sub

    Private Sub mnuStructuredCircularDensityPlot_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularDensityPlot.Click
        dlgCircularDensityPlot.ShowDialog()
    End Sub

    Private Sub mnuTidyandExamineClimaticDataEntry_Click(sender As Object, e As EventArgs) Handles mnuTidyandExamineClimaticDataEntry.Click
        dlgClimaticDataEntry.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularOtherRosePlots_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularOtherRosePlots.Click
        dlgOtherRosePlots.ShowDialog()
    End Sub

    Private Sub mnuClimaticMappingMap_Click(sender As Object, e As EventArgs) Handles mnuClimaticMappingMap.Click
        dlgClimaticStationMaps.ShowDialog()
    End Sub

    Private Sub mnuClimaticMappingCheckStations_Click(sender As Object, e As EventArgs) Handles mnuClimaticMappingCheckStationLocations.Click
        dlgLocatingPointsInShapeFile.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataCheckStationLocations_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataCheckStationLocations.Click
        dlgLocatingPointsInShapeFile.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileImportfromClimateDataStore_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportfromClimateDataStore.Click
        dlgImportERA5Data.ShowDialog()
    End Sub

    Private Sub mnuSetupForDataEntry_Click(sender As Object, e As EventArgs) Handles mnuSetupForDataEntry.Click
        dlgSetupForDataEntry.ShowDialog()
    End Sub

    Private Sub mnuEditPasteNewDataFrame_Click(sender As Object, e As EventArgs) Handles mnuEditPasteNewDataFrame.Click
        dlgPasteNewDataFrame.ShowDialog()
    End Sub

    Private Sub mnuTbLan_Click(sender As Object, e As EventArgs) Handles mnuTbLan.Click
        If strCurrLang <> "en-GB" Then
            strCurrLang = "en-GB"
        Else
            strCurrLang = Me.clsInstatOptions.strLanguageCultureCode
        End If

        Dim strConfiguredLanguage As String = Me.clsInstatOptions.strLanguageCultureCode
        Me.clsInstatOptions.strLanguageCultureCode = strCurrLang
        translateMenu(mnuBar.Items, Me)
        Me.clsInstatOptions.strLanguageCultureCode = strConfiguredLanguage
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click, mnuTbCopy.ButtonClick, mnuSubTbCopy.Click
        If ctrActive.Equals(ucrDataViewer) Then
            ucrDataViewer.CopyRange()
        ElseIf ctrActive.Equals(ucrColumnMeta) Then
            ucrColumnMeta.CopyRange()
        ElseIf ctrActive.Equals(ucrDataFrameMeta) Then
            ucrDataFrameMeta.CopyRange()
        ElseIf ctrActive.Equals(ucrLogWindow) Then
            ucrLogWindow.CopyText()
        ElseIf ctrActive.Equals(ucrScriptWindow) Then
            ucrScriptWindow.CopyText()
        End If
    End Sub

    Private Sub mnuEditCopySpecial_Click(sender As Object, e As EventArgs) Handles mnuEditCopySpecial.Click, mnuSubTbCopySpecial.Click
        dlgCopySpecial.ShowDialog()
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click, mnuTbPaste.ButtonClick, mnuSubTbPaste.Click
        'todo. add public paste functions for the ucrDataViewer, ucrColumnMeta and ucrDataFrameMeta grids
    End Sub

    Private Sub mnuPasteSpecial_Click(sender As Object, e As EventArgs) Handles mnuPasteSpecial.Click, mnuSubTbPasteSpecial.Click
        dlgPasteSpecial.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesPivotTable_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesPivotTable.Click
        dlgPivotTable.ShowDialog()
    End Sub

    Private Sub mnuEditScript_Click(sender As Object, e As EventArgs) Handles mnuEditScript.Click
        dlgScript.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFrameSelectColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameSelectColumns.Click
        dlgSelect.ShowDialog()
    End Sub

    Private Sub mnuDescribeThreeVariablePivotTable_Click(sender As Object, e As EventArgs) Handles mnuDescribeThreeVariablePivotTable.Click
        dlgThreeVariablePivotTable.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileExportToClimsoft_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileExportToClimsoft.Click
        dlgExportToClimsoft.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineCompareColumns_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineCompareColumns.Click
        dlgCompareColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataReshapeScaleOrDistance_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataReshapeScaleOrDistance.Click
        dlgCluster.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableVisualiseData.Click
        dlgVisualizeData.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelMachineLearning_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelMachineLearning.Click
        dlgMachineLearning.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateClusterAnalysis_Click(sender As Object, e As EventArgs) Handles mnuDescribeMultivariateClusterAnalysis.Click
        dlgClusterAnalysis.ShowDialog()
    End Sub
End Class
