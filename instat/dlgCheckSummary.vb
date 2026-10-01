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
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class dlgCheckSummary

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsRecentIfElseFunction As New RFunction
    Private clsInnerIfElseFunction As New RFunction
    Private clsMaxFunction As New RFunction
    Private clsMaxYearAssign As New RFunction
    Private clsFactorFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsWithFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsGeomLine As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsVarsFunction As New RFunction
    Private clsRowVarsFunction As New RFunction
    Private clsColVarsFunction As New RFunction
    Private clsGeomPoint As New RFunction
    Private clsGeomSmoothFunction As New RFunction
    Private clsGeomHlineMean As New RFunction
    Private clsMeanFunction As New RFunction
    Private clsGeomHlineAesMean As New RFunction
    Private clsGroupByMeanFunction As New RFunction
    Private ReadOnly strMeanColumnName As String = ".mean_y"
    Private clsGeomTextFirstLast As New RFunction
    Private clsAesTextFirstLast As New RFunction
    Private clsGeomPointFirstLast As New RFunction
    Private clsGroupByFirstLast As New RFunction
    Private clsFilterFirstLastFunction As New RFunction
    Private clsSliceMinFirstLast As New RFunction
    Private clsSliceMaxFirstLast As New RFunction
    Private clsMaxSidePipeOperator As New ROperator
    Private clsBindRowsFirstLast As New RFunction
    Private clsUngroupFirstLast As New RFunction
    Private clsDistinctFirstLast As New RFunction
    Private clsFirstLastPipeOperator As New ROperator

    Private clsGeomSegmentFunction As New RFunction
    Private clsSegmentAesFunction As New RFunction
    Private clsGeomPoint2Function As New RFunction
    Private clsPoint2AesFunction As New RFunction

    ' ── Outliers tab R function objects ──
    Private clsOutlierBaseOperator As New ROperator
    Private clsOutlierRggplotFunction As New RFunction
    Private clsOutlierRaesFunction As New RFunction
    Private clsOutlierBoxplotFunction As New RFunction
    Private clsOutlierBoxplotStatFunction As New RFunction
    Private clsOutlierAddedJitterFunc As New RFunction
    Private clsOutlierLabsFunction, clsOutlierXlabsFunction, clsOutlierYlabFunction As RFunction
    Private clsOutlierXScaleContinuousFunction As New RFunction
    Private clsOutlierYScaleContinuousFunction As New RFunction
    Private clsOutlierThemeFunction As New RFunction
    Private dctOutlierThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsOutlierFacetFunction As New RFunction
    Private clsOutlierFacetVariablesOperator As New ROperator
    Private clsOutlierVarsFunction As New RFunction
    ' Outlier tab – separate Row/Col vars functions
    Private clsOutlierRowVarsFunction As New RFunction
    Private clsOutlierColVarsFunction As New RFunction
    Private clsOutlierScaleFillViridisFunction As New RFunction
    Private clsOutlierScaleColourViridisFunction As New RFunction
    Private clsOutlierCoordPolarFunction As New RFunction
    Private clsOutlierCoordPolarStartOperator As New ROperator
    Private clsOutlierXScaleDateFunction As New RFunction
    Private clsOutlierYScaleDateFunction As New RFunction
    Private clsOutlierAnnotateFunction As New RFunction
    ' Outlier Labeling Functions
    Private clsOutlierRoundFunction, clsOutlierLabelAfterFunction, clsOutlierAesLabelFunction, clsOutlierLabelSummaryFunction, clsOutlierIfFunction,
        clsOutlierLengthFunction, clsOutlierGroupbyFunction, clsOutlierBoxplotStat2Function, clsOutlierMutateLabelFunction, clsOutlierFilterElement2Function, clsOutlierUngroupFunction,
        clsOutlierAsFactor2Function, clsOutlierMutate2Function, clsOutlierGeomTextFunction, clsOutlierRaes2Function, clsOutlierPositionNudgeFunction As RFunction
    ' Outlier Labeling Operators
    Private clsOutlierOpenBraquetOperator, clsOutlierSpaceOperator, clsOutlierBraquetOperator, clsOutlierSemiCommatOperator, clsOutlierDollardOperator, clsOutlierEqualOperator,
        clsOutlierAssigneOperator, clsOutlierPipeLabelOperator, clsOutlierInOperator, clsOutlierDollarSignOperator As ROperator
    Private bResetOutlierSubdialog As Boolean = True
    Private strOutlierFirstParameterName As String = "geomfunc"
    Private strOutlierGeomParameterNames() As String

    ' Plot Options Objects
    Private clsLabsFunction, clsXLabsFunction, clsYLabsFunction As RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsAnnotateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction

    Private clsCLimitsYContinuous As New RFunction
    Private clsCLimitsYDate As New RFunction
    Private clsAsDateYLimit As New RFunction
    Private clsAsNumeric As New RFunction
    Private clsDatePeriodOperator As New ROperator
    Private clsAsDate As New RFunction

    Private sdgPlots As New sdgPlots
    Private sdgLayerOptions As New sdgLayerOptions
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsOutlierLocalRaesFunction As New RFunction
    Private bResetOutlierLayerSubdialog As Boolean = True

    Private WithEvents contextMenuStripPlotOptions As New ContextMenuStrip
    Private WithEvents PlotOptionsToolStripMenuItem As New ToolStripMenuItem("Plot Options")
    Private WithEvents toolStripMenuItemLineOptions As New ToolStripMenuItem("Line Options")
    Private WithEvents toolStripMenuItemPointOption As New ToolStripMenuItem("Point Options")
    Private WithEvents toolStripMenuItemOutlierBoxplotOptions As New ToolStripMenuItem("Boxplot Options")
    Private WithEvents toolStripMenuItemOutlierJitterOptions As New ToolStripMenuItem("Jitter Options")
    Private WithEvents toolStripMenuItemOutlierTextOptions As New ToolStripMenuItem("Text Options")

    Private Function GetCleanDataFrameParam() As RFunction
        Dim clsClean As RFunction = ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsClean.RemoveParameterByName("stack_data")
        clsClean.RemoveParameterByName("measure.vars")
        clsClean.RemoveParameterByName("id.vars")
        Return clsClean
    End Function

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private WithEvents grdRecentWorkSheet As Worksheet

    Private bUpdatingRecentGrid As Boolean = False
    Private strOutliersListLoadedForDataFrame As String = Nothing

    Private clsLocalRaesFunction As New RFunction

    Private clsMutateFunction As New RFunction
    Private clsAsDateMeanY As New RFunction

    Private clsGeomTextLabelMeanLine As New RFunction
    Private clsRoundMeanY As New RFunction
    Private clsPasteMeanY As New RFunction
    Private clsFormatMeanY As New RFunction

    Private clsSubDialogGeomHlineMean As New RFunction
    Private clsSubDialogGeomHlineAesMean As New RFunction

    Private ReadOnly Property ucrBase As ucrButtons
        Get
            Return UcrBaseCheckSummary
        End Get
    End Property

    Private Sub dlgCheckSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        UpdateVisiblePanels()
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = -1
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        toolStripMenuItemLineOptions.Name = "toolStripMenuItemLineOptions"
        toolStripMenuItemPointOption.Name = "toolStripMenuItemPointOption"
        toolStripMenuItemOutlierBoxplotOptions.Name = "toolStripMenuItemOutlierBoxplotOptions"
        toolStripMenuItemOutlierJitterOptions.Name = "toolStripMenuItemOutlierJitterOptions"
        toolStripMenuItemOutlierTextOptions.Name = "toolStripMenuItemOutlierTextOptions"

        contextMenuStripPlotOptions.Items.Clear()
        contextMenuStripPlotOptions.Items.Add(PlotOptionsToolStripMenuItem)
        contextMenuStripPlotOptions.Items.Add(toolStripMenuItemLineOptions)
        contextMenuStripPlotOptions.Items.Add(toolStripMenuItemPointOption)

        cmdPlotOptions.SplitMenuStrip = contextMenuStripPlotOptions

        ucrPnlOptions.AddRadioButton(rdoRecent)
        ucrPnlOptions.AddRadioButton(rdoOutliers)
        ucrPnlOptions.AddRadioButton(rdoTable)
        ucrPnlOptions.AddRadioButton(rdoTrend)

        ucrReceiverYear.SetParameter(New RParameter("x", 0))
        ucrReceiverYear.Selector = ucrSelectorForCheckSummary
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"
        ucrReceiverYear.SetMeAsReceiver()
        ucrReceiverYear.bUseFilteredData = False

        InitialiseRecentGrid()

        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorForCheckSummary.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetLabelText("New Column Name:")

        ' Trend Initialisation
        ucrSelectorForCheckSummary.SetParameter(New RParameter("data", 0))

        ucrReceiverYVar.SetParameter(New RParameter("y", 0))
        ucrReceiverYVar.Selector = ucrSelectorForCheckSummary
        ucrReceiverYVar.SetIncludedDataTypes({"numeric"}, True)
        ucrReceiverYVar.SetSelectorHeading("Numerics")
        ucrReceiverYVar.SetParameterIsString()
        ucrReceiverYVar.bWithQuotes = False

        ucrReceiverSecondYVar.SetParameter(New RParameter("yend"))
        ucrReceiverSecondYVar.Selector = ucrSelectorForCheckSummary
        ucrReceiverSecondYVar.SetIncludedDataTypes({"numeric"}, True)
        ucrReceiverSecondYVar.SetSelectorHeading("Numerics")
        ucrReceiverSecondYVar.bWithQuotes = False
        ucrReceiverSecondYVar.SetParameterIsString()

        ucrReceiverX.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrSelectorForCheckSummary
        ucrReceiverX.SetClimaticType("year")
        ucrReceiverX.bAutoFill = True
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrReceiverColourBy.SetParameter(New RParameter("colour", 2))
        ucrReceiverColourBy.Selector = ucrSelectorForCheckSummary
        ucrReceiverColourBy.SetIncludedDataTypes({"factor"})
        ucrReceiverColourBy.strSelectorHeading = "Factors"
        ucrReceiverColourBy.bWithQuotes = False
        ucrReceiverColourBy.SetParameterIsString()

        ucrReceiverFacetBy.SetParameter(New RParameter("", 1))
        ucrReceiverFacetBy.Selector = ucrSelectorForCheckSummary
        ucrReceiverFacetBy.SetIncludedDataTypes({"factor"})
        ucrReceiverFacetBy.strSelectorHeading = "Factors"
        ucrReceiverFacetBy.bWithQuotes = False
        ucrReceiverFacetBy.SetParameterIsString()
        ucrReceiverFacetBy.SetValuesToIgnore({"."})

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetColAll, strFacetRowAll, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrChkPoints.SetText("Add Points")
        ucrChkPoints.AddParameterPresentCondition(True, "geom_point")
        ucrChkPoints.AddParameterPresentCondition(False, "geom_point", False)

        ucrChkFirstAndLast.SetText("Label First and Last")
        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.AddParameterValuesCondition(True, "se", "TRUE")
        ucrChkWithSE.AddParameterValuesCondition(False, "se", "FALSE")

        ucrSave.SetPrefix("check_trend_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Store Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorForCheckSummary.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")

        ' Outliers Initialisation
        ucrVariablesAsFactorForCheckSummary.SetParameter(New RParameter("y", 0))
        ucrVariablesAsFactorForCheckSummary.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForCheckSummary.Selector = ucrSelectorForCheckSummary
        ucrVariablesAsFactorForCheckSummary.SetIncludedDataTypes({"numeric"}, True)
        ucrVariablesAsFactorForCheckSummary.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorForCheckSummary.SetParameterIsString()
        ucrVariablesAsFactorForCheckSummary.bWithQuotes = False

        ' X variable receiver
        ucrByFactorsReceiver.SetParameter(New RParameter("x", 1))
        ucrByFactorsReceiver.Selector = ucrSelectorForCheckSummary
        ucrByFactorsReceiver.SetParameterIsString()
        ucrByFactorsReceiver.bWithQuotes = False
        ucrByFactorsReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrByFactorsReceiver.bAddParameterIfEmpty = True
        ucrByFactorsReceiver.SetLinkedDisplayControl(lblByFactors)

        ' Fill by receiver
        ucrSecondFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondFactorReceiver.Selector = ucrSelectorForCheckSummary
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.strSelectorHeading = "Factors"
        ucrSecondFactorReceiver.SetParameterIsString()
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetLinkedDisplayControl(lblBySecondFactor)

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("TRUE")

        ucrNudOutlierCoefficient.SetParameter(New RParameter("coef", iNewPosition:=1))
        ucrNudOutlierCoefficient.DecimalPlaces = 1
        ucrNudOutlierCoefficient.Increment = 0.1
        ucrNudOutlierCoefficient.SetRDefault(1.5)
        ucrNudOutlierCoefficient.SetLinkedDisplayControl(lblOutlierCoefficient)

        ucrChkLabeloutliers.SetText("Label Outliers")
        ucrChkLabeloutliers.AddToLinkedControls(ucrReceiverLabelOutliers, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLabeloutliers.AddToLinkedControls({ucrNudOutlierCoefficient}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverLabelOutliers.SetParameter(New RParameter("label", 1))
        ucrReceiverLabelOutliers.SetParameterIsString()
        ucrReceiverLabelOutliers.Selector = ucrSelectorForCheckSummary
        ucrReceiverLabelOutliers.bWithQuotes = False
        ucrReceiverLabelOutliers.SetLinkedDisplayControl(lblVariable)

        ' Initialise added jitter function
        clsOutlierAddedJitterFunc.SetPackageName("ggplot2")
        clsOutlierAddedJitterFunc.SetRCommand("geom_jitter")
        clsOutlierAddedJitterFunc.AddParameter("height", 0, iPosition:=1)
        clsOutlierAddedJitterFunc.AddParameter("width", 0.2, iPosition:=2)

        Dim clsOutlierAddedJitterParam As New RParameter
        clsOutlierAddedJitterParam.SetArgumentName("add_jitter")
        clsOutlierAddedJitterParam.SetArgument(clsOutlierAddedJitterFunc)
        clsOutlierAddedJitterParam.Position = 3

        ucrChkAddPoints.SetParameter(clsOutlierAddedJitterParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkAddPoints.SetText("Add Points")
        ucrChkAddPoints.AddParameterPresentCondition(True, "add_jitter")
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

        'Broken stick regression is not implemented yet, so this option is disabled for now
        rdoBrokenStick.Enabled = False

        ' Legend
        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True},
            bNewLinkedAddRemoveParameter:=True,
            bNewLinkedHideIfParameterMissing:=True,
            bNewLinkedChangeToDefaultState:=True,
            objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        Dim dctLegendPosition As New Dictionary(Of String, String)
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ' Facet By
        ucrOutlier1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucrOutlier1stFactorReceiver.Selector = ucrSelectorForCheckSummary
        ucrOutlier1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrOutlier1stFactorReceiver.strSelectorHeading = "Factors"
        ucrOutlier1stFactorReceiver.bWithQuotes = False
        ucrOutlier1stFactorReceiver.SetParameterIsString()
        ucrOutlier1stFactorReceiver.SetValuesToIgnore({"."})
        ucrOutlier1stFactorReceiver.SetParameterPosition(1)
        ucrOutlier1stFactorReceiver.SetLinkedDisplayControl(lblOutlierFacetBy)

        ucrOutlierInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrOutlierInputStation.SetDropDownStyleAsNonEditable()

        strOutlierGeomParameterNames = {strOutlierFirstParameterName}

        UpdateVisiblePanels()
    End Sub

    Private Sub SetDefaults()
        strOutliersListLoadedForDataFrame = Nothing
        clsRecentIfElseFunction = New RFunction
        clsInnerIfElseFunction = New RFunction
        clsMaxFunction = New RFunction
        clsMaxYearAssign = New RFunction
        clsFactorFunction = New RFunction
        clsDummyFunction = New RFunction
        clsWithFunction = New RFunction

        ' Trend Defaults
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsGeomLine = New RFunction
        clsRaesFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsVarsFunction = New RFunction
        clsGeomPoint = New RFunction
        clsGeomSmoothFunction = New RFunction
        clsGeomHlineMean = New RFunction
        clsMeanFunction = New RFunction
        clsGeomHlineAesMean = New RFunction
        clsGroupByMeanFunction = New RFunction
        clsGeomTextFirstLast = New RFunction
        clsAesTextFirstLast = New RFunction
        clsGeomPointFirstLast = New RFunction
        clsGroupByFirstLast = New RFunction
        clsFilterFirstLastFunction = New RFunction
        clsSliceMinFirstLast = New RFunction
        clsSliceMaxFirstLast = New RFunction
        clsMaxSidePipeOperator = New ROperator
        clsBindRowsFirstLast = New RFunction
        clsUngroupFirstLast = New RFunction
        clsDistinctFirstLast = New RFunction
        clsFirstLastPipeOperator = New ROperator

        clsGeomSegmentFunction = New RFunction
        clsSegmentAesFunction = New RFunction
        clsGeomPoint2Function = New RFunction
        clsPoint2AesFunction = New RFunction

        clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)

        rdoRecent.Checked = True

        rdoMeanLine.Checked = False
        rdoFittedLine.Checked = False
        rdoBrokenStick.Checked = False
        ucrChkPoints.Checked = True
        ucrChkFirstAndLast.Checked = False
        ucrChkLabel.Checked = False
        ucrChkLabeloutliers.Checked = False

        ucrSelectorForCheckSummary.Reset()
        ucrSaveNewColumn.Reset()
        ucrSave.Reset()
        ucrInputStation.SetName(strNone)

        ' ... (Recent resets)
        If Not ucrSaveNewColumn.bUserTyped Then
            ucrSaveNewColumn.SetPrefix("recent")
        End If

        ResetRecentGridToDefaults()

        ' Recent Function Config
        clsMaxFunction.SetRCommand("max")
        clsMaxFunction.AddParameter("na.rm", "TRUE")

        clsMaxYearAssign.SetAssignToObject("max_year")
        clsMaxYearAssign.SetRCommand("max")
        clsMaxYearAssign.AddParameter("na.rm", "TRUE")

        clsInnerIfElseFunction.SetRCommand("ifelse")
        clsRecentIfElseFunction.SetRCommand("ifelse")

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("ordered", "TRUE")

        clsDummyFunction.SetRCommand("c")

        clsWithFunction.SetRCommand("with")

        ' Trend Function Config
        ' Initialize Plot Options Objects
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()

        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()

        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsOutlierLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsAsDate = New RFunction
        clsAsDate.SetRCommand("as.Date")
        clsAsDate.AddParameter("origin", """2015-12-31""", iPosition:=1)

        clsAsNumeric = New RFunction
        clsAsNumeric.SetRCommand("as.numeric")

        clsDatePeriodOperator = New ROperator
        clsDatePeriodOperator.SetOperation(" ")
        clsDatePeriodOperator.AddParameter("left", "1", iPosition:=0)
        clsDatePeriodOperator.AddParameter("right", "months", iPosition:=1)
        clsDatePeriodOperator.bSpaceAroundOperation = False
        clsDatePeriodOperator.bToScriptAsRString = True

        ' Scale Limits
        clsCLimitsYContinuous = New RFunction
        clsCLimitsYContinuous.SetRCommand("c")
        clsCLimitsYContinuous.AddParameter("lowerlimit", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsCLimitsYContinuous.AddParameter("upperlimit", "NA", bIncludeArgumentName:=False, iPosition:=1)

        clsYScalecontinuousFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYContinuous, iPosition:=3)

        clsCLimitsYDate = New RFunction
        clsCLimitsYDate.SetRCommand("c")
        clsCLimitsYDate.AddParameter("lowerlimit", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsCLimitsYDate.AddParameter("upperlimit", "NA", bIncludeArgumentName:=False, iPosition:=1)

        clsAsDateYLimit = New RFunction
        clsAsDateYLimit.SetRCommand("as.Date")
        clsAsDateYLimit.AddParameter("x", clsRFunctionParameter:=clsCLimitsYDate, iPosition:=0)
        clsAsDateYLimit.AddParameter("format", """%Y/%B/%d""", iPosition:=1)

        clsYScaleDateFunction.AddParameter("date_labels", """%d %b""", iPosition:=0)
        clsYScaleDateFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYDate, iPosition:=3)

        Dim clsPanelBackgroundElementRect As New RFunction
        Dim clsXElementLabels As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsYElementLabels As New RFunction
        Dim clsPanelGridMajorElementLine As New RFunction
        Dim clsPanelGridMinorElementLine As New RFunction
        Dim clsPanelBorderElementRect As New RFunction
        Dim clsPlotElementTitle As New RFunction
        Dim clsPlotElementSubTitle As New RFunction
        Dim clsPlotElementCaption As New RFunction

        If dctThemeFunctions.TryGetValue("panel.background", clsPanelBackgroundElementRect) Then
            clsPanelBackgroundElementRect.AddParameter("colour", """white""")
            clsPanelBackgroundElementRect.AddParameter("fill", """white""")
            clsPanelBackgroundElementRect.AddParameter("size", "0.5")
            clsPanelBackgroundElementRect.AddParameter("linetype", """solid""")
            clsThemeFunction.AddParameter("panel.background", clsRFunctionParameter:=clsPanelBackgroundElementRect)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.major", clsPanelGridMajorElementLine) Then
            clsPanelGridMajorElementLine.AddParameter("colour", """lightblue""")
            clsPanelGridMajorElementLine.AddParameter("linetype", """longdash""")
            clsPanelGridMajorElementLine.AddParameter("size", 1)
            clsThemeFunction.AddParameter("panel.grid.major", clsRFunctionParameter:=clsPanelGridMajorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.minor", clsPanelGridMinorElementLine) Then
            clsPanelGridMinorElementLine.AddParameter("colour", """lightblue""")
            clsPanelGridMinorElementLine.AddParameter("linetype", """longdash""")
            clsPanelGridMinorElementLine.AddParameter("size", 1)
            clsThemeFunction.AddParameter("panel.grid.minor", clsRFunctionParameter:=clsPanelGridMinorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.border", clsPanelBorderElementRect) Then
            clsPanelBorderElementRect.AddParameter("colour", """black""")
            clsPanelBorderElementRect.AddParameter("fill", """NA""")
            clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels) Then
            clsXElementLabels.AddParameter("angle", "90")
            clsXElementLabels.AddParameter("vjust", "0.4")
            clsXElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle) Then
            clsXElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.y", clsYElementLabels) Then
            clsYElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsYElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle) Then
            clsYElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("title", clsPlotElementTitle) Then
            clsPlotElementTitle.AddParameter("size", 20)
            clsThemeFunction.AddParameter("title", clsRFunctionParameter:=clsPlotElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("sub.title", clsPlotElementSubTitle) Then
            clsPlotElementSubTitle.AddParameter("size", 15)
            clsThemeFunction.AddParameter("plot.subtitle", clsRFunctionParameter:=clsPlotElementSubTitle)
        End If

        If dctThemeFunctions.TryGetValue("caption", clsPlotElementCaption) Then
            clsPlotElementCaption.AddParameter("size", 8)
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaption)
        End If

        bResetSubdialog = True
        bResetLineLayerSubdialog = True
        bResetOutlierLayerSubdialog = True

        clsPipeOperator.SetOperation("%>%")
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsGeomLine, iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")
        clsGeomLine.AddParameter("colour", """blue""")
        clsGeomLine.AddParameter("size", "0.8")

        clsGeomPoint.SetPackageName("ggplot2")
        clsGeomPoint.SetRCommand("geom_point")
        clsGeomPoint.AddParameter("colour", """red""")
        clsGeomPoint.AddParameter("size", "2")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        clsGeomSmoothFunction.SetPackageName("ggplot2")
        clsGeomSmoothFunction.SetRCommand("geom_smooth")
        clsGeomSmoothFunction.AddParameter("se", "FALSE")

        clsGeomHlineMean.SetPackageName("ggplot2")
        clsGeomHlineMean.SetRCommand("geom_hline")
        clsGeomHlineMean.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMean)
        clsGeomHlineMean.AddParameter("size", "1.5")

        clsGeomHlineAesMean.SetRCommand("aes")

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsAsDateMeanY.SetRCommand("as.Date")

        clsRoundMeanY.SetRCommand("round")
        clsRoundMeanY.AddParameter("digits", "1")

        clsPasteMeanY.SetRCommand("paste")

        clsFormatMeanY.SetRCommand("format")

        clsSubDialogGeomHlineMean.SetPackageName("ggplot2")
        clsSubDialogGeomHlineMean.SetRCommand("geom_hline")
        clsSubDialogGeomHlineAesMean.SetRCommand("aes")

        clsGeomTextLabelMeanLine.SetPackageName("ggplot2")
        clsGeomTextLabelMeanLine.SetRCommand("geom_text")

        clsGroupByFirstLast.SetPackageName("dplyr")
        clsGroupByFirstLast.SetRCommand("group_by")

        clsGroupByMeanFunction.SetPackageName("dplyr")
        clsGroupByMeanFunction.SetRCommand("group_by")

        clsFilterFirstLastFunction.SetPackageName("dplyr")
        clsFilterFirstLastFunction.SetRCommand("filter")

        clsSliceMinFirstLast.SetPackageName("dplyr")
        clsSliceMinFirstLast.SetRCommand("slice_min")
        clsSliceMinFirstLast.AddParameter("n", "1", iPosition:=1)
        clsSliceMinFirstLast.AddParameter("with_ties", "FALSE", iPosition:=2)

        clsSliceMaxFirstLast.SetPackageName("dplyr")
        clsSliceMaxFirstLast.SetRCommand("slice_max")
        clsSliceMaxFirstLast.AddParameter("n", "1", iPosition:=1)
        clsSliceMaxFirstLast.AddParameter("with_ties", "FALSE", iPosition:=2)

        clsMaxSidePipeOperator.SetOperation("%>%")
        clsMaxSidePipeOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterFirstLastFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsMaxSidePipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFirstLast, iPosition:=2, bIncludeArgumentName:=False)
        clsMaxSidePipeOperator.AddParameter("slice_max", clsRFunctionParameter:=clsSliceMaxFirstLast, iPosition:=3, bIncludeArgumentName:=False)

        clsBindRowsFirstLast.SetPackageName("dplyr")
        clsBindRowsFirstLast.SetRCommand("bind_rows")
        clsBindRowsFirstLast.AddParameter("y", clsROperatorParameter:=clsMaxSidePipeOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsUngroupFirstLast.SetPackageName("dplyr")
        clsUngroupFirstLast.SetRCommand("ungroup")

        clsDistinctFirstLast.SetPackageName("dplyr")
        clsDistinctFirstLast.SetRCommand("distinct")

        clsFirstLastPipeOperator.SetOperation("%>%")
        clsFirstLastPipeOperator.SetAssignTo("first_last")
        clsFirstLastPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterFirstLastFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsFirstLastPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFirstLast, iPosition:=2, bIncludeArgumentName:=False)
        clsFirstLastPipeOperator.AddParameter("slice_min", clsRFunctionParameter:=clsSliceMinFirstLast, iPosition:=3, bIncludeArgumentName:=False)
        clsFirstLastPipeOperator.AddParameter("bind_rows", clsRFunctionParameter:=clsBindRowsFirstLast, iPosition:=4, bIncludeArgumentName:=False)
        clsFirstLastPipeOperator.AddParameter("ungroup", clsRFunctionParameter:=clsUngroupFirstLast, iPosition:=5, bIncludeArgumentName:=False)
        clsFirstLastPipeOperator.AddParameter("distinct", clsRFunctionParameter:=clsDistinctFirstLast, iPosition:=6, bIncludeArgumentName:=False)

        clsGeomTextFirstLast.SetPackageName("ggplot2")
        clsGeomTextFirstLast.SetRCommand("geom_text")
        clsGeomTextFirstLast.AddParameter("data", "first_last", iPosition:=0)
        clsGeomTextFirstLast.AddParameter("mapping", clsRFunctionParameter:=clsAesTextFirstLast)
        clsGeomTextFirstLast.AddParameter("vjust", "-0.6")
        clsGeomTextFirstLast.AddParameter("colour", """black""")
        clsGeomTextFirstLast.AddParameter("na.rm", "TRUE")

        clsGeomPointFirstLast.SetPackageName("ggplot2")
        clsGeomPointFirstLast.SetRCommand("geom_point")
        clsGeomPointFirstLast.AddParameter("data", "first_last", iPosition:=0)
        clsGeomPointFirstLast.AddParameter("shape", "18") ' Diamond shape
        clsGeomPointFirstLast.AddParameter("size", "3")
        clsGeomPointFirstLast.AddParameter("colour", """darkred""")
        clsGeomPointFirstLast.AddParameter("na.rm", "TRUE")

        clsAesTextFirstLast.SetRCommand("aes")

        clsGeomSegmentFunction.SetPackageName("ggplot2")
        clsGeomSegmentFunction.SetRCommand("geom_segment")
        clsGeomSegmentFunction.AddParameter("linewidth", "0.8")
        clsGeomSegmentFunction.AddParameter("lty", "2")

        clsSegmentAesFunction.SetRCommand("aes")

        ' ── Outliers defaults ──
        clsOutlierBaseOperator = New ROperator
        clsOutlierRggplotFunction = New RFunction
        clsOutlierRaesFunction = New RFunction
        clsOutlierBoxplotFunction = New RFunction

        clsOutlierAddedJitterFunc.Clear()
        clsOutlierAddedJitterFunc.SetPackageName("ggplot2")
        clsOutlierAddedJitterFunc.SetRCommand("geom_jitter")
        clsOutlierAddedJitterFunc.AddParameter("height", 0, iPosition:=1)
        clsOutlierAddedJitterFunc.AddParameter("width", 0.2, iPosition:=2)

        clsOutlierFacetVariablesOperator = New ROperator("~")
        clsOutlierFacetVariablesOperator.bForceIncludeOperation = True
        clsOutlierFacetVariablesOperator.bBrackets = False

        clsOutlierBoxplotFunction.SetPackageName("ggplot2")
        clsOutlierBoxplotFunction.SetRCommand("geom_boxplot")
        clsOutlierBoxplotFunction.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)

        clsOutlierBaseOperator.SetOperation("+")
        clsOutlierBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsOutlierRggplotFunction, iPosition:=0)
        clsOutlierBaseOperator.AddParameter(strOutlierFirstParameterName, clsRFunctionParameter:=clsOutlierBoxplotFunction, iPosition:=2)

        clsOutlierRggplotFunction.SetPackageName("ggplot2")
        clsOutlierRggplotFunction.SetRCommand("ggplot")
        clsOutlierRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsOutlierRaesFunction, iPosition:=1)
        clsOutlierRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsOutlierRaesFunction, iPosition:=1)

        clsOutlierRaesFunction.SetPackageName("ggplot2")
        clsOutlierRaesFunction.SetRCommand("aes")

        ' Plot options objects (clone from GgplotDefaults)
        clsOutlierLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsOutlierXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsOutlierYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsOutlierXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsOutlierYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsOutlierAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsOutlierScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction.Clone()
        clsOutlierScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction.Clone()
        clsOutlierScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsOutlierScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsOutlierCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsOutlierCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsOutlierXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsOutlierYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsOutlierThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctOutlierThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsOutlierBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())

        ' Trend
        clsRowVarsFunction = New RFunction
        clsRowVarsFunction.SetPackageName("ggplot2")
        clsRowVarsFunction.SetRCommand("vars")

        clsColVarsFunction = New RFunction
        clsColVarsFunction.SetPackageName("ggplot2")
        clsColVarsFunction.SetRCommand("vars")

        ' Outlier
        clsOutlierRowVarsFunction = New RFunction
        clsOutlierRowVarsFunction.SetPackageName("ggplot2")
        clsOutlierRowVarsFunction.SetRCommand("vars")

        clsOutlierColVarsFunction = New RFunction
        clsOutlierColVarsFunction.SetPackageName("ggplot2")
        clsOutlierColVarsFunction.SetRCommand("vars")

        ' Outlier Labeling
        clsOutlierLabelSummaryFunction = New RFunction
        clsOutlierAesLabelFunction = New RFunction
        clsOutlierRoundFunction = New RFunction
        clsOutlierLabelAfterFunction = New RFunction
        clsOutlierBoxplotStatFunction = New RFunction
        clsOutlierIfFunction = New RFunction
        clsOutlierLengthFunction = New RFunction
        clsOutlierOpenBraquetOperator = New ROperator
        clsOutlierAssigneOperator = New ROperator
        clsOutlierDollardOperator = New ROperator
        clsOutlierSemiCommatOperator = New ROperator
        clsOutlierSpaceOperator = New ROperator
        clsOutlierEqualOperator = New ROperator
        clsOutlierBraquetOperator = New ROperator

        clsOutlierGroupbyFunction = New RFunction
        clsOutlierBoxplotStat2Function = New RFunction
        clsOutlierDollarSignOperator = New ROperator
        clsOutlierInOperator = New ROperator
        clsOutlierMutateLabelFunction = New RFunction
        clsOutlierFilterElement2Function = New RFunction
        clsOutlierUngroupFunction = New RFunction
        clsOutlierAsFactor2Function = New RFunction
        clsOutlierMutate2Function = New RFunction
        clsOutlierPipeLabelOperator = New ROperator
        clsOutlierRaes2Function = New RFunction
        clsOutlierPositionNudgeFunction = New RFunction
        clsOutlierGeomTextFunction = New RFunction

        clsOutlierLabelSummaryFunction.SetPackageName("ggplot2")
        clsOutlierLabelSummaryFunction.SetRCommand("stat_summary")
        clsOutlierLabelSummaryFunction.AddParameter("x", clsRFunctionParameter:=clsOutlierAesLabelFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierLabelSummaryFunction.AddParameter("geom", Chr(34) & "text" & Chr(34), iPosition:=1)
        clsOutlierLabelSummaryFunction.AddParameter("fun", clsROperatorParameter:=clsOutlierOpenBraquetOperator, iPosition:=2)
        clsOutlierLabelSummaryFunction.AddParameter("hjust", "-0.2", iPosition:=3)

        clsOutlierOpenBraquetOperator.SetOperation("{")
        clsOutlierOpenBraquetOperator.AddParameter("left", "\ (y)", iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierOpenBraquetOperator.AddParameter("right", clsROperatorParameter:=clsOutlierAssigneOperator, bIncludeArgumentName:=False, iPosition:=1)

        clsOutlierAssigneOperator.SetOperation("<-")
        clsOutlierAssigneOperator.AddParameter("left", "o", iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierAssigneOperator.AddParameter("right", clsROperatorParameter:=clsOutlierDollardOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierDollardOperator.SetOperation("$")
        clsOutlierDollardOperator.AddParameter("left", clsRFunctionParameter:=clsOutlierBoxplotStatFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierDollardOperator.AddParameter("right", clsROperatorParameter:=clsOutlierSemiCommatOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierBoxplotStatFunction.SetPackageName("grDevices")
        clsOutlierBoxplotStatFunction.SetRCommand("boxplot.stats")
        clsOutlierBoxplotStatFunction.AddParameter("x", "y", iPosition:=0, bIncludeArgumentName:=False)

        clsOutlierSemiCommatOperator.SetOperation(";")
        clsOutlierSemiCommatOperator.AddParameter("left", "out", iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierSemiCommatOperator.AddParameter("right", clsROperatorParameter:=clsOutlierSpaceOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierSpaceOperator.SetOperation("")
        clsOutlierSpaceOperator.AddParameter("left", clsRFunctionParameter:=clsOutlierIfFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierSpaceOperator.AddParameter("right", clsROperatorParameter:=clsOutlierBraquetOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierIfFunction.SetRCommand("if")
        clsOutlierIfFunction.AddParameter("x", clsROperatorParameter:=clsOutlierEqualOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsOutlierEqualOperator.SetOperation("==")
        clsOutlierEqualOperator.AddParameter("left", clsRFunctionParameter:=clsOutlierLengthFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierEqualOperator.AddParameter("right", "0", iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierLengthFunction.SetRCommand("length")
        clsOutlierLengthFunction.AddParameter("x", "o", iPosition:=0, bIncludeArgumentName:=False)

        clsOutlierBraquetOperator.SetOperation("}")
        clsOutlierBraquetOperator.AddParameter("left", "NaN else o", iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierBraquetOperator.AddParameter("right", "", iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierAesLabelFunction.SetRCommand("aes")
        clsOutlierAesLabelFunction.AddParameter("label", clsRFunctionParameter:=clsOutlierRoundFunction, iPosition:=0)

        clsOutlierRoundFunction.SetRCommand("round")
        clsOutlierRoundFunction.AddParameter("x", clsRFunctionParameter:=clsOutlierLabelAfterFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierRoundFunction.AddParameter("y", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierLabelAfterFunction.SetPackageName("ggplot2")
        clsOutlierLabelAfterFunction.SetRCommand("after_stat")
        clsOutlierLabelAfterFunction.AddParameter("x", "y", iPosition:=0, bIncludeArgumentName:=False)

        clsOutlierGroupbyFunction.SetPackageName("dplyr")
        clsOutlierGroupbyFunction.SetRCommand("group_by")

        clsOutlierBoxplotStat2Function.SetPackageName("grDevices")
        clsOutlierBoxplotStat2Function.SetRCommand("boxplot.stats")

        clsOutlierDollarSignOperator.SetOperation("$")
        clsOutlierDollarSignOperator.AddParameter("x", clsRFunctionParameter:=clsOutlierBoxplotStat2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsOutlierDollarSignOperator.AddParameter("y", "out", iPosition:=1, bIncludeArgumentName:=False)
        clsOutlierDollarSignOperator.bSpaceAroundOperation = False

        clsOutlierInOperator.SetOperation("%in%")
        clsOutlierInOperator.AddParameter("y", clsROperatorParameter:=clsOutlierDollarSignOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsOutlierMutateLabelFunction.SetPackageName("dplyr")
        clsOutlierMutateLabelFunction.SetRCommand("mutate")
        clsOutlierMutateLabelFunction.AddParameter("is_out", clsROperatorParameter:=clsOutlierInOperator, iPosition:=0)

        clsOutlierFilterElement2Function.SetPackageName("dplyr")
        clsOutlierFilterElement2Function.SetRCommand("filter")
        clsOutlierFilterElement2Function.AddParameter("x", "is_out", iPosition:=0, bIncludeArgumentName:=False)

        clsOutlierUngroupFunction.SetPackageName("dplyr")
        clsOutlierUngroupFunction.SetRCommand("ungroup")

        clsOutlierAsFactor2Function.SetPackageName("instatExtras")
        clsOutlierAsFactor2Function.SetRCommand("make_factor")

        clsOutlierMutate2Function.SetPackageName("dplyr")
        clsOutlierMutate2Function.SetRCommand("mutate")

        clsOutlierPipeLabelOperator.SetOperation("%>%")
        clsOutlierPipeLabelOperator.SetAssignTo("outliers")
        clsOutlierPipeLabelOperator.AddParameter("group_by", clsRFunctionParameter:=clsOutlierGroupbyFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsOutlierPipeLabelOperator.AddParameter("mutate", clsRFunctionParameter:=clsOutlierMutateLabelFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsOutlierPipeLabelOperator.AddParameter("filter", clsRFunctionParameter:=clsOutlierFilterElement2Function, iPosition:=3, bIncludeArgumentName:=False)
        clsOutlierPipeLabelOperator.AddParameter("ungroup", clsRFunctionParameter:=clsOutlierUngroupFunction, iPosition:=4, bIncludeArgumentName:=False)

        clsOutlierRaes2Function.SetPackageName("ggplot2")
        clsOutlierRaes2Function.SetRCommand("aes")

        clsOutlierPositionNudgeFunction.SetPackageName("ggplot2")
        clsOutlierPositionNudgeFunction.SetRCommand("position_nudge")
        clsOutlierPositionNudgeFunction.AddParameter("x", "0.05", iPosition:=0)

        clsOutlierGeomTextFunction.SetPackageName("ggplot2")
        clsOutlierGeomTextFunction.SetRCommand("geom_text")
        clsOutlierGeomTextFunction.AddParameter("data", "outliers", iPosition:=0)
        clsOutlierGeomTextFunction.AddParameter("x", clsRFunctionParameter:=clsOutlierRaes2Function, iPosition:=1, bIncludeArgumentName:=False)
        clsOutlierGeomTextFunction.AddParameter("hjust", "-0.2", iPosition:=2)
        clsOutlierGeomTextFunction.AddParameter("position", clsRFunctionParameter:=clsOutlierPositionNudgeFunction, iPosition:=3)
        clsOutlierGeomTextFunction.AddParameter("size", "3", iPosition:=4)

        UpdateRecentRCode()
        UpdateTrendRCode()

        UpdateVisiblePanels()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.SetRCode(clsDummyFunction, bReset)
        ucrSaveNewColumn.SetRCode(clsFactorFunction, bReset)

        ' Trend Controls
        ucrSelectorForCheckSummary.SetRCode(clsPipeOperator, bReset)

        ucrReceiverYVar.AddAdditionalCodeParameterPair(clsAsDate, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverYVar.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrReceiverYVar.SetRCode(clsRaesFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrReceiverX.SetRCode(clsAsNumeric, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunction, bReset)

        ' ── Outliers Controls ──
        ucrVariablesAsFactorForCheckSummary.SetRCode(clsOutlierRaesFunction, bReset)
        ucrByFactorsReceiver.SetRCode(clsOutlierRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsOutlierRaesFunction, bReset)
        ucrChkVarWidth.SetRCode(clsOutlierBoxplotFunction, bReset)
        ucrNudOutlierCoefficient.SetRCode(clsOutlierBoxplotFunction, bReset)
        ucrChkAddPoints.SetRCode(clsOutlierBaseOperator, bReset)
        ucrNudJitter.SetRCode(clsOutlierAddedJitterFunc, bReset)
        ucrNudTransparency.SetRCode(clsOutlierAddedJitterFunc, bReset)
        ucrChkLabeloutliers.SetRCode(clsOutlierBaseOperator, bReset)
        ucrReceiverLabelOutliers.SetRCode(clsOutlierRaes2Function, bReset)

        ucrChkLegend.SetRCode(clsOutlierThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsOutlierThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrOutlier1stFactorReceiver.SetRCode(clsOutlierFacetVariablesOperator, bReset)

        If bReset Then
            AddRemoveFacets()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles UcrBaseCheckSummary.ClickReset
        bReset = True
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        UpdateVisiblePanels()

        If rdoRecent.Checked Then
            ucrReceiverYear.SetMeAsReceiver()
            UpdateRecentRCode()
        ElseIf rdoTrend.Checked Then
            ucrReceiverYVar.SetMeAsReceiver()
            UpdateTrendRCode()
        ElseIf rdoOutliers.Checked Then
            AutoFillRecentColumnForOutliers()
            UpdateOutliersRCode()
        End If
        TestOKEnabled()
    End Sub

    Private Sub UpdateVisiblePanels()
        Dim bRecent As Boolean = rdoRecent.Checked
        Dim bTrend As Boolean = rdoTrend.Checked
        Dim bOutliers As Boolean = rdoOutliers.Checked

        pnlRecent.Visible = bRecent
        pnlTrend.Visible = bTrend
        pnlOutliers.Visible = bOutliers

        ucrSaveNewColumn.Visible = bRecent

        ucrChkPoints.Visible = bTrend
        ucrSave.Visible = bTrend OrElse bOutliers
        cmdPlotOptions.Visible = bTrend OrElse bOutliers

        ' Rebuild the split-button dropdown to match the active tab
        contextMenuStripPlotOptions.Items.Clear()
        contextMenuStripPlotOptions.Items.Add(PlotOptionsToolStripMenuItem)
        If bTrend Then
            contextMenuStripPlotOptions.Items.Add(toolStripMenuItemLineOptions)
            contextMenuStripPlotOptions.Items.Add(toolStripMenuItemPointOption)
        ElseIf bOutliers Then
            contextMenuStripPlotOptions.Items.Add(toolStripMenuItemOutlierBoxplotOptions)
            contextMenuStripPlotOptions.Items.Add(toolStripMenuItemOutlierJitterOptions)
            toolStripMenuItemOutlierTextOptions.Enabled = ucrChkLabeloutliers.Checked
            contextMenuStripPlotOptions.Items.Add(toolStripMenuItemOutlierTextOptions)
        End If
        ucrChkFirstAndLast.Visible = bTrend
        AddLineGroupbox.Visible = bTrend

        ucrChkLabel.Visible = False
        ucrChkAddPoints.Visible = bOutliers
        ucrChkLegend.Visible = bOutliers
        ucrChkLabeloutliers.Visible = bOutliers
        lblOutlierFacetBy.Visible = bOutliers
        ucrOutlier1stFactorReceiver.Visible = bOutliers
        ucrOutlierInputStation.Visible = bOutliers

        ucrNudJitter.Visible = bOutliers AndAlso ucrChkAddPoints.Checked
        ucrNudTransparency.Visible = bOutliers AndAlso ucrChkAddPoints.Checked
        ucrInputLegendPosition.Visible = bOutliers AndAlso ucrChkLegend.Checked
        ucrNudOutlierCoefficient.Visible = bOutliers AndAlso ucrChkLabeloutliers.Checked
        ucrReceiverLabelOutliers.Visible = bOutliers AndAlso ucrChkLabeloutliers.Checked

        If bRecent Then
            ucrBase.clsRsyntax.iCallType = 0 ' Data modification
        Else
            ucrBase.clsRsyntax.iCallType = 3 ' Graphing
        End If

        If bTrend Then
            ucrSave.SetPrefix("check_trend_graph")
            ucrSave.SetRCode(clsBaseOperator, False)
        ElseIf bOutliers Then
            ucrSave.SetPrefix("outlier_boxplot")
            ucrSave.SetRCode(clsOutlierBaseOperator, False)
        End If

        If Not bRecent Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMaxYearAssign)
        End If

        If Not bTrend Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFirstLastPipeOperator)
        End If
        If Not bOutliers Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsOutlierPipeLabelOperator)
        End If

        If bOutliers Then
            ucrBase.clsRsyntax.SetBaseROperator(clsOutlierBaseOperator)
        ElseIf Not bRecent Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDummyFunction)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoRecent.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverYear.IsEmpty AndAlso ucrSaveNewColumn.IsComplete() AndAlso IsRecentGridValid())
        ElseIf rdoTrend.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverYVar.IsEmpty AndAlso Not ucrReceiverX.IsEmpty AndAlso ucrSave.IsComplete())
        ElseIf rdoOutliers.Checked Then
            ucrBase.OKEnabled(Not ucrVariablesAsFactorForCheckSummary.IsEmpty AndAlso Not ucrByFactorsReceiver.IsEmpty AndAlso ucrSave.IsComplete())
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged,
        ucrReceiverYVar.ControlContentsChanged, ucrReceiverSecondYVar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrReceiverColourBy.ControlContentsChanged,
        ucrReceiverFacetBy.ControlContentsChanged, ucrChkPoints.ControlContentsChanged, ucrChkFirstAndLast.ControlContentsChanged,
        ucrChkWithSE.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrVariablesAsFactorForCheckSummary.ControlContentsChanged,
        ucrByFactorsReceiver.ControlContentsChanged, ucrSecondFactorReceiver.ControlContentsChanged, ucrChkVarWidth.ControlContentsChanged,
        ucrNudOutlierCoefficient.ControlContentsChanged, ucrChkAddPoints.ControlContentsChanged, ucrChkLabeloutliers.ControlContentsChanged, ucrReceiverLabelOutliers.ControlContentsChanged,
        ucrNudJitter.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged, ucrOutlier1stFactorReceiver.ControlContentsChanged

        If rdoRecent.Checked Then
            UpdateRecentRCode()
        ElseIf rdoTrend.Checked Then
            UpdateTrendRCode()
        ElseIf rdoOutliers.Checked Then
            UpdateOutliersRCode()
        End If
        ' Keep Text Options item enabled only while Label Outliers is checked
        If rdoOutliers.Checked Then
            toolStripMenuItemOutlierTextOptions.Enabled = ucrChkLabeloutliers.Checked
        End If
        TestOKEnabled()
    End Sub

    Private Sub UpdateOutliersRCode()
        If Not rdoOutliers.Checked Then Exit Sub

        If ucrVariablesAsFactorForCheckSummary.IsEmpty OrElse
           ucrByFactorsReceiver.IsEmpty Then
            ucrBase.clsRsyntax.SetBaseROperator(Nothing)
            Exit Sub
        End If

        ' Attach data to ggplot
        Dim clsDataFrameParam As RFunction = ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame
        clsOutlierRggplotFunction.RemoveParameterByName("data")
        clsOutlierRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0)

        ' Outlier visibility and coefficient
        If ucrChkAddPoints.Checked OrElse Not ucrChkLabeloutliers.Checked Then
            clsOutlierBoxplotFunction.AddParameter("outlier.shape", "NA", iPosition:=2)
        Else
            clsOutlierBoxplotFunction.RemoveParameterByName("outlier.shape")
        End If

        If ucrChkLabeloutliers.Checked AndAlso Not ucrNudOutlierCoefficient.IsEmpty Then
            clsOutlierBoxplotFunction.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=2)
        Else
            clsOutlierBoxplotFunction.RemoveParameterByName("coef")
        End If

        AddRemoveOutlierTheme()
        AddRemoveOutlierFacets()

        ' Plot options (labs, scales etc.)
        Dim bAddLabs As Boolean = False
        If clsOutlierLabsFunction IsNot Nothing Then
            For Each clsParam As RParameter In clsOutlierLabsFunction.clsParameters
                If clsParam.strArgumentValue <> Chr(34) & Chr(34) Then
                    bAddLabs = True
                    Exit For
                End If
            Next
        End If

        If bAddLabs Then
            clsOutlierBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsOutlierLabsFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("labs")
        End If

        If clsOutlierXlabsFunction IsNot Nothing AndAlso clsOutlierXlabsFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsOutlierXlabsFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("xlab")
        End If
        If clsOutlierYlabFunction IsNot Nothing AndAlso clsOutlierYlabFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("ylab", clsRFunctionParameter:=clsOutlierYlabFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("ylab")
        End If

        If clsOutlierXScaleContinuousFunction IsNot Nothing AndAlso clsOutlierXScaleContinuousFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("scale_x_continuous", clsRFunctionParameter:=clsOutlierXScaleContinuousFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_x_continuous")
        End If
        If clsOutlierYScaleContinuousFunction IsNot Nothing AndAlso clsOutlierYScaleContinuousFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsOutlierYScaleContinuousFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_y_continuous")
        End If

        If clsOutlierXScaleDateFunction IsNot Nothing AndAlso clsOutlierXScaleDateFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("scale_x_date", clsRFunctionParameter:=clsOutlierXScaleDateFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_x_date")
        End If
        If clsOutlierYScaleDateFunction IsNot Nothing AndAlso clsOutlierYScaleDateFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("scale_y_date", clsRFunctionParameter:=clsOutlierYScaleDateFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_y_date")
        End If

        If clsOutlierScaleFillViridisFunction IsNot Nothing AndAlso clsOutlierScaleFillViridisFunction.iParameterCount > 1 Then
            clsOutlierBaseOperator.AddParameter("scale_fill_viridis", clsRFunctionParameter:=clsOutlierScaleFillViridisFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_fill_viridis")
        End If
        If clsOutlierScaleColourViridisFunction IsNot Nothing AndAlso clsOutlierScaleColourViridisFunction.iParameterCount > 1 Then
            clsOutlierBaseOperator.AddParameter("scale_colour_viridis", clsRFunctionParameter:=clsOutlierScaleColourViridisFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("scale_colour_viridis")
        End If

        If clsOutlierAnnotateFunction IsNot Nothing AndAlso clsOutlierAnnotateFunction.iParameterCount > 1 Then
            clsOutlierBaseOperator.AddParameter("annotate", clsRFunctionParameter:=clsOutlierAnnotateFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("annotate")
        End If

        clsOutlierBaseOperator.AddParameter(strOutlierFirstParameterName,
            clsRFunctionParameter:=clsOutlierBoxplotFunction, iPosition:=2)

        AddOutlierLabelFunctions()

        ucrBase.clsRsyntax.SetBaseROperator(clsOutlierBaseOperator)
    End Sub

    Private Function IsLabelOutliersVariableUsable() As Boolean
        If ucrReceiverLabelOutliers.IsEmpty Then Return False

        Dim strLabelVar As String = ucrReceiverLabelOutliers.GetVariableNames(False).Trim()
        For Each clsParam As RParameter In ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame.clsParameters
            If clsParam.strArgumentName = "measure.vars" Then
                If clsParam.strArgumentValue.Contains(Chr(34) & strLabelVar & Chr(34)) Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub AddOutlierLabelFunctions()
        ' Update the stat_summary function to handle Dates
        clsOutlierBoxplotStatFunction.RemoveParameterByName("x")
        clsOutlierBoxplotStatFunction.AddParameter("x", "as.numeric(y)", iPosition:=0, bIncludeArgumentName:=False)

        If ucrChkLabeloutliers.Checked Then
            If Not ucrNudOutlierCoefficient.IsEmpty Then
                clsOutlierBoxplotStatFunction.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=1)
                clsOutlierBoxplotStat2Function.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=1)
            Else
                clsOutlierBoxplotStatFunction.RemoveParameterByName("coef")
                clsOutlierBoxplotStat2Function.RemoveParameterByName("coef")
            End If

            If IsLabelOutliersVariableUsable() Then
                Dim clsDataFrameParam As RFunction = ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame
                clsOutlierPipeLabelOperator.RemoveParameterByName("data")
                clsOutlierPipeLabelOperator.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)

                ucrBase.clsRsyntax.AddToBeforeCodes(clsOutlierPipeLabelOperator, iPosition:=0)

                ' Update group_by and mutate steps for labeling
                clsOutlierGroupbyFunction.ClearParameters()
                Dim lstGroupByVars As New List(Of String)
                If Not ucrByFactorsReceiver.IsEmpty Then
                    Dim strVar As String = ucrByFactorsReceiver.GetVariableNames(False)
                    If Not lstGroupByVars.Contains(strVar) Then lstGroupByVars.Add(strVar)
                End If
                If Not ucrSecondFactorReceiver.IsEmpty Then
                    Dim strVar As String = ucrSecondFactorReceiver.GetVariableNames(False)
                    If Not lstGroupByVars.Contains(strVar) Then lstGroupByVars.Add(strVar)
                End If
                If Not ucrOutlier1stFactorReceiver.IsEmpty Then
                    Dim strVar As String = ucrOutlier1stFactorReceiver.GetVariableNames(False)
                    If Not lstGroupByVars.Contains(strVar) Then lstGroupByVars.Add(strVar)
                End If

                For i As Integer = 0 To lstGroupByVars.Count - 1
                    clsOutlierGroupbyFunction.AddParameter("var" & i, lstGroupByVars(i), iPosition:=i, bIncludeArgumentName:=False)
                Next

                ' Numeric variable for outlier calculation
                Dim strNumVar As String = ucrVariablesAsFactorForCheckSummary.GetVariableNames(False)
                ' Always wrap in as.numeric for outlier calculation to support Dates and avoid binary + errors
                Dim strNumVarForStats As String = "as.numeric(" & strNumVar & ")"

                ' Ensure boxplot.stats has the numeric variable
                clsOutlierBoxplotStat2Function.ClearParameters()
                clsOutlierBoxplotStat2Function.AddParameter("x", strNumVarForStats, iPosition:=0, bIncludeArgumentName:=False)
                If Not ucrNudOutlierCoefficient.IsEmpty Then
                    clsOutlierBoxplotStat2Function.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=1)
                End If

                ' Update the is_out comparison
                clsOutlierInOperator.ClearParameters()
                clsOutlierInOperator.AddParameter("left", strNumVarForStats, iPosition:=0, bIncludeArgumentName:=False)
                clsOutlierInOperator.AddParameter("right", clsROperatorParameter:=clsOutlierDollarSignOperator, iPosition:=1, bIncludeArgumentName:=False)

                Dim strLabelVar As String = ucrReceiverLabelOutliers.GetVariableNames(False)

                clsOutlierRaes2Function.RemoveParameterByName("label")
                clsOutlierRaes2Function.AddParameter("label", strLabelVar)

                clsOutlierBaseOperator.RemoveParameterByName("label")
                clsOutlierBaseOperator.AddParameter("label_geom", clsRFunctionParameter:=clsOutlierGeomTextFunction, bIncludeArgumentName:=False)
            Else
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsOutlierPipeLabelOperator)
                clsOutlierBaseOperator.RemoveParameterByName("label_geom")
                clsOutlierBaseOperator.AddParameter("label", clsRFunctionParameter:=clsOutlierLabelSummaryFunction, bIncludeArgumentName:=False)
            End If
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsOutlierPipeLabelOperator)
            clsOutlierBaseOperator.RemoveParameterByName("label_geom")
            clsOutlierBaseOperator.RemoveParameterByName("label")
        End If
    End Sub

    Private Sub TrendOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMeanLine.CheckedChanged,
        rdoFittedLine.CheckedChanged, rdoBrokenStick.CheckedChanged

        If rdoTrend.Checked Then
            UpdateTrendRCode()
        End If
    End Sub

    Private Sub InitialiseRecentGrid()
        grdRecent.Worksheets.Clear()
        grdRecentWorkSheet = grdRecent.CreateWorksheet("Recent")
        grdRecent.AddWorksheet(grdRecentWorkSheet)
        grdRecent.CurrentWorksheet = grdRecentWorkSheet
        grdRecentWorkSheet.SetSettings(WorksheetSettings.View_ShowRowHeader, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdRecentWorkSheet.SetSettings(WorksheetSettings.Edit_Readonly, False)
        grdRecentWorkSheet.SelectionForwardDirection = SelectionForwardDirection.Down

        grdRecentWorkSheet.Resize(3, 3)
        grdRecentWorkSheet.ColumnHeaders(0).Text = "Ordinal"
        grdRecentWorkSheet.ColumnHeaders(1).Text = "Label"
        grdRecentWorkSheet.ColumnHeaders(2).Text = "years"
        grdRecentWorkSheet.ColumnHeaders(0).Width = 50
        grdRecentWorkSheet.ColumnHeaders(1).Width = 120
        grdRecentWorkSheet.ColumnHeaders(2).Width = 70

        ResetRecentGridToDefaults()
    End Sub

    Private Sub ResetRecentGridToDefaults()
        If grdRecentWorkSheet Is Nothing Then
            Exit Sub
        End If

        bUpdatingRecentGrid = True
        Try
            grdRecentWorkSheet(0, 0) = 3
            grdRecentWorkSheet(1, 0) = 2
            grdRecentWorkSheet(2, 0) = 1

            grdRecentWorkSheet(0, 1) = "last10"
            grdRecentWorkSheet(1, 1) = "to30"
            grdRecentWorkSheet(2, 1) = "older"

            grdRecentWorkSheet(0, 2) = 10
            grdRecentWorkSheet(1, 2) = 30
            grdRecentWorkSheet(2, 2) = ""

            grdRecentWorkSheet.SetRangeDataFormat(0, 0, 3, 3, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)

            For iRow As Integer = 0 To 2
                grdRecentWorkSheet.GetCell(iRow, 0).IsReadOnly = True
            Next
            grdRecentWorkSheet.GetCell(2, 2).IsReadOnly = True
        Finally
            bUpdatingRecentGrid = False
        End Try
    End Sub

    Private Sub grdRecentWorkSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdRecentWorkSheet.BeforeCellEdit
        If (e.Cell.Column = 0) OrElse (e.Cell.Row = 2 AndAlso e.Cell.Column = 2) Then
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdRecentWorkSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdRecentWorkSheet.AfterCellEdit
        If bUpdatingRecentGrid Then
            Exit Sub
        End If
        If rdoRecent.Checked Then
            UpdateRecentRCode()
            TestOKEnabled()
        End If
    End Sub

    Private Function GetRecentGridValue(iRow As Integer, iCol As Integer) As String
        If grdRecentWorkSheet Is Nothing Then
            Return ""
        End If
        Dim obj As Object = grdRecentWorkSheet(iRow, iCol)
        If obj Is Nothing Then
            Return ""
        End If
        Return obj.ToString().Trim()
    End Function

    Private Function IsRecentGridValid() As Boolean
        Dim strLabel1 As String = GetRecentGridValue(0, 1)
        Dim strLabel2 As String = GetRecentGridValue(1, 1)
        Dim strLabel3 As String = GetRecentGridValue(2, 1)

        If strLabel1 = "" OrElse strLabel2 = "" OrElse strLabel3 = "" Then
            Return False
        End If

        Dim iYears1 As Integer
        Dim iYears2 As Integer
        If Not Integer.TryParse(GetRecentGridValue(0, 2), iYears1) Then
            Return False
        End If
        If Not Integer.TryParse(GetRecentGridValue(1, 2), iYears2) Then
            Return False
        End If
        If iYears1 <= 0 OrElse iYears2 <= 0 Then
            Return False
        End If
        If iYears1 >= iYears2 Then
            Return False
        End If
        Return True
    End Function

    Private Function QuoteRString(strText As String) As String
        If strText Is Nothing Then
            strText = ""
        End If

        Dim strEscaped As String = strText.Replace("\\", "\\\\").Replace("""", "\""")
        Return """" & strEscaped & """"
    End Function

    Private Sub UpdateRecentRCode()

        If grdRecentWorkSheet Is Nothing OrElse ucrReceiverYear.IsEmpty OrElse Not IsRecentGridValid() Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMaxYearAssign)
            Exit Sub
        End If

        Dim strYearVar As String = ucrReceiverYear.GetVariableNames.Replace("]", "").Replace("""", "")
        Dim clsDataFrameParam As RFunction = GetCleanDataFrameParam()
        clsDataFrameParam.RemoveParameterByName("use_current_filter")
        clsDataFrameParam.AddParameter("use_current_filter", "FALSE")

        Dim strLabel1 As String = GetRecentGridValue(0, 1)
        Dim strLabel2 As String = GetRecentGridValue(1, 1)
        Dim strLabel3 As String = GetRecentGridValue(2, 1)
        Dim strYears1 As String = GetRecentGridValue(0, 2)
        Dim strYears2 As String = GetRecentGridValue(1, 2)

        Dim clsCond1 As New ROperator
        Dim clsCond2 As New ROperator
        Dim clsMinus1 As New ROperator
        Dim clsMinus2 As New ROperator

        Dim clsMaxCalc As New RFunction
        clsMaxCalc.SetRCommand("max")
        clsMaxCalc.AddParameter("x", strYearVar, iPosition:=0, bIncludeArgumentName:=False)
        clsMaxCalc.AddParameter("na.rm", "TRUE")

        Dim clsWithMax As New RFunction
        clsWithMax.SetRCommand("with")
        clsWithMax.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0)
        clsWithMax.AddParameter("expr", clsRFunctionParameter:=clsMaxCalc, iPosition:=1)

        clsMaxYearAssign.ClearParameters()
        clsMaxYearAssign.SetAssignToObject("max_year")
        clsMaxYearAssign.AddParameter("value", clsRFunctionParameter:=clsWithMax, iPosition:=0, bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsMaxYearAssign, iPosition:=0)

        clsMinus1.SetOperation("-")
        clsMinus1.AddParameter("m", "max_year", iPosition:=0, bIncludeArgumentName:=False)
        clsMinus1.AddParameter("n", strYears1, iPosition:=1, bIncludeArgumentName:=False)

        clsMinus2.SetOperation("-")
        clsMinus2.AddParameter("m", "max_year", iPosition:=0, bIncludeArgumentName:=False)
        clsMinus2.AddParameter("n", strYears2, iPosition:=1, bIncludeArgumentName:=False)

        clsCond1.SetOperation(">")
        clsCond1.AddParameter("x", strYearVar, iPosition:=0, bIncludeArgumentName:=False)
        clsCond1.AddParameter("y", clsROperatorParameter:=clsMinus1, iPosition:=1, bIncludeArgumentName:=False)

        clsCond2.SetOperation(">")
        clsCond2.AddParameter("x", strYearVar, iPosition:=0, bIncludeArgumentName:=False)
        clsCond2.AddParameter("y", clsROperatorParameter:=clsMinus2, iPosition:=1, bIncludeArgumentName:=False)

        clsInnerIfElseFunction.ClearParameters()
        clsInnerIfElseFunction.SetRCommand("ifelse")
        clsInnerIfElseFunction.AddParameter("test", clsROperatorParameter:=clsCond2, iPosition:=0)
        clsInnerIfElseFunction.AddParameter("yes", QuoteRString(strLabel2), iPosition:=1)
        clsInnerIfElseFunction.AddParameter("no", QuoteRString(strLabel3), iPosition:=2)

        clsRecentIfElseFunction.ClearParameters()
        clsRecentIfElseFunction.SetRCommand("ifelse")
        clsRecentIfElseFunction.AddParameter("test", clsROperatorParameter:=clsCond1, iPosition:=0)
        clsRecentIfElseFunction.AddParameter("yes", QuoteRString(strLabel1), iPosition:=1)
        clsRecentIfElseFunction.AddParameter("no", clsRFunctionParameter:=clsInnerIfElseFunction, iPosition:=2)

        ' Wrap the ifelse logic in with(data, ...) as well
        clsWithFunction.ClearParameters()
        clsWithFunction.SetRCommand("with")
        clsWithFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0)
        clsWithFunction.AddParameter("expr", clsRFunctionParameter:=clsRecentIfElseFunction, iPosition:=1)

        Dim clsLevels As New RFunction
        clsLevels.SetRCommand("c")
        clsLevels.AddParameter("l3", QuoteRString(strLabel3), iPosition:=0, bIncludeArgumentName:=False)
        clsLevels.AddParameter("l2", QuoteRString(strLabel2), iPosition:=1, bIncludeArgumentName:=False)
        clsLevels.AddParameter("l1", QuoteRString(strLabel1), iPosition:=2, bIncludeArgumentName:=False)

        clsFactorFunction.ClearParameters()
        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", clsRFunctionParameter:=clsWithFunction, iPosition:=0)
        clsFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsLevels, iPosition:=1)
        clsFactorFunction.AddParameter("ordered", "TRUE", iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsFactorFunction)
    End Sub
    Private Sub UpdateTrendRCode()
        If Not rdoTrend.Checked Then Exit Sub

        If ucrReceiverYVar.IsEmpty OrElse ucrReceiverX.IsEmpty Then
            ucrBase.clsRsyntax.SetBaseROperator(Nothing)
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("geom_point")
        clsBaseOperator.RemoveParameterByName("geom_smooth")
        clsBaseOperator.RemoveParameterByName("geom_hline_mean")
        clsBaseOperator.RemoveParameterByName("label_first_last")
        clsBaseOperator.RemoveParameterByName("point_first_last")
        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFirstLastPipeOperator)

        clsBaseOperator.RemoveParameterByName("theme")
        clsBaseOperator.RemoveParameterByName("labs")
        clsBaseOperator.RemoveParameterByName("xlab")
        clsBaseOperator.RemoveParameterByName("ylab")
        clsBaseOperator.RemoveParameterByName("scale_x_continuous")
        clsBaseOperator.RemoveParameterByName("scale_y_continuous")
        clsBaseOperator.RemoveParameterByName("scale_x_date")
        clsBaseOperator.RemoveParameterByName("scale_y_date")

        clsBaseOperator.RemoveParameterByName("geom_hline_mean_sdg")

        clsBaseOperator.RemoveParameterByName("text_mean")

        Dim strXVar As String = ucrReceiverX.GetVariableNames.Replace("]", "").Replace("""", "").Replace("'", "")
        Dim strXExpression As String = "as.numeric(" & strXVar & ")"
        If Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor") Then
            strXExpression = "as.numeric(as.character(" & strXVar & "))"
        End If
        clsRaesFunction.AddParameter("x", strXExpression, iPosition:=1)
        clsXLabsFunction.AddParameter("label", QuoteRString(strXVar))

        If Not ucrReceiverSecondYVar.IsEmpty Then
            Dim strYVar As String = ucrReceiverYVar.GetVariableNames.Replace("""", "")
            Dim strSecondYVar As String = ucrReceiverSecondYVar.GetVariableNames.Replace("""", "")

            clsSegmentAesFunction.ClearParameters()
            clsSegmentAesFunction.SetRCommand("aes")

            clsGeomPoint2Function.SetPackageName("ggplot2")
            clsGeomPoint2Function.SetRCommand("geom_point")
            clsGeomPoint2Function.AddParameter("mapping", clsRFunctionParameter:=clsPoint2AesFunction)
            clsGeomPoint2Function.AddParameter("size", "2")
            clsGeomPoint2Function.AddParameter("colour", """darkgreen""")
            clsGeomPoint2Function.AddParameter("shape", "17")

            clsPoint2AesFunction.SetRCommand("aes")

            clsSegmentAesFunction.AddParameter("x", strXExpression, iPosition:=0)
            clsSegmentAesFunction.AddParameter("xend", strXExpression, iPosition:=1)
            clsSegmentAesFunction.AddParameter("y", strYVar, iPosition:=2)
            clsSegmentAesFunction.AddParameter("yend", strSecondYVar, iPosition:=3)

            clsGeomSegmentFunction.RemoveParameterByName("mapping")
            clsGeomSegmentFunction.AddParameter("mapping", clsRFunctionParameter:=clsSegmentAesFunction)

            If ucrReceiverColourBy.IsEmpty Then
                If Not clsGeomSegmentFunction.ContainsParameter("colour") Then
                    clsGeomSegmentFunction.AddParameter("colour", """darkgray""")
                End If
            Else
                clsGeomSegmentFunction.RemoveParameterByName("colour")
            End If

            clsBaseOperator.AddParameter("geom_segment", clsRFunctionParameter:=clsGeomSegmentFunction, iPosition:=2)

            clsPoint2AesFunction.ClearParameters()
            clsPoint2AesFunction.SetRCommand("aes")

            clsPoint2AesFunction.AddParameter("x", strXExpression, iPosition:=0)
            clsPoint2AesFunction.AddParameter("y", strSecondYVar, iPosition:=1)

            clsGeomPoint2Function.RemoveParameterByName("mapping")
            clsGeomPoint2Function.AddParameter("mapping", clsRFunctionParameter:=clsPoint2AesFunction)

            If ucrReceiverColourBy.IsEmpty Then
                If Not clsGeomPoint2Function.ContainsParameter("colour") Then
                    clsGeomPoint2Function.AddParameter("colour", """darkgreen""")
                End If
            Else
                clsGeomPoint2Function.RemoveParameterByName("colour")
            End If

            clsBaseOperator.AddParameter("geom_point2", clsRFunctionParameter:=clsGeomPoint2Function, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("geom_segment")
            clsBaseOperator.RemoveParameterByName("geom_point2")
        End If

        If Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor") Then
            clsGeomLine.AddParameter("group", 1)
            clsBaseOperator.RemoveParameterByName("scale_x_continuous")
        Else
            clsGeomLine.RemoveParameterByName("group")
        End If

        If ucrReceiverColourBy.IsEmpty Then
            If Not clsGeomLine.ContainsParameter("colour") Then
                clsGeomLine.AddParameter("colour", """blue""")
            End If
        Else
            clsGeomLine.RemoveParameterByName("colour")
        End If

        If ucrChkPoints.Checked Then
            If ucrReceiverColourBy.IsEmpty Then
                If Not clsGeomPoint.ContainsParameter("colour") Then
                    clsGeomPoint.AddParameter("colour", """red""")
                End If
            Else
                clsGeomPoint.RemoveParameterByName("colour")
            End If
            clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPoint, iPosition:=2)
        End If

        clsGeomHlineAesMean.ClearParameters()
        clsMutateFunction.RemoveParameterByName(strMeanColumnName)

        If clsSubDialogGeomHlineMean.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("geom_hline_mean_sdg", clsRFunctionParameter:=clsSubDialogGeomHlineMean, iPosition:=3)
        ElseIf rdoMeanLine.Checked Then
            clsMutateFunction.AddParameter(strMeanColumnName, clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

            clsGeomHlineAesMean.AddParameter("yintercept", strMeanColumnName, bIncludeArgumentName:=True)
            If ucrReceiverColourBy.IsEmpty Then
                clsGeomHlineMean.AddParameter("colour", """darkgreen""")
                clsGeomHlineMean.AddParameter("linetype", """dashed""")
            Else
                clsGeomHlineMean.RemoveParameterByName("colour")
            End If
            clsBaseOperator.AddParameter("geom_hline_mean", clsRFunctionParameter:=clsGeomHlineMean, iPosition:=3)

            clsGeomTextLabelMeanLine.ClearParameters()
            Dim clsAesMeanText As New RFunction
            clsAesMeanText.SetRCommand("aes")

            clsAesMeanText.AddParameter("x", "Inf", iPosition:=0)
            clsAesMeanText.AddParameter("y", strMeanColumnName, iPosition:=1)

            Dim strLabelExpr As String = "paste(" & """Mean = """ & ", round(" & strMeanColumnName & ", 2))"
            clsAesMeanText.AddParameter("label", strLabelExpr, iPosition:=2)

            clsGeomTextLabelMeanLine.AddParameter("mapping", clsRFunctionParameter:=clsAesMeanText)
            clsGeomTextLabelMeanLine.AddParameter("hjust", "1.1")
            clsGeomTextLabelMeanLine.AddParameter("vjust", "-0.5")
            clsGeomTextLabelMeanLine.AddParameter("check_overlap", "TRUE")

            If ucrReceiverColourBy.IsEmpty Then
                clsGeomTextLabelMeanLine.AddParameter("colour", """darkgreen""")
            End If
        Else

            clsGeomTextLabelMeanLine.ClearParameters()
        End If

        If clsGeomTextLabelMeanLine.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("text_mean", clsRFunctionParameter:=clsGeomTextLabelMeanLine)
        End If

        If rdoFittedLine.Checked Then
            If ucrChkWithSE.Checked Then
                clsGeomSmoothFunction.AddParameter("se", "TRUE")
            Else
                clsGeomSmoothFunction.AddParameter("se", "FALSE")
            End If
            clsBaseOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsGeomSmoothFunction, iPosition:=4)
        End If

        If ucrChkFirstAndLast.Checked Then
            Dim strYVarFirstLast As String = ucrReceiverYVar.GetVariableNames.Replace("""", "")

            clsGroupByFirstLast.ClearParameters()
            Dim lstFirstLastGroupVars As New List(Of String)
            If Not ucrReceiverFacetBy.IsEmpty Then
                Dim strVar As String = ucrReceiverFacetBy.GetVariableNames(False)
                If Not lstFirstLastGroupVars.Contains(strVar) Then lstFirstLastGroupVars.Add(strVar)
            End If
            If Not ucrReceiverColourBy.IsEmpty Then
                Dim strVar As String = ucrReceiverColourBy.GetVariableNames(False)
                If Not lstFirstLastGroupVars.Contains(strVar) Then lstFirstLastGroupVars.Add(strVar)
            End If
            For i As Integer = 0 To lstFirstLastGroupVars.Count - 1
                clsGroupByFirstLast.AddParameter(i, lstFirstLastGroupVars(i), bIncludeArgumentName:=False, iPosition:=i)
            Next

            clsFilterFirstLastFunction.ClearParameters()
            clsFilterFirstLastFunction.AddParameter("naY", "!is.na(" & strYVarFirstLast & ")", iPosition:=0, bIncludeArgumentName:=False)
            clsFilterFirstLastFunction.AddParameter("naX", "!is.na(" & strXVar & ")", iPosition:=1, bIncludeArgumentName:=False)

            clsSliceMinFirstLast.RemoveParameterByName("order_by")
            clsSliceMinFirstLast.AddParameter("order_by", strXVar, iPosition:=0, bIncludeArgumentName:=False)
            clsSliceMaxFirstLast.RemoveParameterByName("order_by")
            clsSliceMaxFirstLast.AddParameter("order_by", strXVar, iPosition:=0, bIncludeArgumentName:=False)

            clsDistinctFirstLast.ClearParameters()
            For i As Integer = 0 To lstFirstLastGroupVars.Count - 1
                clsDistinctFirstLast.AddParameter(i, lstFirstLastGroupVars(i), bIncludeArgumentName:=False, iPosition:=i)
            Next
            clsDistinctFirstLast.AddParameter(lstFirstLastGroupVars.Count, strXVar, bIncludeArgumentName:=False, iPosition:=lstFirstLastGroupVars.Count)
            clsDistinctFirstLast.AddParameter(".keep_all", "TRUE", iPosition:=lstFirstLastGroupVars.Count + 1)

            Dim clsFirstLastDataFrameParam As RFunction = GetCleanDataFrameParam()
            clsFirstLastPipeOperator.RemoveParameterByName("data")
            clsFirstLastPipeOperator.AddParameter("data", clsRFunctionParameter:=clsFirstLastDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)
            clsMaxSidePipeOperator.RemoveParameterByName("data")
            clsMaxSidePipeOperator.AddParameter("data", clsRFunctionParameter:=clsFirstLastDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)

            ucrBase.clsRsyntax.AddToBeforeCodes(clsFirstLastPipeOperator, iPosition:=0)

            clsAesTextFirstLast.RemoveParameterByName("label")
            clsAesTextFirstLast.AddParameter("label", strYVarFirstLast, iPosition:=0)

            clsBaseOperator.AddParameter("point_first_last", clsRFunctionParameter:=clsGeomPointFirstLast, iPosition:=5)
            clsBaseOperator.AddParameter("label_first_last", clsRFunctionParameter:=clsGeomTextFirstLast, iPosition:=6)
        End If

        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction)
        End If
        If clsLabsFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
        End If
        If clsXLabsFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXLabsFunction)
        End If
        If clsYLabsFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("ylab", clsRFunctionParameter:=clsYLabsFunction)
        End If

        If clsCLimitsYContinuous.iParameterCount > 2 Then
            clsCLimitsYContinuous.ClearParameters()
            clsCLimitsYContinuous.AddParameter("lowerlimit", "NA", bIncludeArgumentName:=False, iPosition:=0)
            clsCLimitsYContinuous.AddParameter("upperlimit", "NA", bIncludeArgumentName:=False, iPosition:=1)
        End If

        If clsXScalecontinuousFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("scale_x_continuous", clsRFunctionParameter:=clsXScalecontinuousFunction)
        End If
        If clsYScalecontinuousFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScalecontinuousFunction)
        End If

        AddRemoveFacets()
        AddRemoveTrendMeanGroupBy()
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub AddRemoveTrendMeanGroupBy()
        Dim clsDataFrameParam As RFunction = GetCleanDataFrameParam()

        clsRggplotFunction.RemoveParameterByName("data")
        clsPipeOperator.RemoveParameterByName("data_frame")
        clsPipeOperator.RemoveParameterByName("group_by_step")
        clsPipeOperator.RemoveParameterByName("mutate_step")

        If clsMutateFunction.iParameterCount > 0 Then
            clsGroupByMeanFunction.ClearParameters()
            Dim lstGroupByVars As New List(Of String)
            If Not ucrReceiverFacetBy.IsEmpty Then
                Dim strVar As String = ucrReceiverFacetBy.GetVariableNames(False)
                If Not lstGroupByVars.Contains(strVar) Then lstGroupByVars.Add(strVar)
            End If
            If Not ucrReceiverColourBy.IsEmpty Then
                Dim strVar As String = ucrReceiverColourBy.GetVariableNames(False)
                If Not lstGroupByVars.Contains(strVar) Then lstGroupByVars.Add(strVar)
            End If
            For i As Integer = 0 To lstGroupByVars.Count - 1
                clsGroupByMeanFunction.AddParameter(i, lstGroupByVars(i), bIncludeArgumentName:=False, iPosition:=i)
            Next

            clsPipeOperator.AddParameter("data_frame", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)
            If clsGroupByMeanFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by_step", clsRFunctionParameter:=clsGroupByMeanFunction, iPosition:=1, bIncludeArgumentName:=False)
            End If
            clsPipeOperator.AddParameter("mutate_step", clsRFunctionParameter:=clsMutateFunction, iPosition:=2, bIncludeArgumentName:=False)
            clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        Else
            clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0)
        End If
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If bUpdatingParameters Then Exit Sub

        clsBaseOperator.RemoveParameterByName("facets")
        clsFacetFunction.RemoveParameterByName("facets")
        clsFacetFunction.RemoveParameterByName("rows")
        clsFacetFunction.RemoveParameterByName("cols")

        If Not ucrReceiverFacetBy.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap : bWrap = True
                Case strFacetCol : bCol = True
                Case strFacetRow : bRow = True
                Case strFacetColAll : bColAll = True
                Case strFacetRowAll : bRowAll = True
            End Select
        End If

        If bWrap Then
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)
        ElseIf bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsVarsFunction)
        ElseIf bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsVarsFunction)
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll OrElse bWrap Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If

        If bWrap Then clsFacetFunction.SetRCommand("facet_wrap")
        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then clsFacetFunction.SetRCommand("facet_grid")

        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE")
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If
    End Sub

    Private Sub UpdateParameters()
        clsFacetOperator.RemoveParameterByName("var1")
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucrReceiverFacetBy.SetRCode(Nothing)

        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucrReceiverFacetBy.ChangeParameterName("var1")
                ucrReceiverFacetBy.SetRCode(clsFacetOperator)
            Case strFacetCol, strFacetColAll
                ucrReceiverFacetBy.ChangeParameterName("col" & ucrInputStation.Name)
                clsVarsFunction.AddParameter("var", ucrReceiverFacetBy.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            Case strFacetRow, strFacetRowAll
                ucrReceiverFacetBy.ChangeParameterName("row" & ucrInputStation.Name)
                clsVarsFunction.AddParameter("var", ucrReceiverFacetBy.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
        End Select

        bUpdatingParameters = False
    End Sub

    Private Sub ucrInputStation_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then Exit Sub

        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not (strChangedText = strFacetCol OrElse strChangedText = strFacetColAll _
            OrElse strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso Not ucrInputStation.Equals(ucrChangedControl) _
            AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If

            If (strChangedText = strFacetWrap AndAlso
            (ucrInputStation.GetText = strFacetRow OrElse ucrInputStation.GetText = strFacetRowAll _
            OrElse ucrInputStation.GetText = strFacetCol OrElse ucrInputStation.GetText = strFacetColAll)) _
        OrElse ((strChangedText = strFacetRow OrElse strChangedText = strFacetRowAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) _
        OrElse ((strChangedText = strFacetCol OrElse strChangedText = strFacetColAll) _
            AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If

        UpdateParameters()
        AddRemoveFacets()
        UpdateTrendRCode()
    End Sub

    Private Sub ucrReceiverColourBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColourBy.ControlValueChanged
        UpdateTrendRCode()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        If rdoTrend.Checked Then
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                              clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                              clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction,
                              clsNewFacetFunction:=clsFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions,
                              ucrNewBaseSelector:=ucrSelectorForCheckSummary, bReset:=bResetSubdialog,
                              clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                              clsNewYScaleDateFunction:=clsYScaleDateFunction,
                              clsNewFacetVariablesOperator:=clsFacetOperator, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                              clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                              clsNewRowVarsFunction:=clsRowVarsFunction,
                              clsNewColVarsFunction:=clsColVarsFunction)
            sdgPlots.ShowDialog()
            bResetSubdialog = False
            UpdateTrendRCode()
        ElseIf rdoOutliers.Checked Then
            sdgPlots.SetRCode(
                clsNewOperator:=clsOutlierBaseOperator,
                clsNewCoordPolarFunction:=clsOutlierCoordPolarFunction,
                clsNewCoordPolarStartOperator:=clsOutlierCoordPolarStartOperator,
                clsNewYScalecontinuousFunction:=clsOutlierYScaleContinuousFunction,
                clsNewXScalecontinuousFunction:=clsOutlierXScaleContinuousFunction,
                clsNewLabsFunction:=clsOutlierLabsFunction,
                clsNewXLabsTitleFunction:=clsOutlierXlabsFunction,
                clsNewYLabTitleFunction:=clsOutlierYlabFunction,
                clsNewFacetFunction:=clsOutlierFacetFunction,
                clsNewThemeFunction:=clsOutlierThemeFunction,
                dctNewThemeFunctions:=dctOutlierThemeFunctions,
                ucrNewBaseSelector:=ucrSelectorForCheckSummary,
                bReset:=bResetOutlierSubdialog,
                clsNewGlobalAesFunction:=clsOutlierRaesFunction,
                clsNewXScaleDateFunction:=clsOutlierXScaleDateFunction,
                clsNewYScaleDateFunction:=clsOutlierYScaleDateFunction,
                clsNewFacetVariablesOperator:=clsOutlierFacetVariablesOperator,
                clsNewScaleFillViridisFunction:=clsOutlierScaleFillViridisFunction,
                clsNewScaleColourViridisFunction:=clsOutlierScaleColourViridisFunction,
                clsNewAnnotateFunction:=clsOutlierAnnotateFunction,
                clsNewRowVarsFunction:=clsOutlierRowVarsFunction,
                clsNewColVarsFunction:=clsOutlierColVarsFunction,
                strMainDialogGeomParameterNames:=strOutlierGeomParameterNames,
                bChangeAesParameter:=True)
            sdgPlots.ShowDialog()
            bResetOutlierSubdialog = False
            UpdateOutliersRCode()
        End If
    End Sub

    Private Sub PlotOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotOptionsToolStripMenuItem.Click
        cmdPlotOptions_Click(sender, e)
    End Sub

    Private Sub toolStripMenuItemOutlierBoxplotOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemOutlierBoxplotOptions.Click
        openSdgLayerOptionsForOutlier(clsOutlierBoxplotFunction)
    End Sub

    Private Sub toolStripMenuItemOutlierJitterOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemOutlierJitterOptions.Click
        openSdgLayerOptionsForOutlier(clsOutlierAddedJitterFunc)
    End Sub

    Private Sub toolStripMenuItemOutlierTextOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemOutlierTextOptions.Click
        If ucrChkLabeloutliers.Checked Then
            openSdgLayerOptionsForOutlier(clsOutlierBoxplotStatFunction)
        End If
    End Sub

    Private Sub openSdgLayerOptionsForOutlier(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsOutlierRggplotFunction,
                                   clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsOutlierRaesFunction,
                                   clsNewLocalAes:=clsOutlierLocalRaesFunction,
                                   bFixGeom:=True,
                                   ucrNewBaseSelector:=ucrSelectorForCheckSummary,
                                   bApplyAesGlobally:=True,
                                   bReset:=bResetOutlierLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetOutlierLayerSubdialog = False
        UpdateOutliersRCode()
    End Sub

    Private Sub toolStripMenuItemLineOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemLineOptions.Click
        openSdgLayerOptions(clsGeomLine)
    End Sub

    Private Sub toolStripMenuItemPointOption_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemPointOption.Click
        openSdgLayerOptions(clsGeomPoint)
    End Sub

    Private Sub openSdgLayerOptions(clsNewGeomFunc As RFunction)
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsNewGeomFunc,
                                   clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorForCheckSummary,
                                   bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = """""" Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the value stored in the clsReasFunction in the multiple variables
                '  case is "value", however that one shouldn't be written in the multiple
                '  variables receiver (otherwise it would stack all variables and the stack
                '  ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables
                '  independently from the multiple variables method? Here if the receiver is
                '  actually in single mode, the variable "value" will still be given back, which
                '  throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value") Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = ("""""") Then
                    ucrReceiverYVar.Clear()
                Else
                    ucrReceiverYVar.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrReceiverColourBy.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOKEnabled()
        UpdateTrendRCode()
    End Sub

    Private Sub AddRemoveOutlierTheme()
        If clsOutlierThemeFunction.iParameterCount > 0 Then
            clsOutlierBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsOutlierThemeFunction, iPosition:=15)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub AddRemoveOutlierFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        clsOutlierBaseOperator.RemoveParameterByName("facets")
        clsOutlierFacetFunction.RemoveParameterByName("facets")
        clsOutlierFacetFunction.RemoveParameterByName("rows")
        clsOutlierFacetFunction.RemoveParameterByName("cols")

        If Not ucrOutlier1stFactorReceiver.IsEmpty Then
            Select Case ucrOutlierInputStation.GetText()
                Case strFacetWrap : bWrap = True
                Case strFacetCol : bCol = True
                Case strFacetRow : bRow = True
                Case strFacetColAll : bColAll = True
                Case strFacetRowAll : bRowAll = True
            End Select
        End If

        If bWrap Then
            clsOutlierFacetVariablesOperator.RemoveParameterByName("var1")
            clsOutlierFacetVariablesOperator.AddParameter("var1", ucrOutlier1stFactorReceiver.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
            clsOutlierFacetFunction.AddParameter("facets", clsROperatorParameter:=clsOutlierFacetVariablesOperator, iPosition:=0)
        ElseIf bRow Or bRowAll Then
            clsOutlierRowVarsFunction.RemoveParameterByName("var")
            clsOutlierRowVarsFunction.AddParameter("var", ucrOutlier1stFactorReceiver.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            clsOutlierFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsOutlierRowVarsFunction)
        ElseIf bCol Or bColAll Then
            clsOutlierColVarsFunction.RemoveParameterByName("var")
            clsOutlierColVarsFunction.AddParameter("var", ucrOutlier1stFactorReceiver.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            clsOutlierFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsOutlierColVarsFunction)
        End If

        If bRow Or bCol Or bRowAll Or bColAll Or bWrap Then
            clsOutlierBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsOutlierFacetFunction)
        Else
            clsOutlierBaseOperator.RemoveParameterByName("facets")
        End If

        If bWrap Then clsOutlierFacetFunction.SetRCommand("facet_wrap")
        If bRow Or bCol Or bRowAll Or bColAll Then clsOutlierFacetFunction.SetRCommand("facet_grid")

        If bRowAll Or bColAll Then
            clsOutlierFacetFunction.AddParameter("margin", "TRUE")
        Else
            clsOutlierFacetFunction.RemoveParameterByName("margin")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        If rdoOutliers.Checked Then
            AddRemoveOutlierTheme()
            UpdateOutliersRCode()
        End If
    End Sub

    Private Sub ucrOutlierInputStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrOutlierInputStation.ControlValueChanged
        If Not rdoOutliers.Checked Then Exit Sub
        AddRemoveOutlierFacets()
        UpdateOutliersRCode()
    End Sub

    Private Sub ucrSelectorForCheckSummary_DataFrameChanged() Handles ucrSelectorForCheckSummary.DataFrameChanged
        If rdoOutliers.Checked Then
            AutoFillRecentColumnForOutliers()
            UpdateOutliersRCode()
        End If
    End Sub

    Private Sub OutliersOverlapReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSecondFactorReceiver.ControlValueChanged, ucrReceiverLabelOutliers.ControlValueChanged
        If rdoOutliers.Checked Then
            ucrVariablesAsFactorForCheckSummary.SetMeAsReceiver()
        End If
    End Sub

    Private Function GetFullVariableName(strBaseName As String) As String
        If strBaseName = "" Then Return ""
        For Each lvi As ListViewItem In ucrSelectorForCheckSummary.lstAvailableVariable.Items
            Dim strText As String = lvi.Text
            Dim strClean As String = strText.Split({" "c, "("c})(0).Trim()
            If strClean.Equals(strBaseName, StringComparison.OrdinalIgnoreCase) Then
                Return strText
            End If
        Next
        Return ""
    End Function

    Private Sub AutoFillRecentColumnForOutliers()
        Try
            Dim strCurrentDataFrameForList As String = ucrSelectorForCheckSummary.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            If strOutliersListLoadedForDataFrame <> strCurrentDataFrameForList Then
                ucrSelectorForCheckSummary.LoadList()
                strOutliersListLoadedForDataFrame = strCurrentDataFrameForList
            End If

            If ucrByFactorsReceiver.IsEmpty OrElse ucrOutlier1stFactorReceiver.IsEmpty Then
                ucrByFactorsReceiver.SetMeAsReceiver()
            End If

            If ucrByFactorsReceiver.IsEmpty Then
                Dim strRecentName As String = ucrSaveNewColumn.GetText().Trim()
                Dim strFullRecentName As String = GetFullVariableName(strRecentName)

                If strFullRecentName <> "" Then
                    ucrByFactorsReceiver.Add(strFullRecentName)
                    ' Auto-fill Fill by receiver with the same recent column
                    ucrSecondFactorReceiver.Add(strFullRecentName)
                Else
                    Dim strFallbacks() As String = {"recent", "Recent", "recent1", "Recent1"}
                    For Each strFallback In strFallbacks
                        strFullRecentName = GetFullVariableName(strFallback)
                        If strFullRecentName <> "" Then
                            ucrByFactorsReceiver.Add(strFullRecentName)
                            ' Auto-fill Fill by receiver with the same recent column
                            ucrSecondFactorReceiver.Add(strFullRecentName)
                            Exit For
                        End If
                    Next
                End If
            End If

            If ucrOutlier1stFactorReceiver.IsEmpty Then
                Dim strCurrentDataFrame As String = ucrSelectorForCheckSummary.ucrAvailableDataFrames.cboAvailableDataFrames.Text
                ucrOutlier1stFactorReceiver.AddItemsWithMetadataProperty(strCurrentDataFrame, "Climatic_Type", {"station_label"})

                If ucrOutlier1stFactorReceiver.IsEmpty Then
                    Dim strStationNames() As String = {"station", "Station", "Station_Name", "station_name", "Station Name", "station name"}
                    For Each strName In strStationNames
                        Dim strFullStationName As String = GetFullVariableName(strName)
                        If strFullStationName <> "" Then
                            ucrOutlier1stFactorReceiver.Add(strFullStationName)
                            Exit For
                        End If
                    Next
                End If

                If Not ucrOutlier1stFactorReceiver.IsEmpty Then
                    ucrOutlierInputStation.SetName(strFacetWrap)
                End If
            End If

            ucrVariablesAsFactorForCheckSummary.SetMeAsReceiver()
        Catch ex As Exception
        End Try
    End Sub
End Class