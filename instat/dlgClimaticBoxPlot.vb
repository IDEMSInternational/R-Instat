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
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsFacetFunction As New RFunction
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
        ucrChkMargins.SetRCode(clsRgeomPlotFunction, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)

        ucrReceiverData.SetRCode(clsRaesFunction, bReset)
        ucrReceiverYear.SetRCode(clsRaesFunction, bReset)
        ucrChkMoreData.SetRCode(clsRaesFunction, bReset)
        ucrReceiverMoreData.SetRCode(clsRaesFunction, bReset)
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

        ucrReceiverStation.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetMeAsReceiver()

        ucrReceiverDate.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverYear.SetParameter(New RParameter("x", 1))
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.bWithQuotes = False

        ucrReceiverWithinYear.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverWithinYear.SetParameter(New RParameter(""))
        ucrReceiverWithinYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverWithinYear.bAutoFill = True
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False

        ucrReceiverData.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverData.SetParameter(New RParameter("y"))
        ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverData.bAutoFill = True
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False

        ucrReceiverFacet.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverFacet.SetParameter(New RParameter(""))
        ucrReceiverFacet.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverFacet.bAutoFill = True
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.bWithQuotes = False

        ucrReceiver2ndFacet.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiver2ndFacet.SetParameter(New RParameter(""))
        ucrReceiver2ndFacet.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
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

        ucrChkMoreData.SetText("More Data")
        ucrChkMoreData.AddParameterPresentCondition(True, "fill", True)
        ucrChkMoreData.AddParameterPresentCondition(False, "fill", False)
        ucrChkMoreData.AddToLinkedControls(ucrReceiverMoreData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMoreData.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverMoreData.SetParameter(New RParameter("fill"))
        ucrReceiverMoreData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "" & Chr(34)})
        ucrReceiverMoreData.SetParameterIsString()
        ucrReceiverMoreData.bWithQuotes = False

        ucrChkFacet.SetText("Facet")
        ucrChkFacet.AddToLinkedControls(ucrReceiverFacet, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChk2ndFacet.SetText("2nd Facet")
        ucrChk2ndFacet.AddToLinkedControls(ucrReceiver2ndFacet, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

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

        ucrSelectorClimaticBoxPlot.Reset()
        ucrSavePlot.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True
        bResetBoxLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
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
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverData.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrSavePlot.IsComplete Then
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
        sdgPlots.SetRCode(clsBaseOperator, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, clsNewXScalecontinuousFunction:=clsXScaleContinuousFunction, clsNewYScalecontinuousFunction:=clsYScaleContinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bReset:=bResetSubdialog)
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

    Private Sub ucrSavePlot_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrSavePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged

    End Sub
End Class