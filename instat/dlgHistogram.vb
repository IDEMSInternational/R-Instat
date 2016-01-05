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
Public Class dlgHistogram
    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("hist")
        ucrBase.clsRsyntax.iCallType = 0
        ucrXReceiver.Selector = ucrAddRemove
        ucrXReceiver.SetMeAsReceiver()
        ucrBase.OKEnabled(False)
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverSingle_Enter(sender As Object, e As EventArgs) Handles ucrXReceiver.Enter
        ucrXReceiver.SetMeAsReceiver()
    End Sub

    Private Sub ucrXReceiver_ValueChanged(sender As Object, e As EventArgs) Handles ucrXReceiver.ValueChanged
        If Not (ucrXReceiver.txtReceiverSingle.Text = "") Then
            ucrBase.clsRsyntax.AddParameter("x", ucrXReceiver.GetVariables())
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub txtHistogramTitle_TextChanged(sender As Object, e As EventArgs) Handles txtHistogramTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtHistogramTitle.Text & Chr(34))
    End Sub
End Class