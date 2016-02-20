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
Public Class dlgDotPlot
    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrYVariableReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrSecondfactorReceiver.Selector = ucrDotPlotSelector
        ucrYVariableReceiver.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)
    End Sub

    Private Sub ucrFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrSecondfactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrSecondfactorReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("fill", ucrSecondfactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrYVariableReceiver_Leave(sender As Object, e As EventArgs) Handles ucrYVariableReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("y", ucrYVariableReceiver.GetVariableNames(False))
    End Sub
End Class