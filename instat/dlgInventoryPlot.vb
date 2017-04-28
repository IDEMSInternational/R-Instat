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

        ucrChkTitle.AddToLinkedControls(ucrInputTitle, objValues:={True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrReceiverElements.Selector = ucrInventoryPlotSelector
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})
        ucrReceiverElements.SetParameter(New RParameter("elements_col", 2))
        ucrReceiverElements.SetParameterIsString()

        ucrReceiverStation.Selector = ucrInventoryPlotSelector
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.SetParameter(New RParameter("station_col", 3))
        ucrReceiverDate.SetClimaticType("station")
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverDate.Selector = ucrInventoryPlotSelector
        ucrReceiverDate.SetParameter(New RParameter("date_col", 1))
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsString()

        ucrInventoryPlotSelector.SetParameter(New RParameter("data_name", 0))
        ucrInventoryPlotSelector.SetParameterIsString()

        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(New RParameter("coord_flip", 4))
        ucrChkFlipCoordinates.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkTitle.SetText("Title")
        ucrInputTitle.SetParameter(New RParameter("graph_title", 5))

        ucrChkShowNonMissing.SetText("Show Non Missing")
        ucrChkShowNonMissing.SetParameter(New RParameter(""))
        ucrChkShowNonMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSaveGraph.SetPrefix("Inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrSaveGraph.IsComplete) AndAlso (ucrChkTitle.Checked AndAlso Not ucrInputTitle.IsEmpty OrElse ucrChkTitle.Checked = False) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultRFunction As New RFunction
        ucrInventoryPlotSelector.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrChkTitle.Checked = False
        ucrInputTitle.SetName("")

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter("coord_flip", "FALSE")
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

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrChkTitle.ControlContentsChanged, ucrInputTitle.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class