Imports RDotNet
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
        'frmCommand.Dock = DockStyle.Fill
        frmEditor.Dock = DockStyle.Left
        frmEditor.Dock = DockStyle.Fill
        frmCommand.Show()
        frmEditor.Show()

    End Sub

    Private Sub ImportASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportASCIIToolStripMenuItem.Click
        clsRInterface.LoadData()
        Dim dataset As DataFrame = clsRInterface.GetData("data")
        'frmEditor.grid.CurrentWorksheet.SetCellData("A1", clsRInterface.GetData("data"))
        'frmEditor.grid.CurrentWorksheet.Rows = dataset.RowCount
        'frmEditor.grid.CurrentWorksheet.Columns = dataset.ColumnCount
        For i As Integer = 0 To dataset.RowCount - 1
            For k As Integer = 0 To dataset.ColumnCount - 1
                frmEditor.grid.CurrentWorksheet.ColumnHeaders(k).Text = dataset.ColumnNames(k)
                frmEditor.grid.CurrentWorksheet(row:=i, col:=k) = dataset(i, k)
            Next
        Next
    End Sub
End Class