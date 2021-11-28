Public Interface IDataViewGrid

    Event WorksheetChanged()

    Event WorksheetRemoved(worksheet As clsWorksheetAdapter)

    Event ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String)

    Event PasteValuesToDataframe()

    Event CellDataChanged()

    Property Visible() As Boolean
    Property Enabled() As Boolean

    WriteOnly Property DataBook As clsDataBook

    Property CurrentWorksheet As clsWorksheetAdapter

    Sub SetCurrentDataFrame(strDataName As String)
    Sub SetCurrentDataFrame(iIndex As Integer)


    Sub SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip,
                                    rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip)

    Sub UpdateAllWorksheetStyles()

    Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter)

    Sub AddColumns(visiblePage As clsDataFramePage)

    Sub AddRowData(dataFrame As clsDataFrame)

    Function GetWorksheet(name As String) As clsWorksheetAdapter

    Function AddNewWorksheet(name As String) As clsWorksheetAdapter

    '   Sub AddAndUpdateWorksheets(grdData)
    Sub RemoveOldWorksheets()

    Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay)

    Function GetSelectedRows() As List(Of String)

    ' Sub RefreshWorksheet(fillWorkSheet As clsWorksheetAdapter, dataFrame As clsDataFrame)

    Sub SelectAll()

    Function WorksheetCount() As Integer

    Sub CopyRange()


End Interface