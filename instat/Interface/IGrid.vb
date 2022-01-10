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

Public Interface IGrid

    Property CurrentWorksheet As clsWorksheetAdapter
    WriteOnly Property DataBook As clsDataBook
    Property bEnabled() As Boolean
    Property bVisible() As Boolean
    Function AddNewWorksheet(strName As String) As clsWorksheetAdapter

    Sub CopyRange()

    Function GetCellValue(iRow As Integer, strColumn As String) As String

    Function GetSelectedRows() As List(Of String)

    Function GetWorksheet(strName As String) As clsWorksheetAdapter

    Sub RemoveOldWorksheets()

    Sub SelectAll()

    Sub SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip,
                                                                rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip)
    Sub SetCurrentDataFrame(strDataName As String)

    Sub SetCurrentDataFrame(iIndex As Integer)

    Sub UpdateAllWorksheetStyles()

    Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter)
End Interface
