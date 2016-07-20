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

Public Class dlgMerge
    Private bFirstLoad As Boolean = True

    Private Sub dlgMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 60
        ucrNewDataFrameName.SetValidationTypeAsRVariable()
        cmdAddAnotherPair.Enabled = False
        ucrReceiverFirstDFKey1.Selector = ucrSelectorFirstDataFrame
        ucrReceiverFirstDFKey2.Selector = ucrSelectorFirstDataFrame
        ucrReceiverFirstDFKey3.Selector = ucrSelectorFirstDataFrame
        ucrReceiverSecondDFKey1.Selector = ucrSelectorSecondDataFrame
        ucrReceiverSecondDFKey2.Selector = ucrSelectorSecondDataFrame
        ucrReceiverSecondDFKey3.Selector = ucrSelectorSecondDataFrame
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrSelectorFirstDataFrame.Reset()
        ucrSelectorSecondDataFrame.Reset()
        ucrReceiverFirstDFKey1.SetMeAsReceiver()
        ucrReceiverSecondDFKey1.SetMeAsReceiver()
        rdoLeftJoin.Checked = True
        rdoChooseMergeColumns.Checked = True
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        Dim bAllowOk As Boolean = True
        If rdoChooseMergeColumns.Checked Then
            If (Not ucrReceiverFirstDFKey1.IsEmpty() AndAlso ucrReceiverSecondDFKey1.IsEmpty) OrElse (Not ucrReceiverFirstDFKey2.IsEmpty() AndAlso ucrReceiverSecondDFKey2.IsEmpty) OrElse (Not ucrReceiverFirstDFKey3.IsEmpty() AndAlso ucrReceiverSecondDFKey3.IsEmpty) Then
                bAllowOk = False
            End If
        End If
        If ucrNewDataFrameName.IsEmpty() Then
            bAllowOk = False
        End If
        ucrBase.OKEnabled(bAllowOk)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDataFrames_DataFrameChanged() Handles ucrSelectorFirstDataFrame.DataFrameChanged, ucrSelectorSecondDataFrame.DataFrameChanged
        If Not ucrNewDataFrameName.UserTyped() Then
            ucrNewDataFrameName.SetName(ucrSelectorFirstDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_merged_with_" & ucrSelectorSecondDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrSelectorFirstDataFrame.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrSelectorSecondDataFrame.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub JoinType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFullJoin.CheckedChanged, rdoInnerJoin.CheckedChanged, rdoLeftJoin.CheckedChanged, rdoRightJoin.CheckedChanged
        If rdoLeftJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("left_join")
        ElseIf rdoFullJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("full_join")
        ElseIf rdoInnerJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("inner_join")
        ElseIf rdoRightJoin.Checked Then
            ucrBase.clsRsyntax.SetFunction("right_join")
        End If
    End Sub

    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If ucrNewDataFrameName.IsEmpty Then
            ucrBase.clsRsyntax.RemoveAssignTo()
        Else
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        End If
    End Sub

    Private Sub KeyOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMergeByAllColumns.CheckedChanged, rdoChooseMergeColumns.CheckedChanged
        If rdoChooseMergeColumns.Checked Then
            grpKeys.Visible = True
            SetByArgument()
            ucrSelectorFirstDataFrame.SetVariablesEnabled(True)
            ucrSelectorSecondDataFrame.SetVariablesEnabled(True)
        Else
            grpKeys.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("by")
            ucrSelectorFirstDataFrame.SetVariablesEnabled(False)
            ucrSelectorSecondDataFrame.SetVariablesEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverFirstDFKey1_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstDFKey1.SelectionChanged
        If Not ucrReceiverFirstDFKey1.IsEmpty() Then
            If ucrReceiverSecondDFKey2.IsEmpty AndAlso ucrSelectorSecondDataFrame.ContainsVariable(ucrReceiverFirstDFKey1.GetVariableNames(False)) Then
                ucrReceiverSecondDFKey1.Add(ucrReceiverFirstDFKey1.GetVariableNames(False))
            End If
            If ucrReceiverSecondDFKey1.IsEmpty Then

            End If
        End If
        SetByArgument()
    End Sub

    Private Sub SetByArgument()
        Dim strByArgument As String = "c("

        If Not ucrReceiverFirstDFKey1.IsEmpty AndAlso Not ucrReceiverSecondDFKey1.IsEmpty Then
            strByArgument = strByArgument & ucrReceiverFirstDFKey1.GetVariableNames & "=" & ucrReceiverSecondDFKey1.GetVariableNames() & ")"
            ucrBase.clsRsyntax.AddParameter("by", strByArgument)
        ElseIf Not ucrReceiverFirstDFKey1.IsEmpty Then
            strByArgument = strByArgument & ucrReceiverFirstDFKey1.GetVariableNames & ")"
            ucrBase.clsRsyntax.AddParameter("by", strByArgument)
        ElseIf Not ucrReceiverFirstDFKey2.IsEmpty Then
            strByArgument = strByArgument & ucrReceiverFirstDFKey2.GetVariableNames & ")"
            ucrBase.clsRsyntax.AddParameter("by", strByArgument)
        Else
            ucrBase.clsRsyntax.RemoveParameter("by")
        End If
    End Sub
End Class