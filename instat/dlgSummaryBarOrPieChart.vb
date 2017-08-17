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
Public Class dlgSummaryBarOrPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsRCoordPolarParam As New RParameter
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
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
    Private bResetSummaryBarLayerSubdialog As Boolean = True

    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim clsRCoordPolarFunction As New RFunction
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrPnlOptions.AddRadioButton(rdoBarChart)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddRadioButton(rdoTable)
        ucrPnlOptions.AddParameterPresentCondition(rdoPieChart, "coord_polar")
        ucrPnlOptions.AddParameterPresentCondition(rdoBarChart, "coord_polar", False)

        ucrPnlOptions.AddToLinkedControls(ucrSecondFactorReceiver, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSecondFactorReceiver.SetLinkedDisplayControl(lblSecondFactor)

        ucrSummaryBarSelector.SetParameter(New RParameter("data", 0))
        ucrSummaryBarSelector.SetParameterIsrfunction()

        ucrYReceiver.SetParameter(New RParameter("y", 1))
        ucrYReceiver.Selector = ucrSummaryBarSelector
        ucrYReceiver.SetIncludedDataTypes({"numeric"})
        ucrYReceiver.strSelectorHeading = "Numerics"
        ucrYReceiver.bWithQuotes = False
        ucrYReceiver.SetParameterIsString()

        ucrFactorReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorReceiver.Selector = ucrSummaryBarSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrSecondFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondFactorReceiver.Selector = ucrSummaryBarSelector
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.strSelectorHeading = "Factors"
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetParameterIsString()

        ucrSaveSummaryBar.SetIsComboBox()
        ucrSaveSummaryBar.SetCheckBoxText("Save Graph")
        ucrSaveSummaryBar.SetDataFrameSelector(ucrSummaryBarSelector.ucrAvailableDataFrames)
        ucrSaveSummaryBar.SetSaveTypeAsGraph()
        ucrSaveSummaryBar.SetPrefix("bar")
        ucrSaveSummaryBar.SetAssignToIfUncheckedValue("last_graph")

        clsRCoordPolarFunction.SetPackageName("ggplot2")
        clsRCoordPolarFunction.SetRCommand("coord_polar")
        clsRCoordPolarFunction.AddParameter("theta", Chr(34) & "y" & Chr(34))
        clsRCoordPolarParam.SetArgumentName("coord_polar")
        clsRCoordPolarParam.SetArgument(clsRCoordPolarFunction)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsRaesFunction = New RFunction

        ucrSummaryBarSelector.Reset()
        ucrSummaryBarSelector.SetGgplotFunction(clsBaseOperator)
        ucrYReceiver.SetMeAsReceiver()
        ucrSaveSummaryBar.Reset()
        bResetSubdialog = True
        bResetSummaryBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomBarFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()

        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSummaryBarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrYReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSaveSummaryBar.SetRCode(clsBaseOperator, bReset)
        ucrSummaryBarSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        SetDialogOptions()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrYReceiver.IsEmpty AndAlso Not ucrFactorReceiver.IsEmpty AndAlso ucrSaveSummaryBar.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        sdgPlots.Reset()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSummaryBarSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSummaryBarSelector, bApplyAesGlobally:=True, bReset:=bResetSummaryBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSummaryBarLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                ucrYReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSummaryBarSelector, bApplyAesGlobally:=True, bReset:=bResetSummaryBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSummaryBarLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                ucrYReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        If rdoBarChart.Checked Then
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameter(clsRCoordPolarParam)
            If Not ucrSaveSummaryBar.bUserTyped Then
                ucrSaveSummaryBar.SetPrefix("bar")
            End If
        ElseIf rdoPieChart.Checked Then
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
            clsRgeomBarFunction.AddParameter("width", "1")
            clsBaseOperator.AddParameter(clsRCoordPolarParam)
            If Not ucrSaveSummaryBar.bUserTyped Then
                ucrSaveSummaryBar.SetPrefix("pie")
            End If
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
    End Sub

    Private Sub CoreControls_ContenctsChanged() Handles ucrYReceiver.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged, ucrSaveSummaryBar.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class