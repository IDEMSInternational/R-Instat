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
        'Set properties needed on load
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverFirstColumn.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverSecondColumn.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverMultipleColumns.Selector = ucrSelectorDataFrameVarAddRemove
        autoTranslate(Me)

        'this default is independent of TwoColumn/MultipleColumn option so can be set here
        rdoPearson.Checked = True
        ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "pearson" & Chr(34))

        'default is the TwoColumn option
        rdoTwoColumns.Checked = True
        SetTwoColumnAsFunction()
    End Sub

    Private Sub ucrReceiverFirstColumn_Leave(sender As Object, e As EventArgs) Handles ucrReceiverFirstColumn.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
    End Sub

    Private Sub ucrReceiverSecondColumn_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSecondColumn.Leave
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
    End Sub

    Private Sub ucrReceiverMultipleColumns_Leave(sender As Object, e As EventArgs) Handles ucrReceiverMultipleColumns.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
    End Sub

    'put all rdo button checked changed in one sub to make it shorter
    Private Sub rdoForMethodsCheckedChanged(sender As Object, e As EventArgs) Handles rdoPearson.CheckedChanged, rdoKendall.CheckedChanged, rdoSpearman.CheckedChanged
        If rdoPearson.Checked Then
            ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        ElseIf rdoKendall.Checked Then
            ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "kendall" & Chr(34))
        ElseIf rdoSpearman.Checked Then
            ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "spearman" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("method")
            'the else case should never happen but is there just in case
        End If
    End Sub

    Private Sub rdoCompleteRowsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCompleteRowsOnly.CheckedChanged, rdoPairwise.CheckedChanged
        SetUseParameter()
    End Sub

    Private Sub SetUseParameter()
        If rdoCompleteRowsOnly.Checked Then
            ucrBase.clsRsyntax.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ElseIf rdoPairwise.Checked Then
            ucrBase.clsRsyntax.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("use")
        End If
    End Sub

    Private Sub SetTwoColumnAsFunction()
        'set the receiver
        ucrReceiverFirstColumn.SetMeAsReceiver()
        'Set function name
        ucrBase.clsRsyntax.SetFunction("cor.test")
        'Set what should be visible/invisible
        grpMissing.Visible = False
        cmdPlots.Visible = False
        lblConfInterval.Visible = True
        txtConfidenceInterval.Visible = True
        ucrReceiverFirstColumn.Visible = True
        ucrReceiverSecondColumn.Visible = True
        ucrReceiverMultipleColumns.Visible = False
        'remove parameters from MultipleColumn case
        ucrBase.clsRsyntax.RemoveParameter("use")
        'add in parameters that may have been removed from MultipleColumn case
        If txtConfidenceInterval.Text = "" Then
            txtConfidenceInterval.Text = 0.95
        End If
        ucrBase.clsRsyntax.AddParameter("conf.level", txtConfidenceInterval.Text)
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
        ucrBase.clsRsyntax.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
        ucrBase.clsRsyntax.AddParameter("exact", "NULL")
    End Sub

    Private Sub SetMultipleColumnAsFunction()
        ucrReceiverMultipleColumns.SetMeAsReceiver()
        'Set function name
        ucrBase.clsRsyntax.SetFunction("cor")
        'Set what should be visible/invisible
        grpMissing.Visible = True
        cmdPlots.Visible = True
        lblConfInterval.Visible = False
        txtConfidenceInterval.Visible = False
        ucrReceiverFirstColumn.Visible = False
        ucrReceiverSecondColumn.Visible = False
        ucrReceiverMultipleColumns.Visible = True
        'Remove parameters from the TwoColumn case
        ucrBase.clsRsyntax.RemoveParameter("alternative")
        ucrBase.clsRsyntax.RemoveParameter("exact")
        ucrBase.clsRsyntax.RemoveParameter("conf.level")
        ucrBase.clsRsyntax.RemoveParameter("y")
        'Add back in parameters they may have been removed in TwoColumn case
        SetUseParameter()
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
    End Sub


    Private Sub ColumnTypeChanged(sender As Object, e As EventArgs) Handles rdoTwoColumns.CheckedChanged, rdoMultipleColumns.CheckedChanged
        If rdoTwoColumns.Checked Then
            SetTwoColumnAsFunction()
        ElseIf rdoMultipleColumns.Checked Then
            SetMultipleColumnAsFunction()
        End If
    End Sub

    Private Sub txtConfidenceInterval_Leave(sender As Object, e As EventArgs) Handles txtConfidenceInterval.Leave
        ucrBase.clsRsyntax.AddParameter("conf.level", txtConfidenceInterval.Text)
    End Sub
End Class