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
Public Class dlgPermuteRows
    Public clsSetSampleFunc As New RFunction
    Public clsSetSeedFunc As New RFunction
    Private Sub dlgPermuteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrReceiverPermuteRows.Selector = ucrSelectorDataFrameAddRemove
        ucrReceiverPermuteRows.SetMeAsReceiver()
        ucrSelectorNewColumnName.SetDataFrameSelector(ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames)
        ucrSelectorNewColumnName.SetPrefix("Perm")
        clsSetSeedFunc.SetRCommand("set.seed")

        ucrBase.clsRsyntax.SetFunction("replicate")
        ucrBase.clsRsyntax.AddParameter("expr", clsRFunctionParameter:=clsSetSampleFunc)
        clsSetSampleFunc.SetRCommand("sample")

        clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())
        clsSetSampleFunc.AddParameter("replace", "FALSE")
        clsSetSampleFunc.AddParameter("size", ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames.iDataFrameLength)
        nudSetSeed.Visible = False
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSelectorNewColumnName.cboColumnName.Text, strTempDataframe:=ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSelectorNewColumnName.cboColumnName.Text)
    End Sub
    Private Sub ucrReceiverPermuteRows_Leave(sender As Object, e As EventArgs) Handles ucrReceiverPermuteRows.Leave
        clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())

    End Sub
    Private Sub chkSetSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
        If chkSetSeed.Checked = True Then
            nudSetSeed.Visible = True
        Else
            nudSetSeed.Visible = False
        End If
    End Sub


    Private Sub nudSetSeed_Leave(sender As Object, e As EventArgs) Handles nudSetSeed.Leave
        clsSetSeedFunc.AddParameter("seed", nudSetSeed.Text)
    End Sub

    Private Sub nudNumberOfPerColumns_Leave(sender As Object, e As EventArgs) Handles nudNumberOfPerColumns.Leave
        ucrBase.clsRsyntax.AddParameter("n", nudNumberOfPerColumns.Text)
    End Sub
End Class