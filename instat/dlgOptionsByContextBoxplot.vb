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

Public Class dlgOptionsByContextBoxplot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private bDefaultsSet As Boolean = True
    Private bRCodeUpdated As Boolean = True
    Private bUpdating As Boolean = False

    ' Main functions and operator for ggplot
    Public clsBaseOperator As New ROperator
    Public clsRggPlotFunction As New RFunction
    Public clsRaesGlobalFunction As New RFunction
    Public clsRaesBoxplotFunction As New RFunction

    ' Geoms (layers)
    Public clsBoxplotViolinGeom As New RFunction
    Public clsJitterGeom As New RFunction
    Public clsHlineGeom As New RFunction

    ' Not yet implemented
    ' Additional functions for plot subdialog
    Public clsLabsFunction As New RFunction
    Public clsXLabsFunction As New RFunction
    Public clsYLabFunction As New RFunction
    Public clsXScaleContinuousFunction As New RFunction
    Public clsYScaleContinuousFunction As New RFunction
    Public clsThemeFunction As New RFunction
    Public dctThemeFunctions As Dictionary(Of String, RFunction)

    ' Facet functions
    Public clsFacetFunction As New RFunction
    Public clsFacetOp As New ROperator
    Public clsFacetRowOp As New ROperator
    Public clsFacetColOp As New ROperator

    Private strFacetRow As String = "Facet Row"
    Private strFacetCol As String = "Facet Column"
    Private strColour As String = "Colour"
    Private strNone As String = "None"

    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction

    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private Sub dlgOptionsByContextBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorPlot.SetParameterIsrfunction()

        ucrReceiverMeasurement.SetParameter(New RParameter("y", 1))
        ucrReceiverMeasurement.Selector = ucrSelectorPlot
        ucrReceiverMeasurement.SetIncludedDataTypes({"numeric"})
        ucrReceiverMeasurement.strSelectorHeading = "Measurements"
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.bWithQuotes = False
        ucrReceiverMeasurement.SetOptionsByContextTypesAllMeasurements()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.Selector = ucrSelectorPlot
        ucrReceiverX.SetIncludedDataTypes({"factor"})
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.AddParameterPresentCondition(True, "geom_jitter")
        ucrChkIncludePoints.AddParameterPresentCondition(False, "geom_jitter", False)

        ucrChkIncludePoints.AddToLinkedControls(ucrInputJitter, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIncludePoints.AddToLinkedControls(ucrNudTransparency, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputJitter.SetParameter(New RParameter("width", iNewPosition:=4))
        ucrInputJitter.SetLinkedDisplayControl(lblJitter)
        ucrInputJitter.SetValidationTypeAsNumeric()
        ucrInputJitter.AddQuotesIfUnrecognised = False

        ucrNudTransparency.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudTransparency.SetLinkedDisplayControl(lblTransparency)
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01

        ucrChkIncludeHline.SetText("Include Horizontal Line")
        ucrChkIncludeHline.bAddRemoveParameter = True
        ucrChkIncludeHline.bChangeParameterValue = False
        ucrChkIncludeHline.AddParameterPresentCondition(True, "geom_hline")
        ucrChkIncludeHline.AddParameterPresentCondition(False, "geom_hline", False)
        ucrChkIncludeHline.AddToLinkedControls(ucrInputHlineValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputHlineValue.SetParameter(New RParameter("yintercept", iNewPosition:=2))
        ucrInputHlineValue.SetLinkedDisplayControl(lblHlineValue)
        ucrInputHlineValue.SetValidationTypeAsNumeric()
        ucrInputHlineValue.AddQuotesIfUnrecognised = False

        ucrReceiverContext1.SetParameter(New RParameter("1", iNewPosition:=1))
        ucrReceiverContext1.Selector = ucrSelectorPlot
        ucrReceiverContext1.SetParameterIsString()
        ucrReceiverContext1.bWithQuotes = False
        ucrReceiverContext1.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext1.SetOptionsByContextTypesAllOptionsContextsBlockings()

        ucrReceiverContext2.SetParameter(New RParameter("2", iNewPosition:=2))
        ucrReceiverContext2.Selector = ucrSelectorPlot
        ucrReceiverContext2.SetParameterIsString()
        ucrReceiverContext2.bWithQuotes = False
        ucrReceiverContext2.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext2.SetOptionsByContextTypesAllOptionsContextsBlockings()

        ucrReceiverContext3.SetParameter(New RParameter("3", iNewPosition:=3))
        ucrReceiverContext3.Selector = ucrSelectorPlot
        ucrReceiverContext3.SetParameterIsString()
        ucrReceiverContext3.bWithQuotes = False
        ucrReceiverContext3.strSelectorHeading = "Contexts,Options,Blocks"
        ucrReceiverContext3.SetOptionsByContextTypesAllOptionsContextsBlockings()

        ucrInputContext1.SetItems({strFacetRow, strFacetCol, strColour, strNone})
        ucrInputContext1.SetDropDownStyleAsNonEditable()

        ucrInputContext2.SetItems({strFacetRow, strFacetCol, strColour, strNone})
        ucrInputContext2.SetDropDownStyleAsNonEditable()

        ucrInputContext3.SetItems({strFacetRow, strFacetCol, strColour, strNone})
        ucrInputContext3.SetDropDownStyleAsNonEditable()

        ucrPnlPlotType.AddRadioButton(rdoBoxplot)
        ucrPnlPlotType.AddRadioButton(rdoViolin)
        ucrPnlPlotType.AddFunctionNamesCondition(rdoBoxplot, "geom_boxplot")
        ucrPnlPlotType.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlotType.AddToLinkedControls(ucrChkVarWidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

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

        ucrChkVerticalXTickMarkers.SetText("Vertical X Tick Markers")
        ucrChkVerticalXTickMarkers.AddParameterPresentCondition(True, "axis.text.x")
        ucrChkVerticalXTickMarkers.AddParameterPresentCondition(False, "axis.text.x", False)

        ucrSavePlot.SetPrefix("boxplot")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggPlotFunction = New RFunction
        clsRaesGlobalFunction = New RFunction

        clsBoxplotViolinGeom = New RFunction
        clsRaesBoxplotFunction = New RFunction
        clsJitterGeom = New RFunction
        clsHlineGeom = New RFunction

        clsFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_grid")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False
        clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp)

        ucrSelectorPlot.Reset()
        ucrReceiverMeasurement.SetMeAsReceiver()

        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrReceiverMeasurement.SetMeAsReceiver()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggPlotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsBoxplotViolinGeom, iPosition:=3)

        clsRggPlotFunction.SetPackageName("ggplot2")
        clsRggPlotFunction.SetRCommand("ggplot")
        clsRggPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGlobalFunction, iPosition:=1)

        clsRaesGlobalFunction.SetPackageName("ggplot2")
        clsRaesGlobalFunction.SetRCommand("aes")
        clsRaesGlobalFunction.AddParameter("x", Chr(34) & Chr(34))

        clsBoxplotViolinGeom.SetPackageName("ggplot2")
        clsBoxplotViolinGeom.SetRCommand("geom_boxplot")
        clsBoxplotViolinGeom.AddParameter("varwidth", "FALSE", iPosition:=0)

        clsJitterGeom.SetPackageName("ggplot2")
        clsJitterGeom.SetRCommand("geom_jitter")
        clsJitterGeom.AddParameter("width", "0.2")
        clsJitterGeom.AddParameter("height", "0")
        clsJitterGeom.AddParameter("colour", Chr(34) & "orange" & Chr(34))
        clsJitterGeom.AddParameter("alpha", "0.8")

        clsHlineGeom.SetPackageName("ggplot2")
        clsHlineGeom.SetRCommand("geom_hline")
        clsHlineGeom.AddParameter("yintercept", "0")
        clsHlineGeom.AddParameter("colour", Chr(34) & "blue" & Chr(34))

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYLabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsRaesBoxplotFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        ucrInputContext1.SetName(strNone)
        ucrInputContext2.SetName(strNone)
        ucrInputContext3.SetName(strNone)
    End Sub

    Private Sub SetRCodeForControls(bResetControl As Boolean)
        bRCodeUpdated = False

        ucrSelectorPlot.SetRCode(clsRggPlotFunction, bResetControl)
        ucrReceiverMeasurement.SetRCode(clsRaesGlobalFunction, bResetControl)
        ucrReceiverX.SetRCode(clsRaesGlobalFunction, bResetControl)

        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bResetControl)
        ucrChkVerticalXTickMarkers.SetRCode(clsThemeFunction, bResetControl)
        ucrChkVarWidth.SetRCode(clsBoxplotViolinGeom, bResetControl)

        ucrChkIncludeHline.SetRCode(clsBaseOperator, bResetControl)
        ucrInputHlineValue.SetRCode(clsHlineGeom, bResetControl)

        ucrChkIncludePoints.SetRCode(clsBaseOperator, bResetControl)
        ucrInputJitter.SetRCode(clsJitterGeom, bResetControl)
        ucrNudTransparency.SetRCode(clsJitterGeom, bResetControl)

        ucrPnlPlotType.SetRCode(clsBoxplotViolinGeom, bResetControl)

        ucrSavePlot.SetRCode(clsBaseOperator, bResetControl)

        bRCodeUpdated = True
        If bResetControl Then
            AutoFill()
        End If
        cmdPointOptions.Visible = ucrChkIncludePoints.Checked
        cmdHLineOptions.Visible = ucrChkIncludeHline.Checked
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverMeasurement.IsEmpty AndAlso ucrSavePlot.IsComplete AndAlso (Not ucrChkIncludePoints.Checked OrElse (Not ucrInputJitter.IsEmpty AndAlso ucrNudTransparency.GetText() <> "")) AndAlso (Not ucrChkIncludeHline.Checked OrElse Not ucrInputHlineValue.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesGlobalFunction,
                          clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYLabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsFacetFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                          clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorPlot, bReset:=bResetSubdialog)
        'this is a temporary fix because we have facets done on the main dialog
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        SetRCodeForControls(False)
        bResetSubdialog = False
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggPlotFunction, clsNewGeomFunc:=clsBoxplotViolinGeom, clsNewGlobalAesFunc:=clsRaesGlobalFunction, clsNewLocalAes:=clsRaesBoxplotFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        SetRCodeForControls(False)
        bResetBoxLayerSubdialog = False
    End Sub

    Private Sub ucrChkVerticalXTickMarkers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkVerticalXTickMarkers.ControlValueChanged
        If ucrChkVerticalXTickMarkers.Checked Then
            dctThemeFunctions("axis.text.x").AddParameter("angle", "90", iPosition:=0)
        Else
            dctThemeFunctions("axis.text.x").RemoveParameterByName("angle")
        End If
        If dctThemeFunctions("axis.text.x").clsParameters.Count > 0 Then
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=dctThemeFunctions("axis.text.x"))
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.x")
        End If
        If clsThemeFunction.clsParameters.Count > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrPnlPlotType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlotType.ControlValueChanged
        If rdoBoxplot.Checked Then
            clsBoxplotViolinGeom.SetRCommand("geom_boxplot")
            cmdBoxPlotOptions.Text = "Boxplot Options"
        ElseIf rdoViolin.Checked Then
            clsBoxplotViolinGeom.SetRCommand("geom_violin")
            cmdBoxPlotOptions.Text = "Violin Plot Options"
        End If
        autoTranslate(Me)
    End Sub

    Private Sub AutoFill()
        If bRCodeUpdated Then
            ucrReceiverMeasurement.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_1_label"})
            ucrReceiverX.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_1_label"})
            ucrReceiverContext1.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_1_label"})
            ucrReceiverContext2.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_2_label"})
            ucrReceiverContext3.AddItemsWithMetadataProperty(ucrSelectorPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_3_label"})
        End If
    End Sub

    Private Sub ucrChkIncludePoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePoints.ControlValueChanged
        If ucrChkIncludePoints.Checked Then
            clsBaseOperator.AddParameter("geom_jitter", clsRFunctionParameter:=clsJitterGeom, iPosition:=4)
        Else
            clsBaseOperator.RemoveParameterByName("geom_jitter")
        End If
        cmdPointOptions.Visible = ucrChkIncludePoints.Checked
    End Sub

    Private Sub ucrChkIncludeHline_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeHline.ControlValueChanged
        If ucrChkIncludeHline.Checked Then
            clsBaseOperator.AddParameter("geom_hline", clsRFunctionParameter:=clsHlineGeom, iPosition:=2)
        Else
            clsBaseOperator.RemoveParameterByName("geom_hline")
        End If
        cmdHLineOptions.Visible = ucrChkIncludeHline.Checked
    End Sub

    Private Sub cmdPoints_Click(sender As Object, e As EventArgs) Handles cmdPointOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggPlotFunction, clsNewGeomFunc:=clsJitterGeom, clsNewGlobalAesFunc:=clsRaesGlobalFunction, clsNewLocalAes:=clsRaesBoxplotFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        SetRCodeForControls(False)
        bResetBoxLayerSubdialog = False
    End Sub

    Private Sub cmdHLineOptions_Click(sender As Object, e As EventArgs) Handles cmdHLineOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggPlotFunction, clsNewGeomFunc:=clsHlineGeom, clsNewGlobalAesFunc:=clsRaesGlobalFunction, clsNewLocalAes:=clsRaesBoxplotFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        SetRCodeForControls(False)
        bResetBoxLayerSubdialog = False
    End Sub

    Private Sub UpdateContextParameters(Optional ucrChangedControl As ucrInputComboBox = Nothing)
        Dim iRowVars As Integer = 0
        Dim iColVars As Integer = 0
        Dim strChangedValue As String

        If Not bUpdating Then
            If ucrChangedControl IsNot Nothing Then
                strChangedValue = ucrChangedControl.GetText()
                If strChangedValue = strColour Then
                    For Each ucrTemp As ucrInputComboBox In {ucrInputContext1, ucrInputContext2, ucrInputContext3}
                        If ucrTemp.GetText() = strChangedValue AndAlso Not ucrTemp.Equals(ucrChangedControl) Then
                            bUpdating = True
                            ucrTemp.SetName(strNone)
                            bUpdating = False
                        End If
                    Next
                End If
            End If
            clsFacetColOp.ClearParameters()
            clsFacetRowOp.ClearParameters()
            clsFacetOp.ClearParameters()
            clsFacetFunction.RemoveParameterByName("dir")
            clsRaesGlobalFunction.RemoveParameterByName("fill")

            If Not ucrReceiverContext1.IsEmpty() Then
                Select Case ucrInputContext1.GetText()
                    Case strFacetRow
                        clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsFacetColOp.AddParameter(iColVars, ucrReceiverContext1.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsRaesGlobalFunction.AddParameter("fill", ucrReceiverContext1.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            If Not ucrReceiverContext2.IsEmpty() Then
                Select Case ucrInputContext2.GetText()
                    Case strFacetRow
                        clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsFacetColOp.AddParameter(iColVars, ucrReceiverContext2.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsRaesGlobalFunction.AddParameter("fill", ucrReceiverContext2.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            If Not ucrReceiverContext3.IsEmpty() Then
                Select Case ucrInputContext3.GetText()
                    Case strFacetRow
                        clsFacetRowOp.AddParameter(iRowVars, ucrReceiverContext3.GetVariableNames(False), iPosition:=iRowVars)
                        iRowVars = iRowVars + 1
                    Case strFacetCol
                        clsFacetColOp.AddParameter(iColVars, ucrReceiverContext3.GetVariableNames(False), iPosition:=iColVars)
                        iColVars = iColVars + 1
                    Case strColour
                        clsRaesGlobalFunction.AddParameter("fill", ucrReceiverContext3.GetVariableNames(False), iPosition:=3)
                End Select
            End If
            clsFacetFunction.SetRCommand("facet_wrap")
            If iRowVars >= 1 AndAlso iColVars = 0 Then
                clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetRowOp, iPosition:=1)
                clsFacetFunction.AddParameter("dir", Chr(34) & "h" & Chr(34))
            ElseIf iColVars >= 1 AndAlso iRowVars = 0 Then
                clsFacetOp.AddParameter("left", "", iPosition:=0)
                clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
                clsFacetFunction.AddParameter("dir", Chr(34) & "v" & Chr(34))
            ElseIf iRowVars >= 1 AndAlso iColVars >= 1 Then
                clsFacetOp.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
                clsFacetOp.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
                clsFacetFunction.SetRCommand("facet_grid")
            End If
            If iRowVars > 0 OrElse iColVars > 0 Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=10)
            Else
                clsBaseOperator.RemoveParameterByName("facets")
            End If
        End If
    End Sub

    Private Sub ContextControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputContext1.ControlValueChanged, ucrInputContext2.ControlValueChanged, ucrInputContext3.ControlValueChanged, ucrReceiverContext1.ControlValueChanged, ucrReceiverContext2.ControlValueChanged, ucrReceiverContext3.ControlValueChanged
        If TypeOf ucrChangedControl Is ucrInputComboBox Then
            UpdateContextParameters(ucrChangedControl)
        Else
            UpdateContextParameters()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrChkIncludePoints.ControlContentsChanged, ucrInputJitter.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged, ucrChkIncludeHline.ControlContentsChanged, ucrInputHlineValue.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class