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
Public Class dlgUnstack


    Private Sub dlgUnstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("unstack")
        ucrBase.clsRsyntax.iCallType = 1
        UcrReceiverUnstack.Selector = ucrAddRemove
        UcrReceiverUnstack.SetMeAsReceiver()

        autoTranslate(Me)

    End Sub
    Private Sub ucrReceiverUnstack_Enter(sender As Object, e As EventArgs) Handles UcrReceiverUnstack.Enter
        UcrReceiverUnstack.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverUnstack_Leave(sender As Object, e As EventArgs) Handles UcrReceiverUnstack.Leave
        ucrBase.clsRsyntax.AddParameter("x", UcrReceiverUnstack.GetVariables())
    End Sub




End Class