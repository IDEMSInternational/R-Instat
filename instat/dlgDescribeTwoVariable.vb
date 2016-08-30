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

    Private Sub cmdstatistics_click(sender As Object, e As EventArgs) Handles cmdStatistics.Click
        sdgDescribe.ShowDialog()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDescribeDisplay.GrpBoxEnable()
        sdgDescribeDisplay.ShowDialog()
    End Sub

    Public Sub TestOKEnabled()
        If ((Not ucrReceiverFirstVar.IsEmpty()) And (Not ucrReceiverSecondVar.IsEmpty())) Then
            ucrBaseDescribeTwoVar.OKEnabled(True)
            Results()
        Else
            ucrBaseDescribeTwoVar.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2
        clsRCorelation.SetRCommand("cor")
        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        chkSaveResult.Checked = False
        chkSaveResult.Enabled = False
        cmdStatistics.Visible = False
        cmdDisplayOptions.Visible = False
        sdgDescribe.SetUcrDescribe(clsRCustomSummary)
        sdgDescribeDisplay.SetAnovaDispOptions(clsRAnova)
        sdgDescribeDisplay.SetFreqDispOptions(clsRFreqTables)
        sdgDescribe.SetDefaults()
        sdgDescribeDisplay.SetDefaults()
        ucrSelectorDescribeTwoVar.Reset()
        chkSaveResult.Checked = False
        StoreResultsParamenter()
        OutputOption()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2
        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVar.SetMeAsReceiver()
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")
        'ucrBaseDescribeOneVar.iHelpTopicID = 
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub Correlation()
        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCorelation)
        clsRCorelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverFirstVar.GetVariables())
        clsRCorelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverSecondVar.GetVariables())
        clsRCorelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        clsRCorelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
    End Sub

    Public Sub Results()
        SecondVarType()
        If ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            chkSaveResult.Enabled = False
            cmdStatistics.Visible = False
            cmdDisplayOptions.Visible = False
            Correlation()
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") And (strSecondVarType = "factor")) Then
            chkSaveResult.Enabled = True
            cmdStatistics.Visible = True
            cmdDisplayOptions.Visible = False
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        ElseIf ((strVarType = "factor") And (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            chkSaveResult.Enabled = False
            cmdStatistics.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRAnova)
            clsRAnova.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            clsRAnova.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            chkSaveResult.Enabled = False
            cmdStatistics.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            clsRFreqTables.AddParameter("x_col_names", ucrReceiverFirstVar.GetVariableNames())
            clsRFreqTables.AddParameter("y_col_name", ucrReceiverSecondVar.GetVariableNames())
        End If
    End Sub

    Private Sub SecondVarType()
        If (Not ucrReceiverSecondVar.IsEmpty()) Then
            clsGetSecondDataType.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
            clsGetSecondDataType.AddParameter("column", ucrReceiverSecondVar.GetVariableNames())
            strSecondVarType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetSecondDataType.ToScript()).AsCharacter(0)
        Else
            strSecondVarType = ""
        End If
    End Sub

    Private Sub CheckType()
        Dim strVariableTypes As List(Of String)
        Dim strOldType As String
        strOldType = strVarType
        If (Not ucrReceiverFirstVar.IsEmpty()) Then
            clsGetDataType.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
            clsGetDataType.AddParameter("column", ucrReceiverFirstVar.GetVariableNames())
            If ucrReceiverFirstVar.lstSelectedVariables.Items.Count = 1 Then
                strVarType = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter(0)
                If (strVarType = "numeric" OrElse strVarType = "integer") Then
                    ucrReceiverFirstVar.SetDataType("numeric")
                Else
                    ucrReceiverFirstVar.SetDataType(strVarType)
                End If
            ElseIf strVarType = "" AndAlso ucrReceiverFirstVar.lstSelectedVariables.Items.Count > 1 Then
                strVariableTypes = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataType.ToScript()).AsCharacter.ToList()
                If strVariableTypes.Distinct().Count > 1 AndAlso Not (strVariableTypes.Distinct().Count = 2 AndAlso strVariableTypes.Distinct().Contains("numeric") AndAlso strVariableTypes.Distinct().Contains("integer")) Then
                    MsgBox("Cannot add these variables. All variables must be of the same data type.", MsgBoxStyle.OkOnly, "Cannot add variables.")
                    ucrReceiverFirstVar.Clear()
                Else
                    If strVariableTypes.Distinct().Count = 1 Then
                        strVarType = strVariableTypes(0)
                    Else
                        strVarType = "numeric"
                    End If
                    ucrReceiverFirstVar.SetDataType(strVarType)
                End If
            End If
        Else
            strVarType = ""
            ucrReceiverFirstVar.RemoveIncludedMetadataProperty(strProperty:="class")
        End If
    End Sub

    Private Sub OutputOption()
        clsRCustomSummary.AddParameter("return_output", "TRUE")
    End Sub

    Private Sub ucrReceiverSecondVar_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondVar.SelectionChanged

    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstVar.SelectionChanged

    End Sub

    Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeTwoVar.DataFrameChanged
        clsRCustomSummary.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRFreqTables.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRAnova.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverFirstVar.SelectionChanged
        CheckType()
        If Not ucrReceiverFirstVar.IsEmpty Then
            clsRCustomSummary.AddParameter("columns_to_summarise", ucrReceiverFirstVar.GetVariableNames())
        Else
            clsRCustomSummary.RemoveParameterByName("columns_to_summarise")
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

    Private Sub ucrReceiverSecondVar_SelectionChanged() Handles ucrReceiverSecondVar.SelectionChanged
        If Not ucrReceiverSecondVar.IsEmpty Then
            SecondVarType()
            clsRCustomSummary.AddParameter("factors", ucrReceiverSecondVar.GetVariableNames)
        Else
            clsRCustomSummary.RemoveParameterByName("factors")
        End If
        TestOKEnabled()
    End Sub
End Class