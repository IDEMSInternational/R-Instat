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
    Private clsXTitleFunction As New RFunction
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
    Private clsThemeFunc As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    Private clsFilteredDataOperator As New ROperator
    Private clsFilterElementOperator As New ROperator
    Private clsFilterElementFunction As New RFunction
    Private clsAsFactorFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction

    'Functions for Label CheckBox
    Private clsRoundFunction, clsLabelAfterFunction, clsLabelSummaryFunction, clsAesLabelFunction, clsBoxplotStatFunction, clsIfFunction,
        clsLengthFunction, clsGroupbyFunction, clsBoxplotStat2Function, clsMutateFunction, clsFilterElement2Function, clsUngroupFunction,
        clsAsFactor2Function, clsMutate2Function, clsGeomTextFunction, clsRaes2Function, clsPositionNudgeFunction As RFunction
    'Label Outlier Operators
    Private clsOpenBraquetOperator, clsSpaceOperator, clsBraquetOperator, clsSemiCommatOperator, clsDollardOperator, clsEqualOperator,
        clsAssigneOperator, clsPipeOperator, clsInOperator, clsDollarSignOperator As ROperator

    Private strFacetWrap As String = "Facet Wrap"
    Private strFacetRow As String = "Facet Row"
    Private strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"
    Private strXAxis As String = "X Axis"
    Private strColour As String = "Colour Axis"
    Private strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bContainsFacet As Boolean = False
    Private bUpdatingParameters As Boolean = False
    Private dctComboReceiver As New Dictionary(Of ucrInputComboBox, ucrReceiverSingle)

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bReset Then
            AutoFill()
        End If
        bReset = False
        SetOptionsButtonsText()
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsTextElementFunc As New RFunction

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

        ucrSelectorClimaticBoxPlot.SetParameter(New RParameter("left", 0))
        ucrSelectorClimaticBoxPlot.SetParameterIsrfunction()

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetParameter(New RParameter(""))
        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetParameter(New RParameter(""))
        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bWithQuotes = False
        ucrReceiverYear.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("x", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetIncludedDataTypes({"factor"})
        ucrReceiverWithinYear.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverWithinYear.bAddParameterIfEmpty = True

        ucrReceiverLabelOutliers.SetParameter(New RParameter("label", 1))
        ucrReceiverLabelOutliers.SetParameterIsString()
        ucrReceiverLabelOutliers.Selector = ucrSelectorClimaticBoxPlot


        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("y", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})

        dctComboReceiver.Add(ucrInputStation, ucrReceiverStation)
        dctComboReceiver.Add(ucrInputYear, ucrReceiverYear)
        dctComboReceiver.Add(ucrInputWithinYear, ucrReceiverWithinYear)

        ucrChkOmitBelow.SetText("Omit Below")
        ucrChkOmitBelow.AddParameterPresentCondition(True, "right", True)
        ucrChkOmitBelow.AddParameterPresentCondition(False, "right", False)

        ucrNudOmitBelow.SetParameter(New RParameter("right"))
        ucrNudOmitBelow.DecimalPlaces = 2
        ucrNudOmitBelow.Increment = 0.1
        ucrChkOmitBelow.AddToLinkedControls(ucrNudOmitBelow, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        ucrChkLabel.SetText("Label Outliers")
        ucrChkLabel.AddParameterPresentCondition(True, "stat_sumary", True)
        ucrChkLabel.AddParameterPresentCondition(False, "stat_sumary", False)
        ucrChkLabel.AddToLinkedControls(ucrReceiverLabelOutliers, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")

        ucrNudOutlierCoefficient.SetParameter(New RParameter("coef", iNewPosition:=1))
        ucrNudOutlierCoefficient.DecimalPlaces = 1
        ucrNudOutlierCoefficient.Increment = 0.1
        ucrNudOutlierCoefficient.SetRDefault(1.5)

        ucrNudOutlierCoefficient.SetLinkedDisplayControl(lblOutlierCoefficient)

        ucrPnlPlots.AddToLinkedControls({ucrNudOutlierCoefficient, ucrChkLabel}, {rdoBoxplot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        clsThemeFunc.SetPackageName("ggplot2")
        clsThemeFunc.SetRCommand("theme")
        clsThemeFunc.AddParameter("axis.text.x", clsRFunctionParameter:=clsTextElementFunc)
        clsTextElementFunc.SetPackageName("ggplot2")
        clsTextElementFunc.SetRCommand("element_text")
        clsTextElementFunc.AddParameter("angle", "90", iPosition:=0)
        clsTextElementFunc.AddParameter("hjust", "1", iPosition:=1)
        clsTextElementFunc.AddParameter("vjust", "0.5", iPosition:=2)

        ucrInputStation.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrInputYear.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputYear.SetDropDownStyleAsNonEditable()

        ucrInputWithinYear.SetItems({strXAxis, strColour, strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputWithinYear.SetDropDownStyleAsNonEditable()

        ucrSavePlot.SetPrefix("box_plot")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Store Graph")
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

        clsFilteredDataOperator = New ROperator
        clsFilterElementOperator = New ROperator
        clsFilterElementFunction = New RFunction
        clsAsFactorFunction = New RFunction
        clsLabelSummaryFunction = New RFunction
        clsAesLabelFunction = New RFunction

        clsRoundFunction = New RFunction
        clsLabelAfterFunction = New RFunction
        clsLengthFunction = New RFunction
        clsIfFunction = New RFunction
        clsBoxplotStatFunction = New RFunction

        clsGroupbyFunction = New RFunction
        clsBoxplotStat2Function = New RFunction
        clsMutateFunction = New RFunction
        clsUngroupFunction = New RFunction
        clsMutate2Function = New RFunction
        clsGeomTextFunction = New RFunction
        clsRaes2Function = New RFunction
        clsFilterElement2Function = New RFunction
        clsPositionNudgeFunction = New RFunction
        clsAsFactor2Function = New RFunction

        clsBraquetOperator = New ROperator
        clsSpaceOperator = New ROperator
        clsDollardOperator = New ROperator
        clsSemiCommatOperator = New ROperator
        clsEqualOperator = New ROperator
        clsAssigneOperator = New ROperator
        clsOpenBraquetOperator = New ROperator
        clsPipeOperator = New ROperator
        clsDollarSignOperator = New ROperator
        clsInOperator = New ROperator

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp, iPosition:=0)
        clsFacetFunction.AddParameter("drop", "FALSE", iPosition:=1)

        clsFilterElementOperator.SetOperation(">")
        clsFilterElementOperator.bBrackets = False

        clsFilterElementFunction.SetPackageName("dplyr")
        clsFilterElementFunction.SetRCommand("filter")
        clsFilterElementFunction.AddParameter("expression", clsROperatorParameter:=clsFilterElementOperator, bIncludeArgumentName:=False)

        clsFilteredDataOperator.SetOperation("%>%")
        clsFilteredDataOperator.bBrackets = False
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsFilteredDataOperator, iPosition:=0)

        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrReceiverElement.SetMeAsReceiver()

        ucrInputStation.SetName(strNone)
        ucrInputStation.bUpdateRCodeFromControl = True
        ucrInputYear.SetName(strNone)
        ucrInputYear.bUpdateRCodeFromControl = True
        ucrInputWithinYear.SetName(strXAxis)
        ucrInputWithinYear.bUpdateRCodeFromControl = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2) 'TODO Check this line

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsAsFactorFunction.SetPackageName("instatExtras")
        clsAsFactorFunction.SetRCommand("make_factor")
        clsAsFactorFunction.AddParameter("x", Chr(34) & Chr(34), bIncludeArgumentName:=False)

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_boxplot")
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE", iPosition:=0)

        clsLabelSummaryFunction.SetPackageName("ggplot2")
        clsLabelSummaryFunction.SetRCommand("stat_summary")
        clsLabelSummaryFunction.AddParameter("x", clsRFunctionParameter:=clsAesLabelFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsLabelSummaryFunction.AddParameter("geom", Chr(34) & "text" & Chr(34), iPosition:=1)
        clsLabelSummaryFunction.AddParameter("fun", clsROperatorParameter:=clsOpenBraquetOperator, iPosition:=2)
        clsLabelSummaryFunction.AddParameter("hjust", "-0.2", iPosition:=3)

        clsOpenBraquetOperator.SetOperation("{")
        clsOpenBraquetOperator.AddParameter("left", "\ (y)", iPosition:=0, bIncludeArgumentName:=False)
        clsOpenBraquetOperator.AddParameter("right", clsROperatorParameter:=clsAssigneOperator, bIncludeArgumentName:=False, iPosition:=1)

        clsAssigneOperator.SetOperation("<-")
        clsAssigneOperator.AddParameter("left", "o", iPosition:=0, bIncludeArgumentName:=False)
        clsAssigneOperator.AddParameter("right", clsROperatorParameter:=clsDollardOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsDollardOperator.SetOperation("$")
        clsDollardOperator.AddParameter("left", clsRFunctionParameter:=clsBoxplotStatFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDollardOperator.AddParameter("right", clsROperatorParameter:=clsSemiCommatOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsBoxplotStatFunction.SetPackageName("grDevices")
        clsBoxplotStatFunction.SetRCommand("boxplot.stats")
        clsBoxplotStatFunction.AddParameter("x", "y", iPosition:=0, bIncludeArgumentName:=False)

        clsSemiCommatOperator.SetOperation(";")
        clsSemiCommatOperator.AddParameter("left", "out", iPosition:=0, bIncludeArgumentName:=False)
        clsSemiCommatOperator.AddParameter("right", clsROperatorParameter:=clsSpaceOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsSpaceOperator.SetOperation("")
        clsSpaceOperator.AddParameter("left", clsRFunctionParameter:=clsIfFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOperator.AddParameter("right", clsROperatorParameter:=clsBraquetOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsIfFunction.SetRCommand("if")
        clsIfFunction.AddParameter("x", clsROperatorParameter:=clsEqualOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsEqualOperator.SetOperation("==")
        clsEqualOperator.AddParameter("left", clsRFunctionParameter:=clsLengthFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsEqualOperator.AddParameter("right", "0", iPosition:=1, bIncludeArgumentName:=False)

        clsLengthFunction.SetRCommand("length")
        clsLengthFunction.AddParameter("x", "o", iPosition:=0, bIncludeArgumentName:=False)

        clsBraquetOperator.SetOperation("}")
        clsBraquetOperator.AddParameter("left", "NaN else o", iPosition:=0, bIncludeArgumentName:=False)
        clsBraquetOperator.AddParameter("right", "", iPosition:=1, bIncludeArgumentName:=False)

        clsAesLabelFunction.SetRCommand("aes")
        clsAesLabelFunction.AddParameter("label", clsRFunctionParameter:=clsRoundFunction, iPosition:=0)

        clsRoundFunction.SetRCommand("round")
        clsRoundFunction.AddParameter("x", clsRFunctionParameter:=clsLabelAfterFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRoundFunction.AddParameter("y", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsLabelAfterFunction.SetPackageName("ggplot2")
        clsLabelAfterFunction.SetRCommand("after_stat")
        clsLabelAfterFunction.AddParameter("x", "y", iPosition:=0, bIncludeArgumentName:=False)

        clsGroupbyFunction.SetPackageName("dplyr")
        clsGroupbyFunction.SetRCommand("group_by")

        clsBoxplotStat2Function.SetPackageName("grDevices")
        clsBoxplotStat2Function.SetRCommand("boxplot.stats")

        clsDollarSignOperator.SetOperation("$")
        clsDollarSignOperator.AddParameter("x", clsRFunctionParameter:=clsBoxplotStat2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsDollarSignOperator.AddParameter("y", "out", iPosition:=1, bIncludeArgumentName:=False)
        clsDollarSignOperator.bSpaceAroundOperation = False

        clsInOperator.SetOperation("%in%")
        clsInOperator.AddParameter("y", clsROperatorParameter:=clsDollarSignOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("is_out", clsROperatorParameter:=clsInOperator, iPosition:=0)

        clsFilterElement2Function.SetPackageName("dplyr")
        clsFilterElement2Function.SetRCommand("filter")
        clsFilterElement2Function.AddParameter("x", "is_out", iPosition:=0, bIncludeArgumentName:=False)

        clsUngroupFunction.SetPackageName("dplyr")
        clsUngroupFunction.SetRCommand("ungroup")

        clsAsFactor2Function.SetPackageName("instatExtras")
        clsAsFactor2Function.SetRCommand("make_factor")

        clsMutate2Function.SetPackageName("dplyr")
        clsMutate2Function.SetRCommand("mutate")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.SetAssignTo("outliers")
        clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupbyFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsPipeOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterElement2Function, iPosition:=3, bIncludeArgumentName:=False)
        clsPipeOperator.AddParameter("ungroup", clsRFunctionParameter:=clsUngroupFunction, iPosition:=4, bIncludeArgumentName:=False)
        clsPipeOperator.AddParameter("mutate2", clsRFunctionParameter:=clsMutate2Function, iPosition:=5, bIncludeArgumentName:=False)

        clsRaes2Function.SetPackageName("ggplot2")
        clsRaes2Function.SetRCommand("aes")

        clsPositionNudgeFunction.SetPackageName("ggplot2")
        clsPositionNudgeFunction.SetRCommand("position_nudge")
        clsPositionNudgeFunction.AddParameter("x", "0.05", iPosition:=0)

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("data", "outliers", iPosition:=0)
        clsGeomTextFunction.AddParameter("x", clsRFunctionParameter:=clsRaes2Function, iPosition:=1, bIncludeArgumentName:=False)
        clsGeomTextFunction.AddParameter("hjust", "-0.2", iPosition:=2)
        clsGeomTextFunction.AddParameter("position", clsRFunctionParameter:=clsPositionNudgeFunction, iPosition:=3)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunc, bIncludeArgumentName:=False)

        clsXlabsFunction.AddParameter("label", "NULL", bIncludeArgumentName:=False)
        clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXlabsFunction, bIncludeArgumentName:=False)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeUpdated = False
        ucrNudOutlierCoefficient.AddAdditionalCodeParameterPair(clsBoxplotStatFunction, New RParameter("coef", 1), iAdditionalPairNo:=1)

        ucrReceiverLabelOutliers.SetRCode(clsRaes2Function, bReset)
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorClimaticBoxPlot.SetRCode(clsFilteredDataOperator, bReset)
        ucrSelectorClimaticBoxPlot.SetRCode(clsPipeOperator, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrNudOutlierCoefficient.SetRCode(clsRgeomPlotFunction, bReset)

        ucrReceiverElement.AddAdditionalCodeParameterPair(clsFilterElementOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement.SetRCode(clsRaesFunction, bReset)
        ucrChkOmitBelow.SetRCode(clsFilteredDataOperator, bReset)
        ucrNudOmitBelow.SetRCode(clsFilterElementOperator, bReset)
        If bReset Then
            ucrChkLabel.SetRCode(clsLabelSummaryFunction)
        End If
        bRCodeUpdated = True
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
        UpdateParameters()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If Not IsNothing(clsBaseOperator.GetParameter("facets")) Then
            bContainsFacet = True
        End If
        sdgPlots.SetRCode(clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                         clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction,
                         clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
                         clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction,
                         clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsFacetFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bReset:=bResetSubdialog)
        'this is a temporary fix because we have facets done on the main dialog
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        sdgPlots.tbpFacet.Enabled = True
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        bResetSubdialog = False

        If bContainsFacet Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
            bContainsFacet = False
        End If
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        If rdoBoxplot.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_boxplot")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("box_plot")
            End If
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("jitter")
            End If
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("violin")
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        SetOptionsButtonsText()
        autoTranslate(Me)
    End Sub

    Private Sub SetOptionsButtonsText()
        If rdoBoxplot.Checked Then
            cmdBoxPlotOptions.Text = "Boxplot Options"
        ElseIf rdoJitter.Checked Then
            cmdBoxPlotOptions.Text = "Jitter Options"
        Else
            cmdBoxPlotOptions.Text = "Violin Options"
        End If
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        'Making sure the filter isn't discarded
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsFilteredDataOperator, iPosition:=0)
        OmitFilter()
        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        If Not IsNothing(clsRgeomPlotFunction.GetParameter("coef")) Then
            ucrNudOutlierCoefficient.SetRCode(clsRgeomPlotFunction, bReset)
        End If
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
        Dim strMonthCol As String
        Dim strDataFrame As String
        Dim strRainCol As String
        Dim strTempCol As String

        strDataFrame = ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strMonthCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "month_label")
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")
        strTempCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "temp_min_label")
        If Not String.IsNullOrEmpty(strTempCol) Then
            ucrReceiverElement.Add(strTempCol, strDataFrame)
        Else
            ucrReceiverElement.Add(strRainCol, strDataFrame)

        End If
        If strMonthCol <> "" Then
            ucrReceiverWithinYear.Add(strMonthCol, strDataFrame)
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged, ucrInputYear.ControlValueChanged, ucrInputWithinYear.ControlValueChanged
        Dim ucrTempReciever As ucrReceiver = Nothing
        Dim strChangedText As String = ""

        If bUpdateComboOptions Then
            strChangedText = ucrChangedControl.GetText()
            If strChangedText <> strNone Then
                For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
                    If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetColAll AndAlso
                       Not strChangedText = strFacetRow AndAlso Not strChangedText = strFacetRowAll AndAlso
                       Not ucrInputTemp.Equals(ucrChangedControl) AndAlso ucrInputTemp.GetText() = strChangedText Then

                        bUpdateComboOptions = False
                        ucrInputTemp.SetName(strNone)
                        bUpdateComboOptions = True
                    End If

                    If (strChangedText = strFacetWrap AndAlso
                            (ucrInputTemp.GetText = strFacetRow OrElse ucrInputTemp.GetText = strFacetRowAll _
                             OrElse ucrInputTemp.GetText = strFacetCol OrElse ucrInputTemp.GetText = strFacetColAll)) _
                        OrElse (strChangedText = strFacetRow AndAlso ucrInputTemp.GetText = strFacetWrap) _
                        OrElse (strChangedText = strFacetRowAll AndAlso ucrInputTemp.GetText = strFacetWrap) _
                        OrElse (strChangedText = strFacetCol AndAlso ucrInputTemp.GetText = strFacetWrap) _
                        OrElse (strChangedText = strFacetColAll AndAlso ucrInputTemp.GetText = strFacetWrap) Then

                        ucrInputTemp.SetName(strNone)
                    End If

                    If (strChangedText = strFacetRow AndAlso ucrInputTemp.GetText = strFacetRowAll) _
                        OrElse (strChangedText = strFacetRowAll AndAlso ucrInputTemp.GetText = strFacetRow) Then
                        ucrInputTemp.SetName(strNone)
                    End If

                    If (strChangedText = strFacetCol AndAlso ucrInputTemp.GetText = strFacetColAll) _
                        OrElse (strChangedText = strFacetColAll AndAlso ucrInputTemp.GetText = strFacetCol) Then
                        ucrInputTemp.SetName(strNone)
                    End If
                Next
            End If

            UpdateParameters()
            AddRemoveFacets()
        End If

    End Sub

    Private Sub UpdateParameters()
        Dim strTemp As String = ""

        clsRaesFunction.RemoveParameterByName("x")
        clsRaesFunction.RemoveParameterByName("color")
        clsRaesFunction.RemoveParameterByName("fill")
        clsAsFactorFunction.RemoveParameterByName("x")

        For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
            clsFacetOp.RemoveParameterByName("wrap" & ucrInputTemp.Name)
            clsFacetColOp.RemoveParameterByName("col" & ucrInputTemp.Name)
            clsFacetRowOp.RemoveParameterByName("row" & ucrInputTemp.Name)
        Next
        clsBaseOperator.RemoveParameterByName("facets")

        bUpdatingParameters = True
        For Each ucrInputTemp As ucrInputComboBox In dctComboReceiver.Keys
            strTemp = ucrInputTemp.GetText()
            dctComboReceiver(ucrInputTemp).SetRCode(Nothing)

            If strTemp = strXAxis Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("x")
                dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(False)
                dctComboReceiver(ucrInputTemp).SetRCode(clsAsFactorFunction)
                clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsAsFactorFunction)

            ElseIf strTemp = strColour Then
                If rdoJitter.Checked Then
                    dctComboReceiver(ucrInputTemp).ChangeParameterName("color")
                    dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(True)
                ElseIf rdoBoxplot.Checked OrElse rdoViolin.Checked Then
                    dctComboReceiver(ucrInputTemp).ChangeParameterName("fill")
                    dctComboReceiver(ucrInputTemp).SetParameterIncludeArgumentName(True)
                End If
                dctComboReceiver(ucrInputTemp).SetRCode(clsRaesFunction)

            ElseIf strTemp = strFacetWrap Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("wrap" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetOp)

            ElseIf strTemp = strFacetCol OrElse strTemp = strFacetColAll Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("col" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetColOp)

            ElseIf strTemp = strFacetRow OrElse strTemp = strFacetRowAll Then
                dctComboReceiver(ucrInputTemp).ChangeParameterName("row" & ucrInputTemp.Name)
                dctComboReceiver(ucrInputTemp).SetRCode(clsFacetRowOp)
            End If
        Next

        If Not clsRaesFunction.ContainsParameter("x") Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If

        bUpdatingParameters = False
    End Sub


    Private Sub ucrSelectorClimaticBoxPlot_DataFrameChanged() Handles ucrSelectorClimaticBoxPlot.DataFrameChanged
        AutoFill()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub AddRemoveFacets()
        Dim strText As String
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

        If Not bUpdatingParameters Then
            clsBaseOperator.RemoveParameterByName("facets")

            For Each kvpTemp As KeyValuePair(Of ucrInputComboBox, ucrReceiverSingle) In dctComboReceiver
                strText = kvpTemp.Key.GetText()
                If (strText = strFacetWrap OrElse strText = strFacetCol OrElse strText = strFacetRow _
                OrElse strText = strFacetColAll OrElse strText = strFacetRowAll) AndAlso Not kvpTemp.Value.IsEmpty Then

                    If strText = strFacetWrap Then bWrap = True
                    If strText = strFacetCol Then bCol = True
                    If strText = strFacetRow Then bRow = True
                    If strText = strFacetColAll Then bColAll = True
                    If strText = strFacetRowAll Then bRowAll = True
                End If
            Next

            If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
            End If

            If bWrap Then
                clsFacetFunction.SetRCommand("facet_wrap")
                clsFacetOp.AddParameter("wrap", iPosition:=0)
            Else
                clsFacetOp.RemoveParameterByName("wrap")
            End If

            If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
                clsFacetFunction.SetRCommand("facet_grid")
            End If

            If bRow OrElse bRowAll Then
                clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
            ElseIf (bCol OrElse bColAll) AndAlso bWrap = False Then
                clsFacetOp.AddParameter("left", ".", iPosition:=0)
            Else
                clsFacetOp.RemoveParameterByName("left")
            End If

            If bCol OrElse bColAll Then
                clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
            ElseIf (bRow OrElse bRowAll) AndAlso bWrap = False Then
                clsFacetOp.AddParameter("right", ".", iPosition:=1)
            Else
                clsFacetOp.RemoveParameterByName("right")
            End If

            If bRowAll OrElse bColAll Then
                clsFacetFunction.AddParameter("margins", "TRUE")
            Else
                clsFacetFunction.RemoveParameterByName("margins")
            End If
        End If
    End Sub


    Private Sub OmitFilter()
        If ucrChkOmitBelow.Checked Then
            clsFilteredDataOperator.AddParameter("right", clsRFunctionParameter:=clsFilterElementFunction, iPosition:=1)
        Else
            clsFilteredDataOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddOutlierFunctions()
        If ucrChkLabel.Checked AndAlso Not ucrReceiverLabelOutliers.IsEmpty Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPipeOperator, iPosition:=0)
            If clsBaseOperator.ContainsParameter("label") Then
                clsBaseOperator.RemoveParameterByName("label")
                clsBaseOperator.AddParameter("x", clsRFunctionParameter:=clsGeomTextFunction, bIncludeArgumentName:=False)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("x")
            clsBaseOperator.AddParameter("label", clsRFunctionParameter:=clsLabelSummaryFunction, bIncludeArgumentName:=False)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPipeOperator)
        End If
    End Sub

    Private Sub ucrChkLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabel.ControlValueChanged
        If ucrChkLabel.Checked Then
            clsBaseOperator.AddParameter("label", clsRFunctionParameter:=clsLabelSummaryFunction, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("label")
        End If
        AddOutlierFunctions()
    End Sub

    Private Sub ucrReceiverLabelOutliers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabelOutliers.ControlValueChanged
        AddOutlierFunctions()
    End Sub

    Private Sub ucrChkOmitBelow_CheckedChanged() Handles ucrChkOmitBelow.ControlValueChanged
        OmitFilter()
    End Sub
    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverWithinYear.ControlValueChanged, ucrReceiverYear.ControlValueChanged
        AddRemoveFacets()
    End Sub

    Private Sub ucrReceiverWithinYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWithinYear.ControlValueChanged
        If Not ucrReceiverWithinYear.IsEmpty Then
            clsGroupbyFunction.AddParameter("x", ucrReceiverWithinYear.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
            clsAsFactor2Function.AddParameter("x", ucrReceiverWithinYear.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
            clsMutate2Function.AddParameter(ucrReceiverWithinYear.GetVariableNames(bWithQuotes:=False), clsRFunctionParameter:=clsAsFactor2Function, iPosition:=0)
        Else
            clsGroupbyFunction.RemoveParameterByName("x")
            clsAsFactor2Function.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged
        If Not ucrReceiverElement.IsEmpty Then
            clsBoxplotStat2Function.AddParameter("x", ucrReceiverElement.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
            clsInOperator.AddParameter("x", ucrReceiverElement.GetVariableNames(bWithQuotes:=False), iPosition:=0)
        Else
            clsBoxplotStat2Function.RemoveParameterByName("x")
            clsInOperator.RemoveParameterByName("x")
        End If

    End Sub

    Private Sub AddCoefficients()
        If clsBoxplotStat2Function IsNot Nothing Then
            If Not ucrNudOutlierCoefficient.IsEmpty Then
                clsBoxplotStat2Function.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=1)
            Else
                clsBoxplotStat2Function.RemoveParameterByName("coef")
            End If
        End If
    End Sub
    Private Sub ucrNudOutlierCoefficient_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudOutlierCoefficient.ControlValueChanged, ucrChkLabel.ControlValueChanged
        AddCoefficients()
        If clsBoxplotStatFunction IsNot Nothing Then
            If ucrChkLabel.Checked Then
                If Not ucrNudOutlierCoefficient.IsEmpty Then
                    clsBoxplotStatFunction.AddParameter("coef", ucrNudOutlierCoefficient.GetText(), iPosition:=1)
                Else
                    clsBoxplotStatFunction.RemoveParameterByName("coef")
                End If
            Else
                clsBoxplotStatFunction.RemoveParameterByName("coef")
            End If
        End If
    End Sub
End Class
