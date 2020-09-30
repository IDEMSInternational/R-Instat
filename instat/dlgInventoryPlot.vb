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
    Private clsClimaticMissing As New RFunction
    Private clsClimaticDetails As New RFunction
    Private clsCurrInvFunction As New RFunction

    Private iPnlSummaryY As Integer
    Private iPnlDetailsY As Integer

    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iPnlSummaryY = grpOptions.Location.Y
            iPnlDetailsY = grpDetailsOptions.Location.Y
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
        'ucrReceiverDate.bWithQuotes = False
        ucrReceiverDate.strSelectorHeading = "Date"

        ucrReceiverElements.SetParameter(New RParameter("element_cols", 2))
        ucrReceiverElements.Selector = ucrInventoryPlotSelector
        ucrReceiverElements.SetParameterIsString()
        ' ucrReceiverElements.bWithQuotes = False
        ucrReceiverElements.strSelectorHeading = "Numerics"

        ucrReceiverStation.SetParameter(New RParameter("station_col", 3))
        ucrReceiverStation.Selector = ucrInventoryPlotSelector
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrChkSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"climatic_missing"})
        ucrChkSummary.SetText("Summary")

        ucrChkDetails.AddRSyntaxContainsFunctionNamesCondition(True, {"climatic_details"})
        ucrChkDetails.SetText("Details")

        ucrChkOmitStart.SetParameter(New RParameter("start", 4))
        ucrChkOmitStart.SetText("Omit Start")
        ucrChkOmitStart.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitStart.SetRDefault("TRUE")

        ucrChkOmitEnd.SetParameter(New RParameter("end", 5))
        ucrChkOmitEnd.SetText("Omit End")
        ucrChkOmitEnd.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitEnd.SetRDefault("FALSE")

        ucrChkYear.SetParameter(New RParameter("year", 7))
        ucrChkYear.SetText("Year")
        ucrChkYear.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkYear.SetRDefault("FALSE")

        ucrChkMonth.SetParameter(New RParameter("month", 6))
        ucrChkMonth.SetText("Month")
        ucrChkMonth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMonth.SetRDefault("FALSE")

        ucrChkDay.SetParameter(New RParameter("day", 5))
        ucrChkDay.SetText("Day")
        ucrChkDay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDay.SetRDefault("TRUE")

        ucrSaveDetails.SetPrefix("climatic_details")
        ucrSaveDetails.SetCheckBoxText("Save Details")
        ucrSaveDetails.SetSaveTypeAsDataFrame()
        ucrSaveDetails.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveDetails.SetIsComboBox()
        ' ucrSaveDetails.SetAssignToIfUncheckedValue("last_details")

        ' ucrChkHour.SetParameter(New RParameter("", 13))
        ucrChkHour.SetText("Hour")
        ' ucrChkHour.SetRDefault("FALSE")

        ' ucrChkMinute.SetParameter(New RParameter("", 13))
        ucrChkMinute.SetText("Minute")
        ' ucrChkMinute.SetRDefault("FALSE")

        ' ucrChkSecond.SetParameter(New RParameter("", 13))
        ucrChkSecond.SetText("Second")
        ' ucrChkSecond.SetRDefault("FALSE")

        ucrPnlOrder.SetParameter(New RParameter("order", 4))
        ucrPnlOrder.AddRadioButton(rdoDateOrder, "TRUE")
        ucrPnlOrder.AddRadioButton(rdoElementOrder, "FALSE")
        ucrPnlOrder.SetRDefault("FALSE")

        ucrChkFlipCoordinates.SetParameter(New RParameter("coord_flip", 4))
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlipCoordinates.SetRDefault("FALSE")

        ucrInputTitle.SetParameter(New RParameter("graph_title", 9))
        ucrInputTitle.SetRDefault("Inventory Plot")

        ucrChkDisplayRainDays.SetParameter(New RParameter("display_rain_days", 11), bNewChangeParameterValue:=True)
        ucrChkDisplayRainDays.SetText("Display Rain Days")
        ucrChkDisplayRainDays.SetRDefault("FALSE")

        ucrChkShowNonMissing.SetText("Show Non Missing")
        ucrChkShowNonMissing.Enabled = False ' this currently has no parameter associated with it

        ucrPnlPlotType.SetParameter(New RParameter("year_doy_plot", 6))
        ucrPnlPlotType.AddRadioButton(rdoyear_doy_plot, "TRUE")
        ucrPnlPlotType.AddRadioButton(rdoDatePlot, "FALSE")
        ucrPnlPlotType.SetRDefault("FALSE")

        ucrSaveGraph.SetPrefix("Inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlOptions.AddRadioButton(rdoMissing)
        ucrPnlOptions.AddRadioButton(rdoGraph)
        ucrPnlOptions.AddFunctionNamesCondition(rdoMissing, {"climatic_missing", "climatic_details"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoGraph, frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        ucrPnlOptions.AddToLinkedControls({ucrChkDisplayRainDays, ucrChkFlipCoordinates, ucrChkShowNonMissing, ucrPnlPlotType, ucrSaveGraph, ucrInputTitle, ucrInputFacetBy}, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkSummary, ucrChkDetails}, {rdoMissing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDetails.AddToLinkedControls({ucrChkDay}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDetails.AddToLinkedControls({ucrPnlOrder}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSummary.AddToLinkedControls({ucrChkOmitStart, ucrChkOmitEnd}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDay.SetLinkedDisplayControl(grpDetailsOptions)
        ucrChkSummary.SetLinkedDisplayControl(ucrPnlOrder)
        ucrChkSummary.SetLinkedDisplayControl(grpOptions)
        ucrPnlOrder.SetLinkedDisplayControl(rdoDateOrder)
        ucrPnlOrder.SetLinkedDisplayControl(rdoElementOrder)
        ucrPnlPlotType.SetLinkedDisplayControl(grpPlotType)
        ucrInputTitle.SetLinkedDisplayControl(lblGraphTitle)
        ucrInputFacetBy.SetLinkedDisplayControl(lblFacetBy)

        Dim dctFacetByPairs As New Dictionary(Of String, String)
        ucrInputFacetBy.SetParameter(New RParameter("facet_by", 8))
        dctFacetByPairs.Add("Default", "NULL")
        dctFacetByPairs.Add("Elements", Chr(34) & "elements" & Chr(34))
        dctFacetByPairs.Add("Stations", Chr(34) & "stations" & Chr(34))
        dctFacetByPairs.Add("Stations-Elements", Chr(34) & "stations-elements" & Chr(34))
        dctFacetByPairs.Add("Elements-Stations", Chr(34) & "elements-stations" & Chr(34))
        ucrInputFacetBy.SetItems(dctFacetByPairs)
        ucrInputFacetBy.SetRDefault("NULL")
        ucrInputFacetBy.SetDropDownStyleAsNonEditable()



    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsClimaticMissing = New RFunction
        clsClimaticDetails = New RFunction

        ucrInventoryPlotSelector.Reset()
        ucrReceiverElements.SetMeAsReceiver()
        ucrSaveGraph.Reset()
        ucrSaveDetails.Reset()

        clsCurrInvFunction = clsDefaultRFunction

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter("coord_flip", "FALSE")
        clsDefaultRFunction.AddParameter("year_doy_plot", "FALSE")
        clsDefaultRFunction.AddParameter("facet_by", "NULL")
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ' clsClimaticDetails.SetAssignTo("last_details", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "last_details")
        clsClimaticMissing.SetRCommand("climatic_missing")
        clsClimaticDetails.SetRCommand("climatic_details")
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultRFunction, iPosition:=0)
        'ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInventoryPlotSelector.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("data", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("date", 1), iAdditionalPairNo:=1)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("elements", 2), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("stations", 3), iAdditionalPairNo:=1)

        ucrInventoryPlotSelector.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("data", 0), iAdditionalPairNo:=2)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("date", 1), iAdditionalPairNo:=2)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("elements", 2), iAdditionalPairNo:=2)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("stations", 3), iAdditionalPairNo:=2)

        ucrInventoryPlotSelector.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverDate.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverStation.SetRCode(clsDefaultRFunction, bReset)
        ucrReceiverElements.SetRCode(clsDefaultRFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsDefaultRFunction, bReset)
        ucrInputTitle.SetRCode(clsDefaultRFunction, bReset)
        ucrChkDisplayRainDays.SetRCode(clsDefaultRFunction, bReset)
        ucrChkShowNonMissing.SetRCode(clsDefaultRFunction, bReset)
        ucrPnlPlotType.SetRCode(clsDefaultRFunction, bReset)
        ucrInputFacetBy.SetRCode(clsDefaultRFunction, bReset)
        ucrSaveGraph.SetRCode(clsDefaultRFunction, bReset)
        ucrChkSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkDetails.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkYear.SetRCode(clsClimaticDetails, bReset)
        ucrChkMonth.SetRCode(clsClimaticDetails, bReset)
        ucrChkDay.SetRCode(clsClimaticDetails, bReset)
        ucrSaveDetails.SetRCode(clsClimaticDetails, bReset)
        ucrChkOmitStart.SetRCode(clsClimaticMissing, bReset)
        ucrChkOmitEnd.SetRCode(clsClimaticMissing, bReset)
        ucrPnlOrder.SetRCode(clsClimaticDetails, bReset)
        ucrPnlOptions.SetRCode(clsCurrInvFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoGraph.Checked Then
            If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrSaveGraph.IsComplete) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso (ucrChkSummary.Checked OrElse (ucrChkDetails.Checked AndAlso ucrSaveDetails.IsComplete AndAlso (ucrChkYear.Checked OrElse ucrChkMonth.Checked OrElse ucrChkDay.Checked OrElse ucrChkHour.Checked OrElse ucrChkMinute.Checked OrElse ucrChkSecond.Checked)))) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
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

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrChkSummary.ControlValueChanged, ucrChkDetails.ControlValueChanged, ucrChkYear.ControlValueChanged, ucrChkMonth.ControlValueChanged, ucrChkDay.ControlValueChanged, ucrChkHour.ControlValueChanged, ucrChkMinute.ControlValueChanged, ucrChkSecond.ControlValueChanged
        TestOkEnabled()
    End Sub
    Private Sub ChangeFunction()
        If ucrChkSummary.Checked Then
            clsCurrInvFunction = clsClimaticMissing
        ElseIf ucrChkDetails.Checked Then
            clsCurrInvFunction = clsClimaticDetails
        End If
    End Sub

    Private Sub ucrPnls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoMissing.Checked Then
            ' ucrBase.clsRsyntax.SetBaseRFunction(clsClimaticMissing)
            ucrBase.clsRsyntax.iCallType = 2
            grpOptions.Location = New Point(grpOptions.Location.X, iPnlSummaryY / 1.05)
            grpDetailsOptions.Location = New Point(grpDetailsOptions.Location.X, iPnlDetailsY / 1.04)
            cmdInventoryPlotOptions.Visible = False
            cmdOptions.Visible = False
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsDefaultRFunction)
            ' ChangeFunction()
        ElseIf rdoGraph.Checked Then
            ' ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
            clsDefaultRFunction.bExcludeAssignedFunctionOutput = False
            ucrBase.clsRsyntax.iCallType = 3
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultRFunction, iPosition:=0)
            cmdInventoryPlotOptions.Visible = True
            cmdOptions.Visible = True
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticMissing)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticDetails)
        End If
    End Sub

    Private Sub ucrPnls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlContentsChanged
        If rdoGraph.Checked Then
            ucrReceiverDate.SetParameterIsString()
            ucrInventoryPlotSelector.SetParameterIsString()
            ucrReceiverStation.SetParameterIsString()
            ucrReceiverStation.bWithQuotes = True
        Else
            ucrReceiverDate.SetParameterIsRFunction()
            ucrReceiverStation.SetParameterIsString()
            ucrReceiverStation.bWithQuotes = False
            ucrInventoryPlotSelector.SetParameterIsrfunction()
        End If
    End Sub

    Private Sub ucrChkDetails_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDetails.ControlValueChanged
        If ucrChkDetails.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsClimaticDetails, iPosition:=1)
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticDetails)
        End If
    End Sub
    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsClimaticMissing, iPosition:=2)
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticMissing)
        End If
    End Sub
End Class