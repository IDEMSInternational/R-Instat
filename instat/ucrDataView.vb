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
Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports unvell.ReoGrid.Events
Imports System.ComponentModel
Imports unvell.ReoGrid

Public Class ucrDataView
    Private _clsDataBook As clsDataBook

    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet

    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub ucrDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdData.Visible = False
        mnuInsertColsBefore.Visible = False
        mnuInsertColsAfter.Visible = False
        autoTranslate(Me)
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        grdData.SheetTabWidth = 450
    End Sub

    Private Sub RefreshWorksheet(fillWorkSheet As Worksheet, dataFrame As clsDataFrame)
        If Not dataFrame.clsVisiblePage.HasChanged Then
            Exit Sub
        End If
        AddColumns(dataFrame.clsVisiblePage, fillWorkSheet)
        AddRowData(dataFrame, fillWorkSheet)
        UpdateWorksheetStyle(fillWorkSheet)
        dataFrame.clsVisiblePage.HasChanged = False
        grdData.CurrentWorksheet = fillWorkSheet
        RefreshDisplayInformation()
    End Sub

    Public Sub UpdateAllWorksheetStyles()
        For Each worksheet In grdData.Worksheets
            UpdateWorksheetStyle(worksheet)
        Next
    End Sub

    Private Sub UpdateWorksheetStyle(fillWorkSheet As Worksheet)
        fillWorkSheet.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName,
                                .TextColor = frmMain.clsInstatOptions.clrEditor,
                                .FontSize = frmMain.clsInstatOptions.fntEditor.Size,
                                .FontName = frmMain.clsInstatOptions.fntEditor.Name
                                })
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

    Private Sub AddAndUpdateWorksheets(grid As ReoGridControl)
        Dim firstAddedWorksheet As Worksheet = Nothing
        For Each clsDataFrame In _clsDataBook.DataFrames
            Dim fillWorkSheet As Worksheet = grid.Worksheets.Where(Function(x) x.Name = clsDataFrame.strName).FirstOrDefault
            If fillWorkSheet Is Nothing Then
                fillWorkSheet = grid.CreateWorksheet(clsDataFrame.strName)
                grid.AddWorksheet(fillWorkSheet)
                If firstAddedWorksheet Is Nothing Then
                    firstAddedWorksheet = fillWorkSheet
                End If
            End If
            RefreshWorksheet(fillWorkSheet, clsDataFrame)
        Next
        If firstAddedWorksheet IsNot Nothing Then
            grid.CurrentWorksheet = firstAddedWorksheet
        End If
    End Sub

    Private Sub RemoveOldWorksheets(grid As ReoGridControl)
        For i = grid.Worksheets.Count - 1 To 0 Step -1
            Dim iGridWorkheetsPosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = grid.Worksheets(index:=iGridWorkheetsPosition).Name).Count = 0 Then
                grid.RemoveWorksheet(i)
            End If
        Next
    End Sub

    Private Sub AddColumns(dataFramePage As clsDataFramePage, workSheet As Worksheet)
        Dim workSheetColumnHeader As ColumnHeader
        workSheet.Columns = dataFramePage.lstColumns.Count
        For i = 0 To dataFramePage.lstColumns.Count - 1
            workSheetColumnHeader = workSheet.ColumnHeaders(i)
            workSheetColumnHeader.Text = dataFramePage.lstColumns(i).strDisplayName
            workSheetColumnHeader.TextColor = dataFramePage.lstColumns(i).clsColour
            workSheetColumnHeader.Style.BackColor = dataFramePage.lstColumns(i).clsBackGroundColour
        Next
    End Sub

    Private Sub AddRowData(dataFrame As clsDataFrame, workSheet As Worksheet)
        Dim textColour As Color
        Dim strRowNames As String()

        If dataFrame.iDisplayedRowCount = 0 Then
            AddBlankRow(workSheet)
            Exit Sub
        End If
        workSheet.Rows = dataFrame.iDisplayedRowCount
        UpdateWorksheetSettings(workSheet)

        If dataFrame.clsFilter.bApplied Then
            textColour = Color.Red
        Else
            textColour = Color.DarkBlue
        End If

        strRowNames = dataFrame.strRowNames()
        For i = 0 To workSheet.Rows - 1
            For j = 0 To workSheet.Columns - 1
                workSheet(row:=i, col:=j) = dataFrame.Data(i, j)
            Next
            workSheet.RowHeaders.Item(i).Text = strRowNames(i)
            workSheet.RowHeaders(i).TextColor = textColour
        Next
    End Sub

    Private Sub UpdateWorksheetSettings(workSheet As Worksheet)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, True)
        workSheet.SetRowsHeight(0, 1, 20)
        Dim rngDataRange As New RangePosition(0, 0, workSheet.Rows, workSheet.Columns)
        workSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)
    End Sub

    Private Sub AddBlankRow(workSheet As Worksheet)
        workSheet.Rows = 1
        For i = 0 To workSheet.Columns - 1
            workSheet(0, col:=i) = ""
        Next
        workSheet.SetRowsHeight(0, 1, 0.1)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, False)
        Exit Sub
    End Sub

    Public Sub RefreshGridData()
        If _clsDataBook Is Nothing Then
            Exit Sub
        End If
        _clsDataBook.RefreshData()
        AddAndUpdateWorksheets(grdData)
        RemoveOldWorksheets(grdData)
        If _clsDataBook.DataFrames.Count = 0 Then
            RefreshDisplayInformation()
        End If
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(grdCurrSheet.Name)
    End Function

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdData.CurrentWorksheet.SelectionRange.Cols = GetCurrentDataFrameFocus()?.iTotalColumnCount Then
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
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(grdData.CurrentWorksheet.SelectionRange.Rows, GetLastSelectedRow(), False)
        EndWait()
    End Sub

    Private Sub mnuInsertRowsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsBefore.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(grdData.CurrentWorksheet.SelectionRange.Rows, GetFirstSelectedRow, True)
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
            grdData.CurrentWorksheet.Copy()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.SelectAll()
        End If
    End Sub

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(grdCurrSheet.Name)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        If grdData.Worksheets.Count < 1 Then
            grdData.Hide()
        ElseIf grdCurrSheet.Equals(e.Worksheet) Then
            RefreshDisplayInformation()
            grdData.Refresh()
        End If
    End Sub

    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        RefreshDisplayInformation()
    End Sub


    Private Sub RefreshDisplayInformation()
        grdCurrSheet = grdData.CurrentWorksheet
        grdData.Visible = Not grdData.Worksheets.Count = 0
        If grdCurrSheet IsNot Nothing AndAlso _clsDataBook IsNot Nothing AndAlso GetCurrentDataFrameFocus() IsNot Nothing Then
            frmMain.strCurrentDataFrame = grdCurrSheet.Name
            frmMain.tstatus.Text = grdCurrSheet.Name
            grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
            SetDisplayLabels()
            UpdateNavigationButtons()
            'hide startup menu items
            panelSectionsAll.Visible = False
            TblPanPageDisplay.Visible = True
        Else
            frmMain.tstatus.Text = GetTranslation("No data loaded")
            TblPanPageDisplay.Visible = False
            'show startup menu items
            panelSectionsAll.Visible = True
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

    End Sub

    'TODO discuss validation for cell editing
    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        'temporary disabled editing
        'e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        ReplaceValueInData(e.NewData.ToString(),
                           GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.Cell.Column).strName,
                           GetCurrentDataFrameFocus().clsVisiblePage.RowNames()(e.Cell.Row))
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
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
        dlgRenameDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub MoveOrCopySheet_Click(sender As Object, e As EventArgs) Handles CopySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuLevelsLabels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        If IsFirstSelectedColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay)
        Dim lstColumns As New List(Of clsColumnHeaderDisplay)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.Col + grdData.CurrentWorksheet.SelectionRange.Cols - 1
            lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(i))
        Next
        Return lstColumns
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
        Return grdData.CurrentWorksheet.SelectionRange.Cols = 1
    End Function

    Private Function IsFirstSelectedColumnAFactor() As Boolean
        Return GetSelectedColumns().FirstOrDefault().bIsFactor
    End Function

    Private Function GetFirstSelectedRow() As String
        Return grdCurrSheet.RowHeaders.Item(grdData.CurrentWorksheet.SelectionRange.Row).Text
    End Function

    Private Function GetSelectedRows() As List(Of String)
        Dim lstSelectedRows As New List(Of String)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Row To grdData.CurrentWorksheet.SelectionRange.Row + grdData.CurrentWorksheet.SelectionRange.Rows - 1
            lstSelectedRows.Add(grdCurrSheet.RowHeaders.Item(i).Text)
        Next
        Return lstSelectedRows
    End Function

    Private Function GetLastSelectedRow() As String
        Return grdCurrSheet.RowHeaders.Item(grdData.CurrentWorksheet.SelectionRange.EndRow).Text
    End Function

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        grdData.Enabled = False
    End Sub

    Private Sub EndWait()
        grdData.Enabled = True
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
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub mnuFilter_Click(sender As Object, e As EventArgs) Handles mnuFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
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
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
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

    Private Sub grdCurrSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforeCut
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforePaste
        e.IsCancelled = True 'prevents pasted data from being added directly into the data view 
        'validate columns
        If e.Range.EndCol >= GetCurrentDataFrameFocus().clsVisiblePage.lstColumns.Count Then
            'this happens when Ctrl + V is pressed and the data to be pasted has more columns
            'than columns between start and end column 
            MsgBox("Columns copied are more than the current data frame columns.", MsgBoxStyle.Critical, "Excess Columns")
            Exit Sub
        End If
        'TODO check see if pasted range is same as selected
        PasteValuesToDataFrame()
    End Sub

    ' Not currently working. Bug with reogrid reported here:
    ' https://reogrid.net/forum/viewtopic.php?id=350
    Private Sub grdCurrSheet_BeforeRangeMove(sender As Object, e As BeforeCopyOrMoveRangeEventArgs) Handles grdCurrSheet.BeforeRangeMove
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
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
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub



    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(grdCurrSheet.Name, GetFirstSelectedRow())
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuComment_Click(sender As Object, e As EventArgs) Handles mnuComment.Click
        dlgAddComment.SetPosition(grdCurrSheet.Name, GetFirstSelectedRow(), GetFirstSelectedColumnName())
        dlgAddComment.ShowDialog()
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        Dim grdWorksheet As unvell.ReoGrid.Worksheet

        If grdData IsNot Nothing Then
            grdWorksheet = grdData.GetWorksheetByName(strDataName)
            If grdWorksheet IsNot Nothing Then
                grdData.CurrentWorksheet = grdWorksheet
            End If
        End If
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        If grdData IsNot Nothing Then
            If grdData.Worksheets.Count > iIndex Then
                grdData.CurrentWorksheet = grdData.Worksheets(iIndex)
            Else
                ' Developer error?
            End If
        End If
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
            mnuInsertColsBefore.Text = "Insert " & grdData.CurrentWorksheet.SelectionRange.Cols & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & grdData.CurrentWorksheet.SelectionRange.Cols & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub HideSheet_Click(sender As Object, e As EventArgs) Handles HideSheet.Click
        StartWait()
        _clsDataBook.HideDataFrame(grdCurrSheet.Name)
        EndWait()
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub statusColumnMenu_Opening(sender As Object, e As CancelEventArgs) Handles statusColumnMenu.Opening
        HideSheet.Enabled = (grdData.Worksheets.Count > 1)
    End Sub

    Private Sub mnuReorderColumns_Click(sender As Object, e As EventArgs) Handles mnuReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuRenameColumn_Click(sender As Object, e As EventArgs) Handles mnuRenameColumn.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuDuplColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
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
            End If
        Next
    End Sub

    Private Sub mnuLebelsLevel_Click(sender As Object, e As EventArgs) Handles mnuLabelsLevel.Click
        If IsFirstSelectedColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedColumnName, grdCurrSheet.Name)
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuSorts_Click(sender As Object, e As EventArgs) Handles mnuSorts.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName, grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFilters_Click(sender As Object, e As EventArgs) Handles mnuFilters.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilters_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilters.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub grdCurrSheet_CellDataChanged(sender As Object, e As CellEventArgs) Handles grdCurrSheet.CellDataChanged
        frmMain.bDataSaved = False
    End Sub

    Private Sub linkNewDataFrame_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartNewDataFrame.LinkClicked
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub linkOpenFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenFile.LinkClicked
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub linkOpenLibrary_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenLibrary.LinkClicked
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
        lblMenuItemPath.Text = If(String.IsNullOrEmpty(linkMenuItem.Tag), "", Path.GetDirectoryName(linkMenuItem.Tag))
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
        Help.ShowHelp(frmMain, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "0")
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
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name, strColumn:=GetFirstSelectedColumnName)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name)
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
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowBack_Click(sender As Object, e As EventArgs) Handles lblRowBack.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadPreviousRowPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowNext_Click(sender As Object, e As EventArgs) Handles lblRowNext.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadNextRowPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowLast_Click(sender As Object, e As EventArgs) Handles lblRowLast.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadLastRowPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColFirst_Click(sender As Object, e As EventArgs) Handles lblColFirst.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadFirstColumnPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColBack_Click(sender As Object, e As EventArgs) Handles lblColBack.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadPreviousColumnPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColNext_Click(sender As Object, e As EventArgs) Handles lblColNext.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadNextColumnPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColLast_Click(sender As Object, e As EventArgs) Handles lblColLast.Click
        GetCurrentDataFrameFocus().clsVisiblePage.LoadLastColumnPage()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

End Class
