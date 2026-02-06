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

Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRScatterGeomFunction, clsLabelFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsGroupAesFuction As New RFunction
    Private clsGroupAesVarFuction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetlayerSubdialog As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabsFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsFacetsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsGeomSmoothFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsGeomRugFunction As New RFunction
    Private clsGeomJitterFunction As New RFunction
    Private clsCountGeomFunction, clsDummyFunction As New RFunction

    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsVarsFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction

    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strFacetRowAll As String = "Facet Row + O"
    Private ReadOnly strFacetColAll As String = "Facet Col + O"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False
    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strGeomSmoothParameterName As String = "geom_smooth"
    Private strGeomTextRepelParameterName As String = "geom_text_repel"
    Private strGeomJitterParameterName As String = "geom_jitter"
    Private strGeomCountParameterName As String = "geom_count"
    Private strGeomParameterNames() As String = {strFirstParameterName, strGeomJitterParameterName, strGeomCountParameterName, strGeomSmoothParameterName, strGeomTextRepelParameterName}
    Private strPickColour As String = "Pick Colour..."
    Private dlgColour As New ColorDialog

    Private Sub dlgScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim clsGeomRugParameter As New RParameter
        Dim dctSidesOptions As New Dictionary(Of String, String)
        Dim dctShapePoint As New Dictionary(Of String, String)
        Dim dctPositioncount As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 433
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorForScatter.SetParameter(New RParameter("data", 0))
        ucrSelectorForScatter.SetParameterIsrfunction()

        ucrVariablesAsFactorForScatter.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForScatter.SetParameterIsString()
        ucrVariablesAsFactorForScatter.bWithQuotes = False
        ucrVariablesAsFactorForScatter.Selector = ucrSelectorForScatter
        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForScatter.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForScatter.bAddParameterIfEmpty = True

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrReceiverLabel.SetParameter(New RParameter("label"))
        ucrReceiverLabel.SetParameterIsString()
        ucrReceiverLabel.bWithQuotes = False
        ucrReceiverLabel.Selector = ucrSelectorForScatter
        ucrReceiverLabel.strSelectorHeading = "Variables"

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.SetParameterIsString()
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.strSelectorHeading = "Variables"

        ucrChkLineofBestFit.SetText("Line of Best Fit")
        ucrChkLineofBestFit.AddParameterPresentCondition(True, "geom_smooth")
        ucrChkLineofBestFit.AddParameterPresentCondition(False, "geom_smooth", False)
        ucrChkLineofBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.SetParameter(New RParameter("se"), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrChkAddRugPlot.SetText("Rug Plot")
        ucrChkAddRugPlot.AddParameterPresentCondition(True, "geom_rug")
        ucrChkAddRugPlot.AddParameterPresentCondition(False, "geom_rug", False)
        ucrChkAddRugPlot.AddToLinkedControls({ucrNudSize, ucrInputSides}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSidePlot.SetText("Side Plot")
        ucrChkAddSidePlot.Enabled = False

        ucrChkSize.SetText("Size")
        ucrChkSize.AddParameterPresentCondition(True, "geom_point")
        ucrChkSize.AddParameterPresentCondition(False, "geom_point", False)
        ucrChkSize.AddToLinkedControls({ucrNudPointsize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkShape.SetText("Shape")
        ucrChkShape.AddParameterPresentCondition(True, "geom_point")
        ucrChkShape.AddParameterPresentCondition(False, "geom_point", False)
        ucrChkShape.AddToLinkedControls({ucrInputShape}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkColour.SetText("Colour")
        ucrChkColour.AddParameterPresentCondition(True, "geom_count")
        ucrChkColour.AddParameterPresentCondition(False, "geom_count", False)
        ucrChkColour.AddToLinkedControls({ucrInputColour}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPosition.SetText("Position")
        ucrChkPosition.AddParameterPresentCondition(True, "geom_count")
        ucrChkPosition.AddParameterPresentCondition(False, "geom_count", False)
        ucrChkPosition.AddToLinkedControls({ucrInputPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlGeoms.AddRadioButton(rdoJitter)
        ucrPnlGeoms.AddRadioButton(rdoPoint)
        ucrPnlGeoms.AddRadioButton(rdoCount)
        ucrPnlGeoms.SetParameter(New RParameter("checked", 9))
        ucrPnlGeoms.AddParameterValuesCondition(rdoPoint, "checked", "geom_point")
        ucrPnlGeoms.AddParameterValuesCondition(rdoCount, "checked", "geom_count")
        ucrPnlGeoms.AddParameterValuesCondition(rdoJitter, "checked", "geom_jitter")
        ucrPnlGeoms.AddToLinkedControls({ucrNudWidth, ucrNudHeigth}, {rdoJitter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.40")
        ucrPnlGeoms.AddToLinkedControls({ucrNudPointsize, ucrChkSize, ucrInputShape, ucrChkShape}, {rdoPoint}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGeoms.AddToLinkedControls({ucrInputPosition}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="identity")
        ucrPnlGeoms.AddToLinkedControls({ucrInputColour}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrPnlGeoms.AddToLinkedControls({ucrChkPosition, ucrChkColour}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveScatterPlot.SetPrefix("scatter_plot")
        ucrSaveScatterPlot.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph,
                                       strRObjectFormat:=RObjectFormat.Image)
        ucrSaveScatterPlot.SetDataFrameSelector(ucrSelectorForScatter.ucrAvailableDataFrames)
        ucrSaveScatterPlot.SetCheckBoxText("Store Graph")
        ucrSaveScatterPlot.SetIsComboBox()
        ucrSaveScatterPlot.SetAssignToIfUncheckedValue("last_graph")

        ucrNudSize.SetParameter(New RParameter("size", 0))
        ucrNudSize.Increment = 0.1
        ucrNudSize.DecimalPlaces = 1
        ucrNudSize.SetRDefault("0.5")

        ucrNudHeigth.SetParameter(New RParameter("height", 5))
        ucrNudHeigth.Maximum = 0.5
        ucrNudHeigth.Minimum = 0
        ucrNudHeigth.Increment = 0.01
        ucrNudHeigth.DecimalPlaces = 2

        ucrNudWidth.SetParameter(New RParameter("width", 6))
        ucrNudWidth.Maximum = 0.5
        ucrNudWidth.Minimum = 0
        ucrNudWidth.Increment = 0.01
        ucrNudWidth.DecimalPlaces = 2

        ucrNudPointsize.SetParameter(New RParameter("size", 7))
        ucrNudPointsize.Increment = 0.1
        ucrNudPointsize.DecimalPlaces = 1
        ucrNudPointsize.SetRDefault("1.5")

        ucrInputShape.SetParameter(New RParameter("shape", 8))
        dctShapePoint.Add("Circle", Chr(34) & "circle" & Chr(34))
        dctShapePoint.Add("Circle Open", Chr(34) & "circle open" & Chr(34))
        dctShapePoint.Add("Circle Filled", Chr(34) & "circle filled" & Chr(34))
        dctShapePoint.Add("Circle Cross", Chr(34) & "circle cross" & Chr(34))
        dctShapePoint.Add("circle Plus", Chr(34) & "circle plus" & Chr(34))
        dctShapePoint.Add("Circle Small", Chr(34) & "circle small" & Chr(34))
        dctShapePoint.Add("Bullet", Chr(34) & "bullet" & Chr(34))
        dctShapePoint.Add("Square", Chr(34) & "square" & Chr(34))
        dctShapePoint.Add("Square Triangle", Chr(34) & "square triangle" & Chr(34))
        dctShapePoint.Add("Square Plus", Chr(34) & "square plus" & Chr(34))
        dctShapePoint.Add("Square Cross", Chr(34) & "square cross" & Chr(34))
        dctShapePoint.Add("Square Filled", Chr(34) & "square filled" & Chr(34))
        dctShapePoint.Add("Square Open", Chr(34) & "square open" & Chr(34))
        dctShapePoint.Add("Diamond", Chr(34) & "diamond" & Chr(34))
        dctShapePoint.Add("Diamond Open", Chr(34) & "diamond open" & Chr(34))
        dctShapePoint.Add("Diamond Filled", Chr(34) & "diamond filled" & Chr(34))
        dctShapePoint.Add("Diamond Plus", Chr(34) & "diamond plus" & Chr(34))
        dctShapePoint.Add("Triangle", Chr(34) & "triangle" & Chr(34))
        dctShapePoint.Add("Triangle Open", Chr(34) & "triangle open" & Chr(34))
        dctShapePoint.Add("Triangle Filled", Chr(34) & "triangle filled" & Chr(34))
        dctShapePoint.Add("Triangle Square", Chr(34) & "triangle square" & Chr(34))
        dctShapePoint.Add("Triangle Down Open", Chr(34) & "triangle down open" & Chr(34))
        dctShapePoint.Add("Triangle Down Filled", Chr(34) & "triangle down filled" & Chr(34))
        dctShapePoint.Add("Plus", Chr(34) & "plus" & Chr(34))
        dctShapePoint.Add("Cross", Chr(34) & "cross" & Chr(34))
        dctShapePoint.Add("Asterisk", Chr(34) & "asterisk" & Chr(34))
        ucrInputShape.SetItems(dctShapePoint)
        ucrInputShape.SetRDefault(Chr(34) & "circle" & Chr(34))
        ucrInputShape.SetDropDownStyleAsNonEditable()

        ucrInputPosition.SetParameter(New RParameter("position", 10))
        ucrInputPosition.SetItems({"identity", "stack", "dodge", "jitter", "fill", "position_dodge", "position_jitter(width=0.2,height=0.0)"})
        ucrInputPosition.SetDropDownStyleAsNonEditable()

        ucrInputColour.SetParameter(New RParameter("colour", 11))
        ucrInputColour.SetItems({"NULL", strPickColour, "Black", "White", "Blue", "Red", "Yellow", "Purple", "Green", "Orange", "Grey", "Brown", "Pink"})
        ucrInputColour.SetDropDownStyleAsNonEditable()
        ucrInputColour.AddQuotesIfUnrecognised = True

        ucrInputSides.SetParameter(New RParameter("sides", 1))
        dctSidesOptions.Add("Bottom and left", Chr(34) & "bl" & Chr(34))
        dctSidesOptions.Add("Top, right and bottom", Chr(34) & "trb" & Chr(34))
        dctSidesOptions.Add("Top, right and left", Chr(34) & "trl" & Chr(34))
        dctSidesOptions.Add("Top, bottom and left", Chr(34) & "tbl" & Chr(34))
        dctSidesOptions.Add("Right, bottom and left", Chr(34) & "rbl" & Chr(34))
        dctSidesOptions.Add("Top and right", Chr(34) & "tr" & Chr(34))
        dctSidesOptions.Add("Top and bottom", Chr(34) & "tb" & Chr(34))
        dctSidesOptions.Add("Top and left", Chr(34) & "tl" & Chr(34))
        dctSidesOptions.Add("Right and bottom", Chr(34) & "rb" & Chr(34))
        dctSidesOptions.Add("Right and left", Chr(34) & "rl" & Chr(34))
        dctSidesOptions.Add("Top", Chr(34) & "t" & Chr(34))
        dctSidesOptions.Add("Right", Chr(34) & "r" & Chr(34))
        dctSidesOptions.Add("Bottom", Chr(34) & "b" & Chr(34))
        dctSidesOptions.Add("Left", Chr(34) & "l" & Chr(34))
        ucrInputSides.SetItems(dctSidesOptions)
        ucrInputSides.SetRDefault(Chr(34) & "bl" & Chr(34))
        ucrInputSides.SetDropDownStyleAsNonEditable()

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
        ucr1stFactorReceiver.Selector = ucrSelectorForScatter
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)
        ucr1stFactorReceiver.SetLinkedDisplayControl(lblFacetBy)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strFacetRowAll, strFacetColAll, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()


        ucrNudSize.SetLinkedDisplayControl(lblSize)
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)
        ucrNudHeigth.SetLinkedDisplayControl(lblHeith)
        ucrInputSides.SetLinkedDisplayControl(lblSides)

    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRScatterGeomFunction = New RFunction
        clsLabelFunction = New RFunction
        clsRaesFunction = New RFunction
        clsGeomSmoothFunction = New RFunction
        clsGeomRugFunction = New RFunction
        clsGeomJitterFunction = New RFunction
        clsCountGeomFunction = New RFunction
        clsDummyFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsVarsFunction = New RFunction
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsGroupAesFuction = New RFunction
        clsGroupAesVarFuction = New RFunction


        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrSelectorForScatter.Reset()
        ucrSelectorForScatter.SetGgplotFunction(clsBaseOperator)
        ucrSaveScatterPlot.Reset()
        ucrVariablesAsFactorForScatter.SetMeAsReceiver()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetlayerSubdialog = True

        toolStripMenuItemRugOptions.Enabled = False
        toolStripMenuItemSmoothOptions.Enabled = False
        toolStripMenuItemTextrepelOptions.Enabled = False
        toolStripMenuItemJitterOptions.Enabled = False
        toolStripMenuItemCountOptions.Enabled = False

        clsDummyFunction.AddParameter("checked", "geom_point", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRScatterGeomFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsRScatterGeomFunction.SetPackageName("ggplot2")
        clsRScatterGeomFunction.SetRCommand("geom_point")

        clsCountGeomFunction.SetPackageName("ggplot2")
        clsCountGeomFunction.SetRCommand("geom_count")

        clsLabelFunction.SetPackageName("ggrepel")
        clsLabelFunction.SetRCommand("geom_text_repel")

        clsGroupAesFuction.SetPackageName("ggplot2")
        clsGroupAesFuction.SetRCommand("aes")

        clsGroupAesVarFuction.SetPackageName("ggplot2")
        clsGroupAesVarFuction.SetRCommand("aes")

        clsGeomRugFunction.SetPackageName("ggplot2")
        clsGeomRugFunction.SetRCommand("geom_rug")
        clsGeomRugFunction.AddParameter("size", 0.5, iPosition:=0)

        clsGeomJitterFunction.SetPackageName("ggplot2")
        clsGeomJitterFunction.SetRCommand("geom_jitter")
        clsGeomJitterFunction.AddParameter("width", 0.4, iPosition:=0)
        clsGeomJitterFunction.AddParameter("height", 0.4, iPosition:=1)

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False

        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsFacetsFunction = GgplotDefaults.clsFacetFunction.Clone()
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

        clsGeomSmoothFunction.SetPackageName("ggplot2")
        clsGeomSmoothFunction.SetRCommand("geom_smooth")
        clsGeomSmoothFunction.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunction.AddParameter("se", "FALSE", iPosition:=1)

        clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorForScatter.strCurrentDataFrame,
                                           strObjectName:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorForScatter.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrReceiverLabel.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForScatter.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrChkLineofBestFit.SetRCode(clsBaseOperator, bReset)
        ucrSaveScatterPlot.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunction, bReset)
        ucrChkAddRugPlot.SetRCode(clsBaseOperator, bReset)
        ucrNudSize.SetRCode(clsGeomRugFunction, bReset)
        ucrNudHeigth.SetRCode(clsGeomJitterFunction, bReset)
        ucrNudWidth.SetRCode(clsGeomJitterFunction, bReset)
        ucrInputSides.SetRCode(clsGeomRugFunction, bReset)
        ucrInputShape.SetRCode(clsRScatterGeomFunction, bReset)
        ucrNudPointsize.SetRCode(clsRScatterGeomFunction, bReset)
        ucrInputColour.SetRCode(clsCountGeomFunction, bReset)
        ucrInputPosition.SetRCode(clsCountGeomFunction, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrPnlGeoms.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        ' Either y or x can be empty but not both
        If (Not ucrSaveScatterPlot.IsComplete) OrElse (ucrVariablesAsFactorForScatter.IsEmpty AndAlso ucrReceiverX.IsEmpty()) Then
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

    Private Sub ucrChkLineofBestFit_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLineofBestFit.ControlValueChanged
        If ucrChkLineofBestFit.Checked Then
            clsBaseOperator.AddParameter("geom_smooth", clsRFunctionParameter:=clsGeomSmoothFunction, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_smooth")
        End If
        toolStripMenuItemSmoothOptions.Enabled = ucrChkLineofBestFit.Checked
    End Sub

    Private Sub ucrChkAddRugPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddRugPlot.ControlValueChanged
        If ucrChkAddRugPlot.Checked Then
            clsBaseOperator.AddParameter("geom_rug", clsRFunctionParameter:=clsGeomRugFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("geom_rug")
        End If
        toolStripMenuItemRugOptions.Enabled = ucrChkAddRugPlot.Checked
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
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewGlobalAesFunction:=clsRaesFunction,
                          clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                          clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                          clsNewYScaleDateFunction:=clsYScaleDateFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSelectorForScatter,
                          strMainDialogGeomParameterNames:=strGeomParameterNames, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        ucr1stFactorReceiver.Add(sdgPlots.ucr1stFactorReceiver.GetText)
        bResetSubdialog = False
    End Sub
    Private Sub toolStripMenuItemPointOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemPointOptions.Click
        EnableDisableOptions(clsRScatterGeomFunction)
    End Sub

    Private Sub toolStripMenuItemRugOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemRugOptions.Click
        EnableDisableOptions(clsGeomRugFunction)
    End Sub

    Private Sub toolStripMenuItemSmoothOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemSmoothOptions.Click
        EnableDisableOptions(clsGeomSmoothFunction)
    End Sub

    Private Sub toolStripMenuItemTextrepelOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTextrepelOptions.Click
        EnableDisableOptions(clsLabelFunction)
    End Sub

    Private Sub toolStripMenuItemJitterOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemJitterOptions.Click
        EnableDisableOptions(clsGeomJitterFunction)
    End Sub

    Private Sub toolStripMenuItemCountOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemCountOptions.Click
        EnableDisableOptions(clsCountGeomFunction)
    End Sub

    Private Sub EnableDisableOptions(clsTempFunction As RFunction)
        'SetupLayer sends the components storing the plot info (clsRaesFunction, clsRggplotFunction, ...) of dlgScatteredPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsTempFunction,
                                   clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction,
                                   bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorForScatter, bApplyAesGlobally:=True,
                                   bReset:=bResetlayerSubdialog)
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.
        sdgLayerOptions.ShowDialog()
        ucrReceiverLabel.SetRCode(clsRaesFunction, bReset)
        bResetlayerSubdialog = False
        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            Select Case clsParam.strArgumentName
                Case "x"
                    If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                        ucrReceiverX.Clear()
                    Else
                        ucrReceiverX.Add(clsParam.strArgumentValue)
                    End If
                Case "y"
                    ' If we are in multiple variables mode and 'y = value', 
                    '     then we should not write 'value' to the multiple variables receiver
                    If Not ucrVariablesAsFactorForScatter.bSingleVariable _
                            AndAlso clsParam.strArgumentValue Is "value" Then
                        Exit Select
                    End If

                    If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                        ucrVariablesAsFactorForScatter.Clear()
                    Else
                        ucrVariablesAsFactorForScatter.Add(clsParam.strArgumentValue)
                    End If
                Case "colour"
                    ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End Select
        Next
    End Sub

    Private Sub ucrSaveScatterPlot_ContentsChanged() Handles ucrSaveScatterPlot.ControlContentsChanged,
        ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForScatter.ControlContentsChanged, ucrSaveScatterPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLabel.ControlValueChanged
        If ucrReceiverLabel.IsEmpty Then
            clsBaseOperator.RemoveParameterByName(strGeomTextRepelParameterName)
        Else
            clsBaseOperator.AddParameter(strGeomTextRepelParameterName, clsRFunctionParameter:=clsLabelFunction, iPosition:=3)
        End If
        toolStripMenuItemTextrepelOptions.Enabled = Not ucrReceiverLabel.IsEmpty
    End Sub

    Private Sub ucrPnlGeoms_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGeoms.ControlValueChanged, ucrNudHeigth.ControlValueChanged, ucrNudWidth.ControlValueChanged, ucrInputColour.ControlValueChanged, ucrInputPosition.ControlValueChanged, ucrInputShape.ControlValueChanged, ucrNudPointsize.ControlValueChanged
        If rdoJitter.Checked Then
            clsGeomJitterFunction.AddParameter("width", ucrNudWidth.GetText, iPosition:=0)
            clsGeomJitterFunction.AddParameter("height", ucrNudHeigth.GetText, iPosition:=1)
            clsBaseOperator.AddParameter(strGeomJitterParameterName, clsRFunctionParameter:=clsGeomJitterFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName(strFirstParameterName)
            clsBaseOperator.RemoveParameterByName(strGeomCountParameterName)
        ElseIf rdoPoint.Checked Then
            clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRScatterGeomFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName(strGeomJitterParameterName)
            clsBaseOperator.RemoveParameterByName(strGeomCountParameterName)
        ElseIf rdoCount.Checked Then
            ChangePositionCount()
            ChangeCountColour()
            clsBaseOperator.AddParameter(strGeomCountParameterName, clsRFunctionParameter:=clsCountGeomFunction, iPosition:=2)
            clsBaseOperator.RemoveParameterByName(strGeomJitterParameterName)
            clsBaseOperator.RemoveParameterByName(strFirstParameterName)
        End If
        toolStripMenuItemJitterOptions.Enabled = rdoJitter.Checked
        toolStripMenuItemCountOptions.Enabled = rdoCount.Checked
    End Sub

    Private Sub ChangePositionCount()
        If ucrInputPosition.GetText = "position_jitter(width=0.2,height=0.0)" Then
            clsCountGeomFunction.AddParameter("position", "position_jitter(width=0.2,height=0.0)", iPosition:=0)
        Else
            clsCountGeomFunction.AddParameter("position", Chr(34) & ucrInputPosition.GetText & Chr(34), iPosition:=0)
        End If
    End Sub

    Private Sub ChangeCountColour()
        If ucrChkColour.Checked Then
            clsCountGeomFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText & Chr(34), iPosition:=11)
        Else
            clsCountGeomFunction.RemoveParameterByName("colour")
        End If

    End Sub

    Private Sub AutoFacetStation()
        Dim currentReceiver As ucrReceiver = ucrSelectorForScatter.CurrentReceiver

        If currentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
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
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol, strFacetColAll
                ucr1stFactorReceiver.ChangeParameterName("cols" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
            Case strFacetRow, strFacetRowAll
                ucr1stFactorReceiver.ChangeParameterName("rows" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsVarsFunction)
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
        Dim bColAll As Boolean = False
        Dim bRowAll As Boolean = False

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
                Case strFacetColAll
                    bColAll = True
                Case strFacetRowAll
                    bRowAll = True
            End Select
        End If
        If bWrap OrElse bRow OrElse bCol OrElse bColAll OrElse bRowAll Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If

        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)
        End If

        If bRow OrElse bCol OrElse bRowAll OrElse bColAll Then
            clsFacetFunction.SetRCommand("facet_grid")
            clsFacetFunction.RemoveParameterByName("facets")
        End If

        If bRowAll OrElse bColAll Then
            clsFacetFunction.AddParameter("margin", "TRUE", iPosition:=1)
        Else
            clsFacetFunction.RemoveParameterByName("margin")
        End If

        If bRow OrElse bRowAll Then
            clsFacetFunction.AddParameter("rows", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)
        Else
            clsFacetFunction.RemoveParameterByName("rows")
        End If

        If bCol OrElse bColAll Then
            clsFacetFunction.AddParameter("cols", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)
        Else
            clsFacetFunction.RemoveParameterByName("cols")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
        AddRemoveGroupAesVar()
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
        If ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorForScatter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForScatter.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub AddRemoveGroupAesVar()
        clsGroupAesFuction.RemoveParameterByName("group")
        clsGroupAesVarFuction.RemoveParameterByName("group")
        clsGeomSmoothFunction.RemoveParameterByName("group_aes")
        clsGeomSmoothFunction.RemoveParameterByName("group_aes1")
        If Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType = "factor" OrElse ucrReceiverX.strCurrDataType = "ordered,factor" Then
            If Not ucrFactorOptionalReceiver.IsEmpty AndAlso ucrFactorOptionalReceiver.strCurrDataType = "factor" OrElse ucrFactorOptionalReceiver.strCurrDataType = "ordered,factor" Then
                ' Add group parameter with variable names
                clsGroupAesFuction.AddParameter("group", ucrFactorOptionalReceiver.GetVariableNames(False), iPosition:=0)
                clsGeomSmoothFunction.AddParameter("group_aes1", clsRFunctionParameter:=clsGroupAesFuction, bIncludeArgumentName:=False)
                clsGroupAesVarFuction.RemoveParameterByName("group")
                clsGeomSmoothFunction.RemoveParameterByName("group_aes")
            Else
                ' Add group parameter without variable names
                clsGroupAesVarFuction.AddParameter("group", 1, iPosition:=0)
                clsGeomSmoothFunction.AddParameter("group_aes", clsRFunctionParameter:=clsGroupAesVarFuction, bIncludeArgumentName:=False)
                clsGroupAesFuction.RemoveParameterByName("group")
                clsGeomSmoothFunction.RemoveParameterByName("group_aes1")
            End If
        Else
            ' Remove group parameters
            clsGroupAesFuction.RemoveParameterByName("group")
            clsGroupAesVarFuction.RemoveParameterByName("group")
            clsGeomSmoothFunction.RemoveParameterByName("group_aes")
            clsGeomSmoothFunction.RemoveParameterByName("group_aes1")
        End If
    End Sub

    Private Sub ucrChkSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSize.ControlValueChanged, ucrNudPointsize.ControlValueChanged
        If ucrChkSize.Checked AndAlso (Not ucrNudPointsize.IsEmpty) Then
            clsRScatterGeomFunction.AddParameter("size", ucrNudPointsize.GetText, iPosition:=0)
        Else
            clsRScatterGeomFunction.RemoveParameterByName("size")
        End If
    End Sub

    Private Sub ucrInputColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputColour.ControlValueChanged
        Dim strColourItem As String
        Dim clrTemp As Color

        If ucrInputColour.GetText() = strPickColour Then
            Try
                If dlgColour.ShowDialog() = DialogResult.OK Then
                    clrTemp = dlgColour.Color
                    'first two character from Hex are fixed as FF for VB use, not part of colour value
                    'ggplot requires # in front of Hex colour values
                    strColourItem = "#" & Hex(clrTemp.ToArgb).Substring(2, 6)
                    'First item is NULL and needs to be changed before setting text otherwise value will not show in combobox
                    ucrInputColour.cboInput.Items.Item(0) = strColourItem
                    ucrInputColour.SetName(strColourItem)
                Else
                    ucrInputColour.SetName("NULL")
                End If
            Catch ex As Exception
                dlgColour.Dispose()
            End Try
        End If
    End Sub
End Class
