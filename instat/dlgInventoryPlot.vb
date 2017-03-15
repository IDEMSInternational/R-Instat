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
Public Class dlgInventoryPlot

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

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

        ucrpnlOptions.AddRadioButton(rdoSingleStationSingleElement)
        ucrpnlOptions.AddRadioButton(rdoSingleStationMultipleElments)
        ucrpnlOptions.AddRadioButton(rdoMultipleStationsSingleElement)
        ucrpnlOptions.AddRadioButton(rdoMultipleStationsMultipleElements)
        ucrpnlOptions.bAllowNonConditionValues = True


        'first option- single station single element
        ucrpnlOptions.AddToLinkedControls(ucrReceiverElement, {rdoSingleStationSingleElement}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)

        '2nd option- single station multiple elements
        ucrpnlOptions.AddToLinkedControls(ucrReceiverElements, {rdoSingleStationMultipleElments}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverElements.SetLinkedDisplayControl(lblElement)

        '3rd option- multiple stations single element
        ucrpnlOptions.AddToLinkedControls(ucrReceiverStation, {rdoMultipleStationsSingleElement}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        '4rd option- multiple stations multiple element
        ucrpnlOptions.AddToLinkedControls({ucrReceiverStation}, {rdoMultipleStationsMultipleElements}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrpnlOptions.AddToLinkedControls(ucrReceiverElements, {rdoMultipleStationsMultipleElements}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverElements.SetLinkedDisplayControl(lblElement)

        ucrChkTitle.AddToLinkedControls(ucrInputTitle, objValues:={True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrReceiverElement.Selector = ucrInventoryPlotSelector
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})
        ucrReceiverElement.SetParameter(New RParameter("elements_col"))
        ucrReceiverElement.SetParameterIsString()

        ucrReceiverElements.Selector = ucrInventoryPlotSelector
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})
        ucrReceiverElements.SetParameter(New RParameter("elements_col"))
        ucrReceiverElements.SetParameterIsString()

        ucrReceiverStation.Selector = ucrInventoryPlotSelector
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.SetParameter(New RParameter("station_col"))
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverDate.Selector = ucrInventoryPlotSelector
        ucrReceiverDate.SetIncludedDataTypes({""})
        ucrReceiverDate.SetParameter(New RParameter("date_col"))
        ucrReceiverDate.SetParameterIsString()

        ucrInventoryPlotSelector.SetParameter(New RParameter("data_name", 0))
        ucrInventoryPlotSelector.SetParameterIsString()

        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkShowNonMissing.SetParameter(New RParameter("coord_flip"))
        ucrChkTitle.SetText("Title")

        ucrChkShowNonMissing.SetText("Show Non Missing")
        ucrChkShowNonMissing.SetParameter(New RParameter(""))

        ucrSaveGraph.SetPrefix("Inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub TestOkEnabled()
        'If (Not ucrYearReceiver.IsEmpty AndAlso Not ucrDayOfYearReceiver.IsEmpty AndAlso Not ucrColourReceiver.IsEmpty) AndAlso ucrSaveGraph.IsComplete() Then
        '    ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultRFunction As New RFunction
        ucrInventoryPlotSelector.Reset()
        ucrSaveGraph.Reset()
        rdoSingleStationSingleElement.Checked = True

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverElement_VisibleChanged(sender As Object, e As EventArgs) Handles ucrReceiverElement.VisibleChanged, ucrReceiverElements.VisibleChanged
        If ucrReceiverElement.Visible Then
            lblElement.Text = "Element:"
        ElseIf ucrReceiverElements.Visible Then
            lblElement.Text = "Elements:"
        End If
    End Sub
End Class