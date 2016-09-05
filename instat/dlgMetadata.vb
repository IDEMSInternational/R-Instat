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
'
Imports instat.Translations
Public Class dlgMetadata
    Public bFirstLoad As Boolean = True
    Private Sub dlgMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            setDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverChooseProperty.Selector = ucrSelectByMetadata
        ucrReceiverChooseColumns.Selector = ucrSelectByMetadata
        ucrReceiverChooseProperty.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 391
        ucrReceiverChooseColumns.SetItemType("column")
        ucrReceiverChooseProperty.SetItemType("metadata")
    End Sub

    Private Sub setDefaults()
        ucrSelectByMetadata.Reset()
        ucrCurrentValue.IsReadOnly = True
        rdoChooseProperty.Checked = True
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputViewDataBy_SelectionChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub grpProperty_CheckedChanged(sender As Object, e As EventArgs) Handles rdoChooseProperty.CheckedChanged, rdoDefineNewProperty.CheckedChanged
        DefineProperty()
    End Sub

    Private Sub DefineProperty()
        If rdoDefineNewProperty.Checked Then
            ucrReceiverChooseProperty.Visible = False
            ucrInputDefineProperty.Visible = True
            ucrReceiverChooseColumns.Focus()
        Else
            ucrReceiverChooseProperty.Visible = True
            ucrInputDefineProperty.Visible = False
        End If
    End Sub
End Class