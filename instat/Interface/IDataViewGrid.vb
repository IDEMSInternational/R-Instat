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

Imports R_Adapter2.R_Adapter.DataBook

Public Interface IDataViewGrid
    Inherits IGrid

    Event CellDataChanged()

    Event PasteValuesToDataframe()

    Event ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String)

    Event DeleteValuesToDataframe()

    Event WorksheetChanged()

    Event WorksheetRemoved(worksheet As clsWorksheetAdapter)

    Sub AddColumns(visiblePage As DataFramePage)

    Sub AddRowData(dataFrame As DataFrame)

    Function GetSelectedColumns() As List(Of ColumnHeaderDisplay)

    Function GetWorksheetCount() As Integer

End Interface