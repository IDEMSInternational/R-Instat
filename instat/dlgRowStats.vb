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
Public Class dlgRowStats
    Private Sub dlgRowStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverMultiple.Selector = ucrSelectorAddRemove
        ucrReceiverMultiple.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("rowStats")
        ucrBase.clsRsyntax.iCallType = 1
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverMultiple_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.LeftList
        ucrBase.clsRsyntax.AddParameter("x", "data$ " & ucrReceiverMultiple.lstSelectedVariables.SelectedItem & "")

    End Sub

    Private Sub ucrReceiverMultiple_Load(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.Load

    End Sub

    Private Sub chkCount_CheckedChanged(sender As Object, e As EventArgs) Handles chkCount.CheckedChanged
        If chkCount.Checked = True Then

        End If
    End Sub
End Class