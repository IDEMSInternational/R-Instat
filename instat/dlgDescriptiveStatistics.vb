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
Public Class dlgDescriptiveStatistics
    Public bFirstLoad As Boolean = True
    Public clsRBaseStatsFunction, clsRMissingFunction, clsRMissingSubFunction As New RFunction
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub cmdstatistics_click(sender As Object, e As EventArgs) Handles cmdStatistics.Click
        sdgDescribe.ShowDialog()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverDescribeOneVar.IsEmpty() Then
            ucrBaseDescribeOneVar.OKEnabled(True)
        Else
            ucrBaseDescribeOneVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        chkSaveResult.Checked = False
        sdgDescribe.SetUcrBase(ucrBaseDescribeOneVar)
        sdgDescribe.SetDefaults()
        ucrSelectorDescribeOneVar.Reset()
        chkSaveResult.Checked = False
        chkDisplayResults.Checked = True
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeOneVar.clsRsyntax.iCallType = 2
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        ucrReceiverDescribeOneVar.SetIncludedDataTypes({"numeric"})
        'ucrBaseDescribeOneVar.iHelpTopicID = 
        ucrBaseDescribeOneVar.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub OutputOption()
        If chkDisplayResults.Checked Then
            ucrBaseDescribeOneVar.clsRsyntax.AddParameter("return_output", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBaseDescribeOneVar.clsRsyntax.AddParameter("return_output", "FALSE")
            Else
                ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("return_output")
            End If
        End If
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeOneVar.DataFrameChanged
        ucrBaseDescribeOneVar.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDescribeOneVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverDescribeOneVar.SelectionChanged
        If Not ucrReceiverDescribeOneVar.IsEmpty Then
            ucrBaseDescribeOneVar.clsRsyntax.AddParameter("columns_to_summarise", ucrReceiverDescribeOneVar.GetVariableNames())
        Else
            ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("columns_to_summarise")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResult.CheckedChanged
        StoreResultsParamenter()
        OutputOption()
    End Sub

    Private Sub chkDisplayResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplayResults.CheckedChanged
        StoreResultsParamenter()
        OutputOption()
    End Sub

    Private Sub ucrReceiverDescribeOneVar_Load(sender As Object, e As EventArgs) Handles ucrReceiverDescribeOneVar.Load

    End Sub

    Private Sub StoreResultsParamenter()
        If chkSaveResult.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBaseDescribeOneVar.clsRsyntax.AddParameter("store_results", "TRUE")
            Else
                ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("store_results")
            End If
        Else
            ucrBaseDescribeOneVar.clsRsyntax.AddParameter("store_results", "FALSE")
        End If
        ucrBaseDescribeOneVar.clsRsyntax.AddParameter("drop", "TRUE")
    End Sub
End Class
