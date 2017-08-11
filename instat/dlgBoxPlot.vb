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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    'clsRggplotFunction is the global ggplot function, will be used as RFunction of the first RParameter of ucrBase.clsRSyntax (which has "+" as main command). It is emphasised as a public field as it is used/editted in the sdgLayerOptions. The link is operated via SetupLayer that sets sdgLayerOptions.clsGgplotFunction = dlgBoxPlot.clsRggplotFunction.
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    'Similarly clsRgeom_boxplotFunction and clsRaesFunction (respectively the geom_boxplot function and the global aes function) are given through SetupLayer to sdgLayerOptions for edit. 
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScaleContinuousFunction As New RFunction
    Private clsYScaleContinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True

    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            'SetGeomprefixFillColourAes()
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
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 436
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPlots.AddRadioButton(rdoViolin)
        ucrPnlPlots.AddRadioButton(rdoBoxplot)
        ucrPnlPlots.AddRadioButton(rdoJitter)

        ucrPnlPlots.AddFunctionNamesCondition(rdoBoxplot, "geom_boxplot")
        ucrPnlPlots.AddFunctionNamesCondition(rdoJitter, "geom_jitter")
        ucrPnlPlots.AddFunctionNamesCondition(rdoViolin, "geom_violin")
        ucrPnlPlots.AddToLinkedControls(ucrChkVarWidth, {rdoBoxplot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorBoxPlot.SetParameter(New RParameter("data", 0))
        ucrSelectorBoxPlot.SetParameterIsrfunction()

        ucrVariablesAsFactorForBoxplot.SetParameter(New RParameter("y", 0))
        ucrVariablesAsFactorForBoxplot.SetFactorReceiver(ucrByFactorsReceiver)
        ucrVariablesAsFactorForBoxplot.Selector = ucrSelectorBoxPlot
        ucrVariablesAsFactorForBoxplot.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorForBoxplot.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorForBoxplot.SetParameterIsString()
        ucrVariablesAsFactorForBoxplot.bWithQuotes = False

        ucrByFactorsReceiver.SetParameter(New RParameter("x", 1))
        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor"})
        ucrByFactorsReceiver.strSelectorHeading = "Factors"
        ucrByFactorsReceiver.SetParameterIsString()
        ucrByFactorsReceiver.bWithQuotes = False
        ucrByFactorsReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrByFactorsReceiver.bAddParameterIfEmpty = True

        ucrSecondFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.strSelectorHeading = "Factors"
        ucrSecondFactorReceiver.SetParameterIsString()
        ucrSecondFactorReceiver.bWithQuotes = False

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 1))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSaveBoxplot.SetPrefix("boxplot")
        ucrSaveBoxplot.SetIsComboBox()
        ucrSaveBoxplot.SetCheckBoxText("Save Graph")
        ucrSaveBoxplot.SetSaveTypeAsGraph()
        ucrSaveBoxplot.SetDataFrameSelector(ucrSelectorBoxPlot.ucrAvailableDataFrames)
        ucrSaveBoxplot.SetAssignToIfUncheckedValue("last_graph")

        '  sdgPlots.SetGgplotFunction(clsRggplotFunction)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction

        ucrSelectorBoxPlot.Reset()
        ucrSaveBoxplot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True
        'rdoBoxplot.Checked = True
        'These chk boxes add features to the BoxPlot when ticked. See SetCorrdFlip and chkVarwidth_CheckedChanged. By default they are unticked.
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_boxplot")
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrSelectorBoxPlot.SetRCode(clsRggplotFunction, bReset)

        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        'passes in +cordflip
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrVariablesAsFactorForBoxplot.SetRCode(clsRaesFunction, bReset)
        ucrByFactorsReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorForBoxplot.IsEmpty OrElse Not ucrSaveBoxplot.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorBoxPlot, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        'SetupLayer sends the components storing the plot info (clsRgeom_boxplotFunction, clsRggplotFunction, ...) of dlgBoxPlot through to sdgLayerOptions where these will be edited.
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRgeom_boxplot and others has been modified. One then needs to display these modifications on the dlgBoxPlot.
        If clsRgeomPlotFunction.GetParameter("varwidth") IsNot Nothing Then
            If clsRgeomPlotFunction.GetParameter("varwidth").strArgumentValue = "TRUE" Then
                ' chkVarwidth.Checked = True
                'Observe that changing the check of the chkVarwidth here doesn't trigger the checkchanged event.
            End If
        Else
            'chkVarwidth.Checked = False
        End If

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrByFactorsReceiver.Clear()
                Else
                    ucrByFactorsReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForBoxplot.bSingleVariable) Then
                ucrVariablesAsFactorForBoxplot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        'Question to be discussed: After running through the sdgLayerOptions, the clsCurrDataFrame parameters seem to have been cleared, such that in the multiple variable case, clsCurrDataFrame needs to be repopulated with "stack", "measure.vars" and "id.vars" parameters. Actually, even when repopulated, they are still not appearing in the script. ??
        'This resets the factor receiver and causes it to be cleared of the correct variable. We don't want this.
        'ucrVariablesAsFactorForBoxplot.SetReceiverStatus()
    End Sub

    Private Sub SetGeomPrefixFillColourAes()
        'Sets geom function, fill and colour aesthetics and ucrsave prefix
        If rdoBoxplot.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_boxplot")
            ucrSaveBoxplot.SetPrefix("boxplot")
            ucrSecondFactorReceiver.ChangeParameterName("fill")
            cmdBoxPlotOptions.Text = "Boxplot Options"
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            ucrSaveBoxplot.SetPrefix("jitter")
            ucrSecondFactorReceiver.ChangeParameterName("colour")
            cmdBoxPlotOptions.Text = "Jitter Options"
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            ucrSaveBoxplot.SetPrefix("violin")
            ucrSecondFactorReceiver.ChangeParameterName("fill")
            cmdBoxPlotOptions.Text = "Violin Options"
        End If
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForBoxplot.bSingleVariable Then
            cmdBoxPlotOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdBoxPlotOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub ucrVariablesAsFactorForBoxplot_ControlContentsChanged() Handles ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        SetGeomprefixFillColourAes()
    End Sub

    Private Sub ucrSaveBoxplot_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveBoxplot.ControlContentsChanged, ucrVariablesAsFactorForBoxplot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorBoxPlot_DataFrameChanged() Handles ucrSelectorBoxPlot.DataFrameChanged
        'TODO Should we clear all general options when the data frame changes? e.g. title, axes options etc.
        clsRggplotFunction.RemoveParameterByName("facets")
    End Sub
End Class