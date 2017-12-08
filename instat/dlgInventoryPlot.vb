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
    Private bResetSubdialog As Boolean = False
    Private clsDefaultRFunction As New RFunction

    Private clsKeyColours As New RFunction
    Private clsListFunc As New RFunction
    Private clsBreaksFunc As New RFunction
    Private clslabelsFunc As New RFunction
    Private clsMissingNonMissing As New RFunction


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

        ucrChkFlipCoordinates.SetParameter(New RParameter("coord_flip", 4))
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlipCoordinates.SetRDefault("FALSE")

        ucrInputTitle.SetParameter(New RParameter("graph_title", 5))
        ucrInputTitle.SetRDefault("Inventory Plot")

        ucrChkShowNonMissing.SetText("Show Non Missing")
        ucrChkShowNonMissing.Enabled = False ' this currently has no parameter associated with it

        ucrPnlPlotType.SetParameter(New RParameter("year_doy_plot"))
        ucrPnlPlotType.AddRadioButton(rdoyear_doy_plot, "TRUE")
        ucrPnlPlotType.AddRadioButton(rdoDatePlot, "FALSE")
        ucrPnlPlotType.SetRDefault("FALSE")

        Dim dctFacetByPairs As New Dictionary(Of String, String)
        ucrInputFacetBy.SetParameter(New RParameter("facet_by"))
        dctFacetByPairs.Add("Default", "NULL")
        dctFacetByPairs.Add("Elements", Chr(34) & "elements" & Chr(34))
        dctFacetByPairs.Add("Stations", Chr(34) & "stations" & Chr(34))
        dctFacetByPairs.Add("Stations-Elements", Chr(34) & "stations-elements" & Chr(34))
        dctFacetByPairs.Add("Elements-Stations", Chr(34) & "elements-stations" & Chr(34))
        ucrInputFacetBy.SetItems(dctFacetByPairs)
        ucrInputFacetBy.SetRDefault("NULL")
        ucrInputFacetBy.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("Inventory")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrInventoryPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction
        clsKeyColours = New RFunction
        clsListFunc = New RFunction
        clsBreaksFunc = New RFunction
        clslabelsFunc = New RFunction
        clsMissingNonMissing = New RFunction

        bResetSubdialog = True
        ucrInventoryPlotSelector.Reset()
        ucrSaveGraph.Reset()
        ucrReceiverDate.SetMeAsReceiver()


        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_inventory_plot")
        clsDefaultRFunction.AddParameter("coord_flip", "FALSE")
        clsDefaultRFunction.AddParameter("year_doy_plot", "FALSE")
        clsDefaultRFunction.AddParameter("facet_by", "NULL")

        clsKeyColours.SetRCommand("c")
        clsKeyColours.AddParameter("missing", Chr(34) & "red" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsKeyColours.AddParameter("nonmissing", Chr(34) & "grey" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsDefaultRFunction.AddParameter("key_colours", clsRFunctionParameter:=clsKeyColours)

        clsBreaksFunc.SetRCommand("c")
        clsListFunc.SetRCommand("list")
        clsBreaksFunc.AddParameter("var1", 0, bIncludeArgumentName:=False, iPosition:=0)
        clsBreaksFunc.AddParameter("threashold", 0.85, bIncludeArgumentName:=False, iPosition:=1)
        clsListFunc.AddParameter("breaks", clsRFunctionParameter:=clsBreaksFunc, iPosition:=0)
        clsDefaultRFunction.AddParameter("rain_cats", clsRFunctionParameter:=clsListFunc)

        clslabelsFunc.SetRCommand("c")
        clslabelsFunc.AddParameter("rain", Chr(34) & "Rain" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clslabelsFunc.AddParameter("dry", Chr(34) & "Dry" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsListFunc.AddParameter("labels ", clsRFunctionParameter:=clslabelsFunc)
        clsDefaultRFunction.AddParameter("rain_cats", clsRFunctionParameter:=clsListFunc)

        clsMissingNonMissing.SetRCommand("c")
        clsMissingNonMissing.AddParameter("var1", Chr(34) & "red" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsMissingNonMissing.AddParameter("var2", Chr(34) & "grey" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsDefaultRFunction.AddParameter("key_colours", clsRFunctionParameter:=clsMissingNonMissing)

        clsDefaultRFunction.SetAssignTo("last_graph", strTempDataframe:=ucrInventoryPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrSaveGraph.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorBoxPlot, bReset:=bResetSubdialog)
        'sdgPlots.ShowDialog()
        'bResetSubdialog = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrInputTitle.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub cmdInventoryPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdInventoryPlotOptions.Click
        sdgInventoryPlot.SetRFunction(clsDefaultRFunction, clsKeyColours, clsBreaksFunc, clslabelsFunc, clsMissingNonMissing, bResetSubdialog)
        bResetSubdialog = False
        sdgInventoryPlot.ShowDialog()
    End Sub
End Class