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
Public Class dlgDeleteDescriptive
    Public bFirstLoad As Boolean
    Private Sub dlgDeleteDescriptive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$delete_object")
        ucrReceiverObjectsToDelete.Selector = ucrSelectorDeleteObject
        ucrReceiverObjectsToDelete.SetMeAsReceiver()
        ucrSelectorDeleteObject.SetItemType("object")
        ucrBase.iHelpTopicID = 352
    End Sub
    Private Sub TestOKEnabled()
        If ucrReceiverObjectsToDelete.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub SetDefaults()
        ucrSelectorDeleteObject.Reset()
        ucrSelectorDeleteObject.Focus()
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub ucrSelectorDeleteObject_DataFrameChanged() Handles ucrSelectorDeleteObject.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorDeleteObject.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverObjectsToDelete_SelectionChanged() Handles ucrReceiverObjectsToDelete.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("object_name", ucrReceiverObjectsToDelete.GetVariableNames())
        TestOKEnabled()
    End Sub
End Class