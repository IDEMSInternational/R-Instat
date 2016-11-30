﻿' Instat-R
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
    Public strHelpFilePath As String
    Public strAppDataPath As String
    Public strInstatOptionsFile As String
    Public clsInstatOptions As InstatOptions
    Public clsRecentItems As New clsRecentFiles
    Public strCurrentDataFrame As String
    Public dlgLastDialog As Form
    Public strSaveFilePath As String
    Private mnuItems As New List(Of Form)

    'This is the default data frame to appear in the data frame selector
    'If "" the current worksheet will be used
    'TODO This should be an option in the Options dialog
    '     User can choose a default data frame or set the default as the current worksheet
    Public strDefaultDataFrame As String = ""

    Private Sub InitialiseWebBrowser()
        'TEST temporary
        'Task: If keep, Still need to add on all the places where frmCommand is
        frmWebBrowser.MdiParent = Me
        frmWebBrowser.Show()
        clsRLink.SetWbOutput(frmWebBrowser.wbOutput)
    End Sub
    Private Sub InitialiseWPFOutputWindow()
        'TEST temporary
        'Task: If keep, Still need to add on all the places where frmCommand is
        frmOutputWindow2.MdiParent = Me
        frmOutputWindow2.Show()
        clsRLink.SetOutput2(frmOutputWindow2.ucrRichTextBox)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temp removed
        mnuHelpAboutRInstat.Visible = False
        InitialiseWebBrowser() 'TEST temporary
        InitialiseWPFOutputWindow() 'TEST temporary
        frmEditor.MdiParent = Me
        frmCommand.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        frmVariables.MdiParent = Me
        frmMetaData.MdiParent = Me
        strStaticPath = Path.GetFullPath("static")
        strHelpFilePath = "Help\R-Instat.chm"
        strAppDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "RInstat\")
        strInstatOptionsFile = "RInstatOptions.bin"
        strSaveFilePath = ""

        clsRLink.SetEngine()
        LoadInstatOptions()

        frmCommand.Show()
        frmEditor.Show()

        Me.LayoutMdi(MdiLayout.TileVertical)

        'Setting the properties of R Interface
        clsRLink.SetLog(frmLog.txtLog)
        clsRLink.SetOutput(frmCommand.txtCommand)
        'Sets up R source files
        clsRLink.RSetup()

        'Sets up the Recent items
        clsRecentItems.setToolStripItems(mnuFile, mnuTbShowLast10, sepStart, sepEnd)
        'checks existence of MRU list
        clsRecentItems.checkOnLoad()

    End Sub

    Private Sub LoadInstatOptions()
        If File.Exists(strInstatOptionsFile) Then
            LoadInstatOptionsFromFile(strInstatOptionsFile)
        Else
            clsInstatOptions = New InstatOptions
            'TODO Should these be here or in the constructor (New) of InstatOptions?
        End If
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
                    'TODO Check whether this is needed or not. Using should do it automatically.
                    '     Also check general structure of this code.
                    'FileStream.Close()
                End Using
            Catch ex As Exception
                MsgBox("Error attempting to use file:" & strFilePath & vbNewLine & "The file may be in use by another program or the file does not contain an instance of InstatOptions." & vbNewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error opening file")
                clsInstatOptions = New InstatOptions
            End Try
        Else
            MsgBox("File:" & strFilePath & " does not exist." & vbNewLine & "File will not be loaded.", MsgBoxStyle.Critical)
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
            MsgBox("Error attempting to save to file:" & strFilePath & vbNewLine & "The file may be in use by another program." & vbNewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error saving to file")
        End Try
    End Sub

    Private Sub mnuFileNewDataFrame_Click(sender As Object, e As EventArgs) Handles mnuFileNewDataFrame.Click
        dlgFileNew.ShowDialog()
    End Sub

    Private Sub RegularSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnGenerateRegularSequence.Click
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuCalculations_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnCalculateCalculations.Click
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuGraphicsInventory_Click(sender As Object, e As EventArgs)
        dlgInventoryPlot.ShowDialog()
    End Sub



    Private Sub mnuClimateMethodsGraphicsCliplot_Click(sender As Object, e As EventArgs)
        dlgCliPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsMissingValues_Click(sender As Object, e As EventArgs)
        dlgMissingValuesplot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsHistogram_Click(sender As Object, e As EventArgs)
        dlgHistogramMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsCumExceedance_Click(sender As Object, e As EventArgs)
        dlgCumulativeExceedance.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsBoxplot_Click(sender As Object, e As EventArgs)
        dlgBoxplotMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsInventory_Click(sender As Object, e As EventArgs)
        dlgInventoryMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsAnnualRainfall_Click(sender As Object, e As EventArgs)
        dlgAnnualRaintotal.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsTimeseries_Click(sender As Object, e As EventArgs)
        dlgTimeseriesPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsWindrose_Click(sender As Object, e As EventArgs)
        dlgWindrosePlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsMultipleLines_Click(sender As Object, e As EventArgs)
        dlgLines.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsRainCount_Click(sender As Object, e As EventArgs)
        dlgYearRaincount.ShowDialog()
    End Sub

    Private Sub mnuClmateMethodThreeSummaries_Click(sender As Object, e As EventArgs)
        dlgThreeSummaries.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationStartOfRain_Click(sender As Object, e As EventArgs)
        dlgAddStartRain.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationEndOfRain_Click(sender As Object, e As EventArgs)
        dlgEndRain.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationChangeFormatDayMonth_Click(sender As Object, e As EventArgs)
        dlgChangeFormatDayMonth.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExportCPTToTabular_Click(sender As Object, e As EventArgs)
        dlgCPTtoTabularData.ShowDialog()
    End Sub

    Private Sub nuClimateMethodsDataManipulationDayMonth_Click(sender As Object, e As EventArgs)
        dlgDayMonth.ShowDialog()

    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayDaily_Click(sender As Object, e As EventArgs)
        dlgDisplayDaily.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayDOYOfYear_Click(sender As Object, e As EventArgs)
        dlgDisplayDOYofYear.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayRainRunningTotal_Click(sender As Object, e As EventArgs)
        dlgDisplayRainRunningTotal.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplaySpellLength_Click(sender As Object, e As EventArgs)
        dlgDisplaySpellLength.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExportForPICSA_Click(sender As Object, e As EventArgs)
        dlgExportforPICSA.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExtremeEvents_Click(sender As Object, e As EventArgs)
        dlgExtremeEvents.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMissingData_Click(sender As Object, e As EventArgs)
        dlgMissingData.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMissingDataTable_Click(sender As Object, e As EventArgs)
        dlgMissingDataTable.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMonthlySummaries_Click(sender As Object, e As EventArgs)
        dlgMonthlySummaries.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationOutputForCD_Click(sender As Object, e As EventArgs)
        dlgOutputforCDT.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalOutputForCPT_Click(sender As Object, e As EventArgs)
        dlgOutputforCPT.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalRainsStatistics_Click(sender As Object, e As EventArgs)
        dlgRainStats.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalSeasonalSummary_Click(sender As Object, e As EventArgs)
        dlgSeasonalSummary.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalSeasonalSummaryRain_Click(sender As Object, e As EventArgs)
        dlgSeasonalSummaryRain.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnRowSummary_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnCalculateRowSummary.Click
        dlgRowStats.ShowDialog()
    End Sub

    Private Sub mnuStatsRegressionSimple_Click(sender As Object, e As EventArgs)
        dlgRegressionSimple.ShowDialog()
    End Sub

    Private Sub FrequencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificFrequency.Click
        dlgFreqTables.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificSummary.Click
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnTransform_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnCalculateTransform.Click
        dlgTransform.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnPolynomials_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnCalculatePolynomials.Click
        dlgPolynomials.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeStack_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeStack.Click
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeUnstack_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeUnstack.Click
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnRecode_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorRecodeNumeric.Click
        dlgRecodeNumeric.ShowDialog()
    End Sub

    Private Sub RandomSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnGenerateRandomSamples.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameViewData.Click
        dlgView.ShowDialog()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeSubset.Click
        dlgRestrict.bIsSubsetDialog = True
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuModelThreeVariablesFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelThreeVariablesFitModel.Click
        dlgThreeVariableModelling.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionLogLinear_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralLogLinear.Click
        dlglogLinearModels.ShowDialog()
    End Sub

    Private Sub mnuStatsNonParametricTwoWayAnova_Click_1(sender As Object, e As EventArgs) Handles mnuModelOtherThreeVariablesNonParametricTwoWayANOVA.Click
        dlgNon_ParametricTwoWayAnova.ShowDialog()
    End Sub

    Private Sub NewWorksheetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseNewWorksheet.Click
        dlgNewWorksheet.ShowDialog()
    End Sub

    Private Sub ImportDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseImportDailyData.Click

    End Sub

    Private Sub MakeFactorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseMakeFactor.Click
        dlgMakeFactor.ShowDialog()
    End Sub

    Private Sub ShiftDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseShiftDailyData.Click
        dlgShiftDailyData.ShowDialog()
    End Sub

    Private Sub UnstackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseUnstackDailyData.Click
        dlgUnstackDailyData.ShowDialog()
    End Sub

    Private Sub StackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseStackDailyData.Click
        dlgStackDailyData.ShowDialog()
    End Sub

    Private Sub InterpolateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseInterpolate.Click
        dlgInterpolate.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuClimaticExamine_Click(sender As Object, e As EventArgs) Handles mnuClimaticExamine.Click
        dlgExamine.ShowDialog()
    End Sub

    Private Sub mnuClimaticProcess_Click(sender As Object, e As EventArgs) Handles mnuClimaticProcess.Click
        dlgProcess.ShowDialog()
    End Sub

    Private Sub mnuClimaticEvaporationSite_Click(sender As Object, e As EventArgs) Handles mnuClimaticEvaporationSite.Click
        dlgSite.ShowDialog()
    End Sub

    Private Sub mnuClimaticEvaporationPenman_Click(sender As Object, e As EventArgs) Handles mnuClimaticEvaporationPenman.Click
        dlgPenman.ShowDialog()
    End Sub

    Private Sub CropCoefficientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CropCoefficientsToolStripMenuItem.Click
        dlgCropCoefficients.ShowDialog()
    End Sub

    Private Sub WaterSatisfactionIndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterSatisfactionIndexToolStripMenuItem.Click
        dlgWaterSatisfactionIndex.ShowDialog()
    End Sub

    Private Sub HeatSumToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticHeatSum.Click
        dlgHeatSum.ShowDialog()
    End Sub

    Private Sub CountsTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticMarkovModellingCountsTotals.Click
        dlgCountsTotals.ShowDialog()
    End Sub

    Private Sub PrepareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticMarkovModellingPrepare.Click
        dlgPrepare.ShowDialog()
    End Sub

    Private Sub ModelProbabilitiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticMarkovModellingModelProbabilities.Click
        dlgModelProbabilities.ShowDialog()
    End Sub

    Private Sub ModelAmountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelAmountsToolStripMenuItem.Click
        dlgModelAmounts.ShowDialog()
    End Sub

    Private Sub InterpolateDailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterpolateDailyToolStripMenuItem.Click
        dlgInterpolateDaily.ShowDialog()
    End Sub

    Private Sub SimulationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulationsToolStripMenuItem.Click

    End Sub

    Private Sub SpellLengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpellLengthToolStripMenuItem.Click
        'dlgSpellLength.ShowDialog()
    End Sub

    Private Sub TotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalsToolStripMenuItem.Click
        dlgTotals.ShowDialog()
    End Sub

    Private Sub mnuStatisticsSimpleModelsTwoSample_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesTwoSamples.Click
        dlgTwoSamples.ShowDialog()
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

    Private Sub mnuManageDataRename_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameRenameColumn.Click
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuWindowVariable_Click(sender As Object, e As EventArgs) Handles mnuViewColumnMetadata.Click
        If frmVariables.Visible Then
            frmVariables.Visible = False
        Else
            frmVariables.Visible = True
            frmVariables.BringToFront()
        End If
    End Sub

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs) Handles mnuViewDataFrameMetadata.Click
        If frmMetaData.Visible Then
            frmMetaData.Visible = False
        Else
            frmMetaData.Visible = True
            frmMetaData.BringToFront()
        End If
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewLog.Click
        If frmLog.Visible Then
            frmLog.Visible = False
        Else
            frmLog.Visible = True
            frmLog.BringToFront()
        End If
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewScriptWindow.Click
        If frmScript.Visible Then
            frmScript.Visible = False
        Else
            frmScript.Visible = True
            frmScript.BringToFront()
        End If
    End Sub

    Private Sub mnuManageReshapeMerge_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeMerge.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuWindowsEditor_Click(sender As Object, e As EventArgs) Handles mnuViewDataView.Click
        If frmEditor.Visible Then
            frmEditor.Visible = False
        Else
            frmEditor.Visible = True
            frmEditor.BringToFront()
        End If
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuFilePrintPreview_Click(sender As Object, e As EventArgs) Handles mnuFilePrintPreview.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnRank_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnCalculateRank.Click
        dlgRank.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsCreateClimateObject_Click(sender As Object, e As EventArgs)
        dlgCreateClimateObject.ShowDialog()
    End Sub

    Private Sub mnuExport_Click(sender As Object, e As EventArgs) Handles mnuExport.Click
        dlgExportDataset.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileSheetMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectDataFrameMetadata.Click
        dlgDataFrameMetaData.ShowDialog()
    End Sub

    Private Sub mnuManageSheetColumnMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameColumnMetadata.Click
        frmVariables.Visible = True
        frmVariables.BringToFront()
    End Sub

    Private Sub mnuManageSheetInsertColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameInsertColumnsRows.Click
        dlgInsertColumn.ShowDialog()
    End Sub

    Private Sub mnuGraphicsBarPie_Click(sender As Object, e As EventArgs)
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnPermuteRows_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnGeneratePermuteRows.Click
        dlgPermuteColumn.ShowDialog()
    End Sub

    Private Sub mnuStatistcsMultivariateCorrelation_Click(sender As Object, e As EventArgs)
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileDeleteSheets_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectDeleteDataFrame.Click
        dlgDeleteSheet.ShowDialog()
    End Sub

    Private Sub mnuManageSheetDeleteColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameDeleteColumnsRows.Click
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
            clsSaveRDS.AddParameter("file", Chr(34) & strSaveFilePath & Chr(34))
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

    Private Sub mnuGraphicsBarPieChart_Click(sender As Object, e As EventArgs)
        dlgSummaryBarOrPieChart.ShowDialog()
    End Sub

    Private Sub mnuGraphicsScatterPlot_Click(sender As Object, e As EventArgs)
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuStatistcsMultivariatePrincipalComponents_Click(sender As Object, e As EventArgs)
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuStatistcsMultivariateCanonicalCorrelations_Click(sender As Object, e As EventArgs)
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub

    Private Sub mnuManageFactorRecode_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorRecodeFactor.Click
        dlgRecodeFactor.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileCopySheet_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectCopyDataFrame.Click
        dlgCopySheet.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileReorderSheets_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectReorderDataFrames.Click
        dlgReorderSheet.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileRenameSheet_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectRenameDataFrame.Click
        dlgRenameSheet.ShowDialog()
    End Sub

    Private Sub mnuManageRechapeColumnSummaries_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeColumnSummaries.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuManageSheetReorder_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorReferenceLevels_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorReferenceLevel.Click
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuMangeFactorLabel_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorLevelsLabels.Click
        dlgLabels.ShowDialog()
    End Sub

    Private Sub mnuManageFactorconvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorConvertToFactor.Click
        dlgConvertColumns.bToFactorOnly = True
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorReorderLevels_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorReorderLevels.Click
        dlgReorderLevels.ShowDialog()
    End Sub

    Private Sub mnuManageFactorUnusedLevels_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorUnusedLevels.Click
        dlgUnusedLevels.ShowDialog()
    End Sub

    Private Sub mnuManageSheetProtect_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameProtectColumn.Click
        dlgProtect.ShowDialog()
    End Sub

    Private Sub mnuManageDataSort_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameSort.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesView_Click(sender As Object, e As EventArgs) Handles mnuOrganiseRObjectsView.Click
        dlgViewDescriptives.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesReoder_Click(sender As Object, e As EventArgs) Handles mnuOrganiseRObjectsReorder.Click
        dlgReoderDescriptives.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesRename_Click(sender As Object, e As EventArgs) Handles mnuOrganiseRObjectsRename.Click
        dlgRenameDescriptive.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesDelete_Click(sender As Object, e As EventArgs) Handles mnuOrganiseRObjectsDelete.Click
        dlgDeleteDescriptive.ShowDialog()
    End Sub

    Private Sub mnuManageFactorContrasts_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorContrasts.Click
        dlgContrasts.ShowDialog()
    End Sub

    Private Sub mnuManageFactorSheet_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorFactorDataFrame.Click
        dlgFactorDataFrame.ShowDialog()
    End Sub

    Private Sub mnuGraphicsUseGraph_Click(sender As Object, e As EventArgs)
        dlgUseGraph.ShowDialog()
    End Sub

    Private Sub mnuManageTextSplit_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextSplit.Click
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuManageTextCombine_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextCombine.Click
        dlgCombineText.ShowDialog()
    End Sub

    Private Sub mnuManageTextMatch_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextMatch.Click
        dlgMatchText.ShowDialog()
    End Sub

    Private Sub mnuManageTextDistance_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextDistance.Click
        dlgDistanceText.ShowDialog()
    End Sub

    Private Sub mnuManageDataFilter_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = ""
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuManageDataConvertTo_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameConvertColumns.Click
        dlgConvertColumns.bToFactorOnly = False
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeTranspose_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeTranspose.Click
        dlgTransposeColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorCombine_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorCombineFactors.Click
        dlgCombine.ShowDialog()
    End Sub

    Private Sub mnuManageFactorDummyVariable_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnFactorDummyVariables.Click
        dlgDummyVariables.ShowDialog()
    End Sub

    Private Sub mnuStatisticsAnalysisOfVarianceGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralANOVAGeneral.Click
        dlgGeneralANOVA.ShowDialog()
    End Sub

    Private Sub mnuStatisticsTablesMultipleResponse_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificMultipleResponse.Click
        dlgMultipleResponse.ShowDialog()
    End Sub

    Private Sub mnuStatisticsSimpleModelsOneSampleSummaryData_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableSampleSummaryData.Click
        dlgOneSampleSummaryData.ShowDialog()
    End Sub

    Private Sub mnuStatisticsSimpleModelsTwoSamplesSummaryData_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesSummaryData.Click
        dlgTwoSampleSummaryData.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionGeneral_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralRegression.Click
        dlgGeneralRegression.ShowDialog()
    End Sub

    Private Sub WindRoseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub ThemesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgThemes.ShowDialog()
    End Sub

    Private Sub CombineToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgCombineforGraphics.ShowDialog()
    End Sub

    Private Sub PopulationPyramidsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgPopulationPyramids.ShowDialog()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeGeneralGraphics.Click
        dlgGeneralForGraphics.ShowDialog()
    End Sub

    Private Sub mnuManageTextTransform_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextTransform.Click
        dlgTransformText.ShowDialog()
    End Sub

    Private Sub mnuTbDelete_Click(sender As Object, e As EventArgs) Handles mnuTbDelete.Click
        mnuToolsClearOutputWindow_Click(sender, e)
    End Sub

    Private Sub mnuEditSelectAll_Click(sender As Object, e As EventArgs) Handles mnuEditSelectAll.Click
        If ActiveMdiChild Is frmLog Then
            frmLog.selectAllText()
        ElseIf ActiveMdiChild Is frmCommand Then
            frmCommand.selectAllText()
        ElseIf ActiveMdiChild Is frmScript Then
            frmScript.selectAllText()
        ElseIf ActiveMdiChild Is frmEditor AndAlso frmEditor.grdData.Visible Then
            frmEditor.selectAllText()
        End If
    End Sub

    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        If ActiveMdiChild Is frmLog Then
            frmLog.copyText()
        ElseIf ActiveMdiChild Is frmCommand Then
            frmCommand.copyText()
        ElseIf ActiveMdiChild Is frmScript Then
            frmScript.copyText()
        ElseIf ActiveMdiChild Is frmEditor AndAlso frmEditor.grdData.Visible Then
            frmEditor.copyRange()
        End If
    End Sub

    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs) Handles mnuToolsOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameHideColumns_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameHideColumns.Click
        dlgHideShowColumns.ShowDialog()
    End Sub

    Private Sub mnuModelProbabilityDistributionsRandomSamplesUseModel_Click(sender As Object, e As EventArgs) Handles mnuModelProbabilityDistributionsRandomSamplesUseModel.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub mnuModelTwoVariablesFitModel_Click(sender As Object, e As EventArgs) Handles mnuModelTwoVariablesFitModel.Click
        dlgRegressionSimple.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableExactResults_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableExactResults.Click
        dlgOneSample.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableSampleSummaryData_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableSampleSummaryData.Click
        dlgOneSampleSummaryData.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableNonParametric_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableNonParametric.Click
        dlgNon_ParametricOneSampleTests.ShowDialog()
    End Sub

    Private Sub mnuModelOtherOneVariableGoodnessofFit_Click(sender As Object, e As EventArgs) Handles mnuModelOtherOneVariableGoodnessofFit.Click
        dlgGoodnessofFit.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesTwoSamples_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesTwoSamples.Click
        dlgTwoSamples.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesSummaryData_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesSummaryData.Click
        dlgTwoSampleSummaryData.ShowDialog()
    End Sub

    Private Sub mnuModelOtherTwoVariablesSimpleRegression_Click(sender As Object, e As EventArgs) Handles mnuModelOtherTwoVariablesSimpleRegression.Click
        dlgRegressionSimple.ShowDialog()
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

    Private Sub mnuModelOtherGeneralRegression_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralRegression.Click
        dlgGeneralRegression.ShowDialog()
    End Sub

    Private Sub mnuModelOtherGeneralLogLinear_Click(sender As Object, e As EventArgs) Handles mnuModelOtherGeneralLogLinear.Click
        dlglogLinearModels.ShowDialog()
    End Sub

    Private Sub DescribeGeneralCorrelations_Click(sender As Object, e As EventArgs)
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub OutputWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuViewOutputWindow.Click
        If frmCommand.Visible Then
            frmCommand.Visible = False
        Else
            frmCommand.Visible = True
            frmCommand.BringToFront()
        End If
    End Sub

    Private Sub mnuOrganiseColumnReshapeRandomSubset_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnReshapeRandomSubset.Click
        dlgRandomSubsets.ShowDialog()
    End Sub

    Private Sub mnuToolsClearOutputWindow_Click(sender As Object, e As EventArgs) Handles mnuToolsClearOutputWindow.Click
        Dim dlgResponse As DialogResult
        If frmCommand.txtCommand.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the " & frmCommand.Text, "Clear " & frmCommand.Text, MessageBoxButtons.YesNo)
            If dlgResponse = DialogResult.Yes Then
                frmCommand.txtCommand.Clear()
            End If
        End If
    End Sub

    Private Sub mnuOrganiseDataObjectDeleteMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectDeleteMetadata.Click
        dlgDeleteMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectMetadata.Click
        'TODO Change this dialog
        '     currently dlgMetadata is colouring grid dialog
        dlgMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectReorderMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectReorderMetadata.Click
        dlgReoderMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataObjectRenameMetadata_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectRenameMetadata.Click
        dlgRenameMetadata.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameRowNumbersNames_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameRowNumbersNames.Click
        dlgRowNamesOrNumbers.ShowDialog()
    End Sub

    Private Sub JitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuOrganisePrepareToShareJitter.Click
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

    Private Sub mnuViewCascade_Click(sender As Object, e As EventArgs) Handles mnuViewCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuViewTileVertically_Click(sender As Object, e As EventArgs) Handles mnuViewTileVertically.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuViewTileHorizontally_Click(sender As Object, e As EventArgs) Handles mnuViewTileHorizontally.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuOrganiseColumnTextFindReplace_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnTextFindReplace.Click
        'dlgReplace.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableSummarise.Click
        dlgDescribeOneVariable.ShowDialog()
    End Sub

    Private Sub mnuDescribeOneVariableGraph_Click(sender As Object, e As EventArgs) Handles mnuDescribeOneVariableGraph.Click
        dlgOneVariableGraph.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim close = MsgBox("Are you sure you want to exit R-Instat?", MessageBoxButtons.YesNo, "Exit")
        If close = DialogResult.Yes Then
            Try
                If (Not System.IO.Directory.Exists(strAppDataPath)) Then
                    System.IO.Directory.CreateDirectory(strAppDataPath)
                End If
                clsRecentItems.saveOnClose()
                SaveInstatOptions(Path.Combine(strAppDataPath, strInstatOptionsFile))
            Catch ex As Exception
                MsgBox("Error attempting to save setting files to App Data folder." & vbNewLine & "System error message: " & ex.Message, MsgBoxStyle.Critical, "Error saving settings")
            End Try
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuOrganiseDataObjectHideDataframes_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataObjectHideDataframes.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub mnuOrganiseDataFrameReplaceValues_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameReplaceValues.Click
        dlgReplace.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesSummarise_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesSummarise.Click
        dlgDescribeTwoVariable.ShowDialog()
    End Sub

    Private Sub mnuAppendDataFrame_Click(sender As Object, e As EventArgs) Handles mnuAppendDataFrame.Click
        dlgAppend.ShowDialog()
    End Sub

    Private Sub mnuFileSaveAsOutputAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAsOutputAs.Click
        Using dlgSaveFile As New SaveFileDialog
            dlgSaveFile.Title = "Save Output Window"
            dlgSaveFile.Filter = "Rich Text Format (*.rtf)|*.rtf"
            dlgSaveFile.InitialDirectory = clsInstatOptions.strWorkingDirectory
            If dlgSaveFile.ShowDialog() = DialogResult.OK Then
                Try
                    frmCommand.txtCommand.SaveFile(dlgSaveFile.FileName, RichTextBoxStreamType.RichText)
                Catch
                    MsgBox("Could not save the output window." & vbNewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
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
                    MsgBox("Could not save the log file." & vbNewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
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
                    MsgBox("Could not save the script file." & vbNewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuOrganiseDataFrameColumnStructure_Click(sender As Object, e As EventArgs) Handles mnuOrganiseDataFrameColumnStructure.Click
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

    Private Sub mnuOrganiseColumnGenerateEnter_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnGenerateEnter.Click
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

    Private Sub mnuClimaticDescribeDescribeDaily_Click(sender As Object, e As EventArgs) Handles mnuClimaticDescribeDescribeDaily.Click
        dlgDisplayDaily.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseSummary_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseSummary.Click
        dlgSummary.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsStartoftheRains_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseEventsStartoftheRains.Click
        dlgStartofRains.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsExtremes_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseEventsExtremes.Click
        dlgExtremes.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsSpells_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseEventsSpells.Click
        dlgSpells.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsWaterBalance_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseEventsWaterBalance.Click
        dlgWaterBalance.ShowDialog()
    End Sub

    Private Sub mnuClimaticOrganiseEventsEndoftheRains_Click(sender As Object, e As EventArgs) Handles mnuClimaticOrganiseEventsEndoftheRains.Click
        dlgEndofRains.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnGenerateCountInFactor_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnGenerateCountInFactor.Click
        dlgCountinFactor.ShowDialog()
    End Sub

    Private Sub mnuDescribeTwoVariablesTabulate_Click(sender As Object, e As EventArgs) Handles mnuDescribeTwoVariablesTabulate.Click
        dlgTwoVariableTabulate.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificScatterPlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificScatterPlot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuDescribeSpecificLinePlot_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificLinePlot.Click
        dlgPlot.ShowDialog()
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

    Private Sub mnuDescribeSpecificBarChartFromSummary_Click(sender As Object, e As EventArgs) Handles mnuDescribeSpecificBarChartFromSummary.Click
        dlgSummaryBarOrPieChart.ShowDialog()
    End Sub

    Private Sub mnuDescribeOtherGraphicsDialogsCumulativeDistribution_Click(sender As Object, e As EventArgs) Handles mnuDescribeOtherGraphicsDialogsCumulativeDistribution.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub mnuOrganiseColumnMakeDate_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnMakeDate.Click
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuClimdex_Click(sender As Object, e As EventArgs) Handles mnuClimdex.Click
        dlgClimdex.ShowDialog()
    End Sub

    Private Sub mnuDescribeOtherGraphicsDialogsWindRose_Click(sender As Object, e As EventArgs) Handles mnuDescribeOtherGraphicsDialogsWindRose.Click
        dlgWindrose.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataExportOpenRefine_Click(sender As Object, e As EventArgs) Handles mnuOrganiseCheckDataExportOpenRefine.Click
        dlgExportToOpenRefine.ShowDialog()
    End Sub

    Private Sub mnuOrganiseCheckDataImportOpenRefine_Click(sender As Object, e As EventArgs) Handles mnuOrganiseCheckDataImportOpenRefine.Click
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

    Private Sub mnuOrganiseColumnUseDate_Click(sender As Object, e As EventArgs) Handles mnuOrganiseColumnUseDate.Click
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

    Private Sub HtmlTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HtmlTestToolStripMenuItem.Click
        'TEST temporary 
        'TESTING TO BE ERASED !!!!!!!
        Dim clsTestStargizer As New RFunction
        clsTestStargizer.SetRCommand("stargazer::stargazer")
        clsTestStargizer.AddParameter("None", "attitude", bIncludeArgumentName:=False)
        clsTestStargizer.AddParameter("type", Chr(34) & "html" & Chr(34))
        clsRLink.RunScript(clsTestStargizer.ToScript(), True, "Helloooooooo Stargizer power", True)
    End Sub
End Class