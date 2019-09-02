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
Public Class dlgClimaticStationMaps
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGgplotFunction, clsGeomSfFunction, clsGeomPointFunction, clsSfAesFunction, clsGeomPointAesFunction, clsFacetFunction, clsScaleShapeFunction, clsLabelRepelFunction As RFunction
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
        ucrBase.iHelpTopicID = 558
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorOutline.SetParameter(New RParameter("data", 0))
        ucrSelectorOutline.SetParameterIsrfunction()

        ucrSelectorStation.SetParameter(New RParameter("data", 0))
        ucrSelectorStation.SetParameterIsrfunction()

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

        ucrSaveMap.SetPrefix("Map")
        ucrSaveMap.SetSaveTypeAsGraph()
        ucrSaveMap.SetIsComboBox()
        ucrSaveMap.SetCheckBoxText("Save Map")
        ucrSaveMap.SetAssignToIfUncheckedValue("last_map")
        ucrSaveMap.SetDataFrameSelector(ucrSelectorOutline.ucrAvailableDataFrames)

    End Sub

    Private Sub SetDefaults()
        clsGeomSfFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsSfAesFunction = New RFunction
        clsGeomPointFunction = New RFunction
        clsGeomPointAesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsScaleShapeFunction = New RFunction
        clsLabelRepelFunction = New RFunction
        clsLabelRepelAesFunction = New RFunction

        clsGGplotOperator = New ROperator
        clsXlimFunction = New RFunction
        clsYlimFunction = New RFunction
        clsFacetOp = New ROperator

        ucrSelectorOutline.Reset()
        ucrSelectorStation.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        ucrReceiverFill.SetMeAsReceiver()
        ucrSaveMap.Reset()
        bResetSubdialog = True
        bResetSFLayerSubdialog = True

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")

        clsGeomSfFunction.SetPackageName("ggplot2")
        clsGeomSfFunction.SetRCommand("geom_sf")
        clsGeomSfFunction.AddParameter("mapping", clsRFunctionParameter:=clsSfAesFunction, iPosition:=1)

        clsSfAesFunction.SetPackageName("ggplot2")
        clsSfAesFunction.SetRCommand("aes")

        clsGeomPointFunction.SetPackageName("ggplot2")
        clsGeomPointFunction.SetRCommand("geom_point")
        clsGeomPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomPointAesFunction,iPosition:=1)

        clsGeomPointAesFunction.SetPackageName("ggplot2")
        clsGeomPointAesFunction.SetRCommand("aes")

        clsScaleShapeFunction.SetPackageName("ggplot2")
        clsScaleShapeFunction.SetRCommand("scale_shape_manual")
        clsScaleShapeFunction.AddParameter("values", strParameterValue:="c(3,4,7,8,11,13,15,16,17,18,21,22,42)", bIncludeArgumentName:=True, iPosition:=0)

        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetFunction.SetRCommand("facet_wrap")
        clsFacetFunction.AddParameter("facet", clsROperatorParameter:=clsFacetOp, bIncludeArgumentName:=False)

        clsLabelRepelFunction.SetPackageName("ggrepel")
        clsLabelRepelFunction.SetRCommand("geom_label_repel")

        clsLabelRepelAesFunction.SetPackageName("ggplot2")
        clsLabelRepelAesFunction.SetRCommand("aes")
        clsLabelRepelFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelRepelAesFunction,iPosition:=1)


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
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsXlimFunction.SetRCommand("xlim")
        clsYlimFunction.SetRCommand("ylim")

        clsGGplotOperator.SetAssignTo("last_map", strTempDataframe:=ucrSelectorOutline.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_map")
        ucrBase.clsRsyntax.SetBaseROperator(clsGGplotOperator)
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsGGplotOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsSfAesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorStation, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsLabelRepelAesFunction, ucrReceiverLongitude.GetParameter())
        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsLabelRepelAesFunction, ucrReceiverLatitude.GetParameter())
        ucrSelectorStation.AddAdditionalCodeParameterPair(clsLabelRepelFunction, ucrSelectorStation.GetParameter())

        ucrSelectorOutline.SetRCode(clsGeomSfFunction, bReset)
        ucrReceiverFill.SetRCode(clsSfAesFunction, bReset)
        ucrSaveMap.SetRCode(clsGGplotOperator, bReset)
        ucrSelectorStation.SetRCode(clsGeomPointFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverShape.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverColor.SetRCode(clsGeomPointAesFunction, bReset)
        ucrReceiverFacet.SetRCode(clsFacetOp, bReset)

        ucrReceiverStation.SetRCode(clsLabelRepelAesFunction, bReset)
    End Sub

    Private Sub cmdSFOptions_Click(sender As Object, e As EventArgs) Handles cmdSFOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsGeomSfFunction, clsNewGlobalAesFunc:=clsSfAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorOutline, bApplyAesGlobally:=True, bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
        For Each clsParam In clsSfAesFunction.clsParameters
            If clsParam.strArgumentName = "fill" Then
                ucrReceiverFill.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub cmdMapOptions_Click(sender As Object, e As EventArgs) Handles cmdMapOptions.Click
        sdgMapOption.SetRCode(clsBaseOperator:=clsGGplotOperator, clsXlim:=clsXlimFunction, clsylim:=clsYlimFunction, bReset:=bResetSubdialog)
        sdgMapOption.ShowDialog()
        bResetSubdialog = False
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

    Private Sub ucrReceiverLatitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLatitude.ControlValueChanged, ucrReceiverLongitude.ControlValueChanged
        If Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty Then
            clsGGplotOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGGplotOperator.RemoveParameterByName("geom_point")
        End If
    End Sub
    Private Sub ucrReceiverShape_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverShape.ControlValueChanged
        If Not ucrReceiverShape.IsEmpty Then
            clsGGplotOperator.AddParameter("scale_shape_manual", clsRFunctionParameter:=clsScaleShapeFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGGplotOperator.RemoveParameterByName("scale_shape_manual")
        End If
    End Sub

    Private Sub ucrReceiverFill_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFill.ControlContentsChanged, ucrReceiverLongitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged, ucrSaveMap.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacet.ControlValueChanged
        If Not ucrReceiverFacet.IsEmpty Then
            clsGGplotOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGGplotOperator.RemoveParameterByName("facets")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        If Not ucrReceiverStation.IsEmpty Then
            clsGGplotOperator.AddParameter("geom_label_repel", clsRFunctionParameter:=clsLabelRepelFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGGplotOperator.RemoveParameterByName("geom_label_repel")
        End If
    End Sub
End Class
