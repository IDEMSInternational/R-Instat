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
Public Class dlgSummaryChart
    Private Sub dlgSummaryChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrSummaryVariableReceiver.Selector = ucrSummaryChartSelector
        ucrSummaryVariableReceiver.SetMeAsReceiver()
        cboClusterBy.Visible = False
        autoTranslate(Me)
    End Sub

    Private Sub chkClusterBy_CheckedChanged(sender As Object, e As EventArgs) Handles chkClusterBy.CheckedChanged
        If chkClusterBy.Checked = True Then
            cboClusterBy.Visible = True
        Else
            cboClusterBy.Visible = False
        End If
    End Sub
End Class