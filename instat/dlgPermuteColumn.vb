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
Public Class dlgPermuteColumn
    Private clsSetSampleFunc, clsSetSeedFunc, clsOverallFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iLength As Integer

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

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrNudNumberofColumns.SetRCode(clsOverallFunction, bReset)
        ucrReceiverPermuteRows.SetRCode(clsSetSampleFunc, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeedFunc, bReset)
    End Sub

    Public Sub SetDefaults()
        Dim clsDefaultFunction, clsDefaultSample, clsDefaultSetSeed As New RFunction
        ucrPermuteRowsSelector.Reset()
        ucrNudSetSeed.SetRDefault(5)
        clsDefaultSample.SetRCommand("sample")
        clsDefaultSample.AddParameter("replace", "FALSE")

        clsDefaultSample.AddParameter("size", iLength)

        clsDefaultSetSeed.SetRCommand("set.seed")
        clsDefaultSetSeed.AddParameter("seed", 5)


        clsDefaultFunction.SetRCommand("replicate")

        clsSetSeedFunc = clsDefaultSetSeed.Clone
        clsSetSampleFunc = clsDefaultSample.Clone
        clsOverallFunction = clsDefaultFunction.Clone
        clsOverallFunction.AddParameter("expr", clsRFunctionParameter:=clsSetSampleFunc)
        SetNameForNewColumn()
        clsOverallFunction.AddParameter("n", 1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallFunction)
    End Sub

    Private Sub SetNameForNewColumn()
        clsOverallFunction.SetAssignTo(strTemp:=ucrSavePermute.GetText, strTempDataframe:=ucrPermuteRowsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSavePermute.GetText, bAssignToIsPrefix:=True)
    End Sub
    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 66
        SetNameForNewColumn()
        ucrReceiverPermuteRows.Selector = ucrPermuteRowsSelector
        ucrReceiverPermuteRows.SetMeAsReceiver()

        ucrPermuteRowsSelector.ucrAvailableDataFrames.SetParameter(New RParameter("size"))
        ucrPermuteRowsSelector.SetParameterIsrfunction()
        ucrReceiverPermuteRows.bUseFilteredData = False
        ucrReceiverPermuteRows.SetParameter(New RParameter("x", 0))
        ucrReceiverPermuteRows.SetParameterIsRFunction()
        ucrNudNumberofColumns.SetParameter(New RParameter("n", 1))
        ucrNudNumberofColumns.SetRDefault(1)
        ucrNudNumberofColumns.Maximum = Integer.MaxValue
        ucrNudNumberofColumns.Minimum = 1


        ucrChkSetSeed.AddToLinkedControls(ucrNudSetSeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeParameterToDefault:=True)



        ucrChkSetSeed.SetText("Set Seed")

        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSetSeed.Maximum = Integer.MaxValue
        ucrNudSetSeed.Minimum = Integer.MinValue



        ucrSavePermute.SetName("permute")
        ucrSavePermute.SetSaveTypeAsColumn()
        ucrSavePermute.SetDataFrameSelector(ucrPermuteRowsSelector.ucrAvailableDataFrames)
        ucrSavePermute.SetLabelText("Save Permute:")
        ucrSavePermute.SetIsComboBox()
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

    Private Sub ucrReceiverPermuteRows_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPermuteRows.ControlContentsChanged, ucrSavePermute.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeedFunc.ToScript, strComment:="dlgPermuteColumn:Setting the seed for the random generator")
        End If

    End Sub

    Private Sub DataFrameLength()
        iLength = ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength
        clsSetSampleFunc.AddParameter("size", iLength)
    End Sub

    Private Sub ucrPermuteRowsSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPermuteRowsSelector.ControlValueChanged
        SetNameForNewColumn()
        DataFrameLength()
    End Sub
End Class