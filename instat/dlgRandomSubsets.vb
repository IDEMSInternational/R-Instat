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
    Public bFirstLoad As Boolean = True 'checks if dialog loads for first time
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
        ReOpenDialog()
        TestOkEnabled()

    End Sub



    'this contains things that initialise the dialog and run once
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 65

        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        ucrReceiverSelected.SetIncludedDataTypes({"numeric"})

        ucrNudSetSeed.Minimum = Integer.MinValue
        ucrNudSetSeed.Maximum = Integer.MaxValue

        ucrChkSetSeed.AddFunctionNamesCondition("set.seed", True)
        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.Minimum = 1
        ucrNudSetSeed.SetRDefault(1)

        ucrReceiverSelected.SetParameter(New RParameter("x", 2))
        ucrReceiverSelected.SetParameterIsRFunction()

        ucrChkWithReplacement.SetParameter(New RParameter("replace", 1))
        ucrChkWithReplacement.SetText("With Replacement:")
        ucrChkWithReplacement.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithReplacement.SetRDefault("FALSE")

        ucrNudNumberOfColumns.SetParameter(New RParameter("n", 2))
        ucrNudNumberOfColumns.Value = 1
        ucrNudNumberOfColumns.Minimum = 1
        ucrNudNumberOfColumns.Maximum = Integer.MaxValue
        ucrNudNumberOfColumns.SetRDefault(1)

        ucrNudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength

        ucrChkSetSeed.SetText("Seed")
        ucrNudSetSeed.Minimum = 1
        ucrNudSetSeed.SetRDefault(1)

        ucrChkSetSeed.AddToLinkedControls(ucrNudSetSeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)






        'ucrSaveRandoSubsets.SetPrefix("one_var")
        ucrSaveRandoSubsets.SetSaveTypeAsDataFrame()
        '   ucrSaveRandoSubsets.SetDataFrameSelector(ucrSelectorRandomSubsets.ucrAvailableDataFrames)
        ucrSaveRandoSubsets.SetLabelText("New Data Frame Name:")
        ucrSaveRandoSubsets.SetIsComboBox()


    End Sub

    'checks when to enable ok button
    Private Sub TestOkEnabled()
        If ucrReceiverSelected.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    'set defaults for the dialog
    Private Sub SetDefaults()
        'ucrReceiverSelected.SetRCode(clsRepFunction, bReset)
        ucrSelectorRandomSubsets.Reset()
        ucrSelectorRandomSubsets.Focus()

        Dim clsDefaultFunction, ClsDefaultSample, clsDefaultSeed, clsDefaultRepFunc As New RFunction

        clsDefaultFunction.SetRCommand("data.frame")
        clsDefaultRepFunc.SetRCommand("replicate")
        ClsDefaultSample.SetRCommand("sample")
        clsDefaultRepFunc.AddParameter("n", 1)
        ClsDefaultSample.AddParameter("replace", "FALSE")
        ClsDefaultSample.AddParameter("size", ucrNudSampleSize.Value)

        clsDefaultSeed.SetRCommand("set.seed")
        clsDefaultSeed.AddParameter("seed", 1)
        clsSetSeed = clsDefaultSeed.Clone

        clsReplicateFunc = clsDefaultRepFunc.Clone
        clsSampleFunc = ClsDefaultSample.Clone

        clsOverallFunction = clsDefaultFunction.Clone
        clsReplicateFunc.AddParameter("expr", clsRFunctionParameter:=clsSampleFunc)
        clsOverallFunction.AddParameter("X", clsRFunctionParameter:=clsReplicateFunc)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)

        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveRandoSubsets.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If

        clsOverallFunction.SetAssignTo(ucrSaveRandoSubsets.GetText(), strTempDataframe:=ucrSaveRandoSubsets.GetText())

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSelected.SetRCode(clsSampleFunc, bReset)
        ucrChkWithReplacement.SetRCode(clsSampleFunc, bReset)
        ucrNudNumberOfColumns.SetRCode(clsReplicateFunc, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeed, bReset)
        ucrSaveRandoSubsets.SetRCode(clsOverallFunction, bReset)

    End Sub

    'set what happens when dialog is reopened
    Private Sub ReOpenDialog()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveRandoSubsets.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            clsSetSeed.SetRCommand("set.seed")
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSubset: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelected.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class