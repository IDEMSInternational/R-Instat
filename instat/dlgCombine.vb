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
Public Class dlgCombine
    Private bFirstLoad As Boolean = True

    Private Sub dlgCombine_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorCombineFactors.Reset()
        ucrSelectorCombineFactors.Focus()
        ucrInputColName.Reset()
        chkDropUnusedLevels.Checked = False
        ucrInputColName.SetPrefix("Interact")
    End Sub

    Private Sub InitialiseDialog()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetMeAsReceiver()
        ucrFactorsReceiver.SetIncludedDataTypes({"factor"})
        ucrBase.clsRsyntax.SetFunction("interaction")
        ucrInputColName.SetItemsTypeAsColumns()
        ucrInputColName.SetDefaultTypeAsColumn()
        ucrInputColName.SetDataFrameSelector(ucrSelectorCombineFactors.ucrAvailableDataFrames)
        ucrBase.iHelpTopicID = 39
        ucrInputColName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub TestOkEnabled()
        If (ucrFactorsReceiver.lstSelectedVariables.Items.Count > 1) AndAlso (Not ucrInputColName.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorsReceiver_SelectionChanged() Handles ucrFactorsReceiver.SelectionChanged
        If ucrFactorsReceiver.lstSelectedVariables.Items.Count > 1 Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrFactorsReceiver.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrInputColName_NameChanged() Handles ucrInputColName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
        TestOkEnabled()
    End Sub

    Private Sub chkDropUnusedLevels_CheckedChanged(sender As Object, e As EventArgs) Handles chkDropUnusedLevels.CheckedChanged
        If chkDropUnusedLevels.Checked Then
            ucrBase.clsRsyntax.AddParameter("drop", "TRUE")
        Else
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("drop", "FALSE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("drop")
            End If
        End If
    End Sub

    Private Sub ucrSelectorCombineFactors_DataFrameChanged() Handles ucrSelectorCombineFactors.DataFrameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
    End Sub
End Class
