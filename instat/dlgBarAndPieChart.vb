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

Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsPieAesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsRCoordPolarParam As New RParameter
    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFuction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBarLayerSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction

    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsRCoordPolarFunction As New RFunction
        Dim dctPositionPairs As New Dictionary(Of String, String)
        Dim dctStatOptions As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 438

        ucrPnlOptions.AddRadioButton(rdoFrequency)
        ucrPnlOptions.AddRadioButton(rdoValue)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequency, "coordpolar")
        ucrPnlOptions.AddFunctionNamesCondition(rdoValue, "coordpolar")
        ucrPnlOptions.AddFunctionNamesCondition(rdoPieChart, "coordpolar")

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates, ucrInputBarChartPositions, ucrReceiverByFactor}, {rdoFrequency, rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverByFactor.SetLinkedDisplayControl(lblByFactor)
        ucrReceiverX.SetLinkedDisplayControl(lblXvariable)
        ucrInputBarChartPositions.SetLinkedDisplayControl(lblPosition)

        ucrBarChartSelector.SetParameter(New RParameter("data", 0))
        ucrBarChartSelector.SetParameterIsrfunction()

        ucrVariablesAsFactorForBarChart.SetParameterIsString()
        ucrVariablesAsFactorForBarChart.Selector = ucrBarChartSelector
        ucrVariablesAsFactorForBarChart.SetFactorReceiver(ucrReceiverByFactor)
        ucrVariablesAsFactorForBarChart.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForBarChart.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForBarChart.bAddParameterIfEmpty = True

        ucrReceiverX.Selector = ucrBarChartSelector
        ucrReceiverX.strSelectorHeading = "X Variable"
        ucrReceiverX.SetParameterIsString()

        ucrReceiverByFactor.Selector = ucrBarChartSelector
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverByFactor.strSelectorHeading = "Factors"
        ucrReceiverByFactor.SetParameter(New RParameter("fill", 1))
        ucrReceiverByFactor.bWithQuotes = False
        ucrReceiverByFactor.SetParameterIsString()

        ucrSaveBar.SetIsComboBox()
        ucrSaveBar.SetCheckBoxText("Save Graph")
        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.SetSaveTypeAsGraph()
        ucrSaveBar.SetPrefix("bar")
        ucrSaveBar.SetAssignToIfUncheckedValue("last_graph")

        clsRCoordPolarFunction.SetPackageName("ggplot2")
        clsRCoordPolarFunction.SetRCommand("coord_polar")
        clsRCoordPolarFunction.AddParameter("theta", Chr(34) & "y" & Chr(34))
        clsRCoordPolarParam.SetArgumentName("coordpolar")
        clsRCoordPolarParam.SetArgument(clsRCoordPolarFunction)

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)


        ucrInputBarChartPositions.SetParameter(New RParameter("position", 0))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputBarChartPositions.SetItems(dctPositionPairs)
        ucrInputBarChartPositions.SetDropDownStyleAsNonEditable()
        ucrInputBarChartPositions.SetRDefault(Chr(34) & "stack" & Chr(34))

    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsPieAesFunction = New RFunction

        ucrBarChartSelector.Reset()
        ucrBarChartSelector.SetGgplotFunction(clsBaseOperator)
        ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")
        clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFuction = GgplotDefaults.clsDefaultThemeFunction.Clone
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrVariablesAsFactorForBarChart.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverX.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsBarAesFunction, bReset)
        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoFrequency.Checked Then
            If Not ucrSaveBar.IsComplete OrElse ucrVariablesAsFactorForBarChart.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoValue.Checked Then
            If Not ucrSaveBar.IsComplete OrElse ucrVariablesAsFactorForBarChart.IsEmpty OrElse ucrReceiverX.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If rdoValue.Checked Or rdoFrequency.Checked Then
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsBarAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog, bNewEnableDiscrete:=False)
        Else
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsPieAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        End If
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...

        'this syncs the coordflip in sdgplots and this main dlg
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        'What should global and local aes be?
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsBarAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        If clsBarAesFunction.ContainsParameter("x") Then
            ucrVariablesAsFactorForBarChart.Add(clsBarAesFunction.GetParameter("x").strArgumentValue)
        Else
            ucrVariablesAsFactorForBarChart.Clear()
        End If
        If clsBarAesFunction.ContainsParameter("fill") Then
            ucrReceiverByFactor.Add(clsBarAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrReceiverByFactor.Clear()
        End If
        'Allows for sync with the layer parameters
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
        TestOkEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsPieAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        If rdoValue.Checked Or rdoFrequency.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True
            cmdColumnChartOptions.Visible = False
            If Not clsBaseOperator.ContainsParameter("geom_bar") Then
                clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            End If
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameter(clsRCoordPolarParam)
            clsBaseOperator.RemoveParameterByName("geom_col")
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("bar")
            End If
            ucrVariablesAsFactorForBarChart.RemoveIncludedMetadataProperty("class")
            ucrVariablesAsFactorForBarChart.strSelectorHeading = "Variables"
        End If
    End Sub

    Private Sub ChangeParameterName()
        clsBarAesFunction.RemoveParameterByName("x")
        clsBarAesFunction.RemoveParameterByName("y")
        If rdoValue.Checked Then
            clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=1)
            clsBarAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=2)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        ElseIf rdoFrequency.Checked Then
            clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
        End If
    End Sub
    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverX.ControlValueChanged
        SetDialogOptions()
        ChangeParameterName()
    End Sub

    Private Sub CoreControls_ContentsChanged() Handles ucrVariablesAsFactorForBarChart.ControlContentsChanged, ucrSaveBar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
