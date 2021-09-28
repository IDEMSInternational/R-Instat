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
Public Class dlgHeatMapPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeomTileFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bRCodeSet As Boolean = True
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsLocalRaesFunction As New RFunction
    Private bResetRugLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private clsLabelAesFunction As New RFunction
    Private clsColourPaletteFunction As New RFunction
    Private clsGeomPointSizeFunction As New RFunction
    Private clsGeomPointShapeFunction As New RFunction
    Private clsShapeAesFunction As New RFunction
    Private clsSizeAesFunction As New RFunction

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomrug"
    Private strGeomParameterNames() As String = {strFirstParameterName}
    Private Sub dlgHeatMapPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)
        Dim dctColourPallette As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 476
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrHeatMapSelector.SetParameter(New RParameter("data", 0))
        ucrHeatMapSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrHeatMapSelector
        ucrReceiverX.bWithQuotes = False

        ucrVariableAsFactorForHeatMap.SetParameter(New RParameter("y", 1))
        ucrVariableAsFactorForHeatMap.Selector = ucrHeatMapSelector
        ucrVariableAsFactorForHeatMap.SetParameterIsString()
        ucrVariableAsFactorForHeatMap.bWithQuotes = False
        ucrVariableAsFactorForHeatMap.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariableAsFactorForHeatMap.bAddParameterIfEmpty = True

        ucrReceiverFill.SetParameter(New RParameter("fill", 2))
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.Selector = ucrHeatMapSelector
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverPoints.SetParameter(New RParameter("size", 0))
        ucrReceiverPoints.SetParameterIsString()
        ucrReceiverPoints.Selector = ucrHeatMapSelector
        ucrReceiverPoints.bWithQuotes = False

        ucrNudShape.SetParameter(New RParameter("size", 2))
        ucrNudShape.Visible = False
        ucrNudShape.SetLinkedDisplayControl(lblPointsSize)

        ucrSaveGraph.SetPrefix("heatmap")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrHeatMapSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrInputColour.SetParameter(New RParameter("colour", 4))
        dctLabelColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLabelColours.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputColour.SetItems(dctLabelColours)
        ucrInputColour.bAllowNonConditionValues = True

        ucrInputPosition.SetParameter(New RParameter("vjust", 2))
        dctLabelPositions.Add("Middle", "0")
        dctLabelPositions.Add("Out", "-0.25")
        dctLabelPositions.Add("In", "5")
        ucrInputPosition.SetItems(dctLabelPositions)
        ucrInputPosition.SetDropDownStyleAsNonEditable()

        ucrInputSize.SetParameter(New RParameter("size", 5))
        dctLabelSizes.Add("Default", "4")
        dctLabelSizes.Add("Small", "3")
        dctLabelSizes.Add("Big", "7")
        ucrInputSize.SetItems(dctLabelSizes)
        ucrInputSize.SetDropDownStyleAsNonEditable()

        ucrInputColourPalette.SetParameter(New RParameter("option", 0))
        dctColourPallette.Add("Viridis", Chr(34) & "viridis" & Chr(34))
        dctColourPallette.Add("Magma", Chr(34) & "magma" & Chr(34))
        dctColourPallette.Add("Inferno", Chr(34) & "inferno" & Chr(34))
        dctColourPallette.Add("Plasma", Chr(34) & "plasma" & Chr(34))
        dctColourPallette.Add("Cividis", Chr(34) & "cividis" & Chr(34))
        ucrInputColourPalette.SetItems(dctColourPallette)
        ucrInputColourPalette.SetDropDownStyleAsNonEditable()

        ucrChkColourPalette.SetText("Colour Palette")
        ucrChkColourPalette.AddParameterPresentCondition(True, "option")
        ucrChkColourPalette.AddParameterPresentCondition(False, "option", False)
        ucrChkAddLabels.SetText("Add Labels")
        ucrChkAddLabels.AddParameterPresentCondition(True, "geom_text")
        ucrChkAddLabels.AddParameterPresentCondition(False, "geom_text", False)

        ucrChkAddLabels.AddToLinkedControls({ucrInputPosition, ucrInputSize, ucrInputColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkColourPalette.AddToLinkedControls({ucrInputColourPalette}, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Viridis")
        ucrInputColour.SetLinkedDisplayControl(lblColour)
        ucrInputPosition.SetLinkedDisplayControl(lblPosition)
        ucrInputSize.SetLinkedDisplayControl(lblSize)

    End Sub

    Private Sub SetDefaults()
        clsRaesFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsRgeomTileFunction = New RFunction
        clsBaseOperator = New ROperator
        clsGeomTextFunction = New RFunction
        clsLabelAesFunction = New RFunction
        clsColourPaletteFunction = New RFunction
        clsGeomPointSizeFunction = New RFunction
        clsSizeAesFunction = New RFunction
        clsGeomPointShapeFunction = New RFunction
        clsShapeAesFunction = New RFunction

        ucrSaveGraph.Reset()
        ucrVariableAsFactorForHeatMap.SetMeAsReceiver()
        ucrHeatMapSelector.Reset()
        ucrHeatMapSelector.SetGgplotFunction(clsBaseOperator)
        bResetSubdialog = True
        bResetRugLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomTileFunction, iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeomTileFunction.SetPackageName("ggplot2")
        clsRgeomTileFunction.SetRCommand("geom_tile")

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")
        clsLabelAesFunction.AddParameter("label", ucrVariableAsFactorForHeatMap.GetVariableNames(False), iPosition:=0)

        clsGeomPointSizeFunction.SetPackageName("ggplot2")
        clsGeomPointSizeFunction.SetRCommand("geom_point")
        clsGeomPointSizeFunction.AddParameter("mapping", clsRFunctionParameter:=clsSizeAesFunction, iPosition:=0)

        clsSizeAesFunction.SetPackageName("ggplot2")
        clsSizeAesFunction.SetRCommand("aes")

        clsGeomPointShapeFunction.SetPackageName("ggplot2")
        clsGeomPointShapeFunction.SetRCommand("geom_point")
        clsGeomPointShapeFunction.AddParameter("mapping", clsRFunctionParameter:=clsShapeAesFunction, iPosition:=0)
        clsGeomPointShapeFunction.AddParameter("size", 5, iPosition:=2)

        clsShapeAesFunction.SetPackageName("ggplot2")
        clsShapeAesFunction.SetRCommand("aes")

        clsColourPaletteFunction.SetPackageName("viridis")
        clsColourPaletteFunction.SetRCommand("scale_fill_viridis")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHeatMapSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrReceiverFill.AddAdditionalCodeParameterPair(clsLabelAesFunction, New RParameter("label", 2), iAdditionalPairNo:=1)
        ucrReceiverPoints.AddAdditionalCodeParameterPair(clsShapeAesFunction, New RParameter("shape", 0), iAdditionalPairNo:=1)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrHeatMapSelector.SetRCode(clsRggplotFunction, bReset)

        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrVariableAsFactorForHeatMap.SetRCode(clsRaesFunction, bReset)
        ucrReceiverFill.SetRCode(clsRaesFunction, bReset)
        ucrChkAddLabels.SetRCode(clsBaseOperator, bReset)
        ucrInputColour.SetRCode(clsGeomTextFunction, bReset)
        ucrInputPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputSize.SetRCode(clsGeomTextFunction, bReset)
        ucrChkColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrInputColourPalette.SetRCode(clsColourPaletteFunction, bReset)
        ucrReceiverPoints.SetRCode(clsSizeAesFunction, bReset)
        ucrNudShape.SetRCode(clsGeomPointShapeFunction, bReset)
        bRCodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrSaveGraph.IsComplete) OrElse (ucrReceiverX.IsEmpty() OrElse ucrVariableAsFactorForHeatMap.IsEmpty() OrElse (ucrChkAddLabels.Checked AndAlso ucrReceiverFill.IsEmpty)) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub AllControlsContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrVariableAsFactorForHeatMap.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged, ucrReceiverFill.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                          clsNewGlobalAesFunction:=clsRaesFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                          clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction,
                          clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrHeatMapSelector,
                          strMainDialogGeomParameterNames:=strGeomParameterNames, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                           clsNewAnnotateFunction:=clsAnnotateFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdTileOptions_Click(sender As Object, e As EventArgs) Handles cmdTileOptions.Click
        ''''''' i wonder if all this will be needed for the new system
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomTileFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHeatMapSelector, bApplyAesGlobally:=True, bReset:=bResetRugLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetRugLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariableAsFactorForHeatMap.bSingleVariable) Then
                ucrVariableAsFactorForHeatMap.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "x" Then
                ucrReceiverX.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrReceiverFill.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub ucrChkColourPalette_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColourPalette.ControlValueChanged
        If ucrChkColourPalette.Checked Then
            clsBaseOperator.AddParameter("palette", clsRFunctionParameter:=clsColourPaletteFunction, iPosition:=6)
        Else
            clsBaseOperator.RemoveParameterByName("palette")
        End If
    End Sub

    Private Sub ucrReceiverPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPoints.ControlValueChanged
        If bRCodeSet Then
            ucrNudShape.Visible = False
            If ucrReceiverPoints.IsEmpty Then
                clsBaseOperator.RemoveParameterByName("geom_point")
            Else
                If ucrReceiverPoints.strCurrDataType = "numeric" Then
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointSizeFunction, iPosition:=7)
                ElseIf ucrReceiverPoints.strCurrDataType = "factor" Then
                    ucrNudShape.Visible = True
                    clsBaseOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointShapeFunction, iPosition:=7)
                Else
                    clsBaseOperator.RemoveParameterByName("geom_point")
                End If

            End If
        End If

    End Sub
End Class