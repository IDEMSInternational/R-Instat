
' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgSort
    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("order")
        ucrReceiverSort.Selector = ucrAddRemove
        ucrReceiverSort.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub
    Private Sub ucrReceiverSort_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSort.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverSort.GetVariables())

    End Sub
    Private Sub grpOrder_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAscending.CheckedChanged, rdoDescending.CheckedChanged
        If rdoAscending.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("Descending", "FALSE")
        Else
            ucrBase.clsRsyntax.AddParameter("Descending", "TRUE")
        End If

    End Sub

    Private Sub grpMissingValues_ChekedChanged(sender As Object, e As EventArgs) Handles rdoFirst.CheckedChanged, rdoLast.CheckedChanged
        If rdoFirst.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        Else
            ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
        End If

    End Sub
End Class