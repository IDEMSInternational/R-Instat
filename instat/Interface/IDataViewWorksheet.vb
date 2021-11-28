Public Interface IDataViewWorksheet2

    Event BeforeCellEdit(sender As Object, e As Object)
    Event AfterCellEdit(sender As Object, e As Object)
    Event BeforeCut(sender As Object, e As Object)
    Event BeforePaste(sender As Object, e As Object)
    Event BeforeRangeMove(sender As Object, e As Object)
    Event BeforeCellKeyDown(sender As Object, e As Object)
    Event CellDataChanged(sender As Object, e As Object)

    Property Name As String
    Property RowHeaders As List(Of Object) 'ToDo move to string list

    Sub SelectAll()


End Interface
