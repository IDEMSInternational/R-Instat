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
Public Class dlgCorrelation
    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("cor")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverFirstColumn.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverFirstColumn.SetMeAsReceiver()
        ucrReceiverSecondColumn.Selector = ucrSelectorDataFrameVarAddRemove
        autoTranslate(Me)
        rdoTwoColumns.Checked = True
        FillFormula()

    End Sub

    Private Sub ucrReceiverFirstColumn_Leave(sender As Object, e As EventArgs) Handles ucrReceiverFirstColumn.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
    End Sub

    Private Sub ucrReceiverSecondColumn_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSecondColumn.Leave
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
    End Sub

    Private Sub rdoPearson_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPearson.CheckedChanged
        ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "pearson" & Chr(34))
    End Sub

    Private Sub rdoKendall_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKendall.CheckedChanged
        ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "kendall" & Chr(34))
    End Sub

    Private Sub rdoSpearman_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSpearman.CheckedChanged
        ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "spearman" & Chr(34))
    End Sub

    Private Sub rdoCompleteRowsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCompleteRowsOnly.CheckedChanged
        ucrBase.clsRsyntax.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
    End Sub

    Private Sub Pairwise_CheckedChanged(sender As Object, e As EventArgs) Handles Pairwise.CheckedChanged
        ucrBase.clsRsyntax.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
    End Sub
    Private Sub FillFormula()
        If rdoTwoColumns.Checked = True Then
            grpMissing.Visible = False

            cmdPlots.Visible = False

        Else


            grpMissing.Visible = True
            cmdPlots.Visible = True
        End If
    End Sub

    Private Sub rdoTwoColumns_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTwoColumns.CheckedChanged
        FillFormula()
    End Sub
End Class