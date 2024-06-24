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
Imports System.Net
Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports System.ComponentModel
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.InteropServices

Public Class frmMain
    Public clsRLink As RLink
    Public clsGrids As New clsGridLink
    Public strStaticPath As String
    Public strHelpFilePath As String = "Help\R-Instat.chm"
    Public strAppDataPath As String
    Public strInstatOptionsFile As String = "Options.bin"
    Public clsInstatOptions As InstatOptions
    Public clsRecentItems As clsRecentFiles
    'Public strCurrentDataFrame As String
    Public dlgLastDialog As Form
    Public strSaveFilePath As String = ""
    Public clsOutputLogger As clsOutputLogger
    Private mnuItems As New List(Of Form)
    Private ctrActive As Control
    Private WithEvents timer As New System.Windows.Forms.Timer
    Private iAutoSaveDataMilliseconds As Integer
    Private clsDataBook As clsDataBook
    Private Shared ReadOnly Logger As NLog.Logger = NLog.LogManager.GetCurrentClassLogger()
    Public bFirstBackupDone As Boolean = False
    Public ReadOnly Property DataBook As clsDataBook
        Get
            Return clsDataBook
        End Get
    End Property

    Public strAutoSaveDataFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_data_auto_save")
    Public strAutoSaveLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_log_auto_save")
    Public strAutoSaveInternalLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_debug_log_auto_save")

    Public strCurrentAutoSaveDataFilePath As String = ""

    Private strLatestVersion As String = ""

    Public isMinimised As Boolean = False
    Public isMaximised As Boolean = False

    'This is the default data frame to appear in the data frame selector
    'If "" the current worksheet will be used
    'TODO This should be an option in the Options dialog
    '     User can choose a default data frame or set the default as the current worksheet
    Public strDefaultDataFrame As String = ""

    Private strCurrentOutputFileName As String = "" 'holds the saved ouput file name to help remember the current selected folder path

    ''' <summary>
    ''' flag used to indicate if current state of selected data has been saved
    ''' it's set to false by ucrDataView control when state of data has been changed
    ''' it's set to true by dlgSaveAs dialog and save menu when data has been successfully saved 
    ''' </summary>
    Public Property bDataSaved As Boolean = False

    Private strCurrLang As String
    Public Sub New()
        Logger.Info("R-Instat started version " & My.Application.Info.Version.ToString)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'set controls layout
        SetupInitialLayout()

        clsOutputLogger = New clsOutputLogger
        clsRLink = New RLink(clsOutputLogger)
        If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) Then
            If Not CefRuntimeWrapper.InitialiseCefRuntime() Then
                MessageBox.Show(Me, "Cef runtime could not be initialised." & Environment.NewLine & "Html content will be shown in your default browser.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '---------------------------------------
        'Gets the path for the executable file that started the application, not including the executable name.
        'We use `Application.StartupPath` because this returns the correct path even if the 
        'application was started by double-clicking a data file in another folder.
        'We need the full path of the static folder to set the working folder containing files 
        'needed when the application is loading.         
        strStaticPath = String.Concat(Application.StartupPath, "\static")
        strAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RInstat\")
        '---------------------------------------

        Dim prdCustom As New clsCustomRenderer(New clsCustomColourTable)

        mnuBar.Renderer = prdCustom
        Tool_strip.Renderer = prdCustom
        '---------------------------------------
        'disable main menu items to prevent user inputs durinng initialisation
        Cursor = Cursors.WaitCursor
        SetMainMenusEnabled(False)
        '---------------------------------------
        'temporary

        ' This must be fixed because CurrentCulture affects functions such as Decimal.TryParse
        ' e.g. "1.0" fails Decimal.TryParse if CurrentCulture = "fr-FR" because it expects "1,0"
        ' Decimal point must be `.` and not `,` because R only accepts `.`
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-GB")

        'ucrDataViewer.StartupMenuItemsVisibility(False)
        clsDataBook = New clsDataBook(clsRLink)

        ucrDataViewer.DataBook = clsDataBook
        ucrColumnMeta.DataBook = clsDataBook
        ucrDataFrameMeta.DataBook = clsDataBook

        ucrOutput.SetLogger(clsOutputLogger)

        '---------------------------------------
        'set up R-Instat options (settings)
        'load any saved options if available
        clsInstatOptions = GetSavedRInstatOptions()
        If clsInstatOptions Is Nothing Then
            clsInstatOptions = New InstatOptions
        End If
        clsInstatOptions.SetDefaultValuesToOptionsNotSet()
        '---------------------------------------

        '---------------------------------------
        'translate the form menu items
        'must come after loading options as options may change language.
        TranslateFrmMainMenu()
        '---------------------------------------

        '---------------------------------------
        'toggle the optional form menu items based on set opyions
        mnuViewStructuredMenu.Checked = clsInstatOptions.bShowStructuredMenu
        mnuViewClimaticMenu.Checked = clsInstatOptions.bShowClimaticMenu
        mnuViewProcurementMenu.Checked = clsInstatOptions.bShowProcurementMenu
        mnuIncludeComments.Checked = clsInstatOptions.bIncludeCommentDefault
        mnuShowRCommand.Checked = clsInstatOptions.bCommandsinOutput
        mnuTbLan.Visible = clsInstatOptions.strLanguageCultureCode <> "en-GB"
        strCurrLang = clsInstatOptions.strLanguageCultureCode
        '---------------------------------------

        '---------------------------------------
        'Set up the Recent items; files, dialogs
        clsRecentItems = New clsRecentFiles(strAppDataPath)
        clsRecentItems.SetToolStripItems(mnuFile, mnuTbOpen, mnuTbLast10Dialogs)
        clsRecentItems.SetDataViewWindow(ucrDataViewer)
        'check existence of MRU list
        clsRecentItems.checkOnLoad()
        '---------------------------------------

        '---------------------------------------
        'set output window options
        ucrOutput.SetInstatOptions(clsInstatOptions)
        '---------------------------------------

        '---------------------------------------
        'start the R engine and install any missing R packages
        'only proceed if;
        '1. R engine has been started
        '2. All packages have been installed
        If Not (clsRLink.StartREngine() AndAlso AllPackagesInstalled()) Then
            Application.Exit()
            Environment.Exit(0)
        End If
        '---------------------------------------

        '---------------------------------------
        'execute R-Instat R set up scripts to set up R data book
        ExecuteSetupRScriptsAndSetupRLinkAndDatabook()
        'execute R global options used by R-Instat R data book
        clsInstatOptions.ExecuteRGlobalOptions()
        '---------------------------------------

        '---------------------------------------
        'enable menu items to allow user inputs
        Cursor = Cursors.Default
        SetMainMenusEnabled(True)
        '---------------------------------------

        '---------------------------------------
        Try
            If (Environment.GetCommandLineArgs.Length > 1) Then
                dlgImportDataset.strFileToOpenOn = Environment.GetCommandLineArgs(1)
                dlgImportDataset.bStartOpenDialog = False
                dlgImportDataset.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '---------------------------------------

        '---------------------------------------
        'Do this after loading options because interval depends on options
        'Interval is in milliseconds and option is in minutes
        timer.Interval = (clsInstatOptions.iAutoSaveDataMinutes * 60 * 1000)
        timer.Start()
        AddHandler System.Windows.Forms.Application.Idle, AddressOf Application_Idle
        '---------------------------------------

        isMaximised = True 'Need to get the windowstate when the application is loaded
    End Sub

    Private Sub CheckForUpdates()
        Dim webClient As New WebClient()

        Try
            ' Download the version information file from the website
            strLatestVersion = webClient.DownloadString("https://r-instat.org/version.txt")
            Dim strCurrVersion = My.Application.Info.Version.ToString()

            ' Compare with the current version of your app
            If strLatestVersion > strCurrVersion Then
                ' New version available, show a notification
                Dim result As DialogResult = MessageBox.Show("R-Instat " & strLatestVersion & " is now available -- you have " & strCurrVersion & Environment.NewLine & "Do you want to dowload it?", "A new version of R-Instat Available!",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Dim myProcess = New System.Diagnostics.Process
                    myProcess.StartInfo.FileName = "https://r-instat.org/"
                    myProcess.Start()
                End If
            End If
        Catch ex As Exception
            MsgBox("Network issues or website not accessible")
        End Try
    End Sub

    Private Sub SetupInitialLayout()
        'splOverall has 2 panels
        'splOverall.Panel1 contains splExtraWindows
        'splOverall.Panel2 contains splDataOutput

        'splExtraWindows has 2 panels
        'splExtraWindows.Panel1 contains splMetadata
        'splExtraWindows.Panel2 contains script window

        'splMetadata has 2 panels
        'splMetadata.Panel1 contains data frame
        'splMetadata.Panel2 contains column metadata

        'splDataOutput has 2 panels
        'splDataOutput.Panel1 contains data viewer window
        'splDataOutput.Panel2 contains output window

        'collaspe all the panels initially (on application startup)
        splOverall.Panel1Collapsed = True
        splOverall.Panel2Collapsed = True

        splExtraWindows.Panel1Collapsed = True
        splExtraWindows.Panel2Collapsed = True

        splMetadata.Panel1Collapsed = True
        splMetadata.Panel2Collapsed = True

        splDataOutput.Panel1Collapsed = True
        splDataOutput.Panel2Collapsed = True

        SetToDefaultLayout()
    End Sub

    Private Sub SetToDefaultLayout()
        splOverall.SplitterDistance = splOverall.Height / 4
        splDataOutput.SplitterDistance = splDataOutput.Width / 2
        splExtraWindows.SplitterDistance = splExtraWindows.Width / 2
        splMetadata.SplitterDistance = splMetadata.Width / 2

        mnuViewDataView.Checked = True
        mnuViewOutput.Checked = True
        mnuViewDataFrameMetadata.Checked = False
        mnuViewColumnMetadata.Checked = False
        mnuViewLogScript.Checked = False
        mnuViewSwapDataAndMetadata.Checked = False
        mnuViewSwapDataAndScript.Checked = False
        mnuColumnMetadat.Checked = False
        mnuDataFrameMetadat.Checked = False

        mnuTbDataView.Checked = True
        mnuOutputWindow.Checked = True
        mnuLogScript.Checked = False
        UpdateLayout()
    End Sub

    Public Sub UpdateLayout()

        Try
            If Not mnuViewDataView.Checked _
                            AndAlso Not mnuViewOutput.Checked _
                            AndAlso Not mnuViewColumnMetadata.Checked _
                            AndAlso Not mnuViewDataFrameMetadata.Checked _
                            AndAlso Not mnuViewLogScript.Checked _
                            AndAlso Not mnuViewSwapDataAndMetadata.Checked _
                            AndAlso Not mnuViewSwapDataAndScript.Checked Then
                splOverall.Hide()
            Else
                splOverall.Show()

                'determine splOverall contents visibility 

                '-------------------------------
                'determine splOverall.Panel1 and it's contents visibility

                If mnuViewColumnMetadata.Checked OrElse mnuViewDataFrameMetadata.Checked OrElse mnuViewLogScript.Checked Then
                    'expand panel 1
                    splOverall.Panel1Collapsed = False
                    'change splOverall.Panel1Collapsed contents visibilty
                    If mnuViewColumnMetadata.Checked OrElse mnuViewDataFrameMetadata.Checked Then
                        splMetadata.Panel1Collapsed = Not mnuViewColumnMetadata.Checked
                        splMetadata.Panel2Collapsed = Not mnuViewDataFrameMetadata.Checked
                        splExtraWindows.Panel1Collapsed = False
                    Else
                        splExtraWindows.Panel1Collapsed = True
                    End If
                    'expand panel 2 based on log script menu item checked status
                    splExtraWindows.Panel2Collapsed = Not mnuViewLogScript.Checked
                Else
                    splOverall.Panel1Collapsed = True
                End If
                '-------------------------------

                '-------------------------------
                'determine splOverall.Panel2 and it's contents visibility

                If mnuViewDataView.Checked OrElse mnuViewOutput.Checked Then
                    splDataOutput.Panel1Collapsed = Not mnuViewDataView.Checked
                    splDataOutput.Panel2Collapsed = Not mnuViewOutput.Checked
                    splOverall.Panel2Collapsed = False
                Else
                    splOverall.Panel2Collapsed = True
                End If
                '-------------------------------


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        mnuTbDataView.Checked = mnuViewDataView.Checked
        mnuOutputWindow.Checked = mnuViewOutput.Checked
        mnuLogScript.Checked = mnuViewLogScript.Checked
    End Sub

    Private Function GetSavedRInstatOptions() As InstatOptions
        Dim clsInstatOptions As InstatOptions = Nothing
        Dim strFilePath As String = Path.Combine(strAppDataPath, strInstatOptionsFile)
        If File.Exists(strFilePath) Then
            Try
                Using FileStream As Stream = File.OpenRead(strFilePath)
                    clsInstatOptions = CType(New BinaryFormatter().Deserialize(FileStream), InstatOptions)
                End Using
            Catch ex As Exception
                MsgBox("Could not load options from:" & strFilePath & Environment.NewLine & "The file may be in use by another program or the file does not contain an instance of InstatOptions." & Environment.NewLine & "Options will be reset to factory defaults." & vbNewLine & "System error message: " & ex.Message, MsgBoxStyle.Information, "Cannot open options file")
            End Try
        End If

        Return clsInstatOptions
    End Function

    Private Function AllPackagesInstalled() As Boolean
        'check missing R packages and prompt to install them
        Dim arrMissingPackages() As String = clsRLink.GetRPackagesNotInstalled()
        If arrMissingPackages IsNot Nothing AndAlso arrMissingPackages.Length > 0 Then
            frmPackageIssues.SetMissingPackages(arrMissingPackages)
            frmPackageIssues.ShowDialog()
            Return Not frmPackageIssues.bCloseRInstat
        Else
            Return True
        End If
    End Function

    Private Sub ExecuteSetupRScriptsAndSetupRLinkAndDatabook()
        Dim strRScripts As String = ""
        Dim strDataFilePath As String = ""

        'could either be a file path or a script
        PromptAndSetAutoRecoveredPrevSessionData(strRScripts, strDataFilePath)

        'if no script recovered then use the default R set up script
        If String.IsNullOrEmpty(strRScripts) Then
            strRScripts = "# Initialising R (e.g Loading R packages)" & Environment.NewLine & clsRLink.GetRSetupScript()
        End If

        'if data file recovered then add it as part of the initial R set up script
        If Not String.IsNullOrEmpty(strDataFilePath) Then
            strRScripts = strRScripts & Environment.NewLine &
                        "# Importing auto recovered data" & Environment.NewLine &
                        clsRLink.GetImportRDSRScript(strDataFilePath, False)
        End If


        'execute the R-Instat set up R scripts
        For Each strLine As String In strRScripts.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            clsRLink.RunScript(strScript:=strLine.Trim(), bSeparateThread:=True, bSilent:=True)
        Next

        'as of 16/05/2023. clsDataBook depends on clsRLink.bInstatObjectExists property
        'to check if R object has been set up at R level.

        'grids are only updated when clsRLink.bInstatObjectExists = True
        If clsRLink.RunInternalScriptGetValue(strScript:="exists('" & clsRLink.strInstatDataObject & "')",
                                              bSeparateThread:=True, bSilent:=True).AsCharacter(0) = "TRUE" Then
            'set R-Instat R object as exists if it has been set up in R level and refresh the grids
            'refreshing grids internally updates the .Net databook object as well.
            clsRLink.bInstatObjectExists = True
            UpdateAllGrids()
        End If

    End Sub

    Private Sub PromptAndSetAutoRecoveredPrevSessionData(ByRef strScript As String, ByRef strDataFilePath As String)

        'if there is  another R-Instat process in the machine then no need to check for autorecovery files
        If Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1 Then
            Return
        End If

        'todo. As of 16/05/2023.
        'the only log file that are multiple is the internal debug file.
        'this is due to checking of R version when setting up R engine. the check creates a debug file before this subroutine is called
        'should we change stop using arrays for the other recovery files?
        Dim strAutoSavedLogFilePaths() As String = {}
        Dim strAutoSavedInternalLogFilePaths() As String = {}
        Dim strAutoSavedDataFilePaths() As String = {}

        If (Directory.Exists(strAutoSaveLogFolderPath)) Then
            strAutoSavedLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveLogFolderPath).ToArray
        End If
        If Directory.Exists(strAutoSaveDataFolderPath) Then
            strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveDataFolderPath).ToArray
        End If
        If (Directory.Exists(strAutoSaveInternalLogFolderPath)) Then
            strAutoSavedInternalLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveInternalLogFolderPath).ToArray
        End If

        '---------------------------------------
        'prompt user for recovery selection
        If (strAutoSavedLogFilePaths.Length > 0 OrElse
            strAutoSavedDataFilePaths.Length > 0) AndAlso
            MsgBox("We have detected that R-Instat may have closed unexpectedly last time." & Environment.NewLine &
                          "Would you like to see auto recovery options?",
                          MessageBoxButtons.YesNo, "Auto Recovery") = MsgBoxResult.Yes Then

            dlgAutoSaveRecovery.strAutoSavedLogFilePaths = strAutoSavedLogFilePaths
            dlgAutoSaveRecovery.strAutoSavedDataFilePaths = strAutoSavedDataFilePaths
            dlgAutoSaveRecovery.strAutoSavedInternalLogFilePaths = strAutoSavedInternalLogFilePaths
            dlgAutoSaveRecovery.ShowDialog()

            'todo. the dialog design is meant to only return just one option; script, data file path or new session.
            'refactor the dialog to enforce the design

            'get the R script from read file if selected by the user
            strScript = dlgAutoSaveRecovery.GetScript()
            'get the data file path if selected by the user
            strDataFilePath = dlgAutoSaveRecovery.GetDataFilePath()
        End If
        '---------------------------------------

        '---------------------------------------
        'delete the recovery files
        If strAutoSavedLogFilePaths.Length > 0 Then
            Try
                File.Delete(strAutoSavedLogFilePaths(0))
            Catch ex As Exception
                MsgBox("Could not delete backup log file" & Environment.NewLine, "Error deleting file")
            End Try
        End If
        If strAutoSavedInternalLogFilePaths.Length > 0 Then
            Try
                For Each strFilePath As String In strAutoSavedInternalLogFilePaths
                    'debug log is created when checking r version. 
                    'so always delete the previous session debug file only
                    If strFilePath <> clsRLink.strAutoSaveDebugLogFilePath Then
                        File.Delete(strFilePath)
                    End If
                Next
            Catch ex As Exception
                MsgBox("Could not delete backup internal log file." & Environment.NewLine & ex.Message, "Error deleting file")
            End Try
        End If

        If strAutoSavedDataFilePaths.Length > 0 Then
            Try
                File.Delete(strAutoSavedDataFilePaths(0))
            Catch ex As Exception
                MsgBox("Could not delete back data file." & Environment.NewLine & ex.Message, "Error deleting file")
            End Try
        End If
        '---------------------------------------

    End Sub
    Private Sub mnuToolsRestoreBackup_Click(sender As Object, e As EventArgs) Handles mnuToolsRestoreBackup.Click
        dlgRestoreBackup.ShowDialog()
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

    Public Sub UpdateSwapDataAndScript()
        If mnuViewSwapDataAndScript.Checked Then
            splDataOutput.Panel1.Controls.Add(ucrScriptWindow)
            splExtraWindows.Panel2.Controls.Add(ucrDataViewer)
            mnuViewLogScript.Text = "Data View"
            mnuViewDataView.Text = "Log/Script"
        Else
            splDataOutput.Panel1.Controls.Add(ucrDataViewer)
            splExtraWindows.Panel2.Controls.Add(ucrScriptWindow)
            mnuViewLogScript.Text = "Log/Script"
            mnuViewDataView.Text = "Data View"
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

    Public Sub AddToScriptWindow(strText As String, Optional bMakeVisible As Boolean = True, Optional bAppendAtCurrentCursorPosition As Boolean = False)
        ucrScriptWindow.AppendText(strText, bAppendAtCurrentCursorPosition:=bAppendAtCurrentCursorPosition)
        If bMakeVisible Then
            mnuViewLogScript.Checked = True
            UpdateLayout()
        End If
    End Sub

    Private Sub mnuFileNewDataFrame_Click(sender As Object, e As EventArgs) Handles mnuFileNewDataFrame.Click
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericRegularSequence_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericRegularSequence.Click
        dlgRegularSequence.SetNumericSequenceAsDefaultOption()
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificTables_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificTables.Click
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeStack_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeStack.Click
        dlgStack.enumStackMode = dlgStack.StackMode.Prepare
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeUnstack_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeUnstack.Click
        dlgUnstack.enumUnstackMode = dlgUnstack.UnstackMode.Prepare
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRecode_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnFactorRecodeNumeric.Click
        dlgRecodeNumeric.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnNumericRandomSamples_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnNumericRandomSamples.Click
        dlgRandomSample.enumRandomSampleMode = dlgRandomSample.RandomSampleMode.Prepare
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

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs) Handles mnuViewDataFrameMetadata.Click
        mnuViewDataFrameMetadata.Checked = Not mnuViewDataFrameMetadata.Checked
        mnuDataFrameMetadat.Checked = mnuViewDataFrameMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuLogScript_Click(sender As Object, e As EventArgs) Handles mnuLogScript.Click, mnuViewLogScript.Click, mnuTbLogScript.ButtonClick
        mnuViewLogScript.Checked = Not mnuViewLogScript.Checked
        mnuLogScript.Checked = mnuViewLogScript.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareReshapeMerge_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeMerge.Click
        dlgMerge.enumMergeMode = dlgMerge.MergeMode.Prepare
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

    Private Sub mnuPrepareSheetColumnMetadata_Click(sender As Object, e As EventArgs) Handles mnuViewColumnMetadata.Click
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuShowRCommand_Click(sender As Object, e As EventArgs) Handles mnuShowRCommand.Click
        mnuShowRCommand.Checked = Not mnuShowRCommand.Checked
        clsInstatOptions.SetCommandInOutpt(mnuShowRCommand.Checked)
        clsInstatOptions.ExecuteRGlobalOptions()
    End Sub

    Private Sub mnuIncludeComments_Click(sender As Object, e As EventArgs) Handles mnuIncludeComments.Click
        mnuIncludeComments.Checked = Not mnuIncludeComments.Checked
        clsInstatOptions.SetIncludeCommentByDefault(mnuIncludeComments.Checked)
        clsInstatOptions.ExecuteRGlobalOptions()
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

    Private Sub mnuTbLast10Dialogs_ButtonClick(sender As Object, e As EventArgs) Handles mnuTbLast10Dialogs.ButtonClick
        If clsRecentItems.lstRecentDialogs.Count > 0 Then
            clsRecentItems.lstRecentDialogs.Last.ShowDialog()
        End If
    End Sub

    Private Sub mnuTbSave_Click(sender As Object, e As EventArgs) Handles mnuTbSave.ButtonClick, mnuSaveData.Click
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
        dlgSplitText.enumSplitMode = dlgSplitText.SplitMode.Prepare
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextCombine_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextCombine.Click
        dlgCombineText.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFilter_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameFilterRows.Click
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

    Private Sub mnuPrepareTextTransform_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextTransform.Click
        dlgTransformText.enumTransformMode = dlgTransformText.TransformMode.Prepare
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
            ElseIf ctrActive.Equals(ucrScriptWindow) Then
                ucrScriptWindow.SelectAllText()
            End If
        End If
    End Sub

    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs) Handles mnuToolsOptions.Click
        dlgOptions.ShowDialog()
        mnuShowRCommand.Checked = dlgOptions.ucrChkShowRCommandsinOutputWindow.chkCheck.Checked
        mnuIncludeComments.Checked = dlgOptions.ucrChkIncludeCommentsbyDefault.chkCheck.Checked
    End Sub

    Private Sub mnuModelProbabilityDistributionsRandomSamplesUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsRandomSamplesUseModel.Click
        dlgRandomSample.enumRandomSampleMode = dlgRandomSample.RandomSampleMode.Model
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

    Private Sub OutputWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewOutput.Click
        mnuViewOutput.Checked = Not mnuViewOutput.Checked
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
        dlgFindInVariableOrFilter.ShowDialog()
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
        dlgOneVariableGraph.enumOnevariableMode = dlgOneVariableGraph.OnevariableMode.Describe
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
                    DeleteAutoSaveFiles()
                    clsRLink.CloseREngine()
                End If

                If RuntimeInformation.IsOSPlatform(OSPlatform.Windows) Then
                    CefRuntimeWrapper.ShutDownCef()
                End If
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

            ' Generate a unique filename with timestamp
            strTempFile = "data_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".rds"
            strCurrentAutoSaveDataFilePath = Path.Combine(strAutoSaveDataFolderPath, strTempFile)

            Dim strBackupMessage As String = $"##########{vbCrLf}## Backing up data and log files on: {DateTime.Now}{vbCrLf}##########"
            Me.ucrScriptWindow.LogText(strBackupMessage)
            clsRLink.AppendToAutoSaveLog(strBackupMessage)

            clsSaveRDS.SetRCommand("saveRDS")
            clsSaveRDS.AddParameter("object", clsRLink.strInstatDataObject)
            clsSaveRDS.AddParameter("file", Chr(34) & strCurrentAutoSaveDataFilePath.Replace("\", "/") & Chr(34))
            clsRLink.RunInternalScript(clsSaveRDS.ToScript(), bSilent:=True, bShowWaitDialogOverride:=False)
            tstatus.Text = strCurrentStatus
            Cursor = Cursors.Default
            bFirstBackupDone = True
        End If
        autoTranslate(Me)
    End Sub

    Public Sub DeleteAutoSaveFiles()
        Try
            If Directory.Exists(strAutoSaveDataFolderPath) OrElse Directory.Exists(strAutoSaveLogFolderPath) OrElse Directory.Exists(strAutoSaveInternalLogFolderPath) Then
                ' Define the retention policy (keep last N autosaves)
                Dim retentionCount As Integer = 5 ' Example: Keep the last 5 autosaves

                ' Retrieve autosaved files
                If Directory.Exists(strAutoSaveDataFolderPath) Then
                    Dim autoSaveDirectory As New DirectoryInfo(strAutoSaveDataFolderPath)
                    Dim files As FileInfo() = autoSaveDirectory.GetFiles("data_*.rds") ' Adjust pattern to match actual filenames

                    ' Sort files by last write time in descending order
                    Dim sortedFiles As IOrderedEnumerable(Of FileInfo) = files.OrderByDescending(Function(f) f.LastWriteTime)

                    ' Determine files to delete based on retention policy
                    Dim filesToDelete As IEnumerable(Of FileInfo) = sortedFiles.Skip(retentionCount)

                    ' Delete older autosaved files
                    For Each file In filesToDelete
                        file.Delete()
                    Next
                ElseIf Directory.Exists(strAutoSaveLogFolderPath) Then
                    Dim autoSaveDirectory As New DirectoryInfo(strAutoSaveLogFolderPath)
                    Dim files As FileInfo() = autoSaveDirectory.GetFiles("log*.R") ' Adjust pattern to match actual filenames

                    ' Sort files by last write time in descending order
                    Dim sortedFiles As IOrderedEnumerable(Of FileInfo) = files.OrderByDescending(Function(f) f.LastWriteTime)

                    ' Determine files to delete based on retention policy
                    Dim filesToDelete As IEnumerable(Of FileInfo) = sortedFiles.Skip(retentionCount)

                    ' Delete older autosaved files
                    For Each file In filesToDelete
                        file.Delete()
                    Next
                ElseIf Directory.Exists(strAutoSaveInternalLogFolderPath) Then
                    Dim autoSaveDirectory As New DirectoryInfo(strAutoSaveInternalLogFolderPath)
                    Dim files As FileInfo() = autoSaveDirectory.GetFiles("debug_log*.R") ' Adjust pattern to match actual filenames

                    ' Sort files by last write time in descending order
                    Dim sortedFiles As IOrderedEnumerable(Of FileInfo) = files.OrderByDescending(Function(f) f.LastWriteTime)

                    ' Determine files to delete based on retention policy
                    Dim filesToDelete As IEnumerable(Of FileInfo) = sortedFiles.Skip(retentionCount)

                    ' Delete older autosaved files
                    For Each file In filesToDelete
                        file.Delete()
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Could not delete auto save data file at: " & strCurrentAutoSaveDataFilePath & Environment.NewLine & ex.Message)
        End Try
    End Sub


    Private Sub mnuOrganiseDataObjectHideDataframes_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectHideDataframes.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameReplaceValues_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameReplaceValues.Click
        dlgReplaceValues.enumReplacevaluesMode = dlgReplaceValues.ReplacevaluesMode.Prepare
        dlgReplaceValues.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesSummarise.Click
        dlgDescribeTwoVariable.enumTwovariableMode = dlgDescribeTwoVariable.TwovariableMode.Describe
        dlgDescribeTwoVariable.ShowDialog()
    End Sub

    Private Sub mnuAppendDataFrame_Click(sender As Object, e As EventArgs) Handles mnuPrepareAppendDataFrame.Click
        dlgAppend.enumAppendMode = dlgAppend.AppendMode.Prepare
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsOutputAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsOutputAs.Click, mnuSaveOutput.Click
        ucrOutput.UcrOutputPages.SaveTab()
    End Sub

    Private Sub mnuFileSaveAsLogAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsLogAs.Click, mnuSaveLog.Click
        ucrScriptWindow.SaveScript(True)
    End Sub

    Private Sub mnuFileSaveAsScriptAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsScriptAs.Click, mnuSaveScript.Click
        ucrScriptWindow.SaveScript(False)
    End Sub

    Private Sub mnuDescribeTwoVariablesGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesGraph.Click
        dlgDescribeTwoVarGraph.enumTwovarMode = dlgDescribeTwoVarGraph.TwovarMode.Describe
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
        dlgCorrelation.SetMultipleSequenceAsDefaultOption()
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
        dlgBoxplot.enumBoxplotMode = dlgBoxplot.BoxplotMode.Describe
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
        dlgMakeDate.enumMakedateMode = dlgMakeDate.MakedateMode.Prepare
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

    Private Sub mnuOrganiseColumnUseDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateUseDate.Click
        dlgUseDate.enumUsedateMode = dlgUseDate.UsedateMode.Prepare
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuHelpHelpIntroduction_Click(sender As Object, e As EventArgs) Handles mnuHelpHelpIntroduction.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "0")
    End Sub

    Private Sub mnuHelpHistFAQ_Click(sender As Object, e As EventArgs) Handles mnuHelpFAQ.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "290")
    End Sub

    Private Sub mnuHelpGetingStarted_Click(sender As Object, e As EventArgs) Handles mnuHelpGetingStarted.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "3")
    End Sub

    Private Sub mnuHelpDataset_Click(sender As Object, e As EventArgs) Handles mnuHelpData.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "71")
    End Sub

    Private Sub mnuHelpRPackagesCommands_Click(sender As Object, e As EventArgs) Handles mnuHelpRPackages.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "26")
    End Sub

    Private Sub mnuHelpR_Click(sender As Object, e As EventArgs) Handles mnuHelpAboutR.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "133")
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
        dlgAddKey.enumAddkeyMode = dlgAddKey.AddkeyMode.Prepare
        dlgAddKey.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesMakeDate_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesMakeDate.Click
        dlgMakeDate.enumMakedateMode = dlgMakeDate.MakedateMode.Climatic
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesUseDate_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesUseDate.Click
        dlgUseDate.enumUsedateMode = dlgUseDate.UsedateMode.Climatic
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareInfillMissingDates_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesInfillMissingDates.Click
        dlgInfill.enumFilldateMode = dlgInfill.FilldateMode.Climatic
        dlgInfill.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSARainfall_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSARainfallGraph.Click
        dlgPICSARainfall.enumPICSAMode = dlgPICSARainfall.PICSAMode.Rainfall
        dlgPICSARainfall.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSATemperature_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSATemperatureGraph.Click
        dlgPICSARainfall.enumPICSAMode = dlgPICSARainfall.PICSAMode.Temperature
        dlgPICSARainfall.ShowDialog()
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
        dlgCorrelation.SetMultipleSequenceAsDefaultOption()
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

    Private Sub mnuDescribeTwoVariablesFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoThreeVariablesTwoWayFrequencies.Click
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
        dlgOneWayFrequencies.enumOnewayMode = dlgOneWayFrequencies.OnewayMode.Describe
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

    Private Sub mnuClimaticPrepareClimaticSummaries_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimaticSummaries.Click
        dlgClimaticSummary.ShowDialog()
    End Sub

    Public Function GetDataFrameCount() As Integer
        If clsDataBook IsNot Nothing Then
            Return clsDataBook.DataFrames.Count
        End If
        Return 0
    End Function

    Public Sub UseColumnSelectionInMetaData(bUseColumnSelecion As Boolean)
        ucrColumnMeta.UseColumnSelectionInMetaData(bUseColumnSelecion)
    End Sub

    Public Sub UseColumnSelectionInDataView(bUseColumnSelecion As Boolean)
        ucrDataViewer.UseColumnSelectionInDataView(bUseColumnSelecion)
    End Sub

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
        If ucrDataViewer.GetWorkSheetCount() <= 0 Then
            Exit Sub
        End If

        If Not bDataSaved _
                AndAlso DialogResult.No = MsgBox("Are you sure you want to close your data?" &
                                    Environment.NewLine & "Any unsaved changes will be lost.",
                                    MessageBoxButtons.YesNo, "Close Data") Then
            Exit Sub
        End If

        clsRLink.CloseDataBook()
        strSaveFilePath = ""
    End Sub

    Private Sub mnuPrepareCheckDataDuplicates_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataDuplicates.Click
        dlgDuplicateRows.enumDuplicateMode = dlgDuplicateRows.DuplicateMode.Prepare
        dlgDuplicateRows.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataBoxplot_Click_1(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataBoxplot.Click
        dlgClimaticBoxPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticCMSAFPlotRegion_Click(sender As Object, e As EventArgs) Handles mnuClimaticCMSAFPlotRegion.Click
        dlgPlotRegion.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataDisplayDaily_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataDisplayDaily.Click
        dlgDisplayDailyData.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnInfillMissingDates_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnDateInfillMissingDates.Click
        dlgInfill.enumFilldateMode = dlgInfill.FilldateMode.Prepare
        dlgInfill.ShowDialog()
    End Sub

    Private Sub mnuDataView_Click(sender As Object, e As EventArgs) Handles mnuTbDataView.Click
        mnuViewDataView.Checked = Not mnuViewDataView.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuTbOutput_Click(sender As Object, e As EventArgs) Handles mnuTbOutput.ButtonClick, mnuOutputWindow.Click
        mnuViewOutput.Checked = Not mnuViewOutput.Checked
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
        dlgBoxplot.enumBoxplotMode = dlgBoxplot.BoxplotMode.Prepare
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneVariableGraph.Click
        dlgOneVariableGraph.enumOnevariableMode = dlgOneVariableGraph.OnevariableMode.Prepare
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneVariableSummarise.Click
        dlgOneVariableSummarise.enumOnevariableMode = dlgOneVariableSummarise.OnevariableMode.Prepare
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataOneWayFrequencies_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataOneWayFrequencies.Click
        dlgOneWayFrequencies.enumOnewayMode = dlgOneWayFrequencies.OnewayMode.Prepare
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
        dlgRegularSequence.enumRegularsequenceMode = dlgRegularSequence.RegularsequenceMode.Prepare
        dlgRegularSequence.SetDateSequenceAsDefaultOption()
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuClimaticDatesGenerateDates_Click(sender As Object, e As EventArgs) Handles mnuClimaticDatesGenerateDates.Click
        dlgRegularSequence.enumRegularsequenceMode = dlgRegularSequence.RegularsequenceMode.Climatic
        dlgRegularSequence.SetDateSequenceAsDefaultOption()
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareEvapotranspiration_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareEvapotranspiration.Click
        dlgEvapotranspiration.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataCompareColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataCompareColumns.Click
        dlgCompareColumns.enumCompareMode = dlgCompareColumns.CompareMode.Prepare
        dlgCompareColumns.ShowDialog()
    End Sub

    Private Sub MergeAdditionalDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextMergeAdditionalData.Click
        dlgMergeAdditionalData.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextsCheckDataDuplicates_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCheckDataDuplicateRows.Click
        dlgDuplicateRows.ShowDialog()
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
        dlgFindNonnumericValues.enumNonNumericMode = dlgFindNonnumericValues.NonNumericMode.Prepare
        dlgFindNonnumericValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineNonNumericCases_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineNonNumericCases.Click
        dlgFindNonnumericValues.enumNonNumericMode = dlgFindNonnumericValues.NonNumericMode.Climatic
        dlgFindNonnumericValues.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineReplaceValues_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineReplaceValues.Click
        dlgReplaceValues.enumReplacevaluesMode = dlgReplaceValues.ReplacevaluesMode.Climatic
        dlgReplaceValues.ShowDialog()
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
        dlgMerge.enumMergeMode = dlgMerge.MergeMode.Climatic
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

    Private Sub mnuHelpGlossary_Click(sender As Object, e As EventArgs) Handles mnuHelpGlossary.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "92")
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
        dlgUnstack.enumUnstackMode = dlgUnstack.UnstackMode.Climatic
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineStack_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineStack.Click
        dlgStack.enumStackMode = dlgStack.StackMode.Climatic
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineAppend_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineAppend.Click
        dlgAppend.enumAppendMode = dlgAppend.AppendMode.Climatic
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareClimdex_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimdex.Click
        dlgClimdexIndices.ShowDialog()
    End Sub

    Private Sub mnuHelpWindows_Click(sender As Object, e As EventArgs) Handles mnuHelpWindows.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "539")
    End Sub

    Private Sub mnuClimaticTidyandExamineDuplicates_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineDuplicateRows.Click
        dlgDuplicateRows.enumDuplicateMode = dlgDuplicateRows.DuplicateMode.Climatic
        dlgDuplicateRows.ShowDialog()
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

    Private Sub MnuMetadata_ButtonClick(sender As Object, e As EventArgs) Handles mnuMetadata.ButtonClick
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        mnuColumnMetadat.Checked = mnuViewColumnMetadata.Checked
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

    Private Sub MnuLastGraph_ButtonClick(sender As Object, e As EventArgs) Handles mnuNormalViewer.Click, mnuLastGraph.ButtonClick
        Dim clsLastObjectRFunction As New RFunction
        clsLastObjectRFunction.SetRCommand(clsRLink.strInstatDataObject & "$get_last_object_data")
        clsLastObjectRFunction.AddParameter("object_type_label", Chr(34) & RObjectTypeLabel.Graph & Chr(34), iPosition:=0)
        clsLastObjectRFunction.AddParameter("as_file", strParameterValue:="FALSE", iPosition:=1)

        Dim clsViewObjectRFunction As New RFunction
        clsViewObjectRFunction.SetRCommand("view_object_data")
        clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsLastObjectRFunction)
        clsViewObjectRFunction.AddParameter("object_format", strParameterValue:=Chr(34) & RObjectFormat.Image & Chr(34))

        clsRLink.RunScript(clsViewObjectRFunction.ToScript(), strComment:="View last graph", bSeparateThread:=False)

    End Sub

    Private Sub Mnuploty_Click(sender As Object, e As EventArgs) Handles mnuploty.Click
        Dim clsViewObjectRFunction As New RFunction
        Dim clsPlotlyRFunction As New RFunction
        Dim clsLastObjectRFunction As New RFunction

        clsLastObjectRFunction.SetRCommand(clsRLink.strInstatDataObject & "$get_last_object_data")
        clsLastObjectRFunction.AddParameter("object_type_label", strParameterValue:=Chr(34) & RObjectTypeLabel.Graph & Chr(34), iPosition:=0)
        clsLastObjectRFunction.AddParameter("as_file", strParameterValue:="FALSE", iPosition:=1)

        clsPlotlyRFunction.SetPackageName("plotly")
        clsPlotlyRFunction.SetRCommand("ggplotly")
        clsPlotlyRFunction.AddParameter("p", clsRFunctionParameter:=clsLastObjectRFunction, iPosition:=0)

        clsViewObjectRFunction.SetRCommand("view_object_data")
        clsViewObjectRFunction.AddParameter("object", clsRFunctionParameter:=clsPlotlyRFunction)
        clsViewObjectRFunction.AddParameter("object_format", strParameterValue:=Chr(34) & RObjectFormat.Html & Chr(34))

        clsRLink.RunScript(clsViewObjectRFunction.ToScript(), strComment:="View last graph as plotly", bSeparateThread:=False)

    End Sub

    Private Sub MnuRViewer_Click(sender As Object, e As EventArgs) Handles mnuRViewer.Click
        Dim clsLastObjectRFunction As New RFunction
        Dim clsPrintRFunction As New RFunction
        clsLastObjectRFunction.SetRCommand(clsRLink.strInstatDataObject & "$get_last_object_data")
        clsLastObjectRFunction.AddParameter("object_type_label", strParameterValue:=Chr(34) & RObjectTypeLabel.Graph & Chr(34), iPosition:=0)
        clsLastObjectRFunction.AddParameter("as_file", strParameterValue:="FALSE", iPosition:=1)

        clsPrintRFunction.SetRCommand("print")
        clsPrintRFunction.AddParameter("x", clsRFunctionParameter:=clsLastObjectRFunction, iPosition:=0)

        clsRLink.RunScript(clsPrintRFunction.ToScript(), strComment:="View last graph in R viewer", bSeparateThread:=False)

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

    Private Sub mnuPrepareCheckDataVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataVisualiseData.Click
        dlgVisualizeData.enumVisualizeMode = dlgVisualizeData.VisualizeMode.Prepare
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
        dlgCorrelation.SetMultipleSequenceAsDefaultOption()
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

    Private Sub mnuStructuredCircularCalculator_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularCalculator.Click
        If dlgCalculator.bFirstLoad Then
            dlgCalculator.SetDefaultKeyboard("Circular")
        End If
        dlgCalculator.ShowDialog()
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

    Private Sub mnuViewSwapDataAndScript_Click(sender As Object, e As EventArgs) Handles mnuViewSwapDataAndScript.Click
        mnuViewSwapDataAndMetadata.Enabled = mnuViewSwapDataAndScript.Checked
        mnuViewSwapDataAndScript.Checked = Not mnuViewSwapDataAndScript.Checked
        UpdateSwapDataAndScript()
        UpdateLayout()
    End Sub

    Private Sub mnuViewSwapDataAndScript_CheckStateChanged(sender As Object, e As EventArgs) Handles mnuViewSwapDataAndScript.CheckStateChanged
        If Not mnuViewSwapDataAndScript.Checked AndAlso Not mnuViewDataView.Checked AndAlso mnuViewLogScript.Checked Then
            mnuViewLogScript.Checked = False
            mnuViewDataView.Checked = True
        End If
    End Sub

    Private Sub mnuViewSwapDataAndMetadata_Click(sender As Object, e As EventArgs) Handles mnuViewSwapDataAndMetadata.Click
        mnuViewSwapDataAndScript.Enabled = mnuViewSwapDataAndMetadata.Checked
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

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        If ctrActive.Equals(ucrDataViewer) Then
            ucrDataViewer.CopyRange()
        ElseIf ctrActive.Equals(ucrColumnMeta) Then
            ucrColumnMeta.CopyRange()
        ElseIf ctrActive.Equals(ucrDataFrameMeta) Then
            ucrDataFrameMeta.CopyRange()
        ElseIf ctrActive.Equals(ucrScriptWindow) Then
            ucrScriptWindow.CopyText()
        End If
    End Sub

    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        If ctrActive.Equals(ucrDataViewer) Then
            ucrDataViewer.PasteValuesToDataFrame()
        ElseIf ctrActive.Equals(ucrColumnMeta) Then
            'todo
        ElseIf ctrActive.Equals(ucrDataFrameMeta) Then
            'todo
        ElseIf ctrActive.Equals(ucrScriptWindow) Then
            ucrScriptWindow.PasteText()
        End If
    End Sub

    Private Sub mnuEditPasteNew_Click(sender As Object, e As EventArgs) Handles mnuEditPasteNew.Click
        dlgPasteNewColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFrameSelectColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameSelectColumns.Click
        dlgSelect.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileExportToClimsoft_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileExportToClimsoft.Click
        dlgExportToClimsoft.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileExportToClimpact_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileExportToClimpact.Click
        dlgExportForClimpact.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataReshapeScaleOrDistance_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataReshapeScaleOrDistance.Click
        dlgCluster.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableVisualiseData.Click
        dlgVisualizeData.enumVisualizeMode = dlgVisualizeData.VisualizeMode.Describe
        dlgVisualizeData.ShowDialog()
    End Sub

    Private Sub mnuModelFitModelMachineLearning_Click(sender As Object, e As EventArgs) Handles mnuModelFitModelMachineLearning.Click
        dlgMachineLearning.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateClusterAnalysis_Click(sender As Object, e As EventArgs) Handles mnuDescribeMultivariateClusterAnalysis.Click
        dlgClusterAnalysis.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextDefineOnStation_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextDefineOnStation.Click
        dlgColumnStructure.ShowDialog()
    End Sub

    Private Sub mnuOptionsByContextDefineOnFarm_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextDefineOnFarm.Click
        dlgDefineOptionsByContext.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoThreeVariablesCorrelations_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoThreeVariablesCorrelations.Click
        dlgCorrelation.mnuCurrent = mnuDescribeTwoThreeVariablesCorrelations
        dlgCorrelation.SetTwoVariableSequenceAsDefaultOption()
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoThreeVariablesThreeWayFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoThreeVariablesThreeWayFrequencies.Click
        dlgThreeVariableFrequencies.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoThreeVariablesPivotTableSummaries_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoThreeVariablesPivotTable.Click
        dlgThreeVariablePivotTable.enumPivotMode = dlgThreeVariablePivotTable.PivotMode.Describe
        dlgThreeVariablePivotTable.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFrameAddMergeColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameAddMergeColumns.Click
        dlgMergeAdditionalData.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataViewDeleteLabels_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataViewDeleteLabels.Click
        dlgViewFactorLabels.ShowDialog()
    End Sub

    Private Sub RandomSplitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataReshapeRandomSplit.Click
        dlgRandomSplit.ShowDialog()
    End Sub

    'Private Sub mnuOptionsByContextCropModel_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCropModel.Click
    '    dlgApsimx.ShowDialog()
    'End Sub

    Private Sub mnuOptionsByContextCropModelApsimxExamples_Click(sender As Object, e As EventArgs) Handles mnuOptionsByContextCropModelApsimxExamples.Click
        dlgApsimx.ShowDialog()

    End Sub

    Private Sub mnuFileImportFromRapidPro_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromRapidPro.Click
        dlgImportFromRapidPro.ShowDialog()
    End Sub

    Private Sub mnuFileImportFromPostgres_Click(sender As Object, e As EventArgs) Handles mnuFileImportFromPostgres.Click
        dlgImportFromPostgres.ShowDialog()
    End Sub

    Private Sub mnuEditWordwrap_Click(sender As Object, e As EventArgs) Handles mnuEditWordwrap.Click
        dlgWordwrap.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnTextSearch_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextSearch.Click
        dlgSearch.ShowDialog()
    End Sub

    Private Sub mnuHelpPackagesDocumentation_Click(sender As Object, e As EventArgs) Handles mnuHelpPackagesDocumentation.Click
        dlgHelpVignettes.ShowDialog()
    End Sub

    Private Sub mnuDescribeUseTable_Click(sender As Object, e As EventArgs) Handles mnuDescribeUseTable.Click
        dlgUseTable.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineTransformText_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineTransformText.Click
        dlgTransformText.enumTransformMode = dlgTransformText.TransformMode.Climatic
        dlgTransformText.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineSplitText_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineSplitText.Click
        dlgSplitText.enumSplitMode = dlgSplitText.SplitMode.Climatic
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataOneVariableSummarise.Click
        dlgOneVariableSummarise.enumOnevariableMode = dlgOneVariableSummarise.OnevariableMode.Climatic
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataOneVariableGraph.Click
        dlgOneVariableGraph.enumOnevariableMode = dlgOneVariableGraph.OnevariableMode.Climatic
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataOneVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataOneVariableFrequencies.Click
        dlgOneWayFrequencies.enumOnewayMode = dlgOneWayFrequencies.OnewayMode.Climatic
        dlgOneWayFrequencies.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataPivotTable_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataPivotTable.Click
        dlgThreeVariablePivotTable.enumPivotMode = dlgThreeVariablePivotTable.PivotMode.Climatic
        dlgThreeVariablePivotTable.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataSetupForDataEditing_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataSetupForDataEditing.Click
        dlgSetupForDataEntry.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataDailyDataEditing_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataDailyDataEditing.Click
        dlgClimaticDataEntry.ShowDialog()
    End Sub

    Private Sub mnuExamineEditDataCompareColumns_Click(sender As Object, e As EventArgs) Handles mnuExamineEditDataCompareColumns.Click
        dlgCompareColumns.enumCompareMode = dlgCompareColumns.CompareMode.Climatic
        dlgCompareColumns.ShowDialog()
    End Sub

    Private Sub mnuStructuredSurvey_Click(sender As Object, e As EventArgs) Handles mnuStructuredSurvey.Click
        dlgSurvey.ShowDialog()
    End Sub

    Private Sub mnuDescribeGraphGraphics_Click(sender As Object, e As EventArgs) Handles mnuDescribeGeneral.Click
        dlgGeneralForGraphics.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataPivotTable_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataPivotTable.Click
        dlgThreeVariablePivotTable.enumPivotMode = dlgThreeVariablePivotTable.PivotMode.Prepare
        dlgThreeVariablePivotTable.ShowDialog()
    End Sub

    Private Sub mnuToolsCheckForUpdates_Click(sender As Object, e As EventArgs) Handles mnuToolsCheckForUpdates.Click
        CheckForUpdates()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyDataKey.Click
        dlgAddKey.enumAddkeyMode = dlgAddKey.AddkeyMode.Climatic
        dlgAddKey.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeSummarise23Variables_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeSummarise23Variables.Click
        dlgDescribeTwoVariable.enumTwovariableMode = dlgDescribeTwoVariable.TwovariableMode.Climatic
        dlgDescribeTwoVariable.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeGraph23Variables_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeGraph23Variables.Click
        dlgDescribeTwoVarGraph.enumTwovarMode = dlgDescribeTwoVarGraph.TwovarMode.Climatic
        dlgDescribeTwoVarGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeSPISPEI_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeSPISPEI.Click
        dlgSPI.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularWindRose_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularWindPollutionRose_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularWindPollutionRose.Click
        dlgWindPollutionRose.ShowDialog()
    End Sub

    Private Sub mnuStructuredCircularOtherRosePlots_Click(sender As Object, e As EventArgs) Handles mnuStructuredCircularOtherRosePlots.Click
        dlgOtherRosePlots.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeWindRose_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeWindPollutionRose_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeWindPollutionRose.Click
        dlgWindPollutionRose.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeOtherRosePlots_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeOtherRosePlots.Click
        dlgOtherRosePlots.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeTrendGraph_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeTrendGraph.Click
        dlgPICSARainfall.enumPICSAMode = dlgPICSARainfall.PICSAMode.General
        dlgPICSARainfall.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeSeasonalGraph_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeSeasonalGraph.Click
        dlgSeasonalGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeIDF_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeIDF.Click
        dlgIDFCurves.ShowDialog()
    End Sub

    Private Sub mnuClimaticExamineEditDataVisualiseData_Click(sender As Object, e As EventArgs) Handles mnuClimaticExamineEditDataVisualiseData.Click
        dlgVisualizeData.enumVisualizeMode = dlgVisualizeData.VisualizeMode.Climatic
        dlgVisualizeData.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSAGeneralGrap_Click(sender As Object, e As EventArgs) Handles mnuClimaticPICSAGeneralGrap.Click
        dlgPICSARainfall.enumPICSAMode = dlgPICSARainfall.PICSAMode.General
        dlgPICSARainfall.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeClimograph_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeClimograph.Click
        dlgClimograph.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileExportToGoogleBucketsToolStrip_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileExportToGoogleBucketsToolStrip.Click
        dlgExportClimaticDefinitions.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "13")
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "7")
    End Sub

    Private Sub PrepareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepareToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "9")
    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "18")
    End Sub

    Private Sub ModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "17")
    End Sub

    Private Sub StructuredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StructuredToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "454")
    End Sub

    Private Sub ClimaticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClimaticToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "19")
    End Sub

    Private Sub ProcurementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcurementToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "498")
    End Sub

    Private Sub ExperimentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExperimentsToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "570")
    End Sub

    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "8")
    End Sub

    Private Sub ViewToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "21")
    End Sub

    Private Sub MenusAndDialogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenusAndDialogsToolStripMenuItem.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "12")
    End Sub
End Class
