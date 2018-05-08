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
    Private clsFacetWrapOp As New ROperator
    Private clsFacetGridOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private clsAsFactor As New RFunction

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
        Dim dctFacet As New Dictionary(Of String, String)

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

        ucrReceiverStation.SetParameter(New RParameter("station", 0, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameter(New RParameter("year", 2, False))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("within_variable", 3, False))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetDataType("factor")

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("y", 1))
        ucrReceiverElement.SetParameterIsString()
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

        dctFacet.Add("x", "x")
        dctFacet.Add("Facet 1", Chr(34) & "facet_wrap" & Chr(34))
        dctFacet.Add("Facet 2", Chr(34) & "facet_grid" & Chr(34))
        dctFacet.Add("None", Chr(34) & "none" & Chr(34))

        ucrInputStation.SetParameter(New RParameter("none"))
        ucrInputStation.SetItems(dctFacet)
        ucrInputStation.SetRDefault("none")
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrInputYear.SetParameter(New RParameter("none"))
        ucrInputYear.SetItems(dctFacet)
        ucrInputYear.SetRDefault("none")
        ucrInputYear.SetDropDownStyleAsNonEditable()

        ucrInputWithinYear.SetParameter(New RParameter("x"))
        ucrInputWithinYear.SetItems(dctFacet)
        ucrInputWithinYear.SetRDefault("x")
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
        clsFacetWrapOp = New ROperator
        clsFacetGridOp = New ROperator
        clsAsFactor = New RFunction
        clsAsFactor.SetRCommand("as.factor")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetWrapOp.SetOperation("~")
        clsFacetWrapOp.bForceIncludeOperation = True
        clsFacetGridOp.SetOperation("~")
        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrReceiverStation.SetMeAsReceiver()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.RemoveParameterByName("facets")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

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

        'ucrReceiverFacetBy.AddAdditionalCodeParameterPair(clsFacetWrapOp, New RParameter("var1", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)

        ucrSelectorClimaticBoxPlot.SetRCode(clsRggplotFunction, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVerticalXTickMarkers.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkOmitBelow.SetRCode(clsRgeomPlotFunction, bReset)

        ucrReceiverElement.SetRCode(clsRaesFunction, bReset)
        ucrInputStation.SetRCode(clsRaesFunction, bReset)
        ucrInputYear.SetRCode(clsRaesFunction)
        ucrInputWithinYear.SetRCode(clsRaesFunction, bReset)

        'ucrReceiverXVariable.SetRCode(clsAsFactor, bReset)
        'ucrReceiverFacetBy.SetRCode(clsFacetGridOp, bReset)
        'ucrReceiver2ndFacet.SetRCode(clsFacetGridOp, bReset)
        'ucrChkMargins.SetRCode(clsFacetFunction, bReset)

        bRCodeUpdated = True
        'SecondFacetReceiverEnabled()
        'MarginsEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverElement.IsEmpty AndAlso ucrSavePlot.IsComplete Then
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

    'Private Sub AddRemoveFacets()
    '    If Not ucrReceiverFacetBy.IsEmpty Then
    '        clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=3)
    '    Else
    '        clsBaseOperator.RemoveParameterByName("facets")
    '    End If
    'End Sub

    'Private Sub SetFacets()
    '    If Not ucrReceiverFacetBy.IsEmpty AndAlso ucrReceiver2ndFacet.IsEmpty Then
    '        clsFacetFunction.SetRCommand("facet_wrap")
    '        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetWrapOp, bIncludeArgumentName:=False, iPosition:=0)
    '    ElseIf Not ucrReceiverFacetBy.IsEmpty AndAlso Not ucrReceiver2ndFacet.IsEmpty Then
    '        clsFacetFunction.SetRCommand("facet_grid")
    '        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetGridOp, bIncludeArgumentName:=False, iPosition:=0)
    '    End If
    'End Sub

    'Private Sub SecondFacetReceiverEnabled()
    '    If bRCodeUpdated Then
    '        If ucrReceiverFacetBy.IsEmpty() Then
    '            ucrReceiver2ndFacet.Clear()
    '            ucrReceiver2ndFacet.Enabled = False
    '        Else
    '            ucrReceiver2ndFacet.Enabled = True
    '        End If
    '    End If
    'End Sub

    'Private Sub ucrReceiverXVariable_ControlValueChanged(ucrChangedControl As ucrCore)
    '    If ucrReceiverXVariable.IsEmpty Then
    '        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=1)
    '    Else
    '        clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsAsFactor, iPosition:=1)
    '    End If
    'End Sub

    Private Sub ChangeParameter()
        If Not ucrReceiverStation.IsEmpty Then
            If ucrInputStation.Text = "x" Then
                ucrReceiverStation.SetParameter(New RParameter("x", 0, False))
                ucrInputStation.SetParameter(New RParameter("x"))
            ElseIf ucrInputStation.Text = "Facet 1" Then
                ucrReceiverStation.SetParameter(New RParameter("facet_wrap"))
                ucrInputStation.SetParameter(New RParameter("facet_wrap"))
            ElseIf ucrInputStation.Text = "Facet 2" Then
                ucrReceiverStation.SetParameter(New RParameter("facet_grid"))
                ucrInputStation.SetParameter(New RParameter("facet_grid"))
            End If
        ElseIf Not ucrReceiverYear.IsEmpty Then
            If ucrInputYear.Text = "x" Then
                ucrReceiverYear.SetParameter(New RParameter("x", 0, False))
                ucrInputYear.SetParameter(New RParameter("x"))
            ElseIf ucrInputYear.GetText = "Facet 1" Then
                ucrReceiverYear.SetParameter(New RParameter("facet_wrap"))
                ucrInputYear.SetParameter(New RParameter("facet_wrap"))
            ElseIf ucrInputYear.Text = "Facet 2" Then
                ucrReceiverYear.SetParameter(New RParameter("facet_grid"))
                ucrInputYear.SetParameter(New RParameter("facet_grid"))
            End If
        ElseIf Not ucrReceiverWithinYear.IsEmpty Then
            If ucrInputWithinYear.Text = "x" Then
                ucrReceiverWithinYear.SetParameter(New RParameter("x", 0, False))
                ucrInputWithinYear.SetParameter(New RParameter("x"))
            ElseIf ucrInputWithinYear.Text = "Facet 1" Then
                ucrReceiverWithinYear.SetParameter(New RParameter("facet_wrap"))
                ucrInputWithinYear.SetParameter(New RParameter("facet_wrap"))
            ElseIf ucrInputWithinYear.Text = "Facet 2" Then
                ucrReceiverWithinYear.SetParameter(New RParameter("facet_grid"))
                ucrInputWithinYear.SetParameter(New RParameter("facet_grid"))
            End If
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

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStation.ControlValueChanged, ucrInputYear.ControlValueChanged, ucrInputWithinYear.ControlValueChanged
        '    SecondFacetReceiverEnabled()
        '    SetFacets()
        '    AddRemoveFacets()
        '    MarginsEnabled()
        ChangeParameter()
        CheckComboBox()
    End Sub

    Private Sub ucrSelectorClimaticBoxPlot_DataFrameChanged() Handles ucrSelectorClimaticBoxPlot.DataFrameChanged
        AutoFill()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSavePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub CheckComboBox()
        If Not ucrInputStation.IsEmpty Or Not ucrInputYear.IsEmpty Or Not ucrInputWithinYear.IsEmpty Then
            If ucrInputStation.Text <> "None" Then
                If ucrInputStation.Text = ucrInputYear.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputYear.SetText("None")
                ElseIf ucrInputStation.Text = ucrInputWithinYear.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputWithinYear.SetText("None")
                End If
            End If
            If ucrInputYear.Text <> "None" Then
                If ucrInputYear.Text = ucrInputStation.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputStation.SetText("None")
                ElseIf ucrInputYear.Text = ucrInputWithinYear.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputWithinYear.SetText("None")
                End If
            End If
            If ucrInputWithinYear.Text <> "None" Then
                If ucrInputWithinYear.Text = ucrInputYear.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputStation.SetText("None")
                ElseIf ucrInputWithinYear.Text = ucrInputYear.Text Then
                    MsgBox("You cannot have more than one x variable, Facet 1 or Facet 2 at the same time.", vbOKOnly)
                    ucrInputYear.SetText("None")
                End If
            End If
        End If
    End Sub
End Class