' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports RDotNet
Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports unvell.ReoGrid.Events

Public Class ucrDataView
    'Public clearFilter As unvell.ReoGrid.Data.AutoColumnFilter
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Private clsAppendVariablesMetaData As New RFunction
    Private clsUnhideAllColumns As New RFunction
    Private clsInsertColumns As New RFunction
    Private clsColumnNames As New RFunction
    Private clsDeleteColumns As New RFunction
    Private clsConvertTo As New RFunction
    Private clsInsertRows As New RFunction
    Private clsDeleteRows As New RFunction
    Private clsReplaceValue As New RFunction
    Private clsRemoveFilter As New RFunction
    Private clsFreezeColumns As New RFunction
    Private clsUnfreezeColumns As New RFunction
    Private clsViewDataFrame As New RFunction
    Private clsGetDataFrame As New RFunction
    Private clsConvertOrderedFactor As New RFunction
    Private clsFilterApplied As New RFunction
    Public lstColumnNames As New List(Of KeyValuePair(Of String, String()))

    Private Sub ucrDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FreezeToHereToolStripMenuItem.Enabled = False
        UnfreezeToolStripMenuItem.Enabled = False
        grdData.Visible = False
        'autoTranslate(Me)
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        grdData.SheetTabWidth = 450
        SetRFunctions()
    End Sub

    'Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
    '    MyBase.OnFormClosing(e)
    '    If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
    '        e.Cancel = True
    '        Me.Hide()
    '    End If
    'End Sub

    Private Sub SetRFunctions()
        clsAppendVariablesMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsColumnNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
        clsInsertColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsDeleteColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        clsConvertTo.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsInsertRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsDeleteRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
        clsUnhideAllColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unhide_all_columns")
        clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsFreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$freeze_columns")
        clsUnfreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unfreeze_columns")
        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsConvertOrderedFactor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsFilterApplied.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_applied")
        clsViewDataFrame.SetRCommand("View")
        UpdateRFunctionDataFrameParameters()
    End Sub

    Private Sub mnuInsertColsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertColsBefore.Click
        clsInsertColumns.AddParameter("adjacent_column", SelectedColumnPosition(True))
        clsInsertColumns.AddParameter("num_cols", grdCurrSheet.SelectionRange.Cols)
        clsInsertColumns.AddParameter("before", "TRUE")
        'TODO This should be an option in dialog
        clsInsertColumns.AddParameter("col_name", Chr(34) & "X" & Chr(34))
        clsInsertColumns.AddParameter("use_col_name_as_prefix", "TRUE")
        frmMain.clsRLink.RunScript(clsInsertColumns.ToScript(), strComment:="Right click menu: Insert Column(s) Before")
    End Sub

    Private Sub mnuInsertColsAfter_Click(sender As Object, e As EventArgs) Handles mnuInsertColsAfter.Click
        clsInsertColumns.AddParameter("adjacent_column", SelectedColumnPosition(False))
        clsInsertColumns.AddParameter("num_cols", grdCurrSheet.SelectionRange.Cols)
        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
            clsInsertColumns.AddParameter("before", "FALSE")
        Else
            clsInsertColumns.RemoveParameterByName("before")
        End If
        'TODO This should be an option in dialog
        'This is now the default in the R method so not needed
        'but should be added if user wants to change from default
        'clsInsertColumns.AddParameter("col_name", Chr(34) & "X" & Chr(34))
        'clsInsertColumns.AddParameter("use_col_name_as_prefix", "TRUE")
        frmMain.clsRLink.RunScript(clsInsertColumns.ToScript(), strComment:="Right click menu: Insert Column(s) After")
    End Sub

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdData.CurrentWorksheet.SelectionRange.Cols = grdData.CurrentWorksheet.ColumnCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                clsDeleteColumns.AddParameter("cols", SelectedColumns())
                frmMain.clsRLink.RunScript(clsDeleteColumns.ToScript(), strComment:="Right click menu: Delete Column(s)")
            End If
        End If
    End Sub

    'Private Sub resetToDefaultWidthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resetToDefaultWidthToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.SetColumnsWidthAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols, unvell.ReoGrid.Worksheet.InitDefaultColumnWidth))
    'End Sub

    Private Sub mnuHideColumns_Click(sender As Object, e As EventArgs) Handles mnuHideColumns.Click
        clsAppendVariablesMetaData.AddParameter("col_names", SelectedColumns())
        clsAppendVariablesMetaData.AddParameter("property", "is_hidden_label")
        clsAppendVariablesMetaData.AddParameter("new_val", "TRUE")
        frmMain.clsRLink.RunScript(clsAppendVariablesMetaData.ToScript(), strComment:="Right click menu: Hide column(s)" & SelectedColumns())
        'grdData.DoAction(New unvell.ReoGrid.Actions.HideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    End Sub

    Private Sub mnuUnhideColumns_Click(sender As Object, e As EventArgs) Handles mnuUnhideColumns.Click
        dlgHideShowColumns.ShowDialog()
        'grdData.DoAction(New unvell.ReoGrid.Actions.UnhideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    End Sub

    Private Sub mnuUnhideAllColumns_Click(sender As Object, e As EventArgs) Handles mnuUnhideAllColumns.Click
        frmMain.clsRLink.RunScript(clsUnhideAllColumns.ToScript(), strComment:="Right click menu: Unhide all columns")
    End Sub

    'Private Sub groupColumnsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles groupColumnsToolStripMenuItem1.Click
    '    Dim worksheet = grdData.CurrentWorksheet

    '    Try
    '        grdData.DoAction(New unvell.ReoGrid.Actions.AddOutlineAction(unvell.ReoGrid.RowOrColumn.Column, grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineOutOfRangeException
    '        MessageBox.Show("Outline out of available range. The last column of spreadsheet cannot be grouped into outlines.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineAlreadyDefinedException
    '        MessageBox.Show("Another outline which same as selected one has already exist.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineIntersectedException
    '        MessageBox.Show("The outline to be added intersects with another existing one.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineTooMuchException
    '        MessageBox.Show("Level of outlines reached the maximum number of levels (10).")
    '    End Try
    'End Sub

    'Private Sub columnFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles columnFilterToolStripMenuItem.Click
    '    If clearFilter IsNot Nothing Then
    '        clearFilter.Detach()
    '    End If
    '    Dim filter As New unvell.ReoGrid.Actions.CreateAutoFilterAction(grdData.CurrentWorksheet.SelectionRange)
    '    grdData.DoAction(filter)
    '    clearFilter = filter.AutoColumnFilter
    'End Sub

    'Private Sub clearColumnFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clearColumnFilterToolStripMenuItem.Click
    '    If clearFilter IsNot Nothing Then
    '        clearFilter.Detach()
    '    End If

    'End Sub

    'Private Sub ungroupColumnsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ungroupColumnsToolStripMenuItem1.Click
    '    Dim removeOutlineAction = New unvell.ReoGrid.Actions.RemoveOutlineAction(unvell.ReoGrid.RowOrColumn.Column, grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols)

    '    Try
    '        grdData.DoAction(removeOutlineAction)
    '    Catch
    '    End Try

    '    If removeOutlineAction.RemovedOutline Is Nothing Then
    '        MessageBox.Show("No grouped columns and outline found at specified position.")
    '    End If
    'End Sub

    'Private Sub ungroupAllColumnsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ungroupAllColumnsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.ClearOutlineAction(unvell.ReoGrid.RowOrColumn.Column))
    'End Sub

    'Private Sub groupRowsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles groupRowsToolStripMenuItem1.Click
    '    Try
    '        grdData.DoAction(New unvell.ReoGrid.Actions.AddOutlineAction(unvell.ReoGrid.RowOrColumn.Row, grdData.CurrentWorksheet.SelectionRange.Row, grdData.CurrentWorksheet.SelectionRange.Rows))
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineOutOfRangeException
    '        MessageBox.Show("Outline out of available range. The last row of spreadsheet cannot be grouped into outlines.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineAlreadyDefinedException
    '        MessageBox.Show("Another same outline already exists.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineIntersectedException
    '        MessageBox.Show("The outline to be added intersects with another existing one.")
    '    Catch generatedExceptionName As unvell.ReoGrid.OutlineTooMuchException
    '        MessageBox.Show("Level of outlines reached the maximum number of levels (10).")
    '    End Try
    'End Sub

    'Private Sub ungroupAllRowsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ungroupAllRowsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.ClearOutlineAction(unvell.ReoGrid.RowOrColumn.Row))
    'End Sub

    'Private Sub ungroupRowsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ungroupRowsToolStripMenuItem1.Click
    '    Dim removeOutlineAction = New unvell.ReoGrid.Actions.RemoveOutlineAction(unvell.ReoGrid.RowOrColumn.Row, grdData.CurrentWorksheet.SelectionRange.Row, grdData.CurrentWorksheet.SelectionRange.Rows)

    '    Try
    '        grdData.DoAction(removeOutlineAction)
    '    Catch
    '    End Try

    '    If removeOutlineAction.RemovedOutline Is Nothing Then
    '        MessageBox.Show("No grouped rows and outline found at specified position.")
    '    End If
    'End Sub

    Private Sub mnuInsertRowsAfter_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsAfter.Click
        clsInsertRows.AddParameter("start_row", grdCurrSheet.RowHeaders(grdCurrSheet.SelectionRange.EndRow).Text)
        clsInsertRows.AddParameter("number_rows", grdData.CurrentWorksheet.SelectionRange.Rows)
        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
            clsInsertRows.AddParameter("before", "FALSE")
        Else
            clsInsertRows.RemoveParameterByName("before")
        End If
        frmMain.clsRLink.RunScript(clsInsertRows.ToScript(), strComment:="Right Click menu: Insert row(s) After")
    End Sub

    Private Sub mnuInsertRowsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsBefore.Click
        clsInsertRows.AddParameter("start_row", grdCurrSheet.RowHeaders(grdCurrSheet.SelectionRange.Row).Text)
        clsInsertRows.AddParameter("number_rows", grdData.CurrentWorksheet.SelectionRange.Rows)
        clsInsertRows.AddParameter("before", "TRUE")
        frmMain.clsRLink.RunScript(clsInsertRows.ToScript(), strComment:="Right Click menu: Insert row(s) Before")
    End Sub

    Private Sub mnuDeleteRows_Click(sender As Object, e As EventArgs) Handles mnuDeleteRows.Click
        Dim Delete = MsgBox("Are you sure you want to delete these row(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Row(s)")
        If Delete = DialogResult.Yes Then
            clsDeleteRows.AddParameter("row_names", SelectedRows())
            frmMain.clsRLink.RunScript(clsDeleteRows.ToScript(), strComment:="Right Click menu: Delete row(s)")
        End If
    End Sub

    'Private Sub resetToDefaultHeightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resetToDefaultHeightToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.SetRowsHeightAction(grdData.CurrentWorksheet.SelectionRange.Row, grdData.CurrentWorksheet.SelectionRange.Rows, unvell.ReoGrid.Worksheet.InitDefaultRowHeight))
    'End Sub

    'Private Sub hideRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hideRowsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.HideRowsAction(grdData.CurrentWorksheet.SelectionRange.Row, grdData.CurrentWorksheet.SelectionRange.Rows))
    'End Sub

    'Private Sub unhideRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles unhideRowsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.UnhideRowsAction(grdData.CurrentWorksheet.SelectionRange.Row, grdData.CurrentWorksheet.SelectionRange.Rows))
    'End Sub

    'Private Sub cutRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cutRangeToolStripMenuItem.Click
    '    Try
    '        grdData.CurrentWorksheet.Cut()
    '    Catch generatedExceptionName As unvell.ReoGrid.RangeIntersectionException
    '        MessageBox.Show("Cannot cut a range that Is a part Of another merged cell.")
    '    Catch
    '        MessageBox.Show("We can't to do that for selected range.")
    '    End Try
    'End Sub

    Public Sub CopyRange()
        Try
            grdData.CurrentWorksheet.Copy()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    'Private Sub pasteRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pasteRangeToolStripMenuItem.Click
    '    Try
    '        grdData.CurrentWorksheet.Paste()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Public Sub SelectAllText()
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.SelectAll()
        End If
    End Sub

    Private Sub insertSheet_Click(sender As Object, e As EventArgs) Handles insertSheet.Click
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteSheet.Click
        Dim strScript As String
        Dim Delete = MsgBox("Are you sure you want to delete this dataframe?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Sheet")
        If grdData.Worksheets.Count > 0 Then
            If Delete = DialogResult.Yes Then
                strScript = frmMain.clsRLink.strInstatDataObject & "$delete_dataframe(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ")"
                frmMain.clsRLink.RunScript(strScript)
            End If
        End If
    End Sub

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        If grdData.Worksheets.Count < 1 Then
            grdData.Hide()
        ElseIf grdCurrSheet.Equals(e.Worksheet) Then
            UpdateCurrentWorksheet()
            grdData.Refresh()
        End If
    End Sub

    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        UpdateCurrentWorksheet()
    End Sub

    Public Sub UpdateCurrentWorksheet()
        Dim iRowCount As Integer
        Dim iColumnCount As Integer

        grdCurrSheet = grdData.CurrentWorksheet
        If grdCurrSheet IsNot Nothing AndAlso frmMain.clsRLink.GetDataFrameNames().Contains(grdCurrSheet.Name) Then
            UpdateRFunctionDataFrameParameters()
            frmMain.strCurrentDataFrame = grdCurrSheet.Name
            frmMain.tstatus.Text = grdCurrSheet.Name
            grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            iRowCount = frmMain.clsRLink.GetDataFrameLength(grdCurrSheet.Name, True)
            iColumnCount = frmMain.clsRLink.GetDataFrameColumnCount(grdCurrSheet.Name)
            lblRowDisplay.Text = "Showing " & grdCurrSheet.RowCount & " of " & iRowCount & " rows"
            If frmMain.clsRLink.RunInternalScriptGetValue(clsFilterApplied.ToScript()).AsLogical(0) Then
                lblRowDisplay.Text = lblRowDisplay.Text & " (" & frmMain.clsRLink.GetDataFrameLength(grdCurrSheet.Name, False) & ")"
            End If
            lblRowDisplay.Text = lblRowDisplay.Text & " | Showing " & grdCurrSheet.ColumnCount & " of " & iColumnCount & " columns"
        Else
            frmMain.tstatus.Text = "No data loaded"
            lblRowDisplay.Text = ""
        End If
    End Sub

    'TODO discuss validation for cell editing
    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        'temporary disabled editing
        'e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        ReplaceValueInData(e.NewData.ToString(), e.Cell.Row, e.Cell.Column)
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
    End Sub

    Private Sub ReplaceValueInData(strNewValue As String, iRow As Integer, iCol As Integer)
        Dim dblValue As Double
        Dim iValue As Integer
        Dim lstCurrentDataColumns As String()
        Dim strCurrentColumn As String
        Dim clsGetVariablesMetadata As New RFunction
        Dim clsGetFactorLevels As New RFunction
        Dim strCellDataType As String
        Dim chrCurrentFactorLevels As CharacterVector
        Dim bValid As Boolean = False

        clsGetFactorLevels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels")
        clsGetFactorLevels.AddParameter("data_name", Chr(34) & grdData.CurrentWorksheet.Name & Chr(34))

        clsGetVariablesMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & grdData.CurrentWorksheet.Name & Chr(34))
        clsGetVariablesMetadata.AddParameter("property", "data_type_label")

        lstCurrentDataColumns = lstColumnNames.Find(Function(x) x.Key = grdData.CurrentWorksheet.Name).Value
        strCurrentColumn = lstCurrentDataColumns(iCol)

        clsGetVariablesMetadata.AddParameter("column", Chr(34) & strCurrentColumn & Chr(34))
        clsGetFactorLevels.AddParameter("col_name", Chr(34) & strCurrentColumn & Chr(34))
        strCellDataType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript()).AsCharacter(0)

        clsReplaceValue.AddParameter("col_name", Chr(34) & strCurrentColumn & Chr(34))
        clsReplaceValue.AddParameter("rows", Chr(34) & grdCurrSheet.RowHeaders.Item(iRow).Text & Chr(34))

        If strNewValue = "NA" Then
            clsReplaceValue.AddParameter("new_value", strNewValue)
            bValid = True
        Else
            Select Case strCellDataType
                Case "factor"
                    chrCurrentFactorLevels = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFactorLevels.ToScript()).AsCharacter
                    If Not chrCurrentFactorLevels.Contains(strNewValue) Then
                        MsgBox("Invalid value: " & strNewValue & Environment.NewLine & "This column is: factor. Values must be an existing level of this factor column.", MsgBoxStyle.Exclamation, "Invalid Value")
                    Else
                        clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
                        bValid = True
                    End If
                Case "numeric"
                    If Double.TryParse(strNewValue, dblValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        MsgBox("Invalid value: " & strNewValue & Environment.NewLine & "This column is: numeric. Values must be numeric.", MsgBoxStyle.Exclamation, "Invalid Value")
                    End If
                Case "integer"
                    If Integer.TryParse(strNewValue, iValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        MsgBox("Invalid value: " & strNewValue & Environment.NewLine & "This column is: integer. Values must be integer.", MsgBoxStyle.Exclamation, "Invalid Value")
                    End If
                    'Currently removed as this is the class for a blank column
                    'Case "logical"
                    '    'Should we accept 'true'/'false'/'True' etc. as logical values?
                    '    If e.NewData = "TRUE" OrElse e.NewData = "FALSE" Then
                    '        clsReplaceValue.AddParameter("new_value", e.NewData)
                    '        bValid = True
                    '    Else
                    '        MsgBox("Invalid value: " & e.NewData.ToString() & Environment.NewLine & "This column is: logical. Values must be logical (either TRUE or FALSE).", MsgBoxStyle.Exclamation, "Invalid Value")
                    '        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                    '    End If
                    'Case "character"
                    'clsReplaceValue.AddParameter("new_value", Chr(34) & e.NewData & Chr(34))
                    'bValid = True
                Case Else
                    If Double.TryParse(strNewValue, dblValue) OrElse strNewValue = "TRUE" OrElse strNewValue = "FALSE" Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                    Else
                        clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
                    End If
                    bValid = True
            End Select
        End If

        If bValid Then
            frmMain.clsRLink.RunScript(clsReplaceValue.ToScript(), strComment:="Replace Value in Data")
        End If
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub MoveOrCopySheet_Click(sender As Object, e As EventArgs) Handles CopySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuConvertVariate_Click(sender As Object, e As EventArgs) Handles mnuConvertVariate.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "numeric" & Chr(34))
        clsConvertTo.AddParameter("col_names", SelectedColumns())
        frmMain.clsRLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Numeric")
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34))
        clsConvertTo.AddParameter("col_names", SelectedColumns())
        frmMain.clsRLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        clsConvertTo.AddParameter("col_names", SelectedColumns())
        frmMain.clsRLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
    End Sub

    Private Function SelectedColumns(Optional bWithQuotes As Boolean = True) As String
        Dim lstSelectedColumns As New List(Of String)
        Dim strCols As String = ""
        Dim lstCurrentDataColumns As String()

        lstCurrentDataColumns = lstColumnNames.Find(Function(x) x.Key = grdData.CurrentWorksheet.Name).Value

        If lstCurrentDataColumns IsNot Nothing AndAlso lstCurrentDataColumns.Count > 0 Then
            For i As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.Col + grdData.CurrentWorksheet.SelectionRange.Cols - 1
                lstSelectedColumns.Add(lstCurrentDataColumns(i))
            Next

            strCols = "c("
            For j As Integer = 0 To lstSelectedColumns.Count - 1
                If j > 0 Then
                    strCols = strCols & ","
                End If
                If bWithQuotes Then
                    strCols = strCols & Chr(34) & lstSelectedColumns(j) & Chr(34)
                Else
                    strCols = strCols & lstSelectedColumns(j)
                End If
            Next
            strCols = strCols & ")"
        End If
        Return strCols
    End Function

    Private Function SelectedRows(Optional bWithQuotes As Boolean = True) As String
        Dim lstSelectedRows As New List(Of String)
        Dim strRows As String = ""

        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Row To grdData.CurrentWorksheet.SelectionRange.Row + grdData.CurrentWorksheet.SelectionRange.Rows - 1
            lstSelectedRows.Add(grdCurrSheet.RowHeaders.Item(i).Text)
        Next
        strRows = "c("
        For j As Integer = 0 To lstSelectedRows.Count - 1
            If j > 0 Then
                strRows = strRows & ","
            End If
            If bWithQuotes Then
                strRows = strRows & Chr(34) & lstSelectedRows(j) & Chr(34)
            Else
                strRows = strRows & lstSelectedRows(j)
            End If
        Next
        strRows = strRows & ")"
        Return strRows
    End Function

    Private Function SelectedColumnsAsArray() As String()
        Dim strSelectedColumns As String()
        Dim lstCurrentDataColumns As String()

        lstCurrentDataColumns = lstColumnNames.Find(Function(x) x.Key = grdData.CurrentWorksheet.Name).Value

        If lstColumnNames IsNot Nothing AndAlso lstColumnNames.Count > 0 Then
            strSelectedColumns = New String(grdData.CurrentWorksheet.SelectionRange.Cols - 1) {}
            For i As Integer = 0 To grdData.CurrentWorksheet.SelectionRange.Cols - 1
                strSelectedColumns(i) = lstCurrentDataColumns(i + grdData.CurrentWorksheet.SelectionRange.Col)
            Next
            Return strSelectedColumns
        Else
            strSelectedColumns = New String() {}
        End If
        Return strSelectedColumns
    End Function

    Private Function SelectedColumnPosition(bFirstNotLast As Boolean)
        Dim lstCurrentDataColumns As String()

        lstCurrentDataColumns = lstColumnNames.Find(Function(x) x.Key = grdData.CurrentWorksheet.Name).Value
        If bFirstNotLast Then
            Return Chr(34) & lstCurrentDataColumns(grdData.CurrentWorksheet.SelectionRange.Col) & Chr(34)
        Else
            Return Chr(34) & lstCurrentDataColumns(grdData.CurrentWorksheet.SelectionRange.EndCol) & Chr(34)
        End If
    End Function

    Private Sub columnFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles columnFilterToolStripMenuItem.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub UpdateRFunctionDataFrameParameters()
        If grdCurrSheet IsNot Nothing Then
            clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsColumnNames.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsInsertColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsDeleteColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsConvertTo.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsInsertRows.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsDeleteRows.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsUnhideAllColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsReplaceValue.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsRemoveFilter.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsFreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsUnfreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsGetDataFrame.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsConvertOrderedFactor.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsFilterApplied.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
        End If
    End Sub

    Public Sub SetColumnNames(strDataFrameName As String, strColumnNames As String())
        Dim iIndex As Integer
        iIndex = lstColumnNames.FindIndex(Function(x) x.Key = strDataFrameName)
        If iIndex <> -1 Then
            lstColumnNames.RemoveAt(iIndex)
        End If
        lstColumnNames.Add(New KeyValuePair(Of String, String())(strDataFrameName, strColumnNames))
    End Sub

    Private Sub mnuFilter_Click(sender As Object, e As EventArgs) Handles mnuFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilter.Click
        frmMain.clsRLink.RunScript(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub clearColumnFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clearColumnFilterToolStripMenuItem.Click
        frmMain.clsRLink.RunScript(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        dlgSort.ShowDialog()
    End Sub

    Private Sub FreezeToHereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreezeToHereToolStripMenuItem.Click
        Dim strLastSelectedColumn As String
        Dim strSelectedColumns As String()

        strSelectedColumns = SelectedColumnsAsArray()
        If strSelectedColumns.Length <> 0 Then
            strLastSelectedColumn = strSelectedColumns(strSelectedColumns.Length - 1)
            clsFreezeColumns.AddParameter("column", Chr(34) & strLastSelectedColumn & Chr(34))
            frmMain.clsRLink.RunScript(clsFreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
        End If
    End Sub

    Private Sub UnfreezeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnfreezeToolStripMenuItem.Click
        frmMain.clsRLink.RunScript(clsUnfreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
    End Sub

    Private Sub grdCurrSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforeCut
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforePaste
        e.IsCancelled = True
        If Not e.Range.IsSingleCell Then
            MsgBox("Pasting multiple cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "Try pasting one cell at a time.", MsgBoxStyle.Information, "Cannot paste multiple cells")
        Else
            ReplaceValueInData(Clipboard.GetText(), e.Range.Row, e.Range.Col)
        End If
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

    Private Sub mnuConvert_Click(sender As Object, e As EventArgs) Handles mnuConvert.Click
        'TODO Selected column should automatically appear in dialog
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub copyRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles copyRangeToolStripMenuItem.Click
        grdData.CurrentWorksheet.Copy()
    End Sub

    Private Sub ViewSheet_Click(sender As Object, e As EventArgs) Handles ViewSheet.Click
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame)
        clsViewDataFrame.AddParameter("title", Chr(34) & grdCurrSheet.Name & Chr(34))
        frmMain.clsRLink.RunScript(clsViewDataFrame.ToScript, strComment:="Right Click Menu: View R Data Frame")
    End Sub

    Private Sub mnuConvertDate_Click(sender As Object, e As EventArgs) Handles mnuConvertToDate.Click
        dlgMakeDate.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgMakeDate.ShowDialog()
    End Sub

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        clsConvertOrderedFactor.AddParameter("col_names", SelectedColumns())
        clsConvertOrderedFactor.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34))
        frmMain.clsRLink.RunScript(clsConvertOrderedFactor.ToScript, strComment:="Right Click Menu: Convert to Ordered Factor")
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub AddCommentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddComment.Click
        dlgAddComment.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
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
End Class
