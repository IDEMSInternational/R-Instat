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
        'frmGraphics.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
        frmCommand.Dock = DockStyle.Right
        'frmCommand.Dock = DockStyle.Fill
        frmEditor.Dock = DockStyle.Left
        frmEditor.Dock = DockStyle.Fill
        frmCommand.Show()
        frmEditor.Show()
        clsRInterface.SetLog(frmLog.txtLog)
        clsRInterface.SetOutput(frmCommand.txtCommand)
        tstatus.Text = frmEditor.grid.CurrentWorksheet.Name

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFIleIEASCII.Click
        clsRInterface.LoadData()
        Dim dataset As DataFrame = clsRInterface.GetData("data")
        frmEditor.grid.CurrentWorksheet.Rows = dataset.RowCount
        frmEditor.grid.CurrentWorksheet.Columns = dataset.ColumnCount
        For i As Integer = 0 To dataset.RowCount - 1
            For k As Integer = 0 To dataset.ColumnCount - 1
                frmEditor.grid.CurrentWorksheet.ColumnHeaders(k).Text = dataset.ColumnNames(k)
                frmEditor.grid.CurrentWorksheet(row:=i, col:=k) = dataset(i, k)
            Next
        Next
    End Sub

    Public Sub FillData(strDataName)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet
        Dim dfDataset As DataFrame

        dfDataset = clsRInterface.GetData(strDataName)
        For Each tempWorkSheet In frmEditor.grid.Worksheets
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
            tempWorkSheet = frmEditor.grid.Worksheets.Create(strDataName)
            tempWorkSheet.Rows = dfDataset.RowCount
            tempWorkSheet.Columns = dfDataset.ColumnCount
            For i As Integer = 0 To dfDataset.RowCount - 1
                For k As Integer = 0 To dfDataset.ColumnCount - 1
                    tempWorkSheet.ColumnHeaders(k).Text = dfDataset.ColumnNames(k)
                    tempWorkSheet(row:=i, col:=k) = dfDataset(i, k)
                Next
            Next
            frmEditor.grid.Worksheets.Add(tempWorkSheet)
        End If
    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        dlgDescriptiveStatistics.ShowDialog()
    End Sub

    Private Sub mnuFileOpenWorksheet_Click(sender As Object, e As EventArgs) Handles mnuFileOpenWorksheet.Click

    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

    End Sub

    Private Sub mnuBar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuBar.ItemClicked

    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuSriptLog_Click(sender As Object, e As EventArgs)
        frmLog.Show()
    End Sub

    Private Sub KiswahiliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KiswahiliToolStripMenuItem.Click
    End Sub

    Private Sub KiswahiliToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KiswahiliToolStripMenuItem1.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
        Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
        autoTranslate(Me)
    End Sub

    Private Sub WindroseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WindroseToolStripMenuItem.Click

    End Sub

    Private Sub ProbabilityPlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuGraphicsProbabilityPlot.Click
        dlgProbabilityPlot.ShowDialog()
    End Sub

    Private Sub ProbabilityDistributionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityDistributionsToolStripMenuItem.Click

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

    Private Sub RowStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RowStatisticsToolStripMenuItem.Click

    End Sub

    Private Sub mnuEditViewEditText_Click(sender As Object, e As EventArgs) Handles mnuEditViewEditText.Click

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

    Private Sub tstatus_Click(sender As Object, e As EventArgs) Handles tstatus.Click

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

    Private Sub mnuFileCloseWorksheet_Click(sender As Object, e As EventArgs) Handles mnuFileCloseWorksheet.Click

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
End Class