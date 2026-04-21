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
Imports RDotNet
Public Class dlgClimaticStationMaps
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGgplotFunction, clsGeomSfFunction, clsGeomPointFunction, clsSfAesFunction, clsGeomPointAesFunction, clsScaleShapeFunction, clsLabelRepelFunction, clsTextRepelFunction As New RFunction
    Private clsGGplotOperator, clsFacetOp As New ROperator

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsXlimFunction, clsYlimFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private clsLocalRaesFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private bResetSFLayerSubdialog As Boolean = True
    Private clsLabelRepelAesFunction As New RFunction
    Private clsTextRepelAesFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsGetDataFrame As New RFunction
    Private clsRemoveFunc As New RFunction
    Private clsDummyFunction As New RFunction

    Private Sub dlgClimaticMaps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 645
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        Dim dctGRugColour As New Dictionary(Of String, String)
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrSelectorOutline.SetParameter(New RParameter("data", 0))
        ucrSelectorOutline.SetParameterIsrfunction()

        ucrSelectorStation.SetParameter(New RParameter("data", 0))
        ucrSelectorStation.SetParameterIsrfunction()

        ucrReceiverGeometry.SetParameter(New RParameter("geometry", 0))
        ucrReceiverGeometry.Selector = ucrSelectorOutline
        ucrReceiverGeometry.SetParameterIsRFunction()

        ucrReceiverFill.SetParameter(New RParameter("fill", 0))
        ucrReceiverFill.Selector = ucrSelectorOutline
        ucrReceiverFill.SetParameterIsString()
        ucrReceiverFill.bWithQuotes = False

        ucrReceiverLongitude.SetParameter(New RParameter("x", 0))
        ucrReceiverLongitude.Selector = ucrSelectorStation
        ucrReceiverLongitude.SetIncludedDataTypes({"numeric"})
        ucrReceiverLongitude.strSelectorHeading = "Numerics"
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.bWithQuotes = False

        ucrReceiverLatitude.SetParameter(New RParameter("y", 1))
        ucrReceiverLatitude.Selector = ucrSelectorStation
        ucrReceiverLatitude.SetIncludedDataTypes({"numeric"})
        ucrReceiverLatitude.strSelectorHeading = "Numerics"
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.bWithQuotes = False

        ucrReceiverShape.SetParameter(New RParameter("shape", 2))
        ucrReceiverShape.Selector = ucrSelectorStation
        ucrReceiverShape.SetParameterIsString()
        ucrReceiverShape.bWithQuotes = False

        ucrReceiverColor.SetParameter(New RParameter("color", 3))
        ucrReceiverColor.Selector = ucrSelectorStation
        ucrReceiverColor.SetParameterIsString()
        ucrReceiverColor.bWithQuotes = False

        ucrReceiverFacet.SetParameter(New RParameter("wrap", bNewIncludeArgumentName:=False))
        ucrReceiverFacet.Selector = ucrSelectorStation
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.bWithQuotes = False

        ucrReceiverStation.SetParameter(New RParameter("label", 2))
        ucrReceiverStation.Selector = ucrSelectorStation
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False

        ucrSaveMap.SetPrefix("map")
        ucrSaveMap.SetSaveTypeAsGraph()
        ucrSaveMap.SetIsComboBox()
        ucrSaveMap.SetCheckBoxText("Store Map")
        ucrSaveMap.SetAssignToIfUncheckedValue("last_map")
        ucrSaveMap.SetDataFrameSelector(ucrSelectorOutline.ucrAvailableDataFrames)

        ucrChkLabelledRectangle.SetText("Text")
        ucrChkLabelledRectangle.AddParameterValuesCondition(True, "text", "True")
        ucrChkLabelledRectangle.AddParameterValuesCondition(False, "text", "False")
        ucrChkLabelledRectangle.SetRDefault("FALSE")

        ucrChkLabelAll.SetText("Label All")
        ucrChkLabelAll.SetParameter(New RParameter("max.overlaps", 6))
        ucrChkLabelAll.AddParameterValuesCondition(True, "max.overlaps", "True")
        ucrChkLabelAll.AddParameterValuesCondition(False, "max.overlaps", "False")
        ucrChkLabelAll.SetRDefault("FALSE")

        ucrChkSize.SetText("Size")
        ucrChkSize.AddParameterValuesCondition(True, "check", "True")
        ucrChkSize.AddParameterValuesCondition(False, "check", "False")
        ucrChkSize.AddToLinkedControls(ucrNudSize, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudSize.SetParameter(New RParameter("size", 4))
        ucrNudSize.Minimum = 0
        ucrNudSize.DecimalPlaces = 1
        ucrNudSize.Increment = 0.1
        ucrNudSize.SetRDefault("5")

        ucrChkColour.SetText("Colour")
        ucrChkColour.AddParameterValuesCondition(True, "checked", "True")
        ucrChkColour.AddParameterValuesCondition(False, "checked", "False")
        ucrChkColour.AddToLinkedControls(ucrInputColour, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputColour.SetParameter(New RParameter("colour", 5))
        dctGRugColour.Add("Black", Chr(34) & "black" & Chr(34))
        dctGRugColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctGRugColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctGRugColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctGRugColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctGRugColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        dctGRugColour.Add("White", Chr(34) & "white" & Chr(34))
        dctGRugColour.Add("None", Chr(34) & "none" & Chr(34))
        ucrInputColour.SetItems(dctGRugColour)
        ucrInputColour.bAllowNonConditionValues = True
        ucrInputColour.SetRDefault(Chr(34) & "black" & Chr(34))

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

        ucrChkAddPoints.SetText("Add Points")
        ucrChkAddPoints.AddParameterPresentCondition(True, "geom_point")
        ucrChkAddPoints.AddParameterPresentCondition(False, "geom_point", False)
        ChangeSize()
    End Sub

    Private Sub SetDefaults()
        clsGetDataFrame = New RFunction
        clsGeomSfFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsSfAesFunction = New RFunction
        clsGeomPointFunction = New RFunction
        clsGeomPointAesFunction = New RFunction
        clsScaleShapeFunction = New RFunction
        clsLabelRepelFunction = New RFunction
        clsTextRepelFunction = New RFunction
        clsLabelRepelAesFunction = New RFunction
        clsTextRepelAesFunction = New RFunction
        clsDummyFunction = New RFunction

        clsGGplotOperator = New ROperator
        clsXlimFunction = New RFunction
        clsYlimFunction = New RFunction
        clsFacetOp = New ROperator

        clsCoordPolarFunction = New RFunction
        clsCoordPolarStartOperator = New ROperator

        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()

        ucrSelectorOutline.Reset()
        ucrSelectorStation.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        ucrReceiverFill.SetMeAsReceiver()
        ucrReceiverGeometry.SetMeAsReceiver()
        ucrSaveMap.Reset()
        bResetSubdialog = True
        bResetSFLayerSubdialog = True

        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsRemoveFunc.SetRCommand("rm")

        clsDummyFunction.AddParameter("checked", "False", iPosition:=0)
        clsDummyFunction.AddParameter("check", "False", iPosition:=1)

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")

        clsGeomSfFunction.SetPackageName("ggplot2")
        clsGeomSfFunction.SetRCommand("geom_sf")
        clsGeomSfFunction.AddParameter("mapping", clsRFunctionParameter:=clsSfAesFunction, iPosition:=1)

        clsSfAesFunction.SetPackageName("ggplot2")
        clsSfAesFunction.SetRCommand("aes")

        clsGeomPointFunction.SetPackageName("ggplot2")
        clsGeomPointFunction.SetRCommand("geom_point")
        clsGeomPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomPointAesFunction, iPosition:=1)

        clsGeomPointAesFunction.SetPackageName("ggplot2")
        clsGeomPointAesFunction.SetRCommand("aes")

        clsScaleShapeFunction.SetPackageName("ggplot2")
        clsScaleShapeFunction.SetRCommand("scale_shape_manual")
        clsScaleShapeFunction.AddParameter("values", strParameterValue:="c(3,4,7,8,11,13,15,16,17,18,21,22,42)", bIncludeArgumentName:=True, iPosition:=0)

        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False

        clsLabelRepelFunction.SetPackageName("ggrepel")
        clsLabelRepelFunction.SetRCommand("geom_label_repel")
        clsLabelRepelFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelRepelAesFunction, iPosition:=1)

        clsTextRepelFunction.SetPackageName("ggrepel")
        clsTextRepelFunction.SetRCommand("geom_text_repel")
        clsTextRepelFunction.AddParameter("mapping", clsRFunctionParameter:=clsTextRepelAesFunction, iPosition:=1)

        clsLabelRepelAesFunction.SetPackageName("ggplot2")
        clsLabelRepelAesFunction.SetRCommand("aes")

        clsTextRepelAesFunction.SetPackageName("ggplot2")
        clsTextRepelAesFunction.SetRCommand("aes")

        clsGGplotOperator.SetOperation("+")
        clsGGplotOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsGGplotOperator.AddParameter("geom_sf", clsRFunctionParameter:=clsGeomSfFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsGGplotOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsRFacetFunction.RemoveParameterByName("facets")
        clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp)

        clsXlimFunction.SetRCommand("xlim")
        clsYlimFunction.SetRCommand("ylim")

        clsGGplotOperator.SetAssignTo("last_map", strTempDataframe:=ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_map")
        ucrBase.clsRsyntax.SetBaseROperator(clsGGplotOperator)
        AutoFillGeometry()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkLabelAll.AddAdditionalCodeParameterPair(clsTextRepelFunction, New RParameter("max.overlaps", 6), iAdditionalPairNo:=1)
        ucrNudSize.AddAdditionalCodeParameterPair(clsTextRepelFunction, New RParameter("size", 4), iAdditionalPairNo:=1)
        ucrInputColour.AddAdditionalCodeParameterPair(clsTextRepelFunction, New RParameter("colour", 5), iAdditionalPairNo:=1)
        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsLabelRepelAesFunction, ucrReceiverLongitude.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsLabelRepelAesFunction, ucrReceiverLatitude.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsTextRepelAesFunction, ucrReceiverStation.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsTextRepelAesFunction, ucrReceiverLongitude.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsTextRepelAesFunction, ucrReceiverLatitude.GetParameter(), iAdditionalPairNo:=2)

        ucrSelectorOutline.SetRCode(clsGeomSfFunction, bReset)
        ucrReceiverFill.SetRCode(clsSfAesFunction, bReset)
        ucrSaveMap.SetRCode(clsGGplotOperator, bReset)
        ucrSelectorStation.SetRCode(clsGgplotFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverShape.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverColor.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverFacet.SetRCode(clsFacetOp, bReset)
        ucrReceiverStation.SetRCode(clsLabelRepelAesFunction, bReset)
        ucrInputColour.SetRCode(clsLabelRepelFunction, bReset)
        ucrNudSize.SetRCode(clsLabelRepelFunction, bReset)
        ucrChkAddPoints.SetRCode(clsGGplotOperator, bReset)
        ucrReceiverGeometry.SetRCode(clsSfAesFunction, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrChkLabelledRectangle.SetRCode(clsGGplotOperator, bReset)
            ucrChkLabelAll.SetRCode(clsLabelRepelFunction, bReset)
            ucrChkSize.SetRCode(clsDummyFunction, bReset)
            ucrChkColour.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean
        If ucrSaveMap.IsComplete Then
            bOkEnabled = True
        End If
        If Not ucrReceiverLongitude.IsEmpty AndAlso ucrReceiverLatitude.IsEmpty Then
            bOkEnabled = False
        ElseIf ucrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty Then
            bOkEnabled = False
        ElseIf Not ucrReceiverStation.IsEmpty AndAlso ucrReceiverLongitude.IsEmpty AndAlso ucrReceiverLatitude.IsEmpty Then
            bOkEnabled = False
        Else
            bOkEnabled = True
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverShape_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverShape.ControlValueChanged
        AddExtraGeoms()
    End Sub

    Private Sub toolStripMenuItemSFOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemSFOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsGeomSfFunction, clsNewGlobalAesFunc:=clsSfAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorOutline, bApplyAesGlobally:=True, bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
        For Each clsParam In clsSfAesFunction.clsParameters
            If clsParam.strArgumentName = "fill" Then
                ucrReceiverFill.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub toolStripMenuItemMapping_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemMapping.Click
        sdgMapOption.SetRCode(clsBaseOperator:=clsGGplotOperator, clsXlim:=clsXlimFunction, clsylim:=clsYlimFunction, bReset:=bResetSubdialog)
        sdgMapOption.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsGGplotOperator, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                  clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewThemeFunction:=clsThemeFunction,
                  dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsSfAesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
                  clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction,
                  clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                  clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorStation, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub PlotOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlotOptionsToolStripMenuItem.Click
        sdgPlots.SetRCode(clsGGplotOperator, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                  clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewThemeFunction:=clsThemeFunction,
                  dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsSfAesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction,
                  clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction,
                  clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                  clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrSelectorStation, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ChangeSize()
        If ucrChkAddPoints.Checked Then
            grpPoints.Visible = True
            Me.Size = New Size(772, 442)
            Me.ucrSaveMap.Location = New Point(10, 319)
            Me.ucrBase.Location = New Point(10, 350)
        Else
            grpPoints.Visible = False
            Me.Size = New Size(772, 384)
            Me.ucrSaveMap.Location = New Point(10, 261)
            Me.ucrBase.Location = New Point(10, 286)
        End If
    End Sub

    Private Sub toolStripMenuItemLabelRepelOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemLabelRepelOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsLabelRepelFunction, clsNewGlobalAesFunc:=clsLabelRepelAesFunction,
                                   clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorStation, bApplyAesGlobally:=True,
                                   bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
        clsGgplotFunction.RemoveParameterByName("mapping")
        clsLabelRepelFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelRepelAesFunction, iPosition:=1)
    End Sub

    Private Sub toolStripMenuItemTextRepelOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTextRepelOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsTextRepelFunction, clsNewGlobalAesFunc:=clsTextRepelAesFunction,
                                   clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorStation, bApplyAesGlobally:=True,
                                   bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
        clsGgplotFunction.RemoveParameterByName("mapping")
        clsTextRepelFunction.AddParameter("mapping", clsRFunctionParameter:=clsTextRepelAesFunction, iPosition:=1)
    End Sub

    Private Sub toolStripMenuItemPointOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemPointOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsGeomPointFunction, clsNewGlobalAesFunc:=clsGeomPointAesFunction,
                                  clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorStation, bApplyAesGlobally:=True,
                                  bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsGGplotOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsGGplotOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub AddExtraGeoms()
        clsGGplotOperator.RemoveParameterByName("geom_label")
        clsGGplotOperator.RemoveParameterByName("geom_point")
        clsGGplotOperator.RemoveParameterByName("facets")
        clsGGplotOperator.RemoveParameterByName("scale_shape_manual")
        If ucrChkAddPoints.Checked Then
            If Not ucrReceiverStation.IsEmpty AndAlso ucrChkLabelledRectangle.Checked Then
                clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            ElseIf Not ucrReceiverStation.IsEmpty AndAlso Not ucrChkLabelledRectangle.Checked Then
                clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            End If
            If Not ucrReceiverFacet.IsEmpty Then
                clsGGplotOperator.AddParameter("facets", clsRFunctionParameter:=clsRFacetFunction, bIncludeArgumentName:=False, iPosition:=2)
            End If
            If Not ucrReceiverShape.IsEmpty Then
                clsGGplotOperator.AddParameter("scale_shape_manual", clsRFunctionParameter:=clsScaleShapeFunction, bIncludeArgumentName:=False, iPosition:=2)
            End If
            clsGGplotOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointFunction, bIncludeArgumentName:=False, iPosition:=2)
        End If
    End Sub

    Private Sub ucrReceiverFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacet.ControlValueChanged
        AddExtraGeoms()
    End Sub


    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        AddExtraGeoms()
    End Sub

    Private Sub ucrChkAddPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddPoints.ControlValueChanged
        ChangeSize()
        AddExtraGeoms()
    End Sub

    Private Sub AutoFillGeometry()
        Dim clsGetGeometry As New RFunction
        Dim clsParam As RParameter = New RParameter
        Dim GeometryOutput As SymbolicExpression
        Dim strScript As String = ""

        If ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsRemoveFunc.AddParameter(strParameterValue:=ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            clsParam.SetArgumentName("data_name")
            clsParam.SetArgumentValue(Chr(34) & ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
            clsGetDataFrame.AddParameter(clsParam)
            clsGetDataFrame.SetAssignTo(ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            clsGetDataFrame.ToScript(strScript)
            frmMain.clsRLink.RunInternalScript(strScript)

            clsGetGeometry.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_geometry")
            clsGetGeometry.AddParameter("data", ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            GeometryOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsGetGeometry.ToScript(), bSilent:=True)

            frmMain.clsRLink.RunInternalScript(clsRemoveFunc.ToScript())

            If GeometryOutput IsNot Nothing AndAlso Not GeometryOutput.Type = Internals.SymbolicExpressionType.Null Then
                ucrReceiverGeometry.Add(GeometryOutput.AsCharacter(0), ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            End If
            clsSfAesFunction.AddParameter("geometry", clsRFunctionParameter:=clsGetGeometry)
        End If
    End Sub

    Private Sub ucrReceiverGeometry_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverGeometry.ControlValueChanged
        clsSfAesFunction.RemoveParameterByName("geometry")
        If ucrReceiverGeometry.IsEmpty Then
            AutoFillGeometry()
        Else
            clsSfAesFunction.AddParameter("geometry", clsRFunctionParameter:=ucrReceiverGeometry.GetVariables)
        End If
    End Sub

    Private Sub ucrSelectorOutline_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOutline.ControlValueChanged
        AutoFillGeometry()
    End Sub

    Private Sub ucrReceiverFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlValueChanged
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
    End Sub

    Private Sub ucrReceiverFill_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlContentsChanged,
        ucrReceiverLongitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrSaveMap.ControlContentsChanged,
        ucrReceiverStation.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AddGeomParameter()
        If ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsTextRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsTextRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_label")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("size")
            clsLabelRepelFunction.RemoveParameterByName("colour")
            clsLabelRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("size")
            clsLabelRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsTextRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("colour")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsTextRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("size")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsTextRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsLabelRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsLabelRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsGGplotOperator.RemoveParameterByName("geom_text")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsLabelRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("size")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("colour")
            clsTextRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("size")
            clsTextRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("colour", Chr(34) & ucrInputColour.GetText() & Chr(34), iPosition:=2)
            clsLabelRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsTextRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsTextRepelFunction.RemoveParameterByName("size")
            clsTextRepelFunction.RemoveParameterByName("colour")
            clsGGplotOperator.RemoveParameterByName("geom_label")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=2)
            clsLabelRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("colour")
        ElseIf Not ucrChkLabelledRectangle.Checked AndAlso ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsLabelRepelFunction.AddParameter("size", ucrNudSize.GetText(), iPosition:=3)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.RemoveParameterByName("colour")
            clsLabelRepelFunction.RemoveParameterByName("max.overlaps")
        ElseIf ucrChkLabelledRectangle.Checked AndAlso Not ucrChkSize.Checked AndAlso Not ucrChkLabelAll.Checked AndAlso Not ucrChkColour.Checked Then
            clsGGplotOperator.AddParameter("geom_text", clsRFunctionParameter:=clsTextRepelFunction, iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_label")
            clsTextRepelFunction.RemoveParameterByName("colour")
            clsTextRepelFunction.RemoveParameterByName("max.overlaps")
            clsTextRepelFunction.RemoveParameterByName("size")
        Else
            clsGGplotOperator.AddParameter("geom_label", clsRFunctionParameter:=clsLabelRepelFunction, iPosition:=2)
            clsGGplotOperator.RemoveParameterByName("geom_text")
            clsLabelRepelFunction.AddParameter("max.overlaps", "Inf", iPosition:=4)
            clsLabelRepelFunction.RemoveParameterByName("colour")
            clsLabelRepelFunction.RemoveParameterByName("size")
        End If
    End Sub

    Private Sub ucrChkLabelledRectangle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabelledRectangle.ControlValueChanged
        AddGeomParameter()
    End Sub

    Private Sub ucrChkLabelAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabelAll.ControlValueChanged
        AddGeomParameter()
    End Sub

    Private Sub ucrChkSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSize.ControlValueChanged
        AddGeomParameter()
    End Sub

    Private Sub ucrChkColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColour.ControlValueChanged
        AddGeomParameter()
    End Sub
End Class
