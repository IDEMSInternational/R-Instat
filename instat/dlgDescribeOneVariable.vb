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
Public Class dlgDescribeOneVariable
    Public bFirstLoad As Boolean = True
    Public clsRBaseFunction, clsRCustomFunction As New RFunction
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

    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.ShowDialog()
        sdgSummaries.TestSummaries()
        TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverDescribeOneVar.IsEmpty() Then
            If chkCustomise.Checked Then
                If sdgSummaries.strSummariesParameter = "c()" Then
                    ucrBaseDescribeOneVar.OKEnabled(False)
                Else
                    ucrBaseDescribeOneVar.OKEnabled(True)
                End If
            Else
                ucrBaseDescribeOneVar.OKEnabled(True)
            End If
        Else
            ucrBaseDescribeOneVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        chkSaveResult.Checked = False
        sdgSummaries.SetMyRFunction(clsRCustomFunction)
        sdgSummaries.SetDefaults()
        ucrSelectorDescribeOneVar.Reset()
        chkSaveResult.Checked = False
        chkSaveResult.Enabled = False
        chkCustomise.Checked = False
        chkOmitMissing.Checked = False
        ChooseFunction()
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeOneVar.clsRsyntax.iCallType = 2
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        clsRCustomFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsRBaseFunction.SetRCommand("summary")
        ucrBaseDescribeOneVar.iHelpTopicID = 410
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ChooseFunction()
        If chkCustomise.Checked Then
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsRCustomFunction)
            cmdSummaries.Enabled = True
        Else
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsRBaseFunction)
            cmdSummaries.Enabled = False
        End If
    End Sub

    Private Sub OutputOption()
        clsRCustomFunction.AddParameter("return_output", "TRUE")
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeOneVar.DataFrameChanged
        clsRCustomFunction.AddParameter("data_name", Chr(34) & ucrSelectorDescribeOneVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverDescribeOneVar.SelectionChanged
        If Not ucrReceiverDescribeOneVar.IsEmpty Then
            clsRCustomFunction.AddParameter("columns_to_summarise", ucrReceiverDescribeOneVar.GetVariableNames())
            clsRBaseFunction.AddParameter("object", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
        Else
            clsRCustomFunction.RemoveParameterByName("columns_to_summarise")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResult.CheckedChanged
        StoreResultsParamenter()
        OutputOption()
    End Sub

    Private Sub chkDisplayResults_CheckedChanged(sender As Object, e As EventArgs)
        StoreResultsParamenter()
        OutputOption()
    End Sub

    Private Sub chkCustomise_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustomise.CheckedChanged
        ChooseFunction()
        TestOKEnabled()
    End Sub

    Private Sub StoreResultsParamenter()
        If chkSaveResult.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCustomFunction.AddParameter("store_results", "TRUE")
            Else
                clsRCustomFunction.RemoveParameterByName("store_results")
            End If
            clsRCustomFunction.AddParameter("store_results", "FALSE")
        End If
        clsRCustomFunction.AddParameter("drop", "TRUE")
    End Sub

    Private Sub chkExcludeMissing_CheckedChanged(sender As Object, e As EventArgs) Handles chkOmitMissing.CheckedChanged
        If chkOmitMissing.Checked Then
            clsRCustomFunction.AddParameter("na.rm", "TRUE")
            clsRBaseFunction.AddParameter("na.rm", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCustomFunction.AddParameter("na.rm", "FALSE")
                clsRBaseFunction.AddParameter("na.rm", "FALSE")
            Else
                clsRCustomFunction.RemoveParameterByName("na.rm")
                clsRBaseFunction.RemoveParameterByName("na.rm")
            End If
        End If
    End Sub
End Class
