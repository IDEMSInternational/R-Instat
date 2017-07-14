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

Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomBarFunction As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsPieAesFunction As New RFunction
    Private clsLocalRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsRCoordPolarParam As New RParameter

    Private clsLabsFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFuction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private bResetBarLayerSubdialog As Boolean = True

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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorReceiver.SetRCode(clsBarAesFunction, bReset)
        ucrFactorReceiver.AddAdditionalCodeParameterPair(clsPieAesFunction, New RParameter("fill", 0), iAdditionalPairNo:=1)

        ucrSecondReceiver.SetRCode(clsBarAesFunction, bReset)

        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrFactorReceiver.IsEmpty OrElse Not ucrSaveBar.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub AllControls_ContenctsChanged() Handles ucrFactorReceiver.ControlContentsChanged, ucrSaveBar.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsRCoordPolarFunction As New RFunction

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrPnlOptions.AddRadioButton(rdoBarChart)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddParameterPresentCondition(rdoPieChart, "coord_polar")
        ucrPnlOptions.AddParameterPresentCondition(rdoBarChart, "coord_polar", False)

        ucrPnlOptions.AddToLinkedControls(ucrChkFlipCoordinates, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrSecondReceiver, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSecondReceiver.SetLinkedDisplayControl(lblSecondFactor)

        ucrBarChartSelector.SetParameter(New RParameter("data", 0))
        ucrBarChartSelector.SetParameterIsrfunction()

        ucrFactorReceiver.Selector = ucrBarChartSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrSecondReceiver.Selector = ucrBarChartSelector
        ucrSecondReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondReceiver.strSelectorHeading = "Factors"
        ucrSecondReceiver.SetParameter(New RParameter("fill", 1))
        ucrSecondReceiver.bWithQuotes = False
        ucrSecondReceiver.SetParameterIsString()

        ' sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        ucrSaveBar.SetIsComboBox()
        ucrSaveBar.SetCheckBoxText("Save Graph")
        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.SetSaveTypeAsGraph()
        ucrSaveBar.SetPrefix("bar")
        ucrSaveBar.SetAssignToIfUncheckedValue("last_graph")

        clsRCoordPolarFunction.SetPackageName("ggplot2")
        clsRCoordPolarFunction.SetRCommand("coord_polar")
        clsRCoordPolarFunction.AddParameter("theta", Chr(34) & "y" & Chr(34))
        clsRCoordPolarParam.SetArgumentName("coord_polar")
        clsRCoordPolarParam.SetArgument(clsRCoordPolarFunction)

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsPieAesFunction = New RFunction

        ucrBarChartSelector.Reset()
        ucrFactorReceiver.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomBarFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")
        clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()

        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsThemeFuction = GgplotDefaults.clsDefaultThemeFunction.Clone
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
    End Sub

    Private Sub SetDialogOptions()
        If rdoBarChart.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            ucrSaveBar.SetPrefix("bar")
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameter(clsRCoordPolarParam)
        ElseIf rdoPieChart.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1)
            ucrSaveBar.SetPrefix("pie")
            clsRgeomBarFunction.AddParameter("width", "1")
            clsBaseOperator.AddParameter(clsRCoordPolarParam)
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        'What should global and local aes be?
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsBarAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        If clsBarAesFunction.ContainsParameter("x") Then
            ucrFactorReceiver.Add(clsBarAesFunction.GetParameter("x").strArgumentValue)
        Else
            ucrFactorReceiver.Clear()
        End If
        If clsBarAesFunction.ContainsParameter("fill") Then
            ucrSecondReceiver.Add(clsBarAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrSecondReceiver.Clear()
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsPieAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        'temp fix - should instead be setting R code of the receivers here
        If Not clsPieAesFunction.ContainsParameter("x") Then
            clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        If clsPieAesFunction.ContainsParameter("fill") Then
            ucrFactorReceiver.Add(clsPieAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrFactorReceiver.Clear()
        End If
        TestOkEnabled()
    End Sub

    Private Sub AllControlsChanged() Handles ucrSaveBar.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class