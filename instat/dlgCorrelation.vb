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
    Public bFirstLoad As Boolean = True
    Public bIsTwoColumnFunction As Boolean

    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiverFirstColumn.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverSecondColumn.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverMultipleColumns.Selector = ucrSelectorDataFrameVarAddRemove
        ucrReceiverFirstColumn.SetDataType("numeric")
        ucrReceiverSecondColumn.SetDataType("numeric")
        ucrReceiverMultipleColumns.SetDataType("numeric")

        ucrBase.iHelpTopicID = 316
        sdgCorrPlot.SetRModelFunction(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDataFrameVarAddRemove.Reset()
        ucrSelectorDataFrameVarAddRemove.Focus()
        ' ucrReceiverFirstColumn.Focus()
        rdoPearson.Checked = True
        rdoMultipleColumns.Checked = True
        sdgCorrPlot.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFirstColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstColumn.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondColumn.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
        TestOKEnabled()
    End Sub

    Public Sub ucrReceiverMultipleColumns_SelectionChanged() Handles ucrReceiverMultipleColumns.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleColumns.GetVariables())
        TestOKEnabled()
    End Sub

    'put all rdo button checked changed in one sub to make it shorter
    Private Sub rdoForMethodsCheckedChanged(sender As Object, e As EventArgs) Handles rdoPearson.CheckedChanged, rdoKendall.CheckedChanged, rdoSpearman.CheckedChanged
        If rdoPearson.Checked Then
            ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "pearson" & Chr(34))
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("method", Chr(34) & "pearson" & Chr(34))
            Else
                ucrBase.clsRsyntax.RemoveParameter("method")
            End If
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
        ucrBase.clsRsyntax.iCallType = 2
        'set the receiver
        ucrReceiverFirstColumn.SetMeAsReceiver()
        'Set function name
        ucrBase.clsRsyntax.SetFunction("cor.test")
        'Set what should be visible/invisible
        grpMissing.Visible = False
        cmdOptions.Visible = False
        lblConfInterval.Visible = True
        nudConfidenceInterval.Visible = True
        ucrReceiverFirstColumn.Visible = True
        ucrReceiverSecondColumn.Visible = True
        ucrReceiverMultipleColumns.Visible = False
        'remove parameters from MultipleColumn case
        ucrBase.clsRsyntax.RemoveParameter("use")
        'add in parameters that may have been removed from MultipleColumn case
        If nudConfidenceInterval.Value.ToString = "" Then
            nudConfidenceInterval.Value = 0.95
        End If
        ucrBase.clsRsyntax.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstColumn.GetVariables())
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondColumn.GetVariables())
        ucrBase.clsRsyntax.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
        ucrBase.clsRsyntax.AddParameter("exact", "NULL")
        bIsTwoColumnFunction = True
        TestOKEnabled()
    End Sub

    Private Sub nudConfidenceInterval_ValueChanged(sender As Object, e As EventArgs) Handles nudConfidenceInterval.ValueChanged
        ucrBase.clsRsyntax.AddParameter("conf.level", nudConfidenceInterval.Value.ToString)
    End Sub

    Private Sub SetMultipleColumnAsFunction()
        ucrReceiverMultipleColumns.SetMeAsReceiver()
        'Set function name
        ucrBase.clsRsyntax.SetFunction("cor")
        'Set what should be visible/invisible
        grpMissing.Visible = True
        cmdOptions.Visible = True
        lblConfInterval.Visible = False
        nudConfidenceInterval.Visible = False
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
        bIsTwoColumnFunction = False
        TestOKEnabled()
    End Sub

    Private Sub ColumnTypeChanged(sender As Object, e As EventArgs) Handles rdoTwoColumns.CheckedChanged, rdoMultipleColumns.CheckedChanged
        If rdoTwoColumns.Checked Then
            SetTwoColumnAsFunction()
        ElseIf rdoMultipleColumns.Checked Then
            SetMultipleColumnAsFunction()
        End If
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCorrPlot.ShowDialog()
    End Sub

    Private Sub TestOKEnabled()
        If (rdoTwoColumns.Checked = True) Then
            If ucrReceiverFirstColumn.IsEmpty() = False And ucrReceiverSecondColumn.IsEmpty() = False And (rdoPearson.Checked = True Or rdoKendall.Checked = True Or rdoSpearman.Checked = True) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf (rdoMultipleColumns.Checked = True) Then
            If ucrReceiverMultipleColumns.IsEmpty() = False And ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 And (rdoCompleteRowsOnly.Checked = True Or rdoPairwise.Checked = True) AndAlso (rdoPearson.Checked = True Or rdoKendall.Checked = True Or rdoSpearman.Checked = True) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If (rdoMultipleColumns.Checked) Then
            sdgCorrPlot.RegOptions()
        End If
    End Sub

End Class