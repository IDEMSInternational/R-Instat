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

Public Interface IDataViewGrid
    Inherits IGrid

    Event CellDataChanged()

    Event PasteValuesToDataframe()

    Event ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String)

    Event DeleteValuesToDataframe()

    Event EditCell()

    Event WorksheetChanged()

    Event WorksheetRemoved(worksheet As clsWorksheetAdapter)

    Event FindRow()

    Sub AddColumns(visiblePage As clsDataFramePage)

    Sub AddRowData(dataFrame As clsDataFrame)

    Sub SearchRowInGrid(rowNumbers As List(Of Integer), strColumn As String, Optional iRow As Integer = 0,
                            Optional bApplyToRows As Boolean = False)

    Sub SelectColumnInGrid(strColumn As String)

    Sub AdjustColumnWidthAfterWrapping(strColumn As String, Optional bApplyWrap As Boolean = False)

    Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay)

    Function GetFirstRowHeader() As String

    Function GetLastRowHeader() As String

    Function GetWorksheetCount() As Integer

End Interface