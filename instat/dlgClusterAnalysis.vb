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
Public Class dlgClusterAnalysis
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsPamFunction As New RFunction
    Private clsAgnesFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsFvizClusterFunction As New RFunction
    Private clsFvizPamFunction As New RFunction
    Private clsFvizDendFunction As New RFunction
    Private clsFvizAgnesFunction As New RFunction
    Private bResetRCode As Boolean = True
    Private Sub dlgClusterAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        Dim dctMetric As New Dictionary(Of String, String)
        Dim dctMethod As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.iCallType = 2

        ucrReceiverClusterData.SetParameterIsRFunction()
        ucrReceiverClusterData.Selector = ucrSelectorClusterData
        ucrReceiverClusterData.SetMeAsReceiver()
        ucrReceiverClusterData.SetDataType("numeric")

        ucrSelectorClusterData.SetParameterIsrfunction()
        ucrSelectorClusterData.SetParameter(New RParameter("x, 0"))

        ucrPnlClusterData.AddRadioButton(rdoPartitioningData)
        ucrPnlClusterData.AddRadioButton(rdoHierarchicalData)
        ucrPnlClusterData.AddParameterValuesCondition(rdoHierarchicalData, "fvizdend", "True")
        ucrPnlClusterData.AddParameterValuesCondition(rdoPartitioningData, "fvizdend", "False")

        ucrInputMetric.SetParameter(New RParameter("metric", 3))
        dctMetric.Add("euclidean", Chr(34) & "euclidean" & Chr(34))
        dctMetric.Add("manhattan", Chr(34) & "manhattan" & Chr(34))
        ucrInputMetric.SetItems(dctMetric)
        ucrInputMetric.SetRDefault(Chr(34) & "euclidean" & Chr(34))

        ucrChkMetric.SetText("Metric:")
        ucrChkMetric.AddToLinkedControls(ucrInputMetric, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMetric.AddFunctionNamesCondition(True, {"pam", "agnes"})

        ucrChkPartitionPlot.SetText("Partition Plot")
        ucrChkPartitionPlot.AddParameterValueFunctionNamesCondition(True, "dend", "False")
        ucrChkPartitionPlot.AddParameterValueFunctionNamesCondition(False, "dend", "True")
        ucrChkPartitionPlot.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkHierarcPlot.SetText("Hierarch Plot")
        ucrChkHierarcPlot.AddParameterValueFunctionNamesCondition(True, "fviz", "False")
        ucrChkHierarcPlot.AddParameterValueFunctionNamesCondition(False, "fviz", "True")
        ucrChkHierarcPlot.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlSelectData.AddRadioButton(rdoNumericVariables)
        ucrPnlSelectData.AddRadioButton(rdoDataFrame)
        ucrPnlSelectData.AddParameterValuesCondition(rdoDataFrame, "checked", "whole")
        ucrPnlSelectData.AddParameterValuesCondition(rdoNumericVariables, "checked", "selected")

        ucrPnlSelectData.AddToLinkedControls(ucrReceiverClusterData, {rdoNumericVariables}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStand.SetParameter(New RParameter("stand", 4))
        ucrChkStand.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStand.SetRDefault("FALSE")
        ucrChkStand.SetText("Stand:")

        ucrChkCluster.SetText("PAM Cluster")
        ucrNudPamCluster.SetMinMax(2, Integer.MaxValue)
        ucrChkCluster.AddToLinkedControls(ucrLinked:=ucrNudPamCluster, objValues:={True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCluster.AddParameterPresentCondition(True, "k")
        ucrChkCluster.AddParameterPresentCondition(False, "k", False)

        ucrInputMethod.SetParameter(New RParameter("method", 4))
        dctMethod.Add("average", Chr(34) & "average" & Chr(34))
        dctMethod.Add("single", Chr(34) & "single" & Chr(34))
        dctMethod.Add("complete", Chr(34) & "complete" & Chr(34))
        dctMethod.Add("ward", Chr(34) & "ward" & Chr(34))
        dctMethod.Add("weighted", Chr(34) & "weighted" & Chr(34))
        dctMethod.Add("flexible", Chr(34) & "flexible" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetRDefault(Chr(34) & "average" & Chr(34))

        ucrChkMethod.SetText("Method")
        ucrChkMethod.AddToLinkedControls(ucrInputMethod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMethod.AddFunctionNamesCondition(True, "agnes")

        ucrPnlClusterData.AddToLinkedControls(ucrChkMetric, {rdoHierarchicalData, rdoPartitioningData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
        ucrPnlClusterData.AddToLinkedControls({ucrChkMethod, ucrChkHierarcPlot}, {rdoHierarchicalData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
        ucrPnlClusterData.AddToLinkedControls(ucrChkCluster, {rdoPartitioningData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlClusterData.AddToLinkedControls(ucrChkPartitionPlot, {rdoPartitioningData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)

        ucrSaveGraph.SetPrefix("Cluster_plot")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorClusterData.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrSaveCluster.SetSaveTypeAsModel()
        ucrSaveCluster.SetDataFrameSelector(ucrSelectorClusterData.ucrAvailableDataFrames)
        ucrSaveCluster.SetLabelText("Clusters:")
        ucrSaveCluster.SetPrefix("cluster")
        ucrSaveCluster.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsAgnesFunction = New RFunction
        clsPamFunction = New RFunction
        clsDummyFunction = New RFunction
        clsFvizClusterFunction = New RFunction
        clsFvizPamFunction = New RFunction
        clsFvizAgnesFunction = New RFunction
        clsFvizDendFunction = New RFunction

        ucrSelectorClusterData.Reset()
        ucrSaveGraph.Reset()
        ucrSaveCluster.Reset()

        clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)
        clsDummyFunction.AddParameter("fvizdend", "False", iPosition:=1)
        clsDummyFunction.AddParameter("fviz", "False", iPosition:=2)
        clsDummyFunction.AddParameter("dend", "False", iPosition:=3)

        clsPamFunction.SetRCommand("pam")
        clsPamFunction.SetPackageName("cluster")

        clsAgnesFunction.SetPackageName("cluster")
        clsAgnesFunction.SetRCommand("agnes")

        clsFvizPamFunction.SetRCommand("pam")
        clsFvizPamFunction.SetPackageName("cluster")

        clsFvizAgnesFunction.SetRCommand("agnes")
        clsFvizAgnesFunction.SetPackageName("cluster")

        clsFvizClusterFunction.SetRCommand("fviz_cluster")
        clsFvizClusterFunction.SetPackageName("factoextra")
        clsFvizClusterFunction.AddParameter("object", clsRFunctionParameter:=clsFvizPamFunction, iPosition:=0)
        clsFvizClusterFunction.AddParameter("star.plot", Chr(34) & "TRUE" & Chr(34), iPosition:=2)
        clsFvizClusterFunction.AddParameter("repel", Chr(34) & "TRUE" & Chr(34), iPosition:=3)

        clsFvizDendFunction.SetRCommand("fviz_dend")
        clsFvizDendFunction.SetPackageName("factoextra")
        clsFvizDendFunction.AddParameter("x", clsRFunctionParameter:=clsFvizAgnesFunction, iPosition:=0)
        clsFvizDendFunction.AddParameter("k", "4", iPosition:=2)
        clsFvizDendFunction.AddParameter("cex", "0.6", iPosition:=3)

        clsFvizDendFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClusterData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_graph")
        clsPamFunction.SetAssignTo("last_cluster", strTempDataframe:=ucrSelectorClusterData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_cluster")
        clsAgnesFunction.SetAssignTo("last_cluster", strTempDataframe:=ucrSelectorClusterData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_cluster")
        ucrBase.clsRsyntax.SetBaseRFunction(clsPamFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bResetRCode = False
        ucrReceiverClusterData.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("x", 0), 1)
        ucrChkStand.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("stand", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrInputMetric.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("metric", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrChkCluster.AddAdditionalCodeParameterPair(clsFvizPamFunction, New RParameter("k", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrInputMetric.AddAdditionalCodeParameterPair(clsFvizAgnesFunction, New RParameter("metric", iNewPosition:=1), iAdditionalPairNo:=2)
        ucrChkStand.AddAdditionalCodeParameterPair(clsFvizAgnesFunction, New RParameter("stand", iNewPosition:=2), iAdditionalPairNo:=2)
        ucrSaveGraph.AddAdditionalRCode(clsFvizClusterFunction, iAdditionalPairNo:=1)
        ucrInputMethod.AddAdditionalCodeParameterPair(clsFvizAgnesFunction, New RParameter("method", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrInputMetric.AddAdditionalCodeParameterPair(clsFvizPamFunction, New RParameter("metric", iNewPosition:=1), iAdditionalPairNo:=3)
        ucrChkStand.AddAdditionalCodeParameterPair(clsFvizPamFunction, New RParameter("stand", iNewPosition:=1), iAdditionalPairNo:=3)

        ucrChkStand.SetRCode(clsPamFunction, bReset)
        ucrChkCluster.SetRCode(clsPamFunction, bReset)
        ucrChkMethod.SetRCode(clsAgnesFunction, bReset)
        ucrInputMetric.SetRCode(clsPamFunction, bReset)
        ucrInputMethod.SetRCode(clsAgnesFunction, bReset)
        ucrSaveGraph.SetRCode(clsFvizDendFunction, bReset)
        ucrPnlClusterData.SetRCode(clsDummyFunction, bReset)
        ucrPnlSelectData.SetRCode(clsDummyFunction, bReset)
        ucrSaveCluster.SetRCode(clsPamFunction, bReset)
        ucrSaveCluster.AddAdditionalRCode(clsFvizPamFunction, bReset)
        ucrSaveCluster.AddAdditionalRCode(clsFvizAgnesFunction, bReset)
        ucrSaveCluster.SetRCode(clsAgnesFunction, bReset)
        bResetRCode = True
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorClusterData.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" _
            OrElse (rdoNumericVariables.Checked AndAlso ucrReceiverClusterData.IsEmpty) OrElse
            (rdoPartitioningData.Checked AndAlso Not ucrChkCluster.Checked) OrElse
            (rdoHierarchicalData.Checked AndAlso Not ucrChkMethod.Checked) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If bResetRCode Then
            If rdoPartitioningData.Checked Then
                clsDummyFunction.AddParameter("fvizdend", "False", iPosition:=1)
                If ucrChkPartitionPlot.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFvizClusterFunction)
                    ucrBase.clsRsyntax.iCallType = 3
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(clsPamFunction)
                    ucrBase.clsRsyntax.iCallType = 2
                End If
            ElseIf rdoHierarchicalData.Checked Then
                clsDummyFunction.AddParameter("fvizdend", "True", iPosition:=1)
                If ucrChkHierarcPlot.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFvizDendFunction)
                    ucrBase.clsRsyntax.iCallType = 3
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(clsAgnesFunction)
                    ucrBase.clsRsyntax.iCallType = 2
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveDataHideOptionsButtons()
        Dim bVisible As Boolean = rdoNumericVariables.Checked
        ucrSelectorClusterData.lstAvailableVariable.Visible = bVisible
        ucrSelectorClusterData.btnAdd.Visible = bVisible
        ucrSelectorClusterData.btnDataOptions.Visible = bVisible
    End Sub

    Private Sub ChangeDataParameter()
        If bResetRCode Then
            If rdoPartitioningData.Checked Then
                If rdoDataFrame.Checked Then
                    clsFvizPamFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                    clsPamFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                ElseIf rdoNumericVariables.Checked Then
                    clsFvizPamFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
                    clsPamFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
                End If
            ElseIf rdoHierarchicalData.Checked Then
                If rdoDataFrame.Checked Then
                    clsFvizAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                    clsAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                Else
                    clsAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
                    clsFvizAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
                End If
            End If
            If rdoDataFrame.Checked Then
                clsDummyFunction.AddParameter("checked", "whole", iPosition:=0)
            Else
                clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)
            End If
        End If
    End Sub

    Private Sub ucrPnlSelectData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged
        AddRemoveDataHideOptionsButtons()
        ChangeDataParameter()
    End Sub

    Private Sub ucrReceiverClusterData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverClusterData.ControlValueChanged
        ChangeDataParameter()
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverClusterData.ControlContentsChanged, ucrSelectorClusterData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrInputMethod.ControlContentsChanged, ucrChkMetric.ControlContentsChanged, ucrChkStand.ControlContentsChanged, ucrChkMethod.ControlContentsChanged, ucrChkCluster.ControlContentsChanged, ucrPnlClusterData.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlClusterData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClusterData.ControlValueChanged
        SetBaseFunction()
        ChangeDataParameter()
    End Sub

    Private Sub ucrChkCluster_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCluster.ControlValueChanged, ucrNudPamCluster.ControlValueChanged
        If ucrChkCluster.Checked Then
            clsPamFunction.AddParameter("k", ucrNudPamCluster.GetText, iPosition:=1)
            clsFvizPamFunction.AddParameter("k", ucrNudPamCluster.GetText, iPosition:=1)
        End If
    End Sub

    Private Sub ucrChkPartitionPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPartitionPlot.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrChkHierarcPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkHierarcPlot.ControlValueChanged
        SetBaseFunction()
    End Sub
End Class