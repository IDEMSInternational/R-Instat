Imports System.Windows

Public Class ucrDataViewLinuxGrid
    Implements IDataViewGrid

    Private _columnContextMenuStrip As ContextMenuStrip
    Private _cellContextMenuStrip As ContextMenuStrip
    Private _rowContextMenuStrip As ContextMenuStrip
    Private _tabContextMenuStrip As ContextMenuStrip

    Private _clsDataBook As clsDataBook
    Private _currentDataFrame As clsDataFrame 'Do not use anywhere other than GetCurrentDataFrameFocus()


    Public Event RefreshDisplayInformation()

    Public Event WorksheetChanged() Implements IDataViewGrid.WorksheetChanged

    Public Event WorksheetRemoved(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.WorksheetRemoved

    Private Event IDataViewGrid_ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String) Implements IDataViewGrid.ReplaceValueInData

    Public Event PasteValuesToDataframe() Implements IDataViewGrid.PasteValuesToDataframe

    Public Event CellDataChanged() Implements IDataViewGrid.CellDataChanged


    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Private Property DataViewGridInterface_Visible As Boolean Implements IDataViewGrid.Visible
        Get
            Return Me.Visible
        End Get
        Set(value As Boolean)
            Me.Visible = value
        End Set
    End Property

    Private WriteOnly Property IDataViewGrid_DataBook As clsDataBook Implements IDataViewGrid.DataBook
        Set(value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Public Property CurrentWorksheet As clsWorksheetAdapter Implements IDataViewGrid.CurrentWorksheet
        Get
            Return New clsWorksheetAdapter(tcTabs.SelectedTab)
        End Get
        Set(value As clsWorksheetAdapter)
            For Each tabPage As TabPage In tcTabs.TabPages
                If tabPage.Text = value.Name Then
                    tcTabs.SelectedTab = tabPage
                    Exit For
                End If
            Next
        End Set
    End Property

    Private Property IDataViewGrid_Enabled As Boolean Implements IDataViewGrid.Enabled
        Get
            Return tcTabs.Enabled
        End Get
        Set(value As Boolean)
            tcTabs.Enabled = value
        End Set
    End Property


    Private Sub IDataViewGrid_SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip, rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip) Implements IDataViewGrid.SetContextmenuStrips
        _columnContextMenuStrip = columnContextMenuStrip
        _cellContextMenuStrip = cellContextMenuStrip
        _rowContextMenuStrip = rowContextMenuStrip
        '  tcTabs.ContextMenuStrip = tabContextMenuStrip
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        If _currentDataFrame Is Nothing Then
            _currentDataFrame = _clsDataBook.GetDataFrame(SelectedTab)
        ElseIf _currentDataFrame.strName IsNot SelectedTab() Then
            _currentDataFrame = _clsDataBook.GetDataFrame(SelectedTab)
        End If
        Return _currentDataFrame
    End Function


    Private Sub DataViewGridInterface_UpdateAllWorksheetStyles() Implements IDataViewGrid.UpdateAllWorksheetStyles
        For Each tabPage In tcTabs.TabPages
            UpdateWorksheetStyle(GetGrid(tabPage))
        Next
    End Sub

    Private Sub UpdateWorksheetStyle(dataGrid As DataGridView)
        Dim newFont As New Font(frmMain.clsInstatOptions.fntEditor, frmMain.clsInstatOptions.fntEditor.Size)
        dataGrid.Font = newFont
        dataGrid.BackColor = frmMain.clsInstatOptions.clrEditor
    End Sub

    Public Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.UpdateWorksheetStyle
        UpdateWorksheetStyle(GetGrid(worksheet.Name))
    End Sub


    Public Sub AddColumns(visiblePage As clsDataFramePage) Implements IDataViewGrid.AddColumns
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.Columns.Clear()
        For i = 0 To visiblePage.lstColumns.Count - 1
            Dim dataGridColumn As DataGridViewColumn = New DataGridViewColumn
            dataGridColumn.Name = visiblePage.lstColumns(i).strDisplayName
            dataGridColumn.CellTemplate = New DataGridViewTextBoxCell()
            dataGrid.Columns.Add(dataGridColumn)
        Next
    End Sub

    Public Sub AddRowData(dataFrame As clsDataFrame) Implements IDataViewGrid.AddRowData
        Dim dataGrid = GetDataGridFromSelectedTab()

        If dataFrame.clsFilter.bApplied Then
            dataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Red
        Else
            dataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
        End If

        Dim strRowNames = dataFrame.strRowNames()
        dataGrid.Rows.Clear()
        For i = 0 To dataFrame.iDisplayedRowCount - 1
            dataGrid.Rows.Add()
            dataGrid.Rows(i).HeaderCell.Value = strRowNames(i)
            For j = 0 To dataGrid.ColumnCount - 1
                dataGrid.Rows(i).Cells(j).Value = dataFrame.Data(i, j)
            Next
        Next
    End Sub

    Public Sub RemoveOldWorksheets() Implements IDataViewGrid.RemoveOldWorksheets
        For i = tcTabs.TabCount - 1 To 0 Step -1
            Dim iTabPagePosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = tcTabs.TabPages(index:=iTabPagePosition).Text).Count = 0 Then
                tcTabs.TabPages.Remove(tcTabs.TabPages(i))
            End If
        Next
    End Sub

    Public Function AddNewWorksheet(name As String) As clsWorksheetAdapter Implements IDataViewGrid.AddNewWorksheet
        Dim tab As New TabPage(name)
        tcTabs.TabPages.Add(tab)
        Dim dataGrid As New DataGridView
        tab.Controls.Add(dataGrid)
        dataGrid.Dock = DockStyle.Fill
        AttachEventsToDataGrid(dataGrid)
        dataGrid.ReadOnly = True

        tab.Tag = dataGrid
        Return New clsWorksheetAdapter(tab)

    End Function


    Private Sub AttachEventsToDataGrid(dataGrid As DataGridView)
        'ToDo Editing disabled so edit events wont work
        AddHandler dataGrid.CellEndEdit, AddressOf DataGridView_CellEndEdit
        AddHandler dataGrid.CellValueChanged, AddressOf DataGridView_CellValueChanged
        AddHandler dataGrid.KeyDown, AddressOf DataGridView_KeyDown

        AddHandler dataGrid.CellMouseClick, AddressOf dataGrid_CellMouseClick
        AddHandler dataGrid.RowHeaderMouseClick, AddressOf dataGrid_RowHeaderMouseClick
        AddHandler dataGrid.ColumnHeaderMouseClick, AddressOf dataGrid_ColumnHeaderMouseClick


        ' DataObject.AddPastingHandler(dataGrid, AddressOf DataGridView_Paste)
    End Sub

    Private Function IDataViewGrid_GetSelectedColumns() As List(Of clsColumnHeaderDisplay) Implements IDataViewGrid.GetSelectedColumns
        Dim lstColumns As New List(Of clsColumnHeaderDisplay)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        Dim selectedColumns As New List(Of Integer)
        For Each cell In dataGrid.SelectedCells
            If Not selectedColumns.Contains(cell.columnIndex) Then
                selectedColumns.Add(cell.columnIndex)
            End If
        Next

        For Each columnIndex In selectedColumns
            lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(columnIndex))
        Next
        Return lstColumns

        'For Each col As DataGridViewColumn In dataGrid.SelectedColumns
        '    lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(col.Index))
        'Next
        'Return lstColumns
    End Function

    Private Function IDataViewGrid_GetSelectedRows() As List(Of String) Implements IDataViewGrid.GetSelectedRows
        Throw New NotImplementedException()
    End Function
    Public Function GetSelectedRows() As List(Of String)
        Dim lstSelectedRows As New List(Of String)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        For Each row As DataGridViewRow In dataGrid.SelectedRows
            lstSelectedRows.Add(row.HeaderCell.Value)
        Next
        Return lstSelectedRows
    End Function

    Public Sub SelectAll() Implements IDataViewGrid.SelectAll
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.SelectAll()
    End Sub

    Public Function WorksheetCount() As Integer Implements IDataViewGrid.WorksheetCount
        Return tcTabs.TabPages.Count()
    End Function









    Public Function SelectedTab() As String
        If tcTabs.SelectedTab Is Nothing Then
            Return ""
        End If
        Return tcTabs.SelectedTab.Text
    End Function

    'Public Function GetSelectedTabColumnCount() As Integer
    '    Return dgvData.ColumnCount
    'End Function

    'Public Function GetSelectedTabSelectedColumnCount() As Integer
    '    Return dgvData.SelectedColumns.Count()
    'End Function



    'Public Function GetFirstSelectedRow() As String
    '    Return dgvData.SelectedRows.Item(0).HeaderCell.Value
    'End Function



    'Public Function GetLastSelectedRow() As String
    '    Return dgvData.SelectedRows.Item(dgvData.SelectedRows.Count - 1).HeaderCell.Value
    'End Function

    'Public Sub RefreshWorksheetTabs()
    '    Dim currentTab As String = SelectedTab()
    '    tcTabs.TabPages.Clear()
    '    For Each clsDataFrame In _clsDataBook.DataFrames
    '        tcTabs.TabPages.Add(clsDataFrame.strName)
    '    Next
    '    For Each tabPage As TabPage In tcTabs.TabPages
    '        If tabPage.Text = currentTab Then
    '            tcTabs.SelectedTab = tabPage
    '            Exit For
    '        End If
    '    Next

    '    If tcTabs.TabPages.Count > 0 And tcTabs.SelectedTab Is Nothing Then
    '        tcTabs.SelectedIndex = 1
    '    End If

    '    RefreshWorksheet()
    'End Sub

    'Public Sub RefreshMetaWorksheetTabs()
    '    Dim currentTab As String = SelectedTab()
    '    tcTabs.TabPages.Clear()
    '    For Each clsDataFrame In _clsDataBook.DataFrames
    '        tcTabs.TabPages.Add(clsDataFrame.strName)
    '    Next
    '    For Each tabPage As TabPage In tcTabs.TabPages
    '        If tabPage.Text = currentTab Then
    '            tcTabs.SelectedTab = tabPage
    '            Exit For
    '        End If
    '    Next

    '    If tcTabs.TabPages.Count > 0 And tcTabs.SelectedTab Is Nothing Then
    '        tcTabs.SelectedIndex = 1
    '    End If

    '    '  AddColumns()
    '    dgvData.Columns.Clear()
    '    For i = 0 To GetCurrentDataFrameFocus()?.clsColumnMetaData?.iColumnCount - 1
    '        Dim dataGridColumn As DataGridViewColumn = New DataGridViewColumn
    '        dataGridColumn.HeaderText = GetCurrentDataFrameFocus.clsColumnMetaData.strColumnName(i)
    '        dataGridColumn.CellTemplate = New DataGridViewTextBoxCell()
    '        dgvData.Columns.Add(dataGridColumn)
    '    Next

    '    '   AddRowData()

    '    dgvData.Rows.Clear()
    '    For i = 0 To GetCurrentDataFrameFocus()?.clsColumnMetaData.iRowCount - 1
    '        dgvData.Rows.Add()
    '        dgvData.Rows(i).HeaderCell.Value = GetCurrentDataFrameFocus.clsColumnMetaData.strRowName(i)
    '        For j = 0 To dgvData.ColumnCount - 1
    '            dgvData.Rows(i).Cells(j).Value = GetCurrentDataFrameFocus.clsColumnMetaData.Data(i, j)
    '        Next
    '    Next
    'End Sub

    Public Sub RefreshWorksheet()
        '   AddColumns()
        '   AddRowData()
    End Sub

    'Private Sub tcTabs_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If tcTabs.SelectedIndex = -1 Then
    '        Exit Sub
    '    End If
    '    RefreshWorksheet()
    '    RaiseEvent RefreshDisplayInformation()
    'End Sub

    Private Sub dataGrid_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        sender.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect
        If e.Button = MouseButtons.Right Then
            If sender.SelectedColumns.Count > 0 Then
                _columnContextMenuStrip.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dataGrid_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        sender.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        If e.Button = MouseButtons.Right Then
            If sender.SelectedRows.Count > 0 Then
                _rowContextMenuStrip.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right Then
            _cellContextMenuStrip.Show(Cursor.Position)
        End If
    End Sub

    Private Sub dgvData_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        ' dgvData.CancelEdit()
        '      ReplaceValueInData(dgvData.CurrentCell.Value.ToString(),
        '     GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.ColumnIndex).strName,
        '     GetCurrentDataFrameFocus().clsVisiblePage.RowName(e.RowIndex))
        'Here incase edit isn't succesful and R command is not run
        '    RefreshWorksheet()
        If somethingChanged Then
            somethingChanged = False
            ' ReplaceValueInData(dgvData.CurrentCell.Value.ToString(),
            'GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(dgvData.CurrentCell.ColumnIndex).strName,
            '     GetCurrentDataFrameFocus().clsVisiblePage.RowName(dgvData.CurrentCell.RowIndex))
            '  dgvData.CancelEdit()

        End If
    End Sub

    Private Sub dgvData_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        '   MsgBox("this")
    End Sub

    'Private Sub dgvData_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)
    '    'MsgBox("this")
    '    '      e.Cancel = True
    '    If dgvData.CurrentCell.Value <> e.FormattedValue And Not somethingChanged Then
    '        somethingChanged = True
    '        'ReplaceValueInData(dgvData.CurrentCell.Value.ToString(),
    '        '       GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(dgvData.CurrentCell.ColumnIndex).strName,
    '        '       GetCurrentDataFrameFocus().clsVisiblePage.RowName(dgvData.CurrentCell.RowIndex))
    '    End If
    '    somethingChanged = False
    '    '    dgvData.EndEdit()
    '    'If GetCurrentDataFrameFocus() IsNot Nothing Then
    '    '    ReplaceValueInData(e.FormattedValue.ToString(),
    '    '           GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.ColumnIndex).strName,
    '    '           GetCurrentDataFrameFocus().clsVisiblePage.RowName(e.RowIndex))
    '    'End If
    '    'dgvData.EndEdit()
    'End Sub

    Private somethingChanged As Boolean = False

    Private Sub dgvData_CellLeave(sender As Object, e As DataGridViewCellEventArgs)
        If somethingChanged Then
            'somethingChanged = False
            'ReplaceValueInData(dgvData.CurrentCell.Value.ToString(),
            '       GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.ColumnIndex).strName,
            '       GetCurrentDataFrameFocus().clsVisiblePage.RowName(e.RowIndex))

        End If
    End Sub

    Private Sub dgvData_Validated(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvData_CellValidated(sender As Object, e As DataGridViewCellEventArgs)
        If somethingChanged Then
            'somethingChanged = False
            'ReplaceValueInData(dgvData.CurrentCell.Value.ToString(),
            '       GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(dgvData.CurrentCell.ColumnIndex).strName,
            '       GetCurrentDataFrameFocus().clsVisiblePage.RowName(dgvData.CurrentCell.RowIndex))
            'dgvData.EndEdit()
        End If
    End Sub

    Private Sub dgvData_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs)

    End Sub

    Private Sub dgvData_CellValuePushed(sender As Object, e As DataGridViewCellValueEventArgs)

    End Sub





    'Public Sub AddAndUpdateWorksheets() Implements IDataViewGrid.AddAndUpdateWorksheets
    '    Dim currentTab As String = SelectedTab()
    '    tcTabs.TabPages.Clear()
    '    For Each clsDataFrame In _clsDataBook.DataFrames
    '        tcTabs.TabPages.Add(clsDataFrame.strName)
    '    Next
    '    For Each tabPage As TabPage In tcTabs.TabPages
    '        If tabPage.Text = currentTab Then
    '            tcTabs.SelectedTab = tabPage
    '            Exit For
    '        End If
    '    Next

    '    If tcTabs.TabPages.Count > 0 And tcTabs.SelectedTab Is Nothing Then
    '        tcTabs.SelectedIndex = 1
    '    End If
    'End Sub











    Private Function GetDataGridFromSelectedTab() As DataGridView
        Return CType(tcTabs.SelectedTab.Tag, DataGridView)
    End Function

    Public Function GetWorksheet(name As String) As clsWorksheetAdapter Implements IDataViewGrid.GetWorksheet
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = name Then
                Return New clsWorksheetAdapter(tabPage)
            End If
        Next
        Return Nothing
    End Function
    Private Function GetGrid(worksheetName As String) As DataGridView
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = worksheetName Then
                Return CType(tabPage.Tag, DataGridView)
            End If
        Next
        Return Nothing
    End Function

    Private Function GetGrid(tabPage As TabPage) As DataGridView
        Return CType(tabPage.Tag, DataGridView)
    End Function

    Private Sub DataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Dim dataGrid = GetDataGridFromSelectedTab()
        RaiseEvent IDataViewGrid_ReplaceValueInData(dataGrid.CurrentCell.Value.ToString(),
                        GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(dataGrid.CurrentCell.ColumnIndex).strName,
                        GetCurrentDataFrameFocus().clsVisiblePage.RowNames()(dataGrid.CurrentCell.RowIndex))
    End Sub

    Private Sub DataGridView_Paste(sender As Object, e As DataObjectPastingEventArgs)
        e.CancelCommand()
        'ToDo need to check columns
        'If e.SourceDataObject.GetData.Range.EndCol >= GetCurrentDataFrameFocus().clsVisiblePage.lstColumns.Count Then
        '    'this happens when Ctrl + V is pressed and the data to be pasted has more columns
        '    'than columns between start and end column
        '    MsgBox("Columns copied are more than the current data frame columns.", MsgBoxStyle.Critical, "Excess Columns")
        '    Exit Sub
        'End If
        'TODO check see if pasted range is same as selected
        RaiseEvent PasteValuesToDataframe()
    End Sub

    Private Sub DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        RaiseEvent CellDataChanged()
    End Sub

    Private Sub tcTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcTabs.SelectedIndexChanged
        RaiseEvent WorksheetChanged()
    End Sub

    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs)

        Dim ctrlV As Boolean = e.Modifiers = Keys.Control And e.KeyCode = Keys.V
        Dim shiftIns As Boolean = e.Modifiers = Keys.Shift And e.KeyCode = Keys.Insert

        If ctrlV Or shiftIns Then
            RaiseEvent PasteValuesToDataframe()
        End If
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String) Implements IDataViewGrid.SetCurrentDataFrame
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = strDataName Then
                tcTabs.SelectedTab = tabPage
            End If
        Next
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer) Implements IDataViewGrid.SetCurrentDataFrame
        If tcTabs.TabPages.Count > iIndex Then
            tcTabs.SelectedIndex = iIndex
        End If
    End Sub

    Public Sub CopyRange() Implements IDataViewGrid.CopyRange
        Dim dataGrid = GetDataGridFromSelectedTab()
        dataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Dim dataObj = dataGrid.GetClipboardContent()
        Clipboard.SetDataObject(dataObj, True)
    End Sub
End Class