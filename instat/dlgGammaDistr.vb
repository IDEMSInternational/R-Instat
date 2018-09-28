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

Public Class dlgGammaDistr
    Private Sub dlgGammaDistr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrBase.clsRsyntax.SetFunction("gamma")
        ucrBase.clsRsyntax.iCallType = 1
        autoTranslate(Me)
        ucrReceiverColumn.Selector = ucrAddRemove
        ucrReceiverColumn.SetMeAsReceiver()
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
        Else
            cboMaximumLikelihood.Visible = False
        End If
    End Sub

    Private Sub chkMethodofMoments_CheckedChanged(sender As Object, e As EventArgs) Handles chkMethodOfMoments.CheckedChanged
        If chkMethodOfMoments.Checked = True Then
            cboMethodOfMoments.Visible = True
        Else
            cboMethodOfMoments.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverColumn_leave(sender As Object, e As EventArgs) Handles ucrReceiverColumn.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverColumn.GetVariables())
    End Sub

    Private Sub ucrReceiverColumn_Load(sender As Object, e As EventArgs)

    End Sub

    'Private Sub chkProbabilityPlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkProbabilityPlot.CheckedChanged
    '    If chkProbabilityPlot.Checked = True Then
    '        ucrBase.clsRsyntax.SetFunction("plot(gamma)")
    '        ucrBase.clsRsyntax.iCallType = 0
    '    Else
    '        ucrBase.clsRsyntax.SetFunction("gamma")
    '        ucrBase.clsRsyntax.iCallType = 1
    '    End If
    'End Sub
End Class