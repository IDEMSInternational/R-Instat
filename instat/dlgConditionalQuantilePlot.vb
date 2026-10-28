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
Public Class dlgConditionalQuantilePlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iDialogHeight As Integer
    Private iBaseMaxY As Integer
    Private clsConditionalQuantileFunction As New RFunction
    Private clsConditionalEvalFunction As New RFunction
    Private clsConditionalQuantilePlotOperator As New ROperator
    Private clsConditionalEvalPlotOperator As New ROperator

    Private Sub dlgConditionalQuantilePlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iDialogHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        SetMode()
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 642

        ucrConditionalQuantilePlotSelector.SetParameter(New RParameter("mydata", 0))
        ucrConditionalQuantilePlotSelector.SetParameterIsrfunction()

        ucrReceiverObservations.SetParameter(New RParameter("obs", 1))
        ucrReceiverObservations.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverObservations.SetParameterIsString()
        ucrReceiverObservations.SetIncludedDataTypes({"numeric"})
        ucrReceiverObservations.strSelectorHeading = "Numerics"

        ucrReceiverPredictions.SetParameter(New RParameter("mod", 2))
        ucrReceiverPredictions.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverPredictions.SetParameterIsString()
        ucrReceiverPredictions.SetIncludedDataTypes({"numeric"})
        ucrReceiverPredictions.strSelectorHeading = "Numerics"

        ucrReceiverMultipleFacet.SetParameter(New RParameter("type", 3))
        ucrReceiverMultipleFacet.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverMultipleFacet.SetParameterIsString()
        ucrReceiverMultipleFacet.SetIncludedDataTypes({"factor"})
        ucrReceiverMultipleFacet.bExcludeFromSelector = True

        ucrReceiverMultipleObs.SetParameter(New RParameter("var.obs", 3))
        ucrReceiverMultipleObs.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverMultipleObs.SetParameterIsString()
        ucrReceiverMultipleObs.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultipleObs.bExcludeFromSelector = True
        ucrReceiverMultipleObs.strSelectorHeading = "Numerics"

        ucrReceiverMultiplePred.SetParameter(New RParameter("var.mod", 4))
        ucrReceiverMultiplePred.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverMultiplePred.SetParameterIsString()
        ucrReceiverMultiplePred.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultiplePred.bExcludeFromSelector = True
        ucrReceiverMultiplePred.strSelectorHeading = "Numerics"

        ucrReceiverType.SetParameter(New RParameter("type", 5))
        ucrReceiverType.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverType.SetParameterIsString()
        ucrReceiverType.SetIncludedDataTypes({"character"})
        ucrReceiverType.strSelectorHeading = "Variables"

        ucrReceiverStatistics.SetParameter(New RParameter("statistic", 7))
        ucrReceiverStatistics.Selector = ucrConditionalQuantilePlotSelector
        ucrReceiverStatistics.SetParameterIsString()
        ucrReceiverStatistics.SetIncludedDataTypes({"numeric"})
        ucrReceiverStatistics.strSelectorHeading = "Numerics"

        ucrNudBin.SetParameter(New RParameter("bins", 4))
        ucrNudBin.Minimum = 1
        ucrNudBin.SetRDefault(31)

        ucrNudMinNumPoints.SetParameter(New RParameter("min.bin", 5))
        ucrNudMinNumPoints.Minimum = 5
        ucrNudMinNumPoints.SetRDefault(10)

        ucrNudColumns.SetParameter(New RParameter("key.columns", 9))
        ucrNudColumns.Minimum = 1
        ucrNudColumns.SetRDefault(2)

        ucrInputLegendPosition.SetParameter(New RParameter("key.position", 10))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrInputLegendPosition.SetRDefault(Chr(34) & "none" & Chr(34))
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()

        ' The mode is chosen by the radio buttons only. Each function keeps its own
        ' parameters, and SetMode() decides which one is run and which controls show.
        ucrPnlOptions.AddRadioButton(rdoQuantiles)
        ucrPnlOptions.AddRadioButton(rdoEvaluation)

        ucrSavePlot.SetPrefix("cond_quantile_plot")
        ucrSavePlot.SetCheckBoxText("Store Graph")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrConditionalQuantilePlotSelector.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsConditionalQuantileFunction = New RFunction
        clsConditionalEvalFunction = New RFunction
        clsConditionalQuantilePlotOperator = New ROperator
        clsConditionalEvalPlotOperator = New ROperator

        ucrConditionalQuantilePlotSelector.Reset()
        ucrSavePlot.Reset()
        ucrReceiverObservations.SetMeAsReceiver()
        rdoQuantiles.Checked = True

        ' plot = FALSE stops openair drawing on an external device.
        ' openair v3 returns a wrapper object, so only its $plot element is a graph.
        clsConditionalQuantileFunction.SetPackageName("openair")
        clsConditionalQuantileFunction.SetRCommand("conditionalQuantile")
        clsConditionalQuantileFunction.AddParameter("plot", "FALSE", iPosition:=11)

        clsConditionalEvalFunction.SetPackageName("openair")
        clsConditionalEvalFunction.SetRCommand("conditionalEval")
        clsConditionalEvalFunction.AddParameter("plot", "FALSE", iPosition:=11)

        clsConditionalQuantilePlotOperator.SetOperation("$", bBracketsTemp:=False)
        clsConditionalQuantilePlotOperator.bSpaceAroundOperation = False
        clsConditionalQuantilePlotOperator.AddParameter("left", clsRFunctionParameter:=clsConditionalQuantileFunction, iPosition:=0)
        clsConditionalQuantilePlotOperator.AddParameter("right", "plot", iPosition:=1)

        clsConditionalEvalPlotOperator.SetOperation("$", bBracketsTemp:=False)
        clsConditionalEvalPlotOperator.bSpaceAroundOperation = False
        clsConditionalEvalPlotOperator.AddParameter("left", clsRFunctionParameter:=clsConditionalEvalFunction, iPosition:=0)
        clsConditionalEvalPlotOperator.AddParameter("right", "plot", iPosition:=1)

        ' The assignment (last_graph or a stored graph) is done only by ucrSavePlot.
        ucrBase.clsRsyntax.SetBaseROperator(clsConditionalQuantilePlotOperator)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ' Shared controls feed both functions.
        ucrConditionalQuantilePlotSelector.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrConditionalQuantilePlotSelector.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverObservations.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrReceiverObservations.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverPredictions.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrReceiverPredictions.GetParameter(), iAdditionalPairNo:=1)
        ucrNudBin.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrNudBin.GetParameter(), iAdditionalPairNo:=1)

        ucrConditionalQuantilePlotSelector.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverObservations.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverPredictions.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudBin.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverMultipleFacet.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudMinNumPoints.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudColumns.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrInputLegendPosition.SetRCode(clsConditionalQuantileFunction, bReset)

        ucrReceiverMultipleObs.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverMultiplePred.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverStatistics.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverType.SetRCode(clsConditionalEvalFunction, bReset)

        ucrSavePlot.SetRCode(ActiveOperator(), bReset)
    End Sub

    Private Function ActiveOperator() As ROperator
        If rdoEvaluation.Checked Then
            Return clsConditionalEvalPlotOperator
        End If
        Return clsConditionalQuantilePlotOperator
    End Function

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        SetMode()
        TestOkEnabled()
    End Sub

    Private Sub SetVisibleColumnOption()
        Dim bShow As Boolean = rdoQuantiles.Checked AndAlso ucrInputLegendPosition.GetText <> "None"
        lblColumns.Visible = bShow
        ucrNudColumns.Visible = bShow
    End Sub

    ' Single place that attaches the selected mode's operator to the syntax and the save control.
    Private Sub SetMode()
        Dim bQuantiles As Boolean = rdoQuantiles.Checked

        ucrInputLegendPosition.Visible = bQuantiles
        lblLegendPositions.Visible = bQuantiles
        ucrNudMinNumPoints.Visible = bQuantiles
        lblColNumber.Visible = bQuantiles
        ucrReceiverMultipleFacet.Visible = bQuantiles
        lblTypes.Visible = bQuantiles

        ucrReceiverMultipleObs.Visible = Not bQuantiles
        lblVarObserved.Visible = Not bQuantiles
        ucrReceiverMultiplePred.Visible = Not bQuantiles
        lblVarPredicted.Visible = Not bQuantiles
        ucrReceiverStatistics.Visible = Not bQuantiles
        lblStatistics.Visible = Not bQuantiles
        ucrReceiverType.Visible = Not bQuantiles
        lblType.Visible = Not bQuantiles
        SetVisibleColumnOption()

        If bQuantiles Then
            ucrBase.clsRsyntax.SetBaseROperator(clsConditionalQuantilePlotOperator)
            ucrSavePlot.SetPrefix("cond_quantile_plot")
            Me.Size = New System.Drawing.Size(Me.Width, 489)
            ucrBase.Location = New Point(ucrBase.Location.X, 397)
            ucrSavePlot.Location = New Point(ucrSavePlot.Location.X, 370)
            cmdPlotOptions.Text = "Conditional Quantile Options"
        Else
            ucrBase.clsRsyntax.SetBaseROperator(clsConditionalEvalPlotOperator)
            ucrSavePlot.SetPrefix("cond_eval_plot")
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrSavePlot.Location = New Point(ucrSavePlot.Location.X, 401)
            cmdPlotOptions.Text = "Conditional Eval Options"
        End If
        ucrSavePlot.SetRCode(ActiveOperator(), False)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverObservations.IsEmpty() OrElse ucrReceiverPredictions.IsEmpty() OrElse Not ucrSavePlot.IsComplete _
                OrElse ucrNudBin.GetText = "" Then
            ucrBase.OKEnabled(False)
        ElseIf rdoQuantiles.Checked AndAlso (ucrNudMinNumPoints.GetText = "" OrElse ucrNudColumns.GetText = "") Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObservations.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverPredictions.ControlContentsChanged, ucrReceiverStatistics.ControlContentsChanged, ucrNudBin.ControlContentsChanged, ucrNudMinNumPoints.ControlContentsChanged, ucrNudColumns.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetMode()
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub ucrInputLegendPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLegendPosition.ControlValueChanged
        SetVisibleColumnOption()
    End Sub
End Class
