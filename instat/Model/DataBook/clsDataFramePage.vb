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
    Private _intRowStart As Integer
    Private _intColumnStart As Integer
    Private _intTotalRowCount As Integer
    Private _intTotalColumnCount As Integer
    Private _strDataFrameName As String
    Private _RLink As RLink
    Private _dataFrame As DataFrame
    Private _lstColumns As List(Of clsColumnHeaderDisplay)

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
    ''' Starting row of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intStartRow As Integer
        Get
            Return _intRowStart
        End Get
    End Property
    ''' <summary>
    ''' End row of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intEndRow As Integer
        Get
            Return _intRowStart + _dataFrame.RowCount - 1
        End Get
    End Property
    ''' <summary>
    ''' Start column of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intStartColumn As Integer
        Get
            Return _intColumnStart
        End Get
    End Property
    ''' <summary>
    ''' End column of the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property intEndColumn As Integer
        Get
            Return _intColumnStart + _dataFrame.ColumnCount - 1
        End Get
    End Property
    ''' <summary>
    ''' Contents of the dataframe for a given cell
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="column"></param>
    ''' <returns></returns>
    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return _dataFrame(row, column)
        End Get
    End Property
    ''' <summary>
    ''' Row name of the dataframe for a given row
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return _dataFrame.RowNames(row)
        End Get
    End Property
    ''' <summary>
    ''' Total number of rows for the visible page
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DisplayedRowCount As Integer
        Get
            Return _dataFrame.RowCount
        End Get
    End Property
    ''' <summary>
    ''' Create a new instance of a dataframe page
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strDataFrameName"></param>
    Public Sub New(rLink As RLink, strDataFrameName As String)
        _RLink = rLink
        _strDataFrameName = strDataFrameName
        _lstColumns = New List(Of clsColumnHeaderDisplay)
        _intColumnStart = 1
        _intRowStart = 1
    End Sub
    ''' <summary>
    ''' Refreshes data. Note: always refreshes regardless whether dataset has changed.
    ''' </summary>
    ''' <returns></returns>
    Public Function RefreshData()
        _dataFrame = GetDataFrameFromRCommand()
        If _dataFrame IsNot Nothing Then
            SetHeaders()
        End If
        Return _dataFrame IsNot Nothing 'Returns a success value
    End Function
    ''' <summary>
    ''' Update the total rows and columns for the dataset so paging can be set
    ''' </summary>
    ''' <param name="intTotalColumns"></param>
    ''' <param name="intTotalRows"></param>
    Public Sub SetTotalRowAndColumnCounts(intTotalColumns As Integer, intTotalRows As Integer)
        _intTotalRowCount = intTotalRows
        _intTotalColumnCount = intTotalColumns
    End Sub

    Private Function GetNoOfRowPages() As Integer
        'Needs to be a function as the number of increments can be changed through options 
        Return Math.Ceiling(_intTotalRowCount / intRowIncrements)
    End Function

    Private Function GetNoOfColumnPages() As Integer
        'Needs to be a function as the number of increments can be changed through options 
        Return Math.Ceiling(_intTotalColumnCount / intColumnIncrements)
    End Function

    Private Function GetDataFrameFromRCommand() As DataFrame
        Dim clsGetDataFrame As New RFunction
        Dim expTemp As SymbolicExpression
        clsGetDataFrame.SetRCommand(_RLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrame.AddParameter("convert_to_character", "TRUE")
        clsGetDataFrame.AddParameter("include_hidden_columns", "FALSE")
        clsGetDataFrame.AddParameter("use_current_filter", "TRUE")
        clsGetDataFrame.AddParameter("max_cols", intColumnIncrements)
        clsGetDataFrame.AddParameter("max_rows", intRowIncrements)
        clsGetDataFrame.AddParameter("start_row", _intRowStart)
        clsGetDataFrame.AddParameter("start_col", _intColumnStart)
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
        columnHeader = New clsColumnHeaderDisplay With
                            {
                                .Name = strHeaderName,
                                .TypeShortCode = "",
                                .IsFactor = False,
                                .Colour = Color.DarkBlue,
                                .BackGroundColour = Nothing
                            }
        If strHeaderType.Contains("factor") AndAlso strHeaderType.Contains("ordered") Then
            columnHeader.TypeShortCode = "(O.F)"
            columnHeader.Colour = Color.Blue
            columnHeader.IsFactor = True
        ElseIf strHeaderType.Contains("factor") Then
            columnHeader.TypeShortCode = "(F)"
            columnHeader.Colour = Color.Blue
            columnHeader.IsFactor = True
        ElseIf strHeaderType.Contains("character") Then
            columnHeader.TypeShortCode = "(C)"
        ElseIf strHeaderType.Contains("Date") OrElse strHeaderType.Contains("POSIXct") OrElse strHeaderType.Contains("POSIXt") OrElse strHeaderType.Contains("hms") OrElse strHeaderType.Contains("difftime") OrElse strHeaderType.Contains("Duration") OrElse strHeaderType.Contains("Period") OrElse strHeaderType.Contains("Interval") Then
            columnHeader.TypeShortCode = "(D)"
        ElseIf strHeaderType.Contains("logical") Then
            columnHeader.TypeShortCode = "(L)"
            ' Structured columns e.g. "circular" are coded with "(S)"
        ElseIf strHeaderType.Contains("circular") Then
            columnHeader.TypeShortCode = "(S)"
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
    ''' <summary>
    ''' Does a next page exist for rows
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadNextRowPage() As Boolean
        Return intEndRow < _intTotalRowCount
    End Function
    ''' <summary>
    ''' Load the next row page
    ''' </summary>
    Public Sub LoadNextRowPage()
        If CanLoadNextRowPage() Then
            _intRowStart += intRowIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub
    ''' <summary>
    ''' Does a previous page exist for rows
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadPreviousRowPage() As Boolean
        Return _intRowStart - intRowIncrements >= 0
    End Function
    ''' <summary>
    ''' Load the previous row page
    ''' </summary>
    Public Sub LoadPreviousRowPage()
        If _intRowStart - intRowIncrements >= 0 Then
            _intRowStart -= intRowIncrements
            _dataFrame = GetDataFrameFromRCommand()
        End If
    End Sub
    ''' <summary>
    ''' Load last row page
    ''' </summary>
    Public Sub LoadLastRowPage()
        _intRowStart = (intRowIncrements * (GetNoOfRowPages() - 1)) + 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub
    ''' <summary>
    ''' Load first row page
    ''' </summary>
    Public Sub LoadFirstRowPage()
        _intRowStart = 1
        _dataFrame = GetDataFrameFromRCommand()
    End Sub
    ''' <summary>
    ''' Does the next column page exist
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadNextColumnPage() As Boolean
        Return intEndColumn < _intTotalColumnCount
    End Function
    ''' <summary>
    ''' Load the next column page
    ''' </summary>
    Public Sub LoadNextColumnPage()
        If CanLoadNextColumnPage() Then
            _intColumnStart += intColumnIncrements
            _dataFrame = GetDataFrameFromRCommand()
            SetHeaders()
        End If
    End Sub
    ''' <summary>
    ''' Does the previous column page exist
    ''' </summary>
    ''' <returns></returns>
    Public Function CanLoadPreviousColumnPage() As Boolean
        Return _intColumnStart - intColumnIncrements >= 0
    End Function
    ''' <summary>
    ''' Load previous column page
    ''' </summary>
    Public Sub LoadPreviousColumnPage()
        If _intColumnStart - intColumnIncrements >= 0 Then
            _intColumnStart -= intColumnIncrements
            _dataFrame = GetDataFrameFromRCommand()
            SetHeaders()
        End If
    End Sub
    ''' <summary>
    ''' Load last column page
    ''' </summary>
    Public Sub LoadLastColumnPage()
        _intColumnStart = (intColumnIncrements * (GetNoOfColumnPages() - 1)) + 1
        _dataFrame = GetDataFrameFromRCommand()
        SetHeaders()
    End Sub
    ''' <summary>
    ''' Load first column page
    ''' </summary>
    Public Sub LoadFirstColumnPage()
        _intColumnStart = 1
        _dataFrame = GetDataFrameFromRCommand()
        SetHeaders()
    End Sub


End Class
