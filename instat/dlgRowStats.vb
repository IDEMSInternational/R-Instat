
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
Public Class dlgRowStats
    Private Sub dlgRowStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("apply")
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiverRowStatistics.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverRowStatistics.SetMeAsReceiver()
        ucrBase.clsRsyntax.AddParameter("MARGIN", 1)
        ucrNewColumnNameSelector.SetDataFrameSelector(ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames)
        ucrNewColumnNameSelector.SetPrefix("Row_Summary")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelector.cboColumnName.Text, strTempDataframe:=ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelector.cboColumnName.Text)
    End Sub

    Private Sub ucrReceiverRowStatistics_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRowStatistics.Leave
        ucrBase.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverRowStatistics.GetVariables())

    End Sub



    Private Sub Statistic_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMean.CheckedChanged, rdoCount.CheckedChanged, rdoMaximum.CheckedChanged, rdoMinimum.CheckedChanged, rdoSum.CheckedChanged, rdoStandardDeviation.CheckedChanged
        If rdoMean.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "mean")
        ElseIf rdoCount.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "function(z) sum(!is.na(z))")
        ElseIf rdoMaximum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "max")
        ElseIf rdoMinimum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "min")
        ElseIf rdoSum.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "sum")
        ElseIf rdoStandardDeviation.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("FUN", "sd")
        Else
            ucrBase.clsRsyntax.RemoveParameter("FUN")
        End If

    End Sub

    Private Sub ucrNewColumnNameSelector_Leave(sender As Object, e As EventArgs) Handles ucrNewColumnNameSelector.Leave
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelector.cboColumnName.Text, strTempDataframe:=ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelector.cboColumnName.Text)
    End Sub
End Class