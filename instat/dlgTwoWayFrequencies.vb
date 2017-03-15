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

Imports instat.Translations
Public Class dlgTwoWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjtFreq As New RFunction
    Private clsSjpFrq As New RFunction
    Private Sub grpFrequencies_Enter(sender As Object, e As EventArgs) Handles grpFrequencies.Enter
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
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverRowFactor.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkTable.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkGraph.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkWeights.SetRCode(clsSjtFreq, bReset)
        ucrChkWeights.SetRCode(clsSjpFrq, bReset)
        ucrChkFlip.SetRCode(clsSjpFrq, bReset)
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ' ucrBase.iHelpTopicID = 
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.SetMeAsReceiver()
        ucrReceiverRowFactor.SetDataType("numeric")
        ucrReceiverRowFactor.SetDataType("numeric")
        ucrReceiverColumnFactor.SetParameter(New RParameter("", 1))
        ucrReceiverColumnFactor.SetParameterIsRFunction()
        ucrReceiverRowFactor.SetParameter(New RParameter("", 1))
        ucrReceiverRowFactor.SetParameterIsRFunction()


        ucrPnlFrequencies.SetParameter(New RParameter(""))
        ucrPnlFrequencies.AddRadioButton(rdoCount, Chr(34) & "" & Chr(34))
        ucrPnlFrequencies.AddRadioButton(rdoRow, Chr(34) & "" & Chr(34))
        ucrPnlFrequencies.AddRadioButton(rdoColumn, Chr(34) & "" & Chr(34))
        ucrPnlFrequencies.AddRadioButton(rdoCell, Chr(34) & "" & Chr(34))
        ucrPnlFrequencies.SetRDefault(Chr(34) & "" & Chr(34))


        ucrChkTable.SetText("Table")
        ucrChkWeights.SetText("Weights")
        '   ucrChkweights.SetParameter(New RParameter("weight.by"))

        ucrChkGraph.SetText("Graph")

        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetParameter(New RParameter("coord.flip"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetRDefault("FALSE")

        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Private Sub SetDefaults()
        clsSjtFreq = New RFunction
        clsSjpFrq = New RFunction
        ucrSelectorTwoWayFrequencies.Reset()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverRowFactor.IsEmpty() AndAlso Not ucrReceiverColumnFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ChangeBaseFunction()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub


    'Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
    '    If ucrChkTable.Checked Then
    '        frmMain.clsRLink.RunScript(clsSjtFreq.ToScript(), iCallType:=2)
    '    End If
    'End Sub
    'Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlValueChanged, ucrChkTable.ControlValueChanged, ucrChkGraph.ControlValueChanged, ucrPnlSort.ControlValueChanged
    '    ChangeBaseFunction()
    'End Sub

    'Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneWayFreq.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
    '    TestOkEnabled()
    'End Sub

End Class
