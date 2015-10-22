Public Class frmMain
    Dim clsRInterface As New RInterface
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmEditor.MdiParent = Me
        frmCommand.MdiParent = Me
        frmGraphics.MdiParent = Me
        frmLog.MdiParent = Me
        frmScript.MdiParent = Me
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
        frmCommand.Dock = DockStyle.Right
        frmEditor.Dock = DockStyle.Left
        frmCommand.Show()
        frmEditor.Show()

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportASCIIToolStripMenuItem.Click
        clsRInterface.LoadData()
        frmEditor.grid.CurrentWorksheet.SetCellData("A1", clsRInterface.GetData("data"))
    End Sub

    Private Sub DescribeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescribeToolStripMenuItem.Click
        dlgDescriptiveStatistics.Show()
    End Sub
End Class