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

Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsRgeomBarFunction1 As New RFunction
    Private clsRgeomBarFunction2 As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsLevelsFunction As New RFunction
    Private clsSubsetFunction1 As New RFunction
    Private clsSubsetFunction2 As New RFunction
    Private clsPolarCoordFunction As New RFunction
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
    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsScaleXdiscretFunction As New RFunction
    Private clsExpansionFunction As New RFunction
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
    Private clsGeomTextFunction As New RFunction
    Private clsLabelAesFunction As New RFunction
    Private clsAnnotateFunction As New RFunction

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
        Dim dctLabelColours As New Dictionary(Of String, String)
        Dim dctLabelPositions As New Dictionary(Of String, String)
        Dim dctLabelSizes As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 438

        ucrPnlOptions.AddRadioButton(rdoFrequency)
        ucrPnlOptions.AddRadioButton(rdoValue)
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequency, "coordpolar")
        ucrPnlOptions.AddFunctionNamesCondition(rdoValue, "coordpolar")

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates, ucrChkPolarCoordinates, ucrInputBarChartPositions, ucrReceiverByFactor}, {rdoFrequency, rdoValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        ucrReceiverByFactor.SetParameter(New RParameter("fill", 2))
        ucrReceiverByFactor.bWithQuotes = False
        ucrReceiverByFactor.SetParameterIsString()

        ucrSaveBar.SetIsComboBox()
        ucrSaveBar.SetCheckBoxText("Save Graph")
        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.SetSaveTypeAsGraph()
        ucrSaveBar.SetPrefix("bar")
        ucrSaveBar.SetAssignToIfUncheckedValue("last_graph")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkBacktoback.SetText("Back to back")
        ucrChkBacktoback.SetParameter(New RParameter("labels", 0))
        ucrChkBacktoback.SetValueIfChecked("abs")
        ucrChkBacktoback.AddToLinkedControls(ucrInputBarChartPositions, {False}, bNewLinkedChangeParameterValue:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrChkPolarCoordinates.SetText("Polar")
        ucrChkPolarCoordinates.SetParameter(New RParameter("theta"))
        ucrChkPolarCoordinates.SetValueIfChecked(Chr(34) & "y" & Chr(34))
        ucrChkPolarCoordinates.AddToLinkedControls({ucrPnlPolar}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkPolarCoordinates.AddToLinkedControls(ucrChkBacktoback, {False}, bNewLinkedChangeParameterValue:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrPnlPolar.AddRadioButton(rdoPie)
        ucrPnlPolar.AddRadioButton(rdoDonut)

        ucrInputBarChartPositions.SetParameter(New RParameter("position", 0))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputBarChartPositions.SetItems(dctPositionPairs)
        ucrInputBarChartPositions.SetDropDownStyleAsNonEditable()
        ucrInputBarChartPositions.SetRDefault(Chr(34) & "stack" & Chr(34))

        ucrInputLabelColour.SetParameter(New RParameter("colour", 4))
        dctLabelColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctLabelColours.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputLabelColour.SetItems(dctLabelColours)
        ucrInputLabelColour.bAllowNonConditionValues = True

        ucrInputLabelPosition.SetParameter(New RParameter("vjust", 2))
        dctLabelPositions.Add("Out", "-0.25")
        dctLabelPositions.Add("In", "5")
        ucrInputLabelPosition.SetItems(dctLabelPositions)
        ucrInputLabelPosition.SetDropDownStyleAsNonEditable()

        ucrInputLabelSize.SetParameter(New RParameter("size", 5))
        dctLabelSizes.Add("Default", "4")
        dctLabelSizes.Add("Small", "3")
        dctLabelSizes.Add("Big", "7")
        ucrInputLabelSize.SetItems(dctLabelSizes)
        ucrInputLabelSize.SetDropDownStyleAsNonEditable()

        ucrChkAddLabels.SetText("Add Labels")
        ucrChkAddLabels.AddParameterPresentCondition(True, "geom_text")
        ucrChkAddLabels.AddParameterPresentCondition(False, "geom_text", False)
        ucrChkAddLabels.AddToLinkedControls({ucrInputLabelPosition, ucrInputLabelSize, ucrInputLabelColour}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLabelColour.SetLinkedDisplayControl(lblLabelColour)
        ucrInputLabelPosition.SetLinkedDisplayControl(lblLabelPosition)
        ucrInputLabelSize.SetLinkedDisplayControl(lblLabelSize)
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
        clsPolarCoordFunction = New RFunction
        clsScaleXdiscretFunction = New RFunction
        clsExpansionFunction = New RFunction
        clsGeomTextFunction = New RFunction
        clsLabelAesFunction = New RFunction

        ucrBarChartSelector.Reset()
        ucrBarChartSelector.SetGgplotFunction(clsBaseOperator)
        ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True
        'Temp fix: Set panel conditions properly!
        rdoPie.Checked = True
        rdoFrequency.Checked = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)

        clsScaleXdiscretFunction.SetRCommand("scale_x_discrete")
        clsScaleXdiscretFunction.AddParameter("expand", clsRFunctionParameter:=clsExpansionFunction, iPosition:=0)

        clsExpansionFunction.SetRCommand("expansion")
        clsExpansionFunction.AddParameter("add", "c(" & 2 & "," & 0 & ")", iPosition:=0)

        clsPolarCoordFunction.SetPackageName("ggplot2")
        clsPolarCoordFunction.SetRCommand("coord_polar")

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

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("mapping", clsRFunctionParameter:=clsLabelAesFunction, iPosition:=1)
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsLabelAesFunction.SetPackageName("ggplot2")
        clsLabelAesFunction.SetRCommand("aes")

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
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction1, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=1)
        ucrBarChartSelector.AddAdditionalCodeParameterPair(clsSubsetFunction2, ucrBarChartSelector.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsPieAesFunction, ucrReceiverByFactor.GetParameter(), iAdditionalPairNo:=1)
        ucrVariablesAsFactorForBarChart.AddAdditionalCodeParameterPair(clsPieAesFunction, ucrVariablesAsFactorForBarChart.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator1, New RParameter("left", 0), iAdditionalPairNo:=1)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsIsEqualToOperator2, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsLevelsFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrVariablesAsFactorForBarChart.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverX.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsBarAesFunction, bReset)
        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkPolarCoordinates.SetRCode(clsPolarCoordFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkBacktoback.SetRCode(clsScaleYSymmetricFunction, bReset)
        ucrInputBarChartPositions.SetRCode(clsRgeomBarFunction, bReset)
        ucrInputLabelColour.SetRCode(clsGeomTextFunction, bReset)
        ucrChkAddLabels.SetRCode(clsBaseOperator, bReset)
        ucrInputLabelPosition.SetRCode(clsGeomTextFunction, bReset)
        ucrInputLabelSize.SetRCode(clsGeomTextFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoFrequency.Checked Then
            If ucrSaveBar.IsComplete AndAlso (Not ucrVariablesAsFactorForBarChart.IsEmpty OrElse Not ucrReceiverByFactor.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If ucrSaveBar.IsComplete AndAlso (Not ucrVariablesAsFactorForBarChart.IsEmpty OrElse Not ucrReceiverX.IsEmpty OrElse Not ucrReceiverByFactor.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
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
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsBarAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog, bNewEnableDiscrete:=False)
        Else
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsPieAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction, bReset:=bResetSubdialog)
        End If
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...

        'this syncs the coordflip in sdgplots and this main dlg
        'ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)

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
            clsRgeomBarFunction.RemoveParameterByName("width")
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
        clsPieAesFunction.RemoveParameterByName("x")
        clsPieAesFunction.RemoveParameterByName("y")
        If rdoValue.Checked Then
            clsBarAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsBarAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsPieAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            clsPieAesFunction.AddParameter("y", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=2)
            clsRgeomBarFunction2.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
            If ucrReceiverX.IsEmpty Then
                clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
            End If
            If ucrVariablesAsFactorForBarChart.IsEmpty Then
                clsBarAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
                clsPieAesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)
            End If
            If ucrReceiverByFactor.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
                clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=2)
            End If
        Else
            If ucrVariablesAsFactorForBarChart.IsEmpty Then
                clsBarAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
                clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
            ElseIf ucrReceiverByFactor.IsEmpty Then
                clsBarAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
                clsPieAesFunction.AddParameter("fill", Chr(34) & Chr(34), iPosition:=1)
            End If
            clsBarAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            clsPieAesFunction.AddParameter("x", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
            clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
            clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=1)
            clsRgeomBarFunction1.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=2)
            clsRgeomBarFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=1)
            clsRgeomBarFunction2.RemoveParameterByName("stat")
        End If

        If Not ucrVariablesAsFactorForBarChart.bSingleVariable Then
            If rdoFrequency.Checked Then
                clsBarAesFunction.AddParameter("x", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                clsPieAesFunction.AddParameter("x", ucrReceiverByFactor.GetVariableNames(False), iPosition:=0)
                clsBarAesFunction.AddParameter("fill", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
                clsPieAesFunction.AddParameter("fill", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=1)
            Else
                clsBarAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
                clsPieAesFunction.AddParameter("fill", ucrReceiverByFactor.GetVariableNames(False), iPosition:=2)
            End If
        End If

    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged
        SetDialogOptions()
        ChangeParameterName()
    End Sub

    Private Sub ucrReceiverByFactor_ControlContentsChanged() Handles ucrReceiverByFactor.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        ucrChkBacktoback.Enabled = If(Not ucrReceiverByFactor.IsEmpty, True, False)
    End Sub

    Private Sub ucrReceiverX_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        If Not ucrReceiverX.Visible Then
            ucrVariablesAsFactorForBarChart.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkBacktoback_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBacktoback.ControlValueChanged, ucrVariablesAsFactorForBarChart.ControlValueChanged, ucrReceiverByFactor.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        clsBaseOperator.RemoveParameterByName("geom_bar1")
        clsBaseOperator.RemoveParameterByName("geom_bar2")
        clsBaseOperator.RemoveParameterByName("scale_y_symmetric")
        clsAesFunction1.RemoveParameterByName("y")
        clsAesFunction2.RemoveParameterByName("y")
        clsRgeomBarFunction2.RemoveParameterByName("aes")
        ucrChkPolarCoordinates.Enabled = True
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
        clsRggplotFunction.RemoveParameterByName("aes")
        If ucrChkBacktoback.Checked Then
            ucrChkPolarCoordinates.Enabled = False
            ucrChkPolarCoordinates.Checked = Not ucrChkBacktoback.Checked
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsSubsetFunction1.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator1, iPosition:=1, bIncludeArgumentName:=False)
            clsSubsetFunction2.AddParameter("subset", clsROperatorParameter:=clsIsEqualToOperator2, iPosition:=1, bIncludeArgumentName:=False)
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
        ChangeParameterName()
        SetGeomTextOptions()
    End Sub

    Private Sub ucrChkPolarCoordinates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPolarCoordinates.ControlValueChanged, ucrPnlPolar.ControlValueChanged
        clsBaseOperator.RemoveParameterByName("coordpolar")
        ChangeParameterName()
        If Not rdoDonut.Checked OrElse Not ucrChkPolarCoordinates.Checked Then
            clsBaseOperator.RemoveParameterByName("scale")
        End If
        If Not rdoDonut.Checked OrElse Not rdoPie.Checked Then
            ChangeParameterName()
        End If
        If ucrChkPolarCoordinates.Checked Then
            ucrChkBacktoback.Checked = Not ucrChkPolarCoordinates.Checked
            clsRggplotFunction.RemoveParameterByName("mapping")
            clsRggplotFunction.AddParameter("aes", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1, bIncludeArgumentName:=False)
            If rdoDonut.Checked Then
                clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsScaleXdiscretFunction, iPosition:=4, bIncludeArgumentName:=False)
            End If
            clsBaseOperator.AddParameter("coordpolar", clsRFunctionParameter:=clsPolarCoordFunction, iPosition:=3)
        End If

    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextFunction, iPosition:=5)
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub SetGeomTextOptions()
        If ucrInputBarChartPositions.GetText = "Dodge" Then
            clsGeomTextFunction.AddParameter("position", "position_dodge(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Fill" Then
            clsGeomTextFunction.AddParameter("position", "position_fill(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Jitter" Then
            clsGeomTextFunction.AddParameter("position", "position_jitter(width = 0.9)", iPosition:=2)
        ElseIf ucrInputBarChartPositions.GetText = "Stack in reverse" Then
            clsGeomTextFunction.AddParameter("position", "position_stack(vjust = 0.5, reverse = TRUE)", iPosition:=2)
        Else
            clsGeomTextFunction.AddParameter("position", "position_identity()", iPosition:=2)
        End If
        If rdoFrequency.Checked Then
            clsGeomTextFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=0)
            clsLabelAesFunction.AddParameter("label", "..count..", iPosition:=0)
        Else
            clsGeomTextFunction.RemoveParameterByName("stat")
            clsLabelAesFunction.AddParameter("label", ucrVariablesAsFactorForBarChart.GetVariableNames(False), iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputBarChartPositions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBarChartPositions.ControlValueChanged
        SetGeomTextOptions()
    End Sub

    Private Sub ucrSaveBar_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForBarChart.ControlContentsChanged, ucrReceiverByFactor.ControlContentsChanged, ucrSaveBar.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrChkBacktoback.ControlContentsChanged, ucrChkPolarCoordinates.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
