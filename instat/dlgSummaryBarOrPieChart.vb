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
    Private clsLabelGeomFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsAesFunction As New RFunction
    Private clsRoundFunction As New RFunction
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
    Private clsCoordPolarFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsLocalRaesFunction As New RFunction
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private bResetSummaryBarLayerSubdialog As Boolean = True

    Private Sub dlgSummaryBarOrPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctPositionPairs As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrPnlOptions.AddRadioButton(rdoBarChart)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddRadioButton(rdoTable)
        ucrPnlOptions.AddParameterPresentCondition(rdoPieChart, "coord_polar")
        ucrPnlOptions.AddParameterPresentCondition(rdoBarChart, "coord_polar", False)

        ucrPnlOptions.AddToLinkedControls(ucrReceiverSecondFactor, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSecondFactor.SetLinkedDisplayControl(lblSecondFactor)

        ucrSummaryBarSelector.SetParameter(New RParameter("data", 0))
        ucrSummaryBarSelector.SetParameterIsrfunction()

        ucrReceiverYVariable.SetParameter(New RParameter("y", 1))
        ucrReceiverYVariable.Selector = ucrSummaryBarSelector
        ucrReceiverYVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverYVariable.strSelectorHeading = "Numerics"
        ucrReceiverYVariable.bWithQuotes = False
        ucrReceiverYVariable.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("x", 0))
        ucrReceiverFactor.Selector = ucrSummaryBarSelector
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.bWithQuotes = False
        ucrReceiverFactor.SetParameterIsString()

        ucrReceiverSecondFactor.SetParameter(New RParameter("fill", 2))
        ucrReceiverSecondFactor.Selector = ucrSummaryBarSelector
        ucrReceiverSecondFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverSecondFactor.strSelectorHeading = "Factors"
        ucrReceiverSecondFactor.bWithQuotes = False
        ucrReceiverSecondFactor.SetParameterIsString()

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

        ucrChkLabel.SetParameter(New RParameter("geom_label", clsLabelGeomFunction, iNewPosition:=2), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkLabel.SetText("Add Label")
        ucrChkLabel.AddParameterPresentCondition(True, "geom_label")
        ucrChkLabel.AddParameterPresentCondition(False, "geom_label", False)

        ucrInputBarChartPosition.SetParameter(New RParameter("position", 1))
        dctPositionPairs.Add("Dodge", Chr(34) & "dodge" & Chr(34))
        dctPositionPairs.Add("Stack", Chr(34) & "stack" & Chr(34))
        dctPositionPairs.Add("Dodge2", Chr(34) & "dodge2" & Chr(34))
        dctPositionPairs.Add("Identity", Chr(34) & "identity" & Chr(34))
        dctPositionPairs.Add("Jitter", Chr(34) & "jitter" & Chr(34))
        dctPositionPairs.Add("Jitter dodge", "position_jitterdodge()")
        dctPositionPairs.Add("Nudge", Chr(34) & "nudge" & Chr(34))
        dctPositionPairs.Add("Fill", Chr(34) & "fill" & Chr(34))
        dctPositionPairs.Add("Stack in reverse", "position_stack(reverse = TRUE)")
        ucrInputBarChartPosition.SetItems(dctPositionPairs)
        ucrInputBarChartPosition.SetDropDownStyleAsNonEditable()

        ucrPnlOptions.AddToLinkedControls({ucrInputBarChartPosition, ucrChkLabel}, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputBarChartPosition.SetLinkedDisplayControl(lblPosition)

        'TODO: Enable when geom_label is in sync with options from plot options subdialog
        ucrChkLabel.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeomBarFunction = New RFunction
        clsRaesFunction = New RFunction
        clsAesFunction = New RFunction
        clsRoundFunction = New RFunction
        clsLabelGeomFunction.Clear()

        ucrSummaryBarSelector.Reset()
        ucrSummaryBarSelector.SetGgplotFunction(clsBaseOperator)
        ucrReceiverYVariable.SetMeAsReceiver()
        ucrSaveSummaryBar.Reset()
        bResetSubdialog = True
        bResetSummaryBarLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geomfunc", clsRFunctionParameter:=clsRgeomBarFunction, iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsAesFunction.SetPackageName("ggplot2")
        clsAesFunction.SetRCommand("aes")
        clsAesFunction.AddParameter("label", clsRFunctionParameter:=clsRoundFunction, iPosition:=0)

        clsRoundFunction.SetRCommand("round")
        clsRoundFunction.AddParameter("digits", 2, iPosition:=1)

        clsRgeomBarFunction.SetPackageName("ggplot2")
        clsRgeomBarFunction.SetRCommand("geom_bar")
        clsRgeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=0)
        clsRgeomBarFunction.AddParameter("position", Chr(34) & "dodge" & Chr(34), iPosition:=1)

        clsLabelGeomFunction.SetPackageName("ggplot2")
        clsLabelGeomFunction.SetRCommand("geom_label")
        clsLabelGeomFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesFunction, iPosition:=1)
        clsLabelGeomFunction.AddParameter("show.legend", "FALSE", iPosition:=2)

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSummaryBarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYVariable.AddAdditionalCodeParameterPair(clsRoundFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverFactor.SetRCode(clsRaesFunction, bReset)
        ucrReceiverYVariable.SetRCode(clsRaesFunction, bReset)
        ucrReceiverSecondFactor.SetRCode(clsRaesFunction, bReset)
        ucrSaveSummaryBar.SetRCode(clsBaseOperator, bReset)
        ucrSummaryBarSelector.SetRCode(clsRggplotFunction, bReset)
        ucrPnlOptions.SetRCode(clsBaseOperator, bReset)
        ucrChkLabel.SetRCode(clsBaseOperator, bReset)
        ucrInputBarChartPosition.SetRCode(clsRgeomBarFunction, bReset)
        SetDialogOptions()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverYVariable.IsEmpty OrElse ucrReceiverFactor.IsEmpty OrElse Not ucrSaveSummaryBar.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        sdgPlots.Reset()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewGlobalAesFunction:=clsRaesFunction, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSummaryBarSelector, clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSummaryBarSelector, bApplyAesGlobally:=True, bReset:=bResetSummaryBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSummaryBarLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrReceiverFactor.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                ucrReceiverYVariable.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrReceiverSecondFactor.Add(clsParam.strArgumentValue)
            End If
        Next
        'Syc position parameter
        ucrInputBarChartPosition.SetRCode(clsRgeomBarFunction, bReset)
        TestOkEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeomBarFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrSummaryBarSelector, bApplyAesGlobally:=True, bReset:=bResetSummaryBarLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetSummaryBarLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                ucrReceiverYVariable.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrReceiverFactor.Add(clsParam.strArgumentValue)
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
            ucrReceiverYVariable.SetMeAsReceiver()
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

    Private Sub ucrInputBarChartPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBarChartPosition.ControlValueChanged
        Select Case ucrInputBarChartPosition.GetText
            Case "Stack"
                clsLabelGeomFunction.AddParameter("position", "position_stack(vjust=1)", iPosition:=1)
            Case "Dodge"
                clsLabelGeomFunction.AddParameter("position", "position_dodge(width=1)", iPosition:=1)
            Case "Dodge2"
                clsLabelGeomFunction.AddParameter("position", "position_dodge2(width=1)", iPosition:=1)
            Case "Identity"
                clsLabelGeomFunction.AddParameter("position", "position_identity()", iPosition:=1)
            Case "Jitter"
                clsLabelGeomFunction.AddParameter("position", "position_jitter(width=0)", iPosition:=1)
            Case "Jitter dodge"
                clsLabelGeomFunction.AddParameter("position", "position_jitterdodge()", iPosition:=1)
            Case "Nudge"
                clsLabelGeomFunction.AddParameter("position", "position_nudge()", iPosition:=1)
            Case "Fill"
                clsLabelGeomFunction.AddParameter("position", "position_fill()", iPosition:=1)
            Case "Stack in reverse"
                clsLabelGeomFunction.AddParameter("position", "position_stack()", iPosition:=1)
            Case Else
                clsLabelGeomFunction.RemoveParameterByName("position")
        End Select
    End Sub

    Private Sub CoreControls_ContenctsChanged() Handles ucrReceiverYVariable.ControlContentsChanged, ucrReceiverFactor.ControlContentsChanged, ucrSaveSummaryBar.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverSecondFactor_ForeColorChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondFactor.ForeColorChanged
        clsScaleColourViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
        clsScaleFillViridisFunction.AddParameter("discrete", "TRUE", iPosition:=5)
    End Sub
End Class