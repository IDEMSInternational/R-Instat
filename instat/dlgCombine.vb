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
    Private Sub dlgInteractions_Load(sender As Object, e As KeyEventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
        Else
            ReOpenDialog()
        End If
        autoTranslate(Me)
    End Sub
    Private Sub SetDefaults()
        ucrSelectorCombineFactors.Reset()
        ucrSelectorCombineFactors.Focus()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetMeAsReceiver()
        chkDropUnusedLevels.Checked = False

    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetDataType("factor")
        chkDropUnusedLevels.Checked = False


        ucrInputColName.SetPrefix("Interact")
        ucrInputColName.SetItemsTypeAsColumns()
        ucrInputColName.SetDefaultTypeAsColumn()
        ucrInputColName.SetDataFrameSelector(ucrSelectorCombineFactors.ucrAvailableDataFrames)

    End Sub

    Private Sub ucrInputColName_NameChanged() Handles ucrInputColName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class
