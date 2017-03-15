'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgRandomSubsets
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrame, clsSetSeed, clsSample, clsReplicate As New RFunction

    Private Sub dlgRandomSubsets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 65

        'ucrReceiver
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        ucrReceiverSelected.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelected.SetParameter(New RParameter("x", 2))
        ucrReceiverSelected.SetParameterIsRFunction()

        ucrChkSetSeed.AddFunctionNamesCondition(False, "set.seed")
        'Set seed
        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.SetMinMax(1, Integer.MaxValue)
        ucrChkSetSeed.SetText("Seed")

        ucrNudSampleSize.SetParameter(New RParameter("size", 2))

        'Replace checkbox
        ucrChkWithReplacement.SetParameter(New RParameter("replace", 1))
        ucrChkWithReplacement.SetText("With Replacement")
        ucrChkWithReplacement.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithReplacement.SetRDefault("FALSE")

        'Number of columns
        ucrNudNumberOfColumns.SetParameter(New RParameter("n", 2))
        ucrNudNumberOfColumns.SetMinMax(1, Integer.MaxValue)

        'Linking checkox and nud
        ucrChkSetSeed.AddToLinkedControls(ucrLinked:=ucrNudSetSeed, objValues:={True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrNewDataframe
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorRandomSubsets.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")

    End Sub

    Private Sub SetDefaults()
        'reset
        ucrSelectorRandomSubsets.Reset()
        ucrNewDataframe.Reset()
        NewDefaultName()
        ReplaceParameters()

        'sample function
        clsSample = New RFunction
        clsSample.SetRCommand("sample")
        ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        clsSample.AddParameter("size", ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)

        'setseed fuction
        clsSetSeed = New RFunction
        clsSetSeed.SetRCommand("set.seed")
        clsSetSeed.AddParameter("seed", 1)

        'replicate func setting
        clsReplicate = New RFunction
        clsReplicate.SetRCommand("replicate")
        clsReplicate.AddParameter("n", 1)
        clsReplicate.AddParameter("expr", clsRFunctionParameter:=clsSample)

        'setting the main fuction
        clsDataFrame = New RFunction
        clsDataFrame.SetRCommand("data.frame")
        clsDataFrame.AddParameter("X", clsRFunctionParameter:=clsReplicate)
        clsDataFrame.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrame)

    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverSelected.IsEmpty AndAlso ucrNudNumberOfColumns.GetText() <> "" AndAlso ucrNudSampleSize.GetText() <> "" AndAlso ucrNewDataframe.IsComplete) Then
            If ucrChkSetSeed.Checked Then
                If ucrNudSetSeed.GetText <> "" Then
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
    'updating rcode of the controls
    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSelected.SetRCode(clsSample, bReset)
        ucrChkWithReplacement.SetRCode(clsSample, bReset)
        ucrNudNumberOfColumns.SetRCode(clsReplicate, bReset)
        ucrNewDataframe.SetRCode(clsDataFrame, bReset)
        ucrNudSampleSize.SetRCode(clsSample, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeed, bReset)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSubset: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub NewDefaultName()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrNewDataframe.bUserTyped) Then
            ucrNewDataframe.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ReplaceParameters()
        If ucrChkWithReplacement.Checked Then
            ucrNudSampleSize.SetMinMax(1, Integer.MaxValue)
        Else
            ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelected.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged, ucrChkSetSeed.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorRandomSubsets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSubsets.ControlValueChanged
        NewDefaultName()
        ReplaceParameters()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNudSampleSize.Value = frmMain.clsRLink.GetDataFrameLength(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub ucrChkWithReplacement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWithReplacement.ControlValueChanged
        ReplaceParameters()
    End Sub

End Class