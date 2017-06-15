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
Public Class dlgDeleteMetadata
    Public bFirstLoad As Boolean = True
    Private Sub dlgDeleteMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            setDefaults()
            InitialiseDialog()
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
        ucrReceiverMetadataToDelete.Selector = ucrSelectorForDeleteMetadata
        ucrReceiverMetadataToDelete.SetMeAsReceiver()
        ucrSelectorForDeleteMetadata.SetItemType("metadata")
        ucrBase.iHelpTopicID = 170
    End Sub

    Private Sub setDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForDeleteMetadata_Load(sender As Object, e As EventArgs) Handles ucrSelectorForDeleteMetadata.Load

    End Sub
End Class