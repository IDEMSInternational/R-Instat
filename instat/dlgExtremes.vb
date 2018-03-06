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

Public Class dlgExtremes
    Private Sub dlgExtremes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkRestrictValues.Checked = False
        lblBetween.Visible = False
        txtBetween.Visible = False
        lblAnd.Visible = False
        txtAnd.Visible = False
        chkMaximumLikelihood.Checked = False
        chkMethodOfMoments.Checked = False
        cboMaximumLikelihood.Visible = True

        cboMethodOfMoments.Visible = False
        chkProbabilityPlot.Checked = False

        ucrBase.OKEnabled(False) ' temporarily for beta

        ucrBase.clsRsyntax.SetFunction("gev.fit")
        ucrBase.clsRsyntax.iCallType = 1
        autoTranslate(Me)
        ucrReceiverDataToFit.Selector = ucrAddRemove
        ucrReceiverDataToFit.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 488
    End Sub

    Private Sub SetDefaults()
    End Sub

    Private Sub chkRestrictValues_CheckedChanged(sender As Object, e As EventArgs) Handles chkRestrictValues.CheckedChanged
        If chkRestrictValues.Checked = True Then
            lblBetween.Visible = True
            txtBetween.Visible = True
            lblAnd.Visible = True
            txtAnd.Visible = True
        Else
            lblBetween.Visible = False
            txtBetween.Visible = False
            lblAnd.Visible = False
            txtAnd.Visible = False
        End If
    End Sub

    Private Sub chkMaximumLikelihood_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaximumLikelihood.CheckedChanged
        If chkMaximumLikelihood.Checked = True Then
            cboMaximumLikelihood.Visible = True
        End If
    End Sub

    Private Sub chkMethodofMoments_CheckedChanged(sender As Object, e As EventArgs) Handles chkMethodOfMoments.CheckedChanged
        If chkMethodOfMoments.Checked = True Then
            cboMethodOfMoments.Visible = True
        Else
            cboMethodOfMoments.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverDataToFit_Leave(sender As Object, e As EventArgs) Handles ucrReceiverDataToFit.Leave
        ucrBase.clsRsyntax.AddParameter("xdat", clsRFunctionParameter:=ucrReceiverDataToFit.GetVariables())
    End Sub
End Class