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

Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRScatterGeomFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsFirstPlusOperator, clsSecondPlusOperator, clsThirdPlusOperator As New ROperator
    Private clsLollipopggplotFunction, clsSegmentggplotFunction, clsFirstggPointFunction, clsSecondggPointFunction, clsSegmentaesFunction, clsFirstPointaesFunction, clsSecondPointaesFunction, clsFlipCoordinateFunction, clsDiagonalaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetlayerSubdialog As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabsFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsFacetsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Dim strReceiverXVarType As String = ""
    Dim strReceiverYSingleVarType As String = ""
    Dim strReceiverYMultipleVarType As String = ""
    Private clsGeomSmoothFunc As New RFunction
    Private clsGeomSmoothParameter As New RParameter
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strGeomSmoothParameterName As String = "geom_smooth"
    Private strGeomParameterNames() As String = {strFirstParameterName, strGeomSmoothParameterName}

    Private Sub dlgScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CheckIfNumeric()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 433
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        'ucrRdoOptions
        ucrPnlType.AddRadioButton(rdoPoints)
        ucrPnlType.AddRadioButton(rdoSegments)

        'ucrPnlPlotType.SetParameter()
        ucrPnlPlotType.AddRadioButton(rdoSimple)
        ucrPnlPlotType.AddRadioButton(rdoDouble)
        ucrPnlPlotType.AddRadioButton(rdoDiagonal)

        ucrPnlType.AddFunctionNamesCondition(rdoPoints, "")
        ucrPnlType.AddFunctionNamesCondition(rdoSegments, "")

        'disabling replaceby input text box
        ucrPnlType.AddToLinkedControls({ucrReceiverX, ucrReceiverLabel, ucrFactorOptionalReceiver, ucrVariablesAsFactorForScatter, ucrChkLineofBestFit, ucrChkWithSE}, {rdoPoints}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverX.SetLinkedDisplayControl(lblXVariable)
        ucrFactorOptionalReceiver.SetLinkedDisplayControl(lblFactorOptional)
        ucrReceiverLabel.SetLinkedDisplayControl(lblVariable)
        'ucrVariablesAsFactorForScatter.SetLinkedDisplayControl(cmdOptions)
        'ucrChkWithSE.SetLinkedDisplayControl(cmdScatterPlotOptions)
        ucrPnlType.AddToLinkedControls({ucrReceiverXStart, ucrReceiverXEnd, ucrReceiverYStart, ucrReceiverYEnd}, {rdoSegments}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls({ucrChkAddPoints}, {rdoSegments}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls({ucrChkHorizontal}, {rdoSegments}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverXStart.SetLinkedDisplayControl(lblXStart)
        ucrReceiverXEnd.SetLinkedDisplayControl(lblXEnd)
        ucrReceiverYStart.SetLinkedDisplayControl(lblYStart)
        ucrReceiverYEnd.SetLinkedDisplayControl(lblYEnd)
        'ucrChkAddPoints.SetLinkedDisplayControl(grpLollipopType)
        'ucrChkAddPoints.SetLinkedDisplayControl(grpOrientation)

        ucrSelectorForScatter.SetParameter(New RParameter("data", 0))
        ucrSelectorForScatter.SetParameterIsrfunction()

        ucrVariablesAsFactorForScatter.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForScatter.SetParameterIsString()
        ucrVariablesAsFactorForScatter.bWithQuotes = False
        ucrVariablesAsFactorForScatter.Selector = ucrSelectorForScatter
        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForScatter.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForScatter.bAddParameterIfEmpty = True

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrReceiverLabel.SetParameter(New RParameter("label"))
        ucrReceiverLabel.SetParameterIsString()
        ucrReceiverLabel.bWithQuotes = False
        ucrReceiverLabel.Selector = ucrSelectorForScatter
        ucrReceiverLabel.strSelectorHeading = "Variables"


        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.SetParameterIsString()
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.strSelectorHeading = "Variables"

        clsGeomSmoothFunc.SetPackageName("ggplot2")
        clsGeomSmoothFunc.SetRCommand("geom_smooth")
        clsGeomSmoothFunc.AddParameter("method", Chr(34) & "lm" & Chr(34), iPosition:=0)
        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)
        clsGeomSmoothParameter.SetArgumentName(strGeomSmoothParameterName)
        clsGeomSmoothParameter.SetArgument(clsGeomSmoothFunc)
        ucrChkLineofBestFit.SetText("Add Line of Best Fit")
        ucrChkLineofBestFit.AddToLinkedControls(ucrChkWithSE, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLineofBestFit.SetParameter(clsGeomSmoothParameter, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkWithSE.SetText("With Standard Error")
        ucrChkWithSE.SetParameter(New RParameter("se"), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrChkWithSE.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithSE.SetRDefault("TRUE")

        ucrReceiverXStart.SetParameter(New RParameter("x", 0))
        ucrReceiverXStart.Selector = ucrSelectorForScatter
        ucrReceiverXStart.SetParameterIsString()
        ucrReceiverXStart.bWithQuotes = False

        ucrReceiverXEnd.SetParameter(New RParameter("xend", 4))
        ucrReceiverXEnd.Selector = ucrSelectorForScatter
        ucrReceiverXEnd.SetParameterIsString()
        ucrReceiverXEnd.bWithQuotes = False

        ucrReceiverYStart.SetParameter(New RParameter("y", 2))
        ucrReceiverYStart.Selector = ucrSelectorForScatter
        ucrReceiverYStart.SetParameterIsString()
        ucrReceiverYStart.bWithQuotes = False

        ucrReceiverYEnd.SetParameter(New RParameter("yend", 3))
        ucrReceiverYEnd.Selector = ucrSelectorForScatter
        ucrReceiverYEnd.SetParameterIsString()
        ucrReceiverYEnd.bWithQuotes = False

        ucrChkAddPoints.SetParameter(New RParameter("first_point", 1))
        ucrChkAddPoints.SetText("Add Points")
        'ucrChkAddPoints.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAddPoints.Checked = True

        ucrChkHorizontal.SetParameter(New RParameter("coord_flip", 1))
        ucrChkHorizontal.SetText("Horizontal Orientation")
        'ucrChkHorizontal.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkHorizontal.SetRDefault("FALSE")

        ucrSaveScatterPlot.SetPrefix("scatterplot")
        ucrSaveScatterPlot.SetSaveTypeAsGraph()
        ucrSaveScatterPlot.SetDataFrameSelector(ucrSelectorForScatter.ucrAvailableDataFrames)
        ucrSaveScatterPlot.SetCheckBoxText("Save Graph")
        ucrSaveScatterPlot.SetIsComboBox()
        ucrSaveScatterPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRScatterGeomFunction = New RFunction
        clsRaesFunction = New RFunction

        clsFirstPlusOperator = New ROperator
        clsSecondPlusOperator = New ROperator
        clsThirdPlusOperator = New ROperator
        clsLollipopggplotFunction = New RFunction
        clsSegmentggplotFunction = New RFunction
        clsFirstggPointFunction = New RFunction
        clsSecondggPointFunction = New RFunction
        clsSegmentaesFunction = New RFunction
        clsFirstPointaesFunction = New RFunction
        clsSecondPointaesFunction = New RFunction
        clsFlipCoordinateFunction = New RFunction
        clsDiagonalaesFunction = New RFunction

        rdoPoints.Checked = True
        rdoSimple.Checked = True

        ucrSelectorForScatter.Reset()
        ucrSelectorForScatter.SetGgplotFunction(clsBaseOperator)
        ucrSaveScatterPlot.Reset()
        ucrVariablesAsFactorForScatter.SetMeAsReceiver()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetlayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRScatterGeomFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))


        clsRScatterGeomFunction.SetPackageName("ggplot2")
        clsRScatterGeomFunction.SetRCommand("geom_point")


        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsFacetsFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction

        clsGeomSmoothFunc.AddParameter("se", "FALSE", iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsLollipopggplotFunction.SetPackageName("ggplot2")
        clsLollipopggplotFunction.SetRCommand("ggplot")

        clsFirstPlusOperator.SetOperation("+")
        clsSecondPlusOperator.SetOperation("+")
        clsThirdPlusOperator.SetOperation("+")

        clsSegmentggplotFunction.SetPackageName("ggplot2")
        clsSegmentggplotFunction.SetRCommand("geom_segment")
        clsSegmentggplotFunction.RemoveParameterByPosition(1)
        clsSegmentggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsSegmentaesFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsSegmentaesFunction.SetPackageName("ggplot2")
        clsSegmentaesFunction.SetRCommand("aes")

        clsFirstggPointFunction.SetPackageName("ggplot2")
        clsFirstggPointFunction.SetRCommand("geom_point")
        clsFirstggPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsFirstPointaesFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsFirstPointaesFunction.SetPackageName("ggplot2")
        clsFirstPointaesFunction.SetRCommand("aes")

        clsSecondggPointFunction.SetPackageName("ggplot2")
        clsSecondggPointFunction.SetRCommand("geom_point")
        clsSecondggPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsSecondPointaesFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsSecondPointaesFunction.SetPackageName("ggplot2")
        clsSecondPointaesFunction.SetRCommand("aes")
        clsSecondPointaesFunction.RemoveParameterByPosition(2)

        clsFlipCoordinateFunction.SetRCommand("coord_flip")

        clsDiagonalaesFunction.SetPackageName("ggplot2")
        clsDiagonalaesFunction.SetRCommand("aes")


        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        'ucrSelectorForScatter.AddAdditionalCodeParameterPair(clsLollipopggplotFunction, New RParameter("data", 0), iAdditionalPairNo:=1)
        'ucrSelectorForScatter.AddAdditionalCodeParameterPair(clsSegmentggplotFunction, New RParameter("data", 0), iAdditionalPairNo:=2)
        'ucrSelectorForScatter.AddAdditionalCodeParameterPair(clsFirstggPointFunction, New RParameter("data", 0), iAdditionalPairNo:=3)
        'ucrSelectorForScatter.AddAdditionalCodeParameterPair(clsSecondggPointFunction, New RParameter("data", 0), iAdditionalPairNo:=4)

        ucrReceiverXStart.AddAdditionalCodeParameterPair(clsSegmentaesFunction, New RParameter("xend", 1), iAdditionalPairNo:=1)
        ucrReceiverXStart.AddAdditionalCodeParameterPair(clsFirstPointaesFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverXStart.AddAdditionalCodeParameterPair(clsSecondPointaesFunction, New RParameter("x", 0), iAdditionalPairNo:=3)

        ucrReceiverXStart.AddAdditionalCodeParameterPair(clsDiagonalaesFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverXEnd.AddAdditionalCodeParameterPair(clsDiagonalaesFunction, New RParameter("xend", 1), iAdditionalPairNo:=1)
        ucrReceiverYStart.AddAdditionalCodeParameterPair(clsDiagonalaesFunction, New RParameter("y", 2), iAdditionalPairNo:=1)
        ucrReceiverYEnd.AddAdditionalCodeParameterPair(clsDiagonalaesFunction, New RParameter("yend", 3), iAdditionalPairNo:=1)

        ucrReceiverYStart.AddAdditionalCodeParameterPair(clsFirstPointaesFunction, New RParameter("y", 1), iAdditionalPairNo:=2)
        ucrReceiverYEnd.AddAdditionalCodeParameterPair(clsSecondPointaesFunction, New RParameter("y", 1), iAdditionalPairNo:=2)

        'ucrChkAddPoints.AddAdditionalCodeParameterPair(clsThirdPlusOperator, New RParameter("first_point", 0), iAdditionalPairNo:=2)

        ucrSelectorForScatter.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrReceiverLabel.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForScatter.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrChkLineofBestFit.SetRCode(clsBaseOperator, bReset)
        ucrSaveScatterPlot.SetRCode(clsBaseOperator, bReset)
        ucrChkWithSE.SetRCode(clsGeomSmoothFunc, bReset)

        ucrReceiverXStart.SetRCode(clsSegmentaesFunction, bReset)
        ucrReceiverXEnd.SetRCode(clsSegmentaesFunction, bReset)
        ucrReceiverYStart.SetRCode(clsSegmentaesFunction, bReset)
        ucrReceiverYEnd.SetRCode(clsSegmentaesFunction, bReset)

        'ucrChkHorizontal.SetRCode(clsThirdPlusOperator, bReset)
        'ucrChkAddPoints.SetRCode(clsFirstPlusOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ' Either y or x can be empty but not both
        ucrBase.OKEnabled(True)
        'If (Not ucrSaveScatterPlot.IsComplete) OrElse (ucrVariablesAsFactorForScatter.IsEmpty AndAlso ucrReceiverX.IsEmpty()) Then
        '    ucrBase.OKEnabled(False)
        'Else
        '    ucrBase.OKEnabled(True)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewGlobalAesFunction:=clsRaesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction, clsNewFacetFunction:=clsFacetsFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSelectorForScatter, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdScatterPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdScatterPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRaesFunction, clsRggplotFunction, ...) of dlgScatteredPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRScatterGeomFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorForScatter, bApplyAesGlobally:=True, bReset:=bResetlayerSubdialog)
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.
        sdgLayerOptions.ShowDialog()
        ucrReceiverLabel.SetRCode(clsRaesFunction, bReset)
        bResetlayerSubdialog = False
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
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForScatter.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForScatter.Clear()
                Else ucrVariablesAsFactorForScatter.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub
    Private Sub ucrSaveScatterPlot_ContentsChanged() Handles ucrSaveScatterPlot.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForScatter.ControlContentsChanged, ucrSaveScatterPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub CheckIfNumeric()
        'strReceiverXVarType = ucrReceiverX.strCurrDataType
        'strReceiverYSingleVarType = ucrVariablesAsFactorForScatter.ucrSingleVariable.strCurrDataType

        'If (ucrVariablesAsFactorForScatter.ucrMultipleVariables.GetCurrentItemTypes.Count > 0) Then
        '    strReceiverYMultipleVarType = ucrVariablesAsFactorForScatter.ucrMultipleVariables.GetCurrentItemTypes.Item(0) 'how about the others as this just gets for the first one 
        'Else
        '    strReceiverYMultipleVarType = ""
        'End If

        'If (Not ucrVariablesAsFactorForScatter.IsEmpty() AndAlso Not ucrReceiverX.IsEmpty()) Then
        '    If ((strReceiverXVarType = "numeric" OrElse strReceiverXVarType = "integer") AndAlso (strReceiverYSingleVarType = "numeric" OrElse strReceiverYSingleVarType = "integer")) OrElse (strReceiverYMultipleVarType = "numeric" OrElse strReceiverYMultipleVarType = "integer") Then
        '        ucrChkLineofBestFit.Enabled = True
        '    End If
        'Else
        '    ucrChkLineofBestFit.Enabled = False
        '    clsBaseOperator.RemoveParameterByName("geom_smooth")
        'End If
    End Sub

    Private Sub ucrVariablesAsFactorForScatter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForScatter.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        ' CheckIfNumeric()
    End Sub

    Private Sub ucrPnlType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlValueChanged, ucrChkAddPoints.ControlValueChanged, ucrChkHorizontal.ControlValueChanged, ucrPnlPlotType.ControlValueChanged
        If rdoSegments.Checked Then
            cmdScatterPlotOptions.Visible = False
            cmdOptions.Visible = False
            ucrReceiverXStart.SetMeAsReceiver()
            grpLollipopType.Visible = True
            If rdoDiagonal.Checked Then
                ucrChkHorizontal.Visible = False
            Else
                ucrChkHorizontal.Visible = True
            End If
            If Not ucrSaveScatterPlot.bUserTyped Then
                ucrSaveScatterPlot.SetPrefix("lollipop")
            End If
            If Not ucrChkAddPoints.Checked Then
                If Not ucrChkHorizontal.Checked Then
                    clsBaseOperator.RemoveParameterByName("third_plus")
                    clsBaseOperator.AddParameter("segment", clsRFunctionParameter:=clsSegmentggplotFunction, iPosition:=1)
                Else
                    clsBaseOperator.RemoveParameterByName("segment")
                    clsBaseOperator.AddParameter("third_plus", clsROperatorParameter:=clsThirdPlusOperator, iPosition:=1)

                    clsThirdPlusOperator.RemoveParameterByName("first_point")
                    clsThirdPlusOperator.RemoveParameterByName("second_point")
                    clsThirdPlusOperator.AddParameter("segment", clsRFunctionParameter:=clsSegmentggplotFunction, iPosition:=0)
                    clsThirdPlusOperator.AddParameter("coord_flip", clsRFunctionParameter:=clsFlipCoordinateFunction, iPosition:=1)
                End If
                clsBaseOperator.RemoveParameterByName("first_plus")
            Else
                If rdoSimple.Checked Then
                    clsFirstPlusOperator.RemoveParameterByName("second_plus")
                    If Not ucrChkHorizontal.Checked Then
                        clsFirstPlusOperator.RemoveParameterByName("third_plus")
                        clsFirstPlusOperator.AddParameter("first_point", clsRFunctionParameter:=clsFirstggPointFunction, iPosition:=1)
                    Else
                        clsFirstPlusOperator.RemoveParameterByName("first_point")
                        clsFirstPlusOperator.AddParameter("third_plus", clsROperatorParameter:=clsThirdPlusOperator, iPosition:=1)

                        clsThirdPlusOperator.RemoveParameterByName("segment")
                        clsThirdPlusOperator.RemoveParameterByName("second_point")
                        clsThirdPlusOperator.AddParameter("first_point", clsRFunctionParameter:=clsFirstggPointFunction, iPosition:=0)
                        clsThirdPlusOperator.AddParameter("coord_flip", clsRFunctionParameter:=clsFlipCoordinateFunction, iPosition:=1)
                    End If
                Else
                    clsFirstPlusOperator.RemoveParameterByName("first_point")
                    clsFirstPlusOperator.RemoveParameterByName("third_plus")
                    clsFirstPlusOperator.AddParameter("second_plus", clsROperatorParameter:=clsSecondPlusOperator, iPosition:=1)
                    clsSecondPlusOperator.AddParameter("first_point", clsRFunctionParameter:=clsFirstggPointFunction, iPosition:=0)
                    If rdoDouble.Checked Then
                        If Not ucrChkHorizontal.Checked Then
                            clsSecondPlusOperator.RemoveParameterByName("third_plus")
                            clsSecondPlusOperator.AddParameter("second_point", clsRFunctionParameter:=clsSecondggPointFunction, iPosition:=1)
                        Else
                            clsSecondPlusOperator.RemoveParameterByName("second_point")
                            clsSecondPlusOperator.AddParameter("third_plus", clsROperatorParameter:=clsThirdPlusOperator, iPosition:=1)

                            clsThirdPlusOperator.RemoveParameterByName("segment")
                            clsThirdPlusOperator.RemoveParameterByName("first_point")
                            clsThirdPlusOperator.AddParameter("second_point", clsRFunctionParameter:=clsSecondggPointFunction, iPosition:=0)
                            clsThirdPlusOperator.AddParameter("coord_flip", clsRFunctionParameter:=clsFlipCoordinateFunction, iPosition:=1)
                        End If
                    ElseIf rdoDiagonal.Checked Then
                        clsSecondPlusOperator.RemoveParameterByName("third_plus")
                        clsSecondPlusOperator.AddParameter("second_point", clsRFunctionParameter:=clsSecondggPointFunction, iPosition:=1)
                        clsSegmentggplotFunction.RemoveParameterByPosition(0)
                        clsSegmentggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsDiagonalaesFunction, bIncludeArgumentName:=False, iPosition:=1)
                        clsSecondPointaesFunction.RemoveParameter(ucrReceiverXStart.GetParameter())
                        ucrReceiverXEnd.AddAdditionalCodeParameterPair(clsSecondPointaesFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
                    End If
                End If
                clsBaseOperator.RemoveParameterByName("segment")
                clsBaseOperator.RemoveParameterByName("third_plus")
                clsBaseOperator.AddParameter("first_plus", clsROperatorParameter:=clsFirstPlusOperator, iPosition:=1)
                clsFirstPlusOperator.AddParameter("segment", clsRFunctionParameter:=clsSegmentggplotFunction, iPosition:=0)
            End If
            clsRggplotFunction.RemoveParameterByName("mapping")
            clsBaseOperator.RemoveParameterByName(strFirstParameterName)
        Else
            grpLollipopType.Visible = False
            cmdScatterPlotOptions.Visible = True
            cmdOptions.Visible = True
            If Not ucrSaveScatterPlot.bUserTyped Then
                ucrSaveScatterPlot.SetPrefix("point_plot")
            End If
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)
            clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
            clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRScatterGeomFunction, iPosition:=1)
            clsBaseOperator.RemoveParameterByName("segment")
            clsBaseOperator.RemoveParameterByName("third_plus")
            clsBaseOperator.RemoveParameterByName("first_plus")
        End If
    End Sub
End Class
