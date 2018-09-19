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
    Public clsRLink As New RLink
    Public clsGrids As New clsGridLink
    Public strStaticPath As String
    Public strHelpFilePath As String = "Help\R-Instat.chm"
    Public strAppDataPath As String
    Public strInstatOptionsFile As String = "Options.bin"
    Public clsInstatOptions As InstatOptions
    Public clsRecentItems As New clsRecentFiles
    Public strCurrentDataFrame As String
    Public dlgLastDialog As Form
    Public strSaveFilePath As String = ""
    Private mnuItems As New List(Of Form)
    Private ctrActive As Control
    Private WithEvents timer As New System.Windows.Forms.Timer
    Private iAutoSaveDataMilliseconds As Integer

    Public strAutoSaveDataFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_data_auto_save")
    Public strAutoSaveLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_log_auto_save")
    Public strAutoSaveInternalLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_debug_log_auto_save")

    Public strCurrentAutoSaveDataFilePath As String = ""

    'This is the default data frame to appear in the data frame selector
    'If "" the current worksheet will be used
    'TODO This should be an option in the Options dialog
    '     User can choose a default data frame or set the default as the current worksheet
    Public strDefaultDataFrame As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs)

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

        InitialiseOutputWindow()
        clsGrids.SetDataViewer(ucrDataViewer)
        clsGrids.SetMetadata(ucrDataFrameMeta.grdMetaData)
        clsGrids.SetVariablesMetadata(ucrColumnMeta.grdVariables)

        clsRLink.SetLog(ucrLogWindow.txtLog)

        SetToDefaultLayout()
        strStaticPath = Path.GetFullPath("static")
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
            clsRecentItems.setToolStripItems(mnuFile, mnuTbOpen, mnuTbLast10Dialogs, sepStart, sepEnd)
            'checks existence of MRU list
            clsRecentItems.checkOnLoad()
            Cursor = Cursors.Default
            SetMainMenusEnabled(True)

            mnuViewClimaticMenu.Checked = clsInstatOptions.bShowClimaticMenu
            mnuViewProcurementMenu.Checked = clsInstatOptions.bShowProcurementMenu
        End If
    End Sub

    ' TODO This is used instead of autoTranslate so that split container isn't shifted
    ' Need to fix this so that all of frmMain can be translated
    Public Sub TranslateFrmMainMenu()
        translateMenu(mnuBar.Items, Me)
    End Sub
    Private Sub SetMainMenusEnabled(bEnabled As Boolean)
        mnuFile.Enabled = bEnabled
        mnuEdit.Enabled = bEnabled
        mnuPrepare.Enabled = bEnabled
        mnuDescribe.Enabled = bEnabled
        mnuModel.Enabled = bEnabled
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

    Private Sub InitialiseOutputWindow()
        clsRLink.SetOutput(ucrOutput.ucrRichTextBox)
        'TEST temporary : creating the temporary graphs 
        clsRLink.rtbOutput.CreateTempDirectory()
    End Sub

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

        mnuTbDataView.Checked = True
        mnuTbOutput.Checked = True
        mnuTbColumnMetadata.Checked = False
        mnuTbLog.Checked = False

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

    Private Sub mnuFileNewDataFrame_Click(sender As Object, e As EventArgs)
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub RegularSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgRegularSequence.bNumericIsDefault = True
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuCalculations_Click(sender As Object, e As EventArgs)
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRowSummary_Click(sender As Object, e As EventArgs)
        dlgRowSummary.ShowDialog()
    End Sub

    Private Sub FrequencyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgFrequency.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnTransform_Click(sender As Object, e As EventArgs)
        dlgTransform.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnPolynomials_Click(sender As Object, e As EventArgs)
        dlgPolynomials.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeStack_Click(sender As Object, e As EventArgs)
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeUnstack_Click(sender As Object, e As EventArgs)
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRecode_Click(sender As Object, e As EventArgs)
        dlgRecodeNumeric.ShowDialog()
    End Sub

    Private Sub RandomSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgView.ShowDialog()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgRestrict.bIsSubsetDialog = True
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuModelThreeVariablesFitModel_Click(sender As Object, e As EventArgs)
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    'Private Sub mnuStatsNonParametricTwoWayAnova_Click_1(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Click
    '    dlgNon_ParametricTwoWayAnova.ShowDialog()
    'End Sub

    Private Sub ImportDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShiftDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgShiftDailyData.ShowDialog()
    End Sub

    Private Sub StackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgStackDailyData.ShowDialog()
    End Sub
    Private Sub mnuClimaticExamine_Click(sender As Object, e As EventArgs)
        dlgExamine.ShowDialog()
    End Sub

    Private Sub mnuClimaticEvaporationSite_Click(sender As Object, e As EventArgs)
        dlgSite.ShowDialog()
    End Sub

    Private Sub mnuFIleExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub mnuFileOpenFromFile_Click(sender As Object, e As EventArgs)
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub mnuFileOpenFromLibrary_Click(sender As Object, e As EventArgs)
        dlgFromLibrary.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataRename_Click(sender As Object, e As EventArgs)
        dlgName.ShowDialog()
    End Sub

    Private Sub UpdateLayout()
        If Not mnuViewDataView.Checked AndAlso Not mnuViewOutputWindow.Checked AndAlso Not mnuViewColumnMetadata.Checked AndAlso Not mnuViewDataFrameMetadata.Checked AndAlso Not mnuViewLog.Checked AndAlso Not mnuViewScriptWindow.Checked Then
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
        mnuTbColumnMetadata.Checked = mnuViewColumnMetadata.Checked
        mnuTbLog.Checked = mnuViewLog.Checked
    End Sub

    Private Sub mnuWindowVariable_Click(sender As Object, e As EventArgs)
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs)
        mnuViewDataFrameMetadata.Checked = Not mnuViewDataFrameMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mnuViewLog.Checked = Not mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mnuViewScriptWindow.Checked = Not mnuViewScriptWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareReshapeMerge_Click(sender As Object, e As EventArgs)
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuWindowsEditor_Click(sender As Object, e As EventArgs)
        mnuViewDataView.Checked = Not mnuViewDataView.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs)
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuFilePrintPreview_Click(sender As Object, e As EventArgs)
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRank_Click(sender As Object, e As EventArgs)
        dlgRank.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsCreateClimateObject_Click(sender As Object, e As EventArgs)
        dlgCreateClimateObject.ShowDialog()
    End Sub

    'Private Sub mnuExport_Click(sender As Object, e As EventArgs) Handles mnuExport.Click
    '    dlgExportDataset.ShowDialog()
    'End Sub

    Private Sub mnuPrepareDataFileSheetMetadata_Click(sender As Object, e As EventArgs)
        dlgDataFrameMetaData.ShowDialog()
    End Sub

    Private Sub mnuPrepareSheetColumnMetadata_Click(sender As Object, e As EventArgs)
        mnuViewColumnMetadata.Checked = True
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareSheetInsertColumnsRows_Click(sender As Object, e As EventArgs)
        dlgInsertColumn.ShowDialog()
    End Sub

    Private Sub mnuGraphicsBarPie_Click(sender As Object, e As EventArgs)
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnPermuteRows_Click(sender As Object, e As EventArgs)
        dlgPermuteColumn.ShowDialog()
    End Sub
    Private Sub mnuPrepareDataFileDeleteSheets_Click(sender As Object, e As EventArgs)
        dlgDeleteDataFrames.ShowDialog()
    End Sub


    Private Sub mnuPrepareSheetDeleteColumnsRows_Click(sender As Object, e As EventArgs)
        dlgDeleteRowsOrColums.ShowDialog()
    End Sub

    Private Sub EditLastDialogueToolStrip_Click(sender As Object, e As EventArgs)
        If clsRecentItems.mnuItems.Count > 0 Then
            clsRecentItems.mnuItems.Last.ShowDialog()
        End If
    End Sub

    Private Sub mnuTbSave_Click(sender As Object, e As EventArgs)
        mnuFileSave_Click(sender, e)
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs)
        Dim clsSaveRDS As New RFunction

        If strSaveFilePath = "" Then
            dlgSaveAs.ShowDialog()
        Else
            clsSaveRDS.SetRCommand("saveRDS")
            clsSaveRDS.AddParameter("object", clsRLink.strInstatDataObject)
            clsSaveRDS.AddParameter("file", Chr(34) & Replace(strSaveFilePath, "\", "/") & Chr(34))
            clsRLink.RunScript(clsSaveRDS.ToScript(), strComment:="File > Save: save file")
        End If
    End Sub

    Private Sub mnuTbCopy_Click(sender As Object, e As EventArgs)
        mnuEditCopy_Click(sender, e)
    End Sub

    Private Sub mnuHelpHelp_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TableOfContents, "")
    End Sub

    Private Sub mnuTbHelp_Click(sender As Object, e As EventArgs)
        mnuHelpHelp_Click(sender, e)
    End Sub

    Private Sub mnuPrepareFactorRecode_Click(sender As Object, e As EventArgs)
        dlgRecodeFactor.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileCopySheet_Click(sender As Object, e As EventArgs)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileReorderSheets_Click(sender As Object, e As EventArgs)
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFileRenameSheet_Click(sender As Object, e As EventArgs)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareRechapeColumnSummaries_Click(sender As Object, e As EventArgs)
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuPrepareSheetReorder_Click(sender As Object, e As EventArgs)
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorReferenceLevels_Click(sender As Object, e As EventArgs)
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorLabel_Click(sender As Object, e As EventArgs)
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorViewLabels_Click(sender As Object, e As EventArgs)
        dlgViewFactorLabels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorConvertToFactor_Click(sender As Object, e As EventArgs)
        dlgConvertColumns.bToFactorOnly = True
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorReorderLevels_Click(sender As Object, e As EventArgs)
        dlgReorderLevels.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorUnusedLevels_Click(sender As Object, e As EventArgs)
        dlgRemoveUnusedLevels.ShowDialog()
    End Sub
    Private Sub mnuPrepareDataSort_Click(sender As Object, e As EventArgs)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuPrepareViewObjects_Click(sender As Object, e As EventArgs)
        dlgViewObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareReorderObjects_Click(sender As Object, e As EventArgs)
        dlgReorderObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareRenameObjects_Click(sender As Object, e As EventArgs)
        dlgRenameObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareDeleteObjects_Click(sender As Object, e As EventArgs)
        dlgDeleteObjects.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorContrasts_Click(sender As Object, e As EventArgs)
        dlgContrasts.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorSheet_Click(sender As Object, e As EventArgs)
        dlgFactorDataFrame.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextSplit_Click(sender As Object, e As EventArgs)
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextCombine_Click(sender As Object, e As EventArgs)
        dlgCombineText.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFilter_Click(sender As Object, e As EventArgs)
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = ""
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataConvertTo_Click(sender As Object, e As EventArgs)
        dlgConvertColumns.bToFactorOnly = False
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareReshapeTranspose_Click(sender As Object, e As EventArgs)
        dlgTransposeColumns.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorCombine_Click(sender As Object, e As EventArgs)
        dlgCombine.ShowDialog()
    End Sub

    Private Sub mnuPrepareFactorDummyVariable_Click(sender As Object, e As EventArgs)
        dlgDummyVariables.ShowDialog()
    End Sub

    'Private Sub mnuStatisticsAnalysisOfVarianceGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralANOVAGeneral.Click
    '    dlgGeneralANOVA.ShowDialog()
    'End Sub

    'Private Sub mnuStatisticsRegressionGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralRegression.Click
    '    dlgGeneralRegression.ShowDialog()
    'End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgGeneralForGraphics.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextTransform_Click(sender As Object, e As EventArgs)
        dlgTransformText.ShowDialog()
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs)
        If ctrActive IsNot Nothing Then
            If ctrActive.Equals(ucrDataViewer) Then
                ucrDataViewer.SelectAllText()
            ElseIf ctrActive.Equals(ucrOutput) Then
                ucrOutput.SelectAllText()
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

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs)
        If ctrActive.Equals(ucrDataViewer) Then
            ucrDataViewer.CopyRange()
        ElseIf ctrActive.Equals(ucrOutput) Then
            ucrOutput.CopyContent()
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

    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs)
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameHideColumns_Click(sender As Object, e As EventArgs)
        dlgHideShowColumns.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsRandomSamplesUseModel_Click(sender As Object, e As EventArgs)
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub mnuModelTwoVariablesFitModel_Click(sender As Object, e As EventArgs)
        dlgTwoVariableFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableExactResults_Click(sender As Object, e As EventArgs)
        dlgOneSample.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableNonParametric_Click(sender As Object, e As EventArgs)
        dlgNon_ParametricOneSampleTests.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesSimpleRegression_Click(sender As Object, e As EventArgs)
        dlgTwoVariableFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesOneWayANOVA_Click(sender As Object, e As EventArgs)
        dlgOneWayANOVA.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesNonParametricTwoSamples_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuModelOtherTwoVariablesNonParametricOneWayANOVA_Click(sender As Object, e As EventArgs)
        dlgNon_ParametricOneWayANOVA.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesSimpleWithGroups_Click(sender As Object, e As EventArgs)
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesNonParametricTwoWayANOVA_Click(sender As Object, e As EventArgs)
        dlgNon_ParametricTwoWayAnova.ShowDialog()
    End Sub

    Private Sub mnuModelOtherThreeVariablesChisquareTest_Click(sender As Object, e As EventArgs)
        dlgChiSquareTest.ShowDialog()
    End Sub

    Private Sub mnuModelOtherGeneralANOVAGeneral_Click(sender As Object, e As EventArgs)
        dlgGeneralANOVA.ShowDialog()
    End Sub

    Private Sub OutputWindowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        mnuViewOutputWindow.Checked = Not mnuViewOutputWindow.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuOrganiseColumnReshapeRandomSubset_Click(sender As Object, e As EventArgs)
        dlgRandomSubsets.ShowDialog()
    End Sub

    Private Sub mnuToolsClearOutputWindow_Click(sender As Object, e As EventArgs)
        Dim rstResponse As DialogResult
        rstResponse = MessageBox.Show("Are you sure you want to clear the Output Window?", "Clear Output Window", MessageBoxButtons.YesNo)
        If rstResponse = DialogResult.Yes Then
            ucrOutput.ucrRichTextBox.rtbOutput.Document.Blocks.Clear() 'To b checked
        End If
    End Sub

    Private Sub mnuOrganiseDataObjectDeleteMetadata_Click(sender As Object, e As EventArgs)
        dlgDeleteMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectMetadata_Click(sender As Object, e As EventArgs)
        'TODO Change this dialog
        '     currently dlgMetadata is colouring grid dialog
        dlgMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectReorderMetadata_Click(sender As Object, e As EventArgs)
        dlgReorderMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectRenameMetadata_Click(sender As Object, e As EventArgs)
        dlgRenameMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameRowNumbersNames_Click(sender As Object, e As EventArgs)
        dlgRowNamesOrNumbers.ShowDialog()
    End Sub

    Private Sub JitterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgJitter.ShowDialog()
    End Sub

    Private Sub mnuModelFourVariablesFitModel_Click(sender As Object, e As EventArgs)
        dlgFourVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuEditFind_Click(sender As Object, e As EventArgs)
        dlgFind.currWindow = ActiveMdiChild
        dlgFind.Owner = Me
        dlgFind.Show()
    End Sub

    Private Sub mnuEditFindNext_Click(sender As Object, e As EventArgs)
        mnuEditFind_Click(sender, e)
    End Sub

    Private Sub ColourByPropertyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'TODO change this dialog
        '     dlgMetadata should be separate
        dlgColourbyProperty.ShowDialog()
    End Sub

    Private Sub mnuViewCascade_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuViewTileVertically_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuViewTileHorizontally_Click(sender As Object, e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuOrganiseColumnTextFindReplace_Click(sender As Object, e As EventArgs)
        dlgStringHandling.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableSummarise_Click(sender As Object, e As EventArgs)
        dlgOneVariableSummarise.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableGraph_Click(sender As Object, e As EventArgs)
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs)
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
                    clsRecentItems.saveOnClose()
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

    Private Sub mnuOrganiseDataObjectHideDataframes_Click(sender As Object, e As EventArgs)
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameReplaceValues_Click(sender As Object, e As EventArgs)
        dlgReplaceValues.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesSummarise_Click(sender As Object, e As EventArgs)
        dlgDescribeTwoVariable.ShowDialog()
    End Sub

    Private Sub mnuAppendDataFrame_Click(sender As Object, e As EventArgs)
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsOutputAs_Click(sender As Object, e As EventArgs)
        'Saves the content of the output window in RichTextFormat.
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output Window"
            dlgSaveFile.Filter = "Rich Text Format (*.rtf)|*.rtf"
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    'Send file name string specifying the location to save the rtf in.
                    ucrOutput.ucrRichTextBox.SaveRtf(dlgSaveFile.FileName)
                Catch
                    MsgBox("Could not save the output window." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuFileSaveAsLogAs_Click(sender As Object, e As EventArgs)
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Log Window"
            dlgSaveFile.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, ucrLogWindow.txtLog.Text)
                Catch
                    MsgBox("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuFileSaveAsScriptAs_Click(sender As Object, e As EventArgs)
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Script Window"
            dlgSaveFile.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, ucrScriptWindow.txtScript.Text)
                Catch
                    MsgBox("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuOrganiseDataFrameColumnStructure_Click(sender As Object, e As EventArgs)
        dlgColumnStructure.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesGraph_Click(sender As Object, e As EventArgs)
        dlgDescribeTwoVarGraph.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileOpensst_Click(sender As Object, e As EventArgs)
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub mnuModelGeneralFitModel_Click(sender As Object, e As EventArgs)
        dlgFitModel.ShowDialog()
    End Sub

    Private Sub mnuImportFromOpenDataKit_Click(sender As Object, e As EventArgs)
        dlgImportFromODK.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableFitModel_Click(sender As Object, e As EventArgs)
        dlgOneVarFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelTwoVariablesUseModel_Click(sender As Object, e As EventArgs)
        dlgTwoVariableUseModel.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnGenerateEnter_Click(sender As Object, e As EventArgs)
        dlgEnter.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableCompareModels_Click(sender As Object, e As EventArgs)
        dlgOneVarCompareModels.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableUseModel_Click(sender As Object, e As EventArgs)
        dlgOneVarUseModel.ShowDialog()
    End Sub

    Private Sub TablesPlusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgShowModel.ShowDialog()
    End Sub

    Private Sub mnuDescribeUseGraph_Click(sender As Object, e As EventArgs)
        dlgUseGraph.ShowDialog()
    End Sub

    Private Sub mnuDescribeCombineGraph_Click(sender As Object, e As EventArgs)
        dlgCombineforGraphics.ShowDialog()
    End Sub

    Private Sub mnuDescribeThemes_Click(sender As Object, e As EventArgs)
        dlgThemes.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateCorrelations_Click(sender As Object, e As EventArgs)
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateprincipalComponents_Click(sender As Object, e As EventArgs)
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuDescribeMultivariateCanonicalCorrelations_Click(sender As Object, e As EventArgs)
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub
    Private Sub mnuClimaticOrganiseSummary_Click(sender As Object, e As EventArgs)
        dlgSummary.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsStartoftheRains_Click(sender As Object, e As EventArgs)
        dlgStartofRains.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsSpells_Click(sender As Object, e As EventArgs)
        dlgSpells.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsWaterBalance_Click(sender As Object, e As EventArgs)
        dlgEndOfRainsSeason.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnGenerateCountInFactor_Click(sender As Object, e As EventArgs)
        dlgCountinFactor.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificScatterPlot_Click(sender As Object, e As EventArgs)
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificLinePlot_Click(sender As Object, e As EventArgs)
        dlgLinePlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificHistogram_Click(sender As Object, e As EventArgs)
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBoxplot_Click(sender As Object, e As EventArgs)
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificDotPlot_Click(sender As Object, e As EventArgs)
        dlgDotPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificRugPlot_Click(sender As Object, e As EventArgs)
        dlgRugPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBarChart_Click(sender As Object, e As EventArgs)
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnMakeDate_Click(sender As Object, e As EventArgs)
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimdex_Click(sender As Object, e As EventArgs)
        dlgClimdexIndices.ShowDialog()
    End Sub

    Private Sub mnuDescribeOtherGraphicsDialogsWindRose_Click(sender As Object, e As EventArgs)
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataExportOpenRefine_Click(sender As Object, e As EventArgs)
        dlgExportToOpenRefine.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataImportOpenRefine_Click(sender As Object, e As EventArgs)
        dlgImportOpenRefine.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsDataAs_Click(sender As Object, e As EventArgs)
        dlgSaveAs.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsCompareModels_Click(sender As Object, e As EventArgs)
        dlgCompareModels.ShowDialog()
    End Sub

    Private Sub mnuDescribeGeneralColumnSummaries_Click(sender As Object, e As EventArgs)
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnUseDate_Click(sender As Object, e As EventArgs)
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuHelpMenusAndDialogues_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "12")
    End Sub

    Private Sub mnuHelpRPackagesAndCommands_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "26")
    End Sub
    Private Sub mnuHelpHelpIntroduction_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "0")
    End Sub

    Private Sub mnuHelpHistFAQ_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "290")
    End Sub

    Private Sub mnuHelpGetingStarted_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "3")
    End Sub

    Private Sub mnuHelpSpreadsheet_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "134")
    End Sub

    Private Sub mnuHelpDataset_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "71")
    End Sub

    Private Sub mnuHelpRPackagesCommands_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "26")
    End Sub

    Private Sub mnuHelpR_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "133")
    End Sub

    Private Sub mnuHelpMenus_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "12")
    End Sub


    Private Sub mnuHelpGuidesCaseStudy_Click(sender As Object, e As EventArgs)
        Process.Start(Path.Combine(strStaticPath, "Help", "Case_Study_Guide_June_2016.pdf"))
    End Sub

    Private Sub mnuHelpGuideGlosary_Click(sender As Object, e As EventArgs)
        Process.Start(Path.Combine(strStaticPath, "Help", "Statistics Glossary.pdf"))
    End Sub

    Private Sub mnuHelpLicence_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "323")
    End Sub

    Private Sub mnuClimaticFileExportToCPT_Click(sender As Object, e As EventArgs)
        dlgExportToCPT.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeMoreGraphsCummulaiveDistribution_Click(sender As Object, e As EventArgs)
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportExporttoCPT_Click(sender As Object, e As EventArgs)
        dlgExportToCPT.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportOpenSST_Click(sender As Object, e As EventArgs)
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub mnuOrgCalculateDuplicateColumn_Click(sender As Object, e As EventArgs)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuCorruptionFile_Click(sender As Object, e As EventArgs)
        dlgCorruptionFile.ShowDialog()
    End Sub

    Private Sub GeneralSummariesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgCalculationsSummary.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksViewAndRemoveKey_Click(sender As Object, e As EventArgs)
        dlgViewAndRemoveKeys.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksAddLink_Click(sender As Object, e As EventArgs)
        dlgAddLink.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksViewAndRemoveKeys_Click(sender As Object, e As EventArgs)
        dlgViewAndRemoveLinks.ShowDialog()
    End Sub

    Private Sub mnuOrganiseKeysAndLinksAddComment_Click(sender As Object, e As EventArgs)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuClimaticMarkovModelling_Click(sender As Object, e As EventArgs)
        dlgNewMarkovChains.ShowDialog()
    End Sub

    Private Sub mnuClimaticDefineClimaticData_Click(sender As Object, e As EventArgs)
        DlgDefineClimaticData.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataInventory_Click(sender As Object, e As EventArgs)
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateFileClimSoft_Click(sender As Object, e As EventArgs)
        dlgClimSoft.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileCliData_Click(sender As Object, e As EventArgs)
        dlgCliData.ShowDialog()
    End Sub

    Private Sub mnuPrepareKeysAndLinksAddKey_Click(sender As Object, e As EventArgs)
        dlgAddKey.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesMakeDate_Click(sender As Object, e As EventArgs)
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareDatesUseDate_Click(sender As Object, e As EventArgs)
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareInfillMissingDates_Click(sender As Object, e As EventArgs)
        dlgInfill.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeTemperatures_Click(sender As Object, e As EventArgs)
        dlgTemperature.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeSunshineRadiation_Click(sender As Object, e As EventArgs)
        dlgSunshine.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSARainfall_Click(sender As Object, e As EventArgs)
        dlgPICSARainfall.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSATemperature_Click(sender As Object, e As EventArgs)
        dlgPICSATemperature.ShowDialog()
    End Sub

    Private Sub mnuClimaticPICSACrops_Click(sender As Object, e As EventArgs)
        dlgPICSACrops.ShowDialog()
    End Sub

    Private Sub mnuCimaticPrepareTransform_Click(sender As Object, e As EventArgs)
        dlgTransformClimatic.ShowDialog()
    End Sub

    Private Sub mnuClimaticModelsExtremes_Click(sender As Object, e As EventArgs)
        dlgExtremes.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCorrelations_Click(sender As Object, e As EventArgs)
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportPrincipalComponents_Click(sender As Object, e As EventArgs)
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCanonicalCorrelations_Click(sender As Object, e As EventArgs)
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineData_Click(sender As Object, e As EventArgs)
        dlgDefineCorruption.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportCumulativeExceedanceGraphs_Click(sender As Object, e As EventArgs)
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareFilterByCountry_Click(sender As Object, e As EventArgs)
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

    Private Sub mnuProcurementModelFitModelToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgFitCorruptionModel.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineRedFlags_Click(sender As Object, e As EventArgs)
        dlgDefineRedFlags.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesFrequencies_Click(sender As Object, e As EventArgs)
        dlgTwoWayFrequencies.ShowDialog()
    End Sub

    Private Sub ImportFromCSPROToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgImportFromCSPRO.ShowDialog()
    End Sub

    Private Sub ImportFromToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgImportFromDatabases.ShowDialog()
    End Sub

    Private Sub OpenNetCDFToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgOpenNetCDF.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineCorruption_Click(sender As Object, e As EventArgs)
        dlgDefineCorruptionOutputs.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareSetFactorReferenceLevel_Click(sender As Object, e As EventArgs)
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgReferenceLevel.strDefaultDataFrame = lstDataNames(0)
        End If
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareDefineContractValueCategories_Click(sender As Object, e As EventArgs)
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

    Private Sub mnuProcurementPrepareMergeAdditionalData_Click(sender As Object, e As EventArgs)
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareUseAwardDate_Click(sender As Object, e As EventArgs)
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

    Private Sub mnuDescribeOneVariableFrequencies_Click(sender As Object, e As EventArgs)
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

    Private Sub mnuProcurementPrepareRecodeNumericIntoQuantiles_Click(sender As Object, e As EventArgs)
        dlgRecodeNumericIntoQuantiles.ShowDialog()
    End Sub

    Private Sub mnuViewResetToDefaultLayout_Click(sender As Object, e As EventArgs)
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

    Private Sub mnuClimaticFileImportGriddedData_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportGriddedData.Click
        dlgImportGriddedData.ShowDialog()
    End Sub

    Private Sub RatingDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RatingDataToolStripMenuItem.Click
        dlgRatingScales.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnTextDistance_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextDistance.Click
        dlgStringDistance.ShowDialog()
    End Sub

    Private Sub mnuDescribeOtherGraphicsDialogsInventoryPlot_Click(sender As Object, e As EventArgs)
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeThreeVariableFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeThreeVariableFrequencies.Click
        dlgThreeVariableFrequencies.ShowDialog()
    End Sub

    Private Sub ExportGraphToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgExportGraphAsImage.ShowDialog()
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

    Private Sub ExportRWorkspaceToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        dlgExportRWorkspace.ShowDialog()
    End Sub

    Private Sub ExportDataSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportDataSetToolStripMenuItem.Click
        dlgExportDataset.ShowDialog()
    End Sub

    Private Sub ExportRWorkspaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportRWorkspaceToolStripMenuItem.Click
        dlgExportRWorkspace.ShowDialog()
    End Sub

    Private Sub ExportGraphAsImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportGraphAsImageToolStripMenuItem.Click
        dlgExportGraphAsImage.ShowDialog()
    End Sub

    Private Sub ExportRObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportRObjectsToolStripMenuItem.Click
        dlgExportRObjects.ShowDialog()
    End Sub

    Private Sub FrequencyTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrequencyTablesToolStripMenuItem.Click
        dlgSummaryBarOrPieChart.ShowDialog()
    End Sub
    Private Sub mnuClimaticPrepareClimaticSummaries_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimaticSummaries.Click
        dlgClimaticSummary.ShowDialog()
    End Sub

    Public Function GetDataFrameCount() As Integer
        If ucrDataViewer IsNot Nothing AndAlso ucrDataViewer.grdData IsNot Nothing Then
            Return ucrDataViewer.grdData.Worksheets.Count
        Else
            Return 0
        End If
    End Function

    Public Sub SetCurrentDataFrame(strDataName As String)
        ucrDataViewer.SetCurrentDataFrame(strDataName)
        ucrColumnMeta.SetCurrentDataFrame(strDataName)
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        ucrDataViewer.SetCurrentDataFrame(iIndex)
        ucrColumnMeta.SetCurrentDataFrame(iIndex)
    End Sub

    Private Sub WindroseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub CummulativeDistributionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CummulativeDistributionToolStripMenuItem.Click
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

    Private Sub mnuProcurementDescribeOneVar_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeOneVar.Click
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

    Private Sub mnuProcurementDescribeTwoVar_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeTwoVar.Click
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
        Dim bClose As DialogResult

        bClose = MsgBox("Are you sure you want to close you data?" & Environment.NewLine & "Any unsaved changes will be lost.", MessageBoxButtons.YesNo, "Close Data")
        If bClose = DialogResult.Yes Then
            clsRLink.CloseData()
            strSaveFilePath = ""
        End If
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

    Private Sub mnuPrepareColumnInfillMissingDates_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnInfillMissingDates.Click
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

    Private Sub mnuTbColumnMetadata_Click(sender As Object, e As EventArgs) Handles mnuTbColumnMetadata.Click
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuTbLog_Click(sender As Object, e As EventArgs) Handles mnuTbLog.Click
        mnuViewLog.Checked = Not mnuViewLog.Checked
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

    Public Sub SetShowClimaticMenu(bNewShowClimaticMenu As Boolean)
        mnuClimatic.Visible = bNewShowClimaticMenu
        mnuViewClimaticMenu.Checked = bNewShowClimaticMenu
    End Sub

    Public Sub SetShowOptionsByContextMenu(bNewShowOptionsByContextMenu As Boolean)
        mnuOptionsByContext.Visible = bNewShowOptionsByContextMenu
        mnuViewOptionsByContextMenu.Checked = bNewShowOptionsByContextMenu
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

    Private Sub SummariseRedFlagsByCountryorOtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummariseRedFlagsByCountryorOtherToolStripMenuItem.Click
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

    Private Sub mnuProcurementCalculateCRI_Click(sender As Object, e As EventArgs) Handles mnuProcurementCalculateCRI.Click
        dlgDefineCRI.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineCorruption_Click_1(sender As Object, e As EventArgs) Handles mnuProcurementDefineCorruption.Click
        dlgDefineCorruptionOutputs.ShowDialog()
    End Sub

    Private Sub SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummariseRedFlagsByCountryAndYearorOtherToolStripMenuItem.Click
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

    Private Sub OneVariableSummariseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneVariableSummariseToolStripMenuItem.Click
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

    Private Sub OneVariableGraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneVariableGraphToolStripMenuItem.Click
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

    Private Sub CorrelationsRedFlagsOrOthersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorrelationsRedFlagsOrOthersToolStripMenuItem.Click
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

    Private Sub MapCountryValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MapCountryValuesToolStripMenuItem.Click
        dlgCountryColouredMap.ShowDialog()
    End Sub

    Private Sub OpenNETcdfFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNETcdfFileToolStripMenuItem.Click
        dlgOpenNetCDF.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataQCRainfall_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataQCRainfall.Click
        dlgClimaticCheckDataRain.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataQCTemperatures_Click(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataQCTemperatures.Click
        dlgClimaticCheckDataTemperature.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificParallelCoordinatePlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificParallelCoordinatePlot.Click
        dlgParallelCoordinatePlot.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnCalculateColumnSummaries_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateColumnSummaries.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnCalculateGeneralSummaries_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateGeneralSummaries.Click
        dlgCalculationsSummary.ShowDialog()
    End Sub

    Private Sub mnuModelHypothesisTests_Click(sender As Object, e As EventArgs) Handles mnuModelHypothesisTests.Click
        dlgHypothesisTestsCalculator.ShowDialog()
    End Sub

    Private Sub mnuPrepareColumnGenerateDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGenerateDate.Click
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

    Private Sub mnuClimaticSPI_Click(sender As Object, e As EventArgs) Handles mnuClimaticSPI.Click
        dlgSPI.ShowDialog()
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

    Private Sub mnuClimaticPrepareCompare_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareCompare.Click
        dlgCompare.ShowDialog()
    End Sub

    Private Sub mnuPrepareCheckDataAnonymiseIDColumn_Click(sender As Object, e As EventArgs) Handles mnuPrepareCheckDataAnonymiseIDColumn.Click
        dlgAnonymiseIDColumn.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileImportShapeFile_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileImportShapeFile.Click
        dlgImportShapeFiles.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineTidyDailyData_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineTidyDailyData.Click
        dlgTidyDailyData.ShowDialog()
    End Sub

    Private Sub mnuClimaticTidyandExamineMerge_Click(sender As Object, e As EventArgs) Handles mnuClimaticTidyandExamineMerge.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuTbLastGraph_Click(sender As Object, e As EventArgs) Handles mnuTbLastGraph.Click
        clsRLink.ViewLastGraph()
    End Sub

    Private Sub mnuClimaticCMSAFExporttoCMSAFRToolbox_Click(sender As Object, e As EventArgs) Handles mnuClimaticCMSAFExporttoCMSAFRToolbox.Click
        dlgExportToCMSAF.ShowDialog()
    End Sub

    Private Sub mnuClimaticCheckDataMaps_Click_1(sender As Object, e As EventArgs) Handles mnuClimaticCheckDataMaps.Click
        dlgClimaticStationMaps.ShowDialog()
    End Sub
End Class