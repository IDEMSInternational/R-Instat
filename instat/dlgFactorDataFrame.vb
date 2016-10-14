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
Public Class dlgFactorDataFrame
    Public bFirstLoad As Boolean = True
    Private Sub ucrSelectorFactorDataFrame_Load(sender As Object, e As EventArgs) Handles ucrSelectorFactorDataFrame.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)

    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$create_factor_data_frame")
        ucrReceiverFactorDataFrame.Selector = ucrSelectorFactorDataFrame
        ucrReceiverFactorDataFrame.SetMeAsReceiver()
        ucrReceiverFactorDataFrame.SetIncludedDataTypes({"factor"})
        SetDefaults()
    End Sub
    Private Sub SetDefaults()
        chkAddCurrentContrast.Checked = True
        IncludeContrast()
        chkReplaceFactorSheet.Checked = False
        Replace()
        ucrSelectorFactorDataFrame.Reset()
        ucrInputFactorNames.ResetText()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactorDataFrame.IsEmpty AndAlso Not ucrInputFactorNames.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorFactorDataFrame_DataFrameChanged() Handles ucrSelectorFactorDataFrame.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorFactorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub chkAddCurrentContrast_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddCurrentContrast.CheckedChanged
        IncludeContrast()
    End Sub
    Private Sub IncludeContrast()
        If chkAddCurrentContrast.Checked Then
            ucrBase.clsRsyntax.AddParameter("include_contrasts", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("include_contrasts", "FALSE")
        End If
    End Sub

    Private Sub chkReplaceFactorSheet_CheckedChanged(sender As Object, e As EventArgs) Handles chkReplaceFactorSheet.CheckedChanged
        Replace()
    End Sub

    Private Sub Replace()
        If chkReplaceFactorSheet.Checked Then
            ucrBase.clsRsyntax.AddParameter("replace", "FALSE")
        Else
            ucrBase.clsRsyntax.AddParameter("replace", "TRUE")
        End If
    End Sub

    Private Sub ucrReceiverFactorDataFrame_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactorDataFrame.SelectionChanged
        FactorVariable()
        TestOKEnabled()
    End Sub

    Private Sub FactorVariable()
        If Not ucrReceiverFactorDataFrame.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("factor", ucrReceiverFactorDataFrame.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("factor")
        End If
    End Sub

    Private Sub FactorDataFrameName()
        If Not ucrInputFactorNames.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("factor_data_frame_name", Chr(34) & ucrInputFactorNames.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("factor_data_frame_name")
        End If
    End Sub

    Private Sub ucrInputFactorNames_ContentsChanged() Handles ucrInputFactorNames.ContentsChanged
        FactorDataFrameName()
        TestOKEnabled()
    End Sub
End Class