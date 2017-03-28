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
        ucrReceiverFirstVar.SetRCode(ucrBaseDescribeTwoVar.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverSecondVar.SetRCode(ucrBaseDescribeTwoVar.clsRsyntax.clsBaseFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsRCustomSummary, bReset)
        ucrChkSaveResult.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRAnova, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRFreqTables, bReset)
    End Sub

    Public Sub TestOKEnabled()
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
        ucrReceiverFirstVar.SetMeAsReceiver()
        clsRFreqTables = New RFunction
        clsRAnova = New RFunction
        clsRFreqTables.AddParameter("addmargins", "FALSE")
        clsRFreqTables.AddParameter("transpose", "FALSE")
        clsRFreqTables.AddParameter("proportions", "FALSE")
        clsRFreqTables.AddParameter("percentages", "FALSE")
        clsRAnova.AddParameter("means", "FALSE")
        clsRAnova.AddParameter("signif.stars", "FALSE")
        clsRAnova.AddParameter("sign_level", "FALSE")

        clsSummariesList = New RFunction
        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsRCustomSummary = New RFunction
        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsRCustomSummary.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)

        ucrReceiverFirstVar.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverFirstVar.SetParameterIsString()

        ucrReceiverSecondVar.SetParameter(New RParameter("factors", 2))
        ucrReceiverSecondVar.SetParameterIsString()

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm"))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkSaveResult.SetText("Save Result")
        ucrChkSaveResult.SetParameter(New RParameter("store_results"))
        ucrChkSaveResult.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        clsRCustomSummary.AddParameter("drop", "TRUE")
        clsRCustomSummary.AddParameter("store_results", "FALSE")
        clsRCustomSummary.AddParameter("return_output", "TRUE")

        clsRCorelation.SetRCommand("cor")
        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")

        ucrChkSaveResult.Enabled = False
        cmdSummaries.Visible = False
        cmdDisplayOptions.Visible = False

        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        bResetSubdialog = True
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeTwoVar.iHelpTopicID = 414
        ucrBaseDescribeTwoVar.clsRsyntax.iCallType = 2

        ucrSelectorDescribeTwoVar.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDescribeTwoVar.SetParameterIsString()

        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar
        'ucrReceiverFirstVar.SetSingleTypeStatus(True)

        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")
        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")
    End Sub

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeTwoVar.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDescribeDisplay.SetRFunction(clsRFreqTables, clsRAnova, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.GrpBoxEnable()
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub Correlation()
        ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRCorelation)
        ucrReceiverFirstVar.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstVar.SetParameterIsRFunction()
        ucrReceiverSecondVar.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondVar.SetParameterIsRFunction()
        clsRCorelation.AddParameter("method", Chr(34) & "pearson" & Chr(34))
        clsRCorelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        'ucrChkOmitMissing.ChangeParameterName("drop")
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
        ElseIf ((strVarType = "factor") And (strSecondVarType = "factor")) Then
            ucrChkSaveResult.Enabled = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrBaseDescribeTwoVar.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            ucrReceiverFirstVar.SetParameter(New RParameter("x_col_names", 1))
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameter(New RParameter("y_col_name", 2))
            ucrReceiverSecondVar.SetParameterIsString()
        Else
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVar.ControlContentsChanged, ucrReceiverSecondVar.ControlContentsChanged
        Results()
        TestOKEnabled()
    End Sub
End Class