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
Public Class dlgChiSquareTest
    Private Sub ChiSquareTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverMultiple.Selector = ucrAddRemove
        ucrReceiverMultiple.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetFunction("chisq.test")
        autoTranslate(Me)
        cboLayoutOfData.Text = "Multiple Data Columns"

    End Sub


    Private Sub ucrReceiverMultiple_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.LeftList
        ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverMultiple.lstSelectedVariables.Text & "")
    End Sub
    Private Sub UcrReceiverMultiple1_Load(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.Load

    End Sub

    Private Sub cboLayoutOfData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLayoutOfData.SelectedIndexChanged

    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load

    End Sub
End Class