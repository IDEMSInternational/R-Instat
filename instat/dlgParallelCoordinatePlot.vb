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
Public Class dlgParallelCoordinatePlot
    Private clsGGParCoordFunc As New RFunction
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsBaseOperator As New ROperator
    Private clsLabsFunction As New RFunction
    Private clsXLabsFunction As New RFunction
    Private clsYLabsFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction

    Private Sub dlgParallelCoordinatePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        Dim dctScale As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 593
        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorParallelCoordinatePlot.SetParameter(New RParameter("data", 0))
        ucrSelectorParallelCoordinatePlot.SetParameterIsrfunction()

        ucrReceiverXVariables.SetParameter(New RParameter("columns", 1))
        ucrReceiverXVariables.strSelectorHeading = "Numerics"
        ucrReceiverXVariables.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverXVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverXVariables.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("groupColumn", 2))
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.Selector = ucrSelectorParallelCoordinatePlot
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameterIsString()

        ucrChkBoxplots.SetParameter(New RParameter("boxplot", 11))
        ' On R, 'boxplot' is the 12th item in the parameter list (but our count starts from 0) so this is position = 11
        ucrChkBoxplots.SetText("Boxplot")
        ucrChkBoxplots.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkBoxplots.SetRDefault("FALSE")

        ucrChkPoints.SetParameter(New RParameter("showPoints", 8))
        ucrChkPoints.SetText("Points")
        ucrChkPoints.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPoints.SetRDefault("FALSE")

        ucrNudTransparency.SetParameter(New RParameter("alphaLines", 10))
        ucrNudTransparency.SetMinMax(0, 1)
        ucrNudTransparency.DecimalPlaces = 2
        ucrNudTransparency.Increment = 0.01
        ucrNudTransparency.SetRDefault(1)

        ucrInputScale.SetParameter(New RParameter("scale", 3))
        dctScale.Add("Std", "std")
        dctScale.Add("Robust", Chr(34) & "robust" & Chr(34))
        dctScale.Add("Uniminmax", Chr(34) & "uniminmax" & Chr(34))
        dctScale.Add("Globalminmax", Chr(34) & "globalminmax" & Chr(34))
        dctScale.Add("Center", Chr(34) & "center" & Chr(34))
        dctScale.Add("CenterObs", Chr(34) & "centerObs" & Chr(34))
        ucrInputScale.SetItems(dctScale)
        ucrInputScale.SetRDefault("std")
        ucrInputScale.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("par_coord_plot")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsGGParCoordFunc = New RFunction

        ucrReceiverXVariables.SetMeAsReceiver()
        ucrSelectorParallelCoordinatePlot.Reset()
        ucrSelectorParallelCoordinatePlot.SetGgplotFunction(clsBaseOperator)
        ucrSaveGraph.Reset()
        bResetSubdialog = True

        clsGGParCoordFunc.SetPackageName("GGally")
        clsGGParCoordFunc.SetRCommand("ggparcoord")

        clsGGParCoordFunc.AddParameter("missing", Chr(34) & "exclude" & Chr(34), iPosition:=6)
        clsGGParCoordFunc.AddParameter("order", Chr(34) & "skewness" & Chr(34), iPosition:=7)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggparcord", clsRFunctionParameter:=clsGGParCoordFunc, iPosition:=0)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorParallelCoordinatePlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorParallelCoordinatePlot.SetRCode(clsGGParCoordFunc, bReset)
        ucrReceiverXVariables.SetRCode(clsGGParCoordFunc, bReset)
        ucrReceiverFactor.SetRCode(clsGGParCoordFunc, bReset)
        ucrChkBoxplots.SetRCode(clsGGParCoordFunc, bReset)
        ucrChkPoints.SetRCode(clsGGParCoordFunc, bReset)
        ucrNudTransparency.SetRCode(clsGGParCoordFunc, bReset)
        ucrInputScale.SetRCode(clsGGParCoordFunc, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrReceiverXVariables.lstSelectedVariables.Items.Count > 1) AndAlso ucrSaveGraph.IsComplete AndAlso ucrNudTransparency.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdParcoordOptions_Click(sender As Object, e As EventArgs) Handles cmdParcoordOptions.Click
        sdgParallelPlots.SetRCode(clsNewRFunction:=clsGGParCoordFunc, bReset:=bReset)
        bResetSubdialog = False
        sdgParallelPlots.ShowDialog()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction,
                          clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction,
                          clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorParallelCoordinatePlot, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrNudTransparency.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class