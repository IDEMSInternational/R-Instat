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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    'clsRggplotFunction is the global ggplot function, will be used as RFunction of the first RParameter of ucrBase.clsRSyntax (which has "+" as main command). It is emphasised as a public field as it is used/editted in the sdgLayerOptions. The link is operated via SetupLayer that sets sdgLayerOptions.clsGgplotFunction = dlgBoxPlot.clsRggplotFunction.
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsStatSummary As New RFunction
    'Similarly clsRgeom_boxplotFunction and clsRaesFunction (respectively the geom_boxplot function and the global aes function) are given through SetupLayer to sdgLayerOptions for edit. 
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsThemeFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    'Adding new function s
    Private clsBoxplotFunc As New RFunction
    Private clsTufteBoxplotFunc As New RFunction
    Private clsJitterplotFunc As New RFunction
    Private clsViolinplotFunc As New RFunction
    Private clsCurrGeomFunc As New RFunction
    ' Jitter function that can be added to the boxplot/violin base layer
    Private clsAddedJitterFunc As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strStatSummaryParameterName As String = "stat_summary"
    Private strAdditionalPointsParameterName As String = "add_jitter"
    Private strGeomParameterNames() As String = {strFirstParameterName, strStatSummaryParameterName, strAdditionalPointsParameterName}

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsAddedJitterParam As New RParameter
        Dim dctSummaries As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 436
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplotTufte)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplotTufte, {"geom_boxplot", "geom_tufteboxplot"})
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls(ucrChkAddPoints, {rdoBoxplotTufte, rdoViolin}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrChkTufte}, {rdoBoxplotTufte}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTufte.AddToLinkedControls(ucrChkVarWidth, {"FALSE"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorBoxPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorBoxPlot.SetParameterIsrfunction()

        ucrVariablesAsFactorForBoxplot.SetParameter(New RParameter("y", 0))
        ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForBoxplot.Selector = ucrSelectorBoxPlot
        ucrVariablesAsFactorForBoxplot.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorForBoxplot.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorForBoxplot.SetParameterIsString()
        ucrVariablesAsFactorForBoxplot.bWithQuotes = False

        ucrByFactorsReceiver.SetParameter(New RParameter("x", 1))
        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})
        ucrByFactorsReceiver.strSelectorHeading = "Factors"
        ucrByFactorsReceiver.SetParameterIsString()
        ucrByFactorsReceiver.bWithQuotes = False
        ucrByFactorsReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrByFactorsReceiver.bAddParameterIfEmpty = True
        ucrSecondFactorReceiver.SetLinkedDisplayControl(lblByFactors)

        ucrSecondFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.strSelectorHeading = "Factors"
        ucrSecondFactorReceiver.SetParameterIsString()
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetLinkedDisplayControl(lblBySecondFactor)

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)

        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsAddedJitterParam.SetArgumentName(strAdditionalPointsParameterName)
        clsAddedJitterParam.SetArgument(clsAddedJitterFunc)
        clsAddedJitterParam.Position = 3

        ucrChkAddPoints.SetParameter(clsAddedJitterParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkAddPoints.SetText("Add Points")
        ucrChkAddPoints.AddToLinkedControls({ucrNudJitter, ucrNudTransparency}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudJitter.SetParameter(New RParameter("width", 2))
        ucrNudJitter.Minimum = 0
        ucrNudJitter.DecimalPlaces = 2
        ucrNudJitter.Increment = 0.01
        ucrNudJitter.SetLinkedDisplayControl(lblJitter)

        ucrNudTransparency.SetParameter(New RParameter("alpha", 2))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01
        ucrNudTransparency.SetLinkedDisplayControl(lblTransparency)
        ucrNudTransparency.SetRDefault(1)

        ucrChkTufte.SetText("Tufte Boxplots")
        ucrChkTufte.AddFunctionNamesCondition(False, "geom_tufteboxplot", False)
        ucrChkTufte.AddFunctionNamesCondition(True, "geom_tufteboxplot")

        ucrSaveBoxplot.SetPrefix("box_plot")
        ucrSaveBoxplot.SetIsComboBox()
        ucrSaveBoxplot.SetCheckBoxText("Save Graph")
        ucrSaveBoxplot.SetSaveTypeAsGraph()
        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        ucrSaveBoxplot.SetAssignToIfUncheckedValue("last_graph")

        ucrInputSummaries.SetParameter(New RParameter("fun.y", 2))
        dctSummaries.Add("mean", Chr(34) & "mean" & Chr(34))
        dctSummaries.Add("median", Chr(34) & "median" & Chr(34))
        ucrInputSummaries.SetItems(dctSummaries)
        ucrInputSummaries.SetDropDownStyleAsNonEditable()


        ucrChkGrouptoConnect.SetText("Group to Connect")
        ucrChkGrouptoConnect.AddToLinkedControls(ucrInputSummaries, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="mean")
        ucrChkGrouptoConnect.AddParameterPresentCondition(True, strStatSummaryParameterName, True)
        ucrChkGrouptoConnect.AddParameterPresentCondition(False, strStatSummaryParameterName, False)
        'this control exists but diabled for now
        ucrChkSwapParameters.SetText("swap Parameters")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsLocalRaesFunction = New RFunction
        clsStatSummary = New RFunction

        'Setting up new functions
        clsBoxplotFunc = New RFunction
        clsTufteBoxplotFunc = New RFunction
        clsJitterplotFunc = New RFunction
        clsViolinplotFunc = New RFunction

        clsAddedJitterFunc.Clear()

        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.SetGgplotFunction(clsBaseOperator)

        ucrSaveBoxplot.Reset()
        sdgPlots.Reset()
        ucrVariablesAsFactorForBoxplot.SetMeAsReceiver()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        'Setting current geom as boxplot
        clsCurrGeomFunc.SetPackageName("ggplot2")
        clsCurrGeomFunc = clsBoxplotFunc

        clsBoxplotFunc.SetPackageName("ggplot2")
        clsBoxplotFunc.SetRCommand("geom_boxplot")
        clsBoxplotFunc.AddParameter("varwidth", "FALSE", iPosition:=0)
        clsBoxplotFunc.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsTufteBoxplotFunc.SetPackageName("ggthemes")
        clsTufteBoxplotFunc.SetRCommand("geom_tufteboxplot")
        clsTufteBoxplotFunc.AddParameter("stat", Chr(34) & "boxplot" & Chr(34), iPosition:=0)
        clsTufteBoxplotFunc.AddParameter("median.type", Chr(34) & "line" & Chr(34), iPosition:=1)
        clsTufteBoxplotFunc.AddParameter("coef ", "1.5", iPosition:=14)

        clsViolinplotFunc.SetPackageName("ggplot2")
        clsViolinplotFunc.SetRCommand("geom_violin")

        clsJitterplotFunc.SetPackageName("ggplot2")
        clsJitterplotFunc.SetRCommand("geom_jitter")
        clsJitterplotFunc.AddParameter("height", 0, iPosition:=1)
        clsJitterplotFunc.AddParameter("width", 0.2, iPosition:=2)

        clsAddedJitterFunc.SetPackageName("ggplot2")
        clsAddedJitterFunc.SetRCommand("geom_jitter")
        clsAddedJitterFunc.AddParameter("height", 0, iPosition:=1)
        clsAddedJitterFunc.AddParameter("width", 0.2, iPosition:=2)

        'Setting operation and adding parameters to baseoperator
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsBoxplotFunc, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)

        clsStatSummary.SetPackageName("ggplot2")
        clsStatSummary.SetRCommand("stat_summary")
        clsStatSummary.AddParameter("geom", Chr(34) & "line" & Chr(34), iPosition:=0)
        clsStatSummary.AddParameter("group", 1, iPosition:=1)
        clsStatSummary.AddParameter("color", Chr(34) & "blue" & Chr(34), iPosition:=2)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)

        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorBoxPlot.SetRCode(clsRggplotFunction, bReset)

        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVarWidth.SetRCode(clsBoxplotFunc, bReset)
        'passes in +cordflip
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrVariablesAsFactorForBoxplot.SetRCode(clsRaesFunction, bReset)
        ucrByFactorsReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsRaesFunction, bReset)

        ucrChkAddPoints.SetRCode(clsBaseOperator, bReset)
        ucrNudJitter.SetRCode(clsAddedJitterFunc, bReset)
        ucrNudTransparency.SetRCode(clsAddedJitterFunc, bReset)
        ucrInputSummaries.SetRCode(clsStatSummary, bReset)
        ucrChkGrouptoConnect.SetRCode(clsBaseOperator, bReset)
        ucrPnlPlots.SetRCode(clsCurrGeomFunc, bReset)

        ucrChkTufte.SetRCode(clsCurrGeomFunc, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorForBoxplot.IsEmpty OrElse Not ucrSaveBoxplot.IsComplete Then
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
                          clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                          clsNewFacetFunction:=clsRFacetFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                          clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bNewEnableDiscrete:=False,
                           clsNewAnnotateFunction:=clsAnnotateFunction, ucrNewBaseSelector:=ucrSelectorBoxPlot, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False

        'this syncs the coordflip in sdgplots and this main dlg
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)

    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRgeom_boxplotFunction, clsRggplotFunction, ...) of dlgBoxPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsCurrGeomFunc, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRgeom_boxplot and others has been modified. One then needs to display these modifications on the dlgBoxPlot.
        If clsCurrGeomFunc.GetParameter("varwidth") IsNot Nothing Then
            If clsCurrGeomFunc.GetParameter("varwidth").strArgumentValue = "TRUE" Then
                ' chkVarwidth.Checked = True
                'Observe that changing the check of the chkVarwidth here doesn't trigger the checkchanged event.
            End If
        Else
            'chkVarwidth.Checked = False
        End If

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrByFactorsReceiver.Clear()
                Else
                    ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForBoxplot.bSingleVariable) Then
                ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next

        'Question to be discussed: After running through the sdgLayerOptions, the clsCurrDataFrame parameters seem to have been cleared, such that in the multiple variable case, clsCurrDataFrame needs to be repopulated with "stack", "measure.vars" and "id.vars" parameters. Actually, even when repopulated, they are still not appearing in the script. ??
        'This resets the factor receiver and causes it to be cleared of the correct variable. We don't want this.
        'ucrVariablesAsFactorForBoxplot.SetReceiverStatus()
    End Sub

    Private Sub SetGeomPrefixFillColourAes()
        'Sets geom function, fill and colour aesthetics, ucrsave prefix and stat summary parameters
        clsStatSummary.AddParameter("size", 1.5, iPosition:=3)
        If rdoBoxplotTufte.Checked Then
            If ucrChkTufte.Checked Then
                cmdBoxPlotOptions.Text = "Tufte Box Options"
                ucrSaveBoxplot.SetPrefix("tufte_boxplot")
                clsCurrGeomFunc = clsTufteBoxplotFunc
                clsStatSummary.AddParameter("size", 0.7, iPosition:=3)
                ucrSecondFactorReceiver.ChangeParameterName("colour")
            Else
                cmdBoxPlotOptions.Text = "Box Options"
                ucrSaveBoxplot.SetPrefix("box_plot")
                ucrSecondFactorReceiver.ChangeParameterName("fill")
                clsCurrGeomFunc = clsBoxplotFunc
            End If

        ElseIf rdoJitter.Checked Then
            cmdBoxPlotOptions.Text = "Jitter Options"
            ucrSaveBoxplot.SetPrefix("jitter")
            ucrSecondFactorReceiver.ChangeParameterName("colour")
            clsCurrGeomFunc = clsJitterplotFunc
        Else
            cmdBoxPlotOptions.Text = "Violin Options"
            ucrSaveBoxplot.SetPrefix("violin")
            ucrSecondFactorReceiver.ChangeParameterName("fill")
            clsCurrGeomFunc = clsViolinplotFunc
        End If
        'TODO Am not sure why the geomfunc parameter which carries clsCurrGeomFunc(current geom function) 
        'does Not Update() properly when readio buttons are changed
        'hence i have to force it to update properly after this if statement
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsCurrGeomFunc, iPosition:=2)
        autoTranslate(Me)
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForBoxplot.bSingleVariable Then
            cmdBoxPlotOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdBoxPlotOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub ucrVariablesAsFactorForBoxplot_ControlContentsChanged() Handles ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged, ucrChkTufte.ControlContentsChanged
        SetGeomPrefixFillColourAes()
    End Sub

    Private Sub ucrSaveBoxplot_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveBoxplot.ControlContentsChanged, ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkGrouptoConnect_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGrouptoConnect.ControlValueChanged
        If ucrChkGrouptoConnect.Checked Then
            clsBaseOperator.AddParameter(strStatSummaryParameterName, clsRFunctionParameter:=clsStatSummary, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName(strStatSummaryParameterName)
        End If
    End Sub

    'this code is commented out but will work once we get the feature of linking controls with the contents of a receiver
    'Private Sub SwapFactors()
    '    If ucrChkSwapParameters.Checked Then
    '        ucrByFactorsReceiver.ChangeParameterName("fill")
    '        ucrSecondFactorReceiver.ChangeParameterName("x")
    '    End If
    'End Sub

    'Private Sub ucrChkSwapParameters_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSwapParameters.ControlValueChanged
    '    SwapFactors()
    'End Sub
End Class
