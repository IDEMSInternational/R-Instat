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

Public Class dlgProbabilityPlot
    Private Sub dlgProbabilityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverPlotVariable.Selector = ucrAddRemove
        ucrReceiverPlotVariable.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("qqnorm")
        ucrBase.clsRsyntax.iCallType = 0
        rdoNormal.Checked = True
        txtTitle.Visible = False
        autoTranslate(Me)

    End Sub

    Private Sub rdoNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormal.CheckedChanged
        If rdoNormal.Checked = True Then
            txtTitle.Text = "Normal Probability Plot of " & ucrReceiverPlotVariable.txtReceiverSingle.Text & ""
        End If

    End Sub

    Private Sub rdoGamma_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGamma.CheckedChanged
        If rdoGamma.Checked = True Then
            txtTitle.Text = "Gamma Probability Plot"
        End If
    End Sub

    Private Sub rdoExtrmeValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExtrmeValue.CheckedChanged
        If rdoExtrmeValue.Checked = True Then
            txtTitle.Text = "Extreme Value Probability Plot"
        End If
    End Sub

    Private Sub rdoEmperical_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEmperical.CheckedChanged
        If rdoEmperical.Checked = True Then
            txtTitle.Text = "Emperical Probability Plot"
        End If
    End Sub

    Private Sub rdoExponential_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExponential.CheckedChanged
        If rdoExponential.Checked = True Then
            txtTitle.Text = "Exponential Probability Plot"
        End If
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub UcrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverPlotVariable.Leave
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverPlotVariable.GetVariables())
    End Sub
End Class


