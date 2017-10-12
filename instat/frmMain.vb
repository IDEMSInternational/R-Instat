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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim prdCustom As New clsCustomRenderer(New clsCustomColourTable)

        mnuBar.Renderer = prdCustom
        Tool_strip.Renderer = prdCustom

        SetMainMenusEnabled(False)
        Cursor = Cursors.WaitCursor
        'temporary
        mnuHelpAboutRInstat.Visible = False

        InitialiseOutputWindow()
        clsGrids.SetDataViewer(ucrDataViewer)
        clsGrids.SetMetadata(ucrDataFrameMeta.grdMetaData)
        clsGrids.SetVariablesMetadata(ucrColumnMeta.grdVariables)

        clsRLink.SetLog(ucrLogWindow.txtLog)

        SetToDefaultLayout()
        strStaticPath = Path.GetFullPath("static")
        strAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RInstat\")

        AutoRecoverAndStartREngine()

        'Do this after setting up R Link becuase setup edits Output window which is changed by Options
        LoadInstatOptions()

        'Do this after loading options because interval depends on options
        'Interval is in milliseconds and option is in minutes
        timer.Interval = (clsInstatOptions.iAutoSaveDataMinutes * 60 * 1000)
        timer.Start()

        AddHandler System.Windows.Forms.Application.Idle, AddressOf Application_Idle

        'Sets up the Recent items
        clsRecentItems.setToolStripItems(mnuFile, mnuTbShowLast10, sepStart, sepEnd)
        'checks existence of MRU list
        clsRecentItems.checkOnLoad()
        Cursor = Cursors.Default
        SetMainMenusEnabled(True)
    End Sub

    Private Sub SetMainMenusEnabled(bEnabled As Boolean)
        mnuFile.Enabled = bEnabled
        mnuEdit.Enabled = bEnabled
        mnuPrepare.Enabled = bEnabled
        mnuDescribe.Enabled = bEnabled
        mnuModel.Enabled = bEnabled
        mnuClimatic.Enabled = bEnabled
        mnuProcurement.Enabled = bEnabled
        mnuTools.Enabled = bEnabled
        mnuView.Enabled = bEnabled
        mnuHelp.Enabled = bEnabled
        Tool_strip.Enabled = bEnabled
    End Sub

    Private Sub Application_Idle(sender As Object, e As EventArgs)
        If clsInstatOptions.bAutoSaveData AndAlso Not timer.Enabled AndAlso (ActiveForm Is Nothing OrElse ActiveForm.Equals(Me)) AndAlso Not clsRLink.bRCodeRunning Then
            AutoSaveData()
            timer.Interval = (clsInstatOptions.iAutoSaveDataMinutes * 60 * 1000)
            timer.Start()
        End If
    End Sub

    Private Sub AutoRecoverAndStartREngine()
        Dim iLogFiles As Integer = 0
        Dim iInternalLogFiles As Integer = 0
        Dim iDataFiles As Integer = 0
        Dim strScript As String = ""
        Dim strDataFilePath As String = ""
        Dim strAutoSavedLogFilePaths() As String = Nothing
        Dim strAutoSavedInternalLogFilePaths() As String = Nothing
        Dim strAutoSavedDataFilePaths() As String = Nothing

        If Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1 Then
            clsRLink.StartREngine(clsRLink.GetRSetupScript())
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
                Else
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
            clsRLink.StartREngine(strScript)
            If strDataFilePath <> "" Then
                clsRLink.LoadInstatDataObjectFromFile(strDataFilePath, strComment:="Loading auto recovered data file")
            End If
        End If
    End Sub

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
                MsgBox("Error attempting to use file:" & strFilePath & Environment.NewLine & "The file may be in use by another program or the file does not contain an instance of InstatOptions." & Environment.NewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error opening file")
                clsInstatOptions = New InstatOptions
            End Try
        Else
            MsgBox("File:" & strFilePath & " does not exist." & Environment.NewLine & "File will not be loaded.", MsgBoxStyle.Critical)
            clsInstatOptions = New InstatOptions
        End If
    End Sub

    Public Sub SaveInstatOptions(strFilePath As String)
        Dim serializer As New BinaryFormatter()

        Try
            Using FileStream As Stream = File.Create(strFilePath)
                serializer.Serialize(FileStream, clsInstatOptions)
                'TODO Check whether this is needed or not. Using should do it automatically.
                '     Also check general structure of this code.
                'FileStream.Close()
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

    Private Sub RegularSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGenerateRegularSequence.Click
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuCalculations_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateCalculations.Click
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnRowSummary_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateRowSummary.Click
        dlgRowSummary.ShowDialog()
    End Sub

    Private Sub FrequencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificFrequency.Click
        dlgFrequency.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificSummary.Click
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnTransform_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateTransform.Click
        dlgTransform.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnPolynomials_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculatePolynomials.Click
        dlgPolynomials.ShowDialog()
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

    Private Sub RandomSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGenerateRandomSamples.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameViewData.Click
        dlgView.ShowDialog()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnReshapeSubset.Click
        dlgRestrict.bIsSubsetDialog = True
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuModelThreeVariablesFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelThreeVariablesFitModel.Click
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    'Private Sub mnuStatsNonParametricTwoWayAnova_Click_1(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Click
    '    dlgNon_ParametricTwoWayAnova.ShowDialog()
    'End Sub

    Private Sub ImportDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareImportDailyData.Click

    End Sub

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

    Private Sub mnuFileOpenFromFile_Click(sender As Object, e As EventArgs) Handles mnuFileOpenFromFile.Click
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        dlgSaveAs.ShowDialog()
    End Sub

    Private Sub mnuFileOpenFromLibrary_Click(sender As Object, e As EventArgs) Handles mnuFileOpenFromLibrary.Click
        dlgFromLibrary.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataRename_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameRenameColumn.Click
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
    End Sub

    Private Sub mnuWindowVariable_Click(sender As Object, e As EventArgs) Handles mnuViewColumnMetadata.Click
        mnuViewColumnMetadata.Checked = Not mnuViewColumnMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs) Handles mnuViewDataFrameMetadata.Click
        mnuViewDataFrameMetadata.Checked = Not mnuViewDataFrameMetadata.Checked
        UpdateLayout()
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewLog.Click
        mnuViewLog.Checked = Not mnuViewLog.Checked
        UpdateLayout()
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewScriptWindow.Click
        mnuViewScriptWindow.Checked = Not mnuViewScriptWindow.Checked
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

    Private Sub mnuPrepareAddColumnRank_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnCalculateRank.Click
        dlgRank.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsCreateClimateObject_Click(sender As Object, e As EventArgs)
        dlgCreateClimateObject.ShowDialog()
    End Sub

    'Private Sub mnuExport_Click(sender As Object, e As EventArgs) Handles mnuExport.Click
    '    dlgExportDataset.ShowDialog()
    'End Sub

    Private Sub mnuPrepareDataFileSheetMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectDataFrameMetadata.Click
        dlgDataFrameMetaData.ShowDialog()
    End Sub

    Private Sub mnuPrepareSheetColumnMetadata_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameColumnMetadata.Click
        mnuViewColumnMetadata.Checked = True
        UpdateLayout()
    End Sub

    Private Sub mnuPrepareSheetInsertColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameInsertColumnsRows.Click
        dlgInsertColumn.ShowDialog()
    End Sub

    Private Sub mnuGraphicsBarPie_Click(sender As Object, e As EventArgs)
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuPrepareAddColumnPermuteRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGeneratePermuteRows.Click
        dlgPermuteColumn.ShowDialog()
    End Sub
    Private Sub mnuPrepareDataFileDeleteSheets_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataObjectDeleteDataFrame.Click
        dlgDeleteDataFrames.ShowDialog()
    End Sub


    Private Sub mnuPrepareSheetDeleteColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameDeleteColumnsRows.Click
        dlgDeleteRowsOrColums.ShowDialog()
    End Sub

    Private Sub EditLastDialogueToolStrip_Click(sender As Object, e As EventArgs) Handles EditLastDialogueToolStrip.Click
        If clsRecentItems.mnuItems.Count > 0 Then
            clsRecentItems.mnuItems.Last.ShowDialog()
        End If
    End Sub

    Private Sub mnuTbNew_Click(sender As Object, e As EventArgs) Handles mnuTbNew.Click
        mnuFileNewDataFrame_Click(sender, e)
    End Sub


    Private Sub mnuTbOpen_Click(sender As Object, e As EventArgs) Handles mnuTbOpen.Click
        mnuFileOpenFromFile_Click(sender, e)
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
        End If
    End Sub

    Private Sub mnuTbCopy_Click(sender As Object, e As EventArgs) Handles mnuTbCopy.Click
        mnuEditCopy_Click(sender, e)
    End Sub

    Private Sub mnuTbPrint_Click(sender As Object, e As EventArgs) Handles mnuTbPrint.Click
        mnuFilePrint_Click(sender, e)
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

    Private Sub mnuPrepareFactorViewLabels_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
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

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeGeneralGraphics.Click
        dlgGeneralForGraphics.ShowDialog()
    End Sub

    Private Sub mnuPrepareTextTransform_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextTransform.Click
        dlgTransformText.ShowDialog()
    End Sub

    Private Sub mnuTbDelete_Click(sender As Object, e As EventArgs) Handles mnuTbDelete.Click
        mnuToolsClearOutputWindow_Click(sender, e)
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuEditSelectAll.Click
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

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
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

    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs) Handles mnuToolsOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameHideColumns_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameHideColumns.Click
        dlgHideShowColumns.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsRandomSamplesUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsRandomSamplesUseModel.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub mnuModelTwoVariablesFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelTwoVariablesFitModel.Click
        dlgTwoVariableFitModel.ShowDialog()
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

    Private Sub mnuModelOtherTwoVariablesNonParametricTwoSamples_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesNonParametricTwoSamples.Click

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
            ucrOutput.ucrRichTextBox.rtbOutput.Document.Blocks.Clear() 'To b checked
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

    Private Sub mnuModelFourVariablesFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelFourVariablesFitModel.Click
        dlgFourVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuEditFind_Click(sender As Object, e As EventArgs) Handles mnuEditFind.Click
        dlgFind.currWindow = ActiveMdiChild
        dlgFind.Owner = Me
        dlgFind.Show()
    End Sub

    Private Sub mnuEditFindNext_Click(sender As Object, e As EventArgs) Handles mnuEditFindNext.Click
        mnuEditFind_Click(sender, e)
    End Sub

    Private Sub ColourByPropertyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColourByPropertyToolStripMenuItem.Click
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

    Private Sub mnuOrganiseColumnTextFindReplace_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnTextFindReplace.Click
        dlgStringHandling.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableSummarise.Click
        dlgDescribeOneVariable.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim bClose As DialogResult = DialogResult.Yes

        If e.CloseReason = CloseReason.UserClosing Then
            bClose = MsgBox("Are you sure you want to exit R-Instat?" & Environment.NewLine & "Any unsaved changes will be lost.", MessageBoxButtons.YesNo, "Exit")
        End If
        If bClose = DialogResult.Yes Then
            Try
                If (Not System.IO.Directory.Exists(strAppDataPath)) Then
                    System.IO.Directory.CreateDirectory(strAppDataPath)
                End If
                clsRecentItems.saveOnClose()
                SaveInstatOptions(Path.Combine(strAppDataPath, strInstatOptionsFile))
                DeleteAutoSaveData()
                DeleteAutoSaveLog()
                DeleteAutoSaveDebugLog()
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

    Private Sub mnuFileSaveAsLogAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsLogAs.Click
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Log Window"
            dlgSaveFile.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, frmLog.txtLog.Text)
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
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSaveFile.FileName, frmScript.txtScript.Text)
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

    Private Sub mnuClimaticFileOpensst_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileOpensst.Click
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub mnuModelGeneralFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelGeneralFitModel.Click
        dlgFitModel.ShowDialog()
    End Sub

    Private Sub mnuImportFromOpenDataKit_Click(sender As Object, e As EventArgs) Handles mnuImportFromODK.Click
        dlgImportFromODK.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelOneVariableFitModel.Click
        dlgOneVarFitModel.ShowDialog()
    End Sub

    Private Sub mnuModelTwoVariablesUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelTwoVariablesUseModel.Click
        dlgTwoVariableUseModel.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnGenerateEnter_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGenerateEnter.Click
        dlgEnter.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableCompareModels_Click(sender As Object, e As EventArgs) Handles mnuModelOneVariableCompareModels.Click
        dlgOneVarCompareModels.ShowDialog()
    End Sub

    Private Sub mnuModelOneVariableUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelOneVariableUseModel.Click
        dlgOneVarUseModel.ShowDialog()
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

    Private Sub mnuOrganiseColumnGenerateCountInFactor_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnGenerateCountInFactor.Click
        dlgCountinFactor.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificScatterPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificScatterPlot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificLinePlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificLinePlot.Click
        dlgLinePlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificHistogram_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificHistogram.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBoxplot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificBoxplot.Click
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificDotPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificDotPlot.Click
        dlgDotPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificRugPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificRugPlot.Click
        dlgRugPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificBarChart_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificBarChart.Click
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnMakeDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnMakeDate.Click
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimdex_Click(sender As Object, e As EventArgs) Handles mnuClimdex.Click
        dlgClimdexIndices.ShowDialog()
    End Sub

    Private Sub mnuDescribeOtherGraphicsDialogsWindRose_Click(sender As Object, e As EventArgs)
        dlgWindrose.ShowDialog()
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

    Private Sub mnuOrganiseColumnUseDate_Click(sender As Object, e As EventArgs) Handles mnuPrepareColumnUseDate.Click
        dlgUseDate.ShowDialog()
    End Sub

    Private Sub mnuHelpMenusAndDialogues_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "12")
    End Sub

    Private Sub mnuHelpRPackagesAndCommands_Click(sender As Object, e As EventArgs)
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "26")
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

    Private Sub mnuHelpSpreadsheet_Click(sender As Object, e As EventArgs) Handles mnuHelpSpreadsheet.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "134")
    End Sub

    Private Sub mnuHelpDataset_Click(sender As Object, e As EventArgs) Handles mnuHelpDataset.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "71")
    End Sub

    Private Sub mnuHelpRPackagesCommands_Click(sender As Object, e As EventArgs) Handles mnuHelpRPackagesCommands.Click
        Help.ShowHelp(Me, strStaticPath & "\" & strHelpFilePath, HelpNavigator.TopicId, "26")
    End Sub

    Private Sub mnuHelpR_Click(sender As Object, e As EventArgs) Handles mnuHelpR.Click
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

    Private Sub mnuClimaticDescribeMoreGraphsCummulaiveDistribution_Click(sender As Object, e As EventArgs)
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportExporttoCPT_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportExporttoCPT.Click
        dlgExportToCPT.ShowDialog()
    End Sub

    Private Sub mnuClimaticSCFSupportOpenSST_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportOpenSST.Click
        dlgOpenSST.ShowDialog()
    End Sub

    Private Sub mnuOrgCalculateDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuPrepareCalculateDuplicateColumn.Click
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuCorruptionFile_Click(sender As Object, e As EventArgs)
        dlgCorruptionFile.ShowDialog()
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

    Private Sub mnuClimaticMarkovModelling_Click(sender As Object, e As EventArgs) Handles mnuClimaticModelsMarkovModelling.Click
        dlgNewMarkovChains.ShowDialog()
    End Sub

    Private Sub mnuCliDefineClimaticData_Click(sender As Object, e As EventArgs) Handles mnuCliDefineClimaticData.Click
        DlgDefineClimaticData.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateFileClimSoft_Click(sender As Object, e As EventArgs) Handles mnuClimateFileClimSoft.Click
        dlgClimSoft.ShowDialog()
    End Sub

    Private Sub mnuClimaticFileCliData_Click(sender As Object, e As EventArgs) Handles mnuClimaticFileCliData.Click
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
        dlgPCSARainfall.ShowDialog()
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

    Private Sub mnuClimaticSCFSupportCumulativeExceedanceGraphs_Click(sender As Object, e As EventArgs) Handles mnuClimaticSCFSupportCumulativeExceedanceGraphs.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareFilterByCountry_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareFilterByCountry.Click
        Dim lstDataNames As List(Of String)

        dlgRestrict.bIsSubsetDialog = True
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
        dlgFitCorruptionModel.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineRedFlags_Click(sender As Object, e As EventArgs) Handles mnuProcurementDefineRedFlags.Click
        dlgDefineRedFlags.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesTabulate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuDescribeTwoVariablesFrequencies_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesFrequencies.Click
        dlgTwoWayFrequencies.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub ImportFromCSPROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromCSPROToolStripMenuItem.Click
        dlgImportFromCSPRO.ShowDialog()
    End Sub

    Private Sub ImportFromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportFromToolStripMenuItem.Click
        dlgImportFromDatabases.ShowDialog()
    End Sub

    Private Sub OpenNetCDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNetCDFToolStripMenuItem.Click
        dlgOpenNetCDF.ShowDialog()
    End Sub

    Private Sub mnuProcurementDefineCorruption_Click(sender As Object, e As EventArgs) Handles mnuProcurementDefineCorruption.Click
        dlgDefineCorruptionOutputs.ShowDialog()
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

    Private Sub mnuProcurementCalculateCRI_Click(sender As Object, e As EventArgs) Handles mnuProcurementCalculateCRI.Click
        dlgDefineCRI.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareStandardiseCountryName_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareStandardiseCountryName.Click
        Dim lstDataNames As List(Of String)

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgStandardiseCountryNames.strDefaultDataFrame = lstDataNames(0)
            dlgStandardiseCountryNames.strDefaultColumn = clsRLink.GetCorruptionColumnOfType(lstDataNames(0), "corruption_country_label")
        Else
            dlgStandardiseCountryNames.strDefaultDataFrame = ""
            dlgStandardiseCountryNames.strDefaultColumn = ""
        End If
        dlgStandardiseCountryNames.ShowDialog()
    End Sub

    Private Sub mnuProcurementPrepareRecodeNumericIntoQuantiles_Click(sender As Object, e As EventArgs) Handles mnuProcurementPrepareRecodeNumericIntoQuantiles.Click
        dlgRecodeNumericIntoQuantiles.ShowDialog()
    End Sub

    Private Sub ResetToDefaultLayoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToDefaultLayoutToolStripMenuItem.Click
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

    Private Sub DispalyClimaticDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispalyClimaticDataToolStripMenuItem.Click
        dlgDisplayDailyData.ShowDialog()
    End Sub

    Private Sub mnuClimaticPrepareClimaticSummaries_Click(sender As Object, e As EventArgs) Handles mnuClimaticPrepareClimaticSummaries.Click
        dlgClimaticSummary.ShowDialog()
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        ucrDataViewer.SetCurrentDataFrame(strDataName)
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

    Private Sub DuplicatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicatesToolStripMenuItem.Click
        dlgDuplicates.ShowDialog()
    End Sub

    Private Sub BoxplotsConceptualisedAndConstructedToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BoxplotsConceptualisedAndConstructedToolStripMenuItem.Click
        dlgClimaticBoxPlot.ShowDialog()
    End Sub

    Private Sub mnuClimaticDescribeWindSpeedDirectionWindRose_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeWindSpeedDirectionWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub PlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlToolStripMenuItem.Click
        dlgPlotRegion.ShowDialog()
    End Sub

    Private Sub mnuProcurementCorrelations_Click(sender As Object, e As EventArgs) Handles mnuProcurementCorrelations.Click
        Dim lstDataNames As List(Of String)
        Dim strComponentColumnNames() As String

        lstDataNames = clsRLink.GetCorruptionContractDataFrameNames()
        If lstDataNames.Count > 0 Then
            dlgCorrelation.strDefaultDataFrame = lstDataNames(0)
            strComponentColumnNames = clsRLink.GetCorruptionComponentsColumnNames(lstDataNames(0))
            If strComponentColumnNames IsNot Nothing AndAlso strComponentColumnNames.Count > 0 Then
                dlgCorrelation.strDefaultColumns = strComponentColumnNames
            End If
        Else
            dlgCorrelation.strDefaultDataFrame = ""
            dlgCorrelation.strDefaultColumns = Nothing
        End If
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub DisplayDailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayDailyToolStripMenuItem.Click
        dlgDisplayDailyData.ShowDialog()
    End Sub

    Private Sub mnuProcurementMaps_Click(sender As Object, e As EventArgs) Handles mnuProcurementMaps.Click
        dlgCountryColouredMap.ShowDialog()
    End Sub

    Private Sub mnuProcurementDescribeMaps_Click(sender As Object, e As EventArgs) Handles mnuProcurementDescribeMaps.Click
        dlgCountryColouredMap.ShowDialog()
    End Sub

    Private Sub mnuPrepareDataFrameVariableSets_Click(sender As Object, e As EventArgs) Handles mnuPrepareDataFrameVariableSets.Click
        dlgVariableSets.ShowDialog()
    End Sub
End Class