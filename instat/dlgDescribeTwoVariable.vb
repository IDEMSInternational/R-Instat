' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgDescribeTwoVariable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public strVarType, strSecondVarType As String
    Public clsGetDataType, clsGetSecondDataType, clsRCorrelation, clsRCustomSummary, clsRAnova, clsRFreqTables As New RFunction
    Private clsSummariesList As New RFunction
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 414
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelectorDescribeTwoVar.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDescribeTwoVar.SetParameterIsString()

        ucrReceiverFirstVar.SetParameter(New RParameter("factors", 2))
        ucrReceiverFirstVar.SetParameterIsString()
        ucrReceiverFirstVar.Selector = ucrSelectorDescribeTwoVar

        ucrReceiverSecondVar.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondVar.SetSingleTypeStatus(True)

        ucrChkSaveResult.SetParameter(New RParameter("store_results", 4))
        ucrChkSaveResult.SetText("Save Result")
        ucrChkSaveResult.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        clsGetDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataType.AddParameter("property", "data_type_label")

        clsGetSecondDataType.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataType.AddParameter("property", "data_type_label")
    End Sub

    Private Sub SetDefaults()
        clsRFreqTables = New RFunction
        clsRAnova = New RFunction
        clsRCorrelation = New RFunction
        clsSummariesList = New RFunction
        clsRCustomSummary = New RFunction

        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVar.SetMeAsReceiver()

        clsRFreqTables.AddParameter("addmargins", "FALSE", iPosition:=2)
        clsRFreqTables.AddParameter("proportions", "FALSE", iPosition:=3)
        clsRFreqTables.AddParameter("percentages", "FALSE", iPosition:=4)
        clsRFreqTables.AddParameter("transpose", "FALSE", iPosition:=5)

        clsRAnova.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnova.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnova.AddParameter("means", "FALSE", iPosition:=4)

        clsRCorrelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34), iPosition:=2)
        clsRCorrelation.AddParameter("method", Chr(34) & "pearson" & Chr(34), iPosition:=3)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsRCustomSummary.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)

        clsRCustomSummary.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRCustomSummary.AddParameter("drop", "TRUE", iPosition:=5)
        clsRCustomSummary.AddParameter("na.rm", "FALSE", iPosition:=6)
        clsRCustomSummary.AddParameter("return_output", "TRUE", iPosition:=7)

        clsRCorrelation.SetRCommand("cor")
        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")

        Results()

        ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverFirstVar.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverFirstVar.AddAdditionalCodeParameterPair(clsRCustomSummary, New RParameter("factors", 2), iAdditionalPairNo:=2)
        ucrReceiverFirstVar.AddAdditionalCodeParameterPair(clsRFreqTables, New RParameter("y_col_name", 2), iAdditionalPairNo:=3)
        'ucrReceiverFirstVar.AddAdditionalCodeParameterPair(clsRCorelation, New RParameter("y", 1), iAdditionalPairNo:=4)

        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRCustomSummary, New RParameter("columns_to_summarise", 1), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRFreqTables, New RParameter("x_col_names", 1), iAdditionalPairNo:=3)
        ' ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRCorelation, New RParameter("x", 0), iAdditionalPairNo:=4)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRCustomSummary, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRFreqTables, New RParameter("data_name", 0), iAdditionalPairNo:=3)

        ucrChkOmitMissing.SetRCode(clsRCustomSummary, bReset)
        ucrChkSaveResult.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCustomSummary, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If ((Not ucrReceiverFirstVar.IsEmpty()) AndAlso (Not ucrReceiverSecondVar.IsEmpty())) Then
            If ((strSecondVarType = "numeric" OrElse strSecondVarType = "integer") AndAlso (strVarType = "factor")) AndAlso clsSummariesList.clsParameters.Count = 0 Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDescribeDisplay.SetRFunction(clsRFreqTables, clsRAnova, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Public Sub Results()
        If Not ucrReceiverFirstVar.IsEmpty() Then
            strVarType = ucrReceiverFirstVar.strCurrDataType
        Else
            strVarType = ""
        End If
        If (ucrReceiverSecondVar.GetCurrentItemTypes.Count > 0) Then
            strSecondVarType = ucrReceiverSecondVar.GetCurrentItemTypes.Item(0)
        Else
            strSecondVarType = ""
        End If

        If ((strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            ucrChkSaveResult.Visible = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
            ucrChkOmitMissing.Visible = False

            clsRCorrelation.RemoveParameterByName("data_name")
            ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelation)
            'Temporary Fix- Only one of the receivers gets variables (the last variable of the two)
            'ie, when ucrReceiverFirstVar and ucrReceiverSecondVar are set from SetParameterIsString to SetParameterIsRFunction only the second (ucrReceiverSecondVar) changes to SetParameterIsRFunction the first one remains as SetParameterIsString which is not needed
            clsRCorrelation.AddParameter("x", clsRFunctionParameter:=ucrReceiverSecondVar.GetVariables)
            clsRCorrelation.AddParameter("y", clsRFunctionParameter:=ucrReceiverFirstVar.GetVariables)
            ' ucrReceiverFirstVar.SetParameterIsRFunction()
            ' ucrReceiverSecondVar.SetParameterIsRFunction()
        ElseIf ((strVarType = "numeric" OrElse strVarType = "integer") AndAlso (strSecondVarType = "factor")) Then
            ucrChkSaveResult.Visible = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrChkOmitMissing.Visible = False
            ucrSelectorDescribeTwoVar.SetParameterIsString()
            ucrBase.clsRsyntax.SetBaseRFunction(clsRAnova)
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameterIsString()
        ElseIf ((strVarType = "factor") AndAlso (strSecondVarType = "numeric" OrElse strSecondVarType = "integer")) Then
            ucrChkSaveResult.Visible = True
            cmdSummaries.Visible = True
            cmdDisplayOptions.Visible = False
            ucrChkOmitMissing.Visible = True
            ucrSelectorDescribeTwoVar.SetParameterIsString()
            ucrReceiverFirstVar.SetParameterIsString()
            ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
            ucrReceiverSecondVar.SetParameterIsString()
        ElseIf ((strVarType = "factor") AndAlso (strSecondVarType = "factor")) Then
            ucrChkSaveResult.Visible = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = True
            ucrChkOmitMissing.Visible = False
            ucrSelectorDescribeTwoVar.SetParameterIsString()
            ucrBase.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            ucrReceiverFirstVar.SetParameterIsString()
            ucrReceiverSecondVar.SetParameterIsString()
        Else
            ucrChkSaveResult.Visible = False
            ucrChkOmitMissing.Visible = False
            cmdSummaries.Visible = False
            cmdDisplayOptions.Visible = False
        End If
        SetRCodeForControls(False)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondVar.ControlContentsChanged, ucrReceiverFirstVar.ControlContentsChanged
        Results()
        TestOKEnabled()
    End Sub
End Class