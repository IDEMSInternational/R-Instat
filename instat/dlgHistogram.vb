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

Imports instat
Imports instat.Translations
Public Class dlgHistogram
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Private clsYlabScalesFunction As New RFunction
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsHistAesFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetHistLayerSubdialog As Boolean = True
    Private clsPercentage As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsForecatsReverse As New RFunction
    Private clsForecatsInfreqValue As New RFunction
    Private clsForecatsReverseValue As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strGeomParameterNames() As String = {strFirstParameterName}

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
        DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctStats As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 435

        ucrPnlOptions.AddRadioButton(rdoHistogram)
        ucrPnlOptions.AddRadioButton(rdoDensity_ridges)
        ucrPnlOptions.AddRadioButton(rdoFrequencyPolygon)

        ucrPnlOptions.AddFunctionNamesCondition(rdoHistogram, {"geom_histogram", "geom_dotplot"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoDensity_ridges, {"geom_density", "geom_density_ridges"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequencyPolygon, "geom_freqpoly")

        ucrHistogramSelector.SetParameter(New RParameter("data", 0))
        ucrHistogramSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("fill", 1))
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        'can put in colour for density and polygon but fill for Histogram
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrInputStats.SetParameter(New RParameter("y", 0))
        dctStats.Add("Counts", "stat(count)")
        dctStats.Add("Fractions", "stat(count/sum(count))")
        dctStats.Add("Scaled Fractions", "stat(count/max(count))")
        ucrInputStats.SetDropDownStyleAsNonEditable()
        ucrInputStats.SetItems(dctStats)
        ucrInputStats.SetLinkedDisplayControl(lblStats)
        ucrInputStats.AddToLinkedControls(ucrChkPercentages, {"Fractions"}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPercentages.SetText("percentages")
        ucrChkPercentages.AddParameterPresentCondition(True, "scale")
        ucrChkPercentages.AddParameterPresentCondition(False, "scale", False)

        ucrChkDisplayAsDotPlot.SetText("Display as Dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(True, "geom_dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(False, "geom_dotplot", False)
        ucrChkDisplayAsDotPlot.AddToLinkedControls({ucrChkOmitYAxis}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkOmitYAxis.SetText("Omit Y Axis")

        ucrChkBinWidth.SetText("Binwidth")
        ucrChkBinWidth.AddToLinkedControls({ucrNudBinwidth}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudBinwidth.SetParameter(New RParameter("binwidth", 3))
        ucrNudBinwidth.SetMinMax(0.00, 10.0)
        ucrNudBinwidth.DecimalPlaces = 2
        ucrNudBinwidth.Increment = 0.01
        ucrNudBinwidth.SetRDefault(1.5)


        ucrChkRidges.SetText("Density Ridges")
        ucrChkRidges.AddFunctionNamesCondition(True, "geom_density_ridges")
        ucrChkRidges.AddFunctionNamesCondition(False, "geom_density_ridges", False)
        ucrChkRidges.AddToLinkedControls({ucrChkMinHeight}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkMinHeight.SetText("Min Height")
        ucrChkMinHeight.AddToLinkedControls({ucrNudMinHeight}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudMinHeight.SetParameter(New RParameter("rel_min_height", 4))
        ucrNudMinHeight.SetMinMax(0.00, 10.0)
        ucrNudMinHeight.DecimalPlaces = 3
        ucrNudMinHeight.Increment = 0.01
        ucrNudMinHeight.SetRDefault(0.01)

        ucrVariablesAsFactorforHist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforHist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforHist.Selector = ucrHistogramSelector
        ucrVariablesAsFactorforHist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforHist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforHist.bWithQuotes = False
        ucrVariablesAsFactorforHist.SetParameterIsString()

        ucrInputAddReorder.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputAddReorder.SetDropDownStyleAsNonEditable()
        ucrInputAddReorder.SetLinkedDisplayControl(lblReorder)

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrHistogramSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrPnlOptions.AddToLinkedControls({ucrChkDisplayAsDotPlot}, {rdoHistogram}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkBinWidth}, {rdoHistogram, rdoFrequencyPolygon}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkRidges}, {rdoDensity_ridges}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRidges.AddToLinkedControls(ucrInputStats, {"FALSE"}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveHist.SetPrefix("histogram")
        ucrSaveHist.SetDataFrameSelector(ucrHistogramSelector.ucrAvailableDataFrames)
        ucrSaveHist.SetIsComboBox()
        ucrSaveHist.SetCheckBoxText("Save Graph")
        ucrSaveHist.SetSaveTypeAsGraph()
        ucrSaveHist.SetAssignToIfUncheckedValue("last_graph")
        DialogueSize()
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsHistAesFunction = New RFunction
        clsPercentage = New RFunction
        clsYlabScalesFunction = New RFunction
        clsForecatsReverse = New RFunction
        clsForecatsInfreqValue = New RFunction
        clsForecatsReverseValue = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True
        ucrHistogramSelector.Reset()
        ucrHistogramSelector.SetGgplotFunction(clsBaseOperator)
        ucrSaveHist.Reset()
        ucrVariablesAsFactorforHist.SetMeAsReceiver()
        bResetSubdialog = True
        bResetHistLayerSubdialog = True

        ucrInputAddReorder.SetText(strNone)
        ucrInputAddReorder.bUpdateRCodeFromControl = True


        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsHistAesFunction.SetPackageName("ggplot2")
        clsHistAesFunction.SetRCommand("aes")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_histogram")
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)

        clsPercentage.SetPackageName("scales")
        clsPercentage.SetRCommand("percent_format")

        clsForecatsReverse.SetPackageName("forcats")
        clsForecatsReverse.SetRCommand("fct_rev")

        clsForecatsReverseValue.SetPackageName("forcats")
        clsForecatsReverseValue.SetRCommand("fct_rev")

        clsForecatsInfreqValue.SetPackageName("forcats")
        clsForecatsInfreqValue.SetRCommand("fct_infreq")


        clsYlabScalesFunction.SetRCommand("scale_y_continuous")
        clsYlabScalesFunction.AddParameter("NULL", "NULL", bIncludeArgumentName:=False, iPosition:=0)
        clsYlabScalesFunction.AddParameter("breaks", "NULL", iPosition:=1)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")


        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveHist.SetRCode(clsBaseOperator, bReset)
        ucrHistogramSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkPercentages.SetRCode(clsYScalecontinuousFunction, bReset)
        ucrChkDisplayAsDotPlot.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkRidges.SetRCode(clsRgeomPlotFunction, bReset)
        ucrVariablesAsFactorforHist.SetRCode(clsRaesFunction, bReset)

        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            ucrInputStats.SetRCode(clsHistAesFunction, bReset)
            ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
            ucrChkBinWidth.SetRCode(clsRgeomPlotFunction, bReset)
            ucrChkMinHeight.SetRCode(clsRgeomPlotFunction, bReset)
            ucrNudBinwidth.SetRCode(clsRgeomPlotFunction, bReset)
            ucrNudMinHeight.SetRCode(clsRgeomPlotFunction, bReset)
            ucrChkOmitYAxis.SetRCode(clsYlabScalesFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        'Tests when ok can be enabled
        If ucrVariablesAsFactorforHist.IsEmpty OrElse Not ucrSaveHist.IsComplete OrElse (ucrChkRidges.Checked AndAlso (ucrFactorReceiver.IsEmpty OrElse ucrFactorReceiver.Enabled = False)) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub SetDialogOptions()
        clsHistAesFunction.RemoveParameterByName("x")
        clsHistAesFunction.RemoveParameterByName("y")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)
        clsRgeomPlotFunction.SetPackageName("ggplot2")
        ucrInputAddReorder.Visible = Not ucrFactorReceiver.IsEmpty()

        If rdoHistogram.Checked Then
            If ucrChkDisplayAsDotPlot.Checked Then
                clsRgeomPlotFunction.SetRCommand("geom_dotplot")
                clsRgeomPlotFunction.RemoveParameterByName("mapping")
                If Not ucrFactorReceiver.IsEmpty Then
                    clsRgeomPlotFunction.AddParameter("binpositions", Chr(34) & "all" & Chr(34), iPosition:=0)
                    clsRgeomPlotFunction.AddParameter("stackgroups", "TRUE", iPosition:=1)
                Else
                    clsRgeomPlotFunction.RemoveParameterByName("binpositions")
                    clsRgeomPlotFunction.RemoveParameterByName("stackgroups")
                End If
            Else
                clsRgeomPlotFunction.SetRCommand("geom_histogram")
                clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)
                If Not ucrFactorReceiver.IsEmpty Then
                    clsRgeomPlotFunction.RemoveParameterByName("binpositions")
                    clsRgeomPlotFunction.RemoveParameterByName("stackgroups")
                End If
            End If

            ucrFactorReceiver.ChangeParameterName("fill")
            If Not ucrSaveHist.bUserTyped Then ucrSaveHist.SetPrefix("histogram")
        End If
        If rdoDensity_ridges.Checked Then
            clsRgeomPlotFunction.RemoveParameterByName("binpositions")
            clsRgeomPlotFunction.RemoveParameterByName("stackgroups")
            If ucrChkRidges.Checked Then
                ucrFactorReceiver.ChangeParameterName("y")
                clsHistAesFunction.RemoveParameterByName("y")
                clsHistAesFunction.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorforHist.GetVariables(), iPosition:=1)
                clsHistAesFunction.AddParameter("y", clsRFunctionParameter:=ucrFactorReceiver.GetVariables(), iPosition:=2)
                clsRgeomPlotFunction.SetPackageName("ggridges")
                clsRgeomPlotFunction.SetRCommand("geom_density_ridges")
                clsRgeomPlotFunction.RemoveParameterByName("mapping")
                If Not ucrSaveHist.bUserTyped Then
                    ucrSaveHist.SetPrefix("density_ridges")
                End If
            Else
                ucrFactorReceiver.ChangeParameterName("colour")
                clsRgeomPlotFunction.SetRCommand("geom_density")
                clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)
                If Not ucrSaveHist.bUserTyped Then
                    ucrSaveHist.SetPrefix("density")
                End If
            End If
        ElseIf rdoFrequencyPolygon.Checked Then
            ucrFactorReceiver.ChangeParameterName("colour")
            clsRgeomPlotFunction.SetRCommand("geom_freqpoly")
            clsRgeomPlotFunction.RemoveParameterByName("binpositions")
            clsRgeomPlotFunction.RemoveParameterByName("stackgroups")
            If Not ucrSaveHist.bUserTyped Then
                ucrSaveHist.SetPrefix("frequency_polygon")
            End If
        End If
        autoTranslate(Me)
        UpdateParameter()

    End Sub

    Private Sub UpdateParameter()
        Dim strChangedTextFreq As String = ucrInputAddReorder.GetText()
        clsRaesFunction.RemoveParameterByName("y")

        clsForecatsInfreqValue.AddParameter("f", "as.factor(" & ucrFactorReceiver.GetVariableNames(False) & ")", iPosition:=0)

        If rdoHistogram.Checked Then
            If Not ucrFactorReceiver.IsEmpty Then
                Select Case strChangedTextFreq
                    Case strAscending
                        clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                        clsRaesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                    Case strDescending
                        clsRaesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                    Case strReverse
                        clsForecatsReverse.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                        clsRaesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                    Case strNone
                        clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                End Select
            End If
        Else
            If Not ucrFactorReceiver.IsEmpty Then
                If rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked Then
                    Select Case strChangedTextFreq
                        Case strAscending
                            clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                            clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        Case strDescending
                            clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                        Case strReverse
                            clsForecatsReverse.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                            clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        Case strNone
                            clsRaesFunction.AddParameter("y", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                    End Select
                Else
                    Select Case strChangedTextFreq
                        Case strAscending
                            clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                            clsRaesFunction.AddParameter("colour", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        Case strDescending
                            clsRaesFunction.AddParameter("colour", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                        Case strReverse
                            clsForecatsReverse.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                            clsRaesFunction.AddParameter("colour", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
                        Case strNone
                            clsRaesFunction.AddParameter("colour", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                    End Select
                End If
            End If
        End If
    End Sub

    Private Sub ucrPnlOptions_Control() Handles ucrPnlOptions.ControlValueChanged, ucrChkDisplayAsDotPlot.ControlValueChanged, ucrChkRidges.ControlValueChanged, ucrFactorReceiver.ControlValueChanged, ucrVariablesAsFactorforHist.ControlValueChanged, ucrInputAddReorder.ControlValueChanged, ucrChkOmitYAxis.ControlValueChanged, ucrNudBinwidth.ControlValueChanged
        toolStripMenuItemHistogramOptions.Enabled = rdoHistogram.Checked AndAlso Not ucrChkDisplayAsDotPlot.Checked
        toolStripMenuItemDotOptions.Enabled = rdoHistogram.Checked AndAlso ucrChkDisplayAsDotPlot.Checked
        toolStripMenuItemDensityOptions.Enabled = rdoDensity_ridges.Checked AndAlso Not ucrChkRidges.Checked
        toolStripMenuItemDensityRidgesOptions.Enabled = rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked
        toolStripMenuItemFrequencyPolygonOptions.Enabled = rdoFrequencyPolygon.Checked
        SetDialogOptions()
        DialogueSize()
        UpdateParameter()
    End Sub

    Private Sub Adding_Percentages(ucrChangedControl As ucrCore) Handles ucrInputStats.ControlValueChanged, ucrChkPercentages.ControlValueChanged
        If ucrInputStats.GetText() = "Fractions" AndAlso ucrChkPercentages.Checked Then
            clsYScalecontinuousFunction.AddParameter("labels", clsRFunctionParameter:=clsPercentage)
            clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsYScalecontinuousFunction)
        Else
            clsBaseOperator.RemoveParameterByName("scale")
        End If
    End Sub

    'TODO remove vbCr not compatible with other code
    Private Sub rdoHistogram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoHistogram.KeyPress
        If e.KeyChar = vbCr Then
            rdoHistogram.Checked = True
        End If
    End Sub

    Private Sub rdoDensity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoDensity_ridges.KeyPress
        If e.KeyChar = vbCr Then
            rdoDensity_ridges.Checked = True
        End If
    End Sub

    Private Sub rdoFrequencyPolygon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoFrequencyPolygon.KeyPress
        If e.KeyChar = vbCr Then
            rdoFrequencyPolygon.Checked = True
        End If
    End Sub

    Private Sub ucrVariablesAsFactorforHist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorforHist.ControlValueChanged
        If Not ucrVariablesAsFactorforHist.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=0)
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction,
                         clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrHistogramSelector, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                         clsNewGlobalAesFunction:=clsRaesFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemHistogramOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemHistogramOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorforHist.bSingleVariable) Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf (clsParam.strArgumentName = "fill" AndAlso rdoHistogram.Checked) OrElse (clsParam.strArgumentName = "colour" AndAlso (rdoFrequencyPolygon.Checked OrElse (rdoDensity_ridges.Checked AndAlso Not ucrChkRidges.Checked))) OrElse (clsParam.strArgumentName = "y" AndAlso (rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked)) Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        'this is here because of the subdialog 
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)
        TestOkEnabled()
    End Sub

    Private Sub toolStripMenuItemDensityOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemDensityRidgesOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityRidgesOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemFrequencyPolygonOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemFrequencyPolygonOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()

    End Sub

    Private Sub toolStripMenuItemDotOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub DialogueSize()
        If rdoHistogram.Checked Then
            Me.Size = New Size(464, 468)
            Me.lblReorder.Location = New Point(283, 275)
            Me.ucrInputAddReorder.Location = New Point(283, 289)
            Me.ucrSaveHist.Location = New Point(10, 360)
            Me.ucrChkLegend.Location = New Point(11, 329)
            Me.ucrInputStation.Location = New Point(318, 328)
            Me.ucrInputLegendPosition.Location = New Point(87, 328)
            Me.ucr1stFactorReceiver.Location = New Point(205, 329)
            Me.lblFacetBy.Location = New Point(208, 315)
            Me.ucrBase.Location = New Point(10, 390)
        ElseIf rdoDensity_ridges.Checked Then
            Me.Size = New Size(464, 500)
            Me.lblReorder.Location = New Point(286, 298)
            Me.ucrInputAddReorder.Location = New Point(287, 314)
            Me.ucrSaveHist.Location = New Point(10, 380)
            Me.ucrBase.Location = New Point(10, 408)
            Me.ucrChkLegend.Location = New Point(11, 349)
            Me.ucrInputStation.Location = New Point(318, 348)
            Me.ucrInputLegendPosition.Location = New Point(87, 348)
            Me.ucr1stFactorReceiver.Location = New Point(205, 349)
            Me.lblFacetBy.Location = New Point(208, 334)
        Else
            Me.Size = New Size(464, 440)
            Me.lblReorder.Location = New Point(283, 250)
            Me.ucrInputAddReorder.Location = New Point(283, 264)
            Me.ucrSaveHist.Location = New Point(10, 330)
            Me.ucrChkLegend.Location = New Point(11, 296)
            Me.ucrInputStation.Location = New Point(318, 294)
            Me.ucrInputLegendPosition.Location = New Point(87, 294)
            Me.ucr1stFactorReceiver.Location = New Point(205, 296)
            Me.lblFacetBy.Location = New Point(208, 283)
            Me.ucrBase.Location = New Point(10, 357)
        End If
    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrHistogramSelector.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            currentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso
                    Not ucrInputStation.Equals(ucrChangedControl) AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso ucrInputStation.GetText = strFacetRow) OrElse (strChangedText = strFacetRow AndAlso
                    ucrInputStation.GetText = strFacetWrap) OrElse (strChangedText = strFacetWrap AndAlso
                    ucrInputStation.GetText = strFacetCol) OrElse (strChangedText = strFacetCol AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub


    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforHist.ControlContentsChanged, ucrSaveHist.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged, ucrChkRidges.ControlContentsChanged, ucrInputAddReorder.ControlContentsChanged, ucrChkBinWidth.ControlContentsChanged, ucrNudBinwidth.ControlContentsChanged, ucrNudMinHeight.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkOmitYAxis_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitYAxis.ControlValueChanged, ucrChkDisplayAsDotPlot.ControlValueChanged
        If ucrChkDisplayAsDotPlot.Checked Then
            If ucrChkOmitYAxis.Checked Then
                clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsYlabScalesFunction, iPosition:=4, bIncludeArgumentName:=False)
            Else
                clsBaseOperator.RemoveParameterByName("scale")
            End If
        End If
    End Sub

    Private Sub ucrChkMinHeight_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMinHeight.ControlValueChanged, ucrNudMinHeight.ControlValueChanged
        If ucrChkRidges.Checked Then
            If ucrChkMinHeight.Checked Then
                clsRgeomPlotFunction.AddParameter("rel_min_height", ucrNudMinHeight.GetText, iPosition:=4)
            Else
                clsRgeomPlotFunction.RemoveParameterByName("rel_min_height")
            End If
        End If
    End Sub

    Private Sub ucrChkBinWidth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBinWidth.ControlValueChanged, ucrNudBinwidth.ControlValueChanged
        If Not rdoDensity_ridges.Checked Then
            If ucrChkBinWidth.Checked Then
                clsRgeomPlotFunction.AddParameter("binwidth", ucrNudBinwidth.GetText, iPosition:=4)
            Else
                clsRgeomPlotFunction.RemoveParameterByName("binwidth")
            End If
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrVariablesAsFactorforHist.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If

            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrHistogramSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrHistogramSelector.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub


End Class