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
Imports RDotNet
Public Class dlgDescribeTwoVariable
    Public bFirstLoad As Boolean = True
    Public bCorrelation As Boolean = False
    Public bFactor As Boolean = False
    Public strVarType, strSecondVarType As String
    Public clsGetDataType, clsGetSecondDataType, clsRCorelation, clsRCustomSummary, clsRAnova, clsRFreqTables As New RFunction
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

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDescribeDisplay.GrpBoxEnable()
        sdgDescribeDisplay.ShowDialog()
    End Sub

    Public Sub TestOKEnabled()
        If ((Not ucrReceiverFirstVar.IsEmpty()) And (Not ucrReceiverSecondVar.IsEmpty())) Then
            ucrBaseDescribeTwoVar.OKEnabled(True)
        Else
            ucrBaseDescribeTwoVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        clsRCorelation.SetRCommand("cor")
        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        chkSaveResult.Checked = False
        chkSaveResult.Enabled = False
        cmdSummaries.Visible = False
        cmdDisplayOptions.Visible = False
        sdgSummaries.SetMyRFunction(clsRCustomSummary)
        sdgDescribeDisplay.SetAnovaDispOptions(clsRAnova)
        sdgDescribeDisplay.SetFreqDispOptions(clsRFreqTables)
        sdgSummaries.SetDefaults()
        sdgDescribeDisplay.SetDefaults()
        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVar.Focus()
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2
        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVar.SetSingleTypeStatus(True)
        ucrReceiverFirstVar.SetMeAsReceiver()
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")
        ucrBaseDescribeTwoVar.iHelpTopicID = 414
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.ShowDialog()
    End Sub

    Private Sub Correlation()
        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCorelation)
        clsRCorelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstVar.GetVariables())
        clsRCorelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondVar.GetVariables())
        clsRCorelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        clsRCorelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
    End Sub

    Public Sub Results()
        If ucrReceiverFirstVar.GetCurrentItemTypes.Count > 0 Then
            strVarType = ucrReceiverFirstVar.GetCurrentItemTypes.Item(0)
        Else
            strVarType = ""
        End If
        If (Not ucrReceiverSecondVar.IsEmpty()) Then
            strSecondVarType = ucrReceiverSecondVar.strCurrDataType
        Else
            strSecondVarType = ""
        End If

        If ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            chkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
            Correlation()
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "factor")) Then
            chkSaveResult.Enabled = True
            cmdSummaries.Visible = True
            cmdDisplayOptions.Visible = False
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        ElseIf ((strVarType = "factor") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            chkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRAnova)
            clsRAnova.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            clsRAnova.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            chkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            clsRFreqTables.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            clsRFreqTables.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        Else
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
        End If
    End Sub

    Private Sub OutputOption()
        clsRCustomSummary.AddParameter("return_output", "TRUE")
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeTwoVar.DataFrameChanged
        clsRCustomSummary.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRFreqTables.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRAnova.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub uucrReceiverSecondVar_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondVar.SelectionChanged

    End Sub

    Private Sub ucrReceiverFirstVar_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstVar.SelectionChanged

    End Sub

    Private Sub ucrReceiverFirstVar_SelectionChanged() Handles ucrReceiverFirstVar.SelectionChanged
        If Not ucrReceiverFirstVar.IsEmpty Then
            clsRCustomSummary.AddParameter("columns_to_summarise", ucrReceiverFirstVar.GetVariableNames())
        Else
            clsRCustomSummary.RemoveParameterByName("columns_to_summarise")
        End If
        Results()
        TestOKEnabled()
    End Sub

    Private Sub uucrReceiverSecondVar_SelectionChanged() Handles ucrReceiverSecondVar.SelectionChanged
        If Not ucrReceiverSecondVar.IsEmpty Then
            clsRCustomSummary.AddParameter("factors", ucrReceiverSecondVar.GetVariableNames)
        Else
            clsRCustomSummary.RemoveParameterByName("factors")
        End If
        Results()
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

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub StoreResultsParamenter()
        If chkSaveResult.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCustomSummary.AddParameter("store_results", "TRUE")
            Else
                clsRCustomSummary.RemoveParameterByName("store_results")
            End If
        Else
            clsRCustomSummary.AddParameter("store_results", "FALSE")
        End If
        clsRCustomSummary.AddParameter("drop", "TRUE")
    End Sub

    Private Sub chkExcludeMissing_CheckedChanged(sender As Object, e As EventArgs) Handles chkOmitMissing.CheckedChanged
        If chkOmitMissing.Checked Then
            clsRCustomSummary.AddParameter("na.rm", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCustomSummary.AddParameter("na.rm", "FALSE")
            Else
                clsRCustomSummary.RemoveParameterByName("na.rm")
            End If
        End If
    End Sub
End Class