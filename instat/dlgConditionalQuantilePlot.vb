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
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctStatistics As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 3

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

        ' ttConditionalQuatilePlot.SetToolTip(ucrNudMinNumPoints.txtInput, "Min.bin can also be length of two e.g. min.bin = c(10,20)")

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

        ucrPnlOptions.AddRadioButton(rdoQuantiles)
        ucrPnlOptions.AddRadioButton(rdoEvaluation)
        ucrPnlOptions.AddFunctionNamesCondition(rdoQuantiles, "conditionalQuantile")
        ucrPnlOptions.AddFunctionNamesCondition(rdoEvaluation, "conditionalEval")
        ucrPnlOptions.AddToLinkedControls({ucrInputLegendPosition, ucrNudMinNumPoints, ucrReceiverMultipleFacet}, {rdoQuantiles}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleObs, ucrReceiverMultiplePred, ucrReceiverStatistics, ucrReceiverType}, {rdoEvaluation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLegendPosition.SetLinkedDisplayControl(lblLegendPositions)
        ucrNudMinNumPoints.SetLinkedDisplayControl(lblColNumber)
        ucrReceiverMultipleFacet.SetLinkedDisplayControl(lblTypes)
        ucrReceiverMultipleObs.SetLinkedDisplayControl(lblVarObserved)
        ucrReceiverMultiplePred.SetLinkedDisplayControl(lblVarPredicted)
        ucrReceiverStatistics.SetLinkedDisplayControl(lblStatistics)
        ucrReceiverType.SetLinkedDisplayControl(lblType)

        ucrSavePlot.SetPrefix("cond_quantile_plot")
        ucrSavePlot.SetCheckBoxText("Save Graph")
        ucrSavePlot.SetIsComboBox()
        ucrSavePlot.SetSaveTypeAsGraph()
        ucrSavePlot.SetDataFrameSelector(ucrConditionalQuantilePlotSelector.ucrAvailableDataFrames)
        ucrSavePlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsConditionalQuantileFunction = New RFunction
        clsConditionalEvalFunction = New RFunction

        ucrConditionalQuantilePlotSelector.Reset()
        ucrSavePlot.Reset()
        ucrReceiverObservations.SetMeAsReceiver()
        SetVisibleColumnOption()

        clsConditionalQuantileFunction.SetPackageName("openair")
        clsConditionalQuantileFunction.SetRCommand("conditionalQuantile")

        clsConditionalEvalFunction.SetPackageName("openair")
        clsConditionalEvalFunction.SetRCommand("conditionalEval")

        clsConditionalEvalFunction.SetAssignTo("last_graph", strTempDataframe:=ucrConditionalQuantilePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsConditionalQuantileFunction.SetAssignTo("last_graph", strTempDataframe:=ucrConditionalQuantilePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsConditionalQuantileFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrConditionalQuantilePlotSelector.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrConditionalQuantilePlotSelector.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverObservations.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrReceiverObservations.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverPredictions.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrReceiverPredictions.GetParameter(), iAdditionalPairNo:=1)
        ucrNudBin.AddAdditionalCodeParameterPair(clsConditionalEvalFunction, ucrNudBin.GetParameter(), iAdditionalPairNo:=1)

        ucrConditionalQuantilePlotSelector.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverObservations.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverPredictions.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrReceiverMultipleFacet.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudBin.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudMinNumPoints.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrNudColumns.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrInputLegendPosition.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrSavePlot.SetRCode(clsConditionalQuantileFunction, bReset)
        ucrSavePlot.AddAdditionalRCode(clsConditionalEvalFunction)
        ucrReceiverMultipleObs.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverMultiplePred.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverStatistics.SetRCode(clsConditionalEvalFunction, bReset)
        ucrReceiverType.SetRCode(clsConditionalEvalFunction, bReset)

        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub SetVisibleColumnOption()
        If ucrInputLegendPosition.GetText = "None" Then
            lblColumns.Visible = False
            ucrNudColumns.Visible = False
        Else
            lblColumns.Visible = True
            ucrNudColumns.Visible = True
        End If
    End Sub

    Private Sub TestOkEnabled()
        If rdoQuantiles.Checked AndAlso Not ucrReceiverObservations.IsEmpty() AndAlso Not ucrReceiverPredictions.IsEmpty() AndAlso ucrSavePlot.IsComplete AndAlso ucrNudBin.GetText <> "" AndAlso ucrNudColumns.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf rdoEvaluation.Checked AndAlso Not ucrReceiverObservations.IsEmpty() AndAlso Not ucrReceiverPredictions.IsEmpty() AndAlso ucrSavePlot.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverObservations_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverObservations.ControlContentsChanged, ucrSavePlot.ControlContentsChanged, ucrReceiverPredictions.ControlContentsChanged, ucrReceiverStatistics.ControlContentsChanged, ucrNudBin.ControlContentsChanged, ucrNudColumns.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoQuantiles.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsConditionalQuantileFunction)
            ucrSavePlot.SetPrefix("cond_quantile_plot")
            Me.Size = New System.Drawing.Size(Me.Width, 489)
            ucrBase.Location = New Point(ucrBase.Location.X, 397)
            ucrSavePlot.Location = New Point(ucrSavePlot.Location.X, 370)
            cmdPlotOptions.Text = "Conditional Quantile Options"
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsConditionalEvalFunction)
            ucrSavePlot.SetPrefix("cond_eval_plot")
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrSavePlot.Location = New Point(ucrSavePlot.Location.X, 401)
            cmdPlotOptions.Text = "Conditional Eval Options"
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrInputLegendPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLegendPosition.ControlValueChanged
        SetVisibleColumnOption()
    End Sub
End Class
