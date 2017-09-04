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
Public Class dlgClimaticBoxPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeUpdated As Boolean = False
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
    Private clsFacetWrapOp As New ROperator
    Private clsFacetGridOp As New ROperator
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetBoxLayerSubdialog As Boolean = True
    Private clsAsFactor As New RFunction

    Private Sub dlgClimaticBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            AutoFill()
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsThemeFunc As New RFunction
        Dim clsTextElementFunc As New RFunction
        Dim clsThemeParam As New RParameter

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

        ucrVariablesAsFactorForClimaticBoxplot.SetParameter(New RParameter("y", 0))
        ucrVariablesAsFactorForClimaticBoxplot.Selector = ucrSelectorClimaticBoxPlot
        ucrVariablesAsFactorForClimaticBoxplot.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorForClimaticBoxplot.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorForClimaticBoxplot.SetParameterIsString()
        ucrVariablesAsFactorForClimaticBoxplot.bWithQuotes = False

        ucrReceiverXVariable.SetParameter(New RParameter("x", 1))
        ucrReceiverXVariable.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverXVariable.SetParameterIsString()
        ucrReceiverXVariable.bWithQuotes = False
        ucrReceiverXVariable.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrReceiverXVariable.bAddParameterIfEmpty = True

        ucrReceiverFacetBy.SetParameter(New RParameter("var1", 0))
        ucrReceiverFacetBy.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiverFacetBy.SetParameterIsString()
        ucrReceiverFacetBy.bWithQuotes = False

        ucrReceiver2ndFacet.SetParameter(New RParameter("var2", 1))
        ucrReceiver2ndFacet.Selector = ucrSelectorClimaticBoxPlot
        ucrReceiver2ndFacet.SetParameterIsString()
        ucrReceiver2ndFacet.bWithQuotes = False

        ucrChkVarWidth.SetParameter(New RParameter("varwidth", 0))
        ucrChkVarWidth.SetText("Variable Width")
        ucrChkVarWidth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkVarWidth.SetRDefault("FALSE")

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkHorizontalBoxplot.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHorizontalBoxplot.SetText("Horizontal Plot")

        ucrChkMargins.SetParameter(New RParameter("margins", 2))
        ucrChkMargins.SetText("Margins")
        ucrChkMargins.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMargins.SetRDefault("FALSE")

        clsThemeFunc.SetPackageName("ggplot2")
        clsThemeFunc.SetRCommand("theme")
        clsThemeFunc.AddParameter("axis.text.x", clsRFunctionParameter:=clsTextElementFunc)
        clsThemeParam.SetArgument(clsThemeFunc)
        clsThemeParam.SetArgumentName("theme")
        clsTextElementFunc.SetPackageName("ggplot2")
        clsTextElementFunc.SetRCommand("element_text")
        clsTextElementFunc.AddParameter("angle", "90", iPosition:=0)
        ucrChkVerticalXTickMarkers.SetText("Vertical X Tick Markers")
        ucrChkVerticalXTickMarkers.SetParameter(clsThemeParam, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=False)

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
        clsFacetWrapOp = New ROperator
        clsFacetGridOp = New ROperator
        clsAsFactor = New RFunction
        clsAsFactor.SetRCommand("as.factor")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetWrapOp.SetOperation("~")
        clsFacetWrapOp.bForceIncludeOperation = True
        clsFacetGridOp.SetOperation("~")
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
        clsRgeomPlotFunction.AddParameter("varwidth", "FALSE", iPosition:=0)

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

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeUpdated = False

        ucrReceiverFacetBy.AddAdditionalCodeParameterPair(clsFacetWrapOp, New RParameter("var1", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrSavePlot.SetRCode(clsBaseOperator, bReset)

        ucrSelectorClimaticBoxPlot.SetRCode(clsRggplotFunction, bReset)
        ucrChkHorizontalBoxplot.SetRCode(clsBaseOperator, bReset)
        ucrChkVerticalXTickMarkers.SetRCode(clsBaseOperator, bReset)

        ucrChkVarWidth.SetRCode(clsRgeomPlotFunction, bReset)
        ucrPnlPlots.SetRCode(clsRgeomPlotFunction, bReset)
        ucrVariablesAsFactorForClimaticBoxplot.SetRCode(clsRaesFunction, bReset)

        ucrReceiverXVariable.SetRCode(clsAsFactor, bReset)
        ucrVariablesAsFactorForClimaticBoxplot.SetRCode(clsRaesFunction, bReset)

        ucrReceiverFacetBy.SetRCode(clsFacetGridOp, bReset)
        ucrReceiver2ndFacet.SetRCode(clsFacetGridOp, bReset)
        ucrChkMargins.SetRCode(clsFacetFunction, bReset)

        bRCodeUpdated = True
        SecondFacetReceiverEnabled()
        MarginsEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrVariablesAsFactorForClimaticBoxplot.IsEmpty AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        AutoFill()
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
            cmdBoxPlotOptions.Text = "Boxplot Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("boxplot")
            End If
        ElseIf rdoJitter.Checked Then
            clsRgeomPlotFunction.SetRCommand("geom_jitter")
            cmdBoxPlotOptions.Text = "Jitter Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("jitter")
            End If
        Else
            clsRgeomPlotFunction.SetRCommand("geom_violin")
            cmdBoxPlotOptions.Text = "Violin Options"
            If Not ucrSavePlot.bUserTyped Then
                ucrSavePlot.SetPrefix("violin")
            End If
        End If
        SetColourFillAes()
    End Sub

    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSelectorClimaticBoxPlot, bApplyAesGlobally:=True, bReset:=bResetBoxLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBoxLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrReceiverXVariable.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                'ucrReceiverData.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                'ucrReceiverMoreData.Add(clsParam.strArgumentValue)
            End If
        Next
        'TODO need to check for the variable width from the geom function in a way that when we check the var width checkbox, it triggers controlvaluechanged
    End Sub

    Private Sub AutoFill()
        Dim strYearCol As String
        Dim strMonthCol As String
        Dim strStationCol As String
        Dim strDataFrame As String

        Dim strRainCol As String

        strDataFrame = ucrSelectorClimaticBoxPlot.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strYearCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "year_label")
        strMonthCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "month_label")
        strStationCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "station_label")
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

        If strRainCol <> "" Then
            ucrVariablesAsFactorForClimaticBoxplot.Add(strRainCol, strDataFrame)
        End If

        If strYearCol <> "" Then
            ucrReceiverXVariable.Add(strYearCol, strDataFrame)
            If strMonthCol <> "" Then
                ucrReceiverFacetBy.Add(strMonthCol, strDataFrame)
                If strStationCol <> "" Then
                    ucrReceiver2ndFacet.Add(strStationCol, strDataFrame)
                End If
            ElseIf strStationCol <> "" Then
                ucrReceiverFacetBy.Add(strStationCol, strDataFrame)
            End If
        ElseIf strMonthCol <> "" Then
            ucrReceiverXVariable.Add(strMonthCol, strDataFrame)
            If strStationCol <> "" Then
                ucrReceiverFacetBy.Add(strStationCol, strDataFrame)
            End If
        ElseIf strStationCol <> "" Then
            ucrReceiverXVariable.Add(strStationCol, strDataFrame)
        End If
    End Sub

    Private Sub AddRemoveFacets()
        If Not ucrReceiverFacetBy.IsEmpty Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction, iPosition:=3)
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If
    End Sub

    Private Sub SetFacets()
        If Not ucrReceiverFacetBy.IsEmpty AndAlso ucrReceiver2ndFacet.IsEmpty Then
            clsFacetFunction.SetRCommand("facet_wrap")
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetWrapOp, bIncludeArgumentName:=False, iPosition:=0)
        ElseIf Not ucrReceiverFacetBy.IsEmpty AndAlso Not ucrReceiver2ndFacet.IsEmpty Then
            clsFacetFunction.SetRCommand("facet_grid")
            clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetGridOp, bIncludeArgumentName:=False, iPosition:=0)
        End If
    End Sub

    Private Sub SecondFacetReceiverEnabled()
        If bRCodeUpdated Then
            If ucrReceiverFacetBy.IsEmpty() Then
                ucrReceiver2ndFacet.Clear()
                ucrReceiver2ndFacet.Enabled = False
            Else
                ucrReceiver2ndFacet.Enabled = True
            End If
        End If
    End Sub

    Private Sub MarginsEnabled()
        If bRCodeUpdated Then
            If Not ucrReceiver2ndFacet.IsEmpty AndAlso Not ucrReceiverFacetBy.IsEmpty Then
                ucrChkMargins.Enabled = True
            Else
                ucrChkMargins.Enabled = False
            End If
        End If
    End Sub

    Private Sub ucrReceiverXVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariable.ControlValueChanged
        If ucrReceiverXVariable.IsEmpty Then
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34), iPosition:=1)
        Else
            clsRaesFunction.AddParameter("x", clsRFunctionParameter:=clsAsFactor, iPosition:=1)
        End If
    End Sub

    Private Sub ucrVariablesAsFactorForClimaticBoxplot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForClimaticBoxplot.ControlValueChanged
        SetColourFillAes()
    End Sub

    Private Sub SetColourFillAes()
        If Not ucrVariablesAsFactorForClimaticBoxplot.IsEmpty AndAlso Not ucrVariablesAsFactorForClimaticBoxplot.bSingleVariable Then
            If rdoJitter.Checked Then
                clsRaesFunction.AddParameter("colour", "variable", iPosition:=2)
                clsRaesFunction.RemoveParameterByName("fill")
            Else
                clsRaesFunction.AddParameter("fill", "variable", , iPosition:=2)
                clsRaesFunction.RemoveParameterByName("colour")
            End If
        Else
            clsRaesFunction.RemoveParameterByName("fill")
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub ucrReceiverFacetBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacetBy.ControlValueChanged, ucrReceiver2ndFacet.ControlValueChanged
        SecondFacetReceiverEnabled()
        SetFacets()
        AddRemoveFacets()
        MarginsEnabled()
        FacetsCheck()
    End Sub

    Private Sub ucrSelectorClimaticBoxPlot_DataFrameChanged() Handles ucrSelectorClimaticBoxPlot.DataFrameChanged
        AutoFill()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSavePlot.ControlContentsChanged, ucrVariablesAsFactorForClimaticBoxplot.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub FacetsCheck()
        If Not ucrReceiverFacetBy.IsEmpty AndAlso Not ucrReceiver2ndFacet.IsEmpty Then
            If ucrReceiverFacetBy.txtReceiverSingle.Text = ucrReceiver2ndFacet.txtReceiverSingle.Text Then
                MsgBox("You cannot do facets with two of the same variables", vbOKOnly)
                ucrReceiver2ndFacet.Clear()
                ucrReceiver2ndFacet.SetMeAsReceiver()
            End If
        End If
    End Sub
End Class