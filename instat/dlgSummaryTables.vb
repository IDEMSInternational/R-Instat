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

Public Class dlgSummaryTables
    Private bFirstload As Boolean = True
    Private Sub dlgSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        cboWeights.Visible = False
        ucrBase.clsRsyntax.SetFunction("summary")
        ucrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
        ucrReceiverFactor.Selector = ucrSelectorSummaryTables
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverVariate.Selector = ucrSelectorSummaryTables

        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkMeans.SetText("Means")
        ucrChkTotals.SetText("Totals")
        ucrChkTrtSCFactor.SetText("Treat Summary Column as Factor")
        ucrChkWeights.SetText("Weights")
    End Sub

    Private Sub chkWeights_CheckedChanged(sender As Object, e As EventArgs)
        If ucrChkWeights.Checked = True Then
            cboWeights.Visible = True
        Else
            cboWeights.Visible = False
        End If
    End Sub

    'Temporary test ok disabled.
    Private Sub TestOkEnabled()
        'If Not ucrReceiverFactor.IsEmpty AndAlso Not ucrReceiverVariate.IsEmpty Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If

        ucrBase.OKEnabled(False)
    End Sub

    Private Sub ucrReceiverFactor_Leave(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFactor.GetVariables())
    End Sub

    Private Sub ucrReceiverVariate_Leave(sender As Object, e As EventArgs)
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverVariate.GetVariables())
    End Sub

    Private Sub ucrReceiverFactor_ControlContentsChanged(ucrChangedControl As ucrCore)
        TestOkEnabled()
    End Sub
End Class