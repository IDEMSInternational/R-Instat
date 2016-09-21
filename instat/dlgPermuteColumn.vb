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

Imports instat.Translations
Public Class dlgPermuteColumn
    Public clsSetSampleFunc As New RFunction
    Public clsSetSeedFunc As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub dlgPermuteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)

    End Sub
    Private Sub SetDefaults()
        ucrReceiverPermuteRows.Selector = ucrPermuteRowsSelector
        ucrReceiverPermuteRows.SetMeAsReceiver()
        ucrInputPermuteRows.SetPrefix("permute")
        chkSetSeed.Checked = False
        nudSetSeed.Visible = False
        TestOkEnabled()
    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverPermuteRows.Selector = ucrPermuteRowsSelector
        ucrReceiverPermuteRows.SetMeAsReceiver()
        clsSetSeedFunc.SetRCommand("set.seed")
        ucrBase.clsRsyntax.SetFunction("replicate")
        ucrBase.clsRsyntax.AddParameter("expr", clsRFunctionParameter:=clsSetSampleFunc)
        clsSetSampleFunc.SetRCommand("sample")
        clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())
        clsSetSampleFunc.AddParameter("replace", "FALSE")
        nudSetSeed.Visible = False
        ucrBase.iHelpTopicID = 66

        ucrInputPermuteRows.SetPrefix("permute")
        ucrInputPermuteRows.SetItemsTypeAsColumns()
        ucrInputPermuteRows.SetDefaultTypeAsColumn()
        ucrInputPermuteRows.SetDataFrameSelector(ucrPermuteRowsSelector.ucrAvailableDataFrames)
        ucrInputPermuteRows.SetValidationTypeAsRVariable()


    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverPermuteRows.IsEmpty AndAlso Not ucrInputPermuteRows.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverPermuteRows_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverPermuteRows.SelectionChanged
        If Not ucrReceiverPermuteRows.IsEmpty Then
            clsSetSampleFunc.AddParameter("x", clsRFunctionParameter:=ucrReceiverPermuteRows.GetVariables())
        Else
            clsSetSampleFunc.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub
    Private Sub chkSetSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
        If chkSetSeed.Checked = True Then
            nudSetSeed.Visible = True
        Else
            nudSetSeed.Visible = False
        End If
    End Sub
    Private Sub nudSetSeed_TextChanged(sender As Object, e As EventArgs) Handles nudSetSeed.TextChanged
        clsSetSeedFunc.AddParameter("seed", nudSetSeed.Value)
    End Sub

    Private Sub nudNumberOfColumns_TextChanged(sender As Object, e As EventArgs) Handles nudNumberOfColumns.TextChanged
        ucrBase.clsRsyntax.AddParameter("n", nudNumberOfColumns.Value)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputPermuteRows_nameChanged() Handles ucrInputPermuteRows.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputPermuteRows.GetText, strTempDataframe:=ucrPermuteRowsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputPermuteRows.GetText, bAssignToIsPrefix:=True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPermuteRowsSelector_DataFrameChanged() Handles ucrPermuteRowsSelector.DataFrameChanged
        clsSetSampleFunc.AddParameter("size", ucrPermuteRowsSelector.ucrAvailableDataFrames.iDataFrameLength)
    End Sub
End Class