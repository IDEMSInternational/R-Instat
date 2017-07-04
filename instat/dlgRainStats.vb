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

Imports instat.Translations
Public Class dlgRainStats

    Private Sub dlgRainStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$rain_stats")
        ucrBase.clsRsyntax.iCallType = 1

    End Sub

    Private Sub txtColunnName1_Leave(sender As Object, e As EventArgs) Handles txtColunnName1.Leave
        ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & txtColunnName1.Text & Chr(34))

    End Sub

    Private Sub txtColunnName2_Leave(sender As Object, e As EventArgs) Handles txtColunnName2.Leave
        ucrBase.clsRsyntax.AddParameter("col_name2", Chr(34) & txtColunnName2.Text & Chr(34))

    End Sub

    Private Sub txtColunnName3_Leave(sender As Object, e As EventArgs) Handles txtColunnName3.Leave
        ucrBase.clsRsyntax.AddParameter("col_name3", Chr(34) & txtColunnName3.Text & Chr(34))

    End Sub

    Private Sub nudThreshold1_Leave(sender As Object, e As EventArgs) Handles nudThreshold1.Leave
        ucrBase.clsRsyntax.AddParameter("thresholds", nudThreshold1.Value.ToString()) 'Again here thresholds is a vector which takes thresholds=c(thresh1,thresh2)
    End Sub

    Private Sub nudThreshold2_Leave(sender As Object, e As EventArgs) Handles nudThreshold2.Leave
        ucrBase.clsRsyntax.AddParameter("thresholds", nudThreshold1.Value.ToString())
    End Sub

    Private Sub nudThresholdRainAmounts_Leave(sender As Object, e As EventArgs) Handles nudThresholdRainAmounts.Leave
        ucrBase.clsRsyntax.AddParameter("thresh_amount", nudThresholdRainAmounts.Value.ToString())
    End Sub
End Class