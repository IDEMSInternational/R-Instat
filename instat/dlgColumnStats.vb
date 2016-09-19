
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
    Public clsRColumnStats As New RFunction
    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TestOKEnabled()
        If (Not ucrReceiverSelectedVariables.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        chkStoreResults.Checked = True
        chkPrintOutput.Checked = False
        chkdropUnusedLevels.Checked = False
        ucrSelectorForColumnStatistics.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverSelectedVariables.SetMeAsReceiver()
        ucrReceiverSelectedVariables.SetIncludedDataTypes({"numeric"})
        ' only allow numeric variables in the first receiver? 
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"}) 'This needs to change
        ucrBase.iHelpTopicID = 64
        clsRColumnStats.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        sdgSummaries.SetMyRFunction(clsRColumnStats)
        sdgSummaries.SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsRColumnStats)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub grpOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkdropUnusedLevels.CheckedChanged, chkPrintOutput.CheckedChanged
        OptionParameters()
    End Sub

    Private Sub OptionParameters()
        If chkPrintOutput.Checked Then
            clsRColumnStats.AddParameter("return_output", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRColumnStats.AddParameter("return_output", "FALSE")
            Else
                clsRColumnStats.RemoveParameterByName("return_output")
            End If
        End If
        If chkdropUnusedLevels.Checked Then
            clsRColumnStats.AddParameter("drop", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRColumnStats.AddParameter("drop", "FALSE")
            Else
                clsRColumnStats.RemoveParameterByName("drop")
            End If
        End If
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorForColumnStatistics.DataFrameChanged
        clsRColumnStats.AddParameter("data_name", Chr(34) & ucrSelectorForColumnStatistics.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverSelectedVariables.SelectionChanged
        If Not ucrReceiverSelectedVariables.IsEmpty Then
            clsRColumnStats.AddParameter("columns_to_summarise", ucrReceiverSelectedVariables.GetVariableNames)
        Else
            clsRColumnStats.RemoveParameterByName("columns_to_summarise")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkStoreResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkStoreResults.CheckedChanged
        StoreResultsParamenter()
    End Sub

    Private Sub StoreResultsParamenter()
        If chkStoreResults.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRColumnStats.AddParameter("store_results", "TRUE")
            Else
                clsRColumnStats.RemoveParameterByName("store_results")
            End If
        Else
            clsRColumnStats.AddParameter("store_results", "FALSE")
        End If
    End Sub

    Private Sub ucrReceiverByFactor_SelectionChanged() Handles ucrReceiverByFactor.SelectionChanged
        If Not ucrReceiverByFactor.IsEmpty Then
            clsRColumnStats.AddParameter("factors", ucrReceiverByFactor.GetVariableNames)
        Else
            clsRColumnStats.RemoveParameterByName("factors")
        End If
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.ShowDialog()
    End Sub
End Class