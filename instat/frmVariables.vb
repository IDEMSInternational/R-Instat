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
Public Class frmVariables
    Public context As New frmEditor
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        frmMain.clsGrids.SetVariablesMetadata(grdVariables)
    End Sub

    Private Sub loadForm()
        grdVariables.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        'gridVariables.SheetTabNewButtonVisible = False
        'gridVariables.SheetTabControlNewButtonVisible = False
        'grdVariables.CurrentWorksheet.Resize(5, 5)
        grdVariables.ColumnHeaderContextMenuStrip = context.grdData.ColumnHeaderContextMenuStrip
        grdVariables.RowHeaderContextMenuStrip = context.grdData.RowHeaderContextMenuStrip
        grdVariables.ContextMenuStrip = context.grdData.ContextMenuStrip
        autoTranslate(Me)
    End Sub
End Class