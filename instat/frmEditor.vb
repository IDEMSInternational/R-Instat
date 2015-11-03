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