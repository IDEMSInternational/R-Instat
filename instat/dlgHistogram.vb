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

Imports instat
Imports instat.Translations
Public Class dlgHistogram
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsHistAesFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private bResetHistLayerSubdialog As Boolean = True
    Private clsPercentage As New RFunction
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsReorderFunction As New RFunction
    Private clsGeomTextFunction As New RFunction
    Private clsForecatsInfreqValue As New RFunction
    Private clsForecatsInfreq As New RFunction
    Private clsForecatsReverse As New RFunction

    Private clsDummyRev As New RFunction
    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"
    Private ReadOnly strReverse As String = "Reverse"
    Private ReadOnly strNone As String = "None"

    'Parameter names for geoms
    Private strFirstParameterName As String = "geomfunc"
    Private strGeomParameterNames() As String = {strFirstParameterName}

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctStats As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 435

        ucrPnlOptions.AddRadioButton(rdoHistogram)
        ucrPnlOptions.AddRadioButton(rdoDensity_ridges)
        ucrPnlOptions.AddRadioButton(rdoFrequencyPolygon)

        ucrPnlOptions.AddFunctionNamesCondition(rdoHistogram, {"geom_histogram", "geom_dotplot"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoDensity_ridges, {"geom_density", "geom_density_ridges"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoFrequencyPolygon, "geom_freqpoly")

        ucrHistogramSelector.SetParameter(New RParameter("data", 0))
        ucrHistogramSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("fill", 1))
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        'can put in colour for density and polygon but fill for Histogram
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrInputStats.SetParameter(New RParameter("y", 0))
        dctStats.Add("Counts", "stat(count)")
        dctStats.Add("Fractions", "stat(count/sum(count))")
        dctStats.Add("Scaled Fractions", "stat(count/max(count))")
        ucrInputStats.SetDropDownStyleAsNonEditable()
        ucrInputStats.SetItems(dctStats)
        ucrInputStats.SetLinkedDisplayControl(lblStats)
        ucrInputStats.AddToLinkedControls(ucrChkPercentages, {"Fractions"}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkPercentages.SetText("Percentages")
        ucrChkPercentages.AddParameterPresentCondition(True, "scale")
        ucrChkPercentages.AddParameterPresentCondition(False, "scale", False)

        ucrChkDisplayAsDotPlot.SetText("Display as Dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(True, "geom_dotplot")
        ucrChkDisplayAsDotPlot.AddFunctionNamesCondition(False, "geom_dotplot", False)

        ucrChkRidges.SetText("Density Ridges")
        ucrChkRidges.AddFunctionNamesCondition(True, "geom_density_ridges")
        ucrChkRidges.AddFunctionNamesCondition(False, "geom_density_ridges", False)

        ucrVariablesAsFactorforHist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforHist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforHist.Selector = ucrHistogramSelector
        ucrVariablesAsFactorforHist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforHist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforHist.bWithQuotes = False
        ucrVariablesAsFactorforHist.SetParameterIsString()

        ucrInputAddReorder.SetItems({strAscending, strDescending, strReverse, strNone})
        ucrInputAddReorder.SetDropDownStyleAsNonEditable()
        ucrInputAddReorder.SetLinkedDisplayControl(lblReorder)

        ucrPnlOptions.AddToLinkedControls({ucrChkDisplayAsDotPlot}, {rdoHistogram}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkRidges}, {rdoDensity_ridges}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRidges.AddToLinkedControls(ucrInputStats, {"FALSE"}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveHist.SetPrefix("histogram")
        ucrSaveHist.SetDataFrameSelector(ucrHistogramSelector.ucrAvailableDataFrames)
        ucrSaveHist.SetIsComboBox()
        ucrSaveHist.SetCheckBoxText("Save Graph")
        ucrSaveHist.SetSaveTypeAsGraph()
        ucrSaveHist.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomPlotFunction = New RFunction
        clsRaesFunction = New RFunction
        clsHistAesFunction = New RFunction
        clsPercentage = New RFunction
        clsGeomTextFunction = New RFunction
        clsForecatsReverse = New RFunction
        clsDummyRev = New RFunction
        clsReorderFunction = New RFunction
        clsForecatsInfreqValue = New RFunction
        clsForecatsInfreq = New RFunction
        clsForecatsReverse = New RFunction

        ucrHistogramSelector.Reset()
        ucrHistogramSelector.SetGgplotFunction(clsBaseOperator)
        ucrSaveHist.Reset()
        ucrVariablesAsFactorforHist.SetMeAsReceiver()
        bResetSubdialog = True
        bResetHistLayerSubdialog = True

        clsDummyRev.AddParameter("reverse", "FALSE", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter(strFirstParameterName, clsRFunctionParameter:=clsRgeomPlotFunction, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        ucrInputAddReorder.SetText(strNone)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsHistAesFunction.SetPackageName("ggplot2")
        clsHistAesFunction.SetRCommand("aes")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_histogram")
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)

        clsPercentage.SetPackageName("scales")
        clsPercentage.SetRCommand("percent_format")

        clsGeomTextFunction.SetPackageName("ggplot2")
        clsGeomTextFunction.SetRCommand("geom_text")
        clsGeomTextFunction.AddParameter("colour", "black", iPosition:=4)
        clsGeomTextFunction.AddParameter("vjust", "-0.25", iPosition:=2)
        clsGeomTextFunction.AddParameter("size", "4", iPosition:=5)

        clsForecatsReverse.SetPackageName("forcats")
        clsForecatsReverse.SetRCommand("fct_rev")

        clsReorderFunction.SetRCommand("reorder")

        clsForecatsInfreqValue.SetPackageName("forcats")
        clsForecatsInfreqValue.SetRCommand("fct_infreq")

        clsForecatsInfreq.SetPackageName("forcats")
        clsForecatsInfreq.SetRCommand("fct_infreq")

        clsForecatsReverse.SetPackageName("forcats")
        clsForecatsReverse.SetRCommand("fct_rev")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveHist.SetRCode(clsBaseOperator, bReset)
        ucrHistogramSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkPercentages.SetRCode(clsYScalecontinuousFunction, bReset)
        ucrChkDisplayAsDotPlot.SetRCode(clsRgeomPlotFunction, bReset)
        ucrChkRidges.SetRCode(clsRgeomPlotFunction, bReset)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorforHist.SetRCode(clsRaesFunction, bReset)
        ucrFactorReceiver.AddAdditionalCodeParameterPair(clsReorderFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        If bReset Then
            ucrInputStats.SetRCode(clsHistAesFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        'Tests when ok can be enabled
        ucrBase.OKEnabled(Not ucrVariablesAsFactorforHist.IsEmpty AndAlso ucrSaveHist.IsComplete)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        clsHistAesFunction.RemoveParameterByName("x")
        clsHistAesFunction.RemoveParameterByName("y")
        clsHistAesFunction.AddParameter("y", "stat(count)", iPosition:=0)
        clsRgeomPlotFunction.SetPackageName("ggplot2")
        ucrInputAddReorder.Visible = Not ucrFactorReceiver.IsEmpty()
        If rdoHistogram.Checked Then
            If ucrChkDisplayAsDotPlot.Checked Then
                clsRgeomPlotFunction.SetRCommand("geom_dotplot")
            Else
                clsRgeomPlotFunction.SetRCommand("geom_histogram")
            End If
            ucrFactorReceiver.ChangeParameterName("fill")
        End If
        If rdoDensity_ridges.Checked Then
            ucrFactorReceiver.ChangeParameterName("fill")
            If Not ucrSaveHist.bUserTyped Then
                ucrSaveHist.SetPrefix("density_ridges")
            End If
            If ucrChkRidges.Checked Then
                ucrFactorReceiver.ChangeParameterName("y")
                clsHistAesFunction.RemoveParameterByName("y")
                clsHistAesFunction.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorforHist.GetVariables(), iPosition:=1)
                clsHistAesFunction.AddParameter("y", clsRFunctionParameter:=ucrFactorReceiver.GetVariables(), iPosition:=2)
                clsRgeomPlotFunction.SetPackageName("ggridges")
                clsRgeomPlotFunction.SetRCommand("geom_density_ridges")
            Else
                ucrFactorReceiver.ChangeParameterName("colour")
                clsRgeomPlotFunction.SetRCommand("geom_density")
            End If
        ElseIf rdoFrequencyPolygon.Checked Then
            ucrFactorReceiver.ChangeParameterName("colour")
            clsRgeomPlotFunction.SetRCommand("geom_freqpoly")
            If Not ucrSaveHist.bUserTyped Then
                ucrSaveHist.SetPrefix("density")
            End If
            ucrFactorReceiver.ChangeParameterName("fill")
            If Not ucrSaveHist.bUserTyped Then
                ucrSaveHist.SetPrefix("frequency_polygon")
            End If
        End If
        autoTranslate(Me)
        UpdateParameter()
    End Sub

    Private Sub ucrPnlOptions_Control() Handles ucrPnlOptions.ControlValueChanged, ucrChkDisplayAsDotPlot.ControlValueChanged,
        ucrChkRidges.ControlValueChanged, ucrFactorReceiver.ControlValueChanged, ucrVariablesAsFactorforHist.ControlValueChanged,
        ucrInputAddReorder.ControlValueChanged
        SetDialogOptions()
    End Sub

    Private Sub Adding_Percentages(ucrChangedControl As ucrCore) Handles ucrInputStats.ControlValueChanged, ucrChkPercentages.ControlValueChanged
        If ucrInputStats.GetText() = "Fractions" AndAlso ucrChkPercentages.Checked Then
            clsYScalecontinuousFunction.AddParameter("labels", clsRFunctionParameter:=clsPercentage)
            clsBaseOperator.AddParameter("scale", clsRFunctionParameter:=clsYScalecontinuousFunction)
        Else
            clsBaseOperator.RemoveParameterByName("scale")
        End If
    End Sub

    'TODO remove vbCr not compatible with other code
    Private Sub rdoHistogram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoHistogram.KeyPress
        If e.KeyChar = vbCr Then
            rdoHistogram.Checked = True
        End If
    End Sub

    Private Sub rdoDensity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoDensity_ridges.KeyPress
        If e.KeyChar = vbCr Then
            rdoDensity_ridges.Checked = True
        End If
    End Sub

    Private Sub rdoFrequencyPolygon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoFrequencyPolygon.KeyPress
        If e.KeyChar = vbCr Then
            rdoFrequencyPolygon.Checked = True
        End If
    End Sub

    Private Sub ucrVariablesAsFactorforHist_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorforHist.ControlValueChanged
        If Not ucrVariablesAsFactorforHist.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariablesAsFactorforHist.GetVariableNames(False), iPosition:=0)
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click, toolStripMenuItemPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction,
                         clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction,
                         clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrHistogramSelector,
                         clsNewGlobalAesFunction:=clsRaesFunction, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction,
                         clsNewAnnotateFunction:=clsAnnotateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, strMainDialogGeomParameterNames:=strGeomParameterNames, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub toolStripMenuItemHistogramOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemHistogramOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorforHist.bSingleVariable) Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf (clsParam.strArgumentName = "fill" AndAlso rdoHistogram.Checked) OrElse (clsParam.strArgumentName = "colour" AndAlso (rdoFrequencyPolygon.Checked OrElse (rdoDensity_ridges.Checked AndAlso Not ucrChkRidges.Checked))) OrElse (clsParam.strArgumentName = "y" AndAlso (rdoDensity_ridges.Checked AndAlso ucrChkRidges.Checked)) Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        'this is here because of the subdialog 
        clsRgeomPlotFunction.AddParameter("mapping", clsRFunctionParameter:=clsHistAesFunction)
        TestOkEnabled()
    End Sub

    Private Sub toolStripMenuItemDensityOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemDensityRidgesOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDensityRidgesOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub toolStripMenuItemFrequencyPolygonOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemFrequencyPolygonOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()

    End Sub

    Private Sub toolStripMenuItemDotOptions_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemDotOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrHistogramSelector, bApplyAesGlobally:=True, bReset:=bResetHistLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetHistLayerSubdialog = False
        SetDialogOptions()
    End Sub

    Private Sub SetGeomTextOptions()
        If rdoHistogram.Checked Then
            clsGeomTextFunction.AddParameter("stat", Chr(34) & "count" & Chr(34), iPosition:=0)
        Else
            clsGeomTextFunction.RemoveParameterByName("stat")
        End If
    End Sub

    Private Sub DialogueSize()
        If rdoHistogram.Checked Then
            Me.Size = New Size(464, 480)
            Me.ucrSaveHist.Location = New Point(10, 284)
            Me.ucrBase.Location = New Point(10, 314)
        ElseIf rdoDensity_ridges.Checked Then
            Me.Size = New Size(464, 433)
            Me.ucrSaveHist.Location = New Point(10, 311)
            Me.ucrBase.Location = New Point(10, 334)
        Else
            Me.Size = New Size(464, 401)
            Me.ucrSaveHist.Location = New Point(10, 275)
            Me.ucrBase.Location = New Point(10, 305)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforHist.ControlContentsChanged, ucrSaveHist.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged, ucrChkRidges.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub UpdateParameter()
        If rdoHistogram.Checked OrElse rdoDensity_ridges.Checked OrElse rdoFrequencyPolygon.Checked Then
            Dim strChangedTextValue As String = ucrInputAddReorder.GetText()
            clsForecatsInfreq.AddParameter("f", "as.factor(" & ucrVariablesAsFactorforHist.GetVariableNames(False) & ")", iPosition:=0)
            clsForecatsInfreqValue.AddParameter("f", "as.factor(" & ucrFactorReceiver.GetVariableNames(False) & ")", iPosition:=0)
            Select Case strChangedTextValue
                Case strAscending
                    clsForecatsReverse.AddParameter("f", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=0)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=1)
                Case strDescending
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsInfreqValue, iPosition:=1)
                Case strReverse
                    clsForecatsReverse.AddParameter("f", ucrFactorReceiver.GetVariableNames(False), iPosition:=0)
                    clsHistAesFunction.AddParameter("fill", clsRFunctionParameter:=clsForecatsReverse, iPosition:=0)
            End Select
        End If
    End Sub
    Private Sub ucrPnlOptions_Control(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrFactorReceiver.ControlValueChanged,
        ucrChkRidges.ControlValueChanged, ucrChkDisplayAsDotPlot.ControlValueChanged, ucrVariablesAsFactorforHist.ControlValueChanged,
        ucrInputAddReorder.ControlValueChanged
        UpdateParameter()
    End Sub
End Class