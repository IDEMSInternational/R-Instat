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

Imports instat
Imports instat.Translations
Public Class dlgRandomSubsets
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSetSeed, clsReplicateFunc, clsOverallFunction, clsSampleFunc As New RFunction
    ' Dim ilength As Integer

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
        TestOkEnabled()

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
        ' ucrChkSetSeed.AddFunctionNamesCondition("set.seed", True)
        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.SetMinMax(1, Integer.MaxValue)
        ucrChkSetSeed.SetText("Seed")

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
        ucrChkSetSeed.AddToLinkedControls(ucrNudSetSeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrNewDataframe
        ucrNewDataframe.SetIsTextBox()
        ucrNewDataframe.SetSaveTypeAsDataFrame()
        ucrNewDataframe.SetDataFrameSelector(ucrSelectorRandomSubsets.ucrAvailableDataFrames)
        ucrNewDataframe.SetLabelText("New Data Frame Name:")


    End Sub

    'checks when to enable ok button
    Private Sub TestOkEnabled()
        If Not ucrReceiverSelected.IsEmpty AndAlso ucrNudNumberOfColumns.GetText() <> "" AndAlso ucrNudSetSeed.GetText() <> "" AndAlso ucrNudSampleSize.GetText() <> "" AndAlso ucrNewDataframe.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'set defaults for the dialog
    Private Sub SetDefaults()
        Dim clsDefaultFunction, clsDefaultSeed, ClsDefaultSample,clsDefaultRepFunc As New RFunction

        ucrSelectorRandomSubsets.Reset()

        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        sizes()
        ReplaceParameters()
        NewDefaultName()

        ucrNudSetSeed.Visible = False
        clsDefaultFunction.SetRCommand("data.frame")
        clsDefaultRepFunc.SetRCommand("replicate")
        ClsDefaultSample.SetRCommand("sample")
        clsDefaultRepFunc.AddParameter("n", 1)
        ClsDefaultSample.AddParameter("replace", "FALSE")
        ClsDefaultSample.AddParameter("size", ucrNudSampleSize.Value)
        clsReplicateFunc = clsDefaultRepFunc

        clsDefaultSeed.SetRCommand("set.seed")
        clsDefaultSeed.AddParameter("seed", 1)
        clsSetSeed = clsDefaultSeed.Clone


        clsSampleFunc = ClsDefaultSample

        clsOverallFunction = clsDefaultFunction.Clone
        clsReplicateFunc.AddParameter("expr", clsRFunctionParameter:=clsSampleFunc)
        clsOverallFunction.AddParameter("X", clsRFunctionParameter:=clsReplicateFunc)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)

        clsOverallFunction.SetAssignTo(ucrNewDataframe.GetText(), strTempDataframe:=ucrNewDataframe.GetText())

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSelected.SetRCode(clsSampleFunc, bReset)
        ucrChkWithReplacement.SetRCode(clsSampleFunc, bReset)
        ucrNudNumberOfColumns.SetRCode(clsReplicateFunc, bReset)
        ucrNudSampleSize.SetRCode(clsSampleFunc, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNewDataframe.SetRCode(clsOverallFunction, bReset)

    End Sub


    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSubset: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub NewDefaultName()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataframe.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub sizes()
        'sample size
        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        clsSampleFunc.AddParameter("size", ucrNudSampleSize.Value)
    End Sub

    Private Sub ReplaceParameters()
        If ucrChkWithReplacement.Checked Then
            clsSampleFunc.AddParameter("replace", "TRUE")
            ucrNudSampleSize.SetMinMax(1, Integer.MaxValue)
        Else
            clsSampleFunc.AddParameter("replace", "FALSE")
            ucrNudSampleSize.SetMinMax(1, ucrNudSampleSize.Value)
        End If
    End Sub


    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelected.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrSelectorRandomSubsets.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorRandomSubsets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSubsets.ControlValueChanged, ucrChkWithReplacement.ControlValueChanged, ucrNudSampleSize.ControlValueChanged
        NewDefaultName()
        ReplaceParameters()
        sizes()
    End Sub
End Class