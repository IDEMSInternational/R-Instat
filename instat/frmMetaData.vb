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

Public Class frmMetaData
    Public context As New frmEditor
    Private Sub frmMetaData_Load(sender As Object, e As EventArgs) Handles Me.Load
        frmMain.clsGrids.SetMetadata(grdMetaData)
        Me.SizeGripStyle = SizeGripStyle.Auto
        loadForm()
    End Sub

    ' TODO this needs tidying up
    Private Sub loadForm()
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, False)
        grdMetaData.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        grdMetaData.SheetTabNewButtonVisible = False
        grdMetaData.SheetTabNewButtonVisible = False
        grdMetaData.CurrentWorksheet.Resize(2, 2)
        grdMetaData.ColumnHeaderContextMenuStrip = context.grdData.ColumnHeaderContextMenuStrip
        grdMetaData.ContextMenuStrip = context.grdData.ContextMenuStrip
        grdMetaData.RowHeaderContextMenuStrip = context.grdData.RowHeaderContextMenuStrip
        autoTranslate(Me)
    End Sub

    'TODO interesting code here - should be discussed and possibly used elsewhere
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub
End Class