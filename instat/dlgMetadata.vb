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
        If Not ucrInputViewDataBy.IsEmpty Or chkRevertBack.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectByMetadata.SetItemType("metadata")
        ucrInputViewDataBy.Selector = ucrSelectByMetadata
        ucrBase.iHelpTopicID = 391
    End Sub

    Private Sub setDefaults()
        ucrSelectByMetadata.Reset()
        ucrInputViewDataBy.SetMeAsReceiver()
        ucrSelectByMetadata.Focus()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub chkRevertBack_CheckStateChanged(sender As Object, e As EventArgs) Handles chkRevertBack.CheckStateChanged
        'this doesn't look right to me DAS
        If chkRevertBack.Checked Then
            ucrInputViewDataBy.txtReceiverSingle.Text = "Name"
            ucrInputViewDataBy.Enabled = False
            ucrSelectByMetadata.Enabled = False
        Else
            ucrInputViewDataBy.Enabled = True
            ucrSelectByMetadata.Enabled = True
            ucrSelectByMetadata.Focus()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputViewDataBy_SelectionChanged(sender As Object, e As EventArgs) Handles ucrInputViewDataBy.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'frmMain.clsGrids.bGrdViewDataByMetadata = True
        frmMain.clsGrids.SetMetadata(ucrInputViewDataBy.txtReceiverSingle.Text)
        frmMain.clsGrids.SetVariablesMetadata(frmVariables.grdVariables)
    End Sub
End Class