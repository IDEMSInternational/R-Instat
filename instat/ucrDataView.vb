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

Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.InteropServices
Imports instat.Translations
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class ucrDataView
    Private _clsDataBook As clsDataBook
    Private _grid As IDataViewGrid


    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet

    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
            _grid.DataBook = value
        End Set
    End Property

    Public ReadOnly Property CellContextMenu As ContextMenuStrip
        Get
            Return cellContextMenuStrip
        End Get
    End Property

    Public ReadOnly Property ColumnContextMenu As ContextMenuStrip
        Get
            Return columnContextMenuStrip
        End Get
    End Property

    Public ReadOnly Property RowContextMenu As ContextMenuStrip
        Get
            Return rowContextMenuStrip
        End Get
    End Property

    Public ReadOnly Property SheetTabContextMenu As ContextMenuStrip
        Get
            Return statusColumnMenu
        End Get
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ucrDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mnuInsertColsBefore.Visible = False
        mnuInsertColsAfter.Visible = False
        autoTranslate(Me)

        If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
            _grid = ucrLinuxGrid
        Else
            _grid = ucrReoGrid
        End If
        'Debug 
        '_grid = ucrLinuxGrid

        _grid.SetContextmenuStrips(columnContextMenuStrip, cellContextMenuStrip, rowContextMenuStrip, statusColumnMenu)
        AttachEventsToGrid()
        RefreshDisplayInformation()
    End Sub

    Private Sub AttachEventsToGrid()
        AddHandler _grid.WorksheetChanged, AddressOf CurrentWorksheetChanged
        AddHandler _grid.WorksheetRemoved, AddressOf WorksheetRemoved
        AddHandler _grid.ReplaceValueInData, AddressOf ReplaceValueInData
        AddHandler _grid.PasteValuesToDataframe, AddressOf PasteValuesToDataFrame
        AddHandler _grid.CellDataChanged, AddressOf CellDataChanged
    End Sub

    Private Sub RefreshWorksheet(fillWorkSheet As clsWorksheetAdapter, dataFrame As clsDataFrame)
        If Not dataFrame.clsVisiblePage.HasChanged Then
            Exit Sub
        End If
        _grid.CurrentWorksheet = fillWorkSheet
        _grid.AddColumns(dataFrame.clsVisiblePage)
        _grid.AddRowData(dataFrame)
        _grid.UpdateWorksheetStyle(fillWorkSheet)
        dataFrame.clsVisiblePage.HasChanged = False
        RefreshDisplayInformation()
    End Sub

    Public Sub UpdateAllWorksheetStyles()
        _grid.UpdateAllWorksheetStyles()
    End Sub

    Private Sub UpdateNavigationButtons()
        lblColBack.Enabled = If(GetCurrentDataFrameFocus()?.clsVisiblePage?.CanLoadPreviousColumnPage(), False)
        lblColNext.Enabled = If(GetCurrentDataFrameFocus()?.clsVisiblePage?.CanLoadNextColumnPage(), False)
        lblColFirst.Enabled = lblColBack.Enabled
        lblColLast.Enabled = lblColNext.Enabled

        lblRowBack.Enabled = If(GetCurrentDataFrameFocus()?.clsVisiblePage?.CanLoadPreviousRowPage(), False)
        lblRowNext.Enabled = If(GetCurrentDataFrameFocus()?.clsVisiblePage?.CanLoadNextRowPage(), False)
        lblRowFirst.Enabled = lblRowBack.Enabled
        lblRowLast.Enabled = lblRowNext.Enabled
    End Sub

    Private Sub AddAndUpdateWorksheets()
        Dim firstAddedWorksheet As clsWorksheetAdapter = Nothing
        For Each clsDataFrame In _clsDataBook.DataFrames
            Dim worksheet As clsWorksheetAdapter = _grid.GetWorksheet(clsDataFrame.strName)
            If worksheet Is Nothing Then
                worksheet = _grid.AddNewWorksheet(clsDataFrame.strName)
                If firstAddedWorksheet Is Nothing Then
                    firstAddedWorksheet = worksheet
                End If
            End If
            RefreshWorksheet(worksheet, clsDataFrame)
        Next
        If firstAddedWorksheet IsNot Nothing Then
            _grid.CurrentWorksheet = firstAddedWorksheet
        End If
    End Sub

    Public Sub RefreshGridData()
        If _clsDataBook Is Nothing Then
            Exit Sub
        End If
        _clsDataBook.RefreshData()
        AddAndUpdateWorksheets()
        _grid.RemoveOldWorksheets()
        If _clsDataBook.DataFrames.Count = 0 Then
            RefreshDisplayInformation()
        End If
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(_grid.CurrentWorksheet.Name)
    End Function

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If GetSelectedColumns.Count = GetCurrentDataFrameFocus()?.iTotalColumnCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                StartWait()
                GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteColumn(GetSelectedColumnNames())
                EndWait()
            End If
        End If
    End Sub

    Private Sub mnuInsertRowsAfter_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsAfter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(GetSelectedRows.Count, GetLastSelectedRow(), False)
        EndWait()
    End Sub

    Private Sub mnuInsertRowsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsBefore.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(GetSelectedRows.Count, GetFirstSelectedRow, True)
        EndWait()
    End Sub

    Private Sub mnuDeleteRows_Click(sender As Object, e As EventArgs) Handles mnuDeleteRows.Click
        Dim Delete = MsgBox("Are you sure you want to delete these row(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Row(s)")
        If Delete = DialogResult.Yes Then
            StartWait()
            GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteRows(GetSelectedRows())
            EndWait()
        End If
    End Sub

    Public Sub CopyRange()
        Try
            _grid.CopyRange()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        _grid.SelectAll()
    End Sub

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(_grid.CurrentWorksheet.Name)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Public Sub WorksheetRemoved(worksheet As clsWorksheetAdapter)
        SetGridVisibility(_clsDataBook.DataFrames.Count > 0)
    End Sub

    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        dlgName.ShowDialog()
    End Sub

    Public Sub CurrentWorksheetChanged()
        RefreshDisplayInformation()
    End Sub

    Private Sub RefreshDisplayInformation()
        If _grid.GetWorksheetCount <> 0 AndAlso _clsDataBook IsNot Nothing AndAlso GetCurrentDataFrameFocus() IsNot Nothing Then
            frmMain.strCurrentDataFrame = _grid.CurrentWorksheet.Name
            frmMain.tstatus.Text = _grid.CurrentWorksheet.Name
            SetDisplayLabels()
            UpdateNavigationButtons()
            SetGridVisibility(True)
        Else
            frmMain.tstatus.Text = GetTranslation("No data loaded")
            SetGridVisibility(False)
        End If
    End Sub

    Private Sub ResizeLabels()
        Const iMinSize As Single = 5
        TblPanPageDisplay.Font = New Font(TblPanPageDisplay.Font.FontFamily, 12, TblPanPageDisplay.Font.Style)

        While lblRowDisplay.Width + lblColDisplay.Width + 50 +
                    lblColBack.Width + lblColFirst.Width + lblColLast.Width + lblColNext.Width +
                    lblRowBack.Width + lblRowFirst.Width + lblRowNext.Width + lblRowLast.Width > TblPanPageDisplay.Width AndAlso
                    TblPanPageDisplay.Font.Size > iMinSize
            TblPanPageDisplay.Font = New Font(TblPanPageDisplay.Font.FontFamily, TblPanPageDisplay.Font.Size - 0.5F, TblPanPageDisplay.Font.Style)
        End While
    End Sub

    Private Sub SetGridVisibility(bIsVisible As Boolean)
        If bIsVisible Then
            tlpTableContainer.ColumnStyles(0).SizeType = SizeType.Absolute
            tlpTableContainer.ColumnStyles(0).Width = 0
            If _grid.GetType() Is GetType(ucrDataViewReoGrid) Then
                tlpTableContainer.ColumnStyles(1).SizeType = SizeType.Absolute
                tlpTableContainer.ColumnStyles(1).Width = 0
                tlpTableContainer.ColumnStyles(2).SizeType = SizeType.Percent
                tlpTableContainer.ColumnStyles(2).Width = 100
            Else
                tlpTableContainer.ColumnStyles(1).SizeType = SizeType.Percent
                tlpTableContainer.ColumnStyles(1).Width = 100
                tlpTableContainer.ColumnStyles(2).SizeType = SizeType.Absolute
                tlpTableContainer.ColumnStyles(2).Width = 0
            End If
        Else
            tlpTableContainer.ColumnStyles(0).SizeType = SizeType.Percent
            tlpTableContainer.ColumnStyles(0).Width = 100
            tlpTableContainer.ColumnStyles(1).SizeType = SizeType.Absolute
            tlpTableContainer.ColumnStyles(1).Width = 0
            tlpTableContainer.ColumnStyles(2).SizeType = SizeType.Absolute
            tlpTableContainer.ColumnStyles(2).Width = 0
        End If
    End Sub

    Private Sub SetDisplayLabels()
        lblRowDisplay.Text = "Showing rows " & GetCurrentDataFrameFocus().clsVisiblePage.intStartRow & " to " &
                             GetCurrentDataFrameFocus().clsVisiblePage.intEndRow & " of "
        If GetCurrentDataFrameFocus().clsFilter.bApplied Then
            lblRowDisplay.Text &= GetCurrentDataFrameFocus().clsFilter.iFilteredRowCount &
                                 " (" & GetCurrentDataFrameFocus().iTotalRowCount & ")" & " | Active filter: " & GetCurrentDataFrameFocus().clsFilter.strName
        Else
            lblRowDisplay.Text &= GetCurrentDataFrameFocus().iTotalRowCount
        End If
        lblColDisplay.Text = "columns " & GetCurrentDataFrameFocus().clsVisiblePage.intStartColumn & " to " & GetCurrentDataFrameFocus().clsVisiblePage.intEndColumn &
                            " of " & GetCurrentDataFrameFocus().iTotalColumnCount
        ResizeLabels()
    End Sub

    Private Sub ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String)
        Dim dblValue As Double
        Dim iValue As Integer
        Dim bWithQuotes As Boolean

        If strNewValue = "NA" Then
            bWithQuotes = False
        Else
            Select Case GetCurrentDataFrameFocus().clsPrepareFunctions.GetDataTypeLabel(strColumnName)
                Case "factor"
                    If Not GetCurrentDataFrameFocus().clsPrepareFunctions.GetColumnFactorLevels(strColumnName).Contains(strNewValue) Then
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: factor. Values must be an existing level of this factor column.", MsgBoxStyle.Exclamation, "Invalid Value")
                        Exit Sub
                    Else
                        bWithQuotes = True
                    End If
                Case "numeric"
                    If Double.TryParse(strNewValue, dblValue) Then
                        bWithQuotes = False
                    Else
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: numeric. Values must be numeric.", MsgBoxStyle.Exclamation, "Invalid Value")
                        Exit Sub
                    End If
                Case "integer"
                    If Integer.TryParse(strNewValue, iValue) Then
                        bWithQuotes = False
                    Else
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: integer. Values must be integer.", MsgBoxStyle.Exclamation, "Invalid Value")
                        Exit Sub
                    End If
                Case Else
                    If Double.TryParse(strNewValue, dblValue) OrElse strNewValue = "TRUE" OrElse strNewValue = "FALSE" Then
                        bWithQuotes = False
                    Else
                        bWithQuotes = True
                    End If
            End Select
        End If
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ReplaceValueInData(strNewValue, strColumnName, strRowText, bWithQuotes)
        EndWait()
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(_grid.CurrentWorksheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub MoveOrCopySheet_Click(sender As Object, e As EventArgs) Handles CopySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(_grid.CurrentWorksheet.Name)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuLevelsLabels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        If IsFirstSelectedColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay)
        Return _grid.GetSelectedColumns()
    End Function

    Private Function GetSelectedColumnNames() As List(Of String)
        Return GetSelectedColumns().Select(Function(x) x.strName).ToList()
    End Function

    Private Function GetFirstSelectedColumnName() As String
        Return GetSelectedColumns().FirstOrDefault().strName
    End Function

    Private Function GetLastSelectedColumnName() As String
        Return GetSelectedColumns().LastOrDefault().strName
    End Function

    Private Function IsOnlyOneColumnSelected() As Boolean
        Return GetSelectedColumnNames.Count = 1
    End Function

    Private Function IsFirstSelectedColumnAFactor() As Boolean
        Return GetSelectedColumns().FirstOrDefault().bIsFactor
    End Function

    Private Function GetFirstSelectedRow() As String
        Return GetSelectedRows().FirstOrDefault()
    End Function

    Private Function GetSelectedRows() As List(Of String)
        Return _grid.GetSelectedRows()
    End Function

    Private Function GetLastSelectedRow() As String
        Return GetSelectedRows.LastOrDefault()
    End Function

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        _grid.bEnabled = False
    End Sub

    Private Sub EndWait()
        _grid.bEnabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToText(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuColumnFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = _grid.CurrentWorksheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub mnuFilter_Click(sender As Object, e As EventArgs) Handles mnuFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = _grid.CurrentWorksheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFreezeToHere_Click(sender As Object, e As EventArgs)
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.FreezeColumns(GetLastSelectedColumnName)
        EndWait()
    End Sub

    Private Sub mnuUnfreeze_Click(sender As Object, e As EventArgs)
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.UnFreezeColumns()
        EndWait()
    End Sub

    Private Sub ViewSheet_Click(sender As Object, e As EventArgs) Handles ViewSheet.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ViewDataFrame()
        EndWait()
    End Sub

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(_grid.CurrentWorksheet.Name, GetFirstSelectedRow())
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuComment_Click(sender As Object, e As EventArgs) Handles mnuComment.Click
        dlgAddComment.SetPosition(_grid.CurrentWorksheet.Name, GetFirstSelectedRow(), GetFirstSelectedColumnName())
        dlgAddComment.ShowDialog()
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        _grid.SetCurrentDataFrame(strDataName)
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        _grid.SetCurrentDataFrame(iIndex)
    End Sub

    Private Sub columnContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles columnContextMenuStrip.Opening
        If IsOnlyOneColumnSelected() Then
            mnuLevelsLabels.Enabled = IsFirstSelectedColumnAFactor()
            mnuDeleteCol.Text = GetTranslation("Delete Column")
            mnuInsertColsBefore.Text = GetTranslation("Insert 1 Column Before")
            mnuInsertColsAfter.Text = GetTranslation("Insert 1 Column After")
        Else
            mnuLevelsLabels.Enabled = False
            mnuDeleteCol.Text = GetTranslation("Delete Columns")
            mnuInsertColsBefore.Text = "Insert " & GetSelectedColumns.Count & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & GetSelectedColumns.Count & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub HideSheet_Click(sender As Object, e As EventArgs) Handles HideSheet.Click
        StartWait()
        _clsDataBook.HideDataFrame(_grid.CurrentWorksheet.Name)
        EndWait()
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub statusColumnMenu_Opening(sender As Object, e As CancelEventArgs) Handles statusColumnMenu.Opening
        HideSheet.Enabled = (_grid.GetWorksheetCount > 1)
    End Sub

    Private Sub mnuReorderColumns_Click(sender As Object, e As EventArgs) Handles mnuReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuRenameColumn_Click(sender As Object, e As EventArgs) Handles mnuRenameColumn.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuDuplColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), _grid.CurrentWorksheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuReorderColumn_Click(sender As Object, e As EventArgs) Handles mnuReorderColumn.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuConvertToFact_Click(sender As Object, e As EventArgs) Handles mnuConvertToFact.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToOrderedFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToOrderedFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToCharacter_Click(sender As Object, e As EventArgs) Handles mnuConvertToCharacter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToCharacter(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToLogic_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogic.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToNumeric_Click(sender As Object, e As EventArgs) Handles mnuConvertToNumeric.Click, mnuConvertVariate.Click
        For Each strColumn In GetSelectedColumnNames()
            Dim iNonNumericValues As Integer = GetCurrentDataFrameFocus().clsPrepareFunctions.GetAmountOfNonNumericValuesInColumn(strColumn)
            If iNonNumericValues = 0 Then
                GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, True)
            ElseIf iNonNumericValues = GetCurrentDataFrameFocus().iTotalRowCount Then
                GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, False)
            Else
                frmConvertToNumeric.SetDataFrameName(GetCurrentDataFrameFocus().strName)
                frmConvertToNumeric.SetColumnName(strColumn)
                frmConvertToNumeric.SetNonNumeric(iNonNumericValues)
                frmConvertToNumeric.ShowDialog()
                ' Yes for "normal" convert and No for "labelled" convert
                If frmConvertToNumeric.DialogResult = DialogResult.Yes Then
                    GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, True)
                ElseIf frmConvertToNumeric.DialogResult = DialogResult.No Then
                    GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, False)
                ElseIf frmConvertToNumeric.DialogResult = DialogResult.Cancel Then
                    Continue For
                End If
                frmConvertToNumeric.Close()
            End If
        Next
    End Sub

    Private Sub mnuLebelsLevel_Click(sender As Object, e As EventArgs) Handles mnuLabelsLevel.Click
        If IsFirstSelectedColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedColumnName, _grid.CurrentWorksheet.Name)
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuSorts_Click(sender As Object, e As EventArgs) Handles mnuSorts.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName, _grid.CurrentWorksheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFilters_Click(sender As Object, e As EventArgs) Handles mnuFilters.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = _grid.CurrentWorksheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilters_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilters.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub CellDataChanged()
        frmMain.bDataSaved = False
    End Sub

    Private Sub linkStartNewDataFrame_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartNewDataFrame.LinkClicked
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub linkStartOpenFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenFile.LinkClicked
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub linkStartOpenLibrary_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenLibrary.LinkClicked
        dlgFromLibrary.ShowDialog()
    End Sub

    ''' <summary>
    ''' clears all the added links label menu items from the recents panel of the data view
    ''' </summary>
    Public Sub ClearRecentFileMenuItems()
        panelRecentMenuItems.Controls.Clear()
        HideOrShowRecentSection()
    End Sub

    ''' <summary>
    ''' adds the link label as a menu item to the recents panel of the data view
    ''' </summary>
    ''' <param name="linkMenuItem">link label with file path set as its tag</param>
    Public Sub InsertRecentFileMenuItems(linkMenuItem As LinkLabel)
        'label used to display the path to the user
        Dim lblMenuItemPath As New Label
        Dim position As Integer = 1

        'add subsequent links after each other, separating them by 19 pixels on the Y axis
        If panelRecentMenuItems.Controls.Count > 0 Then
            'get Y axis position of last control then add 19 pixels to be used as the new Y axis position.
            position = panelRecentMenuItems.Controls.Item(panelRecentMenuItems.Controls.Count - 1).Location.Y
            position = position + 19
        End If

        linkMenuItem.Location = New Point(0, position)
        linkMenuItem.Height = 13
        linkMenuItem.LinkBehavior = LinkBehavior.NeverUnderline
        linkMenuItem.AutoSize = True

        'add the link control.
        panelRecentMenuItems.Controls.Add(linkMenuItem)

        'add the label control. will be besides each other on the same Y axis
        lblMenuItemPath.Text = If(String.IsNullOrEmpty(linkMenuItem.Tag), "", Path.GetDirectoryName(linkMenuItem.Tag).Replace("\", "/"))
        lblMenuItemPath.Location = New Point(linkMenuItem.Width + 10, position)
        lblMenuItemPath.Height = 13
        lblMenuItemPath.AutoSize = True
        panelRecentMenuItems.Controls.Add(lblMenuItemPath)
        HideOrShowRecentSection()
    End Sub

    ''' <summary>
    ''' toggles startup menu items visibility
    ''' </summary>
    ''' <param name="bVisibility"></param>
    Public Sub StartupMenuItemsVisibility(bVisibility As Boolean)
        panelSectionStart.Visible = bVisibility
        panelSectionHelp.Visible = bVisibility
        If bVisibility Then
            HideOrShowRecentSection()
        Else
            panelSectionRecent.Visible = False
        End If
    End Sub

    Private Sub HideOrShowRecentSection()
        panelSectionRecent.Visible = panelRecentMenuItems.Controls.Count > 0
    End Sub

    Private Sub linkHelpIntroduction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpIntroduction.LinkClicked
        Help.ShowHelp(frmMain, frmMain.strStaticPath & "/" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "0")
    End Sub

    Private Sub linkHelpRpackages_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpRpackages.LinkClicked
        dlgHelpVignettes.ShowDialog()
    End Sub

    Private Sub linkHelpRInstatWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpRInstatWebsite.LinkClicked
        Process.Start("http://r-instat.org/")
    End Sub

    Private Sub rowContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles rowContextMenuStrip.Opening
        mnuRemoveCurrentFilter.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub cellContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles cellContextMenuStrip.Opening
        mnuLabelsLevel.Enabled = IsOnlyOneColumnSelected() AndAlso IsOnlyOneColumnSelected()
        mnuRemoveCurrentFilters.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub mnuColumnAddComment_Click(sender As Object, e As EventArgs) Handles mnuColumnAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=_grid.CurrentWorksheet.Name, strColumn:=GetFirstSelectedColumnName)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=_grid.CurrentWorksheet.Name)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        PasteValuesToDataFrame()
    End Sub

    '''' <summary>
    '''' event raised on menu toolstrip click
    '''' paste data starting from selected cells
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    Private Sub mnuCellPasteRange_Click(sender As Object, e As EventArgs) Handles mnuCellPasteRange.Click
        PasteValuesToDataFrame()
    End Sub

    ''' <summary>
    ''' pastes data from clipboard to data view
    ''' </summary>
    Private Sub PasteValuesToDataFrame()
        Dim strClipBoardText As String = My.Computer.Clipboard.GetText
        If String.IsNullOrEmpty(strClipBoardText) Then
            MsgBox("No data available for pasting.", MsgBoxStyle.Information, "No Data")
            Exit Sub
        End If
        'warn user action cannot be undone
        If DialogResult.No = MsgBox("Are you sure you want to paste to these column(s)?" & Environment.NewLine &
                            "This action cannot be undone.", MessageBoxButtons.YesNo, "Paste Data") Then
            Exit Sub
        End If
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.PasteValues(strClipBoardText, GetSelectedColumnNames(), GetFirstSelectedRow)
        EndWait()
    End Sub

    Private Sub lblRowFirst_Click(sender As Object, e As EventArgs) Handles lblRowFirst.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadFirstRowPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowBack_Click(sender As Object, e As EventArgs) Handles lblRowBack.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadPreviousRowPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowNext_Click(sender As Object, e As EventArgs) Handles lblRowNext.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadNextRowPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowLast_Click(sender As Object, e As EventArgs) Handles lblRowLast.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadLastRowPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColFirst_Click(sender As Object, e As EventArgs) Handles lblColFirst.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadFirstColumnPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColBack_Click(sender As Object, e As EventArgs) Handles lblColBack.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadPreviousColumnPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColNext_Click(sender As Object, e As EventArgs) Handles lblColNext.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadNextColumnPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColLast_Click(sender As Object, e As EventArgs) Handles lblColLast.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadLastColumnPage()
        RefreshWorksheet(_grid.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub ucrDataView_Resize(sender As Object, e As EventArgs) Handles TblPanPageDisplay.Resize
        ResizeLabels()
    End Sub
End Class