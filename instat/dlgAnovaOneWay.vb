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
Public Class dlgAnovaOneWay
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub

    Private Sub dlgAnovaOneWay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("summary(lm ")
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.iFunctionType = 1
        autoTranslate(Me)
    End Sub
    Private Sub ucrReceiverSingleA_Enter(sender As Object, e As EventArgs) Handles ucrReceiverSingleA.Enter
        ucrReceiverSingleA.Selector = ucrAddRemove
        ucrReceiverSingleA.SetMeAsReceiver()
    End Sub


    Private Sub ucrReceiverSingleB_Enter(sender As Object, e As EventArgs) Handles ucrReceiverSingleB.Enter
        ucrReceiverSingleB.Selector = ucrAddRemove
        ucrReceiverSingleB.SetMeAsReceiver()
    End Sub

    Private Sub ucrReceiverSingleA_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingleA.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverSingleA.txtReceiverSingle.Text & "")
    End Sub
    Private Sub ucrReceiverSingleB_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingleB.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverSingleB.txtReceiverSingle.Text & "")
    End Sub


End Class