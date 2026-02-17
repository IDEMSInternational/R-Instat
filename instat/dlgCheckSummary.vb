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

    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsGeomLine As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsFacetFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsVarsFunction As New RFunction
    Private clsGeomPoint As New RFunction
    Private clsGeomSmoothFunction As New RFunction
    Private clsGeomHlineMean As New RFunction
    Private clsMeanFunction As New RFunction
    Private clsGeomHlineAesMean As New RFunction
    Private clsGeomTextFirstLast As New RFunction
    Private clsSliceFirstLast As New RFunction
    Private clsGroupByFirstLast As New RFunction
    Private clsOrOperator As New ROperator
    Private clsEqualsMinOperator As New ROperator
    Private clsEqualsMaxOperator As New ROperator
    Private clsMinFunction As New RFunction
    Private clsMaxFunctionFirstLast As New RFunction
    Private clsAesTextFirstLast As New RFunction
    Private clsGeomPointFirstLast As New RFunction

    Private clsGeomSegmentFunction As New RFunction
    Private clsSegmentAesFunction As New RFunction
    Private clsGeomPoint2Function As New RFunction
    Private clsPoint2AesFunction As New RFunction


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

    Private WithEvents contextMenuStripPlotOptions As New ContextMenuStrip
    Private WithEvents PlotOptionsToolStripMenuItem As New ToolStripMenuItem("Plot Options")
    Private WithEvents toolStripMenuItemLineOptions As New ToolStripMenuItem("Line Options")
    Private WithEvents toolStripMenuItemPointOption As New ToolStripMenuItem("Point Options")

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

    Private clsLocalRaesFunction As New RFunction

    Private clsMutateFunction As New RFunction
    Private clsMedianFunction As New RFunction
    Private clsLowerTercileFunction As New RFunction
    Private clsUpperTercileFunction As New RFunction
    Private clsAsDateMeanY As New RFunction
    Private clsAsDateMedianY As New RFunction
    Private clsAsDateLowerTercileY As New RFunction
    Private clsAsDateUpperTercileY As New RFunction

    Private clsGeomTextLabelMeanLine As New RFunction
    Private clsRoundMeanY As New RFunction
    Private clsPasteMeanY As New RFunction
    Private clsFormatMeanY As New RFunction
    Private clsGeomTextLabelMedianLine As New RFunction
    Private clsRoundMedianY As New RFunction
    Private clsPasteMedianY As New RFunction
    Private clsFormatMedianY As New RFunction
    Private clsGeomTextLabelLowerTercileLine As New RFunction
    Private clsRoundLowerTercileY As New RFunction
    Private clsPasteLowerTercileY As New RFunction
    Private clsFormatLowerTercileY As New RFunction
    Private clsGeomTextLabelUpperTercileLine As New RFunction
    Private clsRoundUpperTercileY As New RFunction
    Private clsPasteUpperTercileY As New RFunction
    Private clsFormatUpperTercileY As New RFunction

    Private clsGeomHlineMedian As New RFunction
    Private clsGeomHlineLowerTercile As New RFunction
    Private clsGeomHlineUpperTercile As New RFunction

    Private clsGeomHlineAesMedian As New RFunction
    Private clsGeomHlineAesLowerTercile As New RFunction
    Private clsGeomHlineAesUpperTercile As New RFunction

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
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = -1
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ' Setup Plot Options Menu
        PlotOptionsToolStripMenuItem.Name = "PlotOptionsToolStripMenuItem"
        toolStripMenuItemLineOptions.Name = "toolStripMenuItemLineOptions"
        toolStripMenuItemPointOption.Name = "toolStripMenuItemPointOption"

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


        ucrReceiverFacetBy.SetParameter(New RParameter(""))
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

        ucrSave.SetPrefix("check_trend_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Store Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorForCheckSummary.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")

        rdoBrokenStick.Enabled = False

        UpdateVisiblePanels()
    End Sub

    Private clsWithFunction As New RFunction

    Private Sub SetDefaults()
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
        clsGeomTextFirstLast = New RFunction
        clsSliceFirstLast = New RFunction
        clsGroupByFirstLast = New RFunction
        clsOrOperator = New ROperator
        clsEqualsMinOperator = New ROperator
        clsEqualsMaxOperator = New ROperator
        clsMinFunction = New RFunction
        clsMaxFunctionFirstLast = New RFunction
        clsAesTextFirstLast = New RFunction

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
        ucrChkWithSE.Checked = False

        ucrSelectorForCheckSummary.Reset()
        ucrSaveNewColumn.Reset()
        ucrSave.Reset()
        ucrInputStation.SetName(strNone)

        ' ... (Recent resets)
        If Not ucrSaveNewColumn.bUserTyped Then
            ucrSaveNewColumn.SetPrefix("recent_years")
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

        clsGeomHlineMean.SetPackageName("ggplot2")
        clsGeomHlineMean.SetRCommand("geom_hline")
        clsGeomHlineMean.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMean)
        clsGeomHlineMean.AddParameter("size", "1.5")

        clsGeomHlineAesMean.SetRCommand("aes")

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsMedianFunction.SetRCommand("median")
        clsMedianFunction.AddParameter("na.rm", "TRUE")

        clsLowerTercileFunction.SetRCommand("quantile")
        clsLowerTercileFunction.AddParameter("probs", "1/3")
        clsLowerTercileFunction.AddParameter("na.rm", "TRUE")
        clsLowerTercileFunction.AddParameter("type", "8")

        clsUpperTercileFunction.SetRCommand("quantile")
        clsUpperTercileFunction.AddParameter("probs", "2/3")
        clsUpperTercileFunction.AddParameter("na.rm", "TRUE")
        clsUpperTercileFunction.AddParameter("type", "8")

        clsAsDateMeanY.SetRCommand("as.Date")
        clsAsDateMedianY.SetRCommand("as.Date")
        clsAsDateLowerTercileY.SetRCommand("as.Date")
        clsAsDateUpperTercileY.SetRCommand("as.Date")

        clsRoundMeanY.SetRCommand("round")
        clsRoundMeanY.AddParameter("digits", "1")
        clsRoundMedianY.SetRCommand("round")
        clsRoundMedianY.AddParameter("digits", "1")
        clsRoundLowerTercileY.SetRCommand("round")
        clsRoundLowerTercileY.AddParameter("digits", "1")
        clsRoundUpperTercileY.SetRCommand("round")
        clsRoundUpperTercileY.AddParameter("digits", "1")

        clsPasteMeanY.SetRCommand("paste")
        clsPasteMedianY.SetRCommand("paste")
        clsPasteLowerTercileY.SetRCommand("paste")
        clsPasteUpperTercileY.SetRCommand("paste")

        clsFormatMeanY.SetRCommand("format")
        clsFormatMedianY.SetRCommand("format")
        clsFormatLowerTercileY.SetRCommand("format")
        clsFormatUpperTercileY.SetRCommand("format")

        clsGeomHlineMedian.SetPackageName("ggplot2")
        clsGeomHlineMedian.SetRCommand("geom_hline")
        clsGeomHlineLowerTercile.SetPackageName("ggplot2")
        clsGeomHlineLowerTercile.SetRCommand("geom_hline")
        clsGeomHlineUpperTercile.SetPackageName("ggplot2")
        clsGeomHlineUpperTercile.SetRCommand("geom_hline")

        clsSubDialogGeomHlineMean.SetPackageName("ggplot2")
        clsSubDialogGeomHlineMean.SetRCommand("geom_hline")
        clsSubDialogGeomHlineAesMean.SetRCommand("aes")

        clsGeomTextLabelMeanLine.SetPackageName("ggplot2")
        clsGeomTextLabelMeanLine.SetRCommand("geom_text")
        clsGeomTextLabelMedianLine.SetPackageName("ggplot2")
        clsGeomTextLabelMedianLine.SetRCommand("geom_text")
        clsGeomTextLabelLowerTercileLine.SetPackageName("ggplot2")
        clsGeomTextLabelLowerTercileLine.SetRCommand("geom_text")
        clsGeomTextLabelUpperTercileLine.SetPackageName("ggplot2")
        clsGeomTextLabelUpperTercileLine.SetRCommand("geom_text")

        clsGroupByFirstLast.SetPackageName("dplyr")
        clsGroupByFirstLast.SetRCommand("group_by")

        clsSliceFirstLast.SetPackageName("dplyr")
        clsSliceFirstLast.SetRCommand("slice")
        clsSliceFirstLast.AddParameter("data", clsRFunctionParameter:=clsGroupByFirstLast, iPosition:=0, bIncludeArgumentName:=False)

        clsOrOperator.SetOperation("|")

        clsOrOperator.AddParameter("left", clsROperatorParameter:=clsEqualsMinOperator)
        clsOrOperator.AddParameter("right", clsROperatorParameter:=clsEqualsMaxOperator)

        clsEqualsMinOperator.SetOperation("==")
        clsEqualsMinOperator.AddParameter("right", clsRFunctionParameter:=clsMinFunction)

        clsEqualsMaxOperator.SetOperation("==")
        clsEqualsMaxOperator.AddParameter("right", clsRFunctionParameter:=clsMaxFunctionFirstLast)

        clsMinFunction.SetRCommand("min")
        clsMinFunction.AddParameter("na.rm", "TRUE")

        clsMaxFunctionFirstLast.SetRCommand("max")
        clsMaxFunctionFirstLast.AddParameter("na.rm", "TRUE")

        clsGeomTextFirstLast.SetPackageName("ggplot2")
        clsGeomTextFirstLast.SetRCommand("geom_text")
        clsGeomTextFirstLast.AddParameter("data", clsRFunctionParameter:=clsSliceFirstLast)
        clsGeomTextFirstLast.AddParameter("mapping", clsRFunctionParameter:=clsAesTextFirstLast)
        clsGeomTextFirstLast.AddParameter("vjust", "-0.6")
        clsGeomTextFirstLast.AddParameter("colour", """black""")
        clsGeomTextFirstLast.AddParameter("na.rm", "TRUE")

        clsGeomPointFirstLast.SetPackageName("ggplot2")
        clsGeomPointFirstLast.SetRCommand("geom_point")
        clsGeomPointFirstLast.AddParameter("data", clsRFunctionParameter:=clsSliceFirstLast)
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
        ucrReceiverYVar.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverYVar.AddAdditionalCodeParameterPair(clsLowerTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverYVar.AddAdditionalCodeParameterPair(clsUpperTercileFunction, New RParameter("x", 0), iAdditionalPairNo:=5)

        ucrReceiverYVar.SetRCode(clsRaesFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrReceiverX.SetRCode(clsAsNumeric, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunction, bReset)

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
        End If
        TestOKEnabled()
    End Sub

    Private Sub UpdateVisiblePanels()
        Dim bRecent As Boolean = rdoRecent.Checked
        Dim bTrend As Boolean = rdoTrend.Checked

        pnlRecent.Visible = bRecent
        pnlTrend.Visible = bTrend

        ucrSaveNewColumn.Visible = bRecent

        ucrChkPoints.Visible = bTrend
        ucrSave.Visible = bTrend
        cmdPlotOptions.Visible = bTrend
        ucrChkFirstAndLast.Visible = bTrend
        AddLineGroupbox.Visible = bTrend

        If Not bRecent Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMaxYearAssign)
            ucrBase.clsRsyntax.SetBaseRFunction(clsDummyFunction)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoRecent.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverYear.IsEmpty AndAlso ucrSaveNewColumn.IsComplete() AndAlso IsRecentGridValid())
        ElseIf rdoTrend.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverYVar.IsEmpty AndAlso Not ucrReceiverX.IsEmpty AndAlso ucrSave.IsComplete())
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged,
        ucrReceiverYVar.ControlContentsChanged, ucrReceiverSecondYVar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrReceiverColourBy.ControlContentsChanged,
        ucrReceiverFacetBy.ControlContentsChanged, ucrChkPoints.ControlContentsChanged, ucrChkFirstAndLast.ControlContentsChanged,
        ucrChkWithSE.ControlContentsChanged, ucrSave.ControlContentsChanged

        If rdoRecent.Checked Then
            UpdateRecentRCode()
        ElseIf rdoTrend.Checked Then
            UpdateTrendRCode()
        End If
        TestOKEnabled()
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
        Dim clsDataFrameParam As RFunction = ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
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

        clsBaseOperator.RemoveParameterByName("theme")
        clsBaseOperator.RemoveParameterByName("labs")
        clsBaseOperator.RemoveParameterByName("xlab")
        clsBaseOperator.RemoveParameterByName("ylab")
        clsBaseOperator.RemoveParameterByName("scale_x_continuous")
        clsBaseOperator.RemoveParameterByName("scale_y_continuous")
        clsBaseOperator.RemoveParameterByName("scale_x_date")
        clsBaseOperator.RemoveParameterByName("scale_y_date")

        clsBaseOperator.RemoveParameterByName("geom_hline_mean_sdg")
        clsBaseOperator.RemoveParameterByName("geom_hline_median")
        clsBaseOperator.RemoveParameterByName("geom_hline_lower_tercile")
        clsBaseOperator.RemoveParameterByName("geom_hline_upper_tercile")

        clsBaseOperator.RemoveParameterByName("text_mean")
        clsBaseOperator.RemoveParameterByName("text_median")
        clsBaseOperator.RemoveParameterByName("text_lower_tercile")
        clsBaseOperator.RemoveParameterByName("text_upper_tercile")

        clsPipeOperator.RemoveParameterByName("data_frame")
        clsPipeOperator.RemoveParameterByName("mutate_step")

        Dim clsDataFrameParam As RFunction = ucrSelectorForCheckSummary.ucrAvailableDataFrames.clsCurrDataFrame

        clsRggplotFunction.RemoveParameterByName("data")

        If clsMutateFunction.iParameterCount > 0 Then
            clsPipeOperator.AddParameter("data_frame", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)
            clsPipeOperator.AddParameter("mutate_step", clsRFunctionParameter:=clsMutateFunction, iPosition:=1, bIncludeArgumentName:=False)
            clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        Else
            clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0)
        End If

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

        If clsSubDialogGeomHlineMean.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("geom_hline_mean_sdg", clsRFunctionParameter:=clsSubDialogGeomHlineMean, iPosition:=3)
        ElseIf rdoMeanLine.Checked Then
            Dim strYVar As String = ucrReceiverYVar.GetVariableNames.Replace("""", "")
            clsGeomHlineAesMean.AddParameter("yintercept", "mean(" & strYVar & ", na.rm=TRUE)", bIncludeArgumentName:=True)
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
            clsAesMeanText.AddParameter("y", "mean(" & strYVar & ", na.rm=TRUE)", iPosition:=1)

            Dim strLabelExpr As String = "paste(" & """Mean = """ & ", round(mean(" & strYVar & ", na.rm=TRUE), 2))"
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


        If clsGeomHlineMedian.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("geom_hline_median", clsRFunctionParameter:=clsGeomHlineMedian)
        End If
        If clsGeomHlineLowerTercile.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("geom_hline_lower_tercile", clsRFunctionParameter:=clsGeomHlineLowerTercile)
        End If
        If clsGeomHlineUpperTercile.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("geom_hline_upper_tercile", clsRFunctionParameter:=clsGeomHlineUpperTercile)
        End If


        If clsGeomTextLabelMeanLine.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("text_mean", clsRFunctionParameter:=clsGeomTextLabelMeanLine)
        End If
        If clsGeomTextLabelMedianLine.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("text_median", clsRFunctionParameter:=clsGeomTextLabelMedianLine)
        End If
        If clsGeomTextLabelLowerTercileLine.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("text_lower_tercile", clsRFunctionParameter:=clsGeomTextLabelLowerTercileLine)
        End If
        If clsGeomTextLabelUpperTercileLine.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("text_upper_tercile", clsRFunctionParameter:=clsGeomTextLabelUpperTercileLine)
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
            clsGroupByFirstLast.ClearParameters()
            clsGroupByFirstLast.AddParameter("data", clsRFunctionParameter:=clsDataFrameParam, iPosition:=0, bIncludeArgumentName:=False)

            If Not ucrReceiverFacetBy.IsEmpty Then
                clsGroupByFirstLast.AddParameter("facet", ucrReceiverFacetBy.GetVariableNames(False), bIncludeArgumentName:=False)
            End If
            If Not ucrReceiverColourBy.IsEmpty Then
                clsGroupByFirstLast.AddParameter("colour", ucrReceiverColourBy.GetVariableNames(False), bIncludeArgumentName:=False)
            End If

            Dim strSliceExpr As String = "c(which.min(as.numeric(" & strXVar & ")), which.max(as.numeric(" & strXVar & ")))"

            strSliceExpr = "unique(" & strSliceExpr & ")"

            clsSliceFirstLast.AddParameter("rows", strSliceExpr, iPosition:=1, bIncludeArgumentName:=False)

            clsAesTextFirstLast.AddParameter("label", strXVar, iPosition:=0)

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
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
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

    Private Sub ucrInputStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStation.ControlValueChanged

    End Sub


    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                          clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction,
                          clsNewFacetFunction:=clsFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions,
                          ucrNewBaseSelector:=ucrSelectorForCheckSummary, bReset:=bResetSubdialog,
                          clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                          clsNewYScaleDateFunction:=clsYScaleDateFunction,
                          clsNewFacetVariablesOperator:=clsFacetOperator, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewAnnotateFunction:=clsAnnotateFunction)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        UpdateTrendRCode()
    End Sub

    Private Sub PlotOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotOptionsToolStripMenuItem.Click
        cmdPlotOptions_Click(sender, e)
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
End Class
