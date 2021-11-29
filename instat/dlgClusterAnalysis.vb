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
            ucrPnlClusterData.AddFunctionNamesCondition(rdoPartitioningData, {"pam"})
            ucrPnlClusterData.AddFunctionNamesCondition(rdoHierarchicalData, {"agnes"})

            ucrInputMetric.SetParameter(New RParameter("metric", 3))
            dctMetric.Add("euclidean", Chr(34) & "euclidean" & Chr(34))
            dctMetric.Add("manhattan", Chr(34) & "manhattan" & Chr(34))
            ucrInputMetric.SetItems(dctMetric)
            ucrInputMetric.SetRDefault(Chr(34) & "euclidean" & Chr(34))

            ucrChkMetric.SetText("Metric:")
            ucrChkMetric.AddToLinkedControls(ucrInputMetric, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
            ucrChkMetric.AddFunctionNamesCondition(True, {"pam", "agnes"})

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
            ucrPnlClusterData.AddToLinkedControls(ucrChkMethod, {rdoHierarchicalData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
            ucrPnlClusterData.AddToLinkedControls(ucrChkCluster, {rdoPartitioningData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        End Sub
        Private Sub SetDefaults()
            clsAgnesFunction = New RFunction
            clsPamFunction = New RFunction
            clsDummyFunction = New RFunction

            ucrSelectorClusterData.Reset()
            clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)

            clsPamFunction.SetRCommand("pam")
            clsPamFunction.SetPackageName("cluster")

            clsAgnesFunction.SetPackageName("cluster")
            clsAgnesFunction.SetRCommand("agnes")

            ucrBase.clsRsyntax.SetBaseRFunction(clsPamFunction)

        End Sub

        Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverClusterData.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("x", 0), 1)
        ucrChkStand.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("stand", iNewPosition:=1), iAdditionalPairNo:=1)
            ucrChkMetric.AddAdditionalCodeParameterPair(clsAgnesFunction, New RParameter("metric", iNewPosition:=1), iAdditionalPairNo:=1)

            ucrChkStand.SetRCode(clsPamFunction, bReset)
            ucrChkCluster.SetRCode(clsPamFunction, bReset)
        ucrChkMethod.SetRCode(clsAgnesFunction, bReset)
        ucrInputMetric.SetRCode(clsPamFunction, bReset)
            ucrInputMethod.SetRCode(clsAgnesFunction, bReset)

            ucrReceiverClusterData.SetRCode(clsPamFunction, bReset)
            ucrPnlClusterData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSelectData.SetRCode(clsDummyFunction, bReset)
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
            If rdoPartitioningData.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsPamFunction)
            ElseIf rdoHierarchicalData.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsAgnesFunction)
            End If
        End Sub
        Private Sub AddRemoveDataHideOptionsButtons()
            Dim bVisible As Boolean = rdoNumericVariables.Checked
            ucrSelectorClusterData.lstAvailableVariable.Visible = bVisible
            ucrSelectorClusterData.btnAdd.Visible = bVisible
            ucrSelectorClusterData.btnDataOptions.Visible = bVisible
        End Sub

        Private Sub ChangeDataParameter()
            If rdoPartitioningData.Checked Then
                If rdoDataFrame.Checked Then
                    clsDummyFunction.AddParameter("checked", "whole", iPosition:=0)
                    clsPamFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                Else
                    clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)
                    clsPamFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
                End If
            ElseIf rdoHierarchicalData.Checked Then
            If rdoDataFrame.Checked Then
                clsAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorClusterData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

            Else
                clsAgnesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverClusterData.GetVariables, iPosition:=0)
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
        Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverClusterData.ControlContentsChanged, ucrSelectorClusterData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrInputMethod.ControlContentsChanged, ucrChkMetric.ControlContentsChanged, ucrChkStand.ControlContentsChanged, ucrChkMethod.ControlContentsChanged, ucrChkCluster.ControlContentsChanged
            TestOkEnabled()
        End Sub

        Private Sub ucrPnlClusterData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClusterData.ControlValueChanged
            SetBaseFunction()
        ChangeDataParameter()
    End Sub

        Private Sub ucrChkCluster_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCluster.ControlValueChanged, ucrNudPamCluster.ControlValueChanged
            If ucrChkCluster.Checked Then
                clsPamFunction.AddParameter("k", ucrNudPamCluster.GetText, iPosition:=1)
            End If
        End Sub
    End Class