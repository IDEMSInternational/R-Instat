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
        sdgDescribe.SetUcrBase(clsRCustomFunction)
        sdgDescribe.SetDefaults()
        ucrSelectorDescribeOneVar.Reset()
        chkSaveResult.Checked = False
        chkCustomise.Checked = False
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ' ucrBaseDescribeOneVar.clsRsyntax.iCallType = 0
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        'ucrReceiverDescribeOneVar.SetIncludedDataTypes({"numeric"})
        clsRBaseFunction.SetRCommand("summary")
        'ucrBaseDescribeOneVar.iHelpTopicID = 
        'ucrBaseDescribeOneVar.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        'ucrBaseDescribeOneVar.clsRsyntax.SetFunction("")
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ChooseFunction()
        If chkCustomise.Checked Then
            clsRCustomFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        Else
            clsRBaseFunction.SetRCommand("summary")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("columns_to_summarise")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("return_output")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("store_results")
            'ucrBaseDescribeOneVar.clsRsyntax.AddParameter("drop", "TRUE")
        End If
    End Sub

    'Private Sub AddCols()
    '    clsRPredFunction.SetRCommand("predict")
    '    clsRPredFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
    '    clsRPredFunction.AddParameter("interval", Chr(34) & "prediction" & Chr(34))
    '    clsRDFFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
    '    clsRDFFunction.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
    '    clsRDFFunction.AddParameter("col_name", "c(" & Chr(34) & "fit" & Chr(34) & "," & Chr(34) & "lwr" & Chr(34) & "," & Chr(34) & "upr" & Chr(34) & ")")
    '    clsRDFFunction.AddParameter("col_data", clsRFunctionParameter:=clsRPredFunction)
    '    clsRDFFunction.AddParameter("use_col_name_as_prefix", "FALSE")
    '    frmMain.clsRLink.RunScript(clsRDFFunction.ToScript(), 2)
    'End Sub
    Private Sub OutputOption()
        'If chkDisplayResults.Checked Then
        clsRCustomFunction.AddParameter("return_output", "TRUE")
        'Else
        '    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '        ucrBaseDescribeOneVar.clsRsyntax.AddParameter("return_output", "FALSE")
        '    Else
        '        ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("return_output")
        '    End If
        'End If
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeOneVar.DataFrameChanged
        clsRCustomFunction.AddParameter("data_name", Chr(34) & ucrSelectorDescribeOneVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickOk
        If chkCustomise.Checked Then
            frmMain.clsRLink.RunScript(clsRCustomFunction.ToScript(), 2)
        Else
            frmMain.clsRLink.RunScript(clsRBaseFunction.ToScript(), 2)
            'ucrBaseDescribeOneVar.clsRsyntax.SetFunction("summary")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("columns_to_summarise")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("return_output")
            'ucrBaseDescribeOneVar.clsRsyntax.RemoveParameter("store_results")
            'ucrBaseDescribeOneVar.clsRsyntax.AddParameter("drop", "TRUE")
        End If
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
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDescribeOneVar.SelectionChanged

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
End Class
