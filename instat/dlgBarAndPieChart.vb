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
    Private clsRColFunction As New RFunction
    Private clsColAesFunction As New RFunction
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

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter
        Dim clsRCoordPolarFunction As New RFunction
        Dim dctPositionPairs As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrPnlOptions.AddRadioButton(rdoBarChart)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddRadioButton(rdoColumnChart)
        ucrPnlOptions.AddParameterPresentCondition(rdoPieChart, "coord_polar")
        ucrPnlOptions.AddParameterPresentCondition(rdoBarChart, "geom_bar")
        ucrPnlOptions.AddParameterPresentCondition(rdoColumnChart, "geom_col")

        ucrPnlOptions.AddToLinkedControls({ucrChkFlipCoordinates}, {rdoColumnChart, rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputBarChartPosition, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputBarChartPosition.SetLinkedDisplayControl(lblPosition)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverByFactor}, {rdoBarChart, rdoColumnChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverByFactor.SetLinkedDisplayControl(lblByFactor)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverY, {rdoColumnChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverY.SetLinkedDisplayControl(lblYvariable)

        ucrBarChartSelector.SetParameter(New RParameter("data", 0))
        ucrBarChartSelector.SetParameterIsrfunction()

        ucrReceiverFirst.Selector = ucrBarChartSelector
        ucrReceiverFirst.strSelectorHeading = "Variables"
        ucrReceiverFirst.SetParameter(New RParameter("x", 0))
        ucrReceiverFirst.bWithQuotes = False
        ucrReceiverFirst.SetParameterIsString()
        ucrReceiverFirst.SetLinkedDisplayControl(lblVariable)

        ucrReceiverByFactor.Selector = ucrBarChartSelector
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverByFactor.strSelectorHeading = "Factors"
        ucrReceiverByFactor.SetParameter(New RParameter("fill", 1))
        ucrReceiverByFactor.bWithQuotes = False
        ucrReceiverByFactor.SetParameterIsString()

        ucrReceiverY.Selector = ucrBarChartSelector
        ucrReceiverY.strSelectorHeading = "Y Variable"
        ucrReceiverY.SetParameter(New RParameter("y", 1))
        ucrReceiverY.bWithQuotes = False
        ucrReceiverY.SetParameterIsString()
        ucrReceiverY.SetLinkedDisplayControl(lblYvariable)

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

        ucrInputBarChartPosition.SetParameter(New RParameter("position", 0))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputBarChartPosition.SetItems(dctPositionPairs)
        ucrInputBarChartPosition.SetDropDownStyleAsNonEditable()
        ucrInputBarChartPosition.SetRDefault(Chr(34) & "stack" & Chr(34))

    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsPieAesFunction = New RFunction
        clsColAesFunction = New RFunction
        clsRColFunction = New RFunction

        ucrBarChartSelector.Reset()
        ucrBarChartSelector.SetGgplotFunction(clsBaseOperator)
        ucrReceiverFirst.SetMeAsReceiver()
        ucrSaveBar.Reset()
        bResetSubdialog = True
        bResetBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)


        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsColAesFunction, iPosition:=1)


        clsBarAesFunction.SetPackageName("ggplot2")
        clsBarAesFunction.SetRCommand("aes")

        clsPieAesFunction.SetPackageName("ggplot2")
        clsPieAesFunction.SetRCommand("aes")
        clsPieAesFunction.AddParameter("x", Chr(34) & Chr(34))

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=0)

        clsColAesFunction.SetPackageName("ggplot2")
        clsColAesFunction.SetRCommand("aes")
        clsColAesFunction.AddParameter("x", Chr(34) & Chr(34))
        clsColAesFunction.AddParameter("y", Chr(34) & Chr(34))

        clsRColFunction.SetPackageName("ggplot2")
        clsRColFunction.SetRCommand("geom_col")



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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverFirst.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsPieAesFunction, New RParameter("fill", 0), iAdditionalPairNo:=1)
        ucrReceiverFirst.AddAdditionalCodeParameterPair(clsColAesFunction, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrReceiverByFactor.SetRCode(clsBarAesFunction, bReset)
        ucrReceiverByFactor.AddAdditionalCodeParameterPair(clsColAesFunction, New RParameter("fill", 0), iAdditionalPairNo:=1)

        ucrReceiverY.SetRCode(clsColAesFunction, bReset)

        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrInputBarChartPosition.SetRCode(clsRgeomBarFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoBarChart.Checked Then
            If ucrReceiverFirst.IsEmpty OrElse Not ucrSaveBar.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoPieChart.Checked Then
            If ucrReceiverFirst.IsEmpty OrElse Not ucrSaveBar.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoColumnChart.Checked Then
            If Not ucrReceiverFirst.IsEmpty AndAlso Not ucrReceiverY.IsEmpty AndAlso ucrSaveBar.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        If rdoBarChart.Checked Then
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsBarAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, bReset:=bResetSubdialog)
        Else
            sdgPlots.SetRCode(clsNewOperator:=clsBaseOperator, clsNewGlobalAesFunction:=clsPieAesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewThemeFunction:=clsThemeFuction, dctNewThemeFunctions:=dctThemeFunctions, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrBarChartSelector, bReset:=bResetSubdialog)
        End If
        sdgPlots.ShowDialog()
        bResetSubdialog = False
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...

        'this syncs the coordflip in sdgplots and this main dlg
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        'What should global and local aes be?
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsBarAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        If clsBarAesFunction.ContainsParameter("x") Then
            ucrReceiverFirst.Add(clsBarAesFunction.GetParameter("x").strArgumentValue)
        Else
            ucrReceiverFirst.Clear()
        End If
        If clsBarAesFunction.ContainsParameter("fill") Then
            ucrReceiverByFactor.Add(clsBarAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrReceiverByFactor.Clear()
        End If
        'Allows for sync with the layer parameters
        ucrInputBarChartPosition.SetRCode(clsRgeomBarFunction, bReset)
        TestOkEnabled()
    End Sub

    Private Sub cmdColumnChartOptions_Click(sender As Object, e As EventArgs) Handles cmdColumnChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRColFunction, clsNewGlobalAesFunc:=clsColAesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrBarChartSelector, bApplyAesGlobally:=True, bReset:=bResetBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetBarLayerSubdialog = False
        If clsColAesFunction.ContainsParameter("x") Then
            ucrReceiverFirst.Add(clsColAesFunction.GetParameter("x").strArgumentValue)
        Else
            ucrReceiverFirst.Clear()
        End If
        If clsColAesFunction.ContainsParameter("y") Then
            ucrReceiverY.Add(clsColAesFunction.GetParameter("y").strArgumentValue)
        Else
            ucrReceiverY.Clear()
        End If
        If clsColAesFunction.ContainsParameter("fill") Then
            ucrReceiverByFactor.Add(clsColAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrReceiverByFactor.Clear()
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
            ucrReceiverFirst.Add(clsPieAesFunction.GetParameter("fill").strArgumentValue)
        Else
            ucrReceiverFirst.Clear()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        If rdoBarChart.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True
            cmdColumnChartOptions.Visible = False
            If Not clsBaseOperator.ContainsParameter("geom_bar") Then
                clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=2)
            End If
            clsRgeomBarFunction.RemoveParameterByName("width")
            clsBaseOperator.RemoveParameter(clsRCoordPolarParam)
            clsBaseOperator.RemoveParameterByName("geom_col")
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("bar")
            End If
            ucrReceiverFirst.RemoveIncludedMetadataProperty("class")
            ucrReceiverFirst.strSelectorHeading = "Variables"
        ElseIf rdoPieChart.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsPieAesFunction, iPosition:=1)
            clsRgeomBarFunction.AddParameter("width", "1")
            clsBaseOperator.AddParameter(clsRCoordPolarParam)
            clsBaseOperator.RemoveParameterByName("geom_col")
            ucrReceiverFirst.SetMeAsReceiver()
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
            cmdColumnChartOptions.Visible = False
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("pie")
            End If
            ucrReceiverFirst.SetIncludedDataTypes({"factor"})
            ucrReceiverFirst.strSelectorHeading = "Factors"
            If Not {"factor", "logical"}.Contains(ucrReceiverFirst.strCurrDataType) Then
                ucrReceiverFirst.Clear()
            End If
        ElseIf rdoColumnChart.Checked Then
            clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsColAesFunction, iPosition:=1)
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = False
            cmdColumnChartOptions.Visible = True
            ucrReceiverFirst.SetIncludedDataTypes({"numeric", "factor"})
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameter(clsRCoordPolarParam)
            clsBaseOperator.AddParameter("geom_col", clsRFunctionParameter:=clsRColFunction, iPosition:=2)
            ucrReceiverY.SetMeAsReceiver()
            If Not ucrSaveBar.bUserTyped Then
                ucrSaveBar.SetPrefix("column")
            End If
        End If
    End Sub
    Private Sub ChangeReceiverLocation()
        If rdoBarChart.Checked Then
            lblVariable.Text = "Variable"
            lblVariable.Location = New Point(255, 76)
            ucrReceiverFirst.Location = New Point(255, 91)
            lblByFactor.Text = "By Factor (Optional):"
            lblByFactor.Location = New Point(255, 126)
            ucrReceiverByFactor.Location = New Point(255, 141)
            lblPosition.Text = "Position"
            lblPosition.Location = New Point(255, 171)
            ucrInputBarChartPosition.Location = New Point(255, 184)
        ElseIf rdoColumnChart.Checked Then
            lblYvariable.Text = "Y Variable:"
            lblYvariable.Location = New Point(255, 76)
            ucrReceiverY.Location = New Point(255, 91)
            lblVariable.Text = "X Variable:"
            lblVariable.Location = New Point(255, 126)
            ucrReceiverFirst.Location = New Point(255, 141)
            lblByFactor.Text = "By Factor (Optional):"
            lblByFactor.Location = New Point(255, 171)
            ucrReceiverByFactor.Location = New Point(255, 184)
        ElseIf rdoPieChart.Checked Then
            lblVariable.Text = "Variable"
            lblVariable.Location = New Point(255, 76)
            ucrReceiverFirst.Location = New Point(255, 91)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
        ChangeReceiverLocation()
    End Sub

    Private Sub CoreControls_ContentsChanged() Handles ucrReceiverFirst.ControlContentsChanged, ucrReceiverY.ControlContentsChanged, ucrSaveBar.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
