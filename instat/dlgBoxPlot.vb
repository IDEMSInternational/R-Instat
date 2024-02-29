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
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsRggplotFunction As New RFunction
    'clsRggplotFunction is the global ggplot function, will be used as RFunction of the first RParameter of ucrBase.clsRSyntax (which has "+" as main command). It is emphasised as a public field as it is used/editted in the sdgLayerOptions. The link is operated via SetupLayer that sets sdgLayerOptions.clsGgplotFunction = dlgBoxPlot.clsRggplotFunction.
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsWidthRaesFunction As New RFunction
    Private clsStatAesFunction As New RFunction
    Private clsStatSummary As New RFunction
    Private clsPositionNodgeFunction As New RFunction
    Private clsDummyFunction As New RFunction
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
    Private clsBoxplotFunction As New RFunction
    Private clsTufteBoxplotFunction As New RFunction
    Private clsJitterplotFunction As New RFunction
    Private clsViolinplotFunction As New RFunction
    Private clsCurrGeomFunction As New RFunction
    Private clsSummaryFunction As New RFunction
    Private clsCutWitdhFunction As New RFunction
    Private clsGeomBoxPlotFunction As New RFunction
    ' Jitter function that can be added to the boxplot/violin base layer
    Private clsAddedJitterFunc As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsFacetsFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

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
        DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsAddedJitterParam As New RParameter
        Dim dctSummaries As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 436
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplotTufte)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplotTufte, {"geom_boxplot", "geom_tufteboxplot"})
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls({ucrChkAddPoints, ucrChkWidth}, {rdoBoxplotTufte, rdoViolin}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrChkTufte}, {rdoBoxplotTufte}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTufte.AddToLinkedControls(ucrChkVarWidth, {"FALSE"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls(ucrChkBoxPlot, {rdoJitter, rdoViolin}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


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
        ucr1stFactorReceiver.Selector = ucrSelectorBoxPlot
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrChkWidth.SetText("Width")
        ucrChkWidth.AddToLinkedControls({ucrInputWidth}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.25)
        ucrChkWidth.AddParameterValuesCondition(True, "cut_width", "True")
        ucrChkWidth.AddParameterValuesCondition(False, "cut_width", "False")

        ucrChkBoxPlot.SetText("Add Boxplot")
        ucrChkBoxPlot.AddToLinkedControls({ucrNudBoxPlot}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrChkBoxPlot.AddParameterValuesCondition(True, "boxplot", "True")
        ucrChkBoxPlot.AddParameterValuesCondition(False, "boxplot", "False")

        ucrNudBoxPlot.SetParameter(New RParameter("width", 2))
        ucrNudBoxPlot.SetMinMax(0, 1)
        ucrNudBoxPlot.DecimalPlaces = 2
        ucrNudBoxPlot.Increment = 0.01
        ucrNudBoxPlot.SetLinkedDisplayControl(lblWidth)

        ucrInputWidth.SetParameter(New RParameter("width"))
        ucrInputWidth.SetValidationTypeAsNumeric()

        ucrChkGrouptoConnect.SetText("Group to Connect")
        ucrChkGrouptoConnect.AddToLinkedControls(ucrInputSummaries, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="mean")
        ucrChkGrouptoConnect.AddParameterPresentCondition(True, strStatSummaryParameterName, True)
        ucrChkGrouptoConnect.AddParameterPresentCondition(False, strStatSummaryParameterName, False)
        'this control exists but diabled for now
        DialogueSize()
    End Sub

    Private Sub SetDefaults()
        bResetLineLayerSubdialog = True
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsLocalRaesFunction = New RFunction
        clsStatSummary = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsDummyFunction = New RFunction
        clsWidthRaesFunction = New RFunction
        clsGeomBoxPlotFunction = New RFunction
        clsStatAesFunction = New RFunction
        clsPositionNodgeFunction = New RFunction

        'Setting up new functions
        clsBoxplotFunction = New RFunction
        clsTufteBoxplotFunction = New RFunction
        clsJitterplotFunction = New RFunction
        clsViolinplotFunction = New RFunction
        clsSummaryFunction = New RFunction

        clsAddedJitterFunc.Clear()

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.SetGgplotFunction(clsBaseOperator)

        ucrSaveBoxplot.Reset()
        sdgPlots.Reset()
        ucrVariablesAsFactorForBoxplot.SetMeAsReceiver()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        clsDummyFunction.AddParameter("cut_width", "False", iPosition:=0)
        clsDummyFunction.AddParameter("boxplot", "False", iPosition:=1)

        'Setting current geom as boxplot
        clsCurrGeomFunction.SetPackageName("ggplot2")
        clsCurrGeomFunction = clsBoxplotFunction

        clsBoxplotFunction.SetPackageName("ggplot2")
        clsBoxplotFunction.SetRCommand("geom_boxplot")
        clsBoxplotFunction.AddParameter("varwidth", "FALSE", iPosition:=0)
        clsBoxplotFunction.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsWidthRaesFunction.SetPackageName("ggplot2")
        clsWidthRaesFunction.SetRCommand("aes")

        clsCutWitdhFunction.SetPackageName("ggplot2")
        clsCutWitdhFunction.SetRCommand("cut_width")

        clsStatAesFunction.SetPackageName("ggplot2")
        clsStatAesFunction.SetRCommand("aes")

        clsGeomBoxPlotFunction.SetPackageName("ggplot2")
        clsGeomBoxPlotFunction.SetRCommand("geom_boxplot")

        clsTufteBoxplotFunction.SetPackageName("ggthemes")
        clsTufteBoxplotFunction.SetRCommand("geom_tufteboxplot")
        clsTufteBoxplotFunction.AddParameter("stat", Chr(34) & "boxplot" & Chr(34), iPosition:=0)
        clsTufteBoxplotFunction.AddParameter("median.type", Chr(34) & "line" & Chr(34), iPosition:=1)
        clsTufteBoxplotFunction.AddParameter("coef ", "1.5", iPosition:=14)

        clsViolinplotFunction.SetPackageName("ggplot2")
        clsViolinplotFunction.SetRCommand("geom_violin")

        clsSummaryFunction.SetPackageName("ggplot2")
        clsSummaryFunction.SetRCommand("stat_summary")

        clsJitterplotFunction.SetPackageName("ggplot2")
        clsJitterplotFunction.SetRCommand("geom_jitter")
        clsJitterplotFunction.AddParameter("height", 0, iPosition:=1)
        clsJitterplotFunction.AddParameter("width", 0.2, iPosition:=2)

        clsAddedJitterFunc.SetPackageName("ggplot2")
        clsAddedJitterFunc.SetRCommand("geom_jitter")
        clsAddedJitterFunc.AddParameter("height", 0, iPosition:=1)
        clsAddedJitterFunc.AddParameter("width", 0.2, iPosition:=2)

        'Setting operation and adding parameters to baseoperator
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsBoxplotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)

        clsStatSummary.SetPackageName("ggplot2")
        clsStatSummary.SetRCommand("stat_summary")
        clsStatSummary.AddParameter("geom", Chr(34) & "line" & Chr(34), iPosition:=0)

        clsPositionNodgeFunction.SetPackageName("ggplot2")
        clsPositionNodgeFunction.SetRCommand("position_dodge")
        clsPositionNodgeFunction.AddParameter("width", 0.9, iPosition:=0)

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
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorBoxPlot.SetRCode(clsRggplotFunction, bReset)

        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVarWidth.SetRCode(clsBoxplotFunction, bReset)
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
        ucrPnlPlots.SetRCode(clsCurrGeomFunction, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrChkTufte.SetRCode(clsCurrGeomFunction, bReset)
        ucrInputWidth.SetRCode(clsCutWitdhFunction, bReset)
        ucrNudBoxPlot.SetRCode(clsGeomBoxPlotFunction, bReset)
        If bReset Then
            AutoFacetStation()
            ucrChkBoxPlot.SetRCode(clsDummyFunction, bReset)
            ucrChkWidth.SetRCode(clsDummyFunction, bReset)
        End If
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

    Private Sub SetGeomPrefixFillColourAes()
        'Sets geom function, fill and colour aesthetics, ucrsave prefix and stat summary parameters
        clsStatSummary.AddParameter("size", 1.5, iPosition:=3)
        If rdoBoxplotTufte.Checked Then
            If ucrChkTufte.Checked Then
                ucrSaveBoxplot.SetPrefix("tufte_boxplot")
                clsCurrGeomFunction = clsTufteBoxplotFunction
                clsStatSummary.AddParameter("size", 0.7, iPosition:=3)
                ucrSecondFactorReceiver.ChangeParameterName("colour")
            Else
                ucrSaveBoxplot.SetPrefix("box_plot")
                ucrSecondFactorReceiver.ChangeParameterName("fill")
                clsCurrGeomFunction = clsBoxplotFunction
            End If
        ElseIf rdoJitter.Checked Then
            ucrSaveBoxplot.SetPrefix("jitter")
            ucrSecondFactorReceiver.ChangeParameterName("colour")
            clsCurrGeomFunction = clsJitterplotFunction
        Else
            ucrSaveBoxplot.SetPrefix("violin")
            ucrSecondFactorReceiver.ChangeParameterName("fill")
            clsCurrGeomFunction = clsViolinplotFunction
        End If
        'TODO Am not sure why the geomfunc parameter which carries clsCurrGeomFunction(current geom function) 
        'does Not Update() properly when readio buttons are changed
        'hence i have to force it to update properly after this if statement
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsCurrGeomFunction, iPosition:=2)
        autoTranslate(Me)
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged, ucrChkTufte.ControlContentsChanged, ucrChkAddPoints.ControlValueChanged
        SetGeomPrefixFillColourAes()
        DialogueSize()
        EnableDisableBoxplotOptions()
        If rdoBoxplotTufte.Checked Then
            If ucrChkAddPoints.Checked Then
                clsBoxplotFunction.AddParameter("outlier.shape", "NA", iPosition:=2)
            Else
                clsBoxplotFunction.RemoveParameterByName("outlier.shape")
            End If
        End If
    End Sub

    Private Sub ucrChkGrouptoConnect_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGrouptoConnect.ControlValueChanged
        If ucrChkGrouptoConnect.Checked Then
            clsBaseOperator.AddParameter(strStatSummaryParameterName, clsRFunctionParameter:=clsStatSummary, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName(strStatSummaryParameterName)
        End If
        AddRemoveAesParm()
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorBoxPlot,
                                   bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others have been modified. 
        '  One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrByFactorsReceiver.Clear()
                Else
                    ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the value stored in the clsReasFunction in the multiple variables 
                '  case is "value", however that one shouldn't be written in the multiple 
                '  variables receiver (otherwise it would stack all variables and the stack 
                '  ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables 
                '  independently from the multiple variables method? Here if the receiver is 
                '  actually in single mode, the variable "value" will still be given back, which 
                '  throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForBoxplot.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrVariablesAsFactorForBoxplot.Clear()
                Else
                    ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
                                clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                                clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrSelectorBoxPlot, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                                clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                                clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                                strMainDialogGeomParameterNames:=strGeomParameterNames, bChangeAesParameter:=True, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemBoxOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemBoxOptions.Click
        openSdgLayerOptions(clsBoxplotFunction)
    End Sub

    Private Sub toolStripMenuItemJitterOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemJitterOptions.Click
        openSdgLayerOptions(clsJitterplotFunction)
    End Sub

    Private Sub toolStripMenuItemTufteOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTufteOptions.Click
        openSdgLayerOptions(clsTufteBoxplotFunction)
    End Sub

    Private Sub toolStripMenuItemViolinOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemViolinOptions.Click
        openSdgLayerOptions(clsViolinplotFunction)
    End Sub

    Private Sub toolStripMenuItemSummaryOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemSummaryOptions.Click
        openSdgLayerOptions(clsSummaryFunction)
    End Sub

    Private Sub DialogueSize()
        If rdoBoxplotTufte.Checked OrElse rdoViolin.Checked Then
            Me.Size = New Size(441, 536)
            Me.ucrChkLegend.Location = New Size(10, 388)
            Me.ucrInputLegendPosition.Location = New Size(105, 390)
            Me.ucrInputStation.Location = New Size(335, 390)
            Me.ucr1stFactorReceiver.Location = New Size(222, 391)
            Me.lblFacetBy.Location = New Size(222, 376)
            Me.ucrSaveBoxplot.Location = New Point(10, 418)
            Me.ucrBase.Location = New Point(10, 442)
        Else
            Me.Size = New Size(441, 500)
            Me.ucrChkLegend.Location = New Size(10, 358)
            Me.ucrInputLegendPosition.Location = New Size(105, 360)
            Me.ucrInputStation.Location = New Size(335, 360)
            Me.ucr1stFactorReceiver.Location = New Size(222, 361)
            Me.lblFacetBy.Location = New Size(222, 346)
            Me.ucrSaveBoxplot.Location = New Point(10, 390)
            Me.ucrBase.Location = New Point(10, 415)
        End If
    End Sub

    Private Sub AutoFacetStation()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If ucrSelectorBoxPlot.CurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver = ucrSelectorBoxPlot.CurrentReceiver
        End If
        ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
        AddRemoveGroupBy()
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

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrByFactorsReceiver.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
        EnableDisableWidth()
        AddRemoveAesParm()
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
        If ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorBoxPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorBoxPlot.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub ucrSaveBoxplot_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveBoxplot.ControlContentsChanged, ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub EnableDisableBoxplotOptions()
        toolStripMenuItemJitterOptions.Enabled = rdoJitter.Checked OrElse ((rdoBoxplotTufte.Checked _
            OrElse rdoViolin.Checked) AndAlso ucrChkAddPoints.Checked)
        toolStripMenuItemViolinOptions.Enabled = rdoViolin.Checked
        toolStripMenuItemSummaryOptions.Enabled = rdoBoxplotTufte.Checked OrElse ((rdoJitter.Checked _
            OrElse rdoViolin.Checked) AndAlso ucrChkGrouptoConnect.Checked)
        toolStripMenuItemTufteOptions.Enabled = (rdoBoxplotTufte.Checked AndAlso ucrChkTufte.Checked)
    End Sub

    Private Sub ucrInputWidth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputWidth.ControlValueChanged, ucrByFactorsReceiver.ControlValueChanged
        If Not ucrInputWidth.IsEmpty Then
            clsCutWitdhFunction.AddParameter("width", ucrInputWidth.GetText(), iPosition:=1)
            clsCutWitdhFunction.AddParameter("var", ucrByFactorsReceiver.GetVariableNames(False), bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCutWitdhFunction.RemoveParameterByName("width")
            clsCutWitdhFunction.RemoveParameterByName("var")
        End If
        EnableDisableWidth()
    End Sub

    Private Sub ucrChkWidth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWidth.ControlValueChanged
        EnableDisableWidth()
    End Sub

    Private Sub EnableDisableWidth()
        If ucrByFactorsReceiver.strCurrDataType = "Date" OrElse ucrByFactorsReceiver.strCurrDataType = "factor" OrElse ucrByFactorsReceiver.strCurrDataType = "orderded, factor" Then
            ucrChkWidth.Enabled = False
            ucrInputWidth.Enabled = False
            clsBoxplotFunction.RemoveParameterByName("aes")
            clsWidthRaesFunction.RemoveParameterByName("group")
            clsViolinplotFunction.RemoveParameterByName("aes")
        Else
            ucrChkWidth.Enabled = True
            ucrInputWidth.Enabled = True
            If ucrChkWidth.Checked AndAlso Not ucrByFactorsReceiver.IsEmpty Then
                clsWidthRaesFunction.AddParameter("group", clsRFunctionParameter:=clsCutWitdhFunction, iPosition:=1)
                clsBoxplotFunction.AddParameter("aes", clsRFunctionParameter:=clsWidthRaesFunction, bIncludeArgumentName:=False, iPosition:=1)
                clsViolinplotFunction.AddParameter("aes", clsRFunctionParameter:=clsWidthRaesFunction, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsWidthRaesFunction.RemoveParameterByName("group")
                clsBoxplotFunction.RemoveParameterByName("aes")
                clsViolinplotFunction.RemoveParameterByName("aes")
            End If
        End If
    End Sub

    Private Sub ucrChkBoxPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBoxPlot.ControlValueChanged, ucrNudBoxPlot.ControlValueChanged
        If ucrChkBoxPlot.Checked Then
            clsGeomBoxPlotFunction.AddParameter("width", ucrNudBoxPlot.GetText(), iPosition:=3)
            clsBaseOperator.AddParameter("geom_boxplot", clsRFunctionParameter:=clsGeomBoxPlotFunction)
        Else
            clsGeomBoxPlotFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameterByName("geom_boxplot")
        End If
    End Sub

    Private Sub AddRemoveAesParm()
        If Not ucrSecondFactorReceiver.IsEmpty AndAlso Not (ucrSecondFactorReceiver.GetVariableNames = ucrByFactorsReceiver.GetVariableNames) Then
            clsStatAesFunction.AddParameter("group", ucrSecondFactorReceiver.GetVariableNames(False), iPosition:=0)
            clsStatAesFunction.AddParameter("colour", ucrSecondFactorReceiver.GetVariableNames(False), iPosition:=1)
            clsStatSummary.AddParameter("stat_aes", clsRFunctionParameter:=clsStatAesFunction, bIncludeArgumentName:=False)
            clsStatSummary.AddParameter("position", clsRFunctionParameter:=clsPositionNodgeFunction)
            clsStatSummary.RemoveParameterByName("group")
            clsStatSummary.RemoveParameterByName("color")
        Else
            clsStatSummary.AddParameter("group", 1, iPosition:=1)
            clsStatSummary.AddParameter("color", Chr(34) & "blue" & Chr(34), iPosition:=2)
            clsStatAesFunction.RemoveParameterByName("group")
            clsStatAesFunction.RemoveParameterByName("colour")
            clsStatSummary.RemoveParameterByName("stat_aes")
            clsStatSummary.RemoveParameterByName("position")
        End If
    End Sub

    Private Sub ucrSecondFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSecondFactorReceiver.ControlValueChanged
        AddRemoveAesParm()
    End Sub
End Class
