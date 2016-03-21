' Instat-R
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

Public Class frmMain

    Public clsRLink As New RLink
    Public clsGrids As New clsGridLink
    Public strStaticPath As String
    Public strHelpFilePath As String
    Public clsInstatOptions As InstatOptions
    Public strCurrentDataFrame As String
    Public dlgLastDialog As Form

    Dim mnuItems As New List(Of Form)

    'This is the default data frame to appear in the data frame selector
    'If "" the current worksheet will be used
    'TODO This should be an option in the Options dialog
    '     User can choose a default data frame or set the default as the current worksheet
    Public strDefaultDataFrame As String = ""

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEditor.MdiParent = Me
        frmCommand.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        frmVariables.MdiParent = Me
        frmMetaData.MdiParent = Me
        strStaticPath = Path.GetFullPath("static")
        strHelpFilePath = "Help\R-Instat.chm"

        LoadInstatOptions()

        frmCommand.Show()
        frmEditor.Show()

        Me.LayoutMdi(MdiLayout.TileVertical)

        'Setting the properties of R Interface
        clsRLink.SetLog(frmLog.txtLog)
        clsRLink.SetOutput(frmCommand.txtCommand)
        clsRLink.clsEngine = REngine.GetInstance()
        clsRLink.clsEngine.Initialize()
        'Sets up R source files
        clsRLink.RSetup()

    End Sub

    Private Sub LoadInstatOptions()
        clsInstatOptions = New InstatOptions
        clsInstatOptions.bIncludeRDefaultParameters = False
    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsSummaryDescribe.Click
        dlgDescriptiveStatistics.ShowDialog()
    End Sub

    Private Sub KiswahiliToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
        autoTranslate(Me)
    End Sub

    Private Sub mnuGraphicsCummulativeDistribution_Click(sender As Object, e As EventArgs) Handles mnuGraphicsCummulativeDistribution.Click
        dlgCumulativeDistribution.ShowDialog()
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
        autoTranslate(Me)
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        autoTranslate(Me)
    End Sub

    Private Sub mnuFileNewDataFrame_Click(sender As Object, e As EventArgs) Handles mnuFileNewDataFrame.Click
        dlgFileNew.ShowDialog()
    End Sub

    Private Sub StartOfTheRainsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticEventsStartOfTheRains.Click
        dlgStartofRains.ShowDialog()
    End Sub

    Private Sub RegularSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuManageDataRegularSequence.Click
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuCalculations_Click(sender As Object, e As EventArgs) Handles mnuCalculations.Click
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuGraphicsBoxPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsBoxPlot.Click
        dlgBoxplot.ShowDialog()
    End Sub

    Private Sub mnuEndofRains_Click(sender As Object, e As EventArgs) Handles mnuClimaticEventsEndofRains.Click
        dlgEndofRains.ShowDialog()
    End Sub

    Private Sub mnuGraphicsInventory_Click(sender As Object, e As EventArgs) Handles mnuGraphicsInventory.Click
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionMultinomial_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionMultinomial.Click
        dlgMultipleRegression.ShowDialog()
    End Sub

    Private Sub mnuGraphicsPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsLinePlot.Click
        dlgPlot.ShowDialog()
    End Sub

    Private Sub mnuGraphicsHistogram_Click(sender As Object, e As EventArgs) Handles mnuGraphicsHistogram.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub StemAndLeafToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGraphicsStemAndLeaf.Click
        dlgStemAndLeaf.ShowDialog()
    End Sub

    Private Sub mnuGraphisDotPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsDotPlot.Click
        dlgDotPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsClipBoxPlot_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsClipBoxPlot.Click
        dlgCliBoxplot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsCliplot_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsCliplot.Click
        dlgCliPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsMissingValues_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsMissingValues.Click
        dlgMissingValuesplot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsHistogram_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsHistogram.Click
        dlgHistogramMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsCumExceedance_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsCumExceedance.Click
        dlgCumulativeExceedance.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsBoxplot_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsBoxplot.Click
        dlgBoxplotMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsInventory_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsInventory.Click
        dlgInventoryMethod.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsAnnualRainfall_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsAnnualRainfall.Click
        dlgAnnualRaintotal.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsTimeseries_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsTimeseries.Click
        dlgTimeseriesPlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsWindrose_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsWindrose.Click
        dlgWindrosePlot.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsMultipleLines_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsMultipleLines.Click
        dlgLines.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsGraphicsRainCount_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsGraphicsRainCount.Click
        dlgYearRaincount.ShowDialog()
    End Sub

    Private Sub mnuClmateMethodThreeSummaries_Click(sender As Object, e As EventArgs) Handles mnuClmateMethodThreeSummaries.Click
        dlgThreeSummaries.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationStartOfRain_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationStartOfRain.Click
        dlgAddStartRain.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationEndOfRain_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationEndOfRain.Click
        dlgEndRain.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationChangeFormatDayMonth_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationChangeFormatDayMonth.Click
        dlgChangeFormatDayMonth.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExportCPTToTabular_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationExportCPTToTabular.Click
        dlgCPTtoTabularData.ShowDialog()
    End Sub

    Private Sub nuClimateMethodsDataManipulationDayMonth_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationDayMonth.Click
        dlgDayMonth.ShowDialog()

    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayDaily_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationDisplayDaily.Click
        dlgDisplayDaily.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayDOYOfYear_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationDisplayDOYOfYear.Click
        dlgDisplayDOYofYear.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplayRainRunningTotal_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationDisplayRainRunningTotal.Click
        dlgDisplayRainRunningTotal.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationDisplaySpellLength_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationDisplaySpellLength.Click
        dlgDisplaySpellLength.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExportForPICSA_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationExportForPICSA.Click
        dlgExportforPICSA.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationExtremeEvents_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationExtremeEvents.Click
        dlgExtremeEvents.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMissingData_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationMissingData.Click
        dlgMissingData.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMissingDataTable_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationMissingDataTable.Click
        dlgMissingDataTable.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationMonthlySummaries_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationMonthlySummaries.Click
        dlgMonthlySummaries.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsDataManipulationOutputForCD_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsDataManipulationOutputForCD.Click
        dlgOutputforCDT.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalOutputForCPT_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsAdditionalOutputForCPT.Click
        dlgOutputforCPT.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalRainsStatistics_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsAdditionalRainsStatistics.Click
        dlgRainStats.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalSeasonalSummary_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsAdditionalSeasonalSummary.Click
        dlgSeasonalSummary.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsAdditionalSeasonalSummaryRain_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsAdditionalSeasonalSummaryRain.Click
        dlgSeasonalSummaryRain.ShowDialog()
    End Sub

    Private Sub mnuStatsNonParametricOneWayAnova_Click(sender As Object, e As EventArgs) Handles mnuStatisticsNonParametricOneWayAnova.Click
        dlgNon_ParametricOneWayANOVA.ShowDialog()
    End Sub

    Private Sub mnuStatsSummaryColumnStat_Click(sender As Object, e As EventArgs) Handles mnuStatisticsSummaryColumnStat.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnRowSummary_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnRowSummary.Click
        dlgRowStats.ShowDialog()
    End Sub



    Private Sub mnuStatsRegressionSimple_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionSimple.Click
        dlgRegressionSimple.ShowDialog()
    End Sub



    Private Sub mnuEditFont_Click(sender As Object, e As EventArgs) Handles mnuEditFont.Click
        'dlgFont.ShowDialog()
    End Sub

    Private Sub mnuEditReplace_Click(sender As Object, e As EventArgs) Handles mnuEditReplace.Click
        dlgReplace.ShowDialog()
    End Sub

    Private Sub OneSampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsSimpleModelsOneSample.Click
        dlgOneSample.ShowDialog()
    End Sub

    Private Sub FrequencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsTablesFrequency.Click
        dlgFreqTables.ShowDialog()
    End Sub

    Private Sub SummaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuStatisticsTablesSummary.Click
        dlgSummaryTables.ShowDialog()
    End Sub

    Private Sub DuplicatecopyColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnTransform_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnTransform.Click
        dlgTransform.ShowDialog()
    End Sub

    Private Sub InteractionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgDummyVariables.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnPolynomials_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnPolynomials.Click
        dlgPolynomials.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeStack_Click(sender As Object, e As EventArgs) Handles mnuManageReshapeStack.Click
        dlgStack.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeUnstack_Click(sender As Object, e As EventArgs) Handles mnuManageReshapeUnstack.Click
        dlgUnstack.ShowDialog()
    End Sub

    Private Sub ChisquareTestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsSimpleModelsChisquareTest.Click
        dlgChiSquareTest.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnRecode_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnRecode.Click
        dlgRecode.ShowDialog()
    End Sub

    Private Sub EnterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgChangeType.ShowDialog()
    End Sub

    Private Sub RandomSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuManageDataRandomSamples.Click
        dlgRandomSample.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuManageDataView.Click
        dlgView.ShowDialog()
    End Sub

    Private Sub SelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuManageRechapeSubset.Click
        dlgSelect.ShowDialog()
    End Sub

    Private Sub SelectSndStackToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgSelectAndStuck.ShowDialog()
    End Sub

    Private Sub ExpandToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgExpand.ShowDialog()
    End Sub

    Private Sub FactorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgfactor.ShowDialog()
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgName.ShowDialog()
    End Sub

    Private Sub FormatCtrlDToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgFormat.ShowDialog()
    End Sub

    Private Sub AlignmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgAlignment.ShowDialog()
    End Sub

    Private Sub FactorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuManageFactor.Click
        dlgfactor.ShowDialog()
    End Sub
    Private Sub OrthogonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsAnalysisOfVarianceOrthogonal.Click
        dlgOrthogonal.ShowDialog()
    End Sub

    Private Sub OnewayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsAnalysisOfVarianceOneWay.Click
        dlgOneWayANOVA.ShowDialog()
    End Sub

    Private Sub SimpleWithGroupsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionSimpleWithGroups.Click
        dlgSimpleWithGroups.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionLogLinea_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionLogLinear.Click
        dlgGeneralisedLinearModels.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionLogLinear_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionLogLinear.Click
        dlglogLinearModels.ShowDialog()
    End Sub

    Private Sub OneAndTwoSamplesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuStatisticsNonParametricOneSample.Click
        dlgNon_ParametricOneSampleTests.ShowDialog()
    End Sub

    Private Sub mnuStatsNonParametricTwoWayAnova_Click_1(sender As Object, e As EventArgs) Handles mnuStatisticsNonParametricTwoWayAnova.Click
        dlgNon_ParametricTwoWayAnova.ShowDialog()
    End Sub

    Private Sub NewWorksheetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageNewWorksheet.Click
        dlgNewWorksheet.ShowDialog()
    End Sub

    Private Sub ImportDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageImportDailyData.Click

    End Sub

    Private Sub MakeFactorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageMakeFactor.Click
        dlgMakeFactor.ShowDialog()
    End Sub

    Private Sub ShiftDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageShiftDailyData.Click
        dlgShiftDailyData.ShowDialog()
    End Sub

    Private Sub UnstackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageUnstackDailyData.Click
        dlgUnstackDailyData.ShowDialog()
    End Sub

    Private Sub StackDailyDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageStackDailyData.Click
        dlgStackDailyData.ShowDialog()
    End Sub

    Private Sub InterpolateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageInterpolate.Click
        dlgInterpolate.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuClimaticManageOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub DisplayDailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClimaticDisplayDaily.Click
        dlgDisplayDaily.ShowDialog()
    End Sub

    Private Sub mnuClimaticSummary_Click(sender As Object, e As EventArgs) Handles mnuClimaticSummary.Click
        dlgSummary.ShowDialog()
    End Sub

    Private Sub mnuClimaticEventsExtremes_Click(sender As Object, e As EventArgs) Handles mnuClimaticEventsExtremes.Click
        dlgExtremes.ShowDialog()
    End Sub

    Private Sub mnuClimaticEventsSpells_Click(sender As Object, e As EventArgs) Handles mnuClimaticEventsSpells.Click
        dlgSpells.ShowDialog()
    End Sub

    Private Sub mnuClimaticEventsWaterBalance_Click(sender As Object, e As EventArgs) Handles mnuClimaticEventsWaterBalance.Click
        dlgWaterBalance.ShowDialog()
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

    Private Sub mnuStatisticsSimpleModelsTwoSample_Click(sender As Object, e As EventArgs) Handles mnuStatisticsSimpleModelsTwoSamples.Click
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

    Private Sub mnuManageDataSubset_Click(sender As Object, e As EventArgs)
        dlgSubset.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeSubset_Click(sender As Object, e As EventArgs) Handles mnuManageReshape.Click
        dlgSubset.ShowDialog()
    End Sub

    Private Sub mnuManageDataRename_Click(sender As Object, e As EventArgs) Handles mnuManageDataRename.Click
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuWindowVariable_Click(sender As Object, e As EventArgs) Handles mnuWindowVariable.Click
        If frmVariables.Visible = True Then
            frmVariables.Visible = False
        Else
            frmVariables.Visible = True
        End If
    End Sub

    Private Sub mnuWindowDataFrame_Click(sender As Object, e As EventArgs) Handles mnuWindowDataFrame.Click
        If frmMetaData.Visible = True Then
            frmMetaData.Visible = False
        Else
            frmMetaData.Visible = True
        End If
    End Sub

    Private Sub LogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogToolStripMenuItem.Click
        If frmLog.Visible = True Then
            frmLog.Visible = False
        Else
            frmLog.Visible = True
        End If
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptToolStripMenuItem.Click
        If frmScript.Visible = True Then
            frmScript.Visible = False
        Else
            frmScript.Visible = True
        End If
    End Sub

    Private Sub mnuManageReshapeMerge_Click(sender As Object, e As EventArgs) Handles mnuManageRechapeMerge.Click
        dlgMerge.ShowDialog()
    End Sub

    Private Sub mnuFileOptions_Click(sender As Object, e As EventArgs) Handles mnuFileOptions.Click
        dlgOptions.ShowDialog()
    End Sub

    Private Sub mnuWindowsCascading_Click(sender As Object, e As EventArgs) Handles mnuWindowsCascading.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowsStacked_Click(sender As Object, e As EventArgs) Handles mnuWindowsStacked.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWindowsSideBySide_Click(sender As Object, e As EventArgs) Handles mnuWindowsSideBySide.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub mnuWindowsArrangedIcons_Click(sender As Object, e As EventArgs) Handles mnuWindowsArrangedIcons.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub mnuWindowsEditor_Click(sender As Object, e As EventArgs) Handles mnuWindowsEditor.Click
        If frmEditor.Visible = True Then
            frmEditor.Visible = False
        Else
            frmEditor.Visible = True
        End If
    End Sub

    Private Sub mnuEditUndo_Click(sender As Object, e As EventArgs) Handles mnuEditUndo.Click
        'frmEditor.grdData.Undo()
    End Sub

    Private Sub mnuEditRedo_Click(sender As Object, e As EventArgs) Handles mnuEditRedo.Click
        'frmEditor.grdData.Redo()
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub

    Private Sub mnuFilePrintPreview_Click(sender As Object, e As EventArgs) Handles mnuFilePrintPreview.Click
        dlgPrintPreviewOptions.ShowDialog()
    End Sub



    Private Sub mnuManageAddColumnRank_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnRank.Click
        dlgRank.ShowDialog()
    End Sub

    Private Sub mnuClimateMethodsCreateClimateObject_Click(sender As Object, e As EventArgs) Handles mnuClimateMethodsCreateClimateObject.Click
        dlgCreateClimateObject.ShowDialog()
    End Sub

    Private Sub mnuExport_Click(sender As Object, e As EventArgs) Handles mnuExport.Click
        'For discussion
    End Sub

    Private Sub mnuManageDataFileSheetMetadata_Click(sender As Object, e As EventArgs) Handles mnuManageDataFileSheetMetadata.Click
        dlgSheetMetadata.ShowDialog()
    End Sub

    Private Sub mnuManageSheetColumnMetadata_Click(sender As Object, e As EventArgs) Handles mnuManageSheetColumnMetadata.Click
        frmVariables.Visible = True
        frmVariables.BringToFront()
    End Sub

    Private Sub mnuManageSheetInsertColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuManageSheetInsertColumnsRows.Click
        dlgInsertColumn.ShowDialog()
    End Sub
    Private Sub mnuGraphicsBarPie_Click(sender As Object, e As EventArgs) Handles mnuGraphicsBarPie.Click
        dlgBarAndPieChart.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnPermuteRows_Click(sender As Object, e As EventArgs) Handles mnuManageAddColumnPermuteColumn.Click
        dlgPermuteColumn.ShowDialog()
    End Sub

    Private Sub mnuGraphicsBarPieChartSummaryData_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuStatistcsMultivariateCorrelation_Click(sender As Object, e As EventArgs) Handles mnuStatistcsMultivariateCorrelation.Click
        dlgCorrelation.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileDeleteSheets_Click(sender As Object, e As EventArgs) Handles mnuManageDataFileDeleteSheets.Click
        dlgDeleteSheet.ShowDialog()
    End Sub

    Private Sub mnuManageSheetDeleteColumnsRows_Click(sender As Object, e As EventArgs) Handles mnuManageSheetDeleteColumnsRows.Click
        dlgDeleteRowsOrColums.ShowDialog()
    End Sub

    Private Sub EditLastDialogueToolStrip_Click(sender As Object, e As EventArgs) Handles EditLastDialogueToolStrip.Click
        If Not IsNothing(dlgLastDialog) Then
            dlgLastDialog.ShowDialog()
        End If
    End Sub

    Private Sub mnuTbNew_Click(sender As Object, e As EventArgs) Handles mnuTbNew.Click
        mnuFileNewDataFrame_Click(sender, e)
    End Sub

    Private Sub mnuTbOpen_Click(sender As Object, e As EventArgs) Handles mnuTbOpen.Click
        mnuFileOpenFromFile_Click(sender, e)
    End Sub

    Private Sub mnuTbImport_Click(sender As Object, e As EventArgs) Handles mnuTbImport.Click
        mnuFileOpenFromFile_Click(sender, e)
    End Sub

    Private Sub mnuTbSave_Click(sender As Object, e As EventArgs) Handles mnuTbSave.Click
        mnuFileSave_Click(sender, e)
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        dlgSaveAs.ShowDialog()
    End Sub

    Private Sub mnuTbPrint_Click(sender As Object, e As EventArgs) Handles mnuTbPrint.Click
        mnuFilePrint_Click(sender, e)
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, strStaticPath & strHelpFilePath)
    End Sub

    Private Sub mnuTbHelp_Click(sender As Object, e As EventArgs) Handles mnuTbHelp.Click
        mnuHelp_Click(sender, e)
    End Sub
    Private Sub mnuGraphicsBarPieChart_Click(sender As Object, e As EventArgs) Handles mnuGraphicsBarPieChart.Click
        dlgSummaryBarOrPieChart.ShowDialog()
    End Sub

    Private Sub mnuGraphicsScatterPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsScatterPlot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Public Sub addToMenu(ByVal dialog As Form)
        'Checks for existance, else add it to the beginning
        If mnuItems.Contains(dialog) Then mnuItems.Remove(dialog)
        'adds to the list
        mnuItems.Add(dialog)
        'checks that only 1o items are allowed
        While mnuItems.Count > 10
            mnuItems.RemoveAt(0)
        End While
        'updates the interface
        UpdateItemsMenu()
    End Sub

    Private Sub UpdateItemsMenu()
        'clears the menu items first
        Dim clsItems As New List(Of ToolStripItem)
        'creates a temp collection
        'will be identified by tag
        For Each clsMenu As ToolStripItem In mnuTbShowLast10.DropDownItems
            If Not clsMenu.Tag Is Nothing Then
                If (clsMenu.Tag.ToString().StartsWith("Last")) Then
                    clsItems.Add(clsMenu)
                End If
            End If
        Next
        'go through the list and remove each from the menu
        For Each clsMenu As ToolStripItem In clsItems
            mnuTbShowLast10.DropDownItems.Remove(clsMenu)
        Next
        'displays items (_in reverse order)
        For icounter As Integer = mnuItems.Count - 1 To 0 Step -1
            Dim dialog As Form = mnuItems(icounter)
            'creates new toolstripitem, displaying name of the dialog
            Dim clsItem As New ToolStripMenuItem(dialog.Text)
            'sets the tag
            clsItem.Tag = "Last"
            AddHandler clsItem.Click, AddressOf mnuFile_Click
            'insert into the dropdownitems
            mnuTbShowLast10.DropDownItems.Insert(mnuTbShowLast10.DropDownItems.Count - 1, clsItem)
        Next
        sepStart.Visible = True
        sepEnd.Visible = True
    End Sub

    Private Sub mnuFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each dfTemp As Form In mnuItems
            If dfTemp.Text = sender.ToString Then
                dfTemp.ShowDialog()
                Exit Sub
            End If
        Next
    End Sub

    Private Sub mnuStatistcsMultivariatePrincipalComponents_Click(sender As Object, e As EventArgs) Handles mnuStatistcsMultivariatePrincipalComponents.Click
        dlgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub mnuStatistcsMultivariateCanonicalCorrelations_Click(sender As Object, e As EventArgs) Handles mnuStatistcsMultivariateCanonicalCorrelations.Click
        dlgCanonicalCorrelationAnalysis.ShowDialog()
    End Sub

    Private Sub mnuManageFactorRecode_Click(sender As Object, e As EventArgs) Handles mnuManageFactorRecode.Click
        dlgRecode.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileCopySheet_Click(sender As Object, e As EventArgs) Handles mnuManageDataFileCopySheet.Click
        dlgCopySheet.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileReorderSheets_Click(sender As Object, e As EventArgs) Handles mnuManageDataFileReorderSheets.Click
        dlgReorderSheet.ShowDialog()
    End Sub

    Private Sub mnuManageDataFileRenameSheet_Click(sender As Object, e As EventArgs) Handles mnuManageDataFileRenameSheet.Click
        dlgRenameSheet.ShowDialog()
    End Sub

    Private Sub mnuManageRechapeColumnSummaries_Click(sender As Object, e As EventArgs) Handles mnuManageRechapeColumnSummaries.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuManageSheetReorder_Click(sender As Object, e As EventArgs) Handles mnuManageSheetReorder.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorReferenceLevels_Click(sender As Object, e As EventArgs) Handles mnuManageFactorReferenceLevels.Click
        dlgReferenceLevel.ShowDialog()
    End Sub

    Private Sub mnuMangeFactorLabel_Click(sender As Object, e As EventArgs) Handles mnuMangeFactorLabels.Click
        dlgLabels.ShowDialog()
    End Sub

    Private Sub mnuManageFactorconvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuManageFactorconvertToFactor.Click
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorReorderLevels_Click(sender As Object, e As EventArgs) Handles mnuManageFactorReorderLevels.Click
        dlgReorderLevels.ShowDialog()
    End Sub

    Private Sub mnuManageFactorUnusedLevels_Click(sender As Object, e As EventArgs) Handles mnuManageFactorUnusedLevels.Click
        dlgUnusedLevels.ShowDialog()
    End Sub

    Private Sub mnuManageSheetRestrict_Click(sender As Object, e As EventArgs)
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuManageSheetProtect_Click(sender As Object, e As EventArgs) Handles mnuManageSheetProtect.Click
        dlgProtect.ShowDialog()
    End Sub

    Private Sub mnuManageSheetHideShowColumns_Click(sender As Object, e As EventArgs) Handles mnuManageSheetHideShowColumns.Click
        dlgHideShowColumns.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeRandomSubst_Click(sender As Object, e As EventArgs) Handles mnuManageReshapeRandomSubset.Click
        dlgRandomSubset.ShowDialog()
    End Sub

    Private Sub mnuManageDataSort_Click(sender As Object, e As EventArgs) Handles mnuManageDataSort.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuManageAddColumnFilter_Click(sender As Object, e As EventArgs)
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesView_Click(sender As Object, e As EventArgs) Handles mnuManageDescriptivesView.Click
        dlgViewDescriptives.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesReoder_Click(sender As Object, e As EventArgs) Handles mnuManageDescriptivesReoder.Click
        dlgReoderDescriptives.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesRename_Click(sender As Object, e As EventArgs) Handles mnuManageDescriptivesRename.Click
        dlgRenameDescriptive.ShowDialog()
    End Sub

    Private Sub mnuManageDescriptivesDelete_Click(sender As Object, e As EventArgs) Handles mnuManageDescriptivesDelete.Click
        dlgDeleteDescriptive.ShowDialog()
    End Sub

    Private Sub mnuManageModelsView_Click(sender As Object, e As EventArgs) Handles mnuManageModelsView.Click
        dlgViewModels.ShowDialog()
    End Sub

    Private Sub mnuManageModelsReoder_Click(sender As Object, e As EventArgs) Handles mnuManageModelsReoder.Click
        dlgReoderModels.ShowDialog()
    End Sub

    Private Sub mnuManageModelsRename_Click(sender As Object, e As EventArgs) Handles mnuManageModelsRename.Click
        dlgRenameModels.ShowDialog()
    End Sub

    Private Sub mnuManageModelsDelete_Click(sender As Object, e As EventArgs) Handles mnuManageModelsDelete.Click
        dlgDeleteModels.ShowDialog()
    End Sub

    Private Sub mnuManageFactorContrasts_Click(sender As Object, e As EventArgs) Handles mnuManageFactorContrasts.Click
        dlgContrasts.ShowDialog()
    End Sub

    Private Sub mnuManageFactorSheet_Click(sender As Object, e As EventArgs) Handles mnuManageFactorSheet.Click
        dlgMakeSheets.ShowDialog()
    End Sub

    Private Sub mnuGraphicsUseGraph_Click(sender As Object, e As EventArgs) Handles mnuGraphicsUseGraph.Click
        dlgUseGraph.ShowDialog()
    End Sub

    Private Sub ManageDataCheck_Click(sender As Object, e As EventArgs) Handles ManageDataCheck.Click
        dlgCheckData.ShowDialog()
    End Sub

    Private Sub mnuManageTextSplit_Click(sender As Object, e As EventArgs) Handles mnuManageTextSplit.Click
        dlgSplitText.ShowDialog()
    End Sub

    Private Sub mnuManageTextCombine_Click(sender As Object, e As EventArgs) Handles mnuManageTextCombine.Click
        dlgCombineText.ShowDialog()
    End Sub

    Private Sub mnuManageTextMatch_Click(sender As Object, e As EventArgs) Handles mnuManageTextMatch.Click
        dlgMatchText.ShowDialog()
    End Sub

    Private Sub mnuManageTextDistance_Click(sender As Object, e As EventArgs) Handles mnuManageTextDistance.Click
        dlgDistanceText.ShowDialog()
    End Sub

    Private Sub mnuManageDataFilter_Click(sender As Object, e As EventArgs) Handles mnuManageDataFilter.Click
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuManageDataConvertTo_Click(sender As Object, e As EventArgs) Handles mnuManageDataConvertTo.Click
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuManageReshapeTranspose_Click(sender As Object, e As EventArgs) Handles mnuManageReshapeTranspose.Click
        dlgTransposeColumns.ShowDialog()
    End Sub

    Private Sub mnuManageFactorCombine_Click(sender As Object, e As EventArgs) Handles mnuManageFactorCombine.Click
        dlgCombine.ShowDialog()
    End Sub

    Private Sub mnuManageFactorDummyVariable_Click(sender As Object, e As EventArgs) Handles mnuManageFactorDummyVariable.Click
        dlgDummyVariables.ShowDialog()
    End Sub
End Class

