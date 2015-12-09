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
Public Class dlgLogRank
    Private Sub dlgLogRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        grpCensoringColumns.Visible = False
        grpDisplayOptions.Visible = False
        grpSurvivorFunction.Visible = False
    End Sub

    Private Sub chkCensoringColumns_CheckedChanged(sender As Object, e As EventArgs) Handles chkCensoringColumns.CheckedChanged
        If chkCensoringColumns.Checked = True Then
            grpCensoringColumns.Visible = True
        Else
            grpCensoringColumns.Visible = False
        End If
    End Sub

    Private Sub chkExploratoryPlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkExploratoryPlot.CheckedChanged
        If chkExploratoryPlot.Checked = True Then
            grpSurvivorFunction.Visible = True
            rdoKaplanMeierPlot.Checked = True
        Else
            grpSurvivorFunction.Visible = False
        End If
    End Sub

    Private Sub chkDisplayOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayOptions.CheckedChanged
        If chkDisplayOptions.Checked = True Then
            grpDisplayOptions.Visible = True
        Else
            grpDisplayOptions.Visible = False
        End If
    End Sub
End Class