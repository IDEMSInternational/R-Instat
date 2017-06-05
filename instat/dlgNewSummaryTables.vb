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
Public Class dlgNewSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction As New RFunction
    Private lstCheckboxes As New List(Of ucrCheck)

    Private Sub dlgNewSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        Dim dctPageBy As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 4
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrInputPageBy.Enabled = False ' temporarily disabled

        'summary_name = NA - 8

        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverSummaryCols.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSummaryCols.Selector = ucrSelectorSummaryTables
        ucrReceiverSummaryCols.SetDataType("numeric")
        ucrReceiverSummaryCols.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("factors", 3))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorSummaryTables
        ucrReceiverFactors.SetDataType("factor")

        ucrNudColumnFactors.SetParameter(New RParameter("n_column_factors", 4))
        ucrNudColumnFactors.SetRDefault(0)

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 5))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 7))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 9))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrChkSummaries.Enabled = False ' temporary
        ucrChkSummaries.SetParameter(New RParameter("treat_columns_as_factor", 11))
        ucrChkSummaries.SetText("Treat Summary Columns as a Further Factor")
        ucrChkSummaries.SetRDefault("FALSE")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 14))
        ucrNudSigFigs.SetRDefault(2)

        ucrChkHTMLTable.SetParameter(New RParameter("as_html", 13))
        ucrChkHTMLTable.SetText("HTML Table")
        ucrChkHTMLTable.SetRDefault("TRUE")

        ucrReceiverWeights.SetParameter(New RParameter("weights", 16))
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.Selector = ucrSelectorSummaryTables
        ucrReceiverWeights.SetDataType("numeric")

        ucrChkWeight.SetText("Weights")
        ucrChkWeight.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'Not yet implemented
        ucrChkWeight.Enabled = False

        ucrInputNA.SetParameter(New RParameter("na_display", 15))
        ucrInputNA.SetRDefault(Chr(34) & Chr(34))

        ' For the page_by option:
        'temp disabled, not yet implemented in R function
        'ucrInputPageBy.SetParameter(New RParameter("page_by", 12))
        'temp added to prevent developer error while disabled
        ucrInputPageBy.bAllowNonConditionValues = True
        'dctPageBy.Add("None", "NULL")
        'dctPageBy.Add("Variables", Chr(34) & "variables" & Chr(34))
        'dctPageBy.Add("Summaries", Chr(34) & "summaries" & Chr(34))
        'dctPageBy.Add("Variables and Summaries", "c(" & Chr(34) & "variables" & Chr(34) & "," & Chr(34) & "summaries" & Chr(34) & ")")
        'dctPageBy.Add("Default", Chr(34) & "default" & Chr(34))
        'ucrInputPageBy.SetItems(dctPageBy)
        'ucrInputPageBy.SetRDefault(Chr(34) & "default" & Chr(34))

        ucrChkRowNumbers.SetParameter(New RParameter("rnames", 18))
        ucrChkRowNumbers.SetText("Show Row Names")
        ucrChkRowNumbers.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSaveTable.SetPrefix("table")
        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrSelectorSummaryTables.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()
        ucrSaveTable.SetName("summary_table") ' change this to prefix later. currently, if this is prefix then it is blank

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=2)
        clsDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=5)
        clsDefaultFunction.AddParameter("rnames", "FALSE", iPosition:=18)
        clsDefaultFunction.SetAssignTo("last_table", strTempDataframe:=ucrSelectorSummaryTables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso ucrNudColumnFactors.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
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

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub EnableCheckSummaries()
        If ucrReceiverSummaryCols.lstSelectedVariables.Items.Count > 1 OrElse clsSummariesList.clsParameters.Count > 1 Then ' TODO get this to work for clsSummariesList > 1
            '    ucrChkSummaries.Enabled = True ' temporarily disabled while ucrChkSummaries is disabled
            'Else
            ucrChkSummaries.Enabled = False
        End If
    End Sub

    Private Sub PageBy()
        'If ucrChkDisplayMargins.Checked AndAlso (ucrReceiverSummaryCols.lstSelectedVariables.Items.Count > 1 OrElse clsSummariesList.clsParameters.Count > 1) Then ' TODO get this to work for clsSummariesList > 1
        '    clsDefaultFunction.AddParameter("page_by", "c(" & Chr(34) & "variables" & Chr(34) & "," & Chr(34) & "summaries" & Chr(34) & ")", iPosition:=13)
        '    ucrInputPageBy.SetName("Variables and Summaries")
        '    ucrInputPageBy.Enabled = False
        'Else
        '    clsDefaultFunction.AddParameter("page_by", "NULL", iPosition:=13)
        '    ucrInputPageBy.SetName("None")
        '    ucrInputPageBy.Enabled = True
        'End If
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeight.ControlValueChanged
        If ucrChkWeight.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            If ucrReceiverFactors.IsEmpty Then
                ucrReceiverFactors.SetMeAsReceiver()
            ElseIf ucrReceiverSummaryCols.IsEmpty Then
                ucrReceiverSummaryCols.SetMeAsReceiver()
            Else
                ucrReceiverFactors.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrChkDisplayMargins_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayMargins.ControlValueChanged
        PageBy()
    End Sub

    Private Sub ucrReceiverNumeric_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSummaryCols.ControlValueChanged
        EnableCheckSummaries()
        PageBy()
    End Sub

    Private Sub ucrChkHTMLTable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkHTMLTable.ControlValueChanged
        If ucrChkHTMLTable.Checked Then
            ucrBase.clsRsyntax.iCallType = 4
        Else
            ucrBase.clsRsyntax.iCallType = 1
        End If
    End Sub

    Private Sub ucrChkRowNumbers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRowNumbers.ControlValueChanged
        If Not ucrChkRowNumbers.Checked Then
            clsDefaultFunction.AddParameter("rnames", "FALSE")
        Else
            clsDefaultFunction.RemoveParameterByName("rnames")
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged
        ucrNudColumnFactors.Maximum = ucrReceiverFactors.lstSelectedVariables.Items.Count
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged, ucrChkWeight.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged, ucrReceiverSummaryCols.ControlContentsChanged, ucrNudColumnFactors.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class