' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgOneSample
    Public bFirstLoad As Boolean = True
    Private Sub dlgOneSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 1
        'ucrBase.iHelpTopicID = 371
        ucrReceiverDataColumn.Selector = ucBaseOneSample
        ucrBase.clsRsyntax.SetFunction("t.test")
        cboModels.Text = "Normal"
        cboParameters.Text = "Mean(t-interval)"
        nudValue.Minimum = 0
        nudValue.Maximum = 1
        nudValue.Increment = 0.05
        nudValue.DecimalPlaces = 2
    End Sub

    Private Sub SetDefaults()
        ucBaseOneSample.Reset()
        ucrReceiverDataColumn.SetMeAsReceiver()
        nudValue.Value = 0.05
        nudValue.Visible = False
        lblValue.Visible = False
        chkSignificanceTest.Checked = False
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverDataColumn.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub chkSignificanceTest_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignificanceTest.CheckedChanged
        If chkSignificanceTest.Checked = True Then
            nudValue.Visible = True
            lblValue.Visible = True
        Else
            nudValue.Visible = False
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

    Private Sub ucrReceiverDataColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDataColumn.SelectionChanged
        If Not (ucrReceiverDataColumn.txtReceiverSingle.Text = "") Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverDataColumn.GetVariables())

            ucrBase.clsRsyntax.AddParameter("n", frmEditor.grdData.CurrentWorksheet.RowCount)
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkSignificanceTest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkSignificanceTest.KeyPress
        If e.KeyChar = vbCr Then
            chkSignificanceTest.Checked = True
            nudValue.Visible = True
            lblValue.Visible = True
        End If
    End Sub

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles nudValue.TextChanged
        ucrBase.clsRsyntax.AddParameter("mu", nudValue.Text)
    End Sub

End Class