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

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFIleIEASCII.Click
        clsRInterface.LoadData()
        Dim dataset As DataFrame = clsRInterface.GetData("data")
        'frmEditor.grid.CurrentWorksheet.SetCellData("A1", clsRInterface.GetData("data"))
        frmEditor.grid.CurrentWorksheet.Rows = dataset.RowCount
        frmEditor.grid.CurrentWorksheet.Columns = dataset.ColumnCount
        For i As Integer = 0 To dataset.RowCount - 1
            For k As Integer = 0 To dataset.ColumnCount - 1
                frmEditor.grid.CurrentWorksheet.ColumnHeaders(k).Text = dataset.ColumnNames(k)
                frmEditor.grid.CurrentWorksheet(row:=i, col:=k) = dataset(i, k)
            Next
        Next
    End Sub



    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        dlgDescriptiveStatistics.Show()
    End Sub

    Private Sub mnuFileOpenWorksheet_Click(sender As Object, e As EventArgs) Handles mnuFileOpenWorksheet.Click

    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click

    End Sub

    Private Sub mnuBar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuBar.ItemClicked

    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        dlgSort.Show()
    End Sub

    Private Sub mnuSriptLog_Click(sender As Object, e As EventArgs) Handles mnuSriptLog.Click
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

    Private Sub ProbabilityPlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilityPlotToolStripMenuItem.Click

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
End Class