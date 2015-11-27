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

Public Class dlgOneWayANOVA
    Private Sub dlgOneWayANOVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("aov")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverYVariate.Selector = ucrAddRemove
        ucrReceiverYVariate.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverFactor_Enter(sender As Object, e As EventArgs) Handles ucrReceiverFactor.Enter
        ucrReceiverFactor.Selector = ucrAddRemove
        ucrReceiverFactor.SetMeAsReceiver()
    End Sub

    Private Sub ucrReceiverYVariate_Leave(sender As Object, e As EventArgs) Handles ucrReceiverYVariate.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverYVariate.GetVariables())
    End Sub

    Private Sub ucrReceiverFactor_Leave(sender As Object, e As EventArgs) Handles ucrReceiverFactor.Leave
        ucrBase.clsRsyntax.AddParameter("y", ucrReceiverFactor.GetVariables())
    End Sub
End Class