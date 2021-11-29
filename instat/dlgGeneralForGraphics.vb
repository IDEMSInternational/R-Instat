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
    Public clsGgplotFunction As RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstLayerComplete As New List(Of Boolean)
    'list of completed layers.
    Private iLayerIndex As Integer
    'current layer
    Private clsGlobalAesFunction As New RFunction
    Private clsBaseOperator As ROperator
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
        ucrBase.iHelpTopicID = 420
        'By default, we want to put in the script the output of our Base R-command (in this case the ...+...+...) even when it has been assigned to some object (in which case we want the name of that object in the script so that it's called when the script is run).
        'For example, when a graph is saved, it is assigned to it's place in an R-instat object. If we had set bExcludeAssignedFunctionOutput to True, then we would never print the graph when running the script.
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'iCalltype 3 corresponds to single graphics display in output window.
        ucrBase.clsRsyntax.iCallType = 3

        ucrGraphicsSelector.SetParameter(New RParameter("data", 0))
        ucrGraphicsSelector.SetParameterIsrfunction()

        ucrVariablesAsFactorForGraphics.SetFactorReceiver(ucrFillOrColourReceiver)
        ucrVariablesAsFactorForGraphics.Selector = ucrGraphicsSelector
        ucrVariablesAsFactorForGraphics.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForGraphics.SetParameterIsString()
        ucrVariablesAsFactorForGraphics.bWithQuotes = False
        ucrVariablesAsFactorForGraphics.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrVariablesAsFactorForGraphics.bAddParameterIfEmpty = True

        ucrReceiverX.Selector = ucrGraphicsSelector
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverX.bAddParameterIfEmpty = True

        ucrFillOrColourReceiver.Selector = ucrGraphicsSelector
        ucrFillOrColourReceiver.SetIncludedDataTypes({"factor"})
        ucrFillOrColourReceiver.strSelectorHeading = "Factors"
        ucrFillOrColourReceiver.bWithQuotes = False
        ucrFillOrColourReceiver.SetParameterIsString()

        ucrSave.SetPrefix("graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrGraphicsSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsGgplotFunction = New RFunction
        clsGlobalAesFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrSave.Reset()

        ucrGraphicsSelector.Reset()
        ucrGraphicsSelector.SetGgplotFunction(clsBaseOperator)
        ucrVariablesAsFactorForGraphics.SetMeAsReceiver()
        bDataFrameSet = False
        bResetOptionsSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGlobalAesFunction, iPosition:=1)

        clsGlobalAesFunction.SetPackageName("ggplot2")
        clsGlobalAesFunction.SetRCommand("aes")

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
        ucrGraphicsSelector.SetRCode(clsGgplotFunction, bReset)
        ucrVariablesAsFactorForGraphics.SetRCode(clsGlobalAesFunction, bReset)
        ucrReceiverX.SetRCode(clsGlobalAesFunction, bReset)
        ucrFillOrColourReceiver.SetRCode(clsGlobalAesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrSave.IsComplete OrElse (ucrReceiverX.IsEmpty AndAlso ucrVariablesAsFactorForGraphics.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.DisableLayersTab()
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction,
                          clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewLabsFunction:=clsLabsFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabsFunction,
                          clsNewFacetFunction:=clsFacetsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction,
                          clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, ucrNewBaseSelector:=sdgLayerOptions.ucrGeomWithAes.ucrGeomWithAesSelector, clsNewAnnotateFunction:=clsAnnotateFunction,
                          clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetOptionsSubdialog = False
        sdgPlots.EnableLayersTab()
    End Sub

    Private Sub ucrAdditionalLayers_NumberOfLayersChanged() Handles ucrAdditionalLayers.NumberOfLayersChanged
        'When the number of Layers in the lstLayers on ucrAdditionalLayers need to check if OK is enabled on dlgGeneralForGraphics.
        'TestOKEnabled()
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

    Private Sub ucrVariablesAsFactorForGraphics_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForGraphics.ControlValueChanged, ucrReceiverX.ControlValueChanged, ucrFillOrColourReceiver.ControlValueChanged
        If Not ucrReceiverX.IsEmpty Then
            clsGlobalAesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False), iPosition:=0)
        Else
            clsGlobalAesFunction.RemoveParameterByName("x")
        End If
        If Not ucrVariablesAsFactorForGraphics.IsEmpty Then
            clsGlobalAesFunction.AddParameter("y", ucrVariablesAsFactorForGraphics.GetVariableNames(False), iPosition:=1)
        Else
            clsGlobalAesFunction.RemoveParameterByName("y")
        End If
        If Not ucrFillOrColourReceiver.IsEmpty Then
            clsGlobalAesFunction.AddParameter("colour", ucrFillOrColourReceiver.GetVariableNames(False), iPosition:=2)
        Else
            clsGlobalAesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub AllControl_ControlContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrVariablesAsFactorForGraphics.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class