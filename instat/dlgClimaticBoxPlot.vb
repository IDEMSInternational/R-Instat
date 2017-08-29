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
Public Class dlgClimaticBoxPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsFacetFunction As New RFunction
    Private clsFacetOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)

        ucrSelectorClimaticBoxPlot.SetRCode(clsRggplotFunction, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrVariablesAsFactorForClimaticBoxplot.SetRCode(clsRaesFunction, bReset)

        ucrReceiverYear.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForClimaticBoxplot.SetRCode(clsRaesFunction, bReset)


        'ucrChkFacet.SetRCode(clsBaseOperator, bReset)
        'ucrChk2ndFacet.SetRCode(clsBaseOperator, bReset)
        ucrReceiverFacet.SetRCode(clsFacetOp, bReset)
        ucrReceiver2ndFacet.SetRCode(clsFacetOp, bReset)
        ucrChkMargins.SetRCode(clsFacetFunction, bReset)

    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        'ucrBase.iHelpTopicID = ""
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplot)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlLayoutOptions.AddRadioButton(rdoDataThenYear)
        ucrPnlLayoutOptions.AddRadioButton(rdoYearThenData)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplot, "geom_boxplot")
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls(ucrChkVarWidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorClimaticBoxPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorClimaticBoxPlot.SetParameterIsrfunction()

        ucrVariablesAsFactorForClimaticBoxplot.Selector = ucrSelectorClimaticBoxPlot
        ucrVariablesAsFactorForClimaticBoxplot.SetParameter(New RParameter("y", 0))
        ucrVariablesAsFactorForClimaticBoxplot.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorForClimaticBoxplot.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorForClimaticBoxplot.SetParameterIsString()
        ucrVariablesAsFactorForClimaticBoxplot.bWithQuotes = False

        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.SetParameter(New RParameter("x", 1))
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.bWithQuotes = False

        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetParameter(New RParameter(""))
        ucrReceiverWithinYear.bAutoFill = True
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False

        ucrReceiverFacet.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverFacet.SetParameter(New RParameter("var1", 0))
        ucrReceiverFacet.bAutoFill = True
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.bWithQuotes = False

        ucrReceiver2ndFacet.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiver2ndFacet.SetParameter(New RParameter("var2", 1))
        ucrReceiver2ndFacet.bAutoFill = True
        ucrReceiver2ndFacet.SetParameterIsString()
        ucrReceiver2ndFacet.bWithQuotes = False

        ucrChkVarWidth.SetParameter(New RParameter("varwidth"))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkMargins.SetText("Margins")
        ucrChkMargins.SetParameter(New RParameter("margins"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkMargins.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMargins.SetRDefault("FALSE")

        ucrSavePlot.SetPrefix("boxplot")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsFacetFunction = New RFunction
        clsFacetOp = New ROperator

        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        ucrVariablesAsFactorForClimaticBoxplot.SetMeAsReceiver()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.RemoveParameterByName("facets")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_boxplot")
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrVariablesAsFactorForClimaticBoxplot.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsFacetFunction, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bReset:=bResetSubdialog)
        'this is a temporaly fix because we have facets done on the main dialog
        sdgPlots.tbpFacet.Enabled = False
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        If rdoBoxplot.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_boxplot")
            ucrSavePlot.SetPrefix("boxplot")
            cmdBoxPlotOptions.Text = "Boxplot Options"
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            ucrSavePlot.SetPrefix("jitter")
            cmdBoxPlotOptions.Text = "Jitter Options"
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            ucrSavePlot.SetPrefix("violin")
            cmdBoxPlotOptions.Text = "Violin Options"
        End If
    End Sub

    Private Sub ucrSavePlot_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrVariablesAsFactorForClimaticBoxplot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub SetFacets()
        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetOp.SetOperation("~")
        'If ucrChkFacet.Checked Then
        '    If (Not ucrReceiverFacet.IsEmpty) AndAlso Not ucrChk2ndFacet.Checked Then
        '        clsFacetFunction.SetRCommand("facet_wrap")
        '    ElseIf (Not ucrReceiverFacet.IsEmpty) AndAlso (ucrChk2ndFacet.Checked AndAlso Not ucrReceiver2ndFacet.IsEmpty) Then
        '        clsFacetFunction.SetRCommand("facet_grid")
        '    End If
        '    clsFacetFunction.AddParameter(clsROperatorParameter:=clsFacetOp)
        'End If
    End Sub

    Private Sub FacetControls_ControlvalueChanged(ucrChangedControl As ucrCore)
        'If ucrChangedControl.Equals(ucrChkFacet) AndAlso ucrChkFacet.Checked Then
        '    ucrReceiverFacet.SetMeAsReceiver()
        'ElseIf ucrChangedControl.Equals(ucrChk2ndFacet) AndAlso ucrChk2ndFacet.Checked Then
        '    ucrReceiver2ndFacet.SetMeAsReceiver()
        'End If
        'SetFacets()
        'AddRemoveFacets()
    End Sub

    Private Sub AddRemoveFacets()
        'If ucrChkFacet.Checked AndAlso Not ucrReceiverFacet.IsEmpty Then
        '    clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        'Else
        '    clsBaseOperator.RemoveParameterByName("facets")
        'End If
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrReceiverYear.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                'ucrReceiverData.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                'ucrReceiverMoreData.Add(clsParam.strArgumentValue)
            End If
        Next
        'TODO need to check for the variable width from the geom function in a way that when we check the var width checkbox, it triggers controlvaluechanged
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged

    End Sub
End Class