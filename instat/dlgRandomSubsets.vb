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
    Private clsSeed As New RFunction
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
        ucrReceiverSelected.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        clsSeed.SetRCommand("set.seed")
        ucrBase.clsRsyntax.SetFunction("replicate")
        ucrBase.clsRsyntax.AddParameter("expr", clsRFunctionParameter:=clsSampleFunc)
        clsSampleFunc.SetRCommand("sample")
        clsSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverSelected.GetVariables())
        clsSampleFunc.AddParameter("size", nudNumberOfColumns.Value())
        clsSampleFunc.AddParameter("replace", "FALSE")

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
        ucrNewDataFrameName.Reset()
        ucrSelectorRandomSubsets.Reset()
        ucrSelectorRandomSubsets.Focus()
        ucrReceiverSelected.Selector = ucrSelectorRandomSubsets
        ucrReceiverSelected.SetMeAsReceiver()
        chkWithReplacement.Checked = False
        chkSeed.Checked = False
        nudNumberOfColumns.Value = 1
        nudSampleSize.Value = 1
        nudSeed.Value = 1
        nudSeed.Minimum = Integer.MinValue
        nudSeed.Maximum = Integer.MaxValue
        nudSeed.Visible = False

    End Sub
    'set what happens when dialog is reopened
    Private Sub ReOpenDialog()

    End Sub
    Private Sub ucrNewDataFrameName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        'If Not ucrNewDataFrameName.IsEmpty Then
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText(), strTempDataframe:=ucrNewDataFrameName.GetText())
        'Else
        'ucrBase.clsRsyntax.RemoveAssignTo()
        'End If
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
    Private Sub SeedParameters()
        If chkSeed.Checked Then
            nudSeed.Visible = True
        Else
            nudSeed.Visible = False

        End If
    End Sub

    Private Sub chkSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeed.CheckedChanged
        SeedParameters()
    End Sub
    Private Sub nudSeed_ValueChanged(sender As Object, e As EventArgs) Handles nudSeed.ValueChanged
        clsSeed.AddParameter("set.seed", nudSeed.Value)
    End Sub
    Private Sub nudNumberOfColumns_ValueChanged(sender As Object, e As EventArgs) Handles nudNumberOfColumns.ValueChanged
        ucrBase.clsRsyntax.AddParameter("n", nudNumberOfColumns.Value)
    End Sub

    Private Sub nudSampleSize_ValueChanged(sender As Object, e As EventArgs) Handles nudSampleSize.ValueChanged
        clsSampleFunc.AddParameter("size", nudSampleSize.Value)
    End Sub


    'this is what happens when Reset button is clicked
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

End Class