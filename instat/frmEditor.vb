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

Public Class frmEditor
    'Public clearFilter As unvell.ReoGrid.Data.AutoColumnFilter
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet

    Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsGrids.SetData(grdData)
        grdData.Visible = False
        autoTranslate(Me)
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
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

    Private Sub insertCol_Click(sender As Object, e As EventArgs) Handles mnuInsertCol.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$insert_column_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",col_data = " & "c(), start_pos = " & grdData.CurrentWorksheet.SelectionRange.Col + 1 & ",number_cols =" & grdData.CurrentWorksheet.SelectionRange.Cols & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data_from_start_position(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ", start_pos = " & grdData.CurrentWorksheet.SelectionRange.Col + 1 & ",col_numbers =" & grdData.CurrentWorksheet.SelectionRange.Cols & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    'Private Sub resetToDefaultWidthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles resetToDefaultWidthToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.SetColumnsWidthAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols, unvell.ReoGrid.Worksheet.InitDefaultColumnWidth))
    'End Sub

    'Private Sub hideColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles hideColumnsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.HideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    'End Sub

    'Private Sub unhideColumnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles unhideColumnsToolStripMenuItem.Click
    '    grdData.DoAction(New unvell.ReoGrid.Actions.UnhideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
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

    Private Sub mnuinsertRow_Click(sender As Object, e As EventArgs) Handles mnuInsertRow.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",row_data = " & "c(), start_pos = " & grdData.CurrentWorksheet.SelectionRange.Row + 1 & ",number_rows =" & grdData.CurrentWorksheet.SelectionRange.Rows & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    Private Sub mnuDeleteRows_Click(sender As Object, e As EventArgs) Handles mnuDeleteRows.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ", start_pos = " & grdData.CurrentWorksheet.SelectionRange.Row + 1 & ",num_rows =" & grdData.CurrentWorksheet.SelectionRange.Rows & ")"
        frmMain.clsRLink.RunScript(strSctipt)
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
    '        MessageBox.Show("Cannot cut a range that is a part of another merged cell.")
    '    Catch
    '        MessageBox.Show("We can't to do that for selected range.")
    '    End Try
    'End Sub

    'Private Sub copyRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles copyRangeToolStripMenuItem.Click
    '    Try
    '        grdData.CurrentWorksheet.Copy()
    '    Catch generatedExceptionName As unvell.ReoGrid.RangeIntersectionException
    '        MessageBox.Show("Cannot cut a range that is a part of another merged cell.")
    '    Catch
    '        MessageBox.Show("We can't to do that for selected range.")
    '    End Try
    'End Sub

    'Private Sub pasteRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles pasteRangeToolStripMenuItem.Click
    '    Try
    '        grdData.CurrentWorksheet.Paste()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


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
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        grdCurrSheet = grdData.CurrentWorksheet
        frmMain.strCurrentDataFrame = grdCurrSheet.Name

        frmMain.tstatus.Text = grdCurrSheet.Name
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",col_name = " & Chr(34) & grdData.CurrentWorksheet.GetColumnHeader(grdData.CurrentWorksheet.SelectionRange.Col).Text & Chr(34) & ",index=" & grdData.CurrentWorksheet.SelectionRange.Row + 1 & ",new_value=" & Chr(34) & e.NewData & Chr(34) & ")"
        frmMain.clsRLink.clsEngine.Evaluate(strSctipt)
    End Sub
End Class