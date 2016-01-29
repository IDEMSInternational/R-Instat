
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
Public Class dlgRowStats
    Private Sub dlgRowStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("apply")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverRowStatistics.Selector = ucrSelectorDataFrame
        ucrReceiverRowStatistics.SetMeAsReceiver()
        ucrBase.clsRsyntax.AddParameter("MARGIN", 1)
    End Sub

    Private Sub ucrReceiverRowStatistics_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRowStatistics.Leave
        ucrBase.clsRsyntax.AddParameter("X", ucrReceiverRowStatistics.GetVariableNames())

    End Sub


    Private Sub Statistic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMean.CheckedChanged, rdoCount.CheckedChanged, rdoMaximum.CheckedChanged, rdoMinimum.CheckedChanged, rdoSum.CheckedChanged, rdoStandardDeviation.CheckedChanged
        ' ucrNewColumnName.setPrefix= "RowMean", "RowCount", "RowMaximum", "RowMinimum, "RowSum", "RowStandardDeviation"
        ucrBase.clsRsyntax.AddParameter("FUN", "mean")
        ucrBase.clsRsyntax.AddParameter("FUN", "count")
        ucrBase.clsRsyntax.AddParameter("FUN", "maximum")
        ucrBase.clsRsyntax.AddParameter("FUN", "minimum")
        ucrBase.clsRsyntax.AddParameter("FUN", "sum")
        ucrBase.clsRsyntax.AddParameter("FUN", "sd")

    End Sub
End Class