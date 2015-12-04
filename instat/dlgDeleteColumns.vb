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
Public Class dlgDeleteColumns
    Private Sub dlgDeleteColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrReceiverDeleteColumns.Selector = ucrAddRemove
        ucrReceiverDeleteColumns.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("subset")
        ucrBase.clsRsyntax.iCallType = 1

    End Sub
    Private Sub ucrReceiverDeleteColumns_Enter(sender As Object, e As EventArgs) Handles ucrReceiverDeleteColumns.Enter
        ucrReceiverDeleteColumns.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverDeleteColumns_Leave(sender As Object, e As EventArgs) Handles ucrReceiverDeleteColumns.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverDeleteColumns.GetVariables())
    End Sub
    Private Sub txtSubset_Leave(sender As Object, e As EventArgs) Handles txtSubset.Leave
        ucrBase.clsRsyntax.AddParameter("subset", Chr(34) & txtSubset.Text & Chr(34))
    End Sub
    Private Sub txtSelect_Leave(sender As Object, e As EventArgs) Handles txtSelect.Leave
        ucrBase.clsRsyntax.AddParameter("select", Chr(34) & txtSelect.Text & Chr(34))
    End Sub
End Class