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
Public Class dlgInventory
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultRFunction As New RFunction

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrChkSummary.SetParameter(New RParameter("summary", 5))
        ucrChkSummary.SetText("Summary")
        ucrChkSummary.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSummary.SetRDefault("TRUE")

        'ucrInputTitle.SetParameter(New RParameter("graph_title", 5))
        'ucrInputTitle.SetRDefault("Inventory Plot")


        ucrChkDetails.SetParameter(New RParameter("details", 6))
        ucrChkDetails.SetText("Details")
        ucrChkDetails.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDetails.SetRDefault("FALSE")

        ucrChkOmitStart.SetParameter(New RParameter("omit_start", 7))
        ucrChkOmitStart.SetText("Omit Start")
        ucrChkOmitStart.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitStart.SetRDefault("TRUE")

        ucrChkOmitEnd.SetParameter(New RParameter("omit_end", 8))
        ucrChkOmitEnd.SetText("Omit End")
        ucrChkOmitEnd.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitEnd.SetRDefault("FALSE")

        ucrChkYear.SetParameter(New RParameter("year", 11))
        ucrChkYear.SetText("Year")
        ucrChkYear.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkYear.SetRDefault("FALSE")

        ucrChkMonth.SetParameter(New RParameter("month", 12))
        ucrChkMonth.SetText("Month")
        ucrChkMonth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMonth.SetRDefault("FALSE")

        ucrChkDay.SetParameter(New RParameter("day", 13))
        ucrChkDay.SetText("Day")
        ucrChkDay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDay.SetRDefault("FALSE")

        ucrChkHour.SetParameter(New RParameter("hour", 14))
        ucrChkHour.SetText("Hour")
        ucrChkHour.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkHour.SetRDefault("FALSE")

        ucrChkMinute.SetParameter(New RParameter("minute", 15))
        ucrChkMinute.SetText("Minute")
        ucrChkMinute.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMinute.SetRDefault("FALSE")


        ucrChkSecond.SetParameter(New RParameter("second", 16))
        ucrChkSecond.SetText("Second")
        ucrChkSecond.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSecond.SetRDefault("FALSE")

        ucrPnlDateOrderAndElementOrder.SetParameter(New RParameter("date_order"))
        ucrPnlDateOrderAndElementOrder.AddRadioButton(rdoDateOrder, "FALSE")
        ucrPnlDateOrderAndElementOrder.AddRadioButton(rdoElementOrder, "TRUE")
        ucrPnlDateOrderAndElementOrder.SetRDefault("FALSE")

        Dim dctFacetByPairs As New Dictionary(Of String, String)
        ' ucrInputFacetBy.SetParameter(New RParameter("facet_by"))
        dctFacetByPairs.Add("Default", "NULL")
        dctFacetByPairs.Add("Elements", Chr(34) & "elements" & Chr(34))
        dctFacetByPairs.Add("Stations", Chr(34) & "stations" & Chr(34))
        dctFacetByPairs.Add("Stations-Elements", Chr(34) & "stations-elements" & Chr(34))
        dctFacetByPairs.Add("Elements-Stations", Chr(34) & "elements-stations" & Chr(34))

    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrInventoryPlotSelector.Reset()
        ' ucrSaveGraph.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter("coord_flip", "FALSE")
        clsDefaultRFunction.AddParameter("year_doy_plot", "FALSE")
        clsDefaultRFunction.AddParameter("facet_by", "NULL")
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
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
End Class