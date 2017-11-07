﻿' R- Instat
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
Public Class dlgCountryColouredMap
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMapDataFunction As New RFunction
    Private clsMapDataOperator As New ROperator
    Private clsFilterMapData As New RFunction
    Private clsFilterExpression As New ROperator
    Private clsLatMin As New ROperator
    Private clsLatMax As New ROperator
    Private clsLongMin As New ROperator
    Private clsLongMax As New ROperator

    Private clsJoinFunction As New RFunction
    Private clsConcatenateFunction As New RFunction

    Private clsBaseOperator As New ROperator
    Private clsGgplot As New RFunction
    Private clsRGeomPolygon As New RFunction
    Private clsRaesFunc As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsCoordMap As New RFunction
    Private bResetSubDialog As Boolean = False

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)

    Private bResetLayerSubdialog As Boolean = True
    Private bResetMapOptions As Boolean = True

    Private Sub dlgCountryColouredMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrReceiverCountry.Selector = ucrSelectorCountryColouredMap
        ucrReceiverColourBy.Selector = ucrSelectorCountryColouredMap

        ucrSelectorCountryColouredMap.SetParameter(New RParameter("y", 1))
        ucrSelectorCountryColouredMap.SetParameterIsrfunction()

        ucrReceiverCountry.SetParameter(New RParameter("region", 2))
        ucrReceiverCountry.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverCountry.SetParameterIsString()

        ucrReceiverColourBy.SetParameter(New RParameter("fill", 3))
        ucrReceiverColourBy.SetParameterIsString()
        ucrReceiverColourBy.bWithQuotes = False

        ucrSaveMap.SetPrefix("Map")
        ucrSaveMap.SetSaveTypeAsGraph()
        ucrSaveMap.SetIsComboBox()
        ucrSaveMap.SetCheckBoxText("Save Graph")
        ucrSaveMap.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveMap.SetDataFrameSelector(ucrSelectorCountryColouredMap.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsMapDataFunction = New RFunction
        clsMapDataOperator = New ROperator
        clsJoinFunction = New RFunction
        clsConcatenateFunction = New RFunction
        clsFilterMapData = New RFunction

        clsBaseOperator = New ROperator
        clsGgplot = New RFunction
        clsRGeomPolygon = New RFunction
        clsCoordMap = New RFunction
        clsRaesFunc = New RFunction


        ucrSelectorCountryColouredMap.Reset()
        ucrSelectorCountryColouredMap.SetGgplotFunction(clsBaseOperator)
        ucrReceiverCountry.SetMeAsReceiver()

        clsMapDataFunction.SetPackageName("ggplot2")
        clsMapDataFunction.SetRCommand("map_data")
        clsMapDataFunction.AddParameter("map", strParameterValue:=Chr(34) & "world" & Chr(34))

        clsMapDataOperator.SetOperation("%>%")
        clsMapDataOperator.AddParameter("world", clsRFunctionParameter:=clsMapDataFunction, iPosition:=0)
        clsMapDataOperator.SetAssignTo("world")

        clsFilterMapData.SetPackageName("dplyr")
        clsFilterMapData.SetRCommand("filter")
        clsFilterMapData.AddParameter("expression", clsROperatorParameter:=clsFilterExpression, bIncludeArgumentName:=False)

        clsLatMin.SetOperation(">=")
        clsLatMin.AddParameter("col", "lat", iPosition:=0)
        clsLatMin.AddParameter("value", "-90", iPosition:=1)
        clsLatMax.SetOperation("<=")
        clsLatMax.AddParameter("col", "lat", iPosition:=0)
        clsLatMax.AddParameter("value", "90", iPosition:=1)
        clsLongMin.SetOperation(">=")
        clsLongMin.AddParameter("col", "long", iPosition:=0)
        clsLongMin.AddParameter("value", "-180", iPosition:=1)
        clsLongMax.SetOperation("<=")
        clsLongMax.AddParameter("col", "long", iPosition:=0)
        clsLongMax.AddParameter("value", "191", iPosition:=1)

        clsFilterExpression.SetOperation("&")
        clsFilterExpression.bBrackets = False
        clsFilterExpression.AddParameter("lat_min", clsROperatorParameter:=clsLatMin, iPosition:=0)
        clsFilterExpression.AddParameter("lat_max", clsROperatorParameter:=clsLatMax, iPosition:=1)
        clsFilterExpression.AddParameter("long_min", clsROperatorParameter:=clsLongMin, iPosition:=2)
        clsFilterExpression.AddParameter("long_max", clsROperatorParameter:=clsLongMax, iPosition:=3)

        clsJoinFunction.SetPackageName("dplyr")
        clsJoinFunction.SetRCommand("right_join")
        clsJoinFunction.SetAssignTo("merged_country")
        clsJoinFunction.AddParameter("x", clsROperatorParameter:=clsMapDataOperator, iPosition:=0)
        clsJoinFunction.AddParameter("by", clsRFunctionParameter:=clsConcatenateFunction, iPosition:=2)
        clsConcatenateFunction.SetRCommand("c")

        clsBaseOperator.SetOperation("+")
        clsGgplot.SetPackageName("ggplot2")
        clsGgplot.SetRCommand("ggplot")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplot, iPosition:=0)

        clsRGeomPolygon.SetPackageName("ggplot2")
        clsRGeomPolygon.SetRCommand("geom_polygon")
        clsRGeomPolygon.AddParameter("data", clsRFunctionParameter:=clsJoinFunction, iPosition:=0)
        'TODO make this an option
        clsRGeomPolygon.AddParameter("color", Chr(34) & "black" & Chr(34))

        clsRaesFunc.SetPackageName("ggplot2")
        clsRaesFunc.SetRCommand("aes")
        clsRGeomPolygon.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunc, iPosition:=1)
        clsRaesFunc.AddParameter("x", "long", iPosition:=0)
        clsRaesFunc.AddParameter("y", "lat", iPosition:=1)
        clsRaesFunc.AddParameter("group", "group")
        clsBaseOperator.AddParameter("polygon", clsRFunctionParameter:=clsRGeomPolygon, iPosition:=1)

        ' temporary better default colours for fill
        ' TODO make this editable in the sub dialog
        clsBaseOperator.AddParameter("fill", "scale_fill_gradientn(colours = rev(heat.colors(10)))")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsCoordMap.SetPackageName("ggplot2")
        clsCoordMap.SetRCommand("coord_quickmap")
        clsBaseOperator.AddParameter("coordquickmap", clsRFunctionParameter:=clsCoordMap, iPosition:=2)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorCountryColouredMap.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorCountryColouredMap.SetRCode(clsJoinFunction, bReset)
        ucrReceiverCountry.SetRCode(clsConcatenateFunction, bReset)
        ucrReceiverColourBy.SetRCode(clsRaesFunc, bReset)
        ucrSaveMap.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCountry.IsEmpty AndAlso Not ucrReceiverColourBy.IsEmpty AndAlso ucrSaveMap.IsComplete Then
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
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunc, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorCountryColouredMap, bReset:=bResetSubDialog)
        bResetSubDialog = False
        sdgPlots.ShowDialog()
    End Sub

    Private Sub cmdPolygonOptions_Click(sender As Object, e As EventArgs) Handles cmdPolygonOptions.Click
        'SetupLayer sends the components storing the plot info (clsRgeom_boxplotFunction, clsRggplotFunction, ...) of dlgBoxPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplot, clsNewGeomFunc:=clsRGeomPolygon, clsNewGlobalAesFunc:=clsRaesFunc, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorCountryColouredMap, bApplyAesGlobally:=True, bReset:=bResetLayerSubdialog)

        'For Each clsParam In clsRaesFunc.clsParameters
        '    If clsParam.strArgumentName = "x" Then
        '        sdgLayerOptions.ucrGeomWithAes.ucrReceiverParam1.Add(clsParam.strArgumentValue, bFixReceiver:=True)
        '    End If
        '    If clsParam.strArgumentName = "y" Then
        '        sdgLayerOptions.ucrGeomWithAes.ucrReceiverParam2.Add(clsParam.strArgumentValue, bFixReceiver:=True)
        '    End If
        '    If clsParam.strArgumentName = "group" Then
        '        sdgLayerOptions.ucrGeomWithAes.ucrReceiverParam6.Add(clsParam.strArgumentValue, bFixReceiver:=True)
        '    End If
        'Next

        sdgLayerOptions.ShowDialog()
        bResetLayerSubdialog = False
    End Sub
    Private Sub ucrReceiverCountry_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCountry.ControlContentsChanged, ucrReceiverColourBy.ControlContentsChanged, ucrSaveMap.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorCountryColouredMap_DataFrameChanged() Handles ucrSelectorCountryColouredMap.DataFrameChanged
        sdgPlots.SetDataFrame(ucrSelectorCountryColouredMap.ucrAvailableDataFrames.strCurrDataFrame)
    End Sub

    Private Sub cmdMapOptions_Click(sender As Object, e As EventArgs) Handles cmdMapOptions.Click
        sdgCountryColouredMapOptions.SetRCode(clsNewJoinFunction:=clsJoinFunction, clsNewMapDataOperator:=clsMapDataOperator, clsNewFilterMapData:=clsFilterMapData, clsNewFilterExpression:=clsFilterExpression, clsNewLatMin:=clsLatMin, clsNewLatMax:=clsLatMax, clsNewLongMin:=clsLongMin, clsNewLongMax:=clsLongMax, bReset:=bResetMapOptions)
        sdgCountryColouredMapOptions.ShowDialog()
        bResetMapOptions = False
    End Sub
End Class