' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations

Public Class dlgOneWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjtFreq As New RFunction
    Private clsSjpFrq As New RFunction

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
        bReset = False
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverOneWayFreq.SetRCode(clsSjtFreq, bReset)
        ucrReceiverWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlFrequencies.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkWeights.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSort.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)
        ucrChkGroupData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNudGroups.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 

        ucrReceiverOneWayFreq.SetParameter(New RParameter("data", 1))
        ucrReceiverOneWayFreq.SetParameterIsRFunction()
        ucrReceiverOneWayFreq.Selector = ucrSelectorOneWayFreq

        ucrReceiverWeights.Selector = ucrSelectorOneWayFreq
        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 2))
        ucrReceiverWeights.SetParameterIsRFunction()
        ucrReceiverWeights.SetDataType("numeric")

        ucrPnlSort.SetParameter(New RParameter("sort.frq", 6))
        ucrPnlSort.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoAscending, Chr(34) & "asc" & Chr(34))
        ucrPnlSort.AddRadioButton(rdoDescending, Chr(34) & "desc" & Chr(34))
        ucrPnlSort.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlFrequencies.AddRadioButton(rdoTable)
        ucrPnlFrequencies.AddRadioButton(rdoGraph)
        ucrPnlFrequencies.AddFunctionNamesCondition(rdoTable, "sjt.frq")
        ucrPnlFrequencies.AddFunctionNamesCondition(rdoGraph, "sjp.frq")
        ucrPnlFrequencies.AddToLinkedControls(ucrChkFlip, {rdoGraph}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrNudGroups.SetParameter(New RParameter("auto.group"))
        ucrNudGroups.SetMinMax(2, 100)
        ucrNudGroups.Increment = 5

        ucrChkGroupData.SetParameter(ucrNudGroups.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkGroupData.SetText("Group Data")
        ucrChkGroupData.AddToLinkedControls(ucrNudGroups, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkGroupData.AddFunctionNamesCondition(True, {"sjt.frq", "sjp.frq"})
        ucrChkGroupData.bUpdateRCodeFromControl = True

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 1))
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlip.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction

        ucrSelectorOneWayFreq.Reset()
        ucrReceiverOneWayFreq.SetMeAsReceiver()

        clsSjtFreq.SetRCommand("sjt.frq")
        clsSjtFreq.AddParameter("show.summary", "FALSE")
        clsSjtFreq.AddParameter("skip.zero", "FALSE")
        clsSjtFreq.AddParameter("digits", 0)

        clsSjpFrq.SetRCommand("sjp.frq")
        clsSjpFrq.AddParameter("sort.frq", Chr(34) & "none" & Chr(34))
        clsSjpFrq.AddParameter("type", Chr(34) & "bar" & Chr(34))
        clsSjpFrq.AddParameter("show.prc", "TRUE")
        clsSjpFrq.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorOneWayFreq.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrReceiverOneWayFreq.AddAdditionalCodeParameterPair(clsSjpFrq, New RParameter("var.cnt", 1))
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjpFrq, New RParameter("weight.by", 3))
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjpFrq, ucrChkWeights.GetParameter())
        ucrPnlSort.AddAdditionalCodeParameterPair(clsSjpFrq, New RParameter("sort.frq", 5))
        ucrNudGroups.AddAdditionalCodeParameterPair(clsSjpFrq, New RParameter("auto.group", 35))

        ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
        bResetSubdialog = True
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverOneWayFreq.IsEmpty() Then
            If (Not ucrChkWeights.Checked) AndAlso (Not ucrChkGroupData.Checked) Then
                ucrBase.OKEnabled(True)
            ElseIf ucrChkWeights.Checked Then
                If Not ucrReceiverWeights.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf ucrChkGroupData.Checked Then

                If ucrNudGroups.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoTable.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjtFreq)
            'ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjpFrq)
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strGraph As String
        Dim strTempScript As String = ""

        If rdoTable.Checked AndAlso rdoGraph.Checked Then
            strGraph = clsSjpFrq.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrNudGroups.ControlValueChanged, ucrChkGroupData.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgOneWayFrequencies.SetRFunction(clsSjtFreq, clsSjpFrq, bResetSubdialog)
        bResetSubdialog = False
        sdgOneWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub
End Class