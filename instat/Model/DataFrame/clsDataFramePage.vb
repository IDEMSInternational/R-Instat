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

Imports RDotNet

''' <summary>
''' Holds a subset dataset for the dataframe
''' </summary>
Public Class clsDataFramePage
    Private _iRowStart As Integer
    Private _iColumnStart As Integer
    Private _iTotalRowCount As Integer
    Private _iTotalColumnCount As Integer
    Private _strDataFrameName As String
    Private _clsRLink As RLink
    Private _clsDataFrame As DataFrame
    Private _lstColumns As List(Of clsColumnHeaderDisplay)
    Private _hasChanged As Boolean

    Private ReadOnly Property iColumnIncrements As Integer
        Get
            Return frmMain.clsInstatOptions.iMaxCols
        End Get
    End Property

    Private ReadOnly Property intRowIncrements As Integer
        Get
            Return frmMain.clsInstatOptions.iMaxRows
        End Get
    End Property

    ''' <summary>
    ''' List of columns within the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property lstColumns() As List(Of clsColumnHeaderDisplay)
        Get
            Return _lstColumns
        End Get
    End Property

    ''' <summary>
    ''' Array of row names within the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property RowNames() As String()
        Get
            Return _clsDataFrame.RowNames()
        End Get
    End Property

    ''' <summary>
    ''' Starting row of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intStartRow As Integer
        Get
            Return _iRowStart
        End Get
    End Property

    ''' <summary>
    ''' End row of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intEndRow As Integer
        Get
            Return _iRowStart + _clsDataFrame.RowCount - 1
        End Get
    End Property

    ''' <summary>
    ''' Start column of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intStartColumn As Integer
        Get
            Return _iColumnStart
        End Get
    End Property

    ''' <summary>
    ''' End column of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intEndColumn As Integer
        Get
            Return _iColumnStart + _clsDataFrame.ColumnCount - 1
        End Get
    End Property

    ''' <summary>
    ''' Contents of the dataframe for a given cell
    ''' </summary>
    ''' <param name="iRow"></param>
    ''' <param name="iColumn"></param>
    ''' <returns></returns>
    Public ReadOnly Property Data(iRow As Integer, iColumn As Integer) As Object
        Get
            Return _clsDataFrame(iRow, iColumn)
            'ToDo Need better error handling if out of range
        End Get
    End Property

    ''' <summary>
    ''' Total number of rows for the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DisplayedRowCount As Integer
        Get
            Return _clsDataFrame.RowCount
        End Get
    End Property

    ''' <summary>
    ''' holds whether the dataframe is different from visual grid component
    ''' </summary>
    ''' <returns></returns>
    Public Property HasChanged() As Boolean
        Get
            Return _hasChanged
        End Get
        Set(ByVal value As Boolean)
            _hasChanged = value
        End Set
    End Property

    ''' <summary>
    ''' Create a new instance of a dataframe page
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strDataFrameName"></param>
    Public Sub New(rLink As RLink, strDataFrameName As String)
        _clsRLink = rLink
        _strDataFrameName = strDataFrameName
        _lstColumns = New List(Of clsColumnHeaderDisplay)
        _iColumnStart = 1
        _iRowStart = 1
        _hasChanged = True
    End Sub

    ''' <summary>
    ''' Refreshes data. Note: always refreshes regardless whether dataset has changed.
    ''' </summary>
    ''' <returns></returns>
    Public Function RefreshData()
        _clsDataFrame = GetDataFrameFromRCommand()
        If _clsDataFrame IsNot Nothing Then
            SetHeaders()
        End If
        Return _clsDataFrame IsNot Nothing 'Returns a success value
    End Function

    ''' <summary>
    ''' Update the total rows and columns for the dataset so paging can be set
    ''' </summary>
    ''' <param name="intTotalColumns"></param>
    ''' <param name="intTotalRows"></param>
    Public Sub SetTotalRowAndColumnCounts(intTotalColumns As Integer, intTotalRows As Integer)
        _iTotalRowCount = intTotalRows
        _iTotalColumnCount = intTotalColumns
        If _iTotalRowCount < _iRowStart Then
            _iRowStart = 1
        End If
        If _iTotalColumnCount < _iColumnStart Then
            _iColumnStart = 1
        End If
    End Sub

    Private Function GetNoOfRowPages() As Integer
        'Needs to be a function as the number of increments can be changed through options 
        Return Math.Ceiling(_iTotalRowCount / intRowIncrements)
    End Function

    Private Function GetNoOfColumnPages() As Integer
        'Needs to be a function as the number of increments can be changed through options 
        Return Math.Ceiling(_iTotalColumnCount / iColumnIncrements)
    End Function

    Private Function GetDataFrameFromRCommand() As DataFrame
        Dim clsRFunction As New RFunction
        Dim expTemp As SymbolicExpression
        _hasChanged = True
        clsRFunction.SetRCommand(_clsRLink.strInstatDataObject & "$get_data_frame")
        clsRFunction.AddParameter("convert_to_character", "TRUE")
        clsRFunction.AddParameter("include_hidden_columns", "FALSE")
        clsRFunction.AddParameter("use_current_filter", "TRUE")
        clsRFunction.AddParameter("max_cols", iColumnIncrements)
        clsRFunction.AddParameter("max_rows", intRowIncrements)
        clsRFunction.AddParameter("start_row", _iRowStart)
        clsRFunction.AddParameter("start_col", _iColumnStart)
        clsRFunction.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        expTemp = _clsRLink.RunInternalScriptGetValue(clsRFunction.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsDataFrame
        Else
            Return Nothing
        End If
    End Function

    Private Function GetColumnDataTypes() As CharacterVector
        Dim clsRFunction As New RFunction
        clsRFunction.SetRCommand(_clsRLink.strInstatDataObject & "$get_column_data_types")
        clsRFunction.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsRFunction.AddParameter("columns", _clsRLink.GetListAsRString(_clsDataFrame.ColumnNames.ToList))
        Return _clsRLink.RunInternalScriptGetValue(clsRFunction.ToScript()).AsCharacter
    End Function

    Private Function GetColumnBackgroundColours() As NumericVector
        Dim clsRFunction As New RFunction
        clsRFunction.SetRCommand(_clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsRFunction.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsRFunction.AddParameter("property", "colour_label")
        clsRFunction.AddParameter("column", _clsRLink.GetListAsRString(_clsDataFrame.ColumnNames.ToList))
        Return _clsRLink.RunInternalScriptGetValue(clsRFunction.ToScript()).AsNumeric
    End Function

    Private Function GetHasColumnColours() As Boolean
        Dim clsRFunction As New RFunction
        clsRFunction.ClearParameters()
        clsRFunction.SetRCommand(_clsRLink.strInstatDataObject & "$has_colours")
        clsRFunction.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsRFunction.AddParameter("columns", _clsRLink.GetListAsRString(_clsDataFrame.ColumnNames.ToList))
        Return _clsRLink.RunInternalScriptGetValue(clsRFunction.ToScript()).AsLogical(0)
    End Function

    Private Function GetColumnDispayDetails(strHeaderName As String, strHeaderType As String) As clsColumnHeaderDisplay
        Dim columnHeader As clsColumnHeaderDisplay
        columnHeader = New clsColumnHeaderDisplay With
                            {
                                .strName = strHeaderName,
                                .strTypeShortCode = "",
                                .bIsFactor = False,
                                .clsColour = Color.DarkBlue,
                                .clsBackGroundColour = Nothing
                            }
        If strHeaderType.Contains("factor") AndAlso strHeaderType.Contains("ordered") Then
            columnHeader.strTypeShortCode = "(O.F)"
            columnHeader.clsColour = Color.Blue
            columnHeader.bIsFactor = True
        ElseIf strHeaderType.Contains("factor") Then
            columnHeader.strTypeShortCode = "(F)"
            columnHeader.clsColour = Color.Blue
            columnHeader.bIsFactor = True
        ElseIf strHeaderType.Contains("character") Then
            columnHeader.strTypeShortCode = "(C)"
        ElseIf strHeaderType.Contains("Date") OrElse strHeaderType.Contains("POSIXct") OrElse
                strHeaderType.Contains("POSIXt") OrElse strHeaderType.Contains("hms") OrElse
                strHeaderType.Contains("difftime") OrElse strHeaderType.Contains("Duration") OrElse
                strHeaderType.Contains("Period") OrElse strHeaderType.Contains("Interval") Then
            columnHeader.strTypeShortCode = "(D)"
        ElseIf strHeaderType.Contains("logical") Then
            columnHeader.strTypeShortCode = "(L)"
            ' Structured columns e.g. "circular" are coded with "(S)"
        ElseIf strHeaderType.Contains("circular") Then
            columnHeader.strTypeShortCode = "(S)"
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

        For i = 0 To _clsDataFrame.ColumnNames.ToList.Count - 1
            columnHeader = GetColumnDispayDetails(_clsDataFrame.ColumnNames.ToList(i), vecColumnDataTypes(i))
            If bApplyBackGroundColumnColours AndAlso vecColumnColours IsNot Nothing Then
                columnHeader.clsBackGroundColour = GetColumnBackGroundColor(i, vecColumnColours(i).ToString())
            End If
            _lstColumns.Add(columnHeader)
        Next
    End Sub

    Private Function GetColumnBackGroundColor(iColumn As Integer, Optional iColour As Integer = -1) As Color
        If iColour > 0 AndAlso iColour <= frmMain.clsInstatOptions.lstColourPalette.Count Then
            Return frmMain.clsInstatOptions.lstColourPalette(iColour - 1)
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' Does a next page exist for rows
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadNextRowPage() As Boolean
        Return intEndRow < _iTotalRowCount
    End Function

    ''' <summary>
    ''' Load the next row page
    ''' </summary>
    Public Sub LoadNextRowPage()
        If CanLoadNextRowPage() Then
            _iRowStart += intRowIncrements
            _clsDataFrame = GetDataFrameFromRCommand()
        End If
    End Sub

    ''' <summary>
    ''' Does a previous page exist for rows
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadPreviousRowPage() As Boolean
        Return _iRowStart > intRowIncrements
    End Function

    ''' <summary>
    ''' Load the previous row page
    ''' </summary>
    Public Sub LoadPreviousRowPage()
        If CanLoadPreviousRowPage() Then
            _iRowStart -= intRowIncrements
            _clsDataFrame = GetDataFrameFromRCommand()
        End If
    End Sub

    ''' <summary>
    ''' Load last row page
    ''' </summary>
    Public Sub LoadLastRowPage()
        _iRowStart = (intRowIncrements * (GetNoOfRowPages() - 1)) + 1
        _clsDataFrame = GetDataFrameFromRCommand()
    End Sub

    ''' <summary>
    ''' Load first row page
    ''' </summary>
    Public Sub LoadFirstRowPage()
        _iRowStart = 1
        _clsDataFrame = GetDataFrameFromRCommand()
    End Sub

    ''' <summary>
    ''' Does the next column page exist
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadNextColumnPage() As Boolean
        Return intEndColumn < _iTotalColumnCount
    End Function

    ''' <summary>
    ''' Load the next column page
    ''' </summary>
    Public Sub LoadNextColumnPage()
        If CanLoadNextColumnPage() Then
            _iColumnStart += iColumnIncrements
            _clsDataFrame = GetDataFrameFromRCommand()
            SetHeaders()
        End If
    End Sub

    ''' <summary>
    ''' Does the previous column page exist
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadPreviousColumnPage() As Boolean
        Return _iColumnStart > iColumnIncrements
    End Function

    ''' <summary>
    ''' Load previous column page
    ''' </summary>
    Public Sub LoadPreviousColumnPage()
        If _iColumnStart - iColumnIncrements >= 0 Then
            _iColumnStart -= iColumnIncrements
            _clsDataFrame = GetDataFrameFromRCommand()
            SetHeaders()
        End If
    End Sub

    ''' <summary>
    ''' Load last column page
    ''' </summary>
    Public Sub LoadLastColumnPage()
        _iColumnStart = (iColumnIncrements * (GetNoOfColumnPages() - 1)) + 1
        _clsDataFrame = GetDataFrameFromRCommand()
        SetHeaders()
    End Sub

    ''' <summary>
    ''' Load first column page
    ''' </summary>
    Public Sub LoadFirstColumnPage()
        _iColumnStart = 1
        _clsDataFrame = GetDataFrameFromRCommand()
        SetHeaders()
    End Sub

End Class

