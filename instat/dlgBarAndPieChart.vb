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

Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsRgeomBarFunction1 As New RFunction
    Private clsRgeomBarFunction2 As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsLevelsFunction As New RFunction
    Private clsSubsetFunction1 As New RFunction
    Private clsSubsetFunction2 As New RFunction
    Private clsScaleYSymmetricFunction As New RFunction
    Private clsAesFunction1 As New RFunction
    Private clsAesFunction2 As New RFunction
    Private clsPieAesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsIsEqualToOperator1 As New ROperator
    Private clsIsEqualToOperator2 As New ROperator
    Private clsOpeningSubsetOperator1 As New ROperator
    Private clsOpeningSubsetOperator2 As New ROperator
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

    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequency, "coordpolar")
        ucrPnlOptions.AddFunctionNamesCondition(rdoValue, "coordpolar")

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates, ucrInputBarChartPositions, ucrReceiverByFactor}, {rdoFrequency, rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverByFactor.SetLinkedDisplayControl(lblByFactor)
        ucrReceiverX.SetLinkedDisplayControl(lblXvariable)
        ucrInputBarChartPositions.SetLinkedDisplayControl(lblPosition)

        ucrBarChartSelector.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
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

        ucrChkBacktoback.SetText("Back to back")

        ucrChkPolarCoordinates.SetText("Polar coordinates") 'Not yet implemented

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
        clsIsEqualToOperator1 = New ROperator
        clsIsEqualToOperator2 = New ROperator
        clsOpeningSubsetOperator2 = New ROperator
        clsOpeningSubsetOperator1 = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction1 = New RFunction
        clsRgeomBarFunction2 = New RFunction
        clsBarAesFunction = New RFunction
        clsPieAesFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsSubsetFunction1 = New RFunction
        clsSubsetFunction2 = New RFunction
        clsAesFunction1 = New RFunction
        clsAesFunction2 = New RFunction
        clsScaleYSymmetricFunction = New RFunction

        ucrBarChartSelector.Reset()
        ucrBarChartSelector.SetGgplotFunction(clsBaseOperator)
        ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")
        clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsAesFunction1.SetRCommand("aes")
        clsAesFunction1.AddParameter("y", "..count..*(-1)", iPosition:=0)

        clsAesFunction2.SetRCommand("aes")

        clsLevelsFunction.SetRCommand("levels")

        clsIsEqualToOperator1.SetOperation("==")
        clsIsEqualToOperator1.AddParameter("right", clsROperatorParameter:=clsOpeningSubsetOperator1, iPosition:=1)

        clsIsEqualToOperator2.SetOperation("==")
        clsIsEqualToOperator2.AddParameter("right", clsROperatorParameter:=clsOpeningSubsetOperator2, iPosition:=1)

        clsOpeningSubsetOperator1.SetOperation("[")
        clsOpeningSubsetOperator1.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsOpeningSubsetOperator1.AddParameter("right", "2]", iPosition:=1)
        clsOpeningSubsetOperator1.bSpaceAroundOperation = False
        clsOpeningSubsetOperator1.bBrackets = False

        clsOpeningSubsetOperator2.SetOperation("[")
        clsOpeningSubsetOperator2.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsOpeningSubsetOperator2.AddParameter("right", "1]", iPosition:=1)
        clsOpeningSubsetOperator2.bSpaceAroundOperation = False
        clsOpeningSubsetOperator2.bBrackets = False

        clsSubsetFunction1.SetRCommand("subset")

        clsRgeomBarFunction1.SetPackageName("ggplot2")
        clsRgeomBarFunction1.SetRCommand("geom_bar")
        clsRgeomBarFunction1.AddParameter("data", clsRFunctionParameter:=clsSubsetFunction1, iPosition:=0)
        clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)

        clsRgeomBarFunction2.SetPackageName("ggplot2")
        clsRgeomBarFunction2.SetRCommand("geom_bar")
        clsRgeomBarFunction2.AddParameter("data", clsRFunctionParameter:=clsSubsetFunction2, iPosition:=0)

        clsSubsetFunction2.SetRCommand("subset")

        clsScaleYSymmetricFunction.SetPackageName("lemon")
        clsScaleYSymmetricFunction.SetRCommand("scale_y_symmetric")
        clsScaleYSymmetricFunction.AddParameter("labels", "abs", iPosition:=0)

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
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction1, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=1)
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction2, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=2)
        ucrVariablesAsFactorForBarChart.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverX.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsBarAesFunction, bReset)
        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
        'ucrPnlOptions.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoFrequency.Checked Then
            If Not ucrSaveBar.IsComplete OrElse ucrVariablesAsFactorForBarChart.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
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
            'If Not clsBaseOperator.ContainsParameter("geom_bar") Then
            '    clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            'End If
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
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=2)
            clsRgeomBarFunction2.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        ElseIf rdoFrequency.Checked Then
            clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
            clsRgeomBarFunction2.RemoveParameterByName("stat")
        End If
    End Sub
    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverX.ControlValueChanged
        SetDialogOptions()
        ChangeParameterName()
    End Sub

    Private Sub ucrChkBacktoback_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBacktoback.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        clsBaseOperator.RemoveParameterByName("geom_bar1")
        clsBaseOperator.RemoveParameterByName("geom_bar2")
        clsBaseOperator.RemoveParameterByName("scale_y_symmetric")
        clsAesFunction1.RemoveParameterByName("y")
        clsAesFunction2.RemoveParameterByName("y")
        clsRgeomBarFunction2.RemoveParameterByName("aes")
        ucrInputBarChartPositions.Enabled = True
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
        If ucrChkBacktoback.Checked Then
            ucrInputBarChartPositions.Enabled = False
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsIsEqualToOperator1.AddParameter("left", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
            clsIsEqualToOperator2.AddParameter("left", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
            clsLevelsFunction.AddParameter("1", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
            clsSubsetFunction1.AddParameter("1", clsROperatorParameter:=clsIsEqualToOperator1, iPosition:=1, bIncludeArgumentName:=False)
            clsSubsetFunction2.AddParameter("1", clsROperatorParameter:=clsIsEqualToOperator2, iPosition:=1, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("geom_bar2", clsRFunctionParameter:=clsRgeomBarFunction2, iPosition:=1)
            clsBaseOperator.AddParameter("geom_bar1", clsRFunctionParameter:=clsRgeomBarFunction1, iPosition:=2)
            clsBaseOperator.AddParameter("scale_y_symmetric", clsRFunctionParameter:=clsScaleYSymmetricFunction, iPosition:=3)
            If rdoValue.Checked Then
                clsAesFunction1.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                clsAesFunction2.AddParameter("y", "-" & ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
                clsRgeomBarFunction2.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)
                clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction2, iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsAesFunction1.AddParameter("y", "..count..*(-1)", iPosition:=0)
                clsRgeomBarFunction1.AddParameter("aes", clsRFunctionParameter:=clsAesFunction1, iPosition:=1, bIncludeArgumentName:=False)
            End If

        End If
    End Sub
    Private Sub ucrSaveBar_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForBarChart.ControlContentsChanged, ucrSaveBar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class
