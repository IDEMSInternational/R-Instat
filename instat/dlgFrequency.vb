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
    Private clsSummaryCount As New RFunction
    Private bResetSubdialog As Boolean = False
    Private lstCheckboxes As New List(Of ucrCheck)

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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelectorFrequency.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFrequency.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("row_factors", 2)) ' how to move row_factors to column_factors
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorFrequency
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverFactors.SetMeAsReceiver()

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 8))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 9))
        ucrChkPrintOutput.SetText("Print to Output Window")
        ucrChkPrintOutput.SetRDefault("FALSE")

        'ucrChkSummaries.SetParameter(New RParameter("treat_columns_as_factor", 10))
        'ucrChkSummaries.SetText("Treat Summary Columns as a Further Factor")
        'ucrChkSummaries.SetRDefault("FALSE")


        ucrReceiverSingle.SetDataType("numeric")
        ucrSingleReceiver.SetDataType("factor")
        ucrchkWeights.SetText("Weights")
        ucrChkOverallPercentages.SetText("Overall Percentages")
        ucrChkPercentagesOf.SetText("Percentages of")

        ucrchkWeights.AddToLinkedControls(ucrReceiverSingle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkPercentagesOf.AddToLinkedControls(ucrSingleReceiver, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudColumnFactors.SetMinMax(0, frmMain.clsRLink.GetDataFrameLength(ucrSelectorFrequency.ucrAvailableDataFrames.cboAvailableDataFrames.Text))
        ucrNudDecimals.SetMinMax(0, 5)

        'ucrChkCounts:
        ucrChkCounts.SetText("Counts")

        'ucrChkCounts.SetParameter(New RParameter("summary_count", 3), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        'ucrChkCounts.SetText("Counts")

        'lstCheckboxes = New List(Of ucrCheck)
        'lstCheckboxes.AddRange({ucrChkCounts}) ' add in here percentages, etc too?
        'For Each ctrTemp As ucrCheck In lstCheckboxes
        '    ctrTemp.SetParameterValue(Chr(34) & ctrTemp.GetParameter().strArgumentName & Chr(34))
        '    ctrTemp.SetParameterIncludeArgumentName(False)
        'Next
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummaryCount = New RFunction

        ucrSelectorFrequency.Reset()

        ' summary for count
        clsSummaryCount.SetRCommand("c")
        clsSummaryCount.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)


        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummaryCount, iPosition:=2)
        clsDefaultFunction.AddParameter("return_output", "TRUE") ' we don't want it in the data frame?
        clsDefaultFunction.AddParameter("store_results", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True


        'ucrchkCounts.Checked = True
        'ucrChkDisplayMargins.Checked = True
        '' cmdOptions.Enabled = False
        'ucrNudColumnFactors.Value = 1
        'ucrNudDecimals.Value = 0
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrChkCounts.SetRCode(clsSummaryCount, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso (Not ucrchkWeights.Checked OrElse (ucrchkWeights.Checked AndAlso Not ucrSingleReceiver.IsEmpty)) AndAlso (ucrChkCounts.Checked OrElse ucrChkOverallPercentages.Checked OrElse (ucrChkPercentagesOf.Checked AndAlso Not ucrSingleReceiver.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgFrequency.ShowDialog()
    End Sub

    Private Sub UpdateReceiver()
        If ucrchkWeights.Checked Then
            ucrReceiverSingle.SetMeAsReceiver()
        ElseIf ucrChkPercentagesOf.Checked Then
            ucrSingleReceiver.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrchkOverallPercentages_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrchkWeights.ControlValueChanged, ucrChkPercentagesOf.ControlValueChanged
        UpdateReceiver()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingle.ControlContentsChanged, ucrReceiverFactors.ControlContentsChanged, ucrSingleReceiver.ControlContentsChanged, ucrchkWeights.ControlContentsChanged, ucrChkPercentagesOf.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class