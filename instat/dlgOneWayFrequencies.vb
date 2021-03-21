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
Public Class dlgOneWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjMiscFrq As New RFunction
    Private clsSjPlot, clsPlotGrid, clsSjPlotList As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing

    Private Sub dlgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumn()
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 518

        ucrReceiverOneWayFreq.SetParameter(New RParameter("x", 0))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        ucrReceiverOneWayFreq.bForceAsDataFrame = True
        ucrReceiverOneWayFreq.Selector = ucrSelectorOneWayFreq
        ucrReceiverOneWayFreq.strSelectorHeading = "Variables"
        ucrReceiverOneWayFreq.bDropUnusedFilterLevels = True
        'temp fix to bug in sjPlot
        ucrReceiverOneWayFreq.bRemoveLabels = True

        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 1))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.Selector = ucrSelectorOneWayFreq
        ucrReceiverWeights.SetDataType("numeric")
        ucrReceiverWeights.strSelectorHeading = "Numerics"

        ucrPnlSort.SetParameter(New RParameter("sort.frq", 2))
        ucrPnlSort.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoAscendingFrequencies, Chr(34) & "asc" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoDescendingFrequencies, Chr(34) & "desc" & Chr(34))
        ucrPnlSort.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlFrequencies.AddRadioButton(rdoTable)
        ucrPnlFrequencies.AddRadioButton(rdoGraph)
        ucrPnlFrequencies.AddRadioButton(rdoBoth)

        'setting rdoGraph and rdoTable
        ucrPnlFrequencies.AddFunctionNamesCondition(rdoTable, "frq")
        ucrPnlFrequencies.AddFunctionNamesCondition(rdoGraph, "plot_grid")
        'TODO be able to have conditions across multiple functions

        ucrPnlOutput.SetParameter(New RParameter("out", 7))
        ucrPnlOutput.AddRadioButton(rdoAsText, Chr(34) & "txt" & Chr(34))
        ucrPnlOutput.AddRadioButton(rdoAsHtml, Chr(34) & "viewer" & Chr(34))

        ucrPnlFrequencies.AddToLinkedControls(ucrChkFlip, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencies.AddToLinkedControls(ucrSaveGraph, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencies.AddToLinkedControls(ucrPnlOutput, {rdoTable, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOutput.SetLinkedDisplayControl(grpOutput)

        ucrNudGroups.SetParameter(New RParameter("auto.grp", 9))
        ucrNudGroups.SetMinMax(2, 100)
        ucrNudGroups.Increment = 5

        ucrChkGroupData.SetParameter(ucrNudGroups.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkGroupData.SetText("Group Data")
        ucrChkGroupData.AddToLinkedControls(ucrNudGroups, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkGroupData.AddParameterPresentCondition(True, "auto.group")
        ucrChkGroupData.AddParameterPresentCondition(False, "auto.group", False)

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 10))
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrSaveGraph.SetPrefix("one_way_freq")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOneWayFreq.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsSjMiscFrq = New RFunction
        clsSjPlot = New RFunction
        clsPlotGrid = New RFunction

        ucrSelectorOneWayFreq.Reset()
        ucrReceiverOneWayFreq.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsPlotGrid.SetPackageName("sjPlot")
        clsPlotGrid.SetRCommand("plot_grid")
        clsPlotGrid.AddParameter("x", clsRFunctionParameter:=clsSjPlotList)

        clsSjPlotList.SetRCommand("list")
        clsSjPlotList.AddParameter("x", clsRFunctionParameter:=clsSjPlot, iPosition:=0)

        clsSjMiscFrq.SetPackageName("sjmisc")
        clsSjMiscFrq.SetRCommand("frq")
        clsSjMiscFrq.AddParameter("out", Chr(34) & "txt" & Chr(34), iPosition:=7)

        clsSjPlot.SetPackageName("sjPlot")
        clsSjPlot.SetRCommand("plot_frq")
        clsPlotGrid.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneWayFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjMiscFrq)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrReceiverWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrReceiverWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrPnlSort.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("sort.frq", 3), iAdditionalPairNo:=1)
        ucrNudGroups.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("auto.group", 9), iAdditionalPairNo:=1)
        ucrChkGroupData.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("auto.group", 9), iAdditionalPairNo:=1)
        ucrReceiverOneWayFreq.AddAdditionalCodeParameterPair(clsSjPlot, New RParameter("data", 0), iAdditionalPairNo:=1)

        ucrReceiverWeights.SetRCode(clsSjMiscFrq, bReset)
        ucrReceiverOneWayFreq.SetRCode(clsSjMiscFrq, bReset)
        If bReset OrElse Not rdoBoth.Checked Then
            ucrPnlFrequencies.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If

        ucrPnlOutput.SetRCode(clsSjMiscFrq, bReset)
        ucrChkWeights.SetRCode(clsSjMiscFrq, bReset)
        ucrPnlSort.SetRCode(clsSjMiscFrq, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)
        ucrChkGroupData.SetRCode(clsSjMiscFrq, bReset)
        ucrNudGroups.SetRCode(clsSjMiscFrq, bReset)
        ucrSaveGraph.SetRCode(clsPlotGrid, bReset)
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorOneWayFreq.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumns IsNot Nothing AndAlso strDefaultColumns.Count > 0 Then
            For Each strVar As String In strDefaultColumns
                ucrReceiverOneWayFreq.Add(strVar, strDefaultDataFrame)
            Next
        End If
        strDefaultDataFrame = ""
        strDefaultColumns = Nothing
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneWayFreq.IsEmpty() AndAlso ((ucrChkGroupData.Checked AndAlso ucrNudGroups.GetText <> "") OrElse Not ucrChkGroupData.Checked) AndAlso ucrSaveGraph.IsComplete() Then
            If ucrChkWeights.Checked Then
                If Not ucrReceiverWeights.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strGraph As String
        Dim strTempScript As String = ""
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String

        If rdoBoth.Checked Then
            bIsAssigned = clsPlotGrid.bIsAssigned
            bToBeAssigned = clsPlotGrid.bToBeAssigned
            strAssignTo = clsPlotGrid.strAssignTo

            strGraph = clsPlotGrid.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)

            clsPlotGrid.bIsAssigned = bIsAssigned
            clsPlotGrid.bToBeAssigned = bToBeAssigned
            clsPlotGrid.strAssignTo = strAssignTo
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverOneWayFreq.SetMeAsReceiver()
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOneWayFrequencies.SetRFunction(clsSjMiscFrq, clsSjPlot, clsPlotGrid, clsSjPlotList, bResetSubdialog)
        bResetSubdialog = False
        sdgOneWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlFrequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFrequencies.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub SetBaseFunction()
        If rdoTable.Checked OrElse rdoBoth.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjMiscFrq)
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPlotGrid)
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ucrReceiverOneWayFreq_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlValueChanged
        If ucrReceiverOneWayFreq.lstSelectedVariables.Items.Count > 1 Then
            clsPlotGrid.RemoveParameterByName("x")
            clsPlotGrid.AddParameter("x", clsRFunctionParameter:=clsSjPlot)
        Else
            clsPlotGrid.RemoveParameterByName("x")
            clsPlotGrid.AddParameter("x", clsRFunctionParameter:=clsSjPlotList)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrNudGroups.ControlContentsChanged, ucrChkGroupData.ControlContentsChanged, ucrReceiverOneWayFreq.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class