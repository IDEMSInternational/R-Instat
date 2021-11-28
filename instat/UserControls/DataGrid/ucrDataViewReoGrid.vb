Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class ucrDataViewReoGrid
    Implements IDataViewGrid

    Private _clsDataBook As clsDataBook

    Public Event WorksheetChanged() Implements IDataViewGrid.WorksheetChanged

    Public Event WorksheetRemoved(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.WorksheetRemoved

    Public Event ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String) Implements IDataViewGrid.ReplaceValueInData

    Public Event PasteValuesToDataframe() Implements IDataViewGrid.PasteValuesToDataframe

    Public Event CellDataChanged() Implements IDataViewGrid.CellDataChanged

    Public WriteOnly Property DataBook As clsDataBook Implements IDataViewGrid.DataBook
        Set(value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Private Property CurrentWorksheet As clsWorksheetAdapter Implements IDataViewGrid.CurrentWorksheet
        Get
            Return New clsWorksheetAdapter(grdData.CurrentWorksheet)
        End Get
        Set(value As clsWorksheetAdapter)
            grdData.CurrentWorksheet = grdData.Worksheets.Where(Function(x) x.Name = value.Name).FirstOrDefault
        End Set
    End Property

    Private Property IDataViewGrid_Visible As Boolean Implements IDataViewGrid.Visible
        Get
            Return Me.Visible
        End Get
        Set(value As Boolean)
            Me.Visible = value
        End Set
    End Property

    Private Property IDataViewGrid_Enabled As Boolean Implements IDataViewGrid.Enabled
        Get
            Return grdData.Enabled
        End Get
        Set(value As Boolean)
            grdData.Enabled = value
        End Set
    End Property

    Private Sub Worksheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs)
        RaiseEvent ReplaceValueInData(e.NewData.ToString(),
                           GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.Cell.Column).strName,
                           GetCurrentDataFrameFocus().clsVisiblePage.RowNames()(e.Cell.Row))
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
    End Sub

    Private Sub Worksheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs)
        e.IsCancelled = True
    End Sub

    Private Sub Worksheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs)
        e.IsCancelled = True 'prevents pasted data from being added directly into the data view
        'validate columns
        If e.Range.EndCol >= GetCurrentDataFrameFocus().clsVisiblePage.lstColumns.Count Then
            'this happens when Ctrl + V is pressed and the data to be pasted has more columns
            'than columns between start and end column
            MsgBox("Columns copied are more than the current data frame columns.", MsgBoxStyle.Critical, "Excess Columns")
            Exit Sub
        End If
        'TODO check see if pasted range is same as selected
        RaiseEvent PasteValuesToDataframe()
    End Sub

    Private Sub Worksheet_BeforeRangeMove(sender As Object, e As BeforeCopyOrMoveRangeEventArgs)
        ' Not currently working. Bug with reogrid reported here:
        ' https://reogrid.net/forum/viewtopic.php?id=350
        e.IsCancelled = True
    End Sub

    Private Sub Worksheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs)
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Private Sub Worksheet_CellDataChanged(sender As Object, e As CellEventArgs)
        RaiseEvent CellDataChanged()
    End Sub

    Public Sub SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip, rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip) Implements IDataViewGrid.SetContextmenuStrips
        grdData.ColumnHeaderContextMenuStrip = columnContextMenuStrip
        grdData.ContextMenuStrip = cellContextMenuStrip
        grdData.RowHeaderContextMenuStrip = rowContextMenuStrip
        grdData.SheetTabContextMenuStrip = tabContextMenuStrip
    End Sub

    Public Sub UpdateAllWorksheetStyles() Implements IDataViewGrid.UpdateAllWorksheetStyles
        For Each worksheet In grdData.Worksheets
            UpdateWorksheetStyle(worksheet)
        Next
    End Sub

    Private Sub UpdateWorksheetStyle(workSheet As Worksheet)
        workSheet.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName,
                                .TextColor = frmMain.clsInstatOptions.clrEditor,
                                .FontSize = frmMain.clsInstatOptions.fntEditor.Size,
                                .FontName = frmMain.clsInstatOptions.fntEditor.Name
                                })
    End Sub

    Public Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.UpdateWorksheetStyle
        UpdateWorksheetStyle(grdData.Worksheets.Where(Function(x) x.Name = worksheet.Name).FirstOrDefault)
    End Sub

    Public Sub AddColumns(visiblePage As clsDataFramePage) Implements IDataViewGrid.AddColumns
        Dim workSheetColumnHeader As ColumnHeader
        grdData.CurrentWorksheet.Columns = visiblePage.lstColumns.Count
        For i = 0 To visiblePage.lstColumns.Count - 1
            workSheetColumnHeader = grdData.CurrentWorksheet.ColumnHeaders(i)
            workSheetColumnHeader.Text = visiblePage.lstColumns(i).strDisplayName
            workSheetColumnHeader.TextColor = visiblePage.lstColumns(i).clsColour
            workSheetColumnHeader.Style.BackColor = visiblePage.lstColumns(i).clsBackGroundColour
        Next
    End Sub

    Private Sub AddBlankRow(workSheet As Worksheet)
        workSheet.Rows = 1
        For i = 0 To workSheet.Columns - 1
            workSheet(0, col:=i) = ""
        Next
        workSheet.SetRowsHeight(0, 1, 0.1)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, False)
        Exit Sub
    End Sub

    Private Sub UpdateWorksheetSettings(workSheet As Worksheet)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, True)
        workSheet.SetRowsHeight(0, 1, 20)
        Dim rngDataRange As New RangePosition(0, 0, workSheet.Rows, workSheet.Columns)
        workSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)
    End Sub

    Public Sub AddRowData(dataFrame As clsDataFrame) Implements IDataViewGrid.AddRowData
        Dim textColour As Color
        Dim strRowNames As String()

        If dataFrame.iDisplayedRowCount = 0 Then
            AddBlankRow(grdData.CurrentWorksheet)
            Exit Sub
        End If
        grdData.CurrentWorksheet.Rows = dataFrame.iDisplayedRowCount
        UpdateWorksheetSettings(grdData.CurrentWorksheet)

        If dataFrame.clsFilter.bApplied Then
            textColour = Color.Red
        Else
            textColour = Color.DarkBlue
        End If

        strRowNames = dataFrame.strRowNames()
        For i = 0 To grdData.CurrentWorksheet.Rows - 1
            For j = 0 To grdData.CurrentWorksheet.Columns - 1
                grdData.CurrentWorksheet(row:=i, col:=j) = dataFrame.Data(i, j)
            Next
            grdData.CurrentWorksheet.RowHeaders.Item(i).Text = strRowNames(i)
            grdData.CurrentWorksheet.RowHeaders(i).TextColor = textColour
        Next
    End Sub

    Public Sub RemoveOldWorksheets() Implements IDataViewGrid.RemoveOldWorksheets
        For i = grdData.Worksheets.Count - 1 To 0 Step -1
            Dim iGridWorkheetsPosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = grdData.Worksheets(index:=iGridWorkheetsPosition).Name).Count = 0 Then
                grdData.RemoveWorksheet(i)
            End If
        Next
    End Sub

    'Public Sub RefreshWorksheet(fillWorkSheet As clsWorksheetAdapter, dataFrame As clsDataFrame) Implements IDataViewGrid.RefreshWorksheet
    '    '  Throw New NotImplementedException()
    'End Sub

    'ToDo remove has should be able to go of property
    Public Function GetWorksheet(name As String) As clsWorksheetAdapter Implements IDataViewGrid.GetWorksheet
        Dim worksheet = grdData.Worksheets.Where(Function(x) x.Name = name).FirstOrDefault
        If worksheet IsNot Nothing Then
            Return New clsWorksheetAdapter(worksheet)
        Else
            Return Nothing
        End If
    End Function

    Public Function AddNewWorksheet(name As String) As clsWorksheetAdapter Implements IDataViewGrid.AddNewWorksheet
        Dim fillWorkSheet = grdData.CreateWorksheet(name)
        grdData.AddWorksheet(fillWorkSheet)
        fillWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        AttachEventsToWorksheet(fillWorkSheet)
        Return New clsWorksheetAdapter(fillWorkSheet)
    End Function

    Private Sub AttachEventsToWorksheet(worksheet As Worksheet)
        AddHandler worksheet.AfterCellEdit, AddressOf Worksheet_AfterCellEdit
        AddHandler worksheet.BeforeCut, AddressOf Worksheet_BeforeCut
        AddHandler worksheet.BeforePaste, AddressOf Worksheet_BeforePaste
        AddHandler worksheet.BeforeRangeMove, AddressOf Worksheet_BeforeRangeMove
        AddHandler worksheet.BeforeCellKeyDown, AddressOf Worksheet_BeforeCellKeyDown
        AddHandler worksheet.CellDataChanged, AddressOf Worksheet_CellDataChanged
    End Sub



    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(grdData.CurrentWorksheet.Name)
    End Function

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        RaiseEvent WorksheetRemoved(New clsWorksheetAdapter(e.Worksheet))
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, grdData.WorksheetInserted
        RaiseEvent WorksheetChanged()
    End Sub

    Public Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay) Implements IDataViewGrid.GetSelectedColumns
        Dim lstColumns As New List(Of clsColumnHeaderDisplay)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.Col + grdData.CurrentWorksheet.SelectionRange.Cols - 1
            lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(i))
        Next
        Return lstColumns
    End Function

    Public Function GetSelectedRows() As List(Of String) Implements IDataViewGrid.GetSelectedRows
        Dim lstSelectedRows As New List(Of String)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Row To grdData.CurrentWorksheet.SelectionRange.Row + grdData.CurrentWorksheet.SelectionRange.Rows - 1
            lstSelectedRows.Add(grdData.CurrentWorksheet.RowHeaders.Item(i).Text)
        Next
        Return lstSelectedRows
    End Function

    Private Sub ucrDataViewReoGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        grdData.SheetTabWidth = 450
    End Sub

    Public Sub SelectAll() Implements IDataViewGrid.SelectAll
        If grdData.CurrentWorksheet IsNot Nothing Then
            grdData.CurrentWorksheet.SelectAll()
        End If
    End Sub

    Public Function WorksheetCount() As Integer Implements IDataViewGrid.WorksheetCount
        Return grdData.Worksheets.Count
    End Function

    Public Sub SetCurrentDataFrame(strDataName As String) Implements IDataViewGrid.SetCurrentDataFrame
        Dim grdWorksheet As unvell.ReoGrid.Worksheet

        If grdData IsNot Nothing Then
            grdWorksheet = grdData.GetWorksheetByName(strDataName)
            If grdWorksheet IsNot Nothing Then
                grdData.CurrentWorksheet = grdWorksheet
            End If
        End If
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer) Implements IDataViewGrid.SetCurrentDataFrame
        If grdData IsNot Nothing Then
            If grdData.Worksheets.Count > iIndex Then
                grdData.CurrentWorksheet = grdData.Worksheets(iIndex)
            End If
        End If
    End Sub

    Public Sub CopyRange() Implements IDataViewGrid.CopyRange
        grdData.CurrentWorksheet.Copy()
    End Sub
End Class