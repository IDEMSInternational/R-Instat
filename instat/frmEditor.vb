Public Class frmEditor
    Public Sub UpdateSheet()
        Dim dataset As DataFrame = frmMain.clsRInterface.GetData("data")
        Me.grid.CurrentWorksheet.Rows = dataset.RowCount
        Me.grid.CurrentWorksheet.Columns = dataset.ColumnCount
        For i As Integer = 0 To dataset.RowCount - 1
            For k As Integer = 0 To dataset.ColumnCount - 1
                Me.grid.CurrentWorksheet.ColumnHeaders(k).Text = dataset.ColumnNames(k)
                Me.grid.CurrentWorksheet(row:=i, col:=k) = dataset(i, k)
            Next
        Next
        Me.Refresh()
    End Sub
    Public Sub NewSheet()
        Dim sheet = grid.CreateWorksheet()
        'Add/Insert worksheet
        grid.Worksheets.Add(sheet)
        grid.CurrentWorksheet = sheet
    End Sub

End Class