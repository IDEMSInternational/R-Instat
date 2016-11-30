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
Public Class dlgReferenceLevel
    Public bFirstLoad As Boolean = True
    Private Sub dlgReferenceLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_factor_reference_level")
        ucrBase.iHelpTopicID = 38
        ucrReceiverReferenceLevels.Selector = ucrSelectorForReferenceLevels
        ucrReceiverReferenceLevels.SetMeAsReceiver()
        ucrReceiverReferenceLevels.SetIncludedDataTypes({"factor"})
        ucrReceiverReferenceLevels.SetExcludedDataTypes({"ordered,factor"})
        ucrFactorReferenceLevels.SetReceiver(ucrReceiverReferenceLevels)
        ucrFactorReferenceLevels.SetAsSingleSelector()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForReferenceLevels.Reset()
        ucrSelectorForReferenceLevels.Focus()


    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverReferenceLevels.IsEmpty() = False Then
            ucrBase.OKEnabled(True)

        Else
            ucrBase.OKEnabled(False)

        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForReferenceLevels_DataFrameChanged() Handles ucrSelectorForReferenceLevels.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForReferenceLevels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub ucrReceiverReferenceLevels_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverReferenceLevels.SelectionChanged
        If Not ucrReceiverReferenceLevels.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverReferenceLevels.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrFactorReferenceLevels_SelectedLevelChanged() Handles ucrFactorReferenceLevels.SelectedLevelChanged
        ucrBase.clsRsyntax.AddParameter("new_ref_level", ucrFactorReferenceLevels.GetSelectedLevels())
    End Sub
End Class