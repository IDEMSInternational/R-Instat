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
Public Class dlgClimaticMaps
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGgplotFunction, clsGeomSfFunction, clsGeomPointFunction, clsAesFunction As RFunction
    Private clsGGplotOperator As New ROperator

    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private clsLocalRaesFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private bResetSFLayerSubdialog As Boolean = True


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

        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverFill.SetParameter(New RParameter("fill", 0))
        ucrReceiverFill.Selector = ucrSelectorClimaticMaps
        ucrReceiverFill.SetParameterIsRFunction()
        ucrReceiverFill.bAttachedToPrimaryDataFrame = False
        ucrReceiverFill.bOnlyLinkedToPrimaryDataFrames = False
        ucrReceiverFill.bIncludeDataFrameInAssignment = True

        UcrReceiverLon.SetParameter(New RParameter("x", 0))
        UcrReceiverLon.Selector = ucrSelectorClimaticMaps
        UcrReceiverLon.SetParameterIsRFunction()
        UcrReceiverLon.bAttachedToPrimaryDataFrame = False
        UcrReceiverLon.bOnlyLinkedToPrimaryDataFrames = False
        UcrReceiverLon.bIncludeDataFrameInAssignment = True

        UcrReceiverLat.SetParameter(New RParameter("y", 1))
        UcrReceiverLat.Selector = ucrSelectorClimaticMaps
        UcrReceiverLat.SetParameterIsRFunction()
        UcrReceiverLat.bAttachedToPrimaryDataFrame = False
        UcrReceiverLat.bOnlyLinkedToPrimaryDataFrames = False
        UcrReceiverLat.bIncludeDataFrameInAssignment = True

        UcrReceiverColor.SetParameter(New RParameter("color", 2))
        UcrReceiverColor.Selector = ucrSelectorClimaticMaps
        UcrReceiverColor.SetParameterIsRFunction()
        UcrReceiverColor.bAttachedToPrimaryDataFrame = False
        UcrReceiverColor.bOnlyLinkedToPrimaryDataFrames = False
        UcrReceiverColor.bIncludeDataFrameInAssignment = True

        UcrReceiverShape.SetParameter(New RParameter("shape", 3))
        UcrReceiverShape.Selector = ucrSelectorClimaticMaps
        UcrReceiverShape.SetParameterIsRFunction()
        UcrReceiverShape.bAttachedToPrimaryDataFrame = False
        UcrReceiverShape.bOnlyLinkedToPrimaryDataFrames = False
        UcrReceiverShape.bIncludeDataFrameInAssignment = True



        ucrSaveMap.SetPrefix("Map")
        ucrSaveMap.SetSaveTypeAsGraph()
        ucrSaveMap.SetIsComboBox()
        ucrSaveMap.SetCheckBoxText("Save Map")
        ucrSaveMap.SetAssignToIfUncheckedValue("last_map")
        ucrSaveMap.SetDataFrameSelector(ucrSelectorClimaticMaps.ucrAvailableDataFrames)

    End Sub

    Private Sub SetDefaults()
        clsGeomSfFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsAesFunction = New RFunction
        clsGeomPointFunction = New RFunction



        clsGGplotOperator = New ROperator

        ucrSelectorClimaticMaps.Reset()
        ucrReceiverFill.SetMeAsReceiver()
        ucrSaveMap.Reset()
        bResetSubdialog = True
        bResetSFLayerSubdialog = True

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")

        clsGeomSfFunction.SetPackageName("ggplot2")
        clsGeomSfFunction.SetRCommand("geom_sf")
        clsGeomSfFunction.AddParameter("aes", clsRFunctionParameter:=clsAesFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")

        clsGGplotOperator.SetOperation("+")
        clsGGplotOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsGGplotOperator.AddParameter("geom_sf", clsRFunctionParameter:=clsGeomSfFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsGGplotOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointFunction, bIncludeArgumentName:=False, iPosition:=2)

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

        clsGGplotOperator.SetAssignTo("last_map", strTempDataframe:=ucrSelectorClimaticMaps.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_map")
        ucrBase.clsRsyntax.SetBaseROperator(clsGGplotOperator)
    End Sub

    Private Sub cmdMapOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsGGplotOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsAesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorClimaticMaps, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorClimaticMaps.SetRCode(clsGeomSfFunction, bReset)
        ucrReceiverFill.SetRCode(clsAesFunction, bReset)
        ucrSaveMap.SetRCode(clsGGplotOperator, bReset)
    End Sub

    Private Sub UcrReceiverColor_Load(sender As Object, e As EventArgs) Handles UcrReceiverShape.Load

    End Sub

    Private Sub LabelLon_Click(sender As Object, e As EventArgs) Handles LabelLon.Click

    End Sub

    Private Sub cmdSFOptions_Click(sender As Object, e As EventArgs) Handles cmdSFOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsGgplotFunction, clsNewGeomFunc:=clsGeomSfFunction, clsNewGlobalAesFunc:=clsAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=False, ucrNewBaseSelector:=ucrSelectorClimaticMaps, bApplyAesGlobally:=True, bReset:=bResetSFLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSFLayerSubdialog = False
        For Each clsParam In clsAesFunction.clsParameters
            If clsParam.strArgumentName = "fill" Then
                ucrReceiverFill.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()

    End Sub
End Class