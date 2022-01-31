' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public MustInherit Class ucrReoGrid
    Implements IGrid

    Protected _clsDataBook As clsDataBook

    Public Property CurrentWorksheet As clsWorksheetAdapter Implements IGrid.CurrentWorksheet
        Get
            Return New clsWorksheetAdapter(grdData.CurrentWorksheet)
        End Get
        Set(value As clsWorksheetAdapter)
            grdData.CurrentWorksheet = grdData.Worksheets.Where(Function(x) x.Name = value.Name).FirstOrDefault
        End Set
    End Property

    Public WriteOnly Property DataBook As clsDataBook Implements IGrid.DataBook
        Set(value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Private Property IGrid_Enabled As Boolean Implements IGrid.bEnabled
        Get
            Return grdData.Enabled
        End Get
        Set(value As Boolean)
            grdData.Enabled = value
        End Set
    End Property

    Private Property IGrid_Visible As Boolean Implements IGrid.bVisible
        Get
            Return Me.Visible
        End Get
        Set(value As Boolean)
            Me.Visible = value
            grdData.SheetTabWidth = 450
        End Set
    End Property

    Public Function AddNewWorksheet(name As String) As clsWorksheetAdapter Implements IGrid.AddNewWorksheet
        Dim fillWorkSheet = grdData.CreateWorksheet(name)
        grdData.AddWorksheet(fillWorkSheet)
        fillWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        AttachEventsToWorksheet(fillWorkSheet)
        Return New clsWorksheetAdapter(fillWorkSheet)
    End Function

    Public Sub CopyRange() Implements IGrid.CopyRange
        grdData.CurrentWorksheet.Copy()
    End Sub

    Public Function GetSelectedRows() As List(Of String) Implements IGrid.GetSelectedRows
        Dim lstSelectedRows As New List(Of String)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Row To grdData.CurrentWorksheet.SelectionRange.Row + grdData.CurrentWorksheet.SelectionRange.Rows - 1
            lstSelectedRows.Add(grdData.CurrentWorksheet.RowHeaders.Item(i).Text)
        Next
        Return lstSelectedRows
    End Function

    Public Function GetWorksheet(name As String) As clsWorksheetAdapter Implements IGrid.GetWorksheet
        Dim worksheet = grdData.Worksheets.Where(Function(x) x.Name = name).FirstOrDefault
        If worksheet IsNot Nothing Then
            Return New clsWorksheetAdapter(worksheet)
        End If
        Return Nothing
    End Function

    Public Sub RemoveOldWorksheets() Implements IGrid.RemoveOldWorksheets
        ' Flag to say if a sheet has been deleted.
        Dim bDeleted As Boolean = False
        For i = grdData.Worksheets.Count - 1 To 0 Step -1
            Dim iGridWorkheetsPosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = grdData.Worksheets(iGridWorkheetsPosition).Name).Count = 0 Then
                grdData.RemoveWorksheet(i)
                bDeleted = True
            End If
        Next
        ' Force the grid to refresh if a sheet has been deleted as there is sometimes a UI problem otherwise.
        ' There may be a better way to force a refresh. Disable/Enable is almost unnoticeable.
        ' Could investigate why this issue doesn't happen in ucrDataView.
        If bDeleted Then
            grdData.Enabled = False
            grdData.Enabled = True
        End If
    End Sub

    Public Sub SelectAll() Implements IGrid.SelectAll
        If grdData.CurrentWorksheet IsNot Nothing Then
            grdData.CurrentWorksheet.SelectAll()
        End If
    End Sub

    Public Sub SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip, rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip) Implements IGrid.SetContextmenuStrips
        grdData.ColumnHeaderContextMenuStrip = columnContextMenuStrip
        grdData.ContextMenuStrip = cellContextMenuStrip
        grdData.RowHeaderContextMenuStrip = rowContextMenuStrip
        grdData.SheetTabContextMenuStrip = tabContextMenuStrip
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String) Implements IGrid.SetCurrentDataFrame
        Dim grdWorksheet As unvell.ReoGrid.Worksheet

        If grdData IsNot Nothing Then
            grdWorksheet = grdData.GetWorksheetByName(strDataName)
            If grdWorksheet IsNot Nothing Then
                grdData.CurrentWorksheet = grdWorksheet
            End If
        End If
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer) Implements IGrid.SetCurrentDataFrame
        If grdData IsNot Nothing Then
            If grdData.Worksheets.Count > iIndex Then
                grdData.CurrentWorksheet = grdData.Worksheets(iIndex)
            End If
        End If
    End Sub

    Public Sub UpdateAllWorksheetStyles() Implements IGrid.UpdateAllWorksheetStyles
        For Each worksheet In grdData.Worksheets
            UpdateWorksheetStyle(worksheet)
        Next
    End Sub

    Public Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter) Implements IGrid.UpdateWorksheetStyle
        UpdateWorksheetStyle(grdData.Worksheets.Where(Function(x) x.Name = worksheet.Name).FirstOrDefault)
    End Sub

    Protected MustOverride Sub AttachEventsToWorksheet(Worksheet As Worksheet)

    Protected Sub Worksheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs)
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Protected Sub Worksheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs)
        e.IsCancelled = True
    End Sub

    Protected Sub Worksheet_BeforeRangeMove(sender As Object, e As BeforeCopyOrMoveRangeEventArgs)
        ' Not currently working. Bug with reogrid reported here:
        ' https://reogrid.net/forum/viewtopic.php?id=350
        e.IsCancelled = True
    End Sub

    Private Function GetCellValue(iRow As Integer, strColumn As String) As String Implements IGrid.GetCellValue
        For i As Integer = 0 To grdData.CurrentWorksheet.ColumnCount - 1
            If grdData.CurrentWorksheet.ColumnHeaders(i).Text = strColumn Then
                Return grdData.CurrentWorksheet(iRow, i).ToString()
            End If
        Next
        Return ""
    End Function

    Private Sub UpdateWorksheetStyle(workSheet As Worksheet)
        If frmMain.clsInstatOptions IsNot Nothing Then
            workSheet.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName,
                                .TextColor = frmMain.clsInstatOptions.clrEditor,
                                .FontSize = frmMain.clsInstatOptions.fntEditor.Size,
                                .FontName = frmMain.clsInstatOptions.fntEditor.Name
                                })
        End If

    End Sub

    Private Sub ucrReoGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdData.SheetTabWidth = 450
    End Sub
End Class