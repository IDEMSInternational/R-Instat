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
    Private clsHideDataFrame As New RFunction
    Private clsGetCurrentFilterName As New RFunction
    Public lstColumnNames As New List(Of KeyValuePair(Of String, String()))
    Private strFilterName As String
    Private strNoFilter As String = "no_filter"
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
        clsHideDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata")
        clsViewDataFrame.SetRCommand("View")
        clsGetCurrentFilterName.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_current_filter_name")
        UpdateRFunctionDataFrameParameters()
    End Sub

    'Private Sub mnuInsertColsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertColsBefore.Click
    '    clsInsertColumns.AddParameter("adjacent_column", SelectedColumnPosition(True))
    '    clsInsertColumns.AddParameter("num_cols", grdCurrSheet.SelectionRange.Cols)
    '    clsInsertColumns.AddParameter("before", "TRUE")
    '    'TODO This should be an option in dialog
    '    clsInsertColumns.AddParameter("col_name", Chr(34) & "X" & Chr(34))
    '    clsInsertColumns.AddParameter("use_col_name_as_prefix", "TRUE")
    '    RunScriptFromDataView(clsInsertColumns.ToScript(), strComment:="Right click menu: Insert Column(s) Before")
    'End Sub

    'Private Sub mnuInsertColsAfter_Click(sender As Object, e As EventArgs) Handles mnuInsertColsAfter.Click
    '    clsInsertColumns.AddParameter("adjacent_column", SelectedColumnPosition(False))
    '    clsInsertColumns.AddParameter("num_cols", grdCurrSheet.SelectionRange.Cols)
    '    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '        clsInsertColumns.AddParameter("before", "FALSE")
    '    Else
    '        clsInsertColumns.RemoveParameterByName("before")
    '    End If
    '    'TODO This should be an option in dialog
    '    'This is now the default in the R method so not needed
    '    'but should be added if user wants to change from default
    '    'clsInsertColumns.AddParameter("col_name", Chr(34) & "X" & Chr(34))
    '    'clsInsertColumns.AddParameter("use_col_name_as_prefix", "TRUE")
    '    RunScriptFromDataView(clsInsertColumns.ToScript(), strComment:="Right click menu: Insert Column(s) After")
    'End Sub

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdData.CurrentWorksheet.SelectionRange.Cols = grdData.CurrentWorksheet.ColumnCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                clsDeleteColumns.AddParameter("cols", SelectedColumns())
                RunScriptFromDataView(clsDeleteColumns.ToScript(), strComment:="Right click menu: Delete Column(s)")
            End If
        End If
    End Sub

    'Private Sub resetToDefaultWidthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resetToDefaultWidthToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.SetColumnsWidthAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols, unvell.ReoGrid.Worksheet.InitDefaultColumnWidth))
    'End Sub

    'Private Sub mnuHideColumns_Click(sender As Object, e As EventArgs)
    '    clsAppendVariablesMetaData.AddParameter("col_names", SelectedColumns())
    '    clsAppendVariablesMetaData.AddParameter("property", "is_hidden_label")
    '    clsAppendVariablesMetaData.AddParameter("new_val", "TRUE")
    '    RunScriptFromDataView(clsAppendVariablesMetaData.ToScript(), strComment:="Right click menu: Hide column(s)" & SelectedColumns())
    '    'grdData.DoAction(New unvell.ReoGrid.Actions.HideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    'End Sub

    'Private Sub mnuUnhideColumns_Click(sender As Object, e As EventArgs)
    '    dlgHideShowColumns.SetCurrentDataframe(grdCurrSheet.Name)
    '    dlgHideShowColumns.ShowDialog()
    '    'grdData.DoAction(New unvell.ReoGrid.Actions.UnhideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    'End Sub

    'Private Sub mnuUnhideAllColumns_Click(sender As Object, e As EventArgs)
    '    RunScriptFromDataView(clsUnhideAllColumns.ToScript(), strComment:="Right click menu: Unhide all columns")
    'End Sub

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
        RunScriptFromDataView(clsInsertRows.ToScript(), strComment:="Right click menu: Insert row(s) After")
    End Sub

    Private Sub mnuInsertRowsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsBefore.Click
        clsInsertRows.AddParameter("start_row", grdCurrSheet.RowHeaders(grdCurrSheet.SelectionRange.Row).Text)
        clsInsertRows.AddParameter("number_rows", grdData.CurrentWorksheet.SelectionRange.Rows)
        clsInsertRows.AddParameter("before", "TRUE")
        RunScriptFromDataView(clsInsertRows.ToScript(), strComment:="Right click menu: Insert row(s) Before")
    End Sub

    Private Sub mnuDeleteRows_Click(sender As Object, e As EventArgs) Handles mnuDeleteRows.Click
        Dim Delete = MsgBox("Are you sure you want to delete these row(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Row(s)")
        If Delete = DialogResult.Yes Then
            clsDeleteRows.AddParameter("row_names", SelectedRows())
            RunScriptFromDataView(clsDeleteRows.ToScript(), strComment:="Right click menu: Delete row(s)")
        End If
    End Sub

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

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        'Dim strScript As String
        'Dim Delete = MsgBox("Are you sure you want to delete this dataframe?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Sheet")
        'If grdData.Worksheets.Count > 0 Then
        '    If Delete = DialogResult.Yes Then
        '        strScript = frmMain.clsRLink.strInstatDataObject & "$delete_dataframe(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ")"
        '        RunScriptFromDataView(strScript)
        '    End If
        'End If
        dlgDeleteDataFrames.SetDataFrameToAdd(grdCurrSheet.Name)
        dlgDeleteDataFrames.ShowDialog()
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
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
            iRowCount = frmMain.clsRLink.GetDataFrameLength(grdCurrSheet.Name, True)
            iColumnCount = frmMain.clsRLink.GetDataFrameColumnCount(grdCurrSheet.Name)
            lblRowDisplay.Text = "Showing " & grdCurrSheet.RowCount & " of " & iRowCount & " rows"
            strFilterName = frmMain.clsRLink.RunInternalScriptGetValue(clsGetCurrentFilterName.ToScript(), bSilent:=True).AsCharacter(0)
            If frmMain.clsRLink.RunInternalScriptGetValue(clsFilterApplied.ToScript()).AsLogical(0) Then
                lblRowDisplay.Text = lblRowDisplay.Text & " (" & frmMain.clsRLink.GetDataFrameLength(grdCurrSheet.Name, False) & ")" & "|Active filter:" & strFilterName
            End If
            lblRowDisplay.Text = lblRowDisplay.Text & " | Showing " & grdCurrSheet.ColumnCount & " of " & iColumnCount & " columns"
            'hide startup menu items
            panelSectionsAll.Visible = False
        Else
            frmMain.tstatus.Text = "No data loaded"
            lblRowDisplay.Text = ""
            'show startup menu items
            panelSectionsAll.Visible = True
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

        'trim white space from ends of value
        strNewValue = strNewValue.Trim()

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
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: factor. Values must be an existing level of this factor column.", MsgBoxStyle.Exclamation, "Invalid Value")
                    Else
                        clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
                        bValid = True
                    End If
                Case "numeric"
                    If Double.TryParse(strNewValue, dblValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: numeric. Values must be numeric.", MsgBoxStyle.Exclamation, "Invalid Value")
                    End If
                Case "integer"
                    If Integer.TryParse(strNewValue, iValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        MsgBox("Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: integer. Values must be integer.", MsgBoxStyle.Exclamation, "Invalid Value")
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
            RunScriptFromDataView(clsReplaceValue.ToScript(), strComment:="Replace Value in Data")
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
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "numeric" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Numeric")
    End Sub

    Private Sub mnuLevelsLabels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        Dim strType As String
        Dim strColumns() As String

        strColumns = SelectedColumnsAsArray()
        If strColumns.Count = 1 Then
            strType = frmMain.clsRLink.GetColumnType(grdCurrSheet.Name, strColumns(0))
            If strType.Contains("factor") Then
                dlgLabelsLevels.SetCurrentColumn(strColumns(0), grdCurrSheet.Name)
            End If
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Logical")
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
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

    Private Sub mnuColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuColumnFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub UpdateRFunctionDataFrameParameters()
        If grdCurrSheet IsNot Nothing Then
            clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsColumnNames.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsInsertColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsDeleteColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsConvertTo.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsInsertRows.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsDeleteRows.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsUnhideAllColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsReplaceValue.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsRemoveFilter.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsFreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsUnfreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsGetDataFrame.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsConvertOrderedFactor.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsFilterApplied.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
            clsGetCurrentFilterName.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34), iPosition:=0)
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
        RunScriptFromDataView(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        RunScriptFromDataView(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFreezeToHere_Click(sender As Object, e As EventArgs)
        Dim strLastSelectedColumn As String
        Dim strSelectedColumns As String()

        strSelectedColumns = SelectedColumnsAsArray()
        If strSelectedColumns.Length <> 0 Then
            strLastSelectedColumn = strSelectedColumns(strSelectedColumns.Length - 1)
            clsFreezeColumns.AddParameter("column", Chr(34) & strLastSelectedColumn & Chr(34))
            RunScriptFromDataView(clsFreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
        End If
    End Sub

    Private Sub mnuUnfreeze_Click(sender As Object, e As EventArgs)
        RunScriptFromDataView(clsUnfreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
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

    Private Sub mnuCellCopyRange_Click(sender As Object, e As EventArgs) Handles mnuCellCopyRange.Click
        grdData.CurrentWorksheet.Copy()
    End Sub

    Private Sub ViewSheet_Click(sender As Object, e As EventArgs) Handles ViewSheet.Click
        Dim strScript As String = ""
        Dim strTemp As String
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame)
        clsGetDataFrame.SetAssignTo(grdCurrSheet.Name)
        strTemp = clsViewDataFrame.ToScript(strScript)
        RunScriptFromDataView(strScript & strTemp, strComment:="Right click menu: View R Data Frame", bSeparateThread:=False)

    End Sub

    'Private Sub mnuConvertDate_Click(sender As Object, e As EventArgs)
    '    dlgMakeDate.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
    '    dlgMakeDate.ShowDialog()
    'End Sub

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        clsConvertOrderedFactor.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertOrderedFactor.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertOrderedFactor.ToScript, strComment:="Right click menu: Convert to Ordered Factor")
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub AddCommentToolStripMenuItem_Click(sender As Object, e As EventArgs)
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

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        If grdData IsNot Nothing Then
            If grdData.Worksheets.Count > iIndex Then
                grdData.CurrentWorksheet = grdData.Worksheets(iIndex)
            Else
                ' Developer error?
            End If
        End If
    End Sub

    Private Sub RunScriptFromDataView(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        Cursor = Cursors.WaitCursor
        grdData.Enabled = False
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        grdData.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub columnContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles columnContextMenuStrip.Opening
        Dim iSelectedCols As Integer
        Dim strType As String
        Dim strColumns() As String

        iSelectedCols = grdData.CurrentWorksheet.SelectionRange.Cols
        strColumns = SelectedColumnsAsArray()

        If iSelectedCols = 1 Then
            strType = frmMain.clsRLink.GetColumnType(grdCurrSheet.Name, strColumns(0))
            mnuLevelsLabels.Enabled = (strType.Contains("factor"))
            mnuDeleteCol.Text = "Delete Column"
            mnuInsertColsBefore.Text = "Insert 1 Column Before"
            mnuInsertColsAfter.Text = "Insert 1 Column After"
        Else
            mnuLevelsLabels.Enabled = False
            mnuDeleteCol.Text = "Delete Columns"
            mnuInsertColsBefore.Text = "Insert " & iSelectedCols & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & iSelectedCols & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = Not String.Equals(strFilterName, strNoFilter)
    End Sub

    Private Sub HideSheet_Click(sender As Object, e As EventArgs) Handles HideSheet.Click
        clsHideDataFrame.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
        clsHideDataFrame.AddParameter("property", "is_hidden_label")
        clsHideDataFrame.AddParameter("new_val", "TRUE")
        RunScriptFromDataView(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
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

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuCellHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "134")
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub mnuRenameColumn_Click(sender As Object, e As EventArgs) Handles mnuRenameColumn.Click
        dlgName.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuDuplColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuReorderColumn_Click(sender As Object, e As EventArgs) Handles mnuReorderColumn.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuConvertToFact_Click(sender As Object, e As EventArgs) Handles mnuConvertToFact.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
    End Sub

    Private Sub mnuConvertToOrderedFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToOrderedFactor.Click
        clsConvertOrderedFactor.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertOrderedFactor.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertOrderedFactor.ToScript, strComment:="Right click menu: Convert to Ordered Factor")
    End Sub

    Private Sub mnuConvertToCharacter_Click(sender As Object, e As EventArgs) Handles mnuConvertToCharacter.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    Private Sub mnuConvertToLogic_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogic.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Logical")
    End Sub

    Private Sub mnuConvertToNumeric_Click(sender As Object, e As EventArgs) Handles mnuConvertToNumeric.Click
        clsConvertTo.AddParameter("col_names", SelectedColumns(), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "numeric" & Chr(34), iPosition:=2)
        RunScriptFromDataView(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Numeric")
    End Sub

    Private Sub mnuLebelsLevel_Click(sender As Object, e As EventArgs) Handles mnuLebelsLevel.Click
        Dim strType As String
        Dim strColumns() As String

        strColumns = SelectedColumnsAsArray()
        If strColumns.Count = 1 Then
            strType = frmMain.clsRLink.GetColumnType(grdCurrSheet.Name, strColumns(0))
            If strType.Contains("factor") Then
                dlgLabelsLevels.SetCurrentColumn(strColumns(0), grdCurrSheet.Name)
            End If
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuSorts_Click(sender As Object, e As EventArgs) Handles mnuSorts.Click
        dlgSort.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFilters_Click(sender As Object, e As EventArgs) Handles mnuFilters.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilters_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilters.Click
        RunScriptFromDataView(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
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
        mnuRemoveCurrentFilter.Enabled = Not String.Equals(strFilterName, strNoFilter)
    End Sub

    Private Sub cellContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles cellContextMenuStrip.Opening
        mnuRemoveCurrentFilters.Enabled = Not String.Equals(strFilterName, strNoFilter)
    End Sub
End Class
