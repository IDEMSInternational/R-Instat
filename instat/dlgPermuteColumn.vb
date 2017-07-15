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
Public Class dlgPermuteColumn
    Private clsSetSampleFunction, clsSetSeedFunction, clsOverallFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgPermuteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 66

        ucrPermuteRowsSelector.ucrAvailableDataFrames.SetParameter(New RParameter("size", 1))
        ucrPermuteRowsSelector.SetParameterIsrfunction()

        ucrReceiverPermuteRows.SetParameter(New RParameter("x", 0))
        ucrReceiverPermuteRows.SetParameterIsRFunction()
        ucrReceiverPermuteRows.bUseFilteredData = False
        ucrReceiverPermuteRows.Selector = ucrPermuteRowsSelector
        ucrReceiverPermuteRows.SetMeAsReceiver()

        ucrNudNumberofColumns.SetParameter(New RParameter("n", 1))
        ucrNudNumberofColumns.Maximum = Integer.MaxValue
        ucrNudNumberofColumns.Minimum = 1

        ucrChkSetSeed.AddToLinkedControls(ucrNudSetSeed, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSetSeed.SetText("Set Seed")
        ucrChkSetSeed.AddFunctionNamesCondition(False, "set.seed")

        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.Maximum = Integer.MaxValue

        ucrSavePermute.SetSaveTypeAsColumn()
        ucrSavePermute.SetDataFrameSelector(ucrPermuteRowsSelector.ucrAvailableDataFrames)
        ucrSavePermute.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsSetSeedFunction = New RFunction
        clsSetSampleFunction = New RFunction
        clsOverallFunction = New RFunction

        ucrPermuteRowsSelector.Reset()
        ucrSavePermute.Reset()
        SetNewColumName()

        clsSetSampleFunction.SetRCommand("sample")
        clsSetSampleFunction.AddParameter("replace", "FALSE")
        clsSetSampleFunction.AddParameter("size", ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength)

        clsSetSeedFunction.SetRCommand("set.seed")
        clsSetSeedFunction.AddParameter("seed", 5)

        clsOverallFunction.SetRCommand("replicate")
        clsOverallFunction.AddParameter("expr", clsRFunctionParameter:=clsSetSampleFunction)
        clsOverallFunction.AddParameter("n", 1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSavePermute.GetText, strTempDataframe:=ucrPermuteRowsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSavePermute.GetText, bAssignToIsPrefix:=True)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudNumberofColumns.SetRCode(clsOverallFunction, bReset)
        ucrReceiverPermuteRows.SetRCode(clsSetSampleFunction, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeedFunction, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeedFunction, bReset)
        ucrSavePermute.SetRCode(clsOverallFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverPermuteRows.IsEmpty AndAlso ucrSavePermute.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeedFunction.ToScript, strComment:="dlgPermuteColumn:Setting the seed for the random generator")
        End If
    End Sub

    Private Sub SetNewColumName()
        If ucrNudNumberofColumns.Value = 1 Then
            ucrSavePermute.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
            ucrSavePermute.SetLabelText("New Column Name:")
            If Not ucrSavePermute.bUserTyped Then
                ucrSavePermute.SetPrefix("permute")
            End If
        Else
            ucrSavePermute.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
            ucrSavePermute.SetLabelText("Prefix for New Columns:")
            If Not ucrSavePermute.bUserTyped Then
                ucrSavePermute.SetPrefix("")
                ucrSavePermute.SetName("permute")
            End If
        End If
    End Sub

    Private Sub ucrPermuteRowsSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPermuteRowsSelector.ControlValueChanged
        clsSetSampleFunction.AddParameter("size", ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength)
    End Sub

    Private Sub ucrNudNumberofColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberofColumns.ControlValueChanged
        SetNewColumName()
    End Sub

    Private Sub ucrReceiverPermuteRows_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPermuteRows.ControlContentsChanged, ucrSavePermute.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class