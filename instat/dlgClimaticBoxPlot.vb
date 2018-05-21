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
Public Class dlgClimaticBoxPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeUpdated As Boolean = False
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOp As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private clsAsFactor As New RFunction

    Private strFacetRow As String = "Facet Row"
    Private strFacetCol As String = "Facet Column"
    Private strXAxis As String = "X Axis"
    Private strColour As String = "Colour Axis"
    Private strNone As String = "None"

    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            AutoFill()
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsThemeFunc As New RFunction
        Dim clsTextElementFunc As New RFunction
        Dim clsThemeParam As New RParameter
        ' Dim dctCombo As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = ""
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplot)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplot, "geom_boxplot")
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls(ucrChkVarWidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls(ucrChkOmitBelow, {rdoJitter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorClimaticBoxPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorClimaticBoxPlot.SetParameterIsrfunction()

        'ucrReceiverStation.SetParameter(New RParameter("station", 0, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bWithQuotes = False
        ucrReceiverYear.strSelectorHeading = "Year Variables"


        ucrReceiverWithinYear.SetParameter(New RParameter("x", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetIncludedDataTypes({"factor"})
        ucrReceiverWithinYear.bAutoFill = True
        ucrReceiverWithinYear.SetValuesToIgnore({Chr(34) & Chr(34)})

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("y", 1))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})
        ucrReceiverElement.bAutoFill = True

        ucrChkOmitBelow.SetParameter(New RParameter("width"))
        ucrChkOmitBelow.SetText("Omit Below")
        ucrChkOmitBelow.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitBelow.SetDefaultState("FALSE")

        ucrNudOmitBelow.SetParameter(New RParameter("width"))
        ucrNudOmitBelow.DecimalPlaces = 2
        ucrNudOmitBelow.Increment = 0.1
        ucrChkOmitBelow.AddToLinkedControls(ucrNudOmitBelow, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)

        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"


        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")

        clsThemeFunc.SetPackageName("ggplot2")
        clsThemeFunc.SetRCommand("theme")
        clsThemeFunc.AddParameter("axis.text.x", clsRFunctionParameter:=clsTextElementFunc)
        clsThemeParam.SetArgument(clsThemeFunc)
        clsThemeParam.SetArgumentName("theme")
        clsTextElementFunc.SetPackageName("ggplot2")
        clsTextElementFunc.SetRCommand("element_text")
        clsTextElementFunc.AddParameter("angle", "90", iPosition:=0)
        ucrChkVerticalXTickMarkers.SetText("Vertical X Tick Markers")
        ucrChkVerticalXTickMarkers.SetParameter(clsThemeParam, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=False)

        'dctCombo.Add(strXAxis, strXAxis)
        'dctCombo.Add(strColour, strColour)
        'dctCombo.Add(strFacetRow, strFacetRow)
        'dctCombo.Add(strFacetCol, strFacetCol)
        'dctCombo.Add(strNone, strNone)

        ucrInputStation.SetItems({strXAxis, strColour, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrInputYear.SetItems({strXAxis, strColour, strFacetRow, strFacetCol, strNone})
        ucrInputYear.SetDropDownStyleAsNonEditable()

        ucrInputWithinYear.SetItems({strXAxis, strColour, strFacetRow, strFacetCol, strNone})
        ucrInputWithinYear.SetDropDownStyleAsNonEditable()

        ucrSavePlot.SetPrefix("boxplot")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsAsFactor = New RFunction
        clsAsFactor.SetRCommand("as.factor")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetColOp.SetOperation("+")
        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        clsFacetFunction.AddParameter("facet", clsROperatorParameter:=clsFacetOp)

        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrReceiverStation.SetMeAsReceiver()

        ucrInputStation.SetText(strNone)
        ucrInputYear.SetText(strNone)
        ucrInputWithinYear.SetText(strXAxis)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2) 'TODO Check this line

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_boxplot")
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE", iPosition:=0)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeUpdated = False
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorClimaticBoxPlot.SetRCode(clsRggplotFunction, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVerticalXTickMarkers.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkOmitBelow.SetRCode(clsRgeomPlotFunction, bReset)

        ucrReceiverElement.SetRCode(clsRaesFunction, bReset)

        bRCodeUpdated = True

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverElement.IsEmpty OrElse ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        AutoFill()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsFacetFunction, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bReset:=bResetSubdialog)
        'this is a temporaly fix because we have facets done on the main dialog
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        If rdoBoxplot.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_boxplot")
            cmdBoxPlotOptions.Text = "Boxplot Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("boxplot")
            End If
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            cmdBoxPlotOptions.Text = "Jitter Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("jitter")
            End If
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            cmdBoxPlotOptions.Text = "Violin Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("violin")
            End If
        End If
        'SetColourFillAes()
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                'ucrReceiverXVariable.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                'ucrReceiverData.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                'ucrReceiverMoreData.Add(clsParam.strArgumentValue)
            End If
        Next
        'TODO need to check for the variable width from the geom function in a way that when we check the var width checkbox, it triggers controlvaluechanged
    End Sub

    Private Sub AutoFill()
        Dim strYearCol As String
        Dim strWithinYearCol As String
        Dim strStationCol As String
        Dim strDataFrame As String
        Dim strDateCol As String
        Dim strRainCol As String

        strDataFrame = ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strDateCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "date_label")
        strYearCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "year_label")
        strWithinYearCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "within_year_label")
        strStationCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "station_label")
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

        If strRainCol <> "" Then
            ucrReceiverElement.Add(strRainCol, strDataFrame)
        End If
        If strStationCol <> "" Then
            ucrReceiverStation.Add(strRainCol, strDataFrame)
        End If
        If strDateCol <> "" Then
            ucrReceiverDate.Add(strRainCol, strDataFrame)
        End If

        If strYearCol <> "" Then
            ucrReceiverYear.Add(strYearCol, strDataFrame)
        End If
        If strWithinYearCol <> "" Then
            ucrReceiverWithinYear.Add(strWithinYearCol, strDataFrame)
        End If
    End Sub

    Private Sub ChangeParameter()
        If ucrInputYear.GetText = strXAxis Then
            ucrReceiverYear.SetParameter(New RParameter("x", 1))
        ElseIf ucrInputWithinYear.GetText = strXAxis Then
            ucrReceiverWithinYear.SetParameter(New RParameter("x", 1))
        End If

    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore)
        SetColourFillAes()
    End Sub

    Private Sub SetColourFillAes()
        If Not ucrReceiverElement.IsEmpty Then
            If rdoJitter.Checked Then
                clsRaesFunction.AddParameter("colour", "variable", iPosition:=2)
                clsRaesFunction.RemoveParameterByName("fill")
            Else
                clsRaesFunction.AddParameter("fill", "variable", , iPosition:=2)
                clsRaesFunction.RemoveParameterByName("colour")
            End If
        Else
            clsRaesFunction.RemoveParameterByName("fill")
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged, ucrInputYear.ControlValueChanged, ucrInputWithinYear.ControlValueChanged
        Dim ucrTempReciever As ucrReceiver
        Dim strTemp As String

        If ucrChangedControl.IsLinkedTo(ucrReceiverStation) Then
            strTemp = "station"
            ucrTempReciever = ucrReceiverStation
        ElseIf ucrChangedControl.IsLinkedTo(ucrReceiverYear) Then
            strTemp = "year"
            ucrTempReciever = ucrReceiverYear
        Else ucrChangedControl.IsLinkedTo(ucrReceiverWithinYear)
            strTemp = "withinyear"
            ucrTempReciever = ucrReceiverWithinYear
        End If

        If ucrChangedControl.GetText = strXAxis Then
            ucrTempReciever.SetParameter(New RParameter("x"))
            ucrTempReciever.SetRCode(clsRaesFunction, bReset)
        ElseIf ucrChangedControl.GetText = strColour Then
            ucrTempReciever.SetParameter(New RParameter("colour"))
            ucrTempReciever.SetRCode(clsRaesFunction, bReset)
        ElseIf ucrChangedControl.GetText = strFacetRow Then
            ucrTempReciever.SetParameter(New RParameter(strTemp))
            ucrTempReciever.SetRCode(clsFacetRowOp, bReset)
        ElseIf ucrChangedControl.GetText = strFacetCol Then
            ucrTempReciever.SetParameter(New RParameter(strTemp))
            ucrTempReciever.SetRCode(clsFacetColOp, bReset)
        Else
            ucrTempReciever.ClearCodeAndParameters()
        End If

        ucrReceiverWithinYear.SetRCode(clsRaesFunction, bReset)
        ucrReceiverYear.SetRCode(clsRaesFunction, bReset)

        ChangeParameter()
    End Sub

    Private Sub ucrSelectorClimaticBoxPlot_DataFrameChanged() Handles ucrSelectorClimaticBoxPlot.DataFrameChanged
        AutoFill()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSavePlot.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class