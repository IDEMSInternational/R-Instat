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
Public Class dlgFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    '    Private clsSummaryCount As New RFunction
    Private bResetSubdialog As Boolean = False
    Private lstCheckboxes As New List(Of ucrCheck)
    Private bRCodeSet As Boolean = True

    Private Sub dlgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPercentageType As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 4
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        cmdOptions.Enabled = False ' Temporarily disabled

        ucrSelectorFrequency.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFrequency.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("factors", 3))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorFrequency
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverFactors.SetMeAsReceiver()

        ucrNudColumnFactors.SetParameter(New RParameter("n_column_factors", 4))
        ucrNudColumnFactors.SetRDefault(0)

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 5))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        '8: summary_name = NA

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 9))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        'ucrChkPrintOutput.SetParameter(New RParameter("return_output", 10))
        'ucrChkPrintOutput.SetText("Print to Output Window")
        'ucrChkPrintOutput.SetRDefault("TRUE")

        ' For the page_by option:
        ucrInputPageBy.Enabled = False ' Temporary, not yet implemented in R function
        'ucrInputPageBy.SetParameter(New RParameter("page_by", 12))
        'temp added to prevent developer error while disabled
        ucrInputPageBy.bIsActiveRControl = False
        'dctPageBy.Add("None", "NULL")
        'dctPageBy.Add("Variables", Chr(34) & "variables" & Chr(34))
        'dctPageBy.Add("Summaries", Chr(34) & "summaries" & Chr(34))
        'dctPageBy.Add("Variables and Summaries", "c(" & Chr(34) & "variables" & Chr(34) & "," & Chr(34) & "summaries" & Chr(34) & ")")
        'dctPageBy.Add("Default", Chr(34) & "default" & Chr(34))
        'ucrInputPageBy.SetItems(dctPageBy)
        'ucrInputPageBy.SetRDefault(Chr(34) & "default" & Chr(34))

        ucrChkHTMLTable.SetParameter(New RParameter("as_html", 13))
        ucrChkHTMLTable.SetText("HTML Table")
        ucrChkHTMLTable.SetRDefault("TRUE")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 14))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrInputNA.SetParameter(New RParameter("na_display", 15))
        ucrInputNA.SetRDefault(Chr(34) & Chr(34))

        '16: na_level_display = "NA"

        ucrChkWeights.Enabled = False ' Temporary, parameter position = 17, name = "weights"
        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetRDefault("NULL")
        ucrChkWeights.AddToLinkedControls(ucrReceiverSingle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkRowNumbers.SetParameter(New RParameter("rnames", 18), bNewChangeParameterValue:=True)
        ucrChkRowNumbers.SetText("Show Row Names")
        ucrChkRowNumbers.SetRDefault("TRUE") ' temporary fix, this is not the actual R-default but we need to not run this parameter

        '19: caption = NULL
        '20 result_names = NULL

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 21))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrReceiverMultiplePercentages.SetParameter(New RParameter("perc_total_factors", 23))
        ucrReceiverMultiplePercentages.SetParameterIsString()
        ucrReceiverMultiplePercentages.Selector = ucrSelectorFrequency
        ucrReceiverMultiplePercentages.SetDataType("factor") ' TODO data this accepts must be in the other receiver too
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverMultiplePercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 25))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrSave
        ucrSaveTable.SetPrefix("frequency_table")
        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrSelectorFrequency.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        '        clsSummaryCount = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorFrequency.Reset()
        ucrSaveTable.Reset()

        '        clsSummaryCount.SetRCommand("c")
        '        clsSummaryCount.AddParameter("count_label", "count_label", bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("summaries", "count_label", iPosition:=2) 'clsRFunctionParameter:=clsSummaryCount, iPosition:=2)
        clsDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=5)
        clsDefaultFunction.AddParameter("rnames", "FALSE", iPosition:=18)
        clsDefaultFunction.SetAssignTo("last_table", strTempDataframe:=ucrSelectorFrequency.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'Prevents nud number of columns resetting until controls not synced with R code
        bRCodeSet = False
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        bRCodeSet = True
        '        SetMaxColumnFactors()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso ucrNudColumnFactors.GetText <> "" AndAlso (Not ucrChkWeights.Checked OrElse (ucrChkWeights.Checked AndAlso Not ucrReceiverSingle.IsEmpty)) AndAlso Not ucrReceiverFactors.IsEmpty Then 'AndAlso Not clsSummaryCount.clsParameters.Count = 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'sdgFrequency.SetRFunction(clsSummaryCount, bResetSubdialog)
        'bResetSubdialog = False
        '        sdgFrequency.ShowDialog()
        'TestOKEnabled()
    End Sub

    Private Sub SetMaxColumnFactors()
        ucrNudColumnFactors.Maximum = ucrReceiverFactors.lstSelectedVariables.Items.Count
    End Sub

    Private Sub SettingReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged, ucrChkDisplayAsPercentage.ControlValueChanged, ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverSingle.SetMeAsReceiver()
        ElseIf ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverMultiplePercentages.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged
        If bRCodeSet Then
            SetMaxColumnFactors()
        End If
    End Sub

    Private Sub ucrChkHTMLTable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkHTMLTable.ControlValueChanged
        If ucrChkHTMLTable.Checked Then
            ucrBase.clsRsyntax.iCallType = 4
        Else
            ucrBase.clsRsyntax.iCallType = 2
        End If
    End Sub

    Private Sub ucrChkRowNumbers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRowNumbers.ControlValueChanged
        If Not ucrChkRowNumbers.Checked Then
            clsDefaultFunction.AddParameter("rnames", "FALSE")
        Else
            clsDefaultFunction.RemoveParameterByName("rnames")
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrReceiverSingle.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged, ucrNudColumnFactors.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class