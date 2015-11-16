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
Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class frmMain

    Public clsRInterface As New RInterface

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEditor.MdiParent = Me
        frmCommand.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
        frmCommand.Dock = DockStyle.Right
        frmEditor.Dock = DockStyle.Left
        frmEditor.Dock = DockStyle.Fill
        frmCommand.Show()
        frmEditor.Show()
        clsRInterface.SetLog(frmLog.txtLog)
        clsRInterface.SetOutput(frmCommand.txtCommand)
        tstatus.Text = frmEditor.gridColumns.CurrentWorksheet.Name

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFIleIEASCII.Click
        'clsRInterface.LoadData()
        'Dim dataset As DataFrame = clsRInterface.GetData("data")
        'frmEditor.grid.CurrentWorksheet.Rows = dataset.RowCount
        'frmEditor.grid.CurrentWorksheet.Columns = dataset.ColumnCount
        'For i As Integer = 0 To dataset.RowCount - 1
        '    For k As Integer = 0 To dataset.ColumnCount - 1
        '        frmEditor.grid.CurrentWorksheet.ColumnHeaders(k).Text = dataset.ColumnNames(k)
        '        frmEditor.grid.CurrentWorksheet(row:=i, col:=k) = dataset(i, k)
        '    Next
        'Next
        clsRInterface.LoadData()
        clsRInterface.InstatObject()
        Dim holder As Tuple(Of DataFrame, DataFrame, DataFrame) = clsRInterface.getInstatObject("data")
        FillSheet(holder.Item1)
        FillMetaData(holder.Item2)
        FillVariables(holder.Item3)
    End Sub

    Public Sub FillData(strDataName)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet
        Dim dfDataset As DataFrame

        dfDataset = clsRInterface.GetData(strDataName)
        For Each tempWorkSheet In frmEditor.gridColumns.Worksheets
            If tempWorkSheet.Name = strDataName Then
                tempWorkSheet.Rows = dfDataset.RowCount
                tempWorkSheet.Columns = dfDataset.ColumnCount
                For i As Integer = 0 To dfDataset.RowCount - 1
                    For k As Integer = 0 To dfDataset.ColumnCount - 1
                        tempWorkSheet.ColumnHeaders(k).Text = dfDataset.ColumnNames(k)
                        tempWorkSheet(row:=i, col:=k) = dfDataset(i, k)
                    Next
                Next
                bFoundWorksheet = True
            End If
        Next
        If Not bFoundWorksheet Then
            tempWorkSheet = frmEditor.gridColumns.Worksheets.Create(strDataName)
            tempWorkSheet.Rows = dfDataset.RowCount
            tempWorkSheet.Columns = dfDataset.ColumnCount
            For i As Integer = 0 To dfDataset.RowCount - 1
                For k As Integer = 0 To dfDataset.ColumnCount - 1
                    tempWorkSheet.ColumnHeaders(k).Text = dfDataset.ColumnNames(k)
                    tempWorkSheet(row:=i, col:=k) = dfDataset(i, k)
                Next
            Next
            frmEditor.gridColumns.Worksheets.Add(tempWorkSheet)
        End If
    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        dlgDescriptiveStatistics.ShowDialog()
    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuSriptLog_Click(sender As Object, e As EventArgs)
        frmLog.ShowDialog()
    End Sub

    Private Sub KiswahiliToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KiswahiliToolStripMenuItem1.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
        autoTranslate(Me)
    End Sub

    Private Sub ProbabilityPlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGraphicsProbabilityPlot.Click
        dlgProbabilityPlot.ShowDialog()
    End Sub

    Private Sub FrenchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrenchToolStripMenuItem.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
        autoTranslate(Me)
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
        autoTranslate(Me)
    End Sub

    Private Sub mnuFileNewWorksheet_Click(sender As Object, e As EventArgs) Handles mnuFileNewWorksheet.Click
        frmEditor.NewSheet()
    End Sub

    Private Sub LogWindowMenu_Click(sender As Object, e As EventArgs) Handles LogWindowMenu.Click
        If frmLog.Visible = True Then
            frmLog.Visible = False
        Else
            frmLog.Visible = True
        End If
    End Sub

    Private Sub StartOfTheRainsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartOfTheRainsToolStripMenuItem.Click
        dlgStartofRains.ShowDialog()
    End Sub

    Private Sub RegularSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularSequenceToolStripMenuItem.Click
        dlgRegularSequence.ShowDialog()
    End Sub

    Private Sub mnuCalculations_Click(sender As Object, e As EventArgs) Handles mnuCalculations.Click
        dlgCalculator.ShowDialog()
    End Sub

    Private Sub mnuBoxPlot_Click(sender As Object, e As EventArgs) Handles mnuBoxPlot.Click
        dlgBoxPlot.ShowDialog()
    End Sub

    Private Sub mnuEndofRains_Click(sender As Object, e As EventArgs) Handles mnuEndofRains.Click
        dlgEndofRains.ShowDialog()
    End Sub

    Private Sub mnuGraphicsInventory_Click(sender As Object, e As EventArgs) Handles mnuGraphicsInventory.Click
        dlgInventoryPlot.ShowDialog()
    End Sub

    Private Sub mnuStatisticsRegressionMultiple_Click(sender As Object, e As EventArgs) Handles mnuStatisticsRegressionMultiple.Click
        dlgMultipleRegression.ShowDialog()
    End Sub

    Private Sub mnuGraphicsPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsPlot.Click
        dlgPlot.ShowDialog()
    End Sub

    Private Sub mnuGraphicsHistogram_Click(sender As Object, e As EventArgs) Handles mnuGraphicsHistogram.Click
        dlgHistogram.ShowDialog()
    End Sub

    Private Sub StemAndLeafToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StemAndLeafToolStripMenuItem.Click
        dlgStemAndLeaf.ShowDialog()
    End Sub

    Private Sub mnuGraphisDotPlot_Click(sender As Object, e As EventArgs) Handles mnuGraphisDotPlot.Click
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
    Public Sub FillSheet(df)
        frmEditor.gridColumns.CurrentWorksheet.Rows = df.RowCount
        frmEditor.gridColumns.CurrentWorksheet.Columns = df.ColumnCount
        For i As Integer = 0 To df.RowCount - 1
            For k As Integer = 0 To df.ColumnCount - 1
                frmEditor.gridColumns.CurrentWorksheet.ColumnHeaders(k).Text = df.ColumnNames(k)
                frmEditor.gridColumns.CurrentWorksheet(row:=i, col:=k) = df(i, k)
            Next
        Next
    End Sub
    Public Sub FillMetaData(df)
        'Dim temp As RDotNet.SymbolicExpression
        'Dim temp_str As String
        'For i As Integer = 0 To df.RowCount - 1
        '    For k As Integer = 0 To df.ColumnCount - 1
        '        temp_str = df(i, k)
        '        frmMetaData.txtMetadata.Text = temp_str
        '        'frmMetaData.txtMetadata.Text = String.Format("{0}", df(i, k))
        '    Next
        'Next

        frmMetaData.gridMetaData.CurrentWorksheet.Rows = df.RowCount
        frmMetaData.gridMetaData.CurrentWorksheet.Columns = df.ColumnCount
        For i As Integer = 0 To df.RowCount - 1
            For k As Integer = 0 To df.ColumnCount - 1
                frmMetaData.gridMetaData.CurrentWorksheet.ColumnHeaders(k).Text = df.ColumnNames(k)
                frmMetaData.gridMetaData.CurrentWorksheet(row:=i, col:=k) = df(i, k)
            Next
        Next
    End Sub

    Public Sub FillVariables(df)
        frmVariables.gridVariables.CurrentWorksheet.Rows = df.RowCount
        frmVariables.gridVariables.CurrentWorksheet.Columns = df.ColumnCount
        For i As Integer = 0 To df.RowCount - 1
            For k As Integer = 0 To df.ColumnCount - 1
                frmVariables.gridVariables.CurrentWorksheet.ColumnHeaders(k).Text = df.ColumnNames(k)
                frmVariables.gridVariables.CurrentWorksheet(row:=i, col:=k) = df(i, k)
            Next
        Next
    End Sub

    Private Sub mnuWindowMetadata_Click(sender As Object, e As EventArgs)
        frmMetaData.ShowDialog()
    End Sub

    Private Sub mnuWindowVariables_Click(sender As Object, e As EventArgs)
        frmVariables.ShowDialog()
    End Sub

    Private Sub mnuManageWorksheetInformation_Click(sender As Object, e As EventArgs) Handles mnuManageWorksheetInformation.Click
        If frmVariables.Visible = True Then
            frmVariables.Visible = False
        Else
            frmVariables.Visible = True
        End If
    End Sub

    Private Sub mnuManageLogWindow_Click(sender As Object, e As EventArgs) Handles mnuManageLogWindow.Click
        If frmLog.Visible = True Then
            frmLog.Visible = False
        Else
            frmLog.Visible = True
        End If
    End Sub

    Private Sub mnuManageScriptWindow_Click(sender As Object, e As EventArgs) Handles mnuManageScriptWindow.Click
        If frmScript.Visible = True Then
            frmScript.Visible = False
        Else
            frmScript.Visible = True
        End If
    End Sub

    Private Sub mnuManageWorksheetMetadata_Click(sender As Object, e As EventArgs) Handles mnuManageWorksheetMetadata.Click
        If frmMetaData.Visible = True Then
            frmMetaData.Visible = False
        Else
            frmMetaData.Visible = True
        End If
    End Sub

    Private Sub mnuClmateMethodThreeSummaries_Click(sender As Object, e As EventArgs) Handles mnuClmateMethodThreeSummaries.Click
        dlgThreeSummaries.ShowDialog()
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub StartOfRainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartOfRainToolStripMenuItem.Click
        dlgAddStartRain.ShowDialog()
    End Sub

    Private Sub EndOfRainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndOfRainToolStripMenuItem.Click
        dlgEndRain.ShowDialog()
    End Sub

    Private Sub ChangeFormatDayMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFormatDayMonthToolStripMenuItem.Click
        dlgChangeFormatDayMonth.ShowDialog()
    End Sub

    Private Sub ExportCPTToTabularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportCPTToTabularToolStripMenuItem.Click
        dlgCPTtoTabularData.ShowDialog()
    End Sub

    Private Sub DayMonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayMonthToolStripMenuItem.Click
        dlgDayMonth.ShowDialog()

    End Sub

    Private Sub DisplayDailyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisplayDailyToolStripMenuItem1.Click
        dlgDisplayDaily.ShowDialog()
    End Sub

    Private Sub DisplayDOYOfYearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayDOYOfYearToolStripMenuItem.Click
        dlgDisplayDOYofYear.ShowDialog()
    End Sub

    Private Sub DisplayRainRunningTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayRainRunningTotalToolStripMenuItem.Click
        dlgDisplayRainRunningTotal.ShowDialog()
    End Sub

    Private Sub DisplaySpellLengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySpellLengthToolStripMenuItem.Click
        dlgDisplaySpellLength.ShowDialog()
    End Sub

    Private Sub ExportForPICSAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportForPICSAToolStripMenuItem.Click
        dlgExportforPICSA.ShowDialog()
    End Sub

    Private Sub ExtremeEventsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtremeEventsToolStripMenuItem.Click
        dlgExtremeEvents.ShowDialog()
    End Sub

    Private Sub MissingDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MissingDataToolStripMenuItem.Click
        dlgMissingData.ShowDialog()
    End Sub

    Private Sub MissingDataTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MissingDataTableToolStripMenuItem.Click
        dlgMissingDataTable.ShowDialog()
    End Sub

    Private Sub MonthlySummariesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlySummariesToolStripMenuItem.Click
        dlgMonthlySummaries.ShowDialog()
    End Sub

    Private Sub OutputForCDTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputForCDTToolStripMenuItem.Click
        dlgOutputforCDT.ShowDialog()
    End Sub

    Private Sub OutputForCPTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputForCPTToolStripMenuItem.Click
        dlgOutputforCPT.ShowDialog()
    End Sub

    Private Sub RainsStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RainsStatisticsToolStripMenuItem.Click
        dlgRainStats.ShowDialog()
    End Sub

    Private Sub SeasonalSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeasonalSummaryToolStripMenuItem.Click
        dlgSeasonalSummary.ShowDialog()
    End Sub

    Private Sub SeasonalSummaryRainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeasonalSummaryRainToolStripMenuItem.Click
        dlgSeasonalSummaryRain.ShowDialog()
    End Sub

    Private Sub mnuStatsNonParametricOneWayAnova_Click(sender As Object, e As EventArgs) Handles mnuStatsNonParametricOneWayAnova.Click
        dlgOneWayAnova.ShowDialog()
    End Sub

    Private Sub mnuStatsNonParametricTwoWayAnova_Click(sender As Object, e As EventArgs)
        dlgTwoWayAnova.ShowDialog()
    End Sub

    Private Sub mnuStatsSummaryColumnStat_Click(sender As Object, e As EventArgs) Handles mnuStatsSummaryColumnStat.Click
        dlgColumnStats.ShowDialog()
    End Sub

    Private Sub mnuManageManipulateRowStat_Click(sender As Object, e As EventArgs) Handles mnuManageManipulateRowStat.Click
        dlgRowStats.ShowDialog()
    End Sub

    Private Sub mnuGraphicsScatterplot_Click(sender As Object, e As EventArgs) Handles mnuGraphicsScatterplot.Click
        dlgScatterPlot.ShowDialog()
    End Sub

    Private Sub mnuStatsRegressionSimple_Click(sender As Object, e As EventArgs) Handles mnuStatsRegressionSimple.Click
        dlgRegressionSimple.ShowDialog()
    End Sub

    Private Sub mnuManageDataSort_Click(sender As Object, e As EventArgs) Handles mnuManageDataSort.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub OneSampleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OneSampleToolStripMenuItem.Click
        dlgOneSample.ShowDialog()
    End Sub
End Class