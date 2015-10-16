Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoScript


Public Class frm_main
    Dim fileOpen As New rLink
    Private Sub frm_first_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid.SetSettings(WorkbookSettings.View_ShowSheetTabControl, True)
        grid.SheetTabControlWidth = 200
        frmScript.MdiParent = Me
        dlgGraphicsDialogTemplate.MdiParent = Me
        dlgDataSelectionTemplate.MdiParent = Me
        dlgDialogTemplate.MdiParent = Me
        'frmScript.Show()
        frmScript.editor.Srm = grid.Srm

    End Sub

    Private Sub OpenToolBtn_Click(sender As Object, e As EventArgs) Handles OpenToolBtn.Click
        fileOpen.open()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        fileOpen.open()
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim sheet = grid.CreateWorksheet()
    End Sub

    Private Sub mnuScriptEditor_Click(sender As Object, e As EventArgs) Handles mnuScriptEditor.Click
        frmScript.Show()
    End Sub

    Private Sub CalculationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculationsToolStripMenuItem.Click

    End Sub

    Private Sub GraphicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GraphicsToolStripMenuItem.Click


    End Sub

    Private Sub PlotToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotToolStripMenuItem.Click
        dlgGraphicsDialogTemplate.Show()

    End Sub

    Private Sub CurrentWindowCtrlWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrentWindowCtrlWToolStripMenuItem.Click

    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        dlgDescriptiveStatistics.Show()


    End Sub

    Private Sub ColumnStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnStatisticsToolStripMenuItem.Click

    End Sub

    Private Sub GraphicsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FontCtrlTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditFont.Click
        dlgDataSelectionTemplate.Show()
        dlgDialogTemplate.Show()



    End Sub

    Private Sub GraphicsToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)



    End Sub
End Class
