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
Public Class dlgStemAndLeaf
    Private Sub dlgStemAndLeaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("stem")
        ucrBase.clsRsyntax.iCallType = 2
        UcrReceiverSingle1.Selector = UcrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub
    Private Sub ucrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
    End Sub

End Class