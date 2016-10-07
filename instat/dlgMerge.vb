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
        ucrInputMergeColumnsOptions.SetItems({"Merge by all columns with the same name", "Choose which columns to merge by"})
        sdgMerge.SetRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub SetDefaults()
        ucrNewDataFrameName.Reset()
        ucrFirstDataFrame.Reset()
        ucrSecondDataFrame.Reset()
        rdoLeftJoin.Checked = True
        ucrInputMergeColumnsOptions.SetName("Merge by all columns with the same name")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrInputMergeColumnsOptions.GetText() = "Merge by all columns with the same name" Then
            If Not ucrNewDataFrameName.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf ucrInputMergeColumnsOptions.GetText() = "Choose which columns to merge by" Then
            If sdgMerge.IsOkEnabled() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        sdgMerge.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDataFrames_DataFrameChanged()
        If Not ucrNewDataFrameName.UserTyped() Then
            ucrNewDataFrameName.SetName(ucrFirstDataFrame.cboAvailableDataFrames.Text & "_merged_with_" & ucrSecondDataFrame.cboAvailableDataFrames.Text)
        End If
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrFirstDataFrame.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("y", clsRFunctionParameter:=ucrSecondDataFrame.clsCurrDataFrame)
        ucrBase.clsRsyntax.AddParameter("suffix", "c(" & Chr(34) & ucrFirstDataFrame.cboAvailableDataFrames.Text & Chr(34) & ", " & Chr(34) & ucrSecondDataFrame.cboAvailableDataFrames.Text & Chr(34) & ")")
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
        TestOKEnabled()
    End Sub

    Private Sub ucrInputMergeColumnsOptions_NameChanged() Handles ucrInputMergeColumnsOptions.NameChanged
        If ucrInputMergeColumnsOptions.GetText() = "Merge by all columns with the same name" Then
            cmdChooseMergeColumns.Enabled = False
        ElseIf ucrInputMergeColumnsOptions.GetText() = "Choose which columns to merge by" Then
            cmdChooseMergeColumns.Enabled = True
            ucrBase.clsRsyntax.RemoveParameter("by")
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdChooseMergeColumns_Click(sender As Object, e As EventArgs) Handles cmdChooseMergeColumns.Click
        sdgMerge.ShowDialog()
    End Sub
End Class