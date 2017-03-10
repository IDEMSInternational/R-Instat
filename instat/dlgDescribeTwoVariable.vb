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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bCorrelation As Boolean = False
    Public bFactor As Boolean = False
    Public strVarType, strSecondVarType As String
    Public clsGetDataType, clsGetSecondDataType, clsRCorelation, clsRCustomSummary, clsRAnova, clsRFreqTables As New RFunction
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private Sub dlgDescribeTwoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'When we set the R code, the receiver and checkboxs should have whatever is currently the base function
        ucrReceiverFirstVar.SetRCode(ucrBaseDescribeTwoVar.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverSecondVar.SetRCode(ucrBaseDescribeTwoVar.clsRsyntax.clsBaseFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsRCustomSummary, bReset)
        'ucrChkCustomise.SetRCode(ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, bReset)
        'However, the selector always has the Instat function. This prevents the selector's parameter being added in to the wrong function.
        ucrSelectorDescribeTwoVar.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRAnova, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRFreqTables, bReset)
    End Sub

    Public Sub TestOKEnabled()
        'to consider ordered factor here
        If ((Not ucrReceiverFirstVar.IsEmpty()) AndAlso (Not ucrReceiverSecondVar.IsEmpty())) Then
            If ((strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType = "factor")) AndAlso sdgSummaries.strSummariesParameter = "c()" Then
                ucrBaseDescribeTwoVar.OKEnabled(False)
            Else
                ucrBaseDescribeTwoVar.OKEnabled(True)
            End If
        Else
            ucrBaseDescribeTwoVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorDescribeTwoVar.Reset()

        clsSummariesList = New RFunction
        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsRCustomSummary = New RFunction
        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        'clsInstatSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        'clsInstatSummaryFunction.AddParameter("return_output", "TRUE")
        clsRCustomSummary.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)

        ucrReceiverFirstVar.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverFirstVar.SetParameterIsString()

        ucrReceiverSecondVar.SetParameter(New RParameter("factors", 2))
        ucrReceiverSecondVar.SetParameterIsString()

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm"))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        'cmdSummaries.Enabled = False

        clsRCorelation.SetRCommand("cor")

        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        ucrChkSaveResult.Checked = False
        ucrChkSaveResult.Enabled = False
        cmdSummaries.Visible = False
        cmdDisplayOptions.Visible = False
        ucrChkOmitMissing.Checked = False
        'sdgSummaries.SetMyRFunction(clsRCustomSummary)
        sdgDescribeDisplay.SetAnovaDispOptions(clsRAnova)
        sdgDescribeDisplay.SetFreqDispOptions(clsRFreqTables)
        'sdgSummaries.SetDefaults()
        sdgDescribeDisplay.SetDefaults()
        ucrReceiverFirstVar.SetMeAsReceiver()
        ucrSelectorDescribeTwoVar.Reset()
        ucrSelectorDescribeTwoVar.Focus()
        StoreResultsParamenter()
        OutputOption()
        'TestOKEnabled()
        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        bResetSubdialog = True
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeTwoVar.iHelpTopicID = 414
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2

        ucrSelectorDescribeTwoVar.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDescribeTwoVar.SetParameterIsString()

        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVar.SetSingleTypeStatus(True)
        ucrReceiverFirstVar.SetMeAsReceiver()
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")

        'The selector is only used for one of the functions. Therefore it's parameter name is always the same. So this can be done in Initialise.
        'ucrSelectorDescribeOneVar.SetParameter(New RParameter("data_name", 0))
        'ucrSelectorDescribeOneVar.SetParameterIsString()

        'ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        'ucrReceiverDescribeOneVar.SetMeAsReceiver()

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkSaveResult.SetText("Save Result")
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDescribeDisplay.GrpBoxEnable()
        sdgDescribeDisplay.ShowDialog()
    End Sub

    Private Sub Correlation()
        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCorelation)
        ucrReceiverFirstVar.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstVar.SetParameterIsRFunction()
        ucrReceiverSecondVar.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondVar.SetParameterIsRFunction()
        'clsRCorelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstVar.GetVariables())
        'clsRCorelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondVar.GetVariables())
        clsRCorelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        clsRCorelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ucrChkOmitMissing.ChangeParameterName("drop")
        cmdSummaries.Enabled = True
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
            ucrChkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
            Correlation()
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "factor")) Then
            ucrChkSaveResult.Enabled = True
            cmdSummaries.Visible = True
            cmdDisplayOptions.Visible = False
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
            ucrReceiverFirstVar.SetParameter(New RParameter("columns_to_summarise", 1))
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameter(New RParameter("factors", 2))
            ucrReceiverSecondVar.SetParameterIsString()
        ElseIf ((strVarType = "factor") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            ucrChkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRAnova)
            ucrReceiverFirstVar.SetParameter(New RParameter("x_col_names", 1))
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameter(New RParameter("y_col_name", 2))
            ucrReceiverSecondVar.SetParameterIsString()
            'clsRAnova.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            'clsRAnova.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            ucrChkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            ucrReceiverFirstVar.SetParameter(New RParameter("x_col_names", 1))
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameter(New RParameter("y_col_name", 2))
            ucrReceiverSecondVar.SetParameterIsString()
            'clsRFreqTables.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            'clsRFreqTables.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        Else
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub OutputOption()
        clsRCustomSummary.AddParameter("return_output", "TRUE")
    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeTwoVar.DataFrameChanged
        clsRCustomSummary.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRFreqTables.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRAnova.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSecondVar_SelectionChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub ucrReceiverFirstVar_SelectionChanged() Handles ucrReceiverFirstVar.SelectionChanged
    '    If Not ucrReceiverFirstVar.IsEmpty Then
    '        clsRCustomSummary.AddParameter("columns_to_summarise", ucrReceiverFirstVar.GetVariableNames())
    '    Else
    '        clsRCustomSummary.RemoveParameterByName("columns_to_summarise")
    '    End If
    '    Results()
    '    TestOKEnabled()
    'End Sub

    'Private Sub ucrReceiverSecondVar_SelectionChanged() Handles ucrReceiverSecondVar.SelectionChanged
    '    If Not ucrReceiverSecondVar.IsEmpty Then
    '        clsRCustomSummary.AddParameter("factors", ucrReceiverSecondVar.GetVariableNames)
    '    Else
    '        clsRCustomSummary.RemoveParameterByName("factors")
    '    End If
    '    Results()
    '    TestOKEnabled()
    'End Sub

    Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs)
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
        If ucrChkSaveResult.Checked Then
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

    Private Sub chkExcludeMissing_CheckedChanged(sender As Object, e As EventArgs)
        If ucrChkOmitMissing.Checked Then
            clsRCustomSummary.AddParameter("na.rm", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                clsRCustomSummary.AddParameter("na.rm", "FALSE")
            Else
                clsRCustomSummary.RemoveParameterByName("na.rm")
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVar.ControlContentsChanged, ucrReceiverSecondVar.ControlContentsChanged
        Results()
        TestOKEnabled()
    End Sub
End Class