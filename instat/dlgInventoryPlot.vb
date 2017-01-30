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
    Private clsDefaultRFunction As New RFunction
    Private Sub dlgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 359
        ucrBase.clsRsyntax.iCallType = 3

        ucrYearReceiver.Selector = ucrInventoryPlotSelector
        ucrColourReceiver.Selector = ucrInventoryPlotSelector
        ucrDayOfYearReceiver.Selector = ucrInventoryPlotSelector
        ucrFacetsReceiver.Selector = ucrInventoryPlotSelector

        ucrYearReceiver.Selector = ucrInventoryPlotSelector
        ucrYearReceiver.SetMeAsReceiver()
        ucrYearReceiver.SetParameter(New RParameter("year"))
        ucrYearReceiver.SetParameterIsString()

        ucrColourReceiver.Selector = ucrInventoryPlotSelector
        ucrColourReceiver.SetIncludedDataTypes({"numeric"})
        ucrColourReceiver.SetParameter(New RParameter("col_name"))
        ucrColourReceiver.SetParameterIsString()

        ucrDayOfYearReceiver.Selector = ucrInventoryPlotSelector
        ucrDayOfYearReceiver.SetIncludedDataTypes({"numeric"})
        ucrDayOfYearReceiver.SetParameter(New RParameter("doy"))
        ucrDayOfYearReceiver.SetParameterIsString()

        ucrFacetsReceiver.Selector = ucrInventoryPlotSelector
        ucrFacetsReceiver.SetParameter(New RParameter("facets"))
        ucrFacetsReceiver.SetParameterIsString()

        ucrInventoryPlotSelector.SetParameter(New RParameter("data_name"))
        ucrInventoryPlotSelector.SetParameterIsString()

        ucrChkAddRecodetoData.SetText("Add Recode to Data")
        ucrChkAddRecodetoData.SetParameter(New RParameter("add_to_data"))
        ucrChkAddRecodetoData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAddRecodetoData.SetDefault("FALSE")

        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(New RParameter("coord_flip"))
        ucrChkFlipCoordinates.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlipCoordinates.SetDefault("FALSE")

        ucrSaveGraph.SetPrefix("Inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrNudThreashold.SetParameter(New RParameter("threshold"))
        ucrNudThreashold.Minimum = 0.85
        ucrNudThreashold.Increment = 0.01
        ucrNudThreashold.DecimalPlaces = 2
        ucrNudThreashold.SetDefault("0.85")

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter(ucrInventoryPlotSelector.GetParameter(), 0)
        clsDefaultRFunction.AddParameter("threshold", "0.85")
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrYearReceiver.IsEmpty AndAlso Not ucrDayOfYearReceiver.IsEmpty AndAlso Not ucrColourReceiver.IsEmpty) AndAlso ucrSaveGraph.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction.Clone())
        ucrInventoryPlotSelector.Reset()
        ucrSaveGraph.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ucrYearReceiver.SetMeAsReceiver()
        TestOkEnabled()
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'there needs to be work on sdgplots before this could be linked 
        'sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        'sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrYearReceiver.ControlContentsChanged, ucrColourReceiver.ControlContentsChanged, ucrDayOfYearReceiver.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class