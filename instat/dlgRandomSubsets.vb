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
Public Class dlgRandomSubsets
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrameFunction, clsSetSeedFunction, clsSampleFunction, clsRerunFunction As New RFunction

    Private Sub dlgRandomSubsets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 65

        'ucrReceiver
        ucrReceiverSubsets.bForceAsDataFrame = True
        ucrReceiverSubsets.SetParameter(New RParameter("tbl", 0))
        ucrReceiverSubsets.SetParameterIsRFunction()
        ucrReceiverSubsets.Selector = ucrSelectorRandomSubsets
        ucrReceiverSubsets.SetMeAsReceiver()

        'Replace checkbox
        ucrChkWithReplacement.SetParameter(New RParameter("replace", 1))
        ucrChkWithReplacement.SetText("With Replacement")
        ucrChkWithReplacement.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkWithReplacement.SetRDefault("FALSE")

        'Number of columns
        ucrNudNumberOfColumns.SetParameter(New RParameter(".n", 0))
        ucrNudNumberOfColumns.SetMinMax(1, Integer.MaxValue)

        ' Sample Size
        ucrNudSampleSize.SetParameter(New RParameter("size", 1))

        'Set Seed
        ucrChkSetSeed.SetText("Set Seed")
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(True, {"set.seed"})
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(False, {"set.seed"}, False)
        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.SetMinMax(1, Integer.MaxValue)
        ucrChkSetSeed.AddToLinkedControls(ucrLinked:=ucrNudSetSeed, objValues:={True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrNewDataFrame
        ucrNewDataFrame.SetIsTextBox()
        ucrNewDataFrame.SetSaveTypeAsDataFrame()
        ucrNewDataFrame.SetDataFrameSelector(ucrSelectorRandomSubsets.ucrAvailableDataFrames)
        ucrNewDataFrame.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub SetDefaults()
        clsSampleFunction = New RFunction
        clsSetSeedFunction = New RFunction
        clsRerunFunction = New RFunction
        clsDataFrameFunction = New RFunction


        ucrSelectorRandomSubsets.Reset()
        ucrNewDataFrame.Reset()
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        NewDefaultName()
        ReplaceParameters()

        'sample_n function
        clsSampleFunction.SetPackageName("dplyr")
        clsSampleFunction.SetRCommand("sample_n")
        ucrNudSampleSize.SetMinMax(1, ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength)
        clsSampleFunction.AddParameter("size", ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength, iPosition:=1)

        'setseed fuction
        clsSetSeedFunction.SetRCommand("set.seed")
        clsSetSeedFunction.AddParameter("seed", 1, iPosition:=0)

        'rerun func setting
        clsRerunFunction.SetPackageName("purrr")
        clsRerunFunction.SetRCommand("rerun")
        clsRerunFunction.AddParameter(".n", 1, iPosition:=0)
        clsRerunFunction.AddParameter("expr", clsRFunctionParameter:=clsSampleFunction, iPosition:=1)


        'setting the main fuction
        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("X", clsRFunctionParameter:=clsRerunFunction, iPosition:=0)
        clsDataFrameFunction.SetAssignTo(ucrNewDataFrame.GetText(), strTempDataframe:=ucrNewDataFrame.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunction)
    End Sub

    'updating rcode of the controls
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSubsets.SetRCode(clsSampleFunction, bReset)
        ucrChkWithReplacement.SetRCode(clsSampleFunction, bReset)
        ucrNudNumberOfColumns.SetRCode(clsRerunFunction, bReset)
        ucrNewDataFrame.SetRCode(clsDataFrameFunction, bReset)
        ucrNudSampleSize.SetRCode(clsSampleFunction, bReset)
        ucrChkSetSeed.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeedFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverSubsets.IsEmpty AndAlso ucrNudNumberOfColumns.GetText() <> "" AndAlso ucrNudSampleSize.GetText() <> "" AndAlso ucrNewDataFrame.IsComplete) Then
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

    Private Sub NewDefaultName()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrNewDataFrame.bUserTyped) Then
            ucrNewDataFrame.SetPrefix(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If
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

    Private Sub ucrChkSetSeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSetSeed.ControlValueChanged
        If ucrChkSetSeed.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSetSeedFunction)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSetSeedFunction)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfColumns.ControlContentsChanged, ucrNudSampleSize.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrNewDataFrame.ControlContentsChanged, ucrChkSetSeed.ControlContentsChanged, ucrReceiverSubsets.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class