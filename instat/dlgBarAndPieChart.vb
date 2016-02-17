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

Public Class dlgBarAndPieChart
    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrFactorReceiver.Selector = ucrBarChartSelector
        ucrSecondReceiver.Selector = ucrBarChartSelector
        ucrFactorReceiver.SetMeAsReceiver()
        rdoBarChart.Checked = True
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub rdoBarChart_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged

    End Sub
End Class