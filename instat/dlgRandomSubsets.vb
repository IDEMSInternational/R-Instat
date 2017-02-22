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
    Private clsSetSeed, clsReplicateFunc, clsOverallFunction, clsSampleFunc As New RFunction

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
        Dim clsDefaultFunction, clsDefaultSeed, ClsDefaultSample, clsDefaultRepFunc As New RFunction

        ucrSelectorRandomSubsets.Reset()
        ucrNewDataframe.Reset()
        NewDefaultName()
        ReplaceParameters()
        ucrChkSetSeed.Checked = False
        clsDefaultFunction.SetRCommand("data.frame")
        clsDefaultRepFunc.SetRCommand("replicate")
        ClsDefaultSample.SetRCommand("sample")
        clsDefaultRepFunc.AddParameter("n", 1)
        ClsDefaultSample.AddParameter("replace", "FALSE")
        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        ClsDefaultSample.AddParameter("size", ucrNudSampleSize.Value)
        clsReplicateFunc = clsDefaultRepFunc
        clsDefaultSeed.SetRCommand("set.seed")
        clsDefaultSeed.AddParameter("seed", 1)
        clsSetSeed = clsDefaultSeed
        clsSampleFunc = ClsDefaultSample
        clsOverallFunction = clsDefaultFunction.Clone
        clsReplicateFunc.AddParameter("expr", clsRFunctionParameter:=clsSampleFunc)
        clsOverallFunction.AddParameter("X", clsRFunctionParameter:=clsReplicateFunc)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())

    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverSelected.IsEmpty) AndAlso (ucrNudNumberOfColumns.GetText() <> "") AndAlso (ucrNudSampleSize.GetText() <> "") AndAlso (ucrNewDataframe.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

        If (Not ucrReceiverSelected.IsEmpty) AndAlso (ucrNudNumberOfColumns.GetText() <> "") AndAlso (ucrNudSampleSize.GetText() <> "") AndAlso (ucrNewDataframe.IsComplete) AndAlso (ucrNudSetSeed.GetText <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSelected.SetRCode(clsSampleFunc, bReset)
        ucrChkWithReplacement.SetRCode(clsSampleFunc, bReset)
        ucrNudNumberOfColumns.SetRCode(clsReplicateFunc, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)
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
        clsSampleFunc.AddParameter("size", ucrNudSampleSize.Value)
    End Sub

    Private Sub ReplaceParameters()
        If ucrChkWithReplacement.Checked Then
            clsSampleFunc.AddParameter("replace", "TRUE")
            ucrNudSampleSize.SetMinMax(1, Integer.MaxValue)
        Else
            clsSampleFunc.AddParameter("replace", "FALSE")
            ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelected.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrNewDataframe.ControlContentsChanged
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

    Private Sub ucrNudSampleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudSampleSize.ControlValueChanged
        clsSampleFunc.AddParameter("size", ucrNudSampleSize.Value)
    End Sub
End Class