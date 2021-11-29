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
    Private clsInventoryPlot As RFunction
    Private clsClimaticMissing As RFunction
    Private clsClimaticDetails As RFunction
    Private bResetSubdialog As Boolean = True

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
        Dim dctFacetByPairs As New Dictionary(Of String, String)
        Dim lstCmdControls As New List(Of Control)
        ucrBase.iHelpTopicID = 359

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
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})
        ucrReceiverElements.SetClimaticType("element")
        ucrReceiverElements.bAutoFill = True

        ucrReceiverStation.Selector = ucrInventoryPlotSelector
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameter(New RParameter("station_col", 3))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True
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

        ' ucrChkHour.SetParameter(New RParameter("", ))
        ucrChkHour.SetText("Hour")  ' this currently has no parameter associated with it
        ' ucrChkHour.SetRDefault("FALSE")

        ' ucrChkMinute.SetParameter(New RParameter("", ))
        ucrChkMinute.SetText("Minute")  ' this currently has no parameter associated with it
        ' ucrChkMinute.SetRDefault("FALSE")

        ' ucrChkSecond.SetParameter(New RParameter("", ))
        ucrChkSecond.SetText("Second")  ' this currently has no parameter associated with it
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

        ucrInputFacetBy.SetParameter(New RParameter("facet_by", 8))
        dctFacetByPairs.Add("Default", "NULL")
        dctFacetByPairs.Add("Elements", Chr(34) & "elements" & Chr(34))
        dctFacetByPairs.Add("Stations", Chr(34) & "stations" & Chr(34))
        dctFacetByPairs.Add("Stations-Elements", Chr(34) & "stations-elements" & Chr(34))
        dctFacetByPairs.Add("Elements-Stations", Chr(34) & "elements-stations" & Chr(34))
        ucrInputFacetBy.SetItems(dctFacetByPairs)
        ucrInputFacetBy.SetRDefault("NULL")
        ucrInputFacetBy.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlOptions.AddRadioButton(rdoMissing)
        ucrPnlOptions.AddRadioButton(rdoGraph)
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoMissing, {"climatic_missing", "climatic_details"})
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoGraph, {frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot"})

        ucrPnlOptions.AddToLinkedControls({ucrChkDisplayRainDays, ucrChkFlipCoordinates, ucrChkShowNonMissing, ucrPnlPlotType, ucrSaveGraph, ucrInputTitle, ucrInputFacetBy}, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkSummary, ucrChkDetails}, {rdoMissing}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDetails.AddToLinkedControls({ucrChkDay}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDetails.AddToLinkedControls({ucrPnlOrder}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSummary.AddToLinkedControls({ucrChkOmitStart, ucrChkOmitEnd}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDay.SetLinkedDisplayControl(grpDetailsOptions)
        ucrChkSummary.SetLinkedDisplayControl(grpOptions)
        ucrPnlPlotType.SetLinkedDisplayControl(grpPlotType)
        ucrInputTitle.SetLinkedDisplayControl(lblGraphTitle)
        ucrInputFacetBy.SetLinkedDisplayControl(lblFacetBy)
        lstCmdControls.AddRange({cmdInventoryPlotOptions, cmdOptions})
        ucrChkFlipCoordinates.SetLinkedDisplayControl(lstCmdControls)

    End Sub

    Private Sub SetDefaults()
        clsInventoryPlot = New RFunction
        clsClimaticMissing = New RFunction
        clsClimaticDetails = New RFunction

        ucrInventoryPlotSelector.Reset()
        ucrReceiverElements.SetMeAsReceiver()
        ucrSaveGraph.Reset()
        ucrSaveDetails.Reset()
        bResetSubdialog = True

        clsInventoryPlot.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsInventoryPlot.AddParameter("coord_flip", "FALSE", iPosition:=4)
        clsInventoryPlot.AddParameter("year_doy_plot", "FALSE", iPosition:=6)
        clsInventoryPlot.AddParameter("facet_by", "NULL", iPosition:=8)
        clsInventoryPlot.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsClimaticMissing.SetRCommand("climatic_missing")
        clsClimaticDetails.SetRCommand("climatic_details")
        clsClimaticDetails.SetAssignTo("last_details", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strDataFrameNames:="last_details")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsInventoryPlot, iPosition:=0)
        clsInventoryPlot.iCallType = 3
        clsInventoryPlot.bExcludeAssignedFunctionOutput = False

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInventoryPlotSelector.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("data", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("date", 1), iAdditionalPairNo:=1)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("elements", 2), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsClimaticDetails, New RParameter("station", 3), iAdditionalPairNo:=1)

        ucrInventoryPlotSelector.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("data", 0), iAdditionalPairNo:=2)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("date", 1), iAdditionalPairNo:=2)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("elements", 2), iAdditionalPairNo:=2)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsClimaticMissing, New RParameter("station", 3), iAdditionalPairNo:=2)

        ucrInventoryPlotSelector.SetRCode(clsInventoryPlot, bReset)
        ucrReceiverDate.SetRCode(clsInventoryPlot, bReset)
        ucrReceiverElements.SetRCode(clsInventoryPlot, bReset)
        ucrChkFlipCoordinates.SetRCode(clsInventoryPlot, bReset)
        ucrInputTitle.SetRCode(clsInventoryPlot, bReset)
        ucrChkDisplayRainDays.SetRCode(clsInventoryPlot, bReset)
        ucrChkShowNonMissing.SetRCode(clsInventoryPlot, bReset)
        ucrPnlPlotType.SetRCode(clsInventoryPlot, bReset)
        ucrInputFacetBy.SetRCode(clsInventoryPlot, bReset)
        ucrSaveGraph.SetRCode(clsInventoryPlot, bReset)
        ucrReceiverStation.SetRCode(clsInventoryPlot, bReset)
        ucrChkSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkDetails.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkYear.SetRCode(clsClimaticDetails, bReset)
        ucrChkMonth.SetRCode(clsClimaticDetails, bReset)
        ucrChkDay.SetRCode(clsClimaticDetails, bReset)
        ucrSaveDetails.SetRCode(clsClimaticDetails, bReset)
        ucrChkOmitStart.SetRCode(clsClimaticMissing, bReset)
        ucrChkOmitEnd.SetRCode(clsClimaticMissing, bReset)
        ucrPnlOrder.SetRCode(clsClimaticDetails, bReset)
        ucrPnlOptions.SetRSyntax(ucrBase.clsRsyntax, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If rdoGraph.Checked Then
            If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrSaveGraph.IsComplete) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrChkDetails.Checked AndAlso ucrChkSummary.Checked AndAlso ucrSaveDetails.IsComplete Then
                If ucrChkYear.Checked OrElse ucrChkMonth.Checked OrElse ucrChkDay.Checked OrElse ucrChkHour.Checked OrElse ucrChkMinute.Checked OrElse ucrChkSecond.Checked Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso (ucrChkDetails.Checked AndAlso ucrSaveDetails.IsComplete AndAlso (ucrChkYear.Checked OrElse ucrChkMonth.Checked OrElse ucrChkDay.Checked OrElse ucrChkHour.Checked OrElse ucrChkMinute.Checked OrElse ucrChkSecond.Checked)) Then
                ucrBase.OKEnabled(True)
            ElseIf Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrChkSummary.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrChkSummary.Checked AndAlso ucrChkDetails.Checked AndAlso Not ucrSaveDetails.IsComplete Then
                ucrBase.OKEnabled(False)
            End If
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrChkDetails.Checked AndAlso Not ucrSaveDetails.IsComplete Then
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

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoMissing.Checked Then
            ucrReceiverStation.SetParameterIsRFunction()
            ucrReceiverDate.SetParameterIsRFunction()
            ucrInventoryPlotSelector.SetParameterIsrfunction()
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsInventoryPlot)
        ElseIf rdoGraph.Checked Then
            ucrReceiverStation.SetParameterIsString()
            ucrReceiverDate.SetParameterIsString()
            ucrInventoryPlotSelector.SetParameterIsString()
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsInventoryPlot, iPosition:=0)
            clsInventoryPlot.iCallType = 3
            clsInventoryPlot.bExcludeAssignedFunctionOutput = False
        End If

    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsClimaticMissing, iPosition:=1)
            clsClimaticMissing.iCallType = 2
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticMissing)
        End If

    End Sub

    Private Sub ucrChkDetails_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDetails.ControlValueChanged
        If ucrChkDetails.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsClimaticDetails, iPosition:=2)
            clsClimaticDetails.iCallType = 2
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsClimaticDetails)
        End If

    End Sub

    Private Sub ucrBase_ClickClose(sender As Object, e As EventArgs) Handles ucrBase.ClickClose, Me.Closing
        If rdoMissing.Checked AndAlso Not (ucrChkSummary.Checked OrElse ucrChkDetails.Checked) Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsClimaticMissing, iPosition:=1)
            clsClimaticDetails.iCallType = 2
        End If

    End Sub

    Private Sub cmdInventoryPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdInventoryPlotOptions.Click
        sdgInventoryPlot.SetRCode(clsInventoryNew:=clsInventoryPlot, bReset:=bResetSubdialog)
        sdgInventoryPlot.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrSaveDetails.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrChkSummary.ControlContentsChanged, ucrChkDetails.ControlContentsChanged, ucrChkYear.ControlContentsChanged, ucrChkMonth.ControlContentsChanged, ucrChkDay.ControlContentsChanged, ucrChkHour.ControlContentsChanged, ucrChkMinute.ControlContentsChanged, ucrChkSecond.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOkEnabled()

    End Sub

End Class