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
            'SetDefaultSettings()
            SetDefaultSettings()
            bFirstLoad = False
        End If

        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")
        ucrBase.iHelpTopicID = 36
    End Sub
    Private Sub SetDefaultSettings()
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSelectorFactorLevelsToReorder.Focus()
        ucrReorderFactor.Reset()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorFactorLevelsToReorder_DataFrameChanged() Handles ucrSelectorFactorLevelsToReorder.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub ucrReceiverFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactor.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverFactor.GetVariableNames)
        TestOKEnabled()
    End Sub

    Private Sub ucrReorderFactor_Leave(sender As Object, e As EventArgs) Handles ucrReorderFactor.Leave
        ucrBase.clsRsyntax.AddParameter("new_level_names", ucrReorderFactor.GetVariableNames)
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaultSettings()
    End Sub
End Class