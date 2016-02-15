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

Imports instat.Translations
Imports unvell.ReoGrid.Events

Public Class frmEditor
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

    Private Sub insertCol_Click(sender As Object, e As EventArgs) Handles insertColToolStripMenuItem.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$insert_column_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",col_data = " & "c(), start_pos = " & grdData.CurrentWorksheet.SelectionRange.Col + 1 & ",number_cols =" & grdData.CurrentWorksheet.SelectionRange.Cols & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    Private Sub deleteColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles deleteColumnToolStripMenuItem.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data_from_start_position(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ", start_pos = " & grdData.CurrentWorksheet.SelectionRange.Col + 1 & ",col_numbers =" & grdData.CurrentWorksheet.SelectionRange.Cols & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    Private Sub insertRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles insertRowToolStripMenuItem.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",row_data = " & "c(), start_pos = " & grdData.CurrentWorksheet.SelectionRange.Row + 1 & ",number_rows =" & grdData.CurrentWorksheet.SelectionRange.Rows & ")"
        frmMain.clsRLink.RunScript(strSctipt)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ", start_pos = " & grdData.CurrentWorksheet.SelectionRange.Col + 1 & ",num_rows =" & grdData.CurrentWorksheet.SelectionRange.Cols & ")"
        frmMain.clsRLink.RunScript(strSctipt)
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
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        grdCurrSheet = grdData.CurrentWorksheet
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strSctipt As String
        strSctipt = frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data(data_name =" & Chr(34) & grdData.CurrentWorksheet.Name & Chr(34) & ",col_name = " & Chr(34) & grdData.CurrentWorksheet.GetColumnHeader(grdData.CurrentWorksheet.SelectionRange.Col).Text & Chr(34) & ",index=" & grdData.CurrentWorksheet.SelectionRange.Row + 1 & ",new_value=" & Chr(34) & e.NewData & Chr(34) & ")"
        frmMain.clsRLink.clsEngine.Evaluate(strSctipt)
    End Sub
End Class