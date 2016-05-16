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
        ucrBase.clsRsyntax.SetFunction("replicate")
        ucrReceiverSelected.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        clsSetSeed.SetRCommand("set.seed")
        nudSeed.Minimum = Integer.MinValue
        nudSeed.Maximum = Integer.MaxValue
        ucrNewDataFrameName.SetItemsTypeAsDataFrames()

        ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorRandomSubsets.ucrAvailableDataFrames)




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
        nudNumberOfColumns.Value = 1
        nudSampleSize.Value = 1
        nudSeed.Value = 1
        nudSeed.Visible = False
        TestOkEnabled()
    End Sub
    'set what happens when dialog is reopened
    Private Sub ReOpenDialog()

    End Sub
    Private Sub ucrReceiverSelected_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSelected.SelectionChanged
        If Not ucrReceiverSelected.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", ucrReceiverSelected.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOkEnabled()
    End Sub
    Private Sub SeedParameters()
        If chkSeed.Checked Then
            nudSeed.Visible = True
            If nudSeed.Text <> "" Then
                clsSetSeed.AddParameter("set.seed", nudSeed.Value)
            Else
                clsSetSeed.RemoveParameterByName("set.seed")
            End If
        Else
            nudSeed.Visible = False
            clsSetSeed.RemoveParameterByName("set.seed")
        End If
    End Sub


    'this is what happens when Reset button is clicked
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeed.CheckedChanged
        SeedParameters()
    End Sub

    Private Sub chkWithReplacement_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithReplacement.CheckedChanged
        If chkWithReplacement.Checked = False Then
            'If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
            ucrBase.clsRsyntax.AddParameter("FALSE", chkWithReplacement.CheckedChanged)


        Else
            ucrBase.clsRsyntax.AddParameter("sample", Chr(34) & "TRUE" & Chr(34))
        End If


    End Sub
    Private Sub WithOrWithoutReplacement()

    End Sub

    Private Sub NumberOfReplications()
        If nudNumberOfColumns.Text <> "" Then

            ucrBase.clsRsyntax.AddParameter("n", nudNumberOfColumns.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("n")
        End If

    End Sub
    Private Sub SampleSize()
        If nudSampleSize.Text <> "" Then
            ' clsSampleSize.AddParameter("size", nudNumberOfColumns.Value
            ucrBase.clsRsyntax.AddParameter("sample", Chr(34) & "size" & Chr(34))

            'Else
            'clsSampleSize.RemoveParameterByName("size")
        End If
    End Sub


    Private Sub nudNumberOfColumns_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfColumns.ValueChanged
        NumberOfReplications()
    End Sub

    Private Sub nudSampleSize_ValueChanged(sender As Object, e As EventArgs) Handles nudSampleSize.ValueChanged
        SampleSize()
    End Sub
End Class