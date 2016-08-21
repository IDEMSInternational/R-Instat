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
Public Class dlgDescribeTwoVariable
    Public bFirstLoad As Boolean = True
    Public clsRBaseStatsFunction, clsRMissingFunction, clsRMissingSubFunction As New RFunction
    Private Sub dlgDescribeTwoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If Not ucrReceiverFirstVar.IsEmpty() Then
            ucrBaseDescribeTwoVar.OKEnabled(True)
        Else
            ucrBaseDescribeTwoVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        chkSaveResult.Checked = False
        sdgDescribe.SetUcrBase(ucrBaseDescribeTwoVar)
        sdgDescribe.SetDefaults()
        ucrSelectorDescribeTwoVar.Reset()
        chkSaveResult.Checked = False
        chkDisplayResults.Checked = True
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2
        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVar.SetMeAsReceiver()
        ucrReceiverFirstVar.SetIncludedDataTypes({"numeric"})
        ucrReceiverSecondVar.SetIncludedDataTypes({"factor"})
        'ucrBaseDescribeOneVar.iHelpTopicID = 
        ucrBaseDescribeTwoVar.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub OutputOption()
        If chkDisplayResults.Checked Then
            ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("return_output", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("return_output", "FALSE")
            Else
                ucrBaseDescribeTwoVar.clsRsyntax.RemoveParameter("return_output")
            End If
        End If
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeTwoVar.DataFrameChanged
        ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverFirstVar.SelectionChanged
        If Not ucrReceiverFirstVar.IsEmpty Then
            ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("columns_to_summarise", ucrReceiverFirstVar.GetVariableNames())
        Else
            ucrBaseDescribeTwoVar.clsRsyntax.RemoveParameter("columns_to_summarise")
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

    Private Sub ucrReceiverDescribeOneVar_Load(sender As Object, e As EventArgs) Handles ucrReceiverFirstVar.Load

    End Sub

    Private Sub StoreResultsParamenter()
        If chkSaveResult.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("store_results", "TRUE")
            Else
                ucrBaseDescribeTwoVar.clsRsyntax.RemoveParameter("store_results")
            End If
        Else
            ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("store_results", "FALSE")
        End If
        ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("drop", "TRUE")
    End Sub

    Private Sub ucrReceiverSecondVar_SelectionChanged() Handles ucrReceiverSecondVar.SelectionChanged
        If Not ucrReceiverSecondVar.IsEmpty Then
            ucrBaseDescribeTwoVar.clsRsyntax.AddParameter("factors", ucrReceiverSecondVar.GetVariableNames)
        Else
            ucrBaseDescribeTwoVar.clsRsyntax.RemoveParameter("factors")
        End If
    End Sub
End Class