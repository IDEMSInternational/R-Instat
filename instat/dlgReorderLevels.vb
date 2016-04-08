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
Public Class dlgReorderLevels
    Public bFirstLoad As Boolean = True
    Private Sub dlgReorderLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)


        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "")
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetDataType("factor")
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.strDataType = "factor"

    End Sub
    Private Sub SetDefaultSettings()

        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSelectorFactorLevelsToReorder.Focus()
        ucrReorderFactor.lstAvailableData.ResetText()

    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset

    End Sub

    Private Sub ucrReorderFactor_Leave(sender As Object, e As EventArgs) Handles ucrReorderFactor.Leave

    End Sub
End Class