
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
Public Class dlgRecode
    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverSingle.Selector = ucrSelectorDataFrameAddRemove
        ucrReceiverSingle.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("cut")
        ucrBase.clsRsyntax.AddParameter("breaks")

        ucrSelectorNewColumnName.SetDataFrameSelector(ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames)
        ucrSelectorNewColumnName.SetPrefix("Recode")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSelectorNewColumnName.cboColumnName.Text, strTempDataframe:=ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSelectorNewColumnName.cboColumnName.Text)

    End Sub
    Private Sub ucrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSingle.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverSingle.GetVariables())

    End Sub

    Private Sub ucrMultipleNumeric_Leave(sender As Object, e As EventArgs) Handles ucrMultipleNumeric.Leave
        ucrBase.clsRsyntax.AddParameter("breaks")
    End Sub



    Private Sub chkAddLabels_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddLabels.CheckedChanged
        If chkAddLabels.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("labels")
        End If
    End Sub

    Private Sub grpClosedOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLeft.CheckedChanged, rdoRight.CheckedChanged
        If rdoLeft.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("right", "FALSE")
        Else
            ucrBase.clsRsyntax.AddParameter("right", "TRUE")

        End If

    End Sub


End Class