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
    Private clsSummaryFunction As New RFunction
    Private clsListFunction As New RFunction
    Private Sub dlgCompareSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorVerificationSummary.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVerificationSummary.SetParameterIsString()

        ucrPnlObservationType.SetParameter(New RParameter("obs.type", 1))
        ucrPnlObservationType.AddRadioButton(rdoContinuous, Chr(34) & "'cont'" & Chr(34))
        ucrPnlObservationType.AddRadioButton(rdoCategorical, Chr(34) & "'cat'" & Chr(34))
        ucrPnlObservationType.AddRadioButton(rdoBinary, Chr(34) & "'binary'" & Chr(34))

        ucrReceiverStation.SetParameter(New RParameter("columns_to_summarise", 2))
        ucrReceiverStation.Selector = ucrSelectorVerificationSummary
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverSatellite.SetParameter(New RParameter("pred", 3))
        ucrReceiverSatellite.Selector = ucrSelectorVerificationSummary
        ucrReceiverSatellite.SetParameterIsString()

        ucrReceiverMultipleFactors.SetParameter(New RParameter("factors", 4))
        ucrReceiverMultipleFactors.Selector = ucrSelectorVerificationSummary
        ucrReceiverMultipleFactors.strSelectorHeading = "Factors"
        ucrReceiverMultipleFactors.SetParameterIsString()
        ucrReceiverMultipleFactors.SetIncludedDataTypes({"factor"}, bStrict:=True)
    End Sub

    Private Sub SetDefaults()
        clsSummaryFunction = New RFunction
        clsListFunction = New RFunction
        'data_book$calculate_summary(columns_to_summarise="tmax", data_name="dodoma", factors=c("year"), y="tmin", additional_filter=day_filter, j=1, summaries=c("summary_cor", "summary_count_non_missing", "summary_count", "summary_sum"), silent=TRUE)
        ucrSelectorVerificationSummary.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        clsSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsSummaryFunction.AddParameter("obs.type", Chr(34) & "'cont'" & Chr(34), iPosition:=1)
        clsSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsListFunction, iPosition:=6)

        clsListFunction.SetRCommand("c")

        bResetSubdialog = True
        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgVerificationSummaries.SetRFunction(clsNewListFunction:=clsListFunction, bReset:=bResetSubdialog)
        sdgVerificationSummaries.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverSatellite.IsEmpty OrElse ucrReceiverStation.IsEmpty Then
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
        If rdoContinuous.Checked Then
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'cont'" & Chr(34), iPosition:=5)
        ElseIf rdoBinary.Checked Then
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'binary'" & Chr(34), iPosition:=5)
        ElseIf rdoCategorical.Checked Then
            clsSummaryFunction.AddParameter("frcst.type", Chr(34) & "'cat'" & Chr(34), iPosition:=5)
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverSatellite.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class