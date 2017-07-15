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

Public Class dlgFreqTables
    Private Sub dlgFreqTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboWeights.Visible = False
        cboPercentFactor.Visible = False
        ucrBase.clsRsyntax.SetFunction("frequency")
        ucrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
        ucrReceiverMultiple.Selector = ucrAddRemove
        ucrReceiverMultiple.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 144
    End Sub

    Private Sub chkWeights_CheckedChanged(sender As Object, e As EventArgs) Handles chkWeights.CheckedChanged
        If chkWeights.Checked = True Then
            cboWeights.Visible = True
        Else
            cboWeights.Visible = False
        End If
    End Sub

    Private Sub rdoPercentFactor_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPercentFactor.CheckedChanged
        If rdoPercentFactor.Checked = True Then
            cboPercentFactor.Visible = True
        Else
            cboPercentFactor.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverMultiple_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultiple.Leave
        'TODO fix this
        'ucrBase.clsRsyntax.AddParameter("x", "data$" & ucrReceiverMultiple.lstSelectedVariables.SelectedItem & "")
    End Sub
End Class