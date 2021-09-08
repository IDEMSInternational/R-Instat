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
    Public strFirstVariablesType, strSecondVariableType As String
    Public clsGetDataType, clsGetSecondDataType, clsRCorrelation, clsRCustomSummary, clsConcFunction, clsRAnova, clsRFreqTables As New RFunction
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

        ucrReceiverFirstVars.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverFirstVars.SetParameterIsString()
        ucrReceiverFirstVars.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)

        ucrReceiverSecondVar.SetParameter(New RParameter("factors", 2))
        ucrReceiverSecondVar.SetParameterIsString()
        ucrReceiverSecondVar.Selector = ucrSelectorDescribeTwoVar

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
        clsConcFunction = New RFunction

        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()

        clsConcFunction.SetRCommand("c")

        clsRFreqTables.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$frequency_tables")
        clsRFreqTables.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRFreqTables.AddParameter("as_html", "FALSE", iPosition:=12)

        clsRAnova.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnova.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnova.AddParameter("means", "FALSE", iPosition:=4)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_missing", Chr(34) & "summary_count_missing" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsSummariesList.AddParameter("summary_min", Chr(34) & "summary_min" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsSummariesList.AddParameter("p25", Chr(34) & "p25" & Chr(34), bIncludeArgumentName:=False, iPosition:=2)
        clsSummariesList.AddParameter("summary_median", Chr(34) & "summary_median" & Chr(34), bIncludeArgumentName:=False, iPosition:=3)
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False, iPosition:=4)
        clsSummariesList.AddParameter("p75", Chr(34) & "p75" & Chr(34), bIncludeArgumentName:=False, iPosition:=5)
        clsSummariesList.AddParameter("summary_max", Chr(34) & "summary_max" & Chr(34), bIncludeArgumentName:=False, iPosition:=6)

        clsRCustomSummary.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsRCustomSummary.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)

        clsRCustomSummary.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRCustomSummary.AddParameter("drop", "TRUE", iPosition:=5)
        clsRCustomSummary.AddParameter("na.rm", "FALSE", iPosition:=6)
        clsRCustomSummary.AddParameter("return_output", "TRUE", iPosition:=7)

        clsRCorrelation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$cor")

        clsRAnova.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")

        ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRFreqTables, New RParameter("y_col_name", 2), iAdditionalPairNo:=2)
        ucrReceiverSecondVar.AddAdditionalCodeParameterPair(clsRCorrelation, New RParameter("y_col_name", 2), iAdditionalPairNo:=3)

        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRAnova, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRFreqTables, New RParameter("x_col_names", 1), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelation, New RParameter("x_col_names", 1), iAdditionalPairNo:=3)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnova, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRCustomSummary, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRFreqTables, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=3)

        ucrChkOmitMissing.SetRCode(clsRCustomSummary, bReset)
        ucrReceiverFirstVars.SetRCode(clsRCustomSummary, bReset)
        ucrReceiverSecondVar.SetRCode(clsRCustomSummary, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelation, bReset)

        Results()
    End Sub

    Public Sub TestOKEnabled()
        If ((Not ucrReceiverSecondVar.IsEmpty()) AndAlso (Not ucrReceiverFirstVars.IsEmpty())) Then
            If ((strFirstVariablesType = "numeric" OrElse strFirstVariablesType = "integer") AndAlso (strSecondVariableType = "factor")) AndAlso clsSummariesList.clsParameters.Count = 0 Then
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
        sdgSummaries.SetRFunction(clsSummariesList, clsRCustomSummary, clsConcFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs)
        sdgDescribeDisplay.SetRFunction(clsRFreqTables, clsRAnova, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Public Sub Results()
        Dim lstFirstItemTypes As List(Of String)

        If Not ucrReceiverFirstVars.IsEmpty() Then
            lstFirstItemTypes = ucrReceiverFirstVars.GetCurrentItemTypes(True, bIsCategoricalNumeric:=True)
            If lstFirstItemTypes.Count = 1 AndAlso lstFirstItemTypes.Contains("logical") Then
                lstFirstItemTypes(0) = "categorical"
            Else
                lstFirstItemTypes.RemoveAll(Function(x) x.Contains("logical"))
            End If
            If (lstFirstItemTypes.Count > 0) Then
                strFirstVariablesType = lstFirstItemTypes(0)
            Else
                strFirstVariablesType = ""
                lblFirstType.Text = "________"
                lblFirstType.ForeColor = SystemColors.ControlText
            End If
            lblFirstType.Text = strFirstVariablesType
            lblFirstType.ForeColor = SystemColors.Highlight
        Else
            strFirstVariablesType = ""
            lblFirstType.Text = "________"
            lblFirstType.ForeColor = SystemColors.ControlText
        End If
        If Not ucrReceiverSecondVar.IsEmpty() Then
            strSecondVariableType = ucrReceiverSecondVar.strCurrDataType
            If strSecondVariableType.Contains("factor") OrElse strSecondVariableType.Contains("character") OrElse strSecondVariableType.Contains("logical") Then
                strSecondVariableType = "categorical"
            Else
                strSecondVariableType = "numeric"
            End If
            lblSecondType.Text = strSecondVariableType
            lblSecondType.ForeColor = SystemColors.Highlight
        Else
            strSecondVariableType = ""
            lblSecondType.Text = "________"
            lblSecondType.ForeColor = SystemColors.ControlText
        End If

        If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = True
            cmdSummaries.Visible = False
            ucrChkOmitMissing.Visible = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelation)
            lblSummaryName.Text = "Correlations"
            lblSummaryName.ForeColor = SystemColors.Highlight
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
            grpOptions.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsRAnova)
            lblSummaryName.Text = "ANOVA tables"
            lblSummaryName.ForeColor = SystemColors.Highlight
        ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = True
            cmdSummaries.Visible = True
            ucrChkOmitMissing.Visible = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsRCustomSummary)
            ucrReceiverFirstVars.SetParameterIsString()
            lblSummaryName.Text = "Numerical summaries"
            lblSummaryName.ForeColor = SystemColors.Highlight
        ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
            grpOptions.Visible = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsRFreqTables)
            lblSummaryName.Text = "Frequency tables"
            lblSummaryName.ForeColor = SystemColors.Highlight
        Else
            grpOptions.Visible = False
            lblSummaryName.Text = "__________"
            lblSummaryName.ForeColor = SystemColors.ControlText
        End If
        autoTranslate(Me)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlContentsChanged, ucrReceiverSecondVar.ControlContentsChanged
        Results()
        TestOKEnabled()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If ucrChkOmitMissing.Checked Then
            clsRCorrelation.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34), iPosition:=2)
        Else
            clsRCorrelation.RemoveParameterByName("use")
        End If
    End Sub
End Class