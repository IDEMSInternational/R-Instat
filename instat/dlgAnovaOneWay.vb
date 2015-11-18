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
        ucrBase.clsRsyntax.SetFunction(" aov ")
        ucrBase.clsRsyntax.iCallType = 2
        ucrSingleReceiver1.Selector = ucrAddRemove
        ucrSingleReceiver1.SetMeAsReceiver()
        ucrSingleReceiver2.Selector = ucrAddRemove
        ucrSingleReceiver2.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub
    Private Sub ucrSingleReceiver1_Enter(sender As Object, e As EventArgs) Handles ucrSingleReceiver1.Enter
        ucrSingleReceiver1.Selector = ucrAddRemove
        ucrSingleReceiver1.SetMeAsReceiver()
    End Sub


    Private Sub ucrSingleReceiver2_Enter(sender As Object, e As EventArgs) Handles ucrSingleReceiver2.Enter
        ucrSingleReceiver2.Selector = ucrAddRemove
        ucrSingleReceiver2.SetMeAsReceiver()
    End Sub

    Private Sub ucrSingleReceiver1_Leave(sender As Object, e As EventArgs) Handles ucrSingleReceiver1.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrSingleReceiver1.txtReceiverSingle.Text & "")
    End Sub
    Private Sub ucrSingleReceiver2_Leave(sender As Object, e As EventArgs) Handles ucrSingleReceiver2.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrSingleReceiver2.txtReceiverSingle.Text & "")
    End Sub


End Class