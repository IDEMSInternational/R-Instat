
Imports RDotNet
Public Class frmEditor
    Public Sub UpdateSheet(DataSet As DataFrame)
        Me.grid.CurrentWorksheet.Reset()
        Me.grid.CurrentWorksheet.Rows = DataSet.RowCount
        Me.grid.CurrentWorksheet.Columns = DataSet.ColumnCount
        For k As Integer = 0 To DataSet.ColumnCount - 1
            Me.grid.CurrentWorksheet.ColumnHeaders(k).Text = DataSet.ColumnNames(k)
        Next
        For i As Integer = 0 To DataSet.RowCount - 1
            For k As Integer = 0 To DataSet.ColumnCount - 1
                Me.grid.CurrentWorksheet(row:=i, col:=k) = DataSet(i, k)
            Next
        Next
    End Sub
    Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grid.SheetTabControlWidth = 300
    End Sub
    Public Sub NewSheet()
        Dim sheet = grid.CreateWorksheet()
        'Add/Insert worksheet
        grid.Worksheets.Add(sheet)
        grid.CurrentWorksheet = sheet
    End Sub
End Class