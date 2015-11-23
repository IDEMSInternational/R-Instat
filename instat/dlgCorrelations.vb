'Instat-R
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

Public Class dlgCorrelations
    Private Sub ucrAddRemove_Load(sender As Object, e As EventArgs) Handles ucrAddRemove.Load
        ucrBase.clsRsyntax.SetFunction("cor")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverMultiple.Selector = ucrAddRemove
        ucrReceiverMultiple.SetMeAsReceiver()
        autoTranslate(Me)
    End Sub

    Private Sub ucrReceiverMultiple_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.LeftList
        If ucrReceiverMultiple.lstSelectedVariables.Items.Count = 2 Then
            ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverMultiple.lstSelectedVariables.Items.Item(0) & "")
            ucrBase.clsRsyntax.AddParameter("y", "data$" & ucrReceiverMultiple.lstSelectedVariables.Items.Item(1) & "")
        End If

    End Sub
End Class