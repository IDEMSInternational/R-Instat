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
Public Class dlgCompareSummary
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog = False
    Private iTabIndexSelected As Integer = 0
    Private clsSummaryFunction As New RFunction
    Private clsListFunction As New RFunction
    Private Sub dlgCompareSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorVerificationSummary.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVerificationSummary.SetParameterIsString()

        ucrPnlObservationType.SetParameter(New RParameter("obs.type", 1))
        ucrPnlObservationType.AddRadioButton(rdoContinuous, Chr(34) & "'cont'" & Chr(34))
        ucrPnlObservationType.AddRadioButton(rdoCategorical, Chr(34) & "'cat'" & Chr(34))
        ucrPnlObservationType.AddRadioButton(rdoBinary, Chr(34) & "'binary'" & Chr(34))

        ucrReceiverSatellite.SetParameter(New RParameter("columns_to_summarise", 2))
        ucrReceiverSatellite.Selector = ucrSelectorVerificationSummary
        ucrReceiverSatellite.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("y", 3))
        ucrReceiverStation.Selector = ucrSelectorVerificationSummary
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverMultipleFactors.SetParameter(New RParameter("factors", 4))
        ucrReceiverMultipleFactors.Selector = ucrSelectorVerificationSummary
        ucrReceiverMultipleFactors.strSelectorHeading = "Factors"
        ucrReceiverMultipleFactors.SetParameterIsString()
        ucrReceiverMultipleFactors.SetIncludedDataTypes({"factor"}, bStrict:=True)

        ucrChkIgnoreMissing.SetParameter(New RParameter("na.rm", 7))
        ucrChkIgnoreMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIgnoreMissing.SetRDefault("FALSE")
        ucrChkIgnoreMissing.SetText("Omit Missing Values")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 4))
        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 9))
        ucrChkStoreResults.SetText("Store Results")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")
    End Sub

    Private Sub SetDefaults()
        clsSummaryFunction = New RFunction
        clsListFunction = New RFunction

        ucrSelectorVerificationSummary.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        clsSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsSummaryFunction.AddParameter("obs.type", Chr(34) & "'cont'" & Chr(34), iPosition:=1)
        clsSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsListFunction, iPosition:=6)
        clsListFunction.AddParameter("summary_cor", Chr(34) & "summary_cor" & Chr(34), bIncludeArgumentName:=False, iPosition:=20)

        clsListFunction.SetRCommand("c")

        bResetSubdialog = True
        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgVerificationSummaries.SetRFunction(clsNewSummaryFunction:=clsSummaryFunction, clsNewListFunction:=clsListFunction, iNewTabIndexSelected:=iTabIndexSelected, bReset:=bResetSubdialog)
        sdgVerificationSummaries.ShowDialog()
        bResetSubdialog = False
        AddRemoveUseParameter()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverSatellite.IsEmpty OrElse ucrReceiverStation.IsEmpty OrElse clsListFunction.clsParameters.Count = 0 OrElse Not (ucrChkStoreResults.Checked OrElse ucrChkPrintOutput.Checked) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlObservationType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlObservationType.ControlValueChanged
        SetSelectorDataTypes()
        ucrReceiverSatellite.Clear()
        ucrReceiverStation.Clear()
        ucrReceiverStation.SetMeAsReceiver()
        If rdoContinuous.Checked Then
            iTabIndexSelected = 0
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'cont'" & Chr(34), iPosition:=5)
            sdgVerificationSummaries.EnableDisableTabs(True, False, False)
        ElseIf rdoBinary.Checked Then
            iTabIndexSelected = 1
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'binary'" & Chr(34), iPosition:=5)
            sdgVerificationSummaries.EnableDisableTabs(False, True, False)
        ElseIf rdoCategorical.Checked Then
            iTabIndexSelected = 2
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'cat'" & Chr(34), iPosition:=5)
            sdgVerificationSummaries.EnableDisableTabs(False, False, True)
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverSatellite.ControlValueChanged
        SetSelectorDataTypes()
    End Sub

    Private Sub SetSelectorDataTypes()
        If rdoContinuous.Checked Then
            ucrReceiverSatellite.SetIncludedDataTypes({"numeric"}, bStrict:=True)
            ucrReceiverSatellite.strSelectorHeading = "Numerics"
            ucrReceiverStation.SetIncludedDataTypes({"numeric"}, bStrict:=True)
            ucrReceiverStation.strSelectorHeading = "Numerics"
        ElseIf rdoBinary.Checked Then
            ucrReceiverSatellite.SetIncludedDataTypes({"logical", "numeric"}, bStrict:=True)
            ucrReceiverSatellite.strSelectorHeading = "Logical and Numerics"
            ucrReceiverStation.SetIncludedDataTypes({"logical", "numeric"}, bStrict:=True)
            ucrReceiverStation.strSelectorHeading = "Logical and Numeric"
        ElseIf rdoCategorical.Checked Then
            ucrReceiverSatellite.SetIncludedDataTypes({"logical", "factor"}, bStrict:=True)
            ucrReceiverSatellite.strSelectorHeading = "Logical and Factors"
            ucrReceiverStation.SetIncludedDataTypes({"logical", "factor"}, bStrict:=True)
            ucrReceiverStation.strSelectorHeading = "Logical and Factors"
        End If
    End Sub

    Private Sub ucrChkPrintOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintOutput.ControlValueChanged
        ucrBase.clsRsyntax.iCallType = If(ucrChkPrintOutput.Checked, 2, 0)
    End Sub

    Private Sub AddRemoveUseParameter()
        If ucrChkIgnoreMissing.Checked AndAlso clsListFunction.ContainsParameter("summary_cor") Then
            clsSummaryFunction.AddParameter("use", Chr(34) & "'complete.obs'" & Chr(34), iPosition:=8)
        Else
            clsSummaryFunction.RemoveParameterByName("use")
        End If
    End Sub

    Private Sub ucrChkIgnoreMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIgnoreMissing.ControlValueChanged
        AddRemoveUseParameter()
    End Sub

    Private Sub ucrReceiverStation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverSatellite.ControlContentsChanged, ucrChkPrintOutput.ControlContentsChanged, ucrChkStoreResults.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class