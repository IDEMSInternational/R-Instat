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

Public Class dlgOneSample
    Private Sub cboModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModels.SelectedIndexChanged
    End Sub

    Private Sub dlgOneSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtValue.Visible = False
        lblValue.Visible = False

        ucrBase.clsRsyntax.SetFunction("t.test")
        ucrBase.clsRsyntax.SetFunction("prop.test")
        ucrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
        ucrReceiverSingle.Selector = ucrAddRemove
        ucrReceiverSingle.SetMeAsReceiver()

    End Sub

    Private Sub cboParameters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboParameters.SelectedIndexChanged

    End Sub

    Private Sub chkSignificanceTest_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignificanceTest.CheckedChanged
        If chkSignificanceTest.Checked = True Then
            txtValue.Visible = True
            lblValue.Visible = True
        Else
            txtValue.Visible = False
            lblValue.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingle.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverSingle.GetVariables())
    End Sub
End Class