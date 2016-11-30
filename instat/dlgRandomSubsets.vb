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
    Private clsSetSeed As New RFunction
    Private clsSampleFunc As New RFunction
    Private clsReplicateFunc As New RFunction
    Private clsDataFrameFunc As New RFunction


    Private Sub dlgRandomSubsets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)

    End Sub
    'this contains things that initialise the dialog and run once
    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFrameFunc)
        clsDataFrameFunc.AddParameter("X", clsRFunctionParameter:=clsReplicateFunc)
        clsDataFrameFunc.SetRCommand("data.frame")
        clsReplicateFunc.SetRCommand("replicate")
        ucrReceiverSelected.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        clsSetSeed.SetRCommand("set.seed")
        clsReplicateFunc.AddParameter("expr", clsRFunctionParameter:=clsSampleFunc)
        clsSampleFunc.SetRCommand("sample")
        ucrBase.iHelpTopicID = 65

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

        ucrSelectorRandomSubsets.Reset()
        ucrSelectorRandomSubsets.Focus()
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        chkWithReplacement.Checked = False
        chkSetSeed.Checked = False
        nudNumberOfColumns.Value = 1
        nudNumberOfColumns.Minimum = 1
        nudNumberOfColumns.Maximum = Integer.MaxValue
        ReplaceParameters()
        nudSampleSize.Value = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        nudSetSeed.Value = 1
        nudSetSeed.Minimum = Integer.MinValue
        nudSetSeed.Maximum = Integer.MaxValue
        nudSetSeed.Visible = False
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If

        TestOkEnabled()
    End Sub
    'set what happens when dialog is reopened
    Private Sub ReOpenDialog()
        If ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetName(ucrSelectorRandomSubsets.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_random")
        End If
    End Sub
    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        If Not ucrNewDataFrameName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
        TestOkEnabled()
    End Sub
    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If chkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSubset: Setting the seed for random number generator")
        End If
        TestOkEnabled()
    End Sub
    Private Sub ucrReceiverSelected_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSelected.SelectionChanged
        If Not ucrReceiverSelected.IsEmpty Then
            clsSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverSelected.GetVariables())
        Else
            clsSampleFunc.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub
    Private Sub SetSeedParameters()
        If chkSetSeed.Checked Then
            nudSetSeed.Visible = True
            If nudSetSeed.Text <> "" Then
                clsSetSeed.AddParameter("seed", nudSetSeed.Value)
            Else
                clsSetSeed.RemoveParameterByName("seed")
            End If
        Else
            nudSetSeed.Visible = False
            clsSetSeed.RemoveParameterByName("seed")
        End If
    End Sub
    Private Sub ReplaceParameters()
        If chkWithReplacement.Checked Then
            clsSampleFunc.AddParameter("replace", "TRUE")
            nudSampleSize.Minimum = 1
            nudSampleSize.Maximum = Integer.MaxValue
        Else
            clsSampleFunc.AddParameter("replace", "FALSE")
            nudSampleSize.Minimum = 1
            nudSampleSize.Maximum = ucrSelectorRandomSubsets.ucrAvailableDataFrames.iDataFrameLength
        End If
    End Sub
    Private Sub chkSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
        SetSeedParameters()
    End Sub
    Private Sub nudSeed_TextChanged(sender As Object, e As EventArgs) Handles nudSetSeed.TextChanged
        SetSeedParameters()
    End Sub
    Private Sub nudNumberOfColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNumberOfColumns.TextChanged
        clsReplicateFunc.AddParameter("n", nudNumberOfColumns.Value)
    End Sub

    Private Sub nudSampleSize_TextChanged(sender As Object, e As EventArgs) Handles nudSampleSize.TextChanged
        clsSampleFunc.AddParameter("size", nudSampleSize.Value)
    End Sub
    Private Sub chkWithReplacement_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithReplacement.CheckedChanged
        ReplaceParameters()
    End Sub

    'this is what happens when Reset button is clicked
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub


End Class