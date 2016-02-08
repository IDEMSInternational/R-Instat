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
    Private Sub OneSampleDefaultSettings()
        ucrReceiverDataColumn.Selector = ucrAddRemove
        ucrReceiverDataColumn.SetMeAsReceiver()
        txtValue.Visible = False
        lblValue.Visible = False
        ucrBase.clsRsyntax.SetFunction("t.test")
        cboModels.Text = "Normal"
        cboParameters.Text = "Mean(t-interval)"
        ucrBase.OKEnabled(False)
        autoTranslate(Me)
    End Sub

    Private Sub dlgOneSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OneSampleDefaultSettings()
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

    Private Sub cboModels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModels.SelectedIndexChanged
        If cboModels.SelectedItem = cboModels.Items(1).ToString() Then
            ucrBase.clsRsyntax.SetFunction("prop.test")
        Else
            ucrBase.clsRsyntax.SetFunction("t.test")
        End If
    End Sub

    Private Sub ucrReceiverDataColumn_Leave(sender As Object, e As EventArgs) Handles ucrReceiverDataColumn.Leave
        If Not (ucrReceiverDataColumn.txtReceiverSingle.Text = "") Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverDataColumn.GetVariables())

            ucrBase.clsRsyntax.AddParameter("n", frmEditor.grdData.CurrentWorksheet.RowCount)
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        OneSampleDefaultSettings()
    End Sub
    Private Sub chkSignificanceTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkSignificanceTest.KeyPress
        If e.KeyChar = vbCr Then
            chkSignificanceTest.Checked = True
            txtValue.Visible = True
            lblValue.Visible = True
        End If
    End Sub

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.TextChanged

    End Sub

    Private Sub txtValue_Leave(sender As Object, e As EventArgs) Handles txtValue.Leave
        ucrBase.clsRsyntax.AddParameter("", txtValue.Text)
    End Sub
End Class