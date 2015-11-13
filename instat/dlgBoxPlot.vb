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
Public Class dlgBoxPlot
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ucrBase.clsRsyntax.SetFunction("boxplot")
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiverSingle.Selector = UcrAddRemove
        ucrReceiverSingle.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverSingle_Enter(sender As Object, e As EventArgs) Handles ucrReceiverSingle.Enter
        ucrReceiverSingle.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingle.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverSingle.txtReceiverSingle.Text & "")
    End Sub

    Private Sub txtHistogramTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub txtYLabel_TextChanged(sender As Object, e As EventArgs) Handles txtYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtTitle.Text & Chr(34))
    End Sub
    Private Sub txtXLabel_TextChanged(sender As Object, e As EventArgs) Handles txtXLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtTitle.Text & Chr(34))
    End Sub
End Class