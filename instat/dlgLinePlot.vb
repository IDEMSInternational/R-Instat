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

Public Class dlgLinePlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeomlineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsGeomSmoothFunc As New RFunction
    Private clsGeomSmoothParameter As New RParameter
    Private clsPeaksFunction As New RFunction
    Private clsValleysFunction As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strgeomSmoothParameterName As String = "geom_smooth"
    Private strPeaksPointsParameterName As String = "stat_peaks"
    Private strValleysPointsParameterName As String = "stat_valleys"
    Private strGeomParameterNames() As String = {strFirstParameterName, strgeomSmoothParameterName, strPeaksPointsParameterName, strValleysPointsParameterName}

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsGeomPointFunc As New RFunction
        Dim clsGeomPointParam As New RParameter
        Dim clsPeaksParam As New RParameter
        Dim clsValleysParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 434

        ucrLinePlotSelector.SetParameter(New RParameter("data", 0))
        ucrLinePlotSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.Selector = ucrLinePlotSelector
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrLinePlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Factors"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrReceiverGroup.SetParameter(New RParameter("group", 2))
        ucrReceiverGroup.Selector = ucrLinePlotSelector
        ucrReceiverGroup.bWithQuotes = False
        ucrReceiverGroup.SetParameterIsString()

        ucrVariablesAsFactorForLinePlot.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForLinePlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForLinePlot.Selector = ucrLinePlotSelector
        ucrVariablesAsFactorForLinePlot.strSelectorHeading = "Varibles"
        ucrVariablesAsFactorForLinePlot.SetParameterIsString()
        ucrVariablesAsFactorForLinePlot.bWithQuotes = False
        ucrVariablesAsFactorForLinePlot.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForLinePlot.bAddParameterIfEmpty = True

        clsGeomPointFunc.SetPackageName("ggplot2")
        clsGeomPointFunc.SetRCommand("geom_point")
        clsGeomPointParam.SetArgumentName("geom_point")
        clsGeomPointParam.SetArgument(clsGeomPointFunc)
        clsGeomPointParam.Position = 3
        ucrChkPoints.SetText("Points")
        ucrChkPoints.SetParameter(clsGeomPointParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsGeomSmoothFunc.SetPackageName("ggplot2")
        clsGeomSmoothFunc.SetRCommand("geom_smooth")
        clsGeomSmoothFunc.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsGeomSmoothParameter.SetArgumentName(strgeomSmoothParameterName)
        clsGeomSmoothParameter.SetArgument(clsGeomSmoothFunc)
        ucrChkLineofBestFit.SetText("Add Line of Best Fit")
        ucrChkLineofBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineofBestFit.SetParameter(clsGeomSmoothParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsPeaksFunction.SetPackageName("ggpmisc")
        clsPeaksFunction.SetRCommand("stat_peaks")
        clsPeaksParam.SetArgumentName(strPeaksPointsParameterName)
        clsPeaksParam.SetArgument(clsPeaksFunction)
        clsPeaksFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
        clsPeaksFunction.AddParameter("colour", Chr(34) & "red" & Chr(34))
        ucrChkPeak.SetText("Add Peaks")
        ucrChkPeak.SetParameter(clsPeaksParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        clsValleysFunction.SetPackageName("ggpmisc")
        clsValleysFunction.SetRCommand("stat_valleys")
        clsValleysParam.SetArgumentName(strValleysPointsParameterName)
        clsValleysParam.SetArgument(clsValleysFunction)
        clsValleysFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
        clsValleysFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        ucrChkValley.SetText("Add Valleys")
        ucrChkValley.SetParameter(clsValleysParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)


        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.SetParameter(New RParameter("se", 1))
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrSave.SetPrefix("lineplot")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrLinePlotSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlStepOrPath.AddRadioButton(rdoStep)
        ucrPnlStepOrPath.AddRadioButton(rdoPath)
        ucrPnlStepOrPath.AddFunctionNamesCondition(rdoPath, "geom_path")
        ucrPnlStepOrPath.AddFunctionNamesCondition(rdoStep, "geom_step")
        ucrChkPathOrStep.AddToLinkedControls(ucrPnlStepOrPath, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPathOrStep.SetText("Use path or step")
        ucrChkPathOrStep.AddFunctionNamesCondition(True, {"geom_step", "geom_path"})
        ucrChkPathOrStep.AddFunctionNamesCondition(False, {"geom_step", "geom_path"}, False)
    End Sub

    Private Sub SetDefaults()
        clsRggplotFunction = New RFunction
        clsRgeomlineplotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrLinePlotSelector.Reset()
        ucrLinePlotSelector.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrVariablesAsFactorForLinePlot.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True
        rdoPath.Checked = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomlineplotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=0)
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34), iPosition:=1)

        clsRgeomlineplotFunction.SetPackageName("ggplot2")
        clsRgeomlineplotFunction.SetRCommand("geom_line")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
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

        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsBaseOperator.RemoveParameterByName("geom_point")
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrLinePlotSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForLinePlot.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrReceiverGroup.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkLineofBestFit.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunc, bReset)
        'set Rcode for checkboxes
        ucrChkPeak.SetRCode(clsBaseOperator, bReset)
        ucrChkValley.SetRCode(clsBaseOperator, bReset)
        ucrChkPathOrStep.SetRCode(clsRgeomlineplotFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        'Both x and y aesthetics are mandatory for geom_line. However, when not filled they will be automatically populated by "".
        If Not ucrSave.IsComplete OrElse (ucrReceiverX.IsEmpty AndAlso ucrVariablesAsFactorForLinePlot.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForLinePlot.bSingleVariable Then
            cmdLineOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdLineOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                          clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                          clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrLinePlotSelector,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction,
                          strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomlineplotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrLinePlotSelector, bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForLinePlot.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForLinePlot.Clear()
                Else ucrVariablesAsFactorForLinePlot.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "group" Then
                ucrReceiverGroup.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub UcrVariablesAsFactor_ControlValueChanged() Handles ucrVariablesAsFactorForLinePlot.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged, ucrFactorOptionalReceiver.ControlValueChanged
        SetGroupParam()
    End Sub

    Private Sub SetGroupParam()
        If (Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor")) AndAlso ucrFactorOptionalReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("group", "1", iPosition:=3)
            ucrReceiverGroup.Enabled = False

        ElseIf (Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor")) AndAlso Not ucrFactorOptionalReceiver.IsEmpty Then
            ucrReceiverGroup.Enabled = True
            ucrReceiverGroup.SetText(ucrFactorOptionalReceiver.GetVariableNames(False))
            clsRaesFunction.AddParameter("group", ucrReceiverGroup.GetVariableNames(False), iPosition:=3)
        Else
            clsRaesFunction.RemoveParameterByName("group")
        End If
    End Sub

    Private Sub ucrChkPathOrStep_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPathOrStep.ControlValueChanged, ucrPnlStepOrPath.ControlValueChanged
        If ucrChkPathOrStep.Checked Then
            If rdoStep.Checked Then
                ucrSave.SetPrefix("stepplot")
                clsRgeomlineplotFunction.SetRCommand("geom_step")
            Else
                ucrSave.SetPrefix("pathplot")
                clsRgeomlineplotFunction.SetRCommand("geom_path")
            End If
        Else
            ucrSave.SetPrefix("lineplot")
            clsRgeomlineplotFunction.SetRCommand("geom_line")
        End If
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForLinePlot.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class