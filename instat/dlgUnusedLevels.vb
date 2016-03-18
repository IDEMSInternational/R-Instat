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
Public Class dlgUnusedLevels

    Public bFirstLoad As Boolean = True

    Private Sub dlgUnusedLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            SetDefaultSettings()
            InitialiseDialog()
        End If
        TestOKEnabled()
        ucrBase.iHelpTopicID = 40
        autoTranslate(Me)
    End Sub
    Private Sub SetDefaultSettings()
        ucrSelectorFactorColumn.Reset()
        ucrSelectorFactorColumn.Focus()
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(" droplevels")
        ucrReceiverFactorColumn.Selector = ucrSelectorFactorColumn
        ucrReceiverFactorColumn.SetMeAsReceiver()
        ucrReceiverFactorColumn.SetDataType("factor")
        ucrRemoveUnusedFactorLevels.SetReceiver(ucrReceiverFactorColumn)
    End Sub

    Private Sub ucrBase_clickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaultSettings()
        TestOKEnabled()
    End Sub
    Private Sub TestOKEnabled()
        If ucrReceiverFactorColumn.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
End Class