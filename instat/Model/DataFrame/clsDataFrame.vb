Imports RDotNet

Public Class clsDataFrame
    Private _clsPrepareFunctions As clsPrepareFunctionsForGrids
    Private _clsVisiblePage As clsDataFramePage
    Private _clsColumnMetaData As clsColumnMetaData
    Private _clsFilter As clsDataFrameFilter
    Protected _name As String
    Protected _RLink As RLink
    '  Protected _columnHeaders As List(Of clsColumnHeaderDisplay)
    Protected _totalRowCount As Integer
    Protected _totalColumnCount As Integer

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Filter() As clsDataFrameFilter
        Get
            Return _clsFilter
        End Get
    End Property
    Public ReadOnly Property clsPrepareFunctions As clsPrepareFunctionsForGrids
        Get
            Return _clsPrepareFunctions
        End Get
    End Property

    Public ReadOnly Property clsColumnMetaData As clsColumnMetaData
        Get
            Return _clsColumnMetaData
        End Get
    End Property

    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return _clsVisiblePage.Data(row, column)
        End Get
    End Property
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return _clsVisiblePage.RowName(row)
        End Get
    End Property
    Public ReadOnly Property DisplayedRowCount As Integer
        Get
            Return _clsVisiblePage.DisplayedRowCount
        End Get
    End Property
    Public ReadOnly Property TotalRowCount() As Integer
        Get
            Return _totalRowCount
        End Get
    End Property
    Public ReadOnly Property TotalColumnCount() As Integer
        Get
            Return _totalColumnCount
        End Get
    End Property



    'Public ReadOnly Property ColumnHeaders() As List(Of clsColumnHeaderDisplay)
    '    Get
    '        Return _columnHeaders
    '    End Get
    'End Property

    Public ReadOnly Property VisiblePage() As clsDataFramePage
        Get
            Return _clsVisiblePage
        End Get
    End Property

    Public Sub New(rLink As RLink, name As String)
        _RLink = rLink
        '_columnHeaders = New List(Of clsColumnHeaderDisplay)
        _name = name
        _clsPrepareFunctions = New clsPrepareFunctionsForGrids(rLink, name)
        _clsVisiblePage = New clsDataFramePage(rLink, name)
        _clsFilter = New clsDataFrameFilter(rLink, name)
        _clsColumnMetaData = New clsColumnMetaData(rLink, name)
    End Sub

    Private Function HasDataChanged() As Boolean
        Dim clsDataChanged As New RFunction
        Dim expTemp As SymbolicExpression

        clsDataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_data_changed")
        clsDataChanged.AddParameter("data_name", Chr(34) & _name & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsDataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    Public Sub RefreshData()

        ' _dataFrame = GetDataFrameFromRCommand()
        ' _clsVisablePage.RefreshData()
        If HasDataChanged() Then
            If _clsVisiblePage.RefreshData() Then
                _totalRowCount = _RLink.GetDataFrameLength(_name, False)
                _totalColumnCount = _RLink.GetDataFrameColumnCount(_name)
                _clsVisiblePage.CreatePages(_totalColumnCount, _totalRowCount)
                _clsFilter.RefreshData()

                '    SetHeaders()

                'Not sure what to do here
                'ucrDataViewer.SetColumnNames(strDataName, dfTemp.ColumnNames())

                ResetDataFramesChanged()
            End If
        End If
        _clsColumnMetaData.RefreshData()
    End Sub

    Private Sub ResetDataFramesChanged()
        Dim clsSetDataFramesChanged As New RFunction
        clsSetDataFramesChanged.SetRCommand(_RLink.strInstatDataObject & "$set_data_frames_changed")
        clsSetDataFramesChanged.AddParameter("data_name", Chr(34) & _name & Chr(34))
        clsSetDataFramesChanged.AddParameter("new_val", "FALSE")
        _RLink.RunInternalScript(clsSetDataFramesChanged.ToScript(), bSilent:=True)
    End Sub

    'Protected Overridable Sub SetHeaders()
    '    Dim lstColumnNames As List(Of String)
    '    lstColumnNames = _dataFrame.ColumnNames.ToList
    '    For i = 0 To lstColumnNames.Count - 1
    '        _columnHeaders.Add(New clsColumnHeaderRecord(name:=lstColumnNames(i), colour:=Color.DarkBlue, backgroundColour:=Nothing))
    '    Next
    'End Sub








    Protected Sub FillData()
        Dim clsSetDataFramesChanged As New RFunction
        clsSetDataFramesChanged.SetRCommand(_RLink.strInstatDataObject & "$set_data_frames_changed")
        ' _dataFrame = GetDataFrameFromRCommand()
        ' _clsVisablePage.RefreshData()
        If _clsVisiblePage.RefreshData() Then
            _totalRowCount = _RLink.GetDataFrameLength(_name, False)
            _totalColumnCount = _RLink.GetDataFrameColumnCount(_name)
            _clsVisiblePage.CreatePages(_totalColumnCount, _totalRowCount)
            _clsFilter.RefreshData()
            '    SetHeaders()

            'Not sure what to do here
            'ucrDataViewer.SetColumnNames(strDataName, dfTemp.ColumnNames())

            clsSetDataFramesChanged.AddParameter("data_name", Chr(34) & _name & Chr(34))
            clsSetDataFramesChanged.AddParameter("new_val", "FALSE")
            _RLink.RunInternalScript(clsSetDataFramesChanged.ToScript(), bSilent:=True)
        End If
    End Sub


    'Public Sub LoadNextRowPage()
    '    _clsVisablePage.LoadNextRowPage()

    '    'If _intRowStart + intRowIncrements < _totalRowCount Then
    '    '    _intRowStart += intRowIncrements
    '    '    '_dataFrame = GetDataFrameFromRCommand()
    '    'End If
    'End Sub

    'Public Sub LoadPreviousRowPage()
    '    'If _intRowStart - intRowIncrements >= 0 Then
    '    '    _intRowStart -= intRowIncrements
    '    '    ' _dataFrame = GetDataFrameFromRCommand()
    '    'End If
    'End Sub

    'Public Sub LoadLastRowPage()
    '    'Dim intPages As Integer
    '    'intPages = Math.Ceiling(_totalRowCount / intRowIncrements)
    '    '_intRowStart = intRowIncrements * (intPages - 1)
    '    ''_dataFrame = GetDataFrameFromRCommand()
    'End Sub
    'Public Sub LoadFirstRowPage()
    '    _intRowStart = 1
    '    ' _dataFrame = GetDataFrameFromRCommand()
    'End Sub

End Class
