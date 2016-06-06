﻿' Instat-R
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

Public Class frmEditor
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
    Public lstColumnNames As New List(Of KeyValuePair(Of String, String()))

    Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsGrids.SetData(grdData)
        grdData.Visible = False
        autoTranslate(Me)
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        SetRFunctions()
    End Sub
    ''' <summary>
    ''' Hides the form when it is closed and not exiting it.
    ''' </summary>
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

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
        clsInsertColumns.AddParameter("col_name", Chr(34) & "X" & Chr(34))
        clsInsertColumns.AddParameter("use_col_name_as_prefix", "TRUE")
        frmMain.clsRLink.RunScript(clsInsertColumns.ToScript(), strComment:="Right click menu: Insert Column(s) After")
    End Sub

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        clsDeleteColumns.AddParameter("cols", SelectedColumns())
        frmMain.clsRLink.RunScript(clsDeleteColumns.ToScript(), strComment:="Right click menu: Delete Column(s)")
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
        clsDeleteRows.AddParameter("row_names", SelectedRows())
        frmMain.clsRLink.RunScript(clsDeleteRows.ToScript(), strComment:="Right Click menu: Delete row(s)")
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

    Public Sub copyRange()
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
    Public Sub selectAllText()
        grdCurrSheet.SelectAll()
    End Sub

    Private Sub insertSheet_Click(sender As Object, e As EventArgs) Handles insertSheet.Click
        dlgFileNew.ShowDialog()
    End Sub

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteSheet.Click
        Dim strSctipt As String
        If grdData.Worksheets.Count > 0 Then
            strSctipt = frmMain.clsRLink.strInstatDataObject & "$delete_dataframe(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ")"
            frmMain.clsRLink.RunScript(strSctipt)
        End If
    End Sub

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        If grdData.Worksheets.Count < 1 Then
            grdData.Hide()
        End If
    End Sub

    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(SelectedColumnsAsArray()(0), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        grdCurrSheet = grdData.CurrentWorksheet
        frmMain.strCurrentDataFrame = grdCurrSheet.Name
        frmMain.tstatus.Text = grdCurrSheet.Name
        UpdateRFunctionDataFrameParameters()
    End Sub

    'TODO discuss validation for cell editing
    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        'temporary disabled editing
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        'Dim dblValue As Double
        'clsReplaceValue.AddParameter("col_name", Chr(34) & lstColumnNames(grdCurrSheet.SelectionRange.Col) & Chr(34))
        'clsReplaceValue.AddParameter("row", Chr(34) & grdCurrSheet.RowHeaders.Item(grdCurrSheet.SelectionRange.Row).Text & Chr(34))
        'If Double.TryParse(e.NewData, dblValue) OrElse e.NewData = "TRUE" OrElse e.NewData = "FALSE" OrElse e.NewData = "NA" Then
        '    clsReplaceValue.AddParameter("new_value", e.NewData)
        'Else
        '    clsReplaceValue.AddParameter("new_value", Chr(34) & e.NewData & Chr(34))
        'End If
        'Try
        '    frmMain.clsRLink.RunScript(clsReplaceValue.ToScript())
        'Catch
        '    'frmMain.clsRLink.RunInternalScript(frmMain.clsRLink.strInstatDataObject & "$set_data_frames_changed(" & Chr(34) & grdCurrSheet.Name & Chr(34) & ", TRUE)")
        '    'frmMain.clsGrids.UpdateGrids()
        '    e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
        'End Try
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameSheet.ShowDialog()
    End Sub

    Private Sub MoveOrCopySheet_Click(sender As Object, e As EventArgs) Handles CopySheet.Click
        dlgCopySheet.ShowDialog()
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
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderSheet.ShowDialog()
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
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilter.Click
        frmMain.clsRLink.RunScript(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub frmEditor_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewDataView.Checked = Me.Visible
    End Sub
End Class