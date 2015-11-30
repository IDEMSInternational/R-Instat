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
Public Class dlgNonParametricTwoWayANOVA
    Private Sub dlgNonParametricOneWayANOVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverCounts.Selector = ucrAddRemove
        ucrReceiverCounts.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverRowF_Enter(sender As Object, e As EventArgs) Handles ucrReceiverRowF.Enter
        ucrReceiverRowF.Selector = ucrAddRemove
        ucrReceiverRowF.SetMeAsReceiver()

    End Sub

    Private Sub ucrReceiverColF_Enter(sender As Object, e As EventArgs) Handles ucrReceiverColF.Enter
        ucrReceiverColF.Selector = ucrAddRemove
        ucrReceiverColF.SetMeAsReceiver()

    End Sub

    Private Sub ucrReceiverCounts_Leave(sender As Object, e As EventArgs) Handles ucrReceiverCounts.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverCounts.GetVariables())

    End Sub

    Private Sub ucrReceiverRowF_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRowF.Leave
        ucrBase.clsRsyntax.AddParameter("y", ucrReceiverRowF.GetVariables())

    End Sub

    Private Sub ucrReceiverColF_Leave(sender As Object, e As EventArgs) Handles ucrReceiverColF.Leave
        ucrBase.clsRsyntax.AddParameter("z", ucrReceiverColF.GetVariables())
    End Sub
End Class