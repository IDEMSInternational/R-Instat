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

Public Class dlgGeneralForGraphics
    Public clsGgplotFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstLayerComplete As New List(Of Boolean)
    'list of completed layers.
    Private iLayerIndex As Integer
    'current layer
    Private clsGlobalAesFunction, clsScaleContinuousFunction, clsLevelsFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private strGlobalDataFrame As String
    Public bDataFrameSet As Boolean
    Private bResetOptionsSubdialog As Boolean = True

    'RFunctions for Options sub dialog
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private clsYlabsFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsFacetsFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsYScaleDiscreteFunction As New RFunction
    Private clsXScaleDiscreteFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private clsGroupByFunction As New RFunction
    Private clsAddCodeOperator As New ROperator
    Private bRCodeSet As Boolean = False

    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"

    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False
    Private strPackageName As String

    Private Sub dlgGeneralForGraphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 420
        'By default, we want to put in the script the output of our Base R-command (in this case the ...+...+...) even when it has been assigned to some object (in which case we want the name of that object in the script so that it's called when the script is run).
        'For example, when a graph is saved, it is assigned to it's place in an R-instat object. If we had set bExcludeAssignedFunctionOutput to True, then we would never print the graph when running the script.
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'iCalltype 3 corresponds to single graphics display in output window.
        ucrBase.clsRsyntax.iCallType = 3

        ucrGraphicsSelector.SetParameter(New RParameter("data", 0))
        ucrGraphicsSelector.SetParameterIsrfunction()

        ucrReceiverX.Selector = ucrGraphicsSelector
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrChkUseasNumeric.SetText("Group X")
        ucrChkUseasNumeric.AddParameterValuesCondition(True, "group", "True")
        ucrChkUseasNumeric.AddParameterValuesCondition(False, "group", "False")

        ucrReceiverY.Selector = ucrGraphicsSelector
        ucrReceiverY.strSelectorHeading = "Variables"
        ucrReceiverY.bWithQuotes = False
        ucrReceiverY.SetParameterIsString()
        ucrReceiverY.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverY.bAddParameterIfEmpty = True

        ucrFillReceiver.SetParameter(New RParameter("fill", 3))
        ucrFillReceiver.Selector = ucrGraphicsSelector
        ucrFillReceiver.strSelectorHeading = "Variables"
        ucrFillReceiver.bWithQuotes = False
        ucrFillReceiver.SetParameterIsString()

        ucrColourReceiver.SetParameter(New RParameter("colour", 4))
        ucrColourReceiver.Selector = ucrGraphicsSelector
        ucrColourReceiver.strSelectorHeading = "Variables"
        ucrColourReceiver.bWithQuotes = False
        ucrColourReceiver.SetParameterIsString()

        ucrLabelReceiver.SetParameter(New RParameter("label", 5))
        ucrLabelReceiver.Selector = ucrGraphicsSelector
        ucrLabelReceiver.SetIncludedDataTypes({"factor"})
        ucrLabelReceiver.strSelectorHeading = "Factors"
        ucrLabelReceiver.bWithQuotes = False
        ucrLabelReceiver.SetParameterIsString()

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

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

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrGraphicsSelector
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})
        ucr1stFactorReceiver.SetParameterPosition(1)

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrChkAddCode.SetText("Add Code:")
        ucrChkAddCode.AddToLinkedControls({ucrInputAddCode}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputAddCode.SetItems({"scale_colour_manual(values=c(" & Chr(34) & "red" & Chr(34) & "," & Chr(34) & "blue" & Chr(34) & "," & Chr(34) & "green" & Chr(34) & "," & Chr(34) & "black" & Chr(34) & "," & Chr(34) & "brown" & Chr(34) & "))", "scale_fill_manual(values = c(" & Chr(34) & "coral" & Chr(34) & "," & Chr(34) & "bisque4" & Chr(34) & "," & Chr(34) & "gold" & Chr(34) & "," & Chr(34) & "cyan" & Chr(34) & "," & Chr(34) & "khaki" & Chr(34) & "," & Chr(34) & "orange" & Chr(34) & "," & Chr(34) & "orchid" & Chr(34) & "))", "geom_hline(yintercept=20)", "geom_vline(xintercept=5) + geom_hline(yintercept = 1)", "geom_vline(xintercept=c(1,3,5),colour=" & Chr(34) & "green" & Chr(34) & ")", "scale_x_binned()", "scale_x_binned(n.breaks=20)", "scale_y_continuous(trans=" & Chr(34) & "log10" & Chr(34) & ", label=scales::dollar)"})

        ucrSave.SetPrefix("graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save")
        ucrSave.SetDataFrameSelector(ucrGraphicsSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
        VariableXType()
    End Sub

    Private Sub SetDefaults()
        clsGgplotFunction = New RFunction
        clsGlobalAesFunction = New RFunction
        clsBaseOperator = New ROperator
        clsDummyFunction = New RFunction
        clsScaleContinuousFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsAddCodeOperator = New ROperator

        ucrSave.Reset()

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True
        ucrGraphicsSelector.Reset()
        ucrGraphicsSelector.SetGgplotFunction(clsBaseOperator)
        ucrReceiverY.SetMeAsReceiver()
        bDataFrameSet = False
        bResetOptionsSubdialog = True
        bResetSubdialog = True

        clsDummyFunction.AddParameter("group", "false", iPosition:=0)
        clsDummyFunction.AddParameter("group", "false", iPosition:=1)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGlobalAesFunction, iPosition:=1)

        clsGlobalAesFunction.SetPackageName("ggplot2")
        clsGlobalAesFunction.SetRCommand("aes")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsLevelsFunction.SetPackageName("base")
        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("y", ucrReceiverX.GetVariableNames(False), bIncludeArgumentName:=False, iPosition:=0)

        clsScaleContinuousFunction.SetPackageName("ggplot2")
        clsScaleContinuousFunction.SetRCommand("scale_x_continuous")
        clsScaleContinuousFunction.AddParameter("breaks", "1:12", iPosition:=1)
        clsScaleContinuousFunction.AddParameter("labels", clsRFunctionParameter:=clsLevelsFunction, iPosition:=2)

        clsAddCodeOperator.SetOperation("", bBracketsTemp:=False)

        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsFacetsFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        clsBaseOperator.bExcludeAssignedFunctionOutput = False

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ucrAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=clsBaseOperator, clsRNewggplotFunc:=clsGgplotFunction, clsNewAesFunc:=clsGlobalAesFunction, strNewGlobalDataFrame:=ucrGraphicsSelector.strCurrentDataFrame, bReset:=True)

        sdgPlots.Reset()
        'Warning/to be discussed: sdgPlots doesn't work like sdgLayerOptions. Information actually stays on the dialogue, as it cannot be editted on the general for graphics (yet) I think that sdgPlots should work like LayerOptions and be filled in at load, thanks to a setup function and setsettings sub. 
        TestOKEnabled()
    End Sub

    Private Sub SetCalculationHistory()
        Dim newItem As String = ucrInputAddCode.GetText().Trim()

        If Not String.IsNullOrEmpty(newItem) AndAlso Not ucrInputAddCode.cboInput.Items.Contains(newItem) Then
            ucrInputAddCode.AddItems({newItem})
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsLevelsFunction, New RParameter("y", ucrReceiverX.GetVariableNames(False), bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrGraphicsSelector.SetRCode(clsGgplotFunction, bReset)
        ucrReceiverY.SetRCode(clsGlobalAesFunction, bReset)
        ucrReceiverX.SetRCode(clsGlobalAesFunction, bReset)
        If bReset Then
            ucrChkUseasNumeric.SetRCode(clsDummyFunction, bReset)
            ucrChkAddCode.SetRCode(clsAddCodeOperator, bReset)
            ucrInputAddCode.SetRCode(clsAddCodeOperator, bReset)
        End If
        ucrFillReceiver.SetRCode(clsGlobalAesFunction, bReset)
        ucrColourReceiver.SetRCode(clsGlobalAesFunction, bReset)
        ucrLabelReceiver.SetRCode(clsGlobalAesFunction, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrSave.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrSave.IsComplete OrElse (ucrReceiverX.IsEmpty AndAlso ucrReceiverY.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        ucrAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewAesFunc:=clsGlobalAesFunction, bReset:=True)
        bResetSubdialog = False
    End Sub

    Private Sub ucrAdditionalLayers_NumberOfLayersChanged() Handles ucrAdditionalLayers.NumberOfLayersChanged, ucrAdditionalLayers.NumberOfLayersChanged
        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        'TestOKEnabled()
        VariableXType()
    End Sub

    Private Sub toolStripMenuItemFacets_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemFacets.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=ucrGraphicsSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetOptionsSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        sdgPlots.ShowDialog()
        sdgPlots.EnableLayersTab()
        bResetOptionsSubdialog = False
    End Sub

    Private Sub toolStripMenuItemLayers_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemLayers.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                        clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                        clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                        clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                        clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 1
        sdgPlots.ShowDialog()
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        sdgPlots.EnableLayersTab()
        ucrAdditionalLayers.SetRCodeForControl(clsNewBaseOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewAesFunc:=clsGlobalAesFunction, bReset:=True)
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemTitles_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemTitles.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 2
        sdgPlots.ShowDialog()
        sdgPlots.EnableLayersTab()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemXaxis_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemXaxis.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetOptionsSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 3
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub toolStripMenuItemYaxis_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemYaxis.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetOptionsSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 4
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub toolStripMenuItemThemes_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemThemes.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 5
        sdgPlots.ShowDialog()
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        sdgPlots.EnableLayersTab()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemCoordinates_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemCoordinates.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
        clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 6
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        sdgPlots.EnableLayersTab()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemColour_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemColour.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetOptionsSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 7
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub toolStripMenuItemAnnotation_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemAnnotation.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetOptionsSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 8
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub ucrReceiverY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverY.ControlValueChanged, ucrReceiverX.ControlValueChanged
        If Not ucrReceiverY.IsEmpty Then
            clsGlobalAesFunction.AddParameter("y", ucrReceiverY.GetVariableNames(False), iPosition:=1)
        Else
            clsGlobalAesFunction.RemoveParameterByName("y")
        End If
        If Not ucrFillReceiver.IsEmpty Then
            clsGlobalAesFunction.AddParameter("fill", ucrFillReceiver.GetVariableNames(False), iPosition:=2)
        Else
            clsGlobalAesFunction.RemoveParameterByName("fill")
        End If
        If Not ucrColourReceiver.IsEmpty Then
            clsGlobalAesFunction.AddParameter("colour", ucrColourReceiver.GetVariableNames(False), iPosition:=3)
        Else
            clsGlobalAesFunction.RemoveParameterByName("colour")
        End If
        If Not ucrLabelReceiver.IsEmpty Then
            clsGlobalAesFunction.AddParameter("label", ucrLabelReceiver.GetVariableNames(False), iPosition:=3)
        Else
            clsGlobalAesFunction.RemoveParameterByName("label")
        End If
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrReceiverY.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrInputLegendPosition.ControlContentsChanged, ucrChkLegend.ControlContentsChanged, ucrChkUseasNumeric.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub VariableXType()
        ucrChkUseasNumeric.Visible = False
        If Not ucrReceiverX.IsEmpty Then
            clsGlobalAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
            If ucrReceiverX.strCurrDataType = "factor" OrElse ucrReceiverX.strCurrDataType = "ordered,factor" Then
                ucrChkUseasNumeric.Visible = True
                If ucrChkUseasNumeric.Checked Then
                    clsGlobalAesFunction.AddParameter("group", "1", iPosition:=2)
                Else
                    clsGlobalAesFunction.RemoveParameterByName("group")
                End If
            Else
                ucrChkUseasNumeric.Visible = False
                clsGlobalAesFunction.RemoveParameterByName("group")
            End If
        Else
            clsGlobalAesFunction.RemoveParameterByName("group")
            clsGlobalAesFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub OpenHelpPage()
        If strPackageName <> "" Then
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName), bReplace:=False)
        End If
    End Sub

    Private Sub cmdRHelp_Click(sender As Object, e As EventArgs) Handles cmdRHelp.Click, ListBaseToolStripMenuItem.Click
        strPackageName = "ggplot2"
        OpenHelpPage()
    End Sub

    Private Sub GeomtextpathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeomtextpathToolStripMenuItem.Click
        strPackageName = "geomtextpath"
        OpenHelpPage()
    End Sub

    Private Sub GGallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GGallyToolStripMenuItem.Click
        strPackageName = "GGally"
        OpenHelpPage()
    End Sub

    Private Sub GgaltToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgaltToolStripMenuItem.Click
        strPackageName = "ggalt"
        OpenHelpPage()
    End Sub

    Private Sub GgdendroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgdendroToolStripMenuItem.Click
        strPackageName = "ggdendro"
        OpenHelpPage()
    End Sub

    Private Sub GgeffectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgeffectsToolStripMenuItem.Click
        strPackageName = "ggeffects"
        OpenHelpPage()
    End Sub

    Private Sub GgfittextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgfittextToolStripMenuItem.Click
        strPackageName = "ggfittext"
        OpenHelpPage()
    End Sub

    Private Sub GgforceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgforceToolStripMenuItem.Click
        strPackageName = "ggforce"
        OpenHelpPage()
    End Sub

    Private Sub GgformulaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgformulaToolStripMenuItem.Click
        strPackageName = "ggformula"
        OpenHelpPage()
    End Sub

    Private Sub GgfortifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgfortifyToolStripMenuItem.Click
        strPackageName = "ggfortify"
        OpenHelpPage()
    End Sub

    Private Sub GgmcmcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgmcmcToolStripMenuItem.Click
        strPackageName = "ggmcmc"
        OpenHelpPage()
    End Sub

    Private Sub GgmosaicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgmosaicToolStripMenuItem.Click
        strPackageName = "ggmosaic"
        OpenHelpPage()
    End Sub

    Private Sub GgplotifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgplotifyToolStripMenuItem.Click
        strPackageName = "ggplotify"
        OpenHelpPage()
    End Sub

    Private Sub GgpmiscToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgpmiscToolStripMenuItem.Click
        strPackageName = "ggpmisc"
        OpenHelpPage()
    End Sub

    Private Sub GgppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgppToolStripMenuItem.Click
        strPackageName = "ggpp"
        OpenHelpPage()
    End Sub

    Private Sub GgpubrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgpubrToolStripMenuItem.Click
        strPackageName = "ggpubr"
        OpenHelpPage()
    End Sub

    Private Sub GgrepelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgrepelToolStripMenuItem.Click
        strPackageName = "ggrepel"
        OpenHelpPage()
    End Sub

    Private Sub GgridgesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgridgesToolStripMenuItem.Click
        strPackageName = "ggridges"
        OpenHelpPage()
    End Sub

    Private Sub GgsciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgsciToolStripMenuItem.Click
        strPackageName = "ggsci"
        OpenHelpPage()
    End Sub

    Private Sub GgsignifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgsignifToolStripMenuItem.Click
        strPackageName = "ggsignif"
        OpenHelpPage()
    End Sub

    Private Sub GgstanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgstanceToolStripMenuItem.Click
        strPackageName = "ggstance"
        OpenHelpPage()
    End Sub

    Private Sub GgtextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgtextToolStripMenuItem.Click
        strPackageName = "ggtext"
        OpenHelpPage()
    End Sub

    Private Sub GgthemesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgthemesToolStripMenuItem.Click
        strPackageName = "ggthemes"
        OpenHelpPage()
    End Sub

    Private Sub GgwordbuildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GgwordbuildToolStripMenuItem.Click
        strPackageName = "ggwordbluid"
        OpenHelpPage()
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged, ucrChkUseasNumeric.ControlValueChanged
        VariableXType()
    End Sub

    Private Sub AutoFacetStation()
        Dim ucrCurrentReceiver As ucrReceiver = Nothing

        If ucrGraphicsSelector.CurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver = ucrGraphicsSelector.CurrentReceiver
        End If
        ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrGraphicsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
        AddRemoveGroupBy()
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso
                    Not ucrInputStation.Equals(ucrChangedControl) AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso ucrInputStation.GetText = strFacetRow) OrElse (strChangedText = strFacetRow AndAlso
                    ucrInputStation.GetText = strFacetWrap) OrElse (strChangedText = strFacetWrap AndAlso
                    ucrInputStation.GetText = strFacetCol) OrElse (strChangedText = strFacetCol AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        If Not clsGlobalAesFunction.ContainsParameter("x") Then
            clsGlobalAesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged, ucrReceiverX.ControlValueChanged
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub
    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetVariablesOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If

            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrGraphicsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrGraphicsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrGraphicsSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrGraphicsSelector.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub ucrChkAddCode_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddCode.ControlValueChanged, ucrInputAddCode.ControlValueChanged
        SetCalculationHistory()
        If ucrChkAddCode.Checked AndAlso Not ucrInputAddCode.IsEmpty Then
            clsAddCodeOperator.AddParameter("code1", ucrInputAddCode.GetText(), bIncludeArgumentName:=False, iPosition:=1)
            clsBaseOperator.AddParameter("newcode", clsROperatorParameter:=clsAddCodeOperator, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("newcode")
        End If
    End Sub
End Class