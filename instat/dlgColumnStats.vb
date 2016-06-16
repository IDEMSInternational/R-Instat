
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
Public Class dlgColumnStats
    Public bFirstLoad As Boolean = True
    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (chkCount.Checked Or chkMaximum.Checked Or chkMean.Checked Or chkMedian.Checked Or chkMinimum.Checked Or chkMode.Checked Or chkStDev.Checked Or chkSum.Checked Or chkRange.Checked) And Not ucrReceiverSelectedVariables.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrInputStoreResults.SetName("Summary_name")
        chkStoreResults.Checked = True
        chkReturnOutput.Checked = True
        chkdropUnusedLevels.Checked = True
        ucrSelectorForColumnStatistics.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverSelectedVariables.SetMeAsReceiver()
        ucrReceiverSelectedVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 64
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub grpSummaries_CheckedChanged(sender As Object, e As EventArgs) Handles chkCount.CheckedChanged, chkMean.CheckedChanged, chkMedian.CheckedChanged, chkMinimum.CheckedChanged, chkMaximum.CheckedChanged, chkStDev.CheckedChanged, chkMode.CheckedChanged, chkSum.CheckedChanged, chkRange.CheckedChanged
        SummariesParameters()
        TestOKEnabled()
    End Sub

    Private Sub SummariesParameters()
        Dim lstCheckboxes As New List(Of CheckBox)
        Dim i As Integer = 0
        If lstCheckboxes.Count = 0 Then
            lstCheckboxes.AddRange({chkMean, chkMedian, chkCount, chkMinimum, chkMaximum, chkStDev, chkMode, chkSum, chkRange})
        End If

        If chkCount.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_count" & Chr(34))

        ElseIf chkMean.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_mean" & Chr(34))

        ElseIf chkMinimum.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_min" & Chr(34))

        ElseIf chkMaximum.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_max" & Chr(34))

        ElseIf chkMedian.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_median" & Chr(34))

        ElseIf chkSum.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_sum" & Chr(34))

        ElseIf chkStDev.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summary_sd" & Chr(34))

        ElseIf chkMode.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summmary_mode" & Chr(34))

        ElseIf chkRange.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", Chr(34) & "summmary_range" & Chr(34))
        Else
        End If
    End Sub

    Private Sub grpOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkdropUnusedLevels.CheckedChanged, chkReturnOutput.CheckedChanged
        OptionParameters()
    End Sub

    Private Sub OptionParameters()
        If chkReturnOutput.Checked Then
            ucrBase.clsRsyntax.AddParameter("return_output", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("return_output", "FALSE")
        End If
        If chkdropUnusedLevels.Checked Then
            ucrBase.clsRsyntax.AddParameter("drop", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("drop", "FALSE")
        End If
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorForColumnStatistics.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForColumnStatistics.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverSelectedVariables.SelectionChanged
        If Not ucrReceiverSelectedVariables.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("columns_to_summarise", ucrReceiverSelectedVariables.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("columns_to_summarise")
        End If
    End Sub

    Private Sub chkStoreResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkStoreResults.CheckedChanged
        StoreResultsParamenter()
    End Sub

    Private Sub StoreResultsParamenter()
        If chkStoreResults.Checked Then
            ucrBase.clsRsyntax.AddParameter("store_results", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("store_results", "FALSE")
        End If
    End Sub
    Private Sub ucrInputStoreResults_Namechanged() Handles ucrInputStoreResults.NameChanged
        SummarynameParameter()
    End Sub

    Private Sub SummarynameParameter()
        If chkStoreResults.Checked Then
            ucrBase.clsRsyntax.AddParameter("summary_name", Chr(34) & ucrInputStoreResults.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("summary_name")
        End If
    End Sub

    Private Sub ucrReceiverByFactor_SelectionChanged() Handles ucrReceiverByFactor.SelectionChanged
        If Not ucrReceiverByFactor.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("factors", ucrReceiverByFactor.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("factors")
        End If
    End Sub
End Class