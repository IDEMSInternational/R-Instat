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
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub SetDefaults()
        ucrSelectorCombineFactors.Reset()
        ucrSelectorCombineFactors.Focus()
        chkDropUnusedLevels.Checked = False

    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub TestOkEnabled()
        If ucrFactorsReceiver.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetMeAsReceiver()
        ucrFactorsReceiver.SetDataType("factor")
        chkDropUnusedLevels.Checked = False
        ucrInputColName.SetPrefix("Interact")
        ucrInputColName.SetItemsTypeAsColumns()
        ucrInputColName.SetDefaultTypeAsColumn()
        ucrInputColName.SetDataFrameSelector(ucrSelectorCombineFactors.ucrAvailableDataFrames)
        ucrBase.iHelpTopicID = 39
    End Sub

    Private Sub ucrInputColName_NameChanged() Handles ucrInputColName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub lblNewColumnName_Click(sender As Object, e As EventArgs) Handles lblNewColumnName.Click

    End Sub

End Class
