﻿' R- Instat
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

Imports System.ComponentModel

Public MustInherit Class ucrLinuxGrid
    Implements IGrid

    Protected _clsDataBook As clsDataBook
    Private _cellContextMenuStrip As ContextMenuStrip
    Private _columnContextMenuStrip As ContextMenuStrip
    Private _rowContextMenuStrip As ContextMenuStrip
    Private _tabContextMenuStrip As ContextMenuStrip

    ''' <summary>
    ''' Gets current worksheet adapter
    ''' </summary>
    ''' <returns>Worksheet adapter if a tab is selected, else nothing</returns>
    Public Property CurrentWorksheet As clsWorksheetAdapter Implements IGrid.CurrentWorksheet
        Get
            Return If(tcTabs.SelectedTab Is Nothing, Nothing, New clsWorksheetAdapter(tcTabs.SelectedTab))
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

    Public WriteOnly Property DataBook As clsDataBook Implements IGrid.DataBook
        Set(value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Private Property IGrid_Enabled As Boolean Implements IGrid.bEnabled
        Get
            Return tcTabs.Enabled
        End Get
        Set(value As Boolean)
            tcTabs.Enabled = value
        End Set
    End Property

    Private Property IGrid_Visible As Boolean Implements IGrid.bVisible
        Get
            Return Me.Visible
        End Get
        Set(value As Boolean)
            Me.Visible = value
        End Set
    End Property

    Public Function AddNewWorksheet(strName As String) As clsWorksheetAdapter Implements IGrid.AddNewWorksheet
        Dim tab As New TabPage(strName)
        tcTabs.TabPages.Add(tab)
        Dim dataGrid As New DataGridView
        tab.Controls.Add(dataGrid)
        dataGrid.Dock = DockStyle.Fill
        AttachContextMenuEventsToDataGrid(dataGrid)
        AttachEventsToWorksheet(dataGrid)
        dataGrid.ReadOnly = True
        dataGrid.RowHeadersWidth = 55
        dataGrid.EnableHeadersVisualStyles = False
        tab.Tag = dataGrid
        Return New clsWorksheetAdapter(tab)
    End Function

    ''' <summary>
    ''' Reorder the worksheets
    ''' </summary>
    Private Sub ReOrderWorksheets(strCurrWorksheet As String) Implements IGrid.ReOrderWorksheets
        'assuming the databook will always have all the data frames 
        'and the grid may not have all the data frame worksheets equivalent
        'and all data frames in the data book have changed their order positions 
        'get data frames sheets in the grid based on the databook data frames position order
        'and add it to the list.
        Dim lstWorkSheetsFound As New List(Of TabPage)
        For Each clsDataframe In _clsDataBook.DataFrames
            Dim fillWorkSheet As TabPage = GetTabPage(clsDataframe.strName)
            If fillWorkSheet IsNot Nothing Then
                lstWorkSheetsFound.Add(fillWorkSheet)
            End If
        Next

        'in the second condition we check if all data frames in the data book
        'have the same order positions with all data frame sheets in the grid
        'if not this check will return False which means the data frames in the data book are reordered
        If lstWorkSheetsFound.Count > 1 AndAlso Not _clsDataBook.DataFrames.Select(Function(x) x.strName).ToList().
                                                       SequenceEqual(tcTabs.Controls.OfType(Of TabPage).Select(Function(x) x.Text).ToList) Then
            'reorder the worksheets based on the filled list
            For i As Integer = 0 To lstWorkSheetsFound.Count - 1
                tcTabs.TabPages.Remove(lstWorkSheetsFound(i))
                tcTabs.TabPages.Insert(i, lstWorkSheetsFound(i))
            Next
            tcTabs.SelectedTab = GetTabPage(strCurrWorksheet) 'set the selected sheet back active before reordering
        End If
    End Sub

    Private Function GetTabPage(strName As String) As TabPage
        Dim tab As TabPage = Nothing
        For i As Integer = 0 To tcTabs.TabPages.Count - 1
            If tcTabs.TabPages(i).Text = strName Then
                tab = tcTabs.TabPages(i)
                Exit For
            End If
        Next
        Return tab
    End Function

    Public Sub CopyRange() Implements IGrid.CopyRange
        Dim dataGrid = GetDataGridFromSelectedTab()
        dataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Dim dataObj = dataGrid.GetClipboardContent()
        Clipboard.SetDataObject(dataObj, True)
    End Sub

    Public Function GetCellValue(iRow As Integer, strColumn As String) As String Implements IGrid.GetCellValue
        Dim dataGrid = GetDataGridFromSelectedTab()

        For i As Integer = 0 To dataGrid.ColumnCount - 1
            If dataGrid.Columns(i).Name = strColumn Then
                Return dataGrid.Rows(iRow).Cells(i).Value
            End If
        Next
        Return ""
    End Function

    Public Function GetGrid(tabPage As TabPage) As DataGridView
        Return CType(tabPage.Tag, DataGridView)
    End Function

    Public Function GetGrid(strWorksheetName As String) As DataGridView
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = strWorksheetName Then
                Return CType(tabPage.Tag, DataGridView)
            End If
        Next
        Return Nothing
    End Function

    Public Function GetSelectedRows() As List(Of String) Implements IGrid.GetSelectedRows
        Dim lstSelectedRows As New List(Of String)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        'For Each row As DataGridViewRow In dataGrid.SelectedRows
        '    lstSelectedRows.Add(row.HeaderCell.Value)
        'Next
        For i As Integer = 0 To dataGrid.GetCellCount(DataGridViewElementStates.Selected) - 1
            lstSelectedRows.Add(dataGrid.SelectedCells(i).RowIndex.ToString + 1)
        Next
        lstSelectedRows = lstSelectedRows.Distinct.ToList
        Return lstSelectedRows
    End Function


    Public Function GetSelectedColumnIndexes() As List(Of String) Implements IGrid.GetSelectedColumnIndexes
        Dim lstSelectedColumnIndexes As New List(Of String)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        'For Each column As DataGridViewColumn In dataGrid.SelectedColumns
        '    lstSelectedColumnIndexes.Add(column.HeaderCell.Value)
        'Next
        For i As Integer = 0 To dataGrid.GetCellCount(DataGridViewElementStates.Selected) - 1
            lstSelectedColumnIndexes.Add(dataGrid.SelectedCells(i).ColumnIndex.ToString + 1)
        Next
        lstSelectedColumnIndexes = lstSelectedColumnIndexes.Distinct.ToList
        Return lstSelectedColumnIndexes
    End Function

    Public Function GetWorksheet(name As String) As clsWorksheetAdapter Implements IGrid.GetWorksheet
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = name Then
                Return New clsWorksheetAdapter(tabPage)
            End If
        Next
        Return Nothing
    End Function

    Public Sub RemoveOldWorksheets() Implements IGrid.RemoveOldWorksheets
        For i = tcTabs.TabCount - 1 To 0 Step -1
            Dim iTabPagePosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = tcTabs.TabPages(index:=iTabPagePosition).Text).Count = 0 Then
                tcTabs.TabPages.Remove(tcTabs.TabPages(i))
            End If
        Next
    End Sub

    Public Sub SelectAll() Implements IGrid.SelectAll
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.SelectAll()
    End Sub

    Public Sub SetContextmenuStrips(columnContextMenuStrip As ContextMenuStrip, cellContextMenuStrip As ContextMenuStrip, rowContextMenuStrip As ContextMenuStrip, tabContextMenuStrip As ContextMenuStrip) Implements IGrid.SetContextmenuStrips
        _columnContextMenuStrip = columnContextMenuStrip
        _cellContextMenuStrip = cellContextMenuStrip
        _rowContextMenuStrip = rowContextMenuStrip
        _tabContextMenuStrip = tabContextMenuStrip
        If _tabContextMenuStrip IsNot Nothing Then
            AddHandler _tabContextMenuStrip.Opening, AddressOf contextMenuStrip_Opening
            tcTabs.ContextMenuStrip = _tabContextMenuStrip
        End If
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String) Implements IGrid.SetCurrentDataFrame
        For Each tabPage As TabPage In tcTabs.TabPages
            If tabPage.Text = strDataName Then
                tcTabs.SelectedTab = tabPage
                Exit For
            End If
        Next
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer) Implements IGrid.SetCurrentDataFrame
        If tcTabs.TabPages.Count > iIndex Then
            tcTabs.SelectedIndex = iIndex
        End If
    End Sub

    Public Sub UpdateAllWorksheetStyles() Implements IGrid.UpdateAllWorksheetStyles
        For Each tabPage In tcTabs.TabPages
            UpdateWorksheetStyle(GetGrid(tabPage))
        Next
    End Sub

    Public Sub UpdateWorksheetStyle(dataGrid As DataGridView)
        If frmMain.clsInstatOptions IsNot Nothing Then
            Dim newFont As New Font(frmMain.clsInstatOptions.fntEditor.FontFamily, frmMain.clsInstatOptions.fntEditor.Size,
                                    frmMain.clsInstatOptions.fntEditor.Style, frmMain.clsInstatOptions.fntEditor.Unit)
            dataGrid.DefaultCellStyle.Font = newFont
            dataGrid.DefaultCellStyle.ForeColor = frmMain.clsInstatOptions.clrEditor
            dataGrid.ColumnHeadersDefaultCellStyle.Font = New Font(FontFamily.GenericSansSerif, 8.25)
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
            dataGrid.RowHeadersDefaultCellStyle.Font = New Font(FontFamily.GenericSansSerif, 8.25)
        End If
    End Sub

    Public Sub UpdateWorksheetStyle(worksheet As clsWorksheetAdapter) Implements IGrid.UpdateWorksheetStyle
        UpdateWorksheetStyle(GetGrid(worksheet.Name))
    End Sub

    Protected MustOverride Sub AttachEventsToWorksheet(dataGrid As DataGridView)

    Protected Function GetDataGridFromSelectedTab() As DataGridView
        Return CType(tcTabs.SelectedTab.Tag, DataGridView)
    End Function

    Private Sub AttachContextMenuEventsToDataGrid(dataGrid As DataGridView)
        AddHandler dataGrid.CellMouseClick, AddressOf dataGrid_CellMouseClick
        AddHandler dataGrid.RowHeaderMouseClick, AddressOf dataGrid_RowHeaderMouseClick
        AddHandler dataGrid.ColumnHeaderMouseClick, AddressOf dataGrid_ColumnHeaderMouseClick
    End Sub

    Private Sub contextMenuStrip_Opening(sender As Object, e As CancelEventArgs)
        Dim point = tcTabs.PointToClient(Cursor.Position)
        For i As Integer = 0 To tcTabs.TabCount - 1
            Dim rectangle As Rectangle = tcTabs.GetTabRect(i)
            If rectangle.Contains(point) Then
                tcTabs.SelectedIndex = i ' i is the index of tab under cursor
                Exit Sub
            End If
        Next
        e.Cancel = True
    End Sub

    Private Sub dataGrid_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If _cellContextMenuStrip IsNot Nothing And e.Button = MouseButtons.Right Then
            If sender.SelectedCells.Count > 0 Then
                _cellContextMenuStrip.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dataGrid_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        sender.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect
        If _cellContextMenuStrip IsNot Nothing _
                AndAlso e.Button = MouseButtons.Right _
                AndAlso sender.SelectedCells.Count > 0 Then
            _cellContextMenuStrip.Show(Cursor.Position)
        End If
    End Sub

    Private Sub dataGrid_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        sender.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
        If _rowContextMenuStrip IsNot Nothing AndAlso e.Button = MouseButtons.Right AndAlso
                            sender.SelectedRows.Count > 0 Then
            _rowContextMenuStrip.Show(Cursor.Position)
        End If
    End Sub

End Class