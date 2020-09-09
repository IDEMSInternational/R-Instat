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
Public Class dlgInventoryPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultRFunction As New RFunction
    Private clsClimaticSummary As New RFunction

    Private iPnlSummaryY As Integer
    Private iPnlDetailsY As Integer

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iPnlSummaryY = pnlSummary.Location.Y
            iPnlDetailsY = pnlDetails.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 359
        ucrBase.clsRsyntax.iCallType = 3
        ucrInventoryPlotSelector.SetParameter(New RParameter("data_name", 0))
        ucrInventoryPlotSelector.SetParameterIsString()

        ucrReceiverDate.SetParameter(New RParameter("date_col", 1))
        ucrReceiverDate.Selector = ucrInventoryPlotSelector
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.strSelectorHeading = "Date"

        ucrReceiverElements.SetParameter(New RParameter("element_cols", 2))
        ucrReceiverElements.Selector = ucrInventoryPlotSelector
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.strSelectorHeading = "Numerics"

        ucrReceiverStation.SetParameter(New RParameter("station_col", 3))
        ucrReceiverStation.Selector = ucrInventoryPlotSelector
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrChkSummary.SetParameter(New RParameter("summary", 4))
        ucrChkSummary.SetText("Summary")
        ucrChkSummary.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSummary.SetRDefault("TRUE")

        ucrChkDetails.SetParameter(New RParameter("details", 5))
        ucrChkDetails.SetText("Details")
        ucrChkDetails.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDetails.SetRDefault("FALSE")

        ucrChkOmitStart.SetParameter(New RParameter("start", 10))
        ucrChkOmitStart.SetText("Omit Start")
        ucrChkOmitStart.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitStart.SetRDefault("TRUE")

        ucrChkOmitEnd.SetParameter(New RParameter("end", 11))
        ucrChkOmitEnd.SetText("Omit End")
        ucrChkOmitEnd.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitEnd.SetRDefault("FALSE")

        ucrChkYear.SetParameter(New RParameter("year", 9))
        ucrChkYear.SetText("Year")
        ucrChkYear.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkYear.SetRDefault("FALSE")

        ucrChkMonth.SetParameter(New RParameter("month", 8))
        ucrChkMonth.SetText("Month")
        ucrChkMonth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMonth.SetRDefault("FALSE")

        ucrChkDay.SetParameter(New RParameter("day", 7))
        ucrChkDay.SetText("Day")
        ucrChkDay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDay.SetRDefault("TRUE")

        ' ucrChkHour.SetParameter(New RParameter("", 13))
        ucrChkSaveDetails.SetText("Save Details")
        ' ucrChkHour.SetRDefault("FALSE")

        ' ucrChkHour.SetParameter(New RParameter("", 13))
        ucrChkHour.SetText("Hour")
        ' ucrChkHour.SetRDefault("FALSE")

        ' ucrChkMinute.SetParameter(New RParameter("", 13))
        ucrChkMinute.SetText("Minute")
        ' ucrChkMinute.SetRDefault("FALSE")

        ' ucrChkSecond.SetParameter(New RParameter("", 13))
        ucrChkSecond.SetText("Second")
        ' ucrChkSecond.SetRDefault("FALSE")

        ucrPnlOrder.SetParameter(New RParameter("order", 6))
        ucrPnlOrder.AddRadioButton(rdoDateOrder, "TRUE")
        ucrPnlOrder.AddRadioButton(rdoElementOrder, "FALSE")
        ucrPnlOrder.SetRDefault("FALSE")

        ucrPnls.AddRadioButton(rdoMissing)
        ucrPnls.AddRadioButton(rdoGraph)
        ucrPnls.AddFunctionNamesCondition(rdoMissing, "climatic_missing")
        ucrPnls.AddFunctionNamesCondition(rdoGraph, frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        ucrPnls.AddToLinkedControls(ucrChkSummary, {rdoMissing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnls.AddToLinkedControls(ucrChkDetails, {rdoMissing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDetails.AddToLinkedControls({ucrChkDay}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDay.SetLinkedDisplayControl(pnlDetails)
        ucrChkSummary.SetLinkedDisplayControl(pnlSummary)


        Dim dctFacetByPairs As New Dictionary(Of String, String)

        dctFacetByPairs.Add("Default", "NULL")
        dctFacetByPairs.Add("Elements", Chr(34) & "elements" & Chr(34))
        dctFacetByPairs.Add("Stations", Chr(34) & "stations" & Chr(34))
        dctFacetByPairs.Add("Stations-Elements", Chr(34) & "stations-elements" & Chr(34))
        dctFacetByPairs.Add("Elements-Stations", Chr(34) & "elements-stations" & Chr(34))



    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsClimaticSummary = New RFunction

        ucrInventoryPlotSelector.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter("coord_flip", "FALSE")
        clsDefaultRFunction.AddParameter("year_doy_plot", "FALSE")
        clsDefaultRFunction.AddParameter("facet_by", "NULL")
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        clsClimaticSummary.SetRCommand("climatic_missing")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInventoryPlotSelector.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverDate.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverStation.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverElements.SetRCode(clsDefaultRFunction, bReset)
        ucrChkSummary.SetRCode(clsClimaticSummary, bReset)
        ucrChkDetails.SetRCode(clsClimaticSummary, bReset)
        ucrChkYear.SetRCode(clsClimaticSummary, bReset)
        ucrChkMonth.SetRCode(clsClimaticSummary, bReset)
        ucrChkDay.SetRCode(clsClimaticSummary, bReset)
        ucrChkOmitEnd.SetRCode(clsClimaticSummary, bReset)
        ucrChkOmitStart.SetRCode(clsClimaticSummary, bReset)
        ucrPnlOrder.SetRCode(clsClimaticSummary, bReset)
        ucrPnls.SetRCode(clsDefaultRFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs)
        'there needs to be work on sdgplots before this could be linked 
        'sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        'sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInventoryPlotSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInventoryPlotSelector.ControlValueChanged
        clsClimaticSummary.AddParameter("data", clsRFunctionParameter:=ucrInventoryPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        clsClimaticSummary.AddParameter("date", clsRFunctionParameter:=ucrReceiverDate.GetVariables, iPosition:=1)
    End Sub

    Private Sub ucrReceiverElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlValueChanged
        clsClimaticSummary.AddParameter("elements", ucrReceiverElements.GetVariableNames(bWithQuotes:=False), iPosition:=2)
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        clsClimaticSummary.AddParameter("stations", clsRFunctionParameter:=ucrReceiverStation.GetVariables, iPosition:=3)
    End Sub

    Private Sub ucrPnls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnls.ControlValueChanged
        If rdoMissing.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsClimaticSummary)
            ucrBase.clsRsyntax.iCallType = 2
            pnlSummary.Location = New Point(pnlSummary.Location.X, iPnlSummaryY / 1.12)
            pnlDetails.Location = New Point(pnlDetails.Location.X, iPnlDetailsY / 1.09)
            cmdInventoryPlotOptions.Visible = False
            cmdOptions.Visible = False
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
            ucrBase.clsRsyntax.iCallType = 3
            cmdInventoryPlotOptions.Visible = True
            cmdOptions.Visible = True
        End If
    End Sub
End Class