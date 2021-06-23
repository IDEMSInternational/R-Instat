Imports RDotNet

Public Class clsDataFramePage

    Private _intRowStart As Integer
    Private _intColumnStart As Integer
    Private _intTotalRowCount As Integer
    Private _intTotalColumnCount As Integer
    Private _intNoOfColumnPages As Integer
    Private _intNoOfRowPages As Integer
    Private _strDataFrameName As String

    Private _RLink As RLink
    Private _dataFrame As DataFrame

    Protected _lstColumns As List(Of clsColumnHeaderDisplay)

    Private ReadOnly Property intColumnIncrements As Integer
        Get
            Return frmMain.clsInstatOptions.iMaxCols
        End Get
    End Property
    Private ReadOnly Property intRowIncrements As Integer
        Get
            Return frmMain.clsInstatOptions.iMaxRows
        End Get
    End Property


    Public ReadOnly Property lstColumns() As List(Of clsColumnHeaderDisplay)
        Get
            Return _lstColumns
        End Get
    End Property

    Public ReadOnly Property intStartRow As Integer
        Get
            Return _intRowStart
        End Get
    End Property
    Public ReadOnly Property intEndRow As Integer
        Get
            Return _intRowStart + _dataFrame.RowCount - 1
        End Get
    End Property

    Public ReadOnly Property intStartColumn As Integer
        Get
            Return _intColumnStart
        End Get
    End Property
    Public ReadOnly Property intEndColumn As Integer
        Get
            Return _intColumnStart + _dataFrame.ColumnCount - 1
        End Get
    End Property


    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return _dataFrame(row, column)
        End Get
    End Property
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return _dataFrame.RowNames(row)
        End Get
    End Property

    Public ReadOnly Property ColumnName(column As Integer) As String
        Get
            Return _dataFrame.ColumnNames(column)
        End Get
    End Property
    Public ReadOnly Property DisplayedRowCount As Integer
        Get
            Return _dataFrame.RowCount
        End Get
    End Property

    Public ReadOnly Property DisplayedColumnCount() As Integer
        Get
            Return _dataFrame.ColumnCount
        End Get
    End Property

    Public Sub New(rLink As RLink, strDataFrameName As String)
        _RLink = rLink
        _strDataFrameName = strDataFrameName
        _lstColumns = New List(Of clsColumnHeaderDisplay)
        _intColumnStart = 1
        _intRowStart = 1
    End Sub


    Public Function RefreshData()
        _dataFrame = GetDataFrameFromRCommand()
        If _dataFrame IsNot Nothing Then
            SetHeaders()
        End If
        Return _dataFrame IsNot Nothing 'Returns a success value
    End Function

    Public Sub CreatePages(intTotalColumns As Integer, intTotalRows As Integer)
        _intTotalRowCount = intTotalRows
        _intTotalColumnCount = intTotalColumns
        _intNoOfRowPages = Math.Ceiling(_intTotalRowCount / intRowIncrements)
        _intNoOfColumnPages = Math.Ceiling(_intTotalColumnCount / intColumnIncrements)
    End Sub

    Private Function GetDataFrameFromRCommand() As DataFrame
        Dim clsGetDataFrame As New RFunction
        Dim expTemp As SymbolicExpression
        clsGetDataFrame.SetRCommand(_RLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrame.AddParameter("convert_to_character", "TRUE")
        clsGetDataFrame.AddParameter("include_hidden_columns", "FALSE")
        clsGetDataFrame.AddParameter("use_current_filter", "TRUE")
        clsGetDataFrame.AddParameter("max_cols", intColumnIncrements)
        clsGetDataFrame.AddParameter("max_rows", intRowIncrements - 1)
        clsGetDataFrame.AddParameter("start_row", _intRowStart)
        clsGetDataFrame.AddParameter("start_cols", _intColumnStart)
        clsGetDataFrame.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsGetDataFrame.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsDataFrame
        Else
            Return Nothing
        End If
    End Function

    Private Function GetColumnDataTypes() As CharacterVector
        Dim clsGetVarMetaFunc As New RFunction
        clsGetVarMetaFunc.SetRCommand(_RLink.strInstatDataObject & "$get_column_data_types")
        clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsGetVarMetaFunc.AddParameter("columns", _RLink.GetListAsRString(_dataFrame.ColumnNames.ToList))
        Return _RLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsCharacter
    End Function

    Private Function GetColumnBackgroundColours() As NumericVector
        Dim clsGetVarMetaFunc As New RFunction
        clsGetVarMetaFunc.SetRCommand(_RLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsGetVarMetaFunc.AddParameter("property", "colour_label")
        clsGetVarMetaFunc.AddParameter("column", _RLink.GetListAsRString(_dataFrame.ColumnNames.ToList))
        Return _RLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsNumeric
    End Function

    Private Function GetHasColumnColours() As Boolean
        Dim clsHasColoursFunc As New RFunction
        clsHasColoursFunc.ClearParameters()
        clsHasColoursFunc.SetRCommand(_RLink.strInstatDataObject & "$has_colours")
        clsHasColoursFunc.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsHasColoursFunc.AddParameter("columns", _RLink.GetListAsRString(_dataFrame.ColumnNames.ToList))
        Return _RLink.RunInternalScriptGetValue(clsHasColoursFunc.ToScript()).AsLogical(0)
    End Function
    Private Function GetColumnDispayDetails(strHeaderName As String, strHeaderType As String) As clsColumnHeaderDisplay
        Dim columnHeader As clsColumnHeaderDisplay
        columnHeader = New clsColumnHeaderDisplay With {.Name = strHeaderName, .IsFactor = False, .Colour = Color.DarkBlue, .BackGroundColour = Nothing}
        If strHeaderType.Contains("factor") AndAlso strHeaderType.Contains("ordered") Then
            columnHeader.Name &= " (O.F)"
            columnHeader.Colour = Color.Blue
            columnHeader.IsFactor = True
        ElseIf strHeaderType.Contains("factor") Then
            columnHeader.Name &= " (F)"
            columnHeader.Colour = Color.Blue
            columnHeader.IsFactor = True
        ElseIf strHeaderType.Contains("character") Then
            columnHeader.Name &= " (C)"
        ElseIf strHeaderType.Contains("Date") OrElse strHeaderType.Contains("POSIXct") OrElse strHeaderType.Contains("POSIXt") OrElse strHeaderType.Contains("hms") OrElse strHeaderType.Contains("difftime") OrElse strHeaderType.Contains("Duration") OrElse strHeaderType.Contains("Period") OrElse strHeaderType.Contains("Interval") Then
            columnHeader.Name &= " (D)"
        ElseIf strHeaderType.Contains("logical") Then
            columnHeader.Name &= " (L)"
            ' Structured columns e.g. "circular" are coded with "(S)"
        ElseIf strHeaderType.Contains("circular") Then
            columnHeader.Name &= " (S)"
            ' Types of data for specific Application areas e.g. survival are coded with "(A)"
            ' No examples implemented yet.
            'ElseIf strType.Contains() Then
            '    fillWorkSheet.ColumnHeaders(k).Text = strCurrHeader & " (A)"
            '    fillWorkSheet.ColumnHeaders(k).TextColor = Graphics.SolidColor.DarkBlue
        End If
        Return columnHeader
    End Function

    Private Sub SetHeaders()
        Dim vecColumnColours As NumericVector = Nothing
        Dim bApplyBackGroundColumnColours As Boolean
        Dim vecColumnDataTypes As CharacterVector
        Dim columnHeader As clsColumnHeaderDisplay

        vecColumnDataTypes = GetColumnDataTypes()
        bApplyBackGroundColumnColours = GetHasColumnColours()
        If bApplyBackGroundColumnColours Then
            vecColumnColours = GetColumnBackgroundColours()
        End If
        _lstColumns.Clear()

        For i = 0 To _dataFrame.ColumnNames.ToList.Count - 1
            columnHeader = GetColumnDispayDetails(_dataFrame.ColumnNames.ToList(i), vecColumnDataTypes(i))
            If bApplyBackGroundColumnColours AndAlso vecColumnColours IsNot Nothing Then
                columnHeader.BackGroundColour = GetColumnBackGroundColor(i, vecColumnColours(i).ToString())
            End If
            _lstColumns.Add(columnHeader)
        Next
    End Sub

    Private Function GetColumnBackGroundColor(iColumn As Integer, Optional iColour As Integer = -1) As Color
        If iColour >= 0 AndAlso iColour < frmMain.clsInstatOptions.lstColourPalette.Count Then
            Return frmMain.clsInstatOptions.lstColourPalette(iColour - 1)
        Else
            Return Nothing
        End If
    End Function

    Public Function CanLoadNextRowPage() As Boolean
        Return _intRowStart + intRowIncrements < _intTotalRowCount
    End Function
    Public Sub LoadNextRowPage()
        If _intRowStart + intRowIncrements < _intTotalRowCount Then
            _intRowStart += intRowIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub
    Public Function CanLoadPreviousRowPage() As Boolean
        Return _intRowStart - intRowIncrements >= 0
    End Function
    Public Sub LoadPreviousRowPage()
        If _intRowStart - intRowIncrements >= 0 Then
            _intRowStart -= intRowIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub

    Public Sub LoadLastRowPage()
        _intRowStart = (intRowIncrements * (_intNoOfRowPages - 1)) + 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub
    Public Sub LoadFirstRowPage()
        _intRowStart = 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub

    Public Function CanLoadNextColumnPage() As Boolean
        Return _intColumnStart + intColumnIncrements < _intTotalColumnCount
    End Function
    Public Sub LoadNextColumnPage()
        If _intColumnStart + intColumnIncrements < _intTotalColumnCount Then
            _intColumnStart += intColumnIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub
    Public Function CanLoadPreviousColumnPage() As Boolean
        Return _intColumnStart - intColumnIncrements >= 0
    End Function
    Public Sub LoadPreviousColumnPage()
        If _intColumnStart - intColumnIncrements >= 0 Then
            _intColumnStart -= intColumnIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub

    Public Sub LoadLastColumnPage()
        _intColumnStart = (intColumnIncrements * (_intNoOfColumnPages - 1)) + 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub
    Public Sub LoadFirstColumnPage()
        _intColumnStart = 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub


End Class
