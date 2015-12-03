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
Public Class dlgTwoWayAnova
    Private Sub dlgTwoWayAnova_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction(" aov(x~y*z ")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverCounts.Selector = ucrAddRemove
        ucrReceiverCounts.SetMeAsReceiver()
        autoTranslate(Me)
        ucrReceiverRowFactor.Selector = ucrAddRemove
        ucrReceiverColumnFactor.Selector = ucrAddRemove
    End Sub



    Private Sub ucrReceiverCounts_Leave(sender As Object, e As EventArgs) Handles ucrReceiverCounts.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverCounts.GetVariables())

    End Sub

    Private Sub ucrReceiverRowFactor_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRowFactor.Leave
        ucrBase.clsRsyntax.AddParameter("y", ucrReceiverRowFactor.GetVariables())

    End Sub

    Private Sub ucrReceiverColumnFactor_Leave(sender As Object, e As EventArgs) Handles ucrReceiverColumnFactor.Leave
        ucrBase.clsRsyntax.AddParameter("z", ucrReceiverColumnFactor.GetVariables())

    End Sub


End Class