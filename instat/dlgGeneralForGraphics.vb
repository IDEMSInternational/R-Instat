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
    Private clsDummyFunction As New RFunction
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
        ucrFillReceiver.SetIncludedDataTypes({"factor"})
        ucrFillReceiver.strSelectorHeading = "Factors"
        ucrFillReceiver.bWithQuotes = False
        ucrFillReceiver.SetParameterIsString()

        ucrColourReceiver.SetParameter(New RParameter("colour", 4))
        ucrColourReceiver.Selector = ucrGraphicsSelector
        ucrColourReceiver.SetIncludedDataTypes({"factor"})
        ucrColourReceiver.strSelectorHeading = "Factors"
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

        ucrSave.Reset()

        ucrGraphicsSelector.Reset()
        ucrGraphicsSelector.SetGgplotFunction(clsBaseOperator)
        ucrReceiverY.SetMeAsReceiver()
        bDataFrameSet = False
        bResetOptionsSubdialog = True

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

        clsLevelsFunction.SetPackageName("base")
        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("y", ucrReceiverX.GetVariableNames(False), bIncludeArgumentName:=False, iPosition:=0)

        clsScaleContinuousFunction.SetPackageName("ggplot2")
        clsScaleContinuousFunction.SetRCommand("scale_x_continuous")
        clsScaleContinuousFunction.AddParameter("breaks", "1:12", iPosition:=1)
        clsScaleContinuousFunction.AddParameter("labels", clsRFunctionParameter:=clsLevelsFunction, iPosition:=2)

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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverX.AddAdditionalCodeParameterPair(clsLevelsFunction, New RParameter("y", ucrReceiverX.GetVariableNames(False), bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrGraphicsSelector.SetRCode(clsGgplotFunction, bReset)
        ucrReceiverY.SetRCode(clsGlobalAesFunction, bReset)
        ucrReceiverX.SetRCode(clsGlobalAesFunction, bReset)
        If bReset Then
            ucrChkUseasNumeric.SetRCode(clsDummyFunction, bReset)
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewGlobalAesFunction:=clsGlobalAesFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub ucrAdditionalLayers_NumberOfLayersChanged() Handles ucrAdditionalLayers.NumberOfLayersChanged
        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        'TestOKEnabled()
        VariableXType()
    End Sub

    Private Sub cmdFacets_Click(sender As Object, e As EventArgs) Handles cmdFacets.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub cmdTheme_Click(sender As Object, e As EventArgs) Handles cmdTheme.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 5
        sdgPlots.ShowDialog()
        sdgPlots.tbpPlotsOptions.SelectedIndex = 0
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub cmdTitles_Click(sender As Object, e As EventArgs) Handles cmdTitles.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 2
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub cmdXAxis_Click(sender As Object, e As EventArgs) Handles cmdXAxis.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 3
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub cmdYAxis_Click(sender As Object, e As EventArgs) Handles cmdYAxis.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.tbpPlotsOptions.SelectedIndex = 4
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
            ucrChkUseasNumeric.Visible = ucrReceiverX.strCurrDataType = "factor"
            If ucrChkUseasNumeric.Checked Then
                clsGlobalAesFunction.AddParameter("group", "1", iPosition:=2)
            Else
                clsGlobalAesFunction.RemoveParameterByName("group")
            End If
        Else
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
End Class