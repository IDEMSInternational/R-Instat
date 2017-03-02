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
    Private clsDataFrame, clsSetSeed, ClsSample, clsReplicate As New RFunction

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

        'Set seed
        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.SetMinMax(1, Integer.MaxValue)
        ucrChkSetSeed.SetText("Seed")
        ucrChkSetSeed.bChangeParameterValue = False

        ucrSelectorRandomSubsets.ucrAvailableDataFrames.SetParameter(New RParameter("size", 2))
        ucrSelectorRandomSubsets.SetParameterIsrfunction()

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
        ucrChkSetSeed.Checked = False
        NewDefaultName()
        ReplaceParameters()

        'sample function
        ClsSample = New RFunction
        ClsSample.SetRCommand("sample")
        ClsSample.AddParameter("replace", "FALSE")
        ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        ClsSample.AddParameter("size", ucrNudSampleSize.Value)

        'setseed fuction
        clsSetSeed = New RFunction
        clsSetSeed.SetRCommand("set.seed")
        clsSetSeed.AddParameter("seed", 1)

        'replicate func setting
        clsReplicate = New RFunction
        clsReplicate.SetRCommand("replicate")
        clsReplicate.AddParameter("n", 1)
        clsReplicate.AddParameter("expr", clsRFunctionParameter:=ClsSample)

        'setting the main fuction
        clsDataFrame = New RFunction
        clsDataFrame.SetRCommand("data.frame")
        clsDataFrame.AddParameter("X", clsRFunctionParameter:=clsReplicate)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrame)
        clsDataFrame.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())

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
        ucrReceiverSelected.SetRCode(ClsSample, bReset)
        ucrChkWithReplacement.SetRCode(ClsSample, bReset)
        ucrNudNumberOfColumns.SetRCode(clsReplicate, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNewDataframe.SetRCode(clsDataFrame, bReset)
        ucrNudSampleSize.SetRCode(ClsSample,bReset)
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

    Private Sub sizes()
        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        ClsSample.AddParameter("size", ucrNudSampleSize.Value)
    End Sub

    Private Sub ReplaceParameters()
        If ucrChkWithReplacement.Checked Then
            ClsSample.AddParameter("replace", "TRUE")
            ucrNudSampleSize.SetMinMax(1, Integer.MaxValue)
        Else
            ClsSample.AddParameter("replace", "FALSE")
            ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelected.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged, ucrChkSetSeed.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorRandomSubsets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSubsets.ControlValueChanged
        NewDefaultName()
        ReplaceParameters()
        sizes()
    End Sub

    Private Sub ucrChkWithReplacement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWithReplacement.ControlValueChanged
        ReplaceParameters()
    End Sub
    'Keeping the size of the data frame updated whenever the value is changed in the nud 
    Private Sub ucrNudSampleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudSampleSize.ControlValueChanged
        ClsSample.AddParameter("size", ucrNudSampleSize.Value)
    End Sub
End Class